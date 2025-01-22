using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000514 RID: 1300
	public sealed class StreamMentionAddedNotification : IMessage<StreamMentionAddedNotification>, IMessage, IEquatable<StreamMentionAddedNotification>, IDeepCloneable<StreamMentionAddedNotification>, IBufferMessage
	{
		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x06007EAE RID: 32430 RVA: 0x001ED4F8 File Offset: 0x001EB6F8
		[DebuggerNonUserCode]
		public static MessageParser<StreamMentionAddedNotification> Parser
		{
			get
			{
				return StreamMentionAddedNotification._parser;
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x06007EAF RID: 32431 RVA: 0x001ED510 File Offset: 0x001EB710
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x06007EB0 RID: 32432 RVA: 0x001ED534 File Offset: 0x001EB734
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMentionAddedNotification.Descriptor;
			}
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x001ED54B File Offset: 0x001EB74B
		[DebuggerNonUserCode]
		public StreamMentionAddedNotification()
		{
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x001ED558 File Offset: 0x001EB758
		[DebuggerNonUserCode]
		public StreamMentionAddedNotification(StreamMentionAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.mention_ = ((other.mention_ != null) ? other.mention_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x001ED5B8 File Offset: 0x001EB7B8
		[DebuggerNonUserCode]
		public StreamMentionAddedNotification Clone()
		{
			return new StreamMentionAddedNotification(this);
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x06007EB4 RID: 32436 RVA: 0x001ED5D0 File Offset: 0x001EB7D0
		// (set) Token: 0x06007EB5 RID: 32437 RVA: 0x001ED5E8 File Offset: 0x001EB7E8
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

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x001ED5F4 File Offset: 0x001EB7F4
		// (set) Token: 0x06007EB7 RID: 32439 RVA: 0x001ED60C File Offset: 0x001EB80C
		[DebuggerNonUserCode]
		public StreamMention Mention
		{
			get
			{
				return this.mention_;
			}
			set
			{
				this.mention_ = value;
			}
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x001ED618 File Offset: 0x001EB818
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMentionAddedNotification);
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x001ED638 File Offset: 0x001EB838
		[DebuggerNonUserCode]
		public bool Equals(StreamMentionAddedNotification other)
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
						bool flag5 = !object.Equals(this.Mention, other.Mention);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x001ED6B0 File Offset: 0x001EB8B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.mention_ != null;
			if (flag2)
			{
				num ^= this.Mention.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x001ED71C File Offset: 0x001EB91C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x001ED734 File Offset: 0x001EB934
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EBD RID: 32445 RVA: 0x001ED740 File Offset: 0x001EB940
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.mention_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Mention);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x001ED7B4 File Offset: 0x001EB9B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.mention_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Mention);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x001ED828 File Offset: 0x001EBA28
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMentionAddedNotification other)
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
				bool flag4 = other.mention_ != null;
				if (flag4)
				{
					bool flag5 = this.mention_ == null;
					if (flag5)
					{
						this.Mention = new StreamMention();
					}
					this.Mention.MergeFrom(other.Mention);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007EC0 RID: 32448 RVA: 0x001ED8D5 File Offset: 0x001EBAD5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EC1 RID: 32449 RVA: 0x001ED8E0 File Offset: 0x001EBAE0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.mention_ == null;
						if (flag)
						{
							this.Mention = new StreamMention();
						}
						input.ReadMessage(this.Mention);
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

		// Token: 0x04003995 RID: 14741
		private static readonly MessageParser<StreamMentionAddedNotification> _parser = new MessageParser<StreamMentionAddedNotification>(() => new StreamMentionAddedNotification());

		// Token: 0x04003996 RID: 14742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003997 RID: 14743
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003998 RID: 14744
		private MemberId agentId_;

		// Token: 0x04003999 RID: 14745
		public const int MentionFieldNumber = 3;

		// Token: 0x0400399A RID: 14746
		private StreamMention mention_;
	}
}
