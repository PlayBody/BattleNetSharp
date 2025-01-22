using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000061 RID: 97
	public sealed class ImageFrameInfo : IMessage<ImageFrameInfo>, IMessage, IEquatable<ImageFrameInfo>, IDeepCloneable<ImageFrameInfo>, IBufferMessage
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x000225A4 File Offset: 0x000207A4
		[DebuggerNonUserCode]
		public static MessageParser<ImageFrameInfo> Parser
		{
			get
			{
				return ImageFrameInfo._parser;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x000225BC File Offset: 0x000207BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[74];
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000225E0 File Offset: 0x000207E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ImageFrameInfo.Descriptor;
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000225F7 File Offset: 0x000207F7
		[DebuggerNonUserCode]
		public ImageFrameInfo()
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00022601 File Offset: 0x00020801
		[DebuggerNonUserCode]
		public ImageFrameInfo(ImageFrameInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoTexture_ = other.snoTexture_;
			this.deleted_ = other.deleted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00022640 File Offset: 0x00020840
		[DebuggerNonUserCode]
		public ImageFrameInfo Clone()
		{
			return new ImageFrameInfo(this);
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00022658 File Offset: 0x00020858
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00022689 File Offset: 0x00020889
		[DebuggerNonUserCode]
		public int SnoTexture
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoTextureDefaultValue;
				if (flag)
				{
					snoTextureDefaultValue = this.snoTexture_;
				}
				else
				{
					snoTextureDefaultValue = ImageFrameInfo.SnoTextureDefaultValue;
				}
				return snoTextureDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoTexture_ = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x000226A4 File Offset: 0x000208A4
		[DebuggerNonUserCode]
		public bool HasSnoTexture
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000226C1 File Offset: 0x000208C1
		[DebuggerNonUserCode]
		public void ClearSnoTexture()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x000226D4 File Offset: 0x000208D4
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x00022705 File Offset: 0x00020905
		[DebuggerNonUserCode]
		public bool Deleted
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool deletedDefaultValue;
				if (flag)
				{
					deletedDefaultValue = this.deleted_;
				}
				else
				{
					deletedDefaultValue = ImageFrameInfo.DeletedDefaultValue;
				}
				return deletedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.deleted_ = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00022720 File Offset: 0x00020920
		[DebuggerNonUserCode]
		public bool HasDeleted
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0002273D File Offset: 0x0002093D
		[DebuggerNonUserCode]
		public void ClearDeleted()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00022750 File Offset: 0x00020950
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ImageFrameInfo);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00022770 File Offset: 0x00020970
		[DebuggerNonUserCode]
		public bool Equals(ImageFrameInfo other)
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
					bool flag4 = this.SnoTexture != other.SnoTexture;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Deleted != other.Deleted;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000227E4 File Offset: 0x000209E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoTexture = this.HasSnoTexture;
			if (hasSnoTexture)
			{
				num ^= this.SnoTexture.GetHashCode();
			}
			bool hasDeleted = this.HasDeleted;
			if (hasDeleted)
			{
				num ^= this.Deleted.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00022854 File Offset: 0x00020A54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0002286C File Offset: 0x00020A6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00022878 File Offset: 0x00020A78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoTexture = this.HasSnoTexture;
			if (hasSnoTexture)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoTexture);
			}
			bool hasDeleted = this.HasDeleted;
			if (hasDeleted)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Deleted);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000228E8 File Offset: 0x00020AE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoTexture = this.HasSnoTexture;
			if (hasSnoTexture)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoTexture);
			}
			bool hasDeleted = this.HasDeleted;
			if (hasDeleted)
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

		// Token: 0x06000861 RID: 2145 RVA: 0x00022948 File Offset: 0x00020B48
		[DebuggerNonUserCode]
		public void MergeFrom(ImageFrameInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoTexture = other.HasSnoTexture;
				if (hasSnoTexture)
				{
					this.SnoTexture = other.SnoTexture;
				}
				bool hasDeleted = other.HasDeleted;
				if (hasDeleted)
				{
					this.Deleted = other.Deleted;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000229AA File Offset: 0x00020BAA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000229B8 File Offset: 0x00020BB8
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
						this.Deleted = input.ReadBool();
					}
				}
				else
				{
					this.SnoTexture = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000361 RID: 865
		private static readonly MessageParser<ImageFrameInfo> _parser = new MessageParser<ImageFrameInfo>(() => new ImageFrameInfo());

		// Token: 0x04000362 RID: 866
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000363 RID: 867
		private int _hasBits0;

		// Token: 0x04000364 RID: 868
		public const int SnoTextureFieldNumber = 1;

		// Token: 0x04000365 RID: 869
		private static readonly int SnoTextureDefaultValue = 0;

		// Token: 0x04000366 RID: 870
		private int snoTexture_;

		// Token: 0x04000367 RID: 871
		public const int DeletedFieldNumber = 2;

		// Token: 0x04000368 RID: 872
		private static readonly bool DeletedDefaultValue = false;

		// Token: 0x04000369 RID: 873
		private bool deleted_;
	}
}
