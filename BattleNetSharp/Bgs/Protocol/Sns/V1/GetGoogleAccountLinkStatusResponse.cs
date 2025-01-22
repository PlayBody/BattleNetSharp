using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003CE RID: 974
	public sealed class GetGoogleAccountLinkStatusResponse : IMessage<GetGoogleAccountLinkStatusResponse>, IMessage, IEquatable<GetGoogleAccountLinkStatusResponse>, IDeepCloneable<GetGoogleAccountLinkStatusResponse>, IBufferMessage
	{
		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06006158 RID: 24920 RVA: 0x00178A24 File Offset: 0x00176C24
		[DebuggerNonUserCode]
		public static MessageParser<GetGoogleAccountLinkStatusResponse> Parser
		{
			get
			{
				return GetGoogleAccountLinkStatusResponse._parser;
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06006159 RID: 24921 RVA: 0x00178A3C File Offset: 0x00176C3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x0600615A RID: 24922 RVA: 0x00178A60 File Offset: 0x00176C60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGoogleAccountLinkStatusResponse.Descriptor;
			}
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x00178A77 File Offset: 0x00176C77
		[DebuggerNonUserCode]
		public GetGoogleAccountLinkStatusResponse()
		{
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x00178A84 File Offset: 0x00176C84
		[DebuggerNonUserCode]
		public GetGoogleAccountLinkStatusResponse(GetGoogleAccountLinkStatusResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountLinked_ = other.accountLinked_;
			this.googleId_ = other.googleId_;
			this.displayName_ = other.displayName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x00178ADC File Offset: 0x00176CDC
		[DebuggerNonUserCode]
		public GetGoogleAccountLinkStatusResponse Clone()
		{
			return new GetGoogleAccountLinkStatusResponse(this);
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x0600615E RID: 24926 RVA: 0x00178AF4 File Offset: 0x00176CF4
		// (set) Token: 0x0600615F RID: 24927 RVA: 0x00178B25 File Offset: 0x00176D25
		[DebuggerNonUserCode]
		public bool AccountLinked
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool accountLinkedDefaultValue;
				if (flag)
				{
					accountLinkedDefaultValue = this.accountLinked_;
				}
				else
				{
					accountLinkedDefaultValue = GetGoogleAccountLinkStatusResponse.AccountLinkedDefaultValue;
				}
				return accountLinkedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountLinked_ = value;
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x00178B40 File Offset: 0x00176D40
		[DebuggerNonUserCode]
		public bool HasAccountLinked
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x00178B5D File Offset: 0x00176D5D
		[DebuggerNonUserCode]
		public void ClearAccountLinked()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06006162 RID: 24930 RVA: 0x00178B70 File Offset: 0x00176D70
		// (set) Token: 0x06006163 RID: 24931 RVA: 0x00178B91 File Offset: 0x00176D91
		[DebuggerNonUserCode]
		public string GoogleId
		{
			get
			{
				return this.googleId_ ?? GetGoogleAccountLinkStatusResponse.GoogleIdDefaultValue;
			}
			set
			{
				this.googleId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06006164 RID: 24932 RVA: 0x00178BA8 File Offset: 0x00176DA8
		[DebuggerNonUserCode]
		public bool HasGoogleId
		{
			get
			{
				return this.googleId_ != null;
			}
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x00178BC3 File Offset: 0x00176DC3
		[DebuggerNonUserCode]
		public void ClearGoogleId()
		{
			this.googleId_ = null;
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x00178BD0 File Offset: 0x00176DD0
		// (set) Token: 0x06006167 RID: 24935 RVA: 0x00178BF1 File Offset: 0x00176DF1
		[DebuggerNonUserCode]
		public string DisplayName
		{
			get
			{
				return this.displayName_ ?? GetGoogleAccountLinkStatusResponse.DisplayNameDefaultValue;
			}
			set
			{
				this.displayName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x00178C08 File Offset: 0x00176E08
		[DebuggerNonUserCode]
		public bool HasDisplayName
		{
			get
			{
				return this.displayName_ != null;
			}
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x00178C23 File Offset: 0x00176E23
		[DebuggerNonUserCode]
		public void ClearDisplayName()
		{
			this.displayName_ = null;
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x00178C30 File Offset: 0x00176E30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGoogleAccountLinkStatusResponse);
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x00178C50 File Offset: 0x00176E50
		[DebuggerNonUserCode]
		public bool Equals(GetGoogleAccountLinkStatusResponse other)
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
					bool flag4 = this.AccountLinked != other.AccountLinked;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GoogleId != other.GoogleId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DisplayName != other.DisplayName;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x00178CDC File Offset: 0x00176EDC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountLinked = this.HasAccountLinked;
			if (hasAccountLinked)
			{
				num ^= this.AccountLinked.GetHashCode();
			}
			bool hasGoogleId = this.HasGoogleId;
			if (hasGoogleId)
			{
				num ^= this.GoogleId.GetHashCode();
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num ^= this.DisplayName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00178D60 File Offset: 0x00176F60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x00178D78 File Offset: 0x00176F78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00178D84 File Offset: 0x00176F84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountLinked = this.HasAccountLinked;
			if (hasAccountLinked)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AccountLinked);
			}
			bool hasGoogleId = this.HasGoogleId;
			if (hasGoogleId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GoogleId);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DisplayName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x00178E14 File Offset: 0x00177014
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountLinked = this.HasAccountLinked;
			if (hasAccountLinked)
			{
				num += 2;
			}
			bool hasGoogleId = this.HasGoogleId;
			if (hasGoogleId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GoogleId);
			}
			bool hasDisplayName = this.HasDisplayName;
			if (hasDisplayName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DisplayName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00178E94 File Offset: 0x00177094
		[DebuggerNonUserCode]
		public void MergeFrom(GetGoogleAccountLinkStatusResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountLinked = other.HasAccountLinked;
				if (hasAccountLinked)
				{
					this.AccountLinked = other.AccountLinked;
				}
				bool hasGoogleId = other.HasGoogleId;
				if (hasGoogleId)
				{
					this.GoogleId = other.GoogleId;
				}
				bool hasDisplayName = other.HasDisplayName;
				if (hasDisplayName)
				{
					this.DisplayName = other.DisplayName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x00178F0F File Offset: 0x0017710F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x00178F1C File Offset: 0x0017711C
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
							this.DisplayName = input.ReadString();
						}
					}
					else
					{
						this.GoogleId = input.ReadString();
					}
				}
				else
				{
					this.AccountLinked = input.ReadBool();
				}
			}
		}

		// Token: 0x04002C5F RID: 11359
		private static readonly MessageParser<GetGoogleAccountLinkStatusResponse> _parser = new MessageParser<GetGoogleAccountLinkStatusResponse>(() => new GetGoogleAccountLinkStatusResponse());

		// Token: 0x04002C60 RID: 11360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C61 RID: 11361
		private int _hasBits0;

		// Token: 0x04002C62 RID: 11362
		public const int AccountLinkedFieldNumber = 1;

		// Token: 0x04002C63 RID: 11363
		private static readonly bool AccountLinkedDefaultValue = false;

		// Token: 0x04002C64 RID: 11364
		private bool accountLinked_;

		// Token: 0x04002C65 RID: 11365
		public const int GoogleIdFieldNumber = 2;

		// Token: 0x04002C66 RID: 11366
		private static readonly string GoogleIdDefaultValue = "";

		// Token: 0x04002C67 RID: 11367
		private string googleId_;

		// Token: 0x04002C68 RID: 11368
		public const int DisplayNameFieldNumber = 3;

		// Token: 0x04002C69 RID: 11369
		private static readonly string DisplayNameDefaultValue = "";

		// Token: 0x04002C6A RID: 11370
		private string displayName_;
	}
}
