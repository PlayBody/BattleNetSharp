using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000388 RID: 904
	public sealed class RoleState : IMessage<RoleState>, IMessage, IEquatable<RoleState>, IDeepCloneable<RoleState>, IBufferMessage
	{
		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06005BCF RID: 23503 RVA: 0x00163364 File Offset: 0x00161564
		[DebuggerNonUserCode]
		public static MessageParser<RoleState> Parser
		{
			get
			{
				return RoleState._parser;
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x0016337C File Offset: 0x0016157C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RoleTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x001633A0 File Offset: 0x001615A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleState.Descriptor;
			}
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x001633B7 File Offset: 0x001615B7
		[DebuggerNonUserCode]
		public RoleState()
		{
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x001633F0 File Offset: 0x001615F0
		[DebuggerNonUserCode]
		public RoleState(RoleState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.assignableRole_ = other.assignableRole_.Clone();
			this.required_ = other.required_;
			this.unique_ = other.unique_;
			this.relegationRole_ = other.relegationRole_;
			this.kickableRole_ = other.kickableRole_.Clone();
			this.removableRole_ = other.removableRole_.Clone();
			this.mentionableRole_ = other.mentionableRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x00163498 File Offset: 0x00161698
		[DebuggerNonUserCode]
		public RoleState Clone()
		{
			return new RoleState(this);
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06005BD5 RID: 23509 RVA: 0x001634B0 File Offset: 0x001616B0
		// (set) Token: 0x06005BD6 RID: 23510 RVA: 0x001634D1 File Offset: 0x001616D1
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? RoleState.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06005BD7 RID: 23511 RVA: 0x001634E8 File Offset: 0x001616E8
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00163503 File Offset: 0x00161703
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06005BD9 RID: 23513 RVA: 0x00163510 File Offset: 0x00161710
		[DebuggerNonUserCode]
		public RepeatedField<uint> AssignableRole
		{
			get
			{
				return this.assignableRole_;
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06005BDA RID: 23514 RVA: 0x00163528 File Offset: 0x00161728
		// (set) Token: 0x06005BDB RID: 23515 RVA: 0x00163559 File Offset: 0x00161759
		[DebuggerNonUserCode]
		public bool Required
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool requiredDefaultValue;
				if (flag)
				{
					requiredDefaultValue = this.required_;
				}
				else
				{
					requiredDefaultValue = RoleState.RequiredDefaultValue;
				}
				return requiredDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.required_ = value;
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06005BDC RID: 23516 RVA: 0x00163574 File Offset: 0x00161774
		[DebuggerNonUserCode]
		public bool HasRequired
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x00163591 File Offset: 0x00161791
		[DebuggerNonUserCode]
		public void ClearRequired()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x001635A4 File Offset: 0x001617A4
		// (set) Token: 0x06005BDF RID: 23519 RVA: 0x001635D5 File Offset: 0x001617D5
		[DebuggerNonUserCode]
		public bool Unique
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool uniqueDefaultValue;
				if (flag)
				{
					uniqueDefaultValue = this.unique_;
				}
				else
				{
					uniqueDefaultValue = RoleState.UniqueDefaultValue;
				}
				return uniqueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.unique_ = value;
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x001635F0 File Offset: 0x001617F0
		[DebuggerNonUserCode]
		public bool HasUnique
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x0016360D File Offset: 0x0016180D
		[DebuggerNonUserCode]
		public void ClearUnique()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x00163620 File Offset: 0x00161820
		// (set) Token: 0x06005BE3 RID: 23523 RVA: 0x00163651 File Offset: 0x00161851
		[DebuggerNonUserCode]
		public uint RelegationRole
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint relegationRoleDefaultValue;
				if (flag)
				{
					relegationRoleDefaultValue = this.relegationRole_;
				}
				else
				{
					relegationRoleDefaultValue = RoleState.RelegationRoleDefaultValue;
				}
				return relegationRoleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.relegationRole_ = value;
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x0016366C File Offset: 0x0016186C
		[DebuggerNonUserCode]
		public bool HasRelegationRole
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x00163689 File Offset: 0x00161889
		[DebuggerNonUserCode]
		public void ClearRelegationRole()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x0016369C File Offset: 0x0016189C
		[DebuggerNonUserCode]
		public RepeatedField<uint> KickableRole
		{
			get
			{
				return this.kickableRole_;
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x06005BE7 RID: 23527 RVA: 0x001636B4 File Offset: 0x001618B4
		[DebuggerNonUserCode]
		public RepeatedField<uint> RemovableRole
		{
			get
			{
				return this.removableRole_;
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x001636CC File Offset: 0x001618CC
		[DebuggerNonUserCode]
		public RepeatedField<uint> MentionableRole
		{
			get
			{
				return this.mentionableRole_;
			}
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x001636E4 File Offset: 0x001618E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleState);
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x00163704 File Offset: 0x00161904
		[DebuggerNonUserCode]
		public bool Equals(RoleState other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.assignableRole_.Equals(other.assignableRole_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Required != other.Required;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Unique != other.Unique;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.RelegationRole != other.RelegationRole;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.kickableRole_.Equals(other.kickableRole_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !this.removableRole_.Equals(other.removableRole_);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !this.mentionableRole_.Equals(other.mentionableRole_);
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

		// Token: 0x06005BEB RID: 23531 RVA: 0x00163838 File Offset: 0x00161A38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
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
			num ^= this.mentionableRole_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x00163914 File Offset: 0x00161B14
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x0016392C File Offset: 0x00161B2C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x00163938 File Offset: 0x00161B38
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			this.assignableRole_.WriteTo(ref output, RoleState._repeated_assignableRole_codec);
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
			this.kickableRole_.WriteTo(ref output, RoleState._repeated_kickableRole_codec);
			this.removableRole_.WriteTo(ref output, RoleState._repeated_removableRole_codec);
			this.mentionableRole_.WriteTo(ref output, RoleState._repeated_mentionableRole_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x00163A34 File Offset: 0x00161C34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.assignableRole_.CalculateSize(RoleState._repeated_assignableRole_codec);
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
			num += this.kickableRole_.CalculateSize(RoleState._repeated_kickableRole_codec);
			num += this.removableRole_.CalculateSize(RoleState._repeated_removableRole_codec);
			num += this.mentionableRole_.CalculateSize(RoleState._repeated_mentionableRole_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x00163B10 File Offset: 0x00161D10
		[DebuggerNonUserCode]
		public void MergeFrom(RoleState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
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
				this.mentionableRole_.Add(other.mentionableRole_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x00163BF1 File Offset: 0x00161DF1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x00163BFC File Offset: 0x00161DFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 56U)
				{
					if (num3 <= 34U)
					{
						if (num3 != 18U)
						{
							if (num3 != 32U && num3 != 34U)
							{
								goto IL_0092;
							}
							this.assignableRole_.AddEntriesFrom(ref input, RoleState._repeated_assignableRole_codec);
						}
						else
						{
							this.Name = input.ReadString();
						}
					}
					else if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							if (num3 != 56U)
							{
								goto IL_0092;
							}
							this.RelegationRole = input.ReadUInt32();
						}
						else
						{
							this.Unique = input.ReadBool();
						}
					}
					else
					{
						this.Required = input.ReadBool();
					}
				}
				else
				{
					if (num3 <= 80U)
					{
						if (num3 == 72U || num3 == 74U)
						{
							this.kickableRole_.AddEntriesFrom(ref input, RoleState._repeated_kickableRole_codec);
							continue;
						}
						if (num3 != 80U)
						{
							goto IL_0092;
						}
					}
					else if (num3 != 82U)
					{
						if (num3 != 88U && num3 != 90U)
						{
							goto IL_0092;
						}
						this.mentionableRole_.AddEntriesFrom(ref input, RoleState._repeated_mentionableRole_codec);
						continue;
					}
					this.removableRole_.AddEntriesFrom(ref input, RoleState._repeated_removableRole_codec);
				}
				continue;
				IL_0092:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040029F0 RID: 10736
		private static readonly MessageParser<RoleState> _parser = new MessageParser<RoleState>(() => new RoleState());

		// Token: 0x040029F1 RID: 10737
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029F2 RID: 10738
		private int _hasBits0;

		// Token: 0x040029F3 RID: 10739
		public const int NameFieldNumber = 2;

		// Token: 0x040029F4 RID: 10740
		private static readonly string NameDefaultValue = "";

		// Token: 0x040029F5 RID: 10741
		private string name_;

		// Token: 0x040029F6 RID: 10742
		public const int AssignableRoleFieldNumber = 4;

		// Token: 0x040029F7 RID: 10743
		private static readonly FieldCodec<uint> _repeated_assignableRole_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040029F8 RID: 10744
		private readonly RepeatedField<uint> assignableRole_ = new RepeatedField<uint>();

		// Token: 0x040029F9 RID: 10745
		public const int RequiredFieldNumber = 5;

		// Token: 0x040029FA RID: 10746
		private static readonly bool RequiredDefaultValue = false;

		// Token: 0x040029FB RID: 10747
		private bool required_;

		// Token: 0x040029FC RID: 10748
		public const int UniqueFieldNumber = 6;

		// Token: 0x040029FD RID: 10749
		private static readonly bool UniqueDefaultValue = false;

		// Token: 0x040029FE RID: 10750
		private bool unique_;

		// Token: 0x040029FF RID: 10751
		public const int RelegationRoleFieldNumber = 7;

		// Token: 0x04002A00 RID: 10752
		private static readonly uint RelegationRoleDefaultValue = 0U;

		// Token: 0x04002A01 RID: 10753
		private uint relegationRole_;

		// Token: 0x04002A02 RID: 10754
		public const int KickableRoleFieldNumber = 9;

		// Token: 0x04002A03 RID: 10755
		private static readonly FieldCodec<uint> _repeated_kickableRole_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04002A04 RID: 10756
		private readonly RepeatedField<uint> kickableRole_ = new RepeatedField<uint>();

		// Token: 0x04002A05 RID: 10757
		public const int RemovableRoleFieldNumber = 10;

		// Token: 0x04002A06 RID: 10758
		private static readonly FieldCodec<uint> _repeated_removableRole_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04002A07 RID: 10759
		private readonly RepeatedField<uint> removableRole_ = new RepeatedField<uint>();

		// Token: 0x04002A08 RID: 10760
		public const int MentionableRoleFieldNumber = 11;

		// Token: 0x04002A09 RID: 10761
		private static readonly FieldCodec<uint> _repeated_mentionableRole_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04002A0A RID: 10762
		private readonly RepeatedField<uint> mentionableRole_ = new RepeatedField<uint>();
	}
}
