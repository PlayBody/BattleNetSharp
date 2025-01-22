using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000485 RID: 1157
	public sealed class MemberRoleChangedNotification : IMessage<MemberRoleChangedNotification>, IMessage, IEquatable<MemberRoleChangedNotification>, IDeepCloneable<MemberRoleChangedNotification>, IBufferMessage
	{
		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x001B6CB4 File Offset: 0x001B4EB4
		[DebuggerNonUserCode]
		public static MessageParser<MemberRoleChangedNotification> Parser
		{
			get
			{
				return MemberRoleChangedNotification._parser;
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x060070C0 RID: 28864 RVA: 0x001B6CCC File Offset: 0x001B4ECC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x060070C1 RID: 28865 RVA: 0x001B6CF0 File Offset: 0x001B4EF0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRoleChangedNotification.Descriptor;
			}
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x001B6D07 File Offset: 0x001B4F07
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification()
		{
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x001B6D1C File Offset: 0x001B4F1C
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification(MemberRoleChangedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.assignment_ = other.assignment_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x001B6D88 File Offset: 0x001B4F88
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification Clone()
		{
			return new MemberRoleChangedNotification(this);
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x060070C5 RID: 28869 RVA: 0x001B6DA0 File Offset: 0x001B4FA0
		// (set) Token: 0x060070C6 RID: 28870 RVA: 0x001B6DB8 File Offset: 0x001B4FB8
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

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x060070C7 RID: 28871 RVA: 0x001B6DC4 File Offset: 0x001B4FC4
		// (set) Token: 0x060070C8 RID: 28872 RVA: 0x001B6DF5 File Offset: 0x001B4FF5
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
					clubIdDefaultValue = MemberRoleChangedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x060070C9 RID: 28873 RVA: 0x001B6E10 File Offset: 0x001B5010
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x001B6E2D File Offset: 0x001B502D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x060070CB RID: 28875 RVA: 0x001B6E40 File Offset: 0x001B5040
		[DebuggerNonUserCode]
		public RepeatedField<RoleAssignment> Assignment
		{
			get
			{
				return this.assignment_;
			}
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x001B6E58 File Offset: 0x001B5058
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRoleChangedNotification);
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x001B6E78 File Offset: 0x001B5078
		[DebuggerNonUserCode]
		public bool Equals(MemberRoleChangedNotification other)
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
							bool flag6 = !this.assignment_.Equals(other.assignment_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x001B6F0C File Offset: 0x001B510C
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
			num ^= this.assignment_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x001B6F88 File Offset: 0x001B5188
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x001B6FA0 File Offset: 0x001B51A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x001B6FAC File Offset: 0x001B51AC
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
			this.assignment_.WriteTo(ref output, MemberRoleChangedNotification._repeated_assignment_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x001B7030 File Offset: 0x001B5230
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
			num += this.assignment_.CalculateSize(MemberRoleChangedNotification._repeated_assignment_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x001B70B4 File Offset: 0x001B52B4
		[DebuggerNonUserCode]
		public void MergeFrom(MemberRoleChangedNotification other)
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
				this.assignment_.Add(other.assignment_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x001B714B File Offset: 0x001B534B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x001B7158 File Offset: 0x001B5358
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
							this.assignment_.AddEntriesFrom(ref input, MemberRoleChangedNotification._repeated_assignment_codec);
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

		// Token: 0x040033B2 RID: 13234
		private static readonly MessageParser<MemberRoleChangedNotification> _parser = new MessageParser<MemberRoleChangedNotification>(() => new MemberRoleChangedNotification());

		// Token: 0x040033B3 RID: 13235
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033B4 RID: 13236
		private int _hasBits0;

		// Token: 0x040033B5 RID: 13237
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033B6 RID: 13238
		private MemberId agentId_;

		// Token: 0x040033B7 RID: 13239
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033B8 RID: 13240
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033B9 RID: 13241
		private ulong clubId_;

		// Token: 0x040033BA RID: 13242
		public const int AssignmentFieldNumber = 4;

		// Token: 0x040033BB RID: 13243
		private static readonly FieldCodec<RoleAssignment> _repeated_assignment_codec = FieldCodec.ForMessage<RoleAssignment>(34U, RoleAssignment.Parser);

		// Token: 0x040033BC RID: 13244
		private readonly RepeatedField<RoleAssignment> assignment_ = new RepeatedField<RoleAssignment>();
	}
}
