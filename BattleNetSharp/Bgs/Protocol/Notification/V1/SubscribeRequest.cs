using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005CA RID: 1482
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x06008C23 RID: 35875 RVA: 0x00220038 File Offset: 0x0021E238
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x06008C24 RID: 35876 RVA: 0x00220050 File Offset: 0x0021E250
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x06008C25 RID: 35877 RVA: 0x00220074 File Offset: 0x0021E274
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x0022008B File Offset: 0x0021E28B
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x00220095 File Offset: 0x0021E295
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this.subscription_ = ((other.subscription_ != null) ? other.subscription_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x002200CC File Offset: 0x0021E2CC
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x06008C29 RID: 35881 RVA: 0x002200E4 File Offset: 0x0021E2E4
		// (set) Token: 0x06008C2A RID: 35882 RVA: 0x002200FC File Offset: 0x0021E2FC
		[DebuggerNonUserCode]
		public Subscription Subscription
		{
			get
			{
				return this.subscription_;
			}
			set
			{
				this.subscription_ = value;
			}
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x00220108 File Offset: 0x0021E308
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x00220128 File Offset: 0x0021E328
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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
					bool flag4 = !object.Equals(this.Subscription, other.Subscription);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x00220184 File Offset: 0x0021E384
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.subscription_ != null;
			if (flag)
			{
				num ^= this.Subscription.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x002201D4 File Offset: 0x0021E3D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C2F RID: 35887 RVA: 0x002201EC File Offset: 0x0021E3EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x002201F8 File Offset: 0x0021E3F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.subscription_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Subscription);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x00220248 File Offset: 0x0021E448
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.subscription_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscription);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C32 RID: 35890 RVA: 0x0022029C File Offset: 0x0021E49C
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.subscription_ != null;
				if (flag2)
				{
					bool flag3 = this.subscription_ == null;
					if (flag3)
					{
						this.Subscription = new Subscription();
					}
					this.Subscription.MergeFrom(other.Subscription);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008C33 RID: 35891 RVA: 0x00220308 File Offset: 0x0021E508
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C34 RID: 35892 RVA: 0x00220314 File Offset: 0x0021E514
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
					bool flag = this.subscription_ == null;
					if (flag)
					{
						this.Subscription = new Subscription();
					}
					input.ReadMessage(this.Subscription);
				}
			}
		}

		// Token: 0x04003F68 RID: 16232
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x04003F69 RID: 16233
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F6A RID: 16234
		public const int SubscriptionFieldNumber = 1;

		// Token: 0x04003F6B RID: 16235
		private Subscription subscription_;
	}
}
