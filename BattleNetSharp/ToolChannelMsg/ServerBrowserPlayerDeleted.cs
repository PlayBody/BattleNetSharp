using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000AC RID: 172
	public sealed class ServerBrowserPlayerDeleted : IMessage<ServerBrowserPlayerDeleted>, IMessage, IEquatable<ServerBrowserPlayerDeleted>, IDeepCloneable<ServerBrowserPlayerDeleted>, IBufferMessage
	{
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0003B0A8 File Offset: 0x000392A8
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserPlayerDeleted> Parser
		{
			get
			{
				return ServerBrowserPlayerDeleted._parser;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0003B0C0 File Offset: 0x000392C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[149];
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0003B0E8 File Offset: 0x000392E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserPlayerDeleted.Descriptor;
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0003B0FF File Offset: 0x000392FF
		[DebuggerNonUserCode]
		public ServerBrowserPlayerDeleted()
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0003B109 File Offset: 0x00039309
		[DebuggerNonUserCode]
		public ServerBrowserPlayerDeleted(ServerBrowserPlayerDeleted other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameId_ = other.gameId_;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0003B148 File Offset: 0x00039348
		[DebuggerNonUserCode]
		public ServerBrowserPlayerDeleted Clone()
		{
			return new ServerBrowserPlayerDeleted(this);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0003B160 File Offset: 0x00039360
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x0003B191 File Offset: 0x00039391
		[DebuggerNonUserCode]
		public uint GameId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameIdDefaultValue;
				if (flag)
				{
					gameIdDefaultValue = this.gameId_;
				}
				else
				{
					gameIdDefaultValue = ServerBrowserPlayerDeleted.GameIdDefaultValue;
				}
				return gameIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameId_ = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x0003B1AC File Offset: 0x000393AC
		[DebuggerNonUserCode]
		public bool HasGameId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0003B1C9 File Offset: 0x000393C9
		[DebuggerNonUserCode]
		public void ClearGameId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0003B1DC File Offset: 0x000393DC
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x0003B20D File Offset: 0x0003940D
		[DebuggerNonUserCode]
		public ulong GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = ServerBrowserPlayerDeleted.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0003B228 File Offset: 0x00039428
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0003B245 File Offset: 0x00039445
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0003B258 File Offset: 0x00039458
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserPlayerDeleted);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0003B278 File Offset: 0x00039478
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserPlayerDeleted other)
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
					bool flag4 = this.GameId != other.GameId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameAccountId != other.GameAccountId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0003B2EC File Offset: 0x000394EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num ^= this.GameId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0003B35C File Offset: 0x0003955C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0003B374 File Offset: 0x00039574
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0003B380 File Offset: 0x00039580
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0003B3F0 File Offset: 0x000395F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0003B45C File Offset: 0x0003965C
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserPlayerDeleted other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameId = other.HasGameId;
				if (hasGameId)
				{
					this.GameId = other.GameId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0003B4BE File Offset: 0x000396BE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0003B4CC File Offset: 0x000396CC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GameAccountId = input.ReadUInt64();
					}
				}
				else
				{
					this.GameId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000663 RID: 1635
		private static readonly MessageParser<ServerBrowserPlayerDeleted> _parser = new MessageParser<ServerBrowserPlayerDeleted>(() => new ServerBrowserPlayerDeleted());

		// Token: 0x04000664 RID: 1636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000665 RID: 1637
		private int _hasBits0;

		// Token: 0x04000666 RID: 1638
		public const int GameIdFieldNumber = 1;

		// Token: 0x04000667 RID: 1639
		private static readonly uint GameIdDefaultValue = 0U;

		// Token: 0x04000668 RID: 1640
		private uint gameId_;

		// Token: 0x04000669 RID: 1641
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x0400066A RID: 1642
		private static readonly ulong GameAccountIdDefaultValue = 0UL;

		// Token: 0x0400066B RID: 1643
		private ulong gameAccountId_;
	}
}
