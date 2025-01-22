using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F2 RID: 1266
	public static class ClubStreamReflection
	{
		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x06007BCD RID: 31693 RVA: 0x001E20B0 File Offset: 0x001E02B0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.descriptor;
			}
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x001E20C8 File Offset: 0x001E02C8
		static ClubStreamReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiNiZ3MvbG93L3BiL2NsaWVudC9jbHViX3N0cmVhbS5wcm90bxIUYmdzLnBy", "b3RvY29sLmNsdWIudjEaIWJncy9sb3cvcGIvY2xpZW50L2NsdWJfZW51bS5w", "cm90bxojYmdzL2xvdy9wYi9jbGllbnQvY2x1Yl9tZW1iZXIucHJvdG8aIWJn", "cy9sb3cvcGIvY2xpZW50L2NsdWJfdHlwZS5wcm90bxo1YmdzL2xvdy9wYi9j", "bGllbnQvYXBpL2NsaWVudC92Mi9hdHRyaWJ1dGVfdHlwZXMucHJvdG8aI2Jn", "cy9sb3cvcGIvY2xpZW50L2VtYmVkX3R5cGVzLnByb3RvGihiZ3MvbG93L3Bi", "L2NsaWVudC9ldmVudF92aWV3X3R5cGVzLnByb3RvGiViZ3MvbG93L3BiL2Ns", "aWVudC9tZXNzYWdlX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9l", "dHNfdHlwZXMucHJvdG8iJwoOU3RyZWFtUG9zaXRpb24SFQoJc3RyZWFtX2lk", "GAEgAygEQgIQASIgCgxTdHJlYW1BY2Nlc3MSEAoEcm9sZRgBIAMoDUICEAEi",
				"1AEKE0NyZWF0ZVN0cmVhbU9wdGlvbnMSLQoJYXR0cmlidXRlGAEgAygLMhou", "YmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRIMCgRuYW1lGAIgASgJEg8KB3N1", "YmplY3QYAyABKAkSMgoGYWNjZXNzGAQgASgLMiIuYmdzLnByb3RvY29sLmNs", "dWIudjEuU3RyZWFtQWNjZXNzEjsKC3ZvaWNlX2xldmVsGAUgASgOMiYuYmdz", "LnByb3RvY29sLmNsdWIudjEuU3RyZWFtVm9pY2VMZXZlbCL7AQoGU3RyZWFt", "Eg8KB2NsdWJfaWQYASABKAQSCgoCaWQYAiABKAQSLQoJYXR0cmlidXRlGAMg", "AygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRIMCgRuYW1lGAQgASgJ", "Eg8KB3N1YmplY3QYBSABKAkSMgoGYWNjZXNzGAYgASgLMiIuYmdzLnByb3Rv", "Y29sLmNsdWIudjEuU3RyZWFtQWNjZXNzEjsKC3ZvaWNlX2xldmVsGAcgASgO", "MiYuYmdzLnByb3RvY29sLmNsdWIudjEuU3RyZWFtVm9pY2VMZXZlbBIVCg1j",
				"cmVhdGlvbl90aW1lGAggASgEIi0KEVN0cmVhbURlc2NyaXB0aW9uEgoKAmlk", "GAIgASgEEgwKBG5hbWUYBCABKAkicAoOTWVudGlvbkNvbnRlbnQSCwoDYWxs", "GAEgASgIEgwKBGhlcmUYAiABKAgSMQoJbWVtYmVyX2lkGAMgAygLMh4uYmdz", "LnByb3RvY29sLmNsdWIudjEuTWVtYmVySWQSEAoEcm9sZRgEIAMoDUICEAEi", "XgoUQ3JlYXRlTWVzc2FnZU9wdGlvbnMSDwoHY29udGVudBgCIAEoCRI1Cgdt", "ZW50aW9uGAMgASgLMiQuYmdzLnByb3RvY29sLmNsdWIudjEuTWVudGlvbkNv", "bnRlbnQiUgoaQ2x1YlN0cmVhbU1lc3NhZ2VDb250YWluZXISNAoHbWVzc2Fn", "ZRgBIAMoCzIjLmJncy5wcm90b2NvbC5jbHViLnYxLlN0cmVhbU1lc3NhZ2Ui", "kQEKDENvbnRlbnRDaGFpbhIPCgdjb250ZW50GAUgASgJEiYKBWVtYmVkGAYg", "AygLMhcuYmdzLnByb3RvY29sLkVtYmVkSW5mbxI1CgdtZW50aW9uGAcgASgL",
				"MiQuYmdzLnByb3RvY29sLmNsdWIudjEuTWVudGlvbkNvbnRlbnQSEQoJZWRp", "dF90aW1lGAggASgEIo0CCg1TdHJlYW1NZXNzYWdlEiMKAmlkGAMgASgLMhcu", "YmdzLnByb3RvY29sLk1lc3NhZ2VJZBI3CgZhdXRob3IYBCABKAsyJy5iZ3Mu", "cHJvdG9jb2wuY2x1Yi52MS5NZW1iZXJEZXNjcmlwdGlvbhI5Cg1jb250ZW50", "X2NoYWluGAYgAygLMiIuYmdzLnByb3RvY29sLmNsdWIudjEuQ29udGVudENo", "YWluEjoKCWRlc3Ryb3llchgPIAEoCzInLmJncy5wcm90b2NvbC5jbHViLnYx", "Lk1lbWJlckRlc2NyaXB0aW9uEhEKCWRlc3Ryb3llZBgQIAEoCBIUCgxkZXN0", "cm95X3RpbWUYESABKAQi/gIKDVN0cmVhbU1lbnRpb24SDwoHY2x1Yl9pZBgB", "IAEoBBIRCglzdHJlYW1faWQYAiABKAQSKwoKbWVzc2FnZV9pZBgDIAEoCzIX", "LmJncy5wcm90b2NvbC5NZXNzYWdlSWQSNwoGYXV0aG9yGAQgASgLMicuYmdz",
				"LnByb3RvY29sLmNsdWIudjEuTWVtYmVyRGVzY3JpcHRpb24SEQoJZGVzdHJv", "eWVkGAUgASgIEi4KCm1lbnRpb25faWQYBiABKAsyGi5iZ3MucHJvdG9jb2wu", "VGltZVNlcmllc0lkEjEKCW1lbWJlcl9pZBgHIAEoCzIeLmJncy5wcm90b2Nv", "bC5jbHViLnYxLk1lbWJlcklkEjQKB21lc3NhZ2UYCCABKAsyIy5iZ3MucHJv", "dG9jb2wuY2x1Yi52MS5TdHJlYW1NZXNzYWdlEjcKCWNsdWJfdHlwZRgJIAEo", "CzIkLmJncy5wcm90b2NvbC5jbHViLnYxLlVuaXF1ZUNsdWJUeXBlIloKClN0", "cmVhbVZpZXcSDwoHY2x1Yl9pZBgBIAEoBBIRCglzdHJlYW1faWQYAiABKAQS", "KAoGbWFya2VyGAMgASgLMhguYmdzLnByb3RvY29sLlZpZXdNYXJrZXIiPQoV", "U3RyZWFtQWR2YW5jZVZpZXdUaW1lEhEKCXN0cmVhbV9pZBgBIAEoBBIRCgl2", "aWV3X3RpbWUYAiABKAQiOAoPU3RyZWFtRXZlbnRUaW1lEhEKCXN0cmVhbV9p",
				"ZBgBIAEoBBISCgpldmVudF90aW1lGAIgASgEImEKEVN0cmVhbU1lbnRpb25W", "aWV3Eg8KB2NsdWJfaWQYASABKAQSEQoJc3RyZWFtX2lkGAIgASgEEigKBm1h", "cmtlchgDIAEoCzIYLmJncy5wcm90b2NvbC5WaWV3TWFya2VyItMBChJTdHJl", "YW1TdGF0ZU9wdGlvbnMSLQoJYXR0cmlidXRlGAEgAygLMhouYmdzLnByb3Rv", "Y29sLnYyLkF0dHJpYnV0ZRIMCgRuYW1lGAIgASgJEg8KB3N1YmplY3QYAyAB", "KAkSMgoGYWNjZXNzGAQgASgLMiIuYmdzLnByb3RvY29sLmNsdWIudjEuU3Ry", "ZWFtQWNjZXNzEjsKC3ZvaWNlX2xldmVsGAUgASgOMiYuYmdzLnByb3RvY29s", "LmNsdWIudjEuU3RyZWFtVm9pY2VMZXZlbCKOAgoVU3RyZWFtU3RhdGVBc3Np", "Z25tZW50EhEKCXN0cmVhbV9pZBgBIAEoBBItCglhdHRyaWJ1dGUYAiADKAsy", "Gi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlEgwKBG5hbWUYAyABKAkSDwoH",
				"c3ViamVjdBgEIAEoCRIyCgZhY2Nlc3MYBSABKAsyIi5iZ3MucHJvdG9jb2wu", "Y2x1Yi52MS5TdHJlYW1BY2Nlc3MSIwobc3RyZWFtX3N1YnNjcmlwdGlvbl9y", "ZW1vdmVkGAYgASgIEjsKC3ZvaWNlX2xldmVsGAcgASgOMiYuYmdzLnByb3Rv", "Y29sLmNsdWIudjEuU3RyZWFtVm9pY2VMZXZlbCKLAQoVU3RyZWFtVHlwaW5n", "SW5kaWNhdG9yEjEKCWF1dGhvcl9pZBgBIAEoCzIeLmJncy5wcm90b2NvbC5j", "bHViLnYxLk1lbWJlcklkEjAKCWluZGljYXRvchgCIAEoDjIdLmJncy5wcm90", "b2NvbC5UeXBpbmdJbmRpY2F0b3ISDQoFZXBvY2gYAyABKAQ="
			}));
			ClubStreamReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ClubEnumReflection.Descriptor,
				ClubMemberReflection.Descriptor,
				ClubTypeReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				EmbedTypesReflection.Descriptor,
				EventViewTypesReflection.Descriptor,
				MessageTypesReflection.Descriptor,
				EtsTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(StreamPosition), StreamPosition.Parser, new string[] { "StreamId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamAccess), StreamAccess.Parser, new string[] { "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateStreamOptions), CreateStreamOptions.Parser, new string[] { "Attribute", "Name", "Subject", "Access", "VoiceLevel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Stream), Stream.Parser, new string[] { "ClubId", "Id", "Attribute", "Name", "Subject", "Access", "VoiceLevel", "CreationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamDescription), StreamDescription.Parser, new string[] { "Id", "Name" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MentionContent), MentionContent.Parser, new string[] { "All", "Here", "MemberId", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateMessageOptions), CreateMessageOptions.Parser, new string[] { "Content", "Mention" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClubStreamMessageContainer), ClubStreamMessageContainer.Parser, new string[] { "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ContentChain), ContentChain.Parser, new string[] { "Content", "Embed", "Mention", "EditTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMessage), StreamMessage.Parser, new string[] { "Id", "Author", "ContentChain", "Destroyer", "Destroyed", "DestroyTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMention), StreamMention.Parser, new string[] { "ClubId", "StreamId", "MessageId", "Author", "Destroyed", "MentionId", "MemberId", "Message", "ClubType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamView), StreamView.Parser, new string[] { "ClubId", "StreamId", "Marker" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamAdvanceViewTime), StreamAdvanceViewTime.Parser, new string[] { "StreamId", "ViewTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamEventTime), StreamEventTime.Parser, new string[] { "StreamId", "EventTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamMentionView), StreamMentionView.Parser, new string[] { "ClubId", "StreamId", "Marker" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamStateOptions), StreamStateOptions.Parser, new string[] { "Attribute", "Name", "Subject", "Access", "VoiceLevel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamStateAssignment), StreamStateAssignment.Parser, new string[] { "StreamId", "Attribute", "Name", "Subject", "Access", "StreamSubscriptionRemoved", "VoiceLevel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StreamTypingIndicator), StreamTypingIndicator.Parser, new string[] { "AuthorId", "Indicator", "Epoch" }, null, null, null, null)
			}));
		}

		// Token: 0x0400384D RID: 14413
		private static FileDescriptor descriptor;
	}
}
