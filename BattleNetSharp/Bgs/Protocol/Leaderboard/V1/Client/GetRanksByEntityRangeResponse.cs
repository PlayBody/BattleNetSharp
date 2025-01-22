using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x0200064A RID: 1610
	public sealed class GetRanksByEntityRangeResponse : IMessage<GetRanksByEntityRangeResponse>, IMessage, IEquatable<GetRanksByEntityRangeResponse>, IDeepCloneable<GetRanksByEntityRangeResponse>, IBufferMessage
	{
		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x060095C2 RID: 38338 RVA: 0x00243498 File Offset: 0x00241698
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByEntityRangeResponse> Parser
		{
			get
			{
				return GetRanksByEntityRangeResponse._parser;
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x060095C3 RID: 38339 RVA: 0x002434B0 File Offset: 0x002416B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x060095C4 RID: 38340 RVA: 0x002434D4 File Offset: 0x002416D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByEntityRangeResponse.Descriptor;
			}
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x002434EB File Offset: 0x002416EB
		[DebuggerNonUserCode]
		public GetRanksByEntityRangeResponse()
		{
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x00243500 File Offset: 0x00241700
		[DebuggerNonUserCode]
		public GetRanksByEntityRangeResponse(GetRanksByEntityRangeResponse other)
			: this()
		{
			this.ranks_ = other.ranks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095C7 RID: 38343 RVA: 0x0024352C File Offset: 0x0024172C
		[DebuggerNonUserCode]
		public GetRanksByEntityRangeResponse Clone()
		{
			return new GetRanksByEntityRangeResponse(this);
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x060095C8 RID: 38344 RVA: 0x00243544 File Offset: 0x00241744
		[DebuggerNonUserCode]
		public RepeatedField<Rank> Ranks
		{
			get
			{
				return this.ranks_;
			}
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x0024355C File Offset: 0x0024175C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByEntityRangeResponse);
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x0024357C File Offset: 0x0024177C
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByEntityRangeResponse other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060095CB RID: 38347 RVA: 0x002435D8 File Offset: 0x002417D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ranks_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095CC RID: 38348 RVA: 0x00243618 File Offset: 0x00241818
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x00243630 File Offset: 0x00241830
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095CE RID: 38350 RVA: 0x0024363C File Offset: 0x0024183C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ranks_.WriteTo(ref output, GetRanksByEntityRangeResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095CF RID: 38351 RVA: 0x00243678 File Offset: 0x00241878
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ranks_.CalculateSize(GetRanksByEntityRangeResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x002436C0 File Offset: 0x002418C0
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByEntityRangeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ranks_.Add(other.ranks_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060095D1 RID: 38353 RVA: 0x00243702 File Offset: 0x00241902
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x00243710 File Offset: 0x00241910
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
					this.ranks_.AddEntriesFrom(ref input, GetRanksByEntityRangeResponse._repeated_ranks_codec);
				}
			}
		}

		// Token: 0x0400436D RID: 17261
		private static readonly MessageParser<GetRanksByEntityRangeResponse> _parser = new MessageParser<GetRanksByEntityRangeResponse>(() => new GetRanksByEntityRangeResponse());

		// Token: 0x0400436E RID: 17262
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400436F RID: 17263
		public const int RanksFieldNumber = 1;

		// Token: 0x04004370 RID: 17264
		private static readonly FieldCodec<Rank> _repeated_ranks_codec = FieldCodec.ForMessage<Rank>(10U, Rank.Parser);

		// Token: 0x04004371 RID: 17265
		private readonly RepeatedField<Rank> ranks_ = new RepeatedField<Rank>();
	}
}
