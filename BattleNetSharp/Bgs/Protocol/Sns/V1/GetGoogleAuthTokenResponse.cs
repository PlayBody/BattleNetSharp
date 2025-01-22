using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003CB RID: 971
	public sealed class GetGoogleAuthTokenResponse : IMessage<GetGoogleAuthTokenResponse>, IMessage, IEquatable<GetGoogleAuthTokenResponse>, IDeepCloneable<GetGoogleAuthTokenResponse>, IBufferMessage
	{
		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x00178150 File Offset: 0x00176350
		[DebuggerNonUserCode]
		public static MessageParser<GetGoogleAuthTokenResponse> Parser
		{
			get
			{
				return GetGoogleAuthTokenResponse._parser;
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600611E RID: 24862 RVA: 0x00178168 File Offset: 0x00176368
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x0600611F RID: 24863 RVA: 0x0017818C File Offset: 0x0017638C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGoogleAuthTokenResponse.Descriptor;
			}
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x001781A3 File Offset: 0x001763A3
		[DebuggerNonUserCode]
		public GetGoogleAuthTokenResponse()
		{
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x001781AD File Offset: 0x001763AD
		[DebuggerNonUserCode]
		public GetGoogleAuthTokenResponse(GetGoogleAuthTokenResponse other)
			: this()
		{
			this.accessToken_ = other.accessToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x001781D4 File Offset: 0x001763D4
		[DebuggerNonUserCode]
		public GetGoogleAuthTokenResponse Clone()
		{
			return new GetGoogleAuthTokenResponse(this);
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06006123 RID: 24867 RVA: 0x001781EC File Offset: 0x001763EC
		// (set) Token: 0x06006124 RID: 24868 RVA: 0x0017820D File Offset: 0x0017640D
		[DebuggerNonUserCode]
		public string AccessToken
		{
			get
			{
				return this.accessToken_ ?? GetGoogleAuthTokenResponse.AccessTokenDefaultValue;
			}
			set
			{
				this.accessToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06006125 RID: 24869 RVA: 0x00178224 File Offset: 0x00176424
		[DebuggerNonUserCode]
		public bool HasAccessToken
		{
			get
			{
				return this.accessToken_ != null;
			}
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x0017823F File Offset: 0x0017643F
		[DebuggerNonUserCode]
		public void ClearAccessToken()
		{
			this.accessToken_ = null;
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x0017824C File Offset: 0x0017644C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGoogleAuthTokenResponse);
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x0017826C File Offset: 0x0017646C
		[DebuggerNonUserCode]
		public bool Equals(GetGoogleAuthTokenResponse other)
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
					bool flag4 = this.AccessToken != other.AccessToken;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x001782C4 File Offset: 0x001764C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccessToken = this.HasAccessToken;
			if (hasAccessToken)
			{
				num ^= this.AccessToken.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x00178310 File Offset: 0x00176510
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00178328 File Offset: 0x00176528
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00178334 File Offset: 0x00176534
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccessToken = this.HasAccessToken;
			if (hasAccessToken)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AccessToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00178380 File Offset: 0x00176580
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccessToken = this.HasAccessToken;
			if (hasAccessToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AccessToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x001783D0 File Offset: 0x001765D0
		[DebuggerNonUserCode]
		public void MergeFrom(GetGoogleAuthTokenResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccessToken = other.HasAccessToken;
				if (hasAccessToken)
				{
					this.AccessToken = other.AccessToken;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00178419 File Offset: 0x00176619
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00178424 File Offset: 0x00176624
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AccessToken = input.ReadString();
				}
			}
		}

		// Token: 0x04002C53 RID: 11347
		private static readonly MessageParser<GetGoogleAuthTokenResponse> _parser = new MessageParser<GetGoogleAuthTokenResponse>(() => new GetGoogleAuthTokenResponse());

		// Token: 0x04002C54 RID: 11348
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C55 RID: 11349
		public const int AccessTokenFieldNumber = 1;

		// Token: 0x04002C56 RID: 11350
		private static readonly string AccessTokenDefaultValue = "";

		// Token: 0x04002C57 RID: 11351
		private string accessToken_;
	}
}
