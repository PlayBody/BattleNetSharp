using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C2 RID: 194
	public sealed class QuestCallbackRegionInfoResponse : IMessage<QuestCallbackRegionInfoResponse>, IMessage, IEquatable<QuestCallbackRegionInfoResponse>, IDeepCloneable<QuestCallbackRegionInfoResponse>, IBufferMessage
	{
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00042F20 File Offset: 0x00041120
		[DebuggerNonUserCode]
		public static MessageParser<QuestCallbackRegionInfoResponse> Parser
		{
			get
			{
				return QuestCallbackRegionInfoResponse._parser;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00042F38 File Offset: 0x00041138
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[171];
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00042F60 File Offset: 0x00041160
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestCallbackRegionInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00042F77 File Offset: 0x00041177
		[DebuggerNonUserCode]
		public QuestCallbackRegionInfoResponse()
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00042F8C File Offset: 0x0004118C
		[DebuggerNonUserCode]
		public QuestCallbackRegionInfoResponse(QuestCallbackRegionInfoResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.success_ = other.success_;
			this.questSno_ = other.questSno_;
			this.phaseUid_ = other.phaseUid_;
			this.callbackUid_ = other.callbackUid_;
			this.callbackObjectiveLocationData_ = other.callbackObjectiveLocationData_.Clone();
			this.worldSno_ = other.worldSno_;
			this.defaultPolygonRegionData_ = ((other.defaultPolygonRegionData_ != null) ? other.defaultPolygonRegionData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00043028 File Offset: 0x00041228
		[DebuggerNonUserCode]
		public QuestCallbackRegionInfoResponse Clone()
		{
			return new QuestCallbackRegionInfoResponse(this);
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00043040 File Offset: 0x00041240
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x00043071 File Offset: 0x00041271
		[DebuggerNonUserCode]
		public bool Success
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool successDefaultValue;
				if (flag)
				{
					successDefaultValue = this.success_;
				}
				else
				{
					successDefaultValue = QuestCallbackRegionInfoResponse.SuccessDefaultValue;
				}
				return successDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.success_ = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x0004308C File Offset: 0x0004128C
		[DebuggerNonUserCode]
		public bool HasSuccess
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000430A9 File Offset: 0x000412A9
		[DebuggerNonUserCode]
		public void ClearSuccess()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x000430BC File Offset: 0x000412BC
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x000430ED File Offset: 0x000412ED
		[DebuggerNonUserCode]
		public int QuestSno
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int questSnoDefaultValue;
				if (flag)
				{
					questSnoDefaultValue = this.questSno_;
				}
				else
				{
					questSnoDefaultValue = QuestCallbackRegionInfoResponse.QuestSnoDefaultValue;
				}
				return questSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.questSno_ = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00043108 File Offset: 0x00041308
		[DebuggerNonUserCode]
		public bool HasQuestSno
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00043125 File Offset: 0x00041325
		[DebuggerNonUserCode]
		public void ClearQuestSno()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00043138 File Offset: 0x00041338
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x00043169 File Offset: 0x00041369
		[DebuggerNonUserCode]
		public uint PhaseUid
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint phaseUidDefaultValue;
				if (flag)
				{
					phaseUidDefaultValue = this.phaseUid_;
				}
				else
				{
					phaseUidDefaultValue = QuestCallbackRegionInfoResponse.PhaseUidDefaultValue;
				}
				return phaseUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.phaseUid_ = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00043184 File Offset: 0x00041384
		[DebuggerNonUserCode]
		public bool HasPhaseUid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000431A1 File Offset: 0x000413A1
		[DebuggerNonUserCode]
		public void ClearPhaseUid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x000431B4 File Offset: 0x000413B4
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x000431E5 File Offset: 0x000413E5
		[DebuggerNonUserCode]
		public uint CallbackUid
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint callbackUidDefaultValue;
				if (flag)
				{
					callbackUidDefaultValue = this.callbackUid_;
				}
				else
				{
					callbackUidDefaultValue = QuestCallbackRegionInfoResponse.CallbackUidDefaultValue;
				}
				return callbackUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.callbackUid_ = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00043200 File Offset: 0x00041400
		[DebuggerNonUserCode]
		public bool HasCallbackUid
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0004321D File Offset: 0x0004141D
		[DebuggerNonUserCode]
		public void ClearCallbackUid()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00043230 File Offset: 0x00041430
		[DebuggerNonUserCode]
		public RepeatedField<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData> CallbackObjectiveLocationData
		{
			get
			{
				return this.callbackObjectiveLocationData_;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00043248 File Offset: 0x00041448
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x0004327A File Offset: 0x0004147A
		[DebuggerNonUserCode]
		public int WorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int worldSnoDefaultValue;
				if (flag)
				{
					worldSnoDefaultValue = this.worldSno_;
				}
				else
				{
					worldSnoDefaultValue = QuestCallbackRegionInfoResponse.WorldSnoDefaultValue;
				}
				return worldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.worldSno_ = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00043294 File Offset: 0x00041494
		[DebuggerNonUserCode]
		public bool HasWorldSno
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000432B2 File Offset: 0x000414B2
		[DebuggerNonUserCode]
		public void ClearWorldSno()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x000432C4 File Offset: 0x000414C4
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x000432DC File Offset: 0x000414DC
		[DebuggerNonUserCode]
		public QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData DefaultPolygonRegionData
		{
			get
			{
				return this.defaultPolygonRegionData_;
			}
			set
			{
				this.defaultPolygonRegionData_ = value;
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000432E8 File Offset: 0x000414E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestCallbackRegionInfoResponse);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00043308 File Offset: 0x00041508
		[DebuggerNonUserCode]
		public bool Equals(QuestCallbackRegionInfoResponse other)
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
					bool flag4 = this.Success != other.Success;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.QuestSno != other.QuestSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PhaseUid != other.PhaseUid;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CallbackUid != other.CallbackUid;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.callbackObjectiveLocationData_.Equals(other.callbackObjectiveLocationData_);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.WorldSno != other.WorldSno;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.DefaultPolygonRegionData, other.DefaultPolygonRegionData);
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
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

		// Token: 0x06001269 RID: 4713 RVA: 0x00043418 File Offset: 0x00041618
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num ^= this.Success.GetHashCode();
			}
			bool hasQuestSno = this.HasQuestSno;
			if (hasQuestSno)
			{
				num ^= this.QuestSno.GetHashCode();
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				num ^= this.PhaseUid.GetHashCode();
			}
			bool hasCallbackUid = this.HasCallbackUid;
			if (hasCallbackUid)
			{
				num ^= this.CallbackUid.GetHashCode();
			}
			num ^= this.callbackObjectiveLocationData_.GetHashCode();
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num ^= this.WorldSno.GetHashCode();
			}
			bool flag = this.defaultPolygonRegionData_ != null;
			if (flag)
			{
				num ^= this.DefaultPolygonRegionData.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0004350C File Offset: 0x0004170C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00043524 File Offset: 0x00041724
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00043530 File Offset: 0x00041730
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Success);
			}
			bool hasQuestSno = this.HasQuestSno;
			if (hasQuestSno)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.QuestSno);
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PhaseUid);
			}
			bool hasCallbackUid = this.HasCallbackUid;
			if (hasCallbackUid)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CallbackUid);
			}
			this.callbackObjectiveLocationData_.WriteTo(ref output, QuestCallbackRegionInfoResponse._repeated_callbackObjectiveLocationData_codec);
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WorldSno);
			}
			bool flag = this.defaultPolygonRegionData_ != null;
			if (flag)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.DefaultPolygonRegionData);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00043640 File Offset: 0x00041840
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num += 2;
			}
			bool hasQuestSno = this.HasQuestSno;
			if (hasQuestSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestSno);
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PhaseUid);
			}
			bool hasCallbackUid = this.HasCallbackUid;
			if (hasCallbackUid)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CallbackUid);
			}
			num += this.callbackObjectiveLocationData_.CalculateSize(QuestCallbackRegionInfoResponse._repeated_callbackObjectiveLocationData_codec);
			bool hasWorldSno = this.HasWorldSno;
			if (hasWorldSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldSno);
			}
			bool flag = this.defaultPolygonRegionData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DefaultPolygonRegionData);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00043730 File Offset: 0x00041930
		[DebuggerNonUserCode]
		public void MergeFrom(QuestCallbackRegionInfoResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSuccess = other.HasSuccess;
				if (hasSuccess)
				{
					this.Success = other.Success;
				}
				bool hasQuestSno = other.HasQuestSno;
				if (hasQuestSno)
				{
					this.QuestSno = other.QuestSno;
				}
				bool hasPhaseUid = other.HasPhaseUid;
				if (hasPhaseUid)
				{
					this.PhaseUid = other.PhaseUid;
				}
				bool hasCallbackUid = other.HasCallbackUid;
				if (hasCallbackUid)
				{
					this.CallbackUid = other.CallbackUid;
				}
				this.callbackObjectiveLocationData_.Add(other.callbackObjectiveLocationData_);
				bool hasWorldSno = other.HasWorldSno;
				if (hasWorldSno)
				{
					this.WorldSno = other.WorldSno;
				}
				bool flag2 = other.defaultPolygonRegionData_ != null;
				if (flag2)
				{
					bool flag3 = this.defaultPolygonRegionData_ == null;
					if (flag3)
					{
						this.DefaultPolygonRegionData = new QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData();
					}
					this.DefaultPolygonRegionData.MergeFrom(other.DefaultPolygonRegionData);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00043836 File Offset: 0x00041A36
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00043844 File Offset: 0x00041A44
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_0048;
							}
							this.PhaseUid = input.ReadUInt32();
						}
						else
						{
							this.QuestSno = input.ReadInt32();
						}
					}
					else
					{
						this.Success = input.ReadBool();
					}
				}
				else if (num3 <= 42U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0048;
						}
						this.callbackObjectiveLocationData_.AddEntriesFrom(ref input, QuestCallbackRegionInfoResponse._repeated_callbackObjectiveLocationData_codec);
					}
					else
					{
						this.CallbackUid = input.ReadUInt32();
					}
				}
				else if (num3 != 48U)
				{
					if (num3 != 58U)
					{
						goto IL_0048;
					}
					bool flag = this.defaultPolygonRegionData_ == null;
					if (flag)
					{
						this.DefaultPolygonRegionData = new QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData();
					}
					input.ReadMessage(this.DefaultPolygonRegionData);
				}
				else
				{
					this.WorldSno = input.ReadInt32();
				}
				continue;
				IL_0048:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000756 RID: 1878
		private static readonly MessageParser<QuestCallbackRegionInfoResponse> _parser = new MessageParser<QuestCallbackRegionInfoResponse>(() => new QuestCallbackRegionInfoResponse());

		// Token: 0x04000757 RID: 1879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000758 RID: 1880
		private int _hasBits0;

		// Token: 0x04000759 RID: 1881
		public const int SuccessFieldNumber = 1;

		// Token: 0x0400075A RID: 1882
		private static readonly bool SuccessDefaultValue = false;

		// Token: 0x0400075B RID: 1883
		private bool success_;

		// Token: 0x0400075C RID: 1884
		public const int QuestSnoFieldNumber = 2;

		// Token: 0x0400075D RID: 1885
		private static readonly int QuestSnoDefaultValue = 0;

		// Token: 0x0400075E RID: 1886
		private int questSno_;

		// Token: 0x0400075F RID: 1887
		public const int PhaseUidFieldNumber = 3;

		// Token: 0x04000760 RID: 1888
		private static readonly uint PhaseUidDefaultValue = 0U;

		// Token: 0x04000761 RID: 1889
		private uint phaseUid_;

		// Token: 0x04000762 RID: 1890
		public const int CallbackUidFieldNumber = 4;

		// Token: 0x04000763 RID: 1891
		private static readonly uint CallbackUidDefaultValue = 0U;

		// Token: 0x04000764 RID: 1892
		private uint callbackUid_;

		// Token: 0x04000765 RID: 1893
		public const int CallbackObjectiveLocationDataFieldNumber = 5;

		// Token: 0x04000766 RID: 1894
		private static readonly FieldCodec<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData> _repeated_callbackObjectiveLocationData_codec = FieldCodec.ForMessage<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData>(42U, QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData.Parser);

		// Token: 0x04000767 RID: 1895
		private readonly RepeatedField<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData> callbackObjectiveLocationData_ = new RepeatedField<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData>();

		// Token: 0x04000768 RID: 1896
		public const int WorldSnoFieldNumber = 6;

		// Token: 0x04000769 RID: 1897
		private static readonly int WorldSnoDefaultValue = 0;

		// Token: 0x0400076A RID: 1898
		private int worldSno_;

		// Token: 0x0400076B RID: 1899
		public const int DefaultPolygonRegionDataFieldNumber = 7;

		// Token: 0x0400076C RID: 1900
		private QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData defaultPolygonRegionData_;

		// Token: 0x02000BDD RID: 3037
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200146C RID: 5228
			public sealed class CallbackObjectiveLocationData : IMessage<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData>, IMessage, IEquatable<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData>, IDeepCloneable<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData>, IBufferMessage
			{
				// Token: 0x17003A2C RID: 14892
				// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x004D24B4 File Offset: 0x004D06B4
				[DebuggerNonUserCode]
				public static MessageParser<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData> Parser
				{
					get
					{
						return QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData._parser;
					}
				}

				// Token: 0x17003A2D RID: 14893
				// (get) Token: 0x0600E4D9 RID: 58585 RVA: 0x004D24CC File Offset: 0x004D06CC
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestCallbackRegionInfoResponse.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003A2E RID: 14894
				// (get) Token: 0x0600E4DA RID: 58586 RVA: 0x004D24F0 File Offset: 0x004D06F0
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData.Descriptor;
					}
				}

				// Token: 0x0600E4DB RID: 58587 RVA: 0x004D2507 File Offset: 0x004D0707
				[DebuggerNonUserCode]
				public CallbackObjectiveLocationData()
				{
				}

				// Token: 0x0600E4DC RID: 58588 RVA: 0x004D2511 File Offset: 0x004D0711
				[DebuggerNonUserCode]
				public CallbackObjectiveLocationData(QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData other)
					: this()
				{
					this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E4DD RID: 58589 RVA: 0x004D2548 File Offset: 0x004D0748
				[DebuggerNonUserCode]
				public QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData Clone()
				{
					return new QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData(this);
				}

				// Token: 0x17003A2F RID: 14895
				// (get) Token: 0x0600E4DE RID: 58590 RVA: 0x004D2560 File Offset: 0x004D0760
				// (set) Token: 0x0600E4DF RID: 58591 RVA: 0x004D2578 File Offset: 0x004D0778
				[DebuggerNonUserCode]
				public Vector2 Pos
				{
					get
					{
						return this.pos_;
					}
					set
					{
						this.pos_ = value;
					}
				}

				// Token: 0x0600E4E0 RID: 58592 RVA: 0x004D2584 File Offset: 0x004D0784
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData);
				}

				// Token: 0x0600E4E1 RID: 58593 RVA: 0x004D25A4 File Offset: 0x004D07A4
				[DebuggerNonUserCode]
				public bool Equals(QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData other)
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
							bool flag4 = !object.Equals(this.Pos, other.Pos);
							flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
					return flag2;
				}

				// Token: 0x0600E4E2 RID: 58594 RVA: 0x004D2600 File Offset: 0x004D0800
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool flag = this.pos_ != null;
					if (flag)
					{
						num ^= this.Pos.GetHashCode();
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E4E3 RID: 58595 RVA: 0x004D2650 File Offset: 0x004D0850
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E4E4 RID: 58596 RVA: 0x004D2668 File Offset: 0x004D0868
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E4E5 RID: 58597 RVA: 0x004D2674 File Offset: 0x004D0874
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool flag = this.pos_ != null;
					if (flag)
					{
						output.WriteRawTag(10);
						output.WriteMessage(this.Pos);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E4E6 RID: 58598 RVA: 0x004D26C4 File Offset: 0x004D08C4
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool flag = this.pos_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E4E7 RID: 58599 RVA: 0x004D2718 File Offset: 0x004D0918
				[DebuggerNonUserCode]
				public void MergeFrom(QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool flag2 = other.pos_ != null;
						if (flag2)
						{
							bool flag3 = this.pos_ == null;
							if (flag3)
							{
								this.Pos = new Vector2();
							}
							this.Pos.MergeFrom(other.Pos);
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E4E8 RID: 58600 RVA: 0x004D2784 File Offset: 0x004D0984
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E4E9 RID: 58601 RVA: 0x004D2790 File Offset: 0x004D0990
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 != 10U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.pos_ == null;
							if (flag)
							{
								this.Pos = new Vector2();
							}
							input.ReadMessage(this.Pos);
						}
					}
				}

				// Token: 0x0400A2F7 RID: 41719
				private static readonly MessageParser<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData> _parser = new MessageParser<QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData>(() => new QuestCallbackRegionInfoResponse.Types.CallbackObjectiveLocationData());

				// Token: 0x0400A2F8 RID: 41720
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2F9 RID: 41721
				public const int PosFieldNumber = 1;

				// Token: 0x0400A2FA RID: 41722
				private Vector2 pos_;
			}

			// Token: 0x0200146D RID: 5229
			public sealed class CallbackPolygonRegionData : IMessage<QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData>, IMessage, IEquatable<QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData>, IDeepCloneable<QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData>, IBufferMessage
			{
				// Token: 0x17003A30 RID: 14896
				// (get) Token: 0x0600E4EB RID: 58603 RVA: 0x004D281C File Offset: 0x004D0A1C
				[DebuggerNonUserCode]
				public static MessageParser<QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData> Parser
				{
					get
					{
						return QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData._parser;
					}
				}

				// Token: 0x17003A31 RID: 14897
				// (get) Token: 0x0600E4EC RID: 58604 RVA: 0x004D2834 File Offset: 0x004D0A34
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return QuestCallbackRegionInfoResponse.Descriptor.NestedTypes[1];
					}
				}

				// Token: 0x17003A32 RID: 14898
				// (get) Token: 0x0600E4ED RID: 58605 RVA: 0x004D2858 File Offset: 0x004D0A58
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData.Descriptor;
					}
				}

				// Token: 0x0600E4EE RID: 58606 RVA: 0x004D286F File Offset: 0x004D0A6F
				[DebuggerNonUserCode]
				public CallbackPolygonRegionData()
				{
				}

				// Token: 0x0600E4EF RID: 58607 RVA: 0x004D2884 File Offset: 0x004D0A84
				[DebuggerNonUserCode]
				public CallbackPolygonRegionData(QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData other)
					: this()
				{
					this.pos_ = other.pos_.Clone();
					this.centerPos_ = ((other.centerPos_ != null) ? other.centerPos_.Clone() : null);
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E4F0 RID: 58608 RVA: 0x004D28D8 File Offset: 0x004D0AD8
				[DebuggerNonUserCode]
				public QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData Clone()
				{
					return new QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData(this);
				}

				// Token: 0x17003A33 RID: 14899
				// (get) Token: 0x0600E4F1 RID: 58609 RVA: 0x004D28F0 File Offset: 0x004D0AF0
				[DebuggerNonUserCode]
				public RepeatedField<Vector2> Pos
				{
					get
					{
						return this.pos_;
					}
				}

				// Token: 0x17003A34 RID: 14900
				// (get) Token: 0x0600E4F2 RID: 58610 RVA: 0x004D2908 File Offset: 0x004D0B08
				// (set) Token: 0x0600E4F3 RID: 58611 RVA: 0x004D2920 File Offset: 0x004D0B20
				[DebuggerNonUserCode]
				public Vector2 CenterPos
				{
					get
					{
						return this.centerPos_;
					}
					set
					{
						this.centerPos_ = value;
					}
				}

				// Token: 0x0600E4F4 RID: 58612 RVA: 0x004D292C File Offset: 0x004D0B2C
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData);
				}

				// Token: 0x0600E4F5 RID: 58613 RVA: 0x004D294C File Offset: 0x004D0B4C
				[DebuggerNonUserCode]
				public bool Equals(QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData other)
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
							bool flag4 = !this.pos_.Equals(other.pos_);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = !object.Equals(this.CenterPos, other.CenterPos);
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E4F6 RID: 58614 RVA: 0x004D29C4 File Offset: 0x004D0BC4
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					num ^= this.pos_.GetHashCode();
					bool flag = this.centerPos_ != null;
					if (flag)
					{
						num ^= this.CenterPos.GetHashCode();
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E4F7 RID: 58615 RVA: 0x004D2A20 File Offset: 0x004D0C20
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E4F8 RID: 58616 RVA: 0x004D2A38 File Offset: 0x004D0C38
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E4F9 RID: 58617 RVA: 0x004D2A44 File Offset: 0x004D0C44
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					this.pos_.WriteTo(ref output, QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData._repeated_pos_codec);
					bool flag = this.centerPos_ != null;
					if (flag)
					{
						output.WriteRawTag(18);
						output.WriteMessage(this.CenterPos);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E4FA RID: 58618 RVA: 0x004D2AA8 File Offset: 0x004D0CA8
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					num += this.pos_.CalculateSize(QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData._repeated_pos_codec);
					bool flag = this.centerPos_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.CenterPos);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E4FB RID: 58619 RVA: 0x004D2B0C File Offset: 0x004D0D0C
				[DebuggerNonUserCode]
				public void MergeFrom(QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData other)
				{
					bool flag = other == null;
					if (!flag)
					{
						this.pos_.Add(other.pos_);
						bool flag2 = other.centerPos_ != null;
						if (flag2)
						{
							bool flag3 = this.centerPos_ == null;
							if (flag3)
							{
								this.CenterPos = new Vector2();
							}
							this.CenterPos.MergeFrom(other.CenterPos);
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E4FC RID: 58620 RVA: 0x004D2B8A File Offset: 0x004D0D8A
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E4FD RID: 58621 RVA: 0x004D2B98 File Offset: 0x004D0D98
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
							}
							else
							{
								bool flag = this.centerPos_ == null;
								if (flag)
								{
									this.CenterPos = new Vector2();
								}
								input.ReadMessage(this.CenterPos);
							}
						}
						else
						{
							this.pos_.AddEntriesFrom(ref input, QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData._repeated_pos_codec);
						}
					}
				}

				// Token: 0x0400A2FB RID: 41723
				private static readonly MessageParser<QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData> _parser = new MessageParser<QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData>(() => new QuestCallbackRegionInfoResponse.Types.CallbackPolygonRegionData());

				// Token: 0x0400A2FC RID: 41724
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A2FD RID: 41725
				public const int PosFieldNumber = 1;

				// Token: 0x0400A2FE RID: 41726
				private static readonly FieldCodec<Vector2> _repeated_pos_codec = FieldCodec.ForMessage<Vector2>(10U, Vector2.Parser);

				// Token: 0x0400A2FF RID: 41727
				private readonly RepeatedField<Vector2> pos_ = new RepeatedField<Vector2>();

				// Token: 0x0400A300 RID: 41728
				public const int CenterPosFieldNumber = 2;

				// Token: 0x0400A301 RID: 41729
				private Vector2 centerPos_;
			}
		}
	}
}
