using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004E8 RID: 1256
	public sealed class GetStreamMessageResponse : IMessage<GetStreamMessageResponse>, IMessage, IEquatable<GetStreamMessageResponse>, IDeepCloneable<GetStreamMessageResponse>, IBufferMessage
	{
		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x06007A2A RID: 31274 RVA: 0x001DAD88 File Offset: 0x001D8F88
		[DebuggerNonUserCode]
		public static MessageParser<GetStreamMessageResponse> Parser
		{
			get
			{
				return GetStreamMessageResponse._parser;
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x06007A2B RID: 31275 RVA: 0x001DADA0 File Offset: 0x001D8FA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[77];
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x06007A2C RID: 31276 RVA: 0x001DADC4 File Offset: 0x001D8FC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStreamMessageResponse.Descriptor;
			}
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x001DADDB File Offset: 0x001D8FDB
		[DebuggerNonUserCode]
		public GetStreamMessageResponse()
		{
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x001DADE5 File Offset: 0x001D8FE5
		[DebuggerNonUserCode]
		public GetStreamMessageResponse(GetStreamMessageResponse other)
			: this()
		{
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x001DAE1C File Offset: 0x001D901C
		[DebuggerNonUserCode]
		public GetStreamMessageResponse Clone()
		{
			return new GetStreamMessageResponse(this);
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x06007A30 RID: 31280 RVA: 0x001DAE34 File Offset: 0x001D9034
		// (set) Token: 0x06007A31 RID: 31281 RVA: 0x001DAE4C File Offset: 0x001D904C
		[DebuggerNonUserCode]
		public StreamMessage Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x001DAE58 File Offset: 0x001D9058
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStreamMessageResponse);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x001DAE78 File Offset: 0x001D9078
		[DebuggerNonUserCode]
		public bool Equals(GetStreamMessageResponse other)
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
					bool flag4 = !object.Equals(this.Message, other.Message);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x001DAED4 File Offset: 0x001D90D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.message_ != null;
			if (flag)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x001DAF24 File Offset: 0x001D9124
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x001DAF3C File Offset: 0x001D913C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x001DAF48 File Offset: 0x001D9148
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.message_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Message);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x001DAF98 File Offset: 0x001D9198
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.message_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x001DAFEC File Offset: 0x001D91EC
		[DebuggerNonUserCode]
		public void MergeFrom(GetStreamMessageResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.message_ != null;
				if (flag2)
				{
					bool flag3 = this.message_ == null;
					if (flag3)
					{
						this.Message = new StreamMessage();
					}
					this.Message.MergeFrom(other.Message);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x001DB058 File Offset: 0x001D9258
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x001DB064 File Offset: 0x001D9264
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
					bool flag = this.message_ == null;
					if (flag)
					{
						this.Message = new StreamMessage();
					}
					input.ReadMessage(this.Message);
				}
			}
		}

		// Token: 0x04003763 RID: 14179
		private static readonly MessageParser<GetStreamMessageResponse> _parser = new MessageParser<GetStreamMessageResponse>(() => new GetStreamMessageResponse());

		// Token: 0x04003764 RID: 14180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003765 RID: 14181
		public const int MessageFieldNumber = 1;

		// Token: 0x04003766 RID: 14182
		private StreamMessage message_;
	}
}
