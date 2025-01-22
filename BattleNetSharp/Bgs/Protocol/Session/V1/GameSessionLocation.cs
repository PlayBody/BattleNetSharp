using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000550 RID: 1360
	public sealed class GameSessionLocation : IMessage<GameSessionLocation>, IMessage, IEquatable<GameSessionLocation>, IDeepCloneable<GameSessionLocation>, IBufferMessage
	{
		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600837C RID: 33660 RVA: 0x001FFB50 File Offset: 0x001FDD50
		[DebuggerNonUserCode]
		public static MessageParser<GameSessionLocation> Parser
		{
			get
			{
				return GameSessionLocation._parser;
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600837D RID: 33661 RVA: 0x001FFB68 File Offset: 0x001FDD68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600837E RID: 33662 RVA: 0x001FFB8C File Offset: 0x001FDD8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionLocation.Descriptor;
			}
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x001FFBA3 File Offset: 0x001FDDA3
		[DebuggerNonUserCode]
		public GameSessionLocation()
		{
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x001FFBB0 File Offset: 0x001FDDB0
		[DebuggerNonUserCode]
		public GameSessionLocation(GameSessionLocation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ipAddress_ = other.ipAddress_;
			this.country_ = other.country_;
			this.city_ = other.city_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x001FFC08 File Offset: 0x001FDE08
		[DebuggerNonUserCode]
		public GameSessionLocation Clone()
		{
			return new GameSessionLocation(this);
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x06008382 RID: 33666 RVA: 0x001FFC20 File Offset: 0x001FDE20
		// (set) Token: 0x06008383 RID: 33667 RVA: 0x001FFC41 File Offset: 0x001FDE41
		[DebuggerNonUserCode]
		public string IpAddress
		{
			get
			{
				return this.ipAddress_ ?? GameSessionLocation.IpAddressDefaultValue;
			}
			set
			{
				this.ipAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x06008384 RID: 33668 RVA: 0x001FFC58 File Offset: 0x001FDE58
		[DebuggerNonUserCode]
		public bool HasIpAddress
		{
			get
			{
				return this.ipAddress_ != null;
			}
		}

		// Token: 0x06008385 RID: 33669 RVA: 0x001FFC73 File Offset: 0x001FDE73
		[DebuggerNonUserCode]
		public void ClearIpAddress()
		{
			this.ipAddress_ = null;
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x06008386 RID: 33670 RVA: 0x001FFC80 File Offset: 0x001FDE80
		// (set) Token: 0x06008387 RID: 33671 RVA: 0x001FFCB1 File Offset: 0x001FDEB1
		[DebuggerNonUserCode]
		public uint Country
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint countryDefaultValue;
				if (flag)
				{
					countryDefaultValue = this.country_;
				}
				else
				{
					countryDefaultValue = GameSessionLocation.CountryDefaultValue;
				}
				return countryDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.country_ = value;
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x06008388 RID: 33672 RVA: 0x001FFCCC File Offset: 0x001FDECC
		[DebuggerNonUserCode]
		public bool HasCountry
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x001FFCE9 File Offset: 0x001FDEE9
		[DebuggerNonUserCode]
		public void ClearCountry()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600838A RID: 33674 RVA: 0x001FFCFC File Offset: 0x001FDEFC
		// (set) Token: 0x0600838B RID: 33675 RVA: 0x001FFD1D File Offset: 0x001FDF1D
		[DebuggerNonUserCode]
		public string City
		{
			get
			{
				return this.city_ ?? GameSessionLocation.CityDefaultValue;
			}
			set
			{
				this.city_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600838C RID: 33676 RVA: 0x001FFD34 File Offset: 0x001FDF34
		[DebuggerNonUserCode]
		public bool HasCity
		{
			get
			{
				return this.city_ != null;
			}
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x001FFD4F File Offset: 0x001FDF4F
		[DebuggerNonUserCode]
		public void ClearCity()
		{
			this.city_ = null;
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x001FFD5C File Offset: 0x001FDF5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionLocation);
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x001FFD7C File Offset: 0x001FDF7C
		[DebuggerNonUserCode]
		public bool Equals(GameSessionLocation other)
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
					bool flag4 = this.IpAddress != other.IpAddress;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Country != other.Country;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.City != other.City;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x001FFE08 File Offset: 0x001FE008
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				num ^= this.IpAddress.GetHashCode();
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num ^= this.Country.GetHashCode();
			}
			bool hasCity = this.HasCity;
			if (hasCity)
			{
				num ^= this.City.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x001FFE8C File Offset: 0x001FE08C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x001FFEA4 File Offset: 0x001FE0A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008393 RID: 33683 RVA: 0x001FFEB0 File Offset: 0x001FE0B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.IpAddress);
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Country);
			}
			bool hasCity = this.HasCity;
			if (hasCity)
			{
				output.WriteRawTag(26);
				output.WriteString(this.City);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x001FFF40 File Offset: 0x001FE140
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IpAddress);
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Country);
			}
			bool hasCity = this.HasCity;
			if (hasCity)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.City);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008395 RID: 33685 RVA: 0x001FFFCC File Offset: 0x001FE1CC
		[DebuggerNonUserCode]
		public void MergeFrom(GameSessionLocation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIpAddress = other.HasIpAddress;
				if (hasIpAddress)
				{
					this.IpAddress = other.IpAddress;
				}
				bool hasCountry = other.HasCountry;
				if (hasCountry)
				{
					this.Country = other.Country;
				}
				bool hasCity = other.HasCity;
				if (hasCity)
				{
					this.City = other.City;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x00200047 File Offset: 0x001FE247
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x00200054 File Offset: 0x001FE254
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.City = input.ReadString();
						}
					}
					else
					{
						this.Country = input.ReadUInt32();
					}
				}
				else
				{
					this.IpAddress = input.ReadString();
				}
			}
		}

		// Token: 0x04003BBB RID: 15291
		private static readonly MessageParser<GameSessionLocation> _parser = new MessageParser<GameSessionLocation>(() => new GameSessionLocation());

		// Token: 0x04003BBC RID: 15292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BBD RID: 15293
		private int _hasBits0;

		// Token: 0x04003BBE RID: 15294
		public const int IpAddressFieldNumber = 1;

		// Token: 0x04003BBF RID: 15295
		private static readonly string IpAddressDefaultValue = "";

		// Token: 0x04003BC0 RID: 15296
		private string ipAddress_;

		// Token: 0x04003BC1 RID: 15297
		public const int CountryFieldNumber = 2;

		// Token: 0x04003BC2 RID: 15298
		private static readonly uint CountryDefaultValue = 0U;

		// Token: 0x04003BC3 RID: 15299
		private uint country_;

		// Token: 0x04003BC4 RID: 15300
		public const int CityFieldNumber = 3;

		// Token: 0x04003BC5 RID: 15301
		private static readonly string CityDefaultValue = "";

		// Token: 0x04003BC6 RID: 15302
		private string city_;
	}
}
