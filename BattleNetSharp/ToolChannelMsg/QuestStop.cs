using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000BF RID: 191
	public sealed class QuestStop : IMessage<QuestStop>, IMessage, IEquatable<QuestStop>, IDeepCloneable<QuestStop>, IBufferMessage
	{
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000422B4 File Offset: 0x000404B4
		[DebuggerNonUserCode]
		public static MessageParser<QuestStop> Parser
		{
			get
			{
				return QuestStop._parser;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x000422CC File Offset: 0x000404CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[168];
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000422F4 File Offset: 0x000404F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestStop.Descriptor;
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0004230B File Offset: 0x0004050B
		[DebuggerNonUserCode]
		public QuestStop()
		{
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00042315 File Offset: 0x00040515
		[DebuggerNonUserCode]
		public QuestStop(QuestStop other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoQuest_ = other.snoQuest_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00042348 File Offset: 0x00040548
		[DebuggerNonUserCode]
		public QuestStop Clone()
		{
			return new QuestStop(this);
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x00042360 File Offset: 0x00040560
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x00042391 File Offset: 0x00040591
		[DebuggerNonUserCode]
		public int SnoQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoQuestDefaultValue;
				if (flag)
				{
					snoQuestDefaultValue = this.snoQuest_;
				}
				else
				{
					snoQuestDefaultValue = QuestStop.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000423AC File Offset: 0x000405AC
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000423C9 File Offset: 0x000405C9
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000423DC File Offset: 0x000405DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestStop);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000423FC File Offset: 0x000405FC
		[DebuggerNonUserCode]
		public bool Equals(QuestStop other)
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
					bool flag4 = this.SnoQuest != other.SnoQuest;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00042454 File Offset: 0x00040654
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000424A4 File Offset: 0x000406A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000424BC File Offset: 0x000406BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000424C8 File Offset: 0x000406C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoQuest);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00042514 File Offset: 0x00040714
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoQuest);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00042564 File Offset: 0x00040764
		[DebuggerNonUserCode]
		public void MergeFrom(QuestStop other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000425AD File Offset: 0x000407AD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000425B8 File Offset: 0x000407B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoQuest = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400073F RID: 1855
		private static readonly MessageParser<QuestStop> _parser = new MessageParser<QuestStop>(() => new QuestStop());

		// Token: 0x04000740 RID: 1856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000741 RID: 1857
		private int _hasBits0;

		// Token: 0x04000742 RID: 1858
		public const int SnoQuestFieldNumber = 1;

		// Token: 0x04000743 RID: 1859
		private static readonly int SnoQuestDefaultValue = 0;

		// Token: 0x04000744 RID: 1860
		private int snoQuest_;
	}
}
