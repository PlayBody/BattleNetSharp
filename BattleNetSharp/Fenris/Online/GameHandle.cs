using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000156 RID: 342
	public sealed class GameHandle : IMessage<GameHandle>, IMessage, IEquatable<GameHandle>, IDeepCloneable<GameHandle>, IBufferMessage
	{
		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x00089750 File Offset: 0x00087950
		[DebuggerNonUserCode]
		public static MessageParser<GameHandle> Parser
		{
			get
			{
				return GameHandle._parser;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00089768 File Offset: 0x00087968
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineCommonReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0008978C File Offset: 0x0008798C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameHandle.Descriptor;
			}
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x000897A3 File Offset: 0x000879A3
		[DebuggerNonUserCode]
		public GameHandle()
		{
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x000897B0 File Offset: 0x000879B0
		[DebuggerNonUserCode]
		public GameHandle(GameHandle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameInstanceId_ = other.gameInstanceId_;
			this.matchmakerId_ = other.matchmakerId_;
			this.gameServerGuid_ = other.gameServerGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00089808 File Offset: 0x00087A08
		[DebuggerNonUserCode]
		public GameHandle Clone()
		{
			return new GameHandle(this);
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x00089820 File Offset: 0x00087A20
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x00089851 File Offset: 0x00087A51
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

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x0008986C File Offset: 0x00087A6C
		[DebuggerNonUserCode]
		public bool HasGameInstanceId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00089889 File Offset: 0x00087A89
		[DebuggerNonUserCode]
		public void ClearGameInstanceId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x0008989C File Offset: 0x00087A9C
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x000898CD File Offset: 0x00087ACD
		[DebuggerNonUserCode]
		public ulong MatchmakerId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong matchmakerIdDefaultValue;
				if (flag)
				{
					matchmakerIdDefaultValue = this.matchmakerId_;
				}
				else
				{
					matchmakerIdDefaultValue = GameHandle.MatchmakerIdDefaultValue;
				}
				return matchmakerIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.matchmakerId_ = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x000898E8 File Offset: 0x00087AE8
		[DebuggerNonUserCode]
		public bool HasMatchmakerId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00089905 File Offset: 0x00087B05
		[DebuggerNonUserCode]
		public void ClearMatchmakerId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x00089918 File Offset: 0x00087B18
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x00089949 File Offset: 0x00087B49
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

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x00089964 File Offset: 0x00087B64
		[DebuggerNonUserCode]
		public bool HasGameServerGuid
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00089981 File Offset: 0x00087B81
		[DebuggerNonUserCode]
		public void ClearGameServerGuid()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00089994 File Offset: 0x00087B94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameHandle);
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000899B4 File Offset: 0x00087BB4
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
					bool flag4 = this.GameInstanceId != other.GameInstanceId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MatchmakerId != other.MatchmakerId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameServerGuid != other.GameServerGuid;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00089A40 File Offset: 0x00087C40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameInstanceId = this.HasGameInstanceId;
			if (hasGameInstanceId)
			{
				num ^= this.GameInstanceId.GetHashCode();
			}
			bool hasMatchmakerId = this.HasMatchmakerId;
			if (hasMatchmakerId)
			{
				num ^= this.MatchmakerId.GetHashCode();
			}
			bool hasGameServerGuid = this.HasGameServerGuid;
			if (hasGameServerGuid)
			{
				num ^= this.GameServerGuid.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00089ACC File Offset: 0x00087CCC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00089AE4 File Offset: 0x00087CE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00089AF0 File Offset: 0x00087CF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameInstanceId = this.HasGameInstanceId;
			if (hasGameInstanceId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameInstanceId);
			}
			bool hasMatchmakerId = this.HasMatchmakerId;
			if (hasMatchmakerId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.MatchmakerId);
			}
			bool hasGameServerGuid = this.HasGameServerGuid;
			if (hasGameServerGuid)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.GameServerGuid);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00089B80 File Offset: 0x00087D80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameInstanceId = this.HasGameInstanceId;
			if (hasGameInstanceId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameInstanceId);
			}
			bool hasMatchmakerId = this.HasMatchmakerId;
			if (hasMatchmakerId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.MatchmakerId);
			}
			bool hasGameServerGuid = this.HasGameServerGuid;
			if (hasGameServerGuid)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GameServerGuid);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00089C0C File Offset: 0x00087E0C
		[DebuggerNonUserCode]
		public void MergeFrom(GameHandle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameInstanceId = other.HasGameInstanceId;
				if (hasGameInstanceId)
				{
					this.GameInstanceId = other.GameInstanceId;
				}
				bool hasMatchmakerId = other.HasMatchmakerId;
				if (hasMatchmakerId)
				{
					this.MatchmakerId = other.MatchmakerId;
				}
				bool hasGameServerGuid = other.HasGameServerGuid;
				if (hasGameServerGuid)
				{
					this.GameServerGuid = other.GameServerGuid;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00089C87 File Offset: 0x00087E87
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00089C94 File Offset: 0x00087E94
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GameServerGuid = input.ReadUInt64();
						}
					}
					else
					{
						this.MatchmakerId = input.ReadUInt64();
					}
				}
				else
				{
					this.GameInstanceId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F8E RID: 3982
		private static readonly MessageParser<GameHandle> _parser = new MessageParser<GameHandle>(() => new GameHandle());

		// Token: 0x04000F8F RID: 3983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F90 RID: 3984
		private int _hasBits0;

		// Token: 0x04000F91 RID: 3985
		public const int GameInstanceIdFieldNumber = 1;

		// Token: 0x04000F92 RID: 3986
		private static readonly uint GameInstanceIdDefaultValue = 0U;

		// Token: 0x04000F93 RID: 3987
		private uint gameInstanceId_;

		// Token: 0x04000F94 RID: 3988
		public const int MatchmakerIdFieldNumber = 2;

		// Token: 0x04000F95 RID: 3989
		private static readonly ulong MatchmakerIdDefaultValue = 0UL;

		// Token: 0x04000F96 RID: 3990
		private ulong matchmakerId_;

		// Token: 0x04000F97 RID: 3991
		public const int GameServerGuidFieldNumber = 3;

		// Token: 0x04000F98 RID: 3992
		private static readonly ulong GameServerGuidDefaultValue = 0UL;

		// Token: 0x04000F99 RID: 3993
		private ulong gameServerGuid_;
	}
}
