using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C0 RID: 1216
	public sealed class GetSuggestionsResponse : IMessage<GetSuggestionsResponse>, IMessage, IEquatable<GetSuggestionsResponse>, IDeepCloneable<GetSuggestionsResponse>, IBufferMessage
	{
		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x06007649 RID: 30281 RVA: 0x001CD294 File Offset: 0x001CB494
		[DebuggerNonUserCode]
		public static MessageParser<GetSuggestionsResponse> Parser
		{
			get
			{
				return GetSuggestionsResponse._parser;
			}
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x0600764A RID: 30282 RVA: 0x001CD2AC File Offset: 0x001CB4AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[37];
			}
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x0600764B RID: 30283 RVA: 0x001CD2D0 File Offset: 0x001CB4D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSuggestionsResponse.Descriptor;
			}
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x001CD2E7 File Offset: 0x001CB4E7
		[DebuggerNonUserCode]
		public GetSuggestionsResponse()
		{
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x001CD2FC File Offset: 0x001CB4FC
		[DebuggerNonUserCode]
		public GetSuggestionsResponse(GetSuggestionsResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.suggestion_ = other.suggestion_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x001CD34C File Offset: 0x001CB54C
		[DebuggerNonUserCode]
		public GetSuggestionsResponse Clone()
		{
			return new GetSuggestionsResponse(this);
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x001CD364 File Offset: 0x001CB564
		[DebuggerNonUserCode]
		public RepeatedField<ClubSuggestion> Suggestion
		{
			get
			{
				return this.suggestion_;
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x06007650 RID: 30288 RVA: 0x001CD37C File Offset: 0x001CB57C
		// (set) Token: 0x06007651 RID: 30289 RVA: 0x001CD3AD File Offset: 0x001CB5AD
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
					continuationDefaultValue = GetSuggestionsResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x06007652 RID: 30290 RVA: 0x001CD3C8 File Offset: 0x001CB5C8
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x001CD3E5 File Offset: 0x001CB5E5
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x001CD3F8 File Offset: 0x001CB5F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSuggestionsResponse);
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x001CD418 File Offset: 0x001CB618
		[DebuggerNonUserCode]
		public bool Equals(GetSuggestionsResponse other)
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
					bool flag4 = !this.suggestion_.Equals(other.suggestion_);
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

		// Token: 0x06007656 RID: 30294 RVA: 0x001CD48C File Offset: 0x001CB68C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.suggestion_.GetHashCode();
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

		// Token: 0x06007657 RID: 30295 RVA: 0x001CD4EC File Offset: 0x001CB6EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x001CD504 File Offset: 0x001CB704
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x001CD510 File Offset: 0x001CB710
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.suggestion_.WriteTo(ref output, GetSuggestionsResponse._repeated_suggestion_codec);
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

		// Token: 0x0600765A RID: 30298 RVA: 0x001CD570 File Offset: 0x001CB770
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.suggestion_.CalculateSize(GetSuggestionsResponse._repeated_suggestion_codec);
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

		// Token: 0x0600765B RID: 30299 RVA: 0x001CD5D4 File Offset: 0x001CB7D4
		[DebuggerNonUserCode]
		public void MergeFrom(GetSuggestionsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.suggestion_.Add(other.suggestion_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x001CD62F File Offset: 0x001CB82F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x001CD63C File Offset: 0x001CB83C
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
					this.suggestion_.AddEntriesFrom(ref input, GetSuggestionsResponse._repeated_suggestion_codec);
				}
			}
		}

		// Token: 0x040035DE RID: 13790
		private static readonly MessageParser<GetSuggestionsResponse> _parser = new MessageParser<GetSuggestionsResponse>(() => new GetSuggestionsResponse());

		// Token: 0x040035DF RID: 13791
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035E0 RID: 13792
		private int _hasBits0;

		// Token: 0x040035E1 RID: 13793
		public const int SuggestionFieldNumber = 1;

		// Token: 0x040035E2 RID: 13794
		private static readonly FieldCodec<ClubSuggestion> _repeated_suggestion_codec = FieldCodec.ForMessage<ClubSuggestion>(10U, ClubSuggestion.Parser);

		// Token: 0x040035E3 RID: 13795
		private readonly RepeatedField<ClubSuggestion> suggestion_ = new RepeatedField<ClubSuggestion>();

		// Token: 0x040035E4 RID: 13796
		public const int ContinuationFieldNumber = 2;

		// Token: 0x040035E5 RID: 13797
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x040035E6 RID: 13798
		private ulong continuation_;
	}
}
