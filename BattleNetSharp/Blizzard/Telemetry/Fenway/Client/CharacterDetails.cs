using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000324 RID: 804
	public sealed class CharacterDetails : IMessage<CharacterDetails>, IMessage, IEquatable<CharacterDetails>, IDeepCloneable<CharacterDetails>, IBufferMessage
	{
		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x0014537C File Offset: 0x0014357C
		[DebuggerNonUserCode]
		public static MessageParser<CharacterDetails> Parser
		{
			get
			{
				return CharacterDetails._parser;
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06005427 RID: 21543 RVA: 0x00145394 File Offset: 0x00143594
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonCharacterDetailsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06005428 RID: 21544 RVA: 0x001453B8 File Offset: 0x001435B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterDetails.Descriptor;
			}
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x001453CF File Offset: 0x001435CF
		[DebuggerNonUserCode]
		public CharacterDetails()
		{
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x001453D9 File Offset: 0x001435D9
		[DebuggerNonUserCode]
		public CharacterDetails(CharacterDetails other)
			: this()
		{
			this.characterId_ = other.characterId_;
			this.characterClass_ = other.characterClass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x0014540C File Offset: 0x0014360C
		[DebuggerNonUserCode]
		public CharacterDetails Clone()
		{
			return new CharacterDetails(this);
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x00145424 File Offset: 0x00143624
		// (set) Token: 0x0600542D RID: 21549 RVA: 0x00145445 File Offset: 0x00143645
		[DebuggerNonUserCode]
		public string CharacterId
		{
			get
			{
				return this.characterId_ ?? CharacterDetails.CharacterIdDefaultValue;
			}
			set
			{
				this.characterId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x0600542E RID: 21550 RVA: 0x0014545C File Offset: 0x0014365C
		[DebuggerNonUserCode]
		public bool HasCharacterId
		{
			get
			{
				return this.characterId_ != null;
			}
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x00145477 File Offset: 0x00143677
		[DebuggerNonUserCode]
		public void ClearCharacterId()
		{
			this.characterId_ = null;
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x00145484 File Offset: 0x00143684
		// (set) Token: 0x06005431 RID: 21553 RVA: 0x001454A5 File Offset: 0x001436A5
		[DebuggerNonUserCode]
		public string CharacterClass
		{
			get
			{
				return this.characterClass_ ?? CharacterDetails.CharacterClassDefaultValue;
			}
			set
			{
				this.characterClass_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x001454BC File Offset: 0x001436BC
		[DebuggerNonUserCode]
		public bool HasCharacterClass
		{
			get
			{
				return this.characterClass_ != null;
			}
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x001454D7 File Offset: 0x001436D7
		[DebuggerNonUserCode]
		public void ClearCharacterClass()
		{
			this.characterClass_ = null;
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x001454E4 File Offset: 0x001436E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterDetails);
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x00145504 File Offset: 0x00143704
		[DebuggerNonUserCode]
		public bool Equals(CharacterDetails other)
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
					bool flag4 = this.CharacterId != other.CharacterId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CharacterClass != other.CharacterClass;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x00145578 File Offset: 0x00143778
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCharacterId = this.HasCharacterId;
			if (hasCharacterId)
			{
				num ^= this.CharacterId.GetHashCode();
			}
			bool hasCharacterClass = this.HasCharacterClass;
			if (hasCharacterClass)
			{
				num ^= this.CharacterClass.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x001455DC File Offset: 0x001437DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x001455F4 File Offset: 0x001437F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x00145600 File Offset: 0x00143800
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCharacterId = this.HasCharacterId;
			if (hasCharacterId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.CharacterId);
			}
			bool hasCharacterClass = this.HasCharacterClass;
			if (hasCharacterClass)
			{
				output.WriteRawTag(18);
				output.WriteString(this.CharacterClass);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00145670 File Offset: 0x00143870
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCharacterId = this.HasCharacterId;
			if (hasCharacterId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CharacterId);
			}
			bool hasCharacterClass = this.HasCharacterClass;
			if (hasCharacterClass)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CharacterClass);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x001456DC File Offset: 0x001438DC
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterDetails other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCharacterId = other.HasCharacterId;
				if (hasCharacterId)
				{
					this.CharacterId = other.CharacterId;
				}
				bool hasCharacterClass = other.HasCharacterClass;
				if (hasCharacterClass)
				{
					this.CharacterClass = other.CharacterClass;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x0014573E File Offset: 0x0014393E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x0014574C File Offset: 0x0014394C
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
						this.CharacterClass = input.ReadString();
					}
				}
				else
				{
					this.CharacterId = input.ReadString();
				}
			}
		}

		// Token: 0x04002637 RID: 9783
		private static readonly MessageParser<CharacterDetails> _parser = new MessageParser<CharacterDetails>(() => new CharacterDetails());

		// Token: 0x04002638 RID: 9784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002639 RID: 9785
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400263A RID: 9786
		private static readonly string CharacterIdDefaultValue = "";

		// Token: 0x0400263B RID: 9787
		private string characterId_;

		// Token: 0x0400263C RID: 9788
		public const int CharacterClassFieldNumber = 2;

		// Token: 0x0400263D RID: 9789
		private static readonly string CharacterClassDefaultValue = "";

		// Token: 0x0400263E RID: 9790
		private string characterClass_;
	}
}
