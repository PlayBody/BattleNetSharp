using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000533 RID: 1331
	public sealed class GetSessionCapacityRequest : IMessage<GetSessionCapacityRequest>, IMessage, IEquatable<GetSessionCapacityRequest>, IDeepCloneable<GetSessionCapacityRequest>, IBufferMessage
	{
		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x060080EB RID: 33003 RVA: 0x001F63E4 File Offset: 0x001F45E4
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionCapacityRequest> Parser
		{
			get
			{
				return GetSessionCapacityRequest._parser;
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x060080EC RID: 33004 RVA: 0x001F63FC File Offset: 0x001F45FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x060080ED RID: 33005 RVA: 0x001F6420 File Offset: 0x001F4620
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionCapacityRequest.Descriptor;
			}
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x001F6437 File Offset: 0x001F4637
		[DebuggerNonUserCode]
		public GetSessionCapacityRequest()
		{
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x001F6441 File Offset: 0x001F4641
		[DebuggerNonUserCode]
		public GetSessionCapacityRequest(GetSessionCapacityRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x001F645C File Offset: 0x001F465C
		[DebuggerNonUserCode]
		public GetSessionCapacityRequest Clone()
		{
			return new GetSessionCapacityRequest(this);
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x001F6474 File Offset: 0x001F4674
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionCapacityRequest);
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x001F6494 File Offset: 0x001F4694
		[DebuggerNonUserCode]
		public bool Equals(GetSessionCapacityRequest other)
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

		// Token: 0x060080F3 RID: 33011 RVA: 0x001F64D4 File Offset: 0x001F46D4
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

		// Token: 0x060080F4 RID: 33012 RVA: 0x001F6508 File Offset: 0x001F4708
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x001F6520 File Offset: 0x001F4720
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080F6 RID: 33014 RVA: 0x001F652C File Offset: 0x001F472C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x001F6558 File Offset: 0x001F4758
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

		// Token: 0x060080F8 RID: 33016 RVA: 0x001F658C File Offset: 0x001F478C
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionCapacityRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x001F65BC File Offset: 0x001F47BC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x001F65C8 File Offset: 0x001F47C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A83 RID: 14979
		private static readonly MessageParser<GetSessionCapacityRequest> _parser = new MessageParser<GetSessionCapacityRequest>(() => new GetSessionCapacityRequest());

		// Token: 0x04003A84 RID: 14980
		private UnknownFieldSet _unknownFields;
	}
}
