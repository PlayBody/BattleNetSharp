using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000345 RID: 837
	public sealed class CpuDetails : IMessage<CpuDetails>, IMessage, IEquatable<CpuDetails>, IDeepCloneable<CpuDetails>, IBufferMessage
	{
		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06005733 RID: 22323 RVA: 0x00151A08 File Offset: 0x0014FC08
		[DebuggerNonUserCode]
		public static MessageParser<CpuDetails> Parser
		{
			get
			{
				return CpuDetails._parser;
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06005734 RID: 22324 RVA: 0x00151A20 File Offset: 0x0014FC20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsSystemCpuReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x00151A44 File Offset: 0x0014FC44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CpuDetails.Descriptor;
			}
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x00151A5B File Offset: 0x0014FC5B
		[DebuggerNonUserCode]
		public CpuDetails()
		{
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x00151A68 File Offset: 0x0014FC68
		[DebuggerNonUserCode]
		public CpuDetails(CpuDetails other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.vendor_ = other.vendor_;
			this.brand_ = other.brand_;
			this.frequency_ = other.frequency_;
			this.coreCount_ = other.coreCount_;
			this.hardwareThreadCount_ = other.hardwareThreadCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x00151AD8 File Offset: 0x0014FCD8
		[DebuggerNonUserCode]
		public CpuDetails Clone()
		{
			return new CpuDetails(this);
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x00151AF0 File Offset: 0x0014FCF0
		// (set) Token: 0x0600573A RID: 22330 RVA: 0x00151B11 File Offset: 0x0014FD11
		[DebuggerNonUserCode]
		public string Vendor
		{
			get
			{
				return this.vendor_ ?? CpuDetails.VendorDefaultValue;
			}
			set
			{
				this.vendor_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x00151B28 File Offset: 0x0014FD28
		[DebuggerNonUserCode]
		public bool HasVendor
		{
			get
			{
				return this.vendor_ != null;
			}
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x00151B43 File Offset: 0x0014FD43
		[DebuggerNonUserCode]
		public void ClearVendor()
		{
			this.vendor_ = null;
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x00151B50 File Offset: 0x0014FD50
		// (set) Token: 0x0600573E RID: 22334 RVA: 0x00151B71 File Offset: 0x0014FD71
		[DebuggerNonUserCode]
		public string Brand
		{
			get
			{
				return this.brand_ ?? CpuDetails.BrandDefaultValue;
			}
			set
			{
				this.brand_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x00151B88 File Offset: 0x0014FD88
		[DebuggerNonUserCode]
		public bool HasBrand
		{
			get
			{
				return this.brand_ != null;
			}
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x00151BA3 File Offset: 0x0014FDA3
		[DebuggerNonUserCode]
		public void ClearBrand()
		{
			this.brand_ = null;
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06005741 RID: 22337 RVA: 0x00151BB0 File Offset: 0x0014FDB0
		// (set) Token: 0x06005742 RID: 22338 RVA: 0x00151BE1 File Offset: 0x0014FDE1
		[DebuggerNonUserCode]
		public ulong Frequency
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong frequencyDefaultValue;
				if (flag)
				{
					frequencyDefaultValue = this.frequency_;
				}
				else
				{
					frequencyDefaultValue = CpuDetails.FrequencyDefaultValue;
				}
				return frequencyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.frequency_ = value;
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06005743 RID: 22339 RVA: 0x00151BFC File Offset: 0x0014FDFC
		[DebuggerNonUserCode]
		public bool HasFrequency
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x00151C19 File Offset: 0x0014FE19
		[DebuggerNonUserCode]
		public void ClearFrequency()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06005745 RID: 22341 RVA: 0x00151C2C File Offset: 0x0014FE2C
		// (set) Token: 0x06005746 RID: 22342 RVA: 0x00151C5D File Offset: 0x0014FE5D
		[DebuggerNonUserCode]
		public uint CoreCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint coreCountDefaultValue;
				if (flag)
				{
					coreCountDefaultValue = this.coreCount_;
				}
				else
				{
					coreCountDefaultValue = CpuDetails.CoreCountDefaultValue;
				}
				return coreCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.coreCount_ = value;
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06005747 RID: 22343 RVA: 0x00151C78 File Offset: 0x0014FE78
		[DebuggerNonUserCode]
		public bool HasCoreCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x00151C95 File Offset: 0x0014FE95
		[DebuggerNonUserCode]
		public void ClearCoreCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06005749 RID: 22345 RVA: 0x00151CA8 File Offset: 0x0014FEA8
		// (set) Token: 0x0600574A RID: 22346 RVA: 0x00151CD9 File Offset: 0x0014FED9
		[DebuggerNonUserCode]
		public uint HardwareThreadCount
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint hardwareThreadCountDefaultValue;
				if (flag)
				{
					hardwareThreadCountDefaultValue = this.hardwareThreadCount_;
				}
				else
				{
					hardwareThreadCountDefaultValue = CpuDetails.HardwareThreadCountDefaultValue;
				}
				return hardwareThreadCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.hardwareThreadCount_ = value;
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x0600574B RID: 22347 RVA: 0x00151CF4 File Offset: 0x0014FEF4
		[DebuggerNonUserCode]
		public bool HasHardwareThreadCount
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x00151D11 File Offset: 0x0014FF11
		[DebuggerNonUserCode]
		public void ClearHardwareThreadCount()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x00151D24 File Offset: 0x0014FF24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CpuDetails);
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00151D44 File Offset: 0x0014FF44
		[DebuggerNonUserCode]
		public bool Equals(CpuDetails other)
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
					bool flag4 = this.Vendor != other.Vendor;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Brand != other.Brand;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Frequency != other.Frequency;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CoreCount != other.CoreCount;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.HardwareThreadCount != other.HardwareThreadCount;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00151E10 File Offset: 0x00150010
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVendor = this.HasVendor;
			if (hasVendor)
			{
				num ^= this.Vendor.GetHashCode();
			}
			bool hasBrand = this.HasBrand;
			if (hasBrand)
			{
				num ^= this.Brand.GetHashCode();
			}
			bool hasFrequency = this.HasFrequency;
			if (hasFrequency)
			{
				num ^= this.Frequency.GetHashCode();
			}
			bool hasCoreCount = this.HasCoreCount;
			if (hasCoreCount)
			{
				num ^= this.CoreCount.GetHashCode();
			}
			bool hasHardwareThreadCount = this.HasHardwareThreadCount;
			if (hasHardwareThreadCount)
			{
				num ^= this.HardwareThreadCount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x00151ED0 File Offset: 0x001500D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00151EE8 File Offset: 0x001500E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00151EF4 File Offset: 0x001500F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVendor = this.HasVendor;
			if (hasVendor)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Vendor);
			}
			bool hasBrand = this.HasBrand;
			if (hasBrand)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Brand);
			}
			bool hasFrequency = this.HasFrequency;
			if (hasFrequency)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Frequency);
			}
			bool hasCoreCount = this.HasCoreCount;
			if (hasCoreCount)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CoreCount);
			}
			bool hasHardwareThreadCount = this.HasHardwareThreadCount;
			if (hasHardwareThreadCount)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HardwareThreadCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x00151FCC File Offset: 0x001501CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVendor = this.HasVendor;
			if (hasVendor)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Vendor);
			}
			bool hasBrand = this.HasBrand;
			if (hasBrand)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Brand);
			}
			bool hasFrequency = this.HasFrequency;
			if (hasFrequency)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Frequency);
			}
			bool hasCoreCount = this.HasCoreCount;
			if (hasCoreCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CoreCount);
			}
			bool hasHardwareThreadCount = this.HasHardwareThreadCount;
			if (hasHardwareThreadCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HardwareThreadCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x00152094 File Offset: 0x00150294
		[DebuggerNonUserCode]
		public void MergeFrom(CpuDetails other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVendor = other.HasVendor;
				if (hasVendor)
				{
					this.Vendor = other.Vendor;
				}
				bool hasBrand = other.HasBrand;
				if (hasBrand)
				{
					this.Brand = other.Brand;
				}
				bool hasFrequency = other.HasFrequency;
				if (hasFrequency)
				{
					this.Frequency = other.Frequency;
				}
				bool hasCoreCount = other.HasCoreCount;
				if (hasCoreCount)
				{
					this.CoreCount = other.CoreCount;
				}
				bool hasHardwareThreadCount = other.HasHardwareThreadCount;
				if (hasHardwareThreadCount)
				{
					this.HardwareThreadCount = other.HardwareThreadCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x00152148 File Offset: 0x00150348
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x00152154 File Offset: 0x00150354
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.Brand = input.ReadString();
					}
					else
					{
						this.Vendor = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.HardwareThreadCount = input.ReadUInt32();
					}
					else
					{
						this.CoreCount = input.ReadUInt32();
					}
				}
				else
				{
					this.Frequency = input.ReadUInt64();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027D0 RID: 10192
		private static readonly MessageParser<CpuDetails> _parser = new MessageParser<CpuDetails>(() => new CpuDetails());

		// Token: 0x040027D1 RID: 10193
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027D2 RID: 10194
		private int _hasBits0;

		// Token: 0x040027D3 RID: 10195
		public const int VendorFieldNumber = 1;

		// Token: 0x040027D4 RID: 10196
		private static readonly string VendorDefaultValue = "";

		// Token: 0x040027D5 RID: 10197
		private string vendor_;

		// Token: 0x040027D6 RID: 10198
		public const int BrandFieldNumber = 2;

		// Token: 0x040027D7 RID: 10199
		private static readonly string BrandDefaultValue = "";

		// Token: 0x040027D8 RID: 10200
		private string brand_;

		// Token: 0x040027D9 RID: 10201
		public const int FrequencyFieldNumber = 3;

		// Token: 0x040027DA RID: 10202
		private static readonly ulong FrequencyDefaultValue = 0UL;

		// Token: 0x040027DB RID: 10203
		private ulong frequency_;

		// Token: 0x040027DC RID: 10204
		public const int CoreCountFieldNumber = 4;

		// Token: 0x040027DD RID: 10205
		private static readonly uint CoreCountDefaultValue = 0U;

		// Token: 0x040027DE RID: 10206
		private uint coreCount_;

		// Token: 0x040027DF RID: 10207
		public const int HardwareThreadCountFieldNumber = 5;

		// Token: 0x040027E0 RID: 10208
		private static readonly uint HardwareThreadCountDefaultValue = 0U;

		// Token: 0x040027E1 RID: 10209
		private uint hardwareThreadCount_;
	}
}
