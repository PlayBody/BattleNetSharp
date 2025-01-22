using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200008C RID: 140
	public sealed class Version : IMessage<Version>, IMessage, IEquatable<Version>, IDeepCloneable<Version>, IBufferMessage
	{
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0003089C File Offset: 0x0002EA9C
		[DebuggerNonUserCode]
		public static MessageParser<Version> Parser
		{
			get
			{
				return Version._parser;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000308B4 File Offset: 0x0002EAB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[117];
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000308D8 File Offset: 0x0002EAD8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Version.Descriptor;
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000308EF File Offset: 0x0002EAEF
		[DebuggerNonUserCode]
		public Version()
		{
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000308FC File Offset: 0x0002EAFC
		[DebuggerNonUserCode]
		public Version(Version other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.buildNum_ = other.buildNum_;
			this.codeBranch_ = other.codeBranch_;
			this.dataBranch_ = other.dataBranch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00030954 File Offset: 0x0002EB54
		[DebuggerNonUserCode]
		public Version Clone()
		{
			return new Version(this);
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0003096C File Offset: 0x0002EB6C
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x0003099D File Offset: 0x0002EB9D
		[DebuggerNonUserCode]
		public int BuildNum
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int buildNumDefaultValue;
				if (flag)
				{
					buildNumDefaultValue = this.buildNum_;
				}
				else
				{
					buildNumDefaultValue = Version.BuildNumDefaultValue;
				}
				return buildNumDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.buildNum_ = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000309B8 File Offset: 0x0002EBB8
		[DebuggerNonUserCode]
		public bool HasBuildNum
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000309D5 File Offset: 0x0002EBD5
		[DebuggerNonUserCode]
		public void ClearBuildNum()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000309E8 File Offset: 0x0002EBE8
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00030A09 File Offset: 0x0002EC09
		[DebuggerNonUserCode]
		public string CodeBranch
		{
			get
			{
				return this.codeBranch_ ?? Version.CodeBranchDefaultValue;
			}
			set
			{
				this.codeBranch_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00030A20 File Offset: 0x0002EC20
		[DebuggerNonUserCode]
		public bool HasCodeBranch
		{
			get
			{
				return this.codeBranch_ != null;
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00030A3B File Offset: 0x0002EC3B
		[DebuggerNonUserCode]
		public void ClearCodeBranch()
		{
			this.codeBranch_ = null;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00030A48 File Offset: 0x0002EC48
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00030A69 File Offset: 0x0002EC69
		[DebuggerNonUserCode]
		public string DataBranch
		{
			get
			{
				return this.dataBranch_ ?? Version.DataBranchDefaultValue;
			}
			set
			{
				this.dataBranch_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00030A80 File Offset: 0x0002EC80
		[DebuggerNonUserCode]
		public bool HasDataBranch
		{
			get
			{
				return this.dataBranch_ != null;
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00030A9B File Offset: 0x0002EC9B
		[DebuggerNonUserCode]
		public void ClearDataBranch()
		{
			this.dataBranch_ = null;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00030AA8 File Offset: 0x0002ECA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Version);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		[DebuggerNonUserCode]
		public bool Equals(Version other)
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
					bool flag4 = this.BuildNum != other.BuildNum;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CodeBranch != other.CodeBranch;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DataBranch != other.DataBranch;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00030B54 File Offset: 0x0002ED54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBuildNum = this.HasBuildNum;
			if (hasBuildNum)
			{
				num ^= this.BuildNum.GetHashCode();
			}
			bool hasCodeBranch = this.HasCodeBranch;
			if (hasCodeBranch)
			{
				num ^= this.CodeBranch.GetHashCode();
			}
			bool hasDataBranch = this.HasDataBranch;
			if (hasDataBranch)
			{
				num ^= this.DataBranch.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00030BD8 File Offset: 0x0002EDD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00030BF0 File Offset: 0x0002EDF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00030BFC File Offset: 0x0002EDFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBuildNum = this.HasBuildNum;
			if (hasBuildNum)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuildNum);
			}
			bool hasCodeBranch = this.HasCodeBranch;
			if (hasCodeBranch)
			{
				output.WriteRawTag(18);
				output.WriteString(this.CodeBranch);
			}
			bool hasDataBranch = this.HasDataBranch;
			if (hasDataBranch)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DataBranch);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00030C8C File Offset: 0x0002EE8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBuildNum = this.HasBuildNum;
			if (hasBuildNum)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuildNum);
			}
			bool hasCodeBranch = this.HasCodeBranch;
			if (hasCodeBranch)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CodeBranch);
			}
			bool hasDataBranch = this.HasDataBranch;
			if (hasDataBranch)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DataBranch);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00030D18 File Offset: 0x0002EF18
		[DebuggerNonUserCode]
		public void MergeFrom(Version other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBuildNum = other.HasBuildNum;
				if (hasBuildNum)
				{
					this.BuildNum = other.BuildNum;
				}
				bool hasCodeBranch = other.HasCodeBranch;
				if (hasCodeBranch)
				{
					this.CodeBranch = other.CodeBranch;
				}
				bool hasDataBranch = other.HasDataBranch;
				if (hasDataBranch)
				{
					this.DataBranch = other.DataBranch;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00030D93 File Offset: 0x0002EF93
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DataBranch = input.ReadString();
						}
					}
					else
					{
						this.CodeBranch = input.ReadString();
					}
				}
				else
				{
					this.BuildNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000520 RID: 1312
		private static readonly MessageParser<Version> _parser = new MessageParser<Version>(() => new Version());

		// Token: 0x04000521 RID: 1313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000522 RID: 1314
		private int _hasBits0;

		// Token: 0x04000523 RID: 1315
		public const int BuildNumFieldNumber = 1;

		// Token: 0x04000524 RID: 1316
		private static readonly int BuildNumDefaultValue = 0;

		// Token: 0x04000525 RID: 1317
		private int buildNum_;

		// Token: 0x04000526 RID: 1318
		public const int CodeBranchFieldNumber = 2;

		// Token: 0x04000527 RID: 1319
		private static readonly string CodeBranchDefaultValue = "";

		// Token: 0x04000528 RID: 1320
		private string codeBranch_;

		// Token: 0x04000529 RID: 1321
		public const int DataBranchFieldNumber = 3;

		// Token: 0x0400052A RID: 1322
		private static readonly string DataBranchDefaultValue = "";

		// Token: 0x0400052B RID: 1323
		private string dataBranch_;
	}
}
