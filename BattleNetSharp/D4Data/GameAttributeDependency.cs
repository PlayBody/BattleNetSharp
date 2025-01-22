using System;

namespace D4Data
{
	// Token: 0x020008C9 RID: 2249
	public class GameAttributeDependency
	{
		// Token: 0x0600B638 RID: 46648 RVA: 0x002C8084 File Offset: 0x002C6284
		public GameAttributeDependency(GameAttribute attribute, int? key, bool usesExplicitKey, bool isManualDependency)
		{
			this.Attribute = attribute;
			this.Key = key;
			this.UsesExplicitKey = usesExplicitKey;
			this.IsManualDependency = isManualDependency;
		}

		// Token: 0x04006537 RID: 25911
		public GameAttribute Attribute;

		// Token: 0x04006538 RID: 25912
		public int? Key;

		// Token: 0x04006539 RID: 25913
		public bool UsesExplicitKey;

		// Token: 0x0400653A RID: 25914
		public bool IsManualDependency;
	}
}
