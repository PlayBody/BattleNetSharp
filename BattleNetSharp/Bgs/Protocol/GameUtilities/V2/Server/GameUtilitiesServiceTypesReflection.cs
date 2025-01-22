using System;
using Bgs.Protocol.Account.V2;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F9 RID: 1529
	public static class GameUtilitiesServiceTypesReflection
	{
		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x06008F4B RID: 36683 RVA: 0x0022C344 File Offset: 0x0022A544
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceTypesReflection.descriptor;
			}
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x0022C35C File Offset: 0x0022A55C
		static GameUtilitiesServiceTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CkJiZ3MvbG93L3BiL2NsaWVudC9hcGkvc2VydmVyL3YyL2dhbWVfdXRpbGl0", "aWVzX3NlcnZpY2VfdHlwZXMucHJvdG8SJWJncy5wcm90b2NvbC5nYW1lX3V0", "aWxpdGllcy52Mi5zZXJ2ZXIaIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBl", "cy5wcm90bxozYmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9hY2Nv", "dW50X3R5cGVzLnByb3RvGjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50", "L3YyL2F0dHJpYnV0ZV90eXBlcy5wcm90byJxCgpDbGllbnRJbmZvEhYKDmNs", "aWVudF9hZGRyZXNzGAEgASgJEhoKEnByaXZpbGVnZWRfbmV0d29yaxgCIAEo", "CBIvCgR1c2VyGAMgASgLMiEuYmdzLnByb3RvY29sLmFjY291bnQudjIuSWRl", "bnRpdHkiiAEKDFJlZ2lzdHJhdGlvbhIXCg9yZWdpc3RyYXRpb25faWQYASAB", "KAkSLQoJYXR0cmlidXRlGAIgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJp",
				"YnV0ZRIXCg9jcmVhdGlvbl90aW1lX3MYAyABKAQSFwoPbW9kaWZpZWRfdGlt", "ZV9zGAQgASgEIj8KHEdldFJlZ2lzdHJhdGlvbnNDb250aW51YXRpb24SDQoF", "dG9rZW4YASABKAQSEAoIcG9zaXRpb24YAiABKAkiYAoXR2V0UmVnaXN0cmF0", "aW9uc09wdGlvbnMSMAoGZmlsdGVyGAEgASgLMiAuYmdzLnByb3RvY29sLnYy", "LkF0dHJpYnV0ZUZpbHRlchITCgttYXhfc2VydmVycxgCIAEoDUIDgAEA"
			}));
			GameUtilitiesServiceTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClientInfo), ClientInfo.Parser, new string[] { "ClientAddress", "PrivilegedNetwork", "User" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Registration), Registration.Parser, new string[] { "RegistrationId", "Attribute", "CreationTimeS", "ModifiedTimeS" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRegistrationsContinuation), GetRegistrationsContinuation.Parser, new string[] { "Token", "Position" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetRegistrationsOptions), GetRegistrationsOptions.Parser, new string[] { "Filter", "MaxServers" }, null, null, null, null)
			}));
		}

		// Token: 0x040040BD RID: 16573
		private static FileDescriptor descriptor;
	}
}
