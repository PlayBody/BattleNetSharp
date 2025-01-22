using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200035B RID: 859
	public static class EventViewTypesReflection
	{
		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x060058F5 RID: 22773 RVA: 0x00157E94 File Offset: 0x00156094
		public static FileDescriptor Descriptor
		{
			get
			{
				return EventViewTypesReflection.descriptor;
			}
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00157EAC File Offset: 0x001560AC
		static EventViewTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CihiZ3MvbG93L3BiL2NsaWVudC9ldmVudF92aWV3X3R5cGVzLnByb3RvEgxi", "Z3MucHJvdG9jb2wiiQEKD0dldEV2ZW50T3B0aW9ucxISCgpmZXRjaF9mcm9t", "GAEgASgEEhMKC2ZldGNoX3VudGlsGAIgASgEEhIKCm1heF9ldmVudHMYAyAB", "KA0SOQoFb3JkZXIYBCABKA4yGC5iZ3MucHJvdG9jb2wuRXZlbnRPcmRlcjoQ", "RVZFTlRfREVTQ0VORElORyI/CgpWaWV3TWFya2VyEhYKDmxhc3RfcmVhZF90", "aW1lGAEgASgEEhkKEWxhc3RfbWVzc2FnZV90aW1lGAIgASgEKjcKCkV2ZW50", "T3JkZXISFAoQRVZFTlRfREVTQ0VORElORxAAEhMKD0VWRU5UX0FTQ0VORElO", "RxAB" }));
			EventViewTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[] { typeof(EventOrder) }, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GetEventOptions), GetEventOptions.Parser, new string[] { "FetchFrom", "FetchUntil", "MaxEvents", "Order" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ViewMarker), ViewMarker.Parser, new string[] { "LastReadTime", "LastMessageTime" }, null, null, null, null)
			}));
		}

		// Token: 0x0400288E RID: 10382
		private static FileDescriptor descriptor;
	}
}
