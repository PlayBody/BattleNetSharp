using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000678 RID: 1656
	public sealed class MemberRemovedNotification : IMessage<MemberRemovedNotification>, IMessage, IEquatable<MemberRemovedNotification>, IDeepCloneable<MemberRemovedNotification>, IBufferMessage
	{
		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x060099AF RID: 39343 RVA: 0x00253820 File Offset: 0x00251A20
		[DebuggerNonUserCode]
		public static MessageParser<MemberRemovedNotification> Parser
		{
			get
			{
				return MemberRemovedNotification._parser;
			}
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x00253838 File Offset: 0x00251A38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x060099B1 RID: 39345 RVA: 0x0025385C File Offset: 0x00251A5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRemovedNotification.Descriptor;
			}
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x00253873 File Offset: 0x00251A73
		[DebuggerNonUserCode]
		public MemberRemovedNotification()
		{
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x00253880 File Offset: 0x00251A80
		[DebuggerNonUserCode]
		public MemberRemovedNotification(MemberRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x00253930 File Offset: 0x00251B30
		[DebuggerNonUserCode]
		public MemberRemovedNotification Clone()
		{
			return new MemberRemovedNotification(this);
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x060099B5 RID: 39349 RVA: 0x00253948 File Offset: 0x00251B48
		// (set) Token: 0x060099B6 RID: 39350 RVA: 0x00253960 File Offset: 0x00251B60
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x060099B7 RID: 39351 RVA: 0x0025396C File Offset: 0x00251B6C
		// (set) Token: 0x060099B8 RID: 39352 RVA: 0x00253984 File Offset: 0x00251B84
		[DebuggerNonUserCode]
		public GameAccountHandle SubscriberId
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

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x060099B9 RID: 39353 RVA: 0x00253990 File Offset: 0x00251B90
		// (set) Token: 0x060099BA RID: 39354 RVA: 0x002539A8 File Offset: 0x00251BA8
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

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x060099BB RID: 39355 RVA: 0x002539B4 File Offset: 0x00251BB4
		// (set) Token: 0x060099BC RID: 39356 RVA: 0x002539CC File Offset: 0x00251BCC
		[DebuggerNonUserCode]
		public GameAccountHandle MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x060099BD RID: 39357 RVA: 0x002539D8 File Offset: 0x00251BD8
		// (set) Token: 0x060099BE RID: 39358 RVA: 0x00253A09 File Offset: 0x00251C09
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = MemberRemovedNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x060099BF RID: 39359 RVA: 0x00253A24 File Offset: 0x00251C24
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x00253A41 File Offset: 0x00251C41
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x00253A54 File Offset: 0x00251C54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRemovedNotification);
		}

		// Token: 0x060099C2 RID: 39362 RVA: 0x00253A74 File Offset: 0x00251C74
		[DebuggerNonUserCode]
		public bool Equals(MemberRemovedNotification other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SubscriberId, other.SubscriberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ChannelId, other.ChannelId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.MemberId, other.MemberId);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Reason != other.Reason;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060099C3 RID: 39363 RVA: 0x00253B4C File Offset: 0x00251D4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag4 = this.memberId_ != null;
			if (flag4)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x00253C10 File Offset: 0x00251E10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099C5 RID: 39365 RVA: 0x00253C28 File Offset: 0x00251E28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x00253C34 File Offset: 0x00251E34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool flag4 = this.memberId_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MemberId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Reason);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x00253D18 File Offset: 0x00251F18
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.subscriberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			bool flag3 = this.channelId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag4 = this.memberId_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099C8 RID: 39368 RVA: 0x00253DEC File Offset: 0x00251FEC
		[DebuggerNonUserCode]
		public void MergeFrom(MemberRemovedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.subscriberId_ != null;
				if (flag4)
				{
					bool flag5 = this.subscriberId_ == null;
					if (flag5)
					{
						this.SubscriberId = new GameAccountHandle();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
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
				bool flag8 = other.memberId_ != null;
				if (flag8)
				{
					bool flag9 = this.memberId_ == null;
					if (flag9)
					{
						this.MemberId = new GameAccountHandle();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060099C9 RID: 39369 RVA: 0x00253F34 File Offset: 0x00252134
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x00253F40 File Offset: 0x00252140
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_003C;
						}
						bool flag = this.subscriberId_ == null;
						if (flag)
						{
							this.SubscriberId = new GameAccountHandle();
						}
						input.ReadMessage(this.SubscriberId);
					}
					else
					{
						bool flag2 = this.agentId_ == null;
						if (flag2)
						{
							this.AgentId = new GameAccountHandle();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_003C;
						}
						this.Reason = input.ReadUInt32();
					}
					else
					{
						bool flag3 = this.memberId_ == null;
						if (flag3)
						{
							this.MemberId = new GameAccountHandle();
						}
						input.ReadMessage(this.MemberId);
					}
				}
				else
				{
					bool flag4 = this.channelId_ == null;
					if (flag4)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004517 RID: 17687
		private static readonly MessageParser<MemberRemovedNotification> _parser = new MessageParser<MemberRemovedNotification>(() => new MemberRemovedNotification());

		// Token: 0x04004518 RID: 17688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004519 RID: 17689
		private int _hasBits0;

		// Token: 0x0400451A RID: 17690
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400451B RID: 17691
		private GameAccountHandle agentId_;

		// Token: 0x0400451C RID: 17692
		public const int SubscriberIdFieldNumber = 2;

		// Token: 0x0400451D RID: 17693
		private GameAccountHandle subscriberId_;

		// Token: 0x0400451E RID: 17694
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x0400451F RID: 17695
		private ChannelId channelId_;

		// Token: 0x04004520 RID: 17696
		public const int MemberIdFieldNumber = 4;

		// Token: 0x04004521 RID: 17697
		private GameAccountHandle memberId_;

		// Token: 0x04004522 RID: 17698
		public const int ReasonFieldNumber = 5;

		// Token: 0x04004523 RID: 17699
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04004524 RID: 17700
		private uint reason_;
	}
}
