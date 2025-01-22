using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A6 RID: 1446
	public sealed class BatchSubscribeRequest : IMessage<BatchSubscribeRequest>, IMessage, IEquatable<BatchSubscribeRequest>, IDeepCloneable<BatchSubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x0600899D RID: 35229 RVA: 0x002169DC File Offset: 0x00214BDC
		[DebuggerNonUserCode]
		public static MessageParser<BatchSubscribeRequest> Parser
		{
			get
			{
				return BatchSubscribeRequest._parser;
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x0600899E RID: 35230 RVA: 0x002169F4 File Offset: 0x00214BF4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x00216A18 File Offset: 0x00214C18
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchSubscribeRequest.Descriptor;
			}
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x00216A2F File Offset: 0x00214C2F
		[DebuggerNonUserCode]
		public BatchSubscribeRequest()
		{
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x00216A5C File Offset: 0x00214C5C
		[DebuggerNonUserCode]
		public BatchSubscribeRequest(BatchSubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.entityId_ = other.entityId_.Clone();
			this.program_ = other.program_.Clone();
			this.key_ = other.key_.Clone();
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x00216AEC File Offset: 0x00214CEC
		[DebuggerNonUserCode]
		public BatchSubscribeRequest Clone()
		{
			return new BatchSubscribeRequest(this);
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x060089A3 RID: 35235 RVA: 0x00216B04 File Offset: 0x00214D04
		// (set) Token: 0x060089A4 RID: 35236 RVA: 0x00216B1C File Offset: 0x00214D1C
		[DebuggerNonUserCode]
		public EntityId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x060089A5 RID: 35237 RVA: 0x00216B28 File Offset: 0x00214D28
		[DebuggerNonUserCode]
		public RepeatedField<EntityId> EntityId
		{
			get
			{
				return this.entityId_;
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x060089A6 RID: 35238 RVA: 0x00216B40 File Offset: 0x00214D40
		[DebuggerNonUserCode]
		public RepeatedField<uint> Program
		{
			get
			{
				return this.program_;
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x060089A7 RID: 35239 RVA: 0x00216B58 File Offset: 0x00214D58
		[DebuggerNonUserCode]
		public RepeatedField<FieldKey> Key
		{
			get
			{
				return this.key_;
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x060089A8 RID: 35240 RVA: 0x00216B70 File Offset: 0x00214D70
		// (set) Token: 0x060089A9 RID: 35241 RVA: 0x00216BA1 File Offset: 0x00214DA1
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = BatchSubscribeRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x060089AA RID: 35242 RVA: 0x00216BBC File Offset: 0x00214DBC
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x00216BD9 File Offset: 0x00214DD9
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060089AC RID: 35244 RVA: 0x00216BEC File Offset: 0x00214DEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchSubscribeRequest);
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x00216C0C File Offset: 0x00214E0C
		[DebuggerNonUserCode]
		public bool Equals(BatchSubscribeRequest other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.entityId_.Equals(other.entityId_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.program_.Equals(other.program_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.key_.Equals(other.key_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ObjectId != other.ObjectId;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x00216CE4 File Offset: 0x00214EE4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			num ^= this.entityId_.GetHashCode();
			num ^= this.program_.GetHashCode();
			num ^= this.key_.GetHashCode();
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x00216D7C File Offset: 0x00214F7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x00216D94 File Offset: 0x00214F94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x00216DA0 File Offset: 0x00214FA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			this.entityId_.WriteTo(ref output, BatchSubscribeRequest._repeated_entityId_codec);
			this.program_.WriteTo(ref output, BatchSubscribeRequest._repeated_program_codec);
			this.key_.WriteTo(ref output, BatchSubscribeRequest._repeated_key_codec);
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x00216E48 File Offset: 0x00215048
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			num += this.entityId_.CalculateSize(BatchSubscribeRequest._repeated_entityId_codec);
			num += this.program_.CalculateSize(BatchSubscribeRequest._repeated_program_codec);
			num += this.key_.CalculateSize(BatchSubscribeRequest._repeated_key_codec);
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x00216EF0 File Offset: 0x002150F0
		[DebuggerNonUserCode]
		public void MergeFrom(BatchSubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this.entityId_.Add(other.entityId_);
				this.program_.Add(other.program_);
				this.key_.Add(other.key_);
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x00216FAE File Offset: 0x002151AE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089B5 RID: 35253 RVA: 0x00216FBC File Offset: 0x002151BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_003D;
							}
							goto IL_0091;
						}
						else
						{
							this.entityId_.AddEntriesFrom(ref input, BatchSubscribeRequest._repeated_entityId_codec);
						}
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new EntityId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else
				{
					if (num3 == 29U)
					{
						goto IL_0091;
					}
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_003D;
						}
						this.ObjectId = input.ReadUInt64();
					}
					else
					{
						this.key_.AddEntriesFrom(ref input, BatchSubscribeRequest._repeated_key_codec);
					}
				}
				continue;
				IL_003D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_0091:
				this.program_.AddEntriesFrom(ref input, BatchSubscribeRequest._repeated_program_codec);
			}
		}

		// Token: 0x04003E41 RID: 15937
		private static readonly MessageParser<BatchSubscribeRequest> _parser = new MessageParser<BatchSubscribeRequest>(() => new BatchSubscribeRequest());

		// Token: 0x04003E42 RID: 15938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E43 RID: 15939
		private int _hasBits0;

		// Token: 0x04003E44 RID: 15940
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003E45 RID: 15941
		private EntityId agentId_;

		// Token: 0x04003E46 RID: 15942
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003E47 RID: 15943
		private static readonly FieldCodec<EntityId> _repeated_entityId_codec = FieldCodec.ForMessage<EntityId>(18U, Bgs.Protocol.EntityId.Parser);

		// Token: 0x04003E48 RID: 15944
		private readonly RepeatedField<EntityId> entityId_ = new RepeatedField<EntityId>();

		// Token: 0x04003E49 RID: 15945
		public const int ProgramFieldNumber = 3;

		// Token: 0x04003E4A RID: 15946
		private static readonly FieldCodec<uint> _repeated_program_codec = FieldCodec.ForFixed32(29U);

		// Token: 0x04003E4B RID: 15947
		private readonly RepeatedField<uint> program_ = new RepeatedField<uint>();

		// Token: 0x04003E4C RID: 15948
		public const int KeyFieldNumber = 4;

		// Token: 0x04003E4D RID: 15949
		private static readonly FieldCodec<FieldKey> _repeated_key_codec = FieldCodec.ForMessage<FieldKey>(34U, FieldKey.Parser);

		// Token: 0x04003E4E RID: 15950
		private readonly RepeatedField<FieldKey> key_ = new RepeatedField<FieldKey>();

		// Token: 0x04003E4F RID: 15951
		public const int ObjectIdFieldNumber = 5;

		// Token: 0x04003E50 RID: 15952
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04003E51 RID: 15953
		private ulong objectId_;
	}
}
