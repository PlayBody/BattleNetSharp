using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000414 RID: 1044
	public sealed class SentInvitationAddedNotification : IMessage<SentInvitationAddedNotification>, IMessage, IEquatable<SentInvitationAddedNotification>, IDeepCloneable<SentInvitationAddedNotification>, IBufferMessage
	{
		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x0600670A RID: 26378 RVA: 0x0018E438 File Offset: 0x0018C638
		[DebuggerNonUserCode]
		public static MessageParser<SentInvitationAddedNotification> Parser
		{
			get
			{
				return SentInvitationAddedNotification._parser;
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600670B RID: 26379 RVA: 0x0018E450 File Offset: 0x0018C650
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600670C RID: 26380 RVA: 0x0018E474 File Offset: 0x0018C674
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SentInvitationAddedNotification.Descriptor;
			}
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x0018E48B File Offset: 0x0018C68B
		[DebuggerNonUserCode]
		public SentInvitationAddedNotification()
		{
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x0018E498 File Offset: 0x0018C698
		[DebuggerNonUserCode]
		public SentInvitationAddedNotification(SentInvitationAddedNotification other)
			: this()
		{
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x0018E4F8 File Offset: 0x0018C6F8
		[DebuggerNonUserCode]
		public SentInvitationAddedNotification Clone()
		{
			return new SentInvitationAddedNotification(this);
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06006710 RID: 26384 RVA: 0x0018E510 File Offset: 0x0018C710
		// (set) Token: 0x06006711 RID: 26385 RVA: 0x0018E528 File Offset: 0x0018C728
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06006712 RID: 26386 RVA: 0x0018E534 File Offset: 0x0018C734
		// (set) Token: 0x06006713 RID: 26387 RVA: 0x0018E54C File Offset: 0x0018C74C
		[DebuggerNonUserCode]
		public SentInvitation Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x0018E558 File Offset: 0x0018C758
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SentInvitationAddedNotification);
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x0018E578 File Offset: 0x0018C778
		[DebuggerNonUserCode]
		public bool Equals(SentInvitationAddedNotification other)
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
					bool flag4 = !object.Equals(this.AccountId, other.AccountId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Invitation, other.Invitation);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x0018E5F0 File Offset: 0x0018C7F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag2 = this.invitation_ != null;
			if (flag2)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x0018E65C File Offset: 0x0018C85C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x0018E674 File Offset: 0x0018C874
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x0018E680 File Offset: 0x0018C880
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountId);
			}
			bool flag2 = this.invitation_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Invitation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x0018E6F4 File Offset: 0x0018C8F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag2 = this.invitation_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x0018E768 File Offset: 0x0018C968
		[DebuggerNonUserCode]
		public void MergeFrom(SentInvitationAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountId_ != null;
				if (flag2)
				{
					bool flag3 = this.accountId_ == null;
					if (flag3)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				bool flag4 = other.invitation_ != null;
				if (flag4)
				{
					bool flag5 = this.invitation_ == null;
					if (flag5)
					{
						this.Invitation = new SentInvitation();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x0018E815 File Offset: 0x0018CA15
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x0018E820 File Offset: 0x0018CA20
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.invitation_ == null;
						if (flag)
						{
							this.Invitation = new SentInvitation();
						}
						input.ReadMessage(this.Invitation);
					}
				}
				else
				{
					bool flag2 = this.accountId_ == null;
					if (flag2)
					{
						this.AccountId = new EntityId();
					}
					input.ReadMessage(this.AccountId);
				}
			}
		}

		// Token: 0x04002EB6 RID: 11958
		private static readonly MessageParser<SentInvitationAddedNotification> _parser = new MessageParser<SentInvitationAddedNotification>(() => new SentInvitationAddedNotification());

		// Token: 0x04002EB7 RID: 11959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EB8 RID: 11960
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04002EB9 RID: 11961
		private EntityId accountId_;

		// Token: 0x04002EBA RID: 11962
		public const int InvitationFieldNumber = 2;

		// Token: 0x04002EBB RID: 11963
		private SentInvitation invitation_;
	}
}
