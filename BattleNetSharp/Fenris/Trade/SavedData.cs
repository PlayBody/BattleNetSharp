using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Trade
{
	// Token: 0x0200010C RID: 268
	public sealed class SavedData : IMessage<SavedData>, IMessage, IEquatable<SavedData>, IDeepCloneable<SavedData>, IBufferMessage
	{
		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x0005B70C File Offset: 0x0005990C
		[DebuggerNonUserCode]
		public static MessageParser<SavedData> Parser
		{
			get
			{
				return SavedData._parser;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x0005B724 File Offset: 0x00059924
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TradeReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0005B748 File Offset: 0x00059948
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedData.Descriptor;
			}
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0005B75F File Offset: 0x0005995F
		[DebuggerNonUserCode]
		public SavedData()
		{
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0005B774 File Offset: 0x00059974
		[DebuggerNonUserCode]
		public SavedData(SavedData other)
			: this()
		{
			this.tradeData_ = other.tradeData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0005B7A0 File Offset: 0x000599A0
		[DebuggerNonUserCode]
		public SavedData Clone()
		{
			return new SavedData(this);
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0005B7B8 File Offset: 0x000599B8
		[DebuggerNonUserCode]
		public RepeatedField<TradeData> TradeData
		{
			get
			{
				return this.tradeData_;
			}
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0005B7D0 File Offset: 0x000599D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedData);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0005B7F0 File Offset: 0x000599F0
		[DebuggerNonUserCode]
		public bool Equals(SavedData other)
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
					bool flag4 = !this.tradeData_.Equals(other.tradeData_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0005B84C File Offset: 0x00059A4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tradeData_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0005B88C File Offset: 0x00059A8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0005B8A4 File Offset: 0x00059AA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0005B8B0 File Offset: 0x00059AB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tradeData_.WriteTo(ref output, SavedData._repeated_tradeData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0005B8EC File Offset: 0x00059AEC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tradeData_.CalculateSize(SavedData._repeated_tradeData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0005B934 File Offset: 0x00059B34
		[DebuggerNonUserCode]
		public void MergeFrom(SavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.tradeData_.Add(other.tradeData_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0005B976 File Offset: 0x00059B76
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0005B984 File Offset: 0x00059B84
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
					this.tradeData_.AddEntriesFrom(ref input, SavedData._repeated_tradeData_codec);
				}
			}
		}

		// Token: 0x04000A3D RID: 2621
		private static readonly MessageParser<SavedData> _parser = new MessageParser<SavedData>(() => new SavedData());

		// Token: 0x04000A3E RID: 2622
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A3F RID: 2623
		public const int TradeDataFieldNumber = 1;

		// Token: 0x04000A40 RID: 2624
		private static readonly FieldCodec<TradeData> _repeated_tradeData_codec = FieldCodec.ForMessage<TradeData>(10U, Fenris.Trade.TradeData.Parser);

		// Token: 0x04000A41 RID: 2625
		private readonly RepeatedField<TradeData> tradeData_ = new RepeatedField<TradeData>();
	}
}
