using System;
using Bgs.Protocol.Account.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000565 RID: 1381
	public static class SessionTypesReflection
	{
		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x06008509 RID: 34057 RVA: 0x00205320 File Offset: 0x00203520
		public static FileDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.descriptor;
			}
		}

		// Token: 0x0600850A RID: 34058 RVA: 0x00205338 File Offset: 0x00203538
		static SessionTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjNiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3Nlc3Npb25fdHlw", "ZXMucHJvdG8SHmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudBo5Ymdz", "L2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9nYW1lX2FjY291bnRfaGFu", "ZGxlLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8i", "JAoNQ3JlYXRlT3B0aW9ucxITCgttYWNfYWRkcmVzcxgBIAEoCSIxCgxTdGF0", "ZU9wdGlvbnMSDwoHYmlsbGluZxgBIAEoCBIQCghwcmVzZW5jZRgCIAEoCCKQ", "AQoOUmVzdG9yZU9wdGlvbnMSFgoOY2xpZW50X2FkZHJlc3MYASABKAkSEwoL", "bWFjX2FkZHJlc3MYAiABKAkSEAoIcGxhdGZvcm0YAyABKAkSDgoGbG9jYWxl", "GAQgASgJEhsKE2FwcGxpY2F0aW9uX3ZlcnNpb24YBSABKAUSEgoKdXNlcl9h", "Z2VudBgGIAEoCSJ2CglTZXNzaW9uSWQSEgoKYWNjb3VudF9pZBgBIAEoBBJA",
				"CgxnYW1lX2FjY291bnQYAiABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52", "Mi5HYW1lQWNjb3VudEhhbmRsZRITCgtpbnN0YW5jZV9pZBgDIAEoCSL2AQoM", "QmlsbGluZ1N0YXRlEkMKCmJlbmVmYWN0b3IYASABKAsyLy5iZ3MucHJvdG9j", "b2wuc2Vzc2lvbi52Mi5jbGllbnQuQmVuZWZhY3RvclN0YXRlEhcKD2JpbGxp", "bmdfZW5hYmxlZBgCIAEoCBIUCgxmcmVlX3Nlc3Npb24YAyABKAgSHwoXdXNp", "bmdfbGlmZV90aW1lX2xpY2Vuc2UYBCABKAgSGgoSdXNpbmdfc3Vic2NyaXB0", "aW9uGAUgASgIEh0KFWNvbnN1bXB0aW9uX2dhbWVfdGltZRgGIAEoDRIWCg5l", "eHBpcmVfdGltZV9tcxgHIAEoBCJTChFTZXNzaW9uQ29uc3RyYWludBIgChhw", "YXJlbnRhbF9jb250cm9sc19hY3RpdmUYASABKAgSHAoUbmV4dF9wY19raWNr", "X3RpbWVfbXMYAiABKAQi6wEKDFNlc3Npb25TdGF0ZRI9CgpzZXNzaW9uX2lk",
				"GAEgASgLMikuYmdzLnByb3RvY29sLnNlc3Npb24udjIuY2xpZW50LlNlc3Np", "b25JZBIWCg5jcmVhdGVfdGltZV9tcxgCIAEoBBI9CgdiaWxsaW5nGAMgASgL", "MiwuYmdzLnByb3RvY29sLnNlc3Npb24udjIuY2xpZW50LkJpbGxpbmdTdGF0", "ZRJFCgpjb25zdHJhaW50GAQgASgLMjEuYmdzLnByb3RvY29sLnNlc3Npb24u", "djIuY2xpZW50LlNlc3Npb25Db25zdHJhaW50Ij0KDEJlbmVmYWN0b3JJZBIO", "CgR1dWlkGAEgASgJSAASFQoLZXh0ZXJuYWxfaWQYAiABKA1IAEIGCgR0eXBl", "IpgBCg9CZW5lZmFjdG9yU3RhdGUSQwoNYmVuZWZhY3Rvcl9pZBgBIAEoCzIs", "LmJncy5wcm90b2NvbC5zZXNzaW9uLnYyLmNsaWVudC5CZW5lZmFjdG9ySWQS", "GwoTcmVnaXN0ZXJlZF9sb2NhdGlvbhgCIAEoCBIRCglhY3RpdmF0ZWQYAyAB", "KAgSEAoIaWdyX3BhaWQYBCABKAgifAoQU2Vzc2lvblZhcmlhYmxlcxIaChJj",
				"cmVhdGlvbl90aW1lb3V0X3MYASABKA0SKQohcmVjb21tZW5kZWRfbWFya19h", "bGl2ZV9pbnRlcnZhbF9zGAIgASgNEiEKGW1heF9tYXJrX2FsaXZlX2ludGVy", "dmFsX3MYAyABKA0iLwoKU2Vzc2lvbktleRILCgNrZXkYASABKAwSFAoMZXhw", "aXJhdGlvbl9zGAIgASgEKsUBChZTZXNzaW9uUmVzdHJpY3Rpb25UeXBlEigK", "JFNFU1NJT05fUkVTVFJJQ1RJT05fVFlQRV9VTlNQRUNJRklFRBAAEi0KKVNF", "U1NJT05fUkVTVFJJQ1RJT05fVFlQRV9QQVJFTlRBTF9DT05UUk9MEAESLwor", "U0VTU0lPTl9SRVNUUklDVElPTl9UWVBFX0dPVkVSTk1FTlRfQ09OVFJPTBAC", "EiEKHVNFU1NJT05fUkVTVFJJQ1RJT05fVFlQRV9DQUlTEAMqzQIKH1Nlc3Np", "b25EZXN0cnVjdGlvblN0YXR1c0RldGFpbHMSEQoNQUNDT1VOVF9NVVRFRBAB", "EhYKEkJBVFRMRV9UQUdfQ0hBTkdFRBACEhcKE0JORVRfQUNDT1VOVF9CQU5O",
				"RUQQAxIdChlCTkVUX0FDQ09VTlRfRkxBR19DSEFOR0VEEAQSEwoPQ09VTlRS", "WV9DSEFOR0VEEAUSFAoQQ1VSUkVOQ1lfQ0hBTkdFRBAGEhkKFUdBTUVfQUND", "T1VOVF9VTkxJTktFRBAHEhgKFExFR0FMX1JFR0lPTl9DSEFOR0VEEAgSGAoU", "TEVHQUxfTE9DQUxFX0NIQU5HRUQQCRITCg9MSUNFTlNFX0NIQU5HRUQQChIQ", "CgxOQU1FX0NIQU5HRUQQCxISCg5PUFRfSU5fQ0hBTkdFRBAMEhIKDlJFR0lP", "Tl9DSEFOR0VEEA1CA4ABAA=="
			}));
			SessionTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				GameAccountHandleReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(SessionRestrictionType),
				typeof(SessionDestructionStatusDetails)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CreateOptions), CreateOptions.Parser, new string[] { "MacAddress" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StateOptions), StateOptions.Parser, new string[] { "Billing", "Presence" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RestoreOptions), RestoreOptions.Parser, new string[] { "ClientAddress", "MacAddress", "Platform", "Locale", "ApplicationVersion", "UserAgent" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionId), SessionId.Parser, new string[] { "AccountId", "GameAccount", "InstanceId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BillingState), BillingState.Parser, new string[] { "Benefactor", "BillingEnabled", "FreeSession", "UsingLifeTimeLicense", "UsingSubscription", "ConsumptionGameTime", "ExpireTimeMs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionConstraint), SessionConstraint.Parser, new string[] { "ParentalControlsActive", "NextPcKickTimeMs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionState), SessionState.Parser, new string[] { "SessionId", "CreateTimeMs", "Billing", "Constraint" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BenefactorId), BenefactorId.Parser, new string[] { "Uuid", "ExternalId" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(BenefactorState), BenefactorState.Parser, new string[] { "BenefactorId", "RegisteredLocation", "Activated", "IgrPaid" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionVariables), SessionVariables.Parser, new string[] { "CreationTimeoutS", "RecommendedMarkAliveIntervalS", "MaxMarkAliveIntervalS" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionKey), SessionKey.Parser, new string[] { "Key", "ExpirationS" }, null, null, null, null)
			}));
		}

		// Token: 0x04003C4A RID: 15434
		private static FileDescriptor descriptor;
	}
}
