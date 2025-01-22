using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000333 RID: 819
	public sealed class UserData : IMessage<UserData>, IMessage, IEquatable<UserData>, IDeepCloneable<UserData>, IBufferMessage
	{
		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06005558 RID: 21848 RVA: 0x00149C44 File Offset: 0x00147E44
		[DebuggerNonUserCode]
		public static MessageParser<UserData> Parser
		{
			get
			{
				return UserData._parser;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06005559 RID: 21849 RVA: 0x00149C5C File Offset: 0x00147E5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonUserDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x0600555A RID: 21850 RVA: 0x00149C80 File Offset: 0x00147E80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UserData.Descriptor;
			}
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00149C97 File Offset: 0x00147E97
		[DebuggerNonUserCode]
		public UserData()
		{
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x00149CA4 File Offset: 0x00147EA4
		[DebuggerNonUserCode]
		public UserData(UserData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.battlenetId_ = other.battlenetId_;
			this.accountRegion_ = other.accountRegion_;
			this.country_ = other.country_;
			this.preferredRegion_ = other.preferredRegion_;
			this.platformName_ = other.platformName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00149D14 File Offset: 0x00147F14
		[DebuggerNonUserCode]
		public UserData Clone()
		{
			return new UserData(this);
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x00149D2C File Offset: 0x00147F2C
		// (set) Token: 0x0600555F RID: 21855 RVA: 0x00149D5D File Offset: 0x00147F5D
		[DebuggerNonUserCode]
		public uint BattlenetId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint battlenetIdDefaultValue;
				if (flag)
				{
					battlenetIdDefaultValue = this.battlenetId_;
				}
				else
				{
					battlenetIdDefaultValue = UserData.BattlenetIdDefaultValue;
				}
				return battlenetIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.battlenetId_ = value;
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x00149D78 File Offset: 0x00147F78
		[DebuggerNonUserCode]
		public bool HasBattlenetId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00149D95 File Offset: 0x00147F95
		[DebuggerNonUserCode]
		public void ClearBattlenetId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x00149DA8 File Offset: 0x00147FA8
		// (set) Token: 0x06005563 RID: 21859 RVA: 0x00149DC9 File Offset: 0x00147FC9
		[DebuggerNonUserCode]
		public string AccountRegion
		{
			get
			{
				return this.accountRegion_ ?? UserData.AccountRegionDefaultValue;
			}
			set
			{
				this.accountRegion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06005564 RID: 21860 RVA: 0x00149DE0 File Offset: 0x00147FE0
		[DebuggerNonUserCode]
		public bool HasAccountRegion
		{
			get
			{
				return this.accountRegion_ != null;
			}
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00149DFB File Offset: 0x00147FFB
		[DebuggerNonUserCode]
		public void ClearAccountRegion()
		{
			this.accountRegion_ = null;
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06005566 RID: 21862 RVA: 0x00149E08 File Offset: 0x00148008
		// (set) Token: 0x06005567 RID: 21863 RVA: 0x00149E29 File Offset: 0x00148029
		[DebuggerNonUserCode]
		public string Country
		{
			get
			{
				return this.country_ ?? UserData.CountryDefaultValue;
			}
			set
			{
				this.country_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x00149E40 File Offset: 0x00148040
		[DebuggerNonUserCode]
		public bool HasCountry
		{
			get
			{
				return this.country_ != null;
			}
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00149E5B File Offset: 0x0014805B
		[DebuggerNonUserCode]
		public void ClearCountry()
		{
			this.country_ = null;
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x0600556A RID: 21866 RVA: 0x00149E68 File Offset: 0x00148068
		// (set) Token: 0x0600556B RID: 21867 RVA: 0x00149E99 File Offset: 0x00148099
		[DebuggerNonUserCode]
		public uint PreferredRegion
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint preferredRegionDefaultValue;
				if (flag)
				{
					preferredRegionDefaultValue = this.preferredRegion_;
				}
				else
				{
					preferredRegionDefaultValue = UserData.PreferredRegionDefaultValue;
				}
				return preferredRegionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.preferredRegion_ = value;
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x0600556C RID: 21868 RVA: 0x00149EB4 File Offset: 0x001480B4
		[DebuggerNonUserCode]
		public bool HasPreferredRegion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x00149ED1 File Offset: 0x001480D1
		[DebuggerNonUserCode]
		public void ClearPreferredRegion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x0600556E RID: 21870 RVA: 0x00149EE4 File Offset: 0x001480E4
		// (set) Token: 0x0600556F RID: 21871 RVA: 0x00149F05 File Offset: 0x00148105
		[DebuggerNonUserCode]
		public string PlatformName
		{
			get
			{
				return this.platformName_ ?? UserData.PlatformNameDefaultValue;
			}
			set
			{
				this.platformName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06005570 RID: 21872 RVA: 0x00149F1C File Offset: 0x0014811C
		[DebuggerNonUserCode]
		public bool HasPlatformName
		{
			get
			{
				return this.platformName_ != null;
			}
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x00149F37 File Offset: 0x00148137
		[DebuggerNonUserCode]
		public void ClearPlatformName()
		{
			this.platformName_ = null;
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x00149F44 File Offset: 0x00148144
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UserData);
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x00149F64 File Offset: 0x00148164
		[DebuggerNonUserCode]
		public bool Equals(UserData other)
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
					bool flag4 = this.BattlenetId != other.BattlenetId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AccountRegion != other.AccountRegion;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Country != other.Country;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PreferredRegion != other.PreferredRegion;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.PlatformName != other.PlatformName;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x0014A030 File Offset: 0x00148230
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBattlenetId = this.HasBattlenetId;
			if (hasBattlenetId)
			{
				num ^= this.BattlenetId.GetHashCode();
			}
			bool hasAccountRegion = this.HasAccountRegion;
			if (hasAccountRegion)
			{
				num ^= this.AccountRegion.GetHashCode();
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num ^= this.Country.GetHashCode();
			}
			bool hasPreferredRegion = this.HasPreferredRegion;
			if (hasPreferredRegion)
			{
				num ^= this.PreferredRegion.GetHashCode();
			}
			bool hasPlatformName = this.HasPlatformName;
			if (hasPlatformName)
			{
				num ^= this.PlatformName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x0014A0EC File Offset: 0x001482EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x0014A104 File Offset: 0x00148304
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x0014A110 File Offset: 0x00148310
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBattlenetId = this.HasBattlenetId;
			if (hasBattlenetId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BattlenetId);
			}
			bool hasAccountRegion = this.HasAccountRegion;
			if (hasAccountRegion)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AccountRegion);
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Country);
			}
			bool hasPreferredRegion = this.HasPreferredRegion;
			if (hasPreferredRegion)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.PreferredRegion);
			}
			bool hasPlatformName = this.HasPlatformName;
			if (hasPlatformName)
			{
				output.WriteRawTag(42);
				output.WriteString(this.PlatformName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x0014A1E8 File Offset: 0x001483E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBattlenetId = this.HasBattlenetId;
			if (hasBattlenetId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BattlenetId);
			}
			bool hasAccountRegion = this.HasAccountRegion;
			if (hasAccountRegion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AccountRegion);
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Country);
			}
			bool hasPreferredRegion = this.HasPreferredRegion;
			if (hasPreferredRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PreferredRegion);
			}
			bool hasPlatformName = this.HasPlatformName;
			if (hasPlatformName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlatformName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x0014A2B0 File Offset: 0x001484B0
		[DebuggerNonUserCode]
		public void MergeFrom(UserData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBattlenetId = other.HasBattlenetId;
				if (hasBattlenetId)
				{
					this.BattlenetId = other.BattlenetId;
				}
				bool hasAccountRegion = other.HasAccountRegion;
				if (hasAccountRegion)
				{
					this.AccountRegion = other.AccountRegion;
				}
				bool hasCountry = other.HasCountry;
				if (hasCountry)
				{
					this.Country = other.Country;
				}
				bool hasPreferredRegion = other.HasPreferredRegion;
				if (hasPreferredRegion)
				{
					this.PreferredRegion = other.PreferredRegion;
				}
				bool hasPlatformName = other.HasPlatformName;
				if (hasPlatformName)
				{
					this.PlatformName = other.PlatformName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x0014A364 File Offset: 0x00148564
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x0014A370 File Offset: 0x00148570
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0032;
						}
						this.AccountRegion = input.ReadString();
					}
					else
					{
						this.BattlenetId = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0032;
						}
						this.PlatformName = input.ReadString();
					}
					else
					{
						this.PreferredRegion = input.ReadUInt32();
					}
				}
				else
				{
					this.Country = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026C9 RID: 9929
		private static readonly MessageParser<UserData> _parser = new MessageParser<UserData>(() => new UserData());

		// Token: 0x040026CA RID: 9930
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026CB RID: 9931
		private int _hasBits0;

		// Token: 0x040026CC RID: 9932
		public const int BattlenetIdFieldNumber = 1;

		// Token: 0x040026CD RID: 9933
		private static readonly uint BattlenetIdDefaultValue = 0U;

		// Token: 0x040026CE RID: 9934
		private uint battlenetId_;

		// Token: 0x040026CF RID: 9935
		public const int AccountRegionFieldNumber = 2;

		// Token: 0x040026D0 RID: 9936
		private static readonly string AccountRegionDefaultValue = "";

		// Token: 0x040026D1 RID: 9937
		private string accountRegion_;

		// Token: 0x040026D2 RID: 9938
		public const int CountryFieldNumber = 3;

		// Token: 0x040026D3 RID: 9939
		private static readonly string CountryDefaultValue = "";

		// Token: 0x040026D4 RID: 9940
		private string country_;

		// Token: 0x040026D5 RID: 9941
		public const int PreferredRegionFieldNumber = 4;

		// Token: 0x040026D6 RID: 9942
		private static readonly uint PreferredRegionDefaultValue = 0U;

		// Token: 0x040026D7 RID: 9943
		private uint preferredRegion_;

		// Token: 0x040026D8 RID: 9944
		public const int PlatformNameFieldNumber = 5;

		// Token: 0x040026D9 RID: 9945
		private static readonly string PlatformNameDefaultValue = "";

		// Token: 0x040026DA RID: 9946
		private string platformName_;
	}
}
