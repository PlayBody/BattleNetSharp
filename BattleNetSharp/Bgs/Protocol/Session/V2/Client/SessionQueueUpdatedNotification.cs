using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000556 RID: 1366
	public sealed class SessionQueueUpdatedNotification : IMessage<SessionQueueUpdatedNotification>, IMessage, IEquatable<SessionQueueUpdatedNotification>, IDeepCloneable<SessionQueueUpdatedNotification>, IBufferMessage
	{
		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x06008403 RID: 33795 RVA: 0x00201944 File Offset: 0x001FFB44
		[DebuggerNonUserCode]
		public static MessageParser<SessionQueueUpdatedNotification> Parser
		{
			get
			{
				return SessionQueueUpdatedNotification._parser;
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x06008404 RID: 33796 RVA: 0x0020195C File Offset: 0x001FFB5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionListenerReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x00201980 File Offset: 0x001FFB80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionQueueUpdatedNotification.Descriptor;
			}
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x00201997 File Offset: 0x001FFB97
		[DebuggerNonUserCode]
		public SessionQueueUpdatedNotification()
		{
		}

		// Token: 0x06008407 RID: 33799 RVA: 0x002019A4 File Offset: 0x001FFBA4
		[DebuggerNonUserCode]
		public SessionQueueUpdatedNotification(SessionQueueUpdatedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.position_ = other.position_;
			this.avgCreationTimeMs_ = other.avgCreationTimeMs_;
			this.queuedTimeMs_ = other.queuedTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x002019FC File Offset: 0x001FFBFC
		[DebuggerNonUserCode]
		public SessionQueueUpdatedNotification Clone()
		{
			return new SessionQueueUpdatedNotification(this);
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x06008409 RID: 33801 RVA: 0x00201A14 File Offset: 0x001FFC14
		// (set) Token: 0x0600840A RID: 33802 RVA: 0x00201A45 File Offset: 0x001FFC45
		[DebuggerNonUserCode]
		public uint Position
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint positionDefaultValue;
				if (flag)
				{
					positionDefaultValue = this.position_;
				}
				else
				{
					positionDefaultValue = SessionQueueUpdatedNotification.PositionDefaultValue;
				}
				return positionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.position_ = value;
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0600840B RID: 33803 RVA: 0x00201A60 File Offset: 0x001FFC60
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x00201A7D File Offset: 0x001FFC7D
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0600840D RID: 33805 RVA: 0x00201A90 File Offset: 0x001FFC90
		// (set) Token: 0x0600840E RID: 33806 RVA: 0x00201AC1 File Offset: 0x001FFCC1
		[DebuggerNonUserCode]
		public ulong AvgCreationTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong avgCreationTimeMsDefaultValue;
				if (flag)
				{
					avgCreationTimeMsDefaultValue = this.avgCreationTimeMs_;
				}
				else
				{
					avgCreationTimeMsDefaultValue = SessionQueueUpdatedNotification.AvgCreationTimeMsDefaultValue;
				}
				return avgCreationTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.avgCreationTimeMs_ = value;
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0600840F RID: 33807 RVA: 0x00201ADC File Offset: 0x001FFCDC
		[DebuggerNonUserCode]
		public bool HasAvgCreationTimeMs
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x00201AF9 File Offset: 0x001FFCF9
		[DebuggerNonUserCode]
		public void ClearAvgCreationTimeMs()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x06008411 RID: 33809 RVA: 0x00201B0C File Offset: 0x001FFD0C
		// (set) Token: 0x06008412 RID: 33810 RVA: 0x00201B3D File Offset: 0x001FFD3D
		[DebuggerNonUserCode]
		public ulong QueuedTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong queuedTimeMsDefaultValue;
				if (flag)
				{
					queuedTimeMsDefaultValue = this.queuedTimeMs_;
				}
				else
				{
					queuedTimeMsDefaultValue = SessionQueueUpdatedNotification.QueuedTimeMsDefaultValue;
				}
				return queuedTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.queuedTimeMs_ = value;
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x06008413 RID: 33811 RVA: 0x00201B58 File Offset: 0x001FFD58
		[DebuggerNonUserCode]
		public bool HasQueuedTimeMs
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x00201B75 File Offset: 0x001FFD75
		[DebuggerNonUserCode]
		public void ClearQueuedTimeMs()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x00201B88 File Offset: 0x001FFD88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionQueueUpdatedNotification);
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x00201BA8 File Offset: 0x001FFDA8
		[DebuggerNonUserCode]
		public bool Equals(SessionQueueUpdatedNotification other)
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
					bool flag4 = this.Position != other.Position;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AvgCreationTimeMs != other.AvgCreationTimeMs;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.QueuedTimeMs != other.QueuedTimeMs;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x00201C34 File Offset: 0x001FFE34
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num ^= this.Position.GetHashCode();
			}
			bool hasAvgCreationTimeMs = this.HasAvgCreationTimeMs;
			if (hasAvgCreationTimeMs)
			{
				num ^= this.AvgCreationTimeMs.GetHashCode();
			}
			bool hasQueuedTimeMs = this.HasQueuedTimeMs;
			if (hasQueuedTimeMs)
			{
				num ^= this.QueuedTimeMs.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x00201CC0 File Offset: 0x001FFEC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x00201CD8 File Offset: 0x001FFED8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x00201CE4 File Offset: 0x001FFEE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Position);
			}
			bool hasAvgCreationTimeMs = this.HasAvgCreationTimeMs;
			if (hasAvgCreationTimeMs)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.AvgCreationTimeMs);
			}
			bool hasQueuedTimeMs = this.HasQueuedTimeMs;
			if (hasQueuedTimeMs)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.QueuedTimeMs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x00201D74 File Offset: 0x001FFF74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Position);
			}
			bool hasAvgCreationTimeMs = this.HasAvgCreationTimeMs;
			if (hasAvgCreationTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AvgCreationTimeMs);
			}
			bool hasQueuedTimeMs = this.HasQueuedTimeMs;
			if (hasQueuedTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.QueuedTimeMs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x00201E00 File Offset: 0x00200000
		[DebuggerNonUserCode]
		public void MergeFrom(SessionQueueUpdatedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPosition = other.HasPosition;
				if (hasPosition)
				{
					this.Position = other.Position;
				}
				bool hasAvgCreationTimeMs = other.HasAvgCreationTimeMs;
				if (hasAvgCreationTimeMs)
				{
					this.AvgCreationTimeMs = other.AvgCreationTimeMs;
				}
				bool hasQueuedTimeMs = other.HasQueuedTimeMs;
				if (hasQueuedTimeMs)
				{
					this.QueuedTimeMs = other.QueuedTimeMs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x00201E7B File Offset: 0x0020007B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x00201E88 File Offset: 0x00200088
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.QueuedTimeMs = input.ReadUInt64();
						}
					}
					else
					{
						this.AvgCreationTimeMs = input.ReadUInt64();
					}
				}
				else
				{
					this.Position = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BEB RID: 15339
		private static readonly MessageParser<SessionQueueUpdatedNotification> _parser = new MessageParser<SessionQueueUpdatedNotification>(() => new SessionQueueUpdatedNotification());

		// Token: 0x04003BEC RID: 15340
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BED RID: 15341
		private int _hasBits0;

		// Token: 0x04003BEE RID: 15342
		public const int PositionFieldNumber = 1;

		// Token: 0x04003BEF RID: 15343
		private static readonly uint PositionDefaultValue = 0U;

		// Token: 0x04003BF0 RID: 15344
		private uint position_;

		// Token: 0x04003BF1 RID: 15345
		public const int AvgCreationTimeMsFieldNumber = 2;

		// Token: 0x04003BF2 RID: 15346
		private static readonly ulong AvgCreationTimeMsDefaultValue = 0UL;

		// Token: 0x04003BF3 RID: 15347
		private ulong avgCreationTimeMs_;

		// Token: 0x04003BF4 RID: 15348
		public const int QueuedTimeMsFieldNumber = 3;

		// Token: 0x04003BF5 RID: 15349
		private static readonly ulong QueuedTimeMsDefaultValue = 0UL;

		// Token: 0x04003BF6 RID: 15350
		private ulong queuedTimeMs_;
	}
}
