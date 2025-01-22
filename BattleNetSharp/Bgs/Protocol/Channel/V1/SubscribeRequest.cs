using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006BC RID: 1724
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x06009F5D RID: 40797 RVA: 0x0026C220 File Offset: 0x0026A420
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x0026C238 File Offset: 0x0026A438
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x06009F5F RID: 40799 RVA: 0x0026C25C File Offset: 0x0026A45C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x0026C273 File Offset: 0x0026A473
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x06009F61 RID: 40801 RVA: 0x0026C280 File Offset: 0x0026A480
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.objectId_ = other.objectId_;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F62 RID: 40802 RVA: 0x0026C2F8 File Offset: 0x0026A4F8
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x06009F63 RID: 40803 RVA: 0x0026C310 File Offset: 0x0026A510
		// (set) Token: 0x06009F64 RID: 40804 RVA: 0x0026C328 File Offset: 0x0026A528
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

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x06009F65 RID: 40805 RVA: 0x0026C334 File Offset: 0x0026A534
		// (set) Token: 0x06009F66 RID: 40806 RVA: 0x0026C365 File Offset: 0x0026A565
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

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x06009F67 RID: 40807 RVA: 0x0026C380 File Offset: 0x0026A580
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009F68 RID: 40808 RVA: 0x0026C39D File Offset: 0x0026A59D
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x06009F69 RID: 40809 RVA: 0x0026C3B0 File Offset: 0x0026A5B0
		// (set) Token: 0x06009F6A RID: 40810 RVA: 0x0026C3C8 File Offset: 0x0026A5C8
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x0026C3D4 File Offset: 0x0026A5D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x0026C3F4 File Offset: 0x0026A5F4
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.AccountId, other.AccountId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x0026C488 File Offset: 0x0026A688
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
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x0026C514 File Offset: 0x0026A714
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F6F RID: 40815 RVA: 0x0026C52C File Offset: 0x0026A72C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x0026C538 File Offset: 0x0026A738
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
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AccountId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x0026C5D0 File Offset: 0x0026A7D0
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
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x0026C660 File Offset: 0x0026A860
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
				bool flag4 = other.accountId_ != null;
				if (flag4)
				{
					bool flag5 = this.accountId_ == null;
					if (flag5)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009F73 RID: 40819 RVA: 0x0026C728 File Offset: 0x0026A928
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F74 RID: 40820 RVA: 0x0026C734 File Offset: 0x0026A934
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.accountId_ == null;
							if (flag)
							{
								this.AccountId = new EntityId();
							}
							input.ReadMessage(this.AccountId);
						}
					}
					else
					{
						this.ObjectId = input.ReadUInt64();
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

		// Token: 0x040047D8 RID: 18392
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x040047D9 RID: 18393
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047DA RID: 18394
		private int _hasBits0;

		// Token: 0x040047DB RID: 18395
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040047DC RID: 18396
		private EntityId agentId_;

		// Token: 0x040047DD RID: 18397
		public const int ObjectIdFieldNumber = 2;

		// Token: 0x040047DE RID: 18398
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x040047DF RID: 18399
		private ulong objectId_;

		// Token: 0x040047E0 RID: 18400
		public const int AccountIdFieldNumber = 3;

		// Token: 0x040047E1 RID: 18401
		private EntityId accountId_;
	}
}
