using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.License
{
	// Token: 0x02000159 RID: 345
	public sealed class Entitlement : IMessage<Entitlement>, IMessage, IEquatable<Entitlement>, IDeepCloneable<Entitlement>, IBufferMessage
	{
		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x0008A3D4 File Offset: 0x000885D4
		[DebuggerNonUserCode]
		public static MessageParser<Entitlement> Parser
		{
			get
			{
				return Entitlement._parser;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x0008A3EC File Offset: 0x000885EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LicenseReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0008A410 File Offset: 0x00088610
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Entitlement.Descriptor;
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0008A427 File Offset: 0x00088627
		[DebuggerNonUserCode]
		public Entitlement()
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0008A431 File Offset: 0x00088631
		[DebuggerNonUserCode]
		public Entitlement(Entitlement other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.contentLicenseId_ = other.contentLicenseId_;
			this.productSno_ = other.productSno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0008A470 File Offset: 0x00088670
		[DebuggerNonUserCode]
		public Entitlement Clone()
		{
			return new Entitlement(this);
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x0008A488 File Offset: 0x00088688
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x0008A4B9 File Offset: 0x000886B9
		[DebuggerNonUserCode]
		public int ContentLicenseId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int contentLicenseIdDefaultValue;
				if (flag)
				{
					contentLicenseIdDefaultValue = this.contentLicenseId_;
				}
				else
				{
					contentLicenseIdDefaultValue = Entitlement.ContentLicenseIdDefaultValue;
				}
				return contentLicenseIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.contentLicenseId_ = value;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x0008A4D4 File Offset: 0x000886D4
		[DebuggerNonUserCode]
		public bool HasContentLicenseId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0008A4F1 File Offset: 0x000886F1
		[DebuggerNonUserCode]
		public void ClearContentLicenseId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0008A504 File Offset: 0x00088704
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x0008A535 File Offset: 0x00088735
		[DebuggerNonUserCode]
		public int ProductSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int productSnoDefaultValue;
				if (flag)
				{
					productSnoDefaultValue = this.productSno_;
				}
				else
				{
					productSnoDefaultValue = Entitlement.ProductSnoDefaultValue;
				}
				return productSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.productSno_ = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0008A550 File Offset: 0x00088750
		[DebuggerNonUserCode]
		public bool HasProductSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0008A56D File Offset: 0x0008876D
		[DebuggerNonUserCode]
		public void ClearProductSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0008A580 File Offset: 0x00088780
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Entitlement);
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x0008A5A0 File Offset: 0x000887A0
		[DebuggerNonUserCode]
		public bool Equals(Entitlement other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = this.ContentLicenseId != other.ContentLicenseId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ProductSno != other.ProductSno;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0008A614 File Offset: 0x00088814
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContentLicenseId = this.HasContentLicenseId;
			if (hasContentLicenseId)
			{
				num ^= this.ContentLicenseId.GetHashCode();
			}
			bool hasProductSno = this.HasProductSno;
			if (hasProductSno)
			{
				num ^= this.ProductSno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0008A680 File Offset: 0x00088880
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0008A698 File Offset: 0x00088898
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0008A6A4 File Offset: 0x000888A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContentLicenseId = this.HasContentLicenseId;
			if (hasContentLicenseId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ContentLicenseId);
			}
			bool hasProductSno = this.HasProductSno;
			if (hasProductSno)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ProductSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0008A714 File Offset: 0x00088914
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContentLicenseId = this.HasContentLicenseId;
			if (hasContentLicenseId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ContentLicenseId);
			}
			bool hasProductSno = this.HasProductSno;
			if (hasProductSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ProductSno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0008A780 File Offset: 0x00088980
		[DebuggerNonUserCode]
		public void MergeFrom(Entitlement other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContentLicenseId = other.HasContentLicenseId;
				if (hasContentLicenseId)
				{
					this.ContentLicenseId = other.ContentLicenseId;
				}
				bool hasProductSno = other.HasProductSno;
				if (hasProductSno)
				{
					this.ProductSno = other.ProductSno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0008A7E2 File Offset: 0x000889E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0008A7F0 File Offset: 0x000889F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ProductSno = input.ReadInt32();
					}
				}
				else
				{
					this.ContentLicenseId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000FA4 RID: 4004
		private static readonly MessageParser<Entitlement> _parser = new MessageParser<Entitlement>(() => new Entitlement());

		// Token: 0x04000FA5 RID: 4005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FA6 RID: 4006
		private int _hasBits0;

		// Token: 0x04000FA7 RID: 4007
		public const int ContentLicenseIdFieldNumber = 1;

		// Token: 0x04000FA8 RID: 4008
		private static readonly int ContentLicenseIdDefaultValue = -1;

		// Token: 0x04000FA9 RID: 4009
		private int contentLicenseId_;

		// Token: 0x04000FAA RID: 4010
		public const int ProductSnoFieldNumber = 2;

		// Token: 0x04000FAB RID: 4011
		private static readonly int ProductSnoDefaultValue = -1;

		// Token: 0x04000FAC RID: 4012
		private int productSno_;
	}
}
