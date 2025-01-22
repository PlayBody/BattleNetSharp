using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000484 RID: 1156
	public sealed class SubscriberStateChangedNotification : IMessage<SubscriberStateChangedNotification>, IMessage, IEquatable<SubscriberStateChangedNotification>, IDeepCloneable<SubscriberStateChangedNotification>, IBufferMessage
	{
		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x060070A7 RID: 28839 RVA: 0x001B6738 File Offset: 0x001B4938
		[DebuggerNonUserCode]
		public static MessageParser<SubscriberStateChangedNotification> Parser
		{
			get
			{
				return SubscriberStateChangedNotification._parser;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x001B6750 File Offset: 0x001B4950
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x060070A9 RID: 28841 RVA: 0x001B6774 File Offset: 0x001B4974
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriberStateChangedNotification.Descriptor;
			}
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x001B678B File Offset: 0x001B498B
		[DebuggerNonUserCode]
		public SubscriberStateChangedNotification()
		{
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x001B67A0 File Offset: 0x001B49A0
		[DebuggerNonUserCode]
		public SubscriberStateChangedNotification(SubscriberStateChangedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.assignment_ = other.assignment_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x001B680C File Offset: 0x001B4A0C
		[DebuggerNonUserCode]
		public SubscriberStateChangedNotification Clone()
		{
			return new SubscriberStateChangedNotification(this);
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x060070AD RID: 28845 RVA: 0x001B6824 File Offset: 0x001B4A24
		// (set) Token: 0x060070AE RID: 28846 RVA: 0x001B683C File Offset: 0x001B4A3C
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

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x001B6848 File Offset: 0x001B4A48
		// (set) Token: 0x060070B0 RID: 28848 RVA: 0x001B6879 File Offset: 0x001B4A79
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
					clubIdDefaultValue = SubscriberStateChangedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x060070B1 RID: 28849 RVA: 0x001B6894 File Offset: 0x001B4A94
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x001B68B1 File Offset: 0x001B4AB1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x060070B3 RID: 28851 RVA: 0x001B68C4 File Offset: 0x001B4AC4
		[DebuggerNonUserCode]
		public RepeatedField<SubscriberStateAssignment> Assignment
		{
			get
			{
				return this.assignment_;
			}
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x001B68DC File Offset: 0x001B4ADC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriberStateChangedNotification);
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x001B68FC File Offset: 0x001B4AFC
		[DebuggerNonUserCode]
		public bool Equals(SubscriberStateChangedNotification other)
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

		// Token: 0x060070B6 RID: 28854 RVA: 0x001B6990 File Offset: 0x001B4B90
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

		// Token: 0x060070B7 RID: 28855 RVA: 0x001B6A0C File Offset: 0x001B4C0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x001B6A24 File Offset: 0x001B4C24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x001B6A30 File Offset: 0x001B4C30
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
			this.assignment_.WriteTo(ref output, SubscriberStateChangedNotification._repeated_assignment_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x001B6AB4 File Offset: 0x001B4CB4
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
			num += this.assignment_.CalculateSize(SubscriberStateChangedNotification._repeated_assignment_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x001B6B38 File Offset: 0x001B4D38
		[DebuggerNonUserCode]
		public void MergeFrom(SubscriberStateChangedNotification other)
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

		// Token: 0x060070BC RID: 28860 RVA: 0x001B6BCF File Offset: 0x001B4DCF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x001B6BDC File Offset: 0x001B4DDC
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
							this.assignment_.AddEntriesFrom(ref input, SubscriberStateChangedNotification._repeated_assignment_codec);
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

		// Token: 0x040033A7 RID: 13223
		private static readonly MessageParser<SubscriberStateChangedNotification> _parser = new MessageParser<SubscriberStateChangedNotification>(() => new SubscriberStateChangedNotification());

		// Token: 0x040033A8 RID: 13224
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033A9 RID: 13225
		private int _hasBits0;

		// Token: 0x040033AA RID: 13226
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033AB RID: 13227
		private MemberId agentId_;

		// Token: 0x040033AC RID: 13228
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033AD RID: 13229
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033AE RID: 13230
		private ulong clubId_;

		// Token: 0x040033AF RID: 13231
		public const int AssignmentFieldNumber = 4;

		// Token: 0x040033B0 RID: 13232
		private static readonly FieldCodec<SubscriberStateAssignment> _repeated_assignment_codec = FieldCodec.ForMessage<SubscriberStateAssignment>(34U, SubscriberStateAssignment.Parser);

		// Token: 0x040033B1 RID: 13233
		private readonly RepeatedField<SubscriberStateAssignment> assignment_ = new RepeatedField<SubscriberStateAssignment>();
	}
}
