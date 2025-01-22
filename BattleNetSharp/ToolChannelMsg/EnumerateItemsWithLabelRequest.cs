using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000054 RID: 84
	public sealed class EnumerateItemsWithLabelRequest : IMessage<EnumerateItemsWithLabelRequest>, IMessage, IEquatable<EnumerateItemsWithLabelRequest>, IDeepCloneable<EnumerateItemsWithLabelRequest>, IBufferMessage
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001E874 File Offset: 0x0001CA74
		[DebuggerNonUserCode]
		public static MessageParser<EnumerateItemsWithLabelRequest> Parser
		{
			get
			{
				return EnumerateItemsWithLabelRequest._parser;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0001E88C File Offset: 0x0001CA8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[61];
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0001E8B0 File Offset: 0x0001CAB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumerateItemsWithLabelRequest.Descriptor;
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001E8C7 File Offset: 0x0001CAC7
		[DebuggerNonUserCode]
		public EnumerateItemsWithLabelRequest()
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001E8D1 File Offset: 0x0001CAD1
		[DebuggerNonUserCode]
		public EnumerateItemsWithLabelRequest(EnumerateItemsWithLabelRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001E8EC File Offset: 0x0001CAEC
		[DebuggerNonUserCode]
		public EnumerateItemsWithLabelRequest Clone()
		{
			return new EnumerateItemsWithLabelRequest(this);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0001E904 File Offset: 0x0001CB04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnumerateItemsWithLabelRequest);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001E924 File Offset: 0x0001CB24
		[DebuggerNonUserCode]
		public bool Equals(EnumerateItemsWithLabelRequest other)
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

		// Token: 0x0600071A RID: 1818 RVA: 0x0001E964 File Offset: 0x0001CB64
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

		// Token: 0x0600071B RID: 1819 RVA: 0x0001E998 File Offset: 0x0001CB98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001E9BC File Offset: 0x0001CBBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
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

		// Token: 0x0600071F RID: 1823 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		[DebuggerNonUserCode]
		public void MergeFrom(EnumerateItemsWithLabelRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0001EA4C File Offset: 0x0001CC4C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001EA58 File Offset: 0x0001CC58
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040002EC RID: 748
		private static readonly MessageParser<EnumerateItemsWithLabelRequest> _parser = new MessageParser<EnumerateItemsWithLabelRequest>(() => new EnumerateItemsWithLabelRequest());

		// Token: 0x040002ED RID: 749
		private UnknownFieldSet _unknownFields;
	}
}
