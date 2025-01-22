using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003C3 RID: 963
	public static class SocialNetworkServiceReflection
	{
		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x00176008 File Offset: 0x00174208
		public static FileDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.descriptor;
			}
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00176020 File Offset: 0x00174220
		static SocialNetworkServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci5iZ3MvbG93L3BiL2NsaWVudC9zb2NpYWxfbmV0d29ya19zZXJ2aWNlLnBy", "b3RvEhNiZ3MucHJvdG9jb2wuc25zLnYxGiFiZ3MvbG93L3BiL2NsaWVudC9y", "cGNfdHlwZXMucHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L2FjY291bnRfdHlw", "ZXMucHJvdG8iHAoaR2V0RmFjZWJvb2tBdXRoQ29kZVJlcXVlc3QiWwobR2V0", "RmFjZWJvb2tBdXRoQ29kZVJlc3BvbnNlEg8KB2ZiX2NvZGUYASABKAkSGAoM", "cmVkaXJlY3RfdXJpGAIgASgJQgIYARIRCgVmYl9pZBgDIAEoCUICGAEi3gEK", "HUdldEZhY2Vib29rQm5ldEZyaWVuZHNSZXF1ZXN0EmoKFHByb2ZpbGVfcGlj", "dHVyZV90eXBlGAIgASgOMkUuYmdzLnByb3RvY29sLnNucy52MS5HZXRGYWNl", "Ym9va0JuZXRGcmllbmRzUmVxdWVzdC5Qcm9maWxlUGljdHVyZVR5cGU6BVNN", "QUxMEg0KBXRva2VuGAMgASgNIkIKElByb2ZpbGVQaWN0dXJlVHlwZRIJCgVT",
				"TUFMTBAAEgoKBk5PUk1BTBABEgkKBUxBUkdFEAISCgoGU1FVQVJFEAMiWAob", "R2V0RmFjZWJvb2tTZXR0aW5nc1Jlc3BvbnNlEg4KBmFwcF9pZBgBIAEoCRIU", "CgxyZWRpcmVjdF91cmkYAiABKAkSEwoLYXBpX3ZlcnNpb24YAyABKAkiJQoj", "R2V0RmFjZWJvb2tBY2NvdW50TGlua1N0YXR1c1JlcXVlc3QiYwokR2V0RmFj", "ZWJvb2tBY2NvdW50TGlua1N0YXR1c1Jlc3BvbnNlEhYKDmFjY291bnRfbGlu", "a2VkGAEgASgIEg0KBWZiX2lkGAIgASgJEhQKDGRpc3BsYXlfbmFtZRgDIAEo", "CSIbChlHZXRHb29nbGVBdXRoVG9rZW5SZXF1ZXN0IjIKGkdldEdvb2dsZUF1", "dGhUb2tlblJlc3BvbnNlEhQKDGFjY2Vzc190b2tlbhgBIAEoCSIuChlHZXRH", "b29nbGVTZXR0aW5nc1Jlc3BvbnNlEhEKCWNsaWVudF9pZBgBIAEoCSIjCiFH", "ZXRHb29nbGVBY2NvdW50TGlua1N0YXR1c1JlcXVlc3QiZQoiR2V0R29vZ2xl",
				"QWNjb3VudExpbmtTdGF0dXNSZXNwb25zZRIWCg5hY2NvdW50X2xpbmtlZBgB", "IAEoCBIRCglnb29nbGVfaWQYAiABKAkSFAoMZGlzcGxheV9uYW1lGAMgASgJ", "ItsBCiJGYWNlYm9va0JuZXRGcmllbmRMaXN0Tm90aWZpY2F0aW9uEhIKCmVy", "cm9yX2NvZGUYASABKA0SMwoIaWRlbnRpdHkYAiABKAsyIS5iZ3MucHJvdG9j", "b2wuYWNjb3VudC52MS5JZGVudGl0eRI8CgtmcmllbmRfbGlzdBgDIAMoCzIn", "LmJncy5wcm90b2NvbC5zbnMudjEuRmFjZWJvb2tCbmV0RnJpZW5kEhAKCGxp", "c3RfZW5kGAQgASgIEg0KBXRva2VuGAUgASgNEg0KBWZiX2lkGAYgASgJIq4B", "ChJGYWNlYm9va0JuZXRGcmllbmQSMwoHYm5ldF9pZBgBIAEoCzIiLmJncy5w", "cm90b2NvbC5hY2NvdW50LnYxLkFjY291bnRJZBINCgVmYl9pZBgCIAEoCRIR", "CglsYXN0X25hbWUYAyABKAkSEgoKZmlyc3RfbmFtZRgEIAEoCRIXCg9wcm9m",
				"aWxlX3BpY3R1cmUYBSABKAkSFAoMZGlzcGxheV9uYW1lGAYgASgJIkQKKkZh", "Y2Vib29rQm5ldEZyaWVuZExpc3ROb3RpZmljYXRpb25SZXNwb25zZRIWCghj", "b250aW51ZRgBIAEoCDoEdHJ1ZTK4BwoUU29jaWFsTmV0d29ya1NlcnZpY2US", "gAEKE0dldEZhY2Vib29rQXV0aENvZGUSLy5iZ3MucHJvdG9jb2wuc25zLnYx", "LkdldEZhY2Vib29rQXV0aENvZGVSZXF1ZXN0GjAuYmdzLnByb3RvY29sLnNu", "cy52MS5HZXRGYWNlYm9va0F1dGhDb2RlUmVzcG9uc2UiBoL5KwIIARJqChZH", "ZXRGYWNlYm9va0JuZXRGcmllbmRzEjIuYmdzLnByb3RvY29sLnNucy52MS5H", "ZXRGYWNlYm9va0JuZXRGcmllbmRzUmVxdWVzdBoULmJncy5wcm90b2NvbC5O", "b0RhdGEiBoL5KwIIAhJlChNHZXRGYWNlYm9va1NldHRpbmdzEhQuYmdzLnBy", "b3RvY29sLk5vRGF0YRowLmJncy5wcm90b2NvbC5zbnMudjEuR2V0RmFjZWJv",
				"b2tTZXR0aW5nc1Jlc3BvbnNlIgaC+SsCCAMSmwEKHEdldEZhY2Vib29rQWNj", "b3VudExpbmtTdGF0dXMSOC5iZ3MucHJvdG9jb2wuc25zLnYxLkdldEZhY2Vi", "b29rQWNjb3VudExpbmtTdGF0dXNSZXF1ZXN0GjkuYmdzLnByb3RvY29sLnNu", "cy52MS5HZXRGYWNlYm9va0FjY291bnRMaW5rU3RhdHVzUmVzcG9uc2UiBoL5", "KwIIBBJ9ChJHZXRHb29nbGVBdXRoVG9rZW4SLi5iZ3MucHJvdG9jb2wuc25z", "LnYxLkdldEdvb2dsZUF1dGhUb2tlblJlcXVlc3QaLy5iZ3MucHJvdG9jb2wu", "c25zLnYxLkdldEdvb2dsZUF1dGhUb2tlblJlc3BvbnNlIgaC+SsCCAUSYQoR", "R2V0R29vZ2xlU2V0dGluZ3MSFC5iZ3MucHJvdG9jb2wuTm9EYXRhGi4uYmdz", "LnByb3RvY29sLnNucy52MS5HZXRHb29nbGVTZXR0aW5nc1Jlc3BvbnNlIgaC", "+SsCCAYSlQEKGkdldEdvb2dsZUFjY291bnRMaW5rU3RhdHVzEjYuYmdzLnBy",
				"b3RvY29sLnNucy52MS5HZXRHb29nbGVBY2NvdW50TGlua1N0YXR1c1JlcXVl", "c3QaNy5iZ3MucHJvdG9jb2wuc25zLnYxLkdldEdvb2dsZUFjY291bnRMaW5r", "U3RhdHVzUmVzcG9uc2UiBoL5KwIIBxoygvkrKAomYm5ldC5wcm90b2NvbC5z", "bnMuU29jaWFsTmV0d29ya1NlcnZpY2WK+SsCEAEy8wEKFVNvY2lhbE5ldHdv", "cmtMaXN0ZW5lchKkAQogT25GYWNlYm9va0JuZXRGcmllbmRMaXN0UmVjZWl2", "ZWQSNy5iZ3MucHJvdG9jb2wuc25zLnYxLkZhY2Vib29rQm5ldEZyaWVuZExp", "c3ROb3RpZmljYXRpb24aPy5iZ3MucHJvdG9jb2wuc25zLnYxLkZhY2Vib29r", "Qm5ldEZyaWVuZExpc3ROb3RpZmljYXRpb25SZXNwb25zZSIGgvkrAggBGjOC", "+SspCidibmV0LnByb3RvY29sLnNucy5Tb2NpYWxOZXR3b3JrTGlzdGVuZXKK", "+SsCCAFCA4ABAA=="
			}));
			SocialNetworkServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GetFacebookAuthCodeRequest), GetFacebookAuthCodeRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetFacebookAuthCodeResponse), GetFacebookAuthCodeResponse.Parser, new string[] { "FbCode", "RedirectUri", "FbId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetFacebookBnetFriendsRequest), GetFacebookBnetFriendsRequest.Parser, new string[] { "ProfilePictureType", "Token" }, null, new Type[] { typeof(GetFacebookBnetFriendsRequest.Types.ProfilePictureType) }, null, null),
				new GeneratedClrTypeInfo(typeof(GetFacebookSettingsResponse), GetFacebookSettingsResponse.Parser, new string[] { "AppId", "RedirectUri", "ApiVersion" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetFacebookAccountLinkStatusRequest), GetFacebookAccountLinkStatusRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetFacebookAccountLinkStatusResponse), GetFacebookAccountLinkStatusResponse.Parser, new string[] { "AccountLinked", "FbId", "DisplayName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGoogleAuthTokenRequest), GetGoogleAuthTokenRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGoogleAuthTokenResponse), GetGoogleAuthTokenResponse.Parser, new string[] { "AccessToken" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGoogleSettingsResponse), GetGoogleSettingsResponse.Parser, new string[] { "ClientId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGoogleAccountLinkStatusRequest), GetGoogleAccountLinkStatusRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGoogleAccountLinkStatusResponse), GetGoogleAccountLinkStatusResponse.Parser, new string[] { "AccountLinked", "GoogleId", "DisplayName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FacebookBnetFriendListNotification), FacebookBnetFriendListNotification.Parser, new string[] { "ErrorCode", "Identity", "FriendList", "ListEnd", "Token", "FbId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FacebookBnetFriend), FacebookBnetFriend.Parser, new string[] { "BnetId", "FbId", "LastName", "FirstName", "ProfilePicture", "DisplayName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FacebookBnetFriendListNotificationResponse), FacebookBnetFriendListNotificationResponse.Parser, new string[] { "Continue" }, null, null, null, null)
			}));
		}

		// Token: 0x04002C21 RID: 11297
		private static FileDescriptor descriptor;
	}
}
