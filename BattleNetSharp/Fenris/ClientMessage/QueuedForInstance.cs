using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000283 RID: 643
	public sealed class QueuedForInstance : IMessage<QueuedForInstance>, IMessage, IEquatable<QueuedForInstance>, IDeepCloneable<QueuedForInstance>, IBufferMessage
	{
		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x00108950 File Offset: 0x00106B50
		[DebuggerNonUserCode]
		public static MessageParser<QueuedForInstance> Parser
		{
			get
			{
				return QueuedForInstance._parser;
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x00108968 File Offset: 0x00106B68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[115];
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x0010898C File Offset: 0x00106B8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueuedForInstance.Descriptor;
			}
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x001089A3 File Offset: 0x00106BA3
		[DebuggerNonUserCode]
		public QueuedForInstance()
		{
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x001089AD File Offset: 0x00106BAD
		[DebuggerNonUserCode]
		public QueuedForInstance(QueuedForInstance other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.subzoneType_ = other.subzoneType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x001089E0 File Offset: 0x00106BE0
		[DebuggerNonUserCode]
		public QueuedForInstance Clone()
		{
			return new QueuedForInstance(this);
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x001089F8 File Offset: 0x00106BF8
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x00108A29 File Offset: 0x00106C29
		[DebuggerNonUserCode]
		public int SubzoneType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int subzoneTypeDefaultValue;
				if (flag)
				{
					subzoneTypeDefaultValue = this.subzoneType_;
				}
				else
				{
					subzoneTypeDefaultValue = QueuedForInstance.SubzoneTypeDefaultValue;
				}
				return subzoneTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.subzoneType_ = value;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x00108A44 File Offset: 0x00106C44
		[DebuggerNonUserCode]
		public bool HasSubzoneType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x00108A61 File Offset: 0x00106C61
		[DebuggerNonUserCode]
		public void ClearSubzoneType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00108A74 File Offset: 0x00106C74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueuedForInstance);
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x00108A94 File Offset: 0x00106C94
		[DebuggerNonUserCode]
		public bool Equals(QueuedForInstance other)
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
					bool flag4 = this.SubzoneType != other.SubzoneType;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x00108AEC File Offset: 0x00106CEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSubzoneType = this.HasSubzoneType;
			if (hasSubzoneType)
			{
				num ^= this.SubzoneType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00108B3C File Offset: 0x00106D3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00108B54 File Offset: 0x00106D54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x00108B60 File Offset: 0x00106D60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSubzoneType = this.HasSubzoneType;
			if (hasSubzoneType)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SubzoneType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x00108BAC File Offset: 0x00106DAC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSubzoneType = this.HasSubzoneType;
			if (hasSubzoneType)
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

		// Token: 0x060044AC RID: 17580 RVA: 0x00108BF0 File Offset: 0x00106DF0
		[DebuggerNonUserCode]
		public void MergeFrom(QueuedForInstance other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSubzoneType = other.HasSubzoneType;
				if (hasSubzoneType)
				{
					this.SubzoneType = other.SubzoneType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00108C39 File Offset: 0x00106E39
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x00108C44 File Offset: 0x00106E44
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
					this.SubzoneType = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001ECD RID: 7885
		private static readonly MessageParser<QueuedForInstance> _parser = new MessageParser<QueuedForInstance>(() => new QueuedForInstance());

		// Token: 0x04001ECE RID: 7886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001ECF RID: 7887
		private int _hasBits0;

		// Token: 0x04001ED0 RID: 7888
		public const int SubzoneTypeFieldNumber = 1;

		// Token: 0x04001ED1 RID: 7889
		private static readonly int SubzoneTypeDefaultValue = 0;

		// Token: 0x04001ED2 RID: 7890
		private int subzoneType_;
	}
}
