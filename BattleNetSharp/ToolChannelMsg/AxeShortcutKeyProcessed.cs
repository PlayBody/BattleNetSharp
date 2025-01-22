using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000091 RID: 145
	public sealed class AxeShortcutKeyProcessed : IMessage<AxeShortcutKeyProcessed>, IMessage, IEquatable<AxeShortcutKeyProcessed>, IDeepCloneable<AxeShortcutKeyProcessed>, IBufferMessage
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00031EF4 File Offset: 0x000300F4
		[DebuggerNonUserCode]
		public static MessageParser<AxeShortcutKeyProcessed> Parser
		{
			get
			{
				return AxeShortcutKeyProcessed._parser;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00031F0C File Offset: 0x0003010C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[122];
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00031F30 File Offset: 0x00030130
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AxeShortcutKeyProcessed.Descriptor;
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00031F47 File Offset: 0x00030147
		[DebuggerNonUserCode]
		public AxeShortcutKeyProcessed()
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00031F51 File Offset: 0x00030151
		[DebuggerNonUserCode]
		public AxeShortcutKeyProcessed(AxeShortcutKeyProcessed other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.processed_ = other.processed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00031F84 File Offset: 0x00030184
		[DebuggerNonUserCode]
		public AxeShortcutKeyProcessed Clone()
		{
			return new AxeShortcutKeyProcessed(this);
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00031F9C File Offset: 0x0003019C
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00031FCD File Offset: 0x000301CD
		[DebuggerNonUserCode]
		public bool Processed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool processedDefaultValue;
				if (flag)
				{
					processedDefaultValue = this.processed_;
				}
				else
				{
					processedDefaultValue = AxeShortcutKeyProcessed.ProcessedDefaultValue;
				}
				return processedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.processed_ = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00031FE8 File Offset: 0x000301E8
		[DebuggerNonUserCode]
		public bool HasProcessed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00032005 File Offset: 0x00030205
		[DebuggerNonUserCode]
		public void ClearProcessed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00032018 File Offset: 0x00030218
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AxeShortcutKeyProcessed);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00032038 File Offset: 0x00030238
		[DebuggerNonUserCode]
		public bool Equals(AxeShortcutKeyProcessed other)
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
					bool flag4 = this.Processed != other.Processed;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00032090 File Offset: 0x00030290
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProcessed = this.HasProcessed;
			if (hasProcessed)
			{
				num ^= this.Processed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000320E0 File Offset: 0x000302E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000320F8 File Offset: 0x000302F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00032104 File Offset: 0x00030304
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProcessed = this.HasProcessed;
			if (hasProcessed)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Processed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00032150 File Offset: 0x00030350
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProcessed = this.HasProcessed;
			if (hasProcessed)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00032194 File Offset: 0x00030394
		[DebuggerNonUserCode]
		public void MergeFrom(AxeShortcutKeyProcessed other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProcessed = other.HasProcessed;
				if (hasProcessed)
				{
					this.Processed = other.Processed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000321DD File Offset: 0x000303DD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000321E8 File Offset: 0x000303E8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Processed = input.ReadBool();
				}
			}
		}

		// Token: 0x0400054B RID: 1355
		private static readonly MessageParser<AxeShortcutKeyProcessed> _parser = new MessageParser<AxeShortcutKeyProcessed>(() => new AxeShortcutKeyProcessed());

		// Token: 0x0400054C RID: 1356
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400054D RID: 1357
		private int _hasBits0;

		// Token: 0x0400054E RID: 1358
		public const int ProcessedFieldNumber = 1;

		// Token: 0x0400054F RID: 1359
		private static readonly bool ProcessedDefaultValue = false;

		// Token: 0x04000550 RID: 1360
		private bool processed_;
	}
}
