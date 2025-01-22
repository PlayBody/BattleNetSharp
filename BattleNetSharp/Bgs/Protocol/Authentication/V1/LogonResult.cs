using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000609 RID: 1545
	public sealed class LogonResult : IMessage<LogonResult>, IMessage, IEquatable<LogonResult>, IDeepCloneable<LogonResult>, IBufferMessage
	{
		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600909A RID: 37018 RVA: 0x002313BC File Offset: 0x0022F5BC
		[DebuggerNonUserCode]
		public static MessageParser<LogonResult> Parser
		{
			get
			{
				return LogonResult._parser;
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600909B RID: 37019 RVA: 0x002313D4 File Offset: 0x0022F5D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0600909C RID: 37020 RVA: 0x002313F8 File Offset: 0x0022F5F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonResult.Descriptor;
			}
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x0023140F File Offset: 0x0022F60F
		[DebuggerNonUserCode]
		public LogonResult()
		{
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x00231430 File Offset: 0x0022F630
		[DebuggerNonUserCode]
		public LogonResult(LogonResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.gameAccountId_ = other.gameAccountId_.Clone();
			this.email_ = other.email_;
			this.availableRegion_ = other.availableRegion_.Clone();
			this.connectedRegion_ = other.connectedRegion_;
			this.battleTag_ = other.battleTag_;
			this.geoipCountry_ = other.geoipCountry_;
			this.sessionKey_ = other.sessionKey_;
			this.restrictedMode_ = other.restrictedMode_;
			this.clientId_ = other.clientId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600909F RID: 37023 RVA: 0x00231500 File Offset: 0x0022F700
		[DebuggerNonUserCode]
		public LogonResult Clone()
		{
			return new LogonResult(this);
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x060090A0 RID: 37024 RVA: 0x00231518 File Offset: 0x0022F718
		// (set) Token: 0x060090A1 RID: 37025 RVA: 0x00231549 File Offset: 0x0022F749
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = LogonResult.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x060090A2 RID: 37026 RVA: 0x00231564 File Offset: 0x0022F764
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x00231581 File Offset: 0x0022F781
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x060090A4 RID: 37028 RVA: 0x00231594 File Offset: 0x0022F794
		// (set) Token: 0x060090A5 RID: 37029 RVA: 0x002315AC File Offset: 0x0022F7AC
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x002315B8 File Offset: 0x0022F7B8
		[DebuggerNonUserCode]
		public RepeatedField<EntityId> GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x060090A7 RID: 37031 RVA: 0x002315D0 File Offset: 0x0022F7D0
		// (set) Token: 0x060090A8 RID: 37032 RVA: 0x002315F1 File Offset: 0x0022F7F1
		[DebuggerNonUserCode]
		public string Email
		{
			get
			{
				return this.email_ ?? LogonResult.EmailDefaultValue;
			}
			set
			{
				this.email_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x060090A9 RID: 37033 RVA: 0x00231608 File Offset: 0x0022F808
		[DebuggerNonUserCode]
		public bool HasEmail
		{
			get
			{
				return this.email_ != null;
			}
		}

		// Token: 0x060090AA RID: 37034 RVA: 0x00231623 File Offset: 0x0022F823
		[DebuggerNonUserCode]
		public void ClearEmail()
		{
			this.email_ = null;
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x060090AB RID: 37035 RVA: 0x00231630 File Offset: 0x0022F830
		[DebuggerNonUserCode]
		public RepeatedField<uint> AvailableRegion
		{
			get
			{
				return this.availableRegion_;
			}
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x060090AC RID: 37036 RVA: 0x00231648 File Offset: 0x0022F848
		// (set) Token: 0x060090AD RID: 37037 RVA: 0x00231679 File Offset: 0x0022F879
		[DebuggerNonUserCode]
		public uint ConnectedRegion
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint connectedRegionDefaultValue;
				if (flag)
				{
					connectedRegionDefaultValue = this.connectedRegion_;
				}
				else
				{
					connectedRegionDefaultValue = LogonResult.ConnectedRegionDefaultValue;
				}
				return connectedRegionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.connectedRegion_ = value;
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x060090AE RID: 37038 RVA: 0x00231694 File Offset: 0x0022F894
		[DebuggerNonUserCode]
		public bool HasConnectedRegion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060090AF RID: 37039 RVA: 0x002316B1 File Offset: 0x0022F8B1
		[DebuggerNonUserCode]
		public void ClearConnectedRegion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x060090B0 RID: 37040 RVA: 0x002316C4 File Offset: 0x0022F8C4
		// (set) Token: 0x060090B1 RID: 37041 RVA: 0x002316E5 File Offset: 0x0022F8E5
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? LogonResult.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x002316FC File Offset: 0x0022F8FC
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x00231717 File Offset: 0x0022F917
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x060090B4 RID: 37044 RVA: 0x00231724 File Offset: 0x0022F924
		// (set) Token: 0x060090B5 RID: 37045 RVA: 0x00231745 File Offset: 0x0022F945
		[DebuggerNonUserCode]
		public string GeoipCountry
		{
			get
			{
				return this.geoipCountry_ ?? LogonResult.GeoipCountryDefaultValue;
			}
			set
			{
				this.geoipCountry_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x060090B6 RID: 37046 RVA: 0x0023175C File Offset: 0x0022F95C
		[DebuggerNonUserCode]
		public bool HasGeoipCountry
		{
			get
			{
				return this.geoipCountry_ != null;
			}
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x00231777 File Offset: 0x0022F977
		[DebuggerNonUserCode]
		public void ClearGeoipCountry()
		{
			this.geoipCountry_ = null;
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x060090B8 RID: 37048 RVA: 0x00231784 File Offset: 0x0022F984
		// (set) Token: 0x060090B9 RID: 37049 RVA: 0x002317A5 File Offset: 0x0022F9A5
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? LogonResult.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x002317BC File Offset: 0x0022F9BC
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x002317DA File Offset: 0x0022F9DA
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x002317E4 File Offset: 0x0022F9E4
		// (set) Token: 0x060090BD RID: 37053 RVA: 0x00231815 File Offset: 0x0022FA15
		[DebuggerNonUserCode]
		public bool RestrictedMode
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool restrictedModeDefaultValue;
				if (flag)
				{
					restrictedModeDefaultValue = this.restrictedMode_;
				}
				else
				{
					restrictedModeDefaultValue = LogonResult.RestrictedModeDefaultValue;
				}
				return restrictedModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.restrictedMode_ = value;
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x00231830 File Offset: 0x0022FA30
		[DebuggerNonUserCode]
		public bool HasRestrictedMode
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060090BF RID: 37055 RVA: 0x0023184D File Offset: 0x0022FA4D
		[DebuggerNonUserCode]
		public void ClearRestrictedMode()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x00231860 File Offset: 0x0022FA60
		// (set) Token: 0x060090C1 RID: 37057 RVA: 0x00231881 File Offset: 0x0022FA81
		[DebuggerNonUserCode]
		public string ClientId
		{
			get
			{
				return this.clientId_ ?? LogonResult.ClientIdDefaultValue;
			}
			set
			{
				this.clientId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x060090C2 RID: 37058 RVA: 0x00231898 File Offset: 0x0022FA98
		[DebuggerNonUserCode]
		public bool HasClientId
		{
			get
			{
				return this.clientId_ != null;
			}
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x002318B3 File Offset: 0x0022FAB3
		[DebuggerNonUserCode]
		public void ClearClientId()
		{
			this.clientId_ = null;
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x002318C0 File Offset: 0x0022FAC0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonResult);
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x002318E0 File Offset: 0x0022FAE0
		[DebuggerNonUserCode]
		public bool Equals(LogonResult other)
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
					bool flag4 = this.ErrorCode != other.ErrorCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AccountId, other.AccountId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.gameAccountId_.Equals(other.gameAccountId_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Email != other.Email;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.availableRegion_.Equals(other.availableRegion_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ConnectedRegion != other.ConnectedRegion;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.BattleTag != other.BattleTag;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.GeoipCountry != other.GeoipCountry;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.SessionKey != other.SessionKey;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.RestrictedMode != other.RestrictedMode;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.ClientId != other.ClientId;
															flag2 = !flag14 && object.Equals(this._unknownFields, other._unknownFields);
														}
													}
												}
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

		// Token: 0x060090C6 RID: 37062 RVA: 0x00231A68 File Offset: 0x0022FC68
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			num ^= this.gameAccountId_.GetHashCode();
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num ^= this.Email.GetHashCode();
			}
			num ^= this.availableRegion_.GetHashCode();
			bool hasConnectedRegion = this.HasConnectedRegion;
			if (hasConnectedRegion)
			{
				num ^= this.ConnectedRegion.GetHashCode();
			}
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
			bool hasRestrictedMode = this.HasRestrictedMode;
			if (hasRestrictedMode)
			{
				num ^= this.RestrictedMode.GetHashCode();
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num ^= this.ClientId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x00231BB0 File Offset: 0x0022FDB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x00231BC8 File Offset: 0x0022FDC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x00231BD4 File Offset: 0x0022FDD4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrorCode);
			}
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AccountId);
			}
			this.gameAccountId_.WriteTo(ref output, LogonResult._repeated_gameAccountId_codec);
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Email);
			}
			this.availableRegion_.WriteTo(ref output, LogonResult._repeated_availableRegion_codec);
			bool hasConnectedRegion = this.HasConnectedRegion;
			if (hasConnectedRegion)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ConnectedRegion);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(58);
				output.WriteString(this.BattleTag);
			}
			bool hasGeoipCountry = this.HasGeoipCountry;
			if (hasGeoipCountry)
			{
				output.WriteRawTag(66);
				output.WriteString(this.GeoipCountry);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.SessionKey);
			}
			bool hasRestrictedMode = this.HasRestrictedMode;
			if (hasRestrictedMode)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.RestrictedMode);
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x00231D64 File Offset: 0x0022FF64
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			num += this.gameAccountId_.CalculateSize(LogonResult._repeated_gameAccountId_codec);
			bool hasEmail = this.HasEmail;
			if (hasEmail)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Email);
			}
			num += this.availableRegion_.CalculateSize(LogonResult._repeated_availableRegion_codec);
			bool hasConnectedRegion = this.HasConnectedRegion;
			if (hasConnectedRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConnectedRegion);
			}
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
			bool hasRestrictedMode = this.HasRestrictedMode;
			if (hasRestrictedMode)
			{
				num += 2;
			}
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x00231EC0 File Offset: 0x002300C0
		[DebuggerNonUserCode]
		public void MergeFrom(LogonResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				bool flag2 = other.accountId_ != null;
				if (flag2)
				{
					bool flag3 = this.accountId_ == null;
					if (flag3)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				this.gameAccountId_.Add(other.gameAccountId_);
				bool hasEmail = other.HasEmail;
				if (hasEmail)
				{
					this.Email = other.Email;
				}
				this.availableRegion_.Add(other.availableRegion_);
				bool hasConnectedRegion = other.HasConnectedRegion;
				if (hasConnectedRegion)
				{
					this.ConnectedRegion = other.ConnectedRegion;
				}
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
				bool hasRestrictedMode = other.HasRestrictedMode;
				if (hasRestrictedMode)
				{
					this.RestrictedMode = other.RestrictedMode;
				}
				bool hasClientId = other.HasClientId;
				if (hasClientId)
				{
					this.ClientId = other.ClientId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x00232029 File Offset: 0x00230229
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x00232034 File Offset: 0x00230234
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
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_0091;
								}
								this.gameAccountId_.AddEntriesFrom(ref input, LogonResult._repeated_gameAccountId_codec);
							}
							else
							{
								bool flag = this.accountId_ == null;
								if (flag)
								{
									this.AccountId = new EntityId();
								}
								input.ReadMessage(this.AccountId);
							}
						}
						else
						{
							this.ErrorCode = input.ReadUInt32();
						}
					}
					else if (num3 != 34U)
					{
						if (num3 != 40U && num3 != 42U)
						{
							goto IL_0091;
						}
						this.availableRegion_.AddEntriesFrom(ref input, LogonResult._repeated_availableRegion_codec);
					}
					else
					{
						this.Email = input.ReadString();
					}
				}
				else if (num3 <= 66U)
				{
					if (num3 != 48U)
					{
						if (num3 != 58U)
						{
							if (num3 != 66U)
							{
								goto IL_0091;
							}
							this.GeoipCountry = input.ReadString();
						}
						else
						{
							this.BattleTag = input.ReadString();
						}
					}
					else
					{
						this.ConnectedRegion = input.ReadUInt32();
					}
				}
				else if (num3 != 74U)
				{
					if (num3 != 80U)
					{
						if (num3 != 90U)
						{
							goto IL_0091;
						}
						this.ClientId = input.ReadString();
					}
					else
					{
						this.RestrictedMode = input.ReadBool();
					}
				}
				else
				{
					this.SessionKey = input.ReadBytes();
				}
				continue;
				IL_0091:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400414C RID: 16716
		private static readonly MessageParser<LogonResult> _parser = new MessageParser<LogonResult>(() => new LogonResult());

		// Token: 0x0400414D RID: 16717
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400414E RID: 16718
		private int _hasBits0;

		// Token: 0x0400414F RID: 16719
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004150 RID: 16720
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04004151 RID: 16721
		private uint errorCode_;

		// Token: 0x04004152 RID: 16722
		public const int AccountIdFieldNumber = 2;

		// Token: 0x04004153 RID: 16723
		private EntityId accountId_;

		// Token: 0x04004154 RID: 16724
		public const int GameAccountIdFieldNumber = 3;

		// Token: 0x04004155 RID: 16725
		private static readonly FieldCodec<EntityId> _repeated_gameAccountId_codec = FieldCodec.ForMessage<EntityId>(26U, EntityId.Parser);

		// Token: 0x04004156 RID: 16726
		private readonly RepeatedField<EntityId> gameAccountId_ = new RepeatedField<EntityId>();

		// Token: 0x04004157 RID: 16727
		public const int EmailFieldNumber = 4;

		// Token: 0x04004158 RID: 16728
		private static readonly string EmailDefaultValue = "";

		// Token: 0x04004159 RID: 16729
		private string email_;

		// Token: 0x0400415A RID: 16730
		public const int AvailableRegionFieldNumber = 5;

		// Token: 0x0400415B RID: 16731
		private static readonly FieldCodec<uint> _repeated_availableRegion_codec = FieldCodec.ForUInt32(40U);

		// Token: 0x0400415C RID: 16732
		private readonly RepeatedField<uint> availableRegion_ = new RepeatedField<uint>();

		// Token: 0x0400415D RID: 16733
		public const int ConnectedRegionFieldNumber = 6;

		// Token: 0x0400415E RID: 16734
		private static readonly uint ConnectedRegionDefaultValue = 0U;

		// Token: 0x0400415F RID: 16735
		private uint connectedRegion_;

		// Token: 0x04004160 RID: 16736
		public const int BattleTagFieldNumber = 7;

		// Token: 0x04004161 RID: 16737
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04004162 RID: 16738
		private string battleTag_;

		// Token: 0x04004163 RID: 16739
		public const int GeoipCountryFieldNumber = 8;

		// Token: 0x04004164 RID: 16740
		private static readonly string GeoipCountryDefaultValue = "";

		// Token: 0x04004165 RID: 16741
		private string geoipCountry_;

		// Token: 0x04004166 RID: 16742
		public const int SessionKeyFieldNumber = 9;

		// Token: 0x04004167 RID: 16743
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04004168 RID: 16744
		private ByteString sessionKey_;

		// Token: 0x04004169 RID: 16745
		public const int RestrictedModeFieldNumber = 10;

		// Token: 0x0400416A RID: 16746
		private static readonly bool RestrictedModeDefaultValue = false;

		// Token: 0x0400416B RID: 16747
		private bool restrictedMode_;

		// Token: 0x0400416C RID: 16748
		public const int ClientIdFieldNumber = 11;

		// Token: 0x0400416D RID: 16749
		private static readonly string ClientIdDefaultValue = "";

		// Token: 0x0400416E RID: 16750
		private string clientId_;
	}
}
