using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200029C RID: 668
	public sealed class ConsumeConsoleEntitlementsResponse : IMessage<ConsumeConsoleEntitlementsResponse>, IMessage, IEquatable<ConsumeConsoleEntitlementsResponse>, IDeepCloneable<ConsumeConsoleEntitlementsResponse>, IBufferMessage
	{
		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x0010EAAC File Offset: 0x0010CCAC
		[DebuggerNonUserCode]
		public static MessageParser<ConsumeConsoleEntitlementsResponse> Parser
		{
			get
			{
				return ConsumeConsoleEntitlementsResponse._parser;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x0010EAC4 File Offset: 0x0010CCC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[140];
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x0010EAEC File Offset: 0x0010CCEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumeConsoleEntitlementsResponse.Descriptor;
			}
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x0010EB03 File Offset: 0x0010CD03
		[DebuggerNonUserCode]
		public ConsumeConsoleEntitlementsResponse()
		{
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x0010EB18 File Offset: 0x0010CD18
		[DebuggerNonUserCode]
		public ConsumeConsoleEntitlementsResponse(ConsumeConsoleEntitlementsResponse other)
			: this()
		{
			this.consumablesErrorState_ = other.consumablesErrorState_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0010EB44 File Offset: 0x0010CD44
		[DebuggerNonUserCode]
		public ConsumeConsoleEntitlementsResponse Clone()
		{
			return new ConsumeConsoleEntitlementsResponse(this);
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x0010EB5C File Offset: 0x0010CD5C
		[DebuggerNonUserCode]
		public RepeatedField<ConsumableErrorState> ConsumablesErrorState
		{
			get
			{
				return this.consumablesErrorState_;
			}
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0010EB74 File Offset: 0x0010CD74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumeConsoleEntitlementsResponse);
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x0010EB94 File Offset: 0x0010CD94
		[DebuggerNonUserCode]
		public bool Equals(ConsumeConsoleEntitlementsResponse other)
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
					bool flag4 = !this.consumablesErrorState_.Equals(other.consumablesErrorState_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x0010EBF0 File Offset: 0x0010CDF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.consumablesErrorState_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x0010EC30 File Offset: 0x0010CE30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x0010EC48 File Offset: 0x0010CE48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x0010EC54 File Offset: 0x0010CE54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.consumablesErrorState_.WriteTo(ref output, ConsumeConsoleEntitlementsResponse._repeated_consumablesErrorState_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x0010EC90 File Offset: 0x0010CE90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.consumablesErrorState_.CalculateSize(ConsumeConsoleEntitlementsResponse._repeated_consumablesErrorState_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x0010ECD8 File Offset: 0x0010CED8
		[DebuggerNonUserCode]
		public void MergeFrom(ConsumeConsoleEntitlementsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.consumablesErrorState_.Add(other.consumablesErrorState_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x0010ED1A File Offset: 0x0010CF1A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x0010ED28 File Offset: 0x0010CF28
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
					this.consumablesErrorState_.AddEntriesFrom(ref input, ConsumeConsoleEntitlementsResponse._repeated_consumablesErrorState_codec);
				}
			}
		}

		// Token: 0x04001F71 RID: 8049
		private static readonly MessageParser<ConsumeConsoleEntitlementsResponse> _parser = new MessageParser<ConsumeConsoleEntitlementsResponse>(() => new ConsumeConsoleEntitlementsResponse());

		// Token: 0x04001F72 RID: 8050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F73 RID: 8051
		public const int ConsumablesErrorStateFieldNumber = 1;

		// Token: 0x04001F74 RID: 8052
		private static readonly FieldCodec<ConsumableErrorState> _repeated_consumablesErrorState_codec = FieldCodec.ForMessage<ConsumableErrorState>(10U, ConsumableErrorState.Parser);

		// Token: 0x04001F75 RID: 8053
		private readonly RepeatedField<ConsumableErrorState> consumablesErrorState_ = new RepeatedField<ConsumableErrorState>();
	}
}
