using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utilities.Security;

namespace D2Packets.BattleNet
{
	// Token: 0x02000ABA RID: 2746
	public class LogonC2S : Packet
	{
		// Token: 0x0600BC03 RID: 48131 RVA: 0x00474269 File Offset: 0x00472469
		public LogonC2S()
		{
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x0047428C File Offset: 0x0047248C
		public LogonC2S(string account, string password, uint client, uint server)
		{
			this.ClientToken = client;
			this.ServerToken = server;
			this.Account = account;
			MemoryStream memoryStream = new MemoryStream(28);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			byte[] array = XSha1.CalculateHash(Encoding.ASCII.GetBytes(password));
			binaryWriter.Write(client);
			binaryWriter.Write(server);
			binaryWriter.Write(array);
			byte[] buffer = memoryStream.GetBuffer();
			this.PasswordHash = XSha1.CalculateHash(buffer).ToList<byte>();
		}

		// Token: 0x040090A2 RID: 37026
		public byte FF = byte.MaxValue;

		// Token: 0x040090A3 RID: 37027
		public BattleNetPacket PacketId;

		// Token: 0x040090A4 RID: 37028
		public ushort Length;

		// Token: 0x040090A5 RID: 37029
		public uint ClientToken;

		// Token: 0x040090A6 RID: 37030
		public uint ServerToken;

		// Token: 0x040090A7 RID: 37031
		public List<byte> PasswordHash = new List<byte>(20);

		// Token: 0x040090A8 RID: 37032
		public string Account;
	}
}
