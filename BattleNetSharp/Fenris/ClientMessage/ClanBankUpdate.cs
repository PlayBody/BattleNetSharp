using System;
using System.Diagnostics;
using Fenris.Clan;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200027B RID: 635
	public sealed class ClanBankUpdate : IMessage<ClanBankUpdate>, IMessage, IEquatable<ClanBankUpdate>, IDeepCloneable<ClanBankUpdate>, IBufferMessage
	{
		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x00105F98 File Offset: 0x00104198
		[DebuggerNonUserCode]
		public static MessageParser<ClanBankUpdate> Parser
		{
			get
			{
				return ClanBankUpdate._parser;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x060043D2 RID: 17362 RVA: 0x00105FB0 File Offset: 0x001041B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[107];
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x00105FD4 File Offset: 0x001041D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanBankUpdate.Descriptor;
			}
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00105FEB File Offset: 0x001041EB
		[DebuggerNonUserCode]
		public ClanBankUpdate()
		{
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00106018 File Offset: 0x00104218
		[DebuggerNonUserCode]
		public ClanBankUpdate(ClanBankUpdate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.updatedNumTabs_ = other.updatedNumTabs_;
			this.updatedTabs_ = ((other.updatedTabs_ != null) ? other.updatedTabs_.Clone() : null);
			this.addedItem_ = other.addedItem_.Clone();
			this.updatedItem_ = other.updatedItem_.Clone();
			this.removedItemId_ = other.removedItemId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x001060B4 File Offset: 0x001042B4
		[DebuggerNonUserCode]
		public ClanBankUpdate Clone()
		{
			return new ClanBankUpdate(this);
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x001060CC File Offset: 0x001042CC
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x001060ED File Offset: 0x001042ED
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanBankUpdate.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00106104 File Offset: 0x00104304
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x0010611F File Offset: 0x0010431F
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x0010612C File Offset: 0x0010432C
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x0010615D File Offset: 0x0010435D
		[DebuggerNonUserCode]
		public uint UpdatedNumTabs
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint updatedNumTabsDefaultValue;
				if (flag)
				{
					updatedNumTabsDefaultValue = this.updatedNumTabs_;
				}
				else
				{
					updatedNumTabsDefaultValue = ClanBankUpdate.UpdatedNumTabsDefaultValue;
				}
				return updatedNumTabsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.updatedNumTabs_ = value;
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x00106178 File Offset: 0x00104378
		[DebuggerNonUserCode]
		public bool HasUpdatedNumTabs
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00106195 File Offset: 0x00104395
		[DebuggerNonUserCode]
		public void ClearUpdatedNumTabs()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x001061A8 File Offset: 0x001043A8
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x001061C0 File Offset: 0x001043C0
		[DebuggerNonUserCode]
		public ClanBankTabs UpdatedTabs
		{
			get
			{
				return this.updatedTabs_;
			}
			set
			{
				this.updatedTabs_ = value;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x001061CC File Offset: 0x001043CC
		[DebuggerNonUserCode]
		public RepeatedField<SavedItem> AddedItem
		{
			get
			{
				return this.addedItem_;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060043E2 RID: 17378 RVA: 0x001061E4 File Offset: 0x001043E4
		[DebuggerNonUserCode]
		public RepeatedField<SavedItem> UpdatedItem
		{
			get
			{
				return this.updatedItem_;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x001061FC File Offset: 0x001043FC
		[DebuggerNonUserCode]
		public RepeatedField<ByteString> RemovedItemId
		{
			get
			{
				return this.removedItemId_;
			}
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x00106214 File Offset: 0x00104414
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanBankUpdate);
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x00106234 File Offset: 0x00104434
		[DebuggerNonUserCode]
		public bool Equals(ClanBankUpdate other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UpdatedNumTabs != other.UpdatedNumTabs;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.UpdatedTabs, other.UpdatedTabs);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.addedItem_.Equals(other.addedItem_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.updatedItem_.Equals(other.updatedItem_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.removedItemId_.Equals(other.removedItemId_);
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x0010632C File Offset: 0x0010452C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasUpdatedNumTabs = this.HasUpdatedNumTabs;
			if (hasUpdatedNumTabs)
			{
				num ^= this.UpdatedNumTabs.GetHashCode();
			}
			bool flag = this.updatedTabs_ != null;
			if (flag)
			{
				num ^= this.UpdatedTabs.GetHashCode();
			}
			num ^= this.addedItem_.GetHashCode();
			num ^= this.updatedItem_.GetHashCode();
			num ^= this.removedItemId_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x001063DC File Offset: 0x001045DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x001063F4 File Offset: 0x001045F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x00106400 File Offset: 0x00104600
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasUpdatedNumTabs = this.HasUpdatedNumTabs;
			if (hasUpdatedNumTabs)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.UpdatedNumTabs);
			}
			bool flag = this.updatedTabs_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.UpdatedTabs);
			}
			this.addedItem_.WriteTo(ref output, ClanBankUpdate._repeated_addedItem_codec);
			this.updatedItem_.WriteTo(ref output, ClanBankUpdate._repeated_updatedItem_codec);
			this.removedItemId_.WriteTo(ref output, ClanBankUpdate._repeated_removedItemId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x001064CC File Offset: 0x001046CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasUpdatedNumTabs = this.HasUpdatedNumTabs;
			if (hasUpdatedNumTabs)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UpdatedNumTabs);
			}
			bool flag = this.updatedTabs_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UpdatedTabs);
			}
			num += this.addedItem_.CalculateSize(ClanBankUpdate._repeated_addedItem_codec);
			num += this.updatedItem_.CalculateSize(ClanBankUpdate._repeated_updatedItem_codec);
			num += this.removedItemId_.CalculateSize(ClanBankUpdate._repeated_removedItemId_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x00106594 File Offset: 0x00104794
		[DebuggerNonUserCode]
		public void MergeFrom(ClanBankUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasUpdatedNumTabs = other.HasUpdatedNumTabs;
				if (hasUpdatedNumTabs)
				{
					this.UpdatedNumTabs = other.UpdatedNumTabs;
				}
				bool flag2 = other.updatedTabs_ != null;
				if (flag2)
				{
					bool flag3 = this.updatedTabs_ == null;
					if (flag3)
					{
						this.UpdatedTabs = new ClanBankTabs();
					}
					this.UpdatedTabs.MergeFrom(other.UpdatedTabs);
				}
				this.addedItem_.Add(other.addedItem_);
				this.updatedItem_.Add(other.updatedItem_);
				this.removedItemId_.Add(other.removedItemId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x0010666D File Offset: 0x0010486D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00106678 File Offset: 0x00104878
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 26U)
							{
								goto IL_0040;
							}
							bool flag = this.updatedTabs_ == null;
							if (flag)
							{
								this.UpdatedTabs = new ClanBankTabs();
							}
							input.ReadMessage(this.UpdatedTabs);
						}
						else
						{
							this.UpdatedNumTabs = input.ReadUInt32();
						}
					}
					else
					{
						this.ClanId = input.ReadString();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0040;
						}
						this.removedItemId_.AddEntriesFrom(ref input, ClanBankUpdate._repeated_removedItemId_codec);
					}
					else
					{
						this.updatedItem_.AddEntriesFrom(ref input, ClanBankUpdate._repeated_updatedItem_codec);
					}
				}
				else
				{
					this.addedItem_.AddEntriesFrom(ref input, ClanBankUpdate._repeated_addedItem_codec);
				}
				continue;
				IL_0040:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E77 RID: 7799
		private static readonly MessageParser<ClanBankUpdate> _parser = new MessageParser<ClanBankUpdate>(() => new ClanBankUpdate());

		// Token: 0x04001E78 RID: 7800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E79 RID: 7801
		private int _hasBits0;

		// Token: 0x04001E7A RID: 7802
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E7B RID: 7803
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E7C RID: 7804
		private string clanId_;

		// Token: 0x04001E7D RID: 7805
		public const int UpdatedNumTabsFieldNumber = 2;

		// Token: 0x04001E7E RID: 7806
		private static readonly uint UpdatedNumTabsDefaultValue = 0U;

		// Token: 0x04001E7F RID: 7807
		private uint updatedNumTabs_;

		// Token: 0x04001E80 RID: 7808
		public const int UpdatedTabsFieldNumber = 3;

		// Token: 0x04001E81 RID: 7809
		private ClanBankTabs updatedTabs_;

		// Token: 0x04001E82 RID: 7810
		public const int AddedItemFieldNumber = 4;

		// Token: 0x04001E83 RID: 7811
		private static readonly FieldCodec<SavedItem> _repeated_addedItem_codec = FieldCodec.ForMessage<SavedItem>(34U, SavedItem.Parser);

		// Token: 0x04001E84 RID: 7812
		private readonly RepeatedField<SavedItem> addedItem_ = new RepeatedField<SavedItem>();

		// Token: 0x04001E85 RID: 7813
		public const int UpdatedItemFieldNumber = 5;

		// Token: 0x04001E86 RID: 7814
		private static readonly FieldCodec<SavedItem> _repeated_updatedItem_codec = FieldCodec.ForMessage<SavedItem>(42U, SavedItem.Parser);

		// Token: 0x04001E87 RID: 7815
		private readonly RepeatedField<SavedItem> updatedItem_ = new RepeatedField<SavedItem>();

		// Token: 0x04001E88 RID: 7816
		public const int RemovedItemIdFieldNumber = 6;

		// Token: 0x04001E89 RID: 7817
		private static readonly FieldCodec<ByteString> _repeated_removedItemId_codec = FieldCodec.ForBytes(50U);

		// Token: 0x04001E8A RID: 7818
		private readonly RepeatedField<ByteString> removedItemId_ = new RepeatedField<ByteString>();
	}
}
