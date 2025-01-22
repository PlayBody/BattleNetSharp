using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000797 RID: 1943
	public sealed class GameInfo : IMessage<GameInfo>, IMessage, IEquatable<GameInfo>, IDeepCloneable<GameInfo>, IBufferMessage
	{
		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0600B292 RID: 45714 RVA: 0x002B74BC File Offset: 0x002B56BC
		[DebuggerNonUserCode]
		public static MessageParser<GameInfo> Parser
		{
			get
			{
				return GameInfo._parser;
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600B293 RID: 45715 RVA: 0x002B74D4 File Offset: 0x002B56D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600B294 RID: 45716 RVA: 0x002B74F8 File Offset: 0x002B56F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameInfo.Descriptor;
			}
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x002B750F File Offset: 0x002B570F
		[DebuggerNonUserCode]
		public GameInfo()
		{
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x002B751C File Offset: 0x002B571C
		[DebuggerNonUserCode]
		public GameInfo(GameInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.numPlayers_ = other.numPlayers_;
			this.maxPlayers_ = other.maxPlayers_;
			this.flags_ = other.flags_;
			this.unused_ = other.unused_;
			this.gameName_ = other.gameName_;
			this.gameDescription_ = other.gameDescription_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x002B75A4 File Offset: 0x002B57A4
		[DebuggerNonUserCode]
		public GameInfo Clone()
		{
			return new GameInfo(this);
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600B298 RID: 45720 RVA: 0x002B75BC File Offset: 0x002B57BC
		// (set) Token: 0x0600B299 RID: 45721 RVA: 0x002B75ED File Offset: 0x002B57ED
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = GameInfo.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600B29A RID: 45722 RVA: 0x002B7608 File Offset: 0x002B5808
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x002B7625 File Offset: 0x002B5825
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600B29C RID: 45724 RVA: 0x002B7638 File Offset: 0x002B5838
		// (set) Token: 0x0600B29D RID: 45725 RVA: 0x002B7669 File Offset: 0x002B5869
		[DebuggerNonUserCode]
		public uint NumPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint numPlayersDefaultValue;
				if (flag)
				{
					numPlayersDefaultValue = this.numPlayers_;
				}
				else
				{
					numPlayersDefaultValue = GameInfo.NumPlayersDefaultValue;
				}
				return numPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.numPlayers_ = value;
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600B29E RID: 45726 RVA: 0x002B7684 File Offset: 0x002B5884
		[DebuggerNonUserCode]
		public bool HasNumPlayers
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x002B76A1 File Offset: 0x002B58A1
		[DebuggerNonUserCode]
		public void ClearNumPlayers()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x002B76B4 File Offset: 0x002B58B4
		// (set) Token: 0x0600B2A1 RID: 45729 RVA: 0x002B76E5 File Offset: 0x002B58E5
		[DebuggerNonUserCode]
		public uint MaxPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint maxPlayersDefaultValue;
				if (flag)
				{
					maxPlayersDefaultValue = this.maxPlayers_;
				}
				else
				{
					maxPlayersDefaultValue = GameInfo.MaxPlayersDefaultValue;
				}
				return maxPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.maxPlayers_ = value;
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600B2A2 RID: 45730 RVA: 0x002B7700 File Offset: 0x002B5900
		[DebuggerNonUserCode]
		public bool HasMaxPlayers
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x002B771D File Offset: 0x002B591D
		[DebuggerNonUserCode]
		public void ClearMaxPlayers()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600B2A4 RID: 45732 RVA: 0x002B7730 File Offset: 0x002B5930
		// (set) Token: 0x0600B2A5 RID: 45733 RVA: 0x002B7761 File Offset: 0x002B5961
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = GameInfo.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.flags_ = value;
			}
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600B2A6 RID: 45734 RVA: 0x002B777C File Offset: 0x002B597C
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x002B7799 File Offset: 0x002B5999
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600B2A8 RID: 45736 RVA: 0x002B77AC File Offset: 0x002B59AC
		// (set) Token: 0x0600B2A9 RID: 45737 RVA: 0x002B77CD File Offset: 0x002B59CD
		[DebuggerNonUserCode]
		public string Unused
		{
			get
			{
				return this.unused_ ?? GameInfo.UnusedDefaultValue;
			}
			set
			{
				this.unused_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600B2AA RID: 45738 RVA: 0x002B77E4 File Offset: 0x002B59E4
		[DebuggerNonUserCode]
		public bool HasUnused
		{
			get
			{
				return this.unused_ != null;
			}
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x002B77FF File Offset: 0x002B59FF
		[DebuggerNonUserCode]
		public void ClearUnused()
		{
			this.unused_ = null;
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600B2AC RID: 45740 RVA: 0x002B780C File Offset: 0x002B5A0C
		// (set) Token: 0x0600B2AD RID: 45741 RVA: 0x002B782D File Offset: 0x002B5A2D
		[DebuggerNonUserCode]
		public string GameName
		{
			get
			{
				return this.gameName_ ?? GameInfo.GameNameDefaultValue;
			}
			set
			{
				this.gameName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600B2AE RID: 45742 RVA: 0x002B7844 File Offset: 0x002B5A44
		[DebuggerNonUserCode]
		public bool HasGameName
		{
			get
			{
				return this.gameName_ != null;
			}
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x002B785F File Offset: 0x002B5A5F
		[DebuggerNonUserCode]
		public void ClearGameName()
		{
			this.gameName_ = null;
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600B2B0 RID: 45744 RVA: 0x002B786C File Offset: 0x002B5A6C
		// (set) Token: 0x0600B2B1 RID: 45745 RVA: 0x002B788D File Offset: 0x002B5A8D
		[DebuggerNonUserCode]
		public string GameDescription
		{
			get
			{
				return this.gameDescription_ ?? GameInfo.GameDescriptionDefaultValue;
			}
			set
			{
				this.gameDescription_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600B2B2 RID: 45746 RVA: 0x002B78A4 File Offset: 0x002B5AA4
		[DebuggerNonUserCode]
		public bool HasGameDescription
		{
			get
			{
				return this.gameDescription_ != null;
			}
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x002B78BF File Offset: 0x002B5ABF
		[DebuggerNonUserCode]
		public void ClearGameDescription()
		{
			this.gameDescription_ = null;
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x002B78CC File Offset: 0x002B5ACC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameInfo);
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x002B78EC File Offset: 0x002B5AEC
		[DebuggerNonUserCode]
		public bool Equals(GameInfo other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.NumPlayers != other.NumPlayers;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MaxPlayers != other.MaxPlayers;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Flags != other.Flags;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Unused != other.Unused;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.GameName != other.GameName;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.GameDescription != other.GameDescription;
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

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x002B79F4 File Offset: 0x002B5BF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasNumPlayers = this.HasNumPlayers;
			if (hasNumPlayers)
			{
				num ^= this.NumPlayers.GetHashCode();
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num ^= this.MaxPlayers.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool hasUnused = this.HasUnused;
			if (hasUnused)
			{
				num ^= this.Unused.GetHashCode();
			}
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x002B7AE8 File Offset: 0x002B5CE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x002B7B00 File Offset: 0x002B5D00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x002B7B0C File Offset: 0x002B5D0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasNumPlayers = this.HasNumPlayers;
			if (hasNumPlayers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NumPlayers);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaxPlayers);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Flags);
			}
			bool hasUnused = this.HasUnused;
			if (hasUnused)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Unused);
			}
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.GameName);
			}
			bool hasGameDescription = this.HasGameDescription;
			if (hasGameDescription)
			{
				output.WriteRawTag(58);
				output.WriteString(this.GameDescription);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x002B7C2C File Offset: 0x002B5E2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasNumPlayers = this.HasNumPlayers;
			if (hasNumPlayers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NumPlayers);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPlayers);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			bool hasUnused = this.HasUnused;
			if (hasUnused)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Unused);
			}
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x002B7D30 File Offset: 0x002B5F30
		[DebuggerNonUserCode]
		public void MergeFrom(GameInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasNumPlayers = other.HasNumPlayers;
				if (hasNumPlayers)
				{
					this.NumPlayers = other.NumPlayers;
				}
				bool hasMaxPlayers = other.HasMaxPlayers;
				if (hasMaxPlayers)
				{
					this.MaxPlayers = other.MaxPlayers;
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				bool hasUnused = other.HasUnused;
				if (hasUnused)
				{
					this.Unused = other.Unused;
				}
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x002B7E1A File Offset: 0x002B601A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x002B7E28 File Offset: 0x002B6028
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0045;
							}
							this.MaxPlayers = input.ReadUInt32();
						}
						else
						{
							this.NumPlayers = input.ReadUInt32();
						}
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0045;
						}
						this.Unused = input.ReadString();
					}
					else
					{
						this.Flags = input.ReadUInt32();
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 58U)
					{
						goto IL_0045;
					}
					this.GameDescription = input.ReadString();
				}
				else
				{
					this.GameName = input.ReadString();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400509D RID: 20637
		private static readonly MessageParser<GameInfo> _parser = new MessageParser<GameInfo>(() => new GameInfo());

		// Token: 0x0400509E RID: 20638
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400509F RID: 20639
		private int _hasBits0;

		// Token: 0x040050A0 RID: 20640
		public const int IdFieldNumber = 1;

		// Token: 0x040050A1 RID: 20641
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x040050A2 RID: 20642
		private uint id_;

		// Token: 0x040050A3 RID: 20643
		public const int NumPlayersFieldNumber = 2;

		// Token: 0x040050A4 RID: 20644
		private static readonly uint NumPlayersDefaultValue = 0U;

		// Token: 0x040050A5 RID: 20645
		private uint numPlayers_;

		// Token: 0x040050A6 RID: 20646
		public const int MaxPlayersFieldNumber = 3;

		// Token: 0x040050A7 RID: 20647
		private static readonly uint MaxPlayersDefaultValue = 0U;

		// Token: 0x040050A8 RID: 20648
		private uint maxPlayers_;

		// Token: 0x040050A9 RID: 20649
		public const int FlagsFieldNumber = 4;

		// Token: 0x040050AA RID: 20650
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x040050AB RID: 20651
		private uint flags_;

		// Token: 0x040050AC RID: 20652
		public const int UnusedFieldNumber = 5;

		// Token: 0x040050AD RID: 20653
		private static readonly string UnusedDefaultValue = "";

		// Token: 0x040050AE RID: 20654
		private string unused_;

		// Token: 0x040050AF RID: 20655
		public const int GameNameFieldNumber = 6;

		// Token: 0x040050B0 RID: 20656
		private static readonly string GameNameDefaultValue = "";

		// Token: 0x040050B1 RID: 20657
		private string gameName_;

		// Token: 0x040050B2 RID: 20658
		public const int GameDescriptionFieldNumber = 7;

		// Token: 0x040050B3 RID: 20659
		private static readonly string GameDescriptionDefaultValue = "";

		// Token: 0x040050B4 RID: 20660
		private string gameDescription_;
	}
}
