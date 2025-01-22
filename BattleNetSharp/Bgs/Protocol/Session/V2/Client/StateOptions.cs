using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000569 RID: 1385
	public sealed class StateOptions : IMessage<StateOptions>, IMessage, IEquatable<StateOptions>, IDeepCloneable<StateOptions>, IBufferMessage
	{
		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x06008520 RID: 34080 RVA: 0x00205B24 File Offset: 0x00203D24
		[DebuggerNonUserCode]
		public static MessageParser<StateOptions> Parser
		{
			get
			{
				return StateOptions._parser;
			}
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x06008521 RID: 34081 RVA: 0x00205B3C File Offset: 0x00203D3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x06008522 RID: 34082 RVA: 0x00205B60 File Offset: 0x00203D60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateOptions.Descriptor;
			}
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x00205B77 File Offset: 0x00203D77
		[DebuggerNonUserCode]
		public StateOptions()
		{
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x00205B81 File Offset: 0x00203D81
		[DebuggerNonUserCode]
		public StateOptions(StateOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.billing_ = other.billing_;
			this.presence_ = other.presence_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x00205BC0 File Offset: 0x00203DC0
		[DebuggerNonUserCode]
		public StateOptions Clone()
		{
			return new StateOptions(this);
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x06008526 RID: 34086 RVA: 0x00205BD8 File Offset: 0x00203DD8
		// (set) Token: 0x06008527 RID: 34087 RVA: 0x00205C09 File Offset: 0x00203E09
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
					billingDefaultValue = StateOptions.BillingDefaultValue;
				}
				return billingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.billing_ = value;
			}
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x06008528 RID: 34088 RVA: 0x00205C24 File Offset: 0x00203E24
		[DebuggerNonUserCode]
		public bool HasBilling
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008529 RID: 34089 RVA: 0x00205C41 File Offset: 0x00203E41
		[DebuggerNonUserCode]
		public void ClearBilling()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0600852A RID: 34090 RVA: 0x00205C54 File Offset: 0x00203E54
		// (set) Token: 0x0600852B RID: 34091 RVA: 0x00205C85 File Offset: 0x00203E85
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
					presenceDefaultValue = StateOptions.PresenceDefaultValue;
				}
				return presenceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.presence_ = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0600852C RID: 34092 RVA: 0x00205CA0 File Offset: 0x00203EA0
		[DebuggerNonUserCode]
		public bool HasPresence
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600852D RID: 34093 RVA: 0x00205CBD File Offset: 0x00203EBD
		[DebuggerNonUserCode]
		public void ClearPresence()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600852E RID: 34094 RVA: 0x00205CD0 File Offset: 0x00203ED0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateOptions);
		}

		// Token: 0x0600852F RID: 34095 RVA: 0x00205CF0 File Offset: 0x00203EF0
		[DebuggerNonUserCode]
		public bool Equals(StateOptions other)
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

		// Token: 0x06008530 RID: 34096 RVA: 0x00205D64 File Offset: 0x00203F64
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

		// Token: 0x06008531 RID: 34097 RVA: 0x00205DD0 File Offset: 0x00203FD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008532 RID: 34098 RVA: 0x00205DE8 File Offset: 0x00203FE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x00205DF4 File Offset: 0x00203FF4
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

		// Token: 0x06008534 RID: 34100 RVA: 0x00205E64 File Offset: 0x00204064
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

		// Token: 0x06008535 RID: 34101 RVA: 0x00205EB8 File Offset: 0x002040B8
		[DebuggerNonUserCode]
		public void MergeFrom(StateOptions other)
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

		// Token: 0x06008536 RID: 34102 RVA: 0x00205F1A File Offset: 0x0020411A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x00205F28 File Offset: 0x00204128
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

		// Token: 0x04003C63 RID: 15459
		private static readonly MessageParser<StateOptions> _parser = new MessageParser<StateOptions>(() => new StateOptions());

		// Token: 0x04003C64 RID: 15460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C65 RID: 15461
		private int _hasBits0;

		// Token: 0x04003C66 RID: 15462
		public const int BillingFieldNumber = 1;

		// Token: 0x04003C67 RID: 15463
		private static readonly bool BillingDefaultValue = false;

		// Token: 0x04003C68 RID: 15464
		private bool billing_;

		// Token: 0x04003C69 RID: 15465
		public const int PresenceFieldNumber = 2;

		// Token: 0x04003C6A RID: 15466
		private static readonly bool PresenceDefaultValue = false;

		// Token: 0x04003C6B RID: 15467
		private bool presence_;
	}
}
