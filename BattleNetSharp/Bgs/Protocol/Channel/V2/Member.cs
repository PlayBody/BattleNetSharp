using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200068A RID: 1674
	public sealed class Member : IMessage<Member>, IMessage, IEquatable<Member>, IDeepCloneable<Member>, IBufferMessage
	{
		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x06009B33 RID: 39731 RVA: 0x0025B530 File Offset: 0x00259730
		[DebuggerNonUserCode]
		public static MessageParser<Member> Parser
		{
			get
			{
				return Member._parser;
			}
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x06009B34 RID: 39732 RVA: 0x0025B548 File Offset: 0x00259748
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17003040 RID: 12352
		// (get) Token: 0x06009B35 RID: 39733 RVA: 0x0025B56C File Offset: 0x0025976C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Member.Descriptor;
			}
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x0025B583 File Offset: 0x00259783
		[DebuggerNonUserCode]
		public Member()
		{
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x0025B5A4 File Offset: 0x002597A4
		[DebuggerNonUserCode]
		public Member(Member other)
			: this()
		{
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.battleTag_ = other.battleTag_;
			this.voiceId_ = other.voiceId_;
			this.role_ = other.role_.Clone();
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x0025B620 File Offset: 0x00259820
		[DebuggerNonUserCode]
		public Member Clone()
		{
			return new Member(this);
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06009B39 RID: 39737 RVA: 0x0025B638 File Offset: 0x00259838
		// (set) Token: 0x06009B3A RID: 39738 RVA: 0x0025B650 File Offset: 0x00259850
		[DebuggerNonUserCode]
		public GameAccountHandle Id
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

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06009B3B RID: 39739 RVA: 0x0025B65C File Offset: 0x0025985C
		// (set) Token: 0x06009B3C RID: 39740 RVA: 0x0025B67D File Offset: 0x0025987D
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? Member.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06009B3D RID: 39741 RVA: 0x0025B694 File Offset: 0x00259894
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06009B3E RID: 39742 RVA: 0x0025B6AF File Offset: 0x002598AF
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x06009B3F RID: 39743 RVA: 0x0025B6BC File Offset: 0x002598BC
		// (set) Token: 0x06009B40 RID: 39744 RVA: 0x0025B6DD File Offset: 0x002598DD
		[DebuggerNonUserCode]
		public string VoiceId
		{
			get
			{
				return this.voiceId_ ?? Member.VoiceIdDefaultValue;
			}
			set
			{
				this.voiceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x06009B41 RID: 39745 RVA: 0x0025B6F4 File Offset: 0x002598F4
		[DebuggerNonUserCode]
		public bool HasVoiceId
		{
			get
			{
				return this.voiceId_ != null;
			}
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x0025B70F File Offset: 0x0025990F
		[DebuggerNonUserCode]
		public void ClearVoiceId()
		{
			this.voiceId_ = null;
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x06009B43 RID: 39747 RVA: 0x0025B71C File Offset: 0x0025991C
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x06009B44 RID: 39748 RVA: 0x0025B734 File Offset: 0x00259934
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x0025B74C File Offset: 0x0025994C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Member);
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x0025B76C File Offset: 0x0025996C
		[DebuggerNonUserCode]
		public bool Equals(Member other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.VoiceId != other.VoiceId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.role_.Equals(other.role_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.attribute_.Equals(other.attribute_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x0025B840 File Offset: 0x00259A40
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
			bool hasVoiceId = this.HasVoiceId;
			if (hasVoiceId)
			{
				num ^= this.VoiceId.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x0025B8E0 File Offset: 0x00259AE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x0025B8F8 File Offset: 0x00259AF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x0025B904 File Offset: 0x00259B04
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
			bool hasVoiceId = this.HasVoiceId;
			if (hasVoiceId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.VoiceId);
			}
			this.role_.WriteTo(ref output, Member._repeated_role_codec);
			this.attribute_.WriteTo(ref output, Member._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x0025B9BC File Offset: 0x00259BBC
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
			bool hasVoiceId = this.HasVoiceId;
			if (hasVoiceId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VoiceId);
			}
			num += this.role_.CalculateSize(Member._repeated_role_codec);
			num += this.attribute_.CalculateSize(Member._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x0025BA70 File Offset: 0x00259C70
		[DebuggerNonUserCode]
		public void MergeFrom(Member other)
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
						this.Id = new GameAccountHandle();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				bool hasVoiceId = other.HasVoiceId;
				if (hasVoiceId)
				{
					this.VoiceId = other.VoiceId;
				}
				this.role_.Add(other.role_);
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x0025BB37 File Offset: 0x00259D37
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x0025BB44 File Offset: 0x00259D44
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
								goto IL_003A;
							}
							this.VoiceId = input.ReadString();
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
							this.Id = new GameAccountHandle();
						}
						input.ReadMessage(this.Id);
					}
				}
				else if (num3 != 32U && num3 != 34U)
				{
					if (num3 != 42U)
					{
						goto IL_003A;
					}
					this.attribute_.AddEntriesFrom(ref input, Member._repeated_attribute_codec);
				}
				else
				{
					this.role_.AddEntriesFrom(ref input, Member._repeated_role_codec);
				}
				continue;
				IL_003A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004600 RID: 17920
		private static readonly MessageParser<Member> _parser = new MessageParser<Member>(() => new Member());

		// Token: 0x04004601 RID: 17921
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004602 RID: 17922
		public const int IdFieldNumber = 1;

		// Token: 0x04004603 RID: 17923
		private GameAccountHandle id_;

		// Token: 0x04004604 RID: 17924
		public const int BattleTagFieldNumber = 2;

		// Token: 0x04004605 RID: 17925
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04004606 RID: 17926
		private string battleTag_;

		// Token: 0x04004607 RID: 17927
		public const int VoiceIdFieldNumber = 3;

		// Token: 0x04004608 RID: 17928
		private static readonly string VoiceIdDefaultValue = "";

		// Token: 0x04004609 RID: 17929
		private string voiceId_;

		// Token: 0x0400460A RID: 17930
		public const int RoleFieldNumber = 4;

		// Token: 0x0400460B RID: 17931
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x0400460C RID: 17932
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x0400460D RID: 17933
		public const int AttributeFieldNumber = 5;

		// Token: 0x0400460E RID: 17934
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(42U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400460F RID: 17935
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}
