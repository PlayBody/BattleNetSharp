using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000259 RID: 601
	public sealed class KeyedDungeonPartyVoteData : IMessage<KeyedDungeonPartyVoteData>, IMessage, IEquatable<KeyedDungeonPartyVoteData>, IDeepCloneable<KeyedDungeonPartyVoteData>, IBufferMessage
	{
		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x000FCE58 File Offset: 0x000FB058
		[DebuggerNonUserCode]
		public static MessageParser<KeyedDungeonPartyVoteData> Parser
		{
			get
			{
				return KeyedDungeonPartyVoteData._parser;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x000FCE70 File Offset: 0x000FB070
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[73];
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x000FCE94 File Offset: 0x000FB094
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KeyedDungeonPartyVoteData.Descriptor;
			}
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x000FCEAB File Offset: 0x000FB0AB
		[DebuggerNonUserCode]
		public KeyedDungeonPartyVoteData()
		{
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x000FCEB5 File Offset: 0x000FB0B5
		[DebuggerNonUserCode]
		public KeyedDungeonPartyVoteData(KeyedDungeonPartyVoteData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoDungeon_ = other.snoDungeon_;
			this.dungeonTier_ = other.dungeonTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x000FCEF4 File Offset: 0x000FB0F4
		[DebuggerNonUserCode]
		public KeyedDungeonPartyVoteData Clone()
		{
			return new KeyedDungeonPartyVoteData(this);
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x000FCF0C File Offset: 0x000FB10C
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x000FCF3D File Offset: 0x000FB13D
		[DebuggerNonUserCode]
		public int SnoDungeon
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoDungeonDefaultValue;
				if (flag)
				{
					snoDungeonDefaultValue = this.snoDungeon_;
				}
				else
				{
					snoDungeonDefaultValue = KeyedDungeonPartyVoteData.SnoDungeonDefaultValue;
				}
				return snoDungeonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoDungeon_ = value;
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x000FCF58 File Offset: 0x000FB158
		[DebuggerNonUserCode]
		public bool HasSnoDungeon
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x000FCF75 File Offset: 0x000FB175
		[DebuggerNonUserCode]
		public void ClearSnoDungeon()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x000FCF88 File Offset: 0x000FB188
		// (set) Token: 0x060040BF RID: 16575 RVA: 0x000FCFB9 File Offset: 0x000FB1B9
		[DebuggerNonUserCode]
		public int DungeonTier
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int dungeonTierDefaultValue;
				if (flag)
				{
					dungeonTierDefaultValue = this.dungeonTier_;
				}
				else
				{
					dungeonTierDefaultValue = KeyedDungeonPartyVoteData.DungeonTierDefaultValue;
				}
				return dungeonTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.dungeonTier_ = value;
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x000FCFD4 File Offset: 0x000FB1D4
		[DebuggerNonUserCode]
		public bool HasDungeonTier
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x000FCFF1 File Offset: 0x000FB1F1
		[DebuggerNonUserCode]
		public void ClearDungeonTier()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x000FD004 File Offset: 0x000FB204
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as KeyedDungeonPartyVoteData);
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x000FD024 File Offset: 0x000FB224
		[DebuggerNonUserCode]
		public bool Equals(KeyedDungeonPartyVoteData other)
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
					bool flag4 = this.SnoDungeon != other.SnoDungeon;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DungeonTier != other.DungeonTier;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x000FD098 File Offset: 0x000FB298
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x060040C5 RID: 16581 RVA: 0x000FD104 File Offset: 0x000FB304
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x000FD11C File Offset: 0x000FB31C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x000FD128 File Offset: 0x000FB328
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoDungeon = this.HasSnoDungeon;
			if (hasSnoDungeon)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoDungeon);
			}
			bool hasDungeonTier = this.HasDungeonTier;
			if (hasDungeonTier)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.DungeonTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x000FD198 File Offset: 0x000FB398
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoDungeon = this.HasSnoDungeon;
			if (hasSnoDungeon)
			{
				num += 5;
			}
			bool hasDungeonTier = this.HasDungeonTier;
			if (hasDungeonTier)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x000FD1EC File Offset: 0x000FB3EC
		[DebuggerNonUserCode]
		public void MergeFrom(KeyedDungeonPartyVoteData other)
		{
			bool flag = other == null;
			if (!flag)
			{
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

		// Token: 0x060040CA RID: 16586 RVA: 0x000FD24E File Offset: 0x000FB44E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x000FD25C File Offset: 0x000FB45C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DungeonTier = input.ReadSFixed32();
					}
				}
				else
				{
					this.SnoDungeon = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001D70 RID: 7536
		private static readonly MessageParser<KeyedDungeonPartyVoteData> _parser = new MessageParser<KeyedDungeonPartyVoteData>(() => new KeyedDungeonPartyVoteData());

		// Token: 0x04001D71 RID: 7537
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D72 RID: 7538
		private int _hasBits0;

		// Token: 0x04001D73 RID: 7539
		public const int SnoDungeonFieldNumber = 1;

		// Token: 0x04001D74 RID: 7540
		private static readonly int SnoDungeonDefaultValue = 0;

		// Token: 0x04001D75 RID: 7541
		private int snoDungeon_;

		// Token: 0x04001D76 RID: 7542
		public const int DungeonTierFieldNumber = 2;

		// Token: 0x04001D77 RID: 7543
		private static readonly int DungeonTierDefaultValue = 0;

		// Token: 0x04001D78 RID: 7544
		private int dungeonTier_;
	}
}
