using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200069C RID: 1692
	public sealed class CreateChannelServerOptions : IMessage<CreateChannelServerOptions>, IMessage, IEquatable<CreateChannelServerOptions>, IDeepCloneable<CreateChannelServerOptions>, IBufferMessage
	{
		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06009D05 RID: 40197 RVA: 0x00262BA4 File Offset: 0x00260DA4
		[DebuggerNonUserCode]
		public static MessageParser<CreateChannelServerOptions> Parser
		{
			get
			{
				return CreateChannelServerOptions._parser;
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06009D06 RID: 40198 RVA: 0x00262BBC File Offset: 0x00260DBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerChannelTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06009D07 RID: 40199 RVA: 0x00262BE0 File Offset: 0x00260DE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateChannelServerOptions.Descriptor;
			}
		}

		// Token: 0x06009D08 RID: 40200 RVA: 0x00262BF7 File Offset: 0x00260DF7
		[DebuggerNonUserCode]
		public CreateChannelServerOptions()
		{
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x00262C18 File Offset: 0x00260E18
		[DebuggerNonUserCode]
		public CreateChannelServerOptions(CreateChannelServerOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.name_ = other.name_;
			this.privacyLevel_ = other.privacyLevel_;
			this.attribute_ = other.attribute_.Clone();
			this.member_ = other.member_.Clone();
			this.collectionId_ = other.collectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x00262CAC File Offset: 0x00260EAC
		[DebuggerNonUserCode]
		public CreateChannelServerOptions Clone()
		{
			return new CreateChannelServerOptions(this);
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x06009D0B RID: 40203 RVA: 0x00262CC4 File Offset: 0x00260EC4
		// (set) Token: 0x06009D0C RID: 40204 RVA: 0x00262CDC File Offset: 0x00260EDC
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

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x06009D0D RID: 40205 RVA: 0x00262CE8 File Offset: 0x00260EE8
		// (set) Token: 0x06009D0E RID: 40206 RVA: 0x00262D09 File Offset: 0x00260F09
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? CreateChannelServerOptions.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x06009D0F RID: 40207 RVA: 0x00262D20 File Offset: 0x00260F20
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06009D10 RID: 40208 RVA: 0x00262D3B File Offset: 0x00260F3B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06009D11 RID: 40209 RVA: 0x00262D48 File Offset: 0x00260F48
		// (set) Token: 0x06009D12 RID: 40210 RVA: 0x00262D79 File Offset: 0x00260F79
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
					privacyLevelDefaultValue = CreateChannelServerOptions.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06009D13 RID: 40211 RVA: 0x00262D94 File Offset: 0x00260F94
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x00262DB1 File Offset: 0x00260FB1
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06009D15 RID: 40213 RVA: 0x00262DC4 File Offset: 0x00260FC4
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06009D16 RID: 40214 RVA: 0x00262DDC File Offset: 0x00260FDC
		[DebuggerNonUserCode]
		public RepeatedField<CreateMemberOptions> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06009D17 RID: 40215 RVA: 0x00262DF4 File Offset: 0x00260FF4
		// (set) Token: 0x06009D18 RID: 40216 RVA: 0x00262E15 File Offset: 0x00261015
		[DebuggerNonUserCode]
		public string CollectionId
		{
			get
			{
				return this.collectionId_ ?? CreateChannelServerOptions.CollectionIdDefaultValue;
			}
			set
			{
				this.collectionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06009D19 RID: 40217 RVA: 0x00262E2C File Offset: 0x0026102C
		[DebuggerNonUserCode]
		public bool HasCollectionId
		{
			get
			{
				return this.collectionId_ != null;
			}
		}

		// Token: 0x06009D1A RID: 40218 RVA: 0x00262E47 File Offset: 0x00261047
		[DebuggerNonUserCode]
		public void ClearCollectionId()
		{
			this.collectionId_ = null;
		}

		// Token: 0x06009D1B RID: 40219 RVA: 0x00262E54 File Offset: 0x00261054
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateChannelServerOptions);
		}

		// Token: 0x06009D1C RID: 40220 RVA: 0x00262E74 File Offset: 0x00261074
		[DebuggerNonUserCode]
		public bool Equals(CreateChannelServerOptions other)
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
									bool flag8 = !this.member_.Equals(other.member_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CollectionId != other.CollectionId;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009D1D RID: 40221 RVA: 0x00262F68 File Offset: 0x00261168
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
			num ^= this.member_.GetHashCode();
			bool hasCollectionId = this.HasCollectionId;
			if (hasCollectionId)
			{
				num ^= this.CollectionId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D1E RID: 40222 RVA: 0x0026302C File Offset: 0x0026122C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D1F RID: 40223 RVA: 0x00263044 File Offset: 0x00261244
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x00263050 File Offset: 0x00261250
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
			this.attribute_.WriteTo(ref output, CreateChannelServerOptions._repeated_attribute_codec);
			this.member_.WriteTo(ref output, CreateChannelServerOptions._repeated_member_codec);
			bool hasCollectionId = this.HasCollectionId;
			if (hasCollectionId)
			{
				output.WriteRawTag(50);
				output.WriteString(this.CollectionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D21 RID: 40225 RVA: 0x0026312C File Offset: 0x0026132C
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
			num += this.attribute_.CalculateSize(CreateChannelServerOptions._repeated_attribute_codec);
			num += this.member_.CalculateSize(CreateChannelServerOptions._repeated_member_codec);
			bool hasCollectionId = this.HasCollectionId;
			if (hasCollectionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CollectionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D22 RID: 40226 RVA: 0x00263200 File Offset: 0x00261400
		[DebuggerNonUserCode]
		public void MergeFrom(CreateChannelServerOptions other)
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
				this.member_.Add(other.member_);
				bool hasCollectionId = other.HasCollectionId;
				if (hasCollectionId)
				{
					this.CollectionId = other.CollectionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x002632E2 File Offset: 0x002614E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x002632F0 File Offset: 0x002614F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_0040;
							}
							this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
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
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0040;
						}
						this.CollectionId = input.ReadString();
					}
					else
					{
						this.member_.AddEntriesFrom(ref input, CreateChannelServerOptions._repeated_member_codec);
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, CreateChannelServerOptions._repeated_attribute_codec);
				}
				continue;
				IL_0040:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046DE RID: 18142
		private static readonly MessageParser<CreateChannelServerOptions> _parser = new MessageParser<CreateChannelServerOptions>(() => new CreateChannelServerOptions());

		// Token: 0x040046DF RID: 18143
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046E0 RID: 18144
		private int _hasBits0;

		// Token: 0x040046E1 RID: 18145
		public const int TypeFieldNumber = 1;

		// Token: 0x040046E2 RID: 18146
		private UniqueChannelType type_;

		// Token: 0x040046E3 RID: 18147
		public const int NameFieldNumber = 2;

		// Token: 0x040046E4 RID: 18148
		private static readonly string NameDefaultValue = "";

		// Token: 0x040046E5 RID: 18149
		private string name_;

		// Token: 0x040046E6 RID: 18150
		public const int PrivacyLevelFieldNumber = 3;

		// Token: 0x040046E7 RID: 18151
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x040046E8 RID: 18152
		private PrivacyLevel privacyLevel_;

		// Token: 0x040046E9 RID: 18153
		public const int AttributeFieldNumber = 4;

		// Token: 0x040046EA RID: 18154
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040046EB RID: 18155
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040046EC RID: 18156
		public const int MemberFieldNumber = 5;

		// Token: 0x040046ED RID: 18157
		private static readonly FieldCodec<CreateMemberOptions> _repeated_member_codec = FieldCodec.ForMessage<CreateMemberOptions>(42U, CreateMemberOptions.Parser);

		// Token: 0x040046EE RID: 18158
		private readonly RepeatedField<CreateMemberOptions> member_ = new RepeatedField<CreateMemberOptions>();

		// Token: 0x040046EF RID: 18159
		public const int CollectionIdFieldNumber = 6;

		// Token: 0x040046F0 RID: 18160
		private static readonly string CollectionIdDefaultValue = "";

		// Token: 0x040046F1 RID: 18161
		private string collectionId_;
	}
}
