using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200071E RID: 1822
	public sealed class GetGameSessionInfoRequest : IMessage<GetGameSessionInfoRequest>, IMessage, IEquatable<GetGameSessionInfoRequest>, IDeepCloneable<GetGameSessionInfoRequest>, IBufferMessage
	{
		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600A6FD RID: 42749 RVA: 0x0028A278 File Offset: 0x00288478
		[DebuggerNonUserCode]
		public static MessageParser<GetGameSessionInfoRequest> Parser
		{
			get
			{
				return GetGameSessionInfoRequest._parser;
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600A6FE RID: 42750 RVA: 0x0028A290 File Offset: 0x00288490
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600A6FF RID: 42751 RVA: 0x0028A2B4 File Offset: 0x002884B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameSessionInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x0028A2CB File Offset: 0x002884CB
		[DebuggerNonUserCode]
		public GetGameSessionInfoRequest()
		{
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x0028A2D5 File Offset: 0x002884D5
		[DebuggerNonUserCode]
		public GetGameSessionInfoRequest(GetGameSessionInfoRequest other)
			: this()
		{
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A702 RID: 42754 RVA: 0x0028A30C File Offset: 0x0028850C
		[DebuggerNonUserCode]
		public GetGameSessionInfoRequest Clone()
		{
			return new GetGameSessionInfoRequest(this);
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600A703 RID: 42755 RVA: 0x0028A324 File Offset: 0x00288524
		// (set) Token: 0x0600A704 RID: 42756 RVA: 0x0028A33C File Offset: 0x0028853C
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

		// Token: 0x0600A705 RID: 42757 RVA: 0x0028A348 File Offset: 0x00288548
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameSessionInfoRequest);
		}

		// Token: 0x0600A706 RID: 42758 RVA: 0x0028A368 File Offset: 0x00288568
		[DebuggerNonUserCode]
		public bool Equals(GetGameSessionInfoRequest other)
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

		// Token: 0x0600A707 RID: 42759 RVA: 0x0028A3C4 File Offset: 0x002885C4
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

		// Token: 0x0600A708 RID: 42760 RVA: 0x0028A414 File Offset: 0x00288614
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A709 RID: 42761 RVA: 0x0028A42C File Offset: 0x0028862C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x0028A438 File Offset: 0x00288638
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

		// Token: 0x0600A70B RID: 42763 RVA: 0x0028A488 File Offset: 0x00288688
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

		// Token: 0x0600A70C RID: 42764 RVA: 0x0028A4DC File Offset: 0x002886DC
		[DebuggerNonUserCode]
		public void MergeFrom(GetGameSessionInfoRequest other)
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

		// Token: 0x0600A70D RID: 42765 RVA: 0x0028A548 File Offset: 0x00288748
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A70E RID: 42766 RVA: 0x0028A554 File Offset: 0x00288754
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

		// Token: 0x04004AF9 RID: 19193
		private static readonly MessageParser<GetGameSessionInfoRequest> _parser = new MessageParser<GetGameSessionInfoRequest>(() => new GetGameSessionInfoRequest());

		// Token: 0x04004AFA RID: 19194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AFB RID: 19195
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004AFC RID: 19196
		private EntityId entityId_;
	}
}
