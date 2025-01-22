using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E6 RID: 1766
	public static class ChannelTypesReflection
	{
		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x0027ABA4 File Offset: 0x00278DA4
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.descriptor;
			}
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x0027ABBC File Offset: 0x00278DBC
		static ChannelTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiViZ3MvbG93L3BiL2NsaWVudC9jaGFubmVsX3R5cGVzLnByb3RvEhdiZ3Mu", "cHJvdG9jb2wuY2hhbm5lbC52MRowYmdzL2xvdy9wYi9jbGllbnQvYXBpL2Ns", "aWVudC92MS9jaGFubmVsX2lkLnByb3RvGidiZ3MvbG93L3BiL2NsaWVudC9h", "dHRyaWJ1dGVfdHlwZXMucHJvdG8aJGJncy9sb3cvcGIvY2xpZW50L2VudGl0", "eV90eXBlcy5wcm90bxolYmdzL2xvdy9wYi9jbGllbnQvYWNjb3VudF90eXBl", "cy5wcm90bxooYmdzL2xvdy9wYi9jbGllbnQvaW52aXRhdGlvbl90eXBlcy5w", "cm90bxohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnByb3RvIjwKB01l", "c3NhZ2USKgoJYXR0cmlidXRlGAEgAygLMhcuYmdzLnByb3RvY29sLkF0dHJp", "YnV0ZSoFCGQQkE4i2wEKE0xpc3RDaGFubmVsc09wdGlvbnMSFgoLc3RhcnRf", "aW5kZXgYASABKA06ATASFwoLbWF4X3Jlc3VsdHMYAiABKA06AjE2EgwKBG5h",
				"bWUYAyABKAkSDwoHcHJvZ3JhbRgEIAEoBxIOCgZsb2NhbGUYBSABKAcSFQoN", "Y2FwYWNpdHlfZnVsbBgGIAEoDRI3ChBhdHRyaWJ1dGVfZmlsdGVyGAcgAigL", "Mh0uYmdzLnByb3RvY29sLkF0dHJpYnV0ZUZpbHRlchIUCgxjaGFubmVsX3R5", "cGUYCCABKAkijwEKEkNoYW5uZWxEZXNjcmlwdGlvbhIqCgpjaGFubmVsX2lk", "GAEgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEhcKD2N1cnJlbnRfbWVt", "YmVycxgCIAEoDRI0CgVzdGF0ZRgDIAEoCzIlLmJncy5wcm90b2NvbC5jaGFu", "bmVsLnYxLkNoYW5uZWxTdGF0ZSKAAQoLQ2hhbm5lbEluZm8SQAoLZGVzY3Jp", "cHRpb24YASACKAsyKy5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5DaGFubmVs", "RGVzY3JpcHRpb24SLwoGbWVtYmVyGAIgAygLMh8uYmdzLnByb3RvY29sLmNo", "YW5uZWwudjEuTWVtYmVyIoIECgxDaGFubmVsU3RhdGUSEwoLbWF4X21lbWJl",
				"cnMYASABKA0SEwoLbWluX21lbWJlcnMYAiABKA0SKgoJYXR0cmlidXRlGAMg", "AygLMhcuYmdzLnByb3RvY29sLkF0dHJpYnV0ZRIsCgppbnZpdGF0aW9uGAQg", "AygLMhguYmdzLnByb3RvY29sLkludml0YXRpb24SDgoGcmVhc29uGAYgASgN", "El0KDXByaXZhY3lfbGV2ZWwYByABKA4yMi5iZ3MucHJvdG9jb2wuY2hhbm5l", "bC52MS5DaGFubmVsU3RhdGUuUHJpdmFjeUxldmVsOhJQUklWQUNZX0xFVkVM", "X09QRU4SDAoEbmFtZRgIIAEoCRIdCgxjaGFubmVsX3R5cGUYCiABKAk6B2Rl", "ZmF1bHQSEgoHcHJvZ3JhbRgLIAEoBzoBMBIjChVzdWJzY3JpYmVfdG9fcHJl", "c2VuY2UYDSABKAg6BHRydWUikQEKDFByaXZhY3lMZXZlbBIWChJQUklWQUNZ", "X0xFVkVMX09QRU4QARIsCihQUklWQUNZX0xFVkVMX09QRU5fSU5WSVRBVElP", "Tl9BTkRfRlJJRU5EEAISIQodUFJJVkFDWV9MRVZFTF9PUEVOX0lOVklUQVRJ",
				"T04QAxIYChRQUklWQUNZX0xFVkVMX0NMT1NFRBAEKgUIZBCQTiInChFNZW1i", "ZXJBY2NvdW50SW5mbxISCgpiYXR0bGVfdGFnGAMgASgJIpwBCgtNZW1iZXJT", "dGF0ZRIqCglhdHRyaWJ1dGUYASADKAsyFy5iZ3MucHJvdG9jb2wuQXR0cmli", "dXRlEhAKBHJvbGUYAiADKA1CAhABEhUKCnByaXZpbGVnZXMYAyABKAQ6ATAS", "OAoEaW5mbxgEIAEoCzIqLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLk1lbWJl", "ckFjY291bnRJbmZvImcKBk1lbWJlchIoCghpZGVudGl0eRgBIAIoCzIWLmJn", "cy5wcm90b2NvbC5JZGVudGl0eRIzCgVzdGF0ZRgCIAIoCzIkLmJncy5wcm90", "b2NvbC5jaGFubmVsLnYxLk1lbWJlclN0YXRlIrMBCgxTdWJzY3JpYmVySWQS", "NwoHYWNjb3VudBgBIAEoCzIiLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkFj", "Y291bnRJZEICGAESQAoMZ2FtZV9hY2NvdW50GAIgASgLMiouYmdzLnByb3Rv",
				"Y29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSKAoHcHJvY2VzcxgD", "IAEoCzIXLmJncy5wcm90b2NvbC5Qcm9jZXNzSWRCAkgBUAA="
			}));
			ChannelTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ChannelIdReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				InvitationTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Message), Message.Parser, new string[] { "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListChannelsOptions), ListChannelsOptions.Parser, new string[] { "StartIndex", "MaxResults", "Name", "Program", "Locale", "CapacityFull", "AttributeFilter", "ChannelType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelDescription), ChannelDescription.Parser, new string[] { "ChannelId", "CurrentMembers", "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelInfo), ChannelInfo.Parser, new string[] { "Description", "Member" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelState), ChannelState.Parser, new string[] { "MaxMembers", "MinMembers", "Attribute", "Invitation", "Reason", "PrivacyLevel", "Name", "ChannelType", "Program", "SubscribeToPresence" }, null, new Type[] { typeof(ChannelState.Types.PrivacyLevel) }, null, null),
				new GeneratedClrTypeInfo(typeof(MemberAccountInfo), MemberAccountInfo.Parser, new string[] { "BattleTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberState), MemberState.Parser, new string[] { "Attribute", "Role", "Privileges", "Info" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Member), Member.Parser, new string[] { "Identity", "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscriberId), SubscriberId.Parser, new string[] { "Account", "GameAccount", "Process" }, null, null, null, null)
			}));
		}

		// Token: 0x04004969 RID: 18793
		private static FileDescriptor descriptor;
	}
}
