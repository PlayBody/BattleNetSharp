using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B3 RID: 1459
	public sealed class PresenceStateUpdatedNotification : IMessage<PresenceStateUpdatedNotification>, IMessage, IEquatable<PresenceStateUpdatedNotification>, IDeepCloneable<PresenceStateUpdatedNotification>, IBufferMessage
	{
		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06008A98 RID: 35480 RVA: 0x0021A7B0 File Offset: 0x002189B0
		[DebuggerNonUserCode]
		public static MessageParser<PresenceStateUpdatedNotification> Parser
		{
			get
			{
				return PresenceStateUpdatedNotification._parser;
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x06008A99 RID: 35481 RVA: 0x0021A7C8 File Offset: 0x002189C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x06008A9A RID: 35482 RVA: 0x0021A7EC File Offset: 0x002189EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceStateUpdatedNotification.Descriptor;
			}
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x0021A803 File Offset: 0x00218A03
		[DebuggerNonUserCode]
		public PresenceStateUpdatedNotification()
		{
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x0021A818 File Offset: 0x00218A18
		[DebuggerNonUserCode]
		public PresenceStateUpdatedNotification(PresenceStateUpdatedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.subscriberId_ = other.subscriberId_;
			this.states_ = other.states_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x0021A868 File Offset: 0x00218A68
		[DebuggerNonUserCode]
		public PresenceStateUpdatedNotification Clone()
		{
			return new PresenceStateUpdatedNotification(this);
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x06008A9E RID: 35486 RVA: 0x0021A880 File Offset: 0x00218A80
		// (set) Token: 0x06008A9F RID: 35487 RVA: 0x0021A8B1 File Offset: 0x00218AB1
		[DebuggerNonUserCode]
		public ulong SubscriberId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong subscriberIdDefaultValue;
				if (flag)
				{
					subscriberIdDefaultValue = this.subscriberId_;
				}
				else
				{
					subscriberIdDefaultValue = PresenceStateUpdatedNotification.SubscriberIdDefaultValue;
				}
				return subscriberIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.subscriberId_ = value;
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x06008AA0 RID: 35488 RVA: 0x0021A8CC File Offset: 0x00218ACC
		[DebuggerNonUserCode]
		public bool HasSubscriberId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x0021A8E9 File Offset: 0x00218AE9
		[DebuggerNonUserCode]
		public void ClearSubscriberId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x06008AA2 RID: 35490 RVA: 0x0021A8FC File Offset: 0x00218AFC
		[DebuggerNonUserCode]
		public RepeatedField<PresenceFieldState> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x06008AA3 RID: 35491 RVA: 0x0021A914 File Offset: 0x00218B14
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceStateUpdatedNotification);
		}

		// Token: 0x06008AA4 RID: 35492 RVA: 0x0021A934 File Offset: 0x00218B34
		[DebuggerNonUserCode]
		public bool Equals(PresenceStateUpdatedNotification other)
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
					bool flag4 = this.SubscriberId != other.SubscriberId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.states_.Equals(other.states_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008AA5 RID: 35493 RVA: 0x0021A9A8 File Offset: 0x00218BA8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			num ^= this.states_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AA6 RID: 35494 RVA: 0x0021AA08 File Offset: 0x00218C08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AA7 RID: 35495 RVA: 0x0021AA20 File Offset: 0x00218C20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AA8 RID: 35496 RVA: 0x0021AA2C File Offset: 0x00218C2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.SubscriberId);
			}
			this.states_.WriteTo(ref output, PresenceStateUpdatedNotification._repeated_states_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AA9 RID: 35497 RVA: 0x0021AA8C File Offset: 0x00218C8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSubscriberId = this.HasSubscriberId;
			if (hasSubscriberId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SubscriberId);
			}
			num += this.states_.CalculateSize(PresenceStateUpdatedNotification._repeated_states_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x0021AAF0 File Offset: 0x00218CF0
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceStateUpdatedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSubscriberId = other.HasSubscriberId;
				if (hasSubscriberId)
				{
					this.SubscriberId = other.SubscriberId;
				}
				this.states_.Add(other.states_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x0021AB4B File Offset: 0x00218D4B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x0021AB58 File Offset: 0x00218D58
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.states_.AddEntriesFrom(ref input, PresenceStateUpdatedNotification._repeated_states_codec);
					}
				}
				else
				{
					this.SubscriberId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003EBB RID: 16059
		private static readonly MessageParser<PresenceStateUpdatedNotification> _parser = new MessageParser<PresenceStateUpdatedNotification>(() => new PresenceStateUpdatedNotification());

		// Token: 0x04003EBC RID: 16060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EBD RID: 16061
		private int _hasBits0;

		// Token: 0x04003EBE RID: 16062
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04003EBF RID: 16063
		private static readonly ulong SubscriberIdDefaultValue = 0UL;

		// Token: 0x04003EC0 RID: 16064
		private ulong subscriberId_;

		// Token: 0x04003EC1 RID: 16065
		public const int StatesFieldNumber = 2;

		// Token: 0x04003EC2 RID: 16066
		private static readonly FieldCodec<PresenceFieldState> _repeated_states_codec = FieldCodec.ForMessage<PresenceFieldState>(18U, PresenceFieldState.Parser);

		// Token: 0x04003EC3 RID: 16067
		private readonly RepeatedField<PresenceFieldState> states_ = new RepeatedField<PresenceFieldState>();
	}
}
