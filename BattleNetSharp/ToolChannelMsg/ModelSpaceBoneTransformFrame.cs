using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D1 RID: 209
	public sealed class ModelSpaceBoneTransformFrame : IMessage<ModelSpaceBoneTransformFrame>, IMessage, IEquatable<ModelSpaceBoneTransformFrame>, IDeepCloneable<ModelSpaceBoneTransformFrame>, IBufferMessage
	{
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00049278 File Offset: 0x00047478
		[DebuggerNonUserCode]
		public static MessageParser<ModelSpaceBoneTransformFrame> Parser
		{
			get
			{
				return ModelSpaceBoneTransformFrame._parser;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00049290 File Offset: 0x00047490
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[186];
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x000492B8 File Offset: 0x000474B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModelSpaceBoneTransformFrame.Descriptor;
			}
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000492CF File Offset: 0x000474CF
		[DebuggerNonUserCode]
		public ModelSpaceBoneTransformFrame()
		{
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000492DC File Offset: 0x000474DC
		[DebuggerNonUserCode]
		public ModelSpaceBoneTransformFrame(ModelSpaceBoneTransformFrame other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.frameIndex_ = other.frameIndex_;
			this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
			this.tangent_ = ((other.tangent_ != null) ? other.tangent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00049354 File Offset: 0x00047554
		[DebuggerNonUserCode]
		public ModelSpaceBoneTransformFrame Clone()
		{
			return new ModelSpaceBoneTransformFrame(this);
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0004936C File Offset: 0x0004756C
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x0004939D File Offset: 0x0004759D
		[DebuggerNonUserCode]
		public int FrameIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int frameIndexDefaultValue;
				if (flag)
				{
					frameIndexDefaultValue = this.frameIndex_;
				}
				else
				{
					frameIndexDefaultValue = ModelSpaceBoneTransformFrame.FrameIndexDefaultValue;
				}
				return frameIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.frameIndex_ = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x000493B8 File Offset: 0x000475B8
		[DebuggerNonUserCode]
		public bool HasFrameIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x000493D5 File Offset: 0x000475D5
		[DebuggerNonUserCode]
		public void ClearFrameIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x000493E8 File Offset: 0x000475E8
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x00049400 File Offset: 0x00047600
		[DebuggerNonUserCode]
		public PRTransform Transform
		{
			get
			{
				return this.transform_;
			}
			set
			{
				this.transform_ = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0004940C File Offset: 0x0004760C
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00049424 File Offset: 0x00047624
		[DebuggerNonUserCode]
		public BoneTangent Tangent
		{
			get
			{
				return this.tangent_;
			}
			set
			{
				this.tangent_ = value;
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00049430 File Offset: 0x00047630
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModelSpaceBoneTransformFrame);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00049450 File Offset: 0x00047650
		[DebuggerNonUserCode]
		public bool Equals(ModelSpaceBoneTransformFrame other)
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
					bool flag4 = this.FrameIndex != other.FrameIndex;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Transform, other.Transform);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Tangent, other.Tangent);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x000494E4 File Offset: 0x000476E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				num ^= this.FrameIndex.GetHashCode();
			}
			bool flag = this.transform_ != null;
			if (flag)
			{
				num ^= this.Transform.GetHashCode();
			}
			bool flag2 = this.tangent_ != null;
			if (flag2)
			{
				num ^= this.Tangent.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00049570 File Offset: 0x00047770
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00049588 File Offset: 0x00047788
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00049594 File Offset: 0x00047794
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FrameIndex);
			}
			bool flag = this.transform_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Transform);
			}
			bool flag2 = this.tangent_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Tangent);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0004962C File Offset: 0x0004782C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrameIndex);
			}
			bool flag = this.transform_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
			}
			bool flag2 = this.tangent_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tangent);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000496BC File Offset: 0x000478BC
		[DebuggerNonUserCode]
		public void MergeFrom(ModelSpaceBoneTransformFrame other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFrameIndex = other.HasFrameIndex;
				if (hasFrameIndex)
				{
					this.FrameIndex = other.FrameIndex;
				}
				bool flag2 = other.transform_ != null;
				if (flag2)
				{
					bool flag3 = this.transform_ == null;
					if (flag3)
					{
						this.Transform = new PRTransform();
					}
					this.Transform.MergeFrom(other.Transform);
				}
				bool flag4 = other.tangent_ != null;
				if (flag4)
				{
					bool flag5 = this.tangent_ == null;
					if (flag5)
					{
						this.Tangent = new BoneTangent();
					}
					this.Tangent.MergeFrom(other.Tangent);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00049784 File Offset: 0x00047984
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00049790 File Offset: 0x00047990
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.tangent_ == null;
							if (flag)
							{
								this.Tangent = new BoneTangent();
							}
							input.ReadMessage(this.Tangent);
						}
					}
					else
					{
						bool flag2 = this.transform_ == null;
						if (flag2)
						{
							this.Transform = new PRTransform();
						}
						input.ReadMessage(this.Transform);
					}
				}
				else
				{
					this.FrameIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400081C RID: 2076
		private static readonly MessageParser<ModelSpaceBoneTransformFrame> _parser = new MessageParser<ModelSpaceBoneTransformFrame>(() => new ModelSpaceBoneTransformFrame());

		// Token: 0x0400081D RID: 2077
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400081E RID: 2078
		private int _hasBits0;

		// Token: 0x0400081F RID: 2079
		public const int FrameIndexFieldNumber = 1;

		// Token: 0x04000820 RID: 2080
		private static readonly int FrameIndexDefaultValue = 0;

		// Token: 0x04000821 RID: 2081
		private int frameIndex_;

		// Token: 0x04000822 RID: 2082
		public const int TransformFieldNumber = 2;

		// Token: 0x04000823 RID: 2083
		private PRTransform transform_;

		// Token: 0x04000824 RID: 2084
		public const int TangentFieldNumber = 3;

		// Token: 0x04000825 RID: 2085
		private BoneTangent tangent_;
	}
}
