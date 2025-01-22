using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000740 RID: 1856
	public sealed class ParentalControlInfo : IMessage<ParentalControlInfo>, IMessage, IEquatable<ParentalControlInfo>, IDeepCloneable<ParentalControlInfo>, IBufferMessage
	{
		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600AA60 RID: 43616 RVA: 0x0029816C File Offset: 0x0029636C
		[DebuggerNonUserCode]
		public static MessageParser<ParentalControlInfo> Parser
		{
			get
			{
				return ParentalControlInfo._parser;
			}
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600AA61 RID: 43617 RVA: 0x00298184 File Offset: 0x00296384
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600AA62 RID: 43618 RVA: 0x002981A8 File Offset: 0x002963A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParentalControlInfo.Descriptor;
			}
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x002981BF File Offset: 0x002963BF
		[DebuggerNonUserCode]
		public ParentalControlInfo()
		{
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x002981D4 File Offset: 0x002963D4
		[DebuggerNonUserCode]
		public ParentalControlInfo(ParentalControlInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.timezone_ = other.timezone_;
			this.minutesPerDay_ = other.minutesPerDay_;
			this.minutesPerWeek_ = other.minutesPerWeek_;
			this.canReceiveVoice_ = other.canReceiveVoice_;
			this.canSendVoice_ = other.canSendVoice_;
			this.playSchedule_ = other.playSchedule_.Clone();
			this.canJoinGroup_ = other.canJoinGroup_;
			this.canUseProfile_ = other.canUseProfile_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x0029826C File Offset: 0x0029646C
		[DebuggerNonUserCode]
		public ParentalControlInfo Clone()
		{
			return new ParentalControlInfo(this);
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0600AA66 RID: 43622 RVA: 0x00298284 File Offset: 0x00296484
		// (set) Token: 0x0600AA67 RID: 43623 RVA: 0x002982A5 File Offset: 0x002964A5
		[DebuggerNonUserCode]
		public string Timezone
		{
			get
			{
				return this.timezone_ ?? ParentalControlInfo.TimezoneDefaultValue;
			}
			set
			{
				this.timezone_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600AA68 RID: 43624 RVA: 0x002982BC File Offset: 0x002964BC
		[DebuggerNonUserCode]
		public bool HasTimezone
		{
			get
			{
				return this.timezone_ != null;
			}
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x002982D7 File Offset: 0x002964D7
		[DebuggerNonUserCode]
		public void ClearTimezone()
		{
			this.timezone_ = null;
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600AA6A RID: 43626 RVA: 0x002982E4 File Offset: 0x002964E4
		// (set) Token: 0x0600AA6B RID: 43627 RVA: 0x00298315 File Offset: 0x00296515
		[DebuggerNonUserCode]
		public uint MinutesPerDay
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint minutesPerDayDefaultValue;
				if (flag)
				{
					minutesPerDayDefaultValue = this.minutesPerDay_;
				}
				else
				{
					minutesPerDayDefaultValue = ParentalControlInfo.MinutesPerDayDefaultValue;
				}
				return minutesPerDayDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.minutesPerDay_ = value;
			}
		}

		// Token: 0x170034A2 RID: 13474
		// (get) Token: 0x0600AA6C RID: 43628 RVA: 0x00298330 File Offset: 0x00296530
		[DebuggerNonUserCode]
		public bool HasMinutesPerDay
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x0029834D File Offset: 0x0029654D
		[DebuggerNonUserCode]
		public void ClearMinutesPerDay()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034A3 RID: 13475
		// (get) Token: 0x0600AA6E RID: 43630 RVA: 0x00298360 File Offset: 0x00296560
		// (set) Token: 0x0600AA6F RID: 43631 RVA: 0x00298391 File Offset: 0x00296591
		[DebuggerNonUserCode]
		public uint MinutesPerWeek
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint minutesPerWeekDefaultValue;
				if (flag)
				{
					minutesPerWeekDefaultValue = this.minutesPerWeek_;
				}
				else
				{
					minutesPerWeekDefaultValue = ParentalControlInfo.MinutesPerWeekDefaultValue;
				}
				return minutesPerWeekDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.minutesPerWeek_ = value;
			}
		}

		// Token: 0x170034A4 RID: 13476
		// (get) Token: 0x0600AA70 RID: 43632 RVA: 0x002983AC File Offset: 0x002965AC
		[DebuggerNonUserCode]
		public bool HasMinutesPerWeek
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x002983C9 File Offset: 0x002965C9
		[DebuggerNonUserCode]
		public void ClearMinutesPerWeek()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x0600AA72 RID: 43634 RVA: 0x002983DC File Offset: 0x002965DC
		// (set) Token: 0x0600AA73 RID: 43635 RVA: 0x0029840D File Offset: 0x0029660D
		[DebuggerNonUserCode]
		public bool CanReceiveVoice
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool canReceiveVoiceDefaultValue;
				if (flag)
				{
					canReceiveVoiceDefaultValue = this.canReceiveVoice_;
				}
				else
				{
					canReceiveVoiceDefaultValue = ParentalControlInfo.CanReceiveVoiceDefaultValue;
				}
				return canReceiveVoiceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.canReceiveVoice_ = value;
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x0600AA74 RID: 43636 RVA: 0x00298428 File Offset: 0x00296628
		[DebuggerNonUserCode]
		public bool HasCanReceiveVoice
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x00298445 File Offset: 0x00296645
		[DebuggerNonUserCode]
		public void ClearCanReceiveVoice()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x0600AA76 RID: 43638 RVA: 0x00298458 File Offset: 0x00296658
		// (set) Token: 0x0600AA77 RID: 43639 RVA: 0x00298489 File Offset: 0x00296689
		[DebuggerNonUserCode]
		public bool CanSendVoice
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool canSendVoiceDefaultValue;
				if (flag)
				{
					canSendVoiceDefaultValue = this.canSendVoice_;
				}
				else
				{
					canSendVoiceDefaultValue = ParentalControlInfo.CanSendVoiceDefaultValue;
				}
				return canSendVoiceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.canSendVoice_ = value;
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600AA78 RID: 43640 RVA: 0x002984A4 File Offset: 0x002966A4
		[DebuggerNonUserCode]
		public bool HasCanSendVoice
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x002984C1 File Offset: 0x002966C1
		[DebuggerNonUserCode]
		public void ClearCanSendVoice()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600AA7A RID: 43642 RVA: 0x002984D4 File Offset: 0x002966D4
		[DebuggerNonUserCode]
		public RepeatedField<bool> PlaySchedule
		{
			get
			{
				return this.playSchedule_;
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600AA7B RID: 43643 RVA: 0x002984EC File Offset: 0x002966EC
		// (set) Token: 0x0600AA7C RID: 43644 RVA: 0x0029851E File Offset: 0x0029671E
		[DebuggerNonUserCode]
		public bool CanJoinGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool canJoinGroupDefaultValue;
				if (flag)
				{
					canJoinGroupDefaultValue = this.canJoinGroup_;
				}
				else
				{
					canJoinGroupDefaultValue = ParentalControlInfo.CanJoinGroupDefaultValue;
				}
				return canJoinGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.canJoinGroup_ = value;
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600AA7D RID: 43645 RVA: 0x00298538 File Offset: 0x00296738
		[DebuggerNonUserCode]
		public bool HasCanJoinGroup
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x00298556 File Offset: 0x00296756
		[DebuggerNonUserCode]
		public void ClearCanJoinGroup()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600AA7F RID: 43647 RVA: 0x00298568 File Offset: 0x00296768
		// (set) Token: 0x0600AA80 RID: 43648 RVA: 0x0029859A File Offset: 0x0029679A
		[DebuggerNonUserCode]
		public bool CanUseProfile
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool canUseProfileDefaultValue;
				if (flag)
				{
					canUseProfileDefaultValue = this.canUseProfile_;
				}
				else
				{
					canUseProfileDefaultValue = ParentalControlInfo.CanUseProfileDefaultValue;
				}
				return canUseProfileDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.canUseProfile_ = value;
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600AA81 RID: 43649 RVA: 0x002985B4 File Offset: 0x002967B4
		[DebuggerNonUserCode]
		public bool HasCanUseProfile
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600AA82 RID: 43650 RVA: 0x002985D2 File Offset: 0x002967D2
		[DebuggerNonUserCode]
		public void ClearCanUseProfile()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x002985E4 File Offset: 0x002967E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParentalControlInfo);
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x00298604 File Offset: 0x00296804
		[DebuggerNonUserCode]
		public bool Equals(ParentalControlInfo other)
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
					bool flag4 = this.Timezone != other.Timezone;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MinutesPerDay != other.MinutesPerDay;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MinutesPerWeek != other.MinutesPerWeek;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CanReceiveVoice != other.CanReceiveVoice;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CanSendVoice != other.CanSendVoice;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.playSchedule_.Equals(other.playSchedule_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.CanJoinGroup != other.CanJoinGroup;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CanUseProfile != other.CanUseProfile;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600AA85 RID: 43653 RVA: 0x0029872C File Offset: 0x0029692C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num ^= this.Timezone.GetHashCode();
			}
			bool hasMinutesPerDay = this.HasMinutesPerDay;
			if (hasMinutesPerDay)
			{
				num ^= this.MinutesPerDay.GetHashCode();
			}
			bool hasMinutesPerWeek = this.HasMinutesPerWeek;
			if (hasMinutesPerWeek)
			{
				num ^= this.MinutesPerWeek.GetHashCode();
			}
			bool hasCanReceiveVoice = this.HasCanReceiveVoice;
			if (hasCanReceiveVoice)
			{
				num ^= this.CanReceiveVoice.GetHashCode();
			}
			bool hasCanSendVoice = this.HasCanSendVoice;
			if (hasCanSendVoice)
			{
				num ^= this.CanSendVoice.GetHashCode();
			}
			num ^= this.playSchedule_.GetHashCode();
			bool hasCanJoinGroup = this.HasCanJoinGroup;
			if (hasCanJoinGroup)
			{
				num ^= this.CanJoinGroup.GetHashCode();
			}
			bool hasCanUseProfile = this.HasCanUseProfile;
			if (hasCanUseProfile)
			{
				num ^= this.CanUseProfile.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x00298838 File Offset: 0x00296A38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AA87 RID: 43655 RVA: 0x00298850 File Offset: 0x00296A50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x0029885C File Offset: 0x00296A5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Timezone);
			}
			bool hasMinutesPerDay = this.HasMinutesPerDay;
			if (hasMinutesPerDay)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MinutesPerDay);
			}
			bool hasMinutesPerWeek = this.HasMinutesPerWeek;
			if (hasMinutesPerWeek)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MinutesPerWeek);
			}
			bool hasCanReceiveVoice = this.HasCanReceiveVoice;
			if (hasCanReceiveVoice)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.CanReceiveVoice);
			}
			bool hasCanSendVoice = this.HasCanSendVoice;
			if (hasCanSendVoice)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.CanSendVoice);
			}
			this.playSchedule_.WriteTo(ref output, ParentalControlInfo._repeated_playSchedule_codec);
			bool hasCanJoinGroup = this.HasCanJoinGroup;
			if (hasCanJoinGroup)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.CanJoinGroup);
			}
			bool hasCanUseProfile = this.HasCanUseProfile;
			if (hasCanUseProfile)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.CanUseProfile);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA89 RID: 43657 RVA: 0x00298990 File Offset: 0x00296B90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Timezone);
			}
			bool hasMinutesPerDay = this.HasMinutesPerDay;
			if (hasMinutesPerDay)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinutesPerDay);
			}
			bool hasMinutesPerWeek = this.HasMinutesPerWeek;
			if (hasMinutesPerWeek)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinutesPerWeek);
			}
			bool hasCanReceiveVoice = this.HasCanReceiveVoice;
			if (hasCanReceiveVoice)
			{
				num += 2;
			}
			bool hasCanSendVoice = this.HasCanSendVoice;
			if (hasCanSendVoice)
			{
				num += 2;
			}
			num += this.playSchedule_.CalculateSize(ParentalControlInfo._repeated_playSchedule_codec);
			bool hasCanJoinGroup = this.HasCanJoinGroup;
			if (hasCanJoinGroup)
			{
				num += 2;
			}
			bool hasCanUseProfile = this.HasCanUseProfile;
			if (hasCanUseProfile)
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

		// Token: 0x0600AA8A RID: 43658 RVA: 0x00298A78 File Offset: 0x00296C78
		[DebuggerNonUserCode]
		public void MergeFrom(ParentalControlInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTimezone = other.HasTimezone;
				if (hasTimezone)
				{
					this.Timezone = other.Timezone;
				}
				bool hasMinutesPerDay = other.HasMinutesPerDay;
				if (hasMinutesPerDay)
				{
					this.MinutesPerDay = other.MinutesPerDay;
				}
				bool hasMinutesPerWeek = other.HasMinutesPerWeek;
				if (hasMinutesPerWeek)
				{
					this.MinutesPerWeek = other.MinutesPerWeek;
				}
				bool hasCanReceiveVoice = other.HasCanReceiveVoice;
				if (hasCanReceiveVoice)
				{
					this.CanReceiveVoice = other.CanReceiveVoice;
				}
				bool hasCanSendVoice = other.HasCanSendVoice;
				if (hasCanSendVoice)
				{
					this.CanSendVoice = other.CanSendVoice;
				}
				this.playSchedule_.Add(other.playSchedule_);
				bool hasCanJoinGroup = other.HasCanJoinGroup;
				if (hasCanJoinGroup)
				{
					this.CanJoinGroup = other.CanJoinGroup;
				}
				bool hasCanUseProfile = other.HasCanUseProfile;
				if (hasCanUseProfile)
				{
					this.CanUseProfile = other.CanUseProfile;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x00298B74 File Offset: 0x00296D74
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x00298B80 File Offset: 0x00296D80
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
					if (num3 <= 32U)
					{
						if (num3 != 26U)
						{
							if (num3 != 32U)
							{
								goto IL_0062;
							}
							this.MinutesPerDay = input.ReadUInt32();
						}
						else
						{
							this.Timezone = input.ReadString();
						}
					}
					else if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0062;
						}
						this.CanReceiveVoice = input.ReadBool();
					}
					else
					{
						this.MinutesPerWeek = input.ReadUInt32();
					}
				}
				else
				{
					if (num3 <= 64U)
					{
						if (num3 == 56U)
						{
							this.CanSendVoice = input.ReadBool();
							continue;
						}
						if (num3 != 64U)
						{
							goto IL_0062;
						}
					}
					else if (num3 != 66U)
					{
						if (num3 == 72U)
						{
							this.CanJoinGroup = input.ReadBool();
							continue;
						}
						if (num3 != 80U)
						{
							goto IL_0062;
						}
						this.CanUseProfile = input.ReadBool();
						continue;
					}
					this.playSchedule_.AddEntriesFrom(ref input, ParentalControlInfo._repeated_playSchedule_codec);
				}
				continue;
				IL_0062:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CB4 RID: 19636
		private static readonly MessageParser<ParentalControlInfo> _parser = new MessageParser<ParentalControlInfo>(() => new ParentalControlInfo());

		// Token: 0x04004CB5 RID: 19637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CB6 RID: 19638
		private int _hasBits0;

		// Token: 0x04004CB7 RID: 19639
		public const int TimezoneFieldNumber = 3;

		// Token: 0x04004CB8 RID: 19640
		private static readonly string TimezoneDefaultValue = "";

		// Token: 0x04004CB9 RID: 19641
		private string timezone_;

		// Token: 0x04004CBA RID: 19642
		public const int MinutesPerDayFieldNumber = 4;

		// Token: 0x04004CBB RID: 19643
		private static readonly uint MinutesPerDayDefaultValue = 0U;

		// Token: 0x04004CBC RID: 19644
		private uint minutesPerDay_;

		// Token: 0x04004CBD RID: 19645
		public const int MinutesPerWeekFieldNumber = 5;

		// Token: 0x04004CBE RID: 19646
		private static readonly uint MinutesPerWeekDefaultValue = 0U;

		// Token: 0x04004CBF RID: 19647
		private uint minutesPerWeek_;

		// Token: 0x04004CC0 RID: 19648
		public const int CanReceiveVoiceFieldNumber = 6;

		// Token: 0x04004CC1 RID: 19649
		private static readonly bool CanReceiveVoiceDefaultValue = false;

		// Token: 0x04004CC2 RID: 19650
		private bool canReceiveVoice_;

		// Token: 0x04004CC3 RID: 19651
		public const int CanSendVoiceFieldNumber = 7;

		// Token: 0x04004CC4 RID: 19652
		private static readonly bool CanSendVoiceDefaultValue = false;

		// Token: 0x04004CC5 RID: 19653
		private bool canSendVoice_;

		// Token: 0x04004CC6 RID: 19654
		public const int PlayScheduleFieldNumber = 8;

		// Token: 0x04004CC7 RID: 19655
		private static readonly FieldCodec<bool> _repeated_playSchedule_codec = FieldCodec.ForBool(64U);

		// Token: 0x04004CC8 RID: 19656
		private readonly RepeatedField<bool> playSchedule_ = new RepeatedField<bool>();

		// Token: 0x04004CC9 RID: 19657
		public const int CanJoinGroupFieldNumber = 9;

		// Token: 0x04004CCA RID: 19658
		private static readonly bool CanJoinGroupDefaultValue = false;

		// Token: 0x04004CCB RID: 19659
		private bool canJoinGroup_;

		// Token: 0x04004CCC RID: 19660
		public const int CanUseProfileFieldNumber = 10;

		// Token: 0x04004CCD RID: 19661
		private static readonly bool CanUseProfileDefaultValue = false;

		// Token: 0x04004CCE RID: 19662
		private bool canUseProfile_;
	}
}
