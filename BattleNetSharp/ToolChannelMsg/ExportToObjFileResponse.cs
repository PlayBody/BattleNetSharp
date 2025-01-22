using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000BC RID: 188
	public sealed class ExportToObjFileResponse : IMessage<ExportToObjFileResponse>, IMessage, IEquatable<ExportToObjFileResponse>, IDeepCloneable<ExportToObjFileResponse>, IBufferMessage
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00040AC4 File Offset: 0x0003ECC4
		[DebuggerNonUserCode]
		public static MessageParser<ExportToObjFileResponse> Parser
		{
			get
			{
				return ExportToObjFileResponse._parser;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00040ADC File Offset: 0x0003ECDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[165];
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00040B04 File Offset: 0x0003ED04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExportToObjFileResponse.Descriptor;
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00040B1B File Offset: 0x0003ED1B
		[DebuggerNonUserCode]
		public ExportToObjFileResponse()
		{
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00040B25 File Offset: 0x0003ED25
		[DebuggerNonUserCode]
		public ExportToObjFileResponse(ExportToObjFileResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00040B58 File Offset: 0x0003ED58
		[DebuggerNonUserCode]
		public ExportToObjFileResponse Clone()
		{
			return new ExportToObjFileResponse(this);
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00040B70 File Offset: 0x0003ED70
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x00040BA1 File Offset: 0x0003EDA1
		[DebuggerNonUserCode]
		public bool Success
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool successDefaultValue;
				if (flag)
				{
					successDefaultValue = this.success_;
				}
				else
				{
					successDefaultValue = ExportToObjFileResponse.SuccessDefaultValue;
				}
				return successDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.success_ = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00040BBC File Offset: 0x0003EDBC
		[DebuggerNonUserCode]
		public bool HasSuccess
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00040BD9 File Offset: 0x0003EDD9
		[DebuggerNonUserCode]
		public void ClearSuccess()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00040BEC File Offset: 0x0003EDEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExportToObjFileResponse);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00040C0C File Offset: 0x0003EE0C
		[DebuggerNonUserCode]
		public bool Equals(ExportToObjFileResponse other)
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
					bool flag4 = this.Success != other.Success;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00040C64 File Offset: 0x0003EE64
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num ^= this.Success.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00040CB4 File Offset: 0x0003EEB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00040CCC File Offset: 0x0003EECC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00040CD8 File Offset: 0x0003EED8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Success);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00040D24 File Offset: 0x0003EF24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00040D68 File Offset: 0x0003EF68
		[DebuggerNonUserCode]
		public void MergeFrom(ExportToObjFileResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSuccess = other.HasSuccess;
				if (hasSuccess)
				{
					this.Success = other.Success;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00040DB1 File Offset: 0x0003EFB1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00040DBC File Offset: 0x0003EFBC
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
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x04000710 RID: 1808
		private static readonly MessageParser<ExportToObjFileResponse> _parser = new MessageParser<ExportToObjFileResponse>(() => new ExportToObjFileResponse());

		// Token: 0x04000711 RID: 1809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000712 RID: 1810
		private int _hasBits0;

		// Token: 0x04000713 RID: 1811
		public const int SuccessFieldNumber = 1;

		// Token: 0x04000714 RID: 1812
		private static readonly bool SuccessDefaultValue = false;

		// Token: 0x04000715 RID: 1813
		private bool success_;
	}
}
