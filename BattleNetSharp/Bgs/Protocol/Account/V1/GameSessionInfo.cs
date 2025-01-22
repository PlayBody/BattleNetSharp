using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000746 RID: 1862
	public sealed class GameSessionInfo : IMessage<GameSessionInfo>, IMessage, IEquatable<GameSessionInfo>, IDeepCloneable<GameSessionInfo>, IBufferMessage
	{
		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x0029B4F8 File Offset: 0x002996F8
		[DebuggerNonUserCode]
		public static MessageParser<GameSessionInfo> Parser
		{
			get
			{
				return GameSessionInfo._parser;
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600AB41 RID: 43841 RVA: 0x0029B510 File Offset: 0x00299710
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600AB42 RID: 43842 RVA: 0x0029B534 File Offset: 0x00299734
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionInfo.Descriptor;
			}
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x0029B54B File Offset: 0x0029974B
		[DebuggerNonUserCode]
		public GameSessionInfo()
		{
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x0029B558 File Offset: 0x00299758
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

		// Token: 0x0600AB45 RID: 43845 RVA: 0x0029B618 File Offset: 0x00299818
		[DebuggerNonUserCode]
		public GameSessionInfo Clone()
		{
			return new GameSessionInfo(this);
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x0029B630 File Offset: 0x00299830
		// (set) Token: 0x0600AB47 RID: 43847 RVA: 0x0029B661 File Offset: 0x00299861
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

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600AB48 RID: 43848 RVA: 0x0029B67C File Offset: 0x0029987C
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasStartTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x0029B699 File Offset: 0x00299899
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearStartTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x0029B6AC File Offset: 0x002998AC
		// (set) Token: 0x0600AB4B RID: 43851 RVA: 0x0029B6C4 File Offset: 0x002998C4
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

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x0029B6D0 File Offset: 0x002998D0
		// (set) Token: 0x0600AB4D RID: 43853 RVA: 0x0029B701 File Offset: 0x00299901
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

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x0029B71C File Offset: 0x0029991C
		[DebuggerNonUserCode]
		public bool HasHasBenefactor
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x0029B739 File Offset: 0x00299939
		[DebuggerNonUserCode]
		public void ClearHasBenefactor()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600AB50 RID: 43856 RVA: 0x0029B74C File Offset: 0x0029994C
		// (set) Token: 0x0600AB51 RID: 43857 RVA: 0x0029B77D File Offset: 0x0029997D
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

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600AB52 RID: 43858 RVA: 0x0029B798 File Offset: 0x00299998
		[DebuggerNonUserCode]
		public bool HasIsUsingIgr
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x0029B7B5 File Offset: 0x002999B5
		[DebuggerNonUserCode]
		public void ClearIsUsingIgr()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x0029B7C8 File Offset: 0x002999C8
		// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x0029B7F9 File Offset: 0x002999F9
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

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x0029B814 File Offset: 0x00299A14
		[DebuggerNonUserCode]
		public bool HasParentalControlsActive
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x0029B831 File Offset: 0x00299A31
		[DebuggerNonUserCode]
		public void ClearParentalControlsActive()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x0029B844 File Offset: 0x00299A44
		// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x0029B876 File Offset: 0x00299A76
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

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x0029B890 File Offset: 0x00299A90
		[DebuggerNonUserCode]
		public bool HasStartTimeSec
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x0029B8AE File Offset: 0x00299AAE
		[DebuggerNonUserCode]
		public void ClearStartTimeSec()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x0029B8C0 File Offset: 0x00299AC0
		// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x0029B8D8 File Offset: 0x00299AD8
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

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x0029B8E4 File Offset: 0x00299AE4
		// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x0029B916 File Offset: 0x00299B16
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

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x0029B930 File Offset: 0x00299B30
		[DebuggerNonUserCode]
		public bool HasPlatformId
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x0029B94E File Offset: 0x00299B4E
		[DebuggerNonUserCode]
		public void ClearPlatformId()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x0029B960 File Offset: 0x00299B60
		// (set) Token: 0x0600AB63 RID: 43875 RVA: 0x0029B992 File Offset: 0x00299B92
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

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600AB64 RID: 43876 RVA: 0x0029B9AC File Offset: 0x00299BAC
		[DebuggerNonUserCode]
		public bool HasIgrPaid
		{
			get
			{
				return (this._hasBits0 & 64) != 0;
			}
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x0029B9CA File Offset: 0x00299BCA
		[DebuggerNonUserCode]
		public void ClearIgrPaid()
		{
			this._hasBits0 &= -65;
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x0029B9DC File Offset: 0x00299BDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionInfo);
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x0029B9FC File Offset: 0x00299BFC
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

		// Token: 0x0600AB68 RID: 43880 RVA: 0x0029BB48 File Offset: 0x00299D48
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

		// Token: 0x0600AB69 RID: 43881 RVA: 0x0029BC84 File Offset: 0x00299E84
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x0029BC9C File Offset: 0x00299E9C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x0029BCA8 File Offset: 0x00299EA8
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

		// Token: 0x0600AB6C RID: 43884 RVA: 0x0029BE18 File Offset: 0x0029A018
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

		// Token: 0x0600AB6D RID: 43885 RVA: 0x0029BF20 File Offset: 0x0029A120
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

		// Token: 0x0600AB6E RID: 43886 RVA: 0x0029C08A File Offset: 0x0029A28A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB6F RID: 43887 RVA: 0x0029C098 File Offset: 0x0029A298
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

		// Token: 0x04004D25 RID: 19749
		private static readonly MessageParser<GameSessionInfo> _parser = new MessageParser<GameSessionInfo>(() => new GameSessionInfo());

		// Token: 0x04004D26 RID: 19750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D27 RID: 19751
		private int _hasBits0;

		// Token: 0x04004D28 RID: 19752
		public const int StartTimeFieldNumber = 3;

		// Token: 0x04004D29 RID: 19753
		private static readonly uint StartTimeDefaultValue = 0U;

		// Token: 0x04004D2A RID: 19754
		private uint startTime_;

		// Token: 0x04004D2B RID: 19755
		public const int LocationFieldNumber = 4;

		// Token: 0x04004D2C RID: 19756
		private GameSessionLocation location_;

		// Token: 0x04004D2D RID: 19757
		public const int HasBenefactorFieldNumber = 5;

		// Token: 0x04004D2E RID: 19758
		private static readonly bool HasBenefactorDefaultValue = false;

		// Token: 0x04004D2F RID: 19759
		private bool hasBenefactor_;

		// Token: 0x04004D30 RID: 19760
		public const int IsUsingIgrFieldNumber = 6;

		// Token: 0x04004D31 RID: 19761
		private static readonly bool IsUsingIgrDefaultValue = false;

		// Token: 0x04004D32 RID: 19762
		private bool isUsingIgr_;

		// Token: 0x04004D33 RID: 19763
		public const int ParentalControlsActiveFieldNumber = 7;

		// Token: 0x04004D34 RID: 19764
		private static readonly bool ParentalControlsActiveDefaultValue = false;

		// Token: 0x04004D35 RID: 19765
		private bool parentalControlsActive_;

		// Token: 0x04004D36 RID: 19766
		public const int StartTimeSecFieldNumber = 8;

		// Token: 0x04004D37 RID: 19767
		private static readonly ulong StartTimeSecDefaultValue = 0UL;

		// Token: 0x04004D38 RID: 19768
		private ulong startTimeSec_;

		// Token: 0x04004D39 RID: 19769
		public const int IgrIdFieldNumber = 9;

		// Token: 0x04004D3A RID: 19770
		private IgrId igrId_;

		// Token: 0x04004D3B RID: 19771
		public const int PlatformIdFieldNumber = 10;

		// Token: 0x04004D3C RID: 19772
		private static readonly uint PlatformIdDefaultValue = 0U;

		// Token: 0x04004D3D RID: 19773
		private uint platformId_;

		// Token: 0x04004D3E RID: 19774
		public const int IgrPaidFieldNumber = 11;

		// Token: 0x04004D3F RID: 19775
		private static readonly bool IgrPaidDefaultValue = false;

		// Token: 0x04004D40 RID: 19776
		private bool igrPaid_;
	}
}
