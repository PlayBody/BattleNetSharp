using System;
using System.ComponentModel.DataAnnotations;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B24 RID: 2852
	public class Ladder
	{
		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600C014 RID: 49172 RVA: 0x004A224B File Offset: 0x004A044B
		// (set) Token: 0x0600C015 RID: 49173 RVA: 0x004A2253 File Offset: 0x004A0453
		[Key]
		public string Guid { get; set; }

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600C016 RID: 49174 RVA: 0x004A225C File Offset: 0x004A045C
		// (set) Token: 0x0600C017 RID: 49175 RVA: 0x004A2264 File Offset: 0x004A0464
		public string Email { get; set; }

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600C018 RID: 49176 RVA: 0x004A226D File Offset: 0x004A046D
		// (set) Token: 0x0600C019 RID: 49177 RVA: 0x004A2275 File Offset: 0x004A0475
		public string BattleTag { get; set; }

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600C01A RID: 49178 RVA: 0x004A227E File Offset: 0x004A047E
		// (set) Token: 0x0600C01B RID: 49179 RVA: 0x004A2286 File Offset: 0x004A0486
		public string CharacterName { get; set; }

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600C01C RID: 49180 RVA: 0x004A228F File Offset: 0x004A048F
		// (set) Token: 0x0600C01D RID: 49181 RVA: 0x004A2297 File Offset: 0x004A0497
		public string Class { get; set; }

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600C01E RID: 49182 RVA: 0x004A22A0 File Offset: 0x004A04A0
		// (set) Token: 0x0600C01F RID: 49183 RVA: 0x004A22A8 File Offset: 0x004A04A8
		public uint Level { get; set; }

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600C020 RID: 49184 RVA: 0x004A22B1 File Offset: 0x004A04B1
		// (set) Token: 0x0600C021 RID: 49185 RVA: 0x004A22B9 File Offset: 0x004A04B9
		public ulong Rank { get; set; }
	}
}
