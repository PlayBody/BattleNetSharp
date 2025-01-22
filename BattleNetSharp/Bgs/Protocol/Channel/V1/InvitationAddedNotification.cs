using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C1 RID: 1729
	public sealed class InvitationAddedNotification : IMessage<InvitationAddedNotification>, IMessage, IEquatable<InvitationAddedNotification>, IDeepCloneable<InvitationAddedNotification>, IBufferMessage
	{
		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x0026DA58 File Offset: 0x0026BC58
		[DebuggerNonUserCode]
		public static MessageParser<InvitationAddedNotification> Parser
		{
			get
			{
				return InvitationAddedNotification._parser;
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x06009FCE RID: 40910 RVA: 0x0026DA70 File Offset: 0x0026BC70
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x0026DA94 File Offset: 0x0026BC94
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x0026DAAB File Offset: 0x0026BCAB
		[DebuggerNonUserCode]
		public InvitationAddedNotification()
		{
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x0026DAB8 File Offset: 0x0026BCB8
		[DebuggerNonUserCode]
		public InvitationAddedNotification(InvitationAddedNotification other)
			: this()
		{
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x0026DB18 File Offset: 0x0026BD18
		[DebuggerNonUserCode]
		public InvitationAddedNotification Clone()
		{
			return new InvitationAddedNotification(this);
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x0026DB30 File Offset: 0x0026BD30
		// (set) Token: 0x06009FD4 RID: 40916 RVA: 0x0026DB48 File Offset: 0x0026BD48
		[DebuggerNonUserCode]
		public Invitation Invitation
		{
			get
			{
				return this.invitation_;
			}
			set
			{
				this.invitation_ = value;
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x06009FD5 RID: 40917 RVA: 0x0026DB54 File Offset: 0x0026BD54
		// (set) Token: 0x06009FD6 RID: 40918 RVA: 0x0026DB6C File Offset: 0x0026BD6C
		[DebuggerNonUserCode]
		public Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x0026DB78 File Offset: 0x0026BD78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationAddedNotification);
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x0026DB98 File Offset: 0x0026BD98
		[DebuggerNonUserCode]
		public bool Equals(InvitationAddedNotification other)
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
					bool flag4 = !object.Equals(this.Invitation, other.Invitation);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Subscriber, other.Subscriber);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x0026DC10 File Offset: 0x0026BE10
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool flag2 = this.subscriber_ != null;
			if (flag2)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x0026DC7C File Offset: 0x0026BE7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x0026DC94 File Offset: 0x0026BE94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x0026DCA0 File Offset: 0x0026BEA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.invitation_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Invitation);
			}
			bool flag2 = this.subscriber_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Subscriber);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x0026DD14 File Offset: 0x0026BF14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool flag2 = this.subscriber_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x0026DD88 File Offset: 0x0026BF88
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.invitation_ != null;
				if (flag2)
				{
					bool flag3 = this.invitation_ == null;
					if (flag3)
					{
						this.Invitation = new Invitation();
					}
					this.Invitation.MergeFrom(other.Invitation);
				}
				bool flag4 = other.subscriber_ != null;
				if (flag4)
				{
					bool flag5 = this.subscriber_ == null;
					if (flag5)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x0026DE35 File Offset: 0x0026C035
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x0026DE40 File Offset: 0x0026C040
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
						bool flag = this.subscriber_ == null;
						if (flag)
						{
							this.Subscriber = new Identity();
						}
						input.ReadMessage(this.Subscriber);
					}
				}
				else
				{
					bool flag2 = this.invitation_ == null;
					if (flag2)
					{
						this.Invitation = new Invitation();
					}
					input.ReadMessage(this.Invitation);
				}
			}
		}

		// Token: 0x040047FF RID: 18431
		private static readonly MessageParser<InvitationAddedNotification> _parser = new MessageParser<InvitationAddedNotification>(() => new InvitationAddedNotification());

		// Token: 0x04004800 RID: 18432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004801 RID: 18433
		public const int InvitationFieldNumber = 1;

		// Token: 0x04004802 RID: 18434
		private Invitation invitation_;

		// Token: 0x04004803 RID: 18435
		public const int SubscriberFieldNumber = 2;

		// Token: 0x04004804 RID: 18436
		private Identity subscriber_;
	}
}
