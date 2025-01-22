using System;
using System.ComponentModel.DataAnnotations;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B21 RID: 2849
	public class Item
	{
		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600C004 RID: 49156 RVA: 0x004A1F43 File Offset: 0x004A0143
		// (set) Token: 0x0600C005 RID: 49157 RVA: 0x004A1F4B File Offset: 0x004A014B
		[Key]
		public string KeyInfo { get; set; }

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600C006 RID: 49158 RVA: 0x004A1F54 File Offset: 0x004A0154
		// (set) Token: 0x0600C007 RID: 49159 RVA: 0x004A1F5C File Offset: 0x004A015C
		public string Packet { get; set; }
	}
}
