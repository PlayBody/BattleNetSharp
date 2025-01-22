using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000394 RID: 916
	public sealed class SemanticVersion : IMessage<SemanticVersion>, IMessage, IEquatable<SemanticVersion>, IDeepCloneable<SemanticVersion>, IBufferMessage
	{
		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06005D2B RID: 23851 RVA: 0x00168A2C File Offset: 0x00166C2C
		[DebuggerNonUserCode]
		public static MessageParser<SemanticVersion> Parser
		{
			get
			{
				return SemanticVersion._parser;
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06005D2C RID: 23852 RVA: 0x00168A44 File Offset: 0x00166C44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SemanticVersionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x06005D2D RID: 23853 RVA: 0x00168A68 File Offset: 0x00166C68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SemanticVersion.Descriptor;
			}
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x00168A7F File Offset: 0x00166C7F
		[DebuggerNonUserCode]
		public SemanticVersion()
		{
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x00168A8C File Offset: 0x00166C8C
		[DebuggerNonUserCode]
		public SemanticVersion(SemanticVersion other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.majorVersion_ = other.majorVersion_;
			this.minorVersion_ = other.minorVersion_;
			this.patchVersion_ = other.patchVersion_;
			this.versionString_ = other.versionString_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x00168AF0 File Offset: 0x00166CF0
		[DebuggerNonUserCode]
		public SemanticVersion Clone()
		{
			return new SemanticVersion(this);
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06005D31 RID: 23857 RVA: 0x00168B08 File Offset: 0x00166D08
		// (set) Token: 0x06005D32 RID: 23858 RVA: 0x00168B39 File Offset: 0x00166D39
		[DebuggerNonUserCode]
		public uint MajorVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint majorVersionDefaultValue;
				if (flag)
				{
					majorVersionDefaultValue = this.majorVersion_;
				}
				else
				{
					majorVersionDefaultValue = SemanticVersion.MajorVersionDefaultValue;
				}
				return majorVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.majorVersion_ = value;
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06005D33 RID: 23859 RVA: 0x00168B54 File Offset: 0x00166D54
		[DebuggerNonUserCode]
		public bool HasMajorVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x00168B71 File Offset: 0x00166D71
		[DebuggerNonUserCode]
		public void ClearMajorVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06005D35 RID: 23861 RVA: 0x00168B84 File Offset: 0x00166D84
		// (set) Token: 0x06005D36 RID: 23862 RVA: 0x00168BB5 File Offset: 0x00166DB5
		[DebuggerNonUserCode]
		public uint MinorVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint minorVersionDefaultValue;
				if (flag)
				{
					minorVersionDefaultValue = this.minorVersion_;
				}
				else
				{
					minorVersionDefaultValue = SemanticVersion.MinorVersionDefaultValue;
				}
				return minorVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.minorVersion_ = value;
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06005D37 RID: 23863 RVA: 0x00168BD0 File Offset: 0x00166DD0
		[DebuggerNonUserCode]
		public bool HasMinorVersion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x00168BED File Offset: 0x00166DED
		[DebuggerNonUserCode]
		public void ClearMinorVersion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06005D39 RID: 23865 RVA: 0x00168C00 File Offset: 0x00166E00
		// (set) Token: 0x06005D3A RID: 23866 RVA: 0x00168C31 File Offset: 0x00166E31
		[DebuggerNonUserCode]
		public uint PatchVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint patchVersionDefaultValue;
				if (flag)
				{
					patchVersionDefaultValue = this.patchVersion_;
				}
				else
				{
					patchVersionDefaultValue = SemanticVersion.PatchVersionDefaultValue;
				}
				return patchVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.patchVersion_ = value;
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x06005D3B RID: 23867 RVA: 0x00168C4C File Offset: 0x00166E4C
		[DebuggerNonUserCode]
		public bool HasPatchVersion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x00168C69 File Offset: 0x00166E69
		[DebuggerNonUserCode]
		public void ClearPatchVersion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x00168C7C File Offset: 0x00166E7C
		// (set) Token: 0x06005D3E RID: 23870 RVA: 0x00168C9D File Offset: 0x00166E9D
		[DebuggerNonUserCode]
		public string VersionString
		{
			get
			{
				return this.versionString_ ?? SemanticVersion.VersionStringDefaultValue;
			}
			set
			{
				this.versionString_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x00168CB4 File Offset: 0x00166EB4
		[DebuggerNonUserCode]
		public bool HasVersionString
		{
			get
			{
				return this.versionString_ != null;
			}
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x00168CCF File Offset: 0x00166ECF
		[DebuggerNonUserCode]
		public void ClearVersionString()
		{
			this.versionString_ = null;
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x00168CDC File Offset: 0x00166EDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SemanticVersion);
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x00168CFC File Offset: 0x00166EFC
		[DebuggerNonUserCode]
		public bool Equals(SemanticVersion other)
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
					bool flag4 = this.MajorVersion != other.MajorVersion;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MinorVersion != other.MinorVersion;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PatchVersion != other.PatchVersion;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.VersionString != other.VersionString;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x00168DA8 File Offset: 0x00166FA8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMajorVersion = this.HasMajorVersion;
			if (hasMajorVersion)
			{
				num ^= this.MajorVersion.GetHashCode();
			}
			bool hasMinorVersion = this.HasMinorVersion;
			if (hasMinorVersion)
			{
				num ^= this.MinorVersion.GetHashCode();
			}
			bool hasPatchVersion = this.HasPatchVersion;
			if (hasPatchVersion)
			{
				num ^= this.PatchVersion.GetHashCode();
			}
			bool hasVersionString = this.HasVersionString;
			if (hasVersionString)
			{
				num ^= this.VersionString.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x00168E4C File Offset: 0x0016704C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x00168E64 File Offset: 0x00167064
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x00168E70 File Offset: 0x00167070
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMajorVersion = this.HasMajorVersion;
			if (hasMajorVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MajorVersion);
			}
			bool hasMinorVersion = this.HasMinorVersion;
			if (hasMinorVersion)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MinorVersion);
			}
			bool hasPatchVersion = this.HasPatchVersion;
			if (hasPatchVersion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PatchVersion);
			}
			bool hasVersionString = this.HasVersionString;
			if (hasVersionString)
			{
				output.WriteRawTag(34);
				output.WriteString(this.VersionString);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x00168F24 File Offset: 0x00167124
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMajorVersion = this.HasMajorVersion;
			if (hasMajorVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MajorVersion);
			}
			bool hasMinorVersion = this.HasMinorVersion;
			if (hasMinorVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinorVersion);
			}
			bool hasPatchVersion = this.HasPatchVersion;
			if (hasPatchVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PatchVersion);
			}
			bool hasVersionString = this.HasVersionString;
			if (hasVersionString)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VersionString);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x00168FCC File Offset: 0x001671CC
		[DebuggerNonUserCode]
		public void MergeFrom(SemanticVersion other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMajorVersion = other.HasMajorVersion;
				if (hasMajorVersion)
				{
					this.MajorVersion = other.MajorVersion;
				}
				bool hasMinorVersion = other.HasMinorVersion;
				if (hasMinorVersion)
				{
					this.MinorVersion = other.MinorVersion;
				}
				bool hasPatchVersion = other.HasPatchVersion;
				if (hasPatchVersion)
				{
					this.PatchVersion = other.PatchVersion;
				}
				bool hasVersionString = other.HasVersionString;
				if (hasVersionString)
				{
					this.VersionString = other.VersionString;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x00169062 File Offset: 0x00167262
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x00169070 File Offset: 0x00167270
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
						this.MinorVersion = input.ReadUInt32();
					}
					else
					{
						this.MajorVersion = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.VersionString = input.ReadString();
				}
				else
				{
					this.PatchVersion = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002AA4 RID: 10916
		private static readonly MessageParser<SemanticVersion> _parser = new MessageParser<SemanticVersion>(() => new SemanticVersion());

		// Token: 0x04002AA5 RID: 10917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AA6 RID: 10918
		private int _hasBits0;

		// Token: 0x04002AA7 RID: 10919
		public const int MajorVersionFieldNumber = 1;

		// Token: 0x04002AA8 RID: 10920
		private static readonly uint MajorVersionDefaultValue = 0U;

		// Token: 0x04002AA9 RID: 10921
		private uint majorVersion_;

		// Token: 0x04002AAA RID: 10922
		public const int MinorVersionFieldNumber = 2;

		// Token: 0x04002AAB RID: 10923
		private static readonly uint MinorVersionDefaultValue = 0U;

		// Token: 0x04002AAC RID: 10924
		private uint minorVersion_;

		// Token: 0x04002AAD RID: 10925
		public const int PatchVersionFieldNumber = 3;

		// Token: 0x04002AAE RID: 10926
		private static readonly uint PatchVersionDefaultValue = 0U;

		// Token: 0x04002AAF RID: 10927
		private uint patchVersion_;

		// Token: 0x04002AB0 RID: 10928
		public const int VersionStringFieldNumber = 4;

		// Token: 0x04002AB1 RID: 10929
		private static readonly string VersionStringDefaultValue = "";

		// Token: 0x04002AB2 RID: 10930
		private string versionString_;
	}
}
