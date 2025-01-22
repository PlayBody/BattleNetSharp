using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200017C RID: 380
	public sealed class Digest : IMessage<Digest>, IMessage, IEquatable<Digest>, IDeepCloneable<Digest>, IBufferMessage
	{
		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x0009A99C File Offset: 0x00098B9C
		[DebuggerNonUserCode]
		public static MessageParser<Digest> Parser
		{
			get
			{
				return Digest._parser;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x0009A9B4 File Offset: 0x00098BB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x0009A9D8 File Offset: 0x00098BD8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Digest.Descriptor;
			}
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x0009A9EF File Offset: 0x00098BEF
		[DebuggerNonUserCode]
		public Digest()
		{
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x0009A9FC File Offset: 0x00098BFC
		[DebuggerNonUserCode]
		public Digest(Digest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.heroId_ = other.heroId_;
			this.heroName_ = other.heroName_;
			this.snoClass_ = other.snoClass_;
			this.level_ = other.level_;
			this.playerFlags_ = other.playerFlags_;
			this.visualEquipment_ = ((other.visualEquipment_ != null) ? other.visualEquipment_.Clone() : null);
			this.lastPlayedQuest_ = other.lastPlayedQuest_;
			this.lastPlayedQuestStep_ = other.lastPlayedQuestStep_;
			this.timePlayed_ = other.timePlayed_;
			this.createTime_ = other.createTime_;
			this.lastPlayedTime_ = other.lastPlayedTime_;
			this.deleteTime_ = other.deleteTime_;
			this.appearanceCustomization_ = ((other.appearanceCustomization_ != null) ? other.appearanceCustomization_.Clone() : null);
			this.lastPlace_ = ((other.lastPlace_ != null) ? other.lastPlace_.Clone() : null);
			this.seasonCreated_ = other.seasonCreated_;
			this.lastWorldTier_ = other.lastWorldTier_;
			this.maxWorldTier_ = other.maxWorldTier_;
			this.heroNameForceRenamed_ = other.heroNameForceRenamed_;
			this.reportedHeroName_ = other.reportedHeroName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x0009AB50 File Offset: 0x00098D50
		[DebuggerNonUserCode]
		public Digest Clone()
		{
			return new Digest(this);
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x0009AB68 File Offset: 0x00098D68
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x0009AB99 File Offset: 0x00098D99
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = Digest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x0009ABB4 File Offset: 0x00098DB4
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0009ABD1 File Offset: 0x00098DD1
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x0009ABE4 File Offset: 0x00098DE4
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x0009AC05 File Offset: 0x00098E05
		[DebuggerNonUserCode]
		public ByteString HeroId
		{
			get
			{
				return this.heroId_ ?? Digest.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x0009AC1C File Offset: 0x00098E1C
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x0009AC3A File Offset: 0x00098E3A
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x0009AC44 File Offset: 0x00098E44
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x0009AC65 File Offset: 0x00098E65
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? Digest.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x0009AC7C File Offset: 0x00098E7C
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0009AC97 File Offset: 0x00098E97
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x0009ACA4 File Offset: 0x00098EA4
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x0009ACD5 File Offset: 0x00098ED5
		[DebuggerNonUserCode]
		public int SnoClass
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoClassDefaultValue;
				if (flag)
				{
					snoClassDefaultValue = this.snoClass_;
				}
				else
				{
					snoClassDefaultValue = Digest.SnoClassDefaultValue;
				}
				return snoClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoClass_ = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x0009ACF0 File Offset: 0x00098EF0
		[DebuggerNonUserCode]
		public bool HasSnoClass
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0009AD0D File Offset: 0x00098F0D
		[DebuggerNonUserCode]
		public void ClearSnoClass()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x0009AD20 File Offset: 0x00098F20
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x0009AD51 File Offset: 0x00098F51
		[DebuggerNonUserCode]
		public int Level
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int levelDefaultValue;
				if (flag)
				{
					levelDefaultValue = this.level_;
				}
				else
				{
					levelDefaultValue = Digest.LevelDefaultValue;
				}
				return levelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.level_ = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x0009AD6C File Offset: 0x00098F6C
		[DebuggerNonUserCode]
		public bool HasLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0009AD89 File Offset: 0x00098F89
		[DebuggerNonUserCode]
		public void ClearLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x0009AD9C File Offset: 0x00098F9C
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x0009ADCD File Offset: 0x00098FCD
		[DebuggerNonUserCode]
		public uint PlayerFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint playerFlagsDefaultValue;
				if (flag)
				{
					playerFlagsDefaultValue = this.playerFlags_;
				}
				else
				{
					playerFlagsDefaultValue = Digest.PlayerFlagsDefaultValue;
				}
				return playerFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.playerFlags_ = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x0009ADE8 File Offset: 0x00098FE8
		[DebuggerNonUserCode]
		public bool HasPlayerFlags
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0009AE05 File Offset: 0x00099005
		[DebuggerNonUserCode]
		public void ClearPlayerFlags()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x0009AE18 File Offset: 0x00099018
		// (set) Token: 0x060027B1 RID: 10161 RVA: 0x0009AE30 File Offset: 0x00099030
		[DebuggerNonUserCode]
		public VisualEquipment VisualEquipment
		{
			get
			{
				return this.visualEquipment_;
			}
			set
			{
				this.visualEquipment_ = value;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x0009AE3C File Offset: 0x0009903C
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x0009AE6E File Offset: 0x0009906E
		[DebuggerNonUserCode]
		public int LastPlayedQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int lastPlayedQuestDefaultValue;
				if (flag)
				{
					lastPlayedQuestDefaultValue = this.lastPlayedQuest_;
				}
				else
				{
					lastPlayedQuestDefaultValue = Digest.LastPlayedQuestDefaultValue;
				}
				return lastPlayedQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.lastPlayedQuest_ = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x0009AE88 File Offset: 0x00099088
		[DebuggerNonUserCode]
		public bool HasLastPlayedQuest
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0009AEA6 File Offset: 0x000990A6
		[DebuggerNonUserCode]
		public void ClearLastPlayedQuest()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0009AEB8 File Offset: 0x000990B8
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x0009AEEA File Offset: 0x000990EA
		[DebuggerNonUserCode]
		public int LastPlayedQuestStep
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int lastPlayedQuestStepDefaultValue;
				if (flag)
				{
					lastPlayedQuestStepDefaultValue = this.lastPlayedQuestStep_;
				}
				else
				{
					lastPlayedQuestStepDefaultValue = Digest.LastPlayedQuestStepDefaultValue;
				}
				return lastPlayedQuestStepDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.lastPlayedQuestStep_ = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x0009AF04 File Offset: 0x00099104
		[DebuggerNonUserCode]
		public bool HasLastPlayedQuestStep
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x0009AF22 File Offset: 0x00099122
		[DebuggerNonUserCode]
		public void ClearLastPlayedQuestStep()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0009AF34 File Offset: 0x00099134
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x0009AF66 File Offset: 0x00099166
		[DebuggerNonUserCode]
		public uint TimePlayed
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint timePlayedDefaultValue;
				if (flag)
				{
					timePlayedDefaultValue = this.timePlayed_;
				}
				else
				{
					timePlayedDefaultValue = Digest.TimePlayedDefaultValue;
				}
				return timePlayedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.timePlayed_ = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x0009AF80 File Offset: 0x00099180
		[DebuggerNonUserCode]
		public bool HasTimePlayed
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0009AF9E File Offset: 0x0009919E
		[DebuggerNonUserCode]
		public void ClearTimePlayed()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x0009AFB0 File Offset: 0x000991B0
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x0009AFE5 File Offset: 0x000991E5
		[DebuggerNonUserCode]
		public uint CreateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint createTimeDefaultValue;
				if (flag)
				{
					createTimeDefaultValue = this.createTime_;
				}
				else
				{
					createTimeDefaultValue = Digest.CreateTimeDefaultValue;
				}
				return createTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.createTime_ = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0009B004 File Offset: 0x00099204
		[DebuggerNonUserCode]
		public bool HasCreateTime
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0009B025 File Offset: 0x00099225
		[DebuggerNonUserCode]
		public void ClearCreateTime()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x0009B03C File Offset: 0x0009923C
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x0009B071 File Offset: 0x00099271
		[DebuggerNonUserCode]
		public uint LastPlayedTime
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint lastPlayedTimeDefaultValue;
				if (flag)
				{
					lastPlayedTimeDefaultValue = this.lastPlayedTime_;
				}
				else
				{
					lastPlayedTimeDefaultValue = Digest.LastPlayedTimeDefaultValue;
				}
				return lastPlayedTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.lastPlayedTime_ = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x0009B090 File Offset: 0x00099290
		[DebuggerNonUserCode]
		public bool HasLastPlayedTime
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0009B0B1 File Offset: 0x000992B1
		[DebuggerNonUserCode]
		public void ClearLastPlayedTime()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0009B0C8 File Offset: 0x000992C8
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x0009B0FD File Offset: 0x000992FD
		[DebuggerNonUserCode]
		public ulong DeleteTime
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				ulong deleteTimeDefaultValue;
				if (flag)
				{
					deleteTimeDefaultValue = this.deleteTime_;
				}
				else
				{
					deleteTimeDefaultValue = Digest.DeleteTimeDefaultValue;
				}
				return deleteTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.deleteTime_ = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0009B11C File Offset: 0x0009931C
		[DebuggerNonUserCode]
		public bool HasDeleteTime
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0009B13D File Offset: 0x0009933D
		[DebuggerNonUserCode]
		public void ClearDeleteTime()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x0009B154 File Offset: 0x00099354
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x0009B16C File Offset: 0x0009936C
		[DebuggerNonUserCode]
		public AppearanceCustomization AppearanceCustomization
		{
			get
			{
				return this.appearanceCustomization_;
			}
			set
			{
				this.appearanceCustomization_ = value;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0009B178 File Offset: 0x00099378
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x0009B190 File Offset: 0x00099390
		[DebuggerNonUserCode]
		public SavedDigestPlace LastPlace
		{
			get
			{
				return this.lastPlace_;
			}
			set
			{
				this.lastPlace_ = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x0009B19C File Offset: 0x0009939C
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x0009B1D1 File Offset: 0x000993D1
		[DebuggerNonUserCode]
		public uint SeasonCreated
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint seasonCreatedDefaultValue;
				if (flag)
				{
					seasonCreatedDefaultValue = this.seasonCreated_;
				}
				else
				{
					seasonCreatedDefaultValue = Digest.SeasonCreatedDefaultValue;
				}
				return seasonCreatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.seasonCreated_ = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x0009B1F0 File Offset: 0x000993F0
		[DebuggerNonUserCode]
		public bool HasSeasonCreated
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0009B211 File Offset: 0x00099411
		[DebuggerNonUserCode]
		public void ClearSeasonCreated()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x0009B228 File Offset: 0x00099428
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x0009B25D File Offset: 0x0009945D
		[DebuggerNonUserCode]
		public int LastWorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				int lastWorldTierDefaultValue;
				if (flag)
				{
					lastWorldTierDefaultValue = this.lastWorldTier_;
				}
				else
				{
					lastWorldTierDefaultValue = Digest.LastWorldTierDefaultValue;
				}
				return lastWorldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.lastWorldTier_ = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x0009B27C File Offset: 0x0009947C
		[DebuggerNonUserCode]
		public bool HasLastWorldTier
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x0009B29D File Offset: 0x0009949D
		[DebuggerNonUserCode]
		public void ClearLastWorldTier()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x0009B2B4 File Offset: 0x000994B4
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x0009B2E9 File Offset: 0x000994E9
		[DebuggerNonUserCode]
		public int MaxWorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				int maxWorldTierDefaultValue;
				if (flag)
				{
					maxWorldTierDefaultValue = this.maxWorldTier_;
				}
				else
				{
					maxWorldTierDefaultValue = Digest.MaxWorldTierDefaultValue;
				}
				return maxWorldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.maxWorldTier_ = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x0009B308 File Offset: 0x00099508
		[DebuggerNonUserCode]
		public bool HasMaxWorldTier
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0009B329 File Offset: 0x00099529
		[DebuggerNonUserCode]
		public void ClearMaxWorldTier()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x0009B340 File Offset: 0x00099540
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x0009B375 File Offset: 0x00099575
		[DebuggerNonUserCode]
		public bool HeroNameForceRenamed
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				bool heroNameForceRenamedDefaultValue;
				if (flag)
				{
					heroNameForceRenamedDefaultValue = this.heroNameForceRenamed_;
				}
				else
				{
					heroNameForceRenamedDefaultValue = Digest.HeroNameForceRenamedDefaultValue;
				}
				return heroNameForceRenamedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.heroNameForceRenamed_ = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x0009B394 File Offset: 0x00099594
		[DebuggerNonUserCode]
		public bool HasHeroNameForceRenamed
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x0009B3B5 File Offset: 0x000995B5
		[DebuggerNonUserCode]
		public void ClearHeroNameForceRenamed()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x0009B3CC File Offset: 0x000995CC
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x0009B3ED File Offset: 0x000995ED
		[DebuggerNonUserCode]
		public string ReportedHeroName
		{
			get
			{
				return this.reportedHeroName_ ?? Digest.ReportedHeroNameDefaultValue;
			}
			set
			{
				this.reportedHeroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x0009B404 File Offset: 0x00099604
		[DebuggerNonUserCode]
		public bool HasReportedHeroName
		{
			get
			{
				return this.reportedHeroName_ != null;
			}
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x0009B41F File Offset: 0x0009961F
		[DebuggerNonUserCode]
		public void ClearReportedHeroName()
		{
			this.reportedHeroName_ = null;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x0009B42C File Offset: 0x0009962C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Digest);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x0009B44C File Offset: 0x0009964C
		[DebuggerNonUserCode]
		public bool Equals(Digest other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HeroId != other.HeroId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HeroName != other.HeroName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoClass != other.SnoClass;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Level != other.Level;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PlayerFlags != other.PlayerFlags;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.VisualEquipment, other.VisualEquipment);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.LastPlayedQuest != other.LastPlayedQuest;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.LastPlayedQuestStep != other.LastPlayedQuestStep;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.TimePlayed != other.TimePlayed;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.CreateTime != other.CreateTime;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.LastPlayedTime != other.LastPlayedTime;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.DeleteTime != other.DeleteTime;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !object.Equals(this.AppearanceCustomization, other.AppearanceCustomization);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !object.Equals(this.LastPlace, other.LastPlace);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = this.SeasonCreated != other.SeasonCreated;
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.LastWorldTier != other.LastWorldTier;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.MaxWorldTier != other.MaxWorldTier;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.HeroNameForceRenamed != other.HeroNameForceRenamed;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.ReportedHeroName != other.ReportedHeroName;
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

		// Token: 0x060027E4 RID: 10212 RVA: 0x0009B6E4 File Offset: 0x000998E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				num ^= this.SnoClass.GetHashCode();
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num ^= this.Level.GetHashCode();
			}
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				num ^= this.PlayerFlags.GetHashCode();
			}
			bool flag = this.visualEquipment_ != null;
			if (flag)
			{
				num ^= this.VisualEquipment.GetHashCode();
			}
			bool hasLastPlayedQuest = this.HasLastPlayedQuest;
			if (hasLastPlayedQuest)
			{
				num ^= this.LastPlayedQuest.GetHashCode();
			}
			bool hasLastPlayedQuestStep = this.HasLastPlayedQuestStep;
			if (hasLastPlayedQuestStep)
			{
				num ^= this.LastPlayedQuestStep.GetHashCode();
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num ^= this.TimePlayed.GetHashCode();
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			bool hasLastPlayedTime = this.HasLastPlayedTime;
			if (hasLastPlayedTime)
			{
				num ^= this.LastPlayedTime.GetHashCode();
			}
			bool hasDeleteTime = this.HasDeleteTime;
			if (hasDeleteTime)
			{
				num ^= this.DeleteTime.GetHashCode();
			}
			bool flag2 = this.appearanceCustomization_ != null;
			if (flag2)
			{
				num ^= this.AppearanceCustomization.GetHashCode();
			}
			bool flag3 = this.lastPlace_ != null;
			if (flag3)
			{
				num ^= this.LastPlace.GetHashCode();
			}
			bool hasSeasonCreated = this.HasSeasonCreated;
			if (hasSeasonCreated)
			{
				num ^= this.SeasonCreated.GetHashCode();
			}
			bool hasLastWorldTier = this.HasLastWorldTier;
			if (hasLastWorldTier)
			{
				num ^= this.LastWorldTier.GetHashCode();
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				num ^= this.MaxWorldTier.GetHashCode();
			}
			bool hasHeroNameForceRenamed = this.HasHeroNameForceRenamed;
			if (hasHeroNameForceRenamed)
			{
				num ^= this.HeroNameForceRenamed.GetHashCode();
			}
			bool hasReportedHeroName = this.HasReportedHeroName;
			if (hasReportedHeroName)
			{
				num ^= this.ReportedHeroName.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0009B95C File Offset: 0x00099B5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x0009B974 File Offset: 0x00099B74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0009B980 File Offset: 0x00099B80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Version);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.HeroId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.HeroName);
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				output.WriteRawTag(37);
				output.WriteSFixed32(this.SnoClass);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				output.WriteRawTag(40);
				output.WriteSInt32(this.Level);
			}
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PlayerFlags);
			}
			bool flag = this.visualEquipment_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.VisualEquipment);
			}
			bool hasLastPlayedQuest = this.HasLastPlayedQuest;
			if (hasLastPlayedQuest)
			{
				output.WriteRawTag(109);
				output.WriteSFixed32(this.LastPlayedQuest);
			}
			bool hasLastPlayedQuestStep = this.HasLastPlayedQuestStep;
			if (hasLastPlayedQuestStep)
			{
				output.WriteRawTag(112);
				output.WriteSInt32(this.LastPlayedQuestStep);
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.TimePlayed);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt32(this.CreateTime);
			}
			bool hasLastPlayedTime = this.HasLastPlayedTime;
			if (hasLastPlayedTime)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.LastPlayedTime);
			}
			bool hasDeleteTime = this.HasDeleteTime;
			if (hasDeleteTime)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt64(this.DeleteTime);
			}
			bool flag2 = this.appearanceCustomization_ != null;
			if (flag2)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.AppearanceCustomization);
			}
			bool flag3 = this.lastPlace_ != null;
			if (flag3)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.LastPlace);
			}
			bool hasSeasonCreated = this.HasSeasonCreated;
			if (hasSeasonCreated)
			{
				output.WriteRawTag(176, 1);
				output.WriteUInt32(this.SeasonCreated);
			}
			bool hasLastWorldTier = this.HasLastWorldTier;
			if (hasLastWorldTier)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.LastWorldTier);
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt32(this.MaxWorldTier);
			}
			bool hasHeroNameForceRenamed = this.HasHeroNameForceRenamed;
			if (hasHeroNameForceRenamed)
			{
				output.WriteRawTag(200, 1);
				output.WriteBool(this.HeroNameForceRenamed);
			}
			bool hasReportedHeroName = this.HasReportedHeroName;
			if (hasReportedHeroName)
			{
				output.WriteRawTag(210, 1);
				output.WriteString(this.ReportedHeroName);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x0009BCA4 File Offset: 0x00099EA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.HeroId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool hasSnoClass = this.HasSnoClass;
			if (hasSnoClass)
			{
				num += 5;
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Level);
			}
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayerFlags);
			}
			bool flag = this.visualEquipment_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VisualEquipment);
			}
			bool hasLastPlayedQuest = this.HasLastPlayedQuest;
			if (hasLastPlayedQuest)
			{
				num += 5;
			}
			bool hasLastPlayedQuestStep = this.HasLastPlayedQuestStep;
			if (hasLastPlayedQuestStep)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.LastPlayedQuestStep);
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimePlayed);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.CreateTime);
			}
			bool hasLastPlayedTime = this.HasLastPlayedTime;
			if (hasLastPlayedTime)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.LastPlayedTime);
			}
			bool hasDeleteTime = this.HasDeleteTime;
			if (hasDeleteTime)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.DeleteTime);
			}
			bool flag2 = this.appearanceCustomization_ != null;
			if (flag2)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AppearanceCustomization);
			}
			bool flag3 = this.lastPlace_ != null;
			if (flag3)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LastPlace);
			}
			bool hasSeasonCreated = this.HasSeasonCreated;
			if (hasSeasonCreated)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SeasonCreated);
			}
			bool hasLastWorldTier = this.HasLastWorldTier;
			if (hasLastWorldTier)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.LastWorldTier);
			}
			bool hasMaxWorldTier = this.HasMaxWorldTier;
			if (hasMaxWorldTier)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxWorldTier);
			}
			bool hasHeroNameForceRenamed = this.HasHeroNameForceRenamed;
			if (hasHeroNameForceRenamed)
			{
				num += 3;
			}
			bool hasReportedHeroName = this.HasReportedHeroName;
			if (hasReportedHeroName)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ReportedHeroName);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x0009BF14 File Offset: 0x0009A114
		[DebuggerNonUserCode]
		public void MergeFrom(Digest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				bool hasSnoClass = other.HasSnoClass;
				if (hasSnoClass)
				{
					this.SnoClass = other.SnoClass;
				}
				bool hasLevel = other.HasLevel;
				if (hasLevel)
				{
					this.Level = other.Level;
				}
				bool hasPlayerFlags = other.HasPlayerFlags;
				if (hasPlayerFlags)
				{
					this.PlayerFlags = other.PlayerFlags;
				}
				bool flag2 = other.visualEquipment_ != null;
				if (flag2)
				{
					bool flag3 = this.visualEquipment_ == null;
					if (flag3)
					{
						this.VisualEquipment = new VisualEquipment();
					}
					this.VisualEquipment.MergeFrom(other.VisualEquipment);
				}
				bool hasLastPlayedQuest = other.HasLastPlayedQuest;
				if (hasLastPlayedQuest)
				{
					this.LastPlayedQuest = other.LastPlayedQuest;
				}
				bool hasLastPlayedQuestStep = other.HasLastPlayedQuestStep;
				if (hasLastPlayedQuestStep)
				{
					this.LastPlayedQuestStep = other.LastPlayedQuestStep;
				}
				bool hasTimePlayed = other.HasTimePlayed;
				if (hasTimePlayed)
				{
					this.TimePlayed = other.TimePlayed;
				}
				bool hasCreateTime = other.HasCreateTime;
				if (hasCreateTime)
				{
					this.CreateTime = other.CreateTime;
				}
				bool hasLastPlayedTime = other.HasLastPlayedTime;
				if (hasLastPlayedTime)
				{
					this.LastPlayedTime = other.LastPlayedTime;
				}
				bool hasDeleteTime = other.HasDeleteTime;
				if (hasDeleteTime)
				{
					this.DeleteTime = other.DeleteTime;
				}
				bool flag4 = other.appearanceCustomization_ != null;
				if (flag4)
				{
					bool flag5 = this.appearanceCustomization_ == null;
					if (flag5)
					{
						this.AppearanceCustomization = new AppearanceCustomization();
					}
					this.AppearanceCustomization.MergeFrom(other.AppearanceCustomization);
				}
				bool flag6 = other.lastPlace_ != null;
				if (flag6)
				{
					bool flag7 = this.lastPlace_ == null;
					if (flag7)
					{
						this.LastPlace = new SavedDigestPlace();
					}
					this.LastPlace.MergeFrom(other.LastPlace);
				}
				bool hasSeasonCreated = other.HasSeasonCreated;
				if (hasSeasonCreated)
				{
					this.SeasonCreated = other.SeasonCreated;
				}
				bool hasLastWorldTier = other.HasLastWorldTier;
				if (hasLastWorldTier)
				{
					this.LastWorldTier = other.LastWorldTier;
				}
				bool hasMaxWorldTier = other.HasMaxWorldTier;
				if (hasMaxWorldTier)
				{
					this.MaxWorldTier = other.MaxWorldTier;
				}
				bool hasHeroNameForceRenamed = other.HasHeroNameForceRenamed;
				if (hasHeroNameForceRenamed)
				{
					this.HeroNameForceRenamed = other.HeroNameForceRenamed;
				}
				bool hasReportedHeroName = other.HasReportedHeroName;
				if (hasReportedHeroName)
				{
					this.ReportedHeroName = other.ReportedHeroName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x0009C1CC File Offset: 0x0009A3CC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x0009C1D8 File Offset: 0x0009A3D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 120U)
				{
					if (num3 <= 40U)
					{
						if (num3 <= 18U)
						{
							if (num3 != 8U)
							{
								if (num3 != 18U)
								{
									goto IL_0128;
								}
								this.HeroId = input.ReadBytes();
							}
							else
							{
								this.Version = input.ReadUInt32();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 37U)
							{
								if (num3 != 40U)
								{
									goto IL_0128;
								}
								this.Level = input.ReadSInt32();
							}
							else
							{
								this.SnoClass = input.ReadSFixed32();
							}
						}
						else
						{
							this.HeroName = input.ReadString();
						}
					}
					else if (num3 <= 58U)
					{
						if (num3 != 48U)
						{
							if (num3 != 58U)
							{
								goto IL_0128;
							}
							bool flag = this.visualEquipment_ == null;
							if (flag)
							{
								this.VisualEquipment = new VisualEquipment();
							}
							input.ReadMessage(this.VisualEquipment);
						}
						else
						{
							this.PlayerFlags = input.ReadUInt32();
						}
					}
					else if (num3 != 109U)
					{
						if (num3 != 112U)
						{
							if (num3 != 120U)
							{
								goto IL_0128;
							}
							this.TimePlayed = input.ReadUInt32();
						}
						else
						{
							this.LastPlayedQuestStep = input.ReadSInt32();
						}
					}
					else
					{
						this.LastPlayedQuest = input.ReadSFixed32();
					}
				}
				else if (num3 <= 170U)
				{
					if (num3 <= 144U)
					{
						if (num3 != 136U)
						{
							if (num3 != 144U)
							{
								goto IL_0128;
							}
							this.LastPlayedTime = input.ReadUInt32();
						}
						else
						{
							this.CreateTime = input.ReadUInt32();
						}
					}
					else if (num3 != 152U)
					{
						if (num3 != 162U)
						{
							if (num3 != 170U)
							{
								goto IL_0128;
							}
							bool flag2 = this.lastPlace_ == null;
							if (flag2)
							{
								this.LastPlace = new SavedDigestPlace();
							}
							input.ReadMessage(this.LastPlace);
						}
						else
						{
							bool flag3 = this.appearanceCustomization_ == null;
							if (flag3)
							{
								this.AppearanceCustomization = new AppearanceCustomization();
							}
							input.ReadMessage(this.AppearanceCustomization);
						}
					}
					else
					{
						this.DeleteTime = input.ReadUInt64();
					}
				}
				else if (num3 <= 184U)
				{
					if (num3 != 176U)
					{
						if (num3 != 184U)
						{
							goto IL_0128;
						}
						this.LastWorldTier = input.ReadInt32();
					}
					else
					{
						this.SeasonCreated = input.ReadUInt32();
					}
				}
				else if (num3 != 192U)
				{
					if (num3 != 200U)
					{
						if (num3 != 210U)
						{
							goto IL_0128;
						}
						this.ReportedHeroName = input.ReadString();
					}
					else
					{
						this.HeroNameForceRenamed = input.ReadBool();
					}
				}
				else
				{
					this.MaxWorldTier = input.ReadInt32();
				}
				continue;
				IL_0128:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400118D RID: 4493
		private static readonly MessageParser<Digest> _parser = new MessageParser<Digest>(() => new Digest());

		// Token: 0x0400118E RID: 4494
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400118F RID: 4495
		private int _hasBits0;

		// Token: 0x04001190 RID: 4496
		public const int VersionFieldNumber = 1;

		// Token: 0x04001191 RID: 4497
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04001192 RID: 4498
		private uint version_;

		// Token: 0x04001193 RID: 4499
		public const int HeroIdFieldNumber = 2;

		// Token: 0x04001194 RID: 4500
		private static readonly ByteString HeroIdDefaultValue = ByteString.Empty;

		// Token: 0x04001195 RID: 4501
		private ByteString heroId_;

		// Token: 0x04001196 RID: 4502
		public const int HeroNameFieldNumber = 3;

		// Token: 0x04001197 RID: 4503
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x04001198 RID: 4504
		private string heroName_;

		// Token: 0x04001199 RID: 4505
		public const int SnoClassFieldNumber = 4;

		// Token: 0x0400119A RID: 4506
		private static readonly int SnoClassDefaultValue = -1;

		// Token: 0x0400119B RID: 4507
		private int snoClass_;

		// Token: 0x0400119C RID: 4508
		public const int LevelFieldNumber = 5;

		// Token: 0x0400119D RID: 4509
		private static readonly int LevelDefaultValue = 0;

		// Token: 0x0400119E RID: 4510
		private int level_;

		// Token: 0x0400119F RID: 4511
		public const int PlayerFlagsFieldNumber = 6;

		// Token: 0x040011A0 RID: 4512
		private static readonly uint PlayerFlagsDefaultValue = 0U;

		// Token: 0x040011A1 RID: 4513
		private uint playerFlags_;

		// Token: 0x040011A2 RID: 4514
		public const int VisualEquipmentFieldNumber = 7;

		// Token: 0x040011A3 RID: 4515
		private VisualEquipment visualEquipment_;

		// Token: 0x040011A4 RID: 4516
		public const int LastPlayedQuestFieldNumber = 13;

		// Token: 0x040011A5 RID: 4517
		private static readonly int LastPlayedQuestDefaultValue = 0;

		// Token: 0x040011A6 RID: 4518
		private int lastPlayedQuest_;

		// Token: 0x040011A7 RID: 4519
		public const int LastPlayedQuestStepFieldNumber = 14;

		// Token: 0x040011A8 RID: 4520
		private static readonly int LastPlayedQuestStepDefaultValue = 0;

		// Token: 0x040011A9 RID: 4521
		private int lastPlayedQuestStep_;

		// Token: 0x040011AA RID: 4522
		public const int TimePlayedFieldNumber = 15;

		// Token: 0x040011AB RID: 4523
		private static readonly uint TimePlayedDefaultValue = 0U;

		// Token: 0x040011AC RID: 4524
		private uint timePlayed_;

		// Token: 0x040011AD RID: 4525
		public const int CreateTimeFieldNumber = 17;

		// Token: 0x040011AE RID: 4526
		private static readonly uint CreateTimeDefaultValue = 0U;

		// Token: 0x040011AF RID: 4527
		private uint createTime_;

		// Token: 0x040011B0 RID: 4528
		public const int LastPlayedTimeFieldNumber = 18;

		// Token: 0x040011B1 RID: 4529
		private static readonly uint LastPlayedTimeDefaultValue = 0U;

		// Token: 0x040011B2 RID: 4530
		private uint lastPlayedTime_;

		// Token: 0x040011B3 RID: 4531
		public const int DeleteTimeFieldNumber = 19;

		// Token: 0x040011B4 RID: 4532
		private static readonly ulong DeleteTimeDefaultValue = 0UL;

		// Token: 0x040011B5 RID: 4533
		private ulong deleteTime_;

		// Token: 0x040011B6 RID: 4534
		public const int AppearanceCustomizationFieldNumber = 20;

		// Token: 0x040011B7 RID: 4535
		private AppearanceCustomization appearanceCustomization_;

		// Token: 0x040011B8 RID: 4536
		public const int LastPlaceFieldNumber = 21;

		// Token: 0x040011B9 RID: 4537
		private SavedDigestPlace lastPlace_;

		// Token: 0x040011BA RID: 4538
		public const int SeasonCreatedFieldNumber = 22;

		// Token: 0x040011BB RID: 4539
		private static readonly uint SeasonCreatedDefaultValue = 0U;

		// Token: 0x040011BC RID: 4540
		private uint seasonCreated_;

		// Token: 0x040011BD RID: 4541
		public const int LastWorldTierFieldNumber = 23;

		// Token: 0x040011BE RID: 4542
		private static readonly int LastWorldTierDefaultValue = 0;

		// Token: 0x040011BF RID: 4543
		private int lastWorldTier_;

		// Token: 0x040011C0 RID: 4544
		public const int MaxWorldTierFieldNumber = 24;

		// Token: 0x040011C1 RID: 4545
		private static readonly int MaxWorldTierDefaultValue = 1;

		// Token: 0x040011C2 RID: 4546
		private int maxWorldTier_;

		// Token: 0x040011C3 RID: 4547
		public const int HeroNameForceRenamedFieldNumber = 25;

		// Token: 0x040011C4 RID: 4548
		private static readonly bool HeroNameForceRenamedDefaultValue = false;

		// Token: 0x040011C5 RID: 4549
		private bool heroNameForceRenamed_;

		// Token: 0x040011C6 RID: 4550
		public const int ReportedHeroNameFieldNumber = 26;

		// Token: 0x040011C7 RID: 4551
		private static readonly string ReportedHeroNameDefaultValue = "";

		// Token: 0x040011C8 RID: 4552
		private string reportedHeroName_;
	}
}
