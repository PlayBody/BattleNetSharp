using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C8 RID: 456
	public sealed class ZoneProgressPerZoneGlobalData : IMessage<ZoneProgressPerZoneGlobalData>, IMessage, IEquatable<ZoneProgressPerZoneGlobalData>, IDeepCloneable<ZoneProgressPerZoneGlobalData>, IBufferMessage
	{
		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x000C05D8 File Offset: 0x000BE7D8
		[DebuggerNonUserCode]
		public static MessageParser<ZoneProgressPerZoneGlobalData> Parser
		{
			get
			{
				return ZoneProgressPerZoneGlobalData._parser;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000C05F0 File Offset: 0x000BE7F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x000C0614 File Offset: 0x000BE814
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZoneProgressPerZoneGlobalData.Descriptor;
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x000C062C File Offset: 0x000BE82C
		[DebuggerNonUserCode]
		public ZoneProgressPerZoneGlobalData()
		{
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x000C0690 File Offset: 0x000BE890
		[DebuggerNonUserCode]
		public ZoneProgressPerZoneGlobalData(ZoneProgressPerZoneGlobalData other)
			: this()
		{
			this.snoCamps_ = other.snoCamps_.Clone();
			this.snoDungeons_ = other.snoDungeons_.Clone();
			this.snoFogOfWar_ = other.snoFogOfWar_.Clone();
			this.snoSideQuests_ = other.snoSideQuests_.Clone();
			this.snoWaypoints_ = other.snoWaypoints_.Clone();
			this.gbidHiddenCaches_ = other.gbidHiddenCaches_.Clone();
			this.rewardsPerTier_ = other.rewardsPerTier_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x000C0730 File Offset: 0x000BE930
		[DebuggerNonUserCode]
		public ZoneProgressPerZoneGlobalData Clone()
		{
			return new ZoneProgressPerZoneGlobalData(this);
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x000C0748 File Offset: 0x000BE948
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoCamps
		{
			get
			{
				return this.snoCamps_;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000C0760 File Offset: 0x000BE960
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoDungeons
		{
			get
			{
				return this.snoDungeons_;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x000C0778 File Offset: 0x000BE978
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoFogOfWar
		{
			get
			{
				return this.snoFogOfWar_;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x000C0790 File Offset: 0x000BE990
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoSideQuests
		{
			get
			{
				return this.snoSideQuests_;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x000C07A8 File Offset: 0x000BE9A8
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoWaypoints
		{
			get
			{
				return this.snoWaypoints_;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000C07C0 File Offset: 0x000BE9C0
		[DebuggerNonUserCode]
		public RepeatedField<int> GbidHiddenCaches
		{
			get
			{
				return this.gbidHiddenCaches_;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x000C07D8 File Offset: 0x000BE9D8
		[DebuggerNonUserCode]
		public RepeatedField<ZoneProgressRewardPerTierData> RewardsPerTier
		{
			get
			{
				return this.rewardsPerTier_;
			}
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x000C07F0 File Offset: 0x000BE9F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZoneProgressPerZoneGlobalData);
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000C0810 File Offset: 0x000BEA10
		[DebuggerNonUserCode]
		public bool Equals(ZoneProgressPerZoneGlobalData other)
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
					bool flag4 = !this.snoCamps_.Equals(other.snoCamps_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.snoDungeons_.Equals(other.snoDungeons_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.snoFogOfWar_.Equals(other.snoFogOfWar_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.snoSideQuests_.Equals(other.snoSideQuests_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.snoWaypoints_.Equals(other.snoWaypoints_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.gbidHiddenCaches_.Equals(other.gbidHiddenCaches_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.rewardsPerTier_.Equals(other.rewardsPerTier_);
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x060030B1 RID: 12465 RVA: 0x000C092C File Offset: 0x000BEB2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.snoCamps_.GetHashCode();
			num ^= this.snoDungeons_.GetHashCode();
			num ^= this.snoFogOfWar_.GetHashCode();
			num ^= this.snoSideQuests_.GetHashCode();
			num ^= this.snoWaypoints_.GetHashCode();
			num ^= this.gbidHiddenCaches_.GetHashCode();
			num ^= this.rewardsPerTier_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000C09C0 File Offset: 0x000BEBC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000C09D8 File Offset: 0x000BEBD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x000C09E4 File Offset: 0x000BEBE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.snoCamps_.WriteTo(ref output, ZoneProgressPerZoneGlobalData._repeated_snoCamps_codec);
			this.snoDungeons_.WriteTo(ref output, ZoneProgressPerZoneGlobalData._repeated_snoDungeons_codec);
			this.snoFogOfWar_.WriteTo(ref output, ZoneProgressPerZoneGlobalData._repeated_snoFogOfWar_codec);
			this.snoSideQuests_.WriteTo(ref output, ZoneProgressPerZoneGlobalData._repeated_snoSideQuests_codec);
			this.snoWaypoints_.WriteTo(ref output, ZoneProgressPerZoneGlobalData._repeated_snoWaypoints_codec);
			this.gbidHiddenCaches_.WriteTo(ref output, ZoneProgressPerZoneGlobalData._repeated_gbidHiddenCaches_codec);
			this.rewardsPerTier_.WriteTo(ref output, ZoneProgressPerZoneGlobalData._repeated_rewardsPerTier_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x000C0A8C File Offset: 0x000BEC8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.snoCamps_.CalculateSize(ZoneProgressPerZoneGlobalData._repeated_snoCamps_codec);
			num += this.snoDungeons_.CalculateSize(ZoneProgressPerZoneGlobalData._repeated_snoDungeons_codec);
			num += this.snoFogOfWar_.CalculateSize(ZoneProgressPerZoneGlobalData._repeated_snoFogOfWar_codec);
			num += this.snoSideQuests_.CalculateSize(ZoneProgressPerZoneGlobalData._repeated_snoSideQuests_codec);
			num += this.snoWaypoints_.CalculateSize(ZoneProgressPerZoneGlobalData._repeated_snoWaypoints_codec);
			num += this.gbidHiddenCaches_.CalculateSize(ZoneProgressPerZoneGlobalData._repeated_gbidHiddenCaches_codec);
			num += this.rewardsPerTier_.CalculateSize(ZoneProgressPerZoneGlobalData._repeated_rewardsPerTier_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x000C0B44 File Offset: 0x000BED44
		[DebuggerNonUserCode]
		public void MergeFrom(ZoneProgressPerZoneGlobalData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.snoCamps_.Add(other.snoCamps_);
				this.snoDungeons_.Add(other.snoDungeons_);
				this.snoFogOfWar_.Add(other.snoFogOfWar_);
				this.snoSideQuests_.Add(other.snoSideQuests_);
				this.snoWaypoints_.Add(other.snoWaypoints_);
				this.gbidHiddenCaches_.Add(other.gbidHiddenCaches_);
				this.rewardsPerTier_.Add(other.rewardsPerTier_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x000C0BF5 File Offset: 0x000BEDF5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x000C0C00 File Offset: 0x000BEE00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 29U)
				{
					if (num3 <= 18U)
					{
						if (num3 == 10U || num3 == 13U)
						{
							this.snoCamps_.AddEntriesFrom(ref input, ZoneProgressPerZoneGlobalData._repeated_snoCamps_codec);
							continue;
						}
						if (num3 != 18U)
						{
							goto IL_00A1;
						}
					}
					else if (num3 != 21U)
					{
						if (num3 != 26U && num3 != 29U)
						{
							goto IL_00A1;
						}
						this.snoFogOfWar_.AddEntriesFrom(ref input, ZoneProgressPerZoneGlobalData._repeated_snoFogOfWar_codec);
						continue;
					}
					this.snoDungeons_.AddEntriesFrom(ref input, ZoneProgressPerZoneGlobalData._repeated_snoDungeons_codec);
				}
				else
				{
					if (num3 > 42U)
					{
						if (num3 <= 50U)
						{
							if (num3 == 45U)
							{
								goto IL_010C;
							}
							if (num3 != 50U)
							{
								goto IL_00A1;
							}
						}
						else if (num3 != 53U)
						{
							if (num3 != 58U)
							{
								goto IL_00A1;
							}
							this.rewardsPerTier_.AddEntriesFrom(ref input, ZoneProgressPerZoneGlobalData._repeated_rewardsPerTier_codec);
							continue;
						}
						this.gbidHiddenCaches_.AddEntriesFrom(ref input, ZoneProgressPerZoneGlobalData._repeated_gbidHiddenCaches_codec);
						continue;
					}
					if (num3 == 34U || num3 == 37U)
					{
						this.snoSideQuests_.AddEntriesFrom(ref input, ZoneProgressPerZoneGlobalData._repeated_snoSideQuests_codec);
						continue;
					}
					if (num3 != 42U)
					{
						goto IL_00A1;
					}
					IL_010C:
					this.snoWaypoints_.AddEntriesFrom(ref input, ZoneProgressPerZoneGlobalData._repeated_snoWaypoints_codec);
				}
				continue;
				IL_00A1:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001629 RID: 5673
		private static readonly MessageParser<ZoneProgressPerZoneGlobalData> _parser = new MessageParser<ZoneProgressPerZoneGlobalData>(() => new ZoneProgressPerZoneGlobalData());

		// Token: 0x0400162A RID: 5674
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400162B RID: 5675
		public const int SnoCampsFieldNumber = 1;

		// Token: 0x0400162C RID: 5676
		private static readonly FieldCodec<int> _repeated_snoCamps_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x0400162D RID: 5677
		private readonly RepeatedField<int> snoCamps_ = new RepeatedField<int>();

		// Token: 0x0400162E RID: 5678
		public const int SnoDungeonsFieldNumber = 2;

		// Token: 0x0400162F RID: 5679
		private static readonly FieldCodec<int> _repeated_snoDungeons_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x04001630 RID: 5680
		private readonly RepeatedField<int> snoDungeons_ = new RepeatedField<int>();

		// Token: 0x04001631 RID: 5681
		public const int SnoFogOfWarFieldNumber = 3;

		// Token: 0x04001632 RID: 5682
		private static readonly FieldCodec<int> _repeated_snoFogOfWar_codec = FieldCodec.ForSFixed32(29U);

		// Token: 0x04001633 RID: 5683
		private readonly RepeatedField<int> snoFogOfWar_ = new RepeatedField<int>();

		// Token: 0x04001634 RID: 5684
		public const int SnoSideQuestsFieldNumber = 4;

		// Token: 0x04001635 RID: 5685
		private static readonly FieldCodec<int> _repeated_snoSideQuests_codec = FieldCodec.ForSFixed32(37U);

		// Token: 0x04001636 RID: 5686
		private readonly RepeatedField<int> snoSideQuests_ = new RepeatedField<int>();

		// Token: 0x04001637 RID: 5687
		public const int SnoWaypointsFieldNumber = 5;

		// Token: 0x04001638 RID: 5688
		private static readonly FieldCodec<int> _repeated_snoWaypoints_codec = FieldCodec.ForSFixed32(45U);

		// Token: 0x04001639 RID: 5689
		private readonly RepeatedField<int> snoWaypoints_ = new RepeatedField<int>();

		// Token: 0x0400163A RID: 5690
		public const int GbidHiddenCachesFieldNumber = 6;

		// Token: 0x0400163B RID: 5691
		private static readonly FieldCodec<int> _repeated_gbidHiddenCaches_codec = FieldCodec.ForSFixed32(53U);

		// Token: 0x0400163C RID: 5692
		private readonly RepeatedField<int> gbidHiddenCaches_ = new RepeatedField<int>();

		// Token: 0x0400163D RID: 5693
		public const int RewardsPerTierFieldNumber = 7;

		// Token: 0x0400163E RID: 5694
		private static readonly FieldCodec<ZoneProgressRewardPerTierData> _repeated_rewardsPerTier_codec = FieldCodec.ForMessage<ZoneProgressRewardPerTierData>(58U, ZoneProgressRewardPerTierData.Parser);

		// Token: 0x0400163F RID: 5695
		private readonly RepeatedField<ZoneProgressRewardPerTierData> rewardsPerTier_ = new RepeatedField<ZoneProgressRewardPerTierData>();
	}
}
