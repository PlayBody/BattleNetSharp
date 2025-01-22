using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000720 RID: 1824
	public sealed class GetGameTimeRemainingInfoRequest : IMessage<GetGameTimeRemainingInfoRequest>, IMessage, IEquatable<GetGameTimeRemainingInfoRequest>, IDeepCloneable<GetGameTimeRemainingInfoRequest>, IBufferMessage
	{
		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600A723 RID: 42787 RVA: 0x0028A948 File Offset: 0x00288B48
		[DebuggerNonUserCode]
		public static MessageParser<GetGameTimeRemainingInfoRequest> Parser
		{
			get
			{
				return GetGameTimeRemainingInfoRequest._parser;
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600A724 RID: 42788 RVA: 0x0028A960 File Offset: 0x00288B60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600A725 RID: 42789 RVA: 0x0028A984 File Offset: 0x00288B84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameTimeRemainingInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x0028A99B File Offset: 0x00288B9B
		[DebuggerNonUserCode]
		public GetGameTimeRemainingInfoRequest()
		{
		}

		// Token: 0x0600A727 RID: 42791 RVA: 0x0028A9A8 File Offset: 0x00288BA8
		[DebuggerNonUserCode]
		public GetGameTimeRemainingInfoRequest(GetGameTimeRemainingInfoRequest other)
			: this()
		{
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.benefactorId_ = other.benefactorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A728 RID: 42792 RVA: 0x0028AA14 File Offset: 0x00288C14
		[DebuggerNonUserCode]
		public GetGameTimeRemainingInfoRequest Clone()
		{
			return new GetGameTimeRemainingInfoRequest(this);
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600A729 RID: 42793 RVA: 0x0028AA2C File Offset: 0x00288C2C
		// (set) Token: 0x0600A72A RID: 42794 RVA: 0x0028AA44 File Offset: 0x00288C44
		[DebuggerNonUserCode]
		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600A72B RID: 42795 RVA: 0x0028AA50 File Offset: 0x00288C50
		// (set) Token: 0x0600A72C RID: 42796 RVA: 0x0028AA68 File Offset: 0x00288C68
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600A72D RID: 42797 RVA: 0x0028AA74 File Offset: 0x00288C74
		// (set) Token: 0x0600A72E RID: 42798 RVA: 0x0028AA95 File Offset: 0x00288C95
		[DebuggerNonUserCode]
		public string BenefactorId
		{
			get
			{
				return this.benefactorId_ ?? GetGameTimeRemainingInfoRequest.BenefactorIdDefaultValue;
			}
			set
			{
				this.benefactorId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600A72F RID: 42799 RVA: 0x0028AAAC File Offset: 0x00288CAC
		[DebuggerNonUserCode]
		public bool HasBenefactorId
		{
			get
			{
				return this.benefactorId_ != null;
			}
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x0028AAC7 File Offset: 0x00288CC7
		[DebuggerNonUserCode]
		public void ClearBenefactorId()
		{
			this.benefactorId_ = null;
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x0028AAD4 File Offset: 0x00288CD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameTimeRemainingInfoRequest);
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x0028AAF4 File Offset: 0x00288CF4
		[DebuggerNonUserCode]
		public bool Equals(GetGameTimeRemainingInfoRequest other)
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
					bool flag4 = !object.Equals(this.GameAccountId, other.GameAccountId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AccountId, other.AccountId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BenefactorId != other.BenefactorId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x0028AB88 File Offset: 0x00288D88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasBenefactorId = this.HasBenefactorId;
			if (hasBenefactorId)
			{
				num ^= this.BenefactorId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x0028AC0C File Offset: 0x00288E0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x0028AC24 File Offset: 0x00288E24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x0028AC30 File Offset: 0x00288E30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccountId);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AccountId);
			}
			bool hasBenefactorId = this.HasBenefactorId;
			if (hasBenefactorId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.BenefactorId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x0028ACC8 File Offset: 0x00288EC8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool hasBenefactorId = this.HasBenefactorId;
			if (hasBenefactorId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BenefactorId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x0028AD58 File Offset: 0x00288F58
		[DebuggerNonUserCode]
		public void MergeFrom(GetGameTimeRemainingInfoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccountId_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccountId_ == null;
					if (flag3)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				bool flag4 = other.accountId_ != null;
				if (flag4)
				{
					bool flag5 = this.accountId_ == null;
					if (flag5)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				bool hasBenefactorId = other.HasBenefactorId;
				if (hasBenefactorId)
				{
					this.BenefactorId = other.BenefactorId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x0028AE20 File Offset: 0x00289020
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x0028AE2C File Offset: 0x0028902C
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BenefactorId = input.ReadString();
						}
					}
					else
					{
						bool flag = this.accountId_ == null;
						if (flag)
						{
							this.AccountId = new EntityId();
						}
						input.ReadMessage(this.AccountId);
					}
				}
				else
				{
					bool flag2 = this.gameAccountId_ == null;
					if (flag2)
					{
						this.GameAccountId = new EntityId();
					}
					input.ReadMessage(this.GameAccountId);
				}
			}
		}

		// Token: 0x04004B01 RID: 19201
		private static readonly MessageParser<GetGameTimeRemainingInfoRequest> _parser = new MessageParser<GetGameTimeRemainingInfoRequest>(() => new GetGameTimeRemainingInfoRequest());

		// Token: 0x04004B02 RID: 19202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B03 RID: 19203
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04004B04 RID: 19204
		private EntityId gameAccountId_;

		// Token: 0x04004B05 RID: 19205
		public const int AccountIdFieldNumber = 2;

		// Token: 0x04004B06 RID: 19206
		private EntityId accountId_;

		// Token: 0x04004B07 RID: 19207
		public const int BenefactorIdFieldNumber = 3;

		// Token: 0x04004B08 RID: 19208
		private static readonly string BenefactorIdDefaultValue = "";

		// Token: 0x04004B09 RID: 19209
		private string benefactorId_;
	}
}
