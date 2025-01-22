using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000210 RID: 528
	public sealed class GenericMessage : IMessage<GenericMessage>, IMessage, IEquatable<GenericMessage>, IDeepCloneable<GenericMessage>, IBufferMessage
	{
		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x000E6500 File Offset: 0x000E4700
		[DebuggerNonUserCode]
		public static MessageParser<GenericMessage> Parser
		{
			get
			{
				return GenericMessage._parser;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x000E6518 File Offset: 0x000E4718
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600399A RID: 14746 RVA: 0x000E653C File Offset: 0x000E473C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenericMessage.Descriptor;
			}
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x000E6553 File Offset: 0x000E4753
		[DebuggerNonUserCode]
		public GenericMessage()
		{
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x000E655D File Offset: 0x000E475D
		[DebuggerNonUserCode]
		public GenericMessage(GenericMessage other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x000E6578 File Offset: 0x000E4778
		[DebuggerNonUserCode]
		public GenericMessage Clone()
		{
			return new GenericMessage(this);
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x000E6590 File Offset: 0x000E4790
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenericMessage);
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x000E65B0 File Offset: 0x000E47B0
		[DebuggerNonUserCode]
		public bool Equals(GenericMessage other)
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

		// Token: 0x060039A0 RID: 14752 RVA: 0x000E65F0 File Offset: 0x000E47F0
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

		// Token: 0x060039A1 RID: 14753 RVA: 0x000E6624 File Offset: 0x000E4824
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x000E663C File Offset: 0x000E483C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x000E6648 File Offset: 0x000E4848
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x000E6674 File Offset: 0x000E4874
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

		// Token: 0x060039A5 RID: 14757 RVA: 0x000E66A8 File Offset: 0x000E48A8
		[DebuggerNonUserCode]
		public void MergeFrom(GenericMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x000E66D8 File Offset: 0x000E48D8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x000E66E4 File Offset: 0x000E48E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AD6 RID: 6870
		private static readonly MessageParser<GenericMessage> _parser = new MessageParser<GenericMessage>(() => new GenericMessage());

		// Token: 0x04001AD7 RID: 6871
		private UnknownFieldSet _unknownFields;
	}
}
