using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000194 RID: 404
	public sealed class HeroStateDataDef : IMessage<HeroStateDataDef>, IMessage, IEquatable<HeroStateDataDef>, IDeepCloneable<HeroStateDataDef>, IBufferMessage
	{
		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x000A7390 File Offset: 0x000A5590
		[DebuggerNonUserCode]
		public static MessageParser<HeroStateDataDef> Parser
		{
			get
			{
				return HeroStateDataDef._parser;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x000A73A8 File Offset: 0x000A55A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x000A73CC File Offset: 0x000A55CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroStateDataDef.Descriptor;
			}
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000A73E4 File Offset: 0x000A55E4
		[DebuggerNonUserCode]
		public HeroStateDataDef()
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000A7454 File Offset: 0x000A5654
		[DebuggerNonUserCode]
		public HeroStateDataDef(HeroStateDataDef other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.playerFlags_ = other.playerFlags_;
			this.customizationData_ = ((other.customizationData_ != null) ? other.customizationData_.Clone() : null);
			this.savedData_ = ((other.savedData_ != null) ? other.savedData_.Clone() : null);
			this.townPortalReturnDest_ = ((other.townPortalReturnDest_ != null) ? other.townPortalReturnDest_.Clone() : null);
			this.completedQuestSnos_ = other.completedQuestSnos_.Clone();
			this.fogOfWarUnlockedSnos_ = other.fogOfWarUnlockedSnos_.Clone();
			this.completedRepeatableQuests_ = other.completedRepeatableQuests_.Clone();
			this.completedBounties_ = other.completedBounties_.Clone();
			this.campsDiscoveredSnos_ = other.campsDiscoveredSnos_.Clone();
			this.designerVariables_ = other.designerVariables_.Clone();
			this.foundHiddenCacheGbids_ = other.foundHiddenCacheGbids_.Clone();
			this.zoneProgressData_ = other.zoneProgressData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000A7570 File Offset: 0x000A5770
		[DebuggerNonUserCode]
		public HeroStateDataDef Clone()
		{
			return new HeroStateDataDef(this);
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000A7588 File Offset: 0x000A5788
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x000A75B9 File Offset: 0x000A57B9
		[DebuggerNonUserCode]
		public uint PlayerFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint playerFlagsDefaultValue;
				if (flag)
				{
					playerFlagsDefaultValue = this.playerFlags_;
				}
				else
				{
					playerFlagsDefaultValue = HeroStateDataDef.PlayerFlagsDefaultValue;
				}
				return playerFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.playerFlags_ = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x000A75D4 File Offset: 0x000A57D4
		[DebuggerNonUserCode]
		public bool HasPlayerFlags
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000A75F1 File Offset: 0x000A57F1
		[DebuggerNonUserCode]
		public void ClearPlayerFlags()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x000A7604 File Offset: 0x000A5804
		// (set) Token: 0x06002AA5 RID: 10917 RVA: 0x000A761C File Offset: 0x000A581C
		[DebuggerNonUserCode]
		public AppearanceCustomization CustomizationData
		{
			get
			{
				return this.customizationData_;
			}
			set
			{
				this.customizationData_ = value;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002AA6 RID: 10918 RVA: 0x000A7628 File Offset: 0x000A5828
		// (set) Token: 0x06002AA7 RID: 10919 RVA: 0x000A7640 File Offset: 0x000A5840
		[DebuggerNonUserCode]
		public SavedDefinition SavedData
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

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x000A764C File Offset: 0x000A584C
		// (set) Token: 0x06002AA9 RID: 10921 RVA: 0x000A7664 File Offset: 0x000A5864
		[DebuggerNonUserCode]
		public SavedTownPortalReturnDest TownPortalReturnDest
		{
			get
			{
				return this.townPortalReturnDest_;
			}
			set
			{
				this.townPortalReturnDest_ = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x000A7670 File Offset: 0x000A5870
		[DebuggerNonUserCode]
		public RepeatedField<int> CompletedQuestSnos
		{
			get
			{
				return this.completedQuestSnos_;
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000A7688 File Offset: 0x000A5888
		[DebuggerNonUserCode]
		public RepeatedField<int> FogOfWarUnlockedSnos
		{
			get
			{
				return this.fogOfWarUnlockedSnos_;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x000A76A0 File Offset: 0x000A58A0
		[DebuggerNonUserCode]
		public RepeatedField<CompletedRepeatableQuest> CompletedRepeatableQuests
		{
			get
			{
				return this.completedRepeatableQuests_;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000A76B8 File Offset: 0x000A58B8
		[DebuggerNonUserCode]
		public RepeatedField<CompletedRepeatableQuest> CompletedBounties
		{
			get
			{
				return this.completedBounties_;
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x000A76D0 File Offset: 0x000A58D0
		[DebuggerNonUserCode]
		public RepeatedField<int> CampsDiscoveredSnos
		{
			get
			{
				return this.campsDiscoveredSnos_;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000A76E8 File Offset: 0x000A58E8
		[DebuggerNonUserCode]
		public RepeatedField<DesignerVariable> DesignerVariables
		{
			get
			{
				return this.designerVariables_;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x000A7700 File Offset: 0x000A5900
		[DebuggerNonUserCode]
		public RepeatedField<int> FoundHiddenCacheGbids
		{
			get
			{
				return this.foundHiddenCacheGbids_;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000A7718 File Offset: 0x000A5918
		[DebuggerNonUserCode]
		public RepeatedField<ZoneProgress> ZoneProgressData
		{
			get
			{
				return this.zoneProgressData_;
			}
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000A7730 File Offset: 0x000A5930
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroStateDataDef);
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000A7750 File Offset: 0x000A5950
		[DebuggerNonUserCode]
		public bool Equals(HeroStateDataDef other)
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
					bool flag4 = this.PlayerFlags != other.PlayerFlags;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.CustomizationData, other.CustomizationData);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SavedData, other.SavedData);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.TownPortalReturnDest, other.TownPortalReturnDest);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.completedQuestSnos_.Equals(other.completedQuestSnos_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.fogOfWarUnlockedSnos_.Equals(other.fogOfWarUnlockedSnos_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.completedRepeatableQuests_.Equals(other.completedRepeatableQuests_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !this.completedBounties_.Equals(other.completedBounties_);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.campsDiscoveredSnos_.Equals(other.campsDiscoveredSnos_);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.designerVariables_.Equals(other.designerVariables_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !this.foundHiddenCacheGbids_.Equals(other.foundHiddenCacheGbids_);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !this.zoneProgressData_.Equals(other.zoneProgressData_);
																flag2 = !flag15 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000A7910 File Offset: 0x000A5B10
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				num ^= this.PlayerFlags.GetHashCode();
			}
			bool flag = this.customizationData_ != null;
			if (flag)
			{
				num ^= this.CustomizationData.GetHashCode();
			}
			bool flag2 = this.savedData_ != null;
			if (flag2)
			{
				num ^= this.SavedData.GetHashCode();
			}
			bool flag3 = this.townPortalReturnDest_ != null;
			if (flag3)
			{
				num ^= this.TownPortalReturnDest.GetHashCode();
			}
			num ^= this.completedQuestSnos_.GetHashCode();
			num ^= this.fogOfWarUnlockedSnos_.GetHashCode();
			num ^= this.completedRepeatableQuests_.GetHashCode();
			num ^= this.completedBounties_.GetHashCode();
			num ^= this.campsDiscoveredSnos_.GetHashCode();
			num ^= this.designerVariables_.GetHashCode();
			num ^= this.foundHiddenCacheGbids_.GetHashCode();
			num ^= this.zoneProgressData_.GetHashCode();
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000A7A28 File Offset: 0x000A5C28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x000A7A40 File Offset: 0x000A5C40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000A7A4C File Offset: 0x000A5C4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PlayerFlags);
			}
			bool flag = this.customizationData_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CustomizationData);
			}
			bool flag2 = this.savedData_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SavedData);
			}
			bool flag3 = this.townPortalReturnDest_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TownPortalReturnDest);
			}
			this.completedQuestSnos_.WriteTo(ref output, HeroStateDataDef._repeated_completedQuestSnos_codec);
			this.fogOfWarUnlockedSnos_.WriteTo(ref output, HeroStateDataDef._repeated_fogOfWarUnlockedSnos_codec);
			this.completedRepeatableQuests_.WriteTo(ref output, HeroStateDataDef._repeated_completedRepeatableQuests_codec);
			this.completedBounties_.WriteTo(ref output, HeroStateDataDef._repeated_completedBounties_codec);
			this.campsDiscoveredSnos_.WriteTo(ref output, HeroStateDataDef._repeated_campsDiscoveredSnos_codec);
			this.designerVariables_.WriteTo(ref output, HeroStateDataDef._repeated_designerVariables_codec);
			this.foundHiddenCacheGbids_.WriteTo(ref output, HeroStateDataDef._repeated_foundHiddenCacheGbids_codec);
			this.zoneProgressData_.WriteTo(ref output, HeroStateDataDef._repeated_zoneProgressData_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x000A7B98 File Offset: 0x000A5D98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlayerFlags = this.HasPlayerFlags;
			if (hasPlayerFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayerFlags);
			}
			bool flag = this.customizationData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CustomizationData);
			}
			bool flag2 = this.savedData_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SavedData);
			}
			bool flag3 = this.townPortalReturnDest_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TownPortalReturnDest);
			}
			num += this.completedQuestSnos_.CalculateSize(HeroStateDataDef._repeated_completedQuestSnos_codec);
			num += this.fogOfWarUnlockedSnos_.CalculateSize(HeroStateDataDef._repeated_fogOfWarUnlockedSnos_codec);
			num += this.completedRepeatableQuests_.CalculateSize(HeroStateDataDef._repeated_completedRepeatableQuests_codec);
			num += this.completedBounties_.CalculateSize(HeroStateDataDef._repeated_completedBounties_codec);
			num += this.campsDiscoveredSnos_.CalculateSize(HeroStateDataDef._repeated_campsDiscoveredSnos_codec);
			num += this.designerVariables_.CalculateSize(HeroStateDataDef._repeated_designerVariables_codec);
			num += this.foundHiddenCacheGbids_.CalculateSize(HeroStateDataDef._repeated_foundHiddenCacheGbids_codec);
			num += this.zoneProgressData_.CalculateSize(HeroStateDataDef._repeated_zoneProgressData_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000A7CE4 File Offset: 0x000A5EE4
		[DebuggerNonUserCode]
		public void MergeFrom(HeroStateDataDef other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlayerFlags = other.HasPlayerFlags;
				if (hasPlayerFlags)
				{
					this.PlayerFlags = other.PlayerFlags;
				}
				bool flag2 = other.customizationData_ != null;
				if (flag2)
				{
					bool flag3 = this.customizationData_ == null;
					if (flag3)
					{
						this.CustomizationData = new AppearanceCustomization();
					}
					this.CustomizationData.MergeFrom(other.CustomizationData);
				}
				bool flag4 = other.savedData_ != null;
				if (flag4)
				{
					bool flag5 = this.savedData_ == null;
					if (flag5)
					{
						this.SavedData = new SavedDefinition();
					}
					this.SavedData.MergeFrom(other.SavedData);
				}
				bool flag6 = other.townPortalReturnDest_ != null;
				if (flag6)
				{
					bool flag7 = this.townPortalReturnDest_ == null;
					if (flag7)
					{
						this.TownPortalReturnDest = new SavedTownPortalReturnDest();
					}
					this.TownPortalReturnDest.MergeFrom(other.TownPortalReturnDest);
				}
				this.completedQuestSnos_.Add(other.completedQuestSnos_);
				this.fogOfWarUnlockedSnos_.Add(other.fogOfWarUnlockedSnos_);
				this.completedRepeatableQuests_.Add(other.completedRepeatableQuests_);
				this.completedBounties_.Add(other.completedBounties_);
				this.campsDiscoveredSnos_.Add(other.campsDiscoveredSnos_);
				this.designerVariables_.Add(other.designerVariables_);
				this.foundHiddenCacheGbids_.Add(other.foundHiddenCacheGbids_);
				this.zoneProgressData_.Add(other.zoneProgressData_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x000A7E7C File Offset: 0x000A607C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000A7E88 File Offset: 0x000A6088
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 53U)
				{
					if (num3 <= 34U)
					{
						if (num3 <= 18U)
						{
							if (num3 != 8U)
							{
								if (num3 != 18U)
								{
									goto IL_00D3;
								}
								bool flag = this.customizationData_ == null;
								if (flag)
								{
									this.CustomizationData = new AppearanceCustomization();
								}
								input.ReadMessage(this.CustomizationData);
							}
							else
							{
								this.PlayerFlags = input.ReadUInt32();
							}
						}
						else if (num3 != 26U)
						{
							if (num3 != 34U)
							{
								goto IL_00D3;
							}
							bool flag2 = this.townPortalReturnDest_ == null;
							if (flag2)
							{
								this.TownPortalReturnDest = new SavedTownPortalReturnDest();
							}
							input.ReadMessage(this.TownPortalReturnDest);
						}
						else
						{
							bool flag3 = this.savedData_ == null;
							if (flag3)
							{
								this.SavedData = new SavedDefinition();
							}
							input.ReadMessage(this.SavedData);
						}
					}
					else if (num3 <= 45U)
					{
						if (num3 != 42U && num3 != 45U)
						{
							goto IL_00D3;
						}
						this.completedQuestSnos_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_completedQuestSnos_codec);
					}
					else
					{
						if (num3 != 50U && num3 != 53U)
						{
							goto IL_00D3;
						}
						this.fogOfWarUnlockedSnos_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_fogOfWarUnlockedSnos_codec);
					}
				}
				else if (num3 <= 77U)
				{
					if (num3 <= 66U)
					{
						if (num3 != 58U)
						{
							if (num3 != 66U)
							{
								goto IL_00D3;
							}
							this.completedBounties_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_completedBounties_codec);
						}
						else
						{
							this.completedRepeatableQuests_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_completedRepeatableQuests_codec);
						}
					}
					else
					{
						if (num3 != 74U && num3 != 77U)
						{
							goto IL_00D3;
						}
						this.campsDiscoveredSnos_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_campsDiscoveredSnos_codec);
					}
				}
				else
				{
					if (num3 <= 90U)
					{
						if (num3 == 82U)
						{
							this.designerVariables_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_designerVariables_codec);
							continue;
						}
						if (num3 != 90U)
						{
							goto IL_00D3;
						}
					}
					else if (num3 != 93U)
					{
						if (num3 != 98U)
						{
							goto IL_00D3;
						}
						this.zoneProgressData_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_zoneProgressData_codec);
						continue;
					}
					this.foundHiddenCacheGbids_.AddEntriesFrom(ref input, HeroStateDataDef._repeated_foundHiddenCacheGbids_codec);
				}
				continue;
				IL_00D3:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400132C RID: 4908
		private static readonly MessageParser<HeroStateDataDef> _parser = new MessageParser<HeroStateDataDef>(() => new HeroStateDataDef());

		// Token: 0x0400132D RID: 4909
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400132E RID: 4910
		private int _hasBits0;

		// Token: 0x0400132F RID: 4911
		public const int PlayerFlagsFieldNumber = 1;

		// Token: 0x04001330 RID: 4912
		private static readonly uint PlayerFlagsDefaultValue = 0U;

		// Token: 0x04001331 RID: 4913
		private uint playerFlags_;

		// Token: 0x04001332 RID: 4914
		public const int CustomizationDataFieldNumber = 2;

		// Token: 0x04001333 RID: 4915
		private AppearanceCustomization customizationData_;

		// Token: 0x04001334 RID: 4916
		public const int SavedDataFieldNumber = 3;

		// Token: 0x04001335 RID: 4917
		private SavedDefinition savedData_;

		// Token: 0x04001336 RID: 4918
		public const int TownPortalReturnDestFieldNumber = 4;

		// Token: 0x04001337 RID: 4919
		private SavedTownPortalReturnDest townPortalReturnDest_;

		// Token: 0x04001338 RID: 4920
		public const int CompletedQuestSnosFieldNumber = 5;

		// Token: 0x04001339 RID: 4921
		private static readonly FieldCodec<int> _repeated_completedQuestSnos_codec = FieldCodec.ForSFixed32(45U);

		// Token: 0x0400133A RID: 4922
		private readonly RepeatedField<int> completedQuestSnos_ = new RepeatedField<int>();

		// Token: 0x0400133B RID: 4923
		public const int FogOfWarUnlockedSnosFieldNumber = 6;

		// Token: 0x0400133C RID: 4924
		private static readonly FieldCodec<int> _repeated_fogOfWarUnlockedSnos_codec = FieldCodec.ForSFixed32(53U);

		// Token: 0x0400133D RID: 4925
		private readonly RepeatedField<int> fogOfWarUnlockedSnos_ = new RepeatedField<int>();

		// Token: 0x0400133E RID: 4926
		public const int CompletedRepeatableQuestsFieldNumber = 7;

		// Token: 0x0400133F RID: 4927
		private static readonly FieldCodec<CompletedRepeatableQuest> _repeated_completedRepeatableQuests_codec = FieldCodec.ForMessage<CompletedRepeatableQuest>(58U, CompletedRepeatableQuest.Parser);

		// Token: 0x04001340 RID: 4928
		private readonly RepeatedField<CompletedRepeatableQuest> completedRepeatableQuests_ = new RepeatedField<CompletedRepeatableQuest>();

		// Token: 0x04001341 RID: 4929
		public const int CompletedBountiesFieldNumber = 8;

		// Token: 0x04001342 RID: 4930
		private static readonly FieldCodec<CompletedRepeatableQuest> _repeated_completedBounties_codec = FieldCodec.ForMessage<CompletedRepeatableQuest>(66U, CompletedRepeatableQuest.Parser);

		// Token: 0x04001343 RID: 4931
		private readonly RepeatedField<CompletedRepeatableQuest> completedBounties_ = new RepeatedField<CompletedRepeatableQuest>();

		// Token: 0x04001344 RID: 4932
		public const int CampsDiscoveredSnosFieldNumber = 9;

		// Token: 0x04001345 RID: 4933
		private static readonly FieldCodec<int> _repeated_campsDiscoveredSnos_codec = FieldCodec.ForSFixed32(77U);

		// Token: 0x04001346 RID: 4934
		private readonly RepeatedField<int> campsDiscoveredSnos_ = new RepeatedField<int>();

		// Token: 0x04001347 RID: 4935
		public const int DesignerVariablesFieldNumber = 10;

		// Token: 0x04001348 RID: 4936
		private static readonly FieldCodec<DesignerVariable> _repeated_designerVariables_codec = FieldCodec.ForMessage<DesignerVariable>(82U, DesignerVariable.Parser);

		// Token: 0x04001349 RID: 4937
		private readonly RepeatedField<DesignerVariable> designerVariables_ = new RepeatedField<DesignerVariable>();

		// Token: 0x0400134A RID: 4938
		public const int FoundHiddenCacheGbidsFieldNumber = 11;

		// Token: 0x0400134B RID: 4939
		private static readonly FieldCodec<int> _repeated_foundHiddenCacheGbids_codec = FieldCodec.ForSFixed32(93U);

		// Token: 0x0400134C RID: 4940
		private readonly RepeatedField<int> foundHiddenCacheGbids_ = new RepeatedField<int>();

		// Token: 0x0400134D RID: 4941
		public const int ZoneProgressDataFieldNumber = 12;

		// Token: 0x0400134E RID: 4942
		private static readonly FieldCodec<ZoneProgress> _repeated_zoneProgressData_codec = FieldCodec.ForMessage<ZoneProgress>(98U, ZoneProgress.Parser);

		// Token: 0x0400134F RID: 4943
		private readonly RepeatedField<ZoneProgress> zoneProgressData_ = new RepeatedField<ZoneProgress>();
	}
}
