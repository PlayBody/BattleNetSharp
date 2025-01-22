using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200014E RID: 334
	public sealed class QueueEntryKey : IMessage<QueueEntryKey>, IMessage, IEquatable<QueueEntryKey>, IDeepCloneable<QueueEntryKey>, IBufferMessage
	{
		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x00086A40 File Offset: 0x00084C40
		[DebuggerNonUserCode]
		public static MessageParser<QueueEntryKey> Parser
		{
			get
			{
				return QueueEntryKey._parser;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x00086A58 File Offset: 0x00084C58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x00086A7C File Offset: 0x00084C7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueEntryKey.Descriptor;
			}
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00086A93 File Offset: 0x00084C93
		[DebuggerNonUserCode]
		public QueueEntryKey()
		{
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00086AA0 File Offset: 0x00084CA0
		[DebuggerNonUserCode]
		public QueueEntryKey(QueueEntryKey other)
			: this()
		{
			this.queueId_ = ((other.queueId_ != null) ? other.queueId_.Clone() : null);
			this.entryId_ = other.entryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00086AF0 File Offset: 0x00084CF0
		[DebuggerNonUserCode]
		public QueueEntryKey Clone()
		{
			return new QueueEntryKey(this);
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x00086B08 File Offset: 0x00084D08
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x00086B20 File Offset: 0x00084D20
		[DebuggerNonUserCode]
		public QueueId QueueId
		{
			get
			{
				return this.queueId_;
			}
			set
			{
				this.queueId_ = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00086B2C File Offset: 0x00084D2C
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00086B4D File Offset: 0x00084D4D
		[DebuggerNonUserCode]
		public string EntryId
		{
			get
			{
				return this.entryId_ ?? QueueEntryKey.EntryIdDefaultValue;
			}
			set
			{
				this.entryId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00086B64 File Offset: 0x00084D64
		[DebuggerNonUserCode]
		public bool HasEntryId
		{
			get
			{
				return this.entryId_ != null;
			}
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00086B7F File Offset: 0x00084D7F
		[DebuggerNonUserCode]
		public void ClearEntryId()
		{
			this.entryId_ = null;
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00086B8C File Offset: 0x00084D8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueEntryKey);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00086BAC File Offset: 0x00084DAC
		[DebuggerNonUserCode]
		public bool Equals(QueueEntryKey other)
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
					bool flag4 = !object.Equals(this.QueueId, other.QueueId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EntryId != other.EntryId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00086C20 File Offset: 0x00084E20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.queueId_ != null;
			if (flag)
			{
				num ^= this.QueueId.GetHashCode();
			}
			bool hasEntryId = this.HasEntryId;
			if (hasEntryId)
			{
				num ^= this.EntryId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00086C88 File Offset: 0x00084E88
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00086CA0 File Offset: 0x00084EA0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00086CAC File Offset: 0x00084EAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.queueId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.QueueId);
			}
			bool hasEntryId = this.HasEntryId;
			if (hasEntryId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.EntryId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00086D20 File Offset: 0x00084F20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.queueId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueueId);
			}
			bool hasEntryId = this.HasEntryId;
			if (hasEntryId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EntryId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00086D90 File Offset: 0x00084F90
		[DebuggerNonUserCode]
		public void MergeFrom(QueueEntryKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.queueId_ != null;
				if (flag2)
				{
					bool flag3 = this.queueId_ == null;
					if (flag3)
					{
						this.QueueId = new QueueId();
					}
					this.QueueId.MergeFrom(other.QueueId);
				}
				bool hasEntryId = other.HasEntryId;
				if (hasEntryId)
				{
					this.EntryId = other.EntryId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00086E15 File Offset: 0x00085015
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00086E20 File Offset: 0x00085020
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
						this.EntryId = input.ReadString();
					}
				}
				else
				{
					bool flag = this.queueId_ == null;
					if (flag)
					{
						this.QueueId = new QueueId();
					}
					input.ReadMessage(this.QueueId);
				}
			}
		}

		// Token: 0x04000F3E RID: 3902
		private static readonly MessageParser<QueueEntryKey> _parser = new MessageParser<QueueEntryKey>(() => new QueueEntryKey());

		// Token: 0x04000F3F RID: 3903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F40 RID: 3904
		public const int QueueIdFieldNumber = 1;

		// Token: 0x04000F41 RID: 3905
		private QueueId queueId_;

		// Token: 0x04000F42 RID: 3906
		public const int EntryIdFieldNumber = 2;

		// Token: 0x04000F43 RID: 3907
		private static readonly string EntryIdDefaultValue = "";

		// Token: 0x04000F44 RID: 3908
		private string entryId_;
	}
}
