using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A0 RID: 672
	public sealed class CancelQueueEntry : IMessage<CancelQueueEntry>, IMessage, IEquatable<CancelQueueEntry>, IDeepCloneable<CancelQueueEntry>, IBufferMessage
	{
		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004710 RID: 18192 RVA: 0x0010F768 File Offset: 0x0010D968
		[DebuggerNonUserCode]
		public static MessageParser<CancelQueueEntry> Parser
		{
			get
			{
				return CancelQueueEntry._parser;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x0010F780 File Offset: 0x0010D980
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[144];
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x0010F7A8 File Offset: 0x0010D9A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelQueueEntry.Descriptor;
			}
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x0010F7BF File Offset: 0x0010D9BF
		[DebuggerNonUserCode]
		public CancelQueueEntry()
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x0010F7C9 File Offset: 0x0010D9C9
		[DebuggerNonUserCode]
		public CancelQueueEntry(CancelQueueEntry other)
			: this()
		{
			this.entryKey_ = ((other.entryKey_ != null) ? other.entryKey_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x0010F800 File Offset: 0x0010DA00
		[DebuggerNonUserCode]
		public CancelQueueEntry Clone()
		{
			return new CancelQueueEntry(this);
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004716 RID: 18198 RVA: 0x0010F818 File Offset: 0x0010DA18
		// (set) Token: 0x06004717 RID: 18199 RVA: 0x0010F830 File Offset: 0x0010DA30
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

		// Token: 0x06004718 RID: 18200 RVA: 0x0010F83C File Offset: 0x0010DA3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelQueueEntry);
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x0010F85C File Offset: 0x0010DA5C
		[DebuggerNonUserCode]
		public bool Equals(CancelQueueEntry other)
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

		// Token: 0x0600471A RID: 18202 RVA: 0x0010F8B8 File Offset: 0x0010DAB8
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

		// Token: 0x0600471B RID: 18203 RVA: 0x0010F908 File Offset: 0x0010DB08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x0010F920 File Offset: 0x0010DB20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x0010F92C File Offset: 0x0010DB2C
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

		// Token: 0x0600471E RID: 18206 RVA: 0x0010F97C File Offset: 0x0010DB7C
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

		// Token: 0x0600471F RID: 18207 RVA: 0x0010F9D0 File Offset: 0x0010DBD0
		[DebuggerNonUserCode]
		public void MergeFrom(CancelQueueEntry other)
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

		// Token: 0x06004720 RID: 18208 RVA: 0x0010FA3C File Offset: 0x0010DC3C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x0010FA48 File Offset: 0x0010DC48
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

		// Token: 0x04001F86 RID: 8070
		private static readonly MessageParser<CancelQueueEntry> _parser = new MessageParser<CancelQueueEntry>(() => new CancelQueueEntry());

		// Token: 0x04001F87 RID: 8071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F88 RID: 8072
		public const int EntryKeyFieldNumber = 1;

		// Token: 0x04001F89 RID: 8073
		private QueueEntryKey entryKey_;
	}
}
