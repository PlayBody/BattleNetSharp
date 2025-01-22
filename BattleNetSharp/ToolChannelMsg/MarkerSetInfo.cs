using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000088 RID: 136
	public sealed class MarkerSetInfo : IMessage<MarkerSetInfo>, IMessage, IEquatable<MarkerSetInfo>, IDeepCloneable<MarkerSetInfo>, IBufferMessage
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0002ECE4 File Offset: 0x0002CEE4
		[DebuggerNonUserCode]
		public static MessageParser<MarkerSetInfo> Parser
		{
			get
			{
				return MarkerSetInfo._parser;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0002ECFC File Offset: 0x0002CEFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[113];
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0002ED20 File Offset: 0x0002CF20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkerSetInfo.Descriptor;
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0002ED37 File Offset: 0x0002CF37
		[DebuggerNonUserCode]
		public MarkerSetInfo()
		{
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0002ED44 File Offset: 0x0002CF44
		[DebuggerNonUserCode]
		public MarkerSetInfo(MarkerSetInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.heightFieldCount_ = other.heightFieldCount_;
			this.maskTexturesSize_ = other.maskTexturesSize_;
			this.heightTexturesSize_ = other.heightTexturesSize_;
			this.flowMapTexturesSize_ = other.flowMapTexturesSize_;
			this.clutterBuffersSize_ = other.clutterBuffersSize_;
			this.indexBuffersSize_ = other.indexBuffersSize_;
			this.fogMaskBuffersSize_ = other.fogMaskBuffersSize_;
			this.oceanMaskBuffersSize_ = other.oceanMaskBuffersSize_;
			this.sphericalHarmonicSize_ = other.sphericalHarmonicSize_;
			this.vertexAoSize_ = other.vertexAoSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0002EDFC File Offset: 0x0002CFFC
		[DebuggerNonUserCode]
		public MarkerSetInfo Clone()
		{
			return new MarkerSetInfo(this);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0002EE14 File Offset: 0x0002D014
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0002EE45 File Offset: 0x0002D045
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = MarkerSetInfo.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0002EE60 File Offset: 0x0002D060
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0002EE7D File Offset: 0x0002D07D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0002EE90 File Offset: 0x0002D090
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0002EEC1 File Offset: 0x0002D0C1
		[DebuggerNonUserCode]
		public int HeightFieldCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int heightFieldCountDefaultValue;
				if (flag)
				{
					heightFieldCountDefaultValue = this.heightFieldCount_;
				}
				else
				{
					heightFieldCountDefaultValue = MarkerSetInfo.HeightFieldCountDefaultValue;
				}
				return heightFieldCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.heightFieldCount_ = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		[DebuggerNonUserCode]
		public bool HasHeightFieldCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0002EEF9 File Offset: 0x0002D0F9
		[DebuggerNonUserCode]
		public void ClearHeightFieldCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0002EF0C File Offset: 0x0002D10C
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x0002EF3D File Offset: 0x0002D13D
		[DebuggerNonUserCode]
		public uint MaskTexturesSize
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint maskTexturesSizeDefaultValue;
				if (flag)
				{
					maskTexturesSizeDefaultValue = this.maskTexturesSize_;
				}
				else
				{
					maskTexturesSizeDefaultValue = MarkerSetInfo.MaskTexturesSizeDefaultValue;
				}
				return maskTexturesSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.maskTexturesSize_ = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0002EF58 File Offset: 0x0002D158
		[DebuggerNonUserCode]
		public bool HasMaskTexturesSize
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0002EF75 File Offset: 0x0002D175
		[DebuggerNonUserCode]
		public void ClearMaskTexturesSize()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0002EF88 File Offset: 0x0002D188
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x0002EFB9 File Offset: 0x0002D1B9
		[DebuggerNonUserCode]
		public uint HeightTexturesSize
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint heightTexturesSizeDefaultValue;
				if (flag)
				{
					heightTexturesSizeDefaultValue = this.heightTexturesSize_;
				}
				else
				{
					heightTexturesSizeDefaultValue = MarkerSetInfo.HeightTexturesSizeDefaultValue;
				}
				return heightTexturesSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.heightTexturesSize_ = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0002EFD4 File Offset: 0x0002D1D4
		[DebuggerNonUserCode]
		public bool HasHeightTexturesSize
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0002EFF1 File Offset: 0x0002D1F1
		[DebuggerNonUserCode]
		public void ClearHeightTexturesSize()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0002F004 File Offset: 0x0002D204
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x0002F036 File Offset: 0x0002D236
		[DebuggerNonUserCode]
		public uint FlowMapTexturesSize
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint flowMapTexturesSizeDefaultValue;
				if (flag)
				{
					flowMapTexturesSizeDefaultValue = this.flowMapTexturesSize_;
				}
				else
				{
					flowMapTexturesSizeDefaultValue = MarkerSetInfo.FlowMapTexturesSizeDefaultValue;
				}
				return flowMapTexturesSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.flowMapTexturesSize_ = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0002F050 File Offset: 0x0002D250
		[DebuggerNonUserCode]
		public bool HasFlowMapTexturesSize
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0002F06E File Offset: 0x0002D26E
		[DebuggerNonUserCode]
		public void ClearFlowMapTexturesSize()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0002F080 File Offset: 0x0002D280
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0002F0B2 File Offset: 0x0002D2B2
		[DebuggerNonUserCode]
		public uint ClutterBuffersSize
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint clutterBuffersSizeDefaultValue;
				if (flag)
				{
					clutterBuffersSizeDefaultValue = this.clutterBuffersSize_;
				}
				else
				{
					clutterBuffersSizeDefaultValue = MarkerSetInfo.ClutterBuffersSizeDefaultValue;
				}
				return clutterBuffersSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.clutterBuffersSize_ = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0002F0CC File Offset: 0x0002D2CC
		[DebuggerNonUserCode]
		public bool HasClutterBuffersSize
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0002F0EA File Offset: 0x0002D2EA
		[DebuggerNonUserCode]
		public void ClearClutterBuffersSize()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0002F12E File Offset: 0x0002D32E
		[DebuggerNonUserCode]
		public uint IndexBuffersSize
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint indexBuffersSizeDefaultValue;
				if (flag)
				{
					indexBuffersSizeDefaultValue = this.indexBuffersSize_;
				}
				else
				{
					indexBuffersSizeDefaultValue = MarkerSetInfo.IndexBuffersSizeDefaultValue;
				}
				return indexBuffersSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.indexBuffersSize_ = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0002F148 File Offset: 0x0002D348
		[DebuggerNonUserCode]
		public bool HasIndexBuffersSize
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0002F166 File Offset: 0x0002D366
		[DebuggerNonUserCode]
		public void ClearIndexBuffersSize()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0002F178 File Offset: 0x0002D378
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0002F1AD File Offset: 0x0002D3AD
		[DebuggerNonUserCode]
		public uint FogMaskBuffersSize
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint fogMaskBuffersSizeDefaultValue;
				if (flag)
				{
					fogMaskBuffersSizeDefaultValue = this.fogMaskBuffersSize_;
				}
				else
				{
					fogMaskBuffersSizeDefaultValue = MarkerSetInfo.FogMaskBuffersSizeDefaultValue;
				}
				return fogMaskBuffersSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.fogMaskBuffersSize_ = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0002F1CC File Offset: 0x0002D3CC
		[DebuggerNonUserCode]
		public bool HasFogMaskBuffersSize
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0002F1ED File Offset: 0x0002D3ED
		[DebuggerNonUserCode]
		public void ClearFogMaskBuffersSize()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0002F204 File Offset: 0x0002D404
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0002F239 File Offset: 0x0002D439
		[DebuggerNonUserCode]
		public uint OceanMaskBuffersSize
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint oceanMaskBuffersSizeDefaultValue;
				if (flag)
				{
					oceanMaskBuffersSizeDefaultValue = this.oceanMaskBuffersSize_;
				}
				else
				{
					oceanMaskBuffersSizeDefaultValue = MarkerSetInfo.OceanMaskBuffersSizeDefaultValue;
				}
				return oceanMaskBuffersSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.oceanMaskBuffersSize_ = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0002F258 File Offset: 0x0002D458
		[DebuggerNonUserCode]
		public bool HasOceanMaskBuffersSize
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0002F279 File Offset: 0x0002D479
		[DebuggerNonUserCode]
		public void ClearOceanMaskBuffersSize()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0002F290 File Offset: 0x0002D490
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0002F2C5 File Offset: 0x0002D4C5
		[DebuggerNonUserCode]
		public uint SphericalHarmonicSize
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint sphericalHarmonicSizeDefaultValue;
				if (flag)
				{
					sphericalHarmonicSizeDefaultValue = this.sphericalHarmonicSize_;
				}
				else
				{
					sphericalHarmonicSizeDefaultValue = MarkerSetInfo.SphericalHarmonicSizeDefaultValue;
				}
				return sphericalHarmonicSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.sphericalHarmonicSize_ = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0002F2E4 File Offset: 0x0002D4E4
		[DebuggerNonUserCode]
		public bool HasSphericalHarmonicSize
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0002F305 File Offset: 0x0002D505
		[DebuggerNonUserCode]
		public void ClearSphericalHarmonicSize()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0002F31C File Offset: 0x0002D51C
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0002F351 File Offset: 0x0002D551
		[DebuggerNonUserCode]
		public uint VertexAoSize
		{
			get
			{
				bool flag = (this._hasBits0 & 1024) != 0;
				uint vertexAoSizeDefaultValue;
				if (flag)
				{
					vertexAoSizeDefaultValue = this.vertexAoSize_;
				}
				else
				{
					vertexAoSizeDefaultValue = MarkerSetInfo.VertexAoSizeDefaultValue;
				}
				return vertexAoSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1024;
				this.vertexAoSize_ = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0002F370 File Offset: 0x0002D570
		[DebuggerNonUserCode]
		public bool HasVertexAoSize
		{
			get
			{
				return (this._hasBits0 & 1024) != 0;
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0002F391 File Offset: 0x0002D591
		[DebuggerNonUserCode]
		public void ClearVertexAoSize()
		{
			this._hasBits0 &= -1025;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0002F3A8 File Offset: 0x0002D5A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkerSetInfo);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0002F3C8 File Offset: 0x0002D5C8
		[DebuggerNonUserCode]
		public bool Equals(MarkerSetInfo other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HeightFieldCount != other.HeightFieldCount;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MaskTexturesSize != other.MaskTexturesSize;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.HeightTexturesSize != other.HeightTexturesSize;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.FlowMapTexturesSize != other.FlowMapTexturesSize;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ClutterBuffersSize != other.ClutterBuffersSize;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.IndexBuffersSize != other.IndexBuffersSize;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.FogMaskBuffersSize != other.FogMaskBuffersSize;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.OceanMaskBuffersSize != other.OceanMaskBuffersSize;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.SphericalHarmonicSize != other.SphericalHarmonicSize;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.VertexAoSize != other.VertexAoSize;
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

		// Token: 0x06000C66 RID: 3174 RVA: 0x0002F548 File Offset: 0x0002D748
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasHeightFieldCount = this.HasHeightFieldCount;
			if (hasHeightFieldCount)
			{
				num ^= this.HeightFieldCount.GetHashCode();
			}
			bool hasMaskTexturesSize = this.HasMaskTexturesSize;
			if (hasMaskTexturesSize)
			{
				num ^= this.MaskTexturesSize.GetHashCode();
			}
			bool hasHeightTexturesSize = this.HasHeightTexturesSize;
			if (hasHeightTexturesSize)
			{
				num ^= this.HeightTexturesSize.GetHashCode();
			}
			bool hasFlowMapTexturesSize = this.HasFlowMapTexturesSize;
			if (hasFlowMapTexturesSize)
			{
				num ^= this.FlowMapTexturesSize.GetHashCode();
			}
			bool hasClutterBuffersSize = this.HasClutterBuffersSize;
			if (hasClutterBuffersSize)
			{
				num ^= this.ClutterBuffersSize.GetHashCode();
			}
			bool hasIndexBuffersSize = this.HasIndexBuffersSize;
			if (hasIndexBuffersSize)
			{
				num ^= this.IndexBuffersSize.GetHashCode();
			}
			bool hasFogMaskBuffersSize = this.HasFogMaskBuffersSize;
			if (hasFogMaskBuffersSize)
			{
				num ^= this.FogMaskBuffersSize.GetHashCode();
			}
			bool hasOceanMaskBuffersSize = this.HasOceanMaskBuffersSize;
			if (hasOceanMaskBuffersSize)
			{
				num ^= this.OceanMaskBuffersSize.GetHashCode();
			}
			bool hasSphericalHarmonicSize = this.HasSphericalHarmonicSize;
			if (hasSphericalHarmonicSize)
			{
				num ^= this.SphericalHarmonicSize.GetHashCode();
			}
			bool hasVertexAoSize = this.HasVertexAoSize;
			if (hasVertexAoSize)
			{
				num ^= this.VertexAoSize.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0002F6C4 File Offset: 0x0002D8C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0002F6DC File Offset: 0x0002D8DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0002F6E8 File Offset: 0x0002D8E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasHeightFieldCount = this.HasHeightFieldCount;
			if (hasHeightFieldCount)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HeightFieldCount);
			}
			bool hasMaskTexturesSize = this.HasMaskTexturesSize;
			if (hasMaskTexturesSize)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaskTexturesSize);
			}
			bool hasHeightTexturesSize = this.HasHeightTexturesSize;
			if (hasHeightTexturesSize)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HeightTexturesSize);
			}
			bool hasFlowMapTexturesSize = this.HasFlowMapTexturesSize;
			if (hasFlowMapTexturesSize)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.FlowMapTexturesSize);
			}
			bool hasClutterBuffersSize = this.HasClutterBuffersSize;
			if (hasClutterBuffersSize)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ClutterBuffersSize);
			}
			bool hasIndexBuffersSize = this.HasIndexBuffersSize;
			if (hasIndexBuffersSize)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IndexBuffersSize);
			}
			bool hasFogMaskBuffersSize = this.HasFogMaskBuffersSize;
			if (hasFogMaskBuffersSize)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.FogMaskBuffersSize);
			}
			bool hasOceanMaskBuffersSize = this.HasOceanMaskBuffersSize;
			if (hasOceanMaskBuffersSize)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.OceanMaskBuffersSize);
			}
			bool hasSphericalHarmonicSize = this.HasSphericalHarmonicSize;
			if (hasSphericalHarmonicSize)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.SphericalHarmonicSize);
			}
			bool hasVertexAoSize = this.HasVertexAoSize;
			if (hasVertexAoSize)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.VertexAoSize);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0002F898 File Offset: 0x0002DA98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasHeightFieldCount = this.HasHeightFieldCount;
			if (hasHeightFieldCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeightFieldCount);
			}
			bool hasMaskTexturesSize = this.HasMaskTexturesSize;
			if (hasMaskTexturesSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaskTexturesSize);
			}
			bool hasHeightTexturesSize = this.HasHeightTexturesSize;
			if (hasHeightTexturesSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeightTexturesSize);
			}
			bool hasFlowMapTexturesSize = this.HasFlowMapTexturesSize;
			if (hasFlowMapTexturesSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FlowMapTexturesSize);
			}
			bool hasClutterBuffersSize = this.HasClutterBuffersSize;
			if (hasClutterBuffersSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ClutterBuffersSize);
			}
			bool hasIndexBuffersSize = this.HasIndexBuffersSize;
			if (hasIndexBuffersSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IndexBuffersSize);
			}
			bool hasFogMaskBuffersSize = this.HasFogMaskBuffersSize;
			if (hasFogMaskBuffersSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FogMaskBuffersSize);
			}
			bool hasOceanMaskBuffersSize = this.HasOceanMaskBuffersSize;
			if (hasOceanMaskBuffersSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OceanMaskBuffersSize);
			}
			bool hasSphericalHarmonicSize = this.HasSphericalHarmonicSize;
			if (hasSphericalHarmonicSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SphericalHarmonicSize);
			}
			bool hasVertexAoSize = this.HasVertexAoSize;
			if (hasVertexAoSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.VertexAoSize);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0002FA14 File Offset: 0x0002DC14
		[DebuggerNonUserCode]
		public void MergeFrom(MarkerSetInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasHeightFieldCount = other.HasHeightFieldCount;
				if (hasHeightFieldCount)
				{
					this.HeightFieldCount = other.HeightFieldCount;
				}
				bool hasMaskTexturesSize = other.HasMaskTexturesSize;
				if (hasMaskTexturesSize)
				{
					this.MaskTexturesSize = other.MaskTexturesSize;
				}
				bool hasHeightTexturesSize = other.HasHeightTexturesSize;
				if (hasHeightTexturesSize)
				{
					this.HeightTexturesSize = other.HeightTexturesSize;
				}
				bool hasFlowMapTexturesSize = other.HasFlowMapTexturesSize;
				if (hasFlowMapTexturesSize)
				{
					this.FlowMapTexturesSize = other.FlowMapTexturesSize;
				}
				bool hasClutterBuffersSize = other.HasClutterBuffersSize;
				if (hasClutterBuffersSize)
				{
					this.ClutterBuffersSize = other.ClutterBuffersSize;
				}
				bool hasIndexBuffersSize = other.HasIndexBuffersSize;
				if (hasIndexBuffersSize)
				{
					this.IndexBuffersSize = other.IndexBuffersSize;
				}
				bool hasFogMaskBuffersSize = other.HasFogMaskBuffersSize;
				if (hasFogMaskBuffersSize)
				{
					this.FogMaskBuffersSize = other.FogMaskBuffersSize;
				}
				bool hasOceanMaskBuffersSize = other.HasOceanMaskBuffersSize;
				if (hasOceanMaskBuffersSize)
				{
					this.OceanMaskBuffersSize = other.OceanMaskBuffersSize;
				}
				bool hasSphericalHarmonicSize = other.HasSphericalHarmonicSize;
				if (hasSphericalHarmonicSize)
				{
					this.SphericalHarmonicSize = other.SphericalHarmonicSize;
				}
				bool hasVertexAoSize = other.HasVertexAoSize;
				if (hasVertexAoSize)
				{
					this.VertexAoSize = other.VertexAoSize;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0002FB6A File Offset: 0x0002DD6A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0002FB78 File Offset: 0x0002DD78
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
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_0087;
							}
							this.HeightFieldCount = input.ReadInt32();
						}
						else
						{
							this.SnoHandle = input.ReadInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_0087;
							}
							this.FlowMapTexturesSize = input.ReadUInt32();
						}
						else
						{
							this.HeightTexturesSize = input.ReadUInt32();
						}
					}
					else
					{
						this.MaskTexturesSize = input.ReadUInt32();
					}
				}
				else if (num3 <= 64U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							if (num3 != 64U)
							{
								goto IL_0087;
							}
							this.FogMaskBuffersSize = input.ReadUInt32();
						}
						else
						{
							this.IndexBuffersSize = input.ReadUInt32();
						}
					}
					else
					{
						this.ClutterBuffersSize = input.ReadUInt32();
					}
				}
				else if (num3 != 72U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_0087;
						}
						this.VertexAoSize = input.ReadUInt32();
					}
					else
					{
						this.SphericalHarmonicSize = input.ReadUInt32();
					}
				}
				else
				{
					this.OceanMaskBuffersSize = input.ReadUInt32();
				}
				continue;
				IL_0087:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040004E9 RID: 1257
		private static readonly MessageParser<MarkerSetInfo> _parser = new MessageParser<MarkerSetInfo>(() => new MarkerSetInfo());

		// Token: 0x040004EA RID: 1258
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004EB RID: 1259
		private int _hasBits0;

		// Token: 0x040004EC RID: 1260
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040004ED RID: 1261
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040004EE RID: 1262
		private int snoHandle_;

		// Token: 0x040004EF RID: 1263
		public const int HeightFieldCountFieldNumber = 2;

		// Token: 0x040004F0 RID: 1264
		private static readonly int HeightFieldCountDefaultValue = 0;

		// Token: 0x040004F1 RID: 1265
		private int heightFieldCount_;

		// Token: 0x040004F2 RID: 1266
		public const int MaskTexturesSizeFieldNumber = 3;

		// Token: 0x040004F3 RID: 1267
		private static readonly uint MaskTexturesSizeDefaultValue = 0U;

		// Token: 0x040004F4 RID: 1268
		private uint maskTexturesSize_;

		// Token: 0x040004F5 RID: 1269
		public const int HeightTexturesSizeFieldNumber = 4;

		// Token: 0x040004F6 RID: 1270
		private static readonly uint HeightTexturesSizeDefaultValue = 0U;

		// Token: 0x040004F7 RID: 1271
		private uint heightTexturesSize_;

		// Token: 0x040004F8 RID: 1272
		public const int FlowMapTexturesSizeFieldNumber = 5;

		// Token: 0x040004F9 RID: 1273
		private static readonly uint FlowMapTexturesSizeDefaultValue = 0U;

		// Token: 0x040004FA RID: 1274
		private uint flowMapTexturesSize_;

		// Token: 0x040004FB RID: 1275
		public const int ClutterBuffersSizeFieldNumber = 6;

		// Token: 0x040004FC RID: 1276
		private static readonly uint ClutterBuffersSizeDefaultValue = 0U;

		// Token: 0x040004FD RID: 1277
		private uint clutterBuffersSize_;

		// Token: 0x040004FE RID: 1278
		public const int IndexBuffersSizeFieldNumber = 7;

		// Token: 0x040004FF RID: 1279
		private static readonly uint IndexBuffersSizeDefaultValue = 0U;

		// Token: 0x04000500 RID: 1280
		private uint indexBuffersSize_;

		// Token: 0x04000501 RID: 1281
		public const int FogMaskBuffersSizeFieldNumber = 8;

		// Token: 0x04000502 RID: 1282
		private static readonly uint FogMaskBuffersSizeDefaultValue = 0U;

		// Token: 0x04000503 RID: 1283
		private uint fogMaskBuffersSize_;

		// Token: 0x04000504 RID: 1284
		public const int OceanMaskBuffersSizeFieldNumber = 9;

		// Token: 0x04000505 RID: 1285
		private static readonly uint OceanMaskBuffersSizeDefaultValue = 0U;

		// Token: 0x04000506 RID: 1286
		private uint oceanMaskBuffersSize_;

		// Token: 0x04000507 RID: 1287
		public const int SphericalHarmonicSizeFieldNumber = 10;

		// Token: 0x04000508 RID: 1288
		private static readonly uint SphericalHarmonicSizeDefaultValue = 0U;

		// Token: 0x04000509 RID: 1289
		private uint sphericalHarmonicSize_;

		// Token: 0x0400050A RID: 1290
		public const int VertexAoSizeFieldNumber = 11;

		// Token: 0x0400050B RID: 1291
		private static readonly uint VertexAoSizeDefaultValue = 0U;

		// Token: 0x0400050C RID: 1292
		private uint vertexAoSize_;
	}
}
