using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200004C RID: 76
	public sealed class SNOName : IMessage<SNOName>, IMessage, IEquatable<SNOName>, IDeepCloneable<SNOName>, IBufferMessage
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001C98C File Offset: 0x0001AB8C
		[DebuggerNonUserCode]
		public static MessageParser<SNOName> Parser
		{
			get
			{
				return SNOName._parser;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[53];
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SNOName.Descriptor;
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001C9DF File Offset: 0x0001ABDF
		[DebuggerNonUserCode]
		public SNOName()
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001C9E9 File Offset: 0x0001ABE9
		[DebuggerNonUserCode]
		public SNOName(SNOName other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001CA28 File Offset: 0x0001AC28
		[DebuggerNonUserCode]
		public SNOName Clone()
		{
			return new SNOName(this);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001CA40 File Offset: 0x0001AC40
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0001CA71 File Offset: 0x0001AC71
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
					snoGroupDefaultValue = SNOName.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0001CA8C File Offset: 0x0001AC8C
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001CAA9 File Offset: 0x0001ACA9
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001CABC File Offset: 0x0001ACBC
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0001CAED File Offset: 0x0001ACED
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
					snoHandleDefaultValue = SNOName.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001CB08 File Offset: 0x0001AD08
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001CB25 File Offset: 0x0001AD25
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001CB38 File Offset: 0x0001AD38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SNOName);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001CB58 File Offset: 0x0001AD58
		[DebuggerNonUserCode]
		public bool Equals(SNOName other)
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

		// Token: 0x06000675 RID: 1653 RVA: 0x0001CBCC File Offset: 0x0001ADCC
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

		// Token: 0x06000676 RID: 1654 RVA: 0x0001CC38 File Offset: 0x0001AE38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001CC50 File Offset: 0x0001AE50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001CC5C File Offset: 0x0001AE5C
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

		// Token: 0x06000679 RID: 1657 RVA: 0x0001CCCC File Offset: 0x0001AECC
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

		// Token: 0x0600067A RID: 1658 RVA: 0x0001CD38 File Offset: 0x0001AF38
		[DebuggerNonUserCode]
		public void MergeFrom(SNOName other)
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

		// Token: 0x0600067B RID: 1659 RVA: 0x0001CD9A File Offset: 0x0001AF9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
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

		// Token: 0x040002B5 RID: 693
		private static readonly MessageParser<SNOName> _parser = new MessageParser<SNOName>(() => new SNOName());

		// Token: 0x040002B6 RID: 694
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002B7 RID: 695
		private int _hasBits0;

		// Token: 0x040002B8 RID: 696
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040002B9 RID: 697
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040002BA RID: 698
		private int snoGroup_;

		// Token: 0x040002BB RID: 699
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040002BC RID: 700
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040002BD RID: 701
		private int snoHandle_;
	}
}
