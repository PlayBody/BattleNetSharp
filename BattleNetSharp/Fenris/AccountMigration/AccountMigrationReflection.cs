using System;
using Fenris.Account;
using Fenris.Profile;
using Google.Protobuf.Reflection;

namespace Fenris.AccountMigration
{
	// Token: 0x020002CC RID: 716
	public static class AccountMigrationReflection
	{
		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x00122C10 File Offset: 0x00120E10
		public static FileDescriptor Descriptor
		{
			get
			{
				return AccountMigrationReflection.descriptor;
			}
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00122C28 File Offset: 0x00120E28
		static AccountMigrationReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZBY2NvdW50TWlncmF0aW9uLnByb3RvEhdGZW5yaXMuQWNjb3VudE1pZ3Jh", "dGlvbhoNQWNjb3VudC5wcm90bxoNUHJvZmlsZS5wcm90byKbAQoKUmVhZERh", "dGFWMRIPCgd2ZXJzaW9uGAEgASgNEj4KFXJlYWRfc2F2ZWRfZGVmaW5pdGlv", "bhgCIAEoCzIfLkZlbnJpcy5BY2NvdW50LlNhdmVkRGVmaW5pdGlvbhI8ChRy", "ZWFkX2FjY291bnRfcHJvZmlsZRgDIAEoCzIeLkZlbnJpcy5Qcm9maWxlLkFj", "Y291bnRQcm9maWxlIo0BCgtXcml0ZURhdGFWMhI/ChZ3cml0ZV9zYXZlZF9k", "ZWZpbml0aW9uGAEgASgLMh8uRmVucmlzLkFjY291bnQuU2F2ZWREZWZpbml0", "aW9uEj0KFXdyaXRlX2FjY291bnRfcHJvZmlsZRgCIAEoCzIeLkZlbnJpcy5Q", "cm9maWxlLkFjY291bnRQcm9maWxlImoKDU1pZ3JhdGlvbkRhdGESDwoHdmVy", "c2lvbhgBIAEoDRI9Cg13cml0ZV9kYXRhX1YyGAIgASgLMiQuRmVucmlzLkFj",
				"Y291bnRNaWdyYXRpb24uV3JpdGVEYXRhVjJIAEIJCgdtZXNzYWdl"
			}));
			AccountMigrationReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountReflection.Descriptor,
				ProfileReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ReadDataV1), ReadDataV1.Parser, new string[] { "Version", "ReadSavedDefinition", "ReadAccountProfile" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WriteDataV2), WriteDataV2.Parser, new string[] { "WriteSavedDefinition", "WriteAccountProfile" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MigrationData), MigrationData.Parser, new string[] { "Version", "WriteDataV2" }, new string[] { "Message" }, null, null, null)
			}));
		}

		// Token: 0x040021ED RID: 8685
		private static FileDescriptor descriptor;
	}
}
