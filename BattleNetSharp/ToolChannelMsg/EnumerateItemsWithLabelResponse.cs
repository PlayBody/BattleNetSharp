using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000055 RID: 85
	public sealed class EnumerateItemsWithLabelResponse : IMessage<EnumerateItemsWithLabelResponse>, IMessage, IEquatable<EnumerateItemsWithLabelResponse>, IDeepCloneable<EnumerateItemsWithLabelResponse>, IBufferMessage
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
		[DebuggerNonUserCode]
		public static MessageParser<EnumerateItemsWithLabelResponse> Parser
		{
			get
			{
				return EnumerateItemsWithLabelResponse._parser;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0001EAC8 File Offset: 0x0001CCC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[62];
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x0001EAEC File Offset: 0x0001CCEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumerateItemsWithLabelResponse.Descriptor;
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001EB03 File Offset: 0x0001CD03
		[DebuggerNonUserCode]
		public EnumerateItemsWithLabelResponse()
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0001EB18 File Offset: 0x0001CD18
		[DebuggerNonUserCode]
		public EnumerateItemsWithLabelResponse(EnumerateItemsWithLabelResponse other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001EB44 File Offset: 0x0001CD44
		[DebuggerNonUserCode]
		public EnumerateItemsWithLabelResponse Clone()
		{
			return new EnumerateItemsWithLabelResponse(this);
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001EB5C File Offset: 0x0001CD5C
		[DebuggerNonUserCode]
		public RepeatedField<SNONameWithLabel> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0001EB74 File Offset: 0x0001CD74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnumerateItemsWithLabelResponse);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001EB94 File Offset: 0x0001CD94
		[DebuggerNonUserCode]
		public bool Equals(EnumerateItemsWithLabelResponse other)
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
					bool flag4 = !this.list_.Equals(other.list_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.list_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0001EC30 File Offset: 0x0001CE30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001EC54 File Offset: 0x0001CE54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, EnumerateItemsWithLabelResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001EC90 File Offset: 0x0001CE90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(EnumerateItemsWithLabelResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		[DebuggerNonUserCode]
		public void MergeFrom(EnumerateItemsWithLabelResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001ED1A File Offset: 0x0001CF1A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001ED28 File Offset: 0x0001CF28
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
					this.list_.AddEntriesFrom(ref input, EnumerateItemsWithLabelResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x040002EE RID: 750
		private static readonly MessageParser<EnumerateItemsWithLabelResponse> _parser = new MessageParser<EnumerateItemsWithLabelResponse>(() => new EnumerateItemsWithLabelResponse());

		// Token: 0x040002EF RID: 751
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002F0 RID: 752
		public const int ListFieldNumber = 1;

		// Token: 0x040002F1 RID: 753
		private static readonly FieldCodec<SNONameWithLabel> _repeated_list_codec = FieldCodec.ForMessage<SNONameWithLabel>(10U, SNONameWithLabel.Parser);

		// Token: 0x040002F2 RID: 754
		private readonly RepeatedField<SNONameWithLabel> list_ = new RepeatedField<SNONameWithLabel>();
	}
}
