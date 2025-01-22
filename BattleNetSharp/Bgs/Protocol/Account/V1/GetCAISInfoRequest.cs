using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000722 RID: 1826
	public sealed class GetCAISInfoRequest : IMessage<GetCAISInfoRequest>, IMessage, IEquatable<GetCAISInfoRequest>, IDeepCloneable<GetCAISInfoRequest>, IBufferMessage
	{
		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600A74F RID: 42831 RVA: 0x0028B278 File Offset: 0x00289478
		[DebuggerNonUserCode]
		public static MessageParser<GetCAISInfoRequest> Parser
		{
			get
			{
				return GetCAISInfoRequest._parser;
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600A750 RID: 42832 RVA: 0x0028B290 File Offset: 0x00289490
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x0028B2B4 File Offset: 0x002894B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCAISInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A752 RID: 42834 RVA: 0x0028B2CB File Offset: 0x002894CB
		[DebuggerNonUserCode]
		public GetCAISInfoRequest()
		{
		}

		// Token: 0x0600A753 RID: 42835 RVA: 0x0028B2D5 File Offset: 0x002894D5
		[DebuggerNonUserCode]
		public GetCAISInfoRequest(GetCAISInfoRequest other)
			: this()
		{
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A754 RID: 42836 RVA: 0x0028B30C File Offset: 0x0028950C
		[DebuggerNonUserCode]
		public GetCAISInfoRequest Clone()
		{
			return new GetCAISInfoRequest(this);
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600A755 RID: 42837 RVA: 0x0028B324 File Offset: 0x00289524
		// (set) Token: 0x0600A756 RID: 42838 RVA: 0x0028B33C File Offset: 0x0028953C
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

		// Token: 0x0600A757 RID: 42839 RVA: 0x0028B348 File Offset: 0x00289548
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCAISInfoRequest);
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x0028B368 File Offset: 0x00289568
		[DebuggerNonUserCode]
		public bool Equals(GetCAISInfoRequest other)
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

		// Token: 0x0600A759 RID: 42841 RVA: 0x0028B3C4 File Offset: 0x002895C4
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

		// Token: 0x0600A75A RID: 42842 RVA: 0x0028B414 File Offset: 0x00289614
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x0028B42C File Offset: 0x0028962C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x0028B438 File Offset: 0x00289638
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

		// Token: 0x0600A75D RID: 42845 RVA: 0x0028B488 File Offset: 0x00289688
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

		// Token: 0x0600A75E RID: 42846 RVA: 0x0028B4DC File Offset: 0x002896DC
		[DebuggerNonUserCode]
		public void MergeFrom(GetCAISInfoRequest other)
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

		// Token: 0x0600A75F RID: 42847 RVA: 0x0028B548 File Offset: 0x00289748
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x0028B554 File Offset: 0x00289754
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

		// Token: 0x04004B0E RID: 19214
		private static readonly MessageParser<GetCAISInfoRequest> _parser = new MessageParser<GetCAISInfoRequest>(() => new GetCAISInfoRequest());

		// Token: 0x04004B0F RID: 19215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B10 RID: 19216
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004B11 RID: 19217
		private EntityId entityId_;
	}
}
