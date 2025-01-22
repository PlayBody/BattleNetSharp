using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F0 RID: 1264
	public sealed class ClubRole : IMessage<ClubRole>, IMessage, IEquatable<ClubRole>, IDeepCloneable<ClubRole>, IBufferMessage
	{
		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x06007B91 RID: 31633 RVA: 0x001E1208 File Offset: 0x001DF408
		[DebuggerNonUserCode]
		public static MessageParser<ClubRole> Parser
		{
			get
			{
				return ClubRole._parser;
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x06007B92 RID: 31634 RVA: 0x001E1220 File Offset: 0x001DF420
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRoleReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x06007B93 RID: 31635 RVA: 0x001E1244 File Offset: 0x001DF444
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubRole.Descriptor;
			}
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x001E125B File Offset: 0x001DF45B
		[DebuggerNonUserCode]
		public ClubRole()
		{
		}

		// Token: 0x06007B95 RID: 31637 RVA: 0x001E1268 File Offset: 0x001DF468
		[DebuggerNonUserCode]
		public ClubRole(ClubRole other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this.privilege_ = ((other.privilege_ != null) ? other.privilege_.Clone() : null);
			this.alwaysGrantStreamAccess_ = other.alwaysGrantStreamAccess_;
			this.allowInClubSlot_ = other.allowInClubSlot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x001E12F8 File Offset: 0x001DF4F8
		[DebuggerNonUserCode]
		public ClubRole Clone()
		{
			return new ClubRole(this);
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x06007B97 RID: 31639 RVA: 0x001E1310 File Offset: 0x001DF510
		// (set) Token: 0x06007B98 RID: 31640 RVA: 0x001E1341 File Offset: 0x001DF541
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
					idDefaultValue = ClubRole.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x06007B99 RID: 31641 RVA: 0x001E135C File Offset: 0x001DF55C
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x001E1379 File Offset: 0x001DF579
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x06007B9B RID: 31643 RVA: 0x001E138C File Offset: 0x001DF58C
		// (set) Token: 0x06007B9C RID: 31644 RVA: 0x001E13A4 File Offset: 0x001DF5A4
		[DebuggerNonUserCode]
		public RoleState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x06007B9D RID: 31645 RVA: 0x001E13B0 File Offset: 0x001DF5B0
		// (set) Token: 0x06007B9E RID: 31646 RVA: 0x001E13C8 File Offset: 0x001DF5C8
		[DebuggerNonUserCode]
		public ClubPrivilegeSet Privilege
		{
			get
			{
				return this.privilege_;
			}
			set
			{
				this.privilege_ = value;
			}
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x06007B9F RID: 31647 RVA: 0x001E13D4 File Offset: 0x001DF5D4
		// (set) Token: 0x06007BA0 RID: 31648 RVA: 0x001E1405 File Offset: 0x001DF605
		[DebuggerNonUserCode]
		public bool AlwaysGrantStreamAccess
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool alwaysGrantStreamAccessDefaultValue;
				if (flag)
				{
					alwaysGrantStreamAccessDefaultValue = this.alwaysGrantStreamAccess_;
				}
				else
				{
					alwaysGrantStreamAccessDefaultValue = ClubRole.AlwaysGrantStreamAccessDefaultValue;
				}
				return alwaysGrantStreamAccessDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.alwaysGrantStreamAccess_ = value;
			}
		}

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x06007BA1 RID: 31649 RVA: 0x001E1420 File Offset: 0x001DF620
		[DebuggerNonUserCode]
		public bool HasAlwaysGrantStreamAccess
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x001E143D File Offset: 0x001DF63D
		[DebuggerNonUserCode]
		public void ClearAlwaysGrantStreamAccess()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x001E1450 File Offset: 0x001DF650
		// (set) Token: 0x06007BA4 RID: 31652 RVA: 0x001E1481 File Offset: 0x001DF681
		[DebuggerNonUserCode]
		public bool AllowInClubSlot
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool allowInClubSlotDefaultValue;
				if (flag)
				{
					allowInClubSlotDefaultValue = this.allowInClubSlot_;
				}
				else
				{
					allowInClubSlotDefaultValue = ClubRole.AllowInClubSlotDefaultValue;
				}
				return allowInClubSlotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.allowInClubSlot_ = value;
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x001E149C File Offset: 0x001DF69C
		[DebuggerNonUserCode]
		public bool HasAllowInClubSlot
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x001E14B9 File Offset: 0x001DF6B9
		[DebuggerNonUserCode]
		public void ClearAllowInClubSlot()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x001E14CC File Offset: 0x001DF6CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubRole);
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x001E14EC File Offset: 0x001DF6EC
		[DebuggerNonUserCode]
		public bool Equals(ClubRole other)
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
						bool flag5 = !object.Equals(this.State, other.State);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Privilege, other.Privilege);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AlwaysGrantStreamAccess != other.AlwaysGrantStreamAccess;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.AllowInClubSlot != other.AllowInClubSlot;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x001E15C0 File Offset: 0x001DF7C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this.privilege_ != null;
			if (flag2)
			{
				num ^= this.Privilege.GetHashCode();
			}
			bool hasAlwaysGrantStreamAccess = this.HasAlwaysGrantStreamAccess;
			if (hasAlwaysGrantStreamAccess)
			{
				num ^= this.AlwaysGrantStreamAccess.GetHashCode();
			}
			bool hasAllowInClubSlot = this.HasAllowInClubSlot;
			if (hasAllowInClubSlot)
			{
				num ^= this.AllowInClubSlot.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x001E1688 File Offset: 0x001DF888
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x001E16A0 File Offset: 0x001DF8A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x001E16AC File Offset: 0x001DF8AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.State);
			}
			bool flag2 = this.privilege_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Privilege);
			}
			bool hasAlwaysGrantStreamAccess = this.HasAlwaysGrantStreamAccess;
			if (hasAlwaysGrantStreamAccess)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.AlwaysGrantStreamAccess);
			}
			bool hasAllowInClubSlot = this.HasAllowInClubSlot;
			if (hasAllowInClubSlot)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.AllowInClubSlot);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x001E178C File Offset: 0x001DF98C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this.privilege_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Privilege);
			}
			bool hasAlwaysGrantStreamAccess = this.HasAlwaysGrantStreamAccess;
			if (hasAlwaysGrantStreamAccess)
			{
				num += 2;
			}
			bool hasAllowInClubSlot = this.HasAllowInClubSlot;
			if (hasAllowInClubSlot)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x001E1840 File Offset: 0x001DFA40
		[DebuggerNonUserCode]
		public void MergeFrom(ClubRole other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool flag2 = other.state_ != null;
				if (flag2)
				{
					bool flag3 = this.state_ == null;
					if (flag3)
					{
						this.State = new RoleState();
					}
					this.State.MergeFrom(other.State);
				}
				bool flag4 = other.privilege_ != null;
				if (flag4)
				{
					bool flag5 = this.privilege_ == null;
					if (flag5)
					{
						this.Privilege = new ClubPrivilegeSet();
					}
					this.Privilege.MergeFrom(other.Privilege);
				}
				bool hasAlwaysGrantStreamAccess = other.HasAlwaysGrantStreamAccess;
				if (hasAlwaysGrantStreamAccess)
				{
					this.AlwaysGrantStreamAccess = other.AlwaysGrantStreamAccess;
				}
				bool hasAllowInClubSlot = other.HasAllowInClubSlot;
				if (hasAllowInClubSlot)
				{
					this.AllowInClubSlot = other.AllowInClubSlot;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x001E193E File Offset: 0x001DFB3E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x001E194C File Offset: 0x001DFB4C
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
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0038;
						}
						bool flag = this.state_ == null;
						if (flag)
						{
							this.State = new RoleState();
						}
						input.ReadMessage(this.State);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0038;
						}
						this.AllowInClubSlot = input.ReadBool();
					}
					else
					{
						this.AlwaysGrantStreamAccess = input.ReadBool();
					}
				}
				else
				{
					bool flag2 = this.privilege_ == null;
					if (flag2)
					{
						this.Privilege = new ClubPrivilegeSet();
					}
					input.ReadMessage(this.Privilege);
				}
				continue;
				IL_0038:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400382E RID: 14382
		private static readonly MessageParser<ClubRole> _parser = new MessageParser<ClubRole>(() => new ClubRole());

		// Token: 0x0400382F RID: 14383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003830 RID: 14384
		private int _hasBits0;

		// Token: 0x04003831 RID: 14385
		public const int IdFieldNumber = 1;

		// Token: 0x04003832 RID: 14386
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04003833 RID: 14387
		private uint id_;

		// Token: 0x04003834 RID: 14388
		public const int StateFieldNumber = 2;

		// Token: 0x04003835 RID: 14389
		private RoleState state_;

		// Token: 0x04003836 RID: 14390
		public const int PrivilegeFieldNumber = 3;

		// Token: 0x04003837 RID: 14391
		private ClubPrivilegeSet privilege_;

		// Token: 0x04003838 RID: 14392
		public const int AlwaysGrantStreamAccessFieldNumber = 4;

		// Token: 0x04003839 RID: 14393
		private static readonly bool AlwaysGrantStreamAccessDefaultValue = false;

		// Token: 0x0400383A RID: 14394
		private bool alwaysGrantStreamAccess_;

		// Token: 0x0400383B RID: 14395
		public const int AllowInClubSlotFieldNumber = 5;

		// Token: 0x0400383C RID: 14396
		private static readonly bool AllowInClubSlotDefaultValue = false;

		// Token: 0x0400383D RID: 14397
		private bool allowInClubSlot_;
	}
}
