using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Chat
{
	// Token: 0x0200077B RID: 1915
	public sealed class ChatResponse : IMessage<ChatResponse>, IMessage, IEquatable<ChatResponse>, IDeepCloneable<ChatResponse>, IBufferMessage
	{
		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600B01A RID: 45082 RVA: 0x002ADDC8 File Offset: 0x002ABFC8
		[DebuggerNonUserCode]
		public static MessageParser<ChatResponse> Parser
		{
			get
			{
				return ChatResponse._parser;
			}
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600B01B RID: 45083 RVA: 0x002ADDE0 File Offset: 0x002ABFE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChatReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600B01C RID: 45084 RVA: 0x002ADE04 File Offset: 0x002AC004
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatResponse.Descriptor;
			}
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x002ADE1B File Offset: 0x002AC01B
		[DebuggerNonUserCode]
		public ChatResponse()
		{
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x002ADE25 File Offset: 0x002AC025
		[DebuggerNonUserCode]
		public ChatResponse(ChatResponse other)
			: this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B01F RID: 45087 RVA: 0x002ADE4C File Offset: 0x002AC04C
		[DebuggerNonUserCode]
		public ChatResponse Clone()
		{
			return new ChatResponse(this);
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600B020 RID: 45088 RVA: 0x002ADE64 File Offset: 0x002AC064
		// (set) Token: 0x0600B021 RID: 45089 RVA: 0x002ADE85 File Offset: 0x002AC085
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? ChatResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600B022 RID: 45090 RVA: 0x002ADE9C File Offset: 0x002AC09C
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x002ADEBA File Offset: 0x002AC0BA
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x002ADEC4 File Offset: 0x002AC0C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatResponse);
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x002ADEE4 File Offset: 0x002AC0E4
		[DebuggerNonUserCode]
		public bool Equals(ChatResponse other)
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
					bool flag4 = this.Data != other.Data;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x002ADF3C File Offset: 0x002AC13C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasData = this.HasData;
			if (hasData)
			{
				num ^= this.Data.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B027 RID: 45095 RVA: 0x002ADF88 File Offset: 0x002AC188
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x002ADFA0 File Offset: 0x002AC1A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B029 RID: 45097 RVA: 0x002ADFAC File Offset: 0x002AC1AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasData = this.HasData;
			if (hasData)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x002ADFF8 File Offset: 0x002AC1F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasData = this.HasData;
			if (hasData)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B02B RID: 45099 RVA: 0x002AE048 File Offset: 0x002AC248
		[DebuggerNonUserCode]
		public void MergeFrom(ChatResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasData = other.HasData;
				if (hasData)
				{
					this.Data = other.Data;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B02C RID: 45100 RVA: 0x002AE091 File Offset: 0x002AC291
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B02D RID: 45101 RVA: 0x002AE09C File Offset: 0x002AC29C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Data = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004F6D RID: 20333
		private static readonly MessageParser<ChatResponse> _parser = new MessageParser<ChatResponse>(() => new ChatResponse());

		// Token: 0x04004F6E RID: 20334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F6F RID: 20335
		public const int DataFieldNumber = 3;

		// Token: 0x04004F70 RID: 20336
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x04004F71 RID: 20337
		private ByteString data_;
	}
}
