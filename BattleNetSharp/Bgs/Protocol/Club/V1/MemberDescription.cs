using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000463 RID: 1123
	public sealed class MemberDescription : IMessage<MemberDescription>, IMessage, IEquatable<MemberDescription>, IDeepCloneable<MemberDescription>, IBufferMessage
	{
		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06006DFD RID: 28157 RVA: 0x001AC3F4 File Offset: 0x001AA5F4
		[DebuggerNonUserCode]
		public static MessageParser<MemberDescription> Parser
		{
			get
			{
				return MemberDescription._parser;
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06006DFE RID: 28158 RVA: 0x001AC40C File Offset: 0x001AA60C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x001AC430 File Offset: 0x001AA630
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberDescription.Descriptor;
			}
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x001AC447 File Offset: 0x001AA647
		[DebuggerNonUserCode]
		public MemberDescription()
		{
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x001AC454 File Offset: 0x001AA654
		[DebuggerNonUserCode]
		public MemberDescription(MemberDescription other)
			: this()
		{
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.battleTag_ = other.battleTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x001AC4A4 File Offset: 0x001AA6A4
		[DebuggerNonUserCode]
		public MemberDescription Clone()
		{
			return new MemberDescription(this);
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06006E03 RID: 28163 RVA: 0x001AC4BC File Offset: 0x001AA6BC
		// (set) Token: 0x06006E04 RID: 28164 RVA: 0x001AC4D4 File Offset: 0x001AA6D4
		[DebuggerNonUserCode]
		public MemberId Id
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

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06006E05 RID: 28165 RVA: 0x001AC4E0 File Offset: 0x001AA6E0
		// (set) Token: 0x06006E06 RID: 28166 RVA: 0x001AC501 File Offset: 0x001AA701
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? MemberDescription.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x001AC518 File Offset: 0x001AA718
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x001AC533 File Offset: 0x001AA733
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x001AC540 File Offset: 0x001AA740
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberDescription);
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x001AC560 File Offset: 0x001AA760
		[DebuggerNonUserCode]
		public bool Equals(MemberDescription other)
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
						bool flag5 = this.BattleTag != other.BattleTag;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x001AC5D4 File Offset: 0x001AA7D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x001AC63C File Offset: 0x001AA83C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x001AC654 File Offset: 0x001AA854
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x001AC660 File Offset: 0x001AA860
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x001AC6D4 File Offset: 0x001AA8D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x001AC744 File Offset: 0x001AA944
		[DebuggerNonUserCode]
		public void MergeFrom(MemberDescription other)
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
						this.Id = new MemberId();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x001AC7C9 File Offset: 0x001AA9C9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x001AC7D4 File Offset: 0x001AA9D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BattleTag = input.ReadString();
					}
				}
				else
				{
					bool flag = this.id_ == null;
					if (flag)
					{
						this.Id = new MemberId();
					}
					input.ReadMessage(this.Id);
				}
			}
		}

		// Token: 0x0400329A RID: 12954
		private static readonly MessageParser<MemberDescription> _parser = new MessageParser<MemberDescription>(() => new MemberDescription());

		// Token: 0x0400329B RID: 12955
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400329C RID: 12956
		public const int IdFieldNumber = 1;

		// Token: 0x0400329D RID: 12957
		private MemberId id_;

		// Token: 0x0400329E RID: 12958
		public const int BattleTagFieldNumber = 2;

		// Token: 0x0400329F RID: 12959
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x040032A0 RID: 12960
		private string battleTag_;
	}
}
