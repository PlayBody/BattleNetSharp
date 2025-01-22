using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200047F RID: 1151
	public sealed class StateChangedNotification : IMessage<StateChangedNotification>, IMessage, IEquatable<StateChangedNotification>, IDeepCloneable<StateChangedNotification>, IBufferMessage
	{
		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0600702D RID: 28717 RVA: 0x001B4AD4 File Offset: 0x001B2CD4
		[DebuggerNonUserCode]
		public static MessageParser<StateChangedNotification> Parser
		{
			get
			{
				return StateChangedNotification._parser;
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x0600702E RID: 28718 RVA: 0x001B4AEC File Offset: 0x001B2CEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x0600702F RID: 28719 RVA: 0x001B4B10 File Offset: 0x001B2D10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateChangedNotification.Descriptor;
			}
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x001B4B27 File Offset: 0x001B2D27
		[DebuggerNonUserCode]
		public StateChangedNotification()
		{
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x001B4B34 File Offset: 0x001B2D34
		[DebuggerNonUserCode]
		public StateChangedNotification(StateChangedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x001B4BAC File Offset: 0x001B2DAC
		[DebuggerNonUserCode]
		public StateChangedNotification Clone()
		{
			return new StateChangedNotification(this);
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x001B4BC4 File Offset: 0x001B2DC4
		// (set) Token: 0x06007034 RID: 28724 RVA: 0x001B4BDC File Offset: 0x001B2DDC
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

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x06007035 RID: 28725 RVA: 0x001B4BE8 File Offset: 0x001B2DE8
		// (set) Token: 0x06007036 RID: 28726 RVA: 0x001B4C19 File Offset: 0x001B2E19
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
					clubIdDefaultValue = StateChangedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x06007037 RID: 28727 RVA: 0x001B4C34 File Offset: 0x001B2E34
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x001B4C51 File Offset: 0x001B2E51
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x06007039 RID: 28729 RVA: 0x001B4C64 File Offset: 0x001B2E64
		// (set) Token: 0x0600703A RID: 28730 RVA: 0x001B4C7C File Offset: 0x001B2E7C
		[DebuggerNonUserCode]
		public ClubStateAssignment Assignment
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

		// Token: 0x0600703B RID: 28731 RVA: 0x001B4C88 File Offset: 0x001B2E88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateChangedNotification);
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x001B4CA8 File Offset: 0x001B2EA8
		[DebuggerNonUserCode]
		public bool Equals(StateChangedNotification other)
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

		// Token: 0x0600703D RID: 28733 RVA: 0x001B4D3C File Offset: 0x001B2F3C
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

		// Token: 0x0600703E RID: 28734 RVA: 0x001B4DC8 File Offset: 0x001B2FC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x001B4DE0 File Offset: 0x001B2FE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x001B4DEC File Offset: 0x001B2FEC
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
				output.WriteRawTag(42);
				output.WriteMessage(this.Assignment);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x001B4E84 File Offset: 0x001B3084
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

		// Token: 0x06007042 RID: 28738 RVA: 0x001B4F14 File Offset: 0x001B3114
		[DebuggerNonUserCode]
		public void MergeFrom(StateChangedNotification other)
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
						this.Assignment = new ClubStateAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x001B4FDC File Offset: 0x001B31DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x001B4FE8 File Offset: 0x001B31E8
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
						if (num3 != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.assignment_ == null;
							if (flag)
							{
								this.Assignment = new ClubStateAssignment();
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

		// Token: 0x04003372 RID: 13170
		private static readonly MessageParser<StateChangedNotification> _parser = new MessageParser<StateChangedNotification>(() => new StateChangedNotification());

		// Token: 0x04003373 RID: 13171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003374 RID: 13172
		private int _hasBits0;

		// Token: 0x04003375 RID: 13173
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003376 RID: 13174
		private MemberId agentId_;

		// Token: 0x04003377 RID: 13175
		public const int ClubIdFieldNumber = 3;

		// Token: 0x04003378 RID: 13176
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003379 RID: 13177
		private ulong clubId_;

		// Token: 0x0400337A RID: 13178
		public const int AssignmentFieldNumber = 5;

		// Token: 0x0400337B RID: 13179
		private ClubStateAssignment assignment_;
	}
}
