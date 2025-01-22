using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000399 RID: 921
	public sealed class VoiceCredentials : IMessage<VoiceCredentials>, IMessage, IEquatable<VoiceCredentials>, IDeepCloneable<VoiceCredentials>, IBufferMessage
	{
		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06005D4E RID: 23886 RVA: 0x0016927C File Offset: 0x0016747C
		[DebuggerNonUserCode]
		public static MessageParser<VoiceCredentials> Parser
		{
			get
			{
				return VoiceCredentials._parser;
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x06005D4F RID: 23887 RVA: 0x00169294 File Offset: 0x00167494
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VoiceTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x06005D50 RID: 23888 RVA: 0x001692B8 File Offset: 0x001674B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VoiceCredentials.Descriptor;
			}
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x001692CF File Offset: 0x001674CF
		[DebuggerNonUserCode]
		public VoiceCredentials()
		{
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x001692DC File Offset: 0x001674DC
		[DebuggerNonUserCode]
		public VoiceCredentials(VoiceCredentials other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.voiceId_ = other.voiceId_;
			this.token_ = other.token_;
			this.url_ = other.url_;
			this.joinType_ = other.joinType_;
			this.muteReason_ = other.muteReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x0016934C File Offset: 0x0016754C
		[DebuggerNonUserCode]
		public VoiceCredentials Clone()
		{
			return new VoiceCredentials(this);
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x06005D54 RID: 23892 RVA: 0x00169364 File Offset: 0x00167564
		// (set) Token: 0x06005D55 RID: 23893 RVA: 0x00169385 File Offset: 0x00167585
		[DebuggerNonUserCode]
		public string VoiceId
		{
			get
			{
				return this.voiceId_ ?? VoiceCredentials.VoiceIdDefaultValue;
			}
			set
			{
				this.voiceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06005D56 RID: 23894 RVA: 0x0016939C File Offset: 0x0016759C
		[DebuggerNonUserCode]
		public bool HasVoiceId
		{
			get
			{
				return this.voiceId_ != null;
			}
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x001693B7 File Offset: 0x001675B7
		[DebuggerNonUserCode]
		public void ClearVoiceId()
		{
			this.voiceId_ = null;
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06005D58 RID: 23896 RVA: 0x001693C4 File Offset: 0x001675C4
		// (set) Token: 0x06005D59 RID: 23897 RVA: 0x001693E5 File Offset: 0x001675E5
		[DebuggerNonUserCode]
		public string Token
		{
			get
			{
				return this.token_ ?? VoiceCredentials.TokenDefaultValue;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x001693FC File Offset: 0x001675FC
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return this.token_ != null;
			}
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x00169417 File Offset: 0x00167617
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this.token_ = null;
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06005D5C RID: 23900 RVA: 0x00169424 File Offset: 0x00167624
		// (set) Token: 0x06005D5D RID: 23901 RVA: 0x00169445 File Offset: 0x00167645
		[DebuggerNonUserCode]
		public string Url
		{
			get
			{
				return this.url_ ?? VoiceCredentials.UrlDefaultValue;
			}
			set
			{
				this.url_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06005D5E RID: 23902 RVA: 0x0016945C File Offset: 0x0016765C
		[DebuggerNonUserCode]
		public bool HasUrl
		{
			get
			{
				return this.url_ != null;
			}
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x00169477 File Offset: 0x00167677
		[DebuggerNonUserCode]
		public void ClearUrl()
		{
			this.url_ = null;
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x00169484 File Offset: 0x00167684
		// (set) Token: 0x06005D61 RID: 23905 RVA: 0x001694B5 File Offset: 0x001676B5
		[DebuggerNonUserCode]
		public VoiceJoinType JoinType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				VoiceJoinType joinTypeDefaultValue;
				if (flag)
				{
					joinTypeDefaultValue = this.joinType_;
				}
				else
				{
					joinTypeDefaultValue = VoiceCredentials.JoinTypeDefaultValue;
				}
				return joinTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.joinType_ = value;
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x001694D0 File Offset: 0x001676D0
		[DebuggerNonUserCode]
		public bool HasJoinType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x001694ED File Offset: 0x001676ED
		[DebuggerNonUserCode]
		public void ClearJoinType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x00169500 File Offset: 0x00167700
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x00169531 File Offset: 0x00167731
		[DebuggerNonUserCode]
		public VoiceMuteReason MuteReason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				VoiceMuteReason muteReasonDefaultValue;
				if (flag)
				{
					muteReasonDefaultValue = this.muteReason_;
				}
				else
				{
					muteReasonDefaultValue = VoiceCredentials.MuteReasonDefaultValue;
				}
				return muteReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.muteReason_ = value;
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06005D66 RID: 23910 RVA: 0x0016954C File Offset: 0x0016774C
		[DebuggerNonUserCode]
		public bool HasMuteReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00169569 File Offset: 0x00167769
		[DebuggerNonUserCode]
		public void ClearMuteReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x0016957C File Offset: 0x0016777C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VoiceCredentials);
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x0016959C File Offset: 0x0016779C
		[DebuggerNonUserCode]
		public bool Equals(VoiceCredentials other)
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
					bool flag4 = this.VoiceId != other.VoiceId;
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
							bool flag6 = this.Url != other.Url;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.JoinType != other.JoinType;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.MuteReason != other.MuteReason;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x00169668 File Offset: 0x00167868
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVoiceId = this.HasVoiceId;
			if (hasVoiceId)
			{
				num ^= this.VoiceId.GetHashCode();
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num ^= this.Url.GetHashCode();
			}
			bool hasJoinType = this.HasJoinType;
			if (hasJoinType)
			{
				num ^= this.JoinType.GetHashCode();
			}
			bool hasMuteReason = this.HasMuteReason;
			if (hasMuteReason)
			{
				num ^= this.MuteReason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x00169730 File Offset: 0x00167930
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x00169748 File Offset: 0x00167948
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x00169754 File Offset: 0x00167954
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVoiceId = this.HasVoiceId;
			if (hasVoiceId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.VoiceId);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Token);
			}
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Url);
			}
			bool hasJoinType = this.HasJoinType;
			if (hasJoinType)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.JoinType);
			}
			bool hasMuteReason = this.HasMuteReason;
			if (hasMuteReason)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.MuteReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x0016982C File Offset: 0x00167A2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVoiceId = this.HasVoiceId;
			if (hasVoiceId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VoiceId);
			}
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Url);
			}
			bool hasJoinType = this.HasJoinType;
			if (hasJoinType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.JoinType);
			}
			bool hasMuteReason = this.HasMuteReason;
			if (hasMuteReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MuteReason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x001698F4 File Offset: 0x00167AF4
		[DebuggerNonUserCode]
		public void MergeFrom(VoiceCredentials other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVoiceId = other.HasVoiceId;
				if (hasVoiceId)
				{
					this.VoiceId = other.VoiceId;
				}
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool hasUrl = other.HasUrl;
				if (hasUrl)
				{
					this.Url = other.Url;
				}
				bool hasJoinType = other.HasJoinType;
				if (hasJoinType)
				{
					this.JoinType = other.JoinType;
				}
				bool hasMuteReason = other.HasMuteReason;
				if (hasMuteReason)
				{
					this.MuteReason = other.MuteReason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x001699A8 File Offset: 0x00167BA8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x001699B4 File Offset: 0x00167BB4
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.Token = input.ReadString();
					}
					else
					{
						this.VoiceId = input.ReadString();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.MuteReason = (VoiceMuteReason)input.ReadEnum();
					}
					else
					{
						this.JoinType = (VoiceJoinType)input.ReadEnum();
					}
				}
				else
				{
					this.Url = input.ReadString();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002ABF RID: 10943
		private static readonly MessageParser<VoiceCredentials> _parser = new MessageParser<VoiceCredentials>(() => new VoiceCredentials());

		// Token: 0x04002AC0 RID: 10944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AC1 RID: 10945
		private int _hasBits0;

		// Token: 0x04002AC2 RID: 10946
		public const int VoiceIdFieldNumber = 1;

		// Token: 0x04002AC3 RID: 10947
		private static readonly string VoiceIdDefaultValue = "";

		// Token: 0x04002AC4 RID: 10948
		private string voiceId_;

		// Token: 0x04002AC5 RID: 10949
		public const int TokenFieldNumber = 2;

		// Token: 0x04002AC6 RID: 10950
		private static readonly string TokenDefaultValue = "";

		// Token: 0x04002AC7 RID: 10951
		private string token_;

		// Token: 0x04002AC8 RID: 10952
		public const int UrlFieldNumber = 3;

		// Token: 0x04002AC9 RID: 10953
		private static readonly string UrlDefaultValue = "";

		// Token: 0x04002ACA RID: 10954
		private string url_;

		// Token: 0x04002ACB RID: 10955
		public const int JoinTypeFieldNumber = 4;

		// Token: 0x04002ACC RID: 10956
		private static readonly VoiceJoinType JoinTypeDefaultValue = VoiceJoinType.VoiceJoinNormal;

		// Token: 0x04002ACD RID: 10957
		private VoiceJoinType joinType_;

		// Token: 0x04002ACE RID: 10958
		public const int MuteReasonFieldNumber = 5;

		// Token: 0x04002ACF RID: 10959
		private static readonly VoiceMuteReason MuteReasonDefaultValue = VoiceMuteReason.None;

		// Token: 0x04002AD0 RID: 10960
		private VoiceMuteReason muteReason_;
	}
}
