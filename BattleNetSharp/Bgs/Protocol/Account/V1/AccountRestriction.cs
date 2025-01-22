using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000753 RID: 1875
	public sealed class AccountRestriction : IMessage<AccountRestriction>, IMessage, IEquatable<AccountRestriction>, IDeepCloneable<AccountRestriction>, IBufferMessage
	{
		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600ACA6 RID: 44198 RVA: 0x002A0894 File Offset: 0x0029EA94
		[DebuggerNonUserCode]
		public static MessageParser<AccountRestriction> Parser
		{
			get
			{
				return AccountRestriction._parser;
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x002A08AC File Offset: 0x0029EAAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[35];
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600ACA8 RID: 44200 RVA: 0x002A08D0 File Offset: 0x0029EAD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountRestriction.Descriptor;
			}
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x002A08E7 File Offset: 0x0029EAE7
		[DebuggerNonUserCode]
		public AccountRestriction()
		{
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x002A08FC File Offset: 0x0029EAFC
		[DebuggerNonUserCode]
		public AccountRestriction(AccountRestriction other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.restrictionId_ = other.restrictionId_;
			this.program_ = other.program_;
			this.type_ = other.type_;
			this.platform_ = other.platform_.Clone();
			this.expireTime_ = other.expireTime_;
			this.createdTime_ = other.createdTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x002A097C File Offset: 0x0029EB7C
		[DebuggerNonUserCode]
		public AccountRestriction Clone()
		{
			return new AccountRestriction(this);
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600ACAC RID: 44204 RVA: 0x002A0994 File Offset: 0x0029EB94
		// (set) Token: 0x0600ACAD RID: 44205 RVA: 0x002A09C5 File Offset: 0x0029EBC5
		[DebuggerNonUserCode]
		public uint RestrictionId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint restrictionIdDefaultValue;
				if (flag)
				{
					restrictionIdDefaultValue = this.restrictionId_;
				}
				else
				{
					restrictionIdDefaultValue = AccountRestriction.RestrictionIdDefaultValue;
				}
				return restrictionIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.restrictionId_ = value;
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600ACAE RID: 44206 RVA: 0x002A09E0 File Offset: 0x0029EBE0
		[DebuggerNonUserCode]
		public bool HasRestrictionId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ACAF RID: 44207 RVA: 0x002A09FD File Offset: 0x0029EBFD
		[DebuggerNonUserCode]
		public void ClearRestrictionId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600ACB0 RID: 44208 RVA: 0x002A0A10 File Offset: 0x0029EC10
		// (set) Token: 0x0600ACB1 RID: 44209 RVA: 0x002A0A41 File Offset: 0x0029EC41
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = AccountRestriction.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.program_ = value;
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x002A0A5C File Offset: 0x0029EC5C
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x002A0A79 File Offset: 0x0029EC79
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600ACB4 RID: 44212 RVA: 0x002A0A8C File Offset: 0x0029EC8C
		// (set) Token: 0x0600ACB5 RID: 44213 RVA: 0x002A0ABD File Offset: 0x0029ECBD
		[DebuggerNonUserCode]
		public RestrictionType Type
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				RestrictionType typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = AccountRestriction.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.type_ = value;
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600ACB6 RID: 44214 RVA: 0x002A0AD8 File Offset: 0x0029ECD8
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600ACB7 RID: 44215 RVA: 0x002A0AF5 File Offset: 0x0029ECF5
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x002A0B08 File Offset: 0x0029ED08
		[DebuggerNonUserCode]
		public RepeatedField<uint> Platform
		{
			get
			{
				return this.platform_;
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600ACB9 RID: 44217 RVA: 0x002A0B20 File Offset: 0x0029ED20
		// (set) Token: 0x0600ACBA RID: 44218 RVA: 0x002A0B51 File Offset: 0x0029ED51
		[DebuggerNonUserCode]
		public ulong ExpireTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong expireTimeDefaultValue;
				if (flag)
				{
					expireTimeDefaultValue = this.expireTime_;
				}
				else
				{
					expireTimeDefaultValue = AccountRestriction.ExpireTimeDefaultValue;
				}
				return expireTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.expireTime_ = value;
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600ACBB RID: 44219 RVA: 0x002A0B6C File Offset: 0x0029ED6C
		[DebuggerNonUserCode]
		public bool HasExpireTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x002A0B89 File Offset: 0x0029ED89
		[DebuggerNonUserCode]
		public void ClearExpireTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600ACBD RID: 44221 RVA: 0x002A0B9C File Offset: 0x0029ED9C
		// (set) Token: 0x0600ACBE RID: 44222 RVA: 0x002A0BCE File Offset: 0x0029EDCE
		[DebuggerNonUserCode]
		public ulong CreatedTime
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong createdTimeDefaultValue;
				if (flag)
				{
					createdTimeDefaultValue = this.createdTime_;
				}
				else
				{
					createdTimeDefaultValue = AccountRestriction.CreatedTimeDefaultValue;
				}
				return createdTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.createdTime_ = value;
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600ACBF RID: 44223 RVA: 0x002A0BE8 File Offset: 0x0029EDE8
		[DebuggerNonUserCode]
		public bool HasCreatedTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x002A0C06 File Offset: 0x0029EE06
		[DebuggerNonUserCode]
		public void ClearCreatedTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600ACC1 RID: 44225 RVA: 0x002A0C18 File Offset: 0x0029EE18
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountRestriction);
		}

		// Token: 0x0600ACC2 RID: 44226 RVA: 0x002A0C38 File Offset: 0x0029EE38
		[DebuggerNonUserCode]
		public bool Equals(AccountRestriction other)
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
					bool flag4 = this.RestrictionId != other.RestrictionId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Type != other.Type;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.platform_.Equals(other.platform_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ExpireTime != other.ExpireTime;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CreatedTime != other.CreatedTime;
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

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x002A0D24 File Offset: 0x0029EF24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRestrictionId = this.HasRestrictionId;
			if (hasRestrictionId)
			{
				num ^= this.RestrictionId.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.platform_.GetHashCode();
			bool hasExpireTime = this.HasExpireTime;
			if (hasExpireTime)
			{
				num ^= this.ExpireTime.GetHashCode();
			}
			bool hasCreatedTime = this.HasCreatedTime;
			if (hasCreatedTime)
			{
				num ^= this.CreatedTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x002A0E00 File Offset: 0x0029F000
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x002A0E18 File Offset: 0x0029F018
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x002A0E24 File Offset: 0x0029F024
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRestrictionId = this.HasRestrictionId;
			if (hasRestrictionId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RestrictionId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Program);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Type);
			}
			this.platform_.WriteTo(ref output, AccountRestriction._repeated_platform_codec);
			bool hasExpireTime = this.HasExpireTime;
			if (hasExpireTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.ExpireTime);
			}
			bool hasCreatedTime = this.HasCreatedTime;
			if (hasCreatedTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.CreatedTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x002A0F10 File Offset: 0x0029F110
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRestrictionId = this.HasRestrictionId;
			if (hasRestrictionId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RestrictionId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.platform_.CalculateSize(AccountRestriction._repeated_platform_codec);
			bool hasExpireTime = this.HasExpireTime;
			if (hasExpireTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpireTime);
			}
			bool hasCreatedTime = this.HasCreatedTime;
			if (hasCreatedTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x002A0FE0 File Offset: 0x0029F1E0
		[DebuggerNonUserCode]
		public void MergeFrom(AccountRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRestrictionId = other.HasRestrictionId;
				if (hasRestrictionId)
				{
					this.RestrictionId = other.RestrictionId;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				this.platform_.Add(other.platform_);
				bool hasExpireTime = other.HasExpireTime;
				if (hasExpireTime)
				{
					this.ExpireTime = other.ExpireTime;
				}
				bool hasCreatedTime = other.HasCreatedTime;
				if (hasCreatedTime)
				{
					this.CreatedTime = other.CreatedTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x002A10A6 File Offset: 0x0029F2A6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x002A10B4 File Offset: 0x0029F2B4
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							if (num3 != 24U)
							{
								goto IL_0045;
							}
							this.Type = (RestrictionType)input.ReadEnum();
						}
						else
						{
							this.Program = input.ReadFixed32();
						}
					}
					else
					{
						this.RestrictionId = input.ReadUInt32();
					}
				}
				else if (num3 <= 37U)
				{
					if (num3 != 34U && num3 != 37U)
					{
						goto IL_0045;
					}
					this.platform_.AddEntriesFrom(ref input, AccountRestriction._repeated_platform_codec);
				}
				else if (num3 != 40U)
				{
					if (num3 != 48U)
					{
						goto IL_0045;
					}
					this.CreatedTime = input.ReadUInt64();
				}
				else
				{
					this.ExpireTime = input.ReadUInt64();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004DBB RID: 19899
		private static readonly MessageParser<AccountRestriction> _parser = new MessageParser<AccountRestriction>(() => new AccountRestriction());

		// Token: 0x04004DBC RID: 19900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DBD RID: 19901
		private int _hasBits0;

		// Token: 0x04004DBE RID: 19902
		public const int RestrictionIdFieldNumber = 1;

		// Token: 0x04004DBF RID: 19903
		private static readonly uint RestrictionIdDefaultValue = 0U;

		// Token: 0x04004DC0 RID: 19904
		private uint restrictionId_;

		// Token: 0x04004DC1 RID: 19905
		public const int ProgramFieldNumber = 2;

		// Token: 0x04004DC2 RID: 19906
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004DC3 RID: 19907
		private uint program_;

		// Token: 0x04004DC4 RID: 19908
		public const int TypeFieldNumber = 3;

		// Token: 0x04004DC5 RID: 19909
		private static readonly RestrictionType TypeDefaultValue = RestrictionType.Unknown;

		// Token: 0x04004DC6 RID: 19910
		private RestrictionType type_;

		// Token: 0x04004DC7 RID: 19911
		public const int PlatformFieldNumber = 4;

		// Token: 0x04004DC8 RID: 19912
		private static readonly FieldCodec<uint> _repeated_platform_codec = FieldCodec.ForFixed32(37U);

		// Token: 0x04004DC9 RID: 19913
		private readonly RepeatedField<uint> platform_ = new RepeatedField<uint>();

		// Token: 0x04004DCA RID: 19914
		public const int ExpireTimeFieldNumber = 5;

		// Token: 0x04004DCB RID: 19915
		private static readonly ulong ExpireTimeDefaultValue = 0UL;

		// Token: 0x04004DCC RID: 19916
		private ulong expireTime_;

		// Token: 0x04004DCD RID: 19917
		public const int CreatedTimeFieldNumber = 6;

		// Token: 0x04004DCE RID: 19918
		private static readonly ulong CreatedTimeDefaultValue = 0UL;

		// Token: 0x04004DCF RID: 19919
		private ulong createdTime_;
	}
}
