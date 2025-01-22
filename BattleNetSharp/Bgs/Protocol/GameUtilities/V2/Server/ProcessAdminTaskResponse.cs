using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005F3 RID: 1523
	public sealed class ProcessAdminTaskResponse : IMessage<ProcessAdminTaskResponse>, IMessage, IEquatable<ProcessAdminTaskResponse>, IDeepCloneable<ProcessAdminTaskResponse>, IBufferMessage
	{
		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x0022AEC4 File Offset: 0x002290C4
		[DebuggerNonUserCode]
		public static MessageParser<ProcessAdminTaskResponse> Parser
		{
			get
			{
				return ProcessAdminTaskResponse._parser;
			}
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x06008EE8 RID: 36584 RVA: 0x0022AEDC File Offset: 0x002290DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x06008EE9 RID: 36585 RVA: 0x0022AF00 File Offset: 0x00229100
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProcessAdminTaskResponse.Descriptor;
			}
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x0022AF17 File Offset: 0x00229117
		[DebuggerNonUserCode]
		public ProcessAdminTaskResponse()
		{
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x0022AF2C File Offset: 0x0022912C
		[DebuggerNonUserCode]
		public ProcessAdminTaskResponse(ProcessAdminTaskResponse other)
			: this()
		{
			this.result_ = other.result_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x0022AF58 File Offset: 0x00229158
		[DebuggerNonUserCode]
		public ProcessAdminTaskResponse Clone()
		{
			return new ProcessAdminTaskResponse(this);
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x06008EED RID: 36589 RVA: 0x0022AF70 File Offset: 0x00229170
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Result
		{
			get
			{
				return this.result_;
			}
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x0022AF88 File Offset: 0x00229188
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProcessAdminTaskResponse);
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x0022AFA8 File Offset: 0x002291A8
		[DebuggerNonUserCode]
		public bool Equals(ProcessAdminTaskResponse other)
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

		// Token: 0x06008EF0 RID: 36592 RVA: 0x0022B004 File Offset: 0x00229204
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

		// Token: 0x06008EF1 RID: 36593 RVA: 0x0022B044 File Offset: 0x00229244
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x0022B05C File Offset: 0x0022925C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x0022B068 File Offset: 0x00229268
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.result_.WriteTo(ref output, ProcessAdminTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EF4 RID: 36596 RVA: 0x0022B0A4 File Offset: 0x002292A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.result_.CalculateSize(ProcessAdminTaskResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x0022B0EC File Offset: 0x002292EC
		[DebuggerNonUserCode]
		public void MergeFrom(ProcessAdminTaskResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.result_.Add(other.result_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x0022B12E File Offset: 0x0022932E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x0022B13C File Offset: 0x0022933C
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
					this.result_.AddEntriesFrom(ref input, ProcessAdminTaskResponse._repeated_result_codec);
				}
			}
		}

		// Token: 0x04004092 RID: 16530
		private static readonly MessageParser<ProcessAdminTaskResponse> _parser = new MessageParser<ProcessAdminTaskResponse>(() => new ProcessAdminTaskResponse());

		// Token: 0x04004093 RID: 16531
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004094 RID: 16532
		public const int ResultFieldNumber = 1;

		// Token: 0x04004095 RID: 16533
		private static readonly FieldCodec<Attribute> _repeated_result_codec = FieldCodec.ForMessage<Attribute>(10U, Attribute.Parser);

		// Token: 0x04004096 RID: 16534
		private readonly RepeatedField<Attribute> result_ = new RepeatedField<Attribute>();
	}
}
