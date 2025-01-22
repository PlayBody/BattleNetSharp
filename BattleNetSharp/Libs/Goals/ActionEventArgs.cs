using System;
using Libs.GOAP;

namespace Libs.Goals
{
	// Token: 0x02000907 RID: 2311
	public class ActionEventArgs : EventArgs
	{
		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600B840 RID: 47168 RVA: 0x002DD4A4 File Offset: 0x002DB6A4
		// (set) Token: 0x0600B841 RID: 47169 RVA: 0x002DD4AC File Offset: 0x002DB6AC
		public GoapKey Key { get; private set; }

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600B842 RID: 47170 RVA: 0x002DD4B5 File Offset: 0x002DB6B5
		// (set) Token: 0x0600B843 RID: 47171 RVA: 0x002DD4BD File Offset: 0x002DB6BD
		public object Value { get; private set; }

		// Token: 0x0600B844 RID: 47172 RVA: 0x002DD4C6 File Offset: 0x002DB6C6
		public ActionEventArgs(GoapKey key, object value)
		{
			this.Key = key;
			this.Value = value;
		}
	}
}
