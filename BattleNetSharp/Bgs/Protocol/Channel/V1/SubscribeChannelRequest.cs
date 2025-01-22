using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D0 RID: 1744
	public sealed class SubscribeChannelRequest : IMessage<SubscribeChannelRequest>, IMessage, IEquatable<SubscribeChannelRequest>, IDeepCloneable<SubscribeChannelRequest>, IBufferMessage
	{
		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600A0FE RID: 41214 RVA: 0x00272B64 File Offset: 0x00270D64
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeChannelRequest> Parser
		{
			get
			{
				return SubscribeChannelRequest._parser;
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x00272B7C File Offset: 0x00270D7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600A100 RID: 41216 RVA: 0x00272BA0 File Offset: 0x00270DA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeChannelRequest.Descriptor;
			}
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x00272BB7 File Offset: 0x00270DB7
		[DebuggerNonUserCode]
		public SubscribeChannelRequest()
		{
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x00272BC4 File Offset: 0x00270DC4
		[DebuggerNonUserCode]
		public SubscribeChannelRequest(SubscribeChannelRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.objectId_ = other.objectId_;
			this.agentIdentity_ = ((other.agentIdentity_ != null) ? other.agentIdentity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A103 RID: 41219 RVA: 0x00272C58 File Offset: 0x00270E58
		[DebuggerNonUserCode]
		public SubscribeChannelRequest Clone()
		{
			return new SubscribeChannelRequest(this);
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600A104 RID: 41220 RVA: 0x00272C70 File Offset: 0x00270E70
		// (set) Token: 0x0600A105 RID: 41221 RVA: 0x00272C88 File Offset: 0x00270E88
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

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600A106 RID: 41222 RVA: 0x00272C94 File Offset: 0x00270E94
		// (set) Token: 0x0600A107 RID: 41223 RVA: 0x00272CAC File Offset: 0x00270EAC
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

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600A108 RID: 41224 RVA: 0x00272CB8 File Offset: 0x00270EB8
		// (set) Token: 0x0600A109 RID: 41225 RVA: 0x00272CE9 File Offset: 0x00270EE9
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
					objectIdDefaultValue = SubscribeChannelRequest.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600A10A RID: 41226 RVA: 0x00272D04 File Offset: 0x00270F04
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x00272D21 File Offset: 0x00270F21
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600A10C RID: 41228 RVA: 0x00272D34 File Offset: 0x00270F34
		// (set) Token: 0x0600A10D RID: 41229 RVA: 0x00272D4C File Offset: 0x00270F4C
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

		// Token: 0x0600A10E RID: 41230 RVA: 0x00272D58 File Offset: 0x00270F58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeChannelRequest);
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x00272D78 File Offset: 0x00270F78
		[DebuggerNonUserCode]
		public bool Equals(SubscribeChannelRequest other)
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ObjectId != other.ObjectId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.AgentIdentity, other.AgentIdentity);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x00272E30 File Offset: 0x00271030
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
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
			bool flag3 = this.agentIdentity_ != null;
			if (flag3)
			{
				num ^= this.AgentIdentity.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x00272ED8 File Offset: 0x002710D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x00272EF0 File Offset: 0x002710F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x00272EFC File Offset: 0x002710FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag3 = this.agentIdentity_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AgentIdentity);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x00272FBC File Offset: 0x002711BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
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
			bool flag3 = this.agentIdentity_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentIdentity);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x00273070 File Offset: 0x00271270
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeChannelRequest other)
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
				bool flag6 = other.agentIdentity_ != null;
				if (flag6)
				{
					bool flag7 = this.agentIdentity_ == null;
					if (flag7)
					{
						this.AgentIdentity = new Identity();
					}
					this.AgentIdentity.MergeFrom(other.AgentIdentity);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x00273178 File Offset: 0x00271378
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x00273184 File Offset: 0x00271384
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002F;
						}
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new EntityId();
						}
						input.ReadMessage(this.ChannelId);
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
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag3 = this.agentIdentity_ == null;
					if (flag3)
					{
						this.AgentIdentity = new Identity();
					}
					input.ReadMessage(this.AgentIdentity);
				}
				else
				{
					this.ObjectId = input.ReadUInt64();
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400488E RID: 18574
		private static readonly MessageParser<SubscribeChannelRequest> _parser = new MessageParser<SubscribeChannelRequest>(() => new SubscribeChannelRequest());

		// Token: 0x0400488F RID: 18575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004890 RID: 18576
		private int _hasBits0;

		// Token: 0x04004891 RID: 18577
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004892 RID: 18578
		private EntityId agentId_;

		// Token: 0x04004893 RID: 18579
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x04004894 RID: 18580
		private EntityId channelId_;

		// Token: 0x04004895 RID: 18581
		public const int ObjectIdFieldNumber = 3;

		// Token: 0x04004896 RID: 18582
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04004897 RID: 18583
		private ulong objectId_;

		// Token: 0x04004898 RID: 18584
		public const int AgentIdentityFieldNumber = 4;

		// Token: 0x04004899 RID: 18585
		private Identity agentIdentity_;
	}
}
