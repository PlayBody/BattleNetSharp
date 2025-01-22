using System;
using System.Diagnostics;
using Fenris.AttributeSerializer;
using Fenris.Items;
using Fenris.Trade;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000190 RID: 400
	public sealed class SavedDefinition : IMessage<SavedDefinition>, IMessage, IEquatable<SavedDefinition>, IDeepCloneable<SavedDefinition>, IBufferMessage
	{
		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000A4F3C File Offset: 0x000A313C
		[DebuggerNonUserCode]
		public static MessageParser<SavedDefinition> Parser
		{
			get
			{
				return SavedDefinition._parser;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000A4F54 File Offset: 0x000A3154
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x000A4F78 File Offset: 0x000A3178
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedDefinition.Descriptor;
			}
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000A4F8F File Offset: 0x000A318F
		[DebuggerNonUserCode]
		public SavedDefinition()
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000A4F9C File Offset: 0x000A319C
		[DebuggerNonUserCode]
		public SavedDefinition(SavedDefinition other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.digest_ = ((other.digest_ != null) ? other.digest_.Clone() : null);
			this.savedAttributes_ = ((other.savedAttributes_ != null) ? other.savedAttributes_.Clone() : null);
			this.savedData_ = ((other.savedData_ != null) ? other.savedData_.Clone() : null);
			this.items_ = ((other.items_ != null) ? other.items_.Clone() : null);
			this.customization_ = ((other.customization_ != null) ? other.customization_.Clone() : null);
			this.vendor_ = ((other.vendor_ != null) ? other.vendor_.Clone() : null);
			this.quests_ = ((other.quests_ != null) ? other.quests_.Clone() : null);
			this.discoveries_ = ((other.discoveries_ != null) ? other.discoveries_.Clone() : null);
			this.skills_ = ((other.skills_ != null) ? other.skills_.Clone() : null);
			this.spawnTracking_ = ((other.spawnTracking_ != null) ? other.spawnTracking_.Clone() : null);
			this.tradeSavedData_ = ((other.tradeSavedData_ != null) ? other.tradeSavedData_.Clone() : null);
			this.rewards_ = ((other.rewards_ != null) ? other.rewards_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000A512C File Offset: 0x000A332C
		[DebuggerNonUserCode]
		public SavedDefinition Clone()
		{
			return new SavedDefinition(this);
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000A5144 File Offset: 0x000A3344
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x000A5175 File Offset: 0x000A3375
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = SavedDefinition.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000A5190 File Offset: 0x000A3390
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000A51AD File Offset: 0x000A33AD
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x000A51C0 File Offset: 0x000A33C0
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x000A51D8 File Offset: 0x000A33D8
		[DebuggerNonUserCode]
		public Digest Digest
		{
			get
			{
				return this.digest_;
			}
			set
			{
				this.digest_ = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000A51E4 File Offset: 0x000A33E4
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x000A51FC File Offset: 0x000A33FC
		[DebuggerNonUserCode]
		public SavedAttributes SavedAttributes
		{
			get
			{
				return this.savedAttributes_;
			}
			set
			{
				this.savedAttributes_ = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x000A5208 File Offset: 0x000A3408
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x000A5220 File Offset: 0x000A3420
		[DebuggerNonUserCode]
		public SavedData SavedData
		{
			get
			{
				return this.savedData_;
			}
			set
			{
				this.savedData_ = value;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000A522C File Offset: 0x000A342C
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x000A5244 File Offset: 0x000A3444
		[DebuggerNonUserCode]
		public ItemList Items
		{
			get
			{
				return this.items_;
			}
			set
			{
				this.items_ = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x000A5250 File Offset: 0x000A3450
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x000A5268 File Offset: 0x000A3468
		[DebuggerNonUserCode]
		public Customization Customization
		{
			get
			{
				return this.customization_;
			}
			set
			{
				this.customization_ = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000A5274 File Offset: 0x000A3474
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x000A528C File Offset: 0x000A348C
		[DebuggerNonUserCode]
		public Vendor Vendor
		{
			get
			{
				return this.vendor_;
			}
			set
			{
				this.vendor_ = value;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000A5298 File Offset: 0x000A3498
		// (set) Token: 0x06002A31 RID: 10801 RVA: 0x000A52B0 File Offset: 0x000A34B0
		[DebuggerNonUserCode]
		public Quests Quests
		{
			get
			{
				return this.quests_;
			}
			set
			{
				this.quests_ = value;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002A32 RID: 10802 RVA: 0x000A52BC File Offset: 0x000A34BC
		// (set) Token: 0x06002A33 RID: 10803 RVA: 0x000A52D4 File Offset: 0x000A34D4
		[DebuggerNonUserCode]
		public Discoveries Discoveries
		{
			get
			{
				return this.discoveries_;
			}
			set
			{
				this.discoveries_ = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000A52E0 File Offset: 0x000A34E0
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x000A52F8 File Offset: 0x000A34F8
		[DebuggerNonUserCode]
		public Skills Skills
		{
			get
			{
				return this.skills_;
			}
			set
			{
				this.skills_ = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x000A5304 File Offset: 0x000A3504
		// (set) Token: 0x06002A37 RID: 10807 RVA: 0x000A531C File Offset: 0x000A351C
		[DebuggerNonUserCode]
		public SpawnTracking SpawnTracking
		{
			get
			{
				return this.spawnTracking_;
			}
			set
			{
				this.spawnTracking_ = value;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000A5328 File Offset: 0x000A3528
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x000A5340 File Offset: 0x000A3540
		[DebuggerNonUserCode]
		public SavedData TradeSavedData
		{
			get
			{
				return this.tradeSavedData_;
			}
			set
			{
				this.tradeSavedData_ = value;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x000A534C File Offset: 0x000A354C
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x000A5364 File Offset: 0x000A3564
		[DebuggerNonUserCode]
		public Rewards Rewards
		{
			get
			{
				return this.rewards_;
			}
			set
			{
				this.rewards_ = value;
			}
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000A5370 File Offset: 0x000A3570
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedDefinition);
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000A5390 File Offset: 0x000A3590
		[DebuggerNonUserCode]
		public bool Equals(SavedDefinition other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Digest, other.Digest);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SavedAttributes, other.SavedAttributes);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.SavedData, other.SavedData);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Items, other.Items);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Customization, other.Customization);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Vendor, other.Vendor);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Quests, other.Quests);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.Discoveries, other.Discoveries);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.Skills, other.Skills);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.SpawnTracking, other.SpawnTracking);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.TradeSavedData, other.TradeSavedData);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = !object.Equals(this.Rewards, other.Rewards);
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06002A3E RID: 10814 RVA: 0x000A5570 File Offset: 0x000A3770
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this.digest_ != null;
			if (flag)
			{
				num ^= this.Digest.GetHashCode();
			}
			bool flag2 = this.savedAttributes_ != null;
			if (flag2)
			{
				num ^= this.SavedAttributes.GetHashCode();
			}
			bool flag3 = this.savedData_ != null;
			if (flag3)
			{
				num ^= this.SavedData.GetHashCode();
			}
			bool flag4 = this.items_ != null;
			if (flag4)
			{
				num ^= this.Items.GetHashCode();
			}
			bool flag5 = this.customization_ != null;
			if (flag5)
			{
				num ^= this.Customization.GetHashCode();
			}
			bool flag6 = this.vendor_ != null;
			if (flag6)
			{
				num ^= this.Vendor.GetHashCode();
			}
			bool flag7 = this.quests_ != null;
			if (flag7)
			{
				num ^= this.Quests.GetHashCode();
			}
			bool flag8 = this.discoveries_ != null;
			if (flag8)
			{
				num ^= this.Discoveries.GetHashCode();
			}
			bool flag9 = this.skills_ != null;
			if (flag9)
			{
				num ^= this.Skills.GetHashCode();
			}
			bool flag10 = this.spawnTracking_ != null;
			if (flag10)
			{
				num ^= this.SpawnTracking.GetHashCode();
			}
			bool flag11 = this.tradeSavedData_ != null;
			if (flag11)
			{
				num ^= this.TradeSavedData.GetHashCode();
			}
			bool flag12 = this.rewards_ != null;
			if (flag12)
			{
				num ^= this.Rewards.GetHashCode();
			}
			bool flag13 = this._unknownFields != null;
			if (flag13)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000A571C File Offset: 0x000A391C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000A5734 File Offset: 0x000A3934
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000A5740 File Offset: 0x000A3940
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Version);
			}
			bool flag = this.digest_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Digest);
			}
			bool flag2 = this.savedAttributes_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SavedAttributes);
			}
			bool flag3 = this.savedData_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SavedData);
			}
			bool flag4 = this.items_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Items);
			}
			bool flag5 = this.customization_ != null;
			if (flag5)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Customization);
			}
			bool flag6 = this.vendor_ != null;
			if (flag6)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Vendor);
			}
			bool flag7 = this.quests_ != null;
			if (flag7)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Quests);
			}
			bool flag8 = this.discoveries_ != null;
			if (flag8)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Discoveries);
			}
			bool flag9 = this.skills_ != null;
			if (flag9)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Skills);
			}
			bool flag10 = this.spawnTracking_ != null;
			if (flag10)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SpawnTracking);
			}
			bool flag11 = this.tradeSavedData_ != null;
			if (flag11)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TradeSavedData);
			}
			bool flag12 = this.rewards_ != null;
			if (flag12)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Rewards);
			}
			bool flag13 = this._unknownFields != null;
			if (flag13)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000A595C File Offset: 0x000A3B5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag = this.digest_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Digest);
			}
			bool flag2 = this.savedAttributes_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedAttributes);
			}
			bool flag3 = this.savedData_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedData);
			}
			bool flag4 = this.items_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Items);
			}
			bool flag5 = this.customization_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Customization);
			}
			bool flag6 = this.vendor_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Vendor);
			}
			bool flag7 = this.quests_ != null;
			if (flag7)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Quests);
			}
			bool flag8 = this.discoveries_ != null;
			if (flag8)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Discoveries);
			}
			bool flag9 = this.skills_ != null;
			if (flag9)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Skills);
			}
			bool flag10 = this.spawnTracking_ != null;
			if (flag10)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpawnTracking);
			}
			bool flag11 = this.tradeSavedData_ != null;
			if (flag11)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TradeSavedData);
			}
			bool flag12 = this.rewards_ != null;
			if (flag12)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rewards);
			}
			bool flag13 = this._unknownFields != null;
			if (flag13)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000A5B38 File Offset: 0x000A3D38
		[DebuggerNonUserCode]
		public void MergeFrom(SavedDefinition other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool flag2 = other.digest_ != null;
				if (flag2)
				{
					bool flag3 = this.digest_ == null;
					if (flag3)
					{
						this.Digest = new Digest();
					}
					this.Digest.MergeFrom(other.Digest);
				}
				bool flag4 = other.savedAttributes_ != null;
				if (flag4)
				{
					bool flag5 = this.savedAttributes_ == null;
					if (flag5)
					{
						this.SavedAttributes = new SavedAttributes();
					}
					this.SavedAttributes.MergeFrom(other.SavedAttributes);
				}
				bool flag6 = other.savedData_ != null;
				if (flag6)
				{
					bool flag7 = this.savedData_ == null;
					if (flag7)
					{
						this.SavedData = new SavedData();
					}
					this.SavedData.MergeFrom(other.SavedData);
				}
				bool flag8 = other.items_ != null;
				if (flag8)
				{
					bool flag9 = this.items_ == null;
					if (flag9)
					{
						this.Items = new ItemList();
					}
					this.Items.MergeFrom(other.Items);
				}
				bool flag10 = other.customization_ != null;
				if (flag10)
				{
					bool flag11 = this.customization_ == null;
					if (flag11)
					{
						this.Customization = new Customization();
					}
					this.Customization.MergeFrom(other.Customization);
				}
				bool flag12 = other.vendor_ != null;
				if (flag12)
				{
					bool flag13 = this.vendor_ == null;
					if (flag13)
					{
						this.Vendor = new Vendor();
					}
					this.Vendor.MergeFrom(other.Vendor);
				}
				bool flag14 = other.quests_ != null;
				if (flag14)
				{
					bool flag15 = this.quests_ == null;
					if (flag15)
					{
						this.Quests = new Quests();
					}
					this.Quests.MergeFrom(other.Quests);
				}
				bool flag16 = other.discoveries_ != null;
				if (flag16)
				{
					bool flag17 = this.discoveries_ == null;
					if (flag17)
					{
						this.Discoveries = new Discoveries();
					}
					this.Discoveries.MergeFrom(other.Discoveries);
				}
				bool flag18 = other.skills_ != null;
				if (flag18)
				{
					bool flag19 = this.skills_ == null;
					if (flag19)
					{
						this.Skills = new Skills();
					}
					this.Skills.MergeFrom(other.Skills);
				}
				bool flag20 = other.spawnTracking_ != null;
				if (flag20)
				{
					bool flag21 = this.spawnTracking_ == null;
					if (flag21)
					{
						this.SpawnTracking = new SpawnTracking();
					}
					this.SpawnTracking.MergeFrom(other.SpawnTracking);
				}
				bool flag22 = other.tradeSavedData_ != null;
				if (flag22)
				{
					bool flag23 = this.tradeSavedData_ == null;
					if (flag23)
					{
						this.TradeSavedData = new SavedData();
					}
					this.TradeSavedData.MergeFrom(other.TradeSavedData);
				}
				bool flag24 = other.rewards_ != null;
				if (flag24)
				{
					bool flag25 = this.rewards_ == null;
					if (flag25)
					{
						this.Rewards = new Rewards();
					}
					this.Rewards.MergeFrom(other.Rewards);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000A5E80 File Offset: 0x000A4080
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x000A5E8C File Offset: 0x000A408C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_00A0;
								}
								bool flag = this.savedAttributes_ == null;
								if (flag)
								{
									this.SavedAttributes = new SavedAttributes();
								}
								input.ReadMessage(this.SavedAttributes);
							}
							else
							{
								bool flag2 = this.digest_ == null;
								if (flag2)
								{
									this.Digest = new Digest();
								}
								input.ReadMessage(this.Digest);
							}
						}
						else
						{
							this.Version = input.ReadUInt32();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								goto IL_00A0;
							}
							bool flag3 = this.customization_ == null;
							if (flag3)
							{
								this.Customization = new Customization();
							}
							input.ReadMessage(this.Customization);
						}
						else
						{
							bool flag4 = this.items_ == null;
							if (flag4)
							{
								this.Items = new ItemList();
							}
							input.ReadMessage(this.Items);
						}
					}
					else
					{
						bool flag5 = this.savedData_ == null;
						if (flag5)
						{
							this.SavedData = new SavedData();
						}
						input.ReadMessage(this.SavedData);
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 58U)
					{
						if (num3 != 66U)
						{
							if (num3 != 74U)
							{
								goto IL_00A0;
							}
							bool flag6 = this.discoveries_ == null;
							if (flag6)
							{
								this.Discoveries = new Discoveries();
							}
							input.ReadMessage(this.Discoveries);
						}
						else
						{
							bool flag7 = this.quests_ == null;
							if (flag7)
							{
								this.Quests = new Quests();
							}
							input.ReadMessage(this.Quests);
						}
					}
					else
					{
						bool flag8 = this.vendor_ == null;
						if (flag8)
						{
							this.Vendor = new Vendor();
						}
						input.ReadMessage(this.Vendor);
					}
				}
				else if (num3 <= 90U)
				{
					if (num3 != 82U)
					{
						if (num3 != 90U)
						{
							goto IL_00A0;
						}
						bool flag9 = this.spawnTracking_ == null;
						if (flag9)
						{
							this.SpawnTracking = new SpawnTracking();
						}
						input.ReadMessage(this.SpawnTracking);
					}
					else
					{
						bool flag10 = this.skills_ == null;
						if (flag10)
						{
							this.Skills = new Skills();
						}
						input.ReadMessage(this.Skills);
					}
				}
				else if (num3 != 98U)
				{
					if (num3 != 106U)
					{
						goto IL_00A0;
					}
					bool flag11 = this.rewards_ == null;
					if (flag11)
					{
						this.Rewards = new Rewards();
					}
					input.ReadMessage(this.Rewards);
				}
				else
				{
					bool flag12 = this.tradeSavedData_ == null;
					if (flag12)
					{
						this.TradeSavedData = new SavedData();
					}
					input.ReadMessage(this.TradeSavedData);
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040012EC RID: 4844
		private static readonly MessageParser<SavedDefinition> _parser = new MessageParser<SavedDefinition>(() => new SavedDefinition());

		// Token: 0x040012ED RID: 4845
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012EE RID: 4846
		private int _hasBits0;

		// Token: 0x040012EF RID: 4847
		public const int VersionFieldNumber = 1;

		// Token: 0x040012F0 RID: 4848
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x040012F1 RID: 4849
		private uint version_;

		// Token: 0x040012F2 RID: 4850
		public const int DigestFieldNumber = 2;

		// Token: 0x040012F3 RID: 4851
		private Digest digest_;

		// Token: 0x040012F4 RID: 4852
		public const int SavedAttributesFieldNumber = 3;

		// Token: 0x040012F5 RID: 4853
		private SavedAttributes savedAttributes_;

		// Token: 0x040012F6 RID: 4854
		public const int SavedDataFieldNumber = 4;

		// Token: 0x040012F7 RID: 4855
		private SavedData savedData_;

		// Token: 0x040012F8 RID: 4856
		public const int ItemsFieldNumber = 5;

		// Token: 0x040012F9 RID: 4857
		private ItemList items_;

		// Token: 0x040012FA RID: 4858
		public const int CustomizationFieldNumber = 6;

		// Token: 0x040012FB RID: 4859
		private Customization customization_;

		// Token: 0x040012FC RID: 4860
		public const int VendorFieldNumber = 7;

		// Token: 0x040012FD RID: 4861
		private Vendor vendor_;

		// Token: 0x040012FE RID: 4862
		public const int QuestsFieldNumber = 8;

		// Token: 0x040012FF RID: 4863
		private Quests quests_;

		// Token: 0x04001300 RID: 4864
		public const int DiscoveriesFieldNumber = 9;

		// Token: 0x04001301 RID: 4865
		private Discoveries discoveries_;

		// Token: 0x04001302 RID: 4866
		public const int SkillsFieldNumber = 10;

		// Token: 0x04001303 RID: 4867
		private Skills skills_;

		// Token: 0x04001304 RID: 4868
		public const int SpawnTrackingFieldNumber = 11;

		// Token: 0x04001305 RID: 4869
		private SpawnTracking spawnTracking_;

		// Token: 0x04001306 RID: 4870
		public const int TradeSavedDataFieldNumber = 12;

		// Token: 0x04001307 RID: 4871
		private SavedData tradeSavedData_;

		// Token: 0x04001308 RID: 4872
		public const int RewardsFieldNumber = 13;

		// Token: 0x04001309 RID: 4873
		private Rewards rewards_;
	}
}
