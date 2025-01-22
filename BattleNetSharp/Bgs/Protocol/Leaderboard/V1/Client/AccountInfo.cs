using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Leaderboard.V1.Client
{
	// Token: 0x02000652 RID: 1618
	public sealed class AccountInfo : IMessage<AccountInfo>, IMessage, IEquatable<AccountInfo>, IDeepCloneable<AccountInfo>, IBufferMessage
	{
		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x06009650 RID: 38480 RVA: 0x002453D8 File Offset: 0x002435D8
		[DebuggerNonUserCode]
		public static MessageParser<AccountInfo> Parser
		{
			get
			{
				return AccountInfo._parser;
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x06009651 RID: 38481 RVA: 0x002453F0 File Offset: 0x002435F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x06009652 RID: 38482 RVA: 0x00245414 File Offset: 0x00243614
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountInfo.Descriptor;
			}
		}

		// Token: 0x06009653 RID: 38483 RVA: 0x0024542B File Offset: 0x0024362B
		[DebuggerNonUserCode]
		public AccountInfo()
		{
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x00245438 File Offset: 0x00243638
		[DebuggerNonUserCode]
		public AccountInfo(AccountInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.characterName_ = other.characterName_;
			this.class_ = other.class_;
			this.level_ = other.level_;
			this.email_ = other.email_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x0024549C File Offset: 0x0024369C
		[DebuggerNonUserCode]
		public AccountInfo Clone()
		{
			return new AccountInfo(this);
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x06009656 RID: 38486 RVA: 0x002454B4 File Offset: 0x002436B4
		// (set) Token: 0x06009657 RID: 38487 RVA: 0x002454D5 File Offset: 0x002436D5
		[DebuggerNonUserCode]
		public string CharacterName
		{
			get
			{
				return this.characterName_ ?? AccountInfo.CharacterNameDefaultValue;
			}
			set
			{
				this.characterName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x06009658 RID: 38488 RVA: 0x002454EC File Offset: 0x002436EC
		[DebuggerNonUserCode]
		public bool HasCharacterName
		{
			get
			{
				return this.characterName_ != null;
			}
		}

		// Token: 0x06009659 RID: 38489 RVA: 0x00245507 File Offset: 0x00243707
		[DebuggerNonUserCode]
		public void ClearCharacterName()
		{
			this.characterName_ = null;
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600965A RID: 38490 RVA: 0x00245514 File Offset: 0x00243714
		// (set) Token: 0x0600965B RID: 38491 RVA: 0x00245535 File Offset: 0x00243735
		[DebuggerNonUserCode]
		public string Class
		{
			get
			{
				return this.class_ ?? AccountInfo.ClassDefaultValue;
			}
			set
			{
				this.class_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600965C RID: 38492 RVA: 0x0024554C File Offset: 0x0024374C
		[DebuggerNonUserCode]
		public bool HasClass
		{
			get
			{
				return this.class_ != null;
			}
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x00245567 File Offset: 0x00243767
		[DebuggerNonUserCode]
		public void ClearClass()
		{
			this.class_ = null;
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600965E RID: 38494 RVA: 0x00245574 File Offset: 0x00243774
		// (set) Token: 0x0600965F RID: 38495 RVA: 0x002455A5 File Offset: 0x002437A5
		[DebuggerNonUserCode]
		public uint Level
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint levelDefaultValue;
				if (flag)
				{
					levelDefaultValue = this.level_;
				}
				else
				{
					levelDefaultValue = AccountInfo.LevelDefaultValue;
				}
				return levelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.level_ = value;
			}
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x06009660 RID: 38496 RVA: 0x002455C0 File Offset: 0x002437C0
		[DebuggerNonUserCode]
		public bool HasLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009661 RID: 38497 RVA: 0x002455DD File Offset: 0x002437DD
		[DebuggerNonUserCode]
		public void ClearLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x06009662 RID: 38498 RVA: 0x002455F0 File Offset: 0x002437F0
		// (set) Token: 0x06009663 RID: 38499 RVA: 0x00245611 File Offset: 0x00243811
		[DebuggerNonUserCode]
		public string Email
		{
			get
			{
				return this.email_ ?? AccountInfo.EmailDefaultValue;
			}
			set
			{
				this.email_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x06009664 RID: 38500 RVA: 0x00245628 File Offset: 0x00243828
		[DebuggerNonUserCode]
		public bool HasEmail
		{
			get
			{
				return this.email_ != null;
			}
		}

		// Token: 0x06009665 RID: 38501 RVA: 0x00245643 File Offset: 0x00243843
		[DebuggerNonUserCode]
		public void ClearEmail()
		{
			this.email_ = null;
		}

		// Token: 0x06009666 RID: 38502 RVA: 0x00245650 File Offset: 0x00243850
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountInfo);
		}

		// Token: 0x06009667 RID: 38503 RVA: 0x00245670 File Offset: 0x00243870
		[DebuggerNonUserCode]
		public bool Equals(AccountInfo other)
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
					bool flag4 = this.CharacterName != other.CharacterName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Class != other.Class;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Level != other.Level;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Email != other.Email;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x0024571C File Offset: 0x0024391C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCharacterName = this.HasCharacterName;
			if (hasCharacterName)
			{
				num ^= this.CharacterName.GetHashCode();
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				num ^= this.Class.GetHashCode();
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num ^= this.Level.GetHashCode();
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num ^= this.Email.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x002457B8 File Offset: 0x002439B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x002457D0 File Offset: 0x002439D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x002457DC File Offset: 0x002439DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCharacterName = this.HasCharacterName;
			if (hasCharacterName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.CharacterName);
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Class);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Level);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Email);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x00245890 File Offset: 0x00243A90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCharacterName = this.HasCharacterName;
			if (hasCharacterName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CharacterName);
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Class);
			}
			bool hasLevel = this.HasLevel;
			if (hasLevel)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x00245938 File Offset: 0x00243B38
		[DebuggerNonUserCode]
		public void MergeFrom(AccountInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCharacterName = other.HasCharacterName;
				if (hasCharacterName)
				{
					this.CharacterName = other.CharacterName;
				}
				bool hasClass = other.HasClass;
				if (hasClass)
				{
					this.Class = other.Class;
				}
				bool hasLevel = other.HasLevel;
				if (hasLevel)
				{
					this.Level = other.Level;
				}
				bool hasEmail = other.HasEmail;
				if (hasEmail)
				{
					this.Email = other.Email;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x002459CE File Offset: 0x00243BCE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x002459DC File Offset: 0x00243BDC
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
						if (num3 != 26U)
						{
							goto IL_0029;
						}
						this.Class = input.ReadString();
					}
					else
					{
						this.CharacterName = input.ReadString();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 42U)
					{
						goto IL_0029;
					}
					this.Email = input.ReadString();
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043B1 RID: 17329
		private static readonly MessageParser<AccountInfo> _parser = new MessageParser<AccountInfo>(() => new AccountInfo());

		// Token: 0x040043B2 RID: 17330
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043B3 RID: 17331
		private int _hasBits0;

		// Token: 0x040043B4 RID: 17332
		public const int CharacterNameFieldNumber = 1;

		// Token: 0x040043B5 RID: 17333
		private static readonly string CharacterNameDefaultValue = "";

		// Token: 0x040043B6 RID: 17334
		private string characterName_;

		// Token: 0x040043B7 RID: 17335
		public const int ClassFieldNumber = 3;

		// Token: 0x040043B8 RID: 17336
		private static readonly string ClassDefaultValue = "";

		// Token: 0x040043B9 RID: 17337
		private string class_;

		// Token: 0x040043BA RID: 17338
		public const int LevelFieldNumber = 4;

		// Token: 0x040043BB RID: 17339
		private static readonly uint LevelDefaultValue = 0U;

		// Token: 0x040043BC RID: 17340
		private uint level_;

		// Token: 0x040043BD RID: 17341
		public const int EmailFieldNumber = 5;

		// Token: 0x040043BE RID: 17342
		private static readonly string EmailDefaultValue = "";

		// Token: 0x040043BF RID: 17343
		private string email_;
	}
}
