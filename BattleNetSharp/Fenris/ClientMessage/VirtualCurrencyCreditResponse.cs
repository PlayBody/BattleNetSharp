using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200021A RID: 538
	public sealed class VirtualCurrencyCreditResponse : IMessage<VirtualCurrencyCreditResponse>, IMessage, IEquatable<VirtualCurrencyCreditResponse>, IDeepCloneable<VirtualCurrencyCreditResponse>, IBufferMessage
	{
		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x000E8334 File Offset: 0x000E6534
		[DebuggerNonUserCode]
		public static MessageParser<VirtualCurrencyCreditResponse> Parser
		{
			get
			{
				return VirtualCurrencyCreditResponse._parser;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x000E834C File Offset: 0x000E654C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x000E8370 File Offset: 0x000E6570
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VirtualCurrencyCreditResponse.Descriptor;
			}
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x000E8387 File Offset: 0x000E6587
		[DebuggerNonUserCode]
		public VirtualCurrencyCreditResponse()
		{
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x000E8391 File Offset: 0x000E6591
		[DebuggerNonUserCode]
		public VirtualCurrencyCreditResponse(VirtualCurrencyCreditResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x000E83AC File Offset: 0x000E65AC
		[DebuggerNonUserCode]
		public VirtualCurrencyCreditResponse Clone()
		{
			return new VirtualCurrencyCreditResponse(this);
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x000E83C4 File Offset: 0x000E65C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VirtualCurrencyCreditResponse);
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x000E83E4 File Offset: 0x000E65E4
		[DebuggerNonUserCode]
		public bool Equals(VirtualCurrencyCreditResponse other)
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

		// Token: 0x06003A61 RID: 14945 RVA: 0x000E8424 File Offset: 0x000E6624
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

		// Token: 0x06003A62 RID: 14946 RVA: 0x000E8458 File Offset: 0x000E6658
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x000E8470 File Offset: 0x000E6670
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x000E847C File Offset: 0x000E667C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x000E84A8 File Offset: 0x000E66A8
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

		// Token: 0x06003A66 RID: 14950 RVA: 0x000E84DC File Offset: 0x000E66DC
		[DebuggerNonUserCode]
		public void MergeFrom(VirtualCurrencyCreditResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x000E850C File Offset: 0x000E670C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x000E8518 File Offset: 0x000E6718
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B01 RID: 6913
		private static readonly MessageParser<VirtualCurrencyCreditResponse> _parser = new MessageParser<VirtualCurrencyCreditResponse>(() => new VirtualCurrencyCreditResponse());

		// Token: 0x04001B02 RID: 6914
		private UnknownFieldSet _unknownFields;
	}
}
