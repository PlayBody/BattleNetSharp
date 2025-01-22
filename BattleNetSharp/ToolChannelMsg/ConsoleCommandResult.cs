using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000018 RID: 24
	public sealed class ConsoleCommandResult : IMessage<ConsoleCommandResult>, IMessage, IEquatable<ConsoleCommandResult>, IDeepCloneable<ConsoleCommandResult>, IBufferMessage
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000AB84 File Offset: 0x00008D84
		[DebuggerNonUserCode]
		public static MessageParser<ConsoleCommandResult> Parser
		{
			get
			{
				return ConsoleCommandResult._parser;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000AB9C File Offset: 0x00008D9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsoleCommandResult.Descriptor;
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000ABD7 File Offset: 0x00008DD7
		[DebuggerNonUserCode]
		public ConsoleCommandResult()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		[DebuggerNonUserCode]
		public ConsoleCommandResult(ConsoleCommandResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.command_ = other.command_;
			this.output_ = other.output_;
			this.commandState_ = other.commandState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000AC3C File Offset: 0x00008E3C
		[DebuggerNonUserCode]
		public ConsoleCommandResult Clone()
		{
			return new ConsoleCommandResult(this);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000AC54 File Offset: 0x00008E54
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000AC75 File Offset: 0x00008E75
		[DebuggerNonUserCode]
		public string Command
		{
			get
			{
				return this.command_ ?? ConsoleCommandResult.CommandDefaultValue;
			}
			set
			{
				this.command_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000AC8C File Offset: 0x00008E8C
		[DebuggerNonUserCode]
		public bool HasCommand
		{
			get
			{
				return this.command_ != null;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000ACA7 File Offset: 0x00008EA7
		[DebuggerNonUserCode]
		public void ClearCommand()
		{
			this.command_ = null;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000ACB4 File Offset: 0x00008EB4
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000ACD5 File Offset: 0x00008ED5
		[DebuggerNonUserCode]
		public string Output
		{
			get
			{
				return this.output_ ?? ConsoleCommandResult.OutputDefaultValue;
			}
			set
			{
				this.output_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[DebuggerNonUserCode]
		public bool HasOutput
		{
			get
			{
				return this.output_ != null;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000AD07 File Offset: 0x00008F07
		[DebuggerNonUserCode]
		public void ClearOutput()
		{
			this.output_ = null;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000AD14 File Offset: 0x00008F14
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000AD45 File Offset: 0x00008F45
		[DebuggerNonUserCode]
		public int CommandState
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int commandStateDefaultValue;
				if (flag)
				{
					commandStateDefaultValue = this.commandState_;
				}
				else
				{
					commandStateDefaultValue = ConsoleCommandResult.CommandStateDefaultValue;
				}
				return commandStateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.commandState_ = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000AD60 File Offset: 0x00008F60
		[DebuggerNonUserCode]
		public bool HasCommandState
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000AD7D File Offset: 0x00008F7D
		[DebuggerNonUserCode]
		public void ClearCommandState()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000AD90 File Offset: 0x00008F90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsoleCommandResult);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000ADB0 File Offset: 0x00008FB0
		[DebuggerNonUserCode]
		public bool Equals(ConsoleCommandResult other)
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
					bool flag4 = this.Command != other.Command;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Output != other.Output;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CommandState != other.CommandState;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000AE3C File Offset: 0x0000903C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCommand = this.HasCommand;
			if (hasCommand)
			{
				num ^= this.Command.GetHashCode();
			}
			bool hasOutput = this.HasOutput;
			if (hasOutput)
			{
				num ^= this.Output.GetHashCode();
			}
			bool hasCommandState = this.HasCommandState;
			if (hasCommandState)
			{
				num ^= this.CommandState.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000AED8 File Offset: 0x000090D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000AEE4 File Offset: 0x000090E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCommand = this.HasCommand;
			if (hasCommand)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Command);
			}
			bool hasOutput = this.HasOutput;
			if (hasOutput)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Output);
			}
			bool hasCommandState = this.HasCommandState;
			if (hasCommandState)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CommandState);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000AF74 File Offset: 0x00009174
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCommand = this.HasCommand;
			if (hasCommand)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Command);
			}
			bool hasOutput = this.HasOutput;
			if (hasOutput)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Output);
			}
			bool hasCommandState = this.HasCommandState;
			if (hasCommandState)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CommandState);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000B000 File Offset: 0x00009200
		[DebuggerNonUserCode]
		public void MergeFrom(ConsoleCommandResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCommand = other.HasCommand;
				if (hasCommand)
				{
					this.Command = other.Command;
				}
				bool hasOutput = other.HasOutput;
				if (hasOutput)
				{
					this.Output = other.Output;
				}
				bool hasCommandState = other.HasCommandState;
				if (hasCommandState)
				{
					this.CommandState = other.CommandState;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000B07B File Offset: 0x0000927B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000B088 File Offset: 0x00009288
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
							this.CommandState = input.ReadInt32();
						}
					}
					else
					{
						this.Output = input.ReadString();
					}
				}
				else
				{
					this.Command = input.ReadString();
				}
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly MessageParser<ConsoleCommandResult> _parser = new MessageParser<ConsoleCommandResult>(() => new ConsoleCommandResult());

		// Token: 0x04000087 RID: 135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000088 RID: 136
		private int _hasBits0;

		// Token: 0x04000089 RID: 137
		public const int CommandFieldNumber = 1;

		// Token: 0x0400008A RID: 138
		private static readonly string CommandDefaultValue = "";

		// Token: 0x0400008B RID: 139
		private string command_;

		// Token: 0x0400008C RID: 140
		public const int OutputFieldNumber = 2;

		// Token: 0x0400008D RID: 141
		private static readonly string OutputDefaultValue = "";

		// Token: 0x0400008E RID: 142
		private string output_;

		// Token: 0x0400008F RID: 143
		public const int CommandStateFieldNumber = 3;

		// Token: 0x04000090 RID: 144
		private static readonly int CommandStateDefaultValue = 0;

		// Token: 0x04000091 RID: 145
		private int commandState_;
	}
}
