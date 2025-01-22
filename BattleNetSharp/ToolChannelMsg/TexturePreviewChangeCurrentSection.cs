using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000042 RID: 66
	public sealed class TexturePreviewChangeCurrentSection : IMessage<TexturePreviewChangeCurrentSection>, IMessage, IEquatable<TexturePreviewChangeCurrentSection>, IDeepCloneable<TexturePreviewChangeCurrentSection>, IBufferMessage
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00018648 File Offset: 0x00016848
		[DebuggerNonUserCode]
		public static MessageParser<TexturePreviewChangeCurrentSection> Parser
		{
			get
			{
				return TexturePreviewChangeCurrentSection._parser;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00018660 File Offset: 0x00016860
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[43];
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00018684 File Offset: 0x00016884
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TexturePreviewChangeCurrentSection.Descriptor;
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0001869B File Offset: 0x0001689B
		[DebuggerNonUserCode]
		public TexturePreviewChangeCurrentSection()
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000186A8 File Offset: 0x000168A8
		[DebuggerNonUserCode]
		public TexturePreviewChangeCurrentSection(TexturePreviewChangeCurrentSection other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hwndTexturePreview_ = other.hwndTexturePreview_;
			this.currentLine_ = other.currentLine_;
			this.currentSection_ = other.currentSection_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00018700 File Offset: 0x00016900
		[DebuggerNonUserCode]
		public TexturePreviewChangeCurrentSection Clone()
		{
			return new TexturePreviewChangeCurrentSection(this);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00018718 File Offset: 0x00016918
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00018749 File Offset: 0x00016949
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
					hwndTexturePreviewDefaultValue = TexturePreviewChangeCurrentSection.HwndTexturePreviewDefaultValue;
				}
				return hwndTexturePreviewDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hwndTexturePreview_ = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00018764 File Offset: 0x00016964
		[DebuggerNonUserCode]
		public bool HasHwndTexturePreview
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00018781 File Offset: 0x00016981
		[DebuggerNonUserCode]
		public void ClearHwndTexturePreview()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00018794 File Offset: 0x00016994
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000187C5 File Offset: 0x000169C5
		[DebuggerNonUserCode]
		public int CurrentLine
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int currentLineDefaultValue;
				if (flag)
				{
					currentLineDefaultValue = this.currentLine_;
				}
				else
				{
					currentLineDefaultValue = TexturePreviewChangeCurrentSection.CurrentLineDefaultValue;
				}
				return currentLineDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.currentLine_ = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000187E0 File Offset: 0x000169E0
		[DebuggerNonUserCode]
		public bool HasCurrentLine
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000187FD File Offset: 0x000169FD
		[DebuggerNonUserCode]
		public void ClearCurrentLine()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00018810 File Offset: 0x00016A10
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00018841 File Offset: 0x00016A41
		[DebuggerNonUserCode]
		public int CurrentSection
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int currentSectionDefaultValue;
				if (flag)
				{
					currentSectionDefaultValue = this.currentSection_;
				}
				else
				{
					currentSectionDefaultValue = TexturePreviewChangeCurrentSection.CurrentSectionDefaultValue;
				}
				return currentSectionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.currentSection_ = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001885C File Offset: 0x00016A5C
		[DebuggerNonUserCode]
		public bool HasCurrentSection
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00018879 File Offset: 0x00016A79
		[DebuggerNonUserCode]
		public void ClearCurrentSection()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001888C File Offset: 0x00016A8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TexturePreviewChangeCurrentSection);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000188AC File Offset: 0x00016AAC
		[DebuggerNonUserCode]
		public bool Equals(TexturePreviewChangeCurrentSection other)
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
						bool flag5 = this.CurrentLine != other.CurrentLine;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CurrentSection != other.CurrentSection;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00018938 File Offset: 0x00016B38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHwndTexturePreview = this.HasHwndTexturePreview;
			if (hasHwndTexturePreview)
			{
				num ^= this.HwndTexturePreview.GetHashCode();
			}
			bool hasCurrentLine = this.HasCurrentLine;
			if (hasCurrentLine)
			{
				num ^= this.CurrentLine.GetHashCode();
			}
			bool hasCurrentSection = this.HasCurrentSection;
			if (hasCurrentSection)
			{
				num ^= this.CurrentSection.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000189C4 File Offset: 0x00016BC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000189DC File Offset: 0x00016BDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000189E8 File Offset: 0x00016BE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHwndTexturePreview = this.HasHwndTexturePreview;
			if (hasHwndTexturePreview)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.HwndTexturePreview);
			}
			bool hasCurrentLine = this.HasCurrentLine;
			if (hasCurrentLine)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurrentLine);
			}
			bool hasCurrentSection = this.HasCurrentSection;
			if (hasCurrentSection)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurrentSection);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00018A78 File Offset: 0x00016C78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHwndTexturePreview = this.HasHwndTexturePreview;
			if (hasHwndTexturePreview)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HwndTexturePreview);
			}
			bool hasCurrentLine = this.HasCurrentLine;
			if (hasCurrentLine)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentLine);
			}
			bool hasCurrentSection = this.HasCurrentSection;
			if (hasCurrentSection)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentSection);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00018B04 File Offset: 0x00016D04
		[DebuggerNonUserCode]
		public void MergeFrom(TexturePreviewChangeCurrentSection other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHwndTexturePreview = other.HasHwndTexturePreview;
				if (hasHwndTexturePreview)
				{
					this.HwndTexturePreview = other.HwndTexturePreview;
				}
				bool hasCurrentLine = other.HasCurrentLine;
				if (hasCurrentLine)
				{
					this.CurrentLine = other.CurrentLine;
				}
				bool hasCurrentSection = other.HasCurrentSection;
				if (hasCurrentSection)
				{
					this.CurrentSection = other.CurrentSection;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00018B7F File Offset: 0x00016D7F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00018B8C File Offset: 0x00016D8C
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
							this.CurrentSection = input.ReadInt32();
						}
					}
					else
					{
						this.CurrentLine = input.ReadInt32();
					}
				}
				else
				{
					this.HwndTexturePreview = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400022C RID: 556
		private static readonly MessageParser<TexturePreviewChangeCurrentSection> _parser = new MessageParser<TexturePreviewChangeCurrentSection>(() => new TexturePreviewChangeCurrentSection());

		// Token: 0x0400022D RID: 557
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400022E RID: 558
		private int _hasBits0;

		// Token: 0x0400022F RID: 559
		public const int HwndTexturePreviewFieldNumber = 1;

		// Token: 0x04000230 RID: 560
		private static readonly long HwndTexturePreviewDefaultValue = 0L;

		// Token: 0x04000231 RID: 561
		private long hwndTexturePreview_;

		// Token: 0x04000232 RID: 562
		public const int CurrentLineFieldNumber = 2;

		// Token: 0x04000233 RID: 563
		private static readonly int CurrentLineDefaultValue = 0;

		// Token: 0x04000234 RID: 564
		private int currentLine_;

		// Token: 0x04000235 RID: 565
		public const int CurrentSectionFieldNumber = 3;

		// Token: 0x04000236 RID: 566
		private static readonly int CurrentSectionDefaultValue = 0;

		// Token: 0x04000237 RID: 567
		private int currentSection_;
	}
}
