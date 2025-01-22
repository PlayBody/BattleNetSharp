using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.AttributeSerializer
{
	// Token: 0x020002C0 RID: 704
	public sealed class SavedAttribute : IMessage<SavedAttribute>, IMessage, IEquatable<SavedAttribute>, IDeepCloneable<SavedAttribute>, IBufferMessage
	{
		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004AE9 RID: 19177 RVA: 0x0011EEF8 File Offset: 0x0011D0F8
		[DebuggerNonUserCode]
		public static MessageParser<SavedAttribute> Parser
		{
			get
			{
				return SavedAttribute._parser;
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004AEA RID: 19178 RVA: 0x0011EF10 File Offset: 0x0011D110
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeSerializerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06004AEB RID: 19179 RVA: 0x0011EF34 File Offset: 0x0011D134
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedAttribute.Descriptor;
			}
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x0011EF4B File Offset: 0x0011D14B
		[DebuggerNonUserCode]
		public SavedAttribute()
		{
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x0011EF55 File Offset: 0x0011D155
		[DebuggerNonUserCode]
		public SavedAttribute(SavedAttribute other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key_ = other.key_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x0011EF94 File Offset: 0x0011D194
		[DebuggerNonUserCode]
		public SavedAttribute Clone()
		{
			return new SavedAttribute(this);
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06004AEF RID: 19183 RVA: 0x0011EFAC File Offset: 0x0011D1AC
		// (set) Token: 0x06004AF0 RID: 19184 RVA: 0x0011EFDD File Offset: 0x0011D1DD
		[DebuggerNonUserCode]
		public long Key
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long keyDefaultValue;
				if (flag)
				{
					keyDefaultValue = this.key_;
				}
				else
				{
					keyDefaultValue = SavedAttribute.KeyDefaultValue;
				}
				return keyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.key_ = value;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x0011EFF8 File Offset: 0x0011D1F8
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0011F015 File Offset: 0x0011D215
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x0011F028 File Offset: 0x0011D228
		// (set) Token: 0x06004AF4 RID: 19188 RVA: 0x0011F059 File Offset: 0x0011D259
		[DebuggerNonUserCode]
		public int Value
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int valueDefaultValue;
				if (flag)
				{
					valueDefaultValue = this.value_;
				}
				else
				{
					valueDefaultValue = SavedAttribute.ValueDefaultValue;
				}
				return valueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.value_ = value;
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x0011F074 File Offset: 0x0011D274
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x0011F091 File Offset: 0x0011D291
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0011F0A4 File Offset: 0x0011D2A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedAttribute);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x0011F0C4 File Offset: 0x0011D2C4
		[DebuggerNonUserCode]
		public bool Equals(SavedAttribute other)
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
					bool flag4 = this.Key != other.Key;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Value != other.Value;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x0011F138 File Offset: 0x0011D338
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x0011F1A8 File Offset: 0x0011D3A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x0011F1C0 File Offset: 0x0011D3C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x0011F1CC File Offset: 0x0011D3CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(8);
				output.WriteSInt64(this.Key);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x0011F23C File Offset: 0x0011D43C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeSInt64Size(this.Key);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x0011F2A8 File Offset: 0x0011D4A8
		[DebuggerNonUserCode]
		public void MergeFrom(SavedAttribute other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x0011F30A File Offset: 0x0011D50A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x0011F318 File Offset: 0x0011D518
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadSInt32();
					}
				}
				else
				{
					this.Key = input.ReadSInt64();
				}
			}
		}

		// Token: 0x04002177 RID: 8567
		private static readonly MessageParser<SavedAttribute> _parser = new MessageParser<SavedAttribute>(() => new SavedAttribute());

		// Token: 0x04002178 RID: 8568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002179 RID: 8569
		private int _hasBits0;

		// Token: 0x0400217A RID: 8570
		public const int KeyFieldNumber = 1;

		// Token: 0x0400217B RID: 8571
		private static readonly long KeyDefaultValue = 0L;

		// Token: 0x0400217C RID: 8572
		private long key_;

		// Token: 0x0400217D RID: 8573
		public const int ValueFieldNumber = 2;

		// Token: 0x0400217E RID: 8574
		private static readonly int ValueDefaultValue = 0;

		// Token: 0x0400217F RID: 8575
		private int value_;
	}
}
