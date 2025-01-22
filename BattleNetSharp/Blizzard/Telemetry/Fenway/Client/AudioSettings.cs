using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000337 RID: 823
	public sealed class AudioSettings : IMessage<AudioSettings>, IMessage, IEquatable<AudioSettings>, IDeepCloneable<AudioSettings>, IBufferMessage
	{
		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x060055A2 RID: 21922 RVA: 0x0014ADF0 File Offset: 0x00148FF0
		[DebuggerNonUserCode]
		public static MessageParser<AudioSettings> Parser
		{
			get
			{
				return AudioSettings._parser;
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x0014AE08 File Offset: 0x00149008
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameAudioReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x060055A4 RID: 21924 RVA: 0x0014AE2C File Offset: 0x0014902C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AudioSettings.Descriptor;
			}
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x0014AE43 File Offset: 0x00149043
		[DebuggerNonUserCode]
		public AudioSettings()
		{
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x0014AE50 File Offset: 0x00149050
		[DebuggerNonUserCode]
		public AudioSettings(AudioSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.soundVolume_ = other.soundVolume_;
			this.musicVolume_ = other.musicVolume_;
			this.npcSpeechMode_ = other.npcSpeechMode_;
			this.language_ = other.language_;
			this.advancedAudioPreset_ = other.advancedAudioPreset_;
			this.voVolume_ = other.voVolume_;
			this.sfxMasterVolume_ = other.sfxMasterVolume_;
			this.sfxUiVolume_ = other.sfxUiVolume_;
			this.sfxItemsVolume_ = other.sfxItemsVolume_;
			this.sfxMonsterVolume_ = other.sfxMonsterVolume_;
			this.sfxPlayerSkillsVolume_ = other.sfxPlayerSkillsVolume_;
			this.sfxAmbientMasterVolume_ = other.sfxAmbientMasterVolume_;
			this.sfxAmbientFootstepsVolume_ = other.sfxAmbientFootstepsVolume_;
			this.sfxAmbientFoleyVolume_ = other.sfxAmbientFoleyVolume_;
			this.sfxAmbientObjectsVolume_ = other.sfxAmbientObjectsVolume_;
			this.sfxAmbientEnvironmentVolume_ = other.sfxAmbientEnvironmentVolume_;
			this.sfxCombatMasterVolume_ = other.sfxCombatMasterVolume_;
			this.sfxCombatImpactsVolume_ = other.sfxCombatImpactsVolume_;
			this.sfxCombatWeaponVolume_ = other.sfxCombatWeaponVolume_;
			this.sfxCombatGoreVolume_ = other.sfxCombatGoreVolume_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x0014AF74 File Offset: 0x00149174
		[DebuggerNonUserCode]
		public AudioSettings Clone()
		{
			return new AudioSettings(this);
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x060055A8 RID: 21928 RVA: 0x0014AF8C File Offset: 0x0014918C
		// (set) Token: 0x060055A9 RID: 21929 RVA: 0x0014AFBD File Offset: 0x001491BD
		[DebuggerNonUserCode]
		public int SoundVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int soundVolumeDefaultValue;
				if (flag)
				{
					soundVolumeDefaultValue = this.soundVolume_;
				}
				else
				{
					soundVolumeDefaultValue = AudioSettings.SoundVolumeDefaultValue;
				}
				return soundVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.soundVolume_ = value;
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x0014AFD8 File Offset: 0x001491D8
		[DebuggerNonUserCode]
		public bool HasSoundVolume
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x0014AFF5 File Offset: 0x001491F5
		[DebuggerNonUserCode]
		public void ClearSoundVolume()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x060055AC RID: 21932 RVA: 0x0014B008 File Offset: 0x00149208
		// (set) Token: 0x060055AD RID: 21933 RVA: 0x0014B039 File Offset: 0x00149239
		[DebuggerNonUserCode]
		public int MusicVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int musicVolumeDefaultValue;
				if (flag)
				{
					musicVolumeDefaultValue = this.musicVolume_;
				}
				else
				{
					musicVolumeDefaultValue = AudioSettings.MusicVolumeDefaultValue;
				}
				return musicVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.musicVolume_ = value;
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x0014B054 File Offset: 0x00149254
		[DebuggerNonUserCode]
		public bool HasMusicVolume
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x0014B071 File Offset: 0x00149271
		[DebuggerNonUserCode]
		public void ClearMusicVolume()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x0014B084 File Offset: 0x00149284
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x0014B0B5 File Offset: 0x001492B5
		[DebuggerNonUserCode]
		public int NpcSpeechMode
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int npcSpeechModeDefaultValue;
				if (flag)
				{
					npcSpeechModeDefaultValue = this.npcSpeechMode_;
				}
				else
				{
					npcSpeechModeDefaultValue = AudioSettings.NpcSpeechModeDefaultValue;
				}
				return npcSpeechModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.npcSpeechMode_ = value;
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x0014B0D0 File Offset: 0x001492D0
		[DebuggerNonUserCode]
		public bool HasNpcSpeechMode
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x0014B0ED File Offset: 0x001492ED
		[DebuggerNonUserCode]
		public void ClearNpcSpeechMode()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x0014B100 File Offset: 0x00149300
		// (set) Token: 0x060055B5 RID: 21941 RVA: 0x0014B121 File Offset: 0x00149321
		[DebuggerNonUserCode]
		public string Language
		{
			get
			{
				return this.language_ ?? AudioSettings.LanguageDefaultValue;
			}
			set
			{
				this.language_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x060055B6 RID: 21942 RVA: 0x0014B138 File Offset: 0x00149338
		[DebuggerNonUserCode]
		public bool HasLanguage
		{
			get
			{
				return this.language_ != null;
			}
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x0014B153 File Offset: 0x00149353
		[DebuggerNonUserCode]
		public void ClearLanguage()
		{
			this.language_ = null;
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x0014B160 File Offset: 0x00149360
		// (set) Token: 0x060055B9 RID: 21945 RVA: 0x0014B191 File Offset: 0x00149391
		[DebuggerNonUserCode]
		public uint AdvancedAudioPreset
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint advancedAudioPresetDefaultValue;
				if (flag)
				{
					advancedAudioPresetDefaultValue = this.advancedAudioPreset_;
				}
				else
				{
					advancedAudioPresetDefaultValue = AudioSettings.AdvancedAudioPresetDefaultValue;
				}
				return advancedAudioPresetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.advancedAudioPreset_ = value;
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x060055BA RID: 21946 RVA: 0x0014B1AC File Offset: 0x001493AC
		[DebuggerNonUserCode]
		public bool HasAdvancedAudioPreset
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x0014B1C9 File Offset: 0x001493C9
		[DebuggerNonUserCode]
		public void ClearAdvancedAudioPreset()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x060055BC RID: 21948 RVA: 0x0014B1DC File Offset: 0x001493DC
		// (set) Token: 0x060055BD RID: 21949 RVA: 0x0014B20E File Offset: 0x0014940E
		[DebuggerNonUserCode]
		public int VoVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int voVolumeDefaultValue;
				if (flag)
				{
					voVolumeDefaultValue = this.voVolume_;
				}
				else
				{
					voVolumeDefaultValue = AudioSettings.VoVolumeDefaultValue;
				}
				return voVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.voVolume_ = value;
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x060055BE RID: 21950 RVA: 0x0014B228 File Offset: 0x00149428
		[DebuggerNonUserCode]
		public bool HasVoVolume
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x0014B246 File Offset: 0x00149446
		[DebuggerNonUserCode]
		public void ClearVoVolume()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x060055C0 RID: 21952 RVA: 0x0014B258 File Offset: 0x00149458
		// (set) Token: 0x060055C1 RID: 21953 RVA: 0x0014B28A File Offset: 0x0014948A
		[DebuggerNonUserCode]
		public int SfxMasterVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int sfxMasterVolumeDefaultValue;
				if (flag)
				{
					sfxMasterVolumeDefaultValue = this.sfxMasterVolume_;
				}
				else
				{
					sfxMasterVolumeDefaultValue = AudioSettings.SfxMasterVolumeDefaultValue;
				}
				return sfxMasterVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.sfxMasterVolume_ = value;
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x0014B2A4 File Offset: 0x001494A4
		[DebuggerNonUserCode]
		public bool HasSfxMasterVolume
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x0014B2C2 File Offset: 0x001494C2
		[DebuggerNonUserCode]
		public void ClearSfxMasterVolume()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x060055C4 RID: 21956 RVA: 0x0014B2D4 File Offset: 0x001494D4
		// (set) Token: 0x060055C5 RID: 21957 RVA: 0x0014B306 File Offset: 0x00149506
		[DebuggerNonUserCode]
		public int SfxUiVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int sfxUiVolumeDefaultValue;
				if (flag)
				{
					sfxUiVolumeDefaultValue = this.sfxUiVolume_;
				}
				else
				{
					sfxUiVolumeDefaultValue = AudioSettings.SfxUiVolumeDefaultValue;
				}
				return sfxUiVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.sfxUiVolume_ = value;
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x0014B320 File Offset: 0x00149520
		[DebuggerNonUserCode]
		public bool HasSfxUiVolume
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x0014B33E File Offset: 0x0014953E
		[DebuggerNonUserCode]
		public void ClearSfxUiVolume()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x0014B350 File Offset: 0x00149550
		// (set) Token: 0x060055C9 RID: 21961 RVA: 0x0014B385 File Offset: 0x00149585
		[DebuggerNonUserCode]
		public int SfxItemsVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int sfxItemsVolumeDefaultValue;
				if (flag)
				{
					sfxItemsVolumeDefaultValue = this.sfxItemsVolume_;
				}
				else
				{
					sfxItemsVolumeDefaultValue = AudioSettings.SfxItemsVolumeDefaultValue;
				}
				return sfxItemsVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.sfxItemsVolume_ = value;
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x0014B3A4 File Offset: 0x001495A4
		[DebuggerNonUserCode]
		public bool HasSfxItemsVolume
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x0014B3C5 File Offset: 0x001495C5
		[DebuggerNonUserCode]
		public void ClearSfxItemsVolume()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x0014B3DC File Offset: 0x001495DC
		// (set) Token: 0x060055CD RID: 21965 RVA: 0x0014B411 File Offset: 0x00149611
		[DebuggerNonUserCode]
		public int SfxMonsterVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int sfxMonsterVolumeDefaultValue;
				if (flag)
				{
					sfxMonsterVolumeDefaultValue = this.sfxMonsterVolume_;
				}
				else
				{
					sfxMonsterVolumeDefaultValue = AudioSettings.SfxMonsterVolumeDefaultValue;
				}
				return sfxMonsterVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.sfxMonsterVolume_ = value;
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x0014B430 File Offset: 0x00149630
		[DebuggerNonUserCode]
		public bool HasSfxMonsterVolume
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x0014B451 File Offset: 0x00149651
		[DebuggerNonUserCode]
		public void ClearSfxMonsterVolume()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x060055D0 RID: 21968 RVA: 0x0014B468 File Offset: 0x00149668
		// (set) Token: 0x060055D1 RID: 21969 RVA: 0x0014B49D File Offset: 0x0014969D
		[DebuggerNonUserCode]
		public int SfxPlayerSkillsVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int sfxPlayerSkillsVolumeDefaultValue;
				if (flag)
				{
					sfxPlayerSkillsVolumeDefaultValue = this.sfxPlayerSkillsVolume_;
				}
				else
				{
					sfxPlayerSkillsVolumeDefaultValue = AudioSettings.SfxPlayerSkillsVolumeDefaultValue;
				}
				return sfxPlayerSkillsVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.sfxPlayerSkillsVolume_ = value;
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x060055D2 RID: 21970 RVA: 0x0014B4BC File Offset: 0x001496BC
		[DebuggerNonUserCode]
		public bool HasSfxPlayerSkillsVolume
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x0014B4DD File Offset: 0x001496DD
		[DebuggerNonUserCode]
		public void ClearSfxPlayerSkillsVolume()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x060055D4 RID: 21972 RVA: 0x0014B4F4 File Offset: 0x001496F4
		// (set) Token: 0x060055D5 RID: 21973 RVA: 0x0014B529 File Offset: 0x00149729
		[DebuggerNonUserCode]
		public int SfxAmbientMasterVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				int sfxAmbientMasterVolumeDefaultValue;
				if (flag)
				{
					sfxAmbientMasterVolumeDefaultValue = this.sfxAmbientMasterVolume_;
				}
				else
				{
					sfxAmbientMasterVolumeDefaultValue = AudioSettings.SfxAmbientMasterVolumeDefaultValue;
				}
				return sfxAmbientMasterVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.sfxAmbientMasterVolume_ = value;
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x060055D6 RID: 21974 RVA: 0x0014B548 File Offset: 0x00149748
		[DebuggerNonUserCode]
		public bool HasSfxAmbientMasterVolume
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x0014B569 File Offset: 0x00149769
		[DebuggerNonUserCode]
		public void ClearSfxAmbientMasterVolume()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x0014B580 File Offset: 0x00149780
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x0014B5B5 File Offset: 0x001497B5
		[DebuggerNonUserCode]
		public int SfxAmbientFootstepsVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				int sfxAmbientFootstepsVolumeDefaultValue;
				if (flag)
				{
					sfxAmbientFootstepsVolumeDefaultValue = this.sfxAmbientFootstepsVolume_;
				}
				else
				{
					sfxAmbientFootstepsVolumeDefaultValue = AudioSettings.SfxAmbientFootstepsVolumeDefaultValue;
				}
				return sfxAmbientFootstepsVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.sfxAmbientFootstepsVolume_ = value;
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x060055DA RID: 21978 RVA: 0x0014B5D4 File Offset: 0x001497D4
		[DebuggerNonUserCode]
		public bool HasSfxAmbientFootstepsVolume
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x0014B5F5 File Offset: 0x001497F5
		[DebuggerNonUserCode]
		public void ClearSfxAmbientFootstepsVolume()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x060055DC RID: 21980 RVA: 0x0014B60C File Offset: 0x0014980C
		// (set) Token: 0x060055DD RID: 21981 RVA: 0x0014B641 File Offset: 0x00149841
		[DebuggerNonUserCode]
		public int SfxAmbientFoleyVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				int sfxAmbientFoleyVolumeDefaultValue;
				if (flag)
				{
					sfxAmbientFoleyVolumeDefaultValue = this.sfxAmbientFoleyVolume_;
				}
				else
				{
					sfxAmbientFoleyVolumeDefaultValue = AudioSettings.SfxAmbientFoleyVolumeDefaultValue;
				}
				return sfxAmbientFoleyVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.sfxAmbientFoleyVolume_ = value;
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x060055DE RID: 21982 RVA: 0x0014B660 File Offset: 0x00149860
		[DebuggerNonUserCode]
		public bool HasSfxAmbientFoleyVolume
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x0014B681 File Offset: 0x00149881
		[DebuggerNonUserCode]
		public void ClearSfxAmbientFoleyVolume()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x060055E0 RID: 21984 RVA: 0x0014B698 File Offset: 0x00149898
		// (set) Token: 0x060055E1 RID: 21985 RVA: 0x0014B6CD File Offset: 0x001498CD
		[DebuggerNonUserCode]
		public int SfxAmbientObjectsVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				int sfxAmbientObjectsVolumeDefaultValue;
				if (flag)
				{
					sfxAmbientObjectsVolumeDefaultValue = this.sfxAmbientObjectsVolume_;
				}
				else
				{
					sfxAmbientObjectsVolumeDefaultValue = AudioSettings.SfxAmbientObjectsVolumeDefaultValue;
				}
				return sfxAmbientObjectsVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.sfxAmbientObjectsVolume_ = value;
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x060055E2 RID: 21986 RVA: 0x0014B6EC File Offset: 0x001498EC
		[DebuggerNonUserCode]
		public bool HasSfxAmbientObjectsVolume
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x0014B70D File Offset: 0x0014990D
		[DebuggerNonUserCode]
		public void ClearSfxAmbientObjectsVolume()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x0014B724 File Offset: 0x00149924
		// (set) Token: 0x060055E5 RID: 21989 RVA: 0x0014B759 File Offset: 0x00149959
		[DebuggerNonUserCode]
		public int SfxAmbientEnvironmentVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				int sfxAmbientEnvironmentVolumeDefaultValue;
				if (flag)
				{
					sfxAmbientEnvironmentVolumeDefaultValue = this.sfxAmbientEnvironmentVolume_;
				}
				else
				{
					sfxAmbientEnvironmentVolumeDefaultValue = AudioSettings.SfxAmbientEnvironmentVolumeDefaultValue;
				}
				return sfxAmbientEnvironmentVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.sfxAmbientEnvironmentVolume_ = value;
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x0014B778 File Offset: 0x00149978
		[DebuggerNonUserCode]
		public bool HasSfxAmbientEnvironmentVolume
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x0014B799 File Offset: 0x00149999
		[DebuggerNonUserCode]
		public void ClearSfxAmbientEnvironmentVolume()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x060055E8 RID: 21992 RVA: 0x0014B7B0 File Offset: 0x001499B0
		// (set) Token: 0x060055E9 RID: 21993 RVA: 0x0014B7E5 File Offset: 0x001499E5
		[DebuggerNonUserCode]
		public int SfxCombatMasterVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 32768) != 0;
				int sfxCombatMasterVolumeDefaultValue;
				if (flag)
				{
					sfxCombatMasterVolumeDefaultValue = this.sfxCombatMasterVolume_;
				}
				else
				{
					sfxCombatMasterVolumeDefaultValue = AudioSettings.SfxCombatMasterVolumeDefaultValue;
				}
				return sfxCombatMasterVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32768;
				this.sfxCombatMasterVolume_ = value;
			}
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x060055EA RID: 21994 RVA: 0x0014B804 File Offset: 0x00149A04
		[DebuggerNonUserCode]
		public bool HasSfxCombatMasterVolume
		{
			get
			{
				return (this._hasBits0 & 32768) != 0;
			}
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x0014B825 File Offset: 0x00149A25
		[DebuggerNonUserCode]
		public void ClearSfxCombatMasterVolume()
		{
			this._hasBits0 &= -32769;
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x060055EC RID: 21996 RVA: 0x0014B83C File Offset: 0x00149A3C
		// (set) Token: 0x060055ED RID: 21997 RVA: 0x0014B871 File Offset: 0x00149A71
		[DebuggerNonUserCode]
		public int SfxCombatImpactsVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 65536) != 0;
				int sfxCombatImpactsVolumeDefaultValue;
				if (flag)
				{
					sfxCombatImpactsVolumeDefaultValue = this.sfxCombatImpactsVolume_;
				}
				else
				{
					sfxCombatImpactsVolumeDefaultValue = AudioSettings.SfxCombatImpactsVolumeDefaultValue;
				}
				return sfxCombatImpactsVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 65536;
				this.sfxCombatImpactsVolume_ = value;
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x0014B890 File Offset: 0x00149A90
		[DebuggerNonUserCode]
		public bool HasSfxCombatImpactsVolume
		{
			get
			{
				return (this._hasBits0 & 65536) != 0;
			}
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x0014B8B1 File Offset: 0x00149AB1
		[DebuggerNonUserCode]
		public void ClearSfxCombatImpactsVolume()
		{
			this._hasBits0 &= -65537;
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x0014B8C8 File Offset: 0x00149AC8
		// (set) Token: 0x060055F1 RID: 22001 RVA: 0x0014B8FD File Offset: 0x00149AFD
		[DebuggerNonUserCode]
		public int SfxCombatWeaponVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 131072) != 0;
				int sfxCombatWeaponVolumeDefaultValue;
				if (flag)
				{
					sfxCombatWeaponVolumeDefaultValue = this.sfxCombatWeaponVolume_;
				}
				else
				{
					sfxCombatWeaponVolumeDefaultValue = AudioSettings.SfxCombatWeaponVolumeDefaultValue;
				}
				return sfxCombatWeaponVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 131072;
				this.sfxCombatWeaponVolume_ = value;
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x060055F2 RID: 22002 RVA: 0x0014B91C File Offset: 0x00149B1C
		[DebuggerNonUserCode]
		public bool HasSfxCombatWeaponVolume
		{
			get
			{
				return (this._hasBits0 & 131072) != 0;
			}
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x0014B93D File Offset: 0x00149B3D
		[DebuggerNonUserCode]
		public void ClearSfxCombatWeaponVolume()
		{
			this._hasBits0 &= -131073;
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x060055F4 RID: 22004 RVA: 0x0014B954 File Offset: 0x00149B54
		// (set) Token: 0x060055F5 RID: 22005 RVA: 0x0014B989 File Offset: 0x00149B89
		[DebuggerNonUserCode]
		public int SfxCombatGoreVolume
		{
			get
			{
				bool flag = (this._hasBits0 & 262144) != 0;
				int sfxCombatGoreVolumeDefaultValue;
				if (flag)
				{
					sfxCombatGoreVolumeDefaultValue = this.sfxCombatGoreVolume_;
				}
				else
				{
					sfxCombatGoreVolumeDefaultValue = AudioSettings.SfxCombatGoreVolumeDefaultValue;
				}
				return sfxCombatGoreVolumeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 262144;
				this.sfxCombatGoreVolume_ = value;
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x0014B9A8 File Offset: 0x00149BA8
		[DebuggerNonUserCode]
		public bool HasSfxCombatGoreVolume
		{
			get
			{
				return (this._hasBits0 & 262144) != 0;
			}
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x0014B9C9 File Offset: 0x00149BC9
		[DebuggerNonUserCode]
		public void ClearSfxCombatGoreVolume()
		{
			this._hasBits0 &= -262145;
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x0014B9E0 File Offset: 0x00149BE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AudioSettings);
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x0014BA00 File Offset: 0x00149C00
		[DebuggerNonUserCode]
		public bool Equals(AudioSettings other)
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
					bool flag4 = this.SoundVolume != other.SoundVolume;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MusicVolume != other.MusicVolume;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.NpcSpeechMode != other.NpcSpeechMode;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Language != other.Language;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AdvancedAudioPreset != other.AdvancedAudioPreset;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.VoVolume != other.VoVolume;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SfxMasterVolume != other.SfxMasterVolume;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.SfxUiVolume != other.SfxUiVolume;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SfxItemsVolume != other.SfxItemsVolume;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SfxMonsterVolume != other.SfxMonsterVolume;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.SfxPlayerSkillsVolume != other.SfxPlayerSkillsVolume;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.SfxAmbientMasterVolume != other.SfxAmbientMasterVolume;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.SfxAmbientFootstepsVolume != other.SfxAmbientFootstepsVolume;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.SfxAmbientFoleyVolume != other.SfxAmbientFoleyVolume;
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = this.SfxAmbientObjectsVolume != other.SfxAmbientObjectsVolume;
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.SfxAmbientEnvironmentVolume != other.SfxAmbientEnvironmentVolume;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.SfxCombatMasterVolume != other.SfxCombatMasterVolume;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.SfxCombatImpactsVolume != other.SfxCombatImpactsVolume;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.SfxCombatWeaponVolume != other.SfxCombatWeaponVolume;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.SfxCombatGoreVolume != other.SfxCombatGoreVolume;
																								flag2 = !flag23 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060055FA RID: 22010 RVA: 0x0014BC90 File Offset: 0x00149E90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSoundVolume = this.HasSoundVolume;
			if (hasSoundVolume)
			{
				num ^= this.SoundVolume.GetHashCode();
			}
			bool hasMusicVolume = this.HasMusicVolume;
			if (hasMusicVolume)
			{
				num ^= this.MusicVolume.GetHashCode();
			}
			bool hasNpcSpeechMode = this.HasNpcSpeechMode;
			if (hasNpcSpeechMode)
			{
				num ^= this.NpcSpeechMode.GetHashCode();
			}
			bool hasLanguage = this.HasLanguage;
			if (hasLanguage)
			{
				num ^= this.Language.GetHashCode();
			}
			bool hasAdvancedAudioPreset = this.HasAdvancedAudioPreset;
			if (hasAdvancedAudioPreset)
			{
				num ^= this.AdvancedAudioPreset.GetHashCode();
			}
			bool hasVoVolume = this.HasVoVolume;
			if (hasVoVolume)
			{
				num ^= this.VoVolume.GetHashCode();
			}
			bool hasSfxMasterVolume = this.HasSfxMasterVolume;
			if (hasSfxMasterVolume)
			{
				num ^= this.SfxMasterVolume.GetHashCode();
			}
			bool hasSfxUiVolume = this.HasSfxUiVolume;
			if (hasSfxUiVolume)
			{
				num ^= this.SfxUiVolume.GetHashCode();
			}
			bool hasSfxItemsVolume = this.HasSfxItemsVolume;
			if (hasSfxItemsVolume)
			{
				num ^= this.SfxItemsVolume.GetHashCode();
			}
			bool hasSfxMonsterVolume = this.HasSfxMonsterVolume;
			if (hasSfxMonsterVolume)
			{
				num ^= this.SfxMonsterVolume.GetHashCode();
			}
			bool hasSfxPlayerSkillsVolume = this.HasSfxPlayerSkillsVolume;
			if (hasSfxPlayerSkillsVolume)
			{
				num ^= this.SfxPlayerSkillsVolume.GetHashCode();
			}
			bool hasSfxAmbientMasterVolume = this.HasSfxAmbientMasterVolume;
			if (hasSfxAmbientMasterVolume)
			{
				num ^= this.SfxAmbientMasterVolume.GetHashCode();
			}
			bool hasSfxAmbientFootstepsVolume = this.HasSfxAmbientFootstepsVolume;
			if (hasSfxAmbientFootstepsVolume)
			{
				num ^= this.SfxAmbientFootstepsVolume.GetHashCode();
			}
			bool hasSfxAmbientFoleyVolume = this.HasSfxAmbientFoleyVolume;
			if (hasSfxAmbientFoleyVolume)
			{
				num ^= this.SfxAmbientFoleyVolume.GetHashCode();
			}
			bool hasSfxAmbientObjectsVolume = this.HasSfxAmbientObjectsVolume;
			if (hasSfxAmbientObjectsVolume)
			{
				num ^= this.SfxAmbientObjectsVolume.GetHashCode();
			}
			bool hasSfxAmbientEnvironmentVolume = this.HasSfxAmbientEnvironmentVolume;
			if (hasSfxAmbientEnvironmentVolume)
			{
				num ^= this.SfxAmbientEnvironmentVolume.GetHashCode();
			}
			bool hasSfxCombatMasterVolume = this.HasSfxCombatMasterVolume;
			if (hasSfxCombatMasterVolume)
			{
				num ^= this.SfxCombatMasterVolume.GetHashCode();
			}
			bool hasSfxCombatImpactsVolume = this.HasSfxCombatImpactsVolume;
			if (hasSfxCombatImpactsVolume)
			{
				num ^= this.SfxCombatImpactsVolume.GetHashCode();
			}
			bool hasSfxCombatWeaponVolume = this.HasSfxCombatWeaponVolume;
			if (hasSfxCombatWeaponVolume)
			{
				num ^= this.SfxCombatWeaponVolume.GetHashCode();
			}
			bool hasSfxCombatGoreVolume = this.HasSfxCombatGoreVolume;
			if (hasSfxCombatGoreVolume)
			{
				num ^= this.SfxCombatGoreVolume.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x0014BF04 File Offset: 0x0014A104
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x0014BF1C File Offset: 0x0014A11C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x0014BF28 File Offset: 0x0014A128
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSoundVolume = this.HasSoundVolume;
			if (hasSoundVolume)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SoundVolume);
			}
			bool hasMusicVolume = this.HasMusicVolume;
			if (hasMusicVolume)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MusicVolume);
			}
			bool hasNpcSpeechMode = this.HasNpcSpeechMode;
			if (hasNpcSpeechMode)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NpcSpeechMode);
			}
			bool hasLanguage = this.HasLanguage;
			if (hasLanguage)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Language);
			}
			bool hasAdvancedAudioPreset = this.HasAdvancedAudioPreset;
			if (hasAdvancedAudioPreset)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AdvancedAudioPreset);
			}
			bool hasVoVolume = this.HasVoVolume;
			if (hasVoVolume)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.VoVolume);
			}
			bool hasSfxMasterVolume = this.HasSfxMasterVolume;
			if (hasSfxMasterVolume)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SfxMasterVolume);
			}
			bool hasSfxUiVolume = this.HasSfxUiVolume;
			if (hasSfxUiVolume)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SfxUiVolume);
			}
			bool hasSfxItemsVolume = this.HasSfxItemsVolume;
			if (hasSfxItemsVolume)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SfxItemsVolume);
			}
			bool hasSfxMonsterVolume = this.HasSfxMonsterVolume;
			if (hasSfxMonsterVolume)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SfxMonsterVolume);
			}
			bool hasSfxPlayerSkillsVolume = this.HasSfxPlayerSkillsVolume;
			if (hasSfxPlayerSkillsVolume)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SfxPlayerSkillsVolume);
			}
			bool hasSfxAmbientMasterVolume = this.HasSfxAmbientMasterVolume;
			if (hasSfxAmbientMasterVolume)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SfxAmbientMasterVolume);
			}
			bool hasSfxAmbientFootstepsVolume = this.HasSfxAmbientFootstepsVolume;
			if (hasSfxAmbientFootstepsVolume)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SfxAmbientFootstepsVolume);
			}
			bool hasSfxAmbientFoleyVolume = this.HasSfxAmbientFoleyVolume;
			if (hasSfxAmbientFoleyVolume)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SfxAmbientFoleyVolume);
			}
			bool hasSfxAmbientObjectsVolume = this.HasSfxAmbientObjectsVolume;
			if (hasSfxAmbientObjectsVolume)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SfxAmbientObjectsVolume);
			}
			bool hasSfxAmbientEnvironmentVolume = this.HasSfxAmbientEnvironmentVolume;
			if (hasSfxAmbientEnvironmentVolume)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.SfxAmbientEnvironmentVolume);
			}
			bool hasSfxCombatMasterVolume = this.HasSfxCombatMasterVolume;
			if (hasSfxCombatMasterVolume)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.SfxCombatMasterVolume);
			}
			bool hasSfxCombatImpactsVolume = this.HasSfxCombatImpactsVolume;
			if (hasSfxCombatImpactsVolume)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.SfxCombatImpactsVolume);
			}
			bool hasSfxCombatWeaponVolume = this.HasSfxCombatWeaponVolume;
			if (hasSfxCombatWeaponVolume)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.SfxCombatWeaponVolume);
			}
			bool hasSfxCombatGoreVolume = this.HasSfxCombatGoreVolume;
			if (hasSfxCombatGoreVolume)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.SfxCombatGoreVolume);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x0014C230 File Offset: 0x0014A430
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSoundVolume = this.HasSoundVolume;
			if (hasSoundVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SoundVolume);
			}
			bool hasMusicVolume = this.HasMusicVolume;
			if (hasMusicVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MusicVolume);
			}
			bool hasNpcSpeechMode = this.HasNpcSpeechMode;
			if (hasNpcSpeechMode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcSpeechMode);
			}
			bool hasLanguage = this.HasLanguage;
			if (hasLanguage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Language);
			}
			bool hasAdvancedAudioPreset = this.HasAdvancedAudioPreset;
			if (hasAdvancedAudioPreset)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AdvancedAudioPreset);
			}
			bool hasVoVolume = this.HasVoVolume;
			if (hasVoVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoVolume);
			}
			bool hasSfxMasterVolume = this.HasSfxMasterVolume;
			if (hasSfxMasterVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxMasterVolume);
			}
			bool hasSfxUiVolume = this.HasSfxUiVolume;
			if (hasSfxUiVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxUiVolume);
			}
			bool hasSfxItemsVolume = this.HasSfxItemsVolume;
			if (hasSfxItemsVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxItemsVolume);
			}
			bool hasSfxMonsterVolume = this.HasSfxMonsterVolume;
			if (hasSfxMonsterVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxMonsterVolume);
			}
			bool hasSfxPlayerSkillsVolume = this.HasSfxPlayerSkillsVolume;
			if (hasSfxPlayerSkillsVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxPlayerSkillsVolume);
			}
			bool hasSfxAmbientMasterVolume = this.HasSfxAmbientMasterVolume;
			if (hasSfxAmbientMasterVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxAmbientMasterVolume);
			}
			bool hasSfxAmbientFootstepsVolume = this.HasSfxAmbientFootstepsVolume;
			if (hasSfxAmbientFootstepsVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxAmbientFootstepsVolume);
			}
			bool hasSfxAmbientFoleyVolume = this.HasSfxAmbientFoleyVolume;
			if (hasSfxAmbientFoleyVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxAmbientFoleyVolume);
			}
			bool hasSfxAmbientObjectsVolume = this.HasSfxAmbientObjectsVolume;
			if (hasSfxAmbientObjectsVolume)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SfxAmbientObjectsVolume);
			}
			bool hasSfxAmbientEnvironmentVolume = this.HasSfxAmbientEnvironmentVolume;
			if (hasSfxAmbientEnvironmentVolume)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SfxAmbientEnvironmentVolume);
			}
			bool hasSfxCombatMasterVolume = this.HasSfxCombatMasterVolume;
			if (hasSfxCombatMasterVolume)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SfxCombatMasterVolume);
			}
			bool hasSfxCombatImpactsVolume = this.HasSfxCombatImpactsVolume;
			if (hasSfxCombatImpactsVolume)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SfxCombatImpactsVolume);
			}
			bool hasSfxCombatWeaponVolume = this.HasSfxCombatWeaponVolume;
			if (hasSfxCombatWeaponVolume)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SfxCombatWeaponVolume);
			}
			bool hasSfxCombatGoreVolume = this.HasSfxCombatGoreVolume;
			if (hasSfxCombatGoreVolume)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SfxCombatGoreVolume);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x0014C4B8 File Offset: 0x0014A6B8
		[DebuggerNonUserCode]
		public void MergeFrom(AudioSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSoundVolume = other.HasSoundVolume;
				if (hasSoundVolume)
				{
					this.SoundVolume = other.SoundVolume;
				}
				bool hasMusicVolume = other.HasMusicVolume;
				if (hasMusicVolume)
				{
					this.MusicVolume = other.MusicVolume;
				}
				bool hasNpcSpeechMode = other.HasNpcSpeechMode;
				if (hasNpcSpeechMode)
				{
					this.NpcSpeechMode = other.NpcSpeechMode;
				}
				bool hasLanguage = other.HasLanguage;
				if (hasLanguage)
				{
					this.Language = other.Language;
				}
				bool hasAdvancedAudioPreset = other.HasAdvancedAudioPreset;
				if (hasAdvancedAudioPreset)
				{
					this.AdvancedAudioPreset = other.AdvancedAudioPreset;
				}
				bool hasVoVolume = other.HasVoVolume;
				if (hasVoVolume)
				{
					this.VoVolume = other.VoVolume;
				}
				bool hasSfxMasterVolume = other.HasSfxMasterVolume;
				if (hasSfxMasterVolume)
				{
					this.SfxMasterVolume = other.SfxMasterVolume;
				}
				bool hasSfxUiVolume = other.HasSfxUiVolume;
				if (hasSfxUiVolume)
				{
					this.SfxUiVolume = other.SfxUiVolume;
				}
				bool hasSfxItemsVolume = other.HasSfxItemsVolume;
				if (hasSfxItemsVolume)
				{
					this.SfxItemsVolume = other.SfxItemsVolume;
				}
				bool hasSfxMonsterVolume = other.HasSfxMonsterVolume;
				if (hasSfxMonsterVolume)
				{
					this.SfxMonsterVolume = other.SfxMonsterVolume;
				}
				bool hasSfxPlayerSkillsVolume = other.HasSfxPlayerSkillsVolume;
				if (hasSfxPlayerSkillsVolume)
				{
					this.SfxPlayerSkillsVolume = other.SfxPlayerSkillsVolume;
				}
				bool hasSfxAmbientMasterVolume = other.HasSfxAmbientMasterVolume;
				if (hasSfxAmbientMasterVolume)
				{
					this.SfxAmbientMasterVolume = other.SfxAmbientMasterVolume;
				}
				bool hasSfxAmbientFootstepsVolume = other.HasSfxAmbientFootstepsVolume;
				if (hasSfxAmbientFootstepsVolume)
				{
					this.SfxAmbientFootstepsVolume = other.SfxAmbientFootstepsVolume;
				}
				bool hasSfxAmbientFoleyVolume = other.HasSfxAmbientFoleyVolume;
				if (hasSfxAmbientFoleyVolume)
				{
					this.SfxAmbientFoleyVolume = other.SfxAmbientFoleyVolume;
				}
				bool hasSfxAmbientObjectsVolume = other.HasSfxAmbientObjectsVolume;
				if (hasSfxAmbientObjectsVolume)
				{
					this.SfxAmbientObjectsVolume = other.SfxAmbientObjectsVolume;
				}
				bool hasSfxAmbientEnvironmentVolume = other.HasSfxAmbientEnvironmentVolume;
				if (hasSfxAmbientEnvironmentVolume)
				{
					this.SfxAmbientEnvironmentVolume = other.SfxAmbientEnvironmentVolume;
				}
				bool hasSfxCombatMasterVolume = other.HasSfxCombatMasterVolume;
				if (hasSfxCombatMasterVolume)
				{
					this.SfxCombatMasterVolume = other.SfxCombatMasterVolume;
				}
				bool hasSfxCombatImpactsVolume = other.HasSfxCombatImpactsVolume;
				if (hasSfxCombatImpactsVolume)
				{
					this.SfxCombatImpactsVolume = other.SfxCombatImpactsVolume;
				}
				bool hasSfxCombatWeaponVolume = other.HasSfxCombatWeaponVolume;
				if (hasSfxCombatWeaponVolume)
				{
					this.SfxCombatWeaponVolume = other.SfxCombatWeaponVolume;
				}
				bool hasSfxCombatGoreVolume = other.HasSfxCombatGoreVolume;
				if (hasSfxCombatGoreVolume)
				{
					this.SfxCombatGoreVolume = other.SfxCombatGoreVolume;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x0014C701 File Offset: 0x0014A901
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x0014C70C File Offset: 0x0014A90C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 80U)
				{
					if (num3 <= 40U)
					{
						if (num3 <= 16U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									goto IL_0113;
								}
								this.MusicVolume = input.ReadInt32();
							}
							else
							{
								this.SoundVolume = input.ReadInt32();
							}
						}
						else if (num3 != 24U)
						{
							if (num3 != 34U)
							{
								if (num3 != 40U)
								{
									goto IL_0113;
								}
								this.AdvancedAudioPreset = input.ReadUInt32();
							}
							else
							{
								this.Language = input.ReadString();
							}
						}
						else
						{
							this.NpcSpeechMode = input.ReadInt32();
						}
					}
					else if (num3 <= 56U)
					{
						if (num3 != 48U)
						{
							if (num3 != 56U)
							{
								goto IL_0113;
							}
							this.SfxMasterVolume = input.ReadInt32();
						}
						else
						{
							this.VoVolume = input.ReadInt32();
						}
					}
					else if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							if (num3 != 80U)
							{
								goto IL_0113;
							}
							this.SfxMonsterVolume = input.ReadInt32();
						}
						else
						{
							this.SfxItemsVolume = input.ReadInt32();
						}
					}
					else
					{
						this.SfxUiVolume = input.ReadInt32();
					}
				}
				else if (num3 <= 120U)
				{
					if (num3 <= 96U)
					{
						if (num3 != 88U)
						{
							if (num3 != 96U)
							{
								goto IL_0113;
							}
							this.SfxAmbientMasterVolume = input.ReadInt32();
						}
						else
						{
							this.SfxPlayerSkillsVolume = input.ReadInt32();
						}
					}
					else if (num3 != 104U)
					{
						if (num3 != 112U)
						{
							if (num3 != 120U)
							{
								goto IL_0113;
							}
							this.SfxAmbientObjectsVolume = input.ReadInt32();
						}
						else
						{
							this.SfxAmbientFoleyVolume = input.ReadInt32();
						}
					}
					else
					{
						this.SfxAmbientFootstepsVolume = input.ReadInt32();
					}
				}
				else if (num3 <= 136U)
				{
					if (num3 != 128U)
					{
						if (num3 != 136U)
						{
							goto IL_0113;
						}
						this.SfxCombatMasterVolume = input.ReadInt32();
					}
					else
					{
						this.SfxAmbientEnvironmentVolume = input.ReadInt32();
					}
				}
				else if (num3 != 144U)
				{
					if (num3 != 152U)
					{
						if (num3 != 160U)
						{
							goto IL_0113;
						}
						this.SfxCombatGoreVolume = input.ReadInt32();
					}
					else
					{
						this.SfxCombatWeaponVolume = input.ReadInt32();
					}
				}
				else
				{
					this.SfxCombatImpactsVolume = input.ReadInt32();
				}
				continue;
				IL_0113:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026EC RID: 9964
		private static readonly MessageParser<AudioSettings> _parser = new MessageParser<AudioSettings>(() => new AudioSettings());

		// Token: 0x040026ED RID: 9965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026EE RID: 9966
		private int _hasBits0;

		// Token: 0x040026EF RID: 9967
		public const int SoundVolumeFieldNumber = 1;

		// Token: 0x040026F0 RID: 9968
		private static readonly int SoundVolumeDefaultValue = 0;

		// Token: 0x040026F1 RID: 9969
		private int soundVolume_;

		// Token: 0x040026F2 RID: 9970
		public const int MusicVolumeFieldNumber = 2;

		// Token: 0x040026F3 RID: 9971
		private static readonly int MusicVolumeDefaultValue = 0;

		// Token: 0x040026F4 RID: 9972
		private int musicVolume_;

		// Token: 0x040026F5 RID: 9973
		public const int NpcSpeechModeFieldNumber = 3;

		// Token: 0x040026F6 RID: 9974
		private static readonly int NpcSpeechModeDefaultValue = 0;

		// Token: 0x040026F7 RID: 9975
		private int npcSpeechMode_;

		// Token: 0x040026F8 RID: 9976
		public const int LanguageFieldNumber = 4;

		// Token: 0x040026F9 RID: 9977
		private static readonly string LanguageDefaultValue = "";

		// Token: 0x040026FA RID: 9978
		private string language_;

		// Token: 0x040026FB RID: 9979
		public const int AdvancedAudioPresetFieldNumber = 5;

		// Token: 0x040026FC RID: 9980
		private static readonly uint AdvancedAudioPresetDefaultValue = 0U;

		// Token: 0x040026FD RID: 9981
		private uint advancedAudioPreset_;

		// Token: 0x040026FE RID: 9982
		public const int VoVolumeFieldNumber = 6;

		// Token: 0x040026FF RID: 9983
		private static readonly int VoVolumeDefaultValue = 0;

		// Token: 0x04002700 RID: 9984
		private int voVolume_;

		// Token: 0x04002701 RID: 9985
		public const int SfxMasterVolumeFieldNumber = 7;

		// Token: 0x04002702 RID: 9986
		private static readonly int SfxMasterVolumeDefaultValue = 0;

		// Token: 0x04002703 RID: 9987
		private int sfxMasterVolume_;

		// Token: 0x04002704 RID: 9988
		public const int SfxUiVolumeFieldNumber = 8;

		// Token: 0x04002705 RID: 9989
		private static readonly int SfxUiVolumeDefaultValue = 0;

		// Token: 0x04002706 RID: 9990
		private int sfxUiVolume_;

		// Token: 0x04002707 RID: 9991
		public const int SfxItemsVolumeFieldNumber = 9;

		// Token: 0x04002708 RID: 9992
		private static readonly int SfxItemsVolumeDefaultValue = 0;

		// Token: 0x04002709 RID: 9993
		private int sfxItemsVolume_;

		// Token: 0x0400270A RID: 9994
		public const int SfxMonsterVolumeFieldNumber = 10;

		// Token: 0x0400270B RID: 9995
		private static readonly int SfxMonsterVolumeDefaultValue = 0;

		// Token: 0x0400270C RID: 9996
		private int sfxMonsterVolume_;

		// Token: 0x0400270D RID: 9997
		public const int SfxPlayerSkillsVolumeFieldNumber = 11;

		// Token: 0x0400270E RID: 9998
		private static readonly int SfxPlayerSkillsVolumeDefaultValue = 0;

		// Token: 0x0400270F RID: 9999
		private int sfxPlayerSkillsVolume_;

		// Token: 0x04002710 RID: 10000
		public const int SfxAmbientMasterVolumeFieldNumber = 12;

		// Token: 0x04002711 RID: 10001
		private static readonly int SfxAmbientMasterVolumeDefaultValue = 0;

		// Token: 0x04002712 RID: 10002
		private int sfxAmbientMasterVolume_;

		// Token: 0x04002713 RID: 10003
		public const int SfxAmbientFootstepsVolumeFieldNumber = 13;

		// Token: 0x04002714 RID: 10004
		private static readonly int SfxAmbientFootstepsVolumeDefaultValue = 0;

		// Token: 0x04002715 RID: 10005
		private int sfxAmbientFootstepsVolume_;

		// Token: 0x04002716 RID: 10006
		public const int SfxAmbientFoleyVolumeFieldNumber = 14;

		// Token: 0x04002717 RID: 10007
		private static readonly int SfxAmbientFoleyVolumeDefaultValue = 0;

		// Token: 0x04002718 RID: 10008
		private int sfxAmbientFoleyVolume_;

		// Token: 0x04002719 RID: 10009
		public const int SfxAmbientObjectsVolumeFieldNumber = 15;

		// Token: 0x0400271A RID: 10010
		private static readonly int SfxAmbientObjectsVolumeDefaultValue = 0;

		// Token: 0x0400271B RID: 10011
		private int sfxAmbientObjectsVolume_;

		// Token: 0x0400271C RID: 10012
		public const int SfxAmbientEnvironmentVolumeFieldNumber = 16;

		// Token: 0x0400271D RID: 10013
		private static readonly int SfxAmbientEnvironmentVolumeDefaultValue = 0;

		// Token: 0x0400271E RID: 10014
		private int sfxAmbientEnvironmentVolume_;

		// Token: 0x0400271F RID: 10015
		public const int SfxCombatMasterVolumeFieldNumber = 17;

		// Token: 0x04002720 RID: 10016
		private static readonly int SfxCombatMasterVolumeDefaultValue = 0;

		// Token: 0x04002721 RID: 10017
		private int sfxCombatMasterVolume_;

		// Token: 0x04002722 RID: 10018
		public const int SfxCombatImpactsVolumeFieldNumber = 18;

		// Token: 0x04002723 RID: 10019
		private static readonly int SfxCombatImpactsVolumeDefaultValue = 0;

		// Token: 0x04002724 RID: 10020
		private int sfxCombatImpactsVolume_;

		// Token: 0x04002725 RID: 10021
		public const int SfxCombatWeaponVolumeFieldNumber = 19;

		// Token: 0x04002726 RID: 10022
		private static readonly int SfxCombatWeaponVolumeDefaultValue = 0;

		// Token: 0x04002727 RID: 10023
		private int sfxCombatWeaponVolume_;

		// Token: 0x04002728 RID: 10024
		public const int SfxCombatGoreVolumeFieldNumber = 20;

		// Token: 0x04002729 RID: 10025
		private static readonly int SfxCombatGoreVolumeDefaultValue = 0;

		// Token: 0x0400272A RID: 10026
		private int sfxCombatGoreVolume_;
	}
}
