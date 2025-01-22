using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000413 RID: 1043
	public sealed class InvitationNotification : IMessage<InvitationNotification>, IMessage, IEquatable<InvitationNotification>, IDeepCloneable<InvitationNotification>, IBufferMessage
	{
		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x060066F1 RID: 26353 RVA: 0x0018DE44 File Offset: 0x0018C044
		[DebuggerNonUserCode]
		public static MessageParser<InvitationNotification> Parser
		{
			get
			{
				return InvitationNotification._parser;
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x0018DE5C File Offset: 0x0018C05C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x060066F3 RID: 26355 RVA: 0x0018DE80 File Offset: 0x0018C080
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationNotification.Descriptor;
			}
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x0018DE97 File Offset: 0x0018C097
		[DebuggerNonUserCode]
		public InvitationNotification()
		{
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x0018DEA4 File Offset: 0x0018C0A4
		[DebuggerNonUserCode]
		public InvitationNotification(InvitationNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this.reason_ = other.reason_;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x0018DF1C File Offset: 0x0018C11C
		[DebuggerNonUserCode]
		public InvitationNotification Clone()
		{
			return new InvitationNotification(this);
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x060066F7 RID: 26359 RVA: 0x0018DF34 File Offset: 0x0018C134
		// (set) Token: 0x060066F8 RID: 26360 RVA: 0x0018DF4C File Offset: 0x0018C14C
		[DebuggerNonUserCode]
		public ReceivedInvitation Invitation
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

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x060066F9 RID: 26361 RVA: 0x0018DF58 File Offset: 0x0018C158
		// (set) Token: 0x060066FA RID: 26362 RVA: 0x0018DF89 File Offset: 0x0018C189
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = InvitationNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x060066FB RID: 26363 RVA: 0x0018DFA4 File Offset: 0x0018C1A4
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x0018DFC1 File Offset: 0x0018C1C1
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x060066FD RID: 26365 RVA: 0x0018DFD4 File Offset: 0x0018C1D4
		// (set) Token: 0x060066FE RID: 26366 RVA: 0x0018DFEC File Offset: 0x0018C1EC
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

		// Token: 0x060066FF RID: 26367 RVA: 0x0018DFF8 File Offset: 0x0018C1F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationNotification);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x0018E018 File Offset: 0x0018C218
		[DebuggerNonUserCode]
		public bool Equals(InvitationNotification other)
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
					bool flag4 = !object.Equals(this.Invitation, other.Invitation);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Reason != other.Reason;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.AccountId, other.AccountId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x0018E0AC File Offset: 0x0018C2AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x0018E138 File Offset: 0x0018C338
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x0018E150 File Offset: 0x0018C350
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x0018E15C File Offset: 0x0018C35C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.invitation_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Invitation);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.AccountId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x0018E1F4 File Offset: 0x0018C3F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x0018E284 File Offset: 0x0018C484
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.invitation_ != null;
				if (flag2)
				{
					bool flag3 = this.invitation_ == null;
					if (flag3)
					{
						this.Invitation = new ReceivedInvitation();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				bool flag4 = other.accountId_ != null;
				if (flag4)
				{
					bool flag5 = this.accountId_ == null;
					if (flag5)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x0018E34C File Offset: 0x0018C54C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x0018E358 File Offset: 0x0018C558
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
					if (num3 != 24U)
					{
						if (num3 != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						this.Reason = input.ReadUInt32();
					}
				}
				else
				{
					bool flag2 = this.invitation_ == null;
					if (flag2)
					{
						this.Invitation = new ReceivedInvitation();
					}
					input.ReadMessage(this.Invitation);
				}
			}
		}

		// Token: 0x04002EAC RID: 11948
		private static readonly MessageParser<InvitationNotification> _parser = new MessageParser<InvitationNotification>(() => new InvitationNotification());

		// Token: 0x04002EAD RID: 11949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EAE RID: 11950
		private int _hasBits0;

		// Token: 0x04002EAF RID: 11951
		public const int InvitationFieldNumber = 1;

		// Token: 0x04002EB0 RID: 11952
		private ReceivedInvitation invitation_;

		// Token: 0x04002EB1 RID: 11953
		public const int ReasonFieldNumber = 3;

		// Token: 0x04002EB2 RID: 11954
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04002EB3 RID: 11955
		private uint reason_;

		// Token: 0x04002EB4 RID: 11956
		public const int AccountIdFieldNumber = 5;

		// Token: 0x04002EB5 RID: 11957
		private EntityId accountId_;
	}
}
