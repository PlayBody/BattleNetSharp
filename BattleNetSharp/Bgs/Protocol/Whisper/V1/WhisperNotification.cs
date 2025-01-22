using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x0200039B RID: 923
	public sealed class WhisperNotification : IMessage<WhisperNotification>, IMessage, IEquatable<WhisperNotification>, IDeepCloneable<WhisperNotification>, IBufferMessage
	{
		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06005D75 RID: 23925 RVA: 0x00169DF8 File Offset: 0x00167FF8
		[DebuggerNonUserCode]
		public static MessageParser<WhisperNotification> Parser
		{
			get
			{
				return WhisperNotification._parser;
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06005D76 RID: 23926 RVA: 0x00169E10 File Offset: 0x00168010
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06005D77 RID: 23927 RVA: 0x00169E34 File Offset: 0x00168034
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WhisperNotification.Descriptor;
			}
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x00169E4B File Offset: 0x0016804B
		[DebuggerNonUserCode]
		public WhisperNotification()
		{
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x00169E58 File Offset: 0x00168058
		[DebuggerNonUserCode]
		public WhisperNotification(WhisperNotification other)
			: this()
		{
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.whisper_ = ((other.whisper_ != null) ? other.whisper_.Clone() : null);
			this.senderBattleTag_ = other.senderBattleTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x00169EC4 File Offset: 0x001680C4
		[DebuggerNonUserCode]
		public WhisperNotification Clone()
		{
			return new WhisperNotification(this);
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06005D7B RID: 23931 RVA: 0x00169EDC File Offset: 0x001680DC
		// (set) Token: 0x06005D7C RID: 23932 RVA: 0x00169EF4 File Offset: 0x001680F4
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

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06005D7D RID: 23933 RVA: 0x00169F00 File Offset: 0x00168100
		// (set) Token: 0x06005D7E RID: 23934 RVA: 0x00169F18 File Offset: 0x00168118
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

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06005D7F RID: 23935 RVA: 0x00169F24 File Offset: 0x00168124
		// (set) Token: 0x06005D80 RID: 23936 RVA: 0x00169F45 File Offset: 0x00168145
		[DebuggerNonUserCode]
		public string SenderBattleTag
		{
			get
			{
				return this.senderBattleTag_ ?? WhisperNotification.SenderBattleTagDefaultValue;
			}
			set
			{
				this.senderBattleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06005D81 RID: 23937 RVA: 0x00169F5C File Offset: 0x0016815C
		[DebuggerNonUserCode]
		public bool HasSenderBattleTag
		{
			get
			{
				return this.senderBattleTag_ != null;
			}
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x00169F77 File Offset: 0x00168177
		[DebuggerNonUserCode]
		public void ClearSenderBattleTag()
		{
			this.senderBattleTag_ = null;
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x00169F84 File Offset: 0x00168184
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WhisperNotification);
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x00169FA4 File Offset: 0x001681A4
		[DebuggerNonUserCode]
		public bool Equals(WhisperNotification other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SenderBattleTag != other.SenderBattleTag;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x0016A038 File Offset: 0x00168238
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
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				num ^= this.SenderBattleTag.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x0016A0BC File Offset: 0x001682BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x0016A0D4 File Offset: 0x001682D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x0016A0E0 File Offset: 0x001682E0
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
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SenderBattleTag);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x0016A178 File Offset: 0x00168378
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
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderBattleTag);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x0016A208 File Offset: 0x00168408
		[DebuggerNonUserCode]
		public void MergeFrom(WhisperNotification other)
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
				bool hasSenderBattleTag = other.HasSenderBattleTag;
				if (hasSenderBattleTag)
				{
					this.SenderBattleTag = other.SenderBattleTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x0016A2D0 File Offset: 0x001684D0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x0016A2DC File Offset: 0x001684DC
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SenderBattleTag = input.ReadString();
						}
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

		// Token: 0x04002AD2 RID: 10962
		private static readonly MessageParser<WhisperNotification> _parser = new MessageParser<WhisperNotification>(() => new WhisperNotification());

		// Token: 0x04002AD3 RID: 10963
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AD4 RID: 10964
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04002AD5 RID: 10965
		private AccountId subscriberId_;

		// Token: 0x04002AD6 RID: 10966
		public const int WhisperFieldNumber = 2;

		// Token: 0x04002AD7 RID: 10967
		private Whisper whisper_;

		// Token: 0x04002AD8 RID: 10968
		public const int SenderBattleTagFieldNumber = 3;

		// Token: 0x04002AD9 RID: 10969
		private static readonly string SenderBattleTagDefaultValue = "";

		// Token: 0x04002ADA RID: 10970
		private string senderBattleTag_;
	}
}
