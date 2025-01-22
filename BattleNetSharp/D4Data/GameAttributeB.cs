using System;

namespace D4Data
{
	// Token: 0x020008D0 RID: 2256
	public class GameAttributeB : GameAttribute
	{
		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600B646 RID: 46662 RVA: 0x002D4ED8 File Offset: 0x002D30D8
		public bool DefaultValue
		{
			get
			{
				return this._DefaultValue.Value != 0;
			}
		}

		// Token: 0x0600B647 RID: 46663 RVA: 0x002D4EF8 File Offset: 0x002D30F8
		public GameAttributeB()
		{
		}

		// Token: 0x0600B648 RID: 46664 RVA: 0x002D4F04 File Offset: 0x002D3104
		public GameAttributeB(int id, int defaultValue, int u3, int u4, int u5, string scriptA, string scriptB, string name, GameAttributeEncoding encodingType, byte u10, int min, int max, int bitCount)
			: base(id, defaultValue, u3, u4, u5, scriptA, scriptB, name, encodingType, u10, min, max, bitCount)
		{
		}
	}
}
