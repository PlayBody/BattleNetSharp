using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using D2Data;
using D2Map;
using D2Packets.Game.Server;

namespace D2GameState
{
	// Token: 0x0200090B RID: 2315
	public class Manager
	{
		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600B866 RID: 47206 RVA: 0x002DDD24 File Offset: 0x002DBF24
		public ItemAction MouseItem
		{
			get
			{
				return this.Items.FirstOrDefault((KeyValuePair<uint, ItemAction> it) => it.Value.destination == ItemDestination.Cursor).Value;
			}
		}

		// Token: 0x0600B867 RID: 47207 RVA: 0x002DDD68 File Offset: 0x002DBF68
		public Manager()
		{
			this.LevelData[AreaLevel.None] = new Level();
		}

		// Token: 0x04006A8E RID: 27278
		public ConcurrentDictionary<uint, Player> Players = new ConcurrentDictionary<uint, Player>();

		// Token: 0x04006A8F RID: 27279
		public ConcurrentDictionary<uint, AssignNPC> NPCs = new ConcurrentDictionary<uint, AssignNPC>();

		// Token: 0x04006A90 RID: 27280
		public ConcurrentDictionary<uint, AssignGameObject> GameObjects = new ConcurrentDictionary<uint, AssignGameObject>();

		// Token: 0x04006A91 RID: 27281
		public ConcurrentDictionary<uint, AssignWarp> Warps = new ConcurrentDictionary<uint, AssignWarp>();

		// Token: 0x04006A92 RID: 27282
		public ConcurrentDictionary<uint, ItemAction> Items = new ConcurrentDictionary<uint, ItemAction>();

		// Token: 0x04006A93 RID: 27283
		public ConcurrentDictionary<uint, PortalInfo> PortalsInfo = new ConcurrentDictionary<uint, PortalInfo>();

		// Token: 0x04006A94 RID: 27284
		public ConcurrentDictionary<uint, PortalOwnership> PortalsOwnership = new ConcurrentDictionary<uint, PortalOwnership>();

		// Token: 0x04006A95 RID: 27285
		public ConcurrentDictionary<uint, UpdatePlayerItemSkill> PlayerItemSkill = new ConcurrentDictionary<uint, UpdatePlayerItemSkill>();

		// Token: 0x04006A96 RID: 27286
		public ConcurrentDictionary<AreaLevel, Level> LevelData = new ConcurrentDictionary<AreaLevel, Level>();
	}
}
