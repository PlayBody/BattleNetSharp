using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x0200039D RID: 925
	public sealed class TypingIndicatorNotification : IMessage<TypingIndicatorNotification>, IMessage, IEquatable<TypingIndicatorNotification>, IDeepCloneable<TypingIndicatorNotification>, IBufferMessage
	{
		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x0016A86C File Offset: 0x00168A6C
		[DebuggerNonUserCode]
		public static MessageParser<TypingIndicatorNotification> Parser
		{
			get
			{
				return TypingIndicatorNotification._parser;
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x0016A884 File Offset: 0x00168A84
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06005DA5 RID: 23973 RVA: 0x0016A8A8 File Offset: 0x00168AA8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TypingIndicatorNotification.Descriptor;
			}
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x0016A8BF File Offset: 0x00168ABF
		[DebuggerNonUserCode]
		public TypingIndicatorNotification()
		{
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x0016A8CC File Offset: 0x00168ACC
		[DebuggerNonUserCode]
		public TypingIndicatorNotification(TypingIndicatorNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.senderId_ = ((other.senderId_ != null) ? other.senderId_.Clone() : null);
			this.action_ = other.action_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x0016A944 File Offset: 0x00168B44
		[DebuggerNonUserCode]
		public TypingIndicatorNotification Clone()
		{
			return new TypingIndicatorNotification(this);
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x0016A95C File Offset: 0x00168B5C
		// (set) Token: 0x06005DAA RID: 23978 RVA: 0x0016A974 File Offset: 0x00168B74
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

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06005DAB RID: 23979 RVA: 0x0016A980 File Offset: 0x00168B80
		// (set) Token: 0x06005DAC RID: 23980 RVA: 0x0016A998 File Offset: 0x00168B98
		[DebuggerNonUserCode]
		public AccountId SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06005DAD RID: 23981 RVA: 0x0016A9A4 File Offset: 0x00168BA4
		// (set) Token: 0x06005DAE RID: 23982 RVA: 0x0016A9D5 File Offset: 0x00168BD5
		[DebuggerNonUserCode]
		public TypingIndicator Action
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				TypingIndicator actionDefaultValue;
				if (flag)
				{
					actionDefaultValue = this.action_;
				}
				else
				{
					actionDefaultValue = TypingIndicatorNotification.ActionDefaultValue;
				}
				return actionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.action_ = value;
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06005DAF RID: 23983 RVA: 0x0016A9F0 File Offset: 0x00168BF0
		[DebuggerNonUserCode]
		public bool HasAction
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x0016AA0D File Offset: 0x00168C0D
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x0016AA20 File Offset: 0x00168C20
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TypingIndicatorNotification);
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x0016AA40 File Offset: 0x00168C40
		[DebuggerNonUserCode]
		public bool Equals(TypingIndicatorNotification other)
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
						bool flag5 = !object.Equals(this.SenderId, other.SenderId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Action != other.Action;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x0016AAD4 File Offset: 0x00168CD4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag2 = this.senderId_ != null;
			if (flag2)
			{
				num ^= this.SenderId.GetHashCode();
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num ^= this.Action.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x0016AB64 File Offset: 0x00168D64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x0016AB7C File Offset: 0x00168D7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x0016AB88 File Offset: 0x00168D88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag2 = this.senderId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SenderId);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Action);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x0016AC20 File Offset: 0x00168E20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag2 = this.senderId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SenderId);
			}
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Action);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x0016ACB0 File Offset: 0x00168EB0
		[DebuggerNonUserCode]
		public void MergeFrom(TypingIndicatorNotification other)
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
				bool flag4 = other.senderId_ != null;
				if (flag4)
				{
					bool flag5 = this.senderId_ == null;
					if (flag5)
					{
						this.SenderId = new AccountId();
					}
					this.SenderId.MergeFrom(other.SenderId);
				}
				bool hasAction = other.HasAction;
				if (hasAction)
				{
					this.Action = other.Action;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x0016AD78 File Offset: 0x00168F78
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x0016AD84 File Offset: 0x00168F84
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Action = (TypingIndicator)input.ReadEnum();
						}
					}
					else
					{
						bool flag = this.senderId_ == null;
						if (flag)
						{
							this.SenderId = new AccountId();
						}
						input.ReadMessage(this.SenderId);
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

		// Token: 0x04002AE1 RID: 10977
		private static readonly MessageParser<TypingIndicatorNotification> _parser = new MessageParser<TypingIndicatorNotification>(() => new TypingIndicatorNotification());

		// Token: 0x04002AE2 RID: 10978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AE3 RID: 10979
		private int _hasBits0;

		// Token: 0x04002AE4 RID: 10980
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04002AE5 RID: 10981
		private AccountId subscriberId_;

		// Token: 0x04002AE6 RID: 10982
		public const int SenderIdFieldNumber = 2;

		// Token: 0x04002AE7 RID: 10983
		private AccountId senderId_;

		// Token: 0x04002AE8 RID: 10984
		public const int ActionFieldNumber = 3;

		// Token: 0x04002AE9 RID: 10985
		private static readonly TypingIndicator ActionDefaultValue = TypingIndicator.TypingStart;

		// Token: 0x04002AEA RID: 10986
		private TypingIndicator action_;
	}
}
