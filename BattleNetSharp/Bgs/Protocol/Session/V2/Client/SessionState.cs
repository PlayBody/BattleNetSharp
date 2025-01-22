using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200056E RID: 1390
	public sealed class SessionState : IMessage<SessionState>, IMessage, IEquatable<SessionState>, IDeepCloneable<SessionState>, IBufferMessage
	{
		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x060085C1 RID: 34241 RVA: 0x00207E60 File Offset: 0x00206060
		[DebuggerNonUserCode]
		public static MessageParser<SessionState> Parser
		{
			get
			{
				return SessionState._parser;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x060085C2 RID: 34242 RVA: 0x00207E78 File Offset: 0x00206078
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x00207E9C File Offset: 0x0020609C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionState.Descriptor;
			}
		}

		// Token: 0x060085C4 RID: 34244 RVA: 0x00207EB3 File Offset: 0x002060B3
		[DebuggerNonUserCode]
		public SessionState()
		{
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x00207EC0 File Offset: 0x002060C0
		[DebuggerNonUserCode]
		public SessionState(SessionState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionId_ = ((other.sessionId_ != null) ? other.sessionId_.Clone() : null);
			this.createTimeMs_ = other.createTimeMs_;
			this.billing_ = ((other.billing_ != null) ? other.billing_.Clone() : null);
			this.constraint_ = ((other.constraint_ != null) ? other.constraint_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x00207F54 File Offset: 0x00206154
		[DebuggerNonUserCode]
		public SessionState Clone()
		{
			return new SessionState(this);
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x060085C7 RID: 34247 RVA: 0x00207F6C File Offset: 0x0020616C
		// (set) Token: 0x060085C8 RID: 34248 RVA: 0x00207F84 File Offset: 0x00206184
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

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x060085C9 RID: 34249 RVA: 0x00207F90 File Offset: 0x00206190
		// (set) Token: 0x060085CA RID: 34250 RVA: 0x00207FC1 File Offset: 0x002061C1
		[DebuggerNonUserCode]
		public ulong CreateTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong createTimeMsDefaultValue;
				if (flag)
				{
					createTimeMsDefaultValue = this.createTimeMs_;
				}
				else
				{
					createTimeMsDefaultValue = SessionState.CreateTimeMsDefaultValue;
				}
				return createTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.createTimeMs_ = value;
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x060085CB RID: 34251 RVA: 0x00207FDC File Offset: 0x002061DC
		[DebuggerNonUserCode]
		public bool HasCreateTimeMs
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060085CC RID: 34252 RVA: 0x00207FF9 File Offset: 0x002061F9
		[DebuggerNonUserCode]
		public void ClearCreateTimeMs()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x060085CD RID: 34253 RVA: 0x0020800C File Offset: 0x0020620C
		// (set) Token: 0x060085CE RID: 34254 RVA: 0x00208024 File Offset: 0x00206224
		[DebuggerNonUserCode]
		public BillingState Billing
		{
			get
			{
				return this.billing_;
			}
			set
			{
				this.billing_ = value;
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x060085CF RID: 34255 RVA: 0x00208030 File Offset: 0x00206230
		// (set) Token: 0x060085D0 RID: 34256 RVA: 0x00208048 File Offset: 0x00206248
		[DebuggerNonUserCode]
		public SessionConstraint Constraint
		{
			get
			{
				return this.constraint_;
			}
			set
			{
				this.constraint_ = value;
			}
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x00208054 File Offset: 0x00206254
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionState);
		}

		// Token: 0x060085D2 RID: 34258 RVA: 0x00208074 File Offset: 0x00206274
		[DebuggerNonUserCode]
		public bool Equals(SessionState other)
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
					bool flag4 = !object.Equals(this.SessionId, other.SessionId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CreateTimeMs != other.CreateTimeMs;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Billing, other.Billing);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Constraint, other.Constraint);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060085D3 RID: 34259 RVA: 0x0020812C File Offset: 0x0020632C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sessionId_ != null;
			if (flag)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasCreateTimeMs = this.HasCreateTimeMs;
			if (hasCreateTimeMs)
			{
				num ^= this.CreateTimeMs.GetHashCode();
			}
			bool flag2 = this.billing_ != null;
			if (flag2)
			{
				num ^= this.Billing.GetHashCode();
			}
			bool flag3 = this.constraint_ != null;
			if (flag3)
			{
				num ^= this.Constraint.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085D4 RID: 34260 RVA: 0x002081D4 File Offset: 0x002063D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x002081EC File Offset: 0x002063EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085D6 RID: 34262 RVA: 0x002081F8 File Offset: 0x002063F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SessionId);
			}
			bool hasCreateTimeMs = this.HasCreateTimeMs;
			if (hasCreateTimeMs)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.CreateTimeMs);
			}
			bool flag2 = this.billing_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Billing);
			}
			bool flag3 = this.constraint_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Constraint);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x002082B8 File Offset: 0x002064B8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sessionId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionId);
			}
			bool hasCreateTimeMs = this.HasCreateTimeMs;
			if (hasCreateTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreateTimeMs);
			}
			bool flag2 = this.billing_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Billing);
			}
			bool flag3 = this.constraint_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Constraint);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x0020836C File Offset: 0x0020656C
		[DebuggerNonUserCode]
		public void MergeFrom(SessionState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sessionId_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionId_ == null;
					if (flag3)
					{
						this.SessionId = new SessionId();
					}
					this.SessionId.MergeFrom(other.SessionId);
				}
				bool hasCreateTimeMs = other.HasCreateTimeMs;
				if (hasCreateTimeMs)
				{
					this.CreateTimeMs = other.CreateTimeMs;
				}
				bool flag4 = other.billing_ != null;
				if (flag4)
				{
					bool flag5 = this.billing_ == null;
					if (flag5)
					{
						this.Billing = new BillingState();
					}
					this.Billing.MergeFrom(other.Billing);
				}
				bool flag6 = other.constraint_ != null;
				if (flag6)
				{
					bool flag7 = this.constraint_ == null;
					if (flag7)
					{
						this.Constraint = new SessionConstraint();
					}
					this.Constraint.MergeFrom(other.Constraint);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x00208474 File Offset: 0x00206674
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x00208480 File Offset: 0x00206680
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
							goto IL_002F;
						}
						this.CreateTimeMs = input.ReadUInt64();
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
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag2 = this.constraint_ == null;
					if (flag2)
					{
						this.Constraint = new SessionConstraint();
					}
					input.ReadMessage(this.Constraint);
				}
				else
				{
					bool flag3 = this.billing_ == null;
					if (flag3)
					{
						this.Billing = new BillingState();
					}
					input.ReadMessage(this.Billing);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003CAC RID: 15532
		private static readonly MessageParser<SessionState> _parser = new MessageParser<SessionState>(() => new SessionState());

		// Token: 0x04003CAD RID: 15533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CAE RID: 15534
		private int _hasBits0;

		// Token: 0x04003CAF RID: 15535
		public const int SessionIdFieldNumber = 1;

		// Token: 0x04003CB0 RID: 15536
		private SessionId sessionId_;

		// Token: 0x04003CB1 RID: 15537
		public const int CreateTimeMsFieldNumber = 2;

		// Token: 0x04003CB2 RID: 15538
		private static readonly ulong CreateTimeMsDefaultValue = 0UL;

		// Token: 0x04003CB3 RID: 15539
		private ulong createTimeMs_;

		// Token: 0x04003CB4 RID: 15540
		public const int BillingFieldNumber = 3;

		// Token: 0x04003CB5 RID: 15541
		private BillingState billing_;

		// Token: 0x04003CB6 RID: 15542
		public const int ConstraintFieldNumber = 4;

		// Token: 0x04003CB7 RID: 15543
		private SessionConstraint constraint_;
	}
}
