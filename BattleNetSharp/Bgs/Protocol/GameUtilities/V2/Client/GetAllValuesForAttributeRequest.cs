using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Client
{
	// Token: 0x02000601 RID: 1537
	public sealed class GetAllValuesForAttributeRequest : IMessage<GetAllValuesForAttributeRequest>, IMessage, IEquatable<GetAllValuesForAttributeRequest>, IDeepCloneable<GetAllValuesForAttributeRequest>, IBufferMessage
	{
		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x06008FDD RID: 36829 RVA: 0x0022E360 File Offset: 0x0022C560
		[DebuggerNonUserCode]
		public static MessageParser<GetAllValuesForAttributeRequest> Parser
		{
			get
			{
				return GetAllValuesForAttributeRequest._parser;
			}
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x06008FDE RID: 36830 RVA: 0x0022E378 File Offset: 0x0022C578
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x06008FDF RID: 36831 RVA: 0x0022E39C File Offset: 0x0022C59C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllValuesForAttributeRequest.Descriptor;
			}
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x0022E3B3 File Offset: 0x0022C5B3
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeRequest()
		{
		}

		// Token: 0x06008FE1 RID: 36833 RVA: 0x0022E3BD File Offset: 0x0022C5BD
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeRequest(GetAllValuesForAttributeRequest other)
			: this()
		{
			this.attributeKey_ = other.attributeKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0022E3E4 File Offset: 0x0022C5E4
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeRequest Clone()
		{
			return new GetAllValuesForAttributeRequest(this);
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x06008FE3 RID: 36835 RVA: 0x0022E3FC File Offset: 0x0022C5FC
		// (set) Token: 0x06008FE4 RID: 36836 RVA: 0x0022E41D File Offset: 0x0022C61D
		[DebuggerNonUserCode]
		public string AttributeKey
		{
			get
			{
				return this.attributeKey_ ?? GetAllValuesForAttributeRequest.AttributeKeyDefaultValue;
			}
			set
			{
				this.attributeKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x06008FE5 RID: 36837 RVA: 0x0022E434 File Offset: 0x0022C634
		[DebuggerNonUserCode]
		public bool HasAttributeKey
		{
			get
			{
				return this.attributeKey_ != null;
			}
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x0022E44F File Offset: 0x0022C64F
		[DebuggerNonUserCode]
		public void ClearAttributeKey()
		{
			this.attributeKey_ = null;
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0022E45C File Offset: 0x0022C65C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllValuesForAttributeRequest);
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0022E47C File Offset: 0x0022C67C
		[DebuggerNonUserCode]
		public bool Equals(GetAllValuesForAttributeRequest other)
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
					bool flag4 = this.AttributeKey != other.AttributeKey;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0022E4D4 File Offset: 0x0022C6D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAttributeKey = this.HasAttributeKey;
			if (hasAttributeKey)
			{
				num ^= this.AttributeKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x0022E520 File Offset: 0x0022C720
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x0022E538 File Offset: 0x0022C738
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x0022E544 File Offset: 0x0022C744
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAttributeKey = this.HasAttributeKey;
			if (hasAttributeKey)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AttributeKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x0022E590 File Offset: 0x0022C790
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAttributeKey = this.HasAttributeKey;
			if (hasAttributeKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AttributeKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x0022E5E0 File Offset: 0x0022C7E0
		[DebuggerNonUserCode]
		public void MergeFrom(GetAllValuesForAttributeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAttributeKey = other.HasAttributeKey;
				if (hasAttributeKey)
				{
					this.AttributeKey = other.AttributeKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x0022E629 File Offset: 0x0022C829
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x0022E634 File Offset: 0x0022C834
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
					this.AttributeKey = input.ReadString();
				}
			}
		}

		// Token: 0x040040F7 RID: 16631
		private static readonly MessageParser<GetAllValuesForAttributeRequest> _parser = new MessageParser<GetAllValuesForAttributeRequest>(() => new GetAllValuesForAttributeRequest());

		// Token: 0x040040F8 RID: 16632
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040F9 RID: 16633
		public const int AttributeKeyFieldNumber = 1;

		// Token: 0x040040FA RID: 16634
		private static readonly string AttributeKeyDefaultValue = "";

		// Token: 0x040040FB RID: 16635
		private string attributeKey_;
	}
}
