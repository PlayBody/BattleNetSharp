using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x0200012A RID: 298
	public sealed class QuestStateUpdateMessage : IMessage<QuestStateUpdateMessage>, IMessage, IEquatable<QuestStateUpdateMessage>, IDeepCloneable<QuestStateUpdateMessage>, IBufferMessage
	{
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x00071FCC File Offset: 0x000701CC
		[DebuggerNonUserCode]
		public static MessageParser<QuestStateUpdateMessage> Parser
		{
			get
			{
				return QuestStateUpdateMessage._parser;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00071FE4 File Offset: 0x000701E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00072008 File Offset: 0x00070208
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestStateUpdateMessage.Descriptor;
			}
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0007201F File Offset: 0x0007021F
		[DebuggerNonUserCode]
		public QuestStateUpdateMessage()
		{
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00072034 File Offset: 0x00070234
		[DebuggerNonUserCode]
		public QuestStateUpdateMessage(QuestStateUpdateMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.updateType_ = other.updateType_;
			this.questState_ = ((other.questState_ != null) ? other.questState_.Clone() : null);
			this.questId_ = other.questId_;
			this.ownerGameAccountId_ = other.ownerGameAccountId_;
			this.eventState_ = other.eventState_;
			this.eventActivateTime_ = other.eventActivateTime_;
			this.snoEventLevelArea_ = other.snoEventLevelArea_;
			this.objectiveIsKnown_ = other.objectiveIsKnown_;
			this.fromRestore_ = other.fromRestore_;
			this.hadLuaRuntimeError_ = other.hadLuaRuntimeError_;
			this.luaRuntimeError_ = other.luaRuntimeError_;
			this.phaseIsHidden_ = other.phaseIsHidden_;
			this.paramData_ = other.paramData_.Clone();
			this.numParticipants_ = other.numParticipants_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00072124 File Offset: 0x00070324
		[DebuggerNonUserCode]
		public QuestStateUpdateMessage Clone()
		{
			return new QuestStateUpdateMessage(this);
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x0007213C File Offset: 0x0007033C
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x0007216D File Offset: 0x0007036D
		[DebuggerNonUserCode]
		public QuestStateUpdateMessage.Types.UpdateType UpdateType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				QuestStateUpdateMessage.Types.UpdateType updateTypeDefaultValue;
				if (flag)
				{
					updateTypeDefaultValue = this.updateType_;
				}
				else
				{
					updateTypeDefaultValue = QuestStateUpdateMessage.UpdateTypeDefaultValue;
				}
				return updateTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.updateType_ = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00072188 File Offset: 0x00070388
		[DebuggerNonUserCode]
		public bool HasUpdateType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000721A5 File Offset: 0x000703A5
		[DebuggerNonUserCode]
		public void ClearUpdateType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x000721B8 File Offset: 0x000703B8
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x000721D0 File Offset: 0x000703D0
		[DebuggerNonUserCode]
		public QuestSavedState QuestState
		{
			get
			{
				return this.questState_;
			}
			set
			{
				this.questState_ = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x000721DC File Offset: 0x000703DC
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x0007220D File Offset: 0x0007040D
		[DebuggerNonUserCode]
		public int QuestId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int questIdDefaultValue;
				if (flag)
				{
					questIdDefaultValue = this.questId_;
				}
				else
				{
					questIdDefaultValue = QuestStateUpdateMessage.QuestIdDefaultValue;
				}
				return questIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.questId_ = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00072228 File Offset: 0x00070428
		[DebuggerNonUserCode]
		public bool HasQuestId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00072245 File Offset: 0x00070445
		[DebuggerNonUserCode]
		public void ClearQuestId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x00072258 File Offset: 0x00070458
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x00072289 File Offset: 0x00070489
		[DebuggerNonUserCode]
		public uint OwnerGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint ownerGameAccountIdDefaultValue;
				if (flag)
				{
					ownerGameAccountIdDefaultValue = this.ownerGameAccountId_;
				}
				else
				{
					ownerGameAccountIdDefaultValue = QuestStateUpdateMessage.OwnerGameAccountIdDefaultValue;
				}
				return ownerGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.ownerGameAccountId_ = value;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x000722A4 File Offset: 0x000704A4
		[DebuggerNonUserCode]
		public bool HasOwnerGameAccountId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x000722C1 File Offset: 0x000704C1
		[DebuggerNonUserCode]
		public void ClearOwnerGameAccountId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x000722D4 File Offset: 0x000704D4
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x00072305 File Offset: 0x00070505
		[DebuggerNonUserCode]
		public QuestStateUpdateMessage.Types.EventState EventState
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				QuestStateUpdateMessage.Types.EventState eventStateDefaultValue;
				if (flag)
				{
					eventStateDefaultValue = this.eventState_;
				}
				else
				{
					eventStateDefaultValue = QuestStateUpdateMessage.EventStateDefaultValue;
				}
				return eventStateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.eventState_ = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x00072320 File Offset: 0x00070520
		[DebuggerNonUserCode]
		public bool HasEventState
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0007233D File Offset: 0x0007053D
		[DebuggerNonUserCode]
		public void ClearEventState()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00072350 File Offset: 0x00070550
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x00072382 File Offset: 0x00070582
		[DebuggerNonUserCode]
		public ulong EventActivateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong eventActivateTimeDefaultValue;
				if (flag)
				{
					eventActivateTimeDefaultValue = this.eventActivateTime_;
				}
				else
				{
					eventActivateTimeDefaultValue = QuestStateUpdateMessage.EventActivateTimeDefaultValue;
				}
				return eventActivateTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.eventActivateTime_ = value;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0007239C File Offset: 0x0007059C
		[DebuggerNonUserCode]
		public bool HasEventActivateTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000723BA File Offset: 0x000705BA
		[DebuggerNonUserCode]
		public void ClearEventActivateTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000723CC File Offset: 0x000705CC
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x000723FE File Offset: 0x000705FE
		[DebuggerNonUserCode]
		public int SnoEventLevelArea
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int snoEventLevelAreaDefaultValue;
				if (flag)
				{
					snoEventLevelAreaDefaultValue = this.snoEventLevelArea_;
				}
				else
				{
					snoEventLevelAreaDefaultValue = QuestStateUpdateMessage.SnoEventLevelAreaDefaultValue;
				}
				return snoEventLevelAreaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.snoEventLevelArea_ = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00072418 File Offset: 0x00070618
		[DebuggerNonUserCode]
		public bool HasSnoEventLevelArea
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00072436 File Offset: 0x00070636
		[DebuggerNonUserCode]
		public void ClearSnoEventLevelArea()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00072448 File Offset: 0x00070648
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0007247A File Offset: 0x0007067A
		[DebuggerNonUserCode]
		public bool ObjectiveIsKnown
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool objectiveIsKnownDefaultValue;
				if (flag)
				{
					objectiveIsKnownDefaultValue = this.objectiveIsKnown_;
				}
				else
				{
					objectiveIsKnownDefaultValue = QuestStateUpdateMessage.ObjectiveIsKnownDefaultValue;
				}
				return objectiveIsKnownDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.objectiveIsKnown_ = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00072494 File Offset: 0x00070694
		[DebuggerNonUserCode]
		public bool HasObjectiveIsKnown
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x000724B2 File Offset: 0x000706B2
		[DebuggerNonUserCode]
		public void ClearObjectiveIsKnown()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000724C4 File Offset: 0x000706C4
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x000724F9 File Offset: 0x000706F9
		[DebuggerNonUserCode]
		public bool FromRestore
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool fromRestoreDefaultValue;
				if (flag)
				{
					fromRestoreDefaultValue = this.fromRestore_;
				}
				else
				{
					fromRestoreDefaultValue = QuestStateUpdateMessage.FromRestoreDefaultValue;
				}
				return fromRestoreDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.fromRestore_ = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00072518 File Offset: 0x00070718
		[DebuggerNonUserCode]
		public bool HasFromRestore
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00072539 File Offset: 0x00070739
		[DebuggerNonUserCode]
		public void ClearFromRestore()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00072550 File Offset: 0x00070750
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00072585 File Offset: 0x00070785
		[DebuggerNonUserCode]
		public bool HadLuaRuntimeError
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool hadLuaRuntimeErrorDefaultValue;
				if (flag)
				{
					hadLuaRuntimeErrorDefaultValue = this.hadLuaRuntimeError_;
				}
				else
				{
					hadLuaRuntimeErrorDefaultValue = QuestStateUpdateMessage.HadLuaRuntimeErrorDefaultValue;
				}
				return hadLuaRuntimeErrorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.hadLuaRuntimeError_ = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x000725A4 File Offset: 0x000707A4
		[DebuggerNonUserCode]
		public bool HasHadLuaRuntimeError
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000725C5 File Offset: 0x000707C5
		[DebuggerNonUserCode]
		public void ClearHadLuaRuntimeError()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x000725DC File Offset: 0x000707DC
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x000725FD File Offset: 0x000707FD
		[DebuggerNonUserCode]
		public string LuaRuntimeError
		{
			get
			{
				return this.luaRuntimeError_ ?? QuestStateUpdateMessage.LuaRuntimeErrorDefaultValue;
			}
			set
			{
				this.luaRuntimeError_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00072614 File Offset: 0x00070814
		[DebuggerNonUserCode]
		public bool HasLuaRuntimeError
		{
			get
			{
				return this.luaRuntimeError_ != null;
			}
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x0007262F File Offset: 0x0007082F
		[DebuggerNonUserCode]
		public void ClearLuaRuntimeError()
		{
			this.luaRuntimeError_ = null;
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0007263C File Offset: 0x0007083C
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x00072671 File Offset: 0x00070871
		[DebuggerNonUserCode]
		public bool PhaseIsHidden
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				bool phaseIsHiddenDefaultValue;
				if (flag)
				{
					phaseIsHiddenDefaultValue = this.phaseIsHidden_;
				}
				else
				{
					phaseIsHiddenDefaultValue = QuestStateUpdateMessage.PhaseIsHiddenDefaultValue;
				}
				return phaseIsHiddenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.phaseIsHidden_ = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00072690 File Offset: 0x00070890
		[DebuggerNonUserCode]
		public bool HasPhaseIsHidden
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000726B1 File Offset: 0x000708B1
		[DebuggerNonUserCode]
		public void ClearPhaseIsHidden()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x000726C8 File Offset: 0x000708C8
		[DebuggerNonUserCode]
		public RepeatedField<QuestStateUpdateMessage.Types.CustomParamMessageData> ParamData
		{
			get
			{
				return this.paramData_;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x000726E0 File Offset: 0x000708E0
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00072715 File Offset: 0x00070915
		[DebuggerNonUserCode]
		public uint NumParticipants
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint numParticipantsDefaultValue;
				if (flag)
				{
					numParticipantsDefaultValue = this.numParticipants_;
				}
				else
				{
					numParticipantsDefaultValue = QuestStateUpdateMessage.NumParticipantsDefaultValue;
				}
				return numParticipantsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.numParticipants_ = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00072734 File Offset: 0x00070934
		[DebuggerNonUserCode]
		public bool HasNumParticipants
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00072755 File Offset: 0x00070955
		[DebuggerNonUserCode]
		public void ClearNumParticipants()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0007276C File Offset: 0x0007096C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestStateUpdateMessage);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0007278C File Offset: 0x0007098C
		[DebuggerNonUserCode]
		public bool Equals(QuestStateUpdateMessage other)
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
					bool flag4 = this.UpdateType != other.UpdateType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.QuestState, other.QuestState);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.QuestId != other.QuestId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.OwnerGameAccountId != other.OwnerGameAccountId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.EventState != other.EventState;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.EventActivateTime != other.EventActivateTime;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SnoEventLevelArea != other.SnoEventLevelArea;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ObjectiveIsKnown != other.ObjectiveIsKnown;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.FromRestore != other.FromRestore;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.HadLuaRuntimeError != other.HadLuaRuntimeError;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.LuaRuntimeError != other.LuaRuntimeError;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.PhaseIsHidden != other.PhaseIsHidden;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !this.paramData_.Equals(other.paramData_);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.NumParticipants != other.NumParticipants;
																		flag2 = !flag17 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0007296C File Offset: 0x00070B6C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUpdateType = this.HasUpdateType;
			if (hasUpdateType)
			{
				num ^= this.UpdateType.GetHashCode();
			}
			bool flag = this.questState_ != null;
			if (flag)
			{
				num ^= this.QuestState.GetHashCode();
			}
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num ^= this.QuestId.GetHashCode();
			}
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				num ^= this.OwnerGameAccountId.GetHashCode();
			}
			bool hasEventState = this.HasEventState;
			if (hasEventState)
			{
				num ^= this.EventState.GetHashCode();
			}
			bool hasEventActivateTime = this.HasEventActivateTime;
			if (hasEventActivateTime)
			{
				num ^= this.EventActivateTime.GetHashCode();
			}
			bool hasSnoEventLevelArea = this.HasSnoEventLevelArea;
			if (hasSnoEventLevelArea)
			{
				num ^= this.SnoEventLevelArea.GetHashCode();
			}
			bool hasObjectiveIsKnown = this.HasObjectiveIsKnown;
			if (hasObjectiveIsKnown)
			{
				num ^= this.ObjectiveIsKnown.GetHashCode();
			}
			bool hasFromRestore = this.HasFromRestore;
			if (hasFromRestore)
			{
				num ^= this.FromRestore.GetHashCode();
			}
			bool hasHadLuaRuntimeError = this.HasHadLuaRuntimeError;
			if (hasHadLuaRuntimeError)
			{
				num ^= this.HadLuaRuntimeError.GetHashCode();
			}
			bool hasLuaRuntimeError = this.HasLuaRuntimeError;
			if (hasLuaRuntimeError)
			{
				num ^= this.LuaRuntimeError.GetHashCode();
			}
			bool hasPhaseIsHidden = this.HasPhaseIsHidden;
			if (hasPhaseIsHidden)
			{
				num ^= this.PhaseIsHidden.GetHashCode();
			}
			num ^= this.paramData_.GetHashCode();
			bool hasNumParticipants = this.HasNumParticipants;
			if (hasNumParticipants)
			{
				num ^= this.NumParticipants.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00072B38 File Offset: 0x00070D38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00072B50 File Offset: 0x00070D50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00072B5C File Offset: 0x00070D5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUpdateType = this.HasUpdateType;
			if (hasUpdateType)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.UpdateType);
			}
			bool flag = this.questState_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.QuestState);
			}
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.QuestId);
			}
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OwnerGameAccountId);
			}
			bool hasEventState = this.HasEventState;
			if (hasEventState)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.EventState);
			}
			bool hasEventActivateTime = this.HasEventActivateTime;
			if (hasEventActivateTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.EventActivateTime);
			}
			bool hasSnoEventLevelArea = this.HasSnoEventLevelArea;
			if (hasSnoEventLevelArea)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SnoEventLevelArea);
			}
			bool hasObjectiveIsKnown = this.HasObjectiveIsKnown;
			if (hasObjectiveIsKnown)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ObjectiveIsKnown);
			}
			bool hasFromRestore = this.HasFromRestore;
			if (hasFromRestore)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.FromRestore);
			}
			bool hasHadLuaRuntimeError = this.HasHadLuaRuntimeError;
			if (hasHadLuaRuntimeError)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.HadLuaRuntimeError);
			}
			bool hasLuaRuntimeError = this.HasLuaRuntimeError;
			if (hasLuaRuntimeError)
			{
				output.WriteRawTag(90);
				output.WriteString(this.LuaRuntimeError);
			}
			bool hasPhaseIsHidden = this.HasPhaseIsHidden;
			if (hasPhaseIsHidden)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.PhaseIsHidden);
			}
			this.paramData_.WriteTo(ref output, QuestStateUpdateMessage._repeated_paramData_codec);
			bool hasNumParticipants = this.HasNumParticipants;
			if (hasNumParticipants)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.NumParticipants);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00072D68 File Offset: 0x00070F68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUpdateType = this.HasUpdateType;
			if (hasUpdateType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UpdateType);
			}
			bool flag = this.questState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QuestState);
			}
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			bool hasOwnerGameAccountId = this.HasOwnerGameAccountId;
			if (hasOwnerGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OwnerGameAccountId);
			}
			bool hasEventState = this.HasEventState;
			if (hasEventState)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EventState);
			}
			bool hasEventActivateTime = this.HasEventActivateTime;
			if (hasEventActivateTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EventActivateTime);
			}
			bool hasSnoEventLevelArea = this.HasSnoEventLevelArea;
			if (hasSnoEventLevelArea)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoEventLevelArea);
			}
			bool hasObjectiveIsKnown = this.HasObjectiveIsKnown;
			if (hasObjectiveIsKnown)
			{
				num += 2;
			}
			bool hasFromRestore = this.HasFromRestore;
			if (hasFromRestore)
			{
				num += 2;
			}
			bool hasHadLuaRuntimeError = this.HasHadLuaRuntimeError;
			if (hasHadLuaRuntimeError)
			{
				num += 2;
			}
			bool hasLuaRuntimeError = this.HasLuaRuntimeError;
			if (hasLuaRuntimeError)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LuaRuntimeError);
			}
			bool hasPhaseIsHidden = this.HasPhaseIsHidden;
			if (hasPhaseIsHidden)
			{
				num += 2;
			}
			num += this.paramData_.CalculateSize(QuestStateUpdateMessage._repeated_paramData_codec);
			bool hasNumParticipants = this.HasNumParticipants;
			if (hasNumParticipants)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NumParticipants);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00072F04 File Offset: 0x00071104
		[DebuggerNonUserCode]
		public void MergeFrom(QuestStateUpdateMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUpdateType = other.HasUpdateType;
				if (hasUpdateType)
				{
					this.UpdateType = other.UpdateType;
				}
				bool flag2 = other.questState_ != null;
				if (flag2)
				{
					bool flag3 = this.questState_ == null;
					if (flag3)
					{
						this.QuestState = new QuestSavedState();
					}
					this.QuestState.MergeFrom(other.QuestState);
				}
				bool hasQuestId = other.HasQuestId;
				if (hasQuestId)
				{
					this.QuestId = other.QuestId;
				}
				bool hasOwnerGameAccountId = other.HasOwnerGameAccountId;
				if (hasOwnerGameAccountId)
				{
					this.OwnerGameAccountId = other.OwnerGameAccountId;
				}
				bool hasEventState = other.HasEventState;
				if (hasEventState)
				{
					this.EventState = other.EventState;
				}
				bool hasEventActivateTime = other.HasEventActivateTime;
				if (hasEventActivateTime)
				{
					this.EventActivateTime = other.EventActivateTime;
				}
				bool hasSnoEventLevelArea = other.HasSnoEventLevelArea;
				if (hasSnoEventLevelArea)
				{
					this.SnoEventLevelArea = other.SnoEventLevelArea;
				}
				bool hasObjectiveIsKnown = other.HasObjectiveIsKnown;
				if (hasObjectiveIsKnown)
				{
					this.ObjectiveIsKnown = other.ObjectiveIsKnown;
				}
				bool hasFromRestore = other.HasFromRestore;
				if (hasFromRestore)
				{
					this.FromRestore = other.FromRestore;
				}
				bool hasHadLuaRuntimeError = other.HasHadLuaRuntimeError;
				if (hasHadLuaRuntimeError)
				{
					this.HadLuaRuntimeError = other.HadLuaRuntimeError;
				}
				bool hasLuaRuntimeError = other.HasLuaRuntimeError;
				if (hasLuaRuntimeError)
				{
					this.LuaRuntimeError = other.LuaRuntimeError;
				}
				bool hasPhaseIsHidden = other.HasPhaseIsHidden;
				if (hasPhaseIsHidden)
				{
					this.PhaseIsHidden = other.PhaseIsHidden;
				}
				this.paramData_.Add(other.paramData_);
				bool hasNumParticipants = other.HasNumParticipants;
				if (hasNumParticipants)
				{
					this.NumParticipants = other.NumParticipants;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000730C7 File Offset: 0x000712C7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000730D4 File Offset: 0x000712D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 56U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 24U)
								{
									goto IL_00AF;
								}
								this.QuestId = input.ReadInt32();
							}
							else
							{
								bool flag = this.questState_ == null;
								if (flag)
								{
									this.QuestState = new QuestSavedState();
								}
								input.ReadMessage(this.QuestState);
							}
						}
						else
						{
							this.UpdateType = (QuestStateUpdateMessage.Types.UpdateType)input.ReadEnum();
						}
					}
					else if (num3 <= 40U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_00AF;
							}
							this.EventState = (QuestStateUpdateMessage.Types.EventState)input.ReadEnum();
						}
						else
						{
							this.OwnerGameAccountId = input.ReadUInt32();
						}
					}
					else if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_00AF;
						}
						this.SnoEventLevelArea = input.ReadInt32();
					}
					else
					{
						this.EventActivateTime = input.ReadUInt64();
					}
				}
				else if (num3 <= 80U)
				{
					if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							if (num3 != 80U)
							{
								goto IL_00AF;
							}
							this.HadLuaRuntimeError = input.ReadBool();
						}
						else
						{
							this.FromRestore = input.ReadBool();
						}
					}
					else
					{
						this.ObjectiveIsKnown = input.ReadBool();
					}
				}
				else if (num3 <= 96U)
				{
					if (num3 != 90U)
					{
						if (num3 != 96U)
						{
							goto IL_00AF;
						}
						this.PhaseIsHidden = input.ReadBool();
					}
					else
					{
						this.LuaRuntimeError = input.ReadString();
					}
				}
				else if (num3 != 106U)
				{
					if (num3 != 112U)
					{
						goto IL_00AF;
					}
					this.NumParticipants = input.ReadUInt32();
				}
				else
				{
					this.paramData_.AddEntriesFrom(ref input, QuestStateUpdateMessage._repeated_paramData_codec);
				}
				continue;
				IL_00AF:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000CB5 RID: 3253
		private static readonly MessageParser<QuestStateUpdateMessage> _parser = new MessageParser<QuestStateUpdateMessage>(() => new QuestStateUpdateMessage());

		// Token: 0x04000CB6 RID: 3254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CB7 RID: 3255
		private int _hasBits0;

		// Token: 0x04000CB8 RID: 3256
		public const int UpdateTypeFieldNumber = 1;

		// Token: 0x04000CB9 RID: 3257
		private static readonly QuestStateUpdateMessage.Types.UpdateType UpdateTypeDefaultValue = QuestStateUpdateMessage.Types.UpdateType.UtCreate;

		// Token: 0x04000CBA RID: 3258
		private QuestStateUpdateMessage.Types.UpdateType updateType_;

		// Token: 0x04000CBB RID: 3259
		public const int QuestStateFieldNumber = 2;

		// Token: 0x04000CBC RID: 3260
		private QuestSavedState questState_;

		// Token: 0x04000CBD RID: 3261
		public const int QuestIdFieldNumber = 3;

		// Token: 0x04000CBE RID: 3262
		private static readonly int QuestIdDefaultValue = 0;

		// Token: 0x04000CBF RID: 3263
		private int questId_;

		// Token: 0x04000CC0 RID: 3264
		public const int OwnerGameAccountIdFieldNumber = 4;

		// Token: 0x04000CC1 RID: 3265
		private static readonly uint OwnerGameAccountIdDefaultValue = 0U;

		// Token: 0x04000CC2 RID: 3266
		private uint ownerGameAccountId_;

		// Token: 0x04000CC3 RID: 3267
		public const int EventStateFieldNumber = 5;

		// Token: 0x04000CC4 RID: 3268
		private static readonly QuestStateUpdateMessage.Types.EventState EventStateDefaultValue = QuestStateUpdateMessage.Types.EventState.EsNone;

		// Token: 0x04000CC5 RID: 3269
		private QuestStateUpdateMessage.Types.EventState eventState_;

		// Token: 0x04000CC6 RID: 3270
		public const int EventActivateTimeFieldNumber = 6;

		// Token: 0x04000CC7 RID: 3271
		private static readonly ulong EventActivateTimeDefaultValue = 0UL;

		// Token: 0x04000CC8 RID: 3272
		private ulong eventActivateTime_;

		// Token: 0x04000CC9 RID: 3273
		public const int SnoEventLevelAreaFieldNumber = 7;

		// Token: 0x04000CCA RID: 3274
		private static readonly int SnoEventLevelAreaDefaultValue = 0;

		// Token: 0x04000CCB RID: 3275
		private int snoEventLevelArea_;

		// Token: 0x04000CCC RID: 3276
		public const int ObjectiveIsKnownFieldNumber = 8;

		// Token: 0x04000CCD RID: 3277
		private static readonly bool ObjectiveIsKnownDefaultValue = false;

		// Token: 0x04000CCE RID: 3278
		private bool objectiveIsKnown_;

		// Token: 0x04000CCF RID: 3279
		public const int FromRestoreFieldNumber = 9;

		// Token: 0x04000CD0 RID: 3280
		private static readonly bool FromRestoreDefaultValue = false;

		// Token: 0x04000CD1 RID: 3281
		private bool fromRestore_;

		// Token: 0x04000CD2 RID: 3282
		public const int HadLuaRuntimeErrorFieldNumber = 10;

		// Token: 0x04000CD3 RID: 3283
		private static readonly bool HadLuaRuntimeErrorDefaultValue = false;

		// Token: 0x04000CD4 RID: 3284
		private bool hadLuaRuntimeError_;

		// Token: 0x04000CD5 RID: 3285
		public const int LuaRuntimeErrorFieldNumber = 11;

		// Token: 0x04000CD6 RID: 3286
		private static readonly string LuaRuntimeErrorDefaultValue = "";

		// Token: 0x04000CD7 RID: 3287
		private string luaRuntimeError_;

		// Token: 0x04000CD8 RID: 3288
		public const int PhaseIsHiddenFieldNumber = 12;

		// Token: 0x04000CD9 RID: 3289
		private static readonly bool PhaseIsHiddenDefaultValue = false;

		// Token: 0x04000CDA RID: 3290
		private bool phaseIsHidden_;

		// Token: 0x04000CDB RID: 3291
		public const int ParamDataFieldNumber = 13;

		// Token: 0x04000CDC RID: 3292
		private static readonly FieldCodec<QuestStateUpdateMessage.Types.CustomParamMessageData> _repeated_paramData_codec = FieldCodec.ForMessage<QuestStateUpdateMessage.Types.CustomParamMessageData>(106U, QuestStateUpdateMessage.Types.CustomParamMessageData.Parser);

		// Token: 0x04000CDD RID: 3293
		private readonly RepeatedField<QuestStateUpdateMessage.Types.CustomParamMessageData> paramData_ = new RepeatedField<QuestStateUpdateMessage.Types.CustomParamMessageData>();

		// Token: 0x04000CDE RID: 3294
		public const int NumParticipantsFieldNumber = 14;

		// Token: 0x04000CDF RID: 3295
		private static readonly uint NumParticipantsDefaultValue = 0U;

		// Token: 0x04000CE0 RID: 3296
		private uint numParticipants_;

		// Token: 0x02000C47 RID: 3143
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200147B RID: 5243
			public enum UpdateType
			{
				// Token: 0x0400A3CF RID: 41935
				[OriginalName("UT_CREATE")]
				UtCreate = 1,
				// Token: 0x0400A3D0 RID: 41936
				[OriginalName("UT_UPDATE")]
				UtUpdate,
				// Token: 0x0400A3D1 RID: 41937
				[OriginalName("UT_COMPLETED")]
				UtCompleted,
				// Token: 0x0400A3D2 RID: 41938
				[OriginalName("UT_DELETE")]
				UtDelete,
				// Token: 0x0400A3D3 RID: 41939
				[OriginalName("UT_WORLD_EVENT_NOTIFY")]
				UtWorldEventNotify,
				// Token: 0x0400A3D4 RID: 41940
				[OriginalName("UT_PARTICIPATING")]
				UtParticipating,
				// Token: 0x0400A3D5 RID: 41941
				[OriginalName("UT_EXIT_RANGE")]
				UtExitRange,
				// Token: 0x0400A3D6 RID: 41942
				[OriginalName("UT_PARTICIPANT_REMOVED")]
				UtParticipantRemoved
			}

			// Token: 0x0200147C RID: 5244
			public enum EventState
			{
				// Token: 0x0400A3D8 RID: 41944
				[OriginalName("ES_NONE")]
				EsNone = 1,
				// Token: 0x0400A3D9 RID: 41945
				[OriginalName("ES_WARMUP")]
				EsWarmup,
				// Token: 0x0400A3DA RID: 41946
				[OriginalName("ES_ACTIVE")]
				EsActive
			}

			// Token: 0x0200147D RID: 5245
			public sealed class CustomParamMessageData : IMessage<QuestStateUpdateMessage.Types.CustomParamMessageData>, IMessage, IEquatable<QuestStateUpdateMessage.Types.CustomParamMessageData>, IDeepCloneable<QuestStateUpdateMessage.Types.CustomParamMessageData>, IBufferMessage
			{
				// Token: 0x17003AA1 RID: 15009
				// (get) Token: 0x0600E641 RID: 58945 RVA: 0x004D7564 File Offset: 0x004D5764
				[DebuggerNonUserCode]
				public static MessageParser<QuestStateUpdateMessage.Types.CustomParamMessageData> Parser
				{
					get
					{
						return QuestStateUpdateMessage.Types.CustomParamMessageData._parser;
					}
				}

				// Token: 0x17003AA2 RID: 15010
				// (get) Token: 0x0600E642 RID: 58946 RVA: 0x004D757C File Offset: 0x004D577C
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestStateUpdateMessage.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003AA3 RID: 15011
				// (get) Token: 0x0600E643 RID: 58947 RVA: 0x004D75A0 File Offset: 0x004D57A0
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestStateUpdateMessage.Types.CustomParamMessageData.Descriptor;
					}
				}

				// Token: 0x0600E644 RID: 58948 RVA: 0x004D75B7 File Offset: 0x004D57B7
				[DebuggerNonUserCode]
				public CustomParamMessageData()
				{
				}

				// Token: 0x0600E645 RID: 58949 RVA: 0x004D75CC File Offset: 0x004D57CC
				[DebuggerNonUserCode]
				public CustomParamMessageData(QuestStateUpdateMessage.Types.CustomParamMessageData other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.paramValue_ = other.paramValue_;
					this.snoActor_ = other.snoActor_;
					this.gbidRareName_ = other.gbidRareName_.Clone();
					this.monsterRarity_ = other.monsterRarity_;
					this.useAltName_ = other.useAltName_;
					this.gizmoType_ = other.gizmoType_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E646 RID: 58950 RVA: 0x004D764C File Offset: 0x004D584C
				[DebuggerNonUserCode]
				public QuestStateUpdateMessage.Types.CustomParamMessageData Clone()
				{
					return new QuestStateUpdateMessage.Types.CustomParamMessageData(this);
				}

				// Token: 0x17003AA4 RID: 15012
				// (get) Token: 0x0600E647 RID: 58951 RVA: 0x004D7664 File Offset: 0x004D5864
				// (set) Token: 0x0600E648 RID: 58952 RVA: 0x004D7695 File Offset: 0x004D5895
				[DebuggerNonUserCode]
				public int ParamValue
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int paramValueDefaultValue;
						if (flag)
						{
							paramValueDefaultValue = this.paramValue_;
						}
						else
						{
							paramValueDefaultValue = QuestStateUpdateMessage.Types.CustomParamMessageData.ParamValueDefaultValue;
						}
						return paramValueDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.paramValue_ = value;
					}
				}

				// Token: 0x17003AA5 RID: 15013
				// (get) Token: 0x0600E649 RID: 58953 RVA: 0x004D76B0 File Offset: 0x004D58B0
				[DebuggerNonUserCode]
				public bool HasParamValue
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E64A RID: 58954 RVA: 0x004D76CD File Offset: 0x004D58CD
				[DebuggerNonUserCode]
				public void ClearParamValue()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003AA6 RID: 15014
				// (get) Token: 0x0600E64B RID: 58955 RVA: 0x004D76E0 File Offset: 0x004D58E0
				// (set) Token: 0x0600E64C RID: 58956 RVA: 0x004D7711 File Offset: 0x004D5911
				[DebuggerNonUserCode]
				public int SnoActor
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int snoActorDefaultValue;
						if (flag)
						{
							snoActorDefaultValue = this.snoActor_;
						}
						else
						{
							snoActorDefaultValue = QuestStateUpdateMessage.Types.CustomParamMessageData.SnoActorDefaultValue;
						}
						return snoActorDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.snoActor_ = value;
					}
				}

				// Token: 0x17003AA7 RID: 15015
				// (get) Token: 0x0600E64D RID: 58957 RVA: 0x004D772C File Offset: 0x004D592C
				[DebuggerNonUserCode]
				public bool HasSnoActor
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E64E RID: 58958 RVA: 0x004D7749 File Offset: 0x004D5949
				[DebuggerNonUserCode]
				public void ClearSnoActor()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003AA8 RID: 15016
				// (get) Token: 0x0600E64F RID: 58959 RVA: 0x004D775C File Offset: 0x004D595C
				[DebuggerNonUserCode]
				public RepeatedField<int> GbidRareName
				{
					get
					{
						return this.gbidRareName_;
					}
				}

				// Token: 0x17003AA9 RID: 15017
				// (get) Token: 0x0600E650 RID: 58960 RVA: 0x004D7774 File Offset: 0x004D5974
				// (set) Token: 0x0600E651 RID: 58961 RVA: 0x004D77A5 File Offset: 0x004D59A5
				[DebuggerNonUserCode]
				public int MonsterRarity
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						int monsterRarityDefaultValue;
						if (flag)
						{
							monsterRarityDefaultValue = this.monsterRarity_;
						}
						else
						{
							monsterRarityDefaultValue = QuestStateUpdateMessage.Types.CustomParamMessageData.MonsterRarityDefaultValue;
						}
						return monsterRarityDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.monsterRarity_ = value;
					}
				}

				// Token: 0x17003AAA RID: 15018
				// (get) Token: 0x0600E652 RID: 58962 RVA: 0x004D77C0 File Offset: 0x004D59C0
				[DebuggerNonUserCode]
				public bool HasMonsterRarity
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E653 RID: 58963 RVA: 0x004D77DD File Offset: 0x004D59DD
				[DebuggerNonUserCode]
				public void ClearMonsterRarity()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003AAB RID: 15019
				// (get) Token: 0x0600E654 RID: 58964 RVA: 0x004D77F0 File Offset: 0x004D59F0
				// (set) Token: 0x0600E655 RID: 58965 RVA: 0x004D7821 File Offset: 0x004D5A21
				[DebuggerNonUserCode]
				public bool UseAltName
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						bool useAltNameDefaultValue;
						if (flag)
						{
							useAltNameDefaultValue = this.useAltName_;
						}
						else
						{
							useAltNameDefaultValue = QuestStateUpdateMessage.Types.CustomParamMessageData.UseAltNameDefaultValue;
						}
						return useAltNameDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.useAltName_ = value;
					}
				}

				// Token: 0x17003AAC RID: 15020
				// (get) Token: 0x0600E656 RID: 58966 RVA: 0x004D783C File Offset: 0x004D5A3C
				[DebuggerNonUserCode]
				public bool HasUseAltName
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E657 RID: 58967 RVA: 0x004D7859 File Offset: 0x004D5A59
				[DebuggerNonUserCode]
				public void ClearUseAltName()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x17003AAD RID: 15021
				// (get) Token: 0x0600E658 RID: 58968 RVA: 0x004D786C File Offset: 0x004D5A6C
				// (set) Token: 0x0600E659 RID: 58969 RVA: 0x004D789E File Offset: 0x004D5A9E
				[DebuggerNonUserCode]
				public int GizmoType
				{
					get
					{
						bool flag = (this._hasBits0 & 16) != 0;
						int gizmoTypeDefaultValue;
						if (flag)
						{
							gizmoTypeDefaultValue = this.gizmoType_;
						}
						else
						{
							gizmoTypeDefaultValue = QuestStateUpdateMessage.Types.CustomParamMessageData.GizmoTypeDefaultValue;
						}
						return gizmoTypeDefaultValue;
					}
					set
					{
						this._hasBits0 |= 16;
						this.gizmoType_ = value;
					}
				}

				// Token: 0x17003AAE RID: 15022
				// (get) Token: 0x0600E65A RID: 58970 RVA: 0x004D78B8 File Offset: 0x004D5AB8
				[DebuggerNonUserCode]
				public bool HasGizmoType
				{
					get
					{
						return (this._hasBits0 & 16) != 0;
					}
				}

				// Token: 0x0600E65B RID: 58971 RVA: 0x004D78D6 File Offset: 0x004D5AD6
				[DebuggerNonUserCode]
				public void ClearGizmoType()
				{
					this._hasBits0 &= -17;
				}

				// Token: 0x0600E65C RID: 58972 RVA: 0x004D78E8 File Offset: 0x004D5AE8
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestStateUpdateMessage.Types.CustomParamMessageData);
				}

				// Token: 0x0600E65D RID: 58973 RVA: 0x004D7908 File Offset: 0x004D5B08
				[DebuggerNonUserCode]
				public bool Equals(QuestStateUpdateMessage.Types.CustomParamMessageData other)
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
							bool flag4 = this.ParamValue != other.ParamValue;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.SnoActor != other.SnoActor;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !this.gbidRareName_.Equals(other.gbidRareName_);
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.MonsterRarity != other.MonsterRarity;
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = this.UseAltName != other.UseAltName;
											if (flag8)
											{
												flag2 = false;
											}
											else
											{
												bool flag9 = this.GizmoType != other.GizmoType;
												flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
											}
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E65E RID: 58974 RVA: 0x004D79F4 File Offset: 0x004D5BF4
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasParamValue = this.HasParamValue;
					if (hasParamValue)
					{
						num ^= this.ParamValue.GetHashCode();
					}
					bool hasSnoActor = this.HasSnoActor;
					if (hasSnoActor)
					{
						num ^= this.SnoActor.GetHashCode();
					}
					num ^= this.gbidRareName_.GetHashCode();
					bool hasMonsterRarity = this.HasMonsterRarity;
					if (hasMonsterRarity)
					{
						num ^= this.MonsterRarity.GetHashCode();
					}
					bool hasUseAltName = this.HasUseAltName;
					if (hasUseAltName)
					{
						num ^= this.UseAltName.GetHashCode();
					}
					bool hasGizmoType = this.HasGizmoType;
					if (hasGizmoType)
					{
						num ^= this.GizmoType.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E65F RID: 58975 RVA: 0x004D7AC8 File Offset: 0x004D5CC8
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E660 RID: 58976 RVA: 0x004D7AE0 File Offset: 0x004D5CE0
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E661 RID: 58977 RVA: 0x004D7AEC File Offset: 0x004D5CEC
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasParamValue = this.HasParamValue;
					if (hasParamValue)
					{
						output.WriteRawTag(8);
						output.WriteInt32(this.ParamValue);
					}
					bool hasSnoActor = this.HasSnoActor;
					if (hasSnoActor)
					{
						output.WriteRawTag(16);
						output.WriteInt32(this.SnoActor);
					}
					this.gbidRareName_.WriteTo(ref output, QuestStateUpdateMessage.Types.CustomParamMessageData._repeated_gbidRareName_codec);
					bool hasMonsterRarity = this.HasMonsterRarity;
					if (hasMonsterRarity)
					{
						output.WriteRawTag(32);
						output.WriteInt32(this.MonsterRarity);
					}
					bool hasUseAltName = this.HasUseAltName;
					if (hasUseAltName)
					{
						output.WriteRawTag(40);
						output.WriteBool(this.UseAltName);
					}
					bool hasGizmoType = this.HasGizmoType;
					if (hasGizmoType)
					{
						output.WriteRawTag(48);
						output.WriteInt32(this.GizmoType);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E662 RID: 58978 RVA: 0x004D7BD8 File Offset: 0x004D5DD8
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasParamValue = this.HasParamValue;
					if (hasParamValue)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.ParamValue);
					}
					bool hasSnoActor = this.HasSnoActor;
					if (hasSnoActor)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoActor);
					}
					num += this.gbidRareName_.CalculateSize(QuestStateUpdateMessage.Types.CustomParamMessageData._repeated_gbidRareName_codec);
					bool hasMonsterRarity = this.HasMonsterRarity;
					if (hasMonsterRarity)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterRarity);
					}
					bool hasUseAltName = this.HasUseAltName;
					if (hasUseAltName)
					{
						num += 2;
					}
					bool hasGizmoType = this.HasGizmoType;
					if (hasGizmoType)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.GizmoType);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E663 RID: 58979 RVA: 0x004D7CA8 File Offset: 0x004D5EA8
				[DebuggerNonUserCode]
				public void MergeFrom(QuestStateUpdateMessage.Types.CustomParamMessageData other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasParamValue = other.HasParamValue;
						if (hasParamValue)
						{
							this.ParamValue = other.ParamValue;
						}
						bool hasSnoActor = other.HasSnoActor;
						if (hasSnoActor)
						{
							this.SnoActor = other.SnoActor;
						}
						this.gbidRareName_.Add(other.gbidRareName_);
						bool hasMonsterRarity = other.HasMonsterRarity;
						if (hasMonsterRarity)
						{
							this.MonsterRarity = other.MonsterRarity;
						}
						bool hasUseAltName = other.HasUseAltName;
						if (hasUseAltName)
						{
							this.UseAltName = other.UseAltName;
						}
						bool hasGizmoType = other.HasGizmoType;
						if (hasGizmoType)
						{
							this.GizmoType = other.GizmoType;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E664 RID: 58980 RVA: 0x004D7D6E File Offset: 0x004D5F6E
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E665 RID: 58981 RVA: 0x004D7D7C File Offset: 0x004D5F7C
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 26U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									if (num3 != 26U)
									{
										goto IL_0045;
									}
									goto IL_0079;
								}
								else
								{
									this.SnoActor = input.ReadInt32();
								}
							}
							else
							{
								this.ParamValue = input.ReadInt32();
							}
						}
						else if (num3 <= 32U)
						{
							if (num3 == 29U)
							{
								goto IL_0079;
							}
							if (num3 != 32U)
							{
								goto IL_0045;
							}
							this.MonsterRarity = input.ReadInt32();
						}
						else if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_0045;
							}
							this.GizmoType = input.ReadInt32();
						}
						else
						{
							this.UseAltName = input.ReadBool();
						}
						continue;
						IL_0045:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						continue;
						IL_0079:
						this.gbidRareName_.AddEntriesFrom(ref input, QuestStateUpdateMessage.Types.CustomParamMessageData._repeated_gbidRareName_codec);
					}
				}

				// Token: 0x0400A3DB RID: 41947
				private static readonly MessageParser<QuestStateUpdateMessage.Types.CustomParamMessageData> _parser = new MessageParser<QuestStateUpdateMessage.Types.CustomParamMessageData>(() => new QuestStateUpdateMessage.Types.CustomParamMessageData());

				// Token: 0x0400A3DC RID: 41948
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A3DD RID: 41949
				private int _hasBits0;

				// Token: 0x0400A3DE RID: 41950
				public const int ParamValueFieldNumber = 1;

				// Token: 0x0400A3DF RID: 41951
				private static readonly int ParamValueDefaultValue = 0;

				// Token: 0x0400A3E0 RID: 41952
				private int paramValue_;

				// Token: 0x0400A3E1 RID: 41953
				public const int SnoActorFieldNumber = 2;

				// Token: 0x0400A3E2 RID: 41954
				private static readonly int SnoActorDefaultValue = -1;

				// Token: 0x0400A3E3 RID: 41955
				private int snoActor_;

				// Token: 0x0400A3E4 RID: 41956
				public const int GbidRareNameFieldNumber = 3;

				// Token: 0x0400A3E5 RID: 41957
				private static readonly FieldCodec<int> _repeated_gbidRareName_codec = FieldCodec.ForSFixed32(29U);

				// Token: 0x0400A3E6 RID: 41958
				private readonly RepeatedField<int> gbidRareName_ = new RepeatedField<int>();

				// Token: 0x0400A3E7 RID: 41959
				public const int MonsterRarityFieldNumber = 4;

				// Token: 0x0400A3E8 RID: 41960
				private static readonly int MonsterRarityDefaultValue = 0;

				// Token: 0x0400A3E9 RID: 41961
				private int monsterRarity_;

				// Token: 0x0400A3EA RID: 41962
				public const int UseAltNameFieldNumber = 5;

				// Token: 0x0400A3EB RID: 41963
				private static readonly bool UseAltNameDefaultValue = false;

				// Token: 0x0400A3EC RID: 41964
				private bool useAltName_;

				// Token: 0x0400A3ED RID: 41965
				public const int GizmoTypeFieldNumber = 6;

				// Token: 0x0400A3EE RID: 41966
				private static readonly int GizmoTypeDefaultValue = 0;

				// Token: 0x0400A3EF RID: 41967
				private int gizmoType_;
			}
		}
	}
}
