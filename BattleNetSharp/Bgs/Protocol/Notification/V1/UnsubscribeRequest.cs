using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005CB RID: 1483
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x06008C36 RID: 35894 RVA: 0x002203A0 File Offset: 0x0021E5A0
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x06008C37 RID: 35895 RVA: 0x002203B8 File Offset: 0x0021E5B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x06008C38 RID: 35896 RVA: 0x002203DC File Offset: 0x0021E5DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x002203F3 File Offset: 0x0021E5F3
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x002203FD File Offset: 0x0021E5FD
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this.subscription_ = ((other.subscription_ != null) ? other.subscription_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x00220434 File Offset: 0x0021E634
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x06008C3C RID: 35900 RVA: 0x0022044C File Offset: 0x0021E64C
		// (set) Token: 0x06008C3D RID: 35901 RVA: 0x00220464 File Offset: 0x0021E664
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

		// Token: 0x06008C3E RID: 35902 RVA: 0x00220470 File Offset: 0x0021E670
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x06008C3F RID: 35903 RVA: 0x00220490 File Offset: 0x0021E690
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeRequest other)
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

		// Token: 0x06008C40 RID: 35904 RVA: 0x002204EC File Offset: 0x0021E6EC
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

		// Token: 0x06008C41 RID: 35905 RVA: 0x0022053C File Offset: 0x0021E73C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00220554 File Offset: 0x0021E754
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x00220560 File Offset: 0x0021E760
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

		// Token: 0x06008C44 RID: 35908 RVA: 0x002205B0 File Offset: 0x0021E7B0
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

		// Token: 0x06008C45 RID: 35909 RVA: 0x00220604 File Offset: 0x0021E804
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeRequest other)
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

		// Token: 0x06008C46 RID: 35910 RVA: 0x00220670 File Offset: 0x0021E870
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x0022067C File Offset: 0x0021E87C
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

		// Token: 0x04003F6C RID: 16236
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x04003F6D RID: 16237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F6E RID: 16238
		public const int SubscriptionFieldNumber = 1;

		// Token: 0x04003F6F RID: 16239
		private Subscription subscription_;
	}
}
