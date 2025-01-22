using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A9 RID: 1449
	public sealed class BatchUnsubscribeRequest : IMessage<BatchUnsubscribeRequest>, IMessage, IEquatable<BatchUnsubscribeRequest>, IDeepCloneable<BatchUnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x060089E0 RID: 35296 RVA: 0x002178B8 File Offset: 0x00215AB8
		[DebuggerNonUserCode]
		public static MessageParser<BatchUnsubscribeRequest> Parser
		{
			get
			{
				return BatchUnsubscribeRequest._parser;
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x002178D0 File Offset: 0x00215AD0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x060089E2 RID: 35298 RVA: 0x002178F4 File Offset: 0x00215AF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchUnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x060089E3 RID: 35299 RVA: 0x0021790B File Offset: 0x00215B0B
		[DebuggerNonUserCode]
		public BatchUnsubscribeRequest()
		{
		}

		// Token: 0x060089E4 RID: 35300 RVA: 0x00217920 File Offset: 0x00215B20
		[DebuggerNonUserCode]
		public BatchUnsubscribeRequest(BatchUnsubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.entityId_ = other.entityId_.Clone();
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089E5 RID: 35301 RVA: 0x0021798C File Offset: 0x00215B8C
		[DebuggerNonUserCode]
		public BatchUnsubscribeRequest Clone()
		{
			return new BatchUnsubscribeRequest(this);
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x060089E6 RID: 35302 RVA: 0x002179A4 File Offset: 0x00215BA4
		// (set) Token: 0x060089E7 RID: 35303 RVA: 0x002179BC File Offset: 0x00215BBC
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

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x060089E8 RID: 35304 RVA: 0x002179C8 File Offset: 0x00215BC8
		[DebuggerNonUserCode]
		public RepeatedField<EntityId> EntityId
		{
			get
			{
				return this.entityId_;
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x002179E0 File Offset: 0x00215BE0
		// (set) Token: 0x060089EA RID: 35306 RVA: 0x00217A11 File Offset: 0x00215C11
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
					objectIdDefaultValue = BatchUnsubscribeRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x060089EB RID: 35307 RVA: 0x00217A2C File Offset: 0x00215C2C
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x00217A49 File Offset: 0x00215C49
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x00217A5C File Offset: 0x00215C5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchUnsubscribeRequest);
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x00217A7C File Offset: 0x00215C7C
		[DebuggerNonUserCode]
		public bool Equals(BatchUnsubscribeRequest other)
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
							bool flag6 = this.ObjectId != other.ObjectId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x00217B10 File Offset: 0x00215D10
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

		// Token: 0x060089F0 RID: 35312 RVA: 0x00217B8C File Offset: 0x00215D8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x00217BA4 File Offset: 0x00215DA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x00217BB0 File Offset: 0x00215DB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			this.entityId_.WriteTo(ref output, BatchUnsubscribeRequest._repeated_entityId_codec);
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x00217C34 File Offset: 0x00215E34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			num += this.entityId_.CalculateSize(BatchUnsubscribeRequest._repeated_entityId_codec);
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

		// Token: 0x060089F4 RID: 35316 RVA: 0x00217CB8 File Offset: 0x00215EB8
		[DebuggerNonUserCode]
		public void MergeFrom(BatchUnsubscribeRequest other)
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
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x00217D4F File Offset: 0x00215F4F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089F6 RID: 35318 RVA: 0x00217D5C File Offset: 0x00215F5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ObjectId = input.ReadUInt64();
						}
					}
					else
					{
						this.entityId_.AddEntriesFrom(ref input, BatchUnsubscribeRequest._repeated_entityId_codec);
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
		}

		// Token: 0x04003E5F RID: 15967
		private static readonly MessageParser<BatchUnsubscribeRequest> _parser = new MessageParser<BatchUnsubscribeRequest>(() => new BatchUnsubscribeRequest());

		// Token: 0x04003E60 RID: 15968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E61 RID: 15969
		private int _hasBits0;

		// Token: 0x04003E62 RID: 15970
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003E63 RID: 15971
		private EntityId agentId_;

		// Token: 0x04003E64 RID: 15972
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003E65 RID: 15973
		private static readonly FieldCodec<EntityId> _repeated_entityId_codec = FieldCodec.ForMessage<EntityId>(18U, Bgs.Protocol.EntityId.Parser);

		// Token: 0x04003E66 RID: 15974
		private readonly RepeatedField<EntityId> entityId_ = new RepeatedField<EntityId>();

		// Token: 0x04003E67 RID: 15975
		public const int ObjectIdFieldNumber = 3;

		// Token: 0x04003E68 RID: 15976
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04003E69 RID: 15977
		private ulong objectId_;
	}
}
