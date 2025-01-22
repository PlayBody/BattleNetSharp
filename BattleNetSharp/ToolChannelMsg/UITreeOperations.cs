using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200009B RID: 155
	public sealed class UITreeOperations : IMessage<UITreeOperations>, IMessage, IEquatable<UITreeOperations>, IDeepCloneable<UITreeOperations>, IBufferMessage
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x000358B8 File Offset: 0x00033AB8
		[DebuggerNonUserCode]
		public static MessageParser<UITreeOperations> Parser
		{
			get
			{
				return UITreeOperations._parser;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x000358D0 File Offset: 0x00033AD0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[132];
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000358F8 File Offset: 0x00033AF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UITreeOperations.Descriptor;
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0003590F File Offset: 0x00033B0F
		[DebuggerNonUserCode]
		public UITreeOperations()
		{
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00035924 File Offset: 0x00033B24
		[DebuggerNonUserCode]
		public UITreeOperations(UITreeOperations other)
			: this()
		{
			this.ops_ = other.ops_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00035950 File Offset: 0x00033B50
		[DebuggerNonUserCode]
		public UITreeOperations Clone()
		{
			return new UITreeOperations(this);
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00035968 File Offset: 0x00033B68
		[DebuggerNonUserCode]
		public RepeatedField<UITreeOperation> Ops
		{
			get
			{
				return this.ops_;
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00035980 File Offset: 0x00033B80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UITreeOperations);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000359A0 File Offset: 0x00033BA0
		[DebuggerNonUserCode]
		public bool Equals(UITreeOperations other)
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
					bool flag4 = !this.ops_.Equals(other.ops_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000359FC File Offset: 0x00033BFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ops_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00035A3C File Offset: 0x00033C3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00035A54 File Offset: 0x00033C54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00035A60 File Offset: 0x00033C60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ops_.WriteTo(ref output, UITreeOperations._repeated_ops_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00035A9C File Offset: 0x00033C9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ops_.CalculateSize(UITreeOperations._repeated_ops_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00035AE4 File Offset: 0x00033CE4
		[DebuggerNonUserCode]
		public void MergeFrom(UITreeOperations other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ops_.Add(other.ops_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00035B26 File Offset: 0x00033D26
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00035B34 File Offset: 0x00033D34
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
					this.ops_.AddEntriesFrom(ref input, UITreeOperations._repeated_ops_codec);
				}
			}
		}

		// Token: 0x040005B7 RID: 1463
		private static readonly MessageParser<UITreeOperations> _parser = new MessageParser<UITreeOperations>(() => new UITreeOperations());

		// Token: 0x040005B8 RID: 1464
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005B9 RID: 1465
		public const int OpsFieldNumber = 1;

		// Token: 0x040005BA RID: 1466
		private static readonly FieldCodec<UITreeOperation> _repeated_ops_codec = FieldCodec.ForMessage<UITreeOperation>(10U, UITreeOperation.Parser);

		// Token: 0x040005BB RID: 1467
		private readonly RepeatedField<UITreeOperation> ops_ = new RepeatedField<UITreeOperation>();
	}
}
