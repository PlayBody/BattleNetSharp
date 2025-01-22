using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000649 RID: 1609
	public sealed class GetRanksByEntityRangeRequest : IMessage<GetRanksByEntityRangeRequest>, IMessage, IEquatable<GetRanksByEntityRangeRequest>, IDeepCloneable<GetRanksByEntityRangeRequest>, IBufferMessage
	{
		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x060095A1 RID: 38305 RVA: 0x00242D98 File Offset: 0x00240F98
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByEntityRangeRequest> Parser
		{
			get
			{
				return GetRanksByEntityRangeRequest._parser;
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x060095A2 RID: 38306 RVA: 0x00242DB0 File Offset: 0x00240FB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x060095A3 RID: 38307 RVA: 0x00242DD4 File Offset: 0x00240FD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByEntityRangeRequest.Descriptor;
			}
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x00242DEB File Offset: 0x00240FEB
		[DebuggerNonUserCode]
		public GetRanksByEntityRangeRequest()
		{
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x00242DF8 File Offset: 0x00240FF8
		[DebuggerNonUserCode]
		public GetRanksByEntityRangeRequest(GetRanksByEntityRangeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.leaderboardId_ = other.leaderboardId_;
			this.entityId_ = other.entityId_;
			this.ranksAbove_ = other.ranksAbove_;
			this.ranksBelow_ = other.ranksBelow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x00242E5C File Offset: 0x0024105C
		[DebuggerNonUserCode]
		public GetRanksByEntityRangeRequest Clone()
		{
			return new GetRanksByEntityRangeRequest(this);
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x060095A7 RID: 38311 RVA: 0x00242E74 File Offset: 0x00241074
		// (set) Token: 0x060095A8 RID: 38312 RVA: 0x00242E95 File Offset: 0x00241095
		[DebuggerNonUserCode]
		public string LeaderboardId
		{
			get
			{
				return this.leaderboardId_ ?? GetRanksByEntityRangeRequest.LeaderboardIdDefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x060095A9 RID: 38313 RVA: 0x00242EAC File Offset: 0x002410AC
		[DebuggerNonUserCode]
		public bool HasLeaderboardId
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x00242EC7 File Offset: 0x002410C7
		[DebuggerNonUserCode]
		public void ClearLeaderboardId()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x060095AB RID: 38315 RVA: 0x00242ED4 File Offset: 0x002410D4
		// (set) Token: 0x060095AC RID: 38316 RVA: 0x00242EF5 File Offset: 0x002410F5
		[DebuggerNonUserCode]
		public string EntityId
		{
			get
			{
				return this.entityId_ ?? GetRanksByEntityRangeRequest.EntityIdDefaultValue;
			}
			set
			{
				this.entityId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x060095AD RID: 38317 RVA: 0x00242F0C File Offset: 0x0024110C
		[DebuggerNonUserCode]
		public bool HasEntityId
		{
			get
			{
				return this.entityId_ != null;
			}
		}

		// Token: 0x060095AE RID: 38318 RVA: 0x00242F27 File Offset: 0x00241127
		[DebuggerNonUserCode]
		public void ClearEntityId()
		{
			this.entityId_ = null;
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x060095AF RID: 38319 RVA: 0x00242F34 File Offset: 0x00241134
		// (set) Token: 0x060095B0 RID: 38320 RVA: 0x00242F65 File Offset: 0x00241165
		[DebuggerNonUserCode]
		public uint RanksAbove
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint ranksAboveDefaultValue;
				if (flag)
				{
					ranksAboveDefaultValue = this.ranksAbove_;
				}
				else
				{
					ranksAboveDefaultValue = GetRanksByEntityRangeRequest.RanksAboveDefaultValue;
				}
				return ranksAboveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.ranksAbove_ = value;
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x060095B1 RID: 38321 RVA: 0x00242F80 File Offset: 0x00241180
		[DebuggerNonUserCode]
		public bool HasRanksAbove
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x00242F9D File Offset: 0x0024119D
		[DebuggerNonUserCode]
		public void ClearRanksAbove()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x060095B3 RID: 38323 RVA: 0x00242FB0 File Offset: 0x002411B0
		// (set) Token: 0x060095B4 RID: 38324 RVA: 0x00242FE1 File Offset: 0x002411E1
		[DebuggerNonUserCode]
		public uint RanksBelow
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint ranksBelowDefaultValue;
				if (flag)
				{
					ranksBelowDefaultValue = this.ranksBelow_;
				}
				else
				{
					ranksBelowDefaultValue = GetRanksByEntityRangeRequest.RanksBelowDefaultValue;
				}
				return ranksBelowDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.ranksBelow_ = value;
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x060095B5 RID: 38325 RVA: 0x00242FFC File Offset: 0x002411FC
		[DebuggerNonUserCode]
		public bool HasRanksBelow
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x00243019 File Offset: 0x00241219
		[DebuggerNonUserCode]
		public void ClearRanksBelow()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x0024302C File Offset: 0x0024122C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByEntityRangeRequest);
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x0024304C File Offset: 0x0024124C
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByEntityRangeRequest other)
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
						bool flag5 = this.EntityId != other.EntityId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.RanksAbove != other.RanksAbove;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RanksBelow != other.RanksBelow;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x002430F8 File Offset: 0x002412F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num ^= this.LeaderboardId.GetHashCode();
			}
			bool hasEntityId = this.HasEntityId;
			if (hasEntityId)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasRanksAbove = this.HasRanksAbove;
			if (hasRanksAbove)
			{
				num ^= this.RanksAbove.GetHashCode();
			}
			bool hasRanksBelow = this.HasRanksBelow;
			if (hasRanksBelow)
			{
				num ^= this.RanksBelow.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00243198 File Offset: 0x00241398
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x002431B0 File Offset: 0x002413B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x002431BC File Offset: 0x002413BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.LeaderboardId);
			}
			bool hasEntityId = this.HasEntityId;
			if (hasEntityId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.EntityId);
			}
			bool hasRanksAbove = this.HasRanksAbove;
			if (hasRanksAbove)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.RanksAbove);
			}
			bool hasRanksBelow = this.HasRanksBelow;
			if (hasRanksBelow)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RanksBelow);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x00243270 File Offset: 0x00241470
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LeaderboardId);
			}
			bool hasEntityId = this.HasEntityId;
			if (hasEntityId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EntityId);
			}
			bool hasRanksAbove = this.HasRanksAbove;
			if (hasRanksAbove)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RanksAbove);
			}
			bool hasRanksBelow = this.HasRanksBelow;
			if (hasRanksBelow)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RanksBelow);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x00243318 File Offset: 0x00241518
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByEntityRangeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLeaderboardId = other.HasLeaderboardId;
				if (hasLeaderboardId)
				{
					this.LeaderboardId = other.LeaderboardId;
				}
				bool hasEntityId = other.HasEntityId;
				if (hasEntityId)
				{
					this.EntityId = other.EntityId;
				}
				bool hasRanksAbove = other.HasRanksAbove;
				if (hasRanksAbove)
				{
					this.RanksAbove = other.RanksAbove;
				}
				bool hasRanksBelow = other.HasRanksBelow;
				if (hasRanksBelow)
				{
					this.RanksBelow = other.RanksBelow;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x002433AE File Offset: 0x002415AE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x002433BC File Offset: 0x002415BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0029;
						}
						this.EntityId = input.ReadString();
					}
					else
					{
						this.LeaderboardId = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.RanksBelow = input.ReadUInt32();
				}
				else
				{
					this.RanksAbove = input.ReadUInt32();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400435E RID: 17246
		private static readonly MessageParser<GetRanksByEntityRangeRequest> _parser = new MessageParser<GetRanksByEntityRangeRequest>(() => new GetRanksByEntityRangeRequest());

		// Token: 0x0400435F RID: 17247
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004360 RID: 17248
		private int _hasBits0;

		// Token: 0x04004361 RID: 17249
		public const int LeaderboardIdFieldNumber = 1;

		// Token: 0x04004362 RID: 17250
		private static readonly string LeaderboardIdDefaultValue = "";

		// Token: 0x04004363 RID: 17251
		private string leaderboardId_;

		// Token: 0x04004364 RID: 17252
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04004365 RID: 17253
		private static readonly string EntityIdDefaultValue = "";

		// Token: 0x04004366 RID: 17254
		private string entityId_;

		// Token: 0x04004367 RID: 17255
		public const int RanksAboveFieldNumber = 3;

		// Token: 0x04004368 RID: 17256
		private static readonly uint RanksAboveDefaultValue = 0U;

		// Token: 0x04004369 RID: 17257
		private uint ranksAbove_;

		// Token: 0x0400436A RID: 17258
		public const int RanksBelowFieldNumber = 4;

		// Token: 0x0400436B RID: 17259
		private static readonly uint RanksBelowDefaultValue = 0U;

		// Token: 0x0400436C RID: 17260
		private uint ranksBelow_;
	}
}
