using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x0200060C RID: 1548
	public sealed class LogonUpdateRequest : IMessage<LogonUpdateRequest>, IMessage, IEquatable<LogonUpdateRequest>, IDeepCloneable<LogonUpdateRequest>, IBufferMessage
	{
		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x060090FD RID: 37117 RVA: 0x00232A34 File Offset: 0x00230C34
		[DebuggerNonUserCode]
		public static MessageParser<LogonUpdateRequest> Parser
		{
			get
			{
				return LogonUpdateRequest._parser;
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x060090FE RID: 37118 RVA: 0x00232A4C File Offset: 0x00230C4C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x060090FF RID: 37119 RVA: 0x00232A70 File Offset: 0x00230C70
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x00232A87 File Offset: 0x00230C87
		[DebuggerNonUserCode]
		public LogonUpdateRequest()
		{
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x00232A91 File Offset: 0x00230C91
		[DebuggerNonUserCode]
		public LogonUpdateRequest(LogonUpdateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x00232AC4 File Offset: 0x00230CC4
		[DebuggerNonUserCode]
		public LogonUpdateRequest Clone()
		{
			return new LogonUpdateRequest(this);
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x06009103 RID: 37123 RVA: 0x00232ADC File Offset: 0x00230CDC
		// (set) Token: 0x06009104 RID: 37124 RVA: 0x00232B0D File Offset: 0x00230D0D
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = LogonUpdateRequest.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x06009105 RID: 37125 RVA: 0x00232B28 File Offset: 0x00230D28
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x00232B45 File Offset: 0x00230D45
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x00232B58 File Offset: 0x00230D58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonUpdateRequest);
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x00232B78 File Offset: 0x00230D78
		[DebuggerNonUserCode]
		public bool Equals(LogonUpdateRequest other)
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
					bool flag4 = this.ErrorCode != other.ErrorCode;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x00232BD0 File Offset: 0x00230DD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x00232C20 File Offset: 0x00230E20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600910B RID: 37131 RVA: 0x00232C38 File Offset: 0x00230E38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x00232C44 File Offset: 0x00230E44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x00232C90 File Offset: 0x00230E90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600910E RID: 37134 RVA: 0x00232CE0 File Offset: 0x00230EE0
		[DebuggerNonUserCode]
		public void MergeFrom(LogonUpdateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600910F RID: 37135 RVA: 0x00232D29 File Offset: 0x00230F29
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009110 RID: 37136 RVA: 0x00232D34 File Offset: 0x00230F34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400417D RID: 16765
		private static readonly MessageParser<LogonUpdateRequest> _parser = new MessageParser<LogonUpdateRequest>(() => new LogonUpdateRequest());

		// Token: 0x0400417E RID: 16766
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400417F RID: 16767
		private int _hasBits0;

		// Token: 0x04004180 RID: 16768
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004181 RID: 16769
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04004182 RID: 16770
		private uint errorCode_;
	}
}
