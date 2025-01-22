using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007A3 RID: 1955
	public static class CharacterReflection
	{
		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600B360 RID: 45920 RVA: 0x002BA4D0 File Offset: 0x002B86D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.descriptor;
			}
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x002BA4E8 File Offset: 0x002B86E8
		static CharacterReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNiZ3MvY2hhcmFjdGVyLnByb3RvEiZjbGFzc2ljLnByb3RvY29sLmV4dGVy", "bmFsLnYxLmNoYXJhY3RlchohYmdzL2xvdy9wYi9jbGllbnQvcnBjX3R5cGVz", "LnByb3RvInwKEENoYXJhY3RlclJlcXVlc3QSCwoDa2V5GAEgASgJEgsKA09T", "SRgDIAEoBRIPCgd2ZXJzaW9uGAQgASgJEg8KB2Jhc2VLZXkYBSABKAkSEQoJ", "dGhpcnR5MTAwGAYgASgFEgwKBFduNjQYByABKAUSCwoDb25lGAggASgFIk4K", "FkNyZWF0ZUNoYXJhY3RlclJlcXVlc3QSDAoEbmFtZRgBIAEoCRINCgVjbGFz", "cxgCIAEoBRIXCg9mbGFnc19oY19sYWRkZXIYAyABKAUiMgoWRGVsZXRlQ2hh", "cmFjdGVyUmVxdWVzdBIKCgJpZBgBIAEoDRIMCgR1bmswGAIgASgFIi0KEUNo", "YXJhY3RlclJlc3BvbnNlEgoKAmlkGAEgASgNEgwKBERhdGEYAyABKAwiMQoI", "Q2hhckRhdGESCgoCaWQYASABKA0SDAoEbmFtZRgCIAEoCRILCgNkMnMYAyAB",
				"KAwibgoVUmVhZENoYXJhY3RlclJlc3BvbnNlEg8KB21heF9udW0YASABKA0S", "RAoKY2hhcmFjdGVycxgCIAMoCzIwLmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJu", "YWwudjEuY2hhcmFjdGVyLkNoYXJEYXRhMuwFCglDaGFyYWN0ZXISlwEKD0Ny", "ZWF0ZUNoYXJhY3RlchI+LmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEu", "Y2hhcmFjdGVyLkNyZWF0ZUNoYXJhY3RlclJlcXVlc3QaOS5jbGFzc2ljLnBy", "b3RvY29sLmV4dGVybmFsLnYxLmNoYXJhY3Rlci5DaGFyYWN0ZXJSZXNwb25z", "ZSIJgvkrBQi1/eshEpgBCg9EZWxldGVDaGFyYWN0ZXISPi5jbGFzc2ljLnBy", "b3RvY29sLmV4dGVybmFsLnYxLmNoYXJhY3Rlci5EZWxldGVDaGFyYWN0ZXJS", "ZXF1ZXN0GjkuY2xhc3NpYy5wcm90b2NvbC5leHRlcm5hbC52MS5jaGFyYWN0", "ZXIuQ2hhcmFjdGVyUmVzcG9uc2UiCoL5KwYImMHUjgoSkwEKEENvbnZlcnRD",
				"aGFyYWN0ZXISOC5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmNoYXJh", "Y3Rlci5DaGFyYWN0ZXJSZXF1ZXN0GjkuY2xhc3NpYy5wcm90b2NvbC5leHRl", "cm5hbC52MS5jaGFyYWN0ZXIuQ2hhcmFjdGVyUmVzcG9uc2UiCoL5KwYI0rWf", "hQsScAoNUmVhZENoYXJhY3RlchIULmJncy5wcm90b2NvbC5Ob0RhdGEaPS5j", "bGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmNoYXJhY3Rlci5SZWFkQ2hh", "cmFjdGVyUmVzcG9uc2UiCoL5KwYIkbCIvAQSjwEKDFVzZUNoYXJhY3RlchI4", "LmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuY2hhcmFjdGVyLkNoYXJh", "Y3RlclJlcXVlc3QaOS5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmNo", "YXJhY3Rlci5DaGFyYWN0ZXJSZXNwb25zZSIKgvkrBgjG1cHTBhoQgvkrDAoK", "MHg2MDdGRDE5Ng=="
			}));
			CharacterReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CharacterRequest), CharacterRequest.Parser, new string[] { "Key", "OSI", "Version", "BaseKey", "Thirty100", "Wn64", "One" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateCharacterRequest), CreateCharacterRequest.Parser, new string[] { "Name", "Class", "FlagsHcLadder" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DeleteCharacterRequest), DeleteCharacterRequest.Parser, new string[] { "Id", "Unk0" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CharacterResponse), CharacterResponse.Parser, new string[] { "Id", "Data" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CharData), CharData.Parser, new string[] { "Id", "Name", "D2S" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ReadCharacterResponse), ReadCharacterResponse.Parser, new string[] { "MaxNum", "Characters" }, null, null, null, null)
			}));
		}

		// Token: 0x0400511A RID: 20762
		private static FileDescriptor descriptor;
	}
}
