using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005D5 RID: 1493
	public sealed class NotificationReceivedNotification : IMessage<NotificationReceivedNotification>, IMessage, IEquatable<NotificationReceivedNotification>, IDeepCloneable<NotificationReceivedNotification>, IBufferMessage
	{
		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x06008CDC RID: 36060 RVA: 0x00223024 File Offset: 0x00221224
		[DebuggerNonUserCode]
		public static MessageParser<NotificationReceivedNotification> Parser
		{
			get
			{
				return NotificationReceivedNotification._parser;
			}
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x0022303C File Offset: 0x0022123C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x06008CDE RID: 36062 RVA: 0x00223060 File Offset: 0x00221260
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NotificationReceivedNotification.Descriptor;
			}
		}

		// Token: 0x06008CDF RID: 36063 RVA: 0x00223077 File Offset: 0x00221277
		[DebuggerNonUserCode]
		public NotificationReceivedNotification()
		{
		}

		// Token: 0x06008CE0 RID: 36064 RVA: 0x0022308C File Offset: 0x0022128C
		[DebuggerNonUserCode]
		public NotificationReceivedNotification(NotificationReceivedNotification other)
			: this()
		{
			this.notifications_ = other.notifications_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CE1 RID: 36065 RVA: 0x002230B8 File Offset: 0x002212B8
		[DebuggerNonUserCode]
		public NotificationReceivedNotification Clone()
		{
			return new NotificationReceivedNotification(this);
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x002230D0 File Offset: 0x002212D0
		[DebuggerNonUserCode]
		public RepeatedField<Notification> Notifications
		{
			get
			{
				return this.notifications_;
			}
		}

		// Token: 0x06008CE3 RID: 36067 RVA: 0x002230E8 File Offset: 0x002212E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NotificationReceivedNotification);
		}

		// Token: 0x06008CE4 RID: 36068 RVA: 0x00223108 File Offset: 0x00221308
		[DebuggerNonUserCode]
		public bool Equals(NotificationReceivedNotification other)
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
					bool flag4 = !this.notifications_.Equals(other.notifications_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x00223164 File Offset: 0x00221364
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.notifications_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x002231A4 File Offset: 0x002213A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008CE7 RID: 36071 RVA: 0x002231BC File Offset: 0x002213BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x002231C8 File Offset: 0x002213C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.notifications_.WriteTo(ref output, NotificationReceivedNotification._repeated_notifications_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CE9 RID: 36073 RVA: 0x00223204 File Offset: 0x00221404
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.notifications_.CalculateSize(NotificationReceivedNotification._repeated_notifications_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CEA RID: 36074 RVA: 0x0022324C File Offset: 0x0022144C
		[DebuggerNonUserCode]
		public void MergeFrom(NotificationReceivedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.notifications_.Add(other.notifications_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x0022328E File Offset: 0x0022148E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x0022329C File Offset: 0x0022149C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.notifications_.AddEntriesFrom(ref input, NotificationReceivedNotification._repeated_notifications_codec);
				}
			}
		}

		// Token: 0x04003FB8 RID: 16312
		private static readonly MessageParser<NotificationReceivedNotification> _parser = new MessageParser<NotificationReceivedNotification>(() => new NotificationReceivedNotification());

		// Token: 0x04003FB9 RID: 16313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FBA RID: 16314
		public const int NotificationsFieldNumber = 1;

		// Token: 0x04003FBB RID: 16315
		private static readonly FieldCodec<Notification> _repeated_notifications_codec = FieldCodec.ForMessage<Notification>(10U, Notification.Parser);

		// Token: 0x04003FBC RID: 16316
		private readonly RepeatedField<Notification> notifications_ = new RepeatedField<Notification>();
	}
}
