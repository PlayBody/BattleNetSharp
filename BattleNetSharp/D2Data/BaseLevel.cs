﻿using System;

namespace D2Data
{
	// Token: 0x02000918 RID: 2328
	public class BaseLevel
	{
		// Token: 0x0600B924 RID: 47396 RVA: 0x0031B768 File Offset: 0x00319968
		public BaseLevel(string Name, int Id, int Pal, int Act, int QuestFlag, int QuestFlagEx, int Layer, int SizeX, int SizeY, int SizeXNM, int SizeYNM, int SizeXHell, int SizeYHell, int OffsetX, int OffsetY, int Depend, int Teleport, int Rain, int Mud, int NoPer, int LOSDraw, int FloorFilter, int BlankScreen, int DrawEdges, int IsInside, int DrlgType, int LevelType, int SubType, int SubTheme, int SubWaypoint, int SubShrine, int Vis0, int Vis1, int Vis2, int Vis3, int Vis4, int Vis5, int Vis6, int Vis7, int Warp0, int Warp1, int Warp2, int Warp3, int Warp4, int Warp5, int Warp6, int Warp7, int Intensity, int Red, int Green, int Blue, int Portal, int Position, int SaveMonsters, int Quest, int WarpDist, int MonLvl1, int MonLvl2, int MonLvl3, int MonLvl1Ex, int MonLvl2Ex, int MonLvl3Ex, int MonDen, int MonDenNM, int MonDenHell, int MonUMin, int MonUMax, int MonUMinNM, int MonUMaxNM, int MonUMinHell, int MonUMaxHell, int MonWndr, int MonSpcWalk, int NumMon, string mon1, string mon2, string mon3, string mon4, string mon5, string mon6, string mon7, string mon8, string mon9, string mon10, int rangedspawn, string nmon1, string nmon2, string nmon3, string nmon4, string nmon5, string nmon6, string nmon7, string nmon8, string nmon9, string nmon10, string umon1, string umon2, string umon3, string umon4, string umon5, string umon6, string umon7, string umon8, string umon9, string umon10, string cmon1, string cmon2, string cmon3, string cmon4, int cpct1, int cpct2, int cpct3, int cpct4, int camt1, int camt2, int camt3, int camt4, int Themes, int SoundEnv, int Waypoint, string LevelName, string LevelWarp, string EntryFile, int ObjGrp0, int ObjGrp1, int ObjGrp2, int ObjGrp3, int ObjGrp4, int ObjGrp5, int ObjGrp6, int ObjGrp7, int ObjPrb0, int ObjPrb1, int ObjPrb2, int ObjPrb3, int ObjPrb4, int ObjPrb5, int ObjPrb6, int ObjPrb7)
		{
			this.Name = Name;
			this.Id = Id;
			this.Pal = Pal;
			this.Act = Act;
			this.QuestFlag = QuestFlag;
			this.QuestFlagEx = QuestFlagEx;
			this.Layer = Layer;
			this.SizeX = SizeX;
			this.SizeY = SizeY;
			this.SizeXNM = SizeXNM;
			this.SizeYNM = SizeYNM;
			this.SizeXHell = SizeXHell;
			this.SizeYHell = SizeYHell;
			this.OffsetX = OffsetX;
			this.OffsetY = OffsetY;
			this.Depend = Depend;
			this.Teleport = Teleport;
			this.Rain = Rain;
			this.Mud = Mud;
			this.NoPer = NoPer;
			this.LOSDraw = LOSDraw;
			this.FloorFilter = FloorFilter;
			this.BlankScreen = BlankScreen;
			this.DrawEdges = DrawEdges;
			this.IsInside = IsInside;
			this.DrlgType = DrlgType;
			this.LevelType = LevelType;
			this.SubType = SubType;
			this.SubTheme = SubTheme;
			this.SubWaypoint = SubWaypoint;
			this.SubShrine = SubShrine;
			this.Vis0 = Vis0;
			this.Vis1 = Vis1;
			this.Vis2 = Vis2;
			this.Vis3 = Vis3;
			this.Vis4 = Vis4;
			this.Vis5 = Vis5;
			this.Vis6 = Vis6;
			this.Vis7 = Vis7;
			this.Warp0 = Warp0;
			this.Warp1 = Warp1;
			this.Warp2 = Warp2;
			this.Warp3 = Warp3;
			this.Warp4 = Warp4;
			this.Warp5 = Warp5;
			this.Warp6 = Warp6;
			this.Warp7 = Warp7;
			this.Intensity = Intensity;
			this.Red = Red;
			this.Green = Green;
			this.Blue = Blue;
			this.Portal = Portal;
			this.Position = Position;
			this.SaveMonsters = SaveMonsters;
			this.Quest = Quest;
			this.WarpDist = WarpDist;
			this.MonLvl1 = MonLvl1;
			this.MonLvl2 = MonLvl2;
			this.MonLvl3 = MonLvl3;
			this.MonLvl1Ex = MonLvl1Ex;
			this.MonLvl2Ex = MonLvl2Ex;
			this.MonLvl3Ex = MonLvl3Ex;
			this.MonDen = MonDen;
			this.MonDenNM = MonDenNM;
			this.MonDenHell = MonDenHell;
			this.MonUMin = MonUMin;
			this.MonUMax = MonUMax;
			this.MonUMinNM = MonUMinNM;
			this.MonUMaxNM = MonUMaxNM;
			this.MonUMinHell = MonUMinHell;
			this.MonUMaxHell = MonUMaxHell;
			this.MonWndr = MonWndr;
			this.MonSpcWalk = MonSpcWalk;
			this.NumMon = NumMon;
			this.mon1 = mon1;
			this.mon2 = mon2;
			this.mon3 = mon3;
			this.mon4 = mon4;
			this.mon5 = mon5;
			this.mon6 = mon6;
			this.mon7 = mon7;
			this.mon8 = mon8;
			this.mon9 = mon9;
			this.mon10 = mon10;
			this.rangedspawn = rangedspawn;
			this.nmon1 = nmon1;
			this.nmon2 = nmon2;
			this.nmon3 = nmon3;
			this.nmon4 = nmon4;
			this.nmon5 = nmon5;
			this.nmon6 = nmon6;
			this.nmon7 = nmon7;
			this.nmon8 = nmon8;
			this.nmon9 = nmon9;
			this.nmon10 = nmon10;
			this.umon1 = umon1;
			this.umon2 = umon2;
			this.umon3 = umon3;
			this.umon4 = umon4;
			this.umon5 = umon5;
			this.umon6 = umon6;
			this.umon7 = umon7;
			this.umon8 = umon8;
			this.umon9 = umon9;
			this.umon10 = umon10;
			this.cmon1 = cmon1;
			this.cmon2 = cmon2;
			this.cmon3 = cmon3;
			this.cmon4 = cmon4;
			this.cpct1 = cpct1;
			this.cpct2 = cpct2;
			this.cpct3 = cpct3;
			this.cpct4 = cpct4;
			this.camt1 = camt1;
			this.camt2 = camt2;
			this.camt3 = camt3;
			this.camt4 = camt4;
			this.Themes = Themes;
			this.SoundEnv = SoundEnv;
			this.Waypoint = Waypoint;
			this.LevelName = LevelName;
			this.LevelWarp = LevelWarp;
			this.EntryFile = EntryFile;
			this.ObjGrp0 = ObjGrp0;
			this.ObjGrp1 = ObjGrp1;
			this.ObjGrp2 = ObjGrp2;
			this.ObjGrp3 = ObjGrp3;
			this.ObjGrp4 = ObjGrp4;
			this.ObjGrp5 = ObjGrp5;
			this.ObjGrp6 = ObjGrp6;
			this.ObjGrp7 = ObjGrp7;
			this.ObjPrb0 = ObjPrb0;
			this.ObjPrb1 = ObjPrb1;
			this.ObjPrb2 = ObjPrb2;
			this.ObjPrb3 = ObjPrb3;
			this.ObjPrb4 = ObjPrb4;
			this.ObjPrb5 = ObjPrb5;
			this.ObjPrb6 = ObjPrb6;
			this.ObjPrb7 = ObjPrb7;
		}

		// Token: 0x04006C43 RID: 27715
		public readonly string Name;

		// Token: 0x04006C44 RID: 27716
		public readonly int Id;

		// Token: 0x04006C45 RID: 27717
		public readonly int Pal;

		// Token: 0x04006C46 RID: 27718
		public readonly int Act;

		// Token: 0x04006C47 RID: 27719
		public readonly int QuestFlag;

		// Token: 0x04006C48 RID: 27720
		public readonly int QuestFlagEx;

		// Token: 0x04006C49 RID: 27721
		public readonly int Layer;

		// Token: 0x04006C4A RID: 27722
		public readonly int SizeX;

		// Token: 0x04006C4B RID: 27723
		public readonly int SizeY;

		// Token: 0x04006C4C RID: 27724
		public readonly int SizeXNM;

		// Token: 0x04006C4D RID: 27725
		public readonly int SizeYNM;

		// Token: 0x04006C4E RID: 27726
		public readonly int SizeXHell;

		// Token: 0x04006C4F RID: 27727
		public readonly int SizeYHell;

		// Token: 0x04006C50 RID: 27728
		public readonly int OffsetX;

		// Token: 0x04006C51 RID: 27729
		public readonly int OffsetY;

		// Token: 0x04006C52 RID: 27730
		public readonly int Depend;

		// Token: 0x04006C53 RID: 27731
		public readonly int Teleport;

		// Token: 0x04006C54 RID: 27732
		public readonly int Rain;

		// Token: 0x04006C55 RID: 27733
		public readonly int Mud;

		// Token: 0x04006C56 RID: 27734
		public readonly int NoPer;

		// Token: 0x04006C57 RID: 27735
		public readonly int LOSDraw;

		// Token: 0x04006C58 RID: 27736
		public readonly int FloorFilter;

		// Token: 0x04006C59 RID: 27737
		public readonly int BlankScreen;

		// Token: 0x04006C5A RID: 27738
		public readonly int DrawEdges;

		// Token: 0x04006C5B RID: 27739
		public readonly int IsInside;

		// Token: 0x04006C5C RID: 27740
		public readonly int DrlgType;

		// Token: 0x04006C5D RID: 27741
		public readonly int LevelType;

		// Token: 0x04006C5E RID: 27742
		public readonly int SubType;

		// Token: 0x04006C5F RID: 27743
		public readonly int SubTheme;

		// Token: 0x04006C60 RID: 27744
		public readonly int SubWaypoint;

		// Token: 0x04006C61 RID: 27745
		public readonly int SubShrine;

		// Token: 0x04006C62 RID: 27746
		public readonly int Vis0;

		// Token: 0x04006C63 RID: 27747
		public readonly int Vis1;

		// Token: 0x04006C64 RID: 27748
		public readonly int Vis2;

		// Token: 0x04006C65 RID: 27749
		public readonly int Vis3;

		// Token: 0x04006C66 RID: 27750
		public readonly int Vis4;

		// Token: 0x04006C67 RID: 27751
		public readonly int Vis5;

		// Token: 0x04006C68 RID: 27752
		public readonly int Vis6;

		// Token: 0x04006C69 RID: 27753
		public readonly int Vis7;

		// Token: 0x04006C6A RID: 27754
		public readonly int Warp0;

		// Token: 0x04006C6B RID: 27755
		public readonly int Warp1;

		// Token: 0x04006C6C RID: 27756
		public readonly int Warp2;

		// Token: 0x04006C6D RID: 27757
		public readonly int Warp3;

		// Token: 0x04006C6E RID: 27758
		public readonly int Warp4;

		// Token: 0x04006C6F RID: 27759
		public readonly int Warp5;

		// Token: 0x04006C70 RID: 27760
		public readonly int Warp6;

		// Token: 0x04006C71 RID: 27761
		public readonly int Warp7;

		// Token: 0x04006C72 RID: 27762
		public readonly int Intensity;

		// Token: 0x04006C73 RID: 27763
		public readonly int Red;

		// Token: 0x04006C74 RID: 27764
		public readonly int Green;

		// Token: 0x04006C75 RID: 27765
		public readonly int Blue;

		// Token: 0x04006C76 RID: 27766
		public readonly int Portal;

		// Token: 0x04006C77 RID: 27767
		public readonly int Position;

		// Token: 0x04006C78 RID: 27768
		public readonly int SaveMonsters;

		// Token: 0x04006C79 RID: 27769
		public readonly int Quest;

		// Token: 0x04006C7A RID: 27770
		public readonly int WarpDist;

		// Token: 0x04006C7B RID: 27771
		public readonly int MonLvl1;

		// Token: 0x04006C7C RID: 27772
		public readonly int MonLvl2;

		// Token: 0x04006C7D RID: 27773
		public readonly int MonLvl3;

		// Token: 0x04006C7E RID: 27774
		public readonly int MonLvl1Ex;

		// Token: 0x04006C7F RID: 27775
		public readonly int MonLvl2Ex;

		// Token: 0x04006C80 RID: 27776
		public readonly int MonLvl3Ex;

		// Token: 0x04006C81 RID: 27777
		public readonly int MonDen;

		// Token: 0x04006C82 RID: 27778
		public readonly int MonDenNM;

		// Token: 0x04006C83 RID: 27779
		public readonly int MonDenHell;

		// Token: 0x04006C84 RID: 27780
		public readonly int MonUMin;

		// Token: 0x04006C85 RID: 27781
		public readonly int MonUMax;

		// Token: 0x04006C86 RID: 27782
		public readonly int MonUMinNM;

		// Token: 0x04006C87 RID: 27783
		public readonly int MonUMaxNM;

		// Token: 0x04006C88 RID: 27784
		public readonly int MonUMinHell;

		// Token: 0x04006C89 RID: 27785
		public readonly int MonUMaxHell;

		// Token: 0x04006C8A RID: 27786
		public readonly int MonWndr;

		// Token: 0x04006C8B RID: 27787
		public readonly int MonSpcWalk;

		// Token: 0x04006C8C RID: 27788
		public readonly int NumMon;

		// Token: 0x04006C8D RID: 27789
		public readonly string mon1;

		// Token: 0x04006C8E RID: 27790
		public readonly string mon2;

		// Token: 0x04006C8F RID: 27791
		public readonly string mon3;

		// Token: 0x04006C90 RID: 27792
		public readonly string mon4;

		// Token: 0x04006C91 RID: 27793
		public readonly string mon5;

		// Token: 0x04006C92 RID: 27794
		public readonly string mon6;

		// Token: 0x04006C93 RID: 27795
		public readonly string mon7;

		// Token: 0x04006C94 RID: 27796
		public readonly string mon8;

		// Token: 0x04006C95 RID: 27797
		public readonly string mon9;

		// Token: 0x04006C96 RID: 27798
		public readonly string mon10;

		// Token: 0x04006C97 RID: 27799
		public readonly int rangedspawn;

		// Token: 0x04006C98 RID: 27800
		public readonly string nmon1;

		// Token: 0x04006C99 RID: 27801
		public readonly string nmon2;

		// Token: 0x04006C9A RID: 27802
		public readonly string nmon3;

		// Token: 0x04006C9B RID: 27803
		public readonly string nmon4;

		// Token: 0x04006C9C RID: 27804
		public readonly string nmon5;

