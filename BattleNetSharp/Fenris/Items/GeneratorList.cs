using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000165 RID: 357
	public sealed class GeneratorList : IMessage<GeneratorList>, IMessage, IEquatable<GeneratorList>, IDeepCloneable<GeneratorList>, IBufferMessage
	{
		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00090C90 File Offset: 0x0008EE90
		[DebuggerNonUserCode]
		public static MessageParser<GeneratorList> Parser
		{
			get
			{
				return GeneratorList._parser;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x00090CA8 File Offset: 0x0008EEA8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x00090CCC File Offset: 0x0008EECC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GeneratorList.Descriptor;
			}
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00090CE3 File Offset: 0x0008EEE3
		[DebuggerNonUserCode]
		public GeneratorList()
		{
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00090CF8 File Offset: 0x0008EEF8
		[DebuggerNonUserCode]
		public GeneratorList(GeneratorList other)
			: this()
		{
			this.generators_ = other.generators_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00090D24 File Offset: 0x0008EF24
		[DebuggerNonUserCode]
		public GeneratorList Clone()
		{
			return new GeneratorList(this);
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x00090D3C File Offset: 0x0008EF3C
		[DebuggerNonUserCode]
		public RepeatedField<Generator> Generators
		{
			get
			{
				return this.generators_;
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00090D54 File Offset: 0x0008EF54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GeneratorList);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00090D74 File Offset: 0x0008EF74
		[DebuggerNonUserCode]
		public bool Equals(GeneratorList other)
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
					bool flag4 = !this.generators_.Equals(other.generators_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00090DD0 File Offset: 0x0008EFD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.generators_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00090E10 File Offset: 0x0008F010
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00090E28 File Offset: 0x0008F028
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00090E34 File Offset: 0x0008F034
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.generators_.WriteTo(ref output, GeneratorList._repeated_generators_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00090E70 File Offset: 0x0008F070
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.generators_.CalculateSize(GeneratorList._repeated_generators_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00090EB8 File Offset: 0x0008F0B8
		[DebuggerNonUserCode]
		public void MergeFrom(GeneratorList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.generators_.Add(other.generators_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00090EFA File Offset: 0x0008F0FA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00090F08 File Offset: 0x0008F108
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
					this.generators_.AddEntriesFrom(ref input, GeneratorList._repeated_generators_codec);
				}
			}
		}

		// Token: 0x04001072 RID: 4210
		private static readonly MessageParser<GeneratorList> _parser = new MessageParser<GeneratorList>(() => new GeneratorList());

		// Token: 0x04001073 RID: 4211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001074 RID: 4212
		public const int GeneratorsFieldNumber = 1;

		// Token: 0x04001075 RID: 4213
		private static readonly FieldCodec<Generator> _repeated_generators_codec = FieldCodec.ForMessage<Generator>(10U, Generator.Parser);

		// Token: 0x04001076 RID: 4214
		private readonly RepeatedField<Generator> generators_ = new RepeatedField<Generator>();
	}
}
