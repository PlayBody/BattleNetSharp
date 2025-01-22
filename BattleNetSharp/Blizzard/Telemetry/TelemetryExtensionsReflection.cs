using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002DE RID: 734
	public static class TelemetryExtensionsReflection
	{
		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x00128CB0 File Offset: 0x00126EB0
		public static FileDescriptor Descriptor
		{
			get
			{
				return TelemetryExtensionsReflection.descriptor;
			}
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00128CC8 File Offset: 0x00126EC8
		static TelemetryExtensionsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chp0ZWxlbWV0cnlfZXh0ZW5zaW9ucy5wcm90bxISQmxpenphcmQuVGVsZW1l", "dHJ5GiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90byIoCgtGaWxl", "T3B0aW9ucxIZChF0ZWxlbWV0cnlfbWVzc2FnZRgBIAEoCSKuAQoOTWVzc2Fn", "ZU9wdGlvbnMSEAoIcmVhbHRpbWUYZCABKAgSEQoIbG9uZ3Rlcm0YlgEgASgI", "EhMKCm1ldHJpY19zZXQYyAEgASgIEg8KBm1ldHJpYxjJASABKAgSGwoSZW50", "aXR5X3RpbWVfc2VyaWVzGK0CIAEoCBIQCgdsb2dnaW5nGJEDIAEoCBIUCgth", "dHRyaWJ1dGlvbhj1AyABKAkSDAoDY3JtGNkEIAEoCSIyChFMb2dNZXNzYWdl", "T3B0aW9ucxIMCgRncm9rGAEgASgJEg8KB2lzX2pzb24YAiABKAgihQEKDEZp", "ZWxkT3B0aW9ucxITCgttYXBwZWRfdHlwZRgBIAEoCRIYChBlbGFzdGljX2Fu", "YWx5emVyGGQgASgJEhEKCHJlYWx0aW1lGMgBIAEoCBIaChFlbGFzdGljX3Bh",
				"dGhfbW92ZRisAiABKAkSFwoOY3JtX2ZpZWxkX25hbWUYkAMgASgJIicKD0xv", "Z0ZpZWxkT3B0aW9ucxIUCgxzeXNsb2dfZmllbGQYASABKAk6XQoUVGVsZW1l", "dHJ5RmlsZU9wdGlvbnMSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMY", "yNkEIAEoCzIfLkJsaXp6YXJkLlRlbGVtZXRyeS5GaWxlT3B0aW9uczpmChdU", "ZWxlbWV0cnlNZXNzYWdlT3B0aW9ucxIfLmdvb2dsZS5wcm90b2J1Zi5NZXNz", "YWdlT3B0aW9ucxjI2QQgASgLMiIuQmxpenphcmQuVGVsZW1ldHJ5Lk1lc3Nh", "Z2VPcHRpb25zOmwKGlRlbGVtZXRyeUxvZ01lc3NhZ2VPcHRpb25zEh8uZ29v", "Z2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGMnZBCABKAsyJS5CbGl6emFy", "ZC5UZWxlbWV0cnkuTG9nTWVzc2FnZU9wdGlvbnM6YAoVVGVsZW1ldHJ5Rmll", "bGRPcHRpb25zEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxjI2QQg",
				"ASgLMiAuQmxpenphcmQuVGVsZW1ldHJ5LkZpZWxkT3B0aW9uczpmChhUZWxl", "bWV0cnlMb2dGaWVsZE9wdGlvbnMSHS5nb29nbGUucHJvdG9idWYuRmllbGRP", "cHRpb25zGMnZBCABKAsyIy5CbGl6emFyZC5UZWxlbWV0cnkuTG9nRmllbGRP", "cHRpb25zQiAKHGNvbS5ibGl6emFyZC50ZWxlbWV0cnkucHJvdG9QAQ=="
			}));
			TelemetryExtensionsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { DescriptorReflection.Descriptor }, new GeneratedClrTypeInfo(null, new Extension[]
			{
				TelemetryExtensionsExtensions.TelemetryFileOptions,
				TelemetryExtensionsExtensions.TelemetryMessageOptions,
				TelemetryExtensionsExtensions.TelemetryLogMessageOptions,
				TelemetryExtensionsExtensions.TelemetryFieldOptions,
				TelemetryExtensionsExtensions.TelemetryLogFieldOptions
			}, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(FileOptions), FileOptions.Parser, new string[] { "TelemetryMessage" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MessageOptions), MessageOptions.Parser, new string[] { "Realtime", "Longterm", "MetricSet", "Metric", "EntityTimeSeries", "Logging", "Attribution", "Crm" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogMessageOptions), LogMessageOptions.Parser, new string[] { "Grok", "IsJson" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FieldOptions), FieldOptions.Parser, new string[] { "MappedType", "ElasticAnalyzer", "Realtime", "ElasticPathMove", "CrmFieldName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogFieldOptions), LogFieldOptions.Parser, new string[] { "SyslogField" }, null, null, null, null)
			}));
		}

		// Token: 0x04002296 RID: 8854
		private static FileDescriptor descriptor;
	}
}
