using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000645 RID: 1605
	public sealed class GetRanksByPositionRequest : IMessage<GetRanksByPositionRequest>, IMessage, IEquatable<GetRanksByPositionRequest>, IDeepCloneable<GetRanksByPositionRequest>, IBufferMessage
	{
		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x06009546 RID: 38214 RVA: 0x00241C68 File Offset: 0x0023FE68
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByPositionRequest> Parser
		{
			get
			{
				return GetRanksByPositionRequest._parser;
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x06009547 RID: 38215 RVA: 0x00241C80 File Offset: 0x0023FE80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x00241CA4 File Offset: 0x0023FEA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByPositionRequest.Descriptor;
			}
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x00241CBB File Offset: 0x0023FEBB
		[DebuggerNonUserCode]
		public GetRanksByPositionRequest()
		{
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x00241CD0 File Offset: 0x0023FED0
		[DebuggerNonUserCode]
		public GetRanksByPositionRequest(GetRanksByPositionRequest other)
			: this()
		{
			this.leaderboardId_ = other.leaderboardId_;
			this.positions_ = other.positions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x00241D08 File Offset: 0x0023FF08
		[DebuggerNonUserCode]
		public GetRanksByPositionRequest Clone()
		{
			return new GetRanksByPositionRequest(this);
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0600954C RID: 38220 RVA: 0x00241D20 File Offset: 0x0023FF20
		// (set) Token: 0x0600954D RID: 38221 RVA: 0x00241D41 File Offset: 0x0023FF41
		[DebuggerNonUserCode]
		public string LeaderboardId
		{
			get
			{
				return this.leaderboardId_ ?? GetRanksByPositionRequest.LeaderboardIdDefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600954E RID: 38222 RVA: 0x00241D58 File Offset: 0x0023FF58
		[DebuggerNonUserCode]
		public bool HasLeaderboardId
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x00241D73 File Offset: 0x0023FF73
		[DebuggerNonUserCode]
		public void ClearLeaderboardId()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x06009550 RID: 38224 RVA: 0x00241D80 File Offset: 0x0023FF80
		[DebuggerNonUserCode]
		public RepeatedField<ulong> Positions
		{
			get
			{
				return this.positions_;
			}
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x00241D98 File Offset: 0x0023FF98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByPositionRequest);
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x00241DB8 File Offset: 0x0023FFB8
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByPositionRequest other)
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
					bool flag4 = this.LeaderboardId != other.LeaderboardId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.positions_.Equals(other.positions_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x00241E2C File Offset: 0x0024002C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num ^= this.LeaderboardId.GetHashCode();
			}
			num ^= this.positions_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x00241E84 File Offset: 0x00240084
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009555 RID: 38229 RVA: 0x00241E9C File Offset: 0x0024009C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x00241EA8 File Offset: 0x002400A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.LeaderboardId);
			}
			this.positions_.WriteTo(ref output, GetRanksByPositionRequest._repeated_positions_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x00241F08 File Offset: 0x00240108
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LeaderboardId);
			}
			num += this.positions_.CalculateSize(GetRanksByPositionRequest._repeated_positions_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x00241F6C File Offset: 0x0024016C
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByPositionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLeaderboardId = other.HasLeaderboardId;
				if (hasLeaderboardId)
				{
					this.LeaderboardId = other.LeaderboardId;
				}
				this.positions_.Add(other.positions_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x00241FC7 File Offset: 0x002401C7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00241FD4 File Offset: 0x002401D4
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
					if (num3 != 16U && num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.positions_.AddEntriesFrom(ref input, GetRanksByPositionRequest._repeated_positions_codec);
					}
				}
				else
				{
					this.LeaderboardId = input.ReadString();
				}
			}
		}

		// Token: 0x0400433C RID: 17212
		private static readonly MessageParser<GetRanksByPositionRequest> _parser = new MessageParser<GetRanksByPositionRequest>(() => new GetRanksByPositionRequest());

		// Token: 0x0400433D RID: 17213
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400433E RID: 17214
		public const int LeaderboardIdFieldNumber = 1;

		// Token: 0x0400433F RID: 17215
		private static readonly string LeaderboardIdDefaultValue = "";

		// Token: 0x04004340 RID: 17216
		private string leaderboardId_;

		// Token: 0x04004341 RID: 17217
		public const int PositionsFieldNumber = 2;

		// Token: 0x04004342 RID: 17218
		private static readonly FieldCodec<ulong> _repeated_positions_codec = FieldCodec.ForUInt64(18U);

		// Token: 0x04004343 RID: 17219
		private readonly RepeatedField<ulong> positions_ = new RepeatedField<ulong>();
	}
}
