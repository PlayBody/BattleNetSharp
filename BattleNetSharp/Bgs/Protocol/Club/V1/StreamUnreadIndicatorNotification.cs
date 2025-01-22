using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000490 RID: 1168
	public sealed class StreamUnreadIndicatorNotification : IMessage<StreamUnreadIndicatorNotification>, IMessage, IEquatable<StreamUnreadIndicatorNotification>, IDeepCloneable<StreamUnreadIndicatorNotification>, IBufferMessage
	{
		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x060071EE RID: 29166 RVA: 0x001BB500 File Offset: 0x001B9700
		[DebuggerNonUserCode]
		public static MessageParser<StreamUnreadIndicatorNotification> Parser
		{
			get
			{
				return StreamUnreadIndicatorNotification._parser;
			}
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x060071EF RID: 29167 RVA: 0x001BB518 File Offset: 0x001B9718
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x060071F0 RID: 29168 RVA: 0x001BB53C File Offset: 0x001B973C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamUnreadIndicatorNotification.Descriptor;
			}
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x001BB553 File Offset: 0x001B9753
		[DebuggerNonUserCode]
		public StreamUnreadIndicatorNotification()
		{
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x001BB560 File Offset: 0x001B9760
		[DebuggerNonUserCode]
		public StreamUnreadIndicatorNotification(StreamUnreadIndicatorNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.event_ = ((other.event_ != null) ? other.event_.Clone() : null);
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x001BB5F4 File Offset: 0x001B97F4
		[DebuggerNonUserCode]
		public StreamUnreadIndicatorNotification Clone()
		{
			return new StreamUnreadIndicatorNotification(this);
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x060071F4 RID: 29172 RVA: 0x001BB60C File Offset: 0x001B980C
		// (set) Token: 0x060071F5 RID: 29173 RVA: 0x001BB624 File Offset: 0x001B9824
		[DebuggerNonUserCode]
		public MemberId AgentId
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

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x060071F6 RID: 29174 RVA: 0x001BB630 File Offset: 0x001B9830
		// (set) Token: 0x060071F7 RID: 29175 RVA: 0x001BB661 File Offset: 0x001B9861
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = StreamUnreadIndicatorNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x060071F8 RID: 29176 RVA: 0x001BB67C File Offset: 0x001B987C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x001BB699 File Offset: 0x001B9899
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x060071FA RID: 29178 RVA: 0x001BB6AC File Offset: 0x001B98AC
		// (set) Token: 0x060071FB RID: 29179 RVA: 0x001BB6C4 File Offset: 0x001B98C4
		[DebuggerNonUserCode]
		public StreamEventTime Event
		{
			get
			{
				return this.event_;
			}
			set
			{
				this.event_ = value;
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x060071FC RID: 29180 RVA: 0x001BB6D0 File Offset: 0x001B98D0
		// (set) Token: 0x060071FD RID: 29181 RVA: 0x001BB6E8 File Offset: 0x001B98E8
		[DebuggerNonUserCode]
		public StreamMessage Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x001BB6F4 File Offset: 0x001B98F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamUnreadIndicatorNotification);
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x001BB714 File Offset: 0x001B9914
		[DebuggerNonUserCode]
		public bool Equals(StreamUnreadIndicatorNotification other)
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
						bool flag5 = this.ClubId != other.ClubId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Event, other.Event);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Message, other.Message);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x001BB7CC File Offset: 0x001B99CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool flag2 = this.event_ != null;
			if (flag2)
			{
				num ^= this.Event.GetHashCode();
			}
			bool flag3 = this.message_ != null;
			if (flag3)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x001BB874 File Offset: 0x001B9A74
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x001BB88C File Offset: 0x001B9A8C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x001BB898 File Offset: 0x001B9A98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ClubId);
			}
			bool flag2 = this.event_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Event);
			}
			bool flag3 = this.message_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Message);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x001BB958 File Offset: 0x001B9B58
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool flag2 = this.event_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Event);
			}
			bool flag3 = this.message_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x001BBA0C File Offset: 0x001B9C0C
		[DebuggerNonUserCode]
		public void MergeFrom(StreamUnreadIndicatorNotification other)
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
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool flag4 = other.event_ != null;
				if (flag4)
				{
					bool flag5 = this.event_ == null;
					if (flag5)
					{
						this.Event = new StreamEventTime();
					}
					this.Event.MergeFrom(other.Event);
				}
				bool flag6 = other.message_ != null;
				if (flag6)
				{
					bool flag7 = this.message_ == null;
					if (flag7)
					{
						this.Message = new StreamMessage();
					}
					this.Message.MergeFrom(other.Message);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x001BBB14 File Offset: 0x001B9D14
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x001BBB20 File Offset: 0x001B9D20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 24U)
						{
							goto IL_002F;
						}
						this.ClubId = input.ReadUInt64();
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new MemberId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						goto IL_002F;
					}
					bool flag2 = this.message_ == null;
					if (flag2)
					{
						this.Message = new StreamMessage();
					}
					input.ReadMessage(this.Message);
				}
				else
				{
					bool flag3 = this.event_ == null;
					if (flag3)
					{
						this.Event = new StreamEventTime();
					}
					input.ReadMessage(this.Event);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003437 RID: 13367
		private static readonly MessageParser<StreamUnreadIndicatorNotification> _parser = new MessageParser<StreamUnreadIndicatorNotification>(() => new StreamUnreadIndicatorNotification());

		// Token: 0x04003438 RID: 13368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003439 RID: 13369
		private int _hasBits0;

		// Token: 0x0400343A RID: 13370
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400343B RID: 13371
		private MemberId agentId_;

		// Token: 0x0400343C RID: 13372
		public const int ClubIdFieldNumber = 3;

		// Token: 0x0400343D RID: 13373
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400343E RID: 13374
		private ulong clubId_;

		// Token: 0x0400343F RID: 13375
		public const int EventFieldNumber = 4;

		// Token: 0x04003440 RID: 13376
		private StreamEventTime event_;

		// Token: 0x04003441 RID: 13377
		public const int MessageFieldNumber = 5;

		// Token: 0x04003442 RID: 13378
		private StreamMessage message_;
	}
}
