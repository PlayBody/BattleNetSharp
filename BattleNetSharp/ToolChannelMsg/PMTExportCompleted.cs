using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000101 RID: 257
	public sealed class PMTExportCompleted : IMessage<PMTExportCompleted>, IMessage, IEquatable<PMTExportCompleted>, IDeepCloneable<PMTExportCompleted>, IBufferMessage
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x000578A8 File Offset: 0x00055AA8
		[DebuggerNonUserCode]
		public static MessageParser<PMTExportCompleted> Parser
		{
			get
			{
				return PMTExportCompleted._parser;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x000578C0 File Offset: 0x00055AC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[234];
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x000578E8 File Offset: 0x00055AE8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PMTExportCompleted.Descriptor;
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x000578FF File Offset: 0x00055AFF
		[DebuggerNonUserCode]
		public PMTExportCompleted()
		{
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00057909 File Offset: 0x00055B09
		[DebuggerNonUserCode]
		public PMTExportCompleted(PMTExportCompleted other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0005793C File Offset: 0x00055B3C
		[DebuggerNonUserCode]
		public PMTExportCompleted Clone()
		{
			return new PMTExportCompleted(this);
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00057954 File Offset: 0x00055B54
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x00057985 File Offset: 0x00055B85
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
					errorCodeDefaultValue = PMTExportCompleted.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x000579A0 File Offset: 0x00055BA0
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x000579BD File Offset: 0x00055BBD
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000579D0 File Offset: 0x00055BD0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PMTExportCompleted);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x000579F0 File Offset: 0x00055BF0
		[DebuggerNonUserCode]
		public bool Equals(PMTExportCompleted other)
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

		// Token: 0x0600189A RID: 6298 RVA: 0x00057A48 File Offset: 0x00055C48
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

		// Token: 0x0600189B RID: 6299 RVA: 0x00057A98 File Offset: 0x00055C98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00057AB0 File Offset: 0x00055CB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00057ABC File Offset: 0x00055CBC
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

		// Token: 0x0600189E RID: 6302 RVA: 0x00057B08 File Offset: 0x00055D08
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

		// Token: 0x0600189F RID: 6303 RVA: 0x00057B58 File Offset: 0x00055D58
		[DebuggerNonUserCode]
		public void MergeFrom(PMTExportCompleted other)
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

		// Token: 0x060018A0 RID: 6304 RVA: 0x00057BA1 File Offset: 0x00055DA1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00057BAC File Offset: 0x00055DAC
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

		// Token: 0x040009C9 RID: 2505
		private static readonly MessageParser<PMTExportCompleted> _parser = new MessageParser<PMTExportCompleted>(() => new PMTExportCompleted());

		// Token: 0x040009CA RID: 2506
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009CB RID: 2507
		private int _hasBits0;

		// Token: 0x040009CC RID: 2508
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040009CD RID: 2509
		private static readonly int ErrorCodeDefaultValue = 0;

		// Token: 0x040009CE RID: 2510
		private int errorCode_;
	}
}
