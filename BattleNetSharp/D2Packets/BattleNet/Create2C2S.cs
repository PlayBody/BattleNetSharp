using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utilities.Security;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AAC RID: 2732
	public class Create2C2S : Packet
	{
		// Token: 0x0600BBF4 RID: 48116 RVA: 0x00474078 File Offset: 0x00472278
		public Create2C2S(string account, string password)
		{
			this.Account = account;
			MemoryStream memoryStream = new MemoryStream(28);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			this.PasswordHash = XSha1.CalculateHash(Encoding.ASCII.GetBytes(password)).ToList<byte>();
		}

		// Token: 0x0400905E RID: 36958
		public byte FF = byte.MaxValue;

		// Token: 0x0400905F RID: 36959
		public BattleNetPacket PacketId;

		// Token: 0x04009060 RID: 36960
		public ushort Length;

		// Token: 0x04009061 RID: 36961
		public List<byte> PasswordHash;

		// Token: 0x04009062 RID: 36962
		public string Account;
	}
}
