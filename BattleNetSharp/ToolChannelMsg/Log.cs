using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200001C RID: 28
	public sealed class Log : IMessage<Log>, IMessage, IEquatable<Log>, IDeepCloneable<Log>, IBufferMessage
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000BC40 File Offset: 0x00009E40
		[DebuggerNonUserCode]
		public static MessageParser<Log> Parser
		{
			get
			{
				return Log._parser;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000BC58 File Offset: 0x00009E58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000BC7C File Offset: 0x00009E7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Log.Descriptor;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000BC93 File Offset: 0x00009E93
		[DebuggerNonUserCode]
		public Log()
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000BC9D File Offset: 0x00009E9D
		[DebuggerNonUserCode]
		public Log(Log other)
			: this()
		{
			this.severity_ = other.severity_;
			this.log_ = other.log_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[DebuggerNonUserCode]
		public Log Clone()
		{
			return new Log(this);
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000BD09 File Offset: 0x00009F09
		[DebuggerNonUserCode]
		public string Severity
		{
			get
			{
				return this.severity_ ?? Log.SeverityDefaultValue;
			}
			set
			{
				this.severity_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000BD20 File Offset: 0x00009F20
		[DebuggerNonUserCode]
		public bool HasSeverity
		{
			get
			{
				return this.severity_ != null;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000BD3B File Offset: 0x00009F3B
		[DebuggerNonUserCode]
		public void ClearSeverity()
		{
			this.severity_ = null;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000BD48 File Offset: 0x00009F48
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000BD69 File Offset: 0x00009F69
		[DebuggerNonUserCode]
		public string Log_
		{
			get
			{
				return this.log_ ?? Log.Log_DefaultValue;
			}
			set
			{
				this.log_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000BD80 File Offset: 0x00009F80
		[DebuggerNonUserCode]
		public bool HasLog_
		{
			get
			{
				return this.log_ != null;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000BD9B File Offset: 0x00009F9B
		[DebuggerNonUserCode]
		public void ClearLog_()
		{
			this.log_ = null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Log);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		[DebuggerNonUserCode]
		public bool Equals(Log other)
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
					bool flag4 = this.Severity != other.Severity;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Log_ != other.Log_;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000BE3C File Offset: 0x0000A03C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSeverity = this.HasSeverity;
			if (hasSeverity)
			{
				num ^= this.Severity.GetHashCode();
			}
			bool hasLog_ = this.HasLog_;
			if (hasLog_)
			{
				num ^= this.Log_.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSeverity = this.HasSeverity;
			if (hasSeverity)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Severity);
			}
			bool hasLog_ = this.HasLog_;
			if (hasLog_)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Log_);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000BF34 File Offset: 0x0000A134
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSeverity = this.HasSeverity;
			if (hasSeverity)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Severity);
			}
			bool hasLog_ = this.HasLog_;
			if (hasLog_)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Log_);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[DebuggerNonUserCode]
		public void MergeFrom(Log other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSeverity = other.HasSeverity;
				if (hasSeverity)
				{
					this.Severity = other.Severity;
				}
				bool hasLog_ = other.HasLog_;
				if (hasLog_)
				{
					this.Log_ = other.Log_;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000C002 File Offset: 0x0000A202
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000C010 File Offset: 0x0000A210
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Log_ = input.ReadString();
					}
				}
				else
				{
					this.Severity = input.ReadString();
				}
			}
		}

		// Token: 0x040000A6 RID: 166
		private static readonly MessageParser<Log> _parser = new MessageParser<Log>(() => new Log());

		// Token: 0x040000A7 RID: 167
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000A8 RID: 168
		public const int SeverityFieldNumber = 1;

		// Token: 0x040000A9 RID: 169
		private static readonly string SeverityDefaultValue = "";

		// Token: 0x040000AA RID: 170
		private string severity_;

		// Token: 0x040000AB RID: 171
		public const int Log_FieldNumber = 2;

		// Token: 0x040000AC RID: 172
		private static readonly string Log_DefaultValue = "";

		// Token: 0x040000AD RID: 173
		private string log_;
	}
}
