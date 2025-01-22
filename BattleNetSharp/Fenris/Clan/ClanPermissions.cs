using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002AB RID: 683
	public sealed class ClanPermissions : IMessage<ClanPermissions>, IMessage, IEquatable<ClanPermissions>, IDeepCloneable<ClanPermissions>, IBufferMessage
	{
		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x0011236C File Offset: 0x0011056C
		[DebuggerNonUserCode]
		public static MessageParser<ClanPermissions> Parser
		{
			get
			{
				return ClanPermissions._parser;
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x00112384 File Offset: 0x00110584
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x001123A8 File Offset: 0x001105A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanPermissions.Descriptor;
			}
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x001123BF File Offset: 0x001105BF
		[DebuggerNonUserCode]
		public ClanPermissions()
		{
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x001123CC File Offset: 0x001105CC
		[DebuggerNonUserCode]
		public ClanPermissions(ClanPermissions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.managementEditMotd_ = other.managementEditMotd_;
			this.managementEditSelfNote_ = other.managementEditSelfNote_;
			this.membershipManageApplications_ = other.membershipManageApplications_;
			this.membershipInvite_ = other.membershipInvite_;
			this.membershipPromote_ = other.membershipPromote_;
			this.membershipDemote_ = other.membershipDemote_;
			this.membershipKick_ = other.membershipKick_;
			this.membershipBan_ = other.membershipBan_;
			this.voiceMute_ = other.voiceMute_;
			this.voiceChat_ = other.voiceChat_;
			this.hoardManage_ = other.hoardManage_;
			this.hoardDeposit_ = other.hoardDeposit_;
			this.hoardWithdraw_ = other.hoardWithdraw_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x0011249C File Offset: 0x0011069C
		[DebuggerNonUserCode]
		public ClanPermissions Clone()
		{
			return new ClanPermissions(this);
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x001124B4 File Offset: 0x001106B4
		// (set) Token: 0x060047CE RID: 18382 RVA: 0x001124E5 File Offset: 0x001106E5
		[DebuggerNonUserCode]
		public ClanRank ManagementEditMotd
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ClanRank managementEditMotdDefaultValue;
				if (flag)
				{
					managementEditMotdDefaultValue = this.managementEditMotd_;
				}
				else
				{
					managementEditMotdDefaultValue = ClanPermissions.ManagementEditMotdDefaultValue;
				}
				return managementEditMotdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.managementEditMotd_ = value;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x00112500 File Offset: 0x00110700
		[DebuggerNonUserCode]
		public bool HasManagementEditMotd
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x0011251D File Offset: 0x0011071D
		[DebuggerNonUserCode]
		public void ClearManagementEditMotd()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x00112530 File Offset: 0x00110730
		// (set) Token: 0x060047D2 RID: 18386 RVA: 0x00112561 File Offset: 0x00110761
		[DebuggerNonUserCode]
		public ClanRank ManagementEditSelfNote
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ClanRank managementEditSelfNoteDefaultValue;
				if (flag)
				{
					managementEditSelfNoteDefaultValue = this.managementEditSelfNote_;
				}
				else
				{
					managementEditSelfNoteDefaultValue = ClanPermissions.ManagementEditSelfNoteDefaultValue;
				}
				return managementEditSelfNoteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.managementEditSelfNote_ = value;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x0011257C File Offset: 0x0011077C
		[DebuggerNonUserCode]
		public bool HasManagementEditSelfNote
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00112599 File Offset: 0x00110799
		[DebuggerNonUserCode]
		public void ClearManagementEditSelfNote()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x001125AC File Offset: 0x001107AC
		// (set) Token: 0x060047D6 RID: 18390 RVA: 0x001125DD File Offset: 0x001107DD
		[DebuggerNonUserCode]
		public ClanRank MembershipManageApplications
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ClanRank membershipManageApplicationsDefaultValue;
				if (flag)
				{
					membershipManageApplicationsDefaultValue = this.membershipManageApplications_;
				}
				else
				{
					membershipManageApplicationsDefaultValue = ClanPermissions.MembershipManageApplicationsDefaultValue;
				}
				return membershipManageApplicationsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.membershipManageApplications_ = value;
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x001125F8 File Offset: 0x001107F8
		[DebuggerNonUserCode]
		public bool HasMembershipManageApplications
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x00112615 File Offset: 0x00110815
		[DebuggerNonUserCode]
		public void ClearMembershipManageApplications()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x00112628 File Offset: 0x00110828
		// (set) Token: 0x060047DA RID: 18394 RVA: 0x00112659 File Offset: 0x00110859
		[DebuggerNonUserCode]
		public ClanRank MembershipInvite
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ClanRank membershipInviteDefaultValue;
				if (flag)
				{
					membershipInviteDefaultValue = this.membershipInvite_;
				}
				else
				{
					membershipInviteDefaultValue = ClanPermissions.MembershipInviteDefaultValue;
				}
				return membershipInviteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.membershipInvite_ = value;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x060047DB RID: 18395 RVA: 0x00112674 File Offset: 0x00110874
		[DebuggerNonUserCode]
		public bool HasMembershipInvite
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x00112691 File Offset: 0x00110891
		[DebuggerNonUserCode]
		public void ClearMembershipInvite()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x001126A4 File Offset: 0x001108A4
		// (set) Token: 0x060047DE RID: 18398 RVA: 0x001126D6 File Offset: 0x001108D6
		[DebuggerNonUserCode]
		public ClanRank MembershipPromote
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ClanRank membershipPromoteDefaultValue;
				if (flag)
				{
					membershipPromoteDefaultValue = this.membershipPromote_;
				}
				else
				{
					membershipPromoteDefaultValue = ClanPermissions.MembershipPromoteDefaultValue;
				}
				return membershipPromoteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.membershipPromote_ = value;
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x001126F0 File Offset: 0x001108F0
		[DebuggerNonUserCode]
		public bool HasMembershipPromote
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x0011270E File Offset: 0x0011090E
		[DebuggerNonUserCode]
		public void ClearMembershipPromote()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x00112720 File Offset: 0x00110920
		// (set) Token: 0x060047E2 RID: 18402 RVA: 0x00112752 File Offset: 0x00110952
		[DebuggerNonUserCode]
		public ClanRank MembershipDemote
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				ClanRank membershipDemoteDefaultValue;
				if (flag)
				{
					membershipDemoteDefaultValue = this.membershipDemote_;
				}
				else
				{
					membershipDemoteDefaultValue = ClanPermissions.MembershipDemoteDefaultValue;
				}
				return membershipDemoteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.membershipDemote_ = value;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x0011276C File Offset: 0x0011096C
		[DebuggerNonUserCode]
		public bool HasMembershipDemote
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x0011278A File Offset: 0x0011098A
		[DebuggerNonUserCode]
		public void ClearMembershipDemote()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x0011279C File Offset: 0x0011099C
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x001127CE File Offset: 0x001109CE
		[DebuggerNonUserCode]
		public ClanRank MembershipKick
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				ClanRank membershipKickDefaultValue;
				if (flag)
				{
					membershipKickDefaultValue = this.membershipKick_;
				}
				else
				{
					membershipKickDefaultValue = ClanPermissions.MembershipKickDefaultValue;
				}
				return membershipKickDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.membershipKick_ = value;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x001127E8 File Offset: 0x001109E8
		[DebuggerNonUserCode]
		public bool HasMembershipKick
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x00112806 File Offset: 0x00110A06
		[DebuggerNonUserCode]
		public void ClearMembershipKick()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x00112818 File Offset: 0x00110A18
		// (set) Token: 0x060047EA RID: 18410 RVA: 0x0011284D File Offset: 0x00110A4D
		[DebuggerNonUserCode]
		public ClanRank MembershipBan
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				ClanRank membershipBanDefaultValue;
				if (flag)
				{
					membershipBanDefaultValue = this.membershipBan_;
				}
				else
				{
					membershipBanDefaultValue = ClanPermissions.MembershipBanDefaultValue;
				}
				return membershipBanDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.membershipBan_ = value;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x0011286C File Offset: 0x00110A6C
		[DebuggerNonUserCode]
		public bool HasMembershipBan
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x0011288D File Offset: 0x00110A8D
		[DebuggerNonUserCode]
		public void ClearMembershipBan()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x001128A4 File Offset: 0x00110AA4
		// (set) Token: 0x060047EE RID: 18414 RVA: 0x001128D9 File Offset: 0x00110AD9
		[DebuggerNonUserCode]
		public ClanRank VoiceMute
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				ClanRank voiceMuteDefaultValue;
				if (flag)
				{
					voiceMuteDefaultValue = this.voiceMute_;
				}
				else
				{
					voiceMuteDefaultValue = ClanPermissions.VoiceMuteDefaultValue;
				}
				return voiceMuteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.voiceMute_ = value;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x001128F8 File Offset: 0x00110AF8
		[DebuggerNonUserCode]
		public bool HasVoiceMute
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x00112919 File Offset: 0x00110B19
		[DebuggerNonUserCode]
		public void ClearVoiceMute()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x00112930 File Offset: 0x00110B30
		// (set) Token: 0x060047F2 RID: 18418 RVA: 0x00112965 File Offset: 0x00110B65
		[DebuggerNonUserCode]
		public ClanRank VoiceChat
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				ClanRank voiceChatDefaultValue;
				if (flag)
				{
					voiceChatDefaultValue = this.voiceChat_;
				}
				else
				{
					voiceChatDefaultValue = ClanPermissions.VoiceChatDefaultValue;
				}
				return voiceChatDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.voiceChat_ = value;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x00112984 File Offset: 0x00110B84
		[DebuggerNonUserCode]
		public bool HasVoiceChat
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x001129A5 File Offset: 0x00110BA5
		[DebuggerNonUserCode]
		public void ClearVoiceChat()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x001129BC File Offset: 0x00110BBC
		// (set) Token: 0x060047F6 RID: 18422 RVA: 0x001129F1 File Offset: 0x00110BF1
		[DebuggerNonUserCode]
		public ClanRank HoardManage
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				ClanRank hoardManageDefaultValue;
				if (flag)
				{
					hoardManageDefaultValue = this.hoardManage_;
				}
				else
				{
					hoardManageDefaultValue = ClanPermissions.HoardManageDefaultValue;
				}
				return hoardManageDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.hoardManage_ = value;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x00112A10 File Offset: 0x00110C10
		[DebuggerNonUserCode]
		public bool HasHoardManage
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x00112A31 File Offset: 0x00110C31
		[DebuggerNonUserCode]
		public void ClearHoardManage()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x00112A48 File Offset: 0x00110C48
		// (set) Token: 0x060047FA RID: 18426 RVA: 0x00112A7D File Offset: 0x00110C7D
		[DebuggerNonUserCode]
		public ClanRank HoardDeposit
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				ClanRank hoardDepositDefaultValue;
				if (flag)
				{
					hoardDepositDefaultValue = this.hoardDeposit_;
				}
				else
				{
					hoardDepositDefaultValue = ClanPermissions.HoardDepositDefaultValue;
				}
				return hoardDepositDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.hoardDeposit_ = value;
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x00112A9C File Offset: 0x00110C9C
		[DebuggerNonUserCode]
		public bool HasHoardDeposit
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x00112ABD File Offset: 0x00110CBD
		[DebuggerNonUserCode]
		public void ClearHoardDeposit()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x00112AD4 File Offset: 0x00110CD4
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x00112B09 File Offset: 0x00110D09
		[DebuggerNonUserCode]
		public ClanRank HoardWithdraw
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				ClanRank hoardWithdrawDefaultValue;
				if (flag)
				{
					hoardWithdrawDefaultValue = this.hoardWithdraw_;
				}
				else
				{
					hoardWithdrawDefaultValue = ClanPermissions.HoardWithdrawDefaultValue;
				}
				return hoardWithdrawDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.hoardWithdraw_ = value;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x00112B28 File Offset: 0x00110D28
		[DebuggerNonUserCode]
		public bool HasHoardWithdraw
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x00112B49 File Offset: 0x00110D49
		[DebuggerNonUserCode]
		public void ClearHoardWithdraw()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x00112B60 File Offset: 0x00110D60
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanPermissions);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x00112B80 File Offset: 0x00110D80
		[DebuggerNonUserCode]
		public bool Equals(ClanPermissions other)
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
					bool flag4 = this.ManagementEditMotd != other.ManagementEditMotd;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ManagementEditSelfNote != other.ManagementEditSelfNote;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MembershipManageApplications != other.MembershipManageApplications;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MembershipInvite != other.MembershipInvite;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.MembershipPromote != other.MembershipPromote;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.MembershipDemote != other.MembershipDemote;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.MembershipKick != other.MembershipKick;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MembershipBan != other.MembershipBan;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.VoiceMute != other.VoiceMute;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.VoiceChat != other.VoiceChat;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.HoardManage != other.HoardManage;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.HoardDeposit != other.HoardDeposit;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.HoardWithdraw != other.HoardWithdraw;
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06004803 RID: 18435 RVA: 0x00112D3C File Offset: 0x00110F3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasManagementEditMotd = this.HasManagementEditMotd;
			if (hasManagementEditMotd)
			{
				num ^= this.ManagementEditMotd.GetHashCode();
			}
			bool hasManagementEditSelfNote = this.HasManagementEditSelfNote;
			if (hasManagementEditSelfNote)
			{
				num ^= this.ManagementEditSelfNote.GetHashCode();
			}
			bool hasMembershipManageApplications = this.HasMembershipManageApplications;
			if (hasMembershipManageApplications)
			{
				num ^= this.MembershipManageApplications.GetHashCode();
			}
			bool hasMembershipInvite = this.HasMembershipInvite;
			if (hasMembershipInvite)
			{
				num ^= this.MembershipInvite.GetHashCode();
			}
			bool hasMembershipPromote = this.HasMembershipPromote;
			if (hasMembershipPromote)
			{
				num ^= this.MembershipPromote.GetHashCode();
			}
			bool hasMembershipDemote = this.HasMembershipDemote;
			if (hasMembershipDemote)
			{
				num ^= this.MembershipDemote.GetHashCode();
			}
			bool hasMembershipKick = this.HasMembershipKick;
			if (hasMembershipKick)
			{
				num ^= this.MembershipKick.GetHashCode();
			}
			bool hasMembershipBan = this.HasMembershipBan;
			if (hasMembershipBan)
			{
				num ^= this.MembershipBan.GetHashCode();
			}
			bool hasVoiceMute = this.HasVoiceMute;
			if (hasVoiceMute)
			{
				num ^= this.VoiceMute.GetHashCode();
			}
			bool hasVoiceChat = this.HasVoiceChat;
			if (hasVoiceChat)
			{
				num ^= this.VoiceChat.GetHashCode();
			}
			bool hasHoardManage = this.HasHoardManage;
			if (hasHoardManage)
			{
				num ^= this.HoardManage.GetHashCode();
			}
			bool hasHoardDeposit = this.HasHoardDeposit;
			if (hasHoardDeposit)
			{
				num ^= this.HoardDeposit.GetHashCode();
			}
			bool hasHoardWithdraw = this.HasHoardWithdraw;
			if (hasHoardWithdraw)
			{
				num ^= this.HoardWithdraw.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x00112F38 File Offset: 0x00111138
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x00112F50 File Offset: 0x00111150
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x00112F5C File Offset: 0x0011115C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasManagementEditMotd = this.HasManagementEditMotd;
			if (hasManagementEditMotd)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ManagementEditMotd);
			}
			bool hasManagementEditSelfNote = this.HasManagementEditSelfNote;
			if (hasManagementEditSelfNote)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ManagementEditSelfNote);
			}
			bool hasMembershipManageApplications = this.HasMembershipManageApplications;
			if (hasMembershipManageApplications)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.MembershipManageApplications);
			}
			bool hasMembershipInvite = this.HasMembershipInvite;
			if (hasMembershipInvite)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.MembershipInvite);
			}
			bool hasMembershipPromote = this.HasMembershipPromote;
			if (hasMembershipPromote)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.MembershipPromote);
			}
			bool hasMembershipDemote = this.HasMembershipDemote;
			if (hasMembershipDemote)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.MembershipDemote);
			}
			bool hasMembershipKick = this.HasMembershipKick;
			if (hasMembershipKick)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.MembershipKick);
			}
			bool hasMembershipBan = this.HasMembershipBan;
			if (hasMembershipBan)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.MembershipBan);
			}
			bool hasVoiceMute = this.HasVoiceMute;
			if (hasVoiceMute)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.VoiceMute);
			}
			bool hasVoiceChat = this.HasVoiceChat;
			if (hasVoiceChat)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.VoiceChat);
			}
			bool hasHoardManage = this.HasHoardManage;
			if (hasHoardManage)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.HoardManage);
			}
			bool hasHoardDeposit = this.HasHoardDeposit;
			if (hasHoardDeposit)
			{
				output.WriteRawTag(128, 1);
				output.WriteEnum((int)this.HoardDeposit);
			}
			bool hasHoardWithdraw = this.HasHoardWithdraw;
			if (hasHoardWithdraw)
			{
				output.WriteRawTag(136, 1);
				output.WriteEnum((int)this.HoardWithdraw);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x0011315C File Offset: 0x0011135C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasManagementEditMotd = this.HasManagementEditMotd;
			if (hasManagementEditMotd)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ManagementEditMotd);
			}
			bool hasManagementEditSelfNote = this.HasManagementEditSelfNote;
			if (hasManagementEditSelfNote)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ManagementEditSelfNote);
			}
			bool hasMembershipManageApplications = this.HasMembershipManageApplications;
			if (hasMembershipManageApplications)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MembershipManageApplications);
			}
			bool hasMembershipInvite = this.HasMembershipInvite;
			if (hasMembershipInvite)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MembershipInvite);
			}
			bool hasMembershipPromote = this.HasMembershipPromote;
			if (hasMembershipPromote)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MembershipPromote);
			}
			bool hasMembershipDemote = this.HasMembershipDemote;
			if (hasMembershipDemote)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MembershipDemote);
			}
			bool hasMembershipKick = this.HasMembershipKick;
			if (hasMembershipKick)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MembershipKick);
			}
			bool hasMembershipBan = this.HasMembershipBan;
			if (hasMembershipBan)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MembershipBan);
			}
			bool hasVoiceMute = this.HasVoiceMute;
			if (hasVoiceMute)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.VoiceMute);
			}
			bool hasVoiceChat = this.HasVoiceChat;
			if (hasVoiceChat)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.VoiceChat);
			}
			bool hasHoardManage = this.HasHoardManage;
			if (hasHoardManage)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.HoardManage);
			}
			bool hasHoardDeposit = this.HasHoardDeposit;
			if (hasHoardDeposit)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.HoardDeposit);
			}
			bool hasHoardWithdraw = this.HasHoardWithdraw;
			if (hasHoardWithdraw)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.HoardWithdraw);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x00113314 File Offset: 0x00111514
		[DebuggerNonUserCode]
		public void MergeFrom(ClanPermissions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasManagementEditMotd = other.HasManagementEditMotd;
				if (hasManagementEditMotd)
				{
					this.ManagementEditMotd = other.ManagementEditMotd;
				}
				bool hasManagementEditSelfNote = other.HasManagementEditSelfNote;
				if (hasManagementEditSelfNote)
				{
					this.ManagementEditSelfNote = other.ManagementEditSelfNote;
				}
				bool hasMembershipManageApplications = other.HasMembershipManageApplications;
				if (hasMembershipManageApplications)
				{
					this.MembershipManageApplications = other.MembershipManageApplications;
				}
				bool hasMembershipInvite = other.HasMembershipInvite;
				if (hasMembershipInvite)
				{
					this.MembershipInvite = other.MembershipInvite;
				}
				bool hasMembershipPromote = other.HasMembershipPromote;
				if (hasMembershipPromote)
				{
					this.MembershipPromote = other.MembershipPromote;
				}
				bool hasMembershipDemote = other.HasMembershipDemote;
				if (hasMembershipDemote)
				{
					this.MembershipDemote = other.MembershipDemote;
				}
				bool hasMembershipKick = other.HasMembershipKick;
				if (hasMembershipKick)
				{
					this.MembershipKick = other.MembershipKick;
				}
				bool hasMembershipBan = other.HasMembershipBan;
				if (hasMembershipBan)
				{
					this.MembershipBan = other.MembershipBan;
				}
				bool hasVoiceMute = other.HasVoiceMute;
				if (hasVoiceMute)
				{
					this.VoiceMute = other.VoiceMute;
				}
				bool hasVoiceChat = other.HasVoiceChat;
				if (hasVoiceChat)
				{
					this.VoiceChat = other.VoiceChat;
				}
				bool hasHoardManage = other.HasHoardManage;
				if (hasHoardManage)
				{
					this.HoardManage = other.HoardManage;
				}
				bool hasHoardDeposit = other.HasHoardDeposit;
				if (hasHoardDeposit)
				{
					this.HoardDeposit = other.HoardDeposit;
				}
				bool hasHoardWithdraw = other.HasHoardWithdraw;
				if (hasHoardWithdraw)
				{
					this.HoardWithdraw = other.HoardWithdraw;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x001134A0 File Offset: 0x001116A0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x001134AC File Offset: 0x001116AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 64U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 24U)
								{
									goto IL_00A6;
								}
								this.MembershipManageApplications = (ClanRank)input.ReadEnum();
							}
							else
							{
								this.ManagementEditSelfNote = (ClanRank)input.ReadEnum();
							}
						}
						else
						{
							this.ManagementEditMotd = (ClanRank)input.ReadEnum();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 56U)
						{
							if (num3 != 64U)
							{
								goto IL_00A6;
							}
							this.MembershipDemote = (ClanRank)input.ReadEnum();
						}
						else
						{
							this.MembershipPromote = (ClanRank)input.ReadEnum();
						}
					}
					else
					{
						this.MembershipInvite = (ClanRank)input.ReadEnum();
					}
				}
				else if (num3 <= 104U)
				{
					if (num3 != 72U)
					{
						if (num3 != 80U)
						{
							if (num3 != 104U)
							{
								goto IL_00A6;
							}
							this.VoiceMute = (ClanRank)input.ReadEnum();
						}
						else
						{
							this.MembershipBan = (ClanRank)input.ReadEnum();
						}
					}
					else
					{
						this.MembershipKick = (ClanRank)input.ReadEnum();
					}
				}
				else if (num3 <= 120U)
				{
					if (num3 != 112U)
					{
						if (num3 != 120U)
						{
							goto IL_00A6;
						}
						this.HoardManage = (ClanRank)input.ReadEnum();
					}
					else
					{
						this.VoiceChat = (ClanRank)input.ReadEnum();
					}
				}
				else if (num3 != 128U)
				{
					if (num3 != 136U)
					{
						goto IL_00A6;
					}
					this.HoardWithdraw = (ClanRank)input.ReadEnum();
				}
				else
				{
					this.HoardDeposit = (ClanRank)input.ReadEnum();
				}
				continue;
				IL_00A6:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FC9 RID: 8137
		private static readonly MessageParser<ClanPermissions> _parser = new MessageParser<ClanPermissions>(() => new ClanPermissions());

		// Token: 0x04001FCA RID: 8138
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FCB RID: 8139
		private int _hasBits0;

		// Token: 0x04001FCC RID: 8140
		public const int ManagementEditMotdFieldNumber = 1;

		// Token: 0x04001FCD RID: 8141
		private static readonly ClanRank ManagementEditMotdDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FCE RID: 8142
		private ClanRank managementEditMotd_;

		// Token: 0x04001FCF RID: 8143
		public const int ManagementEditSelfNoteFieldNumber = 2;

		// Token: 0x04001FD0 RID: 8144
		private static readonly ClanRank ManagementEditSelfNoteDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FD1 RID: 8145
		private ClanRank managementEditSelfNote_;

		// Token: 0x04001FD2 RID: 8146
		public const int MembershipManageApplicationsFieldNumber = 3;

		// Token: 0x04001FD3 RID: 8147
		private static readonly ClanRank MembershipManageApplicationsDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FD4 RID: 8148
		private ClanRank membershipManageApplications_;

		// Token: 0x04001FD5 RID: 8149
		public const int MembershipInviteFieldNumber = 4;

		// Token: 0x04001FD6 RID: 8150
		private static readonly ClanRank MembershipInviteDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FD7 RID: 8151
		private ClanRank membershipInvite_;

		// Token: 0x04001FD8 RID: 8152
		public const int MembershipPromoteFieldNumber = 7;

		// Token: 0x04001FD9 RID: 8153
		private static readonly ClanRank MembershipPromoteDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FDA RID: 8154
		private ClanRank membershipPromote_;

		// Token: 0x04001FDB RID: 8155
		public const int MembershipDemoteFieldNumber = 8;

		// Token: 0x04001FDC RID: 8156
		private static readonly ClanRank MembershipDemoteDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FDD RID: 8157
		private ClanRank membershipDemote_;

		// Token: 0x04001FDE RID: 8158
		public const int MembershipKickFieldNumber = 9;

		// Token: 0x04001FDF RID: 8159
		private static readonly ClanRank MembershipKickDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FE0 RID: 8160
		private ClanRank membershipKick_;

		// Token: 0x04001FE1 RID: 8161
		public const int MembershipBanFieldNumber = 10;

		// Token: 0x04001FE2 RID: 8162
		private static readonly ClanRank MembershipBanDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FE3 RID: 8163
		private ClanRank membershipBan_;

		// Token: 0x04001FE4 RID: 8164
		public const int VoiceMuteFieldNumber = 13;

		// Token: 0x04001FE5 RID: 8165
		private static readonly ClanRank VoiceMuteDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FE6 RID: 8166
		private ClanRank voiceMute_;

		// Token: 0x04001FE7 RID: 8167
		public const int VoiceChatFieldNumber = 14;

		// Token: 0x04001FE8 RID: 8168
		private static readonly ClanRank VoiceChatDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FE9 RID: 8169
		private ClanRank voiceChat_;

		// Token: 0x04001FEA RID: 8170
		public const int HoardManageFieldNumber = 15;

		// Token: 0x04001FEB RID: 8171
		private static readonly ClanRank HoardManageDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FEC RID: 8172
		private ClanRank hoardManage_;

		// Token: 0x04001FED RID: 8173
		public const int HoardDepositFieldNumber = 16;

		// Token: 0x04001FEE RID: 8174
		private static readonly ClanRank HoardDepositDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FEF RID: 8175
		private ClanRank hoardDeposit_;

		// Token: 0x04001FF0 RID: 8176
		public const int HoardWithdrawFieldNumber = 17;

		// Token: 0x04001FF1 RID: 8177
		private static readonly ClanRank HoardWithdrawDefaultValue = ClanRank.Invalid;

		// Token: 0x04001FF2 RID: 8178
		private ClanRank hoardWithdraw_;
	}
}
