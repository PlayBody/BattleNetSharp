using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000770 RID: 1904
	public sealed class AuthBody : IMessage<AuthBody>, IMessage, IEquatable<AuthBody>, IDeepCloneable<AuthBody>, IBufferMessage
	{
		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600AECD RID: 44749 RVA: 0x002A8C5C File Offset: 0x002A6E5C
		[DebuggerNonUserCode]
		public static MessageParser<AuthBody> Parser
		{
			get
			{
				return AuthBody._parser;
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600AECE RID: 44750 RVA: 0x002A8C74 File Offset: 0x002A6E74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600AECF RID: 44751 RVA: 0x002A8C98 File Offset: 0x002A6E98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthBody.Descriptor;
			}
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x002A8CAF File Offset: 0x002A6EAF
		[DebuggerNonUserCode]
		public AuthBody()
		{
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x002A8CBC File Offset: 0x002A6EBC
		[DebuggerNonUserCode]
		public AuthBody(AuthBody other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionKey_ = other.sessionKey_;
			this.zero_ = other.zero_;
			this.platform_ = other.platform_;
			this.entity_ = ((other.entity_ != null) ? other.entity_.Clone() : null);
			this.zero2_ = other.zero2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x002A8D3C File Offset: 0x002A6F3C
		[DebuggerNonUserCode]
		public AuthBody Clone()
		{
			return new AuthBody(this);
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600AED3 RID: 44755 RVA: 0x002A8D54 File Offset: 0x002A6F54
		// (set) Token: 0x0600AED4 RID: 44756 RVA: 0x002A8D75 File Offset: 0x002A6F75
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? AuthBody.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600AED5 RID: 44757 RVA: 0x002A8D8C File Offset: 0x002A6F8C
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x002A8DAA File Offset: 0x002A6FAA
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x002A8DB4 File Offset: 0x002A6FB4
		// (set) Token: 0x0600AED8 RID: 44760 RVA: 0x002A8DE5 File Offset: 0x002A6FE5
		[DebuggerNonUserCode]
		public int Zero
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int zeroDefaultValue;
				if (flag)
				{
					zeroDefaultValue = this.zero_;
				}
				else
				{
					zeroDefaultValue = AuthBody.ZeroDefaultValue;
				}
				return zeroDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.zero_ = value;
			}
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600AED9 RID: 44761 RVA: 0x002A8E00 File Offset: 0x002A7000
		[DebuggerNonUserCode]
		public bool HasZero
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x002A8E1D File Offset: 0x002A701D
		[DebuggerNonUserCode]
		public void ClearZero()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600AEDB RID: 44763 RVA: 0x002A8E30 File Offset: 0x002A7030
		// (set) Token: 0x0600AEDC RID: 44764 RVA: 0x002A8E61 File Offset: 0x002A7061
		[DebuggerNonUserCode]
		public int Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = AuthBody.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.platform_ = value;
			}
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600AEDD RID: 44765 RVA: 0x002A8E7C File Offset: 0x002A707C
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x002A8E99 File Offset: 0x002A7099
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600AEDF RID: 44767 RVA: 0x002A8EAC File Offset: 0x002A70AC
		// (set) Token: 0x0600AEE0 RID: 44768 RVA: 0x002A8EC4 File Offset: 0x002A70C4
		[DebuggerNonUserCode]
		public Entity Entity
		{
			get
			{
				return this.entity_;
			}
			set
			{
				this.entity_ = value;
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600AEE1 RID: 44769 RVA: 0x002A8ED0 File Offset: 0x002A70D0
		// (set) Token: 0x0600AEE2 RID: 44770 RVA: 0x002A8F01 File Offset: 0x002A7101
		[DebuggerNonUserCode]
		public int Zero2
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int zero2DefaultValue;
				if (flag)
				{
					zero2DefaultValue = this.zero2_;
				}
				else
				{
					zero2DefaultValue = AuthBody.Zero2DefaultValue;
				}
				return zero2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.zero2_ = value;
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600AEE3 RID: 44771 RVA: 0x002A8F1C File Offset: 0x002A711C
		[DebuggerNonUserCode]
		public bool HasZero2
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x002A8F39 File Offset: 0x002A7139
		[DebuggerNonUserCode]
		public void ClearZero2()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x002A8F4C File Offset: 0x002A714C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AuthBody);
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x002A8F6C File Offset: 0x002A716C
		[DebuggerNonUserCode]
		public bool Equals(AuthBody other)
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
						bool flag5 = this.Zero != other.Zero;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Platform != other.Platform;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Entity, other.Entity);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Zero2 != other.Zero2;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x002A903C File Offset: 0x002A723C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool hasZero = this.HasZero;
			if (hasZero)
			{
				num ^= this.Zero.GetHashCode();
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool flag = this.entity_ != null;
			if (flag)
			{
				num ^= this.Entity.GetHashCode();
			}
			bool hasZero2 = this.HasZero2;
			if (hasZero2)
			{
				num ^= this.Zero2.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x002A90FC File Offset: 0x002A72FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AEE9 RID: 44777 RVA: 0x002A9114 File Offset: 0x002A7314
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEEA RID: 44778 RVA: 0x002A9120 File Offset: 0x002A7320
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.SessionKey);
			}
			bool hasZero = this.HasZero;
			if (hasZero)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Zero);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Platform);
			}
			bool flag = this.entity_ != null;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Entity);
			}
			bool hasZero2 = this.HasZero2;
			if (hasZero2)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Zero2);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEEB RID: 44779 RVA: 0x002A91FC File Offset: 0x002A73FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool hasZero = this.HasZero;
			if (hasZero)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Zero);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Platform);
			}
			bool flag = this.entity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entity);
			}
			bool hasZero2 = this.HasZero2;
			if (hasZero2)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Zero2);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x002A92C8 File Offset: 0x002A74C8
		[DebuggerNonUserCode]
		public void MergeFrom(AuthBody other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool hasZero = other.HasZero;
				if (hasZero)
				{
					this.Zero = other.Zero;
				}
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool flag2 = other.entity_ != null;
				if (flag2)
				{
					bool flag3 = this.entity_ == null;
					if (flag3)
					{
						this.Entity = new Entity();
					}
					this.Entity.MergeFrom(other.Entity);
				}
				bool hasZero2 = other.HasZero2;
				if (hasZero2)
				{
					this.Zero2 = other.Zero2;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x002A93A1 File Offset: 0x002A75A1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x002A93AC File Offset: 0x002A75AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.Zero = input.ReadInt32();
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 50U)
					{
						if (num3 != 64U)
						{
							goto IL_0033;
						}
						this.Zero2 = input.ReadInt32();
					}
					else
					{
						bool flag = this.entity_ == null;
						if (flag)
						{
							this.Entity = new Entity();
						}
						input.ReadMessage(this.Entity);
					}
				}
				else
				{
					this.Platform = input.ReadInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004EBE RID: 20158
		private static readonly MessageParser<AuthBody> _parser = new MessageParser<AuthBody>(() => new AuthBody());

		// Token: 0x04004EBF RID: 20159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EC0 RID: 20160
		private int _hasBits0;

		// Token: 0x04004EC1 RID: 20161
		public const int SessionKeyFieldNumber = 1;

		// Token: 0x04004EC2 RID: 20162
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04004EC3 RID: 20163
		private ByteString sessionKey_;

		// Token: 0x04004EC4 RID: 20164
		public const int ZeroFieldNumber = 2;

		// Token: 0x04004EC5 RID: 20165
		private static readonly int ZeroDefaultValue = 0;

		// Token: 0x04004EC6 RID: 20166
		private int zero_;

		// Token: 0x04004EC7 RID: 20167
		public const int PlatformFieldNumber = 4;

		// Token: 0x04004EC8 RID: 20168
		private static readonly int PlatformDefaultValue = 0;

		// Token: 0x04004EC9 RID: 20169
		private int platform_;

		// Token: 0x04004ECA RID: 20170
		public const int EntityFieldNumber = 6;

		// Token: 0x04004ECB RID: 20171
		private Entity entity_;

		// Token: 0x04004ECC RID: 20172
		public const int Zero2FieldNumber = 8;

		// Token: 0x04004ECD RID: 20173
		private static readonly int Zero2DefaultValue = 0;

		// Token: 0x04004ECE RID: 20174
		private int zero2_;
	}
}
