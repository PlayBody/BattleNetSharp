using System;
using System.Runtime.InteropServices;

namespace D2Map
{
	// Token: 0x020008F7 RID: 2295
	public class UnmanagedStructs
	{
		// Token: 0x020012FE RID: 4862
		[StructLayout(LayoutKind.Explicit)]
		public struct Act
		{
			// Token: 0x04009CE4 RID: 40164
			[FieldOffset(12)]
			public uint MapSeed;

			// Token: 0x04009CE5 RID: 40165
			[FieldOffset(20)]
			public uint ActId;

			// Token: 0x04009CE6 RID: 40166
			[FieldOffset(72)]
			public unsafe UnmanagedStructs.ActMisc* pActMisc;
		}

		// Token: 0x020012FF RID: 4863
		[StructLayout(LayoutKind.Explicit)]
		public struct Level
		{
			// Token: 0x04009CE7 RID: 40167
			[FieldOffset(16)]
			public unsafe UnmanagedStructs.RoomEx* pRoomExFirst;

			// Token: 0x04009CE8 RID: 40168
			[FieldOffset(28)]
			public uint dwPosX;

			// Token: 0x04009CE9 RID: 40169
			[FieldOffset(32)]
			public uint dwPosY;

			// Token: 0x04009CEA RID: 40170
			[FieldOffset(36)]
			public uint dwSizeX;

			// Token: 0x04009CEB RID: 40171
			[FieldOffset(40)]
			public uint dwSizeY;

			// Token: 0x04009CEC RID: 40172
			[FieldOffset(428)]
			public unsafe UnmanagedStructs.Level* pNextLevel;

			// Token: 0x04009CED RID: 40173
			[FieldOffset(436)]
			public unsafe UnmanagedStructs.ActMisc* pMisc;

			// Token: 0x04009CEE RID: 40174
			[FieldOffset(464)]
			public uint dwLevelNo;
		}

		// Token: 0x02001300 RID: 4864
		[StructLayout(LayoutKind.Explicit)]
		public struct ActMisc
		{
			// Token: 0x04009CEF RID: 40175
			[FieldOffset(148)]
			public uint RealTombArea;

			// Token: 0x04009CF0 RID: 40176
			[FieldOffset(1132)]
			public unsafe UnmanagedStructs.Act* pAct;

			// Token: 0x04009CF1 RID: 40177
			[FieldOffset(1148)]
			public unsafe UnmanagedStructs.Level* pLevelFirst;
		}

		// Token: 0x02001301 RID: 4865
		[StructLayout(LayoutKind.Explicit)]
		public struct CollMap
		{
			// Token: 0x04009CF2 RID: 40178
			[FieldOffset(0)]
			public uint dwPosGameX;

			// Token: 0x04009CF3 RID: 40179
			[FieldOffset(4)]
			public uint dwPosGameY;

			// Token: 0x04009CF4 RID: 40180
			[FieldOffset(8)]
			public uint dwSizeGameX;

			// Token: 0x04009CF5 RID: 40181
			[FieldOffset(12)]
			public uint dwSizeGameY;

			// Token: 0x04009CF6 RID: 40182
			[FieldOffset(16)]
			public uint dwPosRoomX;

			// Token: 0x04009CF7 RID: 40183
			[FieldOffset(20)]
			public uint dwPosRoomY;

			// Token: 0x04009CF8 RID: 40184
			[FieldOffset(24)]
			public uint dwSizeRoomX;

			// Token: 0x04009CF9 RID: 40185
			[FieldOffset(28)]
			public uint dwSizeRoomY;

			// Token: 0x04009CFA RID: 40186
			[FieldOffset(32)]
			public unsafe ushort* pMapStart;

			// Token: 0x04009CFB RID: 40187
			[FieldOffset(34)]
			public unsafe ushort* pMapEnd;
		}

		// Token: 0x02001302 RID: 4866
		[StructLayout(LayoutKind.Explicit)]
		public struct Room
		{
			// Token: 0x04009CFC RID: 40188
			[FieldOffset(0)]
			public unsafe UnmanagedStructs.Room** pRoomsNear;

