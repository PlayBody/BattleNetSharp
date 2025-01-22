using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000149 RID: 329
	public sealed class ConsolePresence : IMessage<ConsolePresence>, IMessage, IEquatable<ConsolePresence>, IDeepCloneable<ConsolePresence>, IBufferMessage
	{
		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x00084E00 File Offset: 0x00083000
		[DebuggerNonUserCode]
		public static MessageParser<ConsolePresence> Parser
		{
			get
			{
				return ConsolePresence._parser;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x00084E18 File Offset: 0x00083018
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00084E3C File Offset: 0x0008303C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsolePresence.Descriptor;
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00084E53 File Offset: 0x00083053
		[DebuggerNonUserCode]
		public ConsolePresence()
		{
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00084E5D File Offset: 0x0008305D
		[DebuggerNonUserCode]
		public ConsolePresence(ConsolePresence other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00084E9C File Offset: 0x0008309C
		[DebuggerNonUserCode]
		public ConsolePresence Clone()
		{
			return new ConsolePresence(this);
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x00084EB4 File Offset: 0x000830B4
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x00084EE5 File Offset: 0x000830E5
		[DebuggerNonUserCode]
		public uint AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = ConsolePresence.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00084F00 File Offset: 0x00083100
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00084F1D File Offset: 0x0008311D
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x00084F30 File Offset: 0x00083130
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x00084F61 File Offset: 0x00083161
		[DebuggerNonUserCode]
		public ulong GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = ConsolePresence.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00084F7C File Offset: 0x0008317C
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00084F99 File Offset: 0x00083199
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00084FAC File Offset: 0x000831AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsolePresence);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x00084FCC File Offset: 0x000831CC
		[DebuggerNonUserCode]
		public bool Equals(ConsolePresence other)
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
					bool flag4 = this.AccountId != other.AccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountId != other.GameAccountId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00085040 File Offset: 0x00083240
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000850B0 File Offset: 0x000832B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000850C8 File Offset: 0x000832C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x000850D4 File Offset: 0x000832D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00085144 File Offset: 0x00083344
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000851B0 File Offset: 0x000833B0
		[DebuggerNonUserCode]
		public void MergeFrom(ConsolePresence other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00085212 File Offset: 0x00083412
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00085220 File Offset: 0x00083420
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GameAccountId = input.ReadUInt64();
					}
				}
				else
				{
					this.AccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F12 RID: 3858
		private static readonly MessageParser<ConsolePresence> _parser = new MessageParser<ConsolePresence>(() => new ConsolePresence());

		// Token: 0x04000F13 RID: 3859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F14 RID: 3860
		private int _hasBits0;

		// Token: 0x04000F15 RID: 3861
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04000F16 RID: 3862
		private static readonly uint AccountIdDefaultValue = 0U;

		// Token: 0x04000F17 RID: 3863
		private uint accountId_;

		// Token: 0x04000F18 RID: 3864
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04000F19 RID: 3865
		private static readonly ulong GameAccountIdDefaultValue = 0UL;

		// Token: 0x04000F1A RID: 3866
		private ulong gameAccountId_;
	}
}
