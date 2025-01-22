using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200028A RID: 650
	public sealed class QueueEntryAdded : IMessage<QueueEntryAdded>, IMessage, IEquatable<QueueEntryAdded>, IDeepCloneable<QueueEntryAdded>, IBufferMessage
	{
		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x0010A588 File Offset: 0x00108788
		[DebuggerNonUserCode]
		public static MessageParser<QueueEntryAdded> Parser
		{
			get
			{
				return QueueEntryAdded._parser;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x0010A5A0 File Offset: 0x001087A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[122];
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x0010A5C4 File Offset: 0x001087C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueEntryAdded.Descriptor;
			}
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x0010A5DB File Offset: 0x001087DB
		[DebuggerNonUserCode]
		public QueueEntryAdded()
		{
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x0010A5E5 File Offset: 0x001087E5
		[DebuggerNonUserCode]
		public QueueEntryAdded(QueueEntryAdded other)
			: this()
		{
			this.entryKey_ = ((other.entryKey_ != null) ? other.entryKey_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x0010A61C File Offset: 0x0010881C
		[DebuggerNonUserCode]
		public QueueEntryAdded Clone()
		{
			return new QueueEntryAdded(this);
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x0010A634 File Offset: 0x00108834
		// (set) Token: 0x06004540 RID: 17728 RVA: 0x0010A64C File Offset: 0x0010884C
		[DebuggerNonUserCode]
		public QueueEntryKey EntryKey
		{
			get
			{
				return this.entryKey_;
			}
			set
			{
				this.entryKey_ = value;
			}
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x0010A658 File Offset: 0x00108858
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueEntryAdded);
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x0010A678 File Offset: 0x00108878
		[DebuggerNonUserCode]
		public bool Equals(QueueEntryAdded other)
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
					bool flag4 = !object.Equals(this.EntryKey, other.EntryKey);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x0010A6D4 File Offset: 0x001088D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entryKey_ != null;
			if (flag)
			{
				num ^= this.EntryKey.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x0010A724 File Offset: 0x00108924
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x0010A73C File Offset: 0x0010893C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x0010A748 File Offset: 0x00108948
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entryKey_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntryKey);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x0010A798 File Offset: 0x00108998
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entryKey_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntryKey);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x0010A7EC File Offset: 0x001089EC
		[DebuggerNonUserCode]
		public void MergeFrom(QueueEntryAdded other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entryKey_ != null;
				if (flag2)
				{
					bool flag3 = this.entryKey_ == null;
					if (flag3)
					{
						this.EntryKey = new QueueEntryKey();
					}
					this.EntryKey.MergeFrom(other.EntryKey);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x0010A858 File Offset: 0x00108A58
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x0010A864 File Offset: 0x00108A64
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
					bool flag = this.entryKey_ == null;
					if (flag)
					{
						this.EntryKey = new QueueEntryKey();
					}
					input.ReadMessage(this.EntryKey);
				}
			}
		}

		// Token: 0x04001F01 RID: 7937
		private static readonly MessageParser<QueueEntryAdded> _parser = new MessageParser<QueueEntryAdded>(() => new QueueEntryAdded());

		// Token: 0x04001F02 RID: 7938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F03 RID: 7939
		public const int EntryKeyFieldNumber = 1;

		// Token: 0x04001F04 RID: 7940
		private QueueEntryKey entryKey_;
	}
}
