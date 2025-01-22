using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000276 RID: 630
	public sealed class RunStressResponse : IMessage<RunStressResponse>, IMessage, IEquatable<RunStressResponse>, IDeepCloneable<RunStressResponse>, IBufferMessage
	{
		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x00104FA0 File Offset: 0x001031A0
		[DebuggerNonUserCode]
		public static MessageParser<RunStressResponse> Parser
		{
			get
			{
				return RunStressResponse._parser;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06004371 RID: 17265 RVA: 0x00104FB8 File Offset: 0x001031B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[102];
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x00104FDC File Offset: 0x001031DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunStressResponse.Descriptor;
			}
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00104FF3 File Offset: 0x001031F3
		[DebuggerNonUserCode]
		public RunStressResponse()
		{
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00104FFD File Offset: 0x001031FD
		[DebuggerNonUserCode]
		public RunStressResponse(RunStressResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00105018 File Offset: 0x00103218
		[DebuggerNonUserCode]
		public RunStressResponse Clone()
		{
			return new RunStressResponse(this);
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00105030 File Offset: 0x00103230
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunStressResponse);
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00105050 File Offset: 0x00103250
		[DebuggerNonUserCode]
		public bool Equals(RunStressResponse other)
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

		// Token: 0x06004378 RID: 17272 RVA: 0x00105090 File Offset: 0x00103290
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

		// Token: 0x06004379 RID: 17273 RVA: 0x001050C4 File Offset: 0x001032C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x001050DC File Offset: 0x001032DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x001050E8 File Offset: 0x001032E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00105114 File Offset: 0x00103314
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

		// Token: 0x0600437D RID: 17277 RVA: 0x00105148 File Offset: 0x00103348
		[DebuggerNonUserCode]
		public void MergeFrom(RunStressResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x00105178 File Offset: 0x00103378
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x00105184 File Offset: 0x00103384
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001E5F RID: 7775
		private static readonly MessageParser<RunStressResponse> _parser = new MessageParser<RunStressResponse>(() => new RunStressResponse());

		// Token: 0x04001E60 RID: 7776
		private UnknownFieldSet _unknownFields;
	}
}
