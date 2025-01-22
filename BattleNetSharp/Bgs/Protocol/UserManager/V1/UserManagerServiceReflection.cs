using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003B2 RID: 946
	public static class UserManagerServiceReflection
	{
		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06005F37 RID: 24375 RVA: 0x00170DE4 File Offset: 0x0016EFE4
		public static FileDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.descriptor;
			}
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x00170DFC File Offset: 0x0016EFFC
		static UserManagerServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CixiZ3MvbG93L3BiL2NsaWVudC91c2VyX21hbmFnZXJfc2VydmljZS5wcm90", "bxIcYmdzLnByb3RvY29sLnVzZXJfbWFuYWdlci52MRoqYmdzL2xvdy9wYi9j", "bGllbnQvdXNlcl9tYW5hZ2VyX3R5cGVzLnByb3RvGiRiZ3MvbG93L3BiL2Ns", "aWVudC9lbnRpdHlfdHlwZXMucHJvdG8aImJncy9sb3cvcGIvY2xpZW50L3Jv", "bGVfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5w", "cm90byJPChBTdWJzY3JpYmVSZXF1ZXN0EigKCGFnZW50X2lkGAEgASgLMhYu", "YmdzLnByb3RvY29sLkVudGl0eUlkEhEKCW9iamVjdF9pZBgCIAIoBCK/AQoR", "U3Vic2NyaWJlUmVzcG9uc2USRAoPYmxvY2tlZF9wbGF5ZXJzGAEgAygLMisu", "YmdzLnByb3RvY29sLnVzZXJfbWFuYWdlci52MS5CbG9ja2VkUGxheWVyEkIK", "DnJlY2VudF9wbGF5ZXJzGAIgAygLMiouYmdzLnByb3RvY29sLnVzZXJfbWFu",
				"YWdlci52MS5SZWNlbnRQbGF5ZXISIAoEcm9sZRgDIAMoCzISLmJncy5wcm90", "b2NvbC5Sb2xlIlEKElVuc3Vic2NyaWJlUmVxdWVzdBIoCghhZ2VudF9pZBgB", "IAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIRCglvYmplY3RfaWQYAiAB", "KAQikQEKF0FkZFJlY2VudFBsYXllcnNSZXF1ZXN0EjsKB3BsYXllcnMYASAD", "KAsyKi5iZ3MucHJvdG9jb2wudXNlcl9tYW5hZ2VyLnYxLlJlY2VudFBsYXll", "chIoCghhZ2VudF9pZBgCIAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIP", "Cgdwcm9ncmFtGAMgASgNIlYKGUNsZWFyUmVjZW50UGxheWVyc1JlcXVlc3QS", "KAoIYWdlbnRfaWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSDwoH", "cHJvZ3JhbRgCIAEoDSJ3ChJCbG9ja1BsYXllclJlcXVlc3QSKAoIYWdlbnRf", "aWQYASABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSKQoJdGFyZ2V0X2lk",
				"GAIgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEgwKBHJvbGUYAyABKA0i", "awoUVW5ibG9ja1BsYXllclJlcXVlc3QSKAoIYWdlbnRfaWQYASABKAsyFi5i", "Z3MucHJvdG9jb2wuRW50aXR5SWQSKQoJdGFyZ2V0X2lkGAIgAigLMhYuYmdz", "LnByb3RvY29sLkVudGl0eUlkIroBCh5CbG9ja2VkUGxheWVyQWRkZWROb3Rp", "ZmljYXRpb24SOwoGcGxheWVyGAEgAigLMisuYmdzLnByb3RvY29sLnVzZXJf", "bWFuYWdlci52MS5CbG9ja2VkUGxheWVyEi8KD2dhbWVfYWNjb3VudF9pZBgC", "IAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIqCgphY2NvdW50X2lkGAMg", "ASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkIrwBCiBCbG9ja2VkUGxheWVy", "UmVtb3ZlZE5vdGlmaWNhdGlvbhI7CgZwbGF5ZXIYASACKAsyKy5iZ3MucHJv", "dG9jb2wudXNlcl9tYW5hZ2VyLnYxLkJsb2NrZWRQbGF5ZXISLwoPZ2FtZV9h",
				"Y2NvdW50X2lkGAIgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEioKCmFj", "Y291bnRfaWQYAyABKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQiXAoeUmVj", "ZW50UGxheWVyc0FkZGVkTm90aWZpY2F0aW9uEjoKBnBsYXllchgBIAMoCzIq", "LmJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEuUmVjZW50UGxheWVyIl4K", "IFJlY2VudFBsYXllcnNSZW1vdmVkTm90aWZpY2F0aW9uEjoKBnBsYXllchgB", "IAMoCzIqLmJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEuUmVjZW50UGxh", "eWVyMqUGChJVc2VyTWFuYWdlclNlcnZpY2USdAoJU3Vic2NyaWJlEi4uYmdz", "LnByb3RvY29sLnVzZXJfbWFuYWdlci52MS5TdWJzY3JpYmVSZXF1ZXN0Gi8u", "YmdzLnByb3RvY29sLnVzZXJfbWFuYWdlci52MS5TdWJzY3JpYmVSZXNwb25z", "ZSIGgvkrAggBEmcKEEFkZFJlY2VudFBsYXllcnMSNS5iZ3MucHJvdG9jb2wu",
				"dXNlcl9tYW5hZ2VyLnYxLkFkZFJlY2VudFBsYXllcnNSZXF1ZXN0GhQuYmdz", "LnByb3RvY29sLk5vRGF0YSIGgvkrAggKEmsKEkNsZWFyUmVjZW50UGxheWVy", "cxI3LmJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEuQ2xlYXJSZWNlbnRQ", "bGF5ZXJzUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5KwIICxJd", "CgtCbG9ja1BsYXllchIwLmJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEu", "QmxvY2tQbGF5ZXJSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkr", "AggUEmEKDVVuYmxvY2tQbGF5ZXISMi5iZ3MucHJvdG9jb2wudXNlcl9tYW5h", "Z2VyLnYxLlVuYmxvY2tQbGF5ZXJSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5v", "RGF0YSIGgvkrAggVEmcKFUJsb2NrUGxheWVyRm9yU2Vzc2lvbhIwLmJncy5w", "cm90b2NvbC51c2VyX21hbmFnZXIudjEuQmxvY2tQbGF5ZXJSZXF1ZXN0GhQu",
				"YmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggoEl0KC1Vuc3Vic2NyaWJlEjAu", "YmdzLnByb3RvY29sLnVzZXJfbWFuYWdlci52MS5VbnN1YnNjcmliZVJlcXVl", "c3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCDMaOYL5Ky8KLWJuZXQu", "cHJvdG9jb2wudXNlcl9tYW5hZ2VyLlVzZXJNYW5hZ2VyU2VydmljZYr5KwIQ", "ATK7BAoTVXNlck1hbmFnZXJMaXN0ZW5lchJ3ChRPbkJsb2NrZWRQbGF5ZXJB", "ZGRlZBI8LmJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEuQmxvY2tlZFBs", "YXllckFkZGVkTm90aWZpY2F0aW9uGhkuYmdzLnByb3RvY29sLk5PX1JFU1BP", "TlNFIgaC+SsCCAESewoWT25CbG9ja2VkUGxheWVyUmVtb3ZlZBI+LmJncy5w", "cm90b2NvbC51c2VyX21hbmFnZXIudjEuQmxvY2tlZFBsYXllclJlbW92ZWRO", "b3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwII",
				"AhJ3ChRPblJlY2VudFBsYXllcnNBZGRlZBI8LmJncy5wcm90b2NvbC51c2Vy", "X21hbmFnZXIudjEuUmVjZW50UGxheWVyc0FkZGVkTm90aWZpY2F0aW9uGhku", "YmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAsSewoWT25SZWNlbnRQ", "bGF5ZXJzUmVtb3ZlZBI+LmJncy5wcm90b2NvbC51c2VyX21hbmFnZXIudjEu", "UmVjZW50UGxheWVyc1JlbW92ZWROb3RpZmljYXRpb24aGS5iZ3MucHJvdG9j", "b2wuTk9fUkVTUE9OU0UiBoL5KwIIDBo4gvkrLgosYm5ldC5wcm90b2NvbC51", "c2VyX21hbmFnZXIuVXNlck1hbmFnZXJOb3RpZnmK+SsCCAFCBUgBgAEA"
			}));
			UserManagerServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				UserManagerTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RoleTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SubscribeRequest), SubscribeRequest.Parser, new string[] { "AgentId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeResponse), SubscribeResponse.Parser, new string[] { "BlockedPlayers", "RecentPlayers", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnsubscribeRequest), UnsubscribeRequest.Parser, new string[] { "AgentId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddRecentPlayersRequest), AddRecentPlayersRequest.Parser, new string[] { "Players", "AgentId", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClearRecentPlayersRequest), ClearRecentPlayersRequest.Parser, new string[] { "AgentId", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockPlayerRequest), BlockPlayerRequest.Parser, new string[] { "AgentId", "TargetId", "Role" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnblockPlayerRequest), UnblockPlayerRequest.Parser, new string[] { "AgentId", "TargetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockedPlayerAddedNotification), BlockedPlayerAddedNotification.Parser, new string[] { "Player", "GameAccountId", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BlockedPlayerRemovedNotification), BlockedPlayerRemovedNotification.Parser, new string[] { "Player", "GameAccountId", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RecentPlayersAddedNotification), RecentPlayersAddedNotification.Parser, new string[] { "Player" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RecentPlayersRemovedNotification), RecentPlayersRemovedNotification.Parser, new string[] { "Player" }, null, null, null, null)
			}));
		}

		// Token: 0x04002B8B RID: 11147
		private static FileDescriptor descriptor;
	}
}
