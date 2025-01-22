using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200034D RID: 845
	public sealed class AttributeFilter : IMessage<AttributeFilter>, IMessage, IEquatable<AttributeFilter>, IDeepCloneable<AttributeFilter>, IBufferMessage
	{
		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x060057E2 RID: 22498 RVA: 0x00154304 File Offset: 0x00152504
		[DebuggerNonUserCode]
		public static MessageParser<AttributeFilter> Parser
		{
			get
			{
				return AttributeFilter._parser;
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x0015431C File Offset: 0x0015251C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AttributeTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x060057E4 RID: 22500 RVA: 0x00154340 File Offset: 0x00152540
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeFilter.Descriptor;
			}
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x00154357 File Offset: 0x00152557
		[DebuggerNonUserCode]
		public AttributeFilter()
		{
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x0015436C File Offset: 0x0015256C
		[DebuggerNonUserCode]
		public AttributeFilter(AttributeFilter other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.op_ = other.op_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x001543BC File Offset: 0x001525BC
		[DebuggerNonUserCode]
		public AttributeFilter Clone()
		{
			return new AttributeFilter(this);
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x060057E8 RID: 22504 RVA: 0x001543D4 File Offset: 0x001525D4
		// (set) Token: 0x060057E9 RID: 22505 RVA: 0x00154405 File Offset: 0x00152605
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

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x060057EA RID: 22506 RVA: 0x00154420 File Offset: 0x00152620
		[DebuggerNonUserCode]
		public bool HasOp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x0015443D File Offset: 0x0015263D
		[DebuggerNonUserCode]
		public void ClearOp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x00154450 File Offset: 0x00152650
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00154468 File Offset: 0x00152668
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeFilter);
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00154488 File Offset: 0x00152688
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

		// Token: 0x060057EF RID: 22511 RVA: 0x001544FC File Offset: 0x001526FC
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

		// Token: 0x060057F0 RID: 22512 RVA: 0x00154560 File Offset: 0x00152760
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x00154578 File Offset: 0x00152778
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x00154584 File Offset: 0x00152784
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

		// Token: 0x060057F3 RID: 22515 RVA: 0x001545E4 File Offset: 0x001527E4
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

		// Token: 0x060057F4 RID: 22516 RVA: 0x00154648 File Offset: 0x00152848
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

		// Token: 0x060057F5 RID: 22517 RVA: 0x001546A3 File Offset: 0x001528A3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x001546B0 File Offset: 0x001528B0
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

		// Token: 0x04002821 RID: 10273
		private static readonly MessageParser<AttributeFilter> _parser = new MessageParser<AttributeFilter>(() => new AttributeFilter());

		// Token: 0x04002822 RID: 10274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002823 RID: 10275
		private int _hasBits0;

		// Token: 0x04002824 RID: 10276
		public const int OpFieldNumber = 1;

		// Token: 0x04002825 RID: 10277
		private static readonly AttributeFilter.Types.Operation OpDefaultValue = AttributeFilter.Types.Operation.MatchNone;

		// Token: 0x04002826 RID: 10278
		private AttributeFilter.Types.Operation op_;

		// Token: 0x04002827 RID: 10279
		public const int AttributeFieldNumber = 2;

		// Token: 0x04002828 RID: 10280
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04002829 RID: 10281
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x02000E32 RID: 3634
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001492 RID: 5266
			public enum Operation
			{
				// Token: 0x0400A4DF RID: 42207
				[OriginalName("MATCH_NONE")]
				MatchNone,
				// Token: 0x0400A4E0 RID: 42208
				[OriginalName("MATCH_ANY")]
				MatchAny,
				// Token: 0x0400A4E1 RID: 42209
				[OriginalName("MATCH_ALL")]
				MatchAll,
				// Token: 0x0400A4E2 RID: 42210
				[OriginalName("MATCH_ALL_MOST_SPECIFIC")]
				MatchAllMostSpecific
			}
		}
	}
}
