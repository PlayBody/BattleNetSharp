using System;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000155 RID: 341
	public static class OnlineCommonReflection
	{
		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x00089680 File Offset: 0x00087880
		public static FileDescriptor Descriptor
		{
			get
			{
				return OnlineCommonReflection.descriptor;
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00089698 File Offset: 0x00087898
		static OnlineCommonReflection()
		{
			byte[] array = Convert.FromBase64String("ChJPbmxpbmVDb21tb24ucHJvdG8SDUZlbnJpcy5PbmxpbmUiVwoKR2FtZUhh" + "bmRsZRIYChBnYW1lX2luc3RhbmNlX2lkGAEgASgNEhUKDW1hdGNobWFrZXJf" + "aWQYAiABKAQSGAoQZ2FtZV9zZXJ2ZXJfZ3VpZBgDIAEoBCIvCg9QbGF0Zm9y" + "bUFjY291bnQSCgoCaWQYASABKAQSEAoIcGxhdGZvcm0YAiABKA0=");
			OnlineCommonReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GameHandle), GameHandle.Parser, new string[] { "GameInstanceId", "MatchmakerId", "GameServerGuid" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlatformAccount), PlatformAccount.Parser, new string[] { "Id", "Platform" }, null, null, null, null)
			}));
		}

		// Token: 0x04000F8D RID: 3981
		private static FileDescriptor descriptor;
	}
}
