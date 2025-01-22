using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000183 RID: 387
	public sealed class SavedDroppedItemData : IMessage<SavedDroppedItemData>, IMessage, IEquatable<SavedDroppedItemData>, IDeepCloneable<SavedDroppedItemData>, IBufferMessage
	{
		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0009E878 File Offset: 0x0009CA78
		[DebuggerNonUserCode]
		public static MessageParser<SavedDroppedItemData> Parser
		{
			get
			{
				return SavedDroppedItemData._parser;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x0009E890 File Offset: 0x0009CA90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0009E8B4 File Offset: 0x0009CAB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedDroppedItemData.Descriptor;
			}
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0009E8CB File Offset: 0x0009CACB
		[DebuggerNonUserCode]
		public SavedDroppedItemData()
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0009E8E0 File Offset: 0x0009CAE0
		[DebuggerNonUserCode]
		public SavedDroppedItemData(SavedDroppedItemData other)
			: this()
		{
			this.droppedItems_ = other.droppedItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0009E90C File Offset: 0x0009CB0C
		[DebuggerNonUserCode]
		public SavedDroppedItemData Clone()
		{
			return new SavedDroppedItemData(this);
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x0009E924 File Offset: 0x0009CB24
		[DebuggerNonUserCode]
		public RepeatedField<SavedTransferItem> DroppedItems
		{
			get
			{
				return this.droppedItems_;
			}
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0009E93C File Offset: 0x0009CB3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedDroppedItemData);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x0009E95C File Offset: 0x0009CB5C
		[DebuggerNonUserCode]
		public bool Equals(SavedDroppedItemData other)
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
					bool flag4 = !this.droppedItems_.Equals(other.droppedItems_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0009E9B8 File Offset: 0x0009CBB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.droppedItems_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0009E9F8 File Offset: 0x0009CBF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0009EA10 File Offset: 0x0009CC10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0009EA1C File Offset: 0x0009CC1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.droppedItems_.WriteTo(ref output, SavedDroppedItemData._repeated_droppedItems_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0009EA58 File Offset: 0x0009CC58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.droppedItems_.CalculateSize(SavedDroppedItemData._repeated_droppedItems_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0009EAA0 File Offset: 0x0009CCA0
		[DebuggerNonUserCode]
		public void MergeFrom(SavedDroppedItemData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.droppedItems_.Add(other.droppedItems_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0009EAE2 File Offset: 0x0009CCE2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0009EAF0 File Offset: 0x0009CCF0
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
					this.droppedItems_.AddEntriesFrom(ref input, SavedDroppedItemData._repeated_droppedItems_codec);
				}
			}
		}

		// Token: 0x0400120C RID: 4620
		private static readonly MessageParser<SavedDroppedItemData> _parser = new MessageParser<SavedDroppedItemData>(() => new SavedDroppedItemData());

		// Token: 0x0400120D RID: 4621
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400120E RID: 4622
		public const int DroppedItemsFieldNumber = 1;

		// Token: 0x0400120F RID: 4623
		private static readonly FieldCodec<SavedTransferItem> _repeated_droppedItems_codec = FieldCodec.ForMessage<SavedTransferItem>(10U, SavedTransferItem.Parser);

		// Token: 0x04001210 RID: 4624
		private readonly RepeatedField<SavedTransferItem> droppedItems_ = new RepeatedField<SavedTransferItem>();
	}
}
