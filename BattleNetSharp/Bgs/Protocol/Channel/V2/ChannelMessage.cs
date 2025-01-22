using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000690 RID: 1680
	public sealed class ChannelMessage : IMessage<ChannelMessage>, IMessage, IEquatable<ChannelMessage>, IDeepCloneable<ChannelMessage>, IBufferMessage
	{
		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x0025D908 File Offset: 0x0025BB08
		[DebuggerNonUserCode]
		public static MessageParser<ChannelMessage> Parser
		{
			get
			{
				return ChannelMessage._parser;
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x06009BD0 RID: 39888 RVA: 0x0025D920 File Offset: 0x0025BB20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x0025D944 File Offset: 0x0025BB44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelMessage.Descriptor;
			}
		}

		// Token: 0x06009BD2 RID: 39890 RVA: 0x0025D95B File Offset: 0x0025BB5B
		[DebuggerNonUserCode]
		public ChannelMessage()
		{
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x0025D970 File Offset: 0x0025BB70
		[DebuggerNonUserCode]
		public ChannelMessage(ChannelMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.authorId_ = ((other.authorId_ != null) ? other.authorId_.Clone() : null);
			this.content_ = other.content_;
			this.attribute_ = other.attribute_.Clone();
			this.creationTime_ = other.creationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x0025D9E8 File Offset: 0x0025BBE8
		[DebuggerNonUserCode]
		public ChannelMessage Clone()
		{
			return new ChannelMessage(this);
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x0025DA00 File Offset: 0x0025BC00
		// (set) Token: 0x06009BD6 RID: 39894 RVA: 0x0025DA18 File Offset: 0x0025BC18
		[DebuggerNonUserCode]
		public GameAccountHandle AuthorId
		{
			get
			{
				return this.authorId_;
			}
			set
			{
				this.authorId_ = value;
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x06009BD7 RID: 39895 RVA: 0x0025DA24 File Offset: 0x0025BC24
		// (set) Token: 0x06009BD8 RID: 39896 RVA: 0x0025DA45 File Offset: 0x0025BC45
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? ChannelMessage.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x06009BD9 RID: 39897 RVA: 0x0025DA5C File Offset: 0x0025BC5C
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x0025DA77 File Offset: 0x0025BC77
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x06009BDB RID: 39899 RVA: 0x0025DA84 File Offset: 0x0025BC84
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x06009BDC RID: 39900 RVA: 0x0025DA9C File Offset: 0x0025BC9C
		// (set) Token: 0x06009BDD RID: 39901 RVA: 0x0025DACD File Offset: 0x0025BCCD
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = ChannelMessage.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x06009BDE RID: 39902 RVA: 0x0025DAE8 File Offset: 0x0025BCE8
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x0025DB05 File Offset: 0x0025BD05
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x0025DB18 File Offset: 0x0025BD18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelMessage);
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x0025DB38 File Offset: 0x0025BD38
		[DebuggerNonUserCode]
		public bool Equals(ChannelMessage other)
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
					bool flag4 = !object.Equals(this.AuthorId, other.AuthorId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Content != other.Content;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CreationTime != other.CreationTime;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009BE2 RID: 39906 RVA: 0x0025DBEC File Offset: 0x0025BDEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.authorId_ != null;
			if (flag)
			{
				num ^= this.AuthorId.GetHashCode();
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x0025DC80 File Offset: 0x0025BE80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x0025DC98 File Offset: 0x0025BE98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x0025DCA4 File Offset: 0x0025BEA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.authorId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AuthorId);
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Content);
			}
			this.attribute_.WriteTo(ref output, ChannelMessage._repeated_attribute_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x0025DD4C File Offset: 0x0025BF4C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.authorId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AuthorId);
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			num += this.attribute_.CalculateSize(ChannelMessage._repeated_attribute_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x0025DDEC File Offset: 0x0025BFEC
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.authorId_ != null;
				if (flag2)
				{
					bool flag3 = this.authorId_ == null;
					if (flag3)
					{
						this.AuthorId = new GameAccountHandle();
					}
					this.AuthorId.MergeFrom(other.AuthorId);
				}
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
				this.attribute_.Add(other.attribute_);
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x0025DEA1 File Offset: 0x0025C0A1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x0025DEAC File Offset: 0x0025C0AC
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
						if (num3 != 26U)
						{
							goto IL_002C;
						}
						this.Content = input.ReadString();
					}
					else
					{
						bool flag = this.authorId_ == null;
						if (flag)
						{
							this.AuthorId = new GameAccountHandle();
						}
						input.ReadMessage(this.AuthorId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 40U)
					{
						goto IL_002C;
					}
					this.CreationTime = input.ReadUInt64();
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ChannelMessage._repeated_attribute_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004647 RID: 17991
		private static readonly MessageParser<ChannelMessage> _parser = new MessageParser<ChannelMessage>(() => new ChannelMessage());

		// Token: 0x04004648 RID: 17992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004649 RID: 17993
		private int _hasBits0;

		// Token: 0x0400464A RID: 17994
		public const int AuthorIdFieldNumber = 1;

		// Token: 0x0400464B RID: 17995
		private GameAccountHandle authorId_;

		// Token: 0x0400464C RID: 17996
		public const int ContentFieldNumber = 3;

		// Token: 0x0400464D RID: 17997
		private static readonly string ContentDefaultValue = "";

		// Token: 0x0400464E RID: 17998
		private string content_;

		// Token: 0x0400464F RID: 17999
		public const int AttributeFieldNumber = 4;

		// Token: 0x04004650 RID: 18000
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004651 RID: 18001
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04004652 RID: 18002
		public const int CreationTimeFieldNumber = 5;

		// Token: 0x04004653 RID: 18003
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04004654 RID: 18004
		private ulong creationTime_;
	}
}
