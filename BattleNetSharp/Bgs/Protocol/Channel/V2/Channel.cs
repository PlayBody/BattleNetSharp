using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000692 RID: 1682
	public sealed class Channel : IMessage<Channel>, IMessage, IEquatable<Channel>, IDeepCloneable<Channel>, IBufferMessage
	{
		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x06009C06 RID: 39942 RVA: 0x0025E5E8 File Offset: 0x0025C7E8
		[DebuggerNonUserCode]
		public static MessageParser<Channel> Parser
		{
			get
			{
				return Channel._parser;
			}
		}

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x06009C07 RID: 39943 RVA: 0x0025E600 File Offset: 0x0025C800
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x06009C08 RID: 39944 RVA: 0x0025E624 File Offset: 0x0025C824
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Channel.Descriptor;
			}
		}

		// Token: 0x06009C09 RID: 39945 RVA: 0x0025E63B File Offset: 0x0025C83B
		[DebuggerNonUserCode]
		public Channel()
		{
		}

		// Token: 0x06009C0A RID: 39946 RVA: 0x0025E670 File Offset: 0x0025C870
		[DebuggerNonUserCode]
		public Channel(Channel other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.name_ = other.name_;
			this.privacyLevel_ = other.privacyLevel_;
			this.attribute_ = other.attribute_.Clone();
			this.member_ = other.member_.Clone();
			this.invitation_ = other.invitation_.Clone();
			this.roleSet_ = ((other.roleSet_ != null) ? other.roleSet_.Clone() : null);
			Channel.StateTypeOneofCase stateTypeCase = other.StateTypeCase;
			Channel.StateTypeOneofCase stateTypeOneofCase = stateTypeCase;
			if (stateTypeOneofCase == Channel.StateTypeOneofCase.PublicChannelState)
			{
				this.PublicChannelState = other.PublicChannelState.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C0B RID: 39947 RVA: 0x0025E768 File Offset: 0x0025C968
		[DebuggerNonUserCode]
		public Channel Clone()
		{
			return new Channel(this);
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x06009C0C RID: 39948 RVA: 0x0025E780 File Offset: 0x0025C980
		// (set) Token: 0x06009C0D RID: 39949 RVA: 0x0025E798 File Offset: 0x0025C998
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

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x06009C0E RID: 39950 RVA: 0x0025E7A4 File Offset: 0x0025C9A4
		// (set) Token: 0x06009C0F RID: 39951 RVA: 0x0025E7BC File Offset: 0x0025C9BC
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

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x06009C10 RID: 39952 RVA: 0x0025E7C8 File Offset: 0x0025C9C8
		// (set) Token: 0x06009C11 RID: 39953 RVA: 0x0025E7E9 File Offset: 0x0025C9E9
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Channel.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x06009C12 RID: 39954 RVA: 0x0025E800 File Offset: 0x0025CA00
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x0025E81B File Offset: 0x0025CA1B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x06009C14 RID: 39956 RVA: 0x0025E828 File Offset: 0x0025CA28
		// (set) Token: 0x06009C15 RID: 39957 RVA: 0x0025E859 File Offset: 0x0025CA59
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
					privacyLevelDefaultValue = Channel.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x06009C16 RID: 39958 RVA: 0x0025E874 File Offset: 0x0025CA74
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x0025E891 File Offset: 0x0025CA91
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x06009C18 RID: 39960 RVA: 0x0025E8A4 File Offset: 0x0025CAA4
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x06009C19 RID: 39961 RVA: 0x0025E8BC File Offset: 0x0025CABC
		[DebuggerNonUserCode]
		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x06009C1A RID: 39962 RVA: 0x0025E8D4 File Offset: 0x0025CAD4
		[DebuggerNonUserCode]
		public RepeatedField<ChannelInvitation> Invitation
		{
			get
			{
				return this.invitation_;
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x06009C1B RID: 39963 RVA: 0x0025E8EC File Offset: 0x0025CAEC
		// (set) Token: 0x06009C1C RID: 39964 RVA: 0x0025E904 File Offset: 0x0025CB04
		[DebuggerNonUserCode]
		public ChannelRoleSet RoleSet
		{
			get
			{
				return this.roleSet_;
			}
			set
			{
				this.roleSet_ = value;
			}
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x06009C1D RID: 39965 RVA: 0x0025E910 File Offset: 0x0025CB10
		// (set) Token: 0x06009C1E RID: 39966 RVA: 0x0025E93A File Offset: 0x0025CB3A
		[DebuggerNonUserCode]
		public PublicChannelState PublicChannelState
		{
			get
			{
				return (this.stateTypeCase_ == Channel.StateTypeOneofCase.PublicChannelState) ? ((PublicChannelState)this.stateType_) : null;
			}
			set
			{
				this.stateType_ = value;
				this.stateTypeCase_ = ((value == null) ? Channel.StateTypeOneofCase.None : Channel.StateTypeOneofCase.PublicChannelState);
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x06009C1F RID: 39967 RVA: 0x0025E954 File Offset: 0x0025CB54
		[DebuggerNonUserCode]
		public Channel.StateTypeOneofCase StateTypeCase
		{
			get
			{
				return this.stateTypeCase_;
			}
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x0025E96C File Offset: 0x0025CB6C
		[DebuggerNonUserCode]
		public void ClearStateType()
		{
			this.stateTypeCase_ = Channel.StateTypeOneofCase.None;
			this.stateType_ = null;
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x0025E980 File Offset: 0x0025CB80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Channel);
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x0025E9A0 File Offset: 0x0025CBA0
		[DebuggerNonUserCode]
		public bool Equals(Channel other)
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
										bool flag9 = !this.member_.Equals(other.member_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.invitation_.Equals(other.invitation_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.RoleSet, other.RoleSet);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.PublicChannelState, other.PublicChannelState);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.StateTypeCase != other.StateTypeCase;
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
													}
												}
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

		// Token: 0x06009C23 RID: 39971 RVA: 0x0025EB18 File Offset: 0x0025CD18
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
			num ^= this.member_.GetHashCode();
			num ^= this.invitation_.GetHashCode();
			bool flag3 = this.roleSet_ != null;
			if (flag3)
			{
				num ^= this.RoleSet.GetHashCode();
			}
			bool flag4 = this.stateTypeCase_ == Channel.StateTypeOneofCase.PublicChannelState;
			if (flag4)
			{
				num ^= this.PublicChannelState.GetHashCode();
			}
			num ^= (int)this.stateTypeCase_;
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x0025EC30 File Offset: 0x0025CE30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x0025EC48 File Offset: 0x0025CE48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x0025EC54 File Offset: 0x0025CE54
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
			this.attribute_.WriteTo(ref output, Channel._repeated_attribute_codec);
			this.member_.WriteTo(ref output, Channel._repeated_member_codec);
			this.invitation_.WriteTo(ref output, Channel._repeated_invitation_codec);
			bool flag3 = this.roleSet_ != null;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RoleSet);
			}
			bool flag4 = this.stateTypeCase_ == Channel.StateTypeOneofCase.PublicChannelState;
			if (flag4)
			{
				output.WriteRawTag(242, 6);
				output.WriteMessage(this.PublicChannelState);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x0025ED98 File Offset: 0x0025CF98
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
			num += this.attribute_.CalculateSize(Channel._repeated_attribute_codec);
			num += this.member_.CalculateSize(Channel._repeated_member_codec);
			num += this.invitation_.CalculateSize(Channel._repeated_invitation_codec);
			bool flag3 = this.roleSet_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleSet);
			}
			bool flag4 = this.stateTypeCase_ == Channel.StateTypeOneofCase.PublicChannelState;
			if (flag4)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PublicChannelState);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x0025EEC4 File Offset: 0x0025D0C4
		[DebuggerNonUserCode]
		public void MergeFrom(Channel other)
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
				this.member_.Add(other.member_);
				this.invitation_.Add(other.invitation_);
				bool flag6 = other.roleSet_ != null;
				if (flag6)
				{
					bool flag7 = this.roleSet_ == null;
					if (flag7)
					{
						this.RoleSet = new ChannelRoleSet();
					}
					this.RoleSet.MergeFrom(other.RoleSet);
				}
				Channel.StateTypeOneofCase stateTypeCase = other.StateTypeCase;
				Channel.StateTypeOneofCase stateTypeOneofCase = stateTypeCase;
				if (stateTypeOneofCase == Channel.StateTypeOneofCase.PublicChannelState)
				{
					bool flag8 = this.PublicChannelState == null;
					if (flag8)
					{
						this.PublicChannelState = new PublicChannelState();
					}
					this.PublicChannelState.MergeFrom(other.PublicChannelState);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x0025F062 File Offset: 0x0025D262
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x0025F070 File Offset: 0x0025D270
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0074;
							}
							bool flag = this.type_ == null;
							if (flag)
							{
								this.Type = new UniqueChannelType();
							}
							input.ReadMessage(this.Type);
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
					else if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							goto IL_0074;
						}
						this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0074;
						}
						this.member_.AddEntriesFrom(ref input, Channel._repeated_member_codec);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, Channel._repeated_attribute_codec);
					}
				}
				else if (num3 != 58U)
				{
					if (num3 != 66U)
					{
						if (num3 != 882U)
						{
							goto IL_0074;
						}
						PublicChannelState publicChannelState = new PublicChannelState();
						bool flag3 = this.stateTypeCase_ == Channel.StateTypeOneofCase.PublicChannelState;
						if (flag3)
						{
							publicChannelState.MergeFrom(this.PublicChannelState);
						}
						input.ReadMessage(publicChannelState);
						this.PublicChannelState = publicChannelState;
					}
					else
					{
						bool flag4 = this.roleSet_ == null;
						if (flag4)
						{
							this.RoleSet = new ChannelRoleSet();
						}
						input.ReadMessage(this.RoleSet);
					}
				}
				else
				{
					this.invitation_.AddEntriesFrom(ref input, Channel._repeated_invitation_codec);
				}
				continue;
				IL_0074:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004664 RID: 18020
		private static readonly MessageParser<Channel> _parser = new MessageParser<Channel>(() => new Channel());

		// Token: 0x04004665 RID: 18021
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004666 RID: 18022
		private int _hasBits0;

		// Token: 0x04004667 RID: 18023
		public const int IdFieldNumber = 1;

		// Token: 0x04004668 RID: 18024
		private ChannelId id_;

		// Token: 0x04004669 RID: 18025
		public const int TypeFieldNumber = 2;

		// Token: 0x0400466A RID: 18026
		private UniqueChannelType type_;

		// Token: 0x0400466B RID: 18027
		public const int NameFieldNumber = 3;

		// Token: 0x0400466C RID: 18028
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400466D RID: 18029
		private string name_;

		// Token: 0x0400466E RID: 18030
		public const int PrivacyLevelFieldNumber = 4;

		// Token: 0x0400466F RID: 18031
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x04004670 RID: 18032
		private PrivacyLevel privacyLevel_;

		// Token: 0x04004671 RID: 18033
		public const int AttributeFieldNumber = 5;

		// Token: 0x04004672 RID: 18034
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(42U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004673 RID: 18035
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04004674 RID: 18036
		public const int MemberFieldNumber = 6;

		// Token: 0x04004675 RID: 18037
		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(50U, Bgs.Protocol.Channel.V2.Member.Parser);

		// Token: 0x04004676 RID: 18038
		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();

		// Token: 0x04004677 RID: 18039
		public const int InvitationFieldNumber = 7;

		// Token: 0x04004678 RID: 18040
		private static readonly FieldCodec<ChannelInvitation> _repeated_invitation_codec = FieldCodec.ForMessage<ChannelInvitation>(58U, ChannelInvitation.Parser);

		// Token: 0x04004679 RID: 18041
		private readonly RepeatedField<ChannelInvitation> invitation_ = new RepeatedField<ChannelInvitation>();

		// Token: 0x0400467A RID: 18042
		public const int RoleSetFieldNumber = 8;

		// Token: 0x0400467B RID: 18043
		private ChannelRoleSet roleSet_;

		// Token: 0x0400467C RID: 18044
		public const int PublicChannelStateFieldNumber = 110;

		// Token: 0x0400467D RID: 18045
		private object stateType_;

		// Token: 0x0400467E RID: 18046
		private Channel.StateTypeOneofCase stateTypeCase_ = Channel.StateTypeOneofCase.None;

		// Token: 0x0200118C RID: 4492
		public enum StateTypeOneofCase
		{
			// Token: 0x040098C3 RID: 39107
			None,
			// Token: 0x040098C4 RID: 39108
			PublicChannelState = 110
		}
	}
}
