using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000546 RID: 1350
	public sealed class SessionQueueEndNotification : IMessage<SessionQueueEndNotification>, IMessage, IEquatable<SessionQueueEndNotification>, IDeepCloneable<SessionQueueEndNotification>, IBufferMessage
	{
		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x060082AF RID: 33455 RVA: 0x001FBE28 File Offset: 0x001FA028
		[DebuggerNonUserCode]
		public static MessageParser<SessionQueueEndNotification> Parser
		{
			get
			{
				return SessionQueueEndNotification._parser;
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x060082B0 RID: 33456 RVA: 0x001FBE40 File Offset: 0x001FA040
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x060082B1 RID: 33457 RVA: 0x001FBE64 File Offset: 0x001FA064
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionQueueEndNotification.Descriptor;
			}
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x001FBE7B File Offset: 0x001FA07B
		[DebuggerNonUserCode]
		public SessionQueueEndNotification()
		{
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x001FBE88 File Offset: 0x001FA088
		[DebuggerNonUserCode]
		public SessionQueueEndNotification(SessionQueueEndNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x001FBEF0 File Offset: 0x001FA0F0
		[DebuggerNonUserCode]
		public SessionQueueEndNotification Clone()
		{
			return new SessionQueueEndNotification(this);
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x060082B5 RID: 33461 RVA: 0x001FBF08 File Offset: 0x001FA108
		// (set) Token: 0x060082B6 RID: 33462 RVA: 0x001FBF20 File Offset: 0x001FA120
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x060082B7 RID: 33463 RVA: 0x001FBF2C File Offset: 0x001FA12C
		// (set) Token: 0x060082B8 RID: 33464 RVA: 0x001FBF4D File Offset: 0x001FA14D
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? SessionQueueEndNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x060082B9 RID: 33465 RVA: 0x001FBF64 File Offset: 0x001FA164
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x060082BA RID: 33466 RVA: 0x001FBF7F File Offset: 0x001FA17F
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x060082BB RID: 33467 RVA: 0x001FBF8C File Offset: 0x001FA18C
		// (set) Token: 0x060082BC RID: 33468 RVA: 0x001FBFBD File Offset: 0x001FA1BD
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = SessionQueueEndNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x060082BD RID: 33469 RVA: 0x001FBFD8 File Offset: 0x001FA1D8
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x001FBFF5 File Offset: 0x001FA1F5
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x001FC008 File Offset: 0x001FA208
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionQueueEndNotification);
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x001FC028 File Offset: 0x001FA228
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SessionId != other.SessionId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x001FC0B8 File Offset: 0x001FA2B8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082C2 RID: 33474 RVA: 0x001FC140 File Offset: 0x001FA340
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060082C3 RID: 33475 RVA: 0x001FC158 File Offset: 0x001FA358
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082C4 RID: 33476 RVA: 0x001FC164 File Offset: 0x001FA364
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SessionId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082C5 RID: 33477 RVA: 0x001FC1F8 File Offset: 0x001FA3F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x001FC288 File Offset: 0x001FA488
		[DebuggerNonUserCode]
		public void MergeFrom(SessionQueueEndNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060082C7 RID: 33479 RVA: 0x001FC32B File Offset: 0x001FA52B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082C8 RID: 33480 RVA: 0x001FC338 File Offset: 0x001FA538
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
							this.Reason = input.ReadUInt32();
						}
					}
					else
					{
						this.SessionId = input.ReadString();
					}
				}
				else
				{
					bool flag = this.identity_ == null;
					if (flag)
					{
						this.Identity = new Identity();
					}
					input.ReadMessage(this.Identity);
				}
			}
		}

		// Token: 0x04003B20 RID: 15136
		private static readonly MessageParser<SessionQueueEndNotification> _parser = new MessageParser<SessionQueueEndNotification>(() => new SessionQueueEndNotification());

		// Token: 0x04003B21 RID: 15137
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B22 RID: 15138
		private int _hasBits0;

		// Token: 0x04003B23 RID: 15139
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003B24 RID: 15140
		private Identity identity_;

		// Token: 0x04003B25 RID: 15141
		public const int SessionIdFieldNumber = 2;

		// Token: 0x04003B26 RID: 15142
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003B27 RID: 15143
		private string sessionId_;

		// Token: 0x04003B28 RID: 15144
		public const int ReasonFieldNumber = 3;

		// Token: 0x04003B29 RID: 15145
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04003B2A RID: 15146
		private uint reason_;
	}
}
