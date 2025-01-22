using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001ED RID: 493
	public sealed class DebugTrackedCheckpointData : IMessage<DebugTrackedCheckpointData>, IMessage, IEquatable<DebugTrackedCheckpointData>, IDeepCloneable<DebugTrackedCheckpointData>, IBufferMessage
	{
		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x000D43E8 File Offset: 0x000D25E8
		[DebuggerNonUserCode]
		public static MessageParser<DebugTrackedCheckpointData> Parser
		{
			get
			{
				return DebugTrackedCheckpointData._parser;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x000D4400 File Offset: 0x000D2600
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[50];
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x000D4424 File Offset: 0x000D2624
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugTrackedCheckpointData.Descriptor;
			}
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x000D443B File Offset: 0x000D263B
		[DebuggerNonUserCode]
		public DebugTrackedCheckpointData()
		{
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x000D445C File Offset: 0x000D265C
		[DebuggerNonUserCode]
		public DebugTrackedCheckpointData(DebugTrackedCheckpointData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.isActive_ = other.isActive_;
			this.playerCount_ = other.playerCount_;
			this.monsterCount_ = other.monsterCount_;
			this.ann_ = other.ann_;
			this.acdid_ = other.acdid_;
			this.monsterSpawnAcds_ = other.monsterSpawnAcds_.Clone();
			this.monsterVisitingAcds_ = other.monsterVisitingAcds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x000D451C File Offset: 0x000D271C
		[DebuggerNonUserCode]
		public DebugTrackedCheckpointData Clone()
		{
			return new DebugTrackedCheckpointData(this);
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x000D4534 File Offset: 0x000D2734
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x000D4555 File Offset: 0x000D2755
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? DebugTrackedCheckpointData.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000D456C File Offset: 0x000D276C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x000D4587 File Offset: 0x000D2787
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x000D4594 File Offset: 0x000D2794
		// (set) Token: 0x060035B7 RID: 13751 RVA: 0x000D45C5 File Offset: 0x000D27C5
		[DebuggerNonUserCode]
		public float PosX
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float posXDefaultValue;
				if (flag)
				{
					posXDefaultValue = this.posX_;
				}
				else
				{
					posXDefaultValue = DebugTrackedCheckpointData.PosXDefaultValue;
				}
				return posXDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.posX_ = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x000D45E0 File Offset: 0x000D27E0
		[DebuggerNonUserCode]
		public bool HasPosX
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x000D45FD File Offset: 0x000D27FD
		[DebuggerNonUserCode]
		public void ClearPosX()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x000D4610 File Offset: 0x000D2810
		// (set) Token: 0x060035BB RID: 13755 RVA: 0x000D4641 File Offset: 0x000D2841
		[DebuggerNonUserCode]
		public float PosY
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float posYDefaultValue;
				if (flag)
				{
					posYDefaultValue = this.posY_;
				}
				else
				{
					posYDefaultValue = DebugTrackedCheckpointData.PosYDefaultValue;
				}
				return posYDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.posY_ = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x000D465C File Offset: 0x000D285C
		[DebuggerNonUserCode]
		public bool HasPosY
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x000D4679 File Offset: 0x000D2879
		[DebuggerNonUserCode]
		public void ClearPosY()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x000D468C File Offset: 0x000D288C
		// (set) Token: 0x060035BF RID: 13759 RVA: 0x000D46BD File Offset: 0x000D28BD
		[DebuggerNonUserCode]
		public float PosZ
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float posZDefaultValue;
				if (flag)
				{
					posZDefaultValue = this.posZ_;
				}
				else
				{
					posZDefaultValue = DebugTrackedCheckpointData.PosZDefaultValue;
				}
				return posZDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.posZ_ = value;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x000D46D8 File Offset: 0x000D28D8
		[DebuggerNonUserCode]
		public bool HasPosZ
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x000D46F5 File Offset: 0x000D28F5
		[DebuggerNonUserCode]
		public void ClearPosZ()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x000D4708 File Offset: 0x000D2908
		// (set) Token: 0x060035C3 RID: 13763 RVA: 0x000D4739 File Offset: 0x000D2939
		[DebuggerNonUserCode]
		public bool IsActive
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isActiveDefaultValue;
				if (flag)
				{
					isActiveDefaultValue = this.isActive_;
				}
				else
				{
					isActiveDefaultValue = DebugTrackedCheckpointData.IsActiveDefaultValue;
				}
				return isActiveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isActive_ = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000D4754 File Offset: 0x000D2954
		[DebuggerNonUserCode]
		public bool HasIsActive
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x000D4771 File Offset: 0x000D2971
		[DebuggerNonUserCode]
		public void ClearIsActive()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000D4784 File Offset: 0x000D2984
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x000D47B6 File Offset: 0x000D29B6
		[DebuggerNonUserCode]
		public uint PlayerCount
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint playerCountDefaultValue;
				if (flag)
				{
					playerCountDefaultValue = this.playerCount_;
				}
				else
				{
					playerCountDefaultValue = DebugTrackedCheckpointData.PlayerCountDefaultValue;
				}
				return playerCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.playerCount_ = value;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x000D47D0 File Offset: 0x000D29D0
		[DebuggerNonUserCode]
		public bool HasPlayerCount
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x000D47EE File Offset: 0x000D29EE
		[DebuggerNonUserCode]
		public void ClearPlayerCount()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x000D4800 File Offset: 0x000D2A00
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x000D4832 File Offset: 0x000D2A32
		[DebuggerNonUserCode]
		public uint MonsterCount
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint monsterCountDefaultValue;
				if (flag)
				{
					monsterCountDefaultValue = this.monsterCount_;
				}
				else
				{
					monsterCountDefaultValue = DebugTrackedCheckpointData.MonsterCountDefaultValue;
				}
				return monsterCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.monsterCount_ = value;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x000D484C File Offset: 0x000D2A4C
		[DebuggerNonUserCode]
		public bool HasMonsterCount
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x000D486A File Offset: 0x000D2A6A
		[DebuggerNonUserCode]
		public void ClearMonsterCount()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x000D487C File Offset: 0x000D2A7C
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x000D48AE File Offset: 0x000D2AAE
		[DebuggerNonUserCode]
		public uint Ann
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint annDefaultValue;
				if (flag)
				{
					annDefaultValue = this.ann_;
				}
				else
				{
					annDefaultValue = DebugTrackedCheckpointData.AnnDefaultValue;
				}
				return annDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.ann_ = value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x000D48C8 File Offset: 0x000D2AC8
		[DebuggerNonUserCode]
		public bool HasAnn
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x000D48E6 File Offset: 0x000D2AE6
		[DebuggerNonUserCode]
		public void ClearAnn()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x000D48F8 File Offset: 0x000D2AF8
		// (set) Token: 0x060035D3 RID: 13779 RVA: 0x000D492D File Offset: 0x000D2B2D
		[DebuggerNonUserCode]
		public int Acdid
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int acdidDefaultValue;
				if (flag)
				{
					acdidDefaultValue = this.acdid_;
				}
				else
				{
					acdidDefaultValue = DebugTrackedCheckpointData.AcdidDefaultValue;
				}
				return acdidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.acdid_ = value;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x000D494C File Offset: 0x000D2B4C
		[DebuggerNonUserCode]
		public bool HasAcdid
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000D496D File Offset: 0x000D2B6D
		[DebuggerNonUserCode]
		public void ClearAcdid()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000D4984 File Offset: 0x000D2B84
		[DebuggerNonUserCode]
		public RepeatedField<int> MonsterSpawnAcds
		{
			get
			{
				return this.monsterSpawnAcds_;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x000D499C File Offset: 0x000D2B9C
		[DebuggerNonUserCode]
		public RepeatedField<int> MonsterVisitingAcds
		{
			get
			{
				return this.monsterVisitingAcds_;
			}
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x000D49B4 File Offset: 0x000D2BB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugTrackedCheckpointData);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x000D49D4 File Offset: 0x000D2BD4
		[DebuggerNonUserCode]
		public bool Equals(DebugTrackedCheckpointData other)
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
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.IsActive != other.IsActive;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PlayerCount != other.PlayerCount;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.MonsterCount != other.MonsterCount;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Ann != other.Ann;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.Acdid != other.Acdid;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.monsterSpawnAcds_.Equals(other.monsterSpawnAcds_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !this.monsterVisitingAcds_.Equals(other.monsterVisitingAcds_);
															flag2 = !flag14 && object.Equals(this._unknownFields, other._unknownFields);
														}
													}
												}
											}
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

		// Token: 0x060035DA RID: 13786 RVA: 0x000D4B74 File Offset: 0x000D2D74
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosY);
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosZ);
			}
			bool hasIsActive = this.HasIsActive;
			if (hasIsActive)
			{
				num ^= this.IsActive.GetHashCode();
			}
			bool hasPlayerCount = this.HasPlayerCount;
			if (hasPlayerCount)
			{
				num ^= this.PlayerCount.GetHashCode();
			}
			bool hasMonsterCount = this.HasMonsterCount;
			if (hasMonsterCount)
			{
				num ^= this.MonsterCount.GetHashCode();
			}
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num ^= this.Ann.GetHashCode();
			}
			bool hasAcdid = this.HasAcdid;
			if (hasAcdid)
			{
				num ^= this.Acdid.GetHashCode();
			}
			num ^= this.monsterSpawnAcds_.GetHashCode();
			num ^= this.monsterVisitingAcds_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x000D4CD0 File Offset: 0x000D2ED0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x000D4CE8 File Offset: 0x000D2EE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x000D4CF4 File Offset: 0x000D2EF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PosX);
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PosY);
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.PosZ);
			}
			bool hasIsActive = this.HasIsActive;
			if (hasIsActive)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsActive);
			}
			bool hasPlayerCount = this.HasPlayerCount;
			if (hasPlayerCount)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PlayerCount);
			}
			bool hasMonsterCount = this.HasMonsterCount;
			if (hasMonsterCount)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MonsterCount);
			}
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				output.WriteRawTag(69);
				output.WriteFixed32(this.Ann);
			}
			bool hasAcdid = this.HasAcdid;
			if (hasAcdid)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Acdid);
			}
			this.monsterSpawnAcds_.WriteTo(ref output, DebugTrackedCheckpointData._repeated_monsterSpawnAcds_codec);
			this.monsterVisitingAcds_.WriteTo(ref output, DebugTrackedCheckpointData._repeated_monsterVisitingAcds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x000D4E80 File Offset: 0x000D3080
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasPosX = this.HasPosX;
			if (hasPosX)
			{
				num += 5;
			}
			bool hasPosY = this.HasPosY;
			if (hasPosY)
			{
				num += 5;
			}
			bool hasPosZ = this.HasPosZ;
			if (hasPosZ)
			{
				num += 5;
			}
			bool hasIsActive = this.HasIsActive;
			if (hasIsActive)
			{
				num += 2;
			}
			bool hasPlayerCount = this.HasPlayerCount;
			if (hasPlayerCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayerCount);
			}
			bool hasMonsterCount = this.HasMonsterCount;
			if (hasMonsterCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MonsterCount);
			}
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num += 5;
			}
			bool hasAcdid = this.HasAcdid;
			if (hasAcdid)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Acdid);
			}
			num += this.monsterSpawnAcds_.CalculateSize(DebugTrackedCheckpointData._repeated_monsterSpawnAcds_codec);
			num += this.monsterVisitingAcds_.CalculateSize(DebugTrackedCheckpointData._repeated_monsterVisitingAcds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000D4FA8 File Offset: 0x000D31A8
		[DebuggerNonUserCode]
		public void MergeFrom(DebugTrackedCheckpointData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasPosX = other.HasPosX;
				if (hasPosX)
				{
					this.PosX = other.PosX;
				}
				bool hasPosY = other.HasPosY;
				if (hasPosY)
				{
					this.PosY = other.PosY;
				}
				bool hasPosZ = other.HasPosZ;
				if (hasPosZ)
				{
					this.PosZ = other.PosZ;
				}
				bool hasIsActive = other.HasIsActive;
				if (hasIsActive)
				{
					this.IsActive = other.IsActive;
				}
				bool hasPlayerCount = other.HasPlayerCount;
				if (hasPlayerCount)
				{
					this.PlayerCount = other.PlayerCount;
				}
				bool hasMonsterCount = other.HasMonsterCount;
				if (hasMonsterCount)
				{
					this.MonsterCount = other.MonsterCount;
				}
				bool hasAnn = other.HasAnn;
				if (hasAnn)
				{
					this.Ann = other.Ann;
				}
				bool hasAcdid = other.HasAcdid;
				if (hasAcdid)
				{
					this.Acdid = other.Acdid;
				}
				this.monsterSpawnAcds_.Add(other.monsterSpawnAcds_);
				this.monsterVisitingAcds_.Add(other.monsterVisitingAcds_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x000D50EC File Offset: 0x000D32EC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x000D50F8 File Offset: 0x000D32F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 29U)
					{
						if (num3 != 10U)
						{
							if (num3 != 21U)
							{
								if (num3 != 29U)
								{
									goto IL_00A1;
								}
								this.PosY = input.ReadFloat();
							}
							else
							{
								this.PosX = input.ReadFloat();
							}
						}
						else
						{
							this.Name = input.ReadString();
						}
					}
					else if (num3 != 37U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_00A1;
							}
							this.PlayerCount = input.ReadUInt32();
						}
						else
						{
							this.IsActive = input.ReadBool();
						}
					}
					else
					{
						this.PosZ = input.ReadFloat();
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 56U)
					{
						if (num3 != 69U)
						{
							if (num3 != 72U)
							{
								goto IL_00A1;
							}
							this.Acdid = input.ReadInt32();
						}
						else
						{
							this.Ann = input.ReadFixed32();
						}
					}
					else
					{
						this.MonsterCount = input.ReadUInt32();
					}
				}
				else if (num3 <= 82U)
				{
					if (num3 != 80U && num3 != 82U)
					{
						goto IL_00A1;
					}
					this.monsterSpawnAcds_.AddEntriesFrom(ref input, DebugTrackedCheckpointData._repeated_monsterSpawnAcds_codec);
				}
				else
				{
					if (num3 != 88U && num3 != 90U)
					{
						goto IL_00A1;
					}
					this.monsterVisitingAcds_.AddEntriesFrom(ref input, DebugTrackedCheckpointData._repeated_monsterVisitingAcds_codec);
				}
				continue;
				IL_00A1:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040018DC RID: 6364
		private static readonly MessageParser<DebugTrackedCheckpointData> _parser = new MessageParser<DebugTrackedCheckpointData>(() => new DebugTrackedCheckpointData());

		// Token: 0x040018DD RID: 6365
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018DE RID: 6366
		private int _hasBits0;

		// Token: 0x040018DF RID: 6367
		public const int NameFieldNumber = 1;

		// Token: 0x040018E0 RID: 6368
		private static readonly string NameDefaultValue = "";

		// Token: 0x040018E1 RID: 6369
		private string name_;

		// Token: 0x040018E2 RID: 6370
		public const int PosXFieldNumber = 2;

		// Token: 0x040018E3 RID: 6371
		private static readonly float PosXDefaultValue = 0f;

		// Token: 0x040018E4 RID: 6372
		private float posX_;

		// Token: 0x040018E5 RID: 6373
		public const int PosYFieldNumber = 3;

		// Token: 0x040018E6 RID: 6374
		private static readonly float PosYDefaultValue = 0f;

		// Token: 0x040018E7 RID: 6375
		private float posY_;

		// Token: 0x040018E8 RID: 6376
		public const int PosZFieldNumber = 4;

		// Token: 0x040018E9 RID: 6377
		private static readonly float PosZDefaultValue = 0f;

		// Token: 0x040018EA RID: 6378
		private float posZ_;

		// Token: 0x040018EB RID: 6379
		public const int IsActiveFieldNumber = 5;

		// Token: 0x040018EC RID: 6380
		private static readonly bool IsActiveDefaultValue = false;

		// Token: 0x040018ED RID: 6381
		private bool isActive_;

		// Token: 0x040018EE RID: 6382
		public const int PlayerCountFieldNumber = 6;

		// Token: 0x040018EF RID: 6383
		private static readonly uint PlayerCountDefaultValue = 0U;

		// Token: 0x040018F0 RID: 6384
		private uint playerCount_;

		// Token: 0x040018F1 RID: 6385
		public const int MonsterCountFieldNumber = 7;

		// Token: 0x040018F2 RID: 6386
		private static readonly uint MonsterCountDefaultValue = 0U;

		// Token: 0x040018F3 RID: 6387
		private uint monsterCount_;

		// Token: 0x040018F4 RID: 6388
		public const int AnnFieldNumber = 8;

		// Token: 0x040018F5 RID: 6389
		private static readonly uint AnnDefaultValue = 0U;

		// Token: 0x040018F6 RID: 6390
		private uint ann_;

		// Token: 0x040018F7 RID: 6391
		public const int AcdidFieldNumber = 9;

		// Token: 0x040018F8 RID: 6392
		private static readonly int AcdidDefaultValue = 0;

		// Token: 0x040018F9 RID: 6393
		private int acdid_;

		// Token: 0x040018FA RID: 6394
		public const int MonsterSpawnAcdsFieldNumber = 10;

		// Token: 0x040018FB RID: 6395
		private static readonly FieldCodec<int> _repeated_monsterSpawnAcds_codec = FieldCodec.ForInt32(80U);

		// Token: 0x040018FC RID: 6396
		private readonly RepeatedField<int> monsterSpawnAcds_ = new RepeatedField<int>();

		// Token: 0x040018FD RID: 6397
		public const int MonsterVisitingAcdsFieldNumber = 11;

		// Token: 0x040018FE RID: 6398
		private static readonly FieldCodec<int> _repeated_monsterVisitingAcds_codec = FieldCodec.ForInt32(88U);

		// Token: 0x040018FF RID: 6399
		private readonly RepeatedField<int> monsterVisitingAcds_ = new RepeatedField<int>();
	}
}
