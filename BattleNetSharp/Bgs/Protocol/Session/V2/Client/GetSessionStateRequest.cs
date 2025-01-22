using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000561 RID: 1377
	public sealed class GetSessionStateRequest : IMessage<GetSessionStateRequest>, IMessage, IEquatable<GetSessionStateRequest>, IDeepCloneable<GetSessionStateRequest>, IBufferMessage
	{
		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x060084CE RID: 33998 RVA: 0x002046B4 File Offset: 0x002028B4
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionStateRequest> Parser
		{
			get
			{
				return GetSessionStateRequest._parser;
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x060084CF RID: 33999 RVA: 0x002046CC File Offset: 0x002028CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x060084D0 RID: 34000 RVA: 0x002046F0 File Offset: 0x002028F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionStateRequest.Descriptor;
			}
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x00204707 File Offset: 0x00202907
		[DebuggerNonUserCode]
		public GetSessionStateRequest()
		{
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x00204711 File Offset: 0x00202911
		[DebuggerNonUserCode]
		public GetSessionStateRequest(GetSessionStateRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x0020472C File Offset: 0x0020292C
		[DebuggerNonUserCode]
		public GetSessionStateRequest Clone()
		{
			return new GetSessionStateRequest(this);
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x00204744 File Offset: 0x00202944
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionStateRequest);
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x00204764 File Offset: 0x00202964
		[DebuggerNonUserCode]
		public bool Equals(GetSessionStateRequest other)
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

		// Token: 0x060084D6 RID: 34006 RVA: 0x002047A4 File Offset: 0x002029A4
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

		// Token: 0x060084D7 RID: 34007 RVA: 0x002047D8 File Offset: 0x002029D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084D8 RID: 34008 RVA: 0x002047F0 File Offset: 0x002029F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x002047FC File Offset: 0x002029FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x00204828 File Offset: 0x00202A28
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

		// Token: 0x060084DB RID: 34011 RVA: 0x0020485C File Offset: 0x00202A5C
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x0020488C File Offset: 0x00202A8C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x00204898 File Offset: 0x00202A98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C30 RID: 15408
		private static readonly MessageParser<GetSessionStateRequest> _parser = new MessageParser<GetSessionStateRequest>(() => new GetSessionStateRequest());

		// Token: 0x04003C31 RID: 15409
		private UnknownFieldSet _unknownFields;
	}
}
