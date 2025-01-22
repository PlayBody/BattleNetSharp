using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200016A RID: 362
	public sealed class MailAttachments : IMessage<MailAttachments>, IMessage, IEquatable<MailAttachments>, IDeepCloneable<MailAttachments>, IBufferMessage
	{
		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x00092BA4 File Offset: 0x00090DA4
		[DebuggerNonUserCode]
		public static MessageParser<MailAttachments> Parser
		{
			get
			{
				return MailAttachments._parser;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x00092BBC File Offset: 0x00090DBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x00092BE0 File Offset: 0x00090DE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailAttachments.Descriptor;
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00092BF7 File Offset: 0x00090DF7
		[DebuggerNonUserCode]
		public MailAttachments()
		{
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00092C01 File Offset: 0x00090E01
		[DebuggerNonUserCode]
		public MailAttachments(MailAttachments other)
			: this()
		{
			this.items_ = ((other.items_ != null) ? other.items_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00092C38 File Offset: 0x00090E38
		[DebuggerNonUserCode]
		public MailAttachments Clone()
		{
			return new MailAttachments(this);
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x00092C50 File Offset: 0x00090E50
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x00092C68 File Offset: 0x00090E68
		[DebuggerNonUserCode]
		public ItemList Items
		{
			get
			{
				return this.items_;
			}
			set
			{
				this.items_ = value;
			}
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00092C74 File Offset: 0x00090E74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailAttachments);
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00092C94 File Offset: 0x00090E94
		[DebuggerNonUserCode]
		public bool Equals(MailAttachments other)
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
					bool flag4 = !object.Equals(this.Items, other.Items);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00092CF0 File Offset: 0x00090EF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.items_ != null;
			if (flag)
			{
				num ^= this.Items.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00092D40 File Offset: 0x00090F40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00092D58 File Offset: 0x00090F58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00092D64 File Offset: 0x00090F64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.items_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Items);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00092DB4 File Offset: 0x00090FB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.items_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Items);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00092E08 File Offset: 0x00091008
		[DebuggerNonUserCode]
		public void MergeFrom(MailAttachments other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.items_ != null;
				if (flag2)
				{
					bool flag3 = this.items_ == null;
					if (flag3)
					{
						this.Items = new ItemList();
					}
					this.Items.MergeFrom(other.Items);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00092E74 File Offset: 0x00091074
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00092E80 File Offset: 0x00091080
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.items_ == null;
					if (flag)
					{
						this.Items = new ItemList();
					}
					input.ReadMessage(this.Items);
				}
			}
		}

		// Token: 0x040010AD RID: 4269
		private static readonly MessageParser<MailAttachments> _parser = new MessageParser<MailAttachments>(() => new MailAttachments());

		// Token: 0x040010AE RID: 4270
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010AF RID: 4271
		public const int ItemsFieldNumber = 1;

		// Token: 0x040010B0 RID: 4272
		private ItemList items_;
	}
}
