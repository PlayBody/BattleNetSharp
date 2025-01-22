using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005D8 RID: 1496
	public sealed class SendNotificationRequest : IMessage<SendNotificationRequest>, IMessage, IEquatable<SendNotificationRequest>, IDeepCloneable<SendNotificationRequest>, IBufferMessage
	{
		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x06008CF6 RID: 36086 RVA: 0x00223598 File Offset: 0x00221798
		[DebuggerNonUserCode]
		public static MessageParser<SendNotificationRequest> Parser
		{
			get
			{
				return SendNotificationRequest._parser;
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x002235B0 File Offset: 0x002217B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x06008CF8 RID: 36088 RVA: 0x002235D4 File Offset: 0x002217D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendNotificationRequest.Descriptor;
			}
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x002235EB File Offset: 0x002217EB
		[DebuggerNonUserCode]
		public SendNotificationRequest()
		{
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x002235F5 File Offset: 0x002217F5
		[DebuggerNonUserCode]
		public SendNotificationRequest(SendNotificationRequest other)
			: this()
		{
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x0022362C File Offset: 0x0022182C
		[DebuggerNonUserCode]
		public SendNotificationRequest Clone()
		{
			return new SendNotificationRequest(this);
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x06008CFC RID: 36092 RVA: 0x00223644 File Offset: 0x00221844
		// (set) Token: 0x06008CFD RID: 36093 RVA: 0x0022365C File Offset: 0x0022185C
		[DebuggerNonUserCode]
		public SendNotificationOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x00223668 File Offset: 0x00221868
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendNotificationRequest);
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x00223688 File Offset: 0x00221888
		[DebuggerNonUserCode]
		public bool Equals(SendNotificationRequest other)
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
					bool flag4 = !object.Equals(this.Options, other.Options);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x002236E4 File Offset: 0x002218E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x00223734 File Offset: 0x00221934
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x0022374C File Offset: 0x0022194C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D03 RID: 36099 RVA: 0x00223758 File Offset: 0x00221958
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D04 RID: 36100 RVA: 0x002237A8 File Offset: 0x002219A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D05 RID: 36101 RVA: 0x002237FC File Offset: 0x002219FC
		[DebuggerNonUserCode]
		public void MergeFrom(SendNotificationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new SendNotificationOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008D06 RID: 36102 RVA: 0x00223868 File Offset: 0x00221A68
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D07 RID: 36103 RVA: 0x00223874 File Offset: 0x00221A74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.options_ == null;
					if (flag)
					{
						this.Options = new SendNotificationOptions();
					}
					input.ReadMessage(this.Options);
				}
			}
		}

		// Token: 0x04003FC2 RID: 16322
		private static readonly MessageParser<SendNotificationRequest> _parser = new MessageParser<SendNotificationRequest>(() => new SendNotificationRequest());

		// Token: 0x04003FC3 RID: 16323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FC4 RID: 16324
		public const int OptionsFieldNumber = 2;

		// Token: 0x04003FC5 RID: 16325
		private SendNotificationOptions options_;
	}
}
