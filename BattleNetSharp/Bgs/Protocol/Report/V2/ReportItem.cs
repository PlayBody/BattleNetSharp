using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000588 RID: 1416
	public sealed class ReportItem : IMessage<ReportItem>, IMessage, IEquatable<ReportItem>, IDeepCloneable<ReportItem>, IBufferMessage
	{
		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x0020F260 File Offset: 0x0020D460
		[DebuggerNonUserCode]
		public static MessageParser<ReportItem> Parser
		{
			get
			{
				return ReportItem._parser;
			}
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x06008793 RID: 34707 RVA: 0x0020F278 File Offset: 0x0020D478
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x0020F29C File Offset: 0x0020D49C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportItem.Descriptor;
			}
		}

		// Token: 0x06008795 RID: 34709 RVA: 0x0020F2B3 File Offset: 0x0020D4B3
		[DebuggerNonUserCode]
		public ReportItem()
		{
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x0020F2C4 File Offset: 0x0020D4C4
		[DebuggerNonUserCode]
		public ReportItem(ReportItem other)
			: this()
		{
			ReportItem.TypeOneofCase typeCase = other.TypeCase;
			ReportItem.TypeOneofCase typeOneofCase = typeCase;
			if (typeOneofCase == ReportItem.TypeOneofCase.MessageId)
			{
				this.MessageId = other.MessageId.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008797 RID: 34711 RVA: 0x0020F310 File Offset: 0x0020D510
		[DebuggerNonUserCode]
		public ReportItem Clone()
		{
			return new ReportItem(this);
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x0020F328 File Offset: 0x0020D528
		// (set) Token: 0x06008799 RID: 34713 RVA: 0x0020F351 File Offset: 0x0020D551
		[DebuggerNonUserCode]
		public MessageId MessageId
		{
			get
			{
				return (this.typeCase_ == ReportItem.TypeOneofCase.MessageId) ? ((MessageId)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportItem.TypeOneofCase.None : ReportItem.TypeOneofCase.MessageId);
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0600879A RID: 34714 RVA: 0x0020F368 File Offset: 0x0020D568
		[DebuggerNonUserCode]
		public ReportItem.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x0020F380 File Offset: 0x0020D580
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = ReportItem.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x0020F394 File Offset: 0x0020D594
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportItem);
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x0020F3B4 File Offset: 0x0020D5B4
		[DebuggerNonUserCode]
		public bool Equals(ReportItem other)
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
					bool flag4 = !object.Equals(this.MessageId, other.MessageId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TypeCase != other.TypeCase;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x0020F428 File Offset: 0x0020D628
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.typeCase_ == ReportItem.TypeOneofCase.MessageId;
			if (flag)
			{
				num ^= this.MessageId.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x0020F480 File Offset: 0x0020D680
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x0020F498 File Offset: 0x0020D698
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x0020F4A4 File Offset: 0x0020D6A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.typeCase_ == ReportItem.TypeOneofCase.MessageId;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MessageId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x0020F4F4 File Offset: 0x0020D6F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.typeCase_ == ReportItem.TypeOneofCase.MessageId;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087A3 RID: 34723 RVA: 0x0020F548 File Offset: 0x0020D748
		[DebuggerNonUserCode]
		public void MergeFrom(ReportItem other)
		{
			bool flag = other == null;
			if (!flag)
			{
				ReportItem.TypeOneofCase typeCase = other.TypeCase;
				ReportItem.TypeOneofCase typeOneofCase = typeCase;
				if (typeOneofCase == ReportItem.TypeOneofCase.MessageId)
				{
					bool flag2 = this.MessageId == null;
					if (flag2)
					{
						this.MessageId = new MessageId();
					}
					this.MessageId.MergeFrom(other.MessageId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060087A4 RID: 34724 RVA: 0x0020F5B6 File Offset: 0x0020D7B6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087A5 RID: 34725 RVA: 0x0020F5C4 File Offset: 0x0020D7C4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					MessageId messageId = new MessageId();
					bool flag = this.typeCase_ == ReportItem.TypeOneofCase.MessageId;
					if (flag)
					{
						messageId.MergeFrom(this.MessageId);
					}
					input.ReadMessage(messageId);
					this.MessageId = messageId;
				}
			}
		}

		// Token: 0x04003D75 RID: 15733
		private static readonly MessageParser<ReportItem> _parser = new MessageParser<ReportItem>(() => new ReportItem());

		// Token: 0x04003D76 RID: 15734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D77 RID: 15735
		public const int MessageIdFieldNumber = 1;

		// Token: 0x04003D78 RID: 15736
		private object type_;

		// Token: 0x04003D79 RID: 15737
		private ReportItem.TypeOneofCase typeCase_ = ReportItem.TypeOneofCase.None;

		// Token: 0x0200105E RID: 4190
		public enum TypeOneofCase
		{
			// Token: 0x040097B4 RID: 38836
			None,
			// Token: 0x040097B5 RID: 38837
			MessageId
		}
	}
}
