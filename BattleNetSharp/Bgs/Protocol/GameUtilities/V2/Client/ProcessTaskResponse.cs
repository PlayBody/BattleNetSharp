using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Client
{
	// Token: 0x02000600 RID: 1536
	public sealed class ProcessTaskResponse : IMessage<ProcessTaskResponse>, IMessage, IEquatable<ProcessTaskResponse>, IDeepCloneable<ProcessTaskResponse>, IBufferMessage
	{
		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x06008FCB RID: 36811 RVA: 0x0022E064 File Offset: 0x0022C264
		[DebuggerNonUserCode]
		public static MessageParser<ProcessTaskResponse> Parser
		{
			get
			{
				return ProcessTaskResponse._parser;
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x06008FCC RID: 36812 RVA: 0x0022E07C File Offset: 0x0022C27C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x06008FCD RID: 36813 RVA: 0x0022E0A0 File Offset: 0x0022C2A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessTaskResponse.Descriptor;
			}
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x0022E0B7 File Offset: 0x0022C2B7
		[DebuggerNonUserCode]
		public ProcessTaskResponse()
		{
		}

		// Token: 0x06008FCF RID: 36815 RVA: 0x0022E0CC File Offset: 0x0022C2CC
		[DebuggerNonUserCode]
		public ProcessTaskResponse(ProcessTaskResponse other)
			: this()
		{
			this.result_ = other.result_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x0022E0F8 File Offset: 0x0022C2F8
		[DebuggerNonUserCode]
		public ProcessTaskResponse Clone()
		{
			return new ProcessTaskResponse(this);
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x0022E110 File Offset: 0x0022C310
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.Attribute> Result
		{
			get
			{
				return this.result_;
			}
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x0022E128 File Offset: 0x0022C328
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessTaskResponse);
		}

		// Token: 0x06008FD3 RID: 36819 RVA: 0x0022E148 File Offset: 0x0022C348
		[DebuggerNonUserCode]
		public bool Equals(ProcessTaskResponse other)
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
					bool flag4 = !this.result_.Equals(other.result_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x0022E1A4 File Offset: 0x0022C3A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.result_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x0022E1E4 File Offset: 0x0022C3E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FD6 RID: 36822 RVA: 0x0022E1FC File Offset: 0x0022C3FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FD7 RID: 36823 RVA: 0x0022E208 File Offset: 0x0022C408
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.result_.WriteTo(ref output, ProcessTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FD8 RID: 36824 RVA: 0x0022E244 File Offset: 0x0022C444
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.result_.CalculateSize(ProcessTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x0022E28C File Offset: 0x0022C48C
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessTaskResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.result_.Add(other.result_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x0022E2CE File Offset: 0x0022C4CE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x0022E2DC File Offset: 0x0022C4DC
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
					this.result_.AddEntriesFrom(ref input, ProcessTaskResponse._repeated_result_codec);
				}
			}
		}

		// Token: 0x040040F2 RID: 16626
		private static readonly MessageParser<ProcessTaskResponse> _parser = new MessageParser<ProcessTaskResponse>(() => new ProcessTaskResponse());

		// Token: 0x040040F3 RID: 16627
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040F4 RID: 16628
		public const int ResultFieldNumber = 1;

		// Token: 0x040040F5 RID: 16629
		private static readonly FieldCodec<Bgs.Protocol.Attribute> _repeated_result_codec = FieldCodec.ForMessage<Bgs.Protocol.Attribute>(10U, Attribute.Parser);

		// Token: 0x040040F6 RID: 16630
		private readonly RepeatedField<Bgs.Protocol.Attribute> result_ = new RepeatedField<Bgs.Protocol.Attribute>();
	}
}
