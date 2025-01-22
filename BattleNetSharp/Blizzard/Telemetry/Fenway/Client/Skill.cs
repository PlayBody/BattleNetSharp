using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200032E RID: 814
	public sealed class Skill : IMessage<Skill>, IMessage, IEquatable<Skill>, IDeepCloneable<Skill>, IBufferMessage
	{
		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x001489C0 File Offset: 0x00146BC0
		[DebuggerNonUserCode]
		public static MessageParser<Skill> Parser
		{
			get
			{
				return Skill._parser;
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x001489D8 File Offset: 0x00146BD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonSkillStateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06005502 RID: 21762 RVA: 0x001489FC File Offset: 0x00146BFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Skill.Descriptor;
			}
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00148A13 File Offset: 0x00146C13
		[DebuggerNonUserCode]
		public Skill()
		{
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00148A20 File Offset: 0x00146C20
		[DebuggerNonUserCode]
		public Skill(Skill other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.skillType_ = other.skillType_;
			this.skillLevel_ = other.skillLevel_;
			this.skillName_ = other.skillName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00148A78 File Offset: 0x00146C78
		[DebuggerNonUserCode]
		public Skill Clone()
		{
			return new Skill(this);
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x00148A90 File Offset: 0x00146C90
		// (set) Token: 0x06005507 RID: 21767 RVA: 0x00148AC1 File Offset: 0x00146CC1
		[DebuggerNonUserCode]
		public int SkillType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int skillTypeDefaultValue;
				if (flag)
				{
					skillTypeDefaultValue = this.skillType_;
				}
				else
				{
					skillTypeDefaultValue = Skill.SkillTypeDefaultValue;
				}
				return skillTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.skillType_ = value;
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x00148ADC File Offset: 0x00146CDC
		[DebuggerNonUserCode]
		public bool HasSkillType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00148AF9 File Offset: 0x00146CF9
		[DebuggerNonUserCode]
		public void ClearSkillType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x00148B0C File Offset: 0x00146D0C
		// (set) Token: 0x0600550B RID: 21771 RVA: 0x00148B3D File Offset: 0x00146D3D
		[DebuggerNonUserCode]
		public long SkillLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				long skillLevelDefaultValue;
				if (flag)
				{
					skillLevelDefaultValue = this.skillLevel_;
				}
				else
				{
					skillLevelDefaultValue = Skill.SkillLevelDefaultValue;
				}
				return skillLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.skillLevel_ = value;
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x00148B58 File Offset: 0x00146D58
		[DebuggerNonUserCode]
		public bool HasSkillLevel
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00148B75 File Offset: 0x00146D75
		[DebuggerNonUserCode]
		public void ClearSkillLevel()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x00148B88 File Offset: 0x00146D88
		// (set) Token: 0x0600550F RID: 21775 RVA: 0x00148BA9 File Offset: 0x00146DA9
		[DebuggerNonUserCode]
		public string SkillName
		{
			get
			{
				return this.skillName_ ?? Skill.SkillNameDefaultValue;
			}
			set
			{
				this.skillName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06005510 RID: 21776 RVA: 0x00148BC0 File Offset: 0x00146DC0
		[DebuggerNonUserCode]
		public bool HasSkillName
		{
			get
			{
				return this.skillName_ != null;
			}
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00148BDB File Offset: 0x00146DDB
		[DebuggerNonUserCode]
		public void ClearSkillName()
		{
			this.skillName_ = null;
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00148BE8 File Offset: 0x00146DE8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Skill);
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00148C08 File Offset: 0x00146E08
		[DebuggerNonUserCode]
		public bool Equals(Skill other)
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
					bool flag4 = this.SkillType != other.SkillType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SkillLevel != other.SkillLevel;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SkillName != other.SkillName;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x00148C94 File Offset: 0x00146E94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSkillType = this.HasSkillType;
			if (hasSkillType)
			{
				num ^= this.SkillType.GetHashCode();
			}
			bool hasSkillLevel = this.HasSkillLevel;
			if (hasSkillLevel)
			{
				num ^= this.SkillLevel.GetHashCode();
			}
			bool hasSkillName = this.HasSkillName;
			if (hasSkillName)
			{
				num ^= this.SkillName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x00148D1C File Offset: 0x00146F1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x00148D34 File Offset: 0x00146F34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x00148D40 File Offset: 0x00146F40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSkillType = this.HasSkillType;
			if (hasSkillType)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillType);
			}
			bool hasSkillLevel = this.HasSkillLevel;
			if (hasSkillLevel)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SkillLevel);
			}
			bool hasSkillName = this.HasSkillName;
			if (hasSkillName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SkillName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00148DD0 File Offset: 0x00146FD0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSkillType = this.HasSkillType;
			if (hasSkillType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillType);
			}
			bool hasSkillLevel = this.HasSkillLevel;
			if (hasSkillLevel)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillLevel);
			}
			bool hasSkillName = this.HasSkillName;
			if (hasSkillName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SkillName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00148E5C File Offset: 0x0014705C
		[DebuggerNonUserCode]
		public void MergeFrom(Skill other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSkillType = other.HasSkillType;
				if (hasSkillType)
				{
					this.SkillType = other.SkillType;
				}
				bool hasSkillLevel = other.HasSkillLevel;
				if (hasSkillLevel)
				{
					this.SkillLevel = other.SkillLevel;
				}
				bool hasSkillName = other.HasSkillName;
				if (hasSkillName)
				{
					this.SkillName = other.SkillName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x00148ED7 File Offset: 0x001470D7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00148EE4 File Offset: 0x001470E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SkillName = input.ReadString();
						}
					}
					else
					{
						this.SkillLevel = input.ReadInt64();
					}
				}
				else
				{
					this.SkillType = input.ReadInt32();
				}
			}
		}

		// Token: 0x040026A3 RID: 9891
		private static readonly MessageParser<Skill> _parser = new MessageParser<Skill>(() => new Skill());

		// Token: 0x040026A4 RID: 9892
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026A5 RID: 9893
		private int _hasBits0;

		// Token: 0x040026A6 RID: 9894
		public const int SkillTypeFieldNumber = 1;

		// Token: 0x040026A7 RID: 9895
		private static readonly int SkillTypeDefaultValue = 0;

		// Token: 0x040026A8 RID: 9896
		private int skillType_;

		// Token: 0x040026A9 RID: 9897
		public const int SkillLevelFieldNumber = 2;

		// Token: 0x040026AA RID: 9898
		private static readonly long SkillLevelDefaultValue = 0L;

		// Token: 0x040026AB RID: 9899
		private long skillLevel_;

		// Token: 0x040026AC RID: 9900
		public const int SkillNameFieldNumber = 3;

		// Token: 0x040026AD RID: 9901
		private static readonly string SkillNameDefaultValue = "";

		// Token: 0x040026AE RID: 9902
		private string skillName_;
	}
}
