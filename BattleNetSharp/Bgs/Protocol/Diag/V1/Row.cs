using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000426 RID: 1062
	public sealed class Row : IMessage<Row>, IMessage, IEquatable<Row>, IDeepCloneable<Row>, IBufferMessage
	{
		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x060068AF RID: 26799 RVA: 0x00195170 File Offset: 0x00193370
		[DebuggerNonUserCode]
		public static MessageParser<Row> Parser
		{
			get
			{
				return Row._parser;
			}
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x060068B0 RID: 26800 RVA: 0x00195188 File Offset: 0x00193388
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x060068B1 RID: 26801 RVA: 0x001951AC File Offset: 0x001933AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Row.Descriptor;
			}
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x001951C3 File Offset: 0x001933C3
		[DebuggerNonUserCode]
		public Row()
		{
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x001951D8 File Offset: 0x001933D8
		[DebuggerNonUserCode]
		public Row(Row other)
			: this()
		{
			this.values_ = other.values_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x00195204 File Offset: 0x00193404
		[DebuggerNonUserCode]
		public Row Clone()
		{
			return new Row(this);
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x060068B5 RID: 26805 RVA: 0x0019521C File Offset: 0x0019341C
		[DebuggerNonUserCode]
		public RepeatedField<string> Values
		{
			get
			{
				return this.values_;
			}
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00195234 File Offset: 0x00193434
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Row);
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00195254 File Offset: 0x00193454
		[DebuggerNonUserCode]
		public bool Equals(Row other)
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
					bool flag4 = !this.values_.Equals(other.values_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x001952B0 File Offset: 0x001934B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.values_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x001952F0 File Offset: 0x001934F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00195308 File Offset: 0x00193508
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00195314 File Offset: 0x00193514
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.values_.WriteTo(ref output, Row._repeated_values_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00195350 File Offset: 0x00193550
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.values_.CalculateSize(Row._repeated_values_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00195398 File Offset: 0x00193598
		[DebuggerNonUserCode]
		public void MergeFrom(Row other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.values_.Add(other.values_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x001953DA File Offset: 0x001935DA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x001953E8 File Offset: 0x001935E8
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
					this.values_.AddEntriesFrom(ref input, Row._repeated_values_codec);
				}
			}
		}

		// Token: 0x04002FA2 RID: 12194
		private static readonly MessageParser<Row> _parser = new MessageParser<Row>(() => new Row());

		// Token: 0x04002FA3 RID: 12195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FA4 RID: 12196
		public const int ValuesFieldNumber = 1;

		// Token: 0x04002FA5 RID: 12197
		private static readonly FieldCodec<string> _repeated_values_codec = FieldCodec.ForString(10U);

		// Token: 0x04002FA6 RID: 12198
		private readonly RepeatedField<string> values_ = new RepeatedField<string>();
	}
}
