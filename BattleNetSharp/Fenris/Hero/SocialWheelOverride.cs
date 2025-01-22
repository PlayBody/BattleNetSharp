using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001AD RID: 429
	public sealed class SocialWheelOverride : IMessage<SocialWheelOverride>, IMessage, IEquatable<SocialWheelOverride>, IDeepCloneable<SocialWheelOverride>, IBufferMessage
	{
		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000B1310 File Offset: 0x000AF510
		[DebuggerNonUserCode]
		public static MessageParser<SocialWheelOverride> Parser
		{
			get
			{
				return SocialWheelOverride._parser;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x000B1328 File Offset: 0x000AF528
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000B134C File Offset: 0x000AF54C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SocialWheelOverride.Descriptor;
			}
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x000B1363 File Offset: 0x000AF563
		[DebuggerNonUserCode]
		public SocialWheelOverride()
		{
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x000B1374 File Offset: 0x000AF574
		[DebuggerNonUserCode]
		public SocialWheelOverride(SocialWheelOverride other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.wheelId_ = other.wheelId_;
			this.slotId_ = other.slotId_;
			switch (other.ActionCase)
			{
			case SocialWheelOverride.ActionOneofCase.QuickActionId:
				this.QuickActionId = other.QuickActionId;
				break;
			case SocialWheelOverride.ActionOneofCase.SnoEmote:
				this.SnoEmote = other.SnoEmote;
				break;
			case SocialWheelOverride.ActionOneofCase.SnoConsumable:
				this.SnoConsumable = other.SnoConsumable;
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x000B140C File Offset: 0x000AF60C
		[DebuggerNonUserCode]
		public SocialWheelOverride Clone()
		{
			return new SocialWheelOverride(this);
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x000B1424 File Offset: 0x000AF624
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x000B1455 File Offset: 0x000AF655
		[DebuggerNonUserCode]
		public uint WheelId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint wheelIdDefaultValue;
				if (flag)
				{
					wheelIdDefaultValue = this.wheelId_;
				}
				else
				{
					wheelIdDefaultValue = SocialWheelOverride.WheelIdDefaultValue;
				}
				return wheelIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.wheelId_ = value;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000B1470 File Offset: 0x000AF670
		[DebuggerNonUserCode]
		public bool HasWheelId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000B148D File Offset: 0x000AF68D
		[DebuggerNonUserCode]
		public void ClearWheelId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000B14A0 File Offset: 0x000AF6A0
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x000B14D1 File Offset: 0x000AF6D1
		[DebuggerNonUserCode]
		public uint SlotId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint slotIdDefaultValue;
				if (flag)
				{
					slotIdDefaultValue = this.slotId_;
				}
				else
				{
					slotIdDefaultValue = SocialWheelOverride.SlotIdDefaultValue;
				}
				return slotIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.slotId_ = value;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000B14EC File Offset: 0x000AF6EC
		[DebuggerNonUserCode]
		public bool HasSlotId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x000B1509 File Offset: 0x000AF709
		[DebuggerNonUserCode]
		public void ClearSlotId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x000B151C File Offset: 0x000AF71C
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x000B1544 File Offset: 0x000AF744
		[DebuggerNonUserCode]
		public uint QuickActionId
		{
			get
			{
				return this.HasQuickActionId ? ((uint)this.action_) : 0U;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = SocialWheelOverride.ActionOneofCase.QuickActionId;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000B155C File Offset: 0x000AF75C
		[DebuggerNonUserCode]
		public bool HasQuickActionId
		{
			get
			{
				return this.actionCase_ == SocialWheelOverride.ActionOneofCase.QuickActionId;
			}
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000B1578 File Offset: 0x000AF778
		[DebuggerNonUserCode]
		public void ClearQuickActionId()
		{
			bool hasQuickActionId = this.HasQuickActionId;
			if (hasQuickActionId)
			{
				this.ClearAction();
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000B159C File Offset: 0x000AF79C
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x000B15C4 File Offset: 0x000AF7C4
		[DebuggerNonUserCode]
		public uint SnoEmote
		{
			get
			{
				return this.HasSnoEmote ? ((uint)this.action_) : 0U;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = SocialWheelOverride.ActionOneofCase.SnoEmote;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000B15DC File Offset: 0x000AF7DC
		[DebuggerNonUserCode]
		public bool HasSnoEmote
		{
			get
			{
				return this.actionCase_ == SocialWheelOverride.ActionOneofCase.SnoEmote;
			}
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000B15F8 File Offset: 0x000AF7F8
		[DebuggerNonUserCode]
		public void ClearSnoEmote()
		{
			bool hasSnoEmote = this.HasSnoEmote;
			if (hasSnoEmote)
			{
				this.ClearAction();
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000B161C File Offset: 0x000AF81C
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x000B1644 File Offset: 0x000AF844
		[DebuggerNonUserCode]
		public uint SnoConsumable
		{
			get
			{
				return this.HasSnoConsumable ? ((uint)this.action_) : 0U;
			}
			set
			{
				this.action_ = value;
				this.actionCase_ = SocialWheelOverride.ActionOneofCase.SnoConsumable;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x000B165C File Offset: 0x000AF85C
		[DebuggerNonUserCode]
		public bool HasSnoConsumable
		{
			get
			{
				return this.actionCase_ == SocialWheelOverride.ActionOneofCase.SnoConsumable;
			}
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x000B1678 File Offset: 0x000AF878
		[DebuggerNonUserCode]
		public void ClearSnoConsumable()
		{
			bool hasSnoConsumable = this.HasSnoConsumable;
			if (hasSnoConsumable)
			{
				this.ClearAction();
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000B169C File Offset: 0x000AF89C
		[DebuggerNonUserCode]
		public SocialWheelOverride.ActionOneofCase ActionCase
		{
			get
			{
				return this.actionCase_;
			}
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x000B16B4 File Offset: 0x000AF8B4
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			this.actionCase_ = SocialWheelOverride.ActionOneofCase.None;
			this.action_ = null;
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x000B16C8 File Offset: 0x000AF8C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SocialWheelOverride);
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x000B16E8 File Offset: 0x000AF8E8
		[DebuggerNonUserCode]
		public bool Equals(SocialWheelOverride other)
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
					bool flag4 = this.WheelId != other.WheelId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SlotId != other.SlotId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.QuickActionId != other.QuickActionId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoEmote != other.SnoEmote;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.SnoConsumable != other.SnoConsumable;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ActionCase != other.ActionCase;
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

		// Token: 0x06002D54 RID: 11604 RVA: 0x000B17D4 File Offset: 0x000AF9D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasWheelId = this.HasWheelId;
			if (hasWheelId)
			{
				num ^= this.WheelId.GetHashCode();
			}
			bool hasSlotId = this.HasSlotId;
			if (hasSlotId)
			{
				num ^= this.SlotId.GetHashCode();
			}
			bool hasQuickActionId = this.HasQuickActionId;
			if (hasQuickActionId)
			{
				num ^= this.QuickActionId.GetHashCode();
			}
			bool hasSnoEmote = this.HasSnoEmote;
			if (hasSnoEmote)
			{
				num ^= this.SnoEmote.GetHashCode();
			}
			bool hasSnoConsumable = this.HasSnoConsumable;
			if (hasSnoConsumable)
			{
				num ^= this.SnoConsumable.GetHashCode();
			}
			num ^= (int)this.actionCase_;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000B18A0 File Offset: 0x000AFAA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x000B18B8 File Offset: 0x000AFAB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x000B18C4 File Offset: 0x000AFAC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasWheelId = this.HasWheelId;
			if (hasWheelId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.WheelId);
			}
			bool hasSlotId = this.HasSlotId;
			if (hasSlotId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SlotId);
			}
			bool hasQuickActionId = this.HasQuickActionId;
			if (hasQuickActionId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.QuickActionId);
			}
			bool hasSnoEmote = this.HasSnoEmote;
			if (hasSnoEmote)
			{
				output.WriteRawTag(37);
				output.WriteFixed32(this.SnoEmote);
			}
			bool hasSnoConsumable = this.HasSnoConsumable;
			if (hasSnoConsumable)
			{
				output.WriteRawTag(45);
				output.WriteFixed32(this.SnoConsumable);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x000B199C File Offset: 0x000AFB9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasWheelId = this.HasWheelId;
			if (hasWheelId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WheelId);
			}
			bool hasSlotId = this.HasSlotId;
			if (hasSlotId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SlotId);
			}
			bool hasQuickActionId = this.HasQuickActionId;
			if (hasQuickActionId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QuickActionId);
			}
			bool hasSnoEmote = this.HasSnoEmote;
			if (hasSnoEmote)
			{
				num += 5;
			}
			bool hasSnoConsumable = this.HasSnoConsumable;
			if (hasSnoConsumable)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x000B1A4C File Offset: 0x000AFC4C
		[DebuggerNonUserCode]
		public void MergeFrom(SocialWheelOverride other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasWheelId = other.HasWheelId;
				if (hasWheelId)
				{
					this.WheelId = other.WheelId;
				}
				bool hasSlotId = other.HasSlotId;
				if (hasSlotId)
				{
					this.SlotId = other.SlotId;
				}
				switch (other.ActionCase)
				{
				case SocialWheelOverride.ActionOneofCase.QuickActionId:
					this.QuickActionId = other.QuickActionId;
					break;
				case SocialWheelOverride.ActionOneofCase.SnoEmote:
					this.SnoEmote = other.SnoEmote;
					break;
				case SocialWheelOverride.ActionOneofCase.SnoConsumable:
					this.SnoConsumable = other.SnoConsumable;
					break;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x000B1AFF File Offset: 0x000AFCFF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000B1B0C File Offset: 0x000AFD0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.SlotId = input.ReadUInt32();
					}
					else
					{
						this.WheelId = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 37U)
					{
						if (num3 != 45U)
						{
							goto IL_0032;
						}
						this.SnoConsumable = input.ReadFixed32();
					}
					else
					{
						this.SnoEmote = input.ReadFixed32();
					}
				}
				else
				{
					this.QuickActionId = input.ReadUInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400146D RID: 5229
		private static readonly MessageParser<SocialWheelOverride> _parser = new MessageParser<SocialWheelOverride>(() => new SocialWheelOverride());

		// Token: 0x0400146E RID: 5230
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400146F RID: 5231
		private int _hasBits0;

		// Token: 0x04001470 RID: 5232
		public const int WheelIdFieldNumber = 1;

		// Token: 0x04001471 RID: 5233
		private static readonly uint WheelIdDefaultValue = 0U;

		// Token: 0x04001472 RID: 5234
		private uint wheelId_;

		// Token: 0x04001473 RID: 5235
		public const int SlotIdFieldNumber = 2;

		// Token: 0x04001474 RID: 5236
		private static readonly uint SlotIdDefaultValue = 0U;

		// Token: 0x04001475 RID: 5237
		private uint slotId_;

		// Token: 0x04001476 RID: 5238
		public const int QuickActionIdFieldNumber = 3;

		// Token: 0x04001477 RID: 5239
		public const int SnoEmoteFieldNumber = 4;

		// Token: 0x04001478 RID: 5240
		public const int SnoConsumableFieldNumber = 5;

		// Token: 0x04001479 RID: 5241
		private object action_;

		// Token: 0x0400147A RID: 5242
		private SocialWheelOverride.ActionOneofCase actionCase_ = SocialWheelOverride.ActionOneofCase.None;

		// Token: 0x02000CC8 RID: 3272
		public enum ActionOneofCase
		{
			// Token: 0x0400942C RID: 37932
			None,
			// Token: 0x0400942D RID: 37933
			QuickActionId = 3,
			// Token: 0x0400942E RID: 37934
			SnoEmote,
			// Token: 0x0400942F RID: 37935
			SnoConsumable
		}
	}
}
