using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A7 RID: 423
	public sealed class WorldCreateDebugOverrides : IMessage<WorldCreateDebugOverrides>, IMessage, IEquatable<WorldCreateDebugOverrides>, IDeepCloneable<WorldCreateDebugOverrides>, IBufferMessage
	{
		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x000AEB88 File Offset: 0x000ACD88
		[DebuggerNonUserCode]
		public static MessageParser<WorldCreateDebugOverrides> Parser
		{
			get
			{
				return WorldCreateDebugOverrides._parser;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x000AEBA0 File Offset: 0x000ACDA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x000AEBC4 File Offset: 0x000ACDC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldCreateDebugOverrides.Descriptor;
			}
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000AEBDB File Offset: 0x000ACDDB
		[DebuggerNonUserCode]
		public WorldCreateDebugOverrides()
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000AEBFC File Offset: 0x000ACDFC
		[DebuggerNonUserCode]
		public WorldCreateDebugOverrides(WorldCreateDebugOverrides other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.worldSeed_ = other.worldSeed_;
			this.forcedLabels_ = other.forcedLabels_.Clone();
			this.forcedDungeonStates_ = other.forcedDungeonStates_.Clone();
			this.disableDefaultLabels_ = other.disableDefaultLabels_;
			this.disableDefaultDungeonStates_ = other.disableDefaultDungeonStates_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000AEC74 File Offset: 0x000ACE74
		[DebuggerNonUserCode]
		public WorldCreateDebugOverrides Clone()
		{
			return new WorldCreateDebugOverrides(this);
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000AEC8C File Offset: 0x000ACE8C
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x000AECBD File Offset: 0x000ACEBD
		[DebuggerNonUserCode]
		public int WorldSeed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int worldSeedDefaultValue;
				if (flag)
				{
					worldSeedDefaultValue = this.worldSeed_;
				}
				else
				{
					worldSeedDefaultValue = WorldCreateDebugOverrides.WorldSeedDefaultValue;
				}
				return worldSeedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.worldSeed_ = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x000AECD8 File Offset: 0x000ACED8
		[DebuggerNonUserCode]
		public bool HasWorldSeed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000AECF5 File Offset: 0x000ACEF5
		[DebuggerNonUserCode]
		public void ClearWorldSeed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x000AED08 File Offset: 0x000ACF08
		[DebuggerNonUserCode]
		public RepeatedField<int> ForcedLabels
		{
			get
			{
				return this.forcedLabels_;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x000AED20 File Offset: 0x000ACF20
		[DebuggerNonUserCode]
		public RepeatedField<int> ForcedDungeonStates
		{
			get
			{
				return this.forcedDungeonStates_;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000AED38 File Offset: 0x000ACF38
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x000AED69 File Offset: 0x000ACF69
		[DebuggerNonUserCode]
		public bool DisableDefaultLabels
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool disableDefaultLabelsDefaultValue;
				if (flag)
				{
					disableDefaultLabelsDefaultValue = this.disableDefaultLabels_;
				}
				else
				{
					disableDefaultLabelsDefaultValue = WorldCreateDebugOverrides.DisableDefaultLabelsDefaultValue;
				}
				return disableDefaultLabelsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.disableDefaultLabels_ = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000AED84 File Offset: 0x000ACF84
		[DebuggerNonUserCode]
		public bool HasDisableDefaultLabels
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000AEDA1 File Offset: 0x000ACFA1
		[DebuggerNonUserCode]
		public void ClearDisableDefaultLabels()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000AEDB4 File Offset: 0x000ACFB4
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x000AEDE5 File Offset: 0x000ACFE5
		[DebuggerNonUserCode]
		public bool DisableDefaultDungeonStates
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool disableDefaultDungeonStatesDefaultValue;
				if (flag)
				{
					disableDefaultDungeonStatesDefaultValue = this.disableDefaultDungeonStates_;
				}
				else
				{
					disableDefaultDungeonStatesDefaultValue = WorldCreateDebugOverrides.DisableDefaultDungeonStatesDefaultValue;
				}
				return disableDefaultDungeonStatesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.disableDefaultDungeonStates_ = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000AEE00 File Offset: 0x000AD000
		[DebuggerNonUserCode]
		public bool HasDisableDefaultDungeonStates
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x000AEE1D File Offset: 0x000AD01D
		[DebuggerNonUserCode]
		public void ClearDisableDefaultDungeonStates()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x000AEE30 File Offset: 0x000AD030
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldCreateDebugOverrides);
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000AEE50 File Offset: 0x000AD050
		[DebuggerNonUserCode]
		public bool Equals(WorldCreateDebugOverrides other)
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
					bool flag4 = this.WorldSeed != other.WorldSeed;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.forcedLabels_.Equals(other.forcedLabels_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.forcedDungeonStates_.Equals(other.forcedDungeonStates_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.DisableDefaultLabels != other.DisableDefaultLabels;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.DisableDefaultDungeonStates != other.DisableDefaultDungeonStates;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000AEF24 File Offset: 0x000AD124
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				num ^= this.WorldSeed.GetHashCode();
			}
			num ^= this.forcedLabels_.GetHashCode();
			num ^= this.forcedDungeonStates_.GetHashCode();
			bool hasDisableDefaultLabels = this.HasDisableDefaultLabels;
			if (hasDisableDefaultLabels)
			{
				num ^= this.DisableDefaultLabels.GetHashCode();
			}
			bool hasDisableDefaultDungeonStates = this.HasDisableDefaultDungeonStates;
			if (hasDisableDefaultDungeonStates)
			{
				num ^= this.DisableDefaultDungeonStates.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000AEFCC File Offset: 0x000AD1CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000AEFE4 File Offset: 0x000AD1E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WorldSeed);
			}
			this.forcedLabels_.WriteTo(ref output, WorldCreateDebugOverrides._repeated_forcedLabels_codec);
			this.forcedDungeonStates_.WriteTo(ref output, WorldCreateDebugOverrides._repeated_forcedDungeonStates_codec);
			bool hasDisableDefaultLabels = this.HasDisableDefaultLabels;
			if (hasDisableDefaultLabels)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.DisableDefaultLabels);
			}
			bool hasDisableDefaultDungeonStates = this.HasDisableDefaultDungeonStates;
			if (hasDisableDefaultDungeonStates)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.DisableDefaultDungeonStates);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000AF0A4 File Offset: 0x000AD2A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasWorldSeed = this.HasWorldSeed;
			if (hasWorldSeed)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldSeed);
			}
			num += this.forcedLabels_.CalculateSize(WorldCreateDebugOverrides._repeated_forcedLabels_codec);
			num += this.forcedDungeonStates_.CalculateSize(WorldCreateDebugOverrides._repeated_forcedDungeonStates_codec);
			bool hasDisableDefaultLabels = this.HasDisableDefaultLabels;
			if (hasDisableDefaultLabels)
			{
				num += 2;
			}
			bool hasDisableDefaultDungeonStates = this.HasDisableDefaultDungeonStates;
			if (hasDisableDefaultDungeonStates)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000AF13C File Offset: 0x000AD33C
		[DebuggerNonUserCode]
		public void MergeFrom(WorldCreateDebugOverrides other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasWorldSeed = other.HasWorldSeed;
				if (hasWorldSeed)
				{
					this.WorldSeed = other.WorldSeed;
				}
				this.forcedLabels_.Add(other.forcedLabels_);
				this.forcedDungeonStates_.Add(other.forcedDungeonStates_);
				bool hasDisableDefaultLabels = other.HasDisableDefaultLabels;
				if (hasDisableDefaultLabels)
				{
					this.DisableDefaultLabels = other.DisableDefaultLabels;
				}
				bool hasDisableDefaultDungeonStates = other.HasDisableDefaultDungeonStates;
				if (hasDisableDefaultDungeonStates)
				{
					this.DisableDefaultDungeonStates = other.DisableDefaultDungeonStates;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000AF1DE File Offset: 0x000AD3DE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000AF1EC File Offset: 0x000AD3EC
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
						if (num3 != 18U && num3 != 21U)
						{
							goto IL_0045;
						}
						this.forcedLabels_.AddEntriesFrom(ref input, WorldCreateDebugOverrides._repeated_forcedLabels_codec);
					}
					else
					{
						this.WorldSeed = input.ReadInt32();
					}
				}
				else if (num3 <= 29U)
				{
					if (num3 != 26U && num3 != 29U)
					{
						goto IL_0045;
					}
					this.forcedDungeonStates_.AddEntriesFrom(ref input, WorldCreateDebugOverrides._repeated_forcedDungeonStates_codec);
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						goto IL_0045;
					}
					this.DisableDefaultDungeonStates = input.ReadBool();
				}
				else
				{
					this.DisableDefaultLabels = input.ReadBool();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001419 RID: 5145
		private static readonly MessageParser<WorldCreateDebugOverrides> _parser = new MessageParser<WorldCreateDebugOverrides>(() => new WorldCreateDebugOverrides());

		// Token: 0x0400141A RID: 5146
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400141B RID: 5147
		private int _hasBits0;

		// Token: 0x0400141C RID: 5148
		public const int WorldSeedFieldNumber = 1;

		// Token: 0x0400141D RID: 5149
		private static readonly int WorldSeedDefaultValue = 0;

		// Token: 0x0400141E RID: 5150
		private int worldSeed_;

		// Token: 0x0400141F RID: 5151
		public const int ForcedLabelsFieldNumber = 2;

		// Token: 0x04001420 RID: 5152
		private static readonly FieldCodec<int> _repeated_forcedLabels_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x04001421 RID: 5153
		private readonly RepeatedField<int> forcedLabels_ = new RepeatedField<int>();

		// Token: 0x04001422 RID: 5154
		public const int ForcedDungeonStatesFieldNumber = 3;

		// Token: 0x04001423 RID: 5155
		private static readonly FieldCodec<int> _repeated_forcedDungeonStates_codec = FieldCodec.ForSFixed32(29U);

		// Token: 0x04001424 RID: 5156
		private readonly RepeatedField<int> forcedDungeonStates_ = new RepeatedField<int>();

		// Token: 0x04001425 RID: 5157
		public const int DisableDefaultLabelsFieldNumber = 4;

		// Token: 0x04001426 RID: 5158
		private static readonly bool DisableDefaultLabelsDefaultValue = false;

		// Token: 0x04001427 RID: 5159
		private bool disableDefaultLabels_;

		// Token: 0x04001428 RID: 5160
		public const int DisableDefaultDungeonStatesFieldNumber = 5;

		// Token: 0x04001429 RID: 5161
		private static readonly bool DisableDefaultDungeonStatesDefaultValue = false;

		// Token: 0x0400142A RID: 5162
		private bool disableDefaultDungeonStates_;
	}
}
