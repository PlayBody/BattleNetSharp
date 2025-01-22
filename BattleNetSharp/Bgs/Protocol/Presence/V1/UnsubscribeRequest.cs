using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A1 RID: 1441
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x0600892B RID: 35115 RVA: 0x00215020 File Offset: 0x00213220
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0600892C RID: 35116 RVA: 0x00215038 File Offset: 0x00213238
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600892D RID: 35117 RVA: 0x0021505C File Offset: 0x0021325C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x00215073 File Offset: 0x00213273
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x00215080 File Offset: 0x00213280
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x002150F8 File Offset: 0x002132F8
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x06008931 RID: 35121 RVA: 0x00215110 File Offset: 0x00213310
		// (set) Token: 0x06008932 RID: 35122 RVA: 0x00215128 File Offset: 0x00213328
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

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x06008933 RID: 35123 RVA: 0x00215134 File Offset: 0x00213334
		// (set) Token: 0x06008934 RID: 35124 RVA: 0x0021514C File Offset: 0x0021334C
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x06008935 RID: 35125 RVA: 0x00215158 File Offset: 0x00213358
		// (set) Token: 0x06008936 RID: 35126 RVA: 0x00215189 File Offset: 0x00213389
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
					objectIdDefaultValue = UnsubscribeRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x002151A4 File Offset: 0x002133A4
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x002151C1 File Offset: 0x002133C1
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x002151D4 File Offset: 0x002133D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x002151F4 File Offset: 0x002133F4
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeRequest other)
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
						bool flag5 = !object.Equals(this.EntityId, other.EntityId);
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

		// Token: 0x0600893B RID: 35131 RVA: 0x00215288 File Offset: 0x00213488
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.entityId_ != null;
			if (flag2)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x00215310 File Offset: 0x00213510
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x00215328 File Offset: 0x00213528
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600893E RID: 35134 RVA: 0x00215334 File Offset: 0x00213534
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.entityId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EntityId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x002153CC File Offset: 0x002135CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.entityId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x0021545C File Offset: 0x0021365C
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeRequest other)
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
				bool flag4 = other.entityId_ != null;
				if (flag4)
				{
					bool flag5 = this.entityId_ == null;
					if (flag5)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x00215524 File Offset: 0x00213724
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x00215530 File Offset: 0x00213730
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
						bool flag = this.entityId_ == null;
						if (flag)
						{
							this.EntityId = new EntityId();
						}
						input.ReadMessage(this.EntityId);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003E14 RID: 15892
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x04003E15 RID: 15893
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E16 RID: 15894
		private int _hasBits0;

		// Token: 0x04003E17 RID: 15895
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003E18 RID: 15896
		private EntityId agentId_;

		// Token: 0x04003E19 RID: 15897
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003E1A RID: 15898
		private EntityId entityId_;

		// Token: 0x04003E1B RID: 15899
		public const int ObjectIdFieldNumber = 3;

		// Token: 0x04003E1C RID: 15900
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04003E1D RID: 15901
		private ulong objectId_;
	}
}
