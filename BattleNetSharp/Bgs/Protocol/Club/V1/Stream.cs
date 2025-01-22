using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F6 RID: 1270
	public sealed class Stream : IMessage<Stream>, IMessage, IEquatable<Stream>, IDeepCloneable<Stream>, IBufferMessage
	{
		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x06007C13 RID: 31763 RVA: 0x001E35F0 File Offset: 0x001E17F0
		[DebuggerNonUserCode]
		public static MessageParser<Stream> Parser
		{
			get
			{
				return Stream._parser;
			}
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x06007C14 RID: 31764 RVA: 0x001E3608 File Offset: 0x001E1808
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x06007C15 RID: 31765 RVA: 0x001E362C File Offset: 0x001E182C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Stream.Descriptor;
			}
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x001E3643 File Offset: 0x001E1843
		[DebuggerNonUserCode]
		public Stream()
		{
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x001E3658 File Offset: 0x001E1858
		[DebuggerNonUserCode]
		public Stream(Stream other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.id_ = other.id_;
			this.attribute_ = other.attribute_.Clone();
			this.name_ = other.name_;
			this.subject_ = other.subject_;
			this.access_ = ((other.access_ != null) ? other.access_.Clone() : null);
			this.voiceLevel_ = other.voiceLevel_;
			this.creationTime_ = other.creationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x001E3700 File Offset: 0x001E1900
		[DebuggerNonUserCode]
		public Stream Clone()
		{
			return new Stream(this);
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x06007C19 RID: 31769 RVA: 0x001E3718 File Offset: 0x001E1918
		// (set) Token: 0x06007C1A RID: 31770 RVA: 0x001E3749 File Offset: 0x001E1949
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = Stream.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x06007C1B RID: 31771 RVA: 0x001E3764 File Offset: 0x001E1964
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x001E3781 File Offset: 0x001E1981
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x06007C1D RID: 31773 RVA: 0x001E3794 File Offset: 0x001E1994
		// (set) Token: 0x06007C1E RID: 31774 RVA: 0x001E37C5 File Offset: 0x001E19C5
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Stream.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.id_ = value;
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06007C1F RID: 31775 RVA: 0x001E37E0 File Offset: 0x001E19E0
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007C20 RID: 31776 RVA: 0x001E37FD File Offset: 0x001E19FD
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x06007C21 RID: 31777 RVA: 0x001E3810 File Offset: 0x001E1A10
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x06007C22 RID: 31778 RVA: 0x001E3828 File Offset: 0x001E1A28
		// (set) Token: 0x06007C23 RID: 31779 RVA: 0x001E3849 File Offset: 0x001E1A49
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Stream.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x06007C24 RID: 31780 RVA: 0x001E3860 File Offset: 0x001E1A60
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x001E387B File Offset: 0x001E1A7B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x06007C26 RID: 31782 RVA: 0x001E3888 File Offset: 0x001E1A88
		// (set) Token: 0x06007C27 RID: 31783 RVA: 0x001E38A9 File Offset: 0x001E1AA9
		[DebuggerNonUserCode]
		public string Subject
		{
			get
			{
				return this.subject_ ?? Stream.SubjectDefaultValue;
			}
			set
			{
				this.subject_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x06007C28 RID: 31784 RVA: 0x001E38C0 File Offset: 0x001E1AC0
		[DebuggerNonUserCode]
		public bool HasSubject
		{
			get
			{
				return this.subject_ != null;
			}
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x001E38DB File Offset: 0x001E1ADB
		[DebuggerNonUserCode]
		public void ClearSubject()
		{
			this.subject_ = null;
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06007C2A RID: 31786 RVA: 0x001E38E8 File Offset: 0x001E1AE8
		// (set) Token: 0x06007C2B RID: 31787 RVA: 0x001E3900 File Offset: 0x001E1B00
		[DebuggerNonUserCode]
		public StreamAccess Access
		{
			get
			{
				return this.access_;
			}
			set
			{
				this.access_ = value;
			}
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x06007C2C RID: 31788 RVA: 0x001E390C File Offset: 0x001E1B0C
		// (set) Token: 0x06007C2D RID: 31789 RVA: 0x001E393D File Offset: 0x001E1B3D
		[DebuggerNonUserCode]
		public StreamVoiceLevel VoiceLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				StreamVoiceLevel voiceLevelDefaultValue;
				if (flag)
				{
					voiceLevelDefaultValue = this.voiceLevel_;
				}
				else
				{
					voiceLevelDefaultValue = Stream.VoiceLevelDefaultValue;
				}
				return voiceLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.voiceLevel_ = value;
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x06007C2E RID: 31790 RVA: 0x001E3958 File Offset: 0x001E1B58
		[DebuggerNonUserCode]
		public bool HasVoiceLevel
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x001E3975 File Offset: 0x001E1B75
		[DebuggerNonUserCode]
		public void ClearVoiceLevel()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x06007C30 RID: 31792 RVA: 0x001E3988 File Offset: 0x001E1B88
		// (set) Token: 0x06007C31 RID: 31793 RVA: 0x001E39B9 File Offset: 0x001E1BB9
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = Stream.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x06007C32 RID: 31794 RVA: 0x001E39D4 File Offset: 0x001E1BD4
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x001E39F1 File Offset: 0x001E1BF1
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x001E3A04 File Offset: 0x001E1C04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Stream);
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x001E3A24 File Offset: 0x001E1C24
		[DebuggerNonUserCode]
		public bool Equals(Stream other)
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
					bool flag4 = this.ClubId != other.ClubId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Name != other.Name;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Subject != other.Subject;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Access, other.Access);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.VoiceLevel != other.VoiceLevel;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CreationTime != other.CreationTime;
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

		// Token: 0x06007C36 RID: 31798 RVA: 0x001E3B50 File Offset: 0x001E1D50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasSubject = this.HasSubject;
			if (hasSubject)
			{
				num ^= this.Subject.GetHashCode();
			}
			bool flag = this.access_ != null;
			if (flag)
			{
				num ^= this.Access.GetHashCode();
			}
			bool hasVoiceLevel = this.HasVoiceLevel;
			if (hasVoiceLevel)
			{
				num ^= this.VoiceLevel.GetHashCode();
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

		// Token: 0x06007C37 RID: 31799 RVA: 0x001E3C5C File Offset: 0x001E1E5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x001E3C74 File Offset: 0x001E1E74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x001E3C80 File Offset: 0x001E1E80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClubId);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Id);
			}
			this.attribute_.WriteTo(ref output, Stream._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			bool hasSubject = this.HasSubject;
			if (hasSubject)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Subject);
			}
			bool flag = this.access_ != null;
			if (flag)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Access);
			}
			bool hasVoiceLevel = this.HasVoiceLevel;
			if (hasVoiceLevel)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.VoiceLevel);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x001E3DB4 File Offset: 0x001E1FB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			num += this.attribute_.CalculateSize(Stream._repeated_attribute_codec);
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasSubject = this.HasSubject;
			if (hasSubject)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Subject);
			}
			bool flag = this.access_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Access);
			}
			bool hasVoiceLevel = this.HasVoiceLevel;
			if (hasVoiceLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.VoiceLevel);
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

		// Token: 0x06007C3B RID: 31803 RVA: 0x001E3ECC File Offset: 0x001E20CC
		[DebuggerNonUserCode]
		public void MergeFrom(Stream other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this.attribute_.Add(other.attribute_);
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasSubject = other.HasSubject;
				if (hasSubject)
				{
					this.Subject = other.Subject;
				}
				bool flag2 = other.access_ != null;
				if (flag2)
				{
					bool flag3 = this.access_ == null;
					if (flag3)
					{
						this.Access = new StreamAccess();
					}
					this.Access.MergeFrom(other.Access);
				}
				bool hasVoiceLevel = other.HasVoiceLevel;
				if (hasVoiceLevel)
				{
					this.VoiceLevel = other.VoiceLevel;
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x001E3FED File Offset: 0x001E21ED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x001E3FF8 File Offset: 0x001E21F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_0060;
							}
							this.Id = input.ReadUInt64();
						}
						else
						{
							this.ClubId = input.ReadUInt64();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0060;
						}
						this.Name = input.ReadString();
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, Stream._repeated_attribute_codec);
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0060;
						}
						bool flag = this.access_ == null;
						if (flag)
						{
							this.Access = new StreamAccess();
						}
						input.ReadMessage(this.Access);
					}
					else
					{
						this.Subject = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						goto IL_0060;
					}
					this.CreationTime = input.ReadUInt64();
				}
				else
				{
					this.VoiceLevel = (StreamVoiceLevel)input.ReadEnum();
				}
				continue;
				IL_0060:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003869 RID: 14441
		private static readonly MessageParser<Stream> _parser = new MessageParser<Stream>(() => new Stream());

		// Token: 0x0400386A RID: 14442
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400386B RID: 14443
		private int _hasBits0;

		// Token: 0x0400386C RID: 14444
		public const int ClubIdFieldNumber = 1;

		// Token: 0x0400386D RID: 14445
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400386E RID: 14446
		private ulong clubId_;

		// Token: 0x0400386F RID: 14447
		public const int IdFieldNumber = 2;

		// Token: 0x04003870 RID: 14448
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04003871 RID: 14449
		private ulong id_;

		// Token: 0x04003872 RID: 14450
		public const int AttributeFieldNumber = 3;

		// Token: 0x04003873 RID: 14451
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003874 RID: 14452
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003875 RID: 14453
		public const int NameFieldNumber = 4;

		// Token: 0x04003876 RID: 14454
		private static readonly string NameDefaultValue = "";

		// Token: 0x04003877 RID: 14455
		private string name_;

		// Token: 0x04003878 RID: 14456
		public const int SubjectFieldNumber = 5;

		// Token: 0x04003879 RID: 14457
		private static readonly string SubjectDefaultValue = "";

		// Token: 0x0400387A RID: 14458
		private string subject_;

		// Token: 0x0400387B RID: 14459
		public const int AccessFieldNumber = 6;

		// Token: 0x0400387C RID: 14460
		private StreamAccess access_;

		// Token: 0x0400387D RID: 14461
		public const int VoiceLevelFieldNumber = 7;

		// Token: 0x0400387E RID: 14462
		private static readonly StreamVoiceLevel VoiceLevelDefaultValue = StreamVoiceLevel.VoiceLevelDisabled;

		// Token: 0x0400387F RID: 14463
		private StreamVoiceLevel voiceLevel_;

		// Token: 0x04003880 RID: 14464
		public const int CreationTimeFieldNumber = 8;

		// Token: 0x04003881 RID: 14465
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04003882 RID: 14466
		private ulong creationTime_;
	}
}
