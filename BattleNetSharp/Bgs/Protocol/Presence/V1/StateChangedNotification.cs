using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x0200059C RID: 1436
	public sealed class StateChangedNotification : IMessage<StateChangedNotification>, IMessage, IEquatable<StateChangedNotification>, IDeepCloneable<StateChangedNotification>, IBufferMessage
	{
		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x060088E1 RID: 35041 RVA: 0x00213A30 File Offset: 0x00211C30
		[DebuggerNonUserCode]
		public static MessageParser<StateChangedNotification> Parser
		{
			get
			{
				return StateChangedNotification._parser;
			}
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x060088E2 RID: 35042 RVA: 0x00213A48 File Offset: 0x00211C48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x060088E3 RID: 35043 RVA: 0x00213A6C File Offset: 0x00211C6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StateChangedNotification.Descriptor;
			}
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x00213A83 File Offset: 0x00211C83
		[DebuggerNonUserCode]
		public StateChangedNotification()
		{
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x00213A98 File Offset: 0x00211C98
		[DebuggerNonUserCode]
		public StateChangedNotification(StateChangedNotification other)
			: this()
		{
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.state_ = other.state_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x00213AEC File Offset: 0x00211CEC
		[DebuggerNonUserCode]
		public StateChangedNotification Clone()
		{
			return new StateChangedNotification(this);
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x060088E7 RID: 35047 RVA: 0x00213B04 File Offset: 0x00211D04
		// (set) Token: 0x060088E8 RID: 35048 RVA: 0x00213B1C File Offset: 0x00211D1C
		[DebuggerNonUserCode]
		public AccountId SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x060088E9 RID: 35049 RVA: 0x00213B28 File Offset: 0x00211D28
		[DebuggerNonUserCode]
		public RepeatedField<PresenceState> State
		{
			get
			{
				return this.state_;
			}
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x00213B40 File Offset: 0x00211D40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StateChangedNotification);
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x00213B60 File Offset: 0x00211D60
		[DebuggerNonUserCode]
		public bool Equals(StateChangedNotification other)
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
					bool flag4 = !object.Equals(this.SubscriberId, other.SubscriberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.state_.Equals(other.state_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x00213BD8 File Offset: 0x00211DD8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			num ^= this.state_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x00213C34 File Offset: 0x00211E34
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x00213C4C File Offset: 0x00211E4C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088EF RID: 35055 RVA: 0x00213C58 File Offset: 0x00211E58
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SubscriberId);
			}
			this.state_.WriteTo(ref output, StateChangedNotification._repeated_state_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x00213CBC File Offset: 0x00211EBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			num += this.state_.CalculateSize(StateChangedNotification._repeated_state_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x00213D20 File Offset: 0x00211F20
		[DebuggerNonUserCode]
		public void MergeFrom(StateChangedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.subscriberId_ != null;
				if (flag2)
				{
					bool flag3 = this.subscriberId_ == null;
					if (flag3)
					{
						this.SubscriberId = new AccountId();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				this.state_.Add(other.state_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060088F2 RID: 35058 RVA: 0x00213D9E File Offset: 0x00211F9E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088F3 RID: 35059 RVA: 0x00213DAC File Offset: 0x00211FAC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.state_.AddEntriesFrom(ref input, StateChangedNotification._repeated_state_codec);
					}
				}
				else
				{
					bool flag = this.subscriberId_ == null;
					if (flag)
					{
						this.SubscriberId = new AccountId();
					}
					input.ReadMessage(this.SubscriberId);
				}
			}
		}

		// Token: 0x04003DF2 RID: 15858
		private static readonly MessageParser<StateChangedNotification> _parser = new MessageParser<StateChangedNotification>(() => new StateChangedNotification());

		// Token: 0x04003DF3 RID: 15859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DF4 RID: 15860
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04003DF5 RID: 15861
		private AccountId subscriberId_;

		// Token: 0x04003DF6 RID: 15862
		public const int StateFieldNumber = 2;

		// Token: 0x04003DF7 RID: 15863
		private static readonly FieldCodec<PresenceState> _repeated_state_codec = FieldCodec.ForMessage<PresenceState>(18U, PresenceState.Parser);

		// Token: 0x04003DF8 RID: 15864
		private readonly RepeatedField<PresenceState> state_ = new RepeatedField<PresenceState>();
	}
}
