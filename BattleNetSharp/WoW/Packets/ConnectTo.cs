using System;
using System.Collections.Generic;
using System.Net;

namespace WoW.Packets
{
	// Token: 0x02000814 RID: 2068
	public class ConnectTo : ServerPacket
	{
		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600B543 RID: 46403 RVA: 0x002C33D8 File Offset: 0x002C15D8
		public IPAddress IPAddress
		{
			get
			{
				return new IPAddress(this.IPv4.ToArray());
			}
		}

		// Token: 0x04005AB9 RID: 23225
		public List<byte> Signature = new List<byte>(256);

		// Token: 0x04005ABA RID: 23226
		public ConnectTo.AddressType Type;

		// Token: 0x04005ABB RID: 23227
		public List<byte> IPv4 = new List<byte>(4);

		// Token: 0x04005ABC RID: 23228
		public ushort Port;

		// Token: 0x04005ABD RID: 23229
		public ConnectTo.ConnectToSerial Serial;

		// Token: 0x04005ABE RID: 23230
		public byte Con;

		// Token: 0x04005ABF RID: 23231
		public List<byte> Key = new List<byte>(8);

		// Token: 0x020012E2 RID: 4834
		public enum AddressType : byte
		{
			// Token: 0x04009C5C RID: 40028
			IPv4 = 1,
			// Token: 0x04009C5D RID: 40029
			IPv6,
			// Token: 0x04009C5E RID: 40030
			NamedSocket
		}

		// Token: 0x020012E3 RID: 4835
		public enum ConnectToSerial : uint
		{
			// Token: 0x04009C60 RID: 40032
			None,
			// Token: 0x04009C61 RID: 40033
			Realm = 14U,
			// Token: 0x04009C62 RID: 40034
			WorldAttempt1 = 17U,
			// Token: 0x04009C63 RID: 40035
			WorldAttempt2 = 35U,
			// Token: 0x04009C64 RID: 40036
			WorldAttempt3 = 53U,
			// Token: 0x04009C65 RID: 40037
			WorldAttempt4 = 71U,
			// Token: 0x04009C66 RID: 40038
			WorldAttempt5 = 89U
		}
	}
}
