using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Profanity.V1
{
	// Token: 0x020003DF RID: 991
	public sealed class WordFilter : IMessage<WordFilter>, IMessage, IEquatable<WordFilter>, IDeepCloneable<WordFilter>, IBufferMessage
	{
		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x0017E630 File Offset: 0x0017C830
		[DebuggerNonUserCode]
		public static MessageParser<WordFilter> Parser
		{
			get
			{
				return WordFilter._parser;
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x060062D1 RID: 25297 RVA: 0x0017E648 File Offset: 0x0017C848
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfanityFilterConfigReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x060062D2 RID: 25298 RVA: 0x0017E66C File Offset: 0x0017C86C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WordFilter.Descriptor;
			}
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x0017E683 File Offset: 0x0017C883
		[DebuggerNonUserCode]
		public WordFilter()
		{
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x0017E68D File Offset: 0x0017C88D
		[DebuggerNonUserCode]
		public WordFilter(WordFilter other)
			: this()
		{
			this.type_ = other.type_;
			this.regex_ = other.regex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x0017E6C0 File Offset: 0x0017C8C0
		[DebuggerNonUserCode]
		public WordFilter Clone()
		{
			return new WordFilter(this);
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x060062D6 RID: 25302 RVA: 0x0017E6D8 File Offset: 0x0017C8D8
		// (set) Token: 0x060062D7 RID: 25303 RVA: 0x0017E6F9 File Offset: 0x0017C8F9
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? WordFilter.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x060062D8 RID: 25304 RVA: 0x0017E710 File Offset: 0x0017C910
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x0017E72B File Offset: 0x0017C92B
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x060062DA RID: 25306 RVA: 0x0017E738 File Offset: 0x0017C938
		// (set) Token: 0x060062DB RID: 25307 RVA: 0x0017E759 File Offset: 0x0017C959
		[DebuggerNonUserCode]
		public string Regex
		{
			get
			{
				return this.regex_ ?? WordFilter.RegexDefaultValue;
			}
			set
			{
				this.regex_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x060062DC RID: 25308 RVA: 0x0017E770 File Offset: 0x0017C970
		[DebuggerNonUserCode]
		public bool HasRegex
		{
			get
			{
				return this.regex_ != null;
			}
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x0017E78B File Offset: 0x0017C98B
		[DebuggerNonUserCode]
		public void ClearRegex()
		{
			this.regex_ = null;
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x0017E798 File Offset: 0x0017C998
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WordFilter);
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x0017E7B8 File Offset: 0x0017C9B8
		[DebuggerNonUserCode]
		public bool Equals(WordFilter other)
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
					bool flag4 = this.Type != other.Type;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Regex != other.Regex;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x0017E82C File Offset: 0x0017CA2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasRegex = this.HasRegex;
			if (hasRegex)
			{
				num ^= this.Regex.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x0017E890 File Offset: 0x0017CA90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x0017E8A8 File Offset: 0x0017CAA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x0017E8B4 File Offset: 0x0017CAB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Type);
			}
			bool hasRegex = this.HasRegex;
			if (hasRegex)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Regex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x0017E924 File Offset: 0x0017CB24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool hasRegex = this.HasRegex;
			if (hasRegex)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Regex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x0017E990 File Offset: 0x0017CB90
		[DebuggerNonUserCode]
		public void MergeFrom(WordFilter other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasRegex = other.HasRegex;
				if (hasRegex)
				{
					this.Regex = other.Regex;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x0017E9F2 File Offset: 0x0017CBF2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x0017EA00 File Offset: 0x0017CC00
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Regex = input.ReadString();
					}
				}
				else
				{
					this.Type = input.ReadString();
				}
			}
		}

		// Token: 0x04002D26 RID: 11558
		private static readonly MessageParser<WordFilter> _parser = new MessageParser<WordFilter>(() => new WordFilter());

		// Token: 0x04002D27 RID: 11559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D28 RID: 11560
		public const int TypeFieldNumber = 1;

		// Token: 0x04002D29 RID: 11561
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04002D2A RID: 11562
		private string type_;

		// Token: 0x04002D2B RID: 11563
		public const int RegexFieldNumber = 2;

		// Token: 0x04002D2C RID: 11564
		private static readonly string RegexDefaultValue = "";

		// Token: 0x04002D2D RID: 11565
		private string regex_;
	}
}
