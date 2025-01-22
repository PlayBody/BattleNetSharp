using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000651 RID: 1617
	public sealed class Score : IMessage<Score>, IMessage, IEquatable<Score>, IDeepCloneable<Score>, IBufferMessage
	{
		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x06009637 RID: 38455 RVA: 0x00244F3C File Offset: 0x0024313C
		[DebuggerNonUserCode]
		public static MessageParser<Score> Parser
		{
			get
			{
				return Score._parser;
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x06009638 RID: 38456 RVA: 0x00244F54 File Offset: 0x00243154
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x06009639 RID: 38457 RVA: 0x00244F78 File Offset: 0x00243178
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Score.Descriptor;
			}
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x00244F8F File Offset: 0x0024318F
		[DebuggerNonUserCode]
		public Score()
		{
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x00244F99 File Offset: 0x00243199
		[DebuggerNonUserCode]
		public Score(Score other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = other.type_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x00244FD8 File Offset: 0x002431D8
		[DebuggerNonUserCode]
		public Score Clone()
		{
			return new Score(this);
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600963D RID: 38461 RVA: 0x00244FF0 File Offset: 0x002431F0
		// (set) Token: 0x0600963E RID: 38462 RVA: 0x00245011 File Offset: 0x00243211
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? Score.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0600963F RID: 38463 RVA: 0x00245028 File Offset: 0x00243228
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x00245043 File Offset: 0x00243243
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x06009641 RID: 38465 RVA: 0x00245050 File Offset: 0x00243250
		// (set) Token: 0x06009642 RID: 38466 RVA: 0x00245081 File Offset: 0x00243281
		[DebuggerNonUserCode]
		public double Value
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				double valueDefaultValue;
				if (flag)
				{
					valueDefaultValue = this.value_;
				}
				else
				{
					valueDefaultValue = Score.ValueDefaultValue;
				}
				return valueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.value_ = value;
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x06009643 RID: 38467 RVA: 0x0024509C File Offset: 0x0024329C
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x002450B9 File Offset: 0x002432B9
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x002450CC File Offset: 0x002432CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Score);
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x002450EC File Offset: 0x002432EC
		[DebuggerNonUserCode]
		public bool Equals(Score other)
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
					bool flag4 = this.Type != other.Type;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Value, other.Value);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x00245168 File Offset: 0x00243368
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x002451D4 File Offset: 0x002433D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009649 RID: 38473 RVA: 0x002451EC File Offset: 0x002433EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600964A RID: 38474 RVA: 0x002451F8 File Offset: 0x002433F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Type);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600964B RID: 38475 RVA: 0x00245268 File Offset: 0x00243468
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 9;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x002452CC File Offset: 0x002434CC
		[DebuggerNonUserCode]
		public void MergeFrom(Score other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x0024532E File Offset: 0x0024352E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x0024533C File Offset: 0x0024353C
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
					if (num3 != 17U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadDouble();
					}
				}
				else
				{
					this.Type = input.ReadString();
				}
			}
		}

		// Token: 0x040043A8 RID: 17320
		private static readonly MessageParser<Score> _parser = new MessageParser<Score>(() => new Score());

		// Token: 0x040043A9 RID: 17321
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043AA RID: 17322
		private int _hasBits0;

		// Token: 0x040043AB RID: 17323
		public const int TypeFieldNumber = 1;

		// Token: 0x040043AC RID: 17324
		private static readonly string TypeDefaultValue = "";

		// Token: 0x040043AD RID: 17325
		private string type_;

		// Token: 0x040043AE RID: 17326
		public const int ValueFieldNumber = 2;

		// Token: 0x040043AF RID: 17327
		private static readonly double ValueDefaultValue = 0.0;

		// Token: 0x040043B0 RID: 17328
		private double value_;
	}
}
