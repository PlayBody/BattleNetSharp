using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Server
{
	// Token: 0x020006A5 RID: 1701
	public sealed class MemberRemovedNotification : IMessage<MemberRemovedNotification>, IMessage, IEquatable<MemberRemovedNotification>, IDeepCloneable<MemberRemovedNotification>, IBufferMessage
	{
		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x06009DC2 RID: 40386 RVA: 0x00265988 File Offset: 0x00263B88
		[DebuggerNonUserCode]
		public static MessageParser<MemberRemovedNotification> Parser
		{
			get
			{
				return MemberRemovedNotification._parser;
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x002659A0 File Offset: 0x00263BA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelListenerReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x06009DC4 RID: 40388 RVA: 0x002659C4 File Offset: 0x00263BC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberRemovedNotification.Descriptor;
			}
		}

		// Token: 0x06009DC5 RID: 40389 RVA: 0x002659DB File Offset: 0x00263BDB
		[DebuggerNonUserCode]
		public MemberRemovedNotification()
		{
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x002659FC File Offset: 0x00263BFC
		[DebuggerNonUserCode]
		public MemberRemovedNotification(MemberRemovedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.reason_ = other.reason_;
			this.memberId_ = other.memberId_.Clone();
			this.memberAccountId_ = other.memberAccountId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DC7 RID: 40391 RVA: 0x00265A94 File Offset: 0x00263C94
		[DebuggerNonUserCode]
		public MemberRemovedNotification Clone()
		{
			return new MemberRemovedNotification(this);
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x06009DC8 RID: 40392 RVA: 0x00265AAC File Offset: 0x00263CAC
		// (set) Token: 0x06009DC9 RID: 40393 RVA: 0x00265AC4 File Offset: 0x00263CC4
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

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x06009DCA RID: 40394 RVA: 0x00265AD0 File Offset: 0x00263CD0
		// (set) Token: 0x06009DCB RID: 40395 RVA: 0x00265AE8 File Offset: 0x00263CE8
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

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x06009DCC RID: 40396 RVA: 0x00265AF4 File Offset: 0x00263CF4
		// (set) Token: 0x06009DCD RID: 40397 RVA: 0x00265B25 File Offset: 0x00263D25
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

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06009DCE RID: 40398 RVA: 0x00265B40 File Offset: 0x00263D40
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009DCF RID: 40399 RVA: 0x00265B5D File Offset: 0x00263D5D
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x00265B70 File Offset: 0x00263D70
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> MemberId
		{
			get
			{
				return this.memberId_;
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x06009DD1 RID: 40401 RVA: 0x00265B88 File Offset: 0x00263D88
		[DebuggerNonUserCode]
		public RepeatedField<ulong> MemberAccountId
		{
			get
			{
				return this.memberAccountId_;
			}
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x00265BA0 File Offset: 0x00263DA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberRemovedNotification);
		}

		// Token: 0x06009DD3 RID: 40403 RVA: 0x00265BC0 File Offset: 0x00263DC0
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.memberId_.Equals(other.memberId_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.memberAccountId_.Equals(other.memberAccountId_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009DD4 RID: 40404 RVA: 0x00265C98 File Offset: 0x00263E98
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			num ^= this.memberId_.GetHashCode();
			num ^= this.memberAccountId_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DD5 RID: 40405 RVA: 0x00265D3C File Offset: 0x00263F3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x00265D54 File Offset: 0x00263F54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x00265D60 File Offset: 0x00263F60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ChannelId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Reason);
			}
			this.memberId_.WriteTo(ref output, MemberRemovedNotification._repeated_memberId_codec);
			this.memberAccountId_.WriteTo(ref output, MemberRemovedNotification._repeated_memberAccountId_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x00265E1C File Offset: 0x0026401C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			num += this.memberId_.CalculateSize(MemberRemovedNotification._repeated_memberId_codec);
			num += this.memberAccountId_.CalculateSize(MemberRemovedNotification._repeated_memberAccountId_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x00265ED4 File Offset: 0x002640D4
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
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this.memberId_.Add(other.memberId_);
				this.memberAccountId_.Add(other.memberAccountId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x00265FC0 File Offset: 0x002641C0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DDB RID: 40411 RVA: 0x00265FCC File Offset: 0x002641CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 32U)
				{
					if (num3 != 10U)
					{
						if (num3 != 26U)
						{
							if (num3 != 32U)
							{
								goto IL_0046;
							}
							this.Reason = input.ReadUInt32();
						}
						else
						{
							bool flag = this.channelId_ == null;
							if (flag)
							{
								this.ChannelId = new ChannelId();
							}
							input.ReadMessage(this.ChannelId);
						}
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
				else if (num3 != 42U)
				{
					if (num3 != 48U && num3 != 50U)
					{
						goto IL_0046;
					}
					this.memberAccountId_.AddEntriesFrom(ref input, MemberRemovedNotification._repeated_memberAccountId_codec);
				}
				else
				{
					this.memberId_.AddEntriesFrom(ref input, MemberRemovedNotification._repeated_memberId_codec);
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400472D RID: 18221
		private static readonly MessageParser<MemberRemovedNotification> _parser = new MessageParser<MemberRemovedNotification>(() => new MemberRemovedNotification());

		// Token: 0x0400472E RID: 18222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400472F RID: 18223
		private int _hasBits0;

		// Token: 0x04004730 RID: 18224
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004731 RID: 18225
		private GameAccountHandle agentId_;

		// Token: 0x04004732 RID: 18226
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004733 RID: 18227
		private ChannelId channelId_;

		// Token: 0x04004734 RID: 18228
		public const int ReasonFieldNumber = 4;

		// Token: 0x04004735 RID: 18229
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04004736 RID: 18230
		private uint reason_;

		// Token: 0x04004737 RID: 18231
		public const int MemberIdFieldNumber = 5;

		// Token: 0x04004738 RID: 18232
		private static readonly FieldCodec<GameAccountHandle> _repeated_memberId_codec = FieldCodec.ForMessage<GameAccountHandle>(42U, GameAccountHandle.Parser);

		// Token: 0x04004739 RID: 18233
		private readonly RepeatedField<GameAccountHandle> memberId_ = new RepeatedField<GameAccountHandle>();

		// Token: 0x0400473A RID: 18234
		public const int MemberAccountIdFieldNumber = 6;

		// Token: 0x0400473B RID: 18235
		private static readonly FieldCodec<ulong> _repeated_memberAccountId_codec = FieldCodec.ForUInt64(48U);

		// Token: 0x0400473C RID: 18236
		private readonly RepeatedField<ulong> memberAccountId_ = new RepeatedField<ulong>();
	}
}
