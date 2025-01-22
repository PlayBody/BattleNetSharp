using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Client
{
	// Token: 0x02000602 RID: 1538
	public sealed class GetAllValuesForAttributeResponse : IMessage<GetAllValuesForAttributeResponse>, IMessage, IEquatable<GetAllValuesForAttributeResponse>, IDeepCloneable<GetAllValuesForAttributeResponse>, IBufferMessage
	{
		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x06008FF2 RID: 36850 RVA: 0x0022E6AC File Offset: 0x0022C8AC
		[DebuggerNonUserCode]
		public static MessageParser<GetAllValuesForAttributeResponse> Parser
		{
			get
			{
				return GetAllValuesForAttributeResponse._parser;
			}
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x06008FF3 RID: 36851 RVA: 0x0022E6C4 File Offset: 0x0022C8C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x06008FF4 RID: 36852 RVA: 0x0022E6E8 File Offset: 0x0022C8E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllValuesForAttributeResponse.Descriptor;
			}
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x0022E6FF File Offset: 0x0022C8FF
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeResponse()
		{
		}

		// Token: 0x06008FF6 RID: 36854 RVA: 0x0022E714 File Offset: 0x0022C914
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeResponse(GetAllValuesForAttributeResponse other)
			: this()
		{
			this.attributeValue_ = other.attributeValue_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FF7 RID: 36855 RVA: 0x0022E740 File Offset: 0x0022C940
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeResponse Clone()
		{
			return new GetAllValuesForAttributeResponse(this);
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x06008FF8 RID: 36856 RVA: 0x0022E758 File Offset: 0x0022C958
		[DebuggerNonUserCode]
		public RepeatedField<Variant> AttributeValue
		{
			get
			{
				return this.attributeValue_;
			}
		}

		// Token: 0x06008FF9 RID: 36857 RVA: 0x0022E770 File Offset: 0x0022C970
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllValuesForAttributeResponse);
		}

		// Token: 0x06008FFA RID: 36858 RVA: 0x0022E790 File Offset: 0x0022C990
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

		// Token: 0x06008FFB RID: 36859 RVA: 0x0022E7EC File Offset: 0x0022C9EC
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

		// Token: 0x06008FFC RID: 36860 RVA: 0x0022E82C File Offset: 0x0022CA2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0022E844 File Offset: 0x0022CA44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x0022E850 File Offset: 0x0022CA50
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

		// Token: 0x06008FFF RID: 36863 RVA: 0x0022E88C File Offset: 0x0022CA8C
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

		// Token: 0x06009000 RID: 36864 RVA: 0x0022E8D4 File Offset: 0x0022CAD4
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

		// Token: 0x06009001 RID: 36865 RVA: 0x0022E916 File Offset: 0x0022CB16
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009002 RID: 36866 RVA: 0x0022E924 File Offset: 0x0022CB24
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

		// Token: 0x040040FC RID: 16636
		private static readonly MessageParser<GetAllValuesForAttributeResponse> _parser = new MessageParser<GetAllValuesForAttributeResponse>(() => new GetAllValuesForAttributeResponse());

		// Token: 0x040040FD RID: 16637
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040FE RID: 16638
		public const int AttributeValueFieldNumber = 1;

		// Token: 0x040040FF RID: 16639
		private static readonly FieldCodec<Variant> _repeated_attributeValue_codec = FieldCodec.ForMessage<Variant>(10U, Variant.Parser);

		// Token: 0x04004100 RID: 16640
		private readonly RepeatedField<Variant> attributeValue_ = new RepeatedField<Variant>();
	}
}
