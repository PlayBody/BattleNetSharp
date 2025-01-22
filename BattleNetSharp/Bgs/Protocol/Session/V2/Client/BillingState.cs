using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200056C RID: 1388
	public sealed class BillingState : IMessage<BillingState>, IMessage, IEquatable<BillingState>, IDeepCloneable<BillingState>, IBufferMessage
	{
		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0600857D RID: 34173 RVA: 0x00206ED0 File Offset: 0x002050D0
		[DebuggerNonUserCode]
		public static MessageParser<BillingState> Parser
		{
			get
			{
				return BillingState._parser;
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600857E RID: 34174 RVA: 0x00206EE8 File Offset: 0x002050E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x0600857F RID: 34175 RVA: 0x00206F0C File Offset: 0x0020510C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BillingState.Descriptor;
			}
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x00206F23 File Offset: 0x00205123
		[DebuggerNonUserCode]
		public BillingState()
		{
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x00206F30 File Offset: 0x00205130
		[DebuggerNonUserCode]
		public BillingState(BillingState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.benefactor_ = ((other.benefactor_ != null) ? other.benefactor_.Clone() : null);
			this.billingEnabled_ = other.billingEnabled_;
			this.freeSession_ = other.freeSession_;
			this.usingLifeTimeLicense_ = other.usingLifeTimeLicense_;
			this.usingSubscription_ = other.usingSubscription_;
			this.consumptionGameTime_ = other.consumptionGameTime_;
			this.expireTimeMs_ = other.expireTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x00206FC8 File Offset: 0x002051C8
		[DebuggerNonUserCode]
		public BillingState Clone()
		{
			return new BillingState(this);
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x06008583 RID: 34179 RVA: 0x00206FE0 File Offset: 0x002051E0
		// (set) Token: 0x06008584 RID: 34180 RVA: 0x00206FF8 File Offset: 0x002051F8
		[DebuggerNonUserCode]
		public BenefactorState Benefactor
		{
			get
			{
				return this.benefactor_;
			}
			set
			{
				this.benefactor_ = value;
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x06008585 RID: 34181 RVA: 0x00207004 File Offset: 0x00205204
		// (set) Token: 0x06008586 RID: 34182 RVA: 0x00207035 File Offset: 0x00205235
		[DebuggerNonUserCode]
		public bool BillingEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool billingEnabledDefaultValue;
				if (flag)
				{
					billingEnabledDefaultValue = this.billingEnabled_;
				}
				else
				{
					billingEnabledDefaultValue = BillingState.BillingEnabledDefaultValue;
				}
				return billingEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.billingEnabled_ = value;
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x06008587 RID: 34183 RVA: 0x00207050 File Offset: 0x00205250
		[DebuggerNonUserCode]
		public bool HasBillingEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008588 RID: 34184 RVA: 0x0020706D File Offset: 0x0020526D
		[DebuggerNonUserCode]
		public void ClearBillingEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x00207080 File Offset: 0x00205280
		// (set) Token: 0x0600858A RID: 34186 RVA: 0x002070B1 File Offset: 0x002052B1
		[DebuggerNonUserCode]
		public bool FreeSession
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool freeSessionDefaultValue;
				if (flag)
				{
					freeSessionDefaultValue = this.freeSession_;
				}
				else
				{
					freeSessionDefaultValue = BillingState.FreeSessionDefaultValue;
				}
				return freeSessionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.freeSession_ = value;
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x0600858B RID: 34187 RVA: 0x002070CC File Offset: 0x002052CC
		[DebuggerNonUserCode]
		public bool HasFreeSession
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x002070E9 File Offset: 0x002052E9
		[DebuggerNonUserCode]
		public void ClearFreeSession()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0600858D RID: 34189 RVA: 0x002070FC File Offset: 0x002052FC
		// (set) Token: 0x0600858E RID: 34190 RVA: 0x0020712D File Offset: 0x0020532D
		[DebuggerNonUserCode]
		public bool UsingLifeTimeLicense
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool usingLifeTimeLicenseDefaultValue;
				if (flag)
				{
					usingLifeTimeLicenseDefaultValue = this.usingLifeTimeLicense_;
				}
				else
				{
					usingLifeTimeLicenseDefaultValue = BillingState.UsingLifeTimeLicenseDefaultValue;
				}
				return usingLifeTimeLicenseDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.usingLifeTimeLicense_ = value;
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x0600858F RID: 34191 RVA: 0x00207148 File Offset: 0x00205348
		[DebuggerNonUserCode]
		public bool HasUsingLifeTimeLicense
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008590 RID: 34192 RVA: 0x00207165 File Offset: 0x00205365
		[DebuggerNonUserCode]
		public void ClearUsingLifeTimeLicense()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x00207178 File Offset: 0x00205378
		// (set) Token: 0x06008592 RID: 34194 RVA: 0x002071A9 File Offset: 0x002053A9
		[DebuggerNonUserCode]
		public bool UsingSubscription
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool usingSubscriptionDefaultValue;
				if (flag)
				{
					usingSubscriptionDefaultValue = this.usingSubscription_;
				}
				else
				{
					usingSubscriptionDefaultValue = BillingState.UsingSubscriptionDefaultValue;
				}
				return usingSubscriptionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.usingSubscription_ = value;
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06008593 RID: 34195 RVA: 0x002071C4 File Offset: 0x002053C4
		[DebuggerNonUserCode]
		public bool HasUsingSubscription
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x002071E1 File Offset: 0x002053E1
		[DebuggerNonUserCode]
		public void ClearUsingSubscription()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x002071F4 File Offset: 0x002053F4
		// (set) Token: 0x06008596 RID: 34198 RVA: 0x00207226 File Offset: 0x00205426
		[DebuggerNonUserCode]
		public uint ConsumptionGameTime
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint consumptionGameTimeDefaultValue;
				if (flag)
				{
					consumptionGameTimeDefaultValue = this.consumptionGameTime_;
				}
				else
				{
					consumptionGameTimeDefaultValue = BillingState.ConsumptionGameTimeDefaultValue;
				}
				return consumptionGameTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.consumptionGameTime_ = value;
			}
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x00207240 File Offset: 0x00205440
		[DebuggerNonUserCode]
		public bool HasConsumptionGameTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06008598 RID: 34200 RVA: 0x0020725E File Offset: 0x0020545E
		[DebuggerNonUserCode]
		public void ClearConsumptionGameTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x06008599 RID: 34201 RVA: 0x00207270 File Offset: 0x00205470
		// (set) Token: 0x0600859A RID: 34202 RVA: 0x002072A2 File Offset: 0x002054A2
		[DebuggerNonUserCode]
		public ulong ExpireTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				ulong expireTimeMsDefaultValue;
				if (flag)
				{
					expireTimeMsDefaultValue = this.expireTimeMs_;
				}
				else
				{
					expireTimeMsDefaultValue = BillingState.ExpireTimeMsDefaultValue;
				}
				return expireTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.expireTimeMs_ = value;
			}
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x0600859B RID: 34203 RVA: 0x002072BC File Offset: 0x002054BC
		[DebuggerNonUserCode]
		public bool HasExpireTimeMs
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x002072DA File Offset: 0x002054DA
		[DebuggerNonUserCode]
		public void ClearExpireTimeMs()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x002072EC File Offset: 0x002054EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BillingState);
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x0020730C File Offset: 0x0020550C
		[DebuggerNonUserCode]
		public bool Equals(BillingState other)
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
					bool flag4 = !object.Equals(this.Benefactor, other.Benefactor);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BillingEnabled != other.BillingEnabled;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FreeSession != other.FreeSession;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.UsingLifeTimeLicense != other.UsingLifeTimeLicense;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.UsingSubscription != other.UsingSubscription;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ConsumptionGameTime != other.ConsumptionGameTime;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ExpireTimeMs != other.ExpireTimeMs;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600859F RID: 34207 RVA: 0x00207418 File Offset: 0x00205618
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.benefactor_ != null;
			if (flag)
			{
				num ^= this.Benefactor.GetHashCode();
			}
			bool hasBillingEnabled = this.HasBillingEnabled;
			if (hasBillingEnabled)
			{
				num ^= this.BillingEnabled.GetHashCode();
			}
			bool hasFreeSession = this.HasFreeSession;
			if (hasFreeSession)
			{
				num ^= this.FreeSession.GetHashCode();
			}
			bool hasUsingLifeTimeLicense = this.HasUsingLifeTimeLicense;
			if (hasUsingLifeTimeLicense)
			{
				num ^= this.UsingLifeTimeLicense.GetHashCode();
			}
			bool hasUsingSubscription = this.HasUsingSubscription;
			if (hasUsingSubscription)
			{
				num ^= this.UsingSubscription.GetHashCode();
			}
			bool hasConsumptionGameTime = this.HasConsumptionGameTime;
			if (hasConsumptionGameTime)
			{
				num ^= this.ConsumptionGameTime.GetHashCode();
			}
			bool hasExpireTimeMs = this.HasExpireTimeMs;
			if (hasExpireTimeMs)
			{
				num ^= this.ExpireTimeMs.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x00207518 File Offset: 0x00205718
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x00207530 File Offset: 0x00205730
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x0020753C File Offset: 0x0020573C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.benefactor_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Benefactor);
			}
			bool hasBillingEnabled = this.HasBillingEnabled;
			if (hasBillingEnabled)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.BillingEnabled);
			}
			bool hasFreeSession = this.HasFreeSession;
			if (hasFreeSession)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FreeSession);
			}
			bool hasUsingLifeTimeLicense = this.HasUsingLifeTimeLicense;
			if (hasUsingLifeTimeLicense)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.UsingLifeTimeLicense);
			}
			bool hasUsingSubscription = this.HasUsingSubscription;
			if (hasUsingSubscription)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.UsingSubscription);
			}
			bool hasConsumptionGameTime = this.HasConsumptionGameTime;
			if (hasConsumptionGameTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ConsumptionGameTime);
			}
			bool hasExpireTimeMs = this.HasExpireTimeMs;
			if (hasExpireTimeMs)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.ExpireTimeMs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085A3 RID: 34211 RVA: 0x00207660 File Offset: 0x00205860
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.benefactor_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Benefactor);
			}
			bool hasBillingEnabled = this.HasBillingEnabled;
			if (hasBillingEnabled)
			{
				num += 2;
			}
			bool hasFreeSession = this.HasFreeSession;
			if (hasFreeSession)
			{
				num += 2;
			}
			bool hasUsingLifeTimeLicense = this.HasUsingLifeTimeLicense;
			if (hasUsingLifeTimeLicense)
			{
				num += 2;
			}
			bool hasUsingSubscription = this.HasUsingSubscription;
			if (hasUsingSubscription)
			{
				num += 2;
			}
			bool hasConsumptionGameTime = this.HasConsumptionGameTime;
			if (hasConsumptionGameTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConsumptionGameTime);
			}
			bool hasExpireTimeMs = this.HasExpireTimeMs;
			if (hasExpireTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpireTimeMs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x00207738 File Offset: 0x00205938
		[DebuggerNonUserCode]
		public void MergeFrom(BillingState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.benefactor_ != null;
				if (flag2)
				{
					bool flag3 = this.benefactor_ == null;
					if (flag3)
					{
						this.Benefactor = new BenefactorState();
					}
					this.Benefactor.MergeFrom(other.Benefactor);
				}
				bool hasBillingEnabled = other.HasBillingEnabled;
				if (hasBillingEnabled)
				{
					this.BillingEnabled = other.BillingEnabled;
				}
				bool hasFreeSession = other.HasFreeSession;
				if (hasFreeSession)
				{
					this.FreeSession = other.FreeSession;
				}
				bool hasUsingLifeTimeLicense = other.HasUsingLifeTimeLicense;
				if (hasUsingLifeTimeLicense)
				{
					this.UsingLifeTimeLicense = other.UsingLifeTimeLicense;
				}
				bool hasUsingSubscription = other.HasUsingSubscription;
				if (hasUsingSubscription)
				{
					this.UsingSubscription = other.UsingSubscription;
				}
				bool hasConsumptionGameTime = other.HasConsumptionGameTime;
				if (hasConsumptionGameTime)
				{
					this.ConsumptionGameTime = other.ConsumptionGameTime;
				}
				bool hasExpireTimeMs = other.HasExpireTimeMs;
				if (hasExpireTimeMs)
				{
					this.ExpireTimeMs = other.ExpireTimeMs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x00207847 File Offset: 0x00205A47
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x00207854 File Offset: 0x00205A54
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0055;
							}
							this.FreeSession = input.ReadBool();
						}
						else
						{
							this.BillingEnabled = input.ReadBool();
						}
					}
					else
					{
						bool flag = this.benefactor_ == null;
						if (flag)
						{
							this.Benefactor = new BenefactorState();
						}
						input.ReadMessage(this.Benefactor);
					}
				}
				else if (num3 <= 40U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0055;
						}
						this.UsingSubscription = input.ReadBool();
					}
					else
					{
						this.UsingLifeTimeLicense = input.ReadBool();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_0055;
					}
					this.ExpireTimeMs = input.ReadUInt64();
				}
				else
				{
					this.ConsumptionGameTime = input.ReadUInt32();
				}
				continue;
				IL_0055:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C8C RID: 15500
		private static readonly MessageParser<BillingState> _parser = new MessageParser<BillingState>(() => new BillingState());

		// Token: 0x04003C8D RID: 15501
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C8E RID: 15502
		private int _hasBits0;

		// Token: 0x04003C8F RID: 15503
		public const int BenefactorFieldNumber = 1;

		// Token: 0x04003C90 RID: 15504
		private BenefactorState benefactor_;

		// Token: 0x04003C91 RID: 15505
		public const int BillingEnabledFieldNumber = 2;

		// Token: 0x04003C92 RID: 15506
		private static readonly bool BillingEnabledDefaultValue = false;

		// Token: 0x04003C93 RID: 15507
		private bool billingEnabled_;

		// Token: 0x04003C94 RID: 15508
		public const int FreeSessionFieldNumber = 3;

		// Token: 0x04003C95 RID: 15509
		private static readonly bool FreeSessionDefaultValue = false;

		// Token: 0x04003C96 RID: 15510
		private bool freeSession_;

		// Token: 0x04003C97 RID: 15511
		public const int UsingLifeTimeLicenseFieldNumber = 4;

		// Token: 0x04003C98 RID: 15512
		private static readonly bool UsingLifeTimeLicenseDefaultValue = false;

		// Token: 0x04003C99 RID: 15513
		private bool usingLifeTimeLicense_;

		// Token: 0x04003C9A RID: 15514
		public const int UsingSubscriptionFieldNumber = 5;

		// Token: 0x04003C9B RID: 15515
		private static readonly bool UsingSubscriptionDefaultValue = false;

		// Token: 0x04003C9C RID: 15516
		private bool usingSubscription_;

		// Token: 0x04003C9D RID: 15517
		public const int ConsumptionGameTimeFieldNumber = 6;

		// Token: 0x04003C9E RID: 15518
		private static readonly uint ConsumptionGameTimeDefaultValue = 0U;

		// Token: 0x04003C9F RID: 15519
		private uint consumptionGameTime_;

		// Token: 0x04003CA0 RID: 15520
		public const int ExpireTimeMsFieldNumber = 7;

		// Token: 0x04003CA1 RID: 15521
		private static readonly ulong ExpireTimeMsDefaultValue = 0UL;

		// Token: 0x04003CA2 RID: 15522
		private ulong expireTimeMs_;
	}
}
