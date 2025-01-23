using System;
using System.Collections.Generic;

namespace D2Data
{
	// Token: 0x02000955 RID: 2389
	public class Mercenary
	{
		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600B979 RID: 47481 RVA: 0x0036E548 File Offset: 0x0036C748
		public int Cost
		{
			get
			{
				return this.Hireling.Gold * (15 * (Math.Max(this.Level, this.Hireling.Level) - this.Hireling.Level) + 100) / 100;
			}
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x0036E594 File Offset: 0x0036C794
		public Mercenary(uint seed, uint id, uint diff, int charLevel)
		{
			List<hireling> hirelings = this.GetHirelings(id, diff);
			this.MercSeed = seed;
			Mercenary.Seed seed2 = new Mercenary.Seed(this.MercSeed);
			int num = (int)(seed2.RandomMax(4294967296UL) % (ulong)hirelings.Count);
			this.Level = (int)(seed2.RandomMax(4294967296UL) % 5UL) + charLevel - 5;
			this.Hireling = hirelings[num];
		}

		// Token: 0x0600B97B RID: 47483 RVA: 0x0036E60C File Offset: 0x0036C80C
		public int GetActFromId(uint name)
		{
			bool flag = name >= 3411U && name <= 3451U;
			int num;
			if (flag)
			{
				num = 1;
			}
			else
			{
				bool flag2 = name >= 1019U && name <= 1039U;
				if (flag2)
				{
					num = 2;
				}
				else
				{
					bool flag3 = name >= 1040U && name <= 1059U;
					if (flag3)
					{
						num = 3;
					}
					else
					{
						bool flag4 = name >= 10835U && name <= 10901U;
						if (flag4)
						{
							num = 5;
						}
						else
						{
							num = 0;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x0036E69C File Offset: 0x0036C89C
		public List<hireling> GetHirelings(uint id, uint diff)
		{
			List<hireling> list = new List<hireling>();
			int actFromId = this.GetActFromId(id);
			int num = 0;
			foreach (hireling hireling in hireling.hirelingList)
			{
				bool flag = hireling.Act == actFromId && (long)hireling.Difficulty == (long)((ulong)(diff + 1U)) && hireling.Version == 100;
				if (flag)
				{
					bool flag2 = num == 0 || hireling.Level == num;
					if (flag2)
					{
						list.Add(hireling);
						num = hireling.Level;
					}
				}
			}
			return list;
		}

		// Token: 0x04007B78 RID: 31608
		public uint MercSeed;

		// Token: 0x04007B79 RID: 31609
		public int Level;

		// Token: 0x04007B7A RID: 31610
		public hireling Hireling;

		// Token: 0x0200131D RID: 4893
		public class Seed
		{
			// Token: 0x17003971 RID: 14705
			// (get) Token: 0x0600DF24 RID: 57124 RVA: 0x004C38AC File Offset: 0x004C1AAC
			public ulong Value
			{
				get
				{
					return ((ulong)this.HiSeed << 32) + (ulong)this.LoSeed;
				}
			}

			// Token: 0x0600DF25 RID: 57125 RVA: 0x004C38D0 File Offset: 0x004C1AD0
			public Seed(uint mapSeed)
			{
				this.HiSeed = 666U;
				this.LoSeed = mapSeed;
			}

			// Token: 0x0600DF26 RID: 57126 RVA: 0x004C38EC File Offset: 0x004C1AEC
			public ulong Next()
			{
				ulong num = (ulong)this.LoSeed * 1791398085UL + (ulong)this.HiSeed;
				this.LoSeed = (uint)(num & (ulong)(0xFFFFFFFFFFFFFFFF));
				this.HiSeed = (uint)(num >> 32);
				return this.Value;
			}

			// Token: 0x0600DF27 RID: 57127 RVA: 0x004C3934 File Offset: 0x004C1B34
			public ulong RandomMax(ulong dwMax)
			{
				return this.Next() % dwMax;
			}

			// Token: 0x04009D62 RID: 40290
			public uint LoSeed;

			// Token: 0x04009D63 RID: 40291
			public uint HiSeed;
		}
	}
}
