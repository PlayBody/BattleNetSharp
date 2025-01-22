using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.LimitedTimeEvent
{
	// Token: 0x02000780 RID: 1920
	public static class LimitedTimeEventReflection
	{
		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600B064 RID: 45156 RVA: 0x002AEFA0 File Offset: 0x002AD1A0
		public static FileDescriptor Descriptor
		{
			get
			{
				return LimitedTimeEventReflection.descriptor;
			}
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x002AEFB8 File Offset: 0x002AD1B8
		static LimitedTimeEventReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChxiZ3MvbGltaXRlZF90aW1lX2V2ZW50LnByb3RvEi9jbGFzc2ljLnByb3Rv", "Y29sLmV4dGVybmFsLnYxLmxpbWl0ZWRfdGltZV9ldmVudBohYmdzL2xvdy9w", "Yi9jbGllbnQvcnBjX3R5cGVzLnByb3RvMngKEExpbWl0ZWRUaW1lRXZlbnQS", "UgoZU2V0TGltaXRlZFRpbWVFdmVudFN0YXR1cxIULmJncy5wcm90b2NvbC5O", "b0RhdGEaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgmC+SsFCLPDq30aEIL5KwwK", "CjB4RkM4Q0JFNzA=" }));
			LimitedTimeEventReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, null));
		}

		// Token: 0x04004F94 RID: 20372
		private static FileDescriptor descriptor;
	}
}
