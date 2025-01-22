using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200013F RID: 319
	public sealed class GameCreateParams : IMessage<GameCreateParams>, IMessage, IEquatable<GameCreateParams>, IDeepCloneable<GameCreateParams>, IBufferMessage
	{
		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0008031C File Offset: 0x0007E51C
		[DebuggerNonUserCode]
		public static MessageParser<GameCreateParams> Parser
		{
			get
			{
				return GameCreateParams._parser;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x00080334 File Offset: 0x0007E534
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x00080358 File Offset: 0x0007E558
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameCreateParams.Descriptor;
			}
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0008036F File Offset: 0x0007E56F
		[DebuggerNonUserCode]
		public GameCreateParams()
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0008037C File Offset: 0x0007E57C
		[DebuggerNonUserCode]
		public GameCreateParams(GameCreateParams other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameType_ = other.gameType_;
			this.creationFlags_ = other.creationFlags_;
			this.snoSubzone_ = other.snoSubzone_;
			this.snoWorld_ = other.snoWorld_;
			this.itempowerBracket_ = other.itempowerBracket_;
			this.name_ = other.name_;
			this.partitionType_ = other.partitionType_;
			this.serverPool_ = other.serverPool_;
			this.campaignState_ = ((other.campaignState_ != null) ? other.campaignState_.Clone() : null);
			this.pvpBucket_ = other.pvpBucket_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00080438 File Offset: 0x0007E638
		[DebuggerNonUserCode]
		public GameCreateParams Clone()
		{
			return new GameCreateParams(this);
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x00080450 File Offset: 0x0007E650
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x00080481 File Offset: 0x0007E681
		[DebuggerNonUserCode]
		public int GameType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int gameTypeDefaultValue;
				if (flag)
				{
					gameTypeDefaultValue = this.gameType_;
				}
				else
				{
					gameTypeDefaultValue = GameCreateParams.GameTypeDefaultValue;
				}
				return gameTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameType_ = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0008049C File Offset: 0x0007E69C
		[DebuggerNonUserCode]
		public bool HasGameType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000804B9 File Offset: 0x0007E6B9
		[DebuggerNonUserCode]
		public void ClearGameType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x000804CC File Offset: 0x0007E6CC
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x000804FD File Offset: 0x0007E6FD
		[DebuggerNonUserCode]
		public uint CreationFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint creationFlagsDefaultValue;
				if (flag)
				{
					creationFlagsDefaultValue = this.creationFlags_;
				}
				else
				{
					creationFlagsDefaultValue = GameCreateParams.CreationFlagsDefaultValue;
				}
				return creationFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.creationFlags_ = value;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x00080518 File Offset: 0x0007E718
		[DebuggerNonUserCode]
		public bool HasCreationFlags
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00080535 File Offset: 0x0007E735
		[DebuggerNonUserCode]
		public void ClearCreationFlags()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x00080548 File Offset: 0x0007E748
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x00080579 File Offset: 0x0007E779
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = GameCreateParams.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x00080594 File Offset: 0x0007E794
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000805B1 File Offset: 0x0007E7B1
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x000805C4 File Offset: 0x0007E7C4
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x000805F5 File Offset: 0x0007E7F5
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = GameCreateParams.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x00080610 File Offset: 0x0007E810
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0008062D File Offset: 0x0007E82D
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x00080640 File Offset: 0x0007E840
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x00080672 File Offset: 0x0007E872
		[DebuggerNonUserCode]
		public uint ItempowerBracket
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint itempowerBracketDefaultValue;
				if (flag)
				{
					itempowerBracketDefaultValue = this.itempowerBracket_;
				}
				else
				{
					itempowerBracketDefaultValue = GameCreateParams.ItempowerBracketDefaultValue;
				}
				return itempowerBracketDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.itempowerBracket_ = value;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0008068C File Offset: 0x0007E88C
		[DebuggerNonUserCode]
		public bool HasItempowerBracket
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000806AA File Offset: 0x0007E8AA
		[DebuggerNonUserCode]
		public void ClearItempowerBracket()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x000806BC File Offset: 0x0007E8BC
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x000806DD File Offset: 0x0007E8DD
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? GameCreateParams.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000806F4 File Offset: 0x0007E8F4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0008070F File Offset: 0x0007E90F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0008071C File Offset: 0x0007E91C
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0008074E File Offset: 0x0007E94E
		[DebuggerNonUserCode]
		public uint PartitionType
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint partitionTypeDefaultValue;
				if (flag)
				{
					partitionTypeDefaultValue = this.partitionType_;
				}
				else
				{
					partitionTypeDefaultValue = GameCreateParams.PartitionTypeDefaultValue;
				}
				return partitionTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.partitionType_ = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x00080768 File Offset: 0x0007E968
		[DebuggerNonUserCode]
		public bool HasPartitionType
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00080786 File Offset: 0x0007E986
		[DebuggerNonUserCode]
		public void ClearPartitionType()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x00080798 File Offset: 0x0007E998
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x000807B9 File Offset: 0x0007E9B9
		[DebuggerNonUserCode]
		public string ServerPool
		{
			get
			{
				return this.serverPool_ ?? GameCreateParams.ServerPoolDefaultValue;
			}
			set
			{
				this.serverPool_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x000807D0 File Offset: 0x0007E9D0
		[DebuggerNonUserCode]
		public bool HasServerPool
		{
			get
			{
				return this.serverPool_ != null;
			}
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000807EB File Offset: 0x0007E9EB
		[DebuggerNonUserCode]
		public void ClearServerPool()
		{
			this.serverPool_ = null;
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x000807F8 File Offset: 0x0007E9F8
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x00080810 File Offset: 0x0007EA10
		[DebuggerNonUserCode]
		public CampaignState CampaignState
		{
			get
			{
				return this.campaignState_;
			}
			set
			{
				this.campaignState_ = value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0008081C File Offset: 0x0007EA1C
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x0008084E File Offset: 0x0007EA4E
		[DebuggerNonUserCode]
		public uint PvpBucket
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint pvpBucketDefaultValue;
				if (flag)
				{
					pvpBucketDefaultValue = this.pvpBucket_;
				}
				else
				{
					pvpBucketDefaultValue = GameCreateParams.PvpBucketDefaultValue;
				}
				return pvpBucketDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.pvpBucket_ = value;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x00080868 File Offset: 0x0007EA68
		[DebuggerNonUserCode]
		public bool HasPvpBucket
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00080886 File Offset: 0x0007EA86
		[DebuggerNonUserCode]
		public void ClearPvpBucket()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00080898 File Offset: 0x0007EA98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameCreateParams);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000808B8 File Offset: 0x0007EAB8
		[DebuggerNonUserCode]
		public bool Equals(GameCreateParams other)
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
					bool flag4 = this.GameType != other.GameType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CreationFlags != other.CreationFlags;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoSubzone != other.SnoSubzone;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoWorld != other.SnoWorld;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ItempowerBracket != other.ItempowerBracket;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Name != other.Name;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.PartitionType != other.PartitionType;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ServerPool != other.ServerPool;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.CampaignState, other.CampaignState);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.PvpBucket != other.PvpBucket;
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060020F3 RID: 8435 RVA: 0x00080A1C File Offset: 0x0007EC1C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				num ^= this.GameType.GetHashCode();
			}
			bool hasCreationFlags = this.HasCreationFlags;
			if (hasCreationFlags)
			{
				num ^= this.CreationFlags.GetHashCode();
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasItempowerBracket = this.HasItempowerBracket;
			if (hasItempowerBracket)
			{
				num ^= this.ItempowerBracket.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasPartitionType = this.HasPartitionType;
			if (hasPartitionType)
			{
				num ^= this.PartitionType.GetHashCode();
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num ^= this.ServerPool.GetHashCode();
			}
			bool flag = this.campaignState_ != null;
			if (flag)
			{
				num ^= this.CampaignState.GetHashCode();
			}
			bool hasPvpBucket = this.HasPvpBucket;
			if (hasPvpBucket)
			{
				num ^= this.PvpBucket.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00080B70 File Offset: 0x0007ED70
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00080B88 File Offset: 0x0007ED88
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00080B94 File Offset: 0x0007ED94
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.GameType);
			}
			bool hasCreationFlags = this.HasCreationFlags;
			if (hasCreationFlags)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CreationFlags);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.SnoSubzone);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.SnoWorld);
			}
			bool hasItempowerBracket = this.HasItempowerBracket;
			if (hasItempowerBracket)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ItempowerBracket);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Name);
			}
			bool hasPartitionType = this.HasPartitionType;
			if (hasPartitionType)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PartitionType);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ServerPool);
			}
			bool flag = this.campaignState_ != null;
			if (flag)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CampaignState);
			}
			bool hasPvpBucket = this.HasPvpBucket;
			if (hasPvpBucket)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.PvpBucket);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00080D24 File Offset: 0x0007EF24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.GameType);
			}
			bool hasCreationFlags = this.HasCreationFlags;
			if (hasCreationFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CreationFlags);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoSubzone);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SnoWorld);
			}
			bool hasItempowerBracket = this.HasItempowerBracket;
			if (hasItempowerBracket)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItempowerBracket);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasPartitionType = this.HasPartitionType;
			if (hasPartitionType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PartitionType);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerPool);
			}
			bool flag = this.campaignState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CampaignState);
			}
			bool hasPvpBucket = this.HasPvpBucket;
			if (hasPvpBucket)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PvpBucket);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00080E84 File Offset: 0x0007F084
		[DebuggerNonUserCode]
		public void MergeFrom(GameCreateParams other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameType = other.HasGameType;
				if (hasGameType)
				{
					this.GameType = other.GameType;
				}
				bool hasCreationFlags = other.HasCreationFlags;
				if (hasCreationFlags)
				{
					this.CreationFlags = other.CreationFlags;
				}
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasItempowerBracket = other.HasItempowerBracket;
				if (hasItempowerBracket)
				{
					this.ItempowerBracket = other.ItempowerBracket;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasPartitionType = other.HasPartitionType;
				if (hasPartitionType)
				{
					this.PartitionType = other.PartitionType;
				}
				bool hasServerPool = other.HasServerPool;
				if (hasServerPool)
				{
					this.ServerPool = other.ServerPool;
				}
				bool flag2 = other.campaignState_ != null;
				if (flag2)
				{
					bool flag3 = this.campaignState_ == null;
					if (flag3)
					{
						this.CampaignState = new CampaignState();
					}
					this.CampaignState.MergeFrom(other.CampaignState);
				}
				bool hasPvpBucket = other.HasPvpBucket;
				if (hasPvpBucket)
				{
					this.PvpBucket = other.PvpBucket;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00080FE4 File Offset: 0x0007F1E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00080FF0 File Offset: 0x0007F1F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_007A;
							}
							this.CreationFlags = input.ReadUInt32();
						}
						else
						{
							this.GameType = input.ReadSInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_007A;
							}
							this.ItempowerBracket = input.ReadUInt32();
						}
						else
						{
							this.SnoWorld = input.ReadSInt32();
						}
					}
					else
					{
						this.SnoSubzone = input.ReadSInt32();
					}
				}
				else if (num3 <= 56U)
				{
					if (num3 != 50U)
					{
						if (num3 != 56U)
						{
							goto IL_007A;
						}
						this.PartitionType = input.ReadUInt32();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 74U)
					{
						if (num3 != 80U)
						{
							goto IL_007A;
						}
						this.PvpBucket = input.ReadUInt32();
					}
					else
					{
						bool flag = this.campaignState_ == null;
						if (flag)
						{
							this.CampaignState = new CampaignState();
						}
						input.ReadMessage(this.CampaignState);
					}
				}
				else
				{
					this.ServerPool = input.ReadString();
				}
				continue;
				IL_007A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E78 RID: 3704
		private static readonly MessageParser<GameCreateParams> _parser = new MessageParser<GameCreateParams>(() => new GameCreateParams());

		// Token: 0x04000E79 RID: 3705
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E7A RID: 3706
		private int _hasBits0;

		// Token: 0x04000E7B RID: 3707
		public const int GameTypeFieldNumber = 1;

		// Token: 0x04000E7C RID: 3708
		private static readonly int GameTypeDefaultValue = 0;

		// Token: 0x04000E7D RID: 3709
		private int gameType_;

		// Token: 0x04000E7E RID: 3710
		public const int CreationFlagsFieldNumber = 2;

		// Token: 0x04000E7F RID: 3711
		private static readonly uint CreationFlagsDefaultValue = 0U;

		// Token: 0x04000E80 RID: 3712
		private uint creationFlags_;

		// Token: 0x04000E81 RID: 3713
		public const int SnoSubzoneFieldNumber = 3;

		// Token: 0x04000E82 RID: 3714
		private static readonly int SnoSubzoneDefaultValue = -1;

		// Token: 0x04000E83 RID: 3715
		private int snoSubzone_;

		// Token: 0x04000E84 RID: 3716
		public const int SnoWorldFieldNumber = 4;

		// Token: 0x04000E85 RID: 3717
		private static readonly int SnoWorldDefaultValue = -1;

		// Token: 0x04000E86 RID: 3718
		private int snoWorld_;

		// Token: 0x04000E87 RID: 3719
		public const int ItempowerBracketFieldNumber = 5;

		// Token: 0x04000E88 RID: 3720
		private static readonly uint ItempowerBracketDefaultValue = 0U;

		// Token: 0x04000E89 RID: 3721
		private uint itempowerBracket_;

		// Token: 0x04000E8A RID: 3722
		public const int NameFieldNumber = 6;

		// Token: 0x04000E8B RID: 3723
		private static readonly string NameDefaultValue = "";

		// Token: 0x04000E8C RID: 3724
		private string name_;

		// Token: 0x04000E8D RID: 3725
		public const int PartitionTypeFieldNumber = 7;

		// Token: 0x04000E8E RID: 3726
		private static readonly uint PartitionTypeDefaultValue = 0U;

		// Token: 0x04000E8F RID: 3727
		private uint partitionType_;

		// Token: 0x04000E90 RID: 3728
		public const int ServerPoolFieldNumber = 8;

		// Token: 0x04000E91 RID: 3729
		private static readonly string ServerPoolDefaultValue = "";

		// Token: 0x04000E92 RID: 3730
		private string serverPool_;

		// Token: 0x04000E93 RID: 3731
		public const int CampaignStateFieldNumber = 9;

		// Token: 0x04000E94 RID: 3732
		private CampaignState campaignState_;

		// Token: 0x04000E95 RID: 3733
		public const int PvpBucketFieldNumber = 10;

		// Token: 0x04000E96 RID: 3734
		private static readonly uint PvpBucketDefaultValue = 0U;

		// Token: 0x04000E97 RID: 3735
		private uint pvpBucket_;
	}
}
