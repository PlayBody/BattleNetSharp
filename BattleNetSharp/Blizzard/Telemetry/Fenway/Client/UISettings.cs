using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000343 RID: 835
	public sealed class UISettings : IMessage<UISettings>, IMessage, IEquatable<UISettings>, IDeepCloneable<UISettings>, IBufferMessage
	{
		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x00151240 File Offset: 0x0014F440
		[DebuggerNonUserCode]
		public static MessageParser<UISettings> Parser
		{
			get
			{
				return UISettings._parser;
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06005711 RID: 22289 RVA: 0x00151258 File Offset: 0x0014F458
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameUiReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x0015127C File Offset: 0x0014F47C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UISettings.Descriptor;
			}
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00151293 File Offset: 0x0014F493
		[DebuggerNonUserCode]
		public UISettings()
		{
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x001512A0 File Offset: 0x0014F4A0
		[DebuggerNonUserCode]
		public UISettings(UISettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.skillAmmoFeedbackEnabled_ = other.skillAmmoFeedbackEnabled_;
			this.controllerCursorSensitivity_ = other.controllerCursorSensitivity_;
			this.secondaryWeaponsUniqueBindingsEnabled_ = other.secondaryWeaponsUniqueBindingsEnabled_;
			this.chatFontSize_ = other.chatFontSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00151304 File Offset: 0x0014F504
		[DebuggerNonUserCode]
		public UISettings Clone()
		{
			return new UISettings(this);
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x0015131C File Offset: 0x0014F51C
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x0015134D File Offset: 0x0014F54D
		[DebuggerNonUserCode]
		public bool SkillAmmoFeedbackEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool skillAmmoFeedbackEnabledDefaultValue;
				if (flag)
				{
					skillAmmoFeedbackEnabledDefaultValue = this.skillAmmoFeedbackEnabled_;
				}
				else
				{
					skillAmmoFeedbackEnabledDefaultValue = UISettings.SkillAmmoFeedbackEnabledDefaultValue;
				}
				return skillAmmoFeedbackEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.skillAmmoFeedbackEnabled_ = value;
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x00151368 File Offset: 0x0014F568
		[DebuggerNonUserCode]
		public bool HasSkillAmmoFeedbackEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00151385 File Offset: 0x0014F585
		[DebuggerNonUserCode]
		public void ClearSkillAmmoFeedbackEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x0600571A RID: 22298 RVA: 0x00151398 File Offset: 0x0014F598
		// (set) Token: 0x0600571B RID: 22299 RVA: 0x001513C9 File Offset: 0x0014F5C9
		[DebuggerNonUserCode]
		public int ControllerCursorSensitivity
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int controllerCursorSensitivityDefaultValue;
				if (flag)
				{
					controllerCursorSensitivityDefaultValue = this.controllerCursorSensitivity_;
				}
				else
				{
					controllerCursorSensitivityDefaultValue = UISettings.ControllerCursorSensitivityDefaultValue;
				}
				return controllerCursorSensitivityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.controllerCursorSensitivity_ = value;
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x0600571C RID: 22300 RVA: 0x001513E4 File Offset: 0x0014F5E4
		[DebuggerNonUserCode]
		public bool HasControllerCursorSensitivity
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x00151401 File Offset: 0x0014F601
		[DebuggerNonUserCode]
		public void ClearControllerCursorSensitivity()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x00151414 File Offset: 0x0014F614
		// (set) Token: 0x0600571F RID: 22303 RVA: 0x00151445 File Offset: 0x0014F645
		[DebuggerNonUserCode]
		public bool SecondaryWeaponsUniqueBindingsEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool secondaryWeaponsUniqueBindingsEnabledDefaultValue;
				if (flag)
				{
					secondaryWeaponsUniqueBindingsEnabledDefaultValue = this.secondaryWeaponsUniqueBindingsEnabled_;
				}
				else
				{
					secondaryWeaponsUniqueBindingsEnabledDefaultValue = UISettings.SecondaryWeaponsUniqueBindingsEnabledDefaultValue;
				}
				return secondaryWeaponsUniqueBindingsEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.secondaryWeaponsUniqueBindingsEnabled_ = value;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x00151460 File Offset: 0x0014F660
		[DebuggerNonUserCode]
		public bool HasSecondaryWeaponsUniqueBindingsEnabled
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x0015147D File Offset: 0x0014F67D
		[DebuggerNonUserCode]
		public void ClearSecondaryWeaponsUniqueBindingsEnabled()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06005722 RID: 22306 RVA: 0x00151490 File Offset: 0x0014F690
		// (set) Token: 0x06005723 RID: 22307 RVA: 0x001514C1 File Offset: 0x0014F6C1
		[DebuggerNonUserCode]
		public uint ChatFontSize
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint chatFontSizeDefaultValue;
				if (flag)
				{
					chatFontSizeDefaultValue = this.chatFontSize_;
				}
				else
				{
					chatFontSizeDefaultValue = UISettings.ChatFontSizeDefaultValue;
				}
				return chatFontSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.chatFontSize_ = value;
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06005724 RID: 22308 RVA: 0x001514DC File Offset: 0x0014F6DC
		[DebuggerNonUserCode]
		public bool HasChatFontSize
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x001514F9 File Offset: 0x0014F6F9
		[DebuggerNonUserCode]
		public void ClearChatFontSize()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x0015150C File Offset: 0x0014F70C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UISettings);
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x0015152C File Offset: 0x0014F72C
		[DebuggerNonUserCode]
		public bool Equals(UISettings other)
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
					bool flag4 = this.SkillAmmoFeedbackEnabled != other.SkillAmmoFeedbackEnabled;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ControllerCursorSensitivity != other.ControllerCursorSensitivity;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SecondaryWeaponsUniqueBindingsEnabled != other.SecondaryWeaponsUniqueBindingsEnabled;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ChatFontSize != other.ChatFontSize;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x001515D8 File Offset: 0x0014F7D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSkillAmmoFeedbackEnabled = this.HasSkillAmmoFeedbackEnabled;
			if (hasSkillAmmoFeedbackEnabled)
			{
				num ^= this.SkillAmmoFeedbackEnabled.GetHashCode();
			}
			bool hasControllerCursorSensitivity = this.HasControllerCursorSensitivity;
			if (hasControllerCursorSensitivity)
			{
				num ^= this.ControllerCursorSensitivity.GetHashCode();
			}
			bool hasSecondaryWeaponsUniqueBindingsEnabled = this.HasSecondaryWeaponsUniqueBindingsEnabled;
			if (hasSecondaryWeaponsUniqueBindingsEnabled)
			{
				num ^= this.SecondaryWeaponsUniqueBindingsEnabled.GetHashCode();
			}
			bool hasChatFontSize = this.HasChatFontSize;
			if (hasChatFontSize)
			{
				num ^= this.ChatFontSize.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00151680 File Offset: 0x0014F880
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00151698 File Offset: 0x0014F898
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x001516A4 File Offset: 0x0014F8A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSkillAmmoFeedbackEnabled = this.HasSkillAmmoFeedbackEnabled;
			if (hasSkillAmmoFeedbackEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.SkillAmmoFeedbackEnabled);
			}
			bool hasControllerCursorSensitivity = this.HasControllerCursorSensitivity;
			if (hasControllerCursorSensitivity)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ControllerCursorSensitivity);
			}
			bool hasSecondaryWeaponsUniqueBindingsEnabled = this.HasSecondaryWeaponsUniqueBindingsEnabled;
			if (hasSecondaryWeaponsUniqueBindingsEnabled)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.SecondaryWeaponsUniqueBindingsEnabled);
			}
			bool hasChatFontSize = this.HasChatFontSize;
			if (hasChatFontSize)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ChatFontSize);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00151758 File Offset: 0x0014F958
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSkillAmmoFeedbackEnabled = this.HasSkillAmmoFeedbackEnabled;
			if (hasSkillAmmoFeedbackEnabled)
			{
				num += 2;
			}
			bool hasControllerCursorSensitivity = this.HasControllerCursorSensitivity;
			if (hasControllerCursorSensitivity)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ControllerCursorSensitivity);
			}
			bool hasSecondaryWeaponsUniqueBindingsEnabled = this.HasSecondaryWeaponsUniqueBindingsEnabled;
			if (hasSecondaryWeaponsUniqueBindingsEnabled)
			{
				num += 2;
			}
			bool hasChatFontSize = this.HasChatFontSize;
			if (hasChatFontSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChatFontSize);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x001517E8 File Offset: 0x0014F9E8
		[DebuggerNonUserCode]
		public void MergeFrom(UISettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSkillAmmoFeedbackEnabled = other.HasSkillAmmoFeedbackEnabled;
				if (hasSkillAmmoFeedbackEnabled)
				{
					this.SkillAmmoFeedbackEnabled = other.SkillAmmoFeedbackEnabled;
				}
				bool hasControllerCursorSensitivity = other.HasControllerCursorSensitivity;
				if (hasControllerCursorSensitivity)
				{
					this.ControllerCursorSensitivity = other.ControllerCursorSensitivity;
				}
				bool hasSecondaryWeaponsUniqueBindingsEnabled = other.HasSecondaryWeaponsUniqueBindingsEnabled;
				if (hasSecondaryWeaponsUniqueBindingsEnabled)
				{
					this.SecondaryWeaponsUniqueBindingsEnabled = other.SecondaryWeaponsUniqueBindingsEnabled;
				}
				bool hasChatFontSize = other.HasChatFontSize;
				if (hasChatFontSize)
				{
					this.ChatFontSize = other.ChatFontSize;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x0015187E File Offset: 0x0014FA7E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x0015188C File Offset: 0x0014FA8C
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
						this.ControllerCursorSensitivity = input.ReadInt32();
					}
					else
					{
						this.SkillAmmoFeedbackEnabled = input.ReadBool();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 40U)
					{
						goto IL_0028;
					}
					this.ChatFontSize = input.ReadUInt32();
				}
				else
				{
					this.SecondaryWeaponsUniqueBindingsEnabled = input.ReadBool();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027C0 RID: 10176
		private static readonly MessageParser<UISettings> _parser = new MessageParser<UISettings>(() => new UISettings());

		// Token: 0x040027C1 RID: 10177
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027C2 RID: 10178
		private int _hasBits0;

		// Token: 0x040027C3 RID: 10179
		public const int SkillAmmoFeedbackEnabledFieldNumber = 1;

		// Token: 0x040027C4 RID: 10180
		private static readonly bool SkillAmmoFeedbackEnabledDefaultValue = false;

		// Token: 0x040027C5 RID: 10181
		private bool skillAmmoFeedbackEnabled_;

		// Token: 0x040027C6 RID: 10182
		public const int ControllerCursorSensitivityFieldNumber = 2;

		// Token: 0x040027C7 RID: 10183
		private static readonly int ControllerCursorSensitivityDefaultValue = 0;

		// Token: 0x040027C8 RID: 10184
		private int controllerCursorSensitivity_;

		// Token: 0x040027C9 RID: 10185
		public const int SecondaryWeaponsUniqueBindingsEnabledFieldNumber = 3;

		// Token: 0x040027CA RID: 10186
		private static readonly bool SecondaryWeaponsUniqueBindingsEnabledDefaultValue = false;

		// Token: 0x040027CB RID: 10187
		private bool secondaryWeaponsUniqueBindingsEnabled_;

		// Token: 0x040027CC RID: 10188
		public const int ChatFontSizeFieldNumber = 5;

		// Token: 0x040027CD RID: 10189
		private static readonly uint ChatFontSizeDefaultValue = 0U;

		// Token: 0x040027CE RID: 10190
		private uint chatFontSize_;
	}
}
