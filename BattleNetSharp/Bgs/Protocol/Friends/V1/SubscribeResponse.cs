using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200041F RID: 1055
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x00193290 File Offset: 0x00191490
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600681B RID: 26651 RVA: 0x001932A8 File Offset: 0x001914A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600681C RID: 26652 RVA: 0x001932CC File Offset: 0x001914CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x001932E3 File Offset: 0x001914E3
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x0019331C File Offset: 0x0019151C
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.maxFriends_ = other.maxFriends_;
			this.maxReceivedInvitations_ = other.maxReceivedInvitations_;
			this.maxSentInvitations_ = other.maxSentInvitations_;
			this.role_ = other.role_.Clone();
			this.friends_ = other.friends_.Clone();
			this.receivedInvitations_ = other.receivedInvitations_.Clone();
			this.sentInvitations_ = other.sentInvitations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x001933B8 File Offset: 0x001915B8
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x001933D0 File Offset: 0x001915D0
		// (set) Token: 0x06006821 RID: 26657 RVA: 0x00193401 File Offset: 0x00191601
		[DebuggerNonUserCode]
		public uint MaxFriends
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint maxFriendsDefaultValue;
				if (flag)
				{
					maxFriendsDefaultValue = this.maxFriends_;
				}
				else
				{
					maxFriendsDefaultValue = SubscribeResponse.MaxFriendsDefaultValue;
				}
				return maxFriendsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.maxFriends_ = value;
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06006822 RID: 26658 RVA: 0x0019341C File Offset: 0x0019161C
		[DebuggerNonUserCode]
		public bool HasMaxFriends
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x00193439 File Offset: 0x00191639
		[DebuggerNonUserCode]
		public void ClearMaxFriends()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06006824 RID: 26660 RVA: 0x0019344C File Offset: 0x0019164C
		// (set) Token: 0x06006825 RID: 26661 RVA: 0x0019347D File Offset: 0x0019167D
		[DebuggerNonUserCode]
		public uint MaxReceivedInvitations
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint maxReceivedInvitationsDefaultValue;
				if (flag)
				{
					maxReceivedInvitationsDefaultValue = this.maxReceivedInvitations_;
				}
				else
				{
					maxReceivedInvitationsDefaultValue = SubscribeResponse.MaxReceivedInvitationsDefaultValue;
				}
				return maxReceivedInvitationsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.maxReceivedInvitations_ = value;
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x00193498 File Offset: 0x00191698
		[DebuggerNonUserCode]
		public bool HasMaxReceivedInvitations
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x001934B5 File Offset: 0x001916B5
		[DebuggerNonUserCode]
		public void ClearMaxReceivedInvitations()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06006828 RID: 26664 RVA: 0x001934C8 File Offset: 0x001916C8
		// (set) Token: 0x06006829 RID: 26665 RVA: 0x001934F9 File Offset: 0x001916F9
		[DebuggerNonUserCode]
		public uint MaxSentInvitations
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint maxSentInvitationsDefaultValue;
				if (flag)
				{
					maxSentInvitationsDefaultValue = this.maxSentInvitations_;
				}
				else
				{
					maxSentInvitationsDefaultValue = SubscribeResponse.MaxSentInvitationsDefaultValue;
				}
				return maxSentInvitationsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.maxSentInvitations_ = value;
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x0600682A RID: 26666 RVA: 0x00193514 File Offset: 0x00191714
		[DebuggerNonUserCode]
		public bool HasMaxSentInvitations
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x00193531 File Offset: 0x00191731
		[DebuggerNonUserCode]
		public void ClearMaxSentInvitations()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600682C RID: 26668 RVA: 0x00193544 File Offset: 0x00191744
		[DebuggerNonUserCode]
		public RepeatedField<Role> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x0019355C File Offset: 0x0019175C
		[DebuggerNonUserCode]
		public RepeatedField<Friend> Friends
		{
			get
			{
				return this.friends_;
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600682E RID: 26670 RVA: 0x00193574 File Offset: 0x00191774
		[DebuggerNonUserCode]
		public RepeatedField<ReceivedInvitation> ReceivedInvitations
		{
			get
			{
				return this.receivedInvitations_;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x0019358C File Offset: 0x0019178C
		[DebuggerNonUserCode]
		public RepeatedField<SentInvitation> SentInvitations
		{
			get
			{
				return this.sentInvitations_;
			}
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x001935A4 File Offset: 0x001917A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x001935C4 File Offset: 0x001917C4
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResponse other)
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
					bool flag4 = this.MaxFriends != other.MaxFriends;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxReceivedInvitations != other.MaxReceivedInvitations;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MaxSentInvitations != other.MaxSentInvitations;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.role_.Equals(other.role_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.friends_.Equals(other.friends_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.receivedInvitations_.Equals(other.receivedInvitations_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.sentInvitations_.Equals(other.sentInvitations_);
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

		// Token: 0x06006832 RID: 26674 RVA: 0x001936D8 File Offset: 0x001918D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMaxFriends = this.HasMaxFriends;
			if (hasMaxFriends)
			{
				num ^= this.MaxFriends.GetHashCode();
			}
			bool hasMaxReceivedInvitations = this.HasMaxReceivedInvitations;
			if (hasMaxReceivedInvitations)
			{
				num ^= this.MaxReceivedInvitations.GetHashCode();
			}
			bool hasMaxSentInvitations = this.HasMaxSentInvitations;
			if (hasMaxSentInvitations)
			{
				num ^= this.MaxSentInvitations.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			num ^= this.friends_.GetHashCode();
			num ^= this.receivedInvitations_.GetHashCode();
			num ^= this.sentInvitations_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x0019379C File Offset: 0x0019199C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x001937B4 File Offset: 0x001919B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x001937C0 File Offset: 0x001919C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMaxFriends = this.HasMaxFriends;
			if (hasMaxFriends)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MaxFriends);
			}
			bool hasMaxReceivedInvitations = this.HasMaxReceivedInvitations;
			if (hasMaxReceivedInvitations)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxReceivedInvitations);
			}
			bool hasMaxSentInvitations = this.HasMaxSentInvitations;
			if (hasMaxSentInvitations)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaxSentInvitations);
			}
			this.role_.WriteTo(ref output, SubscribeResponse._repeated_role_codec);
			this.friends_.WriteTo(ref output, SubscribeResponse._repeated_friends_codec);
			this.receivedInvitations_.WriteTo(ref output, SubscribeResponse._repeated_receivedInvitations_codec);
			this.sentInvitations_.WriteTo(ref output, SubscribeResponse._repeated_sentInvitations_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x00193898 File Offset: 0x00191A98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMaxFriends = this.HasMaxFriends;
			if (hasMaxFriends)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxFriends);
			}
			bool hasMaxReceivedInvitations = this.HasMaxReceivedInvitations;
			if (hasMaxReceivedInvitations)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxReceivedInvitations);
			}
			bool hasMaxSentInvitations = this.HasMaxSentInvitations;
			if (hasMaxSentInvitations)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxSentInvitations);
			}
			num += this.role_.CalculateSize(SubscribeResponse._repeated_role_codec);
			num += this.friends_.CalculateSize(SubscribeResponse._repeated_friends_codec);
			num += this.receivedInvitations_.CalculateSize(SubscribeResponse._repeated_receivedInvitations_codec);
			num += this.sentInvitations_.CalculateSize(SubscribeResponse._repeated_sentInvitations_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00193970 File Offset: 0x00191B70
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMaxFriends = other.HasMaxFriends;
				if (hasMaxFriends)
				{
					this.MaxFriends = other.MaxFriends;
				}
				bool hasMaxReceivedInvitations = other.HasMaxReceivedInvitations;
				if (hasMaxReceivedInvitations)
				{
					this.MaxReceivedInvitations = other.MaxReceivedInvitations;
				}
				bool hasMaxSentInvitations = other.HasMaxSentInvitations;
				if (hasMaxSentInvitations)
				{
					this.MaxSentInvitations = other.MaxSentInvitations;
				}
				this.role_.Add(other.role_);
				this.friends_.Add(other.friends_);
				this.receivedInvitations_.Add(other.receivedInvitations_);
				this.sentInvitations_.Add(other.sentInvitations_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00193A36 File Offset: 0x00191C36
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00193A44 File Offset: 0x00191C44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0048;
							}
							this.MaxSentInvitations = input.ReadUInt32();
						}
						else
						{
							this.MaxReceivedInvitations = input.ReadUInt32();
						}
					}
					else
					{
						this.MaxFriends = input.ReadUInt32();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0048;
						}
						this.friends_.AddEntriesFrom(ref input, SubscribeResponse._repeated_friends_codec);
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, SubscribeResponse._repeated_role_codec);
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						goto IL_0048;
					}
					this.sentInvitations_.AddEntriesFrom(ref input, SubscribeResponse._repeated_sentInvitations_codec);
				}
				else
				{
					this.receivedInvitations_.AddEntriesFrom(ref input, SubscribeResponse._repeated_receivedInvitations_codec);
				}
				continue;
				IL_0048:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F66 RID: 12134
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x04002F67 RID: 12135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F68 RID: 12136
		private int _hasBits0;

		// Token: 0x04002F69 RID: 12137
		public const int MaxFriendsFieldNumber = 1;

		// Token: 0x04002F6A RID: 12138
		private static readonly uint MaxFriendsDefaultValue = 0U;

		// Token: 0x04002F6B RID: 12139
		private uint maxFriends_;

		// Token: 0x04002F6C RID: 12140
		public const int MaxReceivedInvitationsFieldNumber = 2;

		// Token: 0x04002F6D RID: 12141
		private static readonly uint MaxReceivedInvitationsDefaultValue = 0U;

		// Token: 0x04002F6E RID: 12142
		private uint maxReceivedInvitations_;

		// Token: 0x04002F6F RID: 12143
		public const int MaxSentInvitationsFieldNumber = 3;

		// Token: 0x04002F70 RID: 12144
		private static readonly uint MaxSentInvitationsDefaultValue = 0U;

		// Token: 0x04002F71 RID: 12145
		private uint maxSentInvitations_;

		// Token: 0x04002F72 RID: 12146
		public const int RoleFieldNumber = 4;

		// Token: 0x04002F73 RID: 12147
		private static readonly FieldCodec<Role> _repeated_role_codec = FieldCodec.ForMessage<Role>(34U, Bgs.Protocol.Role.Parser);

		// Token: 0x04002F74 RID: 12148
		private readonly RepeatedField<Role> role_ = new RepeatedField<Role>();

		// Token: 0x04002F75 RID: 12149
		public const int FriendsFieldNumber = 5;

		// Token: 0x04002F76 RID: 12150
		private static readonly FieldCodec<Friend> _repeated_friends_codec = FieldCodec.ForMessage<Friend>(42U, Friend.Parser);

		// Token: 0x04002F77 RID: 12151
		private readonly RepeatedField<Friend> friends_ = new RepeatedField<Friend>();

		// Token: 0x04002F78 RID: 12152
		public const int ReceivedInvitationsFieldNumber = 7;

		// Token: 0x04002F79 RID: 12153
		private static readonly FieldCodec<ReceivedInvitation> _repeated_receivedInvitations_codec = FieldCodec.ForMessage<ReceivedInvitation>(58U, ReceivedInvitation.Parser);

		// Token: 0x04002F7A RID: 12154
		private readonly RepeatedField<ReceivedInvitation> receivedInvitations_ = new RepeatedField<ReceivedInvitation>();

		// Token: 0x04002F7B RID: 12155
		public const int SentInvitationsFieldNumber = 8;

		// Token: 0x04002F7C RID: 12156
		private static readonly FieldCodec<SentInvitation> _repeated_sentInvitations_codec = FieldCodec.ForMessage<SentInvitation>(66U, SentInvitation.Parser);

		// Token: 0x04002F7D RID: 12157
		private readonly RepeatedField<SentInvitation> sentInvitations_ = new RepeatedField<SentInvitation>();
	}
}
