using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000335 RID: 821
	public sealed class AccessibilitySettings : IMessage<AccessibilitySettings>, IMessage, IEquatable<AccessibilitySettings>, IDeepCloneable<AccessibilitySettings>, IBufferMessage
	{
		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x0600557F RID: 21887 RVA: 0x0014A53C File Offset: 0x0014873C
		[DebuggerNonUserCode]
		public static MessageParser<AccessibilitySettings> Parser
		{
			get
			{
				return AccessibilitySettings._parser;
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06005580 RID: 21888 RVA: 0x0014A554 File Offset: 0x00148754
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameAccessibilityReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06005581 RID: 21889 RVA: 0x0014A578 File Offset: 0x00148778
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessibilitySettings.Descriptor;
			}
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x0014A58F File Offset: 0x0014878F
		[DebuggerNonUserCode]
		public AccessibilitySettings()
		{
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x0014A59C File Offset: 0x0014879C
		[DebuggerNonUserCode]
		public AccessibilitySettings(AccessibilitySettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.lowVisionModeEnabled_ = other.lowVisionModeEnabled_;
			this.colorBlindMode_ = other.colorBlindMode_;
			this.subtitlesEnabled_ = other.subtitlesEnabled_;
			this.npcGreetingsSubtitlesEnabled_ = other.npcGreetingsSubtitlesEnabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x0014A600 File Offset: 0x00148800
		[DebuggerNonUserCode]
		public AccessibilitySettings Clone()
		{
			return new AccessibilitySettings(this);
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06005585 RID: 21893 RVA: 0x0014A618 File Offset: 0x00148818
		// (set) Token: 0x06005586 RID: 21894 RVA: 0x0014A649 File Offset: 0x00148849
		[DebuggerNonUserCode]
		public bool LowVisionModeEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool lowVisionModeEnabledDefaultValue;
				if (flag)
				{
					lowVisionModeEnabledDefaultValue = this.lowVisionModeEnabled_;
				}
				else
				{
					lowVisionModeEnabledDefaultValue = AccessibilitySettings.LowVisionModeEnabledDefaultValue;
				}
				return lowVisionModeEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.lowVisionModeEnabled_ = value;
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x0014A664 File Offset: 0x00148864
		[DebuggerNonUserCode]
		public bool HasLowVisionModeEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x0014A681 File Offset: 0x00148881
		[DebuggerNonUserCode]
		public void ClearLowVisionModeEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06005589 RID: 21897 RVA: 0x0014A694 File Offset: 0x00148894
		// (set) Token: 0x0600558A RID: 21898 RVA: 0x0014A6C5 File Offset: 0x001488C5
		[DebuggerNonUserCode]
		public uint ColorBlindMode
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint colorBlindModeDefaultValue;
				if (flag)
				{
					colorBlindModeDefaultValue = this.colorBlindMode_;
				}
				else
				{
					colorBlindModeDefaultValue = AccessibilitySettings.ColorBlindModeDefaultValue;
				}
				return colorBlindModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.colorBlindMode_ = value;
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x0600558B RID: 21899 RVA: 0x0014A6E0 File Offset: 0x001488E0
		[DebuggerNonUserCode]
		public bool HasColorBlindMode
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x0014A6FD File Offset: 0x001488FD
		[DebuggerNonUserCode]
		public void ClearColorBlindMode()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x0014A710 File Offset: 0x00148910
		// (set) Token: 0x0600558E RID: 21902 RVA: 0x0014A741 File Offset: 0x00148941
		[DebuggerNonUserCode]
		public bool SubtitlesEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool subtitlesEnabledDefaultValue;
				if (flag)
				{
					subtitlesEnabledDefaultValue = this.subtitlesEnabled_;
				}
				else
				{
					subtitlesEnabledDefaultValue = AccessibilitySettings.SubtitlesEnabledDefaultValue;
				}
				return subtitlesEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.subtitlesEnabled_ = value;
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x0600558F RID: 21903 RVA: 0x0014A75C File Offset: 0x0014895C
		[DebuggerNonUserCode]
		public bool HasSubtitlesEnabled
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x0014A779 File Offset: 0x00148979
		[DebuggerNonUserCode]
		public void ClearSubtitlesEnabled()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x0014A78C File Offset: 0x0014898C
		// (set) Token: 0x06005592 RID: 21906 RVA: 0x0014A7BD File Offset: 0x001489BD
		[DebuggerNonUserCode]
		public bool NpcGreetingsSubtitlesEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool npcGreetingsSubtitlesEnabledDefaultValue;
				if (flag)
				{
					npcGreetingsSubtitlesEnabledDefaultValue = this.npcGreetingsSubtitlesEnabled_;
				}
				else
				{
					npcGreetingsSubtitlesEnabledDefaultValue = AccessibilitySettings.NpcGreetingsSubtitlesEnabledDefaultValue;
				}
				return npcGreetingsSubtitlesEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.npcGreetingsSubtitlesEnabled_ = value;
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x0014A7D8 File Offset: 0x001489D8
		[DebuggerNonUserCode]
		public bool HasNpcGreetingsSubtitlesEnabled
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x0014A7F5 File Offset: 0x001489F5
		[DebuggerNonUserCode]
		public void ClearNpcGreetingsSubtitlesEnabled()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x0014A808 File Offset: 0x00148A08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessibilitySettings);
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x0014A828 File Offset: 0x00148A28
		[DebuggerNonUserCode]
		public bool Equals(AccessibilitySettings other)
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
					bool flag4 = this.LowVisionModeEnabled != other.LowVisionModeEnabled;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ColorBlindMode != other.ColorBlindMode;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SubtitlesEnabled != other.SubtitlesEnabled;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.NpcGreetingsSubtitlesEnabled != other.NpcGreetingsSubtitlesEnabled;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x0014A8D4 File Offset: 0x00148AD4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLowVisionModeEnabled = this.HasLowVisionModeEnabled;
			if (hasLowVisionModeEnabled)
			{
				num ^= this.LowVisionModeEnabled.GetHashCode();
			}
			bool hasColorBlindMode = this.HasColorBlindMode;
			if (hasColorBlindMode)
			{
				num ^= this.ColorBlindMode.GetHashCode();
			}
			bool hasSubtitlesEnabled = this.HasSubtitlesEnabled;
			if (hasSubtitlesEnabled)
			{
				num ^= this.SubtitlesEnabled.GetHashCode();
			}
			bool hasNpcGreetingsSubtitlesEnabled = this.HasNpcGreetingsSubtitlesEnabled;
			if (hasNpcGreetingsSubtitlesEnabled)
			{
				num ^= this.NpcGreetingsSubtitlesEnabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x0014A97C File Offset: 0x00148B7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x0014A994 File Offset: 0x00148B94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x0014A9A0 File Offset: 0x00148BA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLowVisionModeEnabled = this.HasLowVisionModeEnabled;
			if (hasLowVisionModeEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.LowVisionModeEnabled);
			}
			bool hasColorBlindMode = this.HasColorBlindMode;
			if (hasColorBlindMode)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ColorBlindMode);
			}
			bool hasSubtitlesEnabled = this.HasSubtitlesEnabled;
			if (hasSubtitlesEnabled)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.SubtitlesEnabled);
			}
			bool hasNpcGreetingsSubtitlesEnabled = this.HasNpcGreetingsSubtitlesEnabled;
			if (hasNpcGreetingsSubtitlesEnabled)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.NpcGreetingsSubtitlesEnabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x0014AA54 File Offset: 0x00148C54
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLowVisionModeEnabled = this.HasLowVisionModeEnabled;
			if (hasLowVisionModeEnabled)
			{
				num += 2;
			}
			bool hasColorBlindMode = this.HasColorBlindMode;
			if (hasColorBlindMode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ColorBlindMode);
			}
			bool hasSubtitlesEnabled = this.HasSubtitlesEnabled;
			if (hasSubtitlesEnabled)
			{
				num += 2;
			}
			bool hasNpcGreetingsSubtitlesEnabled = this.HasNpcGreetingsSubtitlesEnabled;
			if (hasNpcGreetingsSubtitlesEnabled)
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

		// Token: 0x0600559C RID: 21916 RVA: 0x0014AAD8 File Offset: 0x00148CD8
		[DebuggerNonUserCode]
		public void MergeFrom(AccessibilitySettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLowVisionModeEnabled = other.HasLowVisionModeEnabled;
				if (hasLowVisionModeEnabled)
				{
					this.LowVisionModeEnabled = other.LowVisionModeEnabled;
				}
				bool hasColorBlindMode = other.HasColorBlindMode;
				if (hasColorBlindMode)
				{
					this.ColorBlindMode = other.ColorBlindMode;
				}
				bool hasSubtitlesEnabled = other.HasSubtitlesEnabled;
				if (hasSubtitlesEnabled)
				{
					this.SubtitlesEnabled = other.SubtitlesEnabled;
				}
				bool hasNpcGreetingsSubtitlesEnabled = other.HasNpcGreetingsSubtitlesEnabled;
				if (hasNpcGreetingsSubtitlesEnabled)
				{
					this.NpcGreetingsSubtitlesEnabled = other.NpcGreetingsSubtitlesEnabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x0014AB6E File Offset: 0x00148D6E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x0014AB7C File Offset: 0x00148D7C
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
						this.ColorBlindMode = input.ReadUInt32();
					}
					else
					{
						this.LowVisionModeEnabled = input.ReadBool();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.NpcGreetingsSubtitlesEnabled = input.ReadBool();
				}
				else
				{
					this.SubtitlesEnabled = input.ReadBool();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026DC RID: 9948
		private static readonly MessageParser<AccessibilitySettings> _parser = new MessageParser<AccessibilitySettings>(() => new AccessibilitySettings());

		// Token: 0x040026DD RID: 9949
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026DE RID: 9950
		private int _hasBits0;

		// Token: 0x040026DF RID: 9951
		public const int LowVisionModeEnabledFieldNumber = 1;

		// Token: 0x040026E0 RID: 9952
		private static readonly bool LowVisionModeEnabledDefaultValue = false;

		// Token: 0x040026E1 RID: 9953
		private bool lowVisionModeEnabled_;

		// Token: 0x040026E2 RID: 9954
		public const int ColorBlindModeFieldNumber = 2;

		// Token: 0x040026E3 RID: 9955
		private static readonly uint ColorBlindModeDefaultValue = 0U;

		// Token: 0x040026E4 RID: 9956
		private uint colorBlindMode_;

		// Token: 0x040026E5 RID: 9957
		public const int SubtitlesEnabledFieldNumber = 3;

		// Token: 0x040026E6 RID: 9958
		private static readonly bool SubtitlesEnabledDefaultValue = false;

		// Token: 0x040026E7 RID: 9959
		private bool subtitlesEnabled_;

		// Token: 0x040026E8 RID: 9960
		public const int NpcGreetingsSubtitlesEnabledFieldNumber = 4;

		// Token: 0x040026E9 RID: 9961
		private static readonly bool NpcGreetingsSubtitlesEnabledDefaultValue = false;

		// Token: 0x040026EA RID: 9962
		private bool npcGreetingsSubtitlesEnabled_;
	}
}
