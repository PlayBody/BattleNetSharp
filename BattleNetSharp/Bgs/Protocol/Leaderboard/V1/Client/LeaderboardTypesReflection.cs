using System;
using Bgs.Protocol.Account.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000650 RID: 1616
	public static class LeaderboardTypesReflection
	{
		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x06009635 RID: 38453 RVA: 0x00244D70 File Offset: 0x00242F70
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaderboardTypesReflection.descriptor;
			}
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x00244D88 File Offset: 0x00242F88
		static LeaderboardTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjdiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YxL2xlYWRlcmJvYXJk", "X3R5cGVzLnByb3RvEiJiZ3MucHJvdG9jb2wubGVhZGVyYm9hcmQudjEuY2xp", "ZW50GjNiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2FjY291bnRf", "dHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90", "byIkCgVTY29yZRIMCgR0eXBlGAEgASgJEg0KBXZhbHVlGAIgASgBIlIKC0Fj", "Y291bnRJbmZvEhYKDmNoYXJhY3Rlcl9uYW1lGAEgASgJEg0KBWNsYXNzGAMg", "ASgJEg0KBWxldmVsGAQgASgNEg0KBWVtYWlsGAUgASgJIsUCCgRSYW5rEi8K", "BHVzZXIYASABKAsyIS5iZ3MucHJvdG9jb2wuYWNjb3VudC52Mi5JZGVudGl0", "eRIWCg5sZWFkZXJib2FyZF9pZBgCIAEoCRIRCgllbnRpdHlfaWQYAyABKAkS", "EgoKYmF0dGxlX3RhZxgEIAEoCRIYChBjcmVhdGlvbl90aW1lX21zGAUgASgE",
				"EhAKCHBvc2l0aW9uGAYgASgEEjgKBXNjb3JlGAcgASgLMikuYmdzLnByb3Rv", "Y29sLmxlYWRlcmJvYXJkLnYxLmNsaWVudC5TY29yZRJACgdhY2NvdW50GBIg", "ASgLMi8uYmdzLnByb3RvY29sLmxlYWRlcmJvYXJkLnYxLmNsaWVudC5BY2Nv", "dW50SW5mbxIUCgxwYXlsb2FkZTBQYWQYCCABKAkSDwoHdmVyc2lvbhgJIAEo", "BA=="
			}));
			LeaderboardTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Score), Score.Parser, new string[] { "Type", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountInfo), AccountInfo.Parser, new string[] { "CharacterName", "Class", "Level", "Email" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Rank), Rank.Parser, new string[] { "User", "LeaderboardId", "EntityId", "BattleTag", "CreationTimeMs", "Position", "Score", "Account", "Payloade0Pad", "Version" }, null, null, null, null)
			}));
		}

		// Token: 0x040043A7 RID: 17319
		private static FileDescriptor descriptor;
	}
}
