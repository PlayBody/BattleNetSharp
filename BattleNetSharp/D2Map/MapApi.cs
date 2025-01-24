using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using D2Data;
using static D2Map.UnmanagedStructs;

namespace D2Map
{
	// Token: 0x020008F2 RID: 2290
	internal static class MapApi
    {
        // Token: 0x0600B763 RID: 46947
		[DllImport("d2mapapi.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool Initialize(string path);

		// Token: 0x0600B764 RID: 46948
		[DllImport("d2mapapi.dll", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern UnmanagedStructs.Level* GetLevel(UnmanagedStructs.ActMisc* misc, AreaLevel levelno);

		// Token: 0x0600B765 RID: 46949
		[DllImport("d2mapapi.dll", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern void InitLevel(UnmanagedStructs.Level* pLevel);

		// Token: 0x0600B766 RID: 46950
		[DllImport("d2mapapi.dll", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern void AddRoomData(UnmanagedStructs.Act* pAct, uint levelid, uint xpos, uint ypos, UnmanagedStructs.Room* pRoom);

		// Token: 0x0600B767 RID: 46951
		[DllImport("d2mapapi.dll", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern void RemoveRoomData(UnmanagedStructs.Act* pAct, uint levelid, uint xpos, uint ypos, UnmanagedStructs.Room* pRoom);

		// Token: 0x0600B768 RID: 46952
		[DllImport("d2mapapi.dll", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern UnmanagedStructs.Act* LoadAct(ActLocation actno, uint seed, uint difficulty, uint TownLevelId);

		// Token: 0x0600B769 RID: 46953
		[DllImport("d2mapapi.dll", CallingConvention = CallingConvention.Cdecl)]
		private unsafe static extern void UnloadAct(UnmanagedStructs.Act* pAct);

		// Token: 0x0600B76A RID: 46954
		[DllImport("kernel32.dll")]
		private static extern uint GetLastError();

		// Token: 0x0600B76B RID: 46955 RVA: 0x002D8820 File Offset: 0x002D6A20
		static MapApi()
		{
			Process[] processesByName = Process.GetProcessesByName("d2mapper");
			bool flag = processesByName.Length != 0;
			if (!flag)
			{
				Process.Start("C:\\Users\\shalzuth\\Documents\\GitHub\\BattleNetSharp\\d2mapper\\bin\\Debug\\net6.0\\d2mapper.exe");
			}
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x002D886C File Offset: 0x002D6A6C
		public unsafe static ConcurrentDictionary<AreaLevel, Level> GetLevels(uint mapSeed, GameDifficulty difficulty, ActLocation act, bool excludeCollisionMask, bool excludeTileData)
		{
			Encoding utf = Encoding.UTF8;
			HttpClient httpClient = MapApi.client;
			string[] array = new string[6];
			array[0] = "http://127.0.0.1:5000/";
			int num = 1;
			int num2 = (int)difficulty;
			array[num] = num2.ToString();
			array[2] = "/";
			int num3 = 3;
			num2 = (int)act;
			array[num3] = num2.ToString();
			array[4] = "/";
			array[5] = mapSeed.ToString();
			byte[] array2 = Convert.FromBase64String(utf.GetString(httpClient.GetByteArrayAsync(string.Concat(array)).Result));
			bool flag = mapSeed > 0U;
			ConcurrentDictionary<AreaLevel, Level> concurrentDictionary;
			if (flag)
			{
				concurrentDictionary = Level.GetAllLevelsCompressed(array2);
			}
			else
			{
				while (!MapApi.Initialized)
				{
				}
				ConcurrentDictionary<AreaLevel, Level> concurrentDictionary2 = new ConcurrentDictionary<AreaLevel, Level>();
				object gettingLevel = MapApi.GettingLevel;
				lock (gettingLevel)
				{
					uint townLevel = (uint)AreaLevelHelper.GetTownLevel(act);
					UnmanagedStructs.Act* ptr = MapApi.LoadAct(act, mapSeed, (uint)difficulty, (uint)AreaLevelHelper.GetTownLevel(act));
					for (AreaLevel areaLevel = AreaLevelHelper.GetTownLevel(act); areaLevel <= AreaLevelHelper.GetLastLevel(act); areaLevel += 1)
					{
						UnmanagedStructs.Level* level = MapApi.GetLevel(ptr->pActMisc, areaLevel);
						bool flag3 = level->pRoomExFirst == null;
						if (flag3)
						{
							MapApi.InitLevel(level);
						}
						Level level2 = new Level(level);
						for (UnmanagedStructs.RoomEx* ptr2 = level->pRoomExFirst; ptr2 != null; ptr2 = ptr2->pRoomExNext)
						{
							bool flag4 = false;
							bool flag5 = ptr2->pRoom == null;
							if (flag5)
							{
								MapApi.AddRoomData(ptr, (uint)areaLevel, ptr2->dwPosX, ptr2->dwPosY, null);
								flag4 = true;
							}
                            for (uint roomIndex = 0U; roomIndex < ptr2->dwRoomsNear; roomIndex++)
                            {
                                // Calculate the pointer to the nearby room
                                var nearbyRoomPtr = (IntPtr*)(ptr2->pRoom2Near + roomIndex * sizeof(UnmanagedStructs.RoomEx*) / sizeof(UnmanagedStructs.RoomEx*));
								// [Ares] should review
                                var nearbyLevelNo = level->dwLevelNo;

                                // Check if the nearby room level number is different from the current level
                                if (level->dwLevelNo != nearbyLevelNo)
                                {
                                    // Check if the nearby level is not already in the AdjacentLevels list
                                    if (!level2.AdjacentLevels.Contains((AreaLevel)nearbyLevelNo))
                                    {
                                        level2.AdjacentLevels.Add((AreaLevel)nearbyLevelNo);
                                    }
                                }
                            }
                            Room room = new Room(ptr2, excludeCollisionMask, excludeTileData);
							level2.Rooms.Add(room);
							bool flag8 = flag4;
							if (flag8)
							{
								MapApi.RemoveRoomData(ptr, (uint)areaLevel, ptr2->dwPosX, ptr2->dwPosY, ptr2->pRoom);
							}
						}
						concurrentDictionary2.TryAdd(areaLevel, level2);
					}
					MapApi.UnloadAct(ptr);
				}
				concurrentDictionary = concurrentDictionary2;
			}
			return concurrentDictionary;
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x002D8B38 File Offset: 0x002D6D38
		public static ConcurrentDictionary<AreaLevel, Level> GetLevels(uint mapSeed, GameDifficulty difficulty, bool excludeCollisionMask, bool excludeTileData)
		{
			ConcurrentDictionary<AreaLevel, Level> concurrentDictionary = new ConcurrentDictionary<AreaLevel, Level>();
			for (ActLocation actLocation = ActLocation.Act1; actLocation <= ActLocation.Act5; actLocation += 1)
			{
				ConcurrentDictionary<AreaLevel, Level> levels = MapApi.GetLevels(mapSeed, difficulty, actLocation, excludeCollisionMask, excludeTileData);
				foreach (KeyValuePair<AreaLevel, Level> keyValuePair in levels)
				{
					concurrentDictionary.TryAdd(keyValuePair.Key, keyValuePair.Value);
				}
			}
			return concurrentDictionary;
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x002D8BC4 File Offset: 0x002D6DC4
		public static ConcurrentDictionary<AreaLevel, Level> GetActLevels(uint mapSeed, GameDifficulty difficulty, ActLocation act, bool excludeCollisionMask, bool excludeTileData)
		{
			ConcurrentDictionary<AreaLevel, Level> concurrentDictionary = new ConcurrentDictionary<AreaLevel, Level>();
			ConcurrentDictionary<AreaLevel, Level> levels = MapApi.GetLevels(mapSeed, difficulty, act, excludeCollisionMask, excludeTileData);
			foreach (KeyValuePair<AreaLevel, Level> keyValuePair in levels)
			{
				concurrentDictionary.TryAdd(keyValuePair.Key, keyValuePair.Value);
			}
			return concurrentDictionary;
		}

		// Token: 0x040069DC RID: 27100
		private static bool Initialized = false;

		// Token: 0x040069DD RID: 27101
		public static object GettingLevel = new object();

		// Token: 0x040069DE RID: 27102
		private static HttpClient client = new HttpClient();
	}
}
