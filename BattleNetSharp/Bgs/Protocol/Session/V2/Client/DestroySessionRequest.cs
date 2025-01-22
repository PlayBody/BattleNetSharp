using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200055E RID: 1374
	public sealed class DestroySessionRequest : IMessage<DestroySessionRequest>, IMessage, IEquatable<DestroySessionRequest>, IDeepCloneable<DestroySessionRequest>, IBufferMessage
	{
		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x06008497 RID: 33943 RVA: 0x00203EF0 File Offset: 0x002020F0
		[DebuggerNonUserCode]
		public static MessageParser<DestroySessionRequest> Parser
		{
			get
			{
				return DestroySessionRequest._parser;
			}
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x06008498 RID: 33944 RVA: 0x00203F08 File Offset: 0x00202108
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x06008499 RID: 33945 RVA: 0x00203F2C File Offset: 0x0020212C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroySessionRequest.Descriptor;
			}
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x00203F43 File Offset: 0x00202143
		[DebuggerNonUserCode]
		public DestroySessionRequest()
		{
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x00203F4D File Offset: 0x0020214D
		[DebuggerNonUserCode]
		public DestroySessionRequest(DestroySessionRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x00203F68 File Offset: 0x00202168
		[DebuggerNonUserCode]
		public DestroySessionRequest Clone()
		{
			return new DestroySessionRequest(this);
		}

		// Token: 0x0600849D RID: 33949 RVA: 0x00203F80 File Offset: 0x00202180
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroySessionRequest);
		}

		// Token: 0x0600849E RID: 33950 RVA: 0x00203FA0 File Offset: 0x002021A0
		[DebuggerNonUserCode]
		public bool Equals(DestroySessionRequest other)
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

		// Token: 0x0600849F RID: 33951 RVA: 0x00203FE0 File Offset: 0x002021E0
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

		// Token: 0x060084A0 RID: 33952 RVA: 0x00204014 File Offset: 0x00202214
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084A1 RID: 33953 RVA: 0x0020402C File Offset: 0x0020222C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x00204038 File Offset: 0x00202238
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x00204064 File Offset: 0x00202264
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

		// Token: 0x060084A4 RID: 33956 RVA: 0x00204098 File Offset: 0x00202298
		[DebuggerNonUserCode]
		public void MergeFrom(DestroySessionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060084A5 RID: 33957 RVA: 0x002040C8 File Offset: 0x002022C8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084A6 RID: 33958 RVA: 0x002040D4 File Offset: 0x002022D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C27 RID: 15399
		private static readonly MessageParser<DestroySessionRequest> _parser = new MessageParser<DestroySessionRequest>(() => new DestroySessionRequest());

		// Token: 0x04003C28 RID: 15400
		private UnknownFieldSet _unknownFields;
	}
}
