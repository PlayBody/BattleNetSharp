using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000352 RID: 850
	public sealed class EmbedImage : IMessage<EmbedImage>, IMessage, IEquatable<EmbedImage>, IDeepCloneable<EmbedImage>, IBufferMessage
	{
		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06005834 RID: 22580 RVA: 0x00155584 File Offset: 0x00153784
		[DebuggerNonUserCode]
		public static MessageParser<EmbedImage> Parser
		{
			get
			{
				return EmbedImage._parser;
			}
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06005835 RID: 22581 RVA: 0x0015559C File Offset: 0x0015379C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EmbedTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06005836 RID: 22582 RVA: 0x001555C0 File Offset: 0x001537C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EmbedImage.Descriptor;
			}
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x001555D7 File Offset: 0x001537D7
		[DebuggerNonUserCode]
		public EmbedImage()
		{
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x001555E4 File Offset: 0x001537E4
		[DebuggerNonUserCode]
		public EmbedImage(EmbedImage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.url_ = other.url_;
			this.width_ = other.width_;
			this.height_ = other.height_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x0015563C File Offset: 0x0015383C
		[DebuggerNonUserCode]
		public EmbedImage Clone()
		{
			return new EmbedImage(this);
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x0600583A RID: 22586 RVA: 0x00155654 File Offset: 0x00153854
		// (set) Token: 0x0600583B RID: 22587 RVA: 0x00155675 File Offset: 0x00153875
		[DebuggerNonUserCode]
		public string Url
		{
			get
			{
				return this.url_ ?? EmbedImage.UrlDefaultValue;
			}
			set
			{
				this.url_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x0600583C RID: 22588 RVA: 0x0015568C File Offset: 0x0015388C
		[DebuggerNonUserCode]
		public bool HasUrl
		{
			get
			{
				return this.url_ != null;
			}
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x001556A7 File Offset: 0x001538A7
		[DebuggerNonUserCode]
		public void ClearUrl()
		{
			this.url_ = null;
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x0600583E RID: 22590 RVA: 0x001556B4 File Offset: 0x001538B4
		// (set) Token: 0x0600583F RID: 22591 RVA: 0x001556E5 File Offset: 0x001538E5
		[DebuggerNonUserCode]
		public uint Width
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint widthDefaultValue;
				if (flag)
				{
					widthDefaultValue = this.width_;
				}
				else
				{
					widthDefaultValue = EmbedImage.WidthDefaultValue;
				}
				return widthDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.width_ = value;
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06005840 RID: 22592 RVA: 0x00155700 File Offset: 0x00153900
		[DebuggerNonUserCode]
		public bool HasWidth
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x0015571D File Offset: 0x0015391D
		[DebuggerNonUserCode]
		public void ClearWidth()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06005842 RID: 22594 RVA: 0x00155730 File Offset: 0x00153930
		// (set) Token: 0x06005843 RID: 22595 RVA: 0x00155761 File Offset: 0x00153961
		[DebuggerNonUserCode]
		public uint Height
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint heightDefaultValue;
				if (flag)
				{
					heightDefaultValue = this.height_;
				}
				else
				{
					heightDefaultValue = EmbedImage.HeightDefaultValue;
				}
				return heightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.height_ = value;
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06005844 RID: 22596 RVA: 0x0015577C File Offset: 0x0015397C
		[DebuggerNonUserCode]
		public bool HasHeight
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00155799 File Offset: 0x00153999
		[DebuggerNonUserCode]
		public void ClearHeight()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x001557AC File Offset: 0x001539AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EmbedImage);
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x001557CC File Offset: 0x001539CC
		[DebuggerNonUserCode]
		public bool Equals(EmbedImage other)
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
					bool flag4 = this.Url != other.Url;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Width != other.Width;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Height != other.Height;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00155858 File Offset: 0x00153A58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num ^= this.Url.GetHashCode();
			}
			bool hasWidth = this.HasWidth;
			if (hasWidth)
			{
				num ^= this.Width.GetHashCode();
			}
			bool hasHeight = this.HasHeight;
			if (hasHeight)
			{
				num ^= this.Height.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x001558E0 File Offset: 0x00153AE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x001558F8 File Offset: 0x00153AF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x00155904 File Offset: 0x00153B04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Url);
			}
			bool hasWidth = this.HasWidth;
			if (hasWidth)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Width);
			}
			bool hasHeight = this.HasHeight;
			if (hasHeight)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Height);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00155994 File Offset: 0x00153B94
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Url);
			}
			bool hasWidth = this.HasWidth;
			if (hasWidth)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Width);
			}
			bool hasHeight = this.HasHeight;
			if (hasHeight)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Height);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00155A20 File Offset: 0x00153C20
		[DebuggerNonUserCode]
		public void MergeFrom(EmbedImage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUrl = other.HasUrl;
				if (hasUrl)
				{
					this.Url = other.Url;
				}
				bool hasWidth = other.HasWidth;
				if (hasWidth)
				{
					this.Width = other.Width;
				}
				bool hasHeight = other.HasHeight;
				if (hasHeight)
				{
					this.Height = other.Height;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x00155A9B File Offset: 0x00153C9B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x00155AA8 File Offset: 0x00153CA8
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Height = input.ReadUInt32();
						}
					}
					else
					{
						this.Width = input.ReadUInt32();
					}
				}
				else
				{
					this.Url = input.ReadString();
				}
			}
		}

		// Token: 0x04002843 RID: 10307
		private static readonly MessageParser<EmbedImage> _parser = new MessageParser<EmbedImage>(() => new EmbedImage());

		// Token: 0x04002844 RID: 10308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002845 RID: 10309
		private int _hasBits0;

		// Token: 0x04002846 RID: 10310
		public const int UrlFieldNumber = 1;

		// Token: 0x04002847 RID: 10311
		private static readonly string UrlDefaultValue = "";

		// Token: 0x04002848 RID: 10312
		private string url_;

		// Token: 0x04002849 RID: 10313
		public const int WidthFieldNumber = 2;

		// Token: 0x0400284A RID: 10314
		private static readonly uint WidthDefaultValue = 0U;

		// Token: 0x0400284B RID: 10315
		private uint width_;

		// Token: 0x0400284C RID: 10316
		public const int HeightFieldNumber = 3;

		// Token: 0x0400284D RID: 10317
		private static readonly uint HeightDefaultValue = 0U;

		// Token: 0x0400284E RID: 10318
		private uint height_;
	}
}
