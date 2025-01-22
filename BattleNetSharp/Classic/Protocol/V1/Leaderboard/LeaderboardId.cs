using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Leaderboard
{
	// Token: 0x02000762 RID: 1890
	public sealed class LeaderboardId : IMessage<LeaderboardId>, IMessage, IEquatable<LeaderboardId>, IDeepCloneable<LeaderboardId>, IBufferMessage
	{
		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600ADC1 RID: 44481 RVA: 0x002A5190 File Offset: 0x002A3390
		[DebuggerNonUserCode]
		public static MessageParser<LeaderboardId> Parser
		{
			get
			{
				return LeaderboardId._parser;
			}
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x002A51A8 File Offset: 0x002A33A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600ADC3 RID: 44483 RVA: 0x002A51CC File Offset: 0x002A33CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaderboardId.Descriptor;
			}
		}

		// Token: 0x0600ADC4 RID: 44484 RVA: 0x002A51E3 File Offset: 0x002A33E3
		[DebuggerNonUserCode]
		public LeaderboardId()
		{
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x002A51ED File Offset: 0x002A33ED
		[DebuggerNonUserCode]
		public LeaderboardId(LeaderboardId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.unk_ = other.unk_;
			this.leaderboardId_ = other.leaderboardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x002A522C File Offset: 0x002A342C
		[DebuggerNonUserCode]
		public LeaderboardId Clone()
		{
			return new LeaderboardId(this);
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600ADC7 RID: 44487 RVA: 0x002A5244 File Offset: 0x002A3444
		// (set) Token: 0x0600ADC8 RID: 44488 RVA: 0x002A5275 File Offset: 0x002A3475
		[DebuggerNonUserCode]
		public int Unk
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int unkDefaultValue;
				if (flag)
				{
					unkDefaultValue = this.unk_;
				}
				else
				{
					unkDefaultValue = LeaderboardId.UnkDefaultValue;
				}
				return unkDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.unk_ = value;
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600ADC9 RID: 44489 RVA: 0x002A5290 File Offset: 0x002A3490
		[DebuggerNonUserCode]
		public bool HasUnk
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x002A52AD File Offset: 0x002A34AD
		[DebuggerNonUserCode]
		public void ClearUnk()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600ADCB RID: 44491 RVA: 0x002A52C0 File Offset: 0x002A34C0
		// (set) Token: 0x0600ADCC RID: 44492 RVA: 0x002A52E1 File Offset: 0x002A34E1
		[DebuggerNonUserCode]
		public string LeaderboardId_
		{
			get
			{
				return this.leaderboardId_ ?? LeaderboardId.LeaderboardId_DefaultValue;
			}
			set
			{
				this.leaderboardId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0600ADCD RID: 44493 RVA: 0x002A52F8 File Offset: 0x002A34F8
		[DebuggerNonUserCode]
		public bool HasLeaderboardId_
		{
			get
			{
				return this.leaderboardId_ != null;
			}
		}

		// Token: 0x0600ADCE RID: 44494 RVA: 0x002A5313 File Offset: 0x002A3513
		[DebuggerNonUserCode]
		public void ClearLeaderboardId_()
		{
			this.leaderboardId_ = null;
		}

		// Token: 0x0600ADCF RID: 44495 RVA: 0x002A5320 File Offset: 0x002A3520
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaderboardId);
		}

		// Token: 0x0600ADD0 RID: 44496 RVA: 0x002A5340 File Offset: 0x002A3540
		[DebuggerNonUserCode]
		public bool Equals(LeaderboardId other)
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
					bool flag4 = this.Unk != other.Unk;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LeaderboardId_ != other.LeaderboardId_;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x002A53B4 File Offset: 0x002A35B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUnk = this.HasUnk;
			if (hasUnk)
			{
				num ^= this.Unk.GetHashCode();
			}
			bool hasLeaderboardId_ = this.HasLeaderboardId_;
			if (hasLeaderboardId_)
			{
				num ^= this.LeaderboardId_.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x002A5420 File Offset: 0x002A3620
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x002A5438 File Offset: 0x002A3638
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x002A5444 File Offset: 0x002A3644
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUnk = this.HasUnk;
			if (hasUnk)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Unk);
			}
			bool hasLeaderboardId_ = this.HasLeaderboardId_;
			if (hasLeaderboardId_)
			{
				output.WriteRawTag(18);
				output.WriteString(this.LeaderboardId_);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADD5 RID: 44501 RVA: 0x002A54B4 File Offset: 0x002A36B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUnk = this.HasUnk;
			if (hasUnk)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Unk);
			}
			bool hasLeaderboardId_ = this.HasLeaderboardId_;
			if (hasLeaderboardId_)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LeaderboardId_);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADD6 RID: 44502 RVA: 0x002A5520 File Offset: 0x002A3720
		[DebuggerNonUserCode]
		public void MergeFrom(LeaderboardId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUnk = other.HasUnk;
				if (hasUnk)
				{
					this.Unk = other.Unk;
				}
				bool hasLeaderboardId_ = other.HasLeaderboardId_;
				if (hasLeaderboardId_)
				{
					this.LeaderboardId_ = other.LeaderboardId_;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ADD7 RID: 44503 RVA: 0x002A5582 File Offset: 0x002A3782
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADD8 RID: 44504 RVA: 0x002A5590 File Offset: 0x002A3790
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LeaderboardId_ = input.ReadString();
					}
				}
				else
				{
					this.Unk = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E51 RID: 20049
		private static readonly MessageParser<LeaderboardId> _parser = new MessageParser<LeaderboardId>(() => new LeaderboardId());

		// Token: 0x04004E52 RID: 20050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E53 RID: 20051
		private int _hasBits0;

		// Token: 0x04004E54 RID: 20052
		public const int UnkFieldNumber = 1;

		// Token: 0x04004E55 RID: 20053
		private static readonly int UnkDefaultValue = 0;

		// Token: 0x04004E56 RID: 20054
		private int unk_;

		// Token: 0x04004E57 RID: 20055
		public const int LeaderboardId_FieldNumber = 2;

		// Token: 0x04004E58 RID: 20056
		private static readonly string LeaderboardId_DefaultValue = "";

		// Token: 0x04004E59 RID: 20057
		private string leaderboardId_;
	}
}
