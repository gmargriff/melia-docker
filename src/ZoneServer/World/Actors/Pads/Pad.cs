﻿using System;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Actors.Pads.Components;
using Yggdrasil.Composition;
using Yggdrasil.Geometry;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Pads
{
	/// <summary>
	/// Represents a pad, which are zones on the map that trigger events.
	/// </summary>
	/// <remarks>
	/// The exact classification of pads is currently still in the air.
	/// We're considering them their own type of actor that are typically
	/// created by skills, though they might just as well be a type of
	/// monster.
	/// </remarks>
	public class Pad : Actor, IUpdateable
	{
		/// <summary>
		/// Gets or sets the pad's name.
		/// </summary>
		public override string Name { get; set; }

		/// <summary>
		/// Returns the actor that created the pad.
		/// </summary>
		public IActor Creator { get; }

		/// <summary>
		/// Returns the skill the pad was created by.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Returns the pad's area, defining the trigger zone.
		/// </summary>
		public IShapeF Area { get; }

		/// <summary>
		/// Gets or sets the pad's movement speed.
		/// </summary>
		public float Speed { get; set; } = 30;

		/// <summary>
		/// Returns the pad's components.
		/// </summary>
		public ComponentCollection Components { get; } = new();

		/// <summary>
		/// Returns the pad's variables.
		/// </summary>
		/// <remarks>
		/// This is a collection of variables that can be used to store temporary
		/// information about the pad. They are not saved and will be lost after
		/// the pad was destroyed.
		/// </remarks>
		public Variables Variables { get; } = new();

		/// <summary>
		/// Creates a new pad.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="creator"></param>
		/// <param name="skill"></param>
		/// <param name="triggerArea"></param>
		public Pad(string name, IActor creator, Skill skill, IShapeF triggerArea)
		{
			this.Name = name;
			this.Creator = creator;
			this.Skill = skill;
			this.Area = triggerArea;

			this.Position = creator.Position;
			this.Direction = creator.Direction;

			this.Components.Add(new PadMovementComponent(this));
			this.Components.Add(new TriggerComponent(this, triggerArea));
		}

		/// <summary>
		/// Called in regular intervals to update the pad and potentially raise
		/// its events.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Components.Update(elapsed);
		}

		/// <summary>
		/// Destroys the pad, triggering its Destroyed event and removing it from
		/// its current map.
		/// </summary>
		public void Destroy()
		{
			this.Map?.RemovePad(this);
		}
	}
}
