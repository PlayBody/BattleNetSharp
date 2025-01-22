using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200068F RID: 1679
	public sealed class SendMessageOptions : IMessage<SendMessageOptions>, IMessage, IEquatable<SendMessageOptions>, IDeepCloneable<SendMessageOptions>, IBufferMessage
	{
		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x06009BB9 RID: 39865 RVA: 0x0025D4F8 File Offset: 0x0025B6F8
		[DebuggerNonUserCode]
		public static MessageParser<SendMessageOptions> Parser
		{
			get
			{
				return SendMessageOptions._parser;
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x06009BBA RID: 39866 RVA: 0x0025D510 File Offset: 0x0025B710
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x06009BBB RID: 39867 RVA: 0x0025D534 File Offset: 0x0025B734
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendMessageOptions.Descriptor;
			}
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x0025D54B File Offset: 0x0025B74B
		[DebuggerNonUserCode]
		public SendMessageOptions()
		{
		}

		// Token: 0x06009BBD RID: 39869 RVA: 0x0025D560 File Offset: 0x0025B760
		[DebuggerNonUserCode]
		public SendMessageOptions(SendMessageOptions other)
			: this()
		{
			this.content_ = other.content_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BBE RID: 39870 RVA: 0x0025D598 File Offset: 0x0025B798
		[DebuggerNonUserCode]
		public SendMessageOptions Clone()
		{
			return new SendMessageOptions(this);
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x06009BBF RID: 39871 RVA: 0x0025D5B0 File Offset: 0x0025B7B0
		// (set) Token: 0x06009BC0 RID: 39872 RVA: 0x0025D5D1 File Offset: 0x0025B7D1
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? SendMessageOptions.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x06009BC1 RID: 39873 RVA: 0x0025D5E8 File Offset: 0x0025B7E8
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06009BC2 RID: 39874 RVA: 0x0025D603 File Offset: 0x0025B803
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x0025D610 File Offset: 0x0025B810
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x0025D628 File Offset: 0x0025B828
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendMessageOptions);
		}

		// Token: 0x06009BC5 RID: 39877 RVA: 0x0025D648 File Offset: 0x0025B848
		[DebuggerNonUserCode]
		public bool Equals(SendMessageOptions other)
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
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009BC6 RID: 39878 RVA: 0x0025D6BC File Offset: 0x0025B8BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BC7 RID: 39879 RVA: 0x0025D714 File Offset: 0x0025B914
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BC8 RID: 39880 RVA: 0x0025D72C File Offset: 0x0025B92C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BC9 RID: 39881 RVA: 0x0025D738 File Offset: 0x0025B938
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Content);
			}
			this.attribute_.WriteTo(ref output, SendMessageOptions._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x0025D798 File Offset: 0x0025B998
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			num += this.attribute_.CalculateSize(SendMessageOptions._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x0025D7FC File Offset: 0x0025B9FC
		[DebuggerNonUserCode]
		public void MergeFrom(SendMessageOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x0025D857 File Offset: 0x0025BA57
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x0025D864 File Offset: 0x0025BA64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, SendMessageOptions._repeated_attribute_codec);
					}
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x0400463F RID: 17983
		private static readonly MessageParser<SendMessageOptions> _parser = new MessageParser<SendMessageOptions>(() => new SendMessageOptions());

		// Token: 0x04004640 RID: 17984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004641 RID: 17985
		public const int ContentFieldNumber = 4;

		// Token: 0x04004642 RID: 17986
		private static readonly string ContentDefaultValue = "";

		// Token: 0x04004643 RID: 17987
		private string content_;

		// Token: 0x04004644 RID: 17988
		public const int AttributeFieldNumber = 5;

		// Token: 0x04004645 RID: 17989
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(42U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004646 RID: 17990
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}
