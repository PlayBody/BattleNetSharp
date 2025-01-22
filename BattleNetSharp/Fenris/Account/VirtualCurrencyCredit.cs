using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D4 RID: 724
	public sealed class VirtualCurrencyCredit : IMessage<VirtualCurrencyCredit>, IMessage, IEquatable<VirtualCurrencyCredit>, IDeepCloneable<VirtualCurrencyCredit>, IBufferMessage
	{
		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x00125098 File Offset: 0x00123298
		[DebuggerNonUserCode]
		public static MessageParser<VirtualCurrencyCredit> Parser
		{
			get
			{
				return VirtualCurrencyCredit._parser;
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06004C97 RID: 19607 RVA: 0x001250B0 File Offset: 0x001232B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x001250D4 File Offset: 0x001232D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VirtualCurrencyCredit.Descriptor;
			}
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x001250EB File Offset: 0x001232EB
		[DebuggerNonUserCode]
		public VirtualCurrencyCredit()
		{
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x001250F8 File Offset: 0x001232F8
		[DebuggerNonUserCode]
		public VirtualCurrencyCredit(VirtualCurrencyCredit other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.creditId_ = other.creditId_;
			this.achievementSno_ = other.achievementSno_;
			this.amount_ = other.amount_;
			this.description_ = other.description_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x0012515C File Offset: 0x0012335C
		[DebuggerNonUserCode]
		public VirtualCurrencyCredit Clone()
		{
			return new VirtualCurrencyCredit(this);
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06004C9C RID: 19612 RVA: 0x00125174 File Offset: 0x00123374
		// (set) Token: 0x06004C9D RID: 19613 RVA: 0x00125195 File Offset: 0x00123395
		[DebuggerNonUserCode]
		public string CreditId
		{
			get
			{
				return this.creditId_ ?? VirtualCurrencyCredit.CreditIdDefaultValue;
			}
			set
			{
				this.creditId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06004C9E RID: 19614 RVA: 0x001251AC File Offset: 0x001233AC
		[DebuggerNonUserCode]
		public bool HasCreditId
		{
			get
			{
				return this.creditId_ != null;
			}
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x001251C7 File Offset: 0x001233C7
		[DebuggerNonUserCode]
		public void ClearCreditId()
		{
			this.creditId_ = null;
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x06004CA0 RID: 19616 RVA: 0x001251D4 File Offset: 0x001233D4
		// (set) Token: 0x06004CA1 RID: 19617 RVA: 0x00125205 File Offset: 0x00123405
		[DebuggerNonUserCode]
		public int AchievementSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int achievementSnoDefaultValue;
				if (flag)
				{
					achievementSnoDefaultValue = this.achievementSno_;
				}
				else
				{
					achievementSnoDefaultValue = VirtualCurrencyCredit.AchievementSnoDefaultValue;
				}
				return achievementSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.achievementSno_ = value;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06004CA2 RID: 19618 RVA: 0x00125220 File Offset: 0x00123420
		[DebuggerNonUserCode]
		public bool HasAchievementSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x0012523D File Offset: 0x0012343D
		[DebuggerNonUserCode]
		public void ClearAchievementSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06004CA4 RID: 19620 RVA: 0x00125250 File Offset: 0x00123450
		// (set) Token: 0x06004CA5 RID: 19621 RVA: 0x00125281 File Offset: 0x00123481
		[DebuggerNonUserCode]
		public uint Amount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint amountDefaultValue;
				if (flag)
				{
					amountDefaultValue = this.amount_;
				}
				else
				{
					amountDefaultValue = VirtualCurrencyCredit.AmountDefaultValue;
				}
				return amountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.amount_ = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x0012529C File Offset: 0x0012349C
		[DebuggerNonUserCode]
		public bool HasAmount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x001252B9 File Offset: 0x001234B9
		[DebuggerNonUserCode]
		public void ClearAmount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x001252CC File Offset: 0x001234CC
		// (set) Token: 0x06004CA9 RID: 19625 RVA: 0x001252ED File Offset: 0x001234ED
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? VirtualCurrencyCredit.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06004CAA RID: 19626 RVA: 0x00125304 File Offset: 0x00123504
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x0012531F File Offset: 0x0012351F
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x0012532C File Offset: 0x0012352C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VirtualCurrencyCredit);
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x0012534C File Offset: 0x0012354C
		[DebuggerNonUserCode]
		public bool Equals(VirtualCurrencyCredit other)
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
					bool flag4 = this.CreditId != other.CreditId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AchievementSno != other.AchievementSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Amount != other.Amount;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Description != other.Description;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x001253F8 File Offset: 0x001235F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCreditId = this.HasCreditId;
			if (hasCreditId)
			{
				num ^= this.CreditId.GetHashCode();
			}
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num ^= this.AchievementSno.GetHashCode();
			}
			bool hasAmount = this.HasAmount;
			if (hasAmount)
			{
				num ^= this.Amount.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x0012549C File Offset: 0x0012369C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x001254B4 File Offset: 0x001236B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x001254C0 File Offset: 0x001236C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCreditId = this.HasCreditId;
			if (hasCreditId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.CreditId);
			}
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				output.WriteRawTag(21);
				output.WriteSFixed32(this.AchievementSno);
			}
			bool hasAmount = this.HasAmount;
			if (hasAmount)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Amount);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Description);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x00125574 File Offset: 0x00123774
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCreditId = this.HasCreditId;
			if (hasCreditId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CreditId);
			}
			bool hasAchievementSno = this.HasAchievementSno;
			if (hasAchievementSno)
			{
				num += 5;
			}
			bool hasAmount = this.HasAmount;
			if (hasAmount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Amount);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x00125610 File Offset: 0x00123810
		[DebuggerNonUserCode]
		public void MergeFrom(VirtualCurrencyCredit other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCreditId = other.HasCreditId;
				if (hasCreditId)
				{
					this.CreditId = other.CreditId;
				}
				bool hasAchievementSno = other.HasAchievementSno;
				if (hasAchievementSno)
				{
					this.AchievementSno = other.AchievementSno;
				}
				bool hasAmount = other.HasAmount;
				if (hasAmount)
				{
					this.Amount = other.Amount;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x001256A6 File Offset: 0x001238A6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x001256B4 File Offset: 0x001238B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							goto IL_0029;
						}
						this.AchievementSno = input.ReadSFixed32();
					}
					else
					{
						this.CreditId = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_0029;
					}
					this.Description = input.ReadString();
				}
				else
				{
					this.Amount = input.ReadUInt32();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002229 RID: 8745
		private static readonly MessageParser<VirtualCurrencyCredit> _parser = new MessageParser<VirtualCurrencyCredit>(() => new VirtualCurrencyCredit());

		// Token: 0x0400222A RID: 8746
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400222B RID: 8747
		private int _hasBits0;

		// Token: 0x0400222C RID: 8748
		public const int CreditIdFieldNumber = 1;

		// Token: 0x0400222D RID: 8749
		private static readonly string CreditIdDefaultValue = "";

		// Token: 0x0400222E RID: 8750
		private string creditId_;

		// Token: 0x0400222F RID: 8751
		public const int AchievementSnoFieldNumber = 2;

		// Token: 0x04002230 RID: 8752
		private static readonly int AchievementSnoDefaultValue = -1;

		// Token: 0x04002231 RID: 8753
		private int achievementSno_;

		// Token: 0x04002232 RID: 8754
		public const int AmountFieldNumber = 3;

		// Token: 0x04002233 RID: 8755
		private static readonly uint AmountDefaultValue = 0U;

		// Token: 0x04002234 RID: 8756
		private uint amount_;

		// Token: 0x04002235 RID: 8757
		public const int DescriptionFieldNumber = 4;

		// Token: 0x04002236 RID: 8758
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x04002237 RID: 8759
		private string description_;
	}
}
