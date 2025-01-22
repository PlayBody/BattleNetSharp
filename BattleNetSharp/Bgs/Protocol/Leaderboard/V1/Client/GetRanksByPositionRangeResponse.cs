using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000648 RID: 1608
	public sealed class GetRanksByPositionRangeResponse : IMessage<GetRanksByPositionRangeResponse>, IMessage, IEquatable<GetRanksByPositionRangeResponse>, IDeepCloneable<GetRanksByPositionRangeResponse>, IBufferMessage
	{
		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x0600958B RID: 38283 RVA: 0x00242950 File Offset: 0x00240B50
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByPositionRangeResponse> Parser
		{
			get
			{
				return GetRanksByPositionRangeResponse._parser;
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0600958C RID: 38284 RVA: 0x00242968 File Offset: 0x00240B68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600958D RID: 38285 RVA: 0x0024298C File Offset: 0x00240B8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByPositionRangeResponse.Descriptor;
			}
		}

		// Token: 0x0600958E RID: 38286 RVA: 0x002429A3 File Offset: 0x00240BA3
		[DebuggerNonUserCode]
		public GetRanksByPositionRangeResponse()
		{
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x002429B8 File Offset: 0x00240BB8
		[DebuggerNonUserCode]
		public GetRanksByPositionRangeResponse(GetRanksByPositionRangeResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.totalCount_ = other.totalCount_;
			this.ranks_ = other.ranks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x00242A08 File Offset: 0x00240C08
		[DebuggerNonUserCode]
		public GetRanksByPositionRangeResponse Clone()
		{
			return new GetRanksByPositionRangeResponse(this);
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x06009591 RID: 38289 RVA: 0x00242A20 File Offset: 0x00240C20
		// (set) Token: 0x06009592 RID: 38290 RVA: 0x00242A51 File Offset: 0x00240C51
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
					totalCountDefaultValue = GetRanksByPositionRangeResponse.TotalCountDefaultValue;
				}
				return totalCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.totalCount_ = value;
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x06009593 RID: 38291 RVA: 0x00242A6C File Offset: 0x00240C6C
		[DebuggerNonUserCode]
		public bool HasTotalCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x00242A89 File Offset: 0x00240C89
		[DebuggerNonUserCode]
		public void ClearTotalCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x06009595 RID: 38293 RVA: 0x00242A9C File Offset: 0x00240C9C
		[DebuggerNonUserCode]
		public RepeatedField<Rank> Ranks
		{
			get
			{
				return this.ranks_;
			}
		}

		// Token: 0x06009596 RID: 38294 RVA: 0x00242AB4 File Offset: 0x00240CB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByPositionRangeResponse);
		}

		// Token: 0x06009597 RID: 38295 RVA: 0x00242AD4 File Offset: 0x00240CD4
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByPositionRangeResponse other)
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
						bool flag5 = !this.ranks_.Equals(other.ranks_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x00242B48 File Offset: 0x00240D48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTotalCount = this.HasTotalCount;
			if (hasTotalCount)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			num ^= this.ranks_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009599 RID: 38297 RVA: 0x00242BA8 File Offset: 0x00240DA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x00242BC0 File Offset: 0x00240DC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x00242BCC File Offset: 0x00240DCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTotalCount = this.HasTotalCount;
			if (hasTotalCount)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.TotalCount);
			}
			this.ranks_.WriteTo(ref output, GetRanksByPositionRangeResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x00242C2C File Offset: 0x00240E2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTotalCount = this.HasTotalCount;
			if (hasTotalCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.TotalCount);
			}
			num += this.ranks_.CalculateSize(GetRanksByPositionRangeResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x00242C90 File Offset: 0x00240E90
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByPositionRangeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTotalCount = other.HasTotalCount;
				if (hasTotalCount)
				{
					this.TotalCount = other.TotalCount;
				}
				this.ranks_.Add(other.ranks_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600959E RID: 38302 RVA: 0x00242CEB File Offset: 0x00240EEB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600959F RID: 38303 RVA: 0x00242CF8 File Offset: 0x00240EF8
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ranks_.AddEntriesFrom(ref input, GetRanksByPositionRangeResponse._repeated_ranks_codec);
					}
				}
				else
				{
					this.TotalCount = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004355 RID: 17237
		private static readonly MessageParser<GetRanksByPositionRangeResponse> _parser = new MessageParser<GetRanksByPositionRangeResponse>(() => new GetRanksByPositionRangeResponse());

		// Token: 0x04004356 RID: 17238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004357 RID: 17239
		private int _hasBits0;

		// Token: 0x04004358 RID: 17240
		public const int TotalCountFieldNumber = 1;

		// Token: 0x04004359 RID: 17241
		private static readonly ulong TotalCountDefaultValue = 0UL;

		// Token: 0x0400435A RID: 17242
		private ulong totalCount_;

		// Token: 0x0400435B RID: 17243
		public const int RanksFieldNumber = 2;

		// Token: 0x0400435C RID: 17244
		private static readonly FieldCodec<Rank> _repeated_ranks_codec = FieldCodec.ForMessage<Rank>(18U, Rank.Parser);

		// Token: 0x0400435D RID: 17245
		private readonly RepeatedField<Rank> ranks_ = new RepeatedField<Rank>();
	}
}
