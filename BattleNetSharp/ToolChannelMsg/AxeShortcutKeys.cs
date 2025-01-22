using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000090 RID: 144
	public sealed class AxeShortcutKeys : IMessage<AxeShortcutKeys>, IMessage, IEquatable<AxeShortcutKeys>, IDeepCloneable<AxeShortcutKeys>, IBufferMessage
	{
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00031BF8 File Offset: 0x0002FDF8
		[DebuggerNonUserCode]
		public static MessageParser<AxeShortcutKeys> Parser
		{
			get
			{
				return AxeShortcutKeys._parser;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00031C10 File Offset: 0x0002FE10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[121];
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00031C34 File Offset: 0x0002FE34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AxeShortcutKeys.Descriptor;
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00031C4B File Offset: 0x0002FE4B
		[DebuggerNonUserCode]
		public AxeShortcutKeys()
		{
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00031C60 File Offset: 0x0002FE60
		[DebuggerNonUserCode]
		public AxeShortcutKeys(AxeShortcutKeys other)
			: this()
		{
			this.shortcutKeys_ = other.shortcutKeys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00031C8C File Offset: 0x0002FE8C
		[DebuggerNonUserCode]
		public AxeShortcutKeys Clone()
		{
			return new AxeShortcutKeys(this);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00031CA4 File Offset: 0x0002FEA4
		[DebuggerNonUserCode]
		public RepeatedField<AxeShortcutKey> ShortcutKeys
		{
			get
			{
				return this.shortcutKeys_;
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00031CBC File Offset: 0x0002FEBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AxeShortcutKeys);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00031CDC File Offset: 0x0002FEDC
		[DebuggerNonUserCode]
		public bool Equals(AxeShortcutKeys other)
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
					bool flag4 = !this.shortcutKeys_.Equals(other.shortcutKeys_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00031D38 File Offset: 0x0002FF38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.shortcutKeys_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00031D78 File Offset: 0x0002FF78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00031D90 File Offset: 0x0002FF90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00031D9C File Offset: 0x0002FF9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.shortcutKeys_.WriteTo(ref output, AxeShortcutKeys._repeated_shortcutKeys_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00031DD8 File Offset: 0x0002FFD8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.shortcutKeys_.CalculateSize(AxeShortcutKeys._repeated_shortcutKeys_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00031E20 File Offset: 0x00030020
		[DebuggerNonUserCode]
		public void MergeFrom(AxeShortcutKeys other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.shortcutKeys_.Add(other.shortcutKeys_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00031E62 File Offset: 0x00030062
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00031E70 File Offset: 0x00030070
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
					this.shortcutKeys_.AddEntriesFrom(ref input, AxeShortcutKeys._repeated_shortcutKeys_codec);
				}
			}
		}

		// Token: 0x04000546 RID: 1350
		private static readonly MessageParser<AxeShortcutKeys> _parser = new MessageParser<AxeShortcutKeys>(() => new AxeShortcutKeys());

		// Token: 0x04000547 RID: 1351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000548 RID: 1352
		public const int ShortcutKeysFieldNumber = 1;

		// Token: 0x04000549 RID: 1353
		private static readonly FieldCodec<AxeShortcutKey> _repeated_shortcutKeys_codec = FieldCodec.ForMessage<AxeShortcutKey>(10U, AxeShortcutKey.Parser);

		// Token: 0x0400054A RID: 1354
		private readonly RepeatedField<AxeShortcutKey> shortcutKeys_ = new RepeatedField<AxeShortcutKey>();
	}
}
