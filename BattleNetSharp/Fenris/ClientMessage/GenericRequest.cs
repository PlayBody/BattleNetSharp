using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000211 RID: 529
	public sealed class GenericRequest : IMessage<GenericRequest>, IMessage, IEquatable<GenericRequest>, IDeepCloneable<GenericRequest>, IBufferMessage
	{
		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x060039A9 RID: 14761 RVA: 0x000E673C File Offset: 0x000E493C
		[DebuggerNonUserCode]
		public static MessageParser<GenericRequest> Parser
		{
			get
			{
				return GenericRequest._parser;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060039AA RID: 14762 RVA: 0x000E6754 File Offset: 0x000E4954
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x000E6778 File Offset: 0x000E4978
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenericRequest.Descriptor;
			}
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x000E678F File Offset: 0x000E498F
		[DebuggerNonUserCode]
		public GenericRequest()
		{
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x000E6799 File Offset: 0x000E4999
		[DebuggerNonUserCode]
		public GenericRequest(GenericRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x000E67B4 File Offset: 0x000E49B4
		[DebuggerNonUserCode]
		public GenericRequest Clone()
		{
			return new GenericRequest(this);
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x000E67CC File Offset: 0x000E49CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenericRequest);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x000E67EC File Offset: 0x000E49EC
		[DebuggerNonUserCode]
		public bool Equals(GenericRequest other)
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

		// Token: 0x060039B1 RID: 14769 RVA: 0x000E682C File Offset: 0x000E4A2C
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

		// Token: 0x060039B2 RID: 14770 RVA: 0x000E6860 File Offset: 0x000E4A60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x000E6878 File Offset: 0x000E4A78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x000E6884 File Offset: 0x000E4A84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x000E68B0 File Offset: 0x000E4AB0
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

		// Token: 0x060039B6 RID: 14774 RVA: 0x000E68E4 File Offset: 0x000E4AE4
		[DebuggerNonUserCode]
		public void MergeFrom(GenericRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x000E6914 File Offset: 0x000E4B14
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x000E6920 File Offset: 0x000E4B20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AD8 RID: 6872
		private static readonly MessageParser<GenericRequest> _parser = new MessageParser<GenericRequest>(() => new GenericRequest());

		// Token: 0x04001AD9 RID: 6873
		private UnknownFieldSet _unknownFields;
	}
}
