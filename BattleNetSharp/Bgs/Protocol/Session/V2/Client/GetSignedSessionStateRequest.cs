using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200055F RID: 1375
	public sealed class GetSignedSessionStateRequest : IMessage<GetSignedSessionStateRequest>, IMessage, IEquatable<GetSignedSessionStateRequest>, IDeepCloneable<GetSignedSessionStateRequest>, IBufferMessage
	{
		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x060084A8 RID: 33960 RVA: 0x0020412C File Offset: 0x0020232C
		[DebuggerNonUserCode]
		public static MessageParser<GetSignedSessionStateRequest> Parser
		{
			get
			{
				return GetSignedSessionStateRequest._parser;
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x060084A9 RID: 33961 RVA: 0x00204144 File Offset: 0x00202344
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x060084AA RID: 33962 RVA: 0x00204168 File Offset: 0x00202368
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSignedSessionStateRequest.Descriptor;
			}
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x0020417F File Offset: 0x0020237F
		[DebuggerNonUserCode]
		public GetSignedSessionStateRequest()
		{
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x00204189 File Offset: 0x00202389
		[DebuggerNonUserCode]
		public GetSignedSessionStateRequest(GetSignedSessionStateRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x002041A4 File Offset: 0x002023A4
		[DebuggerNonUserCode]
		public GetSignedSessionStateRequest Clone()
		{
			return new GetSignedSessionStateRequest(this);
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x002041BC File Offset: 0x002023BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSignedSessionStateRequest);
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x002041DC File Offset: 0x002023DC
		[DebuggerNonUserCode]
		public bool Equals(GetSignedSessionStateRequest other)
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

		// Token: 0x060084B0 RID: 33968 RVA: 0x0020421C File Offset: 0x0020241C
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

		// Token: 0x060084B1 RID: 33969 RVA: 0x00204250 File Offset: 0x00202450
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x00204268 File Offset: 0x00202468
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x00204274 File Offset: 0x00202474
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x002042A0 File Offset: 0x002024A0
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

		// Token: 0x060084B5 RID: 33973 RVA: 0x002042D4 File Offset: 0x002024D4
		[DebuggerNonUserCode]
		public void MergeFrom(GetSignedSessionStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x00204304 File Offset: 0x00202504
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x00204310 File Offset: 0x00202510
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C29 RID: 15401
		private static readonly MessageParser<GetSignedSessionStateRequest> _parser = new MessageParser<GetSignedSessionStateRequest>(() => new GetSignedSessionStateRequest());

		// Token: 0x04003C2A RID: 15402
		private UnknownFieldSet _unknownFields;
	}
}
