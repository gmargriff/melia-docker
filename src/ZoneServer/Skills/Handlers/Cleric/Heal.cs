﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman
{
	/// <summary>
	/// Handler for the Cleric skill Heal.
	/// </summary>
	[SkillHandler(SkillId.Cleric_Heal)]
	public class Cleric_Heal : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos)
		{
			// Not sure if this is correct in any shape or form
			var spendSp = skill.Properties.GetFloat(PropertyName.SpendSP);
			var overloadBuffCount = caster.Components.Get<BuffCollection>().GetOverbuffCount(BuffId.Heal_Overload_Buff);
			spendSp += (spendSp * 0.5f * overloadBuffCount);

			if (!caster.TrySpendSp(spendSp))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			var targetHandle = caster.Handle; // Where does the target handle come from?
			var target = caster.Map.GetCombatEntity(targetHandle);

			Send.ZC_NORMAL.UpdateSkillEffect(caster, targetHandle, originPos, caster.Direction, Position.Zero);
			Send.ZC_NORMAL.PlayEffect(target, "F_cleric_heal_active_ground_new");

			// TODO: Do we actually need the Heal_Buff? Feels like we could
			//   just heal the target. But maybe there's a reason for it?
			var ratio2 = 150f + (skill.Level - 1) * 103f;
			var healDuration = TimeSpan.FromSeconds(1);
			var overloadDuration = TimeSpan.FromSeconds(3);

			target.Components.Get<BuffCollection>().Start(BuffId.Heal_Buff, ratio2, 0, healDuration, caster);
			caster.Components.Get<BuffCollection>().Start(BuffId.Heal_Overload_Buff, overloadDuration);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}
	}
}