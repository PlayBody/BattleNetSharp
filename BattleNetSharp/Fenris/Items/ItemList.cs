using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000168 RID: 360
	public sealed class ItemList : IMessage<ItemList>, IMessage, IEquatable<ItemList>, IDeepCloneable<ItemList>, IBufferMessage
	{
		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x0009216C File Offset: 0x0009036C
		[DebuggerNonUserCode]
		public static MessageParser<ItemList> Parser
		{
			get
			{
				return ItemList._parser;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x00092184 File Offset: 0x00090384
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000921A8 File Offset: 0x000903A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemList.Descriptor;
			}
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x000921BF File Offset: 0x000903BF
		[DebuggerNonUserCode]
		public ItemList()
		{
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000921D4 File Offset: 0x000903D4
		[DebuggerNonUserCode]
		public ItemList(ItemList other)
			: this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00092200 File Offset: 0x00090400
		[DebuggerNonUserCode]
		public ItemList Clone()
		{
			return new ItemList(this);
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x00092218 File Offset: 0x00090418
		[DebuggerNonUserCode]
		public RepeatedField<SavedItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00092230 File Offset: 0x00090430
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemList);
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00092250 File Offset: 0x00090450
		[DebuggerNonUserCode]
		public bool Equals(ItemList other)
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
					bool flag4 = !this.items_.Equals(other.items_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000922AC File Offset: 0x000904AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000922EC File Offset: 0x000904EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00092304 File Offset: 0x00090504
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00092310 File Offset: 0x00090510
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, ItemList._repeated_items_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0009234C File Offset: 0x0009054C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(ItemList._repeated_items_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00092394 File Offset: 0x00090594
		[DebuggerNonUserCode]
		public void MergeFrom(ItemList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.items_.Add(other.items_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000923D6 File Offset: 0x000905D6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000923E4 File Offset: 0x000905E4
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
					this.items_.AddEntriesFrom(ref input, ItemList._repeated_items_codec);
				}
			}
		}

		// Token: 0x0400109B RID: 4251
		private static readonly MessageParser<ItemList> _parser = new MessageParser<ItemList>(() => new ItemList());

		// Token: 0x0400109C RID: 4252
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400109D RID: 4253
		public const int ItemsFieldNumber = 1;

		// Token: 0x0400109E RID: 4254
		private static readonly FieldCodec<SavedItem> _repeated_items_codec = FieldCodec.ForMessage<SavedItem>(10U, SavedItem.Parser);

		// Token: 0x0400109F RID: 4255
		private readonly RepeatedField<SavedItem> items_ = new RepeatedField<SavedItem>();
	}
}
