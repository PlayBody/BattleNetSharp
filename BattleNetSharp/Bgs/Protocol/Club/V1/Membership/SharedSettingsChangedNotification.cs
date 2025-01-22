using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000513 RID: 1299
	public sealed class SharedSettingsChangedNotification : IMessage<SharedSettingsChangedNotification>, IMessage, IEquatable<SharedSettingsChangedNotification>, IDeepCloneable<SharedSettingsChangedNotification>, IBufferMessage
	{
		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x06007E99 RID: 32409 RVA: 0x001ED04C File Offset: 0x001EB24C
		[DebuggerNonUserCode]
		public static MessageParser<SharedSettingsChangedNotification> Parser
		{
			get
			{
				return SharedSettingsChangedNotification._parser;
			}
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x06007E9A RID: 32410 RVA: 0x001ED064 File Offset: 0x001EB264
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x06007E9B RID: 32411 RVA: 0x001ED088 File Offset: 0x001EB288
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SharedSettingsChangedNotification.Descriptor;
			}
		}

		// Token: 0x06007E9C RID: 32412 RVA: 0x001ED09F File Offset: 0x001EB29F
		[DebuggerNonUserCode]
		public SharedSettingsChangedNotification()
		{
		}

		// Token: 0x06007E9D RID: 32413 RVA: 0x001ED0AC File Offset: 0x001EB2AC
		[DebuggerNonUserCode]
		public SharedSettingsChangedNotification(SharedSettingsChangedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x001ED10C File Offset: 0x001EB30C
		[DebuggerNonUserCode]
		public SharedSettingsChangedNotification Clone()
		{
			return new SharedSettingsChangedNotification(this);
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x06007E9F RID: 32415 RVA: 0x001ED124 File Offset: 0x001EB324
		// (set) Token: 0x06007EA0 RID: 32416 RVA: 0x001ED13C File Offset: 0x001EB33C
		[DebuggerNonUserCode]
		public AccountId AgentId
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

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x06007EA1 RID: 32417 RVA: 0x001ED148 File Offset: 0x001EB348
		// (set) Token: 0x06007EA2 RID: 32418 RVA: 0x001ED160 File Offset: 0x001EB360
		[DebuggerNonUserCode]
		public ClubSharedSettingsAssignment Assignment
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

		// Token: 0x06007EA3 RID: 32419 RVA: 0x001ED16C File Offset: 0x001EB36C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SharedSettingsChangedNotification);
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x001ED18C File Offset: 0x001EB38C
		[DebuggerNonUserCode]
		public bool Equals(SharedSettingsChangedNotification other)
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
						bool flag5 = !object.Equals(this.Assignment, other.Assignment);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x001ED204 File Offset: 0x001EB404
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
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

		// Token: 0x06007EA6 RID: 32422 RVA: 0x001ED270 File Offset: 0x001EB470
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x001ED288 File Offset: 0x001EB488
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x001ED294 File Offset: 0x001EB494
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
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

		// Token: 0x06007EA9 RID: 32425 RVA: 0x001ED308 File Offset: 0x001EB508
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
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

		// Token: 0x06007EAA RID: 32426 RVA: 0x001ED37C File Offset: 0x001EB57C
		[DebuggerNonUserCode]
		public void MergeFrom(SharedSettingsChangedNotification other)
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.assignment_ != null;
				if (flag4)
				{
					bool flag5 = this.assignment_ == null;
					if (flag5)
					{
						this.Assignment = new ClubSharedSettingsAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x001ED429 File Offset: 0x001EB629
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x001ED434 File Offset: 0x001EB634
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
					if (num3 != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.assignment_ == null;
						if (flag)
						{
							this.Assignment = new ClubSharedSettingsAssignment();
						}
						input.ReadMessage(this.Assignment);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x0400398F RID: 14735
		private static readonly MessageParser<SharedSettingsChangedNotification> _parser = new MessageParser<SharedSettingsChangedNotification>(() => new SharedSettingsChangedNotification());

		// Token: 0x04003990 RID: 14736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003991 RID: 14737
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003992 RID: 14738
		private AccountId agentId_;

		// Token: 0x04003993 RID: 14739
		public const int AssignmentFieldNumber = 4;

		// Token: 0x04003994 RID: 14740
		private ClubSharedSettingsAssignment assignment_;
	}
}
