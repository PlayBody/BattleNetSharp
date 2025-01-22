using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200050F RID: 1295
	public sealed class ClubAddedNotification : IMessage<ClubAddedNotification>, IMessage, IEquatable<ClubAddedNotification>, IDeepCloneable<ClubAddedNotification>, IBufferMessage
	{
		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x06007E37 RID: 32311 RVA: 0x001EB9C4 File Offset: 0x001E9BC4
		[DebuggerNonUserCode]
		public static MessageParser<ClubAddedNotification> Parser
		{
			get
			{
				return ClubAddedNotification._parser;
			}
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x06007E38 RID: 32312 RVA: 0x001EB9DC File Offset: 0x001E9BDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x06007E39 RID: 32313 RVA: 0x001EBA00 File Offset: 0x001E9C00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubAddedNotification.Descriptor;
			}
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x001EBA17 File Offset: 0x001E9C17
		[DebuggerNonUserCode]
		public ClubAddedNotification()
		{
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x001EBA24 File Offset: 0x001E9C24
		[DebuggerNonUserCode]
		public ClubAddedNotification(ClubAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.membership_ = ((other.membership_ != null) ? other.membership_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x001EBA84 File Offset: 0x001E9C84
		[DebuggerNonUserCode]
		public ClubAddedNotification Clone()
		{
			return new ClubAddedNotification(this);
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x06007E3D RID: 32317 RVA: 0x001EBA9C File Offset: 0x001E9C9C
		// (set) Token: 0x06007E3E RID: 32318 RVA: 0x001EBAB4 File Offset: 0x001E9CB4
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

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x06007E3F RID: 32319 RVA: 0x001EBAC0 File Offset: 0x001E9CC0
		// (set) Token: 0x06007E40 RID: 32320 RVA: 0x001EBAD8 File Offset: 0x001E9CD8
		[DebuggerNonUserCode]
		public ClubMembershipDescription Membership
		{
			get
			{
				return this.membership_;
			}
			set
			{
				this.membership_ = value;
			}
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x001EBAE4 File Offset: 0x001E9CE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubAddedNotification);
		}

		// Token: 0x06007E42 RID: 32322 RVA: 0x001EBB04 File Offset: 0x001E9D04
		[DebuggerNonUserCode]
		public bool Equals(ClubAddedNotification other)
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
						bool flag5 = !object.Equals(this.Membership, other.Membership);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007E43 RID: 32323 RVA: 0x001EBB7C File Offset: 0x001E9D7C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.membership_ != null;
			if (flag2)
			{
				num ^= this.Membership.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x001EBBE8 File Offset: 0x001E9DE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x001EBC00 File Offset: 0x001E9E00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E46 RID: 32326 RVA: 0x001EBC0C File Offset: 0x001E9E0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.membership_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Membership);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x001EBC80 File Offset: 0x001E9E80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.membership_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Membership);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x001EBCF4 File Offset: 0x001E9EF4
		[DebuggerNonUserCode]
		public void MergeFrom(ClubAddedNotification other)
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
				bool flag4 = other.membership_ != null;
				if (flag4)
				{
					bool flag5 = this.membership_ == null;
					if (flag5)
					{
						this.Membership = new ClubMembershipDescription();
					}
					this.Membership.MergeFrom(other.Membership);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x001EBDA1 File Offset: 0x001E9FA1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x001EBDAC File Offset: 0x001E9FAC
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
						bool flag = this.membership_ == null;
						if (flag)
						{
							this.Membership = new ClubMembershipDescription();
						}
						input.ReadMessage(this.Membership);
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

		// Token: 0x0400396B RID: 14699
		private static readonly MessageParser<ClubAddedNotification> _parser = new MessageParser<ClubAddedNotification>(() => new ClubAddedNotification());

		// Token: 0x0400396C RID: 14700
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400396D RID: 14701
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400396E RID: 14702
		private MemberId agentId_;

		// Token: 0x0400396F RID: 14703
		public const int MembershipFieldNumber = 3;

		// Token: 0x04003970 RID: 14704
		private ClubMembershipDescription membership_;
	}
}
