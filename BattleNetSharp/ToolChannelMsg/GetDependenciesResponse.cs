using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000057 RID: 87
	public sealed class GetDependenciesResponse : IMessage<GetDependenciesResponse>, IMessage, IEquatable<GetDependenciesResponse>, IDeepCloneable<GetDependenciesResponse>, IBufferMessage
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0001F4D4 File Offset: 0x0001D6D4
		[DebuggerNonUserCode]
		public static MessageParser<GetDependenciesResponse> Parser
		{
			get
			{
				return GetDependenciesResponse._parser;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0001F4EC File Offset: 0x0001D6EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[64];
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0001F510 File Offset: 0x0001D710
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDependenciesResponse.Descriptor;
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001F527 File Offset: 0x0001D727
		[DebuggerNonUserCode]
		public GetDependenciesResponse()
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0001F53C File Offset: 0x0001D73C
		[DebuggerNonUserCode]
		public GetDependenciesResponse(GetDependenciesResponse other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0001F568 File Offset: 0x0001D768
		[DebuggerNonUserCode]
		public GetDependenciesResponse Clone()
		{
			return new GetDependenciesResponse(this);
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0001F580 File Offset: 0x0001D780
		[DebuggerNonUserCode]
		public RepeatedField<SNOName> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0001F598 File Offset: 0x0001D798
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDependenciesResponse);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001F5B8 File Offset: 0x0001D7B8
		[DebuggerNonUserCode]
		public bool Equals(GetDependenciesResponse other)
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
					bool flag4 = !this.list_.Equals(other.list_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0001F614 File Offset: 0x0001D814
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.list_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001F654 File Offset: 0x0001D854
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001F66C File Offset: 0x0001D86C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001F678 File Offset: 0x0001D878
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, GetDependenciesResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001F6B4 File Offset: 0x0001D8B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(GetDependenciesResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0001F6FC File Offset: 0x0001D8FC
		[DebuggerNonUserCode]
		public void MergeFrom(GetDependenciesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001F73E File Offset: 0x0001D93E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001F74C File Offset: 0x0001D94C
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
					this.list_.AddEntriesFrom(ref input, GetDependenciesResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x04000302 RID: 770
		private static readonly MessageParser<GetDependenciesResponse> _parser = new MessageParser<GetDependenciesResponse>(() => new GetDependenciesResponse());

		// Token: 0x04000303 RID: 771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000304 RID: 772
		public const int ListFieldNumber = 1;

		// Token: 0x04000305 RID: 773
		private static readonly FieldCodec<SNOName> _repeated_list_codec = FieldCodec.ForMessage<SNOName>(10U, SNOName.Parser);

		// Token: 0x04000306 RID: 774
		private readonly RepeatedField<SNOName> list_ = new RepeatedField<SNOName>();
	}
}
