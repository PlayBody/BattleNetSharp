using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002AE RID: 686
	public sealed class ClanInvite : IMessage<ClanInvite>, IMessage, IEquatable<ClanInvite>, IDeepCloneable<ClanInvite>, IBufferMessage
	{
		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x00115FBC File Offset: 0x001141BC
		[DebuggerNonUserCode]
		public static MessageParser<ClanInvite> Parser
		{
			get
			{
				return ClanInvite._parser;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x00115FD4 File Offset: 0x001141D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x00115FF8 File Offset: 0x001141F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanInvite.Descriptor;
			}
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x0011600F File Offset: 0x0011420F
		[DebuggerNonUserCode]
		public ClanInvite()
		{
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x0011601C File Offset: 0x0011421C
		[DebuggerNonUserCode]
		public ClanInvite(ClanInvite other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.inviteeGameAccountId_ = other.inviteeGameAccountId_;
			this.inviterGameAccountId_ = other.inviterGameAccountId_;
			this.inviteeBnetAccountId_ = other.inviteeBnetAccountId_;
			this.inviterBnetAccountId_ = other.inviterBnetAccountId_;
			this.createdAt_ = other.createdAt_;
			this.clanName_ = other.clanName_;
			this.clanTag_ = other.clanTag_;
			this.heraldry_ = ((other.heraldry_ != null) ? other.heraldry_.Clone() : null);
			this.expiresAt_ = other.expiresAt_;
			this.isFromApplication_ = other.isFromApplication_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x001160E4 File Offset: 0x001142E4
		[DebuggerNonUserCode]
		public ClanInvite Clone()
		{
			return new ClanInvite(this);
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x001160FC File Offset: 0x001142FC
		// (set) Token: 0x060048A2 RID: 18594 RVA: 0x0011611D File Offset: 0x0011431D
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanInvite.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x00116134 File Offset: 0x00114334
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x0011614F File Offset: 0x0011434F
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x0011615C File Offset: 0x0011435C
		// (set) Token: 0x060048A6 RID: 18598 RVA: 0x0011618D File Offset: 0x0011438D
		[DebuggerNonUserCode]
		public uint InviteeGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint inviteeGameAccountIdDefaultValue;
				if (flag)
				{
					inviteeGameAccountIdDefaultValue = this.inviteeGameAccountId_;
				}
				else
				{
					inviteeGameAccountIdDefaultValue = ClanInvite.InviteeGameAccountIdDefaultValue;
				}
				return inviteeGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteeGameAccountId_ = value;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x060048A7 RID: 18599 RVA: 0x001161A8 File Offset: 0x001143A8
		[DebuggerNonUserCode]
		public bool HasInviteeGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x001161C5 File Offset: 0x001143C5
		[DebuggerNonUserCode]
		public void ClearInviteeGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x001161D8 File Offset: 0x001143D8
		// (set) Token: 0x060048AA RID: 18602 RVA: 0x00116209 File Offset: 0x00114409
		[DebuggerNonUserCode]
		public uint InviterGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint inviterGameAccountIdDefaultValue;
				if (flag)
				{
					inviterGameAccountIdDefaultValue = this.inviterGameAccountId_;
				}
				else
				{
					inviterGameAccountIdDefaultValue = ClanInvite.InviterGameAccountIdDefaultValue;
				}
				return inviterGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.inviterGameAccountId_ = value;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x060048AB RID: 18603 RVA: 0x00116224 File Offset: 0x00114424
		[DebuggerNonUserCode]
		public bool HasInviterGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00116241 File Offset: 0x00114441
		[DebuggerNonUserCode]
		public void ClearInviterGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x060048AD RID: 18605 RVA: 0x00116254 File Offset: 0x00114454
		// (set) Token: 0x060048AE RID: 18606 RVA: 0x00116286 File Offset: 0x00114486
		[DebuggerNonUserCode]
		public uint InviteeBnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint inviteeBnetAccountIdDefaultValue;
				if (flag)
				{
					inviteeBnetAccountIdDefaultValue = this.inviteeBnetAccountId_;
				}
				else
				{
					inviteeBnetAccountIdDefaultValue = ClanInvite.InviteeBnetAccountIdDefaultValue;
				}
				return inviteeBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.inviteeBnetAccountId_ = value;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x060048AF RID: 18607 RVA: 0x001162A0 File Offset: 0x001144A0
		[DebuggerNonUserCode]
		public bool HasInviteeBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x001162BE File Offset: 0x001144BE
		[DebuggerNonUserCode]
		public void ClearInviteeBnetAccountId()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x001162D0 File Offset: 0x001144D0
		// (set) Token: 0x060048B2 RID: 18610 RVA: 0x00116302 File Offset: 0x00114502
		[DebuggerNonUserCode]
		public uint InviterBnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint inviterBnetAccountIdDefaultValue;
				if (flag)
				{
					inviterBnetAccountIdDefaultValue = this.inviterBnetAccountId_;
				}
				else
				{
					inviterBnetAccountIdDefaultValue = ClanInvite.InviterBnetAccountIdDefaultValue;
				}
				return inviterBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.inviterBnetAccountId_ = value;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x0011631C File Offset: 0x0011451C
		[DebuggerNonUserCode]
		public bool HasInviterBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x0011633A File Offset: 0x0011453A
		[DebuggerNonUserCode]
		public void ClearInviterBnetAccountId()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x060048B5 RID: 18613 RVA: 0x0011634C File Offset: 0x0011454C
		// (set) Token: 0x060048B6 RID: 18614 RVA: 0x0011637D File Offset: 0x0011457D
		[DebuggerNonUserCode]
		public ulong CreatedAt
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong createdAtDefaultValue;
				if (flag)
				{
					createdAtDefaultValue = this.createdAt_;
				}
				else
				{
					createdAtDefaultValue = ClanInvite.CreatedAtDefaultValue;
				}
				return createdAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.createdAt_ = value;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x060048B7 RID: 18615 RVA: 0x00116398 File Offset: 0x00114598
		[DebuggerNonUserCode]
		public bool HasCreatedAt
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x001163B5 File Offset: 0x001145B5
		[DebuggerNonUserCode]
		public void ClearCreatedAt()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x060048B9 RID: 18617 RVA: 0x001163C8 File Offset: 0x001145C8
		// (set) Token: 0x060048BA RID: 18618 RVA: 0x001163E9 File Offset: 0x001145E9
		[DebuggerNonUserCode]
		public string ClanName
		{
			get
			{
				return this.clanName_ ?? ClanInvite.ClanNameDefaultValue;
			}
			set
			{
				this.clanName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x00116400 File Offset: 0x00114600
		[DebuggerNonUserCode]
		public bool HasClanName
		{
			get
			{
				return this.clanName_ != null;
			}
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x0011641B File Offset: 0x0011461B
		[DebuggerNonUserCode]
		public void ClearClanName()
		{
			this.clanName_ = null;
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x060048BD RID: 18621 RVA: 0x00116428 File Offset: 0x00114628
		// (set) Token: 0x060048BE RID: 18622 RVA: 0x00116449 File Offset: 0x00114649
		[DebuggerNonUserCode]
		public string ClanTag
		{
			get
			{
				return this.clanTag_ ?? ClanInvite.ClanTagDefaultValue;
			}
			set
			{
				this.clanTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x060048BF RID: 18623 RVA: 0x00116460 File Offset: 0x00114660
		[DebuggerNonUserCode]
		public bool HasClanTag
		{
			get
			{
				return this.clanTag_ != null;
			}
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x0011647B File Offset: 0x0011467B
		[DebuggerNonUserCode]
		public void ClearClanTag()
		{
			this.clanTag_ = null;
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x060048C1 RID: 18625 RVA: 0x00116488 File Offset: 0x00114688
		// (set) Token: 0x060048C2 RID: 18626 RVA: 0x001164A0 File Offset: 0x001146A0
		[DebuggerNonUserCode]
		public ClanHeraldry Heraldry
		{
			get
			{
				return this.heraldry_;
			}
			set
			{
				this.heraldry_ = value;
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x060048C3 RID: 18627 RVA: 0x001164AC File Offset: 0x001146AC
		// (set) Token: 0x060048C4 RID: 18628 RVA: 0x001164DD File Offset: 0x001146DD
		[DebuggerNonUserCode]
		public ulong ExpiresAt
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong expiresAtDefaultValue;
				if (flag)
				{
					expiresAtDefaultValue = this.expiresAt_;
				}
				else
				{
					expiresAtDefaultValue = ClanInvite.ExpiresAtDefaultValue;
				}
				return expiresAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.expiresAt_ = value;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x060048C5 RID: 18629 RVA: 0x001164F8 File Offset: 0x001146F8
		[DebuggerNonUserCode]
		public bool HasExpiresAt
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00116515 File Offset: 0x00114715
		[DebuggerNonUserCode]
		public void ClearExpiresAt()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x060048C7 RID: 18631 RVA: 0x00116528 File Offset: 0x00114728
		// (set) Token: 0x060048C8 RID: 18632 RVA: 0x0011655A File Offset: 0x0011475A
		[DebuggerNonUserCode]
		public bool IsFromApplication
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool isFromApplicationDefaultValue;
				if (flag)
				{
					isFromApplicationDefaultValue = this.isFromApplication_;
				}
				else
				{
					isFromApplicationDefaultValue = ClanInvite.IsFromApplicationDefaultValue;
				}
				return isFromApplicationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.isFromApplication_ = value;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x060048C9 RID: 18633 RVA: 0x00116574 File Offset: 0x00114774
		[DebuggerNonUserCode]
		public bool HasIsFromApplication
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00116592 File Offset: 0x00114792
		[DebuggerNonUserCode]
		public void ClearIsFromApplication()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x001165A4 File Offset: 0x001147A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanInvite);
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x001165C4 File Offset: 0x001147C4
		[DebuggerNonUserCode]
		public bool Equals(ClanInvite other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.InviteeGameAccountId != other.InviteeGameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InviterGameAccountId != other.InviterGameAccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.InviteeBnetAccountId != other.InviteeBnetAccountId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.InviterBnetAccountId != other.InviterBnetAccountId;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CreatedAt != other.CreatedAt;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ClanName != other.ClanName;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ClanTag != other.ClanTag;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.Heraldry, other.Heraldry);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.ExpiresAt != other.ExpiresAt;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.IsFromApplication != other.IsFromApplication;
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

		// Token: 0x060048CD RID: 18637 RVA: 0x00116748 File Offset: 0x00114948
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				num ^= this.InviteeGameAccountId.GetHashCode();
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				num ^= this.InviterGameAccountId.GetHashCode();
			}
			bool hasInviteeBnetAccountId = this.HasInviteeBnetAccountId;
			if (hasInviteeBnetAccountId)
			{
				num ^= this.InviteeBnetAccountId.GetHashCode();
			}
			bool hasInviterBnetAccountId = this.HasInviterBnetAccountId;
			if (hasInviterBnetAccountId)
			{
				num ^= this.InviterBnetAccountId.GetHashCode();
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num ^= this.CreatedAt.GetHashCode();
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num ^= this.ClanName.GetHashCode();
			}
			bool hasClanTag = this.HasClanTag;
			if (hasClanTag)
			{
				num ^= this.ClanTag.GetHashCode();
			}
			bool flag = this.heraldry_ != null;
			if (flag)
			{
				num ^= this.Heraldry.GetHashCode();
			}
			bool hasExpiresAt = this.HasExpiresAt;
			if (hasExpiresAt)
			{
				num ^= this.ExpiresAt.GetHashCode();
			}
			bool hasIsFromApplication = this.HasIsFromApplication;
			if (hasIsFromApplication)
			{
				num ^= this.IsFromApplication.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x001168B4 File Offset: 0x00114AB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x001168CC File Offset: 0x00114ACC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x001168D8 File Offset: 0x00114AD8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.InviteeGameAccountId);
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.InviterGameAccountId);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreatedAt);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ClanName);
			}
			bool flag = this.heraldry_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Heraldry);
			}
			bool hasExpiresAt = this.HasExpiresAt;
			if (hasExpiresAt)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.ExpiresAt);
			}
			bool hasInviteeBnetAccountId = this.HasInviteeBnetAccountId;
			if (hasInviteeBnetAccountId)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.InviteeBnetAccountId);
			}
			bool hasInviterBnetAccountId = this.HasInviterBnetAccountId;
			if (hasInviterBnetAccountId)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.InviterBnetAccountId);
			}
			bool hasIsFromApplication = this.HasIsFromApplication;
			if (hasIsFromApplication)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsFromApplication);
			}
			bool hasClanTag = this.HasClanTag;
			if (hasClanTag)
			{
				output.WriteRawTag(98);
				output.WriteString(this.ClanTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00116A8C File Offset: 0x00114C8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasInviteeGameAccountId = this.HasInviteeGameAccountId;
			if (hasInviteeGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviteeGameAccountId);
			}
			bool hasInviterGameAccountId = this.HasInviterGameAccountId;
			if (hasInviterGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviterGameAccountId);
			}
			bool hasInviteeBnetAccountId = this.HasInviteeBnetAccountId;
			if (hasInviteeBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviteeBnetAccountId);
			}
			bool hasInviterBnetAccountId = this.HasInviterBnetAccountId;
			if (hasInviterBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InviterBnetAccountId);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanName);
			}
			bool hasClanTag = this.HasClanTag;
			if (hasClanTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanTag);
			}
			bool flag = this.heraldry_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Heraldry);
			}
			bool hasExpiresAt = this.HasExpiresAt;
			if (hasExpiresAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpiresAt);
			}
			bool hasIsFromApplication = this.HasIsFromApplication;
			if (hasIsFromApplication)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00116C00 File Offset: 0x00114E00
		[DebuggerNonUserCode]
		public void MergeFrom(ClanInvite other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasInviteeGameAccountId = other.HasInviteeGameAccountId;
				if (hasInviteeGameAccountId)
				{
					this.InviteeGameAccountId = other.InviteeGameAccountId;
				}
				bool hasInviterGameAccountId = other.HasInviterGameAccountId;
				if (hasInviterGameAccountId)
				{
					this.InviterGameAccountId = other.InviterGameAccountId;
				}
				bool hasInviteeBnetAccountId = other.HasInviteeBnetAccountId;
				if (hasInviteeBnetAccountId)
				{
					this.InviteeBnetAccountId = other.InviteeBnetAccountId;
				}
				bool hasInviterBnetAccountId = other.HasInviterBnetAccountId;
				if (hasInviterBnetAccountId)
				{
					this.InviterBnetAccountId = other.InviterBnetAccountId;
				}
				bool hasCreatedAt = other.HasCreatedAt;
				if (hasCreatedAt)
				{
					this.CreatedAt = other.CreatedAt;
				}
				bool hasClanName = other.HasClanName;
				if (hasClanName)
				{
					this.ClanName = other.ClanName;
				}
				bool hasClanTag = other.HasClanTag;
				if (hasClanTag)
				{
					this.ClanTag = other.ClanTag;
				}
				bool flag2 = other.heraldry_ != null;
				if (flag2)
				{
					bool flag3 = this.heraldry_ == null;
					if (flag3)
					{
						this.Heraldry = new ClanHeraldry();
					}
					this.Heraldry.MergeFrom(other.Heraldry);
				}
				bool hasExpiresAt = other.HasExpiresAt;
				if (hasExpiresAt)
				{
					this.ExpiresAt = other.ExpiresAt;
				}
				bool hasIsFromApplication = other.HasIsFromApplication;
				if (hasIsFromApplication)
				{
					this.IsFromApplication = other.IsFromApplication;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00116D7B File Offset: 0x00114F7B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00116D88 File Offset: 0x00114F88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								goto IL_0088;
							}
							this.InviteeGameAccountId = input.ReadUInt32();
						}
						else
						{
							this.ClanId = input.ReadString();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 40U)
						{
							if (num3 != 50U)
							{
								goto IL_0088;
							}
							this.ClanName = input.ReadString();
						}
						else
						{
							this.CreatedAt = input.ReadUInt64();
						}
					}
					else
					{
						this.InviterGameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 58U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_0088;
							}
							this.InviteeBnetAccountId = input.ReadUInt32();
						}
						else
						{
							this.ExpiresAt = input.ReadUInt64();
						}
					}
					else
					{
						bool flag = this.heraldry_ == null;
						if (flag)
						{
							this.Heraldry = new ClanHeraldry();
						}
						input.ReadMessage(this.Heraldry);
					}
				}
				else if (num3 != 80U)
				{
					if (num3 != 88U)
					{
						if (num3 != 98U)
						{
							goto IL_0088;
						}
						this.ClanTag = input.ReadString();
					}
					else
					{
						this.IsFromApplication = input.ReadBool();
					}
				}
				else
				{
					this.InviterBnetAccountId = input.ReadUInt32();
				}
				continue;
				IL_0088:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400204E RID: 8270
		private static readonly MessageParser<ClanInvite> _parser = new MessageParser<ClanInvite>(() => new ClanInvite());

		// Token: 0x0400204F RID: 8271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002050 RID: 8272
		private int _hasBits0;

		// Token: 0x04002051 RID: 8273
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04002052 RID: 8274
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04002053 RID: 8275
		private string clanId_;

		// Token: 0x04002054 RID: 8276
		public const int InviteeGameAccountIdFieldNumber = 2;

		// Token: 0x04002055 RID: 8277
		private static readonly uint InviteeGameAccountIdDefaultValue = 0U;

		// Token: 0x04002056 RID: 8278
		private uint inviteeGameAccountId_;

		// Token: 0x04002057 RID: 8279
		public const int InviterGameAccountIdFieldNumber = 3;

		// Token: 0x04002058 RID: 8280
		private static readonly uint InviterGameAccountIdDefaultValue = 0U;

		// Token: 0x04002059 RID: 8281
		private uint inviterGameAccountId_;

		// Token: 0x0400205A RID: 8282
		public const int InviteeBnetAccountIdFieldNumber = 9;

		// Token: 0x0400205B RID: 8283
		private static readonly uint InviteeBnetAccountIdDefaultValue = 0U;

		// Token: 0x0400205C RID: 8284
		private uint inviteeBnetAccountId_;

		// Token: 0x0400205D RID: 8285
		public const int InviterBnetAccountIdFieldNumber = 10;

		// Token: 0x0400205E RID: 8286
		private static readonly uint InviterBnetAccountIdDefaultValue = 0U;

		// Token: 0x0400205F RID: 8287
		private uint inviterBnetAccountId_;

		// Token: 0x04002060 RID: 8288
		public const int CreatedAtFieldNumber = 5;

		// Token: 0x04002061 RID: 8289
		private static readonly ulong CreatedAtDefaultValue = 0UL;

		// Token: 0x04002062 RID: 8290
		private ulong createdAt_;

		// Token: 0x04002063 RID: 8291
		public const int ClanNameFieldNumber = 6;

		// Token: 0x04002064 RID: 8292
		private static readonly string ClanNameDefaultValue = "";

		// Token: 0x04002065 RID: 8293
		private string clanName_;

		// Token: 0x04002066 RID: 8294
		public const int ClanTagFieldNumber = 12;

		// Token: 0x04002067 RID: 8295
		private static readonly string ClanTagDefaultValue = "";

		// Token: 0x04002068 RID: 8296
		private string clanTag_;

		// Token: 0x04002069 RID: 8297
		public const int HeraldryFieldNumber = 7;

		// Token: 0x0400206A RID: 8298
		private ClanHeraldry heraldry_;

		// Token: 0x0400206B RID: 8299
		public const int ExpiresAtFieldNumber = 8;

		// Token: 0x0400206C RID: 8300
		private static readonly ulong ExpiresAtDefaultValue = 0UL;

		// Token: 0x0400206D RID: 8301
		private ulong expiresAt_;

		// Token: 0x0400206E RID: 8302
		public const int IsFromApplicationFieldNumber = 11;

		// Token: 0x0400206F RID: 8303
		private static readonly bool IsFromApplicationDefaultValue = false;

		// Token: 0x04002070 RID: 8304
		private bool isFromApplication_;
	}
}
