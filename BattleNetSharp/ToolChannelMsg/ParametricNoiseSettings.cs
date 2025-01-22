using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D9 RID: 217
	public sealed class ParametricNoiseSettings : IMessage<ParametricNoiseSettings>, IMessage, IEquatable<ParametricNoiseSettings>, IDeepCloneable<ParametricNoiseSettings>, IBufferMessage
	{
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x0004C788 File Offset: 0x0004A988
		[DebuggerNonUserCode]
		public static MessageParser<ParametricNoiseSettings> Parser
		{
			get
			{
				return ParametricNoiseSettings._parser;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[194];
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0004C7C8 File Offset: 0x0004A9C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParametricNoiseSettings.Descriptor;
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0004C7DF File Offset: 0x0004A9DF
		[DebuggerNonUserCode]
		public ParametricNoiseSettings()
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0004C7EC File Offset: 0x0004A9EC
		[DebuggerNonUserCode]
		public ParametricNoiseSettings(ParametricNoiseSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.frequency_ = other.frequency_;
			this.tileDistance_ = other.tileDistance_;
			this.min_ = other.min_;
			this.max_ = other.max_;
			this.offsetX_ = other.offsetX_;
			this.offsetY_ = other.offsetY_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0004C868 File Offset: 0x0004AA68
		[DebuggerNonUserCode]
		public ParametricNoiseSettings Clone()
		{
			return new ParametricNoiseSettings(this);
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0004C880 File Offset: 0x0004AA80
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0004C8B1 File Offset: 0x0004AAB1
		[DebuggerNonUserCode]
		public float Frequency
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float frequencyDefaultValue;
				if (flag)
				{
					frequencyDefaultValue = this.frequency_;
				}
				else
				{
					frequencyDefaultValue = ParametricNoiseSettings.FrequencyDefaultValue;
				}
				return frequencyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.frequency_ = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0004C8CC File Offset: 0x0004AACC
		[DebuggerNonUserCode]
		public bool HasFrequency
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0004C8E9 File Offset: 0x0004AAE9
		[DebuggerNonUserCode]
		public void ClearFrequency()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0004C8FC File Offset: 0x0004AAFC
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x0004C92D File Offset: 0x0004AB2D
		[DebuggerNonUserCode]
		public float TileDistance
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float tileDistanceDefaultValue;
				if (flag)
				{
					tileDistanceDefaultValue = this.tileDistance_;
				}
				else
				{
					tileDistanceDefaultValue = ParametricNoiseSettings.TileDistanceDefaultValue;
				}
				return tileDistanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.tileDistance_ = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0004C948 File Offset: 0x0004AB48
		[DebuggerNonUserCode]
		public bool HasTileDistance
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0004C965 File Offset: 0x0004AB65
		[DebuggerNonUserCode]
		public void ClearTileDistance()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x0004C978 File Offset: 0x0004AB78
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x0004C9A9 File Offset: 0x0004ABA9
		[DebuggerNonUserCode]
		public float Min
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float minDefaultValue;
				if (flag)
				{
					minDefaultValue = this.min_;
				}
				else
				{
					minDefaultValue = ParametricNoiseSettings.MinDefaultValue;
				}
				return minDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.min_ = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x0004C9C4 File Offset: 0x0004ABC4
		[DebuggerNonUserCode]
		public bool HasMin
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0004C9E1 File Offset: 0x0004ABE1
		[DebuggerNonUserCode]
		public void ClearMin()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0004C9F4 File Offset: 0x0004ABF4
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0004CA25 File Offset: 0x0004AC25
		[DebuggerNonUserCode]
		public float Max
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float maxDefaultValue;
				if (flag)
				{
					maxDefaultValue = this.max_;
				}
				else
				{
					maxDefaultValue = ParametricNoiseSettings.MaxDefaultValue;
				}
				return maxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.max_ = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0004CA40 File Offset: 0x0004AC40
		[DebuggerNonUserCode]
		public bool HasMax
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0004CA5D File Offset: 0x0004AC5D
		[DebuggerNonUserCode]
		public void ClearMax()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0004CA70 File Offset: 0x0004AC70
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x0004CAA2 File Offset: 0x0004ACA2
		[DebuggerNonUserCode]
		public float OffsetX
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float offsetXDefaultValue;
				if (flag)
				{
					offsetXDefaultValue = this.offsetX_;
				}
				else
				{
					offsetXDefaultValue = ParametricNoiseSettings.OffsetXDefaultValue;
				}
				return offsetXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.offsetX_ = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x0004CABC File Offset: 0x0004ACBC
		[DebuggerNonUserCode]
		public bool HasOffsetX
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0004CADA File Offset: 0x0004ACDA
		[DebuggerNonUserCode]
		public void ClearOffsetX()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0004CAEC File Offset: 0x0004ACEC
		// (set) Token: 0x0600150E RID: 5390 RVA: 0x0004CB1E File Offset: 0x0004AD1E
		[DebuggerNonUserCode]
		public float OffsetY
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				float offsetYDefaultValue;
				if (flag)
				{
					offsetYDefaultValue = this.offsetY_;
				}
				else
				{
					offsetYDefaultValue = ParametricNoiseSettings.OffsetYDefaultValue;
				}
				return offsetYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.offsetY_ = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0004CB38 File Offset: 0x0004AD38
		[DebuggerNonUserCode]
		public bool HasOffsetY
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0004CB56 File Offset: 0x0004AD56
		[DebuggerNonUserCode]
		public void ClearOffsetY()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0004CB68 File Offset: 0x0004AD68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParametricNoiseSettings);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0004CB88 File Offset: 0x0004AD88
		[DebuggerNonUserCode]
		public bool Equals(ParametricNoiseSettings other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Frequency, other.Frequency);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TileDistance, other.TileDistance);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Min, other.Min);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Max, other.Max);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.OffsetX, other.OffsetX);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.OffsetY, other.OffsetY);
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

		// Token: 0x06001513 RID: 5395 RVA: 0x0004CCA4 File Offset: 0x0004AEA4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFrequency = this.HasFrequency;
			if (hasFrequency)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Frequency);
			}
			bool hasTileDistance = this.HasTileDistance;
			if (hasTileDistance)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TileDistance);
			}
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
			bool hasOffsetX = this.HasOffsetX;
			if (hasOffsetX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.OffsetX);
			}
			bool hasOffsetY = this.HasOffsetY;
			if (hasOffsetY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.OffsetY);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0004CD90 File Offset: 0x0004AF90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0004CDA8 File Offset: 0x0004AFA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0004CDB4 File Offset: 0x0004AFB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFrequency = this.HasFrequency;
			if (hasFrequency)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Frequency);
			}
			bool hasTileDistance = this.HasTileDistance;
			if (hasTileDistance)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.TileDistance);
			}
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Max);
			}
			bool hasOffsetX = this.HasOffsetX;
			if (hasOffsetX)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.OffsetX);
			}
			bool hasOffsetY = this.HasOffsetY;
			if (hasOffsetY)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.OffsetY);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0004CEB0 File Offset: 0x0004B0B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFrequency = this.HasFrequency;
			if (hasFrequency)
			{
				num += 5;
			}
			bool hasTileDistance = this.HasTileDistance;
			if (hasTileDistance)
			{
				num += 5;
			}
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
			bool hasOffsetX = this.HasOffsetX;
			if (hasOffsetX)
			{
				num += 5;
			}
			bool hasOffsetY = this.HasOffsetY;
			if (hasOffsetY)
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

		// Token: 0x06001518 RID: 5400 RVA: 0x0004CF4C File Offset: 0x0004B14C
		[DebuggerNonUserCode]
		public void MergeFrom(ParametricNoiseSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFrequency = other.HasFrequency;
				if (hasFrequency)
				{
					this.Frequency = other.Frequency;
				}
				bool hasTileDistance = other.HasTileDistance;
				if (hasTileDistance)
				{
					this.TileDistance = other.TileDistance;
				}
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
				bool hasOffsetX = other.HasOffsetX;
				if (hasOffsetX)
				{
					this.OffsetX = other.OffsetX;
				}
				bool hasOffsetY = other.HasOffsetY;
				if (hasOffsetY)
				{
					this.OffsetY = other.OffsetY;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0004D01B File Offset: 0x0004B21B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0004D028 File Offset: 0x0004B228
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
					if (num3 != 13U)
					{
						if (num3 != 21U)
						{
							if (num3 != 29U)
							{
								goto IL_003A;
							}
							this.Min = input.ReadFloat();
						}
						else
						{
							this.TileDistance = input.ReadFloat();
						}
					}
					else
					{
						this.Frequency = input.ReadFloat();
					}
				}
				else if (num3 != 37U)
				{
					if (num3 != 45U)
					{
						if (num3 != 53U)
						{
							goto IL_003A;
						}
						this.OffsetY = input.ReadFloat();
					}
					else
					{
						this.OffsetX = input.ReadFloat();
					}
				}
				else
				{
					this.Max = input.ReadFloat();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000888 RID: 2184
		private static readonly MessageParser<ParametricNoiseSettings> _parser = new MessageParser<ParametricNoiseSettings>(() => new ParametricNoiseSettings());

		// Token: 0x04000889 RID: 2185
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400088A RID: 2186
		private int _hasBits0;

		// Token: 0x0400088B RID: 2187
		public const int FrequencyFieldNumber = 1;

		// Token: 0x0400088C RID: 2188
		private static readonly float FrequencyDefaultValue = 0f;

		// Token: 0x0400088D RID: 2189
		private float frequency_;

		// Token: 0x0400088E RID: 2190
		public const int TileDistanceFieldNumber = 2;

		// Token: 0x0400088F RID: 2191
		private static readonly float TileDistanceDefaultValue = 0f;

		// Token: 0x04000890 RID: 2192
		private float tileDistance_;

		// Token: 0x04000891 RID: 2193
		public const int MinFieldNumber = 3;

		// Token: 0x04000892 RID: 2194
		private static readonly float MinDefaultValue = 0f;

		// Token: 0x04000893 RID: 2195
		private float min_;

		// Token: 0x04000894 RID: 2196
		public const int MaxFieldNumber = 4;

		// Token: 0x04000895 RID: 2197
		private static readonly float MaxDefaultValue = 0f;

		// Token: 0x04000896 RID: 2198
		private float max_;

		// Token: 0x04000897 RID: 2199
		public const int OffsetXFieldNumber = 5;

		// Token: 0x04000898 RID: 2200
		private static readonly float OffsetXDefaultValue = 0f;

		// Token: 0x04000899 RID: 2201
		private float offsetX_;

		// Token: 0x0400089A RID: 2202
		public const int OffsetYFieldNumber = 6;

		// Token: 0x0400089B RID: 2203
		private static readonly float OffsetYDefaultValue = 0f;

		// Token: 0x0400089C RID: 2204
		private float offsetY_;
	}
}
