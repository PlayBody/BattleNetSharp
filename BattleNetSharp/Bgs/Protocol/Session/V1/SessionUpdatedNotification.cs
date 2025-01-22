using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000543 RID: 1347
	public sealed class SessionUpdatedNotification : IMessage<SessionUpdatedNotification>, IMessage, IEquatable<SessionUpdatedNotification>, IDeepCloneable<SessionUpdatedNotification>, IBufferMessage
	{
		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x001FA8C8 File Offset: 0x001F8AC8
		[DebuggerNonUserCode]
		public static MessageParser<SessionUpdatedNotification> Parser
		{
			get
			{
				return SessionUpdatedNotification._parser;
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x06008253 RID: 33363 RVA: 0x001FA8E0 File Offset: 0x001F8AE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x06008254 RID: 33364 RVA: 0x001FA904 File Offset: 0x001F8B04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionUpdatedNotification.Descriptor;
			}
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x001FA91B File Offset: 0x001F8B1B
		[DebuggerNonUserCode]
		public SessionUpdatedNotification()
		{
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x001FA928 File Offset: 0x001F8B28
		[DebuggerNonUserCode]
		public SessionUpdatedNotification(SessionUpdatedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.reason_ = other.reason_;
			this.sessionId_ = other.sessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x001FA990 File Offset: 0x001F8B90
		[DebuggerNonUserCode]
		public SessionUpdatedNotification Clone()
		{
			return new SessionUpdatedNotification(this);
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x06008258 RID: 33368 RVA: 0x001FA9A8 File Offset: 0x001F8BA8
		// (set) Token: 0x06008259 RID: 33369 RVA: 0x001FA9C0 File Offset: 0x001F8BC0
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

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x0600825A RID: 33370 RVA: 0x001FA9CC File Offset: 0x001F8BCC
		// (set) Token: 0x0600825B RID: 33371 RVA: 0x001FA9FD File Offset: 0x001F8BFD
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
					reasonDefaultValue = SessionUpdatedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600825C RID: 33372 RVA: 0x001FAA18 File Offset: 0x001F8C18
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x001FAA35 File Offset: 0x001F8C35
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x001FAA48 File Offset: 0x001F8C48
		// (set) Token: 0x0600825F RID: 33375 RVA: 0x001FAA69 File Offset: 0x001F8C69
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? SessionUpdatedNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06008260 RID: 33376 RVA: 0x001FAA80 File Offset: 0x001F8C80
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x001FAA9B File Offset: 0x001F8C9B
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x001FAAA8 File Offset: 0x001F8CA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionUpdatedNotification);
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x001FAAC8 File Offset: 0x001F8CC8
		[DebuggerNonUserCode]
		public bool Equals(SessionUpdatedNotification other)
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
						bool flag5 = this.Reason != other.Reason;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SessionId != other.SessionId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x001FAB58 File Offset: 0x001F8D58
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x001FABE0 File Offset: 0x001F8DE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x001FABF8 File Offset: 0x001F8DF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x001FAC04 File Offset: 0x001F8E04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Reason);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SessionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x001FAC98 File Offset: 0x001F8E98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x001FAD28 File Offset: 0x001F8F28
		[DebuggerNonUserCode]
		public void MergeFrom(SessionUpdatedNotification other)
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
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x001FADCB File Offset: 0x001F8FCB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x001FADD8 File Offset: 0x001F8FD8
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SessionId = input.ReadString();
						}
					}
					else
					{
						this.Reason = input.ReadUInt32();
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

		// Token: 0x04003AF6 RID: 15094
		private static readonly MessageParser<SessionUpdatedNotification> _parser = new MessageParser<SessionUpdatedNotification>(() => new SessionUpdatedNotification());

		// Token: 0x04003AF7 RID: 15095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AF8 RID: 15096
		private int _hasBits0;

		// Token: 0x04003AF9 RID: 15097
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003AFA RID: 15098
		private Identity identity_;

		// Token: 0x04003AFB RID: 15099
		public const int ReasonFieldNumber = 2;

		// Token: 0x04003AFC RID: 15100
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04003AFD RID: 15101
		private uint reason_;

		// Token: 0x04003AFE RID: 15102
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04003AFF RID: 15103
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003B00 RID: 15104
		private string sessionId_;
	}
}
