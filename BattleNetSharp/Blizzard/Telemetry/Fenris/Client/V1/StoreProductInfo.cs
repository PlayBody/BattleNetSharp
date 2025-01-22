using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000312 RID: 786
	public sealed class StoreProductInfo : IMessage<StoreProductInfo>, IMessage, IEquatable<StoreProductInfo>, IDeepCloneable<StoreProductInfo>, IBufferMessage
	{
		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x060052C9 RID: 21193 RVA: 0x0013FD04 File Offset: 0x0013DF04
		[DebuggerNonUserCode]
		public static MessageParser<StoreProductInfo> Parser
		{
			get
			{
				return StoreProductInfo._parser;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x060052CA RID: 21194 RVA: 0x0013FD1C File Offset: 0x0013DF1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreProductInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x0013FD40 File Offset: 0x0013DF40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoreProductInfo.Descriptor;
			}
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x0013FD57 File Offset: 0x0013DF57
		[DebuggerNonUserCode]
		public StoreProductInfo()
		{
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x0013FD64 File Offset: 0x0013DF64
		[DebuggerNonUserCode]
		public StoreProductInfo(StoreProductInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.productId_ = other.productId_;
			this.productName_ = other.productName_;
			this.numberOfOwnedSubitems_ = other.numberOfOwnedSubitems_;
			this.currentDiscount_ = other.currentDiscount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0013FDC8 File Offset: 0x0013DFC8
		[DebuggerNonUserCode]
		public StoreProductInfo Clone()
		{
			return new StoreProductInfo(this);
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x060052CF RID: 21199 RVA: 0x0013FDE0 File Offset: 0x0013DFE0
		// (set) Token: 0x060052D0 RID: 21200 RVA: 0x0013FE11 File Offset: 0x0013E011
		[DebuggerNonUserCode]
		public long ProductId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long productIdDefaultValue;
				if (flag)
				{
					productIdDefaultValue = this.productId_;
				}
				else
				{
					productIdDefaultValue = StoreProductInfo.ProductIdDefaultValue;
				}
				return productIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.productId_ = value;
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x060052D1 RID: 21201 RVA: 0x0013FE2C File Offset: 0x0013E02C
		[DebuggerNonUserCode]
		public bool HasProductId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x0013FE49 File Offset: 0x0013E049
		[DebuggerNonUserCode]
		public void ClearProductId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x060052D3 RID: 21203 RVA: 0x0013FE5C File Offset: 0x0013E05C
		// (set) Token: 0x060052D4 RID: 21204 RVA: 0x0013FE7D File Offset: 0x0013E07D
		[DebuggerNonUserCode]
		public string ProductName
		{
			get
			{
				return this.productName_ ?? StoreProductInfo.ProductNameDefaultValue;
			}
			set
			{
				this.productName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x060052D5 RID: 21205 RVA: 0x0013FE94 File Offset: 0x0013E094
		[DebuggerNonUserCode]
		public bool HasProductName
		{
			get
			{
				return this.productName_ != null;
			}
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x0013FEAF File Offset: 0x0013E0AF
		[DebuggerNonUserCode]
		public void ClearProductName()
		{
			this.productName_ = null;
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x060052D7 RID: 21207 RVA: 0x0013FEBC File Offset: 0x0013E0BC
		// (set) Token: 0x060052D8 RID: 21208 RVA: 0x0013FEED File Offset: 0x0013E0ED
		[DebuggerNonUserCode]
		public uint NumberOfOwnedSubitems
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint numberOfOwnedSubitemsDefaultValue;
				if (flag)
				{
					numberOfOwnedSubitemsDefaultValue = this.numberOfOwnedSubitems_;
				}
				else
				{
					numberOfOwnedSubitemsDefaultValue = StoreProductInfo.NumberOfOwnedSubitemsDefaultValue;
				}
				return numberOfOwnedSubitemsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.numberOfOwnedSubitems_ = value;
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x060052D9 RID: 21209 RVA: 0x0013FF08 File Offset: 0x0013E108
		[DebuggerNonUserCode]
		public bool HasNumberOfOwnedSubitems
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x0013FF25 File Offset: 0x0013E125
		[DebuggerNonUserCode]
		public void ClearNumberOfOwnedSubitems()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x060052DB RID: 21211 RVA: 0x0013FF38 File Offset: 0x0013E138
		// (set) Token: 0x060052DC RID: 21212 RVA: 0x0013FF69 File Offset: 0x0013E169
		[DebuggerNonUserCode]
		public float CurrentDiscount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float currentDiscountDefaultValue;
				if (flag)
				{
					currentDiscountDefaultValue = this.currentDiscount_;
				}
				else
				{
					currentDiscountDefaultValue = StoreProductInfo.CurrentDiscountDefaultValue;
				}
				return currentDiscountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.currentDiscount_ = value;
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x060052DD RID: 21213 RVA: 0x0013FF84 File Offset: 0x0013E184
		[DebuggerNonUserCode]
		public bool HasCurrentDiscount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x0013FFA1 File Offset: 0x0013E1A1
		[DebuggerNonUserCode]
		public void ClearCurrentDiscount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x0013FFB4 File Offset: 0x0013E1B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoreProductInfo);
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x0013FFD4 File Offset: 0x0013E1D4
		[DebuggerNonUserCode]
		public bool Equals(StoreProductInfo other)
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
					bool flag4 = this.ProductId != other.ProductId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ProductName != other.ProductName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.NumberOfOwnedSubitems != other.NumberOfOwnedSubitems;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CurrentDiscount, other.CurrentDiscount);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x0014008C File Offset: 0x0013E28C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProductId = this.HasProductId;
			if (hasProductId)
			{
				num ^= this.ProductId.GetHashCode();
			}
			bool hasProductName = this.HasProductName;
			if (hasProductName)
			{
				num ^= this.ProductName.GetHashCode();
			}
			bool hasNumberOfOwnedSubitems = this.HasNumberOfOwnedSubitems;
			if (hasNumberOfOwnedSubitems)
			{
				num ^= this.NumberOfOwnedSubitems.GetHashCode();
			}
			bool hasCurrentDiscount = this.HasCurrentDiscount;
			if (hasCurrentDiscount)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.CurrentDiscount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00140134 File Offset: 0x0013E334
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x0014014C File Offset: 0x0013E34C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00140158 File Offset: 0x0013E358
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProductId = this.HasProductId;
			if (hasProductId)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ProductId);
			}
			bool hasProductName = this.HasProductName;
			if (hasProductName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ProductName);
			}
			bool hasNumberOfOwnedSubitems = this.HasNumberOfOwnedSubitems;
			if (hasNumberOfOwnedSubitems)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.NumberOfOwnedSubitems);
			}
			bool hasCurrentDiscount = this.HasCurrentDiscount;
			if (hasCurrentDiscount)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.CurrentDiscount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x0014020C File Offset: 0x0013E40C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProductId = this.HasProductId;
			if (hasProductId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ProductId);
			}
			bool hasProductName = this.HasProductName;
			if (hasProductName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ProductName);
			}
			bool hasNumberOfOwnedSubitems = this.HasNumberOfOwnedSubitems;
			if (hasNumberOfOwnedSubitems)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NumberOfOwnedSubitems);
			}
			bool hasCurrentDiscount = this.HasCurrentDiscount;
			if (hasCurrentDiscount)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x001402A8 File Offset: 0x0013E4A8
		[DebuggerNonUserCode]
		public void MergeFrom(StoreProductInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProductId = other.HasProductId;
				if (hasProductId)
				{
					this.ProductId = other.ProductId;
				}
				bool hasProductName = other.HasProductName;
				if (hasProductName)
				{
					this.ProductName = other.ProductName;
				}
				bool hasNumberOfOwnedSubitems = other.HasNumberOfOwnedSubitems;
				if (hasNumberOfOwnedSubitems)
				{
					this.NumberOfOwnedSubitems = other.NumberOfOwnedSubitems;
				}
				bool hasCurrentDiscount = other.HasCurrentDiscount;
				if (hasCurrentDiscount)
				{
					this.CurrentDiscount = other.CurrentDiscount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0014033E File Offset: 0x0013E53E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0014034C File Offset: 0x0013E54C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0028;
						}
						this.ProductName = input.ReadString();
					}
					else
					{
						this.ProductId = input.ReadInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 37U)
					{
						goto IL_0028;
					}
					this.CurrentDiscount = input.ReadFloat();
				}
				else
				{
					this.NumberOfOwnedSubitems = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002590 RID: 9616
		private static readonly MessageParser<StoreProductInfo> _parser = new MessageParser<StoreProductInfo>(() => new StoreProductInfo());

		// Token: 0x04002591 RID: 9617
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002592 RID: 9618
		private int _hasBits0;

		// Token: 0x04002593 RID: 9619
		public const int ProductIdFieldNumber = 1;

		// Token: 0x04002594 RID: 9620
		private static readonly long ProductIdDefaultValue = 0L;

		// Token: 0x04002595 RID: 9621
		private long productId_;

		// Token: 0x04002596 RID: 9622
		public const int ProductNameFieldNumber = 2;

		// Token: 0x04002597 RID: 9623
		private static readonly string ProductNameDefaultValue = "";

		// Token: 0x04002598 RID: 9624
		private string productName_;

		// Token: 0x04002599 RID: 9625
		public const int NumberOfOwnedSubitemsFieldNumber = 3;

		// Token: 0x0400259A RID: 9626
		private static readonly uint NumberOfOwnedSubitemsDefaultValue = 0U;

		// Token: 0x0400259B RID: 9627
		private uint numberOfOwnedSubitems_;

		// Token: 0x0400259C RID: 9628
		public const int CurrentDiscountFieldNumber = 4;

		// Token: 0x0400259D RID: 9629
		private static readonly float CurrentDiscountDefaultValue = 0f;

		// Token: 0x0400259E RID: 9630
		private float currentDiscount_;
	}
}
