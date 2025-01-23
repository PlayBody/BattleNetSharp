using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
    // Ensure that FileOptions implements IExtendableMessage or use a wrapper
    public static class TelemetryExtensionsExtensions
    {
        // Use the correct type that implements IExtendableMessage<T>
        // This is assuming Blizzard.Telemetry.FileOptions should be extendable
        public static readonly Extension<FileOptions, FileOptions> TelemetryFileOptions =
            new(77000, FieldCodec.ForMessage<FileOptions>(616002U, FileOptions.Parser));

        public static readonly Extension<MessageOptions, MessageOptions> TelemetryMessageOptions =
            new(77000, FieldCodec.ForMessage<MessageOptions>(616002U, MessageOptions.Parser));

        public static readonly Extension<MessageOptions, LogMessageOptions> TelemetryLogMessageOptions =
            new(77001, FieldCodec.ForMessage<LogMessageOptions>(616010U, LogMessageOptions.Parser));

        public static readonly Extension<FieldOptions, FieldOptions> TelemetryFieldOptions =
            new(77000, FieldCodec.ForMessage<FieldOptions>(616002U, FieldOptions.Parser));

        public static readonly Extension<FieldOptions, LogFieldOptions> TelemetryLogFieldOptions =
            new(77001, FieldCodec.ForMessage<LogFieldOptions>(616010U, LogFieldOptions.Parser));
    }
}
