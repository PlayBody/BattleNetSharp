using System;
using Bgs.Protocol.Account.V2;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B7 RID: 1463
	public static class PresenceTypesReflection
	{
		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x06008ADF RID: 35551 RVA: 0x0021B5AC File Offset: 0x002197AC
		public static FileDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.descriptor;
			}
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x0021B5C4 File Offset: 0x002197C4
		static PresenceTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjRiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3ByZXNlbmNlX3R5", "cGVzLnByb3RvEhhiZ3MucHJvdG9jb2wucHJlc2VuY2UudjIaOWJncy9sb3cv", "cGIvY2xpZW50L2FwaS9jbGllbnQvdjIvZ2FtZV9hY2NvdW50X2hhbmRsZS5w", "cm90bxo1YmdzL2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9hdHRyaWJ1", "dGVfdHlwZXMucHJvdG8iTAoPUmljaFByZXNlbmNlS2V5EhAKCHRpdGxlX2lk", "GAEgASgNEg4KBnN0cmVhbRgCIAEoBxIXCg9sb2NhbGl6YXRpb25faWQYAyAB", "KA0iVQoQUHJlc2VuY2VGaWVsZEtleRIQCgh0aXRsZV9pZBgBIAEoDRINCgVn", "cm91cBgCIAEoDRINCgVmaWVsZBgDIAEoDRIRCgl1bmlxdWVfaWQYBCABKAQi", "mwEKDVByZXNlbmNlRmllbGQSNwoDa2V5GAEgASgLMiouYmdzLnByb3RvY29s", "LnByZXNlbmNlLnYyLlByZXNlbmNlRmllbGRLZXkSJwoFdmFsdWUYAiABKAsy",
				"GC5iZ3MucHJvdG9jb2wudjIuVmFyaWFudBIPCgdkZWxldGVkGAMgASgIEhcK", "D3VwZGF0ZWRfdGltZV91cxgEIAEoBCK7AQoSUHJlc2VuY2VGaWVsZFN0YXRl", "EhIKCmFjY291bnRfaWQYASABKAQSQAoMZ2FtZV9hY2NvdW50GAIgASgLMiou", "YmdzLnByb3RvY29sLmFjY291bnQudjIuR2FtZUFjY291bnRIYW5kbGUSNwoG", "ZmllbGRzGAMgAygLMicuYmdzLnByb3RvY29sLnByZXNlbmNlLnYyLlByZXNl", "bmNlRmllbGQSFgoOb2xkZXN0X3RpbWVfdXMYBCABKAQihwEKE1ByZXNlbmNl", "RmllbGRVcGRhdGUSNwoDa2V5GAEgASgLMiouYmdzLnByb3RvY29sLnByZXNl", "bmNlLnYyLlByZXNlbmNlRmllbGRLZXkSJwoFdmFsdWUYAiABKAsyGC5iZ3Mu", "cHJvdG9jb2wudjIuVmFyaWFudBIOCgZkZWxldGUYAyABKAgidQoZUHJlc2Vu", "Y2VPbmxpbmVHYW1lQWNjb3VudBJACgxnYW1lX2FjY291bnQYASABKAsyKi5i",
				"Z3MucHJvdG9jb2wuYWNjb3VudC52Mi5HYW1lQWNjb3VudEhhbmRsZRIWCg5v", "bmxpbmVfdGltZV91cxgCIAEoBCJ4CiNQcmVzZW5jZU9ubGluZUdhbWVBY2Nv", "dW50RmllbGRWYWx1ZRJRChRvbmxpbmVfZ2FtZV9hY2NvdW50cxgBIAMoCzIz", "LmJncy5wcm90b2NvbC5wcmVzZW5jZS52Mi5QcmVzZW5jZU9ubGluZUdhbWVB", "Y2NvdW50IksKIlByZXNlbmNlRXh0ZXJuYWxJZGVudGl0eUZpZWxkVmFsdWUS", "EQoJdW5pcXVlX2lkGAEgASgJEhIKCmRpc3BsYXlfaWQYAiABKAkqcgoVUHJl", "c2VuY2VRdWVyeUJlaGF2aW9yEhsKF0JBVFRMRV9ORVRfQUNDT1VOVF9PTkxZ", "EAASHQoZSU5DTFVERV9TQU1FX0dBTUVfQUNDT1VOVBABEh0KGUlOQ0xVREVf", "QUxMX0dBTUVfQUNDT1VOVFMQAipDChVQcmVzZW5jZUFjY291bnRTdGF0dXMS", "CwoHT0ZGTElORRAAEgoKBk9OTElORRABEggKBEFXQVkQAhIHCgNETkQQAw=="
			}));
			PresenceTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				GameAccountHandleReflection.Descriptor,
				AttributeTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(PresenceQueryBehavior),
				typeof(PresenceAccountStatus)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(RichPresenceKey), RichPresenceKey.Parser, new string[] { "TitleId", "Stream", "LocalizationId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceFieldKey), PresenceFieldKey.Parser, new string[] { "TitleId", "Group", "Field", "UniqueId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceField), PresenceField.Parser, new string[] { "Key", "Value", "Deleted", "UpdatedTimeUs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceFieldState), PresenceFieldState.Parser, new string[] { "AccountId", "GameAccount", "Fields", "OldestTimeUs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceFieldUpdate), PresenceFieldUpdate.Parser, new string[] { "Key", "Value", "Delete" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceOnlineGameAccount), PresenceOnlineGameAccount.Parser, new string[] { "GameAccount", "OnlineTimeUs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceOnlineGameAccountFieldValue), PresenceOnlineGameAccountFieldValue.Parser, new string[] { "OnlineGameAccounts" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceExternalIdentityFieldValue), PresenceExternalIdentityFieldValue.Parser, new string[] { "UniqueId", "DisplayId" }, null, null, null, null)
			}));
		}

		// Token: 0x04003ED8 RID: 16088
		private static FileDescriptor descriptor;
	}
}
