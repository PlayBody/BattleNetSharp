using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000096 RID: 150
	public sealed class UITreeRequest : IMessage<UITreeRequest>, IMessage, IEquatable<UITreeRequest>, IDeepCloneable<UITreeRequest>, IBufferMessage
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x000337A4 File Offset: 0x000319A4
		[DebuggerNonUserCode]
		public static MessageParser<UITreeRequest> Parser
		{
			get
			{
				return UITreeRequest._parser;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x000337BC File Offset: 0x000319BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[127];
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x000337E0 File Offset: 0x000319E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UITreeRequest.Descriptor;
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000337F7 File Offset: 0x000319F7
		[DebuggerNonUserCode]
		public UITreeRequest()
		{
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00033801 File Offset: 0x00031A01
		[DebuggerNonUserCode]
		public UITreeRequest(UITreeRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0003381C File Offset: 0x00031A1C
		[DebuggerNonUserCode]
		public UITreeRequest Clone()
		{
			return new UITreeRequest(this);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00033834 File Offset: 0x00031A34
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UITreeRequest);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00033854 File Offset: 0x00031A54
		[DebuggerNonUserCode]
		public bool Equals(UITreeRequest other)
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

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00033894 File Offset: 0x00031A94
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

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000338C8 File Offset: 0x00031AC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000338E0 File Offset: 0x00031AE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000338EC File Offset: 0x00031AEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00033918 File Offset: 0x00031B18
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

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0003394C File Offset: 0x00031B4C
		[DebuggerNonUserCode]
		public void MergeFrom(UITreeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0003397C File Offset: 0x00031B7C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00033988 File Offset: 0x00031B88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400057B RID: 1403
		private static readonly MessageParser<UITreeRequest> _parser = new MessageParser<UITreeRequest>(() => new UITreeRequest());

		// Token: 0x0400057C RID: 1404
		private UnknownFieldSet _unknownFields;
	}
}
