using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003C2 RID: 962
	public sealed class BlockedPlayer : IMessage<BlockedPlayer>, IMessage, IEquatable<BlockedPlayer>, IDeepCloneable<BlockedPlayer>, IBufferMessage
	{
		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x00175960 File Offset: 0x00173B60
		[DebuggerNonUserCode]
		public static MessageParser<BlockedPlayer> Parser
		{
			get
			{
				return BlockedPlayer._parser;
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x00175978 File Offset: 0x00173B78
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x0017599C File Offset: 0x00173B9C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayer.Descriptor;
			}
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x001759B3 File Offset: 0x00173BB3
		[DebuggerNonUserCode]
		public BlockedPlayer()
		{
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x001759C8 File Offset: 0x00173BC8
		[DebuggerNonUserCode]
		public BlockedPlayer(BlockedPlayer other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.name_ = other.name_;
			this.role_ = other.role_.Clone();
			this.privileges_ = other.privileges_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x00175A40 File Offset: 0x00173C40
		[DebuggerNonUserCode]
		public BlockedPlayer Clone()
		{
			return new BlockedPlayer(this);
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x00175A58 File Offset: 0x00173C58
		// (set) Token: 0x06006063 RID: 24675 RVA: 0x00175A70 File Offset: 0x00173C70
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

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x00175A7C File Offset: 0x00173C7C
		// (set) Token: 0x06006065 RID: 24677 RVA: 0x00175A9D File Offset: 0x00173C9D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? BlockedPlayer.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x00175AB4 File Offset: 0x00173CB4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x00175ACF File Offset: 0x00173CCF
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x00175ADC File Offset: 0x00173CDC
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x00175AF4 File Offset: 0x00173CF4
		// (set) Token: 0x0600606A RID: 24682 RVA: 0x00175B25 File Offset: 0x00173D25
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
					privilegesDefaultValue = BlockedPlayer.PrivilegesDefaultValue;
				}
				return privilegesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privileges_ = value;
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600606B RID: 24683 RVA: 0x00175B40 File Offset: 0x00173D40
		[DebuggerNonUserCode]
		public bool HasPrivileges
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x00175B5D File Offset: 0x00173D5D
		[DebuggerNonUserCode]
		public void ClearPrivileges()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x00175B70 File Offset: 0x00173D70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayer);
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x00175B90 File Offset: 0x00173D90
		[DebuggerNonUserCode]
		public bool Equals(BlockedPlayer other)
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
						bool flag5 = this.Name != other.Name;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.role_.Equals(other.role_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Privileges != other.Privileges;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x00175C44 File Offset: 0x00173E44
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num ^= this.Privileges.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x00175CD8 File Offset: 0x00173ED8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x00175CF0 File Offset: 0x00173EF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x00175CFC File Offset: 0x00173EFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			this.role_.WriteTo(ref output, BlockedPlayer._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.Privileges);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x00175DA4 File Offset: 0x00173FA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.role_.CalculateSize(BlockedPlayer._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Privileges);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x00175E44 File Offset: 0x00174044
		[DebuggerNonUserCode]
		public void MergeFrom(BlockedPlayer other)
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
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this.role_.Add(other.role_);
				bool hasPrivileges = other.HasPrivileges;
				if (hasPrivileges)
				{
					this.Privileges = other.Privileges;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00175EF9 File Offset: 0x001740F9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x00175F04 File Offset: 0x00174104
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.Name = input.ReadString();
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
				else if (num3 != 24U && num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0033;
					}
					this.Privileges = input.ReadUInt64();
				}
				else
				{
					this.role_.AddEntriesFrom(ref input, BlockedPlayer._repeated_role_codec);
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C13 RID: 11283
		private static readonly MessageParser<BlockedPlayer> _parser = new MessageParser<BlockedPlayer>(() => new BlockedPlayer());

		// Token: 0x04002C14 RID: 11284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C15 RID: 11285
		private int _hasBits0;

		// Token: 0x04002C16 RID: 11286
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04002C17 RID: 11287
		private EntityId accountId_;

		// Token: 0x04002C18 RID: 11288
		public const int NameFieldNumber = 2;

		// Token: 0x04002C19 RID: 11289
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002C1A RID: 11290
		private string name_;

		// Token: 0x04002C1B RID: 11291
		public const int RoleFieldNumber = 3;

		// Token: 0x04002C1C RID: 11292
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002C1D RID: 11293
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x04002C1E RID: 11294
		public const int PrivilegesFieldNumber = 4;

		// Token: 0x04002C1F RID: 11295
		private static readonly ulong PrivilegesDefaultValue = 0UL;

		// Token: 0x04002C20 RID: 11296
		private ulong privileges_;
	}
}
