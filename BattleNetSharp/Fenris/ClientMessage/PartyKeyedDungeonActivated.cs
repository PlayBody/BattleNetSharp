using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200025E RID: 606
	public sealed class PartyKeyedDungeonActivated : IMessage<PartyKeyedDungeonActivated>, IMessage, IEquatable<PartyKeyedDungeonActivated>, IDeepCloneable<PartyKeyedDungeonActivated>, IBufferMessage
	{
		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x000FE38C File Offset: 0x000FC58C
		[DebuggerNonUserCode]
		public static MessageParser<PartyKeyedDungeonActivated> Parser
		{
			get
			{
				return PartyKeyedDungeonActivated._parser;
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x000FE3A4 File Offset: 0x000FC5A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[78];
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x000FE3C8 File Offset: 0x000FC5C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyKeyedDungeonActivated.Descriptor;
			}
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x000FE3DF File Offset: 0x000FC5DF
		[DebuggerNonUserCode]
		public PartyKeyedDungeonActivated()
		{
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x000FE3EC File Offset: 0x000FC5EC
		[DebuggerNonUserCode]
		public PartyKeyedDungeonActivated(PartyKeyedDungeonActivated other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.snoDungeon_ = other.snoDungeon_;
			this.dungeonTier_ = other.dungeonTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x000FE450 File Offset: 0x000FC650
		[DebuggerNonUserCode]
		public PartyKeyedDungeonActivated Clone()
		{
			return new PartyKeyedDungeonActivated(this);
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x000FE468 File Offset: 0x000FC668
		// (set) Token: 0x0600412C RID: 16684 RVA: 0x000FE489 File Offset: 0x000FC689
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyKeyedDungeonActivated.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x000FE4A0 File Offset: 0x000FC6A0
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x000FE4BB File Offset: 0x000FC6BB
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x000FE4C8 File Offset: 0x000FC6C8
		// (set) Token: 0x06004130 RID: 16688 RVA: 0x000FE4F9 File Offset: 0x000FC6F9
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = PartyKeyedDungeonActivated.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x000FE514 File Offset: 0x000FC714
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x000FE531 File Offset: 0x000FC731
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x000FE544 File Offset: 0x000FC744
		// (set) Token: 0x06004134 RID: 16692 RVA: 0x000FE575 File Offset: 0x000FC775
		[DebuggerNonUserCode]
		public uint SnoDungeon
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint snoDungeonDefaultValue;
				if (flag)
				{
					snoDungeonDefaultValue = this.snoDungeon_;
				}
				else
				{
					snoDungeonDefaultValue = PartyKeyedDungeonActivated.SnoDungeonDefaultValue;
				}
				return snoDungeonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoDungeon_ = value;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x000FE590 File Offset: 0x000FC790
		[DebuggerNonUserCode]
		public bool HasSnoDungeon
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x000FE5AD File Offset: 0x000FC7AD
		[DebuggerNonUserCode]
		public void ClearSnoDungeon()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06004137 RID: 16695 RVA: 0x000FE5C0 File Offset: 0x000FC7C0
		// (set) Token: 0x06004138 RID: 16696 RVA: 0x000FE5F1 File Offset: 0x000FC7F1
		[DebuggerNonUserCode]
		public uint DungeonTier
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint dungeonTierDefaultValue;
				if (flag)
				{
					dungeonTierDefaultValue = this.dungeonTier_;
				}
				else
				{
					dungeonTierDefaultValue = PartyKeyedDungeonActivated.DungeonTierDefaultValue;
				}
				return dungeonTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.dungeonTier_ = value;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x000FE60C File Offset: 0x000FC80C
		[DebuggerNonUserCode]
		public bool HasDungeonTier
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x000FE629 File Offset: 0x000FC829
		[DebuggerNonUserCode]
		public void ClearDungeonTier()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x000FE63C File Offset: 0x000FC83C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyKeyedDungeonActivated);
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x000FE65C File Offset: 0x000FC85C
		[DebuggerNonUserCode]
		public bool Equals(PartyKeyedDungeonActivated other)
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
					bool flag4 = this.PartyId != other.PartyId;
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
							bool flag6 = this.SnoDungeon != other.SnoDungeon;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.DungeonTier != other.DungeonTier;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x000FE708 File Offset: 0x000FC908
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasSnoDungeon = this.HasSnoDungeon;
			if (hasSnoDungeon)
			{
				num ^= this.SnoDungeon.GetHashCode();
			}
			bool hasDungeonTier = this.HasDungeonTier;
			if (hasDungeonTier)
			{
				num ^= this.DungeonTier.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000FE7AC File Offset: 0x000FC9AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x000FE7C4 File Offset: 0x000FC9C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x000FE7D0 File Offset: 0x000FC9D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasSnoDungeon = this.HasSnoDungeon;
			if (hasSnoDungeon)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.SnoDungeon);
			}
			bool hasDungeonTier = this.HasDungeonTier;
			if (hasDungeonTier)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.DungeonTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x000FE884 File Offset: 0x000FCA84
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasSnoDungeon = this.HasSnoDungeon;
			if (hasSnoDungeon)
			{
				num += 5;
			}
			bool hasDungeonTier = this.HasDungeonTier;
			if (hasDungeonTier)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DungeonTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x000FE920 File Offset: 0x000FCB20
		[DebuggerNonUserCode]
		public void MergeFrom(PartyKeyedDungeonActivated other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasSnoDungeon = other.HasSnoDungeon;
				if (hasSnoDungeon)
				{
					this.SnoDungeon = other.SnoDungeon;
				}
				bool hasDungeonTier = other.HasDungeonTier;
				if (hasDungeonTier)
				{
					this.DungeonTier = other.DungeonTier;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x000FE9B6 File Offset: 0x000FCBB6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x000FE9C4 File Offset: 0x000FCBC4
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
							goto IL_0029;
						}
						this.GameAccountId = input.ReadUInt32();
					}
					else
					{
						this.PartyId = input.ReadString();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.DungeonTier = input.ReadUInt32();
				}
				else
				{
					this.SnoDungeon = input.ReadFixed32();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D98 RID: 7576
		private static readonly MessageParser<PartyKeyedDungeonActivated> _parser = new MessageParser<PartyKeyedDungeonActivated>(() => new PartyKeyedDungeonActivated());

		// Token: 0x04001D99 RID: 7577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D9A RID: 7578
		private int _hasBits0;

		// Token: 0x04001D9B RID: 7579
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001D9C RID: 7580
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001D9D RID: 7581
		private string partyId_;

		// Token: 0x04001D9E RID: 7582
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04001D9F RID: 7583
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001DA0 RID: 7584
		private uint gameAccountId_;

		// Token: 0x04001DA1 RID: 7585
		public const int SnoDungeonFieldNumber = 3;

		// Token: 0x04001DA2 RID: 7586
		private static readonly uint SnoDungeonDefaultValue = 0U;

		// Token: 0x04001DA3 RID: 7587
		private uint snoDungeon_;

		// Token: 0x04001DA4 RID: 7588
		public const int DungeonTierFieldNumber = 4;

		// Token: 0x04001DA5 RID: 7589
		private static readonly uint DungeonTierDefaultValue = 0U;

		// Token: 0x04001DA6 RID: 7590
		private uint dungeonTier_;
	}
}
