using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000288 RID: 648
	public sealed class ModifyBankTab : IMessage<ModifyBankTab>, IMessage, IEquatable<ModifyBankTab>, IDeepCloneable<ModifyBankTab>, IBufferMessage
	{
		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x00109C68 File Offset: 0x00107E68
		[DebuggerNonUserCode]
		public static MessageParser<ModifyBankTab> Parser
		{
			get
			{
				return ModifyBankTab._parser;
			}
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x00109C80 File Offset: 0x00107E80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[120];
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x00109CA4 File Offset: 0x00107EA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyBankTab.Descriptor;
			}
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00109CBB File Offset: 0x00107EBB
		[DebuggerNonUserCode]
		public ModifyBankTab()
		{
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00109CC8 File Offset: 0x00107EC8
		[DebuggerNonUserCode]
		public ModifyBankTab(ModifyBankTab other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this.bankTabInfo_ = ((other.bankTabInfo_ != null) ? other.bankTabInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00109D18 File Offset: 0x00107F18
		[DebuggerNonUserCode]
		public ModifyBankTab Clone()
		{
			return new ModifyBankTab(this);
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x00109D30 File Offset: 0x00107F30
		// (set) Token: 0x06004510 RID: 17680 RVA: 0x00109D51 File Offset: 0x00107F51
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ModifyBankTab.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x00109D68 File Offset: 0x00107F68
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00109D83 File Offset: 0x00107F83
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06004513 RID: 17683 RVA: 0x00109D90 File Offset: 0x00107F90
		// (set) Token: 0x06004514 RID: 17684 RVA: 0x00109DA8 File Offset: 0x00107FA8
		[DebuggerNonUserCode]
		public ClanBankTab BankTabInfo
		{
			get
			{
				return this.bankTabInfo_;
			}
			set
			{
				this.bankTabInfo_ = value;
			}
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00109DB4 File Offset: 0x00107FB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyBankTab);
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00109DD4 File Offset: 0x00107FD4
		[DebuggerNonUserCode]
		public bool Equals(ModifyBankTab other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.BankTabInfo, other.BankTabInfo);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00109E48 File Offset: 0x00108048
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this.bankTabInfo_ != null;
			if (flag)
			{
				num ^= this.BankTabInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00109EB0 File Offset: 0x001080B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00109EC8 File Offset: 0x001080C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00109ED4 File Offset: 0x001080D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this.bankTabInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BankTabInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x00109F48 File Offset: 0x00108148
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this.bankTabInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BankTabInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00109FB8 File Offset: 0x001081B8
		[DebuggerNonUserCode]
		public void MergeFrom(ModifyBankTab other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool flag2 = other.bankTabInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.bankTabInfo_ == null;
					if (flag3)
					{
						this.BankTabInfo = new ClanBankTab();
					}
					this.BankTabInfo.MergeFrom(other.BankTabInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x0010A03D File Offset: 0x0010823D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x0010A048 File Offset: 0x00108248
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
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.bankTabInfo_ == null;
						if (flag)
						{
							this.BankTabInfo = new ClanBankTab();
						}
						input.ReadMessage(this.BankTabInfo);
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001EF1 RID: 7921
		private static readonly MessageParser<ModifyBankTab> _parser = new MessageParser<ModifyBankTab>(() => new ModifyBankTab());

		// Token: 0x04001EF2 RID: 7922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EF3 RID: 7923
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001EF4 RID: 7924
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001EF5 RID: 7925
		private string clanId_;

		// Token: 0x04001EF6 RID: 7926
		public const int BankTabInfoFieldNumber = 3;

		// Token: 0x04001EF7 RID: 7927
		private ClanBankTab bankTabInfo_;
	}
}
