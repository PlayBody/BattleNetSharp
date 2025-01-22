using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200067A RID: 1658
	public sealed class MemberRoleChangedNotification : IMessage<MemberRoleChangedNotification>, IMessage, IEquatable<MemberRoleChangedNotification>, IDeepCloneable<MemberRoleChangedNotification>, IBufferMessage
	{
		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x060099E5 RID: 39397 RVA: 0x002547C8 File Offset: 0x002529C8
		[DebuggerNonUserCode]
		public static MessageParser<MemberRoleChangedNotification> Parser
		{
			get
			{
				return MemberRoleChangedNotification._parser;
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x060099E6 RID: 39398 RVA: 0x002547E0 File Offset: 0x002529E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[30];
			}
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x00254804 File Offset: 0x00252A04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRoleChangedNotification.Descriptor;
			}
		}

		// Token: 0x060099E8 RID: 39400 RVA: 0x0025481B File Offset: 0x00252A1B
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification()
		{
		}

		// Token: 0x060099E9 RID: 39401 RVA: 0x00254830 File Offset: 0x00252A30
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification(MemberRoleChangedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = other.assignment_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x002548BC File Offset: 0x00252ABC
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification Clone()
		{
			return new MemberRoleChangedNotification(this);
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x060099EB RID: 39403 RVA: 0x002548D4 File Offset: 0x00252AD4
		// (set) Token: 0x060099EC RID: 39404 RVA: 0x002548EC File Offset: 0x00252AEC
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

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x060099ED RID: 39405 RVA: 0x002548F8 File Offset: 0x00252AF8
		// (set) Token: 0x060099EE RID: 39406 RVA: 0x00254910 File Offset: 0x00252B10
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

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x060099EF RID: 39407 RVA: 0x0025491C File Offset: 0x00252B1C
		// (set) Token: 0x060099F0 RID: 39408 RVA: 0x00254934 File Offset: 0x00252B34
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

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x060099F1 RID: 39409 RVA: 0x00254940 File Offset: 0x00252B40
		[DebuggerNonUserCode]
		public RepeatedField<RoleAssignment> Assignment
		{
			get
			{
				return this.assignment_;
			}
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x00254958 File Offset: 0x00252B58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRoleChangedNotification);
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x00254978 File Offset: 0x00252B78
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
								bool flag7 = !this.assignment_.Equals(other.assignment_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060099F4 RID: 39412 RVA: 0x00254A34 File Offset: 0x00252C34
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
			num ^= this.assignment_.GetHashCode();
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099F5 RID: 39413 RVA: 0x00254ACC File Offset: 0x00252CCC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x00254AE4 File Offset: 0x00252CE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x00254AF0 File Offset: 0x00252CF0
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
			this.assignment_.WriteTo(ref output, MemberRoleChangedNotification._repeated_assignment_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x00254B9C File Offset: 0x00252D9C
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
			num += this.assignment_.CalculateSize(MemberRoleChangedNotification._repeated_assignment_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x00254C44 File Offset: 0x00252E44
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
				this.assignment_.Add(other.assignment_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x00254D43 File Offset: 0x00252F43
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099FB RID: 39419 RVA: 0x00254D50 File Offset: 0x00252F50
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
					this.assignment_.AddEntriesFrom(ref input, MemberRoleChangedNotification._repeated_assignment_codec);
				}
				else
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
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

		// Token: 0x0400452F RID: 17711
		private static readonly MessageParser<MemberRoleChangedNotification> _parser = new MessageParser<MemberRoleChangedNotification>(() => new MemberRoleChangedNotification());

		// Token: 0x04004530 RID: 17712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004531 RID: 17713
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004532 RID: 17714
		private GameAccountHandle agentId_;

		// Token: 0x04004533 RID: 17715
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x04004534 RID: 17716
		private GameAccountHandle subscriberId_;

		// Token: 0x04004535 RID: 17717
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004536 RID: 17718
		private ChannelId channelId_;

		// Token: 0x04004537 RID: 17719
		public const int AssignmentFieldNumber = 4;

		// Token: 0x04004538 RID: 17720
		private static readonly FieldCodec<RoleAssignment> _repeated_assignment_codec = FieldCodec.ForMessage<RoleAssignment>(34U, RoleAssignment.Parser);

		// Token: 0x04004539 RID: 17721
		private readonly RepeatedField<RoleAssignment> assignment_ = new RepeatedField<RoleAssignment>();
	}
}
