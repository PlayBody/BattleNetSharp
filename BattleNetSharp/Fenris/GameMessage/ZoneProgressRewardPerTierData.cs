using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C7 RID: 455
	public sealed class ZoneProgressRewardPerTierData : IMessage<ZoneProgressRewardPerTierData>, IMessage, IEquatable<ZoneProgressRewardPerTierData>, IDeepCloneable<ZoneProgressRewardPerTierData>, IBufferMessage
	{
		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x000C0060 File Offset: 0x000BE260
		[DebuggerNonUserCode]
		public static MessageParser<ZoneProgressRewardPerTierData> Parser
		{
			get
			{
				return ZoneProgressRewardPerTierData._parser;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x000C0078 File Offset: 0x000BE278
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x000C009C File Offset: 0x000BE29C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ZoneProgressRewardPerTierData.Descriptor;
			}
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x000C00B3 File Offset: 0x000BE2B3
		[DebuggerNonUserCode]
		public ZoneProgressRewardPerTierData()
		{
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000C00C8 File Offset: 0x000BE2C8
		[DebuggerNonUserCode]
		public ZoneProgressRewardPerTierData(ZoneProgressRewardPerTierData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.rewards_ = other.rewards_.Clone();
			this.staticXpReward_ = other.staticXpReward_;
			this.xpTier_ = other.xpTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000C0124 File Offset: 0x000BE324
		[DebuggerNonUserCode]
		public ZoneProgressRewardPerTierData Clone()
		{
			return new ZoneProgressRewardPerTierData(this);
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x000C013C File Offset: 0x000BE33C
		[DebuggerNonUserCode]
		public RepeatedField<ZoneProgressRewardData> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x000C0154 File Offset: 0x000BE354
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x000C0185 File Offset: 0x000BE385
		[DebuggerNonUserCode]
		public int StaticXpReward
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int staticXpRewardDefaultValue;
				if (flag)
				{
					staticXpRewardDefaultValue = this.staticXpReward_;
				}
				else
				{
					staticXpRewardDefaultValue = ZoneProgressRewardPerTierData.StaticXpRewardDefaultValue;
				}
				return staticXpRewardDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.staticXpReward_ = value;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x000C01A0 File Offset: 0x000BE3A0
		[DebuggerNonUserCode]
		public bool HasStaticXpReward
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x000C01BD File Offset: 0x000BE3BD
		[DebuggerNonUserCode]
		public void ClearStaticXpReward()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x000C01D0 File Offset: 0x000BE3D0
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x000C0201 File Offset: 0x000BE401
		[DebuggerNonUserCode]
		public int XpTier
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int xpTierDefaultValue;
				if (flag)
				{
					xpTierDefaultValue = this.xpTier_;
				}
				else
				{
					xpTierDefaultValue = ZoneProgressRewardPerTierData.XpTierDefaultValue;
				}
				return xpTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.xpTier_ = value;
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000C021C File Offset: 0x000BE41C
		[DebuggerNonUserCode]
		public bool HasXpTier
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x000C0239 File Offset: 0x000BE439
		[DebuggerNonUserCode]
		public void ClearXpTier()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x000C024C File Offset: 0x000BE44C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ZoneProgressRewardPerTierData);
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x000C026C File Offset: 0x000BE46C
		[DebuggerNonUserCode]
		public bool Equals(ZoneProgressRewardPerTierData other)
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
					bool flag4 = !this.rewards_.Equals(other.rewards_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StaticXpReward != other.StaticXpReward;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.XpTier != other.XpTier;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000C02FC File Offset: 0x000BE4FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewards_.GetHashCode();
			bool hasStaticXpReward = this.HasStaticXpReward;
			if (hasStaticXpReward)
			{
				num ^= this.StaticXpReward.GetHashCode();
			}
			bool hasXpTier = this.HasXpTier;
			if (hasXpTier)
			{
				num ^= this.XpTier.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x000C0378 File Offset: 0x000BE578
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x000C0390 File Offset: 0x000BE590
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x000C039C File Offset: 0x000BE59C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, ZoneProgressRewardPerTierData._repeated_rewards_codec);
			bool hasStaticXpReward = this.HasStaticXpReward;
			if (hasStaticXpReward)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StaticXpReward);
			}
			bool hasXpTier = this.HasXpTier;
			if (hasXpTier)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.XpTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x000C041C File Offset: 0x000BE61C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewards_.CalculateSize(ZoneProgressRewardPerTierData._repeated_rewards_codec);
			bool hasStaticXpReward = this.HasStaticXpReward;
			if (hasStaticXpReward)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StaticXpReward);
			}
			bool hasXpTier = this.HasXpTier;
			if (hasXpTier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.XpTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x000C049C File Offset: 0x000BE69C
		[DebuggerNonUserCode]
		public void MergeFrom(ZoneProgressRewardPerTierData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.rewards_.Add(other.rewards_);
				bool hasStaticXpReward = other.HasStaticXpReward;
				if (hasStaticXpReward)
				{
					this.StaticXpReward = other.StaticXpReward;
				}
				bool hasXpTier = other.HasXpTier;
				if (hasXpTier)
				{
					this.XpTier = other.XpTier;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x000C0510 File Offset: 0x000BE710
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x000C051C File Offset: 0x000BE71C
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.XpTier = input.ReadInt32();
						}
					}
					else
					{
						this.StaticXpReward = input.ReadInt32();
					}
				}
				else
				{
					this.rewards_.AddEntriesFrom(ref input, ZoneProgressRewardPerTierData._repeated_rewards_codec);
				}
			}
		}

		// Token: 0x0400161D RID: 5661
		private static readonly MessageParser<ZoneProgressRewardPerTierData> _parser = new MessageParser<ZoneProgressRewardPerTierData>(() => new ZoneProgressRewardPerTierData());

		// Token: 0x0400161E RID: 5662
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400161F RID: 5663
		private int _hasBits0;

		// Token: 0x04001620 RID: 5664
		public const int RewardsFieldNumber = 1;

		// Token: 0x04001621 RID: 5665
		private static readonly FieldCodec<ZoneProgressRewardData> _repeated_rewards_codec = FieldCodec.ForMessage<ZoneProgressRewardData>(10U, ZoneProgressRewardData.Parser);

		// Token: 0x04001622 RID: 5666
		private readonly RepeatedField<ZoneProgressRewardData> rewards_ = new RepeatedField<ZoneProgressRewardData>();

		// Token: 0x04001623 RID: 5667
		public const int StaticXpRewardFieldNumber = 2;

		// Token: 0x04001624 RID: 5668
		private static readonly int StaticXpRewardDefaultValue = 0;

		// Token: 0x04001625 RID: 5669
		private int staticXpReward_;

		// Token: 0x04001626 RID: 5670
		public const int XpTierFieldNumber = 3;

		// Token: 0x04001627 RID: 5671
		private static readonly int XpTierDefaultValue = 0;

		// Token: 0x04001628 RID: 5672
		private int xpTier_;
	}
}
