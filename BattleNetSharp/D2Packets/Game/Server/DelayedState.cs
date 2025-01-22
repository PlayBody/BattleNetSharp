using System;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x020009AD RID: 2477
	public class DelayedState : Packet
	{
		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0600BABA RID: 47802 RVA: 0x0046CCD8 File Offset: 0x0046AED8
		public BaseState StateProp
		{
			get
			{
				return BaseState.Get((int)this.StateLOD);
			}
		}

		// Token: 0x0400897C RID: 35196
		public GameServerPacket PacketId;

		// Token: 0x0400897D RID: 35197
		public UnitType Type;

		// Token: 0x0400897E RID: 35198
		[MinVersion(GameVersion.D2R)]
		public ushort StateD2R;

		// Token: 0x0400897F RID: 35199
		public uint Id;

		// Token: 0x04008980 RID: 35200
		[MaxVersion(GameVersion.LOD)]
		public byte StateLOD;
	}
}
