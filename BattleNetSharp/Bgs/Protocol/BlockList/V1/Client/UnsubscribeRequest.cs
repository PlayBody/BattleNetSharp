using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006FF RID: 1791
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x00281E20 File Offset: 0x00280020
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600A4AA RID: 42154 RVA: 0x00281E38 File Offset: 0x00280038
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600A4AB RID: 42155 RVA: 0x00281E5C File Offset: 0x0028005C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x00281E73 File Offset: 0x00280073
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x00281E7D File Offset: 0x0028007D
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x00281E98 File Offset: 0x00280098
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x00281EB0 File Offset: 0x002800B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x00281ED0 File Offset: 0x002800D0
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeRequest other)
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

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x00281F10 File Offset: 0x00280110
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

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x00281F44 File Offset: 0x00280144
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x00281F5C File Offset: 0x0028015C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x00281F68 File Offset: 0x00280168
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x00281F94 File Offset: 0x00280194
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

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x00281FC8 File Offset: 0x002801C8
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x00281FF8 File Offset: 0x002801F8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x00282004 File Offset: 0x00280204
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A2B RID: 18987
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x04004A2C RID: 18988
		private UnknownFieldSet _unknownFields;
	}
}
