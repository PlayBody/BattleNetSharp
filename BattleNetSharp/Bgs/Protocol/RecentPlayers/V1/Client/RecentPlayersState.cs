using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000641 RID: 1601
	public sealed class RecentPlayersState : IMessage<RecentPlayersState>, IMessage, IEquatable<RecentPlayersState>, IDeepCloneable<RecentPlayersState>, IBufferMessage
	{
		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x060094FB RID: 38139 RVA: 0x00240974 File Offset: 0x0023EB74
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayersState> Parser
		{
			get
			{
				return RecentPlayersState._parser;
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x060094FC RID: 38140 RVA: 0x0024098C File Offset: 0x0023EB8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x060094FD RID: 38141 RVA: 0x002409B0 File Offset: 0x0023EBB0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayersState.Descriptor;
			}
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x002409C7 File Offset: 0x0023EBC7
		[DebuggerNonUserCode]
		public RecentPlayersState()
		{
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x002409DC File Offset: 0x0023EBDC
		[DebuggerNonUserCode]
		public RecentPlayersState(RecentPlayersState other)
			: this()
		{
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009500 RID: 38144 RVA: 0x00240A08 File Offset: 0x0023EC08
		[DebuggerNonUserCode]
		public RecentPlayersState Clone()
		{
			return new RecentPlayersState(this);
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x06009501 RID: 38145 RVA: 0x00240A20 File Offset: 0x0023EC20
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x00240A38 File Offset: 0x0023EC38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayersState);
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x00240A58 File Offset: 0x0023EC58
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayersState other)
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
					bool flag4 = !this.player_.Equals(other.player_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x00240AB4 File Offset: 0x0023ECB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.player_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x00240AF4 File Offset: 0x0023ECF4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009506 RID: 38150 RVA: 0x00240B0C File Offset: 0x0023ED0C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x00240B18 File Offset: 0x0023ED18
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.player_.WriteTo(ref output, RecentPlayersState._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009508 RID: 38152 RVA: 0x00240B54 File Offset: 0x0023ED54
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.player_.CalculateSize(RecentPlayersState._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x00240B9C File Offset: 0x0023ED9C
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayersState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x00240BDE File Offset: 0x0023EDDE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x00240BEC File Offset: 0x0023EDEC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.player_.AddEntriesFrom(ref input, RecentPlayersState._repeated_player_codec);
				}
			}
		}

		// Token: 0x0400431E RID: 17182
		private static readonly MessageParser<RecentPlayersState> _parser = new MessageParser<RecentPlayersState>(() => new RecentPlayersState());

		// Token: 0x0400431F RID: 17183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004320 RID: 17184
		public const int PlayerFieldNumber = 1;

		// Token: 0x04004321 RID: 17185
		private static readonly FieldCodec<RecentPlayer> _repeated_player_codec = FieldCodec.ForMessage<RecentPlayer>(10U, RecentPlayer.Parser);

		// Token: 0x04004322 RID: 17186
		private readonly RepeatedField<RecentPlayer> player_ = new RepeatedField<RecentPlayer>();
	}
}
