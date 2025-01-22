using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Client
{
	// Token: 0x02000116 RID: 278
	public sealed class ControllerActionBindings : IMessage<ControllerActionBindings>, IMessage, IEquatable<ControllerActionBindings>, IDeepCloneable<ControllerActionBindings>, IBufferMessage
	{
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0005EBA4 File Offset: 0x0005CDA4
		[DebuggerNonUserCode]
		public static MessageParser<ControllerActionBindings> Parser
		{
			get
			{
				return ControllerActionBindings._parser;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x0005EBBC File Offset: 0x0005CDBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0005EBE0 File Offset: 0x0005CDE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControllerActionBindings.Descriptor;
			}
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0005EBF7 File Offset: 0x0005CDF7
		[DebuggerNonUserCode]
		public ControllerActionBindings()
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0005EC04 File Offset: 0x0005CE04
		[DebuggerNonUserCode]
		public ControllerActionBindings(ControllerActionBindings other)
			: this()
		{
			this.controllerActionBindingEquippables_ = ((other.controllerActionBindingEquippables_ != null) ? other.controllerActionBindingEquippables_.Clone() : null);
			this.controllerActionBindingMap_ = ((other.controllerActionBindingMap_ != null) ? other.controllerActionBindingMap_.Clone() : null);
			this.controllerActionBindingPrimary_ = ((other.controllerActionBindingPrimary_ != null) ? other.controllerActionBindingPrimary_.Clone() : null);
			this.controllerActionBindingSecondary_ = ((other.controllerActionBindingSecondary_ != null) ? other.controllerActionBindingSecondary_.Clone() : null);
			this.controllerActionBindingSkill1_ = ((other.controllerActionBindingSkill1_ != null) ? other.controllerActionBindingSkill1_.Clone() : null);
			this.controllerActionBindingSkill2_ = ((other.controllerActionBindingSkill2_ != null) ? other.controllerActionBindingSkill2_.Clone() : null);
			this.controllerActionBindingSkill3_ = ((other.controllerActionBindingSkill3_ != null) ? other.controllerActionBindingSkill3_.Clone() : null);
			this.controllerActionBindingSkill4_ = ((other.controllerActionBindingSkill4_ != null) ? other.controllerActionBindingSkill4_.Clone() : null);
			this.controllerActionBindingUseItem_ = ((other.controllerActionBindingUseItem_ != null) ? other.controllerActionBindingUseItem_.Clone() : null);
			this.controllerActionBindingTargetLock_ = ((other.controllerActionBindingTargetLock_ != null) ? other.controllerActionBindingTargetLock_.Clone() : null);
			this.controllerActionBindingShowItemLabels_ = ((other.controllerActionBindingShowItemLabels_ != null) ? other.controllerActionBindingShowItemLabels_.Clone() : null);
			this.controllerActionBindingQuickResponse_ = ((other.controllerActionBindingQuickResponse_ != null) ? other.controllerActionBindingQuickResponse_.Clone() : null);
			this.controllerActionBindingWheel_ = ((other.controllerActionBindingWheel_ != null) ? other.controllerActionBindingWheel_.Clone() : null);
			this.controllerActionBindingPushToTalk_ = ((other.controllerActionBindingPushToTalk_ != null) ? other.controllerActionBindingPushToTalk_.Clone() : null);
			this.controllerActionBindingEvade_ = ((other.controllerActionBindingEvade_ != null) ? other.controllerActionBindingEvade_.Clone() : null);
			this.controllerActionBindingInteract_ = ((other.controllerActionBindingInteract_ != null) ? other.controllerActionBindingInteract_.Clone() : null);
			this.controllerActionBindingWheelPageBackward_ = ((other.controllerActionBindingWheelPageBackward_ != null) ? other.controllerActionBindingWheelPageBackward_.Clone() : null);
			this.controllerActionBindingWheelPageForward_ = ((other.controllerActionBindingWheelPageForward_ != null) ? other.controllerActionBindingWheelPageForward_.Clone() : null);
			this.controllerActionBindingCombinedInteract_ = ((other.controllerActionBindingCombinedInteract_ != null) ? other.controllerActionBindingCombinedInteract_.Clone() : null);
			this.controllerActionBindingCycleTargetLock_ = ((other.controllerActionBindingCycleTargetLock_ != null) ? other.controllerActionBindingCycleTargetLock_.Clone() : null);
			this.controllerActionBindingTownPortal_ = ((other.controllerActionBindingTownPortal_ != null) ? other.controllerActionBindingTownPortal_.Clone() : null);
			this.controllerActionBindingJoinSpeechToTextChat_ = ((other.controllerActionBindingJoinSpeechToTextChat_ != null) ? other.controllerActionBindingJoinSpeechToTextChat_.Clone() : null);
			this.controllerActionBindingTtsSkipCurrentUtterance_ = ((other.controllerActionBindingTtsSkipCurrentUtterance_ != null) ? other.controllerActionBindingTtsSkipCurrentUtterance_.Clone() : null);
			this.controllerActionBindingTtsCancelAllUtterances_ = ((other.controllerActionBindingTtsCancelAllUtterances_ != null) ? other.controllerActionBindingTtsCancelAllUtterances_.Clone() : null);
			this.controllerActionBindingMount_ = ((other.controllerActionBindingMount_ != null) ? other.controllerActionBindingMount_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0005EEE8 File Offset: 0x0005D0E8
		[DebuggerNonUserCode]
		public ControllerActionBindings Clone()
		{
			return new ControllerActionBindings(this);
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0005EF00 File Offset: 0x0005D100
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0005EF18 File Offset: 0x0005D118
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingEquippables
		{
			get
			{
				return this.controllerActionBindingEquippables_;
			}
			set
			{
				this.controllerActionBindingEquippables_ = value;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0005EF24 File Offset: 0x0005D124
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0005EF3C File Offset: 0x0005D13C
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingMap
		{
			get
			{
				return this.controllerActionBindingMap_;
			}
			set
			{
				this.controllerActionBindingMap_ = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0005EF48 File Offset: 0x0005D148
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0005EF60 File Offset: 0x0005D160
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingPrimary
		{
			get
			{
				return this.controllerActionBindingPrimary_;
			}
			set
			{
				this.controllerActionBindingPrimary_ = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0005EF6C File Offset: 0x0005D16C
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0005EF84 File Offset: 0x0005D184
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingSecondary
		{
			get
			{
				return this.controllerActionBindingSecondary_;
			}
			set
			{
				this.controllerActionBindingSecondary_ = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0005EF90 File Offset: 0x0005D190
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0005EFA8 File Offset: 0x0005D1A8
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingSkill1
		{
			get
			{
				return this.controllerActionBindingSkill1_;
			}
			set
			{
				this.controllerActionBindingSkill1_ = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0005EFB4 File Offset: 0x0005D1B4
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0005EFCC File Offset: 0x0005D1CC
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingSkill2
		{
			get
			{
				return this.controllerActionBindingSkill2_;
			}
			set
			{
				this.controllerActionBindingSkill2_ = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0005EFD8 File Offset: 0x0005D1D8
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0005EFF0 File Offset: 0x0005D1F0
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingSkill3
		{
			get
			{
				return this.controllerActionBindingSkill3_;
			}
			set
			{
				this.controllerActionBindingSkill3_ = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0005EFFC File Offset: 0x0005D1FC
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0005F014 File Offset: 0x0005D214
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingSkill4
		{
			get
			{
				return this.controllerActionBindingSkill4_;
			}
			set
			{
				this.controllerActionBindingSkill4_ = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0005F020 File Offset: 0x0005D220
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0005F038 File Offset: 0x0005D238
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingUseItem
		{
			get
			{
				return this.controllerActionBindingUseItem_;
			}
			set
			{
				this.controllerActionBindingUseItem_ = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0005F044 File Offset: 0x0005D244
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0005F05C File Offset: 0x0005D25C
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingTargetLock
		{
			get
			{
				return this.controllerActionBindingTargetLock_;
			}
			set
			{
				this.controllerActionBindingTargetLock_ = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0005F068 File Offset: 0x0005D268
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0005F080 File Offset: 0x0005D280
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingShowItemLabels
		{
			get
			{
				return this.controllerActionBindingShowItemLabels_;
			}
			set
			{
				this.controllerActionBindingShowItemLabels_ = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0005F08C File Offset: 0x0005D28C
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0005F0A4 File Offset: 0x0005D2A4
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingQuickResponse
		{
			get
			{
				return this.controllerActionBindingQuickResponse_;
			}
			set
			{
				this.controllerActionBindingQuickResponse_ = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0005F0B0 File Offset: 0x0005D2B0
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0005F0C8 File Offset: 0x0005D2C8
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingWheel
		{
			get
			{
				return this.controllerActionBindingWheel_;
			}
			set
			{
				this.controllerActionBindingWheel_ = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0005F0D4 File Offset: 0x0005D2D4
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0005F0EC File Offset: 0x0005D2EC
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingPushToTalk
		{
			get
			{
				return this.controllerActionBindingPushToTalk_;
			}
			set
			{
				this.controllerActionBindingPushToTalk_ = value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0005F110 File Offset: 0x0005D310
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingEvade
		{
			get
			{
				return this.controllerActionBindingEvade_;
			}
			set
			{
				this.controllerActionBindingEvade_ = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0005F11C File Offset: 0x0005D31C
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0005F134 File Offset: 0x0005D334
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingInteract
		{
			get
			{
				return this.controllerActionBindingInteract_;
			}
			set
			{
				this.controllerActionBindingInteract_ = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0005F140 File Offset: 0x0005D340
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0005F158 File Offset: 0x0005D358
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingWheelPageBackward
		{
			get
			{
				return this.controllerActionBindingWheelPageBackward_;
			}
			set
			{
				this.controllerActionBindingWheelPageBackward_ = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0005F164 File Offset: 0x0005D364
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0005F17C File Offset: 0x0005D37C
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingWheelPageForward
		{
			get
			{
				return this.controllerActionBindingWheelPageForward_;
			}
			set
			{
				this.controllerActionBindingWheelPageForward_ = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0005F188 File Offset: 0x0005D388
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingCombinedInteract
		{
			get
			{
				return this.controllerActionBindingCombinedInteract_;
			}
			set
			{
				this.controllerActionBindingCombinedInteract_ = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0005F1AC File Offset: 0x0005D3AC
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0005F1C4 File Offset: 0x0005D3C4
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingCycleTargetLock
		{
			get
			{
				return this.controllerActionBindingCycleTargetLock_;
			}
			set
			{
				this.controllerActionBindingCycleTargetLock_ = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0005F1E8 File Offset: 0x0005D3E8
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingTownPortal
		{
			get
			{
				return this.controllerActionBindingTownPortal_;
			}
			set
			{
				this.controllerActionBindingTownPortal_ = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0005F20C File Offset: 0x0005D40C
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingJoinSpeechToTextChat
		{
			get
			{
				return this.controllerActionBindingJoinSpeechToTextChat_;
			}
			set
			{
				this.controllerActionBindingJoinSpeechToTextChat_ = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0005F218 File Offset: 0x0005D418
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x0005F230 File Offset: 0x0005D430
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingTtsSkipCurrentUtterance
		{
			get
			{
				return this.controllerActionBindingTtsSkipCurrentUtterance_;
			}
			set
			{
				this.controllerActionBindingTtsSkipCurrentUtterance_ = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0005F23C File Offset: 0x0005D43C
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x0005F254 File Offset: 0x0005D454
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingTtsCancelAllUtterances
		{
			get
			{
				return this.controllerActionBindingTtsCancelAllUtterances_;
			}
			set
			{
				this.controllerActionBindingTtsCancelAllUtterances_ = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0005F260 File Offset: 0x0005D460
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0005F278 File Offset: 0x0005D478
		[DebuggerNonUserCode]
		public ControllerActionBinding ControllerActionBindingMount
		{
			get
			{
				return this.controllerActionBindingMount_;
			}
			set
			{
				this.controllerActionBindingMount_ = value;
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0005F284 File Offset: 0x0005D484
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControllerActionBindings);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0005F2A4 File Offset: 0x0005D4A4
		[DebuggerNonUserCode]
		public bool Equals(ControllerActionBindings other)
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
					bool flag4 = !object.Equals(this.ControllerActionBindingEquippables, other.ControllerActionBindingEquippables);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ControllerActionBindingMap, other.ControllerActionBindingMap);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ControllerActionBindingPrimary, other.ControllerActionBindingPrimary);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.ControllerActionBindingSecondary, other.ControllerActionBindingSecondary);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.ControllerActionBindingSkill1, other.ControllerActionBindingSkill1);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.ControllerActionBindingSkill2, other.ControllerActionBindingSkill2);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.ControllerActionBindingSkill3, other.ControllerActionBindingSkill3);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.ControllerActionBindingSkill4, other.ControllerActionBindingSkill4);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.ControllerActionBindingUseItem, other.ControllerActionBindingUseItem);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.ControllerActionBindingTargetLock, other.ControllerActionBindingTargetLock);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.ControllerActionBindingShowItemLabels, other.ControllerActionBindingShowItemLabels);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.ControllerActionBindingQuickResponse, other.ControllerActionBindingQuickResponse);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !object.Equals(this.ControllerActionBindingWheel, other.ControllerActionBindingWheel);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !object.Equals(this.ControllerActionBindingPushToTalk, other.ControllerActionBindingPushToTalk);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !object.Equals(this.ControllerActionBindingEvade, other.ControllerActionBindingEvade);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = !object.Equals(this.ControllerActionBindingInteract, other.ControllerActionBindingInteract);
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = !object.Equals(this.ControllerActionBindingWheelPageBackward, other.ControllerActionBindingWheelPageBackward);
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = !object.Equals(this.ControllerActionBindingWheelPageForward, other.ControllerActionBindingWheelPageForward);
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = !object.Equals(this.ControllerActionBindingCombinedInteract, other.ControllerActionBindingCombinedInteract);
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = !object.Equals(this.ControllerActionBindingCycleTargetLock, other.ControllerActionBindingCycleTargetLock);
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !object.Equals(this.ControllerActionBindingTownPortal, other.ControllerActionBindingTownPortal);
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = !object.Equals(this.ControllerActionBindingJoinSpeechToTextChat, other.ControllerActionBindingJoinSpeechToTextChat);
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = !object.Equals(this.ControllerActionBindingTtsSkipCurrentUtterance, other.ControllerActionBindingTtsSkipCurrentUtterance);
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = !object.Equals(this.ControllerActionBindingTtsCancelAllUtterances, other.ControllerActionBindingTtsCancelAllUtterances);
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = !object.Equals(this.ControllerActionBindingMount, other.ControllerActionBindingMount);
																													flag2 = !flag28 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06001A90 RID: 6800 RVA: 0x0005F614 File Offset: 0x0005D814
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.controllerActionBindingEquippables_ != null;
			if (flag)
			{
				num ^= this.ControllerActionBindingEquippables.GetHashCode();
			}
			bool flag2 = this.controllerActionBindingMap_ != null;
			if (flag2)
			{
				num ^= this.ControllerActionBindingMap.GetHashCode();
			}
			bool flag3 = this.controllerActionBindingPrimary_ != null;
			if (flag3)
			{
				num ^= this.ControllerActionBindingPrimary.GetHashCode();
			}
			bool flag4 = this.controllerActionBindingSecondary_ != null;
			if (flag4)
			{
				num ^= this.ControllerActionBindingSecondary.GetHashCode();
			}
			bool flag5 = this.controllerActionBindingSkill1_ != null;
			if (flag5)
			{
				num ^= this.ControllerActionBindingSkill1.GetHashCode();
			}
			bool flag6 = this.controllerActionBindingSkill2_ != null;
			if (flag6)
			{
				num ^= this.ControllerActionBindingSkill2.GetHashCode();
			}
			bool flag7 = this.controllerActionBindingSkill3_ != null;
			if (flag7)
			{
				num ^= this.ControllerActionBindingSkill3.GetHashCode();
			}
			bool flag8 = this.controllerActionBindingSkill4_ != null;
			if (flag8)
			{
				num ^= this.ControllerActionBindingSkill4.GetHashCode();
			}
			bool flag9 = this.controllerActionBindingUseItem_ != null;
			if (flag9)
			{
				num ^= this.ControllerActionBindingUseItem.GetHashCode();
			}
			bool flag10 = this.controllerActionBindingTargetLock_ != null;
			if (flag10)
			{
				num ^= this.ControllerActionBindingTargetLock.GetHashCode();
			}
			bool flag11 = this.controllerActionBindingShowItemLabels_ != null;
			if (flag11)
			{
				num ^= this.ControllerActionBindingShowItemLabels.GetHashCode();
			}
			bool flag12 = this.controllerActionBindingQuickResponse_ != null;
			if (flag12)
			{
				num ^= this.ControllerActionBindingQuickResponse.GetHashCode();
			}
			bool flag13 = this.controllerActionBindingWheel_ != null;
			if (flag13)
			{
				num ^= this.ControllerActionBindingWheel.GetHashCode();
			}
			bool flag14 = this.controllerActionBindingPushToTalk_ != null;
			if (flag14)
			{
				num ^= this.ControllerActionBindingPushToTalk.GetHashCode();
			}
			bool flag15 = this.controllerActionBindingEvade_ != null;
			if (flag15)
			{
				num ^= this.ControllerActionBindingEvade.GetHashCode();
			}
			bool flag16 = this.controllerActionBindingInteract_ != null;
			if (flag16)
			{
				num ^= this.ControllerActionBindingInteract.GetHashCode();
			}
			bool flag17 = this.controllerActionBindingWheelPageBackward_ != null;
			if (flag17)
			{
				num ^= this.ControllerActionBindingWheelPageBackward.GetHashCode();
			}
			bool flag18 = this.controllerActionBindingWheelPageForward_ != null;
			if (flag18)
			{
				num ^= this.ControllerActionBindingWheelPageForward.GetHashCode();
			}
			bool flag19 = this.controllerActionBindingCombinedInteract_ != null;
			if (flag19)
			{
				num ^= this.ControllerActionBindingCombinedInteract.GetHashCode();
			}
			bool flag20 = this.controllerActionBindingCycleTargetLock_ != null;
			if (flag20)
			{
				num ^= this.ControllerActionBindingCycleTargetLock.GetHashCode();
			}
			bool flag21 = this.controllerActionBindingTownPortal_ != null;
			if (flag21)
			{
				num ^= this.ControllerActionBindingTownPortal.GetHashCode();
			}
			bool flag22 = this.controllerActionBindingJoinSpeechToTextChat_ != null;
			if (flag22)
			{
				num ^= this.ControllerActionBindingJoinSpeechToTextChat.GetHashCode();
			}
			bool flag23 = this.controllerActionBindingTtsSkipCurrentUtterance_ != null;
			if (flag23)
			{
				num ^= this.ControllerActionBindingTtsSkipCurrentUtterance.GetHashCode();
			}
			bool flag24 = this.controllerActionBindingTtsCancelAllUtterances_ != null;
			if (flag24)
			{
				num ^= this.ControllerActionBindingTtsCancelAllUtterances.GetHashCode();
			}
			bool flag25 = this.controllerActionBindingMount_ != null;
			if (flag25)
			{
				num ^= this.ControllerActionBindingMount.GetHashCode();
			}
			bool flag26 = this._unknownFields != null;
			if (flag26)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0005F91C File Offset: 0x0005DB1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0005F934 File Offset: 0x0005DB34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0005F940 File Offset: 0x0005DB40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.controllerActionBindingEquippables_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ControllerActionBindingEquippables);
			}
			bool flag2 = this.controllerActionBindingMap_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ControllerActionBindingMap);
			}
			bool flag3 = this.controllerActionBindingPrimary_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ControllerActionBindingPrimary);
			}
			bool flag4 = this.controllerActionBindingSecondary_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ControllerActionBindingSecondary);
			}
			bool flag5 = this.controllerActionBindingSkill1_ != null;
			if (flag5)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ControllerActionBindingSkill1);
			}
			bool flag6 = this.controllerActionBindingSkill2_ != null;
			if (flag6)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ControllerActionBindingSkill2);
			}
			bool flag7 = this.controllerActionBindingSkill3_ != null;
			if (flag7)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ControllerActionBindingSkill3);
			}
			bool flag8 = this.controllerActionBindingSkill4_ != null;
			if (flag8)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ControllerActionBindingSkill4);
			}
			bool flag9 = this.controllerActionBindingUseItem_ != null;
			if (flag9)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ControllerActionBindingUseItem);
			}
			bool flag10 = this.controllerActionBindingTargetLock_ != null;
			if (flag10)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ControllerActionBindingTargetLock);
			}
			bool flag11 = this.controllerActionBindingShowItemLabels_ != null;
			if (flag11)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ControllerActionBindingShowItemLabels);
			}
			bool flag12 = this.controllerActionBindingQuickResponse_ != null;
			if (flag12)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ControllerActionBindingQuickResponse);
			}
			bool flag13 = this.controllerActionBindingWheel_ != null;
			if (flag13)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ControllerActionBindingWheel);
			}
			bool flag14 = this.controllerActionBindingPushToTalk_ != null;
			if (flag14)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ControllerActionBindingPushToTalk);
			}
			bool flag15 = this.controllerActionBindingEvade_ != null;
			if (flag15)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.ControllerActionBindingEvade);
			}
			bool flag16 = this.controllerActionBindingInteract_ != null;
			if (flag16)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.ControllerActionBindingInteract);
			}
			bool flag17 = this.controllerActionBindingWheelPageBackward_ != null;
			if (flag17)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.ControllerActionBindingWheelPageBackward);
			}
			bool flag18 = this.controllerActionBindingWheelPageForward_ != null;
			if (flag18)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.ControllerActionBindingWheelPageForward);
			}
			bool flag19 = this.controllerActionBindingCombinedInteract_ != null;
			if (flag19)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.ControllerActionBindingCombinedInteract);
			}
			bool flag20 = this.controllerActionBindingCycleTargetLock_ != null;
			if (flag20)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.ControllerActionBindingCycleTargetLock);
			}
			bool flag21 = this.controllerActionBindingTownPortal_ != null;
			if (flag21)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.ControllerActionBindingTownPortal);
			}
			bool flag22 = this.controllerActionBindingJoinSpeechToTextChat_ != null;
			if (flag22)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.ControllerActionBindingJoinSpeechToTextChat);
			}
			bool flag23 = this.controllerActionBindingTtsSkipCurrentUtterance_ != null;
			if (flag23)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.ControllerActionBindingTtsSkipCurrentUtterance);
			}
			bool flag24 = this.controllerActionBindingTtsCancelAllUtterances_ != null;
			if (flag24)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.ControllerActionBindingTtsCancelAllUtterances);
			}
			bool flag25 = this.controllerActionBindingMount_ != null;
			if (flag25)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.ControllerActionBindingMount);
			}
			bool flag26 = this._unknownFields != null;
			if (flag26)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0005FD60 File Offset: 0x0005DF60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.controllerActionBindingEquippables_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingEquippables);
			}
			bool flag2 = this.controllerActionBindingMap_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingMap);
			}
			bool flag3 = this.controllerActionBindingPrimary_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingPrimary);
			}
			bool flag4 = this.controllerActionBindingSecondary_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingSecondary);
			}
			bool flag5 = this.controllerActionBindingSkill1_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingSkill1);
			}
			bool flag6 = this.controllerActionBindingSkill2_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingSkill2);
			}
			bool flag7 = this.controllerActionBindingSkill3_ != null;
			if (flag7)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingSkill3);
			}
			bool flag8 = this.controllerActionBindingSkill4_ != null;
			if (flag8)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingSkill4);
			}
			bool flag9 = this.controllerActionBindingUseItem_ != null;
			if (flag9)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingUseItem);
			}
			bool flag10 = this.controllerActionBindingTargetLock_ != null;
			if (flag10)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingTargetLock);
			}
			bool flag11 = this.controllerActionBindingShowItemLabels_ != null;
			if (flag11)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingShowItemLabels);
			}
			bool flag12 = this.controllerActionBindingQuickResponse_ != null;
			if (flag12)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingQuickResponse);
			}
			bool flag13 = this.controllerActionBindingWheel_ != null;
			if (flag13)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingWheel);
			}
			bool flag14 = this.controllerActionBindingPushToTalk_ != null;
			if (flag14)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingPushToTalk);
			}
			bool flag15 = this.controllerActionBindingEvade_ != null;
			if (flag15)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingEvade);
			}
			bool flag16 = this.controllerActionBindingInteract_ != null;
			if (flag16)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingInteract);
			}
			bool flag17 = this.controllerActionBindingWheelPageBackward_ != null;
			if (flag17)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingWheelPageBackward);
			}
			bool flag18 = this.controllerActionBindingWheelPageForward_ != null;
			if (flag18)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingWheelPageForward);
			}
			bool flag19 = this.controllerActionBindingCombinedInteract_ != null;
			if (flag19)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingCombinedInteract);
			}
			bool flag20 = this.controllerActionBindingCycleTargetLock_ != null;
			if (flag20)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingCycleTargetLock);
			}
			bool flag21 = this.controllerActionBindingTownPortal_ != null;
			if (flag21)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingTownPortal);
			}
			bool flag22 = this.controllerActionBindingJoinSpeechToTextChat_ != null;
			if (flag22)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingJoinSpeechToTextChat);
			}
			bool flag23 = this.controllerActionBindingTtsSkipCurrentUtterance_ != null;
			if (flag23)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingTtsSkipCurrentUtterance);
			}
			bool flag24 = this.controllerActionBindingTtsCancelAllUtterances_ != null;
			if (flag24)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingTtsCancelAllUtterances);
			}
			bool flag25 = this.controllerActionBindingMount_ != null;
			if (flag25)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ControllerActionBindingMount);
			}
			bool flag26 = this._unknownFields != null;
			if (flag26)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x000600CC File Offset: 0x0005E2CC
		[DebuggerNonUserCode]
		public void MergeFrom(ControllerActionBindings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.controllerActionBindingEquippables_ != null;
				if (flag2)
				{
					bool flag3 = this.controllerActionBindingEquippables_ == null;
					if (flag3)
					{
						this.ControllerActionBindingEquippables = new ControllerActionBinding();
					}
					this.ControllerActionBindingEquippables.MergeFrom(other.ControllerActionBindingEquippables);
				}
				bool flag4 = other.controllerActionBindingMap_ != null;
				if (flag4)
				{
					bool flag5 = this.controllerActionBindingMap_ == null;
					if (flag5)
					{
						this.ControllerActionBindingMap = new ControllerActionBinding();
					}
					this.ControllerActionBindingMap.MergeFrom(other.ControllerActionBindingMap);
				}
				bool flag6 = other.controllerActionBindingPrimary_ != null;
				if (flag6)
				{
					bool flag7 = this.controllerActionBindingPrimary_ == null;
					if (flag7)
					{
						this.ControllerActionBindingPrimary = new ControllerActionBinding();
					}
					this.ControllerActionBindingPrimary.MergeFrom(other.ControllerActionBindingPrimary);
				}
				bool flag8 = other.controllerActionBindingSecondary_ != null;
				if (flag8)
				{
					bool flag9 = this.controllerActionBindingSecondary_ == null;
					if (flag9)
					{
						this.ControllerActionBindingSecondary = new ControllerActionBinding();
					}
					this.ControllerActionBindingSecondary.MergeFrom(other.ControllerActionBindingSecondary);
				}
				bool flag10 = other.controllerActionBindingSkill1_ != null;
				if (flag10)
				{
					bool flag11 = this.controllerActionBindingSkill1_ == null;
					if (flag11)
					{
						this.ControllerActionBindingSkill1 = new ControllerActionBinding();
					}
					this.ControllerActionBindingSkill1.MergeFrom(other.ControllerActionBindingSkill1);
				}
				bool flag12 = other.controllerActionBindingSkill2_ != null;
				if (flag12)
				{
					bool flag13 = this.controllerActionBindingSkill2_ == null;
					if (flag13)
					{
						this.ControllerActionBindingSkill2 = new ControllerActionBinding();
					}
					this.ControllerActionBindingSkill2.MergeFrom(other.ControllerActionBindingSkill2);
				}
				bool flag14 = other.controllerActionBindingSkill3_ != null;
				if (flag14)
				{
					bool flag15 = this.controllerActionBindingSkill3_ == null;
					if (flag15)
					{
						this.ControllerActionBindingSkill3 = new ControllerActionBinding();
					}
					this.ControllerActionBindingSkill3.MergeFrom(other.ControllerActionBindingSkill3);
				}
				bool flag16 = other.controllerActionBindingSkill4_ != null;
				if (flag16)
				{
					bool flag17 = this.controllerActionBindingSkill4_ == null;
					if (flag17)
					{
						this.ControllerActionBindingSkill4 = new ControllerActionBinding();
					}
					this.ControllerActionBindingSkill4.MergeFrom(other.ControllerActionBindingSkill4);
				}
				bool flag18 = other.controllerActionBindingUseItem_ != null;
				if (flag18)
				{
					bool flag19 = this.controllerActionBindingUseItem_ == null;
					if (flag19)
					{
						this.ControllerActionBindingUseItem = new ControllerActionBinding();
					}
					this.ControllerActionBindingUseItem.MergeFrom(other.ControllerActionBindingUseItem);
				}
				bool flag20 = other.controllerActionBindingTargetLock_ != null;
				if (flag20)
				{
					bool flag21 = this.controllerActionBindingTargetLock_ == null;
					if (flag21)
					{
						this.ControllerActionBindingTargetLock = new ControllerActionBinding();
					}
					this.ControllerActionBindingTargetLock.MergeFrom(other.ControllerActionBindingTargetLock);
				}
				bool flag22 = other.controllerActionBindingShowItemLabels_ != null;
				if (flag22)
				{
					bool flag23 = this.controllerActionBindingShowItemLabels_ == null;
					if (flag23)
					{
						this.ControllerActionBindingShowItemLabels = new ControllerActionBinding();
					}
					this.ControllerActionBindingShowItemLabels.MergeFrom(other.ControllerActionBindingShowItemLabels);
				}
				bool flag24 = other.controllerActionBindingQuickResponse_ != null;
				if (flag24)
				{
					bool flag25 = this.controllerActionBindingQuickResponse_ == null;
					if (flag25)
					{
						this.ControllerActionBindingQuickResponse = new ControllerActionBinding();
					}
					this.ControllerActionBindingQuickResponse.MergeFrom(other.ControllerActionBindingQuickResponse);
				}
				bool flag26 = other.controllerActionBindingWheel_ != null;
				if (flag26)
				{
					bool flag27 = this.controllerActionBindingWheel_ == null;
					if (flag27)
					{
						this.ControllerActionBindingWheel = new ControllerActionBinding();
					}
					this.ControllerActionBindingWheel.MergeFrom(other.ControllerActionBindingWheel);
				}
				bool flag28 = other.controllerActionBindingPushToTalk_ != null;
				if (flag28)
				{
					bool flag29 = this.controllerActionBindingPushToTalk_ == null;
					if (flag29)
					{
						this.ControllerActionBindingPushToTalk = new ControllerActionBinding();
					}
					this.ControllerActionBindingPushToTalk.MergeFrom(other.ControllerActionBindingPushToTalk);
				}
				bool flag30 = other.controllerActionBindingEvade_ != null;
				if (flag30)
				{
					bool flag31 = this.controllerActionBindingEvade_ == null;
					if (flag31)
					{
						this.ControllerActionBindingEvade = new ControllerActionBinding();
					}
					this.ControllerActionBindingEvade.MergeFrom(other.ControllerActionBindingEvade);
				}
				bool flag32 = other.controllerActionBindingInteract_ != null;
				if (flag32)
				{
					bool flag33 = this.controllerActionBindingInteract_ == null;
					if (flag33)
					{
						this.ControllerActionBindingInteract = new ControllerActionBinding();
					}
					this.ControllerActionBindingInteract.MergeFrom(other.ControllerActionBindingInteract);
				}
				bool flag34 = other.controllerActionBindingWheelPageBackward_ != null;
				if (flag34)
				{
					bool flag35 = this.controllerActionBindingWheelPageBackward_ == null;
					if (flag35)
					{
						this.ControllerActionBindingWheelPageBackward = new ControllerActionBinding();
					}
					this.ControllerActionBindingWheelPageBackward.MergeFrom(other.ControllerActionBindingWheelPageBackward);
				}
				bool flag36 = other.controllerActionBindingWheelPageForward_ != null;
				if (flag36)
				{
					bool flag37 = this.controllerActionBindingWheelPageForward_ == null;
					if (flag37)
					{
						this.ControllerActionBindingWheelPageForward = new ControllerActionBinding();
					}
					this.ControllerActionBindingWheelPageForward.MergeFrom(other.ControllerActionBindingWheelPageForward);
				}
				bool flag38 = other.controllerActionBindingCombinedInteract_ != null;
				if (flag38)
				{
					bool flag39 = this.controllerActionBindingCombinedInteract_ == null;
					if (flag39)
					{
						this.ControllerActionBindingCombinedInteract = new ControllerActionBinding();
					}
					this.ControllerActionBindingCombinedInteract.MergeFrom(other.ControllerActionBindingCombinedInteract);
				}
				bool flag40 = other.controllerActionBindingCycleTargetLock_ != null;
				if (flag40)
				{
					bool flag41 = this.controllerActionBindingCycleTargetLock_ == null;
					if (flag41)
					{
						this.ControllerActionBindingCycleTargetLock = new ControllerActionBinding();
					}
					this.ControllerActionBindingCycleTargetLock.MergeFrom(other.ControllerActionBindingCycleTargetLock);
				}
				bool flag42 = other.controllerActionBindingTownPortal_ != null;
				if (flag42)
				{
					bool flag43 = this.controllerActionBindingTownPortal_ == null;
					if (flag43)
					{
						this.ControllerActionBindingTownPortal = new ControllerActionBinding();
					}
					this.ControllerActionBindingTownPortal.MergeFrom(other.ControllerActionBindingTownPortal);
				}
				bool flag44 = other.controllerActionBindingJoinSpeechToTextChat_ != null;
				if (flag44)
				{
					bool flag45 = this.controllerActionBindingJoinSpeechToTextChat_ == null;
					if (flag45)
					{
						this.ControllerActionBindingJoinSpeechToTextChat = new ControllerActionBinding();
					}
					this.ControllerActionBindingJoinSpeechToTextChat.MergeFrom(other.ControllerActionBindingJoinSpeechToTextChat);
				}
				bool flag46 = other.controllerActionBindingTtsSkipCurrentUtterance_ != null;
				if (flag46)
				{
					bool flag47 = this.controllerActionBindingTtsSkipCurrentUtterance_ == null;
					if (flag47)
					{
						this.ControllerActionBindingTtsSkipCurrentUtterance = new ControllerActionBinding();
					}
					this.ControllerActionBindingTtsSkipCurrentUtterance.MergeFrom(other.ControllerActionBindingTtsSkipCurrentUtterance);
				}
				bool flag48 = other.controllerActionBindingTtsCancelAllUtterances_ != null;
				if (flag48)
				{
					bool flag49 = this.controllerActionBindingTtsCancelAllUtterances_ == null;
					if (flag49)
					{
						this.ControllerActionBindingTtsCancelAllUtterances = new ControllerActionBinding();
					}
					this.ControllerActionBindingTtsCancelAllUtterances.MergeFrom(other.ControllerActionBindingTtsCancelAllUtterances);
				}
				bool flag50 = other.controllerActionBindingMount_ != null;
				if (flag50)
				{
					bool flag51 = this.controllerActionBindingMount_ == null;
					if (flag51)
					{
						this.ControllerActionBindingMount = new ControllerActionBinding();
					}
					this.ControllerActionBindingMount.MergeFrom(other.ControllerActionBindingMount);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00060739 File Offset: 0x0005E939
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00060744 File Offset: 0x0005E944
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 106U)
				{
					if (num3 <= 58U)
					{
						if (num3 <= 34U)
						{
							if (num3 != 10U)
							{
								if (num3 != 18U)
								{
									if (num3 != 34U)
									{
										goto IL_016C;
									}
									bool flag = this.controllerActionBindingPrimary_ == null;
									if (flag)
									{
										this.ControllerActionBindingPrimary = new ControllerActionBinding();
									}
									input.ReadMessage(this.ControllerActionBindingPrimary);
								}
								else
								{
									bool flag2 = this.controllerActionBindingMap_ == null;
									if (flag2)
									{
										this.ControllerActionBindingMap = new ControllerActionBinding();
									}
									input.ReadMessage(this.ControllerActionBindingMap);
								}
							}
							else
							{
								bool flag3 = this.controllerActionBindingEquippables_ == null;
								if (flag3)
								{
									this.ControllerActionBindingEquippables = new ControllerActionBinding();
								}
								input.ReadMessage(this.ControllerActionBindingEquippables);
							}
						}
						else if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								if (num3 != 58U)
								{
									goto IL_016C;
								}
								bool flag4 = this.controllerActionBindingSkill2_ == null;
								if (flag4)
								{
									this.ControllerActionBindingSkill2 = new ControllerActionBinding();
								}
								input.ReadMessage(this.ControllerActionBindingSkill2);
							}
							else
							{
								bool flag5 = this.controllerActionBindingSkill1_ == null;
								if (flag5)
								{
									this.ControllerActionBindingSkill1 = new ControllerActionBinding();
								}
								input.ReadMessage(this.ControllerActionBindingSkill1);
							}
						}
						else
						{
							bool flag6 = this.controllerActionBindingSecondary_ == null;
							if (flag6)
							{
								this.ControllerActionBindingSecondary = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingSecondary);
						}
					}
					else if (num3 <= 82U)
					{
						if (num3 != 66U)
						{
							if (num3 != 74U)
							{
								if (num3 != 82U)
								{
									goto IL_016C;
								}
								bool flag7 = this.controllerActionBindingUseItem_ == null;
								if (flag7)
								{
									this.ControllerActionBindingUseItem = new ControllerActionBinding();
								}
								input.ReadMessage(this.ControllerActionBindingUseItem);
							}
							else
							{
								bool flag8 = this.controllerActionBindingSkill4_ == null;
								if (flag8)
								{
									this.ControllerActionBindingSkill4 = new ControllerActionBinding();
								}
								input.ReadMessage(this.ControllerActionBindingSkill4);
							}
						}
						else
						{
							bool flag9 = this.controllerActionBindingSkill3_ == null;
							if (flag9)
							{
								this.ControllerActionBindingSkill3 = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingSkill3);
						}
					}
					else if (num3 != 90U)
					{
						if (num3 != 98U)
						{
							if (num3 != 106U)
							{
								goto IL_016C;
							}
							bool flag10 = this.controllerActionBindingQuickResponse_ == null;
							if (flag10)
							{
								this.ControllerActionBindingQuickResponse = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingQuickResponse);
						}
						else
						{
							bool flag11 = this.controllerActionBindingShowItemLabels_ == null;
							if (flag11)
							{
								this.ControllerActionBindingShowItemLabels = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingShowItemLabels);
						}
					}
					else
					{
						bool flag12 = this.controllerActionBindingTargetLock_ == null;
						if (flag12)
						{
							this.ControllerActionBindingTargetLock = new ControllerActionBinding();
						}
						input.ReadMessage(this.ControllerActionBindingTargetLock);
					}
				}
				else if (num3 <= 154U)
				{
					if (num3 <= 130U)
					{
						if (num3 != 114U)
						{
							if (num3 != 122U)
							{
								if (num3 != 130U)
								{
									goto IL_016C;
								}
								bool flag13 = this.controllerActionBindingEvade_ == null;
								if (flag13)
								{
									this.ControllerActionBindingEvade = new ControllerActionBinding();
								}
								input.ReadMessage(this.ControllerActionBindingEvade);
							}
							else
							{
								bool flag14 = this.controllerActionBindingPushToTalk_ == null;
								if (flag14)
								{
									this.ControllerActionBindingPushToTalk = new ControllerActionBinding();
								}
								input.ReadMessage(this.ControllerActionBindingPushToTalk);
							}
						}
						else
						{
							bool flag15 = this.controllerActionBindingWheel_ == null;
							if (flag15)
							{
								this.ControllerActionBindingWheel = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingWheel);
						}
					}
					else if (num3 != 138U)
					{
						if (num3 != 146U)
						{
							if (num3 != 154U)
							{
								goto IL_016C;
							}
							bool flag16 = this.controllerActionBindingWheelPageForward_ == null;
							if (flag16)
							{
								this.ControllerActionBindingWheelPageForward = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingWheelPageForward);
						}
						else
						{
							bool flag17 = this.controllerActionBindingWheelPageBackward_ == null;
							if (flag17)
							{
								this.ControllerActionBindingWheelPageBackward = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingWheelPageBackward);
						}
					}
					else
					{
						bool flag18 = this.controllerActionBindingInteract_ == null;
						if (flag18)
						{
							this.ControllerActionBindingInteract = new ControllerActionBinding();
						}
						input.ReadMessage(this.ControllerActionBindingInteract);
					}
				}
				else if (num3 <= 178U)
				{
					if (num3 != 162U)
					{
						if (num3 != 170U)
						{
							if (num3 != 178U)
							{
								goto IL_016C;
							}
							bool flag19 = this.controllerActionBindingTownPortal_ == null;
							if (flag19)
							{
								this.ControllerActionBindingTownPortal = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingTownPortal);
						}
						else
						{
							bool flag20 = this.controllerActionBindingCycleTargetLock_ == null;
							if (flag20)
							{
								this.ControllerActionBindingCycleTargetLock = new ControllerActionBinding();
							}
							input.ReadMessage(this.ControllerActionBindingCycleTargetLock);
						}
					}
					else
					{
						bool flag21 = this.controllerActionBindingCombinedInteract_ == null;
						if (flag21)
						{
							this.ControllerActionBindingCombinedInteract = new ControllerActionBinding();
						}
						input.ReadMessage(this.ControllerActionBindingCombinedInteract);
					}
				}
				else if (num3 <= 194U)
				{
					if (num3 != 186U)
					{
						if (num3 != 194U)
						{
							goto IL_016C;
						}
						bool flag22 = this.controllerActionBindingTtsSkipCurrentUtterance_ == null;
						if (flag22)
						{
							this.ControllerActionBindingTtsSkipCurrentUtterance = new ControllerActionBinding();
						}
						input.ReadMessage(this.ControllerActionBindingTtsSkipCurrentUtterance);
					}
					else
					{
						bool flag23 = this.controllerActionBindingJoinSpeechToTextChat_ == null;
						if (flag23)
						{
							this.ControllerActionBindingJoinSpeechToTextChat = new ControllerActionBinding();
						}
						input.ReadMessage(this.ControllerActionBindingJoinSpeechToTextChat);
					}
				}
				else if (num3 != 202U)
				{
					if (num3 != 210U)
					{
						goto IL_016C;
					}
					bool flag24 = this.controllerActionBindingMount_ == null;
					if (flag24)
					{
						this.ControllerActionBindingMount = new ControllerActionBinding();
					}
					input.ReadMessage(this.ControllerActionBindingMount);
				}
				else
				{
					bool flag25 = this.controllerActionBindingTtsCancelAllUtterances_ == null;
					if (flag25)
					{
						this.ControllerActionBindingTtsCancelAllUtterances = new ControllerActionBinding();
					}
					input.ReadMessage(this.ControllerActionBindingTtsCancelAllUtterances);
				}
				continue;
				IL_016C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A86 RID: 2694
		private static readonly MessageParser<ControllerActionBindings> _parser = new MessageParser<ControllerActionBindings>(() => new ControllerActionBindings());

		// Token: 0x04000A87 RID: 2695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A88 RID: 2696
		public const int ControllerActionBindingEquippablesFieldNumber = 1;

		// Token: 0x04000A89 RID: 2697
		private ControllerActionBinding controllerActionBindingEquippables_;

		// Token: 0x04000A8A RID: 2698
		public const int ControllerActionBindingMapFieldNumber = 2;

		// Token: 0x04000A8B RID: 2699
		private ControllerActionBinding controllerActionBindingMap_;

		// Token: 0x04000A8C RID: 2700
		public const int ControllerActionBindingPrimaryFieldNumber = 4;

		// Token: 0x04000A8D RID: 2701
		private ControllerActionBinding controllerActionBindingPrimary_;

		// Token: 0x04000A8E RID: 2702
		public const int ControllerActionBindingSecondaryFieldNumber = 5;

		// Token: 0x04000A8F RID: 2703
		private ControllerActionBinding controllerActionBindingSecondary_;

		// Token: 0x04000A90 RID: 2704
		public const int ControllerActionBindingSkill1FieldNumber = 6;

		// Token: 0x04000A91 RID: 2705
		private ControllerActionBinding controllerActionBindingSkill1_;

		// Token: 0x04000A92 RID: 2706
		public const int ControllerActionBindingSkill2FieldNumber = 7;

		// Token: 0x04000A93 RID: 2707
		private ControllerActionBinding controllerActionBindingSkill2_;

		// Token: 0x04000A94 RID: 2708
		public const int ControllerActionBindingSkill3FieldNumber = 8;

		// Token: 0x04000A95 RID: 2709
		private ControllerActionBinding controllerActionBindingSkill3_;

		// Token: 0x04000A96 RID: 2710
		public const int ControllerActionBindingSkill4FieldNumber = 9;

		// Token: 0x04000A97 RID: 2711
		private ControllerActionBinding controllerActionBindingSkill4_;

		// Token: 0x04000A98 RID: 2712
		public const int ControllerActionBindingUseItemFieldNumber = 10;

		// Token: 0x04000A99 RID: 2713
		private ControllerActionBinding controllerActionBindingUseItem_;

		// Token: 0x04000A9A RID: 2714
		public const int ControllerActionBindingTargetLockFieldNumber = 11;

		// Token: 0x04000A9B RID: 2715
		private ControllerActionBinding controllerActionBindingTargetLock_;

		// Token: 0x04000A9C RID: 2716
		public const int ControllerActionBindingShowItemLabelsFieldNumber = 12;

		// Token: 0x04000A9D RID: 2717
		private ControllerActionBinding controllerActionBindingShowItemLabels_;

		// Token: 0x04000A9E RID: 2718
		public const int ControllerActionBindingQuickResponseFieldNumber = 13;

		// Token: 0x04000A9F RID: 2719
		private ControllerActionBinding controllerActionBindingQuickResponse_;

		// Token: 0x04000AA0 RID: 2720
		public const int ControllerActionBindingWheelFieldNumber = 14;

		// Token: 0x04000AA1 RID: 2721
		private ControllerActionBinding controllerActionBindingWheel_;

		// Token: 0x04000AA2 RID: 2722
		public const int ControllerActionBindingPushToTalkFieldNumber = 15;

		// Token: 0x04000AA3 RID: 2723
		private ControllerActionBinding controllerActionBindingPushToTalk_;

		// Token: 0x04000AA4 RID: 2724
		public const int ControllerActionBindingEvadeFieldNumber = 16;

		// Token: 0x04000AA5 RID: 2725
		private ControllerActionBinding controllerActionBindingEvade_;

		// Token: 0x04000AA6 RID: 2726
		public const int ControllerActionBindingInteractFieldNumber = 17;

		// Token: 0x04000AA7 RID: 2727
		private ControllerActionBinding controllerActionBindingInteract_;

		// Token: 0x04000AA8 RID: 2728
		public const int ControllerActionBindingWheelPageBackwardFieldNumber = 18;

		// Token: 0x04000AA9 RID: 2729
		private ControllerActionBinding controllerActionBindingWheelPageBackward_;

		// Token: 0x04000AAA RID: 2730
		public const int ControllerActionBindingWheelPageForwardFieldNumber = 19;

		// Token: 0x04000AAB RID: 2731
		private ControllerActionBinding controllerActionBindingWheelPageForward_;

		// Token: 0x04000AAC RID: 2732
		public const int ControllerActionBindingCombinedInteractFieldNumber = 20;

		// Token: 0x04000AAD RID: 2733
		private ControllerActionBinding controllerActionBindingCombinedInteract_;

		// Token: 0x04000AAE RID: 2734
		public const int ControllerActionBindingCycleTargetLockFieldNumber = 21;

		// Token: 0x04000AAF RID: 2735
		private ControllerActionBinding controllerActionBindingCycleTargetLock_;

		// Token: 0x04000AB0 RID: 2736
		public const int ControllerActionBindingTownPortalFieldNumber = 22;

		// Token: 0x04000AB1 RID: 2737
		private ControllerActionBinding controllerActionBindingTownPortal_;

		// Token: 0x04000AB2 RID: 2738
		public const int ControllerActionBindingJoinSpeechToTextChatFieldNumber = 23;

		// Token: 0x04000AB3 RID: 2739
		private ControllerActionBinding controllerActionBindingJoinSpeechToTextChat_;

		// Token: 0x04000AB4 RID: 2740
		public const int ControllerActionBindingTtsSkipCurrentUtteranceFieldNumber = 24;

		// Token: 0x04000AB5 RID: 2741
		private ControllerActionBinding controllerActionBindingTtsSkipCurrentUtterance_;

		// Token: 0x04000AB6 RID: 2742
		public const int ControllerActionBindingTtsCancelAllUtterancesFieldNumber = 25;

		// Token: 0x04000AB7 RID: 2743
		private ControllerActionBinding controllerActionBindingTtsCancelAllUtterances_;

		// Token: 0x04000AB8 RID: 2744
		public const int ControllerActionBindingMountFieldNumber = 26;

		// Token: 0x04000AB9 RID: 2745
		private ControllerActionBinding controllerActionBindingMount_;
	}
}
