using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000076 RID: 118
	public sealed class IterateReferencesRequest : IMessage<IterateReferencesRequest>, IMessage, IEquatable<IterateReferencesRequest>, IDeepCloneable<IterateReferencesRequest>, IBufferMessage
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0002882C File Offset: 0x00026A2C
		[DebuggerNonUserCode]
		public static MessageParser<IterateReferencesRequest> Parser
		{
			get
			{
				return IterateReferencesRequest._parser;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00028844 File Offset: 0x00026A44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[95];
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00028868 File Offset: 0x00026A68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IterateReferencesRequest.Descriptor;
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002887F File Offset: 0x00026A7F
		[DebuggerNonUserCode]
		public IterateReferencesRequest()
		{
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002888C File Offset: 0x00026A8C
		[DebuggerNonUserCode]
		public IterateReferencesRequest(IterateReferencesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.platform_ = other.platform_;
			this.globalSnos_ = other.globalSnos_;
			this.excludedSnos_ = other.excludedSnos_;
			this.excludedGroups_ = other.excludedGroups_;
			this.includeSoftLinkRoots_ = other.includeSoftLinkRoots_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000288FC File Offset: 0x00026AFC
		[DebuggerNonUserCode]
		public IterateReferencesRequest Clone()
		{
			return new IterateReferencesRequest(this);
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00028914 File Offset: 0x00026B14
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00028945 File Offset: 0x00026B45
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
					platformDefaultValue = IterateReferencesRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platform_ = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00028960 File Offset: 0x00026B60
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002897D File Offset: 0x00026B7D
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00028990 File Offset: 0x00026B90
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x000289B1 File Offset: 0x00026BB1
		[DebuggerNonUserCode]
		public string GlobalSnos
		{
			get
			{
				return this.globalSnos_ ?? IterateReferencesRequest.GlobalSnosDefaultValue;
			}
			set
			{
				this.globalSnos_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000289C8 File Offset: 0x00026BC8
		[DebuggerNonUserCode]
		public bool HasGlobalSnos
		{
			get
			{
				return this.globalSnos_ != null;
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000289E3 File Offset: 0x00026BE3
		[DebuggerNonUserCode]
		public void ClearGlobalSnos()
		{
			this.globalSnos_ = null;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x000289F0 File Offset: 0x00026BF0
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00028A11 File Offset: 0x00026C11
		[DebuggerNonUserCode]
		public string ExcludedSnos
		{
			get
			{
				return this.excludedSnos_ ?? IterateReferencesRequest.ExcludedSnosDefaultValue;
			}
			set
			{
				this.excludedSnos_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00028A28 File Offset: 0x00026C28
		[DebuggerNonUserCode]
		public bool HasExcludedSnos
		{
			get
			{
				return this.excludedSnos_ != null;
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00028A43 File Offset: 0x00026C43
		[DebuggerNonUserCode]
		public void ClearExcludedSnos()
		{
			this.excludedSnos_ = null;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00028A50 File Offset: 0x00026C50
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00028A71 File Offset: 0x00026C71
		[DebuggerNonUserCode]
		public string ExcludedGroups
		{
			get
			{
				return this.excludedGroups_ ?? IterateReferencesRequest.ExcludedGroupsDefaultValue;
			}
			set
			{
				this.excludedGroups_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00028A88 File Offset: 0x00026C88
		[DebuggerNonUserCode]
		public bool HasExcludedGroups
		{
			get
			{
				return this.excludedGroups_ != null;
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00028AA3 File Offset: 0x00026CA3
		[DebuggerNonUserCode]
		public void ClearExcludedGroups()
		{
			this.excludedGroups_ = null;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00028AB0 File Offset: 0x00026CB0
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00028AE1 File Offset: 0x00026CE1
		[DebuggerNonUserCode]
		public bool IncludeSoftLinkRoots
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool includeSoftLinkRootsDefaultValue;
				if (flag)
				{
					includeSoftLinkRootsDefaultValue = this.includeSoftLinkRoots_;
				}
				else
				{
					includeSoftLinkRootsDefaultValue = IterateReferencesRequest.IncludeSoftLinkRootsDefaultValue;
				}
				return includeSoftLinkRootsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.includeSoftLinkRoots_ = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00028AFC File Offset: 0x00026CFC
		[DebuggerNonUserCode]
		public bool HasIncludeSoftLinkRoots
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00028B19 File Offset: 0x00026D19
		[DebuggerNonUserCode]
		public void ClearIncludeSoftLinkRoots()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00028B2C File Offset: 0x00026D2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IterateReferencesRequest);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00028B4C File Offset: 0x00026D4C
		[DebuggerNonUserCode]
		public bool Equals(IterateReferencesRequest other)
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
						bool flag5 = this.GlobalSnos != other.GlobalSnos;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ExcludedSnos != other.ExcludedSnos;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ExcludedGroups != other.ExcludedGroups;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.IncludeSoftLinkRoots != other.IncludeSoftLinkRoots;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00028C18 File Offset: 0x00026E18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
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
			bool hasIncludeSoftLinkRoots = this.HasIncludeSoftLinkRoots;
			if (hasIncludeSoftLinkRoots)
			{
				num ^= this.IncludeSoftLinkRoots.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00028CD4 File Offset: 0x00026ED4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00028CEC File Offset: 0x00026EEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00028CF8 File Offset: 0x00026EF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Platform);
			}
			bool hasGlobalSnos = this.HasGlobalSnos;
			if (hasGlobalSnos)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GlobalSnos);
			}
			bool hasExcludedSnos = this.HasExcludedSnos;
			if (hasExcludedSnos)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ExcludedSnos);
			}
			bool hasExcludedGroups = this.HasExcludedGroups;
			if (hasExcludedGroups)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ExcludedGroups);
			}
			bool hasIncludeSoftLinkRoots = this.HasIncludeSoftLinkRoots;
			if (hasIncludeSoftLinkRoots)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IncludeSoftLinkRoots);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00028DD0 File Offset: 0x00026FD0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Platform);
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
			bool hasIncludeSoftLinkRoots = this.HasIncludeSoftLinkRoots;
			if (hasIncludeSoftLinkRoots)
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

		// Token: 0x06000A74 RID: 2676 RVA: 0x00028E8C File Offset: 0x0002708C
		[DebuggerNonUserCode]
		public void MergeFrom(IterateReferencesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
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
				bool hasIncludeSoftLinkRoots = other.HasIncludeSoftLinkRoots;
				if (hasIncludeSoftLinkRoots)
				{
					this.IncludeSoftLinkRoots = other.IncludeSoftLinkRoots;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00028F40 File Offset: 0x00027140
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00028F4C File Offset: 0x0002714C
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
						this.GlobalSnos = input.ReadString();
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
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.IncludeSoftLinkRoots = input.ReadBool();
					}
					else
					{
						this.ExcludedGroups = input.ReadString();
					}
				}
				else
				{
					this.ExcludedSnos = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400041C RID: 1052
		private static readonly MessageParser<IterateReferencesRequest> _parser = new MessageParser<IterateReferencesRequest>(() => new IterateReferencesRequest());

		// Token: 0x0400041D RID: 1053
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400041E RID: 1054
		private int _hasBits0;

		// Token: 0x0400041F RID: 1055
		public const int PlatformFieldNumber = 1;

		// Token: 0x04000420 RID: 1056
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x04000421 RID: 1057
		private int platform_;

		// Token: 0x04000422 RID: 1058
		public const int GlobalSnosFieldNumber = 2;

		// Token: 0x04000423 RID: 1059
		private static readonly string GlobalSnosDefaultValue = "";

		// Token: 0x04000424 RID: 1060
		private string globalSnos_;

		// Token: 0x04000425 RID: 1061
		public const int ExcludedSnosFieldNumber = 3;

		// Token: 0x04000426 RID: 1062
		private static readonly string ExcludedSnosDefaultValue = "";

		// Token: 0x04000427 RID: 1063
		private string excludedSnos_;

		// Token: 0x04000428 RID: 1064
		public const int ExcludedGroupsFieldNumber = 4;

		// Token: 0x04000429 RID: 1065
		private static readonly string ExcludedGroupsDefaultValue = "";

		// Token: 0x0400042A RID: 1066
		private string excludedGroups_;

		// Token: 0x0400042B RID: 1067
		public const int IncludeSoftLinkRootsFieldNumber = 5;

		// Token: 0x0400042C RID: 1068
		private static readonly bool IncludeSoftLinkRootsDefaultValue = false;

		// Token: 0x0400042D RID: 1069
		private bool includeSoftLinkRoots_;
	}
}
