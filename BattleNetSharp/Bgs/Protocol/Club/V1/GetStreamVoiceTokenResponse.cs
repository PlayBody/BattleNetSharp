using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004EC RID: 1260
	public sealed class GetStreamVoiceTokenResponse : IMessage<GetStreamVoiceTokenResponse>, IMessage, IEquatable<GetStreamVoiceTokenResponse>, IDeepCloneable<GetStreamVoiceTokenResponse>, IBufferMessage
	{
		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x06007A8A RID: 31370 RVA: 0x001DC19C File Offset: 0x001DA39C
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamVoiceTokenResponse> Parser
		{
			get
			{
				return GetStreamVoiceTokenResponse._parser;
			}
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x06007A8B RID: 31371 RVA: 0x001DC1B4 File Offset: 0x001DA3B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[81];
			}
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x001DC1D8 File Offset: 0x001DA3D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamVoiceTokenResponse.Descriptor;
			}
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x001DC1EF File Offset: 0x001DA3EF
		[DebuggerNonUserCode]
		public GetStreamVoiceTokenResponse()
		{
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x001DC1FC File Offset: 0x001DA3FC
		[DebuggerNonUserCode]
		public GetStreamVoiceTokenResponse(GetStreamVoiceTokenResponse other)
			: this()
		{
			this.channelUri_ = other.channelUri_;
			this.credentials_ = ((other.credentials_ != null) ? other.credentials_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x001DC24C File Offset: 0x001DA44C
		[DebuggerNonUserCode]
		public GetStreamVoiceTokenResponse Clone()
		{
			return new GetStreamVoiceTokenResponse(this);
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x001DC264 File Offset: 0x001DA464
		// (set) Token: 0x06007A91 RID: 31377 RVA: 0x001DC285 File Offset: 0x001DA485
		[DebuggerNonUserCode]
		public string ChannelUri
		{
			get
			{
				return this.channelUri_ ?? GetStreamVoiceTokenResponse.ChannelUriDefaultValue;
			}
			set
			{
				this.channelUri_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x001DC29C File Offset: 0x001DA49C
		[DebuggerNonUserCode]
		public bool HasChannelUri
		{
			get
			{
				return this.channelUri_ != null;
			}
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x001DC2B7 File Offset: 0x001DA4B7
		[DebuggerNonUserCode]
		public void ClearChannelUri()
		{
			this.channelUri_ = null;
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x001DC2C4 File Offset: 0x001DA4C4
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x001DC2DC File Offset: 0x001DA4DC
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

		// Token: 0x06007A96 RID: 31382 RVA: 0x001DC2E8 File Offset: 0x001DA4E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamVoiceTokenResponse);
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x001DC308 File Offset: 0x001DA508
		[DebuggerNonUserCode]
		public bool Equals(GetStreamVoiceTokenResponse other)
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

		// Token: 0x06007A98 RID: 31384 RVA: 0x001DC37C File Offset: 0x001DA57C
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

		// Token: 0x06007A99 RID: 31385 RVA: 0x001DC3E4 File Offset: 0x001DA5E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x001DC3FC File Offset: 0x001DA5FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x001DC408 File Offset: 0x001DA608
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

		// Token: 0x06007A9C RID: 31388 RVA: 0x001DC47C File Offset: 0x001DA67C
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

		// Token: 0x06007A9D RID: 31389 RVA: 0x001DC4EC File Offset: 0x001DA6EC
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamVoiceTokenResponse other)
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

		// Token: 0x06007A9E RID: 31390 RVA: 0x001DC571 File Offset: 0x001DA771
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x001DC57C File Offset: 0x001DA77C
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

		// Token: 0x04003785 RID: 14213
		private static readonly MessageParser<GetStreamVoiceTokenResponse> _parser = new MessageParser<GetStreamVoiceTokenResponse>(() => new GetStreamVoiceTokenResponse());

		// Token: 0x04003786 RID: 14214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003787 RID: 14215
		public const int ChannelUriFieldNumber = 1;

		// Token: 0x04003788 RID: 14216
		private static readonly string ChannelUriDefaultValue = "";

		// Token: 0x04003789 RID: 14217
		private string channelUri_;

		// Token: 0x0400378A RID: 14218
		public const int CredentialsFieldNumber = 2;

		// Token: 0x0400378B RID: 14219
		private VoiceCredentials credentials_;
	}
}
