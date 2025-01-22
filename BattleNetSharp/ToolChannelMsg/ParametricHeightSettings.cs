using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D6 RID: 214
	public sealed class ParametricHeightSettings : IMessage<ParametricHeightSettings>, IMessage, IEquatable<ParametricHeightSettings>, IDeepCloneable<ParametricHeightSettings>, IBufferMessage
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0004B198 File Offset: 0x00049398
		[DebuggerNonUserCode]
		public static MessageParser<ParametricHeightSettings> Parser
		{
			get
			{
				return ParametricHeightSettings._parser;
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0004B1B0 File Offset: 0x000493B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[191];
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0004B1D8 File Offset: 0x000493D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParametricHeightSettings.Descriptor;
			}
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0004B1EF File Offset: 0x000493EF
		[DebuggerNonUserCode]
		public ParametricHeightSettings()
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0004B1FC File Offset: 0x000493FC
		[DebuggerNonUserCode]
		public ParametricHeightSettings(ParametricHeightSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.min_ = other.min_;
			this.max_ = other.max_;
			this.minSmoothness_ = other.minSmoothness_;
			this.maxSmoothness_ = other.maxSmoothness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0004B260 File Offset: 0x00049460
		[DebuggerNonUserCode]
		public ParametricHeightSettings Clone()
		{
			return new ParametricHeightSettings(this);
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0004B278 File Offset: 0x00049478
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x0004B2A9 File Offset: 0x000494A9
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
					minDefaultValue = ParametricHeightSettings.MinDefaultValue;
				}
				return minDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.min_ = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0004B2C4 File Offset: 0x000494C4
		[DebuggerNonUserCode]
		public bool HasMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0004B2E1 File Offset: 0x000494E1
		[DebuggerNonUserCode]
		public void ClearMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0004B2F4 File Offset: 0x000494F4
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x0004B325 File Offset: 0x00049525
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
					maxDefaultValue = ParametricHeightSettings.MaxDefaultValue;
				}
				return maxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.max_ = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0004B340 File Offset: 0x00049540
		[DebuggerNonUserCode]
		public bool HasMax
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0004B35D File Offset: 0x0004955D
		[DebuggerNonUserCode]
		public void ClearMax()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0004B370 File Offset: 0x00049570
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0004B3A1 File Offset: 0x000495A1
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
					minSmoothnessDefaultValue = ParametricHeightSettings.MinSmoothnessDefaultValue;
				}
				return minSmoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.minSmoothness_ = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0004B3BC File Offset: 0x000495BC
		[DebuggerNonUserCode]
		public bool HasMinSmoothness
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0004B3D9 File Offset: 0x000495D9
		[DebuggerNonUserCode]
		public void ClearMinSmoothness()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0004B3EC File Offset: 0x000495EC
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0004B41D File Offset: 0x0004961D
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
					maxSmoothnessDefaultValue = ParametricHeightSettings.MaxSmoothnessDefaultValue;
				}
				return maxSmoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.maxSmoothness_ = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0004B438 File Offset: 0x00049638
		[DebuggerNonUserCode]
		public bool HasMaxSmoothness
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0004B455 File Offset: 0x00049655
		[DebuggerNonUserCode]
		public void ClearMaxSmoothness()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0004B468 File Offset: 0x00049668
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParametricHeightSettings);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0004B488 File Offset: 0x00049688
		[DebuggerNonUserCode]
		public bool Equals(ParametricHeightSettings other)
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

		// Token: 0x060014A8 RID: 5288 RVA: 0x0004B558 File Offset: 0x00049758
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

		// Token: 0x060014A9 RID: 5289 RVA: 0x0004B604 File Offset: 0x00049804
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0004B61C File Offset: 0x0004981C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0004B628 File Offset: 0x00049828
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

		// Token: 0x060014AC RID: 5292 RVA: 0x0004B6DC File Offset: 0x000498DC
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

		// Token: 0x060014AD RID: 5293 RVA: 0x0004B754 File Offset: 0x00049954
		[DebuggerNonUserCode]
		public void MergeFrom(ParametricHeightSettings other)
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

		// Token: 0x060014AE RID: 5294 RVA: 0x0004B7EA File Offset: 0x000499EA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0004B7F8 File Offset: 0x000499F8
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

		// Token: 0x0400085B RID: 2139
		private static readonly MessageParser<ParametricHeightSettings> _parser = new MessageParser<ParametricHeightSettings>(() => new ParametricHeightSettings());

		// Token: 0x0400085C RID: 2140
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400085D RID: 2141
		private int _hasBits0;

		// Token: 0x0400085E RID: 2142
		public const int MinFieldNumber = 1;

		// Token: 0x0400085F RID: 2143
		private static readonly float MinDefaultValue = 0f;

		// Token: 0x04000860 RID: 2144
		private float min_;

		// Token: 0x04000861 RID: 2145
		public const int MaxFieldNumber = 2;

		// Token: 0x04000862 RID: 2146
		private static readonly float MaxDefaultValue = 0f;

		// Token: 0x04000863 RID: 2147
		private float max_;

		// Token: 0x04000864 RID: 2148
		public const int MinSmoothnessFieldNumber = 3;

		// Token: 0x04000865 RID: 2149
		private static readonly float MinSmoothnessDefaultValue = 0f;

		// Token: 0x04000866 RID: 2150
		private float minSmoothness_;

		// Token: 0x04000867 RID: 2151
		public const int MaxSmoothnessFieldNumber = 4;

		// Token: 0x04000868 RID: 2152
		private static readonly float MaxSmoothnessDefaultValue = 0f;

		// Token: 0x04000869 RID: 2153
		private float maxSmoothness_;
	}
}
