using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000698 RID: 1688
	public sealed class ChannelInvitation : IMessage<ChannelInvitation>, IMessage, IEquatable<ChannelInvitation>, IDeepCloneable<ChannelInvitation>, IBufferMessage
	{
		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x06009CAC RID: 40108 RVA: 0x002610A8 File Offset: 0x0025F2A8
		[DebuggerNonUserCode]
		public static MessageParser<ChannelInvitation> Parser
		{
			get
			{
				return ChannelInvitation._parser;
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x06009CAD RID: 40109 RVA: 0x002610C0 File Offset: 0x0025F2C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x06009CAE RID: 40110 RVA: 0x002610E4 File Offset: 0x0025F2E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelInvitation.Descriptor;
			}
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x002610FB File Offset: 0x0025F2FB
		[DebuggerNonUserCode]
		public ChannelInvitation()
		{
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x00261108 File Offset: 0x0025F308
		[DebuggerNonUserCode]
		public ChannelInvitation(ChannelInvitation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.inviter_ = ((other.inviter_ != null) ? other.inviter_.Clone() : null);
			this.invitee_ = ((other.invitee_ != null) ? other.invitee_.Clone() : null);
			this.channel_ = ((other.channel_ != null) ? other.channel_.Clone() : null);
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.creationTime_ = other.creationTime_;
			this.expirationTime_ = other.expirationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x002611D0 File Offset: 0x0025F3D0
		[DebuggerNonUserCode]
		public ChannelInvitation Clone()
		{
			return new ChannelInvitation(this);
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x06009CB2 RID: 40114 RVA: 0x002611E8 File Offset: 0x0025F3E8
		// (set) Token: 0x06009CB3 RID: 40115 RVA: 0x00261219 File Offset: 0x0025F419
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = ChannelInvitation.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06009CB4 RID: 40116 RVA: 0x00261234 File Offset: 0x0025F434
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x00261251 File Offset: 0x0025F451
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x06009CB6 RID: 40118 RVA: 0x00261264 File Offset: 0x0025F464
		// (set) Token: 0x06009CB7 RID: 40119 RVA: 0x0026127C File Offset: 0x0025F47C
		[DebuggerNonUserCode]
		public MemberDescription Inviter
		{
			get
			{
				return this.inviter_;
			}
			set
			{
				this.inviter_ = value;
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x06009CB8 RID: 40120 RVA: 0x00261288 File Offset: 0x0025F488
		// (set) Token: 0x06009CB9 RID: 40121 RVA: 0x002612A0 File Offset: 0x0025F4A0
		[DebuggerNonUserCode]
		public MemberDescription Invitee
		{
			get
			{
				return this.invitee_;
			}
			set
			{
				this.invitee_ = value;
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06009CBA RID: 40122 RVA: 0x002612AC File Offset: 0x0025F4AC
		// (set) Token: 0x06009CBB RID: 40123 RVA: 0x002612C4 File Offset: 0x0025F4C4
		[DebuggerNonUserCode]
		public ChannelDescription Channel
		{
			get
			{
				return this.channel_;
			}
			set
			{
				this.channel_ = value;
			}
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06009CBC RID: 40124 RVA: 0x002612D0 File Offset: 0x0025F4D0
		// (set) Token: 0x06009CBD RID: 40125 RVA: 0x002612E8 File Offset: 0x0025F4E8
		[DebuggerNonUserCode]
		public ChannelSlot Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06009CBE RID: 40126 RVA: 0x002612F4 File Offset: 0x0025F4F4
		// (set) Token: 0x06009CBF RID: 40127 RVA: 0x00261325 File Offset: 0x0025F525
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = ChannelInvitation.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.creationTime_ = value;
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x00261340 File Offset: 0x0025F540
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x0026135D File Offset: 0x0025F55D
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06009CC2 RID: 40130 RVA: 0x00261370 File Offset: 0x0025F570
		// (set) Token: 0x06009CC3 RID: 40131 RVA: 0x002613A1 File Offset: 0x0025F5A1
		[DebuggerNonUserCode]
		public ulong ExpirationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong expirationTimeDefaultValue;
				if (flag)
				{
					expirationTimeDefaultValue = this.expirationTime_;
				}
				else
				{
					expirationTimeDefaultValue = ChannelInvitation.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06009CC4 RID: 40132 RVA: 0x002613BC File Offset: 0x0025F5BC
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06009CC5 RID: 40133 RVA: 0x002613D9 File Offset: 0x0025F5D9
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x002613EC File Offset: 0x0025F5EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelInvitation);
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x0026140C File Offset: 0x0025F60C
		[DebuggerNonUserCode]
		public bool Equals(ChannelInvitation other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Inviter, other.Inviter);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Invitee, other.Invitee);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Channel, other.Channel);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Slot, other.Slot);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CreationTime != other.CreationTime;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ExpirationTime != other.ExpirationTime;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x00261520 File Offset: 0x0025F720
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this.inviter_ != null;
			if (flag)
			{
				num ^= this.Inviter.GetHashCode();
			}
			bool flag2 = this.invitee_ != null;
			if (flag2)
			{
				num ^= this.Invitee.GetHashCode();
			}
			bool flag3 = this.channel_ != null;
			if (flag3)
			{
				num ^= this.Channel.GetHashCode();
			}
			bool flag4 = this.slot_ != null;
			if (flag4)
			{
				num ^= this.Slot.GetHashCode();
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num ^= this.ExpirationTime.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x00261620 File Offset: 0x0025F820
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x00261638 File Offset: 0x0025F838
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CCB RID: 40139 RVA: 0x00261644 File Offset: 0x0025F844
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Id);
			}
			bool flag = this.inviter_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Inviter);
			}
			bool flag2 = this.invitee_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Invitee);
			}
			bool flag3 = this.channel_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Channel);
			}
			bool flag4 = this.slot_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Slot);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.ExpirationTime);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CCC RID: 40140 RVA: 0x00261770 File Offset: 0x0025F970
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 9;
			}
			bool flag = this.inviter_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Inviter);
			}
			bool flag2 = this.invitee_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitee);
			}
			bool flag3 = this.channel_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Channel);
			}
			bool flag4 = this.slot_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x00261874 File Offset: 0x0025FA74
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelInvitation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool flag2 = other.inviter_ != null;
				if (flag2)
				{
					bool flag3 = this.inviter_ == null;
					if (flag3)
					{
						this.Inviter = new MemberDescription();
					}
					this.Inviter.MergeFrom(other.Inviter);
				}
				bool flag4 = other.invitee_ != null;
				if (flag4)
				{
					bool flag5 = this.invitee_ == null;
					if (flag5)
					{
						this.Invitee = new MemberDescription();
					}
					this.Invitee.MergeFrom(other.Invitee);
				}
				bool flag6 = other.channel_ != null;
				if (flag6)
				{
					bool flag7 = this.channel_ == null;
					if (flag7)
					{
						this.Channel = new ChannelDescription();
					}
					this.Channel.MergeFrom(other.Channel);
				}
				bool flag8 = other.slot_ != null;
				if (flag8)
				{
					bool flag9 = this.slot_ == null;
					if (flag9)
					{
						this.Slot = new ChannelSlot();
					}
					this.Slot.MergeFrom(other.Slot);
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool hasExpirationTime = other.HasExpirationTime;
				if (hasExpirationTime)
				{
					this.ExpirationTime = other.ExpirationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x002619F2 File Offset: 0x0025FBF2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x00261A00 File Offset: 0x0025FC00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 9U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0055;
							}
							bool flag = this.invitee_ == null;
							if (flag)
							{
								this.Invitee = new MemberDescription();
							}
							input.ReadMessage(this.Invitee);
						}
						else
						{
							bool flag2 = this.inviter_ == null;
							if (flag2)
							{
								this.Inviter = new MemberDescription();
							}
							input.ReadMessage(this.Inviter);
						}
					}
					else
					{
						this.Id = input.ReadFixed64();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0055;
						}
						bool flag3 = this.slot_ == null;
						if (flag3)
						{
							this.Slot = new ChannelSlot();
						}
						input.ReadMessage(this.Slot);
					}
					else
					{
						bool flag4 = this.channel_ == null;
						if (flag4)
						{
							this.Channel = new ChannelDescription();
						}
						input.ReadMessage(this.Channel);
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						goto IL_0055;
					}
					this.ExpirationTime = input.ReadUInt64();
				}
				else
				{
					this.CreationTime = input.ReadUInt64();
				}
				continue;
				IL_0055:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046B5 RID: 18101
		private static readonly MessageParser<ChannelInvitation> _parser = new MessageParser<ChannelInvitation>(() => new ChannelInvitation());

		// Token: 0x040046B6 RID: 18102
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046B7 RID: 18103
		private int _hasBits0;

		// Token: 0x040046B8 RID: 18104
		public const int IdFieldNumber = 1;

		// Token: 0x040046B9 RID: 18105
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x040046BA RID: 18106
		private ulong id_;

		// Token: 0x040046BB RID: 18107
		public const int InviterFieldNumber = 2;

		// Token: 0x040046BC RID: 18108
		private MemberDescription inviter_;

		// Token: 0x040046BD RID: 18109
		public const int InviteeFieldNumber = 3;

		// Token: 0x040046BE RID: 18110
		private MemberDescription invitee_;

		// Token: 0x040046BF RID: 18111
		public const int ChannelFieldNumber = 4;

		// Token: 0x040046C0 RID: 18112
		private ChannelDescription channel_;

		// Token: 0x040046C1 RID: 18113
		public const int SlotFieldNumber = 5;

		// Token: 0x040046C2 RID: 18114
		private ChannelSlot slot_;

		// Token: 0x040046C3 RID: 18115
		public const int CreationTimeFieldNumber = 7;

		// Token: 0x040046C4 RID: 18116
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x040046C5 RID: 18117
		private ulong creationTime_;

		// Token: 0x040046C6 RID: 18118
		public const int ExpirationTimeFieldNumber = 8;

		// Token: 0x040046C7 RID: 18119
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x040046C8 RID: 18120
		private ulong expirationTime_;
	}
}
