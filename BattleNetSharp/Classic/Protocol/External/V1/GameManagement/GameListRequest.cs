using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000791 RID: 1937
	public sealed class GameListRequest : IMessage<GameListRequest>, IMessage, IEquatable<GameListRequest>, IDeepCloneable<GameListRequest>, IBufferMessage
	{
		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600B1A1 RID: 45473 RVA: 0x002B3B38 File Offset: 0x002B1D38
		[DebuggerNonUserCode]
		public static MessageParser<GameListRequest> Parser
		{
			get
			{
				return GameListRequest._parser;
			}
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x002B3B50 File Offset: 0x002B1D50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600B1A3 RID: 45475 RVA: 0x002B3B74 File Offset: 0x002B1D74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameListRequest.Descriptor;
			}
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x002B3B8B File Offset: 0x002B1D8B
		[DebuggerNonUserCode]
		public GameListRequest()
		{
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x002B3BA0 File Offset: 0x002B1DA0
		[DebuggerNonUserCode]
		public GameListRequest(GameListRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.charId_ = other.charId_;
			this.unkzero_ = other.unkzero_;
			this.emptystring_ = other.emptystring_;
			this.xF28_ = other.xF28_;
			this.level_ = other.level_;
			this.region_ = other.region_;
			this.difficulty_ = other.difficulty_;
			this.x0_ = other.x0_;
			this.pings_ = other.pings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x002B3C44 File Offset: 0x002B1E44
		[DebuggerNonUserCode]
		public GameListRequest Clone()
		{
			return new GameListRequest(this);
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600B1A7 RID: 45479 RVA: 0x002B3C5C File Offset: 0x002B1E5C
		// (set) Token: 0x0600B1A8 RID: 45480 RVA: 0x002B3C8D File Offset: 0x002B1E8D
		[DebuggerNonUserCode]
		public uint CharId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint charIdDefaultValue;
				if (flag)
				{
					charIdDefaultValue = this.charId_;
				}
				else
				{
					charIdDefaultValue = GameListRequest.CharIdDefaultValue;
				}
				return charIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.charId_ = value;
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600B1A9 RID: 45481 RVA: 0x002B3CA8 File Offset: 0x002B1EA8
		[DebuggerNonUserCode]
		public bool HasCharId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x002B3CC5 File Offset: 0x002B1EC5
		[DebuggerNonUserCode]
		public void ClearCharId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600B1AB RID: 45483 RVA: 0x002B3CD8 File Offset: 0x002B1ED8
		// (set) Token: 0x0600B1AC RID: 45484 RVA: 0x002B3D09 File Offset: 0x002B1F09
		[DebuggerNonUserCode]
		public uint Unkzero
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint unkzeroDefaultValue;
				if (flag)
				{
					unkzeroDefaultValue = this.unkzero_;
				}
				else
				{
					unkzeroDefaultValue = GameListRequest.UnkzeroDefaultValue;
				}
				return unkzeroDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.unkzero_ = value;
			}
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600B1AD RID: 45485 RVA: 0x002B3D24 File Offset: 0x002B1F24
		[DebuggerNonUserCode]
		public bool HasUnkzero
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x002B3D41 File Offset: 0x002B1F41
		[DebuggerNonUserCode]
		public void ClearUnkzero()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600B1AF RID: 45487 RVA: 0x002B3D54 File Offset: 0x002B1F54
		// (set) Token: 0x0600B1B0 RID: 45488 RVA: 0x002B3D75 File Offset: 0x002B1F75
		[DebuggerNonUserCode]
		public string Emptystring
		{
			get
			{
				return this.emptystring_ ?? GameListRequest.EmptystringDefaultValue;
			}
			set
			{
				this.emptystring_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600B1B1 RID: 45489 RVA: 0x002B3D8C File Offset: 0x002B1F8C
		[DebuggerNonUserCode]
		public bool HasEmptystring
		{
			get
			{
				return this.emptystring_ != null;
			}
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x002B3DA7 File Offset: 0x002B1FA7
		[DebuggerNonUserCode]
		public void ClearEmptystring()
		{
			this.emptystring_ = null;
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600B1B3 RID: 45491 RVA: 0x002B3DB4 File Offset: 0x002B1FB4
		// (set) Token: 0x0600B1B4 RID: 45492 RVA: 0x002B3DE5 File Offset: 0x002B1FE5
		[DebuggerNonUserCode]
		public uint XF28
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint xf28DefaultValue;
				if (flag)
				{
					xf28DefaultValue = this.xF28_;
				}
				else
				{
					xf28DefaultValue = GameListRequest.XF28DefaultValue;
				}
				return xf28DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.xF28_ = value;
			}
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600B1B5 RID: 45493 RVA: 0x002B3E00 File Offset: 0x002B2000
		[DebuggerNonUserCode]
		public bool HasXF28
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x002B3E1D File Offset: 0x002B201D
		[DebuggerNonUserCode]
		public void ClearXF28()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600B1B7 RID: 45495 RVA: 0x002B3E30 File Offset: 0x002B2030
		// (set) Token: 0x0600B1B8 RID: 45496 RVA: 0x002B3E61 File Offset: 0x002B2061
		[DebuggerNonUserCode]
		public uint Level
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint levelDefaultValue;
				if (flag)
				{
					levelDefaultValue = this.level_;
				}
				else
				{
					levelDefaultValue = GameListRequest.LevelDefaultValue;
				}
				return levelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.level_ = value;
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600B1B9 RID: 45497 RVA: 0x002B3E7C File Offset: 0x002B207C
		[DebuggerNonUserCode]
		public bool HasLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x002B3E99 File Offset: 0x002B2099
		[DebuggerNonUserCode]
		public void ClearLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600B1BB RID: 45499 RVA: 0x002B3EAC File Offset: 0x002B20AC
		// (set) Token: 0x0600B1BC RID: 45500 RVA: 0x002B3ECD File Offset: 0x002B20CD
		[DebuggerNonUserCode]
		public string Region
		{
			get
			{
				return this.region_ ?? GameListRequest.RegionDefaultValue;
			}
			set
			{
				this.region_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600B1BD RID: 45501 RVA: 0x002B3EE4 File Offset: 0x002B20E4
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return this.region_ != null;
			}
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x002B3EFF File Offset: 0x002B20FF
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this.region_ = null;
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600B1BF RID: 45503 RVA: 0x002B3F0C File Offset: 0x002B210C
		// (set) Token: 0x0600B1C0 RID: 45504 RVA: 0x002B3F3E File Offset: 0x002B213E
		[DebuggerNonUserCode]
		public uint Difficulty
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint difficultyDefaultValue;
				if (flag)
				{
					difficultyDefaultValue = this.difficulty_;
				}
				else
				{
					difficultyDefaultValue = GameListRequest.DifficultyDefaultValue;
				}
				return difficultyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.difficulty_ = value;
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600B1C1 RID: 45505 RVA: 0x002B3F58 File Offset: 0x002B2158
		[DebuggerNonUserCode]
		public bool HasDifficulty
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x002B3F76 File Offset: 0x002B2176
		[DebuggerNonUserCode]
		public void ClearDifficulty()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600B1C3 RID: 45507 RVA: 0x002B3F88 File Offset: 0x002B2188
		// (set) Token: 0x0600B1C4 RID: 45508 RVA: 0x002B3FBA File Offset: 0x002B21BA
		[DebuggerNonUserCode]
		public uint X0
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint x0DefaultValue;
				if (flag)
				{
					x0DefaultValue = this.x0_;
				}
				else
				{
					x0DefaultValue = GameListRequest.X0DefaultValue;
				}
				return x0DefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.x0_ = value;
			}
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600B1C5 RID: 45509 RVA: 0x002B3FD4 File Offset: 0x002B21D4
		[DebuggerNonUserCode]
		public bool HasX0
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x002B3FF2 File Offset: 0x002B21F2
		[DebuggerNonUserCode]
		public void ClearX0()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600B1C7 RID: 45511 RVA: 0x002B4004 File Offset: 0x002B2204
		[DebuggerNonUserCode]
		public RepeatedField<GameServerPing> Pings
		{
			get
			{
				return this.pings_;
			}
		}

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x002B401C File Offset: 0x002B221C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameListRequest);
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x002B403C File Offset: 0x002B223C
		[DebuggerNonUserCode]
		public bool Equals(GameListRequest other)
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
					bool flag4 = this.CharId != other.CharId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Unkzero != other.Unkzero;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Emptystring != other.Emptystring;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.XF28 != other.XF28;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Level != other.Level;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Region != other.Region;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Difficulty != other.Difficulty;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.X0 != other.X0;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.pings_.Equals(other.pings_);
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x0600B1CA RID: 45514 RVA: 0x002B4184 File Offset: 0x002B2384
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				num ^= this.CharId.GetHashCode();
			}
			bool hasUnkzero = this.HasUnkzero;
			if (hasUnkzero)
			{
				num ^= this.Unkzero.GetHashCode();
			}
			bool hasEmptystring = this.HasEmptystring;
			if (hasEmptystring)
			{
				num ^= this.Emptystring.GetHashCode();
			}
			bool hasXF = this.HasXF28;
			if (hasXF)
			{
				num ^= this.XF28.GetHashCode();
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num ^= this.Level.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				num ^= this.Difficulty.GetHashCode();
			}
			bool hasX = this.HasX0;
			if (hasX)
			{
				num ^= this.X0.GetHashCode();
			}
			num ^= this.pings_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x002B42A8 File Offset: 0x002B24A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x002B42C0 File Offset: 0x002B24C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x002B42CC File Offset: 0x002B24CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CharId);
			}
			bool hasUnkzero = this.HasUnkzero;
			if (hasUnkzero)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Unkzero);
			}
			bool hasEmptystring = this.HasEmptystring;
			if (hasEmptystring)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Emptystring);
			}
			bool hasXF = this.HasXF28;
			if (hasXF)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.XF28);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Level);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Region);
			}
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Difficulty);
			}
			bool hasX = this.HasX0;
			if (hasX)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.X0);
			}
			this.pings_.WriteTo(ref output, GameListRequest._repeated_pings_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x002B4424 File Offset: 0x002B2624
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCharId = this.HasCharId;
			if (hasCharId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharId);
			}
			bool hasUnkzero = this.HasUnkzero;
			if (hasUnkzero)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unkzero);
			}
			bool hasEmptystring = this.HasEmptystring;
			if (hasEmptystring)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Emptystring);
			}
			bool hasXF = this.HasXF28;
			if (hasXF)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.XF28);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Region);
			}
			bool hasDifficulty = this.HasDifficulty;
			if (hasDifficulty)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Difficulty);
			}
			bool hasX = this.HasX0;
			if (hasX)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.X0);
			}
			num += this.pings_.CalculateSize(GameListRequest._repeated_pings_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1CF RID: 45519 RVA: 0x002B4558 File Offset: 0x002B2758
		[DebuggerNonUserCode]
		public void MergeFrom(GameListRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCharId = other.HasCharId;
				if (hasCharId)
				{
					this.CharId = other.CharId;
				}
				bool hasUnkzero = other.HasUnkzero;
				if (hasUnkzero)
				{
					this.Unkzero = other.Unkzero;
				}
				bool hasEmptystring = other.HasEmptystring;
				if (hasEmptystring)
				{
					this.Emptystring = other.Emptystring;
				}
				bool hasXF = other.HasXF28;
				if (hasXF)
				{
					this.XF28 = other.XF28;
				}
				bool hasLevel = other.HasLevel;
				if (hasLevel)
				{
					this.Level = other.Level;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				bool hasDifficulty = other.HasDifficulty;
				if (hasDifficulty)
				{
					this.Difficulty = other.Difficulty;
				}
				bool hasX = other.HasX0;
				if (hasX)
				{
					this.X0 = other.X0;
				}
				this.pings_.Add(other.pings_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x002B466F File Offset: 0x002B286F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x002B467C File Offset: 0x002B287C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006A;
							}
							this.Unkzero = input.ReadUInt32();
						}
						else
						{
							this.CharId = input.ReadUInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							goto IL_006A;
						}
						this.XF28 = input.ReadUInt32();
					}
					else
					{
						this.Emptystring = input.ReadString();
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_006A;
						}
						this.Region = input.ReadString();
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						if (num3 != 74U)
						{
							goto IL_006A;
						}
						this.pings_.AddEntriesFrom(ref input, GameListRequest._repeated_pings_codec);
					}
					else
					{
						this.X0 = input.ReadUInt32();
					}
				}
				else
				{
					this.Difficulty = input.ReadUInt32();
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400501E RID: 20510
		private static readonly MessageParser<GameListRequest> _parser = new MessageParser<GameListRequest>(() => new GameListRequest());

		// Token: 0x0400501F RID: 20511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005020 RID: 20512
		private int _hasBits0;

		// Token: 0x04005021 RID: 20513
		public const int CharIdFieldNumber = 1;

		// Token: 0x04005022 RID: 20514
		private static readonly uint CharIdDefaultValue = 0U;

		// Token: 0x04005023 RID: 20515
		private uint charId_;

		// Token: 0x04005024 RID: 20516
		public const int UnkzeroFieldNumber = 2;

		// Token: 0x04005025 RID: 20517
		private static readonly uint UnkzeroDefaultValue = 0U;

		// Token: 0x04005026 RID: 20518
		private uint unkzero_;

		// Token: 0x04005027 RID: 20519
		public const int EmptystringFieldNumber = 3;

		// Token: 0x04005028 RID: 20520
		private static readonly string EmptystringDefaultValue = "";

		// Token: 0x04005029 RID: 20521
		private string emptystring_;

		// Token: 0x0400502A RID: 20522
		public const int XF28FieldNumber = 4;

		// Token: 0x0400502B RID: 20523
		private static readonly uint XF28DefaultValue = 0U;

		// Token: 0x0400502C RID: 20524
		private uint xF28_;

		// Token: 0x0400502D RID: 20525
		public const int LevelFieldNumber = 5;

		// Token: 0x0400502E RID: 20526
		private static readonly uint LevelDefaultValue = 0U;

		// Token: 0x0400502F RID: 20527
		private uint level_;

		// Token: 0x04005030 RID: 20528
		public const int RegionFieldNumber = 6;

		// Token: 0x04005031 RID: 20529
		private static readonly string RegionDefaultValue = "";

		// Token: 0x04005032 RID: 20530
		private string region_;

		// Token: 0x04005033 RID: 20531
		public const int DifficultyFieldNumber = 7;

		// Token: 0x04005034 RID: 20532
		private static readonly uint DifficultyDefaultValue = 0U;

		// Token: 0x04005035 RID: 20533
		private uint difficulty_;

		// Token: 0x04005036 RID: 20534
		public const int X0FieldNumber = 8;

		// Token: 0x04005037 RID: 20535
		private static readonly uint X0DefaultValue = 0U;

		// Token: 0x04005038 RID: 20536
		private uint x0_;

		// Token: 0x04005039 RID: 20537
		public const int PingsFieldNumber = 9;

		// Token: 0x0400503A RID: 20538
		private static readonly FieldCodec<GameServerPing> _repeated_pings_codec = FieldCodec.ForMessage<GameServerPing>(74U, GameServerPing.Parser);

		// Token: 0x0400503B RID: 20539
		private readonly RepeatedField<GameServerPing> pings_ = new RepeatedField<GameServerPing>();
	}
}
