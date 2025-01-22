using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000339 RID: 825
	public sealed class AutoMapSettings : IMessage<AutoMapSettings>, IMessage, IEquatable<AutoMapSettings>, IDeepCloneable<AutoMapSettings>, IBufferMessage
	{
		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06005605 RID: 22021 RVA: 0x0014CB40 File Offset: 0x0014AD40
		[DebuggerNonUserCode]
		public static MessageParser<AutoMapSettings> Parser
		{
			get
			{
				return AutoMapSettings._parser;
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06005606 RID: 22022 RVA: 0x0014CB58 File Offset: 0x0014AD58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameAutomapReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06005607 RID: 22023 RVA: 0x0014CB7C File Offset: 0x0014AD7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AutoMapSettings.Descriptor;
			}
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x0014CB93 File Offset: 0x0014AD93
		[DebuggerNonUserCode]
		public AutoMapSettings()
		{
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x0014CBA0 File Offset: 0x0014ADA0
		[DebuggerNonUserCode]
		public AutoMapSettings(AutoMapSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.automapSize_ = other.automapSize_;
			this.miniMapLocation_ = other.miniMapLocation_;
			this.opacityFadeMode_ = other.opacityFadeMode_;
			this.customOpacity_ = other.customOpacity_;
			this.centerWhenCleared_ = other.centerWhenCleared_;
			this.showParty_ = other.showParty_;
			this.showNames_ = other.showNames_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x0014CC28 File Offset: 0x0014AE28
		[DebuggerNonUserCode]
		public AutoMapSettings Clone()
		{
			return new AutoMapSettings(this);
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x0600560B RID: 22027 RVA: 0x0014CC40 File Offset: 0x0014AE40
		// (set) Token: 0x0600560C RID: 22028 RVA: 0x0014CC71 File Offset: 0x0014AE71
		[DebuggerNonUserCode]
		public uint AutomapSize
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint automapSizeDefaultValue;
				if (flag)
				{
					automapSizeDefaultValue = this.automapSize_;
				}
				else
				{
					automapSizeDefaultValue = AutoMapSettings.AutomapSizeDefaultValue;
				}
				return automapSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.automapSize_ = value;
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x0600560D RID: 22029 RVA: 0x0014CC8C File Offset: 0x0014AE8C
		[DebuggerNonUserCode]
		public bool HasAutomapSize
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x0014CCA9 File Offset: 0x0014AEA9
		[DebuggerNonUserCode]
		public void ClearAutomapSize()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x0014CCBC File Offset: 0x0014AEBC
		// (set) Token: 0x06005610 RID: 22032 RVA: 0x0014CCED File Offset: 0x0014AEED
		[DebuggerNonUserCode]
		public uint MiniMapLocation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint miniMapLocationDefaultValue;
				if (flag)
				{
					miniMapLocationDefaultValue = this.miniMapLocation_;
				}
				else
				{
					miniMapLocationDefaultValue = AutoMapSettings.MiniMapLocationDefaultValue;
				}
				return miniMapLocationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.miniMapLocation_ = value;
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06005611 RID: 22033 RVA: 0x0014CD08 File Offset: 0x0014AF08
		[DebuggerNonUserCode]
		public bool HasMiniMapLocation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x0014CD25 File Offset: 0x0014AF25
		[DebuggerNonUserCode]
		public void ClearMiniMapLocation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06005613 RID: 22035 RVA: 0x0014CD38 File Offset: 0x0014AF38
		// (set) Token: 0x06005614 RID: 22036 RVA: 0x0014CD69 File Offset: 0x0014AF69
		[DebuggerNonUserCode]
		public uint OpacityFadeMode
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint opacityFadeModeDefaultValue;
				if (flag)
				{
					opacityFadeModeDefaultValue = this.opacityFadeMode_;
				}
				else
				{
					opacityFadeModeDefaultValue = AutoMapSettings.OpacityFadeModeDefaultValue;
				}
				return opacityFadeModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.opacityFadeMode_ = value;
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x0014CD84 File Offset: 0x0014AF84
		[DebuggerNonUserCode]
		public bool HasOpacityFadeMode
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x0014CDA1 File Offset: 0x0014AFA1
		[DebuggerNonUserCode]
		public void ClearOpacityFadeMode()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x0014CDB4 File Offset: 0x0014AFB4
		// (set) Token: 0x06005618 RID: 22040 RVA: 0x0014CDE5 File Offset: 0x0014AFE5
		[DebuggerNonUserCode]
		public int CustomOpacity
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int customOpacityDefaultValue;
				if (flag)
				{
					customOpacityDefaultValue = this.customOpacity_;
				}
				else
				{
					customOpacityDefaultValue = AutoMapSettings.CustomOpacityDefaultValue;
				}
				return customOpacityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.customOpacity_ = value;
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06005619 RID: 22041 RVA: 0x0014CE00 File Offset: 0x0014B000
		[DebuggerNonUserCode]
		public bool HasCustomOpacity
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x0014CE1D File Offset: 0x0014B01D
		[DebuggerNonUserCode]
		public void ClearCustomOpacity()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x0014CE30 File Offset: 0x0014B030
		// (set) Token: 0x0600561C RID: 22044 RVA: 0x0014CE62 File Offset: 0x0014B062
		[DebuggerNonUserCode]
		public bool CenterWhenCleared
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool centerWhenClearedDefaultValue;
				if (flag)
				{
					centerWhenClearedDefaultValue = this.centerWhenCleared_;
				}
				else
				{
					centerWhenClearedDefaultValue = AutoMapSettings.CenterWhenClearedDefaultValue;
				}
				return centerWhenClearedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.centerWhenCleared_ = value;
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x0600561D RID: 22045 RVA: 0x0014CE7C File Offset: 0x0014B07C
		[DebuggerNonUserCode]
		public bool HasCenterWhenCleared
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x0014CE9A File Offset: 0x0014B09A
		[DebuggerNonUserCode]
		public void ClearCenterWhenCleared()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x0600561F RID: 22047 RVA: 0x0014CEAC File Offset: 0x0014B0AC
		// (set) Token: 0x06005620 RID: 22048 RVA: 0x0014CEDE File Offset: 0x0014B0DE
		[DebuggerNonUserCode]
		public bool ShowParty
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool showPartyDefaultValue;
				if (flag)
				{
					showPartyDefaultValue = this.showParty_;
				}
				else
				{
					showPartyDefaultValue = AutoMapSettings.ShowPartyDefaultValue;
				}
				return showPartyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.showParty_ = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x0014CEF8 File Offset: 0x0014B0F8
		[DebuggerNonUserCode]
		public bool HasShowParty
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x0014CF16 File Offset: 0x0014B116
		[DebuggerNonUserCode]
		public void ClearShowParty()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06005623 RID: 22051 RVA: 0x0014CF28 File Offset: 0x0014B128
		// (set) Token: 0x06005624 RID: 22052 RVA: 0x0014CF5A File Offset: 0x0014B15A
		[DebuggerNonUserCode]
		public bool ShowNames
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool showNamesDefaultValue;
				if (flag)
				{
					showNamesDefaultValue = this.showNames_;
				}
				else
				{
					showNamesDefaultValue = AutoMapSettings.ShowNamesDefaultValue;
				}
				return showNamesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.showNames_ = value;
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06005625 RID: 22053 RVA: 0x0014CF74 File Offset: 0x0014B174
		[DebuggerNonUserCode]
		public bool HasShowNames
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x0014CF92 File Offset: 0x0014B192
		[DebuggerNonUserCode]
		public void ClearShowNames()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x0014CFA4 File Offset: 0x0014B1A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AutoMapSettings);
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x0014CFC4 File Offset: 0x0014B1C4
		[DebuggerNonUserCode]
		public bool Equals(AutoMapSettings other)
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
					bool flag4 = this.AutomapSize != other.AutomapSize;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MiniMapLocation != other.MiniMapLocation;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.OpacityFadeMode != other.OpacityFadeMode;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CustomOpacity != other.CustomOpacity;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CenterWhenCleared != other.CenterWhenCleared;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ShowParty != other.ShowParty;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ShowNames != other.ShowNames;
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

		// Token: 0x06005629 RID: 22057 RVA: 0x0014D0CC File Offset: 0x0014B2CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAutomapSize = this.HasAutomapSize;
			if (hasAutomapSize)
			{
				num ^= this.AutomapSize.GetHashCode();
			}
			bool hasMiniMapLocation = this.HasMiniMapLocation;
			if (hasMiniMapLocation)
			{
				num ^= this.MiniMapLocation.GetHashCode();
			}
			bool hasOpacityFadeMode = this.HasOpacityFadeMode;
			if (hasOpacityFadeMode)
			{
				num ^= this.OpacityFadeMode.GetHashCode();
			}
			bool hasCustomOpacity = this.HasCustomOpacity;
			if (hasCustomOpacity)
			{
				num ^= this.CustomOpacity.GetHashCode();
			}
			bool hasCenterWhenCleared = this.HasCenterWhenCleared;
			if (hasCenterWhenCleared)
			{
				num ^= this.CenterWhenCleared.GetHashCode();
			}
			bool hasShowParty = this.HasShowParty;
			if (hasShowParty)
			{
				num ^= this.ShowParty.GetHashCode();
			}
			bool hasShowNames = this.HasShowNames;
			if (hasShowNames)
			{
				num ^= this.ShowNames.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x0014D1D0 File Offset: 0x0014B3D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x0014D1E8 File Offset: 0x0014B3E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x0014D1F4 File Offset: 0x0014B3F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAutomapSize = this.HasAutomapSize;
			if (hasAutomapSize)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AutomapSize);
			}
			bool hasMiniMapLocation = this.HasMiniMapLocation;
			if (hasMiniMapLocation)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MiniMapLocation);
			}
			bool hasOpacityFadeMode = this.HasOpacityFadeMode;
			if (hasOpacityFadeMode)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OpacityFadeMode);
			}
			bool hasCustomOpacity = this.HasCustomOpacity;
			if (hasCustomOpacity)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CustomOpacity);
			}
			bool hasCenterWhenCleared = this.HasCenterWhenCleared;
			if (hasCenterWhenCleared)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.CenterWhenCleared);
			}
			bool hasShowParty = this.HasShowParty;
			if (hasShowParty)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ShowParty);
			}
			bool hasShowNames = this.HasShowNames;
			if (hasShowNames)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ShowNames);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x0014D314 File Offset: 0x0014B514
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAutomapSize = this.HasAutomapSize;
			if (hasAutomapSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AutomapSize);
			}
			bool hasMiniMapLocation = this.HasMiniMapLocation;
			if (hasMiniMapLocation)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiniMapLocation);
			}
			bool hasOpacityFadeMode = this.HasOpacityFadeMode;
			if (hasOpacityFadeMode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OpacityFadeMode);
			}
			bool hasCustomOpacity = this.HasCustomOpacity;
			if (hasCustomOpacity)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CustomOpacity);
			}
			bool hasCenterWhenCleared = this.HasCenterWhenCleared;
			if (hasCenterWhenCleared)
			{
				num += 2;
			}
			bool hasShowParty = this.HasShowParty;
			if (hasShowParty)
			{
				num += 2;
			}
			bool hasShowNames = this.HasShowNames;
			if (hasShowNames)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x0014D3F4 File Offset: 0x0014B5F4
		[DebuggerNonUserCode]
		public void MergeFrom(AutoMapSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAutomapSize = other.HasAutomapSize;
				if (hasAutomapSize)
				{
					this.AutomapSize = other.AutomapSize;
				}
				bool hasMiniMapLocation = other.HasMiniMapLocation;
				if (hasMiniMapLocation)
				{
					this.MiniMapLocation = other.MiniMapLocation;
				}
				bool hasOpacityFadeMode = other.HasOpacityFadeMode;
				if (hasOpacityFadeMode)
				{
					this.OpacityFadeMode = other.OpacityFadeMode;
				}
				bool hasCustomOpacity = other.HasCustomOpacity;
				if (hasCustomOpacity)
				{
					this.CustomOpacity = other.CustomOpacity;
				}
				bool hasCenterWhenCleared = other.HasCenterWhenCleared;
				if (hasCenterWhenCleared)
				{
					this.CenterWhenCleared = other.CenterWhenCleared;
				}
				bool hasShowParty = other.HasShowParty;
				if (hasShowParty)
				{
					this.ShowParty = other.ShowParty;
				}
				bool hasShowNames = other.HasShowNames;
				if (hasShowNames)
				{
					this.ShowNames = other.ShowNames;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x0014D4DE File Offset: 0x0014B6DE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x0014D4EC File Offset: 0x0014B6EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0045;
							}
							this.OpacityFadeMode = input.ReadUInt32();
						}
						else
						{
							this.MiniMapLocation = input.ReadUInt32();
						}
					}
					else
					{
						this.AutomapSize = input.ReadUInt32();
					}
				}
				else if (num3 <= 40U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0045;
						}
						this.CenterWhenCleared = input.ReadBool();
					}
					else
					{
						this.CustomOpacity = input.ReadInt32();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_0045;
					}
					this.ShowNames = input.ReadBool();
				}
				else
				{
					this.ShowParty = input.ReadBool();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400272C RID: 10028
		private static readonly MessageParser<AutoMapSettings> _parser = new MessageParser<AutoMapSettings>(() => new AutoMapSettings());

		// Token: 0x0400272D RID: 10029
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400272E RID: 10030
		private int _hasBits0;

		// Token: 0x0400272F RID: 10031
		public const int AutomapSizeFieldNumber = 1;

		// Token: 0x04002730 RID: 10032
		private static readonly uint AutomapSizeDefaultValue = 0U;

		// Token: 0x04002731 RID: 10033
		private uint automapSize_;

		// Token: 0x04002732 RID: 10034
		public const int MiniMapLocationFieldNumber = 2;

		// Token: 0x04002733 RID: 10035
		private static readonly uint MiniMapLocationDefaultValue = 0U;

		// Token: 0x04002734 RID: 10036
		private uint miniMapLocation_;

		// Token: 0x04002735 RID: 10037
		public const int OpacityFadeModeFieldNumber = 3;

		// Token: 0x04002736 RID: 10038
		private static readonly uint OpacityFadeModeDefaultValue = 0U;

		// Token: 0x04002737 RID: 10039
		private uint opacityFadeMode_;

		// Token: 0x04002738 RID: 10040
		public const int CustomOpacityFieldNumber = 4;

		// Token: 0x04002739 RID: 10041
		private static readonly int CustomOpacityDefaultValue = 0;

		// Token: 0x0400273A RID: 10042
		private int customOpacity_;

		// Token: 0x0400273B RID: 10043
		public const int CenterWhenClearedFieldNumber = 5;

		// Token: 0x0400273C RID: 10044
		private static readonly bool CenterWhenClearedDefaultValue = false;

		// Token: 0x0400273D RID: 10045
		private bool centerWhenCleared_;

		// Token: 0x0400273E RID: 10046
		public const int ShowPartyFieldNumber = 6;

		// Token: 0x0400273F RID: 10047
		private static readonly bool ShowPartyDefaultValue = false;

		// Token: 0x04002740 RID: 10048
		private bool showParty_;

		// Token: 0x04002741 RID: 10049
		public const int ShowNamesFieldNumber = 7;

		// Token: 0x04002742 RID: 10050
		private static readonly bool ShowNamesDefaultValue = false;

		// Token: 0x04002743 RID: 10051
		private bool showNames_;
	}
}
