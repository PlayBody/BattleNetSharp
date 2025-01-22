using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200014D RID: 333
	public sealed class QueueId : IMessage<QueueId>, IMessage, IEquatable<QueueId>, IDeepCloneable<QueueId>, IBufferMessage
	{
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x00086488 File Offset: 0x00084688
		[DebuggerNonUserCode]
		public static MessageParser<QueueId> Parser
		{
			get
			{
				return QueueId._parser;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000864A0 File Offset: 0x000846A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000864C4 File Offset: 0x000846C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueId.Descriptor;
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000864DB File Offset: 0x000846DB
		[DebuggerNonUserCode]
		public QueueId()
		{
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000864E8 File Offset: 0x000846E8
		[DebuggerNonUserCode]
		public QueueId(QueueId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.queueType_ = other.queueType_;
			this.id_ = other.id_;
			this.serverpool_ = other.serverpool_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00086540 File Offset: 0x00084740
		[DebuggerNonUserCode]
		public QueueId Clone()
		{
			return new QueueId(this);
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x00086558 File Offset: 0x00084758
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x00086589 File Offset: 0x00084789
		[DebuggerNonUserCode]
		public uint QueueType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint queueTypeDefaultValue;
				if (flag)
				{
					queueTypeDefaultValue = this.queueType_;
				}
				else
				{
					queueTypeDefaultValue = QueueId.QueueTypeDefaultValue;
				}
				return queueTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.queueType_ = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x000865A4 File Offset: 0x000847A4
		[DebuggerNonUserCode]
		public bool HasQueueType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000865C1 File Offset: 0x000847C1
		[DebuggerNonUserCode]
		public void ClearQueueType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x000865D4 File Offset: 0x000847D4
		// (set) Token: 0x06002285 RID: 8837 RVA: 0x000865F5 File Offset: 0x000847F5
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? QueueId.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x0008660C File Offset: 0x0008480C
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00086627 File Offset: 0x00084827
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00086634 File Offset: 0x00084834
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x00086655 File Offset: 0x00084855
		[DebuggerNonUserCode]
		public string Serverpool
		{
			get
			{
				return this.serverpool_ ?? QueueId.ServerpoolDefaultValue;
			}
			set
			{
				this.serverpool_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x0008666C File Offset: 0x0008486C
		[DebuggerNonUserCode]
		public bool HasServerpool
		{
			get
			{
				return this.serverpool_ != null;
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00086687 File Offset: 0x00084887
		[DebuggerNonUserCode]
		public void ClearServerpool()
		{
			this.serverpool_ = null;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00086694 File Offset: 0x00084894
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueId);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000866B4 File Offset: 0x000848B4
		[DebuggerNonUserCode]
		public bool Equals(QueueId other)
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
					bool flag4 = this.QueueType != other.QueueType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Serverpool != other.Serverpool;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00086740 File Offset: 0x00084940
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasQueueType = this.HasQueueType;
			if (hasQueueType)
			{
				num ^= this.QueueType.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasServerpool = this.HasServerpool;
			if (hasServerpool)
			{
				num ^= this.Serverpool.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000867C4 File Offset: 0x000849C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000867DC File Offset: 0x000849DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000867E8 File Offset: 0x000849E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasQueueType = this.HasQueueType;
			if (hasQueueType)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.QueueType);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Id);
			}
			bool hasServerpool = this.HasServerpool;
			if (hasServerpool)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Serverpool);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00086878 File Offset: 0x00084A78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasQueueType = this.HasQueueType;
			if (hasQueueType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QueueType);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool hasServerpool = this.HasServerpool;
			if (hasServerpool)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Serverpool);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00086904 File Offset: 0x00084B04
		[DebuggerNonUserCode]
		public void MergeFrom(QueueId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasQueueType = other.HasQueueType;
				if (hasQueueType)
				{
					this.QueueType = other.QueueType;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasServerpool = other.HasServerpool;
				if (hasServerpool)
				{
					this.Serverpool = other.Serverpool;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0008697F File Offset: 0x00084B7F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0008698C File Offset: 0x00084B8C
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Serverpool = input.ReadString();
						}
					}
					else
					{
						this.Id = input.ReadString();
					}
				}
				else
				{
					this.QueueType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F32 RID: 3890
		private static readonly MessageParser<QueueId> _parser = new MessageParser<QueueId>(() => new QueueId());

		// Token: 0x04000F33 RID: 3891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F34 RID: 3892
		private int _hasBits0;

		// Token: 0x04000F35 RID: 3893
		public const int QueueTypeFieldNumber = 1;

		// Token: 0x04000F36 RID: 3894
		private static readonly uint QueueTypeDefaultValue = 0U;

		// Token: 0x04000F37 RID: 3895
		private uint queueType_;

		// Token: 0x04000F38 RID: 3896
		public const int IdFieldNumber = 2;

		// Token: 0x04000F39 RID: 3897
		private static readonly string IdDefaultValue = "";

		// Token: 0x04000F3A RID: 3898
		private string id_;

		// Token: 0x04000F3B RID: 3899
		public const int ServerpoolFieldNumber = 3;

		// Token: 0x04000F3C RID: 3900
		private static readonly string ServerpoolDefaultValue = "";

		// Token: 0x04000F3D RID: 3901
		private string serverpool_;
	}
}
