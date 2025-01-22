using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000542 RID: 1346
	public sealed class SessionDestroyedNotification : IMessage<SessionDestroyedNotification>, IMessage, IEquatable<SessionDestroyedNotification>, IDeepCloneable<SessionDestroyedNotification>, IBufferMessage
	{
		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x06008233 RID: 33331 RVA: 0x001FA1A8 File Offset: 0x001F83A8
		[DebuggerNonUserCode]
		public static MessageParser<SessionDestroyedNotification> Parser
		{
			get
			{
				return SessionDestroyedNotification._parser;
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x06008234 RID: 33332 RVA: 0x001FA1C0 File Offset: 0x001F83C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x06008235 RID: 33333 RVA: 0x001FA1E4 File Offset: 0x001F83E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionDestroyedNotification.Descriptor;
			}
		}

		// Token: 0x06008236 RID: 33334 RVA: 0x001FA1FB File Offset: 0x001F83FB
		[DebuggerNonUserCode]
		public SessionDestroyedNotification()
		{
		}

		// Token: 0x06008237 RID: 33335 RVA: 0x001FA208 File Offset: 0x001F8408
		[DebuggerNonUserCode]
		public SessionDestroyedNotification(SessionDestroyedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.reason_ = other.reason_;
			this.sessionId_ = other.sessionId_;
			this.reasonDetails_ = other.reasonDetails_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008238 RID: 33336 RVA: 0x001FA27C File Offset: 0x001F847C
		[DebuggerNonUserCode]
		public SessionDestroyedNotification Clone()
		{
			return new SessionDestroyedNotification(this);
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x06008239 RID: 33337 RVA: 0x001FA294 File Offset: 0x001F8494
		// (set) Token: 0x0600823A RID: 33338 RVA: 0x001FA2AC File Offset: 0x001F84AC
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

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600823B RID: 33339 RVA: 0x001FA2B8 File Offset: 0x001F84B8
		// (set) Token: 0x0600823C RID: 33340 RVA: 0x001FA2E9 File Offset: 0x001F84E9
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
					reasonDefaultValue = SessionDestroyedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600823D RID: 33341 RVA: 0x001FA304 File Offset: 0x001F8504
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x001FA321 File Offset: 0x001F8521
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600823F RID: 33343 RVA: 0x001FA334 File Offset: 0x001F8534
		// (set) Token: 0x06008240 RID: 33344 RVA: 0x001FA355 File Offset: 0x001F8555
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? SessionDestroyedNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x06008241 RID: 33345 RVA: 0x001FA36C File Offset: 0x001F856C
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x001FA387 File Offset: 0x001F8587
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x06008243 RID: 33347 RVA: 0x001FA394 File Offset: 0x001F8594
		// (set) Token: 0x06008244 RID: 33348 RVA: 0x001FA3C5 File Offset: 0x001F85C5
		[DebuggerNonUserCode]
		public uint ReasonDetails
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint reasonDetailsDefaultValue;
				if (flag)
				{
					reasonDetailsDefaultValue = this.reasonDetails_;
				}
				else
				{
					reasonDetailsDefaultValue = SessionDestroyedNotification.ReasonDetailsDefaultValue;
				}
				return reasonDetailsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reasonDetails_ = value;
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x06008245 RID: 33349 RVA: 0x001FA3E0 File Offset: 0x001F85E0
		[DebuggerNonUserCode]
		public bool HasReasonDetails
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x001FA3FD File Offset: 0x001F85FD
		[DebuggerNonUserCode]
		public void ClearReasonDetails()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x001FA410 File Offset: 0x001F8610
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionDestroyedNotification);
		}

		// Token: 0x06008248 RID: 33352 RVA: 0x001FA430 File Offset: 0x001F8630
		[DebuggerNonUserCode]
		public bool Equals(SessionDestroyedNotification other)
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
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ReasonDetails != other.ReasonDetails;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x001FA4E0 File Offset: 0x001F86E0
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
			bool hasReasonDetails = this.HasReasonDetails;
			if (hasReasonDetails)
			{
				num ^= this.ReasonDetails.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600824A RID: 33354 RVA: 0x001FA584 File Offset: 0x001F8784
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x001FA59C File Offset: 0x001F879C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600824C RID: 33356 RVA: 0x001FA5A8 File Offset: 0x001F87A8
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
			bool hasReasonDetails = this.HasReasonDetails;
			if (hasReasonDetails)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ReasonDetails);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600824D RID: 33357 RVA: 0x001FA660 File Offset: 0x001F8860
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
			bool hasReasonDetails = this.HasReasonDetails;
			if (hasReasonDetails)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ReasonDetails);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x001FA70C File Offset: 0x001F890C
		[DebuggerNonUserCode]
		public void MergeFrom(SessionDestroyedNotification other)
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
				bool hasReasonDetails = other.HasReasonDetails;
				if (hasReasonDetails)
				{
					this.ReasonDetails = other.ReasonDetails;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x001FA7CA File Offset: 0x001F89CA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x001FA7D8 File Offset: 0x001F89D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.Reason = input.ReadUInt32();
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
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.ReasonDetails = input.ReadUInt32();
				}
				else
				{
					this.SessionId = input.ReadString();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AE8 RID: 15080
		private static readonly MessageParser<SessionDestroyedNotification> _parser = new MessageParser<SessionDestroyedNotification>(() => new SessionDestroyedNotification());

		// Token: 0x04003AE9 RID: 15081
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AEA RID: 15082
		private int _hasBits0;

		// Token: 0x04003AEB RID: 15083
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003AEC RID: 15084
		private Identity identity_;

		// Token: 0x04003AED RID: 15085
		public const int ReasonFieldNumber = 2;

		// Token: 0x04003AEE RID: 15086
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04003AEF RID: 15087
		private uint reason_;

		// Token: 0x04003AF0 RID: 15088
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04003AF1 RID: 15089
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003AF2 RID: 15090
		private string sessionId_;

		// Token: 0x04003AF3 RID: 15091
		public const int ReasonDetailsFieldNumber = 4;

		// Token: 0x04003AF4 RID: 15092
		private static readonly uint ReasonDetailsDefaultValue = 0U;

		// Token: 0x04003AF5 RID: 15093
		private uint reasonDetails_;
	}
}
