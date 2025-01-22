using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F9 RID: 1017
	public sealed class QueueWaitTimes : IMessage<QueueWaitTimes>, IMessage, IEquatable<QueueWaitTimes>, IDeepCloneable<QueueWaitTimes>, IBufferMessage
	{
		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x00185D00 File Offset: 0x00183F00
		[DebuggerNonUserCode]
		public static MessageParser<QueueWaitTimes> Parser
		{
			get
			{
				return QueueWaitTimes._parser;
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x060064DF RID: 25823 RVA: 0x00185D18 File Offset: 0x00183F18
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x060064E0 RID: 25824 RVA: 0x00185D3C File Offset: 0x00183F3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueWaitTimes.Descriptor;
			}
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00185D53 File Offset: 0x00183F53
		[DebuggerNonUserCode]
		public QueueWaitTimes()
		{
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00185D60 File Offset: 0x00183F60
		[DebuggerNonUserCode]
		public QueueWaitTimes(QueueWaitTimes other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.minWait_ = other.minWait_;
			this.maxWait_ = other.maxWait_;
			this.avgWait_ = other.avgWait_;
			this.stdDevWait_ = other.stdDevWait_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00185DC4 File Offset: 0x00183FC4
		[DebuggerNonUserCode]
		public QueueWaitTimes Clone()
		{
			return new QueueWaitTimes(this);
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x060064E4 RID: 25828 RVA: 0x00185DDC File Offset: 0x00183FDC
		// (set) Token: 0x060064E5 RID: 25829 RVA: 0x00185E0D File Offset: 0x0018400D
		[DebuggerNonUserCode]
		public int MinWait
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int minWaitDefaultValue;
				if (flag)
				{
					minWaitDefaultValue = this.minWait_;
				}
				else
				{
					minWaitDefaultValue = QueueWaitTimes.MinWaitDefaultValue;
				}
				return minWaitDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.minWait_ = value;
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x060064E6 RID: 25830 RVA: 0x00185E28 File Offset: 0x00184028
		[DebuggerNonUserCode]
		public bool HasMinWait
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00185E45 File Offset: 0x00184045
		[DebuggerNonUserCode]
		public void ClearMinWait()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x060064E8 RID: 25832 RVA: 0x00185E58 File Offset: 0x00184058
		// (set) Token: 0x060064E9 RID: 25833 RVA: 0x00185E89 File Offset: 0x00184089
		[DebuggerNonUserCode]
		public int MaxWait
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int maxWaitDefaultValue;
				if (flag)
				{
					maxWaitDefaultValue = this.maxWait_;
				}
				else
				{
					maxWaitDefaultValue = QueueWaitTimes.MaxWaitDefaultValue;
				}
				return maxWaitDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.maxWait_ = value;
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x060064EA RID: 25834 RVA: 0x00185EA4 File Offset: 0x001840A4
		[DebuggerNonUserCode]
		public bool HasMaxWait
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x00185EC1 File Offset: 0x001840C1
		[DebuggerNonUserCode]
		public void ClearMaxWait()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x060064EC RID: 25836 RVA: 0x00185ED4 File Offset: 0x001840D4
		// (set) Token: 0x060064ED RID: 25837 RVA: 0x00185F05 File Offset: 0x00184105
		[DebuggerNonUserCode]
		public int AvgWait
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int avgWaitDefaultValue;
				if (flag)
				{
					avgWaitDefaultValue = this.avgWait_;
				}
				else
				{
					avgWaitDefaultValue = QueueWaitTimes.AvgWaitDefaultValue;
				}
				return avgWaitDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.avgWait_ = value;
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x060064EE RID: 25838 RVA: 0x00185F20 File Offset: 0x00184120
		[DebuggerNonUserCode]
		public bool HasAvgWait
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00185F3D File Offset: 0x0018413D
		[DebuggerNonUserCode]
		public void ClearAvgWait()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x060064F0 RID: 25840 RVA: 0x00185F50 File Offset: 0x00184150
		// (set) Token: 0x060064F1 RID: 25841 RVA: 0x00185F81 File Offset: 0x00184181
		[DebuggerNonUserCode]
		public int StdDevWait
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int stdDevWaitDefaultValue;
				if (flag)
				{
					stdDevWaitDefaultValue = this.stdDevWait_;
				}
				else
				{
					stdDevWaitDefaultValue = QueueWaitTimes.StdDevWaitDefaultValue;
				}
				return stdDevWaitDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.stdDevWait_ = value;
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x060064F2 RID: 25842 RVA: 0x00185F9C File Offset: 0x0018419C
		[DebuggerNonUserCode]
		public bool HasStdDevWait
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00185FB9 File Offset: 0x001841B9
		[DebuggerNonUserCode]
		public void ClearStdDevWait()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x00185FCC File Offset: 0x001841CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueWaitTimes);
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x00185FEC File Offset: 0x001841EC
		[DebuggerNonUserCode]
		public bool Equals(QueueWaitTimes other)
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
					bool flag4 = this.MinWait != other.MinWait;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxWait != other.MaxWait;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AvgWait != other.AvgWait;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.StdDevWait != other.StdDevWait;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x00186098 File Offset: 0x00184298
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMinWait = this.HasMinWait;
			if (hasMinWait)
			{
				num ^= this.MinWait.GetHashCode();
			}
			bool hasMaxWait = this.HasMaxWait;
			if (hasMaxWait)
			{
				num ^= this.MaxWait.GetHashCode();
			}
			bool hasAvgWait = this.HasAvgWait;
			if (hasAvgWait)
			{
				num ^= this.AvgWait.GetHashCode();
			}
			bool hasStdDevWait = this.HasStdDevWait;
			if (hasStdDevWait)
			{
				num ^= this.StdDevWait.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00186140 File Offset: 0x00184340
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00186158 File Offset: 0x00184358
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00186164 File Offset: 0x00184364
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMinWait = this.HasMinWait;
			if (hasMinWait)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MinWait);
			}
			bool hasMaxWait = this.HasMaxWait;
			if (hasMaxWait)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxWait);
			}
			bool hasAvgWait = this.HasAvgWait;
			if (hasAvgWait)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AvgWait);
			}
			bool hasStdDevWait = this.HasStdDevWait;
			if (hasStdDevWait)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.StdDevWait);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00186218 File Offset: 0x00184418
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMinWait = this.HasMinWait;
			if (hasMinWait)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinWait);
			}
			bool hasMaxWait = this.HasMaxWait;
			if (hasMaxWait)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxWait);
			}
			bool hasAvgWait = this.HasAvgWait;
			if (hasAvgWait)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AvgWait);
			}
			bool hasStdDevWait = this.HasStdDevWait;
			if (hasStdDevWait)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StdDevWait);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x001862C0 File Offset: 0x001844C0
		[DebuggerNonUserCode]
		public void MergeFrom(QueueWaitTimes other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMinWait = other.HasMinWait;
				if (hasMinWait)
				{
					this.MinWait = other.MinWait;
				}
				bool hasMaxWait = other.HasMaxWait;
				if (hasMaxWait)
				{
					this.MaxWait = other.MaxWait;
				}
				bool hasAvgWait = other.HasAvgWait;
				if (hasAvgWait)
				{
					this.AvgWait = other.AvgWait;
				}
				bool hasStdDevWait = other.HasStdDevWait;
				if (hasStdDevWait)
				{
					this.StdDevWait = other.StdDevWait;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00186356 File Offset: 0x00184556
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00186364 File Offset: 0x00184564
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
						this.MaxWait = input.ReadInt32();
					}
					else
					{
						this.MinWait = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.StdDevWait = input.ReadInt32();
				}
				else
				{
					this.AvgWait = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002DE0 RID: 11744
		private static readonly MessageParser<QueueWaitTimes> _parser = new MessageParser<QueueWaitTimes>(() => new QueueWaitTimes());

		// Token: 0x04002DE1 RID: 11745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DE2 RID: 11746
		private int _hasBits0;

		// Token: 0x04002DE3 RID: 11747
		public const int MinWaitFieldNumber = 1;

		// Token: 0x04002DE4 RID: 11748
		private static readonly int MinWaitDefaultValue = 0;

		// Token: 0x04002DE5 RID: 11749
		private int minWait_;

		// Token: 0x04002DE6 RID: 11750
		public const int MaxWaitFieldNumber = 2;

		// Token: 0x04002DE7 RID: 11751
		private static readonly int MaxWaitDefaultValue = 0;

		// Token: 0x04002DE8 RID: 11752
		private int maxWait_;

		// Token: 0x04002DE9 RID: 11753
		public const int AvgWaitFieldNumber = 3;

		// Token: 0x04002DEA RID: 11754
		private static readonly int AvgWaitDefaultValue = 0;

		// Token: 0x04002DEB RID: 11755
		private int avgWait_;

		// Token: 0x04002DEC RID: 11756
		public const int StdDevWaitFieldNumber = 4;

		// Token: 0x04002DED RID: 11757
		private static readonly int StdDevWaitDefaultValue = 0;

		// Token: 0x04002DEE RID: 11758
		private int stdDevWait_;
	}
}
