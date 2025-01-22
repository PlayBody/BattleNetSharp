using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000292 RID: 658
	public sealed class SubscribeToQueueUpdates : IMessage<SubscribeToQueueUpdates>, IMessage, IEquatable<SubscribeToQueueUpdates>, IDeepCloneable<SubscribeToQueueUpdates>, IBufferMessage
	{
		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x0010C1B8 File Offset: 0x0010A3B8
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeToQueueUpdates> Parser
		{
			get
			{
				return SubscribeToQueueUpdates._parser;
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x0010C1D0 File Offset: 0x0010A3D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[130];
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x0010C1F8 File Offset: 0x0010A3F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeToQueueUpdates.Descriptor;
			}
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x0010C20F File Offset: 0x0010A40F
		[DebuggerNonUserCode]
		public SubscribeToQueueUpdates()
		{
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x0010C219 File Offset: 0x0010A419
		[DebuggerNonUserCode]
		public SubscribeToQueueUpdates(SubscribeToQueueUpdates other)
			: this()
		{
			this.entryKey_ = ((other.entryKey_ != null) ? other.entryKey_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x0010C250 File Offset: 0x0010A450
		[DebuggerNonUserCode]
		public SubscribeToQueueUpdates Clone()
		{
			return new SubscribeToQueueUpdates(this);
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x0010C268 File Offset: 0x0010A468
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x0010C280 File Offset: 0x0010A480
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

		// Token: 0x060045E7 RID: 17895 RVA: 0x0010C28C File Offset: 0x0010A48C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeToQueueUpdates);
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x0010C2AC File Offset: 0x0010A4AC
		[DebuggerNonUserCode]
		public bool Equals(SubscribeToQueueUpdates other)
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

		// Token: 0x060045E9 RID: 17897 RVA: 0x0010C308 File Offset: 0x0010A508
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

		// Token: 0x060045EA RID: 17898 RVA: 0x0010C358 File Offset: 0x0010A558
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x0010C370 File Offset: 0x0010A570
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x0010C37C File Offset: 0x0010A57C
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

		// Token: 0x060045ED RID: 17901 RVA: 0x0010C3CC File Offset: 0x0010A5CC
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

		// Token: 0x060045EE RID: 17902 RVA: 0x0010C420 File Offset: 0x0010A620
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeToQueueUpdates other)
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

		// Token: 0x060045EF RID: 17903 RVA: 0x0010C48C File Offset: 0x0010A68C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x0010C498 File Offset: 0x0010A698
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

		// Token: 0x04001F2B RID: 7979
		private static readonly MessageParser<SubscribeToQueueUpdates> _parser = new MessageParser<SubscribeToQueueUpdates>(() => new SubscribeToQueueUpdates());

		// Token: 0x04001F2C RID: 7980
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F2D RID: 7981
		public const int EntryKeyFieldNumber = 1;

		// Token: 0x04001F2E RID: 7982
		private QueueEntryKey entryKey_;
	}
}
