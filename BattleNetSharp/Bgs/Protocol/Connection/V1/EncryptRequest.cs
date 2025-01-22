using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x02000436 RID: 1078
	public sealed class EncryptRequest : IMessage<EncryptRequest>, IMessage, IEquatable<EncryptRequest>, IDeepCloneable<EncryptRequest>, IBufferMessage
	{
		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x060069FB RID: 27131 RVA: 0x0019A0B8 File Offset: 0x001982B8
		[DebuggerNonUserCode]
		public static MessageParser<EncryptRequest> Parser
		{
			get
			{
				return EncryptRequest._parser;
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x060069FC RID: 27132 RVA: 0x0019A0D0 File Offset: 0x001982D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x060069FD RID: 27133 RVA: 0x0019A0F4 File Offset: 0x001982F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncryptRequest.Descriptor;
			}
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x0019A10B File Offset: 0x0019830B
		[DebuggerNonUserCode]
		public EncryptRequest()
		{
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x0019A115 File Offset: 0x00198315
		[DebuggerNonUserCode]
		public EncryptRequest(EncryptRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x0019A130 File Offset: 0x00198330
		[DebuggerNonUserCode]
		public EncryptRequest Clone()
		{
			return new EncryptRequest(this);
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x0019A148 File Offset: 0x00198348
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncryptRequest);
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x0019A168 File Offset: 0x00198368
		[DebuggerNonUserCode]
		public bool Equals(EncryptRequest other)
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
				flag2 = flag3 || object.Equals(this._unknownFields, other._unknownFields);
			}
			return flag2;
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0019A1A8 File Offset: 0x001983A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0019A1DC File Offset: 0x001983DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x0019A1F4 File Offset: 0x001983F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x0019A200 File Offset: 0x00198400
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x0019A22C File Offset: 0x0019842C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x0019A260 File Offset: 0x00198460
		[DebuggerNonUserCode]
		public void MergeFrom(EncryptRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x0019A290 File Offset: 0x00198490
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x0019A29C File Offset: 0x0019849C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003038 RID: 12344
		private static readonly MessageParser<EncryptRequest> _parser = new MessageParser<EncryptRequest>(() => new EncryptRequest());

		// Token: 0x04003039 RID: 12345
		private UnknownFieldSet _unknownFields;
	}
}
