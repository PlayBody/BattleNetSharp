using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003B3 RID: 947
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06005F39 RID: 24377 RVA: 0x001712E4 File Offset: 0x0016F4E4
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06005F3A RID: 24378 RVA: 0x001712FC File Offset: 0x0016F4FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06005F3B RID: 24379 RVA: 0x00171320 File Offset: 0x0016F520
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x00171337 File Offset: 0x0016F537
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x00171344 File Offset: 0x0016F544
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x001713A0 File Offset: 0x0016F5A0
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06005F3F RID: 24383 RVA: 0x001713B8 File Offset: 0x0016F5B8
		// (set) Token: 0x06005F40 RID: 24384 RVA: 0x001713D0 File Offset: 0x0016F5D0
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

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x001713DC File Offset: 0x0016F5DC
		// (set) Token: 0x06005F42 RID: 24386 RVA: 0x0017140D File Offset: 0x0016F60D
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
					objectIdDefaultValue = SubscribeRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06005F43 RID: 24387 RVA: 0x00171428 File Offset: 0x0016F628
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x00171445 File Offset: 0x0016F645
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x00171458 File Offset: 0x0016F658
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x00171478 File Offset: 0x0016F678
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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
						bool flag5 = this.ObjectId != other.ObjectId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x001714EC File Offset: 0x0016F6EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
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

		// Token: 0x06005F48 RID: 24392 RVA: 0x00171558 File Offset: 0x0016F758
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x00171570 File Offset: 0x0016F770
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x0017157C File Offset: 0x0016F77C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x001715F0 File Offset: 0x0016F7F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
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

		// Token: 0x06005F4C RID: 24396 RVA: 0x00171660 File Offset: 0x0016F860
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
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
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x001716E5 File Offset: 0x0016F8E5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x001716F0 File Offset: 0x0016F8F0
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
					if (num3 != 16U)
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
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04002B8C RID: 11148
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x04002B8D RID: 11149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B8E RID: 11150
		private int _hasBits0;

		// Token: 0x04002B8F RID: 11151
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002B90 RID: 11152
		private EntityId agentId_;

		// Token: 0x04002B91 RID: 11153
		public const int ObjectIdFieldNumber = 2;

		// Token: 0x04002B92 RID: 11154
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04002B93 RID: 11155
		private ulong objectId_;
	}
}
