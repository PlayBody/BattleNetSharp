using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200028C RID: 652
	public sealed class FindGameQueueIdResponse : IMessage<FindGameQueueIdResponse>, IMessage, IEquatable<FindGameQueueIdResponse>, IDeepCloneable<FindGameQueueIdResponse>, IBufferMessage
	{
		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x0010ADA4 File Offset: 0x00108FA4
		[DebuggerNonUserCode]
		public static MessageParser<FindGameQueueIdResponse> Parser
		{
			get
			{
				return FindGameQueueIdResponse._parser;
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x0010ADBC File Offset: 0x00108FBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[124];
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x0010ADE0 File Offset: 0x00108FE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindGameQueueIdResponse.Descriptor;
			}
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x0010ADF7 File Offset: 0x00108FF7
		[DebuggerNonUserCode]
		public FindGameQueueIdResponse()
		{
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x0010AE01 File Offset: 0x00109001
		[DebuggerNonUserCode]
		public FindGameQueueIdResponse(FindGameQueueIdResponse other)
			: this()
		{
			this.queueId_ = other.queueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x0010AE28 File Offset: 0x00109028
		[DebuggerNonUserCode]
		public FindGameQueueIdResponse Clone()
		{
			return new FindGameQueueIdResponse(this);
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x0010AE40 File Offset: 0x00109040
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x0010AE61 File Offset: 0x00109061
		[DebuggerNonUserCode]
		public string QueueId
		{
			get
			{
				return this.queueId_ ?? FindGameQueueIdResponse.QueueIdDefaultValue;
			}
			set
			{
				this.queueId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600456B RID: 17771 RVA: 0x0010AE78 File Offset: 0x00109078
		[DebuggerNonUserCode]
		public bool HasQueueId
		{
			get
			{
				return this.queueId_ != null;
			}
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x0010AE93 File Offset: 0x00109093
		[DebuggerNonUserCode]
		public void ClearQueueId()
		{
			this.queueId_ = null;
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x0010AEA0 File Offset: 0x001090A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindGameQueueIdResponse);
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x0010AEC0 File Offset: 0x001090C0
		[DebuggerNonUserCode]
		public bool Equals(FindGameQueueIdResponse other)
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
					bool flag4 = this.QueueId != other.QueueId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x0010AF18 File Offset: 0x00109118
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasQueueId = this.HasQueueId;
			if (hasQueueId)
			{
				num ^= this.QueueId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x0010AF64 File Offset: 0x00109164
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x0010AF7C File Offset: 0x0010917C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x0010AF88 File Offset: 0x00109188
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasQueueId = this.HasQueueId;
			if (hasQueueId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.QueueId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x0010AFD4 File Offset: 0x001091D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasQueueId = this.HasQueueId;
			if (hasQueueId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.QueueId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x0010B024 File Offset: 0x00109224
		[DebuggerNonUserCode]
		public void MergeFrom(FindGameQueueIdResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasQueueId = other.HasQueueId;
				if (hasQueueId)
				{
					this.QueueId = other.QueueId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x0010B06D File Offset: 0x0010926D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x0010B078 File Offset: 0x00109278
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
					this.QueueId = input.ReadString();
				}
			}
		}

		// Token: 0x04001F0D RID: 7949
		private static readonly MessageParser<FindGameQueueIdResponse> _parser = new MessageParser<FindGameQueueIdResponse>(() => new FindGameQueueIdResponse());

		// Token: 0x04001F0E RID: 7950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F0F RID: 7951
		public const int QueueIdFieldNumber = 1;

		// Token: 0x04001F10 RID: 7952
		private static readonly string QueueIdDefaultValue = "";

		// Token: 0x04001F11 RID: 7953
		private string queueId_;
	}
}
