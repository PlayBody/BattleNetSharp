using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2.Server
{
	// Token: 0x020006A6 RID: 1702
	public sealed class MemberStateChangedNotification : IMessage<MemberStateChangedNotification>, IMessage, IEquatable<MemberStateChangedNotification>, IDeepCloneable<MemberStateChangedNotification>, IBufferMessage
	{
		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x06009DDD RID: 40413 RVA: 0x0026611C File Offset: 0x0026431C
		[DebuggerNonUserCode]
		public static MessageParser<MemberStateChangedNotification> Parser
		{
			get
			{
				return MemberStateChangedNotification._parser;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x06009DDE RID: 40414 RVA: 0x00266134 File Offset: 0x00264334
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelListenerReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x06009DDF RID: 40415 RVA: 0x00266158 File Offset: 0x00264358
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberStateChangedNotification.Descriptor;
			}
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x0026616F File Offset: 0x0026436F
		[DebuggerNonUserCode]
		public MemberStateChangedNotification()
		{
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x00266184 File Offset: 0x00264384
		[DebuggerNonUserCode]
		public MemberStateChangedNotification(MemberStateChangedNotification other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.assignment_ = other.assignment_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x002661F4 File Offset: 0x002643F4
		[DebuggerNonUserCode]
		public MemberStateChangedNotification Clone()
		{
			return new MemberStateChangedNotification(this);
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x0026620C File Offset: 0x0026440C
		// (set) Token: 0x06009DE4 RID: 40420 RVA: 0x00266224 File Offset: 0x00264424
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

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x00266230 File Offset: 0x00264430
		// (set) Token: 0x06009DE6 RID: 40422 RVA: 0x00266248 File Offset: 0x00264448
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

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x00266254 File Offset: 0x00264454
		[DebuggerNonUserCode]
		public RepeatedField<MemberStateAssignment> Assignment
		{
			get
			{
				return this.assignment_;
			}
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x0026626C File Offset: 0x0026446C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberStateChangedNotification);
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x0026628C File Offset: 0x0026448C
		[DebuggerNonUserCode]
		public bool Equals(MemberStateChangedNotification other)
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
							bool flag6 = !this.assignment_.Equals(other.assignment_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x00266324 File Offset: 0x00264524
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
			num ^= this.assignment_.GetHashCode();
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x0026639C File Offset: 0x0026459C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x002663B4 File Offset: 0x002645B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x002663C0 File Offset: 0x002645C0
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
			this.assignment_.WriteTo(ref output, MemberStateChangedNotification._repeated_assignment_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x00266448 File Offset: 0x00264648
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
			num += this.assignment_.CalculateSize(MemberStateChangedNotification._repeated_assignment_codec);
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x002664D0 File Offset: 0x002646D0
		[DebuggerNonUserCode]
		public void MergeFrom(MemberStateChangedNotification other)
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
				this.assignment_.Add(other.assignment_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x0026658F File Offset: 0x0026478F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x0026659C File Offset: 0x0026479C
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
						if (num3 != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.assignment_.AddEntriesFrom(ref input, MemberStateChangedNotification._repeated_assignment_codec);
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

		// Token: 0x0400473D RID: 18237
		private static readonly MessageParser<MemberStateChangedNotification> _parser = new MessageParser<MemberStateChangedNotification>(() => new MemberStateChangedNotification());

		// Token: 0x0400473E RID: 18238
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400473F RID: 18239
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004740 RID: 18240
		private GameAccountHandle agentId_;

		// Token: 0x04004741 RID: 18241
		public const int ChannelIdFieldNumber = 3;

		// Token: 0x04004742 RID: 18242
		private ChannelId channelId_;

		// Token: 0x04004743 RID: 18243
		public const int AssignmentFieldNumber = 5;

		// Token: 0x04004744 RID: 18244
		private static readonly FieldCodec<MemberStateAssignment> _repeated_assignment_codec = FieldCodec.ForMessage<MemberStateAssignment>(42U, MemberStateAssignment.Parser);

		// Token: 0x04004745 RID: 18245
		private readonly RepeatedField<MemberStateAssignment> assignment_ = new RepeatedField<MemberStateAssignment>();
	}
}
