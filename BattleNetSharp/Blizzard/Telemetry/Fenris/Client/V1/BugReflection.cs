using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x020002FD RID: 765
	public static class BugReflection
	{
		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x00134798 File Offset: 0x00132998
		public static FileDescriptor Descriptor
		{
			get
			{
				return BugReflection.descriptor;
			}
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x001347B0 File Offset: 0x001329B0
		static BugReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CglCdWcucHJvdG8SI0JsaXp6YXJkLlRlbGVtZXRyeS5GZW5yaXMuQ2xpZW50", "LnYxGhBMb2NhbGVJbmZvLnByb3RvGhBBQlRlc3RJbmZvLnByb3RvIrkLCgNC", "dWcSEQoJd29ybGRfc25vGAEgASgREhIKCndvcmxkX25hbWUYAiABKAkSEwoL", "c3Viem9uZV9zbm8YAyABKBESFAoMc3Viem9uZV9uYW1lGAQgASgJEg8KB3Bs", "YWNlX3gYBSABKAISDwoHcGxhY2VfeRgGIAEoAhIPCgdwbGFjZV96GAcgASgC", "EhEKCXNjZW5lX3NubxgIIAEoERISCgpzY2VuZV9uYW1lGAkgASgJEhgKEHNj", "ZW5lX3Bvc2l0aW9uX3gYCiABKAISGAoQc2NlbmVfcG9zaXRpb25feRgLIAEo", "AhIYChBzY2VuZV9wb3NpdGlvbl96GAwgASgCEhoKEmluc3RhbmNlX3F1ZXN0", "X3NubxgNIAEoERIbChNpbnN0YW5jZV9xdWVzdF9uYW1lGA4gASgJEhwKFGlu", "c3RhbmNlX3F1ZXN0X3BoYXNlGA8gASgFEhYKDmR1bmdlb25fc3RhdGVzGBAg",
				"ASgJEhIKCndvcmxkX3NlZWQYESABKAUSEwoLZGVzY3JpcHRpb24YEiABKAkS", "EAoIbWV0YWRhdGEYEyABKAkSEgoGbG9jYWxlGBQgASgFQgIYARJECgtsb2Nh", "bGVfaW5mbxgjIAEoCzIvLkJsaXp6YXJkLlRlbGVtZXRyeS5GZW5yaXMuQ2xp", "ZW50LnYxLkxvY2FsZUluZm8SDgoGYnJhbmNoGBUgASgJEhQKDGJ1aWxkX251", "bWJlchgWIAEoBRIfChdidWlsZF92ZXJzaW9uX2NvZGVfZGF0YRgXIAEoCRIa", "ChJ0aHVtYm5haWxfanBnX2RhdGEYGCABKAwSDwoHc3VtbWFyeRgZIAEoCRIR", "Cgl0aW1lc3RhbXAYGiABKAQSGQoRdHJhY2tlZF9xdWVzdF9zbm8YGyABKBES", "GgoSdHJhY2tlZF9xdWVzdF9uYW1lGBwgASgJEhsKE3RyYWNrZWRfcXVlc3Rf", "cGhhc2UYHSABKAUSFQoNb3JpZW50YXRpb25feBgeIAEoAhIVCg1vcmllbnRh", "dGlvbl95GB8gASgCEhUKDW9yaWVudGF0aW9uX3oYICABKAISFQoNb3JpZW50",
				"YXRpb25fdxghIAEoAhISCgpsYXRlbmN5X21zGCIgASgFEhsKD3BsYXllcl9o", "ZXJvX3R4dBgkIAEoDEICGAESFwoPbG9jYWxfcHJlZnNfdHh0GCUgASgMEhgK", "EGxhc3Rfc2Nyb2xsX3VzZWQYJiABKAkSIAoYbGFzdF9jdXRzY2VuZV9wbGF5", "ZWRfc25vGCcgASgREiEKGWxhc3RfY3V0c2NlbmVfcGxheWVkX25hbWUYKCAB", "KAkSJwofbGFzdF9jb21wbGV0ZWRfcXVlc3RfcGhhc2VfaW5mbxgpIAEoCRIV", "Cg1pbnN0YW5jZV90eXBlGCogASgJEh4KFm5pZ2h0bWFyZV9kdW5nZW9uX2lu", "Zm8YKyABKAkSIAoYbGFzdF9jb21wbGV0ZWRfZXZlbnRfc25vGCwgASgREiEK", "GWxhc3RfY29tcGxldGVkX2V2ZW50X25hbWUYLSABKAkSLQolbGFzdF9jb21w", "bGV0ZWRfZXZlbnRfbnVtX3BhcnRpY2lwYW50cxguIAEoERIfChdudW1fbG9j", "YWxfcGFydHlfcGxheWVycxgvIAEoERIgChhudW1fb25saW5lX3BhcnR5X3Bs",
				"YXllcnMYMCABKBESJAocY2xpZW50X3N1cnJvdW5kaW5nc19pbmZvX3R4dBgx", "IAEoDBIfChdsYXN0X3VzZWRfd2F5cG9pbnRfaW5mbxgyIAEoCRIhChljb25j", "ZXJuaW5nX2NvbnRlbnRfZ3JvdXBzGDMgASgJEhAKCGNhdGVnb3J5GDQgASgJ", "EkEKBXRlc3RzGDUgAygLMjIuQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5D", "bGllbnQudjEuQUJUZXN0aW5nSW5mbw=="
			}));
			BugReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				LocaleInfoReflection.Descriptor,
				ABTestInfoReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Bug), Bug.Parser, new string[]
				{
					"WorldSno", "WorldName", "SubzoneSno", "SubzoneName", "PlaceX", "PlaceY", "PlaceZ", "SceneSno", "SceneName", "ScenePositionX",
					"ScenePositionY", "ScenePositionZ", "InstanceQuestSno", "InstanceQuestName", "InstanceQuestPhase", "DungeonStates", "WorldSeed", "Description", "Metadata", "Locale",
					"LocaleInfo", "Branch", "BuildNumber", "BuildVersionCodeData", "ThumbnailJpgData", "Summary", "Timestamp", "TrackedQuestSno", "TrackedQuestName", "TrackedQuestPhase",
					"OrientationX", "OrientationY", "OrientationZ", "OrientationW", "LatencyMs", "PlayerHeroTxt", "LocalPrefsTxt", "LastScrollUsed", "LastCutscenePlayedSno", "LastCutscenePlayedName",
					"LastCompletedQuestPhaseInfo", "InstanceType", "NightmareDungeonInfo", "LastCompletedEventSno", "LastCompletedEventName", "LastCompletedEventNumParticipants", "NumLocalPartyPlayers", "NumOnlinePartyPlayers", "ClientSurroundingsInfoTxt", "LastUsedWaypointInfo",
					"ConcerningContentGroups", "Category", "Tests"
				}, null, null, null, null)
			}));
		}

		// Token: 0x0400241A RID: 9242
		private static FileDescriptor descriptor;
	}
}
