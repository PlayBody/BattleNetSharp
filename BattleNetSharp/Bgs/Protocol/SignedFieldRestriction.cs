using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000365 RID: 869
	public sealed class SignedFieldRestriction : IMessage<SignedFieldRestriction>, IMessage, IEquatable<SignedFieldRestriction>, IDeepCloneable<SignedFieldRestriction>, IBufferMessage
	{
		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x060059A1 RID: 22945 RVA: 0x0015B3B8 File Offset: 0x001595B8
		[DebuggerNonUserCode]
		public static MessageParser<SignedFieldRestriction> Parser
		{
			get
			{
				return SignedFieldRestriction._parser;
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x0015B3D0 File Offset: 0x001595D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x060059A3 RID: 22947 RVA: 0x0015B3F4 File Offset: 0x001595F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignedFieldRestriction.Descriptor;
			}
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x0015B40B File Offset: 0x0015960B
		[DebuggerNonUserCode]
		public SignedFieldRestriction()
		{
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x0015B420 File Offset: 0x00159620
		[DebuggerNonUserCode]
		public SignedFieldRestriction(SignedFieldRestriction other)
			: this()
		{
			this.limits_ = ((other.limits_ != null) ? other.limits_.Clone() : null);
			this.exclude_ = other.exclude_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x0015B474 File Offset: 0x00159674
		[DebuggerNonUserCode]
		public SignedFieldRestriction Clone()
		{
			return new SignedFieldRestriction(this);
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x060059A7 RID: 22951 RVA: 0x0015B48C File Offset: 0x0015968C
		// (set) Token: 0x060059A8 RID: 22952 RVA: 0x0015B4A4 File Offset: 0x001596A4
		[DebuggerNonUserCode]
		public SignedIntRange Limits
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

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x060059A9 RID: 22953 RVA: 0x0015B4B0 File Offset: 0x001596B0
		[DebuggerNonUserCode]
		public RepeatedField<long> Exclude
		{
			get
			{
				return this.exclude_;
			}
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x0015B4C8 File Offset: 0x001596C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignedFieldRestriction);
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x0015B4E8 File Offset: 0x001596E8
		[DebuggerNonUserCode]
		public bool Equals(SignedFieldRestriction other)
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

		// Token: 0x060059AC RID: 22956 RVA: 0x0015B560 File Offset: 0x00159760
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

		// Token: 0x060059AD RID: 22957 RVA: 0x0015B5BC File Offset: 0x001597BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x0015B5D4 File Offset: 0x001597D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x0015B5E0 File Offset: 0x001597E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.limits_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Limits);
			}
			this.exclude_.WriteTo(ref output, SignedFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x0015B644 File Offset: 0x00159844
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.limits_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Limits);
			}
			num += this.exclude_.CalculateSize(SignedFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x0015B6A8 File Offset: 0x001598A8
		[DebuggerNonUserCode]
		public void MergeFrom(SignedFieldRestriction other)
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
						this.Limits = new SignedIntRange();
					}
					this.Limits.MergeFrom(other.Limits);
				}
				this.exclude_.Add(other.exclude_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x0015B726 File Offset: 0x00159926
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x0015B734 File Offset: 0x00159934
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
						this.exclude_.AddEntriesFrom(ref input, SignedFieldRestriction._repeated_exclude_codec);
					}
				}
				else
				{
					bool flag = this.limits_ == null;
					if (flag)
					{
						this.Limits = new SignedIntRange();
					}
					input.ReadMessage(this.Limits);
				}
			}
		}

		// Token: 0x040028DE RID: 10462
		private static readonly MessageParser<SignedFieldRestriction> _parser = new MessageParser<SignedFieldRestriction>(() => new SignedFieldRestriction());

		// Token: 0x040028DF RID: 10463
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E0 RID: 10464
		public const int LimitsFieldNumber = 1;

		// Token: 0x040028E1 RID: 10465
		private SignedIntRange limits_;

		// Token: 0x040028E2 RID: 10466
		public const int ExcludeFieldNumber = 2;

		// Token: 0x040028E3 RID: 10467
		private static readonly FieldCodec<long> _repeated_exclude_codec = FieldCodec.ForSInt64(16U);

		// Token: 0x040028E4 RID: 10468
		private readonly RepeatedField<long> exclude_ = new RepeatedField<long>();
	}
}
