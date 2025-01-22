using System;
using System.Collections.Generic;
using System.Linq;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AAB RID: 2731
	public class ChatEventS2C : Packet
	{
		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0600BBF0 RID: 48112 RVA: 0x00473FF7 File Offset: 0x004721F7
		// (set) Token: 0x0600BBF1 RID: 48113 RVA: 0x00473FFF File Offset: 0x004721FF
		public ChatEventS2C.StatString Stats { get; set; }

		// Token: 0x0600BBF2 RID: 48114 RVA: 0x00474008 File Offset: 0x00472208
		public override void FromBytes(byte[] Bytes)
		{
			base.FromBytes(Bytes);
			ushort length = this.Length;
			long numBytesRead = base.NumBytesRead;
			bool flag = this.EventId == ChatEventS2C.Event.Join;
			if (flag)
			{
				List<byte> list = Bytes.Skip(Bytes.Length - 34).ToList<byte>();
				this.Stats = new ChatEventS2C.StatString
				{
					Bytes = list
				};
			}
		}

		// Token: 0x04009052 RID: 36946
		public byte FF = byte.MaxValue;

		// Token: 0x04009053 RID: 36947
		public BattleNetPacket PacketId;

		// Token: 0x04009054 RID: 36948
		public ushort Length;

		// Token: 0x04009055 RID: 36949
		public ChatEventS2C.Event EventId;

		// Token: 0x04009056 RID: 36950
		public uint UserFlags;

		// Token: 0x04009057 RID: 36951
		public uint Ping;

		// Token: 0x04009058 RID: 36952
		public uint IpAddrDefunct;

		// Token: 0x04009059 RID: 36953
		public uint AccountIdDefunct;

		// Token: 0x0400905A RID: 36954
		public uint RegistrationAuthorityDefunct;

		// Token: 0x0400905B RID: 36955
		public string UserName;

		// Token: 0x0400905C RID: 36956
		public string Text;

		// Token: 0x0200138C RID: 5004
		public class StatString : Packet
		{
			// Token: 0x04009F41 RID: 40769
			public byte X84;

			// Token: 0x04009F42 RID: 40770
			public byte X80;
		}

		// Token: 0x0200138D RID: 5005
		public enum Event : uint
		{
			// Token: 0x04009F44 RID: 40772
			ShowUser = 1U,
			// Token: 0x04009F45 RID: 40773
			Join,
			// Token: 0x04009F46 RID: 40774
			Left,
			// Token: 0x04009F47 RID: 40775
			WhisperRecieved,
			// Token: 0x04009F48 RID: 40776
			Talk,
			// Token: 0x04009F49 RID: 40777
			ServerBroadcast,
			// Token: 0x04009F4A RID: 40778
			ChannelInformation,
			// Token: 0x04009F4B RID: 40779
			UserFlagsUpdate = 9U,
			// Token: 0x04009F4C RID: 40780
			WhisperSent,
			// Token: 0x04009F4D RID: 40781
			ChannelFull = 13U,
			// Token: 0x04009F4E RID: 40782
			ChannelInvalid,
			// Token: 0x04009F4F RID: 40783
			ChannelRestricted,
			// Token: 0x04009F50 RID: 40784
			Information = 18U,
			// Token: 0x04009F51 RID: 40785
			Error,
			// Token: 0x04009F52 RID: 40786
			Ignored = 21U,
			// Token: 0x04009F53 RID: 40787
			Unignored,
			// Token: 0x04009F54 RID: 40788
			Emote
		}
	}
}
