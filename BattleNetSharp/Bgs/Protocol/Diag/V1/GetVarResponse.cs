using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000423 RID: 1059
	public sealed class GetVarResponse : IMessage<GetVarResponse>, IMessage, IEquatable<GetVarResponse>, IDeepCloneable<GetVarResponse>, IBufferMessage
	{
		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x001945B0 File Offset: 0x001927B0
		[DebuggerNonUserCode]
		public static MessageParser<GetVarResponse> Parser
		{
			get
			{
				return GetVarResponse._parser;
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x0600686C RID: 26732 RVA: 0x001945C8 File Offset: 0x001927C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x001945EC File Offset: 0x001927EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetVarResponse.Descriptor;
			}
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x00194603 File Offset: 0x00192803
		[DebuggerNonUserCode]
		public GetVarResponse()
		{
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x0019460D File Offset: 0x0019280D
		[DebuggerNonUserCode]
		public GetVarResponse(GetVarResponse other)
			: this()
		{
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x00194634 File Offset: 0x00192834
		[DebuggerNonUserCode]
		public GetVarResponse Clone()
		{
			return new GetVarResponse(this);
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x0019464C File Offset: 0x0019284C
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x0019466D File Offset: 0x0019286D
		[DebuggerNonUserCode]
		public string Value
		{
			get
			{
				return this.value_ ?? GetVarResponse.ValueDefaultValue;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x00194684 File Offset: 0x00192884
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return this.value_ != null;
			}
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x0019469F File Offset: 0x0019289F
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this.value_ = null;
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x001946AC File Offset: 0x001928AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetVarResponse);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x001946CC File Offset: 0x001928CC
		[DebuggerNonUserCode]
		public bool Equals(GetVarResponse other)
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
					bool flag4 = this.Value != other.Value;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00194724 File Offset: 0x00192924
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00194770 File Offset: 0x00192970
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00194788 File Offset: 0x00192988
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x00194794 File Offset: 0x00192994
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001947E0 File Offset: 0x001929E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00194830 File Offset: 0x00192A30
		[DebuggerNonUserCode]
		public void MergeFrom(GetVarResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x00194879 File Offset: 0x00192A79
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x00194884 File Offset: 0x00192A84
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
					this.Value = input.ReadString();
				}
			}
		}

		// Token: 0x04002F8D RID: 12173
		private static readonly MessageParser<GetVarResponse> _parser = new MessageParser<GetVarResponse>(() => new GetVarResponse());

		// Token: 0x04002F8E RID: 12174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F8F RID: 12175
		public const int ValueFieldNumber = 1;

		// Token: 0x04002F90 RID: 12176
		private static readonly string ValueDefaultValue = "";

		// Token: 0x04002F91 RID: 12177
		private string value_;
	}
}
