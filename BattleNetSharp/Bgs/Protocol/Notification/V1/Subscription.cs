using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005D1 RID: 1489
	public sealed class Subscription : IMessage<Subscription>, IMessage, IEquatable<Subscription>, IDeepCloneable<Subscription>, IBufferMessage
	{
		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x00221710 File Offset: 0x0021F910
		[DebuggerNonUserCode]
		public static MessageParser<Subscription> Parser
		{
			get
			{
				return Subscription._parser;
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x06008C84 RID: 35972 RVA: 0x00221728 File Offset: 0x0021F928
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x06008C85 RID: 35973 RVA: 0x0022174C File Offset: 0x0021F94C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Subscription.Descriptor;
			}
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x00221763 File Offset: 0x0021F963
		[DebuggerNonUserCode]
		public Subscription()
		{
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00221778 File Offset: 0x0021F978
		[DebuggerNonUserCode]
		public Subscription(Subscription other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.target_ = other.target_.Clone();
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this.deliveryRequired_ = other.deliveryRequired_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x002217E4 File Offset: 0x0021F9E4
		[DebuggerNonUserCode]
		public Subscription Clone()
		{
			return new Subscription(this);
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x06008C89 RID: 35977 RVA: 0x002217FC File Offset: 0x0021F9FC
		[DebuggerNonUserCode]
		public RepeatedField<Target> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x06008C8A RID: 35978 RVA: 0x00221814 File Offset: 0x0021FA14
		// (set) Token: 0x06008C8B RID: 35979 RVA: 0x0022182C File Offset: 0x0021FA2C
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

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x06008C8C RID: 35980 RVA: 0x00221838 File Offset: 0x0021FA38
		// (set) Token: 0x06008C8D RID: 35981 RVA: 0x00221869 File Offset: 0x0021FA69
		[DebuggerNonUserCode]
		public bool DeliveryRequired
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool deliveryRequiredDefaultValue;
				if (flag)
				{
					deliveryRequiredDefaultValue = this.deliveryRequired_;
				}
				else
				{
					deliveryRequiredDefaultValue = Subscription.DeliveryRequiredDefaultValue;
				}
				return deliveryRequiredDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.deliveryRequired_ = value;
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x06008C8E RID: 35982 RVA: 0x00221884 File Offset: 0x0021FA84
		[DebuggerNonUserCode]
		public bool HasDeliveryRequired
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x002218A1 File Offset: 0x0021FAA1
		[DebuggerNonUserCode]
		public void ClearDeliveryRequired()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x002218B4 File Offset: 0x0021FAB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Subscription);
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x002218D4 File Offset: 0x0021FAD4
		[DebuggerNonUserCode]
		public bool Equals(Subscription other)
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
					bool flag4 = !this.target_.Equals(other.target_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Subscriber, other.Subscriber);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.DeliveryRequired != other.DeliveryRequired;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x00221968 File Offset: 0x0021FB68
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.target_.GetHashCode();
			bool flag = this.subscriber_ != null;
			if (flag)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool hasDeliveryRequired = this.HasDeliveryRequired;
			if (hasDeliveryRequired)
			{
				num ^= this.DeliveryRequired.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x002219E4 File Offset: 0x0021FBE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x002219FC File Offset: 0x0021FBFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x00221A08 File Offset: 0x0021FC08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.target_.WriteTo(ref output, Subscription._repeated_target_codec);
			bool flag = this.subscriber_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Subscriber);
			}
			bool hasDeliveryRequired = this.HasDeliveryRequired;
			if (hasDeliveryRequired)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.DeliveryRequired);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x00221A8C File Offset: 0x0021FC8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.target_.CalculateSize(Subscription._repeated_target_codec);
			bool flag = this.subscriber_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool hasDeliveryRequired = this.HasDeliveryRequired;
			if (hasDeliveryRequired)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x00221B04 File Offset: 0x0021FD04
		[DebuggerNonUserCode]
		public void MergeFrom(Subscription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.target_.Add(other.target_);
				bool flag2 = other.subscriber_ != null;
				if (flag2)
				{
					bool flag3 = this.subscriber_ == null;
					if (flag3)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				bool hasDeliveryRequired = other.HasDeliveryRequired;
				if (hasDeliveryRequired)
				{
					this.DeliveryRequired = other.DeliveryRequired;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x00221B9B File Offset: 0x0021FD9B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x00221BA8 File Offset: 0x0021FDA8
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DeliveryRequired = input.ReadBool();
						}
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
					this.target_.AddEntriesFrom(ref input, Subscription._repeated_target_codec);
				}
			}
		}

		// Token: 0x04003F8C RID: 16268
		private static readonly MessageParser<Subscription> _parser = new MessageParser<Subscription>(() => new Subscription());

		// Token: 0x04003F8D RID: 16269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F8E RID: 16270
		private int _hasBits0;

		// Token: 0x04003F8F RID: 16271
		public const int TargetFieldNumber = 1;

		// Token: 0x04003F90 RID: 16272
		private static readonly FieldCodec<Target> _repeated_target_codec = FieldCodec.ForMessage<Target>(10U, Bgs.Protocol.Notification.V1.Target.Parser);

		// Token: 0x04003F91 RID: 16273
		private readonly RepeatedField<Target> target_ = new RepeatedField<Target>();

		// Token: 0x04003F92 RID: 16274
		public const int SubscriberFieldNumber = 2;

		// Token: 0x04003F93 RID: 16275
		private Identity subscriber_;

		// Token: 0x04003F94 RID: 16276
		public const int DeliveryRequiredFieldNumber = 3;

		// Token: 0x04003F95 RID: 16277
		private static readonly bool DeliveryRequiredDefaultValue = false;

		// Token: 0x04003F96 RID: 16278
		private bool deliveryRequired_;
	}
}
