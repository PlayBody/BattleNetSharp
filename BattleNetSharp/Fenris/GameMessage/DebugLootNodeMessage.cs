using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F5 RID: 501
	public sealed class DebugLootNodeMessage : IMessage<DebugLootNodeMessage>, IMessage, IEquatable<DebugLootNodeMessage>, IDeepCloneable<DebugLootNodeMessage>, IBufferMessage
	{
		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060036D9 RID: 14041 RVA: 0x000D8D20 File Offset: 0x000D6F20
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootNodeMessage> Parser
		{
			get
			{
				return DebugLootNodeMessage._parser;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x000D8D38 File Offset: 0x000D6F38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[58];
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x000D8D5C File Offset: 0x000D6F5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootNodeMessage.Descriptor;
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x000D8D73 File Offset: 0x000D6F73
		[DebuggerNonUserCode]
		public DebugLootNodeMessage()
		{
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x000D8D88 File Offset: 0x000D6F88
		[DebuggerNonUserCode]
		public DebugLootNodeMessage(DebugLootNodeMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.nodeId_ = other.nodeId_;
			this.nodeIdParent_ = other.nodeIdParent_;
			this.treasureClassSno_ = other.treasureClassSno_;
			this.chooseType_ = other.chooseType_;
			this.entryInfo_ = other.entryInfo_.Clone();
			this.flags_ = other.flags_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x000D8E08 File Offset: 0x000D7008
		[DebuggerNonUserCode]
		public DebugLootNodeMessage Clone()
		{
			return new DebugLootNodeMessage(this);
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060036DF RID: 14047 RVA: 0x000D8E20 File Offset: 0x000D7020
		// (set) Token: 0x060036E0 RID: 14048 RVA: 0x000D8E51 File Offset: 0x000D7051
		[DebuggerNonUserCode]
		public uint NodeId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint nodeIdDefaultValue;
				if (flag)
				{
					nodeIdDefaultValue = this.nodeId_;
				}
				else
				{
					nodeIdDefaultValue = DebugLootNodeMessage.NodeIdDefaultValue;
				}
				return nodeIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.nodeId_ = value;
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x060036E1 RID: 14049 RVA: 0x000D8E6C File Offset: 0x000D706C
		[DebuggerNonUserCode]
		public bool HasNodeId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x000D8E89 File Offset: 0x000D7089
		[DebuggerNonUserCode]
		public void ClearNodeId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060036E3 RID: 14051 RVA: 0x000D8E9C File Offset: 0x000D709C
		// (set) Token: 0x060036E4 RID: 14052 RVA: 0x000D8ECD File Offset: 0x000D70CD
		[DebuggerNonUserCode]
		public uint NodeIdParent
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint nodeIdParentDefaultValue;
				if (flag)
				{
					nodeIdParentDefaultValue = this.nodeIdParent_;
				}
				else
				{
					nodeIdParentDefaultValue = DebugLootNodeMessage.NodeIdParentDefaultValue;
				}
				return nodeIdParentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.nodeIdParent_ = value;
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x000D8EE8 File Offset: 0x000D70E8
		[DebuggerNonUserCode]
		public bool HasNodeIdParent
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x000D8F05 File Offset: 0x000D7105
		[DebuggerNonUserCode]
		public void ClearNodeIdParent()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x000D8F18 File Offset: 0x000D7118
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x000D8F49 File Offset: 0x000D7149
		[DebuggerNonUserCode]
		public int TreasureClassSno
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int treasureClassSnoDefaultValue;
				if (flag)
				{
					treasureClassSnoDefaultValue = this.treasureClassSno_;
				}
				else
				{
					treasureClassSnoDefaultValue = DebugLootNodeMessage.TreasureClassSnoDefaultValue;
				}
				return treasureClassSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.treasureClassSno_ = value;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x000D8F64 File Offset: 0x000D7164
		[DebuggerNonUserCode]
		public bool HasTreasureClassSno
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x000D8F81 File Offset: 0x000D7181
		[DebuggerNonUserCode]
		public void ClearTreasureClassSno()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x000D8F94 File Offset: 0x000D7194
		// (set) Token: 0x060036EC RID: 14060 RVA: 0x000D8FC5 File Offset: 0x000D71C5
		[DebuggerNonUserCode]
		public int ChooseType
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int chooseTypeDefaultValue;
				if (flag)
				{
					chooseTypeDefaultValue = this.chooseType_;
				}
				else
				{
					chooseTypeDefaultValue = DebugLootNodeMessage.ChooseTypeDefaultValue;
				}
				return chooseTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.chooseType_ = value;
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x000D8FE0 File Offset: 0x000D71E0
		[DebuggerNonUserCode]
		public bool HasChooseType
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x000D8FFD File Offset: 0x000D71FD
		[DebuggerNonUserCode]
		public void ClearChooseType()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x000D9010 File Offset: 0x000D7210
		[DebuggerNonUserCode]
		public RepeatedField<DebugLootEntryInfo> EntryInfo
		{
			get
			{
				return this.entryInfo_;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000D9028 File Offset: 0x000D7228
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x000D905A File Offset: 0x000D725A
		[DebuggerNonUserCode]
		public int Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = DebugLootNodeMessage.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.flags_ = value;
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x000D9074 File Offset: 0x000D7274
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x000D9092 File Offset: 0x000D7292
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x000D90A4 File Offset: 0x000D72A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootNodeMessage);
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x000D90C4 File Offset: 0x000D72C4
		[DebuggerNonUserCode]
		public bool Equals(DebugLootNodeMessage other)
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
					bool flag4 = this.NodeId != other.NodeId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.NodeIdParent != other.NodeIdParent;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TreasureClassSno != other.TreasureClassSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ChooseType != other.ChooseType;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.entryInfo_.Equals(other.entryInfo_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Flags != other.Flags;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x000D91B0 File Offset: 0x000D73B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNodeId = this.HasNodeId;
			if (hasNodeId)
			{
				num ^= this.NodeId.GetHashCode();
			}
			bool hasNodeIdParent = this.HasNodeIdParent;
			if (hasNodeIdParent)
			{
				num ^= this.NodeIdParent.GetHashCode();
			}
			bool hasTreasureClassSno = this.HasTreasureClassSno;
			if (hasTreasureClassSno)
			{
				num ^= this.TreasureClassSno.GetHashCode();
			}
			bool hasChooseType = this.HasChooseType;
			if (hasChooseType)
			{
				num ^= this.ChooseType.GetHashCode();
			}
			num ^= this.entryInfo_.GetHashCode();
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x000D9284 File Offset: 0x000D7484
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x000D929C File Offset: 0x000D749C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x000D92A8 File Offset: 0x000D74A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNodeId = this.HasNodeId;
			if (hasNodeId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NodeId);
			}
			bool hasNodeIdParent = this.HasNodeIdParent;
			if (hasNodeIdParent)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.NodeIdParent);
			}
			bool hasTreasureClassSno = this.HasTreasureClassSno;
			if (hasTreasureClassSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.TreasureClassSno);
			}
			bool hasChooseType = this.HasChooseType;
			if (hasChooseType)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChooseType);
			}
			this.entryInfo_.WriteTo(ref output, DebugLootNodeMessage._repeated_entryInfo_codec);
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Flags);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x000D9394 File Offset: 0x000D7594
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNodeId = this.HasNodeId;
			if (hasNodeId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NodeId);
			}
			bool hasNodeIdParent = this.HasNodeIdParent;
			if (hasNodeIdParent)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NodeIdParent);
			}
			bool hasTreasureClassSno = this.HasTreasureClassSno;
			if (hasTreasureClassSno)
			{
				num += 5;
			}
			bool hasChooseType = this.HasChooseType;
			if (hasChooseType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChooseType);
			}
			num += this.entryInfo_.CalculateSize(DebugLootNodeMessage._repeated_entryInfo_codec);
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flags);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x000D9464 File Offset: 0x000D7664
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootNodeMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNodeId = other.HasNodeId;
				if (hasNodeId)
				{
					this.NodeId = other.NodeId;
				}
				bool hasNodeIdParent = other.HasNodeIdParent;
				if (hasNodeIdParent)
				{
					this.NodeIdParent = other.NodeIdParent;
				}
				bool hasTreasureClassSno = other.HasTreasureClassSno;
				if (hasTreasureClassSno)
				{
					this.TreasureClassSno = other.TreasureClassSno;
				}
				bool hasChooseType = other.HasChooseType;
				if (hasChooseType)
				{
					this.ChooseType = other.ChooseType;
				}
				this.entryInfo_.Add(other.entryInfo_);
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x000D952A File Offset: 0x000D772A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x000D9538 File Offset: 0x000D7738
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 29U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 29U)
							{
								goto IL_0039;
							}
							this.TreasureClassSno = input.ReadSFixed32();
						}
						else
						{
							this.NodeIdParent = input.ReadUInt32();
						}
					}
					else
					{
						this.NodeId = input.ReadUInt32();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.Flags = input.ReadInt32();
					}
					else
					{
						this.entryInfo_.AddEntriesFrom(ref input, DebugLootNodeMessage._repeated_entryInfo_codec);
					}
				}
				else
				{
					this.ChooseType = input.ReadInt32();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400197F RID: 6527
		private static readonly MessageParser<DebugLootNodeMessage> _parser = new MessageParser<DebugLootNodeMessage>(() => new DebugLootNodeMessage());

		// Token: 0x04001980 RID: 6528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001981 RID: 6529
		private int _hasBits0;

		// Token: 0x04001982 RID: 6530
		public const int NodeIdFieldNumber = 1;

		// Token: 0x04001983 RID: 6531
		private static readonly uint NodeIdDefaultValue = 0U;

		// Token: 0x04001984 RID: 6532
		private uint nodeId_;

		// Token: 0x04001985 RID: 6533
		public const int NodeIdParentFieldNumber = 2;

		// Token: 0x04001986 RID: 6534
		private static readonly uint NodeIdParentDefaultValue = 0U;

		// Token: 0x04001987 RID: 6535
		private uint nodeIdParent_;

		// Token: 0x04001988 RID: 6536
		public const int TreasureClassSnoFieldNumber = 3;

		// Token: 0x04001989 RID: 6537
		private static readonly int TreasureClassSnoDefaultValue = 0;

		// Token: 0x0400198A RID: 6538
		private int treasureClassSno_;

		// Token: 0x0400198B RID: 6539
		public const int ChooseTypeFieldNumber = 4;

		// Token: 0x0400198C RID: 6540
		private static readonly int ChooseTypeDefaultValue = 0;

		// Token: 0x0400198D RID: 6541
		private int chooseType_;

		// Token: 0x0400198E RID: 6542
		public const int EntryInfoFieldNumber = 5;

		// Token: 0x0400198F RID: 6543
		private static readonly FieldCodec<DebugLootEntryInfo> _repeated_entryInfo_codec = FieldCodec.ForMessage<DebugLootEntryInfo>(42U, DebugLootEntryInfo.Parser);

		// Token: 0x04001990 RID: 6544
		private readonly RepeatedField<DebugLootEntryInfo> entryInfo_ = new RepeatedField<DebugLootEntryInfo>();

		// Token: 0x04001991 RID: 6545
		public const int FlagsFieldNumber = 6;

		// Token: 0x04001992 RID: 6546
		private static readonly int FlagsDefaultValue = 0;

		// Token: 0x04001993 RID: 6547
		private int flags_;
	}
}
