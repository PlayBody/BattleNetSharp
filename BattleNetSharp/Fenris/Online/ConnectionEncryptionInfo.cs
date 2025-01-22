using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000142 RID: 322
	public sealed class ConnectionEncryptionInfo : IMessage<ConnectionEncryptionInfo>, IMessage, IEquatable<ConnectionEncryptionInfo>, IDeepCloneable<ConnectionEncryptionInfo>, IBufferMessage
	{
		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00081BF4 File Offset: 0x0007FDF4
		[DebuggerNonUserCode]
		public static MessageParser<ConnectionEncryptionInfo> Parser
		{
			get
			{
				return ConnectionEncryptionInfo._parser;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x00081C0C File Offset: 0x0007FE0C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00081C30 File Offset: 0x0007FE30
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectionEncryptionInfo.Descriptor;
			}
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00081C47 File Offset: 0x0007FE47
		[DebuggerNonUserCode]
		public ConnectionEncryptionInfo()
		{
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00081C54 File Offset: 0x0007FE54
		[DebuggerNonUserCode]
		public ConnectionEncryptionInfo(ConnectionEncryptionInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.presharedKey_ = ((other.presharedKey_ != null) ? other.presharedKey_.Clone() : null);
			this.token_ = other.token_;
			this.deprecatedCommonName_ = other.deprecatedCommonName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00081CBC File Offset: 0x0007FEBC
		[DebuggerNonUserCode]
		public ConnectionEncryptionInfo Clone()
		{
			return new ConnectionEncryptionInfo(this);
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00081CD4 File Offset: 0x0007FED4
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00081CEC File Offset: 0x0007FEEC
		[DebuggerNonUserCode]
		public PresharedKey PresharedKey
		{
			get
			{
				return this.presharedKey_;
			}
			set
			{
				this.presharedKey_ = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00081CF8 File Offset: 0x0007FEF8
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x00081D29 File Offset: 0x0007FF29
		[DebuggerNonUserCode]
		public ulong Token
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong tokenDefaultValue;
				if (flag)
				{
					tokenDefaultValue = this.token_;
				}
				else
				{
					tokenDefaultValue = ConnectionEncryptionInfo.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.token_ = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00081D44 File Offset: 0x0007FF44
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00081D61 File Offset: 0x0007FF61
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x00081D74 File Offset: 0x0007FF74
		// (set) Token: 0x0600213F RID: 8511 RVA: 0x00081D95 File Offset: 0x0007FF95
		[DebuggerNonUserCode]
		public string DeprecatedCommonName
		{
			get
			{
				return this.deprecatedCommonName_ ?? ConnectionEncryptionInfo.DeprecatedCommonNameDefaultValue;
			}
			set
			{
				this.deprecatedCommonName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00081DAC File Offset: 0x0007FFAC
		[DebuggerNonUserCode]
		public bool HasDeprecatedCommonName
		{
			get
			{
				return this.deprecatedCommonName_ != null;
			}
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00081DC7 File Offset: 0x0007FFC7
		[DebuggerNonUserCode]
		public void ClearDeprecatedCommonName()
		{
			this.deprecatedCommonName_ = null;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00081DD4 File Offset: 0x0007FFD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectionEncryptionInfo);
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00081DF4 File Offset: 0x0007FFF4
		[DebuggerNonUserCode]
		public bool Equals(ConnectionEncryptionInfo other)
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
					bool flag4 = !object.Equals(this.PresharedKey, other.PresharedKey);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Token != other.Token;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DeprecatedCommonName != other.DeprecatedCommonName;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00081E84 File Offset: 0x00080084
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.presharedKey_ != null;
			if (flag)
			{
				num ^= this.PresharedKey.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool hasDeprecatedCommonName = this.HasDeprecatedCommonName;
			if (hasDeprecatedCommonName)
			{
				num ^= this.DeprecatedCommonName.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00081F0C File Offset: 0x0008010C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00081F24 File Offset: 0x00080124
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00081F30 File Offset: 0x00080130
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.presharedKey_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PresharedKey);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Token);
			}
			bool hasDeprecatedCommonName = this.HasDeprecatedCommonName;
			if (hasDeprecatedCommonName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.DeprecatedCommonName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00081FC4 File Offset: 0x000801C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.presharedKey_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PresharedKey);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Token);
			}
			bool hasDeprecatedCommonName = this.HasDeprecatedCommonName;
			if (hasDeprecatedCommonName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DeprecatedCommonName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00082054 File Offset: 0x00080254
		[DebuggerNonUserCode]
		public void MergeFrom(ConnectionEncryptionInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.presharedKey_ != null;
				if (flag2)
				{
					bool flag3 = this.presharedKey_ == null;
					if (flag3)
					{
						this.PresharedKey = new PresharedKey();
					}
					this.PresharedKey.MergeFrom(other.PresharedKey);
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool hasDeprecatedCommonName = other.HasDeprecatedCommonName;
				if (hasDeprecatedCommonName)
				{
					this.DeprecatedCommonName = other.DeprecatedCommonName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x000820F7 File Offset: 0x000802F7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00082104 File Offset: 0x00080304
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
						if (num3 != 50U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DeprecatedCommonName = input.ReadString();
						}
					}
					else
					{
						this.Token = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.presharedKey_ == null;
					if (flag)
					{
						this.PresharedKey = new PresharedKey();
					}
					input.ReadMessage(this.PresharedKey);
				}
			}
		}

		// Token: 0x04000EAC RID: 3756
		private static readonly MessageParser<ConnectionEncryptionInfo> _parser = new MessageParser<ConnectionEncryptionInfo>(() => new ConnectionEncryptionInfo());

		// Token: 0x04000EAD RID: 3757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EAE RID: 3758
		private int _hasBits0;

		// Token: 0x04000EAF RID: 3759
		public const int PresharedKeyFieldNumber = 1;

		// Token: 0x04000EB0 RID: 3760
		private PresharedKey presharedKey_;

		// Token: 0x04000EB1 RID: 3761
		public const int TokenFieldNumber = 2;

		// Token: 0x04000EB2 RID: 3762
		private static readonly ulong TokenDefaultValue = 0UL;

		// Token: 0x04000EB3 RID: 3763
		private ulong token_;

		// Token: 0x04000EB4 RID: 3764
		public const int DeprecatedCommonNameFieldNumber = 6;

		// Token: 0x04000EB5 RID: 3765
		private static readonly string DeprecatedCommonNameDefaultValue = "";

		// Token: 0x04000EB6 RID: 3766
		private string deprecatedCommonName_;
	}
}
