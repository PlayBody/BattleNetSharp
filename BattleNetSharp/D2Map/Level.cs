using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using D2Data;
using D2Map.Pathfinding;
using Roy_T.AStar.Graphs;
using Roy_T.AStar.Grids;
using Roy_T.AStar.Paths;
using Roy_T.AStar.Primitives;

namespace D2Map
{
	// Token: 0x020008F3 RID: 2291
	public class Level
	{
		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600B76F RID: 46959 RVA: 0x002D8C38 File Offset: 0x002D6E38
		// (set) Token: 0x0600B770 RID: 46960 RVA: 0x002D8C40 File Offset: 0x002D6E40
		public uint LevelId { get; set; }

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600B771 RID: 46961 RVA: 0x002D8C49 File Offset: 0x002D6E49
		// (set) Token: 0x0600B772 RID: 46962 RVA: 0x002D8C51 File Offset: 0x002D6E51
		public uint X { get; set; }

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600B773 RID: 46963 RVA: 0x002D8C5A File Offset: 0x002D6E5A
		// (set) Token: 0x0600B774 RID: 46964 RVA: 0x002D8C62 File Offset: 0x002D6E62
		public uint Y { get; set; }

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600B775 RID: 46965 RVA: 0x002D8C6B File Offset: 0x002D6E6B
		// (set) Token: 0x0600B776 RID: 46966 RVA: 0x002D8C73 File Offset: 0x002D6E73
		public uint Width { get; set; }

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600B777 RID: 46967 RVA: 0x002D8C7C File Offset: 0x002D6E7C
		// (set) Token: 0x0600B778 RID: 46968 RVA: 0x002D8C84 File Offset: 0x002D6E84
		public uint Height { get; set; }

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600B779 RID: 46969 RVA: 0x002D8C8D File Offset: 0x002D6E8D
		// (set) Token: 0x0600B77A RID: 46970 RVA: 0x002D8C95 File Offset: 0x002D6E95
		public List<Room> Rooms { get; set; } = new List<Room>();

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600B77B RID: 46971 RVA: 0x002D8C9E File Offset: 0x002D6E9E
		// (set) Token: 0x0600B77C RID: 46972 RVA: 0x002D8CA6 File Offset: 0x002D6EA6
		public List<AreaLevel> AdjacentLevels { get; set; } = new List<AreaLevel>();

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600B77D RID: 46973 RVA: 0x002D8CAF File Offset: 0x002D6EAF
		// (set) Token: 0x0600B77E RID: 46974 RVA: 0x002D8CB7 File Offset: 0x002D6EB7
		public Dictionary<Vector2, AreaLevel> Exits { get; set; } = new Dictionary<Vector2, AreaLevel>();

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600B77F RID: 46975 RVA: 0x002D8CC0 File Offset: 0x002D6EC0
		public List<PresetUnit> Units
		{
			get
			{
				return this.Rooms.SelectMany((Room r) => r.PresetUnits).ToList<PresetUnit>();
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600B780 RID: 46976 RVA: 0x002D8D04 File Offset: 0x002D6F04
		public int Tiles
		{
			get
			{
				return this.Rooms.Sum((Room r) => r.WallCnt + r.FloorCnt);
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600B781 RID: 46977 RVA: 0x002D8D40 File Offset: 0x002D6F40
		public List<string> UsedLibs
		{
			get
			{
				return this.Rooms.SelectMany((Room r) => r.UsedLibs).Distinct<string>().ToList<string>();
			}
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x002D8D88 File Offset: 0x002D6F88
		public static byte[] Compress(byte[] data)
		{
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionLevel.Optimal))
			{
				deflateStream.Write(data, 0, data.Length);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x002D8DD8 File Offset: 0x002D6FD8
		public static byte[] Decompress(byte[] data)
		{
			MemoryStream memoryStream = new MemoryStream();
			using (DeflateStream deflateStream = new DeflateStream(new MemoryStream(data), CompressionMode.Decompress))
			{
				deflateStream.CopyTo(memoryStream);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x002D8E28 File Offset: 0x002D7028
		public static byte[] GetAllLevelBytesCompressed(ConcurrentDictionary<AreaLevel, Level> Levels)
		{
			return Level.Compress(Level.GetAllLevelBytes(Levels).ToArray());
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x002D8E4C File Offset: 0x002D704C
		public static ConcurrentDictionary<AreaLevel, Level> GetAllLevelsCompressed(byte[] b)
		{
			return Level.GetAllLevels(Level.Decompress(b).ToList<byte>());
		}

		// Token: 0x0600B786 RID: 46982 RVA: 0x002D8E70 File Offset: 0x002D7070
		public static List<byte> GetAllLevelBytes(ConcurrentDictionary<AreaLevel, Level> Levels)
		{
			List<byte> list = new List<byte>();
			list.AddRange(BitConverter.GetBytes(Levels.Count<KeyValuePair<AreaLevel, Level>>()));
			foreach (KeyValuePair<AreaLevel, Level> keyValuePair in Levels)
			{
				List<byte> bytes = keyValuePair.Value.GetBytes();
				list.AddRange(BitConverter.GetBytes(bytes.Count<byte>()));
				list.AddRange(bytes);
			}
			list.AddRange(BitConverter.GetBytes(Room.TileLib.Count<KeyValuePair<short, Tile>>()));
			foreach (KeyValuePair<short, Tile> keyValuePair2 in Room.TileLib)
			{
				list.AddRange(keyValuePair2.Value.GetBytes());
			}
			return list;
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x002D8F64 File Offset: 0x002D7164
		public static ConcurrentDictionary<AreaLevel, Level> GetAllLevels(List<byte> b)
		{
			ConcurrentDictionary<AreaLevel, Level> concurrentDictionary = new ConcurrentDictionary<AreaLevel, Level>();
			byte[] array = b.ToArray();
			uint num = BitConverter.ToUInt32(array, 0);
			int num2 = 0;
			int num3 = 0;
			while ((long)num3 < (long)((ulong)num))
			{
				int num4 = BitConverter.ToInt32(array, 4 + num2);
				List<byte> list = b.Skip(4 + num2 + 4).Take(num4).ToList<byte>();
				Level level = new Level(list);
				num2 += 4 + num4;
				concurrentDictionary[(AreaLevel)level.LevelId] = level;
				num3++;
			}
			return concurrentDictionary;
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x002D8FF0 File Offset: 0x002D71F0
		public List<byte> GetBytes()
		{
			List<byte> list = new List<byte>();
			list.AddRange(BitConverter.GetBytes(this.LevelId));
			list.AddRange(BitConverter.GetBytes(this.X));
			list.AddRange(BitConverter.GetBytes(this.Y));
			list.AddRange(BitConverter.GetBytes(this.Width));
			list.AddRange(BitConverter.GetBytes(this.Height));
			list.AddRange(BitConverter.GetBytes(this.Rooms.Count<Room>()));
			foreach (Room room in this.Rooms)
			{
				list.AddRange(room.GetBytes());
			}
			return list;
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x002D90C8 File Offset: 0x002D72C8
		public Level(List<byte> b)
		{
			byte[] array = b.ToArray();
			this.LevelId = BitConverter.ToUInt32(array, 0);
			this.X = BitConverter.ToUInt32(array, 4);
			this.Y = BitConverter.ToUInt32(array, 8);
			this.Width = BitConverter.ToUInt32(array, 12);
			this.Height = BitConverter.ToUInt32(array, 16);
			uint num = BitConverter.ToUInt32(array, 20);
			int num2 = 0;
			int num3 = 0;
			while ((long)num3 < (long)((ulong)num))
			{
				Room room = new Room(b.Skip(24 + num2).ToList<byte>());
				num2 += room.GetBytes().Count<byte>();
				this.Rooms.Add(room);
				num3++;
			}
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x002D91BC File Offset: 0x002D73BC
		public unsafe Level(UnmanagedStructs.Level* level)
		{
			this.LevelId = level->dwLevelNo;
			this.X = level->dwPosX * 5U;
			this.Y = level->dwPosY * 5U;
			this.Width = level->dwSizeX * 5U;
			this.Height = level->dwSizeY * 5U;
			this.Rooms = new List<Room>();
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x002D9264 File Offset: 0x002D7464
		public Level()
		{
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x002D92B4 File Offset: 0x002D74B4
		public void StitchLevel(Level level)
		{
			this.X = Math.Min(this.X, level.X);
			this.Y = Math.Min(this.Y, level.Y);
			this.Rooms.AddRange(level.Rooms);
			this.Width = this.Rooms.Max((Room r) => r.X + r.Width) - this.X;
			this.Height = this.Rooms.Max((Room r) => r.Y + r.Height) - this.Y;
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x002D9374 File Offset: 0x002D7574
		public static void StitchMap(ConcurrentDictionary<AreaLevel, Level> levels)
		{
			Level.StitchAct(levels, ActLocation.Act1);
			Level.StitchAct(levels, ActLocation.Act2);
			Level.StitchAct(levels, ActLocation.Act3);
			Level.StitchAct(levels, ActLocation.Act4);
			Level.StitchAct(levels, ActLocation.Act5);
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x002D93A0 File Offset: 0x002D75A0
		public static void StitchAct(ConcurrentDictionary<AreaLevel, Level> levels, ActLocation act)
		{
			bool flag = act == ActLocation.Act1;
			if (flag)
			{
				levels[AreaLevel.RogueEncampment].StitchLevel(levels[AreaLevel.BloodMoor]);
				levels[AreaLevel.RogueEncampment].StitchLevel(levels[AreaLevel.ColdPlains]);
				levels[AreaLevel.RogueEncampment].StitchLevel(levels[AreaLevel.StonyField]);
				levels[AreaLevel.RogueEncampment].StitchLevel(levels[AreaLevel.BurialGrounds]);
				levels[AreaLevel.DarkWood].StitchLevel(levels[AreaLevel.BlackMarsh]);
				levels[AreaLevel.DarkWood].StitchLevel(levels[AreaLevel.TamoeHighland]);
				levels[AreaLevel.DarkWood].StitchLevel(levels[AreaLevel.MonasteryGate]);
				levels[AreaLevel.DarkWood].StitchLevel(levels[AreaLevel.OuterCloister]);
				levels[AreaLevel.DarkWood].StitchLevel(levels[AreaLevel.Barracks]);
				levels[AreaLevel.InnerCloister].StitchLevel(levels[AreaLevel.Cathedral]);
			}
			else
			{
				bool flag2 = act == ActLocation.Act2;
				if (flag2)
				{
					levels[AreaLevel.LutGholein].StitchLevel(levels[AreaLevel.RockyWaste]);
					levels[AreaLevel.LutGholein].StitchLevel(levels[AreaLevel.DryHills]);
					levels[AreaLevel.LutGholein].StitchLevel(levels[AreaLevel.FarOasis]);
					levels[AreaLevel.LutGholein].StitchLevel(levels[AreaLevel.LostCity]);
					levels[AreaLevel.LutGholein].StitchLevel(levels[AreaLevel.ValleyOfSnakes]);
				}
				else
				{
					bool flag3 = act == ActLocation.Act3;
					if (flag3)
					{
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.SpiderForest]);
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.GreatMarsh]);
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.FlayerJungle]);
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.LowerKurast]);
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.KurastBazaar]);
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.UpperKurast]);
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.KurastCauseway]);
						levels[AreaLevel.KurastDocks].StitchLevel(levels[AreaLevel.Travincal]);
					}
					else
					{
						bool flag4 = act == ActLocation.Act4;
						if (flag4)
						{
							levels[AreaLevel.ThePandemoniumFortress].StitchLevel(levels[AreaLevel.OuterSteppes]);
							levels[AreaLevel.ThePandemoniumFortress].StitchLevel(levels[AreaLevel.PlainsOfDespair]);
							levels[AreaLevel.ThePandemoniumFortress].StitchLevel(levels[AreaLevel.CityOfTheDamned]);
							levels[AreaLevel.RiverOfFlame].StitchLevel(levels[AreaLevel.ChaosSanctuary]);
						}
						else
						{
							bool flag5 = act == ActLocation.Act5;
							if (flag5)
							{
								levels[AreaLevel.Harrogath].StitchLevel(levels[AreaLevel.BloodyFoothills]);
								levels[AreaLevel.Harrogath].StitchLevel(levels[AreaLevel.FrigidHighlands]);
								levels[AreaLevel.Harrogath].StitchLevel(levels[AreaLevel.ArreatPlateau]);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x002D9680 File Offset: 0x002D7880
		public List<D2Map.Pathfinding.Node> CleanPath(List<D2Map.Pathfinding.Node> path)
		{
			float num = 0.1f;
			List<D2Map.Pathfinding.Node> list = new List<D2Map.Pathfinding.Node>();
			Dictionary<int, float> dictionary = new Dictionary<int, float>();
			List<int> list2 = new List<int>();
			for (int i = 1; i < path.Count; i++)
			{
				bool flag = path[i - 1].Y - path[i].Y == 0;
				if (flag)
				{
					dictionary.Add(i, float.MaxValue);
				}
				else
				{
					dictionary.Add(i, 1f * (float)(path[i - 1].X - path[i].X) / (float)(path[i - 1].Y - path[i].Y));
				}
			}
			list.Add(path[0]);
			for (int j = dictionary.Count - 2; j > 0; j--)
			{
				bool flag2 = Math.Abs(dictionary[j] - dictionary[j + 1]) < num;
				if (flag2)
				{
					list2.Add(j);
				}
			}
			foreach (int num2 in list2)
			{
				dictionary.Remove(num2);
			}
			list.Add(path[path.Count - 1]);
			foreach (KeyValuePair<int, float> keyValuePair in dictionary)
			{
				list.Add(path[keyValuePair.Key]);
			}
			return list;
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600B790 RID: 46992 RVA: 0x002D9854 File Offset: 0x002D7A54
		public bool[,] CollisionMap
		{
			get
			{
				bool flag = this._colMap != null;
				bool[,] array;
				if (flag)
				{
					array = this._colMap;
				}
				else
				{
					this._colMap = new bool[(int)this.Width, (int)this.Height];
					int num = 0;
					while ((long)num < (long)((ulong)this.Width))
					{
						int num2 = 0;
						while ((long)num2 < (long)((ulong)this.Height))
						{
							this._colMap[num, num2] = true;
							num2++;
						}
						num++;
					}
					foreach (Room room in this.Rooms)
					{
						for (uint num3 = 0U; num3 < room.Width; num3 += 1U)
						{
							for (uint num4 = 0U; num4 < room.Height; num4 += 1U)
							{
								bool flag2 = (room.GetCollision(num3, num4) & 1) != 1;
								if (flag2)
								{
									this._colMap[(int)(num3 + room.X - this.X), (int)(num4 + room.Y - this.Y)] = false;
								}
							}
						}
					}
					array = this._colMap;
				}
				return array;
			}
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x002D99A4 File Offset: 0x002D7BA4
		public D2Map.Pathfinding.Node[,] GetNodeGridWalls(List<int> ranges = null)
		{
			bool flag = ranges == null;
			if (flag)
			{
				ranges = new List<int> { 1 };
			}
			D2Map.Pathfinding.Node[,] array = new D2Map.Pathfinding.Node[(int)this.Width, (int)this.Height];
			int num = 0;
			while ((long)num < (long)((ulong)this.Width))
			{
				int num2 = 0;
				while ((long)num2 < (long)((ulong)this.Height))
				{
					array[num, num2] = new D2Map.Pathfinding.Node(num, num2, this.IsWall((uint)(num + (int)this.X), (uint)(num2 + (int)this.Y)), this.IsNeighborWall((uint)(num + (int)this.X), (uint)(num2 + (int)this.Y)), ranges, false);
					num2++;
				}
				num++;
			}
			return array;
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x002D9A54 File Offset: 0x002D7C54
		public D2Map.Pathfinding.Node[,] GetMinorNodeGridWalls(Vector2 start, Vector2 end, List<int> ranges = null)
		{
			bool flag = ranges == null;
			if (flag)
			{
				ranges = new List<int> { 1 };
			}
			int num = (int)Math.Max(this.X, Math.Min(start.X, end.X) - (float)this.SmartBuffer);
			int num2 = (int)Math.Max(this.Y, Math.Min(start.Y, end.Y) - (float)this.SmartBuffer);
			int num3 = (int)Math.Min(this.X + this.Width, Math.Max(start.X, end.X) + (float)this.SmartBuffer);
			int num4 = (int)Math.Min(this.Y + this.Height, Math.Max(start.Y, end.Y) + (float)this.SmartBuffer);
			int num5 = num3 - num + 1;
			int num6 = num4 - num2 + 1;
			D2Map.Pathfinding.Node[,] array = new D2Map.Pathfinding.Node[num5, num6];
			for (int i = 0; i < num5; i++)
			{
				for (int j = 0; j < num6; j++)
				{
					array[i, j] = new D2Map.Pathfinding.Node(i, j, this.IsWall((uint)((long)(num + i) + (long)((ulong)this.X)), (uint)((long)(num2 + j) + (long)((ulong)this.Y))), this.IsNeighborWall((uint)((long)(num + i) + (long)((ulong)this.X)), (uint)((long)(num2 + j) + (long)((ulong)this.Y))), ranges, false);
				}
			}
			return array;
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x002D9BD8 File Offset: 0x002D7DD8
		public bool IsWall2(uint x, uint y)
		{
			bool flag = (long)this.CollisionMap.GetLength(0) <= (long)((ulong)x);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = (long)this.CollisionMap.GetLength(1) <= (long)((ulong)y);
				flag2 = flag3 || this.CollisionMap[(int)x, (int)y];
			}
			return flag2;
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x002D9C30 File Offset: 0x002D7E30
		public bool IsWall(uint x, uint y)
		{
			bool flag = (long)this.CollisionMap.GetLength(0) <= (long)((ulong)(x - this.X));
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = (long)this.CollisionMap.GetLength(1) <= (long)((ulong)(y - this.Y));
				flag2 = flag3 || this.CollisionMap[(int)(x - this.X), (int)(y - this.Y)];
			}
			return flag2;
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x002D9CA4 File Offset: 0x002D7EA4
		public bool IsNeighborWall(uint x, uint y)
		{
			return this.IsWall(x - 1U, y) || this.IsWall(x + 1U, y) || this.IsWall(x, y - 1U) || this.IsWall(x, y + 1U);
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x002D9CE8 File Offset: 0x002D7EE8
		public List<D2Map.Pathfinding.Node> GetPath(Vector2 start, Vector2 end, List<int> ranges = null)
		{
			D2Map.Pathfinding.Node[,] minorNodeGridWalls = this.GetMinorNodeGridWalls(start, end, ranges);
			int num = (int)Math.Max(this.X, Math.Min(start.X, end.X) - (float)this.SmartBuffer);
			int num2 = (int)Math.Max(this.Y, Math.Min(start.Y, end.Y) - (float)this.SmartBuffer);
			Vector2 vector = new Vector2(start.X - (float)num, start.Y - (float)num2);
			Vector2 vector2 = new Vector2(end.X - (float)num, end.Y - (float)num2);
			AStar astar = new AStar(minorNodeGridWalls, vector, vector2);
			List<D2Map.Pathfinding.Node> list = astar.GetPath().ToList<D2Map.Pathfinding.Node>();
			bool flag = (float)list.First<D2Map.Pathfinding.Node>().X != vector.X || (float)list.First<D2Map.Pathfinding.Node>().Y != vector.Y || (float)list.Last<D2Map.Pathfinding.Node>().X != vector2.X || (float)list.Last<D2Map.Pathfinding.Node>().Y != vector2.Y;
			if (flag)
			{
				list = this.GetPathDumb1234(start, end, ranges);
			}
			else
			{
				foreach (D2Map.Pathfinding.Node node in list)
				{
					node.X += num - (int)this.X;
					node.Y += num2 - (int)this.Y;
				}
			}
			bool flag2 = ranges.Count == 1;
			if (flag2)
			{
				List<D2Map.Pathfinding.Node> list2 = this.CleanPath(list);
				foreach (D2Map.Pathfinding.Node node2 in list2)
				{
					list[list.IndexOf(node2)].IsCritical = true;
				}
			}
			return list.ToList<D2Map.Pathfinding.Node>();
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x002D9EF8 File Offset: 0x002D80F8
		public Vector2 GetClosestWalkablePos(ushort x, ushort y)
		{
			int num = 15;
			int num2 = 0;
			bool flag = false;
			int num3 = int.MaxValue;
			Vector2 vector = new Vector2(0f, 0f);
			while (!flag && num2 < num)
			{
				for (int i = -num2; i <= num2; i++)
				{
					for (int j = -num2; j <= num2; j++)
					{
						bool flag2 = !this.IsWall((uint)((ushort)((int)x + i)), (uint)((ushort)((int)y + j)));
						if (flag2)
						{
							flag = true;
							int num4 = Math.Abs(i) + Math.Abs(j);
							bool flag3 = num4 < num3;
							if (flag3)
							{
								num3 = num4;
								vector = new Vector2((float)((int)x + i), (float)((int)y + j));
							}
						}
					}
				}
				num2++;
			}
			return vector;
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x002D9FD4 File Offset: 0x002D81D4
		public List<D2Map.Pathfinding.Node> GetPathDumb1234(Vector2 start, Vector2 end, List<int> ranges)
		{
			D2Map.Pathfinding.Node[,] nodeGridWalls = this.GetNodeGridWalls(ranges);
			Vector2 vector = new Vector2(start.X - (float)this.X, start.Y - (float)this.Y);
			Vector2 vector2 = new Vector2(end.X - (float)this.X, end.Y - (float)this.Y);
			AStar astar = new AStar(nodeGridWalls, vector, vector2);
			List<D2Map.Pathfinding.Node> list = astar.GetPath().ToList<D2Map.Pathfinding.Node>();
			return list.ToList<D2Map.Pathfinding.Node>();
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x002DA054 File Offset: 0x002D8254
		public void ThickenWalls()
		{
			foreach (Room room in this.Rooms)
			{
				ushort[,] array = new ushort[(int)room.Width, (int)room.Height];
				for (uint num = 0U; num < room.Width; num += 1U)
				{
					for (uint num2 = 0U; num2 < room.Height; num2 += 1U)
					{
						array[(int)num, (int)num2] = room.GetCollision(num, num2);
					}
				}
				for (uint num3 = 0U; num3 < room.Width; num3 += 1U)
				{
					for (uint num4 = 0U; num4 < room.Height; num4 += 1U)
					{
						bool flag = (room.GetCollision(num3, num4) & 1) == 1;
						if (flag)
						{
							bool flag2 = num3 < room.Width - 1U;
							if (flag2)
							{
								bool flag3 = num4 > 0U;
								if (flag3)
								{
									array[(int)(num3 + 1U), (int)(num4 - 1U)] = room.GetCollision(num3, num4);
								}
								array[(int)(num3 + 1U), (int)num4] = room.GetCollision(num3, num4);
								bool flag4 = num4 < room.Height - 1U;
								if (flag4)
								{
									array[(int)(num3 + 1U), (int)(num4 + 1U)] = room.GetCollision(num3, num4);
								}
							}
							bool flag5 = num3 > 0U;
							if (flag5)
							{
								bool flag6 = num4 > 0U;
								if (flag6)
								{
									array[(int)(num3 - 1U), (int)(num4 - 1U)] = room.GetCollision(num3, num4);
								}
								array[(int)(num3 - 1U), (int)num4] = room.GetCollision(num3, num4);
								bool flag7 = num4 < room.Height - 1U;
								if (flag7)
								{
									array[(int)(num3 - 1U), (int)(num4 + 1U)] = room.GetCollision(num3, num4);
								}
							}
							bool flag8 = num4 > 0U;
							if (flag8)
							{
								array[(int)num3, (int)(num4 - 1U)] = room.GetCollision(num3, num4);
							}
							bool flag9 = num4 < room.Height - 1U;
							if (flag9)
							{
								array[(int)num3, (int)(num4 + 1U)] = room.GetCollision(num3, num4);
							}
						}
					}
				}
				for (uint num5 = 0U; num5 < room.Width; num5 += 1U)
				{
					for (uint num6 = 0U; num6 < room.Height; num6 += 1U)
					{
						room.SetCollision(num5, num6, array[(int)num5, (int)num6] != 0);
					}
				}
			}
		}

		// Token: 0x0600B79A RID: 47002 RVA: 0x002DA2F0 File Offset: 0x002D84F0
		public void CleanMap()
		{
			using (List<Room>.Enumerator enumerator = this.Rooms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Room room = enumerator.Current;
					ushort[,] array = new ushort[(int)room.Width, (int)room.Height];
					for (uint num = 0U; num < room.Width; num += 1U)
					{
						for (uint num2 = 0U; num2 < room.Height; num2 += 1U)
						{
							array[(int)num, (int)num2] = room.GetCollision(num, num2);
						}
					}
					Room room5 = this.Rooms.FirstOrDefault((Room r) => r.Y + r.Height == room.Y && r.X == room.X);
					Room room2 = this.Rooms.FirstOrDefault((Room r) => r.Y - room.Height == room.Y && r.X == room.X);
					Room room3 = this.Rooms.FirstOrDefault((Room r) => r.Y == room.Y && r.X + r.Width == room.X);
					Room room4 = this.Rooms.FirstOrDefault((Room r) => r.Y == room.Y && r.X - room.Width == room.X);
					bool flag = room5 == null;
					if (flag)
					{
						for (uint num3 = 0U; num3 < room.Width - 1U; num3 += 1U)
						{
							room.SetCollision(num3, 0U, true);
						}
					}
					bool flag2 = room2 == null;
					if (flag2)
					{
						for (uint num4 = 0U; num4 < room.Width - 1U; num4 += 1U)
						{
							room.SetCollision(num4, room.Height - 1U, true);
						}
					}
					bool flag3 = room3 == null;
					if (flag3)
					{
						for (uint num5 = 0U; num5 < room.Height - 1U; num5 += 1U)
						{
							room.SetCollision(0U, num5, true);
						}
					}
					bool flag4 = room4 == null;
					if (flag4)
					{
						for (uint num6 = 0U; num6 < room.Height - 1U; num6 += 1U)
						{
							room.SetCollision(room.Width - 1U, num6, true);
						}
					}
					for (uint num7 = 1U; num7 < room.Width - 1U; num7 += 1U)
					{
						bool flag5 = (room.GetCollision(num7, 0U) & 1) == 1;
						if (flag5)
						{
							bool flag6 = (room.GetCollision(num7 - 1U, 0U) & 1) == 1 && (room.GetCollision(num7 - 1U, 1U) & 1) == 1 && (room.GetCollision(num7 + 1U, 1U) & 1) == 1 && (room.GetCollision(num7 + 1U, 0U) & 1) == 1 && (room.GetCollision(num7, 1U) & 1) == 1;
							if (flag6)
							{
								array[(int)num7, 0] = (ushort)(array[(int)num7, 0] & 65534);
							}
						}
						bool flag7 = (room.GetCollision(num7, room.Height - 1U) & 1) == 1;
						if (flag7)
						{
							bool flag8 = (room.GetCollision(num7 - 1U, room.Height - 1U) & 1) == 1 && (room.GetCollision(num7 - 1U, room.Height - 2U) & 1) == 1 && (room.GetCollision(num7 + 1U, room.Height - 1U) & 1) == 1 && (room.GetCollision(num7 + 1U, room.Height - 2U) & 1) == 1 && (room.GetCollision(num7, room.Height - 2U) & 1) == 1;
							if (flag8)
							{
								array[(int)num7, (int)(room.Height - 1U)] = (ushort)(array[(int)num7, (int)(room.Height - 1U)] & 65534);
							}
						}
						for (uint num8 = 1U; num8 < room.Height - 1U; num8 += 1U)
						{
							bool flag9 = (room.GetCollision(num7, num8) & 1) == 1;
							if (flag9)
							{
								bool flag10 = (room.GetCollision(num7 - 1U, num8) & 1) == 1 && (room.GetCollision(num7 - 1U, num8 - 1U) & 1) == 1 && (room.GetCollision(num7 - 1U, num8 + 1U) & 1) == 1 && (room.GetCollision(num7 + 1U, num8 + 1U) & 1) == 1 && (room.GetCollision(num7 + 1U, num8) & 1) == 1 && (room.GetCollision(num7 + 1U, num8 - 1U) & 1) == 1 && (room.GetCollision(num7, num8 - 1U) & 1) == 1 && (room.GetCollision(num7, num8 + 1U) & 1) == 1;
								if (flag10)
								{
									array[(int)num7, (int)num8] = (ushort)(array[(int)num7, (int)num8] & 65534);
								}
							}
						}
					}
					for (uint num9 = 1U; num9 < room.Height - 1U; num9 += 1U)
					{
						bool flag11 = (room.GetCollision(0U, num9) & 1) == 1;
						if (flag11)
						{
							bool flag12 = (room.GetCollision(0U, num9 - 1U) & 1) == 1 && (room.GetCollision(0U, num9 + 1U) & 1) == 1 && (room.GetCollision(1U, num9 - 1U) & 1) == 1 && (room.GetCollision(1U, num9) & 1) == 1 && (room.GetCollision(1U, num9 + 1U) & 1) == 1;
							if (flag12)
							{
								array[0, (int)num9] = (ushort)(array[0, (int)num9] & 65534);
							}
						}
						bool flag13 = (room.GetCollision(room.Width - 1U, num9) & 1) == 1;
						if (flag13)
						{
							bool flag14 = (room.GetCollision(room.Width - 1U, num9 - 1U) & 1) == 1 && (room.GetCollision(room.Width - 1U, num9 + 1U) & 1) == 1 && (room.GetCollision(room.Width - 2U, num9 - 1U) & 1) == 1 && (room.GetCollision(room.Width - 2U, num9) & 1) == 1 && (room.GetCollision(room.Width - 2U, num9 + 1U) & 1) == 1;
							if (flag14)
							{
								array[(int)(room.Width - 1U), (int)num9] = (ushort)(array[0, (int)num9] & 65534);
							}
						}
					}
					bool flag15 = (room.GetCollision(0U, 0U) & 1) == 1;
					if (flag15)
					{
						bool flag16 = (room.GetCollision(1U, 1U) & 1) == 1 && (room.GetCollision(1U, 0U) & 1) == 1 && (room.GetCollision(0U, 1U) & 1) == 1;
						if (flag16)
						{
							array[0, 0] = (ushort)(array[0, 0] & 65534);
						}
					}
					bool flag17 = (room.GetCollision(0U, room.Height - 1U) & 1) == 1;
					if (flag17)
					{
						bool flag18 = (room.GetCollision(1U, room.Height - 1U) & 1) == 1 && (room.GetCollision(1U, room.Height - 2U) & 1) == 1 && (room.GetCollision(0U, room.Height - 2U) & 1) == 1;
						if (flag18)
						{
							array[0, (int)(room.Height - 1U)] = (ushort)(array[0, (int)(room.Height - 1U)] & 65534);
						}
					}
					bool flag19 = (room.GetCollision(room.Width - 1U, 0U) & 1) == 1;
					if (flag19)
					{
						bool flag20 = (room.GetCollision(room.Width - 1U, 1U) & 1) == 1 && (room.GetCollision(room.Width - 2U, 0U) & 1) == 1 && (room.GetCollision(room.Width - 2U, 1U) & 1) == 1;
						if (flag20)
						{
							array[(int)(room.Width - 1U), 0] = (ushort)(array[(int)(room.Width - 1U), 0] & 65534);
						}
					}
					bool flag21 = (room.GetCollision(room.Width - 1U, room.Height - 1U) & 1) == 1;
					if (flag21)
					{
						bool flag22 = (room.GetCollision(room.Width - 2U, room.Height - 2U) & 1) == 1 && (room.GetCollision(room.Width - 1U, room.Height - 2U) & 1) == 1 && (room.GetCollision(room.Width - 2U, room.Height - 1U) & 1) == 1;
						if (flag22)
						{
							array[(int)(room.Width - 1U), (int)(room.Height - 1U)] = (ushort)(array[(int)(room.Width - 1U), (int)(room.Height - 1U)] & 65534);
						}
					}
					for (uint num10 = 0U; num10 < room.Width; num10 += 1U)
					{
						for (uint num11 = 0U; num11 < room.Height; num11 += 1U)
						{
							room.SetCollision(num10, num11, array[(int)num10, (int)num11] != 0);
						}
					}
				}
			}
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x002DAD60 File Offset: 0x002D8F60
		public void DrawLevel(Vector2 start, Vector2 end)
		{
			List<D2Map.Pathfinding.Node> path = this.GetPath(start, end, new List<int> { 1 });
			List<D2Map.Pathfinding.Node> path2 = this.GetPath(start, end, new List<int> { 1, 4, 10, 16 });
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x002DADB4 File Offset: 0x002D8FB4
		public float GetVelocityToPoint(uint i, uint j, uint columns, uint rows)
		{
			bool flag = i < 0U || j < 0U || i >= columns || j >= rows;
			float num;
			if (flag)
			{
				num = 5f;
			}
			else
			{
				bool flag2 = (j == 0U || !this.IsWall(i, j - 1U)) && (j + 1U >= rows || !this.IsWall(i, j + 1U)) && (i == 0U || !this.IsWall(i - 1U, j)) && (i + 1U >= columns || !this.IsWall(i + 1U, j));
				if (flag2)
				{
					num = 5f;
				}
				else
				{
					num = 0f;
				}
			}
			return num;
		}

		// Token: 0x0600B79D RID: 47005 RVA: 0x002DAE44 File Offset: 0x002D9044
		public float GetVelocityWithAdjacency(uint i, uint j, uint columns, uint rows)
		{
			float velocityToPoint = this.GetVelocityToPoint(i, j, columns, rows);
			float num = this.GetVelocityToPoint(i - 3U, j - 3U, columns, rows);
			num = Math.Min(num, this.GetVelocityToPoint(i - 3U, j + 3U, columns, rows));
			num = Math.Min(num, this.GetVelocityToPoint(i + 3U, j - 3U, columns, rows));
			num = Math.Min(num, this.GetVelocityToPoint(i + 3U, j + 3U, columns, rows));
			return (float)((double)velocityToPoint * 0.3 + (double)num * 0.7);
		}

		// Token: 0x0600B79E RID: 47006 RVA: 0x002DAED0 File Offset: 0x002D90D0
		public List<D2Map.Pathfinding.Node> GetPathRoy(Vector2 start, Vector2 end)
		{
			Grid grid = this.cachedGrid;
			lock (grid)
			{
				bool flag2 = this.cachedGrid.Rows == 1;
				if (flag2)
				{
					uint height = this.Height;
					uint width = this.Width;
					Roy_T.AStar.Graphs.Node[,] array = new Roy_T.AStar.Graphs.Node[(int)width, (int)height];
					int num = 0;
					while ((long)num < (long)((ulong)width))
					{
						int num2 = 0;
						while ((long)num2 < (long)((ulong)height))
						{
							array[num, num2] = new Roy_T.AStar.Graphs.Node(new Position((float)num, (float)num2));
							num2++;
						}
						num++;
					}
					for (uint num3 = 0U; num3 < width; num3 += 1U)
					{
						for (uint num4 = 0U; num4 < height; num4 += 1U)
						{
							bool flag3 = this.IsWall(this.X + num4, this.Y + num3);
							if (!flag3)
							{
								Roy_T.AStar.Graphs.Node node = array[(int)num3, (int)num4];
								int num5 = 1;
								bool flag4 = num3 + 1U < width && !this.IsWall(this.X + num4, this.Y + num3 + 1U);
								if (flag4)
								{
									Roy_T.AStar.Graphs.Node node2 = array[(int)(num3 + 1U), (int)num4];
									Velocity velocity = Velocity.FromMetersPerSecond((float)num5);
									node.Connect(node2, velocity);
									node2.Connect(node, velocity);
								}
								bool flag5 = num4 + 1U < height && !this.IsWall(this.X + num4 + 1U, this.Y + num3);
								if (flag5)
								{
									Roy_T.AStar.Graphs.Node node3 = array[(int)num3, (int)(num4 + 1U)];
									Velocity velocity2 = Velocity.FromMetersPerSecond((float)num5);
									node.Connect(node3, velocity2);
									node3.Connect(node, velocity2);
								}
							}
						}
					}
					this.cachedGrid = Grid.CreateGridFrom2DArrayOfNodes(array);
				}
			}
			PathFinder pathFinder = new PathFinder();
			GridPosition gridPosition = new GridPosition((int)(start.X - this.X), (int)(start.Y - this.Y));
			GridPosition gridPosition2 = new GridPosition((int)(end.X - this.X), (int)(end.Y - this.Y));
			Roy_T.AStar.Paths.Path path = pathFinder.FindPath(gridPosition, gridPosition2, this.cachedGrid);
			return path.Edges.Select((IEdge e) => new D2Map.Pathfinding.Node((int)e.End.Position.X / 5, (int)e.End.Position.Y / 5, false, false, null, false)).ToList<D2Map.Pathfinding.Node>();
		}

		// Token: 0x040069E7 RID: 27111
		public bool[,] _colMap;

		// Token: 0x040069E8 RID: 27112
		private int SmartBuffer = 25;

		// Token: 0x040069E9 RID: 27113
		private Grid cachedGrid = Grid.CreateGridFrom2DArrayOfNodes(new Roy_T.AStar.Graphs.Node[1, 1]);
	}
}