		// Token: 0x04006C9D RID: 27805
		public readonly string nmon6;

		// Token: 0x04006C9E RID: 27806
		public readonly string nmon7;

		// Token: 0x04006C9F RID: 27807
		public readonly string nmon8;

		// Token: 0x04006CA0 RID: 27808
		public readonly string nmon9;

		// Token: 0x04006CA1 RID: 27809
		public readonly string nmon10;

		// Token: 0x04006CA2 RID: 27810
		public readonly string umon1;

		// Token: 0x04006CA3 RID: 27811
		public readonly string umon2;

		// Token: 0x04006CA4 RID: 27812
		public readonly string umon3;

		// Token: 0x04006CA5 RID: 27813
		public readonly string umon4;

		// Token: 0x04006CA6 RID: 27814
		public readonly string umon5;

		// Token: 0x04006CA7 RID: 27815
		public readonly string umon6;

		// Token: 0x04006CA8 RID: 27816
		public readonly string umon7;

		// Token: 0x04006CA9 RID: 27817
		public readonly string umon8;

		// Token: 0x04006CAA RID: 27818
		public readonly string umon9;

		// Token: 0x04006CAB RID: 27819
		public readonly string umon10;

		// Token: 0x04006CAC RID: 27820
		public readonly string cmon1;

		// Token: 0x04006CAD RID: 27821
		public readonly string cmon2;

		// Token: 0x04006CAE RID: 27822
		public readonly string cmon3;

		// Token: 0x04006CAF RID: 27823
		public readonly string cmon4;

		// Token: 0x04006CB0 RID: 27824
		public readonly int cpct1;

		// Token: 0x04006CB1 RID: 27825
		public readonly int cpct2;

		// Token: 0x04006CB2 RID: 27826
		public readonly int cpct3;

		// Token: 0x04006CB3 RID: 27827
		public readonly int cpct4;

		// Token: 0x04006CB4 RID: 27828
		public readonly int camt1;

		// Token: 0x04006CB5 RID: 27829
		public readonly int camt2;

		// Token: 0x04006CB6 RID: 27830
		public readonly int camt3;

		// Token: 0x04006CB7 RID: 27831
		public readonly int camt4;

		// Token: 0x04006CB8 RID: 27832
		public readonly int Themes;

		// Token: 0x04006CB9 RID: 27833
		public readonly int SoundEnv;

		// Token: 0x04006CBA RID: 27834
		public readonly int Waypoint;

		// Token: 0x04006CBB RID: 27835
		public readonly string LevelName;

		// Token: 0x04006CBC RID: 27836
		public readonly string LevelWarp;

		// Token: 0x04006CBD RID: 27837
		public readonly string EntryFile;

		// Token: 0x04006CBE RID: 27838
		public readonly int ObjGrp0;

		// Token: 0x04006CBF RID: 27839
		public readonly int ObjGrp1;

		// Token: 0x04006CC0 RID: 27840
		public readonly int ObjGrp2;

		// Token: 0x04006CC1 RID: 27841
		public readonly int ObjGrp3;

		// Token: 0x04006CC2 RID: 27842
		public readonly int ObjGrp4;

		// Token: 0x04006CC3 RID: 27843
		public readonly int ObjGrp5;

		// Token: 0x04006CC4 RID: 27844
		public readonly int ObjGrp6;

		// Token: 0x04006CC5 RID: 27845
		public readonly int ObjGrp7;

		// Token: 0x04006CC6 RID: 27846
		public readonly int ObjPrb0;

		// Token: 0x04006CC7 RID: 27847
		public readonly int ObjPrb1;

		// Token: 0x04006CC8 RID: 27848
		public readonly int ObjPrb2;

		// Token: 0x04006CC9 RID: 27849
		public readonly int ObjPrb3;

		// Token: 0x04006CCA RID: 27850
		public readonly int ObjPrb4;

		// Token: 0x04006CCB RID: 27851
		public readonly int ObjPrb5;

		// Token: 0x04006CCC RID: 27852
		public readonly int ObjPrb6;

		// Token: 0x04006CCD RID: 27853
		public readonly int ObjPrb7;

