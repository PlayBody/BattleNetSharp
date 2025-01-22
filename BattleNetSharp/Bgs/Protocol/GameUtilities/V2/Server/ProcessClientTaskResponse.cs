using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F5 RID: 1525
	public sealed class ProcessClientTaskResponse : IMessage<ProcessClientTaskResponse>, IMessage, IEquatable<ProcessClientTaskResponse>, IDeepCloneable<ProcessClientTaskResponse>, IBufferMessage
	{
		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x0022B6C0 File Offset: 0x002298C0
		[DebuggerNonUserCode]
		public static MessageParser<ProcessClientTaskResponse> Parser
		{
			get
			{
				return ProcessClientTaskResponse._parser;
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x06008F0F RID: 36623 RVA: 0x0022B6D8 File Offset: 0x002298D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x06008F10 RID: 36624 RVA: 0x0022B6FC File Offset: 0x002298FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessClientTaskResponse.Descriptor;
			}
		}

		// Token: 0x06008F11 RID: 36625 RVA: 0x0022B713 File Offset: 0x00229913
		[DebuggerNonUserCode]
		public ProcessClientTaskResponse()
		{
		}

		// Token: 0x06008F12 RID: 36626 RVA: 0x0022B728 File Offset: 0x00229928
		[DebuggerNonUserCode]
		public ProcessClientTaskResponse(ProcessClientTaskResponse other)
			: this()
		{
			this.result_ = other.result_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F13 RID: 36627 RVA: 0x0022B754 File Offset: 0x00229954
		[DebuggerNonUserCode]
		public ProcessClientTaskResponse Clone()
		{
			return new ProcessClientTaskResponse(this);
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x06008F14 RID: 36628 RVA: 0x0022B76C File Offset: 0x0022996C
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Result
		{
			get
			{
				return this.result_;
			}
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x0022B784 File Offset: 0x00229984
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessClientTaskResponse);
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x0022B7A4 File Offset: 0x002299A4
		[DebuggerNonUserCode]
		public bool Equals(ProcessClientTaskResponse other)
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

		// Token: 0x06008F17 RID: 36631 RVA: 0x0022B800 File Offset: 0x00229A00
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

		// Token: 0x06008F18 RID: 36632 RVA: 0x0022B840 File Offset: 0x00229A40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x0022B858 File Offset: 0x00229A58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x0022B864 File Offset: 0x00229A64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.result_.WriteTo(ref output, ProcessClientTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x0022B8A0 File Offset: 0x00229AA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.result_.CalculateSize(ProcessClientTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F1C RID: 36636 RVA: 0x0022B8E8 File Offset: 0x00229AE8
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessClientTaskResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.result_.Add(other.result_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x0022B92A File Offset: 0x00229B2A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x0022B938 File Offset: 0x00229B38
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
					this.result_.AddEntriesFrom(ref input, ProcessClientTaskResponse._repeated_result_codec);
				}
			}
		}

		// Token: 0x040040A1 RID: 16545
		private static readonly MessageParser<ProcessClientTaskResponse> _parser = new MessageParser<ProcessClientTaskResponse>(() => new ProcessClientTaskResponse());

		// Token: 0x040040A2 RID: 16546
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040A3 RID: 16547
		public const int ResultFieldNumber = 1;

		// Token: 0x040040A4 RID: 16548
		private static readonly FieldCodec<Attribute> _repeated_result_codec = FieldCodec.ForMessage<Attribute>(10U, Attribute.Parser);

		// Token: 0x040040A5 RID: 16549
		private readonly RepeatedField<Attribute> result_ = new RepeatedField<Attribute>();
	}
}
