using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.DiabloClone
{
	// Token: 0x0200079D RID: 1949
	public static class DiabloCloneReflection
	{
		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600B32D RID: 45869 RVA: 0x002B9A00 File Offset: 0x002B7C00
		public static FileDescriptor Descriptor
		{
			get
			{
				return DiabloCloneReflection.descriptor;
			}
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x002B9A18 File Offset: 0x002B7C18
		static DiabloCloneReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZiZ3MvZGlhYmxvX2Nsb25lLnByb3RvEiljbGFzc2ljLnByb3RvY29sLmV4", "dGVybmFsLnYxLmRpYWJsb19jbG9uZRohYmdzL2xvdy9wYi9jbGllbnQvcnBj", "X3R5cGVzLnByb3RvIq0BCgtQcm9ncmVzc2lvbhJFCghHYW1lVHlwZRgBIAEo", "DjIzLmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuZGlhYmxvX2Nsb25l", "LkdhbWVUeXBlElcKEVByb2dyZXNzaW9uU3RhdHVzGAIgASgOMjwuY2xhc3Np", "Yy5wcm90b2NvbC5leHRlcm5hbC52MS5kaWFibG9fY2xvbmUuUHJvZ3Jlc3Np", "b25TdGF0dXMiYQoSRGlhYmxvQ2xvbmVNZXNzYWdlEksKC1Byb2dyZXNzaW9u", "GAEgAygLMjYuY2xhc3NpYy5wcm90b2NvbC5leHRlcm5hbC52MS5kaWFibG9f", "Y2xvbmUuUHJvZ3Jlc3Npb24qxAEKCEdhbWVUeXBlEgsKB0NsYXNzaWMQABIT", "Cg9DbGFzc2ljSGFyZGNvcmUQARIRCg1DbGFzc2ljTGFkZGVyEAISGQoVQ2xh",
				"c3NpY0xhZGRlckhhcmRjb3JlEAMSFgoSRXhwYW5zaW9uTm9uTGFkZGVyEAQS", "HgoaRXhwYW5zaW9uTm9uTGFkZGVySGFyZGNvcmUQBRITCg9FeHBhbnNpb25M", "YWRkZXIQBhIbChdFeHBhbnNpb25MYWRkZXJIYXJkY29yZRAHKuQBChFQcm9n", "cmVzc2lvblN0YXR1cxIcChhUZXJyb3JHYXplc1Vwb25TYW5jdHVhcnkQABIc", "ChhUZXJyb3JBcHByb2FjaGVzU2FudHVhcnkQARIlCiFUZXJyb3JCZWdpbnNU", "b0Zvcm1XaXRoaW5TYW5jdHVhcnkQAhIgChxUZXJyb3JTcHJlYWRzQWNyb3Nz", "U2FuY3R1YXJ5EAMSKwonVGVycm9ySXNBYm91dFRvQmVVbmxlYXNoZWRVcG9u", "U2FuY3R1YXJ5EAQSHQoZRGlhYmxvSGFzSW52YWRlZFNhbmN0dWFyeRAFMqIB", "ChNEaWFibG9DbG9uZUV4dGVybmFsEnkKFkRpYWJsb0Nsb25lTWVzc2FnZVRp", "ZXISPS5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmRpYWJsb19jbG9u",
				"ZS5EaWFibG9DbG9uZU1lc3NhZ2UaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgqC", "+SsGCLm3nJYNGhCC+SsMCgoweEM3OTZFNUQ2"
			}));
			DiabloCloneReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(new Type[]
			{
				typeof(GameType),
				typeof(ProgressionStatus)
			}, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Progression), Progression.Parser, new string[] { "GameType", "ProgressionStatus" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DiabloCloneMessage), DiabloCloneMessage.Parser, new string[] { "Progression" }, null, null, null, null)
			}));
		}

		// Token: 0x040050F7 RID: 20727
		private static FileDescriptor descriptor;
	}
}
