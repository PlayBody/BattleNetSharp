using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000041 RID: 65
	public sealed class TexturePreviewChangeCurrentFrame : IMessage<TexturePreviewChangeCurrentFrame>, IMessage, IEquatable<TexturePreviewChangeCurrentFrame>, IDeepCloneable<TexturePreviewChangeCurrentFrame>, IBufferMessage
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00018198 File Offset: 0x00016398
		[DebuggerNonUserCode]
		public static MessageParser<TexturePreviewChangeCurrentFrame> Parser
		{
			get
			{
				return TexturePreviewChangeCurrentFrame._parser;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x000181B0 File Offset: 0x000163B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[42];
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000181D4 File Offset: 0x000163D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TexturePreviewChangeCurrentFrame.Descriptor;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000181EB File Offset: 0x000163EB
		[DebuggerNonUserCode]
		public TexturePreviewChangeCurrentFrame()
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000181F5 File Offset: 0x000163F5
		[DebuggerNonUserCode]
		public TexturePreviewChangeCurrentFrame(TexturePreviewChangeCurrentFrame other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hwndTexturePreview_ = other.hwndTexturePreview_;
			this.currentFrame_ = other.currentFrame_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00018234 File Offset: 0x00016434
		[DebuggerNonUserCode]
		public TexturePreviewChangeCurrentFrame Clone()
		{
			return new TexturePreviewChangeCurrentFrame(this);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001824C File Offset: 0x0001644C
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x0001827D File Offset: 0x0001647D
		[DebuggerNonUserCode]
		public long HwndTexturePreview
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				long hwndTexturePreviewDefaultValue;
				if (flag)
				{
					hwndTexturePreviewDefaultValue = this.hwndTexturePreview_;
				}
				else
				{
					hwndTexturePreviewDefaultValue = TexturePreviewChangeCurrentFrame.HwndTexturePreviewDefaultValue;
				}
				return hwndTexturePreviewDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hwndTexturePreview_ = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00018298 File Offset: 0x00016498
		[DebuggerNonUserCode]
		public bool HasHwndTexturePreview
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000182B5 File Offset: 0x000164B5
		[DebuggerNonUserCode]
		public void ClearHwndTexturePreview()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000182C8 File Offset: 0x000164C8
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x000182F9 File Offset: 0x000164F9
		[DebuggerNonUserCode]
		public int CurrentFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int currentFrameDefaultValue;
				if (flag)
				{
					currentFrameDefaultValue = this.currentFrame_;
				}
				else
				{
					currentFrameDefaultValue = TexturePreviewChangeCurrentFrame.CurrentFrameDefaultValue;
				}
				return currentFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.currentFrame_ = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00018314 File Offset: 0x00016514
		[DebuggerNonUserCode]
		public bool HasCurrentFrame
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00018331 File Offset: 0x00016531
		[DebuggerNonUserCode]
		public void ClearCurrentFrame()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00018344 File Offset: 0x00016544
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TexturePreviewChangeCurrentFrame);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00018364 File Offset: 0x00016564
		[DebuggerNonUserCode]
		public bool Equals(TexturePreviewChangeCurrentFrame other)
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
					bool flag4 = this.HwndTexturePreview != other.HwndTexturePreview;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CurrentFrame != other.CurrentFrame;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000183D8 File Offset: 0x000165D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHwndTexturePreview = this.HasHwndTexturePreview;
			if (hasHwndTexturePreview)
			{
				num ^= this.HwndTexturePreview.GetHashCode();
			}
			bool hasCurrentFrame = this.HasCurrentFrame;
			if (hasCurrentFrame)
			{
				num ^= this.CurrentFrame.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00018448 File Offset: 0x00016648
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00018460 File Offset: 0x00016660
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001846C File Offset: 0x0001666C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHwndTexturePreview = this.HasHwndTexturePreview;
			if (hasHwndTexturePreview)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.HwndTexturePreview);
			}
			bool hasCurrentFrame = this.HasCurrentFrame;
			if (hasCurrentFrame)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurrentFrame);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000184DC File Offset: 0x000166DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHwndTexturePreview = this.HasHwndTexturePreview;
			if (hasHwndTexturePreview)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HwndTexturePreview);
			}
			bool hasCurrentFrame = this.HasCurrentFrame;
			if (hasCurrentFrame)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentFrame);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00018548 File Offset: 0x00016748
		[DebuggerNonUserCode]
		public void MergeFrom(TexturePreviewChangeCurrentFrame other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHwndTexturePreview = other.HasHwndTexturePreview;
				if (hasHwndTexturePreview)
				{
					this.HwndTexturePreview = other.HwndTexturePreview;
				}
				bool hasCurrentFrame = other.HasCurrentFrame;
				if (hasCurrentFrame)
				{
					this.CurrentFrame = other.CurrentFrame;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000185AA File Offset: 0x000167AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000185B8 File Offset: 0x000167B8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurrentFrame = input.ReadInt32();
					}
				}
				else
				{
					this.HwndTexturePreview = input.ReadInt64();
				}
			}
		}

		// Token: 0x04000223 RID: 547
		private static readonly MessageParser<TexturePreviewChangeCurrentFrame> _parser = new MessageParser<TexturePreviewChangeCurrentFrame>(() => new TexturePreviewChangeCurrentFrame());

		// Token: 0x04000224 RID: 548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000225 RID: 549
		private int _hasBits0;

		// Token: 0x04000226 RID: 550
		public const int HwndTexturePreviewFieldNumber = 1;

		// Token: 0x04000227 RID: 551
		private static readonly long HwndTexturePreviewDefaultValue = 0L;

		// Token: 0x04000228 RID: 552
		private long hwndTexturePreview_;

		// Token: 0x04000229 RID: 553
		public const int CurrentFrameFieldNumber = 2;

		// Token: 0x0400022A RID: 554
		private static readonly int CurrentFrameDefaultValue = 0;

		// Token: 0x0400022B RID: 555
		private int currentFrame_;
	}
}
