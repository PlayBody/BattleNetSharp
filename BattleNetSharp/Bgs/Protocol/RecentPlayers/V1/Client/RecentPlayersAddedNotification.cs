using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200062F RID: 1583
	public sealed class RecentPlayersAddedNotification : IMessage<RecentPlayersAddedNotification>, IMessage, IEquatable<RecentPlayersAddedNotification>, IDeepCloneable<RecentPlayersAddedNotification>, IBufferMessage
	{
		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x060093C4 RID: 37828 RVA: 0x0023C97C File Offset: 0x0023AB7C
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayersAddedNotification> Parser
		{
			get
			{
				return RecentPlayersAddedNotification._parser;
			}
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x0023C994 File Offset: 0x0023AB94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x060093C6 RID: 37830 RVA: 0x0023C9B8 File Offset: 0x0023ABB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayersAddedNotification.Descriptor;
			}
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x0023C9CF File Offset: 0x0023ABCF
		[DebuggerNonUserCode]
		public RecentPlayersAddedNotification()
		{
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x0023C9E4 File Offset: 0x0023ABE4
		[DebuggerNonUserCode]
		public RecentPlayersAddedNotification(RecentPlayersAddedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentAccountId_ = other.agentAccountId_;
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x0023CA34 File Offset: 0x0023AC34
		[DebuggerNonUserCode]
		public RecentPlayersAddedNotification Clone()
		{
			return new RecentPlayersAddedNotification(this);
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x060093CA RID: 37834 RVA: 0x0023CA4C File Offset: 0x0023AC4C
		// (set) Token: 0x060093CB RID: 37835 RVA: 0x0023CA7D File Offset: 0x0023AC7D
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
					agentAccountIdDefaultValue = RecentPlayersAddedNotification.AgentAccountIdDefaultValue;
				}
				return agentAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.agentAccountId_ = value;
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x060093CC RID: 37836 RVA: 0x0023CA98 File Offset: 0x0023AC98
		[DebuggerNonUserCode]
		public bool HasAgentAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x0023CAB5 File Offset: 0x0023ACB5
		[DebuggerNonUserCode]
		public void ClearAgentAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x060093CE RID: 37838 RVA: 0x0023CAC8 File Offset: 0x0023ACC8
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x0023CAE0 File Offset: 0x0023ACE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayersAddedNotification);
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x0023CB00 File Offset: 0x0023AD00
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayersAddedNotification other)
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

		// Token: 0x060093D1 RID: 37841 RVA: 0x0023CB74 File Offset: 0x0023AD74
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

		// Token: 0x060093D2 RID: 37842 RVA: 0x0023CBD4 File Offset: 0x0023ADD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x0023CBEC File Offset: 0x0023ADEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x0023CBF8 File Offset: 0x0023ADF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AgentAccountId);
			}
			this.player_.WriteTo(ref output, RecentPlayersAddedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x0023CC58 File Offset: 0x0023AE58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAgentAccountId = this.HasAgentAccountId;
			if (hasAgentAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AgentAccountId);
			}
			num += this.player_.CalculateSize(RecentPlayersAddedNotification._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x0023CCBC File Offset: 0x0023AEBC
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayersAddedNotification other)
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

		// Token: 0x060093D7 RID: 37847 RVA: 0x0023CD17 File Offset: 0x0023AF17
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x0023CD24 File Offset: 0x0023AF24
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
						this.player_.AddEntriesFrom(ref input, RecentPlayersAddedNotification._repeated_player_codec);
					}
				}
				else
				{
					this.AgentAccountId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040042AD RID: 17069
		private static readonly MessageParser<RecentPlayersAddedNotification> _parser = new MessageParser<RecentPlayersAddedNotification>(() => new RecentPlayersAddedNotification());

		// Token: 0x040042AE RID: 17070
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042AF RID: 17071
		private int _hasBits0;

		// Token: 0x040042B0 RID: 17072
		public const int AgentAccountIdFieldNumber = 1;

		// Token: 0x040042B1 RID: 17073
		private static readonly ulong AgentAccountIdDefaultValue = 0UL;

		// Token: 0x040042B2 RID: 17074
		private ulong agentAccountId_;

		// Token: 0x040042B3 RID: 17075
		public const int PlayerFieldNumber = 2;

		// Token: 0x040042B4 RID: 17076
		private static readonly FieldCodec<RecentPlayer> _repeated_player_codec = FieldCodec.ForMessage<RecentPlayer>(18U, RecentPlayer.Parser);

		// Token: 0x040042B5 RID: 17077
		private readonly RepeatedField<RecentPlayer> player_ = new RepeatedField<RecentPlayer>();
	}
}
