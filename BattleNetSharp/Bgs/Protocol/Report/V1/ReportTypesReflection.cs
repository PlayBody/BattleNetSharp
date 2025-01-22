using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000577 RID: 1399
	public static class ReportTypesReflection
	{
		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x06008684 RID: 34436 RVA: 0x0020AA60 File Offset: 0x00208C60
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.descriptor;
			}
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x0020AA78 File Offset: 0x00208C78
		static ReportTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiRiZ3MvbG93L3BiL2NsaWVudC9yZXBvcnRfdHlwZXMucHJvdG8SFmJncy5w", "cm90b2NvbC5yZXBvcnQudjEaJWJncy9sb3cvcGIvY2xpZW50L2FjY291bnRf", "dHlwZXMucHJvdG8aJ2Jncy9sb3cvcGIvY2xpZW50L2F0dHJpYnV0ZV90eXBl", "cy5wcm90bxokYmdzL2xvdy9wYi9jbGllbnQvZW50aXR5X3R5cGVzLnByb3Rv", "GiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8iowQKClJlcG9y", "dFR5cGUSGAoQdXNlcl9kZXNjcmlwdGlvbhgBIAEoCRI9Cg1jdXN0b21fcmVw", "b3J0GAogASgLMiQuYmdzLnByb3RvY29sLnJlcG9ydC52MS5DdXN0b21SZXBv", "cnRIABI5CgtzcGFtX3JlcG9ydBgLIAEoCzIiLmJncy5wcm90b2NvbC5yZXBv", "cnQudjEuU3BhbVJlcG9ydEgAEkUKEWhhcmFzc21lbnRfcmVwb3J0GAwgASgL", "MiguYmdzLnByb3RvY29sLnJlcG9ydC52MS5IYXJhc3NtZW50UmVwb3J0SAAS",
				"TwoXcmVhbF9saWZlX3RocmVhdF9yZXBvcnQYDSABKAsyLC5iZ3MucHJvdG9j", "b2wucmVwb3J0LnYxLlJlYWxMaWZlVGhyZWF0UmVwb3J0SAASXwofaW5hcHBy", "b3ByaWF0ZV9iYXR0bGVfdGFnX3JlcG9ydBgOIAEoCzI0LmJncy5wcm90b2Nv", "bC5yZXBvcnQudjEuSW5hcHByb3ByaWF0ZUJhdHRsZVRhZ1JlcG9ydEgAEj8K", "DmhhY2tpbmdfcmVwb3J0GA8gASgLMiUuYmdzLnByb3RvY29sLnJlcG9ydC52", "MS5IYWNraW5nUmVwb3J0SAASPwoOYm90dGluZ19yZXBvcnQYECABKAsyJS5i", "Z3MucHJvdG9jb2wucmVwb3J0LnYxLkJvdHRpbmdSZXBvcnRIAEIGCgR0eXBl", "ImAKDEN1c3RvbVJlcG9ydBIMCgR0eXBlGAEgASgJEhYKCnByb2dyYW1faWQY", "AiABKAlCAhgBEioKCWF0dHJpYnV0ZRgDIAMoCzIXLmJncy5wcm90b2NvbC5B", "dHRyaWJ1dGUi1QEKClNwYW1SZXBvcnQSOgoGdGFyZ2V0GAEgASgLMiouYmdz",
				"LnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRIYW5kbGUSRAoGc291", "cmNlGAIgASgOMi0uYmdzLnByb3RvY29sLnJlcG9ydC52MS5TcGFtUmVwb3J0", "LlNwYW1Tb3VyY2U6BU9USEVSIkUKClNwYW1Tb3VyY2USCQoFT1RIRVIQARIV", "ChFGUklFTkRfSU5WSVRBVElPThACEgsKB1dISVNQRVIQAxIICgRDSEFUEAQi", "XAoQSGFyYXNzbWVudFJlcG9ydBI6CgZ0YXJnZXQYASABKAsyKi5iZ3MucHJv", "dG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRsZRIMCgR0ZXh0GAIg", "ASgJImAKFFJlYWxMaWZlVGhyZWF0UmVwb3J0EjoKBnRhcmdldBgBIAEoCzIq", "LmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlEgwK", "BHRleHQYAiABKAkibgocSW5hcHByb3ByaWF0ZUJhdHRsZVRhZ1JlcG9ydBI6", "CgZ0YXJnZXQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1l",
				"QWNjb3VudEhhbmRsZRISCgpiYXR0bGVfdGFnGAIgASgJIksKDUhhY2tpbmdS", "ZXBvcnQSOgoGdGFyZ2V0GAEgASgLMiouYmdzLnByb3RvY29sLmFjY291bnQu", "djEuR2FtZUFjY291bnRIYW5kbGUiSwoNQm90dGluZ1JlcG9ydBI6CgZ0YXJn", "ZXQYASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3Vu", "dEhhbmRsZSLlAQoGUmVwb3J0EhMKC3JlcG9ydF90eXBlGAEgAigJEioKCWF0", "dHJpYnV0ZRgCIAMoCzIXLmJncy5wcm90b2NvbC5BdHRyaWJ1dGUSFQoKcmVw", "b3J0X3FvcxgDIAEoBToBMBIxChFyZXBvcnRpbmdfYWNjb3VudBgEIAEoCzIW", "LmJncy5wcm90b2NvbC5FbnRpdHlJZBI2ChZyZXBvcnRpbmdfZ2FtZV9hY2Nv", "dW50GAUgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEhgKEHJlcG9ydF90", "aW1lc3RhbXAYBiABKAZCBUgBgAEA"
			}));
			ReportTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ReportType), ReportType.Parser, new string[] { "UserDescription", "CustomReport", "SpamReport", "HarassmentReport", "RealLifeThreatReport", "InappropriateBattleTagReport", "HackingReport", "BottingReport" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(CustomReport), CustomReport.Parser, new string[] { "Type", "ProgramId", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SpamReport), SpamReport.Parser, new string[] { "Target", "Source" }, null, new Type[] { typeof(SpamReport.Types.SpamSource) }, null, null),
				new GeneratedClrTypeInfo(typeof(HarassmentReport), HarassmentReport.Parser, new string[] { "Target", "Text" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RealLifeThreatReport), RealLifeThreatReport.Parser, new string[] { "Target", "Text" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(InappropriateBattleTagReport), InappropriateBattleTagReport.Parser, new string[] { "Target", "BattleTag" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HackingReport), HackingReport.Parser, new string[] { "Target" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BottingReport), BottingReport.Parser, new string[] { "Target" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Report), Report.Parser, new string[] { "ReportType", "Attribute", "ReportQos", "ReportingAccount", "ReportingGameAccount", "ReportTimestamp" }, null, null, null, null)
			}));
		}

		// Token: 0x04003CFA RID: 15610
		private static FileDescriptor descriptor;
	}
}
