using System;
using System.Diagnostics;
using Fenris.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001C0 RID: 448
	public sealed class MailContents : IMessage<MailContents>, IMessage, IEquatable<MailContents>, IDeepCloneable<MailContents>, IBufferMessage
	{
		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x000B8CD4 File Offset: 0x000B6ED4
		[DebuggerNonUserCode]
		public static MessageParser<MailContents> Parser
		{
			get
			{
				return MailContents._parser;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000B8CEC File Offset: 0x000B6EEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000B8D10 File Offset: 0x000B6F10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailContents.Descriptor;
			}
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000B8D27 File Offset: 0x000B6F27
		[DebuggerNonUserCode]
		public MailContents()
		{
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000B8D34 File Offset: 0x000B6F34
		[DebuggerNonUserCode]
		public MailContents(MailContents other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.appendMessages_ = other.appendMessages_;
			this.mails_ = ((other.mails_ != null) ? other.mails_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000B8D90 File Offset: 0x000B6F90
		[DebuggerNonUserCode]
		public MailContents Clone()
		{
			return new MailContents(this);
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002EEA RID: 12010 RVA: 0x000B8DA8 File Offset: 0x000B6FA8
		// (set) Token: 0x06002EEB RID: 12011 RVA: 0x000B8DD9 File Offset: 0x000B6FD9
		[DebuggerNonUserCode]
		public bool AppendMessages
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool appendMessagesDefaultValue;
				if (flag)
				{
					appendMessagesDefaultValue = this.appendMessages_;
				}
				else
				{
					appendMessagesDefaultValue = MailContents.AppendMessagesDefaultValue;
				}
				return appendMessagesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.appendMessages_ = value;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002EEC RID: 12012 RVA: 0x000B8DF4 File Offset: 0x000B6FF4
		[DebuggerNonUserCode]
		public bool HasAppendMessages
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000B8E11 File Offset: 0x000B7011
		[DebuggerNonUserCode]
		public void ClearAppendMessages()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002EEE RID: 12014 RVA: 0x000B8E24 File Offset: 0x000B7024
		// (set) Token: 0x06002EEF RID: 12015 RVA: 0x000B8E3C File Offset: 0x000B703C
		[DebuggerNonUserCode]
		public Mails Mails
		{
			get
			{
				return this.mails_;
			}
			set
			{
				this.mails_ = value;
			}
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000B8E48 File Offset: 0x000B7048
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailContents);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000B8E68 File Offset: 0x000B7068
		[DebuggerNonUserCode]
		public bool Equals(MailContents other)
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
					bool flag4 = this.AppendMessages != other.AppendMessages;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Mails, other.Mails);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x000B8EDC File Offset: 0x000B70DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAppendMessages = this.HasAppendMessages;
			if (hasAppendMessages)
			{
				num ^= this.AppendMessages.GetHashCode();
			}
			bool flag = this.mails_ != null;
			if (flag)
			{
				num ^= this.Mails.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x000B8F48 File Offset: 0x000B7148
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x000B8F60 File Offset: 0x000B7160
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x000B8F6C File Offset: 0x000B716C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAppendMessages = this.HasAppendMessages;
			if (hasAppendMessages)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AppendMessages);
			}
			bool flag = this.mails_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Mails);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x000B8FDC File Offset: 0x000B71DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAppendMessages = this.HasAppendMessages;
			if (hasAppendMessages)
			{
				num += 2;
			}
			bool flag = this.mails_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Mails);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000B9040 File Offset: 0x000B7240
		[DebuggerNonUserCode]
		public void MergeFrom(MailContents other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAppendMessages = other.HasAppendMessages;
				if (hasAppendMessages)
				{
					this.AppendMessages = other.AppendMessages;
				}
				bool flag2 = other.mails_ != null;
				if (flag2)
				{
					bool flag3 = this.mails_ == null;
					if (flag3)
					{
						this.Mails = new Mails();
					}
					this.Mails.MergeFrom(other.Mails);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000B90C5 File Offset: 0x000B72C5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000B90D0 File Offset: 0x000B72D0
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.mails_ == null;
						if (flag)
						{
							this.Mails = new Mails();
						}
						input.ReadMessage(this.Mails);
					}
				}
				else
				{
					this.AppendMessages = input.ReadBool();
				}
			}
		}

		// Token: 0x04001523 RID: 5411
		private static readonly MessageParser<MailContents> _parser = new MessageParser<MailContents>(() => new MailContents());

		// Token: 0x04001524 RID: 5412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001525 RID: 5413
		private int _hasBits0;

		// Token: 0x04001526 RID: 5414
		public const int AppendMessagesFieldNumber = 1;

		// Token: 0x04001527 RID: 5415
		private static readonly bool AppendMessagesDefaultValue = false;

		// Token: 0x04001528 RID: 5416
		private bool appendMessages_;

		// Token: 0x04001529 RID: 5417
		public const int MailsFieldNumber = 2;

		// Token: 0x0400152A RID: 5418
		private Mails mails_;
	}
}
