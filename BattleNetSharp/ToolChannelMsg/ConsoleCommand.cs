using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000017 RID: 23
	public sealed class ConsoleCommand : IMessage<ConsoleCommand>, IMessage, IEquatable<ConsoleCommand>, IDeepCloneable<ConsoleCommand>, IBufferMessage
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000A838 File Offset: 0x00008A38
		[DebuggerNonUserCode]
		public static MessageParser<ConsoleCommand> Parser
		{
			get
			{
				return ConsoleCommand._parser;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000A850 File Offset: 0x00008A50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000A874 File Offset: 0x00008A74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsoleCommand.Descriptor;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000A88B File Offset: 0x00008A8B
		[DebuggerNonUserCode]
		public ConsoleCommand()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000A895 File Offset: 0x00008A95
		[DebuggerNonUserCode]
		public ConsoleCommand(ConsoleCommand other)
			: this()
		{
			this.command_ = other.command_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A8BC File Offset: 0x00008ABC
		[DebuggerNonUserCode]
		public ConsoleCommand Clone()
		{
			return new ConsoleCommand(this);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000A8F5 File Offset: 0x00008AF5
		[DebuggerNonUserCode]
		public string Command
		{
			get
			{
				return this.command_ ?? ConsoleCommand.CommandDefaultValue;
			}
			set
			{
				this.command_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000A90C File Offset: 0x00008B0C
		[DebuggerNonUserCode]
		public bool HasCommand
		{
			get
			{
				return this.command_ != null;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000A927 File Offset: 0x00008B27
		[DebuggerNonUserCode]
		public void ClearCommand()
		{
			this.command_ = null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000A934 File Offset: 0x00008B34
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsoleCommand);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000A954 File Offset: 0x00008B54
		[DebuggerNonUserCode]
		public bool Equals(ConsoleCommand other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000A9AC File Offset: 0x00008BAC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCommand = this.HasCommand;
			if (hasCommand)
			{
				num ^= this.Command.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000AA10 File Offset: 0x00008C10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000AA1C File Offset: 0x00008C1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCommand = this.HasCommand;
			if (hasCommand)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Command);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000AA68 File Offset: 0x00008C68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCommand = this.HasCommand;
			if (hasCommand)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Command);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[DebuggerNonUserCode]
		public void MergeFrom(ConsoleCommand other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCommand = other.HasCommand;
				if (hasCommand)
				{
					this.Command = other.Command;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000AB01 File Offset: 0x00008D01
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000AB0C File Offset: 0x00008D0C
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
					this.Command = input.ReadString();
				}
			}
		}

		// Token: 0x04000081 RID: 129
		private static readonly MessageParser<ConsoleCommand> _parser = new MessageParser<ConsoleCommand>(() => new ConsoleCommand());

		// Token: 0x04000082 RID: 130
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000083 RID: 131
		public const int CommandFieldNumber = 1;

		// Token: 0x04000084 RID: 132
		private static readonly string CommandDefaultValue = "";

		// Token: 0x04000085 RID: 133
		private string command_;
	}
}
