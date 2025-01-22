using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004FB RID: 1275
	public sealed class ContentChain : IMessage<ContentChain>, IMessage, IEquatable<ContentChain>, IDeepCloneable<ContentChain>, IBufferMessage
	{
		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x06007C9C RID: 31900 RVA: 0x001E5400 File Offset: 0x001E3600
		[DebuggerNonUserCode]
		public static MessageParser<ContentChain> Parser
		{
			get
			{
				return ContentChain._parser;
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x06007C9D RID: 31901 RVA: 0x001E5418 File Offset: 0x001E3618
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x06007C9E RID: 31902 RVA: 0x001E543C File Offset: 0x001E363C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentChain.Descriptor;
			}
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x001E5453 File Offset: 0x001E3653
		[DebuggerNonUserCode]
		public ContentChain()
		{
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x001E5468 File Offset: 0x001E3668
		[DebuggerNonUserCode]
		public ContentChain(ContentChain other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.content_ = other.content_;
			this.embed_ = other.embed_.Clone();
			this.mention_ = ((other.mention_ != null) ? other.mention_.Clone() : null);
			this.editTime_ = other.editTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x001E54E0 File Offset: 0x001E36E0
		[DebuggerNonUserCode]
		public ContentChain Clone()
		{
			return new ContentChain(this);
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x06007CA2 RID: 31906 RVA: 0x001E54F8 File Offset: 0x001E36F8
		// (set) Token: 0x06007CA3 RID: 31907 RVA: 0x001E5519 File Offset: 0x001E3719
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? ContentChain.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x06007CA4 RID: 31908 RVA: 0x001E5530 File Offset: 0x001E3730
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x001E554B File Offset: 0x001E374B
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x06007CA6 RID: 31910 RVA: 0x001E5558 File Offset: 0x001E3758
		[DebuggerNonUserCode]
		public RepeatedField<EmbedInfo> Embed
		{
			get
			{
				return this.embed_;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x06007CA7 RID: 31911 RVA: 0x001E5570 File Offset: 0x001E3770
		// (set) Token: 0x06007CA8 RID: 31912 RVA: 0x001E5588 File Offset: 0x001E3788
		[DebuggerNonUserCode]
		public MentionContent Mention
		{
			get
			{
				return this.mention_;
			}
			set
			{
				this.mention_ = value;
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x06007CA9 RID: 31913 RVA: 0x001E5594 File Offset: 0x001E3794
		// (set) Token: 0x06007CAA RID: 31914 RVA: 0x001E55C5 File Offset: 0x001E37C5
		[DebuggerNonUserCode]
		public ulong EditTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong editTimeDefaultValue;
				if (flag)
				{
					editTimeDefaultValue = this.editTime_;
				}
				else
				{
					editTimeDefaultValue = ContentChain.EditTimeDefaultValue;
				}
				return editTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.editTime_ = value;
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x06007CAB RID: 31915 RVA: 0x001E55E0 File Offset: 0x001E37E0
		[DebuggerNonUserCode]
		public bool HasEditTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x001E55FD File Offset: 0x001E37FD
		[DebuggerNonUserCode]
		public void ClearEditTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x001E5610 File Offset: 0x001E3810
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentChain);
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x001E5630 File Offset: 0x001E3830
		[DebuggerNonUserCode]
		public bool Equals(ContentChain other)
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
						bool flag5 = !this.embed_.Equals(other.embed_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Mention, other.Mention);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.EditTime != other.EditTime;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x001E56E4 File Offset: 0x001E38E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			num ^= this.embed_.GetHashCode();
			bool flag = this.mention_ != null;
			if (flag)
			{
				num ^= this.Mention.GetHashCode();
			}
			bool hasEditTime = this.HasEditTime;
			if (hasEditTime)
			{
				num ^= this.EditTime.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x001E5778 File Offset: 0x001E3978
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x001E5790 File Offset: 0x001E3990
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x001E579C File Offset: 0x001E399C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Content);
			}
			this.embed_.WriteTo(ref output, ContentChain._repeated_embed_codec);
			bool flag = this.mention_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Mention);
			}
			bool hasEditTime = this.HasEditTime;
			if (hasEditTime)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.EditTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x001E5844 File Offset: 0x001E3A44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			num += this.embed_.CalculateSize(ContentChain._repeated_embed_codec);
			bool flag = this.mention_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Mention);
			}
			bool hasEditTime = this.HasEditTime;
			if (hasEditTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EditTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x001E58E4 File Offset: 0x001E3AE4
		[DebuggerNonUserCode]
		public void MergeFrom(ContentChain other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
				this.embed_.Add(other.embed_);
				bool flag2 = other.mention_ != null;
				if (flag2)
				{
					bool flag3 = this.mention_ == null;
					if (flag3)
					{
						this.Mention = new MentionContent();
					}
					this.Mention.MergeFrom(other.Mention);
				}
				bool hasEditTime = other.HasEditTime;
				if (hasEditTime)
				{
					this.EditTime = other.EditTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x001E5999 File Offset: 0x001E3B99
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CB6 RID: 31926 RVA: 0x001E59A4 File Offset: 0x001E3BA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_002C;
						}
						this.embed_.AddEntriesFrom(ref input, ContentChain._repeated_embed_codec);
					}
					else
					{
						this.Content = input.ReadString();
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 64U)
					{
						goto IL_002C;
					}
					this.EditTime = input.ReadUInt64();
				}
				else
				{
					bool flag = this.mention_ == null;
					if (flag)
					{
						this.Mention = new MentionContent();
					}
					input.ReadMessage(this.Mention);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038A7 RID: 14503
		private static readonly MessageParser<ContentChain> _parser = new MessageParser<ContentChain>(() => new ContentChain());

		// Token: 0x040038A8 RID: 14504
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038A9 RID: 14505
		private int _hasBits0;

		// Token: 0x040038AA RID: 14506
		public const int ContentFieldNumber = 5;

		// Token: 0x040038AB RID: 14507
		private static readonly string ContentDefaultValue = "";

		// Token: 0x040038AC RID: 14508
		private string content_;

		// Token: 0x040038AD RID: 14509
		public const int EmbedFieldNumber = 6;

		// Token: 0x040038AE RID: 14510
		private static readonly FieldCodec<EmbedInfo> _repeated_embed_codec = FieldCodec.ForMessage<EmbedInfo>(50U, EmbedInfo.Parser);

		// Token: 0x040038AF RID: 14511
		private readonly RepeatedField<EmbedInfo> embed_ = new RepeatedField<EmbedInfo>();

		// Token: 0x040038B0 RID: 14512
		public const int MentionFieldNumber = 7;

		// Token: 0x040038B1 RID: 14513
		private MentionContent mention_;

		// Token: 0x040038B2 RID: 14514
		public const int EditTimeFieldNumber = 8;

		// Token: 0x040038B3 RID: 14515
		private static readonly ulong EditTimeDefaultValue = 0UL;

		// Token: 0x040038B4 RID: 14516
		private ulong editTime_;
	}
}
