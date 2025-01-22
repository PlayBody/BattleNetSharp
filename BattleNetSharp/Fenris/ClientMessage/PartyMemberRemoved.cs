using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000254 RID: 596
	public sealed class PartyMemberRemoved : IMessage<PartyMemberRemoved>, IMessage, IEquatable<PartyMemberRemoved>, IDeepCloneable<PartyMemberRemoved>, IBufferMessage
	{
		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x0600401B RID: 16411 RVA: 0x000FAC64 File Offset: 0x000F8E64
		[DebuggerNonUserCode]
		public static MessageParser<PartyMemberRemoved> Parser
		{
			get
			{
				return PartyMemberRemoved._parser;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x000FAC7C File Offset: 0x000F8E7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[68];
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x000FACA0 File Offset: 0x000F8EA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyMemberRemoved.Descriptor;
			}
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x000FACB7 File Offset: 0x000F8EB7
		[DebuggerNonUserCode]
		public PartyMemberRemoved()
		{
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x000FACC4 File Offset: 0x000F8EC4
		[DebuggerNonUserCode]
		public PartyMemberRemoved(PartyMemberRemoved other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x000FAD1C File Offset: 0x000F8F1C
		[DebuggerNonUserCode]
		public PartyMemberRemoved Clone()
		{
			return new PartyMemberRemoved(this);
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x000FAD34 File Offset: 0x000F8F34
		// (set) Token: 0x06004022 RID: 16418 RVA: 0x000FAD55 File Offset: 0x000F8F55
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyMemberRemoved.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06004023 RID: 16419 RVA: 0x000FAD6C File Offset: 0x000F8F6C
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x000FAD87 File Offset: 0x000F8F87
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06004025 RID: 16421 RVA: 0x000FAD94 File Offset: 0x000F8F94
		// (set) Token: 0x06004026 RID: 16422 RVA: 0x000FADC5 File Offset: 0x000F8FC5
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = PartyMemberRemoved.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x000FADE0 File Offset: 0x000F8FE0
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x000FADFD File Offset: 0x000F8FFD
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x000FAE10 File Offset: 0x000F9010
		// (set) Token: 0x0600402A RID: 16426 RVA: 0x000FAE41 File Offset: 0x000F9041
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = PartyMemberRemoved.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x000FAE5C File Offset: 0x000F905C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x000FAE79 File Offset: 0x000F9079
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x000FAE8C File Offset: 0x000F908C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyMemberRemoved);
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x000FAEAC File Offset: 0x000F90AC
		[DebuggerNonUserCode]
		public bool Equals(PartyMemberRemoved other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountId != other.GameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x000FAF38 File Offset: 0x000F9138
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x000FAFC0 File Offset: 0x000F91C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x000FAFD8 File Offset: 0x000F91D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x000FAFE4 File Offset: 0x000F91E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x000FB074 File Offset: 0x000F9274
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x000FB100 File Offset: 0x000F9300
		[DebuggerNonUserCode]
		public void MergeFrom(PartyMemberRemoved other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x000FB17B File Offset: 0x000F937B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x000FB188 File Offset: 0x000F9388
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadUInt32();
						}
					}
					else
					{
						this.GameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001D2D RID: 7469
		private static readonly MessageParser<PartyMemberRemoved> _parser = new MessageParser<PartyMemberRemoved>(() => new PartyMemberRemoved());

		// Token: 0x04001D2E RID: 7470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D2F RID: 7471
		private int _hasBits0;

		// Token: 0x04001D30 RID: 7472
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001D31 RID: 7473
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001D32 RID: 7474
		private string partyId_;

		// Token: 0x04001D33 RID: 7475
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x04001D34 RID: 7476
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001D35 RID: 7477
		private uint gameAccountId_;

		// Token: 0x04001D36 RID: 7478
		public const int ReasonFieldNumber = 3;

		// Token: 0x04001D37 RID: 7479
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04001D38 RID: 7480
		private uint reason_;
	}
}
