using System;
using System.Diagnostics;
using Fenris.Hero;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x02000128 RID: 296
	public sealed class QuestSavedState : IMessage<QuestSavedState>, IMessage, IEquatable<QuestSavedState>, IDeepCloneable<QuestSavedState>, IBufferMessage
	{
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00070700 File Offset: 0x0006E900
		[DebuggerNonUserCode]
		public static MessageParser<QuestSavedState> Parser
		{
			get
			{
				return QuestSavedState._parser;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00070718 File Offset: 0x0006E918
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x0007073C File Offset: 0x0006E93C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestSavedState.Descriptor;
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00070754 File Offset: 0x0006E954
		[DebuggerNonUserCode]
		public QuestSavedState()
		{
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x000707A0 File Offset: 0x0006E9A0
		[DebuggerNonUserCode]
		public QuestSavedState(QuestSavedState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoQuest_ = other.snoQuest_;
			this.phaseUid_ = other.phaseUid_;
			this.callbackCounts_ = other.callbackCounts_.Clone();
			this.callbackLootinjectionCounts_ = other.callbackLootinjectionCounts_.Clone();
			this.assignedTime_ = other.assignedTime_;
			this.timedQuestStart_ = other.timedQuestStart_;
			this.timedQuestEnd_ = other.timedQuestEnd_;
			this.objectiveRewardChoices_ = ((other.objectiveRewardChoices_ != null) ? other.objectiveRewardChoices_.Clone() : null);
			this.snoFollowerNpcDeprecated_ = other.snoFollowerNpcDeprecated_;
			this.followerNpcSnos_ = other.followerNpcSnos_.Clone();
			this.questGizmoCompletedCallbacks_ = other.questGizmoCompletedCallbacks_.Clone();
			this.followerClone_ = other.followerClone_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0007088C File Offset: 0x0006EA8C
		[DebuggerNonUserCode]
		public QuestSavedState Clone()
		{
			return new QuestSavedState(this);
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x000708A4 File Offset: 0x0006EAA4
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x000708D5 File Offset: 0x0006EAD5
		[DebuggerNonUserCode]
		public int SnoQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoQuestDefaultValue;
				if (flag)
				{
					snoQuestDefaultValue = this.snoQuest_;
				}
				else
				{
					snoQuestDefaultValue = QuestSavedState.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x000708F0 File Offset: 0x0006EAF0
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0007090D File Offset: 0x0006EB0D
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00070920 File Offset: 0x0006EB20
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x00070951 File Offset: 0x0006EB51
		[DebuggerNonUserCode]
		public uint PhaseUid
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint phaseUidDefaultValue;
				if (flag)
				{
					phaseUidDefaultValue = this.phaseUid_;
				}
				else
				{
					phaseUidDefaultValue = QuestSavedState.PhaseUidDefaultValue;
				}
				return phaseUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.phaseUid_ = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0007096C File Offset: 0x0006EB6C
		[DebuggerNonUserCode]
		public bool HasPhaseUid
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00070989 File Offset: 0x0006EB89
		[DebuggerNonUserCode]
		public void ClearPhaseUid()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x0007099C File Offset: 0x0006EB9C
		[DebuggerNonUserCode]
		public RepeatedField<QuestSavedState.Types.CallbackCount> CallbackCounts
		{
			get
			{
				return this.callbackCounts_;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000709B4 File Offset: 0x0006EBB4
		[DebuggerNonUserCode]
		public RepeatedField<QuestSavedState.Types.CallbackLootInjectionCount> CallbackLootinjectionCounts
		{
			get
			{
				return this.callbackLootinjectionCounts_;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x000709CC File Offset: 0x0006EBCC
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x000709FD File Offset: 0x0006EBFD
		[DebuggerNonUserCode]
		public ulong AssignedTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong assignedTimeDefaultValue;
				if (flag)
				{
					assignedTimeDefaultValue = this.assignedTime_;
				}
				else
				{
					assignedTimeDefaultValue = QuestSavedState.AssignedTimeDefaultValue;
				}
				return assignedTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.assignedTime_ = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00070A18 File Offset: 0x0006EC18
		[DebuggerNonUserCode]
		public bool HasAssignedTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00070A35 File Offset: 0x0006EC35
		[DebuggerNonUserCode]
		public void ClearAssignedTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00070A48 File Offset: 0x0006EC48
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x00070A79 File Offset: 0x0006EC79
		[DebuggerNonUserCode]
		public uint TimedQuestStart
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint timedQuestStartDefaultValue;
				if (flag)
				{
					timedQuestStartDefaultValue = this.timedQuestStart_;
				}
				else
				{
					timedQuestStartDefaultValue = QuestSavedState.TimedQuestStartDefaultValue;
				}
				return timedQuestStartDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.timedQuestStart_ = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00070A94 File Offset: 0x0006EC94
		[DebuggerNonUserCode]
		public bool HasTimedQuestStart
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00070AB1 File Offset: 0x0006ECB1
		[DebuggerNonUserCode]
		public void ClearTimedQuestStart()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00070AC4 File Offset: 0x0006ECC4
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x00070AF6 File Offset: 0x0006ECF6
		[DebuggerNonUserCode]
		public uint TimedQuestEnd
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint timedQuestEndDefaultValue;
				if (flag)
				{
					timedQuestEndDefaultValue = this.timedQuestEnd_;
				}
				else
				{
					timedQuestEndDefaultValue = QuestSavedState.TimedQuestEndDefaultValue;
				}
				return timedQuestEndDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.timedQuestEnd_ = value;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00070B10 File Offset: 0x0006ED10
		[DebuggerNonUserCode]
		public bool HasTimedQuestEnd
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00070B2E File Offset: 0x0006ED2E
		[DebuggerNonUserCode]
		public void ClearTimedQuestEnd()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00070B40 File Offset: 0x0006ED40
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x00070B58 File Offset: 0x0006ED58
		[DebuggerNonUserCode]
		public QuestSavedState.Types.ObjectiveSetRewardChoices ObjectiveRewardChoices
		{
			get
			{
				return this.objectiveRewardChoices_;
			}
			set
			{
				this.objectiveRewardChoices_ = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00070B64 File Offset: 0x0006ED64
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x00070B96 File Offset: 0x0006ED96
		[DebuggerNonUserCode]
		public int SnoFollowerNpcDeprecated
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int snoFollowerNpcDeprecatedDefaultValue;
				if (flag)
				{
					snoFollowerNpcDeprecatedDefaultValue = this.snoFollowerNpcDeprecated_;
				}
				else
				{
					snoFollowerNpcDeprecatedDefaultValue = QuestSavedState.SnoFollowerNpcDeprecatedDefaultValue;
				}
				return snoFollowerNpcDeprecatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.snoFollowerNpcDeprecated_ = value;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00070BB0 File Offset: 0x0006EDB0
		[DebuggerNonUserCode]
		public bool HasSnoFollowerNpcDeprecated
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00070BCE File Offset: 0x0006EDCE
		[DebuggerNonUserCode]
		public void ClearSnoFollowerNpcDeprecated()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00070BE0 File Offset: 0x0006EDE0
		[DebuggerNonUserCode]
		public RepeatedField<int> FollowerNpcSnos
		{
			get
			{
				return this.followerNpcSnos_;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00070BF8 File Offset: 0x0006EDF8
		[DebuggerNonUserCode]
		public RepeatedField<QuestSavedState.Types.QuestGizmoCompletedCallbacks> QuestGizmoCompletedCallbacks
		{
			get
			{
				return this.questGizmoCompletedCallbacks_;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00070C10 File Offset: 0x0006EE10
		[DebuggerNonUserCode]
		public RepeatedField<QuestSavedState.Types.FollowerClone> FollowerClone
		{
			get
			{
				return this.followerClone_;
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00070C28 File Offset: 0x0006EE28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestSavedState);
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00070C48 File Offset: 0x0006EE48
		[DebuggerNonUserCode]
		public bool Equals(QuestSavedState other)
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
					bool flag4 = this.SnoQuest != other.SnoQuest;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PhaseUid != other.PhaseUid;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.callbackCounts_.Equals(other.callbackCounts_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.callbackLootinjectionCounts_.Equals(other.callbackLootinjectionCounts_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AssignedTime != other.AssignedTime;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.TimedQuestStart != other.TimedQuestStart;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.TimedQuestEnd != other.TimedQuestEnd;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.ObjectiveRewardChoices, other.ObjectiveRewardChoices);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SnoFollowerNpcDeprecated != other.SnoFollowerNpcDeprecated;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.followerNpcSnos_.Equals(other.followerNpcSnos_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !this.questGizmoCompletedCallbacks_.Equals(other.questGizmoCompletedCallbacks_);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !this.followerClone_.Equals(other.followerClone_);
																flag2 = !flag15 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00070DF8 File Offset: 0x0006EFF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				num ^= this.PhaseUid.GetHashCode();
			}
			num ^= this.callbackCounts_.GetHashCode();
			num ^= this.callbackLootinjectionCounts_.GetHashCode();
			bool hasAssignedTime = this.HasAssignedTime;
			if (hasAssignedTime)
			{
				num ^= this.AssignedTime.GetHashCode();
			}
			bool hasTimedQuestStart = this.HasTimedQuestStart;
			if (hasTimedQuestStart)
			{
				num ^= this.TimedQuestStart.GetHashCode();
			}
			bool hasTimedQuestEnd = this.HasTimedQuestEnd;
			if (hasTimedQuestEnd)
			{
				num ^= this.TimedQuestEnd.GetHashCode();
			}
			bool flag = this.objectiveRewardChoices_ != null;
			if (flag)
			{
				num ^= this.ObjectiveRewardChoices.GetHashCode();
			}
			bool hasSnoFollowerNpcDeprecated = this.HasSnoFollowerNpcDeprecated;
			if (hasSnoFollowerNpcDeprecated)
			{
				num ^= this.SnoFollowerNpcDeprecated.GetHashCode();
			}
			num ^= this.followerNpcSnos_.GetHashCode();
			num ^= this.questGizmoCompletedCallbacks_.GetHashCode();
			num ^= this.followerClone_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00070F40 File Offset: 0x0006F140
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00070F58 File Offset: 0x0006F158
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00070F64 File Offset: 0x0006F164
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoQuest);
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PhaseUid);
			}
			this.callbackCounts_.WriteTo(ref output, QuestSavedState._repeated_callbackCounts_codec);
			this.callbackLootinjectionCounts_.WriteTo(ref output, QuestSavedState._repeated_callbackLootinjectionCounts_codec);
			bool hasAssignedTime = this.HasAssignedTime;
			if (hasAssignedTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.AssignedTime);
			}
			bool hasTimedQuestStart = this.HasTimedQuestStart;
			if (hasTimedQuestStart)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TimedQuestStart);
			}
			bool hasTimedQuestEnd = this.HasTimedQuestEnd;
			if (hasTimedQuestEnd)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TimedQuestEnd);
			}
			bool flag = this.objectiveRewardChoices_ != null;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ObjectiveRewardChoices);
			}
			bool hasSnoFollowerNpcDeprecated = this.HasSnoFollowerNpcDeprecated;
			if (hasSnoFollowerNpcDeprecated)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SnoFollowerNpcDeprecated);
			}
			this.followerNpcSnos_.WriteTo(ref output, QuestSavedState._repeated_followerNpcSnos_codec);
			this.questGizmoCompletedCallbacks_.WriteTo(ref output, QuestSavedState._repeated_questGizmoCompletedCallbacks_codec);
			this.followerClone_.WriteTo(ref output, QuestSavedState._repeated_followerClone_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000710E0 File Offset: 0x0006F2E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoQuest);
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PhaseUid);
			}
			num += this.callbackCounts_.CalculateSize(QuestSavedState._repeated_callbackCounts_codec);
			num += this.callbackLootinjectionCounts_.CalculateSize(QuestSavedState._repeated_callbackLootinjectionCounts_codec);
			bool hasAssignedTime = this.HasAssignedTime;
			if (hasAssignedTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AssignedTime);
			}
			bool hasTimedQuestStart = this.HasTimedQuestStart;
			if (hasTimedQuestStart)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimedQuestStart);
			}
			bool hasTimedQuestEnd = this.HasTimedQuestEnd;
			if (hasTimedQuestEnd)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimedQuestEnd);
			}
			bool flag = this.objectiveRewardChoices_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ObjectiveRewardChoices);
			}
			bool hasSnoFollowerNpcDeprecated = this.HasSnoFollowerNpcDeprecated;
			if (hasSnoFollowerNpcDeprecated)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoFollowerNpcDeprecated);
			}
			num += this.followerNpcSnos_.CalculateSize(QuestSavedState._repeated_followerNpcSnos_codec);
			num += this.questGizmoCompletedCallbacks_.CalculateSize(QuestSavedState._repeated_questGizmoCompletedCallbacks_codec);
			num += this.followerClone_.CalculateSize(QuestSavedState._repeated_followerClone_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00071244 File Offset: 0x0006F444
		[DebuggerNonUserCode]
		public void MergeFrom(QuestSavedState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				bool hasPhaseUid = other.HasPhaseUid;
				if (hasPhaseUid)
				{
					this.PhaseUid = other.PhaseUid;
				}
				this.callbackCounts_.Add(other.callbackCounts_);
				this.callbackLootinjectionCounts_.Add(other.callbackLootinjectionCounts_);
				bool hasAssignedTime = other.HasAssignedTime;
				if (hasAssignedTime)
				{
					this.AssignedTime = other.AssignedTime;
				}
				bool hasTimedQuestStart = other.HasTimedQuestStart;
				if (hasTimedQuestStart)
				{
					this.TimedQuestStart = other.TimedQuestStart;
				}
				bool hasTimedQuestEnd = other.HasTimedQuestEnd;
				if (hasTimedQuestEnd)
				{
					this.TimedQuestEnd = other.TimedQuestEnd;
				}
				bool flag2 = other.objectiveRewardChoices_ != null;
				if (flag2)
				{
					bool flag3 = this.objectiveRewardChoices_ == null;
					if (flag3)
					{
						this.ObjectiveRewardChoices = new QuestSavedState.Types.ObjectiveSetRewardChoices();
					}
					this.ObjectiveRewardChoices.MergeFrom(other.ObjectiveRewardChoices);
				}
				bool hasSnoFollowerNpcDeprecated = other.HasSnoFollowerNpcDeprecated;
				if (hasSnoFollowerNpcDeprecated)
				{
					this.SnoFollowerNpcDeprecated = other.SnoFollowerNpcDeprecated;
				}
				this.followerNpcSnos_.Add(other.followerNpcSnos_);
				this.questGizmoCompletedCallbacks_.Add(other.questGizmoCompletedCallbacks_);
				this.followerClone_.Add(other.followerClone_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000713AD File Offset: 0x0006F5AD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000713B8 File Offset: 0x0006F5B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									goto IL_00A0;
								}
								this.callbackCounts_.AddEntriesFrom(ref input, QuestSavedState._repeated_callbackCounts_codec);
							}
							else
							{
								this.PhaseUid = input.ReadUInt32();
							}
						}
						else
						{
							this.SnoQuest = input.ReadInt32();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_00A0;
							}
							this.TimedQuestStart = input.ReadUInt32();
						}
						else
						{
							this.AssignedTime = input.ReadUInt64();
						}
					}
					else
					{
						this.callbackLootinjectionCounts_.AddEntriesFrom(ref input, QuestSavedState._repeated_callbackLootinjectionCounts_codec);
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 56U)
					{
						if (num3 != 66U)
						{
							if (num3 != 72U)
							{
								goto IL_00A0;
							}
							this.SnoFollowerNpcDeprecated = input.ReadInt32();
						}
						else
						{
							bool flag = this.objectiveRewardChoices_ == null;
							if (flag)
							{
								this.ObjectiveRewardChoices = new QuestSavedState.Types.ObjectiveSetRewardChoices();
							}
							input.ReadMessage(this.ObjectiveRewardChoices);
						}
					}
					else
					{
						this.TimedQuestEnd = input.ReadUInt32();
					}
				}
				else if (num3 <= 82U)
				{
					if (num3 != 80U && num3 != 82U)
					{
						goto IL_00A0;
					}
					this.followerNpcSnos_.AddEntriesFrom(ref input, QuestSavedState._repeated_followerNpcSnos_codec);
				}
				else if (num3 != 90U)
				{
					if (num3 != 98U)
					{
						goto IL_00A0;
					}
					this.followerClone_.AddEntriesFrom(ref input, QuestSavedState._repeated_followerClone_codec);
				}
				else
				{
					this.questGizmoCompletedCallbacks_.AddEntriesFrom(ref input, QuestSavedState._repeated_questGizmoCompletedCallbacks_codec);
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000C7A RID: 3194
		private static readonly MessageParser<QuestSavedState> _parser = new MessageParser<QuestSavedState>(() => new QuestSavedState());

		// Token: 0x04000C7B RID: 3195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C7C RID: 3196
		private int _hasBits0;

		// Token: 0x04000C7D RID: 3197
		public const int SnoQuestFieldNumber = 1;

		// Token: 0x04000C7E RID: 3198
		private static readonly int SnoQuestDefaultValue = 0;

		// Token: 0x04000C7F RID: 3199
		private int snoQuest_;

		// Token: 0x04000C80 RID: 3200
		public const int PhaseUidFieldNumber = 2;

		// Token: 0x04000C81 RID: 3201
		private static readonly uint PhaseUidDefaultValue = 0U;

		// Token: 0x04000C82 RID: 3202
		private uint phaseUid_;

		// Token: 0x04000C83 RID: 3203
		public const int CallbackCountsFieldNumber = 3;

		// Token: 0x04000C84 RID: 3204
		private static readonly FieldCodec<QuestSavedState.Types.CallbackCount> _repeated_callbackCounts_codec = FieldCodec.ForMessage<QuestSavedState.Types.CallbackCount>(26U, QuestSavedState.Types.CallbackCount.Parser);

		// Token: 0x04000C85 RID: 3205
		private readonly RepeatedField<QuestSavedState.Types.CallbackCount> callbackCounts_ = new RepeatedField<QuestSavedState.Types.CallbackCount>();

		// Token: 0x04000C86 RID: 3206
		public const int CallbackLootinjectionCountsFieldNumber = 4;

		// Token: 0x04000C87 RID: 3207
		private static readonly FieldCodec<QuestSavedState.Types.CallbackLootInjectionCount> _repeated_callbackLootinjectionCounts_codec = FieldCodec.ForMessage<QuestSavedState.Types.CallbackLootInjectionCount>(34U, QuestSavedState.Types.CallbackLootInjectionCount.Parser);

		// Token: 0x04000C88 RID: 3208
		private readonly RepeatedField<QuestSavedState.Types.CallbackLootInjectionCount> callbackLootinjectionCounts_ = new RepeatedField<QuestSavedState.Types.CallbackLootInjectionCount>();

		// Token: 0x04000C89 RID: 3209
		public const int AssignedTimeFieldNumber = 5;

		// Token: 0x04000C8A RID: 3210
		private static readonly ulong AssignedTimeDefaultValue = 0UL;

		// Token: 0x04000C8B RID: 3211
		private ulong assignedTime_;

		// Token: 0x04000C8C RID: 3212
		public const int TimedQuestStartFieldNumber = 6;

		// Token: 0x04000C8D RID: 3213
		private static readonly uint TimedQuestStartDefaultValue = 0U;

		// Token: 0x04000C8E RID: 3214
		private uint timedQuestStart_;

		// Token: 0x04000C8F RID: 3215
		public const int TimedQuestEndFieldNumber = 7;

		// Token: 0x04000C90 RID: 3216
		private static readonly uint TimedQuestEndDefaultValue = 0U;

		// Token: 0x04000C91 RID: 3217
		private uint timedQuestEnd_;

		// Token: 0x04000C92 RID: 3218
		public const int ObjectiveRewardChoicesFieldNumber = 8;

		// Token: 0x04000C93 RID: 3219
		private QuestSavedState.Types.ObjectiveSetRewardChoices objectiveRewardChoices_;

		// Token: 0x04000C94 RID: 3220
		public const int SnoFollowerNpcDeprecatedFieldNumber = 9;

		// Token: 0x04000C95 RID: 3221
		private static readonly int SnoFollowerNpcDeprecatedDefaultValue = -1;

		// Token: 0x04000C96 RID: 3222
		private int snoFollowerNpcDeprecated_;

		// Token: 0x04000C97 RID: 3223
		public const int FollowerNpcSnosFieldNumber = 10;

		// Token: 0x04000C98 RID: 3224
		private static readonly FieldCodec<int> _repeated_followerNpcSnos_codec = FieldCodec.ForInt32(80U);

		// Token: 0x04000C99 RID: 3225
		private readonly RepeatedField<int> followerNpcSnos_ = new RepeatedField<int>();

		// Token: 0x04000C9A RID: 3226
		public const int QuestGizmoCompletedCallbacksFieldNumber = 11;

		// Token: 0x04000C9B RID: 3227
		private static readonly FieldCodec<QuestSavedState.Types.QuestGizmoCompletedCallbacks> _repeated_questGizmoCompletedCallbacks_codec = FieldCodec.ForMessage<QuestSavedState.Types.QuestGizmoCompletedCallbacks>(90U, QuestSavedState.Types.QuestGizmoCompletedCallbacks.Parser);

		// Token: 0x04000C9C RID: 3228
		private readonly RepeatedField<QuestSavedState.Types.QuestGizmoCompletedCallbacks> questGizmoCompletedCallbacks_ = new RepeatedField<QuestSavedState.Types.QuestGizmoCompletedCallbacks>();

		// Token: 0x04000C9D RID: 3229
		public const int FollowerCloneFieldNumber = 12;

		// Token: 0x04000C9E RID: 3230
		private static readonly FieldCodec<QuestSavedState.Types.FollowerClone> _repeated_followerClone_codec = FieldCodec.ForMessage<QuestSavedState.Types.FollowerClone>(98U, QuestSavedState.Types.FollowerClone.Parser);

		// Token: 0x04000C9F RID: 3231
		private readonly RepeatedField<QuestSavedState.Types.FollowerClone> followerClone_ = new RepeatedField<QuestSavedState.Types.FollowerClone>();

		// Token: 0x02000C44 RID: 3140
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001476 RID: 5238
			public sealed class CallbackCount : IMessage<QuestSavedState.Types.CallbackCount>, IMessage, IEquatable<QuestSavedState.Types.CallbackCount>, IDeepCloneable<QuestSavedState.Types.CallbackCount>, IBufferMessage
			{
				// Token: 0x17003A78 RID: 14968
				// (get) Token: 0x0600E5B9 RID: 58809 RVA: 0x004D5994 File Offset: 0x004D3B94
				[DebuggerNonUserCode]
				public static MessageParser<QuestSavedState.Types.CallbackCount> Parser
				{
					get
					{
						return QuestSavedState.Types.CallbackCount._parser;
					}
				}

				// Token: 0x17003A79 RID: 14969
				// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x004D59AC File Offset: 0x004D3BAC
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestSavedState.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003A7A RID: 14970
				// (get) Token: 0x0600E5BB RID: 58811 RVA: 0x004D59D0 File Offset: 0x004D3BD0
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestSavedState.Types.CallbackCount.Descriptor;
					}
				}

				// Token: 0x0600E5BC RID: 58812 RVA: 0x004D59E7 File Offset: 0x004D3BE7
				[DebuggerNonUserCode]
				public CallbackCount()
				{
				}

				// Token: 0x0600E5BD RID: 58813 RVA: 0x004D59F4 File Offset: 0x004D3BF4
				[DebuggerNonUserCode]
				public CallbackCount(QuestSavedState.Types.CallbackCount other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.uid_ = other.uid_;
					this.current_ = other.current_;
					this.completed_ = other.completed_;
					this.failure_ = other.failure_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E5BE RID: 58814 RVA: 0x004D5A58 File Offset: 0x004D3C58
				[DebuggerNonUserCode]
				public QuestSavedState.Types.CallbackCount Clone()
				{
					return new QuestSavedState.Types.CallbackCount(this);
				}

				// Token: 0x17003A7B RID: 14971
				// (get) Token: 0x0600E5BF RID: 58815 RVA: 0x004D5A70 File Offset: 0x004D3C70
				// (set) Token: 0x0600E5C0 RID: 58816 RVA: 0x004D5AA1 File Offset: 0x004D3CA1
				[DebuggerNonUserCode]
				public uint Uid
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint uidDefaultValue;
						if (flag)
						{
							uidDefaultValue = this.uid_;
						}
						else
						{
							uidDefaultValue = QuestSavedState.Types.CallbackCount.UidDefaultValue;
						}
						return uidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.uid_ = value;
					}
				}

				// Token: 0x17003A7C RID: 14972
				// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x004D5ABC File Offset: 0x004D3CBC
				[DebuggerNonUserCode]
				public bool HasUid
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E5C2 RID: 58818 RVA: 0x004D5AD9 File Offset: 0x004D3CD9
				[DebuggerNonUserCode]
				public void ClearUid()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A7D RID: 14973
				// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x004D5AEC File Offset: 0x004D3CEC
				// (set) Token: 0x0600E5C4 RID: 58820 RVA: 0x004D5B1D File Offset: 0x004D3D1D
				[DebuggerNonUserCode]
				public int Current
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int currentDefaultValue;
						if (flag)
						{
							currentDefaultValue = this.current_;
						}
						else
						{
							currentDefaultValue = QuestSavedState.Types.CallbackCount.CurrentDefaultValue;
						}
						return currentDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.current_ = value;
					}
				}

				// Token: 0x17003A7E RID: 14974
				// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x004D5B38 File Offset: 0x004D3D38
				[DebuggerNonUserCode]
				public bool HasCurrent
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E5C6 RID: 58822 RVA: 0x004D5B55 File Offset: 0x004D3D55
				[DebuggerNonUserCode]
				public void ClearCurrent()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A7F RID: 14975
				// (get) Token: 0x0600E5C7 RID: 58823 RVA: 0x004D5B68 File Offset: 0x004D3D68
				// (set) Token: 0x0600E5C8 RID: 58824 RVA: 0x004D5B99 File Offset: 0x004D3D99
				[DebuggerNonUserCode]
				public bool Completed
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						bool completedDefaultValue;
						if (flag)
						{
							completedDefaultValue = this.completed_;
						}
						else
						{
							completedDefaultValue = QuestSavedState.Types.CallbackCount.CompletedDefaultValue;
						}
						return completedDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.completed_ = value;
					}
				}

				// Token: 0x17003A80 RID: 14976
				// (get) Token: 0x0600E5C9 RID: 58825 RVA: 0x004D5BB4 File Offset: 0x004D3DB4
				[DebuggerNonUserCode]
				public bool HasCompleted
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E5CA RID: 58826 RVA: 0x004D5BD1 File Offset: 0x004D3DD1
				[DebuggerNonUserCode]
				public void ClearCompleted()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003A81 RID: 14977
				// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x004D5BE4 File Offset: 0x004D3DE4
				// (set) Token: 0x0600E5CC RID: 58828 RVA: 0x004D5C15 File Offset: 0x004D3E15
				[DebuggerNonUserCode]
				public bool Failure
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						bool failureDefaultValue;
						if (flag)
						{
							failureDefaultValue = this.failure_;
						}
						else
						{
							failureDefaultValue = QuestSavedState.Types.CallbackCount.FailureDefaultValue;
						}
						return failureDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.failure_ = value;
					}
				}

				// Token: 0x17003A82 RID: 14978
				// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x004D5C30 File Offset: 0x004D3E30
				[DebuggerNonUserCode]
				public bool HasFailure
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E5CE RID: 58830 RVA: 0x004D5C4D File Offset: 0x004D3E4D
				[DebuggerNonUserCode]
				public void ClearFailure()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x0600E5CF RID: 58831 RVA: 0x004D5C60 File Offset: 0x004D3E60
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestSavedState.Types.CallbackCount);
				}

				// Token: 0x0600E5D0 RID: 58832 RVA: 0x004D5C80 File Offset: 0x004D3E80
				[DebuggerNonUserCode]
				public bool Equals(QuestSavedState.Types.CallbackCount other)
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
							bool flag4 = this.Uid != other.Uid;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.Current != other.Current;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.Completed != other.Completed;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.Failure != other.Failure;
										flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E5D1 RID: 58833 RVA: 0x004D5D2C File Offset: 0x004D3F2C
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						num ^= this.Uid.GetHashCode();
					}
					bool hasCurrent = this.HasCurrent;
					if (hasCurrent)
					{
						int num2 = num;
						int num3 = this.Current;
						num = num2 ^ num3.GetHashCode();
					}
					bool hasCompleted = this.HasCompleted;
					if (hasCompleted)
					{
						num ^= this.Completed.GetHashCode();
					}
					bool hasFailure = this.HasFailure;
					if (hasFailure)
					{
						num ^= this.Failure.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E5D2 RID: 58834 RVA: 0x004D5DD8 File Offset: 0x004D3FD8
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E5D3 RID: 58835 RVA: 0x004D5DF0 File Offset: 0x004D3FF0
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E5D4 RID: 58836 RVA: 0x004D5DFC File Offset: 0x004D3FFC
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.Uid);
					}
					bool hasCurrent = this.HasCurrent;
					if (hasCurrent)
					{
						output.WriteRawTag(16);
						output.WriteInt32(this.Current);
					}
					bool hasCompleted = this.HasCompleted;
					if (hasCompleted)
					{
						output.WriteRawTag(24);
						output.WriteBool(this.Completed);
					}
					bool hasFailure = this.HasFailure;
					if (hasFailure)
					{
						output.WriteRawTag(32);
						output.WriteBool(this.Failure);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E5D5 RID: 58837 RVA: 0x004D5EB0 File Offset: 0x004D40B0
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
					}
					bool hasCurrent = this.HasCurrent;
					if (hasCurrent)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
					}
					bool hasCompleted = this.HasCompleted;
					if (hasCompleted)
					{
						num += 2;
					}
					bool hasFailure = this.HasFailure;
					if (hasFailure)
					{
						num += 2;
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E5D6 RID: 58838 RVA: 0x004D5F40 File Offset: 0x004D4140
				[DebuggerNonUserCode]
				public void MergeFrom(QuestSavedState.Types.CallbackCount other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasUid = other.HasUid;
						if (hasUid)
						{
							this.Uid = other.Uid;
						}
						bool hasCurrent = other.HasCurrent;
						if (hasCurrent)
						{
							this.Current = other.Current;
						}
						bool hasCompleted = other.HasCompleted;
						if (hasCompleted)
						{
							this.Completed = other.Completed;
						}
						bool hasFailure = other.HasFailure;
						if (hasFailure)
						{
							this.Failure = other.Failure;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E5D7 RID: 58839 RVA: 0x004D5FD6 File Offset: 0x004D41D6
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E5D8 RID: 58840 RVA: 0x004D5FE4 File Offset: 0x004D41E4
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 16U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									goto IL_0028;
								}
								this.Current = input.ReadInt32();
							}
							else
							{
								this.Uid = input.ReadUInt32();
							}
						}
						else if (num3 != 24U)
						{
							if (num3 != 32U)
							{
								goto IL_0028;
							}
							this.Failure = input.ReadBool();
						}
						else
						{
							this.Completed = input.ReadBool();
						}
						continue;
						IL_0028:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A396 RID: 41878
				private static readonly MessageParser<QuestSavedState.Types.CallbackCount> _parser = new MessageParser<QuestSavedState.Types.CallbackCount>(() => new QuestSavedState.Types.CallbackCount());

				// Token: 0x0400A397 RID: 41879
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A398 RID: 41880
				private int _hasBits0;

				// Token: 0x0400A399 RID: 41881
				public const int UidFieldNumber = 1;

				// Token: 0x0400A39A RID: 41882
				private static readonly uint UidDefaultValue = 0U;

				// Token: 0x0400A39B RID: 41883
				private uint uid_;

				// Token: 0x0400A39C RID: 41884
				public const int CurrentFieldNumber = 2;

				// Token: 0x0400A39D RID: 41885
				private static readonly int CurrentDefaultValue = 0;

				// Token: 0x0400A39E RID: 41886
				private int current_;

				// Token: 0x0400A39F RID: 41887
				public const int CompletedFieldNumber = 3;

				// Token: 0x0400A3A0 RID: 41888
				private static readonly bool CompletedDefaultValue = false;

				// Token: 0x0400A3A1 RID: 41889
				private bool completed_;

				// Token: 0x0400A3A2 RID: 41890
				public const int FailureFieldNumber = 4;

				// Token: 0x0400A3A3 RID: 41891
				private static readonly bool FailureDefaultValue = false;

				// Token: 0x0400A3A4 RID: 41892
				private bool failure_;
			}

			// Token: 0x02001477 RID: 5239
			public sealed class CallbackLootInjectionCount : IMessage<QuestSavedState.Types.CallbackLootInjectionCount>, IMessage, IEquatable<QuestSavedState.Types.CallbackLootInjectionCount>, IDeepCloneable<QuestSavedState.Types.CallbackLootInjectionCount>, IBufferMessage
			{
				// Token: 0x17003A83 RID: 14979
				// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x004D60B4 File Offset: 0x004D42B4
				[DebuggerNonUserCode]
				public static MessageParser<QuestSavedState.Types.CallbackLootInjectionCount> Parser
				{
					get
					{
						return QuestSavedState.Types.CallbackLootInjectionCount._parser;
					}
				}

				// Token: 0x17003A84 RID: 14980
				// (get) Token: 0x0600E5DB RID: 58843 RVA: 0x004D60CC File Offset: 0x004D42CC
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestSavedState.Descriptor.NestedTypes[1];
					}
				}

				// Token: 0x17003A85 RID: 14981
				// (get) Token: 0x0600E5DC RID: 58844 RVA: 0x004D60F0 File Offset: 0x004D42F0
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestSavedState.Types.CallbackLootInjectionCount.Descriptor;
					}
				}

				// Token: 0x0600E5DD RID: 58845 RVA: 0x004D6107 File Offset: 0x004D4307
				[DebuggerNonUserCode]
				public CallbackLootInjectionCount()
				{
				}

				// Token: 0x0600E5DE RID: 58846 RVA: 0x004D6111 File Offset: 0x004D4311
				[DebuggerNonUserCode]
				public CallbackLootInjectionCount(QuestSavedState.Types.CallbackLootInjectionCount other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.uid_ = other.uid_;
					this.count_ = other.count_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E5DF RID: 58847 RVA: 0x004D6150 File Offset: 0x004D4350
				[DebuggerNonUserCode]
				public QuestSavedState.Types.CallbackLootInjectionCount Clone()
				{
					return new QuestSavedState.Types.CallbackLootInjectionCount(this);
				}

				// Token: 0x17003A86 RID: 14982
				// (get) Token: 0x0600E5E0 RID: 58848 RVA: 0x004D6168 File Offset: 0x004D4368
				// (set) Token: 0x0600E5E1 RID: 58849 RVA: 0x004D6199 File Offset: 0x004D4399
				[DebuggerNonUserCode]
				public uint Uid
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint uidDefaultValue;
						if (flag)
						{
							uidDefaultValue = this.uid_;
						}
						else
						{
							uidDefaultValue = QuestSavedState.Types.CallbackLootInjectionCount.UidDefaultValue;
						}
						return uidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.uid_ = value;
					}
				}

				// Token: 0x17003A87 RID: 14983
				// (get) Token: 0x0600E5E2 RID: 58850 RVA: 0x004D61B4 File Offset: 0x004D43B4
				[DebuggerNonUserCode]
				public bool HasUid
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E5E3 RID: 58851 RVA: 0x004D61D1 File Offset: 0x004D43D1
				[DebuggerNonUserCode]
				public void ClearUid()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A88 RID: 14984
				// (get) Token: 0x0600E5E4 RID: 58852 RVA: 0x004D61E4 File Offset: 0x004D43E4
				// (set) Token: 0x0600E5E5 RID: 58853 RVA: 0x004D6215 File Offset: 0x004D4415
				[DebuggerNonUserCode]
				public uint Count
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						uint countDefaultValue;
						if (flag)
						{
							countDefaultValue = this.count_;
						}
						else
						{
							countDefaultValue = QuestSavedState.Types.CallbackLootInjectionCount.CountDefaultValue;
						}
						return countDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.count_ = value;
					}
				}

				// Token: 0x17003A89 RID: 14985
				// (get) Token: 0x0600E5E6 RID: 58854 RVA: 0x004D6230 File Offset: 0x004D4430
				[DebuggerNonUserCode]
				public bool HasCount
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E5E7 RID: 58855 RVA: 0x004D624D File Offset: 0x004D444D
				[DebuggerNonUserCode]
				public void ClearCount()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x0600E5E8 RID: 58856 RVA: 0x004D6260 File Offset: 0x004D4460
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestSavedState.Types.CallbackLootInjectionCount);
				}

				// Token: 0x0600E5E9 RID: 58857 RVA: 0x004D6280 File Offset: 0x004D4480
				[DebuggerNonUserCode]
				public bool Equals(QuestSavedState.Types.CallbackLootInjectionCount other)
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
							bool flag4 = this.Uid != other.Uid;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.Count != other.Count;
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E5EA RID: 58858 RVA: 0x004D62F4 File Offset: 0x004D44F4
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						num ^= this.Uid.GetHashCode();
					}
					bool hasCount = this.HasCount;
					if (hasCount)
					{
						num ^= this.Count.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E5EB RID: 58859 RVA: 0x004D6360 File Offset: 0x004D4560
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E5EC RID: 58860 RVA: 0x004D6378 File Offset: 0x004D4578
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E5ED RID: 58861 RVA: 0x004D6384 File Offset: 0x004D4584
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.Uid);
					}
					bool hasCount = this.HasCount;
					if (hasCount)
					{
						output.WriteRawTag(16);
						output.WriteUInt32(this.Count);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E5EE RID: 58862 RVA: 0x004D63F4 File Offset: 0x004D45F4
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
					}
					bool hasCount = this.HasCount;
					if (hasCount)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E5EF RID: 58863 RVA: 0x004D6460 File Offset: 0x004D4660
				[DebuggerNonUserCode]
				public void MergeFrom(QuestSavedState.Types.CallbackLootInjectionCount other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasUid = other.HasUid;
						if (hasUid)
						{
							this.Uid = other.Uid;
						}
						bool hasCount = other.HasCount;
						if (hasCount)
						{
							this.Count = other.Count;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E5F0 RID: 58864 RVA: 0x004D64C2 File Offset: 0x004D46C2
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E5F1 RID: 58865 RVA: 0x004D64D0 File Offset: 0x004D46D0
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
								this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
							}
							else
							{
								this.Count = input.ReadUInt32();
							}
						}
						else
						{
							this.Uid = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A3A5 RID: 41893
				private static readonly MessageParser<QuestSavedState.Types.CallbackLootInjectionCount> _parser = new MessageParser<QuestSavedState.Types.CallbackLootInjectionCount>(() => new QuestSavedState.Types.CallbackLootInjectionCount());

				// Token: 0x0400A3A6 RID: 41894
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A3A7 RID: 41895
				private int _hasBits0;

				// Token: 0x0400A3A8 RID: 41896
				public const int UidFieldNumber = 1;

				// Token: 0x0400A3A9 RID: 41897
				private static readonly uint UidDefaultValue = 0U;

				// Token: 0x0400A3AA RID: 41898
				private uint uid_;

				// Token: 0x0400A3AB RID: 41899
				public const int CountFieldNumber = 2;

				// Token: 0x0400A3AC RID: 41900
				private static readonly uint CountDefaultValue = 0U;

				// Token: 0x0400A3AD RID: 41901
				private uint count_;
			}

			// Token: 0x02001478 RID: 5240
			public sealed class QuestGizmoCompletedCallbacks : IMessage<QuestSavedState.Types.QuestGizmoCompletedCallbacks>, IMessage, IEquatable<QuestSavedState.Types.QuestGizmoCompletedCallbacks>, IDeepCloneable<QuestSavedState.Types.QuestGizmoCompletedCallbacks>, IBufferMessage
			{
				// Token: 0x17003A8A RID: 14986
				// (get) Token: 0x0600E5F3 RID: 58867 RVA: 0x004D6560 File Offset: 0x004D4760
				[DebuggerNonUserCode]
				public static MessageParser<QuestSavedState.Types.QuestGizmoCompletedCallbacks> Parser
				{
					get
					{
						return QuestSavedState.Types.QuestGizmoCompletedCallbacks._parser;
					}
				}

				// Token: 0x17003A8B RID: 14987
				// (get) Token: 0x0600E5F4 RID: 58868 RVA: 0x004D6578 File Offset: 0x004D4778
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestSavedState.Descriptor.NestedTypes[2];
					}
				}

				// Token: 0x17003A8C RID: 14988
				// (get) Token: 0x0600E5F5 RID: 58869 RVA: 0x004D659C File Offset: 0x004D479C
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestSavedState.Types.QuestGizmoCompletedCallbacks.Descriptor;
					}
				}

				// Token: 0x0600E5F6 RID: 58870 RVA: 0x004D65B3 File Offset: 0x004D47B3
				[DebuggerNonUserCode]
				public QuestGizmoCompletedCallbacks()
				{
				}

				// Token: 0x0600E5F7 RID: 58871 RVA: 0x004D65BD File Offset: 0x004D47BD
				[DebuggerNonUserCode]
				public QuestGizmoCompletedCallbacks(QuestSavedState.Types.QuestGizmoCompletedCallbacks other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.value_ = other.value_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E5F8 RID: 58872 RVA: 0x004D65F0 File Offset: 0x004D47F0
				[DebuggerNonUserCode]
				public QuestSavedState.Types.QuestGizmoCompletedCallbacks Clone()
				{
					return new QuestSavedState.Types.QuestGizmoCompletedCallbacks(this);
				}

				// Token: 0x17003A8D RID: 14989
				// (get) Token: 0x0600E5F9 RID: 58873 RVA: 0x004D6608 File Offset: 0x004D4808
				// (set) Token: 0x0600E5FA RID: 58874 RVA: 0x004D6639 File Offset: 0x004D4839
				[DebuggerNonUserCode]
				public uint Value
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint valueDefaultValue;
						if (flag)
						{
							valueDefaultValue = this.value_;
						}
						else
						{
							valueDefaultValue = QuestSavedState.Types.QuestGizmoCompletedCallbacks.ValueDefaultValue;
						}
						return valueDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.value_ = value;
					}
				}

				// Token: 0x17003A8E RID: 14990
				// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x004D6654 File Offset: 0x004D4854
				[DebuggerNonUserCode]
				public bool HasValue
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E5FC RID: 58876 RVA: 0x004D6671 File Offset: 0x004D4871
				[DebuggerNonUserCode]
				public void ClearValue()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x0600E5FD RID: 58877 RVA: 0x004D6684 File Offset: 0x004D4884
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestSavedState.Types.QuestGizmoCompletedCallbacks);
				}

				// Token: 0x0600E5FE RID: 58878 RVA: 0x004D66A4 File Offset: 0x004D48A4
				[DebuggerNonUserCode]
				public bool Equals(QuestSavedState.Types.QuestGizmoCompletedCallbacks other)
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
							bool flag4 = this.Value != other.Value;
							flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
					return flag2;
				}

				// Token: 0x0600E5FF RID: 58879 RVA: 0x004D66FC File Offset: 0x004D48FC
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasValue = this.HasValue;
					if (hasValue)
					{
						num ^= this.Value.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E600 RID: 58880 RVA: 0x004D674C File Offset: 0x004D494C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E601 RID: 58881 RVA: 0x004D6764 File Offset: 0x004D4964
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E602 RID: 58882 RVA: 0x004D6770 File Offset: 0x004D4970
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasValue = this.HasValue;
					if (hasValue)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.Value);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E603 RID: 58883 RVA: 0x004D67BC File Offset: 0x004D49BC
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasValue = this.HasValue;
					if (hasValue)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Value);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E604 RID: 58884 RVA: 0x004D680C File Offset: 0x004D4A0C
				[DebuggerNonUserCode]
				public void MergeFrom(QuestSavedState.Types.QuestGizmoCompletedCallbacks other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasValue = other.HasValue;
						if (hasValue)
						{
							this.Value = other.Value;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E605 RID: 58885 RVA: 0x004D6855 File Offset: 0x004D4A55
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E606 RID: 58886 RVA: 0x004D6860 File Offset: 0x004D4A60
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
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Value = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A3AE RID: 41902
				private static readonly MessageParser<QuestSavedState.Types.QuestGizmoCompletedCallbacks> _parser = new MessageParser<QuestSavedState.Types.QuestGizmoCompletedCallbacks>(() => new QuestSavedState.Types.QuestGizmoCompletedCallbacks());

				// Token: 0x0400A3AF RID: 41903
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A3B0 RID: 41904
				private int _hasBits0;

				// Token: 0x0400A3B1 RID: 41905
				public const int ValueFieldNumber = 1;

				// Token: 0x0400A3B2 RID: 41906
				private static readonly uint ValueDefaultValue = 0U;

				// Token: 0x0400A3B3 RID: 41907
				private uint value_;
			}

			// Token: 0x02001479 RID: 5241
			public sealed class ObjectiveSetRewardChoices : IMessage<QuestSavedState.Types.ObjectiveSetRewardChoices>, IMessage, IEquatable<QuestSavedState.Types.ObjectiveSetRewardChoices>, IDeepCloneable<QuestSavedState.Types.ObjectiveSetRewardChoices>, IBufferMessage
			{
				// Token: 0x17003A8F RID: 14991
				// (get) Token: 0x0600E608 RID: 58888 RVA: 0x004D68D4 File Offset: 0x004D4AD4
				[DebuggerNonUserCode]
				public static MessageParser<QuestSavedState.Types.ObjectiveSetRewardChoices> Parser
				{
					get
					{
						return QuestSavedState.Types.ObjectiveSetRewardChoices._parser;
					}
				}

				// Token: 0x17003A90 RID: 14992
				// (get) Token: 0x0600E609 RID: 58889 RVA: 0x004D68EC File Offset: 0x004D4AEC
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestSavedState.Descriptor.NestedTypes[3];
					}
				}

				// Token: 0x17003A91 RID: 14993
				// (get) Token: 0x0600E60A RID: 58890 RVA: 0x004D6910 File Offset: 0x004D4B10
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestSavedState.Types.ObjectiveSetRewardChoices.Descriptor;
					}
				}

				// Token: 0x0600E60B RID: 58891 RVA: 0x004D6927 File Offset: 0x004D4B27
				[DebuggerNonUserCode]
				public ObjectiveSetRewardChoices()
				{
				}

				// Token: 0x0600E60C RID: 58892 RVA: 0x004D693C File Offset: 0x004D4B3C
				[DebuggerNonUserCode]
				public ObjectiveSetRewardChoices(QuestSavedState.Types.ObjectiveSetRewardChoices other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.objectiveSetUid_ = other.objectiveSetUid_;
					this.callbackUid_ = other.callbackUid_;
					this.rewardChoices_ = other.rewardChoices_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E60D RID: 58893 RVA: 0x004D6998 File Offset: 0x004D4B98
				[DebuggerNonUserCode]
				public QuestSavedState.Types.ObjectiveSetRewardChoices Clone()
				{
					return new QuestSavedState.Types.ObjectiveSetRewardChoices(this);
				}

				// Token: 0x17003A92 RID: 14994
				// (get) Token: 0x0600E60E RID: 58894 RVA: 0x004D69B0 File Offset: 0x004D4BB0
				// (set) Token: 0x0600E60F RID: 58895 RVA: 0x004D69E1 File Offset: 0x004D4BE1
				[DebuggerNonUserCode]
				public uint ObjectiveSetUid
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint objectiveSetUidDefaultValue;
						if (flag)
						{
							objectiveSetUidDefaultValue = this.objectiveSetUid_;
						}
						else
						{
							objectiveSetUidDefaultValue = QuestSavedState.Types.ObjectiveSetRewardChoices.ObjectiveSetUidDefaultValue;
						}
						return objectiveSetUidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.objectiveSetUid_ = value;
					}
				}

				// Token: 0x17003A93 RID: 14995
				// (get) Token: 0x0600E610 RID: 58896 RVA: 0x004D69FC File Offset: 0x004D4BFC
				[DebuggerNonUserCode]
				public bool HasObjectiveSetUid
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E611 RID: 58897 RVA: 0x004D6A19 File Offset: 0x004D4C19
				[DebuggerNonUserCode]
				public void ClearObjectiveSetUid()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A94 RID: 14996
				// (get) Token: 0x0600E612 RID: 58898 RVA: 0x004D6A2C File Offset: 0x004D4C2C
				// (set) Token: 0x0600E613 RID: 58899 RVA: 0x004D6A5D File Offset: 0x004D4C5D
				[DebuggerNonUserCode]
				public uint CallbackUid
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						uint callbackUidDefaultValue;
						if (flag)
						{
							callbackUidDefaultValue = this.callbackUid_;
						}
						else
						{
							callbackUidDefaultValue = QuestSavedState.Types.ObjectiveSetRewardChoices.CallbackUidDefaultValue;
						}
						return callbackUidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.callbackUid_ = value;
					}
				}

				// Token: 0x17003A95 RID: 14997
				// (get) Token: 0x0600E614 RID: 58900 RVA: 0x004D6A78 File Offset: 0x004D4C78
				[DebuggerNonUserCode]
				public bool HasCallbackUid
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E615 RID: 58901 RVA: 0x004D6A95 File Offset: 0x004D4C95
				[DebuggerNonUserCode]
				public void ClearCallbackUid()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A96 RID: 14998
				// (get) Token: 0x0600E616 RID: 58902 RVA: 0x004D6AA8 File Offset: 0x004D4CA8
				[DebuggerNonUserCode]
				public RepeatedField<Generator> RewardChoices
				{
					get
					{
						return this.rewardChoices_;
					}
				}

				// Token: 0x0600E617 RID: 58903 RVA: 0x004D6AC0 File Offset: 0x004D4CC0
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestSavedState.Types.ObjectiveSetRewardChoices);
				}

				// Token: 0x0600E618 RID: 58904 RVA: 0x004D6AE0 File Offset: 0x004D4CE0
				[DebuggerNonUserCode]
				public bool Equals(QuestSavedState.Types.ObjectiveSetRewardChoices other)
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
							bool flag4 = this.ObjectiveSetUid != other.ObjectiveSetUid;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.CallbackUid != other.CallbackUid;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !this.rewardChoices_.Equals(other.rewardChoices_);
									flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E619 RID: 58905 RVA: 0x004D6B70 File Offset: 0x004D4D70
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasObjectiveSetUid = this.HasObjectiveSetUid;
					if (hasObjectiveSetUid)
					{
						num ^= this.ObjectiveSetUid.GetHashCode();
					}
					bool hasCallbackUid = this.HasCallbackUid;
					if (hasCallbackUid)
					{
						num ^= this.CallbackUid.GetHashCode();
					}
					num ^= this.rewardChoices_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E61A RID: 58906 RVA: 0x004D6BEC File Offset: 0x004D4DEC
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E61B RID: 58907 RVA: 0x004D6C04 File Offset: 0x004D4E04
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E61C RID: 58908 RVA: 0x004D6C10 File Offset: 0x004D4E10
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasObjectiveSetUid = this.HasObjectiveSetUid;
					if (hasObjectiveSetUid)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.ObjectiveSetUid);
					}
					bool hasCallbackUid = this.HasCallbackUid;
					if (hasCallbackUid)
					{
						output.WriteRawTag(16);
						output.WriteUInt32(this.CallbackUid);
					}
					this.rewardChoices_.WriteTo(ref output, QuestSavedState.Types.ObjectiveSetRewardChoices._repeated_rewardChoices_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E61D RID: 58909 RVA: 0x004D6C90 File Offset: 0x004D4E90
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasObjectiveSetUid = this.HasObjectiveSetUid;
					if (hasObjectiveSetUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.ObjectiveSetUid);
					}
					bool hasCallbackUid = this.HasCallbackUid;
					if (hasCallbackUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.CallbackUid);
					}
					num += this.rewardChoices_.CalculateSize(QuestSavedState.Types.ObjectiveSetRewardChoices._repeated_rewardChoices_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E61E RID: 58910 RVA: 0x004D6D10 File Offset: 0x004D4F10
				[DebuggerNonUserCode]
				public void MergeFrom(QuestSavedState.Types.ObjectiveSetRewardChoices other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasObjectiveSetUid = other.HasObjectiveSetUid;
						if (hasObjectiveSetUid)
						{
							this.ObjectiveSetUid = other.ObjectiveSetUid;
						}
						bool hasCallbackUid = other.HasCallbackUid;
						if (hasCallbackUid)
						{
							this.CallbackUid = other.CallbackUid;
						}
						this.rewardChoices_.Add(other.rewardChoices_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E61F RID: 58911 RVA: 0x004D6D84 File Offset: 0x004D4F84
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E620 RID: 58912 RVA: 0x004D6D90 File Offset: 0x004D4F90
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
									this.rewardChoices_.AddEntriesFrom(ref input, QuestSavedState.Types.ObjectiveSetRewardChoices._repeated_rewardChoices_codec);
								}
							}
							else
							{
								this.CallbackUid = input.ReadUInt32();
							}
						}
						else
						{
							this.ObjectiveSetUid = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A3B4 RID: 41908
				private static readonly MessageParser<QuestSavedState.Types.ObjectiveSetRewardChoices> _parser = new MessageParser<QuestSavedState.Types.ObjectiveSetRewardChoices>(() => new QuestSavedState.Types.ObjectiveSetRewardChoices());

				// Token: 0x0400A3B5 RID: 41909
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A3B6 RID: 41910
				private int _hasBits0;

				// Token: 0x0400A3B7 RID: 41911
				public const int ObjectiveSetUidFieldNumber = 1;

				// Token: 0x0400A3B8 RID: 41912
				private static readonly uint ObjectiveSetUidDefaultValue = 0U;

				// Token: 0x0400A3B9 RID: 41913
				private uint objectiveSetUid_;

				// Token: 0x0400A3BA RID: 41914
				public const int CallbackUidFieldNumber = 2;

				// Token: 0x0400A3BB RID: 41915
				private static readonly uint CallbackUidDefaultValue = 0U;

				// Token: 0x0400A3BC RID: 41916
				private uint callbackUid_;

				// Token: 0x0400A3BD RID: 41917
				public const int RewardChoicesFieldNumber = 3;

				// Token: 0x0400A3BE RID: 41918
				private static readonly FieldCodec<Generator> _repeated_rewardChoices_codec = FieldCodec.ForMessage<Generator>(26U, Generator.Parser);

				// Token: 0x0400A3BF RID: 41919
				private readonly RepeatedField<Generator> rewardChoices_ = new RepeatedField<Generator>();
			}

			// Token: 0x0200147A RID: 5242
			public sealed class FollowerClone : IMessage<QuestSavedState.Types.FollowerClone>, IMessage, IEquatable<QuestSavedState.Types.FollowerClone>, IDeepCloneable<QuestSavedState.Types.FollowerClone>, IBufferMessage
			{
				// Token: 0x17003A97 RID: 14999
				// (get) Token: 0x0600E622 RID: 58914 RVA: 0x004D6E4C File Offset: 0x004D504C
				[DebuggerNonUserCode]
				public static MessageParser<QuestSavedState.Types.FollowerClone> Parser
				{
					get
					{
						return QuestSavedState.Types.FollowerClone._parser;
					}
				}

				// Token: 0x17003A98 RID: 15000
				// (get) Token: 0x0600E623 RID: 58915 RVA: 0x004D6E64 File Offset: 0x004D5064
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestSavedState.Descriptor.NestedTypes[4];
					}
				}

				// Token: 0x17003A99 RID: 15001
				// (get) Token: 0x0600E624 RID: 58916 RVA: 0x004D6E88 File Offset: 0x004D5088
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestSavedState.Types.FollowerClone.Descriptor;
					}
				}

				// Token: 0x0600E625 RID: 58917 RVA: 0x004D6E9F File Offset: 0x004D509F
				[DebuggerNonUserCode]
				public FollowerClone()
				{
				}

				// Token: 0x0600E626 RID: 58918 RVA: 0x004D6EAC File Offset: 0x004D50AC
				[DebuggerNonUserCode]
				public FollowerClone(QuestSavedState.Types.FollowerClone other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.followerActorSno_ = other.followerActorSno_;
					this.npcClonedFromActorSno_ = other.npcClonedFromActorSno_;
					this.animsetOverride_ = other.animsetOverride_;
					this.visualEquipment_ = ((other.visualEquipment_ != null) ? other.visualEquipment_.Clone() : null);
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E627 RID: 58919 RVA: 0x004D6F20 File Offset: 0x004D5120
				[DebuggerNonUserCode]
				public QuestSavedState.Types.FollowerClone Clone()
				{
					return new QuestSavedState.Types.FollowerClone(this);
				}

				// Token: 0x17003A9A RID: 15002
				// (get) Token: 0x0600E628 RID: 58920 RVA: 0x004D6F38 File Offset: 0x004D5138
				// (set) Token: 0x0600E629 RID: 58921 RVA: 0x004D6F69 File Offset: 0x004D5169
				[DebuggerNonUserCode]
				public int FollowerActorSno
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int followerActorSnoDefaultValue;
						if (flag)
						{
							followerActorSnoDefaultValue = this.followerActorSno_;
						}
						else
						{
							followerActorSnoDefaultValue = QuestSavedState.Types.FollowerClone.FollowerActorSnoDefaultValue;
						}
						return followerActorSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.followerActorSno_ = value;
					}
				}

				// Token: 0x17003A9B RID: 15003
				// (get) Token: 0x0600E62A RID: 58922 RVA: 0x004D6F84 File Offset: 0x004D5184
				[DebuggerNonUserCode]
				public bool HasFollowerActorSno
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E62B RID: 58923 RVA: 0x004D6FA1 File Offset: 0x004D51A1
				[DebuggerNonUserCode]
				public void ClearFollowerActorSno()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A9C RID: 15004
				// (get) Token: 0x0600E62C RID: 58924 RVA: 0x004D6FB4 File Offset: 0x004D51B4
				// (set) Token: 0x0600E62D RID: 58925 RVA: 0x004D6FE5 File Offset: 0x004D51E5
				[DebuggerNonUserCode]
				public int NpcClonedFromActorSno
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int npcClonedFromActorSnoDefaultValue;
						if (flag)
						{
							npcClonedFromActorSnoDefaultValue = this.npcClonedFromActorSno_;
						}
						else
						{
							npcClonedFromActorSnoDefaultValue = QuestSavedState.Types.FollowerClone.NpcClonedFromActorSnoDefaultValue;
						}
						return npcClonedFromActorSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.npcClonedFromActorSno_ = value;
					}
				}

				// Token: 0x17003A9D RID: 15005
				// (get) Token: 0x0600E62E RID: 58926 RVA: 0x004D7000 File Offset: 0x004D5200
				[DebuggerNonUserCode]
				public bool HasNpcClonedFromActorSno
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E62F RID: 58927 RVA: 0x004D701D File Offset: 0x004D521D
				[DebuggerNonUserCode]
				public void ClearNpcClonedFromActorSno()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A9E RID: 15006
				// (get) Token: 0x0600E630 RID: 58928 RVA: 0x004D7030 File Offset: 0x004D5230
				// (set) Token: 0x0600E631 RID: 58929 RVA: 0x004D7061 File Offset: 0x004D5261
				[DebuggerNonUserCode]
				public int AnimsetOverride
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						int animsetOverrideDefaultValue;
						if (flag)
						{
							animsetOverrideDefaultValue = this.animsetOverride_;
						}
						else
						{
							animsetOverrideDefaultValue = QuestSavedState.Types.FollowerClone.AnimsetOverrideDefaultValue;
						}
						return animsetOverrideDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.animsetOverride_ = value;
					}
				}

				// Token: 0x17003A9F RID: 15007
				// (get) Token: 0x0600E632 RID: 58930 RVA: 0x004D707C File Offset: 0x004D527C
				[DebuggerNonUserCode]
				public bool HasAnimsetOverride
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E633 RID: 58931 RVA: 0x004D7099 File Offset: 0x004D5299
				[DebuggerNonUserCode]
				public void ClearAnimsetOverride()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003AA0 RID: 15008
				// (get) Token: 0x0600E634 RID: 58932 RVA: 0x004D70AC File Offset: 0x004D52AC
				// (set) Token: 0x0600E635 RID: 58933 RVA: 0x004D70C4 File Offset: 0x004D52C4
				[DebuggerNonUserCode]
				public VisualEquipment VisualEquipment
				{
					get
					{
						return this.visualEquipment_;
					}
					set
					{
						this.visualEquipment_ = value;
					}
				}

				// Token: 0x0600E636 RID: 58934 RVA: 0x004D70D0 File Offset: 0x004D52D0
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestSavedState.Types.FollowerClone);
				}

				// Token: 0x0600E637 RID: 58935 RVA: 0x004D70F0 File Offset: 0x004D52F0
				[DebuggerNonUserCode]
				public bool Equals(QuestSavedState.Types.FollowerClone other)
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
							bool flag4 = this.FollowerActorSno != other.FollowerActorSno;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.NpcClonedFromActorSno != other.NpcClonedFromActorSno;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.AnimsetOverride != other.AnimsetOverride;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = !object.Equals(this.VisualEquipment, other.VisualEquipment);
										flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E638 RID: 58936 RVA: 0x004D71A0 File Offset: 0x004D53A0
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasFollowerActorSno = this.HasFollowerActorSno;
					if (hasFollowerActorSno)
					{
						num ^= this.FollowerActorSno.GetHashCode();
					}
					bool hasNpcClonedFromActorSno = this.HasNpcClonedFromActorSno;
					if (hasNpcClonedFromActorSno)
					{
						num ^= this.NpcClonedFromActorSno.GetHashCode();
					}
					bool hasAnimsetOverride = this.HasAnimsetOverride;
					if (hasAnimsetOverride)
					{
						num ^= this.AnimsetOverride.GetHashCode();
					}
					bool flag = this.visualEquipment_ != null;
					if (flag)
					{
						num ^= this.VisualEquipment.GetHashCode();
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E639 RID: 58937 RVA: 0x004D7248 File Offset: 0x004D5448
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E63A RID: 58938 RVA: 0x004D7260 File Offset: 0x004D5460
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E63B RID: 58939 RVA: 0x004D726C File Offset: 0x004D546C
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasFollowerActorSno = this.HasFollowerActorSno;
					if (hasFollowerActorSno)
					{
						output.WriteRawTag(13);
						output.WriteSFixed32(this.FollowerActorSno);
					}
					bool hasNpcClonedFromActorSno = this.HasNpcClonedFromActorSno;
					if (hasNpcClonedFromActorSno)
					{
						output.WriteRawTag(21);
						output.WriteSFixed32(this.NpcClonedFromActorSno);
					}
					bool hasAnimsetOverride = this.HasAnimsetOverride;
					if (hasAnimsetOverride)
					{
						output.WriteRawTag(29);
						output.WriteSFixed32(this.AnimsetOverride);
					}
					bool flag = this.visualEquipment_ != null;
					if (flag)
					{
						output.WriteRawTag(34);
						output.WriteMessage(this.VisualEquipment);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E63C RID: 58940 RVA: 0x004D7324 File Offset: 0x004D5524
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasFollowerActorSno = this.HasFollowerActorSno;
					if (hasFollowerActorSno)
					{
						num += 5;
					}
					bool hasNpcClonedFromActorSno = this.HasNpcClonedFromActorSno;
					if (hasNpcClonedFromActorSno)
					{
						num += 5;
					}
					bool hasAnimsetOverride = this.HasAnimsetOverride;
					if (hasAnimsetOverride)
					{
						num += 5;
					}
					bool flag = this.visualEquipment_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.VisualEquipment);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E63D RID: 58941 RVA: 0x004D73AC File Offset: 0x004D55AC
				[DebuggerNonUserCode]
				public void MergeFrom(QuestSavedState.Types.FollowerClone other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasFollowerActorSno = other.HasFollowerActorSno;
						if (hasFollowerActorSno)
						{
							this.FollowerActorSno = other.FollowerActorSno;
						}
						bool hasNpcClonedFromActorSno = other.HasNpcClonedFromActorSno;
						if (hasNpcClonedFromActorSno)
						{
							this.NpcClonedFromActorSno = other.NpcClonedFromActorSno;
						}
						bool hasAnimsetOverride = other.HasAnimsetOverride;
						if (hasAnimsetOverride)
						{
							this.AnimsetOverride = other.AnimsetOverride;
						}
						bool flag2 = other.visualEquipment_ != null;
						if (flag2)
						{
							bool flag3 = this.visualEquipment_ == null;
							if (flag3)
							{
								this.VisualEquipment = new VisualEquipment();
							}
							this.VisualEquipment.MergeFrom(other.VisualEquipment);
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E63E RID: 58942 RVA: 0x004D746A File Offset: 0x004D566A
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E63F RID: 58943 RVA: 0x004D7478 File Offset: 0x004D5678
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 21U)
						{
							if (num3 != 13U)
							{
								if (num3 != 21U)
								{
									goto IL_002C;
								}
								this.NpcClonedFromActorSno = input.ReadSFixed32();
							}
							else
							{
								this.FollowerActorSno = input.ReadSFixed32();
							}
						}
						else if (num3 != 29U)
						{
							if (num3 != 34U)
							{
								goto IL_002C;
							}
							bool flag = this.visualEquipment_ == null;
							if (flag)
							{
								this.VisualEquipment = new VisualEquipment();
							}
							input.ReadMessage(this.VisualEquipment);
						}
						else
						{
							this.AnimsetOverride = input.ReadSFixed32();
						}
						continue;
						IL_002C:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A3C0 RID: 41920
				private static readonly MessageParser<QuestSavedState.Types.FollowerClone> _parser = new MessageParser<QuestSavedState.Types.FollowerClone>(() => new QuestSavedState.Types.FollowerClone());

				// Token: 0x0400A3C1 RID: 41921
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A3C2 RID: 41922
				private int _hasBits0;

				// Token: 0x0400A3C3 RID: 41923
				public const int FollowerActorSnoFieldNumber = 1;

				// Token: 0x0400A3C4 RID: 41924
				private static readonly int FollowerActorSnoDefaultValue = 0;

				// Token: 0x0400A3C5 RID: 41925
				private int followerActorSno_;

				// Token: 0x0400A3C6 RID: 41926
				public const int NpcClonedFromActorSnoFieldNumber = 2;

				// Token: 0x0400A3C7 RID: 41927
				private static readonly int NpcClonedFromActorSnoDefaultValue = 0;

				// Token: 0x0400A3C8 RID: 41928
				private int npcClonedFromActorSno_;

				// Token: 0x0400A3C9 RID: 41929
				public const int AnimsetOverrideFieldNumber = 3;

				// Token: 0x0400A3CA RID: 41930
				private static readonly int AnimsetOverrideDefaultValue = 0;

				// Token: 0x0400A3CB RID: 41931
				private int animsetOverride_;

				// Token: 0x0400A3CC RID: 41932
				public const int VisualEquipmentFieldNumber = 4;

				// Token: 0x0400A3CD RID: 41933
				private VisualEquipment visualEquipment_;
			}
		}
	}
}
