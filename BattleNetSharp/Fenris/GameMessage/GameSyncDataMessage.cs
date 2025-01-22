using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001FA RID: 506
	public sealed class GameSyncDataMessage : IMessage<GameSyncDataMessage>, IMessage, IEquatable<GameSyncDataMessage>, IDeepCloneable<GameSyncDataMessage>, IBufferMessage
	{
		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x000DBB30 File Offset: 0x000D9D30
		[DebuggerNonUserCode]
		public static MessageParser<GameSyncDataMessage> Parser
		{
			get
			{
				return GameSyncDataMessage._parser;
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x0600378D RID: 14221 RVA: 0x000DBB48 File Offset: 0x000D9D48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[63];
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x000DBB6C File Offset: 0x000D9D6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSyncDataMessage.Descriptor;
			}
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x000DBB83 File Offset: 0x000D9D83
		[DebuggerNonUserCode]
		public GameSyncDataMessage()
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x000DBB98 File Offset: 0x000D9D98
		[DebuggerNonUserCode]
		public GameSyncDataMessage(GameSyncDataMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameSyncedFlags_ = other.gameSyncedFlags_;
			this.subzoneSno_ = other.subzoneSno_;
			this.randomWeatherSeed_ = other.randomWeatherSeed_;
			this.worldTier_ = other.worldTier_;
			this.designerVars_ = other.designerVars_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x000DBC0C File Offset: 0x000D9E0C
		[DebuggerNonUserCode]
		public GameSyncDataMessage Clone()
		{
			return new GameSyncDataMessage(this);
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x000DBC24 File Offset: 0x000D9E24
		// (set) Token: 0x06003793 RID: 14227 RVA: 0x000DBC55 File Offset: 0x000D9E55
		[DebuggerNonUserCode]
		public uint GameSyncedFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameSyncedFlagsDefaultValue;
				if (flag)
				{
					gameSyncedFlagsDefaultValue = this.gameSyncedFlags_;
				}
				else
				{
					gameSyncedFlagsDefaultValue = GameSyncDataMessage.GameSyncedFlagsDefaultValue;
				}
				return gameSyncedFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameSyncedFlags_ = value;
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x000DBC70 File Offset: 0x000D9E70
		[DebuggerNonUserCode]
		public bool HasGameSyncedFlags
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000DBC8D File Offset: 0x000D9E8D
		[DebuggerNonUserCode]
		public void ClearGameSyncedFlags()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x000DBCA0 File Offset: 0x000D9EA0
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x000DBCD1 File Offset: 0x000D9ED1
		[DebuggerNonUserCode]
		public int SubzoneSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int subzoneSnoDefaultValue;
				if (flag)
				{
					subzoneSnoDefaultValue = this.subzoneSno_;
				}
				else
				{
					subzoneSnoDefaultValue = GameSyncDataMessage.SubzoneSnoDefaultValue;
				}
				return subzoneSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.subzoneSno_ = value;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x000DBCEC File Offset: 0x000D9EEC
		[DebuggerNonUserCode]
		public bool HasSubzoneSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x000DBD09 File Offset: 0x000D9F09
		[DebuggerNonUserCode]
		public void ClearSubzoneSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x000DBD1C File Offset: 0x000D9F1C
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x000DBD4D File Offset: 0x000D9F4D
		[DebuggerNonUserCode]
		public int RandomWeatherSeed
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int randomWeatherSeedDefaultValue;
				if (flag)
				{
					randomWeatherSeedDefaultValue = this.randomWeatherSeed_;
				}
				else
				{
					randomWeatherSeedDefaultValue = GameSyncDataMessage.RandomWeatherSeedDefaultValue;
				}
				return randomWeatherSeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.randomWeatherSeed_ = value;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x000DBD68 File Offset: 0x000D9F68
		[DebuggerNonUserCode]
		public bool HasRandomWeatherSeed
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x000DBD85 File Offset: 0x000D9F85
		[DebuggerNonUserCode]
		public void ClearRandomWeatherSeed()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x000DBD98 File Offset: 0x000D9F98
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x000DBDC9 File Offset: 0x000D9FC9
		[DebuggerNonUserCode]
		public int WorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int worldTierDefaultValue;
				if (flag)
				{
					worldTierDefaultValue = this.worldTier_;
				}
				else
				{
					worldTierDefaultValue = GameSyncDataMessage.WorldTierDefaultValue;
				}
				return worldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.worldTier_ = value;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x000DBDE4 File Offset: 0x000D9FE4
		[DebuggerNonUserCode]
		public bool HasWorldTier
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x000DBE01 File Offset: 0x000DA001
		[DebuggerNonUserCode]
		public void ClearWorldTier()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x000DBE14 File Offset: 0x000DA014
		[DebuggerNonUserCode]
		public RepeatedField<DesignerVariable> DesignerVars
		{
			get
			{
				return this.designerVars_;
			}
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x000DBE2C File Offset: 0x000DA02C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameSyncDataMessage);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x000DBE4C File Offset: 0x000DA04C
		[DebuggerNonUserCode]
		public bool Equals(GameSyncDataMessage other)
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
					bool flag4 = this.GameSyncedFlags != other.GameSyncedFlags;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SubzoneSno != other.SubzoneSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.RandomWeatherSeed != other.RandomWeatherSeed;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.WorldTier != other.WorldTier;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.designerVars_.Equals(other.designerVars_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x000DBF1C File Offset: 0x000DA11C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameSyncedFlags = this.HasGameSyncedFlags;
			if (hasGameSyncedFlags)
			{
				num ^= this.GameSyncedFlags.GetHashCode();
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				num ^= this.SubzoneSno.GetHashCode();
			}
			bool hasRandomWeatherSeed = this.HasRandomWeatherSeed;
			if (hasRandomWeatherSeed)
			{
				num ^= this.RandomWeatherSeed.GetHashCode();
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num ^= this.WorldTier.GetHashCode();
			}
			num ^= this.designerVars_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x000DBFD4 File Offset: 0x000DA1D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x000DBFEC File Offset: 0x000DA1EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x000DBFF8 File Offset: 0x000DA1F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameSyncedFlags = this.HasGameSyncedFlags;
			if (hasGameSyncedFlags)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameSyncedFlags);
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.SubzoneSno);
			}
			bool hasRandomWeatherSeed = this.HasRandomWeatherSeed;
			if (hasRandomWeatherSeed)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.RandomWeatherSeed);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				output.WriteRawTag(32);
				output.WriteSInt32(this.WorldTier);
			}
			this.designerVars_.WriteTo(ref output, GameSyncDataMessage._repeated_designerVars_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x000DC0C0 File Offset: 0x000DA2C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameSyncedFlags = this.HasGameSyncedFlags;
			if (hasGameSyncedFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameSyncedFlags);
			}
			bool hasSubzoneSno = this.HasSubzoneSno;
			if (hasSubzoneSno)
			{
				num += 5;
			}
			bool hasRandomWeatherSeed = this.HasRandomWeatherSeed;
			if (hasRandomWeatherSeed)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.RandomWeatherSeed);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.WorldTier);
			}
			num += this.designerVars_.CalculateSize(GameSyncDataMessage._repeated_designerVars_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x000DC170 File Offset: 0x000DA370
		[DebuggerNonUserCode]
		public void MergeFrom(GameSyncDataMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameSyncedFlags = other.HasGameSyncedFlags;
				if (hasGameSyncedFlags)
				{
					this.GameSyncedFlags = other.GameSyncedFlags;
				}
				bool hasSubzoneSno = other.HasSubzoneSno;
				if (hasSubzoneSno)
				{
					this.SubzoneSno = other.SubzoneSno;
				}
				bool hasRandomWeatherSeed = other.HasRandomWeatherSeed;
				if (hasRandomWeatherSeed)
				{
					this.RandomWeatherSeed = other.RandomWeatherSeed;
				}
				bool hasWorldTier = other.HasWorldTier;
				if (hasWorldTier)
				{
					this.WorldTier = other.WorldTier;
				}
				this.designerVars_.Add(other.designerVars_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x000DC21B File Offset: 0x000DA41B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x000DC228 File Offset: 0x000DA428
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0032;
						}
						this.SubzoneSno = input.ReadSFixed32();
					}
					else
					{
						this.GameSyncedFlags = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0032;
						}
						this.designerVars_.AddEntriesFrom(ref input, GameSyncDataMessage._repeated_designerVars_codec);
					}
					else
					{
						this.WorldTier = input.ReadSInt32();
					}
				}
				else
				{
					this.RandomWeatherSeed = input.ReadSInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040019E4 RID: 6628
		private static readonly MessageParser<GameSyncDataMessage> _parser = new MessageParser<GameSyncDataMessage>(() => new GameSyncDataMessage());

		// Token: 0x040019E5 RID: 6629
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019E6 RID: 6630
		private int _hasBits0;

		// Token: 0x040019E7 RID: 6631
		public const int GameSyncedFlagsFieldNumber = 1;

		// Token: 0x040019E8 RID: 6632
		private static readonly uint GameSyncedFlagsDefaultValue = 0U;

		// Token: 0x040019E9 RID: 6633
		private uint gameSyncedFlags_;

		// Token: 0x040019EA RID: 6634
		public const int SubzoneSnoFieldNumber = 2;

		// Token: 0x040019EB RID: 6635
		private static readonly int SubzoneSnoDefaultValue = 0;

		// Token: 0x040019EC RID: 6636
		private int subzoneSno_;

		// Token: 0x040019ED RID: 6637
		public const int RandomWeatherSeedFieldNumber = 3;

		// Token: 0x040019EE RID: 6638
		private static readonly int RandomWeatherSeedDefaultValue = 0;

		// Token: 0x040019EF RID: 6639
		private int randomWeatherSeed_;

		// Token: 0x040019F0 RID: 6640
		public const int WorldTierFieldNumber = 4;

		// Token: 0x040019F1 RID: 6641
		private static readonly int WorldTierDefaultValue = 0;

		// Token: 0x040019F2 RID: 6642
		private int worldTier_;

		// Token: 0x040019F3 RID: 6643
		public const int DesignerVarsFieldNumber = 5;

		// Token: 0x040019F4 RID: 6644
		private static readonly FieldCodec<DesignerVariable> _repeated_designerVars_codec = FieldCodec.ForMessage<DesignerVariable>(42U, DesignerVariable.Parser);

		// Token: 0x040019F5 RID: 6645
		private readonly RepeatedField<DesignerVariable> designerVars_ = new RepeatedField<DesignerVariable>();
	}
}
