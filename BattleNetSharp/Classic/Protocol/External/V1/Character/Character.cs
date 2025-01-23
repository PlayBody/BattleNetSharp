using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bgs.Protocol;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007AA RID: 1962
	public static class Character
	{
		// Token: 0x0600B411 RID: 46097 RVA: 0x002BCB64 File Offset: 0x002BAD64
		private static void __Helper_SerializeMessage(IMessage message, SerializationContext context)
		{
			bool flag = message is IBufferMessage;
			if (flag)
			{
				context.SetPayloadLength(message.CalculateSize());
				MessageExtensions.WriteTo(message, context.GetBufferWriter());
				context.Complete();
			}
			else
			{
				context.Complete(MessageExtensions.ToByteArray(message));
			}
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x002BCBB0 File Offset: 0x002BADB0
		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			bool isBufferMessage = Character.__Helper_MessageCache<T>.IsBufferMessage;
			T t;
			if (isBufferMessage)
			{
				t = parser.ParseFrom(context.PayloadAsReadOnlySequence());
			}
			else
			{
				t = parser.ParseFrom(context.PayloadAsNewBuffer());
			}
			return t;
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600B413 RID: 46099 RVA: 0x002BCBE8 File Offset: 0x002BADE8
		public static ServiceDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.Descriptor.Services[0];
			}
		}

		// Token: 0x0600B414 RID: 46100 RVA: 0x002BCC0C File Offset: 0x002BAE0C
		public static ServerServiceDefinition BindService(Character.CharacterBase serviceImpl)
		{
			return ServerServiceDefinition.CreateBuilder().AddMethod<CreateCharacterRequest, CharacterResponse>(Character.__Method_CreateCharacter, new UnaryServerMethod<CreateCharacterRequest, CharacterResponse>(serviceImpl.CreateCharacter)).AddMethod<DeleteCharacterRequest, CharacterResponse>(Character.__Method_DeleteCharacter, new UnaryServerMethod<DeleteCharacterRequest, CharacterResponse>(serviceImpl.DeleteCharacter))
				.AddMethod<CharacterRequest, CharacterResponse>(Character.__Method_ConvertCharacter, new UnaryServerMethod<CharacterRequest, CharacterResponse>(serviceImpl.ConvertCharacter))
				.AddMethod<NoData, ReadCharacterResponse>(Character.__Method_ReadCharacter, new UnaryServerMethod<NoData, ReadCharacterResponse>(serviceImpl.ReadCharacter))
				.AddMethod<CharacterRequest, CharacterResponse>(Character.__Method_UseCharacter, new UnaryServerMethod<CharacterRequest, CharacterResponse>(serviceImpl.UseCharacter))
				.Build();
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x002BCC9C File Offset: 0x002BAE9C
		public static void BindService(ServiceBinderBase serviceBinder, Character.CharacterBase serviceImpl)
		{
			serviceBinder.AddMethod<CreateCharacterRequest, CharacterResponse>(Character.__Method_CreateCharacter, (serviceImpl == null) ? null : new UnaryServerMethod<CreateCharacterRequest, CharacterResponse>(serviceImpl.CreateCharacter));
			serviceBinder.AddMethod<DeleteCharacterRequest, CharacterResponse>(Character.__Method_DeleteCharacter, (serviceImpl == null) ? null : new UnaryServerMethod<DeleteCharacterRequest, CharacterResponse>(serviceImpl.DeleteCharacter));
			serviceBinder.AddMethod<CharacterRequest, CharacterResponse>(Character.__Method_ConvertCharacter, (serviceImpl == null) ? null : new UnaryServerMethod<CharacterRequest, CharacterResponse>(serviceImpl.ConvertCharacter));
			serviceBinder.AddMethod<NoData, ReadCharacterResponse>(Character.__Method_ReadCharacter, (serviceImpl == null) ? null : new UnaryServerMethod<NoData, ReadCharacterResponse>(serviceImpl.ReadCharacter));
			serviceBinder.AddMethod<CharacterRequest, CharacterResponse>(Character.__Method_UseCharacter, (serviceImpl == null) ? null : new UnaryServerMethod<CharacterRequest, CharacterResponse>(serviceImpl.UseCharacter));
		}

		// Token: 0x04005166 RID: 20838
		private static readonly string __ServiceName = "classic.protocol.external.v1.character.Character";

		// Token: 0x04005167 RID: 20839
		private static readonly Marshaller<CreateCharacterRequest> __Marshaller_classic_protocol_external_v1_character_CreateCharacterRequest = Marshallers.Create<CreateCharacterRequest>(new Action<CreateCharacterRequest, SerializationContext>(Character.__Helper_SerializeMessage), (DeserializationContext context) => Character.__Helper_DeserializeMessage<CreateCharacterRequest>(context, CreateCharacterRequest.Parser));

		// Token: 0x04005168 RID: 20840
		private static readonly Marshaller<CharacterResponse> __Marshaller_classic_protocol_external_v1_character_CharacterResponse = Marshallers.Create<CharacterResponse>(new Action<CharacterResponse, SerializationContext>(Character.__Helper_SerializeMessage), (DeserializationContext context) => Character.__Helper_DeserializeMessage<CharacterResponse>(context, CharacterResponse.Parser));

		// Token: 0x04005169 RID: 20841
		private static readonly Marshaller<DeleteCharacterRequest> __Marshaller_classic_protocol_external_v1_character_DeleteCharacterRequest = Marshallers.Create<DeleteCharacterRequest>(new Action<DeleteCharacterRequest, SerializationContext>(Character.__Helper_SerializeMessage), (DeserializationContext context) => Character.__Helper_DeserializeMessage<DeleteCharacterRequest>(context, DeleteCharacterRequest.Parser));

		// Token: 0x0400516A RID: 20842
		private static readonly Marshaller<CharacterRequest> __Marshaller_classic_protocol_external_v1_character_CharacterRequest = Marshallers.Create<CharacterRequest>(new Action<CharacterRequest, SerializationContext>(Character.__Helper_SerializeMessage), (DeserializationContext context) => Character.__Helper_DeserializeMessage<CharacterRequest>(context, CharacterRequest.Parser));

		// Token: 0x0400516B RID: 20843
		private static readonly Marshaller<NoData> __Marshaller_bgs_protocol_NoData = Marshallers.Create<NoData>(new Action<NoData, SerializationContext>(Character.__Helper_SerializeMessage), (DeserializationContext context) => Character.__Helper_DeserializeMessage<NoData>(context, NoData.Parser));

		// Token: 0x0400516C RID: 20844
		private static readonly Marshaller<ReadCharacterResponse> __Marshaller_classic_protocol_external_v1_character_ReadCharacterResponse = Marshallers.Create<ReadCharacterResponse>(new Action<ReadCharacterResponse, SerializationContext>(Character.__Helper_SerializeMessage), (DeserializationContext context) => Character.__Helper_DeserializeMessage<ReadCharacterResponse>(context, ReadCharacterResponse.Parser));

		// Token: 0x0400516D RID: 20845
		private static readonly Method<CreateCharacterRequest, CharacterResponse> __Method_CreateCharacter = new Method<CreateCharacterRequest, CharacterResponse>(0, Character.__ServiceName, "CreateCharacter", Character.__Marshaller_classic_protocol_external_v1_character_CreateCharacterRequest, Character.__Marshaller_classic_protocol_external_v1_character_CharacterResponse);

		// Token: 0x0400516E RID: 20846
		private static readonly Method<DeleteCharacterRequest, CharacterResponse> __Method_DeleteCharacter = new Method<DeleteCharacterRequest, CharacterResponse>(0, Character.__ServiceName, "DeleteCharacter", Character.__Marshaller_classic_protocol_external_v1_character_DeleteCharacterRequest, Character.__Marshaller_classic_protocol_external_v1_character_CharacterResponse);

		// Token: 0x0400516F RID: 20847
		private static readonly Method<CharacterRequest, CharacterResponse> __Method_ConvertCharacter = new Method<CharacterRequest, CharacterResponse>(0, Character.__ServiceName, "ConvertCharacter", Character.__Marshaller_classic_protocol_external_v1_character_CharacterRequest, Character.__Marshaller_classic_protocol_external_v1_character_CharacterResponse);

		// Token: 0x04005170 RID: 20848
		private static readonly Method<NoData, ReadCharacterResponse> __Method_ReadCharacter = new Method<NoData, ReadCharacterResponse>(0, Character.__ServiceName, "ReadCharacter", Character.__Marshaller_bgs_protocol_NoData, Character.__Marshaller_classic_protocol_external_v1_character_ReadCharacterResponse);

		// Token: 0x04005171 RID: 20849
		private static readonly Method<CharacterRequest, CharacterResponse> __Method_UseCharacter = new Method<CharacterRequest, CharacterResponse>(0, Character.__ServiceName, "UseCharacter", Character.__Marshaller_classic_protocol_external_v1_character_CharacterRequest, Character.__Marshaller_classic_protocol_external_v1_character_CharacterResponse);

		// Token: 0x020012D6 RID: 4822
		private static class __Helper_MessageCache<T>
		{
			// Token: 0x040099DE RID: 39390
			public static readonly bool IsBufferMessage = typeof(IBufferMessage).GetTypeInfo().IsAssignableFrom(typeof(T));
		}

		// Token: 0x020012D7 RID: 4823
		[BindServiceMethod(typeof(Character), "BindService")]
		public abstract class CharacterBase
		{
			// Token: 0x0600DE4B RID: 56907 RVA: 0x004C0EE0 File Offset: 0x004BF0E0
			public virtual Task<CharacterResponse> CreateCharacter(CreateCharacterRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DE4C RID: 56908 RVA: 0x004C0EF4 File Offset: 0x004BF0F4
			public virtual Task<CharacterResponse> DeleteCharacter(DeleteCharacterRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DE4D RID: 56909 RVA: 0x004C0F08 File Offset: 0x004BF108
			public virtual Task<CharacterResponse> ConvertCharacter(CharacterRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DE4E RID: 56910 RVA: 0x004C0F1C File Offset: 0x004BF11C
			public virtual Task<ReadCharacterResponse> ReadCharacter(NoData request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}

			// Token: 0x0600DE4F RID: 56911 RVA: 0x004C0F30 File Offset: 0x004BF130
			public virtual Task<CharacterResponse> UseCharacter(CharacterRequest request, ServerCallContext context)
			{
				throw new RpcException(new Status(StatusCode.Unimplemented, ""));
			}
		}

		// Token: 0x020012D8 RID: 4824
		public class CharacterClient : ClientBase<Character.CharacterClient>
		{
			// Token: 0x0600DE51 RID: 56913 RVA: 0x004C0F4D File Offset: 0x004BF14D
			public CharacterClient(ChannelBase channel)
				: base(channel)
			{
			}

			// Token: 0x0600DE52 RID: 56914 RVA: 0x004C0F58 File Offset: 0x004BF158
			public CharacterClient(CallInvoker callInvoker)
				: base(callInvoker)
			{
			}

			// Token: 0x0600DE53 RID: 56915 RVA: 0x004C0F63 File Offset: 0x004BF163
			protected CharacterClient()
			{
			}

			// Token: 0x0600DE54 RID: 56916 RVA: 0x004C0F6D File Offset: 0x004BF16D
			protected CharacterClient(ClientBase.ClientBaseConfiguration configuration)
				: base(configuration)
			{
			}

			// Token: 0x0600DE55 RID: 56917 RVA: 0x004C0F78 File Offset: 0x004BF178
			public virtual CharacterResponse CreateCharacter(CreateCharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateCharacter(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE56 RID: 56918 RVA: 0x004C0FA0 File Offset: 0x004BF1A0
			public virtual CharacterResponse CreateCharacter(CreateCharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CreateCharacterRequest, CharacterResponse>(Character.__Method_CreateCharacter, null, options, request);
			}

			// Token: 0x0600DE57 RID: 56919 RVA: 0x004C0FC8 File Offset: 0x004BF1C8
			public virtual AsyncUnaryCall<CharacterResponse> CreateCharacterAsync(CreateCharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.CreateCharacterAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE58 RID: 56920 RVA: 0x004C0FF0 File Offset: 0x004BF1F0
			public virtual AsyncUnaryCall<CharacterResponse> CreateCharacterAsync(CreateCharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CreateCharacterRequest, CharacterResponse>(Character.__Method_CreateCharacter, null, options, request);
			}

			// Token: 0x0600DE59 RID: 56921 RVA: 0x004C1018 File Offset: 0x004BF218
			public virtual CharacterResponse DeleteCharacter(DeleteCharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeleteCharacter(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE5A RID: 56922 RVA: 0x004C1040 File Offset: 0x004BF240
			public virtual CharacterResponse DeleteCharacter(DeleteCharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<DeleteCharacterRequest, CharacterResponse>(Character.__Method_DeleteCharacter, null, options, request);
			}

			// Token: 0x0600DE5B RID: 56923 RVA: 0x004C1068 File Offset: 0x004BF268
			public virtual AsyncUnaryCall<CharacterResponse> DeleteCharacterAsync(DeleteCharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.DeleteCharacterAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE5C RID: 56924 RVA: 0x004C1090 File Offset: 0x004BF290
			public virtual AsyncUnaryCall<CharacterResponse> DeleteCharacterAsync(DeleteCharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<DeleteCharacterRequest, CharacterResponse>(Character.__Method_DeleteCharacter, null, options, request);
			}

			// Token: 0x0600DE5D RID: 56925 RVA: 0x004C10B8 File Offset: 0x004BF2B8
			public virtual CharacterResponse ConvertCharacter(CharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ConvertCharacter(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE5E RID: 56926 RVA: 0x004C10E0 File Offset: 0x004BF2E0
			public virtual CharacterResponse ConvertCharacter(CharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CharacterRequest, CharacterResponse>(Character.__Method_ConvertCharacter, null, options, request);
			}

			// Token: 0x0600DE5F RID: 56927 RVA: 0x004C1108 File Offset: 0x004BF308
			public virtual AsyncUnaryCall<CharacterResponse> ConvertCharacterAsync(CharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ConvertCharacterAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE60 RID: 56928 RVA: 0x004C1130 File Offset: 0x004BF330
			public virtual AsyncUnaryCall<CharacterResponse> ConvertCharacterAsync(CharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CharacterRequest, CharacterResponse>(Character.__Method_ConvertCharacter, null, options, request);
			}

			// Token: 0x0600DE61 RID: 56929 RVA: 0x004C1158 File Offset: 0x004BF358
			public virtual ReadCharacterResponse ReadCharacter(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ReadCharacter(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE62 RID: 56930 RVA: 0x004C1180 File Offset: 0x004BF380
			public virtual ReadCharacterResponse ReadCharacter(NoData request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<NoData, ReadCharacterResponse>(Character.__Method_ReadCharacter, null, options, request);
			}

			// Token: 0x0600DE63 RID: 56931 RVA: 0x004C11A8 File Offset: 0x004BF3A8
			public virtual AsyncUnaryCall<ReadCharacterResponse> ReadCharacterAsync(NoData request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.ReadCharacterAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE64 RID: 56932 RVA: 0x004C11D0 File Offset: 0x004BF3D0
			public virtual AsyncUnaryCall<ReadCharacterResponse> ReadCharacterAsync(NoData request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<NoData, ReadCharacterResponse>(Character.__Method_ReadCharacter, null, options, request);
			}

			// Token: 0x0600DE65 RID: 56933 RVA: 0x004C11F8 File Offset: 0x004BF3F8
			public virtual CharacterResponse UseCharacter(CharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UseCharacter(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE66 RID: 56934 RVA: 0x004C1220 File Offset: 0x004BF420
			public virtual CharacterResponse UseCharacter(CharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.BlockingUnaryCall<CharacterRequest, CharacterResponse>(Character.__Method_UseCharacter, null, options, request);
			}

			// Token: 0x0600DE67 RID: 56935 RVA: 0x004C1248 File Offset: 0x004BF448
			public virtual AsyncUnaryCall<CharacterResponse> UseCharacterAsync(CharacterRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return this.UseCharacterAsync(request, new CallOptions(headers, deadline, cancellationToken, null, null, null));
			}

			// Token: 0x0600DE68 RID: 56936 RVA: 0x004C1270 File Offset: 0x004BF470
			public virtual AsyncUnaryCall<CharacterResponse> UseCharacterAsync(CharacterRequest request, CallOptions options)
			{
				return base.CallInvoker.AsyncUnaryCall<CharacterRequest, CharacterResponse>(Character.__Method_UseCharacter, null, options, request);
			}

			// Token: 0x0600DE69 RID: 56937 RVA: 0x004C1298 File Offset: 0x004BF498
			protected override Character.CharacterClient NewInstance(ClientBase.ClientBaseConfiguration configuration)
			{
				return new Character.CharacterClient(configuration);
			}
		}
	}
}
