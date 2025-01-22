using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000482 RID: 1154
	public sealed class MemberRemovedNotification : IMessage<MemberRemovedNotification>, IMessage, IEquatable<MemberRemovedNotification>, IDeepCloneable<MemberRemovedNotification>, IBufferMessage
	{
		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x001B5C40 File Offset: 0x001B3E40
		[DebuggerNonUserCode]
		public static MessageParser<MemberRemovedNotification> Parser
		{
			get
			{
				return MemberRemovedNotification._parser;
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x06007078 RID: 28792 RVA: 0x001B5C58 File Offset: 0x001B3E58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x001B5C7C File Offset: 0x001B3E7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRemovedNotification.Descriptor;
			}
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x001B5C93 File Offset: 0x001B3E93
		[DebuggerNonUserCode]
		public MemberRemovedNotification()
		{
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x001B5CA8 File Offset: 0x001B3EA8
		[DebuggerNonUserCode]
		public MemberRemovedNotification(MemberRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.member_ = other.member_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x001B5D14 File Offset: 0x001B3F14
		[DebuggerNonUserCode]
		public MemberRemovedNotification Clone()
		{
			return new MemberRemovedNotification(this);
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x001B5D2C File Offset: 0x001B3F2C
		// (set) Token: 0x0600707E RID: 28798 RVA: 0x001B5D44 File Offset: 0x001B3F44
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

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x001B5D50 File Offset: 0x001B3F50
		// (set) Token: 0x06007080 RID: 28800 RVA: 0x001B5D81 File Offset: 0x001B3F81
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
					clubIdDefaultValue = MemberRemovedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x001B5D9C File Offset: 0x001B3F9C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x001B5DB9 File Offset: 0x001B3FB9
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x001B5DCC File Offset: 0x001B3FCC
		[DebuggerNonUserCode]
		public RepeatedField<MemberRemovedAssignment> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x001B5DE4 File Offset: 0x001B3FE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRemovedNotification);
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x001B5E04 File Offset: 0x001B4004
		[DebuggerNonUserCode]
		public bool Equals(MemberRemovedNotification other)
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

		// Token: 0x06007086 RID: 28806 RVA: 0x001B5E98 File Offset: 0x001B4098
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

		// Token: 0x06007087 RID: 28807 RVA: 0x001B5F14 File Offset: 0x001B4114
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x001B5F2C File Offset: 0x001B412C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x001B5F38 File Offset: 0x001B4138
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
			this.member_.WriteTo(ref output, MemberRemovedNotification._repeated_member_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x001B5FBC File Offset: 0x001B41BC
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
			num += this.member_.CalculateSize(MemberRemovedNotification._repeated_member_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x001B6040 File Offset: 0x001B4240
		[DebuggerNonUserCode]
		public void MergeFrom(MemberRemovedNotification other)
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

		// Token: 0x0600708C RID: 28812 RVA: 0x001B60D7 File Offset: 0x001B42D7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x001B60E4 File Offset: 0x001B42E4
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
							this.member_.AddEntriesFrom(ref input, MemberRemovedNotification._repeated_member_codec);
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

		// Token: 0x04003391 RID: 13201
		private static readonly MessageParser<MemberRemovedNotification> _parser = new MessageParser<MemberRemovedNotification>(() => new MemberRemovedNotification());

		// Token: 0x04003392 RID: 13202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003393 RID: 13203
		private int _hasBits0;

		// Token: 0x04003394 RID: 13204
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003395 RID: 13205
		private MemberId agentId_;

		// Token: 0x04003396 RID: 13206
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003397 RID: 13207
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003398 RID: 13208
		private ulong clubId_;

		// Token: 0x04003399 RID: 13209
		public const int MemberFieldNumber = 4;

		// Token: 0x0400339A RID: 13210
		private static readonly FieldCodec<MemberRemovedAssignment> _repeated_member_codec = FieldCodec.ForMessage<MemberRemovedAssignment>(34U, MemberRemovedAssignment.Parser);

		// Token: 0x0400339B RID: 13211
		private readonly RepeatedField<MemberRemovedAssignment> member_ = new RepeatedField<MemberRemovedAssignment>();
	}
}
