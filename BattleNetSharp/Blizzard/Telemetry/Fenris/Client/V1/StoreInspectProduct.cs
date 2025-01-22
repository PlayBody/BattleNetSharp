using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000310 RID: 784
	public sealed class StoreInspectProduct : IMessage<StoreInspectProduct>, IMessage, IEquatable<StoreInspectProduct>, IDeepCloneable<StoreInspectProduct>, IBufferMessage
	{
		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060052AE RID: 21166 RVA: 0x0013F650 File Offset: 0x0013D850
		[DebuggerNonUserCode]
		public static MessageParser<StoreInspectProduct> Parser
		{
			get
			{
				return StoreInspectProduct._parser;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x0013F668 File Offset: 0x0013D868
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreInspectProductReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x060052B0 RID: 21168 RVA: 0x0013F68C File Offset: 0x0013D88C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoreInspectProduct.Descriptor;
			}
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x0013F6A3 File Offset: 0x0013D8A3
		[DebuggerNonUserCode]
		public StoreInspectProduct()
		{
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0013F6B0 File Offset: 0x0013D8B0
		[DebuggerNonUserCode]
		public StoreInspectProduct(StoreInspectProduct other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this.productInfo_ = ((other.productInfo_ != null) ? other.productInfo_.Clone() : null);
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x0013F728 File Offset: 0x0013D928
		[DebuggerNonUserCode]
		public StoreInspectProduct Clone()
		{
			return new StoreInspectProduct(this);
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x060052B4 RID: 21172 RVA: 0x0013F740 File Offset: 0x0013D940
		// (set) Token: 0x060052B5 RID: 21173 RVA: 0x0013F758 File Offset: 0x0013D958
		[DebuggerNonUserCode]
		public StoreSessionInfo SessionInfo
		{
			get
			{
				return this.sessionInfo_;
			}
			set
			{
				this.sessionInfo_ = value;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x060052B6 RID: 21174 RVA: 0x0013F764 File Offset: 0x0013D964
		// (set) Token: 0x060052B7 RID: 21175 RVA: 0x0013F77C File Offset: 0x0013D97C
		[DebuggerNonUserCode]
		public StoreProductInfo ProductInfo
		{
			get
			{
				return this.productInfo_;
			}
			set
			{
				this.productInfo_ = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x060052B8 RID: 21176 RVA: 0x0013F788 File Offset: 0x0013D988
		// (set) Token: 0x060052B9 RID: 21177 RVA: 0x0013F7B9 File Offset: 0x0013D9B9
		[DebuggerNonUserCode]
		public long ItemId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long itemIdDefaultValue;
				if (flag)
				{
					itemIdDefaultValue = this.itemId_;
				}
				else
				{
					itemIdDefaultValue = StoreInspectProduct.ItemIdDefaultValue;
				}
				return itemIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.itemId_ = value;
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x0013F7D4 File Offset: 0x0013D9D4
		[DebuggerNonUserCode]
		public bool HasItemId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x0013F7F1 File Offset: 0x0013D9F1
		[DebuggerNonUserCode]
		public void ClearItemId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x0013F804 File Offset: 0x0013DA04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoreInspectProduct);
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x0013F824 File Offset: 0x0013DA24
		[DebuggerNonUserCode]
		public bool Equals(StoreInspectProduct other)
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
					bool flag4 = !object.Equals(this.SessionInfo, other.SessionInfo);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ProductInfo, other.ProductInfo);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ItemId != other.ItemId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x0013F8B8 File Offset: 0x0013DAB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num ^= this.SessionInfo.GetHashCode();
			}
			bool flag2 = this.productInfo_ != null;
			if (flag2)
			{
				num ^= this.ProductInfo.GetHashCode();
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num ^= this.ItemId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x0013F940 File Offset: 0x0013DB40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x0013F958 File Offset: 0x0013DB58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x0013F964 File Offset: 0x0013DB64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SessionInfo);
			}
			bool flag2 = this.productInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ProductInfo);
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ItemId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x0013F9FC File Offset: 0x0013DBFC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionInfo);
			}
			bool flag2 = this.productInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ProductInfo);
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ItemId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x0013FA8C File Offset: 0x0013DC8C
		[DebuggerNonUserCode]
		public void MergeFrom(StoreInspectProduct other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sessionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionInfo_ == null;
					if (flag3)
					{
						this.SessionInfo = new StoreSessionInfo();
					}
					this.SessionInfo.MergeFrom(other.SessionInfo);
				}
				bool flag4 = other.productInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.productInfo_ == null;
					if (flag5)
					{
						this.ProductInfo = new StoreProductInfo();
					}
					this.ProductInfo.MergeFrom(other.ProductInfo);
				}
				bool hasItemId = other.HasItemId;
				if (hasItemId)
				{
					this.ItemId = other.ItemId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x0013FB54 File Offset: 0x0013DD54
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x0013FB60 File Offset: 0x0013DD60
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemId = input.ReadInt64();
						}
					}
					else
					{
						bool flag = this.productInfo_ == null;
						if (flag)
						{
							this.ProductInfo = new StoreProductInfo();
						}
						input.ReadMessage(this.ProductInfo);
					}
				}
				else
				{
					bool flag2 = this.sessionInfo_ == null;
					if (flag2)
					{
						this.SessionInfo = new StoreSessionInfo();
					}
					input.ReadMessage(this.SessionInfo);
				}
			}
		}

		// Token: 0x04002585 RID: 9605
		private static readonly MessageParser<StoreInspectProduct> _parser = new MessageParser<StoreInspectProduct>(() => new StoreInspectProduct());

		// Token: 0x04002586 RID: 9606
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002587 RID: 9607
		private int _hasBits0;

		// Token: 0x04002588 RID: 9608
		public const int SessionInfoFieldNumber = 1;

		// Token: 0x04002589 RID: 9609
		private StoreSessionInfo sessionInfo_;

		// Token: 0x0400258A RID: 9610
		public const int ProductInfoFieldNumber = 2;

		// Token: 0x0400258B RID: 9611
		private StoreProductInfo productInfo_;

		// Token: 0x0400258C RID: 9612
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400258D RID: 9613
		private static readonly long ItemIdDefaultValue = 0L;

		// Token: 0x0400258E RID: 9614
		private long itemId_;
	}
}
