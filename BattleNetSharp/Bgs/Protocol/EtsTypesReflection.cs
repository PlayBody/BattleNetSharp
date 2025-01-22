using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000359 RID: 857
	public static class EtsTypesReflection
	{
		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x00157958 File Offset: 0x00155B58
		public static FileDescriptor Descriptor
		{
			get
			{
				return EtsTypesReflection.descriptor;
			}
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00157970 File Offset: 0x00155B70
		static EtsTypesReflection()
		{
			byte[] array = Convert.FromBase64String("CiFiZ3MvbG93L3BiL2NsaWVudC9ldHNfdHlwZXMucHJvdG8SDGJncy5wcm90" + "b2NvbCIvCgxUaW1lU2VyaWVzSWQSDQoFZXBvY2gYASABKAQSEAoIcG9zaXRp" + "b24YAiABKAQ=");
			EtsTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(TimeSeriesId), TimeSeriesId.Parser, new string[] { "Epoch", "Position" }, null, null, null, null)
			}));
		}

		// Token: 0x04002884 RID: 10372
		private static FileDescriptor descriptor;
	}
}
