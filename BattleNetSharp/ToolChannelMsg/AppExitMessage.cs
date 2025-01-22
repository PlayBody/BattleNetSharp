using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000EC RID: 236
	public sealed class AppExitMessage : IMessage<AppExitMessage>, IMessage, IEquatable<AppExitMessage>, IDeepCloneable<AppExitMessage>, IBufferMessage
	{
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00052FA4 File Offset: 0x000511A4
		[DebuggerNonUserCode]
		public static MessageParser<AppExitMessage> Parser
		{
			get
			{
				return AppExitMessage._parser;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00052FBC File Offset: 0x000511BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[213];
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00052FE4 File Offset: 0x000511E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppExitMessage.Descriptor;
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00052FFB File Offset: 0x000511FB
		[DebuggerNonUserCode]
		public AppExitMessage()
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00053005 File Offset: 0x00051205
		[DebuggerNonUserCode]
		public AppExitMessage(AppExitMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.exitCode_ = other.exitCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00053038 File Offset: 0x00051238
		[DebuggerNonUserCode]
		public AppExitMessage Clone()
		{
			return new AppExitMessage(this);
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00053050 File Offset: 0x00051250
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x00053081 File Offset: 0x00051281
		[DebuggerNonUserCode]
		public int ExitCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int exitCodeDefaultValue;
				if (flag)
				{
					exitCodeDefaultValue = this.exitCode_;
				}
				else
				{
					exitCodeDefaultValue = AppExitMessage.ExitCodeDefaultValue;
				}
				return exitCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.exitCode_ = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x0005309C File Offset: 0x0005129C
		[DebuggerNonUserCode]
		public bool HasExitCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x000530B9 File Offset: 0x000512B9
		[DebuggerNonUserCode]
		public void ClearExitCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x000530CC File Offset: 0x000512CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppExitMessage);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x000530EC File Offset: 0x000512EC
		[DebuggerNonUserCode]
		public bool Equals(AppExitMessage other)
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
					bool flag4 = this.ExitCode != other.ExitCode;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00053144 File Offset: 0x00051344
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasExitCode = this.HasExitCode;
			if (hasExitCode)
			{
				num ^= this.ExitCode.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00053194 File Offset: 0x00051394
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x000531AC File Offset: 0x000513AC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x000531B8 File Offset: 0x000513B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasExitCode = this.HasExitCode;
			if (hasExitCode)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ExitCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00053204 File Offset: 0x00051404
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasExitCode = this.HasExitCode;
			if (hasExitCode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExitCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00053254 File Offset: 0x00051454
		[DebuggerNonUserCode]
		public void MergeFrom(AppExitMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasExitCode = other.HasExitCode;
				if (hasExitCode)
				{
					this.ExitCode = other.ExitCode;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0005329D File Offset: 0x0005149D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000532A8 File Offset: 0x000514A8
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
					this.ExitCode = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400094F RID: 2383
		private static readonly MessageParser<AppExitMessage> _parser = new MessageParser<AppExitMessage>(() => new AppExitMessage());

		// Token: 0x04000950 RID: 2384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000951 RID: 2385
		private int _hasBits0;

		// Token: 0x04000952 RID: 2386
		public const int ExitCodeFieldNumber = 1;

		// Token: 0x04000953 RID: 2387
		private static readonly int ExitCodeDefaultValue = 0;

		// Token: 0x04000954 RID: 2388
		private int exitCode_;
	}
}
