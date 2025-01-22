using System;
using Bgs.Protocol.Account.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000626 RID: 1574
	public static class AuthenticationTypesReflection
	{
		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x00239A40 File Offset: 0x00237C40
		public static FileDescriptor Descriptor
		{
			get
			{
				return AuthenticationTypesReflection.descriptor;
			}
		}

		// Token: 0x060092FD RID: 37629 RVA: 0x00239A58 File Offset: 0x00237C58
		static AuthenticationTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F1dGhlbnRpY2F0", "aW9uX3R5cGVzLnByb3RvEiViZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24u", "djIuY2xpZW50GiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8a", "OWJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvZ2FtZV9hY2NvdW50", "X2hhbmRsZS5wcm90byKDAQoMTG9nb25PcHRpb25zEhIKCmF1dGhfdG9rZW4Y", "ASABKAwSEgoKdXNlcl9hZ2VudBgCIAEoCRIRCglkZXZpY2VfaWQYAyABKAkS", "DwoFZW1haWwYCiABKAlIABIWCgxwaG9uZV9udW1iZXIYCyABKAlIAEIPCg1h", "ZGRpdGlvbmFsX2lkIr8BCgtMb2dvblJlY29yZBISCgphY2NvdW50X2lkGAEg", "ASgEEkAKDGdhbWVfYWNjb3VudBgCIAMoCzIqLmJncy5wcm90b2NvbC5hY2Nv", "dW50LnYyLkdhbWVBY2NvdW50SGFuZGxlEhIKCmJhdHRsZV90YWcYAyABKAkS",
				"FQoNZ2VvaXBfY291bnRyeRgEIAEoCRITCgtzZXNzaW9uX2tleRgFIAEoDBIa", "ChJlbXBsb3llZV9vbmx5X21vZGUYBiABKAgiZwoPTG9nb25RdWV1ZVN0YXRl", "EhAKCHBvc2l0aW9uGAEgASgNEiMKG2VzdGltYXRlZF9xdWV1ZV9leGl0X3Rp", "bWVfcxgCIAEoBBIdChVleGl0X3RpbWVfZGV2aWF0aW9uX3MYAyABKARCA4AB", "AA=="
			}));
			AuthenticationTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				GameAccountHandleReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LogonOptions), LogonOptions.Parser, new string[] { "AuthToken", "UserAgent", "DeviceId", "Email", "PhoneNumber" }, new string[] { "AdditionalId" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogonRecord), LogonRecord.Parser, new string[] { "AccountId", "GameAccount", "BattleTag", "GeoipCountry", "SessionKey", "EmployeeOnlyMode" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogonQueueState), LogonQueueState.Parser, new string[] { "Position", "EstimatedQueueExitTimeS", "ExitTimeDeviationS" }, null, null, null, null)
			}));
		}

		// Token: 0x04004260 RID: 16992
		private static FileDescriptor descriptor;
	}
}
