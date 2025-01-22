using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200019B RID: 411
	public sealed class VisualEquipment : IMessage<VisualEquipment>, IMessage, IEquatable<VisualEquipment>, IDeepCloneable<VisualEquipment>, IBufferMessage
	{
		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x000AB4C0 File Offset: 0x000A96C0
		[DebuggerNonUserCode]
		public static MessageParser<VisualEquipment> Parser
		{
			get
			{
				return VisualEquipment._parser;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000AB4D8 File Offset: 0x000A96D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000AB4FC File Offset: 0x000A96FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisualEquipment.Descriptor;
			}
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000AB513 File Offset: 0x000A9713
		[DebuggerNonUserCode]
		public VisualEquipment()
		{
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000AB528 File Offset: 0x000A9728
		[DebuggerNonUserCode]
		public VisualEquipment(VisualEquipment other)
			: this()
		{
			this.visualItem_ = other.visualItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000AB554 File Offset: 0x000A9754
		[DebuggerNonUserCode]
		public VisualEquipment Clone()
		{
			return new VisualEquipment(this);
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000AB56C File Offset: 0x000A976C
		[DebuggerNonUserCode]
		public RepeatedField<VisualItem> VisualItem
		{
			get
			{
				return this.visualItem_;
			}
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000AB584 File Offset: 0x000A9784
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisualEquipment);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000AB5A4 File Offset: 0x000A97A4
		[DebuggerNonUserCode]
		public bool Equals(VisualEquipment other)
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
					bool flag4 = !this.visualItem_.Equals(other.visualItem_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000AB600 File Offset: 0x000A9800
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.visualItem_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000AB640 File Offset: 0x000A9840
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000AB658 File Offset: 0x000A9858
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000AB664 File Offset: 0x000A9864
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.visualItem_.WriteTo(ref output, VisualEquipment._repeated_visualItem_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000AB6A0 File Offset: 0x000A98A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.visualItem_.CalculateSize(VisualEquipment._repeated_visualItem_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000AB6E8 File Offset: 0x000A98E8
		[DebuggerNonUserCode]
		public void MergeFrom(VisualEquipment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.visualItem_.Add(other.visualItem_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000AB72A File Offset: 0x000A992A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000AB738 File Offset: 0x000A9938
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
					this.visualItem_.AddEntriesFrom(ref input, VisualEquipment._repeated_visualItem_codec);
				}
			}
		}

		// Token: 0x040013AB RID: 5035
		private static readonly MessageParser<VisualEquipment> _parser = new MessageParser<VisualEquipment>(() => new VisualEquipment());

		// Token: 0x040013AC RID: 5036
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013AD RID: 5037
		public const int VisualItemFieldNumber = 1;

		// Token: 0x040013AE RID: 5038
		private static readonly FieldCodec<VisualItem> _repeated_visualItem_codec = FieldCodec.ForMessage<VisualItem>(10U, Fenris.Hero.VisualItem.Parser);

		// Token: 0x040013AF RID: 5039
		private readonly RepeatedField<VisualItem> visualItem_ = new RepeatedField<VisualItem>();
	}
}
