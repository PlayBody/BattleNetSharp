using System;
using System.Linq;
using PacketDotNet.Utils.Converters;

namespace PacketDotNet
{
	// Token: 0x02000827 RID: 2087
	public class TlsRecordLayer
	{
		// Token: 0x0600B55C RID: 46428 RVA: 0x002C3AD3 File Offset: 0x002C1CD3
		public TlsRecordLayer(byte[] bytes)
		{
			this.Bytes = bytes;
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600B55D RID: 46429 RVA: 0x002C3AE4 File Offset: 0x002C1CE4
		// (set) Token: 0x0600B55E RID: 46430 RVA: 0x002C3AEE File Offset: 0x002C1CEE
		public ContentType ContentType
		{
			get
			{
				return (ContentType)this.Bytes[0];
			}
			set
			{
				this.Bytes[0] = (byte)value;
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600B55F RID: 46431 RVA: 0x002C3AF9 File Offset: 0x002C1CF9
		// (set) Token: 0x0600B560 RID: 46432 RVA: 0x002C3B0C File Offset: 0x002C1D0C
		public ushort Version
		{
			get
			{
				return EndianBitConverter.Big.ToUInt16(this.Bytes, 1);
			}
			set
			{
				EndianBitConverter.Big.CopyBytes(value, this.Bytes, 1);
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600B561 RID: 46433 RVA: 0x002C3B21 File Offset: 0x002C1D21
		public ushort TotalLength
		{
			get
			{
				return this.Length + 5;
			}
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x002C3B2C File Offset: 0x002C1D2C
		// (set) Token: 0x0600B563 RID: 46435 RVA: 0x002C3B43 File Offset: 0x002C1D43
		public ushort Length
		{
			get
			{
				return EndianBitConverter.Big.ToUInt16(this.Bytes, TlsFields.DataOffsetPosition);
			}
			set
			{
				EndianBitConverter.Big.CopyBytes(value, this.Bytes, TlsFields.DataOffsetPosition);
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600B564 RID: 46436 RVA: 0x002C3B5C File Offset: 0x002C1D5C
		public byte[] Data
		{
			get
			{
				return this.Bytes.Skip(5).Take((int)this.Length).ToArray<byte>();
			}
		}

		// Token: 0x04005B49 RID: 23369
		public byte[] Bytes;
	}
}
