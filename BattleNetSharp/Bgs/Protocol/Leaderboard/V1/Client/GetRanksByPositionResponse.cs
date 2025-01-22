using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000646 RID: 1606
	public sealed class GetRanksByPositionResponse : IMessage<GetRanksByPositionResponse>, IMessage, IEquatable<GetRanksByPositionResponse>, IDeepCloneable<GetRanksByPositionResponse>, IBufferMessage
	{
		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x0024207C File Offset: 0x0024027C
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByPositionResponse> Parser
		{
			get
			{
				return GetRanksByPositionResponse._parser;
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x00242094 File Offset: 0x00240294
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600955E RID: 38238 RVA: 0x002420B8 File Offset: 0x002402B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByPositionResponse.Descriptor;
			}
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x002420CF File Offset: 0x002402CF
		[DebuggerNonUserCode]
		public GetRanksByPositionResponse()
		{
		}

		// Token: 0x06009560 RID: 38240 RVA: 0x002420E4 File Offset: 0x002402E4
		[DebuggerNonUserCode]
		public GetRanksByPositionResponse(GetRanksByPositionResponse other)
			: this()
		{
			this.ranks_ = other.ranks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009561 RID: 38241 RVA: 0x00242110 File Offset: 0x00240310
		[DebuggerNonUserCode]
		public GetRanksByPositionResponse Clone()
		{
			return new GetRanksByPositionResponse(this);
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x06009562 RID: 38242 RVA: 0x00242128 File Offset: 0x00240328
		[DebuggerNonUserCode]
		public RepeatedField<Rank> Ranks
		{
			get
			{
				return this.ranks_;
			}
		}

		// Token: 0x06009563 RID: 38243 RVA: 0x00242140 File Offset: 0x00240340
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByPositionResponse);
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x00242160 File Offset: 0x00240360
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByPositionResponse other)
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

		// Token: 0x06009565 RID: 38245 RVA: 0x002421BC File Offset: 0x002403BC
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

		// Token: 0x06009566 RID: 38246 RVA: 0x002421FC File Offset: 0x002403FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x00242214 File Offset: 0x00240414
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x00242220 File Offset: 0x00240420
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ranks_.WriteTo(ref output, GetRanksByPositionResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x0024225C File Offset: 0x0024045C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ranks_.CalculateSize(GetRanksByPositionResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x002422A4 File Offset: 0x002404A4
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByPositionResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ranks_.Add(other.ranks_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x002422E6 File Offset: 0x002404E6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x002422F4 File Offset: 0x002404F4
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
					this.ranks_.AddEntriesFrom(ref input, GetRanksByPositionResponse._repeated_ranks_codec);
				}
			}
		}

		// Token: 0x04004344 RID: 17220
		private static readonly MessageParser<GetRanksByPositionResponse> _parser = new MessageParser<GetRanksByPositionResponse>(() => new GetRanksByPositionResponse());

		// Token: 0x04004345 RID: 17221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004346 RID: 17222
		public const int RanksFieldNumber = 1;

		// Token: 0x04004347 RID: 17223
		private static readonly FieldCodec<Rank> _repeated_ranks_codec = FieldCodec.ForMessage<Rank>(10U, Rank.Parser);

		// Token: 0x04004348 RID: 17224
		private readonly RepeatedField<Rank> ranks_ = new RepeatedField<Rank>();
	}
}
