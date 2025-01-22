using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C3 RID: 1219
	public sealed class DestroyTicketRequest : IMessage<DestroyTicketRequest>, IMessage, IEquatable<DestroyTicketRequest>, IDeepCloneable<DestroyTicketRequest>, IBufferMessage
	{
		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x0600768B RID: 30347 RVA: 0x001CE03C File Offset: 0x001CC23C
		[DebuggerNonUserCode]
		public static MessageParser<DestroyTicketRequest> Parser
		{
			get
			{
				return DestroyTicketRequest._parser;
			}
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x0600768C RID: 30348 RVA: 0x001CE054 File Offset: 0x001CC254
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[40];
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x0600768D RID: 30349 RVA: 0x001CE078 File Offset: 0x001CC278
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyTicketRequest.Descriptor;
			}
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x001CE08F File Offset: 0x001CC28F
		[DebuggerNonUserCode]
		public DestroyTicketRequest()
		{
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x001CE09C File Offset: 0x001CC29C
		[DebuggerNonUserCode]
		public DestroyTicketRequest(DestroyTicketRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.ticketId_ = other.ticketId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x001CE104 File Offset: 0x001CC304
		[DebuggerNonUserCode]
		public DestroyTicketRequest Clone()
		{
			return new DestroyTicketRequest(this);
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x001CE11C File Offset: 0x001CC31C
		// (set) Token: 0x06007692 RID: 30354 RVA: 0x001CE134 File Offset: 0x001CC334
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

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x06007693 RID: 30355 RVA: 0x001CE140 File Offset: 0x001CC340
		// (set) Token: 0x06007694 RID: 30356 RVA: 0x001CE171 File Offset: 0x001CC371
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = DestroyTicketRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x001CE18C File Offset: 0x001CC38C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x001CE1A9 File Offset: 0x001CC3A9
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x06007697 RID: 30359 RVA: 0x001CE1BC File Offset: 0x001CC3BC
		// (set) Token: 0x06007698 RID: 30360 RVA: 0x001CE1DD File Offset: 0x001CC3DD
		[DebuggerNonUserCode]
		public string TicketId
		{
			get
			{
				return this.ticketId_ ?? DestroyTicketRequest.TicketIdDefaultValue;
			}
			set
			{
				this.ticketId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x06007699 RID: 30361 RVA: 0x001CE1F4 File Offset: 0x001CC3F4
		[DebuggerNonUserCode]
		public bool HasTicketId
		{
			get
			{
				return this.ticketId_ != null;
			}
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x001CE20F File Offset: 0x001CC40F
		[DebuggerNonUserCode]
		public void ClearTicketId()
		{
			this.ticketId_ = null;
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x001CE21C File Offset: 0x001CC41C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyTicketRequest);
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x001CE23C File Offset: 0x001CC43C
		[DebuggerNonUserCode]
		public bool Equals(DestroyTicketRequest other)
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
						bool flag5 = this.ClubId != other.ClubId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TicketId != other.TicketId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x001CE2CC File Offset: 0x001CC4CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool hasTicketId = this.HasTicketId;
			if (hasTicketId)
			{
				num ^= this.TicketId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x001CE354 File Offset: 0x001CC554
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x001CE36C File Offset: 0x001CC56C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x001CE378 File Offset: 0x001CC578
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			bool hasTicketId = this.HasTicketId;
			if (hasTicketId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.TicketId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x001CE40C File Offset: 0x001CC60C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool hasTicketId = this.HasTicketId;
			if (hasTicketId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TicketId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x001CE49C File Offset: 0x001CC69C
		[DebuggerNonUserCode]
		public void MergeFrom(DestroyTicketRequest other)
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
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool hasTicketId = other.HasTicketId;
				if (hasTicketId)
				{
					this.TicketId = other.TicketId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x001CE53F File Offset: 0x001CC73F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x001CE54C File Offset: 0x001CC74C
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
							this.TicketId = input.ReadString();
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040035F5 RID: 13813
		private static readonly MessageParser<DestroyTicketRequest> _parser = new MessageParser<DestroyTicketRequest>(() => new DestroyTicketRequest());

		// Token: 0x040035F6 RID: 13814
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035F7 RID: 13815
		private int _hasBits0;

		// Token: 0x040035F8 RID: 13816
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040035F9 RID: 13817
		private MemberId agentId_;

		// Token: 0x040035FA RID: 13818
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040035FB RID: 13819
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040035FC RID: 13820
		private ulong clubId_;

		// Token: 0x040035FD RID: 13821
		public const int TicketIdFieldNumber = 3;

		// Token: 0x040035FE RID: 13822
		private static readonly string TicketIdDefaultValue = "";

		// Token: 0x040035FF RID: 13823
		private string ticketId_;
	}
}
