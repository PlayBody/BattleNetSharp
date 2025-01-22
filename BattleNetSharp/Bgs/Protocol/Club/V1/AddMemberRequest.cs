using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A6 RID: 1190
	public sealed class AddMemberRequest : IMessage<AddMemberRequest>, IMessage, IEquatable<AddMemberRequest>, IDeepCloneable<AddMemberRequest>, IBufferMessage
	{
		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x060073C3 RID: 29635 RVA: 0x001C42C4 File Offset: 0x001C24C4
		[DebuggerNonUserCode]
		public static MessageParser<AddMemberRequest> Parser
		{
			get
			{
				return AddMemberRequest._parser;
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x060073C4 RID: 29636 RVA: 0x001C42DC File Offset: 0x001C24DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x060073C5 RID: 29637 RVA: 0x001C4300 File Offset: 0x001C2500
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddMemberRequest.Descriptor;
			}
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x001C4317 File Offset: 0x001C2517
		[DebuggerNonUserCode]
		public AddMemberRequest()
		{
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x001C4324 File Offset: 0x001C2524
		[DebuggerNonUserCode]
		public AddMemberRequest(AddMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x001C439C File Offset: 0x001C259C
		[DebuggerNonUserCode]
		public AddMemberRequest Clone()
		{
			return new AddMemberRequest(this);
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x060073C9 RID: 29641 RVA: 0x001C43B4 File Offset: 0x001C25B4
		// (set) Token: 0x060073CA RID: 29642 RVA: 0x001C43CC File Offset: 0x001C25CC
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

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x060073CB RID: 29643 RVA: 0x001C43D8 File Offset: 0x001C25D8
		// (set) Token: 0x060073CC RID: 29644 RVA: 0x001C4409 File Offset: 0x001C2609
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
					clubIdDefaultValue = AddMemberRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x060073CD RID: 29645 RVA: 0x001C4424 File Offset: 0x001C2624
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x001C4441 File Offset: 0x001C2641
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x060073CF RID: 29647 RVA: 0x001C4454 File Offset: 0x001C2654
		// (set) Token: 0x060073D0 RID: 29648 RVA: 0x001C446C File Offset: 0x001C266C
		[DebuggerNonUserCode]
		public CreateMemberOptions Options
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

		// Token: 0x060073D1 RID: 29649 RVA: 0x001C4478 File Offset: 0x001C2678
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddMemberRequest);
		}

		// Token: 0x060073D2 RID: 29650 RVA: 0x001C4498 File Offset: 0x001C2698
		[DebuggerNonUserCode]
		public bool Equals(AddMemberRequest other)
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

		// Token: 0x060073D3 RID: 29651 RVA: 0x001C452C File Offset: 0x001C272C
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

		// Token: 0x060073D4 RID: 29652 RVA: 0x001C45B8 File Offset: 0x001C27B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x001C45D0 File Offset: 0x001C27D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x001C45DC File Offset: 0x001C27DC
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

		// Token: 0x060073D7 RID: 29655 RVA: 0x001C4674 File Offset: 0x001C2874
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

		// Token: 0x060073D8 RID: 29656 RVA: 0x001C4704 File Offset: 0x001C2904
		[DebuggerNonUserCode]
		public void MergeFrom(AddMemberRequest other)
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
						this.Options = new CreateMemberOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x001C47CC File Offset: 0x001C29CC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x001C47D8 File Offset: 0x001C29D8
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
								this.Options = new CreateMemberOptions();
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

		// Token: 0x040034E4 RID: 13540
		private static readonly MessageParser<AddMemberRequest> _parser = new MessageParser<AddMemberRequest>(() => new AddMemberRequest());

		// Token: 0x040034E5 RID: 13541
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034E6 RID: 13542
		private int _hasBits0;

		// Token: 0x040034E7 RID: 13543
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034E8 RID: 13544
		private MemberId agentId_;

		// Token: 0x040034E9 RID: 13545
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040034EA RID: 13546
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034EB RID: 13547
		private ulong clubId_;

		// Token: 0x040034EC RID: 13548
		public const int OptionsFieldNumber = 3;

		// Token: 0x040034ED RID: 13549
		private CreateMemberOptions options_;
	}
}
