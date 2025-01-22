using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000774 RID: 1908
	public sealed class AuthSessionResponse : IMessage<AuthSessionResponse>, IMessage, IEquatable<AuthSessionResponse>, IDeepCloneable<AuthSessionResponse>, IBufferMessage
	{
		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600AF70 RID: 44912 RVA: 0x002AB470 File Offset: 0x002A9670
		[DebuggerNonUserCode]
		public static MessageParser<AuthSessionResponse> Parser
		{
			get
			{
				return AuthSessionResponse._parser;
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600AF71 RID: 44913 RVA: 0x002AB488 File Offset: 0x002A9688
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600AF72 RID: 44914 RVA: 0x002AB4AC File Offset: 0x002A96AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthSessionResponse.Descriptor;
			}
		}

		// Token: 0x0600AF73 RID: 44915 RVA: 0x002AB4C3 File Offset: 0x002A96C3
		[DebuggerNonUserCode]
		public AuthSessionResponse()
		{
		}

		// Token: 0x0600AF74 RID: 44916 RVA: 0x002AB4D8 File Offset: 0x002A96D8
		[DebuggerNonUserCode]
		public AuthSessionResponse(AuthSessionResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionType_ = other.sessionType_.Clone();
			this.unk1_ = other.unk1_;
			this.unk2_ = other.unk2_;
			this.unk3_ = other.unk3_;
			this.unk4_ = other.unk4_;
			this.country_ = other.country_;
			this.unk5_ = other.unk5_;
			this.unk6_ = other.unk6_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF75 RID: 44917 RVA: 0x002AB570 File Offset: 0x002A9770
		[DebuggerNonUserCode]
		public AuthSessionResponse Clone()
		{
			return new AuthSessionResponse(this);
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600AF76 RID: 44918 RVA: 0x002AB588 File Offset: 0x002A9788
		[DebuggerNonUserCode]
		public RepeatedField<string> SessionType
		{
			get
			{
				return this.sessionType_;
			}
		}

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600AF77 RID: 44919 RVA: 0x002AB5A0 File Offset: 0x002A97A0
		// (set) Token: 0x0600AF78 RID: 44920 RVA: 0x002AB5D1 File Offset: 0x002A97D1
		[DebuggerNonUserCode]
		public uint Unk1
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint unk1DefaultValue;
				if (flag)
				{
					unk1DefaultValue = this.unk1_;
				}
				else
				{
					unk1DefaultValue = AuthSessionResponse.Unk1DefaultValue;
				}
				return unk1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.unk1_ = value;
			}
		}

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600AF79 RID: 44921 RVA: 0x002AB5EC File Offset: 0x002A97EC
		[DebuggerNonUserCode]
		public bool HasUnk1
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x002AB609 File Offset: 0x002A9809
		[DebuggerNonUserCode]
		public void ClearUnk1()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600AF7B RID: 44923 RVA: 0x002AB61C File Offset: 0x002A981C
		// (set) Token: 0x0600AF7C RID: 44924 RVA: 0x002AB64D File Offset: 0x002A984D
		[DebuggerNonUserCode]
		public uint Unk2
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint unk2DefaultValue;
				if (flag)
				{
					unk2DefaultValue = this.unk2_;
				}
				else
				{
					unk2DefaultValue = AuthSessionResponse.Unk2DefaultValue;
				}
				return unk2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.unk2_ = value;
			}
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600AF7D RID: 44925 RVA: 0x002AB668 File Offset: 0x002A9868
		[DebuggerNonUserCode]
		public bool HasUnk2
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AF7E RID: 44926 RVA: 0x002AB685 File Offset: 0x002A9885
		[DebuggerNonUserCode]
		public void ClearUnk2()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600AF7F RID: 44927 RVA: 0x002AB698 File Offset: 0x002A9898
		// (set) Token: 0x0600AF80 RID: 44928 RVA: 0x002AB6C9 File Offset: 0x002A98C9
		[DebuggerNonUserCode]
		public uint Unk3
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint unk3DefaultValue;
				if (flag)
				{
					unk3DefaultValue = this.unk3_;
				}
				else
				{
					unk3DefaultValue = AuthSessionResponse.Unk3DefaultValue;
				}
				return unk3DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.unk3_ = value;
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600AF81 RID: 44929 RVA: 0x002AB6E4 File Offset: 0x002A98E4
		[DebuggerNonUserCode]
		public bool HasUnk3
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AF82 RID: 44930 RVA: 0x002AB701 File Offset: 0x002A9901
		[DebuggerNonUserCode]
		public void ClearUnk3()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600AF83 RID: 44931 RVA: 0x002AB714 File Offset: 0x002A9914
		// (set) Token: 0x0600AF84 RID: 44932 RVA: 0x002AB745 File Offset: 0x002A9945
		[DebuggerNonUserCode]
		public uint Unk4
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint unk4DefaultValue;
				if (flag)
				{
					unk4DefaultValue = this.unk4_;
				}
				else
				{
					unk4DefaultValue = AuthSessionResponse.Unk4DefaultValue;
				}
				return unk4DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.unk4_ = value;
			}
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600AF85 RID: 44933 RVA: 0x002AB760 File Offset: 0x002A9960
		[DebuggerNonUserCode]
		public bool HasUnk4
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AF86 RID: 44934 RVA: 0x002AB77D File Offset: 0x002A997D
		[DebuggerNonUserCode]
		public void ClearUnk4()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600AF87 RID: 44935 RVA: 0x002AB790 File Offset: 0x002A9990
		// (set) Token: 0x0600AF88 RID: 44936 RVA: 0x002AB7B1 File Offset: 0x002A99B1
		[DebuggerNonUserCode]
		public string Country
		{
			get
			{
				return this.country_ ?? AuthSessionResponse.CountryDefaultValue;
			}
			set
			{
				this.country_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600AF89 RID: 44937 RVA: 0x002AB7C8 File Offset: 0x002A99C8
		[DebuggerNonUserCode]
		public bool HasCountry
		{
			get
			{
				return this.country_ != null;
			}
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x002AB7E3 File Offset: 0x002A99E3
		[DebuggerNonUserCode]
		public void ClearCountry()
		{
			this.country_ = null;
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600AF8B RID: 44939 RVA: 0x002AB7F0 File Offset: 0x002A99F0
		// (set) Token: 0x0600AF8C RID: 44940 RVA: 0x002AB822 File Offset: 0x002A9A22
		[DebuggerNonUserCode]
		public uint Unk5
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint unk5DefaultValue;
				if (flag)
				{
					unk5DefaultValue = this.unk5_;
				}
				else
				{
					unk5DefaultValue = AuthSessionResponse.Unk5DefaultValue;
				}
				return unk5DefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.unk5_ = value;
			}
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600AF8D RID: 44941 RVA: 0x002AB83C File Offset: 0x002A9A3C
		[DebuggerNonUserCode]
		public bool HasUnk5
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600AF8E RID: 44942 RVA: 0x002AB85A File Offset: 0x002A9A5A
		[DebuggerNonUserCode]
		public void ClearUnk5()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600AF8F RID: 44943 RVA: 0x002AB86C File Offset: 0x002A9A6C
		// (set) Token: 0x0600AF90 RID: 44944 RVA: 0x002AB89E File Offset: 0x002A9A9E
		[DebuggerNonUserCode]
		public uint Unk6
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint unk6DefaultValue;
				if (flag)
				{
					unk6DefaultValue = this.unk6_;
				}
				else
				{
					unk6DefaultValue = AuthSessionResponse.Unk6DefaultValue;
				}
				return unk6DefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.unk6_ = value;
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600AF91 RID: 44945 RVA: 0x002AB8B8 File Offset: 0x002A9AB8
		[DebuggerNonUserCode]
		public bool HasUnk6
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x002AB8D6 File Offset: 0x002A9AD6
		[DebuggerNonUserCode]
		public void ClearUnk6()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x002AB8E8 File Offset: 0x002A9AE8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AuthSessionResponse);
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x002AB908 File Offset: 0x002A9B08
		[DebuggerNonUserCode]
		public bool Equals(AuthSessionResponse other)
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
					bool flag4 = !this.sessionType_.Equals(other.sessionType_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Unk1 != other.Unk1;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Unk2 != other.Unk2;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Unk3 != other.Unk3;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Unk4 != other.Unk4;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Country != other.Country;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Unk5 != other.Unk5;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Unk6 != other.Unk6;
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

		// Token: 0x0600AF95 RID: 44949 RVA: 0x002ABA30 File Offset: 0x002A9C30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sessionType_.GetHashCode();
			bool hasUnk = this.HasUnk1;
			if (hasUnk)
			{
				num ^= this.Unk1.GetHashCode();
			}
			bool hasUnk2 = this.HasUnk2;
			if (hasUnk2)
			{
				num ^= this.Unk2.GetHashCode();
			}
			bool hasUnk3 = this.HasUnk3;
			if (hasUnk3)
			{
				num ^= this.Unk3.GetHashCode();
			}
			bool hasUnk4 = this.HasUnk4;
			if (hasUnk4)
			{
				num ^= this.Unk4.GetHashCode();
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num ^= this.Country.GetHashCode();
			}
			bool hasUnk5 = this.HasUnk5;
			if (hasUnk5)
			{
				num ^= this.Unk5.GetHashCode();
			}
			bool hasUnk6 = this.HasUnk6;
			if (hasUnk6)
			{
				num ^= this.Unk6.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF96 RID: 44950 RVA: 0x002ABB38 File Offset: 0x002A9D38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF97 RID: 44951 RVA: 0x002ABB50 File Offset: 0x002A9D50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF98 RID: 44952 RVA: 0x002ABB5C File Offset: 0x002A9D5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sessionType_.WriteTo(ref output, AuthSessionResponse._repeated_sessionType_codec);
			bool hasUnk = this.HasUnk1;
			if (hasUnk)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Unk1);
			}
			bool hasUnk2 = this.HasUnk2;
			if (hasUnk2)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Unk2);
			}
			bool hasUnk3 = this.HasUnk3;
			if (hasUnk3)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Unk3);
			}
			bool hasUnk4 = this.HasUnk4;
			if (hasUnk4)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Unk4);
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Country);
			}
			bool hasUnk5 = this.HasUnk5;
			if (hasUnk5)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Unk5);
			}
			bool hasUnk6 = this.HasUnk6;
			if (hasUnk6)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Unk6);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF99 RID: 44953 RVA: 0x002ABC90 File Offset: 0x002A9E90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sessionType_.CalculateSize(AuthSessionResponse._repeated_sessionType_codec);
			bool hasUnk = this.HasUnk1;
			if (hasUnk)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk1);
			}
			bool hasUnk2 = this.HasUnk2;
			if (hasUnk2)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk2);
			}
			bool hasUnk3 = this.HasUnk3;
			if (hasUnk3)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk3);
			}
			bool hasUnk4 = this.HasUnk4;
			if (hasUnk4)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk4);
			}
			bool hasCountry = this.HasCountry;
			if (hasCountry)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Country);
			}
			bool hasUnk5 = this.HasUnk5;
			if (hasUnk5)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk5);
			}
			bool hasUnk6 = this.HasUnk6;
			if (hasUnk6)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk6);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x002ABDA8 File Offset: 0x002A9FA8
		[DebuggerNonUserCode]
		public void MergeFrom(AuthSessionResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.sessionType_.Add(other.sessionType_);
				bool hasUnk = other.HasUnk1;
				if (hasUnk)
				{
					this.Unk1 = other.Unk1;
				}
				bool hasUnk2 = other.HasUnk2;
				if (hasUnk2)
				{
					this.Unk2 = other.Unk2;
				}
				bool hasUnk3 = other.HasUnk3;
				if (hasUnk3)
				{
					this.Unk3 = other.Unk3;
				}
				bool hasUnk4 = other.HasUnk4;
				if (hasUnk4)
				{
					this.Unk4 = other.Unk4;
				}
				bool hasCountry = other.HasCountry;
				if (hasCountry)
				{
					this.Country = other.Country;
				}
				bool hasUnk5 = other.HasUnk5;
				if (hasUnk5)
				{
					this.Unk5 = other.Unk5;
				}
				bool hasUnk6 = other.HasUnk6;
				if (hasUnk6)
				{
					this.Unk6 = other.Unk6;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AF9B RID: 44955 RVA: 0x002ABEA4 File Offset: 0x002AA0A4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF9C RID: 44956 RVA: 0x002ABEB0 File Offset: 0x002AA0B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 32U)
					{
						if (num3 != 10U)
						{
							if (num3 != 32U)
							{
								goto IL_005B;
							}
							this.Unk1 = input.ReadUInt32();
						}
						else
						{
							this.sessionType_.AddEntriesFrom(ref input, AuthSessionResponse._repeated_sessionType_codec);
						}
					}
					else if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_005B;
						}
						this.Unk3 = input.ReadUInt32();
					}
					else
					{
						this.Unk2 = input.ReadUInt32();
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 64U)
					{
						if (num3 != 74U)
						{
							goto IL_005B;
						}
						this.Country = input.ReadString();
					}
					else
					{
						this.Unk4 = input.ReadUInt32();
					}
				}
				else if (num3 != 80U)
				{
					if (num3 != 88U)
					{
						goto IL_005B;
					}
					this.Unk6 = input.ReadUInt32();
				}
				else
				{
					this.Unk5 = input.ReadUInt32();
				}
				continue;
				IL_005B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F14 RID: 20244
		private static readonly MessageParser<AuthSessionResponse> _parser = new MessageParser<AuthSessionResponse>(() => new AuthSessionResponse());

		// Token: 0x04004F15 RID: 20245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F16 RID: 20246
		private int _hasBits0;

		// Token: 0x04004F17 RID: 20247
		public const int SessionTypeFieldNumber = 1;

		// Token: 0x04004F18 RID: 20248
		private static readonly FieldCodec<string> _repeated_sessionType_codec = FieldCodec.ForString(10U);

		// Token: 0x04004F19 RID: 20249
		private readonly RepeatedField<string> sessionType_ = new RepeatedField<string>();

		// Token: 0x04004F1A RID: 20250
		public const int Unk1FieldNumber = 4;

		// Token: 0x04004F1B RID: 20251
		private static readonly uint Unk1DefaultValue = 0U;

		// Token: 0x04004F1C RID: 20252
		private uint unk1_;

		// Token: 0x04004F1D RID: 20253
		public const int Unk2FieldNumber = 5;

		// Token: 0x04004F1E RID: 20254
		private static readonly uint Unk2DefaultValue = 0U;

		// Token: 0x04004F1F RID: 20255
		private uint unk2_;

		// Token: 0x04004F20 RID: 20256
		public const int Unk3FieldNumber = 6;

		// Token: 0x04004F21 RID: 20257
		private static readonly uint Unk3DefaultValue = 0U;

		// Token: 0x04004F22 RID: 20258
		private uint unk3_;

		// Token: 0x04004F23 RID: 20259
		public const int Unk4FieldNumber = 8;

		// Token: 0x04004F24 RID: 20260
		private static readonly uint Unk4DefaultValue = 0U;

		// Token: 0x04004F25 RID: 20261
		private uint unk4_;

		// Token: 0x04004F26 RID: 20262
		public const int CountryFieldNumber = 9;

		// Token: 0x04004F27 RID: 20263
		private static readonly string CountryDefaultValue = "";

		// Token: 0x04004F28 RID: 20264
		private string country_;

		// Token: 0x04004F29 RID: 20265
		public const int Unk5FieldNumber = 10;

		// Token: 0x04004F2A RID: 20266
		private static readonly uint Unk5DefaultValue = 0U;

		// Token: 0x04004F2B RID: 20267
		private uint unk5_;

		// Token: 0x04004F2C RID: 20268
		public const int Unk6FieldNumber = 11;

		// Token: 0x04004F2D RID: 20269
		private static readonly uint Unk6DefaultValue = 0U;

		// Token: 0x04004F2E RID: 20270
		private uint unk6_;
	}
}
