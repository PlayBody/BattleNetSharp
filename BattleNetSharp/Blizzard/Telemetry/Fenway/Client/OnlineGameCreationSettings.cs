using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000341 RID: 833
	public sealed class OnlineGameCreationSettings : IMessage<OnlineGameCreationSettings>, IMessage, IEquatable<OnlineGameCreationSettings>, IDeepCloneable<OnlineGameCreationSettings>, IBufferMessage
	{
		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x060056E5 RID: 22245 RVA: 0x001507F8 File Offset: 0x0014E9F8
		[DebuggerNonUserCode]
		public static MessageParser<OnlineGameCreationSettings> Parser
		{
			get
			{
				return OnlineGameCreationSettings._parser;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x060056E6 RID: 22246 RVA: 0x00150810 File Offset: 0x0014EA10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameOnlineCreationReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x060056E7 RID: 22247 RVA: 0x00150834 File Offset: 0x0014EA34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineGameCreationSettings.Descriptor;
			}
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x0015084B File Offset: 0x0014EA4B
		[DebuggerNonUserCode]
		public OnlineGameCreationSettings()
		{
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x00150858 File Offset: 0x0014EA58
		[DebuggerNonUserCode]
		public OnlineGameCreationSettings(OnlineGameCreationSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.difficulty_ = other.difficulty_;
			this.maxNumberOfPlayers_ = other.maxNumberOfPlayers_;
			this.enabledCharacterLevelRestriction_ = other.enabledCharacterLevelRestriction_;
			this.maxCharacterLevelDifference_ = other.maxCharacterLevelDifference_;
			this.automaticallyInvitePlayersToParty_ = other.automaticallyInvitePlayersToParty_;
			this.automaticallyAcceptPartyInvites_ = other.automaticallyAcceptPartyInvites_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x001508D4 File Offset: 0x0014EAD4
		[DebuggerNonUserCode]
		public OnlineGameCreationSettings Clone()
		{
			return new OnlineGameCreationSettings(this);
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x060056EB RID: 22251 RVA: 0x001508EC File Offset: 0x0014EAEC
		// (set) Token: 0x060056EC RID: 22252 RVA: 0x0015090D File Offset: 0x0014EB0D
		[DebuggerNonUserCode]
		public string Difficulty
		{
			get
			{
				return this.difficulty_ ?? OnlineGameCreationSettings.DifficultyDefaultValue;
			}
			set
			{
				this.difficulty_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x060056ED RID: 22253 RVA: 0x00150924 File Offset: 0x0014EB24
		[DebuggerNonUserCode]
		public bool HasDifficulty
		{
			get
			{
				return this.difficulty_ != null;
			}
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x0015093F File Offset: 0x0014EB3F
		[DebuggerNonUserCode]
		public void ClearDifficulty()
		{
			this.difficulty_ = null;
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x060056EF RID: 22255 RVA: 0x0015094C File Offset: 0x0014EB4C
		// (set) Token: 0x060056F0 RID: 22256 RVA: 0x0015097D File Offset: 0x0014EB7D
		[DebuggerNonUserCode]
		public uint MaxNumberOfPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint maxNumberOfPlayersDefaultValue;
				if (flag)
				{
					maxNumberOfPlayersDefaultValue = this.maxNumberOfPlayers_;
				}
				else
				{
					maxNumberOfPlayersDefaultValue = OnlineGameCreationSettings.MaxNumberOfPlayersDefaultValue;
				}
				return maxNumberOfPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.maxNumberOfPlayers_ = value;
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x060056F1 RID: 22257 RVA: 0x00150998 File Offset: 0x0014EB98
		[DebuggerNonUserCode]
		public bool HasMaxNumberOfPlayers
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x001509B5 File Offset: 0x0014EBB5
		[DebuggerNonUserCode]
		public void ClearMaxNumberOfPlayers()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x060056F3 RID: 22259 RVA: 0x001509C8 File Offset: 0x0014EBC8
		// (set) Token: 0x060056F4 RID: 22260 RVA: 0x001509F9 File Offset: 0x0014EBF9
		[DebuggerNonUserCode]
		public bool EnabledCharacterLevelRestriction
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool enabledCharacterLevelRestrictionDefaultValue;
				if (flag)
				{
					enabledCharacterLevelRestrictionDefaultValue = this.enabledCharacterLevelRestriction_;
				}
				else
				{
					enabledCharacterLevelRestrictionDefaultValue = OnlineGameCreationSettings.EnabledCharacterLevelRestrictionDefaultValue;
				}
				return enabledCharacterLevelRestrictionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.enabledCharacterLevelRestriction_ = value;
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x060056F5 RID: 22261 RVA: 0x00150A14 File Offset: 0x0014EC14
		[DebuggerNonUserCode]
		public bool HasEnabledCharacterLevelRestriction
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x00150A31 File Offset: 0x0014EC31
		[DebuggerNonUserCode]
		public void ClearEnabledCharacterLevelRestriction()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x060056F7 RID: 22263 RVA: 0x00150A44 File Offset: 0x0014EC44
		// (set) Token: 0x060056F8 RID: 22264 RVA: 0x00150A75 File Offset: 0x0014EC75
		[DebuggerNonUserCode]
		public uint MaxCharacterLevelDifference
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint maxCharacterLevelDifferenceDefaultValue;
				if (flag)
				{
					maxCharacterLevelDifferenceDefaultValue = this.maxCharacterLevelDifference_;
				}
				else
				{
					maxCharacterLevelDifferenceDefaultValue = OnlineGameCreationSettings.MaxCharacterLevelDifferenceDefaultValue;
				}
				return maxCharacterLevelDifferenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.maxCharacterLevelDifference_ = value;
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x060056F9 RID: 22265 RVA: 0x00150A90 File Offset: 0x0014EC90
		[DebuggerNonUserCode]
		public bool HasMaxCharacterLevelDifference
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x00150AAD File Offset: 0x0014ECAD
		[DebuggerNonUserCode]
		public void ClearMaxCharacterLevelDifference()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x00150AC0 File Offset: 0x0014ECC0
		// (set) Token: 0x060056FC RID: 22268 RVA: 0x00150AF1 File Offset: 0x0014ECF1
		[DebuggerNonUserCode]
		public bool AutomaticallyInvitePlayersToParty
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool automaticallyInvitePlayersToPartyDefaultValue;
				if (flag)
				{
					automaticallyInvitePlayersToPartyDefaultValue = this.automaticallyInvitePlayersToParty_;
				}
				else
				{
					automaticallyInvitePlayersToPartyDefaultValue = OnlineGameCreationSettings.AutomaticallyInvitePlayersToPartyDefaultValue;
				}
				return automaticallyInvitePlayersToPartyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.automaticallyInvitePlayersToParty_ = value;
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x060056FD RID: 22269 RVA: 0x00150B0C File Offset: 0x0014ED0C
		[DebuggerNonUserCode]
		public bool HasAutomaticallyInvitePlayersToParty
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x00150B29 File Offset: 0x0014ED29
		[DebuggerNonUserCode]
		public void ClearAutomaticallyInvitePlayersToParty()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x00150B3C File Offset: 0x0014ED3C
		// (set) Token: 0x06005700 RID: 22272 RVA: 0x00150B6E File Offset: 0x0014ED6E
		[DebuggerNonUserCode]
		public bool AutomaticallyAcceptPartyInvites
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool automaticallyAcceptPartyInvitesDefaultValue;
				if (flag)
				{
					automaticallyAcceptPartyInvitesDefaultValue = this.automaticallyAcceptPartyInvites_;
				}
				else
				{
					automaticallyAcceptPartyInvitesDefaultValue = OnlineGameCreationSettings.AutomaticallyAcceptPartyInvitesDefaultValue;
				}
				return automaticallyAcceptPartyInvitesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.automaticallyAcceptPartyInvites_ = value;
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x00150B88 File Offset: 0x0014ED88
		[DebuggerNonUserCode]
		public bool HasAutomaticallyAcceptPartyInvites
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x00150BA6 File Offset: 0x0014EDA6
		[DebuggerNonUserCode]
		public void ClearAutomaticallyAcceptPartyInvites()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x00150BB8 File Offset: 0x0014EDB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineGameCreationSettings);
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x00150BD8 File Offset: 0x0014EDD8
		[DebuggerNonUserCode]
		public bool Equals(OnlineGameCreationSettings other)
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
					bool flag4 = this.Difficulty != other.Difficulty;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxNumberOfPlayers != other.MaxNumberOfPlayers;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EnabledCharacterLevelRestriction != other.EnabledCharacterLevelRestriction;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MaxCharacterLevelDifference != other.MaxCharacterLevelDifference;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AutomaticallyInvitePlayersToParty != other.AutomaticallyInvitePlayersToParty;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.AutomaticallyAcceptPartyInvites != other.AutomaticallyAcceptPartyInvites;
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

		// Token: 0x06005705 RID: 22277 RVA: 0x00150CC4 File Offset: 0x0014EEC4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				num ^= this.Difficulty.GetHashCode();
			}
			bool hasMaxNumberOfPlayers = this.HasMaxNumberOfPlayers;
			if (hasMaxNumberOfPlayers)
			{
				num ^= this.MaxNumberOfPlayers.GetHashCode();
			}
			bool hasEnabledCharacterLevelRestriction = this.HasEnabledCharacterLevelRestriction;
			if (hasEnabledCharacterLevelRestriction)
			{
				num ^= this.EnabledCharacterLevelRestriction.GetHashCode();
			}
			bool hasMaxCharacterLevelDifference = this.HasMaxCharacterLevelDifference;
			if (hasMaxCharacterLevelDifference)
			{
				num ^= this.MaxCharacterLevelDifference.GetHashCode();
			}
			bool hasAutomaticallyInvitePlayersToParty = this.HasAutomaticallyInvitePlayersToParty;
			if (hasAutomaticallyInvitePlayersToParty)
			{
				num ^= this.AutomaticallyInvitePlayersToParty.GetHashCode();
			}
			bool hasAutomaticallyAcceptPartyInvites = this.HasAutomaticallyAcceptPartyInvites;
			if (hasAutomaticallyAcceptPartyInvites)
			{
				num ^= this.AutomaticallyAcceptPartyInvites.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x00150DA4 File Offset: 0x0014EFA4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x00150DBC File Offset: 0x0014EFBC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x00150DC8 File Offset: 0x0014EFC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Difficulty);
			}
			bool hasMaxNumberOfPlayers = this.HasMaxNumberOfPlayers;
			if (hasMaxNumberOfPlayers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxNumberOfPlayers);
			}
			bool hasEnabledCharacterLevelRestriction = this.HasEnabledCharacterLevelRestriction;
			if (hasEnabledCharacterLevelRestriction)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.EnabledCharacterLevelRestriction);
			}
			bool hasMaxCharacterLevelDifference = this.HasMaxCharacterLevelDifference;
			if (hasMaxCharacterLevelDifference)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MaxCharacterLevelDifference);
			}
			bool hasAutomaticallyInvitePlayersToParty = this.HasAutomaticallyInvitePlayersToParty;
			if (hasAutomaticallyInvitePlayersToParty)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.AutomaticallyInvitePlayersToParty);
			}
			bool hasAutomaticallyAcceptPartyInvites = this.HasAutomaticallyAcceptPartyInvites;
			if (hasAutomaticallyAcceptPartyInvites)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.AutomaticallyAcceptPartyInvites);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x00150EC4 File Offset: 0x0014F0C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Difficulty);
			}
			bool hasMaxNumberOfPlayers = this.HasMaxNumberOfPlayers;
			if (hasMaxNumberOfPlayers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxNumberOfPlayers);
			}
			bool hasEnabledCharacterLevelRestriction = this.HasEnabledCharacterLevelRestriction;
			if (hasEnabledCharacterLevelRestriction)
			{
				num += 2;
			}
			bool hasMaxCharacterLevelDifference = this.HasMaxCharacterLevelDifference;
			if (hasMaxCharacterLevelDifference)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxCharacterLevelDifference);
			}
			bool hasAutomaticallyInvitePlayersToParty = this.HasAutomaticallyInvitePlayersToParty;
			if (hasAutomaticallyInvitePlayersToParty)
			{
				num += 2;
			}
			bool hasAutomaticallyAcceptPartyInvites = this.HasAutomaticallyAcceptPartyInvites;
			if (hasAutomaticallyAcceptPartyInvites)
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

		// Token: 0x0600570A RID: 22282 RVA: 0x00150F84 File Offset: 0x0014F184
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineGameCreationSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDifficulty = other.HasDifficulty;
				if (hasDifficulty)
				{
					this.Difficulty = other.Difficulty;
				}
				bool hasMaxNumberOfPlayers = other.HasMaxNumberOfPlayers;
				if (hasMaxNumberOfPlayers)
				{
					this.MaxNumberOfPlayers = other.MaxNumberOfPlayers;
				}
				bool hasEnabledCharacterLevelRestriction = other.HasEnabledCharacterLevelRestriction;
				if (hasEnabledCharacterLevelRestriction)
				{
					this.EnabledCharacterLevelRestriction = other.EnabledCharacterLevelRestriction;
				}
				bool hasMaxCharacterLevelDifference = other.HasMaxCharacterLevelDifference;
				if (hasMaxCharacterLevelDifference)
				{
					this.MaxCharacterLevelDifference = other.MaxCharacterLevelDifference;
				}
				bool hasAutomaticallyInvitePlayersToParty = other.HasAutomaticallyInvitePlayersToParty;
				if (hasAutomaticallyInvitePlayersToParty)
				{
					this.AutomaticallyInvitePlayersToParty = other.AutomaticallyInvitePlayersToParty;
				}
				bool hasAutomaticallyAcceptPartyInvites = other.HasAutomaticallyAcceptPartyInvites;
				if (hasAutomaticallyAcceptPartyInvites)
				{
					this.AutomaticallyAcceptPartyInvites = other.AutomaticallyAcceptPartyInvites;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x00151053 File Offset: 0x0014F253
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x00151060 File Offset: 0x0014F260
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_003A;
							}
							this.EnabledCharacterLevelRestriction = input.ReadBool();
						}
						else
						{
							this.MaxNumberOfPlayers = input.ReadUInt32();
						}
					}
					else
					{
						this.Difficulty = input.ReadString();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_003A;
						}
						this.AutomaticallyAcceptPartyInvites = input.ReadBool();
					}
					else
					{
						this.AutomaticallyInvitePlayersToParty = input.ReadBool();
					}
				}
				else
				{
					this.MaxCharacterLevelDifference = input.ReadUInt32();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027AA RID: 10154
		private static readonly MessageParser<OnlineGameCreationSettings> _parser = new MessageParser<OnlineGameCreationSettings>(() => new OnlineGameCreationSettings());

		// Token: 0x040027AB RID: 10155
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027AC RID: 10156
		private int _hasBits0;

		// Token: 0x040027AD RID: 10157
		public const int DifficultyFieldNumber = 1;

		// Token: 0x040027AE RID: 10158
		private static readonly string DifficultyDefaultValue = "";

		// Token: 0x040027AF RID: 10159
		private string difficulty_;

		// Token: 0x040027B0 RID: 10160
		public const int MaxNumberOfPlayersFieldNumber = 2;

		// Token: 0x040027B1 RID: 10161
		private static readonly uint MaxNumberOfPlayersDefaultValue = 0U;

		// Token: 0x040027B2 RID: 10162
		private uint maxNumberOfPlayers_;

		// Token: 0x040027B3 RID: 10163
		public const int EnabledCharacterLevelRestrictionFieldNumber = 3;

		// Token: 0x040027B4 RID: 10164
		private static readonly bool EnabledCharacterLevelRestrictionDefaultValue = false;

		// Token: 0x040027B5 RID: 10165
		private bool enabledCharacterLevelRestriction_;

		// Token: 0x040027B6 RID: 10166
		public const int MaxCharacterLevelDifferenceFieldNumber = 4;

		// Token: 0x040027B7 RID: 10167
		private static readonly uint MaxCharacterLevelDifferenceDefaultValue = 0U;

		// Token: 0x040027B8 RID: 10168
		private uint maxCharacterLevelDifference_;

		// Token: 0x040027B9 RID: 10169
		public const int AutomaticallyInvitePlayersToPartyFieldNumber = 5;

		// Token: 0x040027BA RID: 10170
		private static readonly bool AutomaticallyInvitePlayersToPartyDefaultValue = false;

		// Token: 0x040027BB RID: 10171
		private bool automaticallyInvitePlayersToParty_;

		// Token: 0x040027BC RID: 10172
		public const int AutomaticallyAcceptPartyInvitesFieldNumber = 6;

		// Token: 0x040027BD RID: 10173
		private static readonly bool AutomaticallyAcceptPartyInvitesDefaultValue = false;

		// Token: 0x040027BE RID: 10174
		private bool automaticallyAcceptPartyInvites_;
	}
}
