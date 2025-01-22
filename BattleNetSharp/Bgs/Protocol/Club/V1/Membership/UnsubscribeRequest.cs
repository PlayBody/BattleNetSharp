using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200051B RID: 1307
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x06007F1F RID: 32543 RVA: 0x001EF400 File Offset: 0x001ED600
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x06007F20 RID: 32544 RVA: 0x001EF418 File Offset: 0x001ED618
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x06007F21 RID: 32545 RVA: 0x001EF43C File Offset: 0x001ED63C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x001EF453 File Offset: 0x001ED653
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x06007F23 RID: 32547 RVA: 0x001EF45D File Offset: 0x001ED65D
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F24 RID: 32548 RVA: 0x001EF494 File Offset: 0x001ED694
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x06007F25 RID: 32549 RVA: 0x001EF4AC File Offset: 0x001ED6AC
		// (set) Token: 0x06007F26 RID: 32550 RVA: 0x001EF4C4 File Offset: 0x001ED6C4
		[DebuggerNonUserCode]
		public AccountId AgentId
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

		// Token: 0x06007F27 RID: 32551 RVA: 0x001EF4D0 File Offset: 0x001ED6D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x001EF4F0 File Offset: 0x001ED6F0
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x001EF54C File Offset: 0x001ED74C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x001EF59C File Offset: 0x001ED79C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x001EF5B4 File Offset: 0x001ED7B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F2C RID: 32556 RVA: 0x001EF5C0 File Offset: 0x001ED7C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F2D RID: 32557 RVA: 0x001EF610 File Offset: 0x001ED810
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F2E RID: 32558 RVA: 0x001EF664 File Offset: 0x001ED864
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x001EF6D0 File Offset: 0x001ED8D0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x001EF6DC File Offset: 0x001ED8DC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040039C6 RID: 14790
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x040039C7 RID: 14791
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C8 RID: 14792
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039C9 RID: 14793
		private AccountId agentId_;
	}
}
