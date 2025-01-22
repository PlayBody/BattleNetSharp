using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Client
{
	// Token: 0x02000119 RID: 281
	public sealed class GameAccountSettings : IMessage<GameAccountSettings>, IMessage, IEquatable<GameAccountSettings>, IDeepCloneable<GameAccountSettings>, IBufferMessage
	{
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x00061700 File Offset: 0x0005F900
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountSettings> Parser
		{
			get
			{
				return GameAccountSettings._parser;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x00061718 File Offset: 0x0005F918
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0006173C File Offset: 0x0005F93C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountSettings.Descriptor;
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00061754 File Offset: 0x0005F954
		[DebuggerNonUserCode]
		public GameAccountSettings()
		{
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x000617A0 File Offset: 0x0005F9A0
		[DebuggerNonUserCode]
		public GameAccountSettings(GameAccountSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroListOrder_ = other.heroListOrder_.Clone();
			this.fontColorOverrides_ = other.fontColorOverrides_.Clone();
			this.clanNewInvitesApplicationsTimestamp_ = other.clanNewInvitesApplicationsTimestamp_;
			this.seenNews_ = other.seenNews_.Clone();
			this.flags_ = other.flags_;
			this.seenProductIds_ = other.seenProductIds_.Clone();
			this.seenRecentPurchaseIds_ = other.seenRecentPurchaseIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00061840 File Offset: 0x0005FA40
		[DebuggerNonUserCode]
		public GameAccountSettings Clone()
		{
			return new GameAccountSettings(this);
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00061858 File Offset: 0x0005FA58
		[DebuggerNonUserCode]
		public RepeatedField<ByteString> HeroListOrder
		{
			get
			{
				return this.heroListOrder_;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x00061870 File Offset: 0x0005FA70
		[DebuggerNonUserCode]
		public RepeatedField<FontColorOverride> FontColorOverrides
		{
			get
			{
				return this.fontColorOverrides_;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00061888 File Offset: 0x0005FA88
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x000618B9 File Offset: 0x0005FAB9
		[DebuggerNonUserCode]
		public ulong ClanNewInvitesApplicationsTimestamp
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clanNewInvitesApplicationsTimestampDefaultValue;
				if (flag)
				{
					clanNewInvitesApplicationsTimestampDefaultValue = this.clanNewInvitesApplicationsTimestamp_;
				}
				else
				{
					clanNewInvitesApplicationsTimestampDefaultValue = GameAccountSettings.ClanNewInvitesApplicationsTimestampDefaultValue;
				}
				return clanNewInvitesApplicationsTimestampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clanNewInvitesApplicationsTimestamp_ = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000618D4 File Offset: 0x0005FAD4
		[DebuggerNonUserCode]
		public bool HasClanNewInvitesApplicationsTimestamp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x000618F1 File Offset: 0x0005FAF1
		[DebuggerNonUserCode]
		public void ClearClanNewInvitesApplicationsTimestamp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x00061904 File Offset: 0x0005FB04
		[DebuggerNonUserCode]
		public RepeatedField<string> SeenNews
		{
			get
			{
				return this.seenNews_;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0006191C File Offset: 0x0005FB1C
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0006194D File Offset: 0x0005FB4D
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = GameAccountSettings.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.flags_ = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00061968 File Offset: 0x0005FB68
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00061985 File Offset: 0x0005FB85
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00061998 File Offset: 0x0005FB98
		[DebuggerNonUserCode]
		public RepeatedField<ulong> SeenProductIds
		{
			get
			{
				return this.seenProductIds_;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x000619B0 File Offset: 0x0005FBB0
		[DebuggerNonUserCode]
		public RepeatedField<int> SeenRecentPurchaseIds
		{
			get
			{
				return this.seenRecentPurchaseIds_;
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000619C8 File Offset: 0x0005FBC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountSettings);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x000619E8 File Offset: 0x0005FBE8
		[DebuggerNonUserCode]
		public bool Equals(GameAccountSettings other)
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
					bool flag4 = !this.heroListOrder_.Equals(other.heroListOrder_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.fontColorOverrides_.Equals(other.fontColorOverrides_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ClanNewInvitesApplicationsTimestamp != other.ClanNewInvitesApplicationsTimestamp;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.seenNews_.Equals(other.seenNews_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Flags != other.Flags;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.seenProductIds_.Equals(other.seenProductIds_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.seenRecentPurchaseIds_.Equals(other.seenRecentPurchaseIds_);
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06001ADE RID: 6878 RVA: 0x00061B00 File Offset: 0x0005FD00
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.heroListOrder_.GetHashCode();
			num ^= this.fontColorOverrides_.GetHashCode();
			bool hasClanNewInvitesApplicationsTimestamp = this.HasClanNewInvitesApplicationsTimestamp;
			if (hasClanNewInvitesApplicationsTimestamp)
			{
				num ^= this.ClanNewInvitesApplicationsTimestamp.GetHashCode();
			}
			num ^= this.seenNews_.GetHashCode();
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			num ^= this.seenProductIds_.GetHashCode();
			num ^= this.seenRecentPurchaseIds_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00061BB4 File Offset: 0x0005FDB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00061BCC File Offset: 0x0005FDCC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00061BD8 File Offset: 0x0005FDD8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.heroListOrder_.WriteTo(ref output, GameAccountSettings._repeated_heroListOrder_codec);
			this.fontColorOverrides_.WriteTo(ref output, GameAccountSettings._repeated_fontColorOverrides_codec);
			bool hasClanNewInvitesApplicationsTimestamp = this.HasClanNewInvitesApplicationsTimestamp;
			if (hasClanNewInvitesApplicationsTimestamp)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.ClanNewInvitesApplicationsTimestamp);
			}
			this.seenNews_.WriteTo(ref output, GameAccountSettings._repeated_seenNews_codec);
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Flags);
			}
			this.seenProductIds_.WriteTo(ref output, GameAccountSettings._repeated_seenProductIds_codec);
			this.seenRecentPurchaseIds_.WriteTo(ref output, GameAccountSettings._repeated_seenRecentPurchaseIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00061CA0 File Offset: 0x0005FEA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.heroListOrder_.CalculateSize(GameAccountSettings._repeated_heroListOrder_codec);
			num += this.fontColorOverrides_.CalculateSize(GameAccountSettings._repeated_fontColorOverrides_codec);
			bool hasClanNewInvitesApplicationsTimestamp = this.HasClanNewInvitesApplicationsTimestamp;
			if (hasClanNewInvitesApplicationsTimestamp)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClanNewInvitesApplicationsTimestamp);
			}
			num += this.seenNews_.CalculateSize(GameAccountSettings._repeated_seenNews_codec);
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			num += this.seenProductIds_.CalculateSize(GameAccountSettings._repeated_seenProductIds_codec);
			num += this.seenRecentPurchaseIds_.CalculateSize(GameAccountSettings._repeated_seenRecentPurchaseIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00061D6C File Offset: 0x0005FF6C
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.heroListOrder_.Add(other.heroListOrder_);
				this.fontColorOverrides_.Add(other.fontColorOverrides_);
				bool hasClanNewInvitesApplicationsTimestamp = other.HasClanNewInvitesApplicationsTimestamp;
				if (hasClanNewInvitesApplicationsTimestamp)
				{
					this.ClanNewInvitesApplicationsTimestamp = other.ClanNewInvitesApplicationsTimestamp;
				}
				this.seenNews_.Add(other.seenNews_);
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				this.seenProductIds_.Add(other.seenProductIds_);
				this.seenRecentPurchaseIds_.Add(other.seenRecentPurchaseIds_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00061E2B File Offset: 0x0006002B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00061E38 File Offset: 0x00060038
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_006E;
							}
							this.fontColorOverrides_.AddEntriesFrom(ref input, GameAccountSettings._repeated_fontColorOverrides_codec);
						}
						else
						{
							this.heroListOrder_.AddEntriesFrom(ref input, GameAccountSettings._repeated_heroListOrder_codec);
						}
					}
					else if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_006E;
						}
						this.seenNews_.AddEntriesFrom(ref input, GameAccountSettings._repeated_seenNews_codec);
					}
					else
					{
						this.ClanNewInvitesApplicationsTimestamp = input.ReadUInt64();
					}
				}
				else
				{
					if (num3 <= 64U)
					{
						if (num3 == 56U)
						{
							this.Flags = input.ReadUInt32();
							continue;
						}
						if (num3 != 64U)
						{
							goto IL_006E;
						}
					}
					else if (num3 != 66U)
					{
						if (num3 != 72U && num3 != 74U)
						{
							goto IL_006E;
						}
						this.seenRecentPurchaseIds_.AddEntriesFrom(ref input, GameAccountSettings._repeated_seenRecentPurchaseIds_codec);
						continue;
					}
					this.seenProductIds_.AddEntriesFrom(ref input, GameAccountSettings._repeated_seenProductIds_codec);
				}
				continue;
				IL_006E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000ACB RID: 2763
		private static readonly MessageParser<GameAccountSettings> _parser = new MessageParser<GameAccountSettings>(() => new GameAccountSettings());

		// Token: 0x04000ACC RID: 2764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ACD RID: 2765
		private int _hasBits0;

		// Token: 0x04000ACE RID: 2766
		public const int HeroListOrderFieldNumber = 1;

		// Token: 0x04000ACF RID: 2767
		private static readonly FieldCodec<ByteString> _repeated_heroListOrder_codec = FieldCodec.ForBytes(10U);

		// Token: 0x04000AD0 RID: 2768
		private readonly RepeatedField<ByteString> heroListOrder_ = new RepeatedField<ByteString>();

		// Token: 0x04000AD1 RID: 2769
		public const int FontColorOverridesFieldNumber = 2;

		// Token: 0x04000AD2 RID: 2770
		private static readonly FieldCodec<FontColorOverride> _repeated_fontColorOverrides_codec = FieldCodec.ForMessage<FontColorOverride>(18U, FontColorOverride.Parser);

		// Token: 0x04000AD3 RID: 2771
		private readonly RepeatedField<FontColorOverride> fontColorOverrides_ = new RepeatedField<FontColorOverride>();

		// Token: 0x04000AD4 RID: 2772
		public const int ClanNewInvitesApplicationsTimestampFieldNumber = 5;

		// Token: 0x04000AD5 RID: 2773
		private static readonly ulong ClanNewInvitesApplicationsTimestampDefaultValue = 0UL;

		// Token: 0x04000AD6 RID: 2774
		private ulong clanNewInvitesApplicationsTimestamp_;

		// Token: 0x04000AD7 RID: 2775
		public const int SeenNewsFieldNumber = 6;

		// Token: 0x04000AD8 RID: 2776
		private static readonly FieldCodec<string> _repeated_seenNews_codec = FieldCodec.ForString(50U);

		// Token: 0x04000AD9 RID: 2777
		private readonly RepeatedField<string> seenNews_ = new RepeatedField<string>();

		// Token: 0x04000ADA RID: 2778
		public const int FlagsFieldNumber = 7;

		// Token: 0x04000ADB RID: 2779
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x04000ADC RID: 2780
		private uint flags_;

		// Token: 0x04000ADD RID: 2781
		public const int SeenProductIdsFieldNumber = 8;

		// Token: 0x04000ADE RID: 2782
		private static readonly FieldCodec<ulong> _repeated_seenProductIds_codec = FieldCodec.ForUInt64(64U);

		// Token: 0x04000ADF RID: 2783
		private readonly RepeatedField<ulong> seenProductIds_ = new RepeatedField<ulong>();

		// Token: 0x04000AE0 RID: 2784
		public const int SeenRecentPurchaseIdsFieldNumber = 9;

		// Token: 0x04000AE1 RID: 2785
		private static readonly FieldCodec<int> _repeated_seenRecentPurchaseIds_codec = FieldCodec.ForInt32(72U);

		// Token: 0x04000AE2 RID: 2786
		private readonly RepeatedField<int> seenRecentPurchaseIds_ = new RepeatedField<int>();

		// Token: 0x02000C34 RID: 3124
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001472 RID: 5234
			public enum Flags
			{
				// Token: 0x0400A35C RID: 41820
				[OriginalName("CAMPAIGN_SKIP_TUTORIAL_SEEN")]
				CampaignSkipTutorialSeen = 1,
				// Token: 0x0400A35D RID: 41821
				[OriginalName("STORE_REFRESHED_INTRO_SEEN")]
				StoreRefreshedIntroSeen
			}
		}
	}
}
