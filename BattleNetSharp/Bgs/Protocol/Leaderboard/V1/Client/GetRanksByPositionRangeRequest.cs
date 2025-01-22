using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000647 RID: 1607
	public sealed class GetRanksByPositionRangeRequest : IMessage<GetRanksByPositionRangeRequest>, IMessage, IEquatable<GetRanksByPositionRangeRequest>, IDeepCloneable<GetRanksByPositionRangeRequest>, IBufferMessage
	{
		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600956E RID: 38254 RVA: 0x00242378 File Offset: 0x00240578
		[DebuggerNonUserCode]
		public static MessageParser<GetRanksByPositionRangeRequest> Parser
		{
			get
			{
				return GetRanksByPositionRangeRequest._parser;
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x00242390 File Offset: 0x00240590
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x06009570 RID: 38256 RVA: 0x002423B4 File Offset: 0x002405B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRanksByPositionRangeRequest.Descriptor;
			}
		}

		// Token: 0x06009571 RID: 38257 RVA: 0x002423CB File Offset: 0x002405CB
		[DebuggerNonUserCode]
		public GetRanksByPositionRangeRequest()
		{
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x002423D8 File Offset: 0x002405D8
		[DebuggerNonUserCode]
		public GetRanksByPositionRangeRequest(GetRanksByPositionRangeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.leaderboardId_ = other.leaderboardId_;
			this.startPosition_ = other.startPosition_;
			this.endPosition_ = other.endPosition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x00242430 File Offset: 0x00240630
		[DebuggerNonUserCode]
		public GetRanksByPositionRangeRequest Clone()
		{
			return new GetRanksByPositionRangeRequest(this);
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x06009574 RID: 38260 RVA: 0x00242448 File Offset: 0x00240648
		// (set) Token: 0x06009575 RID: 38261 RVA: 0x00242469 File Offset: 0x00240669
		[DebuggerNonUserCode]
		public string LeaderboardId
		{
			get
			{
				return this.leaderboardId_ ?? GetRanksByPositionRangeRequest.LeaderboardIdDefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x06009576 RID: 38262 RVA: 0x00242480 File Offset: 0x00240680
		[DebuggerNonUserCode]
		public bool HasLeaderboardId
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x0024249B File Offset: 0x0024069B
		[DebuggerNonUserCode]
		public void ClearLeaderboardId()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x06009578 RID: 38264 RVA: 0x002424A8 File Offset: 0x002406A8
		// (set) Token: 0x06009579 RID: 38265 RVA: 0x002424D9 File Offset: 0x002406D9
		[DebuggerNonUserCode]
		public ulong StartPosition
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong startPositionDefaultValue;
				if (flag)
				{
					startPositionDefaultValue = this.startPosition_;
				}
				else
				{
					startPositionDefaultValue = GetRanksByPositionRangeRequest.StartPositionDefaultValue;
				}
				return startPositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startPosition_ = value;
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0600957A RID: 38266 RVA: 0x002424F4 File Offset: 0x002406F4
		[DebuggerNonUserCode]
		public bool HasStartPosition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600957B RID: 38267 RVA: 0x00242511 File Offset: 0x00240711
		[DebuggerNonUserCode]
		public void ClearStartPosition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0600957C RID: 38268 RVA: 0x00242524 File Offset: 0x00240724
		// (set) Token: 0x0600957D RID: 38269 RVA: 0x00242555 File Offset: 0x00240755
		[DebuggerNonUserCode]
		public ulong EndPosition
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong endPositionDefaultValue;
				if (flag)
				{
					endPositionDefaultValue = this.endPosition_;
				}
				else
				{
					endPositionDefaultValue = GetRanksByPositionRangeRequest.EndPositionDefaultValue;
				}
				return endPositionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.endPosition_ = value;
			}
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600957E RID: 38270 RVA: 0x00242570 File Offset: 0x00240770
		[DebuggerNonUserCode]
		public bool HasEndPosition
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x0024258D File Offset: 0x0024078D
		[DebuggerNonUserCode]
		public void ClearEndPosition()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x002425A0 File Offset: 0x002407A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRanksByPositionRangeRequest);
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x002425C0 File Offset: 0x002407C0
		[DebuggerNonUserCode]
		public bool Equals(GetRanksByPositionRangeRequest other)
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
						bool flag5 = this.StartPosition != other.StartPosition;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EndPosition != other.EndPosition;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x0024264C File Offset: 0x0024084C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num ^= this.LeaderboardId.GetHashCode();
			}
			bool hasStartPosition = this.HasStartPosition;
			if (hasStartPosition)
			{
				num ^= this.StartPosition.GetHashCode();
			}
			bool hasEndPosition = this.HasEndPosition;
			if (hasEndPosition)
			{
				num ^= this.EndPosition.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x002426D4 File Offset: 0x002408D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x002426EC File Offset: 0x002408EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x002426F8 File Offset: 0x002408F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.LeaderboardId);
			}
			bool hasStartPosition = this.HasStartPosition;
			if (hasStartPosition)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.StartPosition);
			}
			bool hasEndPosition = this.HasEndPosition;
			if (hasEndPosition)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.EndPosition);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x00242788 File Offset: 0x00240988
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LeaderboardId);
			}
			bool hasStartPosition = this.HasStartPosition;
			if (hasStartPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartPosition);
			}
			bool hasEndPosition = this.HasEndPosition;
			if (hasEndPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndPosition);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x00242814 File Offset: 0x00240A14
		[DebuggerNonUserCode]
		public void MergeFrom(GetRanksByPositionRangeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLeaderboardId = other.HasLeaderboardId;
				if (hasLeaderboardId)
				{
					this.LeaderboardId = other.LeaderboardId;
				}
				bool hasStartPosition = other.HasStartPosition;
				if (hasStartPosition)
				{
					this.StartPosition = other.StartPosition;
				}
				bool hasEndPosition = other.HasEndPosition;
				if (hasEndPosition)
				{
					this.EndPosition = other.EndPosition;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x0024288F File Offset: 0x00240A8F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x0024289C File Offset: 0x00240A9C
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndPosition = input.ReadUInt64();
						}
					}
					else
					{
						this.StartPosition = input.ReadUInt64();
					}
				}
				else
				{
					this.LeaderboardId = input.ReadString();
				}
			}
		}

		// Token: 0x04004349 RID: 17225
		private static readonly MessageParser<GetRanksByPositionRangeRequest> _parser = new MessageParser<GetRanksByPositionRangeRequest>(() => new GetRanksByPositionRangeRequest());

		// Token: 0x0400434A RID: 17226
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400434B RID: 17227
		private int _hasBits0;

		// Token: 0x0400434C RID: 17228
		public const int LeaderboardIdFieldNumber = 1;

		// Token: 0x0400434D RID: 17229
		private static readonly string LeaderboardIdDefaultValue = "";

		// Token: 0x0400434E RID: 17230
		private string leaderboardId_;

		// Token: 0x0400434F RID: 17231
		public const int StartPositionFieldNumber = 2;

		// Token: 0x04004350 RID: 17232
		private static readonly ulong StartPositionDefaultValue = 0UL;

		// Token: 0x04004351 RID: 17233
		private ulong startPosition_;

		// Token: 0x04004352 RID: 17234
		public const int EndPositionFieldNumber = 3;

		// Token: 0x04004353 RID: 17235
		private static readonly ulong EndPositionDefaultValue = 0UL;

		// Token: 0x04004354 RID: 17236
		private ulong endPosition_;
	}
}
