using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000676 RID: 1654
	public sealed class GetJoinVoiceTokenResponse : IMessage<GetJoinVoiceTokenResponse>, IMessage, IEquatable<GetJoinVoiceTokenResponse>, IDeepCloneable<GetJoinVoiceTokenResponse>, IBufferMessage
	{
		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0600997F RID: 39295 RVA: 0x00252C68 File Offset: 0x00250E68
		[DebuggerNonUserCode]
		public static MessageParser<GetJoinVoiceTokenResponse> Parser
		{
			get
			{
				return GetJoinVoiceTokenResponse._parser;
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x06009980 RID: 39296 RVA: 0x00252C80 File Offset: 0x00250E80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x06009981 RID: 39297 RVA: 0x00252CA4 File Offset: 0x00250EA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetJoinVoiceTokenResponse.Descriptor;
			}
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x00252CBB File Offset: 0x00250EBB
		[DebuggerNonUserCode]
		public GetJoinVoiceTokenResponse()
		{
		}

		// Token: 0x06009983 RID: 39299 RVA: 0x00252CC8 File Offset: 0x00250EC8
		[DebuggerNonUserCode]
		public GetJoinVoiceTokenResponse(GetJoinVoiceTokenResponse other)
			: this()
		{
			this.channelUri_ = other.channelUri_;
			this.credentials_ = ((other.credentials_ != null) ? other.credentials_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x00252D18 File Offset: 0x00250F18
		[DebuggerNonUserCode]
		public GetJoinVoiceTokenResponse Clone()
		{
			return new GetJoinVoiceTokenResponse(this);
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x06009985 RID: 39301 RVA: 0x00252D30 File Offset: 0x00250F30
		// (set) Token: 0x06009986 RID: 39302 RVA: 0x00252D51 File Offset: 0x00250F51
		[DebuggerNonUserCode]
		public string ChannelUri
		{
			get
			{
				return this.channelUri_ ?? GetJoinVoiceTokenResponse.ChannelUriDefaultValue;
			}
			set
			{
				this.channelUri_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x06009987 RID: 39303 RVA: 0x00252D68 File Offset: 0x00250F68
		[DebuggerNonUserCode]
		public bool HasChannelUri
		{
			get
			{
				return this.channelUri_ != null;
			}
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x00252D83 File Offset: 0x00250F83
		[DebuggerNonUserCode]
		public void ClearChannelUri()
		{
			this.channelUri_ = null;
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x06009989 RID: 39305 RVA: 0x00252D90 File Offset: 0x00250F90
		// (set) Token: 0x0600998A RID: 39306 RVA: 0x00252DA8 File Offset: 0x00250FA8
		[DebuggerNonUserCode]
		public VoiceCredentials Credentials
		{
			get
			{
				return this.credentials_;
			}
			set
			{
				this.credentials_ = value;
			}
		}

		// Token: 0x0600998B RID: 39307 RVA: 0x00252DB4 File Offset: 0x00250FB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetJoinVoiceTokenResponse);
		}

		// Token: 0x0600998C RID: 39308 RVA: 0x00252DD4 File Offset: 0x00250FD4
		[DebuggerNonUserCode]
		public bool Equals(GetJoinVoiceTokenResponse other)
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
					bool flag4 = this.ChannelUri != other.ChannelUri;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Credentials, other.Credentials);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600998D RID: 39309 RVA: 0x00252E48 File Offset: 0x00251048
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasChannelUri = this.HasChannelUri;
			if (hasChannelUri)
			{
				num ^= this.ChannelUri.GetHashCode();
			}
			bool flag = this.credentials_ != null;
			if (flag)
			{
				num ^= this.Credentials.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x00252EB0 File Offset: 0x002510B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600998F RID: 39311 RVA: 0x00252EC8 File Offset: 0x002510C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x00252ED4 File Offset: 0x002510D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasChannelUri = this.HasChannelUri;
			if (hasChannelUri)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ChannelUri);
			}
			bool flag = this.credentials_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Credentials);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009991 RID: 39313 RVA: 0x00252F48 File Offset: 0x00251148
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasChannelUri = this.HasChannelUri;
			if (hasChannelUri)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelUri);
			}
			bool flag = this.credentials_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Credentials);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009992 RID: 39314 RVA: 0x00252FB8 File Offset: 0x002511B8
		[DebuggerNonUserCode]
		public void MergeFrom(GetJoinVoiceTokenResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasChannelUri = other.HasChannelUri;
				if (hasChannelUri)
				{
					this.ChannelUri = other.ChannelUri;
				}
				bool flag2 = other.credentials_ != null;
				if (flag2)
				{
					bool flag3 = this.credentials_ == null;
					if (flag3)
					{
						this.Credentials = new VoiceCredentials();
					}
					this.Credentials.MergeFrom(other.Credentials);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009993 RID: 39315 RVA: 0x0025303D File Offset: 0x0025123D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009994 RID: 39316 RVA: 0x00253048 File Offset: 0x00251248
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.credentials_ == null;
						if (flag)
						{
							this.Credentials = new VoiceCredentials();
						}
						input.ReadMessage(this.Credentials);
					}
				}
				else
				{
					this.ChannelUri = input.ReadString();
				}
			}
		}

		// Token: 0x04004506 RID: 17670
		private static readonly MessageParser<GetJoinVoiceTokenResponse> _parser = new MessageParser<GetJoinVoiceTokenResponse>(() => new GetJoinVoiceTokenResponse());

		// Token: 0x04004507 RID: 17671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004508 RID: 17672
		public const int ChannelUriFieldNumber = 1;

		// Token: 0x04004509 RID: 17673
		private static readonly string ChannelUriDefaultValue = "";

		// Token: 0x0400450A RID: 17674
		private string channelUri_;

		// Token: 0x0400450B RID: 17675
		public const int CredentialsFieldNumber = 2;

		// Token: 0x0400450C RID: 17676
		private VoiceCredentials credentials_;
	}
}
