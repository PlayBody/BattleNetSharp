using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000021 RID: 33
	public sealed class RequestMainHolodeckSettings : IMessage<RequestMainHolodeckSettings>, IMessage, IEquatable<RequestMainHolodeckSettings>, IDeepCloneable<RequestMainHolodeckSettings>, IBufferMessage
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000C998 File Offset: 0x0000AB98
		[DebuggerNonUserCode]
		public static MessageParser<RequestMainHolodeckSettings> Parser
		{
			get
			{
				return RequestMainHolodeckSettings._parser;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RequestMainHolodeckSettings.Descriptor;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000C9EB File Offset: 0x0000ABEB
		[DebuggerNonUserCode]
		public RequestMainHolodeckSettings()
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000C9F5 File Offset: 0x0000ABF5
		[DebuggerNonUserCode]
		public RequestMainHolodeckSettings(RequestMainHolodeckSettings other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000CA10 File Offset: 0x0000AC10
		[DebuggerNonUserCode]
		public RequestMainHolodeckSettings Clone()
		{
			return new RequestMainHolodeckSettings(this);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000CA28 File Offset: 0x0000AC28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RequestMainHolodeckSettings);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000CA48 File Offset: 0x0000AC48
		[DebuggerNonUserCode]
		public bool Equals(RequestMainHolodeckSettings other)
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

		// Token: 0x060001A7 RID: 423 RVA: 0x0000CA88 File Offset: 0x0000AC88
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

		// Token: 0x060001A8 RID: 424 RVA: 0x0000CABC File Offset: 0x0000ACBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000CB0C File Offset: 0x0000AD0C
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

		// Token: 0x060001AC RID: 428 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[DebuggerNonUserCode]
		public void MergeFrom(RequestMainHolodeckSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000B6 RID: 182
		private static readonly MessageParser<RequestMainHolodeckSettings> _parser = new MessageParser<RequestMainHolodeckSettings>(() => new RequestMainHolodeckSettings());

		// Token: 0x040000B7 RID: 183
		private UnknownFieldSet _unknownFields;
	}
}
