using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Warden
{
	// Token: 0x02000755 RID: 1877
	public sealed class WardenRequest : IMessage<WardenRequest>, IMessage, IEquatable<WardenRequest>, IDeepCloneable<WardenRequest>, IBufferMessage
	{
		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600ACCE RID: 44238 RVA: 0x002A1340 File Offset: 0x0029F540
		[DebuggerNonUserCode]
		public static MessageParser<WardenRequest> Parser
		{
			get
			{
				return WardenRequest._parser;
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600ACCF RID: 44239 RVA: 0x002A1358 File Offset: 0x0029F558
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WardenReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600ACD0 RID: 44240 RVA: 0x002A137C File Offset: 0x0029F57C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WardenRequest.Descriptor;
			}
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x002A1393 File Offset: 0x0029F593
		[DebuggerNonUserCode]
		public WardenRequest()
		{
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x002A13A0 File Offset: 0x0029F5A0
		[DebuggerNonUserCode]
		public WardenRequest(WardenRequest other)
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

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x002A1428 File Offset: 0x0029F628
		[DebuggerNonUserCode]
		public WardenRequest Clone()
		{
			return new WardenRequest(this);
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600ACD4 RID: 44244 RVA: 0x002A1440 File Offset: 0x0029F640
		// (set) Token: 0x0600ACD5 RID: 44245 RVA: 0x002A1461 File Offset: 0x0029F661
		[DebuggerNonUserCode]
		public string Key
		{
			get
			{
				return this.key_ ?? WardenRequest.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600ACD6 RID: 44246 RVA: 0x002A1478 File Offset: 0x0029F678
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x002A1493 File Offset: 0x0029F693
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600ACD8 RID: 44248 RVA: 0x002A14A0 File Offset: 0x0029F6A0
		// (set) Token: 0x0600ACD9 RID: 44249 RVA: 0x002A14D1 File Offset: 0x0029F6D1
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
					osidefaultValue = WardenRequest.OSIDefaultValue;
				}
				return osidefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.oSI_ = value;
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600ACDA RID: 44250 RVA: 0x002A14EC File Offset: 0x0029F6EC
		[DebuggerNonUserCode]
		public bool HasOSI
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x002A1509 File Offset: 0x0029F709
		[DebuggerNonUserCode]
		public void ClearOSI()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600ACDC RID: 44252 RVA: 0x002A151C File Offset: 0x0029F71C
		// (set) Token: 0x0600ACDD RID: 44253 RVA: 0x002A153D File Offset: 0x0029F73D
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? WardenRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600ACDE RID: 44254 RVA: 0x002A1554 File Offset: 0x0029F754
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x002A156F File Offset: 0x0029F76F
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600ACE0 RID: 44256 RVA: 0x002A157C File Offset: 0x0029F77C
		// (set) Token: 0x0600ACE1 RID: 44257 RVA: 0x002A159D File Offset: 0x0029F79D
		[DebuggerNonUserCode]
		public string BaseKey
		{
			get
			{
				return this.baseKey_ ?? WardenRequest.BaseKeyDefaultValue;
			}
			set
			{
				this.baseKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600ACE2 RID: 44258 RVA: 0x002A15B4 File Offset: 0x0029F7B4
		[DebuggerNonUserCode]
		public bool HasBaseKey
		{
			get
			{
				return this.baseKey_ != null;
			}
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x002A15CF File Offset: 0x0029F7CF
		[DebuggerNonUserCode]
		public void ClearBaseKey()
		{
			this.baseKey_ = null;
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600ACE4 RID: 44260 RVA: 0x002A15DC File Offset: 0x0029F7DC
		// (set) Token: 0x0600ACE5 RID: 44261 RVA: 0x002A160D File Offset: 0x0029F80D
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
					thirty100DefaultValue = WardenRequest.Thirty100DefaultValue;
				}
				return thirty100DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.thirty100_ = value;
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600ACE6 RID: 44262 RVA: 0x002A1628 File Offset: 0x0029F828
		[DebuggerNonUserCode]
		public bool HasThirty100
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x002A1645 File Offset: 0x0029F845
		[DebuggerNonUserCode]
		public void ClearThirty100()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600ACE8 RID: 44264 RVA: 0x002A1658 File Offset: 0x0029F858
		// (set) Token: 0x0600ACE9 RID: 44265 RVA: 0x002A1689 File Offset: 0x0029F889
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
					wn64DefaultValue = WardenRequest.Wn64DefaultValue;
				}
				return wn64DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.wn64_ = value;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x002A16A4 File Offset: 0x0029F8A4
		[DebuggerNonUserCode]
		public bool HasWn64
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x002A16C1 File Offset: 0x0029F8C1
		[DebuggerNonUserCode]
		public void ClearWn64()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600ACEC RID: 44268 RVA: 0x002A16D4 File Offset: 0x0029F8D4
		// (set) Token: 0x0600ACED RID: 44269 RVA: 0x002A1705 File Offset: 0x0029F905
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
					oneDefaultValue = WardenRequest.OneDefaultValue;
				}
				return oneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.one_ = value;
			}
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600ACEE RID: 44270 RVA: 0x002A1720 File Offset: 0x0029F920
		[DebuggerNonUserCode]
		public bool HasOne
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x002A173D File Offset: 0x0029F93D
		[DebuggerNonUserCode]
		public void ClearOne()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x002A1750 File Offset: 0x0029F950
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WardenRequest);
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x002A1770 File Offset: 0x0029F970
		[DebuggerNonUserCode]
		public bool Equals(WardenRequest other)
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

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x002A1878 File Offset: 0x0029FA78
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

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x002A196C File Offset: 0x0029FB6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x002A1984 File Offset: 0x0029FB84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x002A1990 File Offset: 0x0029FB90
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

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x002A1AB0 File Offset: 0x0029FCB0
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

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x002A1BB4 File Offset: 0x0029FDB4
		[DebuggerNonUserCode]
		public void MergeFrom(WardenRequest other)
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

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x002A1C9E File Offset: 0x0029FE9E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x002A1CAC File Offset: 0x0029FEAC
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

		// Token: 0x04004DD1 RID: 19921
		private static readonly MessageParser<WardenRequest> _parser = new MessageParser<WardenRequest>(() => new WardenRequest());

		// Token: 0x04004DD2 RID: 19922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DD3 RID: 19923
		private int _hasBits0;

		// Token: 0x04004DD4 RID: 19924
		public const int KeyFieldNumber = 1;

		// Token: 0x04004DD5 RID: 19925
		private static readonly string KeyDefaultValue = "";

		// Token: 0x04004DD6 RID: 19926
		private string key_;

		// Token: 0x04004DD7 RID: 19927
		public const int OSIFieldNumber = 3;

		// Token: 0x04004DD8 RID: 19928
		private static readonly int OSIDefaultValue = 0;

		// Token: 0x04004DD9 RID: 19929
		private int oSI_;

		// Token: 0x04004DDA RID: 19930
		public const int VersionFieldNumber = 4;

		// Token: 0x04004DDB RID: 19931
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004DDC RID: 19932
		private string version_;

		// Token: 0x04004DDD RID: 19933
		public const int BaseKeyFieldNumber = 5;

		// Token: 0x04004DDE RID: 19934
		private static readonly string BaseKeyDefaultValue = "";

		// Token: 0x04004DDF RID: 19935
		private string baseKey_;

		// Token: 0x04004DE0 RID: 19936
		public const int Thirty100FieldNumber = 6;

		// Token: 0x04004DE1 RID: 19937
		private static readonly int Thirty100DefaultValue = 0;

		// Token: 0x04004DE2 RID: 19938
		private int thirty100_;

		// Token: 0x04004DE3 RID: 19939
		public const int Wn64FieldNumber = 7;

		// Token: 0x04004DE4 RID: 19940
		private static readonly int Wn64DefaultValue = 0;

		// Token: 0x04004DE5 RID: 19941
		private int wn64_;

		// Token: 0x04004DE6 RID: 19942
		public const int OneFieldNumber = 8;

		// Token: 0x04004DE7 RID: 19943
		private static readonly int OneDefaultValue = 0;

		// Token: 0x04004DE8 RID: 19944
		private int one_;
	}
}