			// Token: 0x04009CFD RID: 40189
			[FieldOffset(16)]
			public unsafe UnmanagedStructs.RoomEx* pRoom2;

			// Token: 0x04009CFE RID: 40190
			[FieldOffset(32)]
			public unsafe UnmanagedStructs.CollMap* pCollisionMap;

			// Token: 0x04009CFF RID: 40191
			[FieldOffset(36)]
			public uint numRoomsNear;

			// Token: 0x04009D00 RID: 40192
			[FieldOffset(76)]
			public uint dwPosX;

			// Token: 0x04009D01 RID: 40193
			[FieldOffset(80)]
			public uint dwPosY;

			// Token: 0x04009D02 RID: 40194
			[FieldOffset(84)]
			public uint dwSizeX;

			// Token: 0x04009D03 RID: 40195
			[FieldOffset(88)]
			public uint dwSizeY;

			// Token: 0x04009D04 RID: 40196
			[FieldOffset(116)]
			public IntPtr pUnitFirst;

			// Token: 0x04009D05 RID: 40197
			[FieldOffset(124)]
			public unsafe UnmanagedStructs.Room* pRoomNext;
		}

		// Token: 0x02001303 RID: 4867
		[StructLayout(LayoutKind.Explicit)]
		public struct PresetUnit
		{
			// Token: 0x04009D06 RID: 40198
			[FieldOffset(4)]
			public uint dwTxtFileNo;

			// Token: 0x04009D07 RID: 40199
			[FieldOffset(8)]
			public uint dwPosX;

			// Token: 0x04009D08 RID: 40200
			[FieldOffset(12)]
			public unsafe UnmanagedStructs.PresetUnit* pPresetNext;

			// Token: 0x04009D09 RID: 40201
			[FieldOffset(20)]
			public uint dwType;

			// Token: 0x04009D0A RID: 40202
			[FieldOffset(24)]
			public uint dwPosY;
		}

		// Token: 0x02001304 RID: 4868
		[StructLayout(LayoutKind.Explicit)]
		public struct RoomTile
		{
			// Token: 0x04009D0B RID: 40203
			[FieldOffset(0)]
			public unsafe UnmanagedStructs.RoomEx* pRoom2;

			// Token: 0x04009D0C RID: 40204
			[FieldOffset(4)]
			public unsafe UnmanagedStructs.RoomTile* pNext;

			// Token: 0x04009D0D RID: 40205
			[FieldOffset(16)]
			public unsafe uint* nNum;
		}

		// Token: 0x02001305 RID: 4869
		[StructLayout(LayoutKind.Explicit)]
		public struct RoomEx
		{
			// Token: 0x04009D0E RID: 40206
			[FieldOffset(8)]
			public unsafe UnmanagedStructs.RoomEx** pRoom2Near;

			// Token: 0x04009D0F RID: 40207
			[FieldOffset(36)]
			public unsafe UnmanagedStructs.RoomEx* pRoomExNext;

			// Token: 0x04009D10 RID: 40208
			[FieldOffset(48)]
			public unsafe UnmanagedStructs.Room* pRoom;

			// Token: 0x04009D11 RID: 40209
			[FieldOffset(44)]
			public uint dwRoomsNear;

			// Token: 0x04009D12 RID: 40210
			[FieldOffset(52)]
			public uint dwPosX;

			// Token: 0x04009D13 RID: 40211
			[FieldOffset(56)]
			public uint dwPosY;

			// Token: 0x04009D14 RID: 40212
			[FieldOffset(60)]
			public uint dwSizeX;

			// Token: 0x04009D15 RID: 40213
			[FieldOffset(64)]
			public uint dwSizeY;

			// Token: 0x04009D16 RID: 40214
			[FieldOffset(76)]
			public unsafe UnmanagedStructs.RoomTile* pRoomTiles;

			// Token: 0x04009D17 RID: 40215
			[FieldOffset(88)]
			public unsafe UnmanagedStructs.Level* pLevel;

			// Token: 0x04009D18 RID: 40216
			[FieldOffset(92)]
			public unsafe UnmanagedStructs.PresetUnit* pPreset;
		}
	}
}
