using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F8 RID: 1272
	public sealed class MentionContent : IMessage<MentionContent>, IMessage, IEquatable<MentionContent>, IDeepCloneable<MentionContent>, IBufferMessage
	{
		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x06007C58 RID: 31832 RVA: 0x001E4634 File Offset: 0x001E2834
		[DebuggerNonUserCode]
		public static MessageParser<MentionContent> Parser
		{
			get
			{
				return MentionContent._parser;
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06007C59 RID: 31833 RVA: 0x001E464C File Offset: 0x001E284C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06007C5A RID: 31834 RVA: 0x001E4670 File Offset: 0x001E2870
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MentionContent.Descriptor;
			}
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x001E4687 File Offset: 0x001E2887
		[DebuggerNonUserCode]
		public MentionContent()
		{
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x001E46A8 File Offset: 0x001E28A8
		[DebuggerNonUserCode]
		public MentionContent(MentionContent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.all_ = other.all_;
			this.here_ = other.here_;
			this.memberId_ = other.memberId_.Clone();
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x001E4714 File Offset: 0x001E2914
		[DebuggerNonUserCode]
		public MentionContent Clone()
		{
			return new MentionContent(this);
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06007C5E RID: 31838 RVA: 0x001E472C File Offset: 0x001E292C
		// (set) Token: 0x06007C5F RID: 31839 RVA: 0x001E475D File Offset: 0x001E295D
		[DebuggerNonUserCode]
		public bool All
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool allDefaultValue;
				if (flag)
				{
					allDefaultValue = this.all_;
				}
				else
				{
					allDefaultValue = MentionContent.AllDefaultValue;
				}
				return allDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.all_ = value;
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x06007C60 RID: 31840 RVA: 0x001E4778 File Offset: 0x001E2978
		[DebuggerNonUserCode]
		public bool HasAll
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x001E4795 File Offset: 0x001E2995
		[DebuggerNonUserCode]
		public void ClearAll()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06007C62 RID: 31842 RVA: 0x001E47A8 File Offset: 0x001E29A8
		// (set) Token: 0x06007C63 RID: 31843 RVA: 0x001E47D9 File Offset: 0x001E29D9
		[DebuggerNonUserCode]
		public bool Here
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool hereDefaultValue;
				if (flag)
				{
					hereDefaultValue = this.here_;
				}
				else
				{
					hereDefaultValue = MentionContent.HereDefaultValue;
				}
				return hereDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.here_ = value;
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x06007C64 RID: 31844 RVA: 0x001E47F4 File Offset: 0x001E29F4
		[DebuggerNonUserCode]
		public bool HasHere
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x001E4811 File Offset: 0x001E2A11
		[DebuggerNonUserCode]
		public void ClearHere()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x06007C66 RID: 31846 RVA: 0x001E4824 File Offset: 0x001E2A24
		[DebuggerNonUserCode]
		public RepeatedField<MemberId> MemberId
		{
			get
			{
				return this.memberId_;
			}
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x06007C67 RID: 31847 RVA: 0x001E483C File Offset: 0x001E2A3C
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x001E4854 File Offset: 0x001E2A54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MentionContent);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x001E4874 File Offset: 0x001E2A74
		[DebuggerNonUserCode]
		public bool Equals(MentionContent other)
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
					bool flag4 = this.All != other.All;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Here != other.Here;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.memberId_.Equals(other.memberId_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.role_.Equals(other.role_);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x001E4928 File Offset: 0x001E2B28
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAll = this.HasAll;
			if (hasAll)
			{
				num ^= this.All.GetHashCode();
			}
			bool hasHere = this.HasHere;
			if (hasHere)
			{
				num ^= this.Here.GetHashCode();
			}
			num ^= this.memberId_.GetHashCode();
			num ^= this.role_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x001E49B0 File Offset: 0x001E2BB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x001E49C8 File Offset: 0x001E2BC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x001E49D4 File Offset: 0x001E2BD4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAll = this.HasAll;
			if (hasAll)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.All);
			}
			bool hasHere = this.HasHere;
			if (hasHere)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Here);
			}
			this.memberId_.WriteTo(ref output, MentionContent._repeated_memberId_codec);
			this.role_.WriteTo(ref output, MentionContent._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x001E4A68 File Offset: 0x001E2C68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAll = this.HasAll;
			if (hasAll)
			{
				num += 2;
			}
			bool hasHere = this.HasHere;
			if (hasHere)
			{
				num += 2;
			}
			num += this.memberId_.CalculateSize(MentionContent._repeated_memberId_codec);
			num += this.role_.CalculateSize(MentionContent._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x001E4AE4 File Offset: 0x001E2CE4
		[DebuggerNonUserCode]
		public void MergeFrom(MentionContent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAll = other.HasAll;
				if (hasAll)
				{
					this.All = other.All;
				}
				bool hasHere = other.HasHere;
				if (hasHere)
				{
					this.Here = other.Here;
				}
				this.memberId_.Add(other.memberId_);
				this.role_.Add(other.role_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x001E4B6A File Offset: 0x001E2D6A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x001E4B78 File Offset: 0x001E2D78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0032;
						}
						this.Here = input.ReadBool();
					}
					else
					{
						this.All = input.ReadBool();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U && num3 != 34U)
					{
						goto IL_0032;
					}
					this.role_.AddEntriesFrom(ref input, MentionContent._repeated_role_codec);
				}
				else
				{
					this.memberId_.AddEntriesFrom(ref input, MentionContent._repeated_memberId_codec);
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400388C RID: 14476
		private static readonly MessageParser<MentionContent> _parser = new MessageParser<MentionContent>(() => new MentionContent());

		// Token: 0x0400388D RID: 14477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400388E RID: 14478
		private int _hasBits0;

		// Token: 0x0400388F RID: 14479
		public const int AllFieldNumber = 1;

		// Token: 0x04003890 RID: 14480
		private static readonly bool AllDefaultValue = false;

		// Token: 0x04003891 RID: 14481
		private bool all_;

		// Token: 0x04003892 RID: 14482
		public const int HereFieldNumber = 2;

		// Token: 0x04003893 RID: 14483
		private static readonly bool HereDefaultValue = false;

		// Token: 0x04003894 RID: 14484
		private bool here_;

		// Token: 0x04003895 RID: 14485
		public const int MemberIdFieldNumber = 3;

		// Token: 0x04003896 RID: 14486
		private static readonly FieldCodec<MemberId> _repeated_memberId_codec = FieldCodec.ForMessage<MemberId>(26U, Bgs.Protocol.Club.V1.MemberId.Parser);

		// Token: 0x04003897 RID: 14487
		private readonly RepeatedField<MemberId> memberId_ = new RepeatedField<MemberId>();

		// Token: 0x04003898 RID: 14488
		public const int RoleFieldNumber = 4;

		// Token: 0x04003899 RID: 14489
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400389A RID: 14490
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();
	}
}
