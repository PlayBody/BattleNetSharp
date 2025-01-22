using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F2 RID: 1778
	public sealed class GetLoginTokenResponse : IMessage<GetLoginTokenResponse>, IMessage, IEquatable<GetLoginTokenResponse>, IDeepCloneable<GetLoginTokenResponse>, IBufferMessage
	{
		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600A3E7 RID: 41959 RVA: 0x0027F35C File Offset: 0x0027D55C
		[DebuggerNonUserCode]
		public static MessageParser<GetLoginTokenResponse> Parser
		{
			get
			{
				return GetLoginTokenResponse._parser;
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600A3E8 RID: 41960 RVA: 0x0027F374 File Offset: 0x0027D574
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelVoiceServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600A3E9 RID: 41961 RVA: 0x0027F398 File Offset: 0x0027D598
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLoginTokenResponse.Descriptor;
			}
		}

		// Token: 0x0600A3EA RID: 41962 RVA: 0x0027F3AF File Offset: 0x0027D5AF
		[DebuggerNonUserCode]
		public GetLoginTokenResponse()
		{
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x0027F3B9 File Offset: 0x0027D5B9
		[DebuggerNonUserCode]
		public GetLoginTokenResponse(GetLoginTokenResponse other)
			: this()
		{
			this.credentials_ = ((other.credentials_ != null) ? other.credentials_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x0027F3F0 File Offset: 0x0027D5F0
		[DebuggerNonUserCode]
		public GetLoginTokenResponse Clone()
		{
			return new GetLoginTokenResponse(this);
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x0027F408 File Offset: 0x0027D608
		// (set) Token: 0x0600A3EE RID: 41966 RVA: 0x0027F420 File Offset: 0x0027D620
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

		// Token: 0x0600A3EF RID: 41967 RVA: 0x0027F42C File Offset: 0x0027D62C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLoginTokenResponse);
		}

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x0027F44C File Offset: 0x0027D64C
		[DebuggerNonUserCode]
		public bool Equals(GetLoginTokenResponse other)
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
					bool flag4 = !object.Equals(this.Credentials, other.Credentials);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x0027F4A8 File Offset: 0x0027D6A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x0027F4F8 File Offset: 0x0027D6F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x0027F510 File Offset: 0x0027D710
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x0027F51C File Offset: 0x0027D71C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.credentials_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Credentials);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x0027F56C File Offset: 0x0027D76C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x0027F5C0 File Offset: 0x0027D7C0
		[DebuggerNonUserCode]
		public void MergeFrom(GetLoginTokenResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
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

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x0027F62C File Offset: 0x0027D82C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x0027F638 File Offset: 0x0027D838
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
					bool flag = this.credentials_ == null;
					if (flag)
					{
						this.Credentials = new VoiceCredentials();
					}
					input.ReadMessage(this.Credentials);
				}
			}
		}

		// Token: 0x040049E3 RID: 18915
		private static readonly MessageParser<GetLoginTokenResponse> _parser = new MessageParser<GetLoginTokenResponse>(() => new GetLoginTokenResponse());

		// Token: 0x040049E4 RID: 18916
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E5 RID: 18917
		public const int CredentialsFieldNumber = 1;

		// Token: 0x040049E6 RID: 18918
		private VoiceCredentials credentials_;
	}
}
