using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000AB RID: 171
	public sealed class ServerBrowserGameShutdown : IMessage<ServerBrowserGameShutdown>, IMessage, IEquatable<ServerBrowserGameShutdown>, IDeepCloneable<ServerBrowserGameShutdown>, IBufferMessage
	{
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0003AD30 File Offset: 0x00038F30
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserGameShutdown> Parser
		{
			get
			{
				return ServerBrowserGameShutdown._parser;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0003AD48 File Offset: 0x00038F48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[148];
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0003AD70 File Offset: 0x00038F70
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserGameShutdown.Descriptor;
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0003AD87 File Offset: 0x00038F87
		[DebuggerNonUserCode]
		public ServerBrowserGameShutdown()
		{
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0003AD91 File Offset: 0x00038F91
		[DebuggerNonUserCode]
		public ServerBrowserGameShutdown(ServerBrowserGameShutdown other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameId_ = other.gameId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0003ADC4 File Offset: 0x00038FC4
		[DebuggerNonUserCode]
		public ServerBrowserGameShutdown Clone()
		{
			return new ServerBrowserGameShutdown(this);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0003ADDC File Offset: 0x00038FDC
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0003AE0D File Offset: 0x0003900D
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
					gameIdDefaultValue = ServerBrowserGameShutdown.GameIdDefaultValue;
				}
				return gameIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameId_ = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0003AE28 File Offset: 0x00039028
		[DebuggerNonUserCode]
		public bool HasGameId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0003AE45 File Offset: 0x00039045
		[DebuggerNonUserCode]
		public void ClearGameId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0003AE58 File Offset: 0x00039058
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserGameShutdown);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0003AE78 File Offset: 0x00039078
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserGameShutdown other)
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

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0003AED0 File Offset: 0x000390D0
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

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0003AF20 File Offset: 0x00039120
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0003AF38 File Offset: 0x00039138
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0003AF44 File Offset: 0x00039144
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

		// Token: 0x06000FEC RID: 4076 RVA: 0x0003AF90 File Offset: 0x00039190
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

		// Token: 0x06000FED RID: 4077 RVA: 0x0003AFE0 File Offset: 0x000391E0
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserGameShutdown other)
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

		// Token: 0x06000FEE RID: 4078 RVA: 0x0003B029 File Offset: 0x00039229
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0003B034 File Offset: 0x00039234
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

		// Token: 0x0400065D RID: 1629
		private static readonly MessageParser<ServerBrowserGameShutdown> _parser = new MessageParser<ServerBrowserGameShutdown>(() => new ServerBrowserGameShutdown());

		// Token: 0x0400065E RID: 1630
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400065F RID: 1631
		private int _hasBits0;

		// Token: 0x04000660 RID: 1632
		public const int GameIdFieldNumber = 1;

		// Token: 0x04000661 RID: 1633
		private static readonly uint GameIdDefaultValue = 0U;

		// Token: 0x04000662 RID: 1634
		private uint gameId_;
	}
}
