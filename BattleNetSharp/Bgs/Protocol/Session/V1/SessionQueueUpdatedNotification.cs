using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000545 RID: 1349
	public sealed class SessionQueueUpdatedNotification : IMessage<SessionQueueUpdatedNotification>, IMessage, IEquatable<SessionQueueUpdatedNotification>, IDeepCloneable<SessionQueueUpdatedNotification>, IBufferMessage
	{
		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600828C RID: 33420 RVA: 0x001FB5C4 File Offset: 0x001F97C4
		[DebuggerNonUserCode]
		public static MessageParser<SessionQueueUpdatedNotification> Parser
		{
			get
			{
				return SessionQueueUpdatedNotification._parser;
			}
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600828D RID: 33421 RVA: 0x001FB5DC File Offset: 0x001F97DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600828E RID: 33422 RVA: 0x001FB600 File Offset: 0x001F9800
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionQueueUpdatedNotification.Descriptor;
			}
		}

		// Token: 0x0600828F RID: 33423 RVA: 0x001FB617 File Offset: 0x001F9817
		[DebuggerNonUserCode]
		public SessionQueueUpdatedNotification()
		{
		}

		// Token: 0x06008290 RID: 33424 RVA: 0x001FB624 File Offset: 0x001F9824
		[DebuggerNonUserCode]
		public SessionQueueUpdatedNotification(SessionQueueUpdatedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this.position_ = other.position_;
			this.avgCreationTimeMs_ = other.avgCreationTimeMs_;
			this.queuedTimeMs_ = other.queuedTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x001FB6A4 File Offset: 0x001F98A4
		[DebuggerNonUserCode]
		public SessionQueueUpdatedNotification Clone()
		{
			return new SessionQueueUpdatedNotification(this);
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x001FB6BC File Offset: 0x001F98BC
		// (set) Token: 0x06008293 RID: 33427 RVA: 0x001FB6D4 File Offset: 0x001F98D4
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

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x06008294 RID: 33428 RVA: 0x001FB6E0 File Offset: 0x001F98E0
		// (set) Token: 0x06008295 RID: 33429 RVA: 0x001FB701 File Offset: 0x001F9901
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? SessionQueueUpdatedNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x06008296 RID: 33430 RVA: 0x001FB718 File Offset: 0x001F9918
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x001FB733 File Offset: 0x001F9933
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x001FB740 File Offset: 0x001F9940
		// (set) Token: 0x06008299 RID: 33433 RVA: 0x001FB771 File Offset: 0x001F9971
		[DebuggerNonUserCode]
		public uint Position
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint positionDefaultValue;
				if (flag)
				{
					positionDefaultValue = this.position_;
				}
				else
				{
					positionDefaultValue = SessionQueueUpdatedNotification.PositionDefaultValue;
				}
				return positionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.position_ = value;
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600829A RID: 33434 RVA: 0x001FB78C File Offset: 0x001F998C
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x001FB7A9 File Offset: 0x001F99A9
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600829C RID: 33436 RVA: 0x001FB7BC File Offset: 0x001F99BC
		// (set) Token: 0x0600829D RID: 33437 RVA: 0x001FB7ED File Offset: 0x001F99ED
		[DebuggerNonUserCode]
		public ulong AvgCreationTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong avgCreationTimeMsDefaultValue;
				if (flag)
				{
					avgCreationTimeMsDefaultValue = this.avgCreationTimeMs_;
				}
				else
				{
					avgCreationTimeMsDefaultValue = SessionQueueUpdatedNotification.AvgCreationTimeMsDefaultValue;
				}
				return avgCreationTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.avgCreationTimeMs_ = value;
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x0600829E RID: 33438 RVA: 0x001FB808 File Offset: 0x001F9A08
		[DebuggerNonUserCode]
		public bool HasAvgCreationTimeMs
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x001FB825 File Offset: 0x001F9A25
		[DebuggerNonUserCode]
		public void ClearAvgCreationTimeMs()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x060082A0 RID: 33440 RVA: 0x001FB838 File Offset: 0x001F9A38
		// (set) Token: 0x060082A1 RID: 33441 RVA: 0x001FB869 File Offset: 0x001F9A69
		[DebuggerNonUserCode]
		public ulong QueuedTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong queuedTimeMsDefaultValue;
				if (flag)
				{
					queuedTimeMsDefaultValue = this.queuedTimeMs_;
				}
				else
				{
					queuedTimeMsDefaultValue = SessionQueueUpdatedNotification.QueuedTimeMsDefaultValue;
				}
				return queuedTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.queuedTimeMs_ = value;
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x060082A2 RID: 33442 RVA: 0x001FB884 File Offset: 0x001F9A84
		[DebuggerNonUserCode]
		public bool HasQueuedTimeMs
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x001FB8A1 File Offset: 0x001F9AA1
		[DebuggerNonUserCode]
		public void ClearQueuedTimeMs()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x001FB8B4 File Offset: 0x001F9AB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionQueueUpdatedNotification);
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x001FB8D4 File Offset: 0x001F9AD4
		[DebuggerNonUserCode]
		public bool Equals(SessionQueueUpdatedNotification other)
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
							bool flag6 = this.Position != other.Position;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.AvgCreationTimeMs != other.AvgCreationTimeMs;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.QueuedTimeMs != other.QueuedTimeMs;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x001FB9A4 File Offset: 0x001F9BA4
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
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num ^= this.Position.GetHashCode();
			}
			bool hasAvgCreationTimeMs = this.HasAvgCreationTimeMs;
			if (hasAvgCreationTimeMs)
			{
				num ^= this.AvgCreationTimeMs.GetHashCode();
			}
			bool hasQueuedTimeMs = this.HasQueuedTimeMs;
			if (hasQueuedTimeMs)
			{
				num ^= this.QueuedTimeMs.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x001FBA68 File Offset: 0x001F9C68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x001FBA80 File Offset: 0x001F9C80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x001FBA8C File Offset: 0x001F9C8C
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
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Position);
			}
			bool hasAvgCreationTimeMs = this.HasAvgCreationTimeMs;
			if (hasAvgCreationTimeMs)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.AvgCreationTimeMs);
			}
			bool hasQueuedTimeMs = this.HasQueuedTimeMs;
			if (hasQueuedTimeMs)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.QueuedTimeMs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x001FBB68 File Offset: 0x001F9D68
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
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Position);
			}
			bool hasAvgCreationTimeMs = this.HasAvgCreationTimeMs;
			if (hasAvgCreationTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AvgCreationTimeMs);
			}
			bool hasQueuedTimeMs = this.HasQueuedTimeMs;
			if (hasQueuedTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.QueuedTimeMs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x001FBC34 File Offset: 0x001F9E34
		[DebuggerNonUserCode]
		public void MergeFrom(SessionQueueUpdatedNotification other)
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
				bool hasPosition = other.HasPosition;
				if (hasPosition)
				{
					this.Position = other.Position;
				}
				bool hasAvgCreationTimeMs = other.HasAvgCreationTimeMs;
				if (hasAvgCreationTimeMs)
				{
					this.AvgCreationTimeMs = other.AvgCreationTimeMs;
				}
				bool hasQueuedTimeMs = other.HasQueuedTimeMs;
				if (hasQueuedTimeMs)
				{
					this.QueuedTimeMs = other.QueuedTimeMs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x001FBD0D File Offset: 0x001F9F0D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x001FBD18 File Offset: 0x001F9F18
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.SessionId = input.ReadString();
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
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.QueuedTimeMs = input.ReadUInt64();
					}
					else
					{
						this.AvgCreationTimeMs = input.ReadUInt64();
					}
				}
				else
				{
					this.Position = input.ReadUInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B0F RID: 15119
		private static readonly MessageParser<SessionQueueUpdatedNotification> _parser = new MessageParser<SessionQueueUpdatedNotification>(() => new SessionQueueUpdatedNotification());

		// Token: 0x04003B10 RID: 15120
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B11 RID: 15121
		private int _hasBits0;

		// Token: 0x04003B12 RID: 15122
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003B13 RID: 15123
		private Identity identity_;

		// Token: 0x04003B14 RID: 15124
		public const int SessionIdFieldNumber = 2;

		// Token: 0x04003B15 RID: 15125
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003B16 RID: 15126
		private string sessionId_;

		// Token: 0x04003B17 RID: 15127
		public const int PositionFieldNumber = 3;

		// Token: 0x04003B18 RID: 15128
		private static readonly uint PositionDefaultValue = 0U;

		// Token: 0x04003B19 RID: 15129
		private uint position_;

		// Token: 0x04003B1A RID: 15130
		public const int AvgCreationTimeMsFieldNumber = 4;

		// Token: 0x04003B1B RID: 15131
		private static readonly ulong AvgCreationTimeMsDefaultValue = 0UL;

		// Token: 0x04003B1C RID: 15132
		private ulong avgCreationTimeMs_;

		// Token: 0x04003B1D RID: 15133
		public const int QueuedTimeMsFieldNumber = 5;

		// Token: 0x04003B1E RID: 15134
		private static readonly ulong QueuedTimeMsDefaultValue = 0UL;

		// Token: 0x04003B1F RID: 15135
		private ulong queuedTimeMs_;
	}
}
