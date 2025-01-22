using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F1 RID: 497
	public sealed class DebugLootActorInfo : IMessage<DebugLootActorInfo>, IMessage, IEquatable<DebugLootActorInfo>, IDeepCloneable<DebugLootActorInfo>, IBufferMessage
	{
		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x0600363A RID: 13882 RVA: 0x000D6674 File Offset: 0x000D4874
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootActorInfo> Parser
		{
			get
			{
				return DebugLootActorInfo._parser;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x000D668C File Offset: 0x000D488C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[54];
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x0600363C RID: 13884 RVA: 0x000D66B0 File Offset: 0x000D48B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootActorInfo.Descriptor;
			}
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x000D66C7 File Offset: 0x000D48C7
		[DebuggerNonUserCode]
		public DebugLootActorInfo()
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x000D66D4 File Offset: 0x000D48D4
		[DebuggerNonUserCode]
		public DebugLootActorInfo(DebugLootActorInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.acdName_ = other.acdName_;
			this.actorSno_ = other.actorSno_;
			this.level_ = other.level_;
			this.worldTier_ = other.worldTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x000D6744 File Offset: 0x000D4944
		[DebuggerNonUserCode]
		public DebugLootActorInfo Clone()
		{
			return new DebugLootActorInfo(this);
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x000D675C File Offset: 0x000D495C
		// (set) Token: 0x06003641 RID: 13889 RVA: 0x000D678D File Offset: 0x000D498D
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
					gameAccountIdDefaultValue = DebugLootActorInfo.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06003642 RID: 13890 RVA: 0x000D67A8 File Offset: 0x000D49A8
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x000D67C5 File Offset: 0x000D49C5
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06003644 RID: 13892 RVA: 0x000D67D8 File Offset: 0x000D49D8
		// (set) Token: 0x06003645 RID: 13893 RVA: 0x000D67F9 File Offset: 0x000D49F9
		[DebuggerNonUserCode]
		public string AcdName
		{
			get
			{
				return this.acdName_ ?? DebugLootActorInfo.AcdNameDefaultValue;
			}
			set
			{
				this.acdName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06003646 RID: 13894 RVA: 0x000D6810 File Offset: 0x000D4A10
		[DebuggerNonUserCode]
		public bool HasAcdName
		{
			get
			{
				return this.acdName_ != null;
			}
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x000D682B File Offset: 0x000D4A2B
		[DebuggerNonUserCode]
		public void ClearAcdName()
		{
			this.acdName_ = null;
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06003648 RID: 13896 RVA: 0x000D6838 File Offset: 0x000D4A38
		// (set) Token: 0x06003649 RID: 13897 RVA: 0x000D6869 File Offset: 0x000D4A69
		[DebuggerNonUserCode]
		public int ActorSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int actorSnoDefaultValue;
				if (flag)
				{
					actorSnoDefaultValue = this.actorSno_;
				}
				else
				{
					actorSnoDefaultValue = DebugLootActorInfo.ActorSnoDefaultValue;
				}
				return actorSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.actorSno_ = value;
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x000D6884 File Offset: 0x000D4A84
		[DebuggerNonUserCode]
		public bool HasActorSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x000D68A1 File Offset: 0x000D4AA1
		[DebuggerNonUserCode]
		public void ClearActorSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x000D68B4 File Offset: 0x000D4AB4
		// (set) Token: 0x0600364D RID: 13901 RVA: 0x000D68E5 File Offset: 0x000D4AE5
		[DebuggerNonUserCode]
		public int Level
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int levelDefaultValue;
				if (flag)
				{
					levelDefaultValue = this.level_;
				}
				else
				{
					levelDefaultValue = DebugLootActorInfo.LevelDefaultValue;
				}
				return levelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.level_ = value;
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x000D6900 File Offset: 0x000D4B00
		[DebuggerNonUserCode]
		public bool HasLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x000D691D File Offset: 0x000D4B1D
		[DebuggerNonUserCode]
		public void ClearLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06003650 RID: 13904 RVA: 0x000D6930 File Offset: 0x000D4B30
		// (set) Token: 0x06003651 RID: 13905 RVA: 0x000D6961 File Offset: 0x000D4B61
		[DebuggerNonUserCode]
		public int WorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int worldTierDefaultValue;
				if (flag)
				{
					worldTierDefaultValue = this.worldTier_;
				}
				else
				{
					worldTierDefaultValue = DebugLootActorInfo.WorldTierDefaultValue;
				}
				return worldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.worldTier_ = value;
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06003652 RID: 13906 RVA: 0x000D697C File Offset: 0x000D4B7C
		[DebuggerNonUserCode]
		public bool HasWorldTier
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x000D6999 File Offset: 0x000D4B99
		[DebuggerNonUserCode]
		public void ClearWorldTier()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x000D69AC File Offset: 0x000D4BAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootActorInfo);
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x000D69CC File Offset: 0x000D4BCC
		[DebuggerNonUserCode]
		public bool Equals(DebugLootActorInfo other)
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
						bool flag5 = this.AcdName != other.AcdName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ActorSno != other.ActorSno;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Level != other.Level;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.WorldTier != other.WorldTier;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x000D6A98 File Offset: 0x000D4C98
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				num ^= this.AcdName.GetHashCode();
			}
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				num ^= this.ActorSno.GetHashCode();
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num ^= this.Level.GetHashCode();
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num ^= this.WorldTier.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x000D6B5C File Offset: 0x000D4D5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x000D6B74 File Offset: 0x000D4D74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x000D6B80 File Offset: 0x000D4D80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AcdName);
			}
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				output.WriteRawTag(29);
				output.WriteSFixed32(this.ActorSno);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WorldTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x000D6C58 File Offset: 0x000D4E58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasAcdName = this.HasAcdName;
			if (hasAcdName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AcdName);
			}
			bool hasActorSno = this.HasActorSno;
			if (hasActorSno)
			{
				num += 5;
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x000D6D14 File Offset: 0x000D4F14
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootActorInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasAcdName = other.HasAcdName;
				if (hasAcdName)
				{
					this.AcdName = other.AcdName;
				}
				bool hasActorSno = other.HasActorSno;
				if (hasActorSno)
				{
					this.ActorSno = other.ActorSno;
				}
				bool hasLevel = other.HasLevel;
				if (hasLevel)
				{
					this.Level = other.Level;
				}
				bool hasWorldTier = other.HasWorldTier;
				if (hasWorldTier)
				{
					this.WorldTier = other.WorldTier;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x000D6DC8 File Offset: 0x000D4FC8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x000D6DD4 File Offset: 0x000D4FD4
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
							goto IL_0032;
						}
						this.AcdName = input.ReadString();
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.WorldTier = input.ReadInt32();
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.ActorSno = input.ReadSFixed32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001928 RID: 6440
		private static readonly MessageParser<DebugLootActorInfo> _parser = new MessageParser<DebugLootActorInfo>(() => new DebugLootActorInfo());

		// Token: 0x04001929 RID: 6441
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400192A RID: 6442
		private int _hasBits0;

		// Token: 0x0400192B RID: 6443
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x0400192C RID: 6444
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x0400192D RID: 6445
		private uint gameAccountId_;

		// Token: 0x0400192E RID: 6446
		public const int AcdNameFieldNumber = 2;

		// Token: 0x0400192F RID: 6447
		private static readonly string AcdNameDefaultValue = "";

		// Token: 0x04001930 RID: 6448
		private string acdName_;

		// Token: 0x04001931 RID: 6449
		public const int ActorSnoFieldNumber = 3;

		// Token: 0x04001932 RID: 6450
		private static readonly int ActorSnoDefaultValue = 0;

		// Token: 0x04001933 RID: 6451
		private int actorSno_;

		// Token: 0x04001934 RID: 6452
		public const int LevelFieldNumber = 4;

		// Token: 0x04001935 RID: 6453
		private static readonly int LevelDefaultValue = 0;

		// Token: 0x04001936 RID: 6454
		private int level_;

		// Token: 0x04001937 RID: 6455
		public const int WorldTierFieldNumber = 5;

		// Token: 0x04001938 RID: 6456
		private static readonly int WorldTierDefaultValue = 0;

		// Token: 0x04001939 RID: 6457
		private int worldTier_;
	}
}
