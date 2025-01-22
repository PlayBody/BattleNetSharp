using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000038 RID: 56
	public sealed class GameModeSettings : IMessage<GameModeSettings>, IMessage, IEquatable<GameModeSettings>, IDeepCloneable<GameModeSettings>, IBufferMessage
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001449C File Offset: 0x0001269C
		[DebuggerNonUserCode]
		public static MessageParser<GameModeSettings> Parser
		{
			get
			{
				return GameModeSettings._parser;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000144B4 File Offset: 0x000126B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[33];
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000144D8 File Offset: 0x000126D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameModeSettings.Descriptor;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000144EF File Offset: 0x000126EF
		[DebuggerNonUserCode]
		public GameModeSettings()
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00014504 File Offset: 0x00012704
		[DebuggerNonUserCode]
		public GameModeSettings(GameModeSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.startLocationInfo_ = ((other.startLocationInfo_ != null) ? other.startLocationInfo_.Clone() : null);
			this.simulateRealGame_ = other.simulateRealGame_;
			this.noReload_ = other.noReload_;
			this.joinLocalLanServer_ = other.joinLocalLanServer_;
			this.worldSeed_ = other.worldSeed_;
			this.dungeonStatesOverridden_ = other.dungeonStatesOverridden_;
			this.dungeonStates_ = other.dungeonStates_.Clone();
			this.clearExistingStartLocationOverrides_ = other.clearExistingStartLocationOverrides_;
			this.worldTier_ = other.worldTier_;
			this.automated_ = other.automated_;
			this.forceHardcore_ = other.forceHardcore_;
			this.forceSeasonal_ = other.forceSeasonal_;
			this.restoreVariousSettingsFromLocalHeroSave_ = other.restoreVariousSettingsFromLocalHeroSave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000145E8 File Offset: 0x000127E8
		[DebuggerNonUserCode]
		public GameModeSettings Clone()
		{
			return new GameModeSettings(this);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00014600 File Offset: 0x00012800
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00014618 File Offset: 0x00012818
		[DebuggerNonUserCode]
		public StartInfo StartLocationInfo
		{
			get
			{
				return this.startLocationInfo_;
			}
			set
			{
				this.startLocationInfo_ = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00014624 File Offset: 0x00012824
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00014655 File Offset: 0x00012855
		[DebuggerNonUserCode]
		public bool SimulateRealGame
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool simulateRealGameDefaultValue;
				if (flag)
				{
					simulateRealGameDefaultValue = this.simulateRealGame_;
				}
				else
				{
					simulateRealGameDefaultValue = GameModeSettings.SimulateRealGameDefaultValue;
				}
				return simulateRealGameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.simulateRealGame_ = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00014670 File Offset: 0x00012870
		[DebuggerNonUserCode]
		public bool HasSimulateRealGame
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001468D File Offset: 0x0001288D
		[DebuggerNonUserCode]
		public void ClearSimulateRealGame()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x000146A0 File Offset: 0x000128A0
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x000146D1 File Offset: 0x000128D1
		[DebuggerNonUserCode]
		public bool NoReload
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool noReloadDefaultValue;
				if (flag)
				{
					noReloadDefaultValue = this.noReload_;
				}
				else
				{
					noReloadDefaultValue = GameModeSettings.NoReloadDefaultValue;
				}
				return noReloadDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.noReload_ = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000146EC File Offset: 0x000128EC
		[DebuggerNonUserCode]
		public bool HasNoReload
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00014709 File Offset: 0x00012909
		[DebuggerNonUserCode]
		public void ClearNoReload()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001471C File Offset: 0x0001291C
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x0001474D File Offset: 0x0001294D
		[DebuggerNonUserCode]
		public bool JoinLocalLanServer
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool joinLocalLanServerDefaultValue;
				if (flag)
				{
					joinLocalLanServerDefaultValue = this.joinLocalLanServer_;
				}
				else
				{
					joinLocalLanServerDefaultValue = GameModeSettings.JoinLocalLanServerDefaultValue;
				}
				return joinLocalLanServerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.joinLocalLanServer_ = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00014768 File Offset: 0x00012968
		[DebuggerNonUserCode]
		public bool HasJoinLocalLanServer
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00014785 File Offset: 0x00012985
		[DebuggerNonUserCode]
		public void ClearJoinLocalLanServer()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00014798 File Offset: 0x00012998
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x000147C9 File Offset: 0x000129C9
		[DebuggerNonUserCode]
		public int WorldSeed
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int worldSeedDefaultValue;
				if (flag)
				{
					worldSeedDefaultValue = this.worldSeed_;
				}
				else
				{
					worldSeedDefaultValue = GameModeSettings.WorldSeedDefaultValue;
				}
				return worldSeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.worldSeed_ = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000147E4 File Offset: 0x000129E4
		[DebuggerNonUserCode]
		public bool HasWorldSeed
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00014801 File Offset: 0x00012A01
		[DebuggerNonUserCode]
		public void ClearWorldSeed()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00014814 File Offset: 0x00012A14
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00014846 File Offset: 0x00012A46
		[DebuggerNonUserCode]
		public bool DungeonStatesOverridden
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool dungeonStatesOverriddenDefaultValue;
				if (flag)
				{
					dungeonStatesOverriddenDefaultValue = this.dungeonStatesOverridden_;
				}
				else
				{
					dungeonStatesOverriddenDefaultValue = GameModeSettings.DungeonStatesOverriddenDefaultValue;
				}
				return dungeonStatesOverriddenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.dungeonStatesOverridden_ = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00014860 File Offset: 0x00012A60
		[DebuggerNonUserCode]
		public bool HasDungeonStatesOverridden
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001487E File Offset: 0x00012A7E
		[DebuggerNonUserCode]
		public void ClearDungeonStatesOverridden()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00014890 File Offset: 0x00012A90
		[DebuggerNonUserCode]
		public RepeatedField<uint> DungeonStates
		{
			get
			{
				return this.dungeonStates_;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x000148A8 File Offset: 0x00012AA8
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000148DA File Offset: 0x00012ADA
		[DebuggerNonUserCode]
		public bool ClearExistingStartLocationOverrides
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool clearExistingStartLocationOverridesDefaultValue;
				if (flag)
				{
					clearExistingStartLocationOverridesDefaultValue = this.clearExistingStartLocationOverrides_;
				}
				else
				{
					clearExistingStartLocationOverridesDefaultValue = GameModeSettings.ClearExistingStartLocationOverridesDefaultValue;
				}
				return clearExistingStartLocationOverridesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.clearExistingStartLocationOverrides_ = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000148F4 File Offset: 0x00012AF4
		[DebuggerNonUserCode]
		public bool HasClearExistingStartLocationOverrides
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00014912 File Offset: 0x00012B12
		[DebuggerNonUserCode]
		public void ClearClearExistingStartLocationOverrides()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00014924 File Offset: 0x00012B24
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00014956 File Offset: 0x00012B56
		[DebuggerNonUserCode]
		public int WorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int worldTierDefaultValue;
				if (flag)
				{
					worldTierDefaultValue = this.worldTier_;
				}
				else
				{
					worldTierDefaultValue = GameModeSettings.WorldTierDefaultValue;
				}
				return worldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.worldTier_ = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00014970 File Offset: 0x00012B70
		[DebuggerNonUserCode]
		public bool HasWorldTier
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001498E File Offset: 0x00012B8E
		[DebuggerNonUserCode]
		public void ClearWorldTier()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x000149A0 File Offset: 0x00012BA0
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x000149D5 File Offset: 0x00012BD5
		[DebuggerNonUserCode]
		public bool Automated
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool automatedDefaultValue;
				if (flag)
				{
					automatedDefaultValue = this.automated_;
				}
				else
				{
					automatedDefaultValue = GameModeSettings.AutomatedDefaultValue;
				}
				return automatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.automated_ = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x000149F4 File Offset: 0x00012BF4
		[DebuggerNonUserCode]
		public bool HasAutomated
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00014A15 File Offset: 0x00012C15
		[DebuggerNonUserCode]
		public void ClearAutomated()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00014A2C File Offset: 0x00012C2C
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00014A61 File Offset: 0x00012C61
		[DebuggerNonUserCode]
		public bool ForceHardcore
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool forceHardcoreDefaultValue;
				if (flag)
				{
					forceHardcoreDefaultValue = this.forceHardcore_;
				}
				else
				{
					forceHardcoreDefaultValue = GameModeSettings.ForceHardcoreDefaultValue;
				}
				return forceHardcoreDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.forceHardcore_ = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00014A80 File Offset: 0x00012C80
		[DebuggerNonUserCode]
		public bool HasForceHardcore
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00014AA1 File Offset: 0x00012CA1
		[DebuggerNonUserCode]
		public void ClearForceHardcore()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00014AB8 File Offset: 0x00012CB8
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00014AED File Offset: 0x00012CED
		[DebuggerNonUserCode]
		public bool ForceSeasonal
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				bool forceSeasonalDefaultValue;
				if (flag)
				{
					forceSeasonalDefaultValue = this.forceSeasonal_;
				}
				else
				{
					forceSeasonalDefaultValue = GameModeSettings.ForceSeasonalDefaultValue;
				}
				return forceSeasonalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.forceSeasonal_ = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00014B0C File Offset: 0x00012D0C
		[DebuggerNonUserCode]
		public bool HasForceSeasonal
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00014B2D File Offset: 0x00012D2D
		[DebuggerNonUserCode]
		public void ClearForceSeasonal()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00014B44 File Offset: 0x00012D44
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00014B79 File Offset: 0x00012D79
		[DebuggerNonUserCode]
		public bool RestoreVariousSettingsFromLocalHeroSave
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				bool restoreVariousSettingsFromLocalHeroSaveDefaultValue;
				if (flag)
				{
					restoreVariousSettingsFromLocalHeroSaveDefaultValue = this.restoreVariousSettingsFromLocalHeroSave_;
				}
				else
				{
					restoreVariousSettingsFromLocalHeroSaveDefaultValue = GameModeSettings.RestoreVariousSettingsFromLocalHeroSaveDefaultValue;
				}
				return restoreVariousSettingsFromLocalHeroSaveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.restoreVariousSettingsFromLocalHeroSave_ = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00014B98 File Offset: 0x00012D98
		[DebuggerNonUserCode]
		public bool HasRestoreVariousSettingsFromLocalHeroSave
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00014BB9 File Offset: 0x00012DB9
		[DebuggerNonUserCode]
		public void ClearRestoreVariousSettingsFromLocalHeroSave()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00014BD0 File Offset: 0x00012DD0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameModeSettings);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00014BF0 File Offset: 0x00012DF0
		[DebuggerNonUserCode]
		public bool Equals(GameModeSettings other)
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
					bool flag4 = !object.Equals(this.StartLocationInfo, other.StartLocationInfo);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SimulateRealGame != other.SimulateRealGame;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.NoReload != other.NoReload;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.JoinLocalLanServer != other.JoinLocalLanServer;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.WorldSeed != other.WorldSeed;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.DungeonStatesOverridden != other.DungeonStatesOverridden;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.dungeonStates_.Equals(other.dungeonStates_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ClearExistingStartLocationOverrides != other.ClearExistingStartLocationOverrides;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.WorldTier != other.WorldTier;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Automated != other.Automated;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.ForceHardcore != other.ForceHardcore;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.ForceSeasonal != other.ForceSeasonal;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.RestoreVariousSettingsFromLocalHeroSave != other.RestoreVariousSettingsFromLocalHeroSave;
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600043D RID: 1085 RVA: 0x00014DB4 File Offset: 0x00012FB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.startLocationInfo_ != null;
			if (flag)
			{
				num ^= this.StartLocationInfo.GetHashCode();
			}
			bool hasSimulateRealGame = this.HasSimulateRealGame;
			if (hasSimulateRealGame)
			{
				num ^= this.SimulateRealGame.GetHashCode();
			}
			bool hasNoReload = this.HasNoReload;
			if (hasNoReload)
			{
				num ^= this.NoReload.GetHashCode();
			}
			bool hasJoinLocalLanServer = this.HasJoinLocalLanServer;
			if (hasJoinLocalLanServer)
			{
				num ^= this.JoinLocalLanServer.GetHashCode();
			}
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				num ^= this.WorldSeed.GetHashCode();
			}
			bool hasDungeonStatesOverridden = this.HasDungeonStatesOverridden;
			if (hasDungeonStatesOverridden)
			{
				num ^= this.DungeonStatesOverridden.GetHashCode();
			}
			num ^= this.dungeonStates_.GetHashCode();
			bool hasClearExistingStartLocationOverrides = this.HasClearExistingStartLocationOverrides;
			if (hasClearExistingStartLocationOverrides)
			{
				num ^= this.ClearExistingStartLocationOverrides.GetHashCode();
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num ^= this.WorldTier.GetHashCode();
			}
			bool hasAutomated = this.HasAutomated;
			if (hasAutomated)
			{
				num ^= this.Automated.GetHashCode();
			}
			bool hasForceHardcore = this.HasForceHardcore;
			if (hasForceHardcore)
			{
				num ^= this.ForceHardcore.GetHashCode();
			}
			bool hasForceSeasonal = this.HasForceSeasonal;
			if (hasForceSeasonal)
			{
				num ^= this.ForceSeasonal.GetHashCode();
			}
			bool hasRestoreVariousSettingsFromLocalHeroSave = this.HasRestoreVariousSettingsFromLocalHeroSave;
			if (hasRestoreVariousSettingsFromLocalHeroSave)
			{
				num ^= this.RestoreVariousSettingsFromLocalHeroSave.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00014F54 File Offset: 0x00013154
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00014F6C File Offset: 0x0001316C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00014F78 File Offset: 0x00013178
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.startLocationInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.StartLocationInfo);
			}
			bool hasSimulateRealGame = this.HasSimulateRealGame;
			if (hasSimulateRealGame)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.SimulateRealGame);
			}
			bool hasNoReload = this.HasNoReload;
			if (hasNoReload)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NoReload);
			}
			bool hasJoinLocalLanServer = this.HasJoinLocalLanServer;
			if (hasJoinLocalLanServer)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.JoinLocalLanServer);
			}
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WorldSeed);
			}
			bool hasDungeonStatesOverridden = this.HasDungeonStatesOverridden;
			if (hasDungeonStatesOverridden)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.DungeonStatesOverridden);
			}
			this.dungeonStates_.WriteTo(ref output, GameModeSettings._repeated_dungeonStates_codec);
			bool hasClearExistingStartLocationOverrides = this.HasClearExistingStartLocationOverrides;
			if (hasClearExistingStartLocationOverrides)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ClearExistingStartLocationOverrides);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WorldTier);
			}
			bool hasAutomated = this.HasAutomated;
			if (hasAutomated)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Automated);
			}
			bool hasForceHardcore = this.HasForceHardcore;
			if (hasForceHardcore)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.ForceHardcore);
			}
			bool hasForceSeasonal = this.HasForceSeasonal;
			if (hasForceSeasonal)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ForceSeasonal);
			}
			bool hasRestoreVariousSettingsFromLocalHeroSave = this.HasRestoreVariousSettingsFromLocalHeroSave;
			if (hasRestoreVariousSettingsFromLocalHeroSave)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.RestoreVariousSettingsFromLocalHeroSave);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00015164 File Offset: 0x00013364
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.startLocationInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StartLocationInfo);
			}
			bool hasSimulateRealGame = this.HasSimulateRealGame;
			if (hasSimulateRealGame)
			{
				num += 2;
			}
			bool hasNoReload = this.HasNoReload;
			if (hasNoReload)
			{
				num += 2;
			}
			bool hasJoinLocalLanServer = this.HasJoinLocalLanServer;
			if (hasJoinLocalLanServer)
			{
				num += 2;
			}
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldSeed);
			}
			bool hasDungeonStatesOverridden = this.HasDungeonStatesOverridden;
			if (hasDungeonStatesOverridden)
			{
				num += 2;
			}
			num += this.dungeonStates_.CalculateSize(GameModeSettings._repeated_dungeonStates_codec);
			bool hasClearExistingStartLocationOverrides = this.HasClearExistingStartLocationOverrides;
			if (hasClearExistingStartLocationOverrides)
			{
				num += 2;
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldTier);
			}
			bool hasAutomated = this.HasAutomated;
			if (hasAutomated)
			{
				num += 2;
			}
			bool hasForceHardcore = this.HasForceHardcore;
			if (hasForceHardcore)
			{
				num += 2;
			}
			bool hasForceSeasonal = this.HasForceSeasonal;
			if (hasForceSeasonal)
			{
				num += 2;
			}
			bool hasRestoreVariousSettingsFromLocalHeroSave = this.HasRestoreVariousSettingsFromLocalHeroSave;
			if (hasRestoreVariousSettingsFromLocalHeroSave)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000152A8 File Offset: 0x000134A8
		[DebuggerNonUserCode]
		public void MergeFrom(GameModeSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.startLocationInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.startLocationInfo_ == null;
					if (flag3)
					{
						this.StartLocationInfo = new StartInfo();
					}
					this.StartLocationInfo.MergeFrom(other.StartLocationInfo);
				}
				bool hasSimulateRealGame = other.HasSimulateRealGame;
				if (hasSimulateRealGame)
				{
					this.SimulateRealGame = other.SimulateRealGame;
				}
				bool hasNoReload = other.HasNoReload;
				if (hasNoReload)
				{
					this.NoReload = other.NoReload;
				}
				bool hasJoinLocalLanServer = other.HasJoinLocalLanServer;
				if (hasJoinLocalLanServer)
				{
					this.JoinLocalLanServer = other.JoinLocalLanServer;
				}
				bool hasWorldSeed = other.HasWorldSeed;
				if (hasWorldSeed)
				{
					this.WorldSeed = other.WorldSeed;
				}
				bool hasDungeonStatesOverridden = other.HasDungeonStatesOverridden;
				if (hasDungeonStatesOverridden)
				{
					this.DungeonStatesOverridden = other.DungeonStatesOverridden;
				}
				this.dungeonStates_.Add(other.dungeonStates_);
				bool hasClearExistingStartLocationOverrides = other.HasClearExistingStartLocationOverrides;
				if (hasClearExistingStartLocationOverrides)
				{
					this.ClearExistingStartLocationOverrides = other.ClearExistingStartLocationOverrides;
				}
				bool hasWorldTier = other.HasWorldTier;
				if (hasWorldTier)
				{
					this.WorldTier = other.WorldTier;
				}
				bool hasAutomated = other.HasAutomated;
				if (hasAutomated)
				{
					this.Automated = other.Automated;
				}
				bool hasForceHardcore = other.HasForceHardcore;
				if (hasForceHardcore)
				{
					this.ForceHardcore = other.ForceHardcore;
				}
				bool hasForceSeasonal = other.HasForceSeasonal;
				if (hasForceSeasonal)
				{
					this.ForceSeasonal = other.ForceSeasonal;
				}
				bool hasRestoreVariousSettingsFromLocalHeroSave = other.HasRestoreVariousSettingsFromLocalHeroSave;
				if (hasRestoreVariousSettingsFromLocalHeroSave)
				{
					this.RestoreVariousSettingsFromLocalHeroSave = other.RestoreVariousSettingsFromLocalHeroSave;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00015450 File Offset: 0x00013650
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001545C File Offset: 0x0001365C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 56U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								if (num3 != 24U)
								{
									goto IL_00B0;
								}
								this.NoReload = input.ReadBool();
							}
							else
							{
								this.SimulateRealGame = input.ReadBool();
							}
						}
						else
						{
							bool flag = this.startLocationInfo_ == null;
							if (flag)
							{
								this.StartLocationInfo = new StartInfo();
							}
							input.ReadMessage(this.StartLocationInfo);
						}
					}
					else if (num3 <= 40U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_00B0;
							}
							this.WorldSeed = input.ReadInt32();
						}
						else
						{
							this.JoinLocalLanServer = input.ReadBool();
						}
					}
					else if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_00B0;
						}
						goto IL_0151;
					}
					else
					{
						this.DungeonStatesOverridden = input.ReadBool();
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 == 58U)
					{
						goto IL_0151;
					}
					if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							goto IL_00B0;
						}
						this.WorldTier = input.ReadInt32();
					}
					else
					{
						this.ClearExistingStartLocationOverrides = input.ReadBool();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_00B0;
						}
						this.ForceHardcore = input.ReadBool();
					}
					else
					{
						this.Automated = input.ReadBool();
					}
				}
				else if (num3 != 96U)
				{
					if (num3 != 104U)
					{
						goto IL_00B0;
					}
					this.RestoreVariousSettingsFromLocalHeroSave = input.ReadBool();
				}
				else
				{
					this.ForceSeasonal = input.ReadBool();
				}
				continue;
				IL_00B0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_0151:
				this.dungeonStates_.AddEntriesFrom(ref input, GameModeSettings._repeated_dungeonStates_codec);
			}
		}

		// Token: 0x040001A9 RID: 425
		private static readonly MessageParser<GameModeSettings> _parser = new MessageParser<GameModeSettings>(() => new GameModeSettings());

		// Token: 0x040001AA RID: 426
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001AB RID: 427
		private int _hasBits0;

		// Token: 0x040001AC RID: 428
		public const int StartLocationInfoFieldNumber = 1;

		// Token: 0x040001AD RID: 429
		private StartInfo startLocationInfo_;

		// Token: 0x040001AE RID: 430
		public const int SimulateRealGameFieldNumber = 2;

		// Token: 0x040001AF RID: 431
		private static readonly bool SimulateRealGameDefaultValue = false;

		// Token: 0x040001B0 RID: 432
		private bool simulateRealGame_;

		// Token: 0x040001B1 RID: 433
		public const int NoReloadFieldNumber = 3;

		// Token: 0x040001B2 RID: 434
		private static readonly bool NoReloadDefaultValue = false;

		// Token: 0x040001B3 RID: 435
		private bool noReload_;

		// Token: 0x040001B4 RID: 436
		public const int JoinLocalLanServerFieldNumber = 4;

		// Token: 0x040001B5 RID: 437
		private static readonly bool JoinLocalLanServerDefaultValue = false;

		// Token: 0x040001B6 RID: 438
		private bool joinLocalLanServer_;

		// Token: 0x040001B7 RID: 439
		public const int WorldSeedFieldNumber = 5;

		// Token: 0x040001B8 RID: 440
		private static readonly int WorldSeedDefaultValue = 0;

		// Token: 0x040001B9 RID: 441
		private int worldSeed_;

		// Token: 0x040001BA RID: 442
		public const int DungeonStatesOverriddenFieldNumber = 6;

		// Token: 0x040001BB RID: 443
		private static readonly bool DungeonStatesOverriddenDefaultValue = false;

		// Token: 0x040001BC RID: 444
		private bool dungeonStatesOverridden_;

		// Token: 0x040001BD RID: 445
		public const int DungeonStatesFieldNumber = 7;

		// Token: 0x040001BE RID: 446
		private static readonly FieldCodec<uint> _repeated_dungeonStates_codec = FieldCodec.ForUInt32(56U);

		// Token: 0x040001BF RID: 447
		private readonly RepeatedField<uint> dungeonStates_ = new RepeatedField<uint>();

		// Token: 0x040001C0 RID: 448
		public const int ClearExistingStartLocationOverridesFieldNumber = 8;

		// Token: 0x040001C1 RID: 449
		private static readonly bool ClearExistingStartLocationOverridesDefaultValue = false;

		// Token: 0x040001C2 RID: 450
		private bool clearExistingStartLocationOverrides_;

		// Token: 0x040001C3 RID: 451
		public const int WorldTierFieldNumber = 9;

		// Token: 0x040001C4 RID: 452
		private static readonly int WorldTierDefaultValue = 0;

		// Token: 0x040001C5 RID: 453
		private int worldTier_;

		// Token: 0x040001C6 RID: 454
		public const int AutomatedFieldNumber = 10;

		// Token: 0x040001C7 RID: 455
		private static readonly bool AutomatedDefaultValue = false;

		// Token: 0x040001C8 RID: 456
		private bool automated_;

		// Token: 0x040001C9 RID: 457
		public const int ForceHardcoreFieldNumber = 11;

		// Token: 0x040001CA RID: 458
		private static readonly bool ForceHardcoreDefaultValue = false;

		// Token: 0x040001CB RID: 459
		private bool forceHardcore_;

		// Token: 0x040001CC RID: 460
		public const int ForceSeasonalFieldNumber = 12;

		// Token: 0x040001CD RID: 461
		private static readonly bool ForceSeasonalDefaultValue = false;

		// Token: 0x040001CE RID: 462
		private bool forceSeasonal_;

		// Token: 0x040001CF RID: 463
		public const int RestoreVariousSettingsFromLocalHeroSaveFieldNumber = 13;

		// Token: 0x040001D0 RID: 464
		private static readonly bool RestoreVariousSettingsFromLocalHeroSaveDefaultValue = false;

		// Token: 0x040001D1 RID: 465
		private bool restoreVariousSettingsFromLocalHeroSave_;
	}
}
