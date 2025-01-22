using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005EC RID: 1516
	public sealed class GetAllValuesForAttributeResponse : IMessage<GetAllValuesForAttributeResponse>, IMessage, IEquatable<GetAllValuesForAttributeResponse>, IDeepCloneable<GetAllValuesForAttributeResponse>, IBufferMessage
	{
		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x06008E87 RID: 36487 RVA: 0x00229474 File Offset: 0x00227674
		[DebuggerNonUserCode]
		public static MessageParser<GetAllValuesForAttributeResponse> Parser
		{
			get
			{
				return GetAllValuesForAttributeResponse._parser;
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x06008E88 RID: 36488 RVA: 0x0022948C File Offset: 0x0022768C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x06008E89 RID: 36489 RVA: 0x002294B0 File Offset: 0x002276B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllValuesForAttributeResponse.Descriptor;
			}
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x002294C7 File Offset: 0x002276C7
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeResponse()
		{
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x002294DC File Offset: 0x002276DC
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeResponse(GetAllValuesForAttributeResponse other)
			: this()
		{
			this.attributeValue_ = other.attributeValue_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x00229508 File Offset: 0x00227708
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeResponse Clone()
		{
			return new GetAllValuesForAttributeResponse(this);
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x06008E8D RID: 36493 RVA: 0x00229520 File Offset: 0x00227720
		[DebuggerNonUserCode]
		public RepeatedField<Variant> AttributeValue
		{
			get
			{
				return this.attributeValue_;
			}
		}

		// Token: 0x06008E8E RID: 36494 RVA: 0x00229538 File Offset: 0x00227738
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllValuesForAttributeResponse);
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x00229558 File Offset: 0x00227758
		[DebuggerNonUserCode]
		public bool Equals(GetAllValuesForAttributeResponse other)
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
					bool flag4 = !this.attributeValue_.Equals(other.attributeValue_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x002295B4 File Offset: 0x002277B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributeValue_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x002295F4 File Offset: 0x002277F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x0022960C File Offset: 0x0022780C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x00229618 File Offset: 0x00227818
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributeValue_.WriteTo(ref output, GetAllValuesForAttributeResponse._repeated_attributeValue_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x00229654 File Offset: 0x00227854
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributeValue_.CalculateSize(GetAllValuesForAttributeResponse._repeated_attributeValue_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x0022969C File Offset: 0x0022789C
		[DebuggerNonUserCode]
		public void MergeFrom(GetAllValuesForAttributeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attributeValue_.Add(other.attributeValue_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008E96 RID: 36502 RVA: 0x002296DE File Offset: 0x002278DE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E97 RID: 36503 RVA: 0x002296EC File Offset: 0x002278EC
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
					this.attributeValue_.AddEntriesFrom(ref input, GetAllValuesForAttributeResponse._repeated_attributeValue_codec);
				}
			}
		}

		// Token: 0x04004057 RID: 16471
		private static readonly MessageParser<GetAllValuesForAttributeResponse> _parser = new MessageParser<GetAllValuesForAttributeResponse>(() => new GetAllValuesForAttributeResponse());

		// Token: 0x04004058 RID: 16472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004059 RID: 16473
		public const int AttributeValueFieldNumber = 1;

		// Token: 0x0400405A RID: 16474
		private static readonly FieldCodec<Variant> _repeated_attributeValue_codec = FieldCodec.ForMessage<Variant>(10U, Variant.Parser);

		// Token: 0x0400405B RID: 16475
		private readonly RepeatedField<Variant> attributeValue_ = new RepeatedField<Variant>();
	}
}
