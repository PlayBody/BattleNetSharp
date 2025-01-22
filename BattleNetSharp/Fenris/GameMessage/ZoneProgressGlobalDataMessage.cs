using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001CA RID: 458
	public sealed class ZoneProgressGlobalDataMessage : IMessage<ZoneProgressGlobalDataMessage>, IMessage, IEquatable<ZoneProgressGlobalDataMessage>, IDeepCloneable<ZoneProgressGlobalDataMessage>, IBufferMessage
	{
		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x000C122C File Offset: 0x000BF42C
		[DebuggerNonUserCode]
		public static MessageParser<ZoneProgressGlobalDataMessage> Parser
		{
			get
			{
				return ZoneProgressGlobalDataMessage._parser;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x000C1244 File Offset: 0x000BF444
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x000C1268 File Offset: 0x000BF468
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZoneProgressGlobalDataMessage.Descriptor;
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000C1280 File Offset: 0x000BF480
		[DebuggerNonUserCode]
		public ZoneProgressGlobalDataMessage()
		{
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x000C12D8 File Offset: 0x000BF4D8
		[DebuggerNonUserCode]
		public ZoneProgressGlobalDataMessage(ZoneProgressGlobalDataMessage other)
			: this()
		{
			this.perZoneData_ = other.perZoneData_.Clone();
			this.renownPerProgressType_ = other.renownPerProgressType_.Clone();
			this.renownPerRewardThreshold_ = other.renownPerRewardThreshold_.Clone();
			this.rewardStringHandles_ = other.rewardStringHandles_.Clone();
			this.trackedRewardStringHandles_ = other.trackedRewardStringHandles_.Clone();
			this.worldToDpoMap_ = other.worldToDpoMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000C1364 File Offset: 0x000BF564
		[DebuggerNonUserCode]
		public ZoneProgressGlobalDataMessage Clone()
		{
			return new ZoneProgressGlobalDataMessage(this);
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x000C137C File Offset: 0x000BF57C
		[DebuggerNonUserCode]
		public RepeatedField<ZoneProgressPerZoneGlobalData> PerZoneData
		{
			get
			{
				return this.perZoneData_;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x000C1394 File Offset: 0x000BF594
		[DebuggerNonUserCode]
		public RepeatedField<int> RenownPerProgressType
		{
			get
			{
				return this.renownPerProgressType_;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060030D8 RID: 12504 RVA: 0x000C13AC File Offset: 0x000BF5AC
		[DebuggerNonUserCode]
		public RepeatedField<int> RenownPerRewardThreshold
		{
			get
			{
				return this.renownPerRewardThreshold_;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000C13C4 File Offset: 0x000BF5C4
		[DebuggerNonUserCode]
		public RepeatedField<uint> RewardStringHandles
		{
			get
			{
				return this.rewardStringHandles_;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x000C13DC File Offset: 0x000BF5DC
		[DebuggerNonUserCode]
		public RepeatedField<uint> TrackedRewardStringHandles
		{
			get
			{
				return this.trackedRewardStringHandles_;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x000C13F4 File Offset: 0x000BF5F4
		[DebuggerNonUserCode]
		public RepeatedField<ZoneProgressWorldToDPOData> WorldToDpoMap
		{
			get
			{
				return this.worldToDpoMap_;
			}
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000C140C File Offset: 0x000BF60C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZoneProgressGlobalDataMessage);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000C142C File Offset: 0x000BF62C
		[DebuggerNonUserCode]
		public bool Equals(ZoneProgressGlobalDataMessage other)
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
					bool flag4 = !this.perZoneData_.Equals(other.perZoneData_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.renownPerProgressType_.Equals(other.renownPerProgressType_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.renownPerRewardThreshold_.Equals(other.renownPerRewardThreshold_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.rewardStringHandles_.Equals(other.rewardStringHandles_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.trackedRewardStringHandles_.Equals(other.trackedRewardStringHandles_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.worldToDpoMap_.Equals(other.worldToDpoMap_);
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

		// Token: 0x060030DE RID: 12510 RVA: 0x000C1528 File Offset: 0x000BF728
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.perZoneData_.GetHashCode();
			num ^= this.renownPerProgressType_.GetHashCode();
			num ^= this.renownPerRewardThreshold_.GetHashCode();
			num ^= this.rewardStringHandles_.GetHashCode();
			num ^= this.trackedRewardStringHandles_.GetHashCode();
			num ^= this.worldToDpoMap_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000C15B0 File Offset: 0x000BF7B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000C15C8 File Offset: 0x000BF7C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x000C15D4 File Offset: 0x000BF7D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.perZoneData_.WriteTo(ref output, ZoneProgressGlobalDataMessage._repeated_perZoneData_codec);
			this.renownPerProgressType_.WriteTo(ref output, ZoneProgressGlobalDataMessage._repeated_renownPerProgressType_codec);
			this.renownPerRewardThreshold_.WriteTo(ref output, ZoneProgressGlobalDataMessage._repeated_renownPerRewardThreshold_codec);
			this.rewardStringHandles_.WriteTo(ref output, ZoneProgressGlobalDataMessage._repeated_rewardStringHandles_codec);
			this.trackedRewardStringHandles_.WriteTo(ref output, ZoneProgressGlobalDataMessage._repeated_trackedRewardStringHandles_codec);
			this.worldToDpoMap_.WriteTo(ref output, ZoneProgressGlobalDataMessage._repeated_worldToDpoMap_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x000C166C File Offset: 0x000BF86C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.perZoneData_.CalculateSize(ZoneProgressGlobalDataMessage._repeated_perZoneData_codec);
			num += this.renownPerProgressType_.CalculateSize(ZoneProgressGlobalDataMessage._repeated_renownPerProgressType_codec);
			num += this.renownPerRewardThreshold_.CalculateSize(ZoneProgressGlobalDataMessage._repeated_renownPerRewardThreshold_codec);
			num += this.rewardStringHandles_.CalculateSize(ZoneProgressGlobalDataMessage._repeated_rewardStringHandles_codec);
			num += this.trackedRewardStringHandles_.CalculateSize(ZoneProgressGlobalDataMessage._repeated_trackedRewardStringHandles_codec);
			num += this.worldToDpoMap_.CalculateSize(ZoneProgressGlobalDataMessage._repeated_worldToDpoMap_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000C1710 File Offset: 0x000BF910
		[DebuggerNonUserCode]
		public void MergeFrom(ZoneProgressGlobalDataMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.perZoneData_.Add(other.perZoneData_);
				this.renownPerProgressType_.Add(other.renownPerProgressType_);
				this.renownPerRewardThreshold_.Add(other.renownPerRewardThreshold_);
				this.rewardStringHandles_.Add(other.rewardStringHandles_);
				this.trackedRewardStringHandles_.Add(other.trackedRewardStringHandles_);
				this.worldToDpoMap_.Add(other.worldToDpoMap_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000C17AF File Offset: 0x000BF9AF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000C17BC File Offset: 0x000BF9BC
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
					if (num3 <= 16U)
					{
						if (num3 == 10U)
						{
							this.perZoneData_.AddEntriesFrom(ref input, ZoneProgressGlobalDataMessage._repeated_perZoneData_codec);
							continue;
						}
						if (num3 != 16U)
						{
							goto IL_0060;
						}
					}
					else if (num3 != 18U)
					{
						if (num3 != 24U && num3 != 26U)
						{
							goto IL_0060;
						}
						this.renownPerRewardThreshold_.AddEntriesFrom(ref input, ZoneProgressGlobalDataMessage._repeated_renownPerRewardThreshold_codec);
						continue;
					}
					this.renownPerProgressType_.AddEntriesFrom(ref input, ZoneProgressGlobalDataMessage._repeated_renownPerProgressType_codec);
				}
				else if (num3 <= 34U)
				{
					if (num3 != 32U && num3 != 34U)
					{
						goto IL_0060;
					}
					this.rewardStringHandles_.AddEntriesFrom(ref input, ZoneProgressGlobalDataMessage._repeated_rewardStringHandles_codec);
				}
				else if (num3 != 40U && num3 != 42U)
				{
					if (num3 != 50U)
					{
						goto IL_0060;
					}
					this.worldToDpoMap_.AddEntriesFrom(ref input, ZoneProgressGlobalDataMessage._repeated_worldToDpoMap_codec);
				}
				else
				{
					this.trackedRewardStringHandles_.AddEntriesFrom(ref input, ZoneProgressGlobalDataMessage._repeated_trackedRewardStringHandles_codec);
				}
				continue;
				IL_0060:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001649 RID: 5705
		private static readonly MessageParser<ZoneProgressGlobalDataMessage> _parser = new MessageParser<ZoneProgressGlobalDataMessage>(() => new ZoneProgressGlobalDataMessage());

		// Token: 0x0400164A RID: 5706
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400164B RID: 5707
		public const int PerZoneDataFieldNumber = 1;

		// Token: 0x0400164C RID: 5708
		private static readonly FieldCodec<ZoneProgressPerZoneGlobalData> _repeated_perZoneData_codec = FieldCodec.ForMessage<ZoneProgressPerZoneGlobalData>(10U, ZoneProgressPerZoneGlobalData.Parser);

		// Token: 0x0400164D RID: 5709
		private readonly RepeatedField<ZoneProgressPerZoneGlobalData> perZoneData_ = new RepeatedField<ZoneProgressPerZoneGlobalData>();

		// Token: 0x0400164E RID: 5710
		public const int RenownPerProgressTypeFieldNumber = 2;

		// Token: 0x0400164F RID: 5711
		private static readonly FieldCodec<int> _repeated_renownPerProgressType_codec = FieldCodec.ForInt32(16U);

		// Token: 0x04001650 RID: 5712
		private readonly RepeatedField<int> renownPerProgressType_ = new RepeatedField<int>();

		// Token: 0x04001651 RID: 5713
		public const int RenownPerRewardThresholdFieldNumber = 3;

		// Token: 0x04001652 RID: 5714
		private static readonly FieldCodec<int> _repeated_renownPerRewardThreshold_codec = FieldCodec.ForInt32(24U);

		// Token: 0x04001653 RID: 5715
		private readonly RepeatedField<int> renownPerRewardThreshold_ = new RepeatedField<int>();

		// Token: 0x04001654 RID: 5716
		public const int RewardStringHandlesFieldNumber = 4;

		// Token: 0x04001655 RID: 5717
		private static readonly FieldCodec<uint> _repeated_rewardStringHandles_codec = FieldCodec.ForUInt32(32U);

		// Token: 0x04001656 RID: 5718
		private readonly RepeatedField<uint> rewardStringHandles_ = new RepeatedField<uint>();

		// Token: 0x04001657 RID: 5719
		public const int TrackedRewardStringHandlesFieldNumber = 5;

		// Token: 0x04001658 RID: 5720
		private static readonly FieldCodec<uint> _repeated_trackedRewardStringHandles_codec = FieldCodec.ForUInt32(40U);

		// Token: 0x04001659 RID: 5721
		private readonly RepeatedField<uint> trackedRewardStringHandles_ = new RepeatedField<uint>();

		// Token: 0x0400165A RID: 5722
		public const int WorldToDpoMapFieldNumber = 6;

		// Token: 0x0400165B RID: 5723
		private static readonly FieldCodec<ZoneProgressWorldToDPOData> _repeated_worldToDpoMap_codec = FieldCodec.ForMessage<ZoneProgressWorldToDPOData>(50U, ZoneProgressWorldToDPOData.Parser);

		// Token: 0x0400165C RID: 5724
		private readonly RepeatedField<ZoneProgressWorldToDPOData> worldToDpoMap_ = new RepeatedField<ZoneProgressWorldToDPOData>();
	}
}
