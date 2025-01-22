using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000794 RID: 1940
	public sealed class GamePlayer : IMessage<GamePlayer>, IMessage, IEquatable<GamePlayer>, IDeepCloneable<GamePlayer>, IBufferMessage
	{
		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600B229 RID: 45609 RVA: 0x002B5C88 File Offset: 0x002B3E88
		[DebuggerNonUserCode]
		public static MessageParser<GamePlayer> Parser
		{
			get
			{
				return GamePlayer._parser;
			}
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600B22A RID: 45610 RVA: 0x002B5CA0 File Offset: 0x002B3EA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600B22B RID: 45611 RVA: 0x002B5CC4 File Offset: 0x002B3EC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GamePlayer.Descriptor;
			}
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x002B5CDB File Offset: 0x002B3EDB
		[DebuggerNonUserCode]
		public GamePlayer()
		{
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x002B5CE8 File Offset: 0x002B3EE8
		[DebuggerNonUserCode]
		public GamePlayer(GamePlayer other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.class_ = other.class_;
			this.level_ = other.level_;
			this.characterId_ = other.characterId_;
			this.bnetId_ = other.bnetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x002B5D58 File Offset: 0x002B3F58
		[DebuggerNonUserCode]
		public GamePlayer Clone()
		{
			return new GamePlayer(this);
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600B22F RID: 45615 RVA: 0x002B5D70 File Offset: 0x002B3F70
		// (set) Token: 0x0600B230 RID: 45616 RVA: 0x002B5D91 File Offset: 0x002B3F91
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? GamePlayer.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600B231 RID: 45617 RVA: 0x002B5DA8 File Offset: 0x002B3FA8
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x002B5DC3 File Offset: 0x002B3FC3
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600B233 RID: 45619 RVA: 0x002B5DD0 File Offset: 0x002B3FD0
		// (set) Token: 0x0600B234 RID: 45620 RVA: 0x002B5E01 File Offset: 0x002B4001
		[DebuggerNonUserCode]
		public uint Class
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint classDefaultValue;
				if (flag)
				{
					classDefaultValue = this.class_;
				}
				else
				{
					classDefaultValue = GamePlayer.ClassDefaultValue;
				}
				return classDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.class_ = value;
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600B235 RID: 45621 RVA: 0x002B5E1C File Offset: 0x002B401C
		[DebuggerNonUserCode]
		public bool HasClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x002B5E39 File Offset: 0x002B4039
		[DebuggerNonUserCode]
		public void ClearClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600B237 RID: 45623 RVA: 0x002B5E4C File Offset: 0x002B404C
		// (set) Token: 0x0600B238 RID: 45624 RVA: 0x002B5E7D File Offset: 0x002B407D
		[DebuggerNonUserCode]
		public uint Level
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint levelDefaultValue;
				if (flag)
				{
					levelDefaultValue = this.level_;
				}
				else
				{
					levelDefaultValue = GamePlayer.LevelDefaultValue;
				}
				return levelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.level_ = value;
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600B239 RID: 45625 RVA: 0x002B5E98 File Offset: 0x002B4098
		[DebuggerNonUserCode]
		public bool HasLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x002B5EB5 File Offset: 0x002B40B5
		[DebuggerNonUserCode]
		public void ClearLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600B23B RID: 45627 RVA: 0x002B5EC8 File Offset: 0x002B40C8
		// (set) Token: 0x0600B23C RID: 45628 RVA: 0x002B5EF9 File Offset: 0x002B40F9
		[DebuggerNonUserCode]
		public uint CharacterId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint characterIdDefaultValue;
				if (flag)
				{
					characterIdDefaultValue = this.characterId_;
				}
				else
				{
					characterIdDefaultValue = GamePlayer.CharacterIdDefaultValue;
				}
				return characterIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.characterId_ = value;
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600B23D RID: 45629 RVA: 0x002B5F14 File Offset: 0x002B4114
		[DebuggerNonUserCode]
		public bool HasCharacterId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x002B5F31 File Offset: 0x002B4131
		[DebuggerNonUserCode]
		public void ClearCharacterId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600B23F RID: 45631 RVA: 0x002B5F44 File Offset: 0x002B4144
		// (set) Token: 0x0600B240 RID: 45632 RVA: 0x002B5F75 File Offset: 0x002B4175
		[DebuggerNonUserCode]
		public uint BnetId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint bnetIdDefaultValue;
				if (flag)
				{
					bnetIdDefaultValue = this.bnetId_;
				}
				else
				{
					bnetIdDefaultValue = GamePlayer.BnetIdDefaultValue;
				}
				return bnetIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.bnetId_ = value;
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600B241 RID: 45633 RVA: 0x002B5F90 File Offset: 0x002B4190
		[DebuggerNonUserCode]
		public bool HasBnetId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x002B5FAD File Offset: 0x002B41AD
		[DebuggerNonUserCode]
		public void ClearBnetId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x002B5FC0 File Offset: 0x002B41C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GamePlayer);
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x002B5FE0 File Offset: 0x002B41E0
		[DebuggerNonUserCode]
		public bool Equals(GamePlayer other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Class != other.Class;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Level != other.Level;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CharacterId != other.CharacterId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.BnetId != other.BnetId;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x002B60AC File Offset: 0x002B42AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				num ^= this.Class.GetHashCode();
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num ^= this.Level.GetHashCode();
			}
			bool hasCharacterId = this.HasCharacterId;
			if (hasCharacterId)
			{
				num ^= this.CharacterId.GetHashCode();
			}
			bool hasBnetId = this.HasBnetId;
			if (hasBnetId)
			{
				num ^= this.BnetId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x002B616C File Offset: 0x002B436C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x002B6184 File Offset: 0x002B4384
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x002B6190 File Offset: 0x002B4390
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Class);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			bool hasCharacterId = this.HasCharacterId;
			if (hasCharacterId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CharacterId);
			}
			bool hasBnetId = this.HasBnetId;
			if (hasBnetId)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BnetId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x002B6268 File Offset: 0x002B4468
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Class);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			bool hasCharacterId = this.HasCharacterId;
			if (hasCharacterId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CharacterId);
			}
			bool hasBnetId = this.HasBnetId;
			if (hasBnetId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x002B6330 File Offset: 0x002B4530
		[DebuggerNonUserCode]
		public void MergeFrom(GamePlayer other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasClass = other.HasClass;
				if (hasClass)
				{
					this.Class = other.Class;
				}
				bool hasLevel = other.HasLevel;
				if (hasLevel)
				{
					this.Level = other.Level;
				}
				bool hasCharacterId = other.HasCharacterId;
				if (hasCharacterId)
				{
					this.CharacterId = other.CharacterId;
				}
				bool hasBnetId = other.HasBnetId;
				if (hasBnetId)
				{
					this.BnetId = other.BnetId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x002B63E4 File Offset: 0x002B45E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x002B63F0 File Offset: 0x002B45F0
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
						this.Class = input.ReadUInt32();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.BnetId = input.ReadUInt32();
					}
					else
					{
						this.CharacterId = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005068 RID: 20584
		private static readonly MessageParser<GamePlayer> _parser = new MessageParser<GamePlayer>(() => new GamePlayer());

		// Token: 0x04005069 RID: 20585
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400506A RID: 20586
		private int _hasBits0;

		// Token: 0x0400506B RID: 20587
		public const int NameFieldNumber = 1;

		// Token: 0x0400506C RID: 20588
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400506D RID: 20589
		private string name_;

		// Token: 0x0400506E RID: 20590
		public const int ClassFieldNumber = 2;

		// Token: 0x0400506F RID: 20591
		private static readonly uint ClassDefaultValue = 0U;

		// Token: 0x04005070 RID: 20592
		private uint class_;

		// Token: 0x04005071 RID: 20593
		public const int LevelFieldNumber = 3;

		// Token: 0x04005072 RID: 20594
		private static readonly uint LevelDefaultValue = 0U;

		// Token: 0x04005073 RID: 20595
		private uint level_;

		// Token: 0x04005074 RID: 20596
		public const int CharacterIdFieldNumber = 4;

		// Token: 0x04005075 RID: 20597
		private static readonly uint CharacterIdDefaultValue = 0U;

		// Token: 0x04005076 RID: 20598
		private uint characterId_;

		// Token: 0x04005077 RID: 20599
		public const int BnetIdFieldNumber = 5;

		// Token: 0x04005078 RID: 20600
		private static readonly uint BnetIdDefaultValue = 0U;

		// Token: 0x04005079 RID: 20601
		private uint bnetId_;
	}
}
