using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Chat
{
	// Token: 0x0200077A RID: 1914
	public sealed class ChatRequest : IMessage<ChatRequest>, IMessage, IEquatable<ChatRequest>, IDeepCloneable<ChatRequest>, IBufferMessage
	{
		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600AFED RID: 45037 RVA: 0x002AD310 File Offset: 0x002AB510
		[DebuggerNonUserCode]
		public static MessageParser<ChatRequest> Parser
		{
			get
			{
				return ChatRequest._parser;
			}
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600AFEE RID: 45038 RVA: 0x002AD328 File Offset: 0x002AB528
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChatReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600AFEF RID: 45039 RVA: 0x002AD34C File Offset: 0x002AB54C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatRequest.Descriptor;
			}
		}

		// Token: 0x0600AFF0 RID: 45040 RVA: 0x002AD363 File Offset: 0x002AB563
		[DebuggerNonUserCode]
		public ChatRequest()
		{
		}

		// Token: 0x0600AFF1 RID: 45041 RVA: 0x002AD370 File Offset: 0x002AB570
		[DebuggerNonUserCode]
		public ChatRequest(ChatRequest other)
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

		// Token: 0x0600AFF2 RID: 45042 RVA: 0x002AD3F8 File Offset: 0x002AB5F8
		[DebuggerNonUserCode]
		public ChatRequest Clone()
		{
			return new ChatRequest(this);
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600AFF3 RID: 45043 RVA: 0x002AD410 File Offset: 0x002AB610
		// (set) Token: 0x0600AFF4 RID: 45044 RVA: 0x002AD431 File Offset: 0x002AB631
		[DebuggerNonUserCode]
		public string Key
		{
			get
			{
				return this.key_ ?? ChatRequest.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x002AD448 File Offset: 0x002AB648
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x002AD463 File Offset: 0x002AB663
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600AFF7 RID: 45047 RVA: 0x002AD470 File Offset: 0x002AB670
		// (set) Token: 0x0600AFF8 RID: 45048 RVA: 0x002AD4A1 File Offset: 0x002AB6A1
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
					osidefaultValue = ChatRequest.OSIDefaultValue;
				}
				return osidefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.oSI_ = value;
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x002AD4BC File Offset: 0x002AB6BC
		[DebuggerNonUserCode]
		public bool HasOSI
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x002AD4D9 File Offset: 0x002AB6D9
		[DebuggerNonUserCode]
		public void ClearOSI()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x002AD4EC File Offset: 0x002AB6EC
		// (set) Token: 0x0600AFFC RID: 45052 RVA: 0x002AD50D File Offset: 0x002AB70D
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? ChatRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x002AD524 File Offset: 0x002AB724
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x002AD53F File Offset: 0x002AB73F
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600AFFF RID: 45055 RVA: 0x002AD54C File Offset: 0x002AB74C
		// (set) Token: 0x0600B000 RID: 45056 RVA: 0x002AD56D File Offset: 0x002AB76D
		[DebuggerNonUserCode]
		public string BaseKey
		{
			get
			{
				return this.baseKey_ ?? ChatRequest.BaseKeyDefaultValue;
			}
			set
			{
				this.baseKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600B001 RID: 45057 RVA: 0x002AD584 File Offset: 0x002AB784
		[DebuggerNonUserCode]
		public bool HasBaseKey
		{
			get
			{
				return this.baseKey_ != null;
			}
		}

		// Token: 0x0600B002 RID: 45058 RVA: 0x002AD59F File Offset: 0x002AB79F
		[DebuggerNonUserCode]
		public void ClearBaseKey()
		{
			this.baseKey_ = null;
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600B003 RID: 45059 RVA: 0x002AD5AC File Offset: 0x002AB7AC
		// (set) Token: 0x0600B004 RID: 45060 RVA: 0x002AD5DD File Offset: 0x002AB7DD
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
					thirty100DefaultValue = ChatRequest.Thirty100DefaultValue;
				}
				return thirty100DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.thirty100_ = value;
			}
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600B005 RID: 45061 RVA: 0x002AD5F8 File Offset: 0x002AB7F8
		[DebuggerNonUserCode]
		public bool HasThirty100
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B006 RID: 45062 RVA: 0x002AD615 File Offset: 0x002AB815
		[DebuggerNonUserCode]
		public void ClearThirty100()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600B007 RID: 45063 RVA: 0x002AD628 File Offset: 0x002AB828
		// (set) Token: 0x0600B008 RID: 45064 RVA: 0x002AD659 File Offset: 0x002AB859
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
					wn64DefaultValue = ChatRequest.Wn64DefaultValue;
				}
				return wn64DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.wn64_ = value;
			}
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600B009 RID: 45065 RVA: 0x002AD674 File Offset: 0x002AB874
		[DebuggerNonUserCode]
		public bool HasWn64
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B00A RID: 45066 RVA: 0x002AD691 File Offset: 0x002AB891
		[DebuggerNonUserCode]
		public void ClearWn64()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600B00B RID: 45067 RVA: 0x002AD6A4 File Offset: 0x002AB8A4
		// (set) Token: 0x0600B00C RID: 45068 RVA: 0x002AD6D5 File Offset: 0x002AB8D5
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
					oneDefaultValue = ChatRequest.OneDefaultValue;
				}
				return oneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.one_ = value;
			}
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600B00D RID: 45069 RVA: 0x002AD6F0 File Offset: 0x002AB8F0
		[DebuggerNonUserCode]
		public bool HasOne
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x002AD70D File Offset: 0x002AB90D
		[DebuggerNonUserCode]
		public void ClearOne()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600B00F RID: 45071 RVA: 0x002AD720 File Offset: 0x002AB920
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatRequest);
		}

		// Token: 0x0600B010 RID: 45072 RVA: 0x002AD740 File Offset: 0x002AB940
		[DebuggerNonUserCode]
		public bool Equals(ChatRequest other)
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

		// Token: 0x0600B011 RID: 45073 RVA: 0x002AD848 File Offset: 0x002ABA48
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

		// Token: 0x0600B012 RID: 45074 RVA: 0x002AD93C File Offset: 0x002ABB3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B013 RID: 45075 RVA: 0x002AD954 File Offset: 0x002ABB54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x002AD960 File Offset: 0x002ABB60
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

		// Token: 0x0600B015 RID: 45077 RVA: 0x002ADA80 File Offset: 0x002ABC80
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

		// Token: 0x0600B016 RID: 45078 RVA: 0x002ADB84 File Offset: 0x002ABD84
		[DebuggerNonUserCode]
		public void MergeFrom(ChatRequest other)
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

		// Token: 0x0600B017 RID: 45079 RVA: 0x002ADC6E File Offset: 0x002ABE6E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x002ADC7C File Offset: 0x002ABE7C
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

		// Token: 0x04004F55 RID: 20309
		private static readonly MessageParser<ChatRequest> _parser = new MessageParser<ChatRequest>(() => new ChatRequest());

		// Token: 0x04004F56 RID: 20310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F57 RID: 20311
		private int _hasBits0;

		// Token: 0x04004F58 RID: 20312
		public const int KeyFieldNumber = 1;

		// Token: 0x04004F59 RID: 20313
		private static readonly string KeyDefaultValue = "";

		// Token: 0x04004F5A RID: 20314
		private string key_;

		// Token: 0x04004F5B RID: 20315
		public const int OSIFieldNumber = 3;

		// Token: 0x04004F5C RID: 20316
		private static readonly int OSIDefaultValue = 0;

		// Token: 0x04004F5D RID: 20317
		private int oSI_;

		// Token: 0x04004F5E RID: 20318
		public const int VersionFieldNumber = 4;

		// Token: 0x04004F5F RID: 20319
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004F60 RID: 20320
		private string version_;

		// Token: 0x04004F61 RID: 20321
		public const int BaseKeyFieldNumber = 5;

		// Token: 0x04004F62 RID: 20322
		private static readonly string BaseKeyDefaultValue = "";

		// Token: 0x04004F63 RID: 20323
		private string baseKey_;

		// Token: 0x04004F64 RID: 20324
		public const int Thirty100FieldNumber = 6;

		// Token: 0x04004F65 RID: 20325
		private static readonly int Thirty100DefaultValue = 0;

		// Token: 0x04004F66 RID: 20326
		private int thirty100_;

		// Token: 0x04004F67 RID: 20327
		public const int Wn64FieldNumber = 7;

		// Token: 0x04004F68 RID: 20328
		private static readonly int Wn64DefaultValue = 0;

		// Token: 0x04004F69 RID: 20329
		private int wn64_;

		// Token: 0x04004F6A RID: 20330
		public const int OneFieldNumber = 8;

		// Token: 0x04004F6B RID: 20331
		private static readonly int OneDefaultValue = 0;

		// Token: 0x04004F6C RID: 20332
		private int one_;
	}
}
