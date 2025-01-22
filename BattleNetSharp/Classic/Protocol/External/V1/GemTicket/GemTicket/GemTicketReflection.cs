using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GemTicket.GemTicket
{
	// Token: 0x02000787 RID: 1927
	public static class GemTicketReflection
	{
		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600B0BA RID: 45242 RVA: 0x002B01E8 File Offset: 0x002AE3E8
		public static FileDescriptor Descriptor
		{
			get
			{
				return GemTicketReflection.descriptor;
			}
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x002B0200 File Offset: 0x002AE400
		static GemTicketReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "ChRiZ3MvZ2VtX3RpY2tldC5wcm90bxIxY2xhc3NpYy5wcm90b2NvbC5leHRl", "cm5hbC52MS5nZW1fdGlja2V0LkdlbVRpY2tldBohYmdzL2xvdy9wYi9jbGll", "bnQvcnBjX3R5cGVzLnByb3RvIiIKEEdlbVRpY2tldFJlcXVlc3QSDgoGZmxh", "Z3MxGAEgASgMIikKEUdlbVRpY2tldFJlc3BvbnNlEhQKDG1hZ2ljX251bWJl", "chgBIAEoCTLFAQoJR2VtVGlja2V0EqUBCgxSZXFHZW1UaWNrZXQSQy5jbGFz", "c2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmdlbV90aWNrZXQuR2VtVGlja2V0", "LkdlbVRpY2tldFJlcXVlc3QaRC5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFs", "LnYxLmdlbV90aWNrZXQuR2VtVGlja2V0LkdlbVRpY2tldFJlc3BvbnNlIgqC", "+SsGCMjOzKwBGhCC+SsMCgoweDVCOTMzMDk5" }));
			GemTicketReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GemTicketRequest), GemTicketRequest.Parser, new string[] { "Flags1" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GemTicketResponse), GemTicketResponse.Parser, new string[] { "MagicNumber" }, null, null, null, null)
			}));
		}

		// Token: 0x04004FB5 RID: 20405
		private static FileDescriptor descriptor;
	}
}
