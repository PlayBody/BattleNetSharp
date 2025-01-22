using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200009E RID: 158
	public sealed class HighlightUITreeNode : IMessage<HighlightUITreeNode>, IMessage, IEquatable<HighlightUITreeNode>, IDeepCloneable<HighlightUITreeNode>, IBufferMessage
	{
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00036360 File Offset: 0x00034560
		[DebuggerNonUserCode]
		public static MessageParser<HighlightUITreeNode> Parser
		{
			get
			{
				return HighlightUITreeNode._parser;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00036378 File Offset: 0x00034578
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[135];
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x000363A0 File Offset: 0x000345A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HighlightUITreeNode.Descriptor;
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000363B7 File Offset: 0x000345B7
		[DebuggerNonUserCode]
		public HighlightUITreeNode()
		{
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x000363C1 File Offset: 0x000345C1
		[DebuggerNonUserCode]
		public HighlightUITreeNode(HighlightUITreeNode other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x000363F4 File Offset: 0x000345F4
		[DebuggerNonUserCode]
		public HighlightUITreeNode Clone()
		{
			return new HighlightUITreeNode(this);
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0003640C File Offset: 0x0003460C
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x0003643D File Offset: 0x0003463D
		[DebuggerNonUserCode]
		public ulong Hash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong hashDefaultValue;
				if (flag)
				{
					hashDefaultValue = this.hash_;
				}
				else
				{
					hashDefaultValue = HighlightUITreeNode.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x00036458 File Offset: 0x00034658
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00036475 File Offset: 0x00034675
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00036488 File Offset: 0x00034688
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HighlightUITreeNode);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000364A8 File Offset: 0x000346A8
		[DebuggerNonUserCode]
		public bool Equals(HighlightUITreeNode other)
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
					bool flag4 = this.Hash != other.Hash;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00036500 File Offset: 0x00034700
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00036550 File Offset: 0x00034750
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00036568 File Offset: 0x00034768
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00036574 File Offset: 0x00034774
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Hash);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000365C0 File Offset: 0x000347C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Hash);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00036610 File Offset: 0x00034810
		[DebuggerNonUserCode]
		public void MergeFrom(HighlightUITreeNode other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00036659 File Offset: 0x00034859
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00036664 File Offset: 0x00034864
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
					this.Hash = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040005CA RID: 1482
		private static readonly MessageParser<HighlightUITreeNode> _parser = new MessageParser<HighlightUITreeNode>(() => new HighlightUITreeNode());

		// Token: 0x040005CB RID: 1483
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005CC RID: 1484
		private int _hasBits0;

		// Token: 0x040005CD RID: 1485
		public const int HashFieldNumber = 1;

		// Token: 0x040005CE RID: 1486
		private static readonly ulong HashDefaultValue = 0UL;

		// Token: 0x040005CF RID: 1487
		private ulong hash_;
	}
}
