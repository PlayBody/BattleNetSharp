using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000164 RID: 356
	public sealed class Generator : IMessage<Generator>, IMessage, IEquatable<Generator>, IDeepCloneable<Generator>, IBufferMessage
	{
		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x0008ED98 File Offset: 0x0008CF98
		[DebuggerNonUserCode]
		public static MessageParser<Generator> Parser
		{
			get
			{
				return Generator._parser;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x0008EDB0 File Offset: 0x0008CFB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x0008EDD4 File Offset: 0x0008CFD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Generator.Descriptor;
			}
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x0008EDEB File Offset: 0x0008CFEB
		[DebuggerNonUserCode]
		public Generator()
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0008EE18 File Offset: 0x0008D018
		[DebuggerNonUserCode]
		public Generator(Generator other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.seed_ = other.seed_;
			this.snoItem_ = other.snoItem_;
			this.baseAffixes_ = other.baseAffixes_.Clone();
			this.rareItemName_ = ((other.rareItemName_ != null) ? other.rareItemName_.Clone() : null);
			this.flags_ = other.flags_;
			this.stackSize_ = other.stackSize_;
			this.snoDye_ = other.snoDye_;
			this.itemQualityLevel_ = other.itemQualityLevel_;
			this.itemBindingLevel_ = other.itemBindingLevel_;
			this.contents_ = other.contents_.Clone();
			this.itemPower_ = other.itemPower_;
			this.socketCount_ = other.socketCount_;
			this.dungeonKeyParams_ = ((other.dungeonKeyParams_ != null) ? other.dungeonKeyParams_.Clone() : null);
			this.imbuedAffixParams_ = ((other.imbuedAffixParams_ != null) ? other.imbuedAffixParams_.Clone() : null);
			this.durabilityPercent_ = other.durabilityPercent_;
			this.deathInfo_ = ((other.deathInfo_ != null) ? other.deathInfo_.Clone() : null);
			this.requiredLevel_ = other.requiredLevel_;
			this.itemQualityModifier_ = other.itemQualityModifier_;
			this.worldTier_ = other.worldTier_;
			this.dungeonLevel_ = other.dungeonLevel_;
			this.inherentRolledAffixes_ = other.inherentRolledAffixes_.Clone();
			this.enchantedAffixParams_ = ((other.enchantedAffixParams_ != null) ? other.enchantedAffixParams_.Clone() : null);
			this.itemUpgradesUsed_ = other.itemUpgradesUsed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x0008EFC0 File Offset: 0x0008D1C0
		[DebuggerNonUserCode]
		public Generator Clone()
		{
			return new Generator(this);
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x0008EFD8 File Offset: 0x0008D1D8
		// (set) Token: 0x060024DC RID: 9436 RVA: 0x0008F009 File Offset: 0x0008D209
		[DebuggerNonUserCode]
		public uint Seed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint seedDefaultValue;
				if (flag)
				{
					seedDefaultValue = this.seed_;
				}
				else
				{
					seedDefaultValue = Generator.SeedDefaultValue;
				}
				return seedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.seed_ = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x0008F024 File Offset: 0x0008D224
		[DebuggerNonUserCode]
		public bool HasSeed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x0008F041 File Offset: 0x0008D241
		[DebuggerNonUserCode]
		public void ClearSeed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x0008F054 File Offset: 0x0008D254
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x0008F085 File Offset: 0x0008D285
		[DebuggerNonUserCode]
		public int SnoItem
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoItemDefaultValue;
				if (flag)
				{
					snoItemDefaultValue = this.snoItem_;
				}
				else
				{
					snoItemDefaultValue = Generator.SnoItemDefaultValue;
				}
				return snoItemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoItem_ = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x0008F0A0 File Offset: 0x0008D2A0
		[DebuggerNonUserCode]
		public bool HasSnoItem
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0008F0BD File Offset: 0x0008D2BD
		[DebuggerNonUserCode]
		public void ClearSnoItem()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x0008F0D0 File Offset: 0x0008D2D0
		[DebuggerNonUserCode]
		public RepeatedField<int> BaseAffixes
		{
			get
			{
				return this.baseAffixes_;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x0008F0E8 File Offset: 0x0008D2E8
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x0008F100 File Offset: 0x0008D300
		[DebuggerNonUserCode]
		public RareItemName RareItemName
		{
			get
			{
				return this.rareItemName_;
			}
			set
			{
				this.rareItemName_ = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x0008F10C File Offset: 0x0008D30C
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x0008F13D File Offset: 0x0008D33D
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = Generator.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.flags_ = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x0008F158 File Offset: 0x0008D358
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0008F175 File Offset: 0x0008D375
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x0008F188 File Offset: 0x0008D388
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x0008F1B9 File Offset: 0x0008D3B9
		[DebuggerNonUserCode]
		public ulong StackSize
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong stackSizeDefaultValue;
				if (flag)
				{
					stackSizeDefaultValue = this.stackSize_;
				}
				else
				{
					stackSizeDefaultValue = Generator.StackSizeDefaultValue;
				}
				return stackSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.stackSize_ = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x0008F1D4 File Offset: 0x0008D3D4
		[DebuggerNonUserCode]
		public bool HasStackSize
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x0008F1F1 File Offset: 0x0008D3F1
		[DebuggerNonUserCode]
		public void ClearStackSize()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x0008F204 File Offset: 0x0008D404
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x0008F236 File Offset: 0x0008D436
		[DebuggerNonUserCode]
		public int SnoDye
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int snoDyeDefaultValue;
				if (flag)
				{
					snoDyeDefaultValue = this.snoDye_;
				}
				else
				{
					snoDyeDefaultValue = Generator.SnoDyeDefaultValue;
				}
				return snoDyeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.snoDye_ = value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x0008F250 File Offset: 0x0008D450
		[DebuggerNonUserCode]
		public bool HasSnoDye
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0008F26E File Offset: 0x0008D46E
		[DebuggerNonUserCode]
		public void ClearSnoDye()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x0008F280 File Offset: 0x0008D480
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x0008F2B2 File Offset: 0x0008D4B2
		[DebuggerNonUserCode]
		public int ItemQualityLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int itemQualityLevelDefaultValue;
				if (flag)
				{
					itemQualityLevelDefaultValue = this.itemQualityLevel_;
				}
				else
				{
					itemQualityLevelDefaultValue = Generator.ItemQualityLevelDefaultValue;
				}
				return itemQualityLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.itemQualityLevel_ = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x0008F2CC File Offset: 0x0008D4CC
		[DebuggerNonUserCode]
		public bool HasItemQualityLevel
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x0008F2EA File Offset: 0x0008D4EA
		[DebuggerNonUserCode]
		public void ClearItemQualityLevel()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x0008F2FC File Offset: 0x0008D4FC
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x0008F32E File Offset: 0x0008D52E
		[DebuggerNonUserCode]
		public int ItemBindingLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				int itemBindingLevelDefaultValue;
				if (flag)
				{
					itemBindingLevelDefaultValue = this.itemBindingLevel_;
				}
				else
				{
					itemBindingLevelDefaultValue = Generator.ItemBindingLevelDefaultValue;
				}
				return itemBindingLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.itemBindingLevel_ = value;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x0008F348 File Offset: 0x0008D548
		[DebuggerNonUserCode]
		public bool HasItemBindingLevel
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x0008F366 File Offset: 0x0008D566
		[DebuggerNonUserCode]
		public void ClearItemBindingLevel()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x0008F378 File Offset: 0x0008D578
		[DebuggerNonUserCode]
		public RepeatedField<EmbeddedGenerator> Contents
		{
			get
			{
				return this.contents_;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x0008F390 File Offset: 0x0008D590
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x0008F3C5 File Offset: 0x0008D5C5
		[DebuggerNonUserCode]
		public int ItemPower
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int itemPowerDefaultValue;
				if (flag)
				{
					itemPowerDefaultValue = this.itemPower_;
				}
				else
				{
					itemPowerDefaultValue = Generator.ItemPowerDefaultValue;
				}
				return itemPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.itemPower_ = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x0008F3E4 File Offset: 0x0008D5E4
		[DebuggerNonUserCode]
		public bool HasItemPower
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0008F405 File Offset: 0x0008D605
		[DebuggerNonUserCode]
		public void ClearItemPower()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x0008F41C File Offset: 0x0008D61C
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x0008F451 File Offset: 0x0008D651
		[DebuggerNonUserCode]
		public uint SocketCount
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint socketCountDefaultValue;
				if (flag)
				{
					socketCountDefaultValue = this.socketCount_;
				}
				else
				{
					socketCountDefaultValue = Generator.SocketCountDefaultValue;
				}
				return socketCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.socketCount_ = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x0008F470 File Offset: 0x0008D670
		[DebuggerNonUserCode]
		public bool HasSocketCount
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x0008F491 File Offset: 0x0008D691
		[DebuggerNonUserCode]
		public void ClearSocketCount()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x0008F4A8 File Offset: 0x0008D6A8
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x0008F4C0 File Offset: 0x0008D6C0
		[DebuggerNonUserCode]
		public DungeonKeyParams DungeonKeyParams
		{
			get
			{
				return this.dungeonKeyParams_;
			}
			set
			{
				this.dungeonKeyParams_ = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x0008F4CC File Offset: 0x0008D6CC
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x0008F4E4 File Offset: 0x0008D6E4
		[DebuggerNonUserCode]
		public ImbuedAffixParams ImbuedAffixParams
		{
			get
			{
				return this.imbuedAffixParams_;
			}
			set
			{
				this.imbuedAffixParams_ = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x0008F4F0 File Offset: 0x0008D6F0
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x0008F525 File Offset: 0x0008D725
		[DebuggerNonUserCode]
		public float DurabilityPercent
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				float durabilityPercentDefaultValue;
				if (flag)
				{
					durabilityPercentDefaultValue = this.durabilityPercent_;
				}
				else
				{
					durabilityPercentDefaultValue = Generator.DurabilityPercentDefaultValue;
				}
				return durabilityPercentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.durabilityPercent_ = value;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x0008F544 File Offset: 0x0008D744
		[DebuggerNonUserCode]
		public bool HasDurabilityPercent
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0008F565 File Offset: 0x0008D765
		[DebuggerNonUserCode]
		public void ClearDurabilityPercent()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x0008F57C File Offset: 0x0008D77C
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x0008F594 File Offset: 0x0008D794
		[DebuggerNonUserCode]
		public PvPDeathInfo DeathInfo
		{
			get
			{
				return this.deathInfo_;
			}
			set
			{
				this.deathInfo_ = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x0008F5A0 File Offset: 0x0008D7A0
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x0008F5D5 File Offset: 0x0008D7D5
		[DebuggerNonUserCode]
		public uint RequiredLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint requiredLevelDefaultValue;
				if (flag)
				{
					requiredLevelDefaultValue = this.requiredLevel_;
				}
				else
				{
					requiredLevelDefaultValue = Generator.RequiredLevelDefaultValue;
				}
				return requiredLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.requiredLevel_ = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x0008F5F4 File Offset: 0x0008D7F4
		[DebuggerNonUserCode]
		public bool HasRequiredLevel
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0008F615 File Offset: 0x0008D815
		[DebuggerNonUserCode]
		public void ClearRequiredLevel()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x0008F62C File Offset: 0x0008D82C
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x0008F661 File Offset: 0x0008D861
		[DebuggerNonUserCode]
		public int ItemQualityModifier
		{
			get
			{
				bool flag = (this._hasBits0 & 2048) != 0;
				int itemQualityModifierDefaultValue;
				if (flag)
				{
					itemQualityModifierDefaultValue = this.itemQualityModifier_;
				}
				else
				{
					itemQualityModifierDefaultValue = Generator.ItemQualityModifierDefaultValue;
				}
				return itemQualityModifierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2048;
				this.itemQualityModifier_ = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x0008F680 File Offset: 0x0008D880
		[DebuggerNonUserCode]
		public bool HasItemQualityModifier
		{
			get
			{
				return (this._hasBits0 & 2048) != 0;
			}
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0008F6A1 File Offset: 0x0008D8A1
		[DebuggerNonUserCode]
		public void ClearItemQualityModifier()
		{
			this._hasBits0 &= -2049;
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x0008F6B8 File Offset: 0x0008D8B8
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x0008F6ED File Offset: 0x0008D8ED
		[DebuggerNonUserCode]
		public int WorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 4096) != 0;
				int worldTierDefaultValue;
				if (flag)
				{
					worldTierDefaultValue = this.worldTier_;
				}
				else
				{
					worldTierDefaultValue = Generator.WorldTierDefaultValue;
				}
				return worldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4096;
				this.worldTier_ = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x0008F70C File Offset: 0x0008D90C
		[DebuggerNonUserCode]
		public bool HasWorldTier
		{
			get
			{
				return (this._hasBits0 & 4096) != 0;
			}
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x0008F72D File Offset: 0x0008D92D
		[DebuggerNonUserCode]
		public void ClearWorldTier()
		{
			this._hasBits0 &= -4097;
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x0008F744 File Offset: 0x0008D944
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x0008F779 File Offset: 0x0008D979
		[DebuggerNonUserCode]
		public int DungeonLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 8192) != 0;
				int dungeonLevelDefaultValue;
				if (flag)
				{
					dungeonLevelDefaultValue = this.dungeonLevel_;
				}
				else
				{
					dungeonLevelDefaultValue = Generator.DungeonLevelDefaultValue;
				}
				return dungeonLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8192;
				this.dungeonLevel_ = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0008F798 File Offset: 0x0008D998
		[DebuggerNonUserCode]
		public bool HasDungeonLevel
		{
			get
			{
				return (this._hasBits0 & 8192) != 0;
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x0008F7B9 File Offset: 0x0008D9B9
		[DebuggerNonUserCode]
		public void ClearDungeonLevel()
		{
			this._hasBits0 &= -8193;
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x0008F7D0 File Offset: 0x0008D9D0
		[DebuggerNonUserCode]
		public RepeatedField<int> InherentRolledAffixes
		{
			get
			{
				return this.inherentRolledAffixes_;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0008F7E8 File Offset: 0x0008D9E8
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x0008F800 File Offset: 0x0008DA00
		[DebuggerNonUserCode]
		public EnchantedAffixParams EnchantedAffixParams
		{
			get
			{
				return this.enchantedAffixParams_;
			}
			set
			{
				this.enchantedAffixParams_ = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x0008F80C File Offset: 0x0008DA0C
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x0008F841 File Offset: 0x0008DA41
		[DebuggerNonUserCode]
		public int ItemUpgradesUsed
		{
			get
			{
				bool flag = (this._hasBits0 & 16384) != 0;
				int itemUpgradesUsedDefaultValue;
				if (flag)
				{
					itemUpgradesUsedDefaultValue = this.itemUpgradesUsed_;
				}
				else
				{
					itemUpgradesUsedDefaultValue = Generator.ItemUpgradesUsedDefaultValue;
				}
				return itemUpgradesUsedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16384;
				this.itemUpgradesUsed_ = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x0008F860 File Offset: 0x0008DA60
		[DebuggerNonUserCode]
		public bool HasItemUpgradesUsed
		{
			get
			{
				return (this._hasBits0 & 16384) != 0;
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x0008F881 File Offset: 0x0008DA81
		[DebuggerNonUserCode]
		public void ClearItemUpgradesUsed()
		{
			this._hasBits0 &= -16385;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0008F898 File Offset: 0x0008DA98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Generator);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0008F8B8 File Offset: 0x0008DAB8
		[DebuggerNonUserCode]
		public bool Equals(Generator other)
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
					bool flag4 = this.Seed != other.Seed;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoItem != other.SnoItem;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.baseAffixes_.Equals(other.baseAffixes_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.RareItemName, other.RareItemName);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Flags != other.Flags;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.StackSize != other.StackSize;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SnoDye != other.SnoDye;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ItemQualityLevel != other.ItemQualityLevel;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ItemBindingLevel != other.ItemBindingLevel;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.contents_.Equals(other.contents_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.ItemPower != other.ItemPower;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.SocketCount != other.SocketCount;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !object.Equals(this.DungeonKeyParams, other.DungeonKeyParams);
																	if (flag16)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag17 = !object.Equals(this.ImbuedAffixParams, other.ImbuedAffixParams);
																		if (flag17)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag18 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DurabilityPercent, other.DurabilityPercent);
																			if (flag18)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag19 = !object.Equals(this.DeathInfo, other.DeathInfo);
																				if (flag19)
																				{
																					flag2 = false;
																				}
																				else
																				{
																					bool flag20 = this.RequiredLevel != other.RequiredLevel;
																					if (flag20)
																					{
																						flag2 = false;
																					}
																					else
																					{
																						bool flag21 = this.ItemQualityModifier != other.ItemQualityModifier;
																						if (flag21)
																						{
																							flag2 = false;
																						}
																						else
																						{
																							bool flag22 = this.WorldTier != other.WorldTier;
																							if (flag22)
																							{
																								flag2 = false;
																							}
																							else
																							{
																								bool flag23 = this.DungeonLevel != other.DungeonLevel;
																								if (flag23)
																								{
																									flag2 = false;
																								}
																								else
																								{
																									bool flag24 = !this.inherentRolledAffixes_.Equals(other.inherentRolledAffixes_);
																									if (flag24)
																									{
																										flag2 = false;
																									}
																									else
																									{
																										bool flag25 = !object.Equals(this.EnchantedAffixParams, other.EnchantedAffixParams);
																										if (flag25)
																										{
																											flag2 = false;
																										}
																										else
																										{
																											bool flag26 = this.ItemUpgradesUsed != other.ItemUpgradesUsed;
																											flag2 = !flag26 && object.Equals(this._unknownFields, other._unknownFields);
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0008FBC0 File Offset: 0x0008DDC0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num ^= this.Seed.GetHashCode();
			}
			bool hasSnoItem = this.HasSnoItem;
			if (hasSnoItem)
			{
				num ^= this.SnoItem.GetHashCode();
			}
			num ^= this.baseAffixes_.GetHashCode();
			bool flag = this.rareItemName_ != null;
			if (flag)
			{
				num ^= this.RareItemName.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool hasStackSize = this.HasStackSize;
			if (hasStackSize)
			{
				num ^= this.StackSize.GetHashCode();
			}
			bool hasSnoDye = this.HasSnoDye;
			if (hasSnoDye)
			{
				num ^= this.SnoDye.GetHashCode();
			}
			bool hasItemQualityLevel = this.HasItemQualityLevel;
			if (hasItemQualityLevel)
			{
				num ^= this.ItemQualityLevel.GetHashCode();
			}
			bool hasItemBindingLevel = this.HasItemBindingLevel;
			if (hasItemBindingLevel)
			{
				num ^= this.ItemBindingLevel.GetHashCode();
			}
			num ^= this.contents_.GetHashCode();
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num ^= this.ItemPower.GetHashCode();
			}
			bool hasSocketCount = this.HasSocketCount;
			if (hasSocketCount)
			{
				num ^= this.SocketCount.GetHashCode();
			}
			bool flag2 = this.dungeonKeyParams_ != null;
			if (flag2)
			{
				num ^= this.DungeonKeyParams.GetHashCode();
			}
			bool flag3 = this.imbuedAffixParams_ != null;
			if (flag3)
			{
				num ^= this.ImbuedAffixParams.GetHashCode();
			}
			bool hasDurabilityPercent = this.HasDurabilityPercent;
			if (hasDurabilityPercent)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DurabilityPercent);
			}
			bool flag4 = this.deathInfo_ != null;
			if (flag4)
			{
				num ^= this.DeathInfo.GetHashCode();
			}
			bool hasRequiredLevel = this.HasRequiredLevel;
			if (hasRequiredLevel)
			{
				num ^= this.RequiredLevel.GetHashCode();
			}
			bool hasItemQualityModifier = this.HasItemQualityModifier;
			if (hasItemQualityModifier)
			{
				num ^= this.ItemQualityModifier.GetHashCode();
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num ^= this.WorldTier.GetHashCode();
			}
			bool hasDungeonLevel = this.HasDungeonLevel;
			if (hasDungeonLevel)
			{
				num ^= this.DungeonLevel.GetHashCode();
			}
			num ^= this.inherentRolledAffixes_.GetHashCode();
			bool flag5 = this.enchantedAffixParams_ != null;
			if (flag5)
			{
				num ^= this.EnchantedAffixParams.GetHashCode();
			}
			bool hasItemUpgradesUsed = this.HasItemUpgradesUsed;
			if (hasItemUpgradesUsed)
			{
				num ^= this.ItemUpgradesUsed.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0008FE6C File Offset: 0x0008E06C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0008FE84 File Offset: 0x0008E084
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x0008FE90 File Offset: 0x0008E090
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Seed);
			}
			bool hasSnoItem = this.HasSnoItem;
			if (hasSnoItem)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SnoItem);
			}
			this.baseAffixes_.WriteTo(ref output, Generator._repeated_baseAffixes_codec);
			bool flag = this.rareItemName_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RareItemName);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Flags);
			}
			bool hasStackSize = this.HasStackSize;
			if (hasStackSize)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.StackSize);
			}
			bool hasSnoDye = this.HasSnoDye;
			if (hasSnoDye)
			{
				output.WriteRawTag(61);
				output.WriteSFixed32(this.SnoDye);
			}
			bool hasItemQualityLevel = this.HasItemQualityLevel;
			if (hasItemQualityLevel)
			{
				output.WriteRawTag(64);
				output.WriteSInt32(this.ItemQualityLevel);
			}
			bool hasItemBindingLevel = this.HasItemBindingLevel;
			if (hasItemBindingLevel)
			{
				output.WriteRawTag(72);
				output.WriteSInt32(this.ItemBindingLevel);
			}
			this.contents_.WriteTo(ref output, Generator._repeated_contents_codec);
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				output.WriteRawTag(128, 1);
				output.WriteSInt32(this.ItemPower);
			}
			bool hasSocketCount = this.HasSocketCount;
			if (hasSocketCount)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt32(this.SocketCount);
			}
			bool flag2 = this.dungeonKeyParams_ != null;
			if (flag2)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.DungeonKeyParams);
			}
			bool flag3 = this.imbuedAffixParams_ != null;
			if (flag3)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.ImbuedAffixParams);
			}
			bool hasDurabilityPercent = this.HasDurabilityPercent;
			if (hasDurabilityPercent)
			{
				output.WriteRawTag(173, 1);
				output.WriteFloat(this.DurabilityPercent);
			}
			bool flag4 = this.deathInfo_ != null;
			if (flag4)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.DeathInfo);
			}
			bool hasRequiredLevel = this.HasRequiredLevel;
			if (hasRequiredLevel)
			{
				output.WriteRawTag(184, 1);
				output.WriteUInt32(this.RequiredLevel);
			}
			bool hasItemQualityModifier = this.HasItemQualityModifier;
			if (hasItemQualityModifier)
			{
				output.WriteRawTag(192, 1);
				output.WriteSInt32(this.ItemQualityModifier);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				output.WriteRawTag(200, 1);
				output.WriteSInt32(this.WorldTier);
			}
			bool hasDungeonLevel = this.HasDungeonLevel;
			if (hasDungeonLevel)
			{
				output.WriteRawTag(208, 1);
				output.WriteSInt32(this.DungeonLevel);
			}
			this.inherentRolledAffixes_.WriteTo(ref output, Generator._repeated_inherentRolledAffixes_codec);
			bool flag5 = this.enchantedAffixParams_ != null;
			if (flag5)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.EnchantedAffixParams);
			}
			bool hasItemUpgradesUsed = this.HasItemUpgradesUsed;
			if (hasItemUpgradesUsed)
			{
				output.WriteRawTag(232, 1);
				output.WriteSInt32(this.ItemUpgradesUsed);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000901F8 File Offset: 0x0008E3F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Seed);
			}
			bool hasSnoItem = this.HasSnoItem;
			if (hasSnoItem)
			{
				num += 5;
			}
			num += this.baseAffixes_.CalculateSize(Generator._repeated_baseAffixes_codec);
			bool flag = this.rareItemName_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RareItemName);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			bool hasStackSize = this.HasStackSize;
			if (hasStackSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StackSize);
			}
			bool hasSnoDye = this.HasSnoDye;
			if (hasSnoDye)
			{
				num += 5;
			}
			bool hasItemQualityLevel = this.HasItemQualityLevel;
			if (hasItemQualityLevel)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ItemQualityLevel);
			}
			bool hasItemBindingLevel = this.HasItemBindingLevel;
			if (hasItemBindingLevel)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ItemBindingLevel);
			}
			num += this.contents_.CalculateSize(Generator._repeated_contents_codec);
			bool hasItemPower = this.HasItemPower;
			if (hasItemPower)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.ItemPower);
			}
			bool hasSocketCount = this.HasSocketCount;
			if (hasSocketCount)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.SocketCount);
			}
			bool flag2 = this.dungeonKeyParams_ != null;
			if (flag2)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DungeonKeyParams);
			}
			bool flag3 = this.imbuedAffixParams_ != null;
			if (flag3)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ImbuedAffixParams);
			}
			bool hasDurabilityPercent = this.HasDurabilityPercent;
			if (hasDurabilityPercent)
			{
				num += 6;
			}
			bool flag4 = this.deathInfo_ != null;
			if (flag4)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DeathInfo);
			}
			bool hasRequiredLevel = this.HasRequiredLevel;
			if (hasRequiredLevel)
			{
				num += 2 + CodedOutputStream.ComputeUInt32Size(this.RequiredLevel);
			}
			bool hasItemQualityModifier = this.HasItemQualityModifier;
			if (hasItemQualityModifier)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.ItemQualityModifier);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.WorldTier);
			}
			bool hasDungeonLevel = this.HasDungeonLevel;
			if (hasDungeonLevel)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.DungeonLevel);
			}
			num += this.inherentRolledAffixes_.CalculateSize(Generator._repeated_inherentRolledAffixes_codec);
			bool flag5 = this.enchantedAffixParams_ != null;
			if (flag5)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EnchantedAffixParams);
			}
			bool hasItemUpgradesUsed = this.HasItemUpgradesUsed;
			if (hasItemUpgradesUsed)
			{
				num += 2 + CodedOutputStream.ComputeSInt32Size(this.ItemUpgradesUsed);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000904A4 File Offset: 0x0008E6A4
		[DebuggerNonUserCode]
		public void MergeFrom(Generator other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSeed = other.HasSeed;
				if (hasSeed)
				{
					this.Seed = other.Seed;
				}
				bool hasSnoItem = other.HasSnoItem;
				if (hasSnoItem)
				{
					this.SnoItem = other.SnoItem;
				}
				this.baseAffixes_.Add(other.baseAffixes_);
				bool flag2 = other.rareItemName_ != null;
				if (flag2)
				{
					bool flag3 = this.rareItemName_ == null;
					if (flag3)
					{
						this.RareItemName = new RareItemName();
					}
					this.RareItemName.MergeFrom(other.RareItemName);
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				bool hasStackSize = other.HasStackSize;
				if (hasStackSize)
				{
					this.StackSize = other.StackSize;
				}
				bool hasSnoDye = other.HasSnoDye;
				if (hasSnoDye)
				{
					this.SnoDye = other.SnoDye;
				}
				bool hasItemQualityLevel = other.HasItemQualityLevel;
				if (hasItemQualityLevel)
				{
					this.ItemQualityLevel = other.ItemQualityLevel;
				}
				bool hasItemBindingLevel = other.HasItemBindingLevel;
				if (hasItemBindingLevel)
				{
					this.ItemBindingLevel = other.ItemBindingLevel;
				}
				this.contents_.Add(other.contents_);
				bool hasItemPower = other.HasItemPower;
				if (hasItemPower)
				{
					this.ItemPower = other.ItemPower;
				}
				bool hasSocketCount = other.HasSocketCount;
				if (hasSocketCount)
				{
					this.SocketCount = other.SocketCount;
				}
				bool flag4 = other.dungeonKeyParams_ != null;
				if (flag4)
				{
					bool flag5 = this.dungeonKeyParams_ == null;
					if (flag5)
					{
						this.DungeonKeyParams = new DungeonKeyParams();
					}
					this.DungeonKeyParams.MergeFrom(other.DungeonKeyParams);
				}
				bool flag6 = other.imbuedAffixParams_ != null;
				if (flag6)
				{
					bool flag7 = this.imbuedAffixParams_ == null;
					if (flag7)
					{
						this.ImbuedAffixParams = new ImbuedAffixParams();
					}
					this.ImbuedAffixParams.MergeFrom(other.ImbuedAffixParams);
				}
				bool hasDurabilityPercent = other.HasDurabilityPercent;
				if (hasDurabilityPercent)
				{
					this.DurabilityPercent = other.DurabilityPercent;
				}
				bool flag8 = other.deathInfo_ != null;
				if (flag8)
				{
					bool flag9 = this.deathInfo_ == null;
					if (flag9)
					{
						this.DeathInfo = new PvPDeathInfo();
					}
					this.DeathInfo.MergeFrom(other.DeathInfo);
				}
				bool hasRequiredLevel = other.HasRequiredLevel;
				if (hasRequiredLevel)
				{
					this.RequiredLevel = other.RequiredLevel;
				}
				bool hasItemQualityModifier = other.HasItemQualityModifier;
				if (hasItemQualityModifier)
				{
					this.ItemQualityModifier = other.ItemQualityModifier;
				}
				bool hasWorldTier = other.HasWorldTier;
				if (hasWorldTier)
				{
					this.WorldTier = other.WorldTier;
				}
				bool hasDungeonLevel = other.HasDungeonLevel;
				if (hasDungeonLevel)
				{
					this.DungeonLevel = other.DungeonLevel;
				}
				this.inherentRolledAffixes_.Add(other.inherentRolledAffixes_);
				bool flag10 = other.enchantedAffixParams_ != null;
				if (flag10)
				{
					bool flag11 = this.enchantedAffixParams_ == null;
					if (flag11)
					{
						this.EnchantedAffixParams = new EnchantedAffixParams();
					}
					this.EnchantedAffixParams.MergeFrom(other.EnchantedAffixParams);
				}
				bool hasItemUpgradesUsed = other.HasItemUpgradesUsed;
				if (hasItemUpgradesUsed)
				{
					this.ItemUpgradesUsed = other.ItemUpgradesUsed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000907DC File Offset: 0x0008E9DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000907E8 File Offset: 0x0008E9E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 128U)
				{
					if (num3 <= 40U)
					{
						if (num3 <= 26U)
						{
							if (num3 == 8U)
							{
								this.Seed = input.ReadUInt32();
								continue;
							}
							if (num3 == 21U)
							{
								this.SnoItem = input.ReadSFixed32();
								continue;
							}
							if (num3 != 26U)
							{
								goto IL_0177;
							}
						}
						else if (num3 != 29U)
						{
							if (num3 == 34U)
							{
								bool flag = this.rareItemName_ == null;
								if (flag)
								{
									this.RareItemName = new RareItemName();
								}
								input.ReadMessage(this.RareItemName);
								continue;
							}
							if (num3 != 40U)
							{
								goto IL_0177;
							}
							this.Flags = input.ReadUInt32();
							continue;
						}
						this.baseAffixes_.AddEntriesFrom(ref input, Generator._repeated_baseAffixes_codec);
					}
					else if (num3 <= 64U)
					{
						if (num3 != 48U)
						{
							if (num3 != 61U)
							{
								if (num3 != 64U)
								{
									goto IL_0177;
								}
								this.ItemQualityLevel = input.ReadSInt32();
							}
							else
							{
								this.SnoDye = input.ReadSFixed32();
							}
						}
						else
						{
							this.StackSize = input.ReadUInt64();
						}
					}
					else if (num3 != 72U)
					{
						if (num3 != 82U)
						{
							if (num3 != 128U)
							{
								goto IL_0177;
							}
							this.ItemPower = input.ReadSInt32();
						}
						else
						{
							this.contents_.AddEntriesFrom(ref input, Generator._repeated_contents_codec);
						}
					}
					else
					{
						this.ItemBindingLevel = input.ReadSInt32();
					}
				}
				else if (num3 <= 184U)
				{
					if (num3 <= 162U)
					{
						if (num3 != 144U)
						{
							if (num3 != 154U)
							{
								if (num3 != 162U)
								{
									goto IL_0177;
								}
								bool flag2 = this.imbuedAffixParams_ == null;
								if (flag2)
								{
									this.ImbuedAffixParams = new ImbuedAffixParams();
								}
								input.ReadMessage(this.ImbuedAffixParams);
							}
							else
							{
								bool flag3 = this.dungeonKeyParams_ == null;
								if (flag3)
								{
									this.DungeonKeyParams = new DungeonKeyParams();
								}
								input.ReadMessage(this.DungeonKeyParams);
							}
						}
						else
						{
							this.SocketCount = input.ReadUInt32();
						}
					}
					else if (num3 != 173U)
					{
						if (num3 != 178U)
						{
							if (num3 != 184U)
							{
								goto IL_0177;
							}
							this.RequiredLevel = input.ReadUInt32();
						}
						else
						{
							bool flag4 = this.deathInfo_ == null;
							if (flag4)
							{
								this.DeathInfo = new PvPDeathInfo();
							}
							input.ReadMessage(this.DeathInfo);
						}
					}
					else
					{
						this.DurabilityPercent = input.ReadFloat();
					}
				}
				else if (num3 <= 208U)
				{
					if (num3 != 192U)
					{
						if (num3 != 200U)
						{
							if (num3 != 208U)
							{
								goto IL_0177;
							}
							this.DungeonLevel = input.ReadSInt32();
						}
						else
						{
							this.WorldTier = input.ReadSInt32();
						}
					}
					else
					{
						this.ItemQualityModifier = input.ReadSInt32();
					}
				}
				else if (num3 <= 221U)
				{
					if (num3 != 218U && num3 != 221U)
					{
						goto IL_0177;
					}
					this.inherentRolledAffixes_.AddEntriesFrom(ref input, Generator._repeated_inherentRolledAffixes_codec);
				}
				else if (num3 != 226U)
				{
					if (num3 != 232U)
					{
						goto IL_0177;
					}
					this.ItemUpgradesUsed = input.ReadSInt32();
				}
				else
				{
					bool flag5 = this.enchantedAffixParams_ == null;
					if (flag5)
					{
						this.EnchantedAffixParams = new EnchantedAffixParams();
					}
					input.ReadMessage(this.EnchantedAffixParams);
				}
				continue;
				IL_0177:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400102F RID: 4143
		private static readonly MessageParser<Generator> _parser = new MessageParser<Generator>(() => new Generator());

		// Token: 0x04001030 RID: 4144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001031 RID: 4145
		private int _hasBits0;

		// Token: 0x04001032 RID: 4146
		public const int SeedFieldNumber = 1;

		// Token: 0x04001033 RID: 4147
		private static readonly uint SeedDefaultValue = 0U;

		// Token: 0x04001034 RID: 4148
		private uint seed_;

		// Token: 0x04001035 RID: 4149
		public const int SnoItemFieldNumber = 2;

		// Token: 0x04001036 RID: 4150
		private static readonly int SnoItemDefaultValue = -1;

		// Token: 0x04001037 RID: 4151
		private int snoItem_;

		// Token: 0x04001038 RID: 4152
		public const int BaseAffixesFieldNumber = 3;

		// Token: 0x04001039 RID: 4153
		private static readonly FieldCodec<int> _repeated_baseAffixes_codec = FieldCodec.ForSFixed32(29U);

		// Token: 0x0400103A RID: 4154
		private readonly RepeatedField<int> baseAffixes_ = new RepeatedField<int>();

		// Token: 0x0400103B RID: 4155
		public const int RareItemNameFieldNumber = 4;

		// Token: 0x0400103C RID: 4156
		private RareItemName rareItemName_;

		// Token: 0x0400103D RID: 4157
		public const int FlagsFieldNumber = 5;

		// Token: 0x0400103E RID: 4158
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x0400103F RID: 4159
		private uint flags_;

		// Token: 0x04001040 RID: 4160
		public const int StackSizeFieldNumber = 6;

		// Token: 0x04001041 RID: 4161
		private static readonly ulong StackSizeDefaultValue = 0UL;

		// Token: 0x04001042 RID: 4162
		private ulong stackSize_;

		// Token: 0x04001043 RID: 4163
		public const int SnoDyeFieldNumber = 7;

		// Token: 0x04001044 RID: 4164
		private static readonly int SnoDyeDefaultValue = -1;

		// Token: 0x04001045 RID: 4165
		private int snoDye_;

		// Token: 0x04001046 RID: 4166
		public const int ItemQualityLevelFieldNumber = 8;

		// Token: 0x04001047 RID: 4167
		private static readonly int ItemQualityLevelDefaultValue = 1;

		// Token: 0x04001048 RID: 4168
		private int itemQualityLevel_;

		// Token: 0x04001049 RID: 4169
		public const int ItemBindingLevelFieldNumber = 9;

		// Token: 0x0400104A RID: 4170
		private static readonly int ItemBindingLevelDefaultValue = 0;

		// Token: 0x0400104B RID: 4171
		private int itemBindingLevel_;

		// Token: 0x0400104C RID: 4172
		public const int ContentsFieldNumber = 10;

		// Token: 0x0400104D RID: 4173
		private static readonly FieldCodec<EmbeddedGenerator> _repeated_contents_codec = FieldCodec.ForMessage<EmbeddedGenerator>(82U, EmbeddedGenerator.Parser);

		// Token: 0x0400104E RID: 4174
		private readonly RepeatedField<EmbeddedGenerator> contents_ = new RepeatedField<EmbeddedGenerator>();

		// Token: 0x0400104F RID: 4175
		public const int ItemPowerFieldNumber = 16;

		// Token: 0x04001050 RID: 4176
		private static readonly int ItemPowerDefaultValue = 0;

		// Token: 0x04001051 RID: 4177
		private int itemPower_;

		// Token: 0x04001052 RID: 4178
		public const int SocketCountFieldNumber = 18;

		// Token: 0x04001053 RID: 4179
		private static readonly uint SocketCountDefaultValue = 0U;

		// Token: 0x04001054 RID: 4180
		private uint socketCount_;

		// Token: 0x04001055 RID: 4181
		public const int DungeonKeyParamsFieldNumber = 19;

		// Token: 0x04001056 RID: 4182
		private DungeonKeyParams dungeonKeyParams_;

		// Token: 0x04001057 RID: 4183
		public const int ImbuedAffixParamsFieldNumber = 20;

		// Token: 0x04001058 RID: 4184
		private ImbuedAffixParams imbuedAffixParams_;

		// Token: 0x04001059 RID: 4185
		public const int DurabilityPercentFieldNumber = 21;

		// Token: 0x0400105A RID: 4186
		private static readonly float DurabilityPercentDefaultValue = 1f;

		// Token: 0x0400105B RID: 4187
		private float durabilityPercent_;

		// Token: 0x0400105C RID: 4188
		public const int DeathInfoFieldNumber = 22;

		// Token: 0x0400105D RID: 4189
		private PvPDeathInfo deathInfo_;

		// Token: 0x0400105E RID: 4190
		public const int RequiredLevelFieldNumber = 23;

		// Token: 0x0400105F RID: 4191
		private static readonly uint RequiredLevelDefaultValue = 0U;

		// Token: 0x04001060 RID: 4192
		private uint requiredLevel_;

		// Token: 0x04001061 RID: 4193
		public const int ItemQualityModifierFieldNumber = 24;

		// Token: 0x04001062 RID: 4194
		private static readonly int ItemQualityModifierDefaultValue = 0;

		// Token: 0x04001063 RID: 4195
		private int itemQualityModifier_;

		// Token: 0x04001064 RID: 4196
		public const int WorldTierFieldNumber = 25;

		// Token: 0x04001065 RID: 4197
		private static readonly int WorldTierDefaultValue = -1;

		// Token: 0x04001066 RID: 4198
		private int worldTier_;

		// Token: 0x04001067 RID: 4199
		public const int DungeonLevelFieldNumber = 26;

		// Token: 0x04001068 RID: 4200
		private static readonly int DungeonLevelDefaultValue = -1;

		// Token: 0x04001069 RID: 4201
		private int dungeonLevel_;

		// Token: 0x0400106A RID: 4202
		public const int InherentRolledAffixesFieldNumber = 27;

		// Token: 0x0400106B RID: 4203
		private static readonly FieldCodec<int> _repeated_inherentRolledAffixes_codec = FieldCodec.ForSFixed32(221U);

		// Token: 0x0400106C RID: 4204
		private readonly RepeatedField<int> inherentRolledAffixes_ = new RepeatedField<int>();

		// Token: 0x0400106D RID: 4205
		public const int EnchantedAffixParamsFieldNumber = 28;

		// Token: 0x0400106E RID: 4206
		private EnchantedAffixParams enchantedAffixParams_;

		// Token: 0x0400106F RID: 4207
		public const int ItemUpgradesUsedFieldNumber = 29;

		// Token: 0x04001070 RID: 4208
		private static readonly int ItemUpgradesUsedDefaultValue = 0;

		// Token: 0x04001071 RID: 4209
		private int itemUpgradesUsed_;
	}
}
