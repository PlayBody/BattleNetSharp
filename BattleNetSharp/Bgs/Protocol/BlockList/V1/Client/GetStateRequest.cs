using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000700 RID: 1792
	public sealed class GetStateRequest : IMessage<GetStateRequest>, IMessage, IEquatable<GetStateRequest>, IDeepCloneable<GetStateRequest>, IBufferMessage
	{
		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600A4BA RID: 42170 RVA: 0x0028205C File Offset: 0x0028025C
		[DebuggerNonUserCode]
		public static MessageParser<GetStateRequest> Parser
		{
			get
			{
				return GetStateRequest._parser;
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x00282074 File Offset: 0x00280274
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600A4BC RID: 42172 RVA: 0x00282098 File Offset: 0x00280298
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateRequest.Descriptor;
			}
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x002820AF File Offset: 0x002802AF
		[DebuggerNonUserCode]
		public GetStateRequest()
		{
		}

		// Token: 0x0600A4BE RID: 42174 RVA: 0x002820B9 File Offset: 0x002802B9
		[DebuggerNonUserCode]
		public GetStateRequest(GetStateRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4BF RID: 42175 RVA: 0x002820D4 File Offset: 0x002802D4
		[DebuggerNonUserCode]
		public GetStateRequest Clone()
		{
			return new GetStateRequest(this);
		}

		// Token: 0x0600A4C0 RID: 42176 RVA: 0x002820EC File Offset: 0x002802EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateRequest);
		}

		// Token: 0x0600A4C1 RID: 42177 RVA: 0x0028210C File Offset: 0x0028030C
		[DebuggerNonUserCode]
		public bool Equals(GetStateRequest other)
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

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x0028214C File Offset: 0x0028034C
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

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x00282180 File Offset: 0x00280380
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x00282198 File Offset: 0x00280398
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x002821A4 File Offset: 0x002803A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x002821D0 File Offset: 0x002803D0
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

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x00282204 File Offset: 0x00280404
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x00282234 File Offset: 0x00280434
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x00282240 File Offset: 0x00280440
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A2D RID: 18989
		private static readonly MessageParser<GetStateRequest> _parser = new MessageParser<GetStateRequest>(() => new GetStateRequest());

		// Token: 0x04004A2E RID: 18990
		private UnknownFieldSet _unknownFields;
	}
}
