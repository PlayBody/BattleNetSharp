using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000580 RID: 1408
	public sealed class Report : IMessage<Report>, IMessage, IEquatable<Report>, IDeepCloneable<Report>, IBufferMessage
	{
		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06008747 RID: 34631 RVA: 0x0020DA7C File Offset: 0x0020BC7C
		[DebuggerNonUserCode]
		public static MessageParser<Report> Parser
		{
			get
			{
				return Report._parser;
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06008748 RID: 34632 RVA: 0x0020DA94 File Offset: 0x0020BC94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06008749 RID: 34633 RVA: 0x0020DAB8 File Offset: 0x0020BCB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Report.Descriptor;
			}
		}

		// Token: 0x0600874A RID: 34634 RVA: 0x0020DACF File Offset: 0x0020BCCF
		[DebuggerNonUserCode]
		public Report()
		{
		}

		// Token: 0x0600874B RID: 34635 RVA: 0x0020DAE4 File Offset: 0x0020BCE4
		[DebuggerNonUserCode]
		public Report(Report other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.reportType_ = other.reportType_;
			this.attribute_ = other.attribute_.Clone();
			this.reportQos_ = other.reportQos_;
			this.reportingAccount_ = ((other.reportingAccount_ != null) ? other.reportingAccount_.Clone() : null);
			this.reportingGameAccount_ = ((other.reportingGameAccount_ != null) ? other.reportingGameAccount_.Clone() : null);
			this.reportTimestamp_ = other.reportTimestamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600874C RID: 34636 RVA: 0x0020DB84 File Offset: 0x0020BD84
		[DebuggerNonUserCode]
		public Report Clone()
		{
			return new Report(this);
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0600874D RID: 34637 RVA: 0x0020DB9C File Offset: 0x0020BD9C
		// (set) Token: 0x0600874E RID: 34638 RVA: 0x0020DBBD File Offset: 0x0020BDBD
		[DebuggerNonUserCode]
		public string ReportType
		{
			get
			{
				return this.reportType_ ?? Report.ReportTypeDefaultValue;
			}
			set
			{
				this.reportType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600874F RID: 34639 RVA: 0x0020DBD4 File Offset: 0x0020BDD4
		[DebuggerNonUserCode]
		public bool HasReportType
		{
			get
			{
				return this.reportType_ != null;
			}
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x0020DBEF File Offset: 0x0020BDEF
		[DebuggerNonUserCode]
		public void ClearReportType()
		{
			this.reportType_ = null;
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x06008751 RID: 34641 RVA: 0x0020DBFC File Offset: 0x0020BDFC
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x06008752 RID: 34642 RVA: 0x0020DC14 File Offset: 0x0020BE14
		// (set) Token: 0x06008753 RID: 34643 RVA: 0x0020DC45 File Offset: 0x0020BE45
		[DebuggerNonUserCode]
		public int ReportQos
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int reportQosDefaultValue;
				if (flag)
				{
					reportQosDefaultValue = this.reportQos_;
				}
				else
				{
					reportQosDefaultValue = Report.ReportQosDefaultValue;
				}
				return reportQosDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reportQos_ = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x06008754 RID: 34644 RVA: 0x0020DC60 File Offset: 0x0020BE60
		[DebuggerNonUserCode]
		public bool HasReportQos
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x0020DC7D File Offset: 0x0020BE7D
		[DebuggerNonUserCode]
		public void ClearReportQos()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x06008756 RID: 34646 RVA: 0x0020DC90 File Offset: 0x0020BE90
		// (set) Token: 0x06008757 RID: 34647 RVA: 0x0020DCA8 File Offset: 0x0020BEA8
		[DebuggerNonUserCode]
		public EntityId ReportingAccount
		{
			get
			{
				return this.reportingAccount_;
			}
			set
			{
				this.reportingAccount_ = value;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x06008758 RID: 34648 RVA: 0x0020DCB4 File Offset: 0x0020BEB4
		// (set) Token: 0x06008759 RID: 34649 RVA: 0x0020DCCC File Offset: 0x0020BECC
		[DebuggerNonUserCode]
		public EntityId ReportingGameAccount
		{
			get
			{
				return this.reportingGameAccount_;
			}
			set
			{
				this.reportingGameAccount_ = value;
			}
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600875A RID: 34650 RVA: 0x0020DCD8 File Offset: 0x0020BED8
		// (set) Token: 0x0600875B RID: 34651 RVA: 0x0020DD09 File Offset: 0x0020BF09
		[DebuggerNonUserCode]
		public ulong ReportTimestamp
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong reportTimestampDefaultValue;
				if (flag)
				{
					reportTimestampDefaultValue = this.reportTimestamp_;
				}
				else
				{
					reportTimestampDefaultValue = Report.ReportTimestampDefaultValue;
				}
				return reportTimestampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reportTimestamp_ = value;
			}
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x0600875C RID: 34652 RVA: 0x0020DD24 File Offset: 0x0020BF24
		[DebuggerNonUserCode]
		public bool HasReportTimestamp
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x0020DD41 File Offset: 0x0020BF41
		[DebuggerNonUserCode]
		public void ClearReportTimestamp()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x0020DD54 File Offset: 0x0020BF54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Report);
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x0020DD74 File Offset: 0x0020BF74
		[DebuggerNonUserCode]
		public bool Equals(Report other)
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
					bool flag4 = this.ReportType != other.ReportType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ReportQos != other.ReportQos;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.ReportingAccount, other.ReportingAccount);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.ReportingGameAccount, other.ReportingGameAccount);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ReportTimestamp != other.ReportTimestamp;
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

		// Token: 0x06008760 RID: 34656 RVA: 0x0020DE68 File Offset: 0x0020C068
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasReportType = this.HasReportType;
			if (hasReportType)
			{
				num ^= this.ReportType.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasReportQos = this.HasReportQos;
			if (hasReportQos)
			{
				num ^= this.ReportQos.GetHashCode();
			}
			bool flag = this.reportingAccount_ != null;
			if (flag)
			{
				num ^= this.ReportingAccount.GetHashCode();
			}
			bool flag2 = this.reportingGameAccount_ != null;
			if (flag2)
			{
				num ^= this.ReportingGameAccount.GetHashCode();
			}
			bool hasReportTimestamp = this.HasReportTimestamp;
			if (hasReportTimestamp)
			{
				num ^= this.ReportTimestamp.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008761 RID: 34657 RVA: 0x0020DF38 File Offset: 0x0020C138
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008762 RID: 34658 RVA: 0x0020DF50 File Offset: 0x0020C150
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008763 RID: 34659 RVA: 0x0020DF5C File Offset: 0x0020C15C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasReportType = this.HasReportType;
			if (hasReportType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ReportType);
			}
			this.attribute_.WriteTo(ref output, Report._repeated_attribute_codec);
			bool hasReportQos = this.HasReportQos;
			if (hasReportQos)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ReportQos);
			}
			bool flag = this.reportingAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ReportingAccount);
			}
			bool flag2 = this.reportingGameAccount_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ReportingGameAccount);
			}
			bool hasReportTimestamp = this.HasReportTimestamp;
			if (hasReportTimestamp)
			{
				output.WriteRawTag(49);
				output.WriteFixed64(this.ReportTimestamp);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008764 RID: 34660 RVA: 0x0020E04C File Offset: 0x0020C24C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasReportType = this.HasReportType;
			if (hasReportType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReportType);
			}
			num += this.attribute_.CalculateSize(Report._repeated_attribute_codec);
			bool hasReportQos = this.HasReportQos;
			if (hasReportQos)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportQos);
			}
			bool flag = this.reportingAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReportingAccount);
			}
			bool flag2 = this.reportingGameAccount_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReportingGameAccount);
			}
			bool hasReportTimestamp = this.HasReportTimestamp;
			if (hasReportTimestamp)
			{
				num += 9;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008765 RID: 34661 RVA: 0x0020E120 File Offset: 0x0020C320
		[DebuggerNonUserCode]
		public void MergeFrom(Report other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasReportType = other.HasReportType;
				if (hasReportType)
				{
					this.ReportType = other.ReportType;
				}
				this.attribute_.Add(other.attribute_);
				bool hasReportQos = other.HasReportQos;
				if (hasReportQos)
				{
					this.ReportQos = other.ReportQos;
				}
				bool flag2 = other.reportingAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.reportingAccount_ == null;
					if (flag3)
					{
						this.ReportingAccount = new EntityId();
					}
					this.ReportingAccount.MergeFrom(other.ReportingAccount);
				}
				bool flag4 = other.reportingGameAccount_ != null;
				if (flag4)
				{
					bool flag5 = this.reportingGameAccount_ == null;
					if (flag5)
					{
						this.ReportingGameAccount = new EntityId();
					}
					this.ReportingGameAccount.MergeFrom(other.ReportingGameAccount);
				}
				bool hasReportTimestamp = other.HasReportTimestamp;
				if (hasReportTimestamp)
				{
					this.ReportTimestamp = other.ReportTimestamp;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x0020E230 File Offset: 0x0020C430
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x0020E23C File Offset: 0x0020C43C
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
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_0040;
							}
							this.ReportQos = input.ReadInt32();
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, Report._repeated_attribute_codec);
						}
					}
					else
					{
						this.ReportType = input.ReadString();
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 49U)
						{
							goto IL_0040;
						}
						this.ReportTimestamp = input.ReadFixed64();
					}
					else
					{
						bool flag = this.reportingGameAccount_ == null;
						if (flag)
						{
							this.ReportingGameAccount = new EntityId();
						}
						input.ReadMessage(this.ReportingGameAccount);
					}
				}
				else
				{
					bool flag2 = this.reportingAccount_ == null;
					if (flag2)
					{
						this.ReportingAccount = new EntityId();
					}
					input.ReadMessage(this.ReportingAccount);
				}
				continue;
				IL_0040:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D39 RID: 15673
		private static readonly MessageParser<Report> _parser = new MessageParser<Report>(() => new Report());

		// Token: 0x04003D3A RID: 15674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D3B RID: 15675
		private int _hasBits0;

		// Token: 0x04003D3C RID: 15676
		public const int ReportTypeFieldNumber = 1;

		// Token: 0x04003D3D RID: 15677
		private static readonly string ReportTypeDefaultValue = "";

		// Token: 0x04003D3E RID: 15678
		private string reportType_;

		// Token: 0x04003D3F RID: 15679
		public const int AttributeFieldNumber = 2;

		// Token: 0x04003D40 RID: 15680
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04003D41 RID: 15681
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003D42 RID: 15682
		public const int ReportQosFieldNumber = 3;

		// Token: 0x04003D43 RID: 15683
		private static readonly int ReportQosDefaultValue = 0;

		// Token: 0x04003D44 RID: 15684
		private int reportQos_;

		// Token: 0x04003D45 RID: 15685
		public const int ReportingAccountFieldNumber = 4;

		// Token: 0x04003D46 RID: 15686
		private EntityId reportingAccount_;

		// Token: 0x04003D47 RID: 15687
		public const int ReportingGameAccountFieldNumber = 5;

		// Token: 0x04003D48 RID: 15688
		private EntityId reportingGameAccount_;

		// Token: 0x04003D49 RID: 15689
		public const int ReportTimestampFieldNumber = 6;

		// Token: 0x04003D4A RID: 15690
		private static readonly ulong ReportTimestampDefaultValue = 0UL;

		// Token: 0x04003D4B RID: 15691
		private ulong reportTimestamp_;
	}
}
