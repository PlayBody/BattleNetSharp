using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200036E RID: 878
	public static class MethodOptionsReflection
	{
		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06005A3B RID: 23099 RVA: 0x0015D21C File Offset: 0x0015B41C
		public static FileDescriptor Descriptor
		{
			get
			{
				return MethodOptionsReflection.descriptor;
			}
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x0015D234 File Offset: 0x0015B434
		static MethodOptionsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CjhiZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9tZXRob2Rf", "b3B0aW9ucy5wcm90bxIMYmdzLnByb3RvY29sGiBnb29nbGUvcHJvdG9idWYv", "ZGVzY3JpcHRvci5wcm90bxoxYmdzL2xvdy9wYi9jbGllbnQvZ2xvYmFsX2V4", "dGVuc2lvbnMvcm91dGluZy5wcm90byK0AgoQQkdTTWV0aG9kT3B0aW9ucxIK", "CgJpZBgBIAEoDRJIChdjbGllbnRfaWRlbnRpdHlfcm91dGluZxgCIAEoDjIn", "LmJncy5wcm90b2NvbC5DbGllbnRJZGVudGl0eVJvdXRpbmdUeXBlEhUKDWVu", "YWJsZV9mYW5vdXQYAyABKAgSIQoZbGVnYWN5X2Zhbm91dF9yZXBsYWNlbWVu", "dBgEIAEoCRITCgtmb3J3YXJkX2tleRgFIAEoCRISCgppZGVtcG90ZW50GAYg", "ASgIEiYKHmhhbmRsZV9kZXN0aW5hdGlvbl91bnJlYWNoYWJsZRgHIAEoCBIe", "ChZjdXN0b21fcmVnaW9uX3Jlc29sdmVyGAggASgJEh8KF2V4cGxpY2l0X3Jl",
				"Z2lvbl9yb3V0aW5nGAkgASgIOlgKDm1ldGhvZF9vcHRpb25zEh4uZ29vZ2xl", "LnByb3RvYnVmLk1ldGhvZE9wdGlvbnMYkL8FIAEoCzIeLmJncy5wcm90b2Nv", "bC5CR1NNZXRob2RPcHRpb25zQiIKDGJncy5wcm90b2NvbEISTWV0aG9kT3B0", "aW9uc1Byb3Rv"
			}));
			MethodOptionsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				DescriptorReflection.Descriptor,
				RoutingReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, new Extension[] { MethodOptionsExtensions.MethodOptions_ }, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(BGSMethodOptions), BGSMethodOptions.Parser, new string[] { "Id", "ClientIdentityRouting", "EnableFanout", "LegacyFanoutReplacement", "ForwardKey", "Idempotent", "HandleDestinationUnreachable", "CustomRegionResolver", "ExplicitRegionRouting" }, null, null, null, null)
			}));
		}

		// Token: 0x04002914 RID: 10516
		private static FileDescriptor descriptor;
	}
}
