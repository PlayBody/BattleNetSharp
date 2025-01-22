using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200005A RID: 90
	public sealed class ManualValidationEntry : IMessage<ManualValidationEntry>, IMessage, IEquatable<ManualValidationEntry>, IDeepCloneable<ManualValidationEntry>, IBufferMessage
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00020610 File Offset: 0x0001E810
		[DebuggerNonUserCode]
		public static MessageParser<ManualValidationEntry> Parser
		{
			get
			{
				return ManualValidationEntry._parser;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00020628 File Offset: 0x0001E828
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[67];
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0002064C File Offset: 0x0001E84C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ManualValidationEntry.Descriptor;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00020663 File Offset: 0x0001E863
		[DebuggerNonUserCode]
		public ManualValidationEntry()
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00020678 File Offset: 0x0001E878
		[DebuggerNonUserCode]
		public ManualValidationEntry(ManualValidationEntry other)
			: this()
		{
			this.errors_ = other.errors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000206A4 File Offset: 0x0001E8A4
		[DebuggerNonUserCode]
		public ManualValidationEntry Clone()
		{
			return new ManualValidationEntry(this);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x000206BC File Offset: 0x0001E8BC
		[DebuggerNonUserCode]
		public RepeatedField<ManualValidationResult> Errors
		{
			get
			{
				return this.errors_;
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000206D4 File Offset: 0x0001E8D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ManualValidationEntry);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000206F4 File Offset: 0x0001E8F4
		[DebuggerNonUserCode]
		public bool Equals(ManualValidationEntry other)
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
					bool flag4 = !this.errors_.Equals(other.errors_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00020750 File Offset: 0x0001E950
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.errors_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00020790 File Offset: 0x0001E990
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000207A8 File Offset: 0x0001E9A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000207B4 File Offset: 0x0001E9B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errors_.WriteTo(ref output, ManualValidationEntry._repeated_errors_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000207F0 File Offset: 0x0001E9F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.errors_.CalculateSize(ManualValidationEntry._repeated_errors_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00020838 File Offset: 0x0001EA38
		[DebuggerNonUserCode]
		public void MergeFrom(ManualValidationEntry other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.errors_.Add(other.errors_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0002087A File Offset: 0x0001EA7A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00020888 File Offset: 0x0001EA88
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
					this.errors_.AddEntriesFrom(ref input, ManualValidationEntry._repeated_errors_codec);
				}
			}
		}

		// Token: 0x04000325 RID: 805
		private static readonly MessageParser<ManualValidationEntry> _parser = new MessageParser<ManualValidationEntry>(() => new ManualValidationEntry());

		// Token: 0x04000326 RID: 806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000327 RID: 807
		public const int ErrorsFieldNumber = 1;

		// Token: 0x04000328 RID: 808
		private static readonly FieldCodec<ManualValidationResult> _repeated_errors_codec = FieldCodec.ForMessage<ManualValidationResult>(10U, ManualValidationResult.Parser);

		// Token: 0x04000329 RID: 809
		private readonly RepeatedField<ManualValidationResult> errors_ = new RepeatedField<ManualValidationResult>();
	}
}
