using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Voice.V2.Client
{
	// Token: 0x0200052A RID: 1322
	public sealed class CreateLoginCredentialsResponse : IMessage<CreateLoginCredentialsResponse>, IMessage, IEquatable<CreateLoginCredentialsResponse>, IDeepCloneable<CreateLoginCredentialsResponse>, IBufferMessage
	{
		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x06008022 RID: 32802 RVA: 0x001F2EA4 File Offset: 0x001F10A4
		[DebuggerNonUserCode]
		public static MessageParser<CreateLoginCredentialsResponse> Parser
		{
			get
			{
				return CreateLoginCredentialsResponse._parser;
			}
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x06008023 RID: 32803 RVA: 0x001F2EBC File Offset: 0x001F10BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VoiceServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x06008024 RID: 32804 RVA: 0x001F2EE0 File Offset: 0x001F10E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateLoginCredentialsResponse.Descriptor;
			}
		}

		// Token: 0x06008025 RID: 32805 RVA: 0x001F2EF7 File Offset: 0x001F10F7
		[DebuggerNonUserCode]
		public CreateLoginCredentialsResponse()
		{
		}

		// Token: 0x06008026 RID: 32806 RVA: 0x001F2F01 File Offset: 0x001F1101
		[DebuggerNonUserCode]
		public CreateLoginCredentialsResponse(CreateLoginCredentialsResponse other)
			: this()
		{
			this.credentials_ = ((other.credentials_ != null) ? other.credentials_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008027 RID: 32807 RVA: 0x001F2F38 File Offset: 0x001F1138
		[DebuggerNonUserCode]
		public CreateLoginCredentialsResponse Clone()
		{
			return new CreateLoginCredentialsResponse(this);
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x001F2F50 File Offset: 0x001F1150
		// (set) Token: 0x06008029 RID: 32809 RVA: 0x001F2F68 File Offset: 0x001F1168
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

		// Token: 0x0600802A RID: 32810 RVA: 0x001F2F74 File Offset: 0x001F1174
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateLoginCredentialsResponse);
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x001F2F94 File Offset: 0x001F1194
		[DebuggerNonUserCode]
		public bool Equals(CreateLoginCredentialsResponse other)
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

		// Token: 0x0600802C RID: 32812 RVA: 0x001F2FF0 File Offset: 0x001F11F0
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

		// Token: 0x0600802D RID: 32813 RVA: 0x001F3040 File Offset: 0x001F1240
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x001F3058 File Offset: 0x001F1258
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x001F3064 File Offset: 0x001F1264
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

		// Token: 0x06008030 RID: 32816 RVA: 0x001F30B4 File Offset: 0x001F12B4
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

		// Token: 0x06008031 RID: 32817 RVA: 0x001F3108 File Offset: 0x001F1308
		[DebuggerNonUserCode]
		public void MergeFrom(CreateLoginCredentialsResponse other)
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

		// Token: 0x06008032 RID: 32818 RVA: 0x001F3174 File Offset: 0x001F1374
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x001F3180 File Offset: 0x001F1380
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

		// Token: 0x04003A2F RID: 14895
		private static readonly MessageParser<CreateLoginCredentialsResponse> _parser = new MessageParser<CreateLoginCredentialsResponse>(() => new CreateLoginCredentialsResponse());

		// Token: 0x04003A30 RID: 14896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A31 RID: 14897
		public const int CredentialsFieldNumber = 1;

		// Token: 0x04003A32 RID: 14898
		private VoiceCredentials credentials_;
	}
}
