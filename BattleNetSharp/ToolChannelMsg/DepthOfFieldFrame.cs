using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D3 RID: 211
	public sealed class DepthOfFieldFrame : IMessage<DepthOfFieldFrame>, IMessage, IEquatable<DepthOfFieldFrame>, IDeepCloneable<DepthOfFieldFrame>, IBufferMessage
	{
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00049D24 File Offset: 0x00047F24
		[DebuggerNonUserCode]
		public static MessageParser<DepthOfFieldFrame> Parser
		{
			get
			{
				return DepthOfFieldFrame._parser;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00049D3C File Offset: 0x00047F3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[188];
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x00049D64 File Offset: 0x00047F64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DepthOfFieldFrame.Descriptor;
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00049D7B File Offset: 0x00047F7B
		[DebuggerNonUserCode]
		public DepthOfFieldFrame()
		{
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00049D88 File Offset: 0x00047F88
		[DebuggerNonUserCode]
		public DepthOfFieldFrame(DepthOfFieldFrame other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.frameIndex_ = other.frameIndex_;
			this.fStop_ = other.fStop_;
			this.focalDistance_ = other.focalDistance_;
			this.nearTransition_ = other.nearTransition_;
			this.focalRegion_ = other.focalRegion_;
			this.farTransition_ = other.farTransition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00049E04 File Offset: 0x00048004
		[DebuggerNonUserCode]
		public DepthOfFieldFrame Clone()
		{
			return new DepthOfFieldFrame(this);
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00049E1C File Offset: 0x0004801C
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x00049E4D File Offset: 0x0004804D
		[DebuggerNonUserCode]
		public int FrameIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int frameIndexDefaultValue;
				if (flag)
				{
					frameIndexDefaultValue = this.frameIndex_;
				}
				else
				{
					frameIndexDefaultValue = DepthOfFieldFrame.FrameIndexDefaultValue;
				}
				return frameIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.frameIndex_ = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00049E68 File Offset: 0x00048068
		[DebuggerNonUserCode]
		public bool HasFrameIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00049E85 File Offset: 0x00048085
		[DebuggerNonUserCode]
		public void ClearFrameIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00049E98 File Offset: 0x00048098
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x00049EC9 File Offset: 0x000480C9
		[DebuggerNonUserCode]
		public float FStop
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float fstopDefaultValue;
				if (flag)
				{
					fstopDefaultValue = this.fStop_;
				}
				else
				{
					fstopDefaultValue = DepthOfFieldFrame.FStopDefaultValue;
				}
				return fstopDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fStop_ = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00049EE4 File Offset: 0x000480E4
		[DebuggerNonUserCode]
		public bool HasFStop
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00049F01 File Offset: 0x00048101
		[DebuggerNonUserCode]
		public void ClearFStop()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00049F14 File Offset: 0x00048114
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x00049F45 File Offset: 0x00048145
		[DebuggerNonUserCode]
		public float FocalDistance
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float focalDistanceDefaultValue;
				if (flag)
				{
					focalDistanceDefaultValue = this.focalDistance_;
				}
				else
				{
					focalDistanceDefaultValue = DepthOfFieldFrame.FocalDistanceDefaultValue;
				}
				return focalDistanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.focalDistance_ = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00049F60 File Offset: 0x00048160
		[DebuggerNonUserCode]
		public bool HasFocalDistance
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00049F7D File Offset: 0x0004817D
		[DebuggerNonUserCode]
		public void ClearFocalDistance()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00049F90 File Offset: 0x00048190
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x00049FC1 File Offset: 0x000481C1
		[DebuggerNonUserCode]
		public float NearTransition
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float nearTransitionDefaultValue;
				if (flag)
				{
					nearTransitionDefaultValue = this.nearTransition_;
				}
				else
				{
					nearTransitionDefaultValue = DepthOfFieldFrame.NearTransitionDefaultValue;
				}
				return nearTransitionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.nearTransition_ = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00049FDC File Offset: 0x000481DC
		[DebuggerNonUserCode]
		public bool HasNearTransition
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00049FF9 File Offset: 0x000481F9
		[DebuggerNonUserCode]
		public void ClearNearTransition()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0004A00C File Offset: 0x0004820C
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0004A03E File Offset: 0x0004823E
		[DebuggerNonUserCode]
		public float FocalRegion
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float focalRegionDefaultValue;
				if (flag)
				{
					focalRegionDefaultValue = this.focalRegion_;
				}
				else
				{
					focalRegionDefaultValue = DepthOfFieldFrame.FocalRegionDefaultValue;
				}
				return focalRegionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.focalRegion_ = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0004A058 File Offset: 0x00048258
		[DebuggerNonUserCode]
		public bool HasFocalRegion
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0004A076 File Offset: 0x00048276
		[DebuggerNonUserCode]
		public void ClearFocalRegion()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0004A088 File Offset: 0x00048288
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0004A0BA File Offset: 0x000482BA
		[DebuggerNonUserCode]
		public float FarTransition
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				float farTransitionDefaultValue;
				if (flag)
				{
					farTransitionDefaultValue = this.farTransition_;
				}
				else
				{
					farTransitionDefaultValue = DepthOfFieldFrame.FarTransitionDefaultValue;
				}
				return farTransitionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.farTransition_ = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0004A0D4 File Offset: 0x000482D4
		[DebuggerNonUserCode]
		public bool HasFarTransition
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0004A0F2 File Offset: 0x000482F2
		[DebuggerNonUserCode]
		public void ClearFarTransition()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0004A104 File Offset: 0x00048304
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DepthOfFieldFrame);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0004A124 File Offset: 0x00048324
		[DebuggerNonUserCode]
		public bool Equals(DepthOfFieldFrame other)
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
					bool flag4 = this.FrameIndex != other.FrameIndex;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FStop, other.FStop);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FocalDistance, other.FocalDistance);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.NearTransition, other.NearTransition);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FocalRegion, other.FocalRegion);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FarTransition, other.FarTransition);
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

		// Token: 0x06001456 RID: 5206 RVA: 0x0004A238 File Offset: 0x00048438
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				num ^= this.FrameIndex.GetHashCode();
			}
			bool hasFStop = this.HasFStop;
			if (hasFStop)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FStop);
			}
			bool hasFocalDistance = this.HasFocalDistance;
			if (hasFocalDistance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FocalDistance);
			}
			bool hasNearTransition = this.HasNearTransition;
			if (hasNearTransition)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.NearTransition);
			}
			bool hasFocalRegion = this.HasFocalRegion;
			if (hasFocalRegion)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FocalRegion);
			}
			bool hasFarTransition = this.HasFarTransition;
			if (hasFarTransition)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FarTransition);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0004A324 File Offset: 0x00048524
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0004A33C File Offset: 0x0004853C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0004A348 File Offset: 0x00048548
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FrameIndex);
			}
			bool hasFStop = this.HasFStop;
			if (hasFStop)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.FStop);
			}
			bool hasFocalDistance = this.HasFocalDistance;
			if (hasFocalDistance)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.FocalDistance);
			}
			bool hasNearTransition = this.HasNearTransition;
			if (hasNearTransition)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.NearTransition);
			}
			bool hasFocalRegion = this.HasFocalRegion;
			if (hasFocalRegion)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.FocalRegion);
			}
			bool hasFarTransition = this.HasFarTransition;
			if (hasFarTransition)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.FarTransition);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0004A444 File Offset: 0x00048644
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrameIndex);
			}
			bool hasFStop = this.HasFStop;
			if (hasFStop)
			{
				num += 5;
			}
			bool hasFocalDistance = this.HasFocalDistance;
			if (hasFocalDistance)
			{
				num += 5;
			}
			bool hasNearTransition = this.HasNearTransition;
			if (hasNearTransition)
			{
				num += 5;
			}
			bool hasFocalRegion = this.HasFocalRegion;
			if (hasFocalRegion)
			{
				num += 5;
			}
			bool hasFarTransition = this.HasFarTransition;
			if (hasFarTransition)
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

		// Token: 0x0600145B RID: 5211 RVA: 0x0004A4EC File Offset: 0x000486EC
		[DebuggerNonUserCode]
		public void MergeFrom(DepthOfFieldFrame other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFrameIndex = other.HasFrameIndex;
				if (hasFrameIndex)
				{
					this.FrameIndex = other.FrameIndex;
				}
				bool hasFStop = other.HasFStop;
				if (hasFStop)
				{
					this.FStop = other.FStop;
				}
				bool hasFocalDistance = other.HasFocalDistance;
				if (hasFocalDistance)
				{
					this.FocalDistance = other.FocalDistance;
				}
				bool hasNearTransition = other.HasNearTransition;
				if (hasNearTransition)
				{
					this.NearTransition = other.NearTransition;
				}
				bool hasFocalRegion = other.HasFocalRegion;
				if (hasFocalRegion)
				{
					this.FocalRegion = other.FocalRegion;
				}
				bool hasFarTransition = other.HasFarTransition;
				if (hasFarTransition)
				{
					this.FarTransition = other.FarTransition;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0004A5BB File Offset: 0x000487BB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0004A5C8 File Offset: 0x000487C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 29U)
				{
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							if (num3 != 29U)
							{
								goto IL_0039;
							}
							this.FocalDistance = input.ReadFloat();
						}
						else
						{
							this.FStop = input.ReadFloat();
						}
					}
					else
					{
						this.FrameIndex = input.ReadInt32();
					}
				}
				else if (num3 != 37U)
				{
					if (num3 != 45U)
					{
						if (num3 != 53U)
						{
							goto IL_0039;
						}
						this.FarTransition = input.ReadFloat();
					}
					else
					{
						this.FocalRegion = input.ReadFloat();
					}
				}
				else
				{
					this.NearTransition = input.ReadFloat();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400082F RID: 2095
		private static readonly MessageParser<DepthOfFieldFrame> _parser = new MessageParser<DepthOfFieldFrame>(() => new DepthOfFieldFrame());

		// Token: 0x04000830 RID: 2096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000831 RID: 2097
		private int _hasBits0;

		// Token: 0x04000832 RID: 2098
		public const int FrameIndexFieldNumber = 1;

		// Token: 0x04000833 RID: 2099
		private static readonly int FrameIndexDefaultValue = 0;

		// Token: 0x04000834 RID: 2100
		private int frameIndex_;

		// Token: 0x04000835 RID: 2101
		public const int FStopFieldNumber = 2;

		// Token: 0x04000836 RID: 2102
		private static readonly float FStopDefaultValue = 0f;

		// Token: 0x04000837 RID: 2103
		private float fStop_;

		// Token: 0x04000838 RID: 2104
		public const int FocalDistanceFieldNumber = 3;

		// Token: 0x04000839 RID: 2105
		private static readonly float FocalDistanceDefaultValue = 0f;

		// Token: 0x0400083A RID: 2106
		private float focalDistance_;

		// Token: 0x0400083B RID: 2107
		public const int NearTransitionFieldNumber = 4;

		// Token: 0x0400083C RID: 2108
		private static readonly float NearTransitionDefaultValue = 0f;

		// Token: 0x0400083D RID: 2109
		private float nearTransition_;

		// Token: 0x0400083E RID: 2110
		public const int FocalRegionFieldNumber = 5;

		// Token: 0x0400083F RID: 2111
		private static readonly float FocalRegionDefaultValue = 0f;

		// Token: 0x04000840 RID: 2112
		private float focalRegion_;

		// Token: 0x04000841 RID: 2113
		public const int FarTransitionFieldNumber = 6;

		// Token: 0x04000842 RID: 2114
		private static readonly float FarTransitionDefaultValue = 0f;

		// Token: 0x04000843 RID: 2115
		private float farTransition_;
	}
}
