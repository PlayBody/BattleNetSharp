using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A2 RID: 674
	public sealed class AcknowledgePlayerNotification : IMessage<AcknowledgePlayerNotification>, IMessage, IEquatable<AcknowledgePlayerNotification>, IDeepCloneable<AcknowledgePlayerNotification>, IBufferMessage
	{
		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x0010FF6C File Offset: 0x0010E16C
		[DebuggerNonUserCode]
		public static MessageParser<AcknowledgePlayerNotification> Parser
		{
			get
			{
				return AcknowledgePlayerNotification._parser;
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x0010FF84 File Offset: 0x0010E184
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[146];
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x0010FFAC File Offset: 0x0010E1AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcknowledgePlayerNotification.Descriptor;
			}
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0010FFC3 File Offset: 0x0010E1C3
		[DebuggerNonUserCode]
		public AcknowledgePlayerNotification()
		{
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0010FFCD File Offset: 0x0010E1CD
		[DebuggerNonUserCode]
		public AcknowledgePlayerNotification(AcknowledgePlayerNotification other)
			: this()
		{
			this.notificationId_ = other.notificationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x0010FFF4 File Offset: 0x0010E1F4
		[DebuggerNonUserCode]
		public AcknowledgePlayerNotification Clone()
		{
			return new AcknowledgePlayerNotification(this);
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x0011000C File Offset: 0x0010E20C
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x0011002D File Offset: 0x0010E22D
		[DebuggerNonUserCode]
		public string NotificationId
		{
			get
			{
				return this.notificationId_ ?? AcknowledgePlayerNotification.NotificationIdDefaultValue;
			}
			set
			{
				this.notificationId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x00110044 File Offset: 0x0010E244
		[DebuggerNonUserCode]
		public bool HasNotificationId
		{
			get
			{
				return this.notificationId_ != null;
			}
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x0011005F File Offset: 0x0010E25F
		[DebuggerNonUserCode]
		public void ClearNotificationId()
		{
			this.notificationId_ = null;
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x0011006C File Offset: 0x0010E26C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcknowledgePlayerNotification);
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x0011008C File Offset: 0x0010E28C
		[DebuggerNonUserCode]
		public bool Equals(AcknowledgePlayerNotification other)
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
					bool flag4 = this.NotificationId != other.NotificationId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x001100E4 File Offset: 0x0010E2E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNotificationId = this.HasNotificationId;
			if (hasNotificationId)
			{
				num ^= this.NotificationId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x00110130 File Offset: 0x0010E330
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x00110148 File Offset: 0x0010E348
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x00110154 File Offset: 0x0010E354
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNotificationId = this.HasNotificationId;
			if (hasNotificationId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.NotificationId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x001101A0 File Offset: 0x0010E3A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNotificationId = this.HasNotificationId;
			if (hasNotificationId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NotificationId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x001101F0 File Offset: 0x0010E3F0
		[DebuggerNonUserCode]
		public void MergeFrom(AcknowledgePlayerNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNotificationId = other.HasNotificationId;
				if (hasNotificationId)
				{
					this.NotificationId = other.NotificationId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x00110239 File Offset: 0x0010E439
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x00110244 File Offset: 0x0010E444
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
					this.NotificationId = input.ReadString();
				}
			}
		}

		// Token: 0x04001F93 RID: 8083
		private static readonly MessageParser<AcknowledgePlayerNotification> _parser = new MessageParser<AcknowledgePlayerNotification>(() => new AcknowledgePlayerNotification());

		// Token: 0x04001F94 RID: 8084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F95 RID: 8085
		public const int NotificationIdFieldNumber = 1;

		// Token: 0x04001F96 RID: 8086
		private static readonly string NotificationIdDefaultValue = "";

		// Token: 0x04001F97 RID: 8087
		private string notificationId_;
	}
}
