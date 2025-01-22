using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200005F RID: 95
	public sealed class GlobalGBIDList : IMessage<GlobalGBIDList>, IMessage, IEquatable<GlobalGBIDList>, IDeepCloneable<GlobalGBIDList>, IBufferMessage
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00021FB0 File Offset: 0x000201B0
		[DebuggerNonUserCode]
		public static MessageParser<GlobalGBIDList> Parser
		{
			get
			{
				return GlobalGBIDList._parser;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00021FC8 File Offset: 0x000201C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[72];
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00021FEC File Offset: 0x000201EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalGBIDList.Descriptor;
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00022003 File Offset: 0x00020203
		[DebuggerNonUserCode]
		public GlobalGBIDList()
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00022018 File Offset: 0x00020218
		[DebuggerNonUserCode]
		public GlobalGBIDList(GlobalGBIDList other)
			: this()
		{
			this.gbidEntries_ = other.gbidEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00022044 File Offset: 0x00020244
		[DebuggerNonUserCode]
		public GlobalGBIDList Clone()
		{
			return new GlobalGBIDList(this);
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0002205C File Offset: 0x0002025C
		[DebuggerNonUserCode]
		public RepeatedField<int> GbidEntries
		{
			get
			{
				return this.gbidEntries_;
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00022074 File Offset: 0x00020274
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalGBIDList);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00022094 File Offset: 0x00020294
		[DebuggerNonUserCode]
		public bool Equals(GlobalGBIDList other)
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
					bool flag4 = !this.gbidEntries_.Equals(other.gbidEntries_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000220F0 File Offset: 0x000202F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gbidEntries_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00022130 File Offset: 0x00020330
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00022148 File Offset: 0x00020348
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00022154 File Offset: 0x00020354
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gbidEntries_.WriteTo(ref output, GlobalGBIDList._repeated_gbidEntries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00022190 File Offset: 0x00020390
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gbidEntries_.CalculateSize(GlobalGBIDList._repeated_gbidEntries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000221D8 File Offset: 0x000203D8
		[DebuggerNonUserCode]
		public void MergeFrom(GlobalGBIDList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.gbidEntries_.Add(other.gbidEntries_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0002221A File Offset: 0x0002041A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00022228 File Offset: 0x00020428
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gbidEntries_.AddEntriesFrom(ref input, GlobalGBIDList._repeated_gbidEntries_codec);
				}
			}
		}

		// Token: 0x04000357 RID: 855
		private static readonly MessageParser<GlobalGBIDList> _parser = new MessageParser<GlobalGBIDList>(() => new GlobalGBIDList());

		// Token: 0x04000358 RID: 856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000359 RID: 857
		public const int GbidEntriesFieldNumber = 1;

		// Token: 0x0400035A RID: 858
		private static readonly FieldCodec<int> _repeated_gbidEntries_codec = FieldCodec.ForInt32(8U);

		// Token: 0x0400035B RID: 859
		private readonly RepeatedField<int> gbidEntries_ = new RepeatedField<int>();
	}
}
