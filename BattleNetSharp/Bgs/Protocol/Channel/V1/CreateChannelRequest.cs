using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006CC RID: 1740
	public sealed class CreateChannelRequest : IMessage<CreateChannelRequest>, IMessage, IEquatable<CreateChannelRequest>, IDeepCloneable<CreateChannelRequest>, IBufferMessage
	{
		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600A098 RID: 41112 RVA: 0x00271394 File Offset: 0x0026F594
		[DebuggerNonUserCode]
		public static MessageParser<CreateChannelRequest> Parser
		{
			get
			{
				return CreateChannelRequest._parser;
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600A099 RID: 41113 RVA: 0x002713AC File Offset: 0x0026F5AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600A09A RID: 41114 RVA: 0x002713D0 File Offset: 0x0026F5D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateChannelRequest.Descriptor;
			}
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x002713E7 File Offset: 0x0026F5E7
		[DebuggerNonUserCode]
		public CreateChannelRequest()
		{
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x002713F4 File Offset: 0x0026F5F4
		[DebuggerNonUserCode]
		public CreateChannelRequest(CreateChannelRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentIdentity_ = ((other.agentIdentity_ != null) ? other.agentIdentity_.Clone() : null);
			this.channelState_ = ((other.channelState_ != null) ? other.channelState_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A09D RID: 41117 RVA: 0x00271488 File Offset: 0x0026F688
		[DebuggerNonUserCode]
		public CreateChannelRequest Clone()
		{
			return new CreateChannelRequest(this);
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600A09E RID: 41118 RVA: 0x002714A0 File Offset: 0x0026F6A0
		// (set) Token: 0x0600A09F RID: 41119 RVA: 0x002714B8 File Offset: 0x0026F6B8
		[DebuggerNonUserCode]
		public Identity AgentIdentity
		{
			get
			{
				return this.agentIdentity_;
			}
			set
			{
				this.agentIdentity_ = value;
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x002714C4 File Offset: 0x0026F6C4
		// (set) Token: 0x0600A0A1 RID: 41121 RVA: 0x002714DC File Offset: 0x0026F6DC
		[DebuggerNonUserCode]
		public ChannelState ChannelState
		{
			get
			{
				return this.channelState_;
			}
			set
			{
				this.channelState_ = value;
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x002714E8 File Offset: 0x0026F6E8
		// (set) Token: 0x0600A0A3 RID: 41123 RVA: 0x00271500 File Offset: 0x0026F700
		[DebuggerNonUserCode]
		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x0027150C File Offset: 0x0026F70C
		// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x0027153D File Offset: 0x0026F73D
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
					objectIdDefaultValue = CreateChannelRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x00271558 File Offset: 0x0026F758
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x00271575 File Offset: 0x0026F775
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x00271588 File Offset: 0x0026F788
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateChannelRequest);
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x002715A8 File Offset: 0x0026F7A8
		[DebuggerNonUserCode]
		public bool Equals(CreateChannelRequest other)
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
					bool flag4 = !object.Equals(this.AgentIdentity, other.AgentIdentity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ChannelState, other.ChannelState);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ChannelId, other.ChannelId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ObjectId != other.ObjectId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x00271660 File Offset: 0x0026F860
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num ^= this.AgentIdentity.GetHashCode();
			}
			bool flag2 = this.channelState_ != null;
			if (flag2)
			{
				num ^= this.ChannelState.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x00271708 File Offset: 0x0026F908
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x00271720 File Offset: 0x0026F920
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x0027172C File Offset: 0x0026F92C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentIdentity);
			}
			bool flag2 = this.channelState_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelState);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ChannelId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x002717EC File Offset: 0x0026F9EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentIdentity);
			}
			bool flag2 = this.channelState_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelState);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x002718A0 File Offset: 0x0026FAA0
		[DebuggerNonUserCode]
		public void MergeFrom(CreateChannelRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentIdentity_ != null;
				if (flag2)
				{
					bool flag3 = this.agentIdentity_ == null;
					if (flag3)
					{
						this.AgentIdentity = new Identity();
					}
					this.AgentIdentity.MergeFrom(other.AgentIdentity);
				}
				bool flag4 = other.channelState_ != null;
				if (flag4)
				{
					bool flag5 = this.channelState_ == null;
					if (flag5)
					{
						this.ChannelState = new ChannelState();
					}
					this.ChannelState.MergeFrom(other.ChannelState);
				}
				bool flag6 = other.channelId_ != null;
				if (flag6)
				{
					bool flag7 = this.channelId_ == null;
					if (flag7)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x002719A8 File Offset: 0x0026FBA8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x002719B4 File Offset: 0x0026FBB4
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
						if (num3 != 26U)
						{
							goto IL_002F;
						}
						bool flag = this.channelState_ == null;
						if (flag)
						{
							this.ChannelState = new ChannelState();
						}
						input.ReadMessage(this.ChannelState);
					}
					else
					{
						bool flag2 = this.agentIdentity_ == null;
						if (flag2)
						{
							this.AgentIdentity = new Identity();
						}
						input.ReadMessage(this.AgentIdentity);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						goto IL_002F;
					}
					this.ObjectId = input.ReadUInt64();
				}
				else
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					input.ReadMessage(this.ChannelId);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004865 RID: 18533
		private static readonly MessageParser<CreateChannelRequest> _parser = new MessageParser<CreateChannelRequest>(() => new CreateChannelRequest());

		// Token: 0x04004866 RID: 18534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004867 RID: 18535
		private int _hasBits0;

		// Token: 0x04004868 RID: 18536
		public const int AgentIdentityFieldNumber = 1;

		// Token: 0x04004869 RID: 18537
		private Identity agentIdentity_;

		// Token: 0x0400486A RID: 18538
		public const int ChannelStateFieldNumber = 3;

		// Token: 0x0400486B RID: 18539
		private ChannelState channelState_;

		// Token: 0x0400486C RID: 18540
		public const int ChannelIdFieldNumber = 4;

		// Token: 0x0400486D RID: 18541
		private EntityId channelId_;

		// Token: 0x0400486E RID: 18542
		public const int ObjectIdFieldNumber = 5;

		// Token: 0x0400486F RID: 18543
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04004870 RID: 18544
		private ulong objectId_;
	}
}
