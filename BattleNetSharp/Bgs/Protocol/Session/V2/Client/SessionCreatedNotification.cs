using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000553 RID: 1363
	public sealed class SessionCreatedNotification : IMessage<SessionCreatedNotification>, IMessage, IEquatable<SessionCreatedNotification>, IDeepCloneable<SessionCreatedNotification>, IBufferMessage
	{
		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x060083B8 RID: 33720 RVA: 0x002009F8 File Offset: 0x001FEBF8
		[DebuggerNonUserCode]
		public static MessageParser<SessionCreatedNotification> Parser
		{
			get
			{
				return SessionCreatedNotification._parser;
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x060083B9 RID: 33721 RVA: 0x00200A10 File Offset: 0x001FEC10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x060083BA RID: 33722 RVA: 0x00200A34 File Offset: 0x001FEC34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionCreatedNotification.Descriptor;
			}
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x00200A4B File Offset: 0x001FEC4B
		[DebuggerNonUserCode]
		public SessionCreatedNotification()
		{
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x00200A58 File Offset: 0x001FEC58
		[DebuggerNonUserCode]
		public SessionCreatedNotification(SessionCreatedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.status_ = other.status_;
			this.sessionKey_ = ((other.sessionKey_ != null) ? other.sessionKey_.Clone() : null);
			this.sessionId_ = ((other.sessionId_ != null) ? other.sessionId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x00200AD0 File Offset: 0x001FECD0
		[DebuggerNonUserCode]
		public SessionCreatedNotification Clone()
		{
			return new SessionCreatedNotification(this);
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x00200AE8 File Offset: 0x001FECE8
		// (set) Token: 0x060083BF RID: 33727 RVA: 0x00200B19 File Offset: 0x001FED19
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
					statusDefaultValue = SessionCreatedNotification.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.status_ = value;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x060083C0 RID: 33728 RVA: 0x00200B34 File Offset: 0x001FED34
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x00200B51 File Offset: 0x001FED51
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x060083C2 RID: 33730 RVA: 0x00200B64 File Offset: 0x001FED64
		// (set) Token: 0x060083C3 RID: 33731 RVA: 0x00200B7C File Offset: 0x001FED7C
		[DebuggerNonUserCode]
		public SessionKey SessionKey
		{
			get
			{
				return this.sessionKey_;
			}
			set
			{
				this.sessionKey_ = value;
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x060083C4 RID: 33732 RVA: 0x00200B88 File Offset: 0x001FED88
		// (set) Token: 0x060083C5 RID: 33733 RVA: 0x00200BA0 File Offset: 0x001FEDA0
		[DebuggerNonUserCode]
		public SessionId SessionId
		{
			get
			{
				return this.sessionId_;
			}
			set
			{
				this.sessionId_ = value;
			}
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x00200BAC File Offset: 0x001FEDAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionCreatedNotification);
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x00200BCC File Offset: 0x001FEDCC
		[DebuggerNonUserCode]
		public bool Equals(SessionCreatedNotification other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SessionKey, other.SessionKey);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SessionId, other.SessionId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x00200C60 File Offset: 0x001FEE60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			bool flag = this.sessionKey_ != null;
			if (flag)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag2 = this.sessionId_ != null;
			if (flag2)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x00200CEC File Offset: 0x001FEEEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x00200D04 File Offset: 0x001FEF04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x00200D10 File Offset: 0x001FEF10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Status);
			}
			bool flag = this.sessionKey_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SessionKey);
			}
			bool flag2 = this.sessionId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SessionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x00200DA8 File Offset: 0x001FEFA8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			bool flag = this.sessionKey_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionKey);
			}
			bool flag2 = this.sessionId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x00200E38 File Offset: 0x001FF038
		[DebuggerNonUserCode]
		public void MergeFrom(SessionCreatedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				bool flag2 = other.sessionKey_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionKey_ == null;
					if (flag3)
					{
						this.SessionKey = new SessionKey();
					}
					this.SessionKey.MergeFrom(other.SessionKey);
				}
				bool flag4 = other.sessionId_ != null;
				if (flag4)
				{
					bool flag5 = this.sessionId_ == null;
					if (flag5)
					{
						this.SessionId = new SessionId();
					}
					this.SessionId.MergeFrom(other.SessionId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x00200F00 File Offset: 0x001FF100
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x00200F0C File Offset: 0x001FF10C
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
							bool flag = this.sessionId_ == null;
							if (flag)
							{
								this.SessionId = new SessionId();
							}
							input.ReadMessage(this.SessionId);
						}
					}
					else
					{
						bool flag2 = this.sessionKey_ == null;
						if (flag2)
						{
							this.SessionKey = new SessionKey();
						}
						input.ReadMessage(this.SessionKey);
					}
				}
				else
				{
					this.Status = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BCF RID: 15311
		private static readonly MessageParser<SessionCreatedNotification> _parser = new MessageParser<SessionCreatedNotification>(() => new SessionCreatedNotification());

		// Token: 0x04003BD0 RID: 15312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BD1 RID: 15313
		private int _hasBits0;

		// Token: 0x04003BD2 RID: 15314
		public const int StatusFieldNumber = 1;

		// Token: 0x04003BD3 RID: 15315
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04003BD4 RID: 15316
		private uint status_;

		// Token: 0x04003BD5 RID: 15317
		public const int SessionKeyFieldNumber = 2;

		// Token: 0x04003BD6 RID: 15318
		private SessionKey sessionKey_;

		// Token: 0x04003BD7 RID: 15319
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04003BD8 RID: 15320
		private SessionId sessionId_;
	}
}
