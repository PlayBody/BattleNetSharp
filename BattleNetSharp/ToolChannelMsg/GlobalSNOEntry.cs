using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200005D RID: 93
	public sealed class GlobalSNOEntry : IMessage<GlobalSNOEntry>, IMessage, IEquatable<GlobalSNOEntry>, IDeepCloneable<GlobalSNOEntry>, IBufferMessage
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0002157C File Offset: 0x0001F77C
		[DebuggerNonUserCode]
		public static MessageParser<GlobalSNOEntry> Parser
		{
			get
			{
				return GlobalSNOEntry._parser;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00021594 File Offset: 0x0001F794
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[70];
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000215B8 File Offset: 0x0001F7B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalSNOEntry.Descriptor;
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000215CF File Offset: 0x0001F7CF
		[DebuggerNonUserCode]
		public GlobalSNOEntry()
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000215DC File Offset: 0x0001F7DC
		[DebuggerNonUserCode]
		public GlobalSNOEntry(GlobalSNOEntry other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.globalSnoEnum_ = other.globalSnoEnum_;
			this.bucket_ = other.bucket_;
			this.snoname_ = ((other.snoname_ != null) ? other.snoname_.Clone() : null);
			this.onlyReferencedFromEnumeratingSnos_ = other.onlyReferencedFromEnumeratingSnos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00021650 File Offset: 0x0001F850
		[DebuggerNonUserCode]
		public GlobalSNOEntry Clone()
		{
			return new GlobalSNOEntry(this);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00021668 File Offset: 0x0001F868
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00021699 File Offset: 0x0001F899
		[DebuggerNonUserCode]
		public int GlobalSnoEnum
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int globalSnoEnumDefaultValue;
				if (flag)
				{
					globalSnoEnumDefaultValue = this.globalSnoEnum_;
				}
				else
				{
					globalSnoEnumDefaultValue = GlobalSNOEntry.GlobalSnoEnumDefaultValue;
				}
				return globalSnoEnumDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.globalSnoEnum_ = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000216B4 File Offset: 0x0001F8B4
		[DebuggerNonUserCode]
		public bool HasGlobalSnoEnum
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000216D1 File Offset: 0x0001F8D1
		[DebuggerNonUserCode]
		public void ClearGlobalSnoEnum()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000216E4 File Offset: 0x0001F8E4
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00021715 File Offset: 0x0001F915
		[DebuggerNonUserCode]
		public GlobalSNOBucket Bucket
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				GlobalSNOBucket bucketDefaultValue;
				if (flag)
				{
					bucketDefaultValue = this.bucket_;
				}
				else
				{
					bucketDefaultValue = GlobalSNOEntry.BucketDefaultValue;
				}
				return bucketDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.bucket_ = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00021730 File Offset: 0x0001F930
		[DebuggerNonUserCode]
		public bool HasBucket
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002174D File Offset: 0x0001F94D
		[DebuggerNonUserCode]
		public void ClearBucket()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00021760 File Offset: 0x0001F960
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00021778 File Offset: 0x0001F978
		[DebuggerNonUserCode]
		public SNOName Snoname
		{
			get
			{
				return this.snoname_;
			}
			set
			{
				this.snoname_ = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00021784 File Offset: 0x0001F984
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000217B5 File Offset: 0x0001F9B5
		[DebuggerNonUserCode]
		public bool OnlyReferencedFromEnumeratingSnos
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool onlyReferencedFromEnumeratingSnosDefaultValue;
				if (flag)
				{
					onlyReferencedFromEnumeratingSnosDefaultValue = this.onlyReferencedFromEnumeratingSnos_;
				}
				else
				{
					onlyReferencedFromEnumeratingSnosDefaultValue = GlobalSNOEntry.OnlyReferencedFromEnumeratingSnosDefaultValue;
				}
				return onlyReferencedFromEnumeratingSnosDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.onlyReferencedFromEnumeratingSnos_ = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x000217D0 File Offset: 0x0001F9D0
		[DebuggerNonUserCode]
		public bool HasOnlyReferencedFromEnumeratingSnos
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000217ED File Offset: 0x0001F9ED
		[DebuggerNonUserCode]
		public void ClearOnlyReferencedFromEnumeratingSnos()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00021800 File Offset: 0x0001FA00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalSNOEntry);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00021820 File Offset: 0x0001FA20
		[DebuggerNonUserCode]
		public bool Equals(GlobalSNOEntry other)
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
					bool flag4 = this.GlobalSnoEnum != other.GlobalSnoEnum;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Bucket != other.Bucket;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Snoname, other.Snoname);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.OnlyReferencedFromEnumeratingSnos != other.OnlyReferencedFromEnumeratingSnos;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000218D0 File Offset: 0x0001FAD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGlobalSnoEnum = this.HasGlobalSnoEnum;
			if (hasGlobalSnoEnum)
			{
				num ^= this.GlobalSnoEnum.GetHashCode();
			}
			bool hasBucket = this.HasBucket;
			if (hasBucket)
			{
				num ^= this.Bucket.GetHashCode();
			}
			bool flag = this.snoname_ != null;
			if (flag)
			{
				num ^= this.Snoname.GetHashCode();
			}
			bool hasOnlyReferencedFromEnumeratingSnos = this.HasOnlyReferencedFromEnumeratingSnos;
			if (hasOnlyReferencedFromEnumeratingSnos)
			{
				num ^= this.OnlyReferencedFromEnumeratingSnos.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00021980 File Offset: 0x0001FB80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00021998 File Offset: 0x0001FB98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000219A4 File Offset: 0x0001FBA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGlobalSnoEnum = this.HasGlobalSnoEnum;
			if (hasGlobalSnoEnum)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GlobalSnoEnum);
			}
			bool hasBucket = this.HasBucket;
			if (hasBucket)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Bucket);
			}
			bool flag = this.snoname_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Snoname);
			}
			bool hasOnlyReferencedFromEnumeratingSnos = this.HasOnlyReferencedFromEnumeratingSnos;
			if (hasOnlyReferencedFromEnumeratingSnos)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.OnlyReferencedFromEnumeratingSnos);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00021A5C File Offset: 0x0001FC5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGlobalSnoEnum = this.HasGlobalSnoEnum;
			if (hasGlobalSnoEnum)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GlobalSnoEnum);
			}
			bool hasBucket = this.HasBucket;
			if (hasBucket)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Bucket);
			}
			bool flag = this.snoname_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snoname);
			}
			bool hasOnlyReferencedFromEnumeratingSnos = this.HasOnlyReferencedFromEnumeratingSnos;
			if (hasOnlyReferencedFromEnumeratingSnos)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00021AFC File Offset: 0x0001FCFC
		[DebuggerNonUserCode]
		public void MergeFrom(GlobalSNOEntry other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGlobalSnoEnum = other.HasGlobalSnoEnum;
				if (hasGlobalSnoEnum)
				{
					this.GlobalSnoEnum = other.GlobalSnoEnum;
				}
				bool hasBucket = other.HasBucket;
				if (hasBucket)
				{
					this.Bucket = other.Bucket;
				}
				bool flag2 = other.snoname_ != null;
				if (flag2)
				{
					bool flag3 = this.snoname_ == null;
					if (flag3)
					{
						this.Snoname = new SNOName();
					}
					this.Snoname.MergeFrom(other.Snoname);
				}
				bool hasOnlyReferencedFromEnumeratingSnos = other.HasOnlyReferencedFromEnumeratingSnos;
				if (hasOnlyReferencedFromEnumeratingSnos)
				{
					this.OnlyReferencedFromEnumeratingSnos = other.OnlyReferencedFromEnumeratingSnos;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00021BBA File Offset: 0x0001FDBA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00021BC8 File Offset: 0x0001FDC8
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
							goto IL_002B;
						}
						this.Bucket = (GlobalSNOBucket)input.ReadEnum();
					}
					else
					{
						this.GlobalSnoEnum = input.ReadInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002B;
					}
					this.OnlyReferencedFromEnumeratingSnos = input.ReadBool();
				}
				else
				{
					bool flag = this.snoname_ == null;
					if (flag)
					{
						this.Snoname = new SNOName();
					}
					input.ReadMessage(this.Snoname);
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000344 RID: 836
		private static readonly MessageParser<GlobalSNOEntry> _parser = new MessageParser<GlobalSNOEntry>(() => new GlobalSNOEntry());

		// Token: 0x04000345 RID: 837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000346 RID: 838
		private int _hasBits0;

		// Token: 0x04000347 RID: 839
		public const int GlobalSnoEnumFieldNumber = 1;

		// Token: 0x04000348 RID: 840
		private static readonly int GlobalSnoEnumDefaultValue = 0;

		// Token: 0x04000349 RID: 841
		private int globalSnoEnum_;

		// Token: 0x0400034A RID: 842
		public const int BucketFieldNumber = 2;

		// Token: 0x0400034B RID: 843
		private static readonly GlobalSNOBucket BucketDefaultValue = GlobalSNOBucket.ToolsAndTesting;

		// Token: 0x0400034C RID: 844
		private GlobalSNOBucket bucket_;

		// Token: 0x0400034D RID: 845
		public const int SnonameFieldNumber = 3;

		// Token: 0x0400034E RID: 846
		private SNOName snoname_;

		// Token: 0x0400034F RID: 847
		public const int OnlyReferencedFromEnumeratingSnosFieldNumber = 4;

		// Token: 0x04000350 RID: 848
		private static readonly bool OnlyReferencedFromEnumeratingSnosDefaultValue = false;

		// Token: 0x04000351 RID: 849
		private bool onlyReferencedFromEnumeratingSnos_;
	}
}
