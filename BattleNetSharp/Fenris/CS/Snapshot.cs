using System;
using System.Diagnostics;
using Fenris.Account;
using Fenris.Client;
using Fenris.Hero;
using Fenris.Items;
using Fenris.Profile;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000202 RID: 514
	public sealed class Snapshot : IMessage<Snapshot>, IMessage, IEquatable<Snapshot>, IDeepCloneable<Snapshot>, IBufferMessage
	{
		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x000DF5AC File Offset: 0x000DD7AC
		[DebuggerNonUserCode]
		public static MessageParser<Snapshot> Parser
		{
			get
			{
				return Snapshot._parser;
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x000DF5C4 File Offset: 0x000DD7C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x000DF5E8 File Offset: 0x000DD7E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Snapshot.Descriptor;
			}
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x000DF5FF File Offset: 0x000DD7FF
		[DebuggerNonUserCode]
		public Snapshot()
		{
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x000DF620 File Offset: 0x000DD820
		[DebuggerNonUserCode]
		public Snapshot(Snapshot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.gameAccountId_ = other.gameAccountId_;
			this.definition_ = ((other.definition_ != null) ? other.definition_.Clone() : null);
			this.heroes_ = other.heroes_.Clone();
			this.heroProfiles_ = ((other.heroProfiles_ != null) ? other.heroProfiles_.Clone() : null);
			this.mails_ = ((other.mails_ != null) ? other.mails_.Clone() : null);
			this.accountProfiles_ = other.accountProfiles_.Clone();
			this.preferences_ = ((other.preferences_ != null) ? other.preferences_.Clone() : null);
			this.banned_ = other.banned_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x000DF708 File Offset: 0x000DD908
		[DebuggerNonUserCode]
		public Snapshot Clone()
		{
			return new Snapshot(this);
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x000DF720 File Offset: 0x000DD920
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x000DF751 File Offset: 0x000DD951
		[DebuggerNonUserCode]
		public ulong Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = Snapshot.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x000DF76C File Offset: 0x000DD96C
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x000DF789 File Offset: 0x000DD989
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x000DF79C File Offset: 0x000DD99C
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x000DF7CD File Offset: 0x000DD9CD
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = Snapshot.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x000DF7E8 File Offset: 0x000DD9E8
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x000DF805 File Offset: 0x000DDA05
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x000DF818 File Offset: 0x000DDA18
		// (set) Token: 0x06003875 RID: 14453 RVA: 0x000DF830 File Offset: 0x000DDA30
		[DebuggerNonUserCode]
		public Fenris.Account.SavedDefinition Definition
		{
			get
			{
				return this.definition_;
			}
			set
			{
				this.definition_ = value;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x000DF83C File Offset: 0x000DDA3C
		[DebuggerNonUserCode]
		public RepeatedField<Fenris.Hero.SavedDefinition> Heroes
		{
			get
			{
				return this.heroes_;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x000DF854 File Offset: 0x000DDA54
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x000DF86C File Offset: 0x000DDA6C
		[DebuggerNonUserCode]
		public HeroProfileList HeroProfiles
		{
			get
			{
				return this.heroProfiles_;
			}
			set
			{
				this.heroProfiles_ = value;
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x000DF878 File Offset: 0x000DDA78
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x000DF890 File Offset: 0x000DDA90
		[DebuggerNonUserCode]
		public Mails Mails
		{
			get
			{
				return this.mails_;
			}
			set
			{
				this.mails_ = value;
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x000DF89C File Offset: 0x000DDA9C
		[DebuggerNonUserCode]
		public RepeatedField<AccountProfile> AccountProfiles
		{
			get
			{
				return this.accountProfiles_;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x000DF8B4 File Offset: 0x000DDAB4
		// (set) Token: 0x0600387D RID: 14461 RVA: 0x000DF8CC File Offset: 0x000DDACC
		[DebuggerNonUserCode]
		public Preferences Preferences
		{
			get
			{
				return this.preferences_;
			}
			set
			{
				this.preferences_ = value;
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x000DF8D8 File Offset: 0x000DDAD8
		// (set) Token: 0x0600387F RID: 14463 RVA: 0x000DF909 File Offset: 0x000DDB09
		[DebuggerNonUserCode]
		public bool Banned
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool bannedDefaultValue;
				if (flag)
				{
					bannedDefaultValue = this.banned_;
				}
				else
				{
					bannedDefaultValue = Snapshot.BannedDefaultValue;
				}
				return bannedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.banned_ = value;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x000DF924 File Offset: 0x000DDB24
		[DebuggerNonUserCode]
		public bool HasBanned
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x000DF941 File Offset: 0x000DDB41
		[DebuggerNonUserCode]
		public void ClearBanned()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x000DF954 File Offset: 0x000DDB54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Snapshot);
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x000DF974 File Offset: 0x000DDB74
		[DebuggerNonUserCode]
		public bool Equals(Snapshot other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountId != other.GameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Definition, other.Definition);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.heroes_.Equals(other.heroes_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.HeroProfiles, other.HeroProfiles);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Mails, other.Mails);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.accountProfiles_.Equals(other.accountProfiles_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.Preferences, other.Preferences);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.Banned != other.Banned;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06003884 RID: 14468 RVA: 0x000DFACC File Offset: 0x000DDCCC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this.definition_ != null;
			if (flag)
			{
				num ^= this.Definition.GetHashCode();
			}
			num ^= this.heroes_.GetHashCode();
			bool flag2 = this.heroProfiles_ != null;
			if (flag2)
			{
				num ^= this.HeroProfiles.GetHashCode();
			}
			bool flag3 = this.mails_ != null;
			if (flag3)
			{
				num ^= this.Mails.GetHashCode();
			}
			num ^= this.accountProfiles_.GetHashCode();
			bool flag4 = this.preferences_ != null;
			if (flag4)
			{
				num ^= this.Preferences.GetHashCode();
			}
			bool hasBanned = this.HasBanned;
			if (hasBanned)
			{
				num ^= this.Banned.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x000DFBE8 File Offset: 0x000DDDE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x000DFC00 File Offset: 0x000DDE00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x000DFC0C File Offset: 0x000DDE0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Version);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this.definition_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Definition);
			}
			this.heroes_.WriteTo(ref output, Snapshot._repeated_heroes_codec);
			bool flag2 = this.heroProfiles_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.HeroProfiles);
			}
			bool flag3 = this.mails_ != null;
			if (flag3)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Mails);
			}
			this.accountProfiles_.WriteTo(ref output, Snapshot._repeated_accountProfiles_codec);
			bool flag4 = this.preferences_ != null;
			if (flag4)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Preferences);
			}
			bool hasBanned = this.HasBanned;
			if (hasBanned)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Banned);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x000DFD5C File Offset: 0x000DDF5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Version);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this.definition_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Definition);
			}
			num += this.heroes_.CalculateSize(Snapshot._repeated_heroes_codec);
			bool flag2 = this.heroProfiles_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroProfiles);
			}
			bool flag3 = this.mails_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Mails);
			}
			num += this.accountProfiles_.CalculateSize(Snapshot._repeated_accountProfiles_codec);
			bool flag4 = this.preferences_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Preferences);
			}
			bool hasBanned = this.HasBanned;
			if (hasBanned)
			{
				num += 2;
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x000DFE84 File Offset: 0x000DE084
		[DebuggerNonUserCode]
		public void MergeFrom(Snapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool flag2 = other.definition_ != null;
				if (flag2)
				{
					bool flag3 = this.definition_ == null;
					if (flag3)
					{
						this.Definition = new Fenris.Account.SavedDefinition();
					}
					this.Definition.MergeFrom(other.Definition);
				}
				this.heroes_.Add(other.heroes_);
				bool flag4 = other.heroProfiles_ != null;
				if (flag4)
				{
					bool flag5 = this.heroProfiles_ == null;
					if (flag5)
					{
						this.HeroProfiles = new HeroProfileList();
					}
					this.HeroProfiles.MergeFrom(other.HeroProfiles);
				}
				bool flag6 = other.mails_ != null;
				if (flag6)
				{
					bool flag7 = this.mails_ == null;
					if (flag7)
					{
						this.Mails = new Mails();
					}
					this.Mails.MergeFrom(other.Mails);
				}
				this.accountProfiles_.Add(other.accountProfiles_);
				bool flag8 = other.preferences_ != null;
				if (flag8)
				{
					bool flag9 = this.preferences_ == null;
					if (flag9)
					{
						this.Preferences = new Preferences();
					}
					this.Preferences.MergeFrom(other.Preferences);
				}
				bool hasBanned = other.HasBanned;
				if (hasBanned)
				{
					this.Banned = other.Banned;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x000E0026 File Offset: 0x000DE226
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x000E0034 File Offset: 0x000DE234
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
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006D;
							}
							this.GameAccountId = input.ReadUInt32();
						}
						else
						{
							this.Version = input.ReadUInt64();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_006D;
						}
						this.heroes_.AddEntriesFrom(ref input, Snapshot._repeated_heroes_codec);
					}
					else
					{
						bool flag = this.definition_ == null;
						if (flag)
						{
							this.Definition = new Fenris.Account.SavedDefinition();
						}
						input.ReadMessage(this.Definition);
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_006D;
						}
						bool flag2 = this.mails_ == null;
						if (flag2)
						{
							this.Mails = new Mails();
						}
						input.ReadMessage(this.Mails);
					}
					else
					{
						bool flag3 = this.heroProfiles_ == null;
						if (flag3)
						{
							this.HeroProfiles = new HeroProfileList();
						}
						input.ReadMessage(this.HeroProfiles);
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						if (num3 != 72U)
						{
							goto IL_006D;
						}
						this.Banned = input.ReadBool();
					}
					else
					{
						bool flag4 = this.preferences_ == null;
						if (flag4)
						{
							this.Preferences = new Preferences();
						}
						input.ReadMessage(this.Preferences);
					}
				}
				else
				{
					this.accountProfiles_.AddEntriesFrom(ref input, Snapshot._repeated_accountProfiles_codec);
				}
				continue;
				IL_006D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001A58 RID: 6744
		private static readonly MessageParser<Snapshot> _parser = new MessageParser<Snapshot>(() => new Snapshot());

		// Token: 0x04001A59 RID: 6745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A5A RID: 6746
		private int _hasBits0;

		// Token: 0x04001A5B RID: 6747
		public const int VersionFieldNumber = 1;

		// Token: 0x04001A5C RID: 6748
		private static readonly ulong VersionDefaultValue = 0UL;

		// Token: 0x04001A5D RID: 6749
		private ulong version_;

		// Token: 0x04001A5E RID: 6750
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04001A5F RID: 6751
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001A60 RID: 6752
		private uint gameAccountId_;

		// Token: 0x04001A61 RID: 6753
		public const int DefinitionFieldNumber = 3;

		// Token: 0x04001A62 RID: 6754
		private Fenris.Account.SavedDefinition definition_;

		// Token: 0x04001A63 RID: 6755
		public const int HeroesFieldNumber = 4;

		// Token: 0x04001A64 RID: 6756
		private static readonly FieldCodec<Fenris.Hero.SavedDefinition> _repeated_heroes_codec = FieldCodec.ForMessage<Fenris.Hero.SavedDefinition>(34U, Fenris.Hero.SavedDefinition.Parser);

		// Token: 0x04001A65 RID: 6757
		private readonly RepeatedField<Fenris.Hero.SavedDefinition> heroes_ = new RepeatedField<Fenris.Hero.SavedDefinition>();

		// Token: 0x04001A66 RID: 6758
		public const int HeroProfilesFieldNumber = 5;

		// Token: 0x04001A67 RID: 6759
		private HeroProfileList heroProfiles_;

		// Token: 0x04001A68 RID: 6760
		public const int MailsFieldNumber = 6;

		// Token: 0x04001A69 RID: 6761
		private Mails mails_;

		// Token: 0x04001A6A RID: 6762
		public const int AccountProfilesFieldNumber = 7;

		// Token: 0x04001A6B RID: 6763
		private static readonly FieldCodec<AccountProfile> _repeated_accountProfiles_codec = FieldCodec.ForMessage<AccountProfile>(58U, AccountProfile.Parser);

		// Token: 0x04001A6C RID: 6764
		private readonly RepeatedField<AccountProfile> accountProfiles_ = new RepeatedField<AccountProfile>();

		// Token: 0x04001A6D RID: 6765
		public const int PreferencesFieldNumber = 8;

		// Token: 0x04001A6E RID: 6766
		private Preferences preferences_;

		// Token: 0x04001A6F RID: 6767
		public const int BannedFieldNumber = 9;

		// Token: 0x04001A70 RID: 6768
		private static readonly bool BannedDefaultValue = false;

		// Token: 0x04001A71 RID: 6769
		private bool banned_;
	}
}
