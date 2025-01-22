using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000074 RID: 116
	public sealed class AllSNOReferencesRequest : IMessage<AllSNOReferencesRequest>, IMessage, IEquatable<AllSNOReferencesRequest>, IDeepCloneable<AllSNOReferencesRequest>, IBufferMessage
	{
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00027CCC File Offset: 0x00025ECC
		[DebuggerNonUserCode]
		public static MessageParser<AllSNOReferencesRequest> Parser
		{
			get
			{
				return AllSNOReferencesRequest._parser;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00027CE4 File Offset: 0x00025EE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[93];
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00027D08 File Offset: 0x00025F08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AllSNOReferencesRequest.Descriptor;
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00027D1F File Offset: 0x00025F1F
		[DebuggerNonUserCode]
		public AllSNOReferencesRequest()
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00027D2C File Offset: 0x00025F2C
		[DebuggerNonUserCode]
		public AllSNOReferencesRequest(AllSNOReferencesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.platform_ = other.platform_;
			this.includeSoftLinkRoots_ = other.includeSoftLinkRoots_;
			this.includeSoftLinks_ = other.includeSoftLinks_;
			this.pageSize_ = other.pageSize_;
			this.continueFromIndex_ = other.continueFromIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00027D9C File Offset: 0x00025F9C
		[DebuggerNonUserCode]
		public AllSNOReferencesRequest Clone()
		{
			return new AllSNOReferencesRequest(this);
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00027DB4 File Offset: 0x00025FB4
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00027DE5 File Offset: 0x00025FE5
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
					platformDefaultValue = AllSNOReferencesRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platform_ = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00027E00 File Offset: 0x00026000
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00027E1D File Offset: 0x0002601D
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00027E30 File Offset: 0x00026030
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00027E61 File Offset: 0x00026061
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
					includeSoftLinkRootsDefaultValue = AllSNOReferencesRequest.IncludeSoftLinkRootsDefaultValue;
				}
				return includeSoftLinkRootsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.includeSoftLinkRoots_ = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00027E7C File Offset: 0x0002607C
		[DebuggerNonUserCode]
		public bool HasIncludeSoftLinkRoots
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00027E99 File Offset: 0x00026099
		[DebuggerNonUserCode]
		public void ClearIncludeSoftLinkRoots()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00027EAC File Offset: 0x000260AC
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00027EDD File Offset: 0x000260DD
		[DebuggerNonUserCode]
		public bool IncludeSoftLinks
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool includeSoftLinksDefaultValue;
				if (flag)
				{
					includeSoftLinksDefaultValue = this.includeSoftLinks_;
				}
				else
				{
					includeSoftLinksDefaultValue = AllSNOReferencesRequest.IncludeSoftLinksDefaultValue;
				}
				return includeSoftLinksDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.includeSoftLinks_ = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00027EF8 File Offset: 0x000260F8
		[DebuggerNonUserCode]
		public bool HasIncludeSoftLinks
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00027F15 File Offset: 0x00026115
		[DebuggerNonUserCode]
		public void ClearIncludeSoftLinks()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00027F28 File Offset: 0x00026128
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00027F59 File Offset: 0x00026159
		[DebuggerNonUserCode]
		public int PageSize
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int pageSizeDefaultValue;
				if (flag)
				{
					pageSizeDefaultValue = this.pageSize_;
				}
				else
				{
					pageSizeDefaultValue = AllSNOReferencesRequest.PageSizeDefaultValue;
				}
				return pageSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.pageSize_ = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00027F74 File Offset: 0x00026174
		[DebuggerNonUserCode]
		public bool HasPageSize
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00027F91 File Offset: 0x00026191
		[DebuggerNonUserCode]
		public void ClearPageSize()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00027FA4 File Offset: 0x000261A4
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00027FD6 File Offset: 0x000261D6
		[DebuggerNonUserCode]
		public int ContinueFromIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int continueFromIndexDefaultValue;
				if (flag)
				{
					continueFromIndexDefaultValue = this.continueFromIndex_;
				}
				else
				{
					continueFromIndexDefaultValue = AllSNOReferencesRequest.ContinueFromIndexDefaultValue;
				}
				return continueFromIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.continueFromIndex_ = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00027FF0 File Offset: 0x000261F0
		[DebuggerNonUserCode]
		public bool HasContinueFromIndex
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002800E File Offset: 0x0002620E
		[DebuggerNonUserCode]
		public void ClearContinueFromIndex()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00028020 File Offset: 0x00026220
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AllSNOReferencesRequest);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00028040 File Offset: 0x00026240
		[DebuggerNonUserCode]
		public bool Equals(AllSNOReferencesRequest other)
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
						bool flag5 = this.IncludeSoftLinkRoots != other.IncludeSoftLinkRoots;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IncludeSoftLinks != other.IncludeSoftLinks;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PageSize != other.PageSize;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ContinueFromIndex != other.ContinueFromIndex;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002810C File Offset: 0x0002630C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool hasIncludeSoftLinkRoots = this.HasIncludeSoftLinkRoots;
			if (hasIncludeSoftLinkRoots)
			{
				num ^= this.IncludeSoftLinkRoots.GetHashCode();
			}
			bool hasIncludeSoftLinks = this.HasIncludeSoftLinks;
			if (hasIncludeSoftLinks)
			{
				num ^= this.IncludeSoftLinks.GetHashCode();
			}
			bool hasPageSize = this.HasPageSize;
			if (hasPageSize)
			{
				num ^= this.PageSize.GetHashCode();
			}
			bool hasContinueFromIndex = this.HasContinueFromIndex;
			if (hasContinueFromIndex)
			{
				num ^= this.ContinueFromIndex.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000281D4 File Offset: 0x000263D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000281EC File Offset: 0x000263EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000281F8 File Offset: 0x000263F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Platform);
			}
			bool hasIncludeSoftLinkRoots = this.HasIncludeSoftLinkRoots;
			if (hasIncludeSoftLinkRoots)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IncludeSoftLinkRoots);
			}
			bool hasIncludeSoftLinks = this.HasIncludeSoftLinks;
			if (hasIncludeSoftLinks)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IncludeSoftLinks);
			}
			bool hasPageSize = this.HasPageSize;
			if (hasPageSize)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PageSize);
			}
			bool hasContinueFromIndex = this.HasContinueFromIndex;
			if (hasContinueFromIndex)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ContinueFromIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000282D0 File Offset: 0x000264D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Platform);
			}
			bool hasIncludeSoftLinkRoots = this.HasIncludeSoftLinkRoots;
			if (hasIncludeSoftLinkRoots)
			{
				num += 2;
			}
			bool hasIncludeSoftLinks = this.HasIncludeSoftLinks;
			if (hasIncludeSoftLinks)
			{
				num += 2;
			}
			bool hasPageSize = this.HasPageSize;
			if (hasPageSize)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PageSize);
			}
			bool hasContinueFromIndex = this.HasContinueFromIndex;
			if (hasContinueFromIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ContinueFromIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00028380 File Offset: 0x00026580
		[DebuggerNonUserCode]
		public void MergeFrom(AllSNOReferencesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool hasIncludeSoftLinkRoots = other.HasIncludeSoftLinkRoots;
				if (hasIncludeSoftLinkRoots)
				{
					this.IncludeSoftLinkRoots = other.IncludeSoftLinkRoots;
				}
				bool hasIncludeSoftLinks = other.HasIncludeSoftLinks;
				if (hasIncludeSoftLinks)
				{
					this.IncludeSoftLinks = other.IncludeSoftLinks;
				}
				bool hasPageSize = other.HasPageSize;
				if (hasPageSize)
				{
					this.PageSize = other.PageSize;
				}
				bool hasContinueFromIndex = other.HasContinueFromIndex;
				if (hasContinueFromIndex)
				{
					this.ContinueFromIndex = other.ContinueFromIndex;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00028434 File Offset: 0x00026634
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00028440 File Offset: 0x00026640
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
						this.IncludeSoftLinkRoots = input.ReadBool();
					}
					else
					{
						this.Platform = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.ContinueFromIndex = input.ReadInt32();
					}
					else
					{
						this.PageSize = input.ReadInt32();
					}
				}
				else
				{
					this.IncludeSoftLinks = input.ReadBool();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000405 RID: 1029
		private static readonly MessageParser<AllSNOReferencesRequest> _parser = new MessageParser<AllSNOReferencesRequest>(() => new AllSNOReferencesRequest());

		// Token: 0x04000406 RID: 1030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000407 RID: 1031
		private int _hasBits0;

		// Token: 0x04000408 RID: 1032
		public const int PlatformFieldNumber = 1;

		// Token: 0x04000409 RID: 1033
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x0400040A RID: 1034
		private int platform_;

		// Token: 0x0400040B RID: 1035
		public const int IncludeSoftLinkRootsFieldNumber = 2;

		// Token: 0x0400040C RID: 1036
		private static readonly bool IncludeSoftLinkRootsDefaultValue = false;

		// Token: 0x0400040D RID: 1037
		private bool includeSoftLinkRoots_;

		// Token: 0x0400040E RID: 1038
		public const int IncludeSoftLinksFieldNumber = 3;

		// Token: 0x0400040F RID: 1039
		private static readonly bool IncludeSoftLinksDefaultValue = false;

		// Token: 0x04000410 RID: 1040
		private bool includeSoftLinks_;

		// Token: 0x04000411 RID: 1041
		public const int PageSizeFieldNumber = 4;

		// Token: 0x04000412 RID: 1042
		private static readonly int PageSizeDefaultValue = 0;

		// Token: 0x04000413 RID: 1043
		private int pageSize_;

		// Token: 0x04000414 RID: 1044
		public const int ContinueFromIndexFieldNumber = 5;

		// Token: 0x04000415 RID: 1045
		private static readonly int ContinueFromIndexDefaultValue = 0;

		// Token: 0x04000416 RID: 1046
		private int continueFromIndex_;
	}
}
