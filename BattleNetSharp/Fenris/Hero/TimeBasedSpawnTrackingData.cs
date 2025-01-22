using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000187 RID: 391
	public sealed class TimeBasedSpawnTrackingData : IMessage<TimeBasedSpawnTrackingData>, IMessage, IEquatable<TimeBasedSpawnTrackingData>, IDeepCloneable<TimeBasedSpawnTrackingData>, IBufferMessage
	{
		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000A01C8 File Offset: 0x0009E3C8
		[DebuggerNonUserCode]
		public static MessageParser<TimeBasedSpawnTrackingData> Parser
		{
			get
			{
				return TimeBasedSpawnTrackingData._parser;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x000A01E0 File Offset: 0x0009E3E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000A0204 File Offset: 0x0009E404
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeBasedSpawnTrackingData.Descriptor;
			}
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x000A021B File Offset: 0x0009E41B
		[DebuggerNonUserCode]
		public TimeBasedSpawnTrackingData()
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000A0228 File Offset: 0x0009E428
		[DebuggerNonUserCode]
		public TimeBasedSpawnTrackingData(TimeBasedSpawnTrackingData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.trackedTimestamp_ = other.trackedTimestamp_;
			this.gizmoHash_ = other.gizmoHash_;
			this.gizmoCooldown_ = other.gizmoCooldown_;
			this.occurrenceExpiration_ = other.occurrenceExpiration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000A028C File Offset: 0x0009E48C
		[DebuggerNonUserCode]
		public TimeBasedSpawnTrackingData Clone()
		{
			return new TimeBasedSpawnTrackingData(this);
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000A02A4 File Offset: 0x0009E4A4
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x000A02D5 File Offset: 0x0009E4D5
		[DebuggerNonUserCode]
		public long TrackedTimestamp
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long trackedTimestampDefaultValue;
				if (flag)
				{
					trackedTimestampDefaultValue = this.trackedTimestamp_;
				}
				else
				{
					trackedTimestampDefaultValue = TimeBasedSpawnTrackingData.TrackedTimestampDefaultValue;
				}
				return trackedTimestampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.trackedTimestamp_ = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000A02F0 File Offset: 0x0009E4F0
		[DebuggerNonUserCode]
		public bool HasTrackedTimestamp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000A030D File Offset: 0x0009E50D
		[DebuggerNonUserCode]
		public void ClearTrackedTimestamp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x000A0320 File Offset: 0x0009E520
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x000A0351 File Offset: 0x0009E551
		[DebuggerNonUserCode]
		public uint GizmoHash
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint gizmoHashDefaultValue;
				if (flag)
				{
					gizmoHashDefaultValue = this.gizmoHash_;
				}
				else
				{
					gizmoHashDefaultValue = TimeBasedSpawnTrackingData.GizmoHashDefaultValue;
				}
				return gizmoHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gizmoHash_ = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x000A036C File Offset: 0x0009E56C
		[DebuggerNonUserCode]
		public bool HasGizmoHash
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000A0389 File Offset: 0x0009E589
		[DebuggerNonUserCode]
		public void ClearGizmoHash()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x000A039C File Offset: 0x0009E59C
		// (set) Token: 0x06002915 RID: 10517 RVA: 0x000A03CD File Offset: 0x0009E5CD
		[DebuggerNonUserCode]
		public uint GizmoCooldown
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint gizmoCooldownDefaultValue;
				if (flag)
				{
					gizmoCooldownDefaultValue = this.gizmoCooldown_;
				}
				else
				{
					gizmoCooldownDefaultValue = TimeBasedSpawnTrackingData.GizmoCooldownDefaultValue;
				}
				return gizmoCooldownDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gizmoCooldown_ = value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x000A03E8 File Offset: 0x0009E5E8
		[DebuggerNonUserCode]
		public bool HasGizmoCooldown
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000A0405 File Offset: 0x0009E605
		[DebuggerNonUserCode]
		public void ClearGizmoCooldown()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x000A0418 File Offset: 0x0009E618
		// (set) Token: 0x06002919 RID: 10521 RVA: 0x000A0449 File Offset: 0x0009E649
		[DebuggerNonUserCode]
		public uint OccurrenceExpiration
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint occurrenceExpirationDefaultValue;
				if (flag)
				{
					occurrenceExpirationDefaultValue = this.occurrenceExpiration_;
				}
				else
				{
					occurrenceExpirationDefaultValue = TimeBasedSpawnTrackingData.OccurrenceExpirationDefaultValue;
				}
				return occurrenceExpirationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.occurrenceExpiration_ = value;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x000A0464 File Offset: 0x0009E664
		[DebuggerNonUserCode]
		public bool HasOccurrenceExpiration
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000A0481 File Offset: 0x0009E681
		[DebuggerNonUserCode]
		public void ClearOccurrenceExpiration()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000A0494 File Offset: 0x0009E694
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeBasedSpawnTrackingData);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000A04B4 File Offset: 0x0009E6B4
		[DebuggerNonUserCode]
		public bool Equals(TimeBasedSpawnTrackingData other)
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
					bool flag4 = this.TrackedTimestamp != other.TrackedTimestamp;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GizmoHash != other.GizmoHash;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GizmoCooldown != other.GizmoCooldown;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.OccurrenceExpiration != other.OccurrenceExpiration;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000A0560 File Offset: 0x0009E760
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTrackedTimestamp = this.HasTrackedTimestamp;
			if (hasTrackedTimestamp)
			{
				num ^= this.TrackedTimestamp.GetHashCode();
			}
			bool hasGizmoHash = this.HasGizmoHash;
			if (hasGizmoHash)
			{
				num ^= this.GizmoHash.GetHashCode();
			}
			bool hasGizmoCooldown = this.HasGizmoCooldown;
			if (hasGizmoCooldown)
			{
				num ^= this.GizmoCooldown.GetHashCode();
			}
			bool hasOccurrenceExpiration = this.HasOccurrenceExpiration;
			if (hasOccurrenceExpiration)
			{
				num ^= this.OccurrenceExpiration.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000A060C File Offset: 0x0009E80C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000A0624 File Offset: 0x0009E824
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000A0630 File Offset: 0x0009E830
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTrackedTimestamp = this.HasTrackedTimestamp;
			if (hasTrackedTimestamp)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TrackedTimestamp);
			}
			bool hasGizmoHash = this.HasGizmoHash;
			if (hasGizmoHash)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GizmoHash);
			}
			bool hasGizmoCooldown = this.HasGizmoCooldown;
			if (hasGizmoCooldown)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GizmoCooldown);
			}
			bool hasOccurrenceExpiration = this.HasOccurrenceExpiration;
			if (hasOccurrenceExpiration)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OccurrenceExpiration);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000A06E4 File Offset: 0x0009E8E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTrackedTimestamp = this.HasTrackedTimestamp;
			if (hasTrackedTimestamp)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TrackedTimestamp);
			}
			bool hasGizmoHash = this.HasGizmoHash;
			if (hasGizmoHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GizmoHash);
			}
			bool hasGizmoCooldown = this.HasGizmoCooldown;
			if (hasGizmoCooldown)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GizmoCooldown);
			}
			bool hasOccurrenceExpiration = this.HasOccurrenceExpiration;
			if (hasOccurrenceExpiration)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OccurrenceExpiration);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000A078C File Offset: 0x0009E98C
		[DebuggerNonUserCode]
		public void MergeFrom(TimeBasedSpawnTrackingData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTrackedTimestamp = other.HasTrackedTimestamp;
				if (hasTrackedTimestamp)
				{
					this.TrackedTimestamp = other.TrackedTimestamp;
				}
				bool hasGizmoHash = other.HasGizmoHash;
				if (hasGizmoHash)
				{
					this.GizmoHash = other.GizmoHash;
				}
				bool hasGizmoCooldown = other.HasGizmoCooldown;
				if (hasGizmoCooldown)
				{
					this.GizmoCooldown = other.GizmoCooldown;
				}
				bool hasOccurrenceExpiration = other.HasOccurrenceExpiration;
				if (hasOccurrenceExpiration)
				{
					this.OccurrenceExpiration = other.OccurrenceExpiration;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000A0822 File Offset: 0x0009EA22
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000A0830 File Offset: 0x0009EA30
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
						this.GizmoHash = input.ReadUInt32();
					}
					else
					{
						this.TrackedTimestamp = input.ReadInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.OccurrenceExpiration = input.ReadUInt32();
				}
				else
				{
					this.GizmoCooldown = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001241 RID: 4673
		private static readonly MessageParser<TimeBasedSpawnTrackingData> _parser = new MessageParser<TimeBasedSpawnTrackingData>(() => new TimeBasedSpawnTrackingData());

		// Token: 0x04001242 RID: 4674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001243 RID: 4675
		private int _hasBits0;

		// Token: 0x04001244 RID: 4676
		public const int TrackedTimestampFieldNumber = 1;

		// Token: 0x04001245 RID: 4677
		private static readonly long TrackedTimestampDefaultValue = 0L;

		// Token: 0x04001246 RID: 4678
		private long trackedTimestamp_;

		// Token: 0x04001247 RID: 4679
		public const int GizmoHashFieldNumber = 2;

		// Token: 0x04001248 RID: 4680
		private static readonly uint GizmoHashDefaultValue = 0U;

		// Token: 0x04001249 RID: 4681
		private uint gizmoHash_;

		// Token: 0x0400124A RID: 4682
		public const int GizmoCooldownFieldNumber = 3;

		// Token: 0x0400124B RID: 4683
		private static readonly uint GizmoCooldownDefaultValue = 0U;

		// Token: 0x0400124C RID: 4684
		private uint gizmoCooldown_;

		// Token: 0x0400124D RID: 4685
		public const int OccurrenceExpirationFieldNumber = 4;

		// Token: 0x0400124E RID: 4686
		private static readonly uint OccurrenceExpirationDefaultValue = 0U;

		// Token: 0x0400124F RID: 4687
		private uint occurrenceExpiration_;
	}
}
