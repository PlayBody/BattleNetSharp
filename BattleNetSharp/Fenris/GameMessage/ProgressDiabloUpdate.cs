using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D0 RID: 464
	public sealed class ProgressDiabloUpdate : IMessage<ProgressDiabloUpdate>, IMessage, IEquatable<ProgressDiabloUpdate>, IDeepCloneable<ProgressDiabloUpdate>, IBufferMessage
	{
		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000C4E8C File Offset: 0x000C308C
		[DebuggerNonUserCode]
		public static MessageParser<ProgressDiabloUpdate> Parser
		{
			get
			{
				return ProgressDiabloUpdate._parser;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x000C4EA4 File Offset: 0x000C30A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000C4EC8 File Offset: 0x000C30C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressDiabloUpdate.Descriptor;
			}
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x000C4EDF File Offset: 0x000C30DF
		[DebuggerNonUserCode]
		public ProgressDiabloUpdate()
		{
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x000C4EF4 File Offset: 0x000C30F4
		[DebuggerNonUserCode]
		public ProgressDiabloUpdate(ProgressDiabloUpdate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.events_ = other.events_.Clone();
			this.completedRunCount_ = other.completedRunCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x000C4F44 File Offset: 0x000C3144
		[DebuggerNonUserCode]
		public ProgressDiabloUpdate Clone()
		{
			return new ProgressDiabloUpdate(this);
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x000C4F5C File Offset: 0x000C315C
		[DebuggerNonUserCode]
		public RepeatedField<ProgressDiabloEvent> Events
		{
			get
			{
				return this.events_;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x000C4F74 File Offset: 0x000C3174
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x000C4FA5 File Offset: 0x000C31A5
		[DebuggerNonUserCode]
		public int CompletedRunCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int completedRunCountDefaultValue;
				if (flag)
				{
					completedRunCountDefaultValue = this.completedRunCount_;
				}
				else
				{
					completedRunCountDefaultValue = ProgressDiabloUpdate.CompletedRunCountDefaultValue;
				}
				return completedRunCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.completedRunCount_ = value;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x000C4FC0 File Offset: 0x000C31C0
		[DebuggerNonUserCode]
		public bool HasCompletedRunCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000C4FDD File Offset: 0x000C31DD
		[DebuggerNonUserCode]
		public void ClearCompletedRunCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x000C4FF0 File Offset: 0x000C31F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressDiabloUpdate);
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x000C5010 File Offset: 0x000C3210
		[DebuggerNonUserCode]
		public bool Equals(ProgressDiabloUpdate other)
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
					bool flag4 = !this.events_.Equals(other.events_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CompletedRunCount != other.CompletedRunCount;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000C5084 File Offset: 0x000C3284
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.events_.GetHashCode();
			bool hasCompletedRunCount = this.HasCompletedRunCount;
			if (hasCompletedRunCount)
			{
				num ^= this.CompletedRunCount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x000C50E4 File Offset: 0x000C32E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x000C50FC File Offset: 0x000C32FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x000C5108 File Offset: 0x000C3308
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.events_.WriteTo(ref output, ProgressDiabloUpdate._repeated_events_codec);
			bool hasCompletedRunCount = this.HasCompletedRunCount;
			if (hasCompletedRunCount)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CompletedRunCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x000C5168 File Offset: 0x000C3368
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.events_.CalculateSize(ProgressDiabloUpdate._repeated_events_codec);
			bool hasCompletedRunCount = this.HasCompletedRunCount;
			if (hasCompletedRunCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompletedRunCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000C51CC File Offset: 0x000C33CC
		[DebuggerNonUserCode]
		public void MergeFrom(ProgressDiabloUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.events_.Add(other.events_);
				bool hasCompletedRunCount = other.HasCompletedRunCount;
				if (hasCompletedRunCount)
				{
					this.CompletedRunCount = other.CompletedRunCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x000C5227 File Offset: 0x000C3427
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x000C5234 File Offset: 0x000C3434
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CompletedRunCount = input.ReadInt32();
					}
				}
				else
				{
					this.events_.AddEntriesFrom(ref input, ProgressDiabloUpdate._repeated_events_codec);
				}
			}
		}

		// Token: 0x040016D0 RID: 5840
		private static readonly MessageParser<ProgressDiabloUpdate> _parser = new MessageParser<ProgressDiabloUpdate>(() => new ProgressDiabloUpdate());

		// Token: 0x040016D1 RID: 5841
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016D2 RID: 5842
		private int _hasBits0;

		// Token: 0x040016D3 RID: 5843
		public const int EventsFieldNumber = 1;

		// Token: 0x040016D4 RID: 5844
		private static readonly FieldCodec<ProgressDiabloEvent> _repeated_events_codec = FieldCodec.ForMessage<ProgressDiabloEvent>(10U, ProgressDiabloEvent.Parser);

		// Token: 0x040016D5 RID: 5845
		private readonly RepeatedField<ProgressDiabloEvent> events_ = new RepeatedField<ProgressDiabloEvent>();

		// Token: 0x040016D6 RID: 5846
		public const int CompletedRunCountFieldNumber = 2;

		// Token: 0x040016D7 RID: 5847
		private static readonly int CompletedRunCountDefaultValue = 0;

		// Token: 0x040016D8 RID: 5848
		private int completedRunCount_;
	}
}
