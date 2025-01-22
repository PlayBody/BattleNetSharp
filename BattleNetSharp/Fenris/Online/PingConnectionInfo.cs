using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000144 RID: 324
	public sealed class PingConnectionInfo : IMessage<PingConnectionInfo>, IMessage, IEquatable<PingConnectionInfo>, IDeepCloneable<PingConnectionInfo>, IBufferMessage
	{
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x00082C28 File Offset: 0x00080E28
		[DebuggerNonUserCode]
		public static MessageParser<PingConnectionInfo> Parser
		{
			get
			{
				return PingConnectionInfo._parser;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x00082C40 File Offset: 0x00080E40
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x00082C64 File Offset: 0x00080E64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PingConnectionInfo.Descriptor;
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00082C7B File Offset: 0x00080E7B
		[DebuggerNonUserCode]
		public PingConnectionInfo()
		{
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00082C88 File Offset: 0x00080E88
		[DebuggerNonUserCode]
		public PingConnectionInfo(PingConnectionInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.address_ = other.address_;
			this.port_ = other.port_;
			this.encryptionInfo_ = ((other.encryptionInfo_ != null) ? other.encryptionInfo_.Clone() : null);
			this.serverPool_ = other.serverPool_;
			this.maxSampleInterval_ = other.maxSampleInterval_;
			this.captureDuration_ = other.captureDuration_;
			this.minSamples_ = other.minSamples_;
			this.maxSamples_ = other.maxSamples_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00082D2C File Offset: 0x00080F2C
		[DebuggerNonUserCode]
		public PingConnectionInfo Clone()
		{
			return new PingConnectionInfo(this);
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x00082D44 File Offset: 0x00080F44
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00082D65 File Offset: 0x00080F65
		[DebuggerNonUserCode]
		public string Address
		{
			get
			{
				return this.address_ ?? PingConnectionInfo.AddressDefaultValue;
			}
			set
			{
				this.address_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x00082D7C File Offset: 0x00080F7C
		[DebuggerNonUserCode]
		public bool HasAddress
		{
			get
			{
				return this.address_ != null;
			}
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00082D97 File Offset: 0x00080F97
		[DebuggerNonUserCode]
		public void ClearAddress()
		{
			this.address_ = null;
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x00082DA4 File Offset: 0x00080FA4
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00082DD5 File Offset: 0x00080FD5
		[DebuggerNonUserCode]
		public uint Port
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint portDefaultValue;
				if (flag)
				{
					portDefaultValue = this.port_;
				}
				else
				{
					portDefaultValue = PingConnectionInfo.PortDefaultValue;
				}
				return portDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.port_ = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x00082DF0 File Offset: 0x00080FF0
		[DebuggerNonUserCode]
		public bool HasPort
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00082E0D File Offset: 0x0008100D
		[DebuggerNonUserCode]
		public void ClearPort()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x00082E20 File Offset: 0x00081020
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x00082E38 File Offset: 0x00081038
		[DebuggerNonUserCode]
		public ConnectionEncryptionInfo EncryptionInfo
		{
			get
			{
				return this.encryptionInfo_;
			}
			set
			{
				this.encryptionInfo_ = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x00082E44 File Offset: 0x00081044
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00082E65 File Offset: 0x00081065
		[DebuggerNonUserCode]
		public string ServerPool
		{
			get
			{
				return this.serverPool_ ?? PingConnectionInfo.ServerPoolDefaultValue;
			}
			set
			{
				this.serverPool_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x00082E7C File Offset: 0x0008107C
		[DebuggerNonUserCode]
		public bool HasServerPool
		{
			get
			{
				return this.serverPool_ != null;
			}
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00082E97 File Offset: 0x00081097
		[DebuggerNonUserCode]
		public void ClearServerPool()
		{
			this.serverPool_ = null;
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x00082EA4 File Offset: 0x000810A4
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00082ED5 File Offset: 0x000810D5
		[DebuggerNonUserCode]
		public uint MaxSampleInterval
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint maxSampleIntervalDefaultValue;
				if (flag)
				{
					maxSampleIntervalDefaultValue = this.maxSampleInterval_;
				}
				else
				{
					maxSampleIntervalDefaultValue = PingConnectionInfo.MaxSampleIntervalDefaultValue;
				}
				return maxSampleIntervalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.maxSampleInterval_ = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00082EF0 File Offset: 0x000810F0
		[DebuggerNonUserCode]
		public bool HasMaxSampleInterval
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00082F0D File Offset: 0x0008110D
		[DebuggerNonUserCode]
		public void ClearMaxSampleInterval()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x00082F20 File Offset: 0x00081120
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x00082F51 File Offset: 0x00081151
		[DebuggerNonUserCode]
		public uint CaptureDuration
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint captureDurationDefaultValue;
				if (flag)
				{
					captureDurationDefaultValue = this.captureDuration_;
				}
				else
				{
					captureDurationDefaultValue = PingConnectionInfo.CaptureDurationDefaultValue;
				}
				return captureDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.captureDuration_ = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x00082F6C File Offset: 0x0008116C
		[DebuggerNonUserCode]
		public bool HasCaptureDuration
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00082F89 File Offset: 0x00081189
		[DebuggerNonUserCode]
		public void ClearCaptureDuration()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x00082F9C File Offset: 0x0008119C
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x00082FCD File Offset: 0x000811CD
		[DebuggerNonUserCode]
		public uint MinSamples
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint minSamplesDefaultValue;
				if (flag)
				{
					minSamplesDefaultValue = this.minSamples_;
				}
				else
				{
					minSamplesDefaultValue = PingConnectionInfo.MinSamplesDefaultValue;
				}
				return minSamplesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.minSamples_ = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x00082FE8 File Offset: 0x000811E8
		[DebuggerNonUserCode]
		public bool HasMinSamples
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00083005 File Offset: 0x00081205
		[DebuggerNonUserCode]
		public void ClearMinSamples()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x00083018 File Offset: 0x00081218
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x0008304A File Offset: 0x0008124A
		[DebuggerNonUserCode]
		public uint MaxSamples
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint maxSamplesDefaultValue;
				if (flag)
				{
					maxSamplesDefaultValue = this.maxSamples_;
				}
				else
				{
					maxSamplesDefaultValue = PingConnectionInfo.MaxSamplesDefaultValue;
				}
				return maxSamplesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.maxSamples_ = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00083064 File Offset: 0x00081264
		[DebuggerNonUserCode]
		public bool HasMaxSamples
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00083082 File Offset: 0x00081282
		[DebuggerNonUserCode]
		public void ClearMaxSamples()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00083094 File Offset: 0x00081294
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PingConnectionInfo);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000830B4 File Offset: 0x000812B4
		[DebuggerNonUserCode]
		public bool Equals(PingConnectionInfo other)
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
					bool flag4 = this.Address != other.Address;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Port != other.Port;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.EncryptionInfo, other.EncryptionInfo);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ServerPool != other.ServerPool;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.MaxSampleInterval != other.MaxSampleInterval;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CaptureDuration != other.CaptureDuration;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.MinSamples != other.MinSamples;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MaxSamples != other.MaxSamples;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000831DC File Offset: 0x000813DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				num ^= this.Address.GetHashCode();
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num ^= this.Port.GetHashCode();
			}
			bool flag = this.encryptionInfo_ != null;
			if (flag)
			{
				num ^= this.EncryptionInfo.GetHashCode();
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num ^= this.ServerPool.GetHashCode();
			}
			bool hasMaxSampleInterval = this.HasMaxSampleInterval;
			if (hasMaxSampleInterval)
			{
				num ^= this.MaxSampleInterval.GetHashCode();
			}
			bool hasCaptureDuration = this.HasCaptureDuration;
			if (hasCaptureDuration)
			{
				num ^= this.CaptureDuration.GetHashCode();
			}
			bool hasMinSamples = this.HasMinSamples;
			if (hasMinSamples)
			{
				num ^= this.MinSamples.GetHashCode();
			}
			bool hasMaxSamples = this.HasMaxSamples;
			if (hasMaxSamples)
			{
				num ^= this.MaxSamples.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000832F0 File Offset: 0x000814F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00083308 File Offset: 0x00081508
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00083314 File Offset: 0x00081514
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Address);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Port);
			}
			bool flag = this.encryptionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.EncryptionInfo);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ServerPool);
			}
			bool hasMaxSampleInterval = this.HasMaxSampleInterval;
			if (hasMaxSampleInterval)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MaxSampleInterval);
			}
			bool hasCaptureDuration = this.HasCaptureDuration;
			if (hasCaptureDuration)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CaptureDuration);
			}
			bool hasMinSamples = this.HasMinSamples;
			if (hasMinSamples)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MinSamples);
			}
			bool hasMaxSamples = this.HasMaxSamples;
			if (hasMaxSamples)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MaxSamples);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x0008345C File Offset: 0x0008165C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAddress = this.HasAddress;
			if (hasAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Address);
			}
			bool hasPort = this.HasPort;
			if (hasPort)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Port);
			}
			bool flag = this.encryptionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EncryptionInfo);
			}
			bool hasServerPool = this.HasServerPool;
			if (hasServerPool)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerPool);
			}
			bool hasMaxSampleInterval = this.HasMaxSampleInterval;
			if (hasMaxSampleInterval)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxSampleInterval);
			}
			bool hasCaptureDuration = this.HasCaptureDuration;
			if (hasCaptureDuration)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CaptureDuration);
			}
			bool hasMinSamples = this.HasMinSamples;
			if (hasMinSamples)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinSamples);
			}
			bool hasMaxSamples = this.HasMaxSamples;
			if (hasMaxSamples)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxSamples);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00083580 File Offset: 0x00081780
		[DebuggerNonUserCode]
		public void MergeFrom(PingConnectionInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAddress = other.HasAddress;
				if (hasAddress)
				{
					this.Address = other.Address;
				}
				bool hasPort = other.HasPort;
				if (hasPort)
				{
					this.Port = other.Port;
				}
				bool flag2 = other.encryptionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.encryptionInfo_ == null;
					if (flag3)
					{
						this.EncryptionInfo = new ConnectionEncryptionInfo();
					}
					this.EncryptionInfo.MergeFrom(other.EncryptionInfo);
				}
				bool hasServerPool = other.HasServerPool;
				if (hasServerPool)
				{
					this.ServerPool = other.ServerPool;
				}
				bool hasMaxSampleInterval = other.HasMaxSampleInterval;
				if (hasMaxSampleInterval)
				{
					this.MaxSampleInterval = other.MaxSampleInterval;
				}
				bool hasCaptureDuration = other.HasCaptureDuration;
				if (hasCaptureDuration)
				{
					this.CaptureDuration = other.CaptureDuration;
				}
				bool hasMinSamples = other.HasMinSamples;
				if (hasMinSamples)
				{
					this.MinSamples = other.MinSamples;
				}
				bool hasMaxSamples = other.HasMaxSamples;
				if (hasMaxSamples)
				{
					this.MaxSamples = other.MaxSamples;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000836AA File Offset: 0x000818AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000836B8 File Offset: 0x000818B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								goto IL_0061;
							}
							this.Port = input.ReadUInt32();
						}
						else
						{
							this.Address = input.ReadString();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0061;
						}
						this.ServerPool = input.ReadString();
					}
					else
					{
						bool flag = this.encryptionInfo_ == null;
						if (flag)
						{
							this.EncryptionInfo = new ConnectionEncryptionInfo();
						}
						input.ReadMessage(this.EncryptionInfo);
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0061;
						}
						this.CaptureDuration = input.ReadUInt32();
					}
					else
					{
						this.MaxSampleInterval = input.ReadUInt32();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						goto IL_0061;
					}
					this.MaxSamples = input.ReadUInt32();
				}
				else
				{
					this.MinSamples = input.ReadUInt32();
				}
				continue;
				IL_0061:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000ECD RID: 3789
		private static readonly MessageParser<PingConnectionInfo> _parser = new MessageParser<PingConnectionInfo>(() => new PingConnectionInfo());

		// Token: 0x04000ECE RID: 3790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ECF RID: 3791
		private int _hasBits0;

		// Token: 0x04000ED0 RID: 3792
		public const int AddressFieldNumber = 1;

		// Token: 0x04000ED1 RID: 3793
		private static readonly string AddressDefaultValue = "";

		// Token: 0x04000ED2 RID: 3794
		private string address_;

		// Token: 0x04000ED3 RID: 3795
		public const int PortFieldNumber = 2;

		// Token: 0x04000ED4 RID: 3796
		private static readonly uint PortDefaultValue = 0U;

		// Token: 0x04000ED5 RID: 3797
		private uint port_;

		// Token: 0x04000ED6 RID: 3798
		public const int EncryptionInfoFieldNumber = 3;

		// Token: 0x04000ED7 RID: 3799
		private ConnectionEncryptionInfo encryptionInfo_;

		// Token: 0x04000ED8 RID: 3800
		public const int ServerPoolFieldNumber = 4;

		// Token: 0x04000ED9 RID: 3801
		private static readonly string ServerPoolDefaultValue = "";

		// Token: 0x04000EDA RID: 3802
		private string serverPool_;

		// Token: 0x04000EDB RID: 3803
		public const int MaxSampleIntervalFieldNumber = 5;

		// Token: 0x04000EDC RID: 3804
		private static readonly uint MaxSampleIntervalDefaultValue = 0U;

		// Token: 0x04000EDD RID: 3805
		private uint maxSampleInterval_;

		// Token: 0x04000EDE RID: 3806
		public const int CaptureDurationFieldNumber = 6;

		// Token: 0x04000EDF RID: 3807
		private static readonly uint CaptureDurationDefaultValue = 0U;

		// Token: 0x04000EE0 RID: 3808
		private uint captureDuration_;

		// Token: 0x04000EE1 RID: 3809
		public const int MinSamplesFieldNumber = 7;

		// Token: 0x04000EE2 RID: 3810
		private static readonly uint MinSamplesDefaultValue = 0U;

		// Token: 0x04000EE3 RID: 3811
		private uint minSamples_;

		// Token: 0x04000EE4 RID: 3812
		public const int MaxSamplesFieldNumber = 8;

		// Token: 0x04000EE5 RID: 3813
		private static readonly uint MaxSamplesDefaultValue = 0U;

		// Token: 0x04000EE6 RID: 3814
		private uint maxSamples_;
	}
}
