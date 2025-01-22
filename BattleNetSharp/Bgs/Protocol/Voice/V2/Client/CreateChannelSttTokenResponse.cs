using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Voice.V2.Client
{
	// Token: 0x0200052C RID: 1324
	public sealed class CreateChannelSttTokenResponse : IMessage<CreateChannelSttTokenResponse>, IMessage, IEquatable<CreateChannelSttTokenResponse>, IDeepCloneable<CreateChannelSttTokenResponse>, IBufferMessage
	{
		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x06008050 RID: 32848 RVA: 0x001F37E8 File Offset: 0x001F19E8
		[DebuggerNonUserCode]
		public static MessageParser<CreateChannelSttTokenResponse> Parser
		{
			get
			{
				return CreateChannelSttTokenResponse._parser;
			}
		}

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x06008051 RID: 32849 RVA: 0x001F3800 File Offset: 0x001F1A00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VoiceServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x06008052 RID: 32850 RVA: 0x001F3824 File Offset: 0x001F1A24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateChannelSttTokenResponse.Descriptor;
			}
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x001F383B File Offset: 0x001F1A3B
		[DebuggerNonUserCode]
		public CreateChannelSttTokenResponse()
		{
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x001F3845 File Offset: 0x001F1A45
		[DebuggerNonUserCode]
		public CreateChannelSttTokenResponse(CreateChannelSttTokenResponse other)
			: this()
		{
			this.token_ = other.token_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x001F386C File Offset: 0x001F1A6C
		[DebuggerNonUserCode]
		public CreateChannelSttTokenResponse Clone()
		{
			return new CreateChannelSttTokenResponse(this);
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x06008056 RID: 32854 RVA: 0x001F3884 File Offset: 0x001F1A84
		// (set) Token: 0x06008057 RID: 32855 RVA: 0x001F38A5 File Offset: 0x001F1AA5
		[DebuggerNonUserCode]
		public string Token
		{
			get
			{
				return this.token_ ?? CreateChannelSttTokenResponse.TokenDefaultValue;
			}
			set
			{
				this.token_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x06008058 RID: 32856 RVA: 0x001F38BC File Offset: 0x001F1ABC
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return this.token_ != null;
			}
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x001F38D7 File Offset: 0x001F1AD7
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this.token_ = null;
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x001F38E4 File Offset: 0x001F1AE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateChannelSttTokenResponse);
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x001F3904 File Offset: 0x001F1B04
		[DebuggerNonUserCode]
		public bool Equals(CreateChannelSttTokenResponse other)
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
					bool flag4 = this.Token != other.Token;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x001F395C File Offset: 0x001F1B5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x001F39A8 File Offset: 0x001F1BA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x001F39C0 File Offset: 0x001F1BC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x001F39CC File Offset: 0x001F1BCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Token);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x001F3A18 File Offset: 0x001F1C18
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Token);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x001F3A68 File Offset: 0x001F1C68
		[DebuggerNonUserCode]
		public void MergeFrom(CreateChannelSttTokenResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x001F3AB1 File Offset: 0x001F1CB1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x001F3ABC File Offset: 0x001F1CBC
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
					this.Token = input.ReadString();
				}
			}
		}

		// Token: 0x04003A3E RID: 14910
		private static readonly MessageParser<CreateChannelSttTokenResponse> _parser = new MessageParser<CreateChannelSttTokenResponse>(() => new CreateChannelSttTokenResponse());

		// Token: 0x04003A3F RID: 14911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A40 RID: 14912
		public const int TokenFieldNumber = 1;

		// Token: 0x04003A41 RID: 14913
		private static readonly string TokenDefaultValue = "";

		// Token: 0x04003A42 RID: 14914
		private string token_;
	}
}
