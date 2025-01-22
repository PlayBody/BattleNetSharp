using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Party
{
	// Token: 0x0200013D RID: 317
	public sealed class OutstandingPartyInvite : IMessage<OutstandingPartyInvite>, IMessage, IEquatable<OutstandingPartyInvite>, IDeepCloneable<OutstandingPartyInvite>, IBufferMessage
	{
		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0007F318 File Offset: 0x0007D518
		[DebuggerNonUserCode]
		public static MessageParser<OutstandingPartyInvite> Parser
		{
			get
			{
				return OutstandingPartyInvite._parser;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0007F330 File Offset: 0x0007D530
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PartyReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0007F354 File Offset: 0x0007D554
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OutstandingPartyInvite.Descriptor;
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0007F36B File Offset: 0x0007D56B
		[DebuggerNonUserCode]
		public OutstandingPartyInvite()
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0007F378 File Offset: 0x0007D578
		[DebuggerNonUserCode]
		public OutstandingPartyInvite(OutstandingPartyInvite other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviteId_ = other.inviteId_;
			this.partyInvite_ = ((other.partyInvite_ != null) ? other.partyInvite_.Clone() : null);
			this.createdTime_ = other.createdTime_;
			this.inviteePartyId_ = other.inviteePartyId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0007F3EC File Offset: 0x0007D5EC
		[DebuggerNonUserCode]
		public OutstandingPartyInvite Clone()
		{
			return new OutstandingPartyInvite(this);
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0007F404 File Offset: 0x0007D604
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x0007F435 File Offset: 0x0007D635
		[DebuggerNonUserCode]
		public ulong InviteId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong inviteIdDefaultValue;
				if (flag)
				{
					inviteIdDefaultValue = this.inviteId_;
				}
				else
				{
					inviteIdDefaultValue = OutstandingPartyInvite.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x0007F450 File Offset: 0x0007D650
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0007F46D File Offset: 0x0007D66D
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0007F480 File Offset: 0x0007D680
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0007F498 File Offset: 0x0007D698
		[DebuggerNonUserCode]
		public PartyInvite PartyInvite
		{
			get
			{
				return this.partyInvite_;
			}
			set
			{
				this.partyInvite_ = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x0007F4D5 File Offset: 0x0007D6D5
		[DebuggerNonUserCode]
		public ulong CreatedTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong createdTimeDefaultValue;
				if (flag)
				{
					createdTimeDefaultValue = this.createdTime_;
				}
				else
				{
					createdTimeDefaultValue = OutstandingPartyInvite.CreatedTimeDefaultValue;
				}
				return createdTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.createdTime_ = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0007F4F0 File Offset: 0x0007D6F0
		[DebuggerNonUserCode]
		public bool HasCreatedTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0007F50D File Offset: 0x0007D70D
		[DebuggerNonUserCode]
		public void ClearCreatedTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0007F520 File Offset: 0x0007D720
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x0007F541 File Offset: 0x0007D741
		[DebuggerNonUserCode]
		public string InviteePartyId
		{
			get
			{
				return this.inviteePartyId_ ?? OutstandingPartyInvite.InviteePartyIdDefaultValue;
			}
			set
			{
				this.inviteePartyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0007F558 File Offset: 0x0007D758
		[DebuggerNonUserCode]
		public bool HasInviteePartyId
		{
			get
			{
				return this.inviteePartyId_ != null;
			}
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x0007F573 File Offset: 0x0007D773
		[DebuggerNonUserCode]
		public void ClearInviteePartyId()
		{
			this.inviteePartyId_ = null;
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0007F580 File Offset: 0x0007D780
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OutstandingPartyInvite);
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0007F5A0 File Offset: 0x0007D7A0
		[DebuggerNonUserCode]
		public bool Equals(OutstandingPartyInvite other)
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
					bool flag4 = this.InviteId != other.InviteId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.PartyInvite, other.PartyInvite);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CreatedTime != other.CreatedTime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.InviteePartyId != other.InviteePartyId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0007F650 File Offset: 0x0007D850
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			bool flag = this.partyInvite_ != null;
			if (flag)
			{
				num ^= this.PartyInvite.GetHashCode();
			}
			bool hasCreatedTime = this.HasCreatedTime;
			if (hasCreatedTime)
			{
				num ^= this.CreatedTime.GetHashCode();
			}
			bool hasInviteePartyId = this.HasInviteePartyId;
			if (hasInviteePartyId)
			{
				num ^= this.InviteePartyId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x0007F6F4 File Offset: 0x0007D8F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x0007F70C File Offset: 0x0007D90C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0007F718 File Offset: 0x0007D918
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.InviteId);
			}
			bool flag = this.partyInvite_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PartyInvite);
			}
			bool hasCreatedTime = this.HasCreatedTime;
			if (hasCreatedTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.CreatedTime);
			}
			bool hasInviteePartyId = this.HasInviteePartyId;
			if (hasInviteePartyId)
			{
				output.WriteRawTag(34);
				output.WriteString(this.InviteePartyId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0007F7D0 File Offset: 0x0007D9D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			bool flag = this.partyInvite_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartyInvite);
			}
			bool hasCreatedTime = this.HasCreatedTime;
			if (hasCreatedTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedTime);
			}
			bool hasInviteePartyId = this.HasInviteePartyId;
			if (hasInviteePartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviteePartyId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0007F87C File Offset: 0x0007DA7C
		[DebuggerNonUserCode]
		public void MergeFrom(OutstandingPartyInvite other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				bool flag2 = other.partyInvite_ != null;
				if (flag2)
				{
					bool flag3 = this.partyInvite_ == null;
					if (flag3)
					{
						this.PartyInvite = new PartyInvite();
					}
					this.PartyInvite.MergeFrom(other.PartyInvite);
				}
				bool hasCreatedTime = other.HasCreatedTime;
				if (hasCreatedTime)
				{
					this.CreatedTime = other.CreatedTime;
				}
				bool hasInviteePartyId = other.HasInviteePartyId;
				if (hasInviteePartyId)
				{
					this.InviteePartyId = other.InviteePartyId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0007F93A File Offset: 0x0007DB3A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0007F948 File Offset: 0x0007DB48
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
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_002B;
						}
						bool flag = this.partyInvite_ == null;
						if (flag)
						{
							this.PartyInvite = new PartyInvite();
						}
						input.ReadMessage(this.PartyInvite);
					}
					else
					{
						this.InviteId = input.ReadUInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002B;
					}
					this.InviteePartyId = input.ReadString();
				}
				else
				{
					this.CreatedTime = input.ReadUInt64();
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E69 RID: 3689
		private static readonly MessageParser<OutstandingPartyInvite> _parser = new MessageParser<OutstandingPartyInvite>(() => new OutstandingPartyInvite());

		// Token: 0x04000E6A RID: 3690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E6B RID: 3691
		private int _hasBits0;

		// Token: 0x04000E6C RID: 3692
		public const int InviteIdFieldNumber = 1;

		// Token: 0x04000E6D RID: 3693
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04000E6E RID: 3694
		private ulong inviteId_;

		// Token: 0x04000E6F RID: 3695
		public const int PartyInviteFieldNumber = 2;

		// Token: 0x04000E70 RID: 3696
		private PartyInvite partyInvite_;

		// Token: 0x04000E71 RID: 3697
		public const int CreatedTimeFieldNumber = 3;

		// Token: 0x04000E72 RID: 3698
		private static readonly ulong CreatedTimeDefaultValue = 0UL;

		// Token: 0x04000E73 RID: 3699
		private ulong createdTime_;

		// Token: 0x04000E74 RID: 3700
		public const int InviteePartyIdFieldNumber = 4;

		// Token: 0x04000E75 RID: 3701
		private static readonly string InviteePartyIdDefaultValue = "";

		// Token: 0x04000E76 RID: 3702
		private string inviteePartyId_;
	}
}
