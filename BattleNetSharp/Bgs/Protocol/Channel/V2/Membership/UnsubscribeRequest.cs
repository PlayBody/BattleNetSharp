using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006AC RID: 1708
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06009E37 RID: 40503 RVA: 0x00267AA0 File Offset: 0x00265CA0
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x00267AB8 File Offset: 0x00265CB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x00267ADC File Offset: 0x00265CDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06009E3A RID: 40506 RVA: 0x00267AF3 File Offset: 0x00265CF3
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x00267AFD File Offset: 0x00265CFD
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x00267B34 File Offset: 0x00265D34
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x06009E3D RID: 40509 RVA: 0x00267B4C File Offset: 0x00265D4C
		// (set) Token: 0x06009E3E RID: 40510 RVA: 0x00267B64 File Offset: 0x00265D64
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
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

		// Token: 0x06009E3F RID: 40511 RVA: 0x00267B70 File Offset: 0x00265D70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x06009E40 RID: 40512 RVA: 0x00267B90 File Offset: 0x00265D90
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

		// Token: 0x06009E41 RID: 40513 RVA: 0x00267BEC File Offset: 0x00265DEC
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

		// Token: 0x06009E42 RID: 40514 RVA: 0x00267C3C File Offset: 0x00265E3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x00267C54 File Offset: 0x00265E54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x00267C60 File Offset: 0x00265E60
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

		// Token: 0x06009E45 RID: 40517 RVA: 0x00267CB0 File Offset: 0x00265EB0
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

		// Token: 0x06009E46 RID: 40518 RVA: 0x00267D04 File Offset: 0x00265F04
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
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x00267D70 File Offset: 0x00265F70
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x00267D7C File Offset: 0x00265F7C
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
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04004764 RID: 18276
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x04004765 RID: 18277
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004766 RID: 18278
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004767 RID: 18279
		private GameAccountHandle agentId_;
	}
}
