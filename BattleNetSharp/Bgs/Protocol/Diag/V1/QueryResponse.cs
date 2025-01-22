using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000427 RID: 1063
	public sealed class QueryResponse : IMessage<QueryResponse>, IMessage, IEquatable<QueryResponse>, IDeepCloneable<QueryResponse>, IBufferMessage
	{
		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x060068C1 RID: 26817 RVA: 0x00195468 File Offset: 0x00193668
		[DebuggerNonUserCode]
		public static MessageParser<QueryResponse> Parser
		{
			get
			{
				return QueryResponse._parser;
			}
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x060068C2 RID: 26818 RVA: 0x00195480 File Offset: 0x00193680
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x060068C3 RID: 26819 RVA: 0x001954A4 File Offset: 0x001936A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryResponse.Descriptor;
			}
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x001954BB File Offset: 0x001936BB
		[DebuggerNonUserCode]
		public QueryResponse()
		{
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x001954DC File Offset: 0x001936DC
		[DebuggerNonUserCode]
		public QueryResponse(QueryResponse other)
			: this()
		{
			this.name_ = other.name_;
			this.columns_ = other.columns_.Clone();
			this.rows_ = other.rows_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00195530 File Offset: 0x00193730
		[DebuggerNonUserCode]
		public QueryResponse Clone()
		{
			return new QueryResponse(this);
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x00195548 File Offset: 0x00193748
		// (set) Token: 0x060068C8 RID: 26824 RVA: 0x00195569 File Offset: 0x00193769
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? QueryResponse.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x060068C9 RID: 26825 RVA: 0x00195580 File Offset: 0x00193780
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x0019559B File Offset: 0x0019379B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x060068CB RID: 26827 RVA: 0x001955A8 File Offset: 0x001937A8
		[DebuggerNonUserCode]
		public RepeatedField<string> Columns
		{
			get
			{
				return this.columns_;
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x001955C0 File Offset: 0x001937C0
		[DebuggerNonUserCode]
		public RepeatedField<Row> Rows
		{
			get
			{
				return this.rows_;
			}
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x001955D8 File Offset: 0x001937D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryResponse);
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x001955F8 File Offset: 0x001937F8
		[DebuggerNonUserCode]
		public bool Equals(QueryResponse other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.columns_.Equals(other.columns_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.rows_.Equals(other.rows_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x0019568C File Offset: 0x0019388C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.columns_.GetHashCode();
			num ^= this.rows_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x001956F4 File Offset: 0x001938F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x0019570C File Offset: 0x0019390C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x00195718 File Offset: 0x00193918
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			this.columns_.WriteTo(ref output, QueryResponse._repeated_columns_codec);
			this.rows_.WriteTo(ref output, QueryResponse._repeated_rows_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00195788 File Offset: 0x00193988
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.columns_.CalculateSize(QueryResponse._repeated_columns_codec);
			num += this.rows_.CalculateSize(QueryResponse._repeated_rows_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x001957FC File Offset: 0x001939FC
		[DebuggerNonUserCode]
		public void MergeFrom(QueryResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this.columns_.Add(other.columns_);
				this.rows_.Add(other.rows_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00195869 File Offset: 0x00193A69
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00195874 File Offset: 0x00193A74
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.rows_.AddEntriesFrom(ref input, QueryResponse._repeated_rows_codec);
						}
					}
					else
					{
						this.columns_.AddEntriesFrom(ref input, QueryResponse._repeated_columns_codec);
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04002FA7 RID: 12199
		private static readonly MessageParser<QueryResponse> _parser = new MessageParser<QueryResponse>(() => new QueryResponse());

		// Token: 0x04002FA8 RID: 12200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FA9 RID: 12201
		public const int NameFieldNumber = 1;

		// Token: 0x04002FAA RID: 12202
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002FAB RID: 12203
		private string name_;

		// Token: 0x04002FAC RID: 12204
		public const int ColumnsFieldNumber = 2;

		// Token: 0x04002FAD RID: 12205
		private static readonly FieldCodec<string> _repeated_columns_codec = FieldCodec.ForString(18U);

		// Token: 0x04002FAE RID: 12206
		private readonly RepeatedField<string> columns_ = new RepeatedField<string>();

		// Token: 0x04002FAF RID: 12207
		public const int RowsFieldNumber = 3;

		// Token: 0x04002FB0 RID: 12208
		private static readonly FieldCodec<Row> _repeated_rows_codec = FieldCodec.ForMessage<Row>(26U, Row.Parser);

		// Token: 0x04002FB1 RID: 12209
		private readonly RepeatedField<Row> rows_ = new RepeatedField<Row>();
	}
}
