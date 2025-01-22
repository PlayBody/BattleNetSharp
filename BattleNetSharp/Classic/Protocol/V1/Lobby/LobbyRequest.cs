using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Lobby
{
	// Token: 0x0200075D RID: 1885
	public sealed class LobbyRequest : IMessage<LobbyRequest>, IMessage, IEquatable<LobbyRequest>, IDeepCloneable<LobbyRequest>, IBufferMessage
	{
		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600AD62 RID: 44386 RVA: 0x002A3754 File Offset: 0x002A1954
		[DebuggerNonUserCode]
		public static MessageParser<LobbyRequest> Parser
		{
			get
			{
				return LobbyRequest._parser;
			}
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600AD63 RID: 44387 RVA: 0x002A376C File Offset: 0x002A196C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600AD64 RID: 44388 RVA: 0x002A3790 File Offset: 0x002A1990
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyRequest.Descriptor;
			}
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x002A37A7 File Offset: 0x002A19A7
		[DebuggerNonUserCode]
		public LobbyRequest()
		{
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x002A37B4 File Offset: 0x002A19B4
		[DebuggerNonUserCode]
		public LobbyRequest(LobbyRequest other)
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

		// Token: 0x0600AD67 RID: 44391 RVA: 0x002A383C File Offset: 0x002A1A3C
		[DebuggerNonUserCode]
		public LobbyRequest Clone()
		{
			return new LobbyRequest(this);
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600AD68 RID: 44392 RVA: 0x002A3854 File Offset: 0x002A1A54
		// (set) Token: 0x0600AD69 RID: 44393 RVA: 0x002A3875 File Offset: 0x002A1A75
		[DebuggerNonUserCode]
		public string Key
		{
			get
			{
				return this.key_ ?? LobbyRequest.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600AD6A RID: 44394 RVA: 0x002A388C File Offset: 0x002A1A8C
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600AD6B RID: 44395 RVA: 0x002A38A7 File Offset: 0x002A1AA7
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600AD6C RID: 44396 RVA: 0x002A38B4 File Offset: 0x002A1AB4
		// (set) Token: 0x0600AD6D RID: 44397 RVA: 0x002A38E5 File Offset: 0x002A1AE5
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
					osidefaultValue = LobbyRequest.OSIDefaultValue;
				}
				return osidefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.oSI_ = value;
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600AD6E RID: 44398 RVA: 0x002A3900 File Offset: 0x002A1B00
		[DebuggerNonUserCode]
		public bool HasOSI
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x002A391D File Offset: 0x002A1B1D
		[DebuggerNonUserCode]
		public void ClearOSI()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600AD70 RID: 44400 RVA: 0x002A3930 File Offset: 0x002A1B30
		// (set) Token: 0x0600AD71 RID: 44401 RVA: 0x002A3951 File Offset: 0x002A1B51
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? LobbyRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600AD72 RID: 44402 RVA: 0x002A3968 File Offset: 0x002A1B68
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x002A3983 File Offset: 0x002A1B83
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600AD74 RID: 44404 RVA: 0x002A3990 File Offset: 0x002A1B90
		// (set) Token: 0x0600AD75 RID: 44405 RVA: 0x002A39B1 File Offset: 0x002A1BB1
		[DebuggerNonUserCode]
		public string BaseKey
		{
			get
			{
				return this.baseKey_ ?? LobbyRequest.BaseKeyDefaultValue;
			}
			set
			{
				this.baseKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0600AD76 RID: 44406 RVA: 0x002A39C8 File Offset: 0x002A1BC8
		[DebuggerNonUserCode]
		public bool HasBaseKey
		{
			get
			{
				return this.baseKey_ != null;
			}
		}

		// Token: 0x0600AD77 RID: 44407 RVA: 0x002A39E3 File Offset: 0x002A1BE3
		[DebuggerNonUserCode]
		public void ClearBaseKey()
		{
			this.baseKey_ = null;
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600AD78 RID: 44408 RVA: 0x002A39F0 File Offset: 0x002A1BF0
		// (set) Token: 0x0600AD79 RID: 44409 RVA: 0x002A3A21 File Offset: 0x002A1C21
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
					thirty100DefaultValue = LobbyRequest.Thirty100DefaultValue;
				}
				return thirty100DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.thirty100_ = value;
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600AD7A RID: 44410 RVA: 0x002A3A3C File Offset: 0x002A1C3C
		[DebuggerNonUserCode]
		public bool HasThirty100
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x002A3A59 File Offset: 0x002A1C59
		[DebuggerNonUserCode]
		public void ClearThirty100()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600AD7C RID: 44412 RVA: 0x002A3A6C File Offset: 0x002A1C6C
		// (set) Token: 0x0600AD7D RID: 44413 RVA: 0x002A3A9D File Offset: 0x002A1C9D
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
					wn64DefaultValue = LobbyRequest.Wn64DefaultValue;
				}
				return wn64DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.wn64_ = value;
			}
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600AD7E RID: 44414 RVA: 0x002A3AB8 File Offset: 0x002A1CB8
		[DebuggerNonUserCode]
		public bool HasWn64
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AD7F RID: 44415 RVA: 0x002A3AD5 File Offset: 0x002A1CD5
		[DebuggerNonUserCode]
		public void ClearWn64()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600AD80 RID: 44416 RVA: 0x002A3AE8 File Offset: 0x002A1CE8
		// (set) Token: 0x0600AD81 RID: 44417 RVA: 0x002A3B19 File Offset: 0x002A1D19
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
					oneDefaultValue = LobbyRequest.OneDefaultValue;
				}
				return oneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.one_ = value;
			}
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600AD82 RID: 44418 RVA: 0x002A3B34 File Offset: 0x002A1D34
		[DebuggerNonUserCode]
		public bool HasOne
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AD83 RID: 44419 RVA: 0x002A3B51 File Offset: 0x002A1D51
		[DebuggerNonUserCode]
		public void ClearOne()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600AD84 RID: 44420 RVA: 0x002A3B64 File Offset: 0x002A1D64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyRequest);
		}

		// Token: 0x0600AD85 RID: 44421 RVA: 0x002A3B84 File Offset: 0x002A1D84
		[DebuggerNonUserCode]
		public bool Equals(LobbyRequest other)
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

		// Token: 0x0600AD86 RID: 44422 RVA: 0x002A3C8C File Offset: 0x002A1E8C
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

		// Token: 0x0600AD87 RID: 44423 RVA: 0x002A3D80 File Offset: 0x002A1F80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD88 RID: 44424 RVA: 0x002A3D98 File Offset: 0x002A1F98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x002A3DA4 File Offset: 0x002A1FA4
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

		// Token: 0x0600AD8A RID: 44426 RVA: 0x002A3EC4 File Offset: 0x002A20C4
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

		// Token: 0x0600AD8B RID: 44427 RVA: 0x002A3FC8 File Offset: 0x002A21C8
		[DebuggerNonUserCode]
		public void MergeFrom(LobbyRequest other)
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

		// Token: 0x0600AD8C RID: 44428 RVA: 0x002A40B2 File Offset: 0x002A22B2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x002A40C0 File Offset: 0x002A22C0
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

		// Token: 0x04004E19 RID: 19993
		private static readonly MessageParser<LobbyRequest> _parser = new MessageParser<LobbyRequest>(() => new LobbyRequest());

		// Token: 0x04004E1A RID: 19994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E1B RID: 19995
		private int _hasBits0;

		// Token: 0x04004E1C RID: 19996
		public const int KeyFieldNumber = 1;

		// Token: 0x04004E1D RID: 19997
		private static readonly string KeyDefaultValue = "";

		// Token: 0x04004E1E RID: 19998
		private string key_;

		// Token: 0x04004E1F RID: 19999
		public const int OSIFieldNumber = 3;

		// Token: 0x04004E20 RID: 20000
		private static readonly int OSIDefaultValue = 0;

		// Token: 0x04004E21 RID: 20001
		private int oSI_;

		// Token: 0x04004E22 RID: 20002
		public const int VersionFieldNumber = 4;

		// Token: 0x04004E23 RID: 20003
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004E24 RID: 20004
		private string version_;

		// Token: 0x04004E25 RID: 20005
		public const int BaseKeyFieldNumber = 5;

		// Token: 0x04004E26 RID: 20006
		private static readonly string BaseKeyDefaultValue = "";

		// Token: 0x04004E27 RID: 20007
		private string baseKey_;

		// Token: 0x04004E28 RID: 20008
		public const int Thirty100FieldNumber = 6;

		// Token: 0x04004E29 RID: 20009
		private static readonly int Thirty100DefaultValue = 0;

		// Token: 0x04004E2A RID: 20010
		private int thirty100_;

		// Token: 0x04004E2B RID: 20011
		public const int Wn64FieldNumber = 7;

		// Token: 0x04004E2C RID: 20012
		private static readonly int Wn64DefaultValue = 0;

		// Token: 0x04004E2D RID: 20013
		private int wn64_;

		// Token: 0x04004E2E RID: 20014
		public const int OneFieldNumber = 8;

		// Token: 0x04004E2F RID: 20015
		private static readonly int OneDefaultValue = 0;

		// Token: 0x04004E30 RID: 20016
		private int one_;
	}
}
