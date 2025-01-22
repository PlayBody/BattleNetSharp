using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200004A RID: 74
	public sealed class AppearanceBoneInformation : IMessage<AppearanceBoneInformation>, IMessage, IEquatable<AppearanceBoneInformation>, IDeepCloneable<AppearanceBoneInformation>, IBufferMessage
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001B87C File Offset: 0x00019A7C
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceBoneInformation> Parser
		{
			get
			{
				return AppearanceBoneInformation._parser;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001B894 File Offset: 0x00019A94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[51];
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceBoneInformation.Descriptor;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0001B8CF File Offset: 0x00019ACF
		[DebuggerNonUserCode]
		public AppearanceBoneInformation()
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001B8DC File Offset: 0x00019ADC
		[DebuggerNonUserCode]
		public AppearanceBoneInformation(AppearanceBoneInformation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.boneIndex_ = other.boneIndex_;
			this.shapeIndex_ = other.shapeIndex_;
			this.mass_ = other.mass_;
			this.animationLod_ = other.animationLod_;
			this.inheritedBone_ = other.inheritedBone_;
			this.clothBone_ = other.clothBone_;
			this.trueBoneLod_ = other.trueBoneLod_;
			this.partialRagdollBone_ = other.partialRagdollBone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001B97C File Offset: 0x00019B7C
		[DebuggerNonUserCode]
		public AppearanceBoneInformation Clone()
		{
			return new AppearanceBoneInformation(this);
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001B994 File Offset: 0x00019B94
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0001B9C5 File Offset: 0x00019BC5
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
					snoHandleDefaultValue = AppearanceBoneInformation.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001B9FD File Offset: 0x00019BFD
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001BA10 File Offset: 0x00019C10
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0001BA41 File Offset: 0x00019C41
		[DebuggerNonUserCode]
		public int BoneIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int boneIndexDefaultValue;
				if (flag)
				{
					boneIndexDefaultValue = this.boneIndex_;
				}
				else
				{
					boneIndexDefaultValue = AppearanceBoneInformation.BoneIndexDefaultValue;
				}
				return boneIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.boneIndex_ = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001BA5C File Offset: 0x00019C5C
		[DebuggerNonUserCode]
		public bool HasBoneIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001BA79 File Offset: 0x00019C79
		[DebuggerNonUserCode]
		public void ClearBoneIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001BA8C File Offset: 0x00019C8C
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x0001BABD File Offset: 0x00019CBD
		[DebuggerNonUserCode]
		public int ShapeIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int shapeIndexDefaultValue;
				if (flag)
				{
					shapeIndexDefaultValue = this.shapeIndex_;
				}
				else
				{
					shapeIndexDefaultValue = AppearanceBoneInformation.ShapeIndexDefaultValue;
				}
				return shapeIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.shapeIndex_ = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001BAD8 File Offset: 0x00019CD8
		[DebuggerNonUserCode]
		public bool HasShapeIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001BAF5 File Offset: 0x00019CF5
		[DebuggerNonUserCode]
		public void ClearShapeIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001BB08 File Offset: 0x00019D08
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x0001BB39 File Offset: 0x00019D39
		[DebuggerNonUserCode]
		public float Mass
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float massDefaultValue;
				if (flag)
				{
					massDefaultValue = this.mass_;
				}
				else
				{
					massDefaultValue = AppearanceBoneInformation.MassDefaultValue;
				}
				return massDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.mass_ = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001BB54 File Offset: 0x00019D54
		[DebuggerNonUserCode]
		public bool HasMass
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001BB71 File Offset: 0x00019D71
		[DebuggerNonUserCode]
		public void ClearMass()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001BB84 File Offset: 0x00019D84
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0001BBB6 File Offset: 0x00019DB6
		[DebuggerNonUserCode]
		public int AnimationLod
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int animationLodDefaultValue;
				if (flag)
				{
					animationLodDefaultValue = this.animationLod_;
				}
				else
				{
					animationLodDefaultValue = AppearanceBoneInformation.AnimationLodDefaultValue;
				}
				return animationLodDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.animationLod_ = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[DebuggerNonUserCode]
		public bool HasAnimationLod
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001BBEE File Offset: 0x00019DEE
		[DebuggerNonUserCode]
		public void ClearAnimationLod()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001BC00 File Offset: 0x00019E00
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x0001BC32 File Offset: 0x00019E32
		[DebuggerNonUserCode]
		public bool InheritedBone
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool inheritedBoneDefaultValue;
				if (flag)
				{
					inheritedBoneDefaultValue = this.inheritedBone_;
				}
				else
				{
					inheritedBoneDefaultValue = AppearanceBoneInformation.InheritedBoneDefaultValue;
				}
				return inheritedBoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.inheritedBone_ = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001BC4C File Offset: 0x00019E4C
		[DebuggerNonUserCode]
		public bool HasInheritedBone
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001BC6A File Offset: 0x00019E6A
		[DebuggerNonUserCode]
		public void ClearInheritedBone()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001BC7C File Offset: 0x00019E7C
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0001BCAE File Offset: 0x00019EAE
		[DebuggerNonUserCode]
		public bool ClothBone
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool clothBoneDefaultValue;
				if (flag)
				{
					clothBoneDefaultValue = this.clothBone_;
				}
				else
				{
					clothBoneDefaultValue = AppearanceBoneInformation.ClothBoneDefaultValue;
				}
				return clothBoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.clothBone_ = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0001BCC8 File Offset: 0x00019EC8
		[DebuggerNonUserCode]
		public bool HasClothBone
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001BCE6 File Offset: 0x00019EE6
		[DebuggerNonUserCode]
		public void ClearClothBone()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x0001BD2D File Offset: 0x00019F2D
		[DebuggerNonUserCode]
		public int TrueBoneLod
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				int trueBoneLodDefaultValue;
				if (flag)
				{
					trueBoneLodDefaultValue = this.trueBoneLod_;
				}
				else
				{
					trueBoneLodDefaultValue = AppearanceBoneInformation.TrueBoneLodDefaultValue;
				}
				return trueBoneLodDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.trueBoneLod_ = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001BD4C File Offset: 0x00019F4C
		[DebuggerNonUserCode]
		public bool HasTrueBoneLod
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001BD6D File Offset: 0x00019F6D
		[DebuggerNonUserCode]
		public void ClearTrueBoneLod()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001BD84 File Offset: 0x00019F84
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x0001BDB9 File Offset: 0x00019FB9
		[DebuggerNonUserCode]
		public bool PartialRagdollBone
		{
			get
			{
				bool flag = (this._hasBits0 & 256) != 0;
				bool partialRagdollBoneDefaultValue;
				if (flag)
				{
					partialRagdollBoneDefaultValue = this.partialRagdollBone_;
				}
				else
				{
					partialRagdollBoneDefaultValue = AppearanceBoneInformation.PartialRagdollBoneDefaultValue;
				}
				return partialRagdollBoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 256;
				this.partialRagdollBone_ = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0001BDD8 File Offset: 0x00019FD8
		[DebuggerNonUserCode]
		public bool HasPartialRagdollBone
		{
			get
			{
				return (this._hasBits0 & 256) != 0;
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0001BDF9 File Offset: 0x00019FF9
		[DebuggerNonUserCode]
		public void ClearPartialRagdollBone()
		{
			this._hasBits0 &= -257;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0001BE10 File Offset: 0x0001A010
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceBoneInformation);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001BE30 File Offset: 0x0001A030
		[DebuggerNonUserCode]
		public bool Equals(AppearanceBoneInformation other)
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
						bool flag5 = this.BoneIndex != other.BoneIndex;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ShapeIndex != other.ShapeIndex;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Mass, other.Mass);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AnimationLod != other.AnimationLod;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.InheritedBone != other.InheritedBone;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ClothBone != other.ClothBone;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.TrueBoneLod != other.TrueBoneLod;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.PartialRagdollBone != other.PartialRagdollBone;
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

		// Token: 0x06000647 RID: 1607 RVA: 0x0001BF7C File Offset: 0x0001A17C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasBoneIndex = this.HasBoneIndex;
			if (hasBoneIndex)
			{
				num ^= this.BoneIndex.GetHashCode();
			}
			bool hasShapeIndex = this.HasShapeIndex;
			if (hasShapeIndex)
			{
				num ^= this.ShapeIndex.GetHashCode();
			}
			bool hasMass = this.HasMass;
			if (hasMass)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Mass);
			}
			bool hasAnimationLod = this.HasAnimationLod;
			if (hasAnimationLod)
			{
				num ^= this.AnimationLod.GetHashCode();
			}
			bool hasInheritedBone = this.HasInheritedBone;
			if (hasInheritedBone)
			{
				num ^= this.InheritedBone.GetHashCode();
			}
			bool hasClothBone = this.HasClothBone;
			if (hasClothBone)
			{
				num ^= this.ClothBone.GetHashCode();
			}
			bool hasTrueBoneLod = this.HasTrueBoneLod;
			if (hasTrueBoneLod)
			{
				num ^= this.TrueBoneLod.GetHashCode();
			}
			bool hasPartialRagdollBone = this.HasPartialRagdollBone;
			if (hasPartialRagdollBone)
			{
				num ^= this.PartialRagdollBone.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001C0DC File Offset: 0x0001A2DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasBoneIndex = this.HasBoneIndex;
			if (hasBoneIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BoneIndex);
			}
			bool hasShapeIndex = this.HasShapeIndex;
			if (hasShapeIndex)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ShapeIndex);
			}
			bool hasMass = this.HasMass;
			if (hasMass)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Mass);
			}
			bool hasAnimationLod = this.HasAnimationLod;
			if (hasAnimationLod)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AnimationLod);
			}
			bool hasInheritedBone = this.HasInheritedBone;
			if (hasInheritedBone)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.InheritedBone);
			}
			bool hasClothBone = this.HasClothBone;
			if (hasClothBone)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ClothBone);
			}
			bool hasTrueBoneLod = this.HasTrueBoneLod;
			if (hasTrueBoneLod)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TrueBoneLod);
			}
			bool hasPartialRagdollBone = this.HasPartialRagdollBone;
			if (hasPartialRagdollBone)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.PartialRagdollBone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001C244 File Offset: 0x0001A444
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasBoneIndex = this.HasBoneIndex;
			if (hasBoneIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoneIndex);
			}
			bool hasShapeIndex = this.HasShapeIndex;
			if (hasShapeIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShapeIndex);
			}
			bool hasMass = this.HasMass;
			if (hasMass)
			{
				num += 5;
			}
			bool hasAnimationLod = this.HasAnimationLod;
			if (hasAnimationLod)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AnimationLod);
			}
			bool hasInheritedBone = this.HasInheritedBone;
			if (hasInheritedBone)
			{
				num += 2;
			}
			bool hasClothBone = this.HasClothBone;
			if (hasClothBone)
			{
				num += 2;
			}
			bool hasTrueBoneLod = this.HasTrueBoneLod;
			if (hasTrueBoneLod)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrueBoneLod);
			}
			bool hasPartialRagdollBone = this.HasPartialRagdollBone;
			if (hasPartialRagdollBone)
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

		// Token: 0x0600064C RID: 1612 RVA: 0x0001C354 File Offset: 0x0001A554
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceBoneInformation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasBoneIndex = other.HasBoneIndex;
				if (hasBoneIndex)
				{
					this.BoneIndex = other.BoneIndex;
				}
				bool hasShapeIndex = other.HasShapeIndex;
				if (hasShapeIndex)
				{
					this.ShapeIndex = other.ShapeIndex;
				}
				bool hasMass = other.HasMass;
				if (hasMass)
				{
					this.Mass = other.Mass;
				}
				bool hasAnimationLod = other.HasAnimationLod;
				if (hasAnimationLod)
				{
					this.AnimationLod = other.AnimationLod;
				}
				bool hasInheritedBone = other.HasInheritedBone;
				if (hasInheritedBone)
				{
					this.InheritedBone = other.InheritedBone;
				}
				bool hasClothBone = other.HasClothBone;
				if (hasClothBone)
				{
					this.ClothBone = other.ClothBone;
				}
				bool hasTrueBoneLod = other.HasTrueBoneLod;
				if (hasTrueBoneLod)
				{
					this.TrueBoneLod = other.TrueBoneLod;
				}
				bool hasPartialRagdollBone = other.HasPartialRagdollBone;
				if (hasPartialRagdollBone)
				{
					this.PartialRagdollBone = other.PartialRagdollBone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0001C474 File Offset: 0x0001A674
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0001C480 File Offset: 0x0001A680
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 37U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006A;
							}
							this.BoneIndex = input.ReadInt32();
						}
						else
						{
							this.SnoHandle = input.ReadInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 37U)
						{
							goto IL_006A;
						}
						this.Mass = input.ReadFloat();
					}
					else
					{
						this.ShapeIndex = input.ReadInt32();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_006A;
						}
						this.InheritedBone = input.ReadBool();
					}
					else
					{
						this.AnimationLod = input.ReadInt32();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						if (num3 != 72U)
						{
							goto IL_006A;
						}
						this.PartialRagdollBone = input.ReadBool();
					}
					else
					{
						this.TrueBoneLod = input.ReadInt32();
					}
				}
				else
				{
					this.ClothBone = input.ReadBool();
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000291 RID: 657
		private static readonly MessageParser<AppearanceBoneInformation> _parser = new MessageParser<AppearanceBoneInformation>(() => new AppearanceBoneInformation());

		// Token: 0x04000292 RID: 658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000293 RID: 659
		private int _hasBits0;

		// Token: 0x04000294 RID: 660
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000295 RID: 661
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000296 RID: 662
		private int snoHandle_;

		// Token: 0x04000297 RID: 663
		public const int BoneIndexFieldNumber = 2;

		// Token: 0x04000298 RID: 664
		private static readonly int BoneIndexDefaultValue = 0;

		// Token: 0x04000299 RID: 665
		private int boneIndex_;

		// Token: 0x0400029A RID: 666
		public const int ShapeIndexFieldNumber = 3;

		// Token: 0x0400029B RID: 667
		private static readonly int ShapeIndexDefaultValue = 0;

		// Token: 0x0400029C RID: 668
		private int shapeIndex_;

		// Token: 0x0400029D RID: 669
		public const int MassFieldNumber = 4;

		// Token: 0x0400029E RID: 670
		private static readonly float MassDefaultValue = 0f;

		// Token: 0x0400029F RID: 671
		private float mass_;

		// Token: 0x040002A0 RID: 672
		public const int AnimationLodFieldNumber = 5;

		// Token: 0x040002A1 RID: 673
		private static readonly int AnimationLodDefaultValue = 0;

		// Token: 0x040002A2 RID: 674
		private int animationLod_;

		// Token: 0x040002A3 RID: 675
		public const int InheritedBoneFieldNumber = 6;

		// Token: 0x040002A4 RID: 676
		private static readonly bool InheritedBoneDefaultValue = false;

		// Token: 0x040002A5 RID: 677
		private bool inheritedBone_;

		// Token: 0x040002A6 RID: 678
		public const int ClothBoneFieldNumber = 7;

		// Token: 0x040002A7 RID: 679
		private static readonly bool ClothBoneDefaultValue = false;

		// Token: 0x040002A8 RID: 680
		private bool clothBone_;

		// Token: 0x040002A9 RID: 681
		public const int TrueBoneLodFieldNumber = 8;

		// Token: 0x040002AA RID: 682
		private static readonly int TrueBoneLodDefaultValue = 0;

		// Token: 0x040002AB RID: 683
		private int trueBoneLod_;

		// Token: 0x040002AC RID: 684
		public const int PartialRagdollBoneFieldNumber = 9;

		// Token: 0x040002AD RID: 685
		private static readonly bool PartialRagdollBoneDefaultValue = false;

		// Token: 0x040002AE RID: 686
		private bool partialRagdollBone_;
	}
}
