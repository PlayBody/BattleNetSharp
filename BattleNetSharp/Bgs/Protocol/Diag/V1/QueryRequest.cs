using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000425 RID: 1061
	public sealed class QueryRequest : IMessage<QueryRequest>, IMessage, IEquatable<QueryRequest>, IDeepCloneable<QueryRequest>, IBufferMessage
	{
		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x00194D64 File Offset: 0x00192F64
		[DebuggerNonUserCode]
		public static MessageParser<QueryRequest> Parser
		{
			get
			{
				return QueryRequest._parser;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600689A RID: 26778 RVA: 0x00194D7C File Offset: 0x00192F7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600689B RID: 26779 RVA: 0x00194DA0 File Offset: 0x00192FA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryRequest.Descriptor;
			}
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x00194DB7 File Offset: 0x00192FB7
		[DebuggerNonUserCode]
		public QueryRequest()
		{
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x00194DCC File Offset: 0x00192FCC
		[DebuggerNonUserCode]
		public QueryRequest(QueryRequest other)
			: this()
		{
			this.name_ = other.name_;
			this.args_ = other.args_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x00194E04 File Offset: 0x00193004
		[DebuggerNonUserCode]
		public QueryRequest Clone()
		{
			return new QueryRequest(this);
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x00194E1C File Offset: 0x0019301C
		// (set) Token: 0x060068A0 RID: 26784 RVA: 0x00194E3D File Offset: 0x0019303D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? QueryRequest.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x00194E54 File Offset: 0x00193054
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x00194E6F File Offset: 0x0019306F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x00194E7C File Offset: 0x0019307C
		[DebuggerNonUserCode]
		public RepeatedField<string> Args
		{
			get
			{
				return this.args_;
			}
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x00194E94 File Offset: 0x00193094
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryRequest);
		}

		// Token: 0x060068A5 RID: 26789 RVA: 0x00194EB4 File Offset: 0x001930B4
		[DebuggerNonUserCode]
		public bool Equals(QueryRequest other)
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
						bool flag5 = !this.args_.Equals(other.args_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060068A6 RID: 26790 RVA: 0x00194F28 File Offset: 0x00193128
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.args_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00194F80 File Offset: 0x00193180
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x00194F98 File Offset: 0x00193198
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x00194FA4 File Offset: 0x001931A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			this.args_.WriteTo(ref output, QueryRequest._repeated_args_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00195004 File Offset: 0x00193204
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.args_.CalculateSize(QueryRequest._repeated_args_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x00195068 File Offset: 0x00193268
		[DebuggerNonUserCode]
		public void MergeFrom(QueryRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this.args_.Add(other.args_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x001950C3 File Offset: 0x001932C3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x001950D0 File Offset: 0x001932D0
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
						this.args_.AddEntriesFrom(ref input, QueryRequest._repeated_args_codec);
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04002F9A RID: 12186
		private static readonly MessageParser<QueryRequest> _parser = new MessageParser<QueryRequest>(() => new QueryRequest());

		// Token: 0x04002F9B RID: 12187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F9C RID: 12188
		public const int NameFieldNumber = 1;

		// Token: 0x04002F9D RID: 12189
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002F9E RID: 12190
		private string name_;

		// Token: 0x04002F9F RID: 12191
		public const int ArgsFieldNumber = 2;

		// Token: 0x04002FA0 RID: 12192
		private static readonly FieldCodec<string> _repeated_args_codec = FieldCodec.ForString(18U);

		// Token: 0x04002FA1 RID: 12193
		private readonly RepeatedField<string> args_ = new RepeatedField<string>();
	}
}
