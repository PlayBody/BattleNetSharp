using System;
using System.Collections.Generic;

namespace D2Packets.Game.Client
{
	// Token: 0x02000A7E RID: 2686
	public class UseItem : Packet
	{
		// Token: 0x04008F35 RID: 36661
		public GameClientPacket PacketId;

		// Token: 0x04008F36 RID: 36662
		[MaxVersion(GameVersion.LOD)]
		public uint Id;

		// Token: 0x04008F37 RID: 36663
		[MaxVersion(GameVersion.LOD)]
		public UseItem.Location Character;

		// Token: 0x04008F38 RID: 36664
		[MaxVersion(GameVersion.LOD)]
		public uint Unk = 0U;

		// Token: 0x04008F39 RID: 36665
		[MinVersion(GameVersion.D2R)]
		public byte Consume;

		// Token: 0x04008F3A RID: 36666
		[MinVersion(GameVersion.D2R)]
		public uint PlayerId;

		// Token: 0x04008F3B RID: 36667
		[MinVersion(GameVersion.D2R)]
		public byte isMerc = 0;

		// Token: 0x04008F3C RID: 36668
		[MinVersion(GameVersion.D2R)]
		public byte xff = byte.MaxValue;

		// Token: 0x04008F3D RID: 36669
		[MinVersion(GameVersion.D2R)]
		public byte TargetX;

		// Token: 0x04008F3E RID: 36670
		[MinVersion(GameVersion.D2R)]
		public byte TargetY;

		// Token: 0x04008F3F RID: 36671
		[MinVersion(GameVersion.D2R)]
		public uint ItemId;

		// Token: 0x04008F40 RID: 36672
		[MinVersion(GameVersion.D2R)]
		public ushort xff02ifbelt;

		// Token: 0x04008F41 RID: 36673
		[MinVersion(GameVersion.D2R)]
		public byte X;

		// Token: 0x04008F42 RID: 36674
		[MinVersion(GameVersion.D2R)]
		public byte Y;

		// Token: 0x04008F43 RID: 36675
		[MinVersion(GameVersion.D2R)]
		public List<UseItem.PotLocation> Pots = new List<UseItem.PotLocation>
		{
			new UseItem.PotLocation(),
			new UseItem.PotLocation(),
			new UseItem.PotLocation()
		};

		// Token: 0x0200137D RID: 4989
		public class PotLocation : Packet
		{
			// Token: 0x04009EF6 RID: 40694
			public uint Id = uint.MaxValue;

			// Token: 0x04009EF7 RID: 40695
			public byte PrevPos;

			// Token: 0x04009EF8 RID: 40696
			public byte NewPos;
		}

		// Token: 0x0200137E RID: 4990
		public enum Location : uint
		{
			// Token: 0x04009EFA RID: 40698
			Player,
			// Token: 0x04009EFB RID: 40699
			Mercenary
		}
	}
}
