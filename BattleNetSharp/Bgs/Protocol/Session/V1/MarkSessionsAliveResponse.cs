using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000538 RID: 1336
	public sealed class MarkSessionsAliveResponse : IMessage<MarkSessionsAliveResponse>, IMessage, IEquatable<MarkSessionsAliveResponse>, IDeepCloneable<MarkSessionsAliveResponse>, IBufferMessage
	{
		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600815A RID: 33114 RVA: 0x001F7914 File Offset: 0x001F5B14
		[DebuggerNonUserCode]
		public static MessageParser<MarkSessionsAliveResponse> Parser
		{
			get
			{
				return MarkSessionsAliveResponse._parser;
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600815B RID: 33115 RVA: 0x001F792C File Offset: 0x001F5B2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x0600815C RID: 33116 RVA: 0x001F7950 File Offset: 0x001F5B50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkSessionsAliveResponse.Descriptor;
			}
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x001F7967 File Offset: 0x001F5B67
		[DebuggerNonUserCode]
		public MarkSessionsAliveResponse()
		{
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x001F797C File Offset: 0x001F5B7C
		[DebuggerNonUserCode]
		public MarkSessionsAliveResponse(MarkSessionsAliveResponse other)
			: this()
		{
			this.failedSession_ = other.failedSession_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x001F79A8 File Offset: 0x001F5BA8
		[DebuggerNonUserCode]
		public MarkSessionsAliveResponse Clone()
		{
			return new MarkSessionsAliveResponse(this);
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x001F79C0 File Offset: 0x001F5BC0
		[DebuggerNonUserCode]
		public RepeatedField<SessionIdentifier> FailedSession
		{
			get
			{
				return this.failedSession_;
			}
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x001F79D8 File Offset: 0x001F5BD8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkSessionsAliveResponse);
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x001F79F8 File Offset: 0x001F5BF8
		[DebuggerNonUserCode]
		public bool Equals(MarkSessionsAliveResponse other)
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
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = !this.failedSession_.Equals(other.failedSession_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x001F7A54 File Offset: 0x001F5C54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.failedSession_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x001F7A94 File Offset: 0x001F5C94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x001F7AAC File Offset: 0x001F5CAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x001F7AB8 File Offset: 0x001F5CB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.failedSession_.WriteTo(ref output, MarkSessionsAliveResponse._repeated_failedSession_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x001F7AF4 File Offset: 0x001F5CF4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.failedSession_.CalculateSize(MarkSessionsAliveResponse._repeated_failedSession_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x001F7B3C File Offset: 0x001F5D3C
		[DebuggerNonUserCode]
		public void MergeFrom(MarkSessionsAliveResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.failedSession_.Add(other.failedSession_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x001F7B7E File Offset: 0x001F5D7E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x001F7B8C File Offset: 0x001F5D8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.failedSession_.AddEntriesFrom(ref input, MarkSessionsAliveResponse._repeated_failedSession_codec);
				}
			}
		}

		// Token: 0x04003AA9 RID: 15017
		private static readonly MessageParser<MarkSessionsAliveResponse> _parser = new MessageParser<MarkSessionsAliveResponse>(() => new MarkSessionsAliveResponse());

		// Token: 0x04003AAA RID: 15018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AAB RID: 15019
		public const int FailedSessionFieldNumber = 1;

		// Token: 0x04003AAC RID: 15020
		private static readonly FieldCodec<SessionIdentifier> _repeated_failedSession_codec = FieldCodec.ForMessage<SessionIdentifier>(10U, SessionIdentifier.Parser);

		// Token: 0x04003AAD RID: 15021
		private readonly RepeatedField<SessionIdentifier> failedSession_ = new RepeatedField<SessionIdentifier>();
	}
}
