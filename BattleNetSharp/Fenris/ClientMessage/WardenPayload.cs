using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A6 RID: 678
	public sealed class WardenPayload : IMessage<WardenPayload>, IMessage, IEquatable<WardenPayload>, IDeepCloneable<WardenPayload>, IBufferMessage
	{
		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x00110FEC File Offset: 0x0010F1EC
		[DebuggerNonUserCode]
		public static MessageParser<WardenPayload> Parser
		{
			get
			{
				return WardenPayload._parser;
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x00111004 File Offset: 0x0010F204
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[150];
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x0011102C File Offset: 0x0010F22C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WardenPayload.Descriptor;
			}
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00111043 File Offset: 0x0010F243
		[DebuggerNonUserCode]
		public WardenPayload()
		{
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x0011104D File Offset: 0x0010F24D
		[DebuggerNonUserCode]
		public WardenPayload(WardenPayload other)
			: this()
		{
			this.payload_ = other.payload_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00111074 File Offset: 0x0010F274
		[DebuggerNonUserCode]
		public WardenPayload Clone()
		{
			return new WardenPayload(this);
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600479F RID: 18335 RVA: 0x0011108C File Offset: 0x0010F28C
		// (set) Token: 0x060047A0 RID: 18336 RVA: 0x001110AD File Offset: 0x0010F2AD
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			get
			{
				return this.payload_ ?? WardenPayload.PayloadDefaultValue;
			}
			set
			{
				this.payload_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x001110C4 File Offset: 0x0010F2C4
		[DebuggerNonUserCode]
		public bool HasPayload
		{
			get
			{
				return this.payload_ != null;
			}
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x001110E2 File Offset: 0x0010F2E2
		[DebuggerNonUserCode]
		public void ClearPayload()
		{
			this.payload_ = null;
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x001110EC File Offset: 0x0010F2EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WardenPayload);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0011110C File Offset: 0x0010F30C
		[DebuggerNonUserCode]
		public bool Equals(WardenPayload other)
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
					bool flag4 = this.Payload != other.Payload;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x00111164 File Offset: 0x0010F364
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num ^= this.Payload.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x001111B0 File Offset: 0x0010F3B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x001111C8 File Offset: 0x0010F3C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x001111D4 File Offset: 0x0010F3D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x00111220 File Offset: 0x0010F420
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPayload = this.HasPayload;
			if (hasPayload)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Payload);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00111270 File Offset: 0x0010F470
		[DebuggerNonUserCode]
		public void MergeFrom(WardenPayload other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPayload = other.HasPayload;
				if (hasPayload)
				{
					this.Payload = other.Payload;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x001112B9 File Offset: 0x0010F4B9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x001112C4 File Offset: 0x0010F4C4
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
					this.Payload = input.ReadBytes();
				}
			}
		}

		// Token: 0x04001FB1 RID: 8113
		private static readonly MessageParser<WardenPayload> _parser = new MessageParser<WardenPayload>(() => new WardenPayload());

		// Token: 0x04001FB2 RID: 8114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB3 RID: 8115
		public const int PayloadFieldNumber = 1;

		// Token: 0x04001FB4 RID: 8116
		private static readonly ByteString PayloadDefaultValue = ByteString.Empty;

		// Token: 0x04001FB5 RID: 8117
		private ByteString payload_;
	}
}
