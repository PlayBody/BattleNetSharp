using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000367 RID: 871
	public sealed class FloatFieldRestriction : IMessage<FloatFieldRestriction>, IMessage, IEquatable<FloatFieldRestriction>, IDeepCloneable<FloatFieldRestriction>, IBufferMessage
	{
		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x0015BC20 File Offset: 0x00159E20
		[DebuggerNonUserCode]
		public static MessageParser<FloatFieldRestriction> Parser
		{
			get
			{
				return FloatFieldRestriction._parser;
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x060059CA RID: 22986 RVA: 0x0015BC38 File Offset: 0x00159E38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x060059CB RID: 22987 RVA: 0x0015BC5C File Offset: 0x00159E5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloatFieldRestriction.Descriptor;
			}
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x0015BC73 File Offset: 0x00159E73
		[DebuggerNonUserCode]
		public FloatFieldRestriction()
		{
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x0015BC88 File Offset: 0x00159E88
		[DebuggerNonUserCode]
		public FloatFieldRestriction(FloatFieldRestriction other)
			: this()
		{
			this.limits_ = ((other.limits_ != null) ? other.limits_.Clone() : null);
			this.exclude_ = other.exclude_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x0015BCDC File Offset: 0x00159EDC
		[DebuggerNonUserCode]
		public FloatFieldRestriction Clone()
		{
			return new FloatFieldRestriction(this);
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x060059CF RID: 22991 RVA: 0x0015BCF4 File Offset: 0x00159EF4
		// (set) Token: 0x060059D0 RID: 22992 RVA: 0x0015BD0C File Offset: 0x00159F0C
		[DebuggerNonUserCode]
		public FloatRange Limits
		{
			get
			{
				return this.limits_;
			}
			set
			{
				this.limits_ = value;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x060059D1 RID: 22993 RVA: 0x0015BD18 File Offset: 0x00159F18
		[DebuggerNonUserCode]
		public RepeatedField<float> Exclude
		{
			get
			{
				return this.exclude_;
			}
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x0015BD30 File Offset: 0x00159F30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloatFieldRestriction);
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x0015BD50 File Offset: 0x00159F50
		[DebuggerNonUserCode]
		public bool Equals(FloatFieldRestriction other)
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
					bool flag4 = !object.Equals(this.Limits, other.Limits);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.exclude_.Equals(other.exclude_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x0015BDC8 File Offset: 0x00159FC8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.limits_ != null;
			if (flag)
			{
				num ^= this.Limits.GetHashCode();
			}
			num ^= this.exclude_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x0015BE24 File Offset: 0x0015A024
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x0015BE3C File Offset: 0x0015A03C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x0015BE48 File Offset: 0x0015A048
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.limits_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Limits);
			}
			this.exclude_.WriteTo(ref output, FloatFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x0015BEAC File Offset: 0x0015A0AC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.limits_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Limits);
			}
			num += this.exclude_.CalculateSize(FloatFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x0015BF10 File Offset: 0x0015A110
		[DebuggerNonUserCode]
		public void MergeFrom(FloatFieldRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.limits_ != null;
				if (flag2)
				{
					bool flag3 = this.limits_ == null;
					if (flag3)
					{
						this.Limits = new FloatRange();
					}
					this.Limits.MergeFrom(other.Limits);
				}
				this.exclude_.Add(other.exclude_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x0015BF8E File Offset: 0x0015A18E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x0015BF9C File Offset: 0x0015A19C
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
					if (num3 != 18U && num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.exclude_.AddEntriesFrom(ref input, FloatFieldRestriction._repeated_exclude_codec);
					}
				}
				else
				{
					bool flag = this.limits_ == null;
					if (flag)
					{
						this.Limits = new FloatRange();
					}
					input.ReadMessage(this.Limits);
				}
			}
		}

		// Token: 0x040028EC RID: 10476
		private static readonly MessageParser<FloatFieldRestriction> _parser = new MessageParser<FloatFieldRestriction>(() => new FloatFieldRestriction());

		// Token: 0x040028ED RID: 10477
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028EE RID: 10478
		public const int LimitsFieldNumber = 1;

		// Token: 0x040028EF RID: 10479
		private FloatRange limits_;

		// Token: 0x040028F0 RID: 10480
		public const int ExcludeFieldNumber = 2;

		// Token: 0x040028F1 RID: 10481
		private static readonly FieldCodec<float> _repeated_exclude_codec = FieldCodec.ForFloat(21U);

		// Token: 0x040028F2 RID: 10482
		private readonly RepeatedField<float> exclude_ = new RepeatedField<float>();
	}
}
