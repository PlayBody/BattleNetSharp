using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A7 RID: 935
	public sealed class SendWhisperResponse : IMessage<SendWhisperResponse>, IMessage, IEquatable<SendWhisperResponse>, IDeepCloneable<SendWhisperResponse>, IBufferMessage
	{
		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x06005E58 RID: 24152 RVA: 0x0016D580 File Offset: 0x0016B780
		[DebuggerNonUserCode]
		public static MessageParser<SendWhisperResponse> Parser
		{
			get
			{
				return SendWhisperResponse._parser;
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x06005E59 RID: 24153 RVA: 0x0016D598 File Offset: 0x0016B798
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06005E5A RID: 24154 RVA: 0x0016D5BC File Offset: 0x0016B7BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendWhisperResponse.Descriptor;
			}
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x0016D5D3 File Offset: 0x0016B7D3
		[DebuggerNonUserCode]
		public SendWhisperResponse()
		{
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x0016D5DD File Offset: 0x0016B7DD
		[DebuggerNonUserCode]
		public SendWhisperResponse(SendWhisperResponse other)
			: this()
		{
			this.whisper_ = ((other.whisper_ != null) ? other.whisper_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x0016D614 File Offset: 0x0016B814
		[DebuggerNonUserCode]
		public SendWhisperResponse Clone()
		{
			return new SendWhisperResponse(this);
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06005E5E RID: 24158 RVA: 0x0016D62C File Offset: 0x0016B82C
		// (set) Token: 0x06005E5F RID: 24159 RVA: 0x0016D644 File Offset: 0x0016B844
		[DebuggerNonUserCode]
		public Whisper Whisper
		{
			get
			{
				return this.whisper_;
			}
			set
			{
				this.whisper_ = value;
			}
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x0016D650 File Offset: 0x0016B850
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendWhisperResponse);
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x0016D670 File Offset: 0x0016B870
		[DebuggerNonUserCode]
		public bool Equals(SendWhisperResponse other)
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
					bool flag4 = !object.Equals(this.Whisper, other.Whisper);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x0016D6CC File Offset: 0x0016B8CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.whisper_ != null;
			if (flag)
			{
				num ^= this.Whisper.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x0016D71C File Offset: 0x0016B91C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x0016D734 File Offset: 0x0016B934
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x0016D740 File Offset: 0x0016B940
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.whisper_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Whisper);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x0016D790 File Offset: 0x0016B990
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.whisper_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Whisper);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x0016D7E4 File Offset: 0x0016B9E4
		[DebuggerNonUserCode]
		public void MergeFrom(SendWhisperResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.whisper_ != null;
				if (flag2)
				{
					bool flag3 = this.whisper_ == null;
					if (flag3)
					{
						this.Whisper = new Whisper();
					}
					this.Whisper.MergeFrom(other.Whisper);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x0016D850 File Offset: 0x0016BA50
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x0016D85C File Offset: 0x0016BA5C
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
					bool flag = this.whisper_ == null;
					if (flag)
					{
						this.Whisper = new Whisper();
					}
					input.ReadMessage(this.Whisper);
				}
			}
		}

		// Token: 0x04002B27 RID: 11047
		private static readonly MessageParser<SendWhisperResponse> _parser = new MessageParser<SendWhisperResponse>(() => new SendWhisperResponse());

		// Token: 0x04002B28 RID: 11048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B29 RID: 11049
		public const int WhisperFieldNumber = 1;

		// Token: 0x04002B2A RID: 11050
		private Whisper whisper_;
	}
}
