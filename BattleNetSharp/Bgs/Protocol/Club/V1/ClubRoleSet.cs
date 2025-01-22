using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F1 RID: 1265
	public sealed class ClubRoleSet : IMessage<ClubRoleSet>, IMessage, IEquatable<ClubRoleSet>, IDeepCloneable<ClubRoleSet>, IBufferMessage
	{
		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x06007BB2 RID: 31666 RVA: 0x001E1A74 File Offset: 0x001DFC74
		[DebuggerNonUserCode]
		public static MessageParser<ClubRoleSet> Parser
		{
			get
			{
				return ClubRoleSet._parser;
			}
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x001E1A8C File Offset: 0x001DFC8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRoleReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x06007BB4 RID: 31668 RVA: 0x001E1AB0 File Offset: 0x001DFCB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubRoleSet.Descriptor;
			}
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x001E1AC7 File Offset: 0x001DFCC7
		[DebuggerNonUserCode]
		public ClubRoleSet()
		{
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x001E1AE8 File Offset: 0x001DFCE8
		[DebuggerNonUserCode]
		public ClubRoleSet(ClubRoleSet other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.role_ = other.role_.Clone();
			this.defaultRole_ = other.defaultRole_.Clone();
			this.assignmentRespectsRelegationChain_ = other.assignmentRespectsRelegationChain_;
			this.subtype_ = other.subtype_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x001E1B54 File Offset: 0x001DFD54
		[DebuggerNonUserCode]
		public ClubRoleSet Clone()
		{
			return new ClubRoleSet(this);
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x001E1B6C File Offset: 0x001DFD6C
		[DebuggerNonUserCode]
		public RepeatedField<ClubRole> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x001E1B84 File Offset: 0x001DFD84
		[DebuggerNonUserCode]
		public RepeatedField<uint> DefaultRole
		{
			get
			{
				return this.defaultRole_;
			}
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x06007BBA RID: 31674 RVA: 0x001E1B9C File Offset: 0x001DFD9C
		// (set) Token: 0x06007BBB RID: 31675 RVA: 0x001E1BCD File Offset: 0x001DFDCD
		[DebuggerNonUserCode]
		public bool AssignmentRespectsRelegationChain
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool assignmentRespectsRelegationChainDefaultValue;
				if (flag)
				{
					assignmentRespectsRelegationChainDefaultValue = this.assignmentRespectsRelegationChain_;
				}
				else
				{
					assignmentRespectsRelegationChainDefaultValue = ClubRoleSet.AssignmentRespectsRelegationChainDefaultValue;
				}
				return assignmentRespectsRelegationChainDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.assignmentRespectsRelegationChain_ = value;
			}
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x06007BBC RID: 31676 RVA: 0x001E1BE8 File Offset: 0x001DFDE8
		[DebuggerNonUserCode]
		public bool HasAssignmentRespectsRelegationChain
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x001E1C05 File Offset: 0x001DFE05
		[DebuggerNonUserCode]
		public void ClearAssignmentRespectsRelegationChain()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x06007BBE RID: 31678 RVA: 0x001E1C18 File Offset: 0x001DFE18
		// (set) Token: 0x06007BBF RID: 31679 RVA: 0x001E1C39 File Offset: 0x001DFE39
		[DebuggerNonUserCode]
		public string Subtype
		{
			get
			{
				return this.subtype_ ?? ClubRoleSet.SubtypeDefaultValue;
			}
			set
			{
				this.subtype_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x001E1C50 File Offset: 0x001DFE50
		[DebuggerNonUserCode]
		public bool HasSubtype
		{
			get
			{
				return this.subtype_ != null;
			}
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x001E1C6B File Offset: 0x001DFE6B
		[DebuggerNonUserCode]
		public void ClearSubtype()
		{
			this.subtype_ = null;
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x001E1C78 File Offset: 0x001DFE78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubRoleSet);
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x001E1C98 File Offset: 0x001DFE98
		[DebuggerNonUserCode]
		public bool Equals(ClubRoleSet other)
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
					bool flag4 = !this.role_.Equals(other.role_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.defaultRole_.Equals(other.defaultRole_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AssignmentRespectsRelegationChain != other.AssignmentRespectsRelegationChain;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Subtype != other.Subtype;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x001E1D4C File Offset: 0x001DFF4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.role_.GetHashCode();
			num ^= this.defaultRole_.GetHashCode();
			bool hasAssignmentRespectsRelegationChain = this.HasAssignmentRespectsRelegationChain;
			if (hasAssignmentRespectsRelegationChain)
			{
				num ^= this.AssignmentRespectsRelegationChain.GetHashCode();
			}
			bool hasSubtype = this.HasSubtype;
			if (hasSubtype)
			{
				num ^= this.Subtype.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x001E1DD4 File Offset: 0x001DFFD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x001E1DEC File Offset: 0x001DFFEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x001E1DF8 File Offset: 0x001DFFF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.role_.WriteTo(ref output, ClubRoleSet._repeated_role_codec);
			this.defaultRole_.WriteTo(ref output, ClubRoleSet._repeated_defaultRole_codec);
			bool hasAssignmentRespectsRelegationChain = this.HasAssignmentRespectsRelegationChain;
			if (hasAssignmentRespectsRelegationChain)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.AssignmentRespectsRelegationChain);
			}
			bool hasSubtype = this.HasSubtype;
			if (hasSubtype)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Subtype);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x001E1E8C File Offset: 0x001E008C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.role_.CalculateSize(ClubRoleSet._repeated_role_codec);
			num += this.defaultRole_.CalculateSize(ClubRoleSet._repeated_defaultRole_codec);
			bool hasAssignmentRespectsRelegationChain = this.HasAssignmentRespectsRelegationChain;
			if (hasAssignmentRespectsRelegationChain)
			{
				num += 2;
			}
			bool hasSubtype = this.HasSubtype;
			if (hasSubtype)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Subtype);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x001E1F14 File Offset: 0x001E0114
		[DebuggerNonUserCode]
		public void MergeFrom(ClubRoleSet other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.role_.Add(other.role_);
				this.defaultRole_.Add(other.defaultRole_);
				bool hasAssignmentRespectsRelegationChain = other.HasAssignmentRespectsRelegationChain;
				if (hasAssignmentRespectsRelegationChain)
				{
					this.AssignmentRespectsRelegationChain = other.AssignmentRespectsRelegationChain;
				}
				bool hasSubtype = other.HasSubtype;
				if (hasSubtype)
				{
					this.Subtype = other.Subtype;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x001E1F9A File Offset: 0x001E019A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x001E1FA8 File Offset: 0x001E01A8
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
					if (num3 != 10U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						goto IL_005C;
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, ClubRoleSet._repeated_role_codec);
					}
				}
				else
				{
					if (num3 == 42U)
					{
						goto IL_005C;
					}
					if (num3 != 48U)
					{
						if (num3 != 58U)
						{
							goto IL_0033;
						}
						this.Subtype = input.ReadString();
					}
					else
					{
						this.AssignmentRespectsRelegationChain = input.ReadBool();
					}
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_005C:
				this.defaultRole_.AddEntriesFrom(ref input, ClubRoleSet._repeated_defaultRole_codec);
			}
		}

		// Token: 0x0400383E RID: 14398
		private static readonly MessageParser<ClubRoleSet> _parser = new MessageParser<ClubRoleSet>(() => new ClubRoleSet());

		// Token: 0x0400383F RID: 14399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003840 RID: 14400
		private int _hasBits0;

		// Token: 0x04003841 RID: 14401
		public const int RoleFieldNumber = 1;

		// Token: 0x04003842 RID: 14402
		private static readonly FieldCodec<ClubRole> _repeated_role_codec = FieldCodec.ForMessage<ClubRole>(10U, ClubRole.Parser);

		// Token: 0x04003843 RID: 14403
		private readonly RepeatedField<ClubRole> role_ = new RepeatedField<ClubRole>();

		// Token: 0x04003844 RID: 14404
		public const int DefaultRoleFieldNumber = 5;

		// Token: 0x04003845 RID: 14405
		private static readonly FieldCodec<uint> _repeated_defaultRole_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04003846 RID: 14406
		private readonly RepeatedField<uint> defaultRole_ = new RepeatedField<uint>();

		// Token: 0x04003847 RID: 14407
		public const int AssignmentRespectsRelegationChainFieldNumber = 6;

		// Token: 0x04003848 RID: 14408
		private static readonly bool AssignmentRespectsRelegationChainDefaultValue = false;

		// Token: 0x04003849 RID: 14409
		private bool assignmentRespectsRelegationChain_;

		// Token: 0x0400384A RID: 14410
		public const int SubtypeFieldNumber = 7;

		// Token: 0x0400384B RID: 14411
		private static readonly string SubtypeDefaultValue = "";

		// Token: 0x0400384C RID: 14412
		private string subtype_;
	}
}
