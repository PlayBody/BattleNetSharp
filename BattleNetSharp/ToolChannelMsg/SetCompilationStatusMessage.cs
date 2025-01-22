using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000035 RID: 53
	public sealed class SetCompilationStatusMessage : IMessage<SetCompilationStatusMessage>, IMessage, IEquatable<SetCompilationStatusMessage>, IDeepCloneable<SetCompilationStatusMessage>, IBufferMessage
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000131B8 File Offset: 0x000113B8
		[DebuggerNonUserCode]
		public static MessageParser<SetCompilationStatusMessage> Parser
		{
			get
			{
				return SetCompilationStatusMessage._parser;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000131D0 File Offset: 0x000113D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[30];
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x000131F4 File Offset: 0x000113F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetCompilationStatusMessage.Descriptor;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001320B File Offset: 0x0001140B
		[DebuggerNonUserCode]
		public SetCompilationStatusMessage()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00013218 File Offset: 0x00011418
		[DebuggerNonUserCode]
		public SetCompilationStatusMessage(SetCompilationStatusMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.compilationMessage_ = other.compilationMessage_;
			this.completedRequestCount_ = other.completedRequestCount_;
			this.totalRequestCount_ = other.totalRequestCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00013270 File Offset: 0x00011470
		[DebuggerNonUserCode]
		public SetCompilationStatusMessage Clone()
		{
			return new SetCompilationStatusMessage(this);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00013288 File Offset: 0x00011488
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000132A9 File Offset: 0x000114A9
		[DebuggerNonUserCode]
		public string CompilationMessage
		{
			get
			{
				return this.compilationMessage_ ?? SetCompilationStatusMessage.CompilationMessageDefaultValue;
			}
			set
			{
				this.compilationMessage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000132C0 File Offset: 0x000114C0
		[DebuggerNonUserCode]
		public bool HasCompilationMessage
		{
			get
			{
				return this.compilationMessage_ != null;
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000132DB File Offset: 0x000114DB
		[DebuggerNonUserCode]
		public void ClearCompilationMessage()
		{
			this.compilationMessage_ = null;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000132E8 File Offset: 0x000114E8
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00013319 File Offset: 0x00011519
		[DebuggerNonUserCode]
		public int CompletedRequestCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int completedRequestCountDefaultValue;
				if (flag)
				{
					completedRequestCountDefaultValue = this.completedRequestCount_;
				}
				else
				{
					completedRequestCountDefaultValue = SetCompilationStatusMessage.CompletedRequestCountDefaultValue;
				}
				return completedRequestCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.completedRequestCount_ = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00013334 File Offset: 0x00011534
		[DebuggerNonUserCode]
		public bool HasCompletedRequestCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00013351 File Offset: 0x00011551
		[DebuggerNonUserCode]
		public void ClearCompletedRequestCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00013364 File Offset: 0x00011564
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00013395 File Offset: 0x00011595
		[DebuggerNonUserCode]
		public int TotalRequestCount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int totalRequestCountDefaultValue;
				if (flag)
				{
					totalRequestCountDefaultValue = this.totalRequestCount_;
				}
				else
				{
					totalRequestCountDefaultValue = SetCompilationStatusMessage.TotalRequestCountDefaultValue;
				}
				return totalRequestCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.totalRequestCount_ = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003BF RID: 959 RVA: 0x000133B0 File Offset: 0x000115B0
		[DebuggerNonUserCode]
		public bool HasTotalRequestCount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000133CD File Offset: 0x000115CD
		[DebuggerNonUserCode]
		public void ClearTotalRequestCount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000133E0 File Offset: 0x000115E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetCompilationStatusMessage);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00013400 File Offset: 0x00011600
		[DebuggerNonUserCode]
		public bool Equals(SetCompilationStatusMessage other)
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
					bool flag4 = this.CompilationMessage != other.CompilationMessage;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CompletedRequestCount != other.CompletedRequestCount;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TotalRequestCount != other.TotalRequestCount;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0001348C File Offset: 0x0001168C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCompilationMessage = this.HasCompilationMessage;
			if (hasCompilationMessage)
			{
				num ^= this.CompilationMessage.GetHashCode();
			}
			bool hasCompletedRequestCount = this.HasCompletedRequestCount;
			if (hasCompletedRequestCount)
			{
				num ^= this.CompletedRequestCount.GetHashCode();
			}
			bool hasTotalRequestCount = this.HasTotalRequestCount;
			if (hasTotalRequestCount)
			{
				num ^= this.TotalRequestCount.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00013514 File Offset: 0x00011714
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0001352C File Offset: 0x0001172C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00013538 File Offset: 0x00011738
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCompilationMessage = this.HasCompilationMessage;
			if (hasCompilationMessage)
			{
				output.WriteRawTag(10);
				output.WriteString(this.CompilationMessage);
			}
			bool hasCompletedRequestCount = this.HasCompletedRequestCount;
			if (hasCompletedRequestCount)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CompletedRequestCount);
			}
			bool hasTotalRequestCount = this.HasTotalRequestCount;
			if (hasTotalRequestCount)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalRequestCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000135C8 File Offset: 0x000117C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCompilationMessage = this.HasCompilationMessage;
			if (hasCompilationMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CompilationMessage);
			}
			bool hasCompletedRequestCount = this.HasCompletedRequestCount;
			if (hasCompletedRequestCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CompletedRequestCount);
			}
			bool hasTotalRequestCount = this.HasTotalRequestCount;
			if (hasTotalRequestCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalRequestCount);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00013654 File Offset: 0x00011854
		[DebuggerNonUserCode]
		public void MergeFrom(SetCompilationStatusMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCompilationMessage = other.HasCompilationMessage;
				if (hasCompilationMessage)
				{
					this.CompilationMessage = other.CompilationMessage;
				}
				bool hasCompletedRequestCount = other.HasCompletedRequestCount;
				if (hasCompletedRequestCount)
				{
					this.CompletedRequestCount = other.CompletedRequestCount;
				}
				bool hasTotalRequestCount = other.HasTotalRequestCount;
				if (hasTotalRequestCount)
				{
					this.TotalRequestCount = other.TotalRequestCount;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000136CF File Offset: 0x000118CF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000136DC File Offset: 0x000118DC
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalRequestCount = input.ReadInt32();
						}
					}
					else
					{
						this.CompletedRequestCount = input.ReadInt32();
					}
				}
				else
				{
					this.CompilationMessage = input.ReadString();
				}
			}
		}

		// Token: 0x04000184 RID: 388
		private static readonly MessageParser<SetCompilationStatusMessage> _parser = new MessageParser<SetCompilationStatusMessage>(() => new SetCompilationStatusMessage());

		// Token: 0x04000185 RID: 389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000186 RID: 390
		private int _hasBits0;

		// Token: 0x04000187 RID: 391
		public const int CompilationMessageFieldNumber = 1;

		// Token: 0x04000188 RID: 392
		private static readonly string CompilationMessageDefaultValue = "";

		// Token: 0x04000189 RID: 393
		private string compilationMessage_;

		// Token: 0x0400018A RID: 394
		public const int CompletedRequestCountFieldNumber = 2;

		// Token: 0x0400018B RID: 395
		private static readonly int CompletedRequestCountDefaultValue = 0;

		// Token: 0x0400018C RID: 396
		private int completedRequestCount_;

		// Token: 0x0400018D RID: 397
		public const int TotalRequestCountFieldNumber = 3;

		// Token: 0x0400018E RID: 398
		private static readonly int TotalRequestCountDefaultValue = 0;

		// Token: 0x0400018F RID: 399
		private int totalRequestCount_;
	}
}
