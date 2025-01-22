using System;

namespace D2Packets.Realm
{
	// Token: 0x02000A89 RID: 2697
	public class CharacterDeleteS2C : Packet
	{
		// Token: 0x04008F74 RID: 36724
		public ushort Length;

		// Token: 0x04008F75 RID: 36725
		public RealmPacket PacketId;

		// Token: 0x04008F76 RID: 36726
		public CharacterDeleteS2C.Result Status;

		// Token: 0x02001382 RID: 4994
		public enum Result : uint
		{
			// Token: 0x04009F05 RID: 40709
			Success,
			// Token: 0x04009F06 RID: 40710
			InvalidName = 73U
		}
	}
}
