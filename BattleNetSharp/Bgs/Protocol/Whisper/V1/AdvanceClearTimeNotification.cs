using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A0 RID: 928
	public sealed class AdvanceClearTimeNotification : IMessage<AdvanceClearTimeNotification>, IMessage, IEquatable<AdvanceClearTimeNotification>, IDeepCloneable<AdvanceClearTimeNotification>, IBufferMessage
	{
		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06005DEA RID: 24042 RVA: 0x0016B904 File Offset: 0x00169B04
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceClearTimeNotification> Parser
		{
			get
			{
				return AdvanceClearTimeNotification._parser;
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x0016B91C File Offset: 0x00169B1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06005DEC RID: 24044 RVA: 0x0016B940 File Offset: 0x00169B40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceClearTimeNotification.Descriptor;
			}
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x0016B957 File Offset: 0x00169B57
		[DebuggerNonUserCode]
		public AdvanceClearTimeNotification()
		{
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x0016B964 File Offset: 0x00169B64
		[DebuggerNonUserCode]
		public AdvanceClearTimeNotification(AdvanceClearTimeNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.senderId_ = ((other.senderId_ != null) ? other.senderId_.Clone() : null);
			this.clearTime_ = other.clearTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x0016B9DC File Offset: 0x00169BDC
		[DebuggerNonUserCode]
		public AdvanceClearTimeNotification Clone()
		{
			return new AdvanceClearTimeNotification(this);
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x0016B9F4 File Offset: 0x00169BF4
		// (set) Token: 0x06005DF1 RID: 24049 RVA: 0x0016BA0C File Offset: 0x00169C0C
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

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x06005DF2 RID: 24050 RVA: 0x0016BA18 File Offset: 0x00169C18
		// (set) Token: 0x06005DF3 RID: 24051 RVA: 0x0016BA30 File Offset: 0x00169C30
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

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06005DF4 RID: 24052 RVA: 0x0016BA3C File Offset: 0x00169C3C
		// (set) Token: 0x06005DF5 RID: 24053 RVA: 0x0016BA6D File Offset: 0x00169C6D
		[DebuggerNonUserCode]
		public ulong ClearTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clearTimeDefaultValue;
				if (flag)
				{
					clearTimeDefaultValue = this.clearTime_;
				}
				else
				{
					clearTimeDefaultValue = AdvanceClearTimeNotification.ClearTimeDefaultValue;
				}
				return clearTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clearTime_ = value;
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x0016BA88 File Offset: 0x00169C88
		[DebuggerNonUserCode]
		public bool HasClearTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x0016BAA5 File Offset: 0x00169CA5
		[DebuggerNonUserCode]
		public void ClearClearTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x0016BAB8 File Offset: 0x00169CB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceClearTimeNotification);
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x0016BAD8 File Offset: 0x00169CD8
		[DebuggerNonUserCode]
		public bool Equals(AdvanceClearTimeNotification other)
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
							bool flag6 = this.ClearTime != other.ClearTime;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x0016BB6C File Offset: 0x00169D6C
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
			bool hasClearTime = this.HasClearTime;
			if (hasClearTime)
			{
				num ^= this.ClearTime.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x0016BBF4 File Offset: 0x00169DF4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x0016BC0C File Offset: 0x00169E0C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x0016BC18 File Offset: 0x00169E18
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
			bool hasClearTime = this.HasClearTime;
			if (hasClearTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ClearTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x0016BCB0 File Offset: 0x00169EB0
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
			bool hasClearTime = this.HasClearTime;
			if (hasClearTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClearTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x0016BD40 File Offset: 0x00169F40
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceClearTimeNotification other)
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
				bool hasClearTime = other.HasClearTime;
				if (hasClearTime)
				{
					this.ClearTime = other.ClearTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x0016BE08 File Offset: 0x0016A008
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x0016BE14 File Offset: 0x0016A014
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
							this.ClearTime = input.ReadUInt64();
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

		// Token: 0x04002AFB RID: 11003
		private static readonly MessageParser<AdvanceClearTimeNotification> _parser = new MessageParser<AdvanceClearTimeNotification>(() => new AdvanceClearTimeNotification());

		// Token: 0x04002AFC RID: 11004
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AFD RID: 11005
		private int _hasBits0;

		// Token: 0x04002AFE RID: 11006
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04002AFF RID: 11007
		private AccountId subscriberId_;

		// Token: 0x04002B00 RID: 11008
		public const int SenderIdFieldNumber = 2;

		// Token: 0x04002B01 RID: 11009
		private AccountId senderId_;

		// Token: 0x04002B02 RID: 11010
		public const int ClearTimeFieldNumber = 3;

		// Token: 0x04002B03 RID: 11011
		private static readonly ulong ClearTimeDefaultValue = 0UL;

		// Token: 0x04002B04 RID: 11012
		private ulong clearTime_;
	}
}
