using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D9 RID: 1753
	public sealed class SendMessageRequest : IMessage<SendMessageRequest>, IMessage, IEquatable<SendMessageRequest>, IDeepCloneable<SendMessageRequest>, IBufferMessage
	{
		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600A19E RID: 41374 RVA: 0x00275678 File Offset: 0x00273878
		[DebuggerNonUserCode]
		public static MessageParser<SendMessageRequest> Parser
		{
			get
			{
				return SendMessageRequest._parser;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600A19F RID: 41375 RVA: 0x00275690 File Offset: 0x00273890
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600A1A0 RID: 41376 RVA: 0x002756B4 File Offset: 0x002738B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMessageRequest.Descriptor;
			}
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x002756CB File Offset: 0x002738CB
		[DebuggerNonUserCode]
		public SendMessageRequest()
		{
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x002756D8 File Offset: 0x002738D8
		[DebuggerNonUserCode]
		public SendMessageRequest(SendMessageRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this.requiredPrivileges_ = other.requiredPrivileges_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x00275750 File Offset: 0x00273950
		[DebuggerNonUserCode]
		public SendMessageRequest Clone()
		{
			return new SendMessageRequest(this);
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x00275768 File Offset: 0x00273968
		// (set) Token: 0x0600A1A5 RID: 41381 RVA: 0x00275780 File Offset: 0x00273980
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

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x0027578C File Offset: 0x0027398C
		// (set) Token: 0x0600A1A7 RID: 41383 RVA: 0x002757A4 File Offset: 0x002739A4
		[DebuggerNonUserCode]
		public Message Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600A1A8 RID: 41384 RVA: 0x002757B0 File Offset: 0x002739B0
		// (set) Token: 0x0600A1A9 RID: 41385 RVA: 0x002757E1 File Offset: 0x002739E1
		[DebuggerNonUserCode]
		public ulong RequiredPrivileges
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong requiredPrivilegesDefaultValue;
				if (flag)
				{
					requiredPrivilegesDefaultValue = this.requiredPrivileges_;
				}
				else
				{
					requiredPrivilegesDefaultValue = SendMessageRequest.RequiredPrivilegesDefaultValue;
				}
				return requiredPrivilegesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requiredPrivileges_ = value;
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600A1AA RID: 41386 RVA: 0x002757FC File Offset: 0x002739FC
		[DebuggerNonUserCode]
		public bool HasRequiredPrivileges
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x00275819 File Offset: 0x00273A19
		[DebuggerNonUserCode]
		public void ClearRequiredPrivileges()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x0027582C File Offset: 0x00273A2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendMessageRequest);
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x0027584C File Offset: 0x00273A4C
		[DebuggerNonUserCode]
		public bool Equals(SendMessageRequest other)
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
						bool flag5 = !object.Equals(this.Message, other.Message);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.RequiredPrivileges != other.RequiredPrivileges;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x002758E0 File Offset: 0x00273AE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				num ^= this.Message.GetHashCode();
			}
			bool hasRequiredPrivileges = this.HasRequiredPrivileges;
			if (hasRequiredPrivileges)
			{
				num ^= this.RequiredPrivileges.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x00275968 File Offset: 0x00273B68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x00275980 File Offset: 0x00273B80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x0027598C File Offset: 0x00273B8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Message);
			}
			bool hasRequiredPrivileges = this.HasRequiredPrivileges;
			if (hasRequiredPrivileges)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.RequiredPrivileges);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x00275A24 File Offset: 0x00273C24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.message_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool hasRequiredPrivileges = this.HasRequiredPrivileges;
			if (hasRequiredPrivileges)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RequiredPrivileges);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x00275AB4 File Offset: 0x00273CB4
		[DebuggerNonUserCode]
		public void MergeFrom(SendMessageRequest other)
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
				bool flag4 = other.message_ != null;
				if (flag4)
				{
					bool flag5 = this.message_ == null;
					if (flag5)
					{
						this.Message = new Message();
					}
					this.Message.MergeFrom(other.Message);
				}
				bool hasRequiredPrivileges = other.HasRequiredPrivileges;
				if (hasRequiredPrivileges)
				{
					this.RequiredPrivileges = other.RequiredPrivileges;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00275B7C File Offset: 0x00273D7C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x00275B88 File Offset: 0x00273D88
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
							this.RequiredPrivileges = input.ReadUInt64();
						}
					}
					else
					{
						bool flag = this.message_ == null;
						if (flag)
						{
							this.Message = new Message();
						}
						input.ReadMessage(this.Message);
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

		// Token: 0x040048D0 RID: 18640
		private static readonly MessageParser<SendMessageRequest> _parser = new MessageParser<SendMessageRequest>(() => new SendMessageRequest());

		// Token: 0x040048D1 RID: 18641
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048D2 RID: 18642
		private int _hasBits0;

		// Token: 0x040048D3 RID: 18643
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040048D4 RID: 18644
		private EntityId agentId_;

		// Token: 0x040048D5 RID: 18645
		public const int MessageFieldNumber = 2;

		// Token: 0x040048D6 RID: 18646
		private Message message_;

		// Token: 0x040048D7 RID: 18647
		public const int RequiredPrivilegesFieldNumber = 3;

		// Token: 0x040048D8 RID: 18648
		private static readonly ulong RequiredPrivilegesDefaultValue = 0UL;

		// Token: 0x040048D9 RID: 18649
		private ulong requiredPrivileges_;
	}
}
