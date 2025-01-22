using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200018C RID: 396
	public sealed class Skills : IMessage<Skills>, IMessage, IEquatable<Skills>, IDeepCloneable<Skills>, IBufferMessage
	{
		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x000A2C08 File Offset: 0x000A0E08
		[DebuggerNonUserCode]
		public static MessageParser<Skills> Parser
		{
			get
			{
				return Skills._parser;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000A2C20 File Offset: 0x000A0E20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x000A2C44 File Offset: 0x000A0E44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Skills.Descriptor;
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000A2C5C File Offset: 0x000A0E5C
		[DebuggerNonUserCode]
		public Skills()
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000A2CA8 File Offset: 0x000A0EA8
		[DebuggerNonUserCode]
		public Skills(Skills other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.activeSkills_ = other.activeSkills_.Clone();
			this.skillVersion_ = other.skillVersion_;
			this.skillKitVersion_ = other.skillKitVersion_;
			this.purchasedSkillTreeNode_ = other.purchasedSkillTreeNode_.Clone();
			this.lastPurchasedSkillTreeNode_ = other.lastPurchasedSkillTreeNode_;
			this.enchantSkill_ = other.enchantSkill_.Clone();
			this.paragonBoard_ = ((other.paragonBoard_ != null) ? other.paragonBoard_.Clone() : null);
			this.paragonGlyph_ = ((other.paragonGlyph_ != null) ? other.paragonGlyph_.Clone() : null);
			this.skillExtraArsenals_ = other.skillExtraArsenals_.Clone();
			this.classPassiveSkill_ = other.classPassiveSkill_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000A2D8C File Offset: 0x000A0F8C
		[DebuggerNonUserCode]
		public Skills Clone()
		{
			return new Skills(this);
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000A2DA4 File Offset: 0x000A0FA4
		[DebuggerNonUserCode]
		public RepeatedField<Skill> ActiveSkills
		{
			get
			{
				return this.activeSkills_;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000A2DBC File Offset: 0x000A0FBC
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x000A2DED File Offset: 0x000A0FED
		[DebuggerNonUserCode]
		public uint SkillVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint skillVersionDefaultValue;
				if (flag)
				{
					skillVersionDefaultValue = this.skillVersion_;
				}
				else
				{
					skillVersionDefaultValue = Skills.SkillVersionDefaultValue;
				}
				return skillVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.skillVersion_ = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000A2E08 File Offset: 0x000A1008
		[DebuggerNonUserCode]
		public bool HasSkillVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000A2E25 File Offset: 0x000A1025
		[DebuggerNonUserCode]
		public void ClearSkillVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000A2E38 File Offset: 0x000A1038
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x000A2E69 File Offset: 0x000A1069
		[DebuggerNonUserCode]
		public uint SkillKitVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint skillKitVersionDefaultValue;
				if (flag)
				{
					skillKitVersionDefaultValue = this.skillKitVersion_;
				}
				else
				{
					skillKitVersionDefaultValue = Skills.SkillKitVersionDefaultValue;
				}
				return skillKitVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.skillKitVersion_ = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000A2E84 File Offset: 0x000A1084
		[DebuggerNonUserCode]
		public bool HasSkillKitVersion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000A2EA1 File Offset: 0x000A10A1
		[DebuggerNonUserCode]
		public void ClearSkillKitVersion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000A2EB4 File Offset: 0x000A10B4
		[DebuggerNonUserCode]
		public RepeatedField<SavedSkillTreeNode> PurchasedSkillTreeNode
		{
			get
			{
				return this.purchasedSkillTreeNode_;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x000A2ECC File Offset: 0x000A10CC
		// (set) Token: 0x060029AE RID: 10670 RVA: 0x000A2EFD File Offset: 0x000A10FD
		[DebuggerNonUserCode]
		public uint LastPurchasedSkillTreeNode
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint lastPurchasedSkillTreeNodeDefaultValue;
				if (flag)
				{
					lastPurchasedSkillTreeNodeDefaultValue = this.lastPurchasedSkillTreeNode_;
				}
				else
				{
					lastPurchasedSkillTreeNodeDefaultValue = Skills.LastPurchasedSkillTreeNodeDefaultValue;
				}
				return lastPurchasedSkillTreeNodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.lastPurchasedSkillTreeNode_ = value;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x000A2F18 File Offset: 0x000A1118
		[DebuggerNonUserCode]
		public bool HasLastPurchasedSkillTreeNode
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000A2F35 File Offset: 0x000A1135
		[DebuggerNonUserCode]
		public void ClearLastPurchasedSkillTreeNode()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x000A2F48 File Offset: 0x000A1148
		[DebuggerNonUserCode]
		public RepeatedField<Skill> EnchantSkill
		{
			get
			{
				return this.enchantSkill_;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000A2F60 File Offset: 0x000A1160
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x000A2F78 File Offset: 0x000A1178
		[DebuggerNonUserCode]
		public ParagonBoardSavedData ParagonBoard
		{
			get
			{
				return this.paragonBoard_;
			}
			set
			{
				this.paragonBoard_ = value;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000A2F84 File Offset: 0x000A1184
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x000A2F9C File Offset: 0x000A119C
		[DebuggerNonUserCode]
		public ParagonGlyphSavedData ParagonGlyph
		{
			get
			{
				return this.paragonGlyph_;
			}
			set
			{
				this.paragonGlyph_ = value;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x000A2FA8 File Offset: 0x000A11A8
		[DebuggerNonUserCode]
		public RepeatedField<SavedSkillExtraAndArsenal> SkillExtraArsenals
		{
			get
			{
				return this.skillExtraArsenals_;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x000A2FC0 File Offset: 0x000A11C0
		[DebuggerNonUserCode]
		public RepeatedField<Skill> ClassPassiveSkill
		{
			get
			{
				return this.classPassiveSkill_;
			}
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000A2FD8 File Offset: 0x000A11D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Skills);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000A2FF8 File Offset: 0x000A11F8
		[DebuggerNonUserCode]
		public bool Equals(Skills other)
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
					bool flag4 = !this.activeSkills_.Equals(other.activeSkills_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SkillVersion != other.SkillVersion;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SkillKitVersion != other.SkillKitVersion;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.purchasedSkillTreeNode_.Equals(other.purchasedSkillTreeNode_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.LastPurchasedSkillTreeNode != other.LastPurchasedSkillTreeNode;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.enchantSkill_.Equals(other.enchantSkill_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.ParagonBoard, other.ParagonBoard);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.ParagonGlyph, other.ParagonGlyph);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.skillExtraArsenals_.Equals(other.skillExtraArsenals_);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.classPassiveSkill_.Equals(other.classPassiveSkill_);
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

		// Token: 0x060029BA RID: 10682 RVA: 0x000A3170 File Offset: 0x000A1370
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activeSkills_.GetHashCode();
			bool hasSkillVersion = this.HasSkillVersion;
			if (hasSkillVersion)
			{
				num ^= this.SkillVersion.GetHashCode();
			}
			bool hasSkillKitVersion = this.HasSkillKitVersion;
			if (hasSkillKitVersion)
			{
				num ^= this.SkillKitVersion.GetHashCode();
			}
			num ^= this.purchasedSkillTreeNode_.GetHashCode();
			bool hasLastPurchasedSkillTreeNode = this.HasLastPurchasedSkillTreeNode;
			if (hasLastPurchasedSkillTreeNode)
			{
				num ^= this.LastPurchasedSkillTreeNode.GetHashCode();
			}
			num ^= this.enchantSkill_.GetHashCode();
			bool flag = this.paragonBoard_ != null;
			if (flag)
			{
				num ^= this.ParagonBoard.GetHashCode();
			}
			bool flag2 = this.paragonGlyph_ != null;
			if (flag2)
			{
				num ^= this.ParagonGlyph.GetHashCode();
			}
			num ^= this.skillExtraArsenals_.GetHashCode();
			num ^= this.classPassiveSkill_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000A327C File Offset: 0x000A147C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000A3294 File Offset: 0x000A1494
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000A32A0 File Offset: 0x000A14A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activeSkills_.WriteTo(ref output, Skills._repeated_activeSkills_codec);
			bool hasSkillVersion = this.HasSkillVersion;
			if (hasSkillVersion)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SkillVersion);
			}
			bool hasSkillKitVersion = this.HasSkillKitVersion;
			if (hasSkillKitVersion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SkillKitVersion);
			}
			this.purchasedSkillTreeNode_.WriteTo(ref output, Skills._repeated_purchasedSkillTreeNode_codec);
			bool hasLastPurchasedSkillTreeNode = this.HasLastPurchasedSkillTreeNode;
			if (hasLastPurchasedSkillTreeNode)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LastPurchasedSkillTreeNode);
			}
			this.enchantSkill_.WriteTo(ref output, Skills._repeated_enchantSkill_codec);
			bool flag = this.paragonBoard_ != null;
			if (flag)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ParagonBoard);
			}
			bool flag2 = this.paragonGlyph_ != null;
			if (flag2)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ParagonGlyph);
			}
			this.skillExtraArsenals_.WriteTo(ref output, Skills._repeated_skillExtraArsenals_codec);
			this.classPassiveSkill_.WriteTo(ref output, Skills._repeated_classPassiveSkill_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000A33D8 File Offset: 0x000A15D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activeSkills_.CalculateSize(Skills._repeated_activeSkills_codec);
			bool hasSkillVersion = this.HasSkillVersion;
			if (hasSkillVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillVersion);
			}
			bool hasSkillKitVersion = this.HasSkillKitVersion;
			if (hasSkillKitVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillKitVersion);
			}
			num += this.purchasedSkillTreeNode_.CalculateSize(Skills._repeated_purchasedSkillTreeNode_codec);
			bool hasLastPurchasedSkillTreeNode = this.HasLastPurchasedSkillTreeNode;
			if (hasLastPurchasedSkillTreeNode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LastPurchasedSkillTreeNode);
			}
			num += this.enchantSkill_.CalculateSize(Skills._repeated_enchantSkill_codec);
			bool flag = this.paragonBoard_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ParagonBoard);
			}
			bool flag2 = this.paragonGlyph_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ParagonGlyph);
			}
			num += this.skillExtraArsenals_.CalculateSize(Skills._repeated_skillExtraArsenals_codec);
			num += this.classPassiveSkill_.CalculateSize(Skills._repeated_classPassiveSkill_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000A3504 File Offset: 0x000A1704
		[DebuggerNonUserCode]
		public void MergeFrom(Skills other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.activeSkills_.Add(other.activeSkills_);
				bool hasSkillVersion = other.HasSkillVersion;
				if (hasSkillVersion)
				{
					this.SkillVersion = other.SkillVersion;
				}
				bool hasSkillKitVersion = other.HasSkillKitVersion;
				if (hasSkillKitVersion)
				{
					this.SkillKitVersion = other.SkillKitVersion;
				}
				this.purchasedSkillTreeNode_.Add(other.purchasedSkillTreeNode_);
				bool hasLastPurchasedSkillTreeNode = other.HasLastPurchasedSkillTreeNode;
				if (hasLastPurchasedSkillTreeNode)
				{
					this.LastPurchasedSkillTreeNode = other.LastPurchasedSkillTreeNode;
				}
				this.enchantSkill_.Add(other.enchantSkill_);
				bool flag2 = other.paragonBoard_ != null;
				if (flag2)
				{
					bool flag3 = this.paragonBoard_ == null;
					if (flag3)
					{
						this.ParagonBoard = new ParagonBoardSavedData();
					}
					this.ParagonBoard.MergeFrom(other.ParagonBoard);
				}
				bool flag4 = other.paragonGlyph_ != null;
				if (flag4)
				{
					bool flag5 = this.paragonGlyph_ == null;
					if (flag5)
					{
						this.ParagonGlyph = new ParagonGlyphSavedData();
					}
					this.ParagonGlyph.MergeFrom(other.ParagonGlyph);
				}
				this.skillExtraArsenals_.Add(other.skillExtraArsenals_);
				this.classPassiveSkill_.Add(other.classPassiveSkill_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000A365C File Offset: 0x000A185C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000A3668 File Offset: 0x000A1868
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 56U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								goto IL_007B;
							}
							this.SkillVersion = input.ReadUInt32();
						}
						else
						{
							this.activeSkills_.AddEntriesFrom(ref input, Skills._repeated_activeSkills_codec);
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 50U)
						{
							if (num3 != 56U)
							{
								goto IL_007B;
							}
							this.LastPurchasedSkillTreeNode = input.ReadUInt32();
						}
						else
						{
							this.purchasedSkillTreeNode_.AddEntriesFrom(ref input, Skills._repeated_purchasedSkillTreeNode_codec);
						}
					}
					else
					{
						this.SkillKitVersion = input.ReadUInt32();
					}
				}
				else if (num3 <= 82U)
				{
					if (num3 != 66U)
					{
						if (num3 != 82U)
						{
							goto IL_007B;
						}
						bool flag = this.paragonBoard_ == null;
						if (flag)
						{
							this.ParagonBoard = new ParagonBoardSavedData();
						}
						input.ReadMessage(this.ParagonBoard);
					}
					else
					{
						this.enchantSkill_.AddEntriesFrom(ref input, Skills._repeated_enchantSkill_codec);
					}
				}
				else if (num3 != 90U)
				{
					if (num3 != 106U)
					{
						if (num3 != 114U)
						{
							goto IL_007B;
						}
						this.classPassiveSkill_.AddEntriesFrom(ref input, Skills._repeated_classPassiveSkill_codec);
					}
					else
					{
						this.skillExtraArsenals_.AddEntriesFrom(ref input, Skills._repeated_skillExtraArsenals_codec);
					}
				}
				else
				{
					bool flag2 = this.paragonGlyph_ == null;
					if (flag2)
					{
						this.ParagonGlyph = new ParagonGlyphSavedData();
					}
					input.ReadMessage(this.ParagonGlyph);
				}
				continue;
				IL_007B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040012A0 RID: 4768
		private static readonly MessageParser<Skills> _parser = new MessageParser<Skills>(() => new Skills());

		// Token: 0x040012A1 RID: 4769
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012A2 RID: 4770
		private int _hasBits0;

		// Token: 0x040012A3 RID: 4771
		public const int ActiveSkillsFieldNumber = 1;

		// Token: 0x040012A4 RID: 4772
		private static readonly FieldCodec<Skill> _repeated_activeSkills_codec = FieldCodec.ForMessage<Skill>(10U, Skill.Parser);

		// Token: 0x040012A5 RID: 4773
		private readonly RepeatedField<Skill> activeSkills_ = new RepeatedField<Skill>();

		// Token: 0x040012A6 RID: 4774
		public const int SkillVersionFieldNumber = 2;

		// Token: 0x040012A7 RID: 4775
		private static readonly uint SkillVersionDefaultValue = 0U;

		// Token: 0x040012A8 RID: 4776
		private uint skillVersion_;

		// Token: 0x040012A9 RID: 4777
		public const int SkillKitVersionFieldNumber = 3;

		// Token: 0x040012AA RID: 4778
		private static readonly uint SkillKitVersionDefaultValue = 0U;

		// Token: 0x040012AB RID: 4779
		private uint skillKitVersion_;

		// Token: 0x040012AC RID: 4780
		public const int PurchasedSkillTreeNodeFieldNumber = 6;

		// Token: 0x040012AD RID: 4781
		private static readonly FieldCodec<SavedSkillTreeNode> _repeated_purchasedSkillTreeNode_codec = FieldCodec.ForMessage<SavedSkillTreeNode>(50U, SavedSkillTreeNode.Parser);

		// Token: 0x040012AE RID: 4782
		private readonly RepeatedField<SavedSkillTreeNode> purchasedSkillTreeNode_ = new RepeatedField<SavedSkillTreeNode>();

		// Token: 0x040012AF RID: 4783
		public const int LastPurchasedSkillTreeNodeFieldNumber = 7;

		// Token: 0x040012B0 RID: 4784
		private static readonly uint LastPurchasedSkillTreeNodeDefaultValue = uint.MaxValue;

		// Token: 0x040012B1 RID: 4785
		private uint lastPurchasedSkillTreeNode_;

		// Token: 0x040012B2 RID: 4786
		public const int EnchantSkillFieldNumber = 8;

		// Token: 0x040012B3 RID: 4787
		private static readonly FieldCodec<Skill> _repeated_enchantSkill_codec = FieldCodec.ForMessage<Skill>(66U, Skill.Parser);

		// Token: 0x040012B4 RID: 4788
		private readonly RepeatedField<Skill> enchantSkill_ = new RepeatedField<Skill>();

		// Token: 0x040012B5 RID: 4789
		public const int ParagonBoardFieldNumber = 10;

		// Token: 0x040012B6 RID: 4790
		private ParagonBoardSavedData paragonBoard_;

		// Token: 0x040012B7 RID: 4791
		public const int ParagonGlyphFieldNumber = 11;

		// Token: 0x040012B8 RID: 4792
		private ParagonGlyphSavedData paragonGlyph_;

		// Token: 0x040012B9 RID: 4793
		public const int SkillExtraArsenalsFieldNumber = 13;

		// Token: 0x040012BA RID: 4794
		private static readonly FieldCodec<SavedSkillExtraAndArsenal> _repeated_skillExtraArsenals_codec = FieldCodec.ForMessage<SavedSkillExtraAndArsenal>(106U, SavedSkillExtraAndArsenal.Parser);

		// Token: 0x040012BB RID: 4795
		private readonly RepeatedField<SavedSkillExtraAndArsenal> skillExtraArsenals_ = new RepeatedField<SavedSkillExtraAndArsenal>();

		// Token: 0x040012BC RID: 4796
		public const int ClassPassiveSkillFieldNumber = 14;

		// Token: 0x040012BD RID: 4797
		private static readonly FieldCodec<Skill> _repeated_classPassiveSkill_codec = FieldCodec.ForMessage<Skill>(114U, Skill.Parser);

		// Token: 0x040012BE RID: 4798
		private readonly RepeatedField<Skill> classPassiveSkill_ = new RepeatedField<Skill>();
	}
}
