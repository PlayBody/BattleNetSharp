using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000771 RID: 1905
	public sealed class AuthRequest : IMessage<AuthRequest>, IMessage, IEquatable<AuthRequest>, IDeepCloneable<AuthRequest>, IBufferMessage
	{
		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600AEF0 RID: 44784 RVA: 0x002A94B8 File Offset: 0x002A76B8
		[DebuggerNonUserCode]
		public static MessageParser<AuthRequest> Parser
		{
			get
			{
				return AuthRequest._parser;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600AEF1 RID: 44785 RVA: 0x002A94D0 File Offset: 0x002A76D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600AEF2 RID: 44786 RVA: 0x002A94F4 File Offset: 0x002A76F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthRequest.Descriptor;
			}
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x002A950B File Offset: 0x002A770B
		[DebuggerNonUserCode]
		public AuthRequest()
		{
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x002A9518 File Offset: 0x002A7718
		[DebuggerNonUserCode]
		public AuthRequest(AuthRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionKey_ = other.sessionKey_;
			this.body_ = ((other.body_ != null) ? other.body_.Clone() : null);
			this.oSI_ = other.oSI_;
			this.version_ = other.version_;
			this.baseKey_ = other.baseKey_;
			this.thirty100_ = other.thirty100_;
			this.wn64_ = other.wn64_;
			this.one_ = other.one_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x002A95BC File Offset: 0x002A77BC
		[DebuggerNonUserCode]
		public AuthRequest Clone()
		{
			return new AuthRequest(this);
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600AEF6 RID: 44790 RVA: 0x002A95D4 File Offset: 0x002A77D4
		// (set) Token: 0x0600AEF7 RID: 44791 RVA: 0x002A95F5 File Offset: 0x002A77F5
		[DebuggerNonUserCode]
		public string SessionKey
		{
			get
			{
				return this.sessionKey_ ?? AuthRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x002A960C File Offset: 0x002A780C
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x0600AEF9 RID: 44793 RVA: 0x002A9627 File Offset: 0x002A7827
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x002A9634 File Offset: 0x002A7834
		// (set) Token: 0x0600AEFB RID: 44795 RVA: 0x002A964C File Offset: 0x002A784C
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

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x002A9658 File Offset: 0x002A7858
		// (set) Token: 0x0600AEFD RID: 44797 RVA: 0x002A9689 File Offset: 0x002A7889
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
					osidefaultValue = AuthRequest.OSIDefaultValue;
				}
				return osidefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.oSI_ = value;
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600AEFE RID: 44798 RVA: 0x002A96A4 File Offset: 0x002A78A4
		[DebuggerNonUserCode]
		public bool HasOSI
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AEFF RID: 44799 RVA: 0x002A96C1 File Offset: 0x002A78C1
		[DebuggerNonUserCode]
		public void ClearOSI()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600AF00 RID: 44800 RVA: 0x002A96D4 File Offset: 0x002A78D4
		// (set) Token: 0x0600AF01 RID: 44801 RVA: 0x002A96F5 File Offset: 0x002A78F5
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? AuthRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600AF02 RID: 44802 RVA: 0x002A970C File Offset: 0x002A790C
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x002A9727 File Offset: 0x002A7927
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600AF04 RID: 44804 RVA: 0x002A9734 File Offset: 0x002A7934
		// (set) Token: 0x0600AF05 RID: 44805 RVA: 0x002A9755 File Offset: 0x002A7955
		[DebuggerNonUserCode]
		public string BaseKey
		{
			get
			{
				return this.baseKey_ ?? AuthRequest.BaseKeyDefaultValue;
			}
			set
			{
				this.baseKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600AF06 RID: 44806 RVA: 0x002A976C File Offset: 0x002A796C
		[DebuggerNonUserCode]
		public bool HasBaseKey
		{
			get
			{
				return this.baseKey_ != null;
			}
		}

		// Token: 0x0600AF07 RID: 44807 RVA: 0x002A9787 File Offset: 0x002A7987
		[DebuggerNonUserCode]
		public void ClearBaseKey()
		{
			this.baseKey_ = null;
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x002A9794 File Offset: 0x002A7994
		// (set) Token: 0x0600AF09 RID: 44809 RVA: 0x002A97C5 File Offset: 0x002A79C5
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
					thirty100DefaultValue = AuthRequest.Thirty100DefaultValue;
				}
				return thirty100DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.thirty100_ = value;
			}
		}

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600AF0A RID: 44810 RVA: 0x002A97E0 File Offset: 0x002A79E0
		[DebuggerNonUserCode]
		public bool HasThirty100
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x002A97FD File Offset: 0x002A79FD
		[DebuggerNonUserCode]
		public void ClearThirty100()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600AF0C RID: 44812 RVA: 0x002A9810 File Offset: 0x002A7A10
		// (set) Token: 0x0600AF0D RID: 44813 RVA: 0x002A9841 File Offset: 0x002A7A41
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
					wn64DefaultValue = AuthRequest.Wn64DefaultValue;
				}
				return wn64DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.wn64_ = value;
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600AF0E RID: 44814 RVA: 0x002A985C File Offset: 0x002A7A5C
		[DebuggerNonUserCode]
		public bool HasWn64
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AF0F RID: 44815 RVA: 0x002A9879 File Offset: 0x002A7A79
		[DebuggerNonUserCode]
		public void ClearWn64()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600AF10 RID: 44816 RVA: 0x002A988C File Offset: 0x002A7A8C
		// (set) Token: 0x0600AF11 RID: 44817 RVA: 0x002A98BD File Offset: 0x002A7ABD
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
					oneDefaultValue = AuthRequest.OneDefaultValue;
				}
				return oneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.one_ = value;
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x002A98D8 File Offset: 0x002A7AD8
		[DebuggerNonUserCode]
		public bool HasOne
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AF13 RID: 44819 RVA: 0x002A98F5 File Offset: 0x002A7AF5
		[DebuggerNonUserCode]
		public void ClearOne()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600AF14 RID: 44820 RVA: 0x002A9908 File Offset: 0x002A7B08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AuthRequest);
		}

		// Token: 0x0600AF15 RID: 44821 RVA: 0x002A9928 File Offset: 0x002A7B28
		[DebuggerNonUserCode]
		public bool Equals(AuthRequest other)
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
							bool flag6 = this.OSI != other.OSI;
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
											bool flag10 = this.Wn64 != other.Wn64;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.One != other.One;
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

		// Token: 0x0600AF16 RID: 44822 RVA: 0x002A9A50 File Offset: 0x002A7C50
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF17 RID: 44823 RVA: 0x002A9B64 File Offset: 0x002A7D64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF18 RID: 44824 RVA: 0x002A9B7C File Offset: 0x002A7D7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x002A9B88 File Offset: 0x002A7D88
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x002A9CD0 File Offset: 0x002A7ED0
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
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x002A9DF4 File Offset: 0x002A7FF4
		[DebuggerNonUserCode]
		public void MergeFrom(AuthRequest other)
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

		// Token: 0x0600AF1C RID: 44828 RVA: 0x002A9F1E File Offset: 0x002A811E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF1D RID: 44829 RVA: 0x002A9F2C File Offset: 0x002A812C
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
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0064;
							}
							bool flag = this.body_ == null;
							if (flag)
							{
								this.Body = new AuthBody();
							}
							input.ReadMessage(this.Body);
						}
						else
						{
							this.SessionKey = input.ReadString();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							goto IL_0064;
						}
						this.Version = input.ReadString();
					}
					else
					{
						this.OSI = input.ReadInt32();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0064;
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
						goto IL_0064;
					}
					this.One = input.ReadInt32();
				}
				else
				{
					this.Wn64 = input.ReadInt32();
				}
				continue;
				IL_0064:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004ECF RID: 20175
		private static readonly MessageParser<AuthRequest> _parser = new MessageParser<AuthRequest>(() => new AuthRequest());

		// Token: 0x04004ED0 RID: 20176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED1 RID: 20177
		private int _hasBits0;

		// Token: 0x04004ED2 RID: 20178
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04004ED3 RID: 20179
		private static readonly string SessionKeyDefaultValue = "";

		// Token: 0x04004ED4 RID: 20180
		private string sessionKey_;

		// Token: 0x04004ED5 RID: 20181
		public const int BodyFieldNumber = 2;

		// Token: 0x04004ED6 RID: 20182
		private AuthBody body_;

		// Token: 0x04004ED7 RID: 20183
		public const int OSIFieldNumber = 3;

		// Token: 0x04004ED8 RID: 20184
		private static readonly int OSIDefaultValue = 0;

		// Token: 0x04004ED9 RID: 20185
		private int oSI_;

		// Token: 0x04004EDA RID: 20186
		public const int VersionFieldNumber = 4;

		// Token: 0x04004EDB RID: 20187
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004EDC RID: 20188
		private string version_;

		// Token: 0x04004EDD RID: 20189
		public const int BaseKeyFieldNumber = 5;

		// Token: 0x04004EDE RID: 20190
		private static readonly string BaseKeyDefaultValue = "";

		// Token: 0x04004EDF RID: 20191
		private string baseKey_;

		// Token: 0x04004EE0 RID: 20192
		public const int Thirty100FieldNumber = 6;

		// Token: 0x04004EE1 RID: 20193
		private static readonly int Thirty100DefaultValue = 0;

		// Token: 0x04004EE2 RID: 20194
		private int thirty100_;

		// Token: 0x04004EE3 RID: 20195
		public const int Wn64FieldNumber = 7;

		// Token: 0x04004EE4 RID: 20196
		private static readonly int Wn64DefaultValue = 0;

		// Token: 0x04004EE5 RID: 20197
		private int wn64_;

		// Token: 0x04004EE6 RID: 20198
		public const int OneFieldNumber = 8;

		// Token: 0x04004EE7 RID: 20199
		private static readonly int OneDefaultValue = 0;

		// Token: 0x04004EE8 RID: 20200
		private int one_;
	}
}
