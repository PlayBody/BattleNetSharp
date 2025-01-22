using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D2 RID: 210
	public sealed class FieldOfViewFrame : IMessage<FieldOfViewFrame>, IMessage, IEquatable<FieldOfViewFrame>, IDeepCloneable<FieldOfViewFrame>, IBufferMessage
	{
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00049870 File Offset: 0x00047A70
		[DebuggerNonUserCode]
		public static MessageParser<FieldOfViewFrame> Parser
		{
			get
			{
				return FieldOfViewFrame._parser;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00049888 File Offset: 0x00047A88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[187];
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000498B0 File Offset: 0x00047AB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldOfViewFrame.Descriptor;
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000498C7 File Offset: 0x00047AC7
		[DebuggerNonUserCode]
		public FieldOfViewFrame()
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x000498D1 File Offset: 0x00047AD1
		[DebuggerNonUserCode]
		public FieldOfViewFrame(FieldOfViewFrame other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.frameIndex_ = other.frameIndex_;
			this.fieldOfView_ = other.fieldOfView_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00049910 File Offset: 0x00047B10
		[DebuggerNonUserCode]
		public FieldOfViewFrame Clone()
		{
			return new FieldOfViewFrame(this);
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x00049928 File Offset: 0x00047B28
		// (set) Token: 0x06001424 RID: 5156 RVA: 0x00049959 File Offset: 0x00047B59
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
					frameIndexDefaultValue = FieldOfViewFrame.FrameIndexDefaultValue;
				}
				return frameIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.frameIndex_ = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x00049974 File Offset: 0x00047B74
		[DebuggerNonUserCode]
		public bool HasFrameIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00049991 File Offset: 0x00047B91
		[DebuggerNonUserCode]
		public void ClearFrameIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000499A4 File Offset: 0x00047BA4
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x000499D5 File Offset: 0x00047BD5
		[DebuggerNonUserCode]
		public float FieldOfView
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float fieldOfViewDefaultValue;
				if (flag)
				{
					fieldOfViewDefaultValue = this.fieldOfView_;
				}
				else
				{
					fieldOfViewDefaultValue = FieldOfViewFrame.FieldOfViewDefaultValue;
				}
				return fieldOfViewDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fieldOfView_ = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x000499F0 File Offset: 0x00047BF0
		[DebuggerNonUserCode]
		public bool HasFieldOfView
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00049A0D File Offset: 0x00047C0D
		[DebuggerNonUserCode]
		public void ClearFieldOfView()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00049A20 File Offset: 0x00047C20
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldOfViewFrame);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00049A40 File Offset: 0x00047C40
		[DebuggerNonUserCode]
		public bool Equals(FieldOfViewFrame other)
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
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FieldOfView, other.FieldOfView);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00049ABC File Offset: 0x00047CBC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				num ^= this.FrameIndex.GetHashCode();
			}
			bool hasFieldOfView = this.HasFieldOfView;
			if (hasFieldOfView)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FieldOfView);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00049B2C File Offset: 0x00047D2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00049B44 File Offset: 0x00047D44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00049B50 File Offset: 0x00047D50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FrameIndex);
			}
			bool hasFieldOfView = this.HasFieldOfView;
			if (hasFieldOfView)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.FieldOfView);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00049BC0 File Offset: 0x00047DC0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFrameIndex = this.HasFrameIndex;
			if (hasFrameIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrameIndex);
			}
			bool hasFieldOfView = this.HasFieldOfView;
			if (hasFieldOfView)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00049C20 File Offset: 0x00047E20
		[DebuggerNonUserCode]
		public void MergeFrom(FieldOfViewFrame other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFrameIndex = other.HasFrameIndex;
				if (hasFrameIndex)
				{
					this.FrameIndex = other.FrameIndex;
				}
				bool hasFieldOfView = other.HasFieldOfView;
				if (hasFieldOfView)
				{
					this.FieldOfView = other.FieldOfView;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00049C82 File Offset: 0x00047E82
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00049C90 File Offset: 0x00047E90
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
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FieldOfView = input.ReadFloat();
					}
				}
				else
				{
					this.FrameIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000826 RID: 2086
		private static readonly MessageParser<FieldOfViewFrame> _parser = new MessageParser<FieldOfViewFrame>(() => new FieldOfViewFrame());

		// Token: 0x04000827 RID: 2087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000828 RID: 2088
		private int _hasBits0;

		// Token: 0x04000829 RID: 2089
		public const int FrameIndexFieldNumber = 1;

		// Token: 0x0400082A RID: 2090
		private static readonly int FrameIndexDefaultValue = 0;

		// Token: 0x0400082B RID: 2091
		private int frameIndex_;

		// Token: 0x0400082C RID: 2092
		public const int FieldOfViewFieldNumber = 2;

		// Token: 0x0400082D RID: 2093
		private static readonly float FieldOfViewDefaultValue = 0f;

		// Token: 0x0400082E RID: 2094
		private float fieldOfView_;
	}
}
