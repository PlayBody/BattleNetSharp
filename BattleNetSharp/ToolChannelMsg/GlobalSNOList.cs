using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200005E RID: 94
	public sealed class GlobalSNOList : IMessage<GlobalSNOList>, IMessage, IEquatable<GlobalSNOList>, IDeepCloneable<GlobalSNOList>, IBufferMessage
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00021CB4 File Offset: 0x0001FEB4
		[DebuggerNonUserCode]
		public static MessageParser<GlobalSNOList> Parser
		{
			get
			{
				return GlobalSNOList._parser;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00021CCC File Offset: 0x0001FECC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[71];
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00021CF0 File Offset: 0x0001FEF0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalSNOList.Descriptor;
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00021D07 File Offset: 0x0001FF07
		[DebuggerNonUserCode]
		public GlobalSNOList()
		{
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00021D1C File Offset: 0x0001FF1C
		[DebuggerNonUserCode]
		public GlobalSNOList(GlobalSNOList other)
			: this()
		{
			this.snoEntries_ = other.snoEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00021D48 File Offset: 0x0001FF48
		[DebuggerNonUserCode]
		public GlobalSNOList Clone()
		{
			return new GlobalSNOList(this);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00021D60 File Offset: 0x0001FF60
		[DebuggerNonUserCode]
		public RepeatedField<GlobalSNOEntry> SnoEntries
		{
			get
			{
				return this.snoEntries_;
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00021D78 File Offset: 0x0001FF78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalSNOList);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00021D98 File Offset: 0x0001FF98
		[DebuggerNonUserCode]
		public bool Equals(GlobalSNOList other)
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
					bool flag4 = !this.snoEntries_.Equals(other.snoEntries_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00021DF4 File Offset: 0x0001FFF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.snoEntries_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00021E34 File Offset: 0x00020034
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00021E4C File Offset: 0x0002004C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00021E58 File Offset: 0x00020058
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.snoEntries_.WriteTo(ref output, GlobalSNOList._repeated_snoEntries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00021E94 File Offset: 0x00020094
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.snoEntries_.CalculateSize(GlobalSNOList._repeated_snoEntries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00021EDC File Offset: 0x000200DC
		[DebuggerNonUserCode]
		public void MergeFrom(GlobalSNOList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.snoEntries_.Add(other.snoEntries_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00021F1E File Offset: 0x0002011E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00021F2C File Offset: 0x0002012C
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
					this.snoEntries_.AddEntriesFrom(ref input, GlobalSNOList._repeated_snoEntries_codec);
				}
			}
		}

		// Token: 0x04000352 RID: 850
		private static readonly MessageParser<GlobalSNOList> _parser = new MessageParser<GlobalSNOList>(() => new GlobalSNOList());

		// Token: 0x04000353 RID: 851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000354 RID: 852
		public const int SnoEntriesFieldNumber = 1;

		// Token: 0x04000355 RID: 853
		private static readonly FieldCodec<GlobalSNOEntry> _repeated_snoEntries_codec = FieldCodec.ForMessage<GlobalSNOEntry>(10U, GlobalSNOEntry.Parser);

		// Token: 0x04000356 RID: 854
		private readonly RepeatedField<GlobalSNOEntry> snoEntries_ = new RepeatedField<GlobalSNOEntry>();
	}
}
