using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000366 RID: 870
	public sealed class UnsignedFieldRestriction : IMessage<UnsignedFieldRestriction>, IMessage, IEquatable<UnsignedFieldRestriction>, IDeepCloneable<UnsignedFieldRestriction>, IBufferMessage
	{
		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x060059B5 RID: 22965 RVA: 0x0015B7EC File Offset: 0x001599EC
		[DebuggerNonUserCode]
		public static MessageParser<UnsignedFieldRestriction> Parser
		{
			get
			{
				return UnsignedFieldRestriction._parser;
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x060059B6 RID: 22966 RVA: 0x0015B804 File Offset: 0x00159A04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x0015B828 File Offset: 0x00159A28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsignedFieldRestriction.Descriptor;
			}
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x0015B83F File Offset: 0x00159A3F
		[DebuggerNonUserCode]
		public UnsignedFieldRestriction()
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x0015B854 File Offset: 0x00159A54
		[DebuggerNonUserCode]
		public UnsignedFieldRestriction(UnsignedFieldRestriction other)
			: this()
		{
			this.limits_ = ((other.limits_ != null) ? other.limits_.Clone() : null);
			this.exclude_ = other.exclude_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x0015B8A8 File Offset: 0x00159AA8
		[DebuggerNonUserCode]
		public UnsignedFieldRestriction Clone()
		{
			return new UnsignedFieldRestriction(this);
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x060059BB RID: 22971 RVA: 0x0015B8C0 File Offset: 0x00159AC0
		// (set) Token: 0x060059BC RID: 22972 RVA: 0x0015B8D8 File Offset: 0x00159AD8
		[DebuggerNonUserCode]
		public UnsignedIntRange Limits
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

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x060059BD RID: 22973 RVA: 0x0015B8E4 File Offset: 0x00159AE4
		[DebuggerNonUserCode]
		public RepeatedField<ulong> Exclude
		{
			get
			{
				return this.exclude_;
			}
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x0015B8FC File Offset: 0x00159AFC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsignedFieldRestriction);
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x0015B91C File Offset: 0x00159B1C
		[DebuggerNonUserCode]
		public bool Equals(UnsignedFieldRestriction other)
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

		// Token: 0x060059C0 RID: 22976 RVA: 0x0015B994 File Offset: 0x00159B94
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

		// Token: 0x060059C1 RID: 22977 RVA: 0x0015B9F0 File Offset: 0x00159BF0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x0015BA08 File Offset: 0x00159C08
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x0015BA14 File Offset: 0x00159C14
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.limits_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Limits);
			}
			this.exclude_.WriteTo(ref output, UnsignedFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x0015BA78 File Offset: 0x00159C78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.limits_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Limits);
			}
			num += this.exclude_.CalculateSize(UnsignedFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x0015BADC File Offset: 0x00159CDC
		[DebuggerNonUserCode]
		public void MergeFrom(UnsignedFieldRestriction other)
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
						this.Limits = new UnsignedIntRange();
					}
					this.Limits.MergeFrom(other.Limits);
				}
				this.exclude_.Add(other.exclude_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x0015BB5A File Offset: 0x00159D5A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x0015BB68 File Offset: 0x00159D68
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
						this.exclude_.AddEntriesFrom(ref input, UnsignedFieldRestriction._repeated_exclude_codec);
					}
				}
				else
				{
					bool flag = this.limits_ == null;
					if (flag)
					{
						this.Limits = new UnsignedIntRange();
					}
					input.ReadMessage(this.Limits);
				}
			}
		}

		// Token: 0x040028E5 RID: 10469
		private static readonly MessageParser<UnsignedFieldRestriction> _parser = new MessageParser<UnsignedFieldRestriction>(() => new UnsignedFieldRestriction());

		// Token: 0x040028E6 RID: 10470
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028E7 RID: 10471
		public const int LimitsFieldNumber = 1;

		// Token: 0x040028E8 RID: 10472
		private UnsignedIntRange limits_;

		// Token: 0x040028E9 RID: 10473
		public const int ExcludeFieldNumber = 2;

		// Token: 0x040028EA RID: 10474
		private static readonly FieldCodec<ulong> _repeated_exclude_codec = FieldCodec.ForUInt64(16U);

		// Token: 0x040028EB RID: 10475
		private readonly RepeatedField<ulong> exclude_ = new RepeatedField<ulong>();
	}
}
