using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D7 RID: 215
	public sealed class ParametricSlopeSettings : IMessage<ParametricSlopeSettings>, IMessage, IEquatable<ParametricSlopeSettings>, IDeepCloneable<ParametricSlopeSettings>, IBufferMessage
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		[DebuggerNonUserCode]
		public static MessageParser<ParametricSlopeSettings> Parser
		{
			get
			{
				return ParametricSlopeSettings._parser;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0004B900 File Offset: 0x00049B00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[192];
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0004B928 File Offset: 0x00049B28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParametricSlopeSettings.Descriptor;
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0004B93F File Offset: 0x00049B3F
		[DebuggerNonUserCode]
		public ParametricSlopeSettings()
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0004B94C File Offset: 0x00049B4C
		[DebuggerNonUserCode]
		public ParametricSlopeSettings(ParametricSlopeSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.min_ = other.min_;
			this.max_ = other.max_;
			this.minSmoothness_ = other.minSmoothness_;
			this.maxSmoothness_ = other.maxSmoothness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0004B9B0 File Offset: 0x00049BB0
		[DebuggerNonUserCode]
		public ParametricSlopeSettings Clone()
		{
			return new ParametricSlopeSettings(this);
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0004B9C8 File Offset: 0x00049BC8
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0004B9F9 File Offset: 0x00049BF9
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
					minDefaultValue = ParametricSlopeSettings.MinDefaultValue;
				}
				return minDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.min_ = value;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0004BA14 File Offset: 0x00049C14
		[DebuggerNonUserCode]
		public bool HasMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0004BA31 File Offset: 0x00049C31
		[DebuggerNonUserCode]
		public void ClearMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0004BA44 File Offset: 0x00049C44
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x0004BA75 File Offset: 0x00049C75
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
					maxDefaultValue = ParametricSlopeSettings.MaxDefaultValue;
				}
				return maxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.max_ = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x0004BA90 File Offset: 0x00049C90
		[DebuggerNonUserCode]
		public bool HasMax
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0004BAAD File Offset: 0x00049CAD
		[DebuggerNonUserCode]
		public void ClearMax()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0004BAC0 File Offset: 0x00049CC0
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0004BAF1 File Offset: 0x00049CF1
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
					minSmoothnessDefaultValue = ParametricSlopeSettings.MinSmoothnessDefaultValue;
				}
				return minSmoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.minSmoothness_ = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0004BB0C File Offset: 0x00049D0C
		[DebuggerNonUserCode]
		public bool HasMinSmoothness
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0004BB29 File Offset: 0x00049D29
		[DebuggerNonUserCode]
		public void ClearMinSmoothness()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0004BB3C File Offset: 0x00049D3C
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x0004BB6D File Offset: 0x00049D6D
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
					maxSmoothnessDefaultValue = ParametricSlopeSettings.MaxSmoothnessDefaultValue;
				}
				return maxSmoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.maxSmoothness_ = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x0004BB88 File Offset: 0x00049D88
		[DebuggerNonUserCode]
		public bool HasMaxSmoothness
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0004BBA5 File Offset: 0x00049DA5
		[DebuggerNonUserCode]
		public void ClearMaxSmoothness()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0004BBB8 File Offset: 0x00049DB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParametricSlopeSettings);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0004BBD8 File Offset: 0x00049DD8
		[DebuggerNonUserCode]
		public bool Equals(ParametricSlopeSettings other)
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

		// Token: 0x060014C9 RID: 5321 RVA: 0x0004BCA8 File Offset: 0x00049EA8
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

		// Token: 0x060014CA RID: 5322 RVA: 0x0004BD54 File Offset: 0x00049F54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0004BD6C File Offset: 0x00049F6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0004BD78 File Offset: 0x00049F78
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

		// Token: 0x060014CD RID: 5325 RVA: 0x0004BE2C File Offset: 0x0004A02C
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

		// Token: 0x060014CE RID: 5326 RVA: 0x0004BEA4 File Offset: 0x0004A0A4
		[DebuggerNonUserCode]
		public void MergeFrom(ParametricSlopeSettings other)
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

		// Token: 0x060014CF RID: 5327 RVA: 0x0004BF3A File Offset: 0x0004A13A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0004BF48 File Offset: 0x0004A148
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

		// Token: 0x0400086A RID: 2154
		private static readonly MessageParser<ParametricSlopeSettings> _parser = new MessageParser<ParametricSlopeSettings>(() => new ParametricSlopeSettings());

		// Token: 0x0400086B RID: 2155
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400086C RID: 2156
		private int _hasBits0;

		// Token: 0x0400086D RID: 2157
		public const int MinFieldNumber = 1;

		// Token: 0x0400086E RID: 2158
		private static readonly float MinDefaultValue = 0f;

		// Token: 0x0400086F RID: 2159
		private float min_;

		// Token: 0x04000870 RID: 2160
		public const int MaxFieldNumber = 2;

		// Token: 0x04000871 RID: 2161
		private static readonly float MaxDefaultValue = 0f;

		// Token: 0x04000872 RID: 2162
		private float max_;

		// Token: 0x04000873 RID: 2163
		public const int MinSmoothnessFieldNumber = 3;

		// Token: 0x04000874 RID: 2164
		private static readonly float MinSmoothnessDefaultValue = 0f;

		// Token: 0x04000875 RID: 2165
		private float minSmoothness_;

		// Token: 0x04000876 RID: 2166
		public const int MaxSmoothnessFieldNumber = 4;

		// Token: 0x04000877 RID: 2167
		private static readonly float MaxSmoothnessDefaultValue = 0f;

		// Token: 0x04000878 RID: 2168
		private float maxSmoothness_;
	}
}
