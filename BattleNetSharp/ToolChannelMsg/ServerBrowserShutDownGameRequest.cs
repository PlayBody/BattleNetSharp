using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A6 RID: 166
	public sealed class ServerBrowserShutDownGameRequest : IMessage<ServerBrowserShutDownGameRequest>, IMessage, IEquatable<ServerBrowserShutDownGameRequest>, IDeepCloneable<ServerBrowserShutDownGameRequest>, IBufferMessage
	{
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00038040 File Offset: 0x00036240
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserShutDownGameRequest> Parser
		{
			get
			{
				return ServerBrowserShutDownGameRequest._parser;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00038058 File Offset: 0x00036258
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[143];
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00038080 File Offset: 0x00036280
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserShutDownGameRequest.Descriptor;
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00038097 File Offset: 0x00036297
		[DebuggerNonUserCode]
		public ServerBrowserShutDownGameRequest()
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000380A1 File Offset: 0x000362A1
		[DebuggerNonUserCode]
		public ServerBrowserShutDownGameRequest(ServerBrowserShutDownGameRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameId_ = other.gameId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000380D4 File Offset: 0x000362D4
		[DebuggerNonUserCode]
		public ServerBrowserShutDownGameRequest Clone()
		{
			return new ServerBrowserShutDownGameRequest(this);
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000380EC File Offset: 0x000362EC
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x0003811D File Offset: 0x0003631D
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
					gameIdDefaultValue = ServerBrowserShutDownGameRequest.GameIdDefaultValue;
				}
				return gameIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameId_ = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00038138 File Offset: 0x00036338
		[DebuggerNonUserCode]
		public bool HasGameId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00038155 File Offset: 0x00036355
		[DebuggerNonUserCode]
		public void ClearGameId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00038168 File Offset: 0x00036368
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserShutDownGameRequest);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00038188 File Offset: 0x00036388
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserShutDownGameRequest other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000381E0 File Offset: 0x000363E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num ^= this.GameId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00038230 File Offset: 0x00036430
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00038248 File Offset: 0x00036448
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00038254 File Offset: 0x00036454
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x000382A0 File Offset: 0x000364A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameId = this.HasGameId;
			if (hasGameId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000382F0 File Offset: 0x000364F0
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserShutDownGameRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameId = other.HasGameId;
				if (hasGameId)
				{
					this.GameId = other.GameId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00038339 File Offset: 0x00036539
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00038344 File Offset: 0x00036544
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GameId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040005FC RID: 1532
		private static readonly MessageParser<ServerBrowserShutDownGameRequest> _parser = new MessageParser<ServerBrowserShutDownGameRequest>(() => new ServerBrowserShutDownGameRequest());

		// Token: 0x040005FD RID: 1533
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005FE RID: 1534
		private int _hasBits0;

		// Token: 0x040005FF RID: 1535
		public const int GameIdFieldNumber = 1;

		// Token: 0x04000600 RID: 1536
		private static readonly uint GameIdDefaultValue = 0U;

		// Token: 0x04000601 RID: 1537
		private uint gameId_;
	}
}
