using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003ED RID: 1005
	public sealed class GameHandle : IMessage<GameHandle>, IMessage, IEquatable<GameHandle>, IDeepCloneable<GameHandle>, IBufferMessage
	{
		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x060063E8 RID: 25576 RVA: 0x001822AC File Offset: 0x001804AC
		[DebuggerNonUserCode]
		public static MessageParser<GameHandle> Parser
		{
			get
			{
				return GameHandle._parser;
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x060063E9 RID: 25577 RVA: 0x001822C4 File Offset: 0x001804C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x060063EA RID: 25578 RVA: 0x001822E8 File Offset: 0x001804E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameHandle.Descriptor;
			}
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x001822FF File Offset: 0x001804FF
		[DebuggerNonUserCode]
		public GameHandle()
		{
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x0018230C File Offset: 0x0018050C
		[DebuggerNonUserCode]
		public GameHandle(GameHandle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.matchmaker_ = ((other.matchmaker_ != null) ? other.matchmaker_.Clone() : null);
			this.gameServer_ = ((other.gameServer_ != null) ? other.gameServer_.Clone() : null);
			this.gameInstanceId_ = other.gameInstanceId_;
			this.matchmakerGuid_ = other.matchmakerGuid_;
			this.gameServerGuid_ = other.gameServerGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x0018239C File Offset: 0x0018059C
		[DebuggerNonUserCode]
		public GameHandle Clone()
		{
			return new GameHandle(this);
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x060063EE RID: 25582 RVA: 0x001823B4 File Offset: 0x001805B4
		// (set) Token: 0x060063EF RID: 25583 RVA: 0x001823CC File Offset: 0x001805CC
		[Obsolete]
		[DebuggerNonUserCode]
		public MatchmakerHandle Matchmaker
		{
			get
			{
				return this.matchmaker_;
			}
			set
			{
				this.matchmaker_ = value;
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x060063F0 RID: 25584 RVA: 0x001823D8 File Offset: 0x001805D8
		// (set) Token: 0x060063F1 RID: 25585 RVA: 0x001823F0 File Offset: 0x001805F0
		[Obsolete]
		[DebuggerNonUserCode]
		public HostProxyPair GameServer
		{
			get
			{
				return this.gameServer_;
			}
			set
			{
				this.gameServer_ = value;
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x001823FC File Offset: 0x001805FC
		// (set) Token: 0x060063F3 RID: 25587 RVA: 0x0018242D File Offset: 0x0018062D
		[DebuggerNonUserCode]
		public uint GameInstanceId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameInstanceIdDefaultValue;
				if (flag)
				{
					gameInstanceIdDefaultValue = this.gameInstanceId_;
				}
				else
				{
					gameInstanceIdDefaultValue = GameHandle.GameInstanceIdDefaultValue;
				}
				return gameInstanceIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameInstanceId_ = value;
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x060063F4 RID: 25588 RVA: 0x00182448 File Offset: 0x00180648
		[DebuggerNonUserCode]
		public bool HasGameInstanceId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x00182465 File Offset: 0x00180665
		[DebuggerNonUserCode]
		public void ClearGameInstanceId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x060063F6 RID: 25590 RVA: 0x00182478 File Offset: 0x00180678
		// (set) Token: 0x060063F7 RID: 25591 RVA: 0x001824A9 File Offset: 0x001806A9
		[DebuggerNonUserCode]
		public ulong MatchmakerGuid
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong matchmakerGuidDefaultValue;
				if (flag)
				{
					matchmakerGuidDefaultValue = this.matchmakerGuid_;
				}
				else
				{
					matchmakerGuidDefaultValue = GameHandle.MatchmakerGuidDefaultValue;
				}
				return matchmakerGuidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.matchmakerGuid_ = value;
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x060063F8 RID: 25592 RVA: 0x001824C4 File Offset: 0x001806C4
		[DebuggerNonUserCode]
		public bool HasMatchmakerGuid
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x001824E1 File Offset: 0x001806E1
		[DebuggerNonUserCode]
		public void ClearMatchmakerGuid()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x060063FA RID: 25594 RVA: 0x001824F4 File Offset: 0x001806F4
		// (set) Token: 0x060063FB RID: 25595 RVA: 0x00182525 File Offset: 0x00180725
		[DebuggerNonUserCode]
		public ulong GameServerGuid
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong gameServerGuidDefaultValue;
				if (flag)
				{
					gameServerGuidDefaultValue = this.gameServerGuid_;
				}
				else
				{
					gameServerGuidDefaultValue = GameHandle.GameServerGuidDefaultValue;
				}
				return gameServerGuidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gameServerGuid_ = value;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x060063FC RID: 25596 RVA: 0x00182540 File Offset: 0x00180740
		[DebuggerNonUserCode]
		public bool HasGameServerGuid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x0018255D File Offset: 0x0018075D
		[DebuggerNonUserCode]
		public void ClearGameServerGuid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00182570 File Offset: 0x00180770
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameHandle);
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00182590 File Offset: 0x00180790
		[DebuggerNonUserCode]
		public bool Equals(GameHandle other)
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
					bool flag4 = !object.Equals(this.Matchmaker, other.Matchmaker);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameServer, other.GameServer);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameInstanceId != other.GameInstanceId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.MatchmakerGuid != other.MatchmakerGuid;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.GameServerGuid != other.GameServerGuid;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x00182664 File Offset: 0x00180864
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.matchmaker_ != null;
			if (flag)
			{
				num ^= this.Matchmaker.GetHashCode();
			}
			bool flag2 = this.gameServer_ != null;
			if (flag2)
			{
				num ^= this.GameServer.GetHashCode();
			}
			bool hasGameInstanceId = this.HasGameInstanceId;
			if (hasGameInstanceId)
			{
				num ^= this.GameInstanceId.GetHashCode();
			}
			bool hasMatchmakerGuid = this.HasMatchmakerGuid;
			if (hasMatchmakerGuid)
			{
				num ^= this.MatchmakerGuid.GetHashCode();
			}
			bool hasGameServerGuid = this.HasGameServerGuid;
			if (hasGameServerGuid)
			{
				num ^= this.GameServerGuid.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x00182728 File Offset: 0x00180928
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x00182740 File Offset: 0x00180940
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x0018274C File Offset: 0x0018094C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.matchmaker_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Matchmaker);
			}
			bool flag2 = this.gameServer_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameServer);
			}
			bool hasGameInstanceId = this.HasGameInstanceId;
			if (hasGameInstanceId)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.GameInstanceId);
			}
			bool hasMatchmakerGuid = this.HasMatchmakerGuid;
			if (hasMatchmakerGuid)
			{
				output.WriteRawTag(33);
				output.WriteFixed64(this.MatchmakerGuid);
			}
			bool hasGameServerGuid = this.HasGameServerGuid;
			if (hasGameServerGuid)
			{
				output.WriteRawTag(41);
				output.WriteFixed64(this.GameServerGuid);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x0018282C File Offset: 0x00180A2C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.matchmaker_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Matchmaker);
			}
			bool flag2 = this.gameServer_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameServer);
			}
			bool hasGameInstanceId = this.HasGameInstanceId;
			if (hasGameInstanceId)
			{
				num += 5;
			}
			bool hasMatchmakerGuid = this.HasMatchmakerGuid;
			if (hasMatchmakerGuid)
			{
				num += 9;
			}
			bool hasGameServerGuid = this.HasGameServerGuid;
			if (hasGameServerGuid)
			{
				num += 9;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x001828D8 File Offset: 0x00180AD8
		[DebuggerNonUserCode]
		public void MergeFrom(GameHandle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.matchmaker_ != null;
				if (flag2)
				{
					bool flag3 = this.matchmaker_ == null;
					if (flag3)
					{
						this.Matchmaker = new MatchmakerHandle();
					}
					this.Matchmaker.MergeFrom(other.Matchmaker);
				}
				bool flag4 = other.gameServer_ != null;
				if (flag4)
				{
					bool flag5 = this.gameServer_ == null;
					if (flag5)
					{
						this.GameServer = new HostProxyPair();
					}
					this.GameServer.MergeFrom(other.GameServer);
				}
				bool hasGameInstanceId = other.HasGameInstanceId;
				if (hasGameInstanceId)
				{
					this.GameInstanceId = other.GameInstanceId;
				}
				bool hasMatchmakerGuid = other.HasMatchmakerGuid;
				if (hasMatchmakerGuid)
				{
					this.MatchmakerGuid = other.MatchmakerGuid;
				}
				bool hasGameServerGuid = other.HasGameServerGuid;
				if (hasGameServerGuid)
				{
					this.GameServerGuid = other.GameServerGuid;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x001829D6 File Offset: 0x00180BD6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x001829E4 File Offset: 0x00180BE4
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
							goto IL_003C;
						}
						bool flag = this.gameServer_ == null;
						if (flag)
						{
							this.GameServer = new HostProxyPair();
						}
						input.ReadMessage(this.GameServer);
					}
					else
					{
						bool flag2 = this.matchmaker_ == null;
						if (flag2)
						{
							this.Matchmaker = new MatchmakerHandle();
						}
						input.ReadMessage(this.Matchmaker);
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 33U)
					{
						if (num3 != 41U)
						{
							goto IL_003C;
						}
						this.GameServerGuid = input.ReadFixed64();
					}
					else
					{
						this.MatchmakerGuid = input.ReadFixed64();
					}
				}
				else
				{
					this.GameInstanceId = input.ReadFixed32();
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D84 RID: 11652
		private static readonly MessageParser<GameHandle> _parser = new MessageParser<GameHandle>(() => new GameHandle());

		// Token: 0x04002D85 RID: 11653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D86 RID: 11654
		private int _hasBits0;

		// Token: 0x04002D87 RID: 11655
		public const int MatchmakerFieldNumber = 1;

		// Token: 0x04002D88 RID: 11656
		private MatchmakerHandle matchmaker_;

		// Token: 0x04002D89 RID: 11657
		public const int GameServerFieldNumber = 2;

		// Token: 0x04002D8A RID: 11658
		private HostProxyPair gameServer_;

		// Token: 0x04002D8B RID: 11659
		public const int GameInstanceIdFieldNumber = 3;

		// Token: 0x04002D8C RID: 11660
		private static readonly uint GameInstanceIdDefaultValue = 0U;

		// Token: 0x04002D8D RID: 11661
		private uint gameInstanceId_;

		// Token: 0x04002D8E RID: 11662
		public const int MatchmakerGuidFieldNumber = 4;

		// Token: 0x04002D8F RID: 11663
		private static readonly ulong MatchmakerGuidDefaultValue = 0UL;

		// Token: 0x04002D90 RID: 11664
		private ulong matchmakerGuid_;

		// Token: 0x04002D91 RID: 11665
		public const int GameServerGuidFieldNumber = 5;

		// Token: 0x04002D92 RID: 11666
		private static readonly ulong GameServerGuidDefaultValue = 0UL;

		// Token: 0x04002D93 RID: 11667
		private ulong gameServerGuid_;
	}
}
