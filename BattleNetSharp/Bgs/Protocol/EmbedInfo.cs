using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000355 RID: 853
	public sealed class EmbedInfo : IMessage<EmbedInfo>, IMessage, IEquatable<EmbedInfo>, IDeepCloneable<EmbedInfo>, IBufferMessage
	{
		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x00156478 File Offset: 0x00154678
		[DebuggerNonUserCode]
		public static MessageParser<EmbedInfo> Parser
		{
			get
			{
				return EmbedInfo._parser;
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06005884 RID: 22660 RVA: 0x00156490 File Offset: 0x00154690
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EmbedTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x001564B4 File Offset: 0x001546B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EmbedInfo.Descriptor;
			}
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x001564CB File Offset: 0x001546CB
		[DebuggerNonUserCode]
		public EmbedInfo()
		{
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x001564D8 File Offset: 0x001546D8
		[DebuggerNonUserCode]
		public EmbedInfo(EmbedInfo other)
			: this()
		{
			this.title_ = other.title_;
			this.type_ = other.type_;
			this.originalUrl_ = other.originalUrl_;
			this.thumbnail_ = ((other.thumbnail_ != null) ? other.thumbnail_.Clone() : null);
			this.provider_ = ((other.provider_ != null) ? other.provider_.Clone() : null);
			this.description_ = other.description_;
			this.html_ = ((other.html_ != null) ? other.html_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x00156584 File Offset: 0x00154784
		[DebuggerNonUserCode]
		public EmbedInfo Clone()
		{
			return new EmbedInfo(this);
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x0015659C File Offset: 0x0015479C
		// (set) Token: 0x0600588A RID: 22666 RVA: 0x001565BD File Offset: 0x001547BD
		[DebuggerNonUserCode]
		public string Title
		{
			get
			{
				return this.title_ ?? EmbedInfo.TitleDefaultValue;
			}
			set
			{
				this.title_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x0600588B RID: 22667 RVA: 0x001565D4 File Offset: 0x001547D4
		[DebuggerNonUserCode]
		public bool HasTitle
		{
			get
			{
				return this.title_ != null;
			}
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x001565EF File Offset: 0x001547EF
		[DebuggerNonUserCode]
		public void ClearTitle()
		{
			this.title_ = null;
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x0600588D RID: 22669 RVA: 0x001565FC File Offset: 0x001547FC
		// (set) Token: 0x0600588E RID: 22670 RVA: 0x0015661D File Offset: 0x0015481D
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? EmbedInfo.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600588F RID: 22671 RVA: 0x00156634 File Offset: 0x00154834
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x0015664F File Offset: 0x0015484F
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06005891 RID: 22673 RVA: 0x0015665C File Offset: 0x0015485C
		// (set) Token: 0x06005892 RID: 22674 RVA: 0x0015667D File Offset: 0x0015487D
		[DebuggerNonUserCode]
		public string OriginalUrl
		{
			get
			{
				return this.originalUrl_ ?? EmbedInfo.OriginalUrlDefaultValue;
			}
			set
			{
				this.originalUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06005893 RID: 22675 RVA: 0x00156694 File Offset: 0x00154894
		[DebuggerNonUserCode]
		public bool HasOriginalUrl
		{
			get
			{
				return this.originalUrl_ != null;
			}
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x001566AF File Offset: 0x001548AF
		[DebuggerNonUserCode]
		public void ClearOriginalUrl()
		{
			this.originalUrl_ = null;
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06005895 RID: 22677 RVA: 0x001566BC File Offset: 0x001548BC
		// (set) Token: 0x06005896 RID: 22678 RVA: 0x001566D4 File Offset: 0x001548D4
		[DebuggerNonUserCode]
		public EmbedImage Thumbnail
		{
			get
			{
				return this.thumbnail_;
			}
			set
			{
				this.thumbnail_ = value;
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x001566E0 File Offset: 0x001548E0
		// (set) Token: 0x06005898 RID: 22680 RVA: 0x001566F8 File Offset: 0x001548F8
		[DebuggerNonUserCode]
		public Provider Provider
		{
			get
			{
				return this.provider_;
			}
			set
			{
				this.provider_ = value;
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06005899 RID: 22681 RVA: 0x00156704 File Offset: 0x00154904
		// (set) Token: 0x0600589A RID: 22682 RVA: 0x00156725 File Offset: 0x00154925
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? EmbedInfo.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x0600589B RID: 22683 RVA: 0x0015673C File Offset: 0x0015493C
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00156757 File Offset: 0x00154957
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x0600589D RID: 22685 RVA: 0x00156764 File Offset: 0x00154964
		// (set) Token: 0x0600589E RID: 22686 RVA: 0x0015677C File Offset: 0x0015497C
		[DebuggerNonUserCode]
		public EmbedHTML Html
		{
			get
			{
				return this.html_;
			}
			set
			{
				this.html_ = value;
			}
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x00156788 File Offset: 0x00154988
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EmbedInfo);
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x001567A8 File Offset: 0x001549A8
		[DebuggerNonUserCode]
		public bool Equals(EmbedInfo other)
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
					bool flag4 = this.Title != other.Title;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Type != other.Type;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.OriginalUrl != other.OriginalUrl;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Thumbnail, other.Thumbnail);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Provider, other.Provider);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Description != other.Description;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.Html, other.Html);
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

		// Token: 0x060058A1 RID: 22689 RVA: 0x001568B8 File Offset: 0x00154AB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitle = this.HasTitle;
			if (hasTitle)
			{
				num ^= this.Title.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasOriginalUrl = this.HasOriginalUrl;
			if (hasOriginalUrl)
			{
				num ^= this.OriginalUrl.GetHashCode();
			}
			bool flag = this.thumbnail_ != null;
			if (flag)
			{
				num ^= this.Thumbnail.GetHashCode();
			}
			bool flag2 = this.provider_ != null;
			if (flag2)
			{
				num ^= this.Provider.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool flag3 = this.html_ != null;
			if (flag3)
			{
				num ^= this.Html.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x001569A8 File Offset: 0x00154BA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x001569C0 File Offset: 0x00154BC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x001569CC File Offset: 0x00154BCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitle = this.HasTitle;
			if (hasTitle)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Title);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Type);
			}
			bool hasOriginalUrl = this.HasOriginalUrl;
			if (hasOriginalUrl)
			{
				output.WriteRawTag(26);
				output.WriteString(this.OriginalUrl);
			}
			bool flag = this.thumbnail_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Thumbnail);
			}
			bool flag2 = this.provider_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Provider);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Description);
			}
			bool flag3 = this.html_ != null;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Html);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x00156AF8 File Offset: 0x00154CF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitle = this.HasTitle;
			if (hasTitle)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Title);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool hasOriginalUrl = this.HasOriginalUrl;
			if (hasOriginalUrl)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OriginalUrl);
			}
			bool flag = this.thumbnail_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Thumbnail);
			}
			bool flag2 = this.provider_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Provider);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool flag3 = this.html_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Html);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x00156C04 File Offset: 0x00154E04
		[DebuggerNonUserCode]
		public void MergeFrom(EmbedInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTitle = other.HasTitle;
				if (hasTitle)
				{
					this.Title = other.Title;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasOriginalUrl = other.HasOriginalUrl;
				if (hasOriginalUrl)
				{
					this.OriginalUrl = other.OriginalUrl;
				}
				bool flag2 = other.thumbnail_ != null;
				if (flag2)
				{
					bool flag3 = this.thumbnail_ == null;
					if (flag3)
					{
						this.Thumbnail = new EmbedImage();
					}
					this.Thumbnail.MergeFrom(other.Thumbnail);
				}
				bool flag4 = other.provider_ != null;
				if (flag4)
				{
					bool flag5 = this.provider_ == null;
					if (flag5)
					{
						this.Provider = new Provider();
					}
					this.Provider.MergeFrom(other.Provider);
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				bool flag6 = other.html_ != null;
				if (flag6)
				{
					bool flag7 = this.html_ == null;
					if (flag7)
					{
						this.Html = new EmbedHTML();
					}
					this.Html.MergeFrom(other.Html);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x00156D5D File Offset: 0x00154F5D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x00156D68 File Offset: 0x00154F68
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_004F;
							}
							this.OriginalUrl = input.ReadString();
						}
						else
						{
							this.Type = input.ReadString();
						}
					}
					else
					{
						this.Title = input.ReadString();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_004F;
						}
						bool flag = this.provider_ == null;
						if (flag)
						{
							this.Provider = new Provider();
						}
						input.ReadMessage(this.Provider);
					}
					else
					{
						bool flag2 = this.thumbnail_ == null;
						if (flag2)
						{
							this.Thumbnail = new EmbedImage();
						}
						input.ReadMessage(this.Thumbnail);
					}
				}
				else if (num3 != 50U)
				{
					if (num3 != 66U)
					{
						goto IL_004F;
					}
					bool flag3 = this.html_ == null;
					if (flag3)
					{
						this.Html = new EmbedHTML();
					}
					input.ReadMessage(this.Html);
				}
				else
				{
					this.Description = input.ReadString();
				}
				continue;
				IL_004F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002860 RID: 10336
		private static readonly MessageParser<EmbedInfo> _parser = new MessageParser<EmbedInfo>(() => new EmbedInfo());

		// Token: 0x04002861 RID: 10337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002862 RID: 10338
		public const int TitleFieldNumber = 1;

		// Token: 0x04002863 RID: 10339
		private static readonly string TitleDefaultValue = "";

		// Token: 0x04002864 RID: 10340
		private string title_;

		// Token: 0x04002865 RID: 10341
		public const int TypeFieldNumber = 2;

		// Token: 0x04002866 RID: 10342
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04002867 RID: 10343
		private string type_;

		// Token: 0x04002868 RID: 10344
		public const int OriginalUrlFieldNumber = 3;

		// Token: 0x04002869 RID: 10345
		private static readonly string OriginalUrlDefaultValue = "";

		// Token: 0x0400286A RID: 10346
		private string originalUrl_;

		// Token: 0x0400286B RID: 10347
		public const int ThumbnailFieldNumber = 4;

		// Token: 0x0400286C RID: 10348
		private EmbedImage thumbnail_;

		// Token: 0x0400286D RID: 10349
		public const int ProviderFieldNumber = 5;

		// Token: 0x0400286E RID: 10350
		private Provider provider_;

		// Token: 0x0400286F RID: 10351
		public const int DescriptionFieldNumber = 6;

		// Token: 0x04002870 RID: 10352
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x04002871 RID: 10353
		private string description_;

		// Token: 0x04002872 RID: 10354
		public const int HtmlFieldNumber = 8;

		// Token: 0x04002873 RID: 10355
		private EmbedHTML html_;
	}
}
