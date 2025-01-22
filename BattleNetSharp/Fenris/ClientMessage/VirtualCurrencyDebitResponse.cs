using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200021C RID: 540
	public sealed class VirtualCurrencyDebitResponse : IMessage<VirtualCurrencyDebitResponse>, IMessage, IEquatable<VirtualCurrencyDebitResponse>, IDeepCloneable<VirtualCurrencyDebitResponse>, IBufferMessage
	{
		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06003A87 RID: 14983 RVA: 0x000E8B28 File Offset: 0x000E6D28
		[DebuggerNonUserCode]
		public static MessageParser<VirtualCurrencyDebitResponse> Parser
		{
			get
			{
				return VirtualCurrencyDebitResponse._parser;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x000E8B40 File Offset: 0x000E6D40
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x000E8B64 File Offset: 0x000E6D64
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VirtualCurrencyDebitResponse.Descriptor;
			}
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x000E8B7B File Offset: 0x000E6D7B
		[DebuggerNonUserCode]
		public VirtualCurrencyDebitResponse()
		{
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x000E8B85 File Offset: 0x000E6D85
		[DebuggerNonUserCode]
		public VirtualCurrencyDebitResponse(VirtualCurrencyDebitResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x000E8BA0 File Offset: 0x000E6DA0
		[DebuggerNonUserCode]
		public VirtualCurrencyDebitResponse Clone()
		{
			return new VirtualCurrencyDebitResponse(this);
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x000E8BB8 File Offset: 0x000E6DB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VirtualCurrencyDebitResponse);
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x000E8BD8 File Offset: 0x000E6DD8
		[DebuggerNonUserCode]
		public bool Equals(VirtualCurrencyDebitResponse other)
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

		// Token: 0x06003A8F RID: 14991 RVA: 0x000E8C18 File Offset: 0x000E6E18
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

		// Token: 0x06003A90 RID: 14992 RVA: 0x000E8C4C File Offset: 0x000E6E4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x000E8C64 File Offset: 0x000E6E64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x000E8C70 File Offset: 0x000E6E70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x000E8C9C File Offset: 0x000E6E9C
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

		// Token: 0x06003A94 RID: 14996 RVA: 0x000E8CD0 File Offset: 0x000E6ED0
		[DebuggerNonUserCode]
		public void MergeFrom(VirtualCurrencyDebitResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x000E8D00 File Offset: 0x000E6F00
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x000E8D0C File Offset: 0x000E6F0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B0F RID: 6927
		private static readonly MessageParser<VirtualCurrencyDebitResponse> _parser = new MessageParser<VirtualCurrencyDebitResponse>(() => new VirtualCurrencyDebitResponse());

		// Token: 0x04001B10 RID: 6928
		private UnknownFieldSet _unknownFields;
	}
}
