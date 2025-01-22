using System;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005DA RID: 1498
	public static class NotificationTypesReflection
	{
		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x06008D0F RID: 36111 RVA: 0x00223A84 File Offset: 0x00221C84
		public static FileDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.descriptor;
			}
		}

		// Token: 0x06008D10 RID: 36112 RVA: 0x00223A9C File Offset: 0x00221C9C
		static NotificationTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjhiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL25vdGlmaWNhdGlv", "bl90eXBlcy5wcm90bxIjYmdzLnByb3RvY29sLm5vdGlmaWNhdGlvbi52Mi5j", "bGllbnQaNWJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvYXR0cmli", "dXRlX3R5cGVzLnByb3RvGiViZ3MvbG93L3BiL2NsaWVudC9hY2NvdW50X3R5", "cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8i", "LwoPVXNlckRlc2NyaXB0aW9uEhwKCmFjY291bnRfaWQYASABKARCCIr5KwQS", "AhAAImIKBkZpbHRlchISCgh0aXRsZV9pZBgBIAEoDUgAEjwKBmhhbmRsZRgC", "IAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50SGFu", "ZGxlSABCBgoEdHlwZSLPAQoXU2VuZE5vdGlmaWNhdGlvbk9wdGlvbnMSIwoE", "dHlwZRgBIAEoCUIVivkrBiIECgIIAYr5KwciBQoDEIAEEiMKEXRhcmdldF9h",
				"Y2NvdW50X2lkGAIgASgEQgiK+SsEEgIQABI7CgZmaWx0ZXIYAyABKAsyKy5i", "Z3MucHJvdG9jb2wubm90aWZpY2F0aW9uLnYyLmNsaWVudC5GaWx0ZXISLQoJ", "YXR0cmlidXRlGAQgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZSKI", "AgoMTm90aWZpY2F0aW9uEiMKBHR5cGUYASABKAlCFYr5KwYiBAoCCAGK+SsH", "IgUKAxCABBJECgZzZW5kZXIYAiABKAsyNC5iZ3MucHJvdG9jb2wubm90aWZp", "Y2F0aW9uLnYyLmNsaWVudC5Vc2VyRGVzY3JpcHRpb24SRAoGdGFyZ2V0GAMg", "ASgLMjQuYmdzLnByb3RvY29sLm5vdGlmaWNhdGlvbi52Mi5jbGllbnQuVXNl", "ckRlc2NyaXB0aW9uEi0KCWF0dHJpYnV0ZRgEIAMoCzIaLmJncy5wcm90b2Nv", "bC52Mi5BdHRyaWJ1dGUSGAoQY3JlYXRpb25fdGltZV9tcxgFIAEoBA=="
			}));
			NotificationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(UserDescription), UserDescription.Parser, new string[] { "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Filter), Filter.Parser, new string[] { "TitleId", "Handle" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendNotificationOptions), SendNotificationOptions.Parser, new string[] { "Type", "TargetAccountId", "Filter", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Notification), Notification.Parser, new string[] { "Type", "Sender", "Target", "Attribute", "CreationTimeMs" }, null, null, null, null)
			}));
		}

		// Token: 0x04003FCA RID: 16330
		private static FileDescriptor descriptor;
	}
}
