using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.DiabloClone
{
	// Token: 0x020007A1 RID: 1953
	public sealed class DiabloCloneMessage : IMessage<DiabloCloneMessage>, IMessage, IEquatable<DiabloCloneMessage>, IDeepCloneable<DiabloCloneMessage>, IBufferMessage
	{
		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x002BA050 File Offset: 0x002B8250
		[DebuggerNonUserCode]
		public static MessageParser<DiabloCloneMessage> Parser
		{
			get
			{
				return DiabloCloneMessage._parser;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600B349 RID: 45897 RVA: 0x002BA068 File Offset: 0x002B8268
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiabloCloneReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600B34A RID: 45898 RVA: 0x002BA08C File Offset: 0x002B828C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiabloCloneMessage.Descriptor;
			}
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x002BA0A3 File Offset: 0x002B82A3
		[DebuggerNonUserCode]
		public DiabloCloneMessage()
		{
		}

		// Token: 0x0600B34C RID: 45900 RVA: 0x002BA0B8 File Offset: 0x002B82B8
		[DebuggerNonUserCode]
		public DiabloCloneMessage(DiabloCloneMessage other)
			: this()
		{
			this.progression_ = other.progression_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x002BA0E4 File Offset: 0x002B82E4
		[DebuggerNonUserCode]
		public DiabloCloneMessage Clone()
		{
			return new DiabloCloneMessage(this);
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x002BA0FC File Offset: 0x002B82FC
		[DebuggerNonUserCode]
		public RepeatedField<Progression> Progression
		{
			get
			{
				return this.progression_;
			}
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x002BA114 File Offset: 0x002B8314
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiabloCloneMessage);
		}

		// Token: 0x0600B350 RID: 45904 RVA: 0x002BA134 File Offset: 0x002B8334
		[DebuggerNonUserCode]
		public bool Equals(DiabloCloneMessage other)
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
					bool flag4 = !this.progression_.Equals(other.progression_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600B351 RID: 45905 RVA: 0x002BA190 File Offset: 0x002B8390
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.progression_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B352 RID: 45906 RVA: 0x002BA1D0 File Offset: 0x002B83D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B353 RID: 45907 RVA: 0x002BA1E8 File Offset: 0x002B83E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x002BA1F4 File Offset: 0x002B83F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.progression_.WriteTo(ref output, DiabloCloneMessage._repeated_progression_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x002BA230 File Offset: 0x002B8430
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.progression_.CalculateSize(DiabloCloneMessage._repeated_progression_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x002BA278 File Offset: 0x002B8478
		[DebuggerNonUserCode]
		public void MergeFrom(DiabloCloneMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.progression_.Add(other.progression_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x002BA2BA File Offset: 0x002B84BA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B358 RID: 45912 RVA: 0x002BA2C8 File Offset: 0x002B84C8
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
					this.progression_.AddEntriesFrom(ref input, DiabloCloneMessage._repeated_progression_codec);
				}
			}
		}

		// Token: 0x04005111 RID: 20753
		private static readonly MessageParser<DiabloCloneMessage> _parser = new MessageParser<DiabloCloneMessage>(() => new DiabloCloneMessage());

		// Token: 0x04005112 RID: 20754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005113 RID: 20755
		public const int ProgressionFieldNumber = 1;

		// Token: 0x04005114 RID: 20756
		private static readonly FieldCodec<Progression> _repeated_progression_codec = FieldCodec.ForMessage<Progression>(10U, Classic.Protocol.External.V1.DiabloClone.Progression.Parser);

		// Token: 0x04005115 RID: 20757
		private readonly RepeatedField<Progression> progression_ = new RepeatedField<Progression>();
	}
}
