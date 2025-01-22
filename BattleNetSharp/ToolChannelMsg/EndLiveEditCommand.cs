using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000032 RID: 50
	public sealed class EndLiveEditCommand : IMessage<EndLiveEditCommand>, IMessage, IEquatable<EndLiveEditCommand>, IDeepCloneable<EndLiveEditCommand>, IBufferMessage
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000123D8 File Offset: 0x000105D8
		[DebuggerNonUserCode]
		public static MessageParser<EndLiveEditCommand> Parser
		{
			get
			{
				return EndLiveEditCommand._parser;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000123F0 File Offset: 0x000105F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00012414 File Offset: 0x00010614
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndLiveEditCommand.Descriptor;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001242B File Offset: 0x0001062B
		[DebuggerNonUserCode]
		public EndLiveEditCommand()
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00012435 File Offset: 0x00010635
		[DebuggerNonUserCode]
		public EndLiveEditCommand(EndLiveEditCommand other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00012474 File Offset: 0x00010674
		[DebuggerNonUserCode]
		public EndLiveEditCommand Clone()
		{
			return new EndLiveEditCommand(this);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0001248C File Offset: 0x0001068C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000124BD File Offset: 0x000106BD
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
					snoGroupDefaultValue = EndLiveEditCommand.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000124D8 File Offset: 0x000106D8
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000124F5 File Offset: 0x000106F5
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00012508 File Offset: 0x00010708
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00012539 File Offset: 0x00010739
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
					snoHandleDefaultValue = EndLiveEditCommand.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00012554 File Offset: 0x00010754
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00012571 File Offset: 0x00010771
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00012584 File Offset: 0x00010784
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndLiveEditCommand);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000125A4 File Offset: 0x000107A4
		[DebuggerNonUserCode]
		public bool Equals(EndLiveEditCommand other)
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

		// Token: 0x06000374 RID: 884 RVA: 0x00012618 File Offset: 0x00010818
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

		// Token: 0x06000375 RID: 885 RVA: 0x00012684 File Offset: 0x00010884
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001269C File Offset: 0x0001089C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000126A8 File Offset: 0x000108A8
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

		// Token: 0x06000378 RID: 888 RVA: 0x00012718 File Offset: 0x00010918
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

		// Token: 0x06000379 RID: 889 RVA: 0x00012784 File Offset: 0x00010984
		[DebuggerNonUserCode]
		public void MergeFrom(EndLiveEditCommand other)
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

		// Token: 0x0600037A RID: 890 RVA: 0x000127E6 File Offset: 0x000109E6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000127F4 File Offset: 0x000109F4
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

		// Token: 0x04000169 RID: 361
		private static readonly MessageParser<EndLiveEditCommand> _parser = new MessageParser<EndLiveEditCommand>(() => new EndLiveEditCommand());

		// Token: 0x0400016A RID: 362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400016B RID: 363
		private int _hasBits0;

		// Token: 0x0400016C RID: 364
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x0400016D RID: 365
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x0400016E RID: 366
		private int snoGroup_;

		// Token: 0x0400016F RID: 367
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x04000170 RID: 368
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000171 RID: 369
		private int snoHandle_;
	}
}
