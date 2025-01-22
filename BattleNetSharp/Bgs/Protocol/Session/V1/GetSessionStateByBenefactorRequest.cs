using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000535 RID: 1333
	public sealed class GetSessionStateByBenefactorRequest : IMessage<GetSessionStateByBenefactorRequest>, IMessage, IEquatable<GetSessionStateByBenefactorRequest>, IDeepCloneable<GetSessionStateByBenefactorRequest>, IBufferMessage
	{
		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x06008115 RID: 33045 RVA: 0x001F6ACC File Offset: 0x001F4CCC
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionStateByBenefactorRequest> Parser
		{
			get
			{
				return GetSessionStateByBenefactorRequest._parser;
			}
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x001F6AE4 File Offset: 0x001F4CE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x001F6B08 File Offset: 0x001F4D08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionStateByBenefactorRequest.Descriptor;
			}
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x001F6B1F File Offset: 0x001F4D1F
		[DebuggerNonUserCode]
		public GetSessionStateByBenefactorRequest()
		{
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x001F6B2C File Offset: 0x001F4D2C
		[DebuggerNonUserCode]
		public GetSessionStateByBenefactorRequest(GetSessionStateByBenefactorRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.benefactorHandle_ = ((other.benefactorHandle_ != null) ? other.benefactorHandle_.Clone() : null);
			this.includeBillingDisabled_ = other.includeBillingDisabled_;
			this.benefactorUuid_ = other.benefactorUuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600811A RID: 33050 RVA: 0x001F6B94 File Offset: 0x001F4D94
		[DebuggerNonUserCode]
		public GetSessionStateByBenefactorRequest Clone()
		{
			return new GetSessionStateByBenefactorRequest(this);
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600811B RID: 33051 RVA: 0x001F6BAC File Offset: 0x001F4DAC
		// (set) Token: 0x0600811C RID: 33052 RVA: 0x001F6BC4 File Offset: 0x001F4DC4
		[DebuggerNonUserCode]
		public GameAccountHandle BenefactorHandle
		{
			get
			{
				return this.benefactorHandle_;
			}
			set
			{
				this.benefactorHandle_ = value;
			}
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600811D RID: 33053 RVA: 0x001F6BD0 File Offset: 0x001F4DD0
		// (set) Token: 0x0600811E RID: 33054 RVA: 0x001F6C01 File Offset: 0x001F4E01
		[DebuggerNonUserCode]
		public bool IncludeBillingDisabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool includeBillingDisabledDefaultValue;
				if (flag)
				{
					includeBillingDisabledDefaultValue = this.includeBillingDisabled_;
				}
				else
				{
					includeBillingDisabledDefaultValue = GetSessionStateByBenefactorRequest.IncludeBillingDisabledDefaultValue;
				}
				return includeBillingDisabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.includeBillingDisabled_ = value;
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x0600811F RID: 33055 RVA: 0x001F6C1C File Offset: 0x001F4E1C
		[DebuggerNonUserCode]
		public bool HasIncludeBillingDisabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x001F6C39 File Offset: 0x001F4E39
		[DebuggerNonUserCode]
		public void ClearIncludeBillingDisabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x06008121 RID: 33057 RVA: 0x001F6C4C File Offset: 0x001F4E4C
		// (set) Token: 0x06008122 RID: 33058 RVA: 0x001F6C6D File Offset: 0x001F4E6D
		[DebuggerNonUserCode]
		public string BenefactorUuid
		{
			get
			{
				return this.benefactorUuid_ ?? GetSessionStateByBenefactorRequest.BenefactorUuidDefaultValue;
			}
			set
			{
				this.benefactorUuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x06008123 RID: 33059 RVA: 0x001F6C84 File Offset: 0x001F4E84
		[DebuggerNonUserCode]
		public bool HasBenefactorUuid
		{
			get
			{
				return this.benefactorUuid_ != null;
			}
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x001F6C9F File Offset: 0x001F4E9F
		[DebuggerNonUserCode]
		public void ClearBenefactorUuid()
		{
			this.benefactorUuid_ = null;
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x001F6CAC File Offset: 0x001F4EAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionStateByBenefactorRequest);
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x001F6CCC File Offset: 0x001F4ECC
		[DebuggerNonUserCode]
		public bool Equals(GetSessionStateByBenefactorRequest other)
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
					bool flag4 = !object.Equals(this.BenefactorHandle, other.BenefactorHandle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IncludeBillingDisabled != other.IncludeBillingDisabled;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BenefactorUuid != other.BenefactorUuid;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x001F6D5C File Offset: 0x001F4F5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.benefactorHandle_ != null;
			if (flag)
			{
				num ^= this.BenefactorHandle.GetHashCode();
			}
			bool hasIncludeBillingDisabled = this.HasIncludeBillingDisabled;
			if (hasIncludeBillingDisabled)
			{
				num ^= this.IncludeBillingDisabled.GetHashCode();
			}
			bool hasBenefactorUuid = this.HasBenefactorUuid;
			if (hasBenefactorUuid)
			{
				num ^= this.BenefactorUuid.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x001F6DE4 File Offset: 0x001F4FE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x001F6DFC File Offset: 0x001F4FFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x001F6E08 File Offset: 0x001F5008
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.benefactorHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BenefactorHandle);
			}
			bool hasIncludeBillingDisabled = this.HasIncludeBillingDisabled;
			if (hasIncludeBillingDisabled)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IncludeBillingDisabled);
			}
			bool hasBenefactorUuid = this.HasBenefactorUuid;
			if (hasBenefactorUuid)
			{
				output.WriteRawTag(26);
				output.WriteString(this.BenefactorUuid);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x001F6E9C File Offset: 0x001F509C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.benefactorHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BenefactorHandle);
			}
			bool hasIncludeBillingDisabled = this.HasIncludeBillingDisabled;
			if (hasIncludeBillingDisabled)
			{
				num += 2;
			}
			bool hasBenefactorUuid = this.HasBenefactorUuid;
			if (hasBenefactorUuid)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BenefactorUuid);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x001F6F20 File Offset: 0x001F5120
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionStateByBenefactorRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.benefactorHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.benefactorHandle_ == null;
					if (flag3)
					{
						this.BenefactorHandle = new GameAccountHandle();
					}
					this.BenefactorHandle.MergeFrom(other.BenefactorHandle);
				}
				bool hasIncludeBillingDisabled = other.HasIncludeBillingDisabled;
				if (hasIncludeBillingDisabled)
				{
					this.IncludeBillingDisabled = other.IncludeBillingDisabled;
				}
				bool hasBenefactorUuid = other.HasBenefactorUuid;
				if (hasBenefactorUuid)
				{
					this.BenefactorUuid = other.BenefactorUuid;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x001F6FC3 File Offset: 0x001F51C3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x001F6FD0 File Offset: 0x001F51D0
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
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BenefactorUuid = input.ReadString();
						}
					}
					else
					{
						this.IncludeBillingDisabled = input.ReadBool();
					}
				}
				else
				{
					bool flag = this.benefactorHandle_ == null;
					if (flag)
					{
						this.BenefactorHandle = new GameAccountHandle();
					}
					input.ReadMessage(this.BenefactorHandle);
				}
			}
		}

		// Token: 0x04003A8E RID: 14990
		private static readonly MessageParser<GetSessionStateByBenefactorRequest> _parser = new MessageParser<GetSessionStateByBenefactorRequest>(() => new GetSessionStateByBenefactorRequest());

		// Token: 0x04003A8F RID: 14991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A90 RID: 14992
		private int _hasBits0;

		// Token: 0x04003A91 RID: 14993
		public const int BenefactorHandleFieldNumber = 1;

		// Token: 0x04003A92 RID: 14994
		private GameAccountHandle benefactorHandle_;

		// Token: 0x04003A93 RID: 14995
		public const int IncludeBillingDisabledFieldNumber = 2;

		// Token: 0x04003A94 RID: 14996
		private static readonly bool IncludeBillingDisabledDefaultValue = false;

		// Token: 0x04003A95 RID: 14997
		private bool includeBillingDisabled_;

		// Token: 0x04003A96 RID: 14998
		public const int BenefactorUuidFieldNumber = 3;

		// Token: 0x04003A97 RID: 14999
		private static readonly string BenefactorUuidDefaultValue = "";

		// Token: 0x04003A98 RID: 15000
		private string benefactorUuid_;
	}
}
