using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F9 RID: 1273
	public sealed class CreateMessageOptions : IMessage<CreateMessageOptions>, IMessage, IEquatable<CreateMessageOptions>, IDeepCloneable<CreateMessageOptions>, IBufferMessage
	{
		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x001E4C78 File Offset: 0x001E2E78
		[DebuggerNonUserCode]
		public static MessageParser<CreateMessageOptions> Parser
		{
			get
			{
				return CreateMessageOptions._parser;
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x06007C74 RID: 31860 RVA: 0x001E4C90 File Offset: 0x001E2E90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x06007C75 RID: 31861 RVA: 0x001E4CB4 File Offset: 0x001E2EB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateMessageOptions.Descriptor;
			}
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x001E4CCB File Offset: 0x001E2ECB
		[DebuggerNonUserCode]
		public CreateMessageOptions()
		{
		}

		// Token: 0x06007C77 RID: 31863 RVA: 0x001E4CD8 File Offset: 0x001E2ED8
		[DebuggerNonUserCode]
		public CreateMessageOptions(CreateMessageOptions other)
			: this()
		{
			this.content_ = other.content_;
			this.mention_ = ((other.mention_ != null) ? other.mention_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C78 RID: 31864 RVA: 0x001E4D28 File Offset: 0x001E2F28
		[DebuggerNonUserCode]
		public CreateMessageOptions Clone()
		{
			return new CreateMessageOptions(this);
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x001E4D40 File Offset: 0x001E2F40
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x001E4D61 File Offset: 0x001E2F61
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? CreateMessageOptions.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x001E4D78 File Offset: 0x001E2F78
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x001E4D93 File Offset: 0x001E2F93
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x001E4DA0 File Offset: 0x001E2FA0
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x001E4DB8 File Offset: 0x001E2FB8
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

		// Token: 0x06007C7F RID: 31871 RVA: 0x001E4DC4 File Offset: 0x001E2FC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateMessageOptions);
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x001E4DE4 File Offset: 0x001E2FE4
		[DebuggerNonUserCode]
		public bool Equals(CreateMessageOptions other)
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
						bool flag5 = !object.Equals(this.Mention, other.Mention);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x001E4E58 File Offset: 0x001E3058
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			bool flag = this.mention_ != null;
			if (flag)
			{
				num ^= this.Mention.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x001E4EC0 File Offset: 0x001E30C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x001E4ED8 File Offset: 0x001E30D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x001E4EE4 File Offset: 0x001E30E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Content);
			}
			bool flag = this.mention_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Mention);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x001E4F58 File Offset: 0x001E3158
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			bool flag = this.mention_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Mention);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x001E4FC8 File Offset: 0x001E31C8
		[DebuggerNonUserCode]
		public void MergeFrom(CreateMessageOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x001E504D File Offset: 0x001E324D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x001E5058 File Offset: 0x001E3258
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x0400389B RID: 14491
		private static readonly MessageParser<CreateMessageOptions> _parser = new MessageParser<CreateMessageOptions>(() => new CreateMessageOptions());

		// Token: 0x0400389C RID: 14492
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400389D RID: 14493
		public const int ContentFieldNumber = 2;

		// Token: 0x0400389E RID: 14494
		private static readonly string ContentDefaultValue = "";

		// Token: 0x0400389F RID: 14495
		private string content_;

		// Token: 0x040038A0 RID: 14496
		public const int MentionFieldNumber = 3;

		// Token: 0x040038A1 RID: 14497
		private MentionContent mention_;
	}
}
