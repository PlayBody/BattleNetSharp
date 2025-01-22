using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000537 RID: 1335
	public sealed class MarkSessionsAliveRequest : IMessage<MarkSessionsAliveRequest>, IMessage, IEquatable<MarkSessionsAliveRequest>, IDeepCloneable<MarkSessionsAliveRequest>, IBufferMessage
	{
		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x001F7618 File Offset: 0x001F5818
		[DebuggerNonUserCode]
		public static MessageParser<MarkSessionsAliveRequest> Parser
		{
			get
			{
				return MarkSessionsAliveRequest._parser;
			}
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x06008149 RID: 33097 RVA: 0x001F7630 File Offset: 0x001F5830
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x001F7654 File Offset: 0x001F5854
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkSessionsAliveRequest.Descriptor;
			}
		}

		// Token: 0x0600814B RID: 33099 RVA: 0x001F766B File Offset: 0x001F586B
		[DebuggerNonUserCode]
		public MarkSessionsAliveRequest()
		{
		}

		// Token: 0x0600814C RID: 33100 RVA: 0x001F7680 File Offset: 0x001F5880
		[DebuggerNonUserCode]
		public MarkSessionsAliveRequest(MarkSessionsAliveRequest other)
			: this()
		{
			this.session_ = other.session_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x001F76AC File Offset: 0x001F58AC
		[DebuggerNonUserCode]
		public MarkSessionsAliveRequest Clone()
		{
			return new MarkSessionsAliveRequest(this);
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x0600814E RID: 33102 RVA: 0x001F76C4 File Offset: 0x001F58C4
		[DebuggerNonUserCode]
		public RepeatedField<SessionIdentifier> Session
		{
			get
			{
				return this.session_;
			}
		}

		// Token: 0x0600814F RID: 33103 RVA: 0x001F76DC File Offset: 0x001F58DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkSessionsAliveRequest);
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x001F76FC File Offset: 0x001F58FC
		[DebuggerNonUserCode]
		public bool Equals(MarkSessionsAliveRequest other)
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
					bool flag4 = !this.session_.Equals(other.session_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x001F7758 File Offset: 0x001F5958
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.session_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x001F7798 File Offset: 0x001F5998
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x001F77B0 File Offset: 0x001F59B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x001F77BC File Offset: 0x001F59BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.session_.WriteTo(ref output, MarkSessionsAliveRequest._repeated_session_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x001F77F8 File Offset: 0x001F59F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.session_.CalculateSize(MarkSessionsAliveRequest._repeated_session_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x001F7840 File Offset: 0x001F5A40
		[DebuggerNonUserCode]
		public void MergeFrom(MarkSessionsAliveRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.session_.Add(other.session_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x001F7882 File Offset: 0x001F5A82
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x001F7890 File Offset: 0x001F5A90
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
					this.session_.AddEntriesFrom(ref input, MarkSessionsAliveRequest._repeated_session_codec);
				}
			}
		}

		// Token: 0x04003AA4 RID: 15012
		private static readonly MessageParser<MarkSessionsAliveRequest> _parser = new MessageParser<MarkSessionsAliveRequest>(() => new MarkSessionsAliveRequest());

		// Token: 0x04003AA5 RID: 15013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AA6 RID: 15014
		public const int SessionFieldNumber = 1;

		// Token: 0x04003AA7 RID: 15015
		private static readonly FieldCodec<SessionIdentifier> _repeated_session_codec = FieldCodec.ForMessage<SessionIdentifier>(10U, SessionIdentifier.Parser);

		// Token: 0x04003AA8 RID: 15016
		private readonly RepeatedField<SessionIdentifier> session_ = new RepeatedField<SessionIdentifier>();
	}
}
