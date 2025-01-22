using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002BB RID: 699
	public sealed class ClanNewsItem : IMessage<ClanNewsItem>, IMessage, IEquatable<ClanNewsItem>, IDeepCloneable<ClanNewsItem>, IBufferMessage
	{
		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06004A70 RID: 19056 RVA: 0x0011D1D8 File Offset: 0x0011B3D8
		[DebuggerNonUserCode]
		public static MessageParser<ClanNewsItem> Parser
		{
			get
			{
				return ClanNewsItem._parser;
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06004A71 RID: 19057 RVA: 0x0011D1F0 File Offset: 0x0011B3F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x0011D214 File Offset: 0x0011B414
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanNewsItem.Descriptor;
			}
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x0011D22B File Offset: 0x0011B42B
		[DebuggerNonUserCode]
		public ClanNewsItem()
		{
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x0011D23C File Offset: 0x0011B43C
		[DebuggerNonUserCode]
		public ClanNewsItem(ClanNewsItem other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this.targetBnetAccountId_ = other.targetBnetAccountId_;
			this.originatorGameAccountId_ = other.originatorGameAccountId_;
			this.originatorBnetAccountId_ = other.originatorBnetAccountId_;
			this.creationTime_ = other.creationTime_;
			switch (other.DataCase)
			{
			case ClanNewsItem.DataOneofCase.AcvData:
				this.AcvData = other.AcvData.Clone();
				break;
			case ClanNewsItem.DataOneofCase.RankData:
				this.RankData = other.RankData.Clone();
				break;
			case ClanNewsItem.DataOneofCase.MotdData:
				this.MotdData = other.MotdData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0011D320 File Offset: 0x0011B520
		[DebuggerNonUserCode]
		public ClanNewsItem Clone()
		{
			return new ClanNewsItem(this);
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06004A76 RID: 19062 RVA: 0x0011D338 File Offset: 0x0011B538
		// (set) Token: 0x06004A77 RID: 19063 RVA: 0x0011D359 File Offset: 0x0011B559
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? ClanNewsItem.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06004A78 RID: 19064 RVA: 0x0011D370 File Offset: 0x0011B570
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x0011D38B File Offset: 0x0011B58B
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x0011D398 File Offset: 0x0011B598
		// (set) Token: 0x06004A7B RID: 19067 RVA: 0x0011D3C9 File Offset: 0x0011B5C9
		[DebuggerNonUserCode]
		public uint Type
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = ClanNewsItem.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.type_ = value;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06004A7C RID: 19068 RVA: 0x0011D3E4 File Offset: 0x0011B5E4
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x0011D401 File Offset: 0x0011B601
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06004A7E RID: 19070 RVA: 0x0011D414 File Offset: 0x0011B614
		// (set) Token: 0x06004A7F RID: 19071 RVA: 0x0011D445 File Offset: 0x0011B645
		[DebuggerNonUserCode]
		public uint TargetGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint targetGameAccountIdDefaultValue;
				if (flag)
				{
					targetGameAccountIdDefaultValue = this.targetGameAccountId_;
				}
				else
				{
					targetGameAccountIdDefaultValue = ClanNewsItem.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06004A80 RID: 19072 RVA: 0x0011D460 File Offset: 0x0011B660
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x0011D47D File Offset: 0x0011B67D
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x0011D490 File Offset: 0x0011B690
		// (set) Token: 0x06004A83 RID: 19075 RVA: 0x0011D4C2 File Offset: 0x0011B6C2
		[DebuggerNonUserCode]
		public uint TargetBnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint targetBnetAccountIdDefaultValue;
				if (flag)
				{
					targetBnetAccountIdDefaultValue = this.targetBnetAccountId_;
				}
				else
				{
					targetBnetAccountIdDefaultValue = ClanNewsItem.TargetBnetAccountIdDefaultValue;
				}
				return targetBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.targetBnetAccountId_ = value;
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x0011D4DC File Offset: 0x0011B6DC
		[DebuggerNonUserCode]
		public bool HasTargetBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x0011D4FA File Offset: 0x0011B6FA
		[DebuggerNonUserCode]
		public void ClearTargetBnetAccountId()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06004A86 RID: 19078 RVA: 0x0011D50C File Offset: 0x0011B70C
		// (set) Token: 0x06004A87 RID: 19079 RVA: 0x0011D53D File Offset: 0x0011B73D
		[DebuggerNonUserCode]
		public uint OriginatorGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint originatorGameAccountIdDefaultValue;
				if (flag)
				{
					originatorGameAccountIdDefaultValue = this.originatorGameAccountId_;
				}
				else
				{
					originatorGameAccountIdDefaultValue = ClanNewsItem.OriginatorGameAccountIdDefaultValue;
				}
				return originatorGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.originatorGameAccountId_ = value;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06004A88 RID: 19080 RVA: 0x0011D558 File Offset: 0x0011B758
		[DebuggerNonUserCode]
		public bool HasOriginatorGameAccountId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x0011D575 File Offset: 0x0011B775
		[DebuggerNonUserCode]
		public void ClearOriginatorGameAccountId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06004A8A RID: 19082 RVA: 0x0011D588 File Offset: 0x0011B788
		// (set) Token: 0x06004A8B RID: 19083 RVA: 0x0011D5BA File Offset: 0x0011B7BA
		[DebuggerNonUserCode]
		public uint OriginatorBnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint originatorBnetAccountIdDefaultValue;
				if (flag)
				{
					originatorBnetAccountIdDefaultValue = this.originatorBnetAccountId_;
				}
				else
				{
					originatorBnetAccountIdDefaultValue = ClanNewsItem.OriginatorBnetAccountIdDefaultValue;
				}
				return originatorBnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.originatorBnetAccountId_ = value;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06004A8C RID: 19084 RVA: 0x0011D5D4 File Offset: 0x0011B7D4
		[DebuggerNonUserCode]
		public bool HasOriginatorBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x0011D5F2 File Offset: 0x0011B7F2
		[DebuggerNonUserCode]
		public void ClearOriginatorBnetAccountId()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06004A8E RID: 19086 RVA: 0x0011D604 File Offset: 0x0011B804
		// (set) Token: 0x06004A8F RID: 19087 RVA: 0x0011D635 File Offset: 0x0011B835
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = ClanNewsItem.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.creationTime_ = value;
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x0011D650 File Offset: 0x0011B850
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x0011D66D File Offset: 0x0011B86D
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x0011D680 File Offset: 0x0011B880
		// (set) Token: 0x06004A93 RID: 19091 RVA: 0x0011D6A9 File Offset: 0x0011B8A9
		[DebuggerNonUserCode]
		public ClanAchievementNewsData AcvData
		{
			get
			{
				return (this.dataCase_ == ClanNewsItem.DataOneofCase.AcvData) ? ((ClanAchievementNewsData)this.data_) : null;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClanNewsItem.DataOneofCase.None : ClanNewsItem.DataOneofCase.AcvData);
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x0011D6C0 File Offset: 0x0011B8C0
		// (set) Token: 0x06004A95 RID: 19093 RVA: 0x0011D6E9 File Offset: 0x0011B8E9
		[DebuggerNonUserCode]
		public ClanRankNewsData RankData
		{
			get
			{
				return (this.dataCase_ == ClanNewsItem.DataOneofCase.RankData) ? ((ClanRankNewsData)this.data_) : null;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClanNewsItem.DataOneofCase.None : ClanNewsItem.DataOneofCase.RankData);
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x0011D700 File Offset: 0x0011B900
		// (set) Token: 0x06004A97 RID: 19095 RVA: 0x0011D729 File Offset: 0x0011B929
		[DebuggerNonUserCode]
		public ClanMotdNewsData MotdData
		{
			get
			{
				return (this.dataCase_ == ClanNewsItem.DataOneofCase.MotdData) ? ((ClanMotdNewsData)this.data_) : null;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? ClanNewsItem.DataOneofCase.None : ClanNewsItem.DataOneofCase.MotdData);
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x0011D740 File Offset: 0x0011B940
		[DebuggerNonUserCode]
		public ClanNewsItem.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x0011D758 File Offset: 0x0011B958
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.dataCase_ = ClanNewsItem.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x0011D76C File Offset: 0x0011B96C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanNewsItem);
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x0011D78C File Offset: 0x0011B98C
		[DebuggerNonUserCode]
		public bool Equals(ClanNewsItem other)
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
						bool flag5 = this.Type != other.Type;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TargetGameAccountId != other.TargetGameAccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TargetBnetAccountId != other.TargetBnetAccountId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.OriginatorGameAccountId != other.OriginatorGameAccountId;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.OriginatorBnetAccountId != other.OriginatorBnetAccountId;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.CreationTime != other.CreationTime;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.AcvData, other.AcvData);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.RankData, other.RankData);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.MotdData, other.MotdData);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.DataCase != other.DataCase;
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

		// Token: 0x06004A9C RID: 19100 RVA: 0x0011D914 File Offset: 0x0011BB14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
			bool hasTargetBnetAccountId = this.HasTargetBnetAccountId;
			if (hasTargetBnetAccountId)
			{
				num ^= this.TargetBnetAccountId.GetHashCode();
			}
			bool hasOriginatorGameAccountId = this.HasOriginatorGameAccountId;
			if (hasOriginatorGameAccountId)
			{
				num ^= this.OriginatorGameAccountId.GetHashCode();
			}
			bool hasOriginatorBnetAccountId = this.HasOriginatorBnetAccountId;
			if (hasOriginatorBnetAccountId)
			{
				num ^= this.OriginatorBnetAccountId.GetHashCode();
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool flag = this.dataCase_ == ClanNewsItem.DataOneofCase.AcvData;
			if (flag)
			{
				num ^= this.AcvData.GetHashCode();
			}
			bool flag2 = this.dataCase_ == ClanNewsItem.DataOneofCase.RankData;
			if (flag2)
			{
				num ^= this.RankData.GetHashCode();
			}
			bool flag3 = this.dataCase_ == ClanNewsItem.DataOneofCase.MotdData;
			if (flag3)
			{
				num ^= this.MotdData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x0011DA70 File Offset: 0x0011BC70
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x0011DA88 File Offset: 0x0011BC88
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x0011DA94 File Offset: 0x0011BC94
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Type);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool hasOriginatorGameAccountId = this.HasOriginatorGameAccountId;
			if (hasOriginatorGameAccountId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OriginatorGameAccountId);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag = this.dataCase_ == ClanNewsItem.DataOneofCase.AcvData;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.AcvData);
			}
			bool flag2 = this.dataCase_ == ClanNewsItem.DataOneofCase.RankData;
			if (flag2)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RankData);
			}
			bool flag3 = this.dataCase_ == ClanNewsItem.DataOneofCase.MotdData;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MotdData);
			}
			bool hasTargetBnetAccountId = this.HasTargetBnetAccountId;
			if (hasTargetBnetAccountId)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.TargetBnetAccountId);
			}
			bool hasOriginatorBnetAccountId = this.HasOriginatorBnetAccountId;
			if (hasOriginatorBnetAccountId)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.OriginatorBnetAccountId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x0011DC2C File Offset: 0x0011BE2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
			bool hasTargetBnetAccountId = this.HasTargetBnetAccountId;
			if (hasTargetBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetBnetAccountId);
			}
			bool hasOriginatorGameAccountId = this.HasOriginatorGameAccountId;
			if (hasOriginatorGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OriginatorGameAccountId);
			}
			bool hasOriginatorBnetAccountId = this.HasOriginatorBnetAccountId;
			if (hasOriginatorBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OriginatorBnetAccountId);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool flag = this.dataCase_ == ClanNewsItem.DataOneofCase.AcvData;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AcvData);
			}
			bool flag2 = this.dataCase_ == ClanNewsItem.DataOneofCase.RankData;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RankData);
			}
			bool flag3 = this.dataCase_ == ClanNewsItem.DataOneofCase.MotdData;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotdData);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x0011DD94 File Offset: 0x0011BF94
		[DebuggerNonUserCode]
		public void MergeFrom(ClanNewsItem other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				bool hasTargetBnetAccountId = other.HasTargetBnetAccountId;
				if (hasTargetBnetAccountId)
				{
					this.TargetBnetAccountId = other.TargetBnetAccountId;
				}
				bool hasOriginatorGameAccountId = other.HasOriginatorGameAccountId;
				if (hasOriginatorGameAccountId)
				{
					this.OriginatorGameAccountId = other.OriginatorGameAccountId;
				}
				bool hasOriginatorBnetAccountId = other.HasOriginatorBnetAccountId;
				if (hasOriginatorBnetAccountId)
				{
					this.OriginatorBnetAccountId = other.OriginatorBnetAccountId;
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				switch (other.DataCase)
				{
				case ClanNewsItem.DataOneofCase.AcvData:
				{
					bool flag2 = this.AcvData == null;
					if (flag2)
					{
						this.AcvData = new ClanAchievementNewsData();
					}
					this.AcvData.MergeFrom(other.AcvData);
					break;
				}
				case ClanNewsItem.DataOneofCase.RankData:
				{
					bool flag3 = this.RankData == null;
					if (flag3)
					{
						this.RankData = new ClanRankNewsData();
					}
					this.RankData.MergeFrom(other.RankData);
					break;
				}
				case ClanNewsItem.DataOneofCase.MotdData:
				{
					bool flag4 = this.MotdData == null;
					if (flag4)
					{
						this.MotdData = new ClanMotdNewsData();
					}
					this.MotdData.MergeFrom(other.MotdData);
					break;
				}
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x0011DF37 File Offset: 0x0011C137
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x0011DF44 File Offset: 0x0011C144
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 10U)
						{
							if (num3 != 16U)
							{
								goto IL_007B;
							}
							this.Type = input.ReadUInt32();
						}
						else
						{
							this.Id = input.ReadString();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_007B;
							}
							this.CreationTime = input.ReadUInt64();
						}
						else
						{
							this.OriginatorGameAccountId = input.ReadUInt32();
						}
					}
					else
					{
						this.TargetGameAccountId = input.ReadUInt32();
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_007B;
						}
						ClanRankNewsData clanRankNewsData = new ClanRankNewsData();
						bool flag = this.dataCase_ == ClanNewsItem.DataOneofCase.RankData;
						if (flag)
						{
							clanRankNewsData.MergeFrom(this.RankData);
						}
						input.ReadMessage(clanRankNewsData);
						this.RankData = clanRankNewsData;
					}
					else
					{
						ClanAchievementNewsData clanAchievementNewsData = new ClanAchievementNewsData();
						bool flag2 = this.dataCase_ == ClanNewsItem.DataOneofCase.AcvData;
						if (flag2)
						{
							clanAchievementNewsData.MergeFrom(this.AcvData);
						}
						input.ReadMessage(clanAchievementNewsData);
						this.AcvData = clanAchievementNewsData;
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 72U)
					{
						if (num3 != 80U)
						{
							goto IL_007B;
						}
						this.OriginatorBnetAccountId = input.ReadUInt32();
					}
					else
					{
						this.TargetBnetAccountId = input.ReadUInt32();
					}
				}
				else
				{
					ClanMotdNewsData clanMotdNewsData = new ClanMotdNewsData();
					bool flag3 = this.dataCase_ == ClanNewsItem.DataOneofCase.MotdData;
					if (flag3)
					{
						clanMotdNewsData.MergeFrom(this.MotdData);
					}
					input.ReadMessage(clanMotdNewsData);
					this.MotdData = clanMotdNewsData;
				}
				continue;
				IL_007B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002140 RID: 8512
		private static readonly MessageParser<ClanNewsItem> _parser = new MessageParser<ClanNewsItem>(() => new ClanNewsItem());

		// Token: 0x04002141 RID: 8513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002142 RID: 8514
		private int _hasBits0;

		// Token: 0x04002143 RID: 8515
		public const int IdFieldNumber = 1;

		// Token: 0x04002144 RID: 8516
		private static readonly string IdDefaultValue = "";

		// Token: 0x04002145 RID: 8517
		private string id_;

		// Token: 0x04002146 RID: 8518
		public const int TypeFieldNumber = 2;

		// Token: 0x04002147 RID: 8519
		private static readonly uint TypeDefaultValue = 0U;

		// Token: 0x04002148 RID: 8520
		private uint type_;

		// Token: 0x04002149 RID: 8521
		public const int TargetGameAccountIdFieldNumber = 3;

		// Token: 0x0400214A RID: 8522
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x0400214B RID: 8523
		private uint targetGameAccountId_;

		// Token: 0x0400214C RID: 8524
		public const int TargetBnetAccountIdFieldNumber = 9;

		// Token: 0x0400214D RID: 8525
		private static readonly uint TargetBnetAccountIdDefaultValue = 0U;

		// Token: 0x0400214E RID: 8526
		private uint targetBnetAccountId_;

		// Token: 0x0400214F RID: 8527
		public const int OriginatorGameAccountIdFieldNumber = 4;

		// Token: 0x04002150 RID: 8528
		private static readonly uint OriginatorGameAccountIdDefaultValue = 0U;

		// Token: 0x04002151 RID: 8529
		private uint originatorGameAccountId_;

		// Token: 0x04002152 RID: 8530
		public const int OriginatorBnetAccountIdFieldNumber = 10;

		// Token: 0x04002153 RID: 8531
		private static readonly uint OriginatorBnetAccountIdDefaultValue = 0U;

		// Token: 0x04002154 RID: 8532
		private uint originatorBnetAccountId_;

		// Token: 0x04002155 RID: 8533
		public const int CreationTimeFieldNumber = 5;

		// Token: 0x04002156 RID: 8534
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04002157 RID: 8535
		private ulong creationTime_;

		// Token: 0x04002158 RID: 8536
		public const int AcvDataFieldNumber = 6;

		// Token: 0x04002159 RID: 8537
		public const int RankDataFieldNumber = 7;

		// Token: 0x0400215A RID: 8538
		public const int MotdDataFieldNumber = 8;

		// Token: 0x0400215B RID: 8539
		private object data_;

		// Token: 0x0400215C RID: 8540
		private ClanNewsItem.DataOneofCase dataCase_ = ClanNewsItem.DataOneofCase.None;

		// Token: 0x02000DD0 RID: 3536
		public enum DataOneofCase
		{
			// Token: 0x04009536 RID: 38198
			None,
			// Token: 0x04009537 RID: 38199
			AcvData = 6,
			// Token: 0x04009538 RID: 38200
			RankData,
			// Token: 0x04009539 RID: 38201
			MotdData
		}
	}
}
