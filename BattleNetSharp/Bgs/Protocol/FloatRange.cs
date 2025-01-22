using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000374 RID: 884
	public sealed class FloatRange : IMessage<FloatRange>, IMessage, IEquatable<FloatRange>, IDeepCloneable<FloatRange>, IBufferMessage
	{
		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x0015EB20 File Offset: 0x0015CD20
		[DebuggerNonUserCode]
		public static MessageParser<FloatRange> Parser
		{
			get
			{
				return FloatRange._parser;
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x0015EB38 File Offset: 0x0015CD38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RangeReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x0015EB5C File Offset: 0x0015CD5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloatRange.Descriptor;
			}
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x0015EB73 File Offset: 0x0015CD73
		[DebuggerNonUserCode]
		public FloatRange()
		{
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x0015EB7D File Offset: 0x0015CD7D
		[DebuggerNonUserCode]
		public FloatRange(FloatRange other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.min_ = other.min_;
			this.max_ = other.max_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x0015EBBC File Offset: 0x0015CDBC
		[DebuggerNonUserCode]
		public FloatRange Clone()
		{
			return new FloatRange(this);
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x0015EBD4 File Offset: 0x0015CDD4
		// (set) Token: 0x06005AAE RID: 23214 RVA: 0x0015EC05 File Offset: 0x0015CE05
		[DebuggerNonUserCode]
		public float Min
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float minDefaultValue;
				if (flag)
				{
					minDefaultValue = this.min_;
				}
				else
				{
					minDefaultValue = FloatRange.MinDefaultValue;
				}
				return minDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.min_ = value;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x0015EC20 File Offset: 0x0015CE20
		[DebuggerNonUserCode]
		public bool HasMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x0015EC3D File Offset: 0x0015CE3D
		[DebuggerNonUserCode]
		public void ClearMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x0015EC50 File Offset: 0x0015CE50
		// (set) Token: 0x06005AB2 RID: 23218 RVA: 0x0015EC81 File Offset: 0x0015CE81
		[DebuggerNonUserCode]
		public float Max
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float maxDefaultValue;
				if (flag)
				{
					maxDefaultValue = this.max_;
				}
				else
				{
					maxDefaultValue = FloatRange.MaxDefaultValue;
				}
				return maxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.max_ = value;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x0015EC9C File Offset: 0x0015CE9C
		[DebuggerNonUserCode]
		public bool HasMax
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x0015ECB9 File Offset: 0x0015CEB9
		[DebuggerNonUserCode]
		public void ClearMax()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x0015ECCC File Offset: 0x0015CECC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloatRange);
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x0015ECEC File Offset: 0x0015CEEC
		[DebuggerNonUserCode]
		public bool Equals(FloatRange other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Min, other.Min);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Max, other.Max);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x0015ED70 File Offset: 0x0015CF70
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Max);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x0015EDE0 File Offset: 0x0015CFE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x0015EDF8 File Offset: 0x0015CFF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x0015EE04 File Offset: 0x0015D004
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Min);
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Max);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x0015EE74 File Offset: 0x0015D074
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMin = this.HasMin;
			if (hasMin)
			{
				num += 5;
			}
			bool hasMax = this.HasMax;
			if (hasMax)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x0015EEC8 File Offset: 0x0015D0C8
		[DebuggerNonUserCode]
		public void MergeFrom(FloatRange other)
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

		// Token: 0x06005ABD RID: 23229 RVA: 0x0015EF2A File Offset: 0x0015D12A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x0015EF38 File Offset: 0x0015D138
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Max = input.ReadFloat();
					}
				}
				else
				{
					this.Min = input.ReadFloat();
				}
			}
		}

		// Token: 0x04002947 RID: 10567
		private static readonly MessageParser<FloatRange> _parser = new MessageParser<FloatRange>(() => new FloatRange());

		// Token: 0x04002948 RID: 10568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002949 RID: 10569
		private int _hasBits0;

		// Token: 0x0400294A RID: 10570
		public const int MinFieldNumber = 1;

		// Token: 0x0400294B RID: 10571
		private static readonly float MinDefaultValue = 0f;

		// Token: 0x0400294C RID: 10572
		private float min_;

		// Token: 0x0400294D RID: 10573
		public const int MaxFieldNumber = 2;

		// Token: 0x0400294E RID: 10574
		private static readonly float MaxDefaultValue = 0f;

		// Token: 0x0400294F RID: 10575
		private float max_;
	}
}
