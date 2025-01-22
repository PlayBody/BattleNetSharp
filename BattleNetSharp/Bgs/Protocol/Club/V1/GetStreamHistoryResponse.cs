using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E6 RID: 1254
	public sealed class GetStreamHistoryResponse : IMessage<GetStreamHistoryResponse>, IMessage, IEquatable<GetStreamHistoryResponse>, IDeepCloneable<GetStreamHistoryResponse>, IBufferMessage
	{
		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x060079F7 RID: 31223 RVA: 0x001DA204 File Offset: 0x001D8404
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamHistoryResponse> Parser
		{
			get
			{
				return GetStreamHistoryResponse._parser;
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x060079F8 RID: 31224 RVA: 0x001DA21C File Offset: 0x001D841C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[75];
			}
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x060079F9 RID: 31225 RVA: 0x001DA240 File Offset: 0x001D8440
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamHistoryResponse.Descriptor;
			}
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x001DA257 File Offset: 0x001D8457
		[DebuggerNonUserCode]
		public GetStreamHistoryResponse()
		{
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x001DA26C File Offset: 0x001D846C
		[DebuggerNonUserCode]
		public GetStreamHistoryResponse(GetStreamHistoryResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.message_ = other.message_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x001DA2BC File Offset: 0x001D84BC
		[DebuggerNonUserCode]
		public GetStreamHistoryResponse Clone()
		{
			return new GetStreamHistoryResponse(this);
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x060079FD RID: 31229 RVA: 0x001DA2D4 File Offset: 0x001D84D4
		[DebuggerNonUserCode]
		public RepeatedField<StreamMessage> Message
		{
			get
			{
				return this.message_;
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x060079FE RID: 31230 RVA: 0x001DA2EC File Offset: 0x001D84EC
		// (set) Token: 0x060079FF RID: 31231 RVA: 0x001DA31D File Offset: 0x001D851D
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
					continuationDefaultValue = GetStreamHistoryResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x001DA338 File Offset: 0x001D8538
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x001DA355 File Offset: 0x001D8555
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x001DA368 File Offset: 0x001D8568
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamHistoryResponse);
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x001DA388 File Offset: 0x001D8588
		[DebuggerNonUserCode]
		public bool Equals(GetStreamHistoryResponse other)
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
					bool flag4 = !this.message_.Equals(other.message_);
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

		// Token: 0x06007A04 RID: 31236 RVA: 0x001DA3FC File Offset: 0x001D85FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.message_.GetHashCode();
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

		// Token: 0x06007A05 RID: 31237 RVA: 0x001DA45C File Offset: 0x001D865C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x001DA474 File Offset: 0x001D8674
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x001DA480 File Offset: 0x001D8680
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.message_.WriteTo(ref output, GetStreamHistoryResponse._repeated_message_codec);
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

		// Token: 0x06007A08 RID: 31240 RVA: 0x001DA4E0 File Offset: 0x001D86E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.message_.CalculateSize(GetStreamHistoryResponse._repeated_message_codec);
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

		// Token: 0x06007A09 RID: 31241 RVA: 0x001DA544 File Offset: 0x001D8744
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamHistoryResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.message_.Add(other.message_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x001DA59F File Offset: 0x001D879F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x001DA5AC File Offset: 0x001D87AC
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
					this.message_.AddEntriesFrom(ref input, GetStreamHistoryResponse._repeated_message_codec);
				}
			}
		}

		// Token: 0x0400374D RID: 14157
		private static readonly MessageParser<GetStreamHistoryResponse> _parser = new MessageParser<GetStreamHistoryResponse>(() => new GetStreamHistoryResponse());

		// Token: 0x0400374E RID: 14158
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400374F RID: 14159
		private int _hasBits0;

		// Token: 0x04003750 RID: 14160
		public const int MessageFieldNumber = 1;

		// Token: 0x04003751 RID: 14161
		private static readonly FieldCodec<StreamMessage> _repeated_message_codec = FieldCodec.ForMessage<StreamMessage>(10U, StreamMessage.Parser);

		// Token: 0x04003752 RID: 14162
		private readonly RepeatedField<StreamMessage> message_ = new RepeatedField<StreamMessage>();

		// Token: 0x04003753 RID: 14163
		public const int ContinuationFieldNumber = 2;

		// Token: 0x04003754 RID: 14164
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04003755 RID: 14165
		private ulong continuation_;
	}
}
