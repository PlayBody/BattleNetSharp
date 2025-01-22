using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200032A RID: 810
	public static class CommonInventoryStateReflection
	{
		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x060054B9 RID: 21689 RVA: 0x001477C4 File Offset: 0x001459C4
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonInventoryStateReflection.descriptor;
			}
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x001477DC File Offset: 0x001459DC
		static CommonInventoryStateReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chxjb21tb25faW52ZW50b3J5X3N0YXRlLnByb3RvEiBCbGl6emFyZC5UZWxl", "bWV0cnkuRmVud2F5LkNsaWVudCLcBQoESXRlbRIKCgJpZBgBIAEoDRIRCglp", "dGVtX2NvZGUYAiABKAkSRAoHcXVhbGl0eRgDIAEoDjIuLkJsaXp6YXJkLlRl", "bGVtZXRyeS5GZW53YXkuQ2xpZW50Lkl0ZW0uUXVhbGl0eToDQW55EkkKCWNv", "bnRhaW5lchgEIAEoDjIwLkJsaXp6YXJkLlRlbGVtZXRyeS5GZW53YXkuQ2xp", "ZW50Lkl0ZW0uQ29udGFpbmVyOgROb25lElEKDWVxdWlwcGVkX3Nsb3QYBSAB", "KA4yMy5CbGl6emFyZC5UZWxlbWV0cnkuRmVud2F5LkNsaWVudC5JdGVtLkVx", "dWlwcGVkU2xvdDoFRW1wdHkidgoHUXVhbGl0eRIHCgNBbnkQABIHCgNMb3cQ", "ARIKCgZOb3JtYWwQAhIICgRIaWdoEAMSCQoFTWFnaWMQBBIHCgNTZXQQBRII", "CgRSYXJlEAYSCgoGVW5pcXVlEAcSCwoHQ3JhZnRlZBAIEgwKCFRlbXBlcmVk",
				"EAkikwEKCUNvbnRhaW5lchIICgROb25lEAASDAoIQmFja1BhY2sQARIICgRC", "ZWx0EAISCAoEQm9keRADEgwKCEhpcmVsaW5nEAQSEAoMUHJpdmF0ZVN0YXNo", "EAUSDwoLU2hhcmVkU3Rhc2gQBhITCg9UcmFuc21vZ3JpZnlCb3gQBxIUChBU", "cmFkZUludGVyYWN0aW9uEAgiwgEKDEVxdWlwcGVkU2xvdBIJCgVFbXB0eRAA", "EggKBEhlYWQQARIICgROZWNrEAISCQoFVG9yc28QAxIMCghSaWdodEFybRAE", "EgsKB0xlZnRBcm0QBRINCglSaWdodEhhbmQQBhIMCghMZWZ0SGFuZBAHEgkK", "BVdhaXN0EAgSCAoERmVldBAJEgoKBkdsb3ZlcxAKEhcKE1JpZ2h0QXJtQWx0", "ZXJuYXRpdmUQCxIWChJMZWZ0QXJtQWx0ZXJuYXRpdmUQDCKFAQoOSW52ZW50", "b3J5U3RhdGUSNQoFaXRlbXMYASADKAsyJi5CbGl6emFyZC5UZWxlbWV0cnku", "RmVud2F5LkNsaWVudC5JdGVtEhQKDGdvbGRfY2FycmllZBgCIAEoBBIRCgln",
				"b2xkX2JhbmsYAyABKAQSEwoLY2hhcm1fY291bnQYBCABKA0="
			}));
			CommonInventoryStateReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Item), Item.Parser, new string[] { "Id", "ItemCode", "Quality", "Container", "EquippedSlot" }, null, new Type[]
				{
					typeof(Item.Types.Quality),
					typeof(Item.Types.Container),
					typeof(Item.Types.EquippedSlot)
				}, null, null),
				new GeneratedClrTypeInfo(typeof(InventoryState), InventoryState.Parser, new string[] { "Items", "GoldCarried", "GoldBank", "CharmCount" }, null, null, null, null)
			}));
		}

		// Token: 0x04002680 RID: 9856
		private static FileDescriptor descriptor;
	}
}
