using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Server
{
	// Token: 0x020006A7 RID: 1703
	public sealed class MemberRoleChangedNotification : IMessage<MemberRoleChangedNotification>, IMessage, IEquatable<MemberRoleChangedNotification>, IDeepCloneable<MemberRoleChangedNotification>, IBufferMessage
	{
		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x06009DF3 RID: 40435 RVA: 0x0026668C File Offset: 0x0026488C
		[DebuggerNonUserCode]
		public static MessageParser<MemberRoleChangedNotification> Parser
		{
			get
			{
				return MemberRoleChangedNotification._parser;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x06009DF4 RID: 40436 RVA: 0x002666A4 File Offset: 0x002648A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelListenerReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x06009DF5 RID: 40437 RVA: 0x002666C8 File Offset: 0x002648C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRoleChangedNotification.Descriptor;
			}
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x002666DF File Offset: 0x002648DF
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification()
		{
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x002666F4 File Offset: 0x002648F4
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification(MemberRoleChangedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = other.assignment_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x00266764 File Offset: 0x00264964
		[DebuggerNonUserCode]
		public MemberRoleChangedNotification Clone()
		{
			return new MemberRoleChangedNotification(this);
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x0026677C File Offset: 0x0026497C
		// (set) Token: 0x06009DFA RID: 40442 RVA: 0x00266794 File Offset: 0x00264994
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

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x06009DFB RID: 40443 RVA: 0x002667A0 File Offset: 0x002649A0
		// (set) Token: 0x06009DFC RID: 40444 RVA: 0x002667B8 File Offset: 0x002649B8
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

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x06009DFD RID: 40445 RVA: 0x002667C4 File Offset: 0x002649C4
		[DebuggerNonUserCode]
		public RepeatedField<RoleAssignment> Assignment
		{
			get
			{
				return this.assignment_;
			}
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x002667DC File Offset: 0x002649DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRoleChangedNotification);
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x002667FC File Offset: 0x002649FC
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
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

		// Token: 0x06009E00 RID: 40448 RVA: 0x00266894 File Offset: 0x00264A94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			num ^= this.assignment_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x0026690C File Offset: 0x00264B0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x00266924 File Offset: 0x00264B24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x00266930 File Offset: 0x00264B30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			this.assignment_.WriteTo(ref output, MemberRoleChangedNotification._repeated_assignment_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x002669B8 File Offset: 0x00264BB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			num += this.assignment_.CalculateSize(MemberRoleChangedNotification._repeated_assignment_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x00266A40 File Offset: 0x00264C40
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
				this.assignment_.Add(other.assignment_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x00266AFF File Offset: 0x00264CFF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x00266B0C File Offset: 0x00264D0C
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
					if (num3 != 26U)
					{
						if (num3 != 42U)
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
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
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
		}

		// Token: 0x04004746 RID: 18246
		private static readonly MessageParser<MemberRoleChangedNotification> _parser = new MessageParser<MemberRoleChangedNotification>(() => new MemberRoleChangedNotification());

		// Token: 0x04004747 RID: 18247
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004748 RID: 18248
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004749 RID: 18249
		private GameAccountHandle agentId_;

		// Token: 0x0400474A RID: 18250
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x0400474B RID: 18251
		private ChannelId channelId_;

		// Token: 0x0400474C RID: 18252
		public const int AssignmentFieldNumber = 5;

		// Token: 0x0400474D RID: 18253
		private static readonly FieldCodec<RoleAssignment> _repeated_assignment_codec = FieldCodec.ForMessage<RoleAssignment>(42U, RoleAssignment.Parser);

		// Token: 0x0400474E RID: 18254
		private readonly RepeatedField<RoleAssignment> assignment_ = new RepeatedField<RoleAssignment>();
	}
}
