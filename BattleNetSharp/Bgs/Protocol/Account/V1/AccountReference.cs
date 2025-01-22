using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000733 RID: 1843
	public sealed class AccountReference : IMessage<AccountReference>, IMessage, IEquatable<AccountReference>, IDeepCloneable<AccountReference>, IBufferMessage
	{
		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600A884 RID: 43140 RVA: 0x00290D20 File Offset: 0x0028EF20
		[DebuggerNonUserCode]
		public static MessageParser<AccountReference> Parser
		{
			get
			{
				return AccountReference._parser;
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600A885 RID: 43141 RVA: 0x00290D38 File Offset: 0x0028EF38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x00290D5C File Offset: 0x0028EF5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountReference.Descriptor;
			}
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x00290D73 File Offset: 0x0028EF73
		[DebuggerNonUserCode]
		public AccountReference()
		{
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x00290D80 File Offset: 0x0028EF80
		[DebuggerNonUserCode]
		public AccountReference(AccountReference other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.email_ = other.email_;
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.battleTag_ = other.battleTag_;
			this.phoneNumber_ = other.phoneNumber_;
			this.region_ = other.region_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A889 RID: 43145 RVA: 0x00290E0C File Offset: 0x0028F00C
		[DebuggerNonUserCode]
		public AccountReference Clone()
		{
			return new AccountReference(this);
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600A88A RID: 43146 RVA: 0x00290E24 File Offset: 0x0028F024
		// (set) Token: 0x0600A88B RID: 43147 RVA: 0x00290E55 File Offset: 0x0028F055
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = AccountReference.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600A88C RID: 43148 RVA: 0x00290E70 File Offset: 0x0028F070
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x00290E8D File Offset: 0x0028F08D
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600A88E RID: 43150 RVA: 0x00290EA0 File Offset: 0x0028F0A0
		// (set) Token: 0x0600A88F RID: 43151 RVA: 0x00290EC1 File Offset: 0x0028F0C1
		[DebuggerNonUserCode]
		public string Email
		{
			get
			{
				return this.email_ ?? AccountReference.EmailDefaultValue;
			}
			set
			{
				this.email_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600A890 RID: 43152 RVA: 0x00290ED8 File Offset: 0x0028F0D8
		[DebuggerNonUserCode]
		public bool HasEmail
		{
			get
			{
				return this.email_ != null;
			}
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x00290EF3 File Offset: 0x0028F0F3
		[DebuggerNonUserCode]
		public void ClearEmail()
		{
			this.email_ = null;
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600A892 RID: 43154 RVA: 0x00290F00 File Offset: 0x0028F100
		// (set) Token: 0x0600A893 RID: 43155 RVA: 0x00290F18 File Offset: 0x0028F118
		[DebuggerNonUserCode]
		public GameAccountHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600A894 RID: 43156 RVA: 0x00290F24 File Offset: 0x0028F124
		// (set) Token: 0x0600A895 RID: 43157 RVA: 0x00290F45 File Offset: 0x0028F145
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? AccountReference.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600A896 RID: 43158 RVA: 0x00290F5C File Offset: 0x0028F15C
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x00290F77 File Offset: 0x0028F177
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600A898 RID: 43160 RVA: 0x00290F84 File Offset: 0x0028F184
		// (set) Token: 0x0600A899 RID: 43161 RVA: 0x00290FA5 File Offset: 0x0028F1A5
		[DebuggerNonUserCode]
		public string PhoneNumber
		{
			get
			{
				return this.phoneNumber_ ?? AccountReference.PhoneNumberDefaultValue;
			}
			set
			{
				this.phoneNumber_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600A89A RID: 43162 RVA: 0x00290FBC File Offset: 0x0028F1BC
		[DebuggerNonUserCode]
		public bool HasPhoneNumber
		{
			get
			{
				return this.phoneNumber_ != null;
			}
		}

		// Token: 0x0600A89B RID: 43163 RVA: 0x00290FD7 File Offset: 0x0028F1D7
		[DebuggerNonUserCode]
		public void ClearPhoneNumber()
		{
			this.phoneNumber_ = null;
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600A89C RID: 43164 RVA: 0x00290FE4 File Offset: 0x0028F1E4
		// (set) Token: 0x0600A89D RID: 43165 RVA: 0x00291015 File Offset: 0x0028F215
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = AccountReference.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.region_ = value;
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600A89E RID: 43166 RVA: 0x00291030 File Offset: 0x0028F230
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x0029104D File Offset: 0x0028F24D
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A8A0 RID: 43168 RVA: 0x00291060 File Offset: 0x0028F260
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountReference);
		}

		// Token: 0x0600A8A1 RID: 43169 RVA: 0x00291080 File Offset: 0x0028F280
		[DebuggerNonUserCode]
		public bool Equals(AccountReference other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Email != other.Email;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Handle, other.Handle);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BattleTag != other.BattleTag;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.PhoneNumber != other.PhoneNumber;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Region != other.Region;
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

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x0029116C File Offset: 0x0028F36C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num ^= this.Email.GetHashCode();
			}
			bool flag = this.handle_ != null;
			if (flag)
			{
				num ^= this.Handle.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num ^= this.PhoneNumber.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x00291244 File Offset: 0x0028F444
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x0029125C File Offset: 0x0028F45C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x00291268 File Offset: 0x0028F468
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Id);
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Email);
			}
			bool flag = this.handle_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Handle);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(34);
				output.WriteString(this.BattleTag);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				output.WriteRawTag(42);
				output.WriteString(this.PhoneNumber);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Region);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8A6 RID: 43174 RVA: 0x00291368 File Offset: 0x0028F568
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 5;
			}
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
			}
			bool flag = this.handle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool hasPhoneNumber = this.HasPhoneNumber;
			if (hasPhoneNumber)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PhoneNumber);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8A7 RID: 43175 RVA: 0x00291444 File Offset: 0x0028F644
		[DebuggerNonUserCode]
		public void MergeFrom(AccountReference other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasEmail = other.HasEmail;
				if (hasEmail)
				{
					this.Email = other.Email;
				}
				bool flag2 = other.handle_ != null;
				if (flag2)
				{
					bool flag3 = this.handle_ == null;
					if (flag3)
					{
						this.Handle = new GameAccountHandle();
					}
					this.Handle.MergeFrom(other.Handle);
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				bool hasPhoneNumber = other.HasPhoneNumber;
				if (hasPhoneNumber)
				{
					this.PhoneNumber = other.PhoneNumber;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A8A8 RID: 43176 RVA: 0x00291538 File Offset: 0x0028F738
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x00291544 File Offset: 0x0028F744
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
					if (num3 != 13U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_003D;
							}
							bool flag = this.handle_ == null;
							if (flag)
							{
								this.Handle = new GameAccountHandle();
							}
							input.ReadMessage(this.Handle);
						}
						else
						{
							this.Email = input.ReadString();
						}
					}
					else
					{
						this.Id = input.ReadFixed32();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 80U)
						{
							goto IL_003D;
						}
						this.Region = input.ReadUInt32();
					}
					else
					{
						this.PhoneNumber = input.ReadString();
					}
				}
				else
				{
					this.BattleTag = input.ReadString();
				}
				continue;
				IL_003D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004BBC RID: 19388
		private static readonly MessageParser<AccountReference> _parser = new MessageParser<AccountReference>(() => new AccountReference());

		// Token: 0x04004BBD RID: 19389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BBE RID: 19390
		private int _hasBits0;

		// Token: 0x04004BBF RID: 19391
		public const int IdFieldNumber = 1;

		// Token: 0x04004BC0 RID: 19392
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04004BC1 RID: 19393
		private uint id_;

		// Token: 0x04004BC2 RID: 19394
		public const int EmailFieldNumber = 2;

		// Token: 0x04004BC3 RID: 19395
		private static readonly string EmailDefaultValue = "";

		// Token: 0x04004BC4 RID: 19396
		private string email_;

		// Token: 0x04004BC5 RID: 19397
		public const int HandleFieldNumber = 3;

		// Token: 0x04004BC6 RID: 19398
		private GameAccountHandle handle_;

		// Token: 0x04004BC7 RID: 19399
		public const int BattleTagFieldNumber = 4;

		// Token: 0x04004BC8 RID: 19400
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04004BC9 RID: 19401
		private string battleTag_;

		// Token: 0x04004BCA RID: 19402
		public const int PhoneNumberFieldNumber = 5;

		// Token: 0x04004BCB RID: 19403
		private static readonly string PhoneNumberDefaultValue = "";

		// Token: 0x04004BCC RID: 19404
		private string phoneNumber_;

		// Token: 0x04004BCD RID: 19405
		public const int RegionFieldNumber = 10;

		// Token: 0x04004BCE RID: 19406
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004BCF RID: 19407
		private uint region_;
	}
}
