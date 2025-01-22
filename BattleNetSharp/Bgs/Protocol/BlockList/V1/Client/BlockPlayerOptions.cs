using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000707 RID: 1799
	public sealed class BlockPlayerOptions : IMessage<BlockPlayerOptions>, IMessage, IEquatable<BlockPlayerOptions>, IDeepCloneable<BlockPlayerOptions>, IBufferMessage
	{
		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600A52D RID: 42285 RVA: 0x002839A8 File Offset: 0x00281BA8
		[DebuggerNonUserCode]
		public static MessageParser<BlockPlayerOptions> Parser
		{
			get
			{
				return BlockPlayerOptions._parser;
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600A52E RID: 42286 RVA: 0x002839C0 File Offset: 0x00281BC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600A52F RID: 42287 RVA: 0x002839E4 File Offset: 0x00281BE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockPlayerOptions.Descriptor;
			}
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x002839FB File Offset: 0x00281BFB
		[DebuggerNonUserCode]
		public BlockPlayerOptions()
		{
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x00283A05 File Offset: 0x00281C05
		[DebuggerNonUserCode]
		public BlockPlayerOptions(BlockPlayerOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountId_ = other.accountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x00283A38 File Offset: 0x00281C38
		[DebuggerNonUserCode]
		public BlockPlayerOptions Clone()
		{
			return new BlockPlayerOptions(this);
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600A533 RID: 42291 RVA: 0x00283A50 File Offset: 0x00281C50
		// (set) Token: 0x0600A534 RID: 42292 RVA: 0x00283A81 File Offset: 0x00281C81
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
					accountIdDefaultValue = BlockPlayerOptions.AccountIdDefaultValue;
				}
				return accountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountId_ = value;
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600A535 RID: 42293 RVA: 0x00283A9C File Offset: 0x00281C9C
		[DebuggerNonUserCode]
		public bool HasAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x00283AB9 File Offset: 0x00281CB9
		[DebuggerNonUserCode]
		public void ClearAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x00283ACC File Offset: 0x00281CCC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockPlayerOptions);
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x00283AEC File Offset: 0x00281CEC
		[DebuggerNonUserCode]
		public bool Equals(BlockPlayerOptions other)
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

		// Token: 0x0600A539 RID: 42297 RVA: 0x00283B44 File Offset: 0x00281D44
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

		// Token: 0x0600A53A RID: 42298 RVA: 0x00283B94 File Offset: 0x00281D94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x00283BAC File Offset: 0x00281DAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x00283BB8 File Offset: 0x00281DB8
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

		// Token: 0x0600A53D RID: 42301 RVA: 0x00283C04 File Offset: 0x00281E04
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

		// Token: 0x0600A53E RID: 42302 RVA: 0x00283C54 File Offset: 0x00281E54
		[DebuggerNonUserCode]
		public void MergeFrom(BlockPlayerOptions other)
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

		// Token: 0x0600A53F RID: 42303 RVA: 0x00283C9D File Offset: 0x00281E9D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A540 RID: 42304 RVA: 0x00283CA8 File Offset: 0x00281EA8
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

		// Token: 0x04004A5A RID: 19034
		private static readonly MessageParser<BlockPlayerOptions> _parser = new MessageParser<BlockPlayerOptions>(() => new BlockPlayerOptions());

		// Token: 0x04004A5B RID: 19035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A5C RID: 19036
		private int _hasBits0;

		// Token: 0x04004A5D RID: 19037
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04004A5E RID: 19038
		private static readonly ulong AccountIdDefaultValue = 0UL;

		// Token: 0x04004A5F RID: 19039
		private ulong accountId_;
	}
}
