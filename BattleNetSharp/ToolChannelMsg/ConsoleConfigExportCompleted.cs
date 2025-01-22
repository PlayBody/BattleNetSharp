using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000102 RID: 258
	public sealed class ConsoleConfigExportCompleted : IMessage<ConsoleConfigExportCompleted>, IMessage, IEquatable<ConsoleConfigExportCompleted>, IDeepCloneable<ConsoleConfigExportCompleted>, IBufferMessage
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x00057C20 File Offset: 0x00055E20
		[DebuggerNonUserCode]
		public static MessageParser<ConsoleConfigExportCompleted> Parser
		{
			get
			{
				return ConsoleConfigExportCompleted._parser;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x00057C38 File Offset: 0x00055E38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[235];
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00057C60 File Offset: 0x00055E60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsoleConfigExportCompleted.Descriptor;
			}
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00057C77 File Offset: 0x00055E77
		[DebuggerNonUserCode]
		public ConsoleConfigExportCompleted()
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00057C81 File Offset: 0x00055E81
		[DebuggerNonUserCode]
		public ConsoleConfigExportCompleted(ConsoleConfigExportCompleted other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00057CB4 File Offset: 0x00055EB4
		[DebuggerNonUserCode]
		public ConsoleConfigExportCompleted Clone()
		{
			return new ConsoleConfigExportCompleted(this);
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00057CCC File Offset: 0x00055ECC
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x00057CFD File Offset: 0x00055EFD
		[DebuggerNonUserCode]
		public int ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = ConsoleConfigExportCompleted.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00057D18 File Offset: 0x00055F18
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00057D35 File Offset: 0x00055F35
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00057D48 File Offset: 0x00055F48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsoleConfigExportCompleted);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00057D68 File Offset: 0x00055F68
		[DebuggerNonUserCode]
		public bool Equals(ConsoleConfigExportCompleted other)
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

		// Token: 0x060018AF RID: 6319 RVA: 0x00057DC0 File Offset: 0x00055FC0
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

		// Token: 0x060018B0 RID: 6320 RVA: 0x00057E10 File Offset: 0x00056010
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00057E28 File Offset: 0x00056028
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00057E34 File Offset: 0x00056034
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00057E80 File Offset: 0x00056080
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00057ED0 File Offset: 0x000560D0
		[DebuggerNonUserCode]
		public void MergeFrom(ConsoleConfigExportCompleted other)
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

		// Token: 0x060018B5 RID: 6325 RVA: 0x00057F19 File Offset: 0x00056119
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00057F24 File Offset: 0x00056124
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
					this.ErrorCode = input.ReadInt32();
				}
			}
		}

		// Token: 0x040009CF RID: 2511
		private static readonly MessageParser<ConsoleConfigExportCompleted> _parser = new MessageParser<ConsoleConfigExportCompleted>(() => new ConsoleConfigExportCompleted());

		// Token: 0x040009D0 RID: 2512
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009D1 RID: 2513
		private int _hasBits0;

		// Token: 0x040009D2 RID: 2514
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040009D3 RID: 2515
		private static readonly int ErrorCodeDefaultValue = 0;

		// Token: 0x040009D4 RID: 2516
		private int errorCode_;
	}
}
