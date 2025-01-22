using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F7 RID: 1527
	public sealed class ProcessServerTaskResponse : IMessage<ProcessServerTaskResponse>, IMessage, IEquatable<ProcessServerTaskResponse>, IDeepCloneable<ProcessServerTaskResponse>, IBufferMessage
	{
		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x06008F33 RID: 36659 RVA: 0x0022BD78 File Offset: 0x00229F78
		[DebuggerNonUserCode]
		public static MessageParser<ProcessServerTaskResponse> Parser
		{
			get
			{
				return ProcessServerTaskResponse._parser;
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x06008F34 RID: 36660 RVA: 0x0022BD90 File Offset: 0x00229F90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x06008F35 RID: 36661 RVA: 0x0022BDB4 File Offset: 0x00229FB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessServerTaskResponse.Descriptor;
			}
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x0022BDCB File Offset: 0x00229FCB
		[DebuggerNonUserCode]
		public ProcessServerTaskResponse()
		{
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x0022BDE0 File Offset: 0x00229FE0
		[DebuggerNonUserCode]
		public ProcessServerTaskResponse(ProcessServerTaskResponse other)
			: this()
		{
			this.result_ = other.result_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x0022BE0C File Offset: 0x0022A00C
		[DebuggerNonUserCode]
		public ProcessServerTaskResponse Clone()
		{
			return new ProcessServerTaskResponse(this);
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x06008F39 RID: 36665 RVA: 0x0022BE24 File Offset: 0x0022A024
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Result
		{
			get
			{
				return this.result_;
			}
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x0022BE3C File Offset: 0x0022A03C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessServerTaskResponse);
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x0022BE5C File Offset: 0x0022A05C
		[DebuggerNonUserCode]
		public bool Equals(ProcessServerTaskResponse other)
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

		// Token: 0x06008F3C RID: 36668 RVA: 0x0022BEB8 File Offset: 0x0022A0B8
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

		// Token: 0x06008F3D RID: 36669 RVA: 0x0022BEF8 File Offset: 0x0022A0F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x0022BF10 File Offset: 0x0022A110
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x0022BF1C File Offset: 0x0022A11C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.result_.WriteTo(ref output, ProcessServerTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F40 RID: 36672 RVA: 0x0022BF58 File Offset: 0x0022A158
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.result_.CalculateSize(ProcessServerTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x0022BFA0 File Offset: 0x0022A1A0
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessServerTaskResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.result_.Add(other.result_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x0022BFE2 File Offset: 0x0022A1E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x0022BFF0 File Offset: 0x0022A1F0
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
					this.result_.AddEntriesFrom(ref input, ProcessServerTaskResponse._repeated_result_codec);
				}
			}
		}

		// Token: 0x040040AE RID: 16558
		private static readonly MessageParser<ProcessServerTaskResponse> _parser = new MessageParser<ProcessServerTaskResponse>(() => new ProcessServerTaskResponse());

		// Token: 0x040040AF RID: 16559
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040B0 RID: 16560
		public const int ResultFieldNumber = 1;

		// Token: 0x040040B1 RID: 16561
		private static readonly FieldCodec<Attribute> _repeated_result_codec = FieldCodec.ForMessage<Attribute>(10U, Attribute.Parser);

		// Token: 0x040040B2 RID: 16562
		private readonly RepeatedField<Attribute> result_ = new RepeatedField<Attribute>();
	}
}
