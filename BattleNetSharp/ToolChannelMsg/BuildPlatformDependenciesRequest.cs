using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000068 RID: 104
	public sealed class BuildPlatformDependenciesRequest : IMessage<BuildPlatformDependenciesRequest>, IMessage, IEquatable<BuildPlatformDependenciesRequest>, IDeepCloneable<BuildPlatformDependenciesRequest>, IBufferMessage
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00024108 File Offset: 0x00022308
		[DebuggerNonUserCode]
		public static MessageParser<BuildPlatformDependenciesRequest> Parser
		{
			get
			{
				return BuildPlatformDependenciesRequest._parser;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00024120 File Offset: 0x00022320
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[81];
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00024144 File Offset: 0x00022344
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildPlatformDependenciesRequest.Descriptor;
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0002415B File Offset: 0x0002235B
		[DebuggerNonUserCode]
		public BuildPlatformDependenciesRequest()
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00024168 File Offset: 0x00022368
		[DebuggerNonUserCode]
		public BuildPlatformDependenciesRequest(BuildPlatformDependenciesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.platform_ = other.platform_;
			this.assetMode_ = other.assetMode_;
			this.globalSnos_ = other.globalSnos_;
			this.excludedSnos_ = other.excludedSnos_;
			this.excludedGroups_ = other.excludedGroups_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000241D8 File Offset: 0x000223D8
		[DebuggerNonUserCode]
		public BuildPlatformDependenciesRequest Clone()
		{
			return new BuildPlatformDependenciesRequest(this);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x000241F0 File Offset: 0x000223F0
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00024221 File Offset: 0x00022421
		[DebuggerNonUserCode]
		public int Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = BuildPlatformDependenciesRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platform_ = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002423C File Offset: 0x0002243C
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00024259 File Offset: 0x00022459
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0002426C File Offset: 0x0002246C
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x0002429D File Offset: 0x0002249D
		[DebuggerNonUserCode]
		public int AssetMode
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int assetModeDefaultValue;
				if (flag)
				{
					assetModeDefaultValue = this.assetMode_;
				}
				else
				{
					assetModeDefaultValue = BuildPlatformDependenciesRequest.AssetModeDefaultValue;
				}
				return assetModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.assetMode_ = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000242B8 File Offset: 0x000224B8
		[DebuggerNonUserCode]
		public bool HasAssetMode
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000242D5 File Offset: 0x000224D5
		[DebuggerNonUserCode]
		public void ClearAssetMode()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000242E8 File Offset: 0x000224E8
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00024309 File Offset: 0x00022509
		[DebuggerNonUserCode]
		public string GlobalSnos
		{
			get
			{
				return this.globalSnos_ ?? BuildPlatformDependenciesRequest.GlobalSnosDefaultValue;
			}
			set
			{
				this.globalSnos_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00024320 File Offset: 0x00022520
		[DebuggerNonUserCode]
		public bool HasGlobalSnos
		{
			get
			{
				return this.globalSnos_ != null;
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002433B File Offset: 0x0002253B
		[DebuggerNonUserCode]
		public void ClearGlobalSnos()
		{
			this.globalSnos_ = null;
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00024348 File Offset: 0x00022548
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00024369 File Offset: 0x00022569
		[DebuggerNonUserCode]
		public string ExcludedSnos
		{
			get
			{
				return this.excludedSnos_ ?? BuildPlatformDependenciesRequest.ExcludedSnosDefaultValue;
			}
			set
			{
				this.excludedSnos_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00024380 File Offset: 0x00022580
		[DebuggerNonUserCode]
		public bool HasExcludedSnos
		{
			get
			{
				return this.excludedSnos_ != null;
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0002439B File Offset: 0x0002259B
		[DebuggerNonUserCode]
		public void ClearExcludedSnos()
		{
			this.excludedSnos_ = null;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000243A8 File Offset: 0x000225A8
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x000243C9 File Offset: 0x000225C9
		[DebuggerNonUserCode]
		public string ExcludedGroups
		{
			get
			{
				return this.excludedGroups_ ?? BuildPlatformDependenciesRequest.ExcludedGroupsDefaultValue;
			}
			set
			{
				this.excludedGroups_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x000243E0 File Offset: 0x000225E0
		[DebuggerNonUserCode]
		public bool HasExcludedGroups
		{
			get
			{
				return this.excludedGroups_ != null;
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000243FB File Offset: 0x000225FB
		[DebuggerNonUserCode]
		public void ClearExcludedGroups()
		{
			this.excludedGroups_ = null;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00024408 File Offset: 0x00022608
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildPlatformDependenciesRequest);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00024428 File Offset: 0x00022628
		[DebuggerNonUserCode]
		public bool Equals(BuildPlatformDependenciesRequest other)
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
					bool flag4 = this.Platform != other.Platform;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AssetMode != other.AssetMode;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GlobalSnos != other.GlobalSnos;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ExcludedSnos != other.ExcludedSnos;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ExcludedGroups != other.ExcludedGroups;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000244F4 File Offset: 0x000226F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool hasAssetMode = this.HasAssetMode;
			if (hasAssetMode)
			{
				num ^= this.AssetMode.GetHashCode();
			}
			bool hasGlobalSnos = this.HasGlobalSnos;
			if (hasGlobalSnos)
			{
				num ^= this.GlobalSnos.GetHashCode();
			}
			bool hasExcludedSnos = this.HasExcludedSnos;
			if (hasExcludedSnos)
			{
				num ^= this.ExcludedSnos.GetHashCode();
			}
			bool hasExcludedGroups = this.HasExcludedGroups;
			if (hasExcludedGroups)
			{
				num ^= this.ExcludedGroups.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000245B0 File Offset: 0x000227B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000245C8 File Offset: 0x000227C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000245D4 File Offset: 0x000227D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Platform);
			}
			bool hasAssetMode = this.HasAssetMode;
			if (hasAssetMode)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AssetMode);
			}
			bool hasGlobalSnos = this.HasGlobalSnos;
			if (hasGlobalSnos)
			{
				output.WriteRawTag(26);
				output.WriteString(this.GlobalSnos);
			}
			bool hasExcludedSnos = this.HasExcludedSnos;
			if (hasExcludedSnos)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ExcludedSnos);
			}
			bool hasExcludedGroups = this.HasExcludedGroups;
			if (hasExcludedGroups)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ExcludedGroups);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000246AC File Offset: 0x000228AC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Platform);
			}
			bool hasAssetMode = this.HasAssetMode;
			if (hasAssetMode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AssetMode);
			}
			bool hasGlobalSnos = this.HasGlobalSnos;
			if (hasGlobalSnos)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GlobalSnos);
			}
			bool hasExcludedSnos = this.HasExcludedSnos;
			if (hasExcludedSnos)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExcludedSnos);
			}
			bool hasExcludedGroups = this.HasExcludedGroups;
			if (hasExcludedGroups)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExcludedGroups);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00024774 File Offset: 0x00022974
		[DebuggerNonUserCode]
		public void MergeFrom(BuildPlatformDependenciesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool hasAssetMode = other.HasAssetMode;
				if (hasAssetMode)
				{
					this.AssetMode = other.AssetMode;
				}
				bool hasGlobalSnos = other.HasGlobalSnos;
				if (hasGlobalSnos)
				{
					this.GlobalSnos = other.GlobalSnos;
				}
				bool hasExcludedSnos = other.HasExcludedSnos;
				if (hasExcludedSnos)
				{
					this.ExcludedSnos = other.ExcludedSnos;
				}
				bool hasExcludedGroups = other.HasExcludedGroups;
				if (hasExcludedGroups)
				{
					this.ExcludedGroups = other.ExcludedGroups;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00024828 File Offset: 0x00022A28
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00024834 File Offset: 0x00022A34
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
							goto IL_0032;
						}
						this.AssetMode = input.ReadInt32();
					}
					else
					{
						this.Platform = input.ReadInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0032;
						}
						this.ExcludedGroups = input.ReadString();
					}
					else
					{
						this.ExcludedSnos = input.ReadString();
					}
				}
				else
				{
					this.GlobalSnos = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000393 RID: 915
		private static readonly MessageParser<BuildPlatformDependenciesRequest> _parser = new MessageParser<BuildPlatformDependenciesRequest>(() => new BuildPlatformDependenciesRequest());

		// Token: 0x04000394 RID: 916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000395 RID: 917
		private int _hasBits0;

		// Token: 0x04000396 RID: 918
		public const int PlatformFieldNumber = 1;

		// Token: 0x04000397 RID: 919
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x04000398 RID: 920
		private int platform_;

		// Token: 0x04000399 RID: 921
		public const int AssetModeFieldNumber = 2;

		// Token: 0x0400039A RID: 922
		private static readonly int AssetModeDefaultValue = 0;

		// Token: 0x0400039B RID: 923
		private int assetMode_;

		// Token: 0x0400039C RID: 924
		public const int GlobalSnosFieldNumber = 3;

		// Token: 0x0400039D RID: 925
		private static readonly string GlobalSnosDefaultValue = "";

		// Token: 0x0400039E RID: 926
		private string globalSnos_;

		// Token: 0x0400039F RID: 927
		public const int ExcludedSnosFieldNumber = 4;

		// Token: 0x040003A0 RID: 928
		private static readonly string ExcludedSnosDefaultValue = "";

		// Token: 0x040003A1 RID: 929
		private string excludedSnos_;

		// Token: 0x040003A2 RID: 930
		public const int ExcludedGroupsFieldNumber = 5;

		// Token: 0x040003A3 RID: 931
		private static readonly string ExcludedGroupsDefaultValue = "";

		// Token: 0x040003A4 RID: 932
		private string excludedGroups_;
	}
}
