using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005AF RID: 1455
	public sealed class FieldOperation : IMessage<FieldOperation>, IMessage, IEquatable<FieldOperation>, IDeepCloneable<FieldOperation>, IBufferMessage
	{
		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x002197C4 File Offset: 0x002179C4
		[DebuggerNonUserCode]
		public static MessageParser<FieldOperation> Parser
		{
			get
			{
				return FieldOperation._parser;
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06008A54 RID: 35412 RVA: 0x002197DC File Offset: 0x002179DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x06008A55 RID: 35413 RVA: 0x00219800 File Offset: 0x00217A00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldOperation.Descriptor;
			}
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x00219817 File Offset: 0x00217A17
		[DebuggerNonUserCode]
		public FieldOperation()
		{
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x00219824 File Offset: 0x00217A24
		[DebuggerNonUserCode]
		public FieldOperation(FieldOperation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.field_ = ((other.field_ != null) ? other.field_.Clone() : null);
			this.operation_ = other.operation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x00219880 File Offset: 0x00217A80
		[DebuggerNonUserCode]
		public FieldOperation Clone()
		{
			return new FieldOperation(this);
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06008A59 RID: 35417 RVA: 0x00219898 File Offset: 0x00217A98
		// (set) Token: 0x06008A5A RID: 35418 RVA: 0x002198B0 File Offset: 0x00217AB0
		[DebuggerNonUserCode]
		public Field Field
		{
			get
			{
				return this.field_;
			}
			set
			{
				this.field_ = value;
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06008A5B RID: 35419 RVA: 0x002198BC File Offset: 0x00217ABC
		// (set) Token: 0x06008A5C RID: 35420 RVA: 0x002198ED File Offset: 0x00217AED
		[DebuggerNonUserCode]
		public FieldOperation.Types.OperationType Operation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				FieldOperation.Types.OperationType operationDefaultValue;
				if (flag)
				{
					operationDefaultValue = this.operation_;
				}
				else
				{
					operationDefaultValue = FieldOperation.OperationDefaultValue;
				}
				return operationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.operation_ = value;
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x00219908 File Offset: 0x00217B08
		[DebuggerNonUserCode]
		public bool HasOperation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008A5E RID: 35422 RVA: 0x00219925 File Offset: 0x00217B25
		[DebuggerNonUserCode]
		public void ClearOperation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x00219938 File Offset: 0x00217B38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldOperation);
		}

		// Token: 0x06008A60 RID: 35424 RVA: 0x00219958 File Offset: 0x00217B58
		[DebuggerNonUserCode]
		public bool Equals(FieldOperation other)
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
					bool flag4 = !object.Equals(this.Field, other.Field);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Operation != other.Operation;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x002199CC File Offset: 0x00217BCC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.field_ != null;
			if (flag)
			{
				num ^= this.Field.GetHashCode();
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num ^= this.Operation.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x00219A40 File Offset: 0x00217C40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x00219A58 File Offset: 0x00217C58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x00219A64 File Offset: 0x00217C64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.field_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Field);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Operation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x00219AD8 File Offset: 0x00217CD8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.field_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Field);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Operation);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x00219B48 File Offset: 0x00217D48
		[DebuggerNonUserCode]
		public void MergeFrom(FieldOperation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.field_ != null;
				if (flag2)
				{
					bool flag3 = this.field_ == null;
					if (flag3)
					{
						this.Field = new Field();
					}
					this.Field.MergeFrom(other.Field);
				}
				bool hasOperation = other.HasOperation;
				if (hasOperation)
				{
					this.Operation = other.Operation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x00219BCD File Offset: 0x00217DCD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A68 RID: 35432 RVA: 0x00219BD8 File Offset: 0x00217DD8
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Operation = (FieldOperation.Types.OperationType)input.ReadEnum();
					}
				}
				else
				{
					bool flag = this.field_ == null;
					if (flag)
					{
						this.Field = new Field();
					}
					input.ReadMessage(this.Field);
				}
			}
		}

		// Token: 0x04003EA0 RID: 16032
		private static readonly MessageParser<FieldOperation> _parser = new MessageParser<FieldOperation>(() => new FieldOperation());

		// Token: 0x04003EA1 RID: 16033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EA2 RID: 16034
		private int _hasBits0;

		// Token: 0x04003EA3 RID: 16035
		public const int FieldFieldNumber = 1;

		// Token: 0x04003EA4 RID: 16036
		private Field field_;

		// Token: 0x04003EA5 RID: 16037
		public const int OperationFieldNumber = 2;

		// Token: 0x04003EA6 RID: 16038
		private static readonly FieldOperation.Types.OperationType OperationDefaultValue = FieldOperation.Types.OperationType.Set;

		// Token: 0x04003EA7 RID: 16039
		private FieldOperation.Types.OperationType operation_;

		// Token: 0x0200108C RID: 4236
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001497 RID: 5271
			public enum OperationType
			{
				// Token: 0x0400A4FA RID: 42234
				[OriginalName("SET")]
				Set,
				// Token: 0x0400A4FB RID: 42235
				[OriginalName("CLEAR")]
				Clear
			}
		}
	}
}
