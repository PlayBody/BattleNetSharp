using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000476 RID: 1142
	public sealed class MemberId : IMessage<MemberId>, IMessage, IEquatable<MemberId>, IDeepCloneable<MemberId>, IBufferMessage
	{
		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x001B1638 File Offset: 0x001AF838
		[DebuggerNonUserCode]
		public static MessageParser<MemberId> Parser
		{
			get
			{
				return MemberId._parser;
			}
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x06006F77 RID: 28535 RVA: 0x001B1650 File Offset: 0x001AF850
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberIdReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x06006F78 RID: 28536 RVA: 0x001B1674 File Offset: 0x001AF874
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberId.Descriptor;
			}
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x001B168B File Offset: 0x001AF88B
		[DebuggerNonUserCode]
		public MemberId()
		{
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x001B1698 File Offset: 0x001AF898
		[DebuggerNonUserCode]
		public MemberId(MemberId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.uniqueId_ = other.uniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x001B16F4 File Offset: 0x001AF8F4
		[DebuggerNonUserCode]
		public MemberId Clone()
		{
			return new MemberId(this);
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x06006F7C RID: 28540 RVA: 0x001B170C File Offset: 0x001AF90C
		// (set) Token: 0x06006F7D RID: 28541 RVA: 0x001B1724 File Offset: 0x001AF924
		[DebuggerNonUserCode]
		public AccountId AccountId
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

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x06006F7E RID: 28542 RVA: 0x001B1730 File Offset: 0x001AF930
		// (set) Token: 0x06006F7F RID: 28543 RVA: 0x001B1761 File Offset: 0x001AF961
		[DebuggerNonUserCode]
		public ulong UniqueId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong uniqueIdDefaultValue;
				if (flag)
				{
					uniqueIdDefaultValue = this.uniqueId_;
				}
				else
				{
					uniqueIdDefaultValue = MemberId.UniqueIdDefaultValue;
				}
				return uniqueIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.uniqueId_ = value;
			}
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x06006F80 RID: 28544 RVA: 0x001B177C File Offset: 0x001AF97C
		[DebuggerNonUserCode]
		public bool HasUniqueId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x001B1799 File Offset: 0x001AF999
		[DebuggerNonUserCode]
		public void ClearUniqueId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x001B17AC File Offset: 0x001AF9AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberId);
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x001B17CC File Offset: 0x001AF9CC
		[DebuggerNonUserCode]
		public bool Equals(MemberId other)
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
					bool flag4 = !object.Equals(this.AccountId, other.AccountId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UniqueId != other.UniqueId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x001B1840 File Offset: 0x001AFA40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x001B18AC File Offset: 0x001AFAAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x001B18C4 File Offset: 0x001AFAC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x001B18D0 File Offset: 0x001AFAD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.accountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountId);
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.UniqueId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x001B1944 File Offset: 0x001AFB44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.accountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x001B19B4 File Offset: 0x001AFBB4
		[DebuggerNonUserCode]
		public void MergeFrom(MemberId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.accountId_ != null;
				if (flag2)
				{
					bool flag3 = this.accountId_ == null;
					if (flag3)
					{
						this.AccountId = new AccountId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				bool hasUniqueId = other.HasUniqueId;
				if (hasUniqueId)
				{
					this.UniqueId = other.UniqueId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x001B1A39 File Offset: 0x001AFC39
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x001B1A44 File Offset: 0x001AFC44
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UniqueId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.accountId_ == null;
					if (flag)
					{
						this.AccountId = new AccountId();
					}
					input.ReadMessage(this.AccountId);
				}
			}
		}

		// Token: 0x0400331F RID: 13087
		private static readonly MessageParser<MemberId> _parser = new MessageParser<MemberId>(() => new MemberId());

		// Token: 0x04003320 RID: 13088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003321 RID: 13089
		private int _hasBits0;

		// Token: 0x04003322 RID: 13090
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04003323 RID: 13091
		private AccountId accountId_;

		// Token: 0x04003324 RID: 13092
		public const int UniqueIdFieldNumber = 2;

		// Token: 0x04003325 RID: 13093
		private static readonly ulong UniqueIdDefaultValue = 0UL;

		// Token: 0x04003326 RID: 13094
		private ulong uniqueId_;
	}
}
