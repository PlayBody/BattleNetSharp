using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000082 RID: 130
	public sealed class AppearanceGeometryInfo : IMessage<AppearanceGeometryInfo>, IMessage, IEquatable<AppearanceGeometryInfo>, IDeepCloneable<AppearanceGeometryInfo>, IBufferMessage
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002BEDC File Offset: 0x0002A0DC
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceGeometryInfo> Parser
		{
			get
			{
				return AppearanceGeometryInfo._parser;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0002BEF4 File Offset: 0x0002A0F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[107];
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0002BF18 File Offset: 0x0002A118
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceGeometryInfo.Descriptor;
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0002BF2F File Offset: 0x0002A12F
		[DebuggerNonUserCode]
		public AppearanceGeometryInfo()
		{
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0002BF44 File Offset: 0x0002A144
		[DebuggerNonUserCode]
		public AppearanceGeometryInfo(AppearanceGeometryInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.surface_ = other.surface_;
			this.bones_ = other.bones_;
			this.chunks_ = other.chunks_.Clone();
			this.totals_ = ((other.totals_ != null) ? other.totals_.Clone() : null);
			this.lodTotals_ = ((other.lodTotals_ != null) ? other.lodTotals_.Clone() : null);
			this.vertexAndIndexBufferSize_ = other.vertexAndIndexBufferSize_;
			this.lodVertexAndIndexBufferSize_ = other.lodVertexAndIndexBufferSize_;
			this.collisionSize_ = other.collisionSize_;
			this.heightFieldCollisionSize_ = other.heightFieldCollisionSize_;
			this.sphericalHarmonicSize_ = other.sphericalHarmonicSize_;
			this.octreeSize_ = other.octreeSize_;
			this.instanceVertexAOSize_ = other.instanceVertexAOSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0002C038 File Offset: 0x0002A238
		[DebuggerNonUserCode]
		public AppearanceGeometryInfo Clone()
		{
			return new AppearanceGeometryInfo(this);
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002C050 File Offset: 0x0002A250
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x0002C081 File Offset: 0x0002A281
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
					snoHandleDefaultValue = AppearanceGeometryInfo.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0002C09C File Offset: 0x0002A29C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0002C0B9 File Offset: 0x0002A2B9
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002C0CC File Offset: 0x0002A2CC
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0002C0FD File Offset: 0x0002A2FD
		[DebuggerNonUserCode]
		public float Surface
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float surfaceDefaultValue;
				if (flag)
				{
					surfaceDefaultValue = this.surface_;
				}
				else
				{
					surfaceDefaultValue = AppearanceGeometryInfo.SurfaceDefaultValue;
				}
				return surfaceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.surface_ = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0002C118 File Offset: 0x0002A318
		[DebuggerNonUserCode]
		public bool HasSurface
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0002C135 File Offset: 0x0002A335
		[DebuggerNonUserCode]
		public void ClearSurface()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0002C148 File Offset: 0x0002A348
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x0002C179 File Offset: 0x0002A379
		[DebuggerNonUserCode]
		public int Bones
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int bonesDefaultValue;
				if (flag)
				{
					bonesDefaultValue = this.bones_;
				}
				else
				{
					bonesDefaultValue = AppearanceGeometryInfo.BonesDefaultValue;
				}
				return bonesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.bones_ = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0002C194 File Offset: 0x0002A394
		[DebuggerNonUserCode]
		public bool HasBones
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0002C1B1 File Offset: 0x0002A3B1
		[DebuggerNonUserCode]
		public void ClearBones()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0002C1C4 File Offset: 0x0002A3C4
		[DebuggerNonUserCode]
		public RepeatedField<ChunkGeometryInfo> Chunks
		{
			get
			{
				return this.chunks_;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0002C1DC File Offset: 0x0002A3DC
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0002C1F4 File Offset: 0x0002A3F4
		[DebuggerNonUserCode]
		public GeometryInfo Totals
		{
			get
			{
				return this.totals_;
			}
			set
			{
				this.totals_ = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0002C200 File Offset: 0x0002A400
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0002C218 File Offset: 0x0002A418
		[DebuggerNonUserCode]
		public GeometryInfo LodTotals
		{
			get
			{
				return this.lodTotals_;
			}
			set
			{
				this.lodTotals_ = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0002C224 File Offset: 0x0002A424
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0002C255 File Offset: 0x0002A455
		[DebuggerNonUserCode]
		public uint VertexAndIndexBufferSize
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint vertexAndIndexBufferSizeDefaultValue;
				if (flag)
				{
					vertexAndIndexBufferSizeDefaultValue = this.vertexAndIndexBufferSize_;
				}
				else
				{
					vertexAndIndexBufferSizeDefaultValue = AppearanceGeometryInfo.VertexAndIndexBufferSizeDefaultValue;
				}
				return vertexAndIndexBufferSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.vertexAndIndexBufferSize_ = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0002C270 File Offset: 0x0002A470
		[DebuggerNonUserCode]
		public bool HasVertexAndIndexBufferSize
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0002C28D File Offset: 0x0002A48D
		[DebuggerNonUserCode]
		public void ClearVertexAndIndexBufferSize()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x0002C2D2 File Offset: 0x0002A4D2
		[DebuggerNonUserCode]
		public uint LodVertexAndIndexBufferSize
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint lodVertexAndIndexBufferSizeDefaultValue;
				if (flag)
				{
					lodVertexAndIndexBufferSizeDefaultValue = this.lodVertexAndIndexBufferSize_;
				}
				else
				{
					lodVertexAndIndexBufferSizeDefaultValue = AppearanceGeometryInfo.LodVertexAndIndexBufferSizeDefaultValue;
				}
				return lodVertexAndIndexBufferSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.lodVertexAndIndexBufferSize_ = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0002C2EC File Offset: 0x0002A4EC
		[DebuggerNonUserCode]
		public bool HasLodVertexAndIndexBufferSize
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0002C30A File Offset: 0x0002A50A
		[DebuggerNonUserCode]
		public void ClearLodVertexAndIndexBufferSize()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0002C31C File Offset: 0x0002A51C
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0002C34E File Offset: 0x0002A54E
		[DebuggerNonUserCode]
		public uint CollisionSize
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint collisionSizeDefaultValue;
				if (flag)
				{
					collisionSizeDefaultValue = this.collisionSize_;
				}
				else
				{
					collisionSizeDefaultValue = AppearanceGeometryInfo.CollisionSizeDefaultValue;
				}
				return collisionSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.collisionSize_ = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0002C368 File Offset: 0x0002A568
		[DebuggerNonUserCode]
		public bool HasCollisionSize
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0002C386 File Offset: 0x0002A586
		[DebuggerNonUserCode]
		public void ClearCollisionSize()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0002C398 File Offset: 0x0002A598
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0002C3CA File Offset: 0x0002A5CA
		[DebuggerNonUserCode]
		public uint HeightFieldCollisionSize
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				uint heightFieldCollisionSizeDefaultValue;
				if (flag)
				{
					heightFieldCollisionSizeDefaultValue = this.heightFieldCollisionSize_;
				}
				else
				{
					heightFieldCollisionSizeDefaultValue = AppearanceGeometryInfo.HeightFieldCollisionSizeDefaultValue;
				}
				return heightFieldCollisionSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.heightFieldCollisionSize_ = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0002C3E4 File Offset: 0x0002A5E4
		[DebuggerNonUserCode]
		public bool HasHeightFieldCollisionSize
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0002C402 File Offset: 0x0002A602
		[DebuggerNonUserCode]
		public void ClearHeightFieldCollisionSize()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0002C414 File Offset: 0x0002A614
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0002C449 File Offset: 0x0002A649
		[DebuggerNonUserCode]
		public uint SphericalHarmonicSize
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				uint sphericalHarmonicSizeDefaultValue;
				if (flag)
				{
					sphericalHarmonicSizeDefaultValue = this.sphericalHarmonicSize_;
				}
				else
				{
					sphericalHarmonicSizeDefaultValue = AppearanceGeometryInfo.SphericalHarmonicSizeDefaultValue;
				}
				return sphericalHarmonicSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.sphericalHarmonicSize_ = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0002C468 File Offset: 0x0002A668
		[DebuggerNonUserCode]
		public bool HasSphericalHarmonicSize
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0002C489 File Offset: 0x0002A689
		[DebuggerNonUserCode]
		public void ClearSphericalHarmonicSize()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x0002C4D5 File Offset: 0x0002A6D5
		[DebuggerNonUserCode]
		public uint OctreeSize
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				uint octreeSizeDefaultValue;
				if (flag)
				{
					octreeSizeDefaultValue = this.octreeSize_;
				}
				else
				{
					octreeSizeDefaultValue = AppearanceGeometryInfo.OctreeSizeDefaultValue;
				}
				return octreeSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.octreeSize_ = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0002C4F4 File Offset: 0x0002A6F4
		[DebuggerNonUserCode]
		public bool HasOctreeSize
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0002C515 File Offset: 0x0002A715
		[DebuggerNonUserCode]
		public void ClearOctreeSize()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0002C52C File Offset: 0x0002A72C
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x0002C561 File Offset: 0x0002A761
		[DebuggerNonUserCode]
		public uint InstanceVertexAOSize
		{
			get
			{
				bool flag = (this._hasBits0 & 512) != 0;
				uint instanceVertexAOSizeDefaultValue;
				if (flag)
				{
					instanceVertexAOSizeDefaultValue = this.instanceVertexAOSize_;
				}
				else
				{
					instanceVertexAOSizeDefaultValue = AppearanceGeometryInfo.InstanceVertexAOSizeDefaultValue;
				}
				return instanceVertexAOSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 512;
				this.instanceVertexAOSize_ = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0002C580 File Offset: 0x0002A780
		[DebuggerNonUserCode]
		public bool HasInstanceVertexAOSize
		{
			get
			{
				return (this._hasBits0 & 512) != 0;
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0002C5A1 File Offset: 0x0002A7A1
		[DebuggerNonUserCode]
		public void ClearInstanceVertexAOSize()
		{
			this._hasBits0 &= -513;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0002C5B8 File Offset: 0x0002A7B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceGeometryInfo);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0002C5D8 File Offset: 0x0002A7D8
		[DebuggerNonUserCode]
		public bool Equals(AppearanceGeometryInfo other)
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
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Surface, other.Surface);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Bones != other.Bones;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.chunks_.Equals(other.chunks_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Totals, other.Totals);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.LodTotals, other.LodTotals);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.VertexAndIndexBufferSize != other.VertexAndIndexBufferSize;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.LodVertexAndIndexBufferSize != other.LodVertexAndIndexBufferSize;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.CollisionSize != other.CollisionSize;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.HeightFieldCollisionSize != other.HeightFieldCollisionSize;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.SphericalHarmonicSize != other.SphericalHarmonicSize;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.OctreeSize != other.OctreeSize;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.InstanceVertexAOSize != other.InstanceVertexAOSize;
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0002C7A4 File Offset: 0x0002A9A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasSurface = this.HasSurface;
			if (hasSurface)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Surface);
			}
			bool hasBones = this.HasBones;
			if (hasBones)
			{
				num ^= this.Bones.GetHashCode();
			}
			num ^= this.chunks_.GetHashCode();
			bool flag = this.totals_ != null;
			if (flag)
			{
				num ^= this.Totals.GetHashCode();
			}
			bool flag2 = this.lodTotals_ != null;
			if (flag2)
			{
				num ^= this.LodTotals.GetHashCode();
			}
			bool hasVertexAndIndexBufferSize = this.HasVertexAndIndexBufferSize;
			if (hasVertexAndIndexBufferSize)
			{
				num ^= this.VertexAndIndexBufferSize.GetHashCode();
			}
			bool hasLodVertexAndIndexBufferSize = this.HasLodVertexAndIndexBufferSize;
			if (hasLodVertexAndIndexBufferSize)
			{
				num ^= this.LodVertexAndIndexBufferSize.GetHashCode();
			}
			bool hasCollisionSize = this.HasCollisionSize;
			if (hasCollisionSize)
			{
				num ^= this.CollisionSize.GetHashCode();
			}
			bool hasHeightFieldCollisionSize = this.HasHeightFieldCollisionSize;
			if (hasHeightFieldCollisionSize)
			{
				num ^= this.HeightFieldCollisionSize.GetHashCode();
			}
			bool hasSphericalHarmonicSize = this.HasSphericalHarmonicSize;
			if (hasSphericalHarmonicSize)
			{
				num ^= this.SphericalHarmonicSize.GetHashCode();
			}
			bool hasOctreeSize = this.HasOctreeSize;
			if (hasOctreeSize)
			{
				num ^= this.OctreeSize.GetHashCode();
			}
			bool hasInstanceVertexAOSize = this.HasInstanceVertexAOSize;
			if (hasInstanceVertexAOSize)
			{
				num ^= this.InstanceVertexAOSize.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0002C94C File Offset: 0x0002AB4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0002C964 File Offset: 0x0002AB64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0002C970 File Offset: 0x0002AB70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasSurface = this.HasSurface;
			if (hasSurface)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Surface);
			}
			bool hasBones = this.HasBones;
			if (hasBones)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Bones);
			}
			this.chunks_.WriteTo(ref output, AppearanceGeometryInfo._repeated_chunks_codec);
			bool flag = this.totals_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Totals);
			}
			bool flag2 = this.lodTotals_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LodTotals);
			}
			bool hasVertexAndIndexBufferSize = this.HasVertexAndIndexBufferSize;
			if (hasVertexAndIndexBufferSize)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.VertexAndIndexBufferSize);
			}
			bool hasLodVertexAndIndexBufferSize = this.HasLodVertexAndIndexBufferSize;
			if (hasLodVertexAndIndexBufferSize)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.LodVertexAndIndexBufferSize);
			}
			bool hasCollisionSize = this.HasCollisionSize;
			if (hasCollisionSize)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CollisionSize);
			}
			bool hasHeightFieldCollisionSize = this.HasHeightFieldCollisionSize;
			if (hasHeightFieldCollisionSize)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.HeightFieldCollisionSize);
			}
			bool hasSphericalHarmonicSize = this.HasSphericalHarmonicSize;
			if (hasSphericalHarmonicSize)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.SphericalHarmonicSize);
			}
			bool hasOctreeSize = this.HasOctreeSize;
			if (hasOctreeSize)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OctreeSize);
			}
			bool hasInstanceVertexAOSize = this.HasInstanceVertexAOSize;
			if (hasInstanceVertexAOSize)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.InstanceVertexAOSize);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0002CB5C File Offset: 0x0002AD5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasSurface = this.HasSurface;
			if (hasSurface)
			{
				num += 5;
			}
			bool hasBones = this.HasBones;
			if (hasBones)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Bones);
			}
			num += this.chunks_.CalculateSize(AppearanceGeometryInfo._repeated_chunks_codec);
			bool flag = this.totals_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Totals);
			}
			bool flag2 = this.lodTotals_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LodTotals);
			}
			bool hasVertexAndIndexBufferSize = this.HasVertexAndIndexBufferSize;
			if (hasVertexAndIndexBufferSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.VertexAndIndexBufferSize);
			}
			bool hasLodVertexAndIndexBufferSize = this.HasLodVertexAndIndexBufferSize;
			if (hasLodVertexAndIndexBufferSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LodVertexAndIndexBufferSize);
			}
			bool hasCollisionSize = this.HasCollisionSize;
			if (hasCollisionSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CollisionSize);
			}
			bool hasHeightFieldCollisionSize = this.HasHeightFieldCollisionSize;
			if (hasHeightFieldCollisionSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HeightFieldCollisionSize);
			}
			bool hasSphericalHarmonicSize = this.HasSphericalHarmonicSize;
			if (hasSphericalHarmonicSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SphericalHarmonicSize);
			}
			bool hasOctreeSize = this.HasOctreeSize;
			if (hasOctreeSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OctreeSize);
			}
			bool hasInstanceVertexAOSize = this.HasInstanceVertexAOSize;
			if (hasInstanceVertexAOSize)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InstanceVertexAOSize);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0002CD04 File Offset: 0x0002AF04
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceGeometryInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasSurface = other.HasSurface;
				if (hasSurface)
				{
					this.Surface = other.Surface;
				}
				bool hasBones = other.HasBones;
				if (hasBones)
				{
					this.Bones = other.Bones;
				}
				this.chunks_.Add(other.chunks_);
				bool flag2 = other.totals_ != null;
				if (flag2)
				{
					bool flag3 = this.totals_ == null;
					if (flag3)
					{
						this.Totals = new GeometryInfo();
					}
					this.Totals.MergeFrom(other.Totals);
				}
				bool flag4 = other.lodTotals_ != null;
				if (flag4)
				{
					bool flag5 = this.lodTotals_ == null;
					if (flag5)
					{
						this.LodTotals = new GeometryInfo();
					}
					this.LodTotals.MergeFrom(other.LodTotals);
				}
				bool hasVertexAndIndexBufferSize = other.HasVertexAndIndexBufferSize;
				if (hasVertexAndIndexBufferSize)
				{
					this.VertexAndIndexBufferSize = other.VertexAndIndexBufferSize;
				}
				bool hasLodVertexAndIndexBufferSize = other.HasLodVertexAndIndexBufferSize;
				if (hasLodVertexAndIndexBufferSize)
				{
					this.LodVertexAndIndexBufferSize = other.LodVertexAndIndexBufferSize;
				}
				bool hasCollisionSize = other.HasCollisionSize;
				if (hasCollisionSize)
				{
					this.CollisionSize = other.CollisionSize;
				}
				bool hasHeightFieldCollisionSize = other.HasHeightFieldCollisionSize;
				if (hasHeightFieldCollisionSize)
				{
					this.HeightFieldCollisionSize = other.HeightFieldCollisionSize;
				}
				bool hasSphericalHarmonicSize = other.HasSphericalHarmonicSize;
				if (hasSphericalHarmonicSize)
				{
					this.SphericalHarmonicSize = other.SphericalHarmonicSize;
				}
				bool hasOctreeSize = other.HasOctreeSize;
				if (hasOctreeSize)
				{
					this.OctreeSize = other.OctreeSize;
				}
				bool hasInstanceVertexAOSize = other.HasInstanceVertexAOSize;
				if (hasInstanceVertexAOSize)
				{
					this.InstanceVertexAOSize = other.InstanceVertexAOSize;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0002CED1 File Offset: 0x0002B0D1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0002CEDC File Offset: 0x0002B0DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 8U)
						{
							if (num3 != 21U)
							{
								if (num3 != 24U)
								{
									goto IL_00A0;
								}
								this.Bones = input.ReadInt32();
							}
							else
							{
								this.Surface = input.ReadFloat();
							}
						}
						else
						{
							this.SnoHandle = input.ReadInt32();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							if (num3 != 50U)
							{
								goto IL_00A0;
							}
							bool flag = this.lodTotals_ == null;
							if (flag)
							{
								this.LodTotals = new GeometryInfo();
							}
							input.ReadMessage(this.LodTotals);
						}
						else
						{
							bool flag2 = this.totals_ == null;
							if (flag2)
							{
								this.Totals = new GeometryInfo();
							}
							input.ReadMessage(this.Totals);
						}
					}
					else
					{
						this.chunks_.AddEntriesFrom(ref input, AppearanceGeometryInfo._repeated_chunks_codec);
					}
				}
				else if (num3 <= 72U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							if (num3 != 72U)
							{
								goto IL_00A0;
							}
							this.CollisionSize = input.ReadUInt32();
						}
						else
						{
							this.LodVertexAndIndexBufferSize = input.ReadUInt32();
						}
					}
					else
					{
						this.VertexAndIndexBufferSize = input.ReadUInt32();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_00A0;
						}
						this.SphericalHarmonicSize = input.ReadUInt32();
					}
					else
					{
						this.HeightFieldCollisionSize = input.ReadUInt32();
					}
				}
				else if (num3 != 96U)
				{
					if (num3 != 104U)
					{
						goto IL_00A0;
					}
					this.InstanceVertexAOSize = input.ReadUInt32();
				}
				else
				{
					this.OctreeSize = input.ReadUInt32();
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000488 RID: 1160
		private static readonly MessageParser<AppearanceGeometryInfo> _parser = new MessageParser<AppearanceGeometryInfo>(() => new AppearanceGeometryInfo());

		// Token: 0x04000489 RID: 1161
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400048A RID: 1162
		private int _hasBits0;

		// Token: 0x0400048B RID: 1163
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x0400048C RID: 1164
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400048D RID: 1165
		private int snoHandle_;

		// Token: 0x0400048E RID: 1166
		public const int SurfaceFieldNumber = 2;

		// Token: 0x0400048F RID: 1167
		private static readonly float SurfaceDefaultValue = 0f;

		// Token: 0x04000490 RID: 1168
		private float surface_;

		// Token: 0x04000491 RID: 1169
		public const int BonesFieldNumber = 3;

		// Token: 0x04000492 RID: 1170
		private static readonly int BonesDefaultValue = 0;

		// Token: 0x04000493 RID: 1171
		private int bones_;

		// Token: 0x04000494 RID: 1172
		public const int ChunksFieldNumber = 4;

		// Token: 0x04000495 RID: 1173
		private static readonly FieldCodec<ChunkGeometryInfo> _repeated_chunks_codec = FieldCodec.ForMessage<ChunkGeometryInfo>(34U, ChunkGeometryInfo.Parser);

		// Token: 0x04000496 RID: 1174
		private readonly RepeatedField<ChunkGeometryInfo> chunks_ = new RepeatedField<ChunkGeometryInfo>();

		// Token: 0x04000497 RID: 1175
		public const int TotalsFieldNumber = 5;

		// Token: 0x04000498 RID: 1176
		private GeometryInfo totals_;

		// Token: 0x04000499 RID: 1177
		public const int LodTotalsFieldNumber = 6;

		// Token: 0x0400049A RID: 1178
		private GeometryInfo lodTotals_;

		// Token: 0x0400049B RID: 1179
		public const int VertexAndIndexBufferSizeFieldNumber = 7;

		// Token: 0x0400049C RID: 1180
		private static readonly uint VertexAndIndexBufferSizeDefaultValue = 0U;

		// Token: 0x0400049D RID: 1181
		private uint vertexAndIndexBufferSize_;

		// Token: 0x0400049E RID: 1182
		public const int LodVertexAndIndexBufferSizeFieldNumber = 8;

		// Token: 0x0400049F RID: 1183
		private static readonly uint LodVertexAndIndexBufferSizeDefaultValue = 0U;

		// Token: 0x040004A0 RID: 1184
		private uint lodVertexAndIndexBufferSize_;

		// Token: 0x040004A1 RID: 1185
		public const int CollisionSizeFieldNumber = 9;

		// Token: 0x040004A2 RID: 1186
		private static readonly uint CollisionSizeDefaultValue = 0U;

		// Token: 0x040004A3 RID: 1187
		private uint collisionSize_;

		// Token: 0x040004A4 RID: 1188
		public const int HeightFieldCollisionSizeFieldNumber = 10;

		// Token: 0x040004A5 RID: 1189
		private static readonly uint HeightFieldCollisionSizeDefaultValue = 0U;

		// Token: 0x040004A6 RID: 1190
		private uint heightFieldCollisionSize_;

		// Token: 0x040004A7 RID: 1191
		public const int SphericalHarmonicSizeFieldNumber = 11;

		// Token: 0x040004A8 RID: 1192
		private static readonly uint SphericalHarmonicSizeDefaultValue = 0U;

		// Token: 0x040004A9 RID: 1193
		private uint sphericalHarmonicSize_;

		// Token: 0x040004AA RID: 1194
		public const int OctreeSizeFieldNumber = 12;

		// Token: 0x040004AB RID: 1195
		private static readonly uint OctreeSizeDefaultValue = 0U;

		// Token: 0x040004AC RID: 1196
		private uint octreeSize_;

		// Token: 0x040004AD RID: 1197
		public const int InstanceVertexAOSizeFieldNumber = 13;

		// Token: 0x040004AE RID: 1198
		private static readonly uint InstanceVertexAOSizeDefaultValue = 0U;

		// Token: 0x040004AF RID: 1199
		private uint instanceVertexAOSize_;
	}
}
