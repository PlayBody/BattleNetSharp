using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E3 RID: 1763
	public sealed class UpdateMemberStateNotification : IMessage<UpdateMemberStateNotification>, IMessage, IEquatable<UpdateMemberStateNotification>, IDeepCloneable<UpdateMemberStateNotification>, IBufferMessage
	{
		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x00279D00 File Offset: 0x00277F00
		[DebuggerNonUserCode]
		public static MessageParser<UpdateMemberStateNotification> Parser
		{
			get
			{
				return UpdateMemberStateNotification._parser;
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600A2A2 RID: 41634 RVA: 0x00279D18 File Offset: 0x00277F18
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x00279D3C File Offset: 0x00277F3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMemberStateNotification.Descriptor;
			}
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x00279D53 File Offset: 0x00277F53
		[DebuggerNonUserCode]
		public UpdateMemberStateNotification()
		{
		}

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x00279D68 File Offset: 0x00277F68
		[DebuggerNonUserCode]
		public UpdateMemberStateNotification(UpdateMemberStateNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.stateChange_ = other.stateChange_.Clone();
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x00279DF4 File Offset: 0x00277FF4
		[DebuggerNonUserCode]
		public UpdateMemberStateNotification Clone()
		{
			return new UpdateMemberStateNotification(this);
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600A2A7 RID: 41639 RVA: 0x00279E0C File Offset: 0x0027800C
		// (set) Token: 0x0600A2A8 RID: 41640 RVA: 0x00279E24 File Offset: 0x00278024
		[DebuggerNonUserCode]
		public EntityId AgentId
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

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600A2A9 RID: 41641 RVA: 0x00279E30 File Offset: 0x00278030
		[DebuggerNonUserCode]
		public RepeatedField<Member> StateChange
		{
			get
			{
				return this.stateChange_;
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600A2AA RID: 41642 RVA: 0x00279E48 File Offset: 0x00278048
		// (set) Token: 0x0600A2AB RID: 41643 RVA: 0x00279E60 File Offset: 0x00278060
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

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600A2AC RID: 41644 RVA: 0x00279E6C File Offset: 0x0027806C
		// (set) Token: 0x0600A2AD RID: 41645 RVA: 0x00279E84 File Offset: 0x00278084
		[DebuggerNonUserCode]
		public Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x00279E90 File Offset: 0x00278090
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMemberStateNotification);
		}

		// Token: 0x0600A2AF RID: 41647 RVA: 0x00279EB0 File Offset: 0x002780B0
		[DebuggerNonUserCode]
		public bool Equals(UpdateMemberStateNotification other)
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
						bool flag5 = !this.stateChange_.Equals(other.stateChange_);
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
								bool flag7 = !object.Equals(this.Subscriber, other.Subscriber);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x00279F6C File Offset: 0x0027816C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			num ^= this.stateChange_.GetHashCode();
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag3 = this.subscriber_ != null;
			if (flag3)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x0027A004 File Offset: 0x00278204
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x0027A01C File Offset: 0x0027821C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x0027A028 File Offset: 0x00278228
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			this.stateChange_.WriteTo(ref output, UpdateMemberStateNotification._repeated_stateChange_codec);
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ChannelId);
			}
			bool flag3 = this.subscriber_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Subscriber);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x0027A0D4 File Offset: 0x002782D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			num += this.stateChange_.CalculateSize(UpdateMemberStateNotification._repeated_stateChange_codec);
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag3 = this.subscriber_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x0027A17C File Offset: 0x0027837C
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateMemberStateNotification other)
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
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this.stateChange_.Add(other.stateChange_);
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag6 = other.subscriber_ != null;
				if (flag6)
				{
					bool flag7 = this.subscriber_ == null;
					if (flag7)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x0027A27B File Offset: 0x0027847B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x0027A288 File Offset: 0x00278488
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
						this.stateChange_.AddEntriesFrom(ref input, UpdateMemberStateNotification._repeated_stateChange_codec);
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new EntityId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						goto IL_002F;
					}
					bool flag2 = this.subscriber_ == null;
					if (flag2)
					{
						this.Subscriber = new Identity();
					}
					input.ReadMessage(this.Subscriber);
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

		// Token: 0x04004942 RID: 18754
		private static readonly MessageParser<UpdateMemberStateNotification> _parser = new MessageParser<UpdateMemberStateNotification>(() => new UpdateMemberStateNotification());

		// Token: 0x04004943 RID: 18755
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004944 RID: 18756
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004945 RID: 18757
		private EntityId agentId_;

		// Token: 0x04004946 RID: 18758
		public const int StateChangeFieldNumber = 2;

		// Token: 0x04004947 RID: 18759
		private static readonly FieldCodec<Member> _repeated_stateChange_codec = FieldCodec.ForMessage<Member>(18U, Member.Parser);

		// Token: 0x04004948 RID: 18760
		private readonly RepeatedField<Member> stateChange_ = new RepeatedField<Member>();

		// Token: 0x04004949 RID: 18761
		public const int ChannelIdFieldNumber = 4;

		// Token: 0x0400494A RID: 18762
		private ChannelId channelId_;

		// Token: 0x0400494B RID: 18763
		public const int SubscriberFieldNumber = 5;

		// Token: 0x0400494C RID: 18764
		private Identity subscriber_;
	}
}
