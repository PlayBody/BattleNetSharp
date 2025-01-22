using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utilities.Security;

namespace D2Packets.BattleNet
{
	// Token: 0x02000AC3 RID: 2755
	public class RealmLogonC2S : Packet
	{
		// Token: 0x0600BC11 RID: 48145 RVA: 0x00474709 File Offset: 0x00472909
		public RealmLogonC2S()
		{
		}

		// Token: 0x0600BC12 RID: 48146 RVA: 0x0047472C File Offset: 0x0047292C
		public RealmLogonC2S(string realm, uint client, uint server)
		{
			this.ClientToken = client;
			this.RealmTitle = realm;
			MemoryStream memoryStream = new MemoryStream(28);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			byte[] array = XSha1.CalculateHash(Encoding.ASCII.GetBytes("password"));
			binaryWriter.Write(client);
			binaryWriter.Write(server);
			binaryWriter.Write(array);
			byte[] buffer = memoryStream.GetBuffer();
			this.PasswordHash = XSha1.CalculateHash(buffer).ToList<byte>();
		}

		// Token: 0x040090D1 RID: 37073
		public byte FF = byte.MaxValue;

		// Token: 0x040090D2 RID: 37074
		public BattleNetPacket PacketId;

		// Token: 0x040090D3 RID: 37075
		public ushort Length;

		// Token: 0x040090D4 RID: 37076
		public uint ClientToken;

		// Token: 0x040090D5 RID: 37077
		public List<byte> PasswordHash = new List<byte>(20);

		// Token: 0x040090D6 RID: 37078
		public string RealmTitle;
	}
}
