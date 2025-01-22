using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200078E RID: 1934
	public sealed class GameCreateRequest : IMessage<GameCreateRequest>, IMessage, IEquatable<GameCreateRequest>, IDeepCloneable<GameCreateRequest>, IBufferMessage
	{
		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600B120 RID: 45344 RVA: 0x002B1BCC File Offset: 0x002AFDCC
		[DebuggerNonUserCode]
		public static MessageParser<GameCreateRequest> Parser
		{
			get
			{
				return GameCreateRequest._parser;
			}
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600B121 RID: 45345 RVA: 0x002B1BE4 File Offset: 0x002AFDE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600B122 RID: 45346 RVA: 0x002B1C08 File Offset: 0x002AFE08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameCreateRequest.Descriptor;
			}
		}

		// Token: 0x0600B123 RID: 45347 RVA: 0x002B1C1F File Offset: 0x002AFE1F
		[DebuggerNonUserCode]
		public GameCreateRequest()
		{
		}

		// Token: 0x0600B124 RID: 45348 RVA: 0x002B1C40 File Offset: 0x002AFE40
		[DebuggerNonUserCode]
		public GameCreateRequest(GameCreateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.charId_ = other.charId_;
			this.gameName_ = other.gameName_;
			this.gamePassword_ = other.gamePassword_;
			this.options_ = other.options_.Clone();
			this.neg1_ = other.neg1_;
			this.empty_ = other.empty_;
			this.pings_ = other.pings_.Clone();
			this.charLevel_ = other.charLevel_;
			this.levelDifference_ = other.levelDifference_;
			this.maxPlayers_ = other.maxPlayers_;
			this.flags_ = other.flags_;
			this.unk1_ = other.unk1_;
			this.unk2_ = other.unk2_;
			this.difficulty_ = other.difficulty_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B125 RID: 45349 RVA: 0x002B1D24 File Offset: 0x002AFF24
		[DebuggerNonUserCode]
		public GameCreateRequest Clone()
		{
			return new GameCreateRequest(this);
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600B126 RID: 45350 RVA: 0x002B1D3C File Offset: 0x002AFF3C
		// (set) Token: 0x0600B127 RID: 45351 RVA: 0x002B1D6D File Offset: 0x002AFF6D
		[DebuggerNonUserCode]
		public uint CharId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint charIdDefaultValue;
				if (flag)
				{
					charIdDefaultValue = this.charId_;
				}
				else
				{
					charIdDefaultValue = GameCreateRequest.CharIdDefaultValue;
				}
				return charIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.charId_ = value;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600B128 RID: 45352 RVA: 0x002B1D88 File Offset: 0x002AFF88
		[DebuggerNonUserCode]
		public bool HasCharId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x002B1DA5 File Offset: 0x002AFFA5
		[DebuggerNonUserCode]
		public void ClearCharId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600B12A RID: 45354 RVA: 0x002B1DB8 File Offset: 0x002AFFB8
		// (set) Token: 0x0600B12B RID: 45355 RVA: 0x002B1DD9 File Offset: 0x002AFFD9
		[DebuggerNonUserCode]
		public string GameName
		{
			get
			{
				return this.gameName_ ?? GameCreateRequest.GameNameDefaultValue;
			}
			set
			{
				this.gameName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600B12C RID: 45356 RVA: 0x002B1DF0 File Offset: 0x002AFFF0
		[DebuggerNonUserCode]
		public bool HasGameName
		{
			get
			{
				return this.gameName_ != null;
			}
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x002B1E0B File Offset: 0x002B000B
		[DebuggerNonUserCode]
		public void ClearGameName()
		{
			this.gameName_ = null;
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600B12E RID: 45358 RVA: 0x002B1E18 File Offset: 0x002B0018
		// (set) Token: 0x0600B12F RID: 45359 RVA: 0x002B1E39 File Offset: 0x002B0039
		[DebuggerNonUserCode]
		public string GamePassword
		{
			get
			{
				return this.gamePassword_ ?? GameCreateRequest.GamePasswordDefaultValue;
			}
			set
			{
				this.gamePassword_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600B130 RID: 45360 RVA: 0x002B1E50 File Offset: 0x002B0050
		[DebuggerNonUserCode]
		public bool HasGamePassword
		{
			get
			{
				return this.gamePassword_ != null;
			}
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x002B1E6B File Offset: 0x002B006B
		[DebuggerNonUserCode]
		public void ClearGamePassword()
		{
			this.gamePassword_ = null;
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600B132 RID: 45362 RVA: 0x002B1E78 File Offset: 0x002B0078
		[DebuggerNonUserCode]
		public RepeatedField<GameOption> Options
		{
			get
			{
				return this.options_;
			}
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600B133 RID: 45363 RVA: 0x002B1E90 File Offset: 0x002B0090
		// (set) Token: 0x0600B134 RID: 45364 RVA: 0x002B1EC1 File Offset: 0x002B00C1
		[DebuggerNonUserCode]
		public uint Neg1
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint neg1DefaultValue;
				if (flag)
				{
					neg1DefaultValue = this.neg1_;
				}
				else
				{
					neg1DefaultValue = GameCreateRequest.Neg1DefaultValue;
				}
				return neg1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.neg1_ = value;
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600B135 RID: 45365 RVA: 0x002B1EDC File Offset: 0x002B00DC
		[DebuggerNonUserCode]
		public bool HasNeg1
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x002B1EF9 File Offset: 0x002B00F9
		[DebuggerNonUserCode]
		public void ClearNeg1()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600B137 RID: 45367 RVA: 0x002B1F0C File Offset: 0x002B010C
		// (set) Token: 0x0600B138 RID: 45368 RVA: 0x002B1F2D File Offset: 0x002B012D
		[DebuggerNonUserCode]
		public string Empty
		{
			get
			{
				return this.empty_ ?? GameCreateRequest.EmptyDefaultValue;
			}
			set
			{
				this.empty_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600B139 RID: 45369 RVA: 0x002B1F44 File Offset: 0x002B0144
		[DebuggerNonUserCode]
		public bool HasEmpty
		{
			get
			{
				return this.empty_ != null;
			}
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x002B1F5F File Offset: 0x002B015F
		[DebuggerNonUserCode]
		public void ClearEmpty()
		{
			this.empty_ = null;
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600B13B RID: 45371 RVA: 0x002B1F6C File Offset: 0x002B016C
		[DebuggerNonUserCode]
		public RepeatedField<GameServerPing> Pings
		{
			get
			{
				return this.pings_;
			}
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0600B13C RID: 45372 RVA: 0x002B1F84 File Offset: 0x002B0184
		// (set) Token: 0x0600B13D RID: 45373 RVA: 0x002B1FB5 File Offset: 0x002B01B5
		[DebuggerNonUserCode]
		public uint CharLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint charLevelDefaultValue;
				if (flag)
				{
					charLevelDefaultValue = this.charLevel_;
				}
				else
				{
					charLevelDefaultValue = GameCreateRequest.CharLevelDefaultValue;
				}
				return charLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.charLevel_ = value;
			}
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600B13E RID: 45374 RVA: 0x002B1FD0 File Offset: 0x002B01D0
		[DebuggerNonUserCode]
		public bool HasCharLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x002B1FED File Offset: 0x002B01ED
		[DebuggerNonUserCode]
		public void ClearCharLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600B140 RID: 45376 RVA: 0x002B2000 File Offset: 0x002B0200
		// (set) Token: 0x0600B141 RID: 45377 RVA: 0x002B2031 File Offset: 0x002B0231
		[DebuggerNonUserCode]
		public uint LevelDifference
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint levelDifferenceDefaultValue;
				if (flag)
				{
					levelDifferenceDefaultValue = this.levelDifference_;
				}
				else
				{
					levelDifferenceDefaultValue = GameCreateRequest.LevelDifferenceDefaultValue;
				}
				return levelDifferenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.levelDifference_ = value;
			}
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600B142 RID: 45378 RVA: 0x002B204C File Offset: 0x002B024C
		[DebuggerNonUserCode]
		public bool HasLevelDifference
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x002B2069 File Offset: 0x002B0269
		[DebuggerNonUserCode]
		public void ClearLevelDifference()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600B144 RID: 45380 RVA: 0x002B207C File Offset: 0x002B027C
		// (set) Token: 0x0600B145 RID: 45381 RVA: 0x002B20AE File Offset: 0x002B02AE
		[DebuggerNonUserCode]
		public uint MaxPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint maxPlayersDefaultValue;
				if (flag)
				{
					maxPlayersDefaultValue = this.maxPlayers_;
				}
				else
				{
					maxPlayersDefaultValue = GameCreateRequest.MaxPlayersDefaultValue;
				}
				return maxPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.maxPlayers_ = value;
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600B146 RID: 45382 RVA: 0x002B20C8 File Offset: 0x002B02C8
		[DebuggerNonUserCode]
		public bool HasMaxPlayers
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x002B20E6 File Offset: 0x002B02E6
		[DebuggerNonUserCode]
		public void ClearMaxPlayers()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600B148 RID: 45384 RVA: 0x002B20F8 File Offset: 0x002B02F8
		// (set) Token: 0x0600B149 RID: 45385 RVA: 0x002B212A File Offset: 0x002B032A
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = GameCreateRequest.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.flags_ = value;
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600B14A RID: 45386 RVA: 0x002B2144 File Offset: 0x002B0344
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x002B2162 File Offset: 0x002B0362
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600B14C RID: 45388 RVA: 0x002B2174 File Offset: 0x002B0374
		// (set) Token: 0x0600B14D RID: 45389 RVA: 0x002B2195 File Offset: 0x002B0395
		[DebuggerNonUserCode]
		public string Unk1
		{
			get
			{
				return this.unk1_ ?? GameCreateRequest.Unk1DefaultValue;
			}
			set
			{
				this.unk1_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600B14E RID: 45390 RVA: 0x002B21AC File Offset: 0x002B03AC
		[DebuggerNonUserCode]
		public bool HasUnk1
		{
			get
			{
				return this.unk1_ != null;
			}
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x002B21C7 File Offset: 0x002B03C7
		[DebuggerNonUserCode]
		public void ClearUnk1()
		{
			this.unk1_ = null;
		}

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600B150 RID: 45392 RVA: 0x002B21D4 File Offset: 0x002B03D4
		// (set) Token: 0x0600B151 RID: 45393 RVA: 0x002B21F5 File Offset: 0x002B03F5
		[DebuggerNonUserCode]
		public string Unk2
		{
			get
			{
				return this.unk2_ ?? GameCreateRequest.Unk2DefaultValue;
			}
			set
			{
				this.unk2_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0600B152 RID: 45394 RVA: 0x002B220C File Offset: 0x002B040C
		[DebuggerNonUserCode]
		public bool HasUnk2
		{
			get
			{
				return this.unk2_ != null;
			}
		}

		// Token: 0x0600B153 RID: 45395 RVA: 0x002B2227 File Offset: 0x002B0427
		[DebuggerNonUserCode]
		public void ClearUnk2()
		{
			this.unk2_ = null;
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600B154 RID: 45396 RVA: 0x002B2234 File Offset: 0x002B0434
		// (set) Token: 0x0600B155 RID: 45397 RVA: 0x002B2266 File Offset: 0x002B0466
		[DebuggerNonUserCode]
		public uint Difficulty
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint difficultyDefaultValue;
				if (flag)
				{
					difficultyDefaultValue = this.difficulty_;
				}
				else
				{
					difficultyDefaultValue = GameCreateRequest.DifficultyDefaultValue;
				}
				return difficultyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.difficulty_ = value;
			}
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600B156 RID: 45398 RVA: 0x002B2280 File Offset: 0x002B0480
		[DebuggerNonUserCode]
		public bool HasDifficulty
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x002B229E File Offset: 0x002B049E
		[DebuggerNonUserCode]
		public void ClearDifficulty()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x002B22B0 File Offset: 0x002B04B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameCreateRequest);
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x002B22D0 File Offset: 0x002B04D0
		[DebuggerNonUserCode]
		public bool Equals(GameCreateRequest other)
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
					bool flag4 = this.CharId != other.CharId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameName != other.GameName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GamePassword != other.GamePassword;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.options_.Equals(other.options_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Neg1 != other.Neg1;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Empty != other.Empty;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.pings_.Equals(other.pings_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CharLevel != other.CharLevel;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.LevelDifference != other.LevelDifference;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.MaxPlayers != other.MaxPlayers;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Flags != other.Flags;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.Unk1 != other.Unk1;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.Unk2 != other.Unk2;
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = this.Difficulty != other.Difficulty;
																		flag2 = !flag17 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600B15A RID: 45402 RVA: 0x002B24B0 File Offset: 0x002B06B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				num ^= this.CharId.GetHashCode();
			}
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num ^= this.GameName.GetHashCode();
			}
			bool hasGamePassword = this.HasGamePassword;
			if (hasGamePassword)
			{
				num ^= this.GamePassword.GetHashCode();
			}
			num ^= this.options_.GetHashCode();
			bool hasNeg = this.HasNeg1;
			if (hasNeg)
			{
				num ^= this.Neg1.GetHashCode();
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				num ^= this.Empty.GetHashCode();
			}
			num ^= this.pings_.GetHashCode();
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				num ^= this.CharLevel.GetHashCode();
			}
			bool hasLevelDifference = this.HasLevelDifference;
			if (hasLevelDifference)
			{
				num ^= this.LevelDifference.GetHashCode();
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num ^= this.MaxPlayers.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool hasUnk = this.HasUnk1;
			if (hasUnk)
			{
				num ^= this.Unk1.GetHashCode();
			}
			bool hasUnk2 = this.HasUnk2;
			if (hasUnk2)
			{
				num ^= this.Unk2.GetHashCode();
			}
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				num ^= this.Difficulty.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x002B264C File Offset: 0x002B084C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x002B2664 File Offset: 0x002B0864
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x002B2670 File Offset: 0x002B0870
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CharId);
			}
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameName);
			}
			bool hasGamePassword = this.HasGamePassword;
			if (hasGamePassword)
			{
				output.WriteRawTag(26);
				output.WriteString(this.GamePassword);
			}
			this.options_.WriteTo(ref output, GameCreateRequest._repeated_options_codec);
			bool hasNeg = this.HasNeg1;
			if (hasNeg)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Neg1);
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Empty);
			}
			this.pings_.WriteTo(ref output, GameCreateRequest._repeated_pings_codec);
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.CharLevel);
			}
			bool hasLevelDifference = this.HasLevelDifference;
			if (hasLevelDifference)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.LevelDifference);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MaxPlayers);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Flags);
			}
			bool hasUnk = this.HasUnk1;
			if (hasUnk)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Unk1);
			}
			bool hasUnk2 = this.HasUnk2;
			if (hasUnk2)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Unk2);
			}
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Difficulty);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x002B2868 File Offset: 0x002B0A68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharId);
			}
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameName);
			}
			bool hasGamePassword = this.HasGamePassword;
			if (hasGamePassword)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GamePassword);
			}
			num += this.options_.CalculateSize(GameCreateRequest._repeated_options_codec);
			bool hasNeg = this.HasNeg1;
			if (hasNeg)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Neg1);
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Empty);
			}
			num += this.pings_.CalculateSize(GameCreateRequest._repeated_pings_codec);
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharLevel);
			}
			bool hasLevelDifference = this.HasLevelDifference;
			if (hasLevelDifference)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelDifference);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPlayers);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			bool hasUnk = this.HasUnk1;
			if (hasUnk)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Unk1);
			}
			bool hasUnk2 = this.HasUnk2;
			if (hasUnk2)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Unk2);
			}
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Difficulty);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x002B2A28 File Offset: 0x002B0C28
		[DebuggerNonUserCode]
		public void MergeFrom(GameCreateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCharId = other.HasCharId;
				if (hasCharId)
				{
					this.CharId = other.CharId;
				}
				bool hasGameName = other.HasGameName;
				if (hasGameName)
				{
					this.GameName = other.GameName;
				}
				bool hasGamePassword = other.HasGamePassword;
				if (hasGamePassword)
				{
					this.GamePassword = other.GamePassword;
				}
				this.options_.Add(other.options_);
				bool hasNeg = other.HasNeg1;
				if (hasNeg)
				{
					this.Neg1 = other.Neg1;
				}
				bool hasEmpty = other.HasEmpty;
				if (hasEmpty)
				{
					this.Empty = other.Empty;
				}
				this.pings_.Add(other.pings_);
				bool hasCharLevel = other.HasCharLevel;
				if (hasCharLevel)
				{
					this.CharLevel = other.CharLevel;
				}
				bool hasLevelDifference = other.HasLevelDifference;
				if (hasLevelDifference)
				{
					this.LevelDifference = other.LevelDifference;
				}
				bool hasMaxPlayers = other.HasMaxPlayers;
				if (hasMaxPlayers)
				{
					this.MaxPlayers = other.MaxPlayers;
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				bool hasUnk = other.HasUnk1;
				if (hasUnk)
				{
					this.Unk1 = other.Unk1;
				}
				bool hasUnk2 = other.HasUnk2;
				if (hasUnk2)
				{
					this.Unk2 = other.Unk2;
				}
				bool hasDifficulty = other.HasDifficulty;
				if (hasDifficulty)
				{
					this.Difficulty = other.Difficulty;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x002B2BBD File Offset: 0x002B0DBD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x002B2BC8 File Offset: 0x002B0DC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 58U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_00AF;
								}
								this.GamePassword = input.ReadString();
							}
							else
							{
								this.GameName = input.ReadString();
							}
						}
						else
						{
							this.CharId = input.ReadUInt32();
						}
					}
					else if (num3 <= 40U)
					{
						if (num3 != 34U)
						{
							if (num3 != 40U)
							{
								goto IL_00AF;
							}
							this.Neg1 = input.ReadUInt32();
						}
						else
						{
							this.options_.AddEntriesFrom(ref input, GameCreateRequest._repeated_options_codec);
						}
					}
					else if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_00AF;
						}
						this.pings_.AddEntriesFrom(ref input, GameCreateRequest._repeated_pings_codec);
					}
					else
					{
						this.Empty = input.ReadString();
					}
				}
				else if (num3 <= 80U)
				{
					if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							if (num3 != 80U)
							{
								goto IL_00AF;
							}
							this.MaxPlayers = input.ReadUInt32();
						}
						else
						{
							this.LevelDifference = input.ReadUInt32();
						}
					}
					else
					{
						this.CharLevel = input.ReadUInt32();
					}
				}
				else if (num3 <= 98U)
				{
					if (num3 != 88U)
					{
						if (num3 != 98U)
						{
							goto IL_00AF;
						}
						this.Unk1 = input.ReadString();
					}
					else
					{
						this.Flags = input.ReadUInt32();
					}
				}
				else if (num3 != 106U)
				{
					if (num3 != 112U)
					{
						goto IL_00AF;
					}
					this.Difficulty = input.ReadUInt32();
				}
				else
				{
					this.Unk2 = input.ReadString();
				}
				continue;
				IL_00AF:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004FD6 RID: 20438
		private static readonly MessageParser<GameCreateRequest> _parser = new MessageParser<GameCreateRequest>(() => new GameCreateRequest());

		// Token: 0x04004FD7 RID: 20439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FD8 RID: 20440
		private int _hasBits0;

		// Token: 0x04004FD9 RID: 20441
		public const int CharIdFieldNumber = 1;

		// Token: 0x04004FDA RID: 20442
		private static readonly uint CharIdDefaultValue = 0U;

		// Token: 0x04004FDB RID: 20443
		private uint charId_;

		// Token: 0x04004FDC RID: 20444
		public const int GameNameFieldNumber = 2;

		// Token: 0x04004FDD RID: 20445
		private static readonly string GameNameDefaultValue = "";

		// Token: 0x04004FDE RID: 20446
		private string gameName_;

		// Token: 0x04004FDF RID: 20447
		public const int GamePasswordFieldNumber = 3;

		// Token: 0x04004FE0 RID: 20448
		private static readonly string GamePasswordDefaultValue = "";

		// Token: 0x04004FE1 RID: 20449
		private string gamePassword_;

		// Token: 0x04004FE2 RID: 20450
		public const int OptionsFieldNumber = 4;

		// Token: 0x04004FE3 RID: 20451
		private static readonly FieldCodec<GameOption> _repeated_options_codec = FieldCodec.ForMessage<GameOption>(34U, GameOption.Parser);

		// Token: 0x04004FE4 RID: 20452
		private readonly RepeatedField<GameOption> options_ = new RepeatedField<GameOption>();

		// Token: 0x04004FE5 RID: 20453
		public const int Neg1FieldNumber = 5;

		// Token: 0x04004FE6 RID: 20454
		private static readonly uint Neg1DefaultValue = 0U;

		// Token: 0x04004FE7 RID: 20455
		private uint neg1_;

		// Token: 0x04004FE8 RID: 20456
		public const int EmptyFieldNumber = 6;

		// Token: 0x04004FE9 RID: 20457
		private static readonly string EmptyDefaultValue = "";

		// Token: 0x04004FEA RID: 20458
		private string empty_;

		// Token: 0x04004FEB RID: 20459
		public const int PingsFieldNumber = 7;

		// Token: 0x04004FEC RID: 20460
		private static readonly FieldCodec<GameServerPing> _repeated_pings_codec = FieldCodec.ForMessage<GameServerPing>(58U, GameServerPing.Parser);

		// Token: 0x04004FED RID: 20461
		private readonly RepeatedField<GameServerPing> pings_ = new RepeatedField<GameServerPing>();

		// Token: 0x04004FEE RID: 20462
		public const int CharLevelFieldNumber = 8;

		// Token: 0x04004FEF RID: 20463
		private static readonly uint CharLevelDefaultValue = 0U;

		// Token: 0x04004FF0 RID: 20464
		private uint charLevel_;

		// Token: 0x04004FF1 RID: 20465
		public const int LevelDifferenceFieldNumber = 9;

		// Token: 0x04004FF2 RID: 20466
		private static readonly uint LevelDifferenceDefaultValue = 0U;

		// Token: 0x04004FF3 RID: 20467
		private uint levelDifference_;

		// Token: 0x04004FF4 RID: 20468
		public const int MaxPlayersFieldNumber = 10;

		// Token: 0x04004FF5 RID: 20469
		private static readonly uint MaxPlayersDefaultValue = 0U;

		// Token: 0x04004FF6 RID: 20470
		private uint maxPlayers_;

		// Token: 0x04004FF7 RID: 20471
		public const int FlagsFieldNumber = 11;

		// Token: 0x04004FF8 RID: 20472
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x04004FF9 RID: 20473
		private uint flags_;

		// Token: 0x04004FFA RID: 20474
		public const int Unk1FieldNumber = 12;

		// Token: 0x04004FFB RID: 20475
		private static readonly string Unk1DefaultValue = "";

		// Token: 0x04004FFC RID: 20476
		private string unk1_;

		// Token: 0x04004FFD RID: 20477
		public const int Unk2FieldNumber = 13;

		// Token: 0x04004FFE RID: 20478
		private static readonly string Unk2DefaultValue = "";

		// Token: 0x04004FFF RID: 20479
		private string unk2_;

		// Token: 0x04005000 RID: 20480
		public const int DifficultyFieldNumber = 14;

		// Token: 0x04005001 RID: 20481
		private static readonly uint DifficultyDefaultValue = 0U;

		// Token: 0x04005002 RID: 20482
		private uint difficulty_;
	}
}
