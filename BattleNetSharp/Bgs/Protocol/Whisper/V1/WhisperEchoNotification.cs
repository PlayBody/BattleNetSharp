using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x0200039C RID: 924
	public sealed class WhisperEchoNotification : IMessage<WhisperEchoNotification>, IMessage, IEquatable<WhisperEchoNotification>, IDeepCloneable<WhisperEchoNotification>, IBufferMessage
	{
		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06005D8E RID: 23950 RVA: 0x0016A3C0 File Offset: 0x001685C0
		[DebuggerNonUserCode]
		public static MessageParser<WhisperEchoNotification> Parser
		{
			get
			{
				return WhisperEchoNotification._parser;
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06005D8F RID: 23951 RVA: 0x0016A3D8 File Offset: 0x001685D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06005D90 RID: 23952 RVA: 0x0016A3FC File Offset: 0x001685FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WhisperEchoNotification.Descriptor;
			}
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x0016A413 File Offset: 0x00168613
		[DebuggerNonUserCode]
		public WhisperEchoNotification()
		{
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x0016A420 File Offset: 0x00168620
		[DebuggerNonUserCode]
		public WhisperEchoNotification(WhisperEchoNotification other)
			: this()
		{
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.whisper_ = ((other.whisper_ != null) ? other.whisper_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x0016A480 File Offset: 0x00168680
		[DebuggerNonUserCode]
		public WhisperEchoNotification Clone()
		{
			return new WhisperEchoNotification(this);
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06005D94 RID: 23956 RVA: 0x0016A498 File Offset: 0x00168698
		// (set) Token: 0x06005D95 RID: 23957 RVA: 0x0016A4B0 File Offset: 0x001686B0
		[DebuggerNonUserCode]
		public AccountId SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06005D96 RID: 23958 RVA: 0x0016A4BC File Offset: 0x001686BC
		// (set) Token: 0x06005D97 RID: 23959 RVA: 0x0016A4D4 File Offset: 0x001686D4
		[DebuggerNonUserCode]
		public Whisper Whisper
		{
			get
			{
				return this.whisper_;
			}
			set
			{
				this.whisper_ = value;
			}
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x0016A4E0 File Offset: 0x001686E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WhisperEchoNotification);
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x0016A500 File Offset: 0x00168700
		[DebuggerNonUserCode]
		public bool Equals(WhisperEchoNotification other)
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
					bool flag4 = !object.Equals(this.SubscriberId, other.SubscriberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Whisper, other.Whisper);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x0016A578 File Offset: 0x00168778
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag2 = this.whisper_ != null;
			if (flag2)
			{
				num ^= this.Whisper.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x0016A5E4 File Offset: 0x001687E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x0016A5FC File Offset: 0x001687FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x0016A608 File Offset: 0x00168808
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag2 = this.whisper_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Whisper);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x0016A67C File Offset: 0x0016887C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag2 = this.whisper_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Whisper);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x0016A6F0 File Offset: 0x001688F0
		[DebuggerNonUserCode]
		public void MergeFrom(WhisperEchoNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.subscriberId_ != null;
				if (flag2)
				{
					bool flag3 = this.subscriberId_ == null;
					if (flag3)
					{
						this.SubscriberId = new AccountId();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				bool flag4 = other.whisper_ != null;
				if (flag4)
				{
					bool flag5 = this.whisper_ == null;
					if (flag5)
					{
						this.Whisper = new Whisper();
					}
					this.Whisper.MergeFrom(other.Whisper);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x0016A79D File Offset: 0x0016899D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x0016A7A8 File Offset: 0x001689A8
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.whisper_ == null;
						if (flag)
						{
							this.Whisper = new Whisper();
						}
						input.ReadMessage(this.Whisper);
					}
				}
				else
				{
					bool flag2 = this.subscriberId_ == null;
					if (flag2)
					{
						this.SubscriberId = new AccountId();
					}
					input.ReadMessage(this.SubscriberId);
				}
			}
		}

		// Token: 0x04002ADB RID: 10971
		private static readonly MessageParser<WhisperEchoNotification> _parser = new MessageParser<WhisperEchoNotification>(() => new WhisperEchoNotification());

		// Token: 0x04002ADC RID: 10972
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ADD RID: 10973
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04002ADE RID: 10974
		private AccountId subscriberId_;

		// Token: 0x04002ADF RID: 10975
		public const int WhisperFieldNumber = 2;

		// Token: 0x04002AE0 RID: 10976
		private Whisper whisper_;
	}
}
