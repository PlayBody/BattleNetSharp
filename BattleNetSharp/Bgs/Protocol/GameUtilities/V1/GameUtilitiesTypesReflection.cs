using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005EE RID: 1518
	public static class GameUtilitiesTypesReflection
	{
		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x06008E9F RID: 36511 RVA: 0x00229D40 File Offset: 0x00227F40
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesTypesReflection.descriptor;
			}
		}

		// Token: 0x06008EA0 RID: 36512 RVA: 0x00229D58 File Offset: 0x00227F58
		static GameUtilitiesTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CixiZ3MvbG93L3BiL2NsaWVudC9nYW1lX3V0aWxpdGllc190eXBlcy5wcm90", "bxIeYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYxGidiZ3MvbG93L3Bi", "L2NsaWVudC9hdHRyaWJ1dGVfdHlwZXMucHJvdG8aJGJncy9sb3cvcGIvY2xp", "ZW50L2VudGl0eV90eXBlcy5wcm90byJ3Cg9QbGF5ZXJWYXJpYWJsZXMSKAoI", "aWRlbnRpdHkYASACKAsyFi5iZ3MucHJvdG9jb2wuSWRlbnRpdHkSDgoGcmF0", "aW5nGAIgASgBEioKCWF0dHJpYnV0ZRgDIAMoCzIXLmJncy5wcm90b2NvbC5B", "dHRyaWJ1dGUiQAoKQ2xpZW50SW5mbxIWCg5jbGllbnRfYWRkcmVzcxgBIAEo", "CRIaChJwcml2aWxlZ2VkX25ldHdvcmsYAiABKAhCPAofYm5ldC5wcm90b2Nv", "bC5nYW1lX3V0aWxpdGllcy52MUIXR2FtZVV0aWxpdGllc1R5cGVzUHJvdG9I", "AQ==" }));
			GameUtilitiesTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(PlayerVariables), PlayerVariables.Parser, new string[] { "Identity", "Rating", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClientInfo), ClientInfo.Parser, new string[] { "ClientAddress", "PrivilegedNetwork" }, null, null, null, null)
			}));
		}

		// Token: 0x04004074 RID: 16500
		private static FileDescriptor descriptor;
	}
}
