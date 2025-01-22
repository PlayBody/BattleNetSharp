using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000773 RID: 1907
	public sealed class AuthSessionRequest : IMessage<AuthSessionRequest>, IMessage, IEquatable<AuthSessionRequest>, IDeepCloneable<AuthSessionRequest>, IBufferMessage
	{
		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x002AA414 File Offset: 0x002A8614
		[DebuggerNonUserCode]
		public static MessageParser<AuthSessionRequest> Parser
		{
			get
			{
				return AuthSessionRequest._parser;
			}
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600AF35 RID: 44853 RVA: 0x002AA42C File Offset: 0x002A862C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x002AA450 File Offset: 0x002A8650
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthSessionRequest.Descriptor;
			}
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x002AA467 File Offset: 0x002A8667
		[DebuggerNonUserCode]
		public AuthSessionRequest()
		{
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x002AA47C File Offset: 0x002A867C
		[DebuggerNonUserCode]
		public AuthSessionRequest(AuthSessionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionKey_ = other.sessionKey_;
			this.body_ = ((other.body_ != null) ? other.body_.Clone() : null);
			this.program_ = other.program_;
			this.version_ = other.version_;
			this.baseKey_ = other.baseKey_;
			this.thirty100_ = other.thirty100_;
			this.platform_ = other.platform_;
			this.one_ = other.one_;
			this.unk_ = other.unk_.Clone();
			this.unk2_ = other.unk2_;
			this.unk3_ = other.unk3_;
			this.unk4_ = other.unk4_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x002AA554 File Offset: 0x002A8754
		[DebuggerNonUserCode]
		public AuthSessionRequest Clone()
		{
			return new AuthSessionRequest(this);
		}

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x002AA56C File Offset: 0x002A876C
		// (set) Token: 0x0600AF3B RID: 44859 RVA: 0x002AA58D File Offset: 0x002A878D
		[DebuggerNonUserCode]
		public string SessionKey
		{
			get
			{
				return this.sessionKey_ ?? AuthSessionRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x002AA5A4 File Offset: 0x002A87A4
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x002AA5BF File Offset: 0x002A87BF
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x002AA5CC File Offset: 0x002A87CC
		// (set) Token: 0x0600AF3F RID: 44863 RVA: 0x002AA5E4 File Offset: 0x002A87E4
		[DebuggerNonUserCode]
		public AuthBody Body
		{
			get
			{
				return this.body_;
			}
			set
			{
				this.body_ = value;
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600AF40 RID: 44864 RVA: 0x002AA5F0 File Offset: 0x002A87F0
		// (set) Token: 0x0600AF41 RID: 44865 RVA: 0x002AA621 File Offset: 0x002A8821
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = AuthSessionRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600AF42 RID: 44866 RVA: 0x002AA63C File Offset: 0x002A883C
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x002AA659 File Offset: 0x002A8859
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600AF44 RID: 44868 RVA: 0x002AA66C File Offset: 0x002A886C
		// (set) Token: 0x0600AF45 RID: 44869 RVA: 0x002AA68D File Offset: 0x002A888D
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? AuthSessionRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600AF46 RID: 44870 RVA: 0x002AA6A4 File Offset: 0x002A88A4
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600AF47 RID: 44871 RVA: 0x002AA6BF File Offset: 0x002A88BF
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600AF48 RID: 44872 RVA: 0x002AA6CC File Offset: 0x002A88CC
		// (set) Token: 0x0600AF49 RID: 44873 RVA: 0x002AA6ED File Offset: 0x002A88ED
		[DebuggerNonUserCode]
		public string BaseKey
		{
			get
			{
				return this.baseKey_ ?? AuthSessionRequest.BaseKeyDefaultValue;
			}
			set
			{
				this.baseKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x002AA704 File Offset: 0x002A8904
		[DebuggerNonUserCode]
		public bool HasBaseKey
		{
			get
			{
				return this.baseKey_ != null;
			}
		}

		// Token: 0x0600AF4B RID: 44875 RVA: 0x002AA71F File Offset: 0x002A891F
		[DebuggerNonUserCode]
		public void ClearBaseKey()
		{
			this.baseKey_ = null;
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x002AA72C File Offset: 0x002A892C
		// (set) Token: 0x0600AF4D RID: 44877 RVA: 0x002AA75D File Offset: 0x002A895D
		[DebuggerNonUserCode]
		public uint Thirty100
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint thirty100DefaultValue;
				if (flag)
				{
					thirty100DefaultValue = this.thirty100_;
				}
				else
				{
					thirty100DefaultValue = AuthSessionRequest.Thirty100DefaultValue;
				}
				return thirty100DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.thirty100_ = value;
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x002AA778 File Offset: 0x002A8978
		[DebuggerNonUserCode]
		public bool HasThirty100
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AF4F RID: 44879 RVA: 0x002AA795 File Offset: 0x002A8995
		[DebuggerNonUserCode]
		public void ClearThirty100()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600AF50 RID: 44880 RVA: 0x002AA7A8 File Offset: 0x002A89A8
		// (set) Token: 0x0600AF51 RID: 44881 RVA: 0x002AA7D9 File Offset: 0x002A89D9
		[DebuggerNonUserCode]
		public uint Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = AuthSessionRequest.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.platform_ = value;
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x002AA7F4 File Offset: 0x002A89F4
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AF53 RID: 44883 RVA: 0x002AA811 File Offset: 0x002A8A11
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x002AA824 File Offset: 0x002A8A24
		// (set) Token: 0x0600AF55 RID: 44885 RVA: 0x002AA855 File Offset: 0x002A8A55
		[DebuggerNonUserCode]
		public uint One
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint oneDefaultValue;
				if (flag)
				{
					oneDefaultValue = this.one_;
				}
				else
				{
					oneDefaultValue = AuthSessionRequest.OneDefaultValue;
				}
				return oneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.one_ = value;
			}
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x002AA870 File Offset: 0x002A8A70
		[DebuggerNonUserCode]
		public bool HasOne
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x002AA88D File Offset: 0x002A8A8D
		[DebuggerNonUserCode]
		public void ClearOne()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600AF58 RID: 44888 RVA: 0x002AA8A0 File Offset: 0x002A8AA0
		[DebuggerNonUserCode]
		public RepeatedField<uint> Unk
		{
			get
			{
				return this.unk_;
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600AF59 RID: 44889 RVA: 0x002AA8B8 File Offset: 0x002A8AB8
		// (set) Token: 0x0600AF5A RID: 44890 RVA: 0x002AA8D9 File Offset: 0x002A8AD9
		[DebuggerNonUserCode]
		public string Unk2
		{
			get
			{
				return this.unk2_ ?? AuthSessionRequest.Unk2DefaultValue;
			}
			set
			{
				this.unk2_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600AF5B RID: 44891 RVA: 0x002AA8F0 File Offset: 0x002A8AF0
		[DebuggerNonUserCode]
		public bool HasUnk2
		{
			get
			{
				return this.unk2_ != null;
			}
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x002AA90B File Offset: 0x002A8B0B
		[DebuggerNonUserCode]
		public void ClearUnk2()
		{
			this.unk2_ = null;
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600AF5D RID: 44893 RVA: 0x002AA918 File Offset: 0x002A8B18
		// (set) Token: 0x0600AF5E RID: 44894 RVA: 0x002AA939 File Offset: 0x002A8B39
		[DebuggerNonUserCode]
		public string Unk3
		{
			get
			{
				return this.unk3_ ?? AuthSessionRequest.Unk3DefaultValue;
			}
			set
			{
				this.unk3_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600AF5F RID: 44895 RVA: 0x002AA950 File Offset: 0x002A8B50
		[DebuggerNonUserCode]
		public bool HasUnk3
		{
			get
			{
				return this.unk3_ != null;
			}
		}

		// Token: 0x0600AF60 RID: 44896 RVA: 0x002AA96B File Offset: 0x002A8B6B
		[DebuggerNonUserCode]
		public void ClearUnk3()
		{
			this.unk3_ = null;
		}

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600AF61 RID: 44897 RVA: 0x002AA978 File Offset: 0x002A8B78
		// (set) Token: 0x0600AF62 RID: 44898 RVA: 0x002AA999 File Offset: 0x002A8B99
		[DebuggerNonUserCode]
		public string Unk4
		{
			get
			{
				return this.unk4_ ?? AuthSessionRequest.Unk4DefaultValue;
			}
			set
			{
				this.unk4_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600AF63 RID: 44899 RVA: 0x002AA9B0 File Offset: 0x002A8BB0
		[DebuggerNonUserCode]
		public bool HasUnk4
		{
			get
			{
				return this.unk4_ != null;
			}
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x002AA9CB File Offset: 0x002A8BCB
		[DebuggerNonUserCode]
		public void ClearUnk4()
		{
			this.unk4_ = null;
		}

		// Token: 0x0600AF65 RID: 44901 RVA: 0x002AA9D8 File Offset: 0x002A8BD8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AuthSessionRequest);
		}

		// Token: 0x0600AF66 RID: 44902 RVA: 0x002AA9F8 File Offset: 0x002A8BF8
		[DebuggerNonUserCode]
		public bool Equals(AuthSessionRequest other)
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
					bool flag4 = this.SessionKey != other.SessionKey;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Body, other.Body);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Program != other.Program;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Version != other.Version;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BaseKey != other.BaseKey;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Thirty100 != other.Thirty100;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Platform != other.Platform;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.One != other.One;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.unk_.Equals(other.unk_);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Unk2 != other.Unk2;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Unk3 != other.Unk3;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.Unk4 != other.Unk4;
																flag2 = !flag15 && object.Equals(this._unknownFields, other._unknownFields);
															}
														}
													}
												}
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

		// Token: 0x0600AF67 RID: 44903 RVA: 0x002AAB9C File Offset: 0x002A8D9C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag = this.body_ != null;
			if (flag)
			{
				num ^= this.Body.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
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
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool hasOne = this.HasOne;
			if (hasOne)
			{
				num ^= this.One.GetHashCode();
			}
			num ^= this.unk_.GetHashCode();
			bool hasUnk = this.HasUnk2;
			if (hasUnk)
			{
				num ^= this.Unk2.GetHashCode();
			}
			bool hasUnk2 = this.HasUnk3;
			if (hasUnk2)
			{
				num ^= this.Unk3.GetHashCode();
			}
			bool hasUnk3 = this.HasUnk4;
			if (hasUnk3)
			{
				num ^= this.Unk4.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF68 RID: 44904 RVA: 0x002AAD0C File Offset: 0x002A8F0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF69 RID: 44905 RVA: 0x002AAD24 File Offset: 0x002A8F24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x002AAD30 File Offset: 0x002A8F30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SessionKey);
			}
			bool flag = this.body_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Body);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Program);
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
				output.WriteUInt32(this.Thirty100);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Platform);
			}
			bool hasOne = this.HasOne;
			if (hasOne)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.One);
			}
			this.unk_.WriteTo(ref output, AuthSessionRequest._repeated_unk_codec);
			bool hasUnk = this.HasUnk2;
			if (hasUnk)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Unk2);
			}
			bool hasUnk2 = this.HasUnk3;
			if (hasUnk2)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Unk3);
			}
			bool hasUnk3 = this.HasUnk4;
			if (hasUnk3)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Unk4);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF6B RID: 44907 RVA: 0x002AAEF8 File Offset: 0x002A90F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionKey);
			}
			bool flag = this.body_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Body);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
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
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Thirty100);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Platform);
			}
			bool hasOne = this.HasOne;
			if (hasOne)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.One);
			}
			num += this.unk_.CalculateSize(AuthSessionRequest._repeated_unk_codec);
			bool hasUnk = this.HasUnk2;
			if (hasUnk)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Unk2);
			}
			bool hasUnk2 = this.HasUnk3;
			if (hasUnk2)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Unk3);
			}
			bool hasUnk3 = this.HasUnk4;
			if (hasUnk3)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Unk4);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF6C RID: 44908 RVA: 0x002AB088 File Offset: 0x002A9288
		[DebuggerNonUserCode]
		public void MergeFrom(AuthSessionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool flag2 = other.body_ != null;
				if (flag2)
				{
					bool flag3 = this.body_ == null;
					if (flag3)
					{
						this.Body = new AuthBody();
					}
					this.Body.MergeFrom(other.Body);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
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
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool hasOne = other.HasOne;
				if (hasOne)
				{
					this.One = other.One;
				}
				this.unk_.Add(other.unk_);
				bool hasUnk = other.HasUnk2;
				if (hasUnk)
				{
					this.Unk2 = other.Unk2;
				}
				bool hasUnk2 = other.HasUnk3;
				if (hasUnk2)
				{
					this.Unk3 = other.Unk3;
				}
				bool hasUnk3 = other.HasUnk4;
				if (hasUnk3)
				{
					this.Unk4 = other.Unk4;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AF6D RID: 44909 RVA: 0x002AB215 File Offset: 0x002A9415
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF6E RID: 44910 RVA: 0x002AB220 File Offset: 0x002A9420
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
					if (num3 <= 24U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 24U)
								{
									goto IL_00A1;
								}
								this.Program = input.ReadUInt32();
							}
							else
							{
								bool flag = this.body_ == null;
								if (flag)
								{
									this.Body = new AuthBody();
								}
								input.ReadMessage(this.Body);
							}
						}
						else
						{
							this.SessionKey = input.ReadString();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							if (num3 != 48U)
							{
								goto IL_00A1;
							}
							this.Thirty100 = input.ReadUInt32();
						}
						else
						{
							this.BaseKey = input.ReadString();
						}
					}
					else
					{
						this.Version = input.ReadString();
					}
				}
				else
				{
					if (num3 <= 72U)
					{
						if (num3 == 56U)
						{
							this.Platform = input.ReadUInt32();
							continue;
						}
						if (num3 == 64U)
						{
							this.One = input.ReadUInt32();
							continue;
						}
						if (num3 != 72U)
						{
							goto IL_00A1;
						}
					}
					else if (num3 <= 82U)
					{
						if (num3 != 74U)
						{
							if (num3 != 82U)
							{
								goto IL_00A1;
							}
							this.Unk2 = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num3 == 90U)
						{
							this.Unk3 = input.ReadString();
							continue;
						}
						if (num3 != 98U)
						{
							goto IL_00A1;
						}
						this.Unk4 = input.ReadString();
						continue;
					}
					this.unk_.AddEntriesFrom(ref input, AuthSessionRequest._repeated_unk_codec);
				}
				continue;
				IL_00A1:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004EEE RID: 20206
		private static readonly MessageParser<AuthSessionRequest> _parser = new MessageParser<AuthSessionRequest>(() => new AuthSessionRequest());

		// Token: 0x04004EEF RID: 20207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EF0 RID: 20208
		private int _hasBits0;

		// Token: 0x04004EF1 RID: 20209
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04004EF2 RID: 20210
		private static readonly string SessionKeyDefaultValue = "";

		// Token: 0x04004EF3 RID: 20211
		private string sessionKey_;

		// Token: 0x04004EF4 RID: 20212
		public const int BodyFieldNumber = 2;

		// Token: 0x04004EF5 RID: 20213
		private AuthBody body_;

		// Token: 0x04004EF6 RID: 20214
		public const int ProgramFieldNumber = 3;

		// Token: 0x04004EF7 RID: 20215
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004EF8 RID: 20216
		private uint program_;

		// Token: 0x04004EF9 RID: 20217
		public const int VersionFieldNumber = 4;

		// Token: 0x04004EFA RID: 20218
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004EFB RID: 20219
		private string version_;

		// Token: 0x04004EFC RID: 20220
		public const int BaseKeyFieldNumber = 5;

		// Token: 0x04004EFD RID: 20221
		private static readonly string BaseKeyDefaultValue = "";

		// Token: 0x04004EFE RID: 20222
		private string baseKey_;

		// Token: 0x04004EFF RID: 20223
		public const int Thirty100FieldNumber = 6;

		// Token: 0x04004F00 RID: 20224
		private static readonly uint Thirty100DefaultValue = 0U;

		// Token: 0x04004F01 RID: 20225
		private uint thirty100_;

		// Token: 0x04004F02 RID: 20226
		public const int PlatformFieldNumber = 7;

		// Token: 0x04004F03 RID: 20227
		private static readonly uint PlatformDefaultValue = 0U;

		// Token: 0x04004F04 RID: 20228
		private uint platform_;

		// Token: 0x04004F05 RID: 20229
		public const int OneFieldNumber = 8;

		// Token: 0x04004F06 RID: 20230
		private static readonly uint OneDefaultValue = 0U;

		// Token: 0x04004F07 RID: 20231
		private uint one_;

		// Token: 0x04004F08 RID: 20232
		public const int UnkFieldNumber = 9;

		// Token: 0x04004F09 RID: 20233
		private static readonly FieldCodec<uint> _repeated_unk_codec = FieldCodec.ForUInt32(72U);

		// Token: 0x04004F0A RID: 20234
		private readonly RepeatedField<uint> unk_ = new RepeatedField<uint>();

		// Token: 0x04004F0B RID: 20235
		public const int Unk2FieldNumber = 10;

		// Token: 0x04004F0C RID: 20236
		private static readonly string Unk2DefaultValue = "";

		// Token: 0x04004F0D RID: 20237
		private string unk2_;

		// Token: 0x04004F0E RID: 20238
		public const int Unk3FieldNumber = 11;

		// Token: 0x04004F0F RID: 20239
		private static readonly string Unk3DefaultValue = "";

		// Token: 0x04004F10 RID: 20240
		private string unk3_;

		// Token: 0x04004F11 RID: 20241
		public const int Unk4FieldNumber = 12;

		// Token: 0x04004F12 RID: 20242
		private static readonly string Unk4DefaultValue = "";

		// Token: 0x04004F13 RID: 20243
		private string unk4_;
	}
}
