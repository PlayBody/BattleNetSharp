using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200001B RID: 27
	public sealed class WwiseSoundBankIDsToNameResult : IMessage<WwiseSoundBankIDsToNameResult>, IMessage, IEquatable<WwiseSoundBankIDsToNameResult>, IDeepCloneable<WwiseSoundBankIDsToNameResult>, IBufferMessage
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000B944 File Offset: 0x00009B44
		[DebuggerNonUserCode]
		public static MessageParser<WwiseSoundBankIDsToNameResult> Parser
		{
			get
			{
				return WwiseSoundBankIDsToNameResult._parser;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000B95C File Offset: 0x00009B5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000B980 File Offset: 0x00009B80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WwiseSoundBankIDsToNameResult.Descriptor;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000B997 File Offset: 0x00009B97
		[DebuggerNonUserCode]
		public WwiseSoundBankIDsToNameResult()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000B9AC File Offset: 0x00009BAC
		[DebuggerNonUserCode]
		public WwiseSoundBankIDsToNameResult(WwiseSoundBankIDsToNameResult other)
			: this()
		{
			this.entries_ = other.entries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000B9D8 File Offset: 0x00009BD8
		[DebuggerNonUserCode]
		public WwiseSoundBankIDsToNameResult Clone()
		{
			return new WwiseSoundBankIDsToNameResult(this);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		[DebuggerNonUserCode]
		public RepeatedField<WwiseSoundBankIDToName> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000BA08 File Offset: 0x00009C08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WwiseSoundBankIDsToNameResult);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000BA28 File Offset: 0x00009C28
		[DebuggerNonUserCode]
		public bool Equals(WwiseSoundBankIDsToNameResult other)
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
					bool flag4 = !this.entries_.Equals(other.entries_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000BA84 File Offset: 0x00009C84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entries_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000BAC4 File Offset: 0x00009CC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000BADC File Offset: 0x00009CDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000BAE8 File Offset: 0x00009CE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entries_.WriteTo(ref output, WwiseSoundBankIDsToNameResult._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000BB24 File Offset: 0x00009D24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entries_.CalculateSize(WwiseSoundBankIDsToNameResult._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000BB6C File Offset: 0x00009D6C
		[DebuggerNonUserCode]
		public void MergeFrom(WwiseSoundBankIDsToNameResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.entries_.Add(other.entries_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000BBAE File Offset: 0x00009DAE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000BBBC File Offset: 0x00009DBC
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
					this.entries_.AddEntriesFrom(ref input, WwiseSoundBankIDsToNameResult._repeated_entries_codec);
				}
			}
		}

		// Token: 0x040000A1 RID: 161
		private static readonly MessageParser<WwiseSoundBankIDsToNameResult> _parser = new MessageParser<WwiseSoundBankIDsToNameResult>(() => new WwiseSoundBankIDsToNameResult());

		// Token: 0x040000A2 RID: 162
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000A3 RID: 163
		public const int EntriesFieldNumber = 1;

		// Token: 0x040000A4 RID: 164
		private static readonly FieldCodec<WwiseSoundBankIDToName> _repeated_entries_codec = FieldCodec.ForMessage<WwiseSoundBankIDToName>(10U, WwiseSoundBankIDToName.Parser);

		// Token: 0x040000A5 RID: 165
		private readonly RepeatedField<WwiseSoundBankIDToName> entries_ = new RepeatedField<WwiseSoundBankIDToName>();
	}
}
