using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000620 RID: 1568
	public static class AuthenticationServiceReflection
	{
		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x06009292 RID: 37522 RVA: 0x0023835C File Offset: 0x0023655C
		public static FileDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.descriptor;
			}
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00238374 File Offset: 0x00236574
		static AuthenticationServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjxiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL2F1dGhlbnRpY2F0", "aW9uX3NlcnZpY2UucHJvdG8SJWJncy5wcm90b2NvbC5hdXRoZW50aWNhdGlv", "bi52Mi5jbGllbnQaOmJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIv", "YXV0aGVudGljYXRpb25fdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50", "L3JwY190eXBlcy5wcm90byKrAQoMTG9nb25SZXF1ZXN0EhAKCHRpdGxlX2lk", "GAEgASgNEhAKCHBsYXRmb3JtGAIgASgJEg4KBmxvY2FsZRgDIAEoCRIbChNh", "cHBsaWNhdGlvbl92ZXJzaW9uGAQgASgNEkoKDWxvZ29uX29wdGlvbnMYCiAB", "KAsyMy5iZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24udjIuY2xpZW50Lkxv", "Z29uT3B0aW9ucyIsChZWZXJpZnlBdXRoVG9rZW5SZXF1ZXN0EhIKCmF1dGhf", "dG9rZW4YASABKAwiLAoYR2VuZXJhdGVBdXRoVG9rZW5SZXF1ZXN0EhAKCHRp",
				"dGxlX2lkGAEgASgNIi8KGUdlbmVyYXRlQXV0aFRva2VuUmVzcG9uc2USEgoK", "YXV0aF90b2tlbhgBIAEoDDLIAwoVQXV0aGVudGljYXRpb25TZXJ2aWNlEloK", "BUxvZ29uEjMuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0aW9uLnYyLmNsaWVu", "dC5Mb2dvblJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAES", "bgoPVmVyaWZ5QXV0aFRva2VuEj0uYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0", "aW9uLnYyLmNsaWVudC5WZXJpZnlBdXRoVG9rZW5SZXF1ZXN0GhQuYmdzLnBy", "b3RvY29sLk5vRGF0YSIGgvkrAggCEp4BChFHZW5lcmF0ZUF1dGhUb2tlbhI/", "LmJncy5wcm90b2NvbC5hdXRoZW50aWNhdGlvbi52Mi5jbGllbnQuR2VuZXJh", "dGVBdXRoVG9rZW5SZXF1ZXN0GkAuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0", "aW9uLnYyLmNsaWVudC5HZW5lcmF0ZUF1dGhUb2tlblJlc3BvbnNlIgaC+SsC",
				"CAMaQoL5Kz4KPGJuZXQucHJvdG9jb2wuYXV0aGVudGljYXRpb24udjIuY2xp", "ZW50LkF1dGhlbnRpY2F0aW9uU2VydmljZUIDgAEA"
			}));
			AuthenticationServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AuthenticationTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(LogonRequest), LogonRequest.Parser, new string[] { "TitleId", "Platform", "Locale", "ApplicationVersion", "LogonOptions" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VerifyAuthTokenRequest), VerifyAuthTokenRequest.Parser, new string[] { "AuthToken" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenerateAuthTokenRequest), GenerateAuthTokenRequest.Parser, new string[] { "TitleId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenerateAuthTokenResponse), GenerateAuthTokenResponse.Parser, new string[] { "AuthToken" }, null, null, null, null)
			}));
		}

		// Token: 0x04004235 RID: 16949
		private static FileDescriptor descriptor;
	}
}
