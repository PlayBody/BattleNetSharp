using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000563 RID: 1379
	public sealed class MarkSessionAliveRequest : IMessage<MarkSessionAliveRequest>, IMessage, IEquatable<MarkSessionAliveRequest>, IDeepCloneable<MarkSessionAliveRequest>, IBufferMessage
	{
		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x060084F2 RID: 34034 RVA: 0x00204C58 File Offset: 0x00202E58
		[DebuggerNonUserCode]
		public static MessageParser<MarkSessionAliveRequest> Parser
		{
			get
			{
				return MarkSessionAliveRequest._parser;
			}
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x060084F3 RID: 34035 RVA: 0x00204C70 File Offset: 0x00202E70
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x060084F4 RID: 34036 RVA: 0x00204C94 File Offset: 0x00202E94
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkSessionAliveRequest.Descriptor;
			}
		}

		// Token: 0x060084F5 RID: 34037 RVA: 0x00204CAB File Offset: 0x00202EAB
		[DebuggerNonUserCode]
		public MarkSessionAliveRequest()
		{
		}

		// Token: 0x060084F6 RID: 34038 RVA: 0x00204CB5 File Offset: 0x00202EB5
		[DebuggerNonUserCode]
		public MarkSessionAliveRequest(MarkSessionAliveRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084F7 RID: 34039 RVA: 0x00204CD0 File Offset: 0x00202ED0
		[DebuggerNonUserCode]
		public MarkSessionAliveRequest Clone()
		{
			return new MarkSessionAliveRequest(this);
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x00204CE8 File Offset: 0x00202EE8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkSessionAliveRequest);
		}

		// Token: 0x060084F9 RID: 34041 RVA: 0x00204D08 File Offset: 0x00202F08
		[DebuggerNonUserCode]
		public bool Equals(MarkSessionAliveRequest other)
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

		// Token: 0x060084FA RID: 34042 RVA: 0x00204D48 File Offset: 0x00202F48
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

		// Token: 0x060084FB RID: 34043 RVA: 0x00204D7C File Offset: 0x00202F7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084FC RID: 34044 RVA: 0x00204D94 File Offset: 0x00202F94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084FD RID: 34045 RVA: 0x00204DA0 File Offset: 0x00202FA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084FE RID: 34046 RVA: 0x00204DCC File Offset: 0x00202FCC
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

		// Token: 0x060084FF RID: 34047 RVA: 0x00204E00 File Offset: 0x00203000
		[DebuggerNonUserCode]
		public void MergeFrom(MarkSessionAliveRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x00204E30 File Offset: 0x00203030
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x00204E3C File Offset: 0x0020303C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C36 RID: 15414
		private static readonly MessageParser<MarkSessionAliveRequest> _parser = new MessageParser<MarkSessionAliveRequest>(() => new MarkSessionAliveRequest());

		// Token: 0x04003C37 RID: 15415
		private UnknownFieldSet _unknownFields;
	}
}
