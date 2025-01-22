using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Network
{
	// Token: 0x02000759 RID: 1881
	public sealed class NetworkRequest : IMessage<NetworkRequest>, IMessage, IEquatable<NetworkRequest>, IDeepCloneable<NetworkRequest>, IBufferMessage
	{
		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600AD18 RID: 44312 RVA: 0x002A24B8 File Offset: 0x002A06B8
		[DebuggerNonUserCode]
		public static MessageParser<NetworkRequest> Parser
		{
			get
			{
				return NetworkRequest._parser;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600AD19 RID: 44313 RVA: 0x002A24D0 File Offset: 0x002A06D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NetworkReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600AD1A RID: 44314 RVA: 0x002A24F4 File Offset: 0x002A06F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetworkRequest.Descriptor;
			}
		}

		// Token: 0x0600AD1B RID: 44315 RVA: 0x002A250B File Offset: 0x002A070B
		[DebuggerNonUserCode]
		public NetworkRequest()
		{
		}

		// Token: 0x0600AD1C RID: 44316 RVA: 0x002A2518 File Offset: 0x002A0718
		[DebuggerNonUserCode]
		public NetworkRequest(NetworkRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key_ = other.key_;
			this.oSI_ = other.oSI_;
			this.version_ = other.version_;
			this.baseKey_ = other.baseKey_;
			this.thirty100_ = other.thirty100_;
			this.wn64_ = other.wn64_;
			this.one_ = other.one_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD1D RID: 44317 RVA: 0x002A25A0 File Offset: 0x002A07A0
		[DebuggerNonUserCode]
		public NetworkRequest Clone()
		{
			return new NetworkRequest(this);
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600AD1E RID: 44318 RVA: 0x002A25B8 File Offset: 0x002A07B8
		// (set) Token: 0x0600AD1F RID: 44319 RVA: 0x002A25D9 File Offset: 0x002A07D9
		[DebuggerNonUserCode]
		public string Key
		{
			get
			{
				return this.key_ ?? NetworkRequest.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600AD20 RID: 44320 RVA: 0x002A25F0 File Offset: 0x002A07F0
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600AD21 RID: 44321 RVA: 0x002A260B File Offset: 0x002A080B
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0600AD22 RID: 44322 RVA: 0x002A2618 File Offset: 0x002A0818
		// (set) Token: 0x0600AD23 RID: 44323 RVA: 0x002A2649 File Offset: 0x002A0849
		[DebuggerNonUserCode]
		public int OSI
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int osidefaultValue;
				if (flag)
				{
					osidefaultValue = this.oSI_;
				}
				else
				{
					osidefaultValue = NetworkRequest.OSIDefaultValue;
				}
				return osidefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.oSI_ = value;
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600AD24 RID: 44324 RVA: 0x002A2664 File Offset: 0x002A0864
		[DebuggerNonUserCode]
		public bool HasOSI
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AD25 RID: 44325 RVA: 0x002A2681 File Offset: 0x002A0881
		[DebuggerNonUserCode]
		public void ClearOSI()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600AD26 RID: 44326 RVA: 0x002A2694 File Offset: 0x002A0894
		// (set) Token: 0x0600AD27 RID: 44327 RVA: 0x002A26B5 File Offset: 0x002A08B5
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? NetworkRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600AD28 RID: 44328 RVA: 0x002A26CC File Offset: 0x002A08CC
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600AD29 RID: 44329 RVA: 0x002A26E7 File Offset: 0x002A08E7
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600AD2A RID: 44330 RVA: 0x002A26F4 File Offset: 0x002A08F4
		// (set) Token: 0x0600AD2B RID: 44331 RVA: 0x002A2715 File Offset: 0x002A0915
		[DebuggerNonUserCode]
		public string BaseKey
		{
			get
			{
				return this.baseKey_ ?? NetworkRequest.BaseKeyDefaultValue;
			}
			set
			{
				this.baseKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600AD2C RID: 44332 RVA: 0x002A272C File Offset: 0x002A092C
		[DebuggerNonUserCode]
		public bool HasBaseKey
		{
			get
			{
				return this.baseKey_ != null;
			}
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x002A2747 File Offset: 0x002A0947
		[DebuggerNonUserCode]
		public void ClearBaseKey()
		{
			this.baseKey_ = null;
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600AD2E RID: 44334 RVA: 0x002A2754 File Offset: 0x002A0954
		// (set) Token: 0x0600AD2F RID: 44335 RVA: 0x002A2785 File Offset: 0x002A0985
		[DebuggerNonUserCode]
		public int Thirty100
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int thirty100DefaultValue;
				if (flag)
				{
					thirty100DefaultValue = this.thirty100_;
				}
				else
				{
					thirty100DefaultValue = NetworkRequest.Thirty100DefaultValue;
				}
				return thirty100DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.thirty100_ = value;
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600AD30 RID: 44336 RVA: 0x002A27A0 File Offset: 0x002A09A0
		[DebuggerNonUserCode]
		public bool HasThirty100
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AD31 RID: 44337 RVA: 0x002A27BD File Offset: 0x002A09BD
		[DebuggerNonUserCode]
		public void ClearThirty100()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600AD32 RID: 44338 RVA: 0x002A27D0 File Offset: 0x002A09D0
		// (set) Token: 0x0600AD33 RID: 44339 RVA: 0x002A2801 File Offset: 0x002A0A01
		[DebuggerNonUserCode]
		public int Wn64
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int wn64DefaultValue;
				if (flag)
				{
					wn64DefaultValue = this.wn64_;
				}
				else
				{
					wn64DefaultValue = NetworkRequest.Wn64DefaultValue;
				}
				return wn64DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.wn64_ = value;
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600AD34 RID: 44340 RVA: 0x002A281C File Offset: 0x002A0A1C
		[DebuggerNonUserCode]
		public bool HasWn64
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x002A2839 File Offset: 0x002A0A39
		[DebuggerNonUserCode]
		public void ClearWn64()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600AD36 RID: 44342 RVA: 0x002A284C File Offset: 0x002A0A4C
		// (set) Token: 0x0600AD37 RID: 44343 RVA: 0x002A287D File Offset: 0x002A0A7D
		[DebuggerNonUserCode]
		public int One
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int oneDefaultValue;
				if (flag)
				{
					oneDefaultValue = this.one_;
				}
				else
				{
					oneDefaultValue = NetworkRequest.OneDefaultValue;
				}
				return oneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.one_ = value;
			}
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600AD38 RID: 44344 RVA: 0x002A2898 File Offset: 0x002A0A98
		[DebuggerNonUserCode]
		public bool HasOne
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x002A28B5 File Offset: 0x002A0AB5
		[DebuggerNonUserCode]
		public void ClearOne()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600AD3A RID: 44346 RVA: 0x002A28C8 File Offset: 0x002A0AC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetworkRequest);
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x002A28E8 File Offset: 0x002A0AE8
		[DebuggerNonUserCode]
		public bool Equals(NetworkRequest other)
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
					bool flag4 = this.Key != other.Key;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.OSI != other.OSI;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Version != other.Version;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BaseKey != other.BaseKey;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Thirty100 != other.Thirty100;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Wn64 != other.Wn64;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.One != other.One;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600AD3C RID: 44348 RVA: 0x002A29F0 File Offset: 0x002A0BF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasOSI = this.HasOSI;
			if (hasOSI)
			{
				num ^= this.OSI.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasBaseKey = this.HasBaseKey;
			if (hasBaseKey)
			{
				num ^= this.BaseKey.GetHashCode();
			}
			bool hasThirty = this.HasThirty100;
			if (hasThirty)
			{
				num ^= this.Thirty100.GetHashCode();
			}
			bool hasWn = this.HasWn64;
			if (hasWn)
			{
				num ^= this.Wn64.GetHashCode();
			}
			bool hasOne = this.HasOne;
			if (hasOne)
			{
				num ^= this.One.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD3D RID: 44349 RVA: 0x002A2AE4 File Offset: 0x002A0CE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x002A2AFC File Offset: 0x002A0CFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD3F RID: 44351 RVA: 0x002A2B08 File Offset: 0x002A0D08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Key);
			}
			bool hasOSI = this.HasOSI;
			if (hasOSI)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OSI);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Version);
			}
			bool hasBaseKey = this.HasBaseKey;
			if (hasBaseKey)
			{
				output.WriteRawTag(42);
				output.WriteString(this.BaseKey);
			}
			bool hasThirty = this.HasThirty100;
			if (hasThirty)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Thirty100);
			}
			bool hasWn = this.HasWn64;
			if (hasWn)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Wn64);
			}
			bool hasOne = this.HasOne;
			if (hasOne)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.One);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x002A2C28 File Offset: 0x002A0E28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			bool hasOSI = this.HasOSI;
			if (hasOSI)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OSI);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			bool hasBaseKey = this.HasBaseKey;
			if (hasBaseKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BaseKey);
			}
			bool hasThirty = this.HasThirty100;
			if (hasThirty)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Thirty100);
			}
			bool hasWn = this.HasWn64;
			if (hasWn)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Wn64);
			}
			bool hasOne = this.HasOne;
			if (hasOne)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.One);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD41 RID: 44353 RVA: 0x002A2D2C File Offset: 0x002A0F2C
		[DebuggerNonUserCode]
		public void MergeFrom(NetworkRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasOSI = other.HasOSI;
				if (hasOSI)
				{
					this.OSI = other.OSI;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasBaseKey = other.HasBaseKey;
				if (hasBaseKey)
				{
					this.BaseKey = other.BaseKey;
				}
				bool hasThirty = other.HasThirty100;
				if (hasThirty)
				{
					this.Thirty100 = other.Thirty100;
				}
				bool hasWn = other.HasWn64;
				if (hasWn)
				{
					this.Wn64 = other.Wn64;
				}
				bool hasOne = other.HasOne;
				if (hasOne)
				{
					this.One = other.One;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AD42 RID: 44354 RVA: 0x002A2E16 File Offset: 0x002A1016
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD43 RID: 44355 RVA: 0x002A2E24 File Offset: 0x002A1024
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
					if (num3 != 10U)
					{
						if (num3 != 24U)
						{
							if (num3 != 34U)
							{
								goto IL_0046;
							}
							this.Version = input.ReadString();
						}
						else
						{
							this.OSI = input.ReadInt32();
						}
					}
					else
					{
						this.Key = input.ReadString();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0046;
						}
						this.Thirty100 = input.ReadInt32();
					}
					else
					{
						this.BaseKey = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						goto IL_0046;
					}
					this.One = input.ReadInt32();
				}
				else
				{
					this.Wn64 = input.ReadInt32();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004DF5 RID: 19957
		private static readonly MessageParser<NetworkRequest> _parser = new MessageParser<NetworkRequest>(() => new NetworkRequest());

		// Token: 0x04004DF6 RID: 19958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DF7 RID: 19959
		private int _hasBits0;

		// Token: 0x04004DF8 RID: 19960
		public const int KeyFieldNumber = 1;

		// Token: 0x04004DF9 RID: 19961
		private static readonly string KeyDefaultValue = "";

		// Token: 0x04004DFA RID: 19962
		private string key_;

		// Token: 0x04004DFB RID: 19963
		public const int OSIFieldNumber = 3;

		// Token: 0x04004DFC RID: 19964
		private static readonly int OSIDefaultValue = 0;

		// Token: 0x04004DFD RID: 19965
		private int oSI_;

		// Token: 0x04004DFE RID: 19966
		public const int VersionFieldNumber = 4;

		// Token: 0x04004DFF RID: 19967
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004E00 RID: 19968
		private string version_;

		// Token: 0x04004E01 RID: 19969
		public const int BaseKeyFieldNumber = 5;

		// Token: 0x04004E02 RID: 19970
		private static readonly string BaseKeyDefaultValue = "";

		// Token: 0x04004E03 RID: 19971
		private string baseKey_;

		// Token: 0x04004E04 RID: 19972
		public const int Thirty100FieldNumber = 6;

		// Token: 0x04004E05 RID: 19973
		private static readonly int Thirty100DefaultValue = 0;

		// Token: 0x04004E06 RID: 19974
		private int thirty100_;

		// Token: 0x04004E07 RID: 19975
		public const int Wn64FieldNumber = 7;

		// Token: 0x04004E08 RID: 19976
		private static readonly int Wn64DefaultValue = 0;

		// Token: 0x04004E09 RID: 19977
		private int wn64_;

		// Token: 0x04004E0A RID: 19978
		public const int OneFieldNumber = 8;

		// Token: 0x04004E0B RID: 19979
		private static readonly int OneDefaultValue = 0;

		// Token: 0x04004E0C RID: 19980
		private int one_;
	}
}
