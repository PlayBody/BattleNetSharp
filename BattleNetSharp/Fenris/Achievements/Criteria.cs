using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C4 RID: 708
	public sealed class Criteria : IMessage<Criteria>, IMessage, IEquatable<Criteria>, IDeepCloneable<Criteria>, IBufferMessage
	{
		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x0011FF90 File Offset: 0x0011E190
		[DebuggerNonUserCode]
		public static MessageParser<Criteria> Parser
		{
			get
			{
				return Criteria._parser;
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x0011FFA8 File Offset: 0x0011E1A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x0011FFCC File Offset: 0x0011E1CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Criteria.Descriptor;
			}
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x0011FFE3 File Offset: 0x0011E1E3
		[DebuggerNonUserCode]
		public Criteria()
		{
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x0011FFF0 File Offset: 0x0011E1F0
		[DebuggerNonUserCode]
		public Criteria(Criteria other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.criteriaId_ = other.criteriaId_;
			this.startTime_ = other.startTime_;
			this.updateTime_ = other.updateTime_;
			this.quantity_ = other.quantity_;
			this.flags_ = other.flags_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00120060 File Offset: 0x0011E260
		[DebuggerNonUserCode]
		public Criteria Clone()
		{
			return new Criteria(this);
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06004B39 RID: 19257 RVA: 0x00120078 File Offset: 0x0011E278
		// (set) Token: 0x06004B3A RID: 19258 RVA: 0x001200A9 File Offset: 0x0011E2A9
		[DebuggerNonUserCode]
		public uint CriteriaId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint criteriaIdDefaultValue;
				if (flag)
				{
					criteriaIdDefaultValue = this.criteriaId_;
				}
				else
				{
					criteriaIdDefaultValue = Criteria.CriteriaIdDefaultValue;
				}
				return criteriaIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.criteriaId_ = value;
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06004B3B RID: 19259 RVA: 0x001200C4 File Offset: 0x0011E2C4
		[DebuggerNonUserCode]
		public bool HasCriteriaId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x001200E1 File Offset: 0x0011E2E1
		[DebuggerNonUserCode]
		public void ClearCriteriaId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004B3D RID: 19261 RVA: 0x001200F4 File Offset: 0x0011E2F4
		// (set) Token: 0x06004B3E RID: 19262 RVA: 0x00120125 File Offset: 0x0011E325
		[DebuggerNonUserCode]
		public ulong StartTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong startTimeDefaultValue;
				if (flag)
				{
					startTimeDefaultValue = this.startTime_;
				}
				else
				{
					startTimeDefaultValue = Criteria.StartTimeDefaultValue;
				}
				return startTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.startTime_ = value;
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004B3F RID: 19263 RVA: 0x00120140 File Offset: 0x0011E340
		[DebuggerNonUserCode]
		public bool HasStartTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x0012015D File Offset: 0x0011E35D
		[DebuggerNonUserCode]
		public void ClearStartTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x00120170 File Offset: 0x0011E370
		// (set) Token: 0x06004B42 RID: 19266 RVA: 0x001201A1 File Offset: 0x0011E3A1
		[DebuggerNonUserCode]
		public ulong UpdateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong updateTimeDefaultValue;
				if (flag)
				{
					updateTimeDefaultValue = this.updateTime_;
				}
				else
				{
					updateTimeDefaultValue = Criteria.UpdateTimeDefaultValue;
				}
				return updateTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.updateTime_ = value;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004B43 RID: 19267 RVA: 0x001201BC File Offset: 0x0011E3BC
		[DebuggerNonUserCode]
		public bool HasUpdateTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x001201D9 File Offset: 0x0011E3D9
		[DebuggerNonUserCode]
		public void ClearUpdateTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004B45 RID: 19269 RVA: 0x001201EC File Offset: 0x0011E3EC
		// (set) Token: 0x06004B46 RID: 19270 RVA: 0x0012021D File Offset: 0x0011E41D
		[DebuggerNonUserCode]
		public ulong Quantity
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong quantityDefaultValue;
				if (flag)
				{
					quantityDefaultValue = this.quantity_;
				}
				else
				{
					quantityDefaultValue = Criteria.QuantityDefaultValue;
				}
				return quantityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.quantity_ = value;
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x00120238 File Offset: 0x0011E438
		[DebuggerNonUserCode]
		public bool HasQuantity
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x00120255 File Offset: 0x0011E455
		[DebuggerNonUserCode]
		public void ClearQuantity()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x00120268 File Offset: 0x0011E468
		// (set) Token: 0x06004B4A RID: 19274 RVA: 0x0012029A File Offset: 0x0011E49A
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = Criteria.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.flags_ = value;
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x001202B4 File Offset: 0x0011E4B4
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x001202D2 File Offset: 0x0011E4D2
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x001202E4 File Offset: 0x0011E4E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Criteria);
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x00120304 File Offset: 0x0011E504
		[DebuggerNonUserCode]
		public bool Equals(Criteria other)
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
					bool flag4 = this.CriteriaId != other.CriteriaId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StartTime != other.StartTime;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.UpdateTime != other.UpdateTime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Quantity != other.Quantity;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Flags != other.Flags;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x001203D0 File Offset: 0x0011E5D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCriteriaId = this.HasCriteriaId;
			if (hasCriteriaId)
			{
				num ^= this.CriteriaId.GetHashCode();
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num ^= this.StartTime.GetHashCode();
			}
			bool hasUpdateTime = this.HasUpdateTime;
			if (hasUpdateTime)
			{
				num ^= this.UpdateTime.GetHashCode();
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num ^= this.Quantity.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x00120498 File Offset: 0x0011E698
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x001204B0 File Offset: 0x0011E6B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x001204BC File Offset: 0x0011E6BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCriteriaId = this.HasCriteriaId;
			if (hasCriteriaId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CriteriaId);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.StartTime);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Quantity);
			}
			bool hasUpdateTime = this.HasUpdateTime;
			if (hasUpdateTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.UpdateTime);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Flags);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x00120594 File Offset: 0x0011E794
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCriteriaId = this.HasCriteriaId;
			if (hasCriteriaId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CriteriaId);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartTime);
			}
			bool hasUpdateTime = this.HasUpdateTime;
			if (hasUpdateTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UpdateTime);
			}
			bool hasQuantity = this.HasQuantity;
			if (hasQuantity)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Quantity);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x0012065C File Offset: 0x0011E85C
		[DebuggerNonUserCode]
		public void MergeFrom(Criteria other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCriteriaId = other.HasCriteriaId;
				if (hasCriteriaId)
				{
					this.CriteriaId = other.CriteriaId;
				}
				bool hasStartTime = other.HasStartTime;
				if (hasStartTime)
				{
					this.StartTime = other.StartTime;
				}
				bool hasUpdateTime = other.HasUpdateTime;
				if (hasUpdateTime)
				{
					this.UpdateTime = other.UpdateTime;
				}
				bool hasQuantity = other.HasQuantity;
				if (hasQuantity)
				{
					this.Quantity = other.Quantity;
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x00120710 File Offset: 0x0011E910
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x0012071C File Offset: 0x0011E91C
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
							goto IL_0032;
						}
						this.StartTime = input.ReadUInt64();
					}
					else
					{
						this.CriteriaId = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.Flags = input.ReadUInt32();
					}
					else
					{
						this.UpdateTime = input.ReadUInt64();
					}
				}
				else
				{
					this.Quantity = input.ReadUInt64();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002192 RID: 8594
		private static readonly MessageParser<Criteria> _parser = new MessageParser<Criteria>(() => new Criteria());

		// Token: 0x04002193 RID: 8595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002194 RID: 8596
		private int _hasBits0;

		// Token: 0x04002195 RID: 8597
		public const int CriteriaIdFieldNumber = 1;

		// Token: 0x04002196 RID: 8598
		private static readonly uint CriteriaIdDefaultValue = 0U;

		// Token: 0x04002197 RID: 8599
		private uint criteriaId_;

		// Token: 0x04002198 RID: 8600
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04002199 RID: 8601
		private static readonly ulong StartTimeDefaultValue = 0UL;

		// Token: 0x0400219A RID: 8602
		private ulong startTime_;

		// Token: 0x0400219B RID: 8603
		public const int UpdateTimeFieldNumber = 4;

		// Token: 0x0400219C RID: 8604
		private static readonly ulong UpdateTimeDefaultValue = 0UL;

		// Token: 0x0400219D RID: 8605
		private ulong updateTime_;

		// Token: 0x0400219E RID: 8606
		public const int QuantityFieldNumber = 3;

		// Token: 0x0400219F RID: 8607
		private static readonly ulong QuantityDefaultValue = 0UL;

		// Token: 0x040021A0 RID: 8608
		private ulong quantity_;

		// Token: 0x040021A1 RID: 8609
		public const int FlagsFieldNumber = 5;

		// Token: 0x040021A2 RID: 8610
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x040021A3 RID: 8611
		private uint flags_;
	}
}
