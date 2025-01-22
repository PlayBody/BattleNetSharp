using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A8 RID: 424
	public sealed class KeyedDungeonData : IMessage<KeyedDungeonData>, IMessage, IEquatable<KeyedDungeonData>, IDeepCloneable<KeyedDungeonData>, IBufferMessage
	{
		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x000AF314 File Offset: 0x000AD514
		[DebuggerNonUserCode]
		public static MessageParser<KeyedDungeonData> Parser
		{
			get
			{
				return KeyedDungeonData._parser;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000AF32C File Offset: 0x000AD52C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x000AF350 File Offset: 0x000AD550
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KeyedDungeonData.Descriptor;
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x000AF367 File Offset: 0x000AD567
		[DebuggerNonUserCode]
		public KeyedDungeonData()
		{
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x000AF37C File Offset: 0x000AD57C
		[DebuggerNonUserCode]
		public KeyedDungeonData(KeyedDungeonData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.keyedDungeonTier_ = other.keyedDungeonTier_;
			this.reviveCount_ = other.reviveCount_;
			this.keyedDungeonGameId_ = ((other.keyedDungeonGameId_ != null) ? other.keyedDungeonGameId_.Clone() : null);
			this.snoDungeonAffixes_ = other.snoDungeonAffixes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x000AF400 File Offset: 0x000AD600
		[DebuggerNonUserCode]
		public KeyedDungeonData Clone()
		{
			return new KeyedDungeonData(this);
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x000AF418 File Offset: 0x000AD618
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x000AF449 File Offset: 0x000AD649
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = KeyedDungeonData.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000AF464 File Offset: 0x000AD664
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000AF481 File Offset: 0x000AD681
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x000AF494 File Offset: 0x000AD694
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x000AF4C5 File Offset: 0x000AD6C5
		[DebuggerNonUserCode]
		public int KeyedDungeonTier
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int keyedDungeonTierDefaultValue;
				if (flag)
				{
					keyedDungeonTierDefaultValue = this.keyedDungeonTier_;
				}
				else
				{
					keyedDungeonTierDefaultValue = KeyedDungeonData.KeyedDungeonTierDefaultValue;
				}
				return keyedDungeonTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.keyedDungeonTier_ = value;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x000AF4E0 File Offset: 0x000AD6E0
		[DebuggerNonUserCode]
		public bool HasKeyedDungeonTier
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000AF4FD File Offset: 0x000AD6FD
		[DebuggerNonUserCode]
		public void ClearKeyedDungeonTier()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x000AF510 File Offset: 0x000AD710
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x000AF541 File Offset: 0x000AD741
		[DebuggerNonUserCode]
		public int ReviveCount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int reviveCountDefaultValue;
				if (flag)
				{
					reviveCountDefaultValue = this.reviveCount_;
				}
				else
				{
					reviveCountDefaultValue = KeyedDungeonData.ReviveCountDefaultValue;
				}
				return reviveCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.reviveCount_ = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x000AF55C File Offset: 0x000AD75C
		[DebuggerNonUserCode]
		public bool HasReviveCount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x000AF579 File Offset: 0x000AD779
		[DebuggerNonUserCode]
		public void ClearReviveCount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002CBA RID: 11450 RVA: 0x000AF58C File Offset: 0x000AD78C
		// (set) Token: 0x06002CBB RID: 11451 RVA: 0x000AF5A4 File Offset: 0x000AD7A4
		[DebuggerNonUserCode]
		public GameHandle KeyedDungeonGameId
		{
			get
			{
				return this.keyedDungeonGameId_;
			}
			set
			{
				this.keyedDungeonGameId_ = value;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000AF5B0 File Offset: 0x000AD7B0
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoDungeonAffixes
		{
			get
			{
				return this.snoDungeonAffixes_;
			}
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000AF5C8 File Offset: 0x000AD7C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KeyedDungeonData);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000AF5E8 File Offset: 0x000AD7E8
		[DebuggerNonUserCode]
		public bool Equals(KeyedDungeonData other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.KeyedDungeonTier != other.KeyedDungeonTier;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ReviveCount != other.ReviveCount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.KeyedDungeonGameId, other.KeyedDungeonGameId);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.snoDungeonAffixes_.Equals(other.snoDungeonAffixes_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000AF6BC File Offset: 0x000AD8BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasKeyedDungeonTier = this.HasKeyedDungeonTier;
			if (hasKeyedDungeonTier)
			{
				num ^= this.KeyedDungeonTier.GetHashCode();
			}
			bool hasReviveCount = this.HasReviveCount;
			if (hasReviveCount)
			{
				num ^= this.ReviveCount.GetHashCode();
			}
			bool flag = this.keyedDungeonGameId_ != null;
			if (flag)
			{
				num ^= this.KeyedDungeonGameId.GetHashCode();
			}
			num ^= this.snoDungeonAffixes_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000AF770 File Offset: 0x000AD970
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000AF788 File Offset: 0x000AD988
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000AF794 File Offset: 0x000AD994
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoWorld);
			}
			bool hasKeyedDungeonTier = this.HasKeyedDungeonTier;
			if (hasKeyedDungeonTier)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.KeyedDungeonTier);
			}
			bool hasReviveCount = this.HasReviveCount;
			if (hasReviveCount)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.ReviveCount);
			}
			bool flag = this.keyedDungeonGameId_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.KeyedDungeonGameId);
			}
			this.snoDungeonAffixes_.WriteTo(ref output, KeyedDungeonData._repeated_snoDungeonAffixes_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000AF860 File Offset: 0x000ADA60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			bool hasKeyedDungeonTier = this.HasKeyedDungeonTier;
			if (hasKeyedDungeonTier)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.KeyedDungeonTier);
			}
			bool hasReviveCount = this.HasReviveCount;
			if (hasReviveCount)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ReviveCount);
			}
			bool flag = this.keyedDungeonGameId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KeyedDungeonGameId);
			}
			num += this.snoDungeonAffixes_.CalculateSize(KeyedDungeonData._repeated_snoDungeonAffixes_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000AF914 File Offset: 0x000ADB14
		[DebuggerNonUserCode]
		public void MergeFrom(KeyedDungeonData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasKeyedDungeonTier = other.HasKeyedDungeonTier;
				if (hasKeyedDungeonTier)
				{
					this.KeyedDungeonTier = other.KeyedDungeonTier;
				}
				bool hasReviveCount = other.HasReviveCount;
				if (hasReviveCount)
				{
					this.ReviveCount = other.ReviveCount;
				}
				bool flag2 = other.keyedDungeonGameId_ != null;
				if (flag2)
				{
					bool flag3 = this.keyedDungeonGameId_ == null;
					if (flag3)
					{
						this.KeyedDungeonGameId = new GameHandle();
					}
					this.KeyedDungeonGameId.MergeFrom(other.KeyedDungeonGameId);
				}
				this.snoDungeonAffixes_.Add(other.snoDungeonAffixes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000AF9E4 File Offset: 0x000ADBE4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000AF9F0 File Offset: 0x000ADBF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 != 13U)
					{
						if (num3 != 24U)
						{
							if (num3 != 32U)
							{
								goto IL_003A;
							}
							this.ReviveCount = input.ReadSInt32();
						}
						else
						{
							this.KeyedDungeonTier = input.ReadSInt32();
						}
					}
					else
					{
						this.SnoWorld = input.ReadSFixed32();
					}
				}
				else if (num3 != 42U)
				{
					if (num3 != 50U && num3 != 53U)
					{
						goto IL_003A;
					}
					this.snoDungeonAffixes_.AddEntriesFrom(ref input, KeyedDungeonData._repeated_snoDungeonAffixes_codec);
				}
				else
				{
					bool flag = this.keyedDungeonGameId_ == null;
					if (flag)
					{
						this.KeyedDungeonGameId = new GameHandle();
					}
					input.ReadMessage(this.KeyedDungeonGameId);
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400142B RID: 5163
		private static readonly MessageParser<KeyedDungeonData> _parser = new MessageParser<KeyedDungeonData>(() => new KeyedDungeonData());

		// Token: 0x0400142C RID: 5164
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400142D RID: 5165
		private int _hasBits0;

		// Token: 0x0400142E RID: 5166
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x0400142F RID: 5167
		private static readonly int SnoWorldDefaultValue = -1;

		// Token: 0x04001430 RID: 5168
		private int snoWorld_;

		// Token: 0x04001431 RID: 5169
		public const int KeyedDungeonTierFieldNumber = 3;

		// Token: 0x04001432 RID: 5170
		private static readonly int KeyedDungeonTierDefaultValue = -1;

		// Token: 0x04001433 RID: 5171
		private int keyedDungeonTier_;

		// Token: 0x04001434 RID: 5172
		public const int ReviveCountFieldNumber = 4;

		// Token: 0x04001435 RID: 5173
		private static readonly int ReviveCountDefaultValue = -1;

		// Token: 0x04001436 RID: 5174
		private int reviveCount_;

		// Token: 0x04001437 RID: 5175
		public const int KeyedDungeonGameIdFieldNumber = 5;

		// Token: 0x04001438 RID: 5176
		private GameHandle keyedDungeonGameId_;

		// Token: 0x04001439 RID: 5177
		public const int SnoDungeonAffixesFieldNumber = 6;

		// Token: 0x0400143A RID: 5178
		private static readonly FieldCodec<int> _repeated_snoDungeonAffixes_codec = FieldCodec.ForSFixed32(53U);

		// Token: 0x0400143B RID: 5179
		private readonly RepeatedField<int> snoDungeonAffixes_ = new RepeatedField<int>();
	}
}
