using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000066 RID: 102
	public sealed class BuildTOCRequest : IMessage<BuildTOCRequest>, IMessage, IEquatable<BuildTOCRequest>, IDeepCloneable<BuildTOCRequest>, IBufferMessage
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00023728 File Offset: 0x00021928
		[DebuggerNonUserCode]
		public static MessageParser<BuildTOCRequest> Parser
		{
			get
			{
				return BuildTOCRequest._parser;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00023740 File Offset: 0x00021940
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[79];
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00023764 File Offset: 0x00021964
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildTOCRequest.Descriptor;
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0002377B File Offset: 0x0002197B
		[DebuggerNonUserCode]
		public BuildTOCRequest()
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00023788 File Offset: 0x00021988
		[DebuggerNonUserCode]
		public BuildTOCRequest(BuildTOCRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.platform_ = other.platform_;
			this.globalSnos_ = other.globalSnos_;
			this.excludedSnos_ = other.excludedSnos_;
			this.excludedGroups_ = other.excludedGroups_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000237EC File Offset: 0x000219EC
		[DebuggerNonUserCode]
		public BuildTOCRequest Clone()
		{
			return new BuildTOCRequest(this);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00023804 File Offset: 0x00021A04
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00023835 File Offset: 0x00021A35
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
					platformDefaultValue = BuildTOCRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platform_ = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00023850 File Offset: 0x00021A50
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0002386D File Offset: 0x00021A6D
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00023880 File Offset: 0x00021A80
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x000238A1 File Offset: 0x00021AA1
		[DebuggerNonUserCode]
		public string GlobalSnos
		{
			get
			{
				return this.globalSnos_ ?? BuildTOCRequest.GlobalSnosDefaultValue;
			}
			set
			{
				this.globalSnos_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x000238B8 File Offset: 0x00021AB8
		[DebuggerNonUserCode]
		public bool HasGlobalSnos
		{
			get
			{
				return this.globalSnos_ != null;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000238D3 File Offset: 0x00021AD3
		[DebuggerNonUserCode]
		public void ClearGlobalSnos()
		{
			this.globalSnos_ = null;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x000238E0 File Offset: 0x00021AE0
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00023901 File Offset: 0x00021B01
		[DebuggerNonUserCode]
		public string ExcludedSnos
		{
			get
			{
				return this.excludedSnos_ ?? BuildTOCRequest.ExcludedSnosDefaultValue;
			}
			set
			{
				this.excludedSnos_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00023918 File Offset: 0x00021B18
		[DebuggerNonUserCode]
		public bool HasExcludedSnos
		{
			get
			{
				return this.excludedSnos_ != null;
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00023933 File Offset: 0x00021B33
		[DebuggerNonUserCode]
		public void ClearExcludedSnos()
		{
			this.excludedSnos_ = null;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00023940 File Offset: 0x00021B40
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00023961 File Offset: 0x00021B61
		[DebuggerNonUserCode]
		public string ExcludedGroups
		{
			get
			{
				return this.excludedGroups_ ?? BuildTOCRequest.ExcludedGroupsDefaultValue;
			}
			set
			{
				this.excludedGroups_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00023978 File Offset: 0x00021B78
		[DebuggerNonUserCode]
		public bool HasExcludedGroups
		{
			get
			{
				return this.excludedGroups_ != null;
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00023993 File Offset: 0x00021B93
		[DebuggerNonUserCode]
		public void ClearExcludedGroups()
		{
			this.excludedGroups_ = null;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000239A0 File Offset: 0x00021BA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildTOCRequest);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000239C0 File Offset: 0x00021BC0
		[DebuggerNonUserCode]
		public bool Equals(BuildTOCRequest other)
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
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00023A6C File Offset: 0x00021C6C
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00023B0C File Offset: 0x00021D0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00023B24 File Offset: 0x00021D24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00023B30 File Offset: 0x00021D30
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00023BE4 File Offset: 0x00021DE4
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00023C8C File Offset: 0x00021E8C
		[DebuggerNonUserCode]
		public void MergeFrom(BuildTOCRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00023D22 File Offset: 0x00021F22
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00023D30 File Offset: 0x00021F30
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
							goto IL_0028;
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
						goto IL_0028;
					}
					this.ExcludedGroups = input.ReadString();
				}
				else
				{
					this.ExcludedSnos = input.ReadString();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400037F RID: 895
		private static readonly MessageParser<BuildTOCRequest> _parser = new MessageParser<BuildTOCRequest>(() => new BuildTOCRequest());

		// Token: 0x04000380 RID: 896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000381 RID: 897
		private int _hasBits0;

		// Token: 0x04000382 RID: 898
		public const int PlatformFieldNumber = 1;

		// Token: 0x04000383 RID: 899
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x04000384 RID: 900
		private int platform_;

		// Token: 0x04000385 RID: 901
		public const int GlobalSnosFieldNumber = 2;

		// Token: 0x04000386 RID: 902
		private static readonly string GlobalSnosDefaultValue = "";

		// Token: 0x04000387 RID: 903
		private string globalSnos_;

		// Token: 0x04000388 RID: 904
		public const int ExcludedSnosFieldNumber = 3;

		// Token: 0x04000389 RID: 905
		private static readonly string ExcludedSnosDefaultValue = "";

		// Token: 0x0400038A RID: 906
		private string excludedSnos_;

		// Token: 0x0400038B RID: 907
		public const int ExcludedGroupsFieldNumber = 4;

		// Token: 0x0400038C RID: 908
		private static readonly string ExcludedGroupsDefaultValue = "";

		// Token: 0x0400038D RID: 909
		private string excludedGroups_;
	}
}
