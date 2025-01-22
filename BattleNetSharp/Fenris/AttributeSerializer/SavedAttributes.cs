using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.AttributeSerializer
{
	// Token: 0x020002C1 RID: 705
	public sealed class SavedAttributes : IMessage<SavedAttributes>, IMessage, IEquatable<SavedAttributes>, IDeepCloneable<SavedAttributes>, IBufferMessage
	{
		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x0011F3A8 File Offset: 0x0011D5A8
		[DebuggerNonUserCode]
		public static MessageParser<SavedAttributes> Parser
		{
			get
			{
				return SavedAttributes._parser;
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06004B03 RID: 19203 RVA: 0x0011F3C0 File Offset: 0x0011D5C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeSerializerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x0011F3E4 File Offset: 0x0011D5E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedAttributes.Descriptor;
			}
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0011F3FB File Offset: 0x0011D5FB
		[DebuggerNonUserCode]
		public SavedAttributes()
		{
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x0011F410 File Offset: 0x0011D610
		[DebuggerNonUserCode]
		public SavedAttributes(SavedAttributes other)
			: this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x0011F43C File Offset: 0x0011D63C
		[DebuggerNonUserCode]
		public SavedAttributes Clone()
		{
			return new SavedAttributes(this);
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x0011F454 File Offset: 0x0011D654
		[DebuggerNonUserCode]
		public RepeatedField<SavedAttribute> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x0011F46C File Offset: 0x0011D66C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedAttributes);
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x0011F48C File Offset: 0x0011D68C
		[DebuggerNonUserCode]
		public bool Equals(SavedAttributes other)
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
					bool flag4 = !this.attributes_.Equals(other.attributes_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x0011F4E8 File Offset: 0x0011D6E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x0011F528 File Offset: 0x0011D728
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x0011F540 File Offset: 0x0011D740
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x0011F54C File Offset: 0x0011D74C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, SavedAttributes._repeated_attributes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x0011F588 File Offset: 0x0011D788
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(SavedAttributes._repeated_attributes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x0011F5D0 File Offset: 0x0011D7D0
		[DebuggerNonUserCode]
		public void MergeFrom(SavedAttributes other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attributes_.Add(other.attributes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x0011F612 File Offset: 0x0011D812
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x0011F620 File Offset: 0x0011D820
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
					this.attributes_.AddEntriesFrom(ref input, SavedAttributes._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x04002180 RID: 8576
		private static readonly MessageParser<SavedAttributes> _parser = new MessageParser<SavedAttributes>(() => new SavedAttributes());

		// Token: 0x04002181 RID: 8577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002182 RID: 8578
		public const int AttributesFieldNumber = 1;

		// Token: 0x04002183 RID: 8579
		private static readonly FieldCodec<SavedAttribute> _repeated_attributes_codec = FieldCodec.ForMessage<SavedAttribute>(10U, SavedAttribute.Parser);

		// Token: 0x04002184 RID: 8580
		private readonly RepeatedField<SavedAttribute> attributes_ = new RepeatedField<SavedAttribute>();
	}
}
