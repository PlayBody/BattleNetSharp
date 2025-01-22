using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B4 RID: 1460
	public sealed class SubscribeFailureResult : IMessage<SubscribeFailureResult>, IMessage, IEquatable<SubscribeFailureResult>, IDeepCloneable<SubscribeFailureResult>, IBufferMessage
	{
		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x06008AAE RID: 35502 RVA: 0x0021ABF8 File Offset: 0x00218DF8
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeFailureResult> Parser
		{
			get
			{
				return SubscribeFailureResult._parser;
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x06008AAF RID: 35503 RVA: 0x0021AC10 File Offset: 0x00218E10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x06008AB0 RID: 35504 RVA: 0x0021AC34 File Offset: 0x00218E34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeFailureResult.Descriptor;
			}
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x0021AC4B File Offset: 0x00218E4B
		[DebuggerNonUserCode]
		public SubscribeFailureResult()
		{
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x0021AC55 File Offset: 0x00218E55
		[DebuggerNonUserCode]
		public SubscribeFailureResult(SubscribeFailureResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x0021AC94 File Offset: 0x00218E94
		[DebuggerNonUserCode]
		public SubscribeFailureResult Clone()
		{
			return new SubscribeFailureResult(this);
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x06008AB4 RID: 35508 RVA: 0x0021ACAC File Offset: 0x00218EAC
		// (set) Token: 0x06008AB5 RID: 35509 RVA: 0x0021ACDD File Offset: 0x00218EDD
		[DebuggerNonUserCode]
		public ulong AccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accountIdDefaultValue;
				if (flag)
				{
					accountIdDefaultValue = this.accountId_;
				}
				else
				{
					accountIdDefaultValue = SubscribeFailureResult.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x06008AB6 RID: 35510 RVA: 0x0021ACF8 File Offset: 0x00218EF8
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x0021AD15 File Offset: 0x00218F15
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x06008AB8 RID: 35512 RVA: 0x0021AD28 File Offset: 0x00218F28
		// (set) Token: 0x06008AB9 RID: 35513 RVA: 0x0021AD59 File Offset: 0x00218F59
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = SubscribeFailureResult.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.status_ = value;
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x06008ABA RID: 35514 RVA: 0x0021AD74 File Offset: 0x00218F74
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008ABB RID: 35515 RVA: 0x0021AD91 File Offset: 0x00218F91
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x0021ADA4 File Offset: 0x00218FA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeFailureResult);
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x0021ADC4 File Offset: 0x00218FC4
		[DebuggerNonUserCode]
		public bool Equals(SubscribeFailureResult other)
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
					bool flag4 = this.AccountId != other.AccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Status != other.Status;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x0021AE38 File Offset: 0x00219038
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x0021AEA8 File Offset: 0x002190A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x0021AEC0 File Offset: 0x002190C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x0021AECC File Offset: 0x002190CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Status);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x0021AF3C File Offset: 0x0021913C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x0021AFA8 File Offset: 0x002191A8
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeFailureResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x0021B00A File Offset: 0x0021920A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x0021B018 File Offset: 0x00219218
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadUInt32();
					}
				}
				else
				{
					this.AccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003EC4 RID: 16068
		private static readonly MessageParser<SubscribeFailureResult> _parser = new MessageParser<SubscribeFailureResult>(() => new SubscribeFailureResult());

		// Token: 0x04003EC5 RID: 16069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EC6 RID: 16070
		private int _hasBits0;

		// Token: 0x04003EC7 RID: 16071
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04003EC8 RID: 16072
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04003EC9 RID: 16073
		private ulong accountId_;

		// Token: 0x04003ECA RID: 16074
		public const int StatusFieldNumber = 2;

		// Token: 0x04003ECB RID: 16075
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04003ECC RID: 16076
		private uint status_;
	}
}
