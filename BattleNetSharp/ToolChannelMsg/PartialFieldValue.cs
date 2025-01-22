using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000030 RID: 48
	public sealed class PartialFieldValue : IMessage<PartialFieldValue>, IMessage, IEquatable<PartialFieldValue>, IDeepCloneable<PartialFieldValue>, IBufferMessage
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0001176C File Offset: 0x0000F96C
		[DebuggerNonUserCode]
		public static MessageParser<PartialFieldValue> Parser
		{
			get
			{
				return PartialFieldValue._parser;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00011784 File Offset: 0x0000F984
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartialFieldValue.Descriptor;
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000117BF File Offset: 0x0000F9BF
		[DebuggerNonUserCode]
		public PartialFieldValue()
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000117C9 File Offset: 0x0000F9C9
		[DebuggerNonUserCode]
		public PartialFieldValue(PartialFieldValue other)
			: this()
		{
			this.fieldPath_ = other.fieldPath_;
			this.binaryValue_ = other.binaryValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000117FC File Offset: 0x0000F9FC
		[DebuggerNonUserCode]
		public PartialFieldValue Clone()
		{
			return new PartialFieldValue(this);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00011814 File Offset: 0x0000FA14
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00011835 File Offset: 0x0000FA35
		[DebuggerNonUserCode]
		public string FieldPath
		{
			get
			{
				return this.fieldPath_ ?? PartialFieldValue.FieldPathDefaultValue;
			}
			set
			{
				this.fieldPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0001184C File Offset: 0x0000FA4C
		[DebuggerNonUserCode]
		public bool HasFieldPath
		{
			get
			{
				return this.fieldPath_ != null;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00011867 File Offset: 0x0000FA67
		[DebuggerNonUserCode]
		public void ClearFieldPath()
		{
			this.fieldPath_ = null;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00011874 File Offset: 0x0000FA74
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00011895 File Offset: 0x0000FA95
		[DebuggerNonUserCode]
		public ByteString BinaryValue
		{
			get
			{
				return this.binaryValue_ ?? PartialFieldValue.BinaryValueDefaultValue;
			}
			set
			{
				this.binaryValue_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000335 RID: 821 RVA: 0x000118AC File Offset: 0x0000FAAC
		[DebuggerNonUserCode]
		public bool HasBinaryValue
		{
			get
			{
				return this.binaryValue_ != null;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000118CA File Offset: 0x0000FACA
		[DebuggerNonUserCode]
		public void ClearBinaryValue()
		{
			this.binaryValue_ = null;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000118D4 File Offset: 0x0000FAD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartialFieldValue);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000118F4 File Offset: 0x0000FAF4
		[DebuggerNonUserCode]
		public bool Equals(PartialFieldValue other)
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
					bool flag4 = this.FieldPath != other.FieldPath;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BinaryValue != other.BinaryValue;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00011968 File Offset: 0x0000FB68
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFieldPath = this.HasFieldPath;
			if (hasFieldPath)
			{
				num ^= this.FieldPath.GetHashCode();
			}
			bool hasBinaryValue = this.HasBinaryValue;
			if (hasBinaryValue)
			{
				num ^= this.BinaryValue.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000119CC File Offset: 0x0000FBCC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000119E4 File Offset: 0x0000FBE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000119F0 File Offset: 0x0000FBF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFieldPath = this.HasFieldPath;
			if (hasFieldPath)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FieldPath);
			}
			bool hasBinaryValue = this.HasBinaryValue;
			if (hasBinaryValue)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.BinaryValue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00011A60 File Offset: 0x0000FC60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFieldPath = this.HasFieldPath;
			if (hasFieldPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FieldPath);
			}
			bool hasBinaryValue = this.HasBinaryValue;
			if (hasBinaryValue)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.BinaryValue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00011ACC File Offset: 0x0000FCCC
		[DebuggerNonUserCode]
		public void MergeFrom(PartialFieldValue other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFieldPath = other.HasFieldPath;
				if (hasFieldPath)
				{
					this.FieldPath = other.FieldPath;
				}
				bool hasBinaryValue = other.HasBinaryValue;
				if (hasBinaryValue)
				{
					this.BinaryValue = other.BinaryValue;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00011B2E File Offset: 0x0000FD2E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00011B3C File Offset: 0x0000FD3C
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
						this.BinaryValue = input.ReadBytes();
					}
				}
				else
				{
					this.FieldPath = input.ReadString();
				}
			}
		}

		// Token: 0x0400014F RID: 335
		private static readonly MessageParser<PartialFieldValue> _parser = new MessageParser<PartialFieldValue>(() => new PartialFieldValue());

		// Token: 0x04000150 RID: 336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000151 RID: 337
		public const int FieldPathFieldNumber = 1;

		// Token: 0x04000152 RID: 338
		private static readonly string FieldPathDefaultValue = "";

		// Token: 0x04000153 RID: 339
		private string fieldPath_;

		// Token: 0x04000154 RID: 340
		public const int BinaryValueFieldNumber = 2;

		// Token: 0x04000155 RID: 341
		private static readonly ByteString BinaryValueDefaultValue = ByteString.Empty;

		// Token: 0x04000156 RID: 342
		private ByteString binaryValue_;
	}
}
