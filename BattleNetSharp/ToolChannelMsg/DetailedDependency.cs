using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200005B RID: 91
	public sealed class DetailedDependency : IMessage<DetailedDependency>, IMessage, IEquatable<DetailedDependency>, IDeepCloneable<DetailedDependency>, IBufferMessage
	{
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0002090C File Offset: 0x0001EB0C
		[DebuggerNonUserCode]
		public static MessageParser<DetailedDependency> Parser
		{
			get
			{
				return DetailedDependency._parser;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00020924 File Offset: 0x0001EB24
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[68];
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00020948 File Offset: 0x0001EB48
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetailedDependency.Descriptor;
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0002095F File Offset: 0x0001EB5F
		[DebuggerNonUserCode]
		public DetailedDependency()
		{
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0002096C File Offset: 0x0001EB6C
		[DebuggerNonUserCode]
		public DetailedDependency(DetailedDependency other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.expectedSnoGroup_ = other.expectedSnoGroup_;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.fieldName_ = other.fieldName_;
			this.fieldDisplayName_ = other.fieldDisplayName_;
			this.userReadableName_ = other.userReadableName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000209E8 File Offset: 0x0001EBE8
		[DebuggerNonUserCode]
		public DetailedDependency Clone()
		{
			return new DetailedDependency(this);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00020A00 File Offset: 0x0001EC00
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00020A31 File Offset: 0x0001EC31
		[DebuggerNonUserCode]
		public int ExpectedSnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int expectedSnoGroupDefaultValue;
				if (flag)
				{
					expectedSnoGroupDefaultValue = this.expectedSnoGroup_;
				}
				else
				{
					expectedSnoGroupDefaultValue = DetailedDependency.ExpectedSnoGroupDefaultValue;
				}
				return expectedSnoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.expectedSnoGroup_ = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00020A4C File Offset: 0x0001EC4C
		[DebuggerNonUserCode]
		public bool HasExpectedSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00020A69 File Offset: 0x0001EC69
		[DebuggerNonUserCode]
		public void ClearExpectedSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00020A7C File Offset: 0x0001EC7C
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00020AAD File Offset: 0x0001ECAD
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = DetailedDependency.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00020AC8 File Offset: 0x0001ECC8
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00020AE5 File Offset: 0x0001ECE5
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00020B29 File Offset: 0x0001ED29
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = DetailedDependency.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00020B44 File Offset: 0x0001ED44
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00020B61 File Offset: 0x0001ED61
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00020B74 File Offset: 0x0001ED74
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00020B95 File Offset: 0x0001ED95
		[DebuggerNonUserCode]
		public string FieldName
		{
			get
			{
				return this.fieldName_ ?? DetailedDependency.FieldNameDefaultValue;
			}
			set
			{
				this.fieldName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00020BAC File Offset: 0x0001EDAC
		[DebuggerNonUserCode]
		public bool HasFieldName
		{
			get
			{
				return this.fieldName_ != null;
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00020BC7 File Offset: 0x0001EDC7
		[DebuggerNonUserCode]
		public void ClearFieldName()
		{
			this.fieldName_ = null;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00020BF5 File Offset: 0x0001EDF5
		[DebuggerNonUserCode]
		public string FieldDisplayName
		{
			get
			{
				return this.fieldDisplayName_ ?? DetailedDependency.FieldDisplayNameDefaultValue;
			}
			set
			{
				this.fieldDisplayName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00020C0C File Offset: 0x0001EE0C
		[DebuggerNonUserCode]
		public bool HasFieldDisplayName
		{
			get
			{
				return this.fieldDisplayName_ != null;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00020C27 File Offset: 0x0001EE27
		[DebuggerNonUserCode]
		public void ClearFieldDisplayName()
		{
			this.fieldDisplayName_ = null;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00020C34 File Offset: 0x0001EE34
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00020C55 File Offset: 0x0001EE55
		[DebuggerNonUserCode]
		public string UserReadableName
		{
			get
			{
				return this.userReadableName_ ?? DetailedDependency.UserReadableNameDefaultValue;
			}
			set
			{
				this.userReadableName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00020C6C File Offset: 0x0001EE6C
		[DebuggerNonUserCode]
		public bool HasUserReadableName
		{
			get
			{
				return this.userReadableName_ != null;
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00020C87 File Offset: 0x0001EE87
		[DebuggerNonUserCode]
		public void ClearUserReadableName()
		{
			this.userReadableName_ = null;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00020C94 File Offset: 0x0001EE94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetailedDependency);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00020CB4 File Offset: 0x0001EEB4
		[DebuggerNonUserCode]
		public bool Equals(DetailedDependency other)
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
					bool flag4 = this.ExpectedSnoGroup != other.ExpectedSnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoGroup != other.SnoGroup;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoHandle != other.SnoHandle;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FieldName != other.FieldName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FieldDisplayName != other.FieldDisplayName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.UserReadableName != other.UserReadableName;
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

		// Token: 0x060007DC RID: 2012 RVA: 0x00020DA0 File Offset: 0x0001EFA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasExpectedSnoGroup = this.HasExpectedSnoGroup;
			if (hasExpectedSnoGroup)
			{
				num ^= this.ExpectedSnoGroup.GetHashCode();
			}
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
			bool hasFieldName = this.HasFieldName;
			if (hasFieldName)
			{
				num ^= this.FieldName.GetHashCode();
			}
			bool hasFieldDisplayName = this.HasFieldDisplayName;
			if (hasFieldDisplayName)
			{
				num ^= this.FieldDisplayName.GetHashCode();
			}
			bool hasUserReadableName = this.HasUserReadableName;
			if (hasUserReadableName)
			{
				num ^= this.UserReadableName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00020E78 File Offset: 0x0001F078
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00020E90 File Offset: 0x0001F090
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00020E9C File Offset: 0x0001F09C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasExpectedSnoGroup = this.HasExpectedSnoGroup;
			if (hasExpectedSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ExpectedSnoGroup);
			}
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasFieldName = this.HasFieldName;
			if (hasFieldName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.FieldName);
			}
			bool hasFieldDisplayName = this.HasFieldDisplayName;
			if (hasFieldDisplayName)
			{
				output.WriteRawTag(42);
				output.WriteString(this.FieldDisplayName);
			}
			bool hasUserReadableName = this.HasUserReadableName;
			if (hasUserReadableName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.UserReadableName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00020F98 File Offset: 0x0001F198
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasExpectedSnoGroup = this.HasExpectedSnoGroup;
			if (hasExpectedSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExpectedSnoGroup);
			}
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
			bool hasFieldName = this.HasFieldName;
			if (hasFieldName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FieldName);
			}
			bool hasFieldDisplayName = this.HasFieldDisplayName;
			if (hasFieldDisplayName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FieldDisplayName);
			}
			bool hasUserReadableName = this.HasUserReadableName;
			if (hasUserReadableName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UserReadableName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0002107C File Offset: 0x0001F27C
		[DebuggerNonUserCode]
		public void MergeFrom(DetailedDependency other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasExpectedSnoGroup = other.HasExpectedSnoGroup;
				if (hasExpectedSnoGroup)
				{
					this.ExpectedSnoGroup = other.ExpectedSnoGroup;
				}
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
				bool hasFieldName = other.HasFieldName;
				if (hasFieldName)
				{
					this.FieldName = other.FieldName;
				}
				bool hasFieldDisplayName = other.HasFieldDisplayName;
				if (hasFieldDisplayName)
				{
					this.FieldDisplayName = other.FieldDisplayName;
				}
				bool hasUserReadableName = other.HasUserReadableName;
				if (hasUserReadableName)
				{
					this.UserReadableName = other.UserReadableName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0002114B File Offset: 0x0001F34B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00021158 File Offset: 0x0001F358
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0039;
							}
							this.SnoHandle = input.ReadInt32();
						}
						else
						{
							this.SnoGroup = input.ReadInt32();
						}
					}
					else
					{
						this.ExpectedSnoGroup = input.ReadInt32();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0039;
						}
						this.UserReadableName = input.ReadString();
					}
					else
					{
						this.FieldDisplayName = input.ReadString();
					}
				}
				else
				{
					this.FieldName = input.ReadString();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400032A RID: 810
		private static readonly MessageParser<DetailedDependency> _parser = new MessageParser<DetailedDependency>(() => new DetailedDependency());

		// Token: 0x0400032B RID: 811
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400032C RID: 812
		private int _hasBits0;

		// Token: 0x0400032D RID: 813
		public const int ExpectedSnoGroupFieldNumber = 1;

		// Token: 0x0400032E RID: 814
		private static readonly int ExpectedSnoGroupDefaultValue = 0;

		// Token: 0x0400032F RID: 815
		private int expectedSnoGroup_;

		// Token: 0x04000330 RID: 816
		public const int SnoGroupFieldNumber = 2;

		// Token: 0x04000331 RID: 817
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x04000332 RID: 818
		private int snoGroup_;

		// Token: 0x04000333 RID: 819
		public const int SnoHandleFieldNumber = 3;

		// Token: 0x04000334 RID: 820
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000335 RID: 821
		private int snoHandle_;

		// Token: 0x04000336 RID: 822
		public const int FieldNameFieldNumber = 4;

		// Token: 0x04000337 RID: 823
		private static readonly string FieldNameDefaultValue = "";

		// Token: 0x04000338 RID: 824
		private string fieldName_;

		// Token: 0x04000339 RID: 825
		public const int FieldDisplayNameFieldNumber = 5;

		// Token: 0x0400033A RID: 826
		private static readonly string FieldDisplayNameDefaultValue = "";

		// Token: 0x0400033B RID: 827
		private string fieldDisplayName_;

		// Token: 0x0400033C RID: 828
		public const int UserReadableNameFieldNumber = 6;

		// Token: 0x0400033D RID: 829
		private static readonly string UserReadableNameDefaultValue = "";

		// Token: 0x0400033E RID: 830
		private string userReadableName_;
	}
}
