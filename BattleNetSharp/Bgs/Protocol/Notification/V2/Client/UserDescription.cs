using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005DB RID: 1499
	public sealed class UserDescription : IMessage<UserDescription>, IMessage, IEquatable<UserDescription>, IDeepCloneable<UserDescription>, IBufferMessage
	{
		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x06008D11 RID: 36113 RVA: 0x00223C88 File Offset: 0x00221E88
		[DebuggerNonUserCode]
		public static MessageParser<UserDescription> Parser
		{
			get
			{
				return UserDescription._parser;
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x06008D12 RID: 36114 RVA: 0x00223CA0 File Offset: 0x00221EA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x06008D13 RID: 36115 RVA: 0x00223CC4 File Offset: 0x00221EC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UserDescription.Descriptor;
			}
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x00223CDB File Offset: 0x00221EDB
		[DebuggerNonUserCode]
		public UserDescription()
		{
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x00223CE5 File Offset: 0x00221EE5
		[DebuggerNonUserCode]
		public UserDescription(UserDescription other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D16 RID: 36118 RVA: 0x00223D18 File Offset: 0x00221F18
		[DebuggerNonUserCode]
		public UserDescription Clone()
		{
			return new UserDescription(this);
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x00223D30 File Offset: 0x00221F30
		// (set) Token: 0x06008D18 RID: 36120 RVA: 0x00223D61 File Offset: 0x00221F61
		[DebuggerNonUserCode]
		public ulong AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = UserDescription.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x06008D19 RID: 36121 RVA: 0x00223D7C File Offset: 0x00221F7C
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008D1A RID: 36122 RVA: 0x00223D99 File Offset: 0x00221F99
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008D1B RID: 36123 RVA: 0x00223DAC File Offset: 0x00221FAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UserDescription);
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x00223DCC File Offset: 0x00221FCC
		[DebuggerNonUserCode]
		public bool Equals(UserDescription other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008D1D RID: 36125 RVA: 0x00223E24 File Offset: 0x00222024
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D1E RID: 36126 RVA: 0x00223E74 File Offset: 0x00222074
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x00223E8C File Offset: 0x0022208C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x00223E98 File Offset: 0x00222098
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D21 RID: 36129 RVA: 0x00223EE4 File Offset: 0x002220E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x00223F34 File Offset: 0x00222134
		[DebuggerNonUserCode]
		public void MergeFrom(UserDescription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x00223F7D File Offset: 0x0022217D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D24 RID: 36132 RVA: 0x00223F88 File Offset: 0x00222188
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003FCB RID: 16331
		private static readonly MessageParser<UserDescription> _parser = new MessageParser<UserDescription>(() => new UserDescription());

		// Token: 0x04003FCC RID: 16332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FCD RID: 16333
		private int _hasBits0;

		// Token: 0x04003FCE RID: 16334
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04003FCF RID: 16335
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04003FD0 RID: 16336
		private ulong accountId_;
	}
}
