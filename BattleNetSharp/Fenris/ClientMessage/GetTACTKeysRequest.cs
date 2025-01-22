using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000213 RID: 531
	public sealed class GetTACTKeysRequest : IMessage<GetTACTKeysRequest>, IMessage, IEquatable<GetTACTKeysRequest>, IDeepCloneable<GetTACTKeysRequest>, IBufferMessage
	{
		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x000E6CEC File Offset: 0x000E4EEC
		[DebuggerNonUserCode]
		public static MessageParser<GetTACTKeysRequest> Parser
		{
			get
			{
				return GetTACTKeysRequest._parser;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x000E6D04 File Offset: 0x000E4F04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x000E6D28 File Offset: 0x000E4F28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTACTKeysRequest.Descriptor;
			}
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x000E6D3F File Offset: 0x000E4F3F
		[DebuggerNonUserCode]
		public GetTACTKeysRequest()
		{
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x000E6D49 File Offset: 0x000E4F49
		[DebuggerNonUserCode]
		public GetTACTKeysRequest(GetTACTKeysRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x000E6D64 File Offset: 0x000E4F64
		[DebuggerNonUserCode]
		public GetTACTKeysRequest Clone()
		{
			return new GetTACTKeysRequest(this);
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x000E6D7C File Offset: 0x000E4F7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTACTKeysRequest);
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x000E6D9C File Offset: 0x000E4F9C
		[DebuggerNonUserCode]
		public bool Equals(GetTACTKeysRequest other)
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

		// Token: 0x060039D7 RID: 14807 RVA: 0x000E6DDC File Offset: 0x000E4FDC
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

		// Token: 0x060039D8 RID: 14808 RVA: 0x000E6E10 File Offset: 0x000E5010
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x000E6E28 File Offset: 0x000E5028
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x000E6E34 File Offset: 0x000E5034
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x000E6E60 File Offset: 0x000E5060
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

		// Token: 0x060039DC RID: 14812 RVA: 0x000E6E94 File Offset: 0x000E5094
		[DebuggerNonUserCode]
		public void MergeFrom(GetTACTKeysRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x000E6EC4 File Offset: 0x000E50C4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x000E6ED0 File Offset: 0x000E50D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AE0 RID: 6880
		private static readonly MessageParser<GetTACTKeysRequest> _parser = new MessageParser<GetTACTKeysRequest>(() => new GetTACTKeysRequest());

		// Token: 0x04001AE1 RID: 6881
		private UnknownFieldSet _unknownFields;
	}
}
