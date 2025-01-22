using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x0200064C RID: 1612
	public sealed class GetRanksByEntityIdsResponse : IMessage<GetRanksByEntityIdsResponse>, IMessage, IEquatable<GetRanksByEntityIdsResponse>, IDeepCloneable<GetRanksByEntityIdsResponse>, IBufferMessage
	{
		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x060095EA RID: 38378 RVA: 0x00243BA0 File Offset: 0x00241DA0
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByEntityIdsResponse> Parser
		{
			get
			{
				return GetRanksByEntityIdsResponse._parser;
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x060095EB RID: 38379 RVA: 0x00243BB8 File Offset: 0x00241DB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x060095EC RID: 38380 RVA: 0x00243BDC File Offset: 0x00241DDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByEntityIdsResponse.Descriptor;
			}
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x00243BF3 File Offset: 0x00241DF3
		[DebuggerNonUserCode]
		public GetRanksByEntityIdsResponse()
		{
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x00243C08 File Offset: 0x00241E08
		[DebuggerNonUserCode]
		public GetRanksByEntityIdsResponse(GetRanksByEntityIdsResponse other)
			: this()
		{
			this.ranks_ = other.ranks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x00243C34 File Offset: 0x00241E34
		[DebuggerNonUserCode]
		public GetRanksByEntityIdsResponse Clone()
		{
			return new GetRanksByEntityIdsResponse(this);
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x060095F0 RID: 38384 RVA: 0x00243C4C File Offset: 0x00241E4C
		[DebuggerNonUserCode]
		public RepeatedField<Rank> Ranks
		{
			get
			{
				return this.ranks_;
			}
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x00243C64 File Offset: 0x00241E64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByEntityIdsResponse);
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x00243C84 File Offset: 0x00241E84
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByEntityIdsResponse other)
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

		// Token: 0x060095F3 RID: 38387 RVA: 0x00243CE0 File Offset: 0x00241EE0
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

		// Token: 0x060095F4 RID: 38388 RVA: 0x00243D20 File Offset: 0x00241F20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00243D38 File Offset: 0x00241F38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x00243D44 File Offset: 0x00241F44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ranks_.WriteTo(ref output, GetRanksByEntityIdsResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x00243D80 File Offset: 0x00241F80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ranks_.CalculateSize(GetRanksByEntityIdsResponse._repeated_ranks_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x00243DC8 File Offset: 0x00241FC8
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByEntityIdsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ranks_.Add(other.ranks_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x00243E0A File Offset: 0x0024200A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x00243E18 File Offset: 0x00242018
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
					this.ranks_.AddEntriesFrom(ref input, GetRanksByEntityIdsResponse._repeated_ranks_codec);
				}
			}
		}

		// Token: 0x0400437A RID: 17274
		private static readonly MessageParser<GetRanksByEntityIdsResponse> _parser = new MessageParser<GetRanksByEntityIdsResponse>(() => new GetRanksByEntityIdsResponse());

		// Token: 0x0400437B RID: 17275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400437C RID: 17276
		public const int RanksFieldNumber = 1;

		// Token: 0x0400437D RID: 17277
		private static readonly FieldCodec<Rank> _repeated_ranks_codec = FieldCodec.ForMessage<Rank>(10U, Rank.Parser);

		// Token: 0x0400437E RID: 17278
		private readonly RepeatedField<Rank> ranks_ = new RepeatedField<Rank>();
	}
}
