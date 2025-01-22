using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000373 RID: 883
	public sealed class SignedIntRange : IMessage<SignedIntRange>, IMessage, IEquatable<SignedIntRange>, IDeepCloneable<SignedIntRange>, IBufferMessage
	{
		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06005A8E RID: 23182 RVA: 0x0015E674 File Offset: 0x0015C874
		[DebuggerNonUserCode]
		public static MessageParser<SignedIntRange> Parser
		{
			get
			{
				return SignedIntRange._parser;
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06005A8F RID: 23183 RVA: 0x0015E68C File Offset: 0x0015C88C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RangeReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x0015E6B0 File Offset: 0x0015C8B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignedIntRange.Descriptor;
			}
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x0015E6C7 File Offset: 0x0015C8C7
		[DebuggerNonUserCode]
		public SignedIntRange()
		{
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x0015E6D1 File Offset: 0x0015C8D1
		[DebuggerNonUserCode]
		public SignedIntRange(SignedIntRange other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.min_ = other.min_;
			this.max_ = other.max_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x0015E710 File Offset: 0x0015C910
		[DebuggerNonUserCode]
		public SignedIntRange Clone()
		{
			return new SignedIntRange(this);
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06005A94 RID: 23188 RVA: 0x0015E728 File Offset: 0x0015C928
		// (set) Token: 0x06005A95 RID: 23189 RVA: 0x0015E759 File Offset: 0x0015C959
		[DebuggerNonUserCode]
		public long Min
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long minDefaultValue;
				if (flag)
				{
					minDefaultValue = this.min_;
				}
				else
				{
					minDefaultValue = SignedIntRange.MinDefaultValue;
				}
				return minDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.min_ = value;
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x0015E774 File Offset: 0x0015C974
		[DebuggerNonUserCode]
		public bool HasMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x0015E791 File Offset: 0x0015C991
		[DebuggerNonUserCode]
		public void ClearMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x0015E7A4 File Offset: 0x0015C9A4
		// (set) Token: 0x06005A99 RID: 23193 RVA: 0x0015E7D5 File Offset: 0x0015C9D5
		[DebuggerNonUserCode]
		public long Max
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				long maxDefaultValue;
				if (flag)
				{
					maxDefaultValue = this.max_;
				}
				else
				{
					maxDefaultValue = SignedIntRange.MaxDefaultValue;
				}
				return maxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.max_ = value;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x0015E7F0 File Offset: 0x0015C9F0
		[DebuggerNonUserCode]
		public bool HasMax
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x0015E80D File Offset: 0x0015CA0D
		[DebuggerNonUserCode]
		public void ClearMax()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x0015E820 File Offset: 0x0015CA20
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignedIntRange);
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x0015E840 File Offset: 0x0015CA40
		[DebuggerNonUserCode]
		public bool Equals(SignedIntRange other)
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

		// Token: 0x06005A9E RID: 23198 RVA: 0x0015E8B4 File Offset: 0x0015CAB4
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

		// Token: 0x06005A9F RID: 23199 RVA: 0x0015E920 File Offset: 0x0015CB20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005AA0 RID: 23200 RVA: 0x0015E938 File Offset: 0x0015CB38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x0015E944 File Offset: 0x0015CB44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Max);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x0015E9B4 File Offset: 0x0015CBB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Max);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x0015EA20 File Offset: 0x0015CC20
		[DebuggerNonUserCode]
		public void MergeFrom(SignedIntRange other)
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

		// Token: 0x06005AA4 RID: 23204 RVA: 0x0015EA82 File Offset: 0x0015CC82
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x0015EA90 File Offset: 0x0015CC90
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
						this.Max = input.ReadInt64();
					}
				}
				else
				{
					this.Min = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400293E RID: 10558
		private static readonly MessageParser<SignedIntRange> _parser = new MessageParser<SignedIntRange>(() => new SignedIntRange());

		// Token: 0x0400293F RID: 10559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002940 RID: 10560
		private int _hasBits0;

		// Token: 0x04002941 RID: 10561
		public const int MinFieldNumber = 1;

		// Token: 0x04002942 RID: 10562
		private static readonly long MinDefaultValue = 0L;

		// Token: 0x04002943 RID: 10563
		private long min_;

		// Token: 0x04002944 RID: 10564
		public const int MaxFieldNumber = 2;

		// Token: 0x04002945 RID: 10565
		private static readonly long MaxDefaultValue = 0L;

		// Token: 0x04002946 RID: 10566
		private long max_;
	}
}
