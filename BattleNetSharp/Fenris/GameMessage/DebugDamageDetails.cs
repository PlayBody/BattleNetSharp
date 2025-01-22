using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E4 RID: 484
	public sealed class DebugDamageDetails : IMessage<DebugDamageDetails>, IMessage, IEquatable<DebugDamageDetails>, IDeepCloneable<DebugDamageDetails>, IBufferMessage
	{
		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06003489 RID: 13449 RVA: 0x000CFD58 File Offset: 0x000CDF58
		[DebuggerNonUserCode]
		public static MessageParser<DebugDamageDetails> Parser
		{
			get
			{
				return DebugDamageDetails._parser;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x000CFD70 File Offset: 0x000CDF70
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[41];
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x000CFD94 File Offset: 0x000CDF94
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugDamageDetails.Descriptor;
			}
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000CFDAB File Offset: 0x000CDFAB
		[DebuggerNonUserCode]
		public DebugDamageDetails()
		{
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x000CFDCC File Offset: 0x000CDFCC
		[DebuggerNonUserCode]
		public DebugDamageDetails(DebugDamageDetails other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.shieldDamageAbsorbed_ = other.shieldDamageAbsorbed_;
			this.remainingShieldTotal_ = other.remainingShieldTotal_;
			this.shieldDamageMultiplier_ = other.shieldDamageMultiplier_;
			this.errorMessages_ = other.errorMessages_.Clone();
			this.hitEffectChances_ = other.hitEffectChances_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x000CFE44 File Offset: 0x000CE044
		[DebuggerNonUserCode]
		public DebugDamageDetails Clone()
		{
			return new DebugDamageDetails(this);
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x000CFE5C File Offset: 0x000CE05C
		// (set) Token: 0x06003490 RID: 13456 RVA: 0x000CFE8D File Offset: 0x000CE08D
		[DebuggerNonUserCode]
		public float ShieldDamageAbsorbed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float shieldDamageAbsorbedDefaultValue;
				if (flag)
				{
					shieldDamageAbsorbedDefaultValue = this.shieldDamageAbsorbed_;
				}
				else
				{
					shieldDamageAbsorbedDefaultValue = DebugDamageDetails.ShieldDamageAbsorbedDefaultValue;
				}
				return shieldDamageAbsorbedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.shieldDamageAbsorbed_ = value;
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x000CFEA8 File Offset: 0x000CE0A8
		[DebuggerNonUserCode]
		public bool HasShieldDamageAbsorbed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x000CFEC5 File Offset: 0x000CE0C5
		[DebuggerNonUserCode]
		public void ClearShieldDamageAbsorbed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x000CFED8 File Offset: 0x000CE0D8
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x000CFF09 File Offset: 0x000CE109
		[DebuggerNonUserCode]
		public float RemainingShieldTotal
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float remainingShieldTotalDefaultValue;
				if (flag)
				{
					remainingShieldTotalDefaultValue = this.remainingShieldTotal_;
				}
				else
				{
					remainingShieldTotalDefaultValue = DebugDamageDetails.RemainingShieldTotalDefaultValue;
				}
				return remainingShieldTotalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.remainingShieldTotal_ = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x000CFF24 File Offset: 0x000CE124
		[DebuggerNonUserCode]
		public bool HasRemainingShieldTotal
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x000CFF41 File Offset: 0x000CE141
		[DebuggerNonUserCode]
		public void ClearRemainingShieldTotal()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x000CFF54 File Offset: 0x000CE154
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x000CFF85 File Offset: 0x000CE185
		[DebuggerNonUserCode]
		public float ShieldDamageMultiplier
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float shieldDamageMultiplierDefaultValue;
				if (flag)
				{
					shieldDamageMultiplierDefaultValue = this.shieldDamageMultiplier_;
				}
				else
				{
					shieldDamageMultiplierDefaultValue = DebugDamageDetails.ShieldDamageMultiplierDefaultValue;
				}
				return shieldDamageMultiplierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.shieldDamageMultiplier_ = value;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x000CFFA0 File Offset: 0x000CE1A0
		[DebuggerNonUserCode]
		public bool HasShieldDamageMultiplier
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x000CFFBD File Offset: 0x000CE1BD
		[DebuggerNonUserCode]
		public void ClearShieldDamageMultiplier()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x0600349B RID: 13467 RVA: 0x000CFFD0 File Offset: 0x000CE1D0
		[DebuggerNonUserCode]
		public RepeatedField<string> ErrorMessages
		{
			get
			{
				return this.errorMessages_;
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x000CFFE8 File Offset: 0x000CE1E8
		[DebuggerNonUserCode]
		public RepeatedField<DebugHitEffectChanceInfo> HitEffectChances
		{
			get
			{
				return this.hitEffectChances_;
			}
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x000D0000 File Offset: 0x000CE200
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugDamageDetails);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x000D0020 File Offset: 0x000CE220
		[DebuggerNonUserCode]
		public bool Equals(DebugDamageDetails other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ShieldDamageAbsorbed, other.ShieldDamageAbsorbed);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.RemainingShieldTotal, other.RemainingShieldTotal);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ShieldDamageMultiplier, other.ShieldDamageMultiplier);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.errorMessages_.Equals(other.errorMessages_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.hitEffectChances_.Equals(other.hitEffectChances_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000D010C File Offset: 0x000CE30C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasShieldDamageAbsorbed = this.HasShieldDamageAbsorbed;
			if (hasShieldDamageAbsorbed)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ShieldDamageAbsorbed);
			}
			bool hasRemainingShieldTotal = this.HasRemainingShieldTotal;
			if (hasRemainingShieldTotal)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.RemainingShieldTotal);
			}
			bool hasShieldDamageMultiplier = this.HasShieldDamageMultiplier;
			if (hasShieldDamageMultiplier)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ShieldDamageMultiplier);
			}
			num ^= this.errorMessages_.GetHashCode();
			num ^= this.hitEffectChances_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000D01B8 File Offset: 0x000CE3B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x000D01D0 File Offset: 0x000CE3D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x000D01DC File Offset: 0x000CE3DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasShieldDamageAbsorbed = this.HasShieldDamageAbsorbed;
			if (hasShieldDamageAbsorbed)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.ShieldDamageAbsorbed);
			}
			bool hasRemainingShieldTotal = this.HasRemainingShieldTotal;
			if (hasRemainingShieldTotal)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.RemainingShieldTotal);
			}
			bool hasShieldDamageMultiplier = this.HasShieldDamageMultiplier;
			if (hasShieldDamageMultiplier)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.ShieldDamageMultiplier);
			}
			this.errorMessages_.WriteTo(ref output, DebugDamageDetails._repeated_errorMessages_codec);
			this.hitEffectChances_.WriteTo(ref output, DebugDamageDetails._repeated_hitEffectChances_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x000D0290 File Offset: 0x000CE490
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasShieldDamageAbsorbed = this.HasShieldDamageAbsorbed;
			if (hasShieldDamageAbsorbed)
			{
				num += 5;
			}
			bool hasRemainingShieldTotal = this.HasRemainingShieldTotal;
			if (hasRemainingShieldTotal)
			{
				num += 5;
			}
			bool hasShieldDamageMultiplier = this.HasShieldDamageMultiplier;
			if (hasShieldDamageMultiplier)
			{
				num += 5;
			}
			num += this.errorMessages_.CalculateSize(DebugDamageDetails._repeated_errorMessages_codec);
			num += this.hitEffectChances_.CalculateSize(DebugDamageDetails._repeated_hitEffectChances_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x000D031C File Offset: 0x000CE51C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugDamageDetails other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasShieldDamageAbsorbed = other.HasShieldDamageAbsorbed;
				if (hasShieldDamageAbsorbed)
				{
					this.ShieldDamageAbsorbed = other.ShieldDamageAbsorbed;
				}
				bool hasRemainingShieldTotal = other.HasRemainingShieldTotal;
				if (hasRemainingShieldTotal)
				{
					this.RemainingShieldTotal = other.RemainingShieldTotal;
				}
				bool hasShieldDamageMultiplier = other.HasShieldDamageMultiplier;
				if (hasShieldDamageMultiplier)
				{
					this.ShieldDamageMultiplier = other.ShieldDamageMultiplier;
				}
				this.errorMessages_.Add(other.errorMessages_);
				this.hitEffectChances_.Add(other.hitEffectChances_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000D03BE File Offset: 0x000CE5BE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000D03CC File Offset: 0x000CE5CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 13U)
					{
						if (num3 != 21U)
						{
							goto IL_0033;
						}
						this.RemainingShieldTotal = input.ReadFloat();
					}
					else
					{
						this.ShieldDamageAbsorbed = input.ReadFloat();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0033;
						}
						this.hitEffectChances_.AddEntriesFrom(ref input, DebugDamageDetails._repeated_hitEffectChances_codec);
					}
					else
					{
						this.errorMessages_.AddEntriesFrom(ref input, DebugDamageDetails._repeated_errorMessages_codec);
					}
				}
				else
				{
					this.ShieldDamageMultiplier = input.ReadFloat();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400184C RID: 6220
		private static readonly MessageParser<DebugDamageDetails> _parser = new MessageParser<DebugDamageDetails>(() => new DebugDamageDetails());

		// Token: 0x0400184D RID: 6221
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400184E RID: 6222
		private int _hasBits0;

		// Token: 0x0400184F RID: 6223
		public const int ShieldDamageAbsorbedFieldNumber = 1;

		// Token: 0x04001850 RID: 6224
		private static readonly float ShieldDamageAbsorbedDefaultValue = 0f;

		// Token: 0x04001851 RID: 6225
		private float shieldDamageAbsorbed_;

		// Token: 0x04001852 RID: 6226
		public const int RemainingShieldTotalFieldNumber = 2;

		// Token: 0x04001853 RID: 6227
		private static readonly float RemainingShieldTotalDefaultValue = 0f;

		// Token: 0x04001854 RID: 6228
		private float remainingShieldTotal_;

		// Token: 0x04001855 RID: 6229
		public const int ShieldDamageMultiplierFieldNumber = 3;

		// Token: 0x04001856 RID: 6230
		private static readonly float ShieldDamageMultiplierDefaultValue = 0f;

		// Token: 0x04001857 RID: 6231
		private float shieldDamageMultiplier_;

		// Token: 0x04001858 RID: 6232
		public const int ErrorMessagesFieldNumber = 4;

		// Token: 0x04001859 RID: 6233
		private static readonly FieldCodec<string> _repeated_errorMessages_codec = FieldCodec.ForString(34U);

		// Token: 0x0400185A RID: 6234
		private readonly RepeatedField<string> errorMessages_ = new RepeatedField<string>();

		// Token: 0x0400185B RID: 6235
		public const int HitEffectChancesFieldNumber = 5;

		// Token: 0x0400185C RID: 6236
		private static readonly FieldCodec<DebugHitEffectChanceInfo> _repeated_hitEffectChances_codec = FieldCodec.ForMessage<DebugHitEffectChanceInfo>(42U, DebugHitEffectChanceInfo.Parser);

		// Token: 0x0400185D RID: 6237
		private readonly RepeatedField<DebugHitEffectChanceInfo> hitEffectChances_ = new RepeatedField<DebugHitEffectChanceInfo>();
	}
}
