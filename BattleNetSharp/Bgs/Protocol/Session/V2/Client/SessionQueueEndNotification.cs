using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000557 RID: 1367
	public sealed class SessionQueueEndNotification : IMessage<SessionQueueEndNotification>, IMessage, IEquatable<SessionQueueEndNotification>, IDeepCloneable<SessionQueueEndNotification>, IBufferMessage
	{
		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x06008420 RID: 33824 RVA: 0x00201F38 File Offset: 0x00200138
		[DebuggerNonUserCode]
		public static MessageParser<SessionQueueEndNotification> Parser
		{
			get
			{
				return SessionQueueEndNotification._parser;
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x06008421 RID: 33825 RVA: 0x00201F50 File Offset: 0x00200150
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionListenerReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06008422 RID: 33826 RVA: 0x00201F74 File Offset: 0x00200174
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionQueueEndNotification.Descriptor;
			}
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x00201F8B File Offset: 0x0020018B
		[DebuggerNonUserCode]
		public SessionQueueEndNotification()
		{
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x00201F95 File Offset: 0x00200195
		[DebuggerNonUserCode]
		public SessionQueueEndNotification(SessionQueueEndNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x00201FC8 File Offset: 0x002001C8
		[DebuggerNonUserCode]
		public SessionQueueEndNotification Clone()
		{
			return new SessionQueueEndNotification(this);
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06008426 RID: 33830 RVA: 0x00201FE0 File Offset: 0x002001E0
		// (set) Token: 0x06008427 RID: 33831 RVA: 0x00202011 File Offset: 0x00200211
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = SessionQueueEndNotification.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.status_ = value;
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06008428 RID: 33832 RVA: 0x0020202C File Offset: 0x0020022C
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x00202049 File Offset: 0x00200249
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x0020205C File Offset: 0x0020025C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionQueueEndNotification);
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x0020207C File Offset: 0x0020027C
		[DebuggerNonUserCode]
		public bool Equals(SessionQueueEndNotification other)
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
					bool flag4 = this.Status != other.Status;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x002020D4 File Offset: 0x002002D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600842D RID: 33837 RVA: 0x00202124 File Offset: 0x00200324
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x0020213C File Offset: 0x0020033C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x00202148 File Offset: 0x00200348
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Status);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x00202194 File Offset: 0x00200394
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x002021E4 File Offset: 0x002003E4
		[DebuggerNonUserCode]
		public void MergeFrom(SessionQueueEndNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x0020222D File Offset: 0x0020042D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x00202238 File Offset: 0x00200438
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Status = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BF7 RID: 15351
		private static readonly MessageParser<SessionQueueEndNotification> _parser = new MessageParser<SessionQueueEndNotification>(() => new SessionQueueEndNotification());

		// Token: 0x04003BF8 RID: 15352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BF9 RID: 15353
		private int _hasBits0;

		// Token: 0x04003BFA RID: 15354
		public const int StatusFieldNumber = 1;

		// Token: 0x04003BFB RID: 15355
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04003BFC RID: 15356
		private uint status_;
	}
}
