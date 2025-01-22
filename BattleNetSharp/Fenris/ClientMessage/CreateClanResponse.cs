using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000265 RID: 613
	public sealed class CreateClanResponse : IMessage<CreateClanResponse>, IMessage, IEquatable<CreateClanResponse>, IDeepCloneable<CreateClanResponse>, IBufferMessage
	{
		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060041E1 RID: 16865 RVA: 0x00100820 File Offset: 0x000FEA20
		[DebuggerNonUserCode]
		public static MessageParser<CreateClanResponse> Parser
		{
			get
			{
				return CreateClanResponse._parser;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x00100838 File Offset: 0x000FEA38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[85];
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x0010085C File Offset: 0x000FEA5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateClanResponse.Descriptor;
			}
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00100873 File Offset: 0x000FEA73
		[DebuggerNonUserCode]
		public CreateClanResponse()
		{
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x0010087D File Offset: 0x000FEA7D
		[DebuggerNonUserCode]
		public CreateClanResponse(CreateClanResponse other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x001008A4 File Offset: 0x000FEAA4
		[DebuggerNonUserCode]
		public CreateClanResponse Clone()
		{
			return new CreateClanResponse(this);
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x001008BC File Offset: 0x000FEABC
		// (set) Token: 0x060041E8 RID: 16872 RVA: 0x001008DD File Offset: 0x000FEADD
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? CreateClanResponse.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x001008F4 File Offset: 0x000FEAF4
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x0010090F File Offset: 0x000FEB0F
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x0010091C File Offset: 0x000FEB1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateClanResponse);
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x0010093C File Offset: 0x000FEB3C
		[DebuggerNonUserCode]
		public bool Equals(CreateClanResponse other)
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
					bool flag4 = this.ClanId != other.ClanId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00100994 File Offset: 0x000FEB94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x001009E0 File Offset: 0x000FEBE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x001009F8 File Offset: 0x000FEBF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x00100A04 File Offset: 0x000FEC04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x00100A50 File Offset: 0x000FEC50
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x00100AA0 File Offset: 0x000FECA0
		[DebuggerNonUserCode]
		public void MergeFrom(CreateClanResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x00100AE9 File Offset: 0x000FECE9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x00100AF4 File Offset: 0x000FECF4
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
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DE1 RID: 7649
		private static readonly MessageParser<CreateClanResponse> _parser = new MessageParser<CreateClanResponse>(() => new CreateClanResponse());

		// Token: 0x04001DE2 RID: 7650
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DE3 RID: 7651
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001DE4 RID: 7652
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001DE5 RID: 7653
		private string clanId_;
	}
}
