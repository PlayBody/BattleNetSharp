using System;
using Google.Protobuf.Reflection;

// Token: 0x0200000D RID: 13
public static class BusMessageReflection
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000042 RID: 66 RVA: 0x00002F00 File Offset: 0x00001100
	public static FileDescriptor Descriptor
	{
		get
		{
			return BusMessageReflection.descriptor;
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002F18 File Offset: 0x00001118
	static BusMessageReflection()
	{
		byte[] array = Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBCdXNNZXNzYWdlLnByb3RvIpgICgpCdXNNZXNzYWdlEhAKCHVuaXF1ZWlk", "GAEgAigJEhUKDXNvdXJjZV9zeXN0ZW0YAiACKAkSFQoNc291cmNlX21vZHVs", "ZRgDIAIoCRIOCgZkb21haW4YBCABKAkSDgoGam9pbmVkGAUgASgIEhUKDXRh", "cmdldF9zeXN0ZW0YBiABKAkSFQoNdGFyZ2V0X21vZHVsZRgHIAEoCRIWCg5z", "b3VyY2Vfc2Vzc2lvbhgIIAEoCRIXCg9zb3VyY2VfdXNlcm5hbWUYCSABKAkS", "GgoScmVmZXJlbmNlX3VuaXF1ZWlkGAogASgJEhIKCnNvdXJjZV9waWQYCyAB", "KA0SFgoOdGFyZ2V0X3Nlc3Npb24YDSABKAkSFwoPdGFyZ2V0X3VzZXJuYW1l", "GA4gASgJEiIKCGJ1c19wZWVyGA8gAygLMhAuQnVzTWVzc2FnZS5QZWVyEiQK", "B2dlbmVyaWMYFCABKAsyEy5CdXNNZXNzYWdlLkdlbmVyaWMSIgoGc3RhdHVz", "GBUgASgLMhIuQnVzTWVzc2FnZS5TdGF0dXMSPAoTZW5jcnlwdGVkQnVzTWVz",
			"c2FnZRgWIAEoCzIfLkJ1c01lc3NhZ2UuRW5jcnlwdGVkQnVzTWVzc2FnZRI1", "Cg9lbmNyeXB0aW9uc2V0dXAYyAEgASgLMhsuQnVzTWVzc2FnZS5FbmNyeXB0", "aW9uU2V0dXASGQoQcHJvdG9jb2xfdmVyc2lvbhisAiABKA0SGwoSc291cmNl", "X2lzX2VsZXZhdGVkGK0CIAEoCBolCgdHZW5lcmljEgwKBHR5cGUYASABKA0S", "DAoEZGF0YRgCIAEoDBqhAQoTRW5jcnlwdGVkQnVzTWVzc2FnZRJCCgR0eXBl", "GAEgASgOMi4uQnVzTWVzc2FnZS5FbmNyeXB0ZWRCdXNNZXNzYWdlLkVuY3J5", "cHRpb25UeXBlOgROT05FEgwKBGRhdGEYAiABKAwSCgoCaXYYAyABKAwiLAoO", "RW5jcnlwdGlvblR5cGUSCAoETk9ORRABEgcKA1JTQRACEgcKA0FFUxADGnQK", "BlN0YXR1cxIvCgRjb2RlGAEgASgOMhcuQnVzTWVzc2FnZS5TdGF0dXMuQ29k", "ZToIUmVjZWl2ZWQiOQoEQ29kZRIMCghSZWNlaXZlZBABEg0KCUNvbXBsZXRl",
			"ZBACEhQKEEFkZHJlc3NDb2xsaXNpb24QAxprCgRQZWVyEg4KBnN5c3RlbRgB", "IAIoCRIOCgZtb2R1bGUYAiACKAkSDwoHc2Vzc2lvbhgDIAEoCRIQCgh1c2Vy", "bmFtZRgEIAEoCRILCgNwaWQYBSABKA0SEwoLaXNfZWxldmF0ZWQYBiABKAga", "IQoPRW5jcnlwdGlvblNldHVwEg4KBkFFU0tleRgBIAEoDA=="
		}));
		BusMessageReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BusMessage), BusMessage.Parser, new string[]
			{
				"Uniqueid", "SourceSystem", "SourceModule", "Domain", "Joined", "TargetSystem", "TargetModule", "SourceSession", "SourceUsername", "ReferenceUniqueid",
				"SourcePid", "TargetSession", "TargetUsername", "BusPeer", "Generic", "Status", "EncryptedBusMessage", "Encryptionsetup", "ProtocolVersion", "SourceIsElevated"
			}, null, null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BusMessage.Types.Generic), BusMessage.Types.Generic.Parser, new string[] { "Type", "Data" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BusMessage.Types.EncryptedBusMessage), BusMessage.Types.EncryptedBusMessage.Parser, new string[] { "Type", "Data", "Iv" }, null, new Type[] { typeof(BusMessage.Types.EncryptedBusMessage.Types.EncryptionType) }, null, null),
				new GeneratedClrTypeInfo(typeof(BusMessage.Types.Status), BusMessage.Types.Status.Parser, new string[] { "Code" }, null, new Type[] { typeof(BusMessage.Types.Status.Types.Code) }, null, null),
				new GeneratedClrTypeInfo(typeof(BusMessage.Types.Peer), BusMessage.Types.Peer.Parser, new string[] { "System", "Module", "Session", "Username", "Pid", "IsElevated" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BusMessage.Types.EncryptionSetup), BusMessage.Types.EncryptionSetup.Parser, new string[] { "AESKey" }, null, null, null, null)
			})
		}));
	}

	// Token: 0x0400001A RID: 26
	private static FileDescriptor descriptor;
}
