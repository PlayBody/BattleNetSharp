using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A2 RID: 1186
	public sealed class GetClubTypeRequest : IMessage<GetClubTypeRequest>, IMessage, IEquatable<GetClubTypeRequest>, IDeepCloneable<GetClubTypeRequest>, IBufferMessage
	{
		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x06007363 RID: 29539 RVA: 0x001C2AA0 File Offset: 0x001C0CA0
		[DebuggerNonUserCode]
		public static MessageParser<GetClubTypeRequest> Parser
		{
			get
			{
				return GetClubTypeRequest._parser;
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x06007364 RID: 29540 RVA: 0x001C2AB8 File Offset: 0x001C0CB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x06007365 RID: 29541 RVA: 0x001C2ADC File Offset: 0x001C0CDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClubTypeRequest.Descriptor;
			}
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x001C2AF3 File Offset: 0x001C0CF3
		[DebuggerNonUserCode]
		public GetClubTypeRequest()
		{
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x001C2B00 File Offset: 0x001C0D00
		[DebuggerNonUserCode]
		public GetClubTypeRequest(GetClubTypeRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x001C2B60 File Offset: 0x001C0D60
		[DebuggerNonUserCode]
		public GetClubTypeRequest Clone()
		{
			return new GetClubTypeRequest(this);
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x06007369 RID: 29545 RVA: 0x001C2B78 File Offset: 0x001C0D78
		// (set) Token: 0x0600736A RID: 29546 RVA: 0x001C2B90 File Offset: 0x001C0D90
		[DebuggerNonUserCode]
		public MemberId AgentId
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

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x0600736B RID: 29547 RVA: 0x001C2B9C File Offset: 0x001C0D9C
		// (set) Token: 0x0600736C RID: 29548 RVA: 0x001C2BB4 File Offset: 0x001C0DB4
		[DebuggerNonUserCode]
		public UniqueClubType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x001C2BC0 File Offset: 0x001C0DC0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClubTypeRequest);
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x001C2BE0 File Offset: 0x001C0DE0
		[DebuggerNonUserCode]
		public bool Equals(GetClubTypeRequest other)
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
						bool flag5 = !object.Equals(this.Type, other.Type);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x001C2C58 File Offset: 0x001C0E58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.type_ != null;
			if (flag2)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x001C2CC4 File Offset: 0x001C0EC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x001C2CDC File Offset: 0x001C0EDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x001C2CE8 File Offset: 0x001C0EE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.type_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Type);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x001C2D5C File Offset: 0x001C0F5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.type_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x001C2DD0 File Offset: 0x001C0FD0
		[DebuggerNonUserCode]
		public void MergeFrom(GetClubTypeRequest other)
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
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.type_ != null;
				if (flag4)
				{
					bool flag5 = this.type_ == null;
					if (flag5)
					{
						this.Type = new UniqueClubType();
					}
					this.Type.MergeFrom(other.Type);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x001C2E7D File Offset: 0x001C107D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x001C2E88 File Offset: 0x001C1088
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.type_ == null;
						if (flag)
						{
							this.Type = new UniqueClubType();
						}
						input.ReadMessage(this.Type);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040034BC RID: 13500
		private static readonly MessageParser<GetClubTypeRequest> _parser = new MessageParser<GetClubTypeRequest>(() => new GetClubTypeRequest());

		// Token: 0x040034BD RID: 13501
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034BE RID: 13502
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034BF RID: 13503
		private MemberId agentId_;

		// Token: 0x040034C0 RID: 13504
		public const int TypeFieldNumber = 2;

		// Token: 0x040034C1 RID: 13505
		private UniqueClubType type_;
	}
}
