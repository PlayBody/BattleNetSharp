using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200054F RID: 1359
	public sealed class GameSessionInfo : IMessage<GameSessionInfo>, IMessage, IEquatable<GameSessionInfo>, IDeepCloneable<GameSessionInfo>, IBufferMessage
	{
		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x001FEDE4 File Offset: 0x001FCFE4
		[DebuggerNonUserCode]
		public static MessageParser<GameSessionInfo> Parser
		{
			get
			{
				return GameSessionInfo._parser;
			}
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600834C RID: 33612 RVA: 0x001FEDFC File Offset: 0x001FCFFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600834D RID: 33613 RVA: 0x001FEE20 File Offset: 0x001FD020
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionInfo.Descriptor;
			}
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x001FEE37 File Offset: 0x001FD037
		[DebuggerNonUserCode]
		public GameSessionInfo()
		{
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x001FEE44 File Offset: 0x001FD044
		[DebuggerNonUserCode]
		public GameSessionInfo(GameSessionInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.startTime_ = other.startTime_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.hasBenefactor_ = other.hasBenefactor_;
			this.isUsingIgr_ = other.isUsingIgr_;
			this.parentalControlsActive_ = other.parentalControlsActive_;
			this.startTimeSec_ = other.startTimeSec_;
			this.igrId_ = ((other.igrId_ != null) ? other.igrId_.Clone() : null);
			this.platformId_ = other.platformId_;
			this.igrPaid_ = other.igrPaid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008350 RID: 33616 RVA: 0x001FEF04 File Offset: 0x001FD104
		[DebuggerNonUserCode]
		public GameSessionInfo Clone()
		{
			return new GameSessionInfo(this);
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x001FEF1C File Offset: 0x001FD11C
		// (set) Token: 0x06008352 RID: 33618 RVA: 0x001FEF4D File Offset: 0x001FD14D
		[Obsolete]
		[DebuggerNonUserCode]
		public uint StartTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint startTimeDefaultValue;
				if (flag)
				{
					startTimeDefaultValue = this.startTime_;
				}
				else
				{
					startTimeDefaultValue = GameSessionInfo.StartTimeDefaultValue;
				}
				return startTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startTime_ = value;
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06008353 RID: 33619 RVA: 0x001FEF68 File Offset: 0x001FD168
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasStartTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x001FEF85 File Offset: 0x001FD185
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearStartTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x06008355 RID: 33621 RVA: 0x001FEF98 File Offset: 0x001FD198
		// (set) Token: 0x06008356 RID: 33622 RVA: 0x001FEFB0 File Offset: 0x001FD1B0
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

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x06008357 RID: 33623 RVA: 0x001FEFBC File Offset: 0x001FD1BC
		// (set) Token: 0x06008358 RID: 33624 RVA: 0x001FEFED File Offset: 0x001FD1ED
		[DebuggerNonUserCode]
		public bool HasBenefactor
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool hasBenefactorDefaultValue;
				if (flag)
				{
					hasBenefactorDefaultValue = this.hasBenefactor_;
				}
				else
				{
					hasBenefactorDefaultValue = GameSessionInfo.HasBenefactorDefaultValue;
				}
				return hasBenefactorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.hasBenefactor_ = value;
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06008359 RID: 33625 RVA: 0x001FF008 File Offset: 0x001FD208
		[DebuggerNonUserCode]
		public bool HasHasBenefactor
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x001FF025 File Offset: 0x001FD225
		[DebuggerNonUserCode]
		public void ClearHasBenefactor()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600835B RID: 33627 RVA: 0x001FF038 File Offset: 0x001FD238
		// (set) Token: 0x0600835C RID: 33628 RVA: 0x001FF069 File Offset: 0x001FD269
		[DebuggerNonUserCode]
		public bool IsUsingIgr
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isUsingIgrDefaultValue;
				if (flag)
				{
					isUsingIgrDefaultValue = this.isUsingIgr_;
				}
				else
				{
					isUsingIgrDefaultValue = GameSessionInfo.IsUsingIgrDefaultValue;
				}
				return isUsingIgrDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isUsingIgr_ = value;
			}
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600835D RID: 33629 RVA: 0x001FF084 File Offset: 0x001FD284
		[DebuggerNonUserCode]
		public bool HasIsUsingIgr
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x001FF0A1 File Offset: 0x001FD2A1
		[DebuggerNonUserCode]
		public void ClearIsUsingIgr()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x0600835F RID: 33631 RVA: 0x001FF0B4 File Offset: 0x001FD2B4
		// (set) Token: 0x06008360 RID: 33632 RVA: 0x001FF0E5 File Offset: 0x001FD2E5
		[DebuggerNonUserCode]
		public bool ParentalControlsActive
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool parentalControlsActiveDefaultValue;
				if (flag)
				{
					parentalControlsActiveDefaultValue = this.parentalControlsActive_;
				}
				else
				{
					parentalControlsActiveDefaultValue = GameSessionInfo.ParentalControlsActiveDefaultValue;
				}
				return parentalControlsActiveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.parentalControlsActive_ = value;
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x06008361 RID: 33633 RVA: 0x001FF100 File Offset: 0x001FD300
		[DebuggerNonUserCode]
		public bool HasParentalControlsActive
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x001FF11D File Offset: 0x001FD31D
		[DebuggerNonUserCode]
		public void ClearParentalControlsActive()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x06008363 RID: 33635 RVA: 0x001FF130 File Offset: 0x001FD330
		// (set) Token: 0x06008364 RID: 33636 RVA: 0x001FF162 File Offset: 0x001FD362
		[DebuggerNonUserCode]
		public ulong StartTimeSec
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				ulong startTimeSecDefaultValue;
				if (flag)
				{
					startTimeSecDefaultValue = this.startTimeSec_;
				}
				else
				{
					startTimeSecDefaultValue = GameSessionInfo.StartTimeSecDefaultValue;
				}
				return startTimeSecDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.startTimeSec_ = value;
			}
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x06008365 RID: 33637 RVA: 0x001FF17C File Offset: 0x001FD37C
		[DebuggerNonUserCode]
		public bool HasStartTimeSec
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x001FF19A File Offset: 0x001FD39A
		[DebuggerNonUserCode]
		public void ClearStartTimeSec()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x06008367 RID: 33639 RVA: 0x001FF1AC File Offset: 0x001FD3AC
		// (set) Token: 0x06008368 RID: 33640 RVA: 0x001FF1C4 File Offset: 0x001FD3C4
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

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x06008369 RID: 33641 RVA: 0x001FF1D0 File Offset: 0x001FD3D0
		// (set) Token: 0x0600836A RID: 33642 RVA: 0x001FF202 File Offset: 0x001FD402
		[DebuggerNonUserCode]
		public uint PlatformId
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint platformIdDefaultValue;
				if (flag)
				{
					platformIdDefaultValue = this.platformId_;
				}
				else
				{
					platformIdDefaultValue = GameSessionInfo.PlatformIdDefaultValue;
				}
				return platformIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.platformId_ = value;
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600836B RID: 33643 RVA: 0x001FF21C File Offset: 0x001FD41C
		[DebuggerNonUserCode]
		public bool HasPlatformId
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x001FF23A File Offset: 0x001FD43A
		[DebuggerNonUserCode]
		public void ClearPlatformId()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600836D RID: 33645 RVA: 0x001FF24C File Offset: 0x001FD44C
		// (set) Token: 0x0600836E RID: 33646 RVA: 0x001FF27E File Offset: 0x001FD47E
		[DebuggerNonUserCode]
		public bool IgrPaid
		{
			get
			{
				bool flag = (this._hasBits0 & 64) != 0;
				bool igrPaidDefaultValue;
				if (flag)
				{
					igrPaidDefaultValue = this.igrPaid_;
				}
				else
				{
					igrPaidDefaultValue = GameSessionInfo.IgrPaidDefaultValue;
				}
				return igrPaidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 64;
				this.igrPaid_ = value;
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600836F RID: 33647 RVA: 0x001FF298 File Offset: 0x001FD498
		[DebuggerNonUserCode]
		public bool HasIgrPaid
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x001FF2B6 File Offset: 0x001FD4B6
		[DebuggerNonUserCode]
		public void ClearIgrPaid()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x001FF2C8 File Offset: 0x001FD4C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionInfo);
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x001FF2E8 File Offset: 0x001FD4E8
		[DebuggerNonUserCode]
		public bool Equals(GameSessionInfo other)
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
					bool flag4 = this.StartTime != other.StartTime;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Location, other.Location);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.HasBenefactor != other.HasBenefactor;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsUsingIgr != other.IsUsingIgr;
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
										bool flag9 = this.StartTimeSec != other.StartTimeSec;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.IgrId, other.IgrId);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.PlatformId != other.PlatformId;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.IgrPaid != other.IgrPaid;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06008373 RID: 33651 RVA: 0x001FF434 File Offset: 0x001FD634
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num ^= this.StartTime.GetHashCode();
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				num ^= this.Location.GetHashCode();
			}
			bool hasHasBenefactor = this.HasHasBenefactor;
			if (hasHasBenefactor)
			{
				num ^= this.HasBenefactor.GetHashCode();
			}
			bool hasIsUsingIgr = this.HasIsUsingIgr;
			if (hasIsUsingIgr)
			{
				num ^= this.IsUsingIgr.GetHashCode();
			}
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				num ^= this.ParentalControlsActive.GetHashCode();
			}
			bool hasStartTimeSec = this.HasStartTimeSec;
			if (hasStartTimeSec)
			{
				num ^= this.StartTimeSec.GetHashCode();
			}
			bool flag2 = this.igrId_ != null;
			if (flag2)
			{
				num ^= this.IgrId.GetHashCode();
			}
			bool hasPlatformId = this.HasPlatformId;
			if (hasPlatformId)
			{
				num ^= this.PlatformId.GetHashCode();
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				num ^= this.IgrPaid.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x001FF570 File Offset: 0x001FD770
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x001FF588 File Offset: 0x001FD788
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x001FF594 File Offset: 0x001FD794
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.StartTime);
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Location);
			}
			bool hasHasBenefactor = this.HasHasBenefactor;
			if (hasHasBenefactor)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.HasBenefactor);
			}
			bool hasIsUsingIgr = this.HasIsUsingIgr;
			if (hasIsUsingIgr)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsUsingIgr);
			}
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ParentalControlsActive);
			}
			bool hasStartTimeSec = this.HasStartTimeSec;
			if (hasStartTimeSec)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.StartTimeSec);
			}
			bool flag2 = this.igrId_ != null;
			if (flag2)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.IgrId);
			}
			bool hasPlatformId = this.HasPlatformId;
			if (hasPlatformId)
			{
				output.WriteRawTag(85);
				output.WriteFixed32(this.PlatformId);
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IgrPaid);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x001FF704 File Offset: 0x001FD904
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StartTime);
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			bool hasHasBenefactor = this.HasHasBenefactor;
			if (hasHasBenefactor)
			{
				num += 2;
			}
			bool hasIsUsingIgr = this.HasIsUsingIgr;
			if (hasIsUsingIgr)
			{
				num += 2;
			}
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				num += 2;
			}
			bool hasStartTimeSec = this.HasStartTimeSec;
			if (hasStartTimeSec)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartTimeSec);
			}
			bool flag2 = this.igrId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IgrId);
			}
			bool hasPlatformId = this.HasPlatformId;
			if (hasPlatformId)
			{
				num += 5;
			}
			bool hasIgrPaid = this.HasIgrPaid;
			if (hasIgrPaid)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x001FF80C File Offset: 0x001FDA0C
		[DebuggerNonUserCode]
		public void MergeFrom(GameSessionInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStartTime = other.HasStartTime;
				if (hasStartTime)
				{
					this.StartTime = other.StartTime;
				}
				bool flag2 = other.location_ != null;
				if (flag2)
				{
					bool flag3 = this.location_ == null;
					if (flag3)
					{
						this.Location = new GameSessionLocation();
					}
					this.Location.MergeFrom(other.Location);
				}
				bool hasHasBenefactor = other.HasHasBenefactor;
				if (hasHasBenefactor)
				{
					this.HasBenefactor = other.HasBenefactor;
				}
				bool hasIsUsingIgr = other.HasIsUsingIgr;
				if (hasIsUsingIgr)
				{
					this.IsUsingIgr = other.IsUsingIgr;
				}
				bool hasParentalControlsActive = other.HasParentalControlsActive;
				if (hasParentalControlsActive)
				{
					this.ParentalControlsActive = other.ParentalControlsActive;
				}
				bool hasStartTimeSec = other.HasStartTimeSec;
				if (hasStartTimeSec)
				{
					this.StartTimeSec = other.StartTimeSec;
				}
				bool flag4 = other.igrId_ != null;
				if (flag4)
				{
					bool flag5 = this.igrId_ == null;
					if (flag5)
					{
						this.IgrId = new IgrId();
					}
					this.IgrId.MergeFrom(other.IgrId);
				}
				bool hasPlatformId = other.HasPlatformId;
				if (hasPlatformId)
				{
					this.PlatformId = other.PlatformId;
				}
				bool hasIgrPaid = other.HasIgrPaid;
				if (hasIgrPaid)
				{
					this.IgrPaid = other.IgrPaid;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x001FF976 File Offset: 0x001FDB76
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x001FF984 File Offset: 0x001FDB84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 34U)
					{
						if (num3 != 24U)
						{
							if (num3 != 34U)
							{
								goto IL_006E;
							}
							bool flag = this.location_ == null;
							if (flag)
							{
								this.Location = new GameSessionLocation();
							}
							input.ReadMessage(this.Location);
						}
						else
						{
							this.StartTime = input.ReadUInt32();
						}
					}
					else if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_006E;
						}
						this.IsUsingIgr = input.ReadBool();
					}
					else
					{
						this.HasBenefactor = input.ReadBool();
					}
				}
				else if (num3 <= 64U)
				{
					if (num3 != 56U)
					{
						if (num3 != 64U)
						{
							goto IL_006E;
						}
						this.StartTimeSec = input.ReadUInt64();
					}
					else
					{
						this.ParentalControlsActive = input.ReadBool();
					}
				}
				else if (num3 != 74U)
				{
					if (num3 != 85U)
					{
						if (num3 != 88U)
						{
							goto IL_006E;
						}
						this.IgrPaid = input.ReadBool();
					}
					else
					{
						this.PlatformId = input.ReadFixed32();
					}
				}
				else
				{
					bool flag2 = this.igrId_ == null;
					if (flag2)
					{
						this.IgrId = new IgrId();
					}
					input.ReadMessage(this.IgrId);
				}
				continue;
				IL_006E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B9F RID: 15263
		private static readonly MessageParser<GameSessionInfo> _parser = new MessageParser<GameSessionInfo>(() => new GameSessionInfo());

		// Token: 0x04003BA0 RID: 15264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BA1 RID: 15265
		private int _hasBits0;

		// Token: 0x04003BA2 RID: 15266
		public const int StartTimeFieldNumber = 3;

		// Token: 0x04003BA3 RID: 15267
		private static readonly uint StartTimeDefaultValue = 0U;

		// Token: 0x04003BA4 RID: 15268
		private uint startTime_;

		// Token: 0x04003BA5 RID: 15269
		public const int LocationFieldNumber = 4;

		// Token: 0x04003BA6 RID: 15270
		private GameSessionLocation location_;

		// Token: 0x04003BA7 RID: 15271
		public const int HasBenefactorFieldNumber = 5;

		// Token: 0x04003BA8 RID: 15272
		private static readonly bool HasBenefactorDefaultValue = false;

		// Token: 0x04003BA9 RID: 15273
		private bool hasBenefactor_;

		// Token: 0x04003BAA RID: 15274
		public const int IsUsingIgrFieldNumber = 6;

		// Token: 0x04003BAB RID: 15275
		private static readonly bool IsUsingIgrDefaultValue = false;

		// Token: 0x04003BAC RID: 15276
		private bool isUsingIgr_;

		// Token: 0x04003BAD RID: 15277
		public const int ParentalControlsActiveFieldNumber = 7;

		// Token: 0x04003BAE RID: 15278
		private static readonly bool ParentalControlsActiveDefaultValue = false;

		// Token: 0x04003BAF RID: 15279
		private bool parentalControlsActive_;

		// Token: 0x04003BB0 RID: 15280
		public const int StartTimeSecFieldNumber = 8;

		// Token: 0x04003BB1 RID: 15281
		private static readonly ulong StartTimeSecDefaultValue = 0UL;

		// Token: 0x04003BB2 RID: 15282
		private ulong startTimeSec_;

		// Token: 0x04003BB3 RID: 15283
		public const int IgrIdFieldNumber = 9;

		// Token: 0x04003BB4 RID: 15284
		private IgrId igrId_;

		// Token: 0x04003BB5 RID: 15285
		public const int PlatformIdFieldNumber = 10;

		// Token: 0x04003BB6 RID: 15286
		private static readonly uint PlatformIdDefaultValue = 0U;

		// Token: 0x04003BB7 RID: 15287
		private uint platformId_;

		// Token: 0x04003BB8 RID: 15288
		public const int IgrPaidFieldNumber = 11;

		// Token: 0x04003BB9 RID: 15289
		private static readonly bool IgrPaidDefaultValue = false;

		// Token: 0x04003BBA RID: 15290
		private bool igrPaid_;
	}
}
