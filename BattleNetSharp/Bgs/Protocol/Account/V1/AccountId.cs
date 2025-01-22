using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000730 RID: 1840
	public sealed class AccountId : IMessage<AccountId>, IMessage, IEquatable<AccountId>, IDeepCloneable<AccountId>, IBufferMessage
	{
		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600A839 RID: 43065 RVA: 0x0028FF30 File Offset: 0x0028E130
		[DebuggerNonUserCode]
		public static MessageParser<AccountId> Parser
		{
			get
			{
				return AccountId._parser;
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600A83A RID: 43066 RVA: 0x0028FF48 File Offset: 0x0028E148
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600A83B RID: 43067 RVA: 0x0028FF6C File Offset: 0x0028E16C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountId.Descriptor;
			}
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x0028FF83 File Offset: 0x0028E183
		[DebuggerNonUserCode]
		public AccountId()
		{
		}

		// Token: 0x0600A83D RID: 43069 RVA: 0x0028FF8D File Offset: 0x0028E18D
		[DebuggerNonUserCode]
		public AccountId(AccountId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A83E RID: 43070 RVA: 0x0028FFC0 File Offset: 0x0028E1C0
		[DebuggerNonUserCode]
		public AccountId Clone()
		{
			return new AccountId(this);
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600A83F RID: 43071 RVA: 0x0028FFD8 File Offset: 0x0028E1D8
		// (set) Token: 0x0600A840 RID: 43072 RVA: 0x00290009 File Offset: 0x0028E209
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = AccountId.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x00290024 File Offset: 0x0028E224
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A842 RID: 43074 RVA: 0x00290041 File Offset: 0x0028E241
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x00290054 File Offset: 0x0028E254
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountId);
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x00290074 File Offset: 0x0028E274
		[DebuggerNonUserCode]
		public bool Equals(AccountId other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A845 RID: 43077 RVA: 0x002900CC File Offset: 0x0028E2CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A846 RID: 43078 RVA: 0x0029011C File Offset: 0x0028E31C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x00290134 File Offset: 0x0028E334
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A848 RID: 43080 RVA: 0x00290140 File Offset: 0x0028E340
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A849 RID: 43081 RVA: 0x0029018C File Offset: 0x0028E38C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A84A RID: 43082 RVA: 0x002901D0 File Offset: 0x0028E3D0
		[DebuggerNonUserCode]
		public void MergeFrom(AccountId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A84B RID: 43083 RVA: 0x00290219 File Offset: 0x0028E419
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x00290224 File Offset: 0x0028E424
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04004BA1 RID: 19361
		private static readonly MessageParser<AccountId> _parser = new MessageParser<AccountId>(() => new AccountId());

		// Token: 0x04004BA2 RID: 19362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BA3 RID: 19363
		private int _hasBits0;

		// Token: 0x04004BA4 RID: 19364
		public const int IdFieldNumber = 1;

		// Token: 0x04004BA5 RID: 19365
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04004BA6 RID: 19366
		private uint id_;
	}
}
