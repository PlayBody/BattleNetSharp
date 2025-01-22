using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000279 RID: 633
	public sealed class SubscribeToClanBankChangesResponse : IMessage<SubscribeToClanBankChangesResponse>, IMessage, IEquatable<SubscribeToClanBankChangesResponse>, IDeepCloneable<SubscribeToClanBankChangesResponse>, IBufferMessage
	{
		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x001058E4 File Offset: 0x00103AE4
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeToClanBankChangesResponse> Parser
		{
			get
			{
				return SubscribeToClanBankChangesResponse._parser;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x060043AA RID: 17322 RVA: 0x001058FC File Offset: 0x00103AFC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[105];
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x00105920 File Offset: 0x00103B20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeToClanBankChangesResponse.Descriptor;
			}
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00105937 File Offset: 0x00103B37
		[DebuggerNonUserCode]
		public SubscribeToClanBankChangesResponse()
		{
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00105941 File Offset: 0x00103B41
		[DebuggerNonUserCode]
		public SubscribeToClanBankChangesResponse(SubscribeToClanBankChangesResponse other)
			: this()
		{
			this.clanBank_ = ((other.clanBank_ != null) ? other.clanBank_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00105978 File Offset: 0x00103B78
		[DebuggerNonUserCode]
		public SubscribeToClanBankChangesResponse Clone()
		{
			return new SubscribeToClanBankChangesResponse(this);
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x060043AF RID: 17327 RVA: 0x00105990 File Offset: 0x00103B90
		// (set) Token: 0x060043B0 RID: 17328 RVA: 0x001059A8 File Offset: 0x00103BA8
		[DebuggerNonUserCode]
		public ClanBank ClanBank
		{
			get
			{
				return this.clanBank_;
			}
			set
			{
				this.clanBank_ = value;
			}
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x001059B4 File Offset: 0x00103BB4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeToClanBankChangesResponse);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x001059D4 File Offset: 0x00103BD4
		[DebuggerNonUserCode]
		public bool Equals(SubscribeToClanBankChangesResponse other)
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
					bool flag4 = !object.Equals(this.ClanBank, other.ClanBank);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00105A30 File Offset: 0x00103C30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.clanBank_ != null;
			if (flag)
			{
				num ^= this.ClanBank.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x00105A80 File Offset: 0x00103C80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x00105A98 File Offset: 0x00103C98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x00105AA4 File Offset: 0x00103CA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.clanBank_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ClanBank);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00105AF4 File Offset: 0x00103CF4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.clanBank_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClanBank);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00105B48 File Offset: 0x00103D48
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeToClanBankChangesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.clanBank_ != null;
				if (flag2)
				{
					bool flag3 = this.clanBank_ == null;
					if (flag3)
					{
						this.ClanBank = new ClanBank();
					}
					this.ClanBank.MergeFrom(other.ClanBank);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00105BB4 File Offset: 0x00103DB4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00105BC0 File Offset: 0x00103DC0
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
					bool flag = this.clanBank_ == null;
					if (flag)
					{
						this.ClanBank = new ClanBank();
					}
					input.ReadMessage(this.ClanBank);
				}
			}
		}

		// Token: 0x04001E6E RID: 7790
		private static readonly MessageParser<SubscribeToClanBankChangesResponse> _parser = new MessageParser<SubscribeToClanBankChangesResponse>(() => new SubscribeToClanBankChangesResponse());

		// Token: 0x04001E6F RID: 7791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E70 RID: 7792
		public const int ClanBankFieldNumber = 1;

		// Token: 0x04001E71 RID: 7793
		private ClanBank clanBank_;
	}
}
