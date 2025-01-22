using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000795 RID: 1941
	public sealed class GameDetailResponse : IMessage<GameDetailResponse>, IMessage, IEquatable<GameDetailResponse>, IDeepCloneable<GameDetailResponse>, IBufferMessage
	{
		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600B24E RID: 45646 RVA: 0x002B64E8 File Offset: 0x002B46E8
		[DebuggerNonUserCode]
		public static MessageParser<GameDetailResponse> Parser
		{
			get
			{
				return GameDetailResponse._parser;
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600B24F RID: 45647 RVA: 0x002B6500 File Offset: 0x002B4700
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600B250 RID: 45648 RVA: 0x002B6524 File Offset: 0x002B4724
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameDetailResponse.Descriptor;
			}
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x002B653B File Offset: 0x002B473B
		[DebuggerNonUserCode]
		public GameDetailResponse()
		{
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x002B6550 File Offset: 0x002B4750
		[DebuggerNonUserCode]
		public GameDetailResponse(GameDetailResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameName_ = other.gameName_;
			this.gameDescription_ = other.gameDescription_;
			this.flags_ = other.flags_;
			this.time_ = other.time_;
			this.empty_ = other.empty_;
			this.charLevel_ = other.charLevel_;
			this.levelDifference_ = other.levelDifference_;
			this.maxPlayers_ = other.maxPlayers_;
			this.gamePlayers_ = other.gamePlayers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x002B65F4 File Offset: 0x002B47F4
		[DebuggerNonUserCode]
		public GameDetailResponse Clone()
		{
			return new GameDetailResponse(this);
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600B254 RID: 45652 RVA: 0x002B660C File Offset: 0x002B480C
		// (set) Token: 0x0600B255 RID: 45653 RVA: 0x002B662D File Offset: 0x002B482D
		[DebuggerNonUserCode]
		public string GameName
		{
			get
			{
				return this.gameName_ ?? GameDetailResponse.GameNameDefaultValue;
			}
			set
			{
				this.gameName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600B256 RID: 45654 RVA: 0x002B6644 File Offset: 0x002B4844
		[DebuggerNonUserCode]
		public bool HasGameName
		{
			get
			{
				return this.gameName_ != null;
			}
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x002B665F File Offset: 0x002B485F
		[DebuggerNonUserCode]
		public void ClearGameName()
		{
			this.gameName_ = null;
		}

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600B258 RID: 45656 RVA: 0x002B666C File Offset: 0x002B486C
		// (set) Token: 0x0600B259 RID: 45657 RVA: 0x002B668D File Offset: 0x002B488D
		[DebuggerNonUserCode]
		public string GameDescription
		{
			get
			{
				return this.gameDescription_ ?? GameDetailResponse.GameDescriptionDefaultValue;
			}
			set
			{
				this.gameDescription_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x002B66A4 File Offset: 0x002B48A4
		[DebuggerNonUserCode]
		public bool HasGameDescription
		{
			get
			{
				return this.gameDescription_ != null;
			}
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x002B66BF File Offset: 0x002B48BF
		[DebuggerNonUserCode]
		public void ClearGameDescription()
		{
			this.gameDescription_ = null;
		}

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600B25C RID: 45660 RVA: 0x002B66CC File Offset: 0x002B48CC
		// (set) Token: 0x0600B25D RID: 45661 RVA: 0x002B66FD File Offset: 0x002B48FD
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = GameDetailResponse.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.flags_ = value;
			}
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600B25E RID: 45662 RVA: 0x002B6718 File Offset: 0x002B4918
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B25F RID: 45663 RVA: 0x002B6735 File Offset: 0x002B4935
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600B260 RID: 45664 RVA: 0x002B6748 File Offset: 0x002B4948
		// (set) Token: 0x0600B261 RID: 45665 RVA: 0x002B6779 File Offset: 0x002B4979
		[DebuggerNonUserCode]
		public uint Time
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint timeDefaultValue;
				if (flag)
				{
					timeDefaultValue = this.time_;
				}
				else
				{
					timeDefaultValue = GameDetailResponse.TimeDefaultValue;
				}
				return timeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.time_ = value;
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600B262 RID: 45666 RVA: 0x002B6794 File Offset: 0x002B4994
		[DebuggerNonUserCode]
		public bool HasTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x002B67B1 File Offset: 0x002B49B1
		[DebuggerNonUserCode]
		public void ClearTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600B264 RID: 45668 RVA: 0x002B67C4 File Offset: 0x002B49C4
		// (set) Token: 0x0600B265 RID: 45669 RVA: 0x002B67E5 File Offset: 0x002B49E5
		[DebuggerNonUserCode]
		public string Empty
		{
			get
			{
				return this.empty_ ?? GameDetailResponse.EmptyDefaultValue;
			}
			set
			{
				this.empty_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600B266 RID: 45670 RVA: 0x002B67FC File Offset: 0x002B49FC
		[DebuggerNonUserCode]
		public bool HasEmpty
		{
			get
			{
				return this.empty_ != null;
			}
		}

		// Token: 0x0600B267 RID: 45671 RVA: 0x002B6817 File Offset: 0x002B4A17
		[DebuggerNonUserCode]
		public void ClearEmpty()
		{
			this.empty_ = null;
		}

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600B268 RID: 45672 RVA: 0x002B6824 File Offset: 0x002B4A24
		// (set) Token: 0x0600B269 RID: 45673 RVA: 0x002B6855 File Offset: 0x002B4A55
		[DebuggerNonUserCode]
		public uint CharLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint charLevelDefaultValue;
				if (flag)
				{
					charLevelDefaultValue = this.charLevel_;
				}
				else
				{
					charLevelDefaultValue = GameDetailResponse.CharLevelDefaultValue;
				}
				return charLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.charLevel_ = value;
			}
		}

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600B26A RID: 45674 RVA: 0x002B6870 File Offset: 0x002B4A70
		[DebuggerNonUserCode]
		public bool HasCharLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x002B688D File Offset: 0x002B4A8D
		[DebuggerNonUserCode]
		public void ClearCharLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600B26C RID: 45676 RVA: 0x002B68A0 File Offset: 0x002B4AA0
		// (set) Token: 0x0600B26D RID: 45677 RVA: 0x002B68D1 File Offset: 0x002B4AD1
		[DebuggerNonUserCode]
		public uint LevelDifference
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint levelDifferenceDefaultValue;
				if (flag)
				{
					levelDifferenceDefaultValue = this.levelDifference_;
				}
				else
				{
					levelDifferenceDefaultValue = GameDetailResponse.LevelDifferenceDefaultValue;
				}
				return levelDifferenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.levelDifference_ = value;
			}
		}

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600B26E RID: 45678 RVA: 0x002B68EC File Offset: 0x002B4AEC
		[DebuggerNonUserCode]
		public bool HasLevelDifference
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B26F RID: 45679 RVA: 0x002B6909 File Offset: 0x002B4B09
		[DebuggerNonUserCode]
		public void ClearLevelDifference()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x002B691C File Offset: 0x002B4B1C
		// (set) Token: 0x0600B271 RID: 45681 RVA: 0x002B694E File Offset: 0x002B4B4E
		[DebuggerNonUserCode]
		public uint MaxPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint maxPlayersDefaultValue;
				if (flag)
				{
					maxPlayersDefaultValue = this.maxPlayers_;
				}
				else
				{
					maxPlayersDefaultValue = GameDetailResponse.MaxPlayersDefaultValue;
				}
				return maxPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.maxPlayers_ = value;
			}
		}

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600B272 RID: 45682 RVA: 0x002B6968 File Offset: 0x002B4B68
		[DebuggerNonUserCode]
		public bool HasMaxPlayers
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600B273 RID: 45683 RVA: 0x002B6986 File Offset: 0x002B4B86
		[DebuggerNonUserCode]
		public void ClearMaxPlayers()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600B274 RID: 45684 RVA: 0x002B6998 File Offset: 0x002B4B98
		[DebuggerNonUserCode]
		public RepeatedField<GamePlayer> GamePlayers
		{
			get
			{
				return this.gamePlayers_;
			}
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x002B69B0 File Offset: 0x002B4BB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameDetailResponse);
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x002B69D0 File Offset: 0x002B4BD0
		[DebuggerNonUserCode]
		public bool Equals(GameDetailResponse other)
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
					bool flag4 = this.GameName != other.GameName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameDescription != other.GameDescription;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Flags != other.Flags;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Time != other.Time;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Empty != other.Empty;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CharLevel != other.CharLevel;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.LevelDifference != other.LevelDifference;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.MaxPlayers != other.MaxPlayers;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.gamePlayers_.Equals(other.gamePlayers_);
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

		// Token: 0x0600B277 RID: 45687 RVA: 0x002B6B18 File Offset: 0x002B4D18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num ^= this.GameName.GetHashCode();
			}
			bool hasGameDescription = this.HasGameDescription;
			if (hasGameDescription)
			{
				num ^= this.GameDescription.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num ^= this.Time.GetHashCode();
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				num ^= this.Empty.GetHashCode();
			}
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				num ^= this.CharLevel.GetHashCode();
			}
			bool hasLevelDifference = this.HasLevelDifference;
			if (hasLevelDifference)
			{
				num ^= this.LevelDifference.GetHashCode();
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num ^= this.MaxPlayers.GetHashCode();
			}
			num ^= this.gamePlayers_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x002B6C3C File Offset: 0x002B4E3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x002B6C54 File Offset: 0x002B4E54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x002B6C60 File Offset: 0x002B4E60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.GameName);
			}
			bool hasGameDescription = this.HasGameDescription;
			if (hasGameDescription)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameDescription);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Flags);
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Time);
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Empty);
			}
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CharLevel);
			}
			bool hasLevelDifference = this.HasLevelDifference;
			if (hasLevelDifference)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LevelDifference);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.MaxPlayers);
			}
			this.gamePlayers_.WriteTo(ref output, GameDetailResponse._repeated_gamePlayers_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x002B6DB8 File Offset: 0x002B4FB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameName);
			}
			bool hasGameDescription = this.HasGameDescription;
			if (hasGameDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameDescription);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Time);
			}
			bool hasEmpty = this.HasEmpty;
			if (hasEmpty)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Empty);
			}
			bool hasCharLevel = this.HasCharLevel;
			if (hasCharLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharLevel);
			}
			bool hasLevelDifference = this.HasLevelDifference;
			if (hasLevelDifference)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelDifference);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPlayers);
			}
			num += this.gamePlayers_.CalculateSize(GameDetailResponse._repeated_gamePlayers_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x002B6EEC File Offset: 0x002B50EC
		[DebuggerNonUserCode]
		public void MergeFrom(GameDetailResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameName = other.HasGameName;
				if (hasGameName)
				{
					this.GameName = other.GameName;
				}
				bool hasGameDescription = other.HasGameDescription;
				if (hasGameDescription)
				{
					this.GameDescription = other.GameDescription;
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				bool hasTime = other.HasTime;
				if (hasTime)
				{
					this.Time = other.Time;
				}
				bool hasEmpty = other.HasEmpty;
				if (hasEmpty)
				{
					this.Empty = other.Empty;
				}
				bool hasCharLevel = other.HasCharLevel;
				if (hasCharLevel)
				{
					this.CharLevel = other.CharLevel;
				}
				bool hasLevelDifference = other.HasLevelDifference;
				if (hasLevelDifference)
				{
					this.LevelDifference = other.LevelDifference;
				}
				bool hasMaxPlayers = other.HasMaxPlayers;
				if (hasMaxPlayers)
				{
					this.MaxPlayers = other.MaxPlayers;
				}
				this.gamePlayers_.Add(other.gamePlayers_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x002B7003 File Offset: 0x002B5203
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x002B7010 File Offset: 0x002B5210
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
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_006B;
							}
							this.GameDescription = input.ReadString();
						}
						else
						{
							this.GameName = input.ReadString();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_006B;
						}
						this.Time = input.ReadUInt32();
					}
					else
					{
						this.Flags = input.ReadUInt32();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_006B;
						}
						this.CharLevel = input.ReadUInt32();
					}
					else
					{
						this.Empty = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						if (num3 != 74U)
						{
							goto IL_006B;
						}
						this.gamePlayers_.AddEntriesFrom(ref input, GameDetailResponse._repeated_gamePlayers_codec);
					}
					else
					{
						this.MaxPlayers = input.ReadUInt32();
					}
				}
				else
				{
					this.LevelDifference = input.ReadUInt32();
				}
				continue;
				IL_006B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400507A RID: 20602
		private static readonly MessageParser<GameDetailResponse> _parser = new MessageParser<GameDetailResponse>(() => new GameDetailResponse());

		// Token: 0x0400507B RID: 20603
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400507C RID: 20604
		private int _hasBits0;

		// Token: 0x0400507D RID: 20605
		public const int GameNameFieldNumber = 1;

		// Token: 0x0400507E RID: 20606
		private static readonly string GameNameDefaultValue = "";

		// Token: 0x0400507F RID: 20607
		private string gameName_;

		// Token: 0x04005080 RID: 20608
		public const int GameDescriptionFieldNumber = 2;

		// Token: 0x04005081 RID: 20609
		private static readonly string GameDescriptionDefaultValue = "";

		// Token: 0x04005082 RID: 20610
		private string gameDescription_;

		// Token: 0x04005083 RID: 20611
		public const int FlagsFieldNumber = 3;

		// Token: 0x04005084 RID: 20612
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x04005085 RID: 20613
		private uint flags_;

		// Token: 0x04005086 RID: 20614
		public const int TimeFieldNumber = 4;

		// Token: 0x04005087 RID: 20615
		private static readonly uint TimeDefaultValue = 0U;

		// Token: 0x04005088 RID: 20616
		private uint time_;

		// Token: 0x04005089 RID: 20617
		public const int EmptyFieldNumber = 5;

		// Token: 0x0400508A RID: 20618
		private static readonly string EmptyDefaultValue = "";

		// Token: 0x0400508B RID: 20619
		private string empty_;

		// Token: 0x0400508C RID: 20620
		public const int CharLevelFieldNumber = 6;

		// Token: 0x0400508D RID: 20621
		private static readonly uint CharLevelDefaultValue = 0U;

		// Token: 0x0400508E RID: 20622
		private uint charLevel_;

		// Token: 0x0400508F RID: 20623
		public const int LevelDifferenceFieldNumber = 7;

		// Token: 0x04005090 RID: 20624
		private static readonly uint LevelDifferenceDefaultValue = 0U;

		// Token: 0x04005091 RID: 20625
		private uint levelDifference_;

		// Token: 0x04005092 RID: 20626
		public const int MaxPlayersFieldNumber = 8;

		// Token: 0x04005093 RID: 20627
		private static readonly uint MaxPlayersDefaultValue = 0U;

		// Token: 0x04005094 RID: 20628
		private uint maxPlayers_;

		// Token: 0x04005095 RID: 20629
		public const int GamePlayersFieldNumber = 9;

		// Token: 0x04005096 RID: 20630
		private static readonly FieldCodec<GamePlayer> _repeated_gamePlayers_codec = FieldCodec.ForMessage<GamePlayer>(74U, GamePlayer.Parser);

		// Token: 0x04005097 RID: 20631
		private readonly RepeatedField<GamePlayer> gamePlayers_ = new RepeatedField<GamePlayer>();
	}
}
