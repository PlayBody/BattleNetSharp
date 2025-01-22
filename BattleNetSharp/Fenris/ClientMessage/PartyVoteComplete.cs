using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200025D RID: 605
	public sealed class PartyVoteComplete : IMessage<PartyVoteComplete>, IMessage, IEquatable<PartyVoteComplete>, IDeepCloneable<PartyVoteComplete>, IBufferMessage
	{
		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x000FE024 File Offset: 0x000FC224
		[DebuggerNonUserCode]
		public static MessageParser<PartyVoteComplete> Parser
		{
			get
			{
				return PartyVoteComplete._parser;
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x000FE03C File Offset: 0x000FC23C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[77];
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x000FE060 File Offset: 0x000FC260
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyVoteComplete.Descriptor;
			}
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x000FE077 File Offset: 0x000FC277
		[DebuggerNonUserCode]
		public PartyVoteComplete()
		{
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x000FE081 File Offset: 0x000FC281
		[DebuggerNonUserCode]
		public PartyVoteComplete(PartyVoteComplete other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.votePassed_ = other.votePassed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x000FE0B4 File Offset: 0x000FC2B4
		[DebuggerNonUserCode]
		public PartyVoteComplete Clone()
		{
			return new PartyVoteComplete(this);
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x000FE0CC File Offset: 0x000FC2CC
		// (set) Token: 0x06004117 RID: 16663 RVA: 0x000FE0FD File Offset: 0x000FC2FD
		[DebuggerNonUserCode]
		public bool VotePassed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool votePassedDefaultValue;
				if (flag)
				{
					votePassedDefaultValue = this.votePassed_;
				}
				else
				{
					votePassedDefaultValue = PartyVoteComplete.VotePassedDefaultValue;
				}
				return votePassedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.votePassed_ = value;
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x000FE118 File Offset: 0x000FC318
		[DebuggerNonUserCode]
		public bool HasVotePassed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x000FE135 File Offset: 0x000FC335
		[DebuggerNonUserCode]
		public void ClearVotePassed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x000FE148 File Offset: 0x000FC348
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyVoteComplete);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x000FE168 File Offset: 0x000FC368
		[DebuggerNonUserCode]
		public bool Equals(PartyVoteComplete other)
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
					bool flag4 = this.VotePassed != other.VotePassed;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x000FE1C0 File Offset: 0x000FC3C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVotePassed = this.HasVotePassed;
			if (hasVotePassed)
			{
				num ^= this.VotePassed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x000FE210 File Offset: 0x000FC410
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x000FE228 File Offset: 0x000FC428
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x000FE234 File Offset: 0x000FC434
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVotePassed = this.HasVotePassed;
			if (hasVotePassed)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.VotePassed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x000FE280 File Offset: 0x000FC480
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVotePassed = this.HasVotePassed;
			if (hasVotePassed)
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

		// Token: 0x06004121 RID: 16673 RVA: 0x000FE2C4 File Offset: 0x000FC4C4
		[DebuggerNonUserCode]
		public void MergeFrom(PartyVoteComplete other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVotePassed = other.HasVotePassed;
				if (hasVotePassed)
				{
					this.VotePassed = other.VotePassed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x000FE30D File Offset: 0x000FC50D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x000FE318 File Offset: 0x000FC518
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
					this.VotePassed = input.ReadBool();
				}
			}
		}

		// Token: 0x04001D92 RID: 7570
		private static readonly MessageParser<PartyVoteComplete> _parser = new MessageParser<PartyVoteComplete>(() => new PartyVoteComplete());

		// Token: 0x04001D93 RID: 7571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D94 RID: 7572
		private int _hasBits0;

		// Token: 0x04001D95 RID: 7573
		public const int VotePassedFieldNumber = 1;

		// Token: 0x04001D96 RID: 7574
		private static readonly bool VotePassedDefaultValue = false;

		// Token: 0x04001D97 RID: 7575
		private bool votePassed_;
	}
}
