using System;
using System.Linq;
using System.Security.Cryptography;
using D2Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BattleNetSharp.D2.Data
{
	// Token: 0x02000B17 RID: 2839
	internal class TerrorZone
	{
		// Token: 0x0600BE7B RID: 48763 RVA: 0x0048B9E8 File Offset: 0x00489BE8
		public static float GetRand(ulong offset)
		{
			ulong num = TerrorZone.seed ^ (TerrorZone.start_time_secs + TerrorZone.terror_time_secs * offset);
			byte[] array = SHA1.HashData(BitConverter.GetBytes(num));
			return BitConverter.ToUInt32(array, 0) / 4.2949673E+09f;
		}

		// Token: 0x0600BE7C RID: 48764 RVA: 0x0048BA2C File Offset: 0x00489C2C
		public static JObject GetNext(ulong offset, bool debug)
		{
			float rand = TerrorZone.GetRand(offset);
			float num = 0f;
			foreach (JToken jtoken in TerrorZone.zones)
			{
				num += Extensions.Value<float>(jtoken["prob"]);
				bool flag = num > rand;
				if (flag)
				{
					float num2 = Extensions.Value<float>(jtoken["prob"]) / (float)(TerrorZone.num_zones - 1);
					foreach (JToken jtoken2 in TerrorZone.zones)
					{
						jtoken2["prob"] = num2 + Extensions.Value<float>(jtoken2["prob"]);
						bool flag2 = Extensions.Value<int>(jtoken2["id"]) == Extensions.Value<int>(jtoken["id"]);
						if (flag2)
						{
							jtoken["prob"] = 0f;
						}
					}
					if (debug)
					{
						IOrderedEnumerable<JToken> orderedEnumerable = TerrorZone.zones.OrderByDescending((JToken z) => Extensions.Value<float>(z["prob"]));
						IOrderedEnumerable<JToken> orderedEnumerable2 = TerrorZone.zones.OrderBy((JToken z) => Extensions.Value<float>(z["prob"]));
						string[] array = new string[7];
						int num3 = 0;
						JToken jtoken3 = orderedEnumerable.First<JToken>()["prob"];
						array[num3] = ((jtoken3 != null) ? jtoken3.ToString() : null);
						array[1] = "(";
						array[2] = ((AreaLevel)Extensions.Value<int>(orderedEnumerable.First<JToken>()["levels"][0]["level_id"])).ToString();
						array[3] = ", ";
						int num4 = 4;
						JToken jtoken4 = orderedEnumerable.Skip(1).First<JToken>()["prob"];
						array[num4] = ((jtoken4 != null) ? jtoken4.ToString() : null);
						array[5] = ", ";
						int num5 = 6;
						JToken jtoken5 = orderedEnumerable2.Skip(1).First<JToken>()["prob"];
						array[num5] = ((jtoken5 != null) ? jtoken5.ToString() : null);
						Console.WriteLine(string.Concat(array));
					}
					return (JObject)jtoken;
				}
			}
			return null;
		}

		// Token: 0x0600BE7D RID: 48765 RVA: 0x0048BCC8 File Offset: 0x00489EC8
		public static void AddWeight(int zone)
		{
			JToken jtoken = TerrorZone.zones.First((JToken b) => Extensions.Value<int>(b["id"]) == zone);
			float num = Extensions.Value<float>(jtoken["prob"]) / (float)(TerrorZone.num_zones - 1);
			foreach (JToken jtoken2 in TerrorZone.zones)
			{
				jtoken2["prob"] = num + Extensions.Value<float>(jtoken2["prob"]);
			}
			jtoken["prob"] = 0f;
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x0048BD8C File Offset: 0x00489F8C
		public static bool Generate()
		{
			ulong num = 1643241600UL;
			ulong num2 = 3600UL;
			uint num3 = 0U;
			int num4 = (int)(TerrorZone.GetRand((ulong)num3++) * (float)TerrorZone.num_zones) + 1;
			foreach (JToken jtoken in TerrorZone.zones)
			{
				jtoken["prob"] = 1f / (float)(TerrorZone.num_zones - 1);
			}
			foreach (JToken jtoken2 in TerrorZone.zones)
			{
				bool flag = Extensions.Value<int>(jtoken2["id"]) == num4;
				if (flag)
				{
					jtoken2["prob"] = 0f;
				}
			}
			bool flag2 = false;
			long tickCount = Environment.TickCount64;
			for (;;)
			{
				DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)(num + num2 * (ulong)num3));
				JObject next = TerrorZone.GetNext((ulong)num3, flag2);
				bool flag3 = dateTimeOffset > DateTimeOffset.Now.AddHours(-3.0);
				if (flag3)
				{
					bool flag4 = (byte)Extensions.Value<int>(next["levels"][0]["level_id"]) == 113;
					if (flag4)
					{
						JObject next2 = TerrorZone.GetNext((ulong)(num3 + 1U), flag2);
						JObject next3 = TerrorZone.GetNext((ulong)(num3 + 2U), flag2);
						bool flag5 = (byte)Extensions.Value<int>(next2["levels"][0]["level_id"]) == 78;
						if (flag5)
						{
							bool flag6 = (byte)Extensions.Value<int>(next3["levels"][0]["level_id"]) == 4;
							if (flag6)
							{
								break;
							}
						}
					}
					string[] array = new string[5];
					int num5 = 0;
					JToken jtoken3 = next["id"];
					array[num5] = ((jtoken3 != null) ? jtoken3.ToString() : null);
					array[1] = " : ";
					array[2] = ((AreaLevel)Extensions.Value<int>(next["levels"][0]["level_id"])).ToString();
					array[3] = " : ";
					array[4] = dateTimeOffset.ToLocalTime().ToString();
					Console.WriteLine(string.Concat(array));
				}
				num3 += 1U;
			}
			return true;
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x0048C038 File Offset: 0x0048A238
		public static void GenerateOld()
		{
			ulong num = 1643241600UL;
			ulong num2 = 3600UL;
			uint num3 = 0U;
			int num4 = (int)(TerrorZone.GetRand((ulong)num3++) * (float)TerrorZone.num_zones) + 1;
			foreach (JToken jtoken in TerrorZone.zones)
			{
				jtoken["prob"] = 1f / (float)(TerrorZone.num_zones - 1);
			}
			foreach (JToken jtoken2 in TerrorZone.zones)
			{
				bool flag = Extensions.Value<int>(jtoken2["id"]) == num4;
				if (flag)
				{
					jtoken2["prob"] = 0f;
				}
			}
			bool flag2 = false;
			long tickCount = Environment.TickCount64;
			for (;;)
			{
				DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)(num + num2 * (ulong)num3));
				JObject next = TerrorZone.GetNext((ulong)num3, flag2);
				bool flag3 = dateTimeOffset > DateTimeOffset.Now.AddHours(-1.0);
				if (flag3)
				{
					string[] array = new string[5];
					int num5 = 0;
					JToken jtoken3 = next["id"];
					array[num5] = ((jtoken3 != null) ? jtoken3.ToString() : null);
					array[1] = " : ";
					array[2] = ((AreaLevel)Extensions.Value<int>(next["levels"][0]["level_id"])).ToString();
					array[3] = " : ";
					array[4] = dateTimeOffset.ToLocalTime().ToString();
					Console.WriteLine(string.Concat(array));
				}
				num3 += 1U;
			}
		}

		// Token: 0x040091C2 RID: 37314
		private static ulong seed = 16664395743979097666UL;

		// Token: 0x040091C3 RID: 37315
		private static ulong start_time_secs = 1643238000UL;

		// Token: 0x040091C4 RID: 37316
		private static ulong terror_time_secs = 3600UL;

		// Token: 0x040091C5 RID: 37317
		private static string jsontxt = "\r\n{\r\n    \"desecrated_zones\": [\r\n        {\r\n            \"start_time_utc\": \"2022-01-27 00:00:00\",\r\n            /* \"end_time_utc\": \"2022-12-15 00:00:00\", */ /* Use end time to automate multiple configs. Useful for events. */\r\n            \"terror_duration_min\": 60,\r\n            \"terror_break_min\": 0,\r\n            \"seed\": 16664395743979097666, /* UInt64. Can't be above 18446744073709551615 */\r\n            \"non_ladder_enabled\": true,\r\n            \"enabled_normal\": true,\r\n            \"enabled_nightmare\": true,\r\n            \"enabled_hell\": true,\r\n            \"default_normal\": {\r\n                \"bound_incl_min\": 3, /* Minimum level of a terrorized monster. MAX(bound_incl_min, original_monster_level) */\r\n                \"bound_incl_max\": 45, /* Maximum level of a terrorized monster. MAX(bound_incl_max, original_monster_level) */\r\n                \"boost_level\": 2, /* player_level + boost_level = terrorized_monster_level */\r\n                \"difficulty_scale\": 1, /* Fake the amount of players in the game. AKA /players X */\r\n                \"boost_experience_percent\": 25 /* Bonus experience percentage applied at to the monster's base experience in monstats.txt */\r\n            },\r\n            \"default_nightmare\": {\r\n                \"bound_incl_min\": 40,\r\n                \"bound_incl_max\": 71,\r\n                \"boost_level\": 2,\r\n                \"difficulty_scale\": 1,\r\n                \"boost_experience_percent\": 25\r\n            },\r\n            \"default_hell\": {\r\n                \"bound_incl_min\": 70,\r\n                \"bound_incl_max\": 96,\r\n                \"boost_level\": 2,\r\n                \"difficulty_scale\": 1,\r\n                \"boost_experience_percent\": 25\r\n            },\r\n            \"warnings\": [\r\n                {\r\n                    \"announce_time_min\": 10,\r\n                    \"tier\": 1\r\n                },\r\n                {\r\n                    \"announce_time_min\": 5,\r\n                    \"tier\": 2\r\n                },\r\n                {\r\n                    \"announce_time_min\": 1,\r\n                    \"tier\": 3\r\n                },\r\n                {\r\n                    /* DO NOT REMOVE! ALWAYS NEED A TIER 0 AT MINUTE 0. DO NOT REMOVE! */\r\n                    \"announce_time_min\": 0,\r\n                    \"tier\": 0\r\n                }\r\n            ],\r\n            \"zones\": [\r\n                {\r\n                    /* Burial Grounds, Crypt, and Mausoleum */\r\n                    \"id\": 1,\r\n                    /* You can have a MAX of 20 desecrated levels at a time */\r\n                    \"levels\": [\r\n                        {\r\n                            /* Burial Grounds */\r\n                            \"level_id\": 17,\r\n                            /* Cold Plains */\r\n                            \"waypoint_level_id\": 3\r\n                            /*\r\n                                The ability to override the defaults on a per-level basis exists.\r\n                                You can also only include the fields you want to modify.\r\n                                Leave the following commented out lines in as an example:\r\n                                \"normal\": {\r\n                                    \"bound_incl_min\": 1,\r\n                                    \"bound_incl_max\": 40,\r\n                                    \"boost_level\": 2,\r\n                                    \"difficulty_scale\": 1,\r\n                                    \"boost_experience_percent\": 25\r\n                                },\r\n                                \"nightmare\": {\r\n                                    \"boost_level\": 2,\r\n                                    \"difficulty_scale\": 1,\r\n                                    \"boost_experience_percent\": 25\r\n                                },\r\n                                \"hell\": {\r\n                                    \"bound_incl_min\": 66,\r\n                                    \"bound_incl_max\": 95,\r\n                                }\r\n                                */\r\n                        },\r\n                        {\r\n                            /* The Crypt */\r\n                            \"level_id\": 18\r\n                        },\r\n                        {\r\n                            /* Mausoleum */\r\n                            \"level_id\": 19\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Cathedral and Catacombs */\r\n                    \"id\": 2,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Cathedral */\r\n                            \"level_id\": 33,\r\n                            /* Inner Cloister */\r\n                            \"waypoint_level_id\": 32\r\n                        },\r\n                        {\r\n                            /* Catacombs Level 1 */\r\n                            \"level_id\": 34\r\n                        },\r\n                        {\r\n                            /* Catacombs Level 2 */\r\n                            \"level_id\": 35\r\n                        },\r\n                        {\r\n                            /* Catacombs Level 3 */\r\n                            \"level_id\": 36\r\n                        },\r\n                        {\r\n                            /* Catacombs Level 4 */\r\n                            \"level_id\": 37\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Cold Plains and Cave */\r\n                    \"id\": 3,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Cold Plains */\r\n                            \"level_id\": 3,\r\n                            /* Cold Plains */\r\n                            \"waypoint_level_id\": 3\r\n                        },\r\n                        {\r\n                            /* Cave Level 1 */\r\n                            \"level_id\": 9\r\n                        },\r\n                        {\r\n                            /* Cave Level 2 */\r\n                            \"level_id\": 13\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Dark Wood and Underground Passage */\r\n                    \"id\": 4,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Dark Wood */\r\n                            \"level_id\": 5,\r\n                            /* Dark Wood */\r\n                            \"waypoint_level_id\": 5\r\n                        },\r\n                        {\r\n                            /* Underground Passage Level 1 */\r\n                            \"level_id\": 10\r\n                        },\r\n                        {\r\n                            /* Underground Passage Level 2  */\r\n                            \"level_id\": 14\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Blood Moor and Den of Evil */\r\n                    \"id\": 5,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Blood Moor */\r\n                            \"level_id\": 2,\r\n                            /* Rogue Encampment */\r\n                            \"waypoint_level_id\": 1\r\n                        },\r\n                        {\r\n                            /* Den of Evil */\r\n                            \"level_id\": 8\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Jail and Barracks */\r\n                    \"id\": 6,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Barracks */\r\n                            \"level_id\": 28,\r\n                            /* Outer Cloister */\r\n                            \"waypoint_level_id\": 27\r\n                        },\r\n                        {\r\n                            /* Jail Level 1 */\r\n                            \"level_id\": 29\r\n                        },\r\n                        {\r\n                            /* Jail Level 2 */\r\n                            \"level_id\": 30\r\n                        },\r\n                        {\r\n                            /* Jail Level 3 */\r\n                            \"level_id\": 31\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Moo Moo Farm */\r\n                    \"id\": 7,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Moo Moo Farm */\r\n                            \"level_id\": 39,\r\n                            /* Rogue Encampment */\r\n                            \"waypoint_level_id\": 1\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Stony Field */\r\n                    \"id\": 8,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Stony Field */\r\n                            \"level_id\": 4,\r\n                            /* Stony Field */\r\n                            \"waypoint_level_id\": 4\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Black Marsh and the Hole */\r\n                    \"id\": 9,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Black Marsh */\r\n                            \"level_id\": 6,\r\n                            /* Black Marsh */\r\n                            \"waypoint_level_id\": 6\r\n                        },\r\n                        {\r\n                            /* Hole Level 1 */\r\n                            \"level_id\": 11\r\n                        },\r\n                        {\r\n                            /* Hole Level 2 */\r\n                            \"level_id\": 15\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Forgotten Tower */\r\n                    \"id\": 10,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Forgotten Tower */\r\n                            \"level_id\": 20,\r\n                            /* Black Marsh */\r\n                            \"waypoint_level_id\": 6\r\n                        },\r\n                        {\r\n                            /* Tower Cellar Level 1 */\r\n                            \"level_id\": 21\r\n                        },\r\n                        {\r\n                            /* Tower Cellar Level 2 */\r\n                            \"level_id\": 22\r\n                        },\r\n                        {\r\n                            /* Tower Cellar Level 3 */\r\n                            \"level_id\": 23\r\n                        },\r\n                        {\r\n                            /* Tower Cellar Level 4 */\r\n                            \"level_id\": 24\r\n                        },\r\n                        {\r\n                            /* Tower Cellar Level 5 */\r\n                            \"level_id\": 25\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Pit */\r\n                    \"id\": 11,\r\n                    \"levels\": [\r\n                        {\r\n                            /*  Pit Level 1 */\r\n                            \"level_id\": 12,\r\n                            /* Outer Cloister */\r\n                            \"waypoint_level_id\": 27\r\n                        },\r\n                        {\r\n                            /* Pit Level 2 */\r\n                            \"level_id\": 16\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Tristram */\r\n                    \"id\": 12,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Tristram */\r\n                            \"level_id\": 38,\r\n                            /* Stony Field */\r\n                            \"waypoint_level_id\": 4\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Lut Gholein Sewers */\r\n                    \"id\": 13,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Sewers Level 1 */\r\n                            \"level_id\": 47,\r\n                            /* Lut Gholein */\r\n                            \"waypoint_level_id\": 40\r\n                        },\r\n                        {\r\n                            /* Sewers Level 2 */\r\n                            \"level_id\": 48\r\n                            /* Sewers Level 2 */\r\n                            /*waypoint_level_id: 48*/\r\n                        },\r\n                        {\r\n                            /* Sewers Level 3 */\r\n                            \"level_id\": 49\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Stony Tomb and Rocky Waste */\r\n                    \"id\": 14,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Rocky Waste */\r\n                            \"level_id\": 41,\r\n                            /* Lut Gholein */\r\n                            \"waypoint_level_id\": 40\r\n                        },\r\n                        {\r\n                            /* Stony Tomb Level 1 */\r\n                            \"level_id\": 55\r\n                        },\r\n                        {\r\n                            /* Stony Tomb Level 2 */\r\n                            \"level_id\": 59\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Dry Hills and Halls of the Dead */\r\n                    \"id\": 15,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Dry Hills */\r\n                            \"level_id\": 42,\r\n                            /* Dry Hills */\r\n                            \"waypoint_level_id\": 42\r\n                        },\r\n                        {\r\n                            /* Halls of the Dead Level 1 */\r\n                            \"level_id\": 56\r\n                        },\r\n                        {\r\n                            /* Halls of the Dead Level 2 */\r\n                            \"level_id\": 57\r\n                        },\r\n                        {\r\n                            /* Halls of the Dead Level 3 */\r\n                            \"level_id\": 60\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Far Oasis */\r\n                    \"id\": 16,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Far Oasis */\r\n                            \"level_id\": 43,\r\n                            /* Far Oasis */\r\n                            \"waypoint_level_id\": 43\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Lost City, Valley of Snakes, and Claw Viper temple */\r\n                    \"id\": 17,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Lost City */\r\n                            \"level_id\": 44,\r\n                            /* Lost City */\r\n                            \"waypoint_level_id\": 44\r\n                        },\r\n                        {\r\n                            /* Valley of Snakes */\r\n                            \"level_id\": 45\r\n                        },\r\n                        {\r\n                            /* Claw Viper Temple Level 1 */\r\n                            \"level_id\": 58\r\n                        },\r\n                        {\r\n                            /* Claw Viper Temple Level 2 */\r\n                            \"level_id\": 61\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Ancient Tunnels */\r\n                    \"id\": 18,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Ancient Tunnels */\r\n                            \"level_id\": 65,\r\n                            /* Lost City */\r\n                            \"waypoint_level_id\": 44\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Tal Rasha's Tombs */\r\n                    \"id\": 19,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Tal Rasha's Tomb */\r\n                            \"level_id\": 66,\r\n                            /* Canyon of the Magi */\r\n                            \"waypoint_level_id\": 46\r\n                        },\r\n                        {\r\n                            /* Tal Rasha's Tomb */\r\n                            \"level_id\": 67\r\n                        },\r\n                        {\r\n                            /* Tal Rasha's Tomb */\r\n                            \"level_id\": 68\r\n                        },\r\n                        {\r\n                            /* Tal Rasha's Tomb */\r\n                            \"level_id\": 69\r\n                        },\r\n                        {\r\n                            /* Tal Rasha's Tomb */\r\n                            \"level_id\": 70\r\n                        },\r\n                        {\r\n                            /* Tal Rasha's Tomb */\r\n                            \"level_id\": 71\r\n                        },\r\n                        {\r\n                            /* Tal Rasha's Tomb */\r\n                            \"level_id\": 72\r\n                        },\r\n                        {\r\n                            /* Tal Rasha's Chamber */\r\n                            \"level_id\": 73\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Arcane Sanctuary */\r\n                    \"id\": 20,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Arcane Sanctuary */\r\n                            \"level_id\": 74,\r\n                            /* Arcane Sanctuary */\r\n                            \"waypoint_level_id\": 74\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Spider Forest and Spider Cavern */\r\n                    \"id\": 21,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Spider Forest */\r\n                            \"level_id\": 76,\r\n                            /* Spider Forest */\r\n                            \"waypoint_level_id\": 76\r\n                        },\r\n                        {\r\n                            /* Spider Cavern */\r\n                            \"level_id\": 85\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Great Marsh */\r\n                    \"id\": 22,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Great Marsh */\r\n                            \"level_id\": 77,\r\n                            /* Great Marsh */\r\n                            \"waypoint_level_id\": 77\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Flayer Jungle and Flayer Dungeon */\r\n                    \"id\": 23,\r\n                    \"levels\": [\r\n                        {\r\n                            /* Flayer Jungle */\r\n                            \"level_id\": 78,\r\n                            /* Flayer Jungle */\r\n                            \"waypoint_level_id\": 78\r\n                        },\r\n                        {\r\n                            /* Flayer Dungeon Level 1 */\r\n                            \"level_id\": 88\r\n                        },\r\n                        {\r\n                            /* Flayer Dungeon Level 2 */\r\n                            \"level_id\": 89\r\n                        },\r\n                        {\r\n                            /* Flayer Dungeon Level 3 */\r\n                            \"level_id\": 91\r\n                        }\r\n                    ]\r\n                },\r\n                {\r\n                    /* Kurast Bazaar and Temples *[...string is too long...]";

		// Token: 0x040091C6 RID: 37318
		private static JObject json = JsonConvert.DeserializeObject<JObject>(TerrorZone.jsontxt);

		// Token: 0x040091C7 RID: 37319
		private static JArray zones = (JArray)((JArray)TerrorZone.json["desecrated_zones"])[0]["zones"];

		// Token: 0x040091C8 RID: 37320
		private static int num_zones = TerrorZone.zones.Count<JToken>();
	}
}
