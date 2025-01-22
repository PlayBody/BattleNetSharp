using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E6 RID: 486
	public sealed class DebugCombatLogStackData : IMessage<DebugCombatLogStackData>, IMessage, IEquatable<DebugCombatLogStackData>, IDeepCloneable<DebugCombatLogStackData>, IBufferMessage
	{
		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x000D0EB0 File Offset: 0x000CF0B0
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogStackData> Parser
		{
			get
			{
				return DebugCombatLogStackData._parser;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x000D0EC8 File Offset: 0x000CF0C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[43];
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x000D0EEC File Offset: 0x000CF0EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogStackData.Descriptor;
			}
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000D0F03 File Offset: 0x000CF103
		[DebuggerNonUserCode]
		public DebugCombatLogStackData()
		{
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000D0F10 File Offset: 0x000CF110
		[DebuggerNonUserCode]
		public DebugCombatLogStackData(DebugCombatLogStackData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.callbackType_ = other.callbackType_;
			this.powerSno_ = other.powerSno_;
			this.stackCount_ = other.stackCount_;
			this.powerSnoFrom_ = other.powerSnoFrom_;
			this.time_ = other.time_;
			this.atMaxStack_ = other.atMaxStack_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x000D0F8C File Offset: 0x000CF18C
		[DebuggerNonUserCode]
		public DebugCombatLogStackData Clone()
		{
			return new DebugCombatLogStackData(this);
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x000D0FA4 File Offset: 0x000CF1A4
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x000D0FD5 File Offset: 0x000CF1D5
		[DebuggerNonUserCode]
		public int CallbackType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int callbackTypeDefaultValue;
				if (flag)
				{
					callbackTypeDefaultValue = this.callbackType_;
				}
				else
				{
					callbackTypeDefaultValue = DebugCombatLogStackData.CallbackTypeDefaultValue;
				}
				return callbackTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.callbackType_ = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x000D0FF0 File Offset: 0x000CF1F0
		[DebuggerNonUserCode]
		public bool HasCallbackType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000D100D File Offset: 0x000CF20D
		[DebuggerNonUserCode]
		public void ClearCallbackType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x000D1020 File Offset: 0x000CF220
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x000D1051 File Offset: 0x000CF251
		[DebuggerNonUserCode]
		public int PowerSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int powerSnoDefaultValue;
				if (flag)
				{
					powerSnoDefaultValue = this.powerSno_;
				}
				else
				{
					powerSnoDefaultValue = DebugCombatLogStackData.PowerSnoDefaultValue;
				}
				return powerSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.powerSno_ = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x000D106C File Offset: 0x000CF26C
		[DebuggerNonUserCode]
		public bool HasPowerSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x000D1089 File Offset: 0x000CF289
		[DebuggerNonUserCode]
		public void ClearPowerSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x000D109C File Offset: 0x000CF29C
		// (set) Token: 0x060034DE RID: 13534 RVA: 0x000D10CD File Offset: 0x000CF2CD
		[DebuggerNonUserCode]
		public int StackCount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int stackCountDefaultValue;
				if (flag)
				{
					stackCountDefaultValue = this.stackCount_;
				}
				else
				{
					stackCountDefaultValue = DebugCombatLogStackData.StackCountDefaultValue;
				}
				return stackCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.stackCount_ = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x060034DF RID: 13535 RVA: 0x000D10E8 File Offset: 0x000CF2E8
		[DebuggerNonUserCode]
		public bool HasStackCount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000D1105 File Offset: 0x000CF305
		[DebuggerNonUserCode]
		public void ClearStackCount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x060034E1 RID: 13537 RVA: 0x000D1118 File Offset: 0x000CF318
		// (set) Token: 0x060034E2 RID: 13538 RVA: 0x000D1149 File Offset: 0x000CF349
		[DebuggerNonUserCode]
		public int PowerSnoFrom
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int powerSnoFromDefaultValue;
				if (flag)
				{
					powerSnoFromDefaultValue = this.powerSnoFrom_;
				}
				else
				{
					powerSnoFromDefaultValue = DebugCombatLogStackData.PowerSnoFromDefaultValue;
				}
				return powerSnoFromDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.powerSnoFrom_ = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x060034E3 RID: 13539 RVA: 0x000D1164 File Offset: 0x000CF364
		[DebuggerNonUserCode]
		public bool HasPowerSnoFrom
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000D1181 File Offset: 0x000CF381
		[DebuggerNonUserCode]
		public void ClearPowerSnoFrom()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x060034E5 RID: 13541 RVA: 0x000D1194 File Offset: 0x000CF394
		// (set) Token: 0x060034E6 RID: 13542 RVA: 0x000D11C6 File Offset: 0x000CF3C6
		[DebuggerNonUserCode]
		public uint Time
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint timeDefaultValue;
				if (flag)
				{
					timeDefaultValue = this.time_;
				}
				else
				{
					timeDefaultValue = DebugCombatLogStackData.TimeDefaultValue;
				}
				return timeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.time_ = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x060034E7 RID: 13543 RVA: 0x000D11E0 File Offset: 0x000CF3E0
		[DebuggerNonUserCode]
		public bool HasTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000D11FE File Offset: 0x000CF3FE
		[DebuggerNonUserCode]
		public void ClearTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x000D1210 File Offset: 0x000CF410
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x000D1242 File Offset: 0x000CF442
		[DebuggerNonUserCode]
		public bool AtMaxStack
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool atMaxStackDefaultValue;
				if (flag)
				{
					atMaxStackDefaultValue = this.atMaxStack_;
				}
				else
				{
					atMaxStackDefaultValue = DebugCombatLogStackData.AtMaxStackDefaultValue;
				}
				return atMaxStackDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.atMaxStack_ = value;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x000D125C File Offset: 0x000CF45C
		[DebuggerNonUserCode]
		public bool HasAtMaxStack
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000D127A File Offset: 0x000CF47A
		[DebuggerNonUserCode]
		public void ClearAtMaxStack()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000D128C File Offset: 0x000CF48C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogStackData);
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000D12AC File Offset: 0x000CF4AC
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogStackData other)
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
					bool flag4 = this.CallbackType != other.CallbackType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PowerSno != other.PowerSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.StackCount != other.StackCount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PowerSnoFrom != other.PowerSnoFrom;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Time != other.Time;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.AtMaxStack != other.AtMaxStack;
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

		// Token: 0x060034EF RID: 13551 RVA: 0x000D1398 File Offset: 0x000CF598
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCallbackType = this.HasCallbackType;
			if (hasCallbackType)
			{
				num ^= this.CallbackType.GetHashCode();
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num ^= this.PowerSno.GetHashCode();
			}
			bool hasStackCount = this.HasStackCount;
			if (hasStackCount)
			{
				num ^= this.StackCount.GetHashCode();
			}
			bool hasPowerSnoFrom = this.HasPowerSnoFrom;
			if (hasPowerSnoFrom)
			{
				num ^= this.PowerSnoFrom.GetHashCode();
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num ^= this.Time.GetHashCode();
			}
			bool hasAtMaxStack = this.HasAtMaxStack;
			if (hasAtMaxStack)
			{
				num ^= this.AtMaxStack.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000D147C File Offset: 0x000CF67C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000D1494 File Offset: 0x000CF694
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000D14A0 File Offset: 0x000CF6A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCallbackType = this.HasCallbackType;
			if (hasCallbackType)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CallbackType);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.PowerSno);
			}
			bool hasStackCount = this.HasStackCount;
			if (hasStackCount)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StackCount);
			}
			bool hasPowerSnoFrom = this.HasPowerSnoFrom;
			if (hasPowerSnoFrom)
			{
				output.WriteRawTag(37);
				output.WriteSFixed32(this.PowerSnoFrom);
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Time);
			}
			bool hasAtMaxStack = this.HasAtMaxStack;
			if (hasAtMaxStack)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.AtMaxStack);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000D159C File Offset: 0x000CF79C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCallbackType = this.HasCallbackType;
			if (hasCallbackType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CallbackType);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num += 5;
			}
			bool hasStackCount = this.HasStackCount;
			if (hasStackCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			bool hasPowerSnoFrom = this.HasPowerSnoFrom;
			if (hasPowerSnoFrom)
			{
				num += 5;
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Time);
			}
			bool hasAtMaxStack = this.HasAtMaxStack;
			if (hasAtMaxStack)
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

		// Token: 0x060034F4 RID: 13556 RVA: 0x000D165C File Offset: 0x000CF85C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogStackData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCallbackType = other.HasCallbackType;
				if (hasCallbackType)
				{
					this.CallbackType = other.CallbackType;
				}
				bool hasPowerSno = other.HasPowerSno;
				if (hasPowerSno)
				{
					this.PowerSno = other.PowerSno;
				}
				bool hasStackCount = other.HasStackCount;
				if (hasStackCount)
				{
					this.StackCount = other.StackCount;
				}
				bool hasPowerSnoFrom = other.HasPowerSnoFrom;
				if (hasPowerSnoFrom)
				{
					this.PowerSnoFrom = other.PowerSnoFrom;
				}
				bool hasTime = other.HasTime;
				if (hasTime)
				{
					this.Time = other.Time;
				}
				bool hasAtMaxStack = other.HasAtMaxStack;
				if (hasAtMaxStack)
				{
					this.AtMaxStack = other.AtMaxStack;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000D172B File Offset: 0x000CF92B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x000D1738 File Offset: 0x000CF938
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							if (num3 != 24U)
							{
								goto IL_0039;
							}
							this.StackCount = input.ReadInt32();
						}
						else
						{
							this.PowerSno = input.ReadSFixed32();
						}
					}
					else
					{
						this.CallbackType = input.ReadInt32();
					}
				}
				else if (num3 != 37U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.AtMaxStack = input.ReadBool();
					}
					else
					{
						this.Time = input.ReadUInt32();
					}
				}
				else
				{
					this.PowerSnoFrom = input.ReadSFixed32();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001872 RID: 6258
		private static readonly MessageParser<DebugCombatLogStackData> _parser = new MessageParser<DebugCombatLogStackData>(() => new DebugCombatLogStackData());

		// Token: 0x04001873 RID: 6259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001874 RID: 6260
		private int _hasBits0;

		// Token: 0x04001875 RID: 6261
		public const int CallbackTypeFieldNumber = 1;

		// Token: 0x04001876 RID: 6262
		private static readonly int CallbackTypeDefaultValue = 0;

		// Token: 0x04001877 RID: 6263
		private int callbackType_;

		// Token: 0x04001878 RID: 6264
		public const int PowerSnoFieldNumber = 2;

		// Token: 0x04001879 RID: 6265
		private static readonly int PowerSnoDefaultValue = 0;

		// Token: 0x0400187A RID: 6266
		private int powerSno_;

		// Token: 0x0400187B RID: 6267
		public const int StackCountFieldNumber = 3;

		// Token: 0x0400187C RID: 6268
		private static readonly int StackCountDefaultValue = 0;

		// Token: 0x0400187D RID: 6269
		private int stackCount_;

		// Token: 0x0400187E RID: 6270
		public const int PowerSnoFromFieldNumber = 4;

		// Token: 0x0400187F RID: 6271
		private static readonly int PowerSnoFromDefaultValue = 0;

		// Token: 0x04001880 RID: 6272
		private int powerSnoFrom_;

		// Token: 0x04001881 RID: 6273
		public const int TimeFieldNumber = 5;

		// Token: 0x04001882 RID: 6274
		private static readonly uint TimeDefaultValue = 0U;

		// Token: 0x04001883 RID: 6275
		private uint time_;

		// Token: 0x04001884 RID: 6276
		public const int AtMaxStackFieldNumber = 6;

		// Token: 0x04001885 RID: 6277
		private static readonly bool AtMaxStackDefaultValue = false;

		// Token: 0x04001886 RID: 6278
		private bool atMaxStack_;
	}
}
