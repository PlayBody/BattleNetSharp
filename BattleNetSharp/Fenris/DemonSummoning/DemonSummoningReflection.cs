using System;
using Fenris.Items;
using Google.Protobuf.Reflection;

namespace Fenris.DemonSummoning
{
	// Token: 0x020001FB RID: 507
	public static class DemonSummoningReflection
	{
		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x000DC334 File Offset: 0x000DA534
		public static FileDescriptor Descriptor
		{
			get
			{
				return DemonSummoningReflection.descriptor;
			}
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x000DC34C File Offset: 0x000DA54C
		static DemonSummoningReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChREZW1vblN1bW1vbmluZy5wcm90bxIVRmVucmlzLkRlbW9uU3VtbW9uaW5n", "GgtJdGVtcy5wcm90byKWAQoMU2Nyb2xsUml0dWFsEhcKD3Nub19zdGFydF9x", "dWVzdBgBIAEoBRIbChNzbm9fYWN0aXZpdHlfcXVlc3RzGAIgAygFEh0KFXNu", "b19jb21wbGV0aW9uX3F1ZXN0cxgDIAMoBRIXCg9zbm9fcml0dWFsX2l0ZW0Y", "BCABKAUSGAoQZ2JpZF9yaXR1YWxfaW5mbxgFIAEoDyK8AQoGU2Nyb2xsEhIK", "CnNub19zY3JvbGwYASABKAUSFAoMaXNfbmlnaHRtYXJlGAIgASgIEhAKCHNu", "b19ib3NzGAMgASgFEjQKB3JpdHVhbHMYBCADKAsyIy5GZW5yaXMuRGVtb25T", "dW1tb25pbmcuU2Nyb2xsUml0dWFsEigKB3Jld2FyZHMYBSADKAsyFy5GZW5y", "aXMuSXRlbXMuR2VuZXJhdG9yEhYKDnNub19ib3NzX3F1ZXN0GAYgASgFIj8K", "DkVxdWlwcGVkU2Nyb2xsEi0KBnNjcm9sbBgBIAEoCzIdLkZlbnJpcy5EZW1v",
				"blN1bW1vbmluZy5TY3JvbGw="
			}));
			DemonSummoningReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { ItemsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ScrollRitual), ScrollRitual.Parser, new string[] { "SnoStartQuest", "SnoActivityQuests", "SnoCompletionQuests", "SnoRitualItem", "GbidRitualInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Scroll), Scroll.Parser, new string[] { "SnoScroll", "IsNightmare", "SnoBoss", "Rituals", "Rewards", "SnoBossQuest" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EquippedScroll), EquippedScroll.Parser, new string[] { "Scroll" }, null, null, null, null)
			}));
		}

		// Token: 0x040019F6 RID: 6646
		private static FileDescriptor descriptor;
	}
}
