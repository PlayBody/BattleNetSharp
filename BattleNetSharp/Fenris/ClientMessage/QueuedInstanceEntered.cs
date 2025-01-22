using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000286 RID: 646
	public sealed class QueuedInstanceEntered : IMessage<QueuedInstanceEntered>, IMessage, IEquatable<QueuedInstanceEntered>, IDeepCloneable<QueuedInstanceEntered>, IBufferMessage
	{
		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x001094C4 File Offset: 0x001076C4
		[DebuggerNonUserCode]
		public static MessageParser<QueuedInstanceEntered> Parser
		{
			get
			{
				return QueuedInstanceEntered._parser;
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x001094DC File Offset: 0x001076DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[118];
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x00109500 File Offset: 0x00107700
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueuedInstanceEntered.Descriptor;
			}
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x00109517 File Offset: 0x00107717
		[DebuggerNonUserCode]
		public QueuedInstanceEntered()
		{
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00109521 File Offset: 0x00107721
		[DebuggerNonUserCode]
		public QueuedInstanceEntered(QueuedInstanceEntered other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSubzone_ = other.snoSubzone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00109554 File Offset: 0x00107754
		[DebuggerNonUserCode]
		public QueuedInstanceEntered Clone()
		{
			return new QueuedInstanceEntered(this);
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x0010956C File Offset: 0x0010776C
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x0010959D File Offset: 0x0010779D
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = QueuedInstanceEntered.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x001095B8 File Offset: 0x001077B8
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x001095D5 File Offset: 0x001077D5
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001095E8 File Offset: 0x001077E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueuedInstanceEntered);
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x00109608 File Offset: 0x00107808
		[DebuggerNonUserCode]
		public bool Equals(QueuedInstanceEntered other)
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
					bool flag4 = this.SnoSubzone != other.SnoSubzone;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x00109660 File Offset: 0x00107860
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x001096B0 File Offset: 0x001078B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x001096C8 File Offset: 0x001078C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x001096D4 File Offset: 0x001078D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00109720 File Offset: 0x00107920
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00109764 File Offset: 0x00107964
		[DebuggerNonUserCode]
		public void MergeFrom(QueuedInstanceEntered other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x001097AD File Offset: 0x001079AD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x001097B8 File Offset: 0x001079B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoSubzone = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001EE2 RID: 7906
		private static readonly MessageParser<QueuedInstanceEntered> _parser = new MessageParser<QueuedInstanceEntered>(() => new QueuedInstanceEntered());

		// Token: 0x04001EE3 RID: 7907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EE4 RID: 7908
		private int _hasBits0;

		// Token: 0x04001EE5 RID: 7909
		public const int SnoSubzoneFieldNumber = 1;

		// Token: 0x04001EE6 RID: 7910
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x04001EE7 RID: 7911
		private int snoSubzone_;
	}
}
