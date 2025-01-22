using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002DA RID: 730
	public sealed class CurrencyAndConsumables : IMessage<CurrencyAndConsumables>, IMessage, IEquatable<CurrencyAndConsumables>, IDeepCloneable<CurrencyAndConsumables>, IBufferMessage
	{
		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06004D32 RID: 19762 RVA: 0x00127590 File Offset: 0x00125790
		[DebuggerNonUserCode]
		public static MessageParser<CurrencyAndConsumables> Parser
		{
			get
			{
				return CurrencyAndConsumables._parser;
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06004D33 RID: 19763 RVA: 0x001275A8 File Offset: 0x001257A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x001275CC File Offset: 0x001257CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CurrencyAndConsumables.Descriptor;
			}
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x001275E3 File Offset: 0x001257E3
		[DebuggerNonUserCode]
		public CurrencyAndConsumables()
		{
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x00127603 File Offset: 0x00125803
		[DebuggerNonUserCode]
		public CurrencyAndConsumables(CurrencyAndConsumables other)
			: this()
		{
			this.virtualCurrencyCredit_ = other.virtualCurrencyCredit_.Clone();
			this.appliedConsumable_ = other.appliedConsumable_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x00127640 File Offset: 0x00125840
		[DebuggerNonUserCode]
		public CurrencyAndConsumables Clone()
		{
			return new CurrencyAndConsumables(this);
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x00127658 File Offset: 0x00125858
		[DebuggerNonUserCode]
		public RepeatedField<VirtualCurrencyCredit> VirtualCurrencyCredit
		{
			get
			{
				return this.virtualCurrencyCredit_;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x00127670 File Offset: 0x00125870
		[DebuggerNonUserCode]
		public RepeatedField<Consumable> AppliedConsumable
		{
			get
			{
				return this.appliedConsumable_;
			}
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x00127688 File Offset: 0x00125888
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CurrencyAndConsumables);
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x001276A8 File Offset: 0x001258A8
		[DebuggerNonUserCode]
		public bool Equals(CurrencyAndConsumables other)
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
					bool flag4 = !this.virtualCurrencyCredit_.Equals(other.virtualCurrencyCredit_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.appliedConsumable_.Equals(other.appliedConsumable_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x00127720 File Offset: 0x00125920
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.virtualCurrencyCredit_.GetHashCode();
			num ^= this.appliedConsumable_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x00127770 File Offset: 0x00125970
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00127788 File Offset: 0x00125988
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00127794 File Offset: 0x00125994
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.virtualCurrencyCredit_.WriteTo(ref output, CurrencyAndConsumables._repeated_virtualCurrencyCredit_codec);
			this.appliedConsumable_.WriteTo(ref output, CurrencyAndConsumables._repeated_appliedConsumable_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x001277E4 File Offset: 0x001259E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.virtualCurrencyCredit_.CalculateSize(CurrencyAndConsumables._repeated_virtualCurrencyCredit_codec);
			num += this.appliedConsumable_.CalculateSize(CurrencyAndConsumables._repeated_appliedConsumable_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x0012783C File Offset: 0x00125A3C
		[DebuggerNonUserCode]
		public void MergeFrom(CurrencyAndConsumables other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.virtualCurrencyCredit_.Add(other.virtualCurrencyCredit_);
				this.appliedConsumable_.Add(other.appliedConsumable_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00127890 File Offset: 0x00125A90
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x0012789C File Offset: 0x00125A9C
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
						this.appliedConsumable_.AddEntriesFrom(ref input, CurrencyAndConsumables._repeated_appliedConsumable_codec);
					}
				}
				else
				{
					this.virtualCurrencyCredit_.AddEntriesFrom(ref input, CurrencyAndConsumables._repeated_virtualCurrencyCredit_codec);
				}
			}
		}

		// Token: 0x0400226A RID: 8810
		private static readonly MessageParser<CurrencyAndConsumables> _parser = new MessageParser<CurrencyAndConsumables>(() => new CurrencyAndConsumables());

		// Token: 0x0400226B RID: 8811
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400226C RID: 8812
		public const int VirtualCurrencyCreditFieldNumber = 1;

		// Token: 0x0400226D RID: 8813
		private static readonly FieldCodec<VirtualCurrencyCredit> _repeated_virtualCurrencyCredit_codec = FieldCodec.ForMessage<VirtualCurrencyCredit>(10U, Fenris.Account.VirtualCurrencyCredit.Parser);

		// Token: 0x0400226E RID: 8814
		private readonly RepeatedField<VirtualCurrencyCredit> virtualCurrencyCredit_ = new RepeatedField<VirtualCurrencyCredit>();

		// Token: 0x0400226F RID: 8815
		public const int AppliedConsumableFieldNumber = 2;

		// Token: 0x04002270 RID: 8816
		private static readonly FieldCodec<Consumable> _repeated_appliedConsumable_codec = FieldCodec.ForMessage<Consumable>(18U, Consumable.Parser);

		// Token: 0x04002271 RID: 8817
		private readonly RepeatedField<Consumable> appliedConsumable_ = new RepeatedField<Consumable>();
	}
}
