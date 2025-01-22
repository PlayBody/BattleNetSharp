using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006DD RID: 1757
	public sealed class JoinNotification : IMessage<JoinNotification>, IMessage, IEquatable<JoinNotification>, IDeepCloneable<JoinNotification>, IBufferMessage
	{
		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600A1F8 RID: 41464 RVA: 0x00276AD0 File Offset: 0x00274CD0
		[DebuggerNonUserCode]
		public static MessageParser<JoinNotification> Parser
		{
			get
			{
				return JoinNotification._parser;
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x00276AE8 File Offset: 0x00274CE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600A1FA RID: 41466 RVA: 0x00276B0C File Offset: 0x00274D0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinNotification.Descriptor;
			}
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x00276B23 File Offset: 0x00274D23
		[DebuggerNonUserCode]
		public JoinNotification()
		{
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x00276B38 File Offset: 0x00274D38
		[DebuggerNonUserCode]
		public JoinNotification(JoinNotification other)
			: this()
		{
			this.self_ = ((other.self_ != null) ? other.self_.Clone() : null);
			this.member_ = other.member_.Clone();
			this.channelState_ = ((other.channelState_ != null) ? other.channelState_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x00276BFC File Offset: 0x00274DFC
		[DebuggerNonUserCode]
		public JoinNotification Clone()
		{
			return new JoinNotification(this);
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600A1FE RID: 41470 RVA: 0x00276C14 File Offset: 0x00274E14
		// (set) Token: 0x0600A1FF RID: 41471 RVA: 0x00276C2C File Offset: 0x00274E2C
		[DebuggerNonUserCode]
		public Member Self
		{
			get
			{
				return this.self_;
			}
			set
			{
				this.self_ = value;
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600A200 RID: 41472 RVA: 0x00276C38 File Offset: 0x00274E38
		[DebuggerNonUserCode]
		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x00276C50 File Offset: 0x00274E50
		// (set) Token: 0x0600A202 RID: 41474 RVA: 0x00276C68 File Offset: 0x00274E68
		[DebuggerNonUserCode]
		public ChannelState ChannelState
		{
			get
			{
				return this.channelState_;
			}
			set
			{
				this.channelState_ = value;
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x00276C74 File Offset: 0x00274E74
		// (set) Token: 0x0600A204 RID: 41476 RVA: 0x00276C8C File Offset: 0x00274E8C
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x00276C98 File Offset: 0x00274E98
		// (set) Token: 0x0600A206 RID: 41478 RVA: 0x00276CB0 File Offset: 0x00274EB0
		[DebuggerNonUserCode]
		public Identity Subscriber
		{
			get
			{
				return this.subscriber_;
			}
			set
			{
				this.subscriber_ = value;
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600A207 RID: 41479 RVA: 0x00276CBC File Offset: 0x00274EBC
		// (set) Token: 0x0600A208 RID: 41480 RVA: 0x00276CD4 File Offset: 0x00274ED4
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

		// Token: 0x0600A209 RID: 41481 RVA: 0x00276CE0 File Offset: 0x00274EE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinNotification);
		}

		// Token: 0x0600A20A RID: 41482 RVA: 0x00276D00 File Offset: 0x00274F00
		[DebuggerNonUserCode]
		public bool Equals(JoinNotification other)
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
					bool flag4 = !object.Equals(this.Self, other.Self);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.member_.Equals(other.member_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ChannelState, other.ChannelState);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.ChannelId, other.ChannelId);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Subscriber, other.Subscriber);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.SubscriberId, other.SubscriberId);
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x00276DFC File Offset: 0x00274FFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.self_ != null;
			if (flag)
			{
				num ^= this.Self.GetHashCode();
			}
			num ^= this.member_.GetHashCode();
			bool flag2 = this.channelState_ != null;
			if (flag2)
			{
				num ^= this.ChannelState.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool flag5 = this.subscriberId_ != null;
			if (flag5)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x00276ECC File Offset: 0x002750CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x00276EE4 File Offset: 0x002750E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x00276EF0 File Offset: 0x002750F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.self_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Self);
			}
			this.member_.WriteTo(ref output, JoinNotification._repeated_member_codec);
			bool flag2 = this.channelState_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelState);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Subscriber);
			}
			bool flag5 = this.subscriberId_ != null;
			if (flag5)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x00276FEC File Offset: 0x002751EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.self_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Self);
			}
			num += this.member_.CalculateSize(JoinNotification._repeated_member_codec);
			bool flag2 = this.channelState_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelState);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag4 = this.subscriber_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool flag5 = this.subscriberId_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag6 = this._unknownFields != null;
			if (flag6)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x002770D4 File Offset: 0x002752D4
		[DebuggerNonUserCode]
		public void MergeFrom(JoinNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.self_ != null;
				if (flag2)
				{
					bool flag3 = this.self_ == null;
					if (flag3)
					{
						this.Self = new Member();
					}
					this.Self.MergeFrom(other.Self);
				}
				this.member_.Add(other.member_);
				bool flag4 = other.channelState_ != null;
				if (flag4)
				{
					bool flag5 = this.channelState_ == null;
					if (flag5)
					{
						this.ChannelState = new ChannelState();
					}
					this.ChannelState.MergeFrom(other.ChannelState);
				}
				bool flag6 = other.channelId_ != null;
				if (flag6)
				{
					bool flag7 = this.channelId_ == null;
					if (flag7)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag8 = other.subscriber_ != null;
				if (flag8)
				{
					bool flag9 = this.subscriber_ == null;
					if (flag9)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				bool flag10 = other.subscriberId_ != null;
				if (flag10)
				{
					bool flag11 = this.subscriberId_ == null;
					if (flag11)
					{
						this.SubscriberId = new AccountId();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x00277253 File Offset: 0x00275453
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x00277260 File Offset: 0x00275460
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0043;
							}
							bool flag = this.channelState_ == null;
							if (flag)
							{
								this.ChannelState = new ChannelState();
							}
							input.ReadMessage(this.ChannelState);
						}
						else
						{
							this.member_.AddEntriesFrom(ref input, JoinNotification._repeated_member_codec);
						}
					}
					else
					{
						bool flag2 = this.self_ == null;
						if (flag2)
						{
							this.Self = new Member();
						}
						input.ReadMessage(this.Self);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0043;
						}
						bool flag3 = this.subscriberId_ == null;
						if (flag3)
						{
							this.SubscriberId = new AccountId();
						}
						input.ReadMessage(this.SubscriberId);
					}
					else
					{
						bool flag4 = this.subscriber_ == null;
						if (flag4)
						{
							this.Subscriber = new Identity();
						}
						input.ReadMessage(this.Subscriber);
					}
				}
				else
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
				continue;
				IL_0043:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048F2 RID: 18674
		private static readonly MessageParser<JoinNotification> _parser = new MessageParser<JoinNotification>(() => new JoinNotification());

		// Token: 0x040048F3 RID: 18675
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048F4 RID: 18676
		public const int SelfFieldNumber = 1;

		// Token: 0x040048F5 RID: 18677
		private Member self_;

		// Token: 0x040048F6 RID: 18678
		public const int MemberFieldNumber = 2;

		// Token: 0x040048F7 RID: 18679
		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(18U, Bgs.Protocol.Channel.V1.Member.Parser);

		// Token: 0x040048F8 RID: 18680
		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();

		// Token: 0x040048F9 RID: 18681
		public const int ChannelStateFieldNumber = 3;

		// Token: 0x040048FA RID: 18682
		private ChannelState channelState_;

		// Token: 0x040048FB RID: 18683
		public const int ChannelIdFieldNumber = 4;

		// Token: 0x040048FC RID: 18684
		private ChannelId channelId_;

		// Token: 0x040048FD RID: 18685
		public const int SubscriberFieldNumber = 5;

		// Token: 0x040048FE RID: 18686
		private Identity subscriber_;

		// Token: 0x040048FF RID: 18687
		public const int SubscriberIdFieldNumber = 6;

		// Token: 0x04004900 RID: 18688
		private AccountId subscriberId_;
	}
}
