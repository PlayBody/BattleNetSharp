using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x02000515 RID: 1301
	public sealed class StreamMentionRemovedNotification : IMessage<StreamMentionRemovedNotification>, IMessage, IEquatable<StreamMentionRemovedNotification>, IDeepCloneable<StreamMentionRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x001ED9A4 File Offset: 0x001EBBA4
		[DebuggerNonUserCode]
		public static MessageParser<StreamMentionRemovedNotification> Parser
		{
			get
			{
				return StreamMentionRemovedNotification._parser;
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x06007EC4 RID: 32452 RVA: 0x001ED9BC File Offset: 0x001EBBBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x06007EC5 RID: 32453 RVA: 0x001ED9E0 File Offset: 0x001EBBE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMentionRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x001ED9F7 File Offset: 0x001EBBF7
		[DebuggerNonUserCode]
		public StreamMentionRemovedNotification()
		{
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x001EDA04 File Offset: 0x001EBC04
		[DebuggerNonUserCode]
		public StreamMentionRemovedNotification(StreamMentionRemovedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.mentionId_ = ((other.mentionId_ != null) ? other.mentionId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x001EDA64 File Offset: 0x001EBC64
		[DebuggerNonUserCode]
		public StreamMentionRemovedNotification Clone()
		{
			return new StreamMentionRemovedNotification(this);
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x06007EC9 RID: 32457 RVA: 0x001EDA7C File Offset: 0x001EBC7C
		// (set) Token: 0x06007ECA RID: 32458 RVA: 0x001EDA94 File Offset: 0x001EBC94
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

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x06007ECB RID: 32459 RVA: 0x001EDAA0 File Offset: 0x001EBCA0
		// (set) Token: 0x06007ECC RID: 32460 RVA: 0x001EDAB8 File Offset: 0x001EBCB8
		[DebuggerNonUserCode]
		public TimeSeriesId MentionId
		{
			get
			{
				return this.mentionId_;
			}
			set
			{
				this.mentionId_ = value;
			}
		}

		// Token: 0x06007ECD RID: 32461 RVA: 0x001EDAC4 File Offset: 0x001EBCC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMentionRemovedNotification);
		}

		// Token: 0x06007ECE RID: 32462 RVA: 0x001EDAE4 File Offset: 0x001EBCE4
		[DebuggerNonUserCode]
		public bool Equals(StreamMentionRemovedNotification other)
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
						bool flag5 = !object.Equals(this.MentionId, other.MentionId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007ECF RID: 32463 RVA: 0x001EDB5C File Offset: 0x001EBD5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.mentionId_ != null;
			if (flag2)
			{
				num ^= this.MentionId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x001EDBC8 File Offset: 0x001EBDC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x001EDBE0 File Offset: 0x001EBDE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007ED2 RID: 32466 RVA: 0x001EDBEC File Offset: 0x001EBDEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.mentionId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MentionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x001EDC60 File Offset: 0x001EBE60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.mentionId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MentionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x001EDCD4 File Offset: 0x001EBED4
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMentionRemovedNotification other)
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
				bool flag4 = other.mentionId_ != null;
				if (flag4)
				{
					bool flag5 = this.mentionId_ == null;
					if (flag5)
					{
						this.MentionId = new TimeSeriesId();
					}
					this.MentionId.MergeFrom(other.MentionId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x001EDD81 File Offset: 0x001EBF81
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x001EDD8C File Offset: 0x001EBF8C
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
						bool flag = this.mentionId_ == null;
						if (flag)
						{
							this.MentionId = new TimeSeriesId();
						}
						input.ReadMessage(this.MentionId);
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

		// Token: 0x0400399B RID: 14747
		private static readonly MessageParser<StreamMentionRemovedNotification> _parser = new MessageParser<StreamMentionRemovedNotification>(() => new StreamMentionRemovedNotification());

		// Token: 0x0400399C RID: 14748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400399D RID: 14749
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400399E RID: 14750
		private AccountId agentId_;

		// Token: 0x0400399F RID: 14751
		public const int MentionIdFieldNumber = 3;

		// Token: 0x040039A0 RID: 14752
		private TimeSeriesId mentionId_;
	}
}
