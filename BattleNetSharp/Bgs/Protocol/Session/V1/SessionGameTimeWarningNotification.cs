using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000544 RID: 1348
	public sealed class SessionGameTimeWarningNotification : IMessage<SessionGameTimeWarningNotification>, IMessage, IEquatable<SessionGameTimeWarningNotification>, IDeepCloneable<SessionGameTimeWarningNotification>, IBufferMessage
	{
		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x0600826D RID: 33389 RVA: 0x001FAEA4 File Offset: 0x001F90A4
		[DebuggerNonUserCode]
		public static MessageParser<SessionGameTimeWarningNotification> Parser
		{
			get
			{
				return SessionGameTimeWarningNotification._parser;
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600826E RID: 33390 RVA: 0x001FAEBC File Offset: 0x001F90BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600826F RID: 33391 RVA: 0x001FAEE0 File Offset: 0x001F90E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionGameTimeWarningNotification.Descriptor;
			}
		}

		// Token: 0x06008270 RID: 33392 RVA: 0x001FAEF7 File Offset: 0x001F90F7
		[DebuggerNonUserCode]
		public SessionGameTimeWarningNotification()
		{
		}

		// Token: 0x06008271 RID: 33393 RVA: 0x001FAF04 File Offset: 0x001F9104
		[DebuggerNonUserCode]
		public SessionGameTimeWarningNotification(SessionGameTimeWarningNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this.remainingTimeDurationMin_ = other.remainingTimeDurationMin_;
			this.restrictionType_ = other.restrictionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008272 RID: 33394 RVA: 0x001FAF78 File Offset: 0x001F9178
		[DebuggerNonUserCode]
		public SessionGameTimeWarningNotification Clone()
		{
			return new SessionGameTimeWarningNotification(this);
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x06008273 RID: 33395 RVA: 0x001FAF90 File Offset: 0x001F9190
		// (set) Token: 0x06008274 RID: 33396 RVA: 0x001FAFA8 File Offset: 0x001F91A8
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

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x06008275 RID: 33397 RVA: 0x001FAFB4 File Offset: 0x001F91B4
		// (set) Token: 0x06008276 RID: 33398 RVA: 0x001FAFD5 File Offset: 0x001F91D5
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? SessionGameTimeWarningNotification.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x06008277 RID: 33399 RVA: 0x001FAFEC File Offset: 0x001F91EC
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x001FB007 File Offset: 0x001F9207
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06008279 RID: 33401 RVA: 0x001FB014 File Offset: 0x001F9214
		// (set) Token: 0x0600827A RID: 33402 RVA: 0x001FB045 File Offset: 0x001F9245
		[DebuggerNonUserCode]
		public uint RemainingTimeDurationMin
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint remainingTimeDurationMinDefaultValue;
				if (flag)
				{
					remainingTimeDurationMinDefaultValue = this.remainingTimeDurationMin_;
				}
				else
				{
					remainingTimeDurationMinDefaultValue = SessionGameTimeWarningNotification.RemainingTimeDurationMinDefaultValue;
				}
				return remainingTimeDurationMinDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.remainingTimeDurationMin_ = value;
			}
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x0600827B RID: 33403 RVA: 0x001FB060 File Offset: 0x001F9260
		[DebuggerNonUserCode]
		public bool HasRemainingTimeDurationMin
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x001FB07D File Offset: 0x001F927D
		[DebuggerNonUserCode]
		public void ClearRemainingTimeDurationMin()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x0600827D RID: 33405 RVA: 0x001FB090 File Offset: 0x001F9290
		// (set) Token: 0x0600827E RID: 33406 RVA: 0x001FB0C1 File Offset: 0x001F92C1
		[DebuggerNonUserCode]
		public uint RestrictionType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint restrictionTypeDefaultValue;
				if (flag)
				{
					restrictionTypeDefaultValue = this.restrictionType_;
				}
				else
				{
					restrictionTypeDefaultValue = SessionGameTimeWarningNotification.RestrictionTypeDefaultValue;
				}
				return restrictionTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.restrictionType_ = value;
			}
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600827F RID: 33407 RVA: 0x001FB0DC File Offset: 0x001F92DC
		[DebuggerNonUserCode]
		public bool HasRestrictionType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x001FB0F9 File Offset: 0x001F92F9
		[DebuggerNonUserCode]
		public void ClearRestrictionType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x001FB10C File Offset: 0x001F930C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionGameTimeWarningNotification);
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x001FB12C File Offset: 0x001F932C
		[DebuggerNonUserCode]
		public bool Equals(SessionGameTimeWarningNotification other)
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
							bool flag6 = this.RemainingTimeDurationMin != other.RemainingTimeDurationMin;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RestrictionType != other.RestrictionType;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x001FB1DC File Offset: 0x001F93DC
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
			bool hasRemainingTimeDurationMin = this.HasRemainingTimeDurationMin;
			if (hasRemainingTimeDurationMin)
			{
				num ^= this.RemainingTimeDurationMin.GetHashCode();
			}
			bool hasRestrictionType = this.HasRestrictionType;
			if (hasRestrictionType)
			{
				num ^= this.RestrictionType.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008284 RID: 33412 RVA: 0x001FB280 File Offset: 0x001F9480
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x001FB298 File Offset: 0x001F9498
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x001FB2A4 File Offset: 0x001F94A4
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
			bool hasRemainingTimeDurationMin = this.HasRemainingTimeDurationMin;
			if (hasRemainingTimeDurationMin)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.RemainingTimeDurationMin);
			}
			bool hasRestrictionType = this.HasRestrictionType;
			if (hasRestrictionType)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.RestrictionType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x001FB35C File Offset: 0x001F955C
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
			bool hasRemainingTimeDurationMin = this.HasRemainingTimeDurationMin;
			if (hasRemainingTimeDurationMin)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RemainingTimeDurationMin);
			}
			bool hasRestrictionType = this.HasRestrictionType;
			if (hasRestrictionType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RestrictionType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x001FB408 File Offset: 0x001F9608
		[DebuggerNonUserCode]
		public void MergeFrom(SessionGameTimeWarningNotification other)
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
				bool hasRemainingTimeDurationMin = other.HasRemainingTimeDurationMin;
				if (hasRemainingTimeDurationMin)
				{
					this.RemainingTimeDurationMin = other.RemainingTimeDurationMin;
				}
				bool hasRestrictionType = other.HasRestrictionType;
				if (hasRestrictionType)
				{
					this.RestrictionType = other.RestrictionType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x001FB4C6 File Offset: 0x001F96C6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x001FB4D4 File Offset: 0x001F96D4
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
							goto IL_002C;
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
						goto IL_002C;
					}
					this.RestrictionType = input.ReadUInt32();
				}
				else
				{
					this.RemainingTimeDurationMin = input.ReadUInt32();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B01 RID: 15105
		private static readonly MessageParser<SessionGameTimeWarningNotification> _parser = new MessageParser<SessionGameTimeWarningNotification>(() => new SessionGameTimeWarningNotification());

		// Token: 0x04003B02 RID: 15106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B03 RID: 15107
		private int _hasBits0;

		// Token: 0x04003B04 RID: 15108
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003B05 RID: 15109
		private Identity identity_;

		// Token: 0x04003B06 RID: 15110
		public const int SessionIdFieldNumber = 2;

		// Token: 0x04003B07 RID: 15111
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003B08 RID: 15112
		private string sessionId_;

		// Token: 0x04003B09 RID: 15113
		public const int RemainingTimeDurationMinFieldNumber = 3;

		// Token: 0x04003B0A RID: 15114
		private static readonly uint RemainingTimeDurationMinDefaultValue = 0U;

		// Token: 0x04003B0B RID: 15115
		private uint remainingTimeDurationMin_;

		// Token: 0x04003B0C RID: 15116
		public const int RestrictionTypeFieldNumber = 4;

		// Token: 0x04003B0D RID: 15117
		private static readonly uint RestrictionTypeDefaultValue = 0U;

		// Token: 0x04003B0E RID: 15118
		private uint restrictionType_;
	}
}
