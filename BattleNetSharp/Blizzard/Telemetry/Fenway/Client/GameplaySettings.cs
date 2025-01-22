using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200033B RID: 827
	public sealed class GameplaySettings : IMessage<GameplaySettings>, IMessage, IEquatable<GameplaySettings>, IDeepCloneable<GameplaySettings>, IBufferMessage
	{
		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06005634 RID: 22068 RVA: 0x0014D6EC File Offset: 0x0014B8EC
		[DebuggerNonUserCode]
		public static MessageParser<GameplaySettings> Parser
		{
			get
			{
				return GameplaySettings._parser;
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06005635 RID: 22069 RVA: 0x0014D704 File Offset: 0x0014B904
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameGameplayReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06005636 RID: 22070 RVA: 0x0014D728 File Offset: 0x0014B928
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplaySettings.Descriptor;
			}
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x0014D73F File Offset: 0x0014B93F
		[DebuggerNonUserCode]
		public GameplaySettings()
		{
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x0014D74C File Offset: 0x0014B94C
		[DebuggerNonUserCode]
		public GameplaySettings(GameplaySettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.autoCollectGold_ = other.autoCollectGold_;
			this.combatFeedbackText_ = other.combatFeedbackText_;
			this.selectedDefaultKeyBindings_ = other.selectedDefaultKeyBindings_;
			this.itemDropSpacing_ = other.itemDropSpacing_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x0014D7B0 File Offset: 0x0014B9B0
		[DebuggerNonUserCode]
		public GameplaySettings Clone()
		{
			return new GameplaySettings(this);
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x0014D7C8 File Offset: 0x0014B9C8
		// (set) Token: 0x0600563B RID: 22075 RVA: 0x0014D7F9 File Offset: 0x0014B9F9
		[DebuggerNonUserCode]
		public bool AutoCollectGold
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool autoCollectGoldDefaultValue;
				if (flag)
				{
					autoCollectGoldDefaultValue = this.autoCollectGold_;
				}
				else
				{
					autoCollectGoldDefaultValue = GameplaySettings.AutoCollectGoldDefaultValue;
				}
				return autoCollectGoldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.autoCollectGold_ = value;
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x0600563C RID: 22076 RVA: 0x0014D814 File Offset: 0x0014BA14
		[DebuggerNonUserCode]
		public bool HasAutoCollectGold
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x0014D831 File Offset: 0x0014BA31
		[DebuggerNonUserCode]
		public void ClearAutoCollectGold()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x0600563E RID: 22078 RVA: 0x0014D844 File Offset: 0x0014BA44
		// (set) Token: 0x0600563F RID: 22079 RVA: 0x0014D875 File Offset: 0x0014BA75
		[DebuggerNonUserCode]
		public bool CombatFeedbackText
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool combatFeedbackTextDefaultValue;
				if (flag)
				{
					combatFeedbackTextDefaultValue = this.combatFeedbackText_;
				}
				else
				{
					combatFeedbackTextDefaultValue = GameplaySettings.CombatFeedbackTextDefaultValue;
				}
				return combatFeedbackTextDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.combatFeedbackText_ = value;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06005640 RID: 22080 RVA: 0x0014D890 File Offset: 0x0014BA90
		[DebuggerNonUserCode]
		public bool HasCombatFeedbackText
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x0014D8AD File Offset: 0x0014BAAD
		[DebuggerNonUserCode]
		public void ClearCombatFeedbackText()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x0014D8C0 File Offset: 0x0014BAC0
		// (set) Token: 0x06005643 RID: 22083 RVA: 0x0014D8F1 File Offset: 0x0014BAF1
		[DebuggerNonUserCode]
		public uint SelectedDefaultKeyBindings
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint selectedDefaultKeyBindingsDefaultValue;
				if (flag)
				{
					selectedDefaultKeyBindingsDefaultValue = this.selectedDefaultKeyBindings_;
				}
				else
				{
					selectedDefaultKeyBindingsDefaultValue = GameplaySettings.SelectedDefaultKeyBindingsDefaultValue;
				}
				return selectedDefaultKeyBindingsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.selectedDefaultKeyBindings_ = value;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06005644 RID: 22084 RVA: 0x0014D90C File Offset: 0x0014BB0C
		[DebuggerNonUserCode]
		public bool HasSelectedDefaultKeyBindings
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x0014D929 File Offset: 0x0014BB29
		[DebuggerNonUserCode]
		public void ClearSelectedDefaultKeyBindings()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x0014D93C File Offset: 0x0014BB3C
		// (set) Token: 0x06005647 RID: 22087 RVA: 0x0014D96D File Offset: 0x0014BB6D
		[DebuggerNonUserCode]
		public uint ItemDropSpacing
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint itemDropSpacingDefaultValue;
				if (flag)
				{
					itemDropSpacingDefaultValue = this.itemDropSpacing_;
				}
				else
				{
					itemDropSpacingDefaultValue = GameplaySettings.ItemDropSpacingDefaultValue;
				}
				return itemDropSpacingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.itemDropSpacing_ = value;
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06005648 RID: 22088 RVA: 0x0014D988 File Offset: 0x0014BB88
		[DebuggerNonUserCode]
		public bool HasItemDropSpacing
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x0014D9A5 File Offset: 0x0014BBA5
		[DebuggerNonUserCode]
		public void ClearItemDropSpacing()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x0014D9B8 File Offset: 0x0014BBB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplaySettings);
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x0014D9D8 File Offset: 0x0014BBD8
		[DebuggerNonUserCode]
		public bool Equals(GameplaySettings other)
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
					bool flag4 = this.AutoCollectGold != other.AutoCollectGold;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CombatFeedbackText != other.CombatFeedbackText;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SelectedDefaultKeyBindings != other.SelectedDefaultKeyBindings;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ItemDropSpacing != other.ItemDropSpacing;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x0014DA84 File Offset: 0x0014BC84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAutoCollectGold = this.HasAutoCollectGold;
			if (hasAutoCollectGold)
			{
				num ^= this.AutoCollectGold.GetHashCode();
			}
			bool hasCombatFeedbackText = this.HasCombatFeedbackText;
			if (hasCombatFeedbackText)
			{
				num ^= this.CombatFeedbackText.GetHashCode();
			}
			bool hasSelectedDefaultKeyBindings = this.HasSelectedDefaultKeyBindings;
			if (hasSelectedDefaultKeyBindings)
			{
				num ^= this.SelectedDefaultKeyBindings.GetHashCode();
			}
			bool hasItemDropSpacing = this.HasItemDropSpacing;
			if (hasItemDropSpacing)
			{
				num ^= this.ItemDropSpacing.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x0014DB2C File Offset: 0x0014BD2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x0014DB44 File Offset: 0x0014BD44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x0014DB50 File Offset: 0x0014BD50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAutoCollectGold = this.HasAutoCollectGold;
			if (hasAutoCollectGold)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AutoCollectGold);
			}
			bool hasCombatFeedbackText = this.HasCombatFeedbackText;
			if (hasCombatFeedbackText)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CombatFeedbackText);
			}
			bool hasSelectedDefaultKeyBindings = this.HasSelectedDefaultKeyBindings;
			if (hasSelectedDefaultKeyBindings)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SelectedDefaultKeyBindings);
			}
			bool hasItemDropSpacing = this.HasItemDropSpacing;
			if (hasItemDropSpacing)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ItemDropSpacing);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x0014DC04 File Offset: 0x0014BE04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAutoCollectGold = this.HasAutoCollectGold;
			if (hasAutoCollectGold)
			{
				num += 2;
			}
			bool hasCombatFeedbackText = this.HasCombatFeedbackText;
			if (hasCombatFeedbackText)
			{
				num += 2;
			}
			bool hasSelectedDefaultKeyBindings = this.HasSelectedDefaultKeyBindings;
			if (hasSelectedDefaultKeyBindings)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectedDefaultKeyBindings);
			}
			bool hasItemDropSpacing = this.HasItemDropSpacing;
			if (hasItemDropSpacing)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemDropSpacing);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x0014DC94 File Offset: 0x0014BE94
		[DebuggerNonUserCode]
		public void MergeFrom(GameplaySettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAutoCollectGold = other.HasAutoCollectGold;
				if (hasAutoCollectGold)
				{
					this.AutoCollectGold = other.AutoCollectGold;
				}
				bool hasCombatFeedbackText = other.HasCombatFeedbackText;
				if (hasCombatFeedbackText)
				{
					this.CombatFeedbackText = other.CombatFeedbackText;
				}
				bool hasSelectedDefaultKeyBindings = other.HasSelectedDefaultKeyBindings;
				if (hasSelectedDefaultKeyBindings)
				{
					this.SelectedDefaultKeyBindings = other.SelectedDefaultKeyBindings;
				}
				bool hasItemDropSpacing = other.HasItemDropSpacing;
				if (hasItemDropSpacing)
				{
					this.ItemDropSpacing = other.ItemDropSpacing;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x0014DD2A File Offset: 0x0014BF2A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x0014DD38 File Offset: 0x0014BF38
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
							goto IL_0028;
						}
						this.CombatFeedbackText = input.ReadBool();
					}
					else
					{
						this.AutoCollectGold = input.ReadBool();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.ItemDropSpacing = input.ReadUInt32();
				}
				else
				{
					this.SelectedDefaultKeyBindings = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002745 RID: 10053
		private static readonly MessageParser<GameplaySettings> _parser = new MessageParser<GameplaySettings>(() => new GameplaySettings());

		// Token: 0x04002746 RID: 10054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002747 RID: 10055
		private int _hasBits0;

		// Token: 0x04002748 RID: 10056
		public const int AutoCollectGoldFieldNumber = 1;

		// Token: 0x04002749 RID: 10057
		private static readonly bool AutoCollectGoldDefaultValue = false;

		// Token: 0x0400274A RID: 10058
		private bool autoCollectGold_;

		// Token: 0x0400274B RID: 10059
		public const int CombatFeedbackTextFieldNumber = 2;

		// Token: 0x0400274C RID: 10060
		private static readonly bool CombatFeedbackTextDefaultValue = false;

		// Token: 0x0400274D RID: 10061
		private bool combatFeedbackText_;

		// Token: 0x0400274E RID: 10062
		public const int SelectedDefaultKeyBindingsFieldNumber = 3;

		// Token: 0x0400274F RID: 10063
		private static readonly uint SelectedDefaultKeyBindingsDefaultValue = 0U;

		// Token: 0x04002750 RID: 10064
		private uint selectedDefaultKeyBindings_;

		// Token: 0x04002751 RID: 10065
		public const int ItemDropSpacingFieldNumber = 4;

		// Token: 0x04002752 RID: 10066
		private static readonly uint ItemDropSpacingDefaultValue = 0U;

		// Token: 0x04002753 RID: 10067
		private uint itemDropSpacing_;
	}
}
