using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000185 RID: 389
	public sealed class CompletedRepeatableQuest : IMessage<CompletedRepeatableQuest>, IMessage, IEquatable<CompletedRepeatableQuest>, IDeepCloneable<CompletedRepeatableQuest>, IBufferMessage
	{
		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x0009F8EC File Offset: 0x0009DAEC
		[DebuggerNonUserCode]
		public static MessageParser<CompletedRepeatableQuest> Parser
		{
			get
			{
				return CompletedRepeatableQuest._parser;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x0009F904 File Offset: 0x0009DB04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x0009F928 File Offset: 0x0009DB28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompletedRepeatableQuest.Descriptor;
			}
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0009F93F File Offset: 0x0009DB3F
		[DebuggerNonUserCode]
		public CompletedRepeatableQuest()
		{
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0009F949 File Offset: 0x0009DB49
		[DebuggerNonUserCode]
		public CompletedRepeatableQuest(CompletedRepeatableQuest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoQuest_ = other.snoQuest_;
			this.lastOccurrence_ = other.lastOccurrence_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0009F988 File Offset: 0x0009DB88
		[DebuggerNonUserCode]
		public CompletedRepeatableQuest Clone()
		{
			return new CompletedRepeatableQuest(this);
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x0009F9A0 File Offset: 0x0009DBA0
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x0009F9D1 File Offset: 0x0009DBD1
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
					snoQuestDefaultValue = CompletedRepeatableQuest.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x0009F9EC File Offset: 0x0009DBEC
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0009FA09 File Offset: 0x0009DC09
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0009FA1C File Offset: 0x0009DC1C
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x0009FA4D File Offset: 0x0009DC4D
		[DebuggerNonUserCode]
		public int LastOccurrence
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int lastOccurrenceDefaultValue;
				if (flag)
				{
					lastOccurrenceDefaultValue = this.lastOccurrence_;
				}
				else
				{
					lastOccurrenceDefaultValue = CompletedRepeatableQuest.LastOccurrenceDefaultValue;
				}
				return lastOccurrenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.lastOccurrence_ = value;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x0009FA68 File Offset: 0x0009DC68
		[DebuggerNonUserCode]
		public bool HasLastOccurrence
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x0009FA85 File Offset: 0x0009DC85
		[DebuggerNonUserCode]
		public void ClearLastOccurrence()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0009FA98 File Offset: 0x0009DC98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompletedRepeatableQuest);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x0009FAB8 File Offset: 0x0009DCB8
		[DebuggerNonUserCode]
		public bool Equals(CompletedRepeatableQuest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LastOccurrence != other.LastOccurrence;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0009FB2C File Offset: 0x0009DD2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			bool hasLastOccurrence = this.HasLastOccurrence;
			if (hasLastOccurrence)
			{
				num ^= this.LastOccurrence.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0009FB98 File Offset: 0x0009DD98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x0009FBB0 File Offset: 0x0009DDB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0009FBBC File Offset: 0x0009DDBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoQuest);
			}
			bool hasLastOccurrence = this.HasLastOccurrence;
			if (hasLastOccurrence)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LastOccurrence);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0009FC2C File Offset: 0x0009DE2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 5;
			}
			bool hasLastOccurrence = this.HasLastOccurrence;
			if (hasLastOccurrence)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastOccurrence);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0009FC8C File Offset: 0x0009DE8C
		[DebuggerNonUserCode]
		public void MergeFrom(CompletedRepeatableQuest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				bool hasLastOccurrence = other.HasLastOccurrence;
				if (hasLastOccurrence)
				{
					this.LastOccurrence = other.LastOccurrence;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0009FCEE File Offset: 0x0009DEEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0009FCFC File Offset: 0x0009DEFC
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
					if (num3 != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LastOccurrence = input.ReadInt32();
					}
				}
				else
				{
					this.SnoQuest = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x0400122F RID: 4655
		private static readonly MessageParser<CompletedRepeatableQuest> _parser = new MessageParser<CompletedRepeatableQuest>(() => new CompletedRepeatableQuest());

		// Token: 0x04001230 RID: 4656
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001231 RID: 4657
		private int _hasBits0;

		// Token: 0x04001232 RID: 4658
		public const int SnoQuestFieldNumber = 1;

		// Token: 0x04001233 RID: 4659
		private static readonly int SnoQuestDefaultValue = -1;

		// Token: 0x04001234 RID: 4660
		private int snoQuest_;

		// Token: 0x04001235 RID: 4661
		public const int LastOccurrenceFieldNumber = 3;

		// Token: 0x04001236 RID: 4662
		private static readonly int LastOccurrenceDefaultValue = 0;

		// Token: 0x04001237 RID: 4663
		private int lastOccurrence_;
	}
}
