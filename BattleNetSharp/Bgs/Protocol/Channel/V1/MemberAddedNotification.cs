using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006DE RID: 1758
	public sealed class MemberAddedNotification : IMessage<MemberAddedNotification>, IMessage, IEquatable<MemberAddedNotification>, IDeepCloneable<MemberAddedNotification>, IBufferMessage
	{
		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600A214 RID: 41492 RVA: 0x00277408 File Offset: 0x00275608
		[DebuggerNonUserCode]
		public static MessageParser<MemberAddedNotification> Parser
		{
			get
			{
				return MemberAddedNotification._parser;
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x00277420 File Offset: 0x00275620
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600A216 RID: 41494 RVA: 0x00277444 File Offset: 0x00275644
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAddedNotification.Descriptor;
			}
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x0027745B File Offset: 0x0027565B
		[DebuggerNonUserCode]
		public MemberAddedNotification()
		{
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x00277468 File Offset: 0x00275668
		[DebuggerNonUserCode]
		public MemberAddedNotification(MemberAddedNotification other)
			: this()
		{
			this.member_ = ((other.member_ != null) ? other.member_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.subscriber_ = ((other.subscriber_ != null) ? other.subscriber_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x002774E4 File Offset: 0x002756E4
		[DebuggerNonUserCode]
		public MemberAddedNotification Clone()
		{
			return new MemberAddedNotification(this);
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600A21A RID: 41498 RVA: 0x002774FC File Offset: 0x002756FC
		// (set) Token: 0x0600A21B RID: 41499 RVA: 0x00277514 File Offset: 0x00275714
		[DebuggerNonUserCode]
		public Member Member
		{
			get
			{
				return this.member_;
			}
			set
			{
				this.member_ = value;
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600A21C RID: 41500 RVA: 0x00277520 File Offset: 0x00275720
		// (set) Token: 0x0600A21D RID: 41501 RVA: 0x00277538 File Offset: 0x00275738
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

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600A21E RID: 41502 RVA: 0x00277544 File Offset: 0x00275744
		// (set) Token: 0x0600A21F RID: 41503 RVA: 0x0027755C File Offset: 0x0027575C
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

		// Token: 0x0600A220 RID: 41504 RVA: 0x00277568 File Offset: 0x00275768
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAddedNotification);
		}

		// Token: 0x0600A221 RID: 41505 RVA: 0x00277588 File Offset: 0x00275788
		[DebuggerNonUserCode]
		public bool Equals(MemberAddedNotification other)
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
					bool flag4 = !object.Equals(this.Member, other.Member);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Subscriber, other.Subscriber);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x00277620 File Offset: 0x00275820
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.member_ != null;
			if (flag)
			{
				num ^= this.Member.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag3 = this.subscriber_ != null;
			if (flag3)
			{
				num ^= this.Subscriber.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x002776A8 File Offset: 0x002758A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x002776C0 File Offset: 0x002758C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x002776CC File Offset: 0x002758CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.member_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Member);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool flag3 = this.subscriber_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Subscriber);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x00277768 File Offset: 0x00275968
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.member_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Member);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag3 = this.subscriber_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Subscriber);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x002777FC File Offset: 0x002759FC
		[DebuggerNonUserCode]
		public void MergeFrom(MemberAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.member_ != null;
				if (flag2)
				{
					bool flag3 = this.member_ == null;
					if (flag3)
					{
						this.Member = new Member();
					}
					this.Member.MergeFrom(other.Member);
				}
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag6 = other.subscriber_ != null;
				if (flag6)
				{
					bool flag7 = this.subscriber_ == null;
					if (flag7)
					{
						this.Subscriber = new Identity();
					}
					this.Subscriber.MergeFrom(other.Subscriber);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x002778E9 File Offset: 0x00275AE9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x002778F4 File Offset: 0x00275AF4
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
							bool flag = this.subscriber_ == null;
							if (flag)
							{
								this.Subscriber = new Identity();
							}
							input.ReadMessage(this.Subscriber);
						}
					}
					else
					{
						bool flag2 = this.channelId_ == null;
						if (flag2)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag3 = this.member_ == null;
					if (flag3)
					{
						this.Member = new Member();
					}
					input.ReadMessage(this.Member);
				}
			}
		}

		// Token: 0x04004901 RID: 18689
		private static readonly MessageParser<MemberAddedNotification> _parser = new MessageParser<MemberAddedNotification>(() => new MemberAddedNotification());

		// Token: 0x04004902 RID: 18690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004903 RID: 18691
		public const int MemberFieldNumber = 1;

		// Token: 0x04004904 RID: 18692
		private Member member_;

		// Token: 0x04004905 RID: 18693
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x04004906 RID: 18694
		private ChannelId channelId_;

		// Token: 0x04004907 RID: 18695
		public const int SubscriberFieldNumber = 3;

		// Token: 0x04004908 RID: 18696
		private Identity subscriber_;
	}
}
