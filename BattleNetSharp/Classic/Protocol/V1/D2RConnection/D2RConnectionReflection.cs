using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x0200076B RID: 1899
	public static class D2RConnectionReflection
	{
		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600AE5B RID: 44635 RVA: 0x002A7124 File Offset: 0x002A5324
		public static FileDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.descriptor;
			}
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x002A713C File Offset: 0x002A533C
		static D2RConnectionReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChhiZ3MvZDJyX2Nvbm5lY3Rpb24ucHJvdG8SImNsYXNzaWMucHJvdG9jb2wu", "djEuZDJyX2Nvbm5lY3Rpb24aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBl", "cy5wcm90byJCCgxMb2dpblJlcXVlc3QSDwoHcHJvZ3JhbRgCIAEoBRIPCgd2", "ZXJzaW9uGAMgASgJEhAKCHBsYXRmb3JtGAQgASgFIjYKDUxvZ2luUmVzcG9u", "c2USCwoDdXJsGAEgASgJEgsKA2tleRgCIAEoCRILCgN1bmsYAyABKAUiFwoH", "dW5rYm9keRIMCgR0ZXN0GAIgASgJInQKBkVudGl0eRIXCg9hY2NvdW5kX2lk", "X2hpZ2gYASABKAQSFgoOYWNjb3VuZF9pZF9sb3cYAiABKAQSHAoUZ2FtZV9h", "Y2NvdW50X2lkX2hpZ2gYAyABKAQSGwoTZ2FtZV9hY2NvdW50X2lkX2xvdxgE", "IAEoBCKKAQoIQXV0aEJvZHkSEwoLc2Vzc2lvbl9rZXkYASABKAwSDAoEemVy", "bxgCIAEoBRIQCghwbGF0Zm9ybRgEIAEoBRI6CgZlbnRpdHkYBiABKAsyKi5j",
				"bGFzc2ljLnByb3RvY29sLnYxLmQycl9jb25uZWN0aW9uLkVudGl0eRINCgV6", "ZXJvMhgIIAEoBSK7AQoLQXV0aFJlcXVlc3QSEwoLc2Vzc2lvbl9rZXkYASAB", "KAkSOgoEYm9keRgCIAEoCzIsLmNsYXNzaWMucHJvdG9jb2wudjEuZDJyX2Nv", "bm5lY3Rpb24uQXV0aEJvZHkSCwoDT1NJGAMgASgFEg8KB3ZlcnNpb24YBCAB", "KAkSDwoHYmFzZUtleRgFIAEoCRIRCgl0aGlydHkxMDAYBiABKAUSDAoEV242", "NBgHIAEoBRILCgNvbmUYCCABKAUiIwoMQXV0aFJlc3BvbnNlEhMKC3Nlc3Np", "b25fa2V5GAMgASgMIoECChJBdXRoU2Vzc2lvblJlcXVlc3QSEwoLc2Vzc2lv", "bl9rZXkYASABKAkSOgoEYm9keRgCIAEoCzIsLmNsYXNzaWMucHJvdG9jb2wu", "djEuZDJyX2Nvbm5lY3Rpb24uQXV0aEJvZHkSDwoHcHJvZ3JhbRgDIAEoDRIP", "Cgd2ZXJzaW9uGAQgASgJEg8KB2Jhc2VLZXkYBSABKAkSEQoJdGhpcnR5MTAw",
				"GAYgASgNEhAKCHBsYXRmb3JtGAcgASgNEgsKA29uZRgIIAEoDRILCgN1bmsY", "CSADKA0SDAoEdW5rMhgKIAEoCRIMCgR1bmszGAsgASgJEgwKBHVuazQYDCAB", "KAkikAEKE0F1dGhTZXNzaW9uUmVzcG9uc2USFAoMc2Vzc2lvbl90eXBlGAEg", "AygJEgwKBHVuazEYBCABKA0SDAoEdW5rMhgFIAEoDRIMCgR1bmszGAYgASgN", "EgwKBHVuazQYCCABKA0SDwoHY291bnRyeRgJIAEoCRIMCgR1bms1GAogASgN", "EgwKBHVuazYYCyABKA0iZAoNT2ZmbGluZUNvb2tpZRITCgttZXRob2RfbmFt", "ZRgBIAEoCRIWCg5zZXNzaW9uX2tleV82NBgCIAEoCRIVCg1zZXNzaW9uX2J5", "dGVzGAMgASgMEg8KB3Byb2dyYW0YBCABKA0iWQoUQ29va2llVXBkYXRlUmVz", "cG9uc2USQQoGY29va2llGAEgASgLMjEuY2xhc3NpYy5wcm90b2NvbC52MS5k", "MnJfY29ubmVjdGlvbi5PZmZsaW5lQ29va2llImUKFVNlc3Npb25VcGRhdGVS",
				"ZXNwb25zZRJMCgtzZXNzaW9uX2tleRgCIAEoCzI3LmNsYXNzaWMucHJvdG9j", "b2wudjEuZDJyX2Nvbm5lY3Rpb24uQXV0aFNlc3Npb25SZXNwb25zZTKZBQoV", "RDJyU2VydmljZXNDb25uZWN0aW9uEooBCgtBdXRoU2Vzc2lvbhI2LmNsYXNz", "aWMucHJvdG9jb2wudjEuZDJyX2Nvbm5lY3Rpb24uQXV0aFNlc3Npb25SZXF1", "ZXN0GjcuY2xhc3NpYy5wcm90b2NvbC52MS5kMnJfY29ubmVjdGlvbi5BdXRo", "U2Vzc2lvblJlc3BvbnNlIgqC+SsGCO6eiugOEmwKDVNlc3Npb25VcGRhdGUS", "FC5iZ3MucHJvdG9jb2wuTm9EYXRhGjkuY2xhc3NpYy5wcm90b2NvbC52MS5k", "MnJfY29ubmVjdGlvbi5TZXNzaW9uVXBkYXRlUmVzcG9uc2UiCoL5KwYIz5SJ", "9AYSgQEKEFNlc3Npb25EZXN0cm95ZWQSLy5jbGFzc2ljLnByb3RvY29sLnYx", "LmQycl9jb25uZWN0aW9uLkF1dGhSZXF1ZXN0GjAuY2xhc3NpYy5wcm90b2Nv",
				"bC52MS5kMnJfY29ubmVjdGlvbi5BdXRoUmVzcG9uc2UiCoL5KwYIl9GUgw8S", "agoMQ29va2llVXBkYXRlEhQuYmdzLnByb3RvY29sLk5vRGF0YRo4LmNsYXNz", "aWMucHJvdG9jb2wudjEuZDJyX2Nvbm5lY3Rpb24uQ29va2llVXBkYXRlUmVz", "cG9uc2UiCoL5KwYI/Yua1wQSPgoEUGluZxIULmJncy5wcm90b2NvbC5Ob0Rh", "dGEaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgqC+SsGCPb/yYgPEkMKClNlcnZl", "clBpbmcSFC5iZ3MucHJvdG9jb2wuTm9EYXRhGhQuYmdzLnByb3RvY29sLk5v", "RGF0YSIJgvkrBQjl85IyGhCC+SsMCgoweEVFQjZBQjIy"
			}));
			D2RConnectionReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LoginRequest), LoginRequest.Parser, new string[] { "Program", "Version", "Platform" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LoginResponse), LoginResponse.Parser, new string[] { "Url", "Key", "Unk" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(unkbody), unkbody.Parser, new string[] { "Test" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Entity), Entity.Parser, new string[] { "AccoundIdHigh", "AccoundIdLow", "GameAccountIdHigh", "GameAccountIdLow" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AuthBody), AuthBody.Parser, new string[] { "SessionKey", "Zero", "Platform", "Entity", "Zero2" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AuthRequest), AuthRequest.Parser, new string[] { "SessionKey", "Body", "OSI", "Version", "BaseKey", "Thirty100", "Wn64", "One" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AuthResponse), AuthResponse.Parser, new string[] { "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AuthSessionRequest), AuthSessionRequest.Parser, new string[]
				{
					"SessionKey", "Body", "Program", "Version", "BaseKey", "Thirty100", "Platform", "One", "Unk", "Unk2",
					"Unk3", "Unk4"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AuthSessionResponse), AuthSessionResponse.Parser, new string[] { "SessionType", "Unk1", "Unk2", "Unk3", "Unk4", "Country", "Unk5", "Unk6" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(OfflineCookie), OfflineCookie.Parser, new string[] { "MethodName", "SessionKey64", "SessionBytes", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CookieUpdateResponse), CookieUpdateResponse.Parser, new string[] { "Cookie" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionUpdateResponse), SessionUpdateResponse.Parser, new string[] { "SessionKey" }, null, null, null, null)
			}));
		}

		// Token: 0x04004E91 RID: 20113
		private static FileDescriptor descriptor;
	}
}
