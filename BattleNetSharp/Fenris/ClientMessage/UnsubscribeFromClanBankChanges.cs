using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200027A RID: 634
	public sealed class UnsubscribeFromClanBankChanges : IMessage<UnsubscribeFromClanBankChanges>, IMessage, IEquatable<UnsubscribeFromClanBankChanges>, IDeepCloneable<UnsubscribeFromClanBankChanges>, IBufferMessage
	{
		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x00105C4C File Offset: 0x00103E4C
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeFromClanBankChanges> Parser
		{
			get
			{
				return UnsubscribeFromClanBankChanges._parser;
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x00105C64 File Offset: 0x00103E64
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[106];
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x00105C88 File Offset: 0x00103E88
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeFromClanBankChanges.Descriptor;
			}
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00105C9F File Offset: 0x00103E9F
		[DebuggerNonUserCode]
		public UnsubscribeFromClanBankChanges()
		{
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00105CA9 File Offset: 0x00103EA9
		[DebuggerNonUserCode]
		public UnsubscribeFromClanBankChanges(UnsubscribeFromClanBankChanges other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00105CD0 File Offset: 0x00103ED0
		[DebuggerNonUserCode]
		public UnsubscribeFromClanBankChanges Clone()
		{
			return new UnsubscribeFromClanBankChanges(this);
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x00105CE8 File Offset: 0x00103EE8
		// (set) Token: 0x060043C3 RID: 17347 RVA: 0x00105D09 File Offset: 0x00103F09
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? UnsubscribeFromClanBankChanges.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x00105D20 File Offset: 0x00103F20
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00105D3B File Offset: 0x00103F3B
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00105D48 File Offset: 0x00103F48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeFromClanBankChanges);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00105D68 File Offset: 0x00103F68
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeFromClanBankChanges other)
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
					bool flag4 = this.ClanId != other.ClanId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00105DC0 File Offset: 0x00103FC0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00105E0C File Offset: 0x0010400C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00105E24 File Offset: 0x00104024
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00105E30 File Offset: 0x00104030
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00105E7C File Offset: 0x0010407C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00105ECC File Offset: 0x001040CC
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeFromClanBankChanges other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x00105F15 File Offset: 0x00104115
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00105F20 File Offset: 0x00104120
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E72 RID: 7794
		private static readonly MessageParser<UnsubscribeFromClanBankChanges> _parser = new MessageParser<UnsubscribeFromClanBankChanges>(() => new UnsubscribeFromClanBankChanges());

		// Token: 0x04001E73 RID: 7795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E74 RID: 7796
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E75 RID: 7797
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E76 RID: 7798
		private string clanId_;
	}
}
