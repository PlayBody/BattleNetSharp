using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000DA RID: 218
	public sealed class ParametricDistanceToWaterSettings : IMessage<ParametricDistanceToWaterSettings>, IMessage, IEquatable<ParametricDistanceToWaterSettings>, IDeepCloneable<ParametricDistanceToWaterSettings>, IBufferMessage
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0004D15C File Offset: 0x0004B35C
		[DebuggerNonUserCode]
		public static MessageParser<ParametricDistanceToWaterSettings> Parser
		{
			get
			{
				return ParametricDistanceToWaterSettings._parser;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x0004D174 File Offset: 0x0004B374
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[195];
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0004D19C File Offset: 0x0004B39C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParametricDistanceToWaterSettings.Descriptor;
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0004D1B3 File Offset: 0x0004B3B3
		[DebuggerNonUserCode]
		public ParametricDistanceToWaterSettings()
		{
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0004D1C0 File Offset: 0x0004B3C0
		[DebuggerNonUserCode]
		public ParametricDistanceToWaterSettings(ParametricDistanceToWaterSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.min_ = other.min_;
			this.max_ = other.max_;
			this.minSmoothness_ = other.minSmoothness_;
			this.maxSmoothness_ = other.maxSmoothness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0004D224 File Offset: 0x0004B424
		[DebuggerNonUserCode]
		public ParametricDistanceToWaterSettings Clone()
		{
			return new ParametricDistanceToWaterSettings(this);
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0004D23C File Offset: 0x0004B43C
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x0004D26D File Offset: 0x0004B46D
		[DebuggerNonUserCode]
		public float Min
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float minDefaultValue;
				if (flag)
				{
					minDefaultValue = this.min_;
				}
				else
				{
					minDefaultValue = ParametricDistanceToWaterSettings.MinDefaultValue;
				}
				return minDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.min_ = value;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x0004D288 File Offset: 0x0004B488
		[DebuggerNonUserCode]
		public bool HasMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0004D2A5 File Offset: 0x0004B4A5
		[DebuggerNonUserCode]
		public void ClearMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x0004D2E9 File Offset: 0x0004B4E9
		[DebuggerNonUserCode]
		public float Max
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float maxDefaultValue;
				if (flag)
				{
					maxDefaultValue = this.max_;
				}
				else
				{
					maxDefaultValue = ParametricDistanceToWaterSettings.MaxDefaultValue;
				}
				return maxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.max_ = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0004D304 File Offset: 0x0004B504
		[DebuggerNonUserCode]
		public bool HasMax
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0004D321 File Offset: 0x0004B521
		[DebuggerNonUserCode]
		public void ClearMax()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0004D334 File Offset: 0x0004B534
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x0004D365 File Offset: 0x0004B565
		[DebuggerNonUserCode]
		public float MinSmoothness
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float minSmoothnessDefaultValue;
				if (flag)
				{
					minSmoothnessDefaultValue = this.minSmoothness_;
				}
				else
				{
					minSmoothnessDefaultValue = ParametricDistanceToWaterSettings.MinSmoothnessDefaultValue;
				}
				return minSmoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.minSmoothness_ = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0004D380 File Offset: 0x0004B580
		[DebuggerNonUserCode]
		public bool HasMinSmoothness
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0004D39D File Offset: 0x0004B59D
		[DebuggerNonUserCode]
		public void ClearMinSmoothness()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0004D3B0 File Offset: 0x0004B5B0
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x0004D3E1 File Offset: 0x0004B5E1
		[DebuggerNonUserCode]
		public float MaxSmoothness
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float maxSmoothnessDefaultValue;
				if (flag)
				{
					maxSmoothnessDefaultValue = this.maxSmoothness_;
				}
				else
				{
					maxSmoothnessDefaultValue = ParametricDistanceToWaterSettings.MaxSmoothnessDefaultValue;
				}
				return maxSmoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.maxSmoothness_ = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0004D3FC File Offset: 0x0004B5FC
		[DebuggerNonUserCode]
		public bool HasMaxSmoothness
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0004D419 File Offset: 0x0004B619
		[DebuggerNonUserCode]
		public void ClearMaxSmoothness()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0004D42C File Offset: 0x0004B62C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParametricDistanceToWaterSettings);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0004D44C File Offset: 0x0004B64C
		[DebuggerNonUserCode]
		public bool Equals(ParametricDistanceToWaterSettings other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Min, other.Min);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Max, other.Max);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MinSmoothness, other.MinSmoothness);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.MaxSmoothness, other.MaxSmoothness);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0004D51C File Offset: 0x0004B71C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Max);
			}
			bool hasMinSmoothness = this.HasMinSmoothness;
			if (hasMinSmoothness)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MinSmoothness);
			}
			bool hasMaxSmoothness = this.HasMaxSmoothness;
			if (hasMaxSmoothness)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.MaxSmoothness);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0004D5EC File Offset: 0x0004B7EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Max);
			}
			bool hasMinSmoothness = this.HasMinSmoothness;
			if (hasMinSmoothness)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.MinSmoothness);
			}
			bool hasMaxSmoothness = this.HasMaxSmoothness;
			if (hasMaxSmoothness)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.MaxSmoothness);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0004D6A0 File Offset: 0x0004B8A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				num += 5;
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				num += 5;
			}
			bool hasMinSmoothness = this.HasMinSmoothness;
			if (hasMinSmoothness)
			{
				num += 5;
			}
			bool hasMaxSmoothness = this.HasMaxSmoothness;
			if (hasMaxSmoothness)
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

		// Token: 0x06001539 RID: 5433 RVA: 0x0004D718 File Offset: 0x0004B918
		[DebuggerNonUserCode]
		public void MergeFrom(ParametricDistanceToWaterSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMin = other.HasMin;
				if (hasMin)
				{
					this.Min = other.Min;
				}
				bool hasMax = other.HasMax;
				if (hasMax)
				{
					this.Max = other.Max;
				}
				bool hasMinSmoothness = other.HasMinSmoothness;
				if (hasMinSmoothness)
				{
					this.MinSmoothness = other.MinSmoothness;
				}
				bool hasMaxSmoothness = other.HasMaxSmoothness;
				if (hasMaxSmoothness)
				{
					this.MaxSmoothness = other.MaxSmoothness;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0004D7AE File Offset: 0x0004B9AE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0004D7BC File Offset: 0x0004B9BC
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
						this.Max = input.ReadFloat();
					}
					else
					{
						this.Min = input.ReadFloat();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						goto IL_0029;
					}
					this.MaxSmoothness = input.ReadFloat();
				}
				else
				{
					this.MinSmoothness = input.ReadFloat();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400089D RID: 2205
		private static readonly MessageParser<ParametricDistanceToWaterSettings> _parser = new MessageParser<ParametricDistanceToWaterSettings>(() => new ParametricDistanceToWaterSettings());

		// Token: 0x0400089E RID: 2206
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400089F RID: 2207
		private int _hasBits0;

		// Token: 0x040008A0 RID: 2208
		public const int MinFieldNumber = 1;

		// Token: 0x040008A1 RID: 2209
		private static readonly float MinDefaultValue = 0f;

		// Token: 0x040008A2 RID: 2210
		private float min_;

		// Token: 0x040008A3 RID: 2211
		public const int MaxFieldNumber = 2;

		// Token: 0x040008A4 RID: 2212
		private static readonly float MaxDefaultValue = 0f;

		// Token: 0x040008A5 RID: 2213
		private float max_;

		// Token: 0x040008A6 RID: 2214
		public const int MinSmoothnessFieldNumber = 3;

		// Token: 0x040008A7 RID: 2215
		private static readonly float MinSmoothnessDefaultValue = 0f;

		// Token: 0x040008A8 RID: 2216
		private float minSmoothness_;

		// Token: 0x040008A9 RID: 2217
		public const int MaxSmoothnessFieldNumber = 4;

		// Token: 0x040008AA RID: 2218
		private static readonly float MaxSmoothnessDefaultValue = 0f;

		// Token: 0x040008AB RID: 2219
		private float maxSmoothness_;
	}
}
