using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006CB RID: 1739
	public static class ChannelOwnerServiceReflection
	{
		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600A096 RID: 41110 RVA: 0x00270F8C File Offset: 0x0026F18C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.descriptor;
			}
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x00270FA4 File Offset: 0x0026F1A4
		static ChannelOwnerServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci1iZ3MvbG93L3BiL2NsaWVudC9jaGFubmVsX293bmVyX3NlcnZpY2UucHJv", "dG8SF2Jncy5wcm90b2NvbC5jaGFubmVsLnYxGiRiZ3MvbG93L3BiL2NsaWVu", "dC9lbnRpdHlfdHlwZXMucHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L2NoYW5u", "ZWxfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5w", "cm90byLDAQoUQ3JlYXRlQ2hhbm5lbFJlcXVlc3QSLgoOYWdlbnRfaWRlbnRp", "dHkYASABKAsyFi5iZ3MucHJvdG9jb2wuSWRlbnRpdHkSPAoNY2hhbm5lbF9z", "dGF0ZRgDIAEoCzIlLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkNoYW5uZWxT", "dGF0ZRIqCgpjaGFubmVsX2lkGAQgASgLMhYuYmdzLnByb3RvY29sLkVudGl0", "eUlkEhEKCW9iamVjdF9pZBgFIAEoBCJWChVDcmVhdGVDaGFubmVsUmVzcG9u", "c2USEQoJb2JqZWN0X2lkGAEgAigEEioKCmNoYW5uZWxfaWQYAiABKAsyFi5i",
				"Z3MucHJvdG9jb2wuRW50aXR5SWQigwEKEkpvaW5DaGFubmVsUmVxdWVzdBIu", "Cg5hZ2VudF9pZGVudGl0eRgBIAEoCzIWLmJncy5wcm90b2NvbC5JZGVudGl0", "eRIqCgpjaGFubmVsX2lkGAMgAigLMhYuYmdzLnByb3RvY29sLkVudGl0eUlk", "EhEKCW9iamVjdF9pZBgEIAIoBCJyChNKb2luQ2hhbm5lbFJlc3BvbnNlEhEK", "CW9iamVjdF9pZBgBIAEoBBIdCg5hbHJlYWR5X21lbWJlchgEIAEoCDoFZmFs", "c2USKQoJbWVtYmVyX2lkGAUgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlk", "IrIBChdTdWJzY3JpYmVDaGFubmVsUmVxdWVzdBIoCghhZ2VudF9pZBgBIAEo", "CzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIqCgpjaGFubmVsX2lkGAIgAigL", "MhYuYmdzLnByb3RvY29sLkVudGl0eUlkEhEKCW9iamVjdF9pZBgDIAIoBBIu", "Cg5hZ2VudF9pZGVudGl0eRgEIAEoCzIWLmJncy5wcm90b2NvbC5JZGVudGl0",
				"eSItChhTdWJzY3JpYmVDaGFubmVsUmVzcG9uc2USEQoJb2JqZWN0X2lkGAEg", "ASgEIoQBChNMaXN0Q2hhbm5lbHNSZXF1ZXN0Ei4KDmFnZW50X2lkZW50aXR5", "GAEgASgLMhYuYmdzLnByb3RvY29sLklkZW50aXR5Ej0KB29wdGlvbnMYAiAC", "KAsyLC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5MaXN0Q2hhbm5lbHNPcHRp", "b25zIlQKFExpc3RDaGFubmVsc1Jlc3BvbnNlEjwKB2NoYW5uZWwYASADKAsy", "Ky5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5DaGFubmVsRGVzY3JpcHRpb24i", "bQoVR2V0Q2hhbm5lbEluZm9SZXF1ZXN0EigKCGFnZW50X2lkGAEgASgLMhYu", "YmdzLnByb3RvY29sLkVudGl0eUlkEioKCmNoYW5uZWxfaWQYAiACKAsyFi5i", "Z3MucHJvdG9jb2wuRW50aXR5SWQiVAoWR2V0Q2hhbm5lbEluZm9SZXNwb25z", "ZRI6CgxjaGFubmVsX2luZm8YASABKAsyJC5iZ3MucHJvdG9jb2wuY2hhbm5l",
				"bC52MS5DaGFubmVsSW5mbzKgBQoTQ2hhbm5lbE93bmVyU2VydmljZRJ2Cg1D", "cmVhdGVDaGFubmVsEi0uYmdzLnByb3RvY29sLmNoYW5uZWwudjEuQ3JlYXRl", "Q2hhbm5lbFJlcXVlc3QaLi5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5DcmVh", "dGVDaGFubmVsUmVzcG9uc2UiBoL5KwIIAhJwCgtKb2luQ2hhbm5lbBIrLmJn", "cy5wcm90b2NvbC5jaGFubmVsLnYxLkpvaW5DaGFubmVsUmVxdWVzdBosLmJn", "cy5wcm90b2NvbC5jaGFubmVsLnYxLkpvaW5DaGFubmVsUmVzcG9uc2UiBoL5", "KwIIAxJzCgxMaXN0Q2hhbm5lbHMSLC5iZ3MucHJvdG9jb2wuY2hhbm5lbC52", "MS5MaXN0Q2hhbm5lbHNSZXF1ZXN0Gi0uYmdzLnByb3RvY29sLmNoYW5uZWwu", "djEuTGlzdENoYW5uZWxzUmVzcG9uc2UiBoL5KwIIBBJ5Cg5HZXRDaGFubmVs", "SW5mbxIuLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkdldENoYW5uZWxJbmZv",
				"UmVxdWVzdBovLmJncy5wcm90b2NvbC5jaGFubmVsLnYxLkdldENoYW5uZWxJ", "bmZvUmVzcG9uc2UiBoL5KwIIBRJ/ChBTdWJzY3JpYmVDaGFubmVsEjAuYmdz", "LnByb3RvY29sLmNoYW5uZWwudjEuU3Vic2NyaWJlQ2hhbm5lbFJlcXVlc3Qa", "MS5iZ3MucHJvdG9jb2wuY2hhbm5lbC52MS5TdWJzY3JpYmVDaGFubmVsUmVz", "cG9uc2UiBoL5KwIIBhougvkrJAoiYm5ldC5wcm90b2NvbC5jaGFubmVsLkNo", "YW5uZWxPd25lcor5KwIQAUIFSAGAAQA="
			}));
			ChannelOwnerServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				EntityTypesReflection.Descriptor,
				ChannelTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CreateChannelRequest), CreateChannelRequest.Parser, new string[] { "AgentIdentity", "ChannelState", "ChannelId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateChannelResponse), CreateChannelResponse.Parser, new string[] { "ObjectId", "ChannelId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(JoinChannelRequest), JoinChannelRequest.Parser, new string[] { "AgentIdentity", "ChannelId", "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(JoinChannelResponse), JoinChannelResponse.Parser, new string[] { "ObjectId", "AlreadyMember", "MemberId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeChannelRequest), SubscribeChannelRequest.Parser, new string[] { "AgentId", "ChannelId", "ObjectId", "AgentIdentity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SubscribeChannelResponse), SubscribeChannelResponse.Parser, new string[] { "ObjectId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListChannelsRequest), ListChannelsRequest.Parser, new string[] { "AgentIdentity", "Options" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ListChannelsResponse), ListChannelsResponse.Parser, new string[] { "Channel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetChannelInfoRequest), GetChannelInfoRequest.Parser, new string[] { "AgentId", "ChannelId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetChannelInfoResponse), GetChannelInfoResponse.Parser, new string[] { "ChannelInfo" }, null, null, null, null)
			}));
		}

		// Token: 0x04004864 RID: 18532
		private static FileDescriptor descriptor;
	}
}
