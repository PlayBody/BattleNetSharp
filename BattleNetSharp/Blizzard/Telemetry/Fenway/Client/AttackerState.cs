using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000322 RID: 802
	public sealed class AttackerState : IMessage<AttackerState>, IMessage, IEquatable<AttackerState>, IDeepCloneable<AttackerState>, IBufferMessage
	{
		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x00144718 File Offset: 0x00142918
		[DebuggerNonUserCode]
		public static MessageParser<AttackerState> Parser
		{
			get
			{
				return AttackerState._parser;
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060053FD RID: 21501 RVA: 0x00144730 File Offset: 0x00142930
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonAttackerStateReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x00144754 File Offset: 0x00142954
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttackerState.Descriptor;
			}
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x0014476B File Offset: 0x0014296B
		[DebuggerNonUserCode]
		public AttackerState()
		{
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x00144780 File Offset: 0x00142980
		[DebuggerNonUserCode]
		public AttackerState(AttackerState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attackerId_ = other.attackerId_;
			this.attackerName_ = other.attackerName_;
			this.stats_ = other.stats_.Clone();
			this.skillState_ = ((other.skillState_ != null) ? other.skillState_.Clone() : null);
			this.inventoryState_ = ((other.inventoryState_ != null) ? other.inventoryState_.Clone() : null);
			this.attackerType_ = other.attackerType_;
			this.championBonus_ = other.championBonus_;
			this.uniqueBonuses_ = ((other.uniqueBonuses_ != null) ? other.uniqueBonuses_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x00144848 File Offset: 0x00142A48
		[DebuggerNonUserCode]
		public AttackerState Clone()
		{
			return new AttackerState(this);
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x00144860 File Offset: 0x00142A60
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x00144891 File Offset: 0x00142A91
		[DebuggerNonUserCode]
		public uint AttackerId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint attackerIdDefaultValue;
				if (flag)
				{
					attackerIdDefaultValue = this.attackerId_;
				}
				else
				{
					attackerIdDefaultValue = AttackerState.AttackerIdDefaultValue;
				}
				return attackerIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.attackerId_ = value;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x001448AC File Offset: 0x00142AAC
		[DebuggerNonUserCode]
		public bool HasAttackerId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x001448C9 File Offset: 0x00142AC9
		[DebuggerNonUserCode]
		public void ClearAttackerId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x001448DC File Offset: 0x00142ADC
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x001448FD File Offset: 0x00142AFD
		[DebuggerNonUserCode]
		public string AttackerName
		{
			get
			{
				return this.attackerName_ ?? AttackerState.AttackerNameDefaultValue;
			}
			set
			{
				this.attackerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x00144914 File Offset: 0x00142B14
		[DebuggerNonUserCode]
		public bool HasAttackerName
		{
			get
			{
				return this.attackerName_ != null;
			}
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x0014492F File Offset: 0x00142B2F
		[DebuggerNonUserCode]
		public void ClearAttackerName()
		{
			this.attackerName_ = null;
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x0014493C File Offset: 0x00142B3C
		[DebuggerNonUserCode]
		public RepeatedField<StatEntry> Stats
		{
			get
			{
				return this.stats_;
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x0600540B RID: 21515 RVA: 0x00144954 File Offset: 0x00142B54
		// (set) Token: 0x0600540C RID: 21516 RVA: 0x0014496C File Offset: 0x00142B6C
		[DebuggerNonUserCode]
		public SkillState SkillState
		{
			get
			{
				return this.skillState_;
			}
			set
			{
				this.skillState_ = value;
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x00144978 File Offset: 0x00142B78
		// (set) Token: 0x0600540E RID: 21518 RVA: 0x00144990 File Offset: 0x00142B90
		[DebuggerNonUserCode]
		public InventoryState InventoryState
		{
			get
			{
				return this.inventoryState_;
			}
			set
			{
				this.inventoryState_ = value;
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x0014499C File Offset: 0x00142B9C
		// (set) Token: 0x06005410 RID: 21520 RVA: 0x001449CD File Offset: 0x00142BCD
		[DebuggerNonUserCode]
		public AttackerState.Types.AttackerType AttackerType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				AttackerState.Types.AttackerType attackerTypeDefaultValue;
				if (flag)
				{
					attackerTypeDefaultValue = this.attackerType_;
				}
				else
				{
					attackerTypeDefaultValue = AttackerState.AttackerTypeDefaultValue;
				}
				return attackerTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.attackerType_ = value;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x001449E8 File Offset: 0x00142BE8
		[DebuggerNonUserCode]
		public bool HasAttackerType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x00144A05 File Offset: 0x00142C05
		[DebuggerNonUserCode]
		public void ClearAttackerType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06005413 RID: 21523 RVA: 0x00144A18 File Offset: 0x00142C18
		// (set) Token: 0x06005414 RID: 21524 RVA: 0x00144A49 File Offset: 0x00142C49
		[DebuggerNonUserCode]
		public AttackerState.Types.ChampionBonus ChampionBonus
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				AttackerState.Types.ChampionBonus championBonusDefaultValue;
				if (flag)
				{
					championBonusDefaultValue = this.championBonus_;
				}
				else
				{
					championBonusDefaultValue = AttackerState.ChampionBonusDefaultValue;
				}
				return championBonusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.championBonus_ = value;
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06005415 RID: 21525 RVA: 0x00144A64 File Offset: 0x00142C64
		[DebuggerNonUserCode]
		public bool HasChampionBonus
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x00144A81 File Offset: 0x00142C81
		[DebuggerNonUserCode]
		public void ClearChampionBonus()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06005417 RID: 21527 RVA: 0x00144A94 File Offset: 0x00142C94
		// (set) Token: 0x06005418 RID: 21528 RVA: 0x00144AAC File Offset: 0x00142CAC
		[DebuggerNonUserCode]
		public UniqueBonusState UniqueBonuses
		{
			get
			{
				return this.uniqueBonuses_;
			}
			set
			{
				this.uniqueBonuses_ = value;
			}
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x00144AB8 File Offset: 0x00142CB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttackerState);
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x00144AD8 File Offset: 0x00142CD8
		[DebuggerNonUserCode]
		public bool Equals(AttackerState other)
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
					bool flag4 = this.AttackerId != other.AttackerId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AttackerName != other.AttackerName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.stats_.Equals(other.stats_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.SkillState, other.SkillState);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.InventoryState, other.InventoryState);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.AttackerType != other.AttackerType;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ChampionBonus != other.ChampionBonus;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.UniqueBonuses, other.UniqueBonuses);
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600541B RID: 21531 RVA: 0x00144C0C File Offset: 0x00142E0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAttackerId = this.HasAttackerId;
			if (hasAttackerId)
			{
				num ^= this.AttackerId.GetHashCode();
			}
			bool hasAttackerName = this.HasAttackerName;
			if (hasAttackerName)
			{
				num ^= this.AttackerName.GetHashCode();
			}
			num ^= this.stats_.GetHashCode();
			bool flag = this.skillState_ != null;
			if (flag)
			{
				num ^= this.SkillState.GetHashCode();
			}
			bool flag2 = this.inventoryState_ != null;
			if (flag2)
			{
				num ^= this.InventoryState.GetHashCode();
			}
			bool hasAttackerType = this.HasAttackerType;
			if (hasAttackerType)
			{
				num ^= this.AttackerType.GetHashCode();
			}
			bool hasChampionBonus = this.HasChampionBonus;
			if (hasChampionBonus)
			{
				num ^= this.ChampionBonus.GetHashCode();
			}
			bool flag3 = this.uniqueBonuses_ != null;
			if (flag3)
			{
				num ^= this.UniqueBonuses.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x00144D24 File Offset: 0x00142F24
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x00144D3C File Offset: 0x00142F3C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x00144D48 File Offset: 0x00142F48
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAttackerId = this.HasAttackerId;
			if (hasAttackerId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AttackerId);
			}
			bool hasAttackerName = this.HasAttackerName;
			if (hasAttackerName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AttackerName);
			}
			this.stats_.WriteTo(ref output, AttackerState._repeated_stats_codec);
			bool flag = this.skillState_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SkillState);
			}
			bool flag2 = this.inventoryState_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.InventoryState);
			}
			bool hasAttackerType = this.HasAttackerType;
			if (hasAttackerType)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.AttackerType);
			}
			bool hasChampionBonus = this.HasChampionBonus;
			if (hasChampionBonus)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ChampionBonus);
			}
			bool flag3 = this.uniqueBonuses_ != null;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.UniqueBonuses);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x00144E84 File Offset: 0x00143084
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAttackerId = this.HasAttackerId;
			if (hasAttackerId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AttackerId);
			}
			bool hasAttackerName = this.HasAttackerName;
			if (hasAttackerName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AttackerName);
			}
			num += this.stats_.CalculateSize(AttackerState._repeated_stats_codec);
			bool flag = this.skillState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillState);
			}
			bool flag2 = this.inventoryState_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InventoryState);
			}
			bool hasAttackerType = this.HasAttackerType;
			if (hasAttackerType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AttackerType);
			}
			bool hasChampionBonus = this.HasChampionBonus;
			if (hasChampionBonus)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChampionBonus);
			}
			bool flag3 = this.uniqueBonuses_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UniqueBonuses);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x00144FA4 File Offset: 0x001431A4
		[DebuggerNonUserCode]
		public void MergeFrom(AttackerState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAttackerId = other.HasAttackerId;
				if (hasAttackerId)
				{
					this.AttackerId = other.AttackerId;
				}
				bool hasAttackerName = other.HasAttackerName;
				if (hasAttackerName)
				{
					this.AttackerName = other.AttackerName;
				}
				this.stats_.Add(other.stats_);
				bool flag2 = other.skillState_ != null;
				if (flag2)
				{
					bool flag3 = this.skillState_ == null;
					if (flag3)
					{
						this.SkillState = new SkillState();
					}
					this.SkillState.MergeFrom(other.SkillState);
				}
				bool flag4 = other.inventoryState_ != null;
				if (flag4)
				{
					bool flag5 = this.inventoryState_ == null;
					if (flag5)
					{
						this.InventoryState = new InventoryState();
					}
					this.InventoryState.MergeFrom(other.InventoryState);
				}
				bool hasAttackerType = other.HasAttackerType;
				if (hasAttackerType)
				{
					this.AttackerType = other.AttackerType;
				}
				bool hasChampionBonus = other.HasChampionBonus;
				if (hasChampionBonus)
				{
					this.ChampionBonus = other.ChampionBonus;
				}
				bool flag6 = other.uniqueBonuses_ != null;
				if (flag6)
				{
					bool flag7 = this.uniqueBonuses_ == null;
					if (flag7)
					{
						this.UniqueBonuses = new UniqueBonusState();
					}
					this.UniqueBonuses.MergeFrom(other.UniqueBonuses);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x0014510F File Offset: 0x0014330F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x0014511C File Offset: 0x0014331C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								goto IL_0060;
							}
							this.AttackerName = input.ReadString();
						}
						else
						{
							this.AttackerId = input.ReadUInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0060;
						}
						bool flag = this.skillState_ == null;
						if (flag)
						{
							this.SkillState = new SkillState();
						}
						input.ReadMessage(this.SkillState);
					}
					else
					{
						this.stats_.AddEntriesFrom(ref input, AttackerState._repeated_stats_codec);
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0060;
						}
						this.AttackerType = (AttackerState.Types.AttackerType)input.ReadEnum();
					}
					else
					{
						bool flag2 = this.inventoryState_ == null;
						if (flag2)
						{
							this.InventoryState = new InventoryState();
						}
						input.ReadMessage(this.InventoryState);
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						goto IL_0060;
					}
					bool flag3 = this.uniqueBonuses_ == null;
					if (flag3)
					{
						this.UniqueBonuses = new UniqueBonusState();
					}
					input.ReadMessage(this.UniqueBonuses);
				}
				else
				{
					this.ChampionBonus = (AttackerState.Types.ChampionBonus)input.ReadEnum();
				}
				continue;
				IL_0060:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400261E RID: 9758
		private static readonly MessageParser<AttackerState> _parser = new MessageParser<AttackerState>(() => new AttackerState());

		// Token: 0x0400261F RID: 9759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002620 RID: 9760
		private int _hasBits0;

		// Token: 0x04002621 RID: 9761
		public const int AttackerIdFieldNumber = 1;

		// Token: 0x04002622 RID: 9762
		private static readonly uint AttackerIdDefaultValue = 0U;

		// Token: 0x04002623 RID: 9763
		private uint attackerId_;

		// Token: 0x04002624 RID: 9764
		public const int AttackerNameFieldNumber = 2;

		// Token: 0x04002625 RID: 9765
		private static readonly string AttackerNameDefaultValue = "";

		// Token: 0x04002626 RID: 9766
		private string attackerName_;

		// Token: 0x04002627 RID: 9767
		public const int StatsFieldNumber = 3;

		// Token: 0x04002628 RID: 9768
		private static readonly FieldCodec<StatEntry> _repeated_stats_codec = FieldCodec.ForMessage<StatEntry>(26U, StatEntry.Parser);

		// Token: 0x04002629 RID: 9769
		private readonly RepeatedField<StatEntry> stats_ = new RepeatedField<StatEntry>();

		// Token: 0x0400262A RID: 9770
		public const int SkillStateFieldNumber = 4;

		// Token: 0x0400262B RID: 9771
		private SkillState skillState_;

		// Token: 0x0400262C RID: 9772
		public const int InventoryStateFieldNumber = 5;

		// Token: 0x0400262D RID: 9773
		private InventoryState inventoryState_;

		// Token: 0x0400262E RID: 9774
		public const int AttackerTypeFieldNumber = 6;

		// Token: 0x0400262F RID: 9775
		private static readonly AttackerState.Types.AttackerType AttackerTypeDefaultValue = AttackerState.Types.AttackerType.Standard;

		// Token: 0x04002630 RID: 9776
		private AttackerState.Types.AttackerType attackerType_;

		// Token: 0x04002631 RID: 9777
		public const int ChampionBonusFieldNumber = 7;

		// Token: 0x04002632 RID: 9778
		private static readonly AttackerState.Types.ChampionBonus ChampionBonusDefaultValue = AttackerState.Types.ChampionBonus.None;

		// Token: 0x04002633 RID: 9779
		private AttackerState.Types.ChampionBonus championBonus_;

		// Token: 0x04002634 RID: 9780
		public const int UniqueBonusesFieldNumber = 8;

		// Token: 0x04002635 RID: 9781
		private UniqueBonusState uniqueBonuses_;

		// Token: 0x02000E18 RID: 3608
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200148D RID: 5261
			public enum AttackerType
			{
				// Token: 0x0400A4AB RID: 42155
				[OriginalName("Standard")]
				Standard,
				// Token: 0x0400A4AC RID: 42156
				[OriginalName("Champion")]
				Champion,
				// Token: 0x0400A4AD RID: 42157
				[OriginalName("Unique")]
				Unique,
				// Token: 0x0400A4AE RID: 42158
				[OriginalName("SuperUnique")]
				SuperUnique,
				// Token: 0x0400A4AF RID: 42159
				[OriginalName("SubBoss")]
				SubBoss,
				// Token: 0x0400A4B0 RID: 42160
				[OriginalName("Boss")]
				Boss,
				// Token: 0x0400A4B1 RID: 42161
				[OriginalName("Player")]
				Player,
				// Token: 0x0400A4B2 RID: 42162
				[OriginalName("Environment")]
				Environment,
				// Token: 0x0400A4B3 RID: 42163
				[OriginalName("Self")]
				Self,
				// Token: 0x0400A4B4 RID: 42164
				[OriginalName("Unknown")]
				Unknown
			}

			// Token: 0x0200148E RID: 5262
			public enum ChampionBonus
			{
				// Token: 0x0400A4B6 RID: 42166
				[OriginalName("None")]
				None,
				// Token: 0x0400A4B7 RID: 42167
				[OriginalName("Ghostly")]
				Ghostly,
				// Token: 0x0400A4B8 RID: 42168
				[OriginalName("Fanatic")]
				Fanatic,
				// Token: 0x0400A4B9 RID: 42169
				[OriginalName("Berseker")]
				Berseker,
				// Token: 0x0400A4BA RID: 42170
				[OriginalName("Possessed")]
				Possessed
			}
		}
	}
}
