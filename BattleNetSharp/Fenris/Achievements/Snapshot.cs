using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Achievements
{
	// Token: 0x020002C5 RID: 709
	public sealed class Snapshot : IMessage<Snapshot>, IMessage, IEquatable<Snapshot>, IDeepCloneable<Snapshot>, IBufferMessage
	{
		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x00120810 File Offset: 0x0011EA10
		[DebuggerNonUserCode]
		public static MessageParser<Snapshot> Parser
		{
			get
			{
				return Snapshot._parser;
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x00120828 File Offset: 0x0011EA28
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AchievementsReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06004B5A RID: 19290 RVA: 0x0012084C File Offset: 0x0011EA4C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Snapshot.Descriptor;
			}
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00120863 File Offset: 0x0011EA63
		[DebuggerNonUserCode]
		public Snapshot()
		{
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00120884 File Offset: 0x0011EA84
		[DebuggerNonUserCode]
		public Snapshot(Snapshot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.achievement_ = other.achievement_.Clone();
			this.criteria_ = other.criteria_.Clone();
			this.timeStamp_ = other.timeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x001208E4 File Offset: 0x0011EAE4
		[DebuggerNonUserCode]
		public Snapshot Clone()
		{
			return new Snapshot(this);
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004B5E RID: 19294 RVA: 0x001208FC File Offset: 0x0011EAFC
		[DebuggerNonUserCode]
		public RepeatedField<Achievement> Achievement
		{
			get
			{
				return this.achievement_;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x00120914 File Offset: 0x0011EB14
		[DebuggerNonUserCode]
		public RepeatedField<Criteria> Criteria
		{
			get
			{
				return this.criteria_;
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06004B60 RID: 19296 RVA: 0x0012092C File Offset: 0x0011EB2C
		// (set) Token: 0x06004B61 RID: 19297 RVA: 0x0012095D File Offset: 0x0011EB5D
		[DebuggerNonUserCode]
		public long TimeStamp
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long timeStampDefaultValue;
				if (flag)
				{
					timeStampDefaultValue = this.timeStamp_;
				}
				else
				{
					timeStampDefaultValue = Snapshot.TimeStampDefaultValue;
				}
				return timeStampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.timeStamp_ = value;
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x00120978 File Offset: 0x0011EB78
		[DebuggerNonUserCode]
		public bool HasTimeStamp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00120995 File Offset: 0x0011EB95
		[DebuggerNonUserCode]
		public void ClearTimeStamp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x001209A8 File Offset: 0x0011EBA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Snapshot);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x001209C8 File Offset: 0x0011EBC8
		[DebuggerNonUserCode]
		public bool Equals(Snapshot other)
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
					bool flag4 = !this.achievement_.Equals(other.achievement_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.criteria_.Equals(other.criteria_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TimeStamp != other.TimeStamp;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x00120A5C File Offset: 0x0011EC5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.achievement_.GetHashCode();
			num ^= this.criteria_.GetHashCode();
			bool hasTimeStamp = this.HasTimeStamp;
			if (hasTimeStamp)
			{
				num ^= this.TimeStamp.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00120AC8 File Offset: 0x0011ECC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00120AE0 File Offset: 0x0011ECE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x00120AEC File Offset: 0x0011ECEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.achievement_.WriteTo(ref output, Snapshot._repeated_achievement_codec);
			this.criteria_.WriteTo(ref output, Snapshot._repeated_criteria_codec);
			bool hasTimeStamp = this.HasTimeStamp;
			if (hasTimeStamp)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TimeStamp);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x00120B5C File Offset: 0x0011ED5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.achievement_.CalculateSize(Snapshot._repeated_achievement_codec);
			num += this.criteria_.CalculateSize(Snapshot._repeated_criteria_codec);
			bool hasTimeStamp = this.HasTimeStamp;
			if (hasTimeStamp)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimeStamp);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x00120BD0 File Offset: 0x0011EDD0
		[DebuggerNonUserCode]
		public void MergeFrom(Snapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.achievement_.Add(other.achievement_);
				this.criteria_.Add(other.criteria_);
				bool hasTimeStamp = other.HasTimeStamp;
				if (hasTimeStamp)
				{
					this.TimeStamp = other.TimeStamp;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x00120C3D File Offset: 0x0011EE3D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x00120C48 File Offset: 0x0011EE48
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TimeStamp = input.ReadInt64();
						}
					}
					else
					{
						this.criteria_.AddEntriesFrom(ref input, Snapshot._repeated_criteria_codec);
					}
				}
				else
				{
					this.achievement_.AddEntriesFrom(ref input, Snapshot._repeated_achievement_codec);
				}
			}
		}

		// Token: 0x040021A4 RID: 8612
		private static readonly MessageParser<Snapshot> _parser = new MessageParser<Snapshot>(() => new Snapshot());

		// Token: 0x040021A5 RID: 8613
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021A6 RID: 8614
		private int _hasBits0;

		// Token: 0x040021A7 RID: 8615
		public const int AchievementFieldNumber = 1;

		// Token: 0x040021A8 RID: 8616
		private static readonly FieldCodec<Achievement> _repeated_achievement_codec = FieldCodec.ForMessage<Achievement>(10U, Fenris.Achievements.Achievement.Parser);

		// Token: 0x040021A9 RID: 8617
		private readonly RepeatedField<Achievement> achievement_ = new RepeatedField<Achievement>();

		// Token: 0x040021AA RID: 8618
		public const int CriteriaFieldNumber = 2;

		// Token: 0x040021AB RID: 8619
		private static readonly FieldCodec<Criteria> _repeated_criteria_codec = FieldCodec.ForMessage<Criteria>(18U, Fenris.Achievements.Criteria.Parser);

		// Token: 0x040021AC RID: 8620
		private readonly RepeatedField<Criteria> criteria_ = new RepeatedField<Criteria>();

		// Token: 0x040021AD RID: 8621
		public const int TimeStampFieldNumber = 3;

		// Token: 0x040021AE RID: 8622
		private static readonly long TimeStampDefaultValue = 0L;

		// Token: 0x040021AF RID: 8623
		private long timeStamp_;
	}
}
