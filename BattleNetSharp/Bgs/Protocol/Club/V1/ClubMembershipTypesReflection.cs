using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200046B RID: 1131
	public static class ClubMembershipTypesReflection
	{
		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x001AEF98 File Offset: 0x001AD198
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.descriptor;
			}
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x001AEFB0 File Offset: 0x001AD1B0
		static ClubMembershipTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci1iZ3MvbG93L3BiL2NsaWVudC9jbHViX21lbWJlcnNoaXBfdHlwZXMucHJv", "dG8SFGJncy5wcm90b2NvbC5jbHViLnYxGiFiZ3MvbG93L3BiL2NsaWVudC9j", "bHViX2NvcmUucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L2NsdWJfdHlwZS5w", "cm90bxojYmdzL2xvdy9wYi9jbGllbnQvY2x1Yl9tZW1iZXIucHJvdG8aJ2Jn", "cy9sb3cvcGIvY2xpZW50L2NsdWJfaW52aXRhdGlvbi5wcm90bxooYmdzL2xv", "dy9wYi9jbGllbnQvZXZlbnRfdmlld190eXBlcy5wcm90bxohYmdzL2xvdy9w", "Yi9jbGllbnQvcnBjX3R5cGVzLnByb3RvIn0KFENsdWJNZW1iZXJzaGlwRmls", "dGVyEjEKCW1lbWJlcl9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5jbHViLnYx", "Lk1lbWJlcklkEjIKBHR5cGUYAiABKAsyJC5iZ3MucHJvdG9jb2wuY2x1Yi52", "MS5VbmlxdWVDbHViVHlwZSJcCh5DbHViTWVtYmVyc2hpcFN1YnNjcmliZU9w",
				"dGlvbnMSOgoGZmlsdGVyGAEgAygLMiouYmdzLnByb3RvY29sLmNsdWIudjEu", "Q2x1Yk1lbWJlcnNoaXBGaWx0ZXIiWwodQ2x1Yk1lbWJlcnNoaXBHZXRTdGF0", "ZU9wdGlvbnMSOgoGZmlsdGVyGAEgAygLMiouYmdzLnByb3RvY29sLmNsdWIu", "djEuQ2x1Yk1lbWJlcnNoaXBGaWx0ZXIigwEKGUNsdWJNZW1iZXJzaGlwRGVz", "Y3JpcHRpb24SMQoJbWVtYmVyX2lkGAEgASgLMh4uYmdzLnByb3RvY29sLmNs", "dWIudjEuTWVtYmVySWQSMwoEY2x1YhgCIAEoCzIlLmJncy5wcm90b2NvbC5j", "bHViLnYxLkNsdWJEZXNjcmlwdGlvbiKAAgoTQ2x1Yk1lbWJlcnNoaXBTdGF0", "ZRJECgtkZXNjcmlwdGlvbhgBIAMoCzIvLmJncy5wcm90b2NvbC5jbHViLnYx", "LkNsdWJNZW1iZXJzaGlwRGVzY3JpcHRpb24SOAoKaW52aXRhdGlvbhgCIAMo", "CzIkLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJJbnZpdGF0aW9uEjkKB3Nl",
				"dHRpbmcYAyABKAsyKC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViU2hhcmVk", "U2V0dGluZ3MSLgoMbWVudGlvbl92aWV3GAQgASgLMhguYmdzLnByb3RvY29s", "LlZpZXdNYXJrZXIiIwoMQ2x1YlBvc2l0aW9uEhMKB2NsdWJfaWQYASADKARC", "AhABIk8KEkNsdWJTaGFyZWRTZXR0aW5ncxI5Cg1jbHViX3Bvc2l0aW9uGAEg", "ASgLMiIuYmdzLnByb3RvY29sLmNsdWIudjEuQ2x1YlBvc2l0aW9uIlYKGUNs", "dWJTaGFyZWRTZXR0aW5nc09wdGlvbnMSOQoNY2x1Yl9wb3NpdGlvbhgBIAEo", "CzIiLmJncy5wcm90b2NvbC5jbHViLnYxLkNsdWJQb3NpdGlvbiJZChxDbHVi", "U2hhcmVkU2V0dGluZ3NBc3NpZ25tZW50EjkKDWNsdWJfcG9zaXRpb24YASAB", "KAsyIi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5DbHViUG9zaXRpb24="
			}));
			ClubMembershipTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubCoreReflection.Descriptor,
				ClubTypeReflection.Descriptor,
				ClubMemberReflection.Descriptor,
				ClubInvitationReflection.Descriptor,
				EventViewTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClubMembershipFilter), ClubMembershipFilter.Parser, new string[] { "MemberId", "Type" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubMembershipSubscribeOptions), ClubMembershipSubscribeOptions.Parser, new string[] { "Filter" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubMembershipGetStateOptions), ClubMembershipGetStateOptions.Parser, new string[] { "Filter" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubMembershipDescription), ClubMembershipDescription.Parser, new string[] { "MemberId", "Club" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubMembershipState), ClubMembershipState.Parser, new string[] { "Description", "Invitation", "Setting", "MentionView" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubPosition), ClubPosition.Parser, new string[] { "ClubId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSharedSettings), ClubSharedSettings.Parser, new string[] { "ClubPosition" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSharedSettingsOptions), ClubSharedSettingsOptions.Parser, new string[] { "ClubPosition" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubSharedSettingsAssignment), ClubSharedSettingsAssignment.Parser, new string[] { "ClubPosition" }, null, null, null, null)
			}));
		}

		// Token: 0x040032EA RID: 13034
		private static FileDescriptor descriptor;
	}
}
