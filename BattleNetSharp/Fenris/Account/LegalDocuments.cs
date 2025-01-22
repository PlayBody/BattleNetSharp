using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002DD RID: 733
	public sealed class LegalDocuments : IMessage<LegalDocuments>, IMessage, IEquatable<LegalDocuments>, IDeepCloneable<LegalDocuments>, IBufferMessage
	{
		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06004D82 RID: 19842 RVA: 0x001289B4 File Offset: 0x00126BB4
		[DebuggerNonUserCode]
		public static MessageParser<LegalDocuments> Parser
		{
			get
			{
				return LegalDocuments._parser;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x001289CC File Offset: 0x00126BCC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x001289F0 File Offset: 0x00126BF0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LegalDocuments.Descriptor;
			}
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x00128A07 File Offset: 0x00126C07
		[DebuggerNonUserCode]
		public LegalDocuments()
		{
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x00128A1C File Offset: 0x00126C1C
		[DebuggerNonUserCode]
		public LegalDocuments(LegalDocuments other)
			: this()
		{
			this.legalDocuments_ = other.legalDocuments_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00128A48 File Offset: 0x00126C48
		[DebuggerNonUserCode]
		public LegalDocuments Clone()
		{
			return new LegalDocuments(this);
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x00128A60 File Offset: 0x00126C60
		[DebuggerNonUserCode]
		public RepeatedField<LegalDocument> LegalDocuments_
		{
			get
			{
				return this.legalDocuments_;
			}
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x00128A78 File Offset: 0x00126C78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LegalDocuments);
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00128A98 File Offset: 0x00126C98
		[DebuggerNonUserCode]
		public bool Equals(LegalDocuments other)
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
					bool flag4 = !this.legalDocuments_.Equals(other.legalDocuments_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00128AF4 File Offset: 0x00126CF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.legalDocuments_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00128B34 File Offset: 0x00126D34
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00128B4C File Offset: 0x00126D4C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x00128B58 File Offset: 0x00126D58
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.legalDocuments_.WriteTo(ref output, LegalDocuments._repeated_legalDocuments_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00128B94 File Offset: 0x00126D94
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.legalDocuments_.CalculateSize(LegalDocuments._repeated_legalDocuments_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00128BDC File Offset: 0x00126DDC
		[DebuggerNonUserCode]
		public void MergeFrom(LegalDocuments other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.legalDocuments_.Add(other.legalDocuments_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00128C1E File Offset: 0x00126E1E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00128C2C File Offset: 0x00126E2C
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
					this.legalDocuments_.AddEntriesFrom(ref input, LegalDocuments._repeated_legalDocuments_codec);
				}
			}
		}

		// Token: 0x04002291 RID: 8849
		private static readonly MessageParser<LegalDocuments> _parser = new MessageParser<LegalDocuments>(() => new LegalDocuments());

		// Token: 0x04002292 RID: 8850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002293 RID: 8851
		public const int LegalDocuments_FieldNumber = 1;

		// Token: 0x04002294 RID: 8852
		private static readonly FieldCodec<LegalDocument> _repeated_legalDocuments_codec = FieldCodec.ForMessage<LegalDocument>(10U, LegalDocument.Parser);

		// Token: 0x04002295 RID: 8853
		private readonly RepeatedField<LegalDocument> legalDocuments_ = new RepeatedField<LegalDocument>();
	}
}
