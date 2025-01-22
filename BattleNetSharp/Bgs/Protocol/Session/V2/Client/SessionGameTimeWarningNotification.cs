using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000555 RID: 1365
	public sealed class SessionGameTimeWarningNotification : IMessage<SessionGameTimeWarningNotification>, IMessage, IEquatable<SessionGameTimeWarningNotification>, IDeepCloneable<SessionGameTimeWarningNotification>, IBufferMessage
	{
		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x060083EA RID: 33770 RVA: 0x00201498 File Offset: 0x001FF698
		[DebuggerNonUserCode]
		public static MessageParser<SessionGameTimeWarningNotification> Parser
		{
			get
			{
				return SessionGameTimeWarningNotification._parser;
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x060083EB RID: 33771 RVA: 0x002014B0 File Offset: 0x001FF6B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionListenerReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x060083EC RID: 33772 RVA: 0x002014D4 File Offset: 0x001FF6D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionGameTimeWarningNotification.Descriptor;
			}
		}

		// Token: 0x060083ED RID: 33773 RVA: 0x002014EB File Offset: 0x001FF6EB
		[DebuggerNonUserCode]
		public SessionGameTimeWarningNotification()
		{
		}

		// Token: 0x060083EE RID: 33774 RVA: 0x002014F5 File Offset: 0x001FF6F5
		[DebuggerNonUserCode]
		public SessionGameTimeWarningNotification(SessionGameTimeWarningNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.remainingTimeDurationMin_ = other.remainingTimeDurationMin_;
			this.restrictionType_ = other.restrictionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x00201534 File Offset: 0x001FF734
		[DebuggerNonUserCode]
		public SessionGameTimeWarningNotification Clone()
		{
			return new SessionGameTimeWarningNotification(this);
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x060083F0 RID: 33776 RVA: 0x0020154C File Offset: 0x001FF74C
		// (set) Token: 0x060083F1 RID: 33777 RVA: 0x0020157D File Offset: 0x001FF77D
		[DebuggerNonUserCode]
		public uint RemainingTimeDurationMin
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint remainingTimeDurationMinDefaultValue;
				if (flag)
				{
					remainingTimeDurationMinDefaultValue = this.remainingTimeDurationMin_;
				}
				else
				{
					remainingTimeDurationMinDefaultValue = SessionGameTimeWarningNotification.RemainingTimeDurationMinDefaultValue;
				}
				return remainingTimeDurationMinDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.remainingTimeDurationMin_ = value;
			}
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x060083F2 RID: 33778 RVA: 0x00201598 File Offset: 0x001FF798
		[DebuggerNonUserCode]
		public bool HasRemainingTimeDurationMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060083F3 RID: 33779 RVA: 0x002015B5 File Offset: 0x001FF7B5
		[DebuggerNonUserCode]
		public void ClearRemainingTimeDurationMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x060083F4 RID: 33780 RVA: 0x002015C8 File Offset: 0x001FF7C8
		// (set) Token: 0x060083F5 RID: 33781 RVA: 0x002015F9 File Offset: 0x001FF7F9
		[DebuggerNonUserCode]
		public uint RestrictionType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint restrictionTypeDefaultValue;
				if (flag)
				{
					restrictionTypeDefaultValue = this.restrictionType_;
				}
				else
				{
					restrictionTypeDefaultValue = SessionGameTimeWarningNotification.RestrictionTypeDefaultValue;
				}
				return restrictionTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.restrictionType_ = value;
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x060083F6 RID: 33782 RVA: 0x00201614 File Offset: 0x001FF814
		[DebuggerNonUserCode]
		public bool HasRestrictionType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060083F7 RID: 33783 RVA: 0x00201631 File Offset: 0x001FF831
		[DebuggerNonUserCode]
		public void ClearRestrictionType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060083F8 RID: 33784 RVA: 0x00201644 File Offset: 0x001FF844
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionGameTimeWarningNotification);
		}

		// Token: 0x060083F9 RID: 33785 RVA: 0x00201664 File Offset: 0x001FF864
		[DebuggerNonUserCode]
		public bool Equals(SessionGameTimeWarningNotification other)
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
					bool flag4 = this.RemainingTimeDurationMin != other.RemainingTimeDurationMin;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RestrictionType != other.RestrictionType;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060083FA RID: 33786 RVA: 0x002016D8 File Offset: 0x001FF8D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRemainingTimeDurationMin = this.HasRemainingTimeDurationMin;
			if (hasRemainingTimeDurationMin)
			{
				num ^= this.RemainingTimeDurationMin.GetHashCode();
			}
			bool hasRestrictionType = this.HasRestrictionType;
			if (hasRestrictionType)
			{
				num ^= this.RestrictionType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083FB RID: 33787 RVA: 0x00201744 File Offset: 0x001FF944
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083FC RID: 33788 RVA: 0x0020175C File Offset: 0x001FF95C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083FD RID: 33789 RVA: 0x00201768 File Offset: 0x001FF968
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRemainingTimeDurationMin = this.HasRemainingTimeDurationMin;
			if (hasRemainingTimeDurationMin)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RemainingTimeDurationMin);
			}
			bool hasRestrictionType = this.HasRestrictionType;
			if (hasRestrictionType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RestrictionType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083FE RID: 33790 RVA: 0x002017D8 File Offset: 0x001FF9D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRemainingTimeDurationMin = this.HasRemainingTimeDurationMin;
			if (hasRemainingTimeDurationMin)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RemainingTimeDurationMin);
			}
			bool hasRestrictionType = this.HasRestrictionType;
			if (hasRestrictionType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RestrictionType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083FF RID: 33791 RVA: 0x00201844 File Offset: 0x001FFA44
		[DebuggerNonUserCode]
		public void MergeFrom(SessionGameTimeWarningNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRemainingTimeDurationMin = other.HasRemainingTimeDurationMin;
				if (hasRemainingTimeDurationMin)
				{
					this.RemainingTimeDurationMin = other.RemainingTimeDurationMin;
				}
				bool hasRestrictionType = other.HasRestrictionType;
				if (hasRestrictionType)
				{
					this.RestrictionType = other.RestrictionType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008400 RID: 33792 RVA: 0x002018A6 File Offset: 0x001FFAA6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x002018B4 File Offset: 0x001FFAB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RestrictionType = input.ReadUInt32();
					}
				}
				else
				{
					this.RemainingTimeDurationMin = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BE2 RID: 15330
		private static readonly MessageParser<SessionGameTimeWarningNotification> _parser = new MessageParser<SessionGameTimeWarningNotification>(() => new SessionGameTimeWarningNotification());

		// Token: 0x04003BE3 RID: 15331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE4 RID: 15332
		private int _hasBits0;

		// Token: 0x04003BE5 RID: 15333
		public const int RemainingTimeDurationMinFieldNumber = 1;

		// Token: 0x04003BE6 RID: 15334
		private static readonly uint RemainingTimeDurationMinDefaultValue = 0U;

		// Token: 0x04003BE7 RID: 15335
		private uint remainingTimeDurationMin_;

		// Token: 0x04003BE8 RID: 15336
		public const int RestrictionTypeFieldNumber = 2;

		// Token: 0x04003BE9 RID: 15337
		private static readonly uint RestrictionTypeDefaultValue = 0U;

		// Token: 0x04003BEA RID: 15338
		private uint restrictionType_;
	}
}
