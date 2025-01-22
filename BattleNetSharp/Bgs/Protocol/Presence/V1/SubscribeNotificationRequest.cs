using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A0 RID: 1440
	public sealed class SubscribeNotificationRequest : IMessage<SubscribeNotificationRequest>, IMessage, IEquatable<SubscribeNotificationRequest>, IDeepCloneable<SubscribeNotificationRequest>, IBufferMessage
	{
		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x06008918 RID: 35096 RVA: 0x00214CB8 File Offset: 0x00212EB8
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeNotificationRequest> Parser
		{
			get
			{
				return SubscribeNotificationRequest._parser;
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x06008919 RID: 35097 RVA: 0x00214CD0 File Offset: 0x00212ED0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0600891A RID: 35098 RVA: 0x00214CF4 File Offset: 0x00212EF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeNotificationRequest.Descriptor;
			}
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x00214D0B File Offset: 0x00212F0B
		[DebuggerNonUserCode]
		public SubscribeNotificationRequest()
		{
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x00214D15 File Offset: 0x00212F15
		[DebuggerNonUserCode]
		public SubscribeNotificationRequest(SubscribeNotificationRequest other)
			: this()
		{
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x00214D4C File Offset: 0x00212F4C
		[DebuggerNonUserCode]
		public SubscribeNotificationRequest Clone()
		{
			return new SubscribeNotificationRequest(this);
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x0600891E RID: 35102 RVA: 0x00214D64 File Offset: 0x00212F64
		// (set) Token: 0x0600891F RID: 35103 RVA: 0x00214D7C File Offset: 0x00212F7C
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06008920 RID: 35104 RVA: 0x00214D88 File Offset: 0x00212F88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeNotificationRequest);
		}

		// Token: 0x06008921 RID: 35105 RVA: 0x00214DA8 File Offset: 0x00212FA8
		[DebuggerNonUserCode]
		public bool Equals(SubscribeNotificationRequest other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x00214E04 File Offset: 0x00213004
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x00214E54 File Offset: 0x00213054
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x00214E6C File Offset: 0x0021306C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008925 RID: 35109 RVA: 0x00214E78 File Offset: 0x00213078
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x00214EC8 File Offset: 0x002130C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x00214F1C File Offset: 0x0021311C
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeNotificationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x00214F88 File Offset: 0x00213188
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x00214F94 File Offset: 0x00213194
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
					bool flag = this.entityId_ == null;
					if (flag)
					{
						this.EntityId = new EntityId();
					}
					input.ReadMessage(this.EntityId);
				}
			}
		}

		// Token: 0x04003E10 RID: 15888
		private static readonly MessageParser<SubscribeNotificationRequest> _parser = new MessageParser<SubscribeNotificationRequest>(() => new SubscribeNotificationRequest());

		// Token: 0x04003E11 RID: 15889
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E12 RID: 15890
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003E13 RID: 15891
		private EntityId entityId_;
	}
}
