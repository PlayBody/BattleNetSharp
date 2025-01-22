using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Server
{
	// Token: 0x020006A4 RID: 1700
	public sealed class MemberAddedNotification : IMessage<MemberAddedNotification>, IMessage, IEquatable<MemberAddedNotification>, IDeepCloneable<MemberAddedNotification>, IBufferMessage
	{
		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x06009DAC RID: 40364 RVA: 0x00265418 File Offset: 0x00263618
		[DebuggerNonUserCode]
		public static MessageParser<MemberAddedNotification> Parser
		{
			get
			{
				return MemberAddedNotification._parser;
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x06009DAD RID: 40365 RVA: 0x00265430 File Offset: 0x00263630
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x06009DAE RID: 40366 RVA: 0x00265454 File Offset: 0x00263654
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAddedNotification.Descriptor;
			}
		}

		// Token: 0x06009DAF RID: 40367 RVA: 0x0026546B File Offset: 0x0026366B
		[DebuggerNonUserCode]
		public MemberAddedNotification()
		{
		}

		// Token: 0x06009DB0 RID: 40368 RVA: 0x00265480 File Offset: 0x00263680
		[DebuggerNonUserCode]
		public MemberAddedNotification(MemberAddedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.member_ = other.member_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x002654F0 File Offset: 0x002636F0
		[DebuggerNonUserCode]
		public MemberAddedNotification Clone()
		{
			return new MemberAddedNotification(this);
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x06009DB2 RID: 40370 RVA: 0x00265508 File Offset: 0x00263708
		// (set) Token: 0x06009DB3 RID: 40371 RVA: 0x00265520 File Offset: 0x00263720
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

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06009DB4 RID: 40372 RVA: 0x0026552C File Offset: 0x0026372C
		// (set) Token: 0x06009DB5 RID: 40373 RVA: 0x00265544 File Offset: 0x00263744
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

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x00265550 File Offset: 0x00263750
		[DebuggerNonUserCode]
		public RepeatedField<Member> Member
		{
			get
			{
				return this.member_;
			}
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x00265568 File Offset: 0x00263768
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAddedNotification);
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x00265588 File Offset: 0x00263788
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
							bool flag6 = !this.member_.Equals(other.member_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009DB9 RID: 40377 RVA: 0x00265620 File Offset: 0x00263820
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
			num ^= this.member_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x00265698 File Offset: 0x00263898
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DBB RID: 40379 RVA: 0x002656B0 File Offset: 0x002638B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DBC RID: 40380 RVA: 0x002656BC File Offset: 0x002638BC
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
			this.member_.WriteTo(ref output, MemberAddedNotification._repeated_member_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x00265744 File Offset: 0x00263944
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
			num += this.member_.CalculateSize(MemberAddedNotification._repeated_member_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x002657CC File Offset: 0x002639CC
		[DebuggerNonUserCode]
		public void MergeFrom(MemberAddedNotification other)
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
				this.member_.Add(other.member_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x0026588B File Offset: 0x00263A8B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x00265898 File Offset: 0x00263A98
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
					if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.member_.AddEntriesFrom(ref input, MemberAddedNotification._repeated_member_codec);
						}
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
		}

		// Token: 0x04004724 RID: 18212
		private static readonly MessageParser<MemberAddedNotification> _parser = new MessageParser<MemberAddedNotification>(() => new MemberAddedNotification());

		// Token: 0x04004725 RID: 18213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004726 RID: 18214
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004727 RID: 18215
		private GameAccountHandle agentId_;

		// Token: 0x04004728 RID: 18216
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004729 RID: 18217
		private ChannelId channelId_;

		// Token: 0x0400472A RID: 18218
		public const int MemberFieldNumber = 4;

		// Token: 0x0400472B RID: 18219
		private static readonly FieldCodec<Member> _repeated_member_codec = FieldCodec.ForMessage<Member>(34U, Bgs.Protocol.Channel.V2.Member.Parser);

		// Token: 0x0400472C RID: 18220
		private readonly RepeatedField<Member> member_ = new RepeatedField<Member>();
	}
}
