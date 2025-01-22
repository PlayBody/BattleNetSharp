using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AAF RID: 2735
	public class EnterChatC2S : Packet
	{
		// Token: 0x0600BBF7 RID: 48119 RVA: 0x0047411A File Offset: 0x0047231A
		public EnterChatC2S()
		{
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x0047412F File Offset: 0x0047232F
		public EnterChatC2S(string character, string realm)
		{
			this.CharName = character;
			this.RealmCharName = realm + "," + character;
		}

		// Token: 0x0400906F RID: 36975
		public byte FF = byte.MaxValue;

		// Token: 0x04009070 RID: 36976
		public BattleNetPacket PacketId;

		// Token: 0x04009071 RID: 36977
		public ushort Length;

		// Token: 0x04009072 RID: 36978
		public string CharName;

		// Token: 0x04009073 RID: 36979
		public string RealmCharName;
	}
}
