using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000BD RID: 189
	public sealed class QuestChangeList : IMessage<QuestChangeList>, IMessage, IEquatable<QuestChangeList>, IDeepCloneable<QuestChangeList>, IBufferMessage
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00040E30 File Offset: 0x0003F030
		[DebuggerNonUserCode]
		public static MessageParser<QuestChangeList> Parser
		{
			get
			{
				return QuestChangeList._parser;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00040E48 File Offset: 0x0003F048
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[166];
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00040E70 File Offset: 0x0003F070
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestChangeList.Descriptor;
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00040E87 File Offset: 0x0003F087
		[DebuggerNonUserCode]
		public QuestChangeList()
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00040E94 File Offset: 0x0003F094
		[DebuggerNonUserCode]
		public QuestChangeList(QuestChangeList other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.rootChanges_ = ((other.rootChanges_ != null) ? other.rootChanges_.Clone() : null);
			this.phaseChanges_ = ((other.phaseChanges_ != null) ? other.phaseChanges_.Clone() : null);
			this.objectivesetChanges_ = ((other.objectivesetChanges_ != null) ? other.objectivesetChanges_.Clone() : null);
			this.callbackChanges_ = ((other.callbackChanges_ != null) ? other.callbackChanges_.Clone() : null);
			this.startPhaseChanged_ = other.startPhaseChanged_;
			this.endPhaseChanged_ = other.endPhaseChanged_;
			this.backgroundPhaseChanged_ = other.backgroundPhaseChanged_;
			this.scriptChanged_ = other.scriptChanged_;
			this.questSno_ = other.questSno_;
			this.unassignedPhaseChanged_ = other.unassignedPhaseChanged_;
			this.bonusPhaseChanged_ = other.bonusPhaseChanged_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00040F8C File Offset: 0x0003F18C
		[DebuggerNonUserCode]
		public QuestChangeList Clone()
		{
			return new QuestChangeList(this);
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00040FA4 File Offset: 0x0003F1A4
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x00040FBC File Offset: 0x0003F1BC
		[DebuggerNonUserCode]
		public QuestChangeList.Types.RootChanges RootChanges
		{
			get
			{
				return this.rootChanges_;
			}
			set
			{
				this.rootChanges_ = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00040FC8 File Offset: 0x0003F1C8
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		[DebuggerNonUserCode]
		public QuestChangeList.Types.PhaseChanges PhaseChanges
		{
			get
			{
				return this.phaseChanges_;
			}
			set
			{
				this.phaseChanges_ = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00040FEC File Offset: 0x0003F1EC
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x00041004 File Offset: 0x0003F204
		[DebuggerNonUserCode]
		public QuestChangeList.Types.ObjectiveSetChanges ObjectivesetChanges
		{
			get
			{
				return this.objectivesetChanges_;
			}
			set
			{
				this.objectivesetChanges_ = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00041010 File Offset: 0x0003F210
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x00041028 File Offset: 0x0003F228
		[DebuggerNonUserCode]
		public QuestChangeList.Types.CallbackChanges CallbackChanges
		{
			get
			{
				return this.callbackChanges_;
			}
			set
			{
				this.callbackChanges_ = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00041034 File Offset: 0x0003F234
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x00041065 File Offset: 0x0003F265
		[DebuggerNonUserCode]
		public bool StartPhaseChanged
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool startPhaseChangedDefaultValue;
				if (flag)
				{
					startPhaseChangedDefaultValue = this.startPhaseChanged_;
				}
				else
				{
					startPhaseChangedDefaultValue = QuestChangeList.StartPhaseChangedDefaultValue;
				}
				return startPhaseChangedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startPhaseChanged_ = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00041080 File Offset: 0x0003F280
		[DebuggerNonUserCode]
		public bool HasStartPhaseChanged
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0004109D File Offset: 0x0003F29D
		[DebuggerNonUserCode]
		public void ClearStartPhaseChanged()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x000410B0 File Offset: 0x0003F2B0
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x000410E1 File Offset: 0x0003F2E1
		[DebuggerNonUserCode]
		public bool EndPhaseChanged
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool endPhaseChangedDefaultValue;
				if (flag)
				{
					endPhaseChangedDefaultValue = this.endPhaseChanged_;
				}
				else
				{
					endPhaseChangedDefaultValue = QuestChangeList.EndPhaseChangedDefaultValue;
				}
				return endPhaseChangedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.endPhaseChanged_ = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x000410FC File Offset: 0x0003F2FC
		[DebuggerNonUserCode]
		public bool HasEndPhaseChanged
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00041119 File Offset: 0x0003F319
		[DebuggerNonUserCode]
		public void ClearEndPhaseChanged()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0004112C File Offset: 0x0003F32C
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x0004115D File Offset: 0x0003F35D
		[DebuggerNonUserCode]
		public bool BackgroundPhaseChanged
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool backgroundPhaseChangedDefaultValue;
				if (flag)
				{
					backgroundPhaseChangedDefaultValue = this.backgroundPhaseChanged_;
				}
				else
				{
					backgroundPhaseChangedDefaultValue = QuestChangeList.BackgroundPhaseChangedDefaultValue;
				}
				return backgroundPhaseChangedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.backgroundPhaseChanged_ = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00041178 File Offset: 0x0003F378
		[DebuggerNonUserCode]
		public bool HasBackgroundPhaseChanged
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00041195 File Offset: 0x0003F395
		[DebuggerNonUserCode]
		public void ClearBackgroundPhaseChanged()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000411A8 File Offset: 0x0003F3A8
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x000411D9 File Offset: 0x0003F3D9
		[DebuggerNonUserCode]
		public bool ScriptChanged
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool scriptChangedDefaultValue;
				if (flag)
				{
					scriptChangedDefaultValue = this.scriptChanged_;
				}
				else
				{
					scriptChangedDefaultValue = QuestChangeList.ScriptChangedDefaultValue;
				}
				return scriptChangedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.scriptChanged_ = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x000411F4 File Offset: 0x0003F3F4
		[DebuggerNonUserCode]
		public bool HasScriptChanged
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00041211 File Offset: 0x0003F411
		[DebuggerNonUserCode]
		public void ClearScriptChanged()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00041224 File Offset: 0x0003F424
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00041256 File Offset: 0x0003F456
		[DebuggerNonUserCode]
		public int QuestSno
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int questSnoDefaultValue;
				if (flag)
				{
					questSnoDefaultValue = this.questSno_;
				}
				else
				{
					questSnoDefaultValue = QuestChangeList.QuestSnoDefaultValue;
				}
				return questSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.questSno_ = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00041270 File Offset: 0x0003F470
		[DebuggerNonUserCode]
		public bool HasQuestSno
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0004128E File Offset: 0x0003F48E
		[DebuggerNonUserCode]
		public void ClearQuestSno()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x000412A0 File Offset: 0x0003F4A0
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x000412D2 File Offset: 0x0003F4D2
		[DebuggerNonUserCode]
		public bool UnassignedPhaseChanged
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool unassignedPhaseChangedDefaultValue;
				if (flag)
				{
					unassignedPhaseChangedDefaultValue = this.unassignedPhaseChanged_;
				}
				else
				{
					unassignedPhaseChangedDefaultValue = QuestChangeList.UnassignedPhaseChangedDefaultValue;
				}
				return unassignedPhaseChangedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.unassignedPhaseChanged_ = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x000412EC File Offset: 0x0003F4EC
		[DebuggerNonUserCode]
		public bool HasUnassignedPhaseChanged
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0004130A File Offset: 0x0003F50A
		[DebuggerNonUserCode]
		public void ClearUnassignedPhaseChanged()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0004131C File Offset: 0x0003F51C
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x0004134E File Offset: 0x0003F54E
		[DebuggerNonUserCode]
		public bool BonusPhaseChanged
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool bonusPhaseChangedDefaultValue;
				if (flag)
				{
					bonusPhaseChangedDefaultValue = this.bonusPhaseChanged_;
				}
				else
				{
					bonusPhaseChangedDefaultValue = QuestChangeList.BonusPhaseChangedDefaultValue;
				}
				return bonusPhaseChangedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.bonusPhaseChanged_ = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00041368 File Offset: 0x0003F568
		[DebuggerNonUserCode]
		public bool HasBonusPhaseChanged
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00041386 File Offset: 0x0003F586
		[DebuggerNonUserCode]
		public void ClearBonusPhaseChanged()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00041398 File Offset: 0x0003F598
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestChangeList);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000413B8 File Offset: 0x0003F5B8
		[DebuggerNonUserCode]
		public bool Equals(QuestChangeList other)
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
					bool flag4 = !object.Equals(this.RootChanges, other.RootChanges);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.PhaseChanges, other.PhaseChanges);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ObjectivesetChanges, other.ObjectivesetChanges);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.CallbackChanges, other.CallbackChanges);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.StartPhaseChanged != other.StartPhaseChanged;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.EndPhaseChanged != other.EndPhaseChanged;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.BackgroundPhaseChanged != other.BackgroundPhaseChanged;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ScriptChanged != other.ScriptChanged;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.QuestSno != other.QuestSno;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.UnassignedPhaseChanged != other.UnassignedPhaseChanged;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.BonusPhaseChanged != other.BonusPhaseChanged;
															flag2 = !flag14 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060011E4 RID: 4580 RVA: 0x00041544 File Offset: 0x0003F744
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.rootChanges_ != null;
			if (flag)
			{
				num ^= this.RootChanges.GetHashCode();
			}
			bool flag2 = this.phaseChanges_ != null;
			if (flag2)
			{
				num ^= this.PhaseChanges.GetHashCode();
			}
			bool flag3 = this.objectivesetChanges_ != null;
			if (flag3)
			{
				num ^= this.ObjectivesetChanges.GetHashCode();
			}
			bool flag4 = this.callbackChanges_ != null;
			if (flag4)
			{
				num ^= this.CallbackChanges.GetHashCode();
			}
			bool hasStartPhaseChanged = this.HasStartPhaseChanged;
			if (hasStartPhaseChanged)
			{
				num ^= this.StartPhaseChanged.GetHashCode();
			}
			bool hasEndPhaseChanged = this.HasEndPhaseChanged;
			if (hasEndPhaseChanged)
			{
				num ^= this.EndPhaseChanged.GetHashCode();
			}
			bool hasBackgroundPhaseChanged = this.HasBackgroundPhaseChanged;
			if (hasBackgroundPhaseChanged)
			{
				num ^= this.BackgroundPhaseChanged.GetHashCode();
			}
			bool hasScriptChanged = this.HasScriptChanged;
			if (hasScriptChanged)
			{
				num ^= this.ScriptChanged.GetHashCode();
			}
			bool hasQuestSno = this.HasQuestSno;
			if (hasQuestSno)
			{
				num ^= this.QuestSno.GetHashCode();
			}
			bool hasUnassignedPhaseChanged = this.HasUnassignedPhaseChanged;
			if (hasUnassignedPhaseChanged)
			{
				num ^= this.UnassignedPhaseChanged.GetHashCode();
			}
			bool hasBonusPhaseChanged = this.HasBonusPhaseChanged;
			if (hasBonusPhaseChanged)
			{
				num ^= this.BonusPhaseChanged.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000416BC File Offset: 0x0003F8BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000416D4 File Offset: 0x0003F8D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000416E0 File Offset: 0x0003F8E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.rootChanges_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RootChanges);
			}
			bool flag2 = this.phaseChanges_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhaseChanges);
			}
			bool flag3 = this.objectivesetChanges_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ObjectivesetChanges);
			}
			bool hasStartPhaseChanged = this.HasStartPhaseChanged;
			if (hasStartPhaseChanged)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.StartPhaseChanged);
			}
			bool hasEndPhaseChanged = this.HasEndPhaseChanged;
			if (hasEndPhaseChanged)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.EndPhaseChanged);
			}
			bool hasBackgroundPhaseChanged = this.HasBackgroundPhaseChanged;
			if (hasBackgroundPhaseChanged)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.BackgroundPhaseChanged);
			}
			bool hasScriptChanged = this.HasScriptChanged;
			if (hasScriptChanged)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ScriptChanged);
			}
			bool flag4 = this.callbackChanges_ != null;
			if (flag4)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CallbackChanges);
			}
			bool hasQuestSno = this.HasQuestSno;
			if (hasQuestSno)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.QuestSno);
			}
			bool hasUnassignedPhaseChanged = this.HasUnassignedPhaseChanged;
			if (hasUnassignedPhaseChanged)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.UnassignedPhaseChanged);
			}
			bool hasBonusPhaseChanged = this.HasBonusPhaseChanged;
			if (hasBonusPhaseChanged)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.BonusPhaseChanged);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0004189C File Offset: 0x0003FA9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.rootChanges_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RootChanges);
			}
			bool flag2 = this.phaseChanges_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhaseChanges);
			}
			bool flag3 = this.objectivesetChanges_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ObjectivesetChanges);
			}
			bool flag4 = this.callbackChanges_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CallbackChanges);
			}
			bool hasStartPhaseChanged = this.HasStartPhaseChanged;
			if (hasStartPhaseChanged)
			{
				num += 2;
			}
			bool hasEndPhaseChanged = this.HasEndPhaseChanged;
			if (hasEndPhaseChanged)
			{
				num += 2;
			}
			bool hasBackgroundPhaseChanged = this.HasBackgroundPhaseChanged;
			if (hasBackgroundPhaseChanged)
			{
				num += 2;
			}
			bool hasScriptChanged = this.HasScriptChanged;
			if (hasScriptChanged)
			{
				num += 2;
			}
			bool hasQuestSno = this.HasQuestSno;
			if (hasQuestSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestSno);
			}
			bool hasUnassignedPhaseChanged = this.HasUnassignedPhaseChanged;
			if (hasUnassignedPhaseChanged)
			{
				num += 2;
			}
			bool hasBonusPhaseChanged = this.HasBonusPhaseChanged;
			if (hasBonusPhaseChanged)
			{
				num += 2;
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000419DC File Offset: 0x0003FBDC
		[DebuggerNonUserCode]
		public void MergeFrom(QuestChangeList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.rootChanges_ != null;
				if (flag2)
				{
					bool flag3 = this.rootChanges_ == null;
					if (flag3)
					{
						this.RootChanges = new QuestChangeList.Types.RootChanges();
					}
					this.RootChanges.MergeFrom(other.RootChanges);
				}
				bool flag4 = other.phaseChanges_ != null;
				if (flag4)
				{
					bool flag5 = this.phaseChanges_ == null;
					if (flag5)
					{
						this.PhaseChanges = new QuestChangeList.Types.PhaseChanges();
					}
					this.PhaseChanges.MergeFrom(other.PhaseChanges);
				}
				bool flag6 = other.objectivesetChanges_ != null;
				if (flag6)
				{
					bool flag7 = this.objectivesetChanges_ == null;
					if (flag7)
					{
						this.ObjectivesetChanges = new QuestChangeList.Types.ObjectiveSetChanges();
					}
					this.ObjectivesetChanges.MergeFrom(other.ObjectivesetChanges);
				}
				bool flag8 = other.callbackChanges_ != null;
				if (flag8)
				{
					bool flag9 = this.callbackChanges_ == null;
					if (flag9)
					{
						this.CallbackChanges = new QuestChangeList.Types.CallbackChanges();
					}
					this.CallbackChanges.MergeFrom(other.CallbackChanges);
				}
				bool hasStartPhaseChanged = other.HasStartPhaseChanged;
				if (hasStartPhaseChanged)
				{
					this.StartPhaseChanged = other.StartPhaseChanged;
				}
				bool hasEndPhaseChanged = other.HasEndPhaseChanged;
				if (hasEndPhaseChanged)
				{
					this.EndPhaseChanged = other.EndPhaseChanged;
				}
				bool hasBackgroundPhaseChanged = other.HasBackgroundPhaseChanged;
				if (hasBackgroundPhaseChanged)
				{
					this.BackgroundPhaseChanged = other.BackgroundPhaseChanged;
				}
				bool hasScriptChanged = other.HasScriptChanged;
				if (hasScriptChanged)
				{
					this.ScriptChanged = other.ScriptChanged;
				}
				bool hasQuestSno = other.HasQuestSno;
				if (hasQuestSno)
				{
					this.QuestSno = other.QuestSno;
				}
				bool hasUnassignedPhaseChanged = other.HasUnassignedPhaseChanged;
				if (hasUnassignedPhaseChanged)
				{
					this.UnassignedPhaseChanged = other.UnassignedPhaseChanged;
				}
				bool hasBonusPhaseChanged = other.HasBonusPhaseChanged;
				if (hasBonusPhaseChanged)
				{
					this.BonusPhaseChanged = other.BonusPhaseChanged;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00041BC6 File Offset: 0x0003FDC6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00041BD4 File Offset: 0x0003FDD4
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
								goto IL_0088;
							}
							bool flag = this.phaseChanges_ == null;
							if (flag)
							{
								this.PhaseChanges = new QuestChangeList.Types.PhaseChanges();
							}
							input.ReadMessage(this.PhaseChanges);
						}
						else
						{
							bool flag2 = this.rootChanges_ == null;
							if (flag2)
							{
								this.RootChanges = new QuestChangeList.Types.RootChanges();
							}
							input.ReadMessage(this.RootChanges);
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_0088;
							}
							this.EndPhaseChanged = input.ReadBool();
						}
						else
						{
							this.StartPhaseChanged = input.ReadBool();
						}
					}
					else
					{
						bool flag3 = this.objectivesetChanges_ == null;
						if (flag3)
						{
							this.ObjectivesetChanges = new QuestChangeList.Types.ObjectiveSetChanges();
						}
						input.ReadMessage(this.ObjectivesetChanges);
					}
				}
				else if (num3 <= 66U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							if (num3 != 66U)
							{
								goto IL_0088;
							}
							bool flag4 = this.callbackChanges_ == null;
							if (flag4)
							{
								this.CallbackChanges = new QuestChangeList.Types.CallbackChanges();
							}
							input.ReadMessage(this.CallbackChanges);
						}
						else
						{
							this.ScriptChanged = input.ReadBool();
						}
					}
					else
					{
						this.BackgroundPhaseChanged = input.ReadBool();
					}
				}
				else if (num3 != 72U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_0088;
						}
						this.BonusPhaseChanged = input.ReadBool();
					}
					else
					{
						this.UnassignedPhaseChanged = input.ReadBool();
					}
				}
				else
				{
					this.QuestSno = input.ReadInt32();
				}
				continue;
				IL_0088:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000716 RID: 1814
		private static readonly MessageParser<QuestChangeList> _parser = new MessageParser<QuestChangeList>(() => new QuestChangeList());

		// Token: 0x04000717 RID: 1815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000718 RID: 1816
		private int _hasBits0;

		// Token: 0x04000719 RID: 1817
		public const int RootChangesFieldNumber = 1;

		// Token: 0x0400071A RID: 1818
		private QuestChangeList.Types.RootChanges rootChanges_;

		// Token: 0x0400071B RID: 1819
		public const int PhaseChangesFieldNumber = 2;

		// Token: 0x0400071C RID: 1820
		private QuestChangeList.Types.PhaseChanges phaseChanges_;

		// Token: 0x0400071D RID: 1821
		public const int ObjectivesetChangesFieldNumber = 3;

		// Token: 0x0400071E RID: 1822
		private QuestChangeList.Types.ObjectiveSetChanges objectivesetChanges_;

		// Token: 0x0400071F RID: 1823
		public const int CallbackChangesFieldNumber = 8;

		// Token: 0x04000720 RID: 1824
		private QuestChangeList.Types.CallbackChanges callbackChanges_;

		// Token: 0x04000721 RID: 1825
		public const int StartPhaseChangedFieldNumber = 4;

		// Token: 0x04000722 RID: 1826
		private static readonly bool StartPhaseChangedDefaultValue = false;

		// Token: 0x04000723 RID: 1827
		private bool startPhaseChanged_;

		// Token: 0x04000724 RID: 1828
		public const int EndPhaseChangedFieldNumber = 5;

		// Token: 0x04000725 RID: 1829
		private static readonly bool EndPhaseChangedDefaultValue = false;

		// Token: 0x04000726 RID: 1830
		private bool endPhaseChanged_;

		// Token: 0x04000727 RID: 1831
		public const int BackgroundPhaseChangedFieldNumber = 6;

		// Token: 0x04000728 RID: 1832
		private static readonly bool BackgroundPhaseChangedDefaultValue = false;

		// Token: 0x04000729 RID: 1833
		private bool backgroundPhaseChanged_;

		// Token: 0x0400072A RID: 1834
		public const int ScriptChangedFieldNumber = 7;

		// Token: 0x0400072B RID: 1835
		private static readonly bool ScriptChangedDefaultValue = false;

		// Token: 0x0400072C RID: 1836
		private bool scriptChanged_;

		// Token: 0x0400072D RID: 1837
		public const int QuestSnoFieldNumber = 9;

		// Token: 0x0400072E RID: 1838
		private static readonly int QuestSnoDefaultValue = 0;

		// Token: 0x0400072F RID: 1839
		private int questSno_;

		// Token: 0x04000730 RID: 1840
		public const int UnassignedPhaseChangedFieldNumber = 10;

		// Token: 0x04000731 RID: 1841
		private static readonly bool UnassignedPhaseChangedDefaultValue = false;

		// Token: 0x04000732 RID: 1842
		private bool unassignedPhaseChanged_;

		// Token: 0x04000733 RID: 1843
		public const int BonusPhaseChangedFieldNumber = 11;

		// Token: 0x04000734 RID: 1844
		private static readonly bool BonusPhaseChangedDefaultValue = false;

		// Token: 0x04000735 RID: 1845
		private bool bonusPhaseChanged_;

		// Token: 0x02000BD5 RID: 3029
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001462 RID: 5218
			public sealed class IdFieldPair : IMessage<QuestChangeList.Types.IdFieldPair>, IMessage, IEquatable<QuestChangeList.Types.IdFieldPair>, IDeepCloneable<QuestChangeList.Types.IdFieldPair>, IBufferMessage
			{
				// Token: 0x170039E8 RID: 14824
				// (get) Token: 0x0600E3F6 RID: 58358 RVA: 0x004CF3A0 File Offset: 0x004CD5A0
				[DebuggerNonUserCode]
				public static MessageParser<QuestChangeList.Types.IdFieldPair> Parser
				{
					get
					{
						return QuestChangeList.Types.IdFieldPair._parser;
					}
				}

				// Token: 0x170039E9 RID: 14825
				// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x004CF3B8 File Offset: 0x004CD5B8
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestChangeList.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x170039EA RID: 14826
				// (get) Token: 0x0600E3F8 RID: 58360 RVA: 0x004CF3DC File Offset: 0x004CD5DC
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestChangeList.Types.IdFieldPair.Descriptor;
					}
				}

				// Token: 0x0600E3F9 RID: 58361 RVA: 0x004CF3F3 File Offset: 0x004CD5F3
				[DebuggerNonUserCode]
				public IdFieldPair()
				{
				}

				// Token: 0x0600E3FA RID: 58362 RVA: 0x004CF3FD File Offset: 0x004CD5FD
				[DebuggerNonUserCode]
				public IdFieldPair(QuestChangeList.Types.IdFieldPair other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.uid_ = other.uid_;
					this.fieldName_ = other.fieldName_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E3FB RID: 58363 RVA: 0x004CF43C File Offset: 0x004CD63C
				[DebuggerNonUserCode]
				public QuestChangeList.Types.IdFieldPair Clone()
				{
					return new QuestChangeList.Types.IdFieldPair(this);
				}

				// Token: 0x170039EB RID: 14827
				// (get) Token: 0x0600E3FC RID: 58364 RVA: 0x004CF454 File Offset: 0x004CD654
				// (set) Token: 0x0600E3FD RID: 58365 RVA: 0x004CF485 File Offset: 0x004CD685
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
							uidDefaultValue = QuestChangeList.Types.IdFieldPair.UidDefaultValue;
						}
						return uidDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.uid_ = value;
					}
				}

				// Token: 0x170039EC RID: 14828
				// (get) Token: 0x0600E3FE RID: 58366 RVA: 0x004CF4A0 File Offset: 0x004CD6A0
				[DebuggerNonUserCode]
				public bool HasUid
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E3FF RID: 58367 RVA: 0x004CF4BD File Offset: 0x004CD6BD
				[DebuggerNonUserCode]
				public void ClearUid()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x170039ED RID: 14829
				// (get) Token: 0x0600E400 RID: 58368 RVA: 0x004CF4D0 File Offset: 0x004CD6D0
				// (set) Token: 0x0600E401 RID: 58369 RVA: 0x004CF4F1 File Offset: 0x004CD6F1
				[DebuggerNonUserCode]
				public string FieldName
				{
					get
					{
						return this.fieldName_ ?? QuestChangeList.Types.IdFieldPair.FieldNameDefaultValue;
					}
					set
					{
						this.fieldName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
					}
				}

				// Token: 0x170039EE RID: 14830
				// (get) Token: 0x0600E402 RID: 58370 RVA: 0x004CF508 File Offset: 0x004CD708
				[DebuggerNonUserCode]
				public bool HasFieldName
				{
					get
					{
						return this.fieldName_ != null;
					}
				}

				// Token: 0x0600E403 RID: 58371 RVA: 0x004CF523 File Offset: 0x004CD723
				[DebuggerNonUserCode]
				public void ClearFieldName()
				{
					this.fieldName_ = null;
				}

				// Token: 0x0600E404 RID: 58372 RVA: 0x004CF530 File Offset: 0x004CD730
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestChangeList.Types.IdFieldPair);
				}

				// Token: 0x0600E405 RID: 58373 RVA: 0x004CF550 File Offset: 0x004CD750
				[DebuggerNonUserCode]
				public bool Equals(QuestChangeList.Types.IdFieldPair other)
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
								bool flag5 = this.FieldName != other.FieldName;
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E406 RID: 58374 RVA: 0x004CF5C4 File Offset: 0x004CD7C4
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						num ^= this.Uid.GetHashCode();
					}
					bool hasFieldName = this.HasFieldName;
					if (hasFieldName)
					{
						num ^= this.FieldName.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E407 RID: 58375 RVA: 0x004CF630 File Offset: 0x004CD830
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E408 RID: 58376 RVA: 0x004CF648 File Offset: 0x004CD848
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E409 RID: 58377 RVA: 0x004CF654 File Offset: 0x004CD854
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.Uid);
					}
					bool hasFieldName = this.HasFieldName;
					if (hasFieldName)
					{
						output.WriteRawTag(18);
						output.WriteString(this.FieldName);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E40A RID: 58378 RVA: 0x004CF6C4 File Offset: 0x004CD8C4
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasUid = this.HasUid;
					if (hasUid)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
					}
					bool hasFieldName = this.HasFieldName;
					if (hasFieldName)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(this.FieldName);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E40B RID: 58379 RVA: 0x004CF730 File Offset: 0x004CD930
				[DebuggerNonUserCode]
				public void MergeFrom(QuestChangeList.Types.IdFieldPair other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasUid = other.HasUid;
						if (hasUid)
						{
							this.Uid = other.Uid;
						}
						bool hasFieldName = other.HasFieldName;
						if (hasFieldName)
						{
							this.FieldName = other.FieldName;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E40C RID: 58380 RVA: 0x004CF792 File Offset: 0x004CD992
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E40D RID: 58381 RVA: 0x004CF7A0 File Offset: 0x004CD9A0
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
								this.FieldName = input.ReadString();
							}
						}
						else
						{
							this.Uid = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A28F RID: 41615
				private static readonly MessageParser<QuestChangeList.Types.IdFieldPair> _parser = new MessageParser<QuestChangeList.Types.IdFieldPair>(() => new QuestChangeList.Types.IdFieldPair());

				// Token: 0x0400A290 RID: 41616
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A291 RID: 41617
				private int _hasBits0;

				// Token: 0x0400A292 RID: 41618
				public const int UidFieldNumber = 1;

				// Token: 0x0400A293 RID: 41619
				private static readonly uint UidDefaultValue = 0U;

				// Token: 0x0400A294 RID: 41620
				private uint uid_;

				// Token: 0x0400A295 RID: 41621
				public const int FieldNameFieldNumber = 2;

				// Token: 0x0400A296 RID: 41622
				private static readonly string FieldNameDefaultValue = "";

				// Token: 0x0400A297 RID: 41623
				private string fieldName_;
			}

			// Token: 0x02001463 RID: 5219
			public sealed class RootChanges : IMessage<QuestChangeList.Types.RootChanges>, IMessage, IEquatable<QuestChangeList.Types.RootChanges>, IDeepCloneable<QuestChangeList.Types.RootChanges>, IBufferMessage
			{
				// Token: 0x170039EF RID: 14831
				// (get) Token: 0x0600E40F RID: 58383 RVA: 0x004CF834 File Offset: 0x004CDA34
				[DebuggerNonUserCode]
				public static MessageParser<QuestChangeList.Types.RootChanges> Parser
				{
					get
					{
						return QuestChangeList.Types.RootChanges._parser;
					}
				}

				// Token: 0x170039F0 RID: 14832
				// (get) Token: 0x0600E410 RID: 58384 RVA: 0x004CF84C File Offset: 0x004CDA4C
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestChangeList.Descriptor.NestedTypes[1];
					}
				}

				// Token: 0x170039F1 RID: 14833
				// (get) Token: 0x0600E411 RID: 58385 RVA: 0x004CF870 File Offset: 0x004CDA70
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestChangeList.Types.RootChanges.Descriptor;
					}
				}

				// Token: 0x0600E412 RID: 58386 RVA: 0x004CF887 File Offset: 0x004CDA87
				[DebuggerNonUserCode]
				public RootChanges()
				{
				}

				// Token: 0x0600E413 RID: 58387 RVA: 0x004CF89C File Offset: 0x004CDA9C
				[DebuggerNonUserCode]
				public RootChanges(QuestChangeList.Types.RootChanges other)
					: this()
				{
					this.fieldName_ = other.fieldName_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E414 RID: 58388 RVA: 0x004CF8C8 File Offset: 0x004CDAC8
				[DebuggerNonUserCode]
				public QuestChangeList.Types.RootChanges Clone()
				{
					return new QuestChangeList.Types.RootChanges(this);
				}

				// Token: 0x170039F2 RID: 14834
				// (get) Token: 0x0600E415 RID: 58389 RVA: 0x004CF8E0 File Offset: 0x004CDAE0
				[DebuggerNonUserCode]
				public RepeatedField<string> FieldName
				{
					get
					{
						return this.fieldName_;
					}
				}

				// Token: 0x0600E416 RID: 58390 RVA: 0x004CF8F8 File Offset: 0x004CDAF8
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestChangeList.Types.RootChanges);
				}

				// Token: 0x0600E417 RID: 58391 RVA: 0x004CF918 File Offset: 0x004CDB18
				[DebuggerNonUserCode]
				public bool Equals(QuestChangeList.Types.RootChanges other)
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
							bool flag4 = !this.fieldName_.Equals(other.fieldName_);
							flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
					return flag2;
				}

				// Token: 0x0600E418 RID: 58392 RVA: 0x004CF974 File Offset: 0x004CDB74
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= this.fieldName_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E419 RID: 58393 RVA: 0x004CF9B4 File Offset: 0x004CDBB4
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E41A RID: 58394 RVA: 0x004CF9CC File Offset: 0x004CDBCC
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E41B RID: 58395 RVA: 0x004CF9D8 File Offset: 0x004CDBD8
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					this.fieldName_.WriteTo(ref output, QuestChangeList.Types.RootChanges._repeated_fieldName_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E41C RID: 58396 RVA: 0x004CFA14 File Offset: 0x004CDC14
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += this.fieldName_.CalculateSize(QuestChangeList.Types.RootChanges._repeated_fieldName_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E41D RID: 58397 RVA: 0x004CFA5C File Offset: 0x004CDC5C
				[DebuggerNonUserCode]
				public void MergeFrom(QuestChangeList.Types.RootChanges other)
				{
					bool flag = other == null;
					if (!flag)
					{
						this.fieldName_.Add(other.fieldName_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E41E RID: 58398 RVA: 0x004CFA9E File Offset: 0x004CDC9E
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E41F RID: 58399 RVA: 0x004CFAAC File Offset: 0x004CDCAC
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
							this.fieldName_.AddEntriesFrom(ref input, QuestChangeList.Types.RootChanges._repeated_fieldName_codec);
						}
					}
				}

				// Token: 0x0400A298 RID: 41624
				private static readonly MessageParser<QuestChangeList.Types.RootChanges> _parser = new MessageParser<QuestChangeList.Types.RootChanges>(() => new QuestChangeList.Types.RootChanges());

				// Token: 0x0400A299 RID: 41625
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A29A RID: 41626
				public const int FieldNameFieldNumber = 1;

				// Token: 0x0400A29B RID: 41627
				private static readonly FieldCodec<string> _repeated_fieldName_codec = FieldCodec.ForString(10U);

				// Token: 0x0400A29C RID: 41628
				private readonly RepeatedField<string> fieldName_ = new RepeatedField<string>();
			}

			// Token: 0x02001464 RID: 5220
			public sealed class PhaseChanges : IMessage<QuestChangeList.Types.PhaseChanges>, IMessage, IEquatable<QuestChangeList.Types.PhaseChanges>, IDeepCloneable<QuestChangeList.Types.PhaseChanges>, IBufferMessage
			{
				// Token: 0x170039F3 RID: 14835
				// (get) Token: 0x0600E421 RID: 58401 RVA: 0x004CFB2C File Offset: 0x004CDD2C
				[DebuggerNonUserCode]
				public static MessageParser<QuestChangeList.Types.PhaseChanges> Parser
				{
					get
					{
						return QuestChangeList.Types.PhaseChanges._parser;
					}
				}

				// Token: 0x170039F4 RID: 14836
				// (get) Token: 0x0600E422 RID: 58402 RVA: 0x004CFB44 File Offset: 0x004CDD44
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestChangeList.Descriptor.NestedTypes[2];
					}
				}

				// Token: 0x170039F5 RID: 14837
				// (get) Token: 0x0600E423 RID: 58403 RVA: 0x004CFB68 File Offset: 0x004CDD68
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestChangeList.Types.PhaseChanges.Descriptor;
					}
				}

				// Token: 0x0600E424 RID: 58404 RVA: 0x004CFB7F File Offset: 0x004CDD7F
				[DebuggerNonUserCode]
				public PhaseChanges()
				{
				}

				// Token: 0x0600E425 RID: 58405 RVA: 0x004CFB9F File Offset: 0x004CDD9F
				[DebuggerNonUserCode]
				public PhaseChanges(QuestChangeList.Types.PhaseChanges other)
					: this()
				{
					this.phaseModifications_ = other.phaseModifications_.Clone();
					this.phaseAddsAndDeletes_ = other.phaseAddsAndDeletes_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E426 RID: 58406 RVA: 0x004CFBDC File Offset: 0x004CDDDC
				[DebuggerNonUserCode]
				public QuestChangeList.Types.PhaseChanges Clone()
				{
					return new QuestChangeList.Types.PhaseChanges(this);
				}

				// Token: 0x170039F6 RID: 14838
				// (get) Token: 0x0600E427 RID: 58407 RVA: 0x004CFBF4 File Offset: 0x004CDDF4
				[DebuggerNonUserCode]
				public RepeatedField<QuestChangeList.Types.IdFieldPair> PhaseModifications
				{
					get
					{
						return this.phaseModifications_;
					}
				}

				// Token: 0x170039F7 RID: 14839
				// (get) Token: 0x0600E428 RID: 58408 RVA: 0x004CFC0C File Offset: 0x004CDE0C
				[DebuggerNonUserCode]
				public RepeatedField<uint> PhaseAddsAndDeletes
				{
					get
					{
						return this.phaseAddsAndDeletes_;
					}
				}

				// Token: 0x0600E429 RID: 58409 RVA: 0x004CFC24 File Offset: 0x004CDE24
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestChangeList.Types.PhaseChanges);
				}

				// Token: 0x0600E42A RID: 58410 RVA: 0x004CFC44 File Offset: 0x004CDE44
				[DebuggerNonUserCode]
				public bool Equals(QuestChangeList.Types.PhaseChanges other)
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
							bool flag4 = !this.phaseModifications_.Equals(other.phaseModifications_);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = !this.phaseAddsAndDeletes_.Equals(other.phaseAddsAndDeletes_);
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E42B RID: 58411 RVA: 0x004CFCBC File Offset: 0x004CDEBC
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= this.phaseModifications_.GetHashCode();
					num ^= this.phaseAddsAndDeletes_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E42C RID: 58412 RVA: 0x004CFD0C File Offset: 0x004CDF0C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E42D RID: 58413 RVA: 0x004CFD24 File Offset: 0x004CDF24
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E42E RID: 58414 RVA: 0x004CFD30 File Offset: 0x004CDF30
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					this.phaseModifications_.WriteTo(ref output, QuestChangeList.Types.PhaseChanges._repeated_phaseModifications_codec);
					this.phaseAddsAndDeletes_.WriteTo(ref output, QuestChangeList.Types.PhaseChanges._repeated_phaseAddsAndDeletes_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E42F RID: 58415 RVA: 0x004CFD80 File Offset: 0x004CDF80
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += this.phaseModifications_.CalculateSize(QuestChangeList.Types.PhaseChanges._repeated_phaseModifications_codec);
					num += this.phaseAddsAndDeletes_.CalculateSize(QuestChangeList.Types.PhaseChanges._repeated_phaseAddsAndDeletes_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E430 RID: 58416 RVA: 0x004CFDD8 File Offset: 0x004CDFD8
				[DebuggerNonUserCode]
				public void MergeFrom(QuestChangeList.Types.PhaseChanges other)
				{
					bool flag = other == null;
					if (!flag)
					{
						this.phaseModifications_.Add(other.phaseModifications_);
						this.phaseAddsAndDeletes_.Add(other.phaseAddsAndDeletes_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E431 RID: 58417 RVA: 0x004CFE2C File Offset: 0x004CE02C
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E432 RID: 58418 RVA: 0x004CFE38 File Offset: 0x004CE038
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
								this.phaseAddsAndDeletes_.AddEntriesFrom(ref input, QuestChangeList.Types.PhaseChanges._repeated_phaseAddsAndDeletes_codec);
							}
						}
						else
						{
							this.phaseModifications_.AddEntriesFrom(ref input, QuestChangeList.Types.PhaseChanges._repeated_phaseModifications_codec);
						}
					}
				}

				// Token: 0x0400A29D RID: 41629
				private static readonly MessageParser<QuestChangeList.Types.PhaseChanges> _parser = new MessageParser<QuestChangeList.Types.PhaseChanges>(() => new QuestChangeList.Types.PhaseChanges());

				// Token: 0x0400A29E RID: 41630
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A29F RID: 41631
				public const int PhaseModificationsFieldNumber = 1;

				// Token: 0x0400A2A0 RID: 41632
				private static readonly FieldCodec<QuestChangeList.Types.IdFieldPair> _repeated_phaseModifications_codec = FieldCodec.ForMessage<QuestChangeList.Types.IdFieldPair>(10U, QuestChangeList.Types.IdFieldPair.Parser);

				// Token: 0x0400A2A1 RID: 41633
				private readonly RepeatedField<QuestChangeList.Types.IdFieldPair> phaseModifications_ = new RepeatedField<QuestChangeList.Types.IdFieldPair>();

				// Token: 0x0400A2A2 RID: 41634
				public const int PhaseAddsAndDeletesFieldNumber = 2;

				// Token: 0x0400A2A3 RID: 41635
				private static readonly FieldCodec<uint> _repeated_phaseAddsAndDeletes_codec = FieldCodec.ForUInt32(16U);

				// Token: 0x0400A2A4 RID: 41636
				private readonly RepeatedField<uint> phaseAddsAndDeletes_ = new RepeatedField<uint>();
			}

			// Token: 0x02001465 RID: 5221
			public sealed class ObjectiveSetChanges : IMessage<QuestChangeList.Types.ObjectiveSetChanges>, IMessage, IEquatable<QuestChangeList.Types.ObjectiveSetChanges>, IDeepCloneable<QuestChangeList.Types.ObjectiveSetChanges>, IBufferMessage
			{
				// Token: 0x170039F8 RID: 14840
				// (get) Token: 0x0600E434 RID: 58420 RVA: 0x004CFEEC File Offset: 0x004CE0EC
				[DebuggerNonUserCode]
				public static MessageParser<QuestChangeList.Types.ObjectiveSetChanges> Parser
				{
					get
					{
						return QuestChangeList.Types.ObjectiveSetChanges._parser;
					}
				}

				// Token: 0x170039F9 RID: 14841
				// (get) Token: 0x0600E435 RID: 58421 RVA: 0x004CFF04 File Offset: 0x004CE104
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestChangeList.Descriptor.NestedTypes[3];
					}
				}

				// Token: 0x170039FA RID: 14842
				// (get) Token: 0x0600E436 RID: 58422 RVA: 0x004CFF28 File Offset: 0x004CE128
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestChangeList.Types.ObjectiveSetChanges.Descriptor;
					}
				}

				// Token: 0x0600E437 RID: 58423 RVA: 0x004CFF3F File Offset: 0x004CE13F
				[DebuggerNonUserCode]
				public ObjectiveSetChanges()
				{
				}

				// Token: 0x0600E438 RID: 58424 RVA: 0x004CFF5F File Offset: 0x004CE15F
				[DebuggerNonUserCode]
				public ObjectiveSetChanges(QuestChangeList.Types.ObjectiveSetChanges other)
					: this()
				{
					this.objectivesetModifications_ = other.objectivesetModifications_.Clone();
					this.objectivesetAddsAndDeletes_ = other.objectivesetAddsAndDeletes_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E439 RID: 58425 RVA: 0x004CFF9C File Offset: 0x004CE19C
				[DebuggerNonUserCode]
				public QuestChangeList.Types.ObjectiveSetChanges Clone()
				{
					return new QuestChangeList.Types.ObjectiveSetChanges(this);
				}

				// Token: 0x170039FB RID: 14843
				// (get) Token: 0x0600E43A RID: 58426 RVA: 0x004CFFB4 File Offset: 0x004CE1B4
				[DebuggerNonUserCode]
				public RepeatedField<QuestChangeList.Types.IdFieldPair> ObjectivesetModifications
				{
					get
					{
						return this.objectivesetModifications_;
					}
				}

				// Token: 0x170039FC RID: 14844
				// (get) Token: 0x0600E43B RID: 58427 RVA: 0x004CFFCC File Offset: 0x004CE1CC
				[DebuggerNonUserCode]
				public RepeatedField<uint> ObjectivesetAddsAndDeletes
				{
					get
					{
						return this.objectivesetAddsAndDeletes_;
					}
				}

				// Token: 0x0600E43C RID: 58428 RVA: 0x004CFFE4 File Offset: 0x004CE1E4
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestChangeList.Types.ObjectiveSetChanges);
				}

				// Token: 0x0600E43D RID: 58429 RVA: 0x004D0004 File Offset: 0x004CE204
				[DebuggerNonUserCode]
				public bool Equals(QuestChangeList.Types.ObjectiveSetChanges other)
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
							bool flag4 = !this.objectivesetModifications_.Equals(other.objectivesetModifications_);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = !this.objectivesetAddsAndDeletes_.Equals(other.objectivesetAddsAndDeletes_);
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E43E RID: 58430 RVA: 0x004D007C File Offset: 0x004CE27C
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= this.objectivesetModifications_.GetHashCode();
					num ^= this.objectivesetAddsAndDeletes_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E43F RID: 58431 RVA: 0x004D00CC File Offset: 0x004CE2CC
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E440 RID: 58432 RVA: 0x004D00E4 File Offset: 0x004CE2E4
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E441 RID: 58433 RVA: 0x004D00F0 File Offset: 0x004CE2F0
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					this.objectivesetModifications_.WriteTo(ref output, QuestChangeList.Types.ObjectiveSetChanges._repeated_objectivesetModifications_codec);
					this.objectivesetAddsAndDeletes_.WriteTo(ref output, QuestChangeList.Types.ObjectiveSetChanges._repeated_objectivesetAddsAndDeletes_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E442 RID: 58434 RVA: 0x004D0140 File Offset: 0x004CE340
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += this.objectivesetModifications_.CalculateSize(QuestChangeList.Types.ObjectiveSetChanges._repeated_objectivesetModifications_codec);
					num += this.objectivesetAddsAndDeletes_.CalculateSize(QuestChangeList.Types.ObjectiveSetChanges._repeated_objectivesetAddsAndDeletes_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E443 RID: 58435 RVA: 0x004D0198 File Offset: 0x004CE398
				[DebuggerNonUserCode]
				public void MergeFrom(QuestChangeList.Types.ObjectiveSetChanges other)
				{
					bool flag = other == null;
					if (!flag)
					{
						this.objectivesetModifications_.Add(other.objectivesetModifications_);
						this.objectivesetAddsAndDeletes_.Add(other.objectivesetAddsAndDeletes_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E444 RID: 58436 RVA: 0x004D01EC File Offset: 0x004CE3EC
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E445 RID: 58437 RVA: 0x004D01F8 File Offset: 0x004CE3F8
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
								this.objectivesetAddsAndDeletes_.AddEntriesFrom(ref input, QuestChangeList.Types.ObjectiveSetChanges._repeated_objectivesetAddsAndDeletes_codec);
							}
						}
						else
						{
							this.objectivesetModifications_.AddEntriesFrom(ref input, QuestChangeList.Types.ObjectiveSetChanges._repeated_objectivesetModifications_codec);
						}
					}
				}

				// Token: 0x0400A2A5 RID: 41637
				private static readonly MessageParser<QuestChangeList.Types.ObjectiveSetChanges> _parser = new MessageParser<QuestChangeList.Types.ObjectiveSetChanges>(() => new QuestChangeList.Types.ObjectiveSetChanges());

				// Token: 0x0400A2A6 RID: 41638
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2A7 RID: 41639
				public const int ObjectivesetModificationsFieldNumber = 1;

				// Token: 0x0400A2A8 RID: 41640
				private static readonly FieldCodec<QuestChangeList.Types.IdFieldPair> _repeated_objectivesetModifications_codec = FieldCodec.ForMessage<QuestChangeList.Types.IdFieldPair>(10U, QuestChangeList.Types.IdFieldPair.Parser);

				// Token: 0x0400A2A9 RID: 41641
				private readonly RepeatedField<QuestChangeList.Types.IdFieldPair> objectivesetModifications_ = new RepeatedField<QuestChangeList.Types.IdFieldPair>();

				// Token: 0x0400A2AA RID: 41642
				public const int ObjectivesetAddsAndDeletesFieldNumber = 2;

				// Token: 0x0400A2AB RID: 41643
				private static readonly FieldCodec<uint> _repeated_objectivesetAddsAndDeletes_codec = FieldCodec.ForUInt32(16U);

				// Token: 0x0400A2AC RID: 41644
				private readonly RepeatedField<uint> objectivesetAddsAndDeletes_ = new RepeatedField<uint>();
			}

			// Token: 0x02001466 RID: 5222
			public sealed class CallbackChanges : IMessage<QuestChangeList.Types.CallbackChanges>, IMessage, IEquatable<QuestChangeList.Types.CallbackChanges>, IDeepCloneable<QuestChangeList.Types.CallbackChanges>, IBufferMessage
			{
				// Token: 0x170039FD RID: 14845
				// (get) Token: 0x0600E447 RID: 58439 RVA: 0x004D02AC File Offset: 0x004CE4AC
				[DebuggerNonUserCode]
				public static MessageParser<QuestChangeList.Types.CallbackChanges> Parser
				{
					get
					{
						return QuestChangeList.Types.CallbackChanges._parser;
					}
				}

				// Token: 0x170039FE RID: 14846
				// (get) Token: 0x0600E448 RID: 58440 RVA: 0x004D02C4 File Offset: 0x004CE4C4
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestChangeList.Descriptor.NestedTypes[4];
					}
				}

				// Token: 0x170039FF RID: 14847
				// (get) Token: 0x0600E449 RID: 58441 RVA: 0x004D02E8 File Offset: 0x004CE4E8
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestChangeList.Types.CallbackChanges.Descriptor;
					}
				}

				// Token: 0x0600E44A RID: 58442 RVA: 0x004D02FF File Offset: 0x004CE4FF
				[DebuggerNonUserCode]
				public CallbackChanges()
				{
				}

				// Token: 0x0600E44B RID: 58443 RVA: 0x004D031F File Offset: 0x004CE51F
				[DebuggerNonUserCode]
				public CallbackChanges(QuestChangeList.Types.CallbackChanges other)
					: this()
				{
					this.callbackModifications_ = other.callbackModifications_.Clone();
					this.callbackAddsAndDeletes_ = other.callbackAddsAndDeletes_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E44C RID: 58444 RVA: 0x004D035C File Offset: 0x004CE55C
				[DebuggerNonUserCode]
				public QuestChangeList.Types.CallbackChanges Clone()
				{
					return new QuestChangeList.Types.CallbackChanges(this);
				}

				// Token: 0x17003A00 RID: 14848
				// (get) Token: 0x0600E44D RID: 58445 RVA: 0x004D0374 File Offset: 0x004CE574
				[DebuggerNonUserCode]
				public RepeatedField<QuestChangeList.Types.IdFieldPair> CallbackModifications
				{
					get
					{
						return this.callbackModifications_;
					}
				}

				// Token: 0x17003A01 RID: 14849
				// (get) Token: 0x0600E44E RID: 58446 RVA: 0x004D038C File Offset: 0x004CE58C
				[DebuggerNonUserCode]
				public RepeatedField<uint> CallbackAddsAndDeletes
				{
					get
					{
						return this.callbackAddsAndDeletes_;
					}
				}

				// Token: 0x0600E44F RID: 58447 RVA: 0x004D03A4 File Offset: 0x004CE5A4
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestChangeList.Types.CallbackChanges);
				}

				// Token: 0x0600E450 RID: 58448 RVA: 0x004D03C4 File Offset: 0x004CE5C4
				[DebuggerNonUserCode]
				public bool Equals(QuestChangeList.Types.CallbackChanges other)
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
							bool flag4 = !this.callbackModifications_.Equals(other.callbackModifications_);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = !this.callbackAddsAndDeletes_.Equals(other.callbackAddsAndDeletes_);
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E451 RID: 58449 RVA: 0x004D043C File Offset: 0x004CE63C
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= this.callbackModifications_.GetHashCode();
					num ^= this.callbackAddsAndDeletes_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E452 RID: 58450 RVA: 0x004D048C File Offset: 0x004CE68C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E453 RID: 58451 RVA: 0x004D04A4 File Offset: 0x004CE6A4
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E454 RID: 58452 RVA: 0x004D04B0 File Offset: 0x004CE6B0
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					this.callbackModifications_.WriteTo(ref output, QuestChangeList.Types.CallbackChanges._repeated_callbackModifications_codec);
					this.callbackAddsAndDeletes_.WriteTo(ref output, QuestChangeList.Types.CallbackChanges._repeated_callbackAddsAndDeletes_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E455 RID: 58453 RVA: 0x004D0500 File Offset: 0x004CE700
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += this.callbackModifications_.CalculateSize(QuestChangeList.Types.CallbackChanges._repeated_callbackModifications_codec);
					num += this.callbackAddsAndDeletes_.CalculateSize(QuestChangeList.Types.CallbackChanges._repeated_callbackAddsAndDeletes_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E456 RID: 58454 RVA: 0x004D0558 File Offset: 0x004CE758
				[DebuggerNonUserCode]
				public void MergeFrom(QuestChangeList.Types.CallbackChanges other)
				{
					bool flag = other == null;
					if (!flag)
					{
						this.callbackModifications_.Add(other.callbackModifications_);
						this.callbackAddsAndDeletes_.Add(other.callbackAddsAndDeletes_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E457 RID: 58455 RVA: 0x004D05AC File Offset: 0x004CE7AC
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E458 RID: 58456 RVA: 0x004D05B8 File Offset: 0x004CE7B8
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
								this.callbackAddsAndDeletes_.AddEntriesFrom(ref input, QuestChangeList.Types.CallbackChanges._repeated_callbackAddsAndDeletes_codec);
							}
						}
						else
						{
							this.callbackModifications_.AddEntriesFrom(ref input, QuestChangeList.Types.CallbackChanges._repeated_callbackModifications_codec);
						}
					}
				}

				// Token: 0x0400A2AD RID: 41645
				private static readonly MessageParser<QuestChangeList.Types.CallbackChanges> _parser = new MessageParser<QuestChangeList.Types.CallbackChanges>(() => new QuestChangeList.Types.CallbackChanges());

				// Token: 0x0400A2AE RID: 41646
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2AF RID: 41647
				public const int CallbackModificationsFieldNumber = 1;

				// Token: 0x0400A2B0 RID: 41648
				private static readonly FieldCodec<QuestChangeList.Types.IdFieldPair> _repeated_callbackModifications_codec = FieldCodec.ForMessage<QuestChangeList.Types.IdFieldPair>(10U, QuestChangeList.Types.IdFieldPair.Parser);

				// Token: 0x0400A2B1 RID: 41649
				private readonly RepeatedField<QuestChangeList.Types.IdFieldPair> callbackModifications_ = new RepeatedField<QuestChangeList.Types.IdFieldPair>();

				// Token: 0x0400A2B2 RID: 41650
				public const int CallbackAddsAndDeletesFieldNumber = 2;

				// Token: 0x0400A2B3 RID: 41651
				private static readonly FieldCodec<uint> _repeated_callbackAddsAndDeletes_codec = FieldCodec.ForUInt32(16U);

				// Token: 0x0400A2B4 RID: 41652
				private readonly RepeatedField<uint> callbackAddsAndDeletes_ = new RepeatedField<uint>();
			}
		}
	}
}
