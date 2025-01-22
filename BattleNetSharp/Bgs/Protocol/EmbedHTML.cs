using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000354 RID: 852
	public sealed class EmbedHTML : IMessage<EmbedHTML>, IMessage, IEquatable<EmbedHTML>, IDeepCloneable<EmbedHTML>, IBufferMessage
	{
		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06005866 RID: 22630 RVA: 0x00155EA4 File Offset: 0x001540A4
		[DebuggerNonUserCode]
		public static MessageParser<EmbedHTML> Parser
		{
			get
			{
				return EmbedHTML._parser;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x00155EBC File Offset: 0x001540BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EmbedTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x00155EE0 File Offset: 0x001540E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EmbedHTML.Descriptor;
			}
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x00155EF7 File Offset: 0x001540F7
		[DebuggerNonUserCode]
		public EmbedHTML()
		{
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x00155F04 File Offset: 0x00154104
		[DebuggerNonUserCode]
		public EmbedHTML(EmbedHTML other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.content_ = other.content_;
			this.width_ = other.width_;
			this.height_ = other.height_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x00155F5C File Offset: 0x0015415C
		[DebuggerNonUserCode]
		public EmbedHTML Clone()
		{
			return new EmbedHTML(this);
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x0600586C RID: 22636 RVA: 0x00155F74 File Offset: 0x00154174
		// (set) Token: 0x0600586D RID: 22637 RVA: 0x00155F95 File Offset: 0x00154195
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? EmbedHTML.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x0600586E RID: 22638 RVA: 0x00155FAC File Offset: 0x001541AC
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x00155FC7 File Offset: 0x001541C7
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06005870 RID: 22640 RVA: 0x00155FD4 File Offset: 0x001541D4
		// (set) Token: 0x06005871 RID: 22641 RVA: 0x00156005 File Offset: 0x00154205
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
					widthDefaultValue = EmbedHTML.WidthDefaultValue;
				}
				return widthDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.width_ = value;
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x00156020 File Offset: 0x00154220
		[DebuggerNonUserCode]
		public bool HasWidth
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x0015603D File Offset: 0x0015423D
		[DebuggerNonUserCode]
		public void ClearWidth()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x00156050 File Offset: 0x00154250
		// (set) Token: 0x06005875 RID: 22645 RVA: 0x00156081 File Offset: 0x00154281
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
					heightDefaultValue = EmbedHTML.HeightDefaultValue;
				}
				return heightDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.height_ = value;
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06005876 RID: 22646 RVA: 0x0015609C File Offset: 0x0015429C
		[DebuggerNonUserCode]
		public bool HasHeight
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x001560B9 File Offset: 0x001542B9
		[DebuggerNonUserCode]
		public void ClearHeight()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x001560CC File Offset: 0x001542CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EmbedHTML);
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x001560EC File Offset: 0x001542EC
		[DebuggerNonUserCode]
		public bool Equals(EmbedHTML other)
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
					bool flag4 = this.Content != other.Content;
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

		// Token: 0x0600587A RID: 22650 RVA: 0x00156178 File Offset: 0x00154378
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
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

		// Token: 0x0600587B RID: 22651 RVA: 0x00156200 File Offset: 0x00154400
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x00156218 File Offset: 0x00154418
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x00156224 File Offset: 0x00154424
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Content);
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

		// Token: 0x0600587E RID: 22654 RVA: 0x001562B4 File Offset: 0x001544B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
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

		// Token: 0x0600587F RID: 22655 RVA: 0x00156340 File Offset: 0x00154540
		[DebuggerNonUserCode]
		public void MergeFrom(EmbedHTML other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
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

		// Token: 0x06005880 RID: 22656 RVA: 0x001563BB File Offset: 0x001545BB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x001563C8 File Offset: 0x001545C8
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
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x04002854 RID: 10324
		private static readonly MessageParser<EmbedHTML> _parser = new MessageParser<EmbedHTML>(() => new EmbedHTML());

		// Token: 0x04002855 RID: 10325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002856 RID: 10326
		private int _hasBits0;

		// Token: 0x04002857 RID: 10327
		public const int ContentFieldNumber = 1;

		// Token: 0x04002858 RID: 10328
		private static readonly string ContentDefaultValue = "";

		// Token: 0x04002859 RID: 10329
		private string content_;

		// Token: 0x0400285A RID: 10330
		public const int WidthFieldNumber = 2;

		// Token: 0x0400285B RID: 10331
		private static readonly uint WidthDefaultValue = 0U;

		// Token: 0x0400285C RID: 10332
		private uint width_;

		// Token: 0x0400285D RID: 10333
		public const int HeightFieldNumber = 3;

		// Token: 0x0400285E RID: 10334
		private static readonly uint HeightDefaultValue = 0U;

		// Token: 0x0400285F RID: 10335
		private uint height_;
	}
}
