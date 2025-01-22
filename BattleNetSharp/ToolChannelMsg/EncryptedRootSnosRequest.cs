using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000FC RID: 252
	public sealed class EncryptedRootSnosRequest : IMessage<EncryptedRootSnosRequest>, IMessage, IEquatable<EncryptedRootSnosRequest>, IDeepCloneable<EncryptedRootSnosRequest>, IBufferMessage
	{
		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x000569FC File Offset: 0x00054BFC
		[DebuggerNonUserCode]
		public static MessageParser<EncryptedRootSnosRequest> Parser
		{
			get
			{
				return EncryptedRootSnosRequest._parser;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00056A14 File Offset: 0x00054C14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[229];
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x00056A3C File Offset: 0x00054C3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncryptedRootSnosRequest.Descriptor;
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00056A53 File Offset: 0x00054C53
		[DebuggerNonUserCode]
		public EncryptedRootSnosRequest()
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00056A5D File Offset: 0x00054C5D
		[DebuggerNonUserCode]
		public EncryptedRootSnosRequest(EncryptedRootSnosRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00056A78 File Offset: 0x00054C78
		[DebuggerNonUserCode]
		public EncryptedRootSnosRequest Clone()
		{
			return new EncryptedRootSnosRequest(this);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00056A90 File Offset: 0x00054C90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncryptedRootSnosRequest);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00056AB0 File Offset: 0x00054CB0
		[DebuggerNonUserCode]
		public bool Equals(EncryptedRootSnosRequest other)
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

		// Token: 0x0600183A RID: 6202 RVA: 0x00056AF0 File Offset: 0x00054CF0
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

		// Token: 0x0600183B RID: 6203 RVA: 0x00056B24 File Offset: 0x00054D24
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00056B3C File Offset: 0x00054D3C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00056B48 File Offset: 0x00054D48
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00056B74 File Offset: 0x00054D74
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

		// Token: 0x0600183F RID: 6207 RVA: 0x00056BA8 File Offset: 0x00054DA8
		[DebuggerNonUserCode]
		public void MergeFrom(EncryptedRootSnosRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00056BD8 File Offset: 0x00054DD8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00056BE4 File Offset: 0x00054DE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040009B2 RID: 2482
		private static readonly MessageParser<EncryptedRootSnosRequest> _parser = new MessageParser<EncryptedRootSnosRequest>(() => new EncryptedRootSnosRequest());

		// Token: 0x040009B3 RID: 2483
		private UnknownFieldSet _unknownFields;
	}
}
