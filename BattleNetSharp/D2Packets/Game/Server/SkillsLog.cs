using System;
using System.Collections.Generic;
using System.Linq;
using D2Data;

namespace D2Packets.Game.Server
{
	// Token: 0x02000A02 RID: 2562
	public class SkillsLog : Packet
	{
		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x00472695 File Offset: 0x00470895
		// (set) Token: 0x0600BB33 RID: 47923 RVA: 0x0047269D File Offset: 0x0047089D
		public Dictionary<SkillType, SkillsLog.SkillLevelAndBonus> SkillLevels { get; set; } = new Dictionary<SkillType, SkillsLog.SkillLevelAndBonus>();

		// Token: 0x17003921 RID: 14625
		public byte this[SkillType Skill]
		{
			get
			{
				bool flag = this.SkillLevels.ContainsKey(Skill);
				byte b;
				if (flag)
				{
					b = this.SkillLevels[Skill].TotalLevel;
				}
				else
				{
					bool flag2 = this.Skills.Count((SkillsLog.SkillLevel s) => s.Type == Skill) > 0;
					if (flag2)
					{
						this.SkillLevels[Skill] = new SkillsLog.SkillLevelAndBonus
						{
							Bonus = this.Skills.Find((SkillsLog.SkillLevel s) => s.Type == Skill).Level
						};
						b = this.SkillLevels[Skill].TotalLevel;
					}
					else
					{
						b = 0;
					}
				}
				return b;
			}
			set
			{
				bool flag = !this.SkillLevels.ContainsKey(Skill);
				if (flag)
				{
					this.SkillLevels.Add(Skill, new SkillsLog.SkillLevelAndBonus
					{
						Bonus = value
					});
				}
				else
				{
					this.SkillLevels[Skill].Bonus = value;
				}
			}
		}

		// Token: 0x04008BF5 RID: 35829
		public GameServerPacket PacketId;

		// Token: 0x04008BF6 RID: 35830
		public byte NumSkills;

		// Token: 0x04008BF7 RID: 35831
		public uint Id;

		// Token: 0x04008BF8 RID: 35832
		public List<SkillsLog.SkillLevel> Skills = new List<SkillsLog.SkillLevel>();

		// Token: 0x02001357 RID: 4951
		public class SkillLevel : Packet
		{
			// Token: 0x04009E4E RID: 40526
			public SkillType Type;

			// Token: 0x04009E4F RID: 40527
			public byte Level = 0;
		}

		// Token: 0x02001358 RID: 4952
		public class SkillLevelAndBonus
		{
			// Token: 0x17003972 RID: 14706
			// (get) Token: 0x0600DFC4 RID: 57284 RVA: 0x004C4934 File Offset: 0x004C2B34
			public byte TotalLevel
			{
				get
				{
					return this.Level + this.Bonus;
				}
			}

			// Token: 0x04009E50 RID: 40528
			public SkillType Type;

			// Token: 0x04009E51 RID: 40529
			public byte Level = 0;

			// Token: 0x04009E52 RID: 40530
			public byte Bonus = 0;
		}
	}
}
