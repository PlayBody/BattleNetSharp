using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200030C RID: 780
	public sealed class NetworkStats : IMessage<NetworkStats>, IMessage, IEquatable<NetworkStats>, IDeepCloneable<NetworkStats>, IBufferMessage
	{
		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x0013E8B0 File Offset: 0x0013CAB0
		[DebuggerNonUserCode]
		public static MessageParser<NetworkStats> Parser
		{
			get
			{
				return NetworkStats._parser;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06005275 RID: 21109 RVA: 0x0013E8C8 File Offset: 0x0013CAC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NetworkStatsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x0013E8EC File Offset: 0x0013CAEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetworkStats.Descriptor;
			}
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0013E903 File Offset: 0x0013CB03
		[DebuggerNonUserCode]
		public NetworkStats()
		{
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x0013E910 File Offset: 0x0013CB10
		[DebuggerNonUserCode]
		public NetworkStats(NetworkStats other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.avgInboundKbPerSecond_ = other.avgInboundKbPerSecond_;
			this.avgOutboundKbPerSecond_ = other.avgOutboundKbPerSecond_;
			this.avgInboundMessagesPerSecond_ = other.avgInboundMessagesPerSecond_;
			this.avgOutboundMessagesPerSecond_ = other.avgOutboundMessagesPerSecond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x0013E974 File Offset: 0x0013CB74
		[DebuggerNonUserCode]
		public NetworkStats Clone()
		{
			return new NetworkStats(this);
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x0013E98C File Offset: 0x0013CB8C
		// (set) Token: 0x0600527B RID: 21115 RVA: 0x0013E9BD File Offset: 0x0013CBBD
		[DebuggerNonUserCode]
		public float AvgInboundKbPerSecond
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float avgInboundKbPerSecondDefaultValue;
				if (flag)
				{
					avgInboundKbPerSecondDefaultValue = this.avgInboundKbPerSecond_;
				}
				else
				{
					avgInboundKbPerSecondDefaultValue = NetworkStats.AvgInboundKbPerSecondDefaultValue;
				}
				return avgInboundKbPerSecondDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.avgInboundKbPerSecond_ = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x0013E9D8 File Offset: 0x0013CBD8
		[DebuggerNonUserCode]
		public bool HasAvgInboundKbPerSecond
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x0013E9F5 File Offset: 0x0013CBF5
		[DebuggerNonUserCode]
		public void ClearAvgInboundKbPerSecond()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x0013EA08 File Offset: 0x0013CC08
		// (set) Token: 0x0600527F RID: 21119 RVA: 0x0013EA39 File Offset: 0x0013CC39
		[DebuggerNonUserCode]
		public float AvgOutboundKbPerSecond
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float avgOutboundKbPerSecondDefaultValue;
				if (flag)
				{
					avgOutboundKbPerSecondDefaultValue = this.avgOutboundKbPerSecond_;
				}
				else
				{
					avgOutboundKbPerSecondDefaultValue = NetworkStats.AvgOutboundKbPerSecondDefaultValue;
				}
				return avgOutboundKbPerSecondDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.avgOutboundKbPerSecond_ = value;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x0013EA54 File Offset: 0x0013CC54
		[DebuggerNonUserCode]
		public bool HasAvgOutboundKbPerSecond
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x0013EA71 File Offset: 0x0013CC71
		[DebuggerNonUserCode]
		public void ClearAvgOutboundKbPerSecond()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06005282 RID: 21122 RVA: 0x0013EA84 File Offset: 0x0013CC84
		// (set) Token: 0x06005283 RID: 21123 RVA: 0x0013EAB5 File Offset: 0x0013CCB5
		[DebuggerNonUserCode]
		public float AvgInboundMessagesPerSecond
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float avgInboundMessagesPerSecondDefaultValue;
				if (flag)
				{
					avgInboundMessagesPerSecondDefaultValue = this.avgInboundMessagesPerSecond_;
				}
				else
				{
					avgInboundMessagesPerSecondDefaultValue = NetworkStats.AvgInboundMessagesPerSecondDefaultValue;
				}
				return avgInboundMessagesPerSecondDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.avgInboundMessagesPerSecond_ = value;
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06005284 RID: 21124 RVA: 0x0013EAD0 File Offset: 0x0013CCD0
		[DebuggerNonUserCode]
		public bool HasAvgInboundMessagesPerSecond
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0013EAED File Offset: 0x0013CCED
		[DebuggerNonUserCode]
		public void ClearAvgInboundMessagesPerSecond()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06005286 RID: 21126 RVA: 0x0013EB00 File Offset: 0x0013CD00
		// (set) Token: 0x06005287 RID: 21127 RVA: 0x0013EB31 File Offset: 0x0013CD31
		[DebuggerNonUserCode]
		public float AvgOutboundMessagesPerSecond
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float avgOutboundMessagesPerSecondDefaultValue;
				if (flag)
				{
					avgOutboundMessagesPerSecondDefaultValue = this.avgOutboundMessagesPerSecond_;
				}
				else
				{
					avgOutboundMessagesPerSecondDefaultValue = NetworkStats.AvgOutboundMessagesPerSecondDefaultValue;
				}
				return avgOutboundMessagesPerSecondDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.avgOutboundMessagesPerSecond_ = value;
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06005288 RID: 21128 RVA: 0x0013EB4C File Offset: 0x0013CD4C
		[DebuggerNonUserCode]
		public bool HasAvgOutboundMessagesPerSecond
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x0013EB69 File Offset: 0x0013CD69
		[DebuggerNonUserCode]
		public void ClearAvgOutboundMessagesPerSecond()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x0013EB7C File Offset: 0x0013CD7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetworkStats);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x0013EB9C File Offset: 0x0013CD9C
		[DebuggerNonUserCode]
		public bool Equals(NetworkStats other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AvgInboundKbPerSecond, other.AvgInboundKbPerSecond);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AvgOutboundKbPerSecond, other.AvgOutboundKbPerSecond);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AvgInboundMessagesPerSecond, other.AvgInboundMessagesPerSecond);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AvgOutboundMessagesPerSecond, other.AvgOutboundMessagesPerSecond);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x0013EC6C File Offset: 0x0013CE6C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAvgInboundKbPerSecond = this.HasAvgInboundKbPerSecond;
			if (hasAvgInboundKbPerSecond)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AvgInboundKbPerSecond);
			}
			bool hasAvgOutboundKbPerSecond = this.HasAvgOutboundKbPerSecond;
			if (hasAvgOutboundKbPerSecond)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AvgOutboundKbPerSecond);
			}
			bool hasAvgInboundMessagesPerSecond = this.HasAvgInboundMessagesPerSecond;
			if (hasAvgInboundMessagesPerSecond)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AvgInboundMessagesPerSecond);
			}
			bool hasAvgOutboundMessagesPerSecond = this.HasAvgOutboundMessagesPerSecond;
			if (hasAvgOutboundMessagesPerSecond)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AvgOutboundMessagesPerSecond);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x0013ED18 File Offset: 0x0013CF18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x0013ED30 File Offset: 0x0013CF30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x0013ED3C File Offset: 0x0013CF3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAvgInboundKbPerSecond = this.HasAvgInboundKbPerSecond;
			if (hasAvgInboundKbPerSecond)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.AvgInboundKbPerSecond);
			}
			bool hasAvgOutboundKbPerSecond = this.HasAvgOutboundKbPerSecond;
			if (hasAvgOutboundKbPerSecond)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.AvgOutboundKbPerSecond);
			}
			bool hasAvgInboundMessagesPerSecond = this.HasAvgInboundMessagesPerSecond;
			if (hasAvgInboundMessagesPerSecond)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.AvgInboundMessagesPerSecond);
			}
			bool hasAvgOutboundMessagesPerSecond = this.HasAvgOutboundMessagesPerSecond;
			if (hasAvgOutboundMessagesPerSecond)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.AvgOutboundMessagesPerSecond);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x0013EDF0 File Offset: 0x0013CFF0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAvgInboundKbPerSecond = this.HasAvgInboundKbPerSecond;
			if (hasAvgInboundKbPerSecond)
			{
				num += 5;
			}
			bool hasAvgOutboundKbPerSecond = this.HasAvgOutboundKbPerSecond;
			if (hasAvgOutboundKbPerSecond)
			{
				num += 5;
			}
			bool hasAvgInboundMessagesPerSecond = this.HasAvgInboundMessagesPerSecond;
			if (hasAvgInboundMessagesPerSecond)
			{
				num += 5;
			}
			bool hasAvgOutboundMessagesPerSecond = this.HasAvgOutboundMessagesPerSecond;
			if (hasAvgOutboundMessagesPerSecond)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x0013EE68 File Offset: 0x0013D068
		[DebuggerNonUserCode]
		public void MergeFrom(NetworkStats other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAvgInboundKbPerSecond = other.HasAvgInboundKbPerSecond;
				if (hasAvgInboundKbPerSecond)
				{
					this.AvgInboundKbPerSecond = other.AvgInboundKbPerSecond;
				}
				bool hasAvgOutboundKbPerSecond = other.HasAvgOutboundKbPerSecond;
				if (hasAvgOutboundKbPerSecond)
				{
					this.AvgOutboundKbPerSecond = other.AvgOutboundKbPerSecond;
				}
				bool hasAvgInboundMessagesPerSecond = other.HasAvgInboundMessagesPerSecond;
				if (hasAvgInboundMessagesPerSecond)
				{
					this.AvgInboundMessagesPerSecond = other.AvgInboundMessagesPerSecond;
				}
				bool hasAvgOutboundMessagesPerSecond = other.HasAvgOutboundMessagesPerSecond;
				if (hasAvgOutboundMessagesPerSecond)
				{
					this.AvgOutboundMessagesPerSecond = other.AvgOutboundMessagesPerSecond;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x0013EEFE File Offset: 0x0013D0FE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x0013EF0C File Offset: 0x0013D10C
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
							goto IL_0029;
						}
						this.AvgOutboundKbPerSecond = input.ReadFloat();
					}
					else
					{
						this.AvgInboundKbPerSecond = input.ReadFloat();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						goto IL_0029;
					}
					this.AvgOutboundMessagesPerSecond = input.ReadFloat();
				}
				else
				{
					this.AvgInboundMessagesPerSecond = input.ReadFloat();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400256E RID: 9582
		private static readonly MessageParser<NetworkStats> _parser = new MessageParser<NetworkStats>(() => new NetworkStats());

		// Token: 0x0400256F RID: 9583
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002570 RID: 9584
		private int _hasBits0;

		// Token: 0x04002571 RID: 9585
		public const int AvgInboundKbPerSecondFieldNumber = 1;

		// Token: 0x04002572 RID: 9586
		private static readonly float AvgInboundKbPerSecondDefaultValue = 0f;

		// Token: 0x04002573 RID: 9587
		private float avgInboundKbPerSecond_;

		// Token: 0x04002574 RID: 9588
		public const int AvgOutboundKbPerSecondFieldNumber = 2;

		// Token: 0x04002575 RID: 9589
		private static readonly float AvgOutboundKbPerSecondDefaultValue = 0f;

		// Token: 0x04002576 RID: 9590
		private float avgOutboundKbPerSecond_;

		// Token: 0x04002577 RID: 9591
		public const int AvgInboundMessagesPerSecondFieldNumber = 3;

		// Token: 0x04002578 RID: 9592
		private static readonly float AvgInboundMessagesPerSecondDefaultValue = 0f;

		// Token: 0x04002579 RID: 9593
		private float avgInboundMessagesPerSecond_;

		// Token: 0x0400257A RID: 9594
		public const int AvgOutboundMessagesPerSecondFieldNumber = 4;

		// Token: 0x0400257B RID: 9595
		private static readonly float AvgOutboundMessagesPerSecondDefaultValue = 0f;

		// Token: 0x0400257C RID: 9596
		private float avgOutboundMessagesPerSecond_;
	}
}
