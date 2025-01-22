using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B0 RID: 688
	public sealed class ClanBannedMember : IMessage<ClanBannedMember>, IMessage, IEquatable<ClanBannedMember>, IDeepCloneable<ClanBannedMember>, IBufferMessage
	{
		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x00117A68 File Offset: 0x00115C68
		[DebuggerNonUserCode]
		public static MessageParser<ClanBannedMember> Parser
		{
			get
			{
				return ClanBannedMember._parser;
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06004902 RID: 18690 RVA: 0x00117A80 File Offset: 0x00115C80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x00117AA4 File Offset: 0x00115CA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanBannedMember.Descriptor;
			}
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00117ABB File Offset: 0x00115CBB
		[DebuggerNonUserCode]
		public ClanBannedMember()
		{
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00117AC8 File Offset: 0x00115CC8
		[DebuggerNonUserCode]
		public ClanBannedMember(ClanBannedMember other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.bnetAccountId_ = other.bnetAccountId_;
			this.banTime_ = other.banTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00117B20 File Offset: 0x00115D20
		[DebuggerNonUserCode]
		public ClanBannedMember Clone()
		{
			return new ClanBannedMember(this);
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x00117B38 File Offset: 0x00115D38
		// (set) Token: 0x06004908 RID: 18696 RVA: 0x00117B69 File Offset: 0x00115D69
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
					gameAccountIdDefaultValue = ClanBannedMember.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x00117B84 File Offset: 0x00115D84
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00117BA1 File Offset: 0x00115DA1
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x00117BB4 File Offset: 0x00115DB4
		// (set) Token: 0x0600490C RID: 18700 RVA: 0x00117BE5 File Offset: 0x00115DE5
		[DebuggerNonUserCode]
		public uint BnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint bnetAccountIdDefaultValue;
				if (flag)
				{
					bnetAccountIdDefaultValue = this.bnetAccountId_;
				}
				else
				{
					bnetAccountIdDefaultValue = ClanBannedMember.BnetAccountIdDefaultValue;
				}
				return bnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.bnetAccountId_ = value;
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x00117C00 File Offset: 0x00115E00
		[DebuggerNonUserCode]
		public bool HasBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00117C1D File Offset: 0x00115E1D
		[DebuggerNonUserCode]
		public void ClearBnetAccountId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x00117C30 File Offset: 0x00115E30
		// (set) Token: 0x06004910 RID: 18704 RVA: 0x00117C61 File Offset: 0x00115E61
		[DebuggerNonUserCode]
		public ulong BanTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong banTimeDefaultValue;
				if (flag)
				{
					banTimeDefaultValue = this.banTime_;
				}
				else
				{
					banTimeDefaultValue = ClanBannedMember.BanTimeDefaultValue;
				}
				return banTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.banTime_ = value;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x00117C7C File Offset: 0x00115E7C
		[DebuggerNonUserCode]
		public bool HasBanTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00117C99 File Offset: 0x00115E99
		[DebuggerNonUserCode]
		public void ClearBanTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00117CAC File Offset: 0x00115EAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanBannedMember);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00117CCC File Offset: 0x00115ECC
		[DebuggerNonUserCode]
		public bool Equals(ClanBannedMember other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
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
							bool flag6 = this.BanTime != other.BanTime;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00117D58 File Offset: 0x00115F58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num ^= this.BnetAccountId.GetHashCode();
			}
			bool hasBanTime = this.HasBanTime;
			if (hasBanTime)
			{
				num ^= this.BanTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00117DE4 File Offset: 0x00115FE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x00117DFC File Offset: 0x00115FFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x00117E08 File Offset: 0x00116008
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasBanTime = this.HasBanTime;
			if (hasBanTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.BanTime);
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BnetAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x00117E98 File Offset: 0x00116098
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetAccountId);
			}
			bool hasBanTime = this.HasBanTime;
			if (hasBanTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.BanTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x00117F24 File Offset: 0x00116124
		[DebuggerNonUserCode]
		public void MergeFrom(ClanBannedMember other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasBnetAccountId = other.HasBnetAccountId;
				if (hasBnetAccountId)
				{
					this.BnetAccountId = other.BnetAccountId;
				}
				bool hasBanTime = other.HasBanTime;
				if (hasBanTime)
				{
					this.BanTime = other.BanTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00117F9F File Offset: 0x0011619F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x00117FAC File Offset: 0x001161AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BnetAccountId = input.ReadUInt32();
						}
					}
					else
					{
						this.BanTime = input.ReadUInt64();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002088 RID: 8328
		private static readonly MessageParser<ClanBannedMember> _parser = new MessageParser<ClanBannedMember>(() => new ClanBannedMember());

		// Token: 0x04002089 RID: 8329
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400208A RID: 8330
		private int _hasBits0;

		// Token: 0x0400208B RID: 8331
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x0400208C RID: 8332
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x0400208D RID: 8333
		private uint gameAccountId_;

		// Token: 0x0400208E RID: 8334
		public const int BnetAccountIdFieldNumber = 3;

		// Token: 0x0400208F RID: 8335
		private static readonly uint BnetAccountIdDefaultValue = 0U;

		// Token: 0x04002090 RID: 8336
		private uint bnetAccountId_;

		// Token: 0x04002091 RID: 8337
		public const int BanTimeFieldNumber = 2;

		// Token: 0x04002092 RID: 8338
		private static readonly ulong BanTimeDefaultValue = 0UL;

		// Token: 0x04002093 RID: 8339
		private ulong banTime_;
	}
}
