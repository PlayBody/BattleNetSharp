using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000679 RID: 1657
	public sealed class MemberAttributeChangedNotification : IMessage<MemberAttributeChangedNotification>, IMessage, IEquatable<MemberAttributeChangedNotification>, IDeepCloneable<MemberAttributeChangedNotification>, IBufferMessage
	{
		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x060099CC RID: 39372 RVA: 0x0025409C File Offset: 0x0025229C
		[DebuggerNonUserCode]
		public static MessageParser<MemberAttributeChangedNotification> Parser
		{
			get
			{
				return MemberAttributeChangedNotification._parser;
			}
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x060099CD RID: 39373 RVA: 0x002540B4 File Offset: 0x002522B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[29];
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x060099CE RID: 39374 RVA: 0x002540D8 File Offset: 0x002522D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAttributeChangedNotification.Descriptor;
			}
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x002540EF File Offset: 0x002522EF
		[DebuggerNonUserCode]
		public MemberAttributeChangedNotification()
		{
		}

		// Token: 0x060099D0 RID: 39376 RVA: 0x002540FC File Offset: 0x002522FC
		[DebuggerNonUserCode]
		public MemberAttributeChangedNotification(MemberAttributeChangedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = ((other.assignment_ != null) ? other.assignment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x00254194 File Offset: 0x00252394
		[DebuggerNonUserCode]
		public MemberAttributeChangedNotification Clone()
		{
			return new MemberAttributeChangedNotification(this);
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x060099D2 RID: 39378 RVA: 0x002541AC File Offset: 0x002523AC
		// (set) Token: 0x060099D3 RID: 39379 RVA: 0x002541C4 File Offset: 0x002523C4
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
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

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x060099D4 RID: 39380 RVA: 0x002541D0 File Offset: 0x002523D0
		// (set) Token: 0x060099D5 RID: 39381 RVA: 0x002541E8 File Offset: 0x002523E8
		[DebuggerNonUserCode]
		public GameAccountHandle SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x002541F4 File Offset: 0x002523F4
		// (set) Token: 0x060099D7 RID: 39383 RVA: 0x0025420C File Offset: 0x0025240C
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x00254218 File Offset: 0x00252418
		// (set) Token: 0x060099D9 RID: 39385 RVA: 0x00254230 File Offset: 0x00252430
		[DebuggerNonUserCode]
		public AttributeAssignment Assignment
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

		// Token: 0x060099DA RID: 39386 RVA: 0x0025423C File Offset: 0x0025243C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAttributeChangedNotification);
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x0025425C File Offset: 0x0025245C
		[DebuggerNonUserCode]
		public bool Equals(MemberAttributeChangedNotification other)
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
						bool flag5 = !object.Equals(this.SubscriberId, other.SubscriberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ChannelId, other.ChannelId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Assignment, other.Assignment);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x00254318 File Offset: 0x00252518
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag4 = this.assignment_ != null;
			if (flag4)
			{
				num ^= this.Assignment.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x002543BC File Offset: 0x002525BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x002543D4 File Offset: 0x002525D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x002543E0 File Offset: 0x002525E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.assignment_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Assignment);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x002544A0 File Offset: 0x002526A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag4 = this.assignment_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Assignment);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x00254554 File Offset: 0x00252754
		[DebuggerNonUserCode]
		public void MergeFrom(MemberAttributeChangedNotification other)
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
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.subscriberId_ != null;
				if (flag4)
				{
					bool flag5 = this.subscriberId_ == null;
					if (flag5)
					{
						this.SubscriberId = new GameAccountHandle();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				bool flag6 = other.channelId_ != null;
				if (flag6)
				{
					bool flag7 = this.channelId_ == null;
					if (flag7)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag8 = other.assignment_ != null;
				if (flag8)
				{
					bool flag9 = this.assignment_ == null;
					if (flag9)
					{
						this.Assignment = new AttributeAssignment();
					}
					this.Assignment.MergeFrom(other.Assignment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x00254681 File Offset: 0x00252881
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099E3 RID: 39395 RVA: 0x0025468C File Offset: 0x0025288C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002F;
						}
						bool flag = this.subscriberId_ == null;
						if (flag)
						{
							this.SubscriberId = new GameAccountHandle();
						}
						input.ReadMessage(this.SubscriberId);
					}
					else
					{
						bool flag2 = this.agentId_ == null;
						if (flag2)
						{
							this.AgentId = new GameAccountHandle();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag3 = this.assignment_ == null;
					if (flag3)
					{
						this.Assignment = new AttributeAssignment();
					}
					input.ReadMessage(this.Assignment);
				}
				else
				{
					bool flag4 = this.channelId_ == null;
					if (flag4)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004525 RID: 17701
		private static readonly MessageParser<MemberAttributeChangedNotification> _parser = new MessageParser<MemberAttributeChangedNotification>(() => new MemberAttributeChangedNotification());

		// Token: 0x04004526 RID: 17702
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004527 RID: 17703
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004528 RID: 17704
		private GameAccountHandle agentId_;

		// Token: 0x04004529 RID: 17705
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x0400452A RID: 17706
		private GameAccountHandle subscriberId_;

		// Token: 0x0400452B RID: 17707
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x0400452C RID: 17708
		private ChannelId channelId_;

		// Token: 0x0400452D RID: 17709
		public const int AssignmentFieldNumber = 4;

		// Token: 0x0400452E RID: 17710
		private AttributeAssignment assignment_;
	}
}
