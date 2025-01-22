using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000216 RID: 534
	public sealed class ActivateTACTKeysResponse : IMessage<ActivateTACTKeysResponse>, IMessage, IEquatable<ActivateTACTKeysResponse>, IDeepCloneable<ActivateTACTKeysResponse>, IBufferMessage
	{
		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x000E76C8 File Offset: 0x000E58C8
		[DebuggerNonUserCode]
		public static MessageParser<ActivateTACTKeysResponse> Parser
		{
			get
			{
				return ActivateTACTKeysResponse._parser;
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x000E76E0 File Offset: 0x000E58E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x000E7704 File Offset: 0x000E5904
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateTACTKeysResponse.Descriptor;
			}
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x000E771B File Offset: 0x000E591B
		[DebuggerNonUserCode]
		public ActivateTACTKeysResponse()
		{
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x000E7725 File Offset: 0x000E5925
		[DebuggerNonUserCode]
		public ActivateTACTKeysResponse(ActivateTACTKeysResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x000E7740 File Offset: 0x000E5940
		[DebuggerNonUserCode]
		public ActivateTACTKeysResponse Clone()
		{
			return new ActivateTACTKeysResponse(this);
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x000E7758 File Offset: 0x000E5958
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateTACTKeysResponse);
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x000E7778 File Offset: 0x000E5978
		[DebuggerNonUserCode]
		public bool Equals(ActivateTACTKeysResponse other)
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

		// Token: 0x06003A11 RID: 14865 RVA: 0x000E77B8 File Offset: 0x000E59B8
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

		// Token: 0x06003A12 RID: 14866 RVA: 0x000E77EC File Offset: 0x000E59EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x000E7804 File Offset: 0x000E5A04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x000E7810 File Offset: 0x000E5A10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x000E783C File Offset: 0x000E5A3C
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

		// Token: 0x06003A16 RID: 14870 RVA: 0x000E7870 File Offset: 0x000E5A70
		[DebuggerNonUserCode]
		public void MergeFrom(ActivateTACTKeysResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x000E78A0 File Offset: 0x000E5AA0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x000E78AC File Offset: 0x000E5AAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AEF RID: 6895
		private static readonly MessageParser<ActivateTACTKeysResponse> _parser = new MessageParser<ActivateTACTKeysResponse>(() => new ActivateTACTKeysResponse());

		// Token: 0x04001AF0 RID: 6896
		private UnknownFieldSet _unknownFields;
	}
}
