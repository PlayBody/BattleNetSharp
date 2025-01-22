using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000033 RID: 51
	public sealed class RefreshLiveEditCommand : IMessage<RefreshLiveEditCommand>, IMessage, IEquatable<RefreshLiveEditCommand>, IDeepCloneable<RefreshLiveEditCommand>, IBufferMessage
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00012884 File Offset: 0x00010A84
		[DebuggerNonUserCode]
		public static MessageParser<RefreshLiveEditCommand> Parser
		{
			get
			{
				return RefreshLiveEditCommand._parser;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0001289C File Offset: 0x00010A9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000128C0 File Offset: 0x00010AC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshLiveEditCommand.Descriptor;
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000128D7 File Offset: 0x00010AD7
		[DebuggerNonUserCode]
		public RefreshLiveEditCommand()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000128E1 File Offset: 0x00010AE1
		[DebuggerNonUserCode]
		public RefreshLiveEditCommand(RefreshLiveEditCommand other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00012920 File Offset: 0x00010B20
		[DebuggerNonUserCode]
		public RefreshLiveEditCommand Clone()
		{
			return new RefreshLiveEditCommand(this);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00012938 File Offset: 0x00010B38
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00012969 File Offset: 0x00010B69
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = RefreshLiveEditCommand.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00012984 File Offset: 0x00010B84
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000129A1 File Offset: 0x00010BA1
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000387 RID: 903 RVA: 0x000129B4 File Offset: 0x00010BB4
		// (set) Token: 0x06000388 RID: 904 RVA: 0x000129E5 File Offset: 0x00010BE5
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = RefreshLiveEditCommand.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00012A00 File Offset: 0x00010C00
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00012A1D File Offset: 0x00010C1D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00012A30 File Offset: 0x00010C30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshLiveEditCommand);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00012A50 File Offset: 0x00010C50
		[DebuggerNonUserCode]
		public bool Equals(RefreshLiveEditCommand other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00012AC4 File Offset: 0x00010CC4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00012B30 File Offset: 0x00010D30
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00012B48 File Offset: 0x00010D48
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00012B54 File Offset: 0x00010D54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00012BC4 File Offset: 0x00010DC4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00012C30 File Offset: 0x00010E30
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshLiveEditCommand other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00012C92 File Offset: 0x00010E92
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00012CA0 File Offset: 0x00010EA0
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
						this.SnoHandle = input.ReadInt32();
					}
				}
				else
				{
					this.SnoGroup = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000172 RID: 370
		private static readonly MessageParser<RefreshLiveEditCommand> _parser = new MessageParser<RefreshLiveEditCommand>(() => new RefreshLiveEditCommand());

		// Token: 0x04000173 RID: 371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000174 RID: 372
		private int _hasBits0;

		// Token: 0x04000175 RID: 373
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x04000176 RID: 374
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x04000177 RID: 375
		private int snoGroup_;

		// Token: 0x04000178 RID: 376
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x04000179 RID: 377
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400017A RID: 378
		private int snoHandle_;
	}
}
