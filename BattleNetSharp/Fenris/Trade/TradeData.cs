using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Trade
{
	// Token: 0x0200010B RID: 267
	public sealed class TradeData : IMessage<TradeData>, IMessage, IEquatable<TradeData>, IDeepCloneable<TradeData>, IBufferMessage
	{
		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x0005B144 File Offset: 0x00059344
		[DebuggerNonUserCode]
		public static MessageParser<TradeData> Parser
		{
			get
			{
				return TradeData._parser;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x0005B15C File Offset: 0x0005935C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TradeReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x0005B180 File Offset: 0x00059380
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TradeData.Descriptor;
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0005B197 File Offset: 0x00059397
		[DebuggerNonUserCode]
		public TradeData()
		{
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0005B1A4 File Offset: 0x000593A4
		[DebuggerNonUserCode]
		public TradeData(TradeData other)
			: this()
		{
			this.tradeId_ = other.tradeId_;
			this.escrowInfo_ = ((other.escrowInfo_ != null) ? other.escrowInfo_.Clone() : null);
			this.tradeInfo_ = ((other.tradeInfo_ != null) ? other.tradeInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0005B210 File Offset: 0x00059410
		[DebuggerNonUserCode]
		public TradeData Clone()
		{
			return new TradeData(this);
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x0005B228 File Offset: 0x00059428
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x0005B249 File Offset: 0x00059449
		[DebuggerNonUserCode]
		public string TradeId
		{
			get
			{
				return this.tradeId_ ?? TradeData.TradeIdDefaultValue;
			}
			set
			{
				this.tradeId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x0005B260 File Offset: 0x00059460
		[DebuggerNonUserCode]
		public bool HasTradeId
		{
			get
			{
				return this.tradeId_ != null;
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0005B27B File Offset: 0x0005947B
		[DebuggerNonUserCode]
		public void ClearTradeId()
		{
			this.tradeId_ = null;
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x0005B288 File Offset: 0x00059488
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0005B2A0 File Offset: 0x000594A0
		[DebuggerNonUserCode]
		public EscrowInfo EscrowInfo
		{
			get
			{
				return this.escrowInfo_;
			}
			set
			{
				this.escrowInfo_ = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0005B2AC File Offset: 0x000594AC
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x0005B2C4 File Offset: 0x000594C4
		[DebuggerNonUserCode]
		public TradeInfo TradeInfo
		{
			get
			{
				return this.tradeInfo_;
			}
			set
			{
				this.tradeInfo_ = value;
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0005B2D0 File Offset: 0x000594D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TradeData);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0005B2F0 File Offset: 0x000594F0
		[DebuggerNonUserCode]
		public bool Equals(TradeData other)
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
					bool flag4 = this.TradeId != other.TradeId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.EscrowInfo, other.EscrowInfo);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.TradeInfo, other.TradeInfo);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0005B384 File Offset: 0x00059584
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTradeId = this.HasTradeId;
			if (hasTradeId)
			{
				num ^= this.TradeId.GetHashCode();
			}
			bool flag = this.escrowInfo_ != null;
			if (flag)
			{
				num ^= this.EscrowInfo.GetHashCode();
			}
			bool flag2 = this.tradeInfo_ != null;
			if (flag2)
			{
				num ^= this.TradeInfo.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0005B408 File Offset: 0x00059608
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0005B420 File Offset: 0x00059620
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0005B42C File Offset: 0x0005962C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTradeId = this.HasTradeId;
			if (hasTradeId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TradeId);
			}
			bool flag = this.escrowInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EscrowInfo);
			}
			bool flag2 = this.tradeInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TradeInfo);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0005B4C4 File Offset: 0x000596C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTradeId = this.HasTradeId;
			if (hasTradeId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TradeId);
			}
			bool flag = this.escrowInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EscrowInfo);
			}
			bool flag2 = this.tradeInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TradeInfo);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0005B554 File Offset: 0x00059754
		[DebuggerNonUserCode]
		public void MergeFrom(TradeData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTradeId = other.HasTradeId;
				if (hasTradeId)
				{
					this.TradeId = other.TradeId;
				}
				bool flag2 = other.escrowInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.escrowInfo_ == null;
					if (flag3)
					{
						this.EscrowInfo = new EscrowInfo();
					}
					this.EscrowInfo.MergeFrom(other.EscrowInfo);
				}
				bool flag4 = other.tradeInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.tradeInfo_ == null;
					if (flag5)
					{
						this.TradeInfo = new TradeInfo();
					}
					this.TradeInfo.MergeFrom(other.TradeInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0005B61C File Offset: 0x0005981C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0005B628 File Offset: 0x00059828
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.tradeInfo_ == null;
							if (flag)
							{
								this.TradeInfo = new TradeInfo();
							}
							input.ReadMessage(this.TradeInfo);
						}
					}
					else
					{
						bool flag2 = this.escrowInfo_ == null;
						if (flag2)
						{
							this.EscrowInfo = new EscrowInfo();
						}
						input.ReadMessage(this.EscrowInfo);
					}
				}
				else
				{
					this.TradeId = input.ReadString();
				}
			}
		}

		// Token: 0x04000A34 RID: 2612
		private static readonly MessageParser<TradeData> _parser = new MessageParser<TradeData>(() => new TradeData());

		// Token: 0x04000A35 RID: 2613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A36 RID: 2614
		public const int TradeIdFieldNumber = 1;

		// Token: 0x04000A37 RID: 2615
		private static readonly string TradeIdDefaultValue = "";

		// Token: 0x04000A38 RID: 2616
		private string tradeId_;

		// Token: 0x04000A39 RID: 2617
		public const int EscrowInfoFieldNumber = 2;

		// Token: 0x04000A3A RID: 2618
		private EscrowInfo escrowInfo_;

		// Token: 0x04000A3B RID: 2619
		public const int TradeInfoFieldNumber = 3;

		// Token: 0x04000A3C RID: 2620
		private TradeInfo tradeInfo_;
	}
}
