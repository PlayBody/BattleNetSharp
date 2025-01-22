using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200028B RID: 651
	public sealed class QueueUpdate : IMessage<QueueUpdate>, IMessage, IEquatable<QueueUpdate>, IDeepCloneable<QueueUpdate>, IBufferMessage
	{
		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x0600454C RID: 17740 RVA: 0x0010A8F0 File Offset: 0x00108AF0
		[DebuggerNonUserCode]
		public static MessageParser<QueueUpdate> Parser
		{
			get
			{
				return QueueUpdate._parser;
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x0010A908 File Offset: 0x00108B08
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[123];
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600454E RID: 17742 RVA: 0x0010A92C File Offset: 0x00108B2C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueUpdate.Descriptor;
			}
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x0010A943 File Offset: 0x00108B43
		[DebuggerNonUserCode]
		public QueueUpdate()
		{
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x0010A950 File Offset: 0x00108B50
		[DebuggerNonUserCode]
		public QueueUpdate(QueueUpdate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entryKey_ = ((other.entryKey_ != null) ? other.entryKey_.Clone() : null);
			this.avgWaitSeconds_ = other.avgWaitSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x0010A9AC File Offset: 0x00108BAC
		[DebuggerNonUserCode]
		public QueueUpdate Clone()
		{
			return new QueueUpdate(this);
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06004552 RID: 17746 RVA: 0x0010A9C4 File Offset: 0x00108BC4
		// (set) Token: 0x06004553 RID: 17747 RVA: 0x0010A9DC File Offset: 0x00108BDC
		[DebuggerNonUserCode]
		public QueueEntryKey EntryKey
		{
			get
			{
				return this.entryKey_;
			}
			set
			{
				this.entryKey_ = value;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x0010A9E8 File Offset: 0x00108BE8
		// (set) Token: 0x06004555 RID: 17749 RVA: 0x0010AA19 File Offset: 0x00108C19
		[DebuggerNonUserCode]
		public uint AvgWaitSeconds
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint avgWaitSecondsDefaultValue;
				if (flag)
				{
					avgWaitSecondsDefaultValue = this.avgWaitSeconds_;
				}
				else
				{
					avgWaitSecondsDefaultValue = QueueUpdate.AvgWaitSecondsDefaultValue;
				}
				return avgWaitSecondsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.avgWaitSeconds_ = value;
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x0010AA34 File Offset: 0x00108C34
		[DebuggerNonUserCode]
		public bool HasAvgWaitSeconds
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x0010AA51 File Offset: 0x00108C51
		[DebuggerNonUserCode]
		public void ClearAvgWaitSeconds()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x0010AA64 File Offset: 0x00108C64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueUpdate);
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x0010AA84 File Offset: 0x00108C84
		[DebuggerNonUserCode]
		public bool Equals(QueueUpdate other)
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
					bool flag4 = !object.Equals(this.EntryKey, other.EntryKey);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AvgWaitSeconds != other.AvgWaitSeconds;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x0010AAF8 File Offset: 0x00108CF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entryKey_ != null;
			if (flag)
			{
				num ^= this.EntryKey.GetHashCode();
			}
			bool hasAvgWaitSeconds = this.HasAvgWaitSeconds;
			if (hasAvgWaitSeconds)
			{
				num ^= this.AvgWaitSeconds.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x0010AB64 File Offset: 0x00108D64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0010AB7C File Offset: 0x00108D7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x0010AB88 File Offset: 0x00108D88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entryKey_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntryKey);
			}
			bool hasAvgWaitSeconds = this.HasAvgWaitSeconds;
			if (hasAvgWaitSeconds)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AvgWaitSeconds);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x0010ABFC File Offset: 0x00108DFC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entryKey_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntryKey);
			}
			bool hasAvgWaitSeconds = this.HasAvgWaitSeconds;
			if (hasAvgWaitSeconds)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvgWaitSeconds);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x0010AC6C File Offset: 0x00108E6C
		[DebuggerNonUserCode]
		public void MergeFrom(QueueUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entryKey_ != null;
				if (flag2)
				{
					bool flag3 = this.entryKey_ == null;
					if (flag3)
					{
						this.EntryKey = new QueueEntryKey();
					}
					this.EntryKey.MergeFrom(other.EntryKey);
				}
				bool hasAvgWaitSeconds = other.HasAvgWaitSeconds;
				if (hasAvgWaitSeconds)
				{
					this.AvgWaitSeconds = other.AvgWaitSeconds;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x0010ACF1 File Offset: 0x00108EF1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x0010ACFC File Offset: 0x00108EFC
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvgWaitSeconds = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.entryKey_ == null;
					if (flag)
					{
						this.EntryKey = new QueueEntryKey();
					}
					input.ReadMessage(this.EntryKey);
				}
			}
		}

		// Token: 0x04001F05 RID: 7941
		private static readonly MessageParser<QueueUpdate> _parser = new MessageParser<QueueUpdate>(() => new QueueUpdate());

		// Token: 0x04001F06 RID: 7942
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F07 RID: 7943
		private int _hasBits0;

		// Token: 0x04001F08 RID: 7944
		public const int EntryKeyFieldNumber = 1;

		// Token: 0x04001F09 RID: 7945
		private QueueEntryKey entryKey_;

		// Token: 0x04001F0A RID: 7946
		public const int AvgWaitSecondsFieldNumber = 2;

		// Token: 0x04001F0B RID: 7947
		private static readonly uint AvgWaitSecondsDefaultValue = 0U;

		// Token: 0x04001F0C RID: 7948
		private uint avgWaitSeconds_;
	}
}
