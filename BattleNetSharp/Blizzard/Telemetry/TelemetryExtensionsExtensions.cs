using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002DF RID: 735
	public static class TelemetryExtensionsExtensions
	{
		// Token: 0x04002297 RID: 8855
		public static readonly Extension<Google.Protobuf.Reflection.FileOptions, FileOptions> TelemetryFileOptions = new Extension<Google.Protobuf.Reflection.FileOptions, FileOptions>(77000, FieldCodec.ForMessage<FileOptions>(616002U, FileOptions.Parser));

		// Token: 0x04002298 RID: 8856
		public static readonly Extension<Google.Protobuf.Reflection.MessageOptions, MessageOptions> TelemetryMessageOptions = new Extension<Google.Protobuf.Reflection.MessageOptions, MessageOptions>(77000, FieldCodec.ForMessage<MessageOptions>(616002U, MessageOptions.Parser));

		// Token: 0x04002299 RID: 8857
		public static readonly Extension<Google.Protobuf.Reflection.MessageOptions, LogMessageOptions> TelemetryLogMessageOptions = new Extension<Google.Protobuf.Reflection.MessageOptions, LogMessageOptions>(77001, FieldCodec.ForMessage<LogMessageOptions>(616010U, LogMessageOptions.Parser));

		// Token: 0x0400229A RID: 8858
		public static readonly Extension<Google.Protobuf.Reflection.FieldOptions, FieldOptions> TelemetryFieldOptions = new Extension<Google.Protobuf.Reflection.FieldOptions, FieldOptions>(77000, FieldCodec.ForMessage<FieldOptions>(616002U, FieldOptions.Parser));

		// Token: 0x0400229B RID: 8859
		public static readonly Extension<Google.Protobuf.Reflection.FieldOptions, LogFieldOptions> TelemetryLogFieldOptions = new Extension<Google.Protobuf.Reflection.FieldOptions, LogFieldOptions>(77001, FieldCodec.ForMessage<LogFieldOptions>(616010U, LogFieldOptions.Parser));
	}
}
