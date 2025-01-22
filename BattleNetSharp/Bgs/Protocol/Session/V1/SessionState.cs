using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200054D RID: 1357
	public sealed class SessionState : IMessage<SessionState>, IMessage, IEquatable<SessionState>, IDeepCloneable<SessionState>, IBufferMessage
	{
		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x060082F1 RID: 33521 RVA: 0x001FD5AC File Offset: 0x001FB7AC
		[DebuggerNonUserCode]
		public static MessageParser<SessionState> Parser
		{
			get
			{
				return SessionState._parser;
			}
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x060082F2 RID: 33522 RVA: 0x001FD5C4 File Offset: 0x001FB7C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x060082F3 RID: 33523 RVA: 0x001FD5E8 File Offset: 0x001FB7E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionState.Descriptor;
			}
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x001FD5FF File Offset: 0x001FB7FF
		[DebuggerNonUserCode]
		public SessionState()
		{
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x001FD60C File Offset: 0x001FB80C
		[DebuggerNonUserCode]
		public SessionState(SessionState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.clientAddress_ = other.clientAddress_;
			this.lastTickTime_ = other.lastTickTime_;
			this.createTime_ = other.createTime_;
			this.parentalControlsActive_ = other.parentalControlsActive_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.usingIgrAddress_ = other.usingIgrAddress_;
			this.hasBenefactor_ = other.hasBenefactor_;
			this.igrId_ = ((other.igrId_ != null) ? other.igrId_.Clone() : null);
			this.deductible_ = other.deductible_;
			this.expireTimeMs_ = other.expireTimeMs_;
			this.macAddress_ = other.macAddress_;
			this.igrPaid_ = other.igrPaid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x001FD70C File Offset: 0x001FB90C
		[DebuggerNonUserCode]
		public SessionState Clone()
		{
			return new SessionState(this);
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x060082F7 RID: 33527 RVA: 0x001FD724 File Offset: 0x001FB924
		// (set) Token: 0x060082F8 RID: 33528 RVA: 0x001FD73C File Offset: 0x001FB93C
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

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x060082F9 RID: 33529 RVA: 0x001FD748 File Offset: 0x001FB948
		// (set) Token: 0x060082FA RID: 33530 RVA: 0x001FD769 File Offset: 0x001FB969
		[DebuggerNonUserCode]
		public string ClientAddress
		{
			get
			{
				return this.clientAddress_ ?? SessionState.ClientAddressDefaultValue;
			}
			set
			{
				this.clientAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x060082FB RID: 33531 RVA: 0x001FD780 File Offset: 0x001FB980
		[DebuggerNonUserCode]
		public bool HasClientAddress
		{
			get
			{
				return this.clientAddress_ != null;
			}
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x001FD79B File Offset: 0x001FB99B
		[DebuggerNonUserCode]
		public void ClearClientAddress()
		{
			this.clientAddress_ = null;
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x060082FD RID: 33533 RVA: 0x001FD7A8 File Offset: 0x001FB9A8
		// (set) Token: 0x060082FE RID: 33534 RVA: 0x001FD7D9 File Offset: 0x001FB9D9
		[DebuggerNonUserCode]
		public ulong LastTickTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong lastTickTimeDefaultValue;
				if (flag)
				{
					lastTickTimeDefaultValue = this.lastTickTime_;
				}
				else
				{
					lastTickTimeDefaultValue = SessionState.LastTickTimeDefaultValue;
				}
				return lastTickTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.lastTickTime_ = value;
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x060082FF RID: 33535 RVA: 0x001FD7F4 File Offset: 0x001FB9F4
		[DebuggerNonUserCode]
		public bool HasLastTickTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008300 RID: 33536 RVA: 0x001FD811 File Offset: 0x001FBA11
		[DebuggerNonUserCode]
		public void ClearLastTickTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x06008301 RID: 33537 RVA: 0x001FD824 File Offset: 0x001FBA24
		// (set) Token: 0x06008302 RID: 33538 RVA: 0x001FD855 File Offset: 0x001FBA55
		[DebuggerNonUserCode]
		public ulong CreateTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong createTimeDefaultValue;
				if (flag)
				{
					createTimeDefaultValue = this.createTime_;
				}
				else
				{
					createTimeDefaultValue = SessionState.CreateTimeDefaultValue;
				}
				return createTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.createTime_ = value;
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x06008303 RID: 33539 RVA: 0x001FD870 File Offset: 0x001FBA70
		[DebuggerNonUserCode]
		public bool HasCreateTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x001FD88D File Offset: 0x001FBA8D
		[DebuggerNonUserCode]
		public void ClearCreateTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x06008305 RID: 33541 RVA: 0x001FD8A0 File Offset: 0x001FBAA0
		// (set) Token: 0x06008306 RID: 33542 RVA: 0x001FD8D1 File Offset: 0x001FBAD1
		[DebuggerNonUserCode]
		public bool ParentalControlsActive
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool parentalControlsActiveDefaultValue;
				if (flag)
				{
					parentalControlsActiveDefaultValue = this.parentalControlsActive_;
				}
				else
				{
					parentalControlsActiveDefaultValue = SessionState.ParentalControlsActiveDefaultValue;
				}
				return parentalControlsActiveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.parentalControlsActive_ = value;
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x06008307 RID: 33543 RVA: 0x001FD8EC File Offset: 0x001FBAEC
		[DebuggerNonUserCode]
		public bool HasParentalControlsActive
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008308 RID: 33544 RVA: 0x001FD909 File Offset: 0x001FBB09
		[DebuggerNonUserCode]
		public void ClearParentalControlsActive()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x06008309 RID: 33545 RVA: 0x001FD91C File Offset: 0x001FBB1C
		// (set) Token: 0x0600830A RID: 33546 RVA: 0x001FD934 File Offset: 0x001FBB34
		[DebuggerNonUserCode]
		public GameSessionLocation Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0600830B RID: 33547 RVA: 0x001FD940 File Offset: 0x001FBB40
		// (set) Token: 0x0600830C RID: 33548 RVA: 0x001FD971 File Offset: 0x001FBB71
		[DebuggerNonUserCode]
		public bool UsingIgrAddress
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool usingIgrAddressDefaultValue;
				if (flag)
				{
					usingIgrAddressDefaultValue = this.usingIgrAddress_;
				}
				else
				{
					usingIgrAddressDefaultValue = SessionState.UsingIgrAddressDefaultValue;
				}
				return usingIgrAddressDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.usingIgrAddress_ = value;
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600830D RID: 33549 RVA: 0x001FD98C File Offset: 0x001FBB8C
		[DebuggerNonUserCode]
		public bool HasUsingIgrAddress
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x001FD9A9 File Offset: 0x001FBBA9
		[DebuggerNonUserCode]
		public void ClearUsingIgrAddress()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x0600830F RID: 33551 RVA: 0x001FD9BC File Offset: 0x001FBBBC
		// (set) Token: 0x06008310 RID: 33552 RVA: 0x001FD9EE File Offset: 0x001FBBEE
		[DebuggerNonUserCode]
		public bool HasBenefactor
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool hasBenefactorDefaultValue;
				if (flag)
				{
					hasBenefactorDefaultValue = this.hasBenefactor_;
				}
				else
				{
					hasBenefactorDefaultValue = SessionState.HasBenefactorDefaultValue;
				}
				return hasBenefactorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.hasBenefactor_ = value;
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x06008311 RID: 33553 RVA: 0x001FDA08 File Offset: 0x001FBC08
		[DebuggerNonUserCode]
		public bool HasHasBenefactor
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x001FDA26 File Offset: 0x001FBC26
		[DebuggerNonUserCode]
		public void ClearHasBenefactor()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x06008313 RID: 33555 RVA: 0x001FDA38 File Offset: 0x001FBC38
		// (set) Token: 0x06008314 RID: 33556 RVA: 0x001FDA50 File Offset: 0x001FBC50
		[DebuggerNonUserCode]
		public IgrId IgrId
		{
			get
			{
				return this.igrId_;
			}
			set
			{
				this.igrId_ = value;
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x06008315 RID: 33557 RVA: 0x001FDA5C File Offset: 0x001FBC5C
		// (set) Token: 0x06008316 RID: 33558 RVA: 0x001FDA8E File Offset: 0x001FBC8E
		[DebuggerNonUserCode]
		public bool Deductible
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool deductibleDefaultValue;
				if (flag)
				{
					deductibleDefaultValue = this.deductible_;
				}
				else
				{
					deductibleDefaultValue = SessionState.DeductibleDefaultValue;
				}
				return deductibleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.deductible_ = value;
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x06008317 RID: 33559 RVA: 0x001FDAA8 File Offset: 0x001FBCA8
		[DebuggerNonUserCode]
		public bool HasDeductible
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x001FDAC6 File Offset: 0x001FBCC6
		[DebuggerNonUserCode]
		public void ClearDeductible()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x06008319 RID: 33561 RVA: 0x001FDAD8 File Offset: 0x001FBCD8
		// (set) Token: 0x0600831A RID: 33562 RVA: 0x001FDB0A File Offset: 0x001FBD0A
		[DebuggerNonUserCode]
		public ulong ExpireTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				ulong expireTimeMsDefaultValue;
				if (flag)
				{
					expireTimeMsDefaultValue = this.expireTimeMs_;
				}
				else
				{
					expireTimeMsDefaultValue = SessionState.ExpireTimeMsDefaultValue;
				}
				return expireTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.expireTimeMs_ = value;
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x0600831B RID: 33563 RVA: 0x001FDB24 File Offset: 0x001FBD24
		[DebuggerNonUserCode]
		public bool HasExpireTimeMs
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x001FDB42 File Offset: 0x001FBD42
		[DebuggerNonUserCode]
		public void ClearExpireTimeMs()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x0600831D RID: 33565 RVA: 0x001FDB54 File Offset: 0x001FBD54
		// (set) Token: 0x0600831E RID: 33566 RVA: 0x001FDB75 File Offset: 0x001FBD75
		[DebuggerNonUserCode]
		public string MacAddress
		{
			get
			{
				return this.macAddress_ ?? SessionState.MacAddressDefaultValue;
			}
			set
			{
				this.macAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600831F RID: 33567 RVA: 0x001FDB8C File Offset: 0x001FBD8C
		[DebuggerNonUserCode]
		public bool HasMacAddress
		{
			get
			{
				return this.macAddress_ != null;
			}
		}

		// Token: 0x06008320 RID: 33568 RVA: 0x001FDBA7 File Offset: 0x001FBDA7
		[DebuggerNonUserCode]
		public void ClearMacAddress()
		{
			this.macAddress_ = null;
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x06008321 RID: 33569 RVA: 0x001FDBB4 File Offset: 0x001FBDB4
		// (set) Token: 0x06008322 RID: 33570 RVA: 0x001FDBE9 File Offset: 0x001FBDE9
		[DebuggerNonUserCode]
		public bool IgrPaid
		{
			get
			{
				bool flag = (this._hasBits0 & 128) != 0;
				bool igrPaidDefaultValue;
				if (flag)
				{
					igrPaidDefaultValue = this.igrPaid_;
				}
				else
				{
					igrPaidDefaultValue = SessionState.IgrPaidDefaultValue;
				}
				return igrPaidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 128;
				this.igrPaid_ = value;
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06008323 RID: 33571 RVA: 0x001FDC08 File Offset: 0x001FBE08
		[DebuggerNonUserCode]
		public bool HasIgrPaid
		{
			get
			{
				return (this._hasBits0 & 128) != 0;
			}
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x001FDC29 File Offset: 0x001FBE29
		[DebuggerNonUserCode]
		public void ClearIgrPaid()
		{
			this._hasBits0 &= -129;
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x001FDC40 File Offset: 0x001FBE40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionState);
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x001FDC60 File Offset: 0x001FBE60
		[DebuggerNonUserCode]
		public bool Equals(SessionState other)
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
					bool flag4 = !object.Equals(this.Handle, other.Handle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClientAddress != other.ClientAddress;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LastTickTime != other.LastTickTime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CreateTime != other.CreateTime;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ParentalControlsActive != other.ParentalControlsActive;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.Location, other.Location);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.UsingIgrAddress != other.UsingIgrAddress;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.HasBenefactor != other.HasBenefactor;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.IgrId, other.IgrId);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = this.Deductible != other.Deductible;
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.ExpireTimeMs != other.ExpireTimeMs;
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = this.MacAddress != other.MacAddress;
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.IgrPaid != other.IgrPaid;
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
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
				}
			}
			return flag2;
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x001FDE24 File Offset: 0x001FC024
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num ^= this.Handle.GetHashCode();
			}
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num ^= this.ClientAddress.GetHashCode();
			}
			bool hasLastTickTime = this.HasLastTickTime;
			if (hasLastTickTime)
			{
				num ^= this.LastTickTime.GetHashCode();
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				num ^= this.ParentalControlsActive.GetHashCode();
			}
			bool flag2 = this.location_ != null;
			if (flag2)
			{
				num ^= this.Location.GetHashCode();
			}
			bool hasUsingIgrAddress = this.HasUsingIgrAddress;
			if (hasUsingIgrAddress)
			{
				num ^= this.UsingIgrAddress.GetHashCode();
			}
			bool hasHasBenefactor = this.HasHasBenefactor;
			if (hasHasBenefactor)
			{
				num ^= this.HasBenefactor.GetHashCode();
			}
			bool flag3 = this.igrId_ != null;
			if (flag3)
			{
				num ^= this.IgrId.GetHashCode();
			}
			bool hasDeductible = this.HasDeductible;
			if (hasDeductible)
			{
				num ^= this.Deductible.GetHashCode();
			}
			bool hasExpireTimeMs = this.HasExpireTimeMs;
			if (hasExpireTimeMs)
			{
				num ^= this.ExpireTimeMs.GetHashCode();
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num ^= this.MacAddress.GetHashCode();
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				num ^= this.IgrPaid.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x001FDFD0 File Offset: 0x001FC1D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x001FDFE8 File Offset: 0x001FC1E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x001FDFF4 File Offset: 0x001FC1F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.handle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ClientAddress);
			}
			bool hasLastTickTime = this.HasLastTickTime;
			if (hasLastTickTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.LastTickTime);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.CreateTime);
			}
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.ParentalControlsActive);
			}
			bool flag2 = this.location_ != null;
			if (flag2)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Location);
			}
			bool hasUsingIgrAddress = this.HasUsingIgrAddress;
			if (hasUsingIgrAddress)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.UsingIgrAddress);
			}
			bool hasHasBenefactor = this.HasHasBenefactor;
			if (hasHasBenefactor)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.HasBenefactor);
			}
			bool flag3 = this.igrId_ != null;
			if (flag3)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.IgrId);
			}
			bool hasDeductible = this.HasDeductible;
			if (hasDeductible)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Deductible);
			}
			bool hasExpireTimeMs = this.HasExpireTimeMs;
			if (hasExpireTimeMs)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.ExpireTimeMs);
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				output.WriteRawTag(98);
				output.WriteString(this.MacAddress);
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IgrPaid);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x001FE1F8 File Offset: 0x001FC3F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			bool hasClientAddress = this.HasClientAddress;
			if (hasClientAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientAddress);
			}
			bool hasLastTickTime = this.HasLastTickTime;
			if (hasLastTickTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastTickTime);
			}
			bool hasCreateTime = this.HasCreateTime;
			if (hasCreateTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreateTime);
			}
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				num += 2;
			}
			bool flag2 = this.location_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			bool hasUsingIgrAddress = this.HasUsingIgrAddress;
			if (hasUsingIgrAddress)
			{
				num += 2;
			}
			bool hasHasBenefactor = this.HasHasBenefactor;
			if (hasHasBenefactor)
			{
				num += 2;
			}
			bool flag3 = this.igrId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IgrId);
			}
			bool hasDeductible = this.HasDeductible;
			if (hasDeductible)
			{
				num += 2;
			}
			bool hasExpireTimeMs = this.HasExpireTimeMs;
			if (hasExpireTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpireTimeMs);
			}
			bool hasMacAddress = this.HasMacAddress;
			if (hasMacAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MacAddress);
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				num += 2;
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x001FE37C File Offset: 0x001FC57C
		[DebuggerNonUserCode]
		public void MergeFrom(SessionState other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasClientAddress = other.HasClientAddress;
				if (hasClientAddress)
				{
					this.ClientAddress = other.ClientAddress;
				}
				bool hasLastTickTime = other.HasLastTickTime;
				if (hasLastTickTime)
				{
					this.LastTickTime = other.LastTickTime;
				}
				bool hasCreateTime = other.HasCreateTime;
				if (hasCreateTime)
				{
					this.CreateTime = other.CreateTime;
				}
				bool hasParentalControlsActive = other.HasParentalControlsActive;
				if (hasParentalControlsActive)
				{
					this.ParentalControlsActive = other.ParentalControlsActive;
				}
				bool flag4 = other.location_ != null;
				if (flag4)
				{
					bool flag5 = this.location_ == null;
					if (flag5)
					{
						this.Location = new GameSessionLocation();
					}
					this.Location.MergeFrom(other.Location);
				}
				bool hasUsingIgrAddress = other.HasUsingIgrAddress;
				if (hasUsingIgrAddress)
				{
					this.UsingIgrAddress = other.UsingIgrAddress;
				}
				bool hasHasBenefactor = other.HasHasBenefactor;
				if (hasHasBenefactor)
				{
					this.HasBenefactor = other.HasBenefactor;
				}
				bool flag6 = other.igrId_ != null;
				if (flag6)
				{
					bool flag7 = this.igrId_ == null;
					if (flag7)
					{
						this.IgrId = new IgrId();
					}
					this.IgrId.MergeFrom(other.IgrId);
				}
				bool hasDeductible = other.HasDeductible;
				if (hasDeductible)
				{
					this.Deductible = other.Deductible;
				}
				bool hasExpireTimeMs = other.HasExpireTimeMs;
				if (hasExpireTimeMs)
				{
					this.ExpireTimeMs = other.ExpireTimeMs;
				}
				bool hasMacAddress = other.HasMacAddress;
				if (hasMacAddress)
				{
					this.MacAddress = other.MacAddress;
				}
				bool hasIgrPaid = other.HasIgrPaid;
				if (hasIgrPaid)
				{
					this.IgrPaid = other.IgrPaid;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x001FE577 File Offset: 0x001FC777
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x001FE584 File Offset: 0x001FC784
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 <= 24U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								if (num3 != 24U)
								{
									goto IL_00A1;
								}
								this.LastTickTime = input.ReadUInt64();
							}
							else
							{
								this.ClientAddress = input.ReadString();
							}
						}
						else
						{
							bool flag = this.handle_ == null;
							if (flag)
							{
								this.Handle = new GameAccountHandle();
							}
							input.ReadMessage(this.Handle);
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							if (num3 != 50U)
							{
								goto IL_00A1;
							}
							bool flag2 = this.location_ == null;
							if (flag2)
							{
								this.Location = new GameSessionLocation();
							}
							input.ReadMessage(this.Location);
						}
						else
						{
							this.ParentalControlsActive = input.ReadBool();
						}
					}
					else
					{
						this.CreateTime = input.ReadUInt64();
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							if (num3 != 74U)
							{
								goto IL_00A1;
							}
							bool flag3 = this.igrId_ == null;
							if (flag3)
							{
								this.IgrId = new IgrId();
							}
							input.ReadMessage(this.IgrId);
						}
						else
						{
							this.HasBenefactor = input.ReadBool();
						}
					}
					else
					{
						this.UsingIgrAddress = input.ReadBool();
					}
				}
				else if (num3 <= 88U)
				{
					if (num3 != 80U)
					{
						if (num3 != 88U)
						{
							goto IL_00A1;
						}
						this.ExpireTimeMs = input.ReadUInt64();
					}
					else
					{
						this.Deductible = input.ReadBool();
					}
				}
				else if (num3 != 98U)
				{
					if (num3 != 104U)
					{
						goto IL_00A1;
					}
					this.IgrPaid = input.ReadBool();
				}
				else
				{
					this.MacAddress = input.ReadString();
				}
				continue;
				IL_00A1:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B6D RID: 15213
		private static readonly MessageParser<SessionState> _parser = new MessageParser<SessionState>(() => new SessionState());

		// Token: 0x04003B6E RID: 15214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B6F RID: 15215
		private int _hasBits0;

		// Token: 0x04003B70 RID: 15216
		public const int HandleFieldNumber = 1;

		// Token: 0x04003B71 RID: 15217
		private GameAccountHandle handle_;

		// Token: 0x04003B72 RID: 15218
		public const int ClientAddressFieldNumber = 2;

		// Token: 0x04003B73 RID: 15219
		private static readonly string ClientAddressDefaultValue = "";

		// Token: 0x04003B74 RID: 15220
		private string clientAddress_;

		// Token: 0x04003B75 RID: 15221
		public const int LastTickTimeFieldNumber = 3;

		// Token: 0x04003B76 RID: 15222
		private static readonly ulong LastTickTimeDefaultValue = 0UL;

		// Token: 0x04003B77 RID: 15223
		private ulong lastTickTime_;

		// Token: 0x04003B78 RID: 15224
		public const int CreateTimeFieldNumber = 4;

		// Token: 0x04003B79 RID: 15225
		private static readonly ulong CreateTimeDefaultValue = 0UL;

		// Token: 0x04003B7A RID: 15226
		private ulong createTime_;

		// Token: 0x04003B7B RID: 15227
		public const int ParentalControlsActiveFieldNumber = 5;

		// Token: 0x04003B7C RID: 15228
		private static readonly bool ParentalControlsActiveDefaultValue = false;

		// Token: 0x04003B7D RID: 15229
		private bool parentalControlsActive_;

		// Token: 0x04003B7E RID: 15230
		public const int LocationFieldNumber = 6;

		// Token: 0x04003B7F RID: 15231
		private GameSessionLocation location_;

		// Token: 0x04003B80 RID: 15232
		public const int UsingIgrAddressFieldNumber = 7;

		// Token: 0x04003B81 RID: 15233
		private static readonly bool UsingIgrAddressDefaultValue = false;

		// Token: 0x04003B82 RID: 15234
		private bool usingIgrAddress_;

		// Token: 0x04003B83 RID: 15235
		public const int HasBenefactorFieldNumber = 8;

		// Token: 0x04003B84 RID: 15236
		private static readonly bool HasBenefactorDefaultValue = false;

		// Token: 0x04003B85 RID: 15237
		private bool hasBenefactor_;

		// Token: 0x04003B86 RID: 15238
		public const int IgrIdFieldNumber = 9;

		// Token: 0x04003B87 RID: 15239
		private IgrId igrId_;

		// Token: 0x04003B88 RID: 15240
		public const int DeductibleFieldNumber = 10;

		// Token: 0x04003B89 RID: 15241
		private static readonly bool DeductibleDefaultValue = false;

		// Token: 0x04003B8A RID: 15242
		private bool deductible_;

		// Token: 0x04003B8B RID: 15243
		public const int ExpireTimeMsFieldNumber = 11;

		// Token: 0x04003B8C RID: 15244
		private static readonly ulong ExpireTimeMsDefaultValue = 0UL;

		// Token: 0x04003B8D RID: 15245
		private ulong expireTimeMs_;

		// Token: 0x04003B8E RID: 15246
		public const int MacAddressFieldNumber = 12;

		// Token: 0x04003B8F RID: 15247
		private static readonly string MacAddressDefaultValue = "";

		// Token: 0x04003B90 RID: 15248
		private string macAddress_;

		// Token: 0x04003B91 RID: 15249
		public const int IgrPaidFieldNumber = 13;

		// Token: 0x04003B92 RID: 15250
		private static readonly bool IgrPaidDefaultValue = false;

		// Token: 0x04003B93 RID: 15251
		private bool igrPaid_;
	}
}
