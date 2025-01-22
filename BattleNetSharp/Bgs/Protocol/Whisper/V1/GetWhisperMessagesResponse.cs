using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003AC RID: 940
	public sealed class GetWhisperMessagesResponse : IMessage<GetWhisperMessagesResponse>, IMessage, IEquatable<GetWhisperMessagesResponse>, IDeepCloneable<GetWhisperMessagesResponse>, IBufferMessage
	{
		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x0016EE20 File Offset: 0x0016D020
		[DebuggerNonUserCode]
		public static MessageParser<GetWhisperMessagesResponse> Parser
		{
			get
			{
				return GetWhisperMessagesResponse._parser;
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06005EC6 RID: 24262 RVA: 0x0016EE38 File Offset: 0x0016D038
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x0016EE5C File Offset: 0x0016D05C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetWhisperMessagesResponse.Descriptor;
			}
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x0016EE73 File Offset: 0x0016D073
		[DebuggerNonUserCode]
		public GetWhisperMessagesResponse()
		{
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x0016EE88 File Offset: 0x0016D088
		[DebuggerNonUserCode]
		public GetWhisperMessagesResponse(GetWhisperMessagesResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.whisper_ = other.whisper_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x0016EED8 File Offset: 0x0016D0D8
		[DebuggerNonUserCode]
		public GetWhisperMessagesResponse Clone()
		{
			return new GetWhisperMessagesResponse(this);
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06005ECB RID: 24267 RVA: 0x0016EEF0 File Offset: 0x0016D0F0
		[DebuggerNonUserCode]
		public RepeatedField<Whisper> Whisper
		{
			get
			{
				return this.whisper_;
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x06005ECC RID: 24268 RVA: 0x0016EF08 File Offset: 0x0016D108
		// (set) Token: 0x06005ECD RID: 24269 RVA: 0x0016EF39 File Offset: 0x0016D139
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetWhisperMessagesResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06005ECE RID: 24270 RVA: 0x0016EF54 File Offset: 0x0016D154
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x0016EF71 File Offset: 0x0016D171
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x0016EF84 File Offset: 0x0016D184
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetWhisperMessagesResponse);
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x0016EFA4 File Offset: 0x0016D1A4
		[DebuggerNonUserCode]
		public bool Equals(GetWhisperMessagesResponse other)
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
					bool flag4 = !this.whisper_.Equals(other.whisper_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Continuation != other.Continuation;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x0016F018 File Offset: 0x0016D218
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.whisper_.GetHashCode();
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x0016F078 File Offset: 0x0016D278
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x0016F090 File Offset: 0x0016D290
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x0016F09C File Offset: 0x0016D29C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.whisper_.WriteTo(ref output, GetWhisperMessagesResponse._repeated_whisper_codec);
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x0016F0FC File Offset: 0x0016D2FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.whisper_.CalculateSize(GetWhisperMessagesResponse._repeated_whisper_codec);
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x0016F160 File Offset: 0x0016D360
		[DebuggerNonUserCode]
		public void MergeFrom(GetWhisperMessagesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.whisper_.Add(other.whisper_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x0016F1BB File Offset: 0x0016D3BB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x0016F1C8 File Offset: 0x0016D3C8
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Continuation = input.ReadUInt64();
					}
				}
				else
				{
					this.whisper_.AddEntriesFrom(ref input, GetWhisperMessagesResponse._repeated_whisper_codec);
				}
			}
		}

		// Token: 0x04002B49 RID: 11081
		private static readonly MessageParser<GetWhisperMessagesResponse> _parser = new MessageParser<GetWhisperMessagesResponse>(() => new GetWhisperMessagesResponse());

		// Token: 0x04002B4A RID: 11082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B4B RID: 11083
		private int _hasBits0;

		// Token: 0x04002B4C RID: 11084
		public const int WhisperFieldNumber = 1;

		// Token: 0x04002B4D RID: 11085
		private static readonly FieldCodec<Whisper> _repeated_whisper_codec = FieldCodec.ForMessage<Whisper>(10U, Bgs.Protocol.Whisper.V1.Whisper.Parser);

		// Token: 0x04002B4E RID: 11086
		private readonly RepeatedField<Whisper> whisper_ = new RepeatedField<Whisper>();

		// Token: 0x04002B4F RID: 11087
		public const int ContinuationFieldNumber = 2;

		// Token: 0x04002B50 RID: 11088
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04002B51 RID: 11089
		private ulong continuation_;
	}
}
