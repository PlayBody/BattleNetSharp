using System;

namespace D4Data
{
	// Token: 0x020008CE RID: 2254
	public class GameAttributeI : GameAttribute
	{
		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600B640 RID: 46656 RVA: 0x002D4E30 File Offset: 0x002D3030
		public int DefaultValue
		{
			get
			{
				return this._DefaultValue.Value;
			}
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x002D4E4D File Offset: 0x002D304D
		public GameAttributeI()
		{
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x002D4E58 File Offset: 0x002D3058
		public GameAttributeI(int id, int defaultValue, int u3, int u4, int u5, string scriptA, string scriptB, string name, GameAttributeEncoding encodingType, byte u10, int min, int max, int bitCount)
			: base(id, defaultValue, u3, u4, u5, scriptA, scriptB, name, encodingType, u10, min, max, bitCount)
		{
		}
	}
}
