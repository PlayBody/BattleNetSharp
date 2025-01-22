using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000469 RID: 1129
	public sealed class MemberStateOptions : IMessage<MemberStateOptions>, IMessage, IEquatable<MemberStateOptions>, IDeepCloneable<MemberStateOptions>, IBufferMessage
	{
		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x001ADE6C File Offset: 0x001AC06C
		[DebuggerNonUserCode]
		public static MessageParser<MemberStateOptions> Parser
		{
			get
			{
				return MemberStateOptions._parser;
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x06006E7D RID: 28285 RVA: 0x001ADE84 File Offset: 0x001AC084
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x06006E7E RID: 28286 RVA: 0x001ADEA8 File Offset: 0x001AC0A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberStateOptions.Descriptor;
			}
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x001ADEBF File Offset: 0x001AC0BF
		[DebuggerNonUserCode]
		public MemberStateOptions()
		{
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x001ADED4 File Offset: 0x001AC0D4
		[DebuggerNonUserCode]
		public MemberStateOptions(MemberStateOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attribute_ = other.attribute_.Clone();
			this.presenceLevel_ = other.presenceLevel_;
			this.moderatorMute_ = other.moderatorMute_;
			this.whisperLevel_ = other.whisperLevel_;
			this.note_ = other.note_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x001ADF48 File Offset: 0x001AC148
		[DebuggerNonUserCode]
		public MemberStateOptions Clone()
		{
			return new MemberStateOptions(this);
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x06006E82 RID: 28290 RVA: 0x001ADF60 File Offset: 0x001AC160
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x06006E83 RID: 28291 RVA: 0x001ADF78 File Offset: 0x001AC178
		// (set) Token: 0x06006E84 RID: 28292 RVA: 0x001ADFA9 File Offset: 0x001AC1A9
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
					presenceLevelDefaultValue = MemberStateOptions.PresenceLevelDefaultValue;
				}
				return presenceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.presenceLevel_ = value;
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x06006E85 RID: 28293 RVA: 0x001ADFC4 File Offset: 0x001AC1C4
		[DebuggerNonUserCode]
		public bool HasPresenceLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x001ADFE1 File Offset: 0x001AC1E1
		[DebuggerNonUserCode]
		public void ClearPresenceLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x001ADFF4 File Offset: 0x001AC1F4
		// (set) Token: 0x06006E88 RID: 28296 RVA: 0x001AE025 File Offset: 0x001AC225
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
					moderatorMuteDefaultValue = MemberStateOptions.ModeratorMuteDefaultValue;
				}
				return moderatorMuteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.moderatorMute_ = value;
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x06006E89 RID: 28297 RVA: 0x001AE040 File Offset: 0x001AC240
		[DebuggerNonUserCode]
		public bool HasModeratorMute
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x001AE05D File Offset: 0x001AC25D
		[DebuggerNonUserCode]
		public void ClearModeratorMute()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x06006E8B RID: 28299 RVA: 0x001AE070 File Offset: 0x001AC270
		// (set) Token: 0x06006E8C RID: 28300 RVA: 0x001AE0A1 File Offset: 0x001AC2A1
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
					whisperLevelDefaultValue = MemberStateOptions.WhisperLevelDefaultValue;
				}
				return whisperLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.whisperLevel_ = value;
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x001AE0BC File Offset: 0x001AC2BC
		[DebuggerNonUserCode]
		public bool HasWhisperLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006E8E RID: 28302 RVA: 0x001AE0D9 File Offset: 0x001AC2D9
		[DebuggerNonUserCode]
		public void ClearWhisperLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x06006E8F RID: 28303 RVA: 0x001AE0EC File Offset: 0x001AC2EC
		// (set) Token: 0x06006E90 RID: 28304 RVA: 0x001AE10D File Offset: 0x001AC30D
		[DebuggerNonUserCode]
		public string Note
		{
			get
			{
				return this.note_ ?? MemberStateOptions.NoteDefaultValue;
			}
			set
			{
				this.note_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x06006E91 RID: 28305 RVA: 0x001AE124 File Offset: 0x001AC324
		[DebuggerNonUserCode]
		public bool HasNote
		{
			get
			{
				return this.note_ != null;
			}
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x001AE13F File Offset: 0x001AC33F
		[DebuggerNonUserCode]
		public void ClearNote()
		{
			this.note_ = null;
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x001AE14C File Offset: 0x001AC34C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberStateOptions);
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x001AE16C File Offset: 0x001AC36C
		[DebuggerNonUserCode]
		public bool Equals(MemberStateOptions other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PresenceLevel != other.PresenceLevel;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ModeratorMute != other.ModeratorMute;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.WhisperLevel != other.WhisperLevel;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Note != other.Note;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x001AE23C File Offset: 0x001AC43C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x001AE2FC File Offset: 0x001AC4FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x001AE314 File Offset: 0x001AC514
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x001AE320 File Offset: 0x001AC520
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, MemberStateOptions._repeated_attribute_codec);
			bool hasPresenceLevel = this.HasPresenceLevel;
			if (hasPresenceLevel)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.PresenceLevel);
			}
			bool hasModeratorMute = this.HasModeratorMute;
			if (hasModeratorMute)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ModeratorMute);
			}
			bool hasWhisperLevel = this.HasWhisperLevel;
			if (hasWhisperLevel)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.WhisperLevel);
			}
			bool hasNote = this.HasNote;
			if (hasNote)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Note);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x001AE3E8 File Offset: 0x001AC5E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(MemberStateOptions._repeated_attribute_codec);
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x001AE498 File Offset: 0x001AC698
		[DebuggerNonUserCode]
		public void MergeFrom(MemberStateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
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

		// Token: 0x06006E9B RID: 28315 RVA: 0x001AE543 File Offset: 0x001AC743
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x001AE550 File Offset: 0x001AC750
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.PresenceLevel = (PresenceLevel)input.ReadEnum();
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, MemberStateOptions._repeated_attribute_codec);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0033;
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
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032C4 RID: 12996
		private static readonly MessageParser<MemberStateOptions> _parser = new MessageParser<MemberStateOptions>(() => new MemberStateOptions());

		// Token: 0x040032C5 RID: 12997
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032C6 RID: 12998
		private int _hasBits0;

		// Token: 0x040032C7 RID: 12999
		public const int AttributeFieldNumber = 1;

		// Token: 0x040032C8 RID: 13000
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040032C9 RID: 13001
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040032CA RID: 13002
		public const int PresenceLevelFieldNumber = 2;

		// Token: 0x040032CB RID: 13003
		private static readonly PresenceLevel PresenceLevelDefaultValue = PresenceLevel.None;

		// Token: 0x040032CC RID: 13004
		private PresenceLevel presenceLevel_;

		// Token: 0x040032CD RID: 13005
		public const int ModeratorMuteFieldNumber = 3;

		// Token: 0x040032CE RID: 13006
		private static readonly bool ModeratorMuteDefaultValue = false;

		// Token: 0x040032CF RID: 13007
		private bool moderatorMute_;

		// Token: 0x040032D0 RID: 13008
		public const int WhisperLevelFieldNumber = 4;

		// Token: 0x040032D1 RID: 13009
		private static readonly WhisperLevel WhisperLevelDefaultValue = WhisperLevel.Open;

		// Token: 0x040032D2 RID: 13010
		private WhisperLevel whisperLevel_;

		// Token: 0x040032D3 RID: 13011
		public const int NoteFieldNumber = 5;

		// Token: 0x040032D4 RID: 13012
		private static readonly string NoteDefaultValue = "";

		// Token: 0x040032D5 RID: 13013
		private string note_;
	}
}
