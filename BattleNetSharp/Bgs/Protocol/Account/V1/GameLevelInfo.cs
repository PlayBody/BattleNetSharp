using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000741 RID: 1857
	public sealed class GameLevelInfo : IMessage<GameLevelInfo>, IMessage, IEquatable<GameLevelInfo>, IDeepCloneable<GameLevelInfo>, IBufferMessage
	{
		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600AA8E RID: 43662 RVA: 0x00298D04 File Offset: 0x00296F04
		[DebuggerNonUserCode]
		public static MessageParser<GameLevelInfo> Parser
		{
			get
			{
				return GameLevelInfo._parser;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600AA8F RID: 43663 RVA: 0x00298D1C File Offset: 0x00296F1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600AA90 RID: 43664 RVA: 0x00298D40 File Offset: 0x00296F40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600AA91 RID: 43665 RVA: 0x00298D57 File Offset: 0x00296F57
		[DebuggerNonUserCode]
		public GameLevelInfo()
		{
		}

		// Token: 0x0600AA92 RID: 43666 RVA: 0x00298D6C File Offset: 0x00296F6C
		[DebuggerNonUserCode]
		public GameLevelInfo(GameLevelInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.isTrial_ = other.isTrial_;
			this.isLifetime_ = other.isLifetime_;
			this.isRestricted_ = other.isRestricted_;
			this.isBeta_ = other.isBeta_;
			this.name_ = other.name_;
			this.program_ = other.program_;
			this.licenses_ = other.licenses_.Clone();
			this.realmPermissions_ = other.realmPermissions_;
			this.lastLogoutTimeMs_ = other.lastLogoutTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA93 RID: 43667 RVA: 0x00298E10 File Offset: 0x00297010
		[DebuggerNonUserCode]
		public GameLevelInfo Clone()
		{
			return new GameLevelInfo(this);
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600AA94 RID: 43668 RVA: 0x00298E28 File Offset: 0x00297028
		// (set) Token: 0x0600AA95 RID: 43669 RVA: 0x00298E59 File Offset: 0x00297059
		[DebuggerNonUserCode]
		public bool IsTrial
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isTrialDefaultValue;
				if (flag)
				{
					isTrialDefaultValue = this.isTrial_;
				}
				else
				{
					isTrialDefaultValue = GameLevelInfo.IsTrialDefaultValue;
				}
				return isTrialDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isTrial_ = value;
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600AA96 RID: 43670 RVA: 0x00298E74 File Offset: 0x00297074
		[DebuggerNonUserCode]
		public bool HasIsTrial
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x00298E91 File Offset: 0x00297091
		[DebuggerNonUserCode]
		public void ClearIsTrial()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600AA98 RID: 43672 RVA: 0x00298EA4 File Offset: 0x002970A4
		// (set) Token: 0x0600AA99 RID: 43673 RVA: 0x00298ED5 File Offset: 0x002970D5
		[DebuggerNonUserCode]
		public bool IsLifetime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isLifetimeDefaultValue;
				if (flag)
				{
					isLifetimeDefaultValue = this.isLifetime_;
				}
				else
				{
					isLifetimeDefaultValue = GameLevelInfo.IsLifetimeDefaultValue;
				}
				return isLifetimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isLifetime_ = value;
			}
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600AA9A RID: 43674 RVA: 0x00298EF0 File Offset: 0x002970F0
		[DebuggerNonUserCode]
		public bool HasIsLifetime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x00298F0D File Offset: 0x0029710D
		[DebuggerNonUserCode]
		public void ClearIsLifetime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600AA9C RID: 43676 RVA: 0x00298F20 File Offset: 0x00297120
		// (set) Token: 0x0600AA9D RID: 43677 RVA: 0x00298F51 File Offset: 0x00297151
		[DebuggerNonUserCode]
		public bool IsRestricted
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isRestrictedDefaultValue;
				if (flag)
				{
					isRestrictedDefaultValue = this.isRestricted_;
				}
				else
				{
					isRestrictedDefaultValue = GameLevelInfo.IsRestrictedDefaultValue;
				}
				return isRestrictedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isRestricted_ = value;
			}
		}

		// Token: 0x170034B6 RID: 13494
		// (get) Token: 0x0600AA9E RID: 43678 RVA: 0x00298F6C File Offset: 0x0029716C
		[DebuggerNonUserCode]
		public bool HasIsRestricted
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x00298F89 File Offset: 0x00297189
		[DebuggerNonUserCode]
		public void ClearIsRestricted()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170034B7 RID: 13495
		// (get) Token: 0x0600AAA0 RID: 43680 RVA: 0x00298F9C File Offset: 0x0029719C
		// (set) Token: 0x0600AAA1 RID: 43681 RVA: 0x00298FCD File Offset: 0x002971CD
		[DebuggerNonUserCode]
		public bool IsBeta
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isBetaDefaultValue;
				if (flag)
				{
					isBetaDefaultValue = this.isBeta_;
				}
				else
				{
					isBetaDefaultValue = GameLevelInfo.IsBetaDefaultValue;
				}
				return isBetaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isBeta_ = value;
			}
		}

		// Token: 0x170034B8 RID: 13496
		// (get) Token: 0x0600AAA2 RID: 43682 RVA: 0x00298FE8 File Offset: 0x002971E8
		[DebuggerNonUserCode]
		public bool HasIsBeta
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x00299005 File Offset: 0x00297205
		[DebuggerNonUserCode]
		public void ClearIsBeta()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170034B9 RID: 13497
		// (get) Token: 0x0600AAA4 RID: 43684 RVA: 0x00299018 File Offset: 0x00297218
		// (set) Token: 0x0600AAA5 RID: 43685 RVA: 0x00299039 File Offset: 0x00297239
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? GameLevelInfo.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170034BA RID: 13498
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x00299050 File Offset: 0x00297250
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600AAA7 RID: 43687 RVA: 0x0029906B File Offset: 0x0029726B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170034BB RID: 13499
		// (get) Token: 0x0600AAA8 RID: 43688 RVA: 0x00299078 File Offset: 0x00297278
		// (set) Token: 0x0600AAA9 RID: 43689 RVA: 0x002990AA File Offset: 0x002972AA
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = GameLevelInfo.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.program_ = value;
			}
		}

		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600AAAA RID: 43690 RVA: 0x002990C4 File Offset: 0x002972C4
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600AAAB RID: 43691 RVA: 0x002990E2 File Offset: 0x002972E2
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600AAAC RID: 43692 RVA: 0x002990F4 File Offset: 0x002972F4
		[DebuggerNonUserCode]
		public RepeatedField<AccountLicense> Licenses
		{
			get
			{
				return this.licenses_;
			}
		}

		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600AAAD RID: 43693 RVA: 0x0029910C File Offset: 0x0029730C
		// (set) Token: 0x0600AAAE RID: 43694 RVA: 0x0029913E File Offset: 0x0029733E
		[DebuggerNonUserCode]
		public uint RealmPermissions
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint realmPermissionsDefaultValue;
				if (flag)
				{
					realmPermissionsDefaultValue = this.realmPermissions_;
				}
				else
				{
					realmPermissionsDefaultValue = GameLevelInfo.RealmPermissionsDefaultValue;
				}
				return realmPermissionsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.realmPermissions_ = value;
			}
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600AAAF RID: 43695 RVA: 0x00299158 File Offset: 0x00297358
		[DebuggerNonUserCode]
		public bool HasRealmPermissions
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x00299176 File Offset: 0x00297376
		[DebuggerNonUserCode]
		public void ClearRealmPermissions()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600AAB1 RID: 43697 RVA: 0x00299188 File Offset: 0x00297388
		// (set) Token: 0x0600AAB2 RID: 43698 RVA: 0x002991BA File Offset: 0x002973BA
		[DebuggerNonUserCode]
		public ulong LastLogoutTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				ulong lastLogoutTimeMsDefaultValue;
				if (flag)
				{
					lastLogoutTimeMsDefaultValue = this.lastLogoutTimeMs_;
				}
				else
				{
					lastLogoutTimeMsDefaultValue = GameLevelInfo.LastLogoutTimeMsDefaultValue;
				}
				return lastLogoutTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.lastLogoutTimeMs_ = value;
			}
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600AAB3 RID: 43699 RVA: 0x002991D4 File Offset: 0x002973D4
		[DebuggerNonUserCode]
		public bool HasLastLogoutTimeMs
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600AAB4 RID: 43700 RVA: 0x002991F2 File Offset: 0x002973F2
		[DebuggerNonUserCode]
		public void ClearLastLogoutTimeMs()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x0600AAB5 RID: 43701 RVA: 0x00299204 File Offset: 0x00297404
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameLevelInfo);
		}

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x00299224 File Offset: 0x00297424
		[DebuggerNonUserCode]
		public bool Equals(GameLevelInfo other)
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
					bool flag4 = this.IsTrial != other.IsTrial;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsLifetime != other.IsLifetime;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsRestricted != other.IsRestricted;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsBeta != other.IsBeta;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Name != other.Name;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Program != other.Program;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.licenses_.Equals(other.licenses_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.RealmPermissions != other.RealmPermissions;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.LastLogoutTimeMs != other.LastLogoutTimeMs;
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

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x0029936C File Offset: 0x0029756C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIsTrial = this.HasIsTrial;
			if (hasIsTrial)
			{
				num ^= this.IsTrial.GetHashCode();
			}
			bool hasIsLifetime = this.HasIsLifetime;
			if (hasIsLifetime)
			{
				num ^= this.IsLifetime.GetHashCode();
			}
			bool hasIsRestricted = this.HasIsRestricted;
			if (hasIsRestricted)
			{
				num ^= this.IsRestricted.GetHashCode();
			}
			bool hasIsBeta = this.HasIsBeta;
			if (hasIsBeta)
			{
				num ^= this.IsBeta.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			num ^= this.licenses_.GetHashCode();
			bool hasRealmPermissions = this.HasRealmPermissions;
			if (hasRealmPermissions)
			{
				num ^= this.RealmPermissions.GetHashCode();
			}
			bool hasLastLogoutTimeMs = this.HasLastLogoutTimeMs;
			if (hasLastLogoutTimeMs)
			{
				num ^= this.LastLogoutTimeMs.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAB8 RID: 43704 RVA: 0x00299494 File Offset: 0x00297694
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AAB9 RID: 43705 RVA: 0x002994AC File Offset: 0x002976AC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AABA RID: 43706 RVA: 0x002994B8 File Offset: 0x002976B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIsTrial = this.HasIsTrial;
			if (hasIsTrial)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsTrial);
			}
			bool hasIsLifetime = this.HasIsLifetime;
			if (hasIsLifetime)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsLifetime);
			}
			bool hasIsRestricted = this.HasIsRestricted;
			if (hasIsRestricted)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsRestricted);
			}
			bool hasIsBeta = this.HasIsBeta;
			if (hasIsBeta)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsBeta);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Name);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(77);
				output.WriteFixed32(this.Program);
			}
			this.licenses_.WriteTo(ref output, GameLevelInfo._repeated_licenses_codec);
			bool hasRealmPermissions = this.HasRealmPermissions;
			if (hasRealmPermissions)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.RealmPermissions);
			}
			bool hasLastLogoutTimeMs = this.HasLastLogoutTimeMs;
			if (hasLastLogoutTimeMs)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.LastLogoutTimeMs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AABB RID: 43707 RVA: 0x00299610 File Offset: 0x00297810
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIsTrial = this.HasIsTrial;
			if (hasIsTrial)
			{
				num += 2;
			}
			bool hasIsLifetime = this.HasIsLifetime;
			if (hasIsLifetime)
			{
				num += 2;
			}
			bool hasIsRestricted = this.HasIsRestricted;
			if (hasIsRestricted)
			{
				num += 2;
			}
			bool hasIsBeta = this.HasIsBeta;
			if (hasIsBeta)
			{
				num += 2;
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			num += this.licenses_.CalculateSize(GameLevelInfo._repeated_licenses_codec);
			bool hasRealmPermissions = this.HasRealmPermissions;
			if (hasRealmPermissions)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RealmPermissions);
			}
			bool hasLastLogoutTimeMs = this.HasLastLogoutTimeMs;
			if (hasLastLogoutTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastLogoutTimeMs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AABC RID: 43708 RVA: 0x00299708 File Offset: 0x00297908
		[DebuggerNonUserCode]
		public void MergeFrom(GameLevelInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIsTrial = other.HasIsTrial;
				if (hasIsTrial)
				{
					this.IsTrial = other.IsTrial;
				}
				bool hasIsLifetime = other.HasIsLifetime;
				if (hasIsLifetime)
				{
					this.IsLifetime = other.IsLifetime;
				}
				bool hasIsRestricted = other.HasIsRestricted;
				if (hasIsRestricted)
				{
					this.IsRestricted = other.IsRestricted;
				}
				bool hasIsBeta = other.HasIsBeta;
				if (hasIsBeta)
				{
					this.IsBeta = other.IsBeta;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this.licenses_.Add(other.licenses_);
				bool hasRealmPermissions = other.HasRealmPermissions;
				if (hasRealmPermissions)
				{
					this.RealmPermissions = other.RealmPermissions;
				}
				bool hasLastLogoutTimeMs = other.HasLastLogoutTimeMs;
				if (hasLastLogoutTimeMs)
				{
					this.LastLogoutTimeMs = other.LastLogoutTimeMs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AABD RID: 43709 RVA: 0x0029981F File Offset: 0x00297A1F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AABE RID: 43710 RVA: 0x0029982C File Offset: 0x00297A2C
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
					if (num3 <= 40U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_006B;
							}
							this.IsLifetime = input.ReadBool();
						}
						else
						{
							this.IsTrial = input.ReadBool();
						}
					}
					else if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_006B;
						}
						this.IsBeta = input.ReadBool();
					}
					else
					{
						this.IsRestricted = input.ReadBool();
					}
				}
				else if (num3 <= 77U)
				{
					if (num3 != 66U)
					{
						if (num3 != 77U)
						{
							goto IL_006B;
						}
						this.Program = input.ReadFixed32();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 82U)
				{
					if (num3 != 88U)
					{
						if (num3 != 96U)
						{
							goto IL_006B;
						}
						this.LastLogoutTimeMs = input.ReadUInt64();
					}
					else
					{
						this.RealmPermissions = input.ReadUInt32();
					}
				}
				else
				{
					this.licenses_.AddEntriesFrom(ref input, GameLevelInfo._repeated_licenses_codec);
				}
				continue;
				IL_006B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CCF RID: 19663
		private static readonly MessageParser<GameLevelInfo> _parser = new MessageParser<GameLevelInfo>(() => new GameLevelInfo());

		// Token: 0x04004CD0 RID: 19664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CD1 RID: 19665
		private int _hasBits0;

		// Token: 0x04004CD2 RID: 19666
		public const int IsTrialFieldNumber = 4;

		// Token: 0x04004CD3 RID: 19667
		private static readonly bool IsTrialDefaultValue = false;

		// Token: 0x04004CD4 RID: 19668
		private bool isTrial_;

		// Token: 0x04004CD5 RID: 19669
		public const int IsLifetimeFieldNumber = 5;

		// Token: 0x04004CD6 RID: 19670
		private static readonly bool IsLifetimeDefaultValue = false;

		// Token: 0x04004CD7 RID: 19671
		private bool isLifetime_;

		// Token: 0x04004CD8 RID: 19672
		public const int IsRestrictedFieldNumber = 6;

		// Token: 0x04004CD9 RID: 19673
		private static readonly bool IsRestrictedDefaultValue = false;

		// Token: 0x04004CDA RID: 19674
		private bool isRestricted_;

		// Token: 0x04004CDB RID: 19675
		public const int IsBetaFieldNumber = 7;

		// Token: 0x04004CDC RID: 19676
		private static readonly bool IsBetaDefaultValue = false;

		// Token: 0x04004CDD RID: 19677
		private bool isBeta_;

		// Token: 0x04004CDE RID: 19678
		public const int NameFieldNumber = 8;

		// Token: 0x04004CDF RID: 19679
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004CE0 RID: 19680
		private string name_;

		// Token: 0x04004CE1 RID: 19681
		public const int ProgramFieldNumber = 9;

		// Token: 0x04004CE2 RID: 19682
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004CE3 RID: 19683
		private uint program_;

		// Token: 0x04004CE4 RID: 19684
		public const int LicensesFieldNumber = 10;

		// Token: 0x04004CE5 RID: 19685
		private static readonly FieldCodec<AccountLicense> _repeated_licenses_codec = FieldCodec.ForMessage<AccountLicense>(82U, AccountLicense.Parser);

		// Token: 0x04004CE6 RID: 19686
		private readonly RepeatedField<AccountLicense> licenses_ = new RepeatedField<AccountLicense>();

		// Token: 0x04004CE7 RID: 19687
		public const int RealmPermissionsFieldNumber = 11;

		// Token: 0x04004CE8 RID: 19688
		private static readonly uint RealmPermissionsDefaultValue = 0U;

		// Token: 0x04004CE9 RID: 19689
		private uint realmPermissions_;

		// Token: 0x04004CEA RID: 19690
		public const int LastLogoutTimeMsFieldNumber = 12;

		// Token: 0x04004CEB RID: 19691
		private static readonly ulong LastLogoutTimeMsDefaultValue = 0UL;

		// Token: 0x04004CEC RID: 19692
		private ulong lastLogoutTimeMs_;
	}
}
