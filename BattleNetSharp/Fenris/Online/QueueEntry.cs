using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200014F RID: 335
	public sealed class QueueEntry : IMessage<QueueEntry>, IMessage, IEquatable<QueueEntry>, IDeepCloneable<QueueEntry>, IBufferMessage
	{
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x00086ECC File Offset: 0x000850CC
		[DebuggerNonUserCode]
		public static MessageParser<QueueEntry> Parser
		{
			get
			{
				return QueueEntry._parser;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x00086EE4 File Offset: 0x000850E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00086F08 File Offset: 0x00085108
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueEntry.Descriptor;
			}
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00086F1F File Offset: 0x0008511F
		[DebuggerNonUserCode]
		public QueueEntry()
		{
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00086F2C File Offset: 0x0008512C
		[DebuggerNonUserCode]
		public QueueEntry(QueueEntry other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entryId_ = other.entryId_;
			this.payload_ = other.payload_;
			this.acquisitionToken_ = other.acquisitionToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00086F84 File Offset: 0x00085184
		[DebuggerNonUserCode]
		public QueueEntry Clone()
		{
			return new QueueEntry(this);
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00086F9C File Offset: 0x0008519C
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x00086FBD File Offset: 0x000851BD
		[DebuggerNonUserCode]
		public string EntryId
		{
			get
			{
				return this.entryId_ ?? QueueEntry.EntryIdDefaultValue;
			}
			set
			{
				this.entryId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x00086FD4 File Offset: 0x000851D4
		[DebuggerNonUserCode]
		public bool HasEntryId
		{
			get
			{
				return this.entryId_ != null;
			}
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00086FEF File Offset: 0x000851EF
		[DebuggerNonUserCode]
		public void ClearEntryId()
		{
			this.entryId_ = null;
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x00086FFC File Offset: 0x000851FC
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x0008701D File Offset: 0x0008521D
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			get
			{
				return this.payload_ ?? QueueEntry.PayloadDefaultValue;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x00087034 File Offset: 0x00085234
		[DebuggerNonUserCode]
		public bool HasPayload
		{
			get
			{
				return this.payload_ != null;
			}
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00087052 File Offset: 0x00085252
		[DebuggerNonUserCode]
		public void ClearPayload()
		{
			this.payload_ = null;
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x0008705C File Offset: 0x0008525C
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x0008708D File Offset: 0x0008528D
		[DebuggerNonUserCode]
		public uint AcquisitionToken
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint acquisitionTokenDefaultValue;
				if (flag)
				{
					acquisitionTokenDefaultValue = this.acquisitionToken_;
				}
				else
				{
					acquisitionTokenDefaultValue = QueueEntry.AcquisitionTokenDefaultValue;
				}
				return acquisitionTokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.acquisitionToken_ = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000870A8 File Offset: 0x000852A8
		[DebuggerNonUserCode]
		public bool HasAcquisitionToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000870C5 File Offset: 0x000852C5
		[DebuggerNonUserCode]
		public void ClearAcquisitionToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000870D8 File Offset: 0x000852D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueEntry);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000870F8 File Offset: 0x000852F8
		[DebuggerNonUserCode]
		public bool Equals(QueueEntry other)
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
					bool flag4 = this.EntryId != other.EntryId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Payload != other.Payload;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.AcquisitionToken != other.AcquisitionToken;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00087184 File Offset: 0x00085384
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEntryId = this.HasEntryId;
			if (hasEntryId)
			{
				num ^= this.EntryId.GetHashCode();
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num ^= this.Payload.GetHashCode();
			}
			bool hasAcquisitionToken = this.HasAcquisitionToken;
			if (hasAcquisitionToken)
			{
				num ^= this.AcquisitionToken.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00087208 File Offset: 0x00085408
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00087220 File Offset: 0x00085420
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0008722C File Offset: 0x0008542C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEntryId = this.HasEntryId;
			if (hasEntryId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.EntryId);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Payload);
			}
			bool hasAcquisitionToken = this.HasAcquisitionToken;
			if (hasAcquisitionToken)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AcquisitionToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000872BC File Offset: 0x000854BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEntryId = this.HasEntryId;
			if (hasEntryId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EntryId);
			}
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			bool hasAcquisitionToken = this.HasAcquisitionToken;
			if (hasAcquisitionToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AcquisitionToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00087348 File Offset: 0x00085548
		[DebuggerNonUserCode]
		public void MergeFrom(QueueEntry other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEntryId = other.HasEntryId;
				if (hasEntryId)
				{
					this.EntryId = other.EntryId;
				}
				bool hasPayload = other.HasPayload;
				if (hasPayload)
				{
					this.Payload = other.Payload;
				}
				bool hasAcquisitionToken = other.HasAcquisitionToken;
				if (hasAcquisitionToken)
				{
					this.AcquisitionToken = other.AcquisitionToken;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000873C3 File Offset: 0x000855C3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000873D0 File Offset: 0x000855D0
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AcquisitionToken = input.ReadUInt32();
						}
					}
					else
					{
						this.Payload = input.ReadBytes();
					}
				}
				else
				{
					this.EntryId = input.ReadString();
				}
			}
		}

		// Token: 0x04000F45 RID: 3909
		private static readonly MessageParser<QueueEntry> _parser = new MessageParser<QueueEntry>(() => new QueueEntry());

		// Token: 0x04000F46 RID: 3910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F47 RID: 3911
		private int _hasBits0;

		// Token: 0x04000F48 RID: 3912
		public const int EntryIdFieldNumber = 1;

		// Token: 0x04000F49 RID: 3913
		private static readonly string EntryIdDefaultValue = "";

		// Token: 0x04000F4A RID: 3914
		private string entryId_;

		// Token: 0x04000F4B RID: 3915
		public const int PayloadFieldNumber = 2;

		// Token: 0x04000F4C RID: 3916
		private static readonly ByteString PayloadDefaultValue = ByteString.Empty;

		// Token: 0x04000F4D RID: 3917
		private ByteString payload_;

		// Token: 0x04000F4E RID: 3918
		public const int AcquisitionTokenFieldNumber = 3;

		// Token: 0x04000F4F RID: 3919
		private static readonly uint AcquisitionTokenDefaultValue = 0U;

		// Token: 0x04000F50 RID: 3920
		private uint acquisitionToken_;
	}
}
