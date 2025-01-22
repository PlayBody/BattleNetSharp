using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200037B RID: 891
	public sealed class BGSServiceOptions : IMessage<BGSServiceOptions>, IMessage, IEquatable<BGSServiceOptions>, IDeepCloneable<BGSServiceOptions>, IBufferMessage
	{
		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x0015F2F8 File Offset: 0x0015D4F8
		[DebuggerNonUserCode]
		public static MessageParser<BGSServiceOptions> Parser
		{
			get
			{
				return BGSServiceOptions._parser;
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x0015F310 File Offset: 0x0015D510
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServiceOptionsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x0015F334 File Offset: 0x0015D534
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BGSServiceOptions.Descriptor;
			}
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x0015F34B File Offset: 0x0015D54B
		[DebuggerNonUserCode]
		public BGSServiceOptions()
		{
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x0015F358 File Offset: 0x0015D558
		[DebuggerNonUserCode]
		public BGSServiceOptions(BGSServiceOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.descriptorName_ = other.descriptorName_;
			this.topic_ = other.topic_;
			this.customSelectShard_ = other.customSelectShard_;
			this.version_ = other.version_;
			this.shardName_ = other.shardName_;
			this.resolveClientInstance_ = other.resolveClientInstance_;
			this.type_ = other.type_;
			this.apiType_ = other.apiType_;
			this.isGlobal_ = other.isGlobal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x0015F3F8 File Offset: 0x0015D5F8
		[DebuggerNonUserCode]
		public BGSServiceOptions Clone()
		{
			return new BGSServiceOptions(this);
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06005ACD RID: 23245 RVA: 0x0015F410 File Offset: 0x0015D610
		// (set) Token: 0x06005ACE RID: 23246 RVA: 0x0015F431 File Offset: 0x0015D631
		[DebuggerNonUserCode]
		public string DescriptorName
		{
			get
			{
				return this.descriptorName_ ?? BGSServiceOptions.DescriptorNameDefaultValue;
			}
			set
			{
				this.descriptorName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06005ACF RID: 23247 RVA: 0x0015F448 File Offset: 0x0015D648
		[DebuggerNonUserCode]
		public bool HasDescriptorName
		{
			get
			{
				return this.descriptorName_ != null;
			}
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x0015F463 File Offset: 0x0015D663
		[DebuggerNonUserCode]
		public void ClearDescriptorName()
		{
			this.descriptorName_ = null;
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06005AD1 RID: 23249 RVA: 0x0015F470 File Offset: 0x0015D670
		// (set) Token: 0x06005AD2 RID: 23250 RVA: 0x0015F491 File Offset: 0x0015D691
		[DebuggerNonUserCode]
		public string Topic
		{
			get
			{
				return this.topic_ ?? BGSServiceOptions.TopicDefaultValue;
			}
			set
			{
				this.topic_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06005AD3 RID: 23251 RVA: 0x0015F4A8 File Offset: 0x0015D6A8
		[DebuggerNonUserCode]
		public bool HasTopic
		{
			get
			{
				return this.topic_ != null;
			}
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x0015F4C3 File Offset: 0x0015D6C3
		[DebuggerNonUserCode]
		public void ClearTopic()
		{
			this.topic_ = null;
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06005AD5 RID: 23253 RVA: 0x0015F4D0 File Offset: 0x0015D6D0
		// (set) Token: 0x06005AD6 RID: 23254 RVA: 0x0015F501 File Offset: 0x0015D701
		[DebuggerNonUserCode]
		public bool CustomSelectShard
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool customSelectShardDefaultValue;
				if (flag)
				{
					customSelectShardDefaultValue = this.customSelectShard_;
				}
				else
				{
					customSelectShardDefaultValue = BGSServiceOptions.CustomSelectShardDefaultValue;
				}
				return customSelectShardDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.customSelectShard_ = value;
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x0015F51C File Offset: 0x0015D71C
		[DebuggerNonUserCode]
		public bool HasCustomSelectShard
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x0015F539 File Offset: 0x0015D739
		[DebuggerNonUserCode]
		public void ClearCustomSelectShard()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06005AD9 RID: 23257 RVA: 0x0015F54C File Offset: 0x0015D74C
		// (set) Token: 0x06005ADA RID: 23258 RVA: 0x0015F57D File Offset: 0x0015D77D
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = BGSServiceOptions.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.version_ = value;
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06005ADB RID: 23259 RVA: 0x0015F598 File Offset: 0x0015D798
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x0015F5B5 File Offset: 0x0015D7B5
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06005ADD RID: 23261 RVA: 0x0015F5C8 File Offset: 0x0015D7C8
		// (set) Token: 0x06005ADE RID: 23262 RVA: 0x0015F5E9 File Offset: 0x0015D7E9
		[DebuggerNonUserCode]
		public string ShardName
		{
			get
			{
				return this.shardName_ ?? BGSServiceOptions.ShardNameDefaultValue;
			}
			set
			{
				this.shardName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06005ADF RID: 23263 RVA: 0x0015F600 File Offset: 0x0015D800
		[DebuggerNonUserCode]
		public bool HasShardName
		{
			get
			{
				return this.shardName_ != null;
			}
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x0015F61B File Offset: 0x0015D81B
		[DebuggerNonUserCode]
		public void ClearShardName()
		{
			this.shardName_ = null;
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06005AE1 RID: 23265 RVA: 0x0015F628 File Offset: 0x0015D828
		// (set) Token: 0x06005AE2 RID: 23266 RVA: 0x0015F659 File Offset: 0x0015D859
		[DebuggerNonUserCode]
		public bool ResolveClientInstance
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool resolveClientInstanceDefaultValue;
				if (flag)
				{
					resolveClientInstanceDefaultValue = this.resolveClientInstance_;
				}
				else
				{
					resolveClientInstanceDefaultValue = BGSServiceOptions.ResolveClientInstanceDefaultValue;
				}
				return resolveClientInstanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.resolveClientInstance_ = value;
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06005AE3 RID: 23267 RVA: 0x0015F674 File Offset: 0x0015D874
		[DebuggerNonUserCode]
		public bool HasResolveClientInstance
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x0015F691 File Offset: 0x0015D891
		[DebuggerNonUserCode]
		public void ClearResolveClientInstance()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06005AE5 RID: 23269 RVA: 0x0015F6A4 File Offset: 0x0015D8A4
		// (set) Token: 0x06005AE6 RID: 23270 RVA: 0x0015F6D5 File Offset: 0x0015D8D5
		[DebuggerNonUserCode]
		public BGSServiceOptions.Types.ServiceType Type
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				BGSServiceOptions.Types.ServiceType typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = BGSServiceOptions.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.type_ = value;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06005AE7 RID: 23271 RVA: 0x0015F6F0 File Offset: 0x0015D8F0
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x0015F70D File Offset: 0x0015D90D
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06005AE9 RID: 23273 RVA: 0x0015F720 File Offset: 0x0015D920
		// (set) Token: 0x06005AEA RID: 23274 RVA: 0x0015F741 File Offset: 0x0015D941
		[DebuggerNonUserCode]
		public string ApiType
		{
			get
			{
				return this.apiType_ ?? BGSServiceOptions.ApiTypeDefaultValue;
			}
			set
			{
				this.apiType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06005AEB RID: 23275 RVA: 0x0015F758 File Offset: 0x0015D958
		[DebuggerNonUserCode]
		public bool HasApiType
		{
			get
			{
				return this.apiType_ != null;
			}
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x0015F773 File Offset: 0x0015D973
		[DebuggerNonUserCode]
		public void ClearApiType()
		{
			this.apiType_ = null;
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06005AED RID: 23277 RVA: 0x0015F780 File Offset: 0x0015D980
		// (set) Token: 0x06005AEE RID: 23278 RVA: 0x0015F7B2 File Offset: 0x0015D9B2
		[DebuggerNonUserCode]
		public bool IsGlobal
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool isGlobalDefaultValue;
				if (flag)
				{
					isGlobalDefaultValue = this.isGlobal_;
				}
				else
				{
					isGlobalDefaultValue = BGSServiceOptions.IsGlobalDefaultValue;
				}
				return isGlobalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.isGlobal_ = value;
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x06005AEF RID: 23279 RVA: 0x0015F7CC File Offset: 0x0015D9CC
		[DebuggerNonUserCode]
		public bool HasIsGlobal
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x0015F7EA File Offset: 0x0015D9EA
		[DebuggerNonUserCode]
		public void ClearIsGlobal()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x0015F7FC File Offset: 0x0015D9FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BGSServiceOptions);
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x0015F81C File Offset: 0x0015DA1C
		[DebuggerNonUserCode]
		public bool Equals(BGSServiceOptions other)
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
					bool flag4 = this.DescriptorName != other.DescriptorName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Topic != other.Topic;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CustomSelectShard != other.CustomSelectShard;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Version != other.Version;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ShardName != other.ShardName;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ResolveClientInstance != other.ResolveClientInstance;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Type != other.Type;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ApiType != other.ApiType;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.IsGlobal != other.IsGlobal;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06005AF3 RID: 23283 RVA: 0x0015F960 File Offset: 0x0015DB60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDescriptorName = this.HasDescriptorName;
			if (hasDescriptorName)
			{
				num ^= this.DescriptorName.GetHashCode();
			}
			bool hasTopic = this.HasTopic;
			if (hasTopic)
			{
				num ^= this.Topic.GetHashCode();
			}
			bool hasCustomSelectShard = this.HasCustomSelectShard;
			if (hasCustomSelectShard)
			{
				num ^= this.CustomSelectShard.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasShardName = this.HasShardName;
			if (hasShardName)
			{
				num ^= this.ShardName.GetHashCode();
			}
			bool hasResolveClientInstance = this.HasResolveClientInstance;
			if (hasResolveClientInstance)
			{
				num ^= this.ResolveClientInstance.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasApiType = this.HasApiType;
			if (hasApiType)
			{
				num ^= this.ApiType.GetHashCode();
			}
			bool hasIsGlobal = this.HasIsGlobal;
			if (hasIsGlobal)
			{
				num ^= this.IsGlobal.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x0015FA94 File Offset: 0x0015DC94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x0015FAAC File Offset: 0x0015DCAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x0015FAB8 File Offset: 0x0015DCB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDescriptorName = this.HasDescriptorName;
			if (hasDescriptorName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.DescriptorName);
			}
			bool hasTopic = this.HasTopic;
			if (hasTopic)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Topic);
			}
			bool hasCustomSelectShard = this.HasCustomSelectShard;
			if (hasCustomSelectShard)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CustomSelectShard);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Version);
			}
			bool hasShardName = this.HasShardName;
			if (hasShardName)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ShardName);
			}
			bool hasResolveClientInstance = this.HasResolveClientInstance;
			if (hasResolveClientInstance)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ResolveClientInstance);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Type);
			}
			bool hasApiType = this.HasApiType;
			if (hasApiType)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ApiType);
			}
			bool hasIsGlobal = this.HasIsGlobal;
			if (hasIsGlobal)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsGlobal);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x0015FC20 File Offset: 0x0015DE20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDescriptorName = this.HasDescriptorName;
			if (hasDescriptorName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DescriptorName);
			}
			bool hasTopic = this.HasTopic;
			if (hasTopic)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Topic);
			}
			bool hasCustomSelectShard = this.HasCustomSelectShard;
			if (hasCustomSelectShard)
			{
				num += 2;
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool hasShardName = this.HasShardName;
			if (hasShardName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ShardName);
			}
			bool hasResolveClientInstance = this.HasResolveClientInstance;
			if (hasResolveClientInstance)
			{
				num += 2;
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			bool hasApiType = this.HasApiType;
			if (hasApiType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ApiType);
			}
			bool hasIsGlobal = this.HasIsGlobal;
			if (hasIsGlobal)
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

		// Token: 0x06005AF8 RID: 23288 RVA: 0x0015FD3C File Offset: 0x0015DF3C
		[DebuggerNonUserCode]
		public void MergeFrom(BGSServiceOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDescriptorName = other.HasDescriptorName;
				if (hasDescriptorName)
				{
					this.DescriptorName = other.DescriptorName;
				}
				bool hasTopic = other.HasTopic;
				if (hasTopic)
				{
					this.Topic = other.Topic;
				}
				bool hasCustomSelectShard = other.HasCustomSelectShard;
				if (hasCustomSelectShard)
				{
					this.CustomSelectShard = other.CustomSelectShard;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasShardName = other.HasShardName;
				if (hasShardName)
				{
					this.ShardName = other.ShardName;
				}
				bool hasResolveClientInstance = other.HasResolveClientInstance;
				if (hasResolveClientInstance)
				{
					this.ResolveClientInstance = other.ResolveClientInstance;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasApiType = other.HasApiType;
				if (hasApiType)
				{
					this.ApiType = other.ApiType;
				}
				bool hasIsGlobal = other.HasIsGlobal;
				if (hasIsGlobal)
				{
					this.IsGlobal = other.IsGlobal;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x0015FE5C File Offset: 0x0015E05C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x0015FE68 File Offset: 0x0015E068
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_006B;
							}
							this.Topic = input.ReadString();
						}
						else
						{
							this.DescriptorName = input.ReadString();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							goto IL_006B;
						}
						this.Version = input.ReadUInt32();
					}
					else
					{
						this.CustomSelectShard = input.ReadBool();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_006B;
						}
						this.ResolveClientInstance = input.ReadBool();
					}
					else
					{
						this.ShardName = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						if (num3 != 72U)
						{
							goto IL_006B;
						}
						this.IsGlobal = input.ReadBool();
					}
					else
					{
						this.ApiType = input.ReadString();
					}
				}
				else
				{
					this.Type = (BGSServiceOptions.Types.ServiceType)input.ReadEnum();
				}
				continue;
				IL_006B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400295F RID: 10591
		private static readonly MessageParser<BGSServiceOptions> _parser = new MessageParser<BGSServiceOptions>(() => new BGSServiceOptions());

		// Token: 0x04002960 RID: 10592
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002961 RID: 10593
		private int _hasBits0;

		// Token: 0x04002962 RID: 10594
		public const int DescriptorNameFieldNumber = 1;

		// Token: 0x04002963 RID: 10595
		private static readonly string DescriptorNameDefaultValue = "";

		// Token: 0x04002964 RID: 10596
		private string descriptorName_;

		// Token: 0x04002965 RID: 10597
		public const int TopicFieldNumber = 2;

		// Token: 0x04002966 RID: 10598
		private static readonly string TopicDefaultValue = "";

		// Token: 0x04002967 RID: 10599
		private string topic_;

		// Token: 0x04002968 RID: 10600
		public const int CustomSelectShardFieldNumber = 3;

		// Token: 0x04002969 RID: 10601
		private static readonly bool CustomSelectShardDefaultValue = false;

		// Token: 0x0400296A RID: 10602
		private bool customSelectShard_;

		// Token: 0x0400296B RID: 10603
		public const int VersionFieldNumber = 4;

		// Token: 0x0400296C RID: 10604
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x0400296D RID: 10605
		private uint version_;

		// Token: 0x0400296E RID: 10606
		public const int ShardNameFieldNumber = 5;

		// Token: 0x0400296F RID: 10607
		private static readonly string ShardNameDefaultValue = "";

		// Token: 0x04002970 RID: 10608
		private string shardName_;

		// Token: 0x04002971 RID: 10609
		public const int ResolveClientInstanceFieldNumber = 6;

		// Token: 0x04002972 RID: 10610
		private static readonly bool ResolveClientInstanceDefaultValue = false;

		// Token: 0x04002973 RID: 10611
		private bool resolveClientInstance_;

		// Token: 0x04002974 RID: 10612
		public const int TypeFieldNumber = 7;

		// Token: 0x04002975 RID: 10613
		private static readonly BGSServiceOptions.Types.ServiceType TypeDefaultValue = BGSServiceOptions.Types.ServiceType.Rpc;

		// Token: 0x04002976 RID: 10614
		private BGSServiceOptions.Types.ServiceType type_;

		// Token: 0x04002977 RID: 10615
		public const int ApiTypeFieldNumber = 8;

		// Token: 0x04002978 RID: 10616
		private static readonly string ApiTypeDefaultValue = "";

		// Token: 0x04002979 RID: 10617
		private string apiType_;

		// Token: 0x0400297A RID: 10618
		public const int IsGlobalFieldNumber = 9;

		// Token: 0x0400297B RID: 10619
		private static readonly bool IsGlobalDefaultValue = false;

		// Token: 0x0400297C RID: 10620
		private bool isGlobal_;

		// Token: 0x02000E50 RID: 3664
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001494 RID: 5268
			public enum ServiceType
			{
				// Token: 0x0400A4EB RID: 42219
				[OriginalName("SERVICE_TYPE_RPC")]
				Rpc,
				// Token: 0x0400A4EC RID: 42220
				[OriginalName("SERVICE_TYPE_RPC_DIRECT")]
				RpcDirect,
				// Token: 0x0400A4ED RID: 42221
				[OriginalName("SERVICE_TYPE_EVENT")]
				Event,
				// Token: 0x0400A4EE RID: 42222
				[OriginalName("SERVICE_TYPE_EVENT_BROADCAST")]
				EventBroadcast
			}
		}
	}
}
