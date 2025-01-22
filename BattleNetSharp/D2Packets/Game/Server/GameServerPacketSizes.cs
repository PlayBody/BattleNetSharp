using System;
using System.Collections.Generic;

namespace D2Packets.Game.Server
{
	// Token: 0x020009BB RID: 2491
	public class GameServerPacketSizes
	{
		// Token: 0x0600BAC8 RID: 47816 RVA: 0x0046CD78 File Offset: 0x0046AF78
		public static bool GetPacketSize(List<byte> input, out int output, bool xpac = false)
		{
			GameServerPacket gameServerPacket = (GameServerPacket)input[0];
			int count = input.Count;
			GameServerPacket gameServerPacket2 = gameServerPacket;
			GameServerPacket gameServerPacket3 = gameServerPacket2;
			if (gameServerPacket3 <= GameServerPacket.NPCMove)
			{
				if (gameServerPacket3 <= GameServerPacket.UpdateItemStats)
				{
					if (gameServerPacket3 != GameServerPacket.TradeRequest)
					{
						if (gameServerPacket3 == GameServerPacket.UpdateItemStats)
						{
							bool flag = count >= 2;
							if (flag)
							{
								output = (int)input[1];
								return true;
							}
							goto IL_033E;
						}
					}
					else
					{
						bool flag2 = count >= 6;
						if (!flag2)
						{
							goto IL_033E;
						}
						TradeRequest.TradeTypes tradeTypes = (TradeRequest.TradeTypes)input[1];
						bool flag3 = tradeTypes == TradeRequest.TradeTypes.RequestTrade;
						if (flag3)
						{
							output = 36;
							return true;
						}
						bool flag4 = tradeTypes == TradeRequest.TradeTypes.CancelTrade;
						if (flag4)
						{
							output = 6;
							return true;
						}
						output = 18;
						return true;
					}
				}
				else if (gameServerPacket3 != GameServerPacket.InformationMessage)
				{
					if (gameServerPacket3 != GameServerPacket.PlayerInGame)
					{
						if (gameServerPacket3 == GameServerPacket.NPCMove)
						{
							bool flag5 = count >= 21;
							if (flag5)
							{
								output = (int)(22 + 4 * input[20]);
								return true;
							}
							goto IL_033E;
						}
					}
					else
					{
						bool flag6 = count >= 3;
						if (flag6)
						{
							output = (int)BitConverter.ToInt16(input.ToArray(), 1);
							return true;
						}
						goto IL_033E;
					}
				}
				else
				{
					bool flag7 = count >= 20;
					if (!flag7)
					{
						goto IL_033E;
					}
					InformationMessage.InformationMessageType informationMessageType = (InformationMessage.InformationMessageType)input[1];
					bool flag8 = informationMessageType == InformationMessage.InformationMessageType.PlayerRelation;
					if (flag8)
					{
						output = 39;
						return true;
					}
					bool flag9 = informationMessageType == InformationMessage.InformationMessageType.JoinedGame;
					if (flag9)
					{
						output = 39;
						return true;
					}
					output = 39;
					return true;
				}
			}
			else if (gameServerPacket3 <= GameServerPacket.SkillsLog)
			{
				if (gameServerPacket3 != GameServerPacket.NPCMoveToTarget)
				{
					if (gameServerPacket3 == GameServerPacket.SkillsLog)
					{
						bool flag10 = count >= 2;
						if (flag10)
						{
							output = (int)(input[1] * 3 + 6);
							return true;
						}
						goto IL_033E;
					}
				}
				else
				{
					bool flag11 = count >= 25;
					if (flag11)
					{
						output = (int)(23 + 4 * input[21]);
						return true;
					}
					goto IL_033E;
				}
			}
			else if (gameServerPacket3 != GameServerPacket.WorldItemAction)
			{
				if (gameServerPacket3 != GameServerPacket.OwnedItemAction)
				{
					switch (gameServerPacket3)
					{
					case GameServerPacket.SetState:
					{
						bool flag12 = count >= 7;
						if (flag12)
						{
							output = (int)input[xpac ? 2 : 6];
							return true;
						}
						goto IL_033E;
					}
					case GameServerPacket.MultipleStates:
					{
						bool flag13 = count >= 7;
						if (flag13)
						{
							output = (int)input[6];
							return true;
						}
						goto IL_033E;
					}
					case GameServerPacket.AssignNPC:
					{
						bool flag14 = count >= 13;
						if (flag14)
						{
							output = (int)input[12];
							return true;
						}
						goto IL_033E;
					}
					}
				}
				else
				{
					bool flag15 = count >= 3;
					if (flag15)
					{
						output = (int)input[2];
						return true;
					}
					goto IL_033E;
				}
			}
			else
			{
				bool flag16 = count >= 3;
				if (flag16)
				{
					output = (int)input[2];
					return true;
				}
				goto IL_033E;
			}
			bool flag17 = xpac && GameServerPacketSizes.Res.ContainsKey(gameServerPacket);
			if (flag17)
			{
				output = GameServerPacketSizes.Res[gameServerPacket];
				return output != 0;
			}
			bool flag18 = GameServerPacketSizes.Lod.ContainsKey(gameServerPacket);
			if (flag18)
			{
				output = GameServerPacketSizes.Lod[gameServerPacket];
				return output != 0;
			}
			IL_033E:
			output = 0;
			return false;
		}

