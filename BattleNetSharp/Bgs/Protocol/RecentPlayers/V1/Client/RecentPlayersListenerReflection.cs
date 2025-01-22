using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200062E RID: 1582
	public static class RecentPlayersListenerReflection
	{
		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x060093C2 RID: 37826 RVA: 0x0023C810 File Offset: 0x0023AA10
		public static FileDescriptor Descriptor
		{
			get
			{
				return RecentPlayersListenerReflection.descriptor;
			}
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x0023C828 File Offset: 0x0023AA28
		static RecentPlayersListenerReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cj1iZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL3JlY2VudF9wbGF5", "ZXJzX2xpc3RlbmVyLnByb3RvEiViZ3MucHJvdG9jb2wucmVjZW50X3BsYXll", "cnMudjEuY2xpZW50GjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3Yx", "L3JlY2VudF9wbGF5ZXJzX3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVu", "dC9ycGNfdHlwZXMucHJvdG8ifwoeUmVjZW50UGxheWVyc0FkZGVkTm90aWZp", "Y2F0aW9uEhgKEGFnZW50X2FjY291bnRfaWQYASABKAQSQwoGcGxheWVyGAIg", "AygLMjMuYmdzLnByb3RvY29sLnJlY2VudF9wbGF5ZXJzLnYxLmNsaWVudC5S", "ZWNlbnRQbGF5ZXIikgEKIFJlY2VudFBsYXllcnNSZW1vdmVkTm90aWZpY2F0", "aW9uEhgKEGFnZW50X2FjY291bnRfaWQYASABKAQSVAoGcGxheWVyGAIgAygL", "MkQuYmdzLnByb3RvY29sLnJlY2VudF9wbGF5ZXJzLnYxLmNsaWVudC5SZWNl",
				"bnRQbGF5ZXJSZW1vdmVkQXNzaWdubWVudDLrAgoVUmVjZW50UGxheWVyc0xp", "c3RlbmVyEoABChRPblJlY2VudFBsYXllcnNBZGRlZBJFLmJncy5wcm90b2Nv", "bC5yZWNlbnRfcGxheWVycy52MS5jbGllbnQuUmVjZW50UGxheWVyc0FkZGVk", "Tm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsC", "CAEShAEKFk9uUmVjZW50UGxheWVyc1JlbW92ZWQSRy5iZ3MucHJvdG9jb2wu", "cmVjZW50X3BsYXllcnMudjEuY2xpZW50LlJlY2VudFBsYXllcnNSZW1vdmVk", "Tm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsC", "CAIaSIL5Kz4KPGJuZXQucHJvdG9jb2wucmVjZW50X3BsYXllcnMudjEuY2xp", "ZW50LlJlY2VudFBsYXllcnNMaXN0ZW5lcor5KwIIAQ=="
			}));
			RecentPlayersListenerReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RecentPlayersTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(RecentPlayersAddedNotification), RecentPlayersAddedNotification.Parser, new string[] { "AgentAccountId", "Player" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RecentPlayersRemovedNotification), RecentPlayersRemovedNotification.Parser, new string[] { "AgentAccountId", "Player" }, null, null, null, null)
			}));
		}

		// Token: 0x040042AC RID: 17068
		private static FileDescriptor descriptor;
	}
}
