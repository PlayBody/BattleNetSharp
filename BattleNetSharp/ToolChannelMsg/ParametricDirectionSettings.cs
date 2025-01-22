using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D8 RID: 216
	public sealed class ParametricDirectionSettings : IMessage<ParametricDirectionSettings>, IMessage, IEquatable<ParametricDirectionSettings>, IDeepCloneable<ParametricDirectionSettings>, IBufferMessage
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0004C038 File Offset: 0x0004A238
		[DebuggerNonUserCode]
		public static MessageParser<ParametricDirectionSettings> Parser
		{
			get
			{
				return ParametricDirectionSettings._parser;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0004C050 File Offset: 0x0004A250
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[193];
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0004C078 File Offset: 0x0004A278
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParametricDirectionSettings.Descriptor;
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0004C08F File Offset: 0x0004A28F
		[DebuggerNonUserCode]
		public ParametricDirectionSettings()
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0004C09C File Offset: 0x0004A29C
		[DebuggerNonUserCode]
		public ParametricDirectionSettings(ParametricDirectionSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.altitude_ = other.altitude_;
			this.azimuth_ = other.azimuth_;
			this.tolerance_ = other.tolerance_;
			this.smoothness_ = other.smoothness_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0004C100 File Offset: 0x0004A300
		[DebuggerNonUserCode]
		public ParametricDirectionSettings Clone()
		{
			return new ParametricDirectionSettings(this);
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0004C118 File Offset: 0x0004A318
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x0004C149 File Offset: 0x0004A349
		[DebuggerNonUserCode]
		public float Altitude
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float altitudeDefaultValue;
				if (flag)
				{
					altitudeDefaultValue = this.altitude_;
				}
				else
				{
					altitudeDefaultValue = ParametricDirectionSettings.AltitudeDefaultValue;
				}
				return altitudeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.altitude_ = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0004C164 File Offset: 0x0004A364
		[DebuggerNonUserCode]
		public bool HasAltitude
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0004C181 File Offset: 0x0004A381
		[DebuggerNonUserCode]
		public void ClearAltitude()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0004C194 File Offset: 0x0004A394
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x0004C1C5 File Offset: 0x0004A3C5
		[DebuggerNonUserCode]
		public float Azimuth
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float azimuthDefaultValue;
				if (flag)
				{
					azimuthDefaultValue = this.azimuth_;
				}
				else
				{
					azimuthDefaultValue = ParametricDirectionSettings.AzimuthDefaultValue;
				}
				return azimuthDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.azimuth_ = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0004C1E0 File Offset: 0x0004A3E0
		[DebuggerNonUserCode]
		public bool HasAzimuth
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0004C1FD File Offset: 0x0004A3FD
		[DebuggerNonUserCode]
		public void ClearAzimuth()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0004C210 File Offset: 0x0004A410
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x0004C241 File Offset: 0x0004A441
		[DebuggerNonUserCode]
		public float Tolerance
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float toleranceDefaultValue;
				if (flag)
				{
					toleranceDefaultValue = this.tolerance_;
				}
				else
				{
					toleranceDefaultValue = ParametricDirectionSettings.ToleranceDefaultValue;
				}
				return toleranceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.tolerance_ = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0004C25C File Offset: 0x0004A45C
		[DebuggerNonUserCode]
		public bool HasTolerance
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0004C279 File Offset: 0x0004A479
		[DebuggerNonUserCode]
		public void ClearTolerance()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0004C28C File Offset: 0x0004A48C
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0004C2BD File Offset: 0x0004A4BD
		[DebuggerNonUserCode]
		public float Smoothness
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float smoothnessDefaultValue;
				if (flag)
				{
					smoothnessDefaultValue = this.smoothness_;
				}
				else
				{
					smoothnessDefaultValue = ParametricDirectionSettings.SmoothnessDefaultValue;
				}
				return smoothnessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.smoothness_ = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		[DebuggerNonUserCode]
		public bool HasSmoothness
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0004C2F5 File Offset: 0x0004A4F5
		[DebuggerNonUserCode]
		public void ClearSmoothness()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0004C308 File Offset: 0x0004A508
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParametricDirectionSettings);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0004C328 File Offset: 0x0004A528
		[DebuggerNonUserCode]
		public bool Equals(ParametricDirectionSettings other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Altitude, other.Altitude);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Azimuth, other.Azimuth);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Tolerance, other.Tolerance);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Smoothness, other.Smoothness);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0004C3F8 File Offset: 0x0004A5F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAltitude = this.HasAltitude;
			if (hasAltitude)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Altitude);
			}
			bool hasAzimuth = this.HasAzimuth;
			if (hasAzimuth)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Azimuth);
			}
			bool hasTolerance = this.HasTolerance;
			if (hasTolerance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Tolerance);
			}
			bool hasSmoothness = this.HasSmoothness;
			if (hasSmoothness)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Smoothness);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0004C4A4 File Offset: 0x0004A6A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0004C4BC File Offset: 0x0004A6BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0004C4C8 File Offset: 0x0004A6C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAltitude = this.HasAltitude;
			if (hasAltitude)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Altitude);
			}
			bool hasAzimuth = this.HasAzimuth;
			if (hasAzimuth)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Azimuth);
			}
			bool hasTolerance = this.HasTolerance;
			if (hasTolerance)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Tolerance);
			}
			bool hasSmoothness = this.HasSmoothness;
			if (hasSmoothness)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Smoothness);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0004C57C File Offset: 0x0004A77C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAltitude = this.HasAltitude;
			if (hasAltitude)
			{
				num += 5;
			}
			bool hasAzimuth = this.HasAzimuth;
			if (hasAzimuth)
			{
				num += 5;
			}
			bool hasTolerance = this.HasTolerance;
			if (hasTolerance)
			{
				num += 5;
			}
			bool hasSmoothness = this.HasSmoothness;
			if (hasSmoothness)
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

		// Token: 0x060014EF RID: 5359 RVA: 0x0004C5F4 File Offset: 0x0004A7F4
		[DebuggerNonUserCode]
		public void MergeFrom(ParametricDirectionSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAltitude = other.HasAltitude;
				if (hasAltitude)
				{
					this.Altitude = other.Altitude;
				}
				bool hasAzimuth = other.HasAzimuth;
				if (hasAzimuth)
				{
					this.Azimuth = other.Azimuth;
				}
				bool hasTolerance = other.HasTolerance;
				if (hasTolerance)
				{
					this.Tolerance = other.Tolerance;
				}
				bool hasSmoothness = other.HasSmoothness;
				if (hasSmoothness)
				{
					this.Smoothness = other.Smoothness;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0004C68A File Offset: 0x0004A88A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0004C698 File Offset: 0x0004A898
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
						this.Azimuth = input.ReadFloat();
					}
					else
					{
						this.Altitude = input.ReadFloat();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 37U)
					{
						goto IL_0029;
					}
					this.Smoothness = input.ReadFloat();
				}
				else
				{
					this.Tolerance = input.ReadFloat();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000879 RID: 2169
		private static readonly MessageParser<ParametricDirectionSettings> _parser = new MessageParser<ParametricDirectionSettings>(() => new ParametricDirectionSettings());

		// Token: 0x0400087A RID: 2170
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400087B RID: 2171
		private int _hasBits0;

		// Token: 0x0400087C RID: 2172
		public const int AltitudeFieldNumber = 1;

		// Token: 0x0400087D RID: 2173
		private static readonly float AltitudeDefaultValue = 0f;

		// Token: 0x0400087E RID: 2174
		private float altitude_;

		// Token: 0x0400087F RID: 2175
		public const int AzimuthFieldNumber = 2;

		// Token: 0x04000880 RID: 2176
		private static readonly float AzimuthDefaultValue = 0f;

		// Token: 0x04000881 RID: 2177
		private float azimuth_;

		// Token: 0x04000882 RID: 2178
		public const int ToleranceFieldNumber = 3;

		// Token: 0x04000883 RID: 2179
		private static readonly float ToleranceDefaultValue = 0f;

		// Token: 0x04000884 RID: 2180
		private float tolerance_;

		// Token: 0x04000885 RID: 2181
		public const int SmoothnessFieldNumber = 4;

		// Token: 0x04000886 RID: 2182
		private static readonly float SmoothnessDefaultValue = 0f;

		// Token: 0x04000887 RID: 2183
		private float smoothness_;
	}
}
