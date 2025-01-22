using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000048 RID: 72
	public sealed class HoudiniSimInformation : IMessage<HoudiniSimInformation>, IMessage, IEquatable<HoudiniSimInformation>, IDeepCloneable<HoudiniSimInformation>, IBufferMessage
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001AA00 File Offset: 0x00018C00
		[DebuggerNonUserCode]
		public static MessageParser<HoudiniSimInformation> Parser
		{
			get
			{
				return HoudiniSimInformation._parser;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001AA18 File Offset: 0x00018C18
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[49];
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001AA3C File Offset: 0x00018C3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoudiniSimInformation.Descriptor;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001AA53 File Offset: 0x00018C53
		[DebuggerNonUserCode]
		public HoudiniSimInformation()
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001AA60 File Offset: 0x00018C60
		[DebuggerNonUserCode]
		public HoudiniSimInformation(HoudiniSimInformation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.simulationSize_ = other.simulationSize_;
			this.particleCount_ = other.particleCount_;
			this.frameCount_ = other.frameCount_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0001AAD0 File Offset: 0x00018CD0
		[DebuggerNonUserCode]
		public HoudiniSimInformation Clone()
		{
			return new HoudiniSimInformation(this);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001AAE8 File Offset: 0x00018CE8
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x0001AB19 File Offset: 0x00018D19
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = HoudiniSimInformation.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001AB34 File Offset: 0x00018D34
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0001AB51 File Offset: 0x00018D51
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001AB64 File Offset: 0x00018D64
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0001AB95 File Offset: 0x00018D95
		[DebuggerNonUserCode]
		public float SimulationSize
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float simulationSizeDefaultValue;
				if (flag)
				{
					simulationSizeDefaultValue = this.simulationSize_;
				}
				else
				{
					simulationSizeDefaultValue = HoudiniSimInformation.SimulationSizeDefaultValue;
				}
				return simulationSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.simulationSize_ = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		[DebuggerNonUserCode]
		public bool HasSimulationSize
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001ABCD File Offset: 0x00018DCD
		[DebuggerNonUserCode]
		public void ClearSimulationSize()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0001AC11 File Offset: 0x00018E11
		[DebuggerNonUserCode]
		public int ParticleCount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int particleCountDefaultValue;
				if (flag)
				{
					particleCountDefaultValue = this.particleCount_;
				}
				else
				{
					particleCountDefaultValue = HoudiniSimInformation.ParticleCountDefaultValue;
				}
				return particleCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.particleCount_ = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0001AC2C File Offset: 0x00018E2C
		[DebuggerNonUserCode]
		public bool HasParticleCount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0001AC49 File Offset: 0x00018E49
		[DebuggerNonUserCode]
		public void ClearParticleCount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001AC5C File Offset: 0x00018E5C
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0001AC8D File Offset: 0x00018E8D
		[DebuggerNonUserCode]
		public int FrameCount
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int frameCountDefaultValue;
				if (flag)
				{
					frameCountDefaultValue = this.frameCount_;
				}
				else
				{
					frameCountDefaultValue = HoudiniSimInformation.FrameCountDefaultValue;
				}
				return frameCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.frameCount_ = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		[DebuggerNonUserCode]
		public bool HasFrameCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001ACC5 File Offset: 0x00018EC5
		[DebuggerNonUserCode]
		public void ClearFrameCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0001AD0A File Offset: 0x00018F0A
		[DebuggerNonUserCode]
		public float Duration
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float durationDefaultValue;
				if (flag)
				{
					durationDefaultValue = this.duration_;
				}
				else
				{
					durationDefaultValue = HoudiniSimInformation.DurationDefaultValue;
				}
				return durationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.duration_ = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001AD24 File Offset: 0x00018F24
		[DebuggerNonUserCode]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001AD42 File Offset: 0x00018F42
		[DebuggerNonUserCode]
		public void ClearDuration()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0001AD54 File Offset: 0x00018F54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoudiniSimInformation);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001AD74 File Offset: 0x00018F74
		[DebuggerNonUserCode]
		public bool Equals(HoudiniSimInformation other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SimulationSize, other.SimulationSize);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ParticleCount != other.ParticleCount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FrameCount != other.FrameCount;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001AE50 File Offset: 0x00019050
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasSimulationSize = this.HasSimulationSize;
			if (hasSimulationSize)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SimulationSize);
			}
			bool hasParticleCount = this.HasParticleCount;
			if (hasParticleCount)
			{
				num ^= this.ParticleCount.GetHashCode();
			}
			bool hasFrameCount = this.HasFrameCount;
			if (hasFrameCount)
			{
				num ^= this.FrameCount.GetHashCode();
			}
			bool hasDuration = this.HasDuration;
			if (hasDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001AF18 File Offset: 0x00019118
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0001AF30 File Offset: 0x00019130
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001AF3C File Offset: 0x0001913C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasSimulationSize = this.HasSimulationSize;
			if (hasSimulationSize)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.SimulationSize);
			}
			bool hasParticleCount = this.HasParticleCount;
			if (hasParticleCount)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ParticleCount);
			}
			bool hasFrameCount = this.HasFrameCount;
			if (hasFrameCount)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FrameCount);
			}
			bool hasDuration = this.HasDuration;
			if (hasDuration)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Duration);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0001B014 File Offset: 0x00019214
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasSimulationSize = this.HasSimulationSize;
			if (hasSimulationSize)
			{
				num += 5;
			}
			bool hasParticleCount = this.HasParticleCount;
			if (hasParticleCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ParticleCount);
			}
			bool hasFrameCount = this.HasFrameCount;
			if (hasFrameCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrameCount);
			}
			bool hasDuration = this.HasDuration;
			if (hasDuration)
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

		// Token: 0x060005FA RID: 1530 RVA: 0x0001B0C4 File Offset: 0x000192C4
		[DebuggerNonUserCode]
		public void MergeFrom(HoudiniSimInformation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasSimulationSize = other.HasSimulationSize;
				if (hasSimulationSize)
				{
					this.SimulationSize = other.SimulationSize;
				}
				bool hasParticleCount = other.HasParticleCount;
				if (hasParticleCount)
				{
					this.ParticleCount = other.ParticleCount;
				}
				bool hasFrameCount = other.HasFrameCount;
				if (hasFrameCount)
				{
					this.FrameCount = other.FrameCount;
				}
				bool hasDuration = other.HasDuration;
				if (hasDuration)
				{
					this.Duration = other.Duration;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0001B178 File Offset: 0x00019378
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0001B184 File Offset: 0x00019384
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0032;
						}
						this.SimulationSize = input.ReadFloat();
					}
					else
					{
						this.SnoHandle = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 45U)
						{
							goto IL_0032;
						}
						this.Duration = input.ReadFloat();
					}
					else
					{
						this.FrameCount = input.ReadInt32();
					}
				}
				else
				{
					this.ParticleCount = input.ReadInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000273 RID: 627
		private static readonly MessageParser<HoudiniSimInformation> _parser = new MessageParser<HoudiniSimInformation>(() => new HoudiniSimInformation());

		// Token: 0x04000274 RID: 628
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000275 RID: 629
		private int _hasBits0;

		// Token: 0x04000276 RID: 630
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000277 RID: 631
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000278 RID: 632
		private int snoHandle_;

		// Token: 0x04000279 RID: 633
		public const int SimulationSizeFieldNumber = 2;

		// Token: 0x0400027A RID: 634
		private static readonly float SimulationSizeDefaultValue = 0f;

		// Token: 0x0400027B RID: 635
		private float simulationSize_;

		// Token: 0x0400027C RID: 636
		public const int ParticleCountFieldNumber = 3;

		// Token: 0x0400027D RID: 637
		private static readonly int ParticleCountDefaultValue = 0;

		// Token: 0x0400027E RID: 638
		private int particleCount_;

		// Token: 0x0400027F RID: 639
		public const int FrameCountFieldNumber = 4;

		// Token: 0x04000280 RID: 640
		private static readonly int FrameCountDefaultValue = 0;

		// Token: 0x04000281 RID: 641
		private int frameCount_;

		// Token: 0x04000282 RID: 642
		public const int DurationFieldNumber = 5;

		// Token: 0x04000283 RID: 643
		private static readonly float DurationDefaultValue = 0f;

		// Token: 0x04000284 RID: 644
		private float duration_;
	}
}
