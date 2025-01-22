using System;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AAD RID: 2733
	public class Create2S2C : Packet
	{
		// Token: 0x04009063 RID: 36963
		public byte FF = byte.MaxValue;

		// Token: 0x04009064 RID: 36964
		public BattleNetPacket PacketId;

		// Token: 0x04009065 RID: 36965
		public ushort Length;

		// Token: 0x04009066 RID: 36966
		public Create2S2C.CreateAccountStatus Status;

		// Token: 0x04009067 RID: 36967
		public string Info;

		// Token: 0x0200138E RID: 5006
		public enum CreateAccountStatus : uint
		{
			// Token: 0x04009F56 RID: 40790
			Success,
			// Token: 0x04009F57 RID: 40791
			TooShort,
			// Token: 0x04009F58 RID: 40792
			InvalidCharacters,
			// Token: 0x04009F59 RID: 40793
			BannedCharacters,
			// Token: 0x04009F5A RID: 40794
			AlreadyExists,
			// Token: 0x04009F5B RID: 40795
			InProcess,
			// Token: 0x04009F5C RID: 40796
			NotEnoughAlphaChars,
			// Token: 0x04009F5D RID: 40797
			AdjacentPunctuation,
			// Token: 0x04009F5E RID: 40798
			TooManyPunctuation
		}
	}
}
