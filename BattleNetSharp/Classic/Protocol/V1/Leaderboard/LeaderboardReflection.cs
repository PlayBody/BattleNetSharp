using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Leaderboard
{
	// Token: 0x02000760 RID: 1888
	public static class LeaderboardReflection
	{
		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600ADAA RID: 44458 RVA: 0x002A4C38 File Offset: 0x002A2E38
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaderboardReflection.descriptor;
			}
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x002A4C50 File Offset: 0x002A2E50
		static LeaderboardReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChViZ3MvbGVhZGVyYm9hcmQucHJvdG8SH2NsYXNzaWMucHJvdG9jb2wudjEu", "bGVhZGVyYm9hcmQaIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90", "byIaCgpTZXJ2ZXJUaW1lEgwKBHRpbWUYASABKAUiNAoNTGVhZGVyYm9hcmRJ", "ZBILCgN1bmsYASACKAUSFgoObGVhZGVyYm9hcmRfaWQYAiACKAkiVAoMTGVh", "ZGVyYm9hcmRzEkQKDGxlYWRlcmJvYXJkcxgBIAMoCzIuLmNsYXNzaWMucHJv", "dG9jb2wudjEubGVhZGVyYm9hcmQuTGVhZGVyYm9hcmRJZCJJCgZTZWFzb24S", "CwoDbnVtGAEgAigFEhIKCnN0YXJ0X3RpbWUYAiACKAUSEAoIZW5kX3RpbWUY", "AyACKAUSDAoEbmFtZRgEIAIoCSJdCgpTZWFzb25JbmZvEjgKB3NlYXNvbnMY", "ASADKAsyJy5jbGFzc2ljLnByb3RvY29sLnYxLmxlYWRlcmJvYXJkLlNlYXNv", "bhIVCg1hY3RpdmVfc2Vhc29uGAIgAigFMsQCCgtMZWFkZXJib2FyZBJkChFH",
				"ZXRMZWFkZXJib2FyZElkcxIULmJncy5wcm90b2NvbC5Ob0RhdGEaLS5jbGFz", "c2ljLnByb3RvY29sLnYxLmxlYWRlcmJvYXJkLkxlYWRlcmJvYXJkcyIKgvkr", "Bgj81PbcBxJeCg1HZXRTZXJ2ZXJUaW1lEhQuYmdzLnByb3RvY29sLk5vRGF0", "YRorLmNsYXNzaWMucHJvdG9jb2wudjEubGVhZGVyYm9hcmQuU2VydmVyVGlt", "ZSIKgvkrBgiF9/DYBBJeCg1TZXRTZWFzb25JbmZvEisuY2xhc3NpYy5wcm90", "b2NvbC52MS5sZWFkZXJib2FyZC5TZWFzb25JbmZvGhQuYmdzLnByb3RvY29s", "Lk5vRGF0YSIKgvkrBgiss4+5ChoPgvkrCwoJMHhCNjJBOEEx"
			}));
			LeaderboardReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ServerTime), ServerTime.Parser, new string[] { "Time" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LeaderboardId), LeaderboardId.Parser, new string[] { "Unk", "LeaderboardId_" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Leaderboards), Leaderboards.Parser, new string[] { "Leaderboards_" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Season), Season.Parser, new string[] { "Num", "StartTime", "EndTime", "Name" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SeasonInfo), SeasonInfo.Parser, new string[] { "Seasons", "ActiveSeason" }, null, null, null, null)
			}));
		}

		// Token: 0x04004E4A RID: 20042
		private static FileDescriptor descriptor;
	}
}
