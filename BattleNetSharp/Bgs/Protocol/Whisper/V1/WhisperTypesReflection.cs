using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003AE RID: 942
	public static class WhisperTypesReflection
	{
		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06005EE1 RID: 24289 RVA: 0x0016F74C File Offset: 0x0016D94C
		public static FileDescriptor Descriptor
		{
			get
			{
				return WhisperTypesReflection.descriptor;
			}
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x0016F764 File Offset: 0x0016D964
		static WhisperTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiViZ3MvbG93L3BiL2NsaWVudC93aGlzcGVyX3R5cGVzLnByb3RvEhdiZ3Mu", "cHJvdG9jb2wud2hpc3Blci52MRolYmdzL2xvdy9wYi9jbGllbnQvYWNjb3Vu", "dF90eXBlcy5wcm90bxojYmdzL2xvdy9wYi9jbGllbnQvZW1iZWRfdHlwZXMu", "cHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90bxooYmdz", "L2xvdy9wYi9jbGllbnQvZXZlbnRfdmlld190eXBlcy5wcm90bxolYmdzL2xv", "dy9wYi9jbGllbnQvbWVzc2FnZV90eXBlcy5wcm90byKIAgoHV2hpc3BlchI1", "CglzZW5kZXJfaWQYASABKAsyIi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5B", "Y2NvdW50SWQSOAoMcmVjaXBpZW50X2lkGAIgASgLMiIuYmdzLnByb3RvY29s", "LmFjY291bnQudjEuQWNjb3VudElkEg8KB2NvbnRlbnQYAyABKAkSJgoFZW1i", "ZWQYBCADKAsyFy5iZ3MucHJvdG9jb2wuRW1iZWRJbmZvEhUKDWNyZWF0aW9u",
				"X3RpbWUYBiABKAQSDwoHcHJvZ3JhbRgHIAEoBxIrCgptZXNzYWdlX2lkGAgg", "ASgLMhcuYmdzLnByb3RvY29sLk1lc3NhZ2VJZCKWAQoLV2hpc3BlclZpZXcS", "NQoJc2VuZGVyX2lkGAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQudjEu", "QWNjb3VudElkEi0KC3ZpZXdfbWFya2VyGAIgASgLMhguYmdzLnByb3RvY29s", "LlZpZXdNYXJrZXISIQoRc2VuZGVyX2JhdHRsZV90YWcYAyABKAlCBoL5KwII", "ASJVCgtTZW5kT3B0aW9ucxI1Cgl0YXJnZXRfaWQYASABKAsyIi5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5BY2NvdW50SWQSDwoHY29udGVudBgCIAEoCQ=="
			}));
			WhisperTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				EmbedTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor,
				EventViewTypesReflection.Descriptor,
				MessageTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Whisper), Whisper.Parser, new string[] { "SenderId", "RecipientId", "Content", "Embed", "CreationTime", "Program", "MessageId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WhisperView), WhisperView.Parser, new string[] { "SenderId", "ViewMarker", "SenderBattleTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SendOptions), SendOptions.Parser, new string[] { "TargetId", "Content" }, null, null, null, null)
			}));
		}

		// Token: 0x04002B65 RID: 11109
		private static FileDescriptor descriptor;
	}
}
