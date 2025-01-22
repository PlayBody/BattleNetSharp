using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A8 RID: 168
	public sealed class ServerBrowserPlayerData : IMessage<ServerBrowserPlayerData>, IMessage, IEquatable<ServerBrowserPlayerData>, IDeepCloneable<ServerBrowserPlayerData>, IBufferMessage
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00038864 File Offset: 0x00036A64
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserPlayerData> Parser
		{
			get
			{
				return ServerBrowserPlayerData._parser;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0003887C File Offset: 0x00036A7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[145];
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000388A4 File Offset: 0x00036AA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserPlayerData.Descriptor;
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000388BB File Offset: 0x00036ABB
		[DebuggerNonUserCode]
		public ServerBrowserPlayerData()
		{
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000388C8 File Offset: 0x00036AC8
		[DebuggerNonUserCode]
		public ServerBrowserPlayerData(ServerBrowserPlayerData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameId_ = other.gameId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.heroName_ = other.heroName_;
			this.heroId_ = other.heroId_;
			this.partyId_ = other.partyId_;
			this.acdid_ = other.acdid_;
			this.nonAuthoritative_ = other.nonAuthoritative_;
			this.worldPlace_ = ((other.worldPlace_ != null) ? other.worldPlace_.Clone() : null);
			this.commandFrameAdjusted_ = other.commandFrameAdjusted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00038978 File Offset: 0x00036B78
		[DebuggerNonUserCode]
		public ServerBrowserPlayerData Clone()
		{
			return new ServerBrowserPlayerData(this);
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00038990 File Offset: 0x00036B90
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x000389C1 File Offset: 0x00036BC1
		[DebuggerNonUserCode]
		public uint GameId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameIdDefaultValue;
				if (flag)
				{
					gameIdDefaultValue = this.gameId_;
				}
				else
				{
					gameIdDefaultValue = ServerBrowserPlayerData.GameIdDefaultValue;
				}
				return gameIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameId_ = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000389DC File Offset: 0x00036BDC
		[DebuggerNonUserCode]
		public bool HasGameId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000389F9 File Offset: 0x00036BF9
		[DebuggerNonUserCode]
		public void ClearGameId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00038A0C File Offset: 0x00036C0C
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00038A3D File Offset: 0x00036C3D
		[DebuggerNonUserCode]
		public ulong GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = ServerBrowserPlayerData.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00038A58 File Offset: 0x00036C58
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00038A75 File Offset: 0x00036C75
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00038A88 File Offset: 0x00036C88
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00038AA9 File Offset: 0x00036CA9
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? ServerBrowserPlayerData.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x00038AC0 File Offset: 0x00036CC0
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00038ADB File Offset: 0x00036CDB
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00038AE8 File Offset: 0x00036CE8
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00038B09 File Offset: 0x00036D09
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? ServerBrowserPlayerData.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00038B20 File Offset: 0x00036D20
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00038B3B File Offset: 0x00036D3B
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00038B48 File Offset: 0x00036D48
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00038B69 File Offset: 0x00036D69
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? ServerBrowserPlayerData.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00038B80 File Offset: 0x00036D80
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00038B9B File Offset: 0x00036D9B
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00038BA8 File Offset: 0x00036DA8
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00038BD9 File Offset: 0x00036DD9
		[DebuggerNonUserCode]
		public uint Acdid
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint acdidDefaultValue;
				if (flag)
				{
					acdidDefaultValue = this.acdid_;
				}
				else
				{
					acdidDefaultValue = ServerBrowserPlayerData.AcdidDefaultValue;
				}
				return acdidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.acdid_ = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00038BF4 File Offset: 0x00036DF4
		[DebuggerNonUserCode]
		public bool HasAcdid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00038C11 File Offset: 0x00036E11
		[DebuggerNonUserCode]
		public void ClearAcdid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00038C24 File Offset: 0x00036E24
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00038C55 File Offset: 0x00036E55
		[DebuggerNonUserCode]
		public bool NonAuthoritative
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool nonAuthoritativeDefaultValue;
				if (flag)
				{
					nonAuthoritativeDefaultValue = this.nonAuthoritative_;
				}
				else
				{
					nonAuthoritativeDefaultValue = ServerBrowserPlayerData.NonAuthoritativeDefaultValue;
				}
				return nonAuthoritativeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.nonAuthoritative_ = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00038C70 File Offset: 0x00036E70
		[DebuggerNonUserCode]
		public bool HasNonAuthoritative
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00038C8D File Offset: 0x00036E8D
		[DebuggerNonUserCode]
		public void ClearNonAuthoritative()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00038CA0 File Offset: 0x00036EA0
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00038CB8 File Offset: 0x00036EB8
		[DebuggerNonUserCode]
		public ServerBrowserWorldPlace WorldPlace
		{
			get
			{
				return this.worldPlace_;
			}
			set
			{
				this.worldPlace_ = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00038CC4 File Offset: 0x00036EC4
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00038CF6 File Offset: 0x00036EF6
		[DebuggerNonUserCode]
		public uint CommandFrameAdjusted
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint commandFrameAdjustedDefaultValue;
				if (flag)
				{
					commandFrameAdjustedDefaultValue = this.commandFrameAdjusted_;
				}
				else
				{
					commandFrameAdjustedDefaultValue = ServerBrowserPlayerData.CommandFrameAdjustedDefaultValue;
				}
				return commandFrameAdjustedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.commandFrameAdjusted_ = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00038D10 File Offset: 0x00036F10
		[DebuggerNonUserCode]
		public bool HasCommandFrameAdjusted
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00038D2E File Offset: 0x00036F2E
		[DebuggerNonUserCode]
		public void ClearCommandFrameAdjusted()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00038D40 File Offset: 0x00036F40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserPlayerData);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00038D60 File Offset: 0x00036F60
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserPlayerData other)
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
					bool flag4 = this.GameId != other.GameId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountId != other.GameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HeroName != other.HeroName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.HeroId != other.HeroId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.PartyId != other.PartyId;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Acdid != other.Acdid;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.NonAuthoritative != other.NonAuthoritative;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.WorldPlace, other.WorldPlace);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.CommandFrameAdjusted != other.CommandFrameAdjusted;
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

		// Token: 0x06000F77 RID: 3959 RVA: 0x00038EA8 File Offset: 0x000370A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num ^= this.GameId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasAcdid = this.HasAcdid;
			if (hasAcdid)
			{
				num ^= this.Acdid.GetHashCode();
			}
			bool hasNonAuthoritative = this.HasNonAuthoritative;
			if (hasNonAuthoritative)
			{
				num ^= this.NonAuthoritative.GetHashCode();
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num ^= this.WorldPlace.GetHashCode();
			}
			bool hasCommandFrameAdjusted = this.HasCommandFrameAdjusted;
			if (hasCommandFrameAdjusted)
			{
				num ^= this.CommandFrameAdjusted.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00038FD8 File Offset: 0x000371D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00038FF0 File Offset: 0x000371F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00038FFC File Offset: 0x000371FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.GameAccountId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.HeroName);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(34);
				output.WriteString(this.HeroId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(42);
				output.WriteString(this.PartyId);
			}
			bool hasAcdid = this.HasAcdid;
			if (hasAcdid)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Acdid);
			}
			bool hasNonAuthoritative = this.HasNonAuthoritative;
			if (hasNonAuthoritative)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.NonAuthoritative);
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.WorldPlace);
			}
			bool hasCommandFrameAdjusted = this.HasCommandFrameAdjusted;
			if (hasCommandFrameAdjusted)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CommandFrameAdjusted);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00039168 File Offset: 0x00037368
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GameAccountId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasAcdid = this.HasAcdid;
			if (hasAcdid)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Acdid);
			}
			bool hasNonAuthoritative = this.HasNonAuthoritative;
			if (hasNonAuthoritative)
			{
				num += 2;
			}
			bool flag = this.worldPlace_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WorldPlace);
			}
			bool hasCommandFrameAdjusted = this.HasCommandFrameAdjusted;
			if (hasCommandFrameAdjusted)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CommandFrameAdjusted);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000392A0 File Offset: 0x000374A0
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserPlayerData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameId = other.HasGameId;
				if (hasGameId)
				{
					this.GameId = other.GameId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasAcdid = other.HasAcdid;
				if (hasAcdid)
				{
					this.Acdid = other.Acdid;
				}
				bool hasNonAuthoritative = other.HasNonAuthoritative;
				if (hasNonAuthoritative)
				{
					this.NonAuthoritative = other.NonAuthoritative;
				}
				bool flag2 = other.worldPlace_ != null;
				if (flag2)
				{
					bool flag3 = this.worldPlace_ == null;
					if (flag3)
					{
						this.WorldPlace = new ServerBrowserWorldPlace();
					}
					this.WorldPlace.MergeFrom(other.WorldPlace);
				}
				bool hasCommandFrameAdjusted = other.HasCommandFrameAdjusted;
				if (hasCommandFrameAdjusted)
				{
					this.CommandFrameAdjusted = other.CommandFrameAdjusted;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000393E5 File Offset: 0x000375E5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000393F0 File Offset: 0x000375F0
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
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006D;
							}
							this.GameAccountId = input.ReadUInt64();
						}
						else
						{
							this.GameId = input.ReadUInt32();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_006D;
						}
						this.HeroId = input.ReadString();
					}
					else
					{
						this.HeroName = input.ReadString();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_006D;
						}
						this.Acdid = input.ReadUInt32();
					}
					else
					{
						this.PartyId = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						if (num3 != 72U)
						{
							goto IL_006D;
						}
						this.CommandFrameAdjusted = input.ReadUInt32();
					}
					else
					{
						bool flag = this.worldPlace_ == null;
						if (flag)
						{
							this.WorldPlace = new ServerBrowserWorldPlace();
						}
						input.ReadMessage(this.WorldPlace);
					}
				}
				else
				{
					this.NonAuthoritative = input.ReadBool();
				}
				continue;
				IL_006D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400060A RID: 1546
		private static readonly MessageParser<ServerBrowserPlayerData> _parser = new MessageParser<ServerBrowserPlayerData>(() => new ServerBrowserPlayerData());

		// Token: 0x0400060B RID: 1547
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400060C RID: 1548
		private int _hasBits0;

		// Token: 0x0400060D RID: 1549
		public const int GameIdFieldNumber = 1;

		// Token: 0x0400060E RID: 1550
		private static readonly uint GameIdDefaultValue = 0U;

		// Token: 0x0400060F RID: 1551
		private uint gameId_;

		// Token: 0x04000610 RID: 1552
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04000611 RID: 1553
		private static readonly ulong GameAccountIdDefaultValue = 0UL;

		// Token: 0x04000612 RID: 1554
		private ulong gameAccountId_;

		// Token: 0x04000613 RID: 1555
		public const int HeroNameFieldNumber = 3;

		// Token: 0x04000614 RID: 1556
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x04000615 RID: 1557
		private string heroName_;

		// Token: 0x04000616 RID: 1558
		public const int HeroIdFieldNumber = 4;

		// Token: 0x04000617 RID: 1559
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04000618 RID: 1560
		private string heroId_;

		// Token: 0x04000619 RID: 1561
		public const int PartyIdFieldNumber = 5;

		// Token: 0x0400061A RID: 1562
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x0400061B RID: 1563
		private string partyId_;

		// Token: 0x0400061C RID: 1564
		public const int AcdidFieldNumber = 6;

		// Token: 0x0400061D RID: 1565
		private static readonly uint AcdidDefaultValue = 0U;

		// Token: 0x0400061E RID: 1566
		private uint acdid_;

		// Token: 0x0400061F RID: 1567
		public const int NonAuthoritativeFieldNumber = 7;

		// Token: 0x04000620 RID: 1568
		private static readonly bool NonAuthoritativeDefaultValue = false;

		// Token: 0x04000621 RID: 1569
		private bool nonAuthoritative_;

		// Token: 0x04000622 RID: 1570
		public const int WorldPlaceFieldNumber = 8;

		// Token: 0x04000623 RID: 1571
		private ServerBrowserWorldPlace worldPlace_;

		// Token: 0x04000624 RID: 1572
		public const int CommandFrameAdjustedFieldNumber = 9;

		// Token: 0x04000625 RID: 1573
		private static readonly uint CommandFrameAdjustedDefaultValue = 0U;

		// Token: 0x04000626 RID: 1574
		private uint commandFrameAdjusted_;
	}
}
