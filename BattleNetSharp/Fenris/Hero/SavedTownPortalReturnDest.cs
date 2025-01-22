using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000182 RID: 386
	public sealed class SavedTownPortalReturnDest : IMessage<SavedTownPortalReturnDest>, IMessage, IEquatable<SavedTownPortalReturnDest>, IDeepCloneable<SavedTownPortalReturnDest>, IBufferMessage
	{
		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x0009E1C4 File Offset: 0x0009C3C4
		[DebuggerNonUserCode]
		public static MessageParser<SavedTownPortalReturnDest> Parser
		{
			get
			{
				return SavedTownPortalReturnDest._parser;
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x0009E1DC File Offset: 0x0009C3DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x0009E200 File Offset: 0x0009C400
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedTownPortalReturnDest.Descriptor;
			}
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x0009E217 File Offset: 0x0009C417
		[DebuggerNonUserCode]
		public SavedTownPortalReturnDest()
		{
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0009E22C File Offset: 0x0009C42C
		[DebuggerNonUserCode]
		public SavedTownPortalReturnDest(SavedTownPortalReturnDest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.worldPlace_ = ((other.worldPlace_ != null) ? other.worldPlace_.Clone() : null);
			this.snoLevelArea_ = other.snoLevelArea_;
			this.expireTimestamp_ = other.expireTimestamp_;
			this.nearbyItem_ = other.nearbyItem_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x0009E2A4 File Offset: 0x0009C4A4
		[DebuggerNonUserCode]
		public SavedTownPortalReturnDest Clone()
		{
			return new SavedTownPortalReturnDest(this);
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x0009E2BC File Offset: 0x0009C4BC
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x0009E2D4 File Offset: 0x0009C4D4
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

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x0009E2E0 File Offset: 0x0009C4E0
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0009E311 File Offset: 0x0009C511
		[DebuggerNonUserCode]
		public int SnoLevelArea
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoLevelAreaDefaultValue;
				if (flag)
				{
					snoLevelAreaDefaultValue = this.snoLevelArea_;
				}
				else
				{
					snoLevelAreaDefaultValue = SavedTownPortalReturnDest.SnoLevelAreaDefaultValue;
				}
				return snoLevelAreaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoLevelArea_ = value;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x0009E32C File Offset: 0x0009C52C
		[DebuggerNonUserCode]
		public bool HasSnoLevelArea
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0009E349 File Offset: 0x0009C549
		[DebuggerNonUserCode]
		public void ClearSnoLevelArea()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x0009E35C File Offset: 0x0009C55C
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x0009E38D File Offset: 0x0009C58D
		[DebuggerNonUserCode]
		public ulong ExpireTimestamp
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong expireTimestampDefaultValue;
				if (flag)
				{
					expireTimestampDefaultValue = this.expireTimestamp_;
				}
				else
				{
					expireTimestampDefaultValue = SavedTownPortalReturnDest.ExpireTimestampDefaultValue;
				}
				return expireTimestampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.expireTimestamp_ = value;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x0009E3A8 File Offset: 0x0009C5A8
		[DebuggerNonUserCode]
		public bool HasExpireTimestamp
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0009E3C5 File Offset: 0x0009C5C5
		[DebuggerNonUserCode]
		public void ClearExpireTimestamp()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x0009E3D8 File Offset: 0x0009C5D8
		[DebuggerNonUserCode]
		public RepeatedField<SavedTransferItem> NearbyItem
		{
			get
			{
				return this.nearbyItem_;
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0009E3F0 File Offset: 0x0009C5F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedTownPortalReturnDest);
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0009E410 File Offset: 0x0009C610
		[DebuggerNonUserCode]
		public bool Equals(SavedTownPortalReturnDest other)
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
						bool flag5 = this.SnoLevelArea != other.SnoLevelArea;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ExpireTimestamp != other.ExpireTimestamp;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.nearbyItem_.Equals(other.nearbyItem_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0009E4C4 File Offset: 0x0009C6C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num ^= this.WorldPlace.GetHashCode();
			}
			bool hasSnoLevelArea = this.HasSnoLevelArea;
			if (hasSnoLevelArea)
			{
				num ^= this.SnoLevelArea.GetHashCode();
			}
			bool hasExpireTimestamp = this.HasExpireTimestamp;
			if (hasExpireTimestamp)
			{
				num ^= this.ExpireTimestamp.GetHashCode();
			}
			num ^= this.nearbyItem_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0009E55C File Offset: 0x0009C75C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0009E574 File Offset: 0x0009C774
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0009E580 File Offset: 0x0009C780
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.WorldPlace);
			}
			bool hasSnoLevelArea = this.HasSnoLevelArea;
			if (hasSnoLevelArea)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoLevelArea);
			}
			bool hasExpireTimestamp = this.HasExpireTimestamp;
			if (hasExpireTimestamp)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ExpireTimestamp);
			}
			this.nearbyItem_.WriteTo(ref output, SavedTownPortalReturnDest._repeated_nearbyItem_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0009E628 File Offset: 0x0009C828
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WorldPlace);
			}
			bool hasSnoLevelArea = this.HasSnoLevelArea;
			if (hasSnoLevelArea)
			{
				num += 5;
			}
			bool hasExpireTimestamp = this.HasExpireTimestamp;
			if (hasExpireTimestamp)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpireTimestamp);
			}
			num += this.nearbyItem_.CalculateSize(SavedTownPortalReturnDest._repeated_nearbyItem_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0009E6BC File Offset: 0x0009C8BC
		[DebuggerNonUserCode]
		public void MergeFrom(SavedTownPortalReturnDest other)
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
				bool hasSnoLevelArea = other.HasSnoLevelArea;
				if (hasSnoLevelArea)
				{
					this.SnoLevelArea = other.SnoLevelArea;
				}
				bool hasExpireTimestamp = other.HasExpireTimestamp;
				if (hasExpireTimestamp)
				{
					this.ExpireTimestamp = other.ExpireTimestamp;
				}
				this.nearbyItem_.Add(other.nearbyItem_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0009E771 File Offset: 0x0009C971
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0009E77C File Offset: 0x0009C97C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							goto IL_002C;
						}
						this.SnoLevelArea = input.ReadSFixed32();
					}
					else
					{
						bool flag = this.worldPlace_ == null;
						if (flag)
						{
							this.WorldPlace = new SavedWorldPlace();
						}
						input.ReadMessage(this.WorldPlace);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					this.nearbyItem_.AddEntriesFrom(ref input, SavedTownPortalReturnDest._repeated_nearbyItem_codec);
				}
				else
				{
					this.ExpireTimestamp = input.ReadUInt64();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040011FE RID: 4606
		private static readonly MessageParser<SavedTownPortalReturnDest> _parser = new MessageParser<SavedTownPortalReturnDest>(() => new SavedTownPortalReturnDest());

		// Token: 0x040011FF RID: 4607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001200 RID: 4608
		private int _hasBits0;

		// Token: 0x04001201 RID: 4609
		public const int WorldPlaceFieldNumber = 1;

		// Token: 0x04001202 RID: 4610
		private SavedWorldPlace worldPlace_;

		// Token: 0x04001203 RID: 4611
		public const int SnoLevelAreaFieldNumber = 2;

		// Token: 0x04001204 RID: 4612
		private static readonly int SnoLevelAreaDefaultValue = -1;

		// Token: 0x04001205 RID: 4613
		private int snoLevelArea_;

		// Token: 0x04001206 RID: 4614
		public const int ExpireTimestampFieldNumber = 3;

		// Token: 0x04001207 RID: 4615
		private static readonly ulong ExpireTimestampDefaultValue = 0UL;

		// Token: 0x04001208 RID: 4616
		private ulong expireTimestamp_;

		// Token: 0x04001209 RID: 4617
		public const int NearbyItemFieldNumber = 4;

		// Token: 0x0400120A RID: 4618
		private static readonly FieldCodec<SavedTransferItem> _repeated_nearbyItem_codec = FieldCodec.ForMessage<SavedTransferItem>(34U, SavedTransferItem.Parser);

		// Token: 0x0400120B RID: 4619
		private readonly RepeatedField<SavedTransferItem> nearbyItem_ = new RepeatedField<SavedTransferItem>();
	}
}
