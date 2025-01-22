using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200068D RID: 1677
	public sealed class GetPublicChannelTypesOptions : IMessage<GetPublicChannelTypesOptions>, IMessage, IEquatable<GetPublicChannelTypesOptions>, IDeepCloneable<GetPublicChannelTypesOptions>, IBufferMessage
	{
		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x06009B89 RID: 39817 RVA: 0x0025CA20 File Offset: 0x0025AC20
		[DebuggerNonUserCode]
		public static MessageParser<GetPublicChannelTypesOptions> Parser
		{
			get
			{
				return GetPublicChannelTypesOptions._parser;
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x06009B8A RID: 39818 RVA: 0x0025CA38 File Offset: 0x0025AC38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x06009B8B RID: 39819 RVA: 0x0025CA5C File Offset: 0x0025AC5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPublicChannelTypesOptions.Descriptor;
			}
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x0025CA73 File Offset: 0x0025AC73
		[DebuggerNonUserCode]
		public GetPublicChannelTypesOptions()
		{
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x0025CA7D File Offset: 0x0025AC7D
		[DebuggerNonUserCode]
		public GetPublicChannelTypesOptions(GetPublicChannelTypesOptions other)
			: this()
		{
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x0025CAB4 File Offset: 0x0025ACB4
		[DebuggerNonUserCode]
		public GetPublicChannelTypesOptions Clone()
		{
			return new GetPublicChannelTypesOptions(this);
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x06009B8F RID: 39823 RVA: 0x0025CACC File Offset: 0x0025ACCC
		// (set) Token: 0x06009B90 RID: 39824 RVA: 0x0025CAE4 File Offset: 0x0025ACE4
		[DebuggerNonUserCode]
		public UniqueChannelType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06009B91 RID: 39825 RVA: 0x0025CAF0 File Offset: 0x0025ACF0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPublicChannelTypesOptions);
		}

		// Token: 0x06009B92 RID: 39826 RVA: 0x0025CB10 File Offset: 0x0025AD10
		[DebuggerNonUserCode]
		public bool Equals(GetPublicChannelTypesOptions other)
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
					bool flag4 = !object.Equals(this.Type, other.Type);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x0025CB6C File Offset: 0x0025AD6C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.type_ != null;
			if (flag)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x0025CBBC File Offset: 0x0025ADBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x0025CBD4 File Offset: 0x0025ADD4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x0025CBE0 File Offset: 0x0025ADE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.type_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Type);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B97 RID: 39831 RVA: 0x0025CC30 File Offset: 0x0025AE30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.type_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x0025CC84 File Offset: 0x0025AE84
		[DebuggerNonUserCode]
		public void MergeFrom(GetPublicChannelTypesOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.type_ != null;
				if (flag2)
				{
					bool flag3 = this.type_ == null;
					if (flag3)
					{
						this.Type = new UniqueChannelType();
					}
					this.Type.MergeFrom(other.Type);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x0025CCF0 File Offset: 0x0025AEF0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x0025CCFC File Offset: 0x0025AEFC
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
					bool flag = this.type_ == null;
					if (flag)
					{
						this.Type = new UniqueChannelType();
					}
					input.ReadMessage(this.Type);
				}
			}
		}

		// Token: 0x0400462A RID: 17962
		private static readonly MessageParser<GetPublicChannelTypesOptions> _parser = new MessageParser<GetPublicChannelTypesOptions>(() => new GetPublicChannelTypesOptions());

		// Token: 0x0400462B RID: 17963
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400462C RID: 17964
		public const int TypeFieldNumber = 1;

		// Token: 0x0400462D RID: 17965
		private UniqueChannelType type_;
	}
}
