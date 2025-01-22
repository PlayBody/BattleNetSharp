using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200068C RID: 1676
	public sealed class PublicChannelType : IMessage<PublicChannelType>, IMessage, IEquatable<PublicChannelType>, IDeepCloneable<PublicChannelType>, IBufferMessage
	{
		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x06009B6E RID: 39790 RVA: 0x0025C46C File Offset: 0x0025A66C
		[DebuggerNonUserCode]
		public static MessageParser<PublicChannelType> Parser
		{
			get
			{
				return PublicChannelType._parser;
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x0025C484 File Offset: 0x0025A684
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x06009B70 RID: 39792 RVA: 0x0025C4A8 File Offset: 0x0025A6A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicChannelType.Descriptor;
			}
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x0025C4BF File Offset: 0x0025A6BF
		[DebuggerNonUserCode]
		public PublicChannelType()
		{
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x0025C4CC File Offset: 0x0025A6CC
		[DebuggerNonUserCode]
		public PublicChannelType(PublicChannelType other)
			: this()
		{
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.name_ = other.name_;
			this.identity_ = other.identity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x0025C528 File Offset: 0x0025A728
		[DebuggerNonUserCode]
		public PublicChannelType Clone()
		{
			return new PublicChannelType(this);
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x06009B74 RID: 39796 RVA: 0x0025C540 File Offset: 0x0025A740
		// (set) Token: 0x06009B75 RID: 39797 RVA: 0x0025C558 File Offset: 0x0025A758
		[DebuggerNonUserCode]
		public UniqueChannelType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x06009B76 RID: 39798 RVA: 0x0025C564 File Offset: 0x0025A764
		// (set) Token: 0x06009B77 RID: 39799 RVA: 0x0025C585 File Offset: 0x0025A785
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? PublicChannelType.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x06009B78 RID: 39800 RVA: 0x0025C59C File Offset: 0x0025A79C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x0025C5B7 File Offset: 0x0025A7B7
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x06009B7A RID: 39802 RVA: 0x0025C5C4 File Offset: 0x0025A7C4
		// (set) Token: 0x06009B7B RID: 39803 RVA: 0x0025C5E5 File Offset: 0x0025A7E5
		[DebuggerNonUserCode]
		public string Identity
		{
			get
			{
				return this.identity_ ?? PublicChannelType.IdentityDefaultValue;
			}
			set
			{
				this.identity_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x06009B7C RID: 39804 RVA: 0x0025C5FC File Offset: 0x0025A7FC
		[DebuggerNonUserCode]
		public bool HasIdentity
		{
			get
			{
				return this.identity_ != null;
			}
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x0025C617 File Offset: 0x0025A817
		[DebuggerNonUserCode]
		public void ClearIdentity()
		{
			this.identity_ = null;
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x0025C624 File Offset: 0x0025A824
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicChannelType);
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x0025C644 File Offset: 0x0025A844
		[DebuggerNonUserCode]
		public bool Equals(PublicChannelType other)
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
					bool flag4 = !object.Equals(this.Type, other.Type);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Identity != other.Identity;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x0025C6D4 File Offset: 0x0025A8D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.type_ != null;
			if (flag)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x0025C758 File Offset: 0x0025A958
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x0025C770 File Offset: 0x0025A970
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x0025C77C File Offset: 0x0025A97C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.type_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Type);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Identity);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x0025C810 File Offset: 0x0025AA10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.type_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Identity);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x0025C8A0 File Offset: 0x0025AAA0
		[DebuggerNonUserCode]
		public void MergeFrom(PublicChannelType other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.type_ != null;
				if (flag2)
				{
					bool flag3 = this.type_ == null;
					if (flag3)
					{
						this.Type = new UniqueChannelType();
					}
					this.Type.MergeFrom(other.Type);
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasIdentity = other.HasIdentity;
				if (hasIdentity)
				{
					this.Identity = other.Identity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x0025C943 File Offset: 0x0025AB43
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x0025C950 File Offset: 0x0025AB50
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Identity = input.ReadString();
						}
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					bool flag = this.type_ == null;
					if (flag)
					{
						this.Type = new UniqueChannelType();
					}
					input.ReadMessage(this.Type);
				}
			}
		}

		// Token: 0x04004620 RID: 17952
		private static readonly MessageParser<PublicChannelType> _parser = new MessageParser<PublicChannelType>(() => new PublicChannelType());

		// Token: 0x04004621 RID: 17953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004622 RID: 17954
		public const int TypeFieldNumber = 1;

		// Token: 0x04004623 RID: 17955
		private UniqueChannelType type_;

		// Token: 0x04004624 RID: 17956
		public const int NameFieldNumber = 2;

		// Token: 0x04004625 RID: 17957
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004626 RID: 17958
		private string name_;

		// Token: 0x04004627 RID: 17959
		public const int IdentityFieldNumber = 3;

		// Token: 0x04004628 RID: 17960
		private static readonly string IdentityDefaultValue = "";

		// Token: 0x04004629 RID: 17961
		private string identity_;
	}
}