		// Token: 0x04008A30 RID: 35376
		public static readonly Dictionary<GameServerPacket, int> Res = new Dictionary<GameServerPacket, int>
		{
			{
				GameServerPacket.AssignPlayer,
				71
			},
			{
				GameServerPacket.TimestampResponse,
				5
			},
			{
				GameServerPacket.Confirm,
				206
			},
			{
				GameServerPacket.AssignMerc,
				24
			},
			{
				GameServerPacket.UnitUseSkillOnTarget,
				20
			},
			{
				GameServerPacket.UnitUseSkill,
				21
			},
			{
				GameServerPacket.PortalInfo,
				12
			},
			{
				GameServerPacket.OpenWaypoint,
				17
			},
			{
				GameServerPacket.CurrentWaypoint,
				4
			},
			{
				GameServerPacket.Unk4a,
				2
			},
			{
				GameServerPacket.NPCMove,
				-1
			},
			{
				GameServerPacket.NPCMoveToTarget,
				-1
			},
			{
				GameServerPacket.SetNPCMode,
				12
			},
			{
				GameServerPacket.CreateMissile,
				72
			},
			{
				GameServerPacket.PortalOwnership,
				79
			},
			{
				GameServerPacket.SummBook,
				14
			},
			{
				GameServerPacket.Relator3,
				23
			},
			{
				GameServerPacket.Relator4,
				0
			},
			{
				GameServerPacket.Relator5,
				10
			},
			{
				GameServerPacket.Relator6,
				5
			},
			{
				GameServerPacket.InformationMessage,
				27
			},
			{
				GameServerPacket.ItemTriggerSkill,
				20
			},
			{
				GameServerPacket.RemoveItemsDisplay,
				6
			},
			{
				GameServerPacket.UseStackableItem,
				3
			},
			{
				GameServerPacket.GameMessage,
				16
			},
			{
				GameServerPacket.StateSkillMove,
				12
			},
			{
				GameServerPacket.PlayerAttributeNotification,
				13
			},
			{
				GameServerPacket.PlayerLifeManaChange,
				17
			},
			{
				GameServerPacket.PlayerLifeManaChangeRegen,
				19
			},
			{
				GameServerPacket.AttributeByte,
				6
			},
			{
				GameServerPacket.AttributeWord,
				7
			},
			{
				GameServerPacket.AttributeDWord,
				9
			},
			{
				GameServerPacket.MercAttributeByte,
				8
			},
			{
				GameServerPacket.MercAttributeUInt16,
				9
			},
			{
				GameServerPacket.MercAttributeUInt32,
				11
			},
			{
				GameServerPacket.EndState,
				8
			},
			{
				GameServerPacket.DelayedState,
				8
			},
			{
				GameServerPacket.MercByteToExperience,
				8
			},
			{
				GameServerPacket.MercWordToExperience,
				9
			}
		};

