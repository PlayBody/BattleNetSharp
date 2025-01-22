using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.GameVersion
{
	// Token: 0x02000767 RID: 1895
	public static class GameVersionReflection
	{
		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600AE29 RID: 44585 RVA: 0x002A6704 File Offset: 0x002A4904
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameVersionReflection.descriptor;
			}
		}

		// Token: 0x0600AE2A RID: 44586 RVA: 0x002A671C File Offset: 0x002A491C
		static GameVersionReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZiZ3MvZ2FtZV92ZXJzaW9uLnByb3RvEiBjbGFzc2ljLnByb3RvY29sLnYx", "LmdhbWVfdmVyc2lvbhohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVzLnBy", "b3RvIiUKEkdhbWVWZXJzaW9uUmVxdWVzdBIPCgd2ZXJzaW9uGAEgASgJIiMK", "E0dhbWVWZXJzaW9uUmVzcG9uc2USDAoERGF0YRgDIAEoDDKoAwoLR2FtZVZl", "cnNpb24SaAoOU2V0R2FtZVZlcnNpb24SNC5jbGFzc2ljLnByb3RvY29sLnYx", "LmdhbWVfdmVyc2lvbi5HYW1lVmVyc2lvblJlcXVlc3QaFC5iZ3MucHJvdG9j", "b2wuTm9EYXRhIgqC+SsGCODIt6QNEowBChJHYW1lVXBkYXRlUmVxdWlyZWQS", "NC5jbGFzc2ljLnByb3RvY29sLnYxLmdhbWVfdmVyc2lvbi5HYW1lVmVyc2lv", "blJlcXVlc3QaNS5jbGFzc2ljLnByb3RvY29sLnYxLmdhbWVfdmVyc2lvbi5H", "YW1lVmVyc2lvblJlc3BvbnNlIgmC+SsFCLLxxg0SjQEKEkdhbWVVcGRhdGVD",
				"YW5jZWxlZBI0LmNsYXNzaWMucHJvdG9jb2wudjEuZ2FtZV92ZXJzaW9uLkdh", "bWVWZXJzaW9uUmVxdWVzdBo1LmNsYXNzaWMucHJvdG9jb2wudjEuZ2FtZV92", "ZXJzaW9uLkdhbWVWZXJzaW9uUmVzcG9uc2UiCoL5KwYI0IXo0AoaEIL5KwwK", "CjB4M0Q5MzBGMEU="
			}));
			GameVersionReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GameVersionRequest), GameVersionRequest.Parser, new string[] { "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameVersionResponse), GameVersionResponse.Parser, new string[] { "Data" }, null, null, null, null)
			}));
		}

		// Token: 0x04004E7F RID: 20095
		private static FileDescriptor descriptor;
	}
}
