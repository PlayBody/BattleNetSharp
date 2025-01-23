using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
<<<<<<< HEAD
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
=======
    // Ensure that FileOptions implements IExtendableMessage or use a wrapper
    public static class TelemetryExtensionsExtensions
    {
        // Use the correct type that implements IExtendableMessage<T>
        // This is assuming Blizzard.Telemetry.FileOptions should be extendable
        public static readonly Extension<Google.Protobuf.Reflection.FileOptions, FileOptions> TelemetryFileOptions =
            new(77000, FieldCodec.ForMessage<FileOptions>(616002U, FileOptions.Parser));

        public static readonly Extension<Google.Protobuf.Reflection.MessageOptions, MessageOptions> TelemetryMessageOptions =
            new(77000, FieldCodec.ForMessage<MessageOptions>(616002U, MessageOptions.Parser));

        public static readonly Extension<Google.Protobuf.Reflection.MessageOptions, LogMessageOptions> TelemetryLogMessageOptions =
            new(77001, FieldCodec.ForMessage<LogMessageOptions>(616010U, LogMessageOptions.Parser));

        public static readonly Extension<Google.Protobuf.Reflection.FieldOptions, FieldOptions> TelemetryFieldOptions =
            new(77000, FieldCodec.ForMessage<FieldOptions>(616002U, FieldOptions.Parser));

        public static readonly Extension<Google.Protobuf.Reflection.FieldOptions, LogFieldOptions> TelemetryLogFieldOptions =
            new(77001, FieldCodec.ForMessage<LogFieldOptions>(616010U, LogFieldOptions.Parser));
    }
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
}
