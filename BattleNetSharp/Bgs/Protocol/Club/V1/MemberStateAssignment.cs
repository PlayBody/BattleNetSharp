using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200046A RID: 1130
	public sealed class MemberStateAssignment : IMessage<MemberStateAssignment>, IMessage, IEquatable<MemberStateAssignment>, IDeepCloneable<MemberStateAssignment>, IBufferMessage
	{
		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x001AE660 File Offset: 0x001AC860
		[DebuggerNonUserCode]
		public static MessageParser<MemberStateAssignment> Parser
		{
			get
			{
				return MemberStateAssignment._parser;
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x06006E9F RID: 28319 RVA: 0x001AE678 File Offset: 0x001AC878
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x001AE69C File Offset: 0x001AC89C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberStateAssignment.Descriptor;
			}
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x001AE6B3 File Offset: 0x001AC8B3
		[DebuggerNonUserCode]
		public MemberStateAssignment()
		{
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x001AE6C8 File Offset: 0x001AC8C8
		[DebuggerNonUserCode]
		public MemberStateAssignment(MemberStateAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.presenceLevel_ = other.presenceLevel_;
			this.moderatorMute_ = other.moderatorMute_;
			this.whisperLevel_ = other.whisperLevel_;
			this.note_ = other.note_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x001AE758 File Offset: 0x001AC958
		[DebuggerNonUserCode]
		public MemberStateAssignment Clone()
		{
			return new MemberStateAssignment(this);
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x001AE770 File Offset: 0x001AC970
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x001AE788 File Offset: 0x001AC988
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x001AE794 File Offset: 0x001AC994
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x06006EA7 RID: 28327 RVA: 0x001AE7AC File Offset: 0x001AC9AC
		// (set) Token: 0x06006EA8 RID: 28328 RVA: 0x001AE7DD File Offset: 0x001AC9DD
		[DebuggerNonUserCode]
		public PresenceLevel PresenceLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				PresenceLevel presenceLevelDefaultValue;
				if (flag)
				{
					presenceLevelDefaultValue = this.presenceLevel_;
				}
				else
				{
					presenceLevelDefaultValue = MemberStateAssignment.PresenceLevelDefaultValue;
				}
				return presenceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.presenceLevel_ = value;
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x06006EA9 RID: 28329 RVA: 0x001AE7F8 File Offset: 0x001AC9F8
		[DebuggerNonUserCode]
		public bool HasPresenceLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x001AE815 File Offset: 0x001ACA15
		[DebuggerNonUserCode]
		public void ClearPresenceLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x06006EAB RID: 28331 RVA: 0x001AE828 File Offset: 0x001ACA28
		// (set) Token: 0x06006EAC RID: 28332 RVA: 0x001AE859 File Offset: 0x001ACA59
		[DebuggerNonUserCode]
		public bool ModeratorMute
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool moderatorMuteDefaultValue;
				if (flag)
				{
					moderatorMuteDefaultValue = this.moderatorMute_;
				}
				else
				{
					moderatorMuteDefaultValue = MemberStateAssignment.ModeratorMuteDefaultValue;
				}
				return moderatorMuteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.moderatorMute_ = value;
			}
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x06006EAD RID: 28333 RVA: 0x001AE874 File Offset: 0x001ACA74
		[DebuggerNonUserCode]
		public bool HasModeratorMute
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x001AE891 File Offset: 0x001ACA91
		[DebuggerNonUserCode]
		public void ClearModeratorMute()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x06006EAF RID: 28335 RVA: 0x001AE8A4 File Offset: 0x001ACAA4
		// (set) Token: 0x06006EB0 RID: 28336 RVA: 0x001AE8D5 File Offset: 0x001ACAD5
		[DebuggerNonUserCode]
		public WhisperLevel WhisperLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				WhisperLevel whisperLevelDefaultValue;
				if (flag)
				{
					whisperLevelDefaultValue = this.whisperLevel_;
				}
				else
				{
					whisperLevelDefaultValue = MemberStateAssignment.WhisperLevelDefaultValue;
				}
				return whisperLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.whisperLevel_ = value;
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x06006EB1 RID: 28337 RVA: 0x001AE8F0 File Offset: 0x001ACAF0
		[DebuggerNonUserCode]
		public bool HasWhisperLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x001AE90D File Offset: 0x001ACB0D
		[DebuggerNonUserCode]
		public void ClearWhisperLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x06006EB3 RID: 28339 RVA: 0x001AE920 File Offset: 0x001ACB20
		// (set) Token: 0x06006EB4 RID: 28340 RVA: 0x001AE941 File Offset: 0x001ACB41
		[DebuggerNonUserCode]
		public string Note
		{
			get
			{
				return this.note_ ?? MemberStateAssignment.NoteDefaultValue;
			}
			set
			{
				this.note_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06006EB5 RID: 28341 RVA: 0x001AE958 File Offset: 0x001ACB58
		[DebuggerNonUserCode]
		public bool HasNote
		{
			get
			{
				return this.note_ != null;
			}
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x001AE973 File Offset: 0x001ACB73
		[DebuggerNonUserCode]
		public void ClearNote()
		{
			this.note_ = null;
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x001AE980 File Offset: 0x001ACB80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberStateAssignment);
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x001AE9A0 File Offset: 0x001ACBA0
		[DebuggerNonUserCode]
		public bool Equals(MemberStateAssignment other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
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
							bool flag6 = this.PresenceLevel != other.PresenceLevel;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ModeratorMute != other.ModeratorMute;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.WhisperLevel != other.WhisperLevel;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Note != other.Note;
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

		// Token: 0x06006EB9 RID: 28345 RVA: 0x001AEA90 File Offset: 0x001ACC90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasPresenceLevel = this.HasPresenceLevel;
			if (hasPresenceLevel)
			{
				num ^= this.PresenceLevel.GetHashCode();
			}
			bool hasModeratorMute = this.HasModeratorMute;
			if (hasModeratorMute)
			{
				num ^= this.ModeratorMute.GetHashCode();
			}
			bool hasWhisperLevel = this.HasWhisperLevel;
			if (hasWhisperLevel)
			{
				num ^= this.WhisperLevel.GetHashCode();
			}
			bool hasNote = this.HasNote;
			if (hasNote)
			{
				num ^= this.Note.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x001AEB6C File Offset: 0x001ACD6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x001AEB84 File Offset: 0x001ACD84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x001AEB90 File Offset: 0x001ACD90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.attribute_.WriteTo(ref output, MemberStateAssignment._repeated_attribute_codec);
			bool hasPresenceLevel = this.HasPresenceLevel;
			if (hasPresenceLevel)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.PresenceLevel);
			}
			bool hasModeratorMute = this.HasModeratorMute;
			if (hasModeratorMute)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ModeratorMute);
			}
			bool hasWhisperLevel = this.HasWhisperLevel;
			if (hasWhisperLevel)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.WhisperLevel);
			}
			bool hasNote = this.HasNote;
			if (hasNote)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Note);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x001AEC80 File Offset: 0x001ACE80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.attribute_.CalculateSize(MemberStateAssignment._repeated_attribute_codec);
			bool hasPresenceLevel = this.HasPresenceLevel;
			if (hasPresenceLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PresenceLevel);
			}
			bool hasModeratorMute = this.HasModeratorMute;
			if (hasModeratorMute)
			{
				num += 2;
			}
			bool hasWhisperLevel = this.HasWhisperLevel;
			if (hasWhisperLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.WhisperLevel);
			}
			bool hasNote = this.HasNote;
			if (hasNote)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Note);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x001AED50 File Offset: 0x001ACF50
		[DebuggerNonUserCode]
		public void MergeFrom(MemberStateAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this.attribute_.Add(other.attribute_);
				bool hasPresenceLevel = other.HasPresenceLevel;
				if (hasPresenceLevel)
				{
					this.PresenceLevel = other.PresenceLevel;
				}
				bool hasModeratorMute = other.HasModeratorMute;
				if (hasModeratorMute)
				{
					this.ModeratorMute = other.ModeratorMute;
				}
				bool hasWhisperLevel = other.HasWhisperLevel;
				if (hasWhisperLevel)
				{
					this.WhisperLevel = other.WhisperLevel;
				}
				bool hasNote = other.HasNote;
				if (hasNote)
				{
					this.Note = other.Note;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x001AEE3B File Offset: 0x001AD03B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x001AEE48 File Offset: 0x001AD048
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
								goto IL_0040;
							}
							this.PresenceLevel = (PresenceLevel)input.ReadEnum();
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, MemberStateAssignment._repeated_attribute_codec);
						}
					}
					else
					{
						bool flag = this.memberId_ == null;
						if (flag)
						{
							this.MemberId = new MemberId();
						}
						input.ReadMessage(this.MemberId);
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 50U)
						{
							goto IL_0040;
						}
						this.Note = input.ReadString();
					}
					else
					{
						this.WhisperLevel = (WhisperLevel)input.ReadEnum();
					}
				}
				else
				{
					this.ModeratorMute = input.ReadBool();
				}
				continue;
				IL_0040:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032D6 RID: 13014
		private static readonly MessageParser<MemberStateAssignment> _parser = new MessageParser<MemberStateAssignment>(() => new MemberStateAssignment());

		// Token: 0x040032D7 RID: 13015
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032D8 RID: 13016
		private int _hasBits0;

		// Token: 0x040032D9 RID: 13017
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040032DA RID: 13018
		private MemberId memberId_;

		// Token: 0x040032DB RID: 13019
		public const int AttributeFieldNumber = 2;

		// Token: 0x040032DC RID: 13020
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040032DD RID: 13021
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040032DE RID: 13022
		public const int PresenceLevelFieldNumber = 3;

		// Token: 0x040032DF RID: 13023
		private static readonly PresenceLevel PresenceLevelDefaultValue = PresenceLevel.None;

		// Token: 0x040032E0 RID: 13024
		private PresenceLevel presenceLevel_;

		// Token: 0x040032E1 RID: 13025
		public const int ModeratorMuteFieldNumber = 4;

		// Token: 0x040032E2 RID: 13026
		private static readonly bool ModeratorMuteDefaultValue = false;

		// Token: 0x040032E3 RID: 13027
		private bool moderatorMute_;

		// Token: 0x040032E4 RID: 13028
		public const int WhisperLevelFieldNumber = 5;

		// Token: 0x040032E5 RID: 13029
		private static readonly WhisperLevel WhisperLevelDefaultValue = WhisperLevel.Open;

		// Token: 0x040032E6 RID: 13030
		private WhisperLevel whisperLevel_;

		// Token: 0x040032E7 RID: 13031
		public const int NoteFieldNumber = 6;

		// Token: 0x040032E8 RID: 13032
		private static readonly string NoteDefaultValue = "";

		// Token: 0x040032E9 RID: 13033
		private string note_;
	}
}
