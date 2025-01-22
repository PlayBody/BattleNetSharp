using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000748 RID: 1864
	public sealed class GameSessionLocation : IMessage<GameSessionLocation>, IMessage, IEquatable<GameSessionLocation>, IDeepCloneable<GameSessionLocation>, IBufferMessage
	{
		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x0029C5CC File Offset: 0x0029A7CC
		[DebuggerNonUserCode]
		public static MessageParser<GameSessionLocation> Parser
		{
			get
			{
				return GameSessionLocation._parser;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600AB85 RID: 43909 RVA: 0x0029C5E4 File Offset: 0x0029A7E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x0029C608 File Offset: 0x0029A808
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionLocation.Descriptor;
			}
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x0029C61F File Offset: 0x0029A81F
		[DebuggerNonUserCode]
		public GameSessionLocation()
		{
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x0029C62C File Offset: 0x0029A82C
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

		// Token: 0x0600AB89 RID: 43913 RVA: 0x0029C684 File Offset: 0x0029A884
		[DebuggerNonUserCode]
		public GameSessionLocation Clone()
		{
			return new GameSessionLocation(this);
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x0029C69C File Offset: 0x0029A89C
		// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x0029C6BD File Offset: 0x0029A8BD
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

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x0029C6D4 File Offset: 0x0029A8D4
		[DebuggerNonUserCode]
		public bool HasIpAddress
		{
			get
			{
				return this.ipAddress_ != null;
			}
		}

		// Token: 0x0600AB8D RID: 43917 RVA: 0x0029C6EF File Offset: 0x0029A8EF
		[DebuggerNonUserCode]
		public void ClearIpAddress()
		{
			this.ipAddress_ = null;
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x0029C6FC File Offset: 0x0029A8FC
		// (set) Token: 0x0600AB8F RID: 43919 RVA: 0x0029C72D File Offset: 0x0029A92D
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

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x0029C748 File Offset: 0x0029A948
		[DebuggerNonUserCode]
		public bool HasCountry
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x0029C765 File Offset: 0x0029A965
		[DebuggerNonUserCode]
		public void ClearCountry()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x0029C778 File Offset: 0x0029A978
		// (set) Token: 0x0600AB93 RID: 43923 RVA: 0x0029C799 File Offset: 0x0029A999
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

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600AB94 RID: 43924 RVA: 0x0029C7B0 File Offset: 0x0029A9B0
		[DebuggerNonUserCode]
		public bool HasCity
		{
			get
			{
				return this.city_ != null;
			}
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x0029C7CB File Offset: 0x0029A9CB
		[DebuggerNonUserCode]
		public void ClearCity()
		{
			this.city_ = null;
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x0029C7D8 File Offset: 0x0029A9D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionLocation);
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x0029C7F8 File Offset: 0x0029A9F8
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

		// Token: 0x0600AB98 RID: 43928 RVA: 0x0029C884 File Offset: 0x0029AA84
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

		// Token: 0x0600AB99 RID: 43929 RVA: 0x0029C908 File Offset: 0x0029AB08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB9A RID: 43930 RVA: 0x0029C920 File Offset: 0x0029AB20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB9B RID: 43931 RVA: 0x0029C92C File Offset: 0x0029AB2C
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

		// Token: 0x0600AB9C RID: 43932 RVA: 0x0029C9BC File Offset: 0x0029ABBC
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

		// Token: 0x0600AB9D RID: 43933 RVA: 0x0029CA48 File Offset: 0x0029AC48
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

		// Token: 0x0600AB9E RID: 43934 RVA: 0x0029CAC3 File Offset: 0x0029ACC3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x0029CAD0 File Offset: 0x0029ACD0
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

		// Token: 0x04004D45 RID: 19781
		private static readonly MessageParser<GameSessionLocation> _parser = new MessageParser<GameSessionLocation>(() => new GameSessionLocation());

		// Token: 0x04004D46 RID: 19782
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D47 RID: 19783
		private int _hasBits0;

		// Token: 0x04004D48 RID: 19784
		public const int IpAddressFieldNumber = 1;

		// Token: 0x04004D49 RID: 19785
		private static readonly string IpAddressDefaultValue = "";

		// Token: 0x04004D4A RID: 19786
		private string ipAddress_;

		// Token: 0x04004D4B RID: 19787
		public const int CountryFieldNumber = 2;

		// Token: 0x04004D4C RID: 19788
		private static readonly uint CountryDefaultValue = 0U;

		// Token: 0x04004D4D RID: 19789
		private uint country_;

		// Token: 0x04004D4E RID: 19790
		public const int CityFieldNumber = 3;

		// Token: 0x04004D4F RID: 19791
		private static readonly string CityDefaultValue = "";

		// Token: 0x04004D50 RID: 19792
		private string city_;
	}
}
