using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007A4 RID: 1956
	public sealed class CharacterRequest : IMessage<CharacterRequest>, IMessage, IEquatable<CharacterRequest>, IDeepCloneable<CharacterRequest>, IBufferMessage
	{
		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600B362 RID: 45922 RVA: 0x002BA794 File Offset: 0x002B8994
		[DebuggerNonUserCode]
		public static MessageParser<CharacterRequest> Parser
		{
			get
			{
				return CharacterRequest._parser;
			}
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600B363 RID: 45923 RVA: 0x002BA7AC File Offset: 0x002B89AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600B364 RID: 45924 RVA: 0x002BA7D0 File Offset: 0x002B89D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterRequest.Descriptor;
			}
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x002BA7E7 File Offset: 0x002B89E7
		[DebuggerNonUserCode]
		public CharacterRequest()
		{
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x002BA7F4 File Offset: 0x002B89F4
		[DebuggerNonUserCode]
		public CharacterRequest(CharacterRequest other)
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

		// Token: 0x0600B367 RID: 45927 RVA: 0x002BA87C File Offset: 0x002B8A7C
		[DebuggerNonUserCode]
		public CharacterRequest Clone()
		{
			return new CharacterRequest(this);
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600B368 RID: 45928 RVA: 0x002BA894 File Offset: 0x002B8A94
		// (set) Token: 0x0600B369 RID: 45929 RVA: 0x002BA8B5 File Offset: 0x002B8AB5
		[DebuggerNonUserCode]
		public string Key
		{
			get
			{
				return this.key_ ?? CharacterRequest.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600B36A RID: 45930 RVA: 0x002BA8CC File Offset: 0x002B8ACC
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x002BA8E7 File Offset: 0x002B8AE7
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600B36C RID: 45932 RVA: 0x002BA8F4 File Offset: 0x002B8AF4
		// (set) Token: 0x0600B36D RID: 45933 RVA: 0x002BA925 File Offset: 0x002B8B25
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
					osidefaultValue = CharacterRequest.OSIDefaultValue;
				}
				return osidefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.oSI_ = value;
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600B36E RID: 45934 RVA: 0x002BA940 File Offset: 0x002B8B40
		[DebuggerNonUserCode]
		public bool HasOSI
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x002BA95D File Offset: 0x002B8B5D
		[DebuggerNonUserCode]
		public void ClearOSI()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600B370 RID: 45936 RVA: 0x002BA970 File Offset: 0x002B8B70
		// (set) Token: 0x0600B371 RID: 45937 RVA: 0x002BA991 File Offset: 0x002B8B91
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? CharacterRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600B372 RID: 45938 RVA: 0x002BA9A8 File Offset: 0x002B8BA8
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x002BA9C3 File Offset: 0x002B8BC3
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600B374 RID: 45940 RVA: 0x002BA9D0 File Offset: 0x002B8BD0
		// (set) Token: 0x0600B375 RID: 45941 RVA: 0x002BA9F1 File Offset: 0x002B8BF1
		[DebuggerNonUserCode]
		public string BaseKey
		{
			get
			{
				return this.baseKey_ ?? CharacterRequest.BaseKeyDefaultValue;
			}
			set
			{
				this.baseKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600B376 RID: 45942 RVA: 0x002BAA08 File Offset: 0x002B8C08
		[DebuggerNonUserCode]
		public bool HasBaseKey
		{
			get
			{
				return this.baseKey_ != null;
			}
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x002BAA23 File Offset: 0x002B8C23
		[DebuggerNonUserCode]
		public void ClearBaseKey()
		{
			this.baseKey_ = null;
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600B378 RID: 45944 RVA: 0x002BAA30 File Offset: 0x002B8C30
		// (set) Token: 0x0600B379 RID: 45945 RVA: 0x002BAA61 File Offset: 0x002B8C61
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
					thirty100DefaultValue = CharacterRequest.Thirty100DefaultValue;
				}
				return thirty100DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.thirty100_ = value;
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600B37A RID: 45946 RVA: 0x002BAA7C File Offset: 0x002B8C7C
		[DebuggerNonUserCode]
		public bool HasThirty100
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x002BAA99 File Offset: 0x002B8C99
		[DebuggerNonUserCode]
		public void ClearThirty100()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600B37C RID: 45948 RVA: 0x002BAAAC File Offset: 0x002B8CAC
		// (set) Token: 0x0600B37D RID: 45949 RVA: 0x002BAADD File Offset: 0x002B8CDD
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
					wn64DefaultValue = CharacterRequest.Wn64DefaultValue;
				}
				return wn64DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.wn64_ = value;
			}
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600B37E RID: 45950 RVA: 0x002BAAF8 File Offset: 0x002B8CF8
		[DebuggerNonUserCode]
		public bool HasWn64
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x002BAB15 File Offset: 0x002B8D15
		[DebuggerNonUserCode]
		public void ClearWn64()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600B380 RID: 45952 RVA: 0x002BAB28 File Offset: 0x002B8D28
		// (set) Token: 0x0600B381 RID: 45953 RVA: 0x002BAB59 File Offset: 0x002B8D59
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
					oneDefaultValue = CharacterRequest.OneDefaultValue;
				}
				return oneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.one_ = value;
			}
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600B382 RID: 45954 RVA: 0x002BAB74 File Offset: 0x002B8D74
		[DebuggerNonUserCode]
		public bool HasOne
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x002BAB91 File Offset: 0x002B8D91
		[DebuggerNonUserCode]
		public void ClearOne()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x002BABA4 File Offset: 0x002B8DA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterRequest);
		}

		// Token: 0x0600B385 RID: 45957 RVA: 0x002BABC4 File Offset: 0x002B8DC4
		[DebuggerNonUserCode]
		public bool Equals(CharacterRequest other)
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

		// Token: 0x0600B386 RID: 45958 RVA: 0x002BACCC File Offset: 0x002B8ECC
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

		// Token: 0x0600B387 RID: 45959 RVA: 0x002BADC0 File Offset: 0x002B8FC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B388 RID: 45960 RVA: 0x002BADD8 File Offset: 0x002B8FD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x002BADE4 File Offset: 0x002B8FE4
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

		// Token: 0x0600B38A RID: 45962 RVA: 0x002BAF04 File Offset: 0x002B9104
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

		// Token: 0x0600B38B RID: 45963 RVA: 0x002BB008 File Offset: 0x002B9208
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterRequest other)
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

		// Token: 0x0600B38C RID: 45964 RVA: 0x002BB0F2 File Offset: 0x002B92F2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B38D RID: 45965 RVA: 0x002BB100 File Offset: 0x002B9300
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

		// Token: 0x0400511B RID: 20763
		private static readonly MessageParser<CharacterRequest> _parser = new MessageParser<CharacterRequest>(() => new CharacterRequest());

		// Token: 0x0400511C RID: 20764
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400511D RID: 20765
		private int _hasBits0;

		// Token: 0x0400511E RID: 20766
		public const int KeyFieldNumber = 1;

		// Token: 0x0400511F RID: 20767
		private static readonly string KeyDefaultValue = "";

		// Token: 0x04005120 RID: 20768
		private string key_;

		// Token: 0x04005121 RID: 20769
		public const int OSIFieldNumber = 3;

		// Token: 0x04005122 RID: 20770
		private static readonly int OSIDefaultValue = 0;

		// Token: 0x04005123 RID: 20771
		private int oSI_;

		// Token: 0x04005124 RID: 20772
		public const int VersionFieldNumber = 4;

		// Token: 0x04005125 RID: 20773
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04005126 RID: 20774
		private string version_;

		// Token: 0x04005127 RID: 20775
		public const int BaseKeyFieldNumber = 5;

		// Token: 0x04005128 RID: 20776
		private static readonly string BaseKeyDefaultValue = "";

		// Token: 0x04005129 RID: 20777
		private string baseKey_;

		// Token: 0x0400512A RID: 20778
		public const int Thirty100FieldNumber = 6;

		// Token: 0x0400512B RID: 20779
		private static readonly int Thirty100DefaultValue = 0;

		// Token: 0x0400512C RID: 20780
		private int thirty100_;

		// Token: 0x0400512D RID: 20781
		public const int Wn64FieldNumber = 7;

		// Token: 0x0400512E RID: 20782
		private static readonly int Wn64DefaultValue = 0;

		// Token: 0x0400512F RID: 20783
		private int wn64_;

		// Token: 0x04005130 RID: 20784
		public const int OneFieldNumber = 8;

		// Token: 0x04005131 RID: 20785
		private static readonly int OneDefaultValue = 0;

		// Token: 0x04005132 RID: 20786
		private int one_;
	}
}
