using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000219 RID: 537
	public sealed class VirtualCurrencyCreditRequest : IMessage<VirtualCurrencyCreditRequest>, IMessage, IEquatable<VirtualCurrencyCreditRequest>, IDeepCloneable<VirtualCurrencyCreditRequest>, IBufferMessage
	{
		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06003A3C RID: 14908 RVA: 0x000E7D7C File Offset: 0x000E5F7C
		[DebuggerNonUserCode]
		public static MessageParser<VirtualCurrencyCreditRequest> Parser
		{
			get
			{
				return VirtualCurrencyCreditRequest._parser;
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x000E7D94 File Offset: 0x000E5F94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x000E7DB8 File Offset: 0x000E5FB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VirtualCurrencyCreditRequest.Descriptor;
			}
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x000E7DCF File Offset: 0x000E5FCF
		[DebuggerNonUserCode]
		public VirtualCurrencyCreditRequest()
		{
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x000E7DDC File Offset: 0x000E5FDC
		[DebuggerNonUserCode]
		public VirtualCurrencyCreditRequest(VirtualCurrencyCreditRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.amount_ = other.amount_;
			this.currencyCode_ = other.currencyCode_;
			this.sessionKey_ = other.sessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x000E7E34 File Offset: 0x000E6034
		[DebuggerNonUserCode]
		public VirtualCurrencyCreditRequest Clone()
		{
			return new VirtualCurrencyCreditRequest(this);
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x000E7E4C File Offset: 0x000E604C
		// (set) Token: 0x06003A43 RID: 14915 RVA: 0x000E7E7D File Offset: 0x000E607D
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
					amountDefaultValue = VirtualCurrencyCreditRequest.AmountDefaultValue;
				}
				return amountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.amount_ = value;
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06003A44 RID: 14916 RVA: 0x000E7E98 File Offset: 0x000E6098
		[DebuggerNonUserCode]
		public bool HasAmount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000E7EB5 File Offset: 0x000E60B5
		[DebuggerNonUserCode]
		public void ClearAmount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06003A46 RID: 14918 RVA: 0x000E7EC8 File Offset: 0x000E60C8
		// (set) Token: 0x06003A47 RID: 14919 RVA: 0x000E7EE9 File Offset: 0x000E60E9
		[DebuggerNonUserCode]
		public string CurrencyCode
		{
			get
			{
				return this.currencyCode_ ?? VirtualCurrencyCreditRequest.CurrencyCodeDefaultValue;
			}
			set
			{
				this.currencyCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06003A48 RID: 14920 RVA: 0x000E7F00 File Offset: 0x000E6100
		[DebuggerNonUserCode]
		public bool HasCurrencyCode
		{
			get
			{
				return this.currencyCode_ != null;
			}
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x000E7F1B File Offset: 0x000E611B
		[DebuggerNonUserCode]
		public void ClearCurrencyCode()
		{
			this.currencyCode_ = null;
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06003A4A RID: 14922 RVA: 0x000E7F28 File Offset: 0x000E6128
		// (set) Token: 0x06003A4B RID: 14923 RVA: 0x000E7F49 File Offset: 0x000E6149
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? VirtualCurrencyCreditRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x000E7F60 File Offset: 0x000E6160
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x000E7F7E File Offset: 0x000E617E
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x000E7F88 File Offset: 0x000E6188
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VirtualCurrencyCreditRequest);
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x000E7FA8 File Offset: 0x000E61A8
		[DebuggerNonUserCode]
		public bool Equals(VirtualCurrencyCreditRequest other)
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

		// Token: 0x06003A50 RID: 14928 RVA: 0x000E8034 File Offset: 0x000E6234
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

		// Token: 0x06003A51 RID: 14929 RVA: 0x000E80B8 File Offset: 0x000E62B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x000E80D0 File Offset: 0x000E62D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x000E80DC File Offset: 0x000E62DC
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

		// Token: 0x06003A54 RID: 14932 RVA: 0x000E816C File Offset: 0x000E636C
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

		// Token: 0x06003A55 RID: 14933 RVA: 0x000E81F8 File Offset: 0x000E63F8
		[DebuggerNonUserCode]
		public void MergeFrom(VirtualCurrencyCreditRequest other)
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

		// Token: 0x06003A56 RID: 14934 RVA: 0x000E8273 File Offset: 0x000E6473
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x000E8280 File Offset: 0x000E6480
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

		// Token: 0x04001AF5 RID: 6901
		private static readonly MessageParser<VirtualCurrencyCreditRequest> _parser = new MessageParser<VirtualCurrencyCreditRequest>(() => new VirtualCurrencyCreditRequest());

		// Token: 0x04001AF6 RID: 6902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AF7 RID: 6903
		private int _hasBits0;

		// Token: 0x04001AF8 RID: 6904
		public const int AmountFieldNumber = 1;

		// Token: 0x04001AF9 RID: 6905
		private static readonly uint AmountDefaultValue = 0U;

		// Token: 0x04001AFA RID: 6906
		private uint amount_;

		// Token: 0x04001AFB RID: 6907
		public const int CurrencyCodeFieldNumber = 2;

		// Token: 0x04001AFC RID: 6908
		private static readonly string CurrencyCodeDefaultValue = "";

		// Token: 0x04001AFD RID: 6909
		private string currencyCode_;

		// Token: 0x04001AFE RID: 6910
		public const int SessionKeyFieldNumber = 3;

		// Token: 0x04001AFF RID: 6911
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001B00 RID: 6912
		private ByteString sessionKey_;
	}
}
