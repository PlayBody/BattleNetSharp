using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E1 RID: 481
	public sealed class DebugCombatStat : IMessage<DebugCombatStat>, IMessage, IEquatable<DebugCombatStat>, IDeepCloneable<DebugCombatStat>, IBufferMessage
	{
		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x000CE8FC File Offset: 0x000CCAFC
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatStat> Parser
		{
			get
			{
				return DebugCombatStat._parser;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x000CE914 File Offset: 0x000CCB14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[38];
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x000CE938 File Offset: 0x000CCB38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatStat.Descriptor;
			}
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x000CE94F File Offset: 0x000CCB4F
		[DebuggerNonUserCode]
		public DebugCombatStat()
		{
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x000CE964 File Offset: 0x000CCB64
		[DebuggerNonUserCode]
		public DebugCombatStat(DebugCombatStat other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.stat_ = other.stat_;
			this.chanceRollResult_ = other.chanceRollResult_;
			this.details_ = other.details_.Clone();
			this.appliesToAnotherStat_ = other.appliesToAnotherStat_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x000CE9CC File Offset: 0x000CCBCC
		[DebuggerNonUserCode]
		public DebugCombatStat Clone()
		{
			return new DebugCombatStat(this);
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x000CE9E4 File Offset: 0x000CCBE4
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x000CEA15 File Offset: 0x000CCC15
		[DebuggerNonUserCode]
		public int Stat
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int statDefaultValue;
				if (flag)
				{
					statDefaultValue = this.stat_;
				}
				else
				{
					statDefaultValue = DebugCombatStat.StatDefaultValue;
				}
				return statDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.stat_ = value;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x000CEA30 File Offset: 0x000CCC30
		[DebuggerNonUserCode]
		public bool HasStat
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x000CEA4D File Offset: 0x000CCC4D
		[DebuggerNonUserCode]
		public void ClearStat()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x000CEA60 File Offset: 0x000CCC60
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x000CEA91 File Offset: 0x000CCC91
		[DebuggerNonUserCode]
		public bool ChanceRollResult
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool chanceRollResultDefaultValue;
				if (flag)
				{
					chanceRollResultDefaultValue = this.chanceRollResult_;
				}
				else
				{
					chanceRollResultDefaultValue = DebugCombatStat.ChanceRollResultDefaultValue;
				}
				return chanceRollResultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.chanceRollResult_ = value;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x000CEAAC File Offset: 0x000CCCAC
		[DebuggerNonUserCode]
		public bool HasChanceRollResult
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x000CEAC9 File Offset: 0x000CCCC9
		[DebuggerNonUserCode]
		public void ClearChanceRollResult()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x000CEADC File Offset: 0x000CCCDC
		[DebuggerNonUserCode]
		public RepeatedField<DebugCombatStatDetail> Details
		{
			get
			{
				return this.details_;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x000CEAF4 File Offset: 0x000CCCF4
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x000CEB25 File Offset: 0x000CCD25
		[DebuggerNonUserCode]
		public bool AppliesToAnotherStat
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool appliesToAnotherStatDefaultValue;
				if (flag)
				{
					appliesToAnotherStatDefaultValue = this.appliesToAnotherStat_;
				}
				else
				{
					appliesToAnotherStatDefaultValue = DebugCombatStat.AppliesToAnotherStatDefaultValue;
				}
				return appliesToAnotherStatDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.appliesToAnotherStat_ = value;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x000CEB40 File Offset: 0x000CCD40
		[DebuggerNonUserCode]
		public bool HasAppliesToAnotherStat
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000CEB5D File Offset: 0x000CCD5D
		[DebuggerNonUserCode]
		public void ClearAppliesToAnotherStat()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x000CEB70 File Offset: 0x000CCD70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatStat);
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x000CEB90 File Offset: 0x000CCD90
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatStat other)
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
					bool flag4 = this.Stat != other.Stat;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ChanceRollResult != other.ChanceRollResult;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.details_.Equals(other.details_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AppliesToAnotherStat != other.AppliesToAnotherStat;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x000CEC40 File Offset: 0x000CCE40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStat = this.HasStat;
			if (hasStat)
			{
				num ^= this.Stat.GetHashCode();
			}
			bool hasChanceRollResult = this.HasChanceRollResult;
			if (hasChanceRollResult)
			{
				num ^= this.ChanceRollResult.GetHashCode();
			}
			num ^= this.details_.GetHashCode();
			bool hasAppliesToAnotherStat = this.HasAppliesToAnotherStat;
			if (hasAppliesToAnotherStat)
			{
				num ^= this.AppliesToAnotherStat.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x000CECDC File Offset: 0x000CCEDC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x000CECF4 File Offset: 0x000CCEF4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x000CED00 File Offset: 0x000CCF00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStat = this.HasStat;
			if (hasStat)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Stat);
			}
			bool hasChanceRollResult = this.HasChanceRollResult;
			if (hasChanceRollResult)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ChanceRollResult);
			}
			this.details_.WriteTo(ref output, DebugCombatStat._repeated_details_codec);
			bool hasAppliesToAnotherStat = this.HasAppliesToAnotherStat;
			if (hasAppliesToAnotherStat)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.AppliesToAnotherStat);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x000CEDA4 File Offset: 0x000CCFA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStat = this.HasStat;
			if (hasStat)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Stat);
			}
			bool hasChanceRollResult = this.HasChanceRollResult;
			if (hasChanceRollResult)
			{
				num += 2;
			}
			num += this.details_.CalculateSize(DebugCombatStat._repeated_details_codec);
			bool hasAppliesToAnotherStat = this.HasAppliesToAnotherStat;
			if (hasAppliesToAnotherStat)
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

		// Token: 0x06003446 RID: 13382 RVA: 0x000CEE2C File Offset: 0x000CD02C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatStat other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStat = other.HasStat;
				if (hasStat)
				{
					this.Stat = other.Stat;
				}
				bool hasChanceRollResult = other.HasChanceRollResult;
				if (hasChanceRollResult)
				{
					this.ChanceRollResult = other.ChanceRollResult;
				}
				this.details_.Add(other.details_);
				bool hasAppliesToAnotherStat = other.HasAppliesToAnotherStat;
				if (hasAppliesToAnotherStat)
				{
					this.AppliesToAnotherStat = other.AppliesToAnotherStat;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x000CEEB9 File Offset: 0x000CD0B9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x000CEEC4 File Offset: 0x000CD0C4
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
						this.ChanceRollResult = input.ReadBool();
					}
					else
					{
						this.Stat = input.ReadInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.AppliesToAnotherStat = input.ReadBool();
				}
				else
				{
					this.details_.AddEntriesFrom(ref input, DebugCombatStat._repeated_details_codec);
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400181F RID: 6175
		private static readonly MessageParser<DebugCombatStat> _parser = new MessageParser<DebugCombatStat>(() => new DebugCombatStat());

		// Token: 0x04001820 RID: 6176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001821 RID: 6177
		private int _hasBits0;

		// Token: 0x04001822 RID: 6178
		public const int StatFieldNumber = 1;

		// Token: 0x04001823 RID: 6179
		private static readonly int StatDefaultValue = 0;

		// Token: 0x04001824 RID: 6180
		private int stat_;

		// Token: 0x04001825 RID: 6181
		public const int ChanceRollResultFieldNumber = 2;

		// Token: 0x04001826 RID: 6182
		private static readonly bool ChanceRollResultDefaultValue = false;

		// Token: 0x04001827 RID: 6183
		private bool chanceRollResult_;

		// Token: 0x04001828 RID: 6184
		public const int DetailsFieldNumber = 3;

		// Token: 0x04001829 RID: 6185
		private static readonly FieldCodec<DebugCombatStatDetail> _repeated_details_codec = FieldCodec.ForMessage<DebugCombatStatDetail>(26U, DebugCombatStatDetail.Parser);

		// Token: 0x0400182A RID: 6186
		private readonly RepeatedField<DebugCombatStatDetail> details_ = new RepeatedField<DebugCombatStatDetail>();

		// Token: 0x0400182B RID: 6187
		public const int AppliesToAnotherStatFieldNumber = 4;

		// Token: 0x0400182C RID: 6188
		private static readonly bool AppliesToAnotherStatDefaultValue = false;

		// Token: 0x0400182D RID: 6189
		private bool appliesToAnotherStat_;
	}
}
