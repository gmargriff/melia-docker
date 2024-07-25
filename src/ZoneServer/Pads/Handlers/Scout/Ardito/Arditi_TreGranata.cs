﻿using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Pads.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Arditi_TreGranata pad, creates and disables the effect
	/// </summary>
	[PadHandler("Arditi_TreGranata")]
	public class Arditi_TreGranata : ICreatePadHandler, IDestroyPadHandler
	{
		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Arditi_TreGranata", 0, 0, 150, true);
		}

		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			Send.ZC_NORMAL.PadUpdate(creator, pad, "Arditi_TreGranata", 0, 0, 150, false);
		}
	}
}
