using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x0200039F RID: 927
	public sealed class WhisperUpdatedNotification : IMessage<WhisperUpdatedNotification>, IMessage, IEquatable<WhisperUpdatedNotification>, IDeepCloneable<WhisperUpdatedNotification>, IBufferMessage
	{
		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06005DD5 RID: 24021 RVA: 0x0016B458 File Offset: 0x00169658
		[DebuggerNonUserCode]
		public static MessageParser<WhisperUpdatedNotification> Parser
		{
			get
			{
				return WhisperUpdatedNotification._parser;
			}
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06005DD6 RID: 24022 RVA: 0x0016B470 File Offset: 0x00169670
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06005DD7 RID: 24023 RVA: 0x0016B494 File Offset: 0x00169694
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WhisperUpdatedNotification.Descriptor;
			}
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x0016B4AB File Offset: 0x001696AB
		[DebuggerNonUserCode]
		public WhisperUpdatedNotification()
		{
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x0016B4B8 File Offset: 0x001696B8
		[DebuggerNonUserCode]
		public WhisperUpdatedNotification(WhisperUpdatedNotification other)
			: this()
		{
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.whisper_ = ((other.whisper_ != null) ? other.whisper_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x0016B518 File Offset: 0x00169718
		[DebuggerNonUserCode]
		public WhisperUpdatedNotification Clone()
		{
			return new WhisperUpdatedNotification(this);
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06005DDB RID: 24027 RVA: 0x0016B530 File Offset: 0x00169730
		// (set) Token: 0x06005DDC RID: 24028 RVA: 0x0016B548 File Offset: 0x00169748
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

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06005DDD RID: 24029 RVA: 0x0016B554 File Offset: 0x00169754
		// (set) Token: 0x06005DDE RID: 24030 RVA: 0x0016B56C File Offset: 0x0016976C
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

		// Token: 0x06005DDF RID: 24031 RVA: 0x0016B578 File Offset: 0x00169778
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WhisperUpdatedNotification);
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x0016B598 File Offset: 0x00169798
		[DebuggerNonUserCode]
		public bool Equals(WhisperUpdatedNotification other)
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

		// Token: 0x06005DE1 RID: 24033 RVA: 0x0016B610 File Offset: 0x00169810
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

		// Token: 0x06005DE2 RID: 24034 RVA: 0x0016B67C File Offset: 0x0016987C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x0016B694 File Offset: 0x00169894
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x0016B6A0 File Offset: 0x001698A0
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

		// Token: 0x06005DE5 RID: 24037 RVA: 0x0016B714 File Offset: 0x00169914
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

		// Token: 0x06005DE6 RID: 24038 RVA: 0x0016B788 File Offset: 0x00169988
		[DebuggerNonUserCode]
		public void MergeFrom(WhisperUpdatedNotification other)
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

		// Token: 0x06005DE7 RID: 24039 RVA: 0x0016B835 File Offset: 0x00169A35
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x0016B840 File Offset: 0x00169A40
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

		// Token: 0x04002AF5 RID: 10997
		private static readonly MessageParser<WhisperUpdatedNotification> _parser = new MessageParser<WhisperUpdatedNotification>(() => new WhisperUpdatedNotification());

		// Token: 0x04002AF6 RID: 10998
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AF7 RID: 10999
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04002AF8 RID: 11000
		private AccountId subscriberId_;

		// Token: 0x04002AF9 RID: 11001
		public const int WhisperFieldNumber = 2;

		// Token: 0x04002AFA RID: 11002
		private Whisper whisper_;
	}
}
