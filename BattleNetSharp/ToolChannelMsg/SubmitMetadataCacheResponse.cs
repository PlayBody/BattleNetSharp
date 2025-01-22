using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F8 RID: 248
	public sealed class SubmitMetadataCacheResponse : IMessage<SubmitMetadataCacheResponse>, IMessage, IEquatable<SubmitMetadataCacheResponse>, IDeepCloneable<SubmitMetadataCacheResponse>, IBufferMessage
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00055C9C File Offset: 0x00053E9C
		[DebuggerNonUserCode]
		public static MessageParser<SubmitMetadataCacheResponse> Parser
		{
			get
			{
				return SubmitMetadataCacheResponse._parser;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00055CB4 File Offset: 0x00053EB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[225];
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00055CDC File Offset: 0x00053EDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitMetadataCacheResponse.Descriptor;
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00055CF3 File Offset: 0x00053EF3
		[DebuggerNonUserCode]
		public SubmitMetadataCacheResponse()
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00055CFD File Offset: 0x00053EFD
		[DebuggerNonUserCode]
		public SubmitMetadataCacheResponse(SubmitMetadataCacheResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00055D30 File Offset: 0x00053F30
		[DebuggerNonUserCode]
		public SubmitMetadataCacheResponse Clone()
		{
			return new SubmitMetadataCacheResponse(this);
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x00055D48 File Offset: 0x00053F48
		// (set) Token: 0x060017E8 RID: 6120 RVA: 0x00055D79 File Offset: 0x00053F79
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
					successDefaultValue = SubmitMetadataCacheResponse.SuccessDefaultValue;
				}
				return successDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.success_ = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00055D94 File Offset: 0x00053F94
		[DebuggerNonUserCode]
		public bool HasSuccess
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00055DB1 File Offset: 0x00053FB1
		[DebuggerNonUserCode]
		public void ClearSuccess()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00055DC4 File Offset: 0x00053FC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitMetadataCacheResponse);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00055DE4 File Offset: 0x00053FE4
		[DebuggerNonUserCode]
		public bool Equals(SubmitMetadataCacheResponse other)
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

		// Token: 0x060017ED RID: 6125 RVA: 0x00055E3C File Offset: 0x0005403C
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

		// Token: 0x060017EE RID: 6126 RVA: 0x00055E8C File Offset: 0x0005408C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00055EA4 File Offset: 0x000540A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00055EB0 File Offset: 0x000540B0
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

		// Token: 0x060017F1 RID: 6129 RVA: 0x00055EFC File Offset: 0x000540FC
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

		// Token: 0x060017F2 RID: 6130 RVA: 0x00055F40 File Offset: 0x00054140
		[DebuggerNonUserCode]
		public void MergeFrom(SubmitMetadataCacheResponse other)
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

		// Token: 0x060017F3 RID: 6131 RVA: 0x00055F89 File Offset: 0x00054189
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00055F94 File Offset: 0x00054194
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

		// Token: 0x0400099C RID: 2460
		private static readonly MessageParser<SubmitMetadataCacheResponse> _parser = new MessageParser<SubmitMetadataCacheResponse>(() => new SubmitMetadataCacheResponse());

		// Token: 0x0400099D RID: 2461
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400099E RID: 2462
		private int _hasBits0;

		// Token: 0x0400099F RID: 2463
		public const int SuccessFieldNumber = 1;

		// Token: 0x040009A0 RID: 2464
		private static readonly bool SuccessDefaultValue = false;

		// Token: 0x040009A1 RID: 2465
		private bool success_;
	}
}
