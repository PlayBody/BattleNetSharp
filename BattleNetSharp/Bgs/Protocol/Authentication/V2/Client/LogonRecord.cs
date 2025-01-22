using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000628 RID: 1576
	public sealed class LogonRecord : IMessage<LogonRecord>, IMessage, IEquatable<LogonRecord>, IDeepCloneable<LogonRecord>, IBufferMessage
	{
		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x06009325 RID: 37669 RVA: 0x0023A4A0 File Offset: 0x002386A0
		[DebuggerNonUserCode]
		public static MessageParser<LogonRecord> Parser
		{
			get
			{
				return LogonRecord._parser;
			}
		}

		// Token: 0x17002DF3 RID: 11763
		// (get) Token: 0x06009326 RID: 37670 RVA: 0x0023A4B8 File Offset: 0x002386B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x06009327 RID: 37671 RVA: 0x0023A4DC File Offset: 0x002386DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonRecord.Descriptor;
			}
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x0023A4F3 File Offset: 0x002386F3
		[DebuggerNonUserCode]
		public LogonRecord()
		{
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x0023A508 File Offset: 0x00238708
		[DebuggerNonUserCode]
		public LogonRecord(LogonRecord other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.gameAccount_ = other.gameAccount_.Clone();
			this.battleTag_ = other.battleTag_;
			this.geoipCountry_ = other.geoipCountry_;
			this.sessionKey_ = other.sessionKey_;
			this.employeeOnlyMode_ = other.employeeOnlyMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x0023A588 File Offset: 0x00238788
		[DebuggerNonUserCode]
		public LogonRecord Clone()
		{
			return new LogonRecord(this);
		}

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x0600932B RID: 37675 RVA: 0x0023A5A0 File Offset: 0x002387A0
		// (set) Token: 0x0600932C RID: 37676 RVA: 0x0023A5D1 File Offset: 0x002387D1
		[DebuggerNonUserCode]
		public ulong AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = LogonRecord.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x0600932D RID: 37677 RVA: 0x0023A5EC File Offset: 0x002387EC
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600932E RID: 37678 RVA: 0x0023A609 File Offset: 0x00238809
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x0600932F RID: 37679 RVA: 0x0023A61C File Offset: 0x0023881C
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x06009330 RID: 37680 RVA: 0x0023A634 File Offset: 0x00238834
		// (set) Token: 0x06009331 RID: 37681 RVA: 0x0023A655 File Offset: 0x00238855
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? LogonRecord.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x06009332 RID: 37682 RVA: 0x0023A66C File Offset: 0x0023886C
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06009333 RID: 37683 RVA: 0x0023A687 File Offset: 0x00238887
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x06009334 RID: 37684 RVA: 0x0023A694 File Offset: 0x00238894
		// (set) Token: 0x06009335 RID: 37685 RVA: 0x0023A6B5 File Offset: 0x002388B5
		[DebuggerNonUserCode]
		public string GeoipCountry
		{
			get
			{
				return this.geoipCountry_ ?? LogonRecord.GeoipCountryDefaultValue;
			}
			set
			{
				this.geoipCountry_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x06009336 RID: 37686 RVA: 0x0023A6CC File Offset: 0x002388CC
		[DebuggerNonUserCode]
		public bool HasGeoipCountry
		{
			get
			{
				return this.geoipCountry_ != null;
			}
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x0023A6E7 File Offset: 0x002388E7
		[DebuggerNonUserCode]
		public void ClearGeoipCountry()
		{
			this.geoipCountry_ = null;
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x06009338 RID: 37688 RVA: 0x0023A6F4 File Offset: 0x002388F4
		// (set) Token: 0x06009339 RID: 37689 RVA: 0x0023A715 File Offset: 0x00238915
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? LogonRecord.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600933A RID: 37690 RVA: 0x0023A72C File Offset: 0x0023892C
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x0600933B RID: 37691 RVA: 0x0023A74A File Offset: 0x0023894A
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600933C RID: 37692 RVA: 0x0023A754 File Offset: 0x00238954
		// (set) Token: 0x0600933D RID: 37693 RVA: 0x0023A785 File Offset: 0x00238985
		[DebuggerNonUserCode]
		public bool EmployeeOnlyMode
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool employeeOnlyModeDefaultValue;
				if (flag)
				{
					employeeOnlyModeDefaultValue = this.employeeOnlyMode_;
				}
				else
				{
					employeeOnlyModeDefaultValue = LogonRecord.EmployeeOnlyModeDefaultValue;
				}
				return employeeOnlyModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.employeeOnlyMode_ = value;
			}
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600933E RID: 37694 RVA: 0x0023A7A0 File Offset: 0x002389A0
		[DebuggerNonUserCode]
		public bool HasEmployeeOnlyMode
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x0023A7BD File Offset: 0x002389BD
		[DebuggerNonUserCode]
		public void ClearEmployeeOnlyMode()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009340 RID: 37696 RVA: 0x0023A7D0 File Offset: 0x002389D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonRecord);
		}

		// Token: 0x06009341 RID: 37697 RVA: 0x0023A7F0 File Offset: 0x002389F0
		[DebuggerNonUserCode]
		public bool Equals(LogonRecord other)
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
					bool flag4 = this.AccountId != other.AccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.gameAccount_.Equals(other.gameAccount_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BattleTag != other.BattleTag;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.GeoipCountry != other.GeoipCountry;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.SessionKey != other.SessionKey;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.EmployeeOnlyMode != other.EmployeeOnlyMode;
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

		// Token: 0x06009342 RID: 37698 RVA: 0x0023A8DC File Offset: 0x00238ADC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			num ^= this.gameAccount_.GetHashCode();
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool hasGeoipCountry = this.HasGeoipCountry;
			if (hasGeoipCountry)
			{
				num ^= this.GeoipCountry.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool hasEmployeeOnlyMode = this.HasEmployeeOnlyMode;
			if (hasEmployeeOnlyMode)
			{
				num ^= this.EmployeeOnlyMode.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009343 RID: 37699 RVA: 0x0023A9A8 File Offset: 0x00238BA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009344 RID: 37700 RVA: 0x0023A9C0 File Offset: 0x00238BC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009345 RID: 37701 RVA: 0x0023A9CC File Offset: 0x00238BCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			this.gameAccount_.WriteTo(ref output, LogonRecord._repeated_gameAccount_codec);
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(26);
				output.WriteString(this.BattleTag);
			}
			bool hasGeoipCountry = this.HasGeoipCountry;
			if (hasGeoipCountry)
			{
				output.WriteRawTag(34);
				output.WriteString(this.GeoipCountry);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.SessionKey);
			}
			bool hasEmployeeOnlyMode = this.HasEmployeeOnlyMode;
			if (hasEmployeeOnlyMode)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.EmployeeOnlyMode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x0023AAB8 File Offset: 0x00238CB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			num += this.gameAccount_.CalculateSize(LogonRecord._repeated_gameAccount_codec);
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool hasGeoipCountry = this.HasGeoipCountry;
			if (hasGeoipCountry)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GeoipCountry);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool hasEmployeeOnlyMode = this.HasEmployeeOnlyMode;
			if (hasEmployeeOnlyMode)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x0023AB88 File Offset: 0x00238D88
		[DebuggerNonUserCode]
		public void MergeFrom(LogonRecord other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				this.gameAccount_.Add(other.gameAccount_);
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				bool hasGeoipCountry = other.HasGeoipCountry;
				if (hasGeoipCountry)
				{
					this.GeoipCountry = other.GeoipCountry;
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool hasEmployeeOnlyMode = other.HasEmployeeOnlyMode;
				if (hasEmployeeOnlyMode)
				{
					this.EmployeeOnlyMode = other.EmployeeOnlyMode;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009348 RID: 37704 RVA: 0x0023AC4E File Offset: 0x00238E4E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009349 RID: 37705 RVA: 0x0023AC5C File Offset: 0x00238E5C
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
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0039;
							}
							this.BattleTag = input.ReadString();
						}
						else
						{
							this.gameAccount_.AddEntriesFrom(ref input, LogonRecord._repeated_gameAccount_codec);
						}
					}
					else
					{
						this.AccountId = input.ReadUInt64();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.EmployeeOnlyMode = input.ReadBool();
					}
					else
					{
						this.SessionKey = input.ReadBytes();
					}
				}
				else
				{
					this.GeoipCountry = input.ReadString();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004270 RID: 17008
		private static readonly MessageParser<LogonRecord> _parser = new MessageParser<LogonRecord>(() => new LogonRecord());

		// Token: 0x04004271 RID: 17009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004272 RID: 17010
		private int _hasBits0;

		// Token: 0x04004273 RID: 17011
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04004274 RID: 17012
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04004275 RID: 17013
		private ulong accountId_;

		// Token: 0x04004276 RID: 17014
		public const int GameAccountFieldNumber = 2;

		// Token: 0x04004277 RID: 17015
		private static readonly FieldCodec<GameAccountHandle> _repeated_gameAccount_codec = FieldCodec.ForMessage<GameAccountHandle>(18U, GameAccountHandle.Parser);

		// Token: 0x04004278 RID: 17016
		private readonly RepeatedField<GameAccountHandle> gameAccount_ = new RepeatedField<GameAccountHandle>();

		// Token: 0x04004279 RID: 17017
		public const int BattleTagFieldNumber = 3;

		// Token: 0x0400427A RID: 17018
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x0400427B RID: 17019
		private string battleTag_;

		// Token: 0x0400427C RID: 17020
		public const int GeoipCountryFieldNumber = 4;

		// Token: 0x0400427D RID: 17021
		private static readonly string GeoipCountryDefaultValue = "";

		// Token: 0x0400427E RID: 17022
		private string geoipCountry_;

		// Token: 0x0400427F RID: 17023
		public const int SessionKeyFieldNumber = 5;

		// Token: 0x04004280 RID: 17024
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04004281 RID: 17025
		private ByteString sessionKey_;

		// Token: 0x04004282 RID: 17026
		public const int EmployeeOnlyModeFieldNumber = 6;

		// Token: 0x04004283 RID: 17027
		private static readonly bool EmployeeOnlyModeDefaultValue = false;

		// Token: 0x04004284 RID: 17028
		private bool employeeOnlyMode_;
	}
}
