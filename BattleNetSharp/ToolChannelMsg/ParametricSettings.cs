using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000DB RID: 219
	public sealed class ParametricSettings : IMessage<ParametricSettings>, IMessage, IEquatable<ParametricSettings>, IDeepCloneable<ParametricSettings>, IBufferMessage
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x0004D8AC File Offset: 0x0004BAAC
		[DebuggerNonUserCode]
		public static MessageParser<ParametricSettings> Parser
		{
			get
			{
				return ParametricSettings._parser;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0004D8C4 File Offset: 0x0004BAC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[196];
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0004D8EC File Offset: 0x0004BAEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParametricSettings.Descriptor;
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0004D903 File Offset: 0x0004BB03
		[DebuggerNonUserCode]
		public ParametricSettings()
		{
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0004D910 File Offset: 0x0004BB10
		[DebuggerNonUserCode]
		public ParametricSettings(ParametricSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.cavitySettings_ = ((other.cavitySettings_ != null) ? other.cavitySettings_.Clone() : null);
			this.heightSettings_ = ((other.heightSettings_ != null) ? other.heightSettings_.Clone() : null);
			this.slopeSettings_ = ((other.slopeSettings_ != null) ? other.slopeSettings_.Clone() : null);
			this.directionSettings_ = ((other.directionSettings_ != null) ? other.directionSettings_.Clone() : null);
			this.noiseSettings_ = ((other.noiseSettings_ != null) ? other.noiseSettings_.Clone() : null);
			this.distanceToWaterSettings_ = ((other.distanceToWaterSettings_ != null) ? other.distanceToWaterSettings_.Clone() : null);
			this.invert_ = other.invert_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
		[DebuggerNonUserCode]
		public ParametricSettings Clone()
		{
			return new ParametricSettings(this);
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0004DA10 File Offset: 0x0004BC10
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x0004DA28 File Offset: 0x0004BC28
		[DebuggerNonUserCode]
		public ParametricCavitySettings CavitySettings
		{
			get
			{
				return this.cavitySettings_;
			}
			set
			{
				this.cavitySettings_ = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x0004DA34 File Offset: 0x0004BC34
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x0004DA4C File Offset: 0x0004BC4C
		[DebuggerNonUserCode]
		public ParametricHeightSettings HeightSettings
		{
			get
			{
				return this.heightSettings_;
			}
			set
			{
				this.heightSettings_ = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x0004DA58 File Offset: 0x0004BC58
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x0004DA70 File Offset: 0x0004BC70
		[DebuggerNonUserCode]
		public ParametricSlopeSettings SlopeSettings
		{
			get
			{
				return this.slopeSettings_;
			}
			set
			{
				this.slopeSettings_ = value;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x0004DA7C File Offset: 0x0004BC7C
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x0004DA94 File Offset: 0x0004BC94
		[DebuggerNonUserCode]
		public ParametricDirectionSettings DirectionSettings
		{
			get
			{
				return this.directionSettings_;
			}
			set
			{
				this.directionSettings_ = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x0004DAA0 File Offset: 0x0004BCA0
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x0004DAB8 File Offset: 0x0004BCB8
		[DebuggerNonUserCode]
		public ParametricNoiseSettings NoiseSettings
		{
			get
			{
				return this.noiseSettings_;
			}
			set
			{
				this.noiseSettings_ = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x0004DAC4 File Offset: 0x0004BCC4
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x0004DADC File Offset: 0x0004BCDC
		[DebuggerNonUserCode]
		public ParametricDistanceToWaterSettings DistanceToWaterSettings
		{
			get
			{
				return this.distanceToWaterSettings_;
			}
			set
			{
				this.distanceToWaterSettings_ = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x0004DAE8 File Offset: 0x0004BCE8
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0004DB19 File Offset: 0x0004BD19
		[DebuggerNonUserCode]
		public bool Invert
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool invertDefaultValue;
				if (flag)
				{
					invertDefaultValue = this.invert_;
				}
				else
				{
					invertDefaultValue = ParametricSettings.InvertDefaultValue;
				}
				return invertDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invert_ = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0004DB34 File Offset: 0x0004BD34
		[DebuggerNonUserCode]
		public bool HasInvert
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0004DB51 File Offset: 0x0004BD51
		[DebuggerNonUserCode]
		public void ClearInvert()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0004DB64 File Offset: 0x0004BD64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParametricSettings);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0004DB84 File Offset: 0x0004BD84
		[DebuggerNonUserCode]
		public bool Equals(ParametricSettings other)
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
					bool flag4 = !object.Equals(this.CavitySettings, other.CavitySettings);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.HeightSettings, other.HeightSettings);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SlopeSettings, other.SlopeSettings);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.DirectionSettings, other.DirectionSettings);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.NoiseSettings, other.NoiseSettings);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.DistanceToWaterSettings, other.DistanceToWaterSettings);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Invert != other.Invert;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0004DCA0 File Offset: 0x0004BEA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.cavitySettings_ != null;
			if (flag)
			{
				num ^= this.CavitySettings.GetHashCode();
			}
			bool flag2 = this.heightSettings_ != null;
			if (flag2)
			{
				num ^= this.HeightSettings.GetHashCode();
			}
			bool flag3 = this.slopeSettings_ != null;
			if (flag3)
			{
				num ^= this.SlopeSettings.GetHashCode();
			}
			bool flag4 = this.directionSettings_ != null;
			if (flag4)
			{
				num ^= this.DirectionSettings.GetHashCode();
			}
			bool flag5 = this.noiseSettings_ != null;
			if (flag5)
			{
				num ^= this.NoiseSettings.GetHashCode();
			}
			bool flag6 = this.distanceToWaterSettings_ != null;
			if (flag6)
			{
				num ^= this.DistanceToWaterSettings.GetHashCode();
			}
			bool hasInvert = this.HasInvert;
			if (hasInvert)
			{
				num ^= this.Invert.GetHashCode();
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0004DD9C File Offset: 0x0004BF9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0004DDB4 File Offset: 0x0004BFB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0004DDC0 File Offset: 0x0004BFC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.cavitySettings_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CavitySettings);
			}
			bool flag2 = this.heightSettings_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HeightSettings);
			}
			bool flag3 = this.slopeSettings_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SlopeSettings);
			}
			bool flag4 = this.directionSettings_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.DirectionSettings);
			}
			bool flag5 = this.noiseSettings_ != null;
			if (flag5)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NoiseSettings);
			}
			bool flag6 = this.distanceToWaterSettings_ != null;
			if (flag6)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.DistanceToWaterSettings);
			}
			bool hasInvert = this.HasInvert;
			if (hasInvert)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Invert);
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0004DEF4 File Offset: 0x0004C0F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.cavitySettings_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CavitySettings);
			}
			bool flag2 = this.heightSettings_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeightSettings);
			}
			bool flag3 = this.slopeSettings_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SlopeSettings);
			}
			bool flag4 = this.directionSettings_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DirectionSettings);
			}
			bool flag5 = this.noiseSettings_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NoiseSettings);
			}
			bool flag6 = this.distanceToWaterSettings_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DistanceToWaterSettings);
			}
			bool hasInvert = this.HasInvert;
			if (hasInvert)
			{
				num += 2;
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0004DFFC File Offset: 0x0004C1FC
		[DebuggerNonUserCode]
		public void MergeFrom(ParametricSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.cavitySettings_ != null;
				if (flag2)
				{
					bool flag3 = this.cavitySettings_ == null;
					if (flag3)
					{
						this.CavitySettings = new ParametricCavitySettings();
					}
					this.CavitySettings.MergeFrom(other.CavitySettings);
				}
				bool flag4 = other.heightSettings_ != null;
				if (flag4)
				{
					bool flag5 = this.heightSettings_ == null;
					if (flag5)
					{
						this.HeightSettings = new ParametricHeightSettings();
					}
					this.HeightSettings.MergeFrom(other.HeightSettings);
				}
				bool flag6 = other.slopeSettings_ != null;
				if (flag6)
				{
					bool flag7 = this.slopeSettings_ == null;
					if (flag7)
					{
						this.SlopeSettings = new ParametricSlopeSettings();
					}
					this.SlopeSettings.MergeFrom(other.SlopeSettings);
				}
				bool flag8 = other.directionSettings_ != null;
				if (flag8)
				{
					bool flag9 = this.directionSettings_ == null;
					if (flag9)
					{
						this.DirectionSettings = new ParametricDirectionSettings();
					}
					this.DirectionSettings.MergeFrom(other.DirectionSettings);
				}
				bool flag10 = other.noiseSettings_ != null;
				if (flag10)
				{
					bool flag11 = this.noiseSettings_ == null;
					if (flag11)
					{
						this.NoiseSettings = new ParametricNoiseSettings();
					}
					this.NoiseSettings.MergeFrom(other.NoiseSettings);
				}
				bool flag12 = other.distanceToWaterSettings_ != null;
				if (flag12)
				{
					bool flag13 = this.distanceToWaterSettings_ == null;
					if (flag13)
					{
						this.DistanceToWaterSettings = new ParametricDistanceToWaterSettings();
					}
					this.DistanceToWaterSettings.MergeFrom(other.DistanceToWaterSettings);
				}
				bool hasInvert = other.HasInvert;
				if (hasInvert)
				{
					this.Invert = other.Invert;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0004E1C4 File Offset: 0x0004C3C4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0004E1D0 File Offset: 0x0004C3D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0055;
							}
							bool flag = this.slopeSettings_ == null;
							if (flag)
							{
								this.SlopeSettings = new ParametricSlopeSettings();
							}
							input.ReadMessage(this.SlopeSettings);
						}
						else
						{
							bool flag2 = this.heightSettings_ == null;
							if (flag2)
							{
								this.HeightSettings = new ParametricHeightSettings();
							}
							input.ReadMessage(this.HeightSettings);
						}
					}
					else
					{
						bool flag3 = this.cavitySettings_ == null;
						if (flag3)
						{
							this.CavitySettings = new ParametricCavitySettings();
						}
						input.ReadMessage(this.CavitySettings);
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0055;
						}
						bool flag4 = this.noiseSettings_ == null;
						if (flag4)
						{
							this.NoiseSettings = new ParametricNoiseSettings();
						}
						input.ReadMessage(this.NoiseSettings);
					}
					else
					{
						bool flag5 = this.directionSettings_ == null;
						if (flag5)
						{
							this.DirectionSettings = new ParametricDirectionSettings();
						}
						input.ReadMessage(this.DirectionSettings);
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 56U)
					{
						goto IL_0055;
					}
					this.Invert = input.ReadBool();
				}
				else
				{
					bool flag6 = this.distanceToWaterSettings_ == null;
					if (flag6)
					{
						this.DistanceToWaterSettings = new ParametricDistanceToWaterSettings();
					}
					input.ReadMessage(this.DistanceToWaterSettings);
				}
				continue;
				IL_0055:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040008AC RID: 2220
		private static readonly MessageParser<ParametricSettings> _parser = new MessageParser<ParametricSettings>(() => new ParametricSettings());

		// Token: 0x040008AD RID: 2221
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008AE RID: 2222
		private int _hasBits0;

		// Token: 0x040008AF RID: 2223
		public const int CavitySettingsFieldNumber = 1;

		// Token: 0x040008B0 RID: 2224
		private ParametricCavitySettings cavitySettings_;

		// Token: 0x040008B1 RID: 2225
		public const int HeightSettingsFieldNumber = 2;

		// Token: 0x040008B2 RID: 2226
		private ParametricHeightSettings heightSettings_;

		// Token: 0x040008B3 RID: 2227
		public const int SlopeSettingsFieldNumber = 3;

		// Token: 0x040008B4 RID: 2228
		private ParametricSlopeSettings slopeSettings_;

		// Token: 0x040008B5 RID: 2229
		public const int DirectionSettingsFieldNumber = 4;

		// Token: 0x040008B6 RID: 2230
		private ParametricDirectionSettings directionSettings_;

		// Token: 0x040008B7 RID: 2231
		public const int NoiseSettingsFieldNumber = 5;

		// Token: 0x040008B8 RID: 2232
		private ParametricNoiseSettings noiseSettings_;

		// Token: 0x040008B9 RID: 2233
		public const int DistanceToWaterSettingsFieldNumber = 6;

		// Token: 0x040008BA RID: 2234
		private ParametricDistanceToWaterSettings distanceToWaterSettings_;

		// Token: 0x040008BB RID: 2235
		public const int InvertFieldNumber = 7;

		// Token: 0x040008BC RID: 2236
		private static readonly bool InvertDefaultValue = false;

		// Token: 0x040008BD RID: 2237
		private bool invert_;
	}
}
