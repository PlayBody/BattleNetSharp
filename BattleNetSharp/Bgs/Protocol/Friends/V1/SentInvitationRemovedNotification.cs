using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000415 RID: 1045
	public sealed class SentInvitationRemovedNotification : IMessage<SentInvitationRemovedNotification>, IMessage, IEquatable<SentInvitationRemovedNotification>, IDeepCloneable<SentInvitationRemovedNotification>, IBufferMessage
	{
		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600671F RID: 26399 RVA: 0x0018E8E4 File Offset: 0x0018CAE4
		[DebuggerNonUserCode]
		public static MessageParser<SentInvitationRemovedNotification> Parser
		{
			get
			{
				return SentInvitationRemovedNotification._parser;
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06006720 RID: 26400 RVA: 0x0018E8FC File Offset: 0x0018CAFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06006721 RID: 26401 RVA: 0x0018E920 File Offset: 0x0018CB20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SentInvitationRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x0018E937 File Offset: 0x0018CB37
		[DebuggerNonUserCode]
		public SentInvitationRemovedNotification()
		{
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x0018E944 File Offset: 0x0018CB44
		[DebuggerNonUserCode]
		public SentInvitationRemovedNotification(SentInvitationRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.invitationId_ = other.invitationId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x0018E9AC File Offset: 0x0018CBAC
		[DebuggerNonUserCode]
		public SentInvitationRemovedNotification Clone()
		{
			return new SentInvitationRemovedNotification(this);
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06006725 RID: 26405 RVA: 0x0018E9C4 File Offset: 0x0018CBC4
		// (set) Token: 0x06006726 RID: 26406 RVA: 0x0018E9DC File Offset: 0x0018CBDC
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

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06006727 RID: 26407 RVA: 0x0018E9E8 File Offset: 0x0018CBE8
		// (set) Token: 0x06006728 RID: 26408 RVA: 0x0018EA19 File Offset: 0x0018CC19
		[DebuggerNonUserCode]
		public ulong InvitationId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong invitationIdDefaultValue;
				if (flag)
				{
					invitationIdDefaultValue = this.invitationId_;
				}
				else
				{
					invitationIdDefaultValue = SentInvitationRemovedNotification.InvitationIdDefaultValue;
				}
				return invitationIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.invitationId_ = value;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06006729 RID: 26409 RVA: 0x0018EA34 File Offset: 0x0018CC34
		[DebuggerNonUserCode]
		public bool HasInvitationId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x0018EA51 File Offset: 0x0018CC51
		[DebuggerNonUserCode]
		public void ClearInvitationId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x0600672B RID: 26411 RVA: 0x0018EA64 File Offset: 0x0018CC64
		// (set) Token: 0x0600672C RID: 26412 RVA: 0x0018EA95 File Offset: 0x0018CC95
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = SentInvitationRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x0600672D RID: 26413 RVA: 0x0018EAB0 File Offset: 0x0018CCB0
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x0018EACD File Offset: 0x0018CCCD
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600672F RID: 26415 RVA: 0x0018EAE0 File Offset: 0x0018CCE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SentInvitationRemovedNotification);
		}

		// Token: 0x06006730 RID: 26416 RVA: 0x0018EB00 File Offset: 0x0018CD00
		[DebuggerNonUserCode]
		public bool Equals(SentInvitationRemovedNotification other)
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
						bool flag5 = this.InvitationId != other.InvitationId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x0018EB90 File Offset: 0x0018CD90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num ^= this.InvitationId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x0018EC1C File Offset: 0x0018CE1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x0018EC34 File Offset: 0x0018CE34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x0018EC40 File Offset: 0x0018CE40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountId);
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				output.WriteRawTag(17);
				output.WriteFixed64(this.InvitationId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x0018ECD4 File Offset: 0x0018CED4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool hasInvitationId = this.HasInvitationId;
			if (hasInvitationId)
			{
				num += 9;
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x0018ED58 File Offset: 0x0018CF58
		[DebuggerNonUserCode]
		public void MergeFrom(SentInvitationRemovedNotification other)
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
				bool hasInvitationId = other.HasInvitationId;
				if (hasInvitationId)
				{
					this.InvitationId = other.InvitationId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x0018EDFB File Offset: 0x0018CFFB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x0018EE08 File Offset: 0x0018D008
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
					if (num3 != 17U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadUInt32();
						}
					}
					else
					{
						this.InvitationId = input.ReadFixed64();
					}
				}
				else
				{
					bool flag = this.accountId_ == null;
					if (flag)
					{
						this.AccountId = new EntityId();
					}
					input.ReadMessage(this.AccountId);
				}
			}
		}

		// Token: 0x04002EBC RID: 11964
		private static readonly MessageParser<SentInvitationRemovedNotification> _parser = new MessageParser<SentInvitationRemovedNotification>(() => new SentInvitationRemovedNotification());

		// Token: 0x04002EBD RID: 11965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EBE RID: 11966
		private int _hasBits0;

		// Token: 0x04002EBF RID: 11967
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04002EC0 RID: 11968
		private EntityId accountId_;

		// Token: 0x04002EC1 RID: 11969
		public const int InvitationIdFieldNumber = 2;

		// Token: 0x04002EC2 RID: 11970
		private static readonly ulong InvitationIdDefaultValue = 0UL;

		// Token: 0x04002EC3 RID: 11971
		private ulong invitationId_;

		// Token: 0x04002EC4 RID: 11972
		public const int ReasonFieldNumber = 3;

		// Token: 0x04002EC5 RID: 11973
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04002EC6 RID: 11974
		private uint reason_;
	}
}
