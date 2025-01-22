using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000481 RID: 1153
	public sealed class MemberAddedNotification : IMessage<MemberAddedNotification>, IMessage, IEquatable<MemberAddedNotification>, IDeepCloneable<MemberAddedNotification>, IBufferMessage
	{
		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600705F RID: 28767 RVA: 0x001B56C4 File Offset: 0x001B38C4
		[DebuggerNonUserCode]
		public static MessageParser<MemberAddedNotification> Parser
		{
			get
			{
				return MemberAddedNotification._parser;
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x06007060 RID: 28768 RVA: 0x001B56DC File Offset: 0x001B38DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x001B5700 File Offset: 0x001B3900
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAddedNotification.Descriptor;
			}
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x001B5717 File Offset: 0x001B3917
		[DebuggerNonUserCode]
		public MemberAddedNotification()
		{
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x001B572C File Offset: 0x001B392C
		[DebuggerNonUserCode]
		public MemberAddedNotification(MemberAddedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.member_ = other.member_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x001B5798 File Offset: 0x001B3998
		[DebuggerNonUserCode]
		public MemberAddedNotification Clone()
		{
			return new MemberAddedNotification(this);
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x001B57B0 File Offset: 0x001B39B0
		// (set) Token: 0x06007066 RID: 28774 RVA: 0x001B57C8 File Offset: 0x001B39C8
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

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x001B57D4 File Offset: 0x001B39D4
		// (set) Token: 0x06007068 RID: 28776 RVA: 0x001B5805 File Offset: 0x001B3A05
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
					clubIdDefaultValue = MemberAddedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x001B5820 File Offset: 0x001B3A20
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600706A RID: 28778 RVA: 0x001B583D File Offset: 0x001B3A3D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600706B RID: 28779 RVA: 0x001B5850 File Offset: 0x001B3A50
		[DebuggerNonUserCode]
		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x001B5868 File Offset: 0x001B3A68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAddedNotification);
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x001B5888 File Offset: 0x001B3A88
		[DebuggerNonUserCode]
		public bool Equals(MemberAddedNotification other)
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
							bool flag6 = !this.member_.Equals(other.member_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x001B591C File Offset: 0x001B3B1C
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
			num ^= this.member_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x001B5998 File Offset: 0x001B3B98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x001B59B0 File Offset: 0x001B3BB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x001B59BC File Offset: 0x001B3BBC
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
				output.WriteRawTag(24);
				output.WriteUInt64(this.ClubId);
			}
			this.member_.WriteTo(ref output, MemberAddedNotification._repeated_member_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x001B5A40 File Offset: 0x001B3C40
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
			num += this.member_.CalculateSize(MemberAddedNotification._repeated_member_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x001B5AC4 File Offset: 0x001B3CC4
		[DebuggerNonUserCode]
		public void MergeFrom(MemberAddedNotification other)
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
				this.member_.Add(other.member_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x001B5B5B File Offset: 0x001B3D5B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x001B5B68 File Offset: 0x001B3D68
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
					if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.member_.AddEntriesFrom(ref input, MemberAddedNotification._repeated_member_codec);
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

		// Token: 0x04003386 RID: 13190
		private static readonly MessageParser<MemberAddedNotification> _parser = new MessageParser<MemberAddedNotification>(() => new MemberAddedNotification());

		// Token: 0x04003387 RID: 13191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003388 RID: 13192
		private int _hasBits0;

		// Token: 0x04003389 RID: 13193
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400338A RID: 13194
		private MemberId agentId_;

		// Token: 0x0400338B RID: 13195
		public const int ClubIdFieldNumber = 3;

		// Token: 0x0400338C RID: 13196
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400338D RID: 13197
		private ulong clubId_;

		// Token: 0x0400338E RID: 13198
		public const int MemberFieldNumber = 4;

		// Token: 0x0400338F RID: 13199
		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(34U, Bgs.Protocol.Club.V1.Member.Parser);

		// Token: 0x04003390 RID: 13200
		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();
	}
}
