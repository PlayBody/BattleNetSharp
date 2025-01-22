using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003BB RID: 955
	public sealed class BlockedPlayerRemovedNotification : IMessage<BlockedPlayerRemovedNotification>, IMessage, IEquatable<BlockedPlayerRemovedNotification>, IDeepCloneable<BlockedPlayerRemovedNotification>, IBufferMessage
	{
		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x00173BA0 File Offset: 0x00171DA0
		[DebuggerNonUserCode]
		public static MessageParser<BlockedPlayerRemovedNotification> Parser
		{
			get
			{
				return BlockedPlayerRemovedNotification._parser;
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06005FF0 RID: 24560 RVA: 0x00173BB8 File Offset: 0x00171DB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x00173BDC File Offset: 0x00171DDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayerRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x00173BF3 File Offset: 0x00171DF3
		[DebuggerNonUserCode]
		public BlockedPlayerRemovedNotification()
		{
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x00173C00 File Offset: 0x00171E00
		[DebuggerNonUserCode]
		public BlockedPlayerRemovedNotification(BlockedPlayerRemovedNotification other)
			: this()
		{
			this.player_ = ((other.player_ != null) ? other.player_.Clone() : null);
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x00173C7C File Offset: 0x00171E7C
		[DebuggerNonUserCode]
		public BlockedPlayerRemovedNotification Clone()
		{
			return new BlockedPlayerRemovedNotification(this);
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x00173C94 File Offset: 0x00171E94
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x00173CAC File Offset: 0x00171EAC
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

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x00173CB8 File Offset: 0x00171EB8
		// (set) Token: 0x06005FF8 RID: 24568 RVA: 0x00173CD0 File Offset: 0x00171ED0
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

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x00173CDC File Offset: 0x00171EDC
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x00173CF4 File Offset: 0x00171EF4
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

		// Token: 0x06005FFB RID: 24571 RVA: 0x00173D00 File Offset: 0x00171F00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayerRemovedNotification);
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x00173D20 File Offset: 0x00171F20
		[DebuggerNonUserCode]
		public bool Equals(BlockedPlayerRemovedNotification other)
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

		// Token: 0x06005FFD RID: 24573 RVA: 0x00173DB8 File Offset: 0x00171FB8
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

		// Token: 0x06005FFE RID: 24574 RVA: 0x00173E40 File Offset: 0x00172040
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x00173E58 File Offset: 0x00172058
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x00173E64 File Offset: 0x00172064
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

		// Token: 0x06006001 RID: 24577 RVA: 0x00173F00 File Offset: 0x00172100
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

		// Token: 0x06006002 RID: 24578 RVA: 0x00173F94 File Offset: 0x00172194
		[DebuggerNonUserCode]
		public void MergeFrom(BlockedPlayerRemovedNotification other)
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

		// Token: 0x06006003 RID: 24579 RVA: 0x00174081 File Offset: 0x00172281
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006004 RID: 24580 RVA: 0x0017408C File Offset: 0x0017228C
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

		// Token: 0x04002BD2 RID: 11218
		private static readonly MessageParser<BlockedPlayerRemovedNotification> _parser = new MessageParser<BlockedPlayerRemovedNotification>(() => new BlockedPlayerRemovedNotification());

		// Token: 0x04002BD3 RID: 11219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BD4 RID: 11220
		public const int PlayerFieldNumber = 1;

		// Token: 0x04002BD5 RID: 11221
		private BlockedPlayer player_;

		// Token: 0x04002BD6 RID: 11222
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04002BD7 RID: 11223
		private EntityId gameAccountId_;

		// Token: 0x04002BD8 RID: 11224
		public const int AccountIdFieldNumber = 3;

		// Token: 0x04002BD9 RID: 11225
		private EntityId accountId_;
	}
}
