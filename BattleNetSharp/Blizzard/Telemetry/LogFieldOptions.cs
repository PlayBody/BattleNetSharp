using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002E4 RID: 740
	public sealed class LogFieldOptions : IMessage<LogFieldOptions>, IMessage, IEquatable<LogFieldOptions>, IDeepCloneable<LogFieldOptions>, IBufferMessage
	{
		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06004E1B RID: 19995 RVA: 0x0012AC08 File Offset: 0x00128E08
		[DebuggerNonUserCode]
		public static MessageParser<LogFieldOptions> Parser
		{
			get
			{
				return LogFieldOptions._parser;
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x0012AC20 File Offset: 0x00128E20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelemetryExtensionsReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x06004E1D RID: 19997 RVA: 0x0012AC44 File Offset: 0x00128E44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogFieldOptions.Descriptor;
			}
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x0012AC5B File Offset: 0x00128E5B
		[DebuggerNonUserCode]
		public LogFieldOptions()
		{
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x0012AC65 File Offset: 0x00128E65
		[DebuggerNonUserCode]
		public LogFieldOptions(LogFieldOptions other)
			: this()
		{
			this.syslogField_ = other.syslogField_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x0012AC8C File Offset: 0x00128E8C
		[DebuggerNonUserCode]
		public LogFieldOptions Clone()
		{
			return new LogFieldOptions(this);
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06004E21 RID: 20001 RVA: 0x0012ACA4 File Offset: 0x00128EA4
		// (set) Token: 0x06004E22 RID: 20002 RVA: 0x0012ACC5 File Offset: 0x00128EC5
		[DebuggerNonUserCode]
		public string SyslogField
		{
			get
			{
				return this.syslogField_ ?? LogFieldOptions.SyslogFieldDefaultValue;
			}
			set
			{
				this.syslogField_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06004E23 RID: 20003 RVA: 0x0012ACDC File Offset: 0x00128EDC
		[DebuggerNonUserCode]
		public bool HasSyslogField
		{
			get
			{
				return this.syslogField_ != null;
			}
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x0012ACF7 File Offset: 0x00128EF7
		[DebuggerNonUserCode]
		public void ClearSyslogField()
		{
			this.syslogField_ = null;
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x0012AD04 File Offset: 0x00128F04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogFieldOptions);
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x0012AD24 File Offset: 0x00128F24
		[DebuggerNonUserCode]
		public bool Equals(LogFieldOptions other)
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
					bool flag4 = this.SyslogField != other.SyslogField;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x0012AD7C File Offset: 0x00128F7C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSyslogField = this.HasSyslogField;
			if (hasSyslogField)
			{
				num ^= this.SyslogField.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x0012ADC8 File Offset: 0x00128FC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x0012ADE0 File Offset: 0x00128FE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x0012ADEC File Offset: 0x00128FEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSyslogField = this.HasSyslogField;
			if (hasSyslogField)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SyslogField);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x0012AE38 File Offset: 0x00129038
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSyslogField = this.HasSyslogField;
			if (hasSyslogField)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SyslogField);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x0012AE88 File Offset: 0x00129088
		[DebuggerNonUserCode]
		public void MergeFrom(LogFieldOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSyslogField = other.HasSyslogField;
				if (hasSyslogField)
				{
					this.SyslogField = other.SyslogField;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x0012AED1 File Offset: 0x001290D1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x0012AEDC File Offset: 0x001290DC
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
					this.SyslogField = input.ReadString();
				}
			}
		}

		// Token: 0x040022D7 RID: 8919
		private static readonly MessageParser<LogFieldOptions> _parser = new MessageParser<LogFieldOptions>(() => new LogFieldOptions());

		// Token: 0x040022D8 RID: 8920
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022D9 RID: 8921
		public const int SyslogFieldFieldNumber = 1;

		// Token: 0x040022DA RID: 8922
		private static readonly string SyslogFieldDefaultValue = "";

		// Token: 0x040022DB RID: 8923
		private string syslogField_;
	}
}
