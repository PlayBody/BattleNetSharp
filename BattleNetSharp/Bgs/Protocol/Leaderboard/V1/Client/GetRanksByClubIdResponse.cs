using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x0200064E RID: 1614
	public sealed class GetRanksByClubIdResponse : IMessage<GetRanksByClubIdResponse>, IMessage, IEquatable<GetRanksByClubIdResponse>, IDeepCloneable<GetRanksByClubIdResponse>, IBufferMessage
	{
		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x06009619 RID: 38425 RVA: 0x00244474 File Offset: 0x00242674
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByClubIdResponse> Parser
		{
			get
			{
				return GetRanksByClubIdResponse._parser;
			}
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600961A RID: 38426 RVA: 0x0024448C File Offset: 0x0024268C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x002444B0 File Offset: 0x002426B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByClubIdResponse.Descriptor;
			}
		}

		// Token: 0x0600961C RID: 38428 RVA: 0x002444C7 File Offset: 0x002426C7
		[DebuggerNonUserCode]
		public GetRanksByClubIdResponse()
		{
		}

		// Token: 0x0600961D RID: 38429 RVA: 0x002444DC File Offset: 0x002426DC
		[DebuggerNonUserCode]
		public GetRanksByClubIdResponse(GetRanksByClubIdResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ranks_ = other.ranks_.Clone();
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x0024452C File Offset: 0x0024272C
		[DebuggerNonUserCode]
		public GetRanksByClubIdResponse Clone()
		{
			return new GetRanksByClubIdResponse(this);
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600961F RID: 38431 RVA: 0x00244544 File Offset: 0x00242744
		[DebuggerNonUserCode]
		public RepeatedField<Rank> Ranks
		{
			get
			{
				return this.ranks_;
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x06009620 RID: 38432 RVA: 0x0024455C File Offset: 0x0024275C
		// (set) Token: 0x06009621 RID: 38433 RVA: 0x0024458D File Offset: 0x0024278D
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
					continuationDefaultValue = GetRanksByClubIdResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x06009622 RID: 38434 RVA: 0x002445A8 File Offset: 0x002427A8
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x002445C5 File Offset: 0x002427C5
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x002445D8 File Offset: 0x002427D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByClubIdResponse);
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x002445F8 File Offset: 0x002427F8
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByClubIdResponse other)
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
					bool flag4 = !this.ranks_.Equals(other.ranks_);
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

		// Token: 0x06009626 RID: 38438 RVA: 0x0024466C File Offset: 0x0024286C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ranks_.GetHashCode();
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

		// Token: 0x06009627 RID: 38439 RVA: 0x002446CC File Offset: 0x002428CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009628 RID: 38440 RVA: 0x002446E4 File Offset: 0x002428E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009629 RID: 38441 RVA: 0x002446F0 File Offset: 0x002428F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ranks_.WriteTo(ref output, GetRanksByClubIdResponse._repeated_ranks_codec);
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

		// Token: 0x0600962A RID: 38442 RVA: 0x00244750 File Offset: 0x00242950
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ranks_.CalculateSize(GetRanksByClubIdResponse._repeated_ranks_codec);
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

		// Token: 0x0600962B RID: 38443 RVA: 0x002447B4 File Offset: 0x002429B4
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByClubIdResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ranks_.Add(other.ranks_);
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600962C RID: 38444 RVA: 0x0024480F File Offset: 0x00242A0F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600962D RID: 38445 RVA: 0x0024481C File Offset: 0x00242A1C
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
					this.ranks_.AddEntriesFrom(ref input, GetRanksByClubIdResponse._repeated_ranks_codec);
				}
			}
		}

		// Token: 0x0400438B RID: 17291
		private static readonly MessageParser<GetRanksByClubIdResponse> _parser = new MessageParser<GetRanksByClubIdResponse>(() => new GetRanksByClubIdResponse());

		// Token: 0x0400438C RID: 17292
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400438D RID: 17293
		private int _hasBits0;

		// Token: 0x0400438E RID: 17294
		public const int RanksFieldNumber = 1;

		// Token: 0x0400438F RID: 17295
		private static readonly FieldCodec<Rank> _repeated_ranks_codec = FieldCodec.ForMessage<Rank>(10U, Rank.Parser);

		// Token: 0x04004390 RID: 17296
		private readonly RepeatedField<Rank> ranks_ = new RepeatedField<Rank>();

		// Token: 0x04004391 RID: 17297
		public const int ContinuationFieldNumber = 2;

		// Token: 0x04004392 RID: 17298
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04004393 RID: 17299
		private ulong continuation_;
	}
}
