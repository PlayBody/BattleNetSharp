using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200006C RID: 108
	public sealed class ConsoleCommandRequest : IMessage<ConsoleCommandRequest>, IMessage, IEquatable<ConsoleCommandRequest>, IDeepCloneable<ConsoleCommandRequest>, IBufferMessage
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002575C File Offset: 0x0002395C
		[DebuggerNonUserCode]
		public static MessageParser<ConsoleCommandRequest> Parser
		{
			get
			{
				return ConsoleCommandRequest._parser;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00025774 File Offset: 0x00023974
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[85];
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00025798 File Offset: 0x00023998
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsoleCommandRequest.Descriptor;
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000257AF File Offset: 0x000239AF
		[DebuggerNonUserCode]
		public ConsoleCommandRequest()
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000257B9 File Offset: 0x000239B9
		[DebuggerNonUserCode]
		public ConsoleCommandRequest(ConsoleCommandRequest other)
			: this()
		{
			this.consoleCommand_ = other.consoleCommand_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000257E0 File Offset: 0x000239E0
		[DebuggerNonUserCode]
		public ConsoleCommandRequest Clone()
		{
			return new ConsoleCommandRequest(this);
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x000257F8 File Offset: 0x000239F8
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00025819 File Offset: 0x00023A19
		[DebuggerNonUserCode]
		public string ConsoleCommand
		{
			get
			{
				return this.consoleCommand_ ?? ConsoleCommandRequest.ConsoleCommandDefaultValue;
			}
			set
			{
				this.consoleCommand_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00025830 File Offset: 0x00023A30
		[DebuggerNonUserCode]
		public bool HasConsoleCommand
		{
			get
			{
				return this.consoleCommand_ != null;
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0002584B File Offset: 0x00023A4B
		[DebuggerNonUserCode]
		public void ClearConsoleCommand()
		{
			this.consoleCommand_ = null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00025858 File Offset: 0x00023A58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsoleCommandRequest);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00025878 File Offset: 0x00023A78
		[DebuggerNonUserCode]
		public bool Equals(ConsoleCommandRequest other)
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
					bool flag4 = this.ConsoleCommand != other.ConsoleCommand;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000258D0 File Offset: 0x00023AD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasConsoleCommand = this.HasConsoleCommand;
			if (hasConsoleCommand)
			{
				num ^= this.ConsoleCommand.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0002591C File Offset: 0x00023B1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00025934 File Offset: 0x00023B34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00025940 File Offset: 0x00023B40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasConsoleCommand = this.HasConsoleCommand;
			if (hasConsoleCommand)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ConsoleCommand);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0002598C File Offset: 0x00023B8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasConsoleCommand = this.HasConsoleCommand;
			if (hasConsoleCommand)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ConsoleCommand);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000259DC File Offset: 0x00023BDC
		[DebuggerNonUserCode]
		public void MergeFrom(ConsoleCommandRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasConsoleCommand = other.HasConsoleCommand;
				if (hasConsoleCommand)
				{
					this.ConsoleCommand = other.ConsoleCommand;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00025A25 File Offset: 0x00023C25
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00025A30 File Offset: 0x00023C30
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
					this.ConsoleCommand = input.ReadString();
				}
			}
		}

		// Token: 0x040003BF RID: 959
		private static readonly MessageParser<ConsoleCommandRequest> _parser = new MessageParser<ConsoleCommandRequest>(() => new ConsoleCommandRequest());

		// Token: 0x040003C0 RID: 960
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003C1 RID: 961
		public const int ConsoleCommandFieldNumber = 1;

		// Token: 0x040003C2 RID: 962
		private static readonly string ConsoleCommandDefaultValue = "";

		// Token: 0x040003C3 RID: 963
		private string consoleCommand_;
	}
}
