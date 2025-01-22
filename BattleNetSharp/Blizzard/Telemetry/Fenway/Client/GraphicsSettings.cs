using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200033F RID: 831
	public sealed class GraphicsSettings : IMessage<GraphicsSettings>, IMessage, IEquatable<GraphicsSettings>, IDeepCloneable<GraphicsSettings>, IBufferMessage
	{
		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x0600566E RID: 22126 RVA: 0x0014E3C8 File Offset: 0x0014C5C8
		[DebuggerNonUserCode]
		public static MessageParser<GraphicsSettings> Parser
		{
			get
			{
				return GraphicsSettings._parser;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x0600566F RID: 22127 RVA: 0x0014E3E0 File Offset: 0x0014C5E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameGraphicsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06005670 RID: 22128 RVA: 0x0014E404 File Offset: 0x0014C604
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GraphicsSettings.Descriptor;
			}
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x0014E41B File Offset: 0x0014C61B
		[DebuggerNonUserCode]
		public GraphicsSettings()
		{
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x0014E428 File Offset: 0x0014C628
		[DebuggerNonUserCode]
		public GraphicsSettings(GraphicsSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.screenResolutionWidth_ = other.screenResolutionWidth_;
			this.screenResolutionHeight_ = other.screenResolutionHeight_;
			this.gameResolutionWidth_ = other.gameResolutionWidth_;
			this.gameResolutionHeight_ = other.gameResolutionHeight_;
			this.lightingQuality_ = other.lightingQuality_;
			this.legacyBlendedShadows_ = other.legacyBlendedShadows_;
			this.legacyPerspective_ = other.legacyPerspective_;
			this.sdGamma_ = other.sdGamma_;
			this.hdGamma_ = other.hdGamma_;
			this.contrast_ = other.contrast_;
			this.vsyncEnabled_ = other.vsyncEnabled_;
			this.framerateCapMode_ = other.framerateCapMode_;
			this.windowMode_ = other.windowMode_;
			this.textureQuality_ = other.textureQuality_;
			this.textureAnisotropy_ = other.textureAnisotropy_;
			this.ambientOcclusionQuality_ = other.ambientOcclusionQuality_;
			this.characterDetailQuality_ = other.characterDetailQuality_;
			this.environmentDetailQuality_ = other.environmentDetailQuality_;
			this.atmosphericsQuality_ = other.atmosphericsQuality_;
			this.transparencyQuality_ = other.transparencyQuality_;
			this.shadowQuality_ = other.shadowQuality_;
			this.antiAliasingMode_ = other.antiAliasingMode_;
			this.hdrCalibration_ = other.hdrCalibration_;
			this.dynamicResolutionScaling_ = other.dynamicResolutionScaling_;
			this.frameRateTarget_ = other.frameRateTarget_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x0014E588 File Offset: 0x0014C788
		[DebuggerNonUserCode]
		public GraphicsSettings Clone()
		{
			return new GraphicsSettings(this);
		}

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06005674 RID: 22132 RVA: 0x0014E5A0 File Offset: 0x0014C7A0
		// (set) Token: 0x06005675 RID: 22133 RVA: 0x0014E5D1 File Offset: 0x0014C7D1
		[DebuggerNonUserCode]
		public uint ScreenResolutionWidth
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint screenResolutionWidthDefaultValue;
				if (flag)
				{
					screenResolutionWidthDefaultValue = this.screenResolutionWidth_;
				}
				else
				{
					screenResolutionWidthDefaultValue = GraphicsSettings.ScreenResolutionWidthDefaultValue;
				}
				return screenResolutionWidthDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.screenResolutionWidth_ = value;
			}
		}

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x0014E5EC File Offset: 0x0014C7EC
		[DebuggerNonUserCode]
		public bool HasScreenResolutionWidth
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x0014E609 File Offset: 0x0014C809
		[DebuggerNonUserCode]
		public void ClearScreenResolutionWidth()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x0014E61C File Offset: 0x0014C81C
		// (set) Token: 0x06005679 RID: 22137 RVA: 0x0014E64D File Offset: 0x0014C84D
		[DebuggerNonUserCode]
		public uint ScreenResolutionHeight
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint screenResolutionHeightDefaultValue;
				if (flag)
				{
					screenResolutionHeightDefaultValue = this.screenResolutionHeight_;
				}
				else
				{
					screenResolutionHeightDefaultValue = GraphicsSettings.ScreenResolutionHeightDefaultValue;
				}
				return screenResolutionHeightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.screenResolutionHeight_ = value;
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x0014E668 File Offset: 0x0014C868
		[DebuggerNonUserCode]
		public bool HasScreenResolutionHeight
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x0014E685 File Offset: 0x0014C885
		[DebuggerNonUserCode]
		public void ClearScreenResolutionHeight()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x0600567C RID: 22140 RVA: 0x0014E698 File Offset: 0x0014C898
		// (set) Token: 0x0600567D RID: 22141 RVA: 0x0014E6C9 File Offset: 0x0014C8C9
		[DebuggerNonUserCode]
		public uint GameResolutionWidth
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint gameResolutionWidthDefaultValue;
				if (flag)
				{
					gameResolutionWidthDefaultValue = this.gameResolutionWidth_;
				}
				else
				{
					gameResolutionWidthDefaultValue = GraphicsSettings.GameResolutionWidthDefaultValue;
				}
				return gameResolutionWidthDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gameResolutionWidth_ = value;
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x0600567E RID: 22142 RVA: 0x0014E6E4 File Offset: 0x0014C8E4
		[DebuggerNonUserCode]
		public bool HasGameResolutionWidth
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x0014E701 File Offset: 0x0014C901
		[DebuggerNonUserCode]
		public void ClearGameResolutionWidth()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06005680 RID: 22144 RVA: 0x0014E714 File Offset: 0x0014C914
		// (set) Token: 0x06005681 RID: 22145 RVA: 0x0014E745 File Offset: 0x0014C945
		[DebuggerNonUserCode]
		public uint GameResolutionHeight
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint gameResolutionHeightDefaultValue;
				if (flag)
				{
					gameResolutionHeightDefaultValue = this.gameResolutionHeight_;
				}
				else
				{
					gameResolutionHeightDefaultValue = GraphicsSettings.GameResolutionHeightDefaultValue;
				}
				return gameResolutionHeightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.gameResolutionHeight_ = value;
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x0014E760 File Offset: 0x0014C960
		[DebuggerNonUserCode]
		public bool HasGameResolutionHeight
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x0014E77D File Offset: 0x0014C97D
		[DebuggerNonUserCode]
		public void ClearGameResolutionHeight()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x0014E790 File Offset: 0x0014C990
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x0014E7C2 File Offset: 0x0014C9C2
		[DebuggerNonUserCode]
		public uint LightingQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint lightingQualityDefaultValue;
				if (flag)
				{
					lightingQualityDefaultValue = this.lightingQuality_;
				}
				else
				{
					lightingQualityDefaultValue = GraphicsSettings.LightingQualityDefaultValue;
				}
				return lightingQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.lightingQuality_ = value;
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x0014E7DC File Offset: 0x0014C9DC
		[DebuggerNonUserCode]
		public bool HasLightingQuality
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x0014E7FA File Offset: 0x0014C9FA
		[DebuggerNonUserCode]
		public void ClearLightingQuality()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x0014E80C File Offset: 0x0014CA0C
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x0014E83E File Offset: 0x0014CA3E
		[DebuggerNonUserCode]
		public bool LegacyBlendedShadows
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool legacyBlendedShadowsDefaultValue;
				if (flag)
				{
					legacyBlendedShadowsDefaultValue = this.legacyBlendedShadows_;
				}
				else
				{
					legacyBlendedShadowsDefaultValue = GraphicsSettings.LegacyBlendedShadowsDefaultValue;
				}
				return legacyBlendedShadowsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.legacyBlendedShadows_ = value;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x0014E858 File Offset: 0x0014CA58
		[DebuggerNonUserCode]
		public bool HasLegacyBlendedShadows
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x0014E876 File Offset: 0x0014CA76
		[DebuggerNonUserCode]
		public void ClearLegacyBlendedShadows()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x0014E888 File Offset: 0x0014CA88
		// (set) Token: 0x0600568D RID: 22157 RVA: 0x0014E8BA File Offset: 0x0014CABA
		[DebuggerNonUserCode]
		public bool LegacyPerspective
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool legacyPerspectiveDefaultValue;
				if (flag)
				{
					legacyPerspectiveDefaultValue = this.legacyPerspective_;
				}
				else
				{
					legacyPerspectiveDefaultValue = GraphicsSettings.LegacyPerspectiveDefaultValue;
				}
				return legacyPerspectiveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.legacyPerspective_ = value;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x0014E8D4 File Offset: 0x0014CAD4
		[DebuggerNonUserCode]
		public bool HasLegacyPerspective
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x0014E8F2 File Offset: 0x0014CAF2
		[DebuggerNonUserCode]
		public void ClearLegacyPerspective()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06005690 RID: 22160 RVA: 0x0014E904 File Offset: 0x0014CB04
		// (set) Token: 0x06005691 RID: 22161 RVA: 0x0014E939 File Offset: 0x0014CB39
		[DebuggerNonUserCode]
		public int SdGamma
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int sdGammaDefaultValue;
				if (flag)
				{
					sdGammaDefaultValue = this.sdGamma_;
				}
				else
				{
					sdGammaDefaultValue = GraphicsSettings.SdGammaDefaultValue;
				}
				return sdGammaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.sdGamma_ = value;
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x0014E958 File Offset: 0x0014CB58
		[DebuggerNonUserCode]
		public bool HasSdGamma
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x0014E979 File Offset: 0x0014CB79
		[DebuggerNonUserCode]
		public void ClearSdGamma()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x0014E990 File Offset: 0x0014CB90
		// (set) Token: 0x06005695 RID: 22165 RVA: 0x0014E9C5 File Offset: 0x0014CBC5
		[DebuggerNonUserCode]
		public int HdGamma
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int hdGammaDefaultValue;
				if (flag)
				{
					hdGammaDefaultValue = this.hdGamma_;
				}
				else
				{
					hdGammaDefaultValue = GraphicsSettings.HdGammaDefaultValue;
				}
				return hdGammaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.hdGamma_ = value;
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x0014E9E4 File Offset: 0x0014CBE4
		[DebuggerNonUserCode]
		public bool HasHdGamma
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x0014EA05 File Offset: 0x0014CC05
		[DebuggerNonUserCode]
		public void ClearHdGamma()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06005698 RID: 22168 RVA: 0x0014EA1C File Offset: 0x0014CC1C
		// (set) Token: 0x06005699 RID: 22169 RVA: 0x0014EA51 File Offset: 0x0014CC51
		[DebuggerNonUserCode]
		public int Contrast
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int contrastDefaultValue;
				if (flag)
				{
					contrastDefaultValue = this.contrast_;
				}
				else
				{
					contrastDefaultValue = GraphicsSettings.ContrastDefaultValue;
				}
				return contrastDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.contrast_ = value;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x0600569A RID: 22170 RVA: 0x0014EA70 File Offset: 0x0014CC70
		[DebuggerNonUserCode]
		public bool HasContrast
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x0014EA91 File Offset: 0x0014CC91
		[DebuggerNonUserCode]
		public void ClearContrast()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x0600569C RID: 22172 RVA: 0x0014EAA8 File Offset: 0x0014CCA8
		// (set) Token: 0x0600569D RID: 22173 RVA: 0x0014EADD File Offset: 0x0014CCDD
		[DebuggerNonUserCode]
		public bool VsyncEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				bool vsyncEnabledDefaultValue;
				if (flag)
				{
					vsyncEnabledDefaultValue = this.vsyncEnabled_;
				}
				else
				{
					vsyncEnabledDefaultValue = GraphicsSettings.VsyncEnabledDefaultValue;
				}
				return vsyncEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.vsyncEnabled_ = value;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x0600569E RID: 22174 RVA: 0x0014EAFC File Offset: 0x0014CCFC
		[DebuggerNonUserCode]
		public bool HasVsyncEnabled
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x0014EB1D File Offset: 0x0014CD1D
		[DebuggerNonUserCode]
		public void ClearVsyncEnabled()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x060056A0 RID: 22176 RVA: 0x0014EB34 File Offset: 0x0014CD34
		// (set) Token: 0x060056A1 RID: 22177 RVA: 0x0014EB69 File Offset: 0x0014CD69
		[DebuggerNonUserCode]
		public uint FramerateCapMode
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				uint framerateCapModeDefaultValue;
				if (flag)
				{
					framerateCapModeDefaultValue = this.framerateCapMode_;
				}
				else
				{
					framerateCapModeDefaultValue = GraphicsSettings.FramerateCapModeDefaultValue;
				}
				return framerateCapModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.framerateCapMode_ = value;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x060056A2 RID: 22178 RVA: 0x0014EB88 File Offset: 0x0014CD88
		[DebuggerNonUserCode]
		public bool HasFramerateCapMode
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x0014EBA9 File Offset: 0x0014CDA9
		[DebuggerNonUserCode]
		public void ClearFramerateCapMode()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x060056A4 RID: 22180 RVA: 0x0014EBC0 File Offset: 0x0014CDC0
		// (set) Token: 0x060056A5 RID: 22181 RVA: 0x0014EBF5 File Offset: 0x0014CDF5
		[DebuggerNonUserCode]
		public uint WindowMode
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				uint windowModeDefaultValue;
				if (flag)
				{
					windowModeDefaultValue = this.windowMode_;
				}
				else
				{
					windowModeDefaultValue = GraphicsSettings.WindowModeDefaultValue;
				}
				return windowModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.windowMode_ = value;
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x060056A6 RID: 22182 RVA: 0x0014EC14 File Offset: 0x0014CE14
		[DebuggerNonUserCode]
		public bool HasWindowMode
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x0014EC35 File Offset: 0x0014CE35
		[DebuggerNonUserCode]
		public void ClearWindowMode()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x0014EC4C File Offset: 0x0014CE4C
		// (set) Token: 0x060056A9 RID: 22185 RVA: 0x0014EC81 File Offset: 0x0014CE81
		[DebuggerNonUserCode]
		public uint TextureQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				uint textureQualityDefaultValue;
				if (flag)
				{
					textureQualityDefaultValue = this.textureQuality_;
				}
				else
				{
					textureQualityDefaultValue = GraphicsSettings.TextureQualityDefaultValue;
				}
				return textureQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.textureQuality_ = value;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x060056AA RID: 22186 RVA: 0x0014ECA0 File Offset: 0x0014CEA0
		[DebuggerNonUserCode]
		public bool HasTextureQuality
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x0014ECC1 File Offset: 0x0014CEC1
		[DebuggerNonUserCode]
		public void ClearTextureQuality()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x060056AC RID: 22188 RVA: 0x0014ECD8 File Offset: 0x0014CED8
		// (set) Token: 0x060056AD RID: 22189 RVA: 0x0014ED0D File Offset: 0x0014CF0D
		[DebuggerNonUserCode]
		public uint TextureAnisotropy
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				uint textureAnisotropyDefaultValue;
				if (flag)
				{
					textureAnisotropyDefaultValue = this.textureAnisotropy_;
				}
				else
				{
					textureAnisotropyDefaultValue = GraphicsSettings.TextureAnisotropyDefaultValue;
				}
				return textureAnisotropyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.textureAnisotropy_ = value;
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x060056AE RID: 22190 RVA: 0x0014ED2C File Offset: 0x0014CF2C
		[DebuggerNonUserCode]
		public bool HasTextureAnisotropy
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0014ED4D File Offset: 0x0014CF4D
		[DebuggerNonUserCode]
		public void ClearTextureAnisotropy()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x060056B0 RID: 22192 RVA: 0x0014ED64 File Offset: 0x0014CF64
		// (set) Token: 0x060056B1 RID: 22193 RVA: 0x0014ED99 File Offset: 0x0014CF99
		[DebuggerNonUserCode]
		public uint AmbientOcclusionQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				uint ambientOcclusionQualityDefaultValue;
				if (flag)
				{
					ambientOcclusionQualityDefaultValue = this.ambientOcclusionQuality_;
				}
				else
				{
					ambientOcclusionQualityDefaultValue = GraphicsSettings.AmbientOcclusionQualityDefaultValue;
				}
				return ambientOcclusionQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.ambientOcclusionQuality_ = value;
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x060056B2 RID: 22194 RVA: 0x0014EDB8 File Offset: 0x0014CFB8
		[DebuggerNonUserCode]
		public bool HasAmbientOcclusionQuality
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x0014EDD9 File Offset: 0x0014CFD9
		[DebuggerNonUserCode]
		public void ClearAmbientOcclusionQuality()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x060056B4 RID: 22196 RVA: 0x0014EDF0 File Offset: 0x0014CFF0
		// (set) Token: 0x060056B5 RID: 22197 RVA: 0x0014EE25 File Offset: 0x0014D025
		[DebuggerNonUserCode]
		public uint CharacterDetailQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				uint characterDetailQualityDefaultValue;
				if (flag)
				{
					characterDetailQualityDefaultValue = this.characterDetailQuality_;
				}
				else
				{
					characterDetailQualityDefaultValue = GraphicsSettings.CharacterDetailQualityDefaultValue;
				}
				return characterDetailQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.characterDetailQuality_ = value;
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x060056B6 RID: 22198 RVA: 0x0014EE44 File Offset: 0x0014D044
		[DebuggerNonUserCode]
		public bool HasCharacterDetailQuality
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x0014EE65 File Offset: 0x0014D065
		[DebuggerNonUserCode]
		public void ClearCharacterDetailQuality()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x060056B8 RID: 22200 RVA: 0x0014EE7C File Offset: 0x0014D07C
		// (set) Token: 0x060056B9 RID: 22201 RVA: 0x0014EEB1 File Offset: 0x0014D0B1
		[DebuggerNonUserCode]
		public uint EnvironmentDetailQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				uint environmentDetailQualityDefaultValue;
				if (flag)
				{
					environmentDetailQualityDefaultValue = this.environmentDetailQuality_;
				}
				else
				{
					environmentDetailQualityDefaultValue = GraphicsSettings.EnvironmentDetailQualityDefaultValue;
				}
				return environmentDetailQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.environmentDetailQuality_ = value;
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x060056BA RID: 22202 RVA: 0x0014EED0 File Offset: 0x0014D0D0
		[DebuggerNonUserCode]
		public bool HasEnvironmentDetailQuality
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x0014EEF1 File Offset: 0x0014D0F1
		[DebuggerNonUserCode]
		public void ClearEnvironmentDetailQuality()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x0014EF08 File Offset: 0x0014D108
		// (set) Token: 0x060056BD RID: 22205 RVA: 0x0014EF3D File Offset: 0x0014D13D
		[DebuggerNonUserCode]
		public uint AtmosphericsQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				uint atmosphericsQualityDefaultValue;
				if (flag)
				{
					atmosphericsQualityDefaultValue = this.atmosphericsQuality_;
				}
				else
				{
					atmosphericsQualityDefaultValue = GraphicsSettings.AtmosphericsQualityDefaultValue;
				}
				return atmosphericsQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.atmosphericsQuality_ = value;
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x0014EF5C File Offset: 0x0014D15C
		[DebuggerNonUserCode]
		public bool HasAtmosphericsQuality
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x0014EF7D File Offset: 0x0014D17D
		[DebuggerNonUserCode]
		public void ClearAtmosphericsQuality()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x0014EF94 File Offset: 0x0014D194
		// (set) Token: 0x060056C1 RID: 22209 RVA: 0x0014EFC9 File Offset: 0x0014D1C9
		[DebuggerNonUserCode]
		public uint TransparencyQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 524288) != 0;
				uint transparencyQualityDefaultValue;
				if (flag)
				{
					transparencyQualityDefaultValue = this.transparencyQuality_;
				}
				else
				{
					transparencyQualityDefaultValue = GraphicsSettings.TransparencyQualityDefaultValue;
				}
				return transparencyQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 524288;
				this.transparencyQuality_ = value;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x060056C2 RID: 22210 RVA: 0x0014EFE8 File Offset: 0x0014D1E8
		[DebuggerNonUserCode]
		public bool HasTransparencyQuality
		{
			get
			{
				return (this._hasBits0 & 524288) != 0;
			}
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x0014F009 File Offset: 0x0014D209
		[DebuggerNonUserCode]
		public void ClearTransparencyQuality()
		{
			this._hasBits0 &= -524289;
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x060056C4 RID: 22212 RVA: 0x0014F020 File Offset: 0x0014D220
		// (set) Token: 0x060056C5 RID: 22213 RVA: 0x0014F055 File Offset: 0x0014D255
		[DebuggerNonUserCode]
		public uint ShadowQuality
		{
			get
			{
				bool flag = (this._hasBits0 & 1048576) != 0;
				uint shadowQualityDefaultValue;
				if (flag)
				{
					shadowQualityDefaultValue = this.shadowQuality_;
				}
				else
				{
					shadowQualityDefaultValue = GraphicsSettings.ShadowQualityDefaultValue;
				}
				return shadowQualityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1048576;
				this.shadowQuality_ = value;
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x0014F074 File Offset: 0x0014D274
		[DebuggerNonUserCode]
		public bool HasShadowQuality
		{
			get
			{
				return (this._hasBits0 & 1048576) != 0;
			}
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x0014F095 File Offset: 0x0014D295
		[DebuggerNonUserCode]
		public void ClearShadowQuality()
		{
			this._hasBits0 &= -1048577;
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x0014F0AC File Offset: 0x0014D2AC
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x0014F0E1 File Offset: 0x0014D2E1
		[DebuggerNonUserCode]
		public uint AntiAliasingMode
		{
			get
			{
				bool flag = (this._hasBits0 & 2097152) != 0;
				uint antiAliasingModeDefaultValue;
				if (flag)
				{
					antiAliasingModeDefaultValue = this.antiAliasingMode_;
				}
				else
				{
					antiAliasingModeDefaultValue = GraphicsSettings.AntiAliasingModeDefaultValue;
				}
				return antiAliasingModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2097152;
				this.antiAliasingMode_ = value;
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x060056CA RID: 22218 RVA: 0x0014F100 File Offset: 0x0014D300
		[DebuggerNonUserCode]
		public bool HasAntiAliasingMode
		{
			get
			{
				return (this._hasBits0 & 2097152) != 0;
			}
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x0014F121 File Offset: 0x0014D321
		[DebuggerNonUserCode]
		public void ClearAntiAliasingMode()
		{
			this._hasBits0 &= -2097153;
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x0014F138 File Offset: 0x0014D338
		// (set) Token: 0x060056CD RID: 22221 RVA: 0x0014F16D File Offset: 0x0014D36D
		[DebuggerNonUserCode]
		public int HdrCalibration
		{
			get
			{
				bool flag = (this._hasBits0 & 4194304) != 0;
				int hdrCalibrationDefaultValue;
				if (flag)
				{
					hdrCalibrationDefaultValue = this.hdrCalibration_;
				}
				else
				{
					hdrCalibrationDefaultValue = GraphicsSettings.HdrCalibrationDefaultValue;
				}
				return hdrCalibrationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4194304;
				this.hdrCalibration_ = value;
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x0014F18C File Offset: 0x0014D38C
		[DebuggerNonUserCode]
		public bool HasHdrCalibration
		{
			get
			{
				return (this._hasBits0 & 4194304) != 0;
			}
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x0014F1AD File Offset: 0x0014D3AD
		[DebuggerNonUserCode]
		public void ClearHdrCalibration()
		{
			this._hasBits0 &= -4194305;
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x060056D0 RID: 22224 RVA: 0x0014F1C4 File Offset: 0x0014D3C4
		// (set) Token: 0x060056D1 RID: 22225 RVA: 0x0014F1F9 File Offset: 0x0014D3F9
		[DebuggerNonUserCode]
		public bool DynamicResolutionScaling
		{
			get
			{
				bool flag = (this._hasBits0 & 8388608) != 0;
				bool dynamicResolutionScalingDefaultValue;
				if (flag)
				{
					dynamicResolutionScalingDefaultValue = this.dynamicResolutionScaling_;
				}
				else
				{
					dynamicResolutionScalingDefaultValue = GraphicsSettings.DynamicResolutionScalingDefaultValue;
				}
				return dynamicResolutionScalingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8388608;
				this.dynamicResolutionScaling_ = value;
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x0014F218 File Offset: 0x0014D418
		[DebuggerNonUserCode]
		public bool HasDynamicResolutionScaling
		{
			get
			{
				return (this._hasBits0 & 8388608) != 0;
			}
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x0014F239 File Offset: 0x0014D439
		[DebuggerNonUserCode]
		public void ClearDynamicResolutionScaling()
		{
			this._hasBits0 &= -8388609;
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x060056D4 RID: 22228 RVA: 0x0014F250 File Offset: 0x0014D450
		// (set) Token: 0x060056D5 RID: 22229 RVA: 0x0014F285 File Offset: 0x0014D485
		[DebuggerNonUserCode]
		public uint FrameRateTarget
		{
			get
			{
				bool flag = (this._hasBits0 & 16777216) != 0;
				uint frameRateTargetDefaultValue;
				if (flag)
				{
					frameRateTargetDefaultValue = this.frameRateTarget_;
				}
				else
				{
					frameRateTargetDefaultValue = GraphicsSettings.FrameRateTargetDefaultValue;
				}
				return frameRateTargetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16777216;
				this.frameRateTarget_ = value;
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x060056D6 RID: 22230 RVA: 0x0014F2A4 File Offset: 0x0014D4A4
		[DebuggerNonUserCode]
		public bool HasFrameRateTarget
		{
			get
			{
				return (this._hasBits0 & 16777216) != 0;
			}
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x0014F2C5 File Offset: 0x0014D4C5
		[DebuggerNonUserCode]
		public void ClearFrameRateTarget()
		{
			this._hasBits0 &= -16777217;
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x0014F2DC File Offset: 0x0014D4DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GraphicsSettings);
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x0014F2FC File Offset: 0x0014D4FC
		[DebuggerNonUserCode]
		public bool Equals(GraphicsSettings other)
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
					bool flag4 = this.ScreenResolutionWidth != other.ScreenResolutionWidth;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ScreenResolutionHeight != other.ScreenResolutionHeight;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameResolutionWidth != other.GameResolutionWidth;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.GameResolutionHeight != other.GameResolutionHeight;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.LightingQuality != other.LightingQuality;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.LegacyBlendedShadows != other.LegacyBlendedShadows;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.LegacyPerspective != other.LegacyPerspective;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.SdGamma != other.SdGamma;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.HdGamma != other.HdGamma;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Contrast != other.Contrast;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.VsyncEnabled != other.VsyncEnabled;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.FramerateCapMode != other.FramerateCapMode;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.WindowMode != other.WindowMode;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.TextureQuality != other.TextureQuality;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.TextureAnisotropy != other.TextureAnisotropy;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.AmbientOcclusionQuality != other.AmbientOcclusionQuality;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.CharacterDetailQuality != other.CharacterDetailQuality;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.EnvironmentDetailQuality != other.EnvironmentDetailQuality;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.AtmosphericsQuality != other.AtmosphericsQuality;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.TransparencyQuality != other.TransparencyQuality;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = this.ShadowQuality != other.ShadowQuality;
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = this.AntiAliasingMode != other.AntiAliasingMode;
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.HdrCalibration != other.HdrCalibration;
																											if (flag26)
																											{
																												flag2 = false;
																											}
																											else
																											{
																												bool flag27 = this.DynamicResolutionScaling != other.DynamicResolutionScaling;
																												if (flag27)
																												{
																													flag2 = false;
																												}
																												else
																												{
																													bool flag28 = this.FrameRateTarget != other.FrameRateTarget;
																													flag2 = !flag28 && object.Equals(this._unknownFields, other._unknownFields);
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
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

		// Token: 0x060056DA RID: 22234 RVA: 0x0014F620 File Offset: 0x0014D820
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasScreenResolutionWidth = this.HasScreenResolutionWidth;
			if (hasScreenResolutionWidth)
			{
				num ^= this.ScreenResolutionWidth.GetHashCode();
			}
			bool hasScreenResolutionHeight = this.HasScreenResolutionHeight;
			if (hasScreenResolutionHeight)
			{
				num ^= this.ScreenResolutionHeight.GetHashCode();
			}
			bool hasGameResolutionWidth = this.HasGameResolutionWidth;
			if (hasGameResolutionWidth)
			{
				num ^= this.GameResolutionWidth.GetHashCode();
			}
			bool hasGameResolutionHeight = this.HasGameResolutionHeight;
			if (hasGameResolutionHeight)
			{
				num ^= this.GameResolutionHeight.GetHashCode();
			}
			bool hasLightingQuality = this.HasLightingQuality;
			if (hasLightingQuality)
			{
				num ^= this.LightingQuality.GetHashCode();
			}
			bool hasLegacyBlendedShadows = this.HasLegacyBlendedShadows;
			if (hasLegacyBlendedShadows)
			{
				num ^= this.LegacyBlendedShadows.GetHashCode();
			}
			bool hasLegacyPerspective = this.HasLegacyPerspective;
			if (hasLegacyPerspective)
			{
				num ^= this.LegacyPerspective.GetHashCode();
			}
			bool hasSdGamma = this.HasSdGamma;
			if (hasSdGamma)
			{
				num ^= this.SdGamma.GetHashCode();
			}
			bool hasHdGamma = this.HasHdGamma;
			if (hasHdGamma)
			{
				num ^= this.HdGamma.GetHashCode();
			}
			bool hasContrast = this.HasContrast;
			if (hasContrast)
			{
				num ^= this.Contrast.GetHashCode();
			}
			bool hasVsyncEnabled = this.HasVsyncEnabled;
			if (hasVsyncEnabled)
			{
				num ^= this.VsyncEnabled.GetHashCode();
			}
			bool hasFramerateCapMode = this.HasFramerateCapMode;
			if (hasFramerateCapMode)
			{
				num ^= this.FramerateCapMode.GetHashCode();
			}
			bool hasWindowMode = this.HasWindowMode;
			if (hasWindowMode)
			{
				num ^= this.WindowMode.GetHashCode();
			}
			bool hasTextureQuality = this.HasTextureQuality;
			if (hasTextureQuality)
			{
				num ^= this.TextureQuality.GetHashCode();
			}
			bool hasTextureAnisotropy = this.HasTextureAnisotropy;
			if (hasTextureAnisotropy)
			{
				num ^= this.TextureAnisotropy.GetHashCode();
			}
			bool hasAmbientOcclusionQuality = this.HasAmbientOcclusionQuality;
			if (hasAmbientOcclusionQuality)
			{
				num ^= this.AmbientOcclusionQuality.GetHashCode();
			}
			bool hasCharacterDetailQuality = this.HasCharacterDetailQuality;
			if (hasCharacterDetailQuality)
			{
				num ^= this.CharacterDetailQuality.GetHashCode();
			}
			bool hasEnvironmentDetailQuality = this.HasEnvironmentDetailQuality;
			if (hasEnvironmentDetailQuality)
			{
				num ^= this.EnvironmentDetailQuality.GetHashCode();
			}
			bool hasAtmosphericsQuality = this.HasAtmosphericsQuality;
			if (hasAtmosphericsQuality)
			{
				num ^= this.AtmosphericsQuality.GetHashCode();
			}
			bool hasTransparencyQuality = this.HasTransparencyQuality;
			if (hasTransparencyQuality)
			{
				num ^= this.TransparencyQuality.GetHashCode();
			}
			bool hasShadowQuality = this.HasShadowQuality;
			if (hasShadowQuality)
			{
				num ^= this.ShadowQuality.GetHashCode();
			}
			bool hasAntiAliasingMode = this.HasAntiAliasingMode;
			if (hasAntiAliasingMode)
			{
				num ^= this.AntiAliasingMode.GetHashCode();
			}
			bool hasHdrCalibration = this.HasHdrCalibration;
			if (hasHdrCalibration)
			{
				num ^= this.HdrCalibration.GetHashCode();
			}
			bool hasDynamicResolutionScaling = this.HasDynamicResolutionScaling;
			if (hasDynamicResolutionScaling)
			{
				num ^= this.DynamicResolutionScaling.GetHashCode();
			}
			bool hasFrameRateTarget = this.HasFrameRateTarget;
			if (hasFrameRateTarget)
			{
				num ^= this.FrameRateTarget.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x0014F930 File Offset: 0x0014DB30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x0014F948 File Offset: 0x0014DB48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x0014F954 File Offset: 0x0014DB54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasScreenResolutionWidth = this.HasScreenResolutionWidth;
			if (hasScreenResolutionWidth)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ScreenResolutionWidth);
			}
			bool hasScreenResolutionHeight = this.HasScreenResolutionHeight;
			if (hasScreenResolutionHeight)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ScreenResolutionHeight);
			}
			bool hasGameResolutionWidth = this.HasGameResolutionWidth;
			if (hasGameResolutionWidth)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GameResolutionWidth);
			}
			bool hasGameResolutionHeight = this.HasGameResolutionHeight;
			if (hasGameResolutionHeight)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GameResolutionHeight);
			}
			bool hasLightingQuality = this.HasLightingQuality;
			if (hasLightingQuality)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.LightingQuality);
			}
			bool hasLegacyBlendedShadows = this.HasLegacyBlendedShadows;
			if (hasLegacyBlendedShadows)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.LegacyBlendedShadows);
			}
			bool hasLegacyPerspective = this.HasLegacyPerspective;
			if (hasLegacyPerspective)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.LegacyPerspective);
			}
			bool hasSdGamma = this.HasSdGamma;
			if (hasSdGamma)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SdGamma);
			}
			bool hasHdGamma = this.HasHdGamma;
			if (hasHdGamma)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HdGamma);
			}
			bool hasContrast = this.HasContrast;
			if (hasContrast)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Contrast);
			}
			bool hasVsyncEnabled = this.HasVsyncEnabled;
			if (hasVsyncEnabled)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.VsyncEnabled);
			}
			bool hasFramerateCapMode = this.HasFramerateCapMode;
			if (hasFramerateCapMode)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.FramerateCapMode);
			}
			bool hasWindowMode = this.HasWindowMode;
			if (hasWindowMode)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.WindowMode);
			}
			bool hasTextureQuality = this.HasTextureQuality;
			if (hasTextureQuality)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.TextureQuality);
			}
			bool hasTextureAnisotropy = this.HasTextureAnisotropy;
			if (hasTextureAnisotropy)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.TextureAnisotropy);
			}
			bool hasAmbientOcclusionQuality = this.HasAmbientOcclusionQuality;
			if (hasAmbientOcclusionQuality)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt32(this.AmbientOcclusionQuality);
			}
			bool hasCharacterDetailQuality = this.HasCharacterDetailQuality;
			if (hasCharacterDetailQuality)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.CharacterDetailQuality);
			}
			bool hasEnvironmentDetailQuality = this.HasEnvironmentDetailQuality;
			if (hasEnvironmentDetailQuality)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.EnvironmentDetailQuality);
			}
			bool hasAtmosphericsQuality = this.HasAtmosphericsQuality;
			if (hasAtmosphericsQuality)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt32(this.AtmosphericsQuality);
			}
			bool hasTransparencyQuality = this.HasTransparencyQuality;
			if (hasTransparencyQuality)
			{
				output.WriteRawTag(160, 1);
				output.WriteUInt32(this.TransparencyQuality);
			}
			bool hasShadowQuality = this.HasShadowQuality;
			if (hasShadowQuality)
			{
				output.WriteRawTag(168, 1);
				output.WriteUInt32(this.ShadowQuality);
			}
			bool hasAntiAliasingMode = this.HasAntiAliasingMode;
			if (hasAntiAliasingMode)
			{
				output.WriteRawTag(176, 1);
				output.WriteUInt32(this.AntiAliasingMode);
			}
			bool hasHdrCalibration = this.HasHdrCalibration;
			if (hasHdrCalibration)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.HdrCalibration);
			}
			bool hasDynamicResolutionScaling = this.HasDynamicResolutionScaling;
			if (hasDynamicResolutionScaling)
			{
				output.WriteRawTag(192, 1);
				output.WriteBool(this.DynamicResolutionScaling);
			}
			bool hasFrameRateTarget = this.HasFrameRateTarget;
			if (hasFrameRateTarget)
			{
				output.WriteRawTag(200, 1);
				output.WriteUInt32(this.FrameRateTarget);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x0014FD24 File Offset: 0x0014DF24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasScreenResolutionWidth = this.HasScreenResolutionWidth;
			if (hasScreenResolutionWidth)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScreenResolutionWidth);
			}
			bool hasScreenResolutionHeight = this.HasScreenResolutionHeight;
			if (hasScreenResolutionHeight)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScreenResolutionHeight);
			}
			bool hasGameResolutionWidth = this.HasGameResolutionWidth;
			if (hasGameResolutionWidth)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameResolutionWidth);
			}
			bool hasGameResolutionHeight = this.HasGameResolutionHeight;
			if (hasGameResolutionHeight)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameResolutionHeight);
			}
			bool hasLightingQuality = this.HasLightingQuality;
			if (hasLightingQuality)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LightingQuality);
			}
			bool hasLegacyBlendedShadows = this.HasLegacyBlendedShadows;
			if (hasLegacyBlendedShadows)
			{
				num += 2;
			}
			bool hasLegacyPerspective = this.HasLegacyPerspective;
			if (hasLegacyPerspective)
			{
				num += 2;
			}
			bool hasSdGamma = this.HasSdGamma;
			if (hasSdGamma)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SdGamma);
			}
			bool hasHdGamma = this.HasHdGamma;
			if (hasHdGamma)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HdGamma);
			}
			bool hasContrast = this.HasContrast;
			if (hasContrast)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Contrast);
			}
			bool hasVsyncEnabled = this.HasVsyncEnabled;
			if (hasVsyncEnabled)
			{
				num += 2;
			}
			bool hasFramerateCapMode = this.HasFramerateCapMode;
			if (hasFramerateCapMode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FramerateCapMode);
			}
			bool hasWindowMode = this.HasWindowMode;
			if (hasWindowMode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WindowMode);
			}
			bool hasTextureQuality = this.HasTextureQuality;
			if (hasTextureQuality)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextureQuality);
			}
			bool hasTextureAnisotropy = this.HasTextureAnisotropy;
			if (hasTextureAnisotropy)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextureAnisotropy);
			}
			bool hasAmbientOcclusionQuality = this.HasAmbientOcclusionQuality;
			if (hasAmbientOcclusionQuality)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.AmbientOcclusionQuality);
			}
			bool hasCharacterDetailQuality = this.HasCharacterDetailQuality;
			if (hasCharacterDetailQuality)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.CharacterDetailQuality);
			}
			bool hasEnvironmentDetailQuality = this.HasEnvironmentDetailQuality;
			if (hasEnvironmentDetailQuality)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.EnvironmentDetailQuality);
			}
			bool hasAtmosphericsQuality = this.HasAtmosphericsQuality;
			if (hasAtmosphericsQuality)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.AtmosphericsQuality);
			}
			bool hasTransparencyQuality = this.HasTransparencyQuality;
			if (hasTransparencyQuality)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.TransparencyQuality);
			}
			bool hasShadowQuality = this.HasShadowQuality;
			if (hasShadowQuality)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.ShadowQuality);
			}
			bool hasAntiAliasingMode = this.HasAntiAliasingMode;
			if (hasAntiAliasingMode)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.AntiAliasingMode);
			}
			bool hasHdrCalibration = this.HasHdrCalibration;
			if (hasHdrCalibration)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.HdrCalibration);
			}
			bool hasDynamicResolutionScaling = this.HasDynamicResolutionScaling;
			if (hasDynamicResolutionScaling)
			{
				num += 3;
			}
			bool hasFrameRateTarget = this.HasFrameRateTarget;
			if (hasFrameRateTarget)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.FrameRateTarget);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00150014 File Offset: 0x0014E214
		[DebuggerNonUserCode]
		public void MergeFrom(GraphicsSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasScreenResolutionWidth = other.HasScreenResolutionWidth;
				if (hasScreenResolutionWidth)
				{
					this.ScreenResolutionWidth = other.ScreenResolutionWidth;
				}
				bool hasScreenResolutionHeight = other.HasScreenResolutionHeight;
				if (hasScreenResolutionHeight)
				{
					this.ScreenResolutionHeight = other.ScreenResolutionHeight;
				}
				bool hasGameResolutionWidth = other.HasGameResolutionWidth;
				if (hasGameResolutionWidth)
				{
					this.GameResolutionWidth = other.GameResolutionWidth;
				}
				bool hasGameResolutionHeight = other.HasGameResolutionHeight;
				if (hasGameResolutionHeight)
				{
					this.GameResolutionHeight = other.GameResolutionHeight;
				}
				bool hasLightingQuality = other.HasLightingQuality;
				if (hasLightingQuality)
				{
					this.LightingQuality = other.LightingQuality;
				}
				bool hasLegacyBlendedShadows = other.HasLegacyBlendedShadows;
				if (hasLegacyBlendedShadows)
				{
					this.LegacyBlendedShadows = other.LegacyBlendedShadows;
				}
				bool hasLegacyPerspective = other.HasLegacyPerspective;
				if (hasLegacyPerspective)
				{
					this.LegacyPerspective = other.LegacyPerspective;
				}
				bool hasSdGamma = other.HasSdGamma;
				if (hasSdGamma)
				{
					this.SdGamma = other.SdGamma;
				}
				bool hasHdGamma = other.HasHdGamma;
				if (hasHdGamma)
				{
					this.HdGamma = other.HdGamma;
				}
				bool hasContrast = other.HasContrast;
				if (hasContrast)
				{
					this.Contrast = other.Contrast;
				}
				bool hasVsyncEnabled = other.HasVsyncEnabled;
				if (hasVsyncEnabled)
				{
					this.VsyncEnabled = other.VsyncEnabled;
				}
				bool hasFramerateCapMode = other.HasFramerateCapMode;
				if (hasFramerateCapMode)
				{
					this.FramerateCapMode = other.FramerateCapMode;
				}
				bool hasWindowMode = other.HasWindowMode;
				if (hasWindowMode)
				{
					this.WindowMode = other.WindowMode;
				}
				bool hasTextureQuality = other.HasTextureQuality;
				if (hasTextureQuality)
				{
					this.TextureQuality = other.TextureQuality;
				}
				bool hasTextureAnisotropy = other.HasTextureAnisotropy;
				if (hasTextureAnisotropy)
				{
					this.TextureAnisotropy = other.TextureAnisotropy;
				}
				bool hasAmbientOcclusionQuality = other.HasAmbientOcclusionQuality;
				if (hasAmbientOcclusionQuality)
				{
					this.AmbientOcclusionQuality = other.AmbientOcclusionQuality;
				}
				bool hasCharacterDetailQuality = other.HasCharacterDetailQuality;
				if (hasCharacterDetailQuality)
				{
					this.CharacterDetailQuality = other.CharacterDetailQuality;
				}
				bool hasEnvironmentDetailQuality = other.HasEnvironmentDetailQuality;
				if (hasEnvironmentDetailQuality)
				{
					this.EnvironmentDetailQuality = other.EnvironmentDetailQuality;
				}
				bool hasAtmosphericsQuality = other.HasAtmosphericsQuality;
				if (hasAtmosphericsQuality)
				{
					this.AtmosphericsQuality = other.AtmosphericsQuality;
				}
				bool hasTransparencyQuality = other.HasTransparencyQuality;
				if (hasTransparencyQuality)
				{
					this.TransparencyQuality = other.TransparencyQuality;
				}
				bool hasShadowQuality = other.HasShadowQuality;
				if (hasShadowQuality)
				{
					this.ShadowQuality = other.ShadowQuality;
				}
				bool hasAntiAliasingMode = other.HasAntiAliasingMode;
				if (hasAntiAliasingMode)
				{
					this.AntiAliasingMode = other.AntiAliasingMode;
				}
				bool hasHdrCalibration = other.HasHdrCalibration;
				if (hasHdrCalibration)
				{
					this.HdrCalibration = other.HdrCalibration;
				}
				bool hasDynamicResolutionScaling = other.HasDynamicResolutionScaling;
				if (hasDynamicResolutionScaling)
				{
					this.DynamicResolutionScaling = other.DynamicResolutionScaling;
				}
				bool hasFrameRateTarget = other.HasFrameRateTarget;
				if (hasFrameRateTarget)
				{
					this.FrameRateTarget = other.FrameRateTarget;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x001502E4 File Offset: 0x0014E4E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x001502F0 File Offset: 0x0014E4F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 96U)
				{
					if (num3 <= 48U)
					{
						if (num3 <= 24U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									if (num3 != 24U)
									{
										goto IL_0165;
									}
									this.GameResolutionWidth = input.ReadUInt32();
								}
								else
								{
									this.ScreenResolutionHeight = input.ReadUInt32();
								}
							}
							else
							{
								this.ScreenResolutionWidth = input.ReadUInt32();
							}
						}
						else if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								if (num3 != 48U)
								{
									goto IL_0165;
								}
								this.LegacyBlendedShadows = input.ReadBool();
							}
							else
							{
								this.LightingQuality = input.ReadUInt32();
							}
						}
						else
						{
							this.GameResolutionHeight = input.ReadUInt32();
						}
					}
					else if (num3 <= 72U)
					{
						if (num3 != 56U)
						{
							if (num3 != 64U)
							{
								if (num3 != 72U)
								{
									goto IL_0165;
								}
								this.HdGamma = input.ReadInt32();
							}
							else
							{
								this.SdGamma = input.ReadInt32();
							}
						}
						else
						{
							this.LegacyPerspective = input.ReadBool();
						}
					}
					else if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							if (num3 != 96U)
							{
								goto IL_0165;
							}
							this.FramerateCapMode = input.ReadUInt32();
						}
						else
						{
							this.VsyncEnabled = input.ReadBool();
						}
					}
					else
					{
						this.Contrast = input.ReadInt32();
					}
				}
				else if (num3 <= 144U)
				{
					if (num3 <= 120U)
					{
						if (num3 != 104U)
						{
							if (num3 != 112U)
							{
								if (num3 != 120U)
								{
									goto IL_0165;
								}
								this.TextureAnisotropy = input.ReadUInt32();
							}
							else
							{
								this.TextureQuality = input.ReadUInt32();
							}
						}
						else
						{
							this.WindowMode = input.ReadUInt32();
						}
					}
					else if (num3 != 128U)
					{
						if (num3 != 136U)
						{
							if (num3 != 144U)
							{
								goto IL_0165;
							}
							this.EnvironmentDetailQuality = input.ReadUInt32();
						}
						else
						{
							this.CharacterDetailQuality = input.ReadUInt32();
						}
					}
					else
					{
						this.AmbientOcclusionQuality = input.ReadUInt32();
					}
				}
				else if (num3 <= 168U)
				{
					if (num3 != 152U)
					{
						if (num3 != 160U)
						{
							if (num3 != 168U)
							{
								goto IL_0165;
							}
							this.ShadowQuality = input.ReadUInt32();
						}
						else
						{
							this.TransparencyQuality = input.ReadUInt32();
						}
					}
					else
					{
						this.AtmosphericsQuality = input.ReadUInt32();
					}
				}
				else if (num3 <= 184U)
				{
					if (num3 != 176U)
					{
						if (num3 != 184U)
						{
							goto IL_0165;
						}
						this.HdrCalibration = input.ReadInt32();
					}
					else
					{
						this.AntiAliasingMode = input.ReadUInt32();
					}
				}
				else if (num3 != 192U)
				{
					if (num3 != 200U)
					{
						goto IL_0165;
					}
					this.FrameRateTarget = input.ReadUInt32();
				}
				else
				{
					this.DynamicResolutionScaling = input.ReadBool();
				}
				continue;
				IL_0165:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400275B RID: 10075
		private static readonly MessageParser<GraphicsSettings> _parser = new MessageParser<GraphicsSettings>(() => new GraphicsSettings());

		// Token: 0x0400275C RID: 10076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400275D RID: 10077
		private int _hasBits0;

		// Token: 0x0400275E RID: 10078
		public const int ScreenResolutionWidthFieldNumber = 1;

		// Token: 0x0400275F RID: 10079
		private static readonly uint ScreenResolutionWidthDefaultValue = 0U;

		// Token: 0x04002760 RID: 10080
		private uint screenResolutionWidth_;

		// Token: 0x04002761 RID: 10081
		public const int ScreenResolutionHeightFieldNumber = 2;

		// Token: 0x04002762 RID: 10082
		private static readonly uint ScreenResolutionHeightDefaultValue = 0U;

		// Token: 0x04002763 RID: 10083
		private uint screenResolutionHeight_;

		// Token: 0x04002764 RID: 10084
		public const int GameResolutionWidthFieldNumber = 3;

		// Token: 0x04002765 RID: 10085
		private static readonly uint GameResolutionWidthDefaultValue = 0U;

		// Token: 0x04002766 RID: 10086
		private uint gameResolutionWidth_;

		// Token: 0x04002767 RID: 10087
		public const int GameResolutionHeightFieldNumber = 4;

		// Token: 0x04002768 RID: 10088
		private static readonly uint GameResolutionHeightDefaultValue = 0U;

		// Token: 0x04002769 RID: 10089
		private uint gameResolutionHeight_;

		// Token: 0x0400276A RID: 10090
		public const int LightingQualityFieldNumber = 5;

		// Token: 0x0400276B RID: 10091
		private static readonly uint LightingQualityDefaultValue = 0U;

		// Token: 0x0400276C RID: 10092
		private uint lightingQuality_;

		// Token: 0x0400276D RID: 10093
		public const int LegacyBlendedShadowsFieldNumber = 6;

		// Token: 0x0400276E RID: 10094
		private static readonly bool LegacyBlendedShadowsDefaultValue = false;

		// Token: 0x0400276F RID: 10095
		private bool legacyBlendedShadows_;

		// Token: 0x04002770 RID: 10096
		public const int LegacyPerspectiveFieldNumber = 7;

		// Token: 0x04002771 RID: 10097
		private static readonly bool LegacyPerspectiveDefaultValue = false;

		// Token: 0x04002772 RID: 10098
		private bool legacyPerspective_;

		// Token: 0x04002773 RID: 10099
		public const int SdGammaFieldNumber = 8;

		// Token: 0x04002774 RID: 10100
		private static readonly int SdGammaDefaultValue = 0;

		// Token: 0x04002775 RID: 10101
		private int sdGamma_;

		// Token: 0x04002776 RID: 10102
		public const int HdGammaFieldNumber = 9;

		// Token: 0x04002777 RID: 10103
		private static readonly int HdGammaDefaultValue = 0;

		// Token: 0x04002778 RID: 10104
		private int hdGamma_;

		// Token: 0x04002779 RID: 10105
		public const int ContrastFieldNumber = 10;

		// Token: 0x0400277A RID: 10106
		private static readonly int ContrastDefaultValue = 0;

		// Token: 0x0400277B RID: 10107
		private int contrast_;

		// Token: 0x0400277C RID: 10108
		public const int VsyncEnabledFieldNumber = 11;

		// Token: 0x0400277D RID: 10109
		private static readonly bool VsyncEnabledDefaultValue = false;

		// Token: 0x0400277E RID: 10110
		private bool vsyncEnabled_;

		// Token: 0x0400277F RID: 10111
		public const int FramerateCapModeFieldNumber = 12;

		// Token: 0x04002780 RID: 10112
		private static readonly uint FramerateCapModeDefaultValue = 0U;

		// Token: 0x04002781 RID: 10113
		private uint framerateCapMode_;

		// Token: 0x04002782 RID: 10114
		public const int WindowModeFieldNumber = 13;

		// Token: 0x04002783 RID: 10115
		private static readonly uint WindowModeDefaultValue = 0U;

		// Token: 0x04002784 RID: 10116
		private uint windowMode_;

		// Token: 0x04002785 RID: 10117
		public const int TextureQualityFieldNumber = 14;

		// Token: 0x04002786 RID: 10118
		private static readonly uint TextureQualityDefaultValue = 0U;

		// Token: 0x04002787 RID: 10119
		private uint textureQuality_;

		// Token: 0x04002788 RID: 10120
		public const int TextureAnisotropyFieldNumber = 15;

		// Token: 0x04002789 RID: 10121
		private static readonly uint TextureAnisotropyDefaultValue = 0U;

		// Token: 0x0400278A RID: 10122
		private uint textureAnisotropy_;

		// Token: 0x0400278B RID: 10123
		public const int AmbientOcclusionQualityFieldNumber = 16;

		// Token: 0x0400278C RID: 10124
		private static readonly uint AmbientOcclusionQualityDefaultValue = 0U;

		// Token: 0x0400278D RID: 10125
		private uint ambientOcclusionQuality_;

		// Token: 0x0400278E RID: 10126
		public const int CharacterDetailQualityFieldNumber = 17;

		// Token: 0x0400278F RID: 10127
		private static readonly uint CharacterDetailQualityDefaultValue = 0U;

		// Token: 0x04002790 RID: 10128
		private uint characterDetailQuality_;

		// Token: 0x04002791 RID: 10129
		public const int EnvironmentDetailQualityFieldNumber = 18;

		// Token: 0x04002792 RID: 10130
		private static readonly uint EnvironmentDetailQualityDefaultValue = 0U;

		// Token: 0x04002793 RID: 10131
		private uint environmentDetailQuality_;

		// Token: 0x04002794 RID: 10132
		public const int AtmosphericsQualityFieldNumber = 19;

		// Token: 0x04002795 RID: 10133
		private static readonly uint AtmosphericsQualityDefaultValue = 0U;

		// Token: 0x04002796 RID: 10134
		private uint atmosphericsQuality_;

		// Token: 0x04002797 RID: 10135
		public const int TransparencyQualityFieldNumber = 20;

		// Token: 0x04002798 RID: 10136
		private static readonly uint TransparencyQualityDefaultValue = 0U;

		// Token: 0x04002799 RID: 10137
		private uint transparencyQuality_;

		// Token: 0x0400279A RID: 10138
		public const int ShadowQualityFieldNumber = 21;

		// Token: 0x0400279B RID: 10139
		private static readonly uint ShadowQualityDefaultValue = 0U;

		// Token: 0x0400279C RID: 10140
		private uint shadowQuality_;

		// Token: 0x0400279D RID: 10141
		public const int AntiAliasingModeFieldNumber = 22;

		// Token: 0x0400279E RID: 10142
		private static readonly uint AntiAliasingModeDefaultValue = 0U;

		// Token: 0x0400279F RID: 10143
		private uint antiAliasingMode_;

		// Token: 0x040027A0 RID: 10144
		public const int HdrCalibrationFieldNumber = 23;

		// Token: 0x040027A1 RID: 10145
		private static readonly int HdrCalibrationDefaultValue = 0;

		// Token: 0x040027A2 RID: 10146
		private int hdrCalibration_;

		// Token: 0x040027A3 RID: 10147
		public const int DynamicResolutionScalingFieldNumber = 24;

		// Token: 0x040027A4 RID: 10148
		private static readonly bool DynamicResolutionScalingDefaultValue = false;

		// Token: 0x040027A5 RID: 10149
		private bool dynamicResolutionScaling_;

		// Token: 0x040027A6 RID: 10150
		public const int FrameRateTargetFieldNumber = 25;

		// Token: 0x040027A7 RID: 10151
		private static readonly uint FrameRateTargetDefaultValue = 0U;

		// Token: 0x040027A8 RID: 10152
		private uint frameRateTarget_;
	}
}
