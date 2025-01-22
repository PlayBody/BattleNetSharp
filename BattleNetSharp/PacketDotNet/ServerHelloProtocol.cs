using System;
using System.Linq;
using PacketDotNet.Utils.Converters;

namespace PacketDotNet
{
	// Token: 0x0200082B RID: 2091
	public class ServerHelloProtocol : HandshakeProtocol
	{
		// Token: 0x0600B571 RID: 46449 RVA: 0x002C3CA8 File Offset: 0x002C1EA8
		public ServerHelloProtocol(byte[] bytes)
			: base(bytes)
		{
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600B572 RID: 46450 RVA: 0x002C3CB3 File Offset: 0x002C1EB3
		// (set) Token: 0x0600B573 RID: 46451 RVA: 0x002C3CC6 File Offset: 0x002C1EC6
		public ushort Version
		{
			get
			{
				return EndianBitConverter.Big.ToUInt16(this.Bytes, 4);
			}
			set
			{
				EndianBitConverter.Big.CopyBytes(value, this.Bytes, 4);
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600B574 RID: 46452 RVA: 0x002C3CDB File Offset: 0x002C1EDB
		public TlsRandom Random
		{
			get
			{
				return new TlsRandom(this.Bytes.Skip(6).ToArray<byte>());
			}
		}
	}
}
