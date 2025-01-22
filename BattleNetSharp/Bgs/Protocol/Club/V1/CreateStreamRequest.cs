using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D1 RID: 1233
	public sealed class CreateStreamRequest : IMessage<CreateStreamRequest>, IMessage, IEquatable<CreateStreamRequest>, IDeepCloneable<CreateStreamRequest>, IBufferMessage
	{
		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x001D2778 File Offset: 0x001D0978
		[DebuggerNonUserCode]
		public static MessageParser<CreateStreamRequest> Parser
		{
			get
			{
				return CreateStreamRequest._parser;
			}
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x060077D8 RID: 30680 RVA: 0x001D2790 File Offset: 0x001D0990
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[54];
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x001D27B4 File Offset: 0x001D09B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateStreamRequest.Descriptor;
			}
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x001D27CB File Offset: 0x001D09CB
		[DebuggerNonUserCode]
		public CreateStreamRequest()
		{
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x001D27D8 File Offset: 0x001D09D8
		[DebuggerNonUserCode]
		public CreateStreamRequest(CreateStreamRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x001D2850 File Offset: 0x001D0A50
		[DebuggerNonUserCode]
		public CreateStreamRequest Clone()
		{
			return new CreateStreamRequest(this);
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x001D2868 File Offset: 0x001D0A68
		// (set) Token: 0x060077DE RID: 30686 RVA: 0x001D2880 File Offset: 0x001D0A80
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

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x001D288C File Offset: 0x001D0A8C
		// (set) Token: 0x060077E0 RID: 30688 RVA: 0x001D28BD File Offset: 0x001D0ABD
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
					clubIdDefaultValue = CreateStreamRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x060077E1 RID: 30689 RVA: 0x001D28D8 File Offset: 0x001D0AD8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x001D28F5 File Offset: 0x001D0AF5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x060077E3 RID: 30691 RVA: 0x001D2908 File Offset: 0x001D0B08
		// (set) Token: 0x060077E4 RID: 30692 RVA: 0x001D2920 File Offset: 0x001D0B20
		[DebuggerNonUserCode]
		public CreateStreamOptions Options
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

		// Token: 0x060077E5 RID: 30693 RVA: 0x001D292C File Offset: 0x001D0B2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateStreamRequest);
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x001D294C File Offset: 0x001D0B4C
		[DebuggerNonUserCode]
		public bool Equals(CreateStreamRequest other)
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

		// Token: 0x060077E7 RID: 30695 RVA: 0x001D29E0 File Offset: 0x001D0BE0
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

		// Token: 0x060077E8 RID: 30696 RVA: 0x001D2A6C File Offset: 0x001D0C6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x001D2A84 File Offset: 0x001D0C84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x001D2A90 File Offset: 0x001D0C90
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

		// Token: 0x060077EB RID: 30699 RVA: 0x001D2B28 File Offset: 0x001D0D28
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

		// Token: 0x060077EC RID: 30700 RVA: 0x001D2BB8 File Offset: 0x001D0DB8
		[DebuggerNonUserCode]
		public void MergeFrom(CreateStreamRequest other)
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
						this.Options = new CreateStreamOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x001D2C80 File Offset: 0x001D0E80
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x001D2C8C File Offset: 0x001D0E8C
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
								this.Options = new CreateStreamOptions();
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

		// Token: 0x04003672 RID: 13938
		private static readonly MessageParser<CreateStreamRequest> _parser = new MessageParser<CreateStreamRequest>(() => new CreateStreamRequest());

		// Token: 0x04003673 RID: 13939
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003674 RID: 13940
		private int _hasBits0;

		// Token: 0x04003675 RID: 13941
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003676 RID: 13942
		private MemberId agentId_;

		// Token: 0x04003677 RID: 13943
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003678 RID: 13944
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003679 RID: 13945
		private ulong clubId_;

		// Token: 0x0400367A RID: 13946
		public const int OptionsFieldNumber = 3;

		// Token: 0x0400367B RID: 13947
		private CreateStreamOptions options_;
	}
}
