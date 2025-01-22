using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000056 RID: 86
	public sealed class GetDependenciesRequest : IMessage<GetDependenciesRequest>, IMessage, IEquatable<GetDependenciesRequest>, IDeepCloneable<GetDependenciesRequest>, IBufferMessage
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0001EDAC File Offset: 0x0001CFAC
		[DebuggerNonUserCode]
		public static MessageParser<GetDependenciesRequest> Parser
		{
			get
			{
				return GetDependenciesRequest._parser;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0001EDC4 File Offset: 0x0001CFC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[63];
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x0001EDE8 File Offset: 0x0001CFE8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDependenciesRequest.Descriptor;
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001EDFF File Offset: 0x0001CFFF
		[DebuggerNonUserCode]
		public GetDependenciesRequest()
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001EE0C File Offset: 0x0001D00C
		[DebuggerNonUserCode]
		public GetDependenciesRequest(GetDependenciesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.platform_ = other.platform_;
			this.includeSoftLinks_ = other.includeSoftLinks_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0001EE70 File Offset: 0x0001D070
		[DebuggerNonUserCode]
		public GetDependenciesRequest Clone()
		{
			return new GetDependenciesRequest(this);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x0001EE88 File Offset: 0x0001D088
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x0001EEB9 File Offset: 0x0001D0B9
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
					snoGroupDefaultValue = GetDependenciesRequest.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0001EED4 File Offset: 0x0001D0D4
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0001EEF1 File Offset: 0x0001D0F1
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x0001EF04 File Offset: 0x0001D104
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x0001EF35 File Offset: 0x0001D135
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
					snoHandleDefaultValue = GetDependenciesRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x0001EF50 File Offset: 0x0001D150
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0001EF6D File Offset: 0x0001D16D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0001EF80 File Offset: 0x0001D180
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x0001EFB1 File Offset: 0x0001D1B1
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
					platformDefaultValue = GetDependenciesRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.platform_ = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0001EFE9 File Offset: 0x0001D1E9
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0001EFFC File Offset: 0x0001D1FC
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0001F02D File Offset: 0x0001D22D
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
					includeSoftLinksDefaultValue = GetDependenciesRequest.IncludeSoftLinksDefaultValue;
				}
				return includeSoftLinksDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.includeSoftLinks_ = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0001F048 File Offset: 0x0001D248
		[DebuggerNonUserCode]
		public bool HasIncludeSoftLinks
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001F065 File Offset: 0x0001D265
		[DebuggerNonUserCode]
		public void ClearIncludeSoftLinks()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001F078 File Offset: 0x0001D278
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDependenciesRequest);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001F098 File Offset: 0x0001D298
		[DebuggerNonUserCode]
		public bool Equals(GetDependenciesRequest other)
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

		// Token: 0x0600074D RID: 1869 RVA: 0x0001F144 File Offset: 0x0001D344
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

		// Token: 0x0600074E RID: 1870 RVA: 0x0001F1EC File Offset: 0x0001D3EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001F204 File Offset: 0x0001D404
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001F210 File Offset: 0x0001D410
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

		// Token: 0x06000751 RID: 1873 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
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

		// Token: 0x06000752 RID: 1874 RVA: 0x0001F360 File Offset: 0x0001D560
		[DebuggerNonUserCode]
		public void MergeFrom(GetDependenciesRequest other)
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

		// Token: 0x06000753 RID: 1875 RVA: 0x0001F3F6 File Offset: 0x0001D5F6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001F404 File Offset: 0x0001D604
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

		// Token: 0x040002F3 RID: 755
		private static readonly MessageParser<GetDependenciesRequest> _parser = new MessageParser<GetDependenciesRequest>(() => new GetDependenciesRequest());

		// Token: 0x040002F4 RID: 756
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002F5 RID: 757
		private int _hasBits0;

		// Token: 0x040002F6 RID: 758
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040002F7 RID: 759
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040002F8 RID: 760
		private int snoGroup_;

		// Token: 0x040002F9 RID: 761
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040002FA RID: 762
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040002FB RID: 763
		private int snoHandle_;

		// Token: 0x040002FC RID: 764
		public const int PlatformFieldNumber = 3;

		// Token: 0x040002FD RID: 765
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x040002FE RID: 766
		private int platform_;

		// Token: 0x040002FF RID: 767
		public const int IncludeSoftLinksFieldNumber = 4;

		// Token: 0x04000300 RID: 768
		private static readonly bool IncludeSoftLinksDefaultValue = false;

		// Token: 0x04000301 RID: 769
		private bool includeSoftLinks_;
	}
}
