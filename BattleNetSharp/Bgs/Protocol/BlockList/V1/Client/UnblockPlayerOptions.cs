using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000708 RID: 1800
	public sealed class UnblockPlayerOptions : IMessage<UnblockPlayerOptions>, IMessage, IEquatable<UnblockPlayerOptions>, IDeepCloneable<UnblockPlayerOptions>, IBufferMessage
	{
		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600A542 RID: 42306 RVA: 0x00283D1C File Offset: 0x00281F1C
		[DebuggerNonUserCode]
		public static MessageParser<UnblockPlayerOptions> Parser
		{
			get
			{
				return UnblockPlayerOptions._parser;
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600A543 RID: 42307 RVA: 0x00283D34 File Offset: 0x00281F34
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600A544 RID: 42308 RVA: 0x00283D58 File Offset: 0x00281F58
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerOptions.Descriptor;
			}
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x00283D6F File Offset: 0x00281F6F
		[DebuggerNonUserCode]
		public UnblockPlayerOptions()
		{
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x00283D79 File Offset: 0x00281F79
		[DebuggerNonUserCode]
		public UnblockPlayerOptions(UnblockPlayerOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x00283DAC File Offset: 0x00281FAC
		[DebuggerNonUserCode]
		public UnblockPlayerOptions Clone()
		{
			return new UnblockPlayerOptions(this);
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600A548 RID: 42312 RVA: 0x00283DC4 File Offset: 0x00281FC4
		// (set) Token: 0x0600A549 RID: 42313 RVA: 0x00283DF5 File Offset: 0x00281FF5
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
					accountIdDefaultValue = UnblockPlayerOptions.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x00283E10 File Offset: 0x00282010
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x00283E2D File Offset: 0x0028202D
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x00283E40 File Offset: 0x00282040
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerOptions);
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x00283E60 File Offset: 0x00282060
		[DebuggerNonUserCode]
		public bool Equals(UnblockPlayerOptions other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x00283EB8 File Offset: 0x002820B8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A54F RID: 42319 RVA: 0x00283F08 File Offset: 0x00282108
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A550 RID: 42320 RVA: 0x00283F20 File Offset: 0x00282120
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A551 RID: 42321 RVA: 0x00283F2C File Offset: 0x0028212C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x00283F78 File Offset: 0x00282178
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountId = this.HasAccountId;
			if (hasAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A553 RID: 42323 RVA: 0x00283FC8 File Offset: 0x002821C8
		[DebuggerNonUserCode]
		public void MergeFrom(UnblockPlayerOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountId = other.HasAccountId;
				if (hasAccountId)
				{
					this.AccountId = other.AccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x00284011 File Offset: 0x00282211
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x0028401C File Offset: 0x0028221C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004A60 RID: 19040
		private static readonly MessageParser<UnblockPlayerOptions> _parser = new MessageParser<UnblockPlayerOptions>(() => new UnblockPlayerOptions());

		// Token: 0x04004A61 RID: 19041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A62 RID: 19042
		private int _hasBits0;

		// Token: 0x04004A63 RID: 19043
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04004A64 RID: 19044
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04004A65 RID: 19045
		private ulong accountId_;
	}
}
