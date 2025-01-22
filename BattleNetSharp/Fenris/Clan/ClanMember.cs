using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002AD RID: 685
	public sealed class ClanMember : IMessage<ClanMember>, IMessage, IEquatable<ClanMember>, IDeepCloneable<ClanMember>, IBufferMessage
	{
		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x00115754 File Offset: 0x00113954
		[DebuggerNonUserCode]
		public static MessageParser<ClanMember> Parser
		{
			get
			{
				return ClanMember._parser;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06004877 RID: 18551 RVA: 0x0011576C File Offset: 0x0011396C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x00115790 File Offset: 0x00113990
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanMember.Descriptor;
			}
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x001157A7 File Offset: 0x001139A7
		[DebuggerNonUserCode]
		public ClanMember()
		{
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x001157B4 File Offset: 0x001139B4
		[DebuggerNonUserCode]
		public ClanMember(ClanMember other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.bnetAccountId_ = other.bnetAccountId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.clanId_ = other.clanId_;
			this.joinedAt_ = other.joinedAt_;
			this.rank_ = other.rank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00115824 File Offset: 0x00113A24
		[DebuggerNonUserCode]
		public ClanMember Clone()
		{
			return new ClanMember(this);
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600487C RID: 18556 RVA: 0x0011583C File Offset: 0x00113A3C
		// (set) Token: 0x0600487D RID: 18557 RVA: 0x0011586D File Offset: 0x00113A6D
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
					bnetAccountIdDefaultValue = ClanMember.BnetAccountIdDefaultValue;
				}
				return bnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.bnetAccountId_ = value;
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x00115888 File Offset: 0x00113A88
		[DebuggerNonUserCode]
		public bool HasBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x001158A5 File Offset: 0x00113AA5
		[DebuggerNonUserCode]
		public void ClearBnetAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x001158B8 File Offset: 0x00113AB8
		// (set) Token: 0x06004881 RID: 18561 RVA: 0x001158E9 File Offset: 0x00113AE9
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = ClanMember.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x00115904 File Offset: 0x00113B04
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00115921 File Offset: 0x00113B21
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x00115934 File Offset: 0x00113B34
		// (set) Token: 0x06004885 RID: 18565 RVA: 0x00115955 File Offset: 0x00113B55
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanMember.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x0011596C File Offset: 0x00113B6C
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00115987 File Offset: 0x00113B87
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06004888 RID: 18568 RVA: 0x00115994 File Offset: 0x00113B94
		// (set) Token: 0x06004889 RID: 18569 RVA: 0x001159C5 File Offset: 0x00113BC5
		[DebuggerNonUserCode]
		public ulong JoinedAt
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong joinedAtDefaultValue;
				if (flag)
				{
					joinedAtDefaultValue = this.joinedAt_;
				}
				else
				{
					joinedAtDefaultValue = ClanMember.JoinedAtDefaultValue;
				}
				return joinedAtDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.joinedAt_ = value;
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600488A RID: 18570 RVA: 0x001159E0 File Offset: 0x00113BE0
		[DebuggerNonUserCode]
		public bool HasJoinedAt
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x001159FD File Offset: 0x00113BFD
		[DebuggerNonUserCode]
		public void ClearJoinedAt()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600488C RID: 18572 RVA: 0x00115A10 File Offset: 0x00113C10
		// (set) Token: 0x0600488D RID: 18573 RVA: 0x00115A41 File Offset: 0x00113C41
		[DebuggerNonUserCode]
		public ClanRank Rank
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ClanRank rankDefaultValue;
				if (flag)
				{
					rankDefaultValue = this.rank_;
				}
				else
				{
					rankDefaultValue = ClanMember.RankDefaultValue;
				}
				return rankDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.rank_ = value;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x0600488E RID: 18574 RVA: 0x00115A5C File Offset: 0x00113C5C
		[DebuggerNonUserCode]
		public bool HasRank
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x00115A79 File Offset: 0x00113C79
		[DebuggerNonUserCode]
		public void ClearRank()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x00115A8C File Offset: 0x00113C8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanMember);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x00115AAC File Offset: 0x00113CAC
		[DebuggerNonUserCode]
		public bool Equals(ClanMember other)
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
					bool flag4 = this.BnetAccountId != other.BnetAccountId;
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
							bool flag6 = this.ClanId != other.ClanId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.JoinedAt != other.JoinedAt;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Rank != other.Rank;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x00115B78 File Offset: 0x00113D78
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasJoinedAt = this.HasJoinedAt;
			if (hasJoinedAt)
			{
				num ^= this.JoinedAt.GetHashCode();
			}
			bool hasRank = this.HasRank;
			if (hasRank)
			{
				num ^= this.Rank.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00115C40 File Offset: 0x00113E40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x00115C58 File Offset: 0x00113E58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x00115C64 File Offset: 0x00113E64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BnetAccountId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ClanId);
			}
			bool hasJoinedAt = this.HasJoinedAt;
			if (hasJoinedAt)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.JoinedAt);
			}
			bool hasRank = this.HasRank;
			if (hasRank)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Rank);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x00115D3C File Offset: 0x00113F3C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasJoinedAt = this.HasJoinedAt;
			if (hasJoinedAt)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.JoinedAt);
			}
			bool hasRank = this.HasRank;
			if (hasRank)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Rank);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00115E04 File Offset: 0x00114004
		[DebuggerNonUserCode]
		public void MergeFrom(ClanMember other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasJoinedAt = other.HasJoinedAt;
				if (hasJoinedAt)
				{
					this.JoinedAt = other.JoinedAt;
				}
				bool hasRank = other.HasRank;
				if (hasRank)
				{
					this.Rank = other.Rank;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00115EB8 File Offset: 0x001140B8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00115EC4 File Offset: 0x001140C4
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.GameAccountId = input.ReadUInt32();
					}
					else
					{
						this.BnetAccountId = input.ReadUInt32();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0032;
						}
						this.Rank = (ClanRank)input.ReadEnum();
					}
					else
					{
						this.JoinedAt = input.ReadUInt64();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400203C RID: 8252
		private static readonly MessageParser<ClanMember> _parser = new MessageParser<ClanMember>(() => new ClanMember());

		// Token: 0x0400203D RID: 8253
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400203E RID: 8254
		private int _hasBits0;

		// Token: 0x0400203F RID: 8255
		public const int BnetAccountIdFieldNumber = 1;

		// Token: 0x04002040 RID: 8256
		private static readonly uint BnetAccountIdDefaultValue = 0U;

		// Token: 0x04002041 RID: 8257
		private uint bnetAccountId_;

		// Token: 0x04002042 RID: 8258
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04002043 RID: 8259
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04002044 RID: 8260
		private uint gameAccountId_;

		// Token: 0x04002045 RID: 8261
		public const int ClanIdFieldNumber = 4;

		// Token: 0x04002046 RID: 8262
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04002047 RID: 8263
		private string clanId_;

		// Token: 0x04002048 RID: 8264
		public const int JoinedAtFieldNumber = 5;

		// Token: 0x04002049 RID: 8265
		private static readonly ulong JoinedAtDefaultValue = 0UL;

		// Token: 0x0400204A RID: 8266
		private ulong joinedAt_;

		// Token: 0x0400204B RID: 8267
		public const int RankFieldNumber = 6;

		// Token: 0x0400204C RID: 8268
		private static readonly ClanRank RankDefaultValue = ClanRank.Invalid;

		// Token: 0x0400204D RID: 8269
		private ClanRank rank_;
	}
}
