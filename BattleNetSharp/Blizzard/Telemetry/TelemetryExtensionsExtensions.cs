using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002DF RID: 735
	public static class TelemetryExtensionsExtensions
	{
		// Token: 0x04002297 RID: 8855
		public static readonly Extension<FileOptions, FileOptions> TelemetryFileOptions = new Extension<FileOptions, FileOptions>(77000, FieldCodec.ForMessage<FileOptions>(616002U, FileOptions.Parser));

		// Token: 0x04002298 RID: 8856
		public static readonly Extension<MessageOptions, MessageOptions> TelemetryMessageOptions = new Extension<MessageOptions, MessageOptions>(77000, FieldCodec.ForMessage<MessageOptions>(616002U, MessageOptions.Parser));

		// Token: 0x04002299 RID: 8857
		public static readonly Extension<MessageOptions, LogMessageOptions> TelemetryLogMessageOptions = new Extension<MessageOptions, LogMessageOptions>(77001, FieldCodec.ForMessage<LogMessageOptions>(616010U, LogMessageOptions.Parser));

		// Token: 0x0400229A RID: 8858
		public static readonly Extension<FieldOptions, FieldOptions> TelemetryFieldOptions = new Extension<FieldOptions, FieldOptions>(77000, FieldCodec.ForMessage<FieldOptions>(616002U, FieldOptions.Parser));

		// Token: 0x0400229B RID: 8859
		public static readonly Extension<FieldOptions, LogFieldOptions> TelemetryLogFieldOptions = new Extension<FieldOptions, LogFieldOptions>(77001, FieldCodec.ForMessage<LogFieldOptions>(616010U, LogFieldOptions.Parser));
	}
}
