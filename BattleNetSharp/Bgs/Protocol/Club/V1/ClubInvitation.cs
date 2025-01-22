using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000456 RID: 1110
	public sealed class ClubInvitation : IMessage<ClubInvitation>, IMessage, IEquatable<ClubInvitation>, IDeepCloneable<ClubInvitation>, IBufferMessage
	{
		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x06006C6F RID: 27759 RVA: 0x001A56F0 File Offset: 0x001A38F0
		[DebuggerNonUserCode]
		public static MessageParser<ClubInvitation> Parser
		{
			get
			{
				return ClubInvitation._parser;
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x06006C70 RID: 27760 RVA: 0x001A5708 File Offset: 0x001A3908
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x001A572C File Offset: 0x001A392C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubInvitation.Descriptor;
			}
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x001A5743 File Offset: 0x001A3943
		[DebuggerNonUserCode]
		public ClubInvitation()
		{
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x001A5758 File Offset: 0x001A3958
		[DebuggerNonUserCode]
		public ClubInvitation(ClubInvitation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.inviter_ = ((other.inviter_ != null) ? other.inviter_.Clone() : null);
			this.invitee_ = ((other.invitee_ != null) ? other.invitee_.Clone() : null);
			this.club_ = ((other.club_ != null) ? other.club_.Clone() : null);
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.creationTime_ = other.creationTime_;
			this.expirationTime_ = other.expirationTime_;
			this.suggester_ = ((other.suggester_ != null) ? other.suggester_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x001A584C File Offset: 0x001A3A4C
		[DebuggerNonUserCode]
		public ClubInvitation Clone()
		{
			return new ClubInvitation(this);
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x001A5864 File Offset: 0x001A3A64
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x001A5895 File Offset: 0x001A3A95
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
					idDefaultValue = ClubInvitation.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x06006C77 RID: 27767 RVA: 0x001A58B0 File Offset: 0x001A3AB0
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x001A58CD File Offset: 0x001A3ACD
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x06006C79 RID: 27769 RVA: 0x001A58E0 File Offset: 0x001A3AE0
		// (set) Token: 0x06006C7A RID: 27770 RVA: 0x001A58F8 File Offset: 0x001A3AF8
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

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x06006C7B RID: 27771 RVA: 0x001A5904 File Offset: 0x001A3B04
		// (set) Token: 0x06006C7C RID: 27772 RVA: 0x001A591C File Offset: 0x001A3B1C
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

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x001A5928 File Offset: 0x001A3B28
		// (set) Token: 0x06006C7E RID: 27774 RVA: 0x001A5940 File Offset: 0x001A3B40
		[DebuggerNonUserCode]
		public ClubDescription Club
		{
			get
			{
				return this.club_;
			}
			set
			{
				this.club_ = value;
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x06006C7F RID: 27775 RVA: 0x001A594C File Offset: 0x001A3B4C
		// (set) Token: 0x06006C80 RID: 27776 RVA: 0x001A5964 File Offset: 0x001A3B64
		[DebuggerNonUserCode]
		public ClubSlot Slot
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

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x001A5970 File Offset: 0x001A3B70
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x06006C82 RID: 27778 RVA: 0x001A5988 File Offset: 0x001A3B88
		// (set) Token: 0x06006C83 RID: 27779 RVA: 0x001A59B9 File Offset: 0x001A3BB9
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
					creationTimeDefaultValue = ClubInvitation.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.creationTime_ = value;
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x06006C84 RID: 27780 RVA: 0x001A59D4 File Offset: 0x001A3BD4
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x001A59F1 File Offset: 0x001A3BF1
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x001A5A04 File Offset: 0x001A3C04
		// (set) Token: 0x06006C87 RID: 27783 RVA: 0x001A5A35 File Offset: 0x001A3C35
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
					expirationTimeDefaultValue = ClubInvitation.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x001A5A50 File Offset: 0x001A3C50
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x001A5A6D File Offset: 0x001A3C6D
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x001A5A80 File Offset: 0x001A3C80
		// (set) Token: 0x06006C8B RID: 27787 RVA: 0x001A5A98 File Offset: 0x001A3C98
		[DebuggerNonUserCode]
		public MemberDescription Suggester
		{
			get
			{
				return this.suggester_;
			}
			set
			{
				this.suggester_ = value;
			}
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x001A5AA4 File Offset: 0x001A3CA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubInvitation);
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x001A5AC4 File Offset: 0x001A3CC4
		[DebuggerNonUserCode]
		public bool Equals(ClubInvitation other)
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
								bool flag7 = !object.Equals(this.Club, other.Club);
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
										bool flag9 = !this.attribute_.Equals(other.attribute_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.CreationTime != other.CreationTime;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ExpirationTime != other.ExpirationTime;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.Suggester, other.Suggester);
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
												}
											}
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

		// Token: 0x06006C8E RID: 27790 RVA: 0x001A5C1C File Offset: 0x001A3E1C
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
			bool flag3 = this.club_ != null;
			if (flag3)
			{
				num ^= this.Club.GetHashCode();
			}
			bool flag4 = this.slot_ != null;
			if (flag4)
			{
				num ^= this.Slot.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
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
			bool flag5 = this.suggester_ != null;
			if (flag5)
			{
				num ^= this.Suggester.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x001A5D44 File Offset: 0x001A3F44
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x001A5D5C File Offset: 0x001A3F5C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x001A5D68 File Offset: 0x001A3F68
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
			bool flag3 = this.club_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Club);
			}
			bool flag4 = this.slot_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Slot);
			}
			this.attribute_.WriteTo(ref output, ClubInvitation._repeated_attribute_codec);
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
			bool flag5 = this.suggester_ != null;
			if (flag5)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Suggester);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x001A5ED0 File Offset: 0x001A40D0
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
			bool flag3 = this.club_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Club);
			}
			bool flag4 = this.slot_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			num += this.attribute_.CalculateSize(ClubInvitation._repeated_attribute_codec);
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
			bool flag5 = this.suggester_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggester);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x001A6008 File Offset: 0x001A4208
		[DebuggerNonUserCode]
		public void MergeFrom(ClubInvitation other)
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
				bool flag6 = other.club_ != null;
				if (flag6)
				{
					bool flag7 = this.club_ == null;
					if (flag7)
					{
						this.Club = new ClubDescription();
					}
					this.Club.MergeFrom(other.Club);
				}
				bool flag8 = other.slot_ != null;
				if (flag8)
				{
					bool flag9 = this.slot_ == null;
					if (flag9)
					{
						this.Slot = new ClubSlot();
					}
					this.Slot.MergeFrom(other.Slot);
				}
				this.attribute_.Add(other.attribute_);
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
				bool flag10 = other.suggester_ != null;
				if (flag10)
				{
					bool flag11 = this.suggester_ == null;
					if (flag11)
					{
						this.Suggester = new MemberDescription();
					}
					this.Suggester.MergeFrom(other.Suggester);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x001A61D8 File Offset: 0x001A43D8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x001A61E4 File Offset: 0x001A43E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 9U)
						{
							if (num3 != 18U)
							{
								goto IL_006E;
							}
							bool flag = this.inviter_ == null;
							if (flag)
							{
								this.Inviter = new MemberDescription();
							}
							input.ReadMessage(this.Inviter);
						}
						else
						{
							this.Id = input.ReadFixed64();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_006E;
						}
						bool flag2 = this.club_ == null;
						if (flag2)
						{
							this.Club = new ClubDescription();
						}
						input.ReadMessage(this.Club);
					}
					else
					{
						bool flag3 = this.invitee_ == null;
						if (flag3)
						{
							this.Invitee = new MemberDescription();
						}
						input.ReadMessage(this.Invitee);
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_006E;
						}
						this.attribute_.AddEntriesFrom(ref input, ClubInvitation._repeated_attribute_codec);
					}
					else
					{
						bool flag4 = this.slot_ == null;
						if (flag4)
						{
							this.Slot = new ClubSlot();
						}
						input.ReadMessage(this.Slot);
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						if (num3 != 74U)
						{
							goto IL_006E;
						}
						bool flag5 = this.suggester_ == null;
						if (flag5)
						{
							this.Suggester = new MemberDescription();
						}
						input.ReadMessage(this.Suggester);
					}
					else
					{
						this.ExpirationTime = input.ReadUInt64();
					}
				}
				else
				{
					this.CreationTime = input.ReadUInt64();
				}
				continue;
				IL_006E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031C9 RID: 12745
		private static readonly MessageParser<ClubInvitation> _parser = new MessageParser<ClubInvitation>(() => new ClubInvitation());

		// Token: 0x040031CA RID: 12746
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031CB RID: 12747
		private int _hasBits0;

		// Token: 0x040031CC RID: 12748
		public const int IdFieldNumber = 1;

		// Token: 0x040031CD RID: 12749
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x040031CE RID: 12750
		private ulong id_;

		// Token: 0x040031CF RID: 12751
		public const int InviterFieldNumber = 2;

		// Token: 0x040031D0 RID: 12752
		private MemberDescription inviter_;

		// Token: 0x040031D1 RID: 12753
		public const int InviteeFieldNumber = 3;

		// Token: 0x040031D2 RID: 12754
		private MemberDescription invitee_;

		// Token: 0x040031D3 RID: 12755
		public const int ClubFieldNumber = 4;

		// Token: 0x040031D4 RID: 12756
		private ClubDescription club_;

		// Token: 0x040031D5 RID: 12757
		public const int SlotFieldNumber = 5;

		// Token: 0x040031D6 RID: 12758
		private ClubSlot slot_;

		// Token: 0x040031D7 RID: 12759
		public const int AttributeFieldNumber = 6;

		// Token: 0x040031D8 RID: 12760
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(50U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040031D9 RID: 12761
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040031DA RID: 12762
		public const int CreationTimeFieldNumber = 7;

		// Token: 0x040031DB RID: 12763
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x040031DC RID: 12764
		private ulong creationTime_;

		// Token: 0x040031DD RID: 12765
		public const int ExpirationTimeFieldNumber = 8;

		// Token: 0x040031DE RID: 12766
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x040031DF RID: 12767
		private ulong expirationTime_;

		// Token: 0x040031E0 RID: 12768
		public const int SuggesterFieldNumber = 9;

		// Token: 0x040031E1 RID: 12769
		private MemberDescription suggester_;
	}
}
