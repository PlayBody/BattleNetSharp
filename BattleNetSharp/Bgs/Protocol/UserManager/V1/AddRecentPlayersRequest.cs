using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003B6 RID: 950
	public sealed class AddRecentPlayersRequest : IMessage<AddRecentPlayersRequest>, IMessage, IEquatable<AddRecentPlayersRequest>, IDeepCloneable<AddRecentPlayersRequest>, IBufferMessage
	{
		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06005F7B RID: 24443 RVA: 0x001720EC File Offset: 0x001702EC
		[DebuggerNonUserCode]
		public static MessageParser<AddRecentPlayersRequest> Parser
		{
			get
			{
				return AddRecentPlayersRequest._parser;
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x00172104 File Offset: 0x00170304
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06005F7D RID: 24445 RVA: 0x00172128 File Offset: 0x00170328
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRecentPlayersRequest.Descriptor;
			}
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x0017213F File Offset: 0x0017033F
		[DebuggerNonUserCode]
		public AddRecentPlayersRequest()
		{
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x00172154 File Offset: 0x00170354
		[DebuggerNonUserCode]
		public AddRecentPlayersRequest(AddRecentPlayersRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.players_ = other.players_.Clone();
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x001721C0 File Offset: 0x001703C0
		[DebuggerNonUserCode]
		public AddRecentPlayersRequest Clone()
		{
			return new AddRecentPlayersRequest(this);
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06005F81 RID: 24449 RVA: 0x001721D8 File Offset: 0x001703D8
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayer> Players
		{
			get
			{
				return this.players_;
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x001721F0 File Offset: 0x001703F0
		// (set) Token: 0x06005F83 RID: 24451 RVA: 0x00172208 File Offset: 0x00170408
		[DebuggerNonUserCode]
		public EntityId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06005F84 RID: 24452 RVA: 0x00172214 File Offset: 0x00170414
		// (set) Token: 0x06005F85 RID: 24453 RVA: 0x00172245 File Offset: 0x00170445
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = AddRecentPlayersRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x00172260 File Offset: 0x00170460
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x0017227D File Offset: 0x0017047D
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x00172290 File Offset: 0x00170490
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddRecentPlayersRequest);
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x001722B0 File Offset: 0x001704B0
		[DebuggerNonUserCode]
		public bool Equals(AddRecentPlayersRequest other)
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
					bool flag4 = !this.players_.Equals(other.players_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AgentId, other.AgentId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Program != other.Program;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x00172344 File Offset: 0x00170544
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.players_.GetHashCode();
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x001723C0 File Offset: 0x001705C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x001723D8 File Offset: 0x001705D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x001723E4 File Offset: 0x001705E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.players_.WriteTo(ref output, AddRecentPlayersRequest._repeated_players_codec);
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AgentId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Program);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x00172468 File Offset: 0x00170668
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.players_.CalculateSize(AddRecentPlayersRequest._repeated_players_codec);
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x001724EC File Offset: 0x001706EC
		[DebuggerNonUserCode]
		public void MergeFrom(AddRecentPlayersRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.players_.Add(other.players_);
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x00172583 File Offset: 0x00170783
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x00172590 File Offset: 0x00170790
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Program = input.ReadUInt32();
						}
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new EntityId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else
				{
					this.players_.AddEntriesFrom(ref input, AddRecentPlayersRequest._repeated_players_codec);
				}
			}
		}

		// Token: 0x04002BA7 RID: 11175
		private static readonly MessageParser<AddRecentPlayersRequest> _parser = new MessageParser<AddRecentPlayersRequest>(() => new AddRecentPlayersRequest());

		// Token: 0x04002BA8 RID: 11176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BA9 RID: 11177
		private int _hasBits0;

		// Token: 0x04002BAA RID: 11178
		public const int PlayersFieldNumber = 1;

		// Token: 0x04002BAB RID: 11179
		private static readonly FieldCodec<RecentPlayer> _repeated_players_codec = FieldCodec.ForMessage<RecentPlayer>(10U, RecentPlayer.Parser);

		// Token: 0x04002BAC RID: 11180
		private readonly RepeatedField<RecentPlayer> players_ = new RepeatedField<RecentPlayer>();

		// Token: 0x04002BAD RID: 11181
		public const int AgentIdFieldNumber = 2;

		// Token: 0x04002BAE RID: 11182
		private EntityId agentId_;

		// Token: 0x04002BAF RID: 11183
		public const int ProgramFieldNumber = 3;

		// Token: 0x04002BB0 RID: 11184
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002BB1 RID: 11185
		private uint program_;
	}
}
