using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000386 RID: 902
	public static class RoleTypesReflection
	{
		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x0016263C File Offset: 0x0016083C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RoleTypesReflection.descriptor;
			}
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x00162654 File Offset: 0x00160854
		static RoleTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiJiZ3MvbG93L3BiL2NsaWVudC9yb2xlX3R5cGVzLnByb3RvEgxiZ3MucHJv", "dG9jb2wiwgEKBFJvbGUSCgoCaWQYASACKA0SDAoEbmFtZRgCIAIoCRIRCglw", "cml2aWxlZ2UYAyADKAkSGwoPYXNzaWduYWJsZV9yb2xlGAQgAygNQgIQARIQ", "CghyZXF1aXJlZBgFIAEoCBIOCgZ1bmlxdWUYBiABKAgSFwoPcmVsZWdhdGlv", "bl9yb2xlGAcgASgNEhkKDWtpY2thYmxlX3JvbGUYCSADKA1CAhABEhoKDnJl", "bW92YWJsZV9yb2xlGAogAygNQgIQASLGAQoJUm9sZVN0YXRlEgwKBG5hbWUY", "AiABKAkSGwoPYXNzaWduYWJsZV9yb2xlGAQgAygNQgIQARIQCghyZXF1aXJl", "ZBgFIAEoCBIOCgZ1bmlxdWUYBiABKAgSFwoPcmVsZWdhdGlvbl9yb2xlGAcg", "ASgNEhkKDWtpY2thYmxlX3JvbGUYCSADKA1CAhABEhoKDnJlbW92YWJsZV9y", "b2xlGAogAygNQgIQARIcChBtZW50aW9uYWJsZV9yb2xlGAsgAygNQgIQAUIC",
				"SAE="
			}));
			RoleTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Role), Role.Parser, new string[] { "Id", "Name", "Privilege", "AssignableRole", "Required", "Unique", "RelegationRole", "KickableRole", "RemovableRole" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RoleState), RoleState.Parser, new string[] { "Name", "AssignableRole", "Required", "Unique", "RelegationRole", "KickableRole", "RemovableRole", "MentionableRole" }, null, null, null, null)
			}));
		}

		// Token: 0x040029D1 RID: 10705
		private static FileDescriptor descriptor;
	}
}
