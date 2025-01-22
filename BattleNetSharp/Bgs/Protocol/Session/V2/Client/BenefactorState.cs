using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000570 RID: 1392
	public sealed class BenefactorState : IMessage<BenefactorState>, IMessage, IEquatable<BenefactorState>, IDeepCloneable<BenefactorState>, IBufferMessage
	{
		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x060085F7 RID: 34295 RVA: 0x00208AC0 File Offset: 0x00206CC0
		[DebuggerNonUserCode]
		public static MessageParser<BenefactorState> Parser
		{
			get
			{
				return BenefactorState._parser;
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x060085F8 RID: 34296 RVA: 0x00208AD8 File Offset: 0x00206CD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x060085F9 RID: 34297 RVA: 0x00208AFC File Offset: 0x00206CFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BenefactorState.Descriptor;
			}
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x00208B13 File Offset: 0x00206D13
		[DebuggerNonUserCode]
		public BenefactorState()
		{
		}

		// Token: 0x060085FB RID: 34299 RVA: 0x00208B20 File Offset: 0x00206D20
		[DebuggerNonUserCode]
		public BenefactorState(BenefactorState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.benefactorId_ = ((other.benefactorId_ != null) ? other.benefactorId_.Clone() : null);
			this.registeredLocation_ = other.registeredLocation_;
			this.activated_ = other.activated_;
			this.igrPaid_ = other.igrPaid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085FC RID: 34300 RVA: 0x00208B94 File Offset: 0x00206D94
		[DebuggerNonUserCode]
		public BenefactorState Clone()
		{
			return new BenefactorState(this);
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x060085FD RID: 34301 RVA: 0x00208BAC File Offset: 0x00206DAC
		// (set) Token: 0x060085FE RID: 34302 RVA: 0x00208BC4 File Offset: 0x00206DC4
		[DebuggerNonUserCode]
		public BenefactorId BenefactorId
		{
			get
			{
				return this.benefactorId_;
			}
			set
			{
				this.benefactorId_ = value;
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x060085FF RID: 34303 RVA: 0x00208BD0 File Offset: 0x00206DD0
		// (set) Token: 0x06008600 RID: 34304 RVA: 0x00208C01 File Offset: 0x00206E01
		[DebuggerNonUserCode]
		public bool RegisteredLocation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool registeredLocationDefaultValue;
				if (flag)
				{
					registeredLocationDefaultValue = this.registeredLocation_;
				}
				else
				{
					registeredLocationDefaultValue = BenefactorState.RegisteredLocationDefaultValue;
				}
				return registeredLocationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.registeredLocation_ = value;
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x06008601 RID: 34305 RVA: 0x00208C1C File Offset: 0x00206E1C
		[DebuggerNonUserCode]
		public bool HasRegisteredLocation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x00208C39 File Offset: 0x00206E39
		[DebuggerNonUserCode]
		public void ClearRegisteredLocation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x06008603 RID: 34307 RVA: 0x00208C4C File Offset: 0x00206E4C
		// (set) Token: 0x06008604 RID: 34308 RVA: 0x00208C7D File Offset: 0x00206E7D
		[DebuggerNonUserCode]
		public bool Activated
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool activatedDefaultValue;
				if (flag)
				{
					activatedDefaultValue = this.activated_;
				}
				else
				{
					activatedDefaultValue = BenefactorState.ActivatedDefaultValue;
				}
				return activatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.activated_ = value;
			}
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x06008605 RID: 34309 RVA: 0x00208C98 File Offset: 0x00206E98
		[DebuggerNonUserCode]
		public bool HasActivated
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008606 RID: 34310 RVA: 0x00208CB5 File Offset: 0x00206EB5
		[DebuggerNonUserCode]
		public void ClearActivated()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x06008607 RID: 34311 RVA: 0x00208CC8 File Offset: 0x00206EC8
		// (set) Token: 0x06008608 RID: 34312 RVA: 0x00208CF9 File Offset: 0x00206EF9
		[DebuggerNonUserCode]
		public bool IgrPaid
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool igrPaidDefaultValue;
				if (flag)
				{
					igrPaidDefaultValue = this.igrPaid_;
				}
				else
				{
					igrPaidDefaultValue = BenefactorState.IgrPaidDefaultValue;
				}
				return igrPaidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.igrPaid_ = value;
			}
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x00208D14 File Offset: 0x00206F14
		[DebuggerNonUserCode]
		public bool HasIgrPaid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x00208D31 File Offset: 0x00206F31
		[DebuggerNonUserCode]
		public void ClearIgrPaid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x00208D44 File Offset: 0x00206F44
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BenefactorState);
		}

		// Token: 0x0600860C RID: 34316 RVA: 0x00208D64 File Offset: 0x00206F64
		[DebuggerNonUserCode]
		public bool Equals(BenefactorState other)
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
					bool flag4 = !object.Equals(this.BenefactorId, other.BenefactorId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RegisteredLocation != other.RegisteredLocation;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Activated != other.Activated;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IgrPaid != other.IgrPaid;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600860D RID: 34317 RVA: 0x00208E14 File Offset: 0x00207014
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.benefactorId_ != null;
			if (flag)
			{
				num ^= this.BenefactorId.GetHashCode();
			}
			bool hasRegisteredLocation = this.HasRegisteredLocation;
			if (hasRegisteredLocation)
			{
				num ^= this.RegisteredLocation.GetHashCode();
			}
			bool hasActivated = this.HasActivated;
			if (hasActivated)
			{
				num ^= this.Activated.GetHashCode();
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				num ^= this.IgrPaid.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x00208EBC File Offset: 0x002070BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600860F RID: 34319 RVA: 0x00208ED4 File Offset: 0x002070D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x00208EE0 File Offset: 0x002070E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.benefactorId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BenefactorId);
			}
			bool hasRegisteredLocation = this.HasRegisteredLocation;
			if (hasRegisteredLocation)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.RegisteredLocation);
			}
			bool hasActivated = this.HasActivated;
			if (hasActivated)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Activated);
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IgrPaid);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x00208F98 File Offset: 0x00207198
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.benefactorId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BenefactorId);
			}
			bool hasRegisteredLocation = this.HasRegisteredLocation;
			if (hasRegisteredLocation)
			{
				num += 2;
			}
			bool hasActivated = this.HasActivated;
			if (hasActivated)
			{
				num += 2;
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
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

		// Token: 0x06008612 RID: 34322 RVA: 0x00209020 File Offset: 0x00207220
		[DebuggerNonUserCode]
		public void MergeFrom(BenefactorState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.benefactorId_ != null;
				if (flag2)
				{
					bool flag3 = this.benefactorId_ == null;
					if (flag3)
					{
						this.BenefactorId = new BenefactorId();
					}
					this.BenefactorId.MergeFrom(other.BenefactorId);
				}
				bool hasRegisteredLocation = other.HasRegisteredLocation;
				if (hasRegisteredLocation)
				{
					this.RegisteredLocation = other.RegisteredLocation;
				}
				bool hasActivated = other.HasActivated;
				if (hasActivated)
				{
					this.Activated = other.Activated;
				}
				bool hasIgrPaid = other.HasIgrPaid;
				if (hasIgrPaid)
				{
					this.IgrPaid = other.IgrPaid;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x002090DE File Offset: 0x002072DE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x002090EC File Offset: 0x002072EC
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.RegisteredLocation = input.ReadBool();
					}
					else
					{
						bool flag = this.benefactorId_ == null;
						if (flag)
						{
							this.BenefactorId = new BenefactorId();
						}
						input.ReadMessage(this.BenefactorId);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.IgrPaid = input.ReadBool();
				}
				else
				{
					this.Activated = input.ReadBool();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003CBE RID: 15550
		private static readonly MessageParser<BenefactorState> _parser = new MessageParser<BenefactorState>(() => new BenefactorState());

		// Token: 0x04003CBF RID: 15551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CC0 RID: 15552
		private int _hasBits0;

		// Token: 0x04003CC1 RID: 15553
		public const int BenefactorIdFieldNumber = 1;

		// Token: 0x04003CC2 RID: 15554
		private BenefactorId benefactorId_;

		// Token: 0x04003CC3 RID: 15555
		public const int RegisteredLocationFieldNumber = 2;

		// Token: 0x04003CC4 RID: 15556
		private static readonly bool RegisteredLocationDefaultValue = false;

		// Token: 0x04003CC5 RID: 15557
		private bool registeredLocation_;

		// Token: 0x04003CC6 RID: 15558
		public const int ActivatedFieldNumber = 3;

		// Token: 0x04003CC7 RID: 15559
		private static readonly bool ActivatedDefaultValue = false;

		// Token: 0x04003CC8 RID: 15560
		private bool activated_;

		// Token: 0x04003CC9 RID: 15561
		public const int IgrPaidFieldNumber = 4;

		// Token: 0x04003CCA RID: 15562
		private static readonly bool IgrPaidDefaultValue = false;

		// Token: 0x04003CCB RID: 15563
		private bool igrPaid_;
	}
}
