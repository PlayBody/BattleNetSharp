using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000305 RID: 773
	public static class LoadingCompletedReflection
	{
		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06005223 RID: 21027 RVA: 0x0013D630 File Offset: 0x0013B830
		public static FileDescriptor Descriptor
		{
			get
			{
				return LoadingCompletedReflection.descriptor;
			}
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x0013D648 File Offset: 0x0013B848
		static LoadingCompletedReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChZMb2FkaW5nQ29tcGxldGVkLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnku", "RmVucmlzLkNsaWVudC52MSL1AgoQTG9hZGluZ0NvbXBsZXRlZBJbCg9zb3Vy", "Y2VfbG9jYXRpb24YASABKAsyQi5CbGl6emFyZC5UZWxlbWV0cnkuRmVucmlz", "LkNsaWVudC52MS5Mb2FkaW5nQ29tcGxldGVkLkxvY2F0aW9uSW5mbxJcChBj", "dXJyZW50X2xvY2F0aW9uGAIgASgLMkIuQmxpenphcmQuVGVsZW1ldHJ5LkZl", "bnJpcy5DbGllbnQudjEuTG9hZGluZ0NvbXBsZXRlZC5Mb2NhdGlvbkluZm8S", "FAoMbG9hZGluZ190aW1lGAMgASgCGo8BCgxMb2NhdGlvbkluZm8SEQoJbWFp", "bl9tZW51GAEgASgIEhEKCXdvcmxkX3NubxgCIAEoERISCgp3b3JsZF9uYW1l", "GAMgASgJEhEKCXNjZW5lX3NubxgEIAEoERISCgpzY2VuZV9uYW1lGAUgASgJ", "Eg4KBmdyaWRfeBgGIAEoBRIOCgZncmlkX3kYByABKAU=" }));
			LoadingCompletedReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LoadingCompleted), LoadingCompleted.Parser, new string[] { "SourceLocation", "CurrentLocation", "LoadingTime" }, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(LoadingCompleted.Types.LocationInfo), LoadingCompleted.Types.LocationInfo.Parser, new string[] { "MainMenu", "WorldSno", "WorldName", "SceneSno", "SceneName", "GridX", "GridY" }, null, null, null, null)
				})
			}));
		}

		// Token: 0x04002550 RID: 9552
		private static FileDescriptor descriptor;
	}
}
