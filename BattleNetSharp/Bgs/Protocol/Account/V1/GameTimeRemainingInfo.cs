using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000743 RID: 1859
	public sealed class GameTimeRemainingInfo : IMessage<GameTimeRemainingInfo>, IMessage, IEquatable<GameTimeRemainingInfo>, IDeepCloneable<GameTimeRemainingInfo>, IBufferMessage
	{
		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x0029A0EC File Offset: 0x002982EC
		[DebuggerNonUserCode]
		public static MessageParser<GameTimeRemainingInfo> Parser
		{
			get
			{
				return GameTimeRemainingInfo._parser;
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x0029A104 File Offset: 0x00298304
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x0029A128 File Offset: 0x00298328
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameTimeRemainingInfo.Descriptor;
			}
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x0029A13F File Offset: 0x0029833F
		[DebuggerNonUserCode]
		public GameTimeRemainingInfo()
		{
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x0029A14C File Offset: 0x0029834C
		[DebuggerNonUserCode]
		public GameTimeRemainingInfo(GameTimeRemainingInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.minutesRemaining_ = other.minutesRemaining_;
			this.parentalDailyMinutesRemaining_ = other.parentalDailyMinutesRemaining_;
			this.parentalWeeklyMinutesRemaining_ = other.parentalWeeklyMinutesRemaining_;
			this.secondsRemainingUntilKick_ = other.secondsRemainingUntilKick_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x0029A1B0 File Offset: 0x002983B0
		[DebuggerNonUserCode]
		public GameTimeRemainingInfo Clone()
		{
			return new GameTimeRemainingInfo(this);
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x0029A1C8 File Offset: 0x002983C8
		// (set) Token: 0x0600AAE8 RID: 43752 RVA: 0x0029A1F9 File Offset: 0x002983F9
		[DebuggerNonUserCode]
		public uint MinutesRemaining
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint minutesRemainingDefaultValue;
				if (flag)
				{
					minutesRemainingDefaultValue = this.minutesRemaining_;
				}
				else
				{
					minutesRemainingDefaultValue = GameTimeRemainingInfo.MinutesRemainingDefaultValue;
				}
				return minutesRemainingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.minutesRemaining_ = value;
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600AAE9 RID: 43753 RVA: 0x0029A214 File Offset: 0x00298414
		[DebuggerNonUserCode]
		public bool HasMinutesRemaining
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x0029A231 File Offset: 0x00298431
		[DebuggerNonUserCode]
		public void ClearMinutesRemaining()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600AAEB RID: 43755 RVA: 0x0029A244 File Offset: 0x00298444
		// (set) Token: 0x0600AAEC RID: 43756 RVA: 0x0029A275 File Offset: 0x00298475
		[DebuggerNonUserCode]
		public uint ParentalDailyMinutesRemaining
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint parentalDailyMinutesRemainingDefaultValue;
				if (flag)
				{
					parentalDailyMinutesRemainingDefaultValue = this.parentalDailyMinutesRemaining_;
				}
				else
				{
					parentalDailyMinutesRemainingDefaultValue = GameTimeRemainingInfo.ParentalDailyMinutesRemainingDefaultValue;
				}
				return parentalDailyMinutesRemainingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.parentalDailyMinutesRemaining_ = value;
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600AAED RID: 43757 RVA: 0x0029A290 File Offset: 0x00298490
		[DebuggerNonUserCode]
		public bool HasParentalDailyMinutesRemaining
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x0029A2AD File Offset: 0x002984AD
		[DebuggerNonUserCode]
		public void ClearParentalDailyMinutesRemaining()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600AAEF RID: 43759 RVA: 0x0029A2C0 File Offset: 0x002984C0
		// (set) Token: 0x0600AAF0 RID: 43760 RVA: 0x0029A2F1 File Offset: 0x002984F1
		[DebuggerNonUserCode]
		public uint ParentalWeeklyMinutesRemaining
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint parentalWeeklyMinutesRemainingDefaultValue;
				if (flag)
				{
					parentalWeeklyMinutesRemainingDefaultValue = this.parentalWeeklyMinutesRemaining_;
				}
				else
				{
					parentalWeeklyMinutesRemainingDefaultValue = GameTimeRemainingInfo.ParentalWeeklyMinutesRemainingDefaultValue;
				}
				return parentalWeeklyMinutesRemainingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.parentalWeeklyMinutesRemaining_ = value;
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600AAF1 RID: 43761 RVA: 0x0029A30C File Offset: 0x0029850C
		[DebuggerNonUserCode]
		public bool HasParentalWeeklyMinutesRemaining
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x0029A329 File Offset: 0x00298529
		[DebuggerNonUserCode]
		public void ClearParentalWeeklyMinutesRemaining()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x0600AAF3 RID: 43763 RVA: 0x0029A33C File Offset: 0x0029853C
		// (set) Token: 0x0600AAF4 RID: 43764 RVA: 0x0029A36D File Offset: 0x0029856D
		[Obsolete]
		[DebuggerNonUserCode]
		public uint SecondsRemainingUntilKick
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint secondsRemainingUntilKickDefaultValue;
				if (flag)
				{
					secondsRemainingUntilKickDefaultValue = this.secondsRemainingUntilKick_;
				}
				else
				{
					secondsRemainingUntilKickDefaultValue = GameTimeRemainingInfo.SecondsRemainingUntilKickDefaultValue;
				}
				return secondsRemainingUntilKickDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.secondsRemainingUntilKick_ = value;
			}
		}

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x0600AAF5 RID: 43765 RVA: 0x0029A388 File Offset: 0x00298588
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasSecondsRemainingUntilKick
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x0029A3A5 File Offset: 0x002985A5
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearSecondsRemainingUntilKick()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x0029A3B8 File Offset: 0x002985B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameTimeRemainingInfo);
		}

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x0029A3D8 File Offset: 0x002985D8
		[DebuggerNonUserCode]
		public bool Equals(GameTimeRemainingInfo other)
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
					bool flag4 = this.MinutesRemaining != other.MinutesRemaining;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ParentalDailyMinutesRemaining != other.ParentalDailyMinutesRemaining;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ParentalWeeklyMinutesRemaining != other.ParentalWeeklyMinutesRemaining;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SecondsRemainingUntilKick != other.SecondsRemainingUntilKick;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AAF9 RID: 43769 RVA: 0x0029A484 File Offset: 0x00298684
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMinutesRemaining = this.HasMinutesRemaining;
			if (hasMinutesRemaining)
			{
				num ^= this.MinutesRemaining.GetHashCode();
			}
			bool hasParentalDailyMinutesRemaining = this.HasParentalDailyMinutesRemaining;
			if (hasParentalDailyMinutesRemaining)
			{
				num ^= this.ParentalDailyMinutesRemaining.GetHashCode();
			}
			bool hasParentalWeeklyMinutesRemaining = this.HasParentalWeeklyMinutesRemaining;
			if (hasParentalWeeklyMinutesRemaining)
			{
				num ^= this.ParentalWeeklyMinutesRemaining.GetHashCode();
			}
			bool hasSecondsRemainingUntilKick = this.HasSecondsRemainingUntilKick;
			if (hasSecondsRemainingUntilKick)
			{
				num ^= this.SecondsRemainingUntilKick.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x0029A52C File Offset: 0x0029872C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x0029A544 File Offset: 0x00298744
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x0029A550 File Offset: 0x00298750
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMinutesRemaining = this.HasMinutesRemaining;
			if (hasMinutesRemaining)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MinutesRemaining);
			}
			bool hasParentalDailyMinutesRemaining = this.HasParentalDailyMinutesRemaining;
			if (hasParentalDailyMinutesRemaining)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ParentalDailyMinutesRemaining);
			}
			bool hasParentalWeeklyMinutesRemaining = this.HasParentalWeeklyMinutesRemaining;
			if (hasParentalWeeklyMinutesRemaining)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ParentalWeeklyMinutesRemaining);
			}
			bool hasSecondsRemainingUntilKick = this.HasSecondsRemainingUntilKick;
			if (hasSecondsRemainingUntilKick)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SecondsRemainingUntilKick);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAFD RID: 43773 RVA: 0x0029A604 File Offset: 0x00298804
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMinutesRemaining = this.HasMinutesRemaining;
			if (hasMinutesRemaining)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinutesRemaining);
			}
			bool hasParentalDailyMinutesRemaining = this.HasParentalDailyMinutesRemaining;
			if (hasParentalDailyMinutesRemaining)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ParentalDailyMinutesRemaining);
			}
			bool hasParentalWeeklyMinutesRemaining = this.HasParentalWeeklyMinutesRemaining;
			if (hasParentalWeeklyMinutesRemaining)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ParentalWeeklyMinutesRemaining);
			}
			bool hasSecondsRemainingUntilKick = this.HasSecondsRemainingUntilKick;
			if (hasSecondsRemainingUntilKick)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SecondsRemainingUntilKick);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x0029A6AC File Offset: 0x002988AC
		[DebuggerNonUserCode]
		public void MergeFrom(GameTimeRemainingInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMinutesRemaining = other.HasMinutesRemaining;
				if (hasMinutesRemaining)
				{
					this.MinutesRemaining = other.MinutesRemaining;
				}
				bool hasParentalDailyMinutesRemaining = other.HasParentalDailyMinutesRemaining;
				if (hasParentalDailyMinutesRemaining)
				{
					this.ParentalDailyMinutesRemaining = other.ParentalDailyMinutesRemaining;
				}
				bool hasParentalWeeklyMinutesRemaining = other.HasParentalWeeklyMinutesRemaining;
				if (hasParentalWeeklyMinutesRemaining)
				{
					this.ParentalWeeklyMinutesRemaining = other.ParentalWeeklyMinutesRemaining;
				}
				bool hasSecondsRemainingUntilKick = other.HasSecondsRemainingUntilKick;
				if (hasSecondsRemainingUntilKick)
				{
					this.SecondsRemainingUntilKick = other.SecondsRemainingUntilKick;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x0029A742 File Offset: 0x00298942
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x0029A750 File Offset: 0x00298950
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
						this.ParentalDailyMinutesRemaining = input.ReadUInt32();
					}
					else
					{
						this.MinutesRemaining = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.SecondsRemainingUntilKick = input.ReadUInt32();
				}
				else
				{
					this.ParentalWeeklyMinutesRemaining = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CFC RID: 19708
		private static readonly MessageParser<GameTimeRemainingInfo> _parser = new MessageParser<GameTimeRemainingInfo>(() => new GameTimeRemainingInfo());

		// Token: 0x04004CFD RID: 19709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CFE RID: 19710
		private int _hasBits0;

		// Token: 0x04004CFF RID: 19711
		public const int MinutesRemainingFieldNumber = 1;

		// Token: 0x04004D00 RID: 19712
		private static readonly uint MinutesRemainingDefaultValue = 0U;

		// Token: 0x04004D01 RID: 19713
		private uint minutesRemaining_;

		// Token: 0x04004D02 RID: 19714
		public const int ParentalDailyMinutesRemainingFieldNumber = 2;

		// Token: 0x04004D03 RID: 19715
		private static readonly uint ParentalDailyMinutesRemainingDefaultValue = 0U;

		// Token: 0x04004D04 RID: 19716
		private uint parentalDailyMinutesRemaining_;

		// Token: 0x04004D05 RID: 19717
		public const int ParentalWeeklyMinutesRemainingFieldNumber = 3;

		// Token: 0x04004D06 RID: 19718
		private static readonly uint ParentalWeeklyMinutesRemainingDefaultValue = 0U;

		// Token: 0x04004D07 RID: 19719
		private uint parentalWeeklyMinutesRemaining_;

		// Token: 0x04004D08 RID: 19720
		public const int SecondsRemainingUntilKickFieldNumber = 4;

		// Token: 0x04004D09 RID: 19721
		private static readonly uint SecondsRemainingUntilKickDefaultValue = 0U;

		// Token: 0x04004D0A RID: 19722
		private uint secondsRemainingUntilKick_;
	}
}
