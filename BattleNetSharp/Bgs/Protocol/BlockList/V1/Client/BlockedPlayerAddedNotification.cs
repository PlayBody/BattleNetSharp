using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006F9 RID: 1785
	public sealed class BlockedPlayerAddedNotification : IMessage<BlockedPlayerAddedNotification>, IMessage, IEquatable<BlockedPlayerAddedNotification>, IDeepCloneable<BlockedPlayerAddedNotification>, IBufferMessage
	{
		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600A451 RID: 42065 RVA: 0x00280B78 File Offset: 0x0027ED78
		[DebuggerNonUserCode]
		public static MessageParser<BlockedPlayerAddedNotification> Parser
		{
			get
			{
				return BlockedPlayerAddedNotification._parser;
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600A452 RID: 42066 RVA: 0x00280B90 File Offset: 0x0027ED90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600A453 RID: 42067 RVA: 0x00280BB4 File Offset: 0x0027EDB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayerAddedNotification.Descriptor;
			}
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x00280BCB File Offset: 0x0027EDCB
		[DebuggerNonUserCode]
		public BlockedPlayerAddedNotification()
		{
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x00280BE0 File Offset: 0x0027EDE0
		[DebuggerNonUserCode]
		public BlockedPlayerAddedNotification(BlockedPlayerAddedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentAccountId_ = other.agentAccountId_;
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x00280C30 File Offset: 0x0027EE30
		[DebuggerNonUserCode]
		public BlockedPlayerAddedNotification Clone()
		{
			return new BlockedPlayerAddedNotification(this);
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600A457 RID: 42071 RVA: 0x00280C48 File Offset: 0x0027EE48
		// (set) Token: 0x0600A458 RID: 42072 RVA: 0x00280C79 File Offset: 0x0027EE79
		[DebuggerNonUserCode]
		public ulong AgentAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong agentAccountIdDefaultValue;
				if (flag)
				{
					agentAccountIdDefaultValue = this.agentAccountId_;
				}
				else
				{
					agentAccountIdDefaultValue = BlockedPlayerAddedNotification.AgentAccountIdDefaultValue;
				}
				return agentAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.agentAccountId_ = value;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600A459 RID: 42073 RVA: 0x00280C94 File Offset: 0x0027EE94
		[DebuggerNonUserCode]
		public bool HasAgentAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x00280CB1 File Offset: 0x0027EEB1
		[DebuggerNonUserCode]
		public void ClearAgentAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x00280CC4 File Offset: 0x0027EEC4
		[DebuggerNonUserCode]
		public RepeatedField<BlockedPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x0600A45C RID: 42076 RVA: 0x00280CDC File Offset: 0x0027EEDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayerAddedNotification);
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x00280CFC File Offset: 0x0027EEFC
		[DebuggerNonUserCode]
		public bool Equals(BlockedPlayerAddedNotification other)
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
					bool flag4 = this.AgentAccountId != other.AgentAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.player_.Equals(other.player_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x00280D70 File Offset: 0x0027EF70
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				num ^= this.AgentAccountId.GetHashCode();
			}
			num ^= this.player_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x00280DD0 File Offset: 0x0027EFD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x00280DE8 File Offset: 0x0027EFE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x00280DF4 File Offset: 0x0027EFF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AgentAccountId);
			}
			this.player_.WriteTo(ref output, BlockedPlayerAddedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x00280E54 File Offset: 0x0027F054
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AgentAccountId);
			}
			num += this.player_.CalculateSize(BlockedPlayerAddedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x00280EB8 File Offset: 0x0027F0B8
		[DebuggerNonUserCode]
		public void MergeFrom(BlockedPlayerAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAgentAccountId = other.HasAgentAccountId;
				if (hasAgentAccountId)
				{
					this.AgentAccountId = other.AgentAccountId;
				}
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x00280F13 File Offset: 0x0027F113
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x00280F20 File Offset: 0x0027F120
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
						this.player_.AddEntriesFrom(ref input, BlockedPlayerAddedNotification._repeated_player_codec);
					}
				}
				else
				{
					this.AgentAccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004A0C RID: 18956
		private static readonly MessageParser<BlockedPlayerAddedNotification> _parser = new MessageParser<BlockedPlayerAddedNotification>(() => new BlockedPlayerAddedNotification());

		// Token: 0x04004A0D RID: 18957
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A0E RID: 18958
		private int _hasBits0;

		// Token: 0x04004A0F RID: 18959
		public const int AgentAccountIdFieldNumber = 1;

		// Token: 0x04004A10 RID: 18960
		private static readonly ulong AgentAccountIdDefaultValue = 0UL;

		// Token: 0x04004A11 RID: 18961
		private ulong agentAccountId_;

		// Token: 0x04004A12 RID: 18962
		public const int PlayerFieldNumber = 2;

		// Token: 0x04004A13 RID: 18963
		private static readonly FieldCodec<BlockedPlayer> _repeated_player_codec = FieldCodec.ForMessage<BlockedPlayer>(18U, BlockedPlayer.Parser);

		// Token: 0x04004A14 RID: 18964
		private readonly RepeatedField<BlockedPlayer> player_ = new RepeatedField<BlockedPlayer>();
	}
}
