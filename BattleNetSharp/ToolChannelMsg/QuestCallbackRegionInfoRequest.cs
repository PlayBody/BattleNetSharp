using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C1 RID: 193
	public sealed class QuestCallbackRegionInfoRequest : IMessage<QuestCallbackRegionInfoRequest>, IMessage, IEquatable<QuestCallbackRegionInfoRequest>, IDeepCloneable<QuestCallbackRegionInfoRequest>, IBufferMessage
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0004292C File Offset: 0x00040B2C
		[DebuggerNonUserCode]
		public static MessageParser<QuestCallbackRegionInfoRequest> Parser
		{
			get
			{
				return QuestCallbackRegionInfoRequest._parser;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00042944 File Offset: 0x00040B44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[170];
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0004296C File Offset: 0x00040B6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestCallbackRegionInfoRequest.Descriptor;
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00042983 File Offset: 0x00040B83
		[DebuggerNonUserCode]
		public QuestCallbackRegionInfoRequest()
		{
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00042990 File Offset: 0x00040B90
		[DebuggerNonUserCode]
		public QuestCallbackRegionInfoRequest(QuestCallbackRegionInfoRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.questSno_ = other.questSno_;
			this.phaseUid_ = other.phaseUid_;
			this.callbackUid_ = other.callbackUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000429E8 File Offset: 0x00040BE8
		[DebuggerNonUserCode]
		public QuestCallbackRegionInfoRequest Clone()
		{
			return new QuestCallbackRegionInfoRequest(this);
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00042A00 File Offset: 0x00040C00
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x00042A31 File Offset: 0x00040C31
		[DebuggerNonUserCode]
		public int QuestSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int questSnoDefaultValue;
				if (flag)
				{
					questSnoDefaultValue = this.questSno_;
				}
				else
				{
					questSnoDefaultValue = QuestCallbackRegionInfoRequest.QuestSnoDefaultValue;
				}
				return questSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.questSno_ = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00042A4C File Offset: 0x00040C4C
		[DebuggerNonUserCode]
		public bool HasQuestSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00042A69 File Offset: 0x00040C69
		[DebuggerNonUserCode]
		public void ClearQuestSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00042A7C File Offset: 0x00040C7C
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x00042AAD File Offset: 0x00040CAD
		[DebuggerNonUserCode]
		public uint PhaseUid
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint phaseUidDefaultValue;
				if (flag)
				{
					phaseUidDefaultValue = this.phaseUid_;
				}
				else
				{
					phaseUidDefaultValue = QuestCallbackRegionInfoRequest.PhaseUidDefaultValue;
				}
				return phaseUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.phaseUid_ = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00042AC8 File Offset: 0x00040CC8
		[DebuggerNonUserCode]
		public bool HasPhaseUid
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00042AE5 File Offset: 0x00040CE5
		[DebuggerNonUserCode]
		public void ClearPhaseUid()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00042AF8 File Offset: 0x00040CF8
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00042B29 File Offset: 0x00040D29
		[DebuggerNonUserCode]
		public uint CallbackUid
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint callbackUidDefaultValue;
				if (flag)
				{
					callbackUidDefaultValue = this.callbackUid_;
				}
				else
				{
					callbackUidDefaultValue = QuestCallbackRegionInfoRequest.CallbackUidDefaultValue;
				}
				return callbackUidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.callbackUid_ = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x00042B44 File Offset: 0x00040D44
		[DebuggerNonUserCode]
		public bool HasCallbackUid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00042B61 File Offset: 0x00040D61
		[DebuggerNonUserCode]
		public void ClearCallbackUid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00042B74 File Offset: 0x00040D74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestCallbackRegionInfoRequest);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00042B94 File Offset: 0x00040D94
		[DebuggerNonUserCode]
		public bool Equals(QuestCallbackRegionInfoRequest other)
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
					bool flag4 = this.QuestSno != other.QuestSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PhaseUid != other.PhaseUid;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CallbackUid != other.CallbackUid;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00042C20 File Offset: 0x00040E20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00042CAC File Offset: 0x00040EAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00042CC4 File Offset: 0x00040EC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00042CD0 File Offset: 0x00040ED0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasQuestSno = this.HasQuestSno;
			if (hasQuestSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestSno);
			}
			bool hasPhaseUid = this.HasPhaseUid;
			if (hasPhaseUid)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PhaseUid);
			}
			bool hasCallbackUid = this.HasCallbackUid;
			if (hasCallbackUid)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CallbackUid);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00042D60 File Offset: 0x00040F60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00042DEC File Offset: 0x00040FEC
		[DebuggerNonUserCode]
		public void MergeFrom(QuestCallbackRegionInfoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00042E67 File Offset: 0x00041067
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00042E74 File Offset: 0x00041074
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CallbackUid = input.ReadUInt32();
						}
					}
					else
					{
						this.PhaseUid = input.ReadUInt32();
					}
				}
				else
				{
					this.QuestSno = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400074A RID: 1866
		private static readonly MessageParser<QuestCallbackRegionInfoRequest> _parser = new MessageParser<QuestCallbackRegionInfoRequest>(() => new QuestCallbackRegionInfoRequest());

		// Token: 0x0400074B RID: 1867
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400074C RID: 1868
		private int _hasBits0;

		// Token: 0x0400074D RID: 1869
		public const int QuestSnoFieldNumber = 1;

		// Token: 0x0400074E RID: 1870
		private static readonly int QuestSnoDefaultValue = 0;

		// Token: 0x0400074F RID: 1871
		private int questSno_;

		// Token: 0x04000750 RID: 1872
		public const int PhaseUidFieldNumber = 2;

		// Token: 0x04000751 RID: 1873
		private static readonly uint PhaseUidDefaultValue = 0U;

		// Token: 0x04000752 RID: 1874
		private uint phaseUid_;

		// Token: 0x04000753 RID: 1875
		public const int CallbackUidFieldNumber = 3;

		// Token: 0x04000754 RID: 1876
		private static readonly uint CallbackUidDefaultValue = 0U;

		// Token: 0x04000755 RID: 1877
		private uint callbackUid_;
	}
}
