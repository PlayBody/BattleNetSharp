using System;

namespace D4Data
{
	// Token: 0x020008CF RID: 2255
	public class GameAttributeF : GameAttribute
	{
		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600B643 RID: 46659 RVA: 0x002D4E84 File Offset: 0x002D3084
		public float DefaultValue
		{
			get
			{
				return this._DefaultValue.ValueF;
			}
		}

		// Token: 0x0600B644 RID: 46660 RVA: 0x002D4EA1 File Offset: 0x002D30A1
		public GameAttributeF()
		{
		}

		// Token: 0x0600B645 RID: 46661 RVA: 0x002D4EAC File Offset: 0x002D30AC
		public GameAttributeF(int id, float defaultValue, int u3, int u4, int u5, string scriptA, string scriptB, string name, GameAttributeEncoding encodingType, byte u10, float min, float max, int bitCount)
			: base(id, defaultValue, u3, u4, u5, scriptA, scriptB, name, encodingType, u10, min, max, bitCount)
		{
		}
	}
}
