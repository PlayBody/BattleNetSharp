using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D4 RID: 212
	public sealed class AnimationFramesResponse : IMessage<AnimationFramesResponse>, IMessage, IEquatable<AnimationFramesResponse>, IDeepCloneable<AnimationFramesResponse>, IBufferMessage
	{
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0004A6F8 File Offset: 0x000488F8
		[DebuggerNonUserCode]
		public static MessageParser<AnimationFramesResponse> Parser
		{
			get
			{
				return AnimationFramesResponse._parser;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0004A710 File Offset: 0x00048910
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[189];
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0004A738 File Offset: 0x00048938
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationFramesResponse.Descriptor;
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0004A74F File Offset: 0x0004894F
		[DebuggerNonUserCode]
		public AnimationFramesResponse()
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0004A77C File Offset: 0x0004897C
		[DebuggerNonUserCode]
		public AnimationFramesResponse(AnimationFramesResponse other)
			: this()
		{
			this.modelSpaceBoneTransform_ = other.modelSpaceBoneTransform_.Clone();
			this.fieldOfView_ = other.fieldOfView_.Clone();
			this.depthOfField_ = other.depthOfField_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0004A7D8 File Offset: 0x000489D8
		[DebuggerNonUserCode]
		public AnimationFramesResponse Clone()
		{
			return new AnimationFramesResponse(this);
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x0004A7F0 File Offset: 0x000489F0
		[DebuggerNonUserCode]
		public RepeatedField<ModelSpaceBoneTransformFrame> ModelSpaceBoneTransform
		{
			get
			{
				return this.modelSpaceBoneTransform_;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0004A808 File Offset: 0x00048A08
		[DebuggerNonUserCode]
		public RepeatedField<FieldOfViewFrame> FieldOfView
		{
			get
			{
				return this.fieldOfView_;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0004A820 File Offset: 0x00048A20
		[DebuggerNonUserCode]
		public RepeatedField<DepthOfFieldFrame> DepthOfField
		{
			get
			{
				return this.depthOfField_;
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0004A838 File Offset: 0x00048A38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationFramesResponse);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0004A858 File Offset: 0x00048A58
		[DebuggerNonUserCode]
		public bool Equals(AnimationFramesResponse other)
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
					bool flag4 = !this.modelSpaceBoneTransform_.Equals(other.modelSpaceBoneTransform_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.fieldOfView_.Equals(other.fieldOfView_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.depthOfField_.Equals(other.depthOfField_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0004A8F0 File Offset: 0x00048AF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.modelSpaceBoneTransform_.GetHashCode();
			num ^= this.fieldOfView_.GetHashCode();
			num ^= this.depthOfField_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0004A94C File Offset: 0x00048B4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0004A964 File Offset: 0x00048B64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0004A970 File Offset: 0x00048B70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.modelSpaceBoneTransform_.WriteTo(ref output, AnimationFramesResponse._repeated_modelSpaceBoneTransform_codec);
			this.fieldOfView_.WriteTo(ref output, AnimationFramesResponse._repeated_fieldOfView_codec);
			this.depthOfField_.WriteTo(ref output, AnimationFramesResponse._repeated_depthOfField_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0004A9D0 File Offset: 0x00048BD0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.modelSpaceBoneTransform_.CalculateSize(AnimationFramesResponse._repeated_modelSpaceBoneTransform_codec);
			num += this.fieldOfView_.CalculateSize(AnimationFramesResponse._repeated_fieldOfView_codec);
			num += this.depthOfField_.CalculateSize(AnimationFramesResponse._repeated_depthOfField_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0004AA3C File Offset: 0x00048C3C
		[DebuggerNonUserCode]
		public void MergeFrom(AnimationFramesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.modelSpaceBoneTransform_.Add(other.modelSpaceBoneTransform_);
				this.fieldOfView_.Add(other.fieldOfView_);
				this.depthOfField_.Add(other.depthOfField_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0004AAA2 File Offset: 0x00048CA2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0004AAB0 File Offset: 0x00048CB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.depthOfField_.AddEntriesFrom(ref input, AnimationFramesResponse._repeated_depthOfField_codec);
						}
					}
					else
					{
						this.fieldOfView_.AddEntriesFrom(ref input, AnimationFramesResponse._repeated_fieldOfView_codec);
					}
				}
				else
				{
					this.modelSpaceBoneTransform_.AddEntriesFrom(ref input, AnimationFramesResponse._repeated_modelSpaceBoneTransform_codec);
				}
			}
		}

		// Token: 0x04000844 RID: 2116
		private static readonly MessageParser<AnimationFramesResponse> _parser = new MessageParser<AnimationFramesResponse>(() => new AnimationFramesResponse());

		// Token: 0x04000845 RID: 2117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000846 RID: 2118
		public const int ModelSpaceBoneTransformFieldNumber = 1;

		// Token: 0x04000847 RID: 2119
		private static readonly FieldCodec<ModelSpaceBoneTransformFrame> _repeated_modelSpaceBoneTransform_codec = FieldCodec.ForMessage<ModelSpaceBoneTransformFrame>(10U, ModelSpaceBoneTransformFrame.Parser);

		// Token: 0x04000848 RID: 2120
		private readonly RepeatedField<ModelSpaceBoneTransformFrame> modelSpaceBoneTransform_ = new RepeatedField<ModelSpaceBoneTransformFrame>();

		// Token: 0x04000849 RID: 2121
		public const int FieldOfViewFieldNumber = 2;

		// Token: 0x0400084A RID: 2122
		private static readonly FieldCodec<FieldOfViewFrame> _repeated_fieldOfView_codec = FieldCodec.ForMessage<FieldOfViewFrame>(18U, FieldOfViewFrame.Parser);

		// Token: 0x0400084B RID: 2123
		private readonly RepeatedField<FieldOfViewFrame> fieldOfView_ = new RepeatedField<FieldOfViewFrame>();

		// Token: 0x0400084C RID: 2124
		public const int DepthOfFieldFieldNumber = 3;

		// Token: 0x0400084D RID: 2125
		private static readonly FieldCodec<DepthOfFieldFrame> _repeated_depthOfField_codec = FieldCodec.ForMessage<DepthOfFieldFrame>(26U, DepthOfFieldFrame.Parser);

		// Token: 0x0400084E RID: 2126
		private readonly RepeatedField<DepthOfFieldFrame> depthOfField_ = new RepeatedField<DepthOfFieldFrame>();
	}
}
