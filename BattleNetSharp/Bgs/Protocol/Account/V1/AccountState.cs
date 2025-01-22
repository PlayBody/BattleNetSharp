using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200074C RID: 1868
	public sealed class AccountState : IMessage<AccountState>, IMessage, IEquatable<AccountState>, IDeepCloneable<AccountState>, IBufferMessage
	{
		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600ABF9 RID: 44025 RVA: 0x0029DDF8 File Offset: 0x0029BFF8
		[DebuggerNonUserCode]
		public static MessageParser<AccountState> Parser
		{
			get
			{
				return AccountState._parser;
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x0029DE10 File Offset: 0x0029C010
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600ABFB RID: 44027 RVA: 0x0029DE34 File Offset: 0x0029C034
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountState.Descriptor;
			}
		}

		// Token: 0x0600ABFC RID: 44028 RVA: 0x0029DE4B File Offset: 0x0029C04B
		[DebuggerNonUserCode]
		public AccountState()
		{
		}

		// Token: 0x0600ABFD RID: 44029 RVA: 0x0029DE78 File Offset: 0x0029C078
		[DebuggerNonUserCode]
		public AccountState(AccountState other)
			: this()
		{
			this.accountLevelInfo_ = ((other.accountLevelInfo_ != null) ? other.accountLevelInfo_.Clone() : null);
			this.privacyInfo_ = ((other.privacyInfo_ != null) ? other.privacyInfo_.Clone() : null);
			this.parentalControlInfo_ = ((other.parentalControlInfo_ != null) ? other.parentalControlInfo_.Clone() : null);
			this.gameLevelInfo_ = other.gameLevelInfo_.Clone();
			this.gameStatus_ = other.gameStatus_.Clone();
			this.gameAccounts_ = other.gameAccounts_.Clone();
			this.securityStatus_ = ((other.securityStatus_ != null) ? other.securityStatus_.Clone() : null);
			this.governmentCurfew_ = ((other.governmentCurfew_ != null) ? other.governmentCurfew_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x0029DF60 File Offset: 0x0029C160
		[DebuggerNonUserCode]
		public AccountState Clone()
		{
			return new AccountState(this);
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600ABFF RID: 44031 RVA: 0x0029DF78 File Offset: 0x0029C178
		// (set) Token: 0x0600AC00 RID: 44032 RVA: 0x0029DF90 File Offset: 0x0029C190
		[DebuggerNonUserCode]
		public AccountLevelInfo AccountLevelInfo
		{
			get
			{
				return this.accountLevelInfo_;
			}
			set
			{
				this.accountLevelInfo_ = value;
			}
		}

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600AC01 RID: 44033 RVA: 0x0029DF9C File Offset: 0x0029C19C
		// (set) Token: 0x0600AC02 RID: 44034 RVA: 0x0029DFB4 File Offset: 0x0029C1B4
		[DebuggerNonUserCode]
		public PrivacyInfo PrivacyInfo
		{
			get
			{
				return this.privacyInfo_;
			}
			set
			{
				this.privacyInfo_ = value;
			}
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x0029DFC0 File Offset: 0x0029C1C0
		// (set) Token: 0x0600AC04 RID: 44036 RVA: 0x0029DFD8 File Offset: 0x0029C1D8
		[DebuggerNonUserCode]
		public ParentalControlInfo ParentalControlInfo
		{
			get
			{
				return this.parentalControlInfo_;
			}
			set
			{
				this.parentalControlInfo_ = value;
			}
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0600AC05 RID: 44037 RVA: 0x0029DFE4 File Offset: 0x0029C1E4
		[DebuggerNonUserCode]
		public RepeatedField<GameLevelInfo> GameLevelInfo
		{
			get
			{
				return this.gameLevelInfo_;
			}
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0600AC06 RID: 44038 RVA: 0x0029DFFC File Offset: 0x0029C1FC
		[DebuggerNonUserCode]
		public RepeatedField<GameStatus> GameStatus
		{
			get
			{
				return this.gameStatus_;
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x0029E014 File Offset: 0x0029C214
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountList> GameAccounts
		{
			get
			{
				return this.gameAccounts_;
			}
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0600AC08 RID: 44040 RVA: 0x0029E02C File Offset: 0x0029C22C
		// (set) Token: 0x0600AC09 RID: 44041 RVA: 0x0029E044 File Offset: 0x0029C244
		[DebuggerNonUserCode]
		public SecurityStatus SecurityStatus
		{
			get
			{
				return this.securityStatus_;
			}
			set
			{
				this.securityStatus_ = value;
			}
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0600AC0A RID: 44042 RVA: 0x0029E050 File Offset: 0x0029C250
		// (set) Token: 0x0600AC0B RID: 44043 RVA: 0x0029E068 File Offset: 0x0029C268
		[DebuggerNonUserCode]
		public PlayScheduleRestriction GovernmentCurfew
		{
			get
			{
				return this.governmentCurfew_;
			}
			set
			{
				this.governmentCurfew_ = value;
			}
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x0029E074 File Offset: 0x0029C274
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountState);
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x0029E094 File Offset: 0x0029C294
		[DebuggerNonUserCode]
		public bool Equals(AccountState other)
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
					bool flag4 = !object.Equals(this.AccountLevelInfo, other.AccountLevelInfo);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.PrivacyInfo, other.PrivacyInfo);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ParentalControlInfo, other.ParentalControlInfo);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.gameLevelInfo_.Equals(other.gameLevelInfo_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.gameStatus_.Equals(other.gameStatus_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.gameAccounts_.Equals(other.gameAccounts_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.SecurityStatus, other.SecurityStatus);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.GovernmentCurfew, other.GovernmentCurfew);
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

		// Token: 0x0600AC0E RID: 44046 RVA: 0x0029E1D4 File Offset: 0x0029C3D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountLevelInfo_ != null;
			if (flag)
			{
				num ^= this.AccountLevelInfo.GetHashCode();
			}
			bool flag2 = this.privacyInfo_ != null;
			if (flag2)
			{
				num ^= this.PrivacyInfo.GetHashCode();
			}
			bool flag3 = this.parentalControlInfo_ != null;
			if (flag3)
			{
				num ^= this.ParentalControlInfo.GetHashCode();
			}
			num ^= this.gameLevelInfo_.GetHashCode();
			num ^= this.gameStatus_.GetHashCode();
			num ^= this.gameAccounts_.GetHashCode();
			bool flag4 = this.securityStatus_ != null;
			if (flag4)
			{
				num ^= this.SecurityStatus.GetHashCode();
			}
			bool flag5 = this.governmentCurfew_ != null;
			if (flag5)
			{
				num ^= this.GovernmentCurfew.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x0029E2C0 File Offset: 0x0029C4C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x0029E2D8 File Offset: 0x0029C4D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC11 RID: 44049 RVA: 0x0029E2E4 File Offset: 0x0029C4E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountLevelInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountLevelInfo);
			}
			bool flag2 = this.privacyInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PrivacyInfo);
			}
			bool flag3 = this.parentalControlInfo_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ParentalControlInfo);
			}
			this.gameLevelInfo_.WriteTo(ref output, AccountState._repeated_gameLevelInfo_codec);
			this.gameStatus_.WriteTo(ref output, AccountState._repeated_gameStatus_codec);
			this.gameAccounts_.WriteTo(ref output, AccountState._repeated_gameAccounts_codec);
			bool flag4 = this.securityStatus_ != null;
			if (flag4)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SecurityStatus);
			}
			bool flag5 = this.governmentCurfew_ != null;
			if (flag5)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GovernmentCurfew);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x0029E404 File Offset: 0x0029C604
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountLevelInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountLevelInfo);
			}
			bool flag2 = this.privacyInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PrivacyInfo);
			}
			bool flag3 = this.parentalControlInfo_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ParentalControlInfo);
			}
			num += this.gameLevelInfo_.CalculateSize(AccountState._repeated_gameLevelInfo_codec);
			num += this.gameStatus_.CalculateSize(AccountState._repeated_gameStatus_codec);
			num += this.gameAccounts_.CalculateSize(AccountState._repeated_gameAccounts_codec);
			bool flag4 = this.securityStatus_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SecurityStatus);
			}
			bool flag5 = this.governmentCurfew_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GovernmentCurfew);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x0029E514 File Offset: 0x0029C714
		[DebuggerNonUserCode]
		public void MergeFrom(AccountState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountLevelInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.accountLevelInfo_ == null;
					if (flag3)
					{
						this.AccountLevelInfo = new AccountLevelInfo();
					}
					this.AccountLevelInfo.MergeFrom(other.AccountLevelInfo);
				}
				bool flag4 = other.privacyInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.privacyInfo_ == null;
					if (flag5)
					{
						this.PrivacyInfo = new PrivacyInfo();
					}
					this.PrivacyInfo.MergeFrom(other.PrivacyInfo);
				}
				bool flag6 = other.parentalControlInfo_ != null;
				if (flag6)
				{
					bool flag7 = this.parentalControlInfo_ == null;
					if (flag7)
					{
						this.ParentalControlInfo = new ParentalControlInfo();
					}
					this.ParentalControlInfo.MergeFrom(other.ParentalControlInfo);
				}
				this.gameLevelInfo_.Add(other.gameLevelInfo_);
				this.gameStatus_.Add(other.gameStatus_);
				this.gameAccounts_.Add(other.gameAccounts_);
				bool flag8 = other.securityStatus_ != null;
				if (flag8)
				{
					bool flag9 = this.securityStatus_ == null;
					if (flag9)
					{
						this.SecurityStatus = new SecurityStatus();
					}
					this.SecurityStatus.MergeFrom(other.SecurityStatus);
				}
				bool flag10 = other.governmentCurfew_ != null;
				if (flag10)
				{
					bool flag11 = this.governmentCurfew_ == null;
					if (flag11)
					{
						this.GovernmentCurfew = new PlayScheduleRestriction();
					}
					this.GovernmentCurfew.MergeFrom(other.GovernmentCurfew);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x0029E6B7 File Offset: 0x0029C8B7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC15 RID: 44053 RVA: 0x0029E6C4 File Offset: 0x0029C8C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 42U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0067;
							}
							bool flag = this.privacyInfo_ == null;
							if (flag)
							{
								this.PrivacyInfo = new PrivacyInfo();
							}
							input.ReadMessage(this.PrivacyInfo);
						}
						else
						{
							bool flag2 = this.accountLevelInfo_ == null;
							if (flag2)
							{
								this.AccountLevelInfo = new AccountLevelInfo();
							}
							input.ReadMessage(this.AccountLevelInfo);
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 42U)
						{
							goto IL_0067;
						}
						this.gameLevelInfo_.AddEntriesFrom(ref input, AccountState._repeated_gameLevelInfo_codec);
					}
					else
					{
						bool flag3 = this.parentalControlInfo_ == null;
						if (flag3)
						{
							this.ParentalControlInfo = new ParentalControlInfo();
						}
						input.ReadMessage(this.ParentalControlInfo);
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_0067;
						}
						this.gameAccounts_.AddEntriesFrom(ref input, AccountState._repeated_gameAccounts_codec);
					}
					else
					{
						this.gameStatus_.AddEntriesFrom(ref input, AccountState._repeated_gameStatus_codec);
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 74U)
					{
						goto IL_0067;
					}
					bool flag4 = this.governmentCurfew_ == null;
					if (flag4)
					{
						this.GovernmentCurfew = new PlayScheduleRestriction();
					}
					input.ReadMessage(this.GovernmentCurfew);
				}
				else
				{
					bool flag5 = this.securityStatus_ == null;
					if (flag5)
					{
						this.SecurityStatus = new SecurityStatus();
					}
					input.ReadMessage(this.SecurityStatus);
				}
				continue;
				IL_0067:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D78 RID: 19832
		private static readonly MessageParser<AccountState> _parser = new MessageParser<AccountState>(() => new AccountState());

		// Token: 0x04004D79 RID: 19833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D7A RID: 19834
		public const int AccountLevelInfoFieldNumber = 1;

		// Token: 0x04004D7B RID: 19835
		private AccountLevelInfo accountLevelInfo_;

		// Token: 0x04004D7C RID: 19836
		public const int PrivacyInfoFieldNumber = 2;

		// Token: 0x04004D7D RID: 19837
		private PrivacyInfo privacyInfo_;

		// Token: 0x04004D7E RID: 19838
		public const int ParentalControlInfoFieldNumber = 3;

		// Token: 0x04004D7F RID: 19839
		private ParentalControlInfo parentalControlInfo_;

		// Token: 0x04004D80 RID: 19840
		public const int GameLevelInfoFieldNumber = 5;

		// Token: 0x04004D81 RID: 19841
		private static readonly FieldCodec<GameLevelInfo> _repeated_gameLevelInfo_codec = FieldCodec.ForMessage<GameLevelInfo>(42U, Bgs.Protocol.Account.V1.GameLevelInfo.Parser);

		// Token: 0x04004D82 RID: 19842
		private readonly RepeatedField<GameLevelInfo> gameLevelInfo_ = new RepeatedField<GameLevelInfo>();

		// Token: 0x04004D83 RID: 19843
		public const int GameStatusFieldNumber = 6;

		// Token: 0x04004D84 RID: 19844
		private static readonly FieldCodec<GameStatus> _repeated_gameStatus_codec = FieldCodec.ForMessage<GameStatus>(50U, Bgs.Protocol.Account.V1.GameStatus.Parser);

		// Token: 0x04004D85 RID: 19845
		private readonly RepeatedField<GameStatus> gameStatus_ = new RepeatedField<GameStatus>();

		// Token: 0x04004D86 RID: 19846
		public const int GameAccountsFieldNumber = 7;

		// Token: 0x04004D87 RID: 19847
		private static readonly FieldCodec<GameAccountList> _repeated_gameAccounts_codec = FieldCodec.ForMessage<GameAccountList>(58U, GameAccountList.Parser);

		// Token: 0x04004D88 RID: 19848
		private readonly RepeatedField<GameAccountList> gameAccounts_ = new RepeatedField<GameAccountList>();

		// Token: 0x04004D89 RID: 19849
		public const int SecurityStatusFieldNumber = 8;

		// Token: 0x04004D8A RID: 19850
		private SecurityStatus securityStatus_;

		// Token: 0x04004D8B RID: 19851
		public const int GovernmentCurfewFieldNumber = 9;

		// Token: 0x04004D8C RID: 19852
		private PlayScheduleRestriction governmentCurfew_;
	}
}
