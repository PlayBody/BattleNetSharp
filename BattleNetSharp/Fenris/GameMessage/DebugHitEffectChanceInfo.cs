using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E3 RID: 483
	public sealed class DebugHitEffectChanceInfo : IMessage<DebugHitEffectChanceInfo>, IMessage, IEquatable<DebugHitEffectChanceInfo>, IDeepCloneable<DebugHitEffectChanceInfo>, IBufferMessage
	{
		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x000CF438 File Offset: 0x000CD638
		[DebuggerNonUserCode]
		public static MessageParser<DebugHitEffectChanceInfo> Parser
		{
			get
			{
				return DebugHitEffectChanceInfo._parser;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x000CF450 File Offset: 0x000CD650
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[40];
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x000CF474 File Offset: 0x000CD674
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugHitEffectChanceInfo.Descriptor;
			}
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x000CF48B File Offset: 0x000CD68B
		[DebuggerNonUserCode]
		public DebugHitEffectChanceInfo()
		{
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x000CF4A0 File Offset: 0x000CD6A0
		[DebuggerNonUserCode]
		public DebugHitEffectChanceInfo(DebugHitEffectChanceInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.powerSno_ = other.powerSno_;
			this.chanceFactors_ = other.chanceFactors_.Clone();
			this.finalProcChance_ = other.finalProcChance_;
			this.rollSuccessful_ = other.rollSuccessful_;
			this.forceEffect_ = other.forceEffect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x000CF520 File Offset: 0x000CD720
		[DebuggerNonUserCode]
		public DebugHitEffectChanceInfo Clone()
		{
			return new DebugHitEffectChanceInfo(this);
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x000CF538 File Offset: 0x000CD738
		// (set) Token: 0x0600346A RID: 13418 RVA: 0x000CF559 File Offset: 0x000CD759
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? DebugHitEffectChanceInfo.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x000CF570 File Offset: 0x000CD770
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x000CF58B File Offset: 0x000CD78B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x000CF598 File Offset: 0x000CD798
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x000CF5C9 File Offset: 0x000CD7C9
		[DebuggerNonUserCode]
		public int PowerSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int powerSnoDefaultValue;
				if (flag)
				{
					powerSnoDefaultValue = this.powerSno_;
				}
				else
				{
					powerSnoDefaultValue = DebugHitEffectChanceInfo.PowerSnoDefaultValue;
				}
				return powerSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.powerSno_ = value;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x000CF5E4 File Offset: 0x000CD7E4
		[DebuggerNonUserCode]
		public bool HasPowerSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x000CF601 File Offset: 0x000CD801
		[DebuggerNonUserCode]
		public void ClearPowerSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x000CF614 File Offset: 0x000CD814
		[DebuggerNonUserCode]
		public RepeatedField<DebugHitEffectFactorInfo> ChanceFactors
		{
			get
			{
				return this.chanceFactors_;
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x000CF62C File Offset: 0x000CD82C
		// (set) Token: 0x06003473 RID: 13427 RVA: 0x000CF65D File Offset: 0x000CD85D
		[DebuggerNonUserCode]
		public float FinalProcChance
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float finalProcChanceDefaultValue;
				if (flag)
				{
					finalProcChanceDefaultValue = this.finalProcChance_;
				}
				else
				{
					finalProcChanceDefaultValue = DebugHitEffectChanceInfo.FinalProcChanceDefaultValue;
				}
				return finalProcChanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.finalProcChance_ = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x000CF678 File Offset: 0x000CD878
		[DebuggerNonUserCode]
		public bool HasFinalProcChance
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000CF695 File Offset: 0x000CD895
		[DebuggerNonUserCode]
		public void ClearFinalProcChance()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
		// (set) Token: 0x06003477 RID: 13431 RVA: 0x000CF6D9 File Offset: 0x000CD8D9
		[DebuggerNonUserCode]
		public bool RollSuccessful
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool rollSuccessfulDefaultValue;
				if (flag)
				{
					rollSuccessfulDefaultValue = this.rollSuccessful_;
				}
				else
				{
					rollSuccessfulDefaultValue = DebugHitEffectChanceInfo.RollSuccessfulDefaultValue;
				}
				return rollSuccessfulDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.rollSuccessful_ = value;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x000CF6F4 File Offset: 0x000CD8F4
		[DebuggerNonUserCode]
		public bool HasRollSuccessful
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x000CF711 File Offset: 0x000CD911
		[DebuggerNonUserCode]
		public void ClearRollSuccessful()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x000CF724 File Offset: 0x000CD924
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x000CF755 File Offset: 0x000CD955
		[DebuggerNonUserCode]
		public int ForceEffect
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int forceEffectDefaultValue;
				if (flag)
				{
					forceEffectDefaultValue = this.forceEffect_;
				}
				else
				{
					forceEffectDefaultValue = DebugHitEffectChanceInfo.ForceEffectDefaultValue;
				}
				return forceEffectDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.forceEffect_ = value;
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x000CF770 File Offset: 0x000CD970
		[DebuggerNonUserCode]
		public bool HasForceEffect
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000CF78D File Offset: 0x000CD98D
		[DebuggerNonUserCode]
		public void ClearForceEffect()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000CF7A0 File Offset: 0x000CD9A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugHitEffectChanceInfo);
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x000CF7C0 File Offset: 0x000CD9C0
		[DebuggerNonUserCode]
		public bool Equals(DebugHitEffectChanceInfo other)
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
					bool flag4 = this.Name != other.Name;
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
							bool flag6 = !this.chanceFactors_.Equals(other.chanceFactors_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FinalProcChance, other.FinalProcChance);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.RollSuccessful != other.RollSuccessful;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ForceEffect != other.ForceEffect;
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

		// Token: 0x06003480 RID: 13440 RVA: 0x000CF8B4 File Offset: 0x000CDAB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num ^= this.PowerSno.GetHashCode();
			}
			num ^= this.chanceFactors_.GetHashCode();
			bool hasFinalProcChance = this.HasFinalProcChance;
			if (hasFinalProcChance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FinalProcChance);
			}
			bool hasRollSuccessful = this.HasRollSuccessful;
			if (hasRollSuccessful)
			{
				num ^= this.RollSuccessful.GetHashCode();
			}
			bool hasForceEffect = this.HasForceEffect;
			if (hasForceEffect)
			{
				num ^= this.ForceEffect.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000CF988 File Offset: 0x000CDB88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x000CF9A0 File Offset: 0x000CDBA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x000CF9AC File Offset: 0x000CDBAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.PowerSno);
			}
			this.chanceFactors_.WriteTo(ref output, DebugHitEffectChanceInfo._repeated_chanceFactors_codec);
			bool hasFinalProcChance = this.HasFinalProcChance;
			if (hasFinalProcChance)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.FinalProcChance);
			}
			bool hasRollSuccessful = this.HasRollSuccessful;
			if (hasRollSuccessful)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.RollSuccessful);
			}
			bool hasForceEffect = this.HasForceEffect;
			if (hasForceEffect)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ForceEffect);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x000CFA98 File Offset: 0x000CDC98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasPowerSno = this.HasPowerSno;
			if (hasPowerSno)
			{
				num += 5;
			}
			num += this.chanceFactors_.CalculateSize(DebugHitEffectChanceInfo._repeated_chanceFactors_codec);
			bool hasFinalProcChance = this.HasFinalProcChance;
			if (hasFinalProcChance)
			{
				num += 5;
			}
			bool hasRollSuccessful = this.HasRollSuccessful;
			if (hasRollSuccessful)
			{
				num += 2;
			}
			bool hasForceEffect = this.HasForceEffect;
			if (hasForceEffect)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ForceEffect);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x000CFB50 File Offset: 0x000CDD50
		[DebuggerNonUserCode]
		public void MergeFrom(DebugHitEffectChanceInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasPowerSno = other.HasPowerSno;
				if (hasPowerSno)
				{
					this.PowerSno = other.PowerSno;
				}
				this.chanceFactors_.Add(other.chanceFactors_);
				bool hasFinalProcChance = other.HasFinalProcChance;
				if (hasFinalProcChance)
				{
					this.FinalProcChance = other.FinalProcChance;
				}
				bool hasRollSuccessful = other.HasRollSuccessful;
				if (hasRollSuccessful)
				{
					this.RollSuccessful = other.RollSuccessful;
				}
				bool hasForceEffect = other.HasForceEffect;
				if (hasForceEffect)
				{
					this.ForceEffect = other.ForceEffect;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x000CFC16 File Offset: 0x000CDE16
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000CFC24 File Offset: 0x000CDE24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							if (num3 != 26U)
							{
								goto IL_003A;
							}
							this.chanceFactors_.AddEntriesFrom(ref input, DebugHitEffectChanceInfo._repeated_chanceFactors_codec);
						}
						else
						{
							this.PowerSno = input.ReadSFixed32();
						}
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 37U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_003A;
						}
						this.ForceEffect = input.ReadInt32();
					}
					else
					{
						this.RollSuccessful = input.ReadBool();
					}
				}
				else
				{
					this.FinalProcChance = input.ReadFloat();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001837 RID: 6199
		private static readonly MessageParser<DebugHitEffectChanceInfo> _parser = new MessageParser<DebugHitEffectChanceInfo>(() => new DebugHitEffectChanceInfo());

		// Token: 0x04001838 RID: 6200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001839 RID: 6201
		private int _hasBits0;

		// Token: 0x0400183A RID: 6202
		public const int NameFieldNumber = 1;

		// Token: 0x0400183B RID: 6203
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400183C RID: 6204
		private string name_;

		// Token: 0x0400183D RID: 6205
		public const int PowerSnoFieldNumber = 2;

		// Token: 0x0400183E RID: 6206
		private static readonly int PowerSnoDefaultValue = 0;

		// Token: 0x0400183F RID: 6207
		private int powerSno_;

		// Token: 0x04001840 RID: 6208
		public const int ChanceFactorsFieldNumber = 3;

		// Token: 0x04001841 RID: 6209
		private static readonly FieldCodec<DebugHitEffectFactorInfo> _repeated_chanceFactors_codec = FieldCodec.ForMessage<DebugHitEffectFactorInfo>(26U, DebugHitEffectFactorInfo.Parser);

		// Token: 0x04001842 RID: 6210
		private readonly RepeatedField<DebugHitEffectFactorInfo> chanceFactors_ = new RepeatedField<DebugHitEffectFactorInfo>();

		// Token: 0x04001843 RID: 6211
		public const int FinalProcChanceFieldNumber = 4;

		// Token: 0x04001844 RID: 6212
		private static readonly float FinalProcChanceDefaultValue = 0f;

		// Token: 0x04001845 RID: 6213
		private float finalProcChance_;

		// Token: 0x04001846 RID: 6214
		public const int RollSuccessfulFieldNumber = 5;

		// Token: 0x04001847 RID: 6215
		private static readonly bool RollSuccessfulDefaultValue = false;

		// Token: 0x04001848 RID: 6216
		private bool rollSuccessful_;

		// Token: 0x04001849 RID: 6217
		public const int ForceEffectFieldNumber = 6;

		// Token: 0x0400184A RID: 6218
		private static readonly int ForceEffectDefaultValue = 0;

		// Token: 0x0400184B RID: 6219
		private int forceEffect_;
	}
}
