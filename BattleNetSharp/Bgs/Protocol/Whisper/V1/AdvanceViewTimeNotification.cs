using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x0200039E RID: 926
	public sealed class AdvanceViewTimeNotification : IMessage<AdvanceViewTimeNotification>, IMessage, IEquatable<AdvanceViewTimeNotification>, IDeepCloneable<AdvanceViewTimeNotification>, IBufferMessage
	{
		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x0016AE64 File Offset: 0x00169064
		[DebuggerNonUserCode]
		public static MessageParser<AdvanceViewTimeNotification> Parser
		{
			get
			{
				return AdvanceViewTimeNotification._parser;
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06005DBD RID: 23997 RVA: 0x0016AE7C File Offset: 0x0016907C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperListenerReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x0016AEA0 File Offset: 0x001690A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdvanceViewTimeNotification.Descriptor;
			}
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x0016AEB7 File Offset: 0x001690B7
		[DebuggerNonUserCode]
		public AdvanceViewTimeNotification()
		{
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x0016AEC4 File Offset: 0x001690C4
		[DebuggerNonUserCode]
		public AdvanceViewTimeNotification(AdvanceViewTimeNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.senderId_ = ((other.senderId_ != null) ? other.senderId_.Clone() : null);
			this.viewTime_ = other.viewTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x0016AF3C File Offset: 0x0016913C
		[DebuggerNonUserCode]
		public AdvanceViewTimeNotification Clone()
		{
			return new AdvanceViewTimeNotification(this);
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06005DC2 RID: 24002 RVA: 0x0016AF54 File Offset: 0x00169154
		// (set) Token: 0x06005DC3 RID: 24003 RVA: 0x0016AF6C File Offset: 0x0016916C
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

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06005DC4 RID: 24004 RVA: 0x0016AF78 File Offset: 0x00169178
		// (set) Token: 0x06005DC5 RID: 24005 RVA: 0x0016AF90 File Offset: 0x00169190
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

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06005DC6 RID: 24006 RVA: 0x0016AF9C File Offset: 0x0016919C
		// (set) Token: 0x06005DC7 RID: 24007 RVA: 0x0016AFCD File Offset: 0x001691CD
		[DebuggerNonUserCode]
		public ulong ViewTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong viewTimeDefaultValue;
				if (flag)
				{
					viewTimeDefaultValue = this.viewTime_;
				}
				else
				{
					viewTimeDefaultValue = AdvanceViewTimeNotification.ViewTimeDefaultValue;
				}
				return viewTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.viewTime_ = value;
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06005DC8 RID: 24008 RVA: 0x0016AFE8 File Offset: 0x001691E8
		[DebuggerNonUserCode]
		public bool HasViewTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x0016B005 File Offset: 0x00169205
		[DebuggerNonUserCode]
		public void ClearViewTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x0016B018 File Offset: 0x00169218
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdvanceViewTimeNotification);
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x0016B038 File Offset: 0x00169238
		[DebuggerNonUserCode]
		public bool Equals(AdvanceViewTimeNotification other)
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
							bool flag6 = this.ViewTime != other.ViewTime;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x0016B0CC File Offset: 0x001692CC
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
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				num ^= this.ViewTime.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x0016B154 File Offset: 0x00169354
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x0016B16C File Offset: 0x0016936C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x0016B178 File Offset: 0x00169378
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
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ViewTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x0016B210 File Offset: 0x00169410
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
			bool hasViewTime = this.HasViewTime;
			if (hasViewTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ViewTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x0016B2A0 File Offset: 0x001694A0
		[DebuggerNonUserCode]
		public void MergeFrom(AdvanceViewTimeNotification other)
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
				bool hasViewTime = other.HasViewTime;
				if (hasViewTime)
				{
					this.ViewTime = other.ViewTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x0016B368 File Offset: 0x00169568
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x0016B374 File Offset: 0x00169574
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
							this.ViewTime = input.ReadUInt64();
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

		// Token: 0x04002AEB RID: 10987
		private static readonly MessageParser<AdvanceViewTimeNotification> _parser = new MessageParser<AdvanceViewTimeNotification>(() => new AdvanceViewTimeNotification());

		// Token: 0x04002AEC RID: 10988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AED RID: 10989
		private int _hasBits0;

		// Token: 0x04002AEE RID: 10990
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04002AEF RID: 10991
		private AccountId subscriberId_;

		// Token: 0x04002AF0 RID: 10992
		public const int SenderIdFieldNumber = 2;

		// Token: 0x04002AF1 RID: 10993
		private AccountId senderId_;

		// Token: 0x04002AF2 RID: 10994
		public const int ViewTimeFieldNumber = 3;

		// Token: 0x04002AF3 RID: 10995
		private static readonly ulong ViewTimeDefaultValue = 0UL;

		// Token: 0x04002AF4 RID: 10996
		private ulong viewTime_;
	}
}
