using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000340 RID: 832
	public static class SettingsGameOnlineCreationReflection
	{
		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x060056E3 RID: 22243 RVA: 0x00150710 File Offset: 0x0014E910
		public static FileDescriptor Descriptor
		{
			get
			{
				return SettingsGameOnlineCreationReflection.descriptor;
			}
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x00150728 File Offset: 0x0014E928
		static SettingsGameOnlineCreationReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "CiNzZXR0aW5nc19nYW1lX29ubGluZV9jcmVhdGlvbi5wcm90bxIgQmxpenph", "cmQuVGVsZW1ldHJ5LkZlbndheS5DbGllbnQi/wEKGk9ubGluZUdhbWVDcmVh", "dGlvblNldHRpbmdzEhIKCmRpZmZpY3VsdHkYASABKAkSHQoVbWF4X251bWJl", "cl9vZl9wbGF5ZXJzGAIgASgNEisKI2VuYWJsZWRfY2hhcmFjdGVyX2xldmVs", "X3Jlc3RyaWN0aW9uGAMgASgIEiYKHm1heF9jaGFyYWN0ZXJfbGV2ZWxfZGlm", "ZmVyZW5jZRgEIAEoDRItCiVhdXRvbWF0aWNhbGx5X2ludml0ZV9wbGF5ZXJz", "X3RvX3BhcnR5GAUgASgIEioKImF1dG9tYXRpY2FsbHlfYWNjZXB0X3BhcnR5", "X2ludml0ZXMYBiABKAg=" }));
			SettingsGameOnlineCreationReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(OnlineGameCreationSettings), OnlineGameCreationSettings.Parser, new string[] { "Difficulty", "MaxNumberOfPlayers", "EnabledCharacterLevelRestriction", "MaxCharacterLevelDifference", "AutomaticallyInvitePlayersToParty", "AutomaticallyAcceptPartyInvites" }, null, null, null, null)
			}));
		}

		// Token: 0x040027A9 RID: 10153
		private static FileDescriptor descriptor;
	}
}
