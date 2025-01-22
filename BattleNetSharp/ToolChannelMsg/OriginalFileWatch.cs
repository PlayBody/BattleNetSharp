using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200004D RID: 77
	public sealed class OriginalFileWatch : IMessage<OriginalFileWatch>, IMessage, IEquatable<OriginalFileWatch>, IDeepCloneable<OriginalFileWatch>, IBufferMessage
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0001CE38 File Offset: 0x0001B038
		[DebuggerNonUserCode]
		public static MessageParser<OriginalFileWatch> Parser
		{
			get
			{
				return OriginalFileWatch._parser;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001CE50 File Offset: 0x0001B050
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[54];
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001CE74 File Offset: 0x0001B074
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OriginalFileWatch.Descriptor;
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001CE8B File Offset: 0x0001B08B
		[DebuggerNonUserCode]
		public OriginalFileWatch()
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001CE98 File Offset: 0x0001B098
		[DebuggerNonUserCode]
		public OriginalFileWatch(OriginalFileWatch other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.file_ = other.file_;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		[DebuggerNonUserCode]
		public OriginalFileWatch Clone()
		{
			return new OriginalFileWatch(this);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0001CF08 File Offset: 0x0001B108
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0001CF29 File Offset: 0x0001B129
		[DebuggerNonUserCode]
		public string File
		{
			get
			{
				return this.file_ ?? OriginalFileWatch.FileDefaultValue;
			}
			set
			{
				this.file_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001CF40 File Offset: 0x0001B140
		[DebuggerNonUserCode]
		public bool HasFile
		{
			get
			{
				return this.file_ != null;
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001CF5B File Offset: 0x0001B15B
		[DebuggerNonUserCode]
		public void ClearFile()
		{
			this.file_ = null;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0001CF68 File Offset: 0x0001B168
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0001CF99 File Offset: 0x0001B199
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
					snoGroupDefaultValue = OriginalFileWatch.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001CFD1 File Offset: 0x0001B1D1
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0001D015 File Offset: 0x0001B215
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
					snoHandleDefaultValue = OriginalFileWatch.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0001D030 File Offset: 0x0001B230
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001D04D File Offset: 0x0001B24D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001D060 File Offset: 0x0001B260
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OriginalFileWatch);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001D080 File Offset: 0x0001B280
		[DebuggerNonUserCode]
		public bool Equals(OriginalFileWatch other)
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
					bool flag4 = this.File != other.File;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoGroup != other.SnoGroup;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoHandle != other.SnoHandle;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001D10C File Offset: 0x0001B30C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFile = this.HasFile;
			if (hasFile)
			{
				num ^= this.File.GetHashCode();
			}
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

		// Token: 0x06000693 RID: 1683 RVA: 0x0001D194 File Offset: 0x0001B394
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFile = this.HasFile;
			if (hasFile)
			{
				output.WriteRawTag(10);
				output.WriteString(this.File);
			}
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001D248 File Offset: 0x0001B448
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFile = this.HasFile;
			if (hasFile)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.File);
			}
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

		// Token: 0x06000697 RID: 1687 RVA: 0x0001D2D4 File Offset: 0x0001B4D4
		[DebuggerNonUserCode]
		public void MergeFrom(OriginalFileWatch other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFile = other.HasFile;
				if (hasFile)
				{
					this.File = other.File;
				}
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

		// Token: 0x06000698 RID: 1688 RVA: 0x0001D34F File Offset: 0x0001B54F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001D35C File Offset: 0x0001B55C
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
							this.SnoHandle = input.ReadInt32();
						}
					}
					else
					{
						this.SnoGroup = input.ReadInt32();
					}
				}
				else
				{
					this.File = input.ReadString();
				}
			}
		}

		// Token: 0x040002BE RID: 702
		private static readonly MessageParser<OriginalFileWatch> _parser = new MessageParser<OriginalFileWatch>(() => new OriginalFileWatch());

		// Token: 0x040002BF RID: 703
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002C0 RID: 704
		private int _hasBits0;

		// Token: 0x040002C1 RID: 705
		public const int FileFieldNumber = 1;

		// Token: 0x040002C2 RID: 706
		private static readonly string FileDefaultValue = "";

		// Token: 0x040002C3 RID: 707
		private string file_;

		// Token: 0x040002C4 RID: 708
		public const int SnoGroupFieldNumber = 2;

		// Token: 0x040002C5 RID: 709
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040002C6 RID: 710
		private int snoGroup_;

		// Token: 0x040002C7 RID: 711
		public const int SnoHandleFieldNumber = 3;

		// Token: 0x040002C8 RID: 712
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040002C9 RID: 713
		private int snoHandle_;
	}
}
