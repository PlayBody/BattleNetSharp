using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000632 RID: 1586
	public static class RecentPlayersServiceReflection
	{
		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x060093F6 RID: 37878 RVA: 0x0023D414 File Offset: 0x0023B614
		public static FileDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.descriptor;
			}
		}

		// Token: 0x060093F7 RID: 37879 RVA: 0x0023D42C File Offset: 0x0023B62C
		static RecentPlayersServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjxiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL3JlY2VudF9wbGF5", "ZXJzX3NlcnZpY2UucHJvdG8SJWJncy5wcm90b2NvbC5yZWNlbnRfcGxheWVy", "cy52MS5jbGllbnQaOmJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjEv", "cmVjZW50X3BsYXllcnNfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50", "L3JwY190eXBlcy5wcm90byISChBTdWJzY3JpYmVSZXF1ZXN0Il0KEVN1YnNj", "cmliZVJlc3BvbnNlEkgKBXN0YXRlGAEgASgLMjkuYmdzLnByb3RvY29sLnJl", "Y2VudF9wbGF5ZXJzLnYxLmNsaWVudC5SZWNlbnRQbGF5ZXJzU3RhdGUiFAoS", "VW5zdWJzY3JpYmVSZXF1ZXN0IhEKD0dldFN0YXRlUmVxdWVzdCJcChBHZXRT", "dGF0ZVJlc3BvbnNlEkgKBXN0YXRlGAEgASgLMjkuYmdzLnByb3RvY29sLnJl", "Y2VudF9wbGF5ZXJzLnYxLmNsaWVudC5SZWNlbnRQbGF5ZXJzU3RhdGUidAoX",
				"QWRkUmVjZW50UGxheWVyc1JlcXVlc3QSWQoHb3B0aW9ucxgCIAEoCzI+LmJn", "cy5wcm90b2NvbC5yZWNlbnRfcGxheWVycy52MS5jbGllbnQuQWRkUmVjZW50", "UGxheWVyc09wdGlvbnNCCIr5KwQyAggBIm4KGUNsZWFyUmVjZW50UGxheWVy", "c1JlcXVlc3QSUQoHb3B0aW9ucxgCIAEoCzJALmJncy5wcm90b2NvbC5yZWNl", "bnRfcGxheWVycy52MS5jbGllbnQuQ2xlYXJSZWNlbnRQbGF5ZXJzT3B0aW9u", "czK4BQoUUmVjZW50UGxheWVyc1NlcnZpY2UShgEKCVN1YnNjcmliZRI3LmJn", "cy5wcm90b2NvbC5yZWNlbnRfcGxheWVycy52MS5jbGllbnQuU3Vic2NyaWJl", "UmVxdWVzdBo4LmJncy5wcm90b2NvbC5yZWNlbnRfcGxheWVycy52MS5jbGll", "bnQuU3Vic2NyaWJlUmVzcG9uc2UiBoL5KwIIARJmCgtVbnN1YnNjcmliZRI5", "LmJncy5wcm90b2NvbC5yZWNlbnRfcGxheWVycy52MS5jbGllbnQuVW5zdWJz",
				"Y3JpYmVSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggCEoMB", "CghHZXRTdGF0ZRI2LmJncy5wcm90b2NvbC5yZWNlbnRfcGxheWVycy52MS5j", "bGllbnQuR2V0U3RhdGVSZXF1ZXN0GjcuYmdzLnByb3RvY29sLnJlY2VudF9w", "bGF5ZXJzLnYxLmNsaWVudC5HZXRTdGF0ZVJlc3BvbnNlIgaC+SsCCAMScAoQ", "QWRkUmVjZW50UGxheWVycxI+LmJncy5wcm90b2NvbC5yZWNlbnRfcGxheWVy", "cy52MS5jbGllbnQuQWRkUmVjZW50UGxheWVyc1JlcXVlc3QaFC5iZ3MucHJv", "dG9jb2wuTm9EYXRhIgaC+SsCCAQSdAoSQ2xlYXJSZWNlbnRQbGF5ZXJzEkAu", "YmdzLnByb3RvY29sLnJlY2VudF9wbGF5ZXJzLnYxLmNsaWVudC5DbGVhclJl", "Y2VudFBsYXllcnNSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkr", "AggFGkGC+Ss9CjtibmV0LnByb3RvY29sLnJlY2VudF9wbGF5ZXJzLnYxLmNs",
				"aWVudC5SZWNlbnRQbGF5ZXJzU2VydmljZQ=="
			}));
			RecentPlayersServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RecentPlayersTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateRequest), GetStateRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetStateResponse), GetStateResponse.Parser, new string[] { "State" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddRecentPlayersRequest), AddRecentPlayersRequest.Parser, new string[] { "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClearRecentPlayersRequest), ClearRecentPlayersRequest.Parser, new string[] { "Options" }, null, null, null, null)
			}));
		}

		// Token: 0x040042C5 RID: 17093
		private static FileDescriptor descriptor;
	}
}
