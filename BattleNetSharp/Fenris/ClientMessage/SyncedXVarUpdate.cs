using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000230 RID: 560
	public sealed class SyncedXVarUpdate : IMessage<SyncedXVarUpdate>, IMessage, IEquatable<SyncedXVarUpdate>, IDeepCloneable<SyncedXVarUpdate>, IBufferMessage
	{
		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x000F0E38 File Offset: 0x000EF038
		[DebuggerNonUserCode]
		public static MessageParser<SyncedXVarUpdate> Parser
		{
			get
			{
				return SyncedXVarUpdate._parser;
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x000F0E50 File Offset: 0x000EF050
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[32];
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x000F0E74 File Offset: 0x000EF074
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncedXVarUpdate.Descriptor;
			}
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x000F0E8B File Offset: 0x000EF08B
		[DebuggerNonUserCode]
		public SyncedXVarUpdate()
		{
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x000F0E95 File Offset: 0x000EF095
		[DebuggerNonUserCode]
		public SyncedXVarUpdate(SyncedXVarUpdate other)
			: this()
		{
			this.cmdLine_ = other.cmdLine_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x000F0EBC File Offset: 0x000EF0BC
		[DebuggerNonUserCode]
		public SyncedXVarUpdate Clone()
		{
			return new SyncedXVarUpdate(this);
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x000F0ED4 File Offset: 0x000EF0D4
		// (set) Token: 0x06003CCB RID: 15563 RVA: 0x000F0EF5 File Offset: 0x000EF0F5
		[DebuggerNonUserCode]
		public string CmdLine
		{
			get
			{
				return this.cmdLine_ ?? SyncedXVarUpdate.CmdLineDefaultValue;
			}
			set
			{
				this.cmdLine_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06003CCC RID: 15564 RVA: 0x000F0F0C File Offset: 0x000EF10C
		[DebuggerNonUserCode]
		public bool HasCmdLine
		{
			get
			{
				return this.cmdLine_ != null;
			}
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x000F0F27 File Offset: 0x000EF127
		[DebuggerNonUserCode]
		public void ClearCmdLine()
		{
			this.cmdLine_ = null;
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x000F0F34 File Offset: 0x000EF134
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncedXVarUpdate);
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x000F0F54 File Offset: 0x000EF154
		[DebuggerNonUserCode]
		public bool Equals(SyncedXVarUpdate other)
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
					bool flag4 = this.CmdLine != other.CmdLine;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x000F0FAC File Offset: 0x000EF1AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCmdLine = this.HasCmdLine;
			if (hasCmdLine)
			{
				num ^= this.CmdLine.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x000F0FF8 File Offset: 0x000EF1F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x000F1010 File Offset: 0x000EF210
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x000F101C File Offset: 0x000EF21C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCmdLine = this.HasCmdLine;
			if (hasCmdLine)
			{
				output.WriteRawTag(10);
				output.WriteString(this.CmdLine);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x000F1068 File Offset: 0x000EF268
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCmdLine = this.HasCmdLine;
			if (hasCmdLine)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CmdLine);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x000F10B8 File Offset: 0x000EF2B8
		[DebuggerNonUserCode]
		public void MergeFrom(SyncedXVarUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCmdLine = other.HasCmdLine;
				if (hasCmdLine)
				{
					this.CmdLine = other.CmdLine;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x000F1101 File Offset: 0x000EF301
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x000F110C File Offset: 0x000EF30C
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
					this.CmdLine = input.ReadString();
				}
			}
		}

		// Token: 0x04001C0E RID: 7182
		private static readonly MessageParser<SyncedXVarUpdate> _parser = new MessageParser<SyncedXVarUpdate>(() => new SyncedXVarUpdate());

		// Token: 0x04001C0F RID: 7183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C10 RID: 7184
		public const int CmdLineFieldNumber = 1;

		// Token: 0x04001C11 RID: 7185
		private static readonly string CmdLineDefaultValue = "";

		// Token: 0x04001C12 RID: 7186
		private string cmdLine_;
	}
}
