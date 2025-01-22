using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000644 RID: 1604
	public sealed class GetRanksResponse : IMessage<GetRanksResponse>, IMessage, IEquatable<GetRanksResponse>, IDeepCloneable<GetRanksResponse>, IBufferMessage
	{
		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600952C RID: 38188 RVA: 0x002416EC File Offset: 0x0023F8EC
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksResponse> Parser
		{
			get
			{
				return GetRanksResponse._parser;
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600952D RID: 38189 RVA: 0x00241704 File Offset: 0x0023F904
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600952E RID: 38190 RVA: 0x00241728 File Offset: 0x0023F928
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksResponse.Descriptor;
			}
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x0024173F File Offset: 0x0023F93F
		[DebuggerNonUserCode]
		public GetRanksResponse()
		{
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x00241754 File Offset: 0x0023F954
		[DebuggerNonUserCode]
		public GetRanksResponse(GetRanksResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.totalCount_ = other.totalCount_;
			this.continuation_ = other.continuation_;
			this.ranks_ = other.ranks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x002417B0 File Offset: 0x0023F9B0
		[DebuggerNonUserCode]
		public GetRanksResponse Clone()
		{
			return new GetRanksResponse(this);
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x06009532 RID: 38194 RVA: 0x002417C8 File Offset: 0x0023F9C8
		// (set) Token: 0x06009533 RID: 38195 RVA: 0x002417F9 File Offset: 0x0023F9F9
		[DebuggerNonUserCode]
		public ulong TotalCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong totalCountDefaultValue;
				if (flag)
				{
					totalCountDefaultValue = this.totalCount_;
				}
				else
				{
					totalCountDefaultValue = GetRanksResponse.TotalCountDefaultValue;
				}
				return totalCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.totalCount_ = value;
			}
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x00241814 File Offset: 0x0023FA14
		[DebuggerNonUserCode]
		public bool HasTotalCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x00241831 File Offset: 0x0023FA31
		[DebuggerNonUserCode]
		public void ClearTotalCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x06009536 RID: 38198 RVA: 0x00241844 File Offset: 0x0023FA44
		// (set) Token: 0x06009537 RID: 38199 RVA: 0x00241875 File Offset: 0x0023FA75
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetRanksResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.continuation_ = value;
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x06009538 RID: 38200 RVA: 0x00241890 File Offset: 0x0023FA90
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009539 RID: 38201 RVA: 0x002418AD File Offset: 0x0023FAAD
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600953A RID: 38202 RVA: 0x002418C0 File Offset: 0x0023FAC0
		[DebuggerNonUserCode]
		public RepeatedField<Rank> Ranks
		{
			get
			{
				return this.ranks_;
			}
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x002418D8 File Offset: 0x0023FAD8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksResponse);
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x002418F8 File Offset: 0x0023FAF8
		[DebuggerNonUserCode]
		public bool Equals(GetRanksResponse other)
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
					bool flag4 = this.TotalCount != other.TotalCount;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Continuation != other.Continuation;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.ranks_.Equals(other.ranks_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00241988 File Offset: 0x0023FB88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTotalCount = this.HasTotalCount;
			if (hasTotalCount)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			num ^= this.ranks_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x00241A04 File Offset: 0x0023FC04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x00241A1C File Offset: 0x0023FC1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x00241A28 File Offset: 0x0023FC28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTotalCount = this.HasTotalCount;
			if (hasTotalCount)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.TotalCount);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Continuation);
			}
			this.ranks_.WriteTo(ref output, GetRanksResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009541 RID: 38209 RVA: 0x00241AA8 File Offset: 0x0023FCA8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTotalCount = this.HasTotalCount;
			if (hasTotalCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.TotalCount);
			}
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			num += this.ranks_.CalculateSize(GetRanksResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009542 RID: 38210 RVA: 0x00241B28 File Offset: 0x0023FD28
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTotalCount = other.HasTotalCount;
				if (hasTotalCount)
				{
					this.TotalCount = other.TotalCount;
				}
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this.ranks_.Add(other.ranks_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009543 RID: 38211 RVA: 0x00241B9C File Offset: 0x0023FD9C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009544 RID: 38212 RVA: 0x00241BA8 File Offset: 0x0023FDA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ranks_.AddEntriesFrom(ref input, GetRanksResponse._repeated_ranks_codec);
						}
					}
					else
					{
						this.Continuation = input.ReadUInt64();
					}
				}
				else
				{
					this.TotalCount = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004330 RID: 17200
		private static readonly MessageParser<GetRanksResponse> _parser = new MessageParser<GetRanksResponse>(() => new GetRanksResponse());

		// Token: 0x04004331 RID: 17201
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004332 RID: 17202
		private int _hasBits0;

		// Token: 0x04004333 RID: 17203
		public const int TotalCountFieldNumber = 1;

		// Token: 0x04004334 RID: 17204
		private static readonly ulong TotalCountDefaultValue = 0UL;

		// Token: 0x04004335 RID: 17205
		private ulong totalCount_;

		// Token: 0x04004336 RID: 17206
		public const int ContinuationFieldNumber = 2;

		// Token: 0x04004337 RID: 17207
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04004338 RID: 17208
		private ulong continuation_;

		// Token: 0x04004339 RID: 17209
		public const int RanksFieldNumber = 3;

		// Token: 0x0400433A RID: 17210
		private static readonly FieldCodec<Rank> _repeated_ranks_codec = FieldCodec.ForMessage<Rank>(26U, Rank.Parser);

		// Token: 0x0400433B RID: 17211
		private readonly RepeatedField<Rank> ranks_ = new RepeatedField<Rank>();
	}
}