		// Token: 0x04008A31 RID: 35377
		public static readonly Dictionary<GameServerPacket, int> Lod = new Dictionary<GameServerPacket, int>
		{
			{
				GameServerPacket.GameLoading,
				1
			},
			{
				GameServerPacket.GameLogonReceipt,
				8
			},
			{
				GameServerPacket.GameLogonSuccess,
				1
			},
			{
				GameServerPacket.LoadAct,
				12
			},
			{
				GameServerPacket.LoadDone,
				1
			},
			{
				GameServerPacket.UnloadDone,
				1
			},
			{
				GameServerPacket.GameLogoutSuccess,
				1
			},
			{
				GameServerPacket.MapAdd,
				6
			},
			{
				GameServerPacket.MapRemove,
				6
			},
			{
				GameServerPacket.AssignWarp,
				11
			},
			{
				GameServerPacket.RemoveGroundUnit,
				6
			},
			{
				GameServerPacket.GameHandshake,
				6
			},
			{
				GameServerPacket.NPCGetHit,
				9
			},
			{
				GameServerPacket.PlayerStop,
				13
			},
			{
				GameServerPacket.SetGameObjectMode,
				12
			},
			{
				GameServerPacket.PlayerMove,
				16
			},
			{
				GameServerPacket.PlayerMoveToTarget,
				16
			},
			{
				GameServerPacket.ReportKill,
				8
			},
			{
				GameServerPacket.PlayerReassign,
				11
			},
			{
				GameServerPacket.PlayerLifeManaChangeRegen,
				15
			},
			{
				GameServerPacket.SmallGoldAdd,
				2
			},
			{
				GameServerPacket.ExperienceByte,
				2
			},
			{
				GameServerPacket.ExperienceUInt16,
				3
			},
			{
				GameServerPacket.ExperienceUInt32,
				5
			},
			{
				GameServerPacket.AttributeByte,
				3
			},
			{
				GameServerPacket.AttributeWord,
				4
			},
			{
				GameServerPacket.AttributeDWord,
				6
			},
			{
				GameServerPacket.PlayerAttributeNotification,
				10
			},
			{
				GameServerPacket.UpdateSkill,
				12
			},
			{
				GameServerPacket.UpdatePlayerItemSkill,
				12
			},
			{
				GameServerPacket.AssignSkill,
				13
			},
			{
				GameServerPacket.GameMessage,
				-1
			},
			{
				GameServerPacket.NPCInfo,
				40
			},
			{
				GameServerPacket.UpdateQuestInfo,
				103
			},
			{
				GameServerPacket.UpdateGameQuestLog,
				97
			},
			{
				GameServerPacket.TransactionComplete,
				15
			},
			{
				GameServerPacket.PlaySound,
				8
			},
			{
				GameServerPacket.TimestampResponse,
				0
			},
			{
				GameServerPacket.TradeRequest,
				0
			},
			{
				GameServerPacket.QuestComplete,
				0
			},
			{
				GameServerPacket.UpdateItemStats,
				-1
			},
			{
				GameServerPacket.UseStackableItem,
				8
			},
			{
				GameServerPacket.PlayerClearCursor,
				6
			},
			{
				GameServerPacket.Relator1,
				11
			},
			{
				GameServerPacket.Relator2,
				11
			},
			{
				GameServerPacket.UnitUseSkillOnTarget,
				16
			},
			{
				GameServerPacket.UnitUseSkill,
				17
			},
			{
				GameServerPacket.MercForHire,
				7
			},
			{
				GameServerPacket.MercForHireListStart,
				1
			},
			{
				GameServerPacket.Unk50,
				15
			},
			{
				GameServerPacket.AssignGameObject,
				14
			},
			{
				GameServerPacket.UpdateQuestLog,
				42
			},
			{
				GameServerPacket.PartyRefresh,
				10
			},
			{
				GameServerPacket.OpenUI,
				7
			},
			{
				GameServerPacket.AssignPlayer,
				26
			},
			{
				GameServerPacket.InformationMessage,
				40
			},
			{
				GameServerPacket.PlayerInGame,
				-1
			},
			{
				GameServerPacket.PlayerLeaveGame,
				5
			},
			{
				GameServerPacket.QuestItemState,
				6
			},
			{
				GameServerPacket.UpdateQuestStatus,
				38
			},
			{
				GameServerPacket.Unk5f,
				5
			},
			{
				GameServerPacket.PortalInfo,
				7
			},
			{
				GameServerPacket.ActChange,
				2
			},
			{
				GameServerPacket.OpenWaypoint,
				21
			},
			{
				GameServerPacket.PlayerKillCount,
				7
			},
			{
				GameServerPacket.NPCMove,
				16
			},
			{
				GameServerPacket.NPCMoveToTarget,
				21
			},
			{
				GameServerPacket.SetNPCMode,
				12
			},
			{
				GameServerPacket.NPCAction,
				16
			},
			{
				GameServerPacket.MonsterAttack,
				16
			},
			{
				GameServerPacket.NPCStop,
				10
			},
			{
				GameServerPacket.CreateMissile,
				32
			},
			{
				GameServerPacket.PlayerCorpseVisible,
				10
			},
			{
				GameServerPacket.AboutPlayer,
				13
			},
			{
				GameServerPacket.PlayerInSight,
				6
			},
			{
				GameServerPacket.UpdateUI,
				2
			},
			{
				GameServerPacket.AcceptTrade,
				21
			},
			{
				GameServerPacket.GoldTrade,
				6
			},
			{
				GameServerPacket.SummonAction,
				13
			},
			{
				GameServerPacket.AssignSkillHotkey,
				8
			},
			{
				GameServerPacket.UseSpecialItem,
				6
			},
			{
				GameServerPacket.SetItemState,
				18
			},
			{
				GameServerPacket.Unk7e,
				5
			},
			{
				GameServerPacket.PartyMemberUpdate,
				10
			},
			{
				GameServerPacket.AssignMerc,
				20
			},
			{
				GameServerPacket.PortalOwnership,
				29
			},
			{
				GameServerPacket.UniqueEvents,
				2
			},
			{
				GameServerPacket.NPCWantsInteract,
				6
			},
			{
				GameServerPacket.PlayerPartyRelationship,
				6
			},
			{
				GameServerPacket.PlayerRelationship,
				11
			},
			{
				GameServerPacket.AssignPlayerToParty,
				7
			},
			{
				GameServerPacket.AssignPlayerCorpse,
				10
			},
			{
				GameServerPacket.Pong,
				33
			},
			{
				GameServerPacket.PartyMemberPulse,
				13
			},
			{
				GameServerPacket.NPCIntro,
				26
			},
			{
				GameServerPacket.SkillsLog,
				-1
			},
			{
				GameServerPacket.PlayerLifeManaChange,
				13
			},
			{
				GameServerPacket.WalkVerify,
				9
			},
			{
				GameServerPacket.SwitchWeaponSet,
				1
			},
			{
				GameServerPacket.ItemTriggerSkill,
				16
			},
			{
				GameServerPacket.MercCost,
				7
			},
			{
				GameServerPacket.WorldItemAction,
				-1
			},
			{
				GameServerPacket.OwnedItemAction,
				-1
			},
			{
				GameServerPacket.MercAttributeByte,
				7
			},
			{
				GameServerPacket.MercAttributeUInt16,
				8
			},
			{
				GameServerPacket.MercAttributeUInt32,
				10
			},
			{
				GameServerPacket.MercByteToExperience,
				7
			},
			{
				GameServerPacket.MercWordToExperience,
				8
			},
			{
				GameServerPacket.BaalWaveClear,
				3
			},
			{
				GameServerPacket.DelayedState,
				7
			},
			{
				GameServerPacket.SetState,
				-1
			},
			{
				GameServerPacket.EndState,
				7
			},
			{
				GameServerPacket.MultipleStates,
				-1
			},
			{
				GameServerPacket.NPCHeal,
				7
			},
			{
				GameServerPacket.AssignNPC,
				-1
			},
			{
				GameServerPacket.NPCUpdate,
				12
			},
			{
				GameServerPacket.WardenCheck,
				-1
			},
			{
				GameServerPacket.RequestLogonInfo,
				0
			},
			{
				GameServerPacket.GameOver,
				1
			},
			{
				GameServerPacket.Invalid,
				0
			},
			{
				GameServerPacket.HostedGamesInfo,
				53
			},
			{
				GameServerPacket.DownloadSave,
				0
			},
			{
				GameServerPacket.ConnectionRefused,
				5
			}
		};
	}
}
