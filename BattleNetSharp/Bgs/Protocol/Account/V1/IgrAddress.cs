using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000752 RID: 1874
	public sealed class IgrAddress : IMessage<IgrAddress>, IMessage, IEquatable<IgrAddress>, IDeepCloneable<IgrAddress>, IBufferMessage
	{
		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x002A0400 File Offset: 0x0029E600
		[DebuggerNonUserCode]
		public static MessageParser<IgrAddress> Parser
		{
			get
			{
				return IgrAddress._parser;
			}
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600AC8E RID: 44174 RVA: 0x002A0418 File Offset: 0x0029E618
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[34];
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600AC8F RID: 44175 RVA: 0x002A043C File Offset: 0x0029E63C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IgrAddress.Descriptor;
			}
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x002A0453 File Offset: 0x0029E653
		[DebuggerNonUserCode]
		public IgrAddress()
		{
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x002A045D File Offset: 0x0029E65D
		[DebuggerNonUserCode]
		public IgrAddress(IgrAddress other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientAddress_ = other.clientAddress_;
			this.region_ = other.region_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x002A049C File Offset: 0x0029E69C
		[DebuggerNonUserCode]
		public IgrAddress Clone()
		{
			return new IgrAddress(this);
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600AC93 RID: 44179 RVA: 0x002A04B4 File Offset: 0x0029E6B4
		// (set) Token: 0x0600AC94 RID: 44180 RVA: 0x002A04D5 File Offset: 0x0029E6D5
		[DebuggerNonUserCode]
		public string ClientAddress
		{
			get
			{
				return this.clientAddress_ ?? IgrAddress.ClientAddressDefaultValue;
			}
			set
			{
				this.clientAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600AC95 RID: 44181 RVA: 0x002A04EC File Offset: 0x0029E6EC
		[DebuggerNonUserCode]
		public bool HasClientAddress
		{
			get
			{
				return this.clientAddress_ != null;
			}
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x002A0507 File Offset: 0x0029E707
		[DebuggerNonUserCode]
		public void ClearClientAddress()
		{
			this.clientAddress_ = null;
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x002A0514 File Offset: 0x0029E714
		// (set) Token: 0x0600AC98 RID: 44184 RVA: 0x002A0545 File Offset: 0x0029E745
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = IgrAddress.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.region_ = value;
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600AC99 RID: 44185 RVA: 0x002A0560 File Offset: 0x0029E760
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x002A057D File Offset: 0x0029E77D
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x002A0590 File Offset: 0x0029E790
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as IgrAddress);
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x002A05B0 File Offset: 0x0029E7B0
		[DebuggerNonUserCode]
		public bool Equals(IgrAddress other)
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
					bool flag4 = this.ClientAddress != other.ClientAddress;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Region != other.Region;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x002A0624 File Offset: 0x0029E824
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num ^= this.ClientAddress.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x002A0690 File Offset: 0x0029E890
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x002A06A8 File Offset: 0x0029E8A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x002A06B4 File Offset: 0x0029E8B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClientAddress);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACA1 RID: 44193 RVA: 0x002A0724 File Offset: 0x0029E924
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x002A0790 File Offset: 0x0029E990
		[DebuggerNonUserCode]
		public void MergeFrom(IgrAddress other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientAddress = other.HasClientAddress;
				if (hasClientAddress)
				{
					this.ClientAddress = other.ClientAddress;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x002A07F2 File Offset: 0x0029E9F2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x002A0800 File Offset: 0x0029EA00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Region = input.ReadUInt32();
					}
				}
				else
				{
					this.ClientAddress = input.ReadString();
				}
			}
		}

		// Token: 0x04004DB2 RID: 19890
		private static readonly MessageParser<IgrAddress> _parser = new MessageParser<IgrAddress>(() => new IgrAddress());

		// Token: 0x04004DB3 RID: 19891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DB4 RID: 19892
		private int _hasBits0;

		// Token: 0x04004DB5 RID: 19893
		public const int ClientAddressFieldNumber = 1;

		// Token: 0x04004DB6 RID: 19894
		private static readonly string ClientAddressDefaultValue = "";

		// Token: 0x04004DB7 RID: 19895
		private string clientAddress_;

		// Token: 0x04004DB8 RID: 19896
		public const int RegionFieldNumber = 2;

		// Token: 0x04004DB9 RID: 19897
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004DBA RID: 19898
		private uint region_;
	}
}
