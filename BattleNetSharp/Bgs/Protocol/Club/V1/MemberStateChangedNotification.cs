using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000483 RID: 1155
	public sealed class MemberStateChangedNotification : IMessage<MemberStateChangedNotification>, IMessage, IEquatable<MemberStateChangedNotification>, IDeepCloneable<MemberStateChangedNotification>, IBufferMessage
	{
		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600708F RID: 28815 RVA: 0x001B61BC File Offset: 0x001B43BC
		[DebuggerNonUserCode]
		public static MessageParser<MemberStateChangedNotification> Parser
		{
			get
			{
				return MemberStateChangedNotification._parser;
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x06007090 RID: 28816 RVA: 0x001B61D4 File Offset: 0x001B43D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x06007091 RID: 28817 RVA: 0x001B61F8 File Offset: 0x001B43F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberStateChangedNotification.Descriptor;
			}
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x001B620F File Offset: 0x001B440F
		[DebuggerNonUserCode]
		public MemberStateChangedNotification()
		{
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x001B6224 File Offset: 0x001B4424
		[DebuggerNonUserCode]
		public MemberStateChangedNotification(MemberStateChangedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.assignment_ = other.assignment_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x001B6290 File Offset: 0x001B4490
		[DebuggerNonUserCode]
		public MemberStateChangedNotification Clone()
		{
			return new MemberStateChangedNotification(this);
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x06007095 RID: 28821 RVA: 0x001B62A8 File Offset: 0x001B44A8
		// (set) Token: 0x06007096 RID: 28822 RVA: 0x001B62C0 File Offset: 0x001B44C0
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

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x06007097 RID: 28823 RVA: 0x001B62CC File Offset: 0x001B44CC
		// (set) Token: 0x06007098 RID: 28824 RVA: 0x001B62FD File Offset: 0x001B44FD
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
					clubIdDefaultValue = MemberStateChangedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x001B6318 File Offset: 0x001B4518
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x001B6335 File Offset: 0x001B4535
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600709B RID: 28827 RVA: 0x001B6348 File Offset: 0x001B4548
		[DebuggerNonUserCode]
		public RepeatedField<MemberStateAssignment> Assignment
		{
			get
			{
				return this.assignment_;
			}
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x001B6360 File Offset: 0x001B4560
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberStateChangedNotification);
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x001B6380 File Offset: 0x001B4580
		[DebuggerNonUserCode]
		public bool Equals(MemberStateChangedNotification other)
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

		// Token: 0x0600709E RID: 28830 RVA: 0x001B6414 File Offset: 0x001B4614
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

		// Token: 0x0600709F RID: 28831 RVA: 0x001B6490 File Offset: 0x001B4690
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x001B64A8 File Offset: 0x001B46A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x001B64B4 File Offset: 0x001B46B4
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
			this.assignment_.WriteTo(ref output, MemberStateChangedNotification._repeated_assignment_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x001B6538 File Offset: 0x001B4738
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
			num += this.assignment_.CalculateSize(MemberStateChangedNotification._repeated_assignment_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x001B65BC File Offset: 0x001B47BC
		[DebuggerNonUserCode]
		public void MergeFrom(MemberStateChangedNotification other)
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

		// Token: 0x060070A4 RID: 28836 RVA: 0x001B6653 File Offset: 0x001B4853
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x001B6660 File Offset: 0x001B4860
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
							this.assignment_.AddEntriesFrom(ref input, MemberStateChangedNotification._repeated_assignment_codec);
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

		// Token: 0x0400339C RID: 13212
		private static readonly MessageParser<MemberStateChangedNotification> _parser = new MessageParser<MemberStateChangedNotification>(() => new MemberStateChangedNotification());

		// Token: 0x0400339D RID: 13213
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400339E RID: 13214
		private int _hasBits0;

		// Token: 0x0400339F RID: 13215
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033A0 RID: 13216
		private MemberId agentId_;

		// Token: 0x040033A1 RID: 13217
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033A2 RID: 13218
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033A3 RID: 13219
		private ulong clubId_;

		// Token: 0x040033A4 RID: 13220
		public const int AssignmentFieldNumber = 4;

		// Token: 0x040033A5 RID: 13221
		private static readonly FieldCodec<MemberStateAssignment> _repeated_assignment_codec = FieldCodec.ForMessage<MemberStateAssignment>(34U, MemberStateAssignment.Parser);

		// Token: 0x040033A6 RID: 13222
		private readonly RepeatedField<MemberStateAssignment> assignment_ = new RepeatedField<MemberStateAssignment>();
	}
}
