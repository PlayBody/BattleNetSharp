using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace D2Map
{
	// Token: 0x020008F5 RID: 2293
	public class Room
	{
		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600B7B1 RID: 47025 RVA: 0x002DB504 File Offset: 0x002D9704
		// (set) Token: 0x0600B7B2 RID: 47026 RVA: 0x002DB50C File Offset: 0x002D970C
		public uint X { get; set; }

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600B7B3 RID: 47027 RVA: 0x002DB515 File Offset: 0x002D9715
		// (set) Token: 0x0600B7B4 RID: 47028 RVA: 0x002DB51D File Offset: 0x002D971D
		public uint Y { get; set; }

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600B7B5 RID: 47029 RVA: 0x002DB526 File Offset: 0x002D9726
		// (set) Token: 0x0600B7B6 RID: 47030 RVA: 0x002DB52E File Offset: 0x002D972E
		public uint Width { get; set; }

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600B7B7 RID: 47031 RVA: 0x002DB537 File Offset: 0x002D9737
		// (set) Token: 0x0600B7B8 RID: 47032 RVA: 0x002DB53F File Offset: 0x002D973F
		public uint Height { get; set; }

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600B7B9 RID: 47033 RVA: 0x002DB548 File Offset: 0x002D9748
		// (set) Token: 0x0600B7BA RID: 47034 RVA: 0x002DB550 File Offset: 0x002D9750
		public BitArray CollisionMapBits { get; set; }

		// Token: 0x0600B7BB RID: 47035 RVA: 0x002DB55C File Offset: 0x002D975C
		public ushort GetCollision(uint x, uint y)
		{
<<<<<<< HEAD
			return (ushort) (this.CollisionMapBits.Get((int)(y * this.CollisionWidth + x)) ? 1 : 0);
=======
			return (ushort)(this.CollisionMapBits.Get((int)(y * this.CollisionWidth + x)) ? 1 : 0;
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x002DB589 File Offset: 0x002D9789
		public void SetCollision(uint x, uint y, bool value)
		{
			this.CollisionMapBits.Set((int)(y * this.CollisionWidth + x), value);
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600B7BD RID: 47037 RVA: 0x002DB5A3 File Offset: 0x002D97A3
		// (set) Token: 0x0600B7BE RID: 47038 RVA: 0x002DB5AB File Offset: 0x002D97AB
		public List<PresetUnit> PresetUnits { get; set; }

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600B7BF RID: 47039 RVA: 0x002DB5B4 File Offset: 0x002D97B4
		// (set) Token: 0x0600B7C0 RID: 47040 RVA: 0x002DB5BC File Offset: 0x002D97BC
		public int[,] Floors { get; set; }

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600B7C1 RID: 47041 RVA: 0x002DB5C5 File Offset: 0x002D97C5
		// (set) Token: 0x0600B7C2 RID: 47042 RVA: 0x002DB5CD File Offset: 0x002D97CD
		public int FloorCnt { get; set; } = 0;

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600B7C3 RID: 47043 RVA: 0x002DB5D6 File Offset: 0x002D97D6
		// (set) Token: 0x0600B7C4 RID: 47044 RVA: 0x002DB5DE File Offset: 0x002D97DE
		public int[,] Walls { get; set; }

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600B7C5 RID: 47045 RVA: 0x002DB5E7 File Offset: 0x002D97E7
		// (set) Token: 0x0600B7C6 RID: 47046 RVA: 0x002DB5EF File Offset: 0x002D97EF
		public int WallCnt { get; set; } = 0;

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600B7C7 RID: 47047 RVA: 0x002DB5F8 File Offset: 0x002D97F8
		// (set) Token: 0x0600B7C8 RID: 47048 RVA: 0x002DB600 File Offset: 0x002D9800
		public List<string> UsedLibs { get; set; }

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600B7C9 RID: 47049 RVA: 0x002DB609 File Offset: 0x002D9809
		// (set) Token: 0x0600B7CA RID: 47050 RVA: 0x002DB611 File Offset: 0x002D9811
		public uint CollisionWidth { get; set; }

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600B7CB RID: 47051 RVA: 0x002DB61A File Offset: 0x002D981A
		// (set) Token: 0x0600B7CC RID: 47052 RVA: 0x002DB622 File Offset: 0x002D9822
		public uint CollisionHeight { get; set; }

		// Token: 0x0600B7CD RID: 47053 RVA: 0x002DB62C File Offset: 0x002D982C
		public List<byte> GetBytes()
		{
			List<byte> list = new List<byte>();
			list.AddRange(BitConverter.GetBytes(this.X));
			list.AddRange(BitConverter.GetBytes(this.Y));
			list.AddRange(BitConverter.GetBytes(this.Width));
			list.AddRange(BitConverter.GetBytes(this.Height));
			list.AddRange(BitConverter.GetBytes(this.CollisionWidth));
			list.AddRange(BitConverter.GetBytes(this.CollisionHeight));
			byte[] array = new byte[(this.CollisionMapBits.Length - 1) / 8 + 1];
			list.AddRange(BitConverter.GetBytes(array.Length));
			this.CollisionMapBits.CopyTo(array, 0);
			list.AddRange(array);
			list.AddRange(BitConverter.GetBytes(this.PresetUnits.Count<PresetUnit>()));
			foreach (PresetUnit presetUnit in this.PresetUnits)
			{
				list.AddRange(presetUnit.GetBytes());
			}
			return list;
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x002DB754 File Offset: 0x002D9954
		public Room(List<byte> b)
		{
			byte[] array = b.ToArray();
			this.X = BitConverter.ToUInt32(array, 0);
			this.Y = BitConverter.ToUInt32(array, 4);
			this.Width = BitConverter.ToUInt32(array, 8);
			this.Height = BitConverter.ToUInt32(array, 12);
			this.CollisionWidth = BitConverter.ToUInt32(array, 16);
			this.CollisionHeight = BitConverter.ToUInt32(array, 20);
			int num = BitConverter.ToInt32(array, 24);
			this.CollisionMapBits = new BitArray(array.Skip(28).Take(num).ToArray<byte>());
			int num2 = 4 + num;
			int num3 = BitConverter.ToInt32(array, 24 + num2);
			this.PresetUnits = new List<PresetUnit>();
			for (int i = 0; i < num3; i++)
			{
				this.PresetUnits.Add(new PresetUnit(b.Skip(24 + num2 + 4 + 16 * i).Take(16).ToList<byte>()));
			}
		}

<<<<<<< HEAD
        // Token: 0x0600B7CF RID: 47055 RVA: 0x002DB86C File Offset: 0x002D9A6C
        private unsafe string DumpString(IntPtr addr)
        {
            const int chunkSize = 8; // Size of ulong in bytes
            const int maxIterations = 16;
            List<byte> byteList = new List<byte>();
=======
		// Token: 0x0600B7CF RID: 47055 RVA: 0x002DB86C File Offset: 0x002D9A6C
		private unsafe string dumpString(IntPtr addr)
		{
			List<byte> list = new List<byte>();
			for (uint num = 0U; num < 16U; num += 1U)
			{
				long num2 = (long)(int)addr + (long)((ulong)(num * 8U));
				ulong num3 = (ulong)(*(UIntPtr)(num2)));
				byte[] bytes = BitConverter.GetBytes(num3);
				for (int i = 0; i < 8; i++)
				{
					bool flag = bytes[i] == 0;
					if (flag)
					{
						return Encoding.UTF8.GetString(list.ToArray());
					}
					list.Add(bytes[i]);
				}
			}
			return Encoding.UTF8.GetString(list.ToArray());
		}
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a

            for (uint offset = 0; offset < maxIterations; offset++)
            {
                // Calculate the current memory address to read from
                ulong* currentAddress = (ulong*)((byte*)addr + (offset * chunkSize));
                ulong data = *currentAddress;

                // Convert the data to bytes
                byte[] bytes = BitConverter.GetBytes(data);

                // Process each byte in the current chunk
                foreach (byte b in bytes)
                {
                    if (b == 0) // Null-terminator found
                        return Encoding.UTF8.GetString(byteList.ToArray());

                    byteList.Add(b);
                }
            }

            // Return the string constructed from the collected bytes
            return Encoding.UTF8.GetString(byteList.ToArray());
        }

        // Token: 0x0600B7D0 RID: 47056 RVA: 0x002DB90C File Offset: 0x002D9B0C
        public unsafe Room(UnmanagedStructs.RoomEx* pRoomEx, bool excludeCollisionMask, bool excludeTileData)
		{
			this.HasCollisionMask = !excludeCollisionMask;
			this.HasTileData = !excludeTileData;
			this.X = pRoomEx->dwPosX * 5U;
			this.Y = pRoomEx->dwPosY * 5U;
			this.Width = pRoomEx->dwSizeX * 5U;
			this.Height = pRoomEx->dwSizeY * 5U;
			this.CollisionWidth = pRoomEx->pRoom->pCollisionMap->dwSizeGameX;
			this.CollisionHeight = pRoomEx->pRoom->pCollisionMap->dwSizeGameY;
			this.CollisionMapBits = new BitArray((int)(this.CollisionWidth * this.CollisionHeight), false);
			for (uint num = 0U; num < this.CollisionHeight; num += 1U)
			{
				for (uint num2 = 0U; num2 < this.CollisionWidth; num2 += 1U)
				{
					bool flag = (pRoomEx->pRoom->pCollisionMap->pMapStart[(ulong)(num * this.CollisionWidth + num2) * 2UL / 2UL] & 1) == 1;
					if (flag)
					{
						this.CollisionMapBits[(int)(num * this.CollisionWidth + num2)] = true;
					}
				}
			}
			this.PresetUnits = new List<PresetUnit>();
			for (UnmanagedStructs.PresetUnit* ptr = pRoomEx->pPreset; ptr != null; ptr = ptr->pPresetNext)
			{
				uint num3 = ptr->dwPosX + pRoomEx->dwPosX * 5U;
				uint num4 = ptr->dwPosY + pRoomEx->dwPosY * 5U;
				uint[] array = new uint[]
				{
					ptr->dwType,
					ptr->dwTxtFileNo,
					num3,
					num4
				};
				PresetUnit presetUnit = new PresetUnit(ptr, this);
				this.PresetUnits.Add(presetUnit);
			}
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x002DBADC File Offset: 0x002D9CDC
		public Vector2 GetMiddleOfRoomWalkable()
		{
			int num = 0;
			while ((long)num < (long)((ulong)(this.Width / 2U)))
			{
				int num2 = 0;
				while ((long)num2 < (long)((ulong)(this.Height / 2U)))
				{
					bool flag = (this.GetCollision((uint)((ulong)(this.Width / 2U) + (ulong)((long)num)), (uint)((ulong)(this.Height / 2U) + (ulong)((long)num2))) & 1) != 1;
					if (flag)
					{
						return new Vector2((float)((ulong)(this.X + this.Width / 2U) + (ulong)((long)num)), (float)((ulong)(this.Y + this.Height / 2U) + (ulong)((long)num2)));
					}
					bool flag2 = (this.GetCollision((uint)((ulong)(this.Width / 2U) + (ulong)((long)num)), (uint)((ulong)(this.Height / 2U) - (ulong)((long)num2))) & 1) != 1;
					if (flag2)
					{
						return new Vector2((float)((ulong)(this.X + this.Width / 2U) + (ulong)((long)num)), (float)((ulong)(this.Y + this.Height / 2U) - (ulong)((long)num2)));
					}
					bool flag3 = (this.GetCollision((uint)((ulong)(this.Width / 2U) - (ulong)((long)num)), (uint)((ulong)(this.Height / 2U) + (ulong)((long)num2))) & 1) != 1;
					if (flag3)
					{
						return new Vector2((float)((ulong)(this.X + this.Width / 2U) - (ulong)((long)num)), (float)((ulong)(this.Y + this.Height / 2U) + (ulong)((long)num2)));
					}
					bool flag4 = (this.GetCollision((uint)((ulong)(this.Width / 2U) - (ulong)((long)num)), (uint)((ulong)(this.Height / 2U) - (ulong)((long)num2))) & 1) != 1;
					if (flag4)
					{
						return new Vector2((float)((ulong)(this.X + this.Width / 2U) - (ulong)((long)num)), (float)((ulong)(this.Y + this.Height / 2U) - (ulong)((long)num2)));
					}
					num2++;
				}
				num++;
			}
			return Vector2.Zero;
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x002DBCB8 File Offset: 0x002D9EB8
		public Room()
		{
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x002DBCE0 File Offset: 0x002D9EE0
		public bool IsAdjacent(Room room)
		{
			bool flag = room.X == this.X && (room.Y == this.Y + this.Height || room.Y == this.Y - room.Height);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = room.Y == this.Y && (room.X == this.X + this.Width || room.X == this.X - room.Width);
				flag2 = flag3;
			}
			return flag2;
		}

		// Token: 0x040069F9 RID: 27129
		public bool HasCollisionMask = false;

		// Token: 0x040069FA RID: 27130
		public bool HasTileData = false;

		// Token: 0x040069FD RID: 27133
		public static List<int> TilesUsed = new List<int> { 0 };

		// Token: 0x040069FE RID: 27134
		public static Dictionary<short, Tile> TileLib = new Dictionary<short, Tile>();
	}
}
