using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000301 RID: 769
	public static class ClientErrorReflection
	{
		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06005159 RID: 20825 RVA: 0x00139830 File Offset: 0x00137A30
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientErrorReflection.descriptor;
			}
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x00139848 File Offset: 0x00137A48
		static ClientErrorReflection()
		{
			byte[] array = Convert.FromBase64String("ChFDbGllbnRFcnJvci5wcm90bxIjQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJp" + "cy5DbGllbnQudjEiOAoLQ2xpZW50RXJyb3ISEgoKZXJyb3JfY29kZRgBIAEo" + "BRIVCg1lcnJvcl9jb250ZXh0GAIgASgJ");
			ClientErrorReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClientError), ClientError.Parser, new string[] { "ErrorCode", "ErrorContext" }, null, null, null, null)
			}));
		}

		// Token: 0x040024CC RID: 9420
		private static FileDescriptor descriptor;
	}
}
