using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200025A RID: 602
	public sealed class PartyMemberGroupVote : IMessage<PartyMemberGroupVote>, IMessage, IEquatable<PartyMemberGroupVote>, IDeepCloneable<PartyMemberGroupVote>, IBufferMessage
	{
		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x000FD2EC File Offset: 0x000FB4EC
		[DebuggerNonUserCode]
		public static MessageParser<PartyMemberGroupVote> Parser
		{
			get
			{
				return PartyMemberGroupVote._parser;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x000FD304 File Offset: 0x000FB504
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[74];
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x000FD328 File Offset: 0x000FB528
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyMemberGroupVote.Descriptor;
			}
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x000FD33F File Offset: 0x000FB53F
		[DebuggerNonUserCode]
		public PartyMemberGroupVote()
		{
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x000FD354 File Offset: 0x000FB554
		[DebuggerNonUserCode]
		public PartyMemberGroupVote(PartyMemberGroupVote other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviterGameAccountId_ = other.inviterGameAccountId_.Clone();
			this.voteType_ = other.voteType_;
			this.keyedDungeonData_ = ((other.keyedDungeonData_ != null) ? other.keyedDungeonData_.Clone() : null);
			this.requestedWorldTier_ = other.requestedWorldTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x000FD3CC File Offset: 0x000FB5CC
		[DebuggerNonUserCode]
		public PartyMemberGroupVote Clone()
		{
			return new PartyMemberGroupVote(this);
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x000FD3E4 File Offset: 0x000FB5E4
		[DebuggerNonUserCode]
		public RepeatedField<uint> InviterGameAccountId
		{
			get
			{
				return this.inviterGameAccountId_;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x000FD3FC File Offset: 0x000FB5FC
		// (set) Token: 0x060040D5 RID: 16597 RVA: 0x000FD42D File Offset: 0x000FB62D
		[DebuggerNonUserCode]
		public uint VoteType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint voteTypeDefaultValue;
				if (flag)
				{
					voteTypeDefaultValue = this.voteType_;
				}
				else
				{
					voteTypeDefaultValue = PartyMemberGroupVote.VoteTypeDefaultValue;
				}
				return voteTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.voteType_ = value;
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x000FD448 File Offset: 0x000FB648
		[DebuggerNonUserCode]
		public bool HasVoteType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x000FD465 File Offset: 0x000FB665
		[DebuggerNonUserCode]
		public void ClearVoteType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x000FD478 File Offset: 0x000FB678
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x000FD490 File Offset: 0x000FB690
		[DebuggerNonUserCode]
		public KeyedDungeonPartyVoteData KeyedDungeonData
		{
			get
			{
				return this.keyedDungeonData_;
			}
			set
			{
				this.keyedDungeonData_ = value;
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x000FD49C File Offset: 0x000FB69C
		// (set) Token: 0x060040DB RID: 16603 RVA: 0x000FD4CD File Offset: 0x000FB6CD
		[DebuggerNonUserCode]
		public int RequestedWorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int requestedWorldTierDefaultValue;
				if (flag)
				{
					requestedWorldTierDefaultValue = this.requestedWorldTier_;
				}
				else
				{
					requestedWorldTierDefaultValue = PartyMemberGroupVote.RequestedWorldTierDefaultValue;
				}
				return requestedWorldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.requestedWorldTier_ = value;
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x000FD4E8 File Offset: 0x000FB6E8
		[DebuggerNonUserCode]
		public bool HasRequestedWorldTier
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x000FD505 File Offset: 0x000FB705
		[DebuggerNonUserCode]
		public void ClearRequestedWorldTier()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x000FD518 File Offset: 0x000FB718
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyMemberGroupVote);
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x000FD538 File Offset: 0x000FB738
		[DebuggerNonUserCode]
		public bool Equals(PartyMemberGroupVote other)
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
					bool flag4 = !this.inviterGameAccountId_.Equals(other.inviterGameAccountId_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.VoteType != other.VoteType;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.KeyedDungeonData, other.KeyedDungeonData);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RequestedWorldTier != other.RequestedWorldTier;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x000FD5EC File Offset: 0x000FB7EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.inviterGameAccountId_.GetHashCode();
			bool hasVoteType = this.HasVoteType;
			if (hasVoteType)
			{
				num ^= this.VoteType.GetHashCode();
			}
			bool flag = this.keyedDungeonData_ != null;
			if (flag)
			{
				num ^= this.KeyedDungeonData.GetHashCode();
			}
			bool hasRequestedWorldTier = this.HasRequestedWorldTier;
			if (hasRequestedWorldTier)
			{
				num ^= this.RequestedWorldTier.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x000FD684 File Offset: 0x000FB884
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x000FD69C File Offset: 0x000FB89C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x000FD6A8 File Offset: 0x000FB8A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.inviterGameAccountId_.WriteTo(ref output, PartyMemberGroupVote._repeated_inviterGameAccountId_codec);
			bool hasVoteType = this.HasVoteType;
			if (hasVoteType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.VoteType);
			}
			bool flag = this.keyedDungeonData_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.KeyedDungeonData);
			}
			bool hasRequestedWorldTier = this.HasRequestedWorldTier;
			if (hasRequestedWorldTier)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RequestedWorldTier);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x000FD750 File Offset: 0x000FB950
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.inviterGameAccountId_.CalculateSize(PartyMemberGroupVote._repeated_inviterGameAccountId_codec);
			bool hasVoteType = this.HasVoteType;
			if (hasVoteType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.VoteType);
			}
			bool flag = this.keyedDungeonData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KeyedDungeonData);
			}
			bool hasRequestedWorldTier = this.HasRequestedWorldTier;
			if (hasRequestedWorldTier)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestedWorldTier);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x000FD7F0 File Offset: 0x000FB9F0
		[DebuggerNonUserCode]
		public void MergeFrom(PartyMemberGroupVote other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.inviterGameAccountId_.Add(other.inviterGameAccountId_);
				bool hasVoteType = other.HasVoteType;
				if (hasVoteType)
				{
					this.VoteType = other.VoteType;
				}
				bool flag2 = other.keyedDungeonData_ != null;
				if (flag2)
				{
					bool flag3 = this.keyedDungeonData_ == null;
					if (flag3)
					{
						this.KeyedDungeonData = new KeyedDungeonPartyVoteData();
					}
					this.KeyedDungeonData.MergeFrom(other.KeyedDungeonData);
				}
				bool hasRequestedWorldTier = other.HasRequestedWorldTier;
				if (hasRequestedWorldTier)
				{
					this.RequestedWorldTier = other.RequestedWorldTier;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x000FD8A5 File Offset: 0x000FBAA5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x000FD8B0 File Offset: 0x000FBAB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 10U)
				{
					if (num3 != 8U && num3 != 10U)
					{
						goto IL_0032;
					}
					this.inviterGameAccountId_.AddEntriesFrom(ref input, PartyMemberGroupVote._repeated_inviterGameAccountId_codec);
				}
				else if (num3 != 16U)
				{
					if (num3 != 26U)
					{
						if (num3 != 32U)
						{
							goto IL_0032;
						}
						this.RequestedWorldTier = input.ReadInt32();
					}
					else
					{
						bool flag = this.keyedDungeonData_ == null;
						if (flag)
						{
							this.KeyedDungeonData = new KeyedDungeonPartyVoteData();
						}
						input.ReadMessage(this.KeyedDungeonData);
					}
				}
				else
				{
					this.VoteType = input.ReadUInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D79 RID: 7545
		private static readonly MessageParser<PartyMemberGroupVote> _parser = new MessageParser<PartyMemberGroupVote>(() => new PartyMemberGroupVote());

		// Token: 0x04001D7A RID: 7546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D7B RID: 7547
		private int _hasBits0;

		// Token: 0x04001D7C RID: 7548
		public const int InviterGameAccountIdFieldNumber = 1;

		// Token: 0x04001D7D RID: 7549
		private static readonly FieldCodec<uint> _repeated_inviterGameAccountId_codec = FieldCodec.ForUInt32(8U);

		// Token: 0x04001D7E RID: 7550
		private readonly RepeatedField<uint> inviterGameAccountId_ = new RepeatedField<uint>();

		// Token: 0x04001D7F RID: 7551
		public const int VoteTypeFieldNumber = 2;

		// Token: 0x04001D80 RID: 7552
		private static readonly uint VoteTypeDefaultValue = 0U;

		// Token: 0x04001D81 RID: 7553
		private uint voteType_;

		// Token: 0x04001D82 RID: 7554
		public const int KeyedDungeonDataFieldNumber = 3;

		// Token: 0x04001D83 RID: 7555
		private KeyedDungeonPartyVoteData keyedDungeonData_;

		// Token: 0x04001D84 RID: 7556
		public const int RequestedWorldTierFieldNumber = 4;

		// Token: 0x04001D85 RID: 7557
		private static readonly int RequestedWorldTierDefaultValue = 0;

		// Token: 0x04001D86 RID: 7558
		private int requestedWorldTier_;
	}
}
