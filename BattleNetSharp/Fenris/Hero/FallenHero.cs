using System;
using System.Diagnostics;
using Fenris.Profile;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000191 RID: 401
	public sealed class FallenHero : IMessage<FallenHero>, IMessage, IEquatable<FallenHero>, IDeepCloneable<FallenHero>, IBufferMessage
	{
		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000A61D0 File Offset: 0x000A43D0
		[DebuggerNonUserCode]
		public static MessageParser<FallenHero> Parser
		{
			get
			{
				return FallenHero._parser;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000A61E8 File Offset: 0x000A43E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000A620C File Offset: 0x000A440C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FallenHero.Descriptor;
			}
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000A6223 File Offset: 0x000A4423
		[DebuggerNonUserCode]
		public FallenHero()
		{
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000A6230 File Offset: 0x000A4430
		[DebuggerNonUserCode]
		public FallenHero(FallenHero other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.profile_ = ((other.profile_ != null) ? other.profile_.Clone() : null);
			this.heroName_ = other.heroName_;
			this.appearanceCustomization_ = ((other.appearanceCustomization_ != null) ? other.appearanceCustomization_.Clone() : null);
			this.timePlayed_ = other.timePlayed_;
			this.createTime_ = other.createTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x000A62C0 File Offset: 0x000A44C0
		[DebuggerNonUserCode]
		public FallenHero Clone()
		{
			return new FallenHero(this);
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000A62D8 File Offset: 0x000A44D8
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x000A62F0 File Offset: 0x000A44F0
		[DebuggerNonUserCode]
		public HeroProfile Profile
		{
			get
			{
				return this.profile_;
			}
			set
			{
				this.profile_ = value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000A62FC File Offset: 0x000A44FC
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x000A631D File Offset: 0x000A451D
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? FallenHero.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000A6334 File Offset: 0x000A4534
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x000A634F File Offset: 0x000A454F
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000A635C File Offset: 0x000A455C
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x000A6374 File Offset: 0x000A4574
		[DebuggerNonUserCode]
		public AppearanceCustomization AppearanceCustomization
		{
			get
			{
				return this.appearanceCustomization_;
			}
			set
			{
				this.appearanceCustomization_ = value;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000A6380 File Offset: 0x000A4580
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x000A63B1 File Offset: 0x000A45B1
		[DebuggerNonUserCode]
		public uint TimePlayed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint timePlayedDefaultValue;
				if (flag)
				{
					timePlayedDefaultValue = this.timePlayed_;
				}
				else
				{
					timePlayedDefaultValue = FallenHero.TimePlayedDefaultValue;
				}
				return timePlayedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.timePlayed_ = value;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000A63CC File Offset: 0x000A45CC
		[DebuggerNonUserCode]
		public bool HasTimePlayed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x000A63E9 File Offset: 0x000A45E9
		[DebuggerNonUserCode]
		public void ClearTimePlayed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000A63FC File Offset: 0x000A45FC
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x000A642D File Offset: 0x000A462D
		[DebuggerNonUserCode]
		public ulong CreateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong createTimeDefaultValue;
				if (flag)
				{
					createTimeDefaultValue = this.createTime_;
				}
				else
				{
					createTimeDefaultValue = FallenHero.CreateTimeDefaultValue;
				}
				return createTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.createTime_ = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x000A6448 File Offset: 0x000A4648
		[DebuggerNonUserCode]
		public bool HasCreateTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000A6465 File Offset: 0x000A4665
		[DebuggerNonUserCode]
		public void ClearCreateTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000A6478 File Offset: 0x000A4678
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FallenHero);
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000A6498 File Offset: 0x000A4698
		[DebuggerNonUserCode]
		public bool Equals(FallenHero other)
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
					bool flag4 = !object.Equals(this.Profile, other.Profile);
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
							bool flag6 = !object.Equals(this.AppearanceCustomization, other.AppearanceCustomization);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TimePlayed != other.TimePlayed;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CreateTime != other.CreateTime;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000A656C File Offset: 0x000A476C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.profile_ != null;
			if (flag)
			{
				num ^= this.Profile.GetHashCode();
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool flag2 = this.appearanceCustomization_ != null;
			if (flag2)
			{
				num ^= this.AppearanceCustomization.GetHashCode();
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num ^= this.TimePlayed.GetHashCode();
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000A662C File Offset: 0x000A482C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000A6644 File Offset: 0x000A4844
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000A6650 File Offset: 0x000A4850
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.profile_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Profile);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.HeroName);
			}
			bool flag2 = this.appearanceCustomization_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.AppearanceCustomization);
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.TimePlayed);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.CreateTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000A6730 File Offset: 0x000A4930
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.profile_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Profile);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool flag2 = this.appearanceCustomization_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AppearanceCustomization);
			}
			bool hasTimePlayed = this.HasTimePlayed;
			if (hasTimePlayed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimePlayed);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreateTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000A67FC File Offset: 0x000A49FC
		[DebuggerNonUserCode]
		public void MergeFrom(FallenHero other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.profile_ != null;
				if (flag2)
				{
					bool flag3 = this.profile_ == null;
					if (flag3)
					{
						this.Profile = new HeroProfile();
					}
					this.Profile.MergeFrom(other.Profile);
				}
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				bool flag4 = other.appearanceCustomization_ != null;
				if (flag4)
				{
					bool flag5 = this.appearanceCustomization_ == null;
					if (flag5)
					{
						this.AppearanceCustomization = new AppearanceCustomization();
					}
					this.AppearanceCustomization.MergeFrom(other.AppearanceCustomization);
				}
				bool hasTimePlayed = other.HasTimePlayed;
				if (hasTimePlayed)
				{
					this.TimePlayed = other.TimePlayed;
				}
				bool hasCreateTime = other.HasCreateTime;
				if (hasCreateTime)
				{
					this.CreateTime = other.CreateTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x000A68FA File Offset: 0x000A4AFA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000A6908 File Offset: 0x000A4B08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							goto IL_0039;
						}
						this.HeroName = input.ReadString();
					}
					else
					{
						bool flag = this.profile_ == null;
						if (flag)
						{
							this.Profile = new HeroProfile();
						}
						input.ReadMessage(this.Profile);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.CreateTime = input.ReadUInt64();
					}
					else
					{
						this.TimePlayed = input.ReadUInt32();
					}
				}
				else
				{
					bool flag2 = this.appearanceCustomization_ == null;
					if (flag2)
					{
						this.AppearanceCustomization = new AppearanceCustomization();
					}
					input.ReadMessage(this.AppearanceCustomization);
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400130A RID: 4874
		private static readonly MessageParser<FallenHero> _parser = new MessageParser<FallenHero>(() => new FallenHero());

		// Token: 0x0400130B RID: 4875
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400130C RID: 4876
		private int _hasBits0;

		// Token: 0x0400130D RID: 4877
		public const int ProfileFieldNumber = 2;

		// Token: 0x0400130E RID: 4878
		private HeroProfile profile_;

		// Token: 0x0400130F RID: 4879
		public const int HeroNameFieldNumber = 3;

		// Token: 0x04001310 RID: 4880
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x04001311 RID: 4881
		private string heroName_;

		// Token: 0x04001312 RID: 4882
		public const int AppearanceCustomizationFieldNumber = 4;

		// Token: 0x04001313 RID: 4883
		private AppearanceCustomization appearanceCustomization_;

		// Token: 0x04001314 RID: 4884
		public const int TimePlayedFieldNumber = 5;

		// Token: 0x04001315 RID: 4885
		private static readonly uint TimePlayedDefaultValue = 0U;

		// Token: 0x04001316 RID: 4886
		private uint timePlayed_;

		// Token: 0x04001317 RID: 4887
		public const int CreateTimeFieldNumber = 6;

		// Token: 0x04001318 RID: 4888
		private static readonly ulong CreateTimeDefaultValue = 0UL;

		// Token: 0x04001319 RID: 4889
		private ulong createTime_;
	}
}
