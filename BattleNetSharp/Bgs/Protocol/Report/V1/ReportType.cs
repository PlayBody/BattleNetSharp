using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000578 RID: 1400
	public sealed class ReportType : IMessage<ReportType>, IMessage, IEquatable<ReportType>, IDeepCloneable<ReportType>, IBufferMessage
	{
		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x06008686 RID: 34438 RVA: 0x0020AE58 File Offset: 0x00209058
		[DebuggerNonUserCode]
		public static MessageParser<ReportType> Parser
		{
			get
			{
				return ReportType._parser;
			}
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x06008687 RID: 34439 RVA: 0x0020AE70 File Offset: 0x00209070
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x06008688 RID: 34440 RVA: 0x0020AE94 File Offset: 0x00209094
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportType.Descriptor;
			}
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x0020AEAB File Offset: 0x002090AB
		[DebuggerNonUserCode]
		public ReportType()
		{
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x0020AEBC File Offset: 0x002090BC
		[DebuggerNonUserCode]
		public ReportType(ReportType other)
			: this()
		{
			this.userDescription_ = other.userDescription_;
			switch (other.TypeCase)
			{
			case ReportType.TypeOneofCase.CustomReport:
				this.CustomReport = other.CustomReport.Clone();
				break;
			case ReportType.TypeOneofCase.SpamReport:
				this.SpamReport = other.SpamReport.Clone();
				break;
			case ReportType.TypeOneofCase.HarassmentReport:
				this.HarassmentReport = other.HarassmentReport.Clone();
				break;
			case ReportType.TypeOneofCase.RealLifeThreatReport:
				this.RealLifeThreatReport = other.RealLifeThreatReport.Clone();
				break;
			case ReportType.TypeOneofCase.InappropriateBattleTagReport:
				this.InappropriateBattleTagReport = other.InappropriateBattleTagReport.Clone();
				break;
			case ReportType.TypeOneofCase.HackingReport:
				this.HackingReport = other.HackingReport.Clone();
				break;
			case ReportType.TypeOneofCase.BottingReport:
				this.BottingReport = other.BottingReport.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x0020AFB0 File Offset: 0x002091B0
		[DebuggerNonUserCode]
		public ReportType Clone()
		{
			return new ReportType(this);
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x0600868C RID: 34444 RVA: 0x0020AFC8 File Offset: 0x002091C8
		// (set) Token: 0x0600868D RID: 34445 RVA: 0x0020AFE9 File Offset: 0x002091E9
		[DebuggerNonUserCode]
		public string UserDescription
		{
			get
			{
				return this.userDescription_ ?? ReportType.UserDescriptionDefaultValue;
			}
			set
			{
				this.userDescription_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0600868E RID: 34446 RVA: 0x0020B000 File Offset: 0x00209200
		[DebuggerNonUserCode]
		public bool HasUserDescription
		{
			get
			{
				return this.userDescription_ != null;
			}
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x0020B01B File Offset: 0x0020921B
		[DebuggerNonUserCode]
		public void ClearUserDescription()
		{
			this.userDescription_ = null;
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x06008690 RID: 34448 RVA: 0x0020B028 File Offset: 0x00209228
		// (set) Token: 0x06008691 RID: 34449 RVA: 0x0020B052 File Offset: 0x00209252
		[DebuggerNonUserCode]
		public CustomReport CustomReport
		{
			get
			{
				return (this.typeCase_ == ReportType.TypeOneofCase.CustomReport) ? ((CustomReport)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportType.TypeOneofCase.None : ReportType.TypeOneofCase.CustomReport);
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x06008692 RID: 34450 RVA: 0x0020B06C File Offset: 0x0020926C
		// (set) Token: 0x06008693 RID: 34451 RVA: 0x0020B096 File Offset: 0x00209296
		[DebuggerNonUserCode]
		public SpamReport SpamReport
		{
			get
			{
				return (this.typeCase_ == ReportType.TypeOneofCase.SpamReport) ? ((SpamReport)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportType.TypeOneofCase.None : ReportType.TypeOneofCase.SpamReport);
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x06008694 RID: 34452 RVA: 0x0020B0B0 File Offset: 0x002092B0
		// (set) Token: 0x06008695 RID: 34453 RVA: 0x0020B0DA File Offset: 0x002092DA
		[DebuggerNonUserCode]
		public HarassmentReport HarassmentReport
		{
			get
			{
				return (this.typeCase_ == ReportType.TypeOneofCase.HarassmentReport) ? ((HarassmentReport)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportType.TypeOneofCase.None : ReportType.TypeOneofCase.HarassmentReport);
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x06008696 RID: 34454 RVA: 0x0020B0F4 File Offset: 0x002092F4
		// (set) Token: 0x06008697 RID: 34455 RVA: 0x0020B11E File Offset: 0x0020931E
		[DebuggerNonUserCode]
		public RealLifeThreatReport RealLifeThreatReport
		{
			get
			{
				return (this.typeCase_ == ReportType.TypeOneofCase.RealLifeThreatReport) ? ((RealLifeThreatReport)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportType.TypeOneofCase.None : ReportType.TypeOneofCase.RealLifeThreatReport);
			}
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x06008698 RID: 34456 RVA: 0x0020B138 File Offset: 0x00209338
		// (set) Token: 0x06008699 RID: 34457 RVA: 0x0020B162 File Offset: 0x00209362
		[DebuggerNonUserCode]
		public InappropriateBattleTagReport InappropriateBattleTagReport
		{
			get
			{
				return (this.typeCase_ == ReportType.TypeOneofCase.InappropriateBattleTagReport) ? ((InappropriateBattleTagReport)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportType.TypeOneofCase.None : ReportType.TypeOneofCase.InappropriateBattleTagReport);
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0600869A RID: 34458 RVA: 0x0020B17C File Offset: 0x0020937C
		// (set) Token: 0x0600869B RID: 34459 RVA: 0x0020B1A6 File Offset: 0x002093A6
		[DebuggerNonUserCode]
		public HackingReport HackingReport
		{
			get
			{
				return (this.typeCase_ == ReportType.TypeOneofCase.HackingReport) ? ((HackingReport)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportType.TypeOneofCase.None : ReportType.TypeOneofCase.HackingReport);
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0600869C RID: 34460 RVA: 0x0020B1C0 File Offset: 0x002093C0
		// (set) Token: 0x0600869D RID: 34461 RVA: 0x0020B1EA File Offset: 0x002093EA
		[DebuggerNonUserCode]
		public BottingReport BottingReport
		{
			get
			{
				return (this.typeCase_ == ReportType.TypeOneofCase.BottingReport) ? ((BottingReport)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? ReportType.TypeOneofCase.None : ReportType.TypeOneofCase.BottingReport);
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600869E RID: 34462 RVA: 0x0020B204 File Offset: 0x00209404
		[DebuggerNonUserCode]
		public ReportType.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x0020B21C File Offset: 0x0020941C
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = ReportType.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x0020B230 File Offset: 0x00209430
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportType);
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x0020B250 File Offset: 0x00209450
		[DebuggerNonUserCode]
		public bool Equals(ReportType other)
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
					bool flag4 = this.UserDescription != other.UserDescription;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.CustomReport, other.CustomReport);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SpamReport, other.SpamReport);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.HarassmentReport, other.HarassmentReport);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.RealLifeThreatReport, other.RealLifeThreatReport);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.InappropriateBattleTagReport, other.InappropriateBattleTagReport);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.HackingReport, other.HackingReport);
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !object.Equals(this.BottingReport, other.BottingReport);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.TypeCase != other.TypeCase;
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

		// Token: 0x060086A2 RID: 34466 RVA: 0x0020B3A8 File Offset: 0x002095A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUserDescription = this.HasUserDescription;
			if (hasUserDescription)
			{
				num ^= this.UserDescription.GetHashCode();
			}
			bool flag = this.typeCase_ == ReportType.TypeOneofCase.CustomReport;
			if (flag)
			{
				num ^= this.CustomReport.GetHashCode();
			}
			bool flag2 = this.typeCase_ == ReportType.TypeOneofCase.SpamReport;
			if (flag2)
			{
				num ^= this.SpamReport.GetHashCode();
			}
			bool flag3 = this.typeCase_ == ReportType.TypeOneofCase.HarassmentReport;
			if (flag3)
			{
				num ^= this.HarassmentReport.GetHashCode();
			}
			bool flag4 = this.typeCase_ == ReportType.TypeOneofCase.RealLifeThreatReport;
			if (flag4)
			{
				num ^= this.RealLifeThreatReport.GetHashCode();
			}
			bool flag5 = this.typeCase_ == ReportType.TypeOneofCase.InappropriateBattleTagReport;
			if (flag5)
			{
				num ^= this.InappropriateBattleTagReport.GetHashCode();
			}
			bool flag6 = this.typeCase_ == ReportType.TypeOneofCase.HackingReport;
			if (flag6)
			{
				num ^= this.HackingReport.GetHashCode();
			}
			bool flag7 = this.typeCase_ == ReportType.TypeOneofCase.BottingReport;
			if (flag7)
			{
				num ^= this.BottingReport.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x0020B4D0 File Offset: 0x002096D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x0020B4E8 File Offset: 0x002096E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x0020B4F4 File Offset: 0x002096F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUserDescription = this.HasUserDescription;
			if (hasUserDescription)
			{
				output.WriteRawTag(10);
				output.WriteString(this.UserDescription);
			}
			bool flag = this.typeCase_ == ReportType.TypeOneofCase.CustomReport;
			if (flag)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CustomReport);
			}
			bool flag2 = this.typeCase_ == ReportType.TypeOneofCase.SpamReport;
			if (flag2)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SpamReport);
			}
			bool flag3 = this.typeCase_ == ReportType.TypeOneofCase.HarassmentReport;
			if (flag3)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.HarassmentReport);
			}
			bool flag4 = this.typeCase_ == ReportType.TypeOneofCase.RealLifeThreatReport;
			if (flag4)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RealLifeThreatReport);
			}
			bool flag5 = this.typeCase_ == ReportType.TypeOneofCase.InappropriateBattleTagReport;
			if (flag5)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.InappropriateBattleTagReport);
			}
			bool flag6 = this.typeCase_ == ReportType.TypeOneofCase.HackingReport;
			if (flag6)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.HackingReport);
			}
			bool flag7 = this.typeCase_ == ReportType.TypeOneofCase.BottingReport;
			if (flag7)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.BottingReport);
			}
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x0020B658 File Offset: 0x00209858
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUserDescription = this.HasUserDescription;
			if (hasUserDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UserDescription);
			}
			bool flag = this.typeCase_ == ReportType.TypeOneofCase.CustomReport;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CustomReport);
			}
			bool flag2 = this.typeCase_ == ReportType.TypeOneofCase.SpamReport;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpamReport);
			}
			bool flag3 = this.typeCase_ == ReportType.TypeOneofCase.HarassmentReport;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HarassmentReport);
			}
			bool flag4 = this.typeCase_ == ReportType.TypeOneofCase.RealLifeThreatReport;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RealLifeThreatReport);
			}
			bool flag5 = this.typeCase_ == ReportType.TypeOneofCase.InappropriateBattleTagReport;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InappropriateBattleTagReport);
			}
			bool flag6 = this.typeCase_ == ReportType.TypeOneofCase.HackingReport;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HackingReport);
			}
			bool flag7 = this.typeCase_ == ReportType.TypeOneofCase.BottingReport;
			if (flag7)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BottingReport);
			}
			bool flag8 = this._unknownFields != null;
			if (flag8)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x0020B794 File Offset: 0x00209994
		[DebuggerNonUserCode]
		public void MergeFrom(ReportType other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUserDescription = other.HasUserDescription;
				if (hasUserDescription)
				{
					this.UserDescription = other.UserDescription;
				}
				switch (other.TypeCase)
				{
				case ReportType.TypeOneofCase.CustomReport:
				{
					bool flag2 = this.CustomReport == null;
					if (flag2)
					{
						this.CustomReport = new CustomReport();
					}
					this.CustomReport.MergeFrom(other.CustomReport);
					break;
				}
				case ReportType.TypeOneofCase.SpamReport:
				{
					bool flag3 = this.SpamReport == null;
					if (flag3)
					{
						this.SpamReport = new SpamReport();
					}
					this.SpamReport.MergeFrom(other.SpamReport);
					break;
				}
				case ReportType.TypeOneofCase.HarassmentReport:
				{
					bool flag4 = this.HarassmentReport == null;
					if (flag4)
					{
						this.HarassmentReport = new HarassmentReport();
					}
					this.HarassmentReport.MergeFrom(other.HarassmentReport);
					break;
				}
				case ReportType.TypeOneofCase.RealLifeThreatReport:
				{
					bool flag5 = this.RealLifeThreatReport == null;
					if (flag5)
					{
						this.RealLifeThreatReport = new RealLifeThreatReport();
					}
					this.RealLifeThreatReport.MergeFrom(other.RealLifeThreatReport);
					break;
				}
				case ReportType.TypeOneofCase.InappropriateBattleTagReport:
				{
					bool flag6 = this.InappropriateBattleTagReport == null;
					if (flag6)
					{
						this.InappropriateBattleTagReport = new InappropriateBattleTagReport();
					}
					this.InappropriateBattleTagReport.MergeFrom(other.InappropriateBattleTagReport);
					break;
				}
				case ReportType.TypeOneofCase.HackingReport:
				{
					bool flag7 = this.HackingReport == null;
					if (flag7)
					{
						this.HackingReport = new HackingReport();
					}
					this.HackingReport.MergeFrom(other.HackingReport);
					break;
				}
				case ReportType.TypeOneofCase.BottingReport:
				{
					bool flag8 = this.BottingReport == null;
					if (flag8)
					{
						this.BottingReport = new BottingReport();
					}
					this.BottingReport.MergeFrom(other.BottingReport);
					break;
				}
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x0020B976 File Offset: 0x00209B76
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x0020B984 File Offset: 0x00209B84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 98U)
				{
					if (num3 <= 82U)
					{
						if (num3 != 10U)
						{
							if (num3 != 82U)
							{
								goto IL_0067;
							}
							CustomReport customReport = new CustomReport();
							bool flag = this.typeCase_ == ReportType.TypeOneofCase.CustomReport;
							if (flag)
							{
								customReport.MergeFrom(this.CustomReport);
							}
							input.ReadMessage(customReport);
							this.CustomReport = customReport;
						}
						else
						{
							this.UserDescription = input.ReadString();
						}
					}
					else if (num3 != 90U)
					{
						if (num3 != 98U)
						{
							goto IL_0067;
						}
						HarassmentReport harassmentReport = new HarassmentReport();
						bool flag2 = this.typeCase_ == ReportType.TypeOneofCase.HarassmentReport;
						if (flag2)
						{
							harassmentReport.MergeFrom(this.HarassmentReport);
						}
						input.ReadMessage(harassmentReport);
						this.HarassmentReport = harassmentReport;
					}
					else
					{
						SpamReport spamReport = new SpamReport();
						bool flag3 = this.typeCase_ == ReportType.TypeOneofCase.SpamReport;
						if (flag3)
						{
							spamReport.MergeFrom(this.SpamReport);
						}
						input.ReadMessage(spamReport);
						this.SpamReport = spamReport;
					}
				}
				else if (num3 <= 114U)
				{
					if (num3 != 106U)
					{
						if (num3 != 114U)
						{
							goto IL_0067;
						}
						InappropriateBattleTagReport inappropriateBattleTagReport = new InappropriateBattleTagReport();
						bool flag4 = this.typeCase_ == ReportType.TypeOneofCase.InappropriateBattleTagReport;
						if (flag4)
						{
							inappropriateBattleTagReport.MergeFrom(this.InappropriateBattleTagReport);
						}
						input.ReadMessage(inappropriateBattleTagReport);
						this.InappropriateBattleTagReport = inappropriateBattleTagReport;
					}
					else
					{
						RealLifeThreatReport realLifeThreatReport = new RealLifeThreatReport();
						bool flag5 = this.typeCase_ == ReportType.TypeOneofCase.RealLifeThreatReport;
						if (flag5)
						{
							realLifeThreatReport.MergeFrom(this.RealLifeThreatReport);
						}
						input.ReadMessage(realLifeThreatReport);
						this.RealLifeThreatReport = realLifeThreatReport;
					}
				}
				else if (num3 != 122U)
				{
					if (num3 != 130U)
					{
						goto IL_0067;
					}
					BottingReport bottingReport = new BottingReport();
					bool flag6 = this.typeCase_ == ReportType.TypeOneofCase.BottingReport;
					if (flag6)
					{
						bottingReport.MergeFrom(this.BottingReport);
					}
					input.ReadMessage(bottingReport);
					this.BottingReport = bottingReport;
				}
				else
				{
					HackingReport hackingReport = new HackingReport();
					bool flag7 = this.typeCase_ == ReportType.TypeOneofCase.HackingReport;
					if (flag7)
					{
						hackingReport.MergeFrom(this.HackingReport);
					}
					input.ReadMessage(hackingReport);
					this.HackingReport = hackingReport;
				}
				continue;
				IL_0067:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003CFB RID: 15611
		private static readonly MessageParser<ReportType> _parser = new MessageParser<ReportType>(() => new ReportType());

		// Token: 0x04003CFC RID: 15612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CFD RID: 15613
		public const int UserDescriptionFieldNumber = 1;

		// Token: 0x04003CFE RID: 15614
		private static readonly string UserDescriptionDefaultValue = "";

		// Token: 0x04003CFF RID: 15615
		private string userDescription_;

		// Token: 0x04003D00 RID: 15616
		public const int CustomReportFieldNumber = 10;

		// Token: 0x04003D01 RID: 15617
		public const int SpamReportFieldNumber = 11;

		// Token: 0x04003D02 RID: 15618
		public const int HarassmentReportFieldNumber = 12;

		// Token: 0x04003D03 RID: 15619
		public const int RealLifeThreatReportFieldNumber = 13;

		// Token: 0x04003D04 RID: 15620
		public const int InappropriateBattleTagReportFieldNumber = 14;

		// Token: 0x04003D05 RID: 15621
		public const int HackingReportFieldNumber = 15;

		// Token: 0x04003D06 RID: 15622
		public const int BottingReportFieldNumber = 16;

		// Token: 0x04003D07 RID: 15623
		private object type_;

		// Token: 0x04003D08 RID: 15624
		private ReportType.TypeOneofCase typeCase_ = ReportType.TypeOneofCase.None;

		// Token: 0x0200104D RID: 4173
		public enum TypeOneofCase
		{
			// Token: 0x0400979A RID: 38810
			None,
			// Token: 0x0400979B RID: 38811
			CustomReport = 10,
			// Token: 0x0400979C RID: 38812
			SpamReport,
			// Token: 0x0400979D RID: 38813
			HarassmentReport,
			// Token: 0x0400979E RID: 38814
			RealLifeThreatReport,
			// Token: 0x0400979F RID: 38815
			InappropriateBattleTagReport,
			// Token: 0x040097A0 RID: 38816
			HackingReport,
			// Token: 0x040097A1 RID: 38817
			BottingReport
		}
	}
}
