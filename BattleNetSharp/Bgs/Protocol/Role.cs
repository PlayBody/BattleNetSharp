using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000387 RID: 903
	public sealed class Role : IMessage<Role>, IMessage, IEquatable<Role>, IDeepCloneable<Role>, IBufferMessage
	{
		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06005BA6 RID: 23462 RVA: 0x001627B8 File Offset: 0x001609B8
		[DebuggerNonUserCode]
		public static MessageParser<Role> Parser
		{
			get
			{
				return Role._parser;
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06005BA7 RID: 23463 RVA: 0x001627D0 File Offset: 0x001609D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RoleTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06005BA8 RID: 23464 RVA: 0x001627F4 File Offset: 0x001609F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Role.Descriptor;
			}
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x0016280B File Offset: 0x00160A0B
		[DebuggerNonUserCode]
		public Role()
		{
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x00162844 File Offset: 0x00160A44
		[DebuggerNonUserCode]
		public Role(Role other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.privilege_ = other.privilege_.Clone();
			this.assignableRole_ = other.assignableRole_.Clone();
			this.required_ = other.required_;
			this.unique_ = other.unique_;
			this.relegationRole_ = other.relegationRole_;
			this.kickableRole_ = other.kickableRole_.Clone();
			this.removableRole_ = other.removableRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x001628F8 File Offset: 0x00160AF8
		[DebuggerNonUserCode]
		public Role Clone()
		{
			return new Role(this);
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06005BAC RID: 23468 RVA: 0x00162910 File Offset: 0x00160B10
		// (set) Token: 0x06005BAD RID: 23469 RVA: 0x00162941 File Offset: 0x00160B41
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Role.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06005BAE RID: 23470 RVA: 0x0016295C File Offset: 0x00160B5C
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00162979 File Offset: 0x00160B79
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x0016298C File Offset: 0x00160B8C
		// (set) Token: 0x06005BB1 RID: 23473 RVA: 0x001629AD File Offset: 0x00160BAD
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Role.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x001629C4 File Offset: 0x00160BC4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x001629DF File Offset: 0x00160BDF
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x001629EC File Offset: 0x00160BEC
		[DebuggerNonUserCode]
		public RepeatedField<string> Privilege
		{
			get
			{
				return this.privilege_;
			}
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06005BB5 RID: 23477 RVA: 0x00162A04 File Offset: 0x00160C04
		[DebuggerNonUserCode]
		public RepeatedField<uint> AssignableRole
		{
			get
			{
				return this.assignableRole_;
			}
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x00162A1C File Offset: 0x00160C1C
		// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x00162A4D File Offset: 0x00160C4D
		[DebuggerNonUserCode]
		public bool Required
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool requiredDefaultValue;
				if (flag)
				{
					requiredDefaultValue = this.required_;
				}
				else
				{
					requiredDefaultValue = Role.RequiredDefaultValue;
				}
				return requiredDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.required_ = value;
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x00162A68 File Offset: 0x00160C68
		[DebuggerNonUserCode]
		public bool HasRequired
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x00162A85 File Offset: 0x00160C85
		[DebuggerNonUserCode]
		public void ClearRequired()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06005BBA RID: 23482 RVA: 0x00162A98 File Offset: 0x00160C98
		// (set) Token: 0x06005BBB RID: 23483 RVA: 0x00162AC9 File Offset: 0x00160CC9
		[DebuggerNonUserCode]
		public bool Unique
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool uniqueDefaultValue;
				if (flag)
				{
					uniqueDefaultValue = this.unique_;
				}
				else
				{
					uniqueDefaultValue = Role.UniqueDefaultValue;
				}
				return uniqueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.unique_ = value;
			}
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06005BBC RID: 23484 RVA: 0x00162AE4 File Offset: 0x00160CE4
		[DebuggerNonUserCode]
		public bool HasUnique
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00162B01 File Offset: 0x00160D01
		[DebuggerNonUserCode]
		public void ClearUnique()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06005BBE RID: 23486 RVA: 0x00162B14 File Offset: 0x00160D14
		// (set) Token: 0x06005BBF RID: 23487 RVA: 0x00162B45 File Offset: 0x00160D45
		[DebuggerNonUserCode]
		public uint RelegationRole
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint relegationRoleDefaultValue;
				if (flag)
				{
					relegationRoleDefaultValue = this.relegationRole_;
				}
				else
				{
					relegationRoleDefaultValue = Role.RelegationRoleDefaultValue;
				}
				return relegationRoleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.relegationRole_ = value;
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06005BC0 RID: 23488 RVA: 0x00162B60 File Offset: 0x00160D60
		[DebuggerNonUserCode]
		public bool HasRelegationRole
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x00162B7D File Offset: 0x00160D7D
		[DebuggerNonUserCode]
		public void ClearRelegationRole()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06005BC2 RID: 23490 RVA: 0x00162B90 File Offset: 0x00160D90
		[DebuggerNonUserCode]
		public RepeatedField<uint> KickableRole
		{
			get
			{
				return this.kickableRole_;
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x06005BC3 RID: 23491 RVA: 0x00162BA8 File Offset: 0x00160DA8
		[DebuggerNonUserCode]
		public RepeatedField<uint> RemovableRole
		{
			get
			{
				return this.removableRole_;
			}
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x00162BC0 File Offset: 0x00160DC0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Role);
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x00162BE0 File Offset: 0x00160DE0
		[DebuggerNonUserCode]
		public bool Equals(Role other)
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
					bool flag4 = this.Id != other.Id;
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
							bool flag6 = !this.privilege_.Equals(other.privilege_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.assignableRole_.Equals(other.assignableRole_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Required != other.Required;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Unique != other.Unique;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.RelegationRole != other.RelegationRole;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !this.kickableRole_.Equals(other.kickableRole_);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !this.removableRole_.Equals(other.removableRole_);
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06005BC6 RID: 23494 RVA: 0x00162D30 File Offset: 0x00160F30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.privilege_.GetHashCode();
			num ^= this.assignableRole_.GetHashCode();
			bool hasRequired = this.HasRequired;
			if (hasRequired)
			{
				num ^= this.Required.GetHashCode();
			}
			bool hasUnique = this.HasUnique;
			if (hasUnique)
			{
				num ^= this.Unique.GetHashCode();
			}
			bool hasRelegationRole = this.HasRelegationRole;
			if (hasRelegationRole)
			{
				num ^= this.RelegationRole.GetHashCode();
			}
			num ^= this.kickableRole_.GetHashCode();
			num ^= this.removableRole_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x00162E2C File Offset: 0x0016102C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x00162E44 File Offset: 0x00161044
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00162E50 File Offset: 0x00161050
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			this.privilege_.WriteTo(ref output, Role._repeated_privilege_codec);
			this.assignableRole_.WriteTo(ref output, Role._repeated_assignableRole_codec);
			bool hasRequired = this.HasRequired;
			if (hasRequired)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Required);
			}
			bool hasUnique = this.HasUnique;
			if (hasUnique)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Unique);
			}
			bool hasRelegationRole = this.HasRelegationRole;
			if (hasRelegationRole)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.RelegationRole);
			}
			this.kickableRole_.WriteTo(ref output, Role._repeated_kickableRole_codec);
			this.removableRole_.WriteTo(ref output, Role._repeated_removableRole_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00162F70 File Offset: 0x00161170
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.privilege_.CalculateSize(Role._repeated_privilege_codec);
			num += this.assignableRole_.CalculateSize(Role._repeated_assignableRole_codec);
			bool hasRequired = this.HasRequired;
			if (hasRequired)
			{
				num += 2;
			}
			bool hasUnique = this.HasUnique;
			if (hasUnique)
			{
				num += 2;
			}
			bool hasRelegationRole = this.HasRelegationRole;
			if (hasRelegationRole)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RelegationRole);
			}
			num += this.kickableRole_.CalculateSize(Role._repeated_kickableRole_codec);
			num += this.removableRole_.CalculateSize(Role._repeated_removableRole_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x0016306C File Offset: 0x0016126C
		[DebuggerNonUserCode]
		public void MergeFrom(Role other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this.privilege_.Add(other.privilege_);
				this.assignableRole_.Add(other.assignableRole_);
				bool hasRequired = other.HasRequired;
				if (hasRequired)
				{
					this.Required = other.Required;
				}
				bool hasUnique = other.HasUnique;
				if (hasUnique)
				{
					this.Unique = other.Unique;
				}
				bool hasRelegationRole = other.HasRelegationRole;
				if (hasRelegationRole)
				{
					this.RelegationRole = other.RelegationRole;
				}
				this.kickableRole_.Add(other.kickableRole_);
				this.removableRole_.Add(other.removableRole_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00163168 File Offset: 0x00161368
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x00163174 File Offset: 0x00161374
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_0091;
								}
								this.privilege_.AddEntriesFrom(ref input, Role._repeated_privilege_codec);
							}
							else
							{
								this.Name = input.ReadString();
							}
						}
						else
						{
							this.Id = input.ReadUInt32();
						}
					}
					else if (num3 != 32U && num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0091;
						}
						this.Required = input.ReadBool();
					}
					else
					{
						this.assignableRole_.AddEntriesFrom(ref input, Role._repeated_assignableRole_codec);
					}
				}
				else
				{
					if (num3 <= 72U)
					{
						if (num3 == 48U)
						{
							this.Unique = input.ReadBool();
							continue;
						}
						if (num3 == 56U)
						{
							this.RelegationRole = input.ReadUInt32();
							continue;
						}
						if (num3 != 72U)
						{
							goto IL_0091;
						}
					}
					else if (num3 != 74U)
					{
						if (num3 != 80U && num3 != 82U)
						{
							goto IL_0091;
						}
						this.removableRole_.AddEntriesFrom(ref input, Role._repeated_removableRole_codec);
						continue;
					}
					this.kickableRole_.AddEntriesFrom(ref input, Role._repeated_kickableRole_codec);
				}
				continue;
				IL_0091:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040029D2 RID: 10706
		private static readonly MessageParser<Role> _parser = new MessageParser<Role>(() => new Role());

		// Token: 0x040029D3 RID: 10707
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029D4 RID: 10708
		private int _hasBits0;

		// Token: 0x040029D5 RID: 10709
		public const int IdFieldNumber = 1;

		// Token: 0x040029D6 RID: 10710
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x040029D7 RID: 10711
		private uint id_;

		// Token: 0x040029D8 RID: 10712
		public const int NameFieldNumber = 2;

		// Token: 0x040029D9 RID: 10713
		private static readonly string NameDefaultValue = "";

		// Token: 0x040029DA RID: 10714
		private string name_;

		// Token: 0x040029DB RID: 10715
		public const int PrivilegeFieldNumber = 3;

		// Token: 0x040029DC RID: 10716
		private static readonly FieldCodec<string> _repeated_privilege_codec = FieldCodec.ForString(26U);

		// Token: 0x040029DD RID: 10717
		private readonly RepeatedField<string> privilege_ = new RepeatedField<string>();

		// Token: 0x040029DE RID: 10718
		public const int AssignableRoleFieldNumber = 4;

		// Token: 0x040029DF RID: 10719
		private static readonly FieldCodec<uint> _repeated_assignableRole_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040029E0 RID: 10720
		private readonly RepeatedField<uint> assignableRole_ = new RepeatedField<uint>();

		// Token: 0x040029E1 RID: 10721
		public const int RequiredFieldNumber = 5;

		// Token: 0x040029E2 RID: 10722
		private static readonly bool RequiredDefaultValue = false;

		// Token: 0x040029E3 RID: 10723
		private bool required_;

		// Token: 0x040029E4 RID: 10724
		public const int UniqueFieldNumber = 6;

		// Token: 0x040029E5 RID: 10725
		private static readonly bool UniqueDefaultValue = false;

		// Token: 0x040029E6 RID: 10726
		private bool unique_;

		// Token: 0x040029E7 RID: 10727
		public const int RelegationRoleFieldNumber = 7;

		// Token: 0x040029E8 RID: 10728
		private static readonly uint RelegationRoleDefaultValue = 0U;

		// Token: 0x040029E9 RID: 10729
		private uint relegationRole_;

		// Token: 0x040029EA RID: 10730
		public const int KickableRoleFieldNumber = 9;

		// Token: 0x040029EB RID: 10731
		private static readonly FieldCodec<uint> _repeated_kickableRole_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040029EC RID: 10732
		private readonly RepeatedField<uint> kickableRole_ = new RepeatedField<uint>();

		// Token: 0x040029ED RID: 10733
		public const int RemovableRoleFieldNumber = 10;

		// Token: 0x040029EE RID: 10734
		private static readonly FieldCodec<uint> _repeated_removableRole_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x040029EF RID: 10735
		private readonly RepeatedField<uint> removableRole_ = new RepeatedField<uint>();
	}
}
