using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000181 RID: 385
	public sealed class SavedTransferItem : IMessage<SavedTransferItem>, IMessage, IEquatable<SavedTransferItem>, IDeepCloneable<SavedTransferItem>, IBufferMessage
	{
		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x0009DBFC File Offset: 0x0009BDFC
		[DebuggerNonUserCode]
		public static MessageParser<SavedTransferItem> Parser
		{
			get
			{
				return SavedTransferItem._parser;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x0009DC14 File Offset: 0x0009BE14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x0009DC38 File Offset: 0x0009BE38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedTransferItem.Descriptor;
			}
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0009DC4F File Offset: 0x0009BE4F
		[DebuggerNonUserCode]
		public SavedTransferItem()
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0009DC5C File Offset: 0x0009BE5C
		[DebuggerNonUserCode]
		public SavedTransferItem(SavedTransferItem other)
			: this()
		{
			this.worldPlace_ = ((other.worldPlace_ != null) ? other.worldPlace_.Clone() : null);
			this.itemId_ = other.itemId_;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0009DCC8 File Offset: 0x0009BEC8
		[DebuggerNonUserCode]
		public SavedTransferItem Clone()
		{
			return new SavedTransferItem(this);
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x0009DCE0 File Offset: 0x0009BEE0
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x0009DCF8 File Offset: 0x0009BEF8
		[DebuggerNonUserCode]
		public SavedWorldPlace WorldPlace
		{
			get
			{
				return this.worldPlace_;
			}
			set
			{
				this.worldPlace_ = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x0009DD04 File Offset: 0x0009BF04
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x0009DD25 File Offset: 0x0009BF25
		[DebuggerNonUserCode]
		public string ItemId
		{
			get
			{
				return this.itemId_ ?? SavedTransferItem.ItemIdDefaultValue;
			}
			set
			{
				this.itemId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x0009DD3C File Offset: 0x0009BF3C
		[DebuggerNonUserCode]
		public bool HasItemId
		{
			get
			{
				return this.itemId_ != null;
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0009DD57 File Offset: 0x0009BF57
		[DebuggerNonUserCode]
		public void ClearItemId()
		{
			this.itemId_ = null;
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x0009DD64 File Offset: 0x0009BF64
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x0009DD7C File Offset: 0x0009BF7C
		[DebuggerNonUserCode]
		public Generator Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0009DD88 File Offset: 0x0009BF88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedTransferItem);
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0009DDA8 File Offset: 0x0009BFA8
		[DebuggerNonUserCode]
		public bool Equals(SavedTransferItem other)
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
					bool flag4 = !object.Equals(this.WorldPlace, other.WorldPlace);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ItemId != other.ItemId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Item, other.Item);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0009DE3C File Offset: 0x0009C03C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num ^= this.WorldPlace.GetHashCode();
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num ^= this.ItemId.GetHashCode();
			}
			bool flag2 = this.item_ != null;
			if (flag2)
			{
				num ^= this.Item.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0009DEC0 File Offset: 0x0009C0C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0009DED8 File Offset: 0x0009C0D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x0009DEE4 File Offset: 0x0009C0E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.WorldPlace);
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ItemId);
			}
			bool flag2 = this.item_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Item);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0009DF7C File Offset: 0x0009C17C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WorldPlace);
			}
			bool hasItemId = this.HasItemId;
			if (hasItemId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ItemId);
			}
			bool flag2 = this.item_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0009E00C File Offset: 0x0009C20C
		[DebuggerNonUserCode]
		public void MergeFrom(SavedTransferItem other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.worldPlace_ != null;
				if (flag2)
				{
					bool flag3 = this.worldPlace_ == null;
					if (flag3)
					{
						this.WorldPlace = new SavedWorldPlace();
					}
					this.WorldPlace.MergeFrom(other.WorldPlace);
				}
				bool hasItemId = other.HasItemId;
				if (hasItemId)
				{
					this.ItemId = other.ItemId;
				}
				bool flag4 = other.item_ != null;
				if (flag4)
				{
					bool flag5 = this.item_ == null;
					if (flag5)
					{
						this.Item = new Generator();
					}
					this.Item.MergeFrom(other.Item);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0009E0D4 File Offset: 0x0009C2D4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x0009E0E0 File Offset: 0x0009C2E0
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.item_ == null;
							if (flag)
							{
								this.Item = new Generator();
							}
							input.ReadMessage(this.Item);
						}
					}
					else
					{
						this.ItemId = input.ReadString();
					}
				}
				else
				{
					bool flag2 = this.worldPlace_ == null;
					if (flag2)
					{
						this.WorldPlace = new SavedWorldPlace();
					}
					input.ReadMessage(this.WorldPlace);
				}
			}
		}

		// Token: 0x040011F5 RID: 4597
		private static readonly MessageParser<SavedTransferItem> _parser = new MessageParser<SavedTransferItem>(() => new SavedTransferItem());

		// Token: 0x040011F6 RID: 4598
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011F7 RID: 4599
		public const int WorldPlaceFieldNumber = 1;

		// Token: 0x040011F8 RID: 4600
		private SavedWorldPlace worldPlace_;

		// Token: 0x040011F9 RID: 4601
		public const int ItemIdFieldNumber = 2;

		// Token: 0x040011FA RID: 4602
		private static readonly string ItemIdDefaultValue = "";

		// Token: 0x040011FB RID: 4603
		private string itemId_;

		// Token: 0x040011FC RID: 4604
		public const int ItemFieldNumber = 3;

		// Token: 0x040011FD RID: 4605
		private Generator item_;
	}
}
