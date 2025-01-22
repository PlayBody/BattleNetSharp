using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200004B RID: 75
	public sealed class ActorTypeUpdateNotification : IMessage<ActorTypeUpdateNotification>, IMessage, IEquatable<ActorTypeUpdateNotification>, IDeepCloneable<ActorTypeUpdateNotification>, IBufferMessage
	{
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001C618 File Offset: 0x0001A818
		[DebuggerNonUserCode]
		public static MessageParser<ActorTypeUpdateNotification> Parser
		{
			get
			{
				return ActorTypeUpdateNotification._parser;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001C630 File Offset: 0x0001A830
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[52];
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001C654 File Offset: 0x0001A854
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorTypeUpdateNotification.Descriptor;
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001C66B File Offset: 0x0001A86B
		[DebuggerNonUserCode]
		public ActorTypeUpdateNotification()
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0001C675 File Offset: 0x0001A875
		[DebuggerNonUserCode]
		public ActorTypeUpdateNotification(ActorTypeUpdateNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
		[DebuggerNonUserCode]
		public ActorTypeUpdateNotification Clone()
		{
			return new ActorTypeUpdateNotification(this);
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x0001C6F1 File Offset: 0x0001A8F1
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = ActorTypeUpdateNotification.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0001C70C File Offset: 0x0001A90C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001C729 File Offset: 0x0001A929
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0001C73C File Offset: 0x0001A93C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorTypeUpdateNotification);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001C75C File Offset: 0x0001A95C
		[DebuggerNonUserCode]
		public bool Equals(ActorTypeUpdateNotification other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600065D RID: 1629 RVA: 0x0001C804 File Offset: 0x0001AA04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001C81C File Offset: 0x0001AA1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001C828 File Offset: 0x0001AA28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001C874 File Offset: 0x0001AA74
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06000661 RID: 1633 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		[DebuggerNonUserCode]
		public void MergeFrom(ActorTypeUpdateNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001C90D File Offset: 0x0001AB0D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001C918 File Offset: 0x0001AB18
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
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040002AF RID: 687
		private static readonly MessageParser<ActorTypeUpdateNotification> _parser = new MessageParser<ActorTypeUpdateNotification>(() => new ActorTypeUpdateNotification());

		// Token: 0x040002B0 RID: 688
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002B1 RID: 689
		private int _hasBits0;

		// Token: 0x040002B2 RID: 690
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040002B3 RID: 691
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040002B4 RID: 692
		private int snoHandle_;
	}
}
