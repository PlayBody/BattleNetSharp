using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000163 RID: 355
	public sealed class PvPDeathInfo : IMessage<PvPDeathInfo>, IMessage, IEquatable<PvPDeathInfo>, IDeepCloneable<PvPDeathInfo>, IBufferMessage
	{
		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0008E3E8 File Offset: 0x0008C5E8
		[DebuggerNonUserCode]
		public static MessageParser<PvPDeathInfo> Parser
		{
			get
			{
				return PvPDeathInfo._parser;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x0008E400 File Offset: 0x0008C600
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x0008E424 File Offset: 0x0008C624
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PvPDeathInfo.Descriptor;
			}
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0008E43B File Offset: 0x0008C63B
		[DebuggerNonUserCode]
		public PvPDeathInfo()
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0008E448 File Offset: 0x0008C648
		[DebuggerNonUserCode]
		public PvPDeathInfo(PvPDeathInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.playerClass_ = other.playerClass_;
			this.level_ = other.level_;
			this.levelArea_ = other.levelArea_;
			this.bnetAccountId_ = other.bnetAccountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.playerIsMale_ = other.playerIsMale_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0008E4C4 File Offset: 0x0008C6C4
		[DebuggerNonUserCode]
		public PvPDeathInfo Clone()
		{
			return new PvPDeathInfo(this);
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0008E4DC File Offset: 0x0008C6DC
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0008E50D File Offset: 0x0008C70D
		[DebuggerNonUserCode]
		public int PlayerClass
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int playerClassDefaultValue;
				if (flag)
				{
					playerClassDefaultValue = this.playerClass_;
				}
				else
				{
					playerClassDefaultValue = PvPDeathInfo.PlayerClassDefaultValue;
				}
				return playerClassDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.playerClass_ = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0008E528 File Offset: 0x0008C728
		[DebuggerNonUserCode]
		public bool HasPlayerClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0008E545 File Offset: 0x0008C745
		[DebuggerNonUserCode]
		public void ClearPlayerClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x0008E558 File Offset: 0x0008C758
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0008E589 File Offset: 0x0008C789
		[DebuggerNonUserCode]
		public int Level
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int levelDefaultValue;
				if (flag)
				{
					levelDefaultValue = this.level_;
				}
				else
				{
					levelDefaultValue = PvPDeathInfo.LevelDefaultValue;
				}
				return levelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.level_ = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0008E5A4 File Offset: 0x0008C7A4
		[DebuggerNonUserCode]
		public bool HasLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0008E5C1 File Offset: 0x0008C7C1
		[DebuggerNonUserCode]
		public void ClearLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x0008E5D4 File Offset: 0x0008C7D4
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0008E605 File Offset: 0x0008C805
		[DebuggerNonUserCode]
		public int LevelArea
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int levelAreaDefaultValue;
				if (flag)
				{
					levelAreaDefaultValue = this.levelArea_;
				}
				else
				{
					levelAreaDefaultValue = PvPDeathInfo.LevelAreaDefaultValue;
				}
				return levelAreaDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.levelArea_ = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x0008E620 File Offset: 0x0008C820
		[DebuggerNonUserCode]
		public bool HasLevelArea
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x0008E63D File Offset: 0x0008C83D
		[DebuggerNonUserCode]
		public void ClearLevelArea()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x0008E650 File Offset: 0x0008C850
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0008E682 File Offset: 0x0008C882
		[DebuggerNonUserCode]
		public uint BnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint bnetAccountIdDefaultValue;
				if (flag)
				{
					bnetAccountIdDefaultValue = this.bnetAccountId_;
				}
				else
				{
					bnetAccountIdDefaultValue = PvPDeathInfo.BnetAccountIdDefaultValue;
				}
				return bnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.bnetAccountId_ = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0008E69C File Offset: 0x0008C89C
		[DebuggerNonUserCode]
		public bool HasBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0008E6BA File Offset: 0x0008C8BA
		[DebuggerNonUserCode]
		public void ClearBnetAccountId()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0008E6CC File Offset: 0x0008C8CC
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0008E6FD File Offset: 0x0008C8FD
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = PvPDeathInfo.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x0008E718 File Offset: 0x0008C918
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0008E735 File Offset: 0x0008C935
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x0008E748 File Offset: 0x0008C948
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0008E77A File Offset: 0x0008C97A
		[DebuggerNonUserCode]
		public bool PlayerIsMale
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool playerIsMaleDefaultValue;
				if (flag)
				{
					playerIsMaleDefaultValue = this.playerIsMale_;
				}
				else
				{
					playerIsMaleDefaultValue = PvPDeathInfo.PlayerIsMaleDefaultValue;
				}
				return playerIsMaleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.playerIsMale_ = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x0008E794 File Offset: 0x0008C994
		[DebuggerNonUserCode]
		public bool HasPlayerIsMale
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0008E7B2 File Offset: 0x0008C9B2
		[DebuggerNonUserCode]
		public void ClearPlayerIsMale()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0008E7C4 File Offset: 0x0008C9C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PvPDeathInfo);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0008E7E4 File Offset: 0x0008C9E4
		[DebuggerNonUserCode]
		public bool Equals(PvPDeathInfo other)
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
					bool flag4 = this.PlayerClass != other.PlayerClass;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Level != other.Level;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LevelArea != other.LevelArea;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BnetAccountId != other.BnetAccountId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.GameAccountId != other.GameAccountId;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PlayerIsMale != other.PlayerIsMale;
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

		// Token: 0x060024CC RID: 9420 RVA: 0x0008E8D0 File Offset: 0x0008CAD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlayerClass = this.HasPlayerClass;
			if (hasPlayerClass)
			{
				num ^= this.PlayerClass.GetHashCode();
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num ^= this.Level.GetHashCode();
			}
			bool hasLevelArea = this.HasLevelArea;
			if (hasLevelArea)
			{
				num ^= this.LevelArea.GetHashCode();
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num ^= this.BnetAccountId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasPlayerIsMale = this.HasPlayerIsMale;
			if (hasPlayerIsMale)
			{
				num ^= this.PlayerIsMale.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0008E9B4 File Offset: 0x0008CBB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0008E9CC File Offset: 0x0008CBCC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0008E9D8 File Offset: 0x0008CBD8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlayerClass = this.HasPlayerClass;
			if (hasPlayerClass)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerClass);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			bool hasLevelArea = this.HasLevelArea;
			if (hasLevelArea)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LevelArea);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasPlayerIsMale = this.HasPlayerIsMale;
			if (hasPlayerIsMale)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.PlayerIsMale);
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.BnetAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0008EAD4 File Offset: 0x0008CCD4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlayerClass = this.HasPlayerClass;
			if (hasPlayerClass)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerClass);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			bool hasLevelArea = this.HasLevelArea;
			if (hasLevelArea)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelArea);
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetAccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasPlayerIsMale = this.HasPlayerIsMale;
			if (hasPlayerIsMale)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0008EBAC File Offset: 0x0008CDAC
		[DebuggerNonUserCode]
		public void MergeFrom(PvPDeathInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlayerClass = other.HasPlayerClass;
				if (hasPlayerClass)
				{
					this.PlayerClass = other.PlayerClass;
				}
				bool hasLevel = other.HasLevel;
				if (hasLevel)
				{
					this.Level = other.Level;
				}
				bool hasLevelArea = other.HasLevelArea;
				if (hasLevelArea)
				{
					this.LevelArea = other.LevelArea;
				}
				bool hasBnetAccountId = other.HasBnetAccountId;
				if (hasBnetAccountId)
				{
					this.BnetAccountId = other.BnetAccountId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasPlayerIsMale = other.HasPlayerIsMale;
				if (hasPlayerIsMale)
				{
					this.PlayerIsMale = other.PlayerIsMale;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0008EC7B File Offset: 0x0008CE7B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x0008EC88 File Offset: 0x0008CE88
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
								goto IL_0039;
							}
							this.LevelArea = input.ReadInt32();
						}
						else
						{
							this.Level = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerClass = input.ReadInt32();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.BnetAccountId = input.ReadUInt32();
					}
					else
					{
						this.PlayerIsMale = input.ReadBool();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400101A RID: 4122
		private static readonly MessageParser<PvPDeathInfo> _parser = new MessageParser<PvPDeathInfo>(() => new PvPDeathInfo());

		// Token: 0x0400101B RID: 4123
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400101C RID: 4124
		private int _hasBits0;

		// Token: 0x0400101D RID: 4125
		public const int PlayerClassFieldNumber = 1;

		// Token: 0x0400101E RID: 4126
		private static readonly int PlayerClassDefaultValue = 0;

		// Token: 0x0400101F RID: 4127
		private int playerClass_;

		// Token: 0x04001020 RID: 4128
		public const int LevelFieldNumber = 2;

		// Token: 0x04001021 RID: 4129
		private static readonly int LevelDefaultValue = 0;

		// Token: 0x04001022 RID: 4130
		private int level_;

		// Token: 0x04001023 RID: 4131
		public const int LevelAreaFieldNumber = 3;

		// Token: 0x04001024 RID: 4132
		private static readonly int LevelAreaDefaultValue = 0;

		// Token: 0x04001025 RID: 4133
		private int levelArea_;

		// Token: 0x04001026 RID: 4134
		public const int BnetAccountIdFieldNumber = 6;

		// Token: 0x04001027 RID: 4135
		private static readonly uint BnetAccountIdDefaultValue = 0U;

		// Token: 0x04001028 RID: 4136
		private uint bnetAccountId_;

		// Token: 0x04001029 RID: 4137
		public const int GameAccountIdFieldNumber = 4;

		// Token: 0x0400102A RID: 4138
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x0400102B RID: 4139
		private uint gameAccountId_;

		// Token: 0x0400102C RID: 4140
		public const int PlayerIsMaleFieldNumber = 5;

		// Token: 0x0400102D RID: 4141
		private static readonly bool PlayerIsMaleDefaultValue = false;

		// Token: 0x0400102E RID: 4142
		private bool playerIsMale_;
	}
}
