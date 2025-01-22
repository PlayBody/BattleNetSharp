using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.TerrorZones
{
	// Token: 0x0200077D RID: 1917
	public static class TerrorZonesReflection
	{
		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0600B035 RID: 45109 RVA: 0x002AE2F8 File Offset: 0x002AC4F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return TerrorZonesReflection.descriptor;
			}
		}

		// Token: 0x0600B036 RID: 45110 RVA: 0x002AE310 File Offset: 0x002AC510
		static TerrorZonesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChZiZ3MvdGVycm9yX3pvbmVzLnByb3RvEiljbGFzc2ljLnByb3RvY29sLmV4", "dGVybmFsLnYxLnRlcnJvcl96b25lcxohYmdzL2xvdy9wYi9jbGllbnQvcnBj", "X3R5cGVzLnByb3RvIokBChlUZXJyb3Jab25lc01lc3NhZ2VSZXF1ZXN0EhAK", "CHRpbWVMZWZ0GAEgASgNEhAKCGN1cnJBcmVhGAIgAygNEhAKCG5leHRBcmVh", "GAMgAygNEgwKBHVuazMYBCABKA0SDAoEdW5rNBgFIAEoDRIMCgR1bms1GAYg", "ASgNEgwKBHVuazYYByABKA0ynQEKC1RlcnJvclpvbmVzEnwKElRlcnJvclpv", "bmVzTWVzc2FnZRJELmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEudGVy", "cm9yX3pvbmVzLlRlcnJvclpvbmVzTWVzc2FnZVJlcXVlc3QaFC5iZ3MucHJv", "dG9jb2wuTm9EYXRhIgqC+SsGCIH92/MEGhCC+SsMCgoweDBGNkUzQTkx" }));
			TerrorZonesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(TerrorZonesMessageRequest), TerrorZonesMessageRequest.Parser, new string[] { "TimeLeft", "CurrArea", "NextArea", "Unk3", "Unk4", "Unk5", "Unk6" }, null, null, null, null)
			}));
		}

		// Token: 0x04004F77 RID: 20343
		private static FileDescriptor descriptor;
	}
}
