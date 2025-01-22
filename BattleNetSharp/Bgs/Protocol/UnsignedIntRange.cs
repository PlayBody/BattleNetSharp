using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000372 RID: 882
	public sealed class UnsignedIntRange : IMessage<UnsignedIntRange>, IMessage, IEquatable<UnsignedIntRange>, IDeepCloneable<UnsignedIntRange>, IBufferMessage
	{
		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06005A75 RID: 23157 RVA: 0x0015E1C8 File Offset: 0x0015C3C8
		[DebuggerNonUserCode]
		public static MessageParser<UnsignedIntRange> Parser
		{
			get
			{
				return UnsignedIntRange._parser;
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06005A76 RID: 23158 RVA: 0x0015E1E0 File Offset: 0x0015C3E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RangeReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06005A77 RID: 23159 RVA: 0x0015E204 File Offset: 0x0015C404
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsignedIntRange.Descriptor;
			}
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x0015E21B File Offset: 0x0015C41B
		[DebuggerNonUserCode]
		public UnsignedIntRange()
		{
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x0015E225 File Offset: 0x0015C425
		[DebuggerNonUserCode]
		public UnsignedIntRange(UnsignedIntRange other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.min_ = other.min_;
			this.max_ = other.max_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x0015E264 File Offset: 0x0015C464
		[DebuggerNonUserCode]
		public UnsignedIntRange Clone()
		{
			return new UnsignedIntRange(this);
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06005A7B RID: 23163 RVA: 0x0015E27C File Offset: 0x0015C47C
		// (set) Token: 0x06005A7C RID: 23164 RVA: 0x0015E2AD File Offset: 0x0015C4AD
		[DebuggerNonUserCode]
		public ulong Min
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong minDefaultValue;
				if (flag)
				{
					minDefaultValue = this.min_;
				}
				else
				{
					minDefaultValue = UnsignedIntRange.MinDefaultValue;
				}
				return minDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.min_ = value;
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06005A7D RID: 23165 RVA: 0x0015E2C8 File Offset: 0x0015C4C8
		[DebuggerNonUserCode]
		public bool HasMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x0015E2E5 File Offset: 0x0015C4E5
		[DebuggerNonUserCode]
		public void ClearMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06005A7F RID: 23167 RVA: 0x0015E2F8 File Offset: 0x0015C4F8
		// (set) Token: 0x06005A80 RID: 23168 RVA: 0x0015E329 File Offset: 0x0015C529
		[DebuggerNonUserCode]
		public ulong Max
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong maxDefaultValue;
				if (flag)
				{
					maxDefaultValue = this.max_;
				}
				else
				{
					maxDefaultValue = UnsignedIntRange.MaxDefaultValue;
				}
				return maxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.max_ = value;
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06005A81 RID: 23169 RVA: 0x0015E344 File Offset: 0x0015C544
		[DebuggerNonUserCode]
		public bool HasMax
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x0015E361 File Offset: 0x0015C561
		[DebuggerNonUserCode]
		public void ClearMax()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x0015E374 File Offset: 0x0015C574
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsignedIntRange);
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x0015E394 File Offset: 0x0015C594
		[DebuggerNonUserCode]
		public bool Equals(UnsignedIntRange other)
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
					bool flag4 = this.Min != other.Min;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Max != other.Max;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x0015E408 File Offset: 0x0015C608
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				num ^= this.Min.GetHashCode();
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				num ^= this.Max.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x0015E474 File Offset: 0x0015C674
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x0015E48C File Offset: 0x0015C68C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x0015E498 File Offset: 0x0015C698
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Max);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x0015E508 File Offset: 0x0015C708
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Max);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x0015E574 File Offset: 0x0015C774
		[DebuggerNonUserCode]
		public void MergeFrom(UnsignedIntRange other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMin = other.HasMin;
				if (hasMin)
				{
					this.Min = other.Min;
				}
				bool hasMax = other.HasMax;
				if (hasMax)
				{
					this.Max = other.Max;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x0015E5D6 File Offset: 0x0015C7D6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x0015E5E4 File Offset: 0x0015C7E4
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Max = input.ReadUInt64();
					}
				}
				else
				{
					this.Min = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04002935 RID: 10549
		private static readonly MessageParser<UnsignedIntRange> _parser = new MessageParser<UnsignedIntRange>(() => new UnsignedIntRange());

		// Token: 0x04002936 RID: 10550
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002937 RID: 10551
		private int _hasBits0;

		// Token: 0x04002938 RID: 10552
		public const int MinFieldNumber = 1;

		// Token: 0x04002939 RID: 10553
		private static readonly ulong MinDefaultValue = 0UL;

		// Token: 0x0400293A RID: 10554
		private ulong min_;

		// Token: 0x0400293B RID: 10555
		public const int MaxFieldNumber = 2;

		// Token: 0x0400293C RID: 10556
		private static readonly ulong MaxDefaultValue = 0UL;

		// Token: 0x0400293D RID: 10557
		private ulong max_;
	}
}
