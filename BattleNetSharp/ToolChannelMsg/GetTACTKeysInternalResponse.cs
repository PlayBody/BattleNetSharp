using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000105 RID: 261
	public sealed class GetTACTKeysInternalResponse : IMessage<GetTACTKeysInternalResponse>, IMessage, IEquatable<GetTACTKeysInternalResponse>, IDeepCloneable<GetTACTKeysInternalResponse>, IBufferMessage
	{
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00058794 File Offset: 0x00056994
		[DebuggerNonUserCode]
		public static MessageParser<GetTACTKeysInternalResponse> Parser
		{
			get
			{
				return GetTACTKeysInternalResponse._parser;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x000587AC File Offset: 0x000569AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[238];
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x000587D4 File Offset: 0x000569D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTACTKeysInternalResponse.Descriptor;
			}
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000587EB File Offset: 0x000569EB
		[DebuggerNonUserCode]
		public GetTACTKeysInternalResponse()
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00058800 File Offset: 0x00056A00
		[DebuggerNonUserCode]
		public GetTACTKeysInternalResponse(GetTACTKeysInternalResponse other)
			: this()
		{
			this.keys_ = other.keys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0005882C File Offset: 0x00056A2C
		[DebuggerNonUserCode]
		public GetTACTKeysInternalResponse Clone()
		{
			return new GetTACTKeysInternalResponse(this);
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00058844 File Offset: 0x00056A44
		[DebuggerNonUserCode]
		public RepeatedField<TACTKeyInternal> Keys
		{
			get
			{
				return this.keys_;
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0005885C File Offset: 0x00056A5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTACTKeysInternalResponse);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0005887C File Offset: 0x00056A7C
		[DebuggerNonUserCode]
		public bool Equals(GetTACTKeysInternalResponse other)
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
					bool flag4 = !this.keys_.Equals(other.keys_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x000588D8 File Offset: 0x00056AD8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.keys_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00058918 File Offset: 0x00056B18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00058930 File Offset: 0x00056B30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0005893C File Offset: 0x00056B3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.keys_.WriteTo(ref output, GetTACTKeysInternalResponse._repeated_keys_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00058978 File Offset: 0x00056B78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.keys_.CalculateSize(GetTACTKeysInternalResponse._repeated_keys_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000589C0 File Offset: 0x00056BC0
		[DebuggerNonUserCode]
		public void MergeFrom(GetTACTKeysInternalResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.keys_.Add(other.keys_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00058A02 File Offset: 0x00056C02
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00058A10 File Offset: 0x00056C10
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
					this.keys_.AddEntriesFrom(ref input, GetTACTKeysInternalResponse._repeated_keys_codec);
				}
			}
		}

		// Token: 0x040009E3 RID: 2531
		private static readonly MessageParser<GetTACTKeysInternalResponse> _parser = new MessageParser<GetTACTKeysInternalResponse>(() => new GetTACTKeysInternalResponse());

		// Token: 0x040009E4 RID: 2532
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009E5 RID: 2533
		public const int KeysFieldNumber = 1;

		// Token: 0x040009E6 RID: 2534
		private static readonly FieldCodec<TACTKeyInternal> _repeated_keys_codec = FieldCodec.ForMessage<TACTKeyInternal>(10U, TACTKeyInternal.Parser);

		// Token: 0x040009E7 RID: 2535
		private readonly RepeatedField<TACTKeyInternal> keys_ = new RepeatedField<TACTKeyInternal>();
	}
}
