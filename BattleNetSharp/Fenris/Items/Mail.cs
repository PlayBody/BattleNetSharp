using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200016B RID: 363
	public sealed class Mail : IMessage<Mail>, IMessage, IEquatable<Mail>, IDeepCloneable<Mail>, IBufferMessage
	{
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x00092F0C File Offset: 0x0009110C
		[DebuggerNonUserCode]
		public static MessageParser<Mail> Parser
		{
			get
			{
				return Mail._parser;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x00092F24 File Offset: 0x00091124
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x00092F48 File Offset: 0x00091148
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Mail.Descriptor;
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00092F5F File Offset: 0x0009115F
		[DebuggerNonUserCode]
		public Mail()
		{
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00092F6C File Offset: 0x0009116C
		[DebuggerNonUserCode]
		public Mail(Mail other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountTo_ = other.gameAccountTo_;
			this.gameAccountFrom_ = other.gameAccountFrom_;
			this.mailId_ = other.mailId_;
			this.title_ = other.title_;
			this.body_ = other.body_;
			this.status_ = other.status_;
			this.sendTime_ = other.sendTime_;
			this.attachments_ = ((other.attachments_ != null) ? other.attachments_.Clone() : null);
			this.partitionId_ = other.partitionId_;
			this.expireAt_ = other.expireAt_;
			this.heroId_ = other.heroId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00093034 File Offset: 0x00091234
		[DebuggerNonUserCode]
		public Mail Clone()
		{
			return new Mail(this);
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x0009304C File Offset: 0x0009124C
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x0009307D File Offset: 0x0009127D
		[DebuggerNonUserCode]
		public uint GameAccountTo
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountToDefaultValue;
				if (flag)
				{
					gameAccountToDefaultValue = this.gameAccountTo_;
				}
				else
				{
					gameAccountToDefaultValue = Mail.GameAccountToDefaultValue;
				}
				return gameAccountToDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountTo_ = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x00093098 File Offset: 0x00091298
		[DebuggerNonUserCode]
		public bool HasGameAccountTo
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x000930B5 File Offset: 0x000912B5
		[DebuggerNonUserCode]
		public void ClearGameAccountTo()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000930C8 File Offset: 0x000912C8
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x000930F9 File Offset: 0x000912F9
		[DebuggerNonUserCode]
		public uint GameAccountFrom
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint gameAccountFromDefaultValue;
				if (flag)
				{
					gameAccountFromDefaultValue = this.gameAccountFrom_;
				}
				else
				{
					gameAccountFromDefaultValue = Mail.GameAccountFromDefaultValue;
				}
				return gameAccountFromDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountFrom_ = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x00093114 File Offset: 0x00091314
		[DebuggerNonUserCode]
		public bool HasGameAccountFrom
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00093131 File Offset: 0x00091331
		[DebuggerNonUserCode]
		public void ClearGameAccountFrom()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x00093144 File Offset: 0x00091344
		// (set) Token: 0x060025DC RID: 9692 RVA: 0x00093165 File Offset: 0x00091365
		[DebuggerNonUserCode]
		public ByteString MailId
		{
			get
			{
				return this.mailId_ ?? Mail.MailIdDefaultValue;
			}
			set
			{
				this.mailId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x0009317C File Offset: 0x0009137C
		[DebuggerNonUserCode]
		public bool HasMailId
		{
			get
			{
				return this.mailId_ != null;
			}
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x0009319A File Offset: 0x0009139A
		[DebuggerNonUserCode]
		public void ClearMailId()
		{
			this.mailId_ = null;
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000931A4 File Offset: 0x000913A4
		// (set) Token: 0x060025E0 RID: 9696 RVA: 0x000931C5 File Offset: 0x000913C5
		[DebuggerNonUserCode]
		public string Title
		{
			get
			{
				return this.title_ ?? Mail.TitleDefaultValue;
			}
			set
			{
				this.title_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000931DC File Offset: 0x000913DC
		[DebuggerNonUserCode]
		public bool HasTitle
		{
			get
			{
				return this.title_ != null;
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000931F7 File Offset: 0x000913F7
		[DebuggerNonUserCode]
		public void ClearTitle()
		{
			this.title_ = null;
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x00093204 File Offset: 0x00091404
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x00093225 File Offset: 0x00091425
		[DebuggerNonUserCode]
		public string Body
		{
			get
			{
				return this.body_ ?? Mail.BodyDefaultValue;
			}
			set
			{
				this.body_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0009323C File Offset: 0x0009143C
		[DebuggerNonUserCode]
		public bool HasBody
		{
			get
			{
				return this.body_ != null;
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00093257 File Offset: 0x00091457
		[DebuggerNonUserCode]
		public void ClearBody()
		{
			this.body_ = null;
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x00093264 File Offset: 0x00091464
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x00093295 File Offset: 0x00091495
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = Mail.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.status_ = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000932B0 File Offset: 0x000914B0
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000932CD File Offset: 0x000914CD
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x000932E0 File Offset: 0x000914E0
		// (set) Token: 0x060025EC RID: 9708 RVA: 0x00093311 File Offset: 0x00091511
		[DebuggerNonUserCode]
		public ulong SendTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong sendTimeDefaultValue;
				if (flag)
				{
					sendTimeDefaultValue = this.sendTime_;
				}
				else
				{
					sendTimeDefaultValue = Mail.SendTimeDefaultValue;
				}
				return sendTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.sendTime_ = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x0009332C File Offset: 0x0009152C
		[DebuggerNonUserCode]
		public bool HasSendTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00093349 File Offset: 0x00091549
		[DebuggerNonUserCode]
		public void ClearSendTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x0009335C File Offset: 0x0009155C
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x00093374 File Offset: 0x00091574
		[DebuggerNonUserCode]
		public MailAttachments Attachments
		{
			get
			{
				return this.attachments_;
			}
			set
			{
				this.attachments_ = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x00093380 File Offset: 0x00091580
		// (set) Token: 0x060025F2 RID: 9714 RVA: 0x000933B2 File Offset: 0x000915B2
		[DebuggerNonUserCode]
		public uint PartitionId
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint partitionIdDefaultValue;
				if (flag)
				{
					partitionIdDefaultValue = this.partitionId_;
				}
				else
				{
					partitionIdDefaultValue = Mail.PartitionIdDefaultValue;
				}
				return partitionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.partitionId_ = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x000933CC File Offset: 0x000915CC
		[DebuggerNonUserCode]
		public bool HasPartitionId
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000933EA File Offset: 0x000915EA
		[DebuggerNonUserCode]
		public void ClearPartitionId()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x000933FC File Offset: 0x000915FC
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0009342E File Offset: 0x0009162E
		[DebuggerNonUserCode]
		public ulong ExpireAt
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				ulong expireAtDefaultValue;
				if (flag)
				{
					expireAtDefaultValue = this.expireAt_;
				}
				else
				{
					expireAtDefaultValue = Mail.ExpireAtDefaultValue;
				}
				return expireAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.expireAt_ = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x00093448 File Offset: 0x00091648
		[DebuggerNonUserCode]
		public bool HasExpireAt
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00093466 File Offset: 0x00091666
		[DebuggerNonUserCode]
		public void ClearExpireAt()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x00093478 File Offset: 0x00091678
		// (set) Token: 0x060025FA RID: 9722 RVA: 0x00093499 File Offset: 0x00091699
		[DebuggerNonUserCode]
		public ByteString HeroId
		{
			get
			{
				return this.heroId_ ?? Mail.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x000934B0 File Offset: 0x000916B0
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000934CE File Offset: 0x000916CE
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000934D8 File Offset: 0x000916D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Mail);
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000934F8 File Offset: 0x000916F8
		[DebuggerNonUserCode]
		public bool Equals(Mail other)
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
					bool flag4 = this.GameAccountTo != other.GameAccountTo;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountFrom != other.GameAccountFrom;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MailId != other.MailId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Title != other.Title;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Body != other.Body;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Status != other.Status;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SendTime != other.SendTime;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Attachments, other.Attachments);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.PartitionId != other.PartitionId;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.ExpireAt != other.ExpireAt;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.HeroId != other.HeroId;
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

		// Token: 0x060025FF RID: 9727 RVA: 0x0009367C File Offset: 0x0009187C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountTo = this.HasGameAccountTo;
			if (hasGameAccountTo)
			{
				num ^= this.GameAccountTo.GetHashCode();
			}
			bool hasGameAccountFrom = this.HasGameAccountFrom;
			if (hasGameAccountFrom)
			{
				num ^= this.GameAccountFrom.GetHashCode();
			}
			bool hasMailId = this.HasMailId;
			if (hasMailId)
			{
				num ^= this.MailId.GetHashCode();
			}
			bool hasTitle = this.HasTitle;
			if (hasTitle)
			{
				num ^= this.Title.GetHashCode();
			}
			bool hasBody = this.HasBody;
			if (hasBody)
			{
				num ^= this.Body.GetHashCode();
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			bool hasSendTime = this.HasSendTime;
			if (hasSendTime)
			{
				num ^= this.SendTime.GetHashCode();
			}
			bool flag = this.attachments_ != null;
			if (flag)
			{
				num ^= this.Attachments.GetHashCode();
			}
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				num ^= this.PartitionId.GetHashCode();
			}
			bool hasExpireAt = this.HasExpireAt;
			if (hasExpireAt)
			{
				num ^= this.ExpireAt.GetHashCode();
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000937E4 File Offset: 0x000919E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000937FC File Offset: 0x000919FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00093808 File Offset: 0x00091A08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountTo = this.HasGameAccountTo;
			if (hasGameAccountTo)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountTo);
			}
			bool hasGameAccountFrom = this.HasGameAccountFrom;
			if (hasGameAccountFrom)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameAccountFrom);
			}
			bool hasMailId = this.HasMailId;
			if (hasMailId)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.MailId);
			}
			bool hasTitle = this.HasTitle;
			if (hasTitle)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Title);
			}
			bool hasBody = this.HasBody;
			if (hasBody)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Body);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Status);
			}
			bool hasSendTime = this.HasSendTime;
			if (hasSendTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.SendTime);
			}
			bool flag = this.attachments_ != null;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Attachments);
			}
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PartitionId);
			}
			bool hasExpireAt = this.HasExpireAt;
			if (hasExpireAt)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.ExpireAt);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.HeroId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000939BC File Offset: 0x00091BBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountTo = this.HasGameAccountTo;
			if (hasGameAccountTo)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountTo);
			}
			bool hasGameAccountFrom = this.HasGameAccountFrom;
			if (hasGameAccountFrom)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountFrom);
			}
			bool hasMailId = this.HasMailId;
			if (hasMailId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MailId);
			}
			bool hasTitle = this.HasTitle;
			if (hasTitle)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Title);
			}
			bool hasBody = this.HasBody;
			if (hasBody)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Body);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			bool hasSendTime = this.HasSendTime;
			if (hasSendTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SendTime);
			}
			bool flag = this.attachments_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Attachments);
			}
			bool hasPartitionId = this.HasPartitionId;
			if (hasPartitionId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PartitionId);
			}
			bool hasExpireAt = this.HasExpireAt;
			if (hasExpireAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpireAt);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.HeroId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00093B3C File Offset: 0x00091D3C
		[DebuggerNonUserCode]
		public void MergeFrom(Mail other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountTo = other.HasGameAccountTo;
				if (hasGameAccountTo)
				{
					this.GameAccountTo = other.GameAccountTo;
				}
				bool hasGameAccountFrom = other.HasGameAccountFrom;
				if (hasGameAccountFrom)
				{
					this.GameAccountFrom = other.GameAccountFrom;
				}
				bool hasMailId = other.HasMailId;
				if (hasMailId)
				{
					this.MailId = other.MailId;
				}
				bool hasTitle = other.HasTitle;
				if (hasTitle)
				{
					this.Title = other.Title;
				}
				bool hasBody = other.HasBody;
				if (hasBody)
				{
					this.Body = other.Body;
				}
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				bool hasSendTime = other.HasSendTime;
				if (hasSendTime)
				{
					this.SendTime = other.SendTime;
				}
				bool flag2 = other.attachments_ != null;
				if (flag2)
				{
					bool flag3 = this.attachments_ == null;
					if (flag3)
					{
						this.Attachments = new MailAttachments();
					}
					this.Attachments.MergeFrom(other.Attachments);
				}
				bool hasPartitionId = other.HasPartitionId;
				if (hasPartitionId)
				{
					this.PartitionId = other.PartitionId;
				}
				bool hasExpireAt = other.HasExpireAt;
				if (hasExpireAt)
				{
					this.ExpireAt = other.ExpireAt;
				}
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00093CB7 File Offset: 0x00091EB7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00093CC4 File Offset: 0x00091EC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 42U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_0087;
							}
							this.GameAccountFrom = input.ReadUInt32();
						}
						else
						{
							this.GameAccountTo = input.ReadUInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							if (num3 != 42U)
							{
								goto IL_0087;
							}
							this.Body = input.ReadString();
						}
						else
						{
							this.Title = input.ReadString();
						}
					}
					else
					{
						this.MailId = input.ReadBytes();
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
								goto IL_0087;
							}
							bool flag = this.attachments_ == null;
							if (flag)
							{
								this.Attachments = new MailAttachments();
							}
							input.ReadMessage(this.Attachments);
						}
						else
						{
							this.SendTime = input.ReadUInt64();
						}
					}
					else
					{
						this.Status = input.ReadUInt32();
					}
				}
				else if (num3 != 72U)
				{
					if (num3 != 88U)
					{
						if (num3 != 98U)
						{
							goto IL_0087;
						}
						this.HeroId = input.ReadBytes();
					}
					else
					{
						this.ExpireAt = input.ReadUInt64();
					}
				}
				else
				{
					this.PartitionId = input.ReadUInt32();
				}
				continue;
				IL_0087:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040010B1 RID: 4273
		private static readonly MessageParser<Mail> _parser = new MessageParser<Mail>(() => new Mail());

		// Token: 0x040010B2 RID: 4274
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010B3 RID: 4275
		private int _hasBits0;

		// Token: 0x040010B4 RID: 4276
		public const int GameAccountToFieldNumber = 1;

		// Token: 0x040010B5 RID: 4277
		private static readonly uint GameAccountToDefaultValue = 0U;

		// Token: 0x040010B6 RID: 4278
		private uint gameAccountTo_;

		// Token: 0x040010B7 RID: 4279
		public const int GameAccountFromFieldNumber = 2;

		// Token: 0x040010B8 RID: 4280
		private static readonly uint GameAccountFromDefaultValue = 0U;

		// Token: 0x040010B9 RID: 4281
		private uint gameAccountFrom_;

		// Token: 0x040010BA RID: 4282
		public const int MailIdFieldNumber = 3;

		// Token: 0x040010BB RID: 4283
		private static readonly ByteString MailIdDefaultValue = ByteString.Empty;

		// Token: 0x040010BC RID: 4284
		private ByteString mailId_;

		// Token: 0x040010BD RID: 4285
		public const int TitleFieldNumber = 4;

		// Token: 0x040010BE RID: 4286
		private static readonly string TitleDefaultValue = "";

		// Token: 0x040010BF RID: 4287
		private string title_;

		// Token: 0x040010C0 RID: 4288
		public const int BodyFieldNumber = 5;

		// Token: 0x040010C1 RID: 4289
		private static readonly string BodyDefaultValue = "";

		// Token: 0x040010C2 RID: 4290
		private string body_;

		// Token: 0x040010C3 RID: 4291
		public const int StatusFieldNumber = 6;

		// Token: 0x040010C4 RID: 4292
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x040010C5 RID: 4293
		private uint status_;

		// Token: 0x040010C6 RID: 4294
		public const int SendTimeFieldNumber = 7;

		// Token: 0x040010C7 RID: 4295
		private static readonly ulong SendTimeDefaultValue = 0UL;

		// Token: 0x040010C8 RID: 4296
		private ulong sendTime_;

		// Token: 0x040010C9 RID: 4297
		public const int AttachmentsFieldNumber = 8;

		// Token: 0x040010CA RID: 4298
		private MailAttachments attachments_;

		// Token: 0x040010CB RID: 4299
		public const int PartitionIdFieldNumber = 9;

		// Token: 0x040010CC RID: 4300
		private static readonly uint PartitionIdDefaultValue = 0U;

		// Token: 0x040010CD RID: 4301
		private uint partitionId_;

		// Token: 0x040010CE RID: 4302
		public const int ExpireAtFieldNumber = 11;

		// Token: 0x040010CF RID: 4303
		private static readonly ulong ExpireAtDefaultValue = 0UL;

		// Token: 0x040010D0 RID: 4304
		private ulong expireAt_;

		// Token: 0x040010D1 RID: 4305
		public const int HeroIdFieldNumber = 12;

		// Token: 0x040010D2 RID: 4306
		private static readonly ByteString HeroIdDefaultValue = ByteString.Empty;

		// Token: 0x040010D3 RID: 4307
		private ByteString heroId_;
	}
}
