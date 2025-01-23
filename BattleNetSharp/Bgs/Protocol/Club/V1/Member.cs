using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200045C RID: 1116
	public sealed class Member : IMessage<Member>, IMessage, IEquatable<Member>, IDeepCloneable<Member>, IBufferMessage
	{
		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06006D27 RID: 27943 RVA: 0x001A91C0 File Offset: 0x001A73C0
		[DebuggerNonUserCode]
		public static MessageParser<Member> Parser
		{
			get
			{
				return Member._parser;
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06006D28 RID: 27944 RVA: 0x001A91D8 File Offset: 0x001A73D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06006D29 RID: 27945 RVA: 0x001A91FC File Offset: 0x001A73FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Member.Descriptor;
			}
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x001A9213 File Offset: 0x001A7413
		[DebuggerNonUserCode]
		public Member()
		{
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x001A9234 File Offset: 0x001A7434
		[DebuggerNonUserCode]
		public Member(Member other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.battleTag_ = other.battleTag_;
			this.role_ = other.role_.Clone();
			this.attribute_ = other.attribute_.Clone();
			this.joinTime_ = other.joinTime_;
			this.presenceLevel_ = other.presenceLevel_;
			this.moderatorMute_ = other.moderatorMute_;
			this.whisperLevel_ = other.whisperLevel_;
			this.note_ = other.note_;
			this.active_ = other.active_;
			this.voice_ = ((other.voice_ != null) ? other.voice_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x001A9314 File Offset: 0x001A7514
		[DebuggerNonUserCode]
		public Member Clone()
		{
			return new Member(this);
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x06006D2D RID: 27949 RVA: 0x001A932C File Offset: 0x001A752C
		// (set) Token: 0x06006D2E RID: 27950 RVA: 0x001A9344 File Offset: 0x001A7544
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

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x06006D2F RID: 27951 RVA: 0x001A9350 File Offset: 0x001A7550
		// (set) Token: 0x06006D30 RID: 27952 RVA: 0x001A9371 File Offset: 0x001A7571
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

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x06006D31 RID: 27953 RVA: 0x001A9388 File Offset: 0x001A7588
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x001A93A3 File Offset: 0x001A75A3
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x001A93B0 File Offset: 0x001A75B0
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x06006D34 RID: 27956 RVA: 0x001A93C8 File Offset: 0x001A75C8
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x06006D35 RID: 27957 RVA: 0x001A93E0 File Offset: 0x001A75E0
		// (set) Token: 0x06006D36 RID: 27958 RVA: 0x001A9411 File Offset: 0x001A7611
		[DebuggerNonUserCode]
		public ulong JoinTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong joinTimeDefaultValue;
				if (flag)
				{
					joinTimeDefaultValue = this.joinTime_;
				}
				else
				{
					joinTimeDefaultValue = Member.JoinTimeDefaultValue;
				}
				return joinTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.joinTime_ = value;
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06006D37 RID: 27959 RVA: 0x001A942C File Offset: 0x001A762C
		[DebuggerNonUserCode]
		public bool HasJoinTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x001A9449 File Offset: 0x001A7649
		[DebuggerNonUserCode]
		public void ClearJoinTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x001A945C File Offset: 0x001A765C
		// (set) Token: 0x06006D3A RID: 27962 RVA: 0x001A948D File Offset: 0x001A768D
		[DebuggerNonUserCode]
		public PresenceLevel PresenceLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				PresenceLevel presenceLevelDefaultValue;
				if (flag)
				{
					presenceLevelDefaultValue = this.presenceLevel_;
				}
				else
				{
					presenceLevelDefaultValue = Member.PresenceLevelDefaultValue;
				}
				return presenceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.presenceLevel_ = value;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06006D3B RID: 27963 RVA: 0x001A94A8 File Offset: 0x001A76A8
		[DebuggerNonUserCode]
		public bool HasPresenceLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x001A94C5 File Offset: 0x001A76C5
		[DebuggerNonUserCode]
		public void ClearPresenceLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06006D3D RID: 27965 RVA: 0x001A94D8 File Offset: 0x001A76D8
		// (set) Token: 0x06006D3E RID: 27966 RVA: 0x001A9509 File Offset: 0x001A7709
		[DebuggerNonUserCode]
		public bool ModeratorMute
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool moderatorMuteDefaultValue;
				if (flag)
				{
					moderatorMuteDefaultValue = this.moderatorMute_;
				}
				else
				{
					moderatorMuteDefaultValue = Member.ModeratorMuteDefaultValue;
				}
				return moderatorMuteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.moderatorMute_ = value;
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x06006D3F RID: 27967 RVA: 0x001A9524 File Offset: 0x001A7724
		[DebuggerNonUserCode]
		public bool HasModeratorMute
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x001A9541 File Offset: 0x001A7741
		[DebuggerNonUserCode]
		public void ClearModeratorMute()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06006D41 RID: 27969 RVA: 0x001A9554 File Offset: 0x001A7754
		// (set) Token: 0x06006D42 RID: 27970 RVA: 0x001A9585 File Offset: 0x001A7785
		[DebuggerNonUserCode]
		public WhisperLevel WhisperLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				WhisperLevel whisperLevelDefaultValue;
				if (flag)
				{
					whisperLevelDefaultValue = this.whisperLevel_;
				}
				else
				{
					whisperLevelDefaultValue = Member.WhisperLevelDefaultValue;
				}
				return whisperLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.whisperLevel_ = value;
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x06006D43 RID: 27971 RVA: 0x001A95A0 File Offset: 0x001A77A0
		[DebuggerNonUserCode]
		public bool HasWhisperLevel
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x001A95BD File Offset: 0x001A77BD
		[DebuggerNonUserCode]
		public void ClearWhisperLevel()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06006D45 RID: 27973 RVA: 0x001A95D0 File Offset: 0x001A77D0
		// (set) Token: 0x06006D46 RID: 27974 RVA: 0x001A95F1 File Offset: 0x001A77F1
		[DebuggerNonUserCode]
		public string Note
		{
			get
			{
				return this.note_ ?? Member.NoteDefaultValue;
			}
			set
			{
				this.note_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x06006D47 RID: 27975 RVA: 0x001A9608 File Offset: 0x001A7808
		[DebuggerNonUserCode]
		public bool HasNote
		{
			get
			{
				return this.note_ != null;
			}
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x001A9623 File Offset: 0x001A7823
		[DebuggerNonUserCode]
		public void ClearNote()
		{
			this.note_ = null;
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x001A9630 File Offset: 0x001A7830
		// (set) Token: 0x06006D4A RID: 27978 RVA: 0x001A9662 File Offset: 0x001A7862
		[DebuggerNonUserCode]
		public bool Active
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool activeDefaultValue;
				if (flag)
				{
					activeDefaultValue = this.active_;
				}
				else
				{
					activeDefaultValue = Member.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.active_ = value;
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06006D4B RID: 27979 RVA: 0x001A967C File Offset: 0x001A787C
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x001A969A File Offset: 0x001A789A
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x06006D4D RID: 27981 RVA: 0x001A96AC File Offset: 0x001A78AC
		// (set) Token: 0x06006D4E RID: 27982 RVA: 0x001A96C4 File Offset: 0x001A78C4
		[DebuggerNonUserCode]
		public MemberVoiceState Voice
		{
			get
			{
				return this.voice_;
			}
			set
			{
				this.voice_ = value;
			}
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x001A96D0 File Offset: 0x001A78D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Member);
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x001A96F0 File Offset: 0x001A78F0
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
							bool flag6 = !this.role_.Equals(other.role_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.JoinTime != other.JoinTime;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.PresenceLevel != other.PresenceLevel;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.ModeratorMute != other.ModeratorMute;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.WhisperLevel != other.WhisperLevel;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.Note != other.Note;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Active != other.Active;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.Voice, other.Voice);
															flag2 = !flag14 && object.Equals(this._unknownFields, other._unknownFields);
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
			}
			return flag2;
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x001A987C File Offset: 0x001A7A7C
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
			num ^= this.role_.GetHashCode();
			num ^= this.attribute_.GetHashCode();
			bool hasJoinTime = this.HasJoinTime;
			if (hasJoinTime)
			{
				num ^= this.JoinTime.GetHashCode();
			}
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
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num ^= this.Active.GetHashCode();
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				num ^= this.Voice.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x001A99D8 File Offset: 0x001A7BD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x001A99F0 File Offset: 0x001A7BF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x001A99FC File Offset: 0x001A7BFC
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
			this.role_.WriteTo(ref output, Member._repeated_role_codec);
			this.attribute_.WriteTo(ref output, Member._repeated_attribute_codec);
			bool hasJoinTime = this.HasJoinTime;
			if (hasJoinTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.JoinTime);
			}
			bool hasPresenceLevel = this.HasPresenceLevel;
			if (hasPresenceLevel)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.PresenceLevel);
			}
			bool hasModeratorMute = this.HasModeratorMute;
			if (hasModeratorMute)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ModeratorMute);
			}
			bool hasWhisperLevel = this.HasWhisperLevel;
			if (hasWhisperLevel)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.WhisperLevel);
			}
			bool hasNote = this.HasNote;
			if (hasNote)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Note);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(144, 3);
				output.WriteBool(this.Active);
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				output.WriteRawTag(154, 3);
				output.WriteMessage(this.Voice);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x001A9B98 File Offset: 0x001A7D98
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
			num += this.role_.CalculateSize(Member._repeated_role_codec);
			num += this.attribute_.CalculateSize(Member._repeated_attribute_codec);
			bool hasJoinTime = this.HasJoinTime;
			if (hasJoinTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.JoinTime);
			}
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
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num += 3;
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Voice);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x001A9CEC File Offset: 0x001A7EEC
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
						this.Id = new MemberId();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				this.role_.Add(other.role_);
				this.attribute_.Add(other.attribute_);
				bool hasJoinTime = other.HasJoinTime;
				if (hasJoinTime)
				{
					this.JoinTime = other.JoinTime;
				}
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
				bool hasActive = other.HasActive;
				if (hasActive)
				{
					this.Active = other.Active;
				}
				bool flag4 = other.voice_ != null;
				if (flag4)
				{
					bool flag5 = this.voice_ == null;
					if (flag5)
					{
						this.Voice = new MemberVoiceState();
					}
					this.Voice.MergeFrom(other.Voice);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x001A9E7A File Offset: 0x001A807A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x001A9E88 File Offset: 0x001A8088
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
					if (num3 <= 24U)
					{
						if (num3 == 10U)
						{
							bool flag = this.id_ == null;
							if (flag)
							{
								this.Id = new MemberId();
							}
							input.ReadMessage(this.Id);
							continue;
						}
						if (num3 == 18U)
						{
							this.BattleTag = input.ReadString();
							continue;
						}
						if (num3 != 24U)
						{
							goto IL_0098;
						}
					}
					else if (num3 != 26U)
					{
						if (num3 == 34U)
						{
							this.attribute_.AddEntriesFrom(ref input, Member._repeated_attribute_codec);
							continue;
						}
						if (num3 != 40U)
						{
							goto IL_0098;
						}
						this.JoinTime = input.ReadUInt64();
						continue;
					}
					this.role_.AddEntriesFrom(ref input, Member._repeated_role_codec);
				}
				else if (num3 <= 64U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							if (num3 != 64U)
							{
								goto IL_0098;
							}
							this.WhisperLevel = (WhisperLevel)input.ReadEnum();
						}
						else
						{
							this.ModeratorMute = input.ReadBool();
						}
					}
					else
					{
						this.PresenceLevel = (PresenceLevel)input.ReadEnum();
					}
				}
				else if (num3 != 74U)
				{
					if (num3 != 400U)
					{
						if (num3 != 410U)
						{
							goto IL_0098;
						}
						bool flag2 = this.voice_ == null;
						if (flag2)
						{
							this.Voice = new MemberVoiceState();
						}
						input.ReadMessage(this.Voice);
					}
					else
					{
						this.Active = input.ReadBool();
					}
				}
				else
				{
					this.Note = input.ReadString();
				}
				continue;
				IL_0098:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003234 RID: 12852
		private static readonly MessageParser<Member> _parser = new MessageParser<Member>(() => new Member());

		// Token: 0x04003235 RID: 12853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003236 RID: 12854
		private int _hasBits0;

		// Token: 0x04003237 RID: 12855
		public const int IdFieldNumber = 1;

		// Token: 0x04003238 RID: 12856
		private MemberId id_;

		// Token: 0x04003239 RID: 12857
		public const int BattleTagFieldNumber = 2;

		// Token: 0x0400323A RID: 12858
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x0400323B RID: 12859
		private string battleTag_;

		// Token: 0x0400323C RID: 12860
		public const int RoleFieldNumber = 3;

		// Token: 0x0400323D RID: 12861
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x0400323E RID: 12862
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x0400323F RID: 12863
		public const int AttributeFieldNumber = 4;

		// Token: 0x04003240 RID: 12864
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(34U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003241 RID: 12865
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003242 RID: 12866
		public const int JoinTimeFieldNumber = 5;

		// Token: 0x04003243 RID: 12867
		private static readonly ulong JoinTimeDefaultValue = 0UL;

		// Token: 0x04003244 RID: 12868
		private ulong joinTime_;

		// Token: 0x04003245 RID: 12869
		public const int PresenceLevelFieldNumber = 6;

		// Token: 0x04003246 RID: 12870
		private static readonly PresenceLevel PresenceLevelDefaultValue = PresenceLevel.None;

		// Token: 0x04003247 RID: 12871
		private PresenceLevel presenceLevel_;

		// Token: 0x04003248 RID: 12872
		public const int ModeratorMuteFieldNumber = 7;

		// Token: 0x04003249 RID: 12873
		private static readonly bool ModeratorMuteDefaultValue = false;

		// Token: 0x0400324A RID: 12874
		private bool moderatorMute_;

		// Token: 0x0400324B RID: 12875
		public const int WhisperLevelFieldNumber = 8;

		// Token: 0x0400324C RID: 12876
		private static readonly WhisperLevel WhisperLevelDefaultValue = WhisperLevel.Open;

		// Token: 0x0400324D RID: 12877
		private WhisperLevel whisperLevel_;

		// Token: 0x0400324E RID: 12878
		public const int NoteFieldNumber = 9;

		// Token: 0x0400324F RID: 12879
		private static readonly string NoteDefaultValue = "";

		// Token: 0x04003250 RID: 12880
		private string note_;

		// Token: 0x04003251 RID: 12881
		public const int ActiveFieldNumber = 50;

		// Token: 0x04003252 RID: 12882
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x04003253 RID: 12883
		private bool active_;

		// Token: 0x04003254 RID: 12884
		public const int VoiceFieldNumber = 51;

		// Token: 0x04003255 RID: 12885
		private MemberVoiceState voice_;
	}
}
