using System;
using System.Linq;
using PacketDotNet.Utils.Converters;

namespace PacketDotNet
{
	// Token: 0x0200082A RID: 2090
	public class ClientHelloProtocol : HandshakeProtocol
	{
		// Token: 0x0600B56D RID: 46445 RVA: 0x002C3C5D File Offset: 0x002C1E5D
		public ClientHelloProtocol(byte[] bytes)
			: base(bytes)
		{
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600B56E RID: 46446 RVA: 0x002C3C68 File Offset: 0x002C1E68
		// (set) Token: 0x0600B56F RID: 46447 RVA: 0x002C3C7B File Offset: 0x002C1E7B
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

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x002C3C90 File Offset: 0x002C1E90
		public TlsRandom Random
		{
			get
			{
				return new TlsRandom(this.Bytes.Skip(6).ToArray<byte>());
			}
		}
	}
}
