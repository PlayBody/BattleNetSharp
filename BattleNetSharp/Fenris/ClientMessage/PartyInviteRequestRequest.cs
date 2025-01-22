using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000249 RID: 585
	public sealed class PartyInviteRequestRequest : IMessage<PartyInviteRequestRequest>, IMessage, IEquatable<PartyInviteRequestRequest>, IDeepCloneable<PartyInviteRequestRequest>, IBufferMessage
	{
		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06003EEE RID: 16110 RVA: 0x000F6F5C File Offset: 0x000F515C
		[DebuggerNonUserCode]
		public static MessageParser<PartyInviteRequestRequest> Parser
		{
			get
			{
				return PartyInviteRequestRequest._parser;
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x000F6F74 File Offset: 0x000F5174
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[57];
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x000F6F98 File Offset: 0x000F5198
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyInviteRequestRequest.Descriptor;
			}
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x000F6FAF File Offset: 0x000F51AF
		[DebuggerNonUserCode]
		public PartyInviteRequestRequest()
		{
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x000F6FB9 File Offset: 0x000F51B9
		[DebuggerNonUserCode]
		public PartyInviteRequestRequest(PartyInviteRequestRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requesteeGameAccountId_ = other.requesteeGameAccountId_;
			this.requesterBattletag_ = other.requesterBattletag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x000F6FF8 File Offset: 0x000F51F8
		[DebuggerNonUserCode]
		public PartyInviteRequestRequest Clone()
		{
			return new PartyInviteRequestRequest(this);
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06003EF4 RID: 16116 RVA: 0x000F7010 File Offset: 0x000F5210
		// (set) Token: 0x06003EF5 RID: 16117 RVA: 0x000F7041 File Offset: 0x000F5241
		[DebuggerNonUserCode]
		public uint RequesteeGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint requesteeGameAccountIdDefaultValue;
				if (flag)
				{
					requesteeGameAccountIdDefaultValue = this.requesteeGameAccountId_;
				}
				else
				{
					requesteeGameAccountIdDefaultValue = PartyInviteRequestRequest.RequesteeGameAccountIdDefaultValue;
				}
				return requesteeGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requesteeGameAccountId_ = value;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x000F705C File Offset: 0x000F525C
		[DebuggerNonUserCode]
		public bool HasRequesteeGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x000F7079 File Offset: 0x000F5279
		[DebuggerNonUserCode]
		public void ClearRequesteeGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x000F708C File Offset: 0x000F528C
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x000F70AD File Offset: 0x000F52AD
		[DebuggerNonUserCode]
		public string RequesterBattletag
		{
			get
			{
				return this.requesterBattletag_ ?? PartyInviteRequestRequest.RequesterBattletagDefaultValue;
			}
			set
			{
				this.requesterBattletag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x000F70C4 File Offset: 0x000F52C4
		[DebuggerNonUserCode]
		public bool HasRequesterBattletag
		{
			get
			{
				return this.requesterBattletag_ != null;
			}
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x000F70DF File Offset: 0x000F52DF
		[DebuggerNonUserCode]
		public void ClearRequesterBattletag()
		{
			this.requesterBattletag_ = null;
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x000F70EC File Offset: 0x000F52EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyInviteRequestRequest);
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x000F710C File Offset: 0x000F530C
		[DebuggerNonUserCode]
		public bool Equals(PartyInviteRequestRequest other)
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
					bool flag4 = this.RequesteeGameAccountId != other.RequesteeGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RequesterBattletag != other.RequesterBattletag;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x000F7180 File Offset: 0x000F5380
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				num ^= this.RequesteeGameAccountId.GetHashCode();
			}
			bool hasRequesterBattletag = this.HasRequesterBattletag;
			if (hasRequesterBattletag)
			{
				num ^= this.RequesterBattletag.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x000F71EC File Offset: 0x000F53EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x000F7204 File Offset: 0x000F5404
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x000F7210 File Offset: 0x000F5410
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RequesteeGameAccountId);
			}
			bool hasRequesterBattletag = this.HasRequesterBattletag;
			if (hasRequesterBattletag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.RequesterBattletag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x000F7280 File Offset: 0x000F5480
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequesteeGameAccountId = this.HasRequesteeGameAccountId;
			if (hasRequesteeGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RequesteeGameAccountId);
			}
			bool hasRequesterBattletag = this.HasRequesterBattletag;
			if (hasRequesterBattletag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RequesterBattletag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x000F72EC File Offset: 0x000F54EC
		[DebuggerNonUserCode]
		public void MergeFrom(PartyInviteRequestRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequesteeGameAccountId = other.HasRequesteeGameAccountId;
				if (hasRequesteeGameAccountId)
				{
					this.RequesteeGameAccountId = other.RequesteeGameAccountId;
				}
				bool hasRequesterBattletag = other.HasRequesterBattletag;
				if (hasRequesterBattletag)
				{
					this.RequesterBattletag = other.RequesterBattletag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x000F734E File Offset: 0x000F554E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x000F735C File Offset: 0x000F555C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RequesterBattletag = input.ReadString();
					}
				}
				else
				{
					this.RequesteeGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CB5 RID: 7349
		private static readonly MessageParser<PartyInviteRequestRequest> _parser = new MessageParser<PartyInviteRequestRequest>(() => new PartyInviteRequestRequest());

		// Token: 0x04001CB6 RID: 7350
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CB7 RID: 7351
		private int _hasBits0;

		// Token: 0x04001CB8 RID: 7352
		public const int RequesteeGameAccountIdFieldNumber = 1;

		// Token: 0x04001CB9 RID: 7353
		private static readonly uint RequesteeGameAccountIdDefaultValue = 0U;

		// Token: 0x04001CBA RID: 7354
		private uint requesteeGameAccountId_;

		// Token: 0x04001CBB RID: 7355
		public const int RequesterBattletagFieldNumber = 2;

		// Token: 0x04001CBC RID: 7356
		private static readonly string RequesterBattletagDefaultValue = "";

		// Token: 0x04001CBD RID: 7357
		private string requesterBattletag_;
	}
}
