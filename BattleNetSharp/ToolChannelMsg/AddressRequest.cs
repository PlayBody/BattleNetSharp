using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200002D RID: 45
	public sealed class AddressRequest : IMessage<AddressRequest>, IMessage, IEquatable<AddressRequest>, IDeepCloneable<AddressRequest>, IBufferMessage
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0001055C File Offset: 0x0000E75C
		[DebuggerNonUserCode]
		public static MessageParser<AddressRequest> Parser
		{
			get
			{
				return AddressRequest._parser;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00010574 File Offset: 0x0000E774
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00010598 File Offset: 0x0000E798
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddressRequest.Descriptor;
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000105AF File Offset: 0x0000E7AF
		[DebuggerNonUserCode]
		public AddressRequest()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000105B9 File Offset: 0x0000E7B9
		[DebuggerNonUserCode]
		public AddressRequest(AddressRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000105D4 File Offset: 0x0000E7D4
		[DebuggerNonUserCode]
		public AddressRequest Clone()
		{
			return new AddressRequest(this);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000105EC File Offset: 0x0000E7EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddressRequest);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001060C File Offset: 0x0000E80C
		[DebuggerNonUserCode]
		public bool Equals(AddressRequest other)
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

		// Token: 0x060002DC RID: 732 RVA: 0x0001064C File Offset: 0x0000E84C
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

		// Token: 0x060002DD RID: 733 RVA: 0x00010680 File Offset: 0x0000E880
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00010698 File Offset: 0x0000E898
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000106A4 File Offset: 0x0000E8A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000106D0 File Offset: 0x0000E8D0
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

		// Token: 0x060002E1 RID: 737 RVA: 0x00010704 File Offset: 0x0000E904
		[DebuggerNonUserCode]
		public void MergeFrom(AddressRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00010734 File Offset: 0x0000E934
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00010740 File Offset: 0x0000E940
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000129 RID: 297
		private static readonly MessageParser<AddressRequest> _parser = new MessageParser<AddressRequest>(() => new AddressRequest());

		// Token: 0x0400012A RID: 298
		private UnknownFieldSet _unknownFields;
	}
}
