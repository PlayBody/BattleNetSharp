using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003BA RID: 954
	public sealed class BlockedPlayerAddedNotification : IMessage<BlockedPlayerAddedNotification>, IMessage, IEquatable<BlockedPlayerAddedNotification>, IDeepCloneable<BlockedPlayerAddedNotification>, IBufferMessage
	{
		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x001735B8 File Offset: 0x001717B8
		[DebuggerNonUserCode]
		public static MessageParser<BlockedPlayerAddedNotification> Parser
		{
			get
			{
				return BlockedPlayerAddedNotification._parser;
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06005FD9 RID: 24537 RVA: 0x001735D0 File Offset: 0x001717D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x001735F4 File Offset: 0x001717F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayerAddedNotification.Descriptor;
			}
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x0017360B File Offset: 0x0017180B
		[DebuggerNonUserCode]
		public BlockedPlayerAddedNotification()
		{
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x00173618 File Offset: 0x00171818
		[DebuggerNonUserCode]
		public BlockedPlayerAddedNotification(BlockedPlayerAddedNotification other)
			: this()
		{
			this.player_ = ((other.player_ != null) ? other.player_.Clone() : null);
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x00173694 File Offset: 0x00171894
		[DebuggerNonUserCode]
		public BlockedPlayerAddedNotification Clone()
		{
			return new BlockedPlayerAddedNotification(this);
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06005FDE RID: 24542 RVA: 0x001736AC File Offset: 0x001718AC
		// (set) Token: 0x06005FDF RID: 24543 RVA: 0x001736C4 File Offset: 0x001718C4
		[DebuggerNonUserCode]
		public BlockedPlayer Player
		{
			get
			{
				return this.player_;
			}
			set
			{
				this.player_ = value;
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06005FE0 RID: 24544 RVA: 0x001736D0 File Offset: 0x001718D0
		// (set) Token: 0x06005FE1 RID: 24545 RVA: 0x001736E8 File Offset: 0x001718E8
		[DebuggerNonUserCode]
		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06005FE2 RID: 24546 RVA: 0x001736F4 File Offset: 0x001718F4
		// (set) Token: 0x06005FE3 RID: 24547 RVA: 0x0017370C File Offset: 0x0017190C
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

		// Token: 0x06005FE4 RID: 24548 RVA: 0x00173718 File Offset: 0x00171918
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayerAddedNotification);
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x00173738 File Offset: 0x00171938
		[DebuggerNonUserCode]
		public bool Equals(BlockedPlayerAddedNotification other)
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
					bool flag4 = !object.Equals(this.Player, other.Player);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccountId, other.GameAccountId);
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

		// Token: 0x06005FE6 RID: 24550 RVA: 0x001737D0 File Offset: 0x001719D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.player_ != null;
			if (flag)
			{
				num ^= this.Player.GetHashCode();
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag3 = this.accountId_ != null;
			if (flag3)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x00173858 File Offset: 0x00171A58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x00173870 File Offset: 0x00171A70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x0017387C File Offset: 0x00171A7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.player_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Player);
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccountId);
			}
			bool flag3 = this.accountId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AccountId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x00173918 File Offset: 0x00171B18
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.player_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Player);
			}
			bool flag2 = this.gameAccountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool flag3 = this.accountId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x001739AC File Offset: 0x00171BAC
		[DebuggerNonUserCode]
		public void MergeFrom(BlockedPlayerAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.player_ != null;
				if (flag2)
				{
					bool flag3 = this.player_ == null;
					if (flag3)
					{
						this.Player = new BlockedPlayer();
					}
					this.Player.MergeFrom(other.Player);
				}
				bool flag4 = other.gameAccountId_ != null;
				if (flag4)
				{
					bool flag5 = this.gameAccountId_ == null;
					if (flag5)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				bool flag6 = other.accountId_ != null;
				if (flag6)
				{
					bool flag7 = this.accountId_ == null;
					if (flag7)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x00173A99 File Offset: 0x00171C99
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x00173AA4 File Offset: 0x00171CA4
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
						if (num3 != 26U)
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
						bool flag2 = this.gameAccountId_ == null;
						if (flag2)
						{
							this.GameAccountId = new EntityId();
						}
						input.ReadMessage(this.GameAccountId);
					}
				}
				else
				{
					bool flag3 = this.player_ == null;
					if (flag3)
					{
						this.Player = new BlockedPlayer();
					}
					input.ReadMessage(this.Player);
				}
			}
		}

		// Token: 0x04002BCA RID: 11210
		private static readonly MessageParser<BlockedPlayerAddedNotification> _parser = new MessageParser<BlockedPlayerAddedNotification>(() => new BlockedPlayerAddedNotification());

		// Token: 0x04002BCB RID: 11211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BCC RID: 11212
		public const int PlayerFieldNumber = 1;

		// Token: 0x04002BCD RID: 11213
		private BlockedPlayer player_;

		// Token: 0x04002BCE RID: 11214
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04002BCF RID: 11215
		private EntityId gameAccountId_;

		// Token: 0x04002BD0 RID: 11216
		public const int AccountIdFieldNumber = 3;

		// Token: 0x04002BD1 RID: 11217
		private EntityId accountId_;
	}
}
