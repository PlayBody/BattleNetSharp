using System;

namespace D2Data
{
	// Token: 0x0200094E RID: 2382
	public class ItemTokens
	{
		// Token: 0x0600B974 RID: 47476 RVA: 0x0036563C File Offset: 0x0036383C
		public static string GetArmorWeightToken(int index)
		{
			bool flag = index < 0 || index <= ItemTokens.ArmorWeights.Length;
			if (flag)
			{
				throw new ArgumentException();
			}
			return ItemTokens.ArmorWeights[index];
		}

		// Token: 0x0600B975 RID: 47477 RVA: 0x00365674 File Offset: 0x00363874
		public static string GetArmorWeightToken(ArmorWeight type)
		{
			return ItemTokens.GetArmorWeightToken((int)type);
		}

		// Token: 0x04007339 RID: 29497
		public static readonly string[] ArmorWeights = new string[] { "lit", "med", "hvy" };
	}
}
