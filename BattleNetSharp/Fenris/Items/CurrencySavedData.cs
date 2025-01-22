using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200016E RID: 366
	public sealed class CurrencySavedData : IMessage<CurrencySavedData>, IMessage, IEquatable<CurrencySavedData>, IDeepCloneable<CurrencySavedData>, IBufferMessage
	{
		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x00094680 File Offset: 0x00092880
		[DebuggerNonUserCode]
		public static MessageParser<CurrencySavedData> Parser
		{
			get
			{
				return CurrencySavedData._parser;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x00094698 File Offset: 0x00092898
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x000946BC File Offset: 0x000928BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CurrencySavedData.Descriptor;
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000946D3 File Offset: 0x000928D3
		[DebuggerNonUserCode]
		public CurrencySavedData()
		{
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000946E8 File Offset: 0x000928E8
		[DebuggerNonUserCode]
		public CurrencySavedData(CurrencySavedData other)
			: this()
		{
			this.currency_ = other.currency_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00094714 File Offset: 0x00092914
		[DebuggerNonUserCode]
		public CurrencySavedData Clone()
		{
			return new CurrencySavedData(this);
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x0009472C File Offset: 0x0009292C
		[DebuggerNonUserCode]
		public RepeatedField<CurrencyData> Currency
		{
			get
			{
				return this.currency_;
			}
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00094744 File Offset: 0x00092944
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CurrencySavedData);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00094764 File Offset: 0x00092964
		[DebuggerNonUserCode]
		public bool Equals(CurrencySavedData other)
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
					bool flag4 = !this.currency_.Equals(other.currency_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000947C0 File Offset: 0x000929C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.currency_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00094800 File Offset: 0x00092A00
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00094818 File Offset: 0x00092A18
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00094824 File Offset: 0x00092A24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.currency_.WriteTo(ref output, CurrencySavedData._repeated_currency_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00094860 File Offset: 0x00092A60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.currency_.CalculateSize(CurrencySavedData._repeated_currency_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000948A8 File Offset: 0x00092AA8
		[DebuggerNonUserCode]
		public void MergeFrom(CurrencySavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.currency_.Add(other.currency_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000948EA File Offset: 0x00092AEA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000948F8 File Offset: 0x00092AF8
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
					this.currency_.AddEntriesFrom(ref input, CurrencySavedData._repeated_currency_codec);
				}
			}
		}

		// Token: 0x040010E2 RID: 4322
		private static readonly MessageParser<CurrencySavedData> _parser = new MessageParser<CurrencySavedData>(() => new CurrencySavedData());

		// Token: 0x040010E3 RID: 4323
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010E4 RID: 4324
		public const int CurrencyFieldNumber = 1;

		// Token: 0x040010E5 RID: 4325
		private static readonly FieldCodec<CurrencyData> _repeated_currency_codec = FieldCodec.ForMessage<CurrencyData>(10U, CurrencyData.Parser);

		// Token: 0x040010E6 RID: 4326
		private readonly RepeatedField<CurrencyData> currency_ = new RepeatedField<CurrencyData>();
	}
}
