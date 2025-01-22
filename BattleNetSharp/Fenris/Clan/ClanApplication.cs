using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002AF RID: 687
	public sealed class ClanApplication : IMessage<ClanApplication>, IMessage, IEquatable<ClanApplication>, IDeepCloneable<ClanApplication>, IBufferMessage
	{
		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x00116F94 File Offset: 0x00115194
		[DebuggerNonUserCode]
		public static MessageParser<ClanApplication> Parser
		{
			get
			{
				return ClanApplication._parser;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x00116FAC File Offset: 0x001151AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x00116FD0 File Offset: 0x001151D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanApplication.Descriptor;
			}
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x00116FE7 File Offset: 0x001151E7
		[DebuggerNonUserCode]
		public ClanApplication()
		{
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x00116FF4 File Offset: 0x001151F4
		[DebuggerNonUserCode]
		public ClanApplication(ClanApplication other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.bnetAccountId_ = other.bnetAccountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.createdAt_ = other.createdAt_;
			this.clanName_ = other.clanName_;
			this.removalReason_ = other.removalReason_;
			this.heraldry_ = ((other.heraldry_ != null) ? other.heraldry_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x0011708C File Offset: 0x0011528C
		[DebuggerNonUserCode]
		public ClanApplication Clone()
		{
			return new ClanApplication(this);
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x001170A4 File Offset: 0x001152A4
		// (set) Token: 0x060048DD RID: 18653 RVA: 0x001170C5 File Offset: 0x001152C5
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanApplication.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x001170DC File Offset: 0x001152DC
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x001170F7 File Offset: 0x001152F7
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x00117104 File Offset: 0x00115304
		// (set) Token: 0x060048E1 RID: 18657 RVA: 0x00117135 File Offset: 0x00115335
		[DebuggerNonUserCode]
		public uint BnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint bnetAccountIdDefaultValue;
				if (flag)
				{
					bnetAccountIdDefaultValue = this.bnetAccountId_;
				}
				else
				{
					bnetAccountIdDefaultValue = ClanApplication.BnetAccountIdDefaultValue;
				}
				return bnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bnetAccountId_ = value;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x00117150 File Offset: 0x00115350
		[DebuggerNonUserCode]
		public bool HasBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x0011716D File Offset: 0x0011536D
		[DebuggerNonUserCode]
		public void ClearBnetAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x00117180 File Offset: 0x00115380
		// (set) Token: 0x060048E5 RID: 18661 RVA: 0x001171B1 File Offset: 0x001153B1
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
					gameAccountIdDefaultValue = ClanApplication.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060048E6 RID: 18662 RVA: 0x001171CC File Offset: 0x001153CC
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x001171E9 File Offset: 0x001153E9
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x001171FC File Offset: 0x001153FC
		// (set) Token: 0x060048E9 RID: 18665 RVA: 0x0011722D File Offset: 0x0011542D
		[DebuggerNonUserCode]
		public ulong CreatedAt
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong createdAtDefaultValue;
				if (flag)
				{
					createdAtDefaultValue = this.createdAt_;
				}
				else
				{
					createdAtDefaultValue = ClanApplication.CreatedAtDefaultValue;
				}
				return createdAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.createdAt_ = value;
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060048EA RID: 18666 RVA: 0x00117248 File Offset: 0x00115448
		[DebuggerNonUserCode]
		public bool HasCreatedAt
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x00117265 File Offset: 0x00115465
		[DebuggerNonUserCode]
		public void ClearCreatedAt()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060048EC RID: 18668 RVA: 0x00117278 File Offset: 0x00115478
		// (set) Token: 0x060048ED RID: 18669 RVA: 0x00117299 File Offset: 0x00115499
		[DebuggerNonUserCode]
		public string ClanName
		{
			get
			{
				return this.clanName_ ?? ClanApplication.ClanNameDefaultValue;
			}
			set
			{
				this.clanName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x001172B0 File Offset: 0x001154B0
		[DebuggerNonUserCode]
		public bool HasClanName
		{
			get
			{
				return this.clanName_ != null;
			}
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x001172CB File Offset: 0x001154CB
		[DebuggerNonUserCode]
		public void ClearClanName()
		{
			this.clanName_ = null;
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x001172D8 File Offset: 0x001154D8
		// (set) Token: 0x060048F1 RID: 18673 RVA: 0x00117309 File Offset: 0x00115509
		[DebuggerNonUserCode]
		public uint RemovalReason
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint removalReasonDefaultValue;
				if (flag)
				{
					removalReasonDefaultValue = this.removalReason_;
				}
				else
				{
					removalReasonDefaultValue = ClanApplication.RemovalReasonDefaultValue;
				}
				return removalReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.removalReason_ = value;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x060048F2 RID: 18674 RVA: 0x00117324 File Offset: 0x00115524
		[DebuggerNonUserCode]
		public bool HasRemovalReason
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00117341 File Offset: 0x00115541
		[DebuggerNonUserCode]
		public void ClearRemovalReason()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x00117354 File Offset: 0x00115554
		// (set) Token: 0x060048F5 RID: 18677 RVA: 0x0011736C File Offset: 0x0011556C
		[DebuggerNonUserCode]
		public ClanHeraldry Heraldry
		{
			get
			{
				return this.heraldry_;
			}
			set
			{
				this.heraldry_ = value;
			}
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x00117378 File Offset: 0x00115578
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanApplication);
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x00117398 File Offset: 0x00115598
		[DebuggerNonUserCode]
		public bool Equals(ClanApplication other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BnetAccountId != other.BnetAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameAccountId != other.GameAccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CreatedAt != other.CreatedAt;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ClanName != other.ClanName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.RemovalReason != other.RemovalReason;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Heraldry, other.Heraldry);
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

		// Token: 0x060048F8 RID: 18680 RVA: 0x001174A4 File Offset: 0x001156A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
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
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num ^= this.CreatedAt.GetHashCode();
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num ^= this.ClanName.GetHashCode();
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				num ^= this.RemovalReason.GetHashCode();
			}
			bool flag = this.heraldry_ != null;
			if (flag)
			{
				num ^= this.Heraldry.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x0011759C File Offset: 0x0011579C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x001175B4 File Offset: 0x001157B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x001175C0 File Offset: 0x001157C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BnetAccountId);
			}
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.CreatedAt);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ClanName);
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.RemovalReason);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this.heraldry_ != null;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Heraldry);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x001176E4 File Offset: 0x001158E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
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
			bool hasCreatedAt = this.HasCreatedAt;
			if (hasCreatedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanName);
			}
			bool hasRemovalReason = this.HasRemovalReason;
			if (hasRemovalReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RemovalReason);
			}
			bool flag = this.heraldry_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Heraldry);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x001177EC File Offset: 0x001159EC
		[DebuggerNonUserCode]
		public void MergeFrom(ClanApplication other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
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
				bool hasCreatedAt = other.HasCreatedAt;
				if (hasCreatedAt)
				{
					this.CreatedAt = other.CreatedAt;
				}
				bool hasClanName = other.HasClanName;
				if (hasClanName)
				{
					this.ClanName = other.ClanName;
				}
				bool hasRemovalReason = other.HasRemovalReason;
				if (hasRemovalReason)
				{
					this.RemovalReason = other.RemovalReason;
				}
				bool flag2 = other.heraldry_ != null;
				if (flag2)
				{
					bool flag3 = this.heraldry_ == null;
					if (flag3)
					{
						this.Heraldry = new ClanHeraldry();
					}
					this.Heraldry.MergeFrom(other.Heraldry);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x001178FB File Offset: 0x00115AFB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00117908 File Offset: 0x00115B08
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0046;
							}
							this.CreatedAt = input.ReadUInt64();
						}
						else
						{
							this.BnetAccountId = input.ReadUInt32();
						}
					}
					else
					{
						this.ClanId = input.ReadString();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0046;
						}
						this.RemovalReason = input.ReadUInt32();
					}
					else
					{
						this.ClanName = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						goto IL_0046;
					}
					bool flag = this.heraldry_ == null;
					if (flag)
					{
						this.Heraldry = new ClanHeraldry();
					}
					input.ReadMessage(this.Heraldry);
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002071 RID: 8305
		private static readonly MessageParser<ClanApplication> _parser = new MessageParser<ClanApplication>(() => new ClanApplication());

		// Token: 0x04002072 RID: 8306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002073 RID: 8307
		private int _hasBits0;

		// Token: 0x04002074 RID: 8308
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04002075 RID: 8309
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04002076 RID: 8310
		private string clanId_;

		// Token: 0x04002077 RID: 8311
		public const int BnetAccountIdFieldNumber = 2;

		// Token: 0x04002078 RID: 8312
		private static readonly uint BnetAccountIdDefaultValue = 0U;

		// Token: 0x04002079 RID: 8313
		private uint bnetAccountId_;

		// Token: 0x0400207A RID: 8314
		public const int GameAccountIdFieldNumber = 7;

		// Token: 0x0400207B RID: 8315
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x0400207C RID: 8316
		private uint gameAccountId_;

		// Token: 0x0400207D RID: 8317
		public const int CreatedAtFieldNumber = 3;

		// Token: 0x0400207E RID: 8318
		private static readonly ulong CreatedAtDefaultValue = 0UL;

		// Token: 0x0400207F RID: 8319
		private ulong createdAt_;

		// Token: 0x04002080 RID: 8320
		public const int ClanNameFieldNumber = 5;

		// Token: 0x04002081 RID: 8321
		private static readonly string ClanNameDefaultValue = "";

		// Token: 0x04002082 RID: 8322
		private string clanName_;

		// Token: 0x04002083 RID: 8323
		public const int RemovalReasonFieldNumber = 6;

		// Token: 0x04002084 RID: 8324
		private static readonly uint RemovalReasonDefaultValue = 0U;

		// Token: 0x04002085 RID: 8325
		private uint removalReason_;

		// Token: 0x04002086 RID: 8326
		public const int HeraldryFieldNumber = 8;

		// Token: 0x04002087 RID: 8327
		private ClanHeraldry heraldry_;
	}
}
