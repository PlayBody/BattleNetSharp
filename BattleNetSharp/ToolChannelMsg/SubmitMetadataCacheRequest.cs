using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F7 RID: 247
	public sealed class SubmitMetadataCacheRequest : IMessage<SubmitMetadataCacheRequest>, IMessage, IEquatable<SubmitMetadataCacheRequest>, IDeepCloneable<SubmitMetadataCacheRequest>, IBufferMessage
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0005594C File Offset: 0x00053B4C
		[DebuggerNonUserCode]
		public static MessageParser<SubmitMetadataCacheRequest> Parser
		{
			get
			{
				return SubmitMetadataCacheRequest._parser;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00055964 File Offset: 0x00053B64
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[224];
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0005598C File Offset: 0x00053B8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitMetadataCacheRequest.Descriptor;
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x000559A3 File Offset: 0x00053BA3
		[DebuggerNonUserCode]
		public SubmitMetadataCacheRequest()
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x000559AD File Offset: 0x00053BAD
		[DebuggerNonUserCode]
		public SubmitMetadataCacheRequest(SubmitMetadataCacheRequest other)
			: this()
		{
			this.generatedMetadataCachePath_ = other.generatedMetadataCachePath_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000559D4 File Offset: 0x00053BD4
		[DebuggerNonUserCode]
		public SubmitMetadataCacheRequest Clone()
		{
			return new SubmitMetadataCacheRequest(this);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x000559EC File Offset: 0x00053BEC
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00055A0D File Offset: 0x00053C0D
		[DebuggerNonUserCode]
		public string GeneratedMetadataCachePath
		{
			get
			{
				return this.generatedMetadataCachePath_ ?? SubmitMetadataCacheRequest.GeneratedMetadataCachePathDefaultValue;
			}
			set
			{
				this.generatedMetadataCachePath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00055A24 File Offset: 0x00053C24
		[DebuggerNonUserCode]
		public bool HasGeneratedMetadataCachePath
		{
			get
			{
				return this.generatedMetadataCachePath_ != null;
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00055A3F File Offset: 0x00053C3F
		[DebuggerNonUserCode]
		public void ClearGeneratedMetadataCachePath()
		{
			this.generatedMetadataCachePath_ = null;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00055A4C File Offset: 0x00053C4C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitMetadataCacheRequest);
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00055A6C File Offset: 0x00053C6C
		[DebuggerNonUserCode]
		public bool Equals(SubmitMetadataCacheRequest other)
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
					bool flag4 = this.GeneratedMetadataCachePath != other.GeneratedMetadataCachePath;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00055AC4 File Offset: 0x00053CC4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGeneratedMetadataCachePath = this.HasGeneratedMetadataCachePath;
			if (hasGeneratedMetadataCachePath)
			{
				num ^= this.GeneratedMetadataCachePath.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00055B10 File Offset: 0x00053D10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00055B28 File Offset: 0x00053D28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00055B34 File Offset: 0x00053D34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGeneratedMetadataCachePath = this.HasGeneratedMetadataCachePath;
			if (hasGeneratedMetadataCachePath)
			{
				output.WriteRawTag(10);
				output.WriteString(this.GeneratedMetadataCachePath);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00055B80 File Offset: 0x00053D80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGeneratedMetadataCachePath = this.HasGeneratedMetadataCachePath;
			if (hasGeneratedMetadataCachePath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GeneratedMetadataCachePath);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00055BD0 File Offset: 0x00053DD0
		[DebuggerNonUserCode]
		public void MergeFrom(SubmitMetadataCacheRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGeneratedMetadataCachePath = other.HasGeneratedMetadataCachePath;
				if (hasGeneratedMetadataCachePath)
				{
					this.GeneratedMetadataCachePath = other.GeneratedMetadataCachePath;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00055C19 File Offset: 0x00053E19
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00055C24 File Offset: 0x00053E24
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
					this.GeneratedMetadataCachePath = input.ReadString();
				}
			}
		}

		// Token: 0x04000997 RID: 2455
		private static readonly MessageParser<SubmitMetadataCacheRequest> _parser = new MessageParser<SubmitMetadataCacheRequest>(() => new SubmitMetadataCacheRequest());

		// Token: 0x04000998 RID: 2456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000999 RID: 2457
		public const int GeneratedMetadataCachePathFieldNumber = 1;

		// Token: 0x0400099A RID: 2458
		private static readonly string GeneratedMetadataCachePathDefaultValue = "";

		// Token: 0x0400099B RID: 2459
		private string generatedMetadataCachePath_;
	}
}
