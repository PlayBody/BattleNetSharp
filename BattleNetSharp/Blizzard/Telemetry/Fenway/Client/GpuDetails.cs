using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000347 RID: 839
	public sealed class GpuDetails : IMessage<GpuDetails>, IMessage, IEquatable<GpuDetails>, IDeepCloneable<GpuDetails>, IBufferMessage
	{
		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x00152324 File Offset: 0x00150524
		[DebuggerNonUserCode]
		public static MessageParser<GpuDetails> Parser
		{
			get
			{
				return GpuDetails._parser;
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x0600575B RID: 22363 RVA: 0x0015233C File Offset: 0x0015053C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsSystemGpuReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x00152360 File Offset: 0x00150560
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuDetails.Descriptor;
			}
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x00152377 File Offset: 0x00150577
		[DebuggerNonUserCode]
		public GpuDetails()
		{
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x00152384 File Offset: 0x00150584
		[DebuggerNonUserCode]
		public GpuDetails(GpuDetails other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.vendorId_ = other.vendorId_;
			this.deviceId_ = other.deviceId_;
			this.deviceName_ = other.deviceName_;
			this.driverVersion_ = other.driverVersion_;
			this.videoMemorySizeGb_ = other.videoMemorySizeGb_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x001523F4 File Offset: 0x001505F4
		[DebuggerNonUserCode]
		public GpuDetails Clone()
		{
			return new GpuDetails(this);
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06005760 RID: 22368 RVA: 0x0015240C File Offset: 0x0015060C
		// (set) Token: 0x06005761 RID: 22369 RVA: 0x0015243D File Offset: 0x0015063D
		[DebuggerNonUserCode]
		public uint VendorId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint vendorIdDefaultValue;
				if (flag)
				{
					vendorIdDefaultValue = this.vendorId_;
				}
				else
				{
					vendorIdDefaultValue = GpuDetails.VendorIdDefaultValue;
				}
				return vendorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.vendorId_ = value;
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x00152458 File Offset: 0x00150658
		[DebuggerNonUserCode]
		public bool HasVendorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00152475 File Offset: 0x00150675
		[DebuggerNonUserCode]
		public void ClearVendorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x00152488 File Offset: 0x00150688
		// (set) Token: 0x06005765 RID: 22373 RVA: 0x001524B9 File Offset: 0x001506B9
		[DebuggerNonUserCode]
		public uint DeviceId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint deviceIdDefaultValue;
				if (flag)
				{
					deviceIdDefaultValue = this.deviceId_;
				}
				else
				{
					deviceIdDefaultValue = GpuDetails.DeviceIdDefaultValue;
				}
				return deviceIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.deviceId_ = value;
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x001524D4 File Offset: 0x001506D4
		[DebuggerNonUserCode]
		public bool HasDeviceId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x001524F1 File Offset: 0x001506F1
		[DebuggerNonUserCode]
		public void ClearDeviceId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x00152504 File Offset: 0x00150704
		// (set) Token: 0x06005769 RID: 22377 RVA: 0x00152525 File Offset: 0x00150725
		[DebuggerNonUserCode]
		public string DeviceName
		{
			get
			{
				return this.deviceName_ ?? GpuDetails.DeviceNameDefaultValue;
			}
			set
			{
				this.deviceName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x0015253C File Offset: 0x0015073C
		[DebuggerNonUserCode]
		public bool HasDeviceName
		{
			get
			{
				return this.deviceName_ != null;
			}
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x00152557 File Offset: 0x00150757
		[DebuggerNonUserCode]
		public void ClearDeviceName()
		{
			this.deviceName_ = null;
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x0600576C RID: 22380 RVA: 0x00152564 File Offset: 0x00150764
		// (set) Token: 0x0600576D RID: 22381 RVA: 0x00152595 File Offset: 0x00150795
		[DebuggerNonUserCode]
		public ulong DriverVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong driverVersionDefaultValue;
				if (flag)
				{
					driverVersionDefaultValue = this.driverVersion_;
				}
				else
				{
					driverVersionDefaultValue = GpuDetails.DriverVersionDefaultValue;
				}
				return driverVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.driverVersion_ = value;
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x0600576E RID: 22382 RVA: 0x001525B0 File Offset: 0x001507B0
		[DebuggerNonUserCode]
		public bool HasDriverVersion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x001525CD File Offset: 0x001507CD
		[DebuggerNonUserCode]
		public void ClearDriverVersion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06005770 RID: 22384 RVA: 0x001525E0 File Offset: 0x001507E0
		// (set) Token: 0x06005771 RID: 22385 RVA: 0x00152611 File Offset: 0x00150811
		[DebuggerNonUserCode]
		public float VideoMemorySizeGb
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float videoMemorySizeGbDefaultValue;
				if (flag)
				{
					videoMemorySizeGbDefaultValue = this.videoMemorySizeGb_;
				}
				else
				{
					videoMemorySizeGbDefaultValue = GpuDetails.VideoMemorySizeGbDefaultValue;
				}
				return videoMemorySizeGbDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.videoMemorySizeGb_ = value;
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x0015262C File Offset: 0x0015082C
		[DebuggerNonUserCode]
		public bool HasVideoMemorySizeGb
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x00152649 File Offset: 0x00150849
		[DebuggerNonUserCode]
		public void ClearVideoMemorySizeGb()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x0015265C File Offset: 0x0015085C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuDetails);
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x0015267C File Offset: 0x0015087C
		[DebuggerNonUserCode]
		public bool Equals(GpuDetails other)
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
					bool flag4 = this.VendorId != other.VendorId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DeviceId != other.DeviceId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DeviceName != other.DeviceName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.DriverVersion != other.DriverVersion;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VideoMemorySizeGb, other.VideoMemorySizeGb);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x00152750 File Offset: 0x00150950
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVendorId = this.HasVendorId;
			if (hasVendorId)
			{
				num ^= this.VendorId.GetHashCode();
			}
			bool hasDeviceId = this.HasDeviceId;
			if (hasDeviceId)
			{
				num ^= this.DeviceId.GetHashCode();
			}
			bool hasDeviceName = this.HasDeviceName;
			if (hasDeviceName)
			{
				num ^= this.DeviceName.GetHashCode();
			}
			bool hasDriverVersion = this.HasDriverVersion;
			if (hasDriverVersion)
			{
				num ^= this.DriverVersion.GetHashCode();
			}
			bool hasVideoMemorySizeGb = this.HasVideoMemorySizeGb;
			if (hasVideoMemorySizeGb)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VideoMemorySizeGb);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x00152814 File Offset: 0x00150A14
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x0015282C File Offset: 0x00150A2C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00152838 File Offset: 0x00150A38
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVendorId = this.HasVendorId;
			if (hasVendorId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.VendorId);
			}
			bool hasDeviceId = this.HasDeviceId;
			if (hasDeviceId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DeviceId);
			}
			bool hasDeviceName = this.HasDeviceName;
			if (hasDeviceName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DeviceName);
			}
			bool hasDriverVersion = this.HasDriverVersion;
			if (hasDriverVersion)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.DriverVersion);
			}
			bool hasVideoMemorySizeGb = this.HasVideoMemorySizeGb;
			if (hasVideoMemorySizeGb)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.VideoMemorySizeGb);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x00152910 File Offset: 0x00150B10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVendorId = this.HasVendorId;
			if (hasVendorId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.VendorId);
			}
			bool hasDeviceId = this.HasDeviceId;
			if (hasDeviceId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DeviceId);
			}
			bool hasDeviceName = this.HasDeviceName;
			if (hasDeviceName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DeviceName);
			}
			bool hasDriverVersion = this.HasDriverVersion;
			if (hasDriverVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.DriverVersion);
			}
			bool hasVideoMemorySizeGb = this.HasVideoMemorySizeGb;
			if (hasVideoMemorySizeGb)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x001529CC File Offset: 0x00150BCC
		[DebuggerNonUserCode]
		public void MergeFrom(GpuDetails other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVendorId = other.HasVendorId;
				if (hasVendorId)
				{
					this.VendorId = other.VendorId;
				}
				bool hasDeviceId = other.HasDeviceId;
				if (hasDeviceId)
				{
					this.DeviceId = other.DeviceId;
				}
				bool hasDeviceName = other.HasDeviceName;
				if (hasDeviceName)
				{
					this.DeviceName = other.DeviceName;
				}
				bool hasDriverVersion = other.HasDriverVersion;
				if (hasDriverVersion)
				{
					this.DriverVersion = other.DriverVersion;
				}
				bool hasVideoMemorySizeGb = other.HasVideoMemorySizeGb;
				if (hasVideoMemorySizeGb)
				{
					this.VideoMemorySizeGb = other.VideoMemorySizeGb;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x00152A80 File Offset: 0x00150C80
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x00152A8C File Offset: 0x00150C8C
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
						this.DeviceId = input.ReadUInt32();
					}
					else
					{
						this.VendorId = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						if (num3 != 53U)
						{
							goto IL_0032;
						}
						this.VideoMemorySizeGb = input.ReadFloat();
					}
					else
					{
						this.DriverVersion = input.ReadUInt64();
					}
				}
				else
				{
					this.DeviceName = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027E3 RID: 10211
		private static readonly MessageParser<GpuDetails> _parser = new MessageParser<GpuDetails>(() => new GpuDetails());

		// Token: 0x040027E4 RID: 10212
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027E5 RID: 10213
		private int _hasBits0;

		// Token: 0x040027E6 RID: 10214
		public const int VendorIdFieldNumber = 1;

		// Token: 0x040027E7 RID: 10215
		private static readonly uint VendorIdDefaultValue = 0U;

		// Token: 0x040027E8 RID: 10216
		private uint vendorId_;

		// Token: 0x040027E9 RID: 10217
		public const int DeviceIdFieldNumber = 2;

		// Token: 0x040027EA RID: 10218
		private static readonly uint DeviceIdDefaultValue = 0U;

		// Token: 0x040027EB RID: 10219
		private uint deviceId_;

		// Token: 0x040027EC RID: 10220
		public const int DeviceNameFieldNumber = 3;

		// Token: 0x040027ED RID: 10221
		private static readonly string DeviceNameDefaultValue = "";

		// Token: 0x040027EE RID: 10222
		private string deviceName_;

		// Token: 0x040027EF RID: 10223
		public const int DriverVersionFieldNumber = 4;

		// Token: 0x040027F0 RID: 10224
		private static readonly ulong DriverVersionDefaultValue = 0UL;

		// Token: 0x040027F1 RID: 10225
		private ulong driverVersion_;

		// Token: 0x040027F2 RID: 10226
		public const int VideoMemorySizeGbFieldNumber = 6;

		// Token: 0x040027F3 RID: 10227
		private static readonly float VideoMemorySizeGbDefaultValue = 0f;

		// Token: 0x040027F4 RID: 10228
		private float videoMemorySizeGb_;
	}
}
