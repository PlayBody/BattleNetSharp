using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200007A RID: 122
	public sealed class ReverseCompilationDependenciesResponse : IMessage<ReverseCompilationDependenciesResponse>, IMessage, IEquatable<ReverseCompilationDependenciesResponse>, IDeepCloneable<ReverseCompilationDependenciesResponse>, IBufferMessage
	{
		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002994C File Offset: 0x00027B4C
		[DebuggerNonUserCode]
		public static MessageParser<ReverseCompilationDependenciesResponse> Parser
		{
			get
			{
				return ReverseCompilationDependenciesResponse._parser;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00029964 File Offset: 0x00027B64
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[99];
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00029988 File Offset: 0x00027B88
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReverseCompilationDependenciesResponse.Descriptor;
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002999F File Offset: 0x00027B9F
		[DebuggerNonUserCode]
		public ReverseCompilationDependenciesResponse()
		{
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x000299B4 File Offset: 0x00027BB4
		[DebuggerNonUserCode]
		public ReverseCompilationDependenciesResponse(ReverseCompilationDependenciesResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.list_ = other.list_.Clone();
			this.tooManyDependencies_ = other.tooManyDependencies_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00029A04 File Offset: 0x00027C04
		[DebuggerNonUserCode]
		public ReverseCompilationDependenciesResponse Clone()
		{
			return new ReverseCompilationDependenciesResponse(this);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00029A1C File Offset: 0x00027C1C
		[DebuggerNonUserCode]
		public RepeatedField<SNOName> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00029A34 File Offset: 0x00027C34
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00029A65 File Offset: 0x00027C65
		[DebuggerNonUserCode]
		public bool TooManyDependencies
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool tooManyDependenciesDefaultValue;
				if (flag)
				{
					tooManyDependenciesDefaultValue = this.tooManyDependencies_;
				}
				else
				{
					tooManyDependenciesDefaultValue = ReverseCompilationDependenciesResponse.TooManyDependenciesDefaultValue;
				}
				return tooManyDependenciesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.tooManyDependencies_ = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00029A80 File Offset: 0x00027C80
		[DebuggerNonUserCode]
		public bool HasTooManyDependencies
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00029A9D File Offset: 0x00027C9D
		[DebuggerNonUserCode]
		public void ClearTooManyDependencies()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00029AB0 File Offset: 0x00027CB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReverseCompilationDependenciesResponse);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00029AD0 File Offset: 0x00027CD0
		[DebuggerNonUserCode]
		public bool Equals(ReverseCompilationDependenciesResponse other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TooManyDependencies != other.TooManyDependencies;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00029B44 File Offset: 0x00027D44
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.list_.GetHashCode();
			bool hasTooManyDependencies = this.HasTooManyDependencies;
			if (hasTooManyDependencies)
			{
				num ^= this.TooManyDependencies.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00029BA4 File Offset: 0x00027DA4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00029BBC File Offset: 0x00027DBC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00029BC8 File Offset: 0x00027DC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, ReverseCompilationDependenciesResponse._repeated_list_codec);
			bool hasTooManyDependencies = this.HasTooManyDependencies;
			if (hasTooManyDependencies)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.TooManyDependencies);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00029C28 File Offset: 0x00027E28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(ReverseCompilationDependenciesResponse._repeated_list_codec);
			bool hasTooManyDependencies = this.HasTooManyDependencies;
			if (hasTooManyDependencies)
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

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00029C80 File Offset: 0x00027E80
		[DebuggerNonUserCode]
		public void MergeFrom(ReverseCompilationDependenciesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				bool hasTooManyDependencies = other.HasTooManyDependencies;
				if (hasTooManyDependencies)
				{
					this.TooManyDependencies = other.TooManyDependencies;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00029CDB File Offset: 0x00027EDB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00029CE8 File Offset: 0x00027EE8
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TooManyDependencies = input.ReadBool();
					}
				}
				else
				{
					this.list_.AddEntriesFrom(ref input, ReverseCompilationDependenciesResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly MessageParser<ReverseCompilationDependenciesResponse> _parser = new MessageParser<ReverseCompilationDependenciesResponse>(() => new ReverseCompilationDependenciesResponse());

		// Token: 0x0400043E RID: 1086
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400043F RID: 1087
		private int _hasBits0;

		// Token: 0x04000440 RID: 1088
		public const int ListFieldNumber = 1;

		// Token: 0x04000441 RID: 1089
		private static readonly FieldCodec<SNOName> _repeated_list_codec = FieldCodec.ForMessage<SNOName>(10U, SNOName.Parser);

		// Token: 0x04000442 RID: 1090
		private readonly RepeatedField<SNOName> list_ = new RepeatedField<SNOName>();

		// Token: 0x04000443 RID: 1091
		public const int TooManyDependenciesFieldNumber = 2;

		// Token: 0x04000444 RID: 1092
		private static readonly bool TooManyDependenciesDefaultValue = false;

		// Token: 0x04000445 RID: 1093
		private bool tooManyDependencies_;
	}
}
