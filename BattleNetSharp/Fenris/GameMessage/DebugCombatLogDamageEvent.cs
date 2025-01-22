using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E5 RID: 485
	public sealed class DebugCombatLogDamageEvent : IMessage<DebugCombatLogDamageEvent>, IMessage, IEquatable<DebugCombatLogDamageEvent>, IDeepCloneable<DebugCombatLogDamageEvent>, IBufferMessage
	{
		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x000D04F4 File Offset: 0x000CE6F4
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogDamageEvent> Parser
		{
			get
			{
				return DebugCombatLogDamageEvent._parser;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x000D050C File Offset: 0x000CE70C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[42];
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x000D0530 File Offset: 0x000CE730
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogDamageEvent.Descriptor;
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x000D0547 File Offset: 0x000CE747
		[DebuggerNonUserCode]
		public DebugCombatLogDamageEvent()
		{
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x000D0554 File Offset: 0x000CE754
		[DebuggerNonUserCode]
		public DebugCombatLogDamageEvent(DebugCombatLogDamageEvent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.damageAmountScaled_ = other.damageAmountScaled_;
			this.damageAmountFlat_ = other.damageAmountFlat_;
			this.damageType_ = other.damageType_;
			this.hpSpecifierType_ = other.hpSpecifierType_;
			this.dotTotalPrediction_ = other.dotTotalPrediction_;
			this.damageDetails_ = ((other.damageDetails_ != null) ? other.damageDetails_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000D05E0 File Offset: 0x000CE7E0
		[DebuggerNonUserCode]
		public DebugCombatLogDamageEvent Clone()
		{
			return new DebugCombatLogDamageEvent(this);
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x000D05F8 File Offset: 0x000CE7F8
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x000D0629 File Offset: 0x000CE829
		[DebuggerNonUserCode]
		public float DamageAmountScaled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float damageAmountScaledDefaultValue;
				if (flag)
				{
					damageAmountScaledDefaultValue = this.damageAmountScaled_;
				}
				else
				{
					damageAmountScaledDefaultValue = DebugCombatLogDamageEvent.DamageAmountScaledDefaultValue;
				}
				return damageAmountScaledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.damageAmountScaled_ = value;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x000D0644 File Offset: 0x000CE844
		[DebuggerNonUserCode]
		public bool HasDamageAmountScaled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000D0661 File Offset: 0x000CE861
		[DebuggerNonUserCode]
		public void ClearDamageAmountScaled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x000D0674 File Offset: 0x000CE874
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x000D06A5 File Offset: 0x000CE8A5
		[DebuggerNonUserCode]
		public float DamageAmountFlat
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float damageAmountFlatDefaultValue;
				if (flag)
				{
					damageAmountFlatDefaultValue = this.damageAmountFlat_;
				}
				else
				{
					damageAmountFlatDefaultValue = DebugCombatLogDamageEvent.DamageAmountFlatDefaultValue;
				}
				return damageAmountFlatDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.damageAmountFlat_ = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x000D06C0 File Offset: 0x000CE8C0
		[DebuggerNonUserCode]
		public bool HasDamageAmountFlat
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000D06DD File Offset: 0x000CE8DD
		[DebuggerNonUserCode]
		public void ClearDamageAmountFlat()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x000D06F0 File Offset: 0x000CE8F0
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x000D0721 File Offset: 0x000CE921
		[DebuggerNonUserCode]
		public int DamageType
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int damageTypeDefaultValue;
				if (flag)
				{
					damageTypeDefaultValue = this.damageType_;
				}
				else
				{
					damageTypeDefaultValue = DebugCombatLogDamageEvent.DamageTypeDefaultValue;
				}
				return damageTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.damageType_ = value;
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x000D073C File Offset: 0x000CE93C
		[DebuggerNonUserCode]
		public bool HasDamageType
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x000D0759 File Offset: 0x000CE959
		[DebuggerNonUserCode]
		public void ClearDamageType()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x000D076C File Offset: 0x000CE96C
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x000D079D File Offset: 0x000CE99D
		[DebuggerNonUserCode]
		public uint HpSpecifierType
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint hpSpecifierTypeDefaultValue;
				if (flag)
				{
					hpSpecifierTypeDefaultValue = this.hpSpecifierType_;
				}
				else
				{
					hpSpecifierTypeDefaultValue = DebugCombatLogDamageEvent.HpSpecifierTypeDefaultValue;
				}
				return hpSpecifierTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.hpSpecifierType_ = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x000D07B8 File Offset: 0x000CE9B8
		[DebuggerNonUserCode]
		public bool HasHpSpecifierType
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000D07D5 File Offset: 0x000CE9D5
		[DebuggerNonUserCode]
		public void ClearHpSpecifierType()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x000D07E8 File Offset: 0x000CE9E8
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x000D081A File Offset: 0x000CEA1A
		[DebuggerNonUserCode]
		public bool DotTotalPrediction
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool dotTotalPredictionDefaultValue;
				if (flag)
				{
					dotTotalPredictionDefaultValue = this.dotTotalPrediction_;
				}
				else
				{
					dotTotalPredictionDefaultValue = DebugCombatLogDamageEvent.DotTotalPredictionDefaultValue;
				}
				return dotTotalPredictionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.dotTotalPrediction_ = value;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x000D0834 File Offset: 0x000CEA34
		[DebuggerNonUserCode]
		public bool HasDotTotalPrediction
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x000D0852 File Offset: 0x000CEA52
		[DebuggerNonUserCode]
		public void ClearDotTotalPrediction()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x000D0864 File Offset: 0x000CEA64
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x000D087C File Offset: 0x000CEA7C
		[DebuggerNonUserCode]
		public DebugDamageDetails DamageDetails
		{
			get
			{
				return this.damageDetails_;
			}
			set
			{
				this.damageDetails_ = value;
			}
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x000D0888 File Offset: 0x000CEA88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogDamageEvent);
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x000D08A8 File Offset: 0x000CEAA8
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogDamageEvent other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DamageAmountScaled, other.DamageAmountScaled);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DamageAmountFlat, other.DamageAmountFlat);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DamageType != other.DamageType;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.HpSpecifierType != other.HpSpecifierType;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.DotTotalPrediction != other.DotTotalPrediction;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.DamageDetails, other.DamageDetails);
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

		// Token: 0x060034C6 RID: 13510 RVA: 0x000D09A4 File Offset: 0x000CEBA4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDamageAmountScaled = this.HasDamageAmountScaled;
			if (hasDamageAmountScaled)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DamageAmountScaled);
			}
			bool hasDamageAmountFlat = this.HasDamageAmountFlat;
			if (hasDamageAmountFlat)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DamageAmountFlat);
			}
			bool hasDamageType = this.HasDamageType;
			if (hasDamageType)
			{
				num ^= this.DamageType.GetHashCode();
			}
			bool hasHpSpecifierType = this.HasHpSpecifierType;
			if (hasHpSpecifierType)
			{
				num ^= this.HpSpecifierType.GetHashCode();
			}
			bool hasDotTotalPrediction = this.HasDotTotalPrediction;
			if (hasDotTotalPrediction)
			{
				num ^= this.DotTotalPrediction.GetHashCode();
			}
			bool flag = this.damageDetails_ != null;
			if (flag)
			{
				num ^= this.DamageDetails.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x000D0A8C File Offset: 0x000CEC8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000D0AA4 File Offset: 0x000CECA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x000D0AB0 File Offset: 0x000CECB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDamageAmountScaled = this.HasDamageAmountScaled;
			if (hasDamageAmountScaled)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.DamageAmountScaled);
			}
			bool hasDamageAmountFlat = this.HasDamageAmountFlat;
			if (hasDamageAmountFlat)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.DamageAmountFlat);
			}
			bool hasDamageType = this.HasDamageType;
			if (hasDamageType)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.DamageType);
			}
			bool hasHpSpecifierType = this.HasHpSpecifierType;
			if (hasHpSpecifierType)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HpSpecifierType);
			}
			bool hasDotTotalPrediction = this.HasDotTotalPrediction;
			if (hasDotTotalPrediction)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.DotTotalPrediction);
			}
			bool flag = this.damageDetails_ != null;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.DamageDetails);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x000D0BB0 File Offset: 0x000CEDB0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDamageAmountScaled = this.HasDamageAmountScaled;
			if (hasDamageAmountScaled)
			{
				num += 5;
			}
			bool hasDamageAmountFlat = this.HasDamageAmountFlat;
			if (hasDamageAmountFlat)
			{
				num += 5;
			}
			bool hasDamageType = this.HasDamageType;
			if (hasDamageType)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.DamageType);
			}
			bool hasHpSpecifierType = this.HasHpSpecifierType;
			if (hasHpSpecifierType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HpSpecifierType);
			}
			bool hasDotTotalPrediction = this.HasDotTotalPrediction;
			if (hasDotTotalPrediction)
			{
				num += 2;
			}
			bool flag = this.damageDetails_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageDetails);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000D0C74 File Offset: 0x000CEE74
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogDamageEvent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDamageAmountScaled = other.HasDamageAmountScaled;
				if (hasDamageAmountScaled)
				{
					this.DamageAmountScaled = other.DamageAmountScaled;
				}
				bool hasDamageAmountFlat = other.HasDamageAmountFlat;
				if (hasDamageAmountFlat)
				{
					this.DamageAmountFlat = other.DamageAmountFlat;
				}
				bool hasDamageType = other.HasDamageType;
				if (hasDamageType)
				{
					this.DamageType = other.DamageType;
				}
				bool hasHpSpecifierType = other.HasHpSpecifierType;
				if (hasHpSpecifierType)
				{
					this.HpSpecifierType = other.HpSpecifierType;
				}
				bool hasDotTotalPrediction = other.HasDotTotalPrediction;
				if (hasDotTotalPrediction)
				{
					this.DotTotalPrediction = other.DotTotalPrediction;
				}
				bool flag2 = other.damageDetails_ != null;
				if (flag2)
				{
					bool flag3 = this.damageDetails_ == null;
					if (flag3)
					{
						this.DamageDetails = new DebugDamageDetails();
					}
					this.DamageDetails.MergeFrom(other.DamageDetails);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x000D0D68 File Offset: 0x000CEF68
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x000D0D74 File Offset: 0x000CEF74
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
					if (num3 != 13U)
					{
						if (num3 != 21U)
						{
							if (num3 != 24U)
							{
								goto IL_003A;
							}
							this.DamageType = input.ReadSInt32();
						}
						else
						{
							this.DamageAmountFlat = input.ReadFloat();
						}
					}
					else
					{
						this.DamageAmountScaled = input.ReadFloat();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_003A;
						}
						bool flag = this.damageDetails_ == null;
						if (flag)
						{
							this.DamageDetails = new DebugDamageDetails();
						}
						input.ReadMessage(this.DamageDetails);
					}
					else
					{
						this.DotTotalPrediction = input.ReadBool();
					}
				}
				else
				{
					this.HpSpecifierType = input.ReadUInt32();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400185E RID: 6238
		private static readonly MessageParser<DebugCombatLogDamageEvent> _parser = new MessageParser<DebugCombatLogDamageEvent>(() => new DebugCombatLogDamageEvent());

		// Token: 0x0400185F RID: 6239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001860 RID: 6240
		private int _hasBits0;

		// Token: 0x04001861 RID: 6241
		public const int DamageAmountScaledFieldNumber = 1;

		// Token: 0x04001862 RID: 6242
		private static readonly float DamageAmountScaledDefaultValue = 0f;

		// Token: 0x04001863 RID: 6243
		private float damageAmountScaled_;

		// Token: 0x04001864 RID: 6244
		public const int DamageAmountFlatFieldNumber = 2;

		// Token: 0x04001865 RID: 6245
		private static readonly float DamageAmountFlatDefaultValue = 0f;

		// Token: 0x04001866 RID: 6246
		private float damageAmountFlat_;

		// Token: 0x04001867 RID: 6247
		public const int DamageTypeFieldNumber = 3;

		// Token: 0x04001868 RID: 6248
		private static readonly int DamageTypeDefaultValue = 0;

		// Token: 0x04001869 RID: 6249
		private int damageType_;

		// Token: 0x0400186A RID: 6250
		public const int HpSpecifierTypeFieldNumber = 4;

		// Token: 0x0400186B RID: 6251
		private static readonly uint HpSpecifierTypeDefaultValue = 0U;

		// Token: 0x0400186C RID: 6252
		private uint hpSpecifierType_;

		// Token: 0x0400186D RID: 6253
		public const int DotTotalPredictionFieldNumber = 5;

		// Token: 0x0400186E RID: 6254
		private static readonly bool DotTotalPredictionDefaultValue = false;

		// Token: 0x0400186F RID: 6255
		private bool dotTotalPrediction_;

		// Token: 0x04001870 RID: 6256
		public const int DamageDetailsFieldNumber = 6;

		// Token: 0x04001871 RID: 6257
		private DebugDamageDetails damageDetails_;
	}
}
