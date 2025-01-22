using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200025C RID: 604
	public sealed class PartyVoteResponse : IMessage<PartyVoteResponse>, IMessage, IEquatable<PartyVoteResponse>, IDeepCloneable<PartyVoteResponse>, IBufferMessage
	{
		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x060040FA RID: 16634 RVA: 0x000FDBE8 File Offset: 0x000FBDE8
		[DebuggerNonUserCode]
		public static MessageParser<PartyVoteResponse> Parser
		{
			get
			{
				return PartyVoteResponse._parser;
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x000FDC00 File Offset: 0x000FBE00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[76];
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x060040FC RID: 16636 RVA: 0x000FDC24 File Offset: 0x000FBE24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyVoteResponse.Descriptor;
			}
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x000FDC3B File Offset: 0x000FBE3B
		[DebuggerNonUserCode]
		public PartyVoteResponse()
		{
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x000FDC50 File Offset: 0x000FBE50
		[DebuggerNonUserCode]
		public PartyVoteResponse(PartyVoteResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_.Clone();
			this.vote_ = other.vote_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x000FDCA0 File Offset: 0x000FBEA0
		[DebuggerNonUserCode]
		public PartyVoteResponse Clone()
		{
			return new PartyVoteResponse(this);
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06004100 RID: 16640 RVA: 0x000FDCB8 File Offset: 0x000FBEB8
		[DebuggerNonUserCode]
		public RepeatedField<uint> GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x000FDCD0 File Offset: 0x000FBED0
		// (set) Token: 0x06004102 RID: 16642 RVA: 0x000FDD01 File Offset: 0x000FBF01
		[DebuggerNonUserCode]
		public bool Vote
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool voteDefaultValue;
				if (flag)
				{
					voteDefaultValue = this.vote_;
				}
				else
				{
					voteDefaultValue = PartyVoteResponse.VoteDefaultValue;
				}
				return voteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.vote_ = value;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06004103 RID: 16643 RVA: 0x000FDD1C File Offset: 0x000FBF1C
		[DebuggerNonUserCode]
		public bool HasVote
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x000FDD39 File Offset: 0x000FBF39
		[DebuggerNonUserCode]
		public void ClearVote()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x000FDD4C File Offset: 0x000FBF4C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyVoteResponse);
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x000FDD6C File Offset: 0x000FBF6C
		[DebuggerNonUserCode]
		public bool Equals(PartyVoteResponse other)
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
					bool flag4 = !this.gameAccountId_.Equals(other.gameAccountId_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Vote != other.Vote;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x000FDDE0 File Offset: 0x000FBFE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gameAccountId_.GetHashCode();
			bool hasVote = this.HasVote;
			if (hasVote)
			{
				num ^= this.Vote.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x000FDE40 File Offset: 0x000FC040
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x000FDE58 File Offset: 0x000FC058
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x000FDE64 File Offset: 0x000FC064
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gameAccountId_.WriteTo(ref output, PartyVoteResponse._repeated_gameAccountId_codec);
			bool hasVote = this.HasVote;
			if (hasVote)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Vote);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x000FDEC4 File Offset: 0x000FC0C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gameAccountId_.CalculateSize(PartyVoteResponse._repeated_gameAccountId_codec);
			bool hasVote = this.HasVote;
			if (hasVote)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x000FDF1C File Offset: 0x000FC11C
		[DebuggerNonUserCode]
		public void MergeFrom(PartyVoteResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.gameAccountId_.Add(other.gameAccountId_);
				bool hasVote = other.HasVote;
				if (hasVote)
				{
					this.Vote = other.Vote;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x000FDF77 File Offset: 0x000FC177
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x000FDF84 File Offset: 0x000FC184
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Vote = input.ReadBool();
					}
				}
				else
				{
					this.gameAccountId_.AddEntriesFrom(ref input, PartyVoteResponse._repeated_gameAccountId_codec);
				}
			}
		}

		// Token: 0x04001D89 RID: 7561
		private static readonly MessageParser<PartyVoteResponse> _parser = new MessageParser<PartyVoteResponse>(() => new PartyVoteResponse());

		// Token: 0x04001D8A RID: 7562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D8B RID: 7563
		private int _hasBits0;

		// Token: 0x04001D8C RID: 7564
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001D8D RID: 7565
		private static readonly FieldCodec<uint> _repeated_gameAccountId_codec = FieldCodec.ForUInt32(8U);

		// Token: 0x04001D8E RID: 7566
		private readonly RepeatedField<uint> gameAccountId_ = new RepeatedField<uint>();

		// Token: 0x04001D8F RID: 7567
		public const int VoteFieldNumber = 2;

		// Token: 0x04001D90 RID: 7568
		private static readonly bool VoteDefaultValue = false;

		// Token: 0x04001D91 RID: 7569
		private bool vote_;
	}
}
