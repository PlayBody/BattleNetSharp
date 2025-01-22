using System;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200063B RID: 1595
	public static class RecentPlayersTypesReflection
	{
		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600947D RID: 38013 RVA: 0x0023EE9C File Offset: 0x0023D09C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RecentPlayersTypesReflection.descriptor;
			}
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x0023EEB4 File Offset: 0x0023D0B4
		static RecentPlayersTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL3JlY2VudF9wbGF5", "ZXJzX3R5cGVzLnByb3RvEiViZ3MucHJvdG9jb2wucmVjZW50X3BsYXllcnMu", "djEuY2xpZW50GiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8a", "NWJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvYXR0cmlidXRlX3R5", "cGVzLnByb3RvIpMBChdBZGRSZWNlbnRQbGF5ZXJzT3B0aW9ucxJnCg1yZWNl", "bnRfcGxheWVyGAIgAygLMjouYmdzLnByb3RvY29sLnJlY2VudF9wbGF5ZXJz", "LnYxLmNsaWVudC5SZWNlbnRQbGF5ZXJPcHRpb25zQhSK+SsGKgQKAggBivkr", "BioECgIQFBIPCgdwcm9ncmFtGAMgASgHIngKE1JlY2VudFBsYXllck9wdGlv", "bnMSHAoKYWNjb3VudF9pZBgBIAEoBEIIivkrBBICEAASQwoJYXR0cmlidXRl", "GAUgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZUIUivkrBioECgII",
				"AIr5KwYqBAoCEBQiLAoZQ2xlYXJSZWNlbnRQbGF5ZXJzT3B0aW9ucxIPCgdw", "cm9ncmFtGAEgASgHIisKHVJlY2VudFBsYXllclJlbW92ZWRBc3NpZ25tZW50", "EgoKAmlkGAEgASgEIp8BCgxSZWNlbnRQbGF5ZXISCgoCaWQYASABKAQSDwoH", "cHJvZ3JhbRgCIAEoBxItCglhdHRyaWJ1dGUYBCADKAsyGi5iZ3MucHJvdG9j", "b2wudjIuQXR0cmlidXRlEhgKEGNyZWF0aW9uX3RpbWVfdXMYBSABKAQSGAoQ", "bW9kaWZpZWRfdGltZV91cxgGIAEoBBIPCgdjb3VudGVyGAcgASgEIlkKElJl", "Y2VudFBsYXllcnNTdGF0ZRJDCgZwbGF5ZXIYASADKAsyMy5iZ3MucHJvdG9j", "b2wucmVjZW50X3BsYXllcnMudjEuY2xpZW50LlJlY2VudFBsYXllclAB"
			}));
			RecentPlayersTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(AddRecentPlayersOptions), AddRecentPlayersOptions.Parser, new string[] { "RecentPlayer", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RecentPlayerOptions), RecentPlayerOptions.Parser, new string[] { "AccountId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClearRecentPlayersOptions), ClearRecentPlayersOptions.Parser, new string[] { "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RecentPlayerRemovedAssignment), RecentPlayerRemovedAssignment.Parser, new string[] { "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RecentPlayer), RecentPlayer.Parser, new string[] { "Id", "Program", "Attribute", "CreationTimeUs", "ModifiedTimeUs", "Counter" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RecentPlayersState), RecentPlayersState.Parser, new string[] { "Player" }, null, null, null, null)
			}));
		}

		// Token: 0x040042EA RID: 17130
		private static FileDescriptor descriptor;
	}
}
