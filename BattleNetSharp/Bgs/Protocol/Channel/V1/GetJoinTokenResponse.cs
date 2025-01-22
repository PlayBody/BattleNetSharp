using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F4 RID: 1780
	public sealed class GetJoinTokenResponse : IMessage<GetJoinTokenResponse>, IMessage, IEquatable<GetJoinTokenResponse>, IDeepCloneable<GetJoinTokenResponse>, IBufferMessage
	{
		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600A40F RID: 41999 RVA: 0x0027FB70 File Offset: 0x0027DD70
		[DebuggerNonUserCode]
		public static MessageParser<GetJoinTokenResponse> Parser
		{
			get
			{
				return GetJoinTokenResponse._parser;
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600A410 RID: 42000 RVA: 0x0027FB88 File Offset: 0x0027DD88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelVoiceServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600A411 RID: 42001 RVA: 0x0027FBAC File Offset: 0x0027DDAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetJoinTokenResponse.Descriptor;
			}
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x0027FBC3 File Offset: 0x0027DDC3
		[DebuggerNonUserCode]
		public GetJoinTokenResponse()
		{
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x0027FBD0 File Offset: 0x0027DDD0
		[DebuggerNonUserCode]
		public GetJoinTokenResponse(GetJoinTokenResponse other)
			: this()
		{
			this.channelUri_ = other.channelUri_;
			this.credentials_ = ((other.credentials_ != null) ? other.credentials_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x0027FC20 File Offset: 0x0027DE20
		[DebuggerNonUserCode]
		public GetJoinTokenResponse Clone()
		{
			return new GetJoinTokenResponse(this);
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600A415 RID: 42005 RVA: 0x0027FC38 File Offset: 0x0027DE38
		// (set) Token: 0x0600A416 RID: 42006 RVA: 0x0027FC59 File Offset: 0x0027DE59
		[DebuggerNonUserCode]
		public string ChannelUri
		{
			get
			{
				return this.channelUri_ ?? GetJoinTokenResponse.ChannelUriDefaultValue;
			}
			set
			{
				this.channelUri_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600A417 RID: 42007 RVA: 0x0027FC70 File Offset: 0x0027DE70
		[DebuggerNonUserCode]
		public bool HasChannelUri
		{
			get
			{
				return this.channelUri_ != null;
			}
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x0027FC8B File Offset: 0x0027DE8B
		[DebuggerNonUserCode]
		public void ClearChannelUri()
		{
			this.channelUri_ = null;
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600A419 RID: 42009 RVA: 0x0027FC98 File Offset: 0x0027DE98
		// (set) Token: 0x0600A41A RID: 42010 RVA: 0x0027FCB0 File Offset: 0x0027DEB0
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

		// Token: 0x0600A41B RID: 42011 RVA: 0x0027FCBC File Offset: 0x0027DEBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetJoinTokenResponse);
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x0027FCDC File Offset: 0x0027DEDC
		[DebuggerNonUserCode]
		public bool Equals(GetJoinTokenResponse other)
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

		// Token: 0x0600A41D RID: 42013 RVA: 0x0027FD50 File Offset: 0x0027DF50
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

		// Token: 0x0600A41E RID: 42014 RVA: 0x0027FDB8 File Offset: 0x0027DFB8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x0027FDD0 File Offset: 0x0027DFD0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x0027FDDC File Offset: 0x0027DFDC
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

		// Token: 0x0600A421 RID: 42017 RVA: 0x0027FE50 File Offset: 0x0027E050
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

		// Token: 0x0600A422 RID: 42018 RVA: 0x0027FEC0 File Offset: 0x0027E0C0
		[DebuggerNonUserCode]
		public void MergeFrom(GetJoinTokenResponse other)
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

		// Token: 0x0600A423 RID: 42019 RVA: 0x0027FF45 File Offset: 0x0027E145
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x0027FF50 File Offset: 0x0027E150
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

		// Token: 0x040049ED RID: 18925
		private static readonly MessageParser<GetJoinTokenResponse> _parser = new MessageParser<GetJoinTokenResponse>(() => new GetJoinTokenResponse());

		// Token: 0x040049EE RID: 18926
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049EF RID: 18927
		public const int ChannelUriFieldNumber = 1;

		// Token: 0x040049F0 RID: 18928
		private static readonly string ChannelUriDefaultValue = "";

		// Token: 0x040049F1 RID: 18929
		private string channelUri_;

		// Token: 0x040049F2 RID: 18930
		public const int CredentialsFieldNumber = 2;

		// Token: 0x040049F3 RID: 18931
		private VoiceCredentials credentials_;
	}
}
