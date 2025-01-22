using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200021B RID: 539
	public sealed class VirtualCurrencyDebitRequest : IMessage<VirtualCurrencyDebitRequest>, IMessage, IEquatable<VirtualCurrencyDebitRequest>, IDeepCloneable<VirtualCurrencyDebitRequest>, IBufferMessage
	{
		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x000E8570 File Offset: 0x000E6770
		[DebuggerNonUserCode]
		public static MessageParser<VirtualCurrencyDebitRequest> Parser
		{
			get
			{
				return VirtualCurrencyDebitRequest._parser;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x000E8588 File Offset: 0x000E6788
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x000E85AC File Offset: 0x000E67AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VirtualCurrencyDebitRequest.Descriptor;
			}
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x000E85C3 File Offset: 0x000E67C3
		[DebuggerNonUserCode]
		public VirtualCurrencyDebitRequest()
		{
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x000E85D0 File Offset: 0x000E67D0
		[DebuggerNonUserCode]
		public VirtualCurrencyDebitRequest(VirtualCurrencyDebitRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.amount_ = other.amount_;
			this.currencyCode_ = other.currencyCode_;
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x000E8628 File Offset: 0x000E6828
		[DebuggerNonUserCode]
		public VirtualCurrencyDebitRequest Clone()
		{
			return new VirtualCurrencyDebitRequest(this);
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x000E8640 File Offset: 0x000E6840
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x000E8671 File Offset: 0x000E6871
		[DebuggerNonUserCode]
		public uint Amount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint amountDefaultValue;
				if (flag)
				{
					amountDefaultValue = this.amount_;
				}
				else
				{
					amountDefaultValue = VirtualCurrencyDebitRequest.AmountDefaultValue;
				}
				return amountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.amount_ = value;
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x000E868C File Offset: 0x000E688C
		[DebuggerNonUserCode]
		public bool HasAmount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x000E86A9 File Offset: 0x000E68A9
		[DebuggerNonUserCode]
		public void ClearAmount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x000E86BC File Offset: 0x000E68BC
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x000E86DD File Offset: 0x000E68DD
		[DebuggerNonUserCode]
		public string CurrencyCode
		{
			get
			{
				return this.currencyCode_ ?? VirtualCurrencyDebitRequest.CurrencyCodeDefaultValue;
			}
			set
			{
				this.currencyCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x000E86F4 File Offset: 0x000E68F4
		[DebuggerNonUserCode]
		public bool HasCurrencyCode
		{
			get
			{
				return this.currencyCode_ != null;
			}
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x000E870F File Offset: 0x000E690F
		[DebuggerNonUserCode]
		public void ClearCurrencyCode()
		{
			this.currencyCode_ = null;
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x000E871C File Offset: 0x000E691C
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x000E873D File Offset: 0x000E693D
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? VirtualCurrencyDebitRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x000E8754 File Offset: 0x000E6954
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x000E8772 File Offset: 0x000E6972
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x000E877C File Offset: 0x000E697C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VirtualCurrencyDebitRequest);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x000E879C File Offset: 0x000E699C
		[DebuggerNonUserCode]
		public bool Equals(VirtualCurrencyDebitRequest other)
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
					bool flag4 = this.Amount != other.Amount;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CurrencyCode != other.CurrencyCode;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SessionKey != other.SessionKey;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x000E8828 File Offset: 0x000E6A28
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAmount = this.HasAmount;
			if (hasAmount)
			{
				num ^= this.Amount.GetHashCode();
			}
			bool hasCurrencyCode = this.HasCurrencyCode;
			if (hasCurrencyCode)
			{
				num ^= this.CurrencyCode.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x000E88AC File Offset: 0x000E6AAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A80 RID: 14976 RVA: 0x000E88C4 File Offset: 0x000E6AC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A81 RID: 14977 RVA: 0x000E88D0 File Offset: 0x000E6AD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAmount = this.HasAmount;
			if (hasAmount)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Amount);
			}
			bool hasCurrencyCode = this.HasCurrencyCode;
			if (hasCurrencyCode)
			{
				output.WriteRawTag(18);
				output.WriteString(this.CurrencyCode);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x000E8960 File Offset: 0x000E6B60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAmount = this.HasAmount;
			if (hasAmount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Amount);
			}
			bool hasCurrencyCode = this.HasCurrencyCode;
			if (hasCurrencyCode)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CurrencyCode);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x000E89EC File Offset: 0x000E6BEC
		[DebuggerNonUserCode]
		public void MergeFrom(VirtualCurrencyDebitRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAmount = other.HasAmount;
				if (hasAmount)
				{
					this.Amount = other.Amount;
				}
				bool hasCurrencyCode = other.HasCurrencyCode;
				if (hasCurrencyCode)
				{
					this.CurrencyCode = other.CurrencyCode;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x000E8A67 File Offset: 0x000E6C67
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x000E8A74 File Offset: 0x000E6C74
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SessionKey = input.ReadBytes();
						}
					}
					else
					{
						this.CurrencyCode = input.ReadString();
					}
				}
				else
				{
					this.Amount = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001B03 RID: 6915
		private static readonly MessageParser<VirtualCurrencyDebitRequest> _parser = new MessageParser<VirtualCurrencyDebitRequest>(() => new VirtualCurrencyDebitRequest());

		// Token: 0x04001B04 RID: 6916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B05 RID: 6917
		private int _hasBits0;

		// Token: 0x04001B06 RID: 6918
		public const int AmountFieldNumber = 1;

		// Token: 0x04001B07 RID: 6919
		private static readonly uint AmountDefaultValue = 0U;

		// Token: 0x04001B08 RID: 6920
		private uint amount_;

		// Token: 0x04001B09 RID: 6921
		public const int CurrencyCodeFieldNumber = 2;

		// Token: 0x04001B0A RID: 6922
		private static readonly string CurrencyCodeDefaultValue = "";

		// Token: 0x04001B0B RID: 6923
		private string currencyCode_;

		// Token: 0x04001B0C RID: 6924
		public const int SessionKeyFieldNumber = 3;

		// Token: 0x04001B0D RID: 6925
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001B0E RID: 6926
		private ByteString sessionKey_;
	}
}
