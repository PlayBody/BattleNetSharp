using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x02000419 RID: 1049
	public sealed class Friend : IMessage<Friend>, IMessage, IEquatable<Friend>, IDeepCloneable<Friend>, IBufferMessage
	{
		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06006748 RID: 26440 RVA: 0x0018FEF8 File Offset: 0x0018E0F8
		[DebuggerNonUserCode]
		public static MessageParser<Friend> Parser
		{
			get
			{
				return Friend._parser;
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x0018FF10 File Offset: 0x0018E110
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600674A RID: 26442 RVA: 0x0018FF34 File Offset: 0x0018E134
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Friend.Descriptor;
			}
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x0018FF4B File Offset: 0x0018E14B
		[DebuggerNonUserCode]
		public Friend()
		{
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x0018FF6C File Offset: 0x0018E16C
		[DebuggerNonUserCode]
		public Friend(Friend other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.role_ = other.role_.Clone();
			this.privileges_ = other.privileges_;
			this.attributesEpoch_ = other.attributesEpoch_;
			this.creationTime_ = other.creationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x00190000 File Offset: 0x0018E200
		[DebuggerNonUserCode]
		public Friend Clone()
		{
			return new Friend(this);
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600674E RID: 26446 RVA: 0x00190018 File Offset: 0x0018E218
		// (set) Token: 0x0600674F RID: 26447 RVA: 0x00190030 File Offset: 0x0018E230
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x0019003C File Offset: 0x0018E23C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x00190054 File Offset: 0x0018E254
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06006752 RID: 26450 RVA: 0x0019006C File Offset: 0x0018E26C
		// (set) Token: 0x06006753 RID: 26451 RVA: 0x0019009D File Offset: 0x0018E29D
		[DebuggerNonUserCode]
		public ulong Privileges
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong privilegesDefaultValue;
				if (flag)
				{
					privilegesDefaultValue = this.privileges_;
				}
				else
				{
					privilegesDefaultValue = Friend.PrivilegesDefaultValue;
				}
				return privilegesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privileges_ = value;
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x001900B8 File Offset: 0x0018E2B8
		[DebuggerNonUserCode]
		public bool HasPrivileges
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x001900D5 File Offset: 0x0018E2D5
		[DebuggerNonUserCode]
		public void ClearPrivileges()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x001900E8 File Offset: 0x0018E2E8
		// (set) Token: 0x06006757 RID: 26455 RVA: 0x00190119 File Offset: 0x0018E319
		[Obsolete]
		[DebuggerNonUserCode]
		public ulong AttributesEpoch
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong attributesEpochDefaultValue;
				if (flag)
				{
					attributesEpochDefaultValue = this.attributesEpoch_;
				}
				else
				{
					attributesEpochDefaultValue = Friend.AttributesEpochDefaultValue;
				}
				return attributesEpochDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.attributesEpoch_ = value;
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06006758 RID: 26456 RVA: 0x00190134 File Offset: 0x0018E334
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasAttributesEpoch
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x00190151 File Offset: 0x0018E351
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearAttributesEpoch()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x00190164 File Offset: 0x0018E364
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x00190195 File Offset: 0x0018E395
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = Friend.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.creationTime_ = value;
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x001901B0 File Offset: 0x0018E3B0
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x001901CD File Offset: 0x0018E3CD
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x001901E0 File Offset: 0x0018E3E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Friend);
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x00190200 File Offset: 0x0018E400
		[DebuggerNonUserCode]
		public bool Equals(Friend other)
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
					bool flag4 = !object.Equals(this.AccountId, other.AccountId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.role_.Equals(other.role_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Privileges != other.Privileges;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AttributesEpoch != other.AttributesEpoch;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CreationTime != other.CreationTime;
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

		// Token: 0x06006760 RID: 26464 RVA: 0x001902F4 File Offset: 0x0018E4F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			num ^= this.role_.GetHashCode();
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num ^= this.Privileges.GetHashCode();
			}
			bool hasAttributesEpoch = this.HasAttributesEpoch;
			if (hasAttributesEpoch)
			{
				num ^= this.AttributesEpoch.GetHashCode();
			}
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

		// Token: 0x06006761 RID: 26465 RVA: 0x001903B8 File Offset: 0x0018E5B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x001903D0 File Offset: 0x0018E5D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x001903DC File Offset: 0x0018E5DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountId);
			}
			this.attribute_.WriteTo(ref output, Friend._repeated_attribute_codec);
			this.role_.WriteTo(ref output, Friend._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.Privileges);
			}
			bool hasAttributesEpoch = this.HasAttributesEpoch;
			if (hasAttributesEpoch)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.AttributesEpoch);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x001904B8 File Offset: 0x0018E6B8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			num += this.attribute_.CalculateSize(Friend._repeated_attribute_codec);
			num += this.role_.CalculateSize(Friend._repeated_role_codec);
			bool hasPrivileges = this.HasPrivileges;
			if (hasPrivileges)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Privileges);
			}
			bool hasAttributesEpoch = this.HasAttributesEpoch;
			if (hasAttributesEpoch)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AttributesEpoch);
			}
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

		// Token: 0x06006765 RID: 26469 RVA: 0x0019058C File Offset: 0x0018E78C
		[DebuggerNonUserCode]
		public void MergeFrom(Friend other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountId_ != null;
				if (flag2)
				{
					bool flag3 = this.accountId_ == null;
					if (flag3)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				this.attribute_.Add(other.attribute_);
				this.role_.Add(other.role_);
				bool hasPrivileges = other.HasPrivileges;
				if (hasPrivileges)
				{
					this.Privileges = other.Privileges;
				}
				bool hasAttributesEpoch = other.HasAttributesEpoch;
				if (hasAttributesEpoch)
				{
					this.AttributesEpoch = other.AttributesEpoch;
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x0019066E File Offset: 0x0018E86E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x0019067C File Offset: 0x0018E87C
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
								goto IL_0052;
							}
							goto IL_00A9;
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, Friend._repeated_attribute_codec);
						}
					}
					else
					{
						bool flag = this.accountId_ == null;
						if (flag)
						{
							this.AccountId = new EntityId();
						}
						input.ReadMessage(this.AccountId);
					}
				}
				else if (num3 <= 32U)
				{
					if (num3 == 26U)
					{
						goto IL_00A9;
					}
					if (num3 != 32U)
					{
						goto IL_0052;
					}
					this.Privileges = input.ReadUInt64();
				}
				else if (num3 != 40U)
				{
					if (num3 != 48U)
					{
						goto IL_0052;
					}
					this.CreationTime = input.ReadUInt64();
				}
				else
				{
					this.AttributesEpoch = input.ReadUInt64();
				}
				continue;
				IL_0052:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_00A9:
				this.role_.AddEntriesFrom(ref input, Friend._repeated_role_codec);
			}
		}

		// Token: 0x04002EF5 RID: 12021
		private static readonly MessageParser<Friend> _parser = new MessageParser<Friend>(() => new Friend());

		// Token: 0x04002EF6 RID: 12022
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EF7 RID: 12023
		private int _hasBits0;

		// Token: 0x04002EF8 RID: 12024
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04002EF9 RID: 12025
		private EntityId accountId_;

		// Token: 0x04002EFA RID: 12026
		public const int AttributeFieldNumber = 2;

		// Token: 0x04002EFB RID: 12027
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04002EFC RID: 12028
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04002EFD RID: 12029
		public const int RoleFieldNumber = 3;

		// Token: 0x04002EFE RID: 12030
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002EFF RID: 12031
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x04002F00 RID: 12032
		public const int PrivilegesFieldNumber = 4;

		// Token: 0x04002F01 RID: 12033
		private static readonly ulong PrivilegesDefaultValue = 0UL;

		// Token: 0x04002F02 RID: 12034
		private ulong privileges_;

		// Token: 0x04002F03 RID: 12035
		public const int AttributesEpochFieldNumber = 5;

		// Token: 0x04002F04 RID: 12036
		private static readonly ulong AttributesEpochDefaultValue = 0UL;

		// Token: 0x04002F05 RID: 12037
		private ulong attributesEpoch_;

		// Token: 0x04002F06 RID: 12038
		public const int CreationTimeFieldNumber = 6;

		// Token: 0x04002F07 RID: 12039
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04002F08 RID: 12040
		private ulong creationTime_;
	}
}
