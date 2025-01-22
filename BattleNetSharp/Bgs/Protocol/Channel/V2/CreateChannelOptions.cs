using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200068B RID: 1675
	public sealed class CreateChannelOptions : IMessage<CreateChannelOptions>, IMessage, IEquatable<CreateChannelOptions>, IDeepCloneable<CreateChannelOptions>, IBufferMessage
	{
		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x06009B50 RID: 39760 RVA: 0x0025BC84 File Offset: 0x00259E84
		[DebuggerNonUserCode]
		public static MessageParser<CreateChannelOptions> Parser
		{
			get
			{
				return CreateChannelOptions._parser;
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x06009B51 RID: 39761 RVA: 0x0025BC9C File Offset: 0x00259E9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x06009B52 RID: 39762 RVA: 0x0025BCC0 File Offset: 0x00259EC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateChannelOptions.Descriptor;
			}
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x0025BCD7 File Offset: 0x00259ED7
		[DebuggerNonUserCode]
		public CreateChannelOptions()
		{
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x0025BCEC File Offset: 0x00259EEC
		[DebuggerNonUserCode]
		public CreateChannelOptions(CreateChannelOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.name_ = other.name_;
			this.privacyLevel_ = other.privacyLevel_;
			this.attribute_ = other.attribute_.Clone();
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x0025BD80 File Offset: 0x00259F80
		[DebuggerNonUserCode]
		public CreateChannelOptions Clone()
		{
			return new CreateChannelOptions(this);
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x06009B56 RID: 39766 RVA: 0x0025BD98 File Offset: 0x00259F98
		// (set) Token: 0x06009B57 RID: 39767 RVA: 0x0025BDB0 File Offset: 0x00259FB0
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

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x06009B58 RID: 39768 RVA: 0x0025BDBC File Offset: 0x00259FBC
		// (set) Token: 0x06009B59 RID: 39769 RVA: 0x0025BDDD File Offset: 0x00259FDD
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? CreateChannelOptions.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x06009B5A RID: 39770 RVA: 0x0025BDF4 File Offset: 0x00259FF4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x0025BE0F File Offset: 0x0025A00F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x06009B5C RID: 39772 RVA: 0x0025BE1C File Offset: 0x0025A01C
		// (set) Token: 0x06009B5D RID: 39773 RVA: 0x0025BE4D File Offset: 0x0025A04D
		[DebuggerNonUserCode]
		public PrivacyLevel PrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				PrivacyLevel privacyLevelDefaultValue;
				if (flag)
				{
					privacyLevelDefaultValue = this.privacyLevel_;
				}
				else
				{
					privacyLevelDefaultValue = CreateChannelOptions.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x06009B5E RID: 39774 RVA: 0x0025BE68 File Offset: 0x0025A068
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x0025BE85 File Offset: 0x0025A085
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x06009B60 RID: 39776 RVA: 0x0025BE98 File Offset: 0x0025A098
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x0025BEB0 File Offset: 0x0025A0B0
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x0025BEC8 File Offset: 0x0025A0C8
		[DebuggerNonUserCode]
		public CreateMemberOptions Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
			}
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x0025BED4 File Offset: 0x0025A0D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateChannelOptions);
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x0025BEF4 File Offset: 0x0025A0F4
		[DebuggerNonUserCode]
		public bool Equals(CreateChannelOptions other)
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
							bool flag6 = this.PrivacyLevel != other.PrivacyLevel;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Member, other.Member);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x0025BFC8 File Offset: 0x0025A1C8
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num ^= this.PrivacyLevel.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this.member_ != null;
			if (flag2)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x0025C080 File Offset: 0x0025A280
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x0025C098 File Offset: 0x0025A298
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B68 RID: 39784 RVA: 0x0025C0A4 File Offset: 0x0025A2A4
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			this.attribute_.WriteTo(ref output, CreateChannelOptions._repeated_attribute_codec);
			bool flag2 = this.member_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Member);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B69 RID: 39785 RVA: 0x0025C170 File Offset: 0x0025A370
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
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
			}
			num += this.attribute_.CalculateSize(CreateChannelOptions._repeated_attribute_codec);
			bool flag2 = this.member_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B6A RID: 39786 RVA: 0x0025C234 File Offset: 0x0025A434
		[DebuggerNonUserCode]
		public void MergeFrom(CreateChannelOptions other)
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
				bool hasPrivacyLevel = other.HasPrivacyLevel;
				if (hasPrivacyLevel)
				{
					this.PrivacyLevel = other.PrivacyLevel;
				}
				this.attribute_.Add(other.attribute_);
				bool flag4 = other.member_ != null;
				if (flag4)
				{
					bool flag5 = this.member_ == null;
					if (flag5)
					{
						this.Member = new CreateMemberOptions();
					}
					this.Member.MergeFrom(other.Member);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009B6B RID: 39787 RVA: 0x0025C329 File Offset: 0x0025A529
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x0025C334 File Offset: 0x0025A534
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.Name = input.ReadString();
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
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0033;
						}
						bool flag2 = this.member_ == null;
						if (flag2)
						{
							this.Member = new CreateMemberOptions();
						}
						input.ReadMessage(this.Member);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, CreateChannelOptions._repeated_attribute_codec);
					}
				}
				else
				{
					this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004610 RID: 17936
		private static readonly MessageParser<CreateChannelOptions> _parser = new MessageParser<CreateChannelOptions>(() => new CreateChannelOptions());

		// Token: 0x04004611 RID: 17937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004612 RID: 17938
		private int _hasBits0;

		// Token: 0x04004613 RID: 17939
		public const int TypeFieldNumber = 1;

		// Token: 0x04004614 RID: 17940
		private UniqueChannelType type_;

		// Token: 0x04004615 RID: 17941
		public const int NameFieldNumber = 2;

		// Token: 0x04004616 RID: 17942
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004617 RID: 17943
		private string name_;

		// Token: 0x04004618 RID: 17944
		public const int PrivacyLevelFieldNumber = 3;

		// Token: 0x04004619 RID: 17945
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x0400461A RID: 17946
		private PrivacyLevel privacyLevel_;

		// Token: 0x0400461B RID: 17947
		public const int AttributeFieldNumber = 4;

		// Token: 0x0400461C RID: 17948
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400461D RID: 17949
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x0400461E RID: 17950
		public const int MemberFieldNumber = 5;

		// Token: 0x0400461F RID: 17951
		private CreateMemberOptions member_;
	}
}
