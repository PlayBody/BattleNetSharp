using System;
using PacketDotNet.Utils.Converters;

namespace PacketDotNet
{
	// Token: 0x02000829 RID: 2089
	public class HandshakeProtocol
	{
		// Token: 0x0600B567 RID: 46439 RVA: 0x002C3C04 File Offset: 0x002C1E04
		public HandshakeProtocol(byte[] bytes)
		{
			this.Bytes = bytes;
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600B568 RID: 46440 RVA: 0x002C3C15 File Offset: 0x002C1E15
		// (set) Token: 0x0600B569 RID: 46441 RVA: 0x002C3C1F File Offset: 0x002C1E1F
		public HandshakeType ContentType
		{
			get
			{
				return (HandshakeType)this.Bytes[0];
			}
			set
			{
				this.Bytes[0] = (byte)value;
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600B56A RID: 46442 RVA: 0x002C3C2A File Offset: 0x002C1E2A
		public ushort TotalLength
		{
			get
			{
				return this.Length + 4;
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600B56B RID: 46443 RVA: 0x002C3C35 File Offset: 0x002C1E35
		// (set) Token: 0x0600B56C RID: 46444 RVA: 0x002C3C48 File Offset: 0x002C1E48
		public ushort Length
		{
			get
			{
				return EndianBitConverter.Big.ToUInt16(this.Bytes, 2);
			}
			set
			{
				EndianBitConverter.Big.CopyBytes(value, this.Bytes, 2);
			}
		}

		// Token: 0x04005B4A RID: 23370
		public byte[] Bytes;
	}
}
