using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200017F RID: 383
	public sealed class SavedSkillExtraAndArsenal : IMessage<SavedSkillExtraAndArsenal>, IMessage, IEquatable<SavedSkillExtraAndArsenal>, IDeepCloneable<SavedSkillExtraAndArsenal>, IBufferMessage
	{
		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x0009D2B0 File Offset: 0x0009B4B0
		[DebuggerNonUserCode]
		public static MessageParser<SavedSkillExtraAndArsenal> Parser
		{
			get
			{
				return SavedSkillExtraAndArsenal._parser;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x0009D2C8 File Offset: 0x0009B4C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x0009D2EC File Offset: 0x0009B4EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedSkillExtraAndArsenal.Descriptor;
			}
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x0009D303 File Offset: 0x0009B503
		[DebuggerNonUserCode]
		public SavedSkillExtraAndArsenal()
		{
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x0009D30D File Offset: 0x0009B50D
		[DebuggerNonUserCode]
		public SavedSkillExtraAndArsenal(SavedSkillExtraAndArsenal other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoPower_ = other.snoPower_;
			this.slot_ = other.slot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0009D34C File Offset: 0x0009B54C
		[DebuggerNonUserCode]
		public SavedSkillExtraAndArsenal Clone()
		{
			return new SavedSkillExtraAndArsenal(this);
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x0009D364 File Offset: 0x0009B564
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x0009D395 File Offset: 0x0009B595
		[DebuggerNonUserCode]
		public int SnoPower
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoPowerDefaultValue;
				if (flag)
				{
					snoPowerDefaultValue = this.snoPower_;
				}
				else
				{
					snoPowerDefaultValue = SavedSkillExtraAndArsenal.SnoPowerDefaultValue;
				}
				return snoPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoPower_ = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x0009D3B0 File Offset: 0x0009B5B0
		[DebuggerNonUserCode]
		public bool HasSnoPower
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x0009D3CD File Offset: 0x0009B5CD
		[DebuggerNonUserCode]
		public void ClearSnoPower()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x0009D3E0 File Offset: 0x0009B5E0
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x0009D411 File Offset: 0x0009B611
		[DebuggerNonUserCode]
		public int Slot
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int slotDefaultValue;
				if (flag)
				{
					slotDefaultValue = this.slot_;
				}
				else
				{
					slotDefaultValue = SavedSkillExtraAndArsenal.SlotDefaultValue;
				}
				return slotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.slot_ = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x0009D42C File Offset: 0x0009B62C
		[DebuggerNonUserCode]
		public bool HasSlot
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x0009D449 File Offset: 0x0009B649
		[DebuggerNonUserCode]
		public void ClearSlot()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0009D45C File Offset: 0x0009B65C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedSkillExtraAndArsenal);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0009D47C File Offset: 0x0009B67C
		[DebuggerNonUserCode]
		public bool Equals(SavedSkillExtraAndArsenal other)
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
					bool flag4 = this.SnoPower != other.SnoPower;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Slot != other.Slot;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0009D4F0 File Offset: 0x0009B6F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoPower = this.HasSnoPower;
			if (hasSnoPower)
			{
				num ^= this.SnoPower.GetHashCode();
			}
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				num ^= this.Slot.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0009D55C File Offset: 0x0009B75C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0009D574 File Offset: 0x0009B774
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x0009D580 File Offset: 0x0009B780
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoPower = this.HasSnoPower;
			if (hasSnoPower)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoPower);
			}
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Slot);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0009D5F0 File Offset: 0x0009B7F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoPower = this.HasSnoPower;
			if (hasSnoPower)
			{
				num += 5;
			}
			bool hasSlot = this.HasSlot;
			if (hasSlot)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Slot);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0009D650 File Offset: 0x0009B850
		[DebuggerNonUserCode]
		public void MergeFrom(SavedSkillExtraAndArsenal other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoPower = other.HasSnoPower;
				if (hasSnoPower)
				{
					this.SnoPower = other.SnoPower;
				}
				bool hasSlot = other.HasSlot;
				if (hasSlot)
				{
					this.Slot = other.Slot;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0009D6B2 File Offset: 0x0009B8B2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x0009D6C0 File Offset: 0x0009B8C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Slot = input.ReadInt32();
					}
				}
				else
				{
					this.SnoPower = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040011E3 RID: 4579
		private static readonly MessageParser<SavedSkillExtraAndArsenal> _parser = new MessageParser<SavedSkillExtraAndArsenal>(() => new SavedSkillExtraAndArsenal());

		// Token: 0x040011E4 RID: 4580
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011E5 RID: 4581
		private int _hasBits0;

		// Token: 0x040011E6 RID: 4582
		public const int SnoPowerFieldNumber = 1;

		// Token: 0x040011E7 RID: 4583
		private static readonly int SnoPowerDefaultValue = -1;

		// Token: 0x040011E8 RID: 4584
		private int snoPower_;

		// Token: 0x040011E9 RID: 4585
		public const int SlotFieldNumber = 3;

		// Token: 0x040011EA RID: 4586
		private static readonly int SlotDefaultValue = -1;

		// Token: 0x040011EB RID: 4587
		private int slot_;
	}
}
