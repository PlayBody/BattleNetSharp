using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000594 RID: 1428
	public static class PublicationTypesReflection
	{
		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600885B RID: 34907 RVA: 0x00211EA8 File Offset: 0x002100A8
		public static FileDescriptor Descriptor
		{
			get
			{
				return PublicationTypesReflection.descriptor;
			}
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x00211EC0 File Offset: 0x002100C0
		static PublicationTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjdiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3B1YmxpY2F0aW9u", "X3R5cGVzLnByb3RvEiJiZ3MucHJvdG9jb2wucHVibGljYXRpb24udjIuY2xp", "ZW50GjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F0dHJpYnV0", "ZV90eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnBy", "b3RvIi4KBlRhcmdldBISCgp0b3BpY19uYW1lGAEgASgJEhAKCGlkZW50aXR5", "GAIgASgJIhoKBkZpbHRlchIQCgh0aXRsZV9pZBgBIAEoDSISChBTdWJzY3Jp", "YmVPcHRpb25zIl0KD1N1YnNjcmliZVJlc3VsdBI6CgZ0YXJnZXQYASABKAsy", "Ki5iZ3MucHJvdG9jb2wucHVibGljYXRpb24udjIuY2xpZW50LlRhcmdldBIO", "CgZzdGF0dXMYAiABKA0ijgEKB0FydGljbGUSOgoGdGFyZ2V0GAEgASgLMiou", "YmdzLnByb3RvY29sLnB1YmxpY2F0aW9uLnYyLmNsaWVudC5UYXJnZXQSLQoJ",
				"YXR0cmlidXRlGAIgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRIY", "ChBjcmVhdGlvbl90aW1lX21zGAMgASgE"
			}));
			PublicationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Target), Target.Parser, new string[] { "TopicName", "Identity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Filter), Filter.Parser, new string[] { "TitleId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeOptions), SubscribeOptions.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResult), SubscribeResult.Parser, new string[] { "Target", "Status" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Article), Article.Parser, new string[] { "Target", "Attribute", "CreationTimeMs" }, null, null, null, null)
			}));
		}

		// Token: 0x04003DC6 RID: 15814
		private static FileDescriptor descriptor;
	}
}
