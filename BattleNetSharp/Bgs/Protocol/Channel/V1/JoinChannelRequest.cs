using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006CE RID: 1742
	public sealed class JoinChannelRequest : IMessage<JoinChannelRequest>, IMessage, IEquatable<JoinChannelRequest>, IDeepCloneable<JoinChannelRequest>, IBufferMessage
	{
		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600A0CA RID: 41162 RVA: 0x00271F84 File Offset: 0x00270184
		[DebuggerNonUserCode]
		public static MessageParser<JoinChannelRequest> Parser
		{
			get
			{
				return JoinChannelRequest._parser;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x00271F9C File Offset: 0x0027019C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600A0CC RID: 41164 RVA: 0x00271FC0 File Offset: 0x002701C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinChannelRequest.Descriptor;
			}
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x00271FD7 File Offset: 0x002701D7
		[DebuggerNonUserCode]
		public JoinChannelRequest()
		{
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x00271FE4 File Offset: 0x002701E4
		[DebuggerNonUserCode]
		public JoinChannelRequest(JoinChannelRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentIdentity_ = ((other.agentIdentity_ != null) ? other.agentIdentity_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x0027205C File Offset: 0x0027025C
		[DebuggerNonUserCode]
		public JoinChannelRequest Clone()
		{
			return new JoinChannelRequest(this);
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600A0D0 RID: 41168 RVA: 0x00272074 File Offset: 0x00270274
		// (set) Token: 0x0600A0D1 RID: 41169 RVA: 0x0027208C File Offset: 0x0027028C
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

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600A0D2 RID: 41170 RVA: 0x00272098 File Offset: 0x00270298
		// (set) Token: 0x0600A0D3 RID: 41171 RVA: 0x002720B0 File Offset: 0x002702B0
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

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600A0D4 RID: 41172 RVA: 0x002720BC File Offset: 0x002702BC
		// (set) Token: 0x0600A0D5 RID: 41173 RVA: 0x002720ED File Offset: 0x002702ED
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
					objectIdDefaultValue = JoinChannelRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600A0D6 RID: 41174 RVA: 0x00272108 File Offset: 0x00270308
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x00272125 File Offset: 0x00270325
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x00272138 File Offset: 0x00270338
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinChannelRequest);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x00272158 File Offset: 0x00270358
		[DebuggerNonUserCode]
		public bool Equals(JoinChannelRequest other)
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
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

		// Token: 0x0600A0DA RID: 41178 RVA: 0x002721EC File Offset: 0x002703EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num ^= this.AgentIdentity.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
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

		// Token: 0x0600A0DB RID: 41179 RVA: 0x00272274 File Offset: 0x00270474
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x0027228C File Offset: 0x0027048C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x00272298 File Offset: 0x00270498
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentIdentity);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00272330 File Offset: 0x00270530
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentIdentity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentIdentity);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
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

		// Token: 0x0600A0DF RID: 41183 RVA: 0x002723C0 File Offset: 0x002705C0
		[DebuggerNonUserCode]
		public void MergeFrom(JoinChannelRequest other)
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
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
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

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x00272488 File Offset: 0x00270688
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x00272494 File Offset: 0x00270694
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
					if (num3 != 26U)
					{
						if (num3 != 32U)
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
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new EntityId();
						}
						input.ReadMessage(this.ChannelId);
					}
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
		}

		// Token: 0x04004879 RID: 18553
		private static readonly MessageParser<JoinChannelRequest> _parser = new MessageParser<JoinChannelRequest>(() => new JoinChannelRequest());

		// Token: 0x0400487A RID: 18554
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400487B RID: 18555
		private int _hasBits0;

		// Token: 0x0400487C RID: 18556
		public const int AgentIdentityFieldNumber = 1;

		// Token: 0x0400487D RID: 18557
		private Identity agentIdentity_;

		// Token: 0x0400487E RID: 18558
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x0400487F RID: 18559
		private EntityId channelId_;

		// Token: 0x04004880 RID: 18560
		public const int ObjectIdFieldNumber = 4;

		// Token: 0x04004881 RID: 18561
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04004882 RID: 18562
		private ulong objectId_;
	}
}
