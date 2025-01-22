using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000140 RID: 320
	public sealed class PlayerTransferParams : IMessage<PlayerTransferParams>, IMessage, IEquatable<PlayerTransferParams>, IDeepCloneable<PlayerTransferParams>, IBufferMessage
	{
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x000811D0 File Offset: 0x0007F3D0
		[DebuggerNonUserCode]
		public static MessageParser<PlayerTransferParams> Parser
		{
			get
			{
				return PlayerTransferParams._parser;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x000811E8 File Offset: 0x0007F3E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0008120C File Offset: 0x0007F40C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTransferParams.Descriptor;
			}
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00081223 File Offset: 0x0007F423
		[DebuggerNonUserCode]
		public PlayerTransferParams()
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00081230 File Offset: 0x0007F430
		[DebuggerNonUserCode]
		public PlayerTransferParams(PlayerTransferParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.transferFromServerMessageQueue_ = other.transferFromServerMessageQueue_;
			this.transferFromGame_ = other.transferFromGame_;
			this.isDelayedTransfer_ = other.isDelayedTransfer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00081288 File Offset: 0x0007F488
		[DebuggerNonUserCode]
		public PlayerTransferParams Clone()
		{
			return new PlayerTransferParams(this);
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x000812A0 File Offset: 0x0007F4A0
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x000812C1 File Offset: 0x0007F4C1
		[DebuggerNonUserCode]
		public string TransferFromServerMessageQueue
		{
			get
			{
				return this.transferFromServerMessageQueue_ ?? PlayerTransferParams.TransferFromServerMessageQueueDefaultValue;
			}
			set
			{
				this.transferFromServerMessageQueue_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x000812D8 File Offset: 0x0007F4D8
		[DebuggerNonUserCode]
		public bool HasTransferFromServerMessageQueue
		{
			get
			{
				return this.transferFromServerMessageQueue_ != null;
			}
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000812F3 File Offset: 0x0007F4F3
		[DebuggerNonUserCode]
		public void ClearTransferFromServerMessageQueue()
		{
			this.transferFromServerMessageQueue_ = null;
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00081300 File Offset: 0x0007F500
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x00081331 File Offset: 0x0007F531
		[DebuggerNonUserCode]
		public int TransferFromGame
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int transferFromGameDefaultValue;
				if (flag)
				{
					transferFromGameDefaultValue = this.transferFromGame_;
				}
				else
				{
					transferFromGameDefaultValue = PlayerTransferParams.TransferFromGameDefaultValue;
				}
				return transferFromGameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.transferFromGame_ = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x0008134C File Offset: 0x0007F54C
		[DebuggerNonUserCode]
		public bool HasTransferFromGame
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00081369 File Offset: 0x0007F569
		[DebuggerNonUserCode]
		public void ClearTransferFromGame()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x0008137C File Offset: 0x0007F57C
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x000813AD File Offset: 0x0007F5AD
		[DebuggerNonUserCode]
		public bool IsDelayedTransfer
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isDelayedTransferDefaultValue;
				if (flag)
				{
					isDelayedTransferDefaultValue = this.isDelayedTransfer_;
				}
				else
				{
					isDelayedTransferDefaultValue = PlayerTransferParams.IsDelayedTransferDefaultValue;
				}
				return isDelayedTransferDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isDelayedTransfer_ = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000813C8 File Offset: 0x0007F5C8
		[DebuggerNonUserCode]
		public bool HasIsDelayedTransfer
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000813E5 File Offset: 0x0007F5E5
		[DebuggerNonUserCode]
		public void ClearIsDelayedTransfer()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000813F8 File Offset: 0x0007F5F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTransferParams);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00081418 File Offset: 0x0007F618
		[DebuggerNonUserCode]
		public bool Equals(PlayerTransferParams other)
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
					bool flag4 = this.TransferFromServerMessageQueue != other.TransferFromServerMessageQueue;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TransferFromGame != other.TransferFromGame;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsDelayedTransfer != other.IsDelayedTransfer;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000814A4 File Offset: 0x0007F6A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTransferFromServerMessageQueue = this.HasTransferFromServerMessageQueue;
			if (hasTransferFromServerMessageQueue)
			{
				num ^= this.TransferFromServerMessageQueue.GetHashCode();
			}
			bool hasTransferFromGame = this.HasTransferFromGame;
			if (hasTransferFromGame)
			{
				num ^= this.TransferFromGame.GetHashCode();
			}
			bool hasIsDelayedTransfer = this.HasIsDelayedTransfer;
			if (hasIsDelayedTransfer)
			{
				num ^= this.IsDelayedTransfer.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0008152C File Offset: 0x0007F72C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00081544 File Offset: 0x0007F744
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00081550 File Offset: 0x0007F750
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTransferFromServerMessageQueue = this.HasTransferFromServerMessageQueue;
			if (hasTransferFromServerMessageQueue)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TransferFromServerMessageQueue);
			}
			bool hasTransferFromGame = this.HasTransferFromGame;
			if (hasTransferFromGame)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.TransferFromGame);
			}
			bool hasIsDelayedTransfer = this.HasIsDelayedTransfer;
			if (hasIsDelayedTransfer)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsDelayedTransfer);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000815E0 File Offset: 0x0007F7E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTransferFromServerMessageQueue = this.HasTransferFromServerMessageQueue;
			if (hasTransferFromServerMessageQueue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TransferFromServerMessageQueue);
			}
			bool hasTransferFromGame = this.HasTransferFromGame;
			if (hasTransferFromGame)
			{
				num += 5;
			}
			bool hasIsDelayedTransfer = this.HasIsDelayedTransfer;
			if (hasIsDelayedTransfer)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00081654 File Offset: 0x0007F854
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerTransferParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTransferFromServerMessageQueue = other.HasTransferFromServerMessageQueue;
				if (hasTransferFromServerMessageQueue)
				{
					this.TransferFromServerMessageQueue = other.TransferFromServerMessageQueue;
				}
				bool hasTransferFromGame = other.HasTransferFromGame;
				if (hasTransferFromGame)
				{
					this.TransferFromGame = other.TransferFromGame;
				}
				bool hasIsDelayedTransfer = other.HasIsDelayedTransfer;
				if (hasIsDelayedTransfer)
				{
					this.IsDelayedTransfer = other.IsDelayedTransfer;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000816CF File Offset: 0x0007F8CF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000816DC File Offset: 0x0007F8DC
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
					if (num3 != 21U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsDelayedTransfer = input.ReadBool();
						}
					}
					else
					{
						this.TransferFromGame = input.ReadSFixed32();
					}
				}
				else
				{
					this.TransferFromServerMessageQueue = input.ReadString();
				}
			}
		}

		// Token: 0x04000E98 RID: 3736
		private static readonly MessageParser<PlayerTransferParams> _parser = new MessageParser<PlayerTransferParams>(() => new PlayerTransferParams());

		// Token: 0x04000E99 RID: 3737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E9A RID: 3738
		private int _hasBits0;

		// Token: 0x04000E9B RID: 3739
		public const int TransferFromServerMessageQueueFieldNumber = 1;

		// Token: 0x04000E9C RID: 3740
		private static readonly string TransferFromServerMessageQueueDefaultValue = "";

		// Token: 0x04000E9D RID: 3741
		private string transferFromServerMessageQueue_;

		// Token: 0x04000E9E RID: 3742
		public const int TransferFromGameFieldNumber = 2;

		// Token: 0x04000E9F RID: 3743
		private static readonly int TransferFromGameDefaultValue = -1;

		// Token: 0x04000EA0 RID: 3744
		private int transferFromGame_;

		// Token: 0x04000EA1 RID: 3745
		public const int IsDelayedTransferFieldNumber = 3;

		// Token: 0x04000EA2 RID: 3746
		private static readonly bool IsDelayedTransferDefaultValue = false;

		// Token: 0x04000EA3 RID: 3747
		private bool isDelayedTransfer_;
	}
}
