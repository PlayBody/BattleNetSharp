using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Network
{
	// Token: 0x02000758 RID: 1880
	public static class NetworkReflection
	{
		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600AD16 RID: 44310 RVA: 0x002A237C File Offset: 0x002A057C
		public static FileDescriptor Descriptor
		{
			get
			{
				return NetworkReflection.descriptor;
			}
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x002A2394 File Offset: 0x002A0594
		static NetworkReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChFiZ3MvbmV0d29yay5wcm90bxIbY2xhc3NpYy5wcm90b2NvbC52MS5uZXR3", "b3JrGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJvdG8iegoOTmV0", "d29ya1JlcXVlc3QSCwoDa2V5GAEgASgJEgsKA09TSRgDIAEoBRIPCgd2ZXJz", "aW9uGAQgASgJEg8KB2Jhc2VLZXkYBSABKAkSEQoJdGhpcnR5MTAwGAYgASgF", "EgwKBFduNjQYByABKAUSCwoDb25lGAggASgFIh8KD05ldHdvcmtSZXNwb25z", "ZRIMCgREYXRhGAMgASgMMt4BCgdOZXR3b3JrEksKEUdldEVjaG9TZXJ2ZXJM", "aXN0EhQuYmdzLnByb3RvY29sLk5vRGF0YRoULmJncy5wcm90b2NvbC5Ob0Rh", "dGEiCoL5KwYIn4qf6gcSdAoLU2VuZFVEUFRlc3QSKy5jbGFzc2ljLnByb3Rv", "Y29sLnYxLm5ldHdvcmsuTmV0d29ya1JlcXVlc3QaLC5jbGFzc2ljLnByb3Rv", "Y29sLnYxLm5ldHdvcmsuTmV0d29ya1Jlc3BvbnNlIgqC+SsGCIzRpoYOGhCC",
				"+SsMCgoweDQ0NDMyRTlC"
			}));
			NetworkReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NetworkRequest), NetworkRequest.Parser, new string[] { "Key", "OSI", "Version", "BaseKey", "Thirty100", "Wn64", "One" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NetworkResponse), NetworkResponse.Parser, new string[] { "Data" }, null, null, null, null)
			}));
		}

		// Token: 0x04004DF4 RID: 19956
		private static FileDescriptor descriptor;
	}
}
