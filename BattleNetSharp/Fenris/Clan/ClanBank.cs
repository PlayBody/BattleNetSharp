using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B5 RID: 693
	public sealed class ClanBank : IMessage<ClanBank>, IMessage, IEquatable<ClanBank>, IDeepCloneable<ClanBank>, IBufferMessage
	{
		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x0011A860 File Offset: 0x00118A60
		[DebuggerNonUserCode]
		public static MessageParser<ClanBank> Parser
		{
			get
			{
				return ClanBank._parser;
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x0011A878 File Offset: 0x00118A78
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x0011A89C File Offset: 0x00118A9C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanBank.Descriptor;
			}
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x0011A8B3 File Offset: 0x00118AB3
		[DebuggerNonUserCode]
		public ClanBank()
		{
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x0011A8C8 File Offset: 0x00118AC8
		[DebuggerNonUserCode]
		public ClanBank(ClanBank other)
			: this()
		{
			this.bankTabs_ = ((other.bankTabs_ != null) ? other.bankTabs_.Clone() : null);
			this.item_ = other.item_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x0011A91C File Offset: 0x00118B1C
		[DebuggerNonUserCode]
		public ClanBank Clone()
		{
			return new ClanBank(this);
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x060049BC RID: 18876 RVA: 0x0011A934 File Offset: 0x00118B34
		// (set) Token: 0x060049BD RID: 18877 RVA: 0x0011A94C File Offset: 0x00118B4C
		[DebuggerNonUserCode]
		public ClanBankTabs BankTabs
		{
			get
			{
				return this.bankTabs_;
			}
			set
			{
				this.bankTabs_ = value;
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x0011A958 File Offset: 0x00118B58
		[DebuggerNonUserCode]
		public RepeatedField<SavedItem> Item
		{
			get
			{
				return this.item_;
			}
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x0011A970 File Offset: 0x00118B70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanBank);
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x0011A990 File Offset: 0x00118B90
		[DebuggerNonUserCode]
		public bool Equals(ClanBank other)
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
					bool flag4 = !object.Equals(this.BankTabs, other.BankTabs);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.item_.Equals(other.item_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x0011AA08 File Offset: 0x00118C08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.bankTabs_ != null;
			if (flag)
			{
				num ^= this.BankTabs.GetHashCode();
			}
			num ^= this.item_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x0011AA64 File Offset: 0x00118C64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x0011AA7C File Offset: 0x00118C7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x0011AA88 File Offset: 0x00118C88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.bankTabs_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BankTabs);
			}
			this.item_.WriteTo(ref output, ClanBank._repeated_item_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x0011AAEC File Offset: 0x00118CEC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.bankTabs_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BankTabs);
			}
			num += this.item_.CalculateSize(ClanBank._repeated_item_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x0011AB50 File Offset: 0x00118D50
		[DebuggerNonUserCode]
		public void MergeFrom(ClanBank other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.bankTabs_ != null;
				if (flag2)
				{
					bool flag3 = this.bankTabs_ == null;
					if (flag3)
					{
						this.BankTabs = new ClanBankTabs();
					}
					this.BankTabs.MergeFrom(other.BankTabs);
				}
				this.item_.Add(other.item_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x0011ABCE File Offset: 0x00118DCE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x0011ABDC File Offset: 0x00118DDC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.item_.AddEntriesFrom(ref input, ClanBank._repeated_item_codec);
					}
				}
				else
				{
					bool flag = this.bankTabs_ == null;
					if (flag)
					{
						this.BankTabs = new ClanBankTabs();
					}
					input.ReadMessage(this.BankTabs);
				}
			}
		}

		// Token: 0x040020EC RID: 8428
		private static readonly MessageParser<ClanBank> _parser = new MessageParser<ClanBank>(() => new ClanBank());

		// Token: 0x040020ED RID: 8429
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020EE RID: 8430
		public const int BankTabsFieldNumber = 1;

		// Token: 0x040020EF RID: 8431
		private ClanBankTabs bankTabs_;

		// Token: 0x040020F0 RID: 8432
		public const int ItemFieldNumber = 2;

		// Token: 0x040020F1 RID: 8433
		private static readonly FieldCodec<SavedItem> _repeated_item_codec = FieldCodec.ForMessage<SavedItem>(18U, SavedItem.Parser);

		// Token: 0x040020F2 RID: 8434
		private readonly RepeatedField<SavedItem> item_ = new RepeatedField<SavedItem>();
	}
}
