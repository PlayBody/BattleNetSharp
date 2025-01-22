using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000137 RID: 311
	public sealed class HeroMiniProfile : IMessage<HeroMiniProfile>, IMessage, IEquatable<HeroMiniProfile>, IDeepCloneable<HeroMiniProfile>, IBufferMessage
	{
		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00079790 File Offset: 0x00077990
		[DebuggerNonUserCode]
		public static MessageParser<HeroMiniProfile> Parser
		{
			get
			{
				return HeroMiniProfile._parser;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x000797A8 File Offset: 0x000779A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x000797CC File Offset: 0x000779CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroMiniProfile.Descriptor;
			}
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000797E3 File Offset: 0x000779E3
		[DebuggerNonUserCode]
		public HeroMiniProfile()
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x000797F0 File Offset: 0x000779F0
		[DebuggerNonUserCode]
		public HeroMiniProfile(HeroMiniProfile other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroId_ = other.heroId_;
			this.heroName_ = other.heroName_;
			this.heroGbidClass_ = other.heroGbidClass_;
			this.heroFlags_ = other.heroFlags_;
			this.heroLevel_ = other.heroLevel_;
			this.heroVisualEquipment_ = ((other.heroVisualEquipment_ != null) ? other.heroVisualEquipment_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0007987C File Offset: 0x00077A7C
		[DebuggerNonUserCode]
		public HeroMiniProfile Clone()
		{
			return new HeroMiniProfile(this);
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00079894 File Offset: 0x00077A94
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x000798B5 File Offset: 0x00077AB5
		[DebuggerNonUserCode]
		public ByteString HeroId
		{
			get
			{
				return this.heroId_ ?? HeroMiniProfile.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x000798CC File Offset: 0x00077ACC
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x000798EA File Offset: 0x00077AEA
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x000798F4 File Offset: 0x00077AF4
		// (set) Token: 0x06001F7D RID: 8061 RVA: 0x00079915 File Offset: 0x00077B15
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? HeroMiniProfile.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0007992C File Offset: 0x00077B2C
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00079947 File Offset: 0x00077B47
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00079954 File Offset: 0x00077B54
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x00079985 File Offset: 0x00077B85
		[DebuggerNonUserCode]
		public int HeroGbidClass
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int heroGbidClassDefaultValue;
				if (flag)
				{
					heroGbidClassDefaultValue = this.heroGbidClass_;
				}
				else
				{
					heroGbidClassDefaultValue = HeroMiniProfile.HeroGbidClassDefaultValue;
				}
				return heroGbidClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.heroGbidClass_ = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000799A0 File Offset: 0x00077BA0
		[DebuggerNonUserCode]
		public bool HasHeroGbidClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x000799BD File Offset: 0x00077BBD
		[DebuggerNonUserCode]
		public void ClearHeroGbidClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x000799D0 File Offset: 0x00077BD0
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x00079A01 File Offset: 0x00077C01
		[DebuggerNonUserCode]
		public uint HeroFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint heroFlagsDefaultValue;
				if (flag)
				{
					heroFlagsDefaultValue = this.heroFlags_;
				}
				else
				{
					heroFlagsDefaultValue = HeroMiniProfile.HeroFlagsDefaultValue;
				}
				return heroFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.heroFlags_ = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00079A1C File Offset: 0x00077C1C
		[DebuggerNonUserCode]
		public bool HasHeroFlags
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00079A39 File Offset: 0x00077C39
		[DebuggerNonUserCode]
		public void ClearHeroFlags()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00079A4C File Offset: 0x00077C4C
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00079A7D File Offset: 0x00077C7D
		[DebuggerNonUserCode]
		public uint HeroLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint heroLevelDefaultValue;
				if (flag)
				{
					heroLevelDefaultValue = this.heroLevel_;
				}
				else
				{
					heroLevelDefaultValue = HeroMiniProfile.HeroLevelDefaultValue;
				}
				return heroLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.heroLevel_ = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00079A98 File Offset: 0x00077C98
		[DebuggerNonUserCode]
		public bool HasHeroLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00079AB5 File Offset: 0x00077CB5
		[DebuggerNonUserCode]
		public void ClearHeroLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00079AC8 File Offset: 0x00077CC8
		// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00079AE0 File Offset: 0x00077CE0
		[DebuggerNonUserCode]
		public VisualEquipment HeroVisualEquipment
		{
			get
			{
				return this.heroVisualEquipment_;
			}
			set
			{
				this.heroVisualEquipment_ = value;
			}
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00079AEC File Offset: 0x00077CEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroMiniProfile);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00079B0C File Offset: 0x00077D0C
		[DebuggerNonUserCode]
		public bool Equals(HeroMiniProfile other)
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
					bool flag4 = this.HeroId != other.HeroId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HeroName != other.HeroName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HeroGbidClass != other.HeroGbidClass;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.HeroFlags != other.HeroFlags;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.HeroLevel != other.HeroLevel;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.HeroVisualEquipment, other.HeroVisualEquipment);
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

		// Token: 0x06001F90 RID: 8080 RVA: 0x00079BF8 File Offset: 0x00077DF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool hasHeroGbidClass = this.HasHeroGbidClass;
			if (hasHeroGbidClass)
			{
				num ^= this.HeroGbidClass.GetHashCode();
			}
			bool hasHeroFlags = this.HasHeroFlags;
			if (hasHeroFlags)
			{
				num ^= this.HeroFlags.GetHashCode();
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				num ^= this.HeroLevel.GetHashCode();
			}
			bool flag = this.heroVisualEquipment_ != null;
			if (flag)
			{
				num ^= this.HeroVisualEquipment.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00079CD4 File Offset: 0x00077ED4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00079CEC File Offset: 0x00077EEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00079CF8 File Offset: 0x00077EF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.HeroId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.HeroName);
			}
			bool hasHeroGbidClass = this.HasHeroGbidClass;
			if (hasHeroGbidClass)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.HeroGbidClass);
			}
			bool hasHeroFlags = this.HasHeroFlags;
			if (hasHeroFlags)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HeroFlags);
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HeroLevel);
			}
			bool flag = this.heroVisualEquipment_ != null;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.HeroVisualEquipment);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00079DF8 File Offset: 0x00077FF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.HeroId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool hasHeroGbidClass = this.HasHeroGbidClass;
			if (hasHeroGbidClass)
			{
				num += 5;
			}
			bool hasHeroFlags = this.HasHeroFlags;
			if (hasHeroFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeroFlags);
			}
			bool hasHeroLevel = this.HasHeroLevel;
			if (hasHeroLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeroLevel);
			}
			bool flag = this.heroVisualEquipment_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroVisualEquipment);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00079ED4 File Offset: 0x000780D4
		[DebuggerNonUserCode]
		public void MergeFrom(HeroMiniProfile other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				bool hasHeroGbidClass = other.HasHeroGbidClass;
				if (hasHeroGbidClass)
				{
					this.HeroGbidClass = other.HeroGbidClass;
				}
				bool hasHeroFlags = other.HasHeroFlags;
				if (hasHeroFlags)
				{
					this.HeroFlags = other.HeroFlags;
				}
				bool hasHeroLevel = other.HasHeroLevel;
				if (hasHeroLevel)
				{
					this.HeroLevel = other.HeroLevel;
				}
				bool flag2 = other.heroVisualEquipment_ != null;
				if (flag2)
				{
					bool flag3 = this.heroVisualEquipment_ == null;
					if (flag3)
					{
						this.HeroVisualEquipment = new VisualEquipment();
					}
					this.HeroVisualEquipment.MergeFrom(other.HeroVisualEquipment);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00079FC8 File Offset: 0x000781C8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00079FD4 File Offset: 0x000781D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 29U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 29U)
							{
								goto IL_003A;
							}
							this.HeroGbidClass = input.ReadSFixed32();
						}
						else
						{
							this.HeroName = input.ReadString();
						}
					}
					else
					{
						this.HeroId = input.ReadBytes();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_003A;
						}
						bool flag = this.heroVisualEquipment_ == null;
						if (flag)
						{
							this.HeroVisualEquipment = new VisualEquipment();
						}
						input.ReadMessage(this.HeroVisualEquipment);
					}
					else
					{
						this.HeroLevel = input.ReadUInt32();
					}
				}
				else
				{
					this.HeroFlags = input.ReadUInt32();
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DAD RID: 3501
		private static readonly MessageParser<HeroMiniProfile> _parser = new MessageParser<HeroMiniProfile>(() => new HeroMiniProfile());

		// Token: 0x04000DAE RID: 3502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DAF RID: 3503
		private int _hasBits0;

		// Token: 0x04000DB0 RID: 3504
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04000DB1 RID: 3505
		private static readonly ByteString HeroIdDefaultValue = ByteString.Empty;

		// Token: 0x04000DB2 RID: 3506
		private ByteString heroId_;

		// Token: 0x04000DB3 RID: 3507
		public const int HeroNameFieldNumber = 2;

		// Token: 0x04000DB4 RID: 3508
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x04000DB5 RID: 3509
		private string heroName_;

		// Token: 0x04000DB6 RID: 3510
		public const int HeroGbidClassFieldNumber = 3;

		// Token: 0x04000DB7 RID: 3511
		private static readonly int HeroGbidClassDefaultValue = 0;

		// Token: 0x04000DB8 RID: 3512
		private int heroGbidClass_;

		// Token: 0x04000DB9 RID: 3513
		public const int HeroFlagsFieldNumber = 4;

		// Token: 0x04000DBA RID: 3514
		private static readonly uint HeroFlagsDefaultValue = 0U;

		// Token: 0x04000DBB RID: 3515
		private uint heroFlags_;

		// Token: 0x04000DBC RID: 3516
		public const int HeroLevelFieldNumber = 5;

		// Token: 0x04000DBD RID: 3517
		private static readonly uint HeroLevelDefaultValue = 0U;

		// Token: 0x04000DBE RID: 3518
		private uint heroLevel_;

		// Token: 0x04000DBF RID: 3519
		public const int HeroVisualEquipmentFieldNumber = 6;

		// Token: 0x04000DC0 RID: 3520
		private VisualEquipment heroVisualEquipment_;
	}
}
