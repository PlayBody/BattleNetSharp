using System;

namespace Libs.GOAP
{
	// Token: 0x02000901 RID: 2305
	public static class GoapKeyDescription
	{
		// Token: 0x0600B827 RID: 47143 RVA: 0x002DCC44 File Offset: 0x002DAE44
		public static string ToString(GoapKey key, object state)
		{
			return key.ToString() + " : " + ((state != null) ? state.ToString() : null);
		}
	}
}
