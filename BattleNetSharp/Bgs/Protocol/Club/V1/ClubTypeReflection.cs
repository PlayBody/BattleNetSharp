using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200050B RID: 1291
	public static class ClubTypeReflection
	{
		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x001EAF14 File Offset: 0x001E9114
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubTypeReflection.descriptor;
			}
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x001EAF2C File Offset: 0x001E912C
		static ClubTypeReflection()
		{
			byte[] array = Convert.FromBase64String("CiFiZ3MvbG93L3BiL2NsaWVudC9jbHViX3R5cGUucHJvdG8SFGJncy5wcm90" + "b2NvbC5jbHViLnYxIi8KDlVuaXF1ZUNsdWJUeXBlEg8KB3Byb2dyYW0YASAB" + "KAcSDAoEbmFtZRgCIAEoCQ==");
			ClubTypeReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(UniqueClubType), UniqueClubType.Parser, new string[] { "Program", "Name" }, null, null, null, null)
			}));
		}

		// Token: 0x0400395F RID: 14687
		private static FileDescriptor descriptor;
	}
}
