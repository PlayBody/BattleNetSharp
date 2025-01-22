using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000ABE RID: 2750
	public class NotifyJoinC2S : Packet
	{
		// Token: 0x0600BC09 RID: 48137 RVA: 0x004744C6 File Offset: 0x004726C6
		public NotifyJoinC2S()
		{
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x004744F1 File Offset: 0x004726F1
		public NotifyJoinC2S(string name, string password)
		{
			this.Name = name;
			this.Password = password;
		}

		// Token: 0x040090B9 RID: 37049
		public byte FF = byte.MaxValue;

		// Token: 0x040090BA RID: 37050
		public BattleNetPacket PacketId;

		// Token: 0x040090BB RID: 37051
		public ushort Length;

		// Token: 0x040090BC RID: 37052
		public uint Product = Versioning.Product;

		// Token: 0x040090BD RID: 37053
		public uint Version = Versioning.Version;

		// Token: 0x040090BE RID: 37054
		public string Name;

		// Token: 0x040090BF RID: 37055
		public string Password;
	}
}
