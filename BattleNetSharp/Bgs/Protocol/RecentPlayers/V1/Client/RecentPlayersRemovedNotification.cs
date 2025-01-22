using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000630 RID: 1584
	public sealed class RecentPlayersRemovedNotification : IMessage<RecentPlayersRemovedNotification>, IMessage, IEquatable<RecentPlayersRemovedNotification>, IDeepCloneable<RecentPlayersRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x060093DA RID: 37850 RVA: 0x0023CDC4 File Offset: 0x0023AFC4
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayersRemovedNotification> Parser
		{
			get
			{
				return RecentPlayersRemovedNotification._parser;
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x060093DB RID: 37851 RVA: 0x0023CDDC File Offset: 0x0023AFDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x060093DC RID: 37852 RVA: 0x0023CE00 File Offset: 0x0023B000
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayersRemovedNotification.Descriptor;
			}
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x0023CE17 File Offset: 0x0023B017
		[DebuggerNonUserCode]
		public RecentPlayersRemovedNotification()
		{
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x0023CE2C File Offset: 0x0023B02C
		[DebuggerNonUserCode]
		public RecentPlayersRemovedNotification(RecentPlayersRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentAccountId_ = other.agentAccountId_;
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x0023CE7C File Offset: 0x0023B07C
		[DebuggerNonUserCode]
		public RecentPlayersRemovedNotification Clone()
		{
			return new RecentPlayersRemovedNotification(this);
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x060093E0 RID: 37856 RVA: 0x0023CE94 File Offset: 0x0023B094
		// (set) Token: 0x060093E1 RID: 37857 RVA: 0x0023CEC5 File Offset: 0x0023B0C5
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
					agentAccountIdDefaultValue = RecentPlayersRemovedNotification.AgentAccountIdDefaultValue;
				}
				return agentAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.agentAccountId_ = value;
			}
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x060093E2 RID: 37858 RVA: 0x0023CEE0 File Offset: 0x0023B0E0
		[DebuggerNonUserCode]
		public bool HasAgentAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x0023CEFD File Offset: 0x0023B0FD
		[DebuggerNonUserCode]
		public void ClearAgentAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x060093E4 RID: 37860 RVA: 0x0023CF10 File Offset: 0x0023B110
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayerRemovedAssignment> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x0023CF28 File Offset: 0x0023B128
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayersRemovedNotification);
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x0023CF48 File Offset: 0x0023B148
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayersRemovedNotification other)
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

		// Token: 0x060093E7 RID: 37863 RVA: 0x0023CFBC File Offset: 0x0023B1BC
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

		// Token: 0x060093E8 RID: 37864 RVA: 0x0023D01C File Offset: 0x0023B21C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x0023D034 File Offset: 0x0023B234
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x0023D040 File Offset: 0x0023B240
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AgentAccountId);
			}
			this.player_.WriteTo(ref output, RecentPlayersRemovedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x0023D0A0 File Offset: 0x0023B2A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AgentAccountId);
			}
			num += this.player_.CalculateSize(RecentPlayersRemovedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093EC RID: 37868 RVA: 0x0023D104 File Offset: 0x0023B304
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayersRemovedNotification other)
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

		// Token: 0x060093ED RID: 37869 RVA: 0x0023D15F File Offset: 0x0023B35F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093EE RID: 37870 RVA: 0x0023D16C File Offset: 0x0023B36C
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
						this.player_.AddEntriesFrom(ref input, RecentPlayersRemovedNotification._repeated_player_codec);
					}
				}
				else
				{
					this.AgentAccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040042B6 RID: 17078
		private static readonly MessageParser<RecentPlayersRemovedNotification> _parser = new MessageParser<RecentPlayersRemovedNotification>(() => new RecentPlayersRemovedNotification());

		// Token: 0x040042B7 RID: 17079
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042B8 RID: 17080
		private int _hasBits0;

		// Token: 0x040042B9 RID: 17081
		public const int AgentAccountIdFieldNumber = 1;

		// Token: 0x040042BA RID: 17082
		private static readonly ulong AgentAccountIdDefaultValue = 0UL;

		// Token: 0x040042BB RID: 17083
		private ulong agentAccountId_;

		// Token: 0x040042BC RID: 17084
		public const int PlayerFieldNumber = 2;

		// Token: 0x040042BD RID: 17085
		private static readonly FieldCodec<RecentPlayerRemovedAssignment> _repeated_player_codec = FieldCodec.ForMessage<RecentPlayerRemovedAssignment>(18U, RecentPlayerRemovedAssignment.Parser);

		// Token: 0x040042BE RID: 17086
		private readonly RepeatedField<RecentPlayerRemovedAssignment> player_ = new RepeatedField<RecentPlayerRemovedAssignment>();
	}
}
