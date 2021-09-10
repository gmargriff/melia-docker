﻿using Melia.Channel.Network;
using Melia.Channel.World.Entities;

namespace Melia.Channel.Scripting
{

	public class ScriptState
	{
		public ChannelConnection Connection { get; private set; }
		public LuaThread LuaThread { get; set; }
		public Monster CurrentNpc { get; set; }

		/// <summary>
		/// Name of the shop currently open, null if there is no shop.
		/// </summary>
		public string CurrentShop { get; set; }

		public ScriptState(ChannelConnection conn)
		{
			this.Connection = conn;
		}

		public void Reset()
		{
			ChannelServer.Instance.ScriptManager.RemoveThread(this.LuaThread);

			this.CurrentShop = null;
			this.CurrentNpc = null;
			this.LuaThread = null;
		}
	}
}
