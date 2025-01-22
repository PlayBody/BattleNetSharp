using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000303 RID: 771
	public static class ClientPerfReflection
	{
		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x00139D54 File Offset: 0x00137F54
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientPerfReflection.descriptor;
			}
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00139D6C File Offset: 0x00137F6C
		static ClientPerfReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChBDbGllbnRQZXJmLnByb3RvEiNCbGl6emFyZC5UZWxlbWV0cnkuRmVucmlz", "LkNsaWVudC52MSKXCAoKQ2xpZW50UGVyZhIRCgl3b3JsZF9zbm8YASABKBES", "EgoKd29ybGRfbmFtZRgCIAEoCRIRCglzY2VuZV9zbm8YAyABKBESEgoKc2Nl", "bmVfbmFtZRgEIAEoCRIOCgZncmlkX3gYBSABKAUSDgoGZ3JpZF95GAYgASgF", "EhUKDWF2ZXJhZ2VfZGVsdGEYByABKAISEQoJbWF4X2RlbHRhGAggASgCEhcK", "D2F2ZXJhZ2VfbW9uc3RlchgJIAEoAhITCgttYXhfbW9uc3RlchgKIAEoAhIT", "CgthdmVyYWdlX3BldBgLIAEoAhIPCgdtYXhfcGV0GAwgASgCEhYKDmF2ZXJh", "Z2VfcGxheWVyGA0gASgCEhIKCm1heF9wbGF5ZXIYDiABKAISFQoNYXZlcmFn", "ZV9hY3RvchgPIAEoAhIRCgltYXhfYWN0b3IYECABKAISGAoQYXZlcmFnZV9w", "YXJ0aWNsZRgRIAEoAhIUCgxtYXhfcGFydGljbGUYEiABKAISHwoXYXZlcmFn",
				"ZV9wYXJ0aWNsZV9zeXN0ZW0YEyABKAISGwoTbWF4X3BhcnRpY2xlX3N5c3Rl", "bRgUIAEoAhIfChdhdmVyYWdlX3Zpc2libGVfbW9uc3RlchgVIAEoAhIbChNt", "YXhfdmlzaWJsZV9tb25zdGVyGBYgASgCEhsKE2F2ZXJhZ2VfdmlzaWJsZV9w", "ZXQYFyABKAISFwoPbWF4X3Zpc2libGVfcGV0GBggASgCEh4KFmF2ZXJhZ2Vf", "dmlzaWJsZV9wbGF5ZXIYGSABKAISGgoSbWF4X3Zpc2libGVfcGxheWVyGBog", "ASgCEh0KFWF2ZXJhZ2VfdmlzaWJsZV9hY3RvchgbIAEoAhIZChFtYXhfdmlz", "aWJsZV9hY3RvchgcIAEoAhIgChhhdmVyYWdlX3Zpc2libGVfcGFydGljbGUY", "HSABKAISHAoUbWF4X3Zpc2libGVfcGFydGljbGUYHiABKAISJwofYXZlcmFn", "ZV92aXNpYmxlX3BhcnRpY2xlX3N5c3RlbRgfIAEoAhIjChttYXhfdmlzaWJs", "ZV9wYXJ0aWNsZV9zeXN0ZW0YICABKAISIwobbWF4X2NwdV9jYWNoZV9yZXF1",
				"aXJlZF9zaXplGCEgASgDEiMKG21heF9ncHVfY2FjaGVfcmVxdWlyZWRfc2l6", "ZRgiIAEoAxIfChdtYXhfbWFpbl9oZWFwX3VzZWRfc2l6ZRgjIAEoAxIgChht", "YXhfc21hbGxfaGVhcF91c2VkX3NpemUYJCABKAMSIAoYYXZlcmFnZV9yZXNv", "bHV0aW9uX3NjYWxlGCUgASgCEiAKGG1pbmltdW1fcmVzb2x1dGlvbl9zY2Fs", "ZRgmIAEoAhIQCghod19jbGFzcxgnIAEoCQ=="
			}));
			ClientPerfReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClientPerf), ClientPerf.Parser, new string[]
				{
					"WorldSno", "WorldName", "SceneSno", "SceneName", "GridX", "GridY", "AverageDelta", "MaxDelta", "AverageMonster", "MaxMonster",
					"AveragePet", "MaxPet", "AveragePlayer", "MaxPlayer", "AverageActor", "MaxActor", "AverageParticle", "MaxParticle", "AverageParticleSystem", "MaxParticleSystem",
					"AverageVisibleMonster", "MaxVisibleMonster", "AverageVisiblePet", "MaxVisiblePet", "AverageVisiblePlayer", "MaxVisiblePlayer", "AverageVisibleActor", "MaxVisibleActor", "AverageVisibleParticle", "MaxVisibleParticle",
					"AverageVisibleParticleSystem", "MaxVisibleParticleSystem", "MaxCpuCacheRequiredSize", "MaxGpuCacheRequiredSize", "MaxMainHeapUsedSize", "MaxSmallHeapUsedSize", "AverageResolutionScale", "MinimumResolutionScale", "HwClass"
				}, null, null, null, null)
			}));
		}

		// Token: 0x040024D6 RID: 9430
		private static FileDescriptor descriptor;
	}
}
