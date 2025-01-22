using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Profanity.V1
{
	// Token: 0x020003E0 RID: 992
	public sealed class WordFilters : IMessage<WordFilters>, IMessage, IEquatable<WordFilters>, IDeepCloneable<WordFilters>, IBufferMessage
	{
		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x0017EA98 File Offset: 0x0017CC98
		[DebuggerNonUserCode]
		public static MessageParser<WordFilters> Parser
		{
			get
			{
				return WordFilters._parser;
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x060062EA RID: 25322 RVA: 0x0017EAB0 File Offset: 0x0017CCB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfanityFilterConfigReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x060062EB RID: 25323 RVA: 0x0017EAD4 File Offset: 0x0017CCD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WordFilters.Descriptor;
			}
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x0017EAEB File Offset: 0x0017CCEB
		[DebuggerNonUserCode]
		public WordFilters()
		{
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x0017EB00 File Offset: 0x0017CD00
		[DebuggerNonUserCode]
		public WordFilters(WordFilters other)
			: this()
		{
			this.filters_ = other.filters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x0017EB2C File Offset: 0x0017CD2C
		[DebuggerNonUserCode]
		public WordFilters Clone()
		{
			return new WordFilters(this);
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x060062EF RID: 25327 RVA: 0x0017EB44 File Offset: 0x0017CD44
		[DebuggerNonUserCode]
		public RepeatedField<WordFilter> Filters
		{
			get
			{
				return this.filters_;
			}
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x0017EB5C File Offset: 0x0017CD5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WordFilters);
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x0017EB7C File Offset: 0x0017CD7C
		[DebuggerNonUserCode]
		public bool Equals(WordFilters other)
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
					bool flag4 = !this.filters_.Equals(other.filters_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x0017EBD8 File Offset: 0x0017CDD8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.filters_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x0017EC18 File Offset: 0x0017CE18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x0017EC30 File Offset: 0x0017CE30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x0017EC3C File Offset: 0x0017CE3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.filters_.WriteTo(ref output, WordFilters._repeated_filters_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x0017EC78 File Offset: 0x0017CE78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.filters_.CalculateSize(WordFilters._repeated_filters_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x0017ECC0 File Offset: 0x0017CEC0
		[DebuggerNonUserCode]
		public void MergeFrom(WordFilters other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.filters_.Add(other.filters_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x0017ED02 File Offset: 0x0017CF02
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x0017ED10 File Offset: 0x0017CF10
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
					this.filters_.AddEntriesFrom(ref input, WordFilters._repeated_filters_codec);
				}
			}
		}

		// Token: 0x04002D2E RID: 11566
		private static readonly MessageParser<WordFilters> _parser = new MessageParser<WordFilters>(() => new WordFilters());

		// Token: 0x04002D2F RID: 11567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D30 RID: 11568
		public const int FiltersFieldNumber = 1;

		// Token: 0x04002D31 RID: 11569
		private static readonly FieldCodec<WordFilter> _repeated_filters_codec = FieldCodec.ForMessage<WordFilter>(10U, WordFilter.Parser);

		// Token: 0x04002D32 RID: 11570
		private readonly RepeatedField<WordFilter> filters_ = new RepeatedField<WordFilter>();
	}
}
