using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.V2
{
	// Token: 0x0200062D RID: 1581
	public sealed class AttributeFilter : IMessage<AttributeFilter>, IMessage, IEquatable<AttributeFilter>, IDeepCloneable<AttributeFilter>, IBufferMessage
	{
		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x060093AC RID: 37804 RVA: 0x0023C3C4 File Offset: 0x0023A5C4
		[DebuggerNonUserCode]
		public static MessageParser<AttributeFilter> Parser
		{
			get
			{
				return AttributeFilter._parser;
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x060093AD RID: 37805 RVA: 0x0023C3DC File Offset: 0x0023A5DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x060093AE RID: 37806 RVA: 0x0023C400 File Offset: 0x0023A600
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeFilter.Descriptor;
			}
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x0023C417 File Offset: 0x0023A617
		[DebuggerNonUserCode]
		public AttributeFilter()
		{
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x0023C42C File Offset: 0x0023A62C
		[DebuggerNonUserCode]
		public AttributeFilter(AttributeFilter other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.op_ = other.op_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x0023C47C File Offset: 0x0023A67C
		[DebuggerNonUserCode]
		public AttributeFilter Clone()
		{
			return new AttributeFilter(this);
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x060093B2 RID: 37810 RVA: 0x0023C494 File Offset: 0x0023A694
		// (set) Token: 0x060093B3 RID: 37811 RVA: 0x0023C4C5 File Offset: 0x0023A6C5
		[DebuggerNonUserCode]
		public AttributeFilter.Types.Operation Op
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				AttributeFilter.Types.Operation opDefaultValue;
				if (flag)
				{
					opDefaultValue = this.op_;
				}
				else
				{
					opDefaultValue = AttributeFilter.OpDefaultValue;
				}
				return opDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.op_ = value;
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x060093B4 RID: 37812 RVA: 0x0023C4E0 File Offset: 0x0023A6E0
		[DebuggerNonUserCode]
		public bool HasOp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x0023C4FD File Offset: 0x0023A6FD
		[DebuggerNonUserCode]
		public void ClearOp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x060093B6 RID: 37814 RVA: 0x0023C510 File Offset: 0x0023A710
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x0023C528 File Offset: 0x0023A728
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeFilter);
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x0023C548 File Offset: 0x0023A748
		[DebuggerNonUserCode]
		public bool Equals(AttributeFilter other)
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
					bool flag4 = this.Op != other.Op;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x0023C5BC File Offset: 0x0023A7BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOp = this.HasOp;
			if (hasOp)
			{
				num ^= this.Op.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x0023C620 File Offset: 0x0023A820
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x0023C638 File Offset: 0x0023A838
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x0023C644 File Offset: 0x0023A844
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOp = this.HasOp;
			if (hasOp)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Op);
			}
			this.attribute_.WriteTo(ref output, AttributeFilter._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x0023C6A4 File Offset: 0x0023A8A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOp = this.HasOp;
			if (hasOp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Op);
			}
			num += this.attribute_.CalculateSize(AttributeFilter._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x0023C708 File Offset: 0x0023A908
		[DebuggerNonUserCode]
		public void MergeFrom(AttributeFilter other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOp = other.HasOp;
				if (hasOp)
				{
					this.Op = other.Op;
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x0023C763 File Offset: 0x0023A963
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x0023C770 File Offset: 0x0023A970
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, AttributeFilter._repeated_attribute_codec);
					}
				}
				else
				{
					this.Op = (AttributeFilter.Types.Operation)input.ReadEnum();
				}
			}
		}

		// Token: 0x040042A3 RID: 17059
		private static readonly MessageParser<AttributeFilter> _parser = new MessageParser<AttributeFilter>(() => new AttributeFilter());

		// Token: 0x040042A4 RID: 17060
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042A5 RID: 17061
		private int _hasBits0;

		// Token: 0x040042A6 RID: 17062
		public const int OpFieldNumber = 1;

		// Token: 0x040042A7 RID: 17063
		private static readonly AttributeFilter.Types.Operation OpDefaultValue = AttributeFilter.Types.Operation.MatchNone;

		// Token: 0x040042A8 RID: 17064
		private AttributeFilter.Types.Operation op_;

		// Token: 0x040042A9 RID: 17065
		public const int AttributeFieldNumber = 2;

		// Token: 0x040042AA RID: 17066
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040042AB RID: 17067
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x02001122 RID: 4386
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001498 RID: 5272
			public enum Operation
			{
				// Token: 0x0400A4FD RID: 42237
				[OriginalName("MATCH_NONE")]
				MatchNone,
				// Token: 0x0400A4FE RID: 42238
				[OriginalName("MATCH_ANY")]
				MatchAny,
				// Token: 0x0400A4FF RID: 42239
				[OriginalName("MATCH_ALL")]
				MatchAll,
				// Token: 0x0400A500 RID: 42240
				[OriginalName("MATCH_ALL_MOST_SPECIFIC")]
				MatchAllMostSpecific
			}
		}
	}
}
