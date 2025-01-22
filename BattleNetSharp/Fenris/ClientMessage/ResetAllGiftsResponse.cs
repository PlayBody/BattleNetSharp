using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000218 RID: 536
	public sealed class ResetAllGiftsResponse : IMessage<ResetAllGiftsResponse>, IMessage, IEquatable<ResetAllGiftsResponse>, IDeepCloneable<ResetAllGiftsResponse>, IBufferMessage
	{
		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x000E7B40 File Offset: 0x000E5D40
		[DebuggerNonUserCode]
		public static MessageParser<ResetAllGiftsResponse> Parser
		{
			get
			{
				return ResetAllGiftsResponse._parser;
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x000E7B58 File Offset: 0x000E5D58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x000E7B7C File Offset: 0x000E5D7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetAllGiftsResponse.Descriptor;
			}
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x000E7B93 File Offset: 0x000E5D93
		[DebuggerNonUserCode]
		public ResetAllGiftsResponse()
		{
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x000E7B9D File Offset: 0x000E5D9D
		[DebuggerNonUserCode]
		public ResetAllGiftsResponse(ResetAllGiftsResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x000E7BB8 File Offset: 0x000E5DB8
		[DebuggerNonUserCode]
		public ResetAllGiftsResponse Clone()
		{
			return new ResetAllGiftsResponse(this);
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x000E7BD0 File Offset: 0x000E5DD0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetAllGiftsResponse);
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x000E7BF0 File Offset: 0x000E5DF0
		[DebuggerNonUserCode]
		public bool Equals(ResetAllGiftsResponse other)
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

		// Token: 0x06003A33 RID: 14899 RVA: 0x000E7C30 File Offset: 0x000E5E30
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

		// Token: 0x06003A34 RID: 14900 RVA: 0x000E7C64 File Offset: 0x000E5E64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x000E7C7C File Offset: 0x000E5E7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x000E7C88 File Offset: 0x000E5E88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x000E7CB4 File Offset: 0x000E5EB4
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

		// Token: 0x06003A38 RID: 14904 RVA: 0x000E7CE8 File Offset: 0x000E5EE8
		[DebuggerNonUserCode]
		public void MergeFrom(ResetAllGiftsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x000E7D18 File Offset: 0x000E5F18
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x000E7D24 File Offset: 0x000E5F24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AF3 RID: 6899
		private static readonly MessageParser<ResetAllGiftsResponse> _parser = new MessageParser<ResetAllGiftsResponse>(() => new ResetAllGiftsResponse());

		// Token: 0x04001AF4 RID: 6900
		private UnknownFieldSet _unknownFields;
	}
}
