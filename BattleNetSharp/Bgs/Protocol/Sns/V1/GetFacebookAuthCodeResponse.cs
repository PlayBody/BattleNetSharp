using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003C5 RID: 965
	public sealed class GetFacebookAuthCodeResponse : IMessage<GetFacebookAuthCodeResponse>, IMessage, IEquatable<GetFacebookAuthCodeResponse>, IDeepCloneable<GetFacebookAuthCodeResponse>, IBufferMessage
	{
		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x00176778 File Offset: 0x00174978
		[DebuggerNonUserCode]
		public static MessageParser<GetFacebookAuthCodeResponse> Parser
		{
			get
			{
				return GetFacebookAuthCodeResponse._parser;
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x00176790 File Offset: 0x00174990
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600608D RID: 24717 RVA: 0x001767B4 File Offset: 0x001749B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFacebookAuthCodeResponse.Descriptor;
			}
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x001767CB File Offset: 0x001749CB
		[DebuggerNonUserCode]
		public GetFacebookAuthCodeResponse()
		{
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x001767D5 File Offset: 0x001749D5
		[DebuggerNonUserCode]
		public GetFacebookAuthCodeResponse(GetFacebookAuthCodeResponse other)
			: this()
		{
			this.fbCode_ = other.fbCode_;
			this.redirectUri_ = other.redirectUri_;
			this.fbId_ = other.fbId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x00176814 File Offset: 0x00174A14
		[DebuggerNonUserCode]
		public GetFacebookAuthCodeResponse Clone()
		{
			return new GetFacebookAuthCodeResponse(this);
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x06006091 RID: 24721 RVA: 0x0017682C File Offset: 0x00174A2C
		// (set) Token: 0x06006092 RID: 24722 RVA: 0x0017684D File Offset: 0x00174A4D
		[DebuggerNonUserCode]
		public string FbCode
		{
			get
			{
				return this.fbCode_ ?? GetFacebookAuthCodeResponse.FbCodeDefaultValue;
			}
			set
			{
				this.fbCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06006093 RID: 24723 RVA: 0x00176864 File Offset: 0x00174A64
		[DebuggerNonUserCode]
		public bool HasFbCode
		{
			get
			{
				return this.fbCode_ != null;
			}
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0017687F File Offset: 0x00174A7F
		[DebuggerNonUserCode]
		public void ClearFbCode()
		{
			this.fbCode_ = null;
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06006095 RID: 24725 RVA: 0x0017688C File Offset: 0x00174A8C
		// (set) Token: 0x06006096 RID: 24726 RVA: 0x001768AD File Offset: 0x00174AAD
		[Obsolete]
		[DebuggerNonUserCode]
		public string RedirectUri
		{
			get
			{
				return this.redirectUri_ ?? GetFacebookAuthCodeResponse.RedirectUriDefaultValue;
			}
			set
			{
				this.redirectUri_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06006097 RID: 24727 RVA: 0x001768C4 File Offset: 0x00174AC4
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasRedirectUri
		{
			get
			{
				return this.redirectUri_ != null;
			}
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x001768DF File Offset: 0x00174ADF
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearRedirectUri()
		{
			this.redirectUri_ = null;
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06006099 RID: 24729 RVA: 0x001768EC File Offset: 0x00174AEC
		// (set) Token: 0x0600609A RID: 24730 RVA: 0x0017690D File Offset: 0x00174B0D
		[Obsolete]
		[DebuggerNonUserCode]
		public string FbId
		{
			get
			{
				return this.fbId_ ?? GetFacebookAuthCodeResponse.FbIdDefaultValue;
			}
			set
			{
				this.fbId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x0600609B RID: 24731 RVA: 0x00176924 File Offset: 0x00174B24
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasFbId
		{
			get
			{
				return this.fbId_ != null;
			}
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x0017693F File Offset: 0x00174B3F
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearFbId()
		{
			this.fbId_ = null;
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x0017694C File Offset: 0x00174B4C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFacebookAuthCodeResponse);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x0017696C File Offset: 0x00174B6C
		[DebuggerNonUserCode]
		public bool Equals(GetFacebookAuthCodeResponse other)
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
					bool flag4 = this.FbCode != other.FbCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RedirectUri != other.RedirectUri;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FbId != other.FbId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x001769F8 File Offset: 0x00174BF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFbCode = this.HasFbCode;
			if (hasFbCode)
			{
				num ^= this.FbCode.GetHashCode();
			}
			bool hasRedirectUri = this.HasRedirectUri;
			if (hasRedirectUri)
			{
				num ^= this.RedirectUri.GetHashCode();
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num ^= this.FbId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x00176A78 File Offset: 0x00174C78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x00176A90 File Offset: 0x00174C90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x00176A9C File Offset: 0x00174C9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFbCode = this.HasFbCode;
			if (hasFbCode)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FbCode);
			}
			bool hasRedirectUri = this.HasRedirectUri;
			if (hasRedirectUri)
			{
				output.WriteRawTag(18);
				output.WriteString(this.RedirectUri);
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.FbId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x00176B2C File Offset: 0x00174D2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFbCode = this.HasFbCode;
			if (hasFbCode)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FbCode);
			}
			bool hasRedirectUri = this.HasRedirectUri;
			if (hasRedirectUri)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RedirectUri);
			}
			bool hasFbId = this.HasFbId;
			if (hasFbId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FbId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x00176BB8 File Offset: 0x00174DB8
		[DebuggerNonUserCode]
		public void MergeFrom(GetFacebookAuthCodeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFbCode = other.HasFbCode;
				if (hasFbCode)
				{
					this.FbCode = other.FbCode;
				}
				bool hasRedirectUri = other.HasRedirectUri;
				if (hasRedirectUri)
				{
					this.RedirectUri = other.RedirectUri;
				}
				bool hasFbId = other.HasFbId;
				if (hasFbId)
				{
					this.FbId = other.FbId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00176C33 File Offset: 0x00174E33
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00176C40 File Offset: 0x00174E40
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
							this.FbId = input.ReadString();
						}
					}
					else
					{
						this.RedirectUri = input.ReadString();
					}
				}
				else
				{
					this.FbCode = input.ReadString();
				}
			}
		}

		// Token: 0x04002C24 RID: 11300
		private static readonly MessageParser<GetFacebookAuthCodeResponse> _parser = new MessageParser<GetFacebookAuthCodeResponse>(() => new GetFacebookAuthCodeResponse());

		// Token: 0x04002C25 RID: 11301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C26 RID: 11302
		public const int FbCodeFieldNumber = 1;

		// Token: 0x04002C27 RID: 11303
		private static readonly string FbCodeDefaultValue = "";

		// Token: 0x04002C28 RID: 11304
		private string fbCode_;

		// Token: 0x04002C29 RID: 11305
		public const int RedirectUriFieldNumber = 2;

		// Token: 0x04002C2A RID: 11306
		private static readonly string RedirectUriDefaultValue = "";

		// Token: 0x04002C2B RID: 11307
		private string redirectUri_;

		// Token: 0x04002C2C RID: 11308
		public const int FbIdFieldNumber = 3;

		// Token: 0x04002C2D RID: 11309
		private static readonly string FbIdDefaultValue = "";

		// Token: 0x04002C2E RID: 11310
		private string fbId_;
	}
}
