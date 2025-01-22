using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003C7 RID: 967
	public sealed class GetFacebookSettingsResponse : IMessage<GetFacebookSettingsResponse>, IMessage, IEquatable<GetFacebookSettingsResponse>, IDeepCloneable<GetFacebookSettingsResponse>, IBufferMessage
	{
		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x060060C1 RID: 24769 RVA: 0x001771AC File Offset: 0x001753AC
		[DebuggerNonUserCode]
		public static MessageParser<GetFacebookSettingsResponse> Parser
		{
			get
			{
				return GetFacebookSettingsResponse._parser;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x060060C2 RID: 24770 RVA: 0x001771C4 File Offset: 0x001753C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x060060C3 RID: 24771 RVA: 0x001771E8 File Offset: 0x001753E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFacebookSettingsResponse.Descriptor;
			}
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x001771FF File Offset: 0x001753FF
		[DebuggerNonUserCode]
		public GetFacebookSettingsResponse()
		{
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00177209 File Offset: 0x00175409
		[DebuggerNonUserCode]
		public GetFacebookSettingsResponse(GetFacebookSettingsResponse other)
			: this()
		{
			this.appId_ = other.appId_;
			this.redirectUri_ = other.redirectUri_;
			this.apiVersion_ = other.apiVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x00177248 File Offset: 0x00175448
		[DebuggerNonUserCode]
		public GetFacebookSettingsResponse Clone()
		{
			return new GetFacebookSettingsResponse(this);
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x00177260 File Offset: 0x00175460
		// (set) Token: 0x060060C8 RID: 24776 RVA: 0x00177281 File Offset: 0x00175481
		[DebuggerNonUserCode]
		public string AppId
		{
			get
			{
				return this.appId_ ?? GetFacebookSettingsResponse.AppIdDefaultValue;
			}
			set
			{
				this.appId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x060060C9 RID: 24777 RVA: 0x00177298 File Offset: 0x00175498
		[DebuggerNonUserCode]
		public bool HasAppId
		{
			get
			{
				return this.appId_ != null;
			}
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x001772B3 File Offset: 0x001754B3
		[DebuggerNonUserCode]
		public void ClearAppId()
		{
			this.appId_ = null;
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x060060CB RID: 24779 RVA: 0x001772C0 File Offset: 0x001754C0
		// (set) Token: 0x060060CC RID: 24780 RVA: 0x001772E1 File Offset: 0x001754E1
		[DebuggerNonUserCode]
		public string RedirectUri
		{
			get
			{
				return this.redirectUri_ ?? GetFacebookSettingsResponse.RedirectUriDefaultValue;
			}
			set
			{
				this.redirectUri_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x001772F8 File Offset: 0x001754F8
		[DebuggerNonUserCode]
		public bool HasRedirectUri
		{
			get
			{
				return this.redirectUri_ != null;
			}
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x00177313 File Offset: 0x00175513
		[DebuggerNonUserCode]
		public void ClearRedirectUri()
		{
			this.redirectUri_ = null;
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x00177320 File Offset: 0x00175520
		// (set) Token: 0x060060D0 RID: 24784 RVA: 0x00177341 File Offset: 0x00175541
		[DebuggerNonUserCode]
		public string ApiVersion
		{
			get
			{
				return this.apiVersion_ ?? GetFacebookSettingsResponse.ApiVersionDefaultValue;
			}
			set
			{
				this.apiVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x00177358 File Offset: 0x00175558
		[DebuggerNonUserCode]
		public bool HasApiVersion
		{
			get
			{
				return this.apiVersion_ != null;
			}
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x00177373 File Offset: 0x00175573
		[DebuggerNonUserCode]
		public void ClearApiVersion()
		{
			this.apiVersion_ = null;
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00177380 File Offset: 0x00175580
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFacebookSettingsResponse);
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x001773A0 File Offset: 0x001755A0
		[DebuggerNonUserCode]
		public bool Equals(GetFacebookSettingsResponse other)
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
					bool flag4 = this.AppId != other.AppId;
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
							bool flag6 = this.ApiVersion != other.ApiVersion;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x0017742C File Offset: 0x0017562C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAppId = this.HasAppId;
			if (hasAppId)
			{
				num ^= this.AppId.GetHashCode();
			}
			bool hasRedirectUri = this.HasRedirectUri;
			if (hasRedirectUri)
			{
				num ^= this.RedirectUri.GetHashCode();
			}
			bool hasApiVersion = this.HasApiVersion;
			if (hasApiVersion)
			{
				num ^= this.ApiVersion.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x001774AC File Offset: 0x001756AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x001774C4 File Offset: 0x001756C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x001774D0 File Offset: 0x001756D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAppId = this.HasAppId;
			if (hasAppId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AppId);
			}
			bool hasRedirectUri = this.HasRedirectUri;
			if (hasRedirectUri)
			{
				output.WriteRawTag(18);
				output.WriteString(this.RedirectUri);
			}
			bool hasApiVersion = this.HasApiVersion;
			if (hasApiVersion)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ApiVersion);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x00177560 File Offset: 0x00175760
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAppId = this.HasAppId;
			if (hasAppId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AppId);
			}
			bool hasRedirectUri = this.HasRedirectUri;
			if (hasRedirectUri)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RedirectUri);
			}
			bool hasApiVersion = this.HasApiVersion;
			if (hasApiVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ApiVersion);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x001775EC File Offset: 0x001757EC
		[DebuggerNonUserCode]
		public void MergeFrom(GetFacebookSettingsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAppId = other.HasAppId;
				if (hasAppId)
				{
					this.AppId = other.AppId;
				}
				bool hasRedirectUri = other.HasRedirectUri;
				if (hasRedirectUri)
				{
					this.RedirectUri = other.RedirectUri;
				}
				bool hasApiVersion = other.HasApiVersion;
				if (hasApiVersion)
				{
					this.ApiVersion = other.ApiVersion;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x00177667 File Offset: 0x00175867
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x00177674 File Offset: 0x00175874
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
							this.ApiVersion = input.ReadString();
						}
					}
					else
					{
						this.RedirectUri = input.ReadString();
					}
				}
				else
				{
					this.AppId = input.ReadString();
				}
			}
		}

		// Token: 0x04002C38 RID: 11320
		private static readonly MessageParser<GetFacebookSettingsResponse> _parser = new MessageParser<GetFacebookSettingsResponse>(() => new GetFacebookSettingsResponse());

		// Token: 0x04002C39 RID: 11321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C3A RID: 11322
		public const int AppIdFieldNumber = 1;

		// Token: 0x04002C3B RID: 11323
		private static readonly string AppIdDefaultValue = "";

		// Token: 0x04002C3C RID: 11324
		private string appId_;

		// Token: 0x04002C3D RID: 11325
		public const int RedirectUriFieldNumber = 2;

		// Token: 0x04002C3E RID: 11326
		private static readonly string RedirectUriDefaultValue = "";

		// Token: 0x04002C3F RID: 11327
		private string redirectUri_;

		// Token: 0x04002C40 RID: 11328
		public const int ApiVersionFieldNumber = 3;

		// Token: 0x04002C41 RID: 11329
		private static readonly string ApiVersionDefaultValue = "";

		// Token: 0x04002C42 RID: 11330
		private string apiVersion_;
	}
}
