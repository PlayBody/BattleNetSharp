using System;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200069B RID: 1691
	public static class ServerChannelTypesReflection
	{
		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06009D03 RID: 40195 RVA: 0x002628D0 File Offset: 0x00260AD0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ServerChannelTypesReflection.descriptor;
			}
		}

		// Token: 0x06009D04 RID: 40196 RVA: 0x002628E8 File Offset: 0x00260AE8
		static ServerChannelTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjpiZ3MvbG93L3BiL2NsaWVudC9hcGkvc2VydmVyL3YyL3NlcnZlcl9jaGFu", "bmVsX3R5cGVzLnByb3RvEhdiZ3MucHJvdG9jb2wuY2hhbm5lbC52Mho1Ymdz", "L2xvdy9wYi9jbGllbnQvYXBpL2NsaWVudC92Mi9hdHRyaWJ1dGVfdHlwZXMu", "cHJvdG8aMmJncy9sb3cvcGIvY2xpZW50L2FwaS9jbGllbnQvdjIvY2hhbm5l", "bF9lbnVtLnByb3RvGjNiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3Yy", "L2NoYW5uZWxfdHlwZXMucHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L2FjY291", "bnRfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5w", "cm90byKmAgoaQ3JlYXRlQ2hhbm5lbFNlcnZlck9wdGlvbnMSOAoEdHlwZRgB", "IAEoCzIqLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLlVuaXF1ZUNoYW5uZWxU", "eXBlEgwKBG5hbWUYAiABKAkSPAoNcHJpdmFjeV9sZXZlbBgDIAEoDjIlLmJn",
				"cy5wcm90b2NvbC5jaGFubmVsLnYyLlByaXZhY3lMZXZlbBItCglhdHRyaWJ1", "dGUYBCADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlEjwKBm1lbWJl", "chgFIAMoCzIsLmJncy5wcm90b2NvbC5jaGFubmVsLnYyLkNyZWF0ZU1lbWJl", "ck9wdGlvbnMSFQoNY29sbGVjdGlvbl9pZBgGIAEoCSKCAQoTQ2hhbm5lbFN0", "YXRlT3B0aW9ucxItCglhdHRyaWJ1dGUYASADKAsyGi5iZ3MucHJvdG9jb2wu", "djIuQXR0cmlidXRlEjwKDXByaXZhY3lfbGV2ZWwYAiABKA4yJS5iZ3MucHJv", "dG9jb2wuY2hhbm5lbC52Mi5Qcml2YWN5TGV2ZWwikwEKFkNoYW5uZWxTdGF0", "ZUFzc2lnbm1lbnQSDAoEbmFtZRgBIAEoCRItCglhdHRyaWJ1dGUYAiADKAsy", "Gi5iZ3MucHJvdG9jb2wudjIuQXR0cmlidXRlEjwKDXByaXZhY3lfbGV2ZWwY", "AyABKA4yJS5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5Qcml2YWN5TGV2ZWwi",
				"iAEKGFVwZGF0ZU1lbWJlclN0YXRlT3B0aW9ucxI9CgltZW1iZXJfaWQYASAB", "KAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRs", "ZRItCglhdHRyaWJ1dGUYAiADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0cmli", "dXRlIoUBChVNZW1iZXJTdGF0ZUFzc2lnbm1lbnQSPQoJbWVtYmVyX2lkGAEg", "ASgLMiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5k", "bGUSLQoJYXR0cmlidXRlGAIgAygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJp", "YnV0ZSKMAQoYQWN0aXZlQ2hhbm5lbERlc2NyaXB0aW9uEjgKBHR5cGUYASAB", "KAsyKi5iZ3MucHJvdG9jb2wuY2hhbm5lbC52Mi5VbmlxdWVDaGFubmVsVHlw", "ZRI2CgpjaGFubmVsX2lkGAIgASgLMiIuYmdzLnByb3RvY29sLmNoYW5uZWwu", "djIuQ2hhbm5lbElkUABQAVACUAM="
			}));
			ServerChannelTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				ChannelEnumReflection.Descriptor,
				ChannelTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CreateChannelServerOptions), CreateChannelServerOptions.Parser, new string[] { "Type", "Name", "PrivacyLevel", "Attribute", "Member", "CollectionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelStateOptions), ChannelStateOptions.Parser, new string[] { "Attribute", "PrivacyLevel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelStateAssignment), ChannelStateAssignment.Parser, new string[] { "Name", "Attribute", "PrivacyLevel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateMemberStateOptions), UpdateMemberStateOptions.Parser, new string[] { "MemberId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemberStateAssignment), MemberStateAssignment.Parser, new string[] { "MemberId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ActiveChannelDescription), ActiveChannelDescription.Parser, new string[] { "Type", "ChannelId" }, null, null, null, null)
			}));
		}

		// Token: 0x040046DD RID: 18141
		private static FileDescriptor descriptor;
	}
}
