using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000049 RID: 73
	public sealed class AppearanceBoneInformationRequest : IMessage<AppearanceBoneInformationRequest>, IMessage, IEquatable<AppearanceBoneInformationRequest>, IDeepCloneable<AppearanceBoneInformationRequest>, IBufferMessage
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001B28C File Offset: 0x0001948C
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceBoneInformationRequest> Parser
		{
			get
			{
				return AppearanceBoneInformationRequest._parser;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001B2A4 File Offset: 0x000194A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[50];
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001B2C8 File Offset: 0x000194C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceBoneInformationRequest.Descriptor;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001B2DF File Offset: 0x000194DF
		[DebuggerNonUserCode]
		public AppearanceBoneInformationRequest()
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001B2EC File Offset: 0x000194EC
		[DebuggerNonUserCode]
		public AppearanceBoneInformationRequest(AppearanceBoneInformationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.boneIndex_ = other.boneIndex_;
			this.shapeIndex_ = other.shapeIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001B344 File Offset: 0x00019544
		[DebuggerNonUserCode]
		public AppearanceBoneInformationRequest Clone()
		{
			return new AppearanceBoneInformationRequest(this);
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001B35C File Offset: 0x0001955C
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0001B38D File Offset: 0x0001958D
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
					snoHandleDefaultValue = AppearanceBoneInformationRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0001B3C5 File Offset: 0x000195C5
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001B3D8 File Offset: 0x000195D8
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x0001B409 File Offset: 0x00019609
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
					boneIndexDefaultValue = AppearanceBoneInformationRequest.BoneIndexDefaultValue;
				}
				return boneIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.boneIndex_ = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001B424 File Offset: 0x00019624
		[DebuggerNonUserCode]
		public bool HasBoneIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001B441 File Offset: 0x00019641
		[DebuggerNonUserCode]
		public void ClearBoneIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001B454 File Offset: 0x00019654
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x0001B485 File Offset: 0x00019685
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
					shapeIndexDefaultValue = AppearanceBoneInformationRequest.ShapeIndexDefaultValue;
				}
				return shapeIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.shapeIndex_ = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001B4A0 File Offset: 0x000196A0
		[DebuggerNonUserCode]
		public bool HasShapeIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001B4BD File Offset: 0x000196BD
		[DebuggerNonUserCode]
		public void ClearShapeIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001B4D0 File Offset: 0x000196D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceBoneInformationRequest);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001B4F0 File Offset: 0x000196F0
		[DebuggerNonUserCode]
		public bool Equals(AppearanceBoneInformationRequest other)
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
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001B57C File Offset: 0x0001977C
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0001B608 File Offset: 0x00019808
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0001B620 File Offset: 0x00019820
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001B62C File Offset: 0x0001982C
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0001B6BC File Offset: 0x000198BC
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001B748 File Offset: 0x00019948
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceBoneInformationRequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001B7C3 File Offset: 0x000199C3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001B7D0 File Offset: 0x000199D0
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
							this.ShapeIndex = input.ReadInt32();
						}
					}
					else
					{
						this.BoneIndex = input.ReadInt32();
					}
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly MessageParser<AppearanceBoneInformationRequest> _parser = new MessageParser<AppearanceBoneInformationRequest>(() => new AppearanceBoneInformationRequest());

		// Token: 0x04000286 RID: 646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000287 RID: 647
		private int _hasBits0;

		// Token: 0x04000288 RID: 648
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000289 RID: 649
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400028A RID: 650
		private int snoHandle_;

		// Token: 0x0400028B RID: 651
		public const int BoneIndexFieldNumber = 2;

		// Token: 0x0400028C RID: 652
		private static readonly int BoneIndexDefaultValue = 0;

		// Token: 0x0400028D RID: 653
		private int boneIndex_;

		// Token: 0x0400028E RID: 654
		public const int ShapeIndexFieldNumber = 3;

		// Token: 0x0400028F RID: 655
		private static readonly int ShapeIndexDefaultValue = 0;

		// Token: 0x04000290 RID: 656
		private int shapeIndex_;
	}
}
