using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002E8 RID: 744
	public sealed class FenrisTrace : IMessage<FenrisTrace>, IMessage, IEquatable<FenrisTrace>, IDeepCloneable<FenrisTrace>, IBufferMessage
	{
		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06004E4D RID: 20045 RVA: 0x0012BB14 File Offset: 0x00129D14
		[DebuggerNonUserCode]
		public static MessageParser<FenrisTrace> Parser
		{
			get
			{
				return FenrisTrace._parser;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06004E4E RID: 20046 RVA: 0x0012BB2C File Offset: 0x00129D2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FenrisTraceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x0012BB50 File Offset: 0x00129D50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FenrisTrace.Descriptor;
			}
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x0012BB67 File Offset: 0x00129D67
		[DebuggerNonUserCode]
		public FenrisTrace()
		{
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x0012BB7C File Offset: 0x00129D7C
		[DebuggerNonUserCode]
		public FenrisTrace(FenrisTrace other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.traceId_ = other.traceId_;
			this.parentSpanId_ = other.parentSpanId_;
			this.spanId_ = other.spanId_;
			this.requestTime_ = other.requestTime_;
			this.duration_ = other.duration_;
			this.serverName_ = other.serverName_;
			this.spanName_ = other.spanName_;
			this.gameAccountId_ = other.gameAccountId_;
			this.name_ = other.name_;
			this.log_ = other.log_.Clone();
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x0012BC38 File Offset: 0x00129E38
		[DebuggerNonUserCode]
		public FenrisTrace Clone()
		{
			return new FenrisTrace(this);
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x0012BC50 File Offset: 0x00129E50
		// (set) Token: 0x06004E54 RID: 20052 RVA: 0x0012BC71 File Offset: 0x00129E71
		[DebuggerNonUserCode]
		public string TraceId
		{
			get
			{
				return this.traceId_ ?? FenrisTrace.TraceIdDefaultValue;
			}
			set
			{
				this.traceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x0012BC88 File Offset: 0x00129E88
		[DebuggerNonUserCode]
		public bool HasTraceId
		{
			get
			{
				return this.traceId_ != null;
			}
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x0012BCA3 File Offset: 0x00129EA3
		[DebuggerNonUserCode]
		public void ClearTraceId()
		{
			this.traceId_ = null;
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x0012BCB0 File Offset: 0x00129EB0
		// (set) Token: 0x06004E58 RID: 20056 RVA: 0x0012BCD1 File Offset: 0x00129ED1
		[DebuggerNonUserCode]
		public string ParentSpanId
		{
			get
			{
				return this.parentSpanId_ ?? FenrisTrace.ParentSpanIdDefaultValue;
			}
			set
			{
				this.parentSpanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x0012BCE8 File Offset: 0x00129EE8
		[DebuggerNonUserCode]
		public bool HasParentSpanId
		{
			get
			{
				return this.parentSpanId_ != null;
			}
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x0012BD03 File Offset: 0x00129F03
		[DebuggerNonUserCode]
		public void ClearParentSpanId()
		{
			this.parentSpanId_ = null;
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06004E5B RID: 20059 RVA: 0x0012BD10 File Offset: 0x00129F10
		// (set) Token: 0x06004E5C RID: 20060 RVA: 0x0012BD31 File Offset: 0x00129F31
		[DebuggerNonUserCode]
		public string SpanId
		{
			get
			{
				return this.spanId_ ?? FenrisTrace.SpanIdDefaultValue;
			}
			set
			{
				this.spanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06004E5D RID: 20061 RVA: 0x0012BD48 File Offset: 0x00129F48
		[DebuggerNonUserCode]
		public bool HasSpanId
		{
			get
			{
				return this.spanId_ != null;
			}
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x0012BD63 File Offset: 0x00129F63
		[DebuggerNonUserCode]
		public void ClearSpanId()
		{
			this.spanId_ = null;
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06004E5F RID: 20063 RVA: 0x0012BD70 File Offset: 0x00129F70
		// (set) Token: 0x06004E60 RID: 20064 RVA: 0x0012BDA1 File Offset: 0x00129FA1
		[DebuggerNonUserCode]
		public ulong RequestTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong requestTimeDefaultValue;
				if (flag)
				{
					requestTimeDefaultValue = this.requestTime_;
				}
				else
				{
					requestTimeDefaultValue = FenrisTrace.RequestTimeDefaultValue;
				}
				return requestTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requestTime_ = value;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06004E61 RID: 20065 RVA: 0x0012BDBC File Offset: 0x00129FBC
		[DebuggerNonUserCode]
		public bool HasRequestTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x0012BDD9 File Offset: 0x00129FD9
		[DebuggerNonUserCode]
		public void ClearRequestTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x0012BDEC File Offset: 0x00129FEC
		// (set) Token: 0x06004E64 RID: 20068 RVA: 0x0012BE1D File Offset: 0x0012A01D
		[DebuggerNonUserCode]
		public ulong Duration
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong durationDefaultValue;
				if (flag)
				{
					durationDefaultValue = this.duration_;
				}
				else
				{
					durationDefaultValue = FenrisTrace.DurationDefaultValue;
				}
				return durationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.duration_ = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x0012BE38 File Offset: 0x0012A038
		[DebuggerNonUserCode]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x0012BE55 File Offset: 0x0012A055
		[DebuggerNonUserCode]
		public void ClearDuration()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x0012BE68 File Offset: 0x0012A068
		// (set) Token: 0x06004E68 RID: 20072 RVA: 0x0012BE89 File Offset: 0x0012A089
		[DebuggerNonUserCode]
		public string ServerName
		{
			get
			{
				return this.serverName_ ?? FenrisTrace.ServerNameDefaultValue;
			}
			set
			{
				this.serverName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06004E69 RID: 20073 RVA: 0x0012BEA0 File Offset: 0x0012A0A0
		[DebuggerNonUserCode]
		public bool HasServerName
		{
			get
			{
				return this.serverName_ != null;
			}
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x0012BEBB File Offset: 0x0012A0BB
		[DebuggerNonUserCode]
		public void ClearServerName()
		{
			this.serverName_ = null;
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06004E6B RID: 20075 RVA: 0x0012BEC8 File Offset: 0x0012A0C8
		// (set) Token: 0x06004E6C RID: 20076 RVA: 0x0012BEE9 File Offset: 0x0012A0E9
		[DebuggerNonUserCode]
		public string SpanName
		{
			get
			{
				return this.spanName_ ?? FenrisTrace.SpanNameDefaultValue;
			}
			set
			{
				this.spanName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x0012BF00 File Offset: 0x0012A100
		[DebuggerNonUserCode]
		public bool HasSpanName
		{
			get
			{
				return this.spanName_ != null;
			}
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x0012BF1B File Offset: 0x0012A11B
		[DebuggerNonUserCode]
		public void ClearSpanName()
		{
			this.spanName_ = null;
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06004E6F RID: 20079 RVA: 0x0012BF28 File Offset: 0x0012A128
		// (set) Token: 0x06004E70 RID: 20080 RVA: 0x0012BF59 File Offset: 0x0012A159
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = FenrisTrace.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06004E71 RID: 20081 RVA: 0x0012BF74 File Offset: 0x0012A174
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x0012BF91 File Offset: 0x0012A191
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06004E73 RID: 20083 RVA: 0x0012BFA4 File Offset: 0x0012A1A4
		// (set) Token: 0x06004E74 RID: 20084 RVA: 0x0012BFC5 File Offset: 0x0012A1C5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? FenrisTrace.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06004E75 RID: 20085 RVA: 0x0012BFDC File Offset: 0x0012A1DC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x0012BFF7 File Offset: 0x0012A1F7
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06004E77 RID: 20087 RVA: 0x0012C004 File Offset: 0x0012A204
		[DebuggerNonUserCode]
		public RepeatedField<string> Log
		{
			get
			{
				return this.log_;
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06004E78 RID: 20088 RVA: 0x0012C01C File Offset: 0x0012A21C
		// (set) Token: 0x06004E79 RID: 20089 RVA: 0x0012C04D File Offset: 0x0012A24D
		[DebuggerNonUserCode]
		public int Status
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = FenrisTrace.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.status_ = value;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06004E7A RID: 20090 RVA: 0x0012C068 File Offset: 0x0012A268
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x0012C085 File Offset: 0x0012A285
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x0012C098 File Offset: 0x0012A298
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FenrisTrace);
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x0012C0B8 File Offset: 0x0012A2B8
		[DebuggerNonUserCode]
		public bool Equals(FenrisTrace other)
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
					bool flag4 = this.TraceId != other.TraceId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ParentSpanId != other.ParentSpanId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SpanId != other.SpanId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RequestTime != other.RequestTime;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Duration != other.Duration;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ServerName != other.ServerName;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SpanName != other.SpanName;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.GameAccountId != other.GameAccountId;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.Name != other.Name;
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !this.log_.Equals(other.log_);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = this.Status != other.Status;
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

		// Token: 0x06004E7E RID: 20094 RVA: 0x0012C23C File Offset: 0x0012A43C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTraceId = this.HasTraceId;
			if (hasTraceId)
			{
				num ^= this.TraceId.GetHashCode();
			}
			bool hasParentSpanId = this.HasParentSpanId;
			if (hasParentSpanId)
			{
				num ^= this.ParentSpanId.GetHashCode();
			}
			bool hasSpanId = this.HasSpanId;
			if (hasSpanId)
			{
				num ^= this.SpanId.GetHashCode();
			}
			bool hasRequestTime = this.HasRequestTime;
			if (hasRequestTime)
			{
				num ^= this.RequestTime.GetHashCode();
			}
			bool hasDuration = this.HasDuration;
			if (hasDuration)
			{
				num ^= this.Duration.GetHashCode();
			}
			bool hasServerName = this.HasServerName;
			if (hasServerName)
			{
				num ^= this.ServerName.GetHashCode();
			}
			bool hasSpanName = this.HasSpanName;
			if (hasSpanName)
			{
				num ^= this.SpanName.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.log_.GetHashCode();
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x0012C390 File Offset: 0x0012A590
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x0012C3A8 File Offset: 0x0012A5A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x0012C3B4 File Offset: 0x0012A5B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTraceId = this.HasTraceId;
			if (hasTraceId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TraceId);
			}
			bool hasParentSpanId = this.HasParentSpanId;
			if (hasParentSpanId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ParentSpanId);
			}
			bool hasSpanId = this.HasSpanId;
			if (hasSpanId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SpanId);
			}
			bool hasRequestTime = this.HasRequestTime;
			if (hasRequestTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.RequestTime);
			}
			bool hasDuration = this.HasDuration;
			if (hasDuration)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.Duration);
			}
			bool hasServerName = this.HasServerName;
			if (hasServerName)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ServerName);
			}
			bool hasSpanName = this.HasSpanName;
			if (hasSpanName)
			{
				output.WriteRawTag(58);
				output.WriteString(this.SpanName);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Name);
			}
			this.log_.WriteTo(ref output, FenrisTrace._repeated_log_codec);
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Status);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x0012C554 File Offset: 0x0012A754
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTraceId = this.HasTraceId;
			if (hasTraceId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TraceId);
			}
			bool hasParentSpanId = this.HasParentSpanId;
			if (hasParentSpanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ParentSpanId);
			}
			bool hasSpanId = this.HasSpanId;
			if (hasSpanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SpanId);
			}
			bool hasRequestTime = this.HasRequestTime;
			if (hasRequestTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RequestTime);
			}
			bool hasDuration = this.HasDuration;
			if (hasDuration)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Duration);
			}
			bool hasServerName = this.HasServerName;
			if (hasServerName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ServerName);
			}
			bool hasSpanName = this.HasSpanName;
			if (hasSpanName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SpanName);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.log_.CalculateSize(FenrisTrace._repeated_log_codec);
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x0012C6C4 File Offset: 0x0012A8C4
		[DebuggerNonUserCode]
		public void MergeFrom(FenrisTrace other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTraceId = other.HasTraceId;
				if (hasTraceId)
				{
					this.TraceId = other.TraceId;
				}
				bool hasParentSpanId = other.HasParentSpanId;
				if (hasParentSpanId)
				{
					this.ParentSpanId = other.ParentSpanId;
				}
				bool hasSpanId = other.HasSpanId;
				if (hasSpanId)
				{
					this.SpanId = other.SpanId;
				}
				bool hasRequestTime = other.HasRequestTime;
				if (hasRequestTime)
				{
					this.RequestTime = other.RequestTime;
				}
				bool hasDuration = other.HasDuration;
				if (hasDuration)
				{
					this.Duration = other.Duration;
				}
				bool hasServerName = other.HasServerName;
				if (hasServerName)
				{
					this.ServerName = other.ServerName;
				}
				bool hasSpanName = other.HasSpanName;
				if (hasSpanName)
				{
					this.SpanName = other.SpanName;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this.log_.Add(other.log_);
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x0012C811 File Offset: 0x0012AA11
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x0012C81C File Offset: 0x0012AA1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 40U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_0088;
							}
							this.ParentSpanId = input.ReadString();
						}
						else
						{
							this.TraceId = input.ReadString();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							if (num3 != 40U)
							{
								goto IL_0088;
							}
							this.Duration = input.ReadUInt64();
						}
						else
						{
							this.RequestTime = input.ReadUInt64();
						}
					}
					else
					{
						this.SpanId = input.ReadString();
					}
				}
				else if (num3 <= 64U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							if (num3 != 64U)
							{
								goto IL_0088;
							}
							this.GameAccountId = input.ReadUInt32();
						}
						else
						{
							this.SpanName = input.ReadString();
						}
					}
					else
					{
						this.ServerName = input.ReadString();
					}
				}
				else if (num3 != 74U)
				{
					if (num3 != 82U)
					{
						if (num3 != 88U)
						{
							goto IL_0088;
						}
						this.Status = input.ReadInt32();
					}
					else
					{
						this.log_.AddEntriesFrom(ref input, FenrisTrace._repeated_log_codec);
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
				continue;
				IL_0088:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022F0 RID: 8944
		private static readonly MessageParser<FenrisTrace> _parser = new MessageParser<FenrisTrace>(() => new FenrisTrace());

		// Token: 0x040022F1 RID: 8945
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022F2 RID: 8946
		private int _hasBits0;

		// Token: 0x040022F3 RID: 8947
		public const int TraceIdFieldNumber = 1;

		// Token: 0x040022F4 RID: 8948
		private static readonly string TraceIdDefaultValue = "";

		// Token: 0x040022F5 RID: 8949
		private string traceId_;

		// Token: 0x040022F6 RID: 8950
		public const int ParentSpanIdFieldNumber = 2;

		// Token: 0x040022F7 RID: 8951
		private static readonly string ParentSpanIdDefaultValue = "";

		// Token: 0x040022F8 RID: 8952
		private string parentSpanId_;

		// Token: 0x040022F9 RID: 8953
		public const int SpanIdFieldNumber = 3;

		// Token: 0x040022FA RID: 8954
		private static readonly string SpanIdDefaultValue = "";

		// Token: 0x040022FB RID: 8955
		private string spanId_;

		// Token: 0x040022FC RID: 8956
		public const int RequestTimeFieldNumber = 4;

		// Token: 0x040022FD RID: 8957
		private static readonly ulong RequestTimeDefaultValue = 0UL;

		// Token: 0x040022FE RID: 8958
		private ulong requestTime_;

		// Token: 0x040022FF RID: 8959
		public const int DurationFieldNumber = 5;

		// Token: 0x04002300 RID: 8960
		private static readonly ulong DurationDefaultValue = 0UL;

		// Token: 0x04002301 RID: 8961
		private ulong duration_;

		// Token: 0x04002302 RID: 8962
		public const int ServerNameFieldNumber = 6;

		// Token: 0x04002303 RID: 8963
		private static readonly string ServerNameDefaultValue = "";

		// Token: 0x04002304 RID: 8964
		private string serverName_;

		// Token: 0x04002305 RID: 8965
		public const int SpanNameFieldNumber = 7;

		// Token: 0x04002306 RID: 8966
		private static readonly string SpanNameDefaultValue = "";

		// Token: 0x04002307 RID: 8967
		private string spanName_;

		// Token: 0x04002308 RID: 8968
		public const int GameAccountIdFieldNumber = 8;

		// Token: 0x04002309 RID: 8969
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x0400230A RID: 8970
		private uint gameAccountId_;

		// Token: 0x0400230B RID: 8971
		public const int NameFieldNumber = 9;

		// Token: 0x0400230C RID: 8972
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400230D RID: 8973
		private string name_;

		// Token: 0x0400230E RID: 8974
		public const int LogFieldNumber = 10;

		// Token: 0x0400230F RID: 8975
		private static readonly FieldCodec<string> _repeated_log_codec = FieldCodec.ForString(82U);

		// Token: 0x04002310 RID: 8976
		private readonly RepeatedField<string> log_ = new RepeatedField<string>();

		// Token: 0x04002311 RID: 8977
		public const int StatusFieldNumber = 11;

		// Token: 0x04002312 RID: 8978
		private static readonly int StatusDefaultValue = 0;

		// Token: 0x04002313 RID: 8979
		private int status_;
	}
}
