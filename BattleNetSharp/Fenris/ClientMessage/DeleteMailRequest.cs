using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000231 RID: 561
	public sealed class DeleteMailRequest : IMessage<DeleteMailRequest>, IMessage, IEquatable<DeleteMailRequest>, IDeepCloneable<DeleteMailRequest>, IBufferMessage
	{
		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x000F1184 File Offset: 0x000EF384
		[DebuggerNonUserCode]
		public static MessageParser<DeleteMailRequest> Parser
		{
			get
			{
				return DeleteMailRequest._parser;
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x000F119C File Offset: 0x000EF39C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[33];
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x000F11C0 File Offset: 0x000EF3C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteMailRequest.Descriptor;
			}
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x000F11D7 File Offset: 0x000EF3D7
		[DebuggerNonUserCode]
		public DeleteMailRequest()
		{
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x000F11E1 File Offset: 0x000EF3E1
		[DebuggerNonUserCode]
		public DeleteMailRequest(DeleteMailRequest other)
			: this()
		{
			this.mailId_ = other.mailId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x000F1208 File Offset: 0x000EF408
		[DebuggerNonUserCode]
		public DeleteMailRequest Clone()
		{
			return new DeleteMailRequest(this);
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x000F1220 File Offset: 0x000EF420
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x000F1241 File Offset: 0x000EF441
		[DebuggerNonUserCode]
		public string MailId
		{
			get
			{
				return this.mailId_ ?? DeleteMailRequest.MailIdDefaultValue;
			}
			set
			{
				this.mailId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x000F1258 File Offset: 0x000EF458
		[DebuggerNonUserCode]
		public bool HasMailId
		{
			get
			{
				return this.mailId_ != null;
			}
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x000F1273 File Offset: 0x000EF473
		[DebuggerNonUserCode]
		public void ClearMailId()
		{
			this.mailId_ = null;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x000F1280 File Offset: 0x000EF480
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteMailRequest);
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x000F12A0 File Offset: 0x000EF4A0
		[DebuggerNonUserCode]
		public bool Equals(DeleteMailRequest other)
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
					bool flag4 = this.MailId != other.MailId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x000F12F8 File Offset: 0x000EF4F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMailId = this.HasMailId;
			if (hasMailId)
			{
				num ^= this.MailId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x000F1344 File Offset: 0x000EF544
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x000F135C File Offset: 0x000EF55C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x000F1368 File Offset: 0x000EF568
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMailId = this.HasMailId;
			if (hasMailId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.MailId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x000F13B4 File Offset: 0x000EF5B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMailId = this.HasMailId;
			if (hasMailId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MailId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x000F1404 File Offset: 0x000EF604
		[DebuggerNonUserCode]
		public void MergeFrom(DeleteMailRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMailId = other.HasMailId;
				if (hasMailId)
				{
					this.MailId = other.MailId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x000F144D File Offset: 0x000EF64D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x000F1458 File Offset: 0x000EF658
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
					this.MailId = input.ReadString();
				}
			}
		}

		// Token: 0x04001C13 RID: 7187
		private static readonly MessageParser<DeleteMailRequest> _parser = new MessageParser<DeleteMailRequest>(() => new DeleteMailRequest());

		// Token: 0x04001C14 RID: 7188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C15 RID: 7189
		public const int MailIdFieldNumber = 1;

		// Token: 0x04001C16 RID: 7190
		private static readonly string MailIdDefaultValue = "";

		// Token: 0x04001C17 RID: 7191
		private string mailId_;
	}
}
