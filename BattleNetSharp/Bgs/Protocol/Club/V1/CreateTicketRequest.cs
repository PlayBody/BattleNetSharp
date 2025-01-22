using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004C1 RID: 1217
	public sealed class CreateTicketRequest : IMessage<CreateTicketRequest>, IMessage, IEquatable<CreateTicketRequest>, IDeepCloneable<CreateTicketRequest>, IBufferMessage
	{
		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x0600765F RID: 30303 RVA: 0x001CD6DC File Offset: 0x001CB8DC
		[DebuggerNonUserCode]
		public static MessageParser<CreateTicketRequest> Parser
		{
			get
			{
				return CreateTicketRequest._parser;
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06007660 RID: 30304 RVA: 0x001CD6F4 File Offset: 0x001CB8F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[38];
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x06007661 RID: 30305 RVA: 0x001CD718 File Offset: 0x001CB918
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateTicketRequest.Descriptor;
			}
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x001CD72F File Offset: 0x001CB92F
		[DebuggerNonUserCode]
		public CreateTicketRequest()
		{
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x001CD73C File Offset: 0x001CB93C
		[DebuggerNonUserCode]
		public CreateTicketRequest(CreateTicketRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x001CD7B4 File Offset: 0x001CB9B4
		[DebuggerNonUserCode]
		public CreateTicketRequest Clone()
		{
			return new CreateTicketRequest(this);
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x06007665 RID: 30309 RVA: 0x001CD7CC File Offset: 0x001CB9CC
		// (set) Token: 0x06007666 RID: 30310 RVA: 0x001CD7E4 File Offset: 0x001CB9E4
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

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x06007667 RID: 30311 RVA: 0x001CD7F0 File Offset: 0x001CB9F0
		// (set) Token: 0x06007668 RID: 30312 RVA: 0x001CD821 File Offset: 0x001CBA21
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
					clubIdDefaultValue = CreateTicketRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x06007669 RID: 30313 RVA: 0x001CD83C File Offset: 0x001CBA3C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x001CD859 File Offset: 0x001CBA59
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x0600766B RID: 30315 RVA: 0x001CD86C File Offset: 0x001CBA6C
		// (set) Token: 0x0600766C RID: 30316 RVA: 0x001CD884 File Offset: 0x001CBA84
		[DebuggerNonUserCode]
		public CreateTicketOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x001CD890 File Offset: 0x001CBA90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateTicketRequest);
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x001CD8B0 File Offset: 0x001CBAB0
		[DebuggerNonUserCode]
		public bool Equals(CreateTicketRequest other)
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
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x001CD944 File Offset: 0x001CBB44
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x001CD9D0 File Offset: 0x001CBBD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x001CD9E8 File Offset: 0x001CBBE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x001CD9F4 File Offset: 0x001CBBF4
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x001CDA8C File Offset: 0x001CBC8C
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
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x001CDB1C File Offset: 0x001CBD1C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateTicketRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new CreateTicketOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x001CDBE4 File Offset: 0x001CBDE4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x001CDBF0 File Offset: 0x001CBDF0
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
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new CreateTicketOptions();
							}
							input.ReadMessage(this.Options);
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
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

		// Token: 0x040035E7 RID: 13799
		private static readonly MessageParser<CreateTicketRequest> _parser = new MessageParser<CreateTicketRequest>(() => new CreateTicketRequest());

		// Token: 0x040035E8 RID: 13800
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035E9 RID: 13801
		private int _hasBits0;

		// Token: 0x040035EA RID: 13802
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040035EB RID: 13803
		private MemberId agentId_;

		// Token: 0x040035EC RID: 13804
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040035ED RID: 13805
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040035EE RID: 13806
		private ulong clubId_;

		// Token: 0x040035EF RID: 13807
		public const int OptionsFieldNumber = 3;

		// Token: 0x040035F0 RID: 13808
		private CreateTicketOptions options_;
	}
}
