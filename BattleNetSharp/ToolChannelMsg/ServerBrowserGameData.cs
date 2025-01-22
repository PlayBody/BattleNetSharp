using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000AA RID: 170
	public sealed class ServerBrowserGameData : IMessage<ServerBrowserGameData>, IMessage, IEquatable<ServerBrowserGameData>, IDeepCloneable<ServerBrowserGameData>, IBufferMessage
	{
		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00039B84 File Offset: 0x00037D84
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserGameData> Parser
		{
			get
			{
				return ServerBrowserGameData._parser;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00039B9C File Offset: 0x00037D9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[147];
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00039BC4 File Offset: 0x00037DC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserGameData.Descriptor;
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00039BDB File Offset: 0x00037DDB
		[DebuggerNonUserCode]
		public ServerBrowserGameData()
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00039BFC File Offset: 0x00037DFC
		[DebuggerNonUserCode]
		public ServerBrowserGameData(ServerBrowserGameData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameId_ = other.gameId_;
			this.hasPlayersData_ = other.hasPlayersData_;
			this.players_ = other.players_.Clone();
			this.snoSubzone_ = other.snoSubzone_;
			this.matchmakingOn_ = other.matchmakingOn_;
			this.instancePartyId_ = other.instancePartyId_;
			this.ticksSincePlayerInGame_ = other.ticksSincePlayerInGame_;
			this.serverCommandFrame_ = other.serverCommandFrame_;
			this.hasWorldData_ = other.hasWorldData_;
			this.worlds_ = other.worlds_.Clone();
			this.partySize_ = other.partySize_;
			this.snoInstanceQuest_ = other.snoInstanceQuest_;
			this.gameWorldTier_ = other.gameWorldTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00039CD4 File Offset: 0x00037ED4
		[DebuggerNonUserCode]
		public ServerBrowserGameData Clone()
		{
			return new ServerBrowserGameData(this);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00039CEC File Offset: 0x00037EEC
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00039D1D File Offset: 0x00037F1D
		[DebuggerNonUserCode]
		public uint GameId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameIdDefaultValue;
				if (flag)
				{
					gameIdDefaultValue = this.gameId_;
				}
				else
				{
					gameIdDefaultValue = ServerBrowserGameData.GameIdDefaultValue;
				}
				return gameIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameId_ = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00039D38 File Offset: 0x00037F38
		[DebuggerNonUserCode]
		public bool HasGameId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00039D55 File Offset: 0x00037F55
		[DebuggerNonUserCode]
		public void ClearGameId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00039D68 File Offset: 0x00037F68
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00039D99 File Offset: 0x00037F99
		[DebuggerNonUserCode]
		public bool HasPlayersData
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool hasPlayersDataDefaultValue;
				if (flag)
				{
					hasPlayersDataDefaultValue = this.hasPlayersData_;
				}
				else
				{
					hasPlayersDataDefaultValue = ServerBrowserGameData.HasPlayersDataDefaultValue;
				}
				return hasPlayersDataDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.hasPlayersData_ = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00039DB4 File Offset: 0x00037FB4
		[DebuggerNonUserCode]
		public bool HasHasPlayersData
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00039DD1 File Offset: 0x00037FD1
		[DebuggerNonUserCode]
		public void ClearHasPlayersData()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00039DE4 File Offset: 0x00037FE4
		[DebuggerNonUserCode]
		public RepeatedField<ServerBrowserPlayerData> Players
		{
			get
			{
				return this.players_;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00039DFC File Offset: 0x00037FFC
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00039E2D File Offset: 0x0003802D
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = ServerBrowserGameData.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00039E48 File Offset: 0x00038048
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00039E65 File Offset: 0x00038065
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00039E78 File Offset: 0x00038078
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00039EA9 File Offset: 0x000380A9
		[DebuggerNonUserCode]
		public bool MatchmakingOn
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool matchmakingOnDefaultValue;
				if (flag)
				{
					matchmakingOnDefaultValue = this.matchmakingOn_;
				}
				else
				{
					matchmakingOnDefaultValue = ServerBrowserGameData.MatchmakingOnDefaultValue;
				}
				return matchmakingOnDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.matchmakingOn_ = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00039EC4 File Offset: 0x000380C4
		[DebuggerNonUserCode]
		public bool HasMatchmakingOn
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00039EE1 File Offset: 0x000380E1
		[DebuggerNonUserCode]
		public void ClearMatchmakingOn()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00039EF4 File Offset: 0x000380F4
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00039F15 File Offset: 0x00038115
		[DebuggerNonUserCode]
		public string InstancePartyId
		{
			get
			{
				return this.instancePartyId_ ?? ServerBrowserGameData.InstancePartyIdDefaultValue;
			}
			set
			{
				this.instancePartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00039F2C File Offset: 0x0003812C
		[DebuggerNonUserCode]
		public bool HasInstancePartyId
		{
			get
			{
				return this.instancePartyId_ != null;
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00039F47 File Offset: 0x00038147
		[DebuggerNonUserCode]
		public void ClearInstancePartyId()
		{
			this.instancePartyId_ = null;
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00039F54 File Offset: 0x00038154
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00039F86 File Offset: 0x00038186
		[DebuggerNonUserCode]
		public uint TicksSincePlayerInGame
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint ticksSincePlayerInGameDefaultValue;
				if (flag)
				{
					ticksSincePlayerInGameDefaultValue = this.ticksSincePlayerInGame_;
				}
				else
				{
					ticksSincePlayerInGameDefaultValue = ServerBrowserGameData.TicksSincePlayerInGameDefaultValue;
				}
				return ticksSincePlayerInGameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.ticksSincePlayerInGame_ = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00039FA0 File Offset: 0x000381A0
		[DebuggerNonUserCode]
		public bool HasTicksSincePlayerInGame
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00039FBE File Offset: 0x000381BE
		[DebuggerNonUserCode]
		public void ClearTicksSincePlayerInGame()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00039FD0 File Offset: 0x000381D0
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x0003A002 File Offset: 0x00038202
		[DebuggerNonUserCode]
		public uint ServerCommandFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint serverCommandFrameDefaultValue;
				if (flag)
				{
					serverCommandFrameDefaultValue = this.serverCommandFrame_;
				}
				else
				{
					serverCommandFrameDefaultValue = ServerBrowserGameData.ServerCommandFrameDefaultValue;
				}
				return serverCommandFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.serverCommandFrame_ = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0003A01C File Offset: 0x0003821C
		[DebuggerNonUserCode]
		public bool HasServerCommandFrame
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0003A03A File Offset: 0x0003823A
		[DebuggerNonUserCode]
		public void ClearServerCommandFrame()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0003A04C File Offset: 0x0003824C
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0003A07E File Offset: 0x0003827E
		[DebuggerNonUserCode]
		public bool HasWorldData
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool hasWorldDataDefaultValue;
				if (flag)
				{
					hasWorldDataDefaultValue = this.hasWorldData_;
				}
				else
				{
					hasWorldDataDefaultValue = ServerBrowserGameData.HasWorldDataDefaultValue;
				}
				return hasWorldDataDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.hasWorldData_ = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0003A098 File Offset: 0x00038298
		[DebuggerNonUserCode]
		public bool HasHasWorldData
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0003A0B6 File Offset: 0x000382B6
		[DebuggerNonUserCode]
		public void ClearHasWorldData()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0003A0C8 File Offset: 0x000382C8
		[DebuggerNonUserCode]
		public RepeatedField<ServerBrowserWorldData> Worlds
		{
			get
			{
				return this.worlds_;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x0003A0E0 File Offset: 0x000382E0
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0003A115 File Offset: 0x00038315
		[DebuggerNonUserCode]
		public int PartySize
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int partySizeDefaultValue;
				if (flag)
				{
					partySizeDefaultValue = this.partySize_;
				}
				else
				{
					partySizeDefaultValue = ServerBrowserGameData.PartySizeDefaultValue;
				}
				return partySizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.partySize_ = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x0003A134 File Offset: 0x00038334
		[DebuggerNonUserCode]
		public bool HasPartySize
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0003A155 File Offset: 0x00038355
		[DebuggerNonUserCode]
		public void ClearPartySize()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0003A16C File Offset: 0x0003836C
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x0003A1A1 File Offset: 0x000383A1
		[DebuggerNonUserCode]
		public int SnoInstanceQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				int snoInstanceQuestDefaultValue;
				if (flag)
				{
					snoInstanceQuestDefaultValue = this.snoInstanceQuest_;
				}
				else
				{
					snoInstanceQuestDefaultValue = ServerBrowserGameData.SnoInstanceQuestDefaultValue;
				}
				return snoInstanceQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.snoInstanceQuest_ = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0003A1C0 File Offset: 0x000383C0
		[DebuggerNonUserCode]
		public bool HasSnoInstanceQuest
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0003A1E1 File Offset: 0x000383E1
		[DebuggerNonUserCode]
		public void ClearSnoInstanceQuest()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0003A1F8 File Offset: 0x000383F8
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x0003A22D File Offset: 0x0003842D
		[DebuggerNonUserCode]
		public int GameWorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				int gameWorldTierDefaultValue;
				if (flag)
				{
					gameWorldTierDefaultValue = this.gameWorldTier_;
				}
				else
				{
					gameWorldTierDefaultValue = ServerBrowserGameData.GameWorldTierDefaultValue;
				}
				return gameWorldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.gameWorldTier_ = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0003A24C File Offset: 0x0003844C
		[DebuggerNonUserCode]
		public bool HasGameWorldTier
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0003A26D File Offset: 0x0003846D
		[DebuggerNonUserCode]
		public void ClearGameWorldTier()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0003A284 File Offset: 0x00038484
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserGameData);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0003A2A4 File Offset: 0x000384A4
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserGameData other)
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
					bool flag4 = this.GameId != other.GameId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HasPlayersData != other.HasPlayersData;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.players_.Equals(other.players_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoSubzone != other.SnoSubzone;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.MatchmakingOn != other.MatchmakingOn;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.InstancePartyId != other.InstancePartyId;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.TicksSincePlayerInGame != other.TicksSincePlayerInGame;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ServerCommandFrame != other.ServerCommandFrame;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.HasWorldData != other.HasWorldData;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.worlds_.Equals(other.worlds_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.PartySize != other.PartySize;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.SnoInstanceQuest != other.SnoInstanceQuest;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.GameWorldTier != other.GameWorldTier;
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

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0003A468 File Offset: 0x00038668
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num ^= this.GameId.GetHashCode();
			}
			bool hasHasPlayersData = this.HasHasPlayersData;
			if (hasHasPlayersData)
			{
				num ^= this.HasPlayersData.GetHashCode();
			}
			num ^= this.players_.GetHashCode();
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool hasMatchmakingOn = this.HasMatchmakingOn;
			if (hasMatchmakingOn)
			{
				num ^= this.MatchmakingOn.GetHashCode();
			}
			bool hasInstancePartyId = this.HasInstancePartyId;
			if (hasInstancePartyId)
			{
				num ^= this.InstancePartyId.GetHashCode();
			}
			bool hasTicksSincePlayerInGame = this.HasTicksSincePlayerInGame;
			if (hasTicksSincePlayerInGame)
			{
				num ^= this.TicksSincePlayerInGame.GetHashCode();
			}
			bool hasServerCommandFrame = this.HasServerCommandFrame;
			if (hasServerCommandFrame)
			{
				num ^= this.ServerCommandFrame.GetHashCode();
			}
			bool hasHasWorldData = this.HasHasWorldData;
			if (hasHasWorldData)
			{
				num ^= this.HasWorldData.GetHashCode();
			}
			num ^= this.worlds_.GetHashCode();
			bool hasPartySize = this.HasPartySize;
			if (hasPartySize)
			{
				num ^= this.PartySize.GetHashCode();
			}
			bool hasSnoInstanceQuest = this.HasSnoInstanceQuest;
			if (hasSnoInstanceQuest)
			{
				num ^= this.SnoInstanceQuest.GetHashCode();
			}
			bool hasGameWorldTier = this.HasGameWorldTier;
			if (hasGameWorldTier)
			{
				num ^= this.GameWorldTier.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0003A5FC File Offset: 0x000387FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0003A614 File Offset: 0x00038814
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0003A620 File Offset: 0x00038820
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameId);
			}
			bool hasHasPlayersData = this.HasHasPlayersData;
			if (hasHasPlayersData)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.HasPlayersData);
			}
			this.players_.WriteTo(ref output, ServerBrowserGameData._repeated_players_codec);
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(37);
				output.WriteSFixed32(this.SnoSubzone);
			}
			bool hasMatchmakingOn = this.HasMatchmakingOn;
			if (hasMatchmakingOn)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.MatchmakingOn);
			}
			bool hasInstancePartyId = this.HasInstancePartyId;
			if (hasInstancePartyId)
			{
				output.WriteRawTag(50);
				output.WriteString(this.InstancePartyId);
			}
			bool hasTicksSincePlayerInGame = this.HasTicksSincePlayerInGame;
			if (hasTicksSincePlayerInGame)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TicksSincePlayerInGame);
			}
			bool hasServerCommandFrame = this.HasServerCommandFrame;
			if (hasServerCommandFrame)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ServerCommandFrame);
			}
			bool hasHasWorldData = this.HasHasWorldData;
			if (hasHasWorldData)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.HasWorldData);
			}
			this.worlds_.WriteTo(ref output, ServerBrowserGameData._repeated_worlds_codec);
			bool hasPartySize = this.HasPartySize;
			if (hasPartySize)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PartySize);
			}
			bool hasSnoInstanceQuest = this.HasSnoInstanceQuest;
			if (hasSnoInstanceQuest)
			{
				output.WriteRawTag(101);
				output.WriteSFixed32(this.SnoInstanceQuest);
			}
			bool hasGameWorldTier = this.HasGameWorldTier;
			if (hasGameWorldTier)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.GameWorldTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0003A7F4 File Offset: 0x000389F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameId);
			}
			bool hasHasPlayersData = this.HasHasPlayersData;
			if (hasHasPlayersData)
			{
				num += 2;
			}
			num += this.players_.CalculateSize(ServerBrowserGameData._repeated_players_codec);
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 5;
			}
			bool hasMatchmakingOn = this.HasMatchmakingOn;
			if (hasMatchmakingOn)
			{
				num += 2;
			}
			bool hasInstancePartyId = this.HasInstancePartyId;
			if (hasInstancePartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InstancePartyId);
			}
			bool hasTicksSincePlayerInGame = this.HasTicksSincePlayerInGame;
			if (hasTicksSincePlayerInGame)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TicksSincePlayerInGame);
			}
			bool hasServerCommandFrame = this.HasServerCommandFrame;
			if (hasServerCommandFrame)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServerCommandFrame);
			}
			bool hasHasWorldData = this.HasHasWorldData;
			if (hasHasWorldData)
			{
				num += 2;
			}
			num += this.worlds_.CalculateSize(ServerBrowserGameData._repeated_worlds_codec);
			bool hasPartySize = this.HasPartySize;
			if (hasPartySize)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartySize);
			}
			bool hasSnoInstanceQuest = this.HasSnoInstanceQuest;
			if (hasSnoInstanceQuest)
			{
				num += 5;
			}
			bool hasGameWorldTier = this.HasGameWorldTier;
			if (hasGameWorldTier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GameWorldTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0003A958 File Offset: 0x00038B58
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserGameData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameId = other.HasGameId;
				if (hasGameId)
				{
					this.GameId = other.GameId;
				}
				bool hasHasPlayersData = other.HasHasPlayersData;
				if (hasHasPlayersData)
				{
					this.HasPlayersData = other.HasPlayersData;
				}
				this.players_.Add(other.players_);
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool hasMatchmakingOn = other.HasMatchmakingOn;
				if (hasMatchmakingOn)
				{
					this.MatchmakingOn = other.MatchmakingOn;
				}
				bool hasInstancePartyId = other.HasInstancePartyId;
				if (hasInstancePartyId)
				{
					this.InstancePartyId = other.InstancePartyId;
				}
				bool hasTicksSincePlayerInGame = other.HasTicksSincePlayerInGame;
				if (hasTicksSincePlayerInGame)
				{
					this.TicksSincePlayerInGame = other.TicksSincePlayerInGame;
				}
				bool hasServerCommandFrame = other.HasServerCommandFrame;
				if (hasServerCommandFrame)
				{
					this.ServerCommandFrame = other.ServerCommandFrame;
				}
				bool hasHasWorldData = other.HasHasWorldData;
				if (hasHasWorldData)
				{
					this.HasWorldData = other.HasWorldData;
				}
				this.worlds_.Add(other.worlds_);
				bool hasPartySize = other.HasPartySize;
				if (hasPartySize)
				{
					this.PartySize = other.PartySize;
				}
				bool hasSnoInstanceQuest = other.HasSnoInstanceQuest;
				if (hasSnoInstanceQuest)
				{
					this.SnoInstanceQuest = other.SnoInstanceQuest;
				}
				bool hasGameWorldTier = other.HasGameWorldTier;
				if (hasGameWorldTier)
				{
					this.GameWorldTier = other.GameWorldTier;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0003AAD2 File Offset: 0x00038CD2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0003AAE0 File Offset: 0x00038CE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								if (num3 != 26U)
								{
									goto IL_00A0;
								}
								this.players_.AddEntriesFrom(ref input, ServerBrowserGameData._repeated_players_codec);
							}
							else
							{
								this.HasPlayersData = input.ReadBool();
							}
						}
						else
						{
							this.GameId = input.ReadUInt32();
						}
					}
					else if (num3 != 37U)
					{
						if (num3 != 40U)
						{
							if (num3 != 50U)
							{
								goto IL_00A0;
							}
							this.InstancePartyId = input.ReadString();
						}
						else
						{
							this.MatchmakingOn = input.ReadBool();
						}
					}
					else
					{
						this.SnoSubzone = input.ReadSFixed32();
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
								goto IL_00A0;
							}
							this.HasWorldData = input.ReadBool();
						}
						else
						{
							this.ServerCommandFrame = input.ReadUInt32();
						}
					}
					else
					{
						this.TicksSincePlayerInGame = input.ReadUInt32();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 82U)
					{
						if (num3 != 88U)
						{
							goto IL_00A0;
						}
						this.PartySize = input.ReadInt32();
					}
					else
					{
						this.worlds_.AddEntriesFrom(ref input, ServerBrowserGameData._repeated_worlds_codec);
					}
				}
				else if (num3 != 101U)
				{
					if (num3 != 104U)
					{
						goto IL_00A0;
					}
					this.GameWorldTier = input.ReadInt32();
				}
				else
				{
					this.SnoInstanceQuest = input.ReadSFixed32();
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000633 RID: 1587
		private static readonly MessageParser<ServerBrowserGameData> _parser = new MessageParser<ServerBrowserGameData>(() => new ServerBrowserGameData());

		// Token: 0x04000634 RID: 1588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000635 RID: 1589
		private int _hasBits0;

		// Token: 0x04000636 RID: 1590
		public const int GameIdFieldNumber = 1;

		// Token: 0x04000637 RID: 1591
		private static readonly uint GameIdDefaultValue = 0U;

		// Token: 0x04000638 RID: 1592
		private uint gameId_;

		// Token: 0x04000639 RID: 1593
		public const int HasPlayersDataFieldNumber = 2;

		// Token: 0x0400063A RID: 1594
		private static readonly bool HasPlayersDataDefaultValue = false;

		// Token: 0x0400063B RID: 1595
		private bool hasPlayersData_;

		// Token: 0x0400063C RID: 1596
		public const int PlayersFieldNumber = 3;

		// Token: 0x0400063D RID: 1597
		private static readonly FieldCodec<ServerBrowserPlayerData> _repeated_players_codec = FieldCodec.ForMessage<ServerBrowserPlayerData>(26U, ServerBrowserPlayerData.Parser);

		// Token: 0x0400063E RID: 1598
		private readonly RepeatedField<ServerBrowserPlayerData> players_ = new RepeatedField<ServerBrowserPlayerData>();

		// Token: 0x0400063F RID: 1599
		public const int SnoSubzoneFieldNumber = 4;

		// Token: 0x04000640 RID: 1600
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x04000641 RID: 1601
		private int snoSubzone_;

		// Token: 0x04000642 RID: 1602
		public const int MatchmakingOnFieldNumber = 5;

		// Token: 0x04000643 RID: 1603
		private static readonly bool MatchmakingOnDefaultValue = false;

		// Token: 0x04000644 RID: 1604
		private bool matchmakingOn_;

		// Token: 0x04000645 RID: 1605
		public const int InstancePartyIdFieldNumber = 6;

		// Token: 0x04000646 RID: 1606
		private static readonly string InstancePartyIdDefaultValue = "";

		// Token: 0x04000647 RID: 1607
		private string instancePartyId_;

		// Token: 0x04000648 RID: 1608
		public const int TicksSincePlayerInGameFieldNumber = 7;

		// Token: 0x04000649 RID: 1609
		private static readonly uint TicksSincePlayerInGameDefaultValue = 0U;

		// Token: 0x0400064A RID: 1610
		private uint ticksSincePlayerInGame_;

		// Token: 0x0400064B RID: 1611
		public const int ServerCommandFrameFieldNumber = 8;

		// Token: 0x0400064C RID: 1612
		private static readonly uint ServerCommandFrameDefaultValue = 0U;

		// Token: 0x0400064D RID: 1613
		private uint serverCommandFrame_;

		// Token: 0x0400064E RID: 1614
		public const int HasWorldDataFieldNumber = 9;

		// Token: 0x0400064F RID: 1615
		private static readonly bool HasWorldDataDefaultValue = false;

		// Token: 0x04000650 RID: 1616
		private bool hasWorldData_;

		// Token: 0x04000651 RID: 1617
		public const int WorldsFieldNumber = 10;

		// Token: 0x04000652 RID: 1618
		private static readonly FieldCodec<ServerBrowserWorldData> _repeated_worlds_codec = FieldCodec.ForMessage<ServerBrowserWorldData>(82U, ServerBrowserWorldData.Parser);

		// Token: 0x04000653 RID: 1619
		private readonly RepeatedField<ServerBrowserWorldData> worlds_ = new RepeatedField<ServerBrowserWorldData>();

		// Token: 0x04000654 RID: 1620
		public const int PartySizeFieldNumber = 11;

		// Token: 0x04000655 RID: 1621
		private static readonly int PartySizeDefaultValue = 0;

		// Token: 0x04000656 RID: 1622
		private int partySize_;

		// Token: 0x04000657 RID: 1623
		public const int SnoInstanceQuestFieldNumber = 12;

		// Token: 0x04000658 RID: 1624
		private static readonly int SnoInstanceQuestDefaultValue = 0;

		// Token: 0x04000659 RID: 1625
		private int snoInstanceQuest_;

		// Token: 0x0400065A RID: 1626
		public const int GameWorldTierFieldNumber = 13;

		// Token: 0x0400065B RID: 1627
		private static readonly int GameWorldTierDefaultValue = 0;

		// Token: 0x0400065C RID: 1628
		private int gameWorldTier_;
	}
}
