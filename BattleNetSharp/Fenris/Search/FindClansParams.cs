using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Search
{
	// Token: 0x0200011C RID: 284
	public sealed class FindClansParams : IMessage<FindClansParams>, IMessage, IEquatable<FindClansParams>, IDeepCloneable<FindClansParams>, IBufferMessage
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0006A794 File Offset: 0x00068994
		[DebuggerNonUserCode]
		public static MessageParser<FindClansParams> Parser
		{
			get
			{
				return FindClansParams._parser;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0006A7AC File Offset: 0x000689AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SearchReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0006A7D0 File Offset: 0x000689D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindClansParams.Descriptor;
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0006A7E7 File Offset: 0x000689E7
		[DebuggerNonUserCode]
		public FindClansParams()
		{
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0006A7FC File Offset: 0x000689FC
		[DebuggerNonUserCode]
		public FindClansParams(FindClansParams other)
			: this()
		{
			this.text_ = other.text_;
			this.label_ = other.label_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0006A834 File Offset: 0x00068A34
		[DebuggerNonUserCode]
		public FindClansParams Clone()
		{
			return new FindClansParams(this);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0006A84C File Offset: 0x00068A4C
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0006A86D File Offset: 0x00068A6D
		[DebuggerNonUserCode]
		public string Text
		{
			get
			{
				return this.text_ ?? FindClansParams.TextDefaultValue;
			}
			set
			{
				this.text_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0006A884 File Offset: 0x00068A84
		[DebuggerNonUserCode]
		public bool HasText
		{
			get
			{
				return this.text_ != null;
			}
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0006A89F File Offset: 0x00068A9F
		[DebuggerNonUserCode]
		public void ClearText()
		{
			this.text_ = null;
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0006A8AC File Offset: 0x00068AAC
		[DebuggerNonUserCode]
		public RepeatedField<uint> Label
		{
			get
			{
				return this.label_;
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0006A8C4 File Offset: 0x00068AC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindClansParams);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		[DebuggerNonUserCode]
		public bool Equals(FindClansParams other)
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
					bool flag4 = this.Text != other.Text;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.label_.Equals(other.label_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0006A958 File Offset: 0x00068B58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasText = this.HasText;
			if (hasText)
			{
				num ^= this.Text.GetHashCode();
			}
			num ^= this.label_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0006A9B0 File Offset: 0x00068BB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0006A9C8 File Offset: 0x00068BC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0006A9D4 File Offset: 0x00068BD4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasText = this.HasText;
			if (hasText)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Text);
			}
			this.label_.WriteTo(ref output, FindClansParams._repeated_label_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0006AA34 File Offset: 0x00068C34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasText = this.HasText;
			if (hasText)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Text);
			}
			num += this.label_.CalculateSize(FindClansParams._repeated_label_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0006AA98 File Offset: 0x00068C98
		[DebuggerNonUserCode]
		public void MergeFrom(FindClansParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasText = other.HasText;
				if (hasText)
				{
					this.Text = other.Text;
				}
				this.label_.Add(other.label_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0006AAF3 File Offset: 0x00068CF3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0006AB00 File Offset: 0x00068D00
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
					if (num3 != 16U && num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.label_.AddEntriesFrom(ref input, FindClansParams._repeated_label_codec);
					}
				}
				else
				{
					this.Text = input.ReadString();
				}
			}
		}

		// Token: 0x04000BC7 RID: 3015
		private static readonly MessageParser<FindClansParams> _parser = new MessageParser<FindClansParams>(() => new FindClansParams());

		// Token: 0x04000BC8 RID: 3016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BC9 RID: 3017
		public const int TextFieldNumber = 1;

		// Token: 0x04000BCA RID: 3018
		private static readonly string TextDefaultValue = "";

		// Token: 0x04000BCB RID: 3019
		private string text_;

		// Token: 0x04000BCC RID: 3020
		public const int LabelFieldNumber = 2;

		// Token: 0x04000BCD RID: 3021
		private static readonly FieldCodec<uint> _repeated_label_codec = FieldCodec.ForUInt32(16U);

		// Token: 0x04000BCE RID: 3022
		private readonly RepeatedField<uint> label_ = new RepeatedField<uint>();
	}
}
