using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000044 RID: 68
	public sealed class TextureInformation : IMessage<TextureInformation>, IMessage, IEquatable<TextureInformation>, IDeepCloneable<TextureInformation>, IBufferMessage
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00018FAC File Offset: 0x000171AC
		[DebuggerNonUserCode]
		public static MessageParser<TextureInformation> Parser
		{
			get
			{
				return TextureInformation._parser;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00018FC4 File Offset: 0x000171C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[45];
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00018FE8 File Offset: 0x000171E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextureInformation.Descriptor;
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00018FFF File Offset: 0x000171FF
		[DebuggerNonUserCode]
		public TextureInformation()
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001900C File Offset: 0x0001720C
		[DebuggerNonUserCode]
		public TextureInformation(TextureInformation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.width_ = other.width_;
			this.height_ = other.height_;
			this.estimatedSize_ = other.estimatedSize_;
			this.avgColor_ = ((other.avgColor_ != null) ? other.avgColor_.Clone() : null);
			this.originalWidth_ = other.originalWidth_;
			this.originalHeight_ = other.originalHeight_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000190A4 File Offset: 0x000172A4
		[DebuggerNonUserCode]
		public TextureInformation Clone()
		{
			return new TextureInformation(this);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x000190BC File Offset: 0x000172BC
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x000190ED File Offset: 0x000172ED
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
					snoHandleDefaultValue = TextureInformation.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00019108 File Offset: 0x00017308
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00019125 File Offset: 0x00017325
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00019138 File Offset: 0x00017338
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00019169 File Offset: 0x00017369
		[DebuggerNonUserCode]
		public int Width
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int widthDefaultValue;
				if (flag)
				{
					widthDefaultValue = this.width_;
				}
				else
				{
					widthDefaultValue = TextureInformation.WidthDefaultValue;
				}
				return widthDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.width_ = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00019184 File Offset: 0x00017384
		[DebuggerNonUserCode]
		public bool HasWidth
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000191A1 File Offset: 0x000173A1
		[DebuggerNonUserCode]
		public void ClearWidth()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000191B4 File Offset: 0x000173B4
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x000191E5 File Offset: 0x000173E5
		[DebuggerNonUserCode]
		public int Height
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int heightDefaultValue;
				if (flag)
				{
					heightDefaultValue = this.height_;
				}
				else
				{
					heightDefaultValue = TextureInformation.HeightDefaultValue;
				}
				return heightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.height_ = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00019200 File Offset: 0x00017400
		[DebuggerNonUserCode]
		public bool HasHeight
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001921D File Offset: 0x0001741D
		[DebuggerNonUserCode]
		public void ClearHeight()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00019230 File Offset: 0x00017430
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00019261 File Offset: 0x00017461
		[DebuggerNonUserCode]
		public int EstimatedSize
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int estimatedSizeDefaultValue;
				if (flag)
				{
					estimatedSizeDefaultValue = this.estimatedSize_;
				}
				else
				{
					estimatedSizeDefaultValue = TextureInformation.EstimatedSizeDefaultValue;
				}
				return estimatedSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.estimatedSize_ = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001927C File Offset: 0x0001747C
		[DebuggerNonUserCode]
		public bool HasEstimatedSize
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00019299 File Offset: 0x00017499
		[DebuggerNonUserCode]
		public void ClearEstimatedSize()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000192AC File Offset: 0x000174AC
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000192C4 File Offset: 0x000174C4
		[DebuggerNonUserCode]
		public Vector3 AvgColor
		{
			get
			{
				return this.avgColor_;
			}
			set
			{
				this.avgColor_ = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000192D0 File Offset: 0x000174D0
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00019302 File Offset: 0x00017502
		[DebuggerNonUserCode]
		public int OriginalWidth
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int originalWidthDefaultValue;
				if (flag)
				{
					originalWidthDefaultValue = this.originalWidth_;
				}
				else
				{
					originalWidthDefaultValue = TextureInformation.OriginalWidthDefaultValue;
				}
				return originalWidthDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.originalWidth_ = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001931C File Offset: 0x0001751C
		[DebuggerNonUserCode]
		public bool HasOriginalWidth
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001933A File Offset: 0x0001753A
		[DebuggerNonUserCode]
		public void ClearOriginalWidth()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0001934C File Offset: 0x0001754C
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0001937E File Offset: 0x0001757E
		[DebuggerNonUserCode]
		public int OriginalHeight
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				int originalHeightDefaultValue;
				if (flag)
				{
					originalHeightDefaultValue = this.originalHeight_;
				}
				else
				{
					originalHeightDefaultValue = TextureInformation.OriginalHeightDefaultValue;
				}
				return originalHeightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.originalHeight_ = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00019398 File Offset: 0x00017598
		[DebuggerNonUserCode]
		public bool HasOriginalHeight
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000193B6 File Offset: 0x000175B6
		[DebuggerNonUserCode]
		public void ClearOriginalHeight()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000193C8 File Offset: 0x000175C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextureInformation);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000193E8 File Offset: 0x000175E8
		[DebuggerNonUserCode]
		public bool Equals(TextureInformation other)
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
						bool flag5 = this.Width != other.Width;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Height != other.Height;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.EstimatedSize != other.EstimatedSize;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.AvgColor, other.AvgColor);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.OriginalWidth != other.OriginalWidth;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.OriginalHeight != other.OriginalHeight;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06000581 RID: 1409 RVA: 0x000194F4 File Offset: 0x000176F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
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
			bool hasEstimatedSize = this.HasEstimatedSize;
			if (hasEstimatedSize)
			{
				num ^= this.EstimatedSize.GetHashCode();
			}
			bool flag = this.avgColor_ != null;
			if (flag)
			{
				num ^= this.AvgColor.GetHashCode();
			}
			bool hasOriginalWidth = this.HasOriginalWidth;
			if (hasOriginalWidth)
			{
				num ^= this.OriginalWidth.GetHashCode();
			}
			bool hasOriginalHeight = this.HasOriginalHeight;
			if (hasOriginalHeight)
			{
				num ^= this.OriginalHeight.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000195F4 File Offset: 0x000177F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001960C File Offset: 0x0001780C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00019618 File Offset: 0x00017818
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasWidth = this.HasWidth;
			if (hasWidth)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Width);
			}
			bool hasHeight = this.HasHeight;
			if (hasHeight)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Height);
			}
			bool hasEstimatedSize = this.HasEstimatedSize;
			if (hasEstimatedSize)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EstimatedSize);
			}
			bool flag = this.avgColor_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.AvgColor);
			}
			bool hasOriginalWidth = this.HasOriginalWidth;
			if (hasOriginalWidth)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.OriginalWidth);
			}
			bool hasOriginalHeight = this.HasOriginalHeight;
			if (hasOriginalHeight)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.OriginalHeight);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001973C File Offset: 0x0001793C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasWidth = this.HasWidth;
			if (hasWidth)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Width);
			}
			bool hasHeight = this.HasHeight;
			if (hasHeight)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Height);
			}
			bool hasEstimatedSize = this.HasEstimatedSize;
			if (hasEstimatedSize)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EstimatedSize);
			}
			bool flag = this.avgColor_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AvgColor);
			}
			bool hasOriginalWidth = this.HasOriginalWidth;
			if (hasOriginalWidth)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginalWidth);
			}
			bool hasOriginalHeight = this.HasOriginalHeight;
			if (hasOriginalHeight)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginalHeight);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00019844 File Offset: 0x00017A44
		[DebuggerNonUserCode]
		public void MergeFrom(TextureInformation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
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
				bool hasEstimatedSize = other.HasEstimatedSize;
				if (hasEstimatedSize)
				{
					this.EstimatedSize = other.EstimatedSize;
				}
				bool flag2 = other.avgColor_ != null;
				if (flag2)
				{
					bool flag3 = this.avgColor_ == null;
					if (flag3)
					{
						this.AvgColor = new Vector3();
					}
					this.AvgColor.MergeFrom(other.AvgColor);
				}
				bool hasOriginalWidth = other.HasOriginalWidth;
				if (hasOriginalWidth)
				{
					this.OriginalWidth = other.OriginalWidth;
				}
				bool hasOriginalHeight = other.HasOriginalHeight;
				if (hasOriginalHeight)
				{
					this.OriginalHeight = other.OriginalHeight;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00019953 File Offset: 0x00017B53
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00019960 File Offset: 0x00017B60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_004B;
							}
							this.Height = input.ReadInt32();
						}
						else
						{
							this.Width = input.ReadInt32();
						}
					}
					else
					{
						this.SnoHandle = input.ReadInt32();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_004B;
						}
						bool flag = this.avgColor_ == null;
						if (flag)
						{
							this.AvgColor = new Vector3();
						}
						input.ReadMessage(this.AvgColor);
					}
					else
					{
						this.EstimatedSize = input.ReadInt32();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 56U)
					{
						goto IL_004B;
					}
					this.OriginalHeight = input.ReadInt32();
				}
				else
				{
					this.OriginalWidth = input.ReadInt32();
				}
				continue;
				IL_004B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400023E RID: 574
		private static readonly MessageParser<TextureInformation> _parser = new MessageParser<TextureInformation>(() => new TextureInformation());

		// Token: 0x0400023F RID: 575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000240 RID: 576
		private int _hasBits0;

		// Token: 0x04000241 RID: 577
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000242 RID: 578
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000243 RID: 579
		private int snoHandle_;

		// Token: 0x04000244 RID: 580
		public const int WidthFieldNumber = 2;

		// Token: 0x04000245 RID: 581
		private static readonly int WidthDefaultValue = 0;

		// Token: 0x04000246 RID: 582
		private int width_;

		// Token: 0x04000247 RID: 583
		public const int HeightFieldNumber = 3;

		// Token: 0x04000248 RID: 584
		private static readonly int HeightDefaultValue = 0;

		// Token: 0x04000249 RID: 585
		private int height_;

		// Token: 0x0400024A RID: 586
		public const int EstimatedSizeFieldNumber = 4;

		// Token: 0x0400024B RID: 587
		private static readonly int EstimatedSizeDefaultValue = 0;

		// Token: 0x0400024C RID: 588
		private int estimatedSize_;

		// Token: 0x0400024D RID: 589
		public const int AvgColorFieldNumber = 5;

		// Token: 0x0400024E RID: 590
		private Vector3 avgColor_;

		// Token: 0x0400024F RID: 591
		public const int OriginalWidthFieldNumber = 6;

		// Token: 0x04000250 RID: 592
		private static readonly int OriginalWidthDefaultValue = 0;

		// Token: 0x04000251 RID: 593
		private int originalWidth_;

		// Token: 0x04000252 RID: 594
		public const int OriginalHeightFieldNumber = 7;

		// Token: 0x04000253 RID: 595
		private static readonly int OriginalHeightDefaultValue = 0;

		// Token: 0x04000254 RID: 596
		private int originalHeight_;
	}
}
