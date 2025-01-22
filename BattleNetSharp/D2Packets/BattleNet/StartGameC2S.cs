using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC8 RID: 2760
	public class StartGameC2S : Packet
	{
		// Token: 0x0600BC17 RID: 48151 RVA: 0x0047483C File Offset: 0x00472A3C
		public StartGameC2S()
		{
		}

		// Token: 0x0600BC18 RID: 48152 RVA: 0x0047488C File Offset: 0x00472A8C
		public StartGameC2S(string name, string password)
		{
			this.Name = name;
			this.Password = password;
			this.State = 1U;
		}

		// Token: 0x040090EB RID: 37099
		public byte FF = byte.MaxValue;

		// Token: 0x040090EC RID: 37100
		public BattleNetPacket PacketId;

		// Token: 0x040090ED RID: 37101
		public ushort Length;

		// Token: 0x040090EE RID: 37102
		public uint State;

		// Token: 0x040090EF RID: 37103
		public uint Uptime = 0U;

		// Token: 0x040090F0 RID: 37104
		public ushort Type = 0;

		// Token: 0x040090F1 RID: 37105
		public ushort SubType = 0;

		// Token: 0x040090F2 RID: 37106
		public uint Provider = 0U;

		// Token: 0x040090F3 RID: 37107
		public uint Ladder = 0U;

		// Token: 0x040090F4 RID: 37108
		public string Name;

		// Token: 0x040090F5 RID: 37109
		public string Password;

		// Token: 0x040090F6 RID: 37110
		public string Statstring = "";

		// Token: 0x02001394 RID: 5012
		public enum GameState : uint
		{
			// Token: 0x04009F74 RID: 40820
			Private = 1U,
			// Token: 0x04009F75 RID: 40821
			Full,
			// Token: 0x04009F76 RID: 40822
			Others = 4U,
			// Token: 0x04009F77 RID: 40823
			Progress = 8U,
			// Token: 0x04009F78 RID: 40824
			Replay = 128U
		}
	}
}
