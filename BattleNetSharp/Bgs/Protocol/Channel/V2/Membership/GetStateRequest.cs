using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Membership
{
	// Token: 0x020006AD RID: 1709
	public sealed class GetStateRequest : IMessage<GetStateRequest>, IMessage, IEquatable<GetStateRequest>, IDeepCloneable<GetStateRequest>, IBufferMessage
	{
		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x06009E4A RID: 40522 RVA: 0x00267E08 File Offset: 0x00266008
		[DebuggerNonUserCode]
		public static MessageParser<GetStateRequest> Parser
		{
			get
			{
				return GetStateRequest._parser;
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x06009E4B RID: 40523 RVA: 0x00267E20 File Offset: 0x00266020
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelMembershipServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x06009E4C RID: 40524 RVA: 0x00267E44 File Offset: 0x00266044
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateRequest.Descriptor;
			}
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x00267E5B File Offset: 0x0026605B
		[DebuggerNonUserCode]
		public GetStateRequest()
		{
		}

		// Token: 0x06009E4E RID: 40526 RVA: 0x00267E65 File Offset: 0x00266065
		[DebuggerNonUserCode]
		public GetStateRequest(GetStateRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x00267E9C File Offset: 0x0026609C
		[DebuggerNonUserCode]
		public GetStateRequest Clone()
		{
			return new GetStateRequest(this);
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x06009E50 RID: 40528 RVA: 0x00267EB4 File Offset: 0x002660B4
		// (set) Token: 0x06009E51 RID: 40529 RVA: 0x00267ECC File Offset: 0x002660CC
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

		// Token: 0x06009E52 RID: 40530 RVA: 0x00267ED8 File Offset: 0x002660D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateRequest);
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x00267EF8 File Offset: 0x002660F8
		[DebuggerNonUserCode]
		public bool Equals(GetStateRequest other)
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

		// Token: 0x06009E54 RID: 40532 RVA: 0x00267F54 File Offset: 0x00266154
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

		// Token: 0x06009E55 RID: 40533 RVA: 0x00267FA4 File Offset: 0x002661A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x00267FBC File Offset: 0x002661BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E57 RID: 40535 RVA: 0x00267FC8 File Offset: 0x002661C8
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

		// Token: 0x06009E58 RID: 40536 RVA: 0x00268018 File Offset: 0x00266218
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

		// Token: 0x06009E59 RID: 40537 RVA: 0x0026806C File Offset: 0x0026626C
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateRequest other)
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

		// Token: 0x06009E5A RID: 40538 RVA: 0x002680D8 File Offset: 0x002662D8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x002680E4 File Offset: 0x002662E4
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

		// Token: 0x04004768 RID: 18280
		private static readonly MessageParser<GetStateRequest> _parser = new MessageParser<GetStateRequest>(() => new GetStateRequest());

		// Token: 0x04004769 RID: 18281
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400476A RID: 18282
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400476B RID: 18283
		private GameAccountHandle agentId_;
	}
}
