using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200041A RID: 1050
	public sealed class FriendOfFriend : IMessage<FriendOfFriend>, IMessage, IEquatable<FriendOfFriend>, IDeepCloneable<FriendOfFriend>, IBufferMessage
	{
		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06006769 RID: 26473 RVA: 0x001907E8 File Offset: 0x0018E9E8
		[DebuggerNonUserCode]
		public static MessageParser<FriendOfFriend> Parser
		{
			get
			{
				return FriendOfFriend._parser;
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600676A RID: 26474 RVA: 0x00190800 File Offset: 0x0018EA00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600676B RID: 26475 RVA: 0x00190824 File Offset: 0x0018EA24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendOfFriend.Descriptor;
			}
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x0019083B File Offset: 0x0018EA3B
		[DebuggerNonUserCode]
		public FriendOfFriend()
		{
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00190850 File Offset: 0x0018EA50
		[DebuggerNonUserCode]
		public FriendOfFriend(FriendOfFriend other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.role_ = other.role_.Clone();
			this.privileges_ = other.privileges_;
			this.fullName_ = other.fullName_;
			this.battleTag_ = other.battleTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x001908D4 File Offset: 0x0018EAD4
		[DebuggerNonUserCode]
		public FriendOfFriend Clone()
		{
			return new FriendOfFriend(this);
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x001908EC File Offset: 0x0018EAEC
		// (set) Token: 0x06006770 RID: 26480 RVA: 0x00190904 File Offset: 0x0018EB04
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

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06006771 RID: 26481 RVA: 0x00190910 File Offset: 0x0018EB10
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06006772 RID: 26482 RVA: 0x00190928 File Offset: 0x0018EB28
		// (set) Token: 0x06006773 RID: 26483 RVA: 0x00190959 File Offset: 0x0018EB59
		[DebuggerNonUserCode]
		public ulong Privileges
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong privilegesDefaultValue;
				if (flag)
				{
					privilegesDefaultValue = this.privileges_;
				}
				else
				{
					privilegesDefaultValue = FriendOfFriend.PrivilegesDefaultValue;
				}
				return privilegesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privileges_ = value;
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06006774 RID: 26484 RVA: 0x00190974 File Offset: 0x0018EB74
		[DebuggerNonUserCode]
		public bool HasPrivileges
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00190991 File Offset: 0x0018EB91
		[DebuggerNonUserCode]
		public void ClearPrivileges()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x001909A4 File Offset: 0x0018EBA4
		// (set) Token: 0x06006777 RID: 26487 RVA: 0x001909C5 File Offset: 0x0018EBC5
		[DebuggerNonUserCode]
		public string FullName
		{
			get
			{
				return this.fullName_ ?? FriendOfFriend.FullNameDefaultValue;
			}
			set
			{
				this.fullName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x001909DC File Offset: 0x0018EBDC
		[DebuggerNonUserCode]
		public bool HasFullName
		{
			get
			{
				return this.fullName_ != null;
			}
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x001909F7 File Offset: 0x0018EBF7
		[DebuggerNonUserCode]
		public void ClearFullName()
		{
			this.fullName_ = null;
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x0600677A RID: 26490 RVA: 0x00190A04 File Offset: 0x0018EC04
		// (set) Token: 0x0600677B RID: 26491 RVA: 0x00190A25 File Offset: 0x0018EC25
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? FriendOfFriend.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x00190A3C File Offset: 0x0018EC3C
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x00190A57 File Offset: 0x0018EC57
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00190A64 File Offset: 0x0018EC64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendOfFriend);
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00190A84 File Offset: 0x0018EC84
		[DebuggerNonUserCode]
		public bool Equals(FriendOfFriend other)
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
						bool flag5 = !this.role_.Equals(other.role_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Privileges != other.Privileges;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FullName != other.FullName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BattleTag != other.BattleTag;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00190B58 File Offset: 0x0018ED58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num ^= this.Privileges.GetHashCode();
			}
			bool hasFullName = this.HasFullName;
			if (hasFullName)
			{
				num ^= this.FullName.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x00190C08 File Offset: 0x0018EE08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x00190C20 File Offset: 0x0018EE20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x00190C2C File Offset: 0x0018EE2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountId);
			}
			this.role_.WriteTo(ref output, FriendOfFriend._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.Privileges);
			}
			bool hasFullName = this.HasFullName;
			if (hasFullName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.FullName);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(58);
				output.WriteString(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x00190CF8 File Offset: 0x0018EEF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			num += this.role_.CalculateSize(FriendOfFriend._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Privileges);
			}
			bool hasFullName = this.HasFullName;
			if (hasFullName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FullName);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x00190DB8 File Offset: 0x0018EFB8
		[DebuggerNonUserCode]
		public void MergeFrom(FriendOfFriend other)
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
				this.role_.Add(other.role_);
				bool hasPrivileges = other.HasPrivileges;
				if (hasPrivileges)
				{
					this.Privileges = other.Privileges;
				}
				bool hasFullName = other.HasFullName;
				if (hasFullName)
				{
					this.FullName = other.FullName;
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x00190E88 File Offset: 0x0018F088
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x00190E94 File Offset: 0x0018F094
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
					if (num3 != 10U)
					{
						if (num3 != 24U && num3 != 26U)
						{
							goto IL_003A;
						}
						this.role_.AddEntriesFrom(ref input, FriendOfFriend._repeated_role_codec);
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
				else if (num3 != 32U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_003A;
						}
						this.BattleTag = input.ReadString();
					}
					else
					{
						this.FullName = input.ReadString();
					}
				}
				else
				{
					this.Privileges = input.ReadUInt64();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F09 RID: 12041
		private static readonly MessageParser<FriendOfFriend> _parser = new MessageParser<FriendOfFriend>(() => new FriendOfFriend());

		// Token: 0x04002F0A RID: 12042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F0B RID: 12043
		private int _hasBits0;

		// Token: 0x04002F0C RID: 12044
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04002F0D RID: 12045
		private EntityId accountId_;

		// Token: 0x04002F0E RID: 12046
		public const int RoleFieldNumber = 3;

		// Token: 0x04002F0F RID: 12047
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002F10 RID: 12048
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x04002F11 RID: 12049
		public const int PrivilegesFieldNumber = 4;

		// Token: 0x04002F12 RID: 12050
		private static readonly ulong PrivilegesDefaultValue = 0UL;

		// Token: 0x04002F13 RID: 12051
		private ulong privileges_;

		// Token: 0x04002F14 RID: 12052
		public const int FullNameFieldNumber = 6;

		// Token: 0x04002F15 RID: 12053
		private static readonly string FullNameDefaultValue = "";

		// Token: 0x04002F16 RID: 12054
		private string fullName_;

		// Token: 0x04002F17 RID: 12055
		public const int BattleTagFieldNumber = 7;

		// Token: 0x04002F18 RID: 12056
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04002F19 RID: 12057
		private string battleTag_;
	}
}
