using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000327 RID: 807
	public sealed class GameContext : IMessage<GameContext>, IMessage, IEquatable<GameContext>, IDeepCloneable<GameContext>, IBufferMessage
	{
		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x00145DD8 File Offset: 0x00143FD8
		[DebuggerNonUserCode]
		public static MessageParser<GameContext> Parser
		{
			get
			{
				return GameContext._parser;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x0600545B RID: 21595 RVA: 0x00145DF0 File Offset: 0x00143FF0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonGameContextReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x0600545C RID: 21596 RVA: 0x00145E14 File Offset: 0x00144014
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameContext.Descriptor;
			}
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x00145E2B File Offset: 0x0014402B
		[DebuggerNonUserCode]
		public GameContext()
		{
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x00145E38 File Offset: 0x00144038
		[DebuggerNonUserCode]
		public GameContext(GameContext other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameType_ = other.gameType_;
			this.gameDifficulty_ = other.gameDifficulty_;
			this.isExpansion_ = other.isExpansion_;
			this.isLadder_ = other.isLadder_;
			this.completedGame_ = other.completedGame_;
			this.completingAct_ = other.completingAct_;
			this.presetName_ = other.presetName_;
			this.inFrontend_ = other.inFrontend_;
			this.currentLevel_ = ((other.currentLevel_ != null) ? other.currentLevel_.Clone() : null);
			this.playerX_ = other.playerX_;
			this.playerY_ = other.playerY_;
			this.gameSeed_ = other.gameSeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x00145F0C File Offset: 0x0014410C
		[DebuggerNonUserCode]
		public GameContext Clone()
		{
			return new GameContext(this);
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06005460 RID: 21600 RVA: 0x00145F24 File Offset: 0x00144124
		// (set) Token: 0x06005461 RID: 21601 RVA: 0x00145F45 File Offset: 0x00144145
		[DebuggerNonUserCode]
		public string GameType
		{
			get
			{
				return this.gameType_ ?? GameContext.GameTypeDefaultValue;
			}
			set
			{
				this.gameType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06005462 RID: 21602 RVA: 0x00145F5C File Offset: 0x0014415C
		[DebuggerNonUserCode]
		public bool HasGameType
		{
			get
			{
				return this.gameType_ != null;
			}
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x00145F77 File Offset: 0x00144177
		[DebuggerNonUserCode]
		public void ClearGameType()
		{
			this.gameType_ = null;
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06005464 RID: 21604 RVA: 0x00145F84 File Offset: 0x00144184
		// (set) Token: 0x06005465 RID: 21605 RVA: 0x00145FA5 File Offset: 0x001441A5
		[DebuggerNonUserCode]
		public string GameDifficulty
		{
			get
			{
				return this.gameDifficulty_ ?? GameContext.GameDifficultyDefaultValue;
			}
			set
			{
				this.gameDifficulty_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x00145FBC File Offset: 0x001441BC
		[DebuggerNonUserCode]
		public bool HasGameDifficulty
		{
			get
			{
				return this.gameDifficulty_ != null;
			}
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x00145FD7 File Offset: 0x001441D7
		[DebuggerNonUserCode]
		public void ClearGameDifficulty()
		{
			this.gameDifficulty_ = null;
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x00145FE4 File Offset: 0x001441E4
		// (set) Token: 0x06005469 RID: 21609 RVA: 0x00146015 File Offset: 0x00144215
		[DebuggerNonUserCode]
		public bool IsExpansion
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isExpansionDefaultValue;
				if (flag)
				{
					isExpansionDefaultValue = this.isExpansion_;
				}
				else
				{
					isExpansionDefaultValue = GameContext.IsExpansionDefaultValue;
				}
				return isExpansionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isExpansion_ = value;
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x00146030 File Offset: 0x00144230
		[DebuggerNonUserCode]
		public bool HasIsExpansion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x0014604D File Offset: 0x0014424D
		[DebuggerNonUserCode]
		public void ClearIsExpansion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x0600546C RID: 21612 RVA: 0x00146060 File Offset: 0x00144260
		// (set) Token: 0x0600546D RID: 21613 RVA: 0x00146091 File Offset: 0x00144291
		[DebuggerNonUserCode]
		public bool IsLadder
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isLadderDefaultValue;
				if (flag)
				{
					isLadderDefaultValue = this.isLadder_;
				}
				else
				{
					isLadderDefaultValue = GameContext.IsLadderDefaultValue;
				}
				return isLadderDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isLadder_ = value;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x0600546E RID: 21614 RVA: 0x001460AC File Offset: 0x001442AC
		[DebuggerNonUserCode]
		public bool HasIsLadder
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x001460C9 File Offset: 0x001442C9
		[DebuggerNonUserCode]
		public void ClearIsLadder()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06005470 RID: 21616 RVA: 0x001460DC File Offset: 0x001442DC
		// (set) Token: 0x06005471 RID: 21617 RVA: 0x0014610D File Offset: 0x0014430D
		[DebuggerNonUserCode]
		public bool CompletedGame
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool completedGameDefaultValue;
				if (flag)
				{
					completedGameDefaultValue = this.completedGame_;
				}
				else
				{
					completedGameDefaultValue = GameContext.CompletedGameDefaultValue;
				}
				return completedGameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.completedGame_ = value;
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06005472 RID: 21618 RVA: 0x00146128 File Offset: 0x00144328
		[DebuggerNonUserCode]
		public bool HasCompletedGame
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x00146145 File Offset: 0x00144345
		[DebuggerNonUserCode]
		public void ClearCompletedGame()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06005474 RID: 21620 RVA: 0x00146158 File Offset: 0x00144358
		// (set) Token: 0x06005475 RID: 21621 RVA: 0x00146189 File Offset: 0x00144389
		[DebuggerNonUserCode]
		public uint CompletingAct
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint completingActDefaultValue;
				if (flag)
				{
					completingActDefaultValue = this.completingAct_;
				}
				else
				{
					completingActDefaultValue = GameContext.CompletingActDefaultValue;
				}
				return completingActDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.completingAct_ = value;
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06005476 RID: 21622 RVA: 0x001461A4 File Offset: 0x001443A4
		[DebuggerNonUserCode]
		public bool HasCompletingAct
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x001461C1 File Offset: 0x001443C1
		[DebuggerNonUserCode]
		public void ClearCompletingAct()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06005478 RID: 21624 RVA: 0x001461D4 File Offset: 0x001443D4
		// (set) Token: 0x06005479 RID: 21625 RVA: 0x001461F5 File Offset: 0x001443F5
		[DebuggerNonUserCode]
		public string PresetName
		{
			get
			{
				return this.presetName_ ?? GameContext.PresetNameDefaultValue;
			}
			set
			{
				this.presetName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x0014620C File Offset: 0x0014440C
		[DebuggerNonUserCode]
		public bool HasPresetName
		{
			get
			{
				return this.presetName_ != null;
			}
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x00146227 File Offset: 0x00144427
		[DebuggerNonUserCode]
		public void ClearPresetName()
		{
			this.presetName_ = null;
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x0600547C RID: 21628 RVA: 0x00146234 File Offset: 0x00144434
		// (set) Token: 0x0600547D RID: 21629 RVA: 0x00146266 File Offset: 0x00144466
		[DebuggerNonUserCode]
		public bool InFrontend
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool inFrontendDefaultValue;
				if (flag)
				{
					inFrontendDefaultValue = this.inFrontend_;
				}
				else
				{
					inFrontendDefaultValue = GameContext.InFrontendDefaultValue;
				}
				return inFrontendDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.inFrontend_ = value;
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x00146280 File Offset: 0x00144480
		[DebuggerNonUserCode]
		public bool HasInFrontend
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x0014629E File Offset: 0x0014449E
		[DebuggerNonUserCode]
		public void ClearInFrontend()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x001462B0 File Offset: 0x001444B0
		// (set) Token: 0x06005481 RID: 21633 RVA: 0x001462C8 File Offset: 0x001444C8
		[DebuggerNonUserCode]
		public Level CurrentLevel
		{
			get
			{
				return this.currentLevel_;
			}
			set
			{
				this.currentLevel_ = value;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x001462D4 File Offset: 0x001444D4
		// (set) Token: 0x06005483 RID: 21635 RVA: 0x00146306 File Offset: 0x00144506
		[DebuggerNonUserCode]
		public uint PlayerX
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint playerXDefaultValue;
				if (flag)
				{
					playerXDefaultValue = this.playerX_;
				}
				else
				{
					playerXDefaultValue = GameContext.PlayerXDefaultValue;
				}
				return playerXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.playerX_ = value;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x00146320 File Offset: 0x00144520
		[DebuggerNonUserCode]
		public bool HasPlayerX
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x0014633E File Offset: 0x0014453E
		[DebuggerNonUserCode]
		public void ClearPlayerX()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x00146350 File Offset: 0x00144550
		// (set) Token: 0x06005487 RID: 21639 RVA: 0x00146382 File Offset: 0x00144582
		[DebuggerNonUserCode]
		public uint PlayerY
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint playerYDefaultValue;
				if (flag)
				{
					playerYDefaultValue = this.playerY_;
				}
				else
				{
					playerYDefaultValue = GameContext.PlayerYDefaultValue;
				}
				return playerYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.playerY_ = value;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x0014639C File Offset: 0x0014459C
		[DebuggerNonUserCode]
		public bool HasPlayerY
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x001463BA File Offset: 0x001445BA
		[DebuggerNonUserCode]
		public void ClearPlayerY()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x001463CC File Offset: 0x001445CC
		// (set) Token: 0x0600548B RID: 21643 RVA: 0x00146401 File Offset: 0x00144601
		[DebuggerNonUserCode]
		public uint GameSeed
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint gameSeedDefaultValue;
				if (flag)
				{
					gameSeedDefaultValue = this.gameSeed_;
				}
				else
				{
					gameSeedDefaultValue = GameContext.GameSeedDefaultValue;
				}
				return gameSeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.gameSeed_ = value;
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x00146420 File Offset: 0x00144620
		[DebuggerNonUserCode]
		public bool HasGameSeed
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x00146441 File Offset: 0x00144641
		[DebuggerNonUserCode]
		public void ClearGameSeed()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x00146458 File Offset: 0x00144658
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameContext);
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00146478 File Offset: 0x00144678
		[DebuggerNonUserCode]
		public bool Equals(GameContext other)
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
					bool flag4 = this.GameType != other.GameType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameDifficulty != other.GameDifficulty;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsExpansion != other.IsExpansion;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsLadder != other.IsLadder;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CompletedGame != other.CompletedGame;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CompletingAct != other.CompletingAct;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.PresetName != other.PresetName;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.InFrontend != other.InFrontend;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.CurrentLevel, other.CurrentLevel);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.PlayerX != other.PlayerX;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.PlayerY != other.PlayerY;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.GameSeed != other.GameSeed;
																flag2 = !flag15 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06005490 RID: 21648 RVA: 0x00146618 File Offset: 0x00144818
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				num ^= this.GameType.GetHashCode();
			}
			bool hasGameDifficulty = this.HasGameDifficulty;
			if (hasGameDifficulty)
			{
				num ^= this.GameDifficulty.GetHashCode();
			}
			bool hasIsExpansion = this.HasIsExpansion;
			if (hasIsExpansion)
			{
				num ^= this.IsExpansion.GetHashCode();
			}
			bool hasIsLadder = this.HasIsLadder;
			if (hasIsLadder)
			{
				num ^= this.IsLadder.GetHashCode();
			}
			bool hasCompletedGame = this.HasCompletedGame;
			if (hasCompletedGame)
			{
				num ^= this.CompletedGame.GetHashCode();
			}
			bool hasCompletingAct = this.HasCompletingAct;
			if (hasCompletingAct)
			{
				num ^= this.CompletingAct.GetHashCode();
			}
			bool hasPresetName = this.HasPresetName;
			if (hasPresetName)
			{
				num ^= this.PresetName.GetHashCode();
			}
			bool hasInFrontend = this.HasInFrontend;
			if (hasInFrontend)
			{
				num ^= this.InFrontend.GetHashCode();
			}
			bool flag = this.currentLevel_ != null;
			if (flag)
			{
				num ^= this.CurrentLevel.GetHashCode();
			}
			bool hasPlayerX = this.HasPlayerX;
			if (hasPlayerX)
			{
				num ^= this.PlayerX.GetHashCode();
			}
			bool hasPlayerY = this.HasPlayerY;
			if (hasPlayerY)
			{
				num ^= this.PlayerY.GetHashCode();
			}
			bool hasGameSeed = this.HasGameSeed;
			if (hasGameSeed)
			{
				num ^= this.GameSeed.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x001467A4 File Offset: 0x001449A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x001467BC File Offset: 0x001449BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x001467C8 File Offset: 0x001449C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.GameType);
			}
			bool hasGameDifficulty = this.HasGameDifficulty;
			if (hasGameDifficulty)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameDifficulty);
			}
			bool hasIsExpansion = this.HasIsExpansion;
			if (hasIsExpansion)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsExpansion);
			}
			bool hasIsLadder = this.HasIsLadder;
			if (hasIsLadder)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsLadder);
			}
			bool hasCompletedGame = this.HasCompletedGame;
			if (hasCompletedGame)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.CompletedGame);
			}
			bool hasCompletingAct = this.HasCompletingAct;
			if (hasCompletingAct)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CompletingAct);
			}
			bool hasPresetName = this.HasPresetName;
			if (hasPresetName)
			{
				output.WriteRawTag(58);
				output.WriteString(this.PresetName);
			}
			bool hasInFrontend = this.HasInFrontend;
			if (hasInFrontend)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.InFrontend);
			}
			bool flag = this.currentLevel_ != null;
			if (flag)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CurrentLevel);
			}
			bool hasPlayerX = this.HasPlayerX;
			if (hasPlayerX)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.PlayerX);
			}
			bool hasPlayerY = this.HasPlayerY;
			if (hasPlayerY)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PlayerY);
			}
			bool hasGameSeed = this.HasGameSeed;
			if (hasGameSeed)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.GameSeed);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x001469A0 File Offset: 0x00144BA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameType);
			}
			bool hasGameDifficulty = this.HasGameDifficulty;
			if (hasGameDifficulty)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameDifficulty);
			}
			bool hasIsExpansion = this.HasIsExpansion;
			if (hasIsExpansion)
			{
				num += 2;
			}
			bool hasIsLadder = this.HasIsLadder;
			if (hasIsLadder)
			{
				num += 2;
			}
			bool hasCompletedGame = this.HasCompletedGame;
			if (hasCompletedGame)
			{
				num += 2;
			}
			bool hasCompletingAct = this.HasCompletingAct;
			if (hasCompletingAct)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CompletingAct);
			}
			bool hasPresetName = this.HasPresetName;
			if (hasPresetName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PresetName);
			}
			bool hasInFrontend = this.HasInFrontend;
			if (hasInFrontend)
			{
				num += 2;
			}
			bool flag = this.currentLevel_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentLevel);
			}
			bool hasPlayerX = this.HasPlayerX;
			if (hasPlayerX)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayerX);
			}
			bool hasPlayerY = this.HasPlayerY;
			if (hasPlayerY)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayerY);
			}
			bool hasGameSeed = this.HasGameSeed;
			if (hasGameSeed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameSeed);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x00146B0C File Offset: 0x00144D0C
		[DebuggerNonUserCode]
		public void MergeFrom(GameContext other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameType = other.HasGameType;
				if (hasGameType)
				{
					this.GameType = other.GameType;
				}
				bool hasGameDifficulty = other.HasGameDifficulty;
				if (hasGameDifficulty)
				{
					this.GameDifficulty = other.GameDifficulty;
				}
				bool hasIsExpansion = other.HasIsExpansion;
				if (hasIsExpansion)
				{
					this.IsExpansion = other.IsExpansion;
				}
				bool hasIsLadder = other.HasIsLadder;
				if (hasIsLadder)
				{
					this.IsLadder = other.IsLadder;
				}
				bool hasCompletedGame = other.HasCompletedGame;
				if (hasCompletedGame)
				{
					this.CompletedGame = other.CompletedGame;
				}
				bool hasCompletingAct = other.HasCompletingAct;
				if (hasCompletingAct)
				{
					this.CompletingAct = other.CompletingAct;
				}
				bool hasPresetName = other.HasPresetName;
				if (hasPresetName)
				{
					this.PresetName = other.PresetName;
				}
				bool hasInFrontend = other.HasInFrontend;
				if (hasInFrontend)
				{
					this.InFrontend = other.InFrontend;
				}
				bool flag2 = other.currentLevel_ != null;
				if (flag2)
				{
					bool flag3 = this.currentLevel_ == null;
					if (flag3)
					{
						this.CurrentLevel = new Level();
					}
					this.CurrentLevel.MergeFrom(other.CurrentLevel);
				}
				bool hasPlayerX = other.HasPlayerX;
				if (hasPlayerX)
				{
					this.PlayerX = other.PlayerX;
				}
				bool hasPlayerY = other.HasPlayerY;
				if (hasPlayerY)
				{
					this.PlayerY = other.PlayerY;
				}
				bool hasGameSeed = other.HasGameSeed;
				if (hasGameSeed)
				{
					this.GameSeed = other.GameSeed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x00146CA2 File Offset: 0x00144EA2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x00146CB0 File Offset: 0x00144EB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 24U)
								{
									goto IL_0092;
								}
								this.IsExpansion = input.ReadBool();
							}
							else
							{
								this.GameDifficulty = input.ReadString();
							}
						}
						else
						{
							this.GameType = input.ReadString();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_0092;
							}
							this.CompletingAct = input.ReadUInt32();
						}
						else
						{
							this.CompletedGame = input.ReadBool();
						}
					}
					else
					{
						this.IsLadder = input.ReadBool();
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 58U)
					{
						if (num3 != 64U)
						{
							if (num3 != 74U)
							{
								goto IL_0092;
							}
							bool flag = this.currentLevel_ == null;
							if (flag)
							{
								this.CurrentLevel = new Level();
							}
							input.ReadMessage(this.CurrentLevel);
						}
						else
						{
							this.InFrontend = input.ReadBool();
						}
					}
					else
					{
						this.PresetName = input.ReadString();
					}
				}
				else if (num3 != 80U)
				{
					if (num3 != 88U)
					{
						if (num3 != 96U)
						{
							goto IL_0092;
						}
						this.GameSeed = input.ReadUInt32();
					}
					else
					{
						this.PlayerY = input.ReadUInt32();
					}
				}
				else
				{
					this.PlayerX = input.ReadUInt32();
				}
				continue;
				IL_0092:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002649 RID: 9801
		private static readonly MessageParser<GameContext> _parser = new MessageParser<GameContext>(() => new GameContext());

		// Token: 0x0400264A RID: 9802
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400264B RID: 9803
		private int _hasBits0;

		// Token: 0x0400264C RID: 9804
		public const int GameTypeFieldNumber = 1;

		// Token: 0x0400264D RID: 9805
		private static readonly string GameTypeDefaultValue = "";

		// Token: 0x0400264E RID: 9806
		private string gameType_;

		// Token: 0x0400264F RID: 9807
		public const int GameDifficultyFieldNumber = 2;

		// Token: 0x04002650 RID: 9808
		private static readonly string GameDifficultyDefaultValue = "";

		// Token: 0x04002651 RID: 9809
		private string gameDifficulty_;

		// Token: 0x04002652 RID: 9810
		public const int IsExpansionFieldNumber = 3;

		// Token: 0x04002653 RID: 9811
		private static readonly bool IsExpansionDefaultValue = false;

		// Token: 0x04002654 RID: 9812
		private bool isExpansion_;

		// Token: 0x04002655 RID: 9813
		public const int IsLadderFieldNumber = 4;

		// Token: 0x04002656 RID: 9814
		private static readonly bool IsLadderDefaultValue = false;

		// Token: 0x04002657 RID: 9815
		private bool isLadder_;

		// Token: 0x04002658 RID: 9816
		public const int CompletedGameFieldNumber = 5;

		// Token: 0x04002659 RID: 9817
		private static readonly bool CompletedGameDefaultValue = false;

		// Token: 0x0400265A RID: 9818
		private bool completedGame_;

		// Token: 0x0400265B RID: 9819
		public const int CompletingActFieldNumber = 6;

		// Token: 0x0400265C RID: 9820
		private static readonly uint CompletingActDefaultValue = 0U;

		// Token: 0x0400265D RID: 9821
		private uint completingAct_;

		// Token: 0x0400265E RID: 9822
		public const int PresetNameFieldNumber = 7;

		// Token: 0x0400265F RID: 9823
		private static readonly string PresetNameDefaultValue = "";

		// Token: 0x04002660 RID: 9824
		private string presetName_;

		// Token: 0x04002661 RID: 9825
		public const int InFrontendFieldNumber = 8;

		// Token: 0x04002662 RID: 9826
		private static readonly bool InFrontendDefaultValue = false;

		// Token: 0x04002663 RID: 9827
		private bool inFrontend_;

		// Token: 0x04002664 RID: 9828
		public const int CurrentLevelFieldNumber = 9;

		// Token: 0x04002665 RID: 9829
		private Level currentLevel_;

		// Token: 0x04002666 RID: 9830
		public const int PlayerXFieldNumber = 10;

		// Token: 0x04002667 RID: 9831
		private static readonly uint PlayerXDefaultValue = 0U;

		// Token: 0x04002668 RID: 9832
		private uint playerX_;

		// Token: 0x04002669 RID: 9833
		public const int PlayerYFieldNumber = 11;

		// Token: 0x0400266A RID: 9834
		private static readonly uint PlayerYDefaultValue = 0U;

		// Token: 0x0400266B RID: 9835
		private uint playerY_;

		// Token: 0x0400266C RID: 9836
		public const int GameSeedFieldNumber = 12;

		// Token: 0x0400266D RID: 9837
		private static readonly uint GameSeedDefaultValue = 0U;

		// Token: 0x0400266E RID: 9838
		private uint gameSeed_;
	}
}
