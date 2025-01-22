using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000549 RID: 1353
	public static class SessionTypesReflection
	{
		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x060082D6 RID: 33494 RVA: 0x001FCD74 File Offset: 0x001FAF74
		public static FileDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.descriptor;
			}
		}

		// Token: 0x060082D7 RID: 33495 RVA: 0x001FCD8C File Offset: 0x001FAF8C
		static SessionTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiViZ3MvbG93L3BiL2NsaWVudC9zZXNzaW9uX3R5cGVzLnByb3RvEhdiZ3Mu", "cHJvdG9jb2wuc2Vzc2lvbi52MRolYmdzL2xvdy9wYi9jbGllbnQvYWNjb3Vu", "dF90eXBlcy5wcm90byI/Cg5TZXNzaW9uT3B0aW9ucxIVCgdiaWxsaW5nGAEg", "ASgIOgR0cnVlEhYKCHByZXNlbmNlGAIgASgIOgR0cnVlIqcDCgxTZXNzaW9u", "U3RhdGUSOgoGaGFuZGxlGAEgASgLMiouYmdzLnByb3RvY29sLmFjY291bnQu", "djEuR2FtZUFjY291bnRIYW5kbGUSFgoOY2xpZW50X2FkZHJlc3MYAiABKAkS", "FgoObGFzdF90aWNrX3RpbWUYAyABKAQSEwoLY3JlYXRlX3RpbWUYBCABKAQS", "IAoYcGFyZW50YWxfY29udHJvbHNfYWN0aXZlGAUgASgIEj4KCGxvY2F0aW9u", "GAYgASgLMiwuYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZVNlc3Npb25M", "b2NhdGlvbhIZChF1c2luZ19pZ3JfYWRkcmVzcxgHIAEoCBIWCg5oYXNfYmVu",
				"ZWZhY3RvchgIIAEoCBIuCgZpZ3JfaWQYCSABKAsyHi5iZ3MucHJvdG9jb2wu", "YWNjb3VudC52MS5JZ3JJZBISCgpkZWR1Y3RpYmxlGAogASgIEhYKDmV4cGly", "ZV90aW1lX21zGAsgASgEEhMKC21hY19hZGRyZXNzGAwgASgJEhAKCGlncl9w", "YWlkGA0gASgIIn0KEVNlc3Npb25JZGVudGlmaWVyEkAKDGdhbWVfYWNjb3Vu", "dBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50", "SGFuZGxlEhIKCnNlc3Npb25faWQYAiABKAkSEgoKYWNjb3VudF9pZBgDIAEo", "BCKoAgoPR2FtZVNlc3Npb25JbmZvEhYKCnN0YXJ0X3RpbWUYAyABKA1CAhgB", "Ej4KCGxvY2F0aW9uGAQgASgLMiwuYmdzLnByb3RvY29sLnNlc3Npb24udjEu", "R2FtZVNlc3Npb25Mb2NhdGlvbhIWCg5oYXNfYmVuZWZhY3RvchgFIAEoCBIU", "Cgxpc191c2luZ19pZ3IYBiABKAgSIAoYcGFyZW50YWxfY29udHJvbHNfYWN0",
				"aXZlGAcgASgIEhYKDnN0YXJ0X3RpbWVfc2VjGAggASgEEi4KBmlncl9pZBgJ", "IAEoCzIeLmJncy5wcm90b2NvbC5zZXNzaW9uLnYxLklncklkEhMKC3BsYXRm", "b3JtX2lkGAogASgHEhAKCGlncl9wYWlkGAsgASgIIkgKE0dhbWVTZXNzaW9u", "TG9jYXRpb24SEgoKaXBfYWRkcmVzcxgBIAEoCRIPCgdjb3VudHJ5GAIgASgN", "EgwKBGNpdHkYAyABKAkiegoFSWdySWQSQgoMZ2FtZV9hY2NvdW50GAEgASgL", "MiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGVI", "ABIVCgtleHRlcm5hbF9pZBgCIAEoB0gAEg4KBHV1aWQYAyABKAlIAEIGCgR0", "eXBlKmEKFlNlc3Npb25SZXN0cmljdGlvblR5cGUSDwoLVU5TUEVDSUZJRUQQ", "ABIUChBQQVJFTlRBTF9DT05UUk9MEAESFgoSR09WRVJOTUVOVF9DT05UUk9M", "EAISCAoEQ0FJUxADKs0CCh9TZXNzaW9uRGVzdHJ1Y3Rpb25SZWFzb25EZXRh",
				"aWxzEhEKDUFDQ09VTlRfTVVURUQQARIWChJCQVRUTEVfVEFHX0NIQU5HRUQQ", "AhIXChNCTkVUX0FDQ09VTlRfQkFOTkVEEAMSHQoZQk5FVF9BQ0NPVU5UX0ZM", "QUdfQ0hBTkdFRBAEEhMKD0NPVU5UUllfQ0hBTkdFRBAFEhQKEENVUlJFTkNZ", "X0NIQU5HRUQQBhIZChVHQU1FX0FDQ09VTlRfVU5MSU5LRUQQBxIYChRMRUdB", "TF9SRUdJT05fQ0hBTkdFRBAIEhgKFExFR0FMX0xPQ0FMRV9DSEFOR0VEEAkS", "EwoPTElDRU5TRV9DSEFOR0VEEAoSEAoMTkFNRV9DSEFOR0VEEAsSEgoOT1BU", "X0lOX0NIQU5HRUQQDBISCg5SRUdJT05fQ0hBTkdFRBANQgJIAQ=="
			}));
			SessionTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { AccountTypesReflection.Descriptor }, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(SessionRestrictionType),
				typeof(SessionDestructionReasonDetails)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SessionOptions), SessionOptions.Parser, new string[] { "Billing", "Presence" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionState), SessionState.Parser, new string[]
				{
					"Handle", "ClientAddress", "LastTickTime", "CreateTime", "ParentalControlsActive", "Location", "UsingIgrAddress", "HasBenefactor", "IgrId", "Deductible",
					"ExpireTimeMs", "MacAddress", "IgrPaid"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionIdentifier), SessionIdentifier.Parser, new string[] { "GameAccount", "SessionId", "AccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameSessionInfo), GameSessionInfo.Parser, new string[] { "StartTime", "Location", "HasBenefactor", "IsUsingIgr", "ParentalControlsActive", "StartTimeSec", "IgrId", "PlatformId", "IgrPaid" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameSessionLocation), GameSessionLocation.Parser, new string[] { "IpAddress", "Country", "City" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(IgrId), IgrId.Parser, new string[] { "GameAccount", "ExternalId", "Uuid" }, new string[] { "Type" }, null, null, null)
			}));
		}

		// Token: 0x04003B50 RID: 15184
		private static FileDescriptor descriptor;
	}
}
