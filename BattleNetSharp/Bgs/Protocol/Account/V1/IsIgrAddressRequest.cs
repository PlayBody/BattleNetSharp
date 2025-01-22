using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000715 RID: 1813
	public sealed class IsIgrAddressRequest : IMessage<IsIgrAddressRequest>, IMessage, IEquatable<IsIgrAddressRequest>, IDeepCloneable<IsIgrAddressRequest>, IBufferMessage
	{
		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600A621 RID: 42529 RVA: 0x002871BC File Offset: 0x002853BC
		[DebuggerNonUserCode]
		public static MessageParser<IsIgrAddressRequest> Parser
		{
			get
			{
				return IsIgrAddressRequest._parser;
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600A622 RID: 42530 RVA: 0x002871D4 File Offset: 0x002853D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600A623 RID: 42531 RVA: 0x002871F8 File Offset: 0x002853F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IsIgrAddressRequest.Descriptor;
			}
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x0028720F File Offset: 0x0028540F
		[DebuggerNonUserCode]
		public IsIgrAddressRequest()
		{
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x00287219 File Offset: 0x00285419
		[DebuggerNonUserCode]
		public IsIgrAddressRequest(IsIgrAddressRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientAddress_ = other.clientAddress_;
			this.region_ = other.region_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x00287258 File Offset: 0x00285458
		[DebuggerNonUserCode]
		public IsIgrAddressRequest Clone()
		{
			return new IsIgrAddressRequest(this);
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x00287270 File Offset: 0x00285470
		// (set) Token: 0x0600A628 RID: 42536 RVA: 0x00287291 File Offset: 0x00285491
		[DebuggerNonUserCode]
		public string ClientAddress
		{
			get
			{
				return this.clientAddress_ ?? IsIgrAddressRequest.ClientAddressDefaultValue;
			}
			set
			{
				this.clientAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600A629 RID: 42537 RVA: 0x002872A8 File Offset: 0x002854A8
		[DebuggerNonUserCode]
		public bool HasClientAddress
		{
			get
			{
				return this.clientAddress_ != null;
			}
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x002872C3 File Offset: 0x002854C3
		[DebuggerNonUserCode]
		public void ClearClientAddress()
		{
			this.clientAddress_ = null;
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600A62B RID: 42539 RVA: 0x002872D0 File Offset: 0x002854D0
		// (set) Token: 0x0600A62C RID: 42540 RVA: 0x00287301 File Offset: 0x00285501
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = IsIgrAddressRequest.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.region_ = value;
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600A62D RID: 42541 RVA: 0x0028731C File Offset: 0x0028551C
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x00287339 File Offset: 0x00285539
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x0028734C File Offset: 0x0028554C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IsIgrAddressRequest);
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x0028736C File Offset: 0x0028556C
		[DebuggerNonUserCode]
		public bool Equals(IsIgrAddressRequest other)
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
					bool flag4 = this.ClientAddress != other.ClientAddress;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Region != other.Region;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x002873E0 File Offset: 0x002855E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num ^= this.ClientAddress.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x0028744C File Offset: 0x0028564C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x00287464 File Offset: 0x00285664
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x00287470 File Offset: 0x00285670
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClientAddress);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x002874E0 File Offset: 0x002856E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x0028754C File Offset: 0x0028574C
		[DebuggerNonUserCode]
		public void MergeFrom(IsIgrAddressRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientAddress = other.HasClientAddress;
				if (hasClientAddress)
				{
					this.ClientAddress = other.ClientAddress;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x002875AE File Offset: 0x002857AE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x002875BC File Offset: 0x002857BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Region = input.ReadUInt32();
					}
				}
				else
				{
					this.ClientAddress = input.ReadString();
				}
			}
		}

		// Token: 0x04004AA9 RID: 19113
		private static readonly MessageParser<IsIgrAddressRequest> _parser = new MessageParser<IsIgrAddressRequest>(() => new IsIgrAddressRequest());

		// Token: 0x04004AAA RID: 19114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AAB RID: 19115
		private int _hasBits0;

		// Token: 0x04004AAC RID: 19116
		public const int ClientAddressFieldNumber = 1;

		// Token: 0x04004AAD RID: 19117
		private static readonly string ClientAddressDefaultValue = "";

		// Token: 0x04004AAE RID: 19118
		private string clientAddress_;

		// Token: 0x04004AAF RID: 19119
		public const int RegionFieldNumber = 2;

		// Token: 0x04004AB0 RID: 19120
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004AB1 RID: 19121
		private uint region_;
	}
}
