using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000706 RID: 1798
	public sealed class BlockedPlayer : IMessage<BlockedPlayer>, IMessage, IEquatable<BlockedPlayer>, IDeepCloneable<BlockedPlayer>, IBufferMessage
	{
		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600A50C RID: 42252 RVA: 0x0028328C File Offset: 0x0028148C
		[DebuggerNonUserCode]
		public static MessageParser<BlockedPlayer> Parser
		{
			get
			{
				return BlockedPlayer._parser;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600A50D RID: 42253 RVA: 0x002832A4 File Offset: 0x002814A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600A50E RID: 42254 RVA: 0x002832C8 File Offset: 0x002814C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayer.Descriptor;
			}
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x002832DF File Offset: 0x002814DF
		[DebuggerNonUserCode]
		public BlockedPlayer()
		{
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x002832EC File Offset: 0x002814EC
		[DebuggerNonUserCode]
		public BlockedPlayer(BlockedPlayer other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.battleTag_ = other.battleTag_;
			this.creationTimeUs_ = other.creationTimeUs_;
			this.modifiedTimeUs_ = other.modifiedTimeUs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x00283350 File Offset: 0x00281550
		[DebuggerNonUserCode]
		public BlockedPlayer Clone()
		{
			return new BlockedPlayer(this);
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600A512 RID: 42258 RVA: 0x00283368 File Offset: 0x00281568
		// (set) Token: 0x0600A513 RID: 42259 RVA: 0x00283399 File Offset: 0x00281599
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = BlockedPlayer.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600A514 RID: 42260 RVA: 0x002833B4 File Offset: 0x002815B4
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x002833D1 File Offset: 0x002815D1
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600A516 RID: 42262 RVA: 0x002833E4 File Offset: 0x002815E4
		// (set) Token: 0x0600A517 RID: 42263 RVA: 0x00283405 File Offset: 0x00281605
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? BlockedPlayer.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600A518 RID: 42264 RVA: 0x0028341C File Offset: 0x0028161C
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x00283437 File Offset: 0x00281637
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600A51A RID: 42266 RVA: 0x00283444 File Offset: 0x00281644
		// (set) Token: 0x0600A51B RID: 42267 RVA: 0x00283475 File Offset: 0x00281675
		[DebuggerNonUserCode]
		public ulong CreationTimeUs
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong creationTimeUsDefaultValue;
				if (flag)
				{
					creationTimeUsDefaultValue = this.creationTimeUs_;
				}
				else
				{
					creationTimeUsDefaultValue = BlockedPlayer.CreationTimeUsDefaultValue;
				}
				return creationTimeUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.creationTimeUs_ = value;
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600A51C RID: 42268 RVA: 0x00283490 File Offset: 0x00281690
		[DebuggerNonUserCode]
		public bool HasCreationTimeUs
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x002834AD File Offset: 0x002816AD
		[DebuggerNonUserCode]
		public void ClearCreationTimeUs()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600A51E RID: 42270 RVA: 0x002834C0 File Offset: 0x002816C0
		// (set) Token: 0x0600A51F RID: 42271 RVA: 0x002834F1 File Offset: 0x002816F1
		[DebuggerNonUserCode]
		public ulong ModifiedTimeUs
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong modifiedTimeUsDefaultValue;
				if (flag)
				{
					modifiedTimeUsDefaultValue = this.modifiedTimeUs_;
				}
				else
				{
					modifiedTimeUsDefaultValue = BlockedPlayer.ModifiedTimeUsDefaultValue;
				}
				return modifiedTimeUsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.modifiedTimeUs_ = value;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600A520 RID: 42272 RVA: 0x0028350C File Offset: 0x0028170C
		[DebuggerNonUserCode]
		public bool HasModifiedTimeUs
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x00283529 File Offset: 0x00281729
		[DebuggerNonUserCode]
		public void ClearModifiedTimeUs()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x0028353C File Offset: 0x0028173C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayer);
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x0028355C File Offset: 0x0028175C
		[DebuggerNonUserCode]
		public bool Equals(BlockedPlayer other)
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
						bool flag5 = this.BattleTag != other.BattleTag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CreationTimeUs != other.CreationTimeUs;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ModifiedTimeUs != other.ModifiedTimeUs;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x00283608 File Offset: 0x00281808
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool hasCreationTimeUs = this.HasCreationTimeUs;
			if (hasCreationTimeUs)
			{
				num ^= this.CreationTimeUs.GetHashCode();
			}
			bool hasModifiedTimeUs = this.HasModifiedTimeUs;
			if (hasModifiedTimeUs)
			{
				num ^= this.ModifiedTimeUs.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x002836AC File Offset: 0x002818AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x002836C4 File Offset: 0x002818C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x002836D0 File Offset: 0x002818D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.BattleTag);
			}
			bool hasCreationTimeUs = this.HasCreationTimeUs;
			if (hasCreationTimeUs)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.CreationTimeUs);
			}
			bool hasModifiedTimeUs = this.HasModifiedTimeUs;
			if (hasModifiedTimeUs)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.ModifiedTimeUs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x00283784 File Offset: 0x00281984
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool hasCreationTimeUs = this.HasCreationTimeUs;
			if (hasCreationTimeUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTimeUs);
			}
			bool hasModifiedTimeUs = this.HasModifiedTimeUs;
			if (hasModifiedTimeUs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ModifiedTimeUs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x0028382C File Offset: 0x00281A2C
		[DebuggerNonUserCode]
		public void MergeFrom(BlockedPlayer other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				bool hasCreationTimeUs = other.HasCreationTimeUs;
				if (hasCreationTimeUs)
				{
					this.CreationTimeUs = other.CreationTimeUs;
				}
				bool hasModifiedTimeUs = other.HasModifiedTimeUs;
				if (hasModifiedTimeUs)
				{
					this.ModifiedTimeUs = other.ModifiedTimeUs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x002838C2 File Offset: 0x00281AC2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x002838D0 File Offset: 0x00281AD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0028;
						}
						this.BattleTag = input.ReadString();
					}
					else
					{
						this.Id = input.ReadUInt64();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						goto IL_0028;
					}
					this.ModifiedTimeUs = input.ReadUInt64();
				}
				else
				{
					this.CreationTimeUs = input.ReadUInt64();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A4B RID: 19019
		private static readonly MessageParser<BlockedPlayer> _parser = new MessageParser<BlockedPlayer>(() => new BlockedPlayer());

		// Token: 0x04004A4C RID: 19020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A4D RID: 19021
		private int _hasBits0;

		// Token: 0x04004A4E RID: 19022
		public const int IdFieldNumber = 1;

		// Token: 0x04004A4F RID: 19023
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04004A50 RID: 19024
		private ulong id_;

		// Token: 0x04004A51 RID: 19025
		public const int BattleTagFieldNumber = 2;

		// Token: 0x04004A52 RID: 19026
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04004A53 RID: 19027
		private string battleTag_;

		// Token: 0x04004A54 RID: 19028
		public const int CreationTimeUsFieldNumber = 4;

		// Token: 0x04004A55 RID: 19029
		private static readonly ulong CreationTimeUsDefaultValue = 0UL;

		// Token: 0x04004A56 RID: 19030
		private ulong creationTimeUs_;

		// Token: 0x04004A57 RID: 19031
		public const int ModifiedTimeUsFieldNumber = 5;

		// Token: 0x04004A58 RID: 19032
		private static readonly ulong ModifiedTimeUsDefaultValue = 0UL;

		// Token: 0x04004A59 RID: 19033
		private ulong modifiedTimeUs_;
	}
}
