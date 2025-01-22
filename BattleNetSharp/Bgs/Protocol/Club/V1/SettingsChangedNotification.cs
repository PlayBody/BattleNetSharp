using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000480 RID: 1152
	public sealed class SettingsChangedNotification : IMessage<SettingsChangedNotification>, IMessage, IEquatable<SettingsChangedNotification>, IDeepCloneable<SettingsChangedNotification>, IBufferMessage
	{
		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x001B50CC File Offset: 0x001B32CC
		[DebuggerNonUserCode]
		public static MessageParser<SettingsChangedNotification> Parser
		{
			get
			{
				return SettingsChangedNotification._parser;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x06007047 RID: 28743 RVA: 0x001B50E4 File Offset: 0x001B32E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x06007048 RID: 28744 RVA: 0x001B5108 File Offset: 0x001B3308
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettingsChangedNotification.Descriptor;
			}
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x001B511F File Offset: 0x001B331F
		[DebuggerNonUserCode]
		public SettingsChangedNotification()
		{
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x001B512C File Offset: 0x001B332C
		[DebuggerNonUserCode]
		public SettingsChangedNotification(SettingsChangedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x001B51A4 File Offset: 0x001B33A4
		[DebuggerNonUserCode]
		public SettingsChangedNotification Clone()
		{
			return new SettingsChangedNotification(this);
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600704C RID: 28748 RVA: 0x001B51BC File Offset: 0x001B33BC
		// (set) Token: 0x0600704D RID: 28749 RVA: 0x001B51D4 File Offset: 0x001B33D4
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

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600704E RID: 28750 RVA: 0x001B51E0 File Offset: 0x001B33E0
		// (set) Token: 0x0600704F RID: 28751 RVA: 0x001B5211 File Offset: 0x001B3411
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
					clubIdDefaultValue = SettingsChangedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x06007050 RID: 28752 RVA: 0x001B522C File Offset: 0x001B342C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x001B5249 File Offset: 0x001B3449
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x06007052 RID: 28754 RVA: 0x001B525C File Offset: 0x001B345C
		// (set) Token: 0x06007053 RID: 28755 RVA: 0x001B5274 File Offset: 0x001B3474
		[DebuggerNonUserCode]
		public ClubSettingsAssignment Assignment
		{
			get
			{
				return this.assignment_;
			}
			set
			{
				this.assignment_ = value;
			}
		}

		// Token: 0x06007054 RID: 28756 RVA: 0x001B5280 File Offset: 0x001B3480
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettingsChangedNotification);
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x001B52A0 File Offset: 0x001B34A0
		[DebuggerNonUserCode]
		public bool Equals(SettingsChangedNotification other)
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
							bool flag6 = !object.Equals(this.Assignment, other.Assignment);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x001B5334 File Offset: 0x001B3534
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
			bool flag2 = this.assignment_ != null;
			if (flag2)
			{
				num ^= this.Assignment.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x001B53C0 File Offset: 0x001B35C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x001B53D8 File Offset: 0x001B35D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007059 RID: 28761 RVA: 0x001B53E4 File Offset: 0x001B35E4
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
			bool flag2 = this.assignment_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Assignment);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x001B547C File Offset: 0x001B367C
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
			bool flag2 = this.assignment_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Assignment);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x001B550C File Offset: 0x001B370C
		[DebuggerNonUserCode]
		public void MergeFrom(SettingsChangedNotification other)
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
				bool flag4 = other.assignment_ != null;
				if (flag4)
				{
					bool flag5 = this.assignment_ == null;
					if (flag5)
					{
						this.Assignment = new ClubSettingsAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x001B55D4 File Offset: 0x001B37D4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x001B55E0 File Offset: 0x001B37E0
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
							bool flag = this.assignment_ == null;
							if (flag)
							{
								this.Assignment = new ClubSettingsAssignment();
							}
							input.ReadMessage(this.Assignment);
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

		// Token: 0x0400337C RID: 13180
		private static readonly MessageParser<SettingsChangedNotification> _parser = new MessageParser<SettingsChangedNotification>(() => new SettingsChangedNotification());

		// Token: 0x0400337D RID: 13181
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400337E RID: 13182
		private int _hasBits0;

		// Token: 0x0400337F RID: 13183
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003380 RID: 13184
		private MemberId agentId_;

		// Token: 0x04003381 RID: 13185
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003382 RID: 13186
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003383 RID: 13187
		private ulong clubId_;

		// Token: 0x04003384 RID: 13188
		public const int AssignmentFieldNumber = 4;

		// Token: 0x04003385 RID: 13189
		private ClubSettingsAssignment assignment_;
	}
}
