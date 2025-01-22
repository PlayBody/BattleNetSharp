using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200074E RID: 1870
	public sealed class GameAccountState : IMessage<GameAccountState>, IMessage, IEquatable<GameAccountState>, IDeepCloneable<GameAccountState>, IBufferMessage
	{
		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0600AC2C RID: 44076 RVA: 0x0029ED98 File Offset: 0x0029CF98
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountState> Parser
		{
			get
			{
				return GameAccountState._parser;
			}
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x0029EDB0 File Offset: 0x0029CFB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[30];
			}
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x0029EDD4 File Offset: 0x0029CFD4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountState.Descriptor;
			}
		}

		// Token: 0x0600AC2F RID: 44079 RVA: 0x0029EDEB File Offset: 0x0029CFEB
		[DebuggerNonUserCode]
		public GameAccountState()
		{
		}

		// Token: 0x0600AC30 RID: 44080 RVA: 0x0029EDF8 File Offset: 0x0029CFF8
		[DebuggerNonUserCode]
		public GameAccountState(GameAccountState other)
			: this()
		{
			this.gameLevelInfo_ = ((other.gameLevelInfo_ != null) ? other.gameLevelInfo_.Clone() : null);
			this.gameTimeInfo_ = ((other.gameTimeInfo_ != null) ? other.gameTimeInfo_.Clone() : null);
			this.gameStatus_ = ((other.gameStatus_ != null) ? other.gameStatus_.Clone() : null);
			this.rafInfo_ = ((other.rafInfo_ != null) ? other.rafInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC31 RID: 44081 RVA: 0x0029EE90 File Offset: 0x0029D090
		[DebuggerNonUserCode]
		public GameAccountState Clone()
		{
			return new GameAccountState(this);
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0600AC32 RID: 44082 RVA: 0x0029EEA8 File Offset: 0x0029D0A8
		// (set) Token: 0x0600AC33 RID: 44083 RVA: 0x0029EEC0 File Offset: 0x0029D0C0
		[DebuggerNonUserCode]
		public GameLevelInfo GameLevelInfo
		{
			get
			{
				return this.gameLevelInfo_;
			}
			set
			{
				this.gameLevelInfo_ = value;
			}
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0600AC34 RID: 44084 RVA: 0x0029EECC File Offset: 0x0029D0CC
		// (set) Token: 0x0600AC35 RID: 44085 RVA: 0x0029EEE4 File Offset: 0x0029D0E4
		[DebuggerNonUserCode]
		public GameTimeInfo GameTimeInfo
		{
			get
			{
				return this.gameTimeInfo_;
			}
			set
			{
				this.gameTimeInfo_ = value;
			}
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x0029EEF0 File Offset: 0x0029D0F0
		// (set) Token: 0x0600AC37 RID: 44087 RVA: 0x0029EF08 File Offset: 0x0029D108
		[DebuggerNonUserCode]
		public GameStatus GameStatus
		{
			get
			{
				return this.gameStatus_;
			}
			set
			{
				this.gameStatus_ = value;
			}
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600AC38 RID: 44088 RVA: 0x0029EF14 File Offset: 0x0029D114
		// (set) Token: 0x0600AC39 RID: 44089 RVA: 0x0029EF2C File Offset: 0x0029D12C
		[DebuggerNonUserCode]
		public RAFInfo RafInfo
		{
			get
			{
				return this.rafInfo_;
			}
			set
			{
				this.rafInfo_ = value;
			}
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x0029EF38 File Offset: 0x0029D138
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountState);
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x0029EF58 File Offset: 0x0029D158
		[DebuggerNonUserCode]
		public bool Equals(GameAccountState other)
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
					bool flag4 = !object.Equals(this.GameLevelInfo, other.GameLevelInfo);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameTimeInfo, other.GameTimeInfo);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.GameStatus, other.GameStatus);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.RafInfo, other.RafInfo);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x0029F014 File Offset: 0x0029D214
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameLevelInfo_ != null;
			if (flag)
			{
				num ^= this.GameLevelInfo.GetHashCode();
			}
			bool flag2 = this.gameTimeInfo_ != null;
			if (flag2)
			{
				num ^= this.GameTimeInfo.GetHashCode();
			}
			bool flag3 = this.gameStatus_ != null;
			if (flag3)
			{
				num ^= this.GameStatus.GetHashCode();
			}
			bool flag4 = this.rafInfo_ != null;
			if (flag4)
			{
				num ^= this.RafInfo.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x0029F0B8 File Offset: 0x0029D2B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x0029F0D0 File Offset: 0x0029D2D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x0029F0DC File Offset: 0x0029D2DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameLevelInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameLevelInfo);
			}
			bool flag2 = this.gameTimeInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameTimeInfo);
			}
			bool flag3 = this.gameStatus_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GameStatus);
			}
			bool flag4 = this.rafInfo_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RafInfo);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x0029F19C File Offset: 0x0029D39C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameLevelInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameLevelInfo);
			}
			bool flag2 = this.gameTimeInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameTimeInfo);
			}
			bool flag3 = this.gameStatus_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameStatus);
			}
			bool flag4 = this.rafInfo_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RafInfo);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC41 RID: 44097 RVA: 0x0029F250 File Offset: 0x0029D450
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameLevelInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.gameLevelInfo_ == null;
					if (flag3)
					{
						this.GameLevelInfo = new GameLevelInfo();
					}
					this.GameLevelInfo.MergeFrom(other.GameLevelInfo);
				}
				bool flag4 = other.gameTimeInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.gameTimeInfo_ == null;
					if (flag5)
					{
						this.GameTimeInfo = new GameTimeInfo();
					}
					this.GameTimeInfo.MergeFrom(other.GameTimeInfo);
				}
				bool flag6 = other.gameStatus_ != null;
				if (flag6)
				{
					bool flag7 = this.gameStatus_ == null;
					if (flag7)
					{
						this.GameStatus = new GameStatus();
					}
					this.GameStatus.MergeFrom(other.GameStatus);
				}
				bool flag8 = other.rafInfo_ != null;
				if (flag8)
				{
					bool flag9 = this.rafInfo_ == null;
					if (flag9)
					{
						this.RafInfo = new RAFInfo();
					}
					this.RafInfo.MergeFrom(other.RafInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AC42 RID: 44098 RVA: 0x0029F37D File Offset: 0x0029D57D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x0029F388 File Offset: 0x0029D588
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_002F;
						}
						bool flag = this.gameTimeInfo_ == null;
						if (flag)
						{
							this.GameTimeInfo = new GameTimeInfo();
						}
						input.ReadMessage(this.GameTimeInfo);
					}
					else
					{
						bool flag2 = this.gameLevelInfo_ == null;
						if (flag2)
						{
							this.GameLevelInfo = new GameLevelInfo();
						}
						input.ReadMessage(this.GameLevelInfo);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag3 = this.rafInfo_ == null;
					if (flag3)
					{
						this.RafInfo = new RAFInfo();
					}
					input.ReadMessage(this.RafInfo);
				}
				else
				{
					bool flag4 = this.gameStatus_ == null;
					if (flag4)
					{
						this.GameStatus = new GameStatus();
					}
					input.ReadMessage(this.GameStatus);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D93 RID: 19859
		private static readonly MessageParser<GameAccountState> _parser = new MessageParser<GameAccountState>(() => new GameAccountState());

		// Token: 0x04004D94 RID: 19860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D95 RID: 19861
		public const int GameLevelInfoFieldNumber = 1;

		// Token: 0x04004D96 RID: 19862
		private GameLevelInfo gameLevelInfo_;

		// Token: 0x04004D97 RID: 19863
		public const int GameTimeInfoFieldNumber = 2;

		// Token: 0x04004D98 RID: 19864
		private GameTimeInfo gameTimeInfo_;

		// Token: 0x04004D99 RID: 19865
		public const int GameStatusFieldNumber = 3;

		// Token: 0x04004D9A RID: 19866
		private GameStatus gameStatus_;

		// Token: 0x04004D9B RID: 19867
		public const int RafInfoFieldNumber = 4;

		// Token: 0x04004D9C RID: 19868
		private RAFInfo rafInfo_;
	}
}
