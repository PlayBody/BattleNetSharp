using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000693 RID: 1683
	public sealed class ChannelDescription : IMessage<ChannelDescription>, IMessage, IEquatable<ChannelDescription>, IDeepCloneable<ChannelDescription>, IBufferMessage
	{
		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x06009C2C RID: 39980 RVA: 0x0025F2B8 File Offset: 0x0025D4B8
		[DebuggerNonUserCode]
		public static MessageParser<ChannelDescription> Parser
		{
			get
			{
				return ChannelDescription._parser;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x0025F2D0 File Offset: 0x0025D4D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x06009C2E RID: 39982 RVA: 0x0025F2F4 File Offset: 0x0025D4F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelDescription.Descriptor;
			}
		}

		// Token: 0x06009C2F RID: 39983 RVA: 0x0025F30B File Offset: 0x0025D50B
		[DebuggerNonUserCode]
		public ChannelDescription()
		{
		}

		// Token: 0x06009C30 RID: 39984 RVA: 0x0025F328 File Offset: 0x0025D528
		[DebuggerNonUserCode]
		public ChannelDescription(ChannelDescription other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.name_ = other.name_;
			this.privacyLevel_ = other.privacyLevel_;
			this.attribute_ = other.attribute_.Clone();
			this.memberCount_ = other.memberCount_;
			ChannelDescription.StateTypeOneofCase stateTypeCase = other.StateTypeCase;
			ChannelDescription.StateTypeOneofCase stateTypeOneofCase = stateTypeCase;
			if (stateTypeOneofCase == ChannelDescription.StateTypeOneofCase.PublicChannelState)
			{
				this.PublicChannelState = other.PublicChannelState.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C31 RID: 39985 RVA: 0x0025F3EC File Offset: 0x0025D5EC
		[DebuggerNonUserCode]
		public ChannelDescription Clone()
		{
			return new ChannelDescription(this);
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x06009C32 RID: 39986 RVA: 0x0025F404 File Offset: 0x0025D604
		// (set) Token: 0x06009C33 RID: 39987 RVA: 0x0025F41C File Offset: 0x0025D61C
		[DebuggerNonUserCode]
		public ChannelId Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x06009C34 RID: 39988 RVA: 0x0025F428 File Offset: 0x0025D628
		// (set) Token: 0x06009C35 RID: 39989 RVA: 0x0025F440 File Offset: 0x0025D640
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

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x0025F44C File Offset: 0x0025D64C
		// (set) Token: 0x06009C37 RID: 39991 RVA: 0x0025F46D File Offset: 0x0025D66D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ChannelDescription.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x06009C38 RID: 39992 RVA: 0x0025F484 File Offset: 0x0025D684
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0025F49F File Offset: 0x0025D69F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x0025F4AC File Offset: 0x0025D6AC
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x0025F4DD File Offset: 0x0025D6DD
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
					privacyLevelDefaultValue = ChannelDescription.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x0025F4F8 File Offset: 0x0025D6F8
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x0025F515 File Offset: 0x0025D715
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x06009C3E RID: 39998 RVA: 0x0025F528 File Offset: 0x0025D728
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x06009C3F RID: 39999 RVA: 0x0025F540 File Offset: 0x0025D740
		// (set) Token: 0x06009C40 RID: 40000 RVA: 0x0025F571 File Offset: 0x0025D771
		[DebuggerNonUserCode]
		public uint MemberCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint memberCountDefaultValue;
				if (flag)
				{
					memberCountDefaultValue = this.memberCount_;
				}
				else
				{
					memberCountDefaultValue = ChannelDescription.MemberCountDefaultValue;
				}
				return memberCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.memberCount_ = value;
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x06009C41 RID: 40001 RVA: 0x0025F58C File Offset: 0x0025D78C
		[DebuggerNonUserCode]
		public bool HasMemberCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x0025F5A9 File Offset: 0x0025D7A9
		[DebuggerNonUserCode]
		public void ClearMemberCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x06009C43 RID: 40003 RVA: 0x0025F5BC File Offset: 0x0025D7BC
		// (set) Token: 0x06009C44 RID: 40004 RVA: 0x0025F5E6 File Offset: 0x0025D7E6
		[DebuggerNonUserCode]
		public PublicChannelState PublicChannelState
		{
			get
			{
				return (this.stateTypeCase_ == ChannelDescription.StateTypeOneofCase.PublicChannelState) ? ((PublicChannelState)this.stateType_) : null;
			}
			set
			{
				this.stateType_ = value;
				this.stateTypeCase_ = ((value == null) ? ChannelDescription.StateTypeOneofCase.None : ChannelDescription.StateTypeOneofCase.PublicChannelState);
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x06009C45 RID: 40005 RVA: 0x0025F600 File Offset: 0x0025D800
		[DebuggerNonUserCode]
		public ChannelDescription.StateTypeOneofCase StateTypeCase
		{
			get
			{
				return this.stateTypeCase_;
			}
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x0025F618 File Offset: 0x0025D818
		[DebuggerNonUserCode]
		public void ClearStateType()
		{
			this.stateTypeCase_ = ChannelDescription.StateTypeOneofCase.None;
			this.stateType_ = null;
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x0025F62C File Offset: 0x0025D82C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelDescription);
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x0025F64C File Offset: 0x0025D84C
		[DebuggerNonUserCode]
		public bool Equals(ChannelDescription other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Type, other.Type);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Name != other.Name;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PrivacyLevel != other.PrivacyLevel;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.attribute_.Equals(other.attribute_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.MemberCount != other.MemberCount;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.PublicChannelState, other.PublicChannelState);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.StateTypeCase != other.StateTypeCase;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
											}
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

		// Token: 0x06009C49 RID: 40009 RVA: 0x0025F780 File Offset: 0x0025D980
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag2 = this.type_ != null;
			if (flag2)
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
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num ^= this.MemberCount.GetHashCode();
			}
			bool flag3 = this.stateTypeCase_ == ChannelDescription.StateTypeOneofCase.PublicChannelState;
			if (flag3)
			{
				num ^= this.PublicChannelState.GetHashCode();
			}
			num ^= (int)this.stateTypeCase_;
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x0025F87C File Offset: 0x0025DA7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x0025F894 File Offset: 0x0025DA94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x0025F8A0 File Offset: 0x0025DAA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Id);
			}
			bool flag2 = this.type_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Type);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			this.attribute_.WriteTo(ref output, ChannelDescription._repeated_attribute_codec);
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MemberCount);
			}
			bool flag3 = this.stateTypeCase_ == ChannelDescription.StateTypeOneofCase.PublicChannelState;
			if (flag3)
			{
				output.WriteRawTag(242, 6);
				output.WriteMessage(this.PublicChannelState);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x0025F9BC File Offset: 0x0025DBBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool flag2 = this.type_ != null;
			if (flag2)
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
			num += this.attribute_.CalculateSize(ChannelDescription._repeated_attribute_codec);
			bool hasMemberCount = this.HasMemberCount;
			if (hasMemberCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MemberCount);
			}
			bool flag3 = this.stateTypeCase_ == ChannelDescription.StateTypeOneofCase.PublicChannelState;
			if (flag3)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PublicChannelState);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x0025FAC0 File Offset: 0x0025DCC0
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelDescription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new ChannelId();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool flag4 = other.type_ != null;
				if (flag4)
				{
					bool flag5 = this.type_ == null;
					if (flag5)
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
				bool hasMemberCount = other.HasMemberCount;
				if (hasMemberCount)
				{
					this.MemberCount = other.MemberCount;
				}
				ChannelDescription.StateTypeOneofCase stateTypeCase = other.StateTypeCase;
				ChannelDescription.StateTypeOneofCase stateTypeOneofCase = stateTypeCase;
				if (stateTypeOneofCase == ChannelDescription.StateTypeOneofCase.PublicChannelState)
				{
					bool flag6 = this.PublicChannelState == null;
					if (flag6)
					{
						this.PublicChannelState = new PublicChannelState();
					}
					this.PublicChannelState.MergeFrom(other.PublicChannelState);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x0025FC15 File Offset: 0x0025DE15
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x0025FC20 File Offset: 0x0025DE20
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
								goto IL_005B;
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
					else
					{
						bool flag2 = this.id_ == null;
						if (flag2)
						{
							this.Id = new ChannelId();
						}
						input.ReadMessage(this.Id);
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_005B;
						}
						this.attribute_.AddEntriesFrom(ref input, ChannelDescription._repeated_attribute_codec);
					}
					else
					{
						this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 882U)
					{
						goto IL_005B;
					}
					PublicChannelState publicChannelState = new PublicChannelState();
					bool flag3 = this.stateTypeCase_ == ChannelDescription.StateTypeOneofCase.PublicChannelState;
					if (flag3)
					{
						publicChannelState.MergeFrom(this.PublicChannelState);
					}
					input.ReadMessage(publicChannelState);
					this.PublicChannelState = publicChannelState;
				}
				else
				{
					this.MemberCount = input.ReadUInt32();
				}
				continue;
				IL_005B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400467F RID: 18047
		private static readonly MessageParser<ChannelDescription> _parser = new MessageParser<ChannelDescription>(() => new ChannelDescription());

		// Token: 0x04004680 RID: 18048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004681 RID: 18049
		private int _hasBits0;

		// Token: 0x04004682 RID: 18050
		public const int IdFieldNumber = 1;

		// Token: 0x04004683 RID: 18051
		private ChannelId id_;

		// Token: 0x04004684 RID: 18052
		public const int TypeFieldNumber = 2;

		// Token: 0x04004685 RID: 18053
		private UniqueChannelType type_;

		// Token: 0x04004686 RID: 18054
		public const int NameFieldNumber = 3;

		// Token: 0x04004687 RID: 18055
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004688 RID: 18056
		private string name_;

		// Token: 0x04004689 RID: 18057
		public const int PrivacyLevelFieldNumber = 4;

		// Token: 0x0400468A RID: 18058
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x0400468B RID: 18059
		private PrivacyLevel privacyLevel_;

		// Token: 0x0400468C RID: 18060
		public const int AttributeFieldNumber = 5;

		// Token: 0x0400468D RID: 18061
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(42U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400468E RID: 18062
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x0400468F RID: 18063
		public const int MemberCountFieldNumber = 6;

		// Token: 0x04004690 RID: 18064
		private static readonly uint MemberCountDefaultValue = 0U;

		// Token: 0x04004691 RID: 18065
		private uint memberCount_;

		// Token: 0x04004692 RID: 18066
		public const int PublicChannelStateFieldNumber = 110;

		// Token: 0x04004693 RID: 18067
		private object stateType_;

		// Token: 0x04004694 RID: 18068
		private ChannelDescription.StateTypeOneofCase stateTypeCase_ = ChannelDescription.StateTypeOneofCase.None;

		// Token: 0x0200118E RID: 4494
		public enum StateTypeOneofCase
		{
			// Token: 0x040098C7 RID: 39111
			None,
			// Token: 0x040098C8 RID: 39112
			PublicChannelState = 110
		}
	}
}
