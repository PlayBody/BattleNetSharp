using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A9 RID: 425
	public sealed class CampaignState : IMessage<CampaignState>, IMessage, IEquatable<CampaignState>, IDeepCloneable<CampaignState>, IBufferMessage
	{
		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x000AFB0C File Offset: 0x000ADD0C
		[DebuggerNonUserCode]
		public static MessageParser<CampaignState> Parser
		{
			get
			{
				return CampaignState._parser;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000AFB24 File Offset: 0x000ADD24
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x000AFB48 File Offset: 0x000ADD48
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CampaignState.Descriptor;
			}
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000AFB5F File Offset: 0x000ADD5F
		[DebuggerNonUserCode]
		public CampaignState()
		{
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x000AFB74 File Offset: 0x000ADD74
		[DebuggerNonUserCode]
		public CampaignState(CampaignState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sourceBnetAccountId_ = other.sourceBnetAccountId_;
			this.sourceGameAccountId_ = other.sourceGameAccountId_;
			this.snoQuest_ = other.snoQuest_.Clone();
			this.keyedDungeonData_ = ((other.keyedDungeonData_ != null) ? other.keyedDungeonData_.Clone() : null);
			this.worldCreateDebugOverrides_ = ((other.worldCreateDebugOverrides_ != null) ? other.worldCreateDebugOverrides_.Clone() : null);
			this.worldTier_ = other.worldTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000AFC14 File Offset: 0x000ADE14
		[DebuggerNonUserCode]
		public CampaignState Clone()
		{
			return new CampaignState(this);
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x000AFC2C File Offset: 0x000ADE2C
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x000AFC5D File Offset: 0x000ADE5D
		[DebuggerNonUserCode]
		public uint SourceBnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint sourceBnetAccountIdDefaultValue;
				if (flag)
				{
					sourceBnetAccountIdDefaultValue = this.sourceBnetAccountId_;
				}
				else
				{
					sourceBnetAccountIdDefaultValue = CampaignState.SourceBnetAccountIdDefaultValue;
				}
				return sourceBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sourceBnetAccountId_ = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x000AFC78 File Offset: 0x000ADE78
		[DebuggerNonUserCode]
		public bool HasSourceBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x000AFC95 File Offset: 0x000ADE95
		[DebuggerNonUserCode]
		public void ClearSourceBnetAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000AFCA8 File Offset: 0x000ADEA8
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x000AFCD9 File Offset: 0x000ADED9
		[DebuggerNonUserCode]
		public uint SourceGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint sourceGameAccountIdDefaultValue;
				if (flag)
				{
					sourceGameAccountIdDefaultValue = this.sourceGameAccountId_;
				}
				else
				{
					sourceGameAccountIdDefaultValue = CampaignState.SourceGameAccountIdDefaultValue;
				}
				return sourceGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.sourceGameAccountId_ = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x000AFCF4 File Offset: 0x000ADEF4
		[DebuggerNonUserCode]
		public bool HasSourceGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000AFD11 File Offset: 0x000ADF11
		[DebuggerNonUserCode]
		public void ClearSourceGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x000AFD24 File Offset: 0x000ADF24
		[DebuggerNonUserCode]
		public RepeatedField<uint> SnoQuest
		{
			get
			{
				return this.snoQuest_;
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x000AFD3C File Offset: 0x000ADF3C
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x000AFD54 File Offset: 0x000ADF54
		[DebuggerNonUserCode]
		public KeyedDungeonData KeyedDungeonData
		{
			get
			{
				return this.keyedDungeonData_;
			}
			set
			{
				this.keyedDungeonData_ = value;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x000AFD60 File Offset: 0x000ADF60
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x000AFD78 File Offset: 0x000ADF78
		[DebuggerNonUserCode]
		public WorldCreateDebugOverrides WorldCreateDebugOverrides
		{
			get
			{
				return this.worldCreateDebugOverrides_;
			}
			set
			{
				this.worldCreateDebugOverrides_ = value;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000AFD84 File Offset: 0x000ADF84
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x000AFDB5 File Offset: 0x000ADFB5
		[DebuggerNonUserCode]
		public int WorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int worldTierDefaultValue;
				if (flag)
				{
					worldTierDefaultValue = this.worldTier_;
				}
				else
				{
					worldTierDefaultValue = CampaignState.WorldTierDefaultValue;
				}
				return worldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.worldTier_ = value;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x000AFDD0 File Offset: 0x000ADFD0
		[DebuggerNonUserCode]
		public bool HasWorldTier
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000AFDED File Offset: 0x000ADFED
		[DebuggerNonUserCode]
		public void ClearWorldTier()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000AFE00 File Offset: 0x000AE000
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CampaignState);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000AFE20 File Offset: 0x000AE020
		[DebuggerNonUserCode]
		public bool Equals(CampaignState other)
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
					bool flag4 = this.SourceBnetAccountId != other.SourceBnetAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SourceGameAccountId != other.SourceGameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.snoQuest_.Equals(other.snoQuest_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.KeyedDungeonData, other.KeyedDungeonData);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.WorldCreateDebugOverrides, other.WorldCreateDebugOverrides);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.WorldTier != other.WorldTier;
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

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000AFF14 File Offset: 0x000AE114
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSourceBnetAccountId = this.HasSourceBnetAccountId;
			if (hasSourceBnetAccountId)
			{
				num ^= this.SourceBnetAccountId.GetHashCode();
			}
			bool hasSourceGameAccountId = this.HasSourceGameAccountId;
			if (hasSourceGameAccountId)
			{
				num ^= this.SourceGameAccountId.GetHashCode();
			}
			num ^= this.snoQuest_.GetHashCode();
			bool flag = this.keyedDungeonData_ != null;
			if (flag)
			{
				num ^= this.KeyedDungeonData.GetHashCode();
			}
			bool flag2 = this.worldCreateDebugOverrides_ != null;
			if (flag2)
			{
				num ^= this.WorldCreateDebugOverrides.GetHashCode();
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num ^= this.WorldTier.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000AFFE8 File Offset: 0x000AE1E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000B0000 File Offset: 0x000AE200
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000B000C File Offset: 0x000AE20C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSourceBnetAccountId = this.HasSourceBnetAccountId;
			if (hasSourceBnetAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.SourceBnetAccountId);
			}
			bool hasSourceGameAccountId = this.HasSourceGameAccountId;
			if (hasSourceGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SourceGameAccountId);
			}
			this.snoQuest_.WriteTo(ref output, CampaignState._repeated_snoQuest_codec);
			bool flag = this.keyedDungeonData_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.KeyedDungeonData);
			}
			bool flag2 = this.worldCreateDebugOverrides_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.WorldCreateDebugOverrides);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				output.WriteRawTag(48);
				output.WriteSInt32(this.WorldTier);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000B00FC File Offset: 0x000AE2FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSourceBnetAccountId = this.HasSourceBnetAccountId;
			if (hasSourceBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceBnetAccountId);
			}
			bool hasSourceGameAccountId = this.HasSourceGameAccountId;
			if (hasSourceGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceGameAccountId);
			}
			num += this.snoQuest_.CalculateSize(CampaignState._repeated_snoQuest_codec);
			bool flag = this.keyedDungeonData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KeyedDungeonData);
			}
			bool flag2 = this.worldCreateDebugOverrides_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WorldCreateDebugOverrides);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.WorldTier);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000B01DC File Offset: 0x000AE3DC
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSourceBnetAccountId = other.HasSourceBnetAccountId;
				if (hasSourceBnetAccountId)
				{
					this.SourceBnetAccountId = other.SourceBnetAccountId;
				}
				bool hasSourceGameAccountId = other.HasSourceGameAccountId;
				if (hasSourceGameAccountId)
				{
					this.SourceGameAccountId = other.SourceGameAccountId;
				}
				this.snoQuest_.Add(other.snoQuest_);
				bool flag2 = other.keyedDungeonData_ != null;
				if (flag2)
				{
					bool flag3 = this.keyedDungeonData_ == null;
					if (flag3)
					{
						this.KeyedDungeonData = new KeyedDungeonData();
					}
					this.KeyedDungeonData.MergeFrom(other.KeyedDungeonData);
				}
				bool flag4 = other.worldCreateDebugOverrides_ != null;
				if (flag4)
				{
					bool flag5 = this.worldCreateDebugOverrides_ == null;
					if (flag5)
					{
						this.WorldCreateDebugOverrides = new WorldCreateDebugOverrides();
					}
					this.WorldCreateDebugOverrides.MergeFrom(other.WorldCreateDebugOverrides);
				}
				bool hasWorldTier = other.HasWorldTier;
				if (hasWorldTier)
				{
					this.WorldTier = other.WorldTier;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x000B02EC File Offset: 0x000AE4EC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000B02F8 File Offset: 0x000AE4F8
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 26U)
							{
								goto IL_004B;
							}
							goto IL_0085;
						}
						else
						{
							this.SourceGameAccountId = input.ReadUInt32();
						}
					}
					else
					{
						this.SourceBnetAccountId = input.ReadUInt32();
					}
				}
				else if (num3 <= 34U)
				{
					if (num3 == 29U)
					{
						goto IL_0085;
					}
					if (num3 != 34U)
					{
						goto IL_004B;
					}
					bool flag = this.keyedDungeonData_ == null;
					if (flag)
					{
						this.KeyedDungeonData = new KeyedDungeonData();
					}
					input.ReadMessage(this.KeyedDungeonData);
				}
				else if (num3 != 42U)
				{
					if (num3 != 48U)
					{
						goto IL_004B;
					}
					this.WorldTier = input.ReadSInt32();
				}
				else
				{
					bool flag2 = this.worldCreateDebugOverrides_ == null;
					if (flag2)
					{
						this.WorldCreateDebugOverrides = new WorldCreateDebugOverrides();
					}
					input.ReadMessage(this.WorldCreateDebugOverrides);
				}
				continue;
				IL_004B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_0085:
				this.snoQuest_.AddEntriesFrom(ref input, CampaignState._repeated_snoQuest_codec);
			}
		}

		// Token: 0x0400143C RID: 5180
		private static readonly MessageParser<CampaignState> _parser = new MessageParser<CampaignState>(() => new CampaignState());

		// Token: 0x0400143D RID: 5181
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400143E RID: 5182
		private int _hasBits0;

		// Token: 0x0400143F RID: 5183
		public const int SourceBnetAccountIdFieldNumber = 1;

		// Token: 0x04001440 RID: 5184
		private static readonly uint SourceBnetAccountIdDefaultValue = 0U;

		// Token: 0x04001441 RID: 5185
		private uint sourceBnetAccountId_;

		// Token: 0x04001442 RID: 5186
		public const int SourceGameAccountIdFieldNumber = 2;

		// Token: 0x04001443 RID: 5187
		private static readonly uint SourceGameAccountIdDefaultValue = 0U;

		// Token: 0x04001444 RID: 5188
		private uint sourceGameAccountId_;

		// Token: 0x04001445 RID: 5189
		public const int SnoQuestFieldNumber = 3;

		// Token: 0x04001446 RID: 5190
		private static readonly FieldCodec<uint> _repeated_snoQuest_codec = FieldCodec.ForFixed32(26U);

		// Token: 0x04001447 RID: 5191
		private readonly RepeatedField<uint> snoQuest_ = new RepeatedField<uint>();

		// Token: 0x04001448 RID: 5192
		public const int KeyedDungeonDataFieldNumber = 4;

		// Token: 0x04001449 RID: 5193
		private KeyedDungeonData keyedDungeonData_;

		// Token: 0x0400144A RID: 5194
		public const int WorldCreateDebugOverridesFieldNumber = 5;

		// Token: 0x0400144B RID: 5195
		private WorldCreateDebugOverrides worldCreateDebugOverrides_;

		// Token: 0x0400144C RID: 5196
		public const int WorldTierFieldNumber = 6;

		// Token: 0x0400144D RID: 5197
		private static readonly int WorldTierDefaultValue = 0;

		// Token: 0x0400144E RID: 5198
		private int worldTier_;
	}
}
