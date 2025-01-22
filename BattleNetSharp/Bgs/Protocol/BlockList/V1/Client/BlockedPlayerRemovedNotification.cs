using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006FA RID: 1786
	public sealed class BlockedPlayerRemovedNotification : IMessage<BlockedPlayerRemovedNotification>, IMessage, IEquatable<BlockedPlayerRemovedNotification>, IDeepCloneable<BlockedPlayerRemovedNotification>, IBufferMessage
	{
		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600A467 RID: 42087 RVA: 0x00280FC0 File Offset: 0x0027F1C0
		[DebuggerNonUserCode]
		public static MessageParser<BlockedPlayerRemovedNotification> Parser
		{
			get
			{
				return BlockedPlayerRemovedNotification._parser;
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600A468 RID: 42088 RVA: 0x00280FD8 File Offset: 0x0027F1D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600A469 RID: 42089 RVA: 0x00280FFC File Offset: 0x0027F1FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockedPlayerRemovedNotification.Descriptor;
			}
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x00281013 File Offset: 0x0027F213
		[DebuggerNonUserCode]
		public BlockedPlayerRemovedNotification()
		{
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x00281028 File Offset: 0x0027F228
		[DebuggerNonUserCode]
		public BlockedPlayerRemovedNotification(BlockedPlayerRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentAccountId_ = other.agentAccountId_;
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x00281078 File Offset: 0x0027F278
		[DebuggerNonUserCode]
		public BlockedPlayerRemovedNotification Clone()
		{
			return new BlockedPlayerRemovedNotification(this);
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x00281090 File Offset: 0x0027F290
		// (set) Token: 0x0600A46E RID: 42094 RVA: 0x002810C1 File Offset: 0x0027F2C1
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
					agentAccountIdDefaultValue = BlockedPlayerRemovedNotification.AgentAccountIdDefaultValue;
				}
				return agentAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.agentAccountId_ = value;
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600A46F RID: 42095 RVA: 0x002810DC File Offset: 0x0027F2DC
		[DebuggerNonUserCode]
		public bool HasAgentAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x002810F9 File Offset: 0x0027F2F9
		[DebuggerNonUserCode]
		public void ClearAgentAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600A471 RID: 42097 RVA: 0x0028110C File Offset: 0x0027F30C
		[DebuggerNonUserCode]
		public RepeatedField<UnblockPlayerAssignment> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x00281124 File Offset: 0x0027F324
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockedPlayerRemovedNotification);
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x00281144 File Offset: 0x0027F344
		[DebuggerNonUserCode]
		public bool Equals(BlockedPlayerRemovedNotification other)
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

		// Token: 0x0600A474 RID: 42100 RVA: 0x002811B8 File Offset: 0x0027F3B8
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

		// Token: 0x0600A475 RID: 42101 RVA: 0x00281218 File Offset: 0x0027F418
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x00281230 File Offset: 0x0027F430
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x0028123C File Offset: 0x0027F43C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AgentAccountId);
			}
			this.player_.WriteTo(ref output, BlockedPlayerRemovedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x0028129C File Offset: 0x0027F49C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AgentAccountId);
			}
			num += this.player_.CalculateSize(BlockedPlayerRemovedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x00281300 File Offset: 0x0027F500
		[DebuggerNonUserCode]
		public void MergeFrom(BlockedPlayerRemovedNotification other)
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

		// Token: 0x0600A47A RID: 42106 RVA: 0x0028135B File Offset: 0x0027F55B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x00281368 File Offset: 0x0027F568
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
						this.player_.AddEntriesFrom(ref input, BlockedPlayerRemovedNotification._repeated_player_codec);
					}
				}
				else
				{
					this.AgentAccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004A15 RID: 18965
		private static readonly MessageParser<BlockedPlayerRemovedNotification> _parser = new MessageParser<BlockedPlayerRemovedNotification>(() => new BlockedPlayerRemovedNotification());

		// Token: 0x04004A16 RID: 18966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A17 RID: 18967
		private int _hasBits0;

		// Token: 0x04004A18 RID: 18968
		public const int AgentAccountIdFieldNumber = 1;

		// Token: 0x04004A19 RID: 18969
		private static readonly ulong AgentAccountIdDefaultValue = 0UL;

		// Token: 0x04004A1A RID: 18970
		private ulong agentAccountId_;

		// Token: 0x04004A1B RID: 18971
		public const int PlayerFieldNumber = 2;

		// Token: 0x04004A1C RID: 18972
		private static readonly FieldCodec<UnblockPlayerAssignment> _repeated_player_codec = FieldCodec.ForMessage<UnblockPlayerAssignment>(18U, UnblockPlayerAssignment.Parser);

		// Token: 0x04004A1D RID: 18973
		private readonly RepeatedField<UnblockPlayerAssignment> player_ = new RepeatedField<UnblockPlayerAssignment>();
	}
}
