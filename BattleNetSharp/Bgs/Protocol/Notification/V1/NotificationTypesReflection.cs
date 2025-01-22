using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005CF RID: 1487
	public static class NotificationTypesReflection
	{
		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06008C6A RID: 35946 RVA: 0x00221038 File Offset: 0x0021F238
		public static FileDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.descriptor;
			}
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x00221050 File Offset: 0x0021F250
		static NotificationTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CipiZ3MvbG93L3BiL2NsaWVudC9ub3RpZmljYXRpb25fdHlwZXMucHJvdG8S", "HGJncy5wcm90b2NvbC5ub3RpZmljYXRpb24udjEaJWJncy9sb3cvcGIvY2xp", "ZW50L2FjY291bnRfdHlwZXMucHJvdG8aJ2Jncy9sb3cvcGIvY2xpZW50L2F0", "dHJpYnV0ZV90eXBlcy5wcm90bxokYmdzL2xvdy9wYi9jbGllbnQvZW50aXR5", "X3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJv", "dG8iSwoGVGFyZ2V0EjMKCGlkZW50aXR5GAEgASgLMiEuYmdzLnByb3RvY29s", "LmFjY291bnQudjEuSWRlbnRpdHkSDAoEdHlwZRgCIAEoCSKdAQoMU3Vic2Ny", "aXB0aW9uEjQKBnRhcmdldBgBIAMoCzIkLmJncy5wcm90b2NvbC5ub3RpZmlj", "YXRpb24udjEuVGFyZ2V0EjUKCnN1YnNjcmliZXIYAiABKAsyIS5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5JZGVudGl0eRIgChFkZWxpdmVyeV9yZXF1aXJl",
				"ZBgDIAEoCDoFZmFsc2UioQMKDE5vdGlmaWNhdGlvbhIpCglzZW5kZXJfaWQY", "ASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSKQoJdGFyZ2V0X2lkGAIg", "AigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEgwKBHR5cGUYAyACKAkSKgoJ", "YXR0cmlidXRlGAQgAygLMhcuYmdzLnByb3RvY29sLkF0dHJpYnV0ZRIxChFz", "ZW5kZXJfYWNjb3VudF9pZBgFIAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJ", "ZBIxChF0YXJnZXRfYWNjb3VudF9pZBgGIAEoCzIWLmJncy5wcm90b2NvbC5F", "bnRpdHlJZBIZChFzZW5kZXJfYmF0dGxlX3RhZxgHIAEoCRIZChF0YXJnZXRf", "YmF0dGxlX3RhZxgIIAEoCRIlCgRwZWVyGAkgASgLMhcuYmdzLnByb3RvY29s", "LlByb2Nlc3NJZBI+ChNmb3J3YXJkaW5nX2lkZW50aXR5GAogASgLMiEuYmdz", "LnByb3RvY29sLmFjY291bnQudjEuSWRlbnRpdHkihwEKDlRhcmdldElkZW50",
				"aXR5EjMKB2FjY291bnQYASABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52", "MS5BY2NvdW50SWQSQAoMZ2FtZV9hY2NvdW50GAIgASgLMiouYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGVCAkgB"
			}));
			NotificationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Target), Target.Parser, new string[] { "Identity", "Type" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Subscription), Subscription.Parser, new string[] { "Target", "Subscriber", "DeliveryRequired" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Notification), Notification.Parser, new string[] { "SenderId", "TargetId", "Type", "Attribute", "SenderAccountId", "TargetAccountId", "SenderBattleTag", "TargetBattleTag", "Peer", "ForwardingIdentity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TargetIdentity), TargetIdentity.Parser, new string[] { "Account", "GameAccount" }, null, null, null, null)
			}));
		}

		// Token: 0x04003F84 RID: 16260
		private static FileDescriptor descriptor;
	}
}
