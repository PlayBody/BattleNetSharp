using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C2 RID: 1730
	public sealed class InvitationRemovedNotification : IMessage<InvitationRemovedNotification>, IMessage, IEquatable<InvitationRemovedNotification>, IDeepCloneable<InvitationRemovedNotification>, IBufferMessage
	{
		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x06009FE2 RID: 40930 RVA: 0x0026DF04 File Offset: 0x0026C104
		[DebuggerNonUserCode]
		public static MessageParser<InvitationRemovedNotification> Parser
		{
			get
			{
				return InvitationRemovedNotification._parser;
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x06009FE3 RID: 40931 RVA: 0x0026DF1C File Offset: 0x0026C11C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x0026DF40 File Offset: 0x0026C140
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x0026DF57 File Offset: 0x0026C157
		[DebuggerNonUserCode]
		public InvitationRemovedNotification()
		{
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x0026DF64 File Offset: 0x0026C164
		[DebuggerNonUserCode]
		public InvitationRemovedNotification(InvitationRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.invitation_ = ((other.invitation_ != null) ? other.invitation_.Clone() : null);
			this.reason_ = other.reason_;
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x0026DFDC File Offset: 0x0026C1DC
		[DebuggerNonUserCode]
		public InvitationRemovedNotification Clone()
		{
			return new InvitationRemovedNotification(this);
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x06009FE8 RID: 40936 RVA: 0x0026DFF4 File Offset: 0x0026C1F4
		// (set) Token: 0x06009FE9 RID: 40937 RVA: 0x0026E00C File Offset: 0x0026C20C
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

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x06009FEA RID: 40938 RVA: 0x0026E018 File Offset: 0x0026C218
		// (set) Token: 0x06009FEB RID: 40939 RVA: 0x0026E049 File Offset: 0x0026C249
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = InvitationRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x06009FEC RID: 40940 RVA: 0x0026E064 File Offset: 0x0026C264
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x0026E081 File Offset: 0x0026C281
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x06009FEE RID: 40942 RVA: 0x0026E094 File Offset: 0x0026C294
		// (set) Token: 0x06009FEF RID: 40943 RVA: 0x0026E0AC File Offset: 0x0026C2AC
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

		// Token: 0x06009FF0 RID: 40944 RVA: 0x0026E0B8 File Offset: 0x0026C2B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationRemovedNotification);
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x0026E0D8 File Offset: 0x0026C2D8
		[DebuggerNonUserCode]
		public bool Equals(InvitationRemovedNotification other)
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
						bool flag5 = this.Reason != other.Reason;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Subscriber, other.Subscriber);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x0026E16C File Offset: 0x0026C36C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num ^= this.Invitation.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
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

		// Token: 0x06009FF3 RID: 40947 RVA: 0x0026E1F8 File Offset: 0x0026C3F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x0026E210 File Offset: 0x0026C410
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x0026E21C File Offset: 0x0026C41C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.invitation_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Invitation);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Reason);
			}
			bool flag2 = this.subscriber_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Subscriber);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x0026E2B4 File Offset: 0x0026C4B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.invitation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Invitation);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
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

		// Token: 0x06009FF7 RID: 40951 RVA: 0x0026E344 File Offset: 0x0026C544
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationRemovedNotification other)
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
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
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

		// Token: 0x06009FF8 RID: 40952 RVA: 0x0026E40C File Offset: 0x0026C60C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x0026E418 File Offset: 0x0026C618
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
					if (num3 != 16U)
					{
						if (num3 != 26U)
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
						this.Reason = input.ReadUInt32();
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

		// Token: 0x04004805 RID: 18437
		private static readonly MessageParser<InvitationRemovedNotification> _parser = new MessageParser<InvitationRemovedNotification>(() => new InvitationRemovedNotification());

		// Token: 0x04004806 RID: 18438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004807 RID: 18439
		private int _hasBits0;

		// Token: 0x04004808 RID: 18440
		public const int InvitationFieldNumber = 1;

		// Token: 0x04004809 RID: 18441
		private Invitation invitation_;

		// Token: 0x0400480A RID: 18442
		public const int ReasonFieldNumber = 2;

		// Token: 0x0400480B RID: 18443
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x0400480C RID: 18444
		private uint reason_;

		// Token: 0x0400480D RID: 18445
		public const int SubscriberFieldNumber = 3;

		// Token: 0x0400480E RID: 18446
		private Identity subscriber_;
	}
}