		// Token: 0x04006CCE RID: 27854
		public static readonly BaseLevel[] Levels = new BaseLevel[]
		{
			new BaseLevel("Null", 0, 0, 0, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 25, 50, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 255, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Town", 1, 0, 0, -1, -1, 0, 56, 40, 56, 40, 56, 40, -1, -1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 2, 1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 1, 1, 0, 0, 2025, 0, 25, 50, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "chicken", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 1, 0, "Rogue Encampment", "To The Rogue Encampment", "A1L1", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Wilderness 1", 2, 0, 0, -1, -1, 0, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 3, 2, 6, 0, 4, 5, 0, 0, 0, 8, 8, 8, 8, 0, -1, -1, -1, 0, 1, 2, 3, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 1, 26, 51, 1, 36, 67, 520, 520, 520, -1, -1, 4, 5, 7, 9, 1, 0, 3, "zombie1", "fallen1", "quillrat1", "", "", "", "", "", "", "", -1, "zombie1", "fallen1", "quillrat1", "", "", "", "", "", "", "", "zombie1", "fallen1", "quillrat1", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 255, "Blood Moor", "To The Blood Moor", "A1L2", 4, 38, 33, 34, 0, 0, 0, 0, 3, 17, 17, 17, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Wilderness 2", 3, 0, 0, -1, -1, 0, 80, 80, 80, 80, 80, 80, 1000, 1000, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 3, 2, 6, 1, 4, 5, 0, 0, 0, 9, 9, 9, 9, 0, -1, -1, -1, 0, 1, 2, 3, -1, 0, 0, 0, 0, 1, 0, 1, 0, 2025, 2, 27, 52, 2, 36, 68, 520, 520, 520, 1, 1, 4, 5, 7, 9, 1, 0, 3, "brute1", "corruptrogue1", "fallenshaman1", "cr_lancer1", "", "", "", "", "", "", -1, "brute1", "corruptrogue1", "fallenshaman1", "cr_lancer1", "", "", "", "", "", "", "brute1", "corruptrogue1", "fallenshaman1", "cr_lancer1", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 1, "Cold Plains", "To The Cold Plains", "A1L3", 4, 38, 33, 34, 0, 0, 0, 0, 3, 22, 22, 22, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Wilderness 3", 4, 0, 0, -1, -1, 0, 80, 80, 80, 80, 80, 80, 1000, 1000, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 3, 2, 6, 2, 4, 5, 0, 0, 0, 10, 10, 10, 10, 0, -1, -1, -1, 0, 1, 2, 3, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 4, 29, 54, 4, 37, 68, 520, 520, 520, 1, 2, 4, 6, 7, 9, 1, 0, 3, "skeleton1", "zombie2", "crownest1", "goatman1", "cr_archer1", "", "", "", "", "", -1, "skeleton1", "zombie2", "crownest1", "goatman1", "cr_archer1", "", "", "", "", "", "skeleton1", "zombie2", "foulcrow1", "goatman1", "cr_archer1", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 2, "Stony Field", "To The Stony Field", "A1L4", 1, 38, 33, 34, 0, 0, 0, 0, 4, 27, 27, 27, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Wilderness 4", 5, 0, 0, -1, -1, 0, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 3, 2, 6, 3, 4, 5, 0, 0, 0, 10, 10, 10, 10, 0, -1, -1, -1, 0, 1, 2, 3, -1, 0, 0, 0, 0, 1, 0, 1, 0, 2025, 5, 30, 55, 5, 38, 68, 520, 520, 520, 1, 2, 4, 6, 7, 9, 1, 0, 3, "fallen2", "corruptrogue2", "quillrat2", "cr_lancer2", "sk_archer1", "", "", "", "", "", -1, "fallen2", "corruptrogue2", "quillrat2", "cr_lancer2", "sk_archer1", "", "", "", "", "", "fallen2", "corruptrogue2", "quillrat2", "cr_lancer2", "sk_archer1", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 3, "Dark Wood", "To The Dark Wood", "A1L5", 1, 38, 33, 34, 0, 0, 0, 0, 4, 30, 30, 30, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Wilderness 5", 6, 0, 0, -1, -1, 0, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 3, 2, 6, 4, 4, 5, 0, 0, 20, 11, 11, 11, 11, 0, -1, -1, 10, 0, 1, 2, 3, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 6, 31, 56, 6, 38, 69, 520, 520, 520, 1, 2, 4, 6, 7, 9, 1, 0, 3, "crownest2", "skeleton2", "brute2", "goatman2", "fallenshaman2", "cr_archer2", "", "", "", "", -1, "crownest2", "skeleton2", "brute2", "goatman2", "fallenshaman2", "cr_archer2", "", "", "", "", "skeleton2", "foulcrow2", "brute2", "goatman2", "fallenshaman2", "cr_archer2", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 4, "Black Marsh", "To The Black Marsh", "A1L6", 1, 38, 33, 34, 0, 0, 0, 0, 5, 32, 32, 32, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Wilderness 6", 7, 0, 0, -1, -1, 0, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 3, 2, 6, 2, 4, 5, 0, 0, 0, 12, 12, 12, 12, 0, -1, -1, -1, 0, 1, 2, 3, -1, 0, 0, 0, 0, 1, 0, 1, 0, 2025, 8, 33, 58, 8, 39, 69, 520, 520, 520, 1, 2, 4, 6, 7, 9, 1, 0, 3, "corruptrogue3", "quillrat3", "cr_lancer3", "sk_archer2", "skmage_fire1", "", "", "", "", "", -1, "corruptrogue3", "quillrat3", "cr_lancer3", "sk_archer2", "skmage_fire1", "", "", "", "", "", "corruptrogue3", "quillrat3", "cr_lancer3", "sk_archer2", "skmage_fire1", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 255, "Tamoe Highland", "To The Tamoe Highland", "A1L7", 1, 38, 33, 34, 0, 0, 0, 0, 5, 35, 35, 35, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 1", 8, 0, 0, -1, -1, 1, 200, 200, 200, 200, 200, 200, 1500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 3, -1, -1, -1, -1, 2, 0, 0, 0, 0, 0, 0, 0, 4, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 1, 2025, 1, 26, 51, 1, 36, 79, 600, 600, 600, -1, -1, -1, -1, -1, -1, 0, 0, 3, "zombie1", "brute1", "fallenshaman1", "", "", "", "", "", "", "", -1, "zombie1", "brute1", "fallenshaman1", "", "", "", "", "", "", "", "zombie1", "brute1", "fallenshaman1", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Den of Evil", "To The Den of Evil", "A1L9", 6, 4, 0, 0, 0, 0, 0, 0, 35, 45, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 2", 9, 0, 0, -1, -1, 2, 200, 200, 200, 200, 200, 200, 1500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 3, -1, -1, -1, -1, 3, 0, 0, 0, 13, 0, 0, 0, 4, -1, -1, -1, 5, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 2, 27, 52, 2, 36, 77, 600, 600, 600, 1, 2, 4, 6, 6, 8, 1, 0, 3, "skeleton1", "zombie2", "cr_archer1", "", "", "", "", "", "", "", -1, "skeleton1", "zombie2", "cr_archer1", "", "", "", "", "", "", "", "skeleton1", "zombie2", "cr_archer1", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Cave Level 1", "To The Cave Level 1", "A1L9", 6, 4, 0, 0, 0, 0, 0, 0, 30, 3, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 3", 10, 0, 0, -1, -1, 3, 200, 200, 200, 200, 200, 200, 1500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 3, -1, -1, -1, -1, 4, 5, 0, 0, 14, 0, 0, 0, 4, 4, -1, -1, 5, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 4, 29, 54, 4, 37, 69, 600, 600, 600, 1, 2, 4, 6, 6, 8, 1, 0, 3, "bighead3", "fallen2", "corruptrogue2", "sk_archer1", "", "", "", "", "", "", -1, "bighead3", "fallen2", "corruptrogue2", "sk_archer1", "", "", "", "", "", "", "bighead3", "fallen2", "corruptrogue2", "sk_archer1", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Underground Passage Level 1", "To Underground Passage Level 1", "A1L10", 6, 4, 0, 0, 0, 0, 0, 0, 30, 3, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 4", 11, 0, 0, -1, -1, 4, 200, 200, 200, 200, 200, 200, 1500, 1900, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 3, -1, -1, -1, -1, 6, 0, 0, 0, 15, 0, 0, 0, 4, -1, -1, -1, 5, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 5, 30, 55, 5, 38, 80, 600, 600, 600, 1, 2, 4, 6, 6, 8, 1, 0, 3, "bighead3", "fallen2", "brute2", "cr_archer2", "", "", "", "", "", "", -1, "bighead3", "fallen2", "brute2", "cr_archer2", "", "", "", "", "", "", "bighead3", "fallen2", "brute2", "cr_archer2", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Hole Level 1", "To The Hole Level 1", "A1L11", 6, 4, 0, 0, 0, 0, 0, 0, 30, 3, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 5", 12, 0, 0, -1, -1, 5, 200, 200, 200, 200, 200, 200, 1500, 2200, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 3, -1, -1, -1, -1, 7, 0, 0, 0, 16, 0, 0, 0, 4, -1, -1, -1, 5, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 7, 32, 57, 7, 39, 85, 600, 600, 600, 1, 2, 4, 6, 6, 8, 1, 0, 3, "skeleton3", "fallen3", "corruptrogue3", "cr_archer3", "", "", "", "", "", "", -1, "skeleton3", "fallen3", "corruptrogue3", "cr_archer3", "", "", "", "", "", "", "skeleton3", "fallen3", "corruptrogue3", "cr_archer3", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Pit Level 1", "To The Pit Level 1", "A1L12", 6, 4, 0, 0, 0, 0, 0, 0, 30, 6, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 2 Treasure", 13, 0, 0, -1, -1, 6, 24, 24, 24, 24, 24, 24, 1500, 2500, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 3, -1, -1, -1, -1, 0, 9, 0, 0, 0, 0, 0, 0, -1, 4, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 2, 27, 52, 2, 37, 78, 600, 600, 600, 1, 2, 2, 3, 2, 3, 1, 0, 3, "skeleton1", "zombie2", "cr_archer1", "", "", "", "", "", "", "", -1, "skeleton1", "zombie2", "cr_archer1", "", "", "", "", "", "", "", "skeleton1", "zombie2", "cr_archer1", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Cave Level 2", "To The Cave Level 2", "A1L14", 6, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 3 Treasure", 14, 0, 0, -1, -1, 7, 24, 24, 24, 24, 24, 24, 1500, 2624, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 3, -1, -1, -1, -1, 0, 10, 0, 0, 0, 0, 0, 0, -1, 4, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 4, 29, 54, 4, 38, 83, 600, 600, 600, 1, 2, 2, 3, 2, 3, 1, 0, 3, "bighead3", "fallen2", "corruptrogue2", "sk_archer1", "", "", "", "", "", "", -1, "bighead3", "fallen2", "corruptrogue2", "sk_archer1", "", "", "", "", "", "", "bighead3", "fallen2", "corruptrogue2", "sk_archer1", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Underground Passage Level 2", "To Underground Passage Level 2", "A1L15", 6, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 4 Treasure", 15, 0, 0, -1, -1, 8, 24, 24, 24, 24, 24, 24, 1500, 2748, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 3, -1, -1, -1, -1, 0, 11, 0, 0, 0, 0, 0, 0, -1, 4, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 3800, 5, 30, 55, 5, 39, 81, 600, 600, 600, 1, 2, 2, 3, 2, 3, 1, 0, 3, "bighead3", "fallen2", "brute2", "cr_archer2", "", "", "", "", "", "", -1, "bighead3", "fallen2", "brute2", "cr_archer2", "", "", "", "", "", "", "bighead3", "fallen2", "brute2", "cr_archer2", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Hole Level 2", "To The Hole Level 2", "A1L16", 6, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cave 5 Treasure", 16, 0, 0, -1, -1, 9, 24, 24, 24, 24, 24, 24, 1500, 2872, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 3, -1, -1, -1, -1, 0, 12, 0, 0, 0, 0, 0, 0, -1, 4, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 7, 32, 57, 7, 40, 85, 600, 600, 600, 1, 2, 2, 3, 2, 3, 1, 0, 3, "skeleton3", "fallen3", "corruptrogue3", "cr_archer3", "", "", "", "", "", "", -1, "skeleton3", "fallen3", "corruptrogue3", "cr_archer3", "", "", "", "", "", "", "skeleton3", "fallen3", "corruptrogue3", "cr_archer3", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 4, 255, "Pit Level 2", "To The Pit Level 2", "A1L17", 6, 4, 0, 0, 0, 0, 0, 0, 25, 6, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Graveyard", 17, 0, 0, -1, -1, 0, 40, 48, 40, 48, 40, 48, -1, -1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 3, 2, -1, -1, -1, -1, 18, 19, 0, 0, 0, 0, 0, 0, 6, 7, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 3, 28, 53, 3, 36, 80, 520, 520, 520, -1, -1, -1, -1, -1, -1, 1, 0, 3, "skeleton1", "zombie2", "", "", "", "", "", "", "", "", -1, "skeleton1", "zombie2", "", "", "", "", "", "", "", "", "skeleton1", "zombie2", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 255, "Burial Grounds", "To The Burial Grounds", "A1L18", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Crypt 1 A", 18, 0, 0, -1, -1, 10, 200, 200, 200, 200, 200, 200, 2000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 4, -1, -1, -1, -1, 17, 0, 0, 0, 0, 0, 0, 0, 8, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 3, 28, 53, 3, 37, 83, 1056, 1056, 1056, 1, 1, 3, 4, 4, 5, 1, 0, 3, "skeleton1", "zombie2", "", "", "", "", "", "", "", "", -1, "skeleton1", "zombie2", "", "", "", "", "", "", "", "", "skeleton1", "zombie2", "", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Crypt", "To The Crypt", "A1L19", 7, 8, 9, 10, 0, 0, 0, 0, 75, 4, 50, 75, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Crypt 2 A", 19, 0, 0, -1, -1, 11, 200, 200, 200, 200, 200, 200, 2000, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 4, -1, -1, -1, -1, 17, 0, 0, 0, 0, 0, 0, 0, 8, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 3, 28, 53, 3, 37, 85, 1056, 1056, 1056, 1, 1, 3, 4, 4, 5, 1, 0, 3, "skeleton1", "zombie2", "", "", "", "", "", "", "", "", -1, "skeleton1", "zombie2", "", "", "", "", "", "", "", "", "skeleton1", "zombie2", "", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Mausoleum", "To The Mausoleum", "A1L20", 7, 8, 9, 10, 0, 0, 0, 0, 75, 4, 50, 75, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Tower 2", 20, 0, 0, -1, -1, 12, 8, 8, 8, 8, 8, 8, 2000, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 2, -1, -1, -1, -1, 6, 21, 0, 0, 0, 0, 0, 0, 11, 12, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 7, 32, 57, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 1, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 5, 255, "Forgotten Tower", "To The Forgotten Tower", "A1L21", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Crypt 3 A", 21, 0, 0, -1, -1, 13, 200, 200, 200, 200, 200, 200, 2500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 4, -1, -1, -1, -1, 20, 22, 0, 0, 0, 0, 0, 0, 8, 9, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 7, 32, 57, 7, 38, 75, 1024, 1024, 1024, 1, 1, 2, 3, 3, 4, 1, 0, 3, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", -1, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Tower Cellar Level 1", "To The Tower Cellar Level 1", "A1L22", 15, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Crypt 3 B", 22, 0, 0, -1, -1, 14, 200, 200, 200, 200, 200, 200, 2500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 4, -1, -1, -1, -1, 21, 23, 0, 0, 0, 0, 0, 0, 8, 9, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 7, 32, 57, 7, 39, 76, 1024, 1024, 1024, 1, 1, 2, 3, 3, 4, 1, 0, 3, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", -1, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Tower Cellar Level 2", "To The Tower Cellar Level 2", "A1L23", 15, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Crypt 3 C", 23, 0, 0, -1, -1, 15, 200, 200, 200, 200, 200, 200, 2500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 4, -1, -1, -1, -1, 22, 24, 0, 0, 0, 0, 0, 0, 8, 9, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 7, 32, 57, 7, 40, 77, 1024, 1024, 1024, 1, 1, 2, 3, 3, 4, 1, 0, 3, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", -1, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Tower Cellar Level 3", "To The Tower Cellar Level 3", "A1L24", 15, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Crypt 3 D", 24, 0, 0, -1, -1, 16, 200, 200, 200, 200, 200, 200, 2500, 1900, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 4, -1, -1, -1, -1, 23, 25, 0, 0, 0, 0, 0, 0, 8, 9, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 7, 32, 57, 7, 41, 78, 1024, 1024, 1024, 1, 1, 2, 3, 3, 4, 1, 0, 3, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", -1, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Tower Cellar Level 4", "To The Tower Cellar Level 4", "A1L25", 15, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Crypt 3 E", 25, 0, 0, -1, -1, 17, 30, 30, 30, 30, 30, 30, 2500, 2200, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 4, -1, -1, -1, -1, 24, 0, 0, 0, 0, 0, 0, 0, 8, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 7, 32, 57, 7, 42, 79, 1024, 1024, 1024, 1, 1, 2, 3, 3, 4, 1, 0, 3, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", -1, "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "fallen3", "wraith1", "goatman3", "cr_archer3", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Tower Cellar Level 5", "To The Tower Cellar Level 5", "A1L26", 15, 0, 0, 0, 0, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Monastery", 26, 0, 0, -1, -1, 0, 64, 18, 64, 18, 64, 18, 3000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 2, 5, -1, -1, -1, -1, 0, 27, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 8, 33, 58, 8, 40, 70, 600, 600, 600, 0, 1, 0, 1, 1, 2, 1, 0, 3, "bighead4", "corruptrogue3", "sk_archer2", "skmage_ltng1", "", "", "", "", "", "", -1, "bighead4", "corruptrogue3", "sk_archer2", "skmage_ltng1", "", "", "", "", "", "", "bighead4", "corruptrogue3", "sk_archer2", "skmage_ltng1", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 48, 6, 255, "Monastery Gate", "To The Monastery Gate", "A1L27", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Courtyard 1", 27, 0, 0, -1, -1, 0, 56, 40, 56, 40, 56, 40, 0, -40, 26, 1, 0, 0, 0, 1, 1, 1, 0, 0, 2, 6, -1, -1, -1, -1, 26, 28, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 1, 0, 1, 0, 2025, 9, 34, 59, 9, 40, 70, 600, 600, 600, 0, 1, 1, 2, 2, 3, 1, 0, 3, "brute3", "corruptrogue4", "fallenshaman3", "quillrat4", "", "", "", "", "", "", -1, "brute3", "corruptrogue4", "fallenshaman3", "quillrat4", "", "", "", "", "", "", "brute3", "corruptrogue4", "fallenshaman3", "quillrat4", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 7, 5, "Outer Cloister", "To The Outer Cloister", "A1L28", 14, 15, 0, 0, 0, 0, 0, 0, 7, 33, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Barracks", 28, 0, 0, -1, -1, 0, 200, 200, 200, 200, 200, 200, -1, -1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 7, -1, -1, -1, -1, 27, 29, 0, 0, 0, 0, 0, 0, -1, 14, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 9, 34, 59, 9, 40, 70, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 0, 3, "corruptrogue4", "goatman5", "fallenshaman3", "sk_archer3", "skmage_fire2", "", "", "", "", "", -1, "corruptrogue4", "goatman5", "fallenshaman3", "sk_archer3", "skmage_fire2", "", "", "", "", "", "corruptrogue4", "goatman5", "fallenshaman3", "sk_archer3", "skmage_fire2", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 8, 255, "Barracks", "To The Barracks", "A1L29", 51, 3, 17, 0, 0, 0, 0, 0, 9, 35, 25, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Jail 1", 29, 0, 0, -1, -1, 18, 200, 200, 200, 200, 200, 200, 3500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 8, -1, -1, -1, -1, 28, 30, 0, 0, 0, 0, 0, 0, 13, 14, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 1, 0, 1, 0, 2025, 10, 35, 60, 10, 41, 71, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 1, 3, "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_fire2", "", "", "", "", "", -1, "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_fire2", "", "", "", "", "", "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_fire2", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 8, 6, "Jail Level 1", "To The Jail Level 1", "A1L30", 51, 15, 3, 0, 0, 0, 0, 0, 11, 50, 35, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Jail 2", 30, 0, 0, -1, -1, 19, 200, 200, 200, 200, 200, 200, 3500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 8, -1, -1, -1, -1, 29, 31, 0, 0, 0, 0, 0, 0, 13, 14, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 10, 35, 60, 10, 41, 71, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 1, 3, "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_fire2", "", "", "", "", "", -1, "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_fire2", "", "", "", "", "", "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_fire2", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 8, 255, "Jail Level 2", "To The Jail Level 2", "A1L31", 51, 15, 3, 0, 0, 0, 0, 0, 13, 50, 45, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Jail 3", 31, 0, 0, -1, -1, 20, 200, 200, 200, 200, 200, 200, 3500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 8, -1, -1, -1, -1, 30, 32, 0, 0, 0, 0, 0, 0, 13, 13, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 10, 35, 60, 10, 41, 71, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 1, 3, "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_ltng2", "", "", "", "", "", -1, "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_ltng2", "", "", "", "", "", "fallen4", "wraith2", "goatman5", "sk_archer3", "skmage_ltng2", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 8, 255, "Jail Level 3", "To The Jail Level 3", "A1L32", 51, 15, 3, 0, 0, 0, 0, 0, 15, 50, 55, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Courtyard 2", 32, 0, 0, -1, -1, 0, 18, 20, 18, 20, 18, 20, 4000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 2, 6, -1, -1, -1, -1, 31, 33, 0, 0, 0, 0, 0, 0, 14, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 10, 35, 60, 10, 41, 72, 720, 720, 720, 0, 1, 1, 2, 2, 2, 1, 0, 3, "fallen4", "cr_archer4", "skmage_ltng2", "", "", "", "", "", "", "", -1, "fallen4", "cr_archer4", "skmage_ltng2", "", "", "", "", "", "", "", "fallen4", "cr_archer4", "skmage_ltng2", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 7, 7, "Inner Cloister", "To The Inner Cloister", "A1L33", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Cathedral", 33, 0, 0, -1, -1, 0, 28, 34, 28, 34, 28, 34, -4, -34, 32, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 9, -1, -1, -1, -1, 32, 34, 0, 0, 0, 0, 0, 0, -1, 15, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 1, 0, 1, 0, 2025, 11, 36, 61, 11, 42, 72, 680, 680, 680, 1, 2, 2, 3, 3, 3, 1, 0, 3, "bighead2", "wraith2", "fallenshaman4", "", "", "", "", "", "", "", -1, "bighead2", "wraith2", "fallenshaman4", "", "", "", "", "", "", "", "bighead2", "wraith2", "fallenshaman4", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 9, 255, "Cathedral", "To The Cathedral", "A1L34", 16, 3, 50, 17, 0, 0, 0, 0, 35, 45, 3, 3, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Catacombs 1", 34, 0, 0, -1, -1, 21, 200, 200, 200, 200, 200, 200, 4500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 10, -1, -1, -1, -1, 33, 35, 0, 0, 0, 0, 0, 0, 16, 18, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 11, 36, 61, 11, 42, 72, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 0, 3, "bighead2", "fallenshaman4", "fetish1", "", "", "", "", "", "", "", -1, "bighead2", "fallenshaman4", "fetish1", "", "", "", "", "", "", "", "bighead2", "fallenshaman4", "fetish1", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 60, 10, 255, "Catacombs Level 1", "To The Catacombs Level 1", "A1L35", 16, 3, 14, 17, 0, 0, 0, 0, 40, 45, 15, 3, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Catacombs 2", 35, 0, 0, -1, -1, 22, 200, 200, 200, 200, 200, 200, 4500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 10, -1, -1, -1, -1, 34, 36, 0, 0, 0, 0, 0, 0, 17, 18, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 11, 36, 61, 11, 42, 73, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 0, 3, "bighead2", "fallenshaman4", "arach1", "", "", "", "", "", "", "", -1, "bighead2", "fallenshaman4", "arach1", "", "", "", "", "", "", "", "bighead2", "fallenshaman4", "arach1", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 60, 10, 8, "Catacombs Level 2", "To The Catacombs Level 2", "A1L36", 16, 3, 14, 17, 0, 0, 0, 0, 45, 45, 17, 3, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Catacombs 3", 36, 0, 0, -1, -1, 23, 200, 200, 200, 200, 200, 200, 4500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 10, -1, -1, -1, -1, 35, 37, 0, 0, 0, 0, 0, 0, 17, 18, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 1, 0, 1, 0, 2025, 12, 37, 62, 12, 43, 73, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 0, 3, "zombie3", "bighead1", "vampire5", "", "", "", "", "", "", "", -1, "zombie3", "bighead1", "vampire5", "", "", "", "", "", "", "", "zombie3", "bighead1", "vampire5", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 60, 10, 255, "Catacombs Level 3", "To The Catacombs Level 3", "A1L37", 16, 3, 14, 17, 0, 0, 0, 0, 50, 45, 19, 3, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Catacombs 4", 37, 0, 0, -1, -1, 24, 22, 31, 22, 31, 22, 31, 4500, 1900, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 10, -1, -1, -1, -1, 36, 0, 0, 0, 0, 0, 0, 0, 17, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 12, 37, 62, 12, 43, 73, 680, 680, 680, 1, 2, 4, 5, 6, 8, 1, 0, 3, "zombie3", "bighead1", "", "", "", "", "", "", "", "", -1, "zombie3", "bighead1", "", "", "", "", "", "", "", "", "zombie3", "bighead1", "", "", "", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 60, 10, 255, "Catacombs Level 4", "To The Catacombs Level 4", "A1L38", 16, 3, 14, 17, 0, 0, 0, 0, 55, 45, 1, 3, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Tristram", 38, 0, 0, -1, -1, 25, 43, 48, 43, 48, 43, 48, 5000, 1000, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 2, 11, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 1, 1, 0, 2025, 6, 31, 56, 6, 39, 76, 520, 520, 520, 1, 2, 3, 4, 5, 6, 0, 0, 3, "skeleton2", "goatman2", "fallenshaman2", "sk_archer1", "", "", "", "", "", "", -1, "skeleton2", "goatman2", "fallenshaman2", "sk_archer1", "", "", "", "", "", "", "skeleton2", "goatman2", "fallenshaman2", "sk_archer1", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 255, "Tristram", "To Tristram", "A1L39", 44, 45, 0, 0, 0, 0, 0, 0, 0, 33, 1, 0, 0, 0, 0, 0),
			new BaseLevel("Act 1 - Moo Moo Farm", 39, 0, 0, 26, 40, 26, 80, 80, 80, 80, 80, 80, 5000, 1148, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 3, 2, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 28, 53, 78, 28, 64, 81, 800, 800, 800, 0, 1, 3, 4, 6, 8, 1, 0, 3, "hellbovine", "hellbovine", "hellbovine", "", "", "", "", "", "", "", -1, "hellbovine", "hellbovine", "hellbovine", "", "", "", "", "", "", "", "hellbovine", "hellbovine", "hellbovine", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 34, 255, "Moo Moo Farm", "To The Moo Moo Farm", "A1L40", 1, 38, 33, 34, 0, 0, 0, 0, 5, 35, 35, 35, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Town", 40, 1, 1, -1, -1, 27, 56, 56, 56, 56, 56, 56, 1000, 1000, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 2, 12, -1, -1, -1, -1, 0, 0, 47, 47, 50, 0, 0, 0, -1, -1, 19, 20, 24, -1, -1, -1, 0, 0, 0, 0, 1, 1, 0, 0, 2025, 0, 25, 50, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "bug", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 12, 9, "Lut Gholein", "To Lut Gholein", "A2L1", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Desert 1", 41, 1, 1, -1, -1, 27, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 3, 16, 9, 0, 7, 8, 55, 55, 55, 55, 0, 0, 0, 0, 33, 34, 35, 36, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 14, 39, 64, 14, 43, 75, 880, 880, 880, 1, 2, 4, 6, 7, 9, 1, 0, 3, "sandleaper1", "pantherwoman1", "scarab1", "vulture1", "slinger1", "", "", "", "", "", -1, "sandleaper1", "pantherwoman1", "scarab1", "vulture1", "slinger1", "", "", "", "", "", "sandleaper1", "pantherwoman1", "scarab1", "vulture1", "slinger1", "", "", "", "", "", "scorpion", "", "", "", 20, -1, -1, -1, -1, -1, -1, -1, 0, 13, 255, "Rocky Waste", "To The Rocky Waste", "A2L2", 30, 24, 32, 37, 36, 0, 0, 0, 15, 30, 15, 40, 40, 0, 0, 0),
			new BaseLevel("Act 2 - Desert 2", 42, 1, 1, -1, -1, 27, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 3, 16, 9, 1, 7, 8, 56, 56, 56, 56, 0, 0, 0, 0, 33, 34, 35, 36, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 15, 40, 65, 15, 44, 76, 880, 880, 880, 1, 2, 4, 6, 7, 9, 1, 0, 3, "sandleaper2", "pantherwoman2", "vulture2", "slinger5", "", "", "", "", "", "", -1, "sandleaper2", "pantherwoman2", "vulture2", "slinger5", "", "", "", "", "", "", "sandleaper2", "pantherwoman2", "vulture2", "slinger5", "", "", "", "", "", "", "scorpion", "", "", "", 20, -1, -1, -1, -1, -1, -1, -1, 0, 13, 11, "Dry Hills", "To The Dry Hills", "A2L3", 30, 24, 32, 37, 36, 0, 0, 0, 15, 30, 14, 40, 40, 0, 0, 0),
			new BaseLevel("Act 2 - Desert 3", 43, 1, 1, -1, -1, 27, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 3, 16, 9, 2, 7, 8, 0, 0, 0, 0, 62, 0, 0, 0, -1, -1, -1, -1, 47, -1, -1, -1, 0, 0, 0, 0, 1, 0, 1, 0, 2025, 16, 41, 66, 16, 45, 76, 880, 880, 880, 1, 2, 4, 6, 7, 9, 1, 0, 3, "crownest3", "sandmaggot1", "swarm1", "scarab2", "vulture2", "", "", "", "", "", -1, "crownest3", "sandmaggot1", "swarm1", "scarab2", "vulture2", "", "", "", "", "", "foulcrow3", "sandmaggot1", "swarm1", "scarab2", "vulture2", "", "", "", "", "", "scorpion", "", "", "", 20, -1, -1, -1, -1, -1, -1, -1, 0, 13, 13, "Far Oasis", "To The Far Oasis", "A2L4", 30, 24, 32, 37, 36, 0, 0, 0, 15, 30, 13, 40, 40, 0, 0, 0),
			new BaseLevel("Act 2 - Desert 4", 44, 1, 1, -1, -1, 27, 80, 80, 80, 80, 80, 80, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 3, 16, 9, 3, 7, 8, 0, 0, 65, 0, 0, 0, 0, 0, -1, -1, 50, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 3800, 17, 42, 67, 17, 46, 77, 880, 880, 880, 1, 2, 4, 6, 7, 9, 1, 0, 3, "zombie5", "sandraider2", "sandleaper3", "pantherwoman3", "slinger6", "", "", "", "", "", -1, "zombie5", "sandraider2", "sandleaper3", "pantherwoman3", "slinger6", "", "", "", "", "", "zombie5", "sandraider2", "sandleaper3", "pantherwoman3", "slinger6", "", "", "", "", "", "scorpion", "", "", "", 20, -1, -1, -1, -1, -1, -1, -1, 0, 13, 14, "Lost City", "To The Lost City", "A2L5", 30, 24, 32, 37, 36, 0, 0, 0, 15, 30, 12, 40, 40, 0, 0, 0),
			new BaseLevel("Act 2 - Desert 5", 45, 1, 1, -1, -1, 27, 32, 32, 32, 32, 32, 32, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 3, 16, -1, -1, -1, 8, 0, 58, 0, 0, 0, 0, 0, 0, -1, 37, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 1, 0, 1, 0, 2025, 18, 43, 68, 18, 46, 77, 880, 880, 880, 1, 2, 4, 6, 7, 9, 1, 0, 3, "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", -1, "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", "scorpion", "", "", "", 20, -1, -1, -1, -1, -1, -1, -1, 0, 13, 255, "Valley of Snakes", "To The Valley of Snakes", "A2L6", 30, 24, 32, 37, 36, 0, 0, 0, 15, 30, 11, 40, 40, 0, 0, 0),
			new BaseLevel("Act 2 - Valley of the Kings", 46, 1, 1, 13, 13, 28, 80, 80, 80, 80, 80, 80, 2500, 1000, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 3, 16, 9, 4, 7, 8, 0, 66, 67, 68, 69, 70, 71, 72, -1, 38, 39, 40, 41, 42, 43, 44, 0, 0, 0, 0, 1, 1, 1, 0, 3800, 16, 41, 66, 16, 48, 79, 880, 880, 880, -1, -1, 3, 4, 7, 9, 1, 0, 3, "brute4", "sandmaggot3", "pantherwoman4", "scarab4", "slinger4", "", "", "", "", "", -1, "brute4", "sandmaggot3", "pantherwoman4", "scarab4", "slinger4", "", "", "", "", "", "brute4", "sandmaggot3", "pantherwoman4", "scarab4", "slinger4", "", "", "", "", "", "scorpion", "", "", "", 20, -1, -1, -1, -1, -1, -1, -1, 0, 14, 17, "Canyon of the Magi", "To The Canyon of the Magi", "A2L7", 30, 24, 32, 37, 36, 0, 0, 0, 15, 30, 10, 40, 40, 0, 0, 0),
			new BaseLevel("Act 2 - Sewer 1 A", 47, 1, 1, -1, -1, 29, 200, 200, 200, 200, 200, 200, 1500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 13, -1, -1, -1, -1, 40, 40, 48, 0, 0, 0, 0, 0, 22, 21, 23, -1, -1, -1, -1, -1, 8, 255, 255, 255, 0, 0, 1, 0, 100, 13, 38, 63, 13, 43, 74, 680, 680, 680, 0, 1, 3, 4, 6, 8, 1, 0, 3, "skeleton4", "sandraider1", "mummy1", "sk_archer4", "", "", "", "", "", "", -1, "skeleton4", "sandraider1", "mummy1", "sk_archer4", "", "", "", "", "", "", "skeleton4", "sandraider1", "mummy1", "sk_archer4", "", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 100, 20, -1, -1, -1, -1, -1, 0, 15, 255, "Sewers Level 1", "To The Sewers Level 1", "A2L8", 32, 26, 5, 0, 0, 0, 0, 0, 10, 10, 10, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Sewer 1 B", 48, 1, 1, -1, -1, 30, 200, 200, 200, 200, 200, 200, 1500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 13, -1, -1, -1, -1, 47, 0, 49, 0, 0, 0, 0, 0, 22, -1, 23, -1, -1, -1, -1, -1, 8, 255, 255, 255, 0, 0, 1, 0, 2025, 13, 38, 63, 13, 43, 74, 680, 680, 680, 0, 1, 3, 4, 6, 8, 1, 0, 3, "skeleton4", "sandraider1", "mummy1", "sk_archer4", "", "", "", "", "", "", -1, "skeleton4", "sandraider1", "mummy1", "sk_archer4", "", "", "", "", "", "", "skeleton4", "sandraider1", "mummy1", "sk_archer4", "", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 100, 20, -1, -1, -1, -1, -1, 0, 15, 10, "Sewers Level 2", "To The Sewers Level 2", "A2L9", 32, 26, 5, 0, 0, 0, 0, 0, 12, 12, 12, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Sewer 1 C", 49, 1, 1, -1, -1, 31, 200, 200, 200, 200, 200, 200, 1500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 13, -1, -1, -1, -1, 48, 0, 0, 0, 0, 0, 0, 0, 22, -1, -1, -1, -1, -1, -1, -1, 8, 255, 255, 255, 0, 0, 1, 0, 2025, 14, 39, 64, 14, 44, 75, 680, 680, 680, 0, 1, 3, 4, 6, 8, 1, 0, 3, "skeleton4", "pantherwoman1", "mummy1", "skmage_fire3", "", "", "", "", "", "", -1, "skeleton4", "pantherwoman1", "mummy1", "skmage_fire3", "", "", "", "", "", "", "skeleton4", "pantherwoman1", "mummy1", "skmage_fire3", "", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 100, 20, -1, -1, -1, -1, -1, 0, 15, 255, "Sewers Level 3", "To The Sewers Level 3", "A2L10", 32, 26, 5, 0, 0, 0, 0, 0, 15, 15, 15, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Harem", 50, 1, 1, 11, 11, 32, 16, 19, 16, 19, 16, 19, 2000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 14, -1, -1, -1, -1, 40, 0, 51, 51, 0, 0, 0, 0, 25, -1, 28, 29, -1, -1, -1, -1, 128, 255, 255, 255, 0, 0, 0, 0, 2025, 0, 25, 50, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 16, 255, "Harem Level 1", "To The Harem Level 1", "A2L11", 56, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Corrupt Harem 1", 51, 1, 1, 11, 11, 33, 100, 100, 100, 100, 100, 100, 2000, 1119, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 14, -1, -1, -1, -1, 50, 50, 52, 52, 0, 0, 0, 0, 26, 27, 28, 29, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 13, 38, 63, 13, 47, 78, 2200, 2200, 2200, -1, -1, -1, -1, -1, -1, 1, 0, 3, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_cold4", "", "", "", "", "", -1, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_cold4", "", "", "", "", "", "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_cold4", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 17, 255, "Harem Level 2", "To The Harem Level 2", "A2L12", 56, 55, 0, 0, 0, 0, 0, 0, 15, 33, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Basement 1", 52, 1, 1, 11, 11, 34, 100, 100, 100, 100, 100, 100, 2000, 1319, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 15, -1, -1, -1, -1, 51, 51, 53, 53, 0, 0, 0, 0, 26, 27, 32, 32, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 13, 38, 63, 13, 47, 78, 2200, 2200, 2200, 0, 1, 3, 4, 5, 7, 1, 1, 3, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_fire4", "", "", "", "", "", -1, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_fire4", "", "", "", "", "", "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_fire4", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 18, 15, "Palace Cellar Level 1 ", "To The Palace Cellar Level 1 ", "A2L13", 57, 58, 0, 0, 0, 0, 0, 0, 20, 10, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Basement 2", 53, 1, 1, 11, 11, 35, 100, 100, 100, 100, 100, 100, 2000, 1519, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 15, -1, -1, -1, -1, 52, 52, 54, 54, 0, 0, 0, 0, 30, 31, 32, 32, -1, -1, -1, -1, 0, 255, 255, 255, 1, 0, 1, 0, 2025, 13, 38, 63, 13, 47, 78, 2200, 2200, 2200, 0, 1, 3, 4, 5, 7, 1, 1, 3, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_pois4", "", "", "", "", "", -1, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_pois4", "", "", "", "", "", "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_pois4", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 18, 255, "Palace Cellar Level 2", "To The Palace Cellar Level 2", "A2L14", 57, 58, 0, 0, 0, 0, 0, 0, 20, 10, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Basement 3", 54, 1, 1, 11, 11, 36, 100, 100, 100, 100, 100, 100, 2000, 1719, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 15, -1, -1, -1, -1, 53, 53, 0, 0, 0, 0, 0, 0, 30, 31, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 1, 1, 1, 0, 2025, 13, 38, 63, 13, 48, 78, 2200, 2200, 2200, 0, 1, 3, 4, 5, 7, 1, 1, 3, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_ltng4", "", "", "", "", "", -1, "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_ltng4", "", "", "", "", "", "sandraider3", "baboon1", "sk_archer5", "blunderbore1", "skmage_ltng4", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 18, 255, "Palace Cellar Level 3", "To The Palace Cellar Level 3", "A2L15", 57, 58, 0, 0, 0, 0, 0, 0, 20, 10, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb 1 A", 55, 1, 1, -1, -1, 37, 200, 200, 200, 200, 200, 200, 3000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 41, 0, 0, 0, 59, 0, 0, 0, 45, -1, -1, -1, 46, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 12, 37, 62, 12, 44, 78, 2200, 2200, 2200, 0, 1, 3, 4, 6, 8, 1, 0, 3, "skeleton5", "scarab1", "skmage_ltng3", "", "", "", "", "", "", "", -1, "skeleton5", "scarab1", "skmage_ltng3", "", "", "", "", "", "", "", "skeleton5", "scarab1", "skmage_ltng3", "", "", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 19, 255, "Stony Tomb Level 1", "To The Stony Tomb Level 1", "A2L16", 19, 29, 24, 0, 0, 0, 0, 0, 10, 20, 35, 45, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb 2 A", 56, 1, 1, -1, -1, 38, 200, 200, 200, 200, 200, 200, 3000, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 42, 0, 0, 0, 57, 0, 0, 0, 45, -1, -1, -1, 46, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 12, 37, 62, 12, 44, 79, 2200, 2200, 2200, 0, 1, 3, 4, 6, 8, 1, 0, 3, "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", -1, "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 19, 255, "Halls of the Dead Level 1", "To The Halls of the Dead Level 1", "A2L17", 19, 29, 24, 0, 0, 0, 0, 0, 10, 20, 35, 45, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb 2 B", 57, 1, 1, -1, -1, 39, 200, 200, 200, 200, 200, 200, 3000, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 56, 0, 0, 0, 60, 0, 0, 0, 45, -1, -1, -1, 46, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 13, 38, 63, 13, 45, 81, 2200, 2200, 2200, 0, 1, 3, 4, 6, 8, 1, 0, 3, "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", -1, "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 19, 12, "Halls of the Dead Level 2", "To The Halls of the Dead Level 2", "A2L18", 19, 29, 24, 0, 0, 0, 0, 0, 10, 20, 35, 45, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb 3 A", 58, 1, 1, -1, -1, 40, 200, 200, 200, 200, 200, 200, 3000, 1900, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 45, 0, 0, 0, 61, 0, 0, 0, 45, -1, -1, -1, 46, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 14, 39, 64, 14, 47, 82, 2200, 2200, 2200, 0, 1, 3, 4, 6, 8, 1, 0, 3, "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", -1, "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 19, 255, "Claw Viper Temple Level 1", "To The Claw Viper Temple Level 1", "A2L19", 19, 29, 24, 0, 0, 0, 0, 0, 10, 20, 35, 45, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb 1 Treasure", 59, 1, 1, -1, -1, 41, 200, 200, 200, 200, 200, 200, 3000, 2200, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 55, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 12, 37, 62, 12, 44, 79, 2200, 2200, 2200, 0, 1, 0, 1, 1, 2, 1, 0, 3, "skeleton5", "scarab1", "skmage_pois3", "", "", "", "", "", "", "", -1, "skeleton5", "scarab1", "skmage_pois3", "", "", "", "", "", "", "", "skeleton5", "scarab1", "skmage_pois3", "", "", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 19, 255, "Stony Tomb Level 2", "To The Stony Tomb Level 2", "A2L20", 19, 29, 24, 0, 0, 0, 0, 0, 10, 30, 45, 55, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb 2 Treasure", 60, 1, 1, -1, -1, 42, 200, 200, 200, 200, 200, 200, 3000, 2500, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 57, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 13, 38, 63, 13, 45, 82, 2200, 2200, 2200, 0, 1, 0, 1, 1, 2, 1, 0, 3, "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", -1, "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", "mummy2", "unraveler1", "unraveler1", "batdemon1", "slinger2", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 19, 255, "Halls of the Dead Level 3", "To The Halls of the Dead Level 3", "A2L21", 19, 29, 24, 0, 0, 0, 0, 0, 10, 30, 45, 55, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb 3 Treasure", 61, 1, 1, -1, -1, 43, 200, 200, 200, 200, 200, 200, 3000, 2800, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 58, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 14, 39, 64, 14, 47, 83, 2200, 2200, 2200, 0, 1, 0, 1, 1, 2, 1, 0, 3, "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", -1, "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", "clawviper2", "clawviper2", "clawviper3", "clawviper3", "mummy3", "unraveler2", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 60, 19, 255, "Claw Viper Temple Level 2", "To The Claw Viper Temple Level 2", "A2L22", 19, 29, 24, 0, 0, 0, 0, 0, 10, 30, 45, 55, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Lair 1 A", 62, 1, 1, -1, -1, 44, 200, 200, 200, 200, 200, 200, 3500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 18, -1, -1, -1, -1, 43, 63, 0, 0, 0, 0, 0, 0, 48, 49, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 45, 84, 990, 990, 990, 0, 2, 3, 4, 5, 6, 1, 0, 3, "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", -1, "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 20, 255, "Maggot Lair Level 1", "To The Maggot Lair Level 1", "A2L23", 35, 29, 0, 0, 0, 0, 0, 0, 50, 35, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Lair 1 B", 63, 1, 1, -1, -1, 45, 200, 200, 200, 200, 200, 200, 3500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 18, -1, -1, -1, -1, 62, 64, 0, 0, 0, 0, 0, 0, 48, 49, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 45, 84, 990, 990, 990, 0, 2, 3, 4, 5, 6, 1, 0, 3, "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", -1, "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 20, 255, "Maggot Lair Level 2", "To The Maggot Lair Level 2", "A2L24", 35, 29, 0, 0, 0, 0, 0, 0, 65, 35, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Lair 1 Treasure", 64, 1, 1, -1, -1, 46, 200, 200, 200, 200, 200, 200, 3500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 18, -1, -1, -1, -1, 63, 0, 0, 0, 0, 0, 0, 0, 48, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 46, 85, 990, 990, 990, 0, 2, 2, 3, 4, 5, 1, 0, 3, "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", -1, "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", "sandmaggot1", "sandmaggot2", "swarm2", "scarab2", "scarab3", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 20, 255, "Maggot Lair Level 3", "To The Maggot Lair Level 3", "A2L25", 35, 29, 0, 0, 0, 0, 0, 0, 80, 55, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Sewer 2 A", 65, 1, 1, -1, -1, 47, 200, 200, 200, 200, 200, 200, 4000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 13, -1, -1, -1, -1, 44, 0, 0, 0, 0, 0, 0, 0, 22, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 46, 85, 680, 680, 680, 0, 2, 3, 4, 6, 8, 1, 0, 3, "zombie5", "sandraider3", "mummy3", "skmage_ltng4", "", "", "", "", "", "", -1, "zombie5", "sandraider3", "mummy3", "skmage_ltng4", "", "", "", "", "", "", "zombie5", "sandraider3", "mummy3", "skmage_ltng4", "", "", "", "", "", "", "rat", "bat", "scorpion", "", 30, 100, 20, -1, -1, -1, -1, -1, 8, 15, 255, "Ancient Tunnels", "To The Ancient Tunnels", "A2L26", 29, 0, 0, 0, 0, 0, 0, 0, 55, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb Tal 1", 66, 1, 1, 13, 13, 48, 200, 200, 200, 200, 200, 200, 4500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 46, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 4, 6, 7, 9, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 19, 255, "Tal Rasha's Tomb", "To Tal Rasha's Tomb", "A2L27", 19, 29, 32, 78, 0, 0, 0, 0, 10, 40, 5, 10, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb Tal 2", 67, 1, 1, 13, 13, 49, 200, 200, 200, 200, 200, 200, 4500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 46, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 4, 6, 7, 9, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 19, 255, "Tal Rasha's Tomb", "To Tal Rasha's Tomb", "A2L27", 19, 29, 32, 78, 0, 0, 0, 0, 10, 40, 5, 10, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb Tal 3", 68, 1, 1, 13, 13, 50, 200, 200, 200, 200, 200, 200, 4500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 46, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 4, 6, 7, 9, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 19, 255, "Tal Rasha's Tomb", "To Tal Rasha's Tomb", "A2L27", 19, 29, 32, 78, 0, 0, 0, 0, 10, 40, 5, 10, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb Tal 4", 69, 1, 1, 13, 13, 51, 200, 200, 200, 200, 200, 200, 4500, 1900, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 46, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 4, 6, 7, 9, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 19, 255, "Tal Rasha's Tomb", "To Tal Rasha's Tomb", "A2L27", 19, 29, 32, 78, 0, 0, 0, 0, 10, 40, 5, 10, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb Tal 5", 70, 1, 1, 13, 13, 52, 200, 200, 200, 200, 200, 200, 4500, 2200, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 46, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 4, 6, 7, 9, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 19, 255, "Tal Rasha's Tomb", "To Tal Rasha's Tomb", "A2L27", 19, 29, 32, 78, 0, 0, 0, 0, 10, 40, 5, 10, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb Tal 6", 71, 1, 1, 13, 13, 53, 200, 200, 200, 200, 200, 200, 4500, 2500, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 46, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 4, 6, 7, 9, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 19, 255, "Tal Rasha's Tomb", "To Tal Rasha's Tomb", "A2L27", 19, 29, 32, 78, 0, 0, 0, 0, 10, 40, 5, 10, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Tomb Tal 7", 72, 1, 1, 13, 13, 54, 200, 200, 200, 200, 200, 200, 4500, 2800, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 17, -1, -1, -1, -1, 46, 0, 0, 0, 0, 0, 0, 0, 45, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 4, 6, 7, 9, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "", 30, 30, 20, -1, -1, -1, -1, -1, 8, 19, 255, "Tal Rasha's Tomb", "To Tal Rasha's Tomb", "A2L27", 19, 29, 32, 78, 0, 0, 0, 0, 10, 40, 5, 10, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Duriel's Lair", 73, 1, 1, 13, 13, 55, 32, 47, 32, 47, 32, 47, 4500, 3100, 0, 2, 0, 0, 1, 1, 1, 1, 0, 1, 2, 17, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 1, 1, 0, 2025, 17, 42, 67, 17, 49, 80, 2200, 2200, 2200, 0, 2, 0, 2, 0, 2, 1, 0, 3, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", -1, "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "wraith4", "scarab4", "mummy4", "unraveler3", "unraveler3", "vampire1", "blunderbore2", "", "", "", "rat", "bat", "scorpion", "larva", 30, 30, 20, 100, -1, -1, -1, -1, 0, 21, 255, "Duriel's Lair", "To Duriel's Lair", "A2L40", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 2 - Arcane", 74, 1, 1, 11, 11, 56, 200, 200, 200, 200, 200, 200, 5000, 1000, 0, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 19, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 128, 255, 255, 255, 1, 1, 1, 11, 3800, 14, 39, 64, 14, 48, 79, 990, 990, 990, 0, 1, 4, 5, 7, 9, 1, 0, 3, "wraith3", "goatman4", "vampire1", "", "", "", "", "", "", "", -1, "wraith3", "goatman4", "vampire1", "", "", "", "", "", "", "", "wraith3", "goatman4", "vampire1", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 22, 16, "Arcane Sanctuary", "To The Arcane Sanctuary", "A2L41", 53, 75, 0, 0, 0, 0, 0, 0, 75, 75, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Town", 75, 2, 2, -1, -1, 57, 64, 48, 64, 48, 64, 48, 1000, 1000, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 2, 20, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 1, 0, 0, 2025, 0, 25, 50, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 23, 18, "Kurast Docktown", "To The Kurast Docktown", "A3L1", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Jungle 1", 76, 2, 2, -1, -1, 57, 64, 192, 64, 192, 64, 192, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 3, 21, -1, -1, -1, -1, 84, 85, 0, 0, 0, 0, 0, 0, 51, 51, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 21, 46, 71, 21, 49, 79, 650, 650, 650, 1, 2, 4, 6, 10, 15, 1, 5, 3, "baboon3", "mosquito1", "thornhulk1", "fetish2", "fetishblow2", "foulcrow4", "", "", "", "", -1, "baboon3", "mosquito1", "thornhulk1", "fetish2", "fetishblow2", "foulcrow4", "", "", "", "", "baboon3", "mosquito1", "thornhulk1", "fetish2", "fetishblow2", "foulcrow4", "", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 24, 19, "Spider Forest", "To The Spider Forest", "A3L2", 31, 43, 40, 52, 69, 0, 0, 0, 50, 15, 45, 35, 30, 0, 0, 0),
			new BaseLevel("Act 3 - Jungle 2", 77, 2, 2, -1, -1, 57, 64, 192, 64, 192, 64, 192, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 3, 21, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 21, 46, 71, 21, 50, 80, 650, 650, 650, 1, 2, 4, 6, 10, 15, 1, 5, 3, "frogdemon1", "frogdemon2", "thornhulk2", "zombie4", "fetishshaman2", "willowisp1", "", "", "", "", -1, "frogdemon1", "frogdemon2", "thornhulk2", "zombie4", "fetishshaman2", "willowisp1", "", "", "", "", "frogdemon1", "frogdemon2", "thornhulk2", "zombie4", "fetishshaman2", "willowisp1", "", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 24, 20, "Great Marsh", "To The Great Marsh", "A3L3", 31, 43, 40, 52, 69, 0, 0, 0, 50, 15, 45, 35, 30, 0, 0, 0),
			new BaseLevel("Act 3 - Jungle 3", 78, 2, 2, -1, -1, 57, 64, 192, 64, 192, 64, 192, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 3, 21, -1, -1, -1, -1, 86, 88, 0, 0, 0, 0, 0, 0, 53, 54, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 22, 47, 72, 22, 50, 80, 650, 650, 650, 1, 2, 4, 6, 10, 15, 1, 5, 3, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "vulture4", "frogdemon3", "fetishblow3", "", "", "", -1, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "vulture4", "frogdemon3", "fetishblow3", "", "", "", "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "vulture4", "frogdemon3", "fetishblow3", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 24, 21, "Flayer Jungle", "To The Flayer Jungle", "A3L4", 31, 43, 40, 52, 43, 69, 0, 0, 50, 15, 45, 35, 50, 25, 0, 0),
			new BaseLevel("Act 3 - Kurast 1", 79, 2, 2, -1, -1, 57, 80, 64, 80, 64, 80, 64, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 3, 22, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 22, 47, 72, 22, 52, 80, 325, 325, 325, 1, 2, 4, 6, 7, 9, 1, 0, 3, "baboon4", "sandleaper4", "vulture3", "zealot1", "", "", "", "", "", "", -1, "baboon4", "sandleaper4", "vulture3", "zealot1", "", "", "", "", "", "", "baboon4", "sandleaper4", "vulture3", "zealot1", "", "", "", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 25, 22, "Lower Kurast", "To Lower Kurast", "A3L5", 31, 76, 40, 42, 43, 69, 0, 0, 33, 15, 35, 40, 40, 15, 0, 0),
			new BaseLevel("Act 3 - Kurast 2", 80, 2, 2, -1, -1, 57, 80, 64, 80, 64, 80, 64, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 3, 22, -1, -1, -1, -1, 92, 92, 94, 95, 0, 0, 0, 0, 57, 57, 61, 61, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 22, 47, 72, 22, 52, 81, 325, 325, 325, 1, 2, 4, 6, 7, 9, 1, 0, 3, "thornhulk3", "swarm4", "zealot2", "cantor1", "", "", "", "", "", "", -1, "thornhulk3", "swarm4", "zealot2", "cantor1", "", "", "", "", "", "", "thornhulk3", "swarm4", "zealot2", "cantor1", "", "", "", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 25, 23, "Kurast Bazaar", "To The Kurast Bazaar", "A3L6", 31, 76, 40, 42, 43, 69, 0, 0, 33, 15, 45, 50, 50, 25, 0, 0),
			new BaseLevel("Act 3 - Kurast 3", 81, 2, 2, -1, -1, 57, 80, 64, 80, 64, 80, 64, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 3, 22, -1, -1, -1, -1, 92, 92, 96, 97, 0, 0, 0, 0, 57, 57, 61, 61, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 23, 48, 73, 23, 52, 81, 325, 325, 325, 1, 2, 4, 6, 7, 9, 1, 0, 3, "vulture4", "zealot3", "cantor2", "thornhulk3", "", "", "", "", "", "", -1, "vulture4", "zealot3", "cantor2", "thornhulk3", "", "", "", "", "", "", "vulture4", "zealot3", "cantor2", "thornhulk3", "", "", "", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 25, 24, "Upper Kurast", "To Upper Kurast", "A3L7", 31, 76, 40, 42, 43, 69, 0, 0, 33, 15, 45, 50, 50, 25, 0, 0),
			new BaseLevel("Act 3 - Kurast 4", 82, 2, 2, -1, -1, 57, 48, 16, 48, 16, 48, 16, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 3, 22, -1, -1, -1, -1, 0, 0, 98, 99, 0, 0, 0, 0, -1, -1, 61, 61, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 24, 49, 74, 24, 53, 81, 325, 325, 325, 1, 2, 4, 6, 7, 9, 1, 0, 3, "sandraider4", "baboon5", "cantor3", "", "", "", "", "", "", "", -1, "sandraider4", "baboon5", "cantor3", "", "", "", "", "", "", "", "sandraider4", "baboon5", "cantor3", "", "", "", "", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 25, 255, "Kurast Causeway", "To The Kurast Causeway", "A3L8", 31, 76, 40, 42, 43, 69, 0, 0, 33, 15, 45, 50, 50, 25, 0, 0),
			new BaseLevel("Act 3 - Travincal", 83, 2, 2, -1, -1, 57, 64, 64, 64, 64, 64, 64, -1, -1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 3, 22, -1, -1, -1, -1, 100, 0, 0, 0, 0, 0, 0, 0, 64, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 24, 49, 74, 24, 54, 82, 325, 325, 325, 0, 1, 3, 5, 6, 8, 1, 0, 3, "cantor3", "cantor3", "vampire2", "", "", "", "", "", "", "", -1, "cantor3", "cantor3", "vampire2", "", "", "", "", "", "", "", "cantor3", "cantor3", "vampire2", "", "", "", "", "", "", "", "snake", "parrot", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 0, 25, 25, "Travincal", "To Travincal", "A3L9", 31, 61, 40, 42, 69, 62, 0, 0, 33, 25, 50, 33, 33, 35, 0, 0),
			new BaseLevel("Act 3 - Spider 1", 84, 2, 2, -1, -1, 58, 200, 200, 200, 200, 200, 200, 1500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 23, -1, -1, -1, -1, 0, 76, 0, 0, 0, 0, 0, 0, -1, 52, -1, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 21, 46, 71, 21, 50, 79, 700, 700, 700, 0, 1, 3, 4, 4, 5, 1, 0, 3, "arach3", "arach4", "batdemon2", "sandmaggot4", "arach3", "", "", "", "", "", -1, "arach3", "arach4", "batdemon2", "sandmaggot4", "arach3", "", "", "", "", "", "arach3", "arach4", "batdemon2", "sandmaggot4", "arach3", "", "", "", "", "", "minispider", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 29, 255, "Spider Cave", "To The Spider Cave", "A3L10", 0, 2, 68, 62, 0, 0, 0, 0, 35, 35, 35, 35, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Spider 2", 85, 2, 2, -1, -1, 59, 200, 200, 200, 200, 200, 200, 1500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 23, -1, -1, -1, -1, 0, 76, 0, 0, 0, 0, 0, 0, -1, 52, -1, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 21, 46, 71, 21, 50, 79, 700, 700, 700, 0, 1, 3, 4, 4, 5, 1, 0, 3, "arach3", "arach4", "batdemon2", "sandmaggot4", "arach3", "", "", "", "", "", -1, "arach3", "arach4", "batdemon2", "sandmaggot4", "arach3", "", "", "", "", "", "arach3", "arach4", "batdemon2", "sandmaggot4", "arach3", "", "", "", "", "", "minispider", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 29, 255, "Spider Cavern", "To The Spider Cavern", "A3L11", 0, 2, 68, 62, 0, 0, 0, 0, 35, 35, 35, 35, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Dungeon 1 A", 86, 2, 2, -1, -1, 60, 200, 200, 200, 200, 200, 200, 2000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 24, -1, -1, -1, -1, 87, 78, 0, 0, 0, 0, 0, 0, 56, 55, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 21, 46, 71, 21, 51, 80, 700, 700, 700, 0, 1, 3, 4, 5, 6, 1, 0, 3, "mummy4", "bonefetish4", "batdemon2", "willowisp1", "bonefetish5", "", "", "", "", "", -1, "mummy4", "bonefetish4", "batdemon2", "willowisp1", "bonefetish5", "", "", "", "", "", "mummy4", "bonefetish4", "batdemon2", "willowisp1", "bonefetish5", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 27, 255, "Swampy Pit Level 1", "To The Swampy Pit Level 1", "A3L12", 66, 67, 62, 64, 72, 0, 0, 0, 80, 80, 35, 35, 35, 0, 0, 0),
			new BaseLevel("Act 3 - Dungeon 1 B", 87, 2, 2, -1, -1, 61, 200, 200, 200, 200, 200, 200, 2000, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 24, -1, -1, -1, -1, 90, 86, 0, 0, 0, 0, 0, 0, 56, 55, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 21, 46, 71, 21, 51, 81, 700, 700, 700, 0, 1, 3, 4, 5, 5, 1, 0, 3, "bonefetish4", "zombie4", "batdemon2", "willowisp1", "bonefetish5", "", "", "", "", "", -1, "bonefetish4", "zombie4", "batdemon2", "willowisp1", "bonefetish5", "", "", "", "", "", "bonefetish4", "zombie4", "batdemon2", "willowisp1", "bonefetish5", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 27, 255, "Swampy Pit Level 2", "To The Swampy Pit Level 2", "A3L13", 66, 67, 62, 64, 72, 0, 0, 0, 80, 80, 35, 35, 35, 0, 0, 0),
			new BaseLevel("Act 3 - Dungeon 2 A", 88, 2, 2, -1, -1, 62, 200, 200, 200, 200, 200, 200, 2000, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 24, -1, -1, -1, -1, 89, 78, 0, 0, 0, 0, 0, 0, 56, 55, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 22, 47, 72, 22, 51, 81, 700, 700, 700, 0, 1, 3, 4, 5, 6, 1, 0, 3, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", -1, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 27, 255, "Flayer Dungeon Level 1", "To The Flayer Dungeon Level 1", "A3L14", 66, 67, 62, 64, 72, 0, 0, 0, 80, 80, 35, 35, 35, 0, 0, 0),
			new BaseLevel("Act 3 - Dungeon 2 B", 89, 2, 2, -1, -1, 63, 200, 200, 200, 200, 200, 200, 2000, 1900, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 24, -1, -1, -1, -1, 91, 88, 0, 0, 0, 0, 0, 0, 56, 55, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 22, 47, 72, 22, 51, 82, 700, 700, 700, 0, 1, 3, 4, 5, 5, 1, 0, 3, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", -1, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 27, 255, "Flayer Dungeon Level 2", "To The Flayer Dungeon Level 2", "A3L15", 66, 67, 62, 64, 72, 0, 0, 0, 80, 80, 35, 35, 35, 0, 0, 0),
			new BaseLevel("Act 3 - Dungeon 1 Treasure", 90, 2, 2, -1, -1, 64, 40, 40, 40, 40, 40, 40, 2000, 2200, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 24, -1, -1, -1, -1, 0, 87, 0, 0, 0, 0, 0, 0, -1, 55, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 21, 46, 71, 21, 51, 82, 700, 700, 700, 0, 1, 1, 2, 2, 3, 1, 0, 3, "bonefetish4", "bonefetish5", "batdemon2", "willowisp1", "", "", "", "", "", "", -1, "bonefetish4", "bonefetish5", "batdemon2", "willowisp1", "", "", "", "", "", "", "mosquito2", "bonefetish5", "batdemon2", "willowisp1", "", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 27, 255, "Swampy Pit Level 3", "To The Swampy Pit Level 3", "A3L16", 66, 67, 62, 64, 72, 0, 0, 0, 80, 80, 35, 35, 35, 0, 0, 0),
			new BaseLevel("Act 3 - Dungeon 2 Treasure", 91, 2, 2, -1, -1, 65, 40, 40, 40, 40, 40, 40, 2000, 2340, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 24, -1, -1, -1, -1, 0, 89, 0, 0, 0, 0, 0, 0, -1, 55, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 22, 47, 72, 22, 51, 83, 700, 700, 700, 0, 1, 1, 2, 2, 3, 1, 0, 3, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", -1, "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", "fetish3", "fetishshaman3", "fetish4", "fetishshaman4", "batdemon3", "wraith5", "fetishblow3", "bonefetish3", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 27, 255, "Flayer Dungeon Level 3", "To The Flayer Dungeon Level 3", "A3L17", 66, 67, 62, 64, 72, 0, 0, 0, 80, 55, 35, 35, 35, 0, 0, 0),
			new BaseLevel("Act 3 - Sewer 1", 92, 2, 2, -1, -1, 66, 200, 200, 200, 200, 200, 200, 2500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 25, -1, -1, -1, -1, 80, 80, 81, 81, 93, 0, 0, 0, 58, 59, 58, 59, 60, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 23, 48, 73, 23, 52, 84, 650, 650, 650, 1, 2, 3, 4, 6, 7, 1, 0, 3, "mummy4", "mosquito2", "batdemon3", "unraveler4", "bonefetish4", "", "", "", "", "", -1, "mummy4", "mosquito2", "batdemon3", "unraveler4", "bonefetish4", "", "", "", "", "", "mummy4", "mosquito2", "batdemon3", "unraveler4", "bonefetish4", "", "", "", "", "", "rat", "rat", "", "", 100, 100, -1, -1, -1, -1, -1, -1, 0, 26, 255, "Sewers Level 1", "To The Sewers Level 1", "A3L18", 64, 70, 62, 65, 0, 0, 0, 0, 50, 50, 35, 45, 45, 0, 0, 0),
			new BaseLevel("Act 3 - Sewer 2", 93, 2, 2, -1, -1, 67, 18, 22, 18, 22, 18, 22, 2500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 25, -1, -1, -1, -1, 92, 0, 0, 0, 0, 0, 0, 0, 58, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 24, 49, 74, 24, 53, 85, 650, 650, 650, 1, 2, 3, 4, 6, 7, 1, 0, 3, "mummy4", "unraveler4", "mosquito4", "frogdemon3", "bonefetish4", "", "", "", "", "", -1, "mummy4", "unraveler4", "mosquito4", "frogdemon3", "bonefetish4", "", "", "", "", "", "mummy4", "unraveler4", "mosquito4", "frogdemon3", "bonefetish4", "", "", "", "", "", "rat", "rat", "", "", 100, 100, -1, -1, -1, -1, -1, -1, 0, 26, 255, "Sewers Level 2", "To The Sewers Level 2", "A3L19", 64, 70, 62, 65, 0, 0, 0, 0, 50, 50, 35, 45, 45, 0, 0, 0),
			new BaseLevel("Act 3 - Temple 1", 94, 2, 2, -1, -1, 68, 24, 24, 24, 24, 24, 24, 3000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 22, -1, -1, -1, -1, 80, 80, 0, 0, 0, 0, 0, 0, 62, 63, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 23, 48, 73, 23, 53, 84, 990, 990, 990, 1, 2, 1, 2, 2, 2, 1, 0, 3, "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", -1, "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 28, 255, "Ruined Temple", "To The Ruined Temple", "A3L20", 60, 61, 59, 60, 0, 0, 0, 0, 50, 25, 45, 33, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Temple 2", 95, 2, 2, -1, -1, 69, 24, 24, 24, 24, 24, 24, 3000, 1124, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 22, -1, -1, -1, -1, 80, 80, 0, 0, 0, 0, 0, 0, 62, 63, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 23, 48, 73, 23, 53, 84, 990, 990, 990, 1, 2, 1, 2, 2, 2, 1, 0, 3, "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", -1, "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 28, 255, "Disused Fane", "To The Disused Fane", "A3L21", 60, 61, 59, 60, 0, 0, 0, 0, 50, 25, 45, 33, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Temple 3", 96, 2, 2, -1, -1, 70, 24, 24, 24, 24, 24, 24, 3000, 1248, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 22, -1, -1, -1, -1, 81, 81, 0, 0, 0, 0, 0, 0, 62, 63, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 23, 48, 73, 23, 53, 84, 990, 990, 990, 1, 2, 1, 2, 2, 2, 1, 0, 3, "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", -1, "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", "brute5", "corruptrogue5", "arach5", "vampire2", "", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 28, 255, "Forgotten Reliquary", "To The Forgotten Reliquary", "A3L22", 60, 61, 59, 60, 0, 0, 0, 0, 50, 25, 45, 33, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Temple 4", 97, 2, 2, -1, -1, 71, 24, 24, 24, 24, 24, 24, 3000, 1372, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 22, -1, -1, -1, -1, 81, 81, 0, 0, 0, 0, 0, 0, 62, 63, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 24, 49, 74, 24, 54, 85, 990, 990, 990, 1, 2, 1, 2, 2, 2, 1, 0, 3, "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", -1, "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 28, 255, "Forgotten Temple", "To The Forgotten Temple", "A3L23", 60, 61, 59, 60, 0, 0, 0, 0, 50, 25, 45, 33, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Temple 5", 98, 2, 2, -1, -1, 72, 24, 24, 24, 24, 24, 24, 3000, 1496, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 22, -1, -1, -1, -1, 82, 82, 0, 0, 0, 0, 0, 0, 62, 63, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 24, 49, 74, 24, 54, 85, 990, 990, 990, 1, 2, 1, 2, 2, 2, 1, 0, 3, "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", -1, "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 28, 255, "Ruined Fane", "To The Ruined Fane", "A3L24", 60, 61, 59, 60, 0, 0, 0, 0, 50, 25, 45, 33, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Temple 6", 99, 2, 2, -1, -1, 73, 24, 24, 24, 24, 24, 24, 3000, 1620, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 22, -1, -1, -1, -1, 82, 82, 0, 0, 0, 0, 0, 0, 62, 63, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 100, 24, 49, 74, 24, 54, 85, 990, 990, 990, 1, 2, 1, 2, 2, 2, 1, 0, 3, "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", -1, "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", "clawviper5", "scarab5", "batdemon4", "cr_archer5", "", "", "", "", "", "", "rat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 28, 255, "Disused Reliquary", "To The Disused Reliquary", "A3L25", 60, 61, 59, 60, 0, 0, 0, 0, 50, 25, 45, 33, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Mephisto 1", 100, 2, 2, 21, 21, 74, 200, 200, 200, 200, 200, 200, 3500, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 22, -1, -1, -1, -1, 101, 101, 83, 83, 0, 0, 0, 0, 67, 68, 65, 66, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 3800, 25, 50, 75, 25, 55, 83, 800, 800, 800, 1, 2, 3, 4, 5, 7, 1, 0, 3, "mummy5", "vampire3", "blunderbore3", "bonefetish5", "", "", "", "", "", "", -1, "mummy5", "vampire3", "blunderbore3", "bonefetish5", "", "", "", "", "", "", "mummy5", "vampire3", "blunderbore3", "bonefetish5", "", "", "", "", "", "", "bat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 30, 255, "Durance of Hate Level 1", "To The Durance of Hate Level 1", "A3L26", 60, 61, 59, 74, 0, 0, 0, 0, 50, 25, 45, 45, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Mephisto 2", 101, 2, 2, 21, 21, 75, 200, 200, 200, 200, 200, 200, 3500, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 22, -1, -1, -1, -1, 102, 102, 100, 100, 0, 0, 0, 0, 67, 68, 65, 66, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 3700, 25, 50, 75, 25, 55, 83, 800, 800, 800, 1, 2, 3, 4, 5, 7, 1, 0, 3, "mummy5", "vampire3", "blunderbore3", "bonefetish5", "", "", "", "", "", "", -1, "mummy5", "vampire3", "blunderbore3", "bonefetish5", "", "", "", "", "", "", "mummy5", "vampire3", "blunderbore3", "bonefetish5", "", "", "", "", "", "", "bat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 30, 26, "Durance of Hate Level 2", "To The Durance of Hate Level 2", "A3L27", 60, 61, 59, 74, 0, 0, 0, 0, 50, 25, 45, 45, 0, 0, 0, 0),
			new BaseLevel("Act 3 - Mephisto 3", 102, 2, 2, 21, 21, 76, 41, 29, 41, 29, 41, 29, 3500, 1600, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 2, 22, -1, -1, -1, -1, 0, 0, 101, 101, 0, 0, 0, 0, -1, -1, 65, 66, -1, -1, -1, -1, 0, 255, 255, 255, 0, 1, 1, 0, 3800, 25, 50, 75, 25, 55, 83, 800, 800, 800, 1, 2, 3, 4, 5, 7, 1, 0, 3, "vampire4", "vampire4", "", "", "", "", "", "", "", "", -1, "vampire4", "vampire4", "", "", "", "", "", "", "", "", "vampire4", "bonefetish5", "", "", "", "", "", "", "", "", "bat", "", "", "", 30, -1, -1, -1, -1, -1, -1, -1, 0, 30, 255, "Durance of Hate Level 3", "To The Durance of Hate Level 3", "A3L28", 60, 61, 59, 74, 0, 0, 0, 0, 50, 25, 45, 45, 0, 0, 0, 0),
			new BaseLevel("Act 4 - Town", 103, 3, 3, -1, -1, 77, 32, 24, 32, 24, 32, 24, 1000, 1000, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 2, 26, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 140, 255, 255, 255, 0, 1, 0, 0, 2025, 0, 25, 50, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 31, 27, "The Pandemonium Fortress", "To The Pandemonium Fortress", "A4L1", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 4 - Mesa 1", 104, 3, 3, -1, -1, 77, 80, 64, 80, 64, 80, 64, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 3, 27, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 120, 255, 255, 255, 0, 0, 1, 0, 3900, 26, 51, 76, 26, 56, 82, 800, 800, 800, 0, 1, 5, 6, 8, 10, 1, 0, 3, "sandleaper5", "vilemother1", "fingermage1", "regurgitator1", "doomknight1", "megademon3", "", "", "", "", -1, "sandleaper5", "vilemother1", "fingermage1", "regurgitator1", "doomknight1", "megademon3", "", "", "", "", "sandleaper5", "vilemother1", "fingermage1", "regurgitator1", "doomknight1", "megademon1", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 32, 255, "Outer Steppes", "To The Outer Steppes", "A4L2", 46, 47, 77, 0, 0, 0, 0, 0, 30, 80, 70, 0, 0, 0, 0, 0),
			new BaseLevel("Act 4 - Mesa 2", 105, 3, 3, -1, -1, 77, 64, 80, 64, 80, 64, 80, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 3, 27, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 80, 255, 255, 255, 0, 0, 1, 0, 2025, 26, 51, 76, 26, 56, 83, 800, 800, 800, 0, 1, 5, 6, 8, 10, 1, 0, 3, "willowisp3", "vilemother1", "fingermage1", "regurgitator1", "doomknight1", "megademon3", "", "", "", "", -1, "willowisp3", "vilemother1", "fingermage1", "regurgitator1", "doomknight1", "megademon3", "", "", "", "", "willowisp3", "vilemother1", "fingermage1", "regurgitator1", "doomknight1", "megademon2", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 32, 255, "Plains of Despair", "To The Plains of Despair", "A4L3", 46, 47, 77, 0, 0, 0, 0, 0, 30, 80, 70, 0, 0, 0, 0, 0),
			new BaseLevel("Act 4 - Mesa 3", 106, 3, 3, -1, -1, 77, 80, 64, 80, 64, 80, 64, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 3, 27, -1, -1, -1, -1, 0, 107, 0, 0, 0, 0, 0, 0, -1, 69, -1, -1, -1, -1, -1, -1, 40, 255, 255, 255, 0, 0, 1, 0, 2025, 27, 52, 77, 27, 57, 84, 800, 800, 800, 0, 1, 5, 6, 8, 10, 1, 0, 3, "bighead5", "batdemon5", "vilemother2", "fingermage2", "regurgitator2", "doomknight2", "megademon2", "", "", "", -1, "bighead5", "batdemon5", "vilemother2", "fingermage2", "regurgitator2", "doomknight2", "megademon2", "", "", "", "bighead5", "batdemon5", "vilemother2", "fingermage2", "regurgitator2", "doomknight2", "megademon2", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 32, 28, "City of the Damned", "To The City of the Damned", "A4L4", 46, 47, 77, 0, 0, 0, 0, 0, 30, 80, 70, 0, 0, 0, 0, 0),
			new BaseLevel("Act 4 - Lava 1", 107, 3, 3, -1, -1, 78, 200, 200, 200, 200, 200, 200, -1, -1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 28, -1, -1, -1, -1, 106, 108, 0, 0, 0, 0, 0, 0, 70, -1, -1, -1, -1, -1, -1, -1, 120, 255, 255, 255, 0, 0, 1, 0, 3800, 27, 52, 77, 27, 57, 85, 800, 800, 800, 0, 1, 4, 5, 6, 7, 1, 5, 3, "sandmaggot5", "blunderbore4", "vilemother3", "fingermage2", "regurgitator3", "doomknight2", "megademon2", "", "", "", -1, "sandmaggot5", "blunderbore4", "vilemother3", "fingermage2", "regurgitator3", "doomknight2", "megademon2", "", "", "", "sandmaggot5", "blunderbore4", "vilemother3", "fingermage2", "regurgitator3", "doomknight2", "megademon3", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 33, 29, "River of Flame", "To The River of Flame", "A4L5", 48, 49, 0, 0, 0, 0, 0, 0, 90, 60, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 4 - Diablo 1", 108, 3, 3, -1, -1, 78, 120, 120, 120, 120, 120, 120, 1500, 1000, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 3, 28, -1, -1, -1, -1, 107, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 80, 255, 255, 255, 0, 0, 1, 0, 2025, 28, 53, 78, 28, 58, 85, 800, 800, 800, 0, 1, 4, 5, 6, 7, 1, 0, 3, "fingermage3", "doomknight3", "megademon3", "", "", "", "", "", "", "", -1, "fingermage3", "doomknight3", "megademon3", "", "", "", "", "", "", "", "fingermage3", "doomknight3", "megademon3", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 34, 255, "Chaos Sanctum", "To Chaos Sanctum", "A4L6", 48, 49, 0, 0, 0, 0, 0, 0, 30, 50, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Town", 109, 4, 4, -1, -1, 79, 40, 40, 40, 40, 40, 40, 1000, 1000, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 2, 29, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 1, 0, 0, 2025, 0, 0, 0, -1, -1, -1, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 36, 30, "Harrogath", "To Harrogath", "A5L1", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Siege 1", 110, 4, 4, -1, -1, 79, 240, 48, 240, 48, 240, 48, 760, 1000, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 3, 30, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 24, 49, 74, 24, 58, 80, 0, 650, 650, 1, 2, 3, 5, 4, 6, 0, 0, 2, "minion1", "deathmauler1", "overseer1", "imp1", "sk_archer6", "quillrat6", "bighead6", "", "", "", 1, "minion1", "deathmauler1", "overseer1", "imp1", "sk_archer6", "quillrat6", "foulcrow5", "vulture5", "thornhulk5", "slinger7", "", "", "", "", "", "", "", "", "", "", "bunny", "", "", "", 3, -1, -1, -1, -1, -1, -1, -1, 0, 37, 255, "Bloody Foothills", "To The Bloody Foothills", "A5L2", 99, 100, 101, 102, 103, 104, 105, 106, 40, 25, 25, 25, 25, 25, 25, 25),
			new BaseLevel("Act 5 - Barricade 1", 111, 4, 4, -1, -1, 79, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 3, 31, 10, 1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 3900, 25, 50, 75, 25, 59, 81, 450, 450, 450, 1, 2, 6, 7, 9, 11, 0, 0, 3, "imp1", "siegebeast2", "", "", "", "", "", "", "", "", 1, "imp3", "siegebeast1", "minion2", "deathmauler2", "sk_archer6", "cr_archer6", "cr_lancer6", "slinger8", "blunderbore5", "overseer2", "imp2", "", "", "", "", "", "", "", "", "", "bunny", "", "", "", 2, -1, -1, -1, -1, -1, -1, -1, 0, 37, 31, "Rigid Highlands", "To The Rigid Highlands", "A5L3", 99, 100, 101, 102, 103, 104, 105, 106, 25, 25, 25, 25, 25, 25, 25, 25),
			new BaseLevel("Act 5 - Barricade 2", 112, 4, 4, -1, -1, 79, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 3, 31, 10, 1, -1, -1, 0, 0, 113, 0, 0, 0, 0, 0, -1, -1, 71, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 26, 51, 76, 26, 60, 81, 350, 350, 350, 1, 2, 6, 7, 9, 11, 0, 0, 3, "overseer2", "minion2", "", "", "", "", "", "", "", "", 1, "deathmauler3", "minion4", "siegebeast3", "overseer5", "imp3", "slinger9", "skmage_ltng5", "skmage_fire5", "goatman7", "fallenshaman6", "overseer2", "", "", "", "", "", "", "", "", "", "bunny", "", "", "", 2, -1, -1, -1, -1, -1, -1, -1, 0, 37, 32, "Arreat Plateau", "To The Arreat Plateau", "A5L4", 99, 100, 101, 102, 103, 104, 105, 106, 25, 25, 25, 26, 25, 25, 25, 25),
			new BaseLevel("Act 5 - Ice Cave 1", 113, 4, 4, -1, -1, 80, 200, 200, 200, 200, 200, 200, 2000, 1000, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 33, -1, -1, -1, -1, 112, 115, 114, 0, 0, 0, 0, 0, 73, 74, 75, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 29, 54, 79, 29, 61, 82, 700, 700, 700, 0, 1, 4, 5, 7, 9, 1, 0, 3, "frozenhorror1", "succubus3", "bloodlord1", "", "", "", "", "", "", "", 1, "snowyeti1", "frozenhorror1", "succubus1", "bloodlord3", "sandraider7", "sandleaper6", "skmage_cold5", "cr_archer7", "wraith6", "clawviper6", "snowyeti1", "bloodlord1", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 39, 33, "Crystalized Cavern Level 1", "To The Crystalized Cavern Level 1", "A5L7", 107, 108, 109, 123, 129, 110, 0, 0, 25, 25, 70, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Ice Cave 1A", 114, 4, 4, -1, -1, 81, 64, 64, 64, 64, 64, 64, 2000, 1300, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 33, -1, -1, -1, -1, 113, 0, 0, 0, 0, 0, 0, 0, 73, -1, -1, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 29, 54, 79, 29, 61, 83, 800, 800, 800, 0, 1, 3, 4, 6, 8, 1, 0, 3, "snowyeti2", "succubus5", "reanimatedhorde1", "", "", "", "", "", "", "", 1, "snowyeti1", "frozenhorror1", "succubus6", "reanimatedhorde1", "succubuswitch6", "willowisp5", "skmage_cold5", "cr_lancer7", "wraith6", "clawviper6", "frozenhorror2", "deathmauler3", "bloodlord1", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 39, 255, "Cellar of Pity", "To The Cellar of Pity", "A5L8", 107, 108, 109, 123, 129, 110, 0, 0, 25, 25, 70, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Ice Cave 2", 115, 4, 4, -1, -1, 82, 200, 200, 200, 200, 200, 200, 2000, 1464, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 33, -1, -1, -1, -1, 113, 117, 116, 0, 0, 0, 0, 0, 73, 74, 75, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 29, 54, 79, 29, 61, 83, 700, 700, 700, 0, 1, 4, 5, 7, 9, 1, 0, 3, "deathmauler3", "reanimatedhorde2", "frozenhorror2", "", "", "", "", "", "", "", 1, "snowyeti1", "frozenhorror1", "reanimatedhorde1", "skeleton6", "wraith7", "batdemon6", "skmage_cold5", "bloodlord6", "skeleton6", "clawviper7", "snowyeti2", "deathmauler3", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 40, 34, "Crystalized Cavern Level 2", "To The Crystalized Cavern Level 2", "A5L9", 107, 108, 109, 123, 129, 110, 0, 0, 25, 25, 70, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Ice Cave 2A", 116, 4, 4, -1, -1, 83, 32, 32, 32, 32, 32, 32, 2000, 1764, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 33, -1, -1, -1, -1, 115, 0, 0, 0, 0, 0, 0, 0, 73, -1, -1, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 29, 54, 79, 29, 61, 84, 600, 600, 600, 0, 1, 3, 4, 6, 8, 1, 0, 3, "snowyeti1", "succubus2", "", "", "", "", "", "", "", "", 1, "snowyeti2", "succubus6", "frozenhorror2", "bighead6", "goatman7", "cr_archer7", "skmage_cold5", "wraith6", "bloodlord6", "sandraider7", "succubus3", "frozenhorror3", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 40, 255, "Echo Chamber", "To The Echo Chamber", "A5L10", 107, 108, 109, 123, 129, 110, 0, 0, 25, 25, 70, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Barricade Snow", 117, 4, 4, -1, -1, 84, 128, 80, 128, 80, 128, 80, 2000, 1896, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 3, 31, 11, 1, -1, -1, 115, 0, 118, 0, 0, 0, 0, 0, 72, -1, 71, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 27, 52, 77, 27, 60, 81, 550, 550, 550, 2, 3, 4, 6, 9, 11, 0, 0, 3, "siegebeast2", "imp4", "", "", "", "", "", "", "", "", 1, "siegebeast2", "imp2", "deathmauler4", "minion5", "succubus5", "sk_archer7", "vulture5", "skmage_ltng5", "goatman10", "pantherwoman6", "imp4", "", "", "", "", "", "", "", "", "", "bunny", "", "", "", 2, -1, -1, -1, -1, -1, -1, -1, 0, 38, 36, "Tundra Wastelands", "To The Tundra Wastelands", "A5L5", 112, 111, 113, 114, 115, 129, 0, 0, 25, 25, 25, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Ice Cave 3", 118, 4, 4, -1, -1, 85, 200, 200, 200, 200, 200, 200, 2000, 2076, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 33, -1, -1, -1, -1, 117, 120, 119, 0, 0, 0, 0, 0, 73, 74, 75, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 29, 54, 79, 29, 62, 82, 650, 650, 650, 0, 1, 4, 5, 7, 9, 1, 0, 3, "frozenhorror3", "deathmauler3", "bloodlord1", "", "", "", "", "", "", "", 1, "frozenhorror2", "snowyeti2", "bloodlord7", "fallenshaman6", "quillrat7", "cr_lancer7", "skmage_cold5", "cr_lancer7", "reanimatedhorde2", "bighead6", "frozenhorror3", "succubus1", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 41, 37, "Glacial Caves Level 1", "To The Glacier Caves Level 1", "A5L11", 107, 108, 109, 123, 129, 110, 0, 0, 25, 25, 70, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Ice Cave 3A", 119, 4, 4, -1, -1, 86, 32, 32, 32, 32, 32, 32, 2000, 2376, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 33, -1, -1, -1, -1, 118, 0, 0, 0, 0, 0, 0, 0, 73, -1, -1, -1, -1, -1, -1, -1, 30, 255, 255, 255, 0, 0, 1, 0, 2025, 29, 54, 79, 29, 62, 83, 650, 650, 650, 0, 1, 3, 4, 6, 8, 1, 0, 3, "snowyeti4", "succubus3", "reanimatedhorde3", "", "", "", "", "", "", "", 1, "snowyeti2", "succubus4", "bloodlord7", "frozenhorror2", "clawviper7", "bonefetish5", "willowisp5", "batdemon6", "wraith6", "succubuswitch6", "succubus5", "deathmauler5", "snowyeti4", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 41, 255, "Glacial Caves Level 2", "To The Glacier Caves Level 2", "A5L12", 107, 108, 109, 123, 129, 110, 0, 0, 25, 25, 70, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Mountain Top", 120, 4, 4, -1, -1, 87, 20, 28, 20, 28, 20, 28, 2000, 2508, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 2, 31, -1, 1, -1, -1, 118, 128, 0, 0, 0, 0, 0, 0, 79, 80, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 27, 52, 77, 37, 68, 87, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, 3, "ancientbarb1", "ancientbarb2", "ancientbarb3", "", "", "", "", "", "", "", -1, "ancientbarb1", "ancientbarb2", "ancientbarb3", "", "", "", "", "", "", "", "ancientbarb1", "ancientbarb2", "ancientbarb3", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 42, 255, "Rocky Summit", "To The Rocky Summit", "A5L6", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Temple Entrance", 121, 4, 4, -1, -1, 88, 22, 27, 22, 27, 22, 27, 2000, 2636, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 2, 31, -1, -1, -1, -1, 0, 122, 0, 0, 0, 0, 0, 0, -1, 76, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 1, 1, 0, 2025, 32, 57, 82, 32, 63, 83, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 43, 255, "Nihlathaks Temple", "To Nihlathaks Temple", "A5L13", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Temple 1", 122, 4, 4, -1, -1, 89, 80, 80, 80, 80, 80, 80, 2000, 2763, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 32, -1, -1, -1, -1, 121, 123, 0, 0, 0, 0, 0, 0, 78, 77, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 3000, 33, 58, 83, 33, 63, 83, 700, 700, 700, 0, 0, 2, 3, 6, 7, 0, 0, 3, "reanimatedhorde3", "bloodlord2", "", "", "", "", "", "", "", "", -1, "reanimatedhorde3", "bloodlord2", "deathmauler5", "skeleton7", "sandleaper7", "fallenshaman7", "scarab6", "fetish6", "skmage_pois5", "baboon7", "reanimatedhorde2", "bloodlord2", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 44, 255, "Halls of Anguish", "To The Halls of Anguish", "A5L14", 116, 117, 118, 124, 125, 129, 128, 0, 30, 30, 30, 30, 40, 25, 30, 0),
			new BaseLevel("Act 5 - Temple 2", 123, 4, 4, -1, -1, 90, 80, 80, 80, 80, 80, 80, 2000, 2943, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 32, -1, -1, -1, -1, 122, 124, 0, 0, 0, 0, 0, 0, 78, 77, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 34, 59, 84, 34, 64, 84, 700, 700, 700, 0, 0, 2, 3, 6, 7, 0, 0, 3, "reanimatedhorde4", "deathmauler2", "putriddefiler1", "", "", "", "", "", "", "", 1, "bloodlord2", "sandraider7", "baboon8", "goatman9", "quillrat8", "unraveler6", "fetishblow6", "cantor5", "vilemother4", "sandmaggot6", "reanimatedhorde3", "deathmauler2", "baaltaunt", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 44, 35, "Halls of Death's Calling", "To The Halls of Death's Calling", "A5L15", 116, 117, 118, 124, 125, 129, 128, 0, 30, 30, 30, 30, 40, 25, 30, 0),
			new BaseLevel("Act 5 - Temple Boss", 124, 4, 4, -1, -1, 91, 84, 84, 84, 84, 84, 84, 2500, 1000, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 2, 32, -1, -1, -1, -1, 123, 0, 0, 0, 0, 0, 0, 0, 78, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 36, 61, 86, 36, 64, 84, 700, 700, 700, -1, -1, -1, -1, -1, -1, 0, 0, 3, "minion6", "succubus4", "putriddefiler2", "", "", "", "", "", "", "", 1, "minion9", "succubus4", "putriddefiler2", "reanimatedhorde3", "wraith6", "arach6", "sk_archer9", "fetishshaman6", "baboon6", "clawviper9", "minion6", "succubus4", "putriddefiler1", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 45, 255, "Halls of Vaught", "To The Halls of Vaught", "A5L17", 116, 117, 118, 124, 125, 129, 128, 0, 30, 30, 30, 30, 40, 25, 30, 0),
			new BaseLevel("Act 5 - Hell 1", 125, 3, 4, -1, -1, 92, 200, 200, 200, 200, 200, 200, 2500, 1184, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 35, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 120, 255, 255, 255, 0, 1, 1, 0, 3800, 39, 64, 89, 39, 60, 81, 800, 800, 800, 0, 1, 1, 2, 3, 4, 1, 0, 3, "bloodlord3", "imp2", "", "", "", "", "", "", "", "", 1, "bloodlord3", "imp6", "megademon4", "succubus7", "succubuswitch7", "fallenshaman8", "sk_archer10", "bonefetish6", "fingermage4", "minion10", "overseer2", "bloodlord4", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 46, 255, "Hell1", "To Hell1", "A5L23", 48, 49, 0, 0, 0, 0, 0, 0, 90, 60, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Hell 2", 126, 3, 4, -1, -1, 93, 200, 200, 200, 200, 200, 200, 2500, 1484, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 35, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 120, 255, 255, 255, 0, 1, 1, 0, 3800, 39, 64, 89, 39, 61, 82, 800, 800, 800, 0, 1, 1, 2, 3, 4, 1, 0, 3, "bloodlord2", "overseer3", "", "", "", "", "", "", "", "", 1, "bloodlord3", "imp6", "megademon4", "succubus7", "clawviper8", "blunderbore6", "unraveler7", "skmage_fire6", "goatman8", "regurgitator4", "overseer3", "bloodlord4", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 46, 255, "Hell2", "To Hell2", "A5L24", 48, 49, 0, 0, 0, 0, 0, 0, 90, 60, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Hell 3", 127, 3, 4, -1, -1, 94, 200, 200, 200, 200, 200, 200, 2500, 1784, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 35, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 120, 255, 255, 255, 0, 1, 1, 0, 3800, 39, 64, 89, 39, 62, 83, 700, 700, 700, 0, 1, 1, 2, 3, 4, 1, 0, 3, "imp4", "overseer4", "", "", "", "", "", "", "", "", 1, "imp7", "overseer4", "megademon4", "clawviper8", "bloodlord2", "succubuswitch5", "vampire6", "fetishblow7", "reanimatedhorde6", "dkmag1", "overseer4", "bloodlord5", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 46, 255, "Hell3", "To Hell3", "A5L25", 48, 49, 0, 0, 0, 0, 0, 0, 90, 60, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Baal Temple 1", 128, 4, 4, 39, 39, 95, 200, 200, 200, 200, 200, 200, 2500, 2084, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 34, -1, -1, -1, -1, 120, 129, 0, 0, 0, 0, 0, 0, 81, 82, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 39, 64, 89, 39, 65, 85, 700, 700, 700, 0, 0, 2, 3, 6, 8, 0, 0, 3, "reanimatedhorde5", "succubuswitch2", "putriddefiler3", "", "", "", "", "", "", "", 1, "reanimatedhorde6", "succubuswitch8", "putriddefiler3", "sandraider9", "bloodlord5", "cr_lancer8", "vilemother5", "cantor6", "vampire7", "fetishshaman8", "bloodlord3", "succubuswitch2", "putriddefiler2", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 47, 255, "The Worldstone Keep Level 1", "To The Worldstone Keep Level 1", "A5L18", 119, 120, 121, 122, 106, 129, 0, 0, 25, 25, 35, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Baal Temple 2", 129, 4, 4, 39, 39, 96, 200, 200, 200, 200, 200, 200, 2500, 2384, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 34, -1, -1, -1, -1, 128, 130, 0, 0, 0, 0, 0, 0, 81, 82, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 40, 65, 90, 40, 65, 85, 700, 700, 700, 0, 0, 2, 3, 6, 8, 0, 0, 3, "suicideminion6", "minion7", "", "", "", "", "", "", "", "", 1, "suicideminion6", "minion11", "fetish8", "batdemon7", "clawviper10", "mummy6", "skmage_pois6", "unraveler8", "scarab7", "willowisp6", "bloodlord4", "minion7", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 47, 38, "The Worldstone Keep Level 2", "To The Worldstone Keep Level 2", "A5L19", 119, 120, 121, 122, 129, 106, 0, 0, 25, 25, 35, 25, 26, 25, 0, 0),
			new BaseLevel("Act 5 - Baal Temple 3", 130, 4, 4, 39, 39, 97, 200, 200, 200, 200, 200, 200, 2500, 2684, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 34, -1, -1, -1, -1, 129, 131, 0, 0, 0, 0, 0, 0, 81, 82, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 42, 67, 92, 42, 66, 85, 700, 700, 700, 0, 0, 2, 3, 6, 8, 0, 0, 3, "bloodlord5", "imp5", "putriddefiler4", "", "", "", "", "", "", "", 1, "bloodlord5", "imp5", "putriddefiler4", "fingermage5", "dkmag2", "fetishblow8", "skmage_ltng6", "wraith8", "succubus4", "overseer4", "bloodlord5", "succubuswitch3", "putriddefiler3", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 47, 255, "The Worldstone Keep Level 3", "To The Worldstone Keep Level 3", "A5L20", 119, 120, 121, 122, 129, 106, 0, 0, 25, 25, 35, 25, 25, 25, 0, 0),
			new BaseLevel("Act 5 - Throne Room", 131, 4, 4, 39, 39, 98, 40, 52, 40, 52, 40, 52, 3000, 1000, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 2, 34, -1, -1, -1, -1, 130, 132, 0, 0, 0, 0, 0, 0, 81, 82, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 1000, 43, 68, 93, 43, 66, 85, 700, 700, 700, 0, 0, 1, 2, 4, 5, 0, 0, 3, "bloodlord5", "succubuswitch3", "", "", "", "", "", "", "", "", 1, "bloodlord5", "succubuswitch5", "bonefetish7", "sandraider10", "willowisp7", "vampire8", "megademon5", "unraveler9", "dkmag2", "clawviper10", "bloodlord5", "succubuswitch3", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 48, 255, "Throne of Destruction", "To The Throne of Destruction", "A5L21", 126, 127, 0, 0, 0, 0, 0, 0, 25, 25, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - World Stone", 132, 4, 4, 39, 39, 99, 55, 55, 55, 55, 55, 55, 3000, 1152, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 2, 34, -1, -1, -1, -1, 131, 0, 0, 0, 0, 0, 0, 0, 81, -1, -1, -1, -1, -1, -1, -1, 40, 255, 255, 255, 0, 1, 1, 0, 0, 0, 0, 0, 43, 66, 85, 0, 0, 0, -1, -1, -1, -1, -1, -1, 0, 0, -1, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 49, 255, "The Worldstone Chamber", "To The Worldstone Chamber", "A5L22", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Pandemonium 1", 133, 0, 4, -1, -1, 11, 200, 200, 200, 200, 200, 200, 4000, 1500, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 4, -1, -1, -1, -1, 17, 0, 0, 0, 0, 0, 0, 0, 8, -1, -1, -1, -1, -1, -1, -1, 0, 255, 255, 255, 0, 0, 1, 0, 2025, 50, 75, 83, 50, 75, 83, 1056, 1056, 1056, 1, 1, 3, 4, 4, 5, 1, 0, 3, "succubus8", "succubuswitch9", "corruptrogue6", "cr_archer8", "cr_lancer8", "", "", "", "", "", -1, "succubus8", "succubuswitch9", "corruptrogue6", "cr_archer8", "cr_lancer8", "", "", "", "", "", "succubus8", "succubuswitch9", "corruptrogue6", "cr_archer8", "cr_lancer8", "", "", "", "", "", "rat", "bat", "", "", 30, 30, -1, -1, -1, -1, -1, -1, 8, 5, 255, "Pandemonium Run 1", "To The Pandemonium Run 1", "A5L28", 7, 8, 9, 10, 0, 0, 0, 0, 75, 4, 50, 75, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Pandemonium 2", 134, 1, 4, -1, -1, 28, 80, 80, 80, 80, 80, 80, 4000, 1700, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 3, 16, 9, 4, 7, 8, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 40, 255, 255, 255, 1, 1, 1, 0, 3800, 50, 75, 83, 50, 75, 83, 880, 880, 880, -1, -1, 3, 4, 7, 9, 1, 0, 3, "swarm5", "sandmaggot7", "arach7", "scarab8", "", "", "", "", "", "", -1, "swarm5", "sandmaggot7", "arach7", "scarab8", "", "", "", "", "", "", "swarm5", "sandmaggot7", "arach7", "scarab8", "", "", "", "", "", "", "scorpion", "", "", "", 20, -1, -1, -1, -1, -1, -1, -1, 0, 14, 17, "Pandemonium Run 2", "To The Pandemonium Run 2", "A5L29", 30, 24, 32, 37, 36, 0, 0, 0, 15, 30, 10, 40, 40, 0, 0, 0),
			new BaseLevel("Act 5 - Pandemonium 3", 135, 3, 4, -1, -1, 92, 200, 200, 200, 200, 200, 200, 4000, 2884, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 35, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 120, 255, 255, 255, 0, 1, 1, 0, 3800, 50, 75, 83, 50, 75, 83, 800, 800, 800, 0, 1, 1, 2, 3, 4, 1, 0, 3, "overseer6", "dkmag3", "megademon6", "imp8", "", "", "", "", "", "", 1, "overseer6", "dkmag3", "megademon6", "imp8", "", "", "", "", "", "", "overseer6", "dkmag3", "megademon6", "imp8", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 46, 255, "Pandemonium Run 3", "To The Pandemonium Run 3", "A5L30", 48, 49, 0, 0, 0, 0, 0, 0, 90, 60, 0, 0, 0, 0, 0, 0),
			new BaseLevel("Act 5 - Pandemonium Finale", 136, 0, 4, -1, -1, 25, 43, 48, 43, 48, 43, 48, 5000, 1000, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 2, 11, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 0, 2025, 50, 75, 83, 50, 75, 83, 0, 0, 0, 3, 3, 3, 3, 3, 3, 0, 0, 0, "", "", "", "", "", "", "", "", "", "", -1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 255, "Tristram", "To Tristram", "A5L31", 44, 45, 0, 0, 0, 0, 0, 0, 0, 33, 1, 0, 0, 0, 0, 0)
		};
	}
}
