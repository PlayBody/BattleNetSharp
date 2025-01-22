using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002E1 RID: 737
	public sealed class MessageOptions : IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>, IBufferMessage
	{
		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06004DAC RID: 19884 RVA: 0x00129328 File Offset: 0x00127528
		[DebuggerNonUserCode]
		public static MessageParser<MessageOptions> Parser
		{
			get
			{
				return MessageOptions._parser;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06004DAD RID: 19885 RVA: 0x00129340 File Offset: 0x00127540
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelemetryExtensionsReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06004DAE RID: 19886 RVA: 0x00129364 File Offset: 0x00127564
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageOptions.Descriptor;
			}
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x0012937B File Offset: 0x0012757B
		[DebuggerNonUserCode]
		public MessageOptions()
		{
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00129388 File Offset: 0x00127588
		[DebuggerNonUserCode]
		public MessageOptions(MessageOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.realtime_ = other.realtime_;
			this.longterm_ = other.longterm_;
			this.metricSet_ = other.metricSet_;
			this.metric_ = other.metric_;
			this.entityTimeSeries_ = other.entityTimeSeries_;
			this.logging_ = other.logging_;
			this.attribution_ = other.attribution_;
			this.crm_ = other.crm_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x0012941C File Offset: 0x0012761C
		[DebuggerNonUserCode]
		public MessageOptions Clone()
		{
			return new MessageOptions(this);
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x00129434 File Offset: 0x00127634
		// (set) Token: 0x06004DB3 RID: 19891 RVA: 0x00129465 File Offset: 0x00127665
		[DebuggerNonUserCode]
		public bool Realtime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool realtimeDefaultValue;
				if (flag)
				{
					realtimeDefaultValue = this.realtime_;
				}
				else
				{
					realtimeDefaultValue = MessageOptions.RealtimeDefaultValue;
				}
				return realtimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.realtime_ = value;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x00129480 File Offset: 0x00127680
		[DebuggerNonUserCode]
		public bool HasRealtime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x0012949D File Offset: 0x0012769D
		[DebuggerNonUserCode]
		public void ClearRealtime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x001294B0 File Offset: 0x001276B0
		// (set) Token: 0x06004DB7 RID: 19895 RVA: 0x001294E1 File Offset: 0x001276E1
		[DebuggerNonUserCode]
		public bool Longterm
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool longtermDefaultValue;
				if (flag)
				{
					longtermDefaultValue = this.longterm_;
				}
				else
				{
					longtermDefaultValue = MessageOptions.LongtermDefaultValue;
				}
				return longtermDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.longterm_ = value;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x001294FC File Offset: 0x001276FC
		[DebuggerNonUserCode]
		public bool HasLongterm
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00129519 File Offset: 0x00127719
		[DebuggerNonUserCode]
		public void ClearLongterm()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x0012952C File Offset: 0x0012772C
		// (set) Token: 0x06004DBB RID: 19899 RVA: 0x0012955D File Offset: 0x0012775D
		[DebuggerNonUserCode]
		public bool MetricSet
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool metricSetDefaultValue;
				if (flag)
				{
					metricSetDefaultValue = this.metricSet_;
				}
				else
				{
					metricSetDefaultValue = MessageOptions.MetricSetDefaultValue;
				}
				return metricSetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.metricSet_ = value;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06004DBC RID: 19900 RVA: 0x00129578 File Offset: 0x00127778
		[DebuggerNonUserCode]
		public bool HasMetricSet
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x00129595 File Offset: 0x00127795
		[DebuggerNonUserCode]
		public void ClearMetricSet()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x001295A8 File Offset: 0x001277A8
		// (set) Token: 0x06004DBF RID: 19903 RVA: 0x001295D9 File Offset: 0x001277D9
		[DebuggerNonUserCode]
		public bool Metric
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool metricDefaultValue;
				if (flag)
				{
					metricDefaultValue = this.metric_;
				}
				else
				{
					metricDefaultValue = MessageOptions.MetricDefaultValue;
				}
				return metricDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.metric_ = value;
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x001295F4 File Offset: 0x001277F4
		[DebuggerNonUserCode]
		public bool HasMetric
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x00129611 File Offset: 0x00127811
		[DebuggerNonUserCode]
		public void ClearMetric()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x00129624 File Offset: 0x00127824
		// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x00129656 File Offset: 0x00127856
		[DebuggerNonUserCode]
		public bool EntityTimeSeries
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool entityTimeSeriesDefaultValue;
				if (flag)
				{
					entityTimeSeriesDefaultValue = this.entityTimeSeries_;
				}
				else
				{
					entityTimeSeriesDefaultValue = MessageOptions.EntityTimeSeriesDefaultValue;
				}
				return entityTimeSeriesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.entityTimeSeries_ = value;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x00129670 File Offset: 0x00127870
		[DebuggerNonUserCode]
		public bool HasEntityTimeSeries
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x0012968E File Offset: 0x0012788E
		[DebuggerNonUserCode]
		public void ClearEntityTimeSeries()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x001296A0 File Offset: 0x001278A0
		// (set) Token: 0x06004DC7 RID: 19911 RVA: 0x001296D2 File Offset: 0x001278D2
		[DebuggerNonUserCode]
		public bool Logging
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool loggingDefaultValue;
				if (flag)
				{
					loggingDefaultValue = this.logging_;
				}
				else
				{
					loggingDefaultValue = MessageOptions.LoggingDefaultValue;
				}
				return loggingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.logging_ = value;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x001296EC File Offset: 0x001278EC
		[DebuggerNonUserCode]
		public bool HasLogging
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x0012970A File Offset: 0x0012790A
		[DebuggerNonUserCode]
		public void ClearLogging()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x0012971C File Offset: 0x0012791C
		// (set) Token: 0x06004DCB RID: 19915 RVA: 0x0012973D File Offset: 0x0012793D
		[DebuggerNonUserCode]
		public string Attribution
		{
			get
			{
				return this.attribution_ ?? MessageOptions.AttributionDefaultValue;
			}
			set
			{
				this.attribution_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06004DCC RID: 19916 RVA: 0x00129754 File Offset: 0x00127954
		[DebuggerNonUserCode]
		public bool HasAttribution
		{
			get
			{
				return this.attribution_ != null;
			}
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x0012976F File Offset: 0x0012796F
		[DebuggerNonUserCode]
		public void ClearAttribution()
		{
			this.attribution_ = null;
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x0012977C File Offset: 0x0012797C
		// (set) Token: 0x06004DCF RID: 19919 RVA: 0x0012979D File Offset: 0x0012799D
		[DebuggerNonUserCode]
		public string Crm
		{
			get
			{
				return this.crm_ ?? MessageOptions.CrmDefaultValue;
			}
			set
			{
				this.crm_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x001297B4 File Offset: 0x001279B4
		[DebuggerNonUserCode]
		public bool HasCrm
		{
			get
			{
				return this.crm_ != null;
			}
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x001297CF File Offset: 0x001279CF
		[DebuggerNonUserCode]
		public void ClearCrm()
		{
			this.crm_ = null;
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x001297DC File Offset: 0x001279DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageOptions);
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x001297FC File Offset: 0x001279FC
		[DebuggerNonUserCode]
		public bool Equals(MessageOptions other)
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
					bool flag4 = this.Realtime != other.Realtime;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Longterm != other.Longterm;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MetricSet != other.MetricSet;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Metric != other.Metric;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.EntityTimeSeries != other.EntityTimeSeries;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Logging != other.Logging;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Attribution != other.Attribution;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.Crm != other.Crm;
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

		// Token: 0x06004DD4 RID: 19924 RVA: 0x00129924 File Offset: 0x00127B24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRealtime = this.HasRealtime;
			if (hasRealtime)
			{
				num ^= this.Realtime.GetHashCode();
			}
			bool hasLongterm = this.HasLongterm;
			if (hasLongterm)
			{
				num ^= this.Longterm.GetHashCode();
			}
			bool hasMetricSet = this.HasMetricSet;
			if (hasMetricSet)
			{
				num ^= this.MetricSet.GetHashCode();
			}
			bool hasMetric = this.HasMetric;
			if (hasMetric)
			{
				num ^= this.Metric.GetHashCode();
			}
			bool hasEntityTimeSeries = this.HasEntityTimeSeries;
			if (hasEntityTimeSeries)
			{
				num ^= this.EntityTimeSeries.GetHashCode();
			}
			bool hasLogging = this.HasLogging;
			if (hasLogging)
			{
				num ^= this.Logging.GetHashCode();
			}
			bool hasAttribution = this.HasAttribution;
			if (hasAttribution)
			{
				num ^= this.Attribution.GetHashCode();
			}
			bool hasCrm = this.HasCrm;
			if (hasCrm)
			{
				num ^= this.Crm.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x00129A38 File Offset: 0x00127C38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x00129A50 File Offset: 0x00127C50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00129A5C File Offset: 0x00127C5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRealtime = this.HasRealtime;
			if (hasRealtime)
			{
				output.WriteRawTag(160, 6);
				output.WriteBool(this.Realtime);
			}
			bool hasLongterm = this.HasLongterm;
			if (hasLongterm)
			{
				output.WriteRawTag(176, 9);
				output.WriteBool(this.Longterm);
			}
			bool hasMetricSet = this.HasMetricSet;
			if (hasMetricSet)
			{
				output.WriteRawTag(192, 12);
				output.WriteBool(this.MetricSet);
			}
			bool hasMetric = this.HasMetric;
			if (hasMetric)
			{
				output.WriteRawTag(200, 12);
				output.WriteBool(this.Metric);
			}
			bool hasEntityTimeSeries = this.HasEntityTimeSeries;
			if (hasEntityTimeSeries)
			{
				output.WriteRawTag(232, 18);
				output.WriteBool(this.EntityTimeSeries);
			}
			bool hasLogging = this.HasLogging;
			if (hasLogging)
			{
				output.WriteRawTag(136, 25);
				output.WriteBool(this.Logging);
			}
			bool hasAttribution = this.HasAttribution;
			if (hasAttribution)
			{
				output.WriteRawTag(170, 31);
				output.WriteString(this.Attribution);
			}
			bool hasCrm = this.HasCrm;
			if (hasCrm)
			{
				output.WriteRawTag(202, 37);
				output.WriteString(this.Crm);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x00129BC8 File Offset: 0x00127DC8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRealtime = this.HasRealtime;
			if (hasRealtime)
			{
				num += 3;
			}
			bool hasLongterm = this.HasLongterm;
			if (hasLongterm)
			{
				num += 3;
			}
			bool hasMetricSet = this.HasMetricSet;
			if (hasMetricSet)
			{
				num += 3;
			}
			bool hasMetric = this.HasMetric;
			if (hasMetric)
			{
				num += 3;
			}
			bool hasEntityTimeSeries = this.HasEntityTimeSeries;
			if (hasEntityTimeSeries)
			{
				num += 3;
			}
			bool hasLogging = this.HasLogging;
			if (hasLogging)
			{
				num += 3;
			}
			bool hasAttribution = this.HasAttribution;
			if (hasAttribution)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Attribution);
			}
			bool hasCrm = this.HasCrm;
			if (hasCrm)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.Crm);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x00129CA0 File Offset: 0x00127EA0
		[DebuggerNonUserCode]
		public void MergeFrom(MessageOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRealtime = other.HasRealtime;
				if (hasRealtime)
				{
					this.Realtime = other.Realtime;
				}
				bool hasLongterm = other.HasLongterm;
				if (hasLongterm)
				{
					this.Longterm = other.Longterm;
				}
				bool hasMetricSet = other.HasMetricSet;
				if (hasMetricSet)
				{
					this.MetricSet = other.MetricSet;
				}
				bool hasMetric = other.HasMetric;
				if (hasMetric)
				{
					this.Metric = other.Metric;
				}
				bool hasEntityTimeSeries = other.HasEntityTimeSeries;
				if (hasEntityTimeSeries)
				{
					this.EntityTimeSeries = other.EntityTimeSeries;
				}
				bool hasLogging = other.HasLogging;
				if (hasLogging)
				{
					this.Logging = other.Logging;
				}
				bool hasAttribution = other.HasAttribution;
				if (hasAttribution)
				{
					this.Attribution = other.Attribution;
				}
				bool hasCrm = other.HasCrm;
				if (hasCrm)
				{
					this.Crm = other.Crm;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x00129DA5 File Offset: 0x00127FA5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x00129DB0 File Offset: 0x00127FB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 1608U)
				{
					if (num3 <= 1200U)
					{
						if (num3 != 800U)
						{
							if (num3 != 1200U)
							{
								goto IL_0085;
							}
							this.Longterm = input.ReadBool();
						}
						else
						{
							this.Realtime = input.ReadBool();
						}
					}
					else if (num3 != 1600U)
					{
						if (num3 != 1608U)
						{
							goto IL_0085;
						}
						this.Metric = input.ReadBool();
					}
					else
					{
						this.MetricSet = input.ReadBool();
					}
				}
				else if (num3 <= 3208U)
				{
					if (num3 != 2408U)
					{
						if (num3 != 3208U)
						{
							goto IL_0085;
						}
						this.Logging = input.ReadBool();
					}
					else
					{
						this.EntityTimeSeries = input.ReadBool();
					}
				}
				else if (num3 != 4010U)
				{
					if (num3 != 4810U)
					{
						goto IL_0085;
					}
					this.Crm = input.ReadString();
				}
				else
				{
					this.Attribution = input.ReadString();
				}
				continue;
				IL_0085:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022A1 RID: 8865
		private static readonly MessageParser<MessageOptions> _parser = new MessageParser<MessageOptions>(() => new MessageOptions());

		// Token: 0x040022A2 RID: 8866
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A3 RID: 8867
		private int _hasBits0;

		// Token: 0x040022A4 RID: 8868
		public const int RealtimeFieldNumber = 100;

		// Token: 0x040022A5 RID: 8869
		private static readonly bool RealtimeDefaultValue = false;

		// Token: 0x040022A6 RID: 8870
		private bool realtime_;

		// Token: 0x040022A7 RID: 8871
		public const int LongtermFieldNumber = 150;

		// Token: 0x040022A8 RID: 8872
		private static readonly bool LongtermDefaultValue = false;

		// Token: 0x040022A9 RID: 8873
		private bool longterm_;

		// Token: 0x040022AA RID: 8874
		public const int MetricSetFieldNumber = 200;

		// Token: 0x040022AB RID: 8875
		private static readonly bool MetricSetDefaultValue = false;

		// Token: 0x040022AC RID: 8876
		private bool metricSet_;

		// Token: 0x040022AD RID: 8877
		public const int MetricFieldNumber = 201;

		// Token: 0x040022AE RID: 8878
		private static readonly bool MetricDefaultValue = false;

		// Token: 0x040022AF RID: 8879
		private bool metric_;

		// Token: 0x040022B0 RID: 8880
		public const int EntityTimeSeriesFieldNumber = 301;

		// Token: 0x040022B1 RID: 8881
		private static readonly bool EntityTimeSeriesDefaultValue = false;

		// Token: 0x040022B2 RID: 8882
		private bool entityTimeSeries_;

		// Token: 0x040022B3 RID: 8883
		public const int LoggingFieldNumber = 401;

		// Token: 0x040022B4 RID: 8884
		private static readonly bool LoggingDefaultValue = false;

		// Token: 0x040022B5 RID: 8885
		private bool logging_;

		// Token: 0x040022B6 RID: 8886
		public const int AttributionFieldNumber = 501;

		// Token: 0x040022B7 RID: 8887
		private static readonly string AttributionDefaultValue = "";

		// Token: 0x040022B8 RID: 8888
		private string attribution_;

		// Token: 0x040022B9 RID: 8889
		public const int CrmFieldNumber = 601;

		// Token: 0x040022BA RID: 8890
		private static readonly string CrmDefaultValue = "";

		// Token: 0x040022BB RID: 8891
		private string crm_;
	}
}
