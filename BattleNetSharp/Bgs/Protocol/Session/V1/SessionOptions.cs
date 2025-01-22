using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200054C RID: 1356
	public sealed class SessionOptions : IMessage<SessionOptions>, IMessage, IEquatable<SessionOptions>, IDeepCloneable<SessionOptions>, IBufferMessage
	{
		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x060082D8 RID: 33496 RVA: 0x001FD118 File Offset: 0x001FB318
		[DebuggerNonUserCode]
		public static MessageParser<SessionOptions> Parser
		{
			get
			{
				return SessionOptions._parser;
			}
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x060082D9 RID: 33497 RVA: 0x001FD130 File Offset: 0x001FB330
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x060082DA RID: 33498 RVA: 0x001FD154 File Offset: 0x001FB354
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionOptions.Descriptor;
			}
		}

		// Token: 0x060082DB RID: 33499 RVA: 0x001FD16B File Offset: 0x001FB36B
		[DebuggerNonUserCode]
		public SessionOptions()
		{
		}

		// Token: 0x060082DC RID: 33500 RVA: 0x001FD175 File Offset: 0x001FB375
		[DebuggerNonUserCode]
		public SessionOptions(SessionOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.billing_ = other.billing_;
			this.presence_ = other.presence_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082DD RID: 33501 RVA: 0x001FD1B4 File Offset: 0x001FB3B4
		[DebuggerNonUserCode]
		public SessionOptions Clone()
		{
			return new SessionOptions(this);
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x060082DE RID: 33502 RVA: 0x001FD1CC File Offset: 0x001FB3CC
		// (set) Token: 0x060082DF RID: 33503 RVA: 0x001FD1FD File Offset: 0x001FB3FD
		[DebuggerNonUserCode]
		public bool Billing
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool billingDefaultValue;
				if (flag)
				{
					billingDefaultValue = this.billing_;
				}
				else
				{
					billingDefaultValue = SessionOptions.BillingDefaultValue;
				}
				return billingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.billing_ = value;
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x060082E0 RID: 33504 RVA: 0x001FD218 File Offset: 0x001FB418
		[DebuggerNonUserCode]
		public bool HasBilling
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060082E1 RID: 33505 RVA: 0x001FD235 File Offset: 0x001FB435
		[DebuggerNonUserCode]
		public void ClearBilling()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x001FD248 File Offset: 0x001FB448
		// (set) Token: 0x060082E3 RID: 33507 RVA: 0x001FD279 File Offset: 0x001FB479
		[DebuggerNonUserCode]
		public bool Presence
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool presenceDefaultValue;
				if (flag)
				{
					presenceDefaultValue = this.presence_;
				}
				else
				{
					presenceDefaultValue = SessionOptions.PresenceDefaultValue;
				}
				return presenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.presence_ = value;
			}
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x060082E4 RID: 33508 RVA: 0x001FD294 File Offset: 0x001FB494
		[DebuggerNonUserCode]
		public bool HasPresence
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060082E5 RID: 33509 RVA: 0x001FD2B1 File Offset: 0x001FB4B1
		[DebuggerNonUserCode]
		public void ClearPresence()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060082E6 RID: 33510 RVA: 0x001FD2C4 File Offset: 0x001FB4C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionOptions);
		}

		// Token: 0x060082E7 RID: 33511 RVA: 0x001FD2E4 File Offset: 0x001FB4E4
		[DebuggerNonUserCode]
		public bool Equals(SessionOptions other)
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
					bool flag4 = this.Billing != other.Billing;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Presence != other.Presence;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060082E8 RID: 33512 RVA: 0x001FD358 File Offset: 0x001FB558
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBilling = this.HasBilling;
			if (hasBilling)
			{
				num ^= this.Billing.GetHashCode();
			}
			bool hasPresence = this.HasPresence;
			if (hasPresence)
			{
				num ^= this.Presence.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082E9 RID: 33513 RVA: 0x001FD3C4 File Offset: 0x001FB5C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060082EA RID: 33514 RVA: 0x001FD3DC File Offset: 0x001FB5DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082EB RID: 33515 RVA: 0x001FD3E8 File Offset: 0x001FB5E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBilling = this.HasBilling;
			if (hasBilling)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Billing);
			}
			bool hasPresence = this.HasPresence;
			if (hasPresence)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Presence);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x001FD458 File Offset: 0x001FB658
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBilling = this.HasBilling;
			if (hasBilling)
			{
				num += 2;
			}
			bool hasPresence = this.HasPresence;
			if (hasPresence)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x001FD4AC File Offset: 0x001FB6AC
		[DebuggerNonUserCode]
		public void MergeFrom(SessionOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBilling = other.HasBilling;
				if (hasBilling)
				{
					this.Billing = other.Billing;
				}
				bool hasPresence = other.HasPresence;
				if (hasPresence)
				{
					this.Presence = other.Presence;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x001FD50E File Offset: 0x001FB70E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082EF RID: 33519 RVA: 0x001FD51C File Offset: 0x001FB71C
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Presence = input.ReadBool();
					}
				}
				else
				{
					this.Billing = input.ReadBool();
				}
			}
		}

		// Token: 0x04003B64 RID: 15204
		private static readonly MessageParser<SessionOptions> _parser = new MessageParser<SessionOptions>(() => new SessionOptions());

		// Token: 0x04003B65 RID: 15205
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B66 RID: 15206
		private int _hasBits0;

		// Token: 0x04003B67 RID: 15207
		public const int BillingFieldNumber = 1;

		// Token: 0x04003B68 RID: 15208
		private static readonly bool BillingDefaultValue = true;

		// Token: 0x04003B69 RID: 15209
		private bool billing_;

		// Token: 0x04003B6A RID: 15210
		public const int PresenceFieldNumber = 2;

		// Token: 0x04003B6B RID: 15211
		private static readonly bool PresenceDefaultValue = true;

		// Token: 0x04003B6C RID: 15212
		private bool presence_;
	}
}
