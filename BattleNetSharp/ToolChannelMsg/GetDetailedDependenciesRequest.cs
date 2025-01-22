using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000058 RID: 88
	public sealed class GetDetailedDependenciesRequest : IMessage<GetDetailedDependenciesRequest>, IMessage, IEquatable<GetDetailedDependenciesRequest>, IDeepCloneable<GetDetailedDependenciesRequest>, IBufferMessage
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		[DebuggerNonUserCode]
		public static MessageParser<GetDetailedDependenciesRequest> Parser
		{
			get
			{
				return GetDetailedDependenciesRequest._parser;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[65];
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0001F80C File Offset: 0x0001DA0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetailedDependenciesRequest.Descriptor;
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001F823 File Offset: 0x0001DA23
		[DebuggerNonUserCode]
		public GetDetailedDependenciesRequest()
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001F830 File Offset: 0x0001DA30
		[DebuggerNonUserCode]
		public GetDetailedDependenciesRequest(GetDetailedDependenciesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.platform_ = other.platform_;
			this.includeSoftLinks_ = other.includeSoftLinks_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001F894 File Offset: 0x0001DA94
		[DebuggerNonUserCode]
		public GetDetailedDependenciesRequest Clone()
		{
			return new GetDetailedDependenciesRequest(this);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0001F8AC File Offset: 0x0001DAAC
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0001F8DD File Offset: 0x0001DADD
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = GetDetailedDependenciesRequest.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001F915 File Offset: 0x0001DB15
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001F928 File Offset: 0x0001DB28
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0001F959 File Offset: 0x0001DB59
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = GetDetailedDependenciesRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0001F974 File Offset: 0x0001DB74
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001F991 File Offset: 0x0001DB91
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0001F9D5 File Offset: 0x0001DBD5
		[DebuggerNonUserCode]
		public int Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = GetDetailedDependenciesRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.platform_ = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001FA0D File Offset: 0x0001DC0D
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0001FA20 File Offset: 0x0001DC20
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0001FA51 File Offset: 0x0001DC51
		[DebuggerNonUserCode]
		public bool IncludeSoftLinks
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool includeSoftLinksDefaultValue;
				if (flag)
				{
					includeSoftLinksDefaultValue = this.includeSoftLinks_;
				}
				else
				{
					includeSoftLinksDefaultValue = GetDetailedDependenciesRequest.IncludeSoftLinksDefaultValue;
				}
				return includeSoftLinksDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.includeSoftLinks_ = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0001FA6C File Offset: 0x0001DC6C
		[DebuggerNonUserCode]
		public bool HasIncludeSoftLinks
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001FA89 File Offset: 0x0001DC89
		[DebuggerNonUserCode]
		public void ClearIncludeSoftLinks()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001FA9C File Offset: 0x0001DC9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetailedDependenciesRequest);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001FABC File Offset: 0x0001DCBC
		[DebuggerNonUserCode]
		public bool Equals(GetDetailedDependenciesRequest other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Platform != other.Platform;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IncludeSoftLinks != other.IncludeSoftLinks;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001FB68 File Offset: 0x0001DD68
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool hasIncludeSoftLinks = this.HasIncludeSoftLinks;
			if (hasIncludeSoftLinks)
			{
				num ^= this.IncludeSoftLinks.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0001FC10 File Offset: 0x0001DE10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001FC28 File Offset: 0x0001DE28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001FC34 File Offset: 0x0001DE34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Platform);
			}
			bool hasIncludeSoftLinks = this.HasIncludeSoftLinks;
			if (hasIncludeSoftLinks)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IncludeSoftLinks);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Platform);
			}
			bool hasIncludeSoftLinks = this.HasIncludeSoftLinks;
			if (hasIncludeSoftLinks)
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

		// Token: 0x06000785 RID: 1925 RVA: 0x0001FD84 File Offset: 0x0001DF84
		[DebuggerNonUserCode]
		public void MergeFrom(GetDetailedDependenciesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool hasIncludeSoftLinks = other.HasIncludeSoftLinks;
				if (hasIncludeSoftLinks)
				{
					this.IncludeSoftLinks = other.IncludeSoftLinks;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001FE1A File Offset: 0x0001E01A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001FE28 File Offset: 0x0001E028
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
						this.SnoHandle = input.ReadInt32();
					}
					else
					{
						this.SnoGroup = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.IncludeSoftLinks = input.ReadBool();
				}
				else
				{
					this.Platform = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000307 RID: 775
		private static readonly MessageParser<GetDetailedDependenciesRequest> _parser = new MessageParser<GetDetailedDependenciesRequest>(() => new GetDetailedDependenciesRequest());

		// Token: 0x04000308 RID: 776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000309 RID: 777
		private int _hasBits0;

		// Token: 0x0400030A RID: 778
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x0400030B RID: 779
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x0400030C RID: 780
		private int snoGroup_;

		// Token: 0x0400030D RID: 781
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x0400030E RID: 782
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400030F RID: 783
		private int snoHandle_;

		// Token: 0x04000310 RID: 784
		public const int PlatformFieldNumber = 3;

		// Token: 0x04000311 RID: 785
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x04000312 RID: 786
		private int platform_;

		// Token: 0x04000313 RID: 787
		public const int IncludeSoftLinksFieldNumber = 4;

		// Token: 0x04000314 RID: 788
		private static readonly bool IncludeSoftLinksDefaultValue = false;

		// Token: 0x04000315 RID: 789
		private bool includeSoftLinks_;
	}
}
