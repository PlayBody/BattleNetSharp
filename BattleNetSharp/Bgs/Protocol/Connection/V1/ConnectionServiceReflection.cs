using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000429 RID: 1065
	public static class ConnectionServiceReflection
	{
		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x060068DE RID: 26846 RVA: 0x00195C1C File Offset: 0x00193E1C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.descriptor;
			}
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00195C34 File Offset: 0x00193E34
		static ConnectionServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CipiZ3MvbG93L3BiL2NsaWVudC9jb25uZWN0aW9uX3NlcnZpY2UucHJvdG8S", "GmJncy5wcm90b2NvbC5jb25uZWN0aW9uLnYxGixiZ3MvbG93L3BiL2NsaWVu", "dC9jb250ZW50X2hhbmRsZV90eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGll", "bnQvcnBjX3R5cGVzLnByb3RvGihiZ3MvbG93L3BiL2NsaWVudC9zZW1hbnRp", "Y192ZXJzaW9uLnByb3RvIpUBChRDbGllbnRTZGtWZXJzaW9uSW5mbxIQCghz", "ZGtfbmFtZRgBIAEoCRIyCgtzZGtfdmVyc2lvbhgCIAEoCzIdLmJncy5wcm90", "b2NvbC5TZW1hbnRpY1ZlcnNpb24SNwoQcHJvdG9jb2xfdmVyc2lvbhgDIAEo", "CzIdLmJncy5wcm90b2NvbC5TZW1hbnRpY1ZlcnNpb24iwAIKDkNvbm5lY3RS", "ZXF1ZXN0EioKCWNsaWVudF9pZBgBIAEoCzIXLmJncy5wcm90b2NvbC5Qcm9j", "ZXNzSWQSPQoMYmluZF9yZXF1ZXN0GAIgASgLMicuYmdzLnByb3RvY29sLmNv",
				"bm5lY3Rpb24udjEuQmluZFJlcXVlc3QSHgoQdXNlX2JpbmRsZXNzX3JwYxgD", "IAEoCDoEdHJ1ZRJYCg5tZXRlcmluZ19sZXZlbBgEIAEoDjIpLmJncy5wcm90", "b2NvbC5jb25uZWN0aW9uLnYxLk1ldGVyaW5nTGV2ZWw6FU1FVEVSSU5HX0xF", "VkVMX0xFR0FDWRJJCg9jbGllbnRfc2RrX2luZm8YBSABKAsyMC5iZ3MucHJv", "dG9jb2wuY29ubmVjdGlvbi52MS5DbGllbnRTZGtWZXJzaW9uSW5mbyJXCiBD", "b25uZWN0aW9uTWV0ZXJpbmdDb250ZW50SGFuZGxlcxIzCg5jb250ZW50X2hh", "bmRsZRgBIAMoCzIbLmJncy5wcm90b2NvbC5Db250ZW50SGFuZGxlIrQDCg9D", "b25uZWN0UmVzcG9uc2USKgoJc2VydmVyX2lkGAEgAigLMhcuYmdzLnByb3Rv", "Y29sLlByb2Nlc3NJZBIqCgljbGllbnRfaWQYAiABKAsyFy5iZ3MucHJvdG9j", "b2wuUHJvY2Vzc0lkEhMKC2JpbmRfcmVzdWx0GAMgASgNEj8KDWJpbmRfcmVz",
				"cG9uc2UYBCABKAsyKC5iZ3MucHJvdG9jb2wuY29ubmVjdGlvbi52MS5CaW5k", "UmVzcG9uc2USWgoUY29udGVudF9oYW5kbGVfYXJyYXkYBSABKAsyPC5iZ3Mu", "cHJvdG9jb2wuY29ubmVjdGlvbi52MS5Db25uZWN0aW9uTWV0ZXJpbmdDb250", "ZW50SGFuZGxlcxITCgtzZXJ2ZXJfdGltZRgGIAEoBBIfChB1c2VfYmluZGxl", "c3NfcnBjGAcgASgIOgVmYWxzZRJhChtiaW5hcnlfY29udGVudF9oYW5kbGVf", "YXJyYXkYCCABKAsyPC5iZ3MucHJvdG9jb2wuY29ubmVjdGlvbi52MS5Db25u", "ZWN0aW9uTWV0ZXJpbmdDb250ZW50SGFuZGxlcyIoCgxCb3VuZFNlcnZpY2US", "DAoEaGFzaBgBIAIoBxIKCgJpZBgCIAIoDSKYAgoLQmluZFJlcXVlc3QSLgog", "ZGVwcmVjYXRlZF9pbXBvcnRlZF9zZXJ2aWNlX2hhc2gYASADKAdCBBABGAES", "UQobZGVwcmVjYXRlZF9leHBvcnRlZF9zZXJ2aWNlGAIgAygLMiguYmdzLnBy",
				"b3RvY29sLmNvbm5lY3Rpb24udjEuQm91bmRTZXJ2aWNlQgIYARJCChBleHBv", "cnRlZF9zZXJ2aWNlGAMgAygLMiguYmdzLnByb3RvY29sLmNvbm5lY3Rpb24u", "djEuQm91bmRTZXJ2aWNlEkIKEGltcG9ydGVkX3NlcnZpY2UYBCADKAsyKC5i", "Z3MucHJvdG9jb2wuY29ubmVjdGlvbi52MS5Cb3VuZFNlcnZpY2UiMQoMQmlu", "ZFJlc3BvbnNlEiEKE2ltcG9ydGVkX3NlcnZpY2VfaWQYASADKA1CBBABGAEi", "jgEKC0VjaG9SZXF1ZXN0EgwKBHRpbWUYASABKAYSGwoMbmV0d29ya19vbmx5", "GAIgASgIOgVmYWxzZRIPCgdwYXlsb2FkGAMgASgMEigKB2ZvcndhcmQYBCAB", "KAsyFy5iZ3MucHJvdG9jb2wuUHJvY2Vzc0lkEhkKEWZvcndhcmRfY2xpZW50", "X2lkGAUgASgJIi0KDEVjaG9SZXNwb25zZRIMCgR0aW1lGAEgASgGEg8KB3Bh", "eWxvYWQYAiABKAwiJwoRRGlzY29ubmVjdFJlcXVlc3QSEgoKZXJyb3JfY29k",
				"ZRgBIAIoDSI8ChZEaXNjb25uZWN0Tm90aWZpY2F0aW9uEhIKCmVycm9yX2Nv", "ZGUYASACKA0SDgoGcmVhc29uGAIgASgJIhAKDkVuY3J5cHRSZXF1ZXN0KkoK", "DU1ldGVyaW5nTGV2ZWwSGQoVTUVURVJJTkdfTEVWRUxfTEVHQUNZEAASHgoa", "TUVURVJJTkdfTEVWRUxfQ0FURUdPUklaRUQQATLxBQoRQ29ubmVjdGlvblNl", "cnZpY2USagoHQ29ubmVjdBIqLmJncy5wcm90b2NvbC5jb25uZWN0aW9uLnYx", "LkNvbm5lY3RSZXF1ZXN0GisuYmdzLnByb3RvY29sLmNvbm5lY3Rpb24udjEu", "Q29ubmVjdFJlc3BvbnNlIgaC+SsCCAESZAoEQmluZBInLmJncy5wcm90b2Nv", "bC5jb25uZWN0aW9uLnYxLkJpbmRSZXF1ZXN0GiguYmdzLnByb3RvY29sLmNv", "bm5lY3Rpb24udjEuQmluZFJlc3BvbnNlIgmIAgGC+SsCCAISYQoERWNobxIn", "LmJncy5wcm90b2NvbC5jb25uZWN0aW9uLnYxLkVjaG9SZXF1ZXN0GiguYmdz",
				"LnByb3RvY29sLmNvbm5lY3Rpb24udjEuRWNob1Jlc3BvbnNlIgaC+SsCCAMS", "aAoPRm9yY2VEaXNjb25uZWN0EjIuYmdzLnByb3RvY29sLmNvbm5lY3Rpb24u", "djEuRGlzY29ubmVjdE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19S", "RVNQT05TRSIGgvkrAggEEkQKCUtlZXBBbGl2ZRIULmJncy5wcm90b2NvbC5O", "b0RhdGEaGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIBRJWCgdF", "bmNyeXB0EiouYmdzLnByb3RvY29sLmNvbm5lY3Rpb24udjEuRW5jcnlwdFJl", "cXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgmIAgGC+SsCCAYSZQoRUmVx", "dWVzdERpc2Nvbm5lY3QSLS5iZ3MucHJvdG9jb2wuY29ubmVjdGlvbi52MS5E", "aXNjb25uZWN0UmVxdWVzdBoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIG", "gvkrAggHGjiC+SssCipibmV0LnByb3RvY29sLmNvbm5lY3Rpb24uQ29ubmVj",
				"dGlvblNlcnZpY2WK+SsECAEQAUI8ChpiZ3MucHJvdG9jb2wuY29ubmVjdGlv", "bi52MUIWQ29ubmVjdGlvblNlcnZpY2VQcm90b0gBgAEAiAEB"
			}));
			ConnectionServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ContentHandleTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor,
				SemanticVersionReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[] { typeof(MeteringLevel) }, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClientSdkVersionInfo), ClientSdkVersionInfo.Parser, new string[] { "SdkName", "SdkVersion", "ProtocolVersion" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConnectRequest), ConnectRequest.Parser, new string[] { "ClientId", "BindRequest", "UseBindlessRpc", "MeteringLevel", "ClientSdkInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConnectionMeteringContentHandles), ConnectionMeteringContentHandles.Parser, new string[] { "ContentHandle" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConnectResponse), ConnectResponse.Parser, new string[] { "ServerId", "ClientId", "BindResult", "BindResponse", "ContentHandleArray", "ServerTime", "UseBindlessRpc", "BinaryContentHandleArray" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BoundService), BoundService.Parser, new string[] { "Hash", "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BindRequest), BindRequest.Parser, new string[] { "DeprecatedImportedServiceHash", "DeprecatedExportedService", "ExportedService", "ImportedService" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(BindResponse), BindResponse.Parser, new string[] { "ImportedServiceId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EchoRequest), EchoRequest.Parser, new string[] { "Time", "NetworkOnly", "Payload", "Forward", "ForwardClientId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EchoResponse), EchoResponse.Parser, new string[] { "Time", "Payload" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DisconnectRequest), DisconnectRequest.Parser, new string[] { "ErrorCode" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DisconnectNotification), DisconnectNotification.Parser, new string[] { "ErrorCode", "Reason" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EncryptRequest), EncryptRequest.Parser, null, null, null, null, null)
			}));
		}

		// Token: 0x04002FBC RID: 12220
		private static FileDescriptor descriptor;
	}
}
