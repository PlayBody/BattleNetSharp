using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000653 RID: 1619
	public sealed class Rank : IMessage<Rank>, IMessage, IEquatable<Rank>, IDeepCloneable<Rank>, IBufferMessage
	{
		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x06009671 RID: 38513 RVA: 0x00245ABC File Offset: 0x00243CBC
		[DebuggerNonUserCode]
		public static MessageParser<Rank> Parser
		{
			get
			{
				return Rank._parser;
			}
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x06009672 RID: 38514 RVA: 0x00245AD4 File Offset: 0x00243CD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x06009673 RID: 38515 RVA: 0x00245AF8 File Offset: 0x00243CF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Rank.Descriptor;
			}
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x00245B0F File Offset: 0x00243D0F
		[DebuggerNonUserCode]
		public Rank()
		{
		}

		// Token: 0x06009675 RID: 38517 RVA: 0x00245B1C File Offset: 0x00243D1C
		[DebuggerNonUserCode]
		public Rank(Rank other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.user_ = ((other.user_ != null) ? other.user_.Clone() : null);
			this.leaderboardId_ = other.leaderboardId_;
			this.entityId_ = other.entityId_;
			this.battleTag_ = other.battleTag_;
			this.creationTimeMs_ = other.creationTimeMs_;
			this.position_ = other.position_;
			this.score_ = ((other.score_ != null) ? other.score_.Clone() : null);
			this.account_ = ((other.account_ != null) ? other.account_.Clone() : null);
			this.payloade0Pad_ = other.payloade0Pad_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x00245BF8 File Offset: 0x00243DF8
		[DebuggerNonUserCode]
		public Rank Clone()
		{
			return new Rank(this);
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x06009677 RID: 38519 RVA: 0x00245C10 File Offset: 0x00243E10
		// (set) Token: 0x06009678 RID: 38520 RVA: 0x00245C28 File Offset: 0x00243E28
		[DebuggerNonUserCode]
		public Identity User
		{
			get
			{
				return this.user_;
			}
			set
			{
				this.user_ = value;
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x00245C34 File Offset: 0x00243E34
		// (set) Token: 0x0600967A RID: 38522 RVA: 0x00245C55 File Offset: 0x00243E55
		[DebuggerNonUserCode]
		public string LeaderboardId
		{
			get
			{
				return this.leaderboardId_ ?? Rank.LeaderboardIdDefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600967B RID: 38523 RVA: 0x00245C6C File Offset: 0x00243E6C
		[DebuggerNonUserCode]
		public bool HasLeaderboardId
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x0600967C RID: 38524 RVA: 0x00245C87 File Offset: 0x00243E87
		[DebuggerNonUserCode]
		public void ClearLeaderboardId()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600967D RID: 38525 RVA: 0x00245C94 File Offset: 0x00243E94
		// (set) Token: 0x0600967E RID: 38526 RVA: 0x00245CB5 File Offset: 0x00243EB5
		[DebuggerNonUserCode]
		public string EntityId
		{
			get
			{
				return this.entityId_ ?? Rank.EntityIdDefaultValue;
			}
			set
			{
				this.entityId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600967F RID: 38527 RVA: 0x00245CCC File Offset: 0x00243ECC
		[DebuggerNonUserCode]
		public bool HasEntityId
		{
			get
			{
				return this.entityId_ != null;
			}
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x00245CE7 File Offset: 0x00243EE7
		[DebuggerNonUserCode]
		public void ClearEntityId()
		{
			this.entityId_ = null;
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x06009681 RID: 38529 RVA: 0x00245CF4 File Offset: 0x00243EF4
		// (set) Token: 0x06009682 RID: 38530 RVA: 0x00245D15 File Offset: 0x00243F15
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? Rank.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x06009683 RID: 38531 RVA: 0x00245D2C File Offset: 0x00243F2C
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x00245D47 File Offset: 0x00243F47
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x00245D54 File Offset: 0x00243F54
		// (set) Token: 0x06009686 RID: 38534 RVA: 0x00245D85 File Offset: 0x00243F85
		[DebuggerNonUserCode]
		public ulong CreationTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeMsDefaultValue;
				if (flag)
				{
					creationTimeMsDefaultValue = this.creationTimeMs_;
				}
				else
				{
					creationTimeMsDefaultValue = Rank.CreationTimeMsDefaultValue;
				}
				return creationTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTimeMs_ = value;
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x06009687 RID: 38535 RVA: 0x00245DA0 File Offset: 0x00243FA0
		[DebuggerNonUserCode]
		public bool HasCreationTimeMs
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x00245DBD File Offset: 0x00243FBD
		[DebuggerNonUserCode]
		public void ClearCreationTimeMs()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x06009689 RID: 38537 RVA: 0x00245DD0 File Offset: 0x00243FD0
		// (set) Token: 0x0600968A RID: 38538 RVA: 0x00245E01 File Offset: 0x00244001
		[DebuggerNonUserCode]
		public ulong Position
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong positionDefaultValue;
				if (flag)
				{
					positionDefaultValue = this.position_;
				}
				else
				{
					positionDefaultValue = Rank.PositionDefaultValue;
				}
				return positionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.position_ = value;
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0600968B RID: 38539 RVA: 0x00245E1C File Offset: 0x0024401C
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x00245E39 File Offset: 0x00244039
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x00245E4C File Offset: 0x0024404C
		// (set) Token: 0x0600968E RID: 38542 RVA: 0x00245E64 File Offset: 0x00244064
		[DebuggerNonUserCode]
		public Score Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600968F RID: 38543 RVA: 0x00245E70 File Offset: 0x00244070
		// (set) Token: 0x06009690 RID: 38544 RVA: 0x00245E88 File Offset: 0x00244088
		[DebuggerNonUserCode]
		public AccountInfo Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
			}
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x06009691 RID: 38545 RVA: 0x00245E94 File Offset: 0x00244094
		// (set) Token: 0x06009692 RID: 38546 RVA: 0x00245EB5 File Offset: 0x002440B5
		[DebuggerNonUserCode]
		public string Payloade0Pad
		{
			get
			{
				return this.payloade0Pad_ ?? Rank.Payloade0PadDefaultValue;
			}
			set
			{
				this.payloade0Pad_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x00245ECC File Offset: 0x002440CC
		[DebuggerNonUserCode]
		public bool HasPayloade0Pad
		{
			get
			{
				return this.payloade0Pad_ != null;
			}
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x00245EE7 File Offset: 0x002440E7
		[DebuggerNonUserCode]
		public void ClearPayloade0Pad()
		{
			this.payloade0Pad_ = null;
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x06009695 RID: 38549 RVA: 0x00245EF4 File Offset: 0x002440F4
		// (set) Token: 0x06009696 RID: 38550 RVA: 0x00245F25 File Offset: 0x00244125
		[DebuggerNonUserCode]
		public ulong Version
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = Rank.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.version_ = value;
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x06009697 RID: 38551 RVA: 0x00245F40 File Offset: 0x00244140
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x00245F5D File Offset: 0x0024415D
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06009699 RID: 38553 RVA: 0x00245F70 File Offset: 0x00244170
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Rank);
		}

		// Token: 0x0600969A RID: 38554 RVA: 0x00245F90 File Offset: 0x00244190
		[DebuggerNonUserCode]
		public bool Equals(Rank other)
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
					bool flag4 = !object.Equals(this.User, other.User);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LeaderboardId != other.LeaderboardId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EntityId != other.EntityId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BattleTag != other.BattleTag;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CreationTimeMs != other.CreationTimeMs;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Position != other.Position;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Score, other.Score);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Account, other.Account);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.Payloade0Pad != other.Payloade0Pad;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Version != other.Version;
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x002460FC File Offset: 0x002442FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.user_ != null;
			if (flag)
			{
				num ^= this.User.GetHashCode();
			}
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
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				num ^= this.CreationTimeMs.GetHashCode();
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num ^= this.Position.GetHashCode();
			}
			bool flag2 = this.score_ != null;
			if (flag2)
			{
				num ^= this.Score.GetHashCode();
			}
			bool flag3 = this.account_ != null;
			if (flag3)
			{
				num ^= this.Account.GetHashCode();
			}
			bool hasPayloade0Pad = this.HasPayloade0Pad;
			if (hasPayloade0Pad)
			{
				num ^= this.Payloade0Pad.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x00246248 File Offset: 0x00244448
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x00246260 File Offset: 0x00244460
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x0024626C File Offset: 0x0024446C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.user_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.User);
			}
			bool hasLeaderboardId = this.HasLeaderboardId;
			if (hasLeaderboardId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.LeaderboardId);
			}
			bool hasEntityId = this.HasEntityId;
			if (hasEntityId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.EntityId);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(34);
				output.WriteString(this.BattleTag);
			}
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreationTimeMs);
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.Position);
			}
			bool flag2 = this.score_ != null;
			if (flag2)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Score);
			}
			bool hasPayloade0Pad = this.HasPayloade0Pad;
			if (hasPayloade0Pad)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Payloade0Pad);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.Version);
			}
			bool flag3 = this.account_ != null;
			if (flag3)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.Account);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x00246408 File Offset: 0x00244608
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.user_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.User);
			}
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
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTimeMs);
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Position);
			}
			bool flag2 = this.score_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Score);
			}
			bool flag3 = this.account_ != null;
			if (flag3)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Account);
			}
			bool hasPayloade0Pad = this.HasPayloade0Pad;
			if (hasPayloade0Pad)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Payloade0Pad);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Version);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x00246570 File Offset: 0x00244770
		[DebuggerNonUserCode]
		public void MergeFrom(Rank other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.user_ != null;
				if (flag2)
				{
					bool flag3 = this.user_ == null;
					if (flag3)
					{
						this.User = new Identity();
					}
					this.User.MergeFrom(other.User);
				}
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
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				bool hasCreationTimeMs = other.HasCreationTimeMs;
				if (hasCreationTimeMs)
				{
					this.CreationTimeMs = other.CreationTimeMs;
				}
				bool hasPosition = other.HasPosition;
				if (hasPosition)
				{
					this.Position = other.Position;
				}
				bool flag4 = other.score_ != null;
				if (flag4)
				{
					bool flag5 = this.score_ == null;
					if (flag5)
					{
						this.Score = new Score();
					}
					this.Score.MergeFrom(other.Score);
				}
				bool flag6 = other.account_ != null;
				if (flag6)
				{
					bool flag7 = this.account_ == null;
					if (flag7)
					{
						this.Account = new AccountInfo();
					}
					this.Account.MergeFrom(other.Account);
				}
				bool hasPayloade0Pad = other.HasPayloade0Pad;
				if (hasPayloade0Pad)
				{
					this.Payloade0Pad = other.Payloade0Pad;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x0024671A File Offset: 0x0024491A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x00246728 File Offset: 0x00244928
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_007E;
							}
							this.LeaderboardId = input.ReadString();
						}
						else
						{
							bool flag = this.user_ == null;
							if (flag)
							{
								this.User = new Identity();
							}
							input.ReadMessage(this.User);
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							if (num3 != 40U)
							{
								goto IL_007E;
							}
							this.CreationTimeMs = input.ReadUInt64();
						}
						else
						{
							this.BattleTag = input.ReadString();
						}
					}
					else
					{
						this.EntityId = input.ReadString();
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 48U)
					{
						if (num3 != 58U)
						{
							goto IL_007E;
						}
						bool flag2 = this.score_ == null;
						if (flag2)
						{
							this.Score = new Score();
						}
						input.ReadMessage(this.Score);
					}
					else
					{
						this.Position = input.ReadUInt64();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 72U)
					{
						if (num3 != 146U)
						{
							goto IL_007E;
						}
						bool flag3 = this.account_ == null;
						if (flag3)
						{
							this.Account = new AccountInfo();
						}
						input.ReadMessage(this.Account);
					}
					else
					{
						this.Version = input.ReadUInt64();
					}
				}
				else
				{
					this.Payloade0Pad = input.ReadString();
				}
				continue;
				IL_007E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043C0 RID: 17344
		private static readonly MessageParser<Rank> _parser = new MessageParser<Rank>(() => new Rank());

		// Token: 0x040043C1 RID: 17345
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043C2 RID: 17346
		private int _hasBits0;

		// Token: 0x040043C3 RID: 17347
		public const int UserFieldNumber = 1;

		// Token: 0x040043C4 RID: 17348
		private Identity user_;

		// Token: 0x040043C5 RID: 17349
		public const int LeaderboardIdFieldNumber = 2;

		// Token: 0x040043C6 RID: 17350
		private static readonly string LeaderboardIdDefaultValue = "";

		// Token: 0x040043C7 RID: 17351
		private string leaderboardId_;

		// Token: 0x040043C8 RID: 17352
		public const int EntityIdFieldNumber = 3;

		// Token: 0x040043C9 RID: 17353
		private static readonly string EntityIdDefaultValue = "";

		// Token: 0x040043CA RID: 17354
		private string entityId_;

		// Token: 0x040043CB RID: 17355
		public const int BattleTagFieldNumber = 4;

		// Token: 0x040043CC RID: 17356
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x040043CD RID: 17357
		private string battleTag_;

		// Token: 0x040043CE RID: 17358
		public const int CreationTimeMsFieldNumber = 5;

		// Token: 0x040043CF RID: 17359
		private static readonly ulong CreationTimeMsDefaultValue = 0UL;

		// Token: 0x040043D0 RID: 17360
		private ulong creationTimeMs_;

		// Token: 0x040043D1 RID: 17361
		public const int PositionFieldNumber = 6;

		// Token: 0x040043D2 RID: 17362
		private static readonly ulong PositionDefaultValue = 0UL;

		// Token: 0x040043D3 RID: 17363
		private ulong position_;

		// Token: 0x040043D4 RID: 17364
		public const int ScoreFieldNumber = 7;

		// Token: 0x040043D5 RID: 17365
		private Score score_;

		// Token: 0x040043D6 RID: 17366
		public const int AccountFieldNumber = 18;

		// Token: 0x040043D7 RID: 17367
		private AccountInfo account_;

		// Token: 0x040043D8 RID: 17368
		public const int Payloade0PadFieldNumber = 8;

		// Token: 0x040043D9 RID: 17369
		private static readonly string Payloade0PadDefaultValue = "";

		// Token: 0x040043DA RID: 17370
		private string payloade0Pad_;

		// Token: 0x040043DB RID: 17371
		public const int VersionFieldNumber = 9;

		// Token: 0x040043DC RID: 17372
		private static readonly ulong VersionDefaultValue = 0UL;

		// Token: 0x040043DD RID: 17373
		private ulong version_;
	}
}
